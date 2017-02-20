Public Class CustomerData

    Public Property EditMode As Boolean = False
    Public Property SelectedCustomer As CCustomer = Nothing
    Public Property NewLastName As String = ""

    Private Sub CustomerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If EditMode = False Then
            CustomerNumberTextBox.Text = "02-" & CCustomer.GetNextBaseCustomerNumber.ToString
            BillingStateTextBox.Text = "NY"
            TextBoxTaxRate.Text = "0.08"
        End If

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If EditMode Then

            With SelectedCustomer

                .ContactName = ContactNameTextBox.Text
                .HomePhone = HomePhoneTextBox.Text
                .BusinessPhone = BusinessPhoneTextBox.Text
                .TaxRate = TextBoxTaxRate.Text
                .BillingAddress.FirstName = BillingFirstNameTextBox.Text
                .BillingAddress.LastName = BillingLastNameTextBox.Text
                .BillingAddress.Address = BillingAddressTextBox.Text
                .BillingAddress.City = BillingCityTextBox.Text
                .BillingAddress.State = BillingStateTextBox.Text
                .BillingAddress.ZipCode = BillingZipCodeTextBox.Text
                .SendToCollections = CheckBoxCollections.Checked
                .CustomerNotes = TextBoxNotes.Text

                ' ----- Save the current balance 
                If (TextBoxCurrentBalance.Text.Trim <> "") Then
                    .CurrentBalanceForCollection = Convert.ToDouble(TextBoxCurrentBalance.Text)
                Else
                    .CurrentBalanceForCollection = 0.0
                End If

                ' ----- Save the as of date 
                .CollectionBalanceAsOf = DateTimePickerCollectionBalance.Value

                ' ----- Save the data 
                .Update()

            End With

        Else

            Dim newCustomer As New CCustomer
            With newCustomer

                .BillingAddress = New CAddressBlock
                '.PickUpAddress = New CAddressBlock

                ' ----- Parse out the customer information 
                .CustomerNumber = CustomerNumberTextBox.Text
                .CustomerNumberPrefix = "02"
                .CustomerNumberBase = Convert.ToInt32(.CustomerNumber.Substring(.CustomerNumber.IndexOf("-") + 1))

                .ContactName = ContactNameTextBox.Text
                .HomePhone = HomePhoneTextBox.Text
                .BusinessPhone = BusinessPhoneTextBox.Text
                .TaxRate = TextBoxTaxRate.Text
                .BillingAddress.FirstName = BillingFirstNameTextBox.Text
                .BillingAddress.LastName = BillingLastNameTextBox.Text
                .BillingAddress.Address = BillingAddressTextBox.Text
                .BillingAddress.City = BillingCityTextBox.Text
                .BillingAddress.State = BillingStateTextBox.Text
                .BillingAddress.ZipCode = BillingZipCodeTextBox.Text

                ' ----- Set this for later
                NewLastName = .BillingAddress.LastName

                ' ----- This flag tells the system that an account may not have an active rolloff but money is owed
                .SendToCollections = CheckBoxCollections.Checked

                ' ----- Save the balance 
                If (TextBoxCurrentBalance.Text.Trim <> "") Then
                    .CurrentBalanceForCollection = Convert.ToDouble(TextBoxCurrentBalance.Text)
                Else
                    .CurrentBalanceForCollection = 0.0
                End If

                ' ----- Save the as of date 
                .CollectionBalanceAsOf = DateTimePickerCollectionBalance.Value

                ' ----- Save the customer notes 
                .CustomerNotes = TextBoxNotes.Text

                .Save()

            End With

        End If

        ' ----- Close the screen 
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ContactNameTextBox_Leave(sender As Object, e As EventArgs) Handles ContactNameTextBox.Leave

        If EditMode = False Then

            Dim charSep() As Char = {" "c}

            Dim tempName As String = ContactNameTextBox.Text
            Dim nameArray() As String = tempName.Split(charSep, 5, StringSplitOptions.RemoveEmptyEntries)

            If nameArray.Length = 1 Then
                BillingFirstNameTextBox.Text = MakeUpperFirstLetter(nameArray(0))
            ElseIf nameArray.Length >= 2 Then
                BillingFirstNameTextBox.Text = MakeUpperFirstLetter(nameArray(0))

                Dim tempLastName As String = ""
                For iCounter As Integer = 1 To nameArray.Count - 1
                    tempLastName &= nameArray(iCounter) & " "
                Next
                BillingLastNameTextBox.Text = MakeUpperFirstLetter(tempLastName.Trim)

            End If

        End If

        Dim tb As TextBox = DirectCast(sender, TextBox)
        If tb IsNot Nothing Then
            tb.Text = MakeUpperFirstLetter(tb.Text)
        End If

    End Sub

    Private Sub CustomerNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerNumberTextBox.KeyDown, TextBoxTaxRate.KeyDown, HomePhoneTextBox.KeyDown, ContactNameTextBox.KeyDown, CheckBoxCollections.KeyDown, BusinessPhoneTextBox.KeyDown, BillingZipCodeTextBox.KeyDown, BillingStateTextBox.KeyDown, BillingLastNameTextBox.KeyDown, BillingFirstNameTextBox.KeyDown, BillingCityTextBox.KeyDown, BillingAddressTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub CustomerNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomerNumberTextBox.KeyPress, TextBoxTaxRate.KeyPress, HomePhoneTextBox.KeyPress, ContactNameTextBox.KeyPress, CheckBoxCollections.KeyPress, BusinessPhoneTextBox.KeyPress, BillingZipCodeTextBox.KeyPress, BillingStateTextBox.KeyPress, BillingLastNameTextBox.KeyPress, BillingFirstNameTextBox.KeyPress, BillingCityTextBox.KeyPress, BillingAddressTextBox.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub PickupAddressTextBox_Leave(sender As Object, e As EventArgs) Handles BillingLastNameTextBox.Leave, BillingFirstNameTextBox.Leave, BillingCityTextBox.Leave, BillingAddressTextBox.Leave
        Dim tb As TextBox = DirectCast(sender, TextBox)
        If tb IsNot Nothing Then
            tb.Text = MakeUpperFirstLetter(tb.Text)
        End If
    End Sub

Private Sub HomePhoneTextBox_Leave( sender As Object,  e As EventArgs) Handles HomePhoneTextBox.Leave

        Dim workingNumber As String = HomePhoneTextBox.Text
        Dim filteredNumber As String = workingNumber

        If workingNumber.Length = 7 then 
            filteredNumber = workingNumber.Substring (0,3) & "-" & workingNumber.Substring (3,4)
        End If

        If workingNumber.Length = 10 then 
            filteredNumber = workingNumber.Substring (0,3) & "-" & workingNumber.Substring (3,3) & "-" & workingNumber .Substring (6,4)
        End If

        HomePhoneTextBox .Text = filteredNumber  

End Sub

Private Sub BusinessPhoneTextBox_Leave( sender As Object,  e As EventArgs) Handles BusinessPhoneTextBox.Leave

        Dim workingNumber As String = BusinessPhoneTextBox.Text
        Dim filteredNumber As String = workingNumber

        If workingNumber.Length = 7 then 
            filteredNumber = workingNumber.Substring (0,3) & "-" & workingNumber.Substring (3,4)
        End If

        If workingNumber.Length = 10 then 
            filteredNumber = workingNumber.Substring (0,3) & "-" & workingNumber.Substring (3,3) & "-" & workingNumber .Substring (6,4)
        End If

        BusinessPhoneTextBox .Text = filteredNumber 

End Sub

End Class