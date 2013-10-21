using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAroundMe
{
    public class GeoLocationPoint
    {

        private double lon;
        public double Lon
        {
            get { return lon; }
            set { lon = value; }
        }


        private double lat;
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }
    }
}
