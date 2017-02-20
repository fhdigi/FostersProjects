Public Class AddToWaitingList

    Public Property EditMode As Boolean = False
    Public Property EditedWaitingListObject As CWaitingList = Nothing

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function CheckData() As Boolean

        ' ----- Make sure we have a customer
        If ComboBoxCustomers.SelectedItem Is Nothing Then
            MessageBox.Show("You must select a customer before saving this item", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        ' ------ Definitely need a service address 
        If TextBoxAddress.Text.Trim = "" Then
            MessageBox.Show("You must enter an address before saving this item", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If TextBoxCity.Text.Trim = "" Then
            MessageBox.Show("You must enter a city before saving this item", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim tempWL As New CWaitingList

        ' ----- Make sure we have valid data 
        If Not CheckData() Then Exit Sub

        ' ----- If this is a new waiting list object, we need to assign is a unique ID 
        If EditMode = False Then
            tempWL.Customer = ComboBoxCustomers.SelectedItem
            tempWL.ServiceAddress = New CAddressBlock
        Else
            tempWL = EditedWaitingListObject
        End If

        tempWL.CallDate = DateTimePickerCallTime.Value
        tempWL.RollOffSize = DirectCast(ComboBoxRollOff.SelectedItem, CRollOffFee).RollOffSize
        tempWL.RollOffUse = TextBoxRollOffUse.Text.Trim
        tempWL.Notes = TextBoxNotes.Text.Trim

        If Not EditMode Then
            tempWL.NumberOnList = CDataExtender.GetMaxWaitingListNumber(CWaitingList.WaitListStatusTypes.OnWaitList) + 1
        End If

        ' ----- Save the service address
        tempWL.ServiceAddress.FirstName = TextBoxServiceFirstName.Text
        tempWL.ServiceAddress.LastName = TextBoxServiceLastName.Text
        tempWL.ServiceAddress.Address = TextBoxAddress.Text
        tempWL.ServiceAddress.City = TextBoxCity.Text
        tempWL.ServiceAddress.State = TextBoxState.Text
        tempWL.ServiceAddress.ZipCode = TextBoxZipCode.Text

        If EditMode Then
            tempWL.Update()
        Else
            tempWL.Save()
        End If

        ' ----- Close the screen 
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub GetPreviousServiceAddresses()

        ' ----- First make sure we have a valid customer 
        If ComboBoxCustomers.SelectedItem Is Nothing Then Exit Sub

        ' ----- Get the customer 
        Dim selectedCustomer As CCustomer = DirectCast(ComboBoxCustomers.SelectedItem, CCustomer)

        ' ----- Since we have a customer ... fill in the billing name
        TextBoxServiceFirstName.Text = selectedCustomer.BillingAddress.FirstName
        TextBoxServiceLastName.Text = selectedCustomer.BillingAddress.LastName

        ' ----- Write the notes 
        LabelCustNotes.Text = selectedCustomer.CustomerNotes.Trim

        ' ----- Check to see if the collection balance is greater than 0
        TextBoxNotes.Text = ""
        If selectedCustomer .CurrentBalanceForCollection  > 0.0 then 
            TextBoxNotes .Text = String.Format("This customer is showing a collection balance of ${0:n2}. Please verify before proceeding.", selectedCustomer .CurrentBalanceForCollection )
        End If

        ' ----- With the account number, find all of the roll offs associated
        Dim rollOffList As List(Of CRollOff) = CRollOff.GetRollOffsForCustomer(selectedCustomer.DatabaseID)

        ' ----- Fill in the previous address list 
        ListBoxPreviousAddresses.DataSource = rollOffList
        ListBoxPreviousAddresses.DisplayMember = "AddressBlock"
        ListBoxPreviousAddresses.ValueMember = "DatabaseID"

    End Sub

    Private Sub ListBoxPreviousAddresses_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxPreviousAddresses.DoubleClick

        If MessageBox.Show("Would you like to use this address as the current service address for this roll off?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            Dim rollOffID As Integer = DirectCast(ListBoxPreviousAddresses.SelectedValue, Integer)
            Dim serviceAddress As CAddressBlock = CRollOff.GetServiceAddress(rollOffID)

            Try
                TextBoxServiceFirstName.Text = serviceAddress.FirstName
                TextBoxServiceLastName.Text = serviceAddress.LastName
            Catch ex As Exception
            End Try

            TextBoxAddress.Text = serviceAddress.Address
            TextBoxCity.Text = serviceAddress.City
            TextBoxState.Text = serviceAddress.State
            TextBoxZipCode.Text = serviceAddress.ZipCode

        End If

    End Sub

    Private Sub AddToWaitingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Fill in the roll off sizes 
        ComboBoxRollOff.Items.AddRange(CRollOffFee.GetRollOffFees.ToArray)
        If ComboBoxRollOff.Items.Count > 1 Then ComboBoxRollOff.SelectedIndex = 1

        ComboBoxCustomers.Items.AddRange(CurrentCustomerList.OrderBy(Function(c) c.BillingAddress.ReverseFullName).ToArray)

        If EditMode Then

            ' ----- Get the selected customer 
            ComboBoxCustomers.SelectedItem = CurrentCustomerList.Where(Function(c) c.CustomerNumber = EditedWaitingListObject.Customer.CustomerNumber).Select(Function(c) c).FirstOrDefault

            ' ----- Write out the service address 
            Try
                TextBoxServiceFirstName.Text = EditedWaitingListObject.ServiceAddress.FirstName
            Catch ex As Exception
            End Try

            Try
                TextBoxServiceLastName.Text = EditedWaitingListObject.ServiceAddress.LastName
            Catch ex As Exception
            End Try

            TextBoxAddress.Text = EditedWaitingListObject.ServiceAddress.Address
            TextBoxCity.Text = EditedWaitingListObject.ServiceAddress.City
            TextBoxState.Text = EditedWaitingListObject.ServiceAddress.State
            TextBoxZipCode.Text = EditedWaitingListObject.ServiceAddress.ZipCode

            ' ----- Find the selected roll off 
            For Each roItem As CRollOffFee In ComboBoxRollOff.Items
                If roItem.RollOffSize = EditedWaitingListObject.RollOffSize Then
                    ComboBoxRollOff.SelectedItem = roItem
                    Exit For
                End If
            Next

            ' ----- Fill in the rest of the object 
            DateTimePickerCallTime.Value = EditedWaitingListObject.CallDate
            TextBoxRollOffUse.Text = EditedWaitingListObject.RollOffUse
            TextBoxNotes.Text = EditedWaitingListObject.Notes

        End If

    End Sub

    Private Sub ButtonAddNewCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddNewCustomer.Click

        Dim frm As New CustomerData
        frm.EditMode = False

        ' ----- Show the new list
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' ----- Fill in the global list 
            FillGlobalLists()

        End If

    End Sub

    Private Sub ComboBoxCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCustomers.SelectedIndexChanged

        ' ----- Get the previous roll off addresses of the customer 
        GetPreviousServiceAddresses()

    End Sub

    Private Sub TextBoxAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxAddress.KeyDown, TextBoxZipCode.KeyDown, TextBoxState.KeyDown, TextBoxRollOffUse.KeyDown, TextBoxNotes.KeyDown, TextBoxCity.KeyDown, DateTimePickerCallTime.KeyDown, ComboBoxRollOff.KeyDown, ComboBoxCustomers.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TextBoxAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAddress.KeyPress, TextBoxZipCode.KeyPress, TextBoxState.KeyPress, TextBoxRollOffUse.KeyPress, TextBoxNotes.KeyPress, TextBoxCity.KeyPress, DateTimePickerCallTime.KeyPress, ComboBoxRollOff.KeyPress, ComboBoxCustomers.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxAddress_Leave(sender As Object, e As EventArgs) Handles TextBoxAddress.Leave, TextBoxCity.Leave
        Dim tb As TextBox = DirectCast(sender, TextBox)
        If tb IsNot Nothing Then
            tb.Text = MakeUpperFirstLetter(tb.Text)
        End If
    End Sub

    Private Sub ButtonEditCustomer_Click(sender As Object, e As EventArgs) Handles ButtonEditCustomer.Click
        Dim frm As New EditCustomerRecord
        frm.CustomerToEdit = ComboBoxCustomers.SelectedItem
        frm.ShowDialog()
    End Sub

End Class