using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAroundMe
{
    public class BusRouteWebPageViewModel: BasePageVieModel
    {
        public BusRouteWebPageViewModel(BusRoute route)
        {
            Route = route;
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
            }
        }
    }
}
