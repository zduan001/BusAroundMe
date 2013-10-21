using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace BusAroundMe
{
    class BusRouteNameConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string busRouteNameStr = string.Empty;

            BusRoute route = value as BusRoute;
            if (route != null)
            {
                busRouteNameStr += route.ShortName + " "
                    + route.Description + " "
                    + route.DepartureDispayStr;
            }

            return busRouteNameStr;
             
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
