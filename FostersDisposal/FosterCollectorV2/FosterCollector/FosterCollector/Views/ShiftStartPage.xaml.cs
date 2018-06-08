using System;
using System.Collections.Generic;
using FosterCollector.Classes;
using Xamarin.Forms;

namespace FosterCollector.Views
{
    public partial class ShiftStartPage : ContentPage
    {
        public ShiftStartPage()
        {
            InitializeComponent();

            // Fill the dropdowns
            FillPickerControls();

            // Set the drop downs
            pickerDay.SelectedIndex = App.GetLastDay();
            pickerRoute.SelectedIndex = App.GetLastRoute();

            // Set the version
            labelVersion.Text = String.Format("Version {0}","1.0.18.606");
        }

        /// <summary>
        /// Routine to clear out the route and start fresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void StartNewRoute(object sender, EventArgs e)
        {
            // Show a message to the user stating what is going on
            bool answer = await DisplayAlert("Confirm", "Are you sure you would like to start this route?  If there was any previous data on this route, that data will be erased", "Yes", "No");
            if (answer == false) return;

            // Get the day and route 
            int curDay = pickerDay.SelectedIndex;
            int curRoute = pickerRoute.SelectedIndex;

            // Set the day and route 
            App.SetLastDay(curDay);
            App.SetLastRoute(curRoute);

            // Now move to the data entry form 
            DisposalEntry entryForm = new DisposalEntry(DisposalEntry.RouteStatus.StartNew, curDay, curRoute);
            await Navigation.PushAsync(entryForm);
        }

        private async void ResumePreviousRoute(object sender, EventArgs e)
        {
            int curDay = pickerDay.SelectedIndex;
            int curRoute = pickerRoute.SelectedIndex;

            // Set the day and route 
            App.SetLastDay(curDay);
            App.SetLastRoute(curRoute);

            // Show the action sheet to see what type of route the user would like 
            var action =
                await DisplayActionSheet("Route Options", "Cancel", null, "Start New Route", "Resume Previous Route");

            if (action == "Start New Route")
            {
                // One more time to make sure they want to do this
                bool answer =
                    await
                        DisplayAlert("Confirm",
                            "Are you sure you would start a new route?  This will delete any previous route data.",
                            "Yes", "No");
                if (answer == false) return;

                // Show the page 
                DisposalEntry entryForm = new DisposalEntry(DisposalEntry.RouteStatus.StartNew, curDay, curRoute);
                await Navigation.PushAsync(entryForm);
            }

            if (action == "Resume Previous Route")
            {
                // Show the page 
                DisposalEntry entryForm = new DisposalEntry(DisposalEntry.RouteStatus.ResumePrevious, curDay, curRoute);
                await Navigation.PushAsync(entryForm);
            }
        }

        private void FillPickerControls()
        {
            // Fill in the days 
            for (int iDay = 1; iDay <= 7; iDay++)
                pickerDay.Items.Add(App.WeekDayLookup[iDay]);


            // Fill in the routes 
            for (int i = 1; i <= 4; i++)
                pickerRoute.Items.Add(i.ToString());

        }

        private void ClearRoute(object sender, EventArgs e)
        {
            CollectionRecord.DeleteAll();
        }

        private async void ButtonUploadData(object sender, EventArgs e)
        {
            // Show a message to the user stating what is going on
            bool answer = await DisplayAlert("Confirm", "Are you sure you would like to upload this route to the FTP site?  A message will appear once the upload has been completed.", "Yes", "No");
            if (answer == false) return;

            int dayToExport = App.GetLastDay() + 1;
            int routeToExport = App.GetLastRoute() + 1;

            // Create a filtered list 
            List<CollectionRecord> filteredList = CollectionRecord.GetItemsByDayAndRoute(dayToExport, routeToExport);

            // Create the base file name string 
            string baseFileName = string.Format("CollectionData_Day{0}_Route{1}_{2:ddMMMyyyy}.fcf", dayToExport, routeToExport, DateTime.Today);

            // Export the data (if we have any records)
            if (filteredList.Count > 0) DependencyService.Get<ISQLite>().ExportRouteData(filteredList, baseFileName);

            // Tell the user 
            await DisplayAlert("FTP Transfer", "The route has been uploaded.", "OK");
        }

        private async void ButtonUpdateCustomerList(object sender, EventArgs e)
        {
            // Show a message to the user stating what is going on
            bool answer = await DisplayAlert("Confirm", "Are you sure you would like to download the latest customer route data?  A message will appear once the download has been completed.", "Yes", "No");
            if (answer == false) return;

            // Download the file from the FTP site 
            DependencyService.Get<ISQLite>().GetCustomerRouteData();

            // Tell the user 
            await DisplayAlert("Customer Route Data", "The customer route data has been downloaded.", "OK");
        }
    }
}
