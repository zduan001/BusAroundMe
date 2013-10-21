using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BusAroundMe;
using Windows.Storage.Streams;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;

namespace BusAroundMe
{
    public class XmlDesDataService : IDataAccessService
    {
        public XmlDesDataService()
        {
            LocalDeserializer<Agency> agencySerializer = new LocalDeserializer<Agency>();
            LocalDeserializer<BusRoute> busRouteSerializer = new LocalDeserializer<BusRoute>();
            LocalDeserializer<BusStop> busStopSerializer = new LocalDeserializer<BusStop>();
            LocalDeserializer<BusStopForRoute> busStopForRouteSerializer = new LocalDeserializer<BusStopForRoute>();
            LocalDeserializer<GeoLocationPoint> geoLocationPointSerializer = new LocalDeserializer<GeoLocationPoint>();
        }

        private List<Agency> agencies;
        public List<Agency> Agencies
        {
            get
            {
                if (agencies == null)
                {
                    Task<List<Agency>> agencyTask = LocalDeserializer<Agency>.GetData();
                    agencyTask.Wait();
                    agencies = agencyTask.Result;
                }
                return agencies;
            }
        }

        private List<BusRoute> busRoutes;
        public List<BusRoute> BusRoutes
        {
            get
            {
                if (busRoutes == null)
                {
                    Task<List<BusRoute>> busRouteTask = LocalDeserializer<BusRoute>.GetData();
                    busRouteTask.Wait();
                    busRoutes = busRouteTask.Result;
                }
                return busRoutes;
            }
        }

        public List<BusStop> busStops;
        public List<BusStop> BusStops
        {
            get
            {
                if (busStops == null)
                {

                    Task<List<BusStop>> busStopTask = LocalDeserializer<BusStop>.GetData();
                    busStopTask.Wait();
                    busStops = busStopTask.Result;
                }
                return busStops;
            }
        }

        public List<BusStopForRoute> busStopForRoutes;
        public List<BusStopForRoute> BusStopForRoutes
        {
            get
            {
                if (busStopForRoutes == null)
                {
                    Task<List<BusStopForRoute>> busStopForRouteTask = LocalDeserializer<BusStopForRoute>.GetData();
                    busStopForRouteTask.Wait();
                    busStopForRoutes = busStopForRouteTask.Result;
                }
                return busStopForRoutes;
            }
        }

        public List<GeoLocationPoint> geoLocationPoints;
        public List<GeoLocationPoint> GeoLocationPoints
        {
            get
            {
                if (geoLocationPoints == null)
                {
                    Task<List<GeoLocationPoint>> geoLocationPointTask = LocalDeserializer<GeoLocationPoint>.GetData();
                    geoLocationPointTask.Wait();
                    geoLocationPoints = geoLocationPointTask.Result;
                }
                return geoLocationPoints;
            }
        }

        #region interface method
        public System.Collections.ObjectModel.Collection<double> DecodePolyline(string polyline)
        {
            return null;
        }

        public Task<List<BusAroundMe.BusRoute>> GetBusRoutesAtAStop(BusAroundMe.BusStop stop)
        {
            return Task<List<BusRoute>>.Factory.StartNew(() => this.BusRoutes);
        }

        public Task<List<BusAroundMe.BusStop>> GetBusStopsAtALocation(double latitude, double longitude)
        {
            return Task<List<BusStop>>.Factory.StartNew(() => this.BusStops);
        }

        public Task<BusAroundMe.BusStop> GetDepartureTimeAtStop(string stopId)
        {
            return Task<BusStop>.Factory.StartNew(() => this.BusStops[0]);
        }

        public Task<System.Collections.ObjectModel.Collection<double>> GetPathForRoute(string routeId)
        {
            return null;
        }
        #endregion


    }

    public class LocalDeserializer<T> where T : new()
    {
        public static async Task<List<T>> GetData()
        {
            List<T> listObject = new List<T>();
            Type t = typeof(T);
            XDocument document = await ReadXml(t.Name + ".xml");

            var agencies = from p in document.Descendants(t.Name) select p;

            foreach (XElement agency in agencies)
            {
                T o = (T)Activator.CreateInstance(t);

                foreach (PropertyInfo propertyInfo in t.GetTypeInfo().DeclaredProperties)
                {
                    if (propertyInfo.CanWrite)
                    {
                        if (propertyInfo.PropertyType == typeof(System.Boolean))
                        {
                            t.GetTypeInfo().GetDeclaredProperty(propertyInfo.Name).SetValue(o, bool.Parse(agency.Element(propertyInfo.Name).Value));
                        }
                        else if (propertyInfo.PropertyType == typeof(int))
                        {
                            t.GetTypeInfo().GetDeclaredProperty(propertyInfo.Name).SetValue(o, int.Parse(agency.Element(propertyInfo.Name).Value));
                        }
                        else if (propertyInfo.PropertyType == typeof(double))
                        {
                            t.GetTypeInfo().GetDeclaredProperty(propertyInfo.Name).SetValue(o, double.Parse(agency.Element(propertyInfo.Name).Value));
                        }
                        else if (propertyInfo.PropertyType == typeof(float))
                        {
                            t.GetTypeInfo().GetDeclaredProperty(propertyInfo.Name).SetValue(o, float.Parse(agency.Element(propertyInfo.Name).Value));
                        }
                        else if (propertyInfo.PropertyType == typeof(string))
                        {
                            t.GetTypeInfo().GetDeclaredProperty(propertyInfo.Name).SetValue(o, agency.Element(propertyInfo.Name).Value);
                        }
                    }
                }
                listObject.Add(o);
            }
            return listObject;
        }


        private static async Task<XDocument> ReadXml(string xmlFileName)
        {
            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("XmlDesDataService\\" + xmlFileName);
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
    }
}
