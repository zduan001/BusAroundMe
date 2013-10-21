using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Networking.Connectivity;
using Windows.Networking.PushNotifications;

namespace BusAroundMe
{
    public static class PushNotificationHelpers
    {
        public static PushNotificationChannel pushNotificationChannel;

        public static async void OpenChannel()
        {
            PushNotificationChannel operation = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();
            var notificationUri = operation.Uri;
            var expirationTime = operation.ExpirationTime;

            Debug.WriteLine(notificationUri);
            Debug.WriteLine(expirationTime);

            pushNotificationChannel = operation;
            //pushNotificationChannel.PushNotificationReceived += pushNotificationChannel_PushNotificationReceived;

            var names = NetworkInformation.GetHostNames();

            int foundIdx;
            for (int i = 0; i < names.Count; i++)
            {
                foundIdx = names[i].DisplayName.IndexOf(".local");
                if (foundIdx > 0)
                {
                    //textBlk.Text = names[i].DisplayName.Substring(0, foundIdx);
                }
            }
        }

        public static void pushNotificationChannel_PushNotificationReceived(PushNotificationChannel sender, PushNotificationReceivedEventArgs args)
        {
            string notificationContent = String.Empty;

            switch (args.NotificationType)
            {
                case PushNotificationType.Badge:
                    notificationContent = args.BadgeNotification.Content.GetXml();
                    break;
                case PushNotificationType.Tile:
                    notificationContent = args.TileNotification.Content.GetXml();
                    break;
                case PushNotificationType.Toast:
                    notificationContent = args.ToastNotification.Content.GetXml();
                    break;
            }
            // prevent the notification from being delivered to the UI
            args.Cancel = true;
        }
    }
}
