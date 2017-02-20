<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupRollOffFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertFileProDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertWaitingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.WaitingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CollectionAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollOffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InactiveRollOffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BillSelectedAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonAddNewCustomer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonViewCustomerList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonBillSelected = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonBillingLog = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonAddToWaitingList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonWaitingList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefreshAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPaymentSummary = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRevenueReport = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewRollOffs = New System.Windows.Forms.DataGridView()
        Me.colUniqueID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBill = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colRollOffDelivered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateRollOffPickedUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDeposits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colButtonDeposits = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDumpingCharges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colButtonCharges = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TotalPayments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colButtonPayments = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RollOffTotalCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHistory = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colLastBill = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colAccountNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonClearSearch = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MonthlyBatchBillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripMain.SuspendLayout()
        Me.ToolStripMain.SuspendLayout()
        CType(Me.DataGridViewRollOffs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Open Roll Off Accounts"
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.RollOffsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1311, 24)
        Me.MenuStripMain.TabIndex = 2
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupRollOffFeesToolStripMenuItem, Me.ConvertFileProDataToolStripMenuItem, Me.ConvertWaitingListToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SetupRollOffFeesToolStripMenuItem
        '
        Me.SetupRollOffFeesToolStripMenuItem.Name = "SetupRollOffFeesToolStripMenuItem"
        Me.SetupRollOffFeesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SetupRollOffFeesToolStripMenuItem.Text = "Setup Roll Off Fees..."
        '
        'ConvertFileProDataToolStripMenuItem
        '
        Me.ConvertFileProDataToolStripMenuItem.Enabled = False
        Me.ConvertFileProDataToolStripMenuItem.Name = "ConvertFileProDataToolStripMenuItem"
        Me.ConvertFileProDataToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ConvertFileProDataToolStripMenuItem.Text = "Convert FilePro Data..."
        '
        'ConvertWaitingListToolStripMenuItem
        '
        Me.ConvertWaitingListToolStripMenuItem.Enabled = False
        Me.ConvertWaitingListToolStripMenuItem.Name = "ConvertWaitingListToolStripMenuItem"
        Me.ConvertWaitingListToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ConvertWaitingListToolStripMenuItem.Text = "Convert Data..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCustomerToolStripMenuItem, Me.ViewCustomerListToolStripMenuItem, Me.ToolStripSeparator3, Me.WaitingListToolStripMenuItem, Me.ToolStripSeparator6, Me.CollectionAccountsToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "&Customers"
        '
        'AddNewCustomerToolStripMenuItem
        '
        Me.AddNewCustomerToolStripMenuItem.Image = Global.FosterRollOff.My.Resources.Resources.Worker_Add
        Me.AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        Me.AddNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddNewCustomerToolStripMenuItem.Text = "&Add New Customer..."
        '
        'ViewCustomerListToolStripMenuItem
        '
        Me.ViewCustomerListToolStripMenuItem.Image = Global.FosterRollOff.My.Resources.Resources.Worker_Details
        Me.ViewCustomerListToolStripMenuItem.Name = "ViewCustomerListToolStripMenuItem"
        Me.ViewCustomerListToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ViewCustomerListToolStripMenuItem.Text = "&View Customer List..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(187, 6)
        '
        'WaitingListToolStripMenuItem
        '
        Me.WaitingListToolStripMenuItem.Image = Global.FosterRollOff.My.Resources.Resources.To_Do_Edit
        Me.WaitingListToolStripMenuItem.Name = "WaitingListToolStripMenuItem"
        Me.WaitingListToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.WaitingListToolStripMenuItem.Text = "View Waiting List..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(187, 6)
        '
        'CollectionAccountsToolStripMenuItem
        '
        Me.CollectionAccountsToolStripMenuItem.Name = "CollectionAccountsToolStripMenuItem"
        Me.CollectionAccountsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CollectionAccountsToolStripMenuItem.Text = "Collection Accounts..."
        '
        'RollOffsToolStripMenuItem
        '
        Me.RollOffsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InactiveRollOffsToolStripMenuItem, Me.ToolStripSeparator2, Me.BillSelectedAccountsToolStripMenuItem, Me.MonthlyBatchBillingToolStripMenuItem})
        Me.RollOffsToolStripMenuItem.Name = "RollOffsToolStripMenuItem"
        Me.RollOffsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.RollOffsToolStripMenuItem.Text = "Roll Offs"
        '
        'InactiveRollOffsToolStripMenuItem
        '
        Me.InactiveRollOffsToolStripMenuItem.Name = "InactiveRollOffsToolStripMenuItem"
        Me.InactiveRollOffsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.InactiveRollOffsToolStripMenuItem.Text = "Inactive Roll Offs..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'BillSelectedAccountsToolStripMenuItem
        '
        Me.BillSelectedAccountsToolStripMenuItem.Image = Global.FosterRollOff.My.Resources.Resources.Billing
        Me.BillSelectedAccountsToolStripMenuItem.Name = "BillSelectedAccountsToolStripMenuItem"
        Me.BillSelectedAccountsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.BillSelectedAccountsToolStripMenuItem.Text = "Bill Selected Accounts..."
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentSummaryToolStripMenuItem, Me.RevenueReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'PaymentSummaryToolStripMenuItem
        '
        Me.PaymentSummaryToolStripMenuItem.Image = Global.FosterRollOff.My.Resources.Resources.FunctionHS
        Me.PaymentSummaryToolStripMenuItem.Name = "PaymentSummaryToolStripMenuItem"
        Me.PaymentSummaryToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PaymentSummaryToolStripMenuItem.Text = "&Payment Summary..."
        '
        'RevenueReportToolStripMenuItem
        '
        Me.RevenueReportToolStripMenuItem.Image = Global.FosterRollOff.My.Resources.Resources.Bank
        Me.RevenueReportToolStripMenuItem.Name = "RevenueReportToolStripMenuItem"
        Me.RevenueReportToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RevenueReportToolStripMenuItem.Text = "&Revenue Report..."
        '
        'ToolStripMain
        '
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAddNewCustomer, Me.ToolStripButtonViewCustomerList, Me.ToolStripButtonBillSelected, Me.ToolStripButtonBillingLog, Me.ToolStripSeparator4, Me.ToolStripButtonAddToWaitingList, Me.ToolStripButtonWaitingList, Me.ToolStripButtonRefresh, Me.ToolStripButtonRefreshAll, Me.ToolStripButtonPaymentSummary, Me.ToolStripButtonRevenueReport})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(1311, 25)
        Me.ToolStripMain.TabIndex = 3
        Me.ToolStripMain.Text = "ToolStrip1"
        '
        'ToolStripButtonAddNewCustomer
        '
        Me.ToolStripButtonAddNewCustomer.Image = Global.FosterRollOff.My.Resources.Resources.Worker_Add
        Me.ToolStripButtonAddNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAddNewCustomer.Name = "ToolStripButtonAddNewCustomer"
        Me.ToolStripButtonAddNewCustomer.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripButtonAddNewCustomer.Text = "Add New Customer..."
        '
        'ToolStripButtonViewCustomerList
        '
        Me.ToolStripButtonViewCustomerList.Image = Global.FosterRollOff.My.Resources.Resources.Worker_Details
        Me.ToolStripButtonViewCustomerList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonViewCustomerList.Name = "ToolStripButtonViewCustomerList"
        Me.ToolStripButtonViewCustomerList.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripButtonViewCustomerList.Text = "View Customer List..."
        '
        'ToolStripButtonBillSelected
        '
        Me.ToolStripButtonBillSelected.Image = Global.FosterRollOff.My.Resources.Resources.Billing
        Me.ToolStripButtonBillSelected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBillSelected.Name = "ToolStripButtonBillSelected"
        Me.ToolStripButtonBillSelected.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripButtonBillSelected.Text = "Bill Selected Accounts..."
        '
        'ToolStripButtonBillingLog
        '
        Me.ToolStripButtonBillingLog.Image = Global.FosterRollOff.My.Resources.Resources.Ledger
        Me.ToolStripButtonBillingLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBillingLog.Name = "ToolStripButtonBillingLog"
        Me.ToolStripButtonBillingLog.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripButtonBillingLog.Text = "Billing Log..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonAddToWaitingList
        '
        Me.ToolStripButtonAddToWaitingList.Image = Global.FosterRollOff.My.Resources.Resources._005_Task_16x16_72
        Me.ToolStripButtonAddToWaitingList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAddToWaitingList.Name = "ToolStripButtonAddToWaitingList"
        Me.ToolStripButtonAddToWaitingList.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripButtonAddToWaitingList.Text = "Add to Waiting List..."
        '
        'ToolStripButtonWaitingList
        '
        Me.ToolStripButtonWaitingList.Image = Global.FosterRollOff.My.Resources.Resources.To_Do_Edit
        Me.ToolStripButtonWaitingList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonWaitingList.Name = "ToolStripButtonWaitingList"
        Me.ToolStripButtonWaitingList.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripButtonWaitingList.Text = "View Waiting List..."
        '
        'ToolStripButtonRefresh
        '
        Me.ToolStripButtonRefresh.Image = Global.FosterRollOff.My.Resources.Resources.Refresh_All
        Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
        Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripButtonRefresh.Text = "Refresh Selected"
        '
        'ToolStripButtonRefreshAll
        '
        Me.ToolStripButtonRefreshAll.Image = Global.FosterRollOff.My.Resources.Resources._112_RefreshArrow_Green_16x16_72
        Me.ToolStripButtonRefreshAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefreshAll.Name = "ToolStripButtonRefreshAll"
        Me.ToolStripButtonRefreshAll.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripButtonRefreshAll.Text = "Refresh All"
        '
        'ToolStripButtonPaymentSummary
        '
        Me.ToolStripButtonPaymentSummary.Image = Global.FosterRollOff.My.Resources.Resources.FunctionHS
        Me.ToolStripButtonPaymentSummary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPaymentSummary.Name = "ToolStripButtonPaymentSummary"
        Me.ToolStripButtonPaymentSummary.Size = New System.Drawing.Size(128, 22)
        Me.ToolStripButtonPaymentSummary.Text = "Payment Summary"
        '
        'ToolStripButtonRevenueReport
        '
        Me.ToolStripButtonRevenueReport.Image = Global.FosterRollOff.My.Resources.Resources.Bank
        Me.ToolStripButtonRevenueReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRevenueReport.Name = "ToolStripButtonRevenueReport"
        Me.ToolStripButtonRevenueReport.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripButtonRevenueReport.Text = "Revenue Report"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dumping Charges"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.DataPropertyName = "Customer"
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Charges..."
        '
        'DataGridViewRollOffs
        '
        Me.DataGridViewRollOffs.AllowUserToAddRows = False
        Me.DataGridViewRollOffs.AllowUserToDeleteRows = False
        Me.DataGridViewRollOffs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRollOffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRollOffs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUniqueID, Me.colBill, Me.colCustomer, Me.colRollOffDelivered, Me.colSize, Me.colDay, Me.colDateRollOffPickedUp, Me.TotalDeposits, Me.colButtonDeposits, Me.colDumpingCharges, Me.colButtonCharges, Me.TotalPayments, Me.colButtonPayments, Me.RollOffTotalCharge, Me.colHistory, Me.colLastBill, Me.colAccountNumber})
        Me.DataGridViewRollOffs.Location = New System.Drawing.Point(12, 88)
        Me.DataGridViewRollOffs.Name = "DataGridViewRollOffs"
        Me.DataGridViewRollOffs.RowHeadersVisible = False
        Me.DataGridViewRollOffs.RowTemplate.Height = 30
        Me.DataGridViewRollOffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridViewRollOffs.Size = New System.Drawing.Size(1287, 466)
        Me.DataGridViewRollOffs.TabIndex = 0
        '
        'colUniqueID
        '
        Me.colUniqueID.HeaderText = "ID"
        Me.colUniqueID.Name = "colUniqueID"
        Me.colUniqueID.Visible = False
        '
        'colBill
        '
        Me.colBill.FalseValue = "False"
        Me.colBill.HeaderText = "Select"
        Me.colBill.Name = "colBill"
        Me.colBill.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colBill.TrueValue = "True"
        Me.colBill.Width = 40
        '
        'colCustomer
        '
        Me.colCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        Me.colCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colRollOffDelivered
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colRollOffDelivered.DefaultCellStyle = DataGridViewCellStyle1
        Me.colRollOffDelivered.HeaderText = "Roll Off Delivered"
        Me.colRollOffDelivered.Name = "colRollOffDelivered"
        Me.colRollOffDelivered.ReadOnly = True
        '
        'colSize
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSize.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSize.HeaderText = "Size"
        Me.colSize.Name = "colSize"
        Me.colSize.ReadOnly = True
        Me.colSize.Width = 50
        '
        'colDay
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDay.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDay.HeaderText = "Days"
        Me.colDay.Name = "colDay"
        Me.colDay.ReadOnly = True
        Me.colDay.Width = 50
        '
        'colDateRollOffPickedUp
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colDateRollOffPickedUp.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDateRollOffPickedUp.HeaderText = "Roll Off Picked Up"
        Me.colDateRollOffPickedUp.Name = "colDateRollOffPickedUp"
        Me.colDateRollOffPickedUp.ReadOnly = True
        '
        'TotalDeposits
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.TotalDeposits.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalDeposits.HeaderText = "Deposits"
        Me.TotalDeposits.Name = "TotalDeposits"
        Me.TotalDeposits.ReadOnly = True
        Me.TotalDeposits.Width = 80
        '
        'colButtonDeposits
        '
        Me.colButtonDeposits.HeaderText = ""
        Me.colButtonDeposits.Name = "colButtonDeposits"
        Me.colButtonDeposits.ReadOnly = True
        Me.colButtonDeposits.Text = "Deposits"
        Me.colButtonDeposits.UseColumnTextForButtonValue = True
        Me.colButtonDeposits.Width = 70
        '
        'colDumpingCharges
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.colDumpingCharges.DefaultCellStyle = DataGridViewCellStyle6
        Me.colDumpingCharges.HeaderText = "Dumping Charges"
        Me.colDumpingCharges.Name = "colDumpingCharges"
        Me.colDumpingCharges.ReadOnly = True
        Me.colDumpingCharges.Width = 80
        '
        'colButtonCharges
        '
        Me.colButtonCharges.HeaderText = ""
        Me.colButtonCharges.Name = "colButtonCharges"
        Me.colButtonCharges.ReadOnly = True
        Me.colButtonCharges.Text = "Charges"
        Me.colButtonCharges.UseColumnTextForButtonValue = True
        Me.colButtonCharges.Width = 70
        '
        'TotalPayments
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.TotalPayments.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalPayments.HeaderText = "Payments"
        Me.TotalPayments.Name = "TotalPayments"
        Me.TotalPayments.ReadOnly = True
        Me.TotalPayments.Width = 80
        '
        'colButtonPayments
        '
        Me.colButtonPayments.HeaderText = ""
        Me.colButtonPayments.Name = "colButtonPayments"
        Me.colButtonPayments.ReadOnly = True
        Me.colButtonPayments.Text = "Payments"
        Me.colButtonPayments.UseColumnTextForButtonValue = True
        Me.colButtonPayments.Width = 70
        '
        'RollOffTotalCharge
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Format = "c2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.RollOffTotalCharge.DefaultCellStyle = DataGridViewCellStyle8
        Me.RollOffTotalCharge.HeaderText = "Total"
        Me.RollOffTotalCharge.Name = "RollOffTotalCharge"
        Me.RollOffTotalCharge.ReadOnly = True
        Me.RollOffTotalCharge.Width = 70
        '
        'colHistory
        '
        Me.colHistory.HeaderText = ""
        Me.colHistory.Image = Global.FosterRollOff.My.Resources.Resources.History
        Me.colHistory.Name = "colHistory"
        Me.colHistory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colHistory.ToolTipText = "Show History for Roll Off"
        Me.colHistory.Width = 40
        '
        'colLastBill
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLastBill.DefaultCellStyle = DataGridViewCellStyle9
        Me.colLastBill.HeaderText = "Last Bill"
        Me.colLastBill.Name = "colLastBill"
        Me.colLastBill.ReadOnly = True
        Me.colLastBill.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colLastBill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colLastBill.Width = 125
        '
        'colAccountNumber
        '
        Me.colAccountNumber.HeaderText = "AcctNumber"
        Me.colAccountNumber.Name = "colAccountNumber"
        Me.colAccountNumber.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(208, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search List"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(283, 59)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(409, 21)
        Me.TextBoxSearch.TabIndex = 5
        '
        'ButtonClearSearch
        '
        Me.ButtonClearSearch.Location = New System.Drawing.Point(698, 57)
        Me.ButtonClearSearch.Name = "ButtonClearSearch"
        Me.ButtonClearSearch.Size = New System.Drawing.Size(109, 23)
        Me.ButtonClearSearch.TabIndex = 6
        Me.ButtonClearSearch.Text = "Clear Search..."
        Me.ButtonClearSearch.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.FosterRollOff.My.Resources.Resources.History
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Show History for Roll Off"
        Me.DataGridViewImageColumn1.Width = 40
        '
        'MonthlyBatchBillingToolStripMenuItem
        '
        Me.MonthlyBatchBillingToolStripMenuItem.Name = "MonthlyBatchBillingToolStripMenuItem"
        Me.MonthlyBatchBillingToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.MonthlyBatchBillingToolStripMenuItem.Text = "Monthly Batch Billing..."
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 566)
        Me.Controls.Add(Me.ButtonClearSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewRollOffs)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Name = "MainScreen"
        Me.Text = "Foster's Disposal - Roll Off Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        CType(Me.DataGridViewRollOffs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonViewCustomerList As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonAddNewCustomer As System.Windows.Forms.ToolStripButton
    Friend WithEvents SetupRollOffFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConvertFileProDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DailyRentalRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollOffChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButtonBillSelected As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewRollOffs As System.Windows.Forms.DataGridView
    Friend WithEvents RollOffsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InactiveRollOffsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WaitingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonWaitingList As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPaymentSummary As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRevenueReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevenueReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BillSelectedAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonBillingLog As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConvertWaitingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonAddToWaitingList As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRefreshAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClearSearch As System.Windows.Forms.Button
    Friend WithEvents colUniqueID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBill As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCustomer As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colRollOffDelivered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateRollOffPickedUp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDeposits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colButtonDeposits As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDumpingCharges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colButtonCharges As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TotalPayments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colButtonPayments As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents RollOffTotalCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHistory As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colLastBill As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colAccountNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CollectionAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyBatchBillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
