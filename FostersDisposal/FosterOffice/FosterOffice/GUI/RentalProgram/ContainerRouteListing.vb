Imports DevExpress.XtraReports.UI

Public Class ContainerRouteListing

    Dim RentalCustomerDayArray() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
    Dim currentCustomerDictionary As New Dictionary(Of Integer, PickupTransaction.RentalCustomer.RentalRouteInformation)
    Dim currentRouteListIndex As Integer = 0
    Dim currentDayListIndex As Integer = 0

    Private Sub FillRouteDropdown()

        ' ----- Create an object listing 
        Dim tempList As New List(Of PickupTransaction.RecycleListing)
        tempList.Add(New PickupTransaction.RecycleListing(-1, "Route 1"))
        tempList.Add(New PickupTransaction.RecycleListing(-2, "Route 2"))
        tempList.Add(New PickupTransaction.RecycleListing(-3, "Route 3"))
        tempList.Add(New PickupTransaction.RecycleListing(-4, "Route 4"))
        tempList.Add(New PickupTransaction.RecycleListing(-5, "Tablet 1"))
        tempList.Add(New PickupTransaction.RecycleListing(-6, "Tablet 2"))
        tempList.Add(New PickupTransaction.RecycleListing(-7, "Tablet 3"))

        With ComboBoxRoute

            .Items.Clear()

            ' ----- Get the custom routes 
            For Each strObj As PickupTransaction.RecycleListing In tempList
                .Items.Add(strObj)
            Next

            ' ----- Get the custom routes 
            For Each strObj As PickupTransaction.RecycleListing In PickupTransaction.RecycleListing.GetRecycleListings(My.Settings.DatabaseLocation, ComboBoxDay.SelectedIndex)
                .Items.Add(strObj)
            Next

        End With

    End Sub

    Private Sub RefreshScreen()

        ' ----- This may take a while 
        Cursor = Cursors.WaitCursor

        ' ----- Refresh the dictionary
        SetCustomerDictionary()

        ' ----- Refresh the available customers
        GetAllCustomers()

        ' ----- Refresh the customers already assigned 
        GetCustomersForSelectedDayRoute()

        ' ----- Reset everything back 
        Cursor = Cursors.Default

    End Sub

    Private Sub SetCustomerDictionary()

        ' ----- Loop through each customer object and add it to the main listview 
        currentCustomerDictionary.Clear()
        currentCustomerDictionary = PickupTransaction.RentalCustomer.GetCustomerByDay(My.Settings.DatabaseLocation, ComboBoxDay.SelectedIndex)

    End Sub

    Private Sub ComboBoxDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDay.SelectedIndexChanged

        If ComboBoxDay.Focused Then
            FillRouteDropdown()
            RefreshScreen()
            ComboBoxRoute.SelectedIndex = 0
            GetCustomersForSelectedDayRoute()
        End If

    End Sub

    Private Sub ComboBoxRoute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoute.SelectedIndexChanged

        If ComboBoxRoute.Focused Then

            ' ----- If we swap between a standard route and a customer route, we need to refresh the customers 
            If (currentRouteListIndex < 7 And ComboBoxRoute.SelectedIndex >= 7) Or (currentRouteListIndex >= 7 And ComboBoxRoute.SelectedIndex < 7) Then
                GetAllCustomers()
            End If

            ' ----- Also now need to refresh the actual list 
            GetCustomersForSelectedDayRoute()

            ' ----- Now set the current index 
            currentRouteListIndex = ComboBoxRoute.SelectedIndex

        End If

    End Sub

    Private Sub ContainerRouteListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Default to starting values 
        ComboBoxDay.SelectedIndex = 0

        ' ----- Fill in the route drop down 
        FillRouteDropdown()

        ' ----- Default to route 1
        ComboBoxRoute.SelectedIndex = 0
        currentRouteListIndex = ComboBoxRoute.SelectedIndex

        ' ----- Get the data 
        RefreshScreen()

    End Sub

    Private Sub GetAllCustomers()

        ' ----- Show the wait cursor ... the database processing takes a little while 
        Cursor = Cursors.WaitCursor

        ' ----- Remove all of the items 
        ListViewMainList.Items.Clear()

        If ComboBoxRoute.SelectedIndex >= 7 Then

            For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In currentCustomerDictionary.Values.Where(Function(c) c.RecycleRouteNumber = 0).OrderBy(Function(c) c.CustomerName)

                ' ---- Write out the data to the 
                Dim itmX As ListViewItem = ListViewMainList.Items.Add(obj.CustomerName)
                itmX.SubItems.Add(obj.CustomerAddress)
                itmX.SubItems.Add(obj.Size)

                If obj.Size = "Hand" Then
                    itmX.ForeColor = Color.Green
                Else
                    itmX.ForeColor = Color.Black
                End If

                itmX.SubItems.Add(obj.Container)
                itmX.SubItems.Add(obj.ExtraInfo)

                itmX.Tag = obj

            Next

        Else

            For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In currentCustomerDictionary.Values.Where(Function(c) c.RouteNumber = 0).OrderBy(Function(c) c.CustomerName)

                ' ---- Write out the data to the 
                Dim itmX As ListViewItem = ListViewMainList.Items.Add(obj.CustomerName)
                itmX.SubItems.Add(obj.CustomerAddress)
                itmX.SubItems.Add(obj.Size)

                If obj.Size = "Hand" Then
                    itmX.ForeColor = Color.Green
                Else
                    itmX.ForeColor = Color.Black
                End If

                itmX.SubItems.Add(obj.Container)
                itmX.SubItems.Add(obj.ExtraInfo)

                itmX.Tag = obj

            Next

        End If

        ' ----- Reset 
        Cursor = Cursors.Default

    End Sub

    Private Sub GetCustomersForSelectedDayRoute()

        ' ----- Clear out the list view 
        ListViewRoutes.Items.Clear()

        ' ----- Now add the items to list view 
        Dim selectedRoute As Integer = ComboBoxRoute.SelectedIndex + 1

        ' ----- Once we get beyon the first 7 items, we have custom items 
        If selectedRoute >= 8 Then
            selectedRoute = DirectCast(ComboBoxRoute.SelectedItem, PickupTransaction.RecycleListing).ID
            For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In currentCustomerDictionary.Values.Where(Function(c) c.RecycleRouteNumber = selectedRoute).OrderBy(Function(c) c.RecycleSequenceNumber)
                AddItemToListView(obj)
            Next
        Else
            For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In currentCustomerDictionary.Values.Where(Function(c) c.RouteNumber = selectedRoute).OrderBy(Function(c) c.SequenceNumber)
                AddItemToListView(obj)
            Next
        End If

    End Sub

    Private Sub AddItemToListView(obj As PickupTransaction.RentalCustomer.RentalRouteInformation)

        ' ----- Move it over to the other grid 
        Dim itmX As ListViewItem = ListViewRoutes.Items.Add(obj.CustomerName)
        itmX.SubItems.Add(obj.CustomerAddress)
        itmX.Tag = obj

    End Sub

    Private Sub ButtonAddToRoute_Click(sender As Object, e As EventArgs) Handles ButtonAddToRoute.Click

        ' ----- Move everything that is selected to the other list 
        For Each lvItem As ListViewItem In ListViewMainList.Items
            If lvItem.Checked Then
                AddItemToListView(DirectCast(lvItem.Tag, PickupTransaction.RentalCustomer.RentalRouteInformation))
                lvItem.Checked = False
            End If
        Next

    End Sub

    Private Sub ButtonRemoveFromRoute_Click(sender As Object, e As EventArgs) Handles ButtonRemoveFromRoute.Click

        ' ----- Move everything that is selected to the other list 
        For Each lvItem As ListViewItem In ListViewRoutes.Items

            If lvItem.Checked Then

                ' ----- Get the object 
                Dim delObj As PickupTransaction.RentalCustomer.RentalRouteInformation = DirectCast(lvItem.Tag, PickupTransaction.RentalCustomer.RentalRouteInformation)

                ' ---- Remove the information from the database 
                If ComboBoxRoute.SelectedIndex + 1 >= 8 Then
                    Dim selectedRoute As Integer = DirectCast(ComboBoxRoute.SelectedItem, PickupTransaction.RecycleListing).ID
                    delObj.RemoveFromRoute(My.Settings.DatabaseLocation, selectedRoute, RentalCustomerDayArray(ComboBoxDay.SelectedIndex), True)
                Else
                    delObj.RemoveFromRoute(My.Settings.DatabaseLocation, ComboBoxRoute.SelectedIndex + 1, RentalCustomerDayArray(ComboBoxDay.SelectedIndex), False)
                End If

                ' ----- Now remove the object from the list 
                lvItem.Remove()

            End If

        Next

    End Sub

    Private Sub SaveRoute()

        ' ----- Create a day array
        Dim seqNumber As Integer = (ComboBoxDay.SelectedIndex + 1) * 10000

        Dim updatedSeq As Integer = seqNumber

        ' ----- Get every item in the list view 
        For Each itmX As ListViewItem In (From lv As ListViewItem In ListViewRoutes.Items Order By lv.Index).ToList

            ' ----- Get the object 
            Dim tempObj As PickupTransaction.RentalCustomer.RentalRouteInformation = DirectCast(itmX.Tag, PickupTransaction.RentalCustomer.RentalRouteInformation)

            ' ----- Increase the sequence number 
            updatedSeq += 1

            ' ----- Save the route 
            If ComboBoxRoute.SelectedIndex >= 7 Then
                tempObj.UpdateRoute(My.Settings.DatabaseLocation, DirectCast(ComboBoxRoute.SelectedItem, PickupTransaction.RecycleListing).ID, updatedSeq, RentalCustomerDayArray(ComboBoxDay.SelectedIndex), False)
            Else
                tempObj.UpdateRoute(My.Settings.DatabaseLocation, ComboBoxRoute.SelectedIndex + 1, updatedSeq, RentalCustomerDayArray(ComboBoxDay.SelectedIndex), True)
            End If

        Next

        ' ----- Refresh the dictionary 
        SetCustomerDictionary()

    End Sub

    Private Sub ButtonSaveRoute_Click(sender As Object, e As EventArgs) Handles ButtonSaveRoute.Click, ButtonSaveRouteAndClose.Click

        ' ----- Save the information 
        SaveRoute()

        ' ----- If the user wants to close the screen, then get out 
        If DirectCast(sender, Button).Name = "ButtonSaveRouteAndClose" Then
            Me.Close()
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        If MessageBox.Show("Are you sure you would like to cancel this screen?  Any route changes since the last save will be lost", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub ButtonMasterOfficeRoute_Click(sender As Object, e As EventArgs) Handles ButtonMasterOfficeRoute.Click

        ' ----- First save the route 
        SaveRoute()

        ' ----- Now show the route 
        Dim rpt As New RentalCustomerMasterOfficeRoute
        Dim routeNumber As Integer = ComboBoxRoute.SelectedIndex + 1

        Dim tempDict As New Dictionary(Of Integer, PickupTransaction.RentalCustomer.RentalRouteInformation)

        ' ----- Create a temporary dictionary object that basically contains the ordered list 
        For iRoute As Integer = 1 To ComboBoxRoute.Items.Count
            If iRoute >= 8 Then
                Dim selectedRoute As Integer = DirectCast(ComboBoxRoute.Items(iRoute - 1), PickupTransaction.RecycleListing).ID
                For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In currentCustomerDictionary.Values.Where(Function(c) c.RecycleRouteNumber = selectedRoute).OrderBy(Function(c) c.RecycleSequenceNumber)
                    Try
                        tempDict.Add(obj.CustomerNumber, obj)
                    Catch ex As Exception
                    End Try
                Next
            Else
                For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In currentCustomerDictionary.Values.Where(Function(c) c.RouteNumber = iRoute).OrderBy(Function(c) c.SequenceNumber)
                    Try
                        tempDict.Add(obj.CustomerNumber, obj)
                    Catch ex As Exception
                    End Try
                Next
            End If
        Next

        ' ----- Pass in the data 
        'rpt.BindingSource1.DataSource = currentCustomerDictionary.Values.Where(Function(c) c.RouteNumber > 0).OrderBy(Function(c) c.SequenceNumber).OrderBy(Function(c) c.ReportOrder)
        rpt.BindingSource1.DataSource = tempDict.Values

        ' ----- Show the report 
        rpt.XrLabelHeader.Text = String.Format("{0}'s Containers", ComboBoxDay.Text)
        rpt.ShowPreview()

    End Sub

    Private Sub ButtonPrintRoute_Click(sender As Object, e As EventArgs) Handles ButtonMasterTruckRoute.Click

        ' ----- First save the route 
        SaveRoute()

        ' ----- the first report will contain all of the dumpter routes 
        Dim rptDumpster1 As New RentalCustomerRouteListing
        rptDumpster1.BindingSource1.DataSource = currentCustomerDictionary.Values.Where(Function(c) c.RouteNumber = 1).OrderBy(Function(c) c.SequenceNumber).OrderBy(Function(c) c.RouteNumber)
        rptDumpster1.XrLabelDate.Text = String.Format("{0} Morning", ComboBoxDay.Text)

        Dim rptDumpsterOther As New RentalCustomerRouteListing
        rptDumpsterOther.BindingSource1.DataSource = currentCustomerDictionary.Values.Where(Function(c) c.RouteNumber > 1 And (c.SpecialRoute Or c.HasTrashDumpster = True Or c.Size = "Hand")).OrderBy(Function(c) c.SequenceNumber).OrderBy(Function(c) c.RouteNumber)
        rptDumpsterOther.XrLabelDate.Text = String.Format("{0}", ComboBoxDay.Text)

        rptDumpster1.CreateDocument()
        rptDumpsterOther.CreateDocument()
        rptDumpster1.Pages.AddRange(rptDumpsterOther.Pages)

        For Each obj As PickupTransaction.RecycleListing In ComboBoxRoute.Items
            If obj.ID >= 0 Then
                Dim rptRecycle As New RentalCustomerRecycleListing
                'rptRecycle.BindingSource1.DataSource = currentCustomerDictionary.Values.Where(Function(c) c.RecycleRouteNumber = obj.ID And c.HasRecycleContainer = True).OrderBy(Function(c) c.RecycleSequenceNumber).OrderBy(Function(c) c.RecycleRouteNumber)
                rptRecycle.BindingSource1.DataSource = currentCustomerDictionary.Values.Where(Function(c) c.RecycleRouteNumber = obj.ID).OrderBy(Function(c) c.RecycleSequenceNumber).OrderBy(Function(c) c.RecycleRouteNumber)
                rptRecycle.XrLabelHeader.Text = obj.Description
                rptRecycle.CreateDocument()
                rptDumpster1.Pages.AddRange(rptRecycle.Pages)
            End If
        Next

        rptDumpster1.ShowPreview()

    End Sub

    Private Sub ButtonMoveToRoute_Click(sender As Object, e As EventArgs) Handles ButtonMoveToRoute1.Click, ButtonMoveToRoute4.Click, ButtonMoveToRoute3.Click, ButtonMoveToRoute2.Click

        Dim newRouteNumber As Integer = 0
        Integer.TryParse(DirectCast(sender, Button).Text, newRouteNumber)

        Dim ans As String = String.Format("This will move the selected customers to route #{0}.  Are you sure you would like to continue?", newRouteNumber)

        ' ----- Make sure this is what they want to do
        If MessageBox.Show(ans, "Confirm Move", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then

            ' ----- Move the route over for each item 
            For Each lvItem As ListViewItem In ListViewRoutes.Items

                If lvItem.Checked Then

                    ' ----- Get the object 
                    Dim moveObj As PickupTransaction.RentalCustomer.RentalRouteInformation = DirectCast(lvItem.Tag, PickupTransaction.RentalCustomer.RentalRouteInformation)

                    ' ---- Remove the information from the database 
                    moveObj.AssignNewRoute(My.Settings.DatabaseLocation, newRouteNumber)

                End If

            Next

            RefreshScreen()

        End If

    End Sub

    Private Sub ButtonTablet1_Click(sender As Object, e As EventArgs) Handles ButtonTablet1.Click, ButtonTablet2.Click, ButtonTablet3.Click

        Dim newRouteNumber As Integer = 0
        Integer.TryParse(DirectCast(sender, Button).Text, newRouteNumber)

        Dim ans As String = String.Format("This will move the selected customers to tablet #{0}.  Are you sure you would like to continue?", newRouteNumber)

        ' ----- Make sure this is what they want to do
        If MessageBox.Show(ans, "Confirm Move", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then

            ' ----- Move the route over for each item 
            For Each lvItem As ListViewItem In ListViewRoutes.Items

                If lvItem.Checked Then

                    ' ----- Get the object 
                    Dim moveObj As PickupTransaction.RentalCustomer.RentalRouteInformation = DirectCast(lvItem.Tag, PickupTransaction.RentalCustomer.RentalRouteInformation)

                    ' ---- Remove the information from the database 
                    moveObj.AssignNewRoute(My.Settings.DatabaseLocation, newRouteNumber + 4)

                End If

            Next

            RefreshScreen()

        End If

    End Sub

#Region "Drag-Drop Routines"

    Private Sub ListViewRoutes_MouseMove(sender As Object, e As MouseEventArgs) Handles ListViewRoutes.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim lv As ListView = sender
            If lv.DoDragDrop(lv.SelectedItems, DragDropEffects.Move Or DragDropEffects.Copy) = DragDropEffects.Move Then
                For Each lvi As ListViewItem In lv.SelectedItems
                    lv.Items.Remove(lvi)
                Next
            End If
        End If

    End Sub

    Private Sub ListViewRoutes_DragEnter(sender As Object, e As DragEventArgs) Handles ListViewRoutes.DragEnter

        If e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Const CTRL As Integer = 8
            If (e.KeyState And CTRL) = CTRL Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        End If

    End Sub

    Private Sub ListViewRoutes_DragDrop(sender As Object, e As DragEventArgs) Handles ListViewRoutes.DragDrop

        Dim lv As ListView = sender
        Dim pt As Point = lv.PointToClient(Cursor.Position)
        Dim hit As ListViewHitTestInfo = lv.HitTest(pt)
        Dim sel As ListView.SelectedListViewItemCollection
        sel = e.Data.GetData(GetType(ListView.SelectedListViewItemCollection))
        If hit.Item Is Nothing Then
            For Each lvi As ListViewItem In sel
                lv.Items.Add(lvi.Clone)
            Next
        Else
            For Each lvi As ListViewItem In sel
                lv.Items.Insert(hit.Item.Index, lvi.Clone)
            Next
        End If

    End Sub

#End Region

    Private Sub ButtonCreateRecycleListing_Click(sender As Object, e As EventArgs) Handles ButtonCreateRecycleListing.Click

        Dim frm As New AddRecycleListing

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            ' ----- First save the new recycle listing 
            Dim tempObj As New PickupTransaction.RecycleListing
            tempObj.DayIndex = ComboBoxDay.SelectedIndex
            tempObj.Description = frm.RecycleListingName
            PickupTransaction.RecycleListing.SaveListing(My.Settings.DatabaseLocation, tempObj)

            ' ----- Now load it to the drop down listing 
            FillRouteDropdown()

        End If

    End Sub

    Private Sub ButtonRename_Click(sender As Object, e As EventArgs) Handles ButtonRename.Click

        Dim obj As PickupTransaction.RecycleListing = DirectCast(ComboBoxRoute.SelectedItem, PickupTransaction.RecycleListing)

        If Not obj Is Nothing Then

            Dim frm As New AddRecycleListing
            frm.RecycleListingName = obj.Description

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                ' ----- First save the new recycle listing 
                Dim tempObj As New PickupTransaction.RecycleListing
                tempObj.ID = obj.ID
                tempObj.DayIndex = obj.DayIndex
                tempObj.Description = frm.RecycleListingName
                PickupTransaction.RecycleListing.UpdateListing(My.Settings.DatabaseLocation, tempObj)

                ' ----- Now load it to the drop down listing 
                FillRouteDropdown()

            End If

        End If

    End Sub

    Private Sub ButtonDeleteRouteListDesc_Click(sender As Object, e As EventArgs) Handles ButtonDeleteRouteListDesc.Click

        Dim obj As PickupTransaction.RecycleListing = DirectCast(ComboBoxRoute.SelectedItem, PickupTransaction.RecycleListing)

        If Not obj Is Nothing Then

            If MessageBox.Show("Are you sure you would like to delete the selected route listing.  Once confirmed, the process cannot be undone.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                obj.DeleteListing(My.Settings.DatabaseLocation)

                ' ----- Now load it to the drop down listing 
                FillRouteDropdown()

            End If

        End If

    End Sub

    Private Sub ButtonRemoveManual_Click(sender As Object, e As EventArgs) Handles ButtonRemoveManual.Click

        Dim customerObj As PickupTransaction.RentalCustomer.RentalRouteInformation = DirectCast(ListViewMainList.CheckedItems(0).Tag, PickupTransaction.RentalCustomer.RentalRouteInformation)

        If Not customerObj Is Nothing Then

            If customerObj.MiscText = "MANUAL FROM RESIDENTIAL" Then

                If MessageBox.Show("Are you sure you would like to remove the selected manual customer from the route listing?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    ' ----- Get the ID
                    Dim pickupID As Integer = customerObj.PickupID

                    ' ----- Delete the record from the database 
                    PickupTransaction.RentalPickupInformation.DeletePickupRecord(My.Settings.DatabaseLocation, pickupID)

                    ' ----- Refresh the list 
                    RefreshScreen()
                    GetAllCustomers()

                End If

            End If

        End If

    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        If (ListViewMainList.CheckedItems.Count > 0) AndAlso DirectCast(ListViewMainList.CheckedItems(0).Tag, PickupTransaction.RentalCustomer.RentalRouteInformation).MiscText = "MANUAL FROM RESIDENTIAL" Then
            ButtonRemoveManual.Enabled = True
        Else
            ButtonRemoveManual.Enabled = False
        End If
    End Sub

End Class
