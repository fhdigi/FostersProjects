<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingReview
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.LabelAcctNumber = New System.Windows.Forms.Label()
        Me.LabelSeqNumber = New System.Windows.Forms.Label()
        Me.LabelBillingType = New System.Windows.Forms.Label()
        Me.LabelMonthlyCharge = New System.Windows.Forms.Label()
        Me.LabelTotalCharge = New System.Windows.Forms.Label()
        Me.LabelBagsAllowed = New System.Windows.Forms.Label()
        Me.LabelBagsPickedUp = New System.Windows.Forms.Label()
        Me.LabelExtraBagQty = New System.Windows.Forms.Label()
        Me.LabelExtraBagCost = New System.Windows.Forms.Label()
        Me.DateTimePickerBillingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ListBoxCustomers = New System.Windows.Forms.ListBox()
        Me.LabelTotalAmount = New System.Windows.Forms.Label()
        Me.LabelCurrentBalance = New System.Windows.Forms.Label()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelSaved = New System.Windows.Forms.Label()
        Me.PictureBoxSaved = New System.Windows.Forms.PictureBox()
        Me.LabelGenerate = New System.Windows.Forms.Label()
        Me.PictureBoxGenerate = New System.Windows.Forms.PictureBox()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.DataGridViewHistory = New System.Windows.Forms.DataGridView()
        Me.colTransID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCustomerHistoryLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonSaveCurrentBill = New System.Windows.Forms.Button()
        Me.ButtonCreateBills = New System.Windows.Forms.Button()
        Me.ButtonResetData = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBoxClosedAccounts = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCustomerHistoryLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClosedAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.AllowUserToAddRows = False
        Me.DataGridViewItems.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDescription, Me.colAmount})
        Me.DataGridViewItems.Location = New System.Drawing.Point(523, 164)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.Size = New System.Drawing.Size(439, 252)
        Me.DataGridViewItems.TabIndex = 0
        '
        'colDescription
        '
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Width = 250
        '
        'colAmount
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle8
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        '
        'LabelCustomer
        '
        Me.LabelCustomer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomer.Location = New System.Drawing.Point(520, 57)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(172, 20)
        Me.LabelCustomer.TabIndex = 1
        '
        'LabelAcctNumber
        '
        Me.LabelAcctNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAcctNumber.ForeColor = System.Drawing.Color.Blue
        Me.LabelAcctNumber.Location = New System.Drawing.Point(520, 85)
        Me.LabelAcctNumber.Name = "LabelAcctNumber"
        Me.LabelAcctNumber.Size = New System.Drawing.Size(172, 20)
        Me.LabelAcctNumber.TabIndex = 2
        '
        'LabelSeqNumber
        '
        Me.LabelSeqNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeqNumber.ForeColor = System.Drawing.Color.Blue
        Me.LabelSeqNumber.Location = New System.Drawing.Point(520, 113)
        Me.LabelSeqNumber.Name = "LabelSeqNumber"
        Me.LabelSeqNumber.Size = New System.Drawing.Size(172, 20)
        Me.LabelSeqNumber.TabIndex = 3
        '
        'LabelBillingType
        '
        Me.LabelBillingType.Location = New System.Drawing.Point(712, 57)
        Me.LabelBillingType.Name = "LabelBillingType"
        Me.LabelBillingType.Size = New System.Drawing.Size(179, 20)
        Me.LabelBillingType.TabIndex = 1
        '
        'LabelMonthlyCharge
        '
        Me.LabelMonthlyCharge.Location = New System.Drawing.Point(712, 85)
        Me.LabelMonthlyCharge.Name = "LabelMonthlyCharge"
        Me.LabelMonthlyCharge.Size = New System.Drawing.Size(179, 20)
        Me.LabelMonthlyCharge.TabIndex = 2
        '
        'LabelTotalCharge
        '
        Me.LabelTotalCharge.Location = New System.Drawing.Point(712, 113)
        Me.LabelTotalCharge.Name = "LabelTotalCharge"
        Me.LabelTotalCharge.Size = New System.Drawing.Size(179, 20)
        Me.LabelTotalCharge.TabIndex = 3
        '
        'LabelBagsAllowed
        '
        Me.LabelBagsAllowed.Location = New System.Drawing.Point(897, 57)
        Me.LabelBagsAllowed.Name = "LabelBagsAllowed"
        Me.LabelBagsAllowed.Size = New System.Drawing.Size(117, 20)
        Me.LabelBagsAllowed.TabIndex = 1
        '
        'LabelBagsPickedUp
        '
        Me.LabelBagsPickedUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelBagsPickedUp.ForeColor = System.Drawing.Color.Blue
        Me.LabelBagsPickedUp.Location = New System.Drawing.Point(897, 85)
        Me.LabelBagsPickedUp.Name = "LabelBagsPickedUp"
        Me.LabelBagsPickedUp.Size = New System.Drawing.Size(117, 20)
        Me.LabelBagsPickedUp.TabIndex = 2
        '
        'LabelExtraBagQty
        '
        Me.LabelExtraBagQty.Location = New System.Drawing.Point(897, 113)
        Me.LabelExtraBagQty.Name = "LabelExtraBagQty"
        Me.LabelExtraBagQty.Size = New System.Drawing.Size(117, 20)
        Me.LabelExtraBagQty.TabIndex = 3
        '
        'LabelExtraBagCost
        '
        Me.LabelExtraBagCost.Location = New System.Drawing.Point(897, 138)
        Me.LabelExtraBagCost.Name = "LabelExtraBagCost"
        Me.LabelExtraBagCost.Size = New System.Drawing.Size(117, 20)
        Me.LabelExtraBagCost.TabIndex = 3
        '
        'DateTimePickerBillingDate
        '
        Me.DateTimePickerBillingDate.Location = New System.Drawing.Point(205, 47)
        Me.DateTimePickerBillingDate.Name = "DateTimePickerBillingDate"
        Me.DateTimePickerBillingDate.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerBillingDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Billing Date"
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(968, 392)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 5
        Me.ButtonPrevious.Text = "<< Previous"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(1049, 392)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 5
        Me.ButtonNext.Text = "Next >>"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(411, 45)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 6
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ListBoxCustomers
        '
        Me.ListBoxCustomers.FormattingEnabled = True
        Me.ListBoxCustomers.Location = New System.Drawing.Point(146, 125)
        Me.ListBoxCustomers.Name = "ListBoxCustomers"
        Me.ListBoxCustomers.Size = New System.Drawing.Size(343, 550)
        Me.ListBoxCustomers.TabIndex = 7
        '
        'LabelTotalAmount
        '
        Me.LabelTotalAmount.AutoSize = True
        Me.LabelTotalAmount.Location = New System.Drawing.Point(178, 402)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(0, 13)
        Me.LabelTotalAmount.TabIndex = 3
        '
        'LabelCurrentBalance
        '
        Me.LabelCurrentBalance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentBalance.ForeColor = System.Drawing.Color.Blue
        Me.LabelCurrentBalance.Location = New System.Drawing.Point(520, 138)
        Me.LabelCurrentBalance.Name = "LabelCurrentBalance"
        Me.LabelCurrentBalance.Size = New System.Drawing.Size(371, 20)
        Me.LabelCurrentBalance.TabIndex = 8
        '
        'ButtonPreview
        '
        Me.ButtonPreview.Image = Global.FosterOffice.My.Resources.Resources.Preview
        Me.ButtonPreview.Location = New System.Drawing.Point(968, 272)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(156, 30)
        Me.ButtonPreview.TabIndex = 10
        Me.ButtonPreview.Text = "   Preview Bills..."
        Me.ButtonPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonPreview.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(205, 85)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxSearch.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(411, 84)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(27, 21)
        Me.ButtonSearch.TabIndex = 13
        Me.ButtonSearch.Text = "?"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBoxClosedAccounts)
        Me.Panel1.Controls.Add(Me.LabelSaved)
        Me.Panel1.Controls.Add(Me.PictureBoxSaved)
        Me.Panel1.Controls.Add(Me.LabelGenerate)
        Me.Panel1.Controls.Add(Me.PictureBoxGenerate)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 784)
        Me.Panel1.TabIndex = 18
        '
        'LabelSaved
        '
        Me.LabelSaved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelSaved.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaved.Location = New System.Drawing.Point(3, 142)
        Me.LabelSaved.Name = "LabelSaved"
        Me.LabelSaved.Size = New System.Drawing.Size(122, 22)
        Me.LabelSaved.TabIndex = 1
        Me.LabelSaved.Text = "Saved"
        Me.LabelSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxSaved
        '
        Me.PictureBoxSaved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSaved.Image = Global.FosterOffice.My.Resources.Resources.Database
        Me.PictureBoxSaved.Location = New System.Drawing.Point(48, 104)
        Me.PictureBoxSaved.Name = "PictureBoxSaved"
        Me.PictureBoxSaved.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxSaved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxSaved.TabIndex = 0
        Me.PictureBoxSaved.TabStop = False
        '
        'LabelGenerate
        '
        Me.LabelGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGenerate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenerate.Location = New System.Drawing.Point(3, 62)
        Me.LabelGenerate.Name = "LabelGenerate"
        Me.LabelGenerate.Size = New System.Drawing.Size(122, 22)
        Me.LabelGenerate.TabIndex = 1
        Me.LabelGenerate.Text = "Generate "
        Me.LabelGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxGenerate
        '
        Me.PictureBoxGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxGenerate.Image = Global.FosterOffice.My.Resources.Resources.Form_Wizard
        Me.PictureBoxGenerate.Location = New System.Drawing.Point(48, 24)
        Me.PictureBoxGenerate.Name = "PictureBoxGenerate"
        Me.PictureBoxGenerate.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxGenerate.TabIndex = 0
        Me.PictureBoxGenerate.TabStop = False
        '
        'LabelHeader
        '
        Me.LabelHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelHeader.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.Blue
        Me.LabelHeader.Location = New System.Drawing.Point(127, -1)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(1010, 32)
        Me.LabelHeader.TabIndex = 19
        Me.LabelHeader.Text = "Bills to be Generated"
        Me.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewHistory
        '
        Me.DataGridViewHistory.AllowUserToAddRows = False
        Me.DataGridViewHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewHistory.AutoGenerateColumns = False
        Me.DataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTransID, Me.colCustomerID, Me.TransactionDateDataGridViewTextBoxColumn, Me.TransactionDescDataGridViewTextBoxColumn, Me.TransactionAmountDataGridViewTextBoxColumn, Me.RunningBalanceDataGridViewTextBoxColumn})
        Me.DataGridViewHistory.DataSource = Me.CCustomerHistoryLineItemsBindingSource
        Me.DataGridViewHistory.Location = New System.Drawing.Point(523, 437)
        Me.DataGridViewHistory.Name = "DataGridViewHistory"
        Me.DataGridViewHistory.ReadOnly = True
        Me.DataGridViewHistory.Size = New System.Drawing.Size(601, 242)
        Me.DataGridViewHistory.TabIndex = 20
        '
        'colTransID
        '
        Me.colTransID.DataPropertyName = "TransactionID"
        Me.colTransID.HeaderText = "TransID"
        Me.colTransID.Name = "colTransID"
        Me.colTransID.ReadOnly = True
        Me.colTransID.Visible = False
        '
        'colCustomerID
        '
        Me.colCustomerID.DataPropertyName = "CustomerID"
        Me.colCustomerID.HeaderText = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.ReadOnly = True
        Me.colCustomerID.Visible = False
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.TransactionDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        Me.TransactionDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionDescDataGridViewTextBoxColumn
        '
        Me.TransactionDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionDescDataGridViewTextBoxColumn.DataPropertyName = "TransactionDesc"
        Me.TransactionDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.TransactionDescDataGridViewTextBoxColumn.Name = "TransactionDescDataGridViewTextBoxColumn"
        Me.TransactionDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionAmountDataGridViewTextBoxColumn
        '
        Me.TransactionAmountDataGridViewTextBoxColumn.DataPropertyName = "TransactionAmount"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0.00"
        Me.TransactionAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.TransactionAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.TransactionAmountDataGridViewTextBoxColumn.Name = "TransactionAmountDataGridViewTextBoxColumn"
        Me.TransactionAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RunningBalanceDataGridViewTextBoxColumn
        '
        Me.RunningBalanceDataGridViewTextBoxColumn.DataPropertyName = "RunningBalance"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0.00"
        Me.RunningBalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.RunningBalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.RunningBalanceDataGridViewTextBoxColumn.Name = "RunningBalanceDataGridViewTextBoxColumn"
        Me.RunningBalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CCustomerHistoryLineItemsBindingSource
        '
        Me.CCustomerHistoryLineItemsBindingSource.DataSource = GetType(PickupTransaction.Customer.CCustomerHistory.CCustomerHistoryLineItems)
        '
        'ButtonSaveCurrentBill
        '
        Me.ButtonSaveCurrentBill.Image = Global.FosterOffice.My.Resources.Resources.Save
        Me.ButtonSaveCurrentBill.Location = New System.Drawing.Point(968, 200)
        Me.ButtonSaveCurrentBill.Name = "ButtonSaveCurrentBill"
        Me.ButtonSaveCurrentBill.Size = New System.Drawing.Size(156, 30)
        Me.ButtonSaveCurrentBill.TabIndex = 11
        Me.ButtonSaveCurrentBill.Text = "   Save Current Bill"
        Me.ButtonSaveCurrentBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSaveCurrentBill.UseVisualStyleBackColor = True
        '
        'ButtonCreateBills
        '
        Me.ButtonCreateBills.Image = Global.FosterOffice.My.Resources.Resources.Billing
        Me.ButtonCreateBills.Location = New System.Drawing.Point(968, 164)
        Me.ButtonCreateBills.Name = "ButtonCreateBills"
        Me.ButtonCreateBills.Size = New System.Drawing.Size(155, 30)
        Me.ButtonCreateBills.TabIndex = 11
        Me.ButtonCreateBills.Text = "   Create Bills"
        Me.ButtonCreateBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCreateBills.UseVisualStyleBackColor = True
        '
        'ButtonResetData
        '
        Me.ButtonResetData.Image = Global.FosterOffice.My.Resources.Resources.delete_12x12
        Me.ButtonResetData.Location = New System.Drawing.Point(968, 236)
        Me.ButtonResetData.Name = "ButtonResetData"
        Me.ButtonResetData.Size = New System.Drawing.Size(156, 30)
        Me.ButtonResetData.TabIndex = 9
        Me.ButtonResetData.Text = "   Delete Bill / Reset"
        Me.ButtonResetData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonResetData.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Closed Accounts"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxClosedAccounts
        '
        Me.PictureBoxClosedAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClosedAccounts.Image = Global.FosterOffice.My.Resources.Resources.Receipt_Edit
        Me.PictureBoxClosedAccounts.Location = New System.Drawing.Point(48, 187)
        Me.PictureBoxClosedAccounts.Name = "PictureBoxClosedAccounts"
        Me.PictureBoxClosedAccounts.Size = New System.Drawing.Size(28, 28)
        Me.PictureBoxClosedAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxClosedAccounts.TabIndex = 2
        Me.PictureBoxClosedAccounts.TabStop = False
        '
        'BillingReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 697)
        Me.Controls.Add(Me.DataGridViewHistory)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSaveCurrentBill)
        Me.Controls.Add(Me.ButtonCreateBills)
        Me.Controls.Add(Me.ButtonPreview)
        Me.Controls.Add(Me.ButtonResetData)
        Me.Controls.Add(Me.LabelCurrentBalance)
        Me.Controls.Add(Me.ListBoxCustomers)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.DateTimePickerBillingDate)
        Me.Controls.Add(Me.LabelExtraBagCost)
        Me.Controls.Add(Me.LabelExtraBagQty)
        Me.Controls.Add(Me.LabelTotalCharge)
        Me.Controls.Add(Me.LabelTotalAmount)
        Me.Controls.Add(Me.LabelSeqNumber)
        Me.Controls.Add(Me.LabelBagsPickedUp)
        Me.Controls.Add(Me.LabelMonthlyCharge)
        Me.Controls.Add(Me.LabelAcctNumber)
        Me.Controls.Add(Me.LabelBagsAllowed)
        Me.Controls.Add(Me.LabelBillingType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Controls.Add(Me.DataGridViewItems)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillingReview"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Review"
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxSaved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCustomerHistoryLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClosedAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewItems As System.Windows.Forms.DataGridView
    Friend WithEvents LabelCustomer As System.Windows.Forms.Label
    Friend WithEvents LabelAcctNumber As System.Windows.Forms.Label
    Friend WithEvents LabelSeqNumber As System.Windows.Forms.Label
    Friend WithEvents LabelBillingType As System.Windows.Forms.Label
    Friend WithEvents LabelMonthlyCharge As System.Windows.Forms.Label
    Friend WithEvents LabelTotalCharge As System.Windows.Forms.Label
    Friend WithEvents LabelBagsAllowed As System.Windows.Forms.Label
    Friend WithEvents LabelBagsPickedUp As System.Windows.Forms.Label
    Friend WithEvents LabelExtraBagQty As System.Windows.Forms.Label
    Friend WithEvents LabelExtraBagCost As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerBillingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ListBoxCustomers As System.Windows.Forms.ListBox
    Friend WithEvents LabelTotalAmount As System.Windows.Forms.Label
    Friend WithEvents LabelCurrentBalance As System.Windows.Forms.Label
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonResetData As System.Windows.Forms.Button
    Friend WithEvents ButtonPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonCreateBills As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveCurrentBill As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelSaved As System.Windows.Forms.Label
    Friend WithEvents PictureBoxSaved As System.Windows.Forms.PictureBox
    Friend WithEvents LabelGenerate As System.Windows.Forms.Label
    Friend WithEvents PictureBoxGenerate As System.Windows.Forms.PictureBox
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents DataGridViewHistory As System.Windows.Forms.DataGridView
    Friend WithEvents colTransID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RunningBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCustomerHistoryLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxClosedAccounts As System.Windows.Forms.PictureBox
End Class
