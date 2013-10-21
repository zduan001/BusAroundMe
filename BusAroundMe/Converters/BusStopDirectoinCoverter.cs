using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace BusAroundMe
{
    public class BusStopDirectoinCoverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string directionStr = string.Empty;

            string direction = value.ToString();
            switch (direction)
            {
                case "S":
                    directionStr = "South";
                    break;
                case "N":
                    directionStr = "North";
                    break;
                case "E":
                    directionStr = "East";
                    break;
                case "W":
                    directionStr = "West";
                    break;
                case "":
                    directionStr = "Unkonwn";
                    break;
                default:
                    directionStr = direction;
                    break;

            }


            return directionStr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
