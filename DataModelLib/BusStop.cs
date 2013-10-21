using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAroundMe
{
    public class BusStop
    {

        /// <summary>
        /// 
        /// </summary>
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private double lat;
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private double lon;
        public double Lon
        {
            get { return lon; }
            set { lon = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string direction;
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        
        /// <summary>
        /// Location Type of the bust stop.
        /// </summary>
        private int locationType;
        public int LocationType
        {
            get { return locationType; }
            set { locationType = value; }
        }

        /// <summary>
        /// Bus routes have stops at this bus stop.
        /// </summary>
        private List<BusRoute> routes;
        public List<BusRoute> Routes
        {
            get 
            {
                if (routes == null)
                {
                    routes = new List<BusRoute>();
                }
                return routes; 
            }
            set 
            { 
                routes = value; 
            }
        }

        public string RoutesStr
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (BusRoute route in Routes)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(route.ShortName);
                }

                return sb.ToString();
            }
        }
    }
}
