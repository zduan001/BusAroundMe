using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace BusAroundMe
{
    public class StopNameConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            BusStopDirectoinCoverter directionCoverter = new BusStopDirectoinCoverter();
            string StopNamewithDirection = string.Empty;
            BusStop stop = value as BusStop;
            if (stop != null)
            {
                StopNamewithDirection = stop.Name;
                if (!string.IsNullOrEmpty(stop.Direction))
                {
                    StopNamewithDirection += "  (" + directionCoverter.Convert(stop.Direction, typeof(string), null, string.Empty).ToString() + ")";
                }
            }

            return StopNamewithDirection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
