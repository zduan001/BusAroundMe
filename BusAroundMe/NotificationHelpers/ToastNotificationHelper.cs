using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationsExtensions.ToastContent;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace BusAroundMe
{
    public static class ToastNotificationHelper
    {
        /// <summary>
        /// Use ToastText02 template to display the code.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="withSound"></param>
        public static void ShowToastNotification(string title, string content, bool withSound)
        {
            IToastText02 toastContent = ToastContentFactory.CreateToastText02();
            toastContent.TextHeading.Text = title;
            toastContent.TextBodyWrap.Text = content;
            if (withSound)
            {
                // Only allow reminder sound to be played.
                toastContent.Audio.Content = ToastAudioContent.Reminder;
            }

            // Create a toast, then create a ToastNotifier object to show
            // the toast
            ToastNotification toast = toastContent.CreateNotification();

            try
            {
                // If you have other applications in your package, you can specify the AppId of
                // the app to create a ToastNotifier for that application
                ToastNotificationManager.CreateToastNotifier().Show(toast);
            }
            catch (System.Exception)
            {
                //Log the exception ... mostly like a "the application identifier provided is invalid" exception.
            }
        }

        public static void DisplayToastUsingXmlManipulation(ToastTemplateType templateType, string[] content)
        {
            // GetTemplateContent returns a Windows.Data.Xml.Dom.XmlDocument object containing
            // the toast XML
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(templateType);

            // You can use the methods from the XML document to specify all of the
            // required parameters for the toast
            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            
            // Make sure stringElements have enough space to hold the content.
            if (content.Length < stringElements.Length)
            {
                for (uint i = 0; i < content.Length; i++)
                {
                    stringElements.Item(i).AppendChild(toastXml.CreateTextNode(content[i]));
                }
            }

            // Create a toast from the Xml, then create a ToastNotifier object to show
            // the toast
            ToastNotification toast = new ToastNotification(toastXml);

            // If you have other applications in your package, you can specify the AppId of
            // the app to create a ToastNotifier for that application
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
