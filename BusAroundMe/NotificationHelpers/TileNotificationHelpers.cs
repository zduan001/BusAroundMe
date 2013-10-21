using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationsExtensions.TileContent;
using Windows.UI.Notifications;

namespace BusAroundMe
{
    public static class TileNotificationHelpers
    {
        public static void UpdateTile(string title, string content, string tag)
        {
            ITileWideText09 tileContent = TileContentFactory.CreateTileWideText09();
            tileContent.TextHeading.Text = title;
            tileContent.TextBodyWrap.Text = content;

            ITileSquareText02 squareTileContent = TileContentFactory.CreateTileSquareText02();
            squareTileContent.TextHeading.Text = title;
            squareTileContent.TextBodyWrap.Text = content;
            tileContent.SquareContent = squareTileContent;

            TileNotification tileNotification = tileContent.CreateNotification();
            
            if (string.IsNullOrWhiteSpace(tag))
            {
                tag = "TestTag01";
            }
            // set the tag on the notification
            tileNotification.Tag = tag;
            EnableTileNotificationCycling();
            TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
        }

        public static void ClearTile()
        {
            TileUpdateManager.CreateTileUpdaterForApplication().Clear();
            DisableTileNotificationCycling();
        }

        public static void EnableTileNotificationCycling()
        {
            TileUpdateManager.CreateTileUpdaterForApplication().EnableNotificationQueue(true);
        }

        public static void DisableTileNotificationCycling()
        {
            TileUpdateManager.CreateTileUpdaterForApplication().EnableNotificationQueue(false);
        }


    }
}
