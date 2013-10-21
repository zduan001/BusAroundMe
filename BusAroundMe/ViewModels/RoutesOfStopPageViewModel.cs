using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace BusAroundMe
{
    public class RoutesOfStopPageViewModel : BasePageVieModel
    {
        #region constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stop"></param>
        public RoutesOfStopPageViewModel(BusStop stop)
        {
            Stop= stop;
            StopName = stop.Name;
            GetData();
        }
        #endregion

        #region methods
        /// <summary>
        /// 
        /// </summary>
        public async void GetData()
        {
            Routes = await DataAccessService.CurrentDataService.GetBusRoutesAtAStop(Stop);
        }
        #endregion

        #region property
        private BusStop stop;
        public BusStop Stop
        {
            get 
            { 
                return stop; 
            }
            set 
            { 
                stop = value;
                NotifyPropertyChanged("Stop");
            }
        }

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
                NotifyPropertyChanged("Routes");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool isLoading;
        public bool IsLoading
        {
            get { return isLoading; }
            set 
            { 
                isLoading = value;
                NotifyPropertyChanged("IsLoading");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private string stopName;
        public string StopName
        {
            get 
            { 
                return this.stopName; 
            }
            
            set 
            { 
                this.stopName = value;
                NotifyPropertyChanged("StopName");
            }
        }

        #endregion
    }
}
