Public Class MainScreen

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGlobalLists()
        FillGrid(Nothing)
    End Sub

    Private Sub FillGrid(roObj As CRollOff)

        ShowStatusForm.Show(Me)
        ShowStatusForm.Refresh()

        ' ----- Refresh the transactions list 
        FillTransactions()

        If roObj Is Nothing Then

            ' ----- Clear all of the rows 
            DataGridViewRollOffs.Rows.Clear()

            Try

                Dim rollOffList As List(Of CRollOff) = CDataExtender.GetListOfActiveRollOffs.OrderBy(Function(c) c.Customer.BillingAddress.FirstName).OrderBy(Function(c) c.Customer.BillingAddress.LastName).ToList

                For Each roObj In rollOffList
                    With DataGridViewRollOffs
                        Dim newRowIndex As Integer = .Rows.Add
                        .Rows(newRowIndex).Cells("colUniqueID").Value = roObj.DatabaseID
                        .Rows(newRowIndex).Cells("colAccountNumber").Value = roObj.Customer.CustomerNumber
                        .Rows(newRowIndex).Cells("colCustomer").Value = String.Format("{0} ({1}, {2})", roObj.Customer, roObj.ServiceAddress.Address, roObj.ServiceAddress.City)
                        .Rows(newRowIndex).Cells("colRollOffDelivered").Value = roObj.DateRollOffDelivered
                        .Rows(newRowIndex).Cells("colSize").Value = roObj.RollOffSize
                        .Rows(newRowIndex).Cells("colDay").Value = roObj.DaysHadRollOff
                        .Rows(newRowIndex).Cells("colDateRollOffPickedUp").Value = roObj.DateRollOffPickedUp
                        .Rows(newRowIndex).Cells("TotalDeposits").Value = roObj.TotalDeposits
                        .Rows(newRowIndex).Cells("colDumpingCharges").Value = roObj.TotalCharges
                        .Rows(newRowIndex).Cells("TotalPayments").Value = roObj.TotalPayments
                        .Rows(newRowIndex).Cells("RollOffTotalCharge").Value = roObj.RollOffTotalCharge
                        .Rows(newRowIndex).Cells("colLastBill").Value = roObj.DisplayedLastBillDetails

                        Dim linkCell As DataGridViewLinkCell = .Rows(newRowIndex).Cells("colCustomer")
                        If roObj.RollOffTotalCharge > 0.0 Then
                            linkCell.LinkColor = Color.Red
                        Else
                            linkCell.LinkColor = Color.Blue
                        End If
                        linkCell.VisitedLinkColor = linkCell.LinkColor

                    End With
                Next

            Catch ex As Exception

            Finally
                ShowStatusForm.Close()
            End Try

        Else

            Try
                For Each dgr As DataGridViewRow In DataGridViewRollOffs.Rows
                    With dgr
                        If .Cells("colUniqueID").Value = roObj.DatabaseID Then
                            .Cells("colAccountNumber").Value = roObj.Customer.CustomerNumber
                            .Cells("colCustomer").Value = String.Format("{0} ({1}, {2})", roObj.Customer, roObj.ServiceAddress.Address, roObj.ServiceAddress.City)
                            .Cells("colRollOffDelivered").Value = roObj.DateRollOffDelivered
                            .Cells("colSize").Value = roObj.RollOffSize
                            .Cells("colDay").Value = roObj.DaysHadRollOff
                            .Cells("colDateRollOffPickedUp").Value = roObj.DateRollOffPickedUp
                            .Cells("TotalDeposits").Value = roObj.TotalDeposits
                            .Cells("colDumpingCharges").Value = roObj.TotalCharges
                            .Cells("TotalPayments").Value = roObj.TotalPayments
                            .Cells("RollOffTotalCharge").Value = roObj.RollOffTotalCharge
                            .Cells("colLastBill").Value = roObj.DisplayedLastBillDetails

                            Dim linkCell As DataGridViewLinkCell = .Cells("colCustomer")
                            If roObj.RollOffTotalCharge > 0.0 Then
                                linkCell.LinkColor = Color.Red
                            Else
                                linkCell.LinkColor = Color.Blue
                            End If
                            linkCell.VisitedLinkColor = linkCell.LinkColor
                        End If
                    End With
                Next
            Catch ex As Exception

            Finally
                ShowStatusForm.Close()
            End Try

        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        End
    End Sub

    Private Sub ToolStripButtonViewCustomerList_Click(sender As Object, e As EventArgs) Handles ToolStripButtonViewCustomerList.Click, ViewCustomerListToolStripMenuItem.Click
        Dim frm As New CustomerList
        frm.ShowDialog()
    End Sub

    Private Sub AddNewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCustomerToolStripMenuItem.Click, ToolStripButtonAddNewCustomer.Click

        Dim frm As New CustomerData
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FillGlobalLists()
        End If

    End Sub

    Private Sub DataGridViewRollOffs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRollOffs.CellClick
        'If e.ColumnIndex = 1 Then
        '    DataGridViewRollOffs.EndEdit()
        'End If
    End Sub

    Private Sub DataGridViewRollOffs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRollOffs.CellContentClick

        ' ----- In case the header is clicked
        If e.RowIndex < 0 Then Exit Sub

        If e.ColumnIndex = 1 Then
            Dim chkB As DataGridViewCheckBoxCell = DirectCast(DataGridViewRollOffs.Rows(e.RowIndex).Cells("colBill"), DataGridViewCheckBoxCell)
            If chkB.Value = chkB.TrueValue Then
                chkB.Value = chkB.FalseValue
            Else
                chkB.Value = chkB.TrueValue
            End If
            DataGridViewRollOffs.EndEdit()
        End If

        ' ----- This will allow you to edit the customer data
        If DataGridViewRollOffs.Columns(e.ColumnIndex).Name = "colCustomer" Then
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(DataGridViewRollOffs.CurrentRow.Cells("colUniqueID").Value)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CreateRollOffForm() With {.EditMode = True, .SelectedRollOff = tempRO}
            frm.TabControlRollOff.SelectedTab = frm.TabPageDelivered
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If frm.DeactivatedRollOff Then
                    FillGrid(Nothing)
                Else
                    FillGrid(tempRO)
                End If
            End If
        End If

        If DataGridViewRollOffs.Columns(e.ColumnIndex).Name = "colLastBill" Then
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(DataGridViewRollOffs.CurrentRow.Cells("colUniqueID").Value)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New BillingForm() With {.EditMode = True, .RollOffToEdit = tempRO, .RollOffBillDateToEdit = CBillingObject.ReturnLastBill(tempRO).BillingDate}
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FillGrid(tempRO)
            End If
        End If

        If DataGridViewRollOffs.Columns(e.ColumnIndex).Name = "colButtonCharges" Then
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(DataGridViewRollOffs.CurrentRow.Cells("colUniqueID").Value)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerCharges() With {.SelectedCustomer = tempRO.Customer, .SelectedRollOff = tempRO}
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FillGrid(tempRO)
            End If
        End If

        If DataGridViewRollOffs.Columns(e.ColumnIndex).Name = "colButtonPayments" Then
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(DataGridViewRollOffs.CurrentRow.Cells("colUniqueID").Value)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerPayments() With {.SelectedCustomer = tempRO.Customer, .SelectedRollOff = tempRO}
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FillGrid(tempRO)
            End If
        End If

        If DataGridViewRollOffs.Columns(e.ColumnIndex).Name = "colButtonDeposits" Then
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(DataGridViewRollOffs.CurrentRow.Cells("colUniqueID").Value)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerDeposits() With {.SelectedCustomer = tempRO.Customer, .SelectedRollOff = tempRO}
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FillGrid(tempRO)
            End If
        End If

        If DataGridViewRollOffs.Columns(e.ColumnIndex).Name = "colHistory" Then
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(DataGridViewRollOffs.CurrentRow.Cells("colUniqueID").Value)
            If tempRO Is Nothing Then Exit Sub
            Dim frm As New CustomerHistory() With {.SelectedCustomer = tempRO.Customer, .SelectedRollOff = tempRO}
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FillGrid(tempRO)
            End If
        End If

    End Sub

    Private Sub SetupRollOffFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupRollOffFeesToolStripMenuItem.Click
        Dim frm As New RollOffFees
        frm.ShowDialog()
    End Sub

    Private Sub ConvertFileProDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertFileProDataToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you would like to convert the legacy FilePro datafile to the new database?  If you already have customer data in the database, this conversion could cause duplicate records.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            CFPConversion.ConvertFilePro()
        End If
    End Sub

    Private Sub ToolStripButtonRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRefresh.Click

        ' ----- Refresh the transactions list 
        FillTransactions()

        Try
            For Each dgr As DataGridViewRow In DataGridViewRollOffs.Rows
                With dgr
                    Dim chkCust As DataGridViewCheckBoxCell = dgr.Cells("colBill")
                    If chkCust.EditedFormattedValue = True Then
                        Dim roObj As CRollOff = CDataExtender.GetRollOff(dgr.Cells("colUniqueID").Value)
                        If roObj IsNot Nothing Then
                            .Cells("colAccountNumber").Value = roObj.Customer.CustomerNumber
                            .Cells("colCustomer").Value = String.Format("{0} ({1}, {2})", roObj.Customer, roObj.ServiceAddress.Address, roObj.ServiceAddress.City)
                            .Cells("colRollOffDelivered").Value = roObj.DateRollOffDelivered
                            .Cells("colSize").Value = roObj.RollOffSize
                            .Cells("colDay").Value = roObj.DaysHadRollOff
                            .Cells("colDateRollOffPickedUp").Value = roObj.DateRollOffPickedUp
                            .Cells("TotalDeposits").Value = roObj.TotalDeposits
                            .Cells("colDumpingCharges").Value = roObj.TotalCharges
                            .Cells("TotalPayments").Value = roObj.TotalPayments
                            .Cells("RollOffTotalCharge").Value = roObj.RollOffTotalCharge
                            .Cells("colLastBill").Value = roObj.DisplayedLastBillDetails

                            Dim linkCell As DataGridViewLinkCell = .Cells("colCustomer")
                            If roObj.RollOffTotalCharge > 0.0 Then
                                linkCell.LinkColor = Color.Red
                            Else
                                linkCell.LinkColor = Color.Blue
                            End If
                            linkCell.VisitedLinkColor = linkCell.LinkColor
                        End If
                    End If
                End With
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButtonRefreshAll_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRefreshAll.Click
        FillGrid(Nothing)
    End Sub

    Private Sub ToolStripButtonBillSelected_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBillSelected.Click, BillSelectedAccountsToolStripMenuItem.Click

        Dim frmBilling As New BillingForm

        ' ----- Get all of the selected customers 
        For Each dgr As DataGridViewRow In DataGridViewRollOffs.Rows
            Dim chkCust As DataGridViewCheckBoxCell = dgr.Cells("colBill")
            If chkCust.EditedFormattedValue = True Then
                Dim tempRO As CRollOff = CDataExtender.GetRollOff(dgr.Cells("colUniqueID").Value)
                If tempRO IsNot Nothing Then
                    frmBilling.RollOffListing.Add(tempRO)
                End If
            End If
        Next

        ' ----- Make sure we have at least one roll off account selected 
        If frmBilling.RollOffListing.Count = 0 Then
            MessageBox.Show("Please select at least one roll off to bill.", "Select Roll Off", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmBilling = Nothing
        Else
            frmBilling.Show()
        End If

    End Sub

    Private Sub InactiveRollOffsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactiveRollOffsToolStripMenuItem.Click

        Dim frm As New InactiveRollOffs

        ' ----- Show the form
        frm.ShowDialog()

        ' ----- Only refresh if something was done in the screen that would affect the main list 
        If frm.ShouldRefresh Then FillGrid(Nothing)

    End Sub

    Private Sub WaitingListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaitingListToolStripMenuItem.Click, ToolStripButtonWaitingList.Click
        Dim frm As New WaitingList
        frm.ShowDialog()
    End Sub

    Private Sub PaymentSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentSummaryToolStripMenuItem.Click, ToolStripButtonPaymentSummary.Click
        Dim frm As New ReportFrames() With {.ReportType = ReportFrames.ReportTypeFlags.PaymentSummary}
        frm.Show()
    End Sub

    Private Sub RevenueReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevenueReportToolStripMenuItem.Click, ToolStripButtonRevenueReport.Click
        Dim frm As New ReportFrames() With {.ReportType = ReportFrames.ReportTypeFlags.RevenueReport}
        frm.Show()
    End Sub

    Private Sub ToolStripButtonBillingLog_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBillingLog.Click
        For Each dgr As DataGridViewRow In DataGridViewRollOffs.Rows
            Dim chkCust As DataGridViewCheckBoxCell = dgr.Cells("colBill")
            If chkCust.EditedFormattedValue = True Then
                Dim tempRO As CRollOff = CDataExtender.GetRollOff(dgr.Cells("colUniqueID").Value)
                If tempRO IsNot Nothing Then
                    Dim frm As New CustomerBillingLog() With {.passedRO = tempRO}
                    frm.Show()
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub ToolStripButtonAddToWaitingList_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAddToWaitingList.Click
        Dim frm As New AddToWaitingList() With {.EditMode = False}
        frm.ShowDialog()
    End Sub

    Private Sub ConvertWaitingListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertWaitingListToolStripMenuItem.Click

        ' ----- Get a list of current roll offs
        'For Each rollObj As CRollOff In CDataExtender.GetListOfActiveRollOffs()

        '    If rollObj.ServiceAddress Is Nothing Then

        '        ' ----- Pull their pickup address from the customer record
        '        Dim pickupAddress As CAddressBlock = rollObj.Customer.PickUpAddress

        '        ' ------ Set the pickup address to the roll off service address 
        '        rollObj.ServiceAddress = pickupAddress

        '        ' ------ Save it 
        '        rollObj.Update()

        '    End If

        'Next

        'For Each waitObj As CWaitingList In CDataExtender.GetCustomersOnWaitingList(CWaitingList.WaitListStatusTypes.OnWaitList)

        '    If waitObj.ServiceAddress Is Nothing Then

        '        ' ----- Pull their service address from the customer records 
        '        Dim pickupAddress As CAddressBlock = waitObj.Customer.PickUpAddress

        '        ' ----- Set the service address 
        '        waitObj.ServiceAddress = pickupAddress

        '        ' ----- Save it to the database 
        '        waitObj.Update()

        '    End If


        'Next

    End Sub

    Private Sub ButtonClearSearch_Click(sender As Object, e As EventArgs) Handles ButtonClearSearch.Click
        TextBoxSearch.Text = ""
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        ' ----- We are going to attempt to filter the list without hitting the database each time 
        For Each dgr As DataGridViewRow In DataGridViewRollOffs.Rows

            Dim showRow As Boolean = False

            If TextBoxSearch.Text.Trim = "" Then
                ' ----- If there is nothing to search, then show all rows
                showRow = True
            Else
                ' ----- Get the customer name and address 
                Dim customer As String = dgr.Cells("colCustomer").Value.ToString.ToUpper

                ' ----- Get the account number
                Dim customerAccount As String = dgr.Cells("colAccountNumber").Value.ToString

                ' ----- If there is a match for either ... show the row 
                If customer.Contains(TextBoxSearch.Text.ToUpper) OrElse customerAccount.Contains(TextBoxSearch.Text) Then
                    showRow = True
                End If
            End If

            ' ----- Basis the flag, show or hide the row 
            dgr.Visible = showRow

        Next

    End Sub

    Private Sub CollectionAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionAccountsToolStripMenuItem.Click

        Dim frm As New CollectionAccounts
        frm.ShowDialog()

    End Sub

    Private Sub MonthlyBatchBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyBatchBillingToolStripMenuItem.Click

        Dim frmBilling As New BillingForm

        ' ----- Get customers that have a balance due OR who already have a bill made for the end of the month
        Dim rollOffList As List(Of CRollOff) = CDataExtender.GetListOfActiveRollOffs.Where(Function(c) c.RollOffTotalCharge > 0.0).OrderBy(Function(c) c.Customer.BillingAddress.FirstName).OrderBy(Function(c) c.Customer.BillingAddress.LastName).ToList

        For Each tempRO As CRollOff In rollOffList
            frmBilling.RollOffListing.Add(tempRO)
        Next

        frmBilling.Show()

    End Sub

End Class