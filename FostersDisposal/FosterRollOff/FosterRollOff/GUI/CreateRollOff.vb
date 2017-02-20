Public Class CreateRollOffForm

    Public Property EditMode As Boolean = False
    Public Property SelectedRollOff As CRollOff = Nothing

    Public Property FromCustomerForm As Boolean = False
    Public Property SelectedCustomer As CCustomer = Nothing
    Public Property DateRollOffDelivered As Date = Nothing
    Public Property SizeFromWaitingList As Integer = 0

    Public Property ServiceAddress As CAddressBlock = Nothing

    Public Property DeactivatedRollOff As Boolean = False

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If EditMode Then

            SelectedRollOff.DateRollOffDelivered = DateTimePickerDropOffDate.Value
            SelectedRollOff.RentalRate = Convert.ToDouble(TextBoxDailyRate.Text)
            SelectedRollOff.ServiceCharge = Convert.ToDouble(TextBoxRentalFee.Text)
            SelectedRollOff.RollOffSize = Convert.ToDouble(TextBoxSize.Text)
            SelectedRollOff.DumpingFee = Convert.ToDouble(TextBoxDumpingFee.Text)

            If CheckBoxRollOffPickedUp.Checked Then
                SelectedRollOff.RollOffPickedUp = True
                SelectedRollOff.DateRollOffPickedUp = DateTimePickerRollOffPickedUp.Value
            Else
                SelectedRollOff.RollOffPickedUp = False
            End If

            If RadioButtonDaily.Checked Then
                SelectedRollOff.RentalPeriod = 0
            Else
                SelectedRollOff.RentalPeriod = 1
            End If

            SelectedRollOff.FeeObj = DirectCast(ComboBoxRollOffFees.SelectedItem, CRollOffFee)

            ' ----- Added September 2015
            SelectedRollOff .RollOffNotes = textBoxNotes.Text 

            SelectedRollOff.Update()

        Else

            Dim newRollOffObject As New CRollOff
            newRollOffObject.Customer = SelectedCustomer
            newRollOffObject.ServiceAddress = ServiceAddress
            newRollOffObject.DateRollOffDelivered = DateTimePickerDropOffDate.Value
            newRollOffObject.RentalRate = Convert.ToDouble(TextBoxDailyRate.Text)
            newRollOffObject.RollOffSize = Convert.ToDouble(TextBoxSize.Text)
            newRollOffObject.ServiceCharge = Convert.ToDouble(TextBoxRentalFee.Text)
            newRollOffObject.DumpingFee = Convert.ToDouble(TextBoxDumpingFee.Text)

            If CheckBoxRollOffPickedUp.Checked Then
                newRollOffObject.RollOffPickedUp = True
                newRollOffObject.DateRollOffPickedUp = DateTimePickerRollOffPickedUp.Value
            Else
                newRollOffObject.RollOffPickedUp = False
            End If

            If RadioButtonDaily.Checked Then
                newRollOffObject.RentalPeriod = 0
            Else
                newRollOffObject.RentalPeriod = 1
            End If

            newRollOffObject.FeeObj = DirectCast(ComboBoxRollOffFees.SelectedItem, CRollOffFee)

            ' ----- Added September 2015
            newRollOffObject.RollOffNotes = textBoxNotes.Text 

            newRollOffObject.Save()

        End If

        ' ----- Close the screen
        DialogResult = Windows.Forms.DialogResult.OK
        Close()

    End Sub

    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs)

        Dim frm As New CustomerData
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' ----- Fill in the global list 
            FillGlobalLists()
        End If

    End Sub

    Private Sub UpdateServiceAddressLabel()

        LabelServiceAddress.Text = String.Format("Service Address: {0}, {1}, {2} {3}", ServiceAddress.Address, ServiceAddress.City, ServiceAddress.State, ServiceAddress.ZipCode)
        
        if not SelectedRollOff is nothing then

            LabelSpecialBill.Visible = SelectedRollOff.UseRollOffBillingAddress

            if (SelectedRollOff.UseRollOffBillingAddress)
                LabelSpecialBill.Text = String.Format("Roll Off Billing Address: {0}, {1}, {2} {3}", SelectedRollOff.RollOffBillingAddress.Address, SelectedRollOff.RollOffBillingAddress.City, SelectedRollOff.RollOffBillingAddress.State, SelectedRollOff.RollOffBillingAddress.ZipCode)
            End If

        Else
            LabelSpecialBill.Visible = false
        End If

    End Sub

    Private Sub UpdateBillingAddressLabel()
        LabelBillingAddress.Text = String.Format("Billing Address: {0}, {1}", SelectedCustomer.BillingAddress.Address, SelectedCustomer.BillingAddress.CSZ)
    End Sub

    Private Sub CreateRollOffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If EditMode Then
            SelectedCustomer = SelectedRollOff.Customer
            ServiceAddress = New CAddressBlock
            ServiceAddress = SelectedRollOff.ServiceAddress
        End If

        ' ----- Write out the customer 
        Dim customerString As String = String.Format("{0}", SelectedCustomer.BillingAddress.ReverseFullName)
        LabelCustomer.Text = customerString

        UpdateServiceAddressLabel()
        UpdateBillingAddressLabel()

        ' ----- Write out the account number 
        LabelAccount.Text = "Account: " & SelectedCustomer.CustomerNumber

        ComboBoxRollOffFees.Items.AddRange(CRollOffFee.GetRollOffFees.ToArray)
        RadioButtonDaily.Checked = True

        If EditMode Then

            For Each feeObj As CRollOffFee In ComboBoxRollOffFees.Items
                If feeObj.DatabaseID = SelectedRollOff.FeeObj.DatabaseID Then
                    ComboBoxRollOffFees.SelectedItem = feeObj
                    Exit For
                End If
            Next

            ' ----- Set the rest of the data 
            DateTimePickerDropOffDate.Value = SelectedRollOff.DateRollOffDelivered
            TextBoxDailyRate.Text = String.Format("{0:f2}", SelectedRollOff.RentalRate)
            TextBoxRentalFee.Text = String.Format("{0:f2}", SelectedRollOff.ServiceCharge)
            TextBoxSize.Text = String.Format("{0:f2}", SelectedRollOff.RollOffSize)
            TextBoxDumpingFee.Text = String.Format("{0:f2}", SelectedRollOff.DumpingFee)

            If SelectedRollOff.RentalPeriod = 0 Then
                RadioButtonDaily.Checked = True
            Else
                RadioButtonMonthly.Checked = True
            End If

            If SelectedRollOff.RollOffPickedUp Then
                CheckBoxRollOffPickedUp.Checked = True
                DateTimePickerRollOffPickedUp.Value = SelectedRollOff.DateRollOffPickedUp
            Else
                CheckBoxRollOffPickedUp.Checked = False
            End If

            ' ----- Added September 2015
            TextBoxNotes.Text = SelectedRollOff.RollOffNotes

            ButtonDelete.Enabled = True

            FillBillList()

        End If

        If FromCustomerForm Then


            If IsDate(DateRollOffDelivered) Then
                DateTimePickerDropOffDate.Value = Date.Today
            End If

            ' ----- We will force the size here 
            If SizeFromWaitingList <> 0 Then
                For Each feeObj As CRollOffFee In ComboBoxRollOffFees.Items
                    If feeObj.RollOffSize = SizeFromWaitingList Then
                        ComboBoxRollOffFees.SelectedItem = feeObj
                        Exit For
                    End If
                Next
            End If

            ' ----- Default to daily rental rate 
            RadioButtonDaily.Checked = True

        End If

    End Sub

    Private Sub FillBillList()
        ListViewBills.Items.Clear()
        For Each billObj As CBillingObject In CBillingObject.ReturnBillsList(SelectedRollOff)
            Dim itmX As ListViewItem = ListViewBills.Items.Add(String.Format("{0:MM/dd/yyyy}", billObj.BillingDate))
            itmX.SubItems.Add(String.Format("{0:f2}", billObj.Total))
            itmX.Tag = billObj
        Next
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If MessageBox.Show("Are you sure you would like to delete this roll off?  Once confirmed, this process cannot be undone.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            SelectedRollOff.Delete()
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ComboBoxRollOffFees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRollOffFees.SelectedIndexChanged

        Dim rollOffFees As CRollOffFee = DirectCast(ComboBoxRollOffFees.SelectedItem, CRollOffFee)

        If Not rollOffFees Is Nothing Then
            TextBoxSize.Text = String.Format("{0:f0}", rollOffFees.RollOffSize)
            TextBoxDailyRate.Text = String.Format("{0:f2}", rollOffFees.DailyFee)
            TextBoxRentalFee.Text = String.Format("{0:f2}", rollOffFees.RentalAmount)
        End If

    End Sub

    Private Sub CheckBoxRollOffPickedUp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRollOffPickedUp.CheckedChanged
        DateTimePickerRollOffPickedUp.Enabled = CheckBoxRollOffPickedUp.Checked
    End Sub

    Private Sub ButtonDeactivate_Click(sender As Object, e As EventArgs) Handles ButtonDeactivate.Click

        ' ----- Save the data 
        SelectedRollOff.Active = False
        SelectedRollOff.Update()

        ' ----- Set the flag to force a screen refresh
        DeactivatedRollOff = True

        ' ----- Close the screen 
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ButtonRefreshList_Click(sender As Object, e As EventArgs) Handles ButtonRefreshList.Click
        FillBillList()
    End Sub

    Private Sub ButtonViewBill_Click(sender As Object, e As EventArgs) Handles ButtonViewBill.Click

        If ListViewBills.SelectedItems.Count = 1 Then
            Dim tempBill As CBillingObject = DirectCast(ListViewBills.SelectedItems(0).Tag, CBillingObject)
            If tempBill IsNot Nothing Then
                Dim frm As New BillingForm
                frm.EditMode = True
                frm.RollOffToEdit = tempBill.RollOffObject
                frm.RollOffBillDateToEdit = tempBill.BillingDate
                frm.Show()
            End If
        End If

    End Sub

    Private Sub ListViewBills_DoubleClick(sender As Object, e As EventArgs) Handles ListViewBills.DoubleClick
        ButtonViewBill.PerformClick()
    End Sub

    Private Sub LabelServiceAddress_Click(sender As Object, e As EventArgs) Handles LabelServiceAddress.Click

        ' ----- We need to give the user the ability to change the service address 
        Dim frm As New RollOffServiceEdit
        frm.RollOffObj = SelectedRollOff
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SelectedRollOff.Update()
            UpdateServiceAddressLabel()
        End If

    End Sub

    Private Sub LabelBillingAddress_Click(sender As Object, e As EventArgs) Handles LabelBillingAddress.Click
        Dim frm As New EditCustomerRecord
        frm.CustomerToEdit = SelectedCustomer
        frm.ShowDialog()
        UpdateBillingAddressLabel()
    End Sub

    Private Sub TimerRollOff_Tick(sender As Object, e As EventArgs) Handles TimerRollOff.Tick
        ButtonViewBill.Enabled = (ListViewBills.SelectedItems.Count > 0)
    End Sub



End Class
