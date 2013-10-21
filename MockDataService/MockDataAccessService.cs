using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusAroundMe;
using Windows.Storage.Streams;
using System.Collections.ObjectModel;

namespace MockDataService
{
    public class MockDataAccessService : IDataAccessService
    {
        /// <summary>
        /// ToDo: move this static field somewhere common.
        /// </summary>
        public static DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        #region static current object
        public static MockDataAccessService Current
        {
            get
            {
                return new MockDataAccessService();
            }
        }
        #endregion

        #region propertyies
        private List<BusStop> busStops;
        public List<BusStop> BusStops
        {
            get 
            {
                if (busStops == null)
                {
                    Task<List<BusStop>> task = GetAllBusStops();
                    task.Wait();
                    busStops = task.Result as List<BusStop>;
                }
                return busStops; 
            }
        }

        private List<BusRoute> busRoutes;
        public List<BusRoute> BusRoutes
        {
            get 
            {
                if (busRoutes == null)
                {
                    Task<List<BusRoute>> task = GetAllBusRoutes();
                    task.Wait();
                    busRoutes = task.Result as List<BusRoute>;
                }
                return busRoutes; 
            }
        }

        private List<BusStopAndRoutePair> busStopAndRoutePair;
        public List<BusStopAndRoutePair> BusStopAndRoutePair
        {
            get 
            {
                if (busStopAndRoutePair == null)
                {
                    Task<List<BusStopAndRoutePair>> task = GetAllBusStopRoutePair();
                    task.Wait();
                    busStopAndRoutePair = task.Result as List<BusStopAndRoutePair>;
                }
                return busStopAndRoutePair; 
            }
        }
        #endregion

        #region interface
        public Collection<double> DecodePolyline(string polyline)
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

        public Task<List<BusRoute>> GetBusRoutesAtAStop(BusStop stop)
        {
            return Task<List<BusRoute>>.Factory.StartNew(() => GetListofBusRouteSnyc(stop));
        }
        private List<BusRoute> GetListofBusRouteSnyc(BusStop stop)
        {
            List<BusStopAndRoutePair> listOfPair = new List<BusStopAndRoutePair>();
            foreach (BusStopAndRoutePair pair in this.BusStopAndRoutePair)
            {
                if (pair.StopId == stop.Id)
                {
                    listOfPair.Add(pair);
                }
            }

            List<BusRoute> brList = new List<BusRoute>();
            foreach (BusRoute br in this.BusRoutes)
            {
                foreach (BusStopAndRoutePair pair in listOfPair)
                {
                    if (br.Id == pair.RoutId)
                    {
                        bool containsRoute = false;
                        foreach (BusRoute bRoute in brList)
                        {
                            if (bRoute.Id == br.Id)
                            {
                                containsRoute = true;
                                break;
                            }
                        }
                        if (!containsRoute)
                        {
                            brList.Add(br);
                        }
                    }
                }
            }
            return brList;
        }

        public Task<List<BusStop>> GetBusStopsAtALocation(double latitude, double longitude)
        {
            return Task<List<BusStop>>.Factory.StartNew(() => GetListOfBusStops());
        }
        private List<BusStop> GetListOfBusStops()
        {
            foreach (BusStop stop in this.BusStops)
            {
                stop.Routes.Clear();
                foreach (BusStopAndRoutePair pair in this.BusStopAndRoutePair)
                {
                    if (pair.StopId == stop.Id)
                    {
                        foreach (BusRoute route in this.BusRoutes)
                        {
                            if (route.Id == pair.RoutId)
                            {
                                bool containsRoute = false;
                                foreach (BusRoute br in stop.Routes)
                                {
                                    if (br.Id == route.Id)
                                    {
                                        containsRoute = true;
                                        break;
                                    }
                                }
                                if (!containsRoute)
                                {
                                    stop.Routes.Add(route);
                                }
                            }
                        }
                    }
                }
            }
            return this.BusStops;
        }


        public Task<BusStop> GetDepartureTimeAtStop(string stopId)
        {
            return Task<BusStop>.Factory.StartNew(()=> GetDepartureTimeAtAStop(stopId));
        }
        private BusStop GetDepartureTimeAtAStop(string stopId)
        {
            var stops = from s in this.BusStops
                        where s.Id == stopId
                        select s;

            BusStop stop = stops.FirstOrDefault();

            List<BusRoute> routes = GetListofBusRouteSnyc(stop);
            stop.Routes = routes;
            foreach (BusRoute r in stop.Routes)
            {
                r.ArrivalDepartures.Clear();
                foreach (BusStopAndRoutePair pair in this.BusStopAndRoutePair)
                {
                    if (r.Id == pair.RoutId)
                    {
                        BusRoute.ArrivalDeaprture ad = new BusRoute.ArrivalDeaprture()
                        {
                            TripId = "0",
                            StopId = stopId,
                            Status = "OK",
                            PredictedArrivalTime = Epoch.AddMilliseconds(pair.PredictedArrivalTime),
                            PredictedDepartureTime = Epoch.AddMilliseconds(pair.PredictedDepartureTime),
                            ScheduledArrivalTime = Epoch.AddMilliseconds(pair.ScheduledArrivalTime),
                            ScheduledDepartureTime = Epoch.AddMilliseconds(pair.ScheduledDepartureTime)
                        };
                        r.ArrivalDepartures.Add(ad);
                    }
                }
            }
            return stop;
        }

        public Task<Collection<double>> GetPathForRoute(string routeId)
        {
            return Task<Collection<double>>.Factory.StartNew(()=>GetGeoPointForABusRoute(routeId));
        }
        private Collection<double> GetGeoPointForABusRoute(string routeId)
        {
            var routes = from s in this.busRoutes
                         where s.Id == routeId
                         select s;
            BusRoute route = routes.FirstOrDefault();

            return DecodePolyline(route.EncodedPolyline);
        }
        #endregion

        #region helper methods

        private async Task<List<BusStopAndRoutePair>> GetAllBusStopRoutePair()
        {
            XDocument document = await ReadXml("ArrivalDepartureAdapter.xml");

            var pairs = from p in document.Descendants("SpGetArrivalAndDepartures")
                        select new
                        {
                            stopId = p.Element("stopId").Value,
                            lat = p.Element("lat").Value,
                            lon = p.Element("lon").Value,
                            direction = p.Element("direction").Value,
                            stopname = p.Element("name").Value,
                            locationtype = p.Element("locationtype").Value,
                            routeId = p.Element("routeId").Value,
                            routeShortName = p.Element("shortname").Value,
                            routeLongName = p.Element("longname").Value,
                            routedescription = p.Element("description").Value,
                            url = p.Element("url").Value,
                            predictedArrivalTime = p.Element("predictedArrivalTime").Value,
                            predictedDepartureTime = p.Element("predictedDepartureTime").Value,
                            scheduledArrivalTime = p.Element("scheduledArrivalTime").Value,
                            scheduledDepartureTime = p.Element("scheduledDepartureTime").Value,
                        };

            List<BusStopAndRoutePair> Bsrps = new List<BusStopAndRoutePair>();
            foreach (var pair in pairs)
            {
                BusStopAndRoutePair bsrp = new BusStopAndRoutePair()
                {
                    RoutId = pair.routeId,
                    StopId = pair.stopId,
                    PredictedArrivalTime = long.Parse(pair.predictedArrivalTime),
                    PredictedDepartureTime = long.Parse(pair.predictedDepartureTime),
                    ScheduledArrivalTime = long.Parse(pair.scheduledArrivalTime),
                    ScheduledDepartureTime = long.Parse(pair.scheduledDepartureTime),
                };

                Bsrps.Add(bsrp);
            }

            return Bsrps;
        }

        private async Task<List<BusRoute>> GetAllBusRoutes()
        {
            XDocument document = await ReadXml("BusRoutes.xml");
            var routes = from route in document.Descendants("SpGetBusRoutesAtAStop")
                         select new
                         {
                             RouteId = route.Element("routeid").Value,
                             ShortName = route.Element("shortname").Value,
                             LongName = route.Element("longname").Value,
                             Id = route.Element("id").Value,
                             EncodedPolyline = route.Element("encodedPolyline").Value,
                             Url = route.Element("url").Value,
                             Type = route.Element("type").Value,
                         };

            List<BusRoute> busRoutes = new List<BusRoute>();

            foreach (var r in routes)
            {
                BusRoute rt = new BusRoute()
                {
                    Id = r.Id,
                    ShortName = r.ShortName,
                    Type = int.Parse(r.Type),
                    Url = new Uri(r.Url),
                    Description = r.LongName,
                    EncodedPolyline = r.EncodedPolyline
                };

                busRoutes.Add(rt);
            }

            return busRoutes;
        }

        private async Task<List<BusStop>> GetAllBusStops()
        {
            List<BusStop> busStops = new List<BusStop>();

            XDocument document = await ReadXml("BusStops.xml");
            var stops = from s in document.Descendants("BusStop")
                        select new
                        {
                            Id = s.Element("Id").Value,
                            lat = s.Element("lat").Value,
                            lon = s.Element("lon").Value,
                            direction = s.Element("direction").Value,
                            stopname = s.Element("name").Value,
                            locationtype = s.Element("locationtype").Value,
                            code = s.Element("code").Value,
                        };

            foreach (var stop in stops)
            {
                BusStop bs = new BusStop()
                {
                    Id = stop.Id,
                    Lat = double.Parse(stop.lat),
                    Lon = double.Parse(stop.lon),
                    Direction = stop.direction,
                    Name = stop.stopname,
                    Code = int.Parse(stop.code),
                    LocationType = int.Parse(stop.locationtype)
                };

                busStops.Add(bs);
            }

            var stops1 = from s in document.Descendants("BusStop")
                         select s;

            foreach (var ss in stops1)
            {
                
            }
            return busStops;
        }

        private async Task<long> GetCurrentTime()
        {
            XDocument document = await ReadXml("CurrenTime.xml");

            var currentTimes = from c in document.Descendants("CurrentTime")
                              select new
                              {
                                  time = c.Element("currentTime"),
                              };
            var time = currentTimes.FirstOrDefault();
            long currentTime = long.Parse(time.time.ToString());
            return currentTime;
        }

        private async Task<XDocument> ReadXml(string xmlFileName)
        {
            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("MockDataService\\" + xmlFileName);
            using (var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
            {
                using (DataReader reader = new DataReader(stream))
                {
                    UInt64 size = stream.Size;
                    if (size < UInt32.MaxValue)
                    {
                        UInt32 numBytesLoaded = await reader.LoadAsync((UInt32)size);
                        string fileContent = reader.ReadString(numBytesLoaded);
                        XDocument xDocument = XDocument.Parse(fileContent);
                        return xDocument;
                    }
                }
            }
            return null;
        }
        #endregion
    }

    public class BusStopAndRoutePair
    {
        private string routId;
        public string RoutId
        {
            get { return routId; }
            set { routId = value; }
        }
        
        private string stopId;
        public string StopId
        {
            get { return stopId; }
            set { stopId = value; }
        }
        
        private long predictedArrivalTime;
        public long PredictedArrivalTime
        {
            get { return predictedArrivalTime; }
            set { predictedArrivalTime = value; }
        }
        
        private long predictedDepartureTime;
        public long PredictedDepartureTime
        {
            get { return predictedDepartureTime; }
            set { predictedDepartureTime = value; }
        }
        
        private long scheduledArrivalTime;
        public long ScheduledArrivalTime
        {
            get { return scheduledArrivalTime; }
            set { scheduledArrivalTime = value; }
        }
        
        private long scheduledDepartureTime;
        public long ScheduledDepartureTime
        {
            get { return scheduledDepartureTime; }
            set { scheduledDepartureTime = value; }
        }
    }
}
