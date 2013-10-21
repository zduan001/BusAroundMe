using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace BusAroundMe
{
    public static class AppSettings
    {
        public const int MaxFavorites = 5;

        public const char separator = ',';

        private const string favoriteStr = "favorite";

        private static List<BusStopForRoute> favorites;

        public static List<BusStopForRoute> Favorites
        {
            get
            {
                if (favorites == null)
                {
                    favorites = new List<BusStopForRoute>();
                }
                return favorites;
            }
            set
            {
                favorites = value;
            }
        }

        public static void SaveFavorites()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            string[] favorites = new string[MaxFavorites];

            for (int i = 0; i < MaxFavorites; i++)
            {
                if (Favorites[i] != null)
                    favorites[i] = Favorites[i].RouteId.ToString() + "," + Favorites[i].StopId.ToString();
                else
                    favorites[i] = string.Empty;
            }

            localSettings.Values["favorite0"] = favorites[0];
            localSettings.Values["favorite1"] = favorites[1];
            localSettings.Values["favorite2"] = favorites[2];
            localSettings.Values["favorite3"] = favorites[3];
            localSettings.Values["favorite4"] = favorites[4];
            
        }

        public static void RetrieveFavorites()
        {

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            object[] favorites = new object[MaxFavorites];

            favorites[0] = localSettings.Values["favorite0"];
            favorites[1] = localSettings.Values["favorite1"];
            favorites[2] = localSettings.Values["favorite2"];
            favorites[3] = localSettings.Values["favorite3"];
            favorites[4] = localSettings.Values["favorite4"];

            Favorites.Clear();
            for (int i = 0; i < MaxFavorites; i++)
            {
                if (!string.IsNullOrEmpty(favorites[i].ToString()))
                {
                    string[] ids = favorites[i].ToString().Split(separator);
                    Favorites.Add(new BusStopForRoute() { RouteId = ids[0].Trim(), StopId = ids[1].Trim() });
                }
            }
        }

        public static void AddFavorites(string routeId, string stopId)
        {
            Favorites.Insert(0, new BusStopForRoute() { RouteId = routeId, StopId = stopId });
            if (Favorites.Count > 5)
            {
                Favorites.RemoveAt(5);
            }
        }

        public static void RemoveFavorite(string routeId, string stopId)
        {
            foreach (BusStopForRoute bsfr in Favorites)
            {
                if (bsfr.RouteId == routeId && bsfr.StopId == stopId)
                {
                    Favorites.Remove(bsfr);
                    break;
                }
            }
        }

        public static int GetCountofFavorites()
        {
            return Favorites.Count;
        }
    }
}
