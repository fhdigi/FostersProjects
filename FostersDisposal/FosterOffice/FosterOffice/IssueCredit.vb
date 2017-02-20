Public Class IssueCredit

    Public Property SelectedCustomerNumber As Integer = 0
    Public Property EditPayment As Boolean = False
    Public Property PaymentID As Integer = 0
    Private PaymentObject As PickupTransaction.Payments
    Private RentalPaymentObject As PickupTransaction.RentalPayment

    Private Sub IssueCredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Show the wait form
        Dim frmWait As New WaitForm
        frmWait.Show(Me)
        frmWait.Refresh()

        ' ----- Fill in the customer number combo box 
#If RentalProgram Then

        ComboBoxCustomerNumber.DataSource = PickupTransaction.RentalCustomer.ReturnCustomerList(My.Settings.DatabaseLocation)
        ComboBoxCustomerNumber.DisplayMember = "NameWithAccountNumber"
        ComboBoxCustomerNumber.ValueMember = "CustomerNumber"

#Else

        ComboBoxCustomerNumber.DataSource = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation, -1)
        ComboBoxCustomerNumber.DisplayMember = "NameWithAccountNumber"
        ComboBoxCustomerNumber.ValueMember = "AccountNumber"

#End If

        ' ----- Set the customer if one is given 
        If SelectedCustomerNumber > 0 Then
            ComboBoxCustomerNumber.SelectedValue = SelectedCustomerNumber
        End If

        ' ----- If we are editing a payment, then set the original edit amounts 
        If EditPayment Then

            ' ----- Get the payment object from the database 
#If RentalProgram Then

            ' ----- Create a payment object 
            RentalPaymentObject = PickupTransaction.RentalPayment.ReturnPaymentDetails(My.Settings.DatabaseLocation, PaymentID)

            ' ----- Set the date 
            DateTimePickerPaymentDate.Value = RentalPaymentObject.PaymentDate

            ' ----- Set the amount 
            TextBoxPaymentAmount.Text = String.Format("{0:f2}", RentalPaymentObject.PaymentAmount)

            ' ----- Set the check number 
            TextBoxCheckNumber.Text = RentalPaymentObject.CheckNumber.ToString

            ' ----- Set the method of payment 
            ComboBoxMOP.SelectedIndex = RentalPaymentObject.MOP

#Else
            ' ----- Create a payment object 
            PaymentObject = PickupTransaction.Payments.ReturnPaymentDetails(My.Settings.DatabaseLocation, PaymentID)

            ' ----- Set the date 
            DateTimePickerPaymentDate.Value = PaymentObject.PaymentDate

            ' ----- Set the amount 
            TextBoxPaymentAmount.Text = String.Format("{0:f2}", PaymentObject.PaymentAmount)

            ' ----- Set the check number 
            TextBoxCheckNumber.Text = PaymentObject.CheckNumber.ToString

            ' ----- Set the method of payment 
            ComboBoxMOP.SelectedIndex = PaymentObject.MOP

#End If

        Else

            ' ----- Default to check
            ComboBoxMOP.SelectedIndex = 1

        End If

        ' ----- Reset the cursor 
        frmWait.Close()
        Cursor = Cursors.Default

    End Sub

    Private Sub ClearAll()

        ' ----- If we are clearing, then this is a new payment entry
        EditPayment = False

        ' ----- Blank out the customer drop down
        ComboBoxCustomerNumber.SelectedIndex = -1

        ' ----- Blank out the payment amount 
        ComboBoxMOP.SelectedIndex = 1
        TextBoxPaymentAmount.Text = "0.00"
        TextBoxCheckNumber.Text = ""

        ' ----- Delete any lingering payment objects 
        PaymentObject = Nothing
        RentalPaymentObject = Nothing

        ' ----- place the focus on the customer 
        ComboBoxCustomerNumber.Focus()

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click

        ' ----- Just close the screen 
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        ' ----- Get the selected date 
        Dim selDate As Date = DateTimePickerPaymentDate.Value

        ' ----- Get the amount they would like to pay 
        Dim payAmount As Single = 0.0

        If Single.TryParse(TextBoxPaymentAmount.Text, payAmount) Then

            ' ----- MOP
            Dim intMOP As Integer = ComboBoxMOP.SelectedIndex

            ' ----- Retrieve the check number 
            Dim lCheckNumber As Long = 0
            If intMOP = 1 Then
                Long.TryParse(TextBoxCheckNumber.Text, lCheckNumber)
            End If

            ' ----- Pull the account number from the database 
            Dim customerNumber As Integer = ComboBoxCustomerNumber.SelectedValue

            Dim continueWithSave As Boolean = True

            ' ----- Only make the check for duplicate payments when they enter a new check 
            If Not EditPayment Then

#If RentalProgram Then

                If PickupTransaction.RentalPayment.DoesPaymentExist(My.Settings.DatabaseLocation, customerNumber, selDate) Then
                    If MessageBox.Show("A credit already exists for this customer and date.  Would you still like to save this credit?", "Save Credit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                        continueWithSave = False
                    End If
                End If

#Else

                If PickupTransaction.Payments.DoesPaymentExist(My.Settings.DatabaseLocation, customerNumber, selDate) Then
                    If MessageBox.Show("A credit already exists for this customer and date.  Would you still like to save this credit?", "Save Credit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                        continueWithSave = False
                    End If
                End If

#End If

            End If

            If customerNumber > 0 AndAlso continueWithSave Then

#If RentalProgram Then

                If EditPayment Then
                    RentalPaymentObject.PaymentDate = selDate
                    RentalPaymentObject.PaymentAmount = -1.0 * payAmount
                    RentalPaymentObject.CustomerID = customerNumber
                    RentalPaymentObject.MOP = intMOP
                    RentalPaymentObject.CheckNumber = lCheckNumber
                    RentalPaymentObject.SavePayment(My.Settings.DatabaseLocation)
                Else
                    Dim newObj As New PickupTransaction.RentalPayment(0, selDate, -1.0 * payAmount, customerNumber, intMOP, lCheckNumber, "", "")
                    newObj.SavePayment(My.Settings.DatabaseLocation)
                End If

                ' ----- Refresh the customer balance 
                PickupTransaction.RentalCustomer.SetCustomerBalances(My.Settings.DatabaseLocation, customerNumber)

#Else
                If EditPayment Then
                    PaymentObject.PaymentDate = selDate
                    PaymentObject.PaymentAmount = -1.0 * payAmount
                    PaymentObject.CustomerID = customerNumber
                    PaymentObject.MOP = intMOP
                    PaymentObject.CheckNumber = lCheckNumber
                    PaymentObject.SavePayment(My.Settings.DatabaseLocation)
                Else
                    Dim newObj As New PickupTransaction.Payments(0, selDate, -1.0 * payAmount, customerNumber, intMOP, lCheckNumber, "", "")
                    newObj.SavePayment(My.Settings.DatabaseLocation)
                End If

                ' ----- Refresh the customer balance 
                PickupTransaction.Customer.SetCustomerBalances(My.Settings.DatabaseLocation, customerNumber)

#End If
            Else

                ' ----- Jump out of the routine 
                Exit Sub

            End If

        End If

        ' ----- Get set to enter a new payment 
        ClearAll()

    End Sub

    Private Sub ComboBoxCustomerNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxCustomerNumber.KeyDown, DateTimePickerPaymentDate.KeyDown, TextBoxPaymentAmount.KeyDown, TextBoxCheckNumber.KeyDown, ComboBoxMOP.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub ComboBoxCustomerNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxCustomerNumber.KeyPress, DateTimePickerPaymentDate.KeyPress, TextBoxPaymentAmount.KeyPress, TextBoxCheckNumber.KeyPress, ComboBoxMOP.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub TimerPayment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPayment.Tick

        If ComboBoxCustomerNumber.SelectedIndex > -1 And TextBoxPaymentAmount.Text <> "" Then
            ButtonSave.Enabled = True
        Else
            ButtonSave.Enabled = False
        End If

    End Sub

End Class