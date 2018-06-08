using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace FosterCollector.Classes
{
    public class CCustomerList
    {
        public string PickupDate { get; set; }
        public int SequenceNumber { get; set; }
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddressWithCSZ { get; set; }
        public string SpecialInstructions { get; set; }
        public int Route { get; set; }
        public string PhoneNumber { get; set; }
        public int BillingBagRate { get; set; }
        public int PickupDayIndex { get; set; }
        public bool YellowTab { get; set; }

        public CCustomerList()
        {
        }

        public static List<CCustomerList> GetCustomerListing(int dayIndex, int routeIndex)
        {
            // Get the customer list 
            List<CCustomerList> customerList = DependencyService.Get<ISQLite>().ReturnCustomerList();

            // Check to make sure we have a list 
            if (customerList == null)
            {
                return null;
            }

            // Pull the day of the week from the index 
            string dayOfWeek = App.WeekDayLookup[dayIndex];

            // Return a filtered list 
            return customerList.Where(c => c.PickupDate == dayOfWeek && c.Route == routeIndex).ToList();
        }
    }
}
