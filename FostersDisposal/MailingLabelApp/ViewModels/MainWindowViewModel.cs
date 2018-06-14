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
        }

        public void RefreshListing()
        {
            if (SelectedRoute == "Monday")
                CustomerListing = new ObservableCollection<Customer>(Customer.GetCustomers().Where(x => x.SequenceNumber >= 10000 && x.SequenceNumber < 20000));
            if (SelectedRoute == "Tuesday")
                CustomerListing = new ObservableCollection<Customer>(Customer.GetCustomers().Where(x => x.SequenceNumber >= 20000 && x.SequenceNumber < 30000));
            if (SelectedRoute == "Wednesday")
                CustomerListing = new ObservableCollection<Customer>(Customer.GetCustomers().Where(x => x.SequenceNumber >= 30000 && x.SequenceNumber < 40000));
            if (SelectedRoute == "Thursday")
                CustomerListing = new ObservableCollection<Customer>(Customer.GetCustomers().Where(x => x.SequenceNumber >= 40000 && x.SequenceNumber < 50000));
            if (SelectedRoute == "Friday")
                CustomerListing = new ObservableCollection<Customer>(Customer.GetCustomers().Where(x => x.SequenceNumber >= 50000 && x.SequenceNumber < 60000));
        }
    }
}
