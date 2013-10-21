using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace BusAroundMe
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            // Do not repeat app initialization when already running, just ensure that
            // the window is active
            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
            {
                Window.Current.Activate();
                return;
            }

            if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
            {
                //TODO: Load state from previously suspended application
            }

            // Create a Frame to act navigation context and navigate to the first page
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(BusStopsAroundALocation)))
            {
                throw new Exception("Failed to create initial page");
            }

            // Place the frame in the current Window and ensure that it is active
            Window.Current.Content = rootFrame;
            Window.Current.Activate();

            


            PushNotificationHelpers.OpenChannel();
            //RequestBackgroundTask();
            WriteToLogFile("\r\n xyz is xyz");

            ////////////////////////////////////////////////////////////////////
            //
            //  Register Background Task
            //
            ////////////////////////////////////////////////////////////////////
            //string backgroundTaskEntryPoint = "BackgroundTask.FileSavingBackgroundTask";
            //string backgroundTaskName = "FileSavingTask";

            //SystemTrigger trigger = new SystemTrigger(SystemTriggerType.SessionConnected, false);

            //BackGroundTaskHelpers.RegisterBackGroundTask(backgroundTaskEntryPoint, backgroundTaskName, trigger, null);
            //BackGroundTaskHelpers.RegisterBackGroundTask(backgroundTaskEntryPoint, backgroundTaskName, new TimeTrigger(15, false), null);
        }


        private async void RequestBackgroundTask()
        {
            ////////////////////////////////////////////////////////////////////////////////////////
            //
            //  Request BackgroundTask ability
            //
            ////////////////////////////////////////////////////////////////////////////////////////
            BackgroundAccessStatus status = await BackgroundExecutionManager.RequestAccessAsync();
            MessageDialog msg;
            switch (status)
            {
                case BackgroundAccessStatus.AllowedWithAlwaysOnRealTimeConnectivity:
                    msg = new MessageDialog("This app is on the lock screen and has access to Real Time Connectivity.");
                    //Scenario1OutputText.Text = "This app is on the lock screen and has access to Real Time Connectivity.";
                    break;
                case BackgroundAccessStatus.AllowedMayUseActiveRealTimeConnectivity:
                    msg = new MessageDialog("This app is on the lock screen, but does not have access to Real Time Connectivity.");
                    //Scenario1OutputText.Text = "This app is on the lock screen, but does not have access to Real Time Connectivity.";
                    break;
                case BackgroundAccessStatus.Denied:
                    msg = new MessageDialog("This app is not on the lock screen.");
                    //Scenario1OutputText.Text = "This app is not on the lock screen.";
                    break;
                case BackgroundAccessStatus.Unspecified:
                    msg = new MessageDialog("The user has not yet taken any action. This is the default setting and the app is not on the lock screen.");
                    //Scenario1OutputText.Text = "The user has not yet taken any action. This is the default setting and the app is not on the lock screen.";
                    break;
                default:
                    break;
            }
        }


        private async void WriteToLogFile(string informations)
        {

            //StorageFolder storageFolder = KnownFolders.DocumentsLibrary;

            //StorageFile sampleFile = await storageFolder.CreateFileAsync("sample.txt", CreationCollisionOption.OpenIfExists);

            //if (sampleFile != null)
            //{
            //    await FileIO.AppendTextAsync(sampleFile, informations);
            //}

        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
