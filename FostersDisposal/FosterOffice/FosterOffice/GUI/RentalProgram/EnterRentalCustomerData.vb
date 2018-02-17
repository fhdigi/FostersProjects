Public Class EnterRentalCustomerData

    Dim currentCustomerDictionary As New Dictionary(Of Integer, PickupTransaction.RentalCustomer.RentalRouteInformation)
    Dim currentPickupInformation As New Dictionary(Of Integer, PickupTransaction.RentalRouteData)
    Dim currentCustomerOnCall As New Dictionary(Of Integer, PickupTransaction.RentalCustomer.RentalRouteInformation)
    Dim RentalCustomerDayArray() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}

    Private Sub RefreshScreen()

        ' ----- This may take a while 
        Cursor = Cursors.WaitCursor

        ' ----- Refresh the customers already assigned 
        If TabControlRoutes.SelectedTab.Name = "TabPageRoutes" Then
            Try
                GetCustomersForSelectedDayRoute()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            GetOnCallCustomers()
        End If

        ' ----- Reset everything back 
        Cursor = Cursors.Default

    End Sub

    Private Sub SetCustomerDictionary()

        ' ----- This may take a while 
        Cursor = Cursors.WaitCursor

        ' ----- Loop through each customer object and add it to the main listview 
        currentCustomerDictionary.Clear()
        currentCustomerDictionary = PickupTransaction.RentalCustomer.GetCustomerByDay(My.Settings.DatabaseLocation, If(DateTimePickerRouteDate.Value.DayOfWeek = 0, 6, DateTimePickerRouteDate.Value.DayOfWeek - 1))

        ' ----- Loop through each pickup object
        currentPickupInformation.Clear()
        currentPickupInformation = PickupTransaction.RentalRouteData.GetCustomerDataByDayAndRoute(My.Settings.DatabaseLocation, DateTimePickerRouteDate.Value.ToShortDateString)

        ' ----- Reset everything back 
        Cursor = Cursors.Default

    End Sub

    Private Sub GetOnCallCustomers()

        ' ----- Use the dictionary to find out the customers on this date 
        Dim newList As List(Of PickupTransaction.RentalCustomer.RentalCustomerData) = (From c In currentCustomerOnCall
                                                                                       Order By c.Value.CustomerName
                                                                                       Select New PickupTransaction.RentalCustomer.RentalCustomerData With
                                                                                                  {
                                                                                                      .AccountNumber = c.Value.CustomerNumber,
                                                                                                      .CustomerName = c.Value.CustomerName,
                                                                                                      .CustomerAddress = c.Value.CustomerAddress
                                                                                                  }).ToList

        If currentPickupInformation.Count > 0 Then
            For Each obj As PickupTransaction.RentalCustomer.RentalCustomerData In newList
                Try
                    Dim testObj As PickupTransaction.RentalRouteData = currentPickupInformation(obj.AccountNumber)
                    obj.Notes = testObj.Notes
                    obj.Trash = testObj.Trash
                    obj.RecycleOther = testObj.Recycle
                    obj.Cardboard = testObj.Cardboard
                    obj.Cart = testObj.Cart
                    obj.MiscCharge = testObj.MiscCharge
                    obj.RollOff = testObj.RollOff
                Catch ex As Exception

                End Try
            Next
        End If

        If TextBoxSearch.Text.Trim = "" Then
            RentalCustomerDataBindingSource.DataSource = newList
        Else
            RentalCustomerDataBindingSource.DataSource = newList.Where(Function(c) c.CustomerName.ToUpper.Contains(TextBoxSearch.Text.ToUpper) Or c.AccountNumber.ToString.Contains(TextBoxSearch.Text))
        End If

    End Sub

    Private Sub GetCustomersForSelectedDayRoute()

        ' ----- If this is Sunday ... then get out 
        If DateTimePickerRouteDate.Value.DayOfWeek = 0 Then
            RentalCustomerDataBindingSource.DataSource = Nothing
            Exit Sub
        End If

        Dim newList As List(Of PickupTransaction.RentalCustomer.RentalCustomerData) = GetCustomersForListing()

        If currentPickupInformation.Count > 0 Then
            For Each obj As PickupTransaction.RentalCustomer.RentalCustomerData In newList
                Try
                    Dim testObj As PickupTransaction.RentalRouteData = currentPickupInformation(obj.AccountNumber)
                    obj.Notes = testObj.Notes
                    obj.Trash = testObj.Trash
                    obj.RecycleOther = testObj.Recycle
                    obj.Cardboard = testObj.Cardboard
                    obj.Cart = testObj.Cart
                    obj.MiscCharge = testObj.MiscCharge
                    obj.RollOff = testObj.RollOff
                Catch ex As Exception

                End Try
            Next
        End If

        RentalCustomerDataBindingSource.DataSource = newList.OrderBy(Function(c) c.OrderOnDataSheet)

    End Sub

    Private Function GetCustomersForListing() As List(Of PickupTransaction.RentalCustomer.RentalCustomerData)

        ' ----- Use the dictionary to find out the customers on this date 
        Return (From c In currentCustomerDictionary
                Where (c.Value.RouteNumber > 0 And c.Value.DayOfTheWeek = RentalCustomerDayArray(DateTimePickerRouteDate.Value.DayOfWeek - 1)) Or (c.Value.RecycleRouteNumber > 0 And c.Value.RouteNumber = 0 And c.Value.DayOfTheWeek = RentalCustomerDayArray(DateTimePickerRouteDate.Value.DayOfWeek - 1))
                Order By c.Value.RouteNumber, c.Value.SequenceNumber
                Select New PickupTransaction.RentalCustomer.RentalCustomerData With
                           {
                               .AccountNumber = c.Value.CustomerNumber,
                               .CustomerName = c.Value.CustomerName,
                               .CustomerAddress = c.Value.CustomerAddress,
                               .HasDumpster = c.Value.HasTrashDumpster,
                               .HasCardboard = c.Value.HasCardboard,
                               .HasRecycle = c.Value.HasRecycleBin,
                               .HasCart = c.Value.Is90GallonCart,
                               .OrderOnDataSheet = If(c.Value.RouteNumber > 0, c.Value.RouteNumber, c.Value.RecycleRouteNumber * 100)
                           }).ToList

    End Function

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub EnterRentalCustomerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Refresh the dictionary
        SetCustomerDictionary()

        ' ----- Loop through the on calls 
        currentCustomerOnCall.Clear()
        currentCustomerOnCall = PickupTransaction.RentalCustomer.GetCustomerOnCall(My.Settings.DatabaseLocation)

        ' ----- Get the information from the database 
        RefreshScreen()

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RefreshScreen()
    End Sub

    Private Sub DateTimePickerRouteDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerRouteDate.ValueChanged

        ' ----- Refresh the customer dictionary 
        SetCustomerDictionary()

        ' ----- Update the screen 
        RefreshScreen()

    End Sub

    Private Sub DataGridViewRentals_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRentals.CellEndEdit

        ' ----- Get the control and the current row 
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim currentRow As DataGridViewRow = dgv.Rows(e.RowIndex)

        ' ----- Get the customer number 
        Dim customerNumber As Integer = currentRow.Cells(0).Value

        ' ----- Get the date
        Dim pickupDate As Date = DateTimePickerRouteDate.Value.ToShortDateString

        Dim entryType As Integer = 0

        Select Case dgv.Columns(e.ColumnIndex).Name

            Case "colNotes"
                entryType = 0

            Case "TrashDataGridViewTextBoxColumn"
                entryType = 1

            Case "RecycleOtherDataGridViewTextBoxColumn"
                entryType = 2

            Case "colCardboard"
                entryType = 3

            Case "colCart"
                entryType = 4

            Case "colMiscCharge"
                entryType = 5

            Case "colRollOff"
                entryType = 6

        End Select

        If Not currentRow.Cells(e.ColumnIndex).Value Is Nothing Then
            PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, pickupDate, customerNumber, entryType, currentRow.Cells(e.ColumnIndex).Value.ToString)
        Else
            PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, pickupDate, customerNumber, entryType, "")
        End If

    End Sub

    Private Sub DataGridViewOnCalls_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOnCalls.CellEndEdit

        ' ----- Get the control and the current row 
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim currentRow As DataGridViewRow = dgv.Rows(e.RowIndex)

        ' ----- Get the customer number 
        Dim customerNumber As Integer = currentRow.Cells(0).Value

        ' ----- Get the date
        Dim pickupDate As Date = DateTimePickerRouteDate.Value.ToShortDateString

        Dim entryType As Integer = 0

        Select Case dgv.Columns(e.ColumnIndex).Name

            Case "OnCallNotes"
                entryType = 0

            Case "OnCallTrash"
                entryType = 1

            Case "OnCallRecycle"
                entryType = 2

            Case "OnCallCardboard"
                entryType = 3

            Case "OnCallCart"
                entryType = 4

            Case "OnCallMiscCharge"
                entryType = 5

            Case "OnCallRollOff"
                entryType = 6

        End Select

        If Not currentRow.Cells(e.ColumnIndex).Value Is Nothing Then
            PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, pickupDate, customerNumber, entryType, currentRow.Cells(e.ColumnIndex).Value.ToString)
        Else
            PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, pickupDate, customerNumber, entryType, "")
        End If

    End Sub

    Private Sub TabControlRoutes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlRoutes.SelectedIndexChanged
        RefreshScreen()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        GetOnCallCustomers()
    End Sub

    Private Sub TextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetOnCallCustomers()
        End If
    End Sub

    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = ControlChars.Cr Then e.Handled = True
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxSearch.Text = ""
        GetOnCallCustomers()
    End Sub

    Private Sub ButtonManualEntry_Click(sender As Object, e As EventArgs) Handles ButtonManualEntry.Click
        Dim frm As New ManualRentalCustomerDataEntry
        frm.DateTimePickupDate.Value = DateTimePickerRouteDate.Value
        frm.ShowDialog()
    End Sub

    Private Sub ButtonAutoFill_Click(sender As Object, e As EventArgs) Handles ButtonAutoFill.Click

        Dim msgAnswer As DialogResult =
                MessageBox.Show(
                    "Default data will populate each customer's record.  If there is data already entered, there is a chance that data will be overwritten. Once the process completes, it cannot be undone.  Would you like to continue?",
                    "Continue", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If msgAnswer = DialogResult.Yes Then
            SetAutoData("1")
        end if

    End Sub

    Private Sub ButtonClearData_Click(sender As Object, e As EventArgs) Handles ButtonClearData.Click

        Dim msgAnswer As DialogResult =
                MessageBox.Show(
                    "This will remove all of the route data for the selected date.  Once the process completes, it cannot be undone.  Would you like to continue?",
                    "Continue", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If msgAnswer = DialogResult.Yes Then
            SetAutoData("")
        end if 

    End Sub

    Private Sub SetAutoData(updateVal As String)

        '* show the wait cursor *'
        Cursor = Cursors.WaitCursor 

        '* pull out the date  *'
        Dim dteRecord As DateTime = DateTimePickerRouteDate.Value

        '* this will give me the list of customers *' 
        Dim newList As List(Of PickupTransaction.RentalCustomer.RentalCustomerData) = GetCustomersForListing

        '* save the data to the database first *'
        For each obj As PickupTransaction.RentalCustomer.RentalCustomerData In newList
            If obj.HasDumpster Then
                PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, dteRecord, obj.AccountNumber, 1, updateVal)
            End If
            If obj.HasRecycle Then
                PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, dteRecord, obj.AccountNumber, 2, updateVal)
            End If
            If obj.HasCardboard Then
                PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, dteRecord, obj.AccountNumber, 3, updateVal)
            End If
            If obj.HasCart Then
                PickupTransaction.RentalRouteData.UpdatePickupData(My.Settings.DatabaseLocation, dteRecord, obj.AccountNumber, 4, updateVal)
            End If
        Next

        '* refresh the screen *'
        DateTimePickerRouteDate_ValueChanged(Nothing , nothing)

        '* show the normal cursor *'
        Cursor = Cursors.Default 

    End Sub

End Class