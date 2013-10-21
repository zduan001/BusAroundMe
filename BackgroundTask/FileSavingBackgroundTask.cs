using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Storage;
using Windows.System.Threading;

namespace BackgroundTask
{
    public sealed class FileSavingBackgroundTask : IBackgroundTask
    {

        volatile bool _cancelRequested = false;
        BackgroundTaskDeferral _deferral = null;
        ThreadPoolTimer _periodicTimer = null;
        uint _progress = 0;
        IBackgroundTaskInstance _taskInstance;

        public void Run(IBackgroundTaskInstance taskInstance)
        {

            Debug.WriteLine("Background " + taskInstance.Task.Name + " Starting...");

            WriteToLogFile("Background " + taskInstance.Task.Name + " Starting...");

            //
            // Associate a cancellation handler with the background task.
            //
            taskInstance.Canceled += new BackgroundTaskCanceledEventHandler(OnCanceled);

            //
            // Get the deferral object from the task instance, and take a reference to the taskInstance;
            //
            _deferral = taskInstance.GetDeferral();
            _taskInstance = taskInstance;

            _periodicTimer = ThreadPoolTimer.CreatePeriodicTimer(new TimerElapsedHandler(PeriodicTimerCallback), TimeSpan.FromMilliseconds(500));
        }

        private async void WriteToLogFile(string informations)
        {

            StorageFolder storageFolder = KnownFolders.DocumentsLibrary;

            StorageFile sampleFile = await storageFolder.CreateFileAsync("sample.txt", CreationCollisionOption.OpenIfExists);

            if (sampleFile != null)
            {
                await FileIO.AppendTextAsync(sampleFile, informations);
            }

        }

        //
        // Handles background task cancellation.
        //
        private void OnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            //
            // Indicate that the background task is canceled.
            //
            _cancelRequested = true;

            Debug.WriteLine("Background " + sender.Task.Name + " Cancel Requested...");
            WriteToLogFile("Background " + sender.Task.Name + " Cancel Requested...");
        }

        //
        // Simulate the background task activity.
        //
        private void PeriodicTimerCallback(ThreadPoolTimer timer)
        {
            if ((_cancelRequested == false) && (_progress < 100))
            {
                _progress += 10;
                _taskInstance.Progress = _progress;
            }
            else
            {
                _periodicTimer.Cancel();

                var settings = ApplicationData.Current.LocalSettings;
                var key = _taskInstance.Task.TaskId.ToString();

                //
                // Write to LocalSettings to indicate that this background task ran.
                //
                if (_cancelRequested)
                {
                    settings.Values[key] = "Canceled";
                }
                else
                {
                    settings.Values[key] = "Completed";
                }

                Debug.WriteLine("Background " + _taskInstance.Task.Name + (_cancelRequested ? " Canceled" : " Completed"));

                //
                // Indicate that the background task has completed.
                //
                _deferral.Complete();
            }
        }
    }
}
