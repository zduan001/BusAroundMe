using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationsExtensions.BadgeContent;
using Windows.UI.Notifications;

namespace BusAroundMe
{
    public class BadgeNotificationHelpers
    {

        public static void UpdateBadgeWithNumber(int number)
        {
            BadgeNumericNotificationContent badgeContent = new BadgeNumericNotificationContent((uint)number);

            // send the notification to the app's application tile
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Update(badgeContent.CreateNotification());
        }

        public static void UpdateBadgeWithGlyph(int index)
        {
            BadgeGlyphNotificationContent badgeContent = new BadgeGlyphNotificationContent(GlyphValue.Activity);

            // send the notification to the app's application tile
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Update(badgeContent.CreateNotification());

        }
    }
}
