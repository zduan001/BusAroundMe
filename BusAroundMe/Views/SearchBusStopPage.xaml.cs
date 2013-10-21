using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Bing.Maps;
using Windows.Devices.Geolocation;
using System.Collections.ObjectModel;
using Windows.UI.Core;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace BusAroundMe
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class SearchBusStopPage : BusAroundMe.Common.LayoutAwarePage
    {
        private LocationIcon locationIcon;
        private Geolocator geolocator;

        public SearchBusStopPage()
        {
            this.InitializeComponent();

            geolocator = new Geolocator();
            locationIcon = new LocationIcon();


            map.Children.Add(locationIcon);
            geolocator.PositionChanged += new Windows.Foundation.TypedEventHandler<Geolocator, PositionChangedEventArgs>(geolocator_PositionChanged);
        }

        private async  void geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            // Need to set map view on UI thread.
            await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, new DispatchedHandler(
                () =>
                {
                    displayPosition(this, args);
                }));
        }

        private void displayPosition(object sender, PositionChangedEventArgs args)
        {

            Location location = new Location(args.Position.Coordinate.Latitude, args.Position.Coordinate.Longitude);
            MapLayer.SetPosition(locationIcon, location);
            MapLayer.SetPosition(locationIcon, location);

            map.SetView(location, 15.0f);
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }


        private void  GetBusStopFormMapLocation()
        {
            Location loc = map.Center;
            this.Frame.Navigate(typeof(BusStopsAroundALocation), loc);
            //List<BusStop> busStops = await RestXmlCallHelper.GetBusStopsAtALocation(loc.Latitude, loc.Longitude);

            //foreach (BusStop stop in busStops)
            //{
            //    BusStopIcon busStopIcon = new BusStopIcon();
            //    map.Children.Add(busStopIcon);
            //    MapLayer.SetPosition(busStopIcon, new Location(stop.Lat, stop.Lon));
            //}
        }

        private void SearchAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            GetBusStopFormMapLocation();
        }

        private void searchButton_Click_1(object sender, RoutedEventArgs e)
        {
            GetBusStopFormMapLocation();
        }
    }
}
