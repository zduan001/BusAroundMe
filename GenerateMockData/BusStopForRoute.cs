using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAroundMe
{
    public class BusStopForRoute : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        private string routeId;
        public string RouteId
        {
            get { return routeId; }
            set { routeId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string stopId;
        public string StopId
        {
            get { return stopId; }
            set { stopId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private BusRoute route;
        public BusRoute Route
        {
            get { return route; }
            set
            {
                route = value;
                NotifyPropertyChanged("Route");
                NotifyPropertyChanged("Stop");
                NotifyPropertyChanged("StopName");
                NotifyPropertyChanged("RouteShortName");
                NotifyPropertyChanged("RouteDescription");
                NotifyPropertyChanged("DepartureDispayStr");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private BusStop stop;
        public BusStop Stop
        {
            get { return stop; }
            set
            {
                stop = value;
                NotifyPropertyChanged("Route");
                NotifyPropertyChanged("Stop");
                NotifyPropertyChanged("StopName");
                NotifyPropertyChanged("RouteShortName");
                NotifyPropertyChanged("RouteDescription");
                NotifyPropertyChanged("DepartureDispayStr");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string StopName
        {
            get
            {
                if (stop != null)
                    return stop.Name;
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RouteShortName
        {
            get
            {
                if (route != null)
                    return route.ShortName;
                return string.Empty;
            }
        }

        public string RouteDescription
        {
            get
            {
                if (route != null)
                    return route.Description;
                return string.Empty;
            }
        }

        public String DepartureDispayStr
        {
            get
            {
                string displayStr = string.Empty;
                if (route != null)
                {
                    foreach (BusRoute.ArrivalDeaprture ad in route.ArrivalDepartures)
                    {
                        if (displayStr.Length > 0)
                        {
                            displayStr += ", ";
                        }
                        displayStr += ad.DepartureIn.Minutes.ToString() + "min";
                    }
                }

                displayStr = string.IsNullOrEmpty(displayStr) ? "No schedual available at this time" : displayStr;
                return displayStr;
            }
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
