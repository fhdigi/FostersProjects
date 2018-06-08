using System;
using System.Collections.Generic;
using System.Linq;
using FosterCollector.Classes;
using Xamarin.Forms;

namespace FosterCollector.Views
{
    public partial class DisposalEntry : ContentPage
    {
        public enum RouteStatus
        {
            StartNew = 1,
            ResumePrevious = 2
        }

        private enum MoveDirection
        {
            Forward = 1,
            Backward = 2,
            Jump = 3
        }

        // For each customer, this list should maintain the current items collected 
        private List<CollectionRecord> CollectedItems = new List<CollectionRecord>();

        // This is the complete list of customers on this route 
        private List<CCustomerList> CurrentCustomerList = new List<CCustomerList>();
        
        // Index to keep track of the current items
        private int _currentCustomerIndex = -1;
        private string _currentCustomerId = "";
        private int _currentBagCount = 0;
        private int _currentRoute = 0;
        private int _currentDay = 0;
        private string _routeDesc = "";

        public DisposalEntry(RouteStatus rs, int curDay, int curRoute) 
        {
            InitializeComponent();

            // Disable the navigation bar
            NavigationPage.SetHasBackButton(this, false);

            // Create a message to listen for Jump Requests
            MessagingCenter.Subscribe<JumpToCustomer, int>(this, "JumpTo", (sender, arg) =>
            {
                _currentCustomerIndex = arg;
                UpdateRoutine(MoveDirection.Jump);
            } );

            // Get the customer list for the day and route 
            _currentDay = curDay + 1;
            _currentRoute = curRoute + 1;
            _routeDesc = string.Format("Truck - {0}", _currentRoute);
            CurrentCustomerList = CCustomerList.GetCustomerListing(_currentDay, _currentRoute);

            // If the list comes back blank ... tell the user and go back
            if (CurrentCustomerList == null)
            {
                DisplayAlert("Customer List", "The customer list cannot be loaded.  The most likely cause is due to a missing file.  Please press the Update Customer List button and then try again.", "OK");
                Navigation.PopAsync();
            }
                
            // If this is a new route, clear every thing out
            if (rs == RouteStatus.StartNew)
            {
                CollectionRecord.DeleteDayAndRoute(_currentDay, _currentRoute);
            }

            // Fill in the other items that are collected 
            ReadItemsToCollect();

            // Go to the first record
            UpdateRoutine(MoveDirection.Forward);

            // Set an event when those items are selected
            CurrentItemList.ItemSelected += (sender, e) =>
            {
                ItemsCollected colItem = (ItemsCollected)e.SelectedItem;
                if (colItem != null) CollectedItems.Add(new CollectionRecord(_currentCustomerId, _currentDay, _currentRoute, colItem.ID.ToString(), 1, colItem.ItemDescription, DateTime.Now, _routeDesc, colItem.MinimumPrice));
                AddToList();
            };
        }

        private void UpdateRoutine(MoveDirection direction)
        {
            // Save the data to the database 
            SaveCustomerRecord();

            // Move to the next customer 
            if (direction == MoveDirection.Forward)
            {
                _currentCustomerIndex++;
            }
            else if (direction == MoveDirection.Backward)
            {
                _currentCustomerIndex--;
            }

            // Show the label at the top 
            DisplayCustomer();

            // Recall their data (if they have any)
            CollectedItems.Clear();
            CollectedItems = CollectionRecord.GetItemByCustomer(_currentCustomerId);

            // Get the bag count
            if (CollectedItems.Count > 0)
                _currentBagCount = CollectedItems.Where(x => x.ItemID == "1").Select(x => x.Quantity).FirstOrDefault();

            // Display it
            AddToList();

            // See if this allows us to select the same extra item a second time
            CurrentItemList.SelectedItem = null;
        }

        private void SaveCustomerRecord()
        {
            CollectionRecord.DeleteItemByCustomer(_currentCustomerId);
            foreach (CollectionRecord colRec in CollectedItems)
            {
                CollectionRecord.SaveRecord(colRec);
            }
        }

        private void ButtonNextOnClicked(object sender, EventArgs e)
        {
            UpdateRoutine(MoveDirection.Forward);
        }

        private void ButtonPreviousOnClicked(object sender, EventArgs e)
        {
            UpdateRoutine(MoveDirection.Backward);
        }

        private async void DisplayCustomer()
        {
            // If there is nothing in the list, then get out 
            if (CurrentCustomerList.Count == 0) return;

            // Just make sure we do not exceed the bounds of the listing 
            if (_currentCustomerIndex < 0) _currentCustomerIndex = 0;
            if (_currentCustomerIndex >= CurrentCustomerList.Count) _currentCustomerIndex = CurrentCustomerList.Count - 1;

            // Show the data
            LabelName.Text = CurrentCustomerList[_currentCustomerIndex].CustomerName;
            LabelAddress.Text = CurrentCustomerList[_currentCustomerIndex].CustomerAddress;
            LabelSeqNumber.Text = CurrentCustomerList[_currentCustomerIndex].SequenceNumber.ToString();

            // Set the customer ID
            _currentCustomerId = CurrentCustomerList[_currentCustomerIndex].AccountNumber.ToString();

            // Check for Yellow Tab
            if (CurrentCustomerList[_currentCustomerIndex].YellowTab)
            {
                await DisplayAlert("Yellow Tab Customer", "YELLOW TAB CUSTOMER - DO NOT PICKUP.", "OK");
            }

            // Check for special instructions 
            try
            {
                if (CurrentCustomerList[_currentCustomerIndex].SpecialInstructions.Trim() != "")
                {
                    await DisplayAlert("Special Instructions", CurrentCustomerList[_currentCustomerIndex].SpecialInstructions, "OK");
                }
            }
            catch (Exception e)
            {
              
            }
        }

        private void ReadItemsToCollect()
        {
            CurrentItemList.ItemsSource = null;
            CurrentItemList.ItemsSource = ItemsCollected.GetItemsCollected();
        }

        public void AddToList()
        {
            CollectedItemList.ItemsSource = null;
            CollectedItemList.ItemsSource = CollectedItems;
        }

        public void RemoveFromList()
        {
            CollectionRecord itemSel = (CollectionRecord)CollectedItemList.SelectedItem;

            if (itemSel != null)
            {
                CollectedItems.Remove(itemSel);
                AddToList();
            }
        }

        private void OnBtnRemoveItemClicked(object sender, EventArgs e)
        {
            RemoveFromList();
        }

        #region Garbage Bags 
        
        private void CheckForGarbageBag()
        {
            foreach (CollectionRecord colRec in CollectedItems)
            {
                if (colRec.ItemID == "1")
                {
                    CollectedItems.Remove(colRec);
                    return;
                }
            }
        }

        private void SetBagAmount()
        {
            CheckForGarbageBag();
            CollectedItems.Add(new CollectionRecord(_currentCustomerId, _currentDay, _currentRoute, "1", _currentBagCount , string.Format("Garbage Bags {0}",_currentBagCount), DateTime.Now, _routeDesc, 0.00));
            AddToList();
        }

        private void AddOneBag(object sender, EventArgs e)
        {
            _currentBagCount = 1;
            SetBagAmount();
        }

        private void AddTwoBag(object sender, EventArgs e)
        {
            _currentBagCount = 2;
            SetBagAmount();
        }

        private void AddThreeBag(object sender, EventArgs e)
        {
            _currentBagCount = 3;
            SetBagAmount();
        }

        private void AddFourBag(object sender, EventArgs e)
        {
            _currentBagCount = 4;
            SetBagAmount();
        }

        private void AddFiveBag(object sender, EventArgs e)
        {
            _currentBagCount = 5;
            SetBagAmount();
        }

        private void AddSixBag(object sender, EventArgs e)
        {
            _currentBagCount = 6;
            SetBagAmount();
        }

        private void IncreaseBagCount(object sender, EventArgs e)
        {
            _currentBagCount++;
            SetBagAmount();
        }

        private void DecreaseBagCount(object sender, EventArgs e)
        {
            if (_currentBagCount > 1) _currentBagCount--;
            SetBagAmount();
        }

        #endregion

        private async void ButtonJumpToClicked(object sender, EventArgs e)
        {
            JumpToCustomer jumpCust = new JumpToCustomer(CurrentCustomerList);
            await Navigation.PushAsync(jumpCust, true);
        }

        // Go back to the main screen 
        private async void ButtonEndRoute(object sender, EventArgs e)
        {
            // Save the current customer
            SaveCustomerRecord();

            // Return to the main screen 
            await Navigation.PopAsync();
        }
    }
}
