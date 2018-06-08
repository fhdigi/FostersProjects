using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FosterCollector.Classes;
using Xamarin.Forms;

namespace FosterCollector.Views
{
    public partial class JumpToCustomer : ContentPage
    {
        public CCustomerList CurrentCustomer = null;
        private List<CCustomerList> customerList = null;
 
        public JumpToCustomer(List<CCustomerList> listCust )
        {
            InitializeComponent();

            customerList = listCust;
            lvJumpTo.ItemsSource = listCust;
        }

        private void ButtonJumpToCustomer(object sender, EventArgs e)
        {
            CurrentCustomer = (CCustomerList) lvJumpTo.SelectedItem;
            int customerIndex = -1;

            if (CurrentCustomer != null)
            {
                foreach (CCustomerList custObj in customerList)
                {
                    customerIndex++;
                    if (custObj.Equals(CurrentCustomer))
                    {
                        break;
                    }
                }

                MessagingCenter.Send<JumpToCustomer, int>(this, "JumpTo", customerIndex);
                Navigation.PopAsync();
            }
        }
    }
}
