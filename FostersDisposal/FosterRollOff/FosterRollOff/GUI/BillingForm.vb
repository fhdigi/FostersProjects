Public Class BillingForm

    Public RollOffListing As New List(Of CRollOff)
    Public EditMode As Boolean = False
    Public RollOffToEdit As CRollOff
    Public RollOffBillDateToEdit As Date = Nothing

    Dim RollOffPickedUp As Boolean = False

    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Set the billing date
        If EditMode Then

            ' ----- Set the picker to the date of the bill
            DateTimePickerBillingDate.Value = RollOffBillDateToEdit
            ComboBoxCustomers.Items.Add(RollOffToEdit)
            ComboBoxCustomers.SelectedIndex = 0

        Else

            ' ----- Set the billing date to today 
            DateTimePickerBillingDate.Value = Now

            ' ----- Load all of the selected customers from the main screen 
            For Each custObj As CRollOff In RollOffListing.OrderBy(Function(t) t.Customer.BillingAddress.LastName)
                ComboBoxCustomers.Items.Add(custObj)
            Next

            ' ----- As long as we have one customer in the list, select the first one (just so the screen is not blank)
            If ComboBoxCustomers.Items.Count > 0 Then
                ComboBoxCustomers.SelectedIndex = 0
            End If

        End If

        ' ----- We only want to show the delete button when we are in edit mode
        ButtonDeleteBill.Visible = EditMode

    End Sub

    Private Sub CheckBoxUsePrePrintedForm_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUsePrePrintedForm.CheckedChanged
        If CheckBoxUsePrePrintedForm.Focused Then
            RefreshReport(False)
        End If
    End Sub

    Private Sub RefreshReport(tagReprintDate As Boolean)

        Dim rptFrm As New RollOffBill
        Dim reportSource As List(Of CRollOffHistoryBilling)

        ' ----- This just tacks on the Reprinted message on the bill 
        Dim reprintMessage As String = If(tagReprintDate, String.Format("Reprinted: {0:MM/dd/yyyy}", Date.Today), "")

        ' ----- Depending on whether this is a new bill or an existing bill 
        If EditMode Then
            reportSource = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff).GetRollOffBillInformation(RollOffBillDateToEdit).OrderBy(Function(t) t.TransactionDate).ToList
        Else
            reportSource = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff).GetRollOffHistoryForBilling(DateTimePickerBillingDate.Value).OrderBy(Function(t) t.TransactionDate).OrderBy(Function(t) t.BillSortOrder).ToList
        End If

        Dim loopCounter As Integer = 0
        Dim savedSubTotal As Double = 0.0
        Dim savedTax As Double = 0.0
        Dim savedTotal As Double = 0.0

        For Each objBill As CRollOffHistoryBilling In reportSource
            loopCounter += 1
            If loopCounter = 1 Then
                savedSubTotal = objBill.SubTotal
                savedTax = objBill.Tax
                savedTotal = objBill.Total
            Else
                objBill.SubTotal = savedSubTotal
                objBill.Tax = savedTax
                objBill.Total = savedTotal
            End If
            objBill.ReprintMessage = reprintMessage
        Next

        rptFrm.BindingSource1.DataSource = reportSource

        ' ------ If we do not want to see the panels
        If CheckBoxUsePrePrintedForm.Checked Then
            rptFrm.HidePanels()
        End If

        rptFrm.CreateDocument()

        ' ----- Show the form
        DocumentViewerBill.DocumentSource = rptFrm

    End Sub

    Private Function DoesRollOffHaveBillThisDate(ro As CRollOff) As Boolean

        Dim billDate As Date = DateTimePickerBillingDate.Value

        Dim savedBillObject As CBillingObject = CBillingObject.ReturnBillsList(ro).Where(Function(c) c.BillingDate.Date.ToShortDateString = billDate.Date.ToShortDateString).Select(Function(c) c).FirstOrDefault
        If savedBillObject Is Nothing Then
            Return False
        Else
            RollOffBillDateToEdit = billDate
            Return True
        End If

    End Function

    Private Sub ComboBoxCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCustomers.SelectedIndexChanged

        RollOffPickedUp = False

        ' ----- Fill in the data for the rental 
        Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)

        ' ----- If we change the drop down, this can only occur when creating bills 
        EditMode = DoesRollOffHaveBillThisDate(tempRO)

        If EditMode = False Then

            ' ----- We are looking to see if there have been any other charges for this roll off related to rental charges 
            Dim chargeListing As List(Of CCharges) = CCharges.GetChargeList(tempRO).Where(Function(c) c.ChargeType = CCharges.ChargeTypeListing.Rental).ToList

            ' ----- Determine the end date for the roll off 
            Dim dteRollOffEndRentalDate As Date = Nothing
            If tempRO.RollOffPickedUp Then
                dteRollOffEndRentalDate = tempRO.DateRollOffPickedUp
                RollOffPickedUp = True
            Else
                dteRollOffEndRentalDate = Now
            End If

            ' ----- This will set the start and end dates 
            If chargeListing.Count > 0 Then
                ' ----- Get the maximum date ... the next day then becomes the start date 
                Dim lastRentalDate As Date = chargeListing.Select(Function(c) c.ChargeDateEnd.Date).Max
                DateTimePickerRentalStart.Value = lastRentalDate + New TimeSpan(1, 0, 0, 0)
                DateTimePickerRentalEnd.Value = dteRollOffEndRentalDate
            Else
                DateTimePickerRentalStart.Value = tempRO.DateRollOffDelivered
                DateTimePickerRentalEnd.Value = dteRollOffEndRentalDate
            End If

            ' ----- Get the rental charge 
            AdjustRentalCharge()

        End If

        ' ----- Refresh the report
        RefreshReport(False)

    End Sub

    Private Sub DateTimePickerBillingDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerBillingDate.ValueChanged
        If DateTimePickerBillingDate.Focused Then
            ComboBoxCustomers_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub AdjustRentalCharge()

        ' ----- Fill in the data for the rental 
        Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)

        ' ----- Set the number of days 
        Dim numberOfDays As Integer = (DateTimePickerRentalEnd.Value - DateTimePickerRentalStart.Value).Days + If(RollOffPickedUp, 0, 1)
        TextBoxNumberOfDays.Text = numberOfDays.ToString

        ' ----- Now set the amount to be charged
        Dim rentalCharge As Double = (((DateTimePickerRentalEnd.Value - DateTimePickerRentalStart.Value).Days + If(RollOffPickedUp, 0, 1)) \ If(tempRO.RentalPeriod = 0, 1, 30)) * tempRO.RentalRate
        TextBoxRentalCharge.Text = String.Format("{0:f0}", rentalCharge)

    End Sub

#Region "Button Actions"

    Private Sub ButtonSaveRentalCharge_Click(sender As Object, e As EventArgs) Handles ButtonSaveRentalCharge.Click

        ' ----- Make sure we have a roll off object 
        Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)
        If tempRO Is Nothing Then Exit Sub

        ' ----- Count the number of days for the rental 
        Dim numberOfDays As Integer = 0
        Integer.TryParse(TextBoxNumberOfDays.Text, numberOfDays)

        ' ----- Create a new save object 
        Dim saveObj As New CCharges

        saveObj.ChargeType = CCharges.ChargeTypeListing.Rental
        saveObj.Description = String.Format("RENTAL CHARGE {0} - {1}", DateTimePickerRentalStart.Value.ToShortDateString, DateTimePickerRentalEnd.Value.ToShortDateString)
        saveObj.ChargeDateBegin = DateTimePickerRentalStart.Value.Date
        saveObj.ChargeDateEnd = DateTimePickerRentalEnd.Value.Date

        saveObj.Unit = numberOfDays
        saveObj.Rate = tempRO.RentalRate
        Double.TryParse(TextBoxRentalCharge.Text, saveObj.Total)
        saveObj.RollOffObject = tempRO
        saveObj.Save()

        RefreshReport(False)

    End Sub

    Private Sub DateTimePickerRentalStart_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerRentalStart.ValueChanged, DateTimePickerRentalEnd.ValueChanged
        AdjustRentalCharge()
    End Sub

    Private Sub ButtonSaveBill_Click(sender As Object, e As EventArgs) Handles ButtonSaveBill.Click

        ' ----- Get the roll off object 
        Dim currentROObject As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)

        ' ----- A little safety measure in case the object is not defined 
        If currentROObject Is Nothing Then Exit Sub

        ' ----- We will loop through each charge and mark its bill date 
        Dim chargeListing As List(Of CRollOffHistoryBilling) = currentROObject.GetRollOffHistoryForBilling(DateTimePickerBillingDate.Value).OrderBy(Function(t) t.TransactionDate).ToList

        For Each chrgObj As CRollOffHistoryBilling In chargeListing
            If chrgObj.TransactionType = CRollOffHistoryBilling.TransType.Charge Or chrgObj.TransactionType = CRollOffHistoryBilling.TransType.Rental Then
                Dim obj As CCharges = CCharges.FindCharge(chrgObj.TransactionDatabaseID)
                obj.MarkAsBilled(DateTimePickerBillingDate.Value)
            End If
            If chrgObj.TransactionType = CRollOffHistoryBilling.TransType.Deposit Then
                Dim obj As ITransaction = CDeposits.FindDeposit(chrgObj.TransactionDatabaseID)
                obj.MarkAsBilled(DateTimePickerBillingDate.Value)
            End If
            If chrgObj.TransactionType = CRollOffHistoryBilling.TransType.Payment Then
                Dim obj As ITransaction = CPayments.FindPayment(chrgObj.TransactionDatabaseID)
                obj.MarkAsBilled(DateTimePickerBillingDate.Value)
            End If
        Next

        ' ----- Now we need to save the tax 
        Dim newTaxCharge As New CCharges
        newTaxCharge.ChargeDateBegin = DateTimePickerBillingDate.Value.ToShortDateString
        newTaxCharge.ChargeDateEnd = DateTimePickerBillingDate.Value.ToShortDateString
        newTaxCharge.BilledDate = DateTimePickerBillingDate.Value.ToShortDateString
        newTaxCharge.ChargeType = CCharges.ChargeTypeListing.Tax
        newTaxCharge.Description = "Sales Tax"
        newTaxCharge.Rate = chargeListing(0).Tax
        newTaxCharge.Unit = 1.0
        newTaxCharge.Total = chargeListing(0).Tax
        newTaxCharge.RollOffObject = currentROObject
        newTaxCharge.HasBeenBilled = True
        newTaxCharge.Save()

        ' ----- Create a new bill object 
        Dim newBill As New CBillingObject
        newBill.BillingDate = DateTimePickerBillingDate.Value
        newBill.SubTotal = chargeListing(0).SubTotal
        newBill.Tax = chargeListing(0).Tax
        newBill.Total = chargeListing(0).Total
        newBill.RollOffObject = currentROObject
        newBill.ChargeListing = chargeListing

        ' ----- Now save the object 
        newBill.Save(EditMode)

        ' ----- Since we are still looking at this bill, change the edit mode to true 
        EditMode = True
        RollOffBillDateToEdit = DateTimePickerBillingDate.Value

    End Sub

    Private Sub ButtonDeleteBill_Click(sender As Object, e As EventArgs) Handles ButtonDeleteBill.Click

        If MessageBox.Show("Are you sure you would like to delete this bill?  Once confirmed, the process cannot be undone.  Please note ... this action only deletes the bill from the database.  It does not delete any of the charges/deposits/payments that make up the bill.  Any tax charges are removed however.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)

            ' ----- First clear out the flag from the charges 
            Dim billObj As CBillingObject = CBillingObject.GetBillInformation(tempRO, DateTimePickerBillingDate.Value)
            If billObj IsNot Nothing Then
                For Each obj As CRollOffHistoryBilling In billObj.ChargeListing
                    If obj.TransactionType = CRollOffHistoryBilling.TransType.Charge Then
                        CCharges.FindCharge(obj.TransactionDatabaseID).RemoveBillFlag(DateTimePickerBillingDate.Value)
                    End If
                    If obj.TransactionType = CRollOffHistoryBilling.TransType.Deposit Then
                        CDeposits.FindDeposit(obj.TransactionDatabaseID).RemoveBillFlag(DateTimePickerBillingDate.Value)
                    End If
                    If obj.TransactionType = CRollOffHistoryBilling.TransType.Payment Then
                        CPayments.FindPayment(obj.TransactionDatabaseID).RemoveBillFlag(DateTimePickerBillingDate.Value)
                    End If
                Next
            End If

            ' ----- Now get rid of the billing object 
            billObj.Delete()

            ' ----- Now close the screen
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub ButtonRePrintBill_Click(sender As Object, e As EventArgs) Handles ButtonRePrintBill.Click
        RefreshReport(True)
    End Sub

#End Region

#Region "Charge/Deposit/Payment Button"

    Private Sub ButtonCharges_Click(sender As Object, e As EventArgs) Handles ButtonCharges.Click

        If ComboBoxCustomers.SelectedItem IsNot Nothing Then
            Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerCharges
            frm.SelectedCustomer = tempRO.Customer
            frm.SelectedRollOff = tempRO
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshReport(False)
            End If
        End If

    End Sub

    Private Sub ButtonDeposits_Click(sender As Object, e As EventArgs) Handles ButtonDeposits.Click

        If ComboBoxCustomers.SelectedItem IsNot Nothing Then
            Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerDeposits
            frm.SelectedCustomer = tempRO.Customer
            frm.SelectedRollOff = tempRO
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshReport(False)
            End If
        End If

    End Sub

    Private Sub ButtonPayments_Click(sender As Object, e As EventArgs) Handles ButtonPayments.Click

        If ComboBoxCustomers.SelectedItem IsNot Nothing Then
            Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerPayments
            frm.SelectedCustomer = tempRO.Customer
            frm.SelectedRollOff = tempRO
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshReport(False)
            End If
        End If

    End Sub

#End Region

    Private Sub ButtonBillingLog_Click(sender As Object, e As EventArgs) Handles ButtonBillingLog.Click

        ' ----- Fill in the data for the rental 
        Dim tempRO As CRollOff = DirectCast(ComboBoxCustomers.SelectedItem, CRollOff)

        If tempRO IsNot Nothing Then
            Dim frm As New CustomerBillingLog
            frm.passedRO = tempRO
            frm.Show()
        End If

    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        BarStaticItemEditMode.Caption = If(EditMode, "Edit Mode", "New Mode")
    End Sub

End Class