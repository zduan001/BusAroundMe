using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAroundMe
{
    public static class Constants
    {
        public static string AppKey = "TEST";

        public static string BaseUri = "http://api.onebusaway.org/api/where/";

        public static string Agency_With_Coverage = "agencies-with-coverage";

        public static string Arrivals_and_Departures_for_Stop = "arrivals-and-departures-for-stop";

        public static string Stops_For_Location = "stops-for-location";

        public static string Arrivals_And_Departures_For_Stop = "arrivals-and-departures-for-stop";

        public static string Current_Time = "current-time";

        public static string Stops_For_Route = "stops-for-route";

        public static string VersionStr = "version";

        public static string CurrentVersionValue = "2";

        public static string XML = ".xml?";

        public static string Lat = "lat";

        public static string Lon = "lon";

        public static string Key = "key";

        public static DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}
