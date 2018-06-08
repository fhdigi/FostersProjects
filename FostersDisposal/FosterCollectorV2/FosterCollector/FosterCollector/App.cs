using System;
using System.Collections.Generic;
using FosterCollector.Classes;
using FosterCollector.Views;
using SQLite;
using Xamarin.Forms;

namespace FosterCollector
{
    public class App : Application
    {
        public static Dictionary<int, string> WeekDayLookup = new Dictionary<int, string>();
        public static SQLiteConnection CollectionDataBase = null;

        public App()
        {
            // Crank up the database 
            CollectionDataBase = DependencyService.Get<ISQLite>().GetConnection();
            CollectionDataBase.CreateTable<CollectionRecord>();

            // Handle when your app starts
            WeekDayLookup.Clear();
            WeekDayLookup.Add(1, "Monday");
            WeekDayLookup.Add(2, "Tuesday");
            WeekDayLookup.Add(3, "Wednesday");
            WeekDayLookup.Add(4, "Thursday");
            WeekDayLookup.Add(5, "Friday");
            WeekDayLookup.Add(6, "Saturday");
            WeekDayLookup.Add(7, "Sunday");        
            
            // The root page of your application
            MainPage = new NavigationPage(new ShiftStartPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static int GetLastDay()
        {
            if (Current.Properties.ContainsKey("LastDay"))
            {
                return Convert.ToInt32(Current.Properties["LastDay"]);
            }
            else
            {
                return 0;
            }
        }

        public static int GetLastRoute()
        {
            if (Current.Properties.ContainsKey("LastRoute"))
            {
                return Convert.ToInt32(Current.Properties["LastRoute"]);
            }
            else
            {
                return 0;
            }
        }

        public static void SetLastDay(int lastDay)
        {
            Current.Properties["LastDay"] = lastDay.ToString();
        }

        public static void SetLastRoute(int lastRoute)
        {
            Current.Properties["LastRoute"] = lastRoute.ToString();
        }
    }
}
