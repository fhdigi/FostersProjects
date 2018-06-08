using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using SQLite;
using Xamarin.Forms;
using System.Xml.Serialization;

namespace FosterCollector.Classes
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
        bool ExportRouteData(List<CollectionRecord>filteredList, string baseFileName);
        bool GetCustomerRouteData();
        List<CCustomerList> ReturnCustomerList();
    }

    public class CollectionRecord
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public DateTime DateCollected { get; set; }
        public int Quantity { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public string RouteDescription { get; set; }
        public int RouteNumber { get; set; }
        public int Day { get; set; }

        public CollectionRecord() {}

        public CollectionRecord(string customerId, int day, int route, string itemId, int qty, string itemDesc, DateTime dateCollected, string routeDesc, double itemPrice)
        {
            CustomerID = customerId;
            Day = day;
            RouteNumber = route;
            Quantity = qty;
            ItemID = itemId;
            ItemDescription = itemDesc;
            DateCollected = dateCollected;
            RouteDescription = routeDesc;
            ItemPrice = itemPrice;
        }

        public static void SaveRecord(CollectionRecord colRecord)
        {
            App.CollectionDataBase.Insert(colRecord);
        } 

        public static List<CollectionRecord> GetItems()
        {
            return (from i in App.CollectionDataBase.Table<CollectionRecord>() select i).ToList();
        }

        public static List<CollectionRecord> GetItemByCustomer(string customerId)
        {
            return App.CollectionDataBase.Table<CollectionRecord>().Where(x => x.CustomerID == customerId).ToList();
        }

        public static List<CollectionRecord> GetItemsByDayAndRoute(int day, int route)
        {
            return App.CollectionDataBase.Table<CollectionRecord>().Where(x => x.Day == day && x.RouteNumber == route).ToList();
        }

        public static void DeleteItemByCustomer(string customerId)
        {
            App.CollectionDataBase.Table<CollectionRecord>().Delete(x => x.CustomerID == customerId);
        }

        public static void DeleteAll()
        {
            App.CollectionDataBase.DeleteAll<CollectionRecord>();
        }

        public static void DeleteDayAndRoute(int day, int route)
        {
            App.CollectionDataBase.Table<CollectionRecord>().Delete(x => x.Day == day && x.RouteNumber == route);
        }
    }
}
