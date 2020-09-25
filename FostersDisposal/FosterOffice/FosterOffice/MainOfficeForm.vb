Imports PickupTransaction
Imports System.IO
Imports System.Xml.Serialization
Imports DevExpress.XtraReports.UI

Public Class MainOfficeForm

    Private currentRow As Integer = -1
    Private selectedCustomerNumber As Integer = 0

    Private balanceThread As Threading.Thread
    Private MainGridControl As DevExpress.XtraGrid.GridControl

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        End
    End Sub

    Private Sub AddNewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCustomerToolStripMenuItem.Click, ToolStripButtonAddNewCustomer.Click

#If RentalProgram = True Then

        ' ----- Pull up the rental customer screen 
        Dim frm As New RentalCustomerEntry
        frm.EditMode = False

        ' ----- Show it 
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

#Else

        Dim frm As New CustomerEntry
        frm.EditMode = False

        ' ----- If they added a new customer, refresh the grid on the main screen 
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            ' ----- Refresh the data source 
            GridControlMain.DataSource = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation)

            ' ----- Expand all of the groups 
            GridViewMain.ExpandAllGroups()

        End If

#End If


    End Sub

#Region "Print Que Related"

    Public Sub LoadPrintQueFile()

        Try

            ' ----- Open the billing type file 
            Using fs As New StreamReader(My.Application.Info.DirectoryPath & "\customPrintQue.xml")

                ' ----- Read the data from the file 
                Dim printQueFile As New XmlSerializer(GetType(List(Of CCustomerBill)))
                CustomPrintQue = printQueFile.Deserialize(fs)

            End Using

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SavePrintQueFile()

        Try

            Using fs As New StreamWriter(My.Application.Info.DirectoryPath & "\customPrintQue.xml")

                Dim printQueFile As New XmlSerializer(GetType(List(Of CCustomerBill)))
                printQueFile.Serialize(fs, CustomPrintQue)

            End Using

        Catch ex As Exception

        End Try

    End Sub

#End Region

    Private Sub MainOfficeForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' ----- Make sure the thread is stopped
        Try
            If balanceThread.IsAlive Then
                balanceThread.Abort()
            End If
        Catch ex As Exception

        End Try

        ' ----- Save the print que file 
        SavePrintQueFile()

    End Sub

    Private Sub MainOfficeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' ----- Allow the thread to write to the main screen 
        CheckForIllegalCrossThreadCalls = False

        ' ----- Check for an update file on the internet
        'Try
        '    balanceThread = New Threading.Thread(AddressOf RefreshBalanceThread)
        '    balanceThread.Start(True)
        'Catch ex As Exception
        'End Try

#If RentalProgram = False Then

        ' ----- Create the data that we need 
        Try
            ProgramDataObject.Init(My.Settings.DatabaseLocation)
        Catch ex As Exception
        End Try

        GridControlMain.Visible = True
        GridControlRental.Visible = False
        MainGridControl = GridControlMain
        ButtonViewBills.Visible = False

#Else
        GridControlMain.Visible = False
        GridControlRental.Visible = True
        MainGridControl = GridControlRental
        ButtonViewBills.Visible = True
#End If

        ' ----- Blank out the label at startup
        LabelControlCustomer.Text = ""

#If RentalProgram = True Then

        ' ----- Get the current customer list 
        Try

            GridControlRental.DataSource = PickupTransaction.RentalCustomer.ReturnMainRentalList(My.Settings.DatabaseLocation, False)
            GridViewRental.OptionsCustomization.AllowGroup = False
            GridViewRental.ExpandAllGroups()

        Catch ex As Exception
        End Try

        ' ----- We do not need this toolbar option for the rental program 
        ToolStripButtonReviewCollectedItems.Visible = False
        ReviewCollectedItemsToolStripMenuItem.Visible = False
        UploadCurrentRouteDataToolStripMenuItem.Visible = False
        ToolStripSeparator3.Visible = False
        ToolStripSeparator8.Visible = False
        RefreshAllCurrentBalancesToolStripMenuItem.Visible = True
        CollectionItemsToolStripMenuItem.Visible = False
        SequenceNumberDistributionToolStripMenuItem.Visible = False
        UpdateBillingAmountsToolStripMenuItem.Visible = False
        ReprintBillsToolStripMenuItem.Visible = False

        ' ----- Reports Menu 
        CustomerListingTypeDEFBillingToolStripMenuItem.Visible = False
        ResidentialRouteCountsToolStripMenuItem.Visible = False
        YellowTabReportToolStripMenuItem.Visible = False
        ShowCustomersWithPurchaseOrdersToolStripMenuItem.Visible = True
        LastBilledReportToolStripMenuItem.Visible = False

        ' ----- Menus we need to see 
        ContainerRouteListingsToolStripMenuItem.Visible = True
        EnterRentalCustomerRouteDataToolStripMenuItem.Visible = True
        CopyCommercialDataFromResidentialToolStripMenuItem.Visible = True
        CustomerContainerReportToolStripMenuItem.Visible = True

        ' ----- For new FTP upload
        UploadCurrentRouteDataToFTPToolStripMenuItem .Visible = False 

#Else
        ' ----- Get the current customer list 
        Try
            With GridControlMain
                .DataSource = PickupTransaction.Customer.ReturnMainCustomerList(My.Settings.DatabaseLocation, Not CheckBoxSearchInactive.Checked)
            End With

            ' ----- Expand all of the groups 
            GridViewMain.ExpandAllGroups()

        Catch ex As Exception
        End Try

        ' ----- Menus to show 
        UploadCurrentRouteDataToolStripMenuItem.Visible = False ' True
        ToolStripSeparator3.Visible = True
        ToolStripSeparator8.Visible = True
        RefreshAllCurrentBalancesToolStripMenuItem.Visible = True
        CollectionItemsToolStripMenuItem.Visible = True
        SequenceNumberDistributionToolStripMenuItem.Visible = True
        UpdateBillingAmountsToolStripMenuItem.Visible = True
        ReprintBillsToolStripMenuItem.Visible = True

        ' ----- Reports Menu 
        CustomerListingTypeDEFBillingToolStripMenuItem.Visible = True
        ResidentialRouteCountsToolStripMenuItem.Visible = True
        YellowTabReportToolStripMenuItem.Visible = True
        ShowCustomersWithPurchaseOrdersToolStripMenuItem.Visible = False
        LastBilledReportToolStripMenuItem.Visible = True

        ' ----- Menus we need not see 
        ContainerRouteListingsToolStripMenuItem.Visible = False
        EnterRentalCustomerRouteDataToolStripMenuItem.Visible = False
        CopyCommercialDataFromResidentialToolStripMenuItem.Visible = False
        CustomerContainerReportToolStripMenuItem.Visible = False

        ' ----- For new FTP upload
        UploadCurrentRouteDataToFTPToolStripMenuItem.Visible = True

#End If

        LoadPrintQueFile()

        ' ----- Set this as the active control
        ActiveControl = TextBoxSearchCustomer

    End Sub

    Private Sub UpdateBillingAmountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBillingAmountsToolStripMenuItem.Click
        Dim frm As New BillingTypes
        frm.ShowDialog()
    End Sub

    Private Sub MakePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakePaymentToolStripMenuItem.Click, ToolStripButtonReceivePayment.Click


#If RentalProgram = True Then

        Dim frm As New RentalMakePayment

        Try
            RentalCustomer.SetCustomerBalances(My.Settings.DatabaseLocation, selectedCustomerNumber)
        Catch ex As Exception
        End Try

#Else
        Dim frm As New MakePayment
#End If

        frm.SelectedCustomerNumber = selectedCustomerNumber
        frm.ShowDialog()

        UpdateCustomerGrid()

    End Sub

    Private Sub EditItemsCollectedListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemsCollectedListToolStripMenuItem.Click
        Dim frm As New PriceList
        frm.ShowDialog()
    End Sub

    Private Sub GridViewRental_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewRental.RowCellClick

        ' ----- Get the control that is selected
        Dim gridViewObj As DevExpress.XtraGrid.Views.Grid.GridView = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        ' ----- If we have data ...
        If gridViewObj.IsDataRow(e.RowHandle) Then

            currentRow = e.RowHandle

            ' ----- Get the account number 
            selectedCustomerNumber = gridViewObj.GetRowCellValue(e.RowHandle, colAccountNumber)

            ' ----- Refresh the customer grid 
            UpdateCustomerGrid()

        End If

    End Sub

    Private Sub GridViewMain_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewMain.FocusedRowChanged, GridViewRental.FocusedRowChanged

        ' ----- Get the control that is selected
        Dim gridViewObj As DevExpress.XtraGrid.Views.Grid.GridView = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        ' ----- If we have data ...
        If gridViewObj.IsDataRow(e.FocusedRowHandle) Then

            currentRow = e.FocusedRowHandle

            ' ----- Get the account number 
            selectedCustomerNumber = gridViewObj.GetRowCellValue(e.FocusedRowHandle, colAccountNumber)

            ' ----- Refresh the customer grid 
            UpdateCustomerGrid()

        End If

    End Sub

    Public Sub UpdateCustomerGrid()

#If RentalProgram = True Then

        If selectedCustomerNumber > 0 Then

            Dim tempCustObj As PickupTransaction.RentalCustomer = PickupTransaction.RentalCustomer.GetRentalCustomer(My.Settings.DatabaseLocation, selectedCustomerNumber)
            LabelControlCustomer.Text = tempCustObj.FullName
            PropertyGridControlCustomer.SelectedObject = tempCustObj

            '----- Determine the current balance
            Dim customerHistoryData As PickupTransaction.RentalCustomer.CRentalCustomerHistory = PickupTransaction.RentalCustomer.RentalCustomerHistory(My.Settings.DatabaseLocation, selectedCustomerNumber, Date.Today + New TimeSpan(1, 0, 0, 0), True)
            DataGridViewHistory.DataSource = (From c In customerHistoryData.TransactionLineItems Order By c.TransactionDate Select c).ToList
            DataGridViewHistory.FirstDisplayedScrollingRowIndex = DataGridViewHistory.Rows.Count - 1
            LabelCurrentBalance.Text = "Current Balance: " & String.Format("{0:c2}", customerHistoryData.CurrentBalance)

        End If

#Else
        If selectedCustomerNumber > 0 Then

            ' ----- From the account number, get the selected customer object  
            Dim tempCustObj As PickupTransaction.Customer = PickupTransaction.Customer.GetCustomer(My.Settings.DatabaseLocation, selectedCustomerNumber)
            LabelControlCustomer.Text = tempCustObj.FullName
            PropertyGridControlCustomer.SelectedObject = tempCustObj

            '----- Determine the current balance
            Dim customerHistoryData As PickupTransaction.Customer.CCustomerHistory = PickupTransaction.Customer.CustomerHistory(My.Settings.DatabaseLocation, selectedCustomerNumber, Date.Today + New TimeSpan(1, 0, 0, 0))
            DataGridViewHistory.DataSource = (From c In customerHistoryData.TransactionLineItems Order By c.TransactionDate Select c).ToList
            DataGridViewHistory.FirstDisplayedScrollingRowIndex = DataGridViewHistory.Rows.Count - 1
            LabelCurrentBalance.Text = "Current Balance: " & String.Format("{0:c2}", customerHistoryData.CurrentBalance)

        End If

#End If

    End Sub

    Private Sub CustomerListingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListingToolStripMenuItem.Click, ToolStripButtonCustomerListing.Click

        Dim frm As New ReportDisplay
        frm.WhichReport = ReportDisplay.ReportType.CustomerListing
        frm.Show()

    End Sub

    Private Sub PropertyGridControlCustomer_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles PropertyGridControlCustomer.CellValueChanged

#If RentalProgram Then

        Dim tempCustObj As RentalCustomer = DirectCast(PropertyGridControlCustomer.SelectedObject, RentalCustomer)
        tempCustObj.Update(My.Settings.DatabaseLocation)

        If TextBoxSearchCustomer.Text <> "" Then
            Call ButtonSearchCustomer_Click(Nothing, Nothing)
        Else

            ' ----- Get the datasource 
            GridControlMain.DataSource = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation)

            ' ----- Expand all of the groups 
            GridViewMain.ExpandAllGroups()

        End If

#Else

        Dim tempCustObj As Customer = DirectCast(PropertyGridControlCustomer.SelectedObject, Customer)
        tempCustObj.Update(My.Settings.DatabaseLocation)

        If TextBoxSearchCustomer.Text <> "" Then
            Call ButtonSearchCustomer_Click(Nothing, Nothing)
        Else

            ' ----- Get the datasource 
            GridControlMain.DataSource = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation)

            ' ----- Expand all of the groups 
            GridViewMain.ExpandAllGroups()

        End If

#End If

    End Sub

    Private Sub PaymentSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentSummaryToolStripMenuItem.Click, ToolStripButtonPaymentSummary.Click

        Dim frmWait As New WaitForm
        frmWait.Label1.Text = "Loading Report..."
        frmWait.Show(Me)
        frmWait.Refresh()

        Dim frm As New ReportDisplay
        frm.WhichReport = ReportDisplay.ReportType.PaymentListing
        frm.Show()

        frmWait.Close()

    End Sub

    Private Sub SimpleButtonPaymentHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonPaymentHistory.Click

        Dim frm As New PaymentHistory
        frm.CustomerNumber = selectedCustomerNumber
        frm.ShowDialog()

        ' ----- Refresh the current customer 
        UpdateCustomerGrid()

    End Sub

    Private Sub SimpleButtonCustomerCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonCustomerCard.Click

#If RentalProgram = True Then

        Dim frm As New RentalCustomerEntry
        frm.CustomerNumber = selectedCustomerNumber
        frm.EditMode = True
        frm.ShowDialog()

#Else

        Dim frm As New CustomerEntry
        frm.CustomerNumber = selectedCustomerNumber
        frm.EditMode = True
        frm.ShowDialog()

#End If

    End Sub

    Private Sub UploadCurrentRouteDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadCurrentRouteDataToolStripMenuItem.Click

        ' ----- Show the wait cursor 
        Cursor = Cursors.WaitCursor

        ' ----- Create a customer listing object file 
        Customer.CreateCustomerList(My.Settings.DatabaseLocation)

        ' ----- Move this file to the shared location 
        My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CustomerList.dat", My.Settings.SharedLocation & "\CustomerList.dat", True)

        ' ----- Reset the cursor 
        Cursor = Cursors.Default

    End Sub

    Private Sub UploadCurrentRouteDataToFTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadCurrentRouteDataToFTPToolStripMenuItem.Click

        ' ----- Show the wait cursor 
        Cursor = Cursors.WaitCursor

        Try

            ' ----- Create a customer listing object file 
            Customer.CreateCustomerList(My.Settings.DatabaseLocation)

            ' ----- Now copy the file to the FTP site
            Dim ftpClient As New FTPHelper.Client("ftp://www.lccsny.com/foster", "0083045|lccsnycom00", "captmo28")
            ftpClient.UploadFile(My.Application.Info.DirectoryPath & "\CustomerList.dat", "CustomerList.dat")

            ' ----- Tell the user
            MessageBox.Show("The route has been uploaded to the FTP site.")

        Catch ex As Exception

            Dim errorString As String = String.Format("There was an error uploading the customer listing.  The error message is {0}.  Please contact LCCS and report this error message.  Thank you", ex.Message)
            MessageBox.Show(errorString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

        ' ----- Reset the cursor 
        Cursor = Cursors.Default


    End Sub

    Private Sub ButtonDeleteCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteCustomer.Click

        ' ----- Make sure they want to delete the customer 
        If MessageBox.Show("Are you sure you would like to delete the selected customer?.  Once this process is confirmed, the operation cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

#If RentalProgram Then

        ' ----- From the account number, get the selected customer object 
        Dim tempCustObj As PickupTransaction.RentalCustomer = PickupTransaction.RentalCustomer.GetRentalCustomer(My.Settings.DatabaseLocation, selectedCustomerNumber)
        tempCustObj.DeleteRentalCustomer(My.Settings.DatabaseLocation)

        ' ----- Get the datasource 
        GridControlMain.DataSource = PickupTransaction.RentalCustomer.ReturnCustomerList(My.Settings.DatabaseLocation)

#Else

        ' ----- From the account number, get the selected customer object 
        Dim tempCustObj As PickupTransaction.Customer = PickupTransaction.Customer.GetCustomer(My.Settings.DatabaseLocation, selectedCustomerNumber)
        tempCustObj.DeleteCustomer(My.Settings.DatabaseLocation)

        ' ----- Get the datasource 
        GridControlMain.DataSource = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation)

#End If

        ' ----- Expand all of the groups 
        GridViewMain.ExpandAllGroups()

        ' ----- Reset the customer number 
        selectedCustomerNumber = 0
        LabelControlCustomer.Text = ""
        PropertyGridControlCustomer.SelectedObject = Nothing

    End Sub

    Private Sub SimpleButtonEditPickedUpItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonEditPickedUpItems.Click

#If RentalProgram Then
        ' ----- Display a screen that shows all of the items picked up and on what date
        Dim frm As New ViewRentalPickupItems
        frm.AccountNumber = selectedCustomerNumber
        frm.CustomerName = LabelControlCustomer.Text
        frm.ShowDialog()
#Else
        ' ----- Display a screen that shows all of the items picked up and on what date
        Dim frm As New EditPickupItems
        frm.CustomerNumber = selectedCustomerNumber
        frm.ShowDialog()
#End If

    End Sub

    Private Sub ReviewCollectedItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReviewCollectedItemsToolStripMenuItem.Click, ToolStripButtonReviewCollectedItems.Click
        Dim frm As New ReviewPickedUpItems
        frm.ShowDialog()
    End Sub

    Private Sub BillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem.Click
        Dim billMod As New BillingForm
        billMod.Show(Me)
    End Sub

    Private Sub SetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        Dim frm As New SetupForm
        frm.ShowDialog()
    End Sub

#Region "Search Routines"

    Private Sub ButtonSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchCustomer.Click

        ' ----- Show the wait cursor 
        Cursor = Cursors.WaitCursor

#If RentalProgram Then

        ' ----- If there is no search criteria
        If TextBoxSearchCustomer.Text = "" Then
            GridControlRental.DataSource = PickupTransaction.RentalCustomer.ReturnMainRentalList(My.Settings.DatabaseLocation, CheckBoxSearchInactive.Checked)
        Else

            ' ----- Get the data from the string and search the database 
            Try
                With GridControlRental
                    Dim filteredList As List(Of PickupTransaction.RentalCustomer.CRentalCustomerList) = PickupTransaction.RentalCustomer.ReturnMainRentalList(My.Settings.DatabaseLocation, CheckBoxSearchInactive.Checked)
                    .DataSource = (From f In filteredList
                                   Where f.CustomerName.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.AccountNumber.ToString.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.CustomerAddress.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.PhoneNumber.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.BillingInformation.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper)
                                   Select f).ToList
                End With

            Catch ex As Exception

            End Try

        End If

        ' ----- Expand all of the groups 
        GridViewRental.ExpandAllGroups()

#Else

        ' ----- If there is no search criteria
        If TextBoxSearchCustomer.Text = "" Then

            GridControlMain.DataSource = PickupTransaction.Customer.ReturnMainCustomerList(My.Settings.DatabaseLocation, Not CheckBoxSearchInactive.Checked)
        Else

            ' ----- Get the data from the string and search the database 
            Try
                With GridControlMain
                    Dim filteredList As List(Of PickupTransaction.Customer.CCustomerList) = PickupTransaction.Customer.ReturnCustomerList(My.Settings.DatabaseLocation, -1)
                    .DataSource = (From f In filteredList
                                   Where f.CustomerName.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.AccountNumber.ToString.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.CustomerAddress.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.PhoneNumber.ToUpper.Contains(TextBoxSearchCustomer.Text.ToUpper) Or f.SequenceNumber.ToString.Contains(TextBoxSearchCustomer.Text.ToUpper)
                                   Select f).ToList
                End With

            Catch ex As Exception

            End Try

        End If

        ' ----- Expand all of the groups 
        GridViewMain.ExpandAllGroups()

#End If

        ' ----- Reset the cursor 
        Cursor = Cursors.Default

    End Sub

    Private Sub TextBoxSearchCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxSearchCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ButtonSearchCustomer_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBoxSearchCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSearchCustomer.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

#End Region

    Private Sub RevenueReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevenueReportToolStripMenuItem.Click, ToolStripButtonRevenueReport.Click

        Dim frmWait As New WaitForm
        frmWait.Label1.Text = "Loading Report..."
        frmWait.Show(Me)
        frmWait.Refresh()

        Dim frm As New ReportDisplay
        frm.WhichReport = ReportDisplay.ReportType.RevenueReport
        frm.Show()

        frmWait.Close()

    End Sub

    Private Sub BillingFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingFormToolStripMenuItem.Click

#If RentalProgram Then
        Dim frm As New RentalCustomerBillingReview
        frm.Show(Me)
#Else
        Dim frm As New BillingReview
        frm.Show(Me)
#End If

    End Sub

    Private Sub DataGridViewHistory_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewHistory.RowEnter

        If DataGridViewHistory.Rows(e.RowIndex).Cells(1).Value = "Payment" Then
            ButtonPrintPayment.Enabled = True
        Else
            ButtonPrintPayment.Enabled = False
        End If

    End Sub

    Private Sub ButtonPrintPayment_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPrintPayment.Click

        ' ----- Get the payment ID 
        Dim paymentID As Integer = DataGridViewHistory.CurrentRow.Cells("colTransID").Value

        ' ----- With the payment ID ... print the receipt 
        Dim rpt As New PaymentReceipt

        ' ----- Get the customer number 
        Dim customerNumber As Integer = DataGridViewHistory.CurrentRow.Cells("colCustomerID").Value

        ' ----- Set the payment date 
        rpt.PaymentDate = DataGridViewHistory.CurrentRow.Cells("colDate").Value

        ' ----- Get the customer history 
#If RentalProgram Then
        Dim customerHistoryList As PickupTransaction.RentalCustomer.CRentalCustomerHistory = PickupTransaction.RentalCustomer.RentalCustomerHistory(My.Settings.DatabaseLocation, customerNumber, rpt.PaymentDate.Date)
        Dim rentalPaymentObj As PickupTransaction.RentalPayment = PickupTransaction.RentalPayment.ReturnPaymentDetails(My.Settings.DatabaseLocation, paymentID)
#Else
        Dim customerHistoryList As PickupTransaction.Customer.CCustomerHistory = PickupTransaction.Customer.CustomerHistory(My.Settings.DatabaseLocation, customerNumber, rpt.PaymentDate)
        Dim rentalPaymentObj As PickupTransaction.Payments = PickupTransaction.Payments.ReturnPaymentDetails(My.Settings.DatabaseLocation, paymentID)
#End If

        ' ----- Set the payment amount 
        rpt.PaymentAmount = DataGridViewHistory.CurrentRow.Cells("colAmount").Value

        ' ----- Set the payment MOP description 
        rpt.PaymentMOPDescription = rentalPaymentObj.MethodOfPaymentDesc & If(rentalPaymentObj.MOP = 1, "#: " & rentalPaymentObj.CheckNumber.ToString, "")

        ' ----- Set the datasource 
        rpt.BindingSource1.DataSource = customerHistoryList

        ' ----- Print it directly 
        rpt.ShowPreview()

    End Sub

    Private Sub SimpleButtonManualBill_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButtonManualBill.Click

        Dim frm As New BillingReview

        frm.ManualBillingMode = True
        frm.ManualCustomerNumber = selectedCustomerNumber
        frm.ShowDialog()

    End Sub

    Private Sub UpdateMonthBilledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateMonthBilledToolStripMenuItem.Click

        Dim transList As List(Of PickupTransaction.Transactions) = PickupTransaction.Transactions.ReturnLatestTransaction(My.Settings.DatabaseLocation)

        For Each obj As PickupTransaction.Transactions In transList
            PickupTransaction.Customer.UpdateMonthBilled(My.Settings.DatabaseLocation, obj.CustomerID, obj.TransDate.Month)
        Next

    End Sub

    Private Sub RefreshAllCurrentBalancesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshAllCurrentBalancesToolStripMenuItem.Click

        ' ----- check to make sure the process is not already running 
        If Not balanceThread Is Nothing Then
            If balanceThread.IsAlive Then
                MessageBox.Show("The posting process is still running.  Another posting process cannot be started until the existing process completes", "Process Running", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        End If

        ' ----- Check for an update file on the internet
        Try
            balanceThread = New Threading.Thread(AddressOf RefreshBalanceThread)
            balanceThread.Start(False)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RefreshBalanceThread(checkDate As Boolean)

#If RentalProgram = True Then

        'Dim blnRunPost As Boolean = True

        '' ----- Set the balance
        'ToolStripStatusLabelBalancing.Text = "Posting Current Balances to the Database"
        'ToolStripStatusLabelBalancing.ForeColor = Color.Red

        'If checkDate Then

        '    ' ----- Get a list of all of the current post dates in the database 
        '    Dim dateList As List(Of Date) = PickupTransaction.RentalCustomer.CheckDateLastPost(My.Settings.DatabaseLocation)

        '    ' ----- If we see a date that is not today ... then refresh all of the dates 
        '    If Not dateList Is Nothing AndAlso dateList.Count = 1 Then
        '        If dateList(0).Date = Date.Today Then
        '            blnRunPost = False
        '        End If
        '    End If

        'End If

        '' ----- Run the calculations 
        'Try
        '    If blnRunPost Then
        '        PickupTransaction.RentalCustomer.SetCustomerBalances(My.Settings.DatabaseLocation)
        '        ToolStripStatusLabelBalancing.Text = "Posting Operation Complete"
        '    Else
        '        ToolStripStatusLabelBalancing.Text = "Posting Operation Skipped"
        '    End If
        'Catch ex As Exception
        '    ToolStripStatusLabelBalancing.Text = "Posting Operation Encountered an Error: " & ex.Message
        'End Try

        'ToolStripStatusLabelBalancing.ForeColor = Color.Black

#Else
        Dim blnRunPost As Boolean = True

        ' ----- Set the bal
        ToolStripStatusLabelBalancing.Text = "Posting Current Balances to the Database"
        ToolStripStatusLabelBalancing.ForeColor = Color.Red

        If checkDate Then

            ' ----- Get a list of all of the current post dates in the database 
            Dim dateList As List(Of Date) = Customer.CheckDateLastPost(My.Settings.DatabaseLocation)

            ' ----- If we see a date that is not today ... then refresh all of the dates 
            If Not dateList Is Nothing AndAlso dateList.Count = 1 Then
                If dateList(0).Date = Date.Today Then
                    blnRunPost = False
                End If
            End If

        End If

        ' ----- Run the calculations 
        Try
            If blnRunPost Then
                Customer.SetCustomerBalances(My.Settings.DatabaseLocation)
                ToolStripStatusLabelBalancing.Text = "Posting Operation Complete"
            Else
                ToolStripStatusLabelBalancing.Text = "Posting Operation Skipped"
            End If
        Catch ex As Exception
            ToolStripStatusLabelBalancing.Text = "Posting Operation Encountered an Error: " & ex.Message
        End Try

        ToolStripStatusLabelBalancing.ForeColor = Color.Black

#End If

    End Sub

    Private Sub CustomerNotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerNotesToolStripMenuItem.Click

#If RentalProgram Then
        Dim rpt As New RentalCustomerNotes
        rpt.DataSource = PickupTransaction.RentalCustomer.ReturnRentalCustomersWithComments(My.Settings.DatabaseLocation).OrderBy(Function(c) c.FullName)
        rpt.ShowPreview()
#Else
        Dim frm As New CustomerNoteFilter
        frm.ReportToShow = 0
        frm.Show(Me)
#End If

    End Sub

    Private Sub CustomerAgingReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerAgingReportToolStripMenuItem.Click

#If RentalProgram = True Then

        Dim frm As New ReportDisplayRental
        frm.ShowDelinquentsOnly = False
        frm.Show(Me)

#Else
        Dim frm As New CustomerNoteFilter
        frm.ReportToShow = 1
        frm.Show(Me)
#End If


    End Sub

    Private Sub CustomerAgingReportDelinquentOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerAgingReportDelinquentOnlyToolStripMenuItem.Click

#If RentalProgram = True Then

        Dim frm As New ReportDisplayRental
        frm.ShowDelinquentsOnly = True
        frm.Show(Me)

#Else
        Dim frm As New CustomerNoteFilter
        frm.ReportToShow = 3
        frm.Show(Me)
#End If

    End Sub

    Private Sub ShowCustomersWithPurchaseOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCustomersWithPurchaseOrdersToolStripMenuItem.Click

        Dim rpt As New RentalCustomerWithPO
        rpt.DataSource = (From c In PickupTransaction.RentalCustomer.ReturnCustomer(My.Settings.DatabaseLocation)
                          Where c.UsePONumberForAll = True
                          Order By c.CustomerNumber
                          Select c).ToList
        rpt.ShowPreview()

    End Sub

    Private Sub ReprintBillsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReprintBillsToolStripMenuItem.Click

        ' ----- Get the latest print que file 
        LoadPrintQueFile()

        ' ----- Show the screen for custom printing 
        Dim frm As New ReprintBill
        frm.ShowDialog()

        ' ----- Save the print que file 
        SavePrintQueFile()

    End Sub

    Private Sub IssueCreditToACustomerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IssueCreditToACustomerToolStripMenuItem.Click

        Dim frm As New IssueCredit
        frm.ShowDialog()

        UpdateCustomerGrid()

    End Sub

    Private Sub CustomerListingTypeDEFBillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListingTypeDEFBillingToolStripMenuItem.Click

        Dim frm As New CustomerNoteFilter
        frm.ReportToShow = 2
        frm.ShowDialog()

    End Sub

    Private Sub ButtonClearSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearSearch.Click

        ' ----- Quick way to clear the search text box 
        TextBoxSearchCustomer.Text = ""
        ButtonSearchCustomer_Click(Nothing, Nothing)

    End Sub

    Private Sub SequenceNumberDistributionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SequenceNumberDistributionToolStripMenuItem.Click
        Dim frm As New SequenceNumberAdjust
        frm.ShowDialog()
    End Sub

    Private Sub ResidentialRouteCountsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResidentialRouteCountsToolStripMenuItem.Click
        Dim rpt As New ResidentialRouteReport
        rpt.BindingSourceRouteCount.DataSource = PickupTransaction.Customer.CCustomerRouteCounts.GenerateRouteCount(My.Settings.DatabaseLocation)
        rpt.ShowPreview()
    End Sub

    Private Sub YellowTabReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YellowTabReportToolStripMenuItem.Click
        Dim rpt As New YellowTabReport
        rpt.BindingSourceCustomer.DataSource = PickupTransaction.Customer.ReturnCustomerWithinSequence(My.Settings.DatabaseLocation, 10000, 79999)
        rpt.ShowPreview()
    End Sub

    Private Sub ConvertRentalCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertRentalCustomersToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        CCustomerFilePro.ConvertFileProRental()
        Cursor = Cursors.Default

    End Sub

    Private Sub ContainerRouteListingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContainerRouteListingsToolStripMenuItem.Click
        Dim frm As New ContainerRouteListing
        frm.ShowDialog()
    End Sub

    Private Sub EnterRentalCustomerRouteDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterRentalCustomerRouteDataToolStripMenuItem.Click

        Dim frm As New EnterRentalCustomerData
        frm.ShowDialog()

    End Sub

    Private Sub CopyCommercialDataFromResidentialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCommercialDataFromResidentialToolStripMenuItem.Click

        If MessageBox.Show("You are about to copy over Route 4 customers from the residential database and add pickup records to the commercial database.  Would you like to continue?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            ' ----- Get a list of all of the route 4 customers 
            For Each cust As PickupTransaction.Customer In PickupTransaction.Customer.GetRoute4Customers(My.Settings.DatabaseLocation)

                ' ----- Determine if this customer is in the commercial database 
                If Not PickupTransaction.RentalPickupInformation.IsCustomerInTable(My.Settings.DatabaseLocation, cust.CustomerNumber) Then

                    ' ----- Create a record 
                    Dim newPickupRecord As New PickupTransaction.RentalPickupInformation

                    With newPickupRecord

                        .CustomerNumber = cust.CustomerNumber
                        .DumpsterIndex = "Hand"
                        .LoadIndex = ""
                        .SizeIndex = ""
                        .MiscText = "MANUAL FROM RESIDENTIAL"

                        If cust.SequenceNumber >= 10000 And cust.SequenceNumber < 20000 Then .DaysIndex = "Monday"
                        If cust.SequenceNumber >= 20000 And cust.SequenceNumber < 30000 Then .DaysIndex = "Tuesday"
                        If cust.SequenceNumber >= 30000 And cust.SequenceNumber < 40000 Then .DaysIndex = "Wednesday"
                        If cust.SequenceNumber >= 40000 And cust.SequenceNumber < 50000 Then .DaysIndex = "Thursday"
                        If cust.SequenceNumber >= 50000 And cust.SequenceNumber < 60000 Then .DaysIndex = "Friday"
                        If cust.SequenceNumber >= 60000 Then .DaysIndex = "Saturday"

                    End With

                    ' ----- Create the records 
                    PickupTransaction.RentalPickupInformation.SetCustomerPickupInformation(My.Settings.DatabaseLocation, newPickupRecord)

                    'Else

                    '    ' ----- Update the data by first getting the customer 
                    '    Dim pickupRecord As List(Of PickupTransaction.RentalPickupInformation) = PickupTransaction.RentalPickupInformation.GetCustomerPickupInformation(My.Settings.DatabaseLocation, cust.CustomerNumber)

                    '    For Each pr As PickupTransaction.RentalPickupInformation In pickupRecord
                    '        pr.MiscText = cust.SpecialInstructions
                    '        PickupTransaction.RentalPickupInformation.SetCustomerPickupInformation(My.Settings.DatabaseLocation, pr)
                    '    Next

                End If

            Next

        End If

    End Sub

    Private Sub ButtonViewBills_Click(sender As Object, e As EventArgs) Handles ButtonViewBills.Click

        Dim frm As New ViewRentalBills
        frm.CustomerAccountNumber = selectedCustomerNumber
        frm.ShowDialog()

    End Sub

    Private Sub CheckBoxCurrentMonthPickups_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCurrentMonthPickups.CheckedChanged
        UpdateCustomerGrid()
    End Sub

    Private Sub EnterManualPickupInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterManualPickupInformationToolStripMenuItem.Click
        Dim frm As New ManualRentalCustomerDataEntry
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabelBalancing_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabelBalancing.Click
        MessageBox.Show(ToolStripStatusLabelBalancing.Text)
    End Sub

    Private Sub CustomerContainerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerContainerReportToolStripMenuItem.Click
        Dim rpt As New RentalCustomerContainerReport
        rpt.BindingSourceCustomer.DataSource = PickupTransaction.RentalCustomer.GetCustomerContainerInfo(My.Settings.DatabaseLocation)
        rpt.ShowPreview()
    End Sub

    Private Sub LastBilledReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastBilledReportToolStripMenuItem.Click

        Dim frm As New LastBillReportFilter
        Dim monthsToReviewArray(9) As Integer

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' ----- Get the billing month 
            Dim currentMonth As Integer = Date.Today.Month

            ' ----- We will assume that if we are at the beginning of the month, then they want last month billing (and check for January)
            If Date.Today.Day <= 10 Then
                currentMonth -= 1
                If currentMonth = 0 Then currentMonth = 12
            End If

            ' ----- This will be the month to review
            Dim monthToReview As Integer = currentMonth - frm.NumberOfMonths

            ' ----- We want to go back 9 months 
            For iStep As Integer = 0 To 8
                monthsToReviewArray(iStep) = currentMonth - frm.NumberOfMonths - iStep
                If monthsToReviewArray(iStep) <= 0 Then monthsToReviewArray(iStep) += 12
            Next

            ' ----- Now run the report with the criteria
            Dim rpt As New LastBillReport
            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                             Where (c.LastMonthBilled = monthsToReviewArray(0) Or c.LastMonthBilled = monthsToReviewArray(1) Or c.LastMonthBilled = monthsToReviewArray(2) Or c.LastMonthBilled = monthsToReviewArray(3) Or c.LastMonthBilled = monthsToReviewArray(4) Or c.LastMonthBilled = monthsToReviewArray(5) Or c.LastMonthBilled = monthsToReviewArray(6) Or c.LastMonthBilled = monthsToReviewArray(7) Or c.LastMonthBilled = monthsToReviewArray(8)) And c.SequenceNumber < 80000
                             Order By c.SequenceNumber
            rpt.ShowPreview()

        End If
    End Sub

    Private Sub MailingLabelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailingLabelsToolStripMenuItem.Click

        Dim mailingLabelApp As String = "..\MailingLabelApp\MailingLabelApp.exe"
        Process.Start(mailingLabelApp)

    End Sub

    Private Sub ButtonBalanceRefresh_Click(sender As Object, e As EventArgs) Handles ButtonBalanceRefresh.Click
        Customer.SetCustomerBalances(My.Settings.DatabaseLocation, selectedCustomerNumber)
        UpdateCustomerGrid()
    End Sub

    Private Sub GoInAfterReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoInAfterReportToolStripMenuItem.Click
        Dim filterScreen As New CustomerNoteFilter
        filterScreen.ReportToShow = 4
        filterScreen.ShowDialog()
    End Sub

End Class
