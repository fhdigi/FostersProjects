Imports PickupTransaction

Public Class RentalCustomerEntry

    Public Property EditMode As Boolean = False
    Public Property CustomerNumber As Integer = 0
    Public Property TabIndexToDisplay As Integer = 0

    Private CustomerHistoryReport As New CustomerHistory

    Private Sub RentalCustomerEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CustomerBindingSource.Clear()

        If _EditMode Then

            Dim obj As RentalCustomer = RentalCustomer.GetRentalCustomer(My.Settings.DatabaseLocation, _CustomerNumber)
            CustomerBindingSource.DataSource = obj

            ' ----- Set the route 
            Try
                ComboBoxRouteNumber.SelectedIndex = obj.Route - 1
            Catch ex As Exception
            End Try

            Try
                ComboBoxDumpsterPUCharge.SelectedIndex = obj.DumpsterPUType
                ComboBoxCartPUCharge.SelectedIndex = obj.Cart90GallonPUType
                ComboBoxCardboardPUCharge.SelectedIndex = obj.CardboardPUType
                ComboBoxRecyclePUCharge.SelectedIndex = obj.RecyclePUType
            Catch ex As Exception
            End Try

            ' ----- Get the pickup information 
            FillInPickupInformation(obj.CustomerNumber)

        Else

            ResetScreenForNewCustomer()

        End If

        TabControlCustomer.SelectedTab = TabControlCustomer.TabPages(TabIndexToDisplay)

    End Sub

    Private Sub CheckBoxSameAsRoute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSameAsRoute.CheckedChanged
        GroupBoxBillingAddress.Enabled = Not CheckBoxSameAsRoute.Checked
    End Sub

    Private Function SavePickupInformation(customerNumber As Integer) As Integer

        Dim returnVal As Integer = 0

        With DataGridViewPickupDays

            For Each dgr As DataGridViewRow In .Rows

                Dim tempObj As New PickupTransaction.RentalPickupInformation

                ' ----- Pull out the customer number 
                tempObj.CustomerNumber = customerNumber

                ' ----- See if we have a dumpster 
                tempObj.DumpsterIndex = dgr.Cells("colType").Value

                ' ----- We need to at least have a dumpster set 
                If Not tempObj.DumpsterIndex Is Nothing AndAlso tempObj.DumpsterIndex.ToString <> "" Then
                    tempObj.ID = dgr.Cells("colID").Value
                    tempObj.SequenceNumber = dgr.Cells("colSeqNumber").Value
                    tempObj.DaysIndex = dgr.Cells("colDays").Value
                    tempObj.LoadIndex = dgr.Cells("colLoadType").Value
                    tempObj.SizeIndex = dgr.Cells("colDumpsterSize").Value
                    tempObj.Route = dgr.Cells("colRoute").Value
                    tempObj.MiscText = dgr.Cells("colMisc").Value

                    ' ----- Added 26-Apr-2013
                    tempObj.TruckNotes = dgr.Cells("colTruckNotes").Value

                    PickupTransaction.RentalPickupInformation.SetCustomerPickupInformation(My.Settings.DatabaseLocation, tempObj)

                    Select Case tempObj.DaysIndex
                        Case "Monday"
                            If Not returnVal And 1 Then returnVal += 1
                        Case "Tuesday"
                            If Not returnVal And 2 Then returnVal += 2
                        Case "Wednesday"
                            If Not returnVal And 4 Then returnVal += 4 '
                        Case "Thursday"
                            If Not returnVal And 8 Then returnVal += 8
                        Case "Friday"
                            If Not returnVal And 16 Then returnVal += 16
                        Case "Saturday"
                            If Not returnVal And 32 Then returnVal += 32
                    End Select

                End If

            Next

        End With

        Return returnVal

    End Function

    Private Sub FillInPickupInformation(customerNumber As Integer)

        Dim listingPU As List(Of PickupTransaction.RentalPickupInformation) = PickupTransaction.RentalPickupInformation.GetCustomerPickupInformation(My.Settings.DatabaseLocation, customerNumber)

        With DataGridViewPickupDays

            ' ----- Remove all of the rows 
            .Rows.Clear()

            For Each pickObj As PickupTransaction.RentalPickupInformation In listingPU

                ' ----- Add a new row 
                Dim newRowIndex As Integer = .Rows.Add

                ' ----- Write out the information 
                .Rows(newRowIndex).Cells("colID").Value = pickObj.ID
                .Rows(newRowIndex).Cells("colSeqNumber").Value = pickObj.SequenceNumber
                .Rows(newRowIndex).Cells("colType").Value = pickObj.DumpsterIndex
                .Rows(newRowIndex).Cells("colDays").Value = pickObj.DaysIndex
                .Rows(newRowIndex).Cells("colLoadType").Value = pickObj.LoadIndex
                .Rows(newRowIndex).Cells("colDumpsterSize").Value = pickObj.SizeIndex
                .Rows(newRowIndex).Cells("colRoute").Value = pickObj.Route
                .Rows(newRowIndex).Cells("colMisc").Value = pickObj.MiscText
                .Rows(newRowIndex).Cells("colTruckNotes").Value = pickObj.TruckNotes

            Next

        End With

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click

        ' ----- Set the dialog result flag 
        DialogResult = Windows.Forms.DialogResult.Cancel

        ' ----- Cancel the pending edit 
        CustomerBindingSource.CancelEdit()

        ' ----- Close the form 
        Me.Close()

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click, ButtonSaveAndClose.Click

        ' -----> Save the data
        CustomerBindingSource.EndEdit()
        Dim customerObj As RentalCustomer = CustomerBindingSource.DataSource

        ' ----- If there is no account number, then get out 
        If customerObj.CustomerNumber = 0 Then
            MessageBox.Show("Please enter a customer account number for this customer prior to saving", "Enter Account Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ----- If there is no phone number, then get out 
        If customerObj.BusinessPhone = "" Then
            MessageBox.Show("Please enter a business phone number for this customer prior to saving", "Enter Phone", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ----- Copy the route information over to the billing information
        If CheckBoxSameAsRoute.Checked Then
            customerObj.Billing_Address = customerObj.RouteLocation_Address
            customerObj.Billing_City = customerObj.RouteLocation_City
            customerObj.Billing_FirstName = customerObj.RouteLocation_FirstName
            customerObj.Billing_LastName = customerObj.RouteLocation_LastName
            customerObj.Billing_State = customerObj.RouteLocation_State
            customerObj.Billing_ZipCode = customerObj.RouteLocation_ZipCode
        End If

        Try
            If customerObj.Billing_LastName.Trim = "" Then customerObj.Billing_LastName = " "
            If customerObj.RouteLocation_LastName.Trim = "" Then customerObj.RouteLocation_LastName = " "
        Catch ex As Exception

        End Try

        ' ----- Save the charge information
        customerObj.DumpsterPUType = If(ComboBoxDumpsterPUCharge.SelectedIndex = -1, 0, ComboBoxDumpsterPUCharge.SelectedIndex)
        customerObj.Cart90GallonPUType = If(ComboBoxCartPUCharge.SelectedIndex = -1, 1, ComboBoxCartPUCharge.SelectedIndex)
        customerObj.CardboardPUType = If(ComboBoxCardboardPUCharge.SelectedIndex = -1, 0, ComboBoxCardboardPUCharge.SelectedIndex)
        customerObj.RecyclePUType = If(ComboBoxRecyclePUCharge.SelectedIndex = -1, 0, ComboBoxRecyclePUCharge.SelectedIndex)

        ' ----- Save the pickup days
        customerObj.PickupDay = SavePickupInformation(customerObj.CustomerNumber)

        If EditMode Then
            customerObj.Update(My.Settings.DatabaseLocation)
        Else
            customerObj.Save(My.Settings.DatabaseLocation)
        End If

        ' ----- Get a pointer to the button that called the routine
        Dim btn As Button = DirectCast(sender, Button)

        ' ----- Depending on what was pressed, save the data and close or stay 
        If btn.Name = "ButtonSaveAndClose" Then

            ' ----- Set the dialog result flag 
            DialogResult = Windows.Forms.DialogResult.OK

            ' ----- Close the form 
            Me.Close()

        Else

            ResetScreenForNewCustomer()

        End If

        ' ----- Once we get here, we can fill in the customer dictionary
        ProgramDataObject.UpdateCustomerDictionary(My.Settings.DatabaseLocation)

    End Sub

    Private Sub ResetScreenForNewCustomer()

        ' ----- Create a new data object 
        CustomerBindingSource.DataSource = New RentalCustomer

        ' ----- Return the latest customer number 
        DirectCast(CustomerBindingSource.DataSource, RentalCustomer).CustomerNumber = PickupTransaction.RentalCustomer.ReturnMaxCustomerNumber(My.Settings.DatabaseLocation)

        ' ----- Set the tax rate 
        DirectCast(CustomerBindingSource.DataSource, RentalCustomer).TaxRate = Convert.ToDouble(My.Settings.TaxRate)

        ' ----- Just some default data 
        ComboBoxRouteNumber.SelectedIndex = 0

        CheckBoxSameAsRoute.Checked = True

        ' ----- Start the focus on the customer number 
        ActiveControl = RouteLocation_FirstNameTextBox

        ' ----- Remove the pickup days grid
        DataGridViewPickupDays.Rows.Clear()

    End Sub

    Private Sub CustomerNumberTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerNumberTextBox.KeyDown, HomePhoneTextBox.KeyDown, BusinessPhoneTextBox.KeyDown, RouteLocation_FirstNameTextBox.KeyDown, RouteLocation_LastNameTextBox.KeyDown, RouteLocation_AddressTextBox.KeyDown, RouteLocation_CityTextBox.KeyDown, RouteLocation_StateTextBox.KeyDown, RouteLocation_ZipCodeTextBox.KeyDown, CheckBoxSameAsRoute.KeyDown, Billing_FirstNameTextBox.KeyDown, Billing_LastNameTextBox.KeyDown, Billing_AddressTextBox.KeyDown, Billing_CityTextBox.KeyDown, Billing_StateTextBox.KeyDown, Billing_ZipCodeTextBox.KeyDown, TextBoxMonthsToBill.KeyDown, TextBoxLMB.KeyDown, TextBoxFax.KeyDown, TextBoxEMailAddress.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

    End Sub

    Private Sub BusinessPhoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CustomerNumberTextBox.KeyPress, HomePhoneTextBox.KeyPress, BusinessPhoneTextBox.KeyPress, RouteLocation_FirstNameTextBox.KeyPress, RouteLocation_LastNameTextBox.KeyPress, RouteLocation_AddressTextBox.KeyPress, RouteLocation_CityTextBox.KeyPress, RouteLocation_StateTextBox.KeyPress, RouteLocation_ZipCodeTextBox.KeyPress, CheckBoxSameAsRoute.KeyPress, Billing_FirstNameTextBox.KeyPress, Billing_LastNameTextBox.KeyPress, Billing_AddressTextBox.KeyPress, Billing_CityTextBox.KeyPress, Billing_StateTextBox.KeyPress, Billing_ZipCodeTextBox.KeyPress, TextBoxMonthsToBill.KeyPress, TextBoxLMB.KeyPress, TextBoxFax.KeyPress, TextBoxEMailAddress.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub RouteLocation_FirstNameTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RouteLocation_FirstNameTextBox.Leave, RouteLocation_LastNameTextBox.Leave, RouteLocation_AddressTextBox.Leave, RouteLocation_CityTextBox.Leave, Billing_FirstNameTextBox.Leave, Billing_LastNameTextBox.Leave, Billing_AddressTextBox.Leave, Billing_CityTextBox.Leave

        Dim newText As String = ""
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim charSpace As Char() = "{ }"

        Try

            ' ----- Determine if this is a multi-word text
            Dim wordArray() As String = tb.Text.Split (charSpace , 5, StringSplitOptions.RemoveEmptyEntries )

            ' ----- Make sure we have something to parse 
            If wordArray .Length > 0 then 
                For iCount As Integer = 0 to wordArray .Length - 1
                    newText  &= If (iCount > 0 , " " , "") & wordArray (iCount).Substring(0, 1).ToUpper & wordArray (iCount).Substring(1)                    
                Next
            End If

            ' ----- replace the text box 
            tb.Text = newText 

            ' ----- This is the code that was replaced 17-Jan-2015
            'If tempText.Length >= 1 Then
            '    tb.Text = tempText.Substring(0, 1).ToUpper & tempText.Substring(1)
            'End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HomePhoneTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePhoneTextBox.Leave, BusinessPhoneTextBox.Leave, TextBoxFax.Leave, TextBoxEMailAddress.Leave

        Dim tempText As String = ""
        Dim tb As TextBox = DirectCast(sender, TextBox)

        Try
            tempText = tb.Text.Trim
            If tempText.Length = 7 And Not tempText.Contains("-") Then
                tb.Text = tempText.Substring(0, 3) & "-" & tempText.Substring(3)
            ElseIf tempText.Length = 10 Then
                tb.Text = "(" & tempText.Substring(0, 3) & ") " & tempText.Substring(3, 3) & "-" & tempText.Substring(6)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonDeleteSelectedLine_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSelectedLine.Click

        ' ----- Check to see if there is a selected row 
        If DataGridViewPickupDays.SelectedRows.Count > 0 Then

            If MessageBox.Show("Are you sure you would like to delete the selected row?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                ' ----- Get the selected row 
                Dim selectedRow As DataGridViewRow = DataGridViewPickupDays.SelectedRows(0)

                ' ----- Get the ID
                Dim pickupID As Integer = selectedRow.Cells("colID").Value

                ' ----- Delete the record from the database 
                PickupTransaction.RentalPickupInformation.DeletePickupRecord(My.Settings.DatabaseLocation, pickupID)

                ' ----- Remove the row
                DataGridViewPickupDays.Rows.Remove(selectedRow)

            End If

        End If

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichEditOperations(sender, RTBOperations.Cut )
    End Sub

    Private Sub CopyToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichEditOperations(sender , RTBOperations.Copy )
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichEditOperations(sender, RTBOperations.Paste )
    End Sub

End Class