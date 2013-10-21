using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusAroundMe
{
    public class BusRoute
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
        private string shortName;
        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Uri url;
        [XmlIgnore]
        public Uri Url
        {
            get { return url; }
            set { url = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string encodedPolyline;
        public string EncodedPolyline
        {
            get { return encodedPolyline; }
            set { encodedPolyline = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private List<ArrivalDeaprture> arrivalDepartures;
        public List<ArrivalDeaprture> ArrivalDepartures
        {
            get 
            {
                if (arrivalDepartures == null)
                {
                    arrivalDepartures = new List<ArrivalDeaprture>();
                }
                return arrivalDepartures; 
            }
            set 
            { 
                arrivalDepartures = value; 
            }
        }

        public String DepartureDispayStr
        {
            get
            {
                string displayStr = string.Empty;
                
                foreach (ArrivalDeaprture ad in ArrivalDepartures)
                {
                    if (displayStr.Length > 0)
                    {
                        displayStr += ", ";
                    }
                    displayStr += ad.DepartureIn.Minutes.ToString() + "min";
                }

                displayStr = string.IsNullOrEmpty(displayStr) ? "No schedual available at this time" : displayStr;

                return displayStr;
            }
        }

        #region inner class ArrivalDeparture
        /// <summary>
        /// 
        /// </summary>
        public class ArrivalDeaprture
        {
            /// <summary>
            /// 
            /// </summary>
            private string tripId;
            public string TripId
            {
                get { return tripId; }
                set { tripId = value; }
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
            private DateTime predictedArrivalTime;
            public DateTime PredictedArrivalTime
            {
                get { return predictedArrivalTime; }
                set { predictedArrivalTime = value; }
            }
            
            /// <summary>
            /// 
            /// </summary>
            private DateTime scheduledArrivalTime;
            public DateTime ScheduledArrivalTime
            {
                get { return scheduledArrivalTime; }
                set { scheduledArrivalTime = value; }
            }
            
            /// <summary>
            /// 
            /// </summary>
            private DateTime predictedDepartureTime;
            public DateTime PredictedDepartureTime
            {
                get { return predictedDepartureTime; }
                set { predictedDepartureTime = value; }
            }
            
            /// <summary>
            /// 
            /// </summary>
            private DateTime scheduledDepartureTime;
            public DateTime ScheduledDepartureTime
            {
                get { return scheduledDepartureTime; }
                set { scheduledDepartureTime = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            private string status;
            public string Status
            {
                get { return status; }
                set { status = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            private TimeSpan departureIn;
            public TimeSpan DepartureIn
            {
                get { return departureIn; }
                set { departureIn = value; }
            }
        }
        #endregion

    }
}
