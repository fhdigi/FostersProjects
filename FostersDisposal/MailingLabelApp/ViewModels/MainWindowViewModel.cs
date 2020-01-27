using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MailingLabelApp.Models;

namespace MailingLabelApp.ViewModels
{
    public class MainWindowViewModel : LcBaseViewModel
    {
        private ObservableCollection<Customer> _customerListing;
        private List<string> _routeDays;
        private string _selectedRoute;
        private List<BillingType> billingTypes;
        private BillingType selectedBillingType;

        public ObservableCollection<Customer> CustomerListing
        {
            get => _customerListing;
            set => SetProperty(ref _customerListing, value);
        }

        public List<string> RouteDays
        {
            get => _routeDays;
            set => SetProperty(ref _routeDays, value);
        }

        public string SelectedRoute
        {
            get => _selectedRoute;
            set => SetProperty(ref _selectedRoute, value);
        }
        public List<BillingType> BillingTypeListing { get => billingTypes; set => SetProperty(ref billingTypes, value); }
        public BillingType SelectedBillingType { get => selectedBillingType; set => SetProperty(ref selectedBillingType, value); }

        public MainWindowViewModel()
        {
            /* establish the route days */
            RouteDays = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
            };

            /* set it to all routes */
            if (RouteDays.Count > 0) SelectedRoute = RouteDays[0];

            /* added in for the billing types */
            BillingTypeListing = BillingType.GetBillingTypes();
            if (BillingTypeListing.Count > 0) SelectedBillingType = BillingTypeListing[0];

        }

        public void RefreshListing()
        {
            List<Customer> routeListing = new List<Customer>();

            if (SelectedRoute == "Monday")
                routeListing = Customer.GetCustomers().Where(x => x.SequenceNumber >= 10000 && x.SequenceNumber < 20000).ToList();
            if (SelectedRoute == "Tuesday")
                routeListing = Customer.GetCustomers().Where(x => x.SequenceNumber >= 20000 && x.SequenceNumber < 30000).ToList();
            if (SelectedRoute == "Wednesday")
                routeListing = Customer.GetCustomers().Where(x => x.SequenceNumber >= 30000 && x.SequenceNumber < 40000).ToList();
            if (SelectedRoute == "Thursday")
                routeListing = Customer.GetCustomers().Where(x => x.SequenceNumber >= 40000 && x.SequenceNumber < 50000).ToList();
            if (SelectedRoute == "Friday")
                routeListing = Customer.GetCustomers().Where(x => x.SequenceNumber >= 50000 && x.SequenceNumber < 60000).ToList();

            if (SelectedBillingType.BillingTypeNumber > 0)
            {
                CustomerListing = new ObservableCollection<Customer>(routeListing.Where(cust => cust.BillingType == SelectedBillingType.BillingTypeNumber));
            }
            else
            {
                CustomerListing = new ObservableCollection<Customer>(routeListing);
            }
        }
    }

    public class BillingType
    {
        public int BillingTypeNumber { get; set; }
        public string BillingTypeDescription { get; set; }

        public override string ToString()
        {
            return BillingTypeDescription;
        }

        public static List<BillingType> GetBillingTypes()
        {
            List<BillingType> billingTypes = new List<BillingType>
            {
                new BillingType { BillingTypeNumber = 0, BillingTypeDescription = "All Types"},
                new BillingType { BillingTypeNumber = 1, BillingTypeDescription = "Type A"},
                new BillingType { BillingTypeNumber = 2, BillingTypeDescription = "Type B"},
                new BillingType { BillingTypeNumber = 3, BillingTypeDescription = "Type C"},
                new BillingType { BillingTypeNumber = 4, BillingTypeDescription = "Type E"},
                new BillingType { BillingTypeNumber = 5, BillingTypeDescription = "Type F"},
            };

            return billingTypes;
        }
    }
}
