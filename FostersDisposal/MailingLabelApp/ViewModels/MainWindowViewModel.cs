using System.Collections.ObjectModel;
using MailingLabelApp.Models;

namespace MailingLabelApp.ViewModels
{
    public class MainWindowViewModel : LcBaseViewModel
    {
        private ObservableCollection<Customer> _customerListing;
        private bool _showMonday;
        private bool _showTuesday;
        private bool _showWednesday;
        private bool _showThursday;
        private bool _showFriday;

        public ObservableCollection<Customer> CustomerListing
        {
            get => _customerListing;
            set => SetProperty(ref _customerListing, value);
        }

        public bool ShowMonday
        {
            get => _showMonday;
            set => SetProperty(ref _showMonday, value);
        }

        public bool ShowTuesday
        {
            get => _showTuesday;
            set => SetProperty(ref _showTuesday, value);
        }

        public bool ShowWednesday
        {
            get => _showWednesday;
            set => SetProperty(ref _showWednesday, value);
        }

        public bool ShowThursday
        {
            get => _showThursday;
            set => SetProperty(ref _showThursday, value);
        }

        public bool ShowFriday
        {
            get => _showFriday;
            set => SetProperty(ref _showFriday, value);
        }

        public void RefreshListing()
        {
            CustomerListing = new ObservableCollection<Customer>(Customer.GetCustomers());
        }
    }
}
