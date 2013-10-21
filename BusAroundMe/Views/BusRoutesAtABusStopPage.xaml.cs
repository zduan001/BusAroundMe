using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Bing.Maps;
using System.Collections.ObjectModel;
using Windows.UI.Core;

// The Split Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234234

namespace BusAroundMe
{
    /// <summary>
    /// A page that displays a group title, a list of items within the group, and details for
    /// the currently selected item.
    /// </summary>
    public sealed partial class BusRoutesAtABusStopPage : BusAroundMe.Common.LayoutAwarePage
    {
        private LocationIcon locationIcon;
        private BusStopIcon busStopIcon;
        private Geolocator geolocator;

        public BusRoutesAtABusStopPage()
        {
            this.InitializeComponent();

            geolocator = new Geolocator();
            locationIcon = new LocationIcon();
            busStopIcon = new BusStopIcon();

            // Add the location icon to map layer so that we can position it.
            map.Children.Add(locationIcon);
            map.Children.Add(busStopIcon);
            geolocator.PositionChanged += new Windows.Foundation.TypedEventHandler<Geolocator, PositionChangedEventArgs>(geolocator_PositionChanged);
            App.Current.Resuming += Current_Resuming;
            SetShareInformation();
            this.Unloaded += RoutesOfStopPage_Unloaded;
        }

        private void SetShareInformation()
        {
            var dataTransferMange = Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView();

            dataTransferMange.DataRequested += dataTransferMange_DataRequested;

        }

        void dataTransferMange_DataRequested(Windows.ApplicationModel.DataTransfer.DataTransferManager sender, Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs args)
        {
            args.Request.Data.Properties.Title = this.viewModel.StopName;
            args.Request.Data.Properties.Description = "Bus coming and leaving @ bus stop " + this.viewModel.StopName;
            string datatext = string.Empty;

            BusRoute route = this.itemListView.SelectedItem as BusRoute;

            if (route != null)
            {
                datatext += "Bus Route " + route.ShortName + " " + route.Description;
                datatext += "\r\n" + route.DepartureDispayStr;

            }
            args.Request.Data.SetText(datatext);
        }

        void RoutesOfStopPage_Unloaded(object sender, RoutedEventArgs e)
        {
            var dataTransferMange = Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView();
            dataTransferMange.DataRequested -= dataTransferMange_DataRequested;
        }

        void Current_Resuming(object sender, object e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            //TODO: check if data context is null.
            this.viewModel.GetData();
        }

        private async void geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
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

            if (this.viewModel.Stop != null)
            {
                Location busStopLocation = new Location(this.viewModel.Stop.Lat, this.viewModel.Stop.Lon);
                MapLayer.SetPosition(busStopIcon, busStopLocation);
                map.SetView(busStopLocation, 15.0f);
            }
            else
            {
                map.SetView(location, 15.0f);
            }
        }
        
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The
        /// Parameter property provides the group to be displayed.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BusStop stop = e.Parameter as BusStop;
            if (stop != null)
            {
                viewModel = new RoutesOfStopPageViewModel(stop);
            }
            this.DataContext = viewModel;

            if (!this.UsingLogicalPageNavigation() && this.viewModel.Routes.Count > 0)
            {
                this.itemsViewSource.View.MoveCurrentToFirst();
            }
        }

        /// <summary>
        /// Hanlde the app bar navigate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToFavriteClicked(object sender, RoutedEventArgs e)
        {
            BusRoute route = this.itemListView.SelectedItem as BusRoute;
            if (route != null && !string.IsNullOrEmpty(route.Id) && this.viewModel != null && this.viewModel.Stop != null && !string.IsNullOrEmpty(this.viewModel.Stop.Id))
            {
                AppSettings.AddFavorites(route.Id, this.viewModel.Stop.Id);
                ToastNotificationHelper.ShowToastNotification("Added to favorite", route.ShortName + " @ " + this.viewModel.Stop.Name, true);
                TileNotificationHelpers.UpdateTile("Added to favorites: ", route.ShortName + " @ " + this.viewModel.Stop.Name, route.Id + this.viewModel.Stop.Id);
                BadgeNotificationHelpers.UpdateBadgeWithNumber(AppSettings.GetCountofFavorites());
            }
        }

        /// <summary>
        /// Invoked when an item within the list is selected.
        /// </summary>
        /// <param name="sender">The GridView (or ListView when the application is Snapped)
        /// displaying the selected item.</param>
        /// <param name="e">Event data that describes how the selection was changed.</param>
        private async void ItemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Invalidate the view state when logical page navigation is in effect, as a change
            // in selection may cause a corresponding change in the current logical page.  When
            // an item is selected this has the effect of changing from displaying the item list
            // to showing the selected item's details.  When the selection is cleared this has the
            // opposite effect.
            if (this.UsingLogicalPageNavigation()) this.InvalidateVisualState();

            BusRoute route = itemListView.SelectedItem as BusRoute;
            Collection<double> points = null;
            if (route != null)
            {
                points = await RestXmlDataService.Current.GetPathForRoute(route.Id);
            }

            if (points == null)
            {
                return;
            }

            /////////////////////////////////////////////////////////////////////////////////
            //
            //  Creat and draw bus route on to map.
            //
            /////////////////////////////////////////////////////////////////////////////////
            map.ShapeLayers.Clear();
            MapShapeLayer shapeLayer = new MapShapeLayer();
            MapPolyline mapPolyline = new MapPolyline();
            mapPolyline.Locations = new LocationCollection();

            for (int i = 0; i < points.Count; i += 2)
            {
                mapPolyline.Locations.Add(new Location(points[i], points[i + 1]));
            }

            mapPolyline.Color = Windows.UI.Colors.Purple;
            mapPolyline.Width = 5;
            shapeLayer.Shapes.Add(mapPolyline);
            map.ShapeLayers.Add(shapeLayer);
        }

        /// <summary>
        /// Handler of the View Web page bottom task bar button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewWebPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BusRouteDetailPage), this.itemListView.SelectedItem);
        }

        private RoutesOfStopPageViewModel viewModel;

        #region Page state management

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
            // TODO: Assign a bindable group to this.DefaultViewModel["Group"]
            // TODO: Assign a collection of bindable items to this.DefaultViewModel["Items"]

            if (pageState == null)
            {
                // When this is a new page, select the first item automatically unless logical page
                // navigation is being used (see the logical page navigation #region below.)
                if (!this.UsingLogicalPageNavigation() && this.itemsViewSource.View != null)
                {
                    this.itemsViewSource.View.MoveCurrentToFirst();
                }
            }
            else
            {
                // Restore the previously saved state associated with this page
                if (pageState.ContainsKey("SelectedItem") && this.itemsViewSource.View != null)
                {
                    // TODO: Invoke this.itemsViewSource.View.MoveCurrentTo() with the selected
                    //       item as specified by the value of pageState["SelectedItem"]
                }
            }
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
            if (this.itemsViewSource.View != null)
            {
                var selectedItem = this.itemsViewSource.View.CurrentItem;
                // TODO: Derive a serializable navigation parameter and assign it to
                //       pageState["SelectedItem"]
            }
        }

        #endregion

        #region Logical page navigation

        // Visual state management typically reflects the four application view states directly
        // (full screen landscape and portrait plus snapped and filled views.)  The split page is
        // designed so that the snapped and portrait view states each have two distinct sub-states:
        // either the item list or the details are displayed, but not both at the same time.
        //
        // This is all implemented with a single physical page that can represent two logical
        // pages.  The code below achieves this goal without making the user aware of the
        // distinction.

        /// <summary>
        /// Invoked to determine whether the page should act as one logical page or two.
        /// </summary>
        /// <param name="viewState">The view state for which the question is being posed, or null
        /// for the current view state.  This parameter is optional with null as the default
        /// value.</param>
        /// <returns>True when the view state in question is portrait or snapped, false
        /// otherwise.</returns>
        private bool UsingLogicalPageNavigation(ApplicationViewState? viewState = null)
        {
            if (viewState == null) viewState = ApplicationView.Value;
            return viewState == ApplicationViewState.FullScreenPortrait ||
                viewState == ApplicationViewState.Snapped;
        }

        ///// <summary>
        ///// Invoked when an item within the list is selected.
        ///// </summary>
        ///// <param name="sender">The GridView (or ListView when the application is Snapped)
        ///// displaying the selected item.</param>
        ///// <param name="e">Event data that describes how the selection was changed.</param>
        //void ItemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // Invalidate the view state when logical page navigation is in effect, as a change
        //    // in selection may cause a corresponding change in the current logical page.  When
        //    // an item is selected this has the effect of changing from displaying the item list
        //    // to showing the selected item's details.  When the selection is cleared this has the
        //    // opposite effect.
        //    if (this.UsingLogicalPageNavigation()) this.InvalidateVisualState();
        //}

        /// <summary>
        /// Invoked when the page's back button is pressed.
        /// </summary>
        /// <param name="sender">The back button instance.</param>
        /// <param name="e">Event data that describes how the back button was clicked.</param>
        protected override void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.UsingLogicalPageNavigation() && itemListView.SelectedItem != null)
            {
                // When logical page navigation is in effect and there's a selected item that
                // item's details are currently displayed.  Clearing the selection will return to
                // the item list.  From the user's point of view this is a logical backward
                // navigation.
                this.itemListView.SelectedItem = null;
            }
            else
            {
                // When logical page navigation is not in effect, or when there is no selected
                // item, use the default back button behavior.
                base.GoBack(sender, e);
            }
        }

        /// <summary>
        /// Invoked to determine the name of the visual state that corresponds to an application
        /// view state.
        /// </summary>
        /// <param name="viewState">The view state for which the question is being posed.</param>
        /// <returns>The name of the desired visual state.  This is the same as the name of the
        /// view state except when there is a selected item in portrait and snapped views where
        /// this additional logical page is represented by adding a suffix of _Detail.</returns>
        protected override string DetermineVisualState(ApplicationViewState viewState)
        {
            // Update the back button's enabled state when the view state changes
            var logicalPageBack = this.UsingLogicalPageNavigation(viewState) && this.itemListView.SelectedItem != null;
            var physicalPageBack = this.Frame != null && this.Frame.CanGoBack;
            this.DefaultViewModel["CanGoBack"] = logicalPageBack || physicalPageBack;

            // Determine visual states for landscape layouts based not on the view state, but
            // on the width of the window.  This page has one layout that is appropriate for
            // 1366 virtual pixels or wider, and another for narrower displays or when a snapped
            // application reduces the horizontal space available to less than 1366.
            if (viewState == ApplicationViewState.Filled ||
                viewState == ApplicationViewState.FullScreenLandscape)
            {
                var windowWidth = Window.Current.Bounds.Width;
                if (windowWidth >= 1366) return "FullScreenLandscapeOrWide";
                return "FilledOrNarrow";
            }

            // When in portrait or snapped start with the default visual state name, then add a
            // suffix when viewing details instead of the list
            var defaultStateName = base.DetermineVisualState(viewState);
            return logicalPageBack ? defaultStateName + "_Detail" : defaultStateName;
        }

        #endregion

        private void map_DoubleTappedOverride_1(object sender, DoubleTappedRoutedEventArgs e)
        {
            

        }


    }
}
