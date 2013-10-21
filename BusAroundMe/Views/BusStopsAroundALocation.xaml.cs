using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bing.Maps;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace BusAroundMe
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class BusStopsAroundALocation : BusAroundMe.Common.LayoutAwarePage
    {
        public BusStopsAroundALocation()
        {
            this.InitializeComponent();
            App.Current.Resuming += Current_Resuming;
        }

        private BusStopPageViewModel viewModel;

        // Refresh data after resume.
        void Current_Resuming(object sender, object e)
        {
            // TODO: check if the datacontext is null.
            (this.DataContext as BusStopPageViewModel).GetData();
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
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Location location = e.Parameter as Location;
            if (location != null)
            {
                viewModel = new BusStopPageViewModel(location.Latitude, location.Longitude);
            }
            else
            {
                viewModel = new BusStopPageViewModel();
            }

            this.DataContext = viewModel;
            this.viewModel.NoBusStopFound += new EventHandler((s,arg) =>{
                this.Frame.Navigate(typeof(SearchBusStopPage), null);
            });
        }

        private void itemGridView_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(BusRoutesAtABusStopPage), e.ClickedItem);
        }

        private void ViewSavedStopsClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FavoritePage), this.itemListView.SelectedItem);
        }

        private void SearchAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchBusStopPage), this.itemListView.SelectedItem);
        }

        private void itemListView_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(BusRoutesAtABusStopPage), e.ClickedItem);
        }
    }
}
