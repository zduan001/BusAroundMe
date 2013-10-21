using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusAroundMe
{
    public class RestXmlDataService : IDataAccessService
    {
        public static RestXmlDataService Current
        {
            get
            {
                return new RestXmlDataService();
            }
        }
        /// <summary>
        /// Return a list of bus routes for one bus stop
        /// </summary>
        /// <param name="stop"></param>
        /// <returns></returns>
        public async Task<List<BusRoute>> GetBusRoutesAtAStop(BusStop stop)
        {

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 1000000;

            string ArrivalAndDepartureForStopAddree = Constants.BaseUri +
                Constants.Arrivals_and_Departures_for_Stop +
                "/" + stop.Id +
                Constants.XML +
                Constants.Key + "=" + Constants.AppKey;

            HttpResponseMessage arrivalDepartureResponse = await client.GetAsync(ArrivalAndDepartureForStopAddree);

            if (arrivalDepartureResponse.IsSuccessStatusCode)
            {
                XDocument document = XDocument.Parse(arrivalDepartureResponse.Content.ReadAsStringAsync().Result);

                var cTime = from t in document.Descendants("response")
                            select new
                            {
                                ct = t.Element("currentTime").Value,
                            };

                var time = cTime.FirstOrDefault();
                DateTime currentTime = Constants.Epoch.AddMilliseconds(double.Parse(time.ct));

                var arrivalDepartureTimes = from ad in document.Descendants("arrivalAndDeparture")
                                            select new
                                            {
                                                RouteId = ad.Element("routeId").Value,
                                                RouteShortName = ad.Element("routeShortName").Value,
                                                TripId = ad.Element("tripId").Value,
                                                TripHeadsign = ad.Element("tripHeadsign").Value,
                                                StopId = ad.Element("stopId").Value,
                                                PredictedArrivalTime = ad.Element("predictedArrivalTime").Value,
                                                ScheduledArrivalTime = ad.Element("scheduledArrivalTime").Value,
                                                PredictedDepartureTime = ad.Element("predictedDepartureTime").Value,
                                                ScheduledDepartureTime = ad.Element("scheduledDepartureTime").Value,
                                                status = ad.Element("status").Value,
                                            };

                //Clear ArrivalDepartures list before populate.
                foreach (BusRoute route in stop.Routes)
                {
                    route.ArrivalDepartures.Clear();
                }

                foreach (var adTime in arrivalDepartureTimes)
                {
                    long parrivalLong, sarrivalLong, pdepartureLong, sdepartureLong;
                    long.TryParse(adTime.PredictedArrivalTime, out parrivalLong);
                    long.TryParse(adTime.ScheduledArrivalTime, out sarrivalLong);
                    long.TryParse(adTime.PredictedDepartureTime, out pdepartureLong);
                    long.TryParse(adTime.ScheduledDepartureTime, out sdepartureLong);

                    DateTime parrivalTime, sarrivalTime, pdepartureTime, sdepartureTime;

                    parrivalTime = Constants.Epoch.AddMilliseconds(parrivalLong);
                    sarrivalTime = Constants.Epoch.AddMilliseconds(sarrivalLong);
                    pdepartureTime = Constants.Epoch.AddMilliseconds(pdepartureLong);
                    sdepartureTime = Constants.Epoch.AddMilliseconds(sdepartureLong);


                    BusRoute r = null;
                    foreach (BusRoute route in stop.Routes)
                    {
                        if (route.Id == adTime.RouteId)
                        {
                            r = route;
                            break;
                        }
                    }

                    if (r != null)
                    {
                        r.ArrivalDepartures.Add(new BusRoute.ArrivalDeaprture()
                        {
                            TripId = adTime.TripId,
                            StopId = adTime.StopId,
                            Status = adTime.status,
                            PredictedArrivalTime = parrivalTime,
                            ScheduledArrivalTime = sarrivalTime,
                            PredictedDepartureTime = pdepartureTime,
                            ScheduledDepartureTime = sdepartureTime,
                            DepartureIn = sdepartureTime - currentTime
                        });
                    }
                }
                return stop.Routes;
            }
            return null;
        }

        public async Task<Collection<double>> GetPathForRoute(string routeId)
        {
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 1000000;

            string stopsForRouteAddress = Constants.BaseUri +
                Constants.Stops_For_Route +
                "/" + routeId +
                Constants.XML +
                Constants.Key + "=" + Constants.AppKey + "&" +
                Constants.VersionStr + "=" + Constants.CurrentVersionValue;

            HttpResponseMessage stopsForRouteResponse = await client.GetAsync(stopsForRouteAddress);
            if (stopsForRouteResponse.IsSuccessStatusCode)
            {
                XDocument document = XDocument.Parse(stopsForRouteResponse.Content.ReadAsStringAsync().Result);

                ////////////////////////////////////////////////
                //
                //  Parse google map encoded polyline string wiht Linq
                //
                ////////////////////////////////////////////////
                var polylines = from line in document.Descendants("encodedPolyline")
                                select new
                                {
                                    PointsStr = line.Element("points").Value,
                                    Length = line.Element("length").Value,
                                };

                //////////////////////////////////////////
                //
                //  Create PolyLine of Bus Routes.
                //
                ///////////////////////////////////////////////
                var polyline = polylines.FirstOrDefault();
                Collection<double> points = DecodePolyline(polyline.PointsStr);

                return points;
            }
            return null;
        }

        public async Task<BusStop> GetDepartureTimeAtStop(string stopId)
        {
            BusStop busStopRet = null;

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 1000000;

            string arrivalAndDepartureForStopAddree = Constants.BaseUri +
                Constants.Arrivals_and_Departures_for_Stop +
                "/" + stopId +
                Constants.XML +
                Constants.Key + "=" + Constants.AppKey;

            HttpResponseMessage arrivalDepartureResponse = await client.GetAsync(arrivalAndDepartureForStopAddree);

            if (arrivalDepartureResponse.IsSuccessStatusCode)
            {
                XDocument document = XDocument.Parse(arrivalDepartureResponse.Content.ReadAsStringAsync().Result);

                ////////////////////////////////////////////////
                //
                //  Parse CurrentTime wiht Linq
                //
                ////////////////////////////////////////////////
                var cTime = from t in document.Descendants("response")
                            select new
                            {
                                ct = t.Element("currentTime").Value,
                            };

                ////////////////////////////////////////////////////////////
                //
                //  Create CurrentTime.
                //
                ////////////////////////////////////////////////////////////
                var time = cTime.FirstOrDefault();
                DateTime currentTime = Constants.Epoch.AddMilliseconds(double.Parse(time.ct));

                ////////////////////////////////////////////////////////
                //
                //  Parse Stop info with Linq
                //
                ////////////////////////////////////////////////////////
                var stops = from busStop in document.Descendants("stop")
                            select new
                            {
                                StopId = string.IsNullOrEmpty((string)busStop.Element("id")) ? string.Empty : busStop.Element("id").Value,
                                Lat = string.IsNullOrEmpty((string)busStop.Element("lat")) ? string.Empty : busStop.Element("lat").Value,
                                Lon = string.IsNullOrEmpty((string)busStop.Element("lon")) ? string.Empty : busStop.Element("lon").Value,
                                Direction = string.IsNullOrEmpty((string)busStop.Element("direction")) ? string.Empty : busStop.Element("direction").Value,
                                Name = string.IsNullOrEmpty((string)busStop.Element("name")) ? string.Empty : busStop.Element("name").Value,
                                Code = string.IsNullOrEmpty((string)busStop.Element("code")) ? string.Empty : busStop.Element("code").Value,
                                LocationType = string.IsNullOrEmpty((string)busStop.Element("code")) ? string.Empty : busStop.Element("code").Value,
                            };

                //////////////////////////////////////////
                //
                //  Create Bust Stop from http response.
                //
                ///////////////////////////////////////////////
                var stop = stops.FirstOrDefault();
                double lat, lon;
                int code, locationType;

                Double.TryParse(stop.Lon, out lon);
                Double.TryParse(stop.Lat, out lat);
                int.TryParse(stop.Code, out code);
                int.TryParse(stop.LocationType, out locationType);

                busStopRet = new BusStop()
                {
                    Id = stop.StopId,
                    Lat = lat,
                    Lon = lon,
                    Direction = stop.Direction,
                    Name = stop.Name,
                    Code = code,
                    LocationType = locationType
                };

                //////////////////////////////////////////////////////////////
                //
                //  Parse bus routes with Linq
                //
                //////////////////////////////////////////////////////////////
                var routes = from busRoute in document.Descendants("route")
                             select new
                             {
                                 RouteID = string.IsNullOrEmpty((string)busRoute.Element("id")) ? string.Empty : busRoute.Element("id").Value,
                                 ShortName = string.IsNullOrEmpty((string)busRoute.Element("shortName")) ? string.Empty : busRoute.Element("shortName").Value,
                                 Description = string.IsNullOrEmpty((string)busRoute.Element("description")) ? string.Empty : busRoute.Element("description").Value,
                                 Type = string.IsNullOrEmpty((string)busRoute.Element("type")) ? string.Empty : busRoute.Element("type").Value,
                                 Url = string.IsNullOrEmpty((string)busRoute.Element("url")) ? string.Empty : busRoute.Element("url").Value,
                             };

                ////////////////////////////////////////
                //
                //  Create and add bus routes
                //
                ////////////////////////////////////////
                busStopRet.Routes.Clear();
                foreach (var route in routes)
                {
                    int routeType;
                    int.TryParse(route.Type, out routeType);

                    busStopRet.Routes.Add(
                        new BusRoute()
                        {
                            Id = route.RouteID,
                            ShortName = route.ShortName,
                            Description = route.Description,
                            Type = routeType,
                            Url = string.IsNullOrEmpty(route.Url) ? null : new Uri(route.Url)
                        });
                }

                //////////////////////////////////////////////////////////////
                //
                //  Parse bus arrival and departures with Linq
                //
                //////////////////////////////////////////////////////////////
                var arrivalDepartureTimes = from ad in document.Descendants("arrivalAndDeparture")
                                            select new
                                            {
                                                RouteId = ad.Element("routeId").Value,
                                                RouteShortName = ad.Element("routeShortName").Value,
                                                TripId = ad.Element("tripId").Value,
                                                TripHeadsign = ad.Element("tripHeadsign").Value,
                                                StopId = ad.Element("stopId").Value,
                                                PredictedArrivalTime = ad.Element("predictedArrivalTime").Value,
                                                ScheduledArrivalTime = ad.Element("scheduledArrivalTime").Value,
                                                PredictedDepartureTime = ad.Element("predictedDepartureTime").Value,
                                                ScheduledDepartureTime = ad.Element("scheduledDepartureTime").Value,
                                                status = ad.Element("status").Value,
                                            };

                ////////////////////////////////////////////////////////
                //
                //  Create and Add Arrival Departure Times
                //
                ////////////////////////////////////////////////////////
                BusRoute r = null;
                foreach (var adTime in arrivalDepartureTimes)
                {
                    long parrivalLong, sarrivalLong, pdepartureLong, sdepartureLong;
                    long.TryParse(adTime.PredictedArrivalTime, out parrivalLong);
                    long.TryParse(adTime.ScheduledArrivalTime, out sarrivalLong);
                    long.TryParse(adTime.PredictedDepartureTime, out pdepartureLong);
                    long.TryParse(adTime.ScheduledDepartureTime, out sdepartureLong);

                    DateTime parrivalTime, sarrivalTime, pdepartureTime, sdepartureTime;

                    parrivalTime = Constants.Epoch.AddMilliseconds(parrivalLong);
                    sarrivalTime = Constants.Epoch.AddMilliseconds(sarrivalLong);
                    pdepartureTime = Constants.Epoch.AddMilliseconds(pdepartureLong);
                    sdepartureTime = Constants.Epoch.AddMilliseconds(sdepartureLong);

                    r = null;
                    foreach (BusRoute route in busStopRet.Routes)
                    {
                        if (route.Id == adTime.RouteId)
                        {
                            r = route;
                            break;
                        }
                    }

                    if (r != null)
                    {
                        r.ArrivalDepartures.Add(new BusRoute.ArrivalDeaprture()
                        {
                            TripId = adTime.TripId,
                            StopId = adTime.StopId,
                            Status = adTime.status,
                            PredictedArrivalTime = parrivalTime,
                            ScheduledArrivalTime = sarrivalTime,
                            PredictedDepartureTime = pdepartureTime,
                            ScheduledDepartureTime = sdepartureTime,
                            DepartureIn = sdepartureTime - currentTime
                        });
                    }
                }
            }
            return busStopRet;
        }

        public async Task<List<BusStop>> GetBusStopsAtALocation(double latitude, double longitude)
        {
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 1000000;

            string StopsForLocationAddress = Constants.BaseUri +
                Constants.Stops_For_Location +
                Constants.XML +
                Constants.Key + "=" + Constants.AppKey + "&" +
                Constants.Lat + "=" + latitude.ToString() + "&" +
                Constants.Lon + "=" + longitude.ToString();

            HttpResponseMessage busStopsResponse = await client.GetAsync(StopsForLocationAddress);

            if (busStopsResponse.IsSuccessStatusCode)
            {
                XDocument document = XDocument.Parse(busStopsResponse.Content.ReadAsStringAsync().Result);
                var busStops = from stop in document.Descendants("stop")
                               select new
                               {
                                   Id = stop.Element("id").Value,
                                   Lat = stop.Element("lat").Value,
                                   Lon = stop.Element("lon").Value,
                                   Direction = string.IsNullOrEmpty((string)stop.Element("direction")) ? string.Empty : stop.Element("direction").Value,
                                   Name = string.IsNullOrEmpty((string)stop.Element("name")) ? string.Empty : stop.Element("name").Value,
                                   Code = string.IsNullOrEmpty((string)stop.Element("code")) ? string.Empty : stop.Element("code").Value,
                                   LocationType = string.IsNullOrEmpty((string)stop.Element("locationType")) ? string.Empty : stop.Element("locationType").Value,
                                   Routes = stop.Element("routes").ToString(),
                               };

                List<BusStop> stops = new List<BusStop>();

                foreach (var busStop in busStops)
                {
                    double lat, lon;
                    int code, locationType;

                    Double.TryParse(busStop.Lon, out lon);
                    Double.TryParse(busStop.Lat, out lat);
                    int.TryParse(busStop.Code, out code);
                    int.TryParse(busStop.LocationType, out locationType);

                    BusStop stop = new BusStop()
                    {
                        Id = busStop.Id,
                        Lat = lat,
                        Lon = lon,
                        Direction = busStop.Direction,
                        Name = busStop.Name,
                        Code = code,
                        LocationType = locationType
                    };

                    XDocument routesList = XDocument.Parse(busStop.Routes);
                    var routes = from route in routesList.Descendants("route")
                                 select new
                                 {
                                     Id = route.Element("id").Value,
                                     ShortName = string.IsNullOrEmpty((string)route.Element("shortName")) ? string.Empty : route.Element("shortName").Value,
                                     Description = string.IsNullOrEmpty((string)route.Element("description")) ? string.Empty : route.Element("description").Value,
                                     RouteType = route.Element("type").Value,
                                     Url = string.IsNullOrEmpty((string)route.Element("url")) ? string.Empty : route.Element("url").Value,
                                 };
                    foreach (var route in routes)
                    {
                        int routeType;
                        int.TryParse(route.RouteType, out routeType);

                        stop.Routes.Add(
                            new BusRoute()
                            {
                                Id = route.Id,
                                ShortName = route.ShortName,
                                Description = route.Description,
                                Type = routeType,
                                Url = string.IsNullOrEmpty(route.Url) ? null : new Uri(route.Url)
                            });
                    }

                    stops.Add(stop);
                }
                return stops;
            }
            return null;
        }

        public Collection<Double> DecodePolyline(string polyline)
        {
            if (polyline == null || polyline == "") return null;

            char[] polylinechars = polyline.ToCharArray();
            int index = 0;
            Collection<Double> points = new Collection<Double>();
            int currentLat = 0;
            int currentLng = 0;
            int next5bits;
            int sum;
            int shifter;

            while (index < polylinechars.Length)
            {
                // calculate next latitude
                sum = 0;
                shifter = 0;
                do
                {
                    next5bits = (int)polylinechars[index++] - 63;
                    sum |= (next5bits & 31) << shifter;
                    shifter += 5;
                } while (next5bits >= 32 && index < polylinechars.Length);

                if (index >= polylinechars.Length)
                    break;

                currentLat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

                //calculate next longitude
                sum = 0;
                shifter = 0;
                do
                {
                    next5bits = (int)polylinechars[index++] - 63;
                    sum |= (next5bits & 31) << shifter;
                    shifter += 5;
                } while (next5bits >= 32 && index < polylinechars.Length);

                if (index >= polylinechars.Length && next5bits >= 32)
                    break;

                currentLng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

                points.Add(Convert.ToDouble(currentLat) / 100000.0);
                points.Add(Convert.ToDouble(currentLng) / 100000.0);
            }

            return points;
        }

    }
}
