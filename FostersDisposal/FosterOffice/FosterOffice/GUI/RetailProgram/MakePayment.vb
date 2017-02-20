Imports DevExpress.XtraReports.UI

Public Class MakePayment

    Public Property SelectedCustomerNumber As Integer = 0
    Public Property EditPayment As Boolean = False
    Public Property PaymentID As Integer = 0
    Private PaymentObject As PickupTransaction.Payments

    Private Sub MakePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Show the wait form
        Dim frmWait As New WaitForm
        frmWait.Show(Me)
        frmWait.Refresh()

        ' ----- Fill in the customer number combo box 
        ComboBoxCustomerNumber.DataSource = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation, -1)
        ComboBoxCustomerNumber.DisplayMember = "NameWithAccountNumber"
        ComboBoxCustomerNumber.ValueMember = "AccountNumber"

        ' ----- Set the customer if one is given 
        If SelectedCustomerNumber > 0 Then
            ComboBoxCustomerNumber.SelectedValue = SelectedCustomerNumber
            GetPayment()
        End If

        ' ----- If we are editing a payment, then set the original edit amounts 
        If EditPayment Then

            ' ----- Get the payment object from the database 
            PaymentObject = PickupTransaction.Payments.ReturnPaymentDetails(My.Settings.DatabaseLocation, PaymentID)

            ' ----- Set the date 
            DateTimePickerPaymentDate.Value = PaymentObject.PaymentDate

            ' ----- Set the amount 
            TextBoxPaymentAmount.Text = String.Format("{0:f2}", PaymentObject.PaymentAmount)

            ' ----- Set the check number 
            TextBoxCheckNumber.Text = PaymentObject.CheckNumber.ToString

            ' ----- Set the method of payment 
            ComboBoxMOP.SelectedIndex = PaymentObject.MOP

            ' ----- Do we have a description
            If Not PaymentObject.Description Is Nothing Then
                TextBoxDescription.Text = PaymentObject.Description.Trim
            End If

            ' ----- see if we have anything in the cc auth section
            If not PaymentObject.CreditCardAuthNumber is nothing then 
                TextBoxCcAuthorization .Text = PaymentObject.CreditCardAuthNumber
            End If

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
        TextBoxDescription.Text = ""

        ' ----- Delete any lingering payment objects 
        PaymentObject = Nothing

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

            ' ----- Get the description
            Dim paymentDesc As String = ""
            If intMOP = 3 Then
                paymentDesc = TextBoxDescription.Text
            End If

            ' ----- Get the CC Auth Number
            Dim ccAuth As String = ""
            if intMOP = 4 then 
                ccAuth = TextBoxCcAuthorization.Text
            End If

            Dim continueWithSave As Boolean = True

            ' ----- Only make the check for duplicate payments when they enter a new check 
            If Not EditPayment Then
                If PickupTransaction.Payments.DoesPaymentExist(My.Settings.DatabaseLocation, customerNumber, selDate) Then
                    If MessageBox.Show("A payment already exists for this customer and payment date.  Would you still like to save this payment?", "Save Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                        continueWithSave = False
                    End If
                End If
            End If

            If customerNumber > 0 AndAlso continueWithSave Then

                If EditPayment Then
                    PaymentObject.PaymentDate = selDate
                    PaymentObject.PaymentAmount = payAmount
                    PaymentObject.CustomerID = customerNumber
                    PaymentObject.MOP = intMOP
                    PaymentObject.CheckNumber = lCheckNumber
                    PaymentObject.Description = paymentDesc
                    PaymentObject.CreditCardAuthNumber = ccAuth 
                    PaymentObject.SavePayment(My.Settings.DatabaseLocation)
                Else
                    Dim newObj As New PickupTransaction.Payments(0, selDate, payAmount, customerNumber, intMOP, lCheckNumber, paymentDesc, ccAuth)
                    newObj.SavePayment(My.Settings.DatabaseLocation)
                End If

                ' ----- Refresh the customer balance 
                PickupTransaction.Customer.SetCustomerBalances(My.Settings.DatabaseLocation, customerNumber)

                ' ----- Check to see if this is a yellow tab customer 
                Dim yf As Boolean = False
                Dim ab As Double = 0.0
                PickupTransaction.Customer.GetCustomerYellowStatus(My.Settings.DatabaseLocation, customerNumber, yf, ab)

                If yf Then

                    Dim strMsgAB As String = String.Format("This customer was marked as delinquent but the recent payment has reduced their aging balance to {0:c2}.  Would you like to remove the yellow tab for this customer", ab)
                    If MessageBox.Show(strMsgAB, "Remove Tab", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        PickupTransaction.Customer.RemoveYellowTab(My.Settings.DatabaseLocation, customerNumber)
                    End If

                ElseIf PickupTransaction.Customer.GetCustomerSequenceNumber(My.Settings.DatabaseLocation, customerNumber) >= 80000 Then

                    MessageBox.Show("Please note that this is a discontinued customer", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            Else

                ' ----- Jump out of the routine 
                Exit Sub

            End If

            ' ----- Get set to enter a new payment 
            ClearAll()

        End If

    End Sub

    Private Sub ComboBoxCustomerNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxCustomerNumber.KeyDown, DateTimePickerPaymentDate.KeyDown, TextBoxPaymentAmount.KeyDown, TextBoxCheckNumber.KeyDown, ComboBoxMOP.KeyDown, TextBoxDescription.KeyDown, TextBoxCcAuthorization .KeyDown 
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub ComboBoxCustomerNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxCustomerNumber.KeyPress, DateTimePickerPaymentDate.KeyPress, TextBoxPaymentAmount.KeyPress, TextBoxCheckNumber.KeyPress, ComboBoxMOP.KeyPress, TextBoxDescription.KeyPress, TextBoxCcAuthorization .KeyPress 
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

        TextBoxDescription.Enabled = (ComboBoxMOP.SelectedIndex = 3)
        TextBoxCcAuthorization.Enabled = (ComboBoxMOP.SelectedIndex = ComboBoxMOP.Items.Count - 1)

    End Sub

    Private Sub ButtonPrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintReceipt.Click

        ' ----- Create a new object for the payment receipt
        Dim rpt As New PaymentReceipt

        ' ----- Get the customer number 
        Dim customerNumber As Integer = ComboBoxCustomerNumber.SelectedValue

        ' ----- Get the customer history 
        Dim customerHistoryList As PickupTransaction.Customer.CCustomerHistory = PickupTransaction.Customer.CustomerHistory(My.Settings.DatabaseLocation, customerNumber, DateTimePickerPaymentDate.Value)

        Dim payAmount As Double = 0.0
        If Double.TryParse(TextBoxPaymentAmount.Text, payAmount) Then

            ' ----- Set the payment amount 
            rpt.PaymentAmount = payAmount

            ' ----- Set the payment date 
            rpt.PaymentDate = DateTimePickerPaymentDate.Value

            ' ----- Set the datasource 
            rpt.BindingSource1.DataSource = customerHistoryList

            ' ----- Print it directly 
            rpt.ShowPreview()

        End If

    End Sub

    Private Sub GetPayment()

        ' ----- Only perform this operation if the user is entering a new payment 
        If EditPayment = False Then

            Try

                Dim tempCO As PickupTransaction.Customer = PickupTransaction.Customer.GetCustomer(My.Settings.DatabaseLocation, ComboBoxCustomerNumber.SelectedValue)
                TextBoxPaymentAmount.Text = String.Format("{0:n2}", tempCO.CurrentBalance)

                If tempCO.SendToCollections Then
                    LabelCollectionMessage.Text = "NOTE: This account has been sent to collections."
                Else
                    LabelCollectionMessage.Text = ""
                End If

            Catch ex As Exception

            End Try

        Else

            Try

                Dim tempCO As PickupTransaction.Customer = PickupTransaction.Customer.GetCustomer(My.Settings.DatabaseLocation, ComboBoxCustomerNumber.SelectedValue)

                If tempCO.SendToCollections Then
                    LabelCollectionMessage.Text = "NOTE: This account has been sent to collections."
                Else
                    LabelCollectionMessage.Text = ""
                End If

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ComboBoxCustomerNumber_Leave(sender As Object, e As System.EventArgs) Handles ComboBoxCustomerNumber.Leave
        ' GetPayment()
    End Sub

    Private Sub ComboBoxCustomerNumber_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxCustomerNumber.SelectedValueChanged
        GetPayment()
    End Sub

End Class