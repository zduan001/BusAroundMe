using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Devices.Geolocation;

namespace BusAroundMe
{
    public class BusStopPageViewModel : BasePageVieModel
    {
        public BusStopPageViewModel()
        {
            GetLocation();
        }

        public BusStopPageViewModel(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
            GetData();
        }

        private double latitude;
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        
        private double longitude;
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public async void GetLocation()
        {
            Geolocator geo = new Geolocator();

            try
            {
                CancellationTokenSource _cts = new CancellationTokenSource();
                CancellationToken token = _cts.Token;

                Geoposition pos = await geo.GetGeopositionAsync().AsTask(token);
                latitude = pos.Coordinate.Latitude;
                longitude = pos.Coordinate.Longitude;

                GetData();
            }
            catch (UnauthorizedAccessException)
            {
                // Do something to this exception , let user know geopostion can not get.
            }
        }

        public async void GetData()
        {
            
            this.Items = await DataAccessService.CurrentDataService.GetBusStopsAtALocation(latitude, longitude);
            //this.Items = await RestXmlCallHelper.GetBusStopsAtALocation(47.653435, -122.305641);
            if (this.Items == null || this.Items.Count == 0)
            {
                if (this.NoBusStopFound != null)
                {
                    this.NoBusStopFound(this, new EventArgs());
                }
            }
        }

        private List<BusStop> items;
        public List<BusStop> Items
        {
            get
            {
                if (items == null)
                {
                    items = new List<BusStop>();
                }
                return items;
            }
            set
            {
                items = value;
                NotifyPropertyChanged("Items");
            }
        }

        public EventHandler NoBusStopFound;
    }
}
