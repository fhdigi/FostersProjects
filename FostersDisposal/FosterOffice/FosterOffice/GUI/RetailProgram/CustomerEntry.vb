Imports PickupTransaction

Public Class CustomerEntry

    Public Property EditMode As Boolean = False
    Public Property CustomerNumber As Integer = 0

    Private CustomerHistoryReport As New CustomerHistory

    Private Sub CheckBoxSameAsRoute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSameAsRoute.CheckedChanged
        GroupBoxBillingAddress.Enabled = Not CheckBoxSameAsRoute.Checked
    End Sub

    Private Sub CustomerEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CustomerBindingSource.Clear()

        ComboBoxBillingType.Items.AddRange((From b In ProgramDataObject.BillingTypeObjectList Order By b.Designation Select b).ToArray)

        If _EditMode Then

            Dim obj As Customer = Customer.GetCustomer(My.Settings.DatabaseLocation, _CustomerNumber)
            CustomerBindingSource.DataSource = obj

            ' ----- Set the pickup day
            Try
                ComboBoxPickupDay.SelectedIndex = obj.PickupDay - 1
            Catch ex As Exception
            End Try


            ' ----- Set the billing type 
            Try
                ComboBoxBillingType.SelectedIndex = obj.BillingType - 1
            Catch ex As Exception
            End Try


            ' ----- Set the route 
            Try
                ComboBoxRouteNumber.SelectedIndex = obj.Route - 1
            Catch ex As Exception
            End Try

            ' ----- Set the next sequence number 
            If obj.SequenceNumber < 80000 Then
                TextBoxNextSeqNumber.Text = PickupTransaction.Customer.ReturnMaxSequenceNumber(My.Settings.DatabaseLocation).ToString
            Else
                TextBoxNextSeqNumber.Enabled = False
                ButtonMakeAccountInactive.Enabled = False
            End If

            ' ----- Set the Go In After and Amount
            Try
                CheckBoxGoInAfter.Checked = obj.GoInAfter
                TextBoxGoInAfterAmount.Text = String.Format("{0:f2}", obj.GoInAfterAmount)
            Catch ex As Exception

            End Try

            ' ----- Set the yellow tab
            Try
                CheckBoxYellowTab.Checked = obj.YellowTab
            Catch ex As Exception

            End Try

            ' ----- Fill in the vacation information 
            FillInCustomerVacation()

        Else

            ResetScreenForNewCustomer()

        End If

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
        Dim customerObj As Customer = CustomerBindingSource.DataSource

        ' ----- If there is no account number, then get out 
        If customerObj.CustomerNumber = 0 Then
            MessageBox.Show("Please enter a customer account number for this customer prior to saving", "Enter Account Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ----- If there is no sequence number, then get out 
        If customerObj.SequenceNumber = 0 Then
            MessageBox.Show("Please enter a sequence number for this customer prior to saving", "Enter Sequence Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If customerObj.LastMonthBilled = 0 Then
            MessageBox.Show("Please enter a last month billed value for this customer prior to saving", "Last Month Billed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ----- If there is no phone number, then get out 
        If customerObj.HomePhone = "" Then
            MessageBox.Show("Please enter a phone number for this customer prior to saving", "Enter Phone", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ----- I really only care about the information below if the user is an active customer
        If customerObj.SequenceNumber < 80000 Then

            ' ----- Save the pickup day 
            If ComboBoxPickupDay.SelectedIndex < 0 Then
                MessageBox.Show("Please select a pickup date for this customer before proceeding", "Enter Pickup Date", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                customerObj.PickupDay = ComboBoxPickupDay.SelectedIndex + 1
            End If

            ' ----- Save the billing type
            If ComboBoxBillingType.SelectedIndex < 0 Then
                MessageBox.Show("Please select a billing type for this customer before proceeding", "Enter Billing Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                customerObj.BillingType = ComboBoxBillingType.SelectedIndex + 1
            End If

            ' ----- Set the route 
            If ComboBoxRouteNumber.SelectedIndex < 0 Then
                MessageBox.Show("Please select a route for this customer before proceeding", "Enter Route", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                customerObj.Route = ComboBoxRouteNumber.SelectedIndex + 1
            End If

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

        ' ----- Set these manually
        customerObj.GoInAfter = CheckBoxGoInAfter.Checked

        Dim tempAmt As Single = 0.0
        If Single.TryParse(TextBoxGoInAfterAmount.Text, tempAmt) Then
            customerObj.GoInAfterAmount = tempAmt
        Else
            customerObj.GoInAfterAmount = 0.0
        End If

        customerObj.YellowTab = CheckBoxYellowTab.Checked

        If EditMode Then
            customerObj.Update(My.Settings.DatabaseLocation)
        Else
            customerObj.Save(My.Settings.DatabaseLocation)
        End If

        Dim btn As Button = DirectCast(sender, Button)

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
        CustomerBindingSource.DataSource = New Customer

        ' ----- Return the latest customer number 
        DirectCast(CustomerBindingSource.DataSource, Customer).CustomerNumber = PickupTransaction.Customer.ReturnMaxCustomerNumber(My.Settings.DatabaseLocation)

        ' ----- Set the tax rate 
        DirectCast(CustomerBindingSource.DataSource, Customer).TaxRate = Convert.ToDouble(My.Settings.TaxRate)

        ' ----- Just some default data 
        ComboBoxBillingType.SelectedIndex = 0
        ComboBoxPickupDay.SelectedIndex = 0
        ComboBoxRouteNumber.SelectedIndex = 0

        CheckBoxSameAsRoute.Checked = True

        ' ----- No need to close an account you have not created yet
        ButtonMakeAccountInactive.Enabled = False

        ' ----- Set the Go In After amounts 
        CheckBoxGoInAfter.Checked = False
        TextBoxGoInAfterAmount.Text = "0.00"

        ' ----- The yellow tab for a new customer should be set to false 
        CheckBoxYellowTab.Checked = False

        ' ----- Disable the vacation credit stuff for a new customer
        ListViewVacation.Enabled = False
        ButtonAddVacation.Enabled = False
        ButtonEditVacation.Enabled = False
        ButtonDeleteVacation.Enabled = False

        ' ----- Start the focus on the customer number 
        ActiveControl = RouteLocation_FirstNameTextBox

    End Sub

    Private Sub CustomerNumberTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerNumberTextBox.KeyDown, SequenceNumberTextBox.KeyDown, HomePhoneTextBox.KeyDown, BusinessPhoneTextBox.KeyDown, ComboBoxPickupDay.KeyDown, ComboBoxBillingType.KeyDown, TextBoxTaxRate.KeyDown, RouteLocation_FirstNameTextBox.KeyDown, RouteLocation_LastNameTextBox.KeyDown, RouteLocation_AddressTextBox.KeyDown, RouteLocation_CityTextBox.KeyDown, RouteLocation_StateTextBox.KeyDown, RouteLocation_ZipCodeTextBox.KeyDown, CheckBoxSameAsRoute.KeyDown, Billing_FirstNameTextBox.KeyDown, Billing_LastNameTextBox.KeyDown, Billing_AddressTextBox.KeyDown, Billing_CityTextBox.KeyDown, Billing_StateTextBox.KeyDown, Billing_ZipCodeTextBox.KeyDown, ComboBoxRouteNumber.KeyDown, TextBoxMonthsToBill.KeyDown, TextBoxLMB.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

    End Sub

    Private Sub BusinessPhoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CustomerNumberTextBox.KeyPress, SequenceNumberTextBox.KeyPress, HomePhoneTextBox.KeyPress, BusinessPhoneTextBox.KeyPress, ComboBoxPickupDay.KeyPress, ComboBoxBillingType.KeyPress, TextBoxTaxRate.KeyPress, RouteLocation_FirstNameTextBox.KeyPress, RouteLocation_LastNameTextBox.KeyPress, RouteLocation_AddressTextBox.KeyPress, RouteLocation_CityTextBox.KeyPress, RouteLocation_StateTextBox.KeyPress, RouteLocation_ZipCodeTextBox.KeyPress, CheckBoxSameAsRoute.KeyPress, Billing_FirstNameTextBox.KeyPress, Billing_LastNameTextBox.KeyPress, Billing_AddressTextBox.KeyPress, Billing_CityTextBox.KeyPress, Billing_StateTextBox.KeyPress, Billing_ZipCodeTextBox.KeyPress, ComboBoxRouteNumber.KeyPress, TextBoxMonthsToBill.KeyPress, TextBoxLMB.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub RouteLocation_FirstNameTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RouteLocation_FirstNameTextBox.Leave, RouteLocation_LastNameTextBox.Leave, RouteLocation_AddressTextBox .Leave , RouteLocation_CityTextBox.Leave, Billing_FirstNameTextBox.Leave, Billing_LastNameTextBox.Leave, Billing_AddressTextBox .Leave , Billing_CityTextBox.Leave

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

    Private Sub HomePhoneTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePhoneTextBox.Leave, BusinessPhoneTextBox.Leave

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

    Private Sub CheckBoxGoInAfter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxGoInAfter.CheckedChanged

        TextBoxGoInAfterAmount.Enabled = CheckBoxGoInAfter.Checked

        If TextBoxGoInAfterAmount.Enabled Then
            Dim amountTemp As Double = 0.0
            If Double.TryParse(TextBoxGoInAfterAmount.Text, amountTemp) Then
                If amountTemp = 0.0 Then
                    TextBoxGoInAfterAmount.Text = "2.00"
                End If
            End If
        End If
        
    End Sub

    Private Sub ButtonMakeAccountInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMakeAccountInactive.Click

        ' ----- Same as saving except we will set some values specifically
        ' -----> Save the data
        CustomerBindingSource.EndEdit()
        Dim customerObj As Customer = CustomerBindingSource.DataSource

        ' ----- If there is no sequence number, then get out 
        customerObj.SequenceNumber = Convert.ToInt32(TextBoxNextSeqNumber.Text)
        customerObj.PickupDay = 0
        customerObj.Route = 0

        customerObj.Update(My.Settings.DatabaseLocation)

        ' ----- Set the dialog result flag 
        DialogResult = Windows.Forms.DialogResult.OK

        ' ----- Close the form 
        Me.Close()

    End Sub

    Private Sub ButtonAddVacation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAddVacation.Click

        Dim frm As New VacationCreditForm
        frm.CustomerObject = CustomerBindingSource.DataSource

        ' ----- Show the add vacation screen  
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FillInCustomerVacation()
        End If

    End Sub

    Private Sub ButtonEditVacation_Click(sender As Object, e As System.EventArgs) Handles ButtonEditVacation.Click

        If ListViewVacation.SelectedItems.Count > 0 Then

            Dim frm As New VacationCreditForm
            Dim lvItem As ListViewItem = ListViewVacation.SelectedItems(0)
            frm.CustomerObject = CustomerBindingSource.DataSource
            frm.ExistingID = lvItem.Tag

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                FillInCustomerVacation()
            End If

        End If

    End Sub

    Private Sub ButtonDeleteVacation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDeleteVacation.Click

        If ListViewVacation.SelectedItems.Count > 0 Then

            If MessageBox.Show("Are you sure you would like to delete the selected vacation credit?  Once this process is performed, it cannot be undone.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim lvItem As ListViewItem = ListViewVacation.SelectedItems(0)
                PickupTransaction.VacationCredit.DeleteVacationDates(My.Settings.DatabaseLocation, lvItem.Tag)
                FillInCustomerVacation()
            End If

        End If

    End Sub

    Private Sub FillInCustomerVacation()

        ' ----- Remove all of the items from the vacation listing 
        ListViewVacation.Items.Clear()

        ' ---- Get the customer number 
        Dim customerNumber As Integer = DirectCast(CustomerBindingSource.DataSource, Customer).CustomerNumber

        ' ----- Get the listing of vacation credits 
        For Each vcObj As PickupTransaction.VacationCredit In PickupTransaction.VacationCredit.GetVacationCredits(My.Settings.DatabaseLocation, customerNumber)
            Dim lvItem As ListViewItem = ListViewVacation.Items.Add(vcObj.DateStart.Year.ToString)
            lvItem.Tag = vcObj.ID
            lvItem.SubItems.Add(String.Format("{0:MM/dd/yyyy}", vcObj.DateStart))
            lvItem.SubItems.Add(String.Format("{0:MM/dd/yyyy}", vcObj.DateEnd))
        Next

    End Sub

    Private Sub CutToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles CutToolStripMenuItem.Click
        RichEditOperations (sender, RTBOperations.Cut)
    End Sub

    Private Sub CopyToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichEditOperations (sender, RTBOperations.Copy)
    End Sub

    Private Sub PasteToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichEditOperations (sender, RTBOperations.Paste)
    End Sub

End Class