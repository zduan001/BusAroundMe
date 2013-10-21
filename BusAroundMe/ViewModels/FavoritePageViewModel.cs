using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusAroundMe
{
    public class FavoritePageViewModel : BasePageVieModel
    {

        public FavoritePageViewModel()
        {
            GetData();
        }

        /// <summary>
        /// 
        /// </summary>
        private List<BusStopForRoute> stopAndRoutes;
        public List<BusStopForRoute> StopAndRoutes
        {
            get 
            {
                if (stopAndRoutes == null)
                {
                    stopAndRoutes = new List<BusStopForRoute>();
                }
                return stopAndRoutes; 
            }
            set
            {
                stopAndRoutes = value;
                NotifyPropertyChanged("StopAndRoutes");
            }
        }

        public void Refresh()
        {
            GetData();
        }

        /// <summary>
        /// 
        /// </summary>
        private async void GetData()
        {
            
            stopAndRoutes = AppSettings.Favorites;

            foreach (BusStopForRoute bsfr in stopAndRoutes)
            {
                BusStop stop = await DataAccessService.CurrentDataService.GetDepartureTimeAtStop(bsfr.StopId);

                bsfr.Stop = stop;

                foreach (BusRoute route in stop.Routes)
                {
                    if (route.Id == bsfr.RouteId)
                    {
                        bsfr.Route = route;
                    }
                }
            }
            StopAndRoutes = stopAndRoutes;
        }
        
    }
}
