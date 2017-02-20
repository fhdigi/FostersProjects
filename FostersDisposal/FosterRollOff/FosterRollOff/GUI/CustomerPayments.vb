Public Class CustomerPayments

    Public Property SelectedCustomer As CCustomer = Nothing
    Public Property SelectedRollOff As CRollOff = Nothing

    Private Sub FillList()

        DataGridViewCustomerPayments.Rows.Clear()

        For Each chrObj As ITransaction In CPayments.GetPaymentList(SelectedRollOff)
            With DataGridViewCustomerPayments
                Dim newRowIndex As Integer = .Rows.Add
                .Rows(newRowIndex).Cells("colID").Value = chrObj.DatabaseID
                .Rows(newRowIndex).Cells("colBillDate").Value = If(chrObj.HasBeenBilled, String.Format("{0:MM/dd/yyyy}", chrObj.BilledDate), "")
                .Rows(newRowIndex).Cells("colDescription").Value = chrObj.Description
                .Rows(newRowIndex).Cells("colPaymentDate").Value = String.Format("{0:MM/dd/yyyy}", chrObj.TransactionDate)
                .Rows(newRowIndex).Cells("colPaymentAmount").Value = String.Format("{0:f2}", chrObj.Amount)
                .Rows(newRowIndex).Cells("colCheckNumber").Value = chrObj.CheckNumber
                .Rows(newRowIndex).Cells("colCreditCard").Value = String.Format("{0:f2}", chrObj.Amount)

                ' ----- new for credit cards 
                dim checkCell As DataGridViewCheckBoxCell = DirectCast(.Rows(newRowIndex).Cells("colCreditCard"), DataGridViewCheckBoxCell)
                checkCell.Value = chrObj.CreditCardTransaction
                .Rows(newRowIndex).Cells("colAuthNumber").Value = chrObj.CreditCardAuthNumber
                .Rows(newRowIndex).Cells("colTransactionId").Value = chrObj.TransactionId

            End With
        Next

    End Sub

    Private Sub CustomerCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelHeader.Text = SelectedCustomer.BillingAddress.FirstName & " " & SelectedCustomer.BillingAddress.LastName
        FillList()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        For Each dgr As DataGridViewRow In DataGridViewCustomerPayments.Rows

            Dim saveObj As New CPayments
            Dim newRecord As Boolean = False

            If dgr.Cells("colID").Value Is Nothing Then
                'saveObj.AssignID()
                newRecord = True
            Else
                saveObj.DatabaseID = dgr.Cells("colID").Value
            End If

            ' ----- Would rather not save the rental charge here but this may change 
            saveObj.Description = dgr.Cells("colDescription").Value
            saveObj.TransactionDate = dgr.Cells("colPaymentDate").Value
            saveObj.Amount = dgr.Cells("colPaymentAmount").Value
            saveObj.CheckNumber = dgr.Cells("colCheckNumber").Value
            saveObj.RollOffObject = SelectedRollOff

            ' ----- Save the billed on date 
            If Not dgr.Cells("colBillDate").Value Is Nothing Then
                If dgr.Cells("colBillDate").Value.ToString <> "" AndAlso IsDate(dgr.Cells("colBillDate").Value.ToString) Then
                    saveObj.HasBeenBilled = True
                    saveObj.BilledDate = dgr.Cells("colBillDate").Value
                End If
            End If

            ' ----- new for credit cards 
            dim checkCell As DataGridViewCheckBoxCell = DirectCast(dgr.Cells("colCreditCard"), DataGridViewCheckBoxCell)
            saveObj.CreditCardTransaction = checkCell.Value
            saveObj.CreditCardAuthNumber = dgr.Cells("colAuthNumber").Value
            saveObj.TransactionId = dgr.Cells("colTransactionId").Value

            If newRecord Then
                saveObj.Save()
            Else
                saveObj.Update()
            End If

        Next

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        If MessageBox.Show("Are you sure you would like to delete the selected payment?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim selectedDGR As DataGridViewRow = DataGridViewCustomerPayments.SelectedRows(0)
            Dim delChargeObj As New CPayments
            delChargeObj.DatabaseID = selectedDGR.Cells("colID").Value
            delChargeObj.Description = selectedDGR.Cells("colDescription").Value
            delChargeObj.TransactionDate = selectedDGR.Cells("colPaymentDate").Value
            delChargeObj.Amount = selectedDGR.Cells("colPaymentAmount").Value
            delChargeObj.CheckNumber = selectedDGR.Cells("colCheckNumber").Value
            delChargeObj.RollOffObject = SelectedRollOff
            If delChargeObj IsNot Nothing Then delChargeObj.Delete()
            FillList()
        End If

    End Sub

    Private Sub ButtonQuickPayment_Click(sender As Object, e As EventArgs) Handles ButtonQuickPayment.Click

        With DataGridViewCustomerPayments
            Dim newPaymentRow As Integer = .Rows.Add
            .Rows(newPaymentRow).Cells("colDescription").Value = "PAYMENT"
            .Rows(newPaymentRow).Cells("colPaymentDate").Value = String.Format("{0:MM/dd/yyyy}", Date.Today)
            .CurrentCell = .Rows(newPaymentRow).Cells("colPaymentAmount")
            .BeginEdit(True)
        End With

    End Sub

    Private Sub ButtonPrintReceipt_Click(sender As Object, e As EventArgs) Handles ButtonPrintReceipt.Click

        If DataGridViewCustomerPayments.SelectedRows.Count > 0 Then

            Dim frm As New PaymentReports

            ' ----- Get the selected row 
            Dim selectedDGR As DataGridViewRow = DataGridViewCustomerPayments.SelectedRows(0)

            ' ----- Fill in the data from the grid 
            frm.Receipt.PaymentDate = selectedDGR.Cells("colPaymentDate").Value
            frm.Receipt.Amount = selectedDGR.Cells("colPaymentAmount").Value

            Dim checkNumber As String = selectedDGR.Cells("colCheckNumber").Value.ToString
            frm.Receipt.MOP = If(IsNumeric(checkNumber), "Check # ", "") & checkNumber

            ' ----- Get the customer information 
            frm.Receipt.CustomerNumber = SelectedRollOff.Customer.CustomerNumber
            frm.Receipt.CustomerName = SelectedRollOff.Customer.BillingAddress.FullName
            frm.Receipt.BillingAddress = SelectedRollOff.Customer.BillingAddress.Address
            frm.Receipt.BillingCSZ = SelectedRollOff.Customer.BillingAddress.CSZ
            frm.Receipt.ServiceAddress = SelectedRollOff.ServiceAddress.Address
            frm.Receipt.ServiceCSZ = SelectedRollOff.ServiceAddress.CSZ

            ' ----- Pass in the current balance 
            if SelectedRollOff.Customer .SendToCollections then 
                dim paymentsSinceCollections = CPayments.GetPaymentList (SelectedRollOff).Where(Function(f) f.TransactionDate > SelectedRollOff .Customer .CollectionBalanceAsOf ).Sum(function(f) f.Amount)
                frm.Receipt.CurrentBalance = SelectedRollOff.Customer.CurrentBalanceForCollection - paymentsSinceCollections
            Else
                frm.Receipt.CurrentBalance = SelectedRollOff.RollOffTotalCharge
            End If
            
            ' ----- Set the report type 
            frm.CurrentReportType = PaymentReports.ReportType.PrintReceipt

            ' ----- Show the report 
            frm.Show(Me)

        End If

    End Sub

    Private Sub ButtonPrintPaymentReport_Click(sender As Object, e As EventArgs) Handles ButtonPrintPaymentReport.Click

        Dim frm As New PaymentReports
        frm.PaymentListing = CPayments.GetPaymentList(SelectedRollOff)
        frm.CurrentReportType = PaymentReports.ReportType.PaymentListing
        frm.Show(Me)

    End Sub

End Class