<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalCustomerBillingReview
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.LabelAcctNumber = New System.Windows.Forms.Label()
        Me.LabelBagsPickedUp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ListBoxCustomers = New System.Windows.Forms.ListBox()
        Me.LabelTotalAmount = New System.Windows.Forms.Label()
        Me.LabelCurrentBalance = New System.Windows.Forms.Label()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBoxClosedAccounts = New System.Windows.Forms.PictureBox()
        Me.LabelSaved = New System.Windows.Forms.Label()
        Me.PictureBoxSaved = New System.Windows.Forms.PictureBox()
        Me.LabelGenerate = New System.Windows.Forms.Label()
        Me.PictureBoxGenerate = New System.Windows.Forms.PictureBox()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.DataGridViewHistory = New System.Windows.Forms.DataGridView()
        Me.colTransID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCustomerHistoryLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonSaveCurrentBill = New System.Windows.Forms.Button()
        Me.ButtonCreateBills = New System.Windows.Forms.Button()
        Me.ButtonResetData = New System.Windows.Forms.Button()
        Me.ComboBoxBillingMonth = New System.Windows.Forms.ComboBox()
        Me.TextBoxBillingYear = New System.Windows.Forms.TextBox()
        Me.LabelViewCompanyCard = New System.Windows.Forms.Label()
        Me.ButtonPrintSelectedBill = New System.Windows.Forms.Button()
        Me.CheckBoxWithHeader = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridViewItems,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxClosedAccounts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxSaved,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxGenerate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridViewHistory,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CCustomerHistoryLineItemsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.AllowUserToAddRows = false
        Me.DataGridViewItems.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DataGridViewItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colQty, Me.colDescription, Me.colAmount})
        Me.DataGridViewItems.Location = New System.Drawing.Point(335, 61)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.RowHeadersWidth = 20
        Me.DataGridViewItems.Size = New System.Drawing.Size(466, 903)
        Me.DataGridViewItems.TabIndex = 0
        '
        'colDate
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 70
        '
        'colQty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle3
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 50
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colAmount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Width = 80
        '
        'LabelCustomer
        '
        Me.LabelCustomer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelCustomer.Location = New System.Drawing.Point(332, 36)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(256, 20)
        Me.LabelCustomer.TabIndex = 1
        Me.LabelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAcctNumber
        '
        Me.LabelAcctNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelAcctNumber.ForeColor = System.Drawing.Color.Blue
        Me.LabelAcctNumber.Location = New System.Drawing.Point(601, 36)
        Me.LabelAcctNumber.Name = "LabelAcctNumber"
        Me.LabelAcctNumber.Size = New System.Drawing.Size(130, 20)
        Me.LabelAcctNumber.TabIndex = 2
        Me.LabelAcctNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelBagsPickedUp
        '
        Me.LabelBagsPickedUp.AutoSize = true
        Me.LabelBagsPickedUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelBagsPickedUp.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelBagsPickedUp.ForeColor = System.Drawing.Color.Blue
        Me.LabelBagsPickedUp.Location = New System.Drawing.Point(817, 88)
        Me.LabelBagsPickedUp.Name = "LabelBagsPickedUp"
        Me.LabelBagsPickedUp.Size = New System.Drawing.Size(164, 19)
        Me.LabelBagsPickedUp.TabIndex = 2
        Me.LabelBagsPickedUp.Text = "View Pickup History..."
        Me.LabelBagsPickedUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Billing Date"
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(821, 392)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 5
        Me.ButtonPrevious.Text = "<< Previous"
        Me.ButtonPrevious.UseVisualStyleBackColor = true
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(902, 392)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 5
        Me.ButtonNext.Text = "Next >>"
        Me.ButtonNext.UseVisualStyleBackColor = true
        '
        'ListBoxCustomers
        '
        Me.ListBoxCustomers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.ListBoxCustomers.FormattingEnabled = true
        Me.ListBoxCustomers.Location = New System.Drawing.Point(12, 172)
        Me.ListBoxCustomers.Name = "ListBoxCustomers"
        Me.ListBoxCustomers.Size = New System.Drawing.Size(298, 784)
        Me.ListBoxCustomers.TabIndex = 7
        '
        'LabelTotalAmount
        '
        Me.LabelTotalAmount.AutoSize = true
        Me.LabelTotalAmount.Location = New System.Drawing.Point(178, 402)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(0, 13)
        Me.LabelTotalAmount.TabIndex = 3
        '
        'LabelCurrentBalance
        '
        Me.LabelCurrentBalance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelCurrentBalance.ForeColor = System.Drawing.Color.Blue
        Me.LabelCurrentBalance.Location = New System.Drawing.Point(818, 59)
        Me.LabelCurrentBalance.Name = "LabelCurrentBalance"
        Me.LabelCurrentBalance.Size = New System.Drawing.Size(295, 20)
        Me.LabelCurrentBalance.TabIndex = 8
        Me.LabelCurrentBalance.Text = "***"
        '
        'ButtonPreview
        '
        Me.ButtonPreview.Image = Global.FosterOffice.My.Resources.Resources.Preview
        Me.ButtonPreview.Location = New System.Drawing.Point(821, 233)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(165, 30)
        Me.ButtonPreview.TabIndex = 10
        Me.ButtonPreview.Text = "   Preview All Bills..."
        Me.ButtonPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonPreview.UseVisualStyleBackColor = true
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(77, 141)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxSearch.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(31, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(283, 140)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(27, 21)
        Me.ButtonSearch.TabIndex = 13
        Me.ButtonSearch.Text = "?"
        Me.ButtonSearch.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Closed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxClosedAccounts
        '
        Me.PictureBoxClosedAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClosedAccounts.Image = Global.FosterOffice.My.Resources.Resources.Receipt_Edit
        Me.PictureBoxClosedAccounts.Location = New System.Drawing.Point(225, 79)
        Me.PictureBoxClosedAccounts.Name = "PictureBoxClosedAccounts"
        Me.PictureBoxClosedAccounts.Size = New System.Drawing.Size(28, 28)
        Me.PictureBoxClosedAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxClosedAccounts.TabIndex = 2
        Me.PictureBoxClosedAccounts.TabStop = false
        '
        'LabelSaved
        '
        Me.LabelSaved.AutoSize = true
        Me.LabelSaved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelSaved.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelSaved.Location = New System.Drawing.Point(146, 111)
        Me.LabelSaved.Name = "LabelSaved"
        Me.LabelSaved.Size = New System.Drawing.Size(42, 13)
        Me.LabelSaved.TabIndex = 1
        Me.LabelSaved.Text = "Saved"
        Me.LabelSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxSaved
        '
        Me.PictureBoxSaved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSaved.Image = Global.FosterOffice.My.Resources.Resources.Database
        Me.PictureBoxSaved.Location = New System.Drawing.Point(151, 75)
        Me.PictureBoxSaved.Name = "PictureBoxSaved"
        Me.PictureBoxSaved.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxSaved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxSaved.TabIndex = 0
        Me.PictureBoxSaved.TabStop = false
        '
        'LabelGenerate
        '
        Me.LabelGenerate.AutoSize = true
        Me.LabelGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGenerate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelGenerate.Location = New System.Drawing.Point(62, 110)
        Me.LabelGenerate.Name = "LabelGenerate"
        Me.LabelGenerate.Size = New System.Drawing.Size(63, 13)
        Me.LabelGenerate.TabIndex = 1
        Me.LabelGenerate.Text = "Generate "
        Me.LabelGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxGenerate
        '
        Me.PictureBoxGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxGenerate.Image = Global.FosterOffice.My.Resources.Resources.Form_Wizard
        Me.PictureBoxGenerate.Location = New System.Drawing.Point(77, 75)
        Me.PictureBoxGenerate.Name = "PictureBoxGenerate"
        Me.PictureBoxGenerate.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxGenerate.TabIndex = 0
        Me.PictureBoxGenerate.TabStop = false
        '
        'LabelHeader
        '
        Me.LabelHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.LabelHeader.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.Blue
        Me.LabelHeader.Location = New System.Drawing.Point(0, 0)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(1234, 32)
        Me.LabelHeader.TabIndex = 19
        Me.LabelHeader.Text = "Bills to be Generated"
        Me.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewHistory
        '
        Me.DataGridViewHistory.AllowUserToAddRows = false
        Me.DataGridViewHistory.AllowUserToDeleteRows = false
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DataGridViewHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DataGridViewHistory.AutoGenerateColumns = false
        Me.DataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTransID, Me.colCustomerID})
        Me.DataGridViewHistory.DataSource = Me.CCustomerHistoryLineItemsBindingSource
        Me.DataGridViewHistory.Location = New System.Drawing.Point(821, 434)
        Me.DataGridViewHistory.Name = "DataGridViewHistory"
        Me.DataGridViewHistory.ReadOnly = true
        Me.DataGridViewHistory.RowHeadersVisible = false
        Me.DataGridViewHistory.Size = New System.Drawing.Size(399, 528)
        Me.DataGridViewHistory.TabIndex = 20
        '
        'colTransID
        '
        Me.colTransID.DataPropertyName = "TransactionID"
        Me.colTransID.HeaderText = "TransID"
        Me.colTransID.Name = "colTransID"
        Me.colTransID.ReadOnly = true
        Me.colTransID.Visible = false
        '
        'colCustomerID
        '
        Me.colCustomerID.DataPropertyName = "CustomerID"
        Me.colCustomerID.HeaderText = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.ReadOnly = true
        Me.colCustomerID.Visible = false
        '
        'ButtonSaveCurrentBill
        '
        Me.ButtonSaveCurrentBill.Image = Global.FosterOffice.My.Resources.Resources.Save
        Me.ButtonSaveCurrentBill.Location = New System.Drawing.Point(821, 197)
        Me.ButtonSaveCurrentBill.Name = "ButtonSaveCurrentBill"
        Me.ButtonSaveCurrentBill.Size = New System.Drawing.Size(165, 30)
        Me.ButtonSaveCurrentBill.TabIndex = 11
        Me.ButtonSaveCurrentBill.Text = "   Save Current Bill"
        Me.ButtonSaveCurrentBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSaveCurrentBill.UseVisualStyleBackColor = true
        '
        'ButtonCreateBills
        '
        Me.ButtonCreateBills.Image = Global.FosterOffice.My.Resources.Resources.Billing
        Me.ButtonCreateBills.Location = New System.Drawing.Point(821, 161)
        Me.ButtonCreateBills.Name = "ButtonCreateBills"
        Me.ButtonCreateBills.Size = New System.Drawing.Size(165, 30)
        Me.ButtonCreateBills.TabIndex = 11
        Me.ButtonCreateBills.Text = "   Create Bills"
        Me.ButtonCreateBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCreateBills.UseVisualStyleBackColor = true
        '
        'ButtonResetData
        '
        Me.ButtonResetData.Image = Global.FosterOffice.My.Resources.Resources.delete_12x12
        Me.ButtonResetData.Location = New System.Drawing.Point(821, 329)
        Me.ButtonResetData.Name = "ButtonResetData"
        Me.ButtonResetData.Size = New System.Drawing.Size(165, 30)
        Me.ButtonResetData.TabIndex = 9
        Me.ButtonResetData.Text = "   Delete Bill / Reset"
        Me.ButtonResetData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonResetData.UseVisualStyleBackColor = true
        '
        'ComboBoxBillingMonth
        '
        Me.ComboBoxBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBillingMonth.FormattingEnabled = true
        Me.ComboBoxBillingMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxBillingMonth.Location = New System.Drawing.Point(77, 46)
        Me.ComboBoxBillingMonth.Name = "ComboBoxBillingMonth"
        Me.ComboBoxBillingMonth.Size = New System.Drawing.Size(176, 21)
        Me.ComboBoxBillingMonth.TabIndex = 21
        '
        'TextBoxBillingYear
        '
        Me.TextBoxBillingYear.Location = New System.Drawing.Point(259, 46)
        Me.TextBoxBillingYear.Name = "TextBoxBillingYear"
        Me.TextBoxBillingYear.Size = New System.Drawing.Size(51, 21)
        Me.TextBoxBillingYear.TabIndex = 22
        '
        'LabelViewCompanyCard
        '
        Me.LabelViewCompanyCard.AutoSize = true
        Me.LabelViewCompanyCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelViewCompanyCard.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelViewCompanyCard.ForeColor = System.Drawing.Color.Blue
        Me.LabelViewCompanyCard.Location = New System.Drawing.Point(817, 121)
        Me.LabelViewCompanyCard.Name = "LabelViewCompanyCard"
        Me.LabelViewCompanyCard.Size = New System.Drawing.Size(169, 19)
        Me.LabelViewCompanyCard.TabIndex = 2
        Me.LabelViewCompanyCard.Text = "View Customer Card..."
        Me.LabelViewCompanyCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonPrintSelectedBill
        '
        Me.ButtonPrintSelectedBill.Image = Global.FosterOffice.My.Resources.Resources.Preview
        Me.ButtonPrintSelectedBill.Location = New System.Drawing.Point(822, 269)
        Me.ButtonPrintSelectedBill.Name = "ButtonPrintSelectedBill"
        Me.ButtonPrintSelectedBill.Size = New System.Drawing.Size(165, 30)
        Me.ButtonPrintSelectedBill.TabIndex = 10
        Me.ButtonPrintSelectedBill.Text = "   Preview Selected Bill..."
        Me.ButtonPrintSelectedBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonPrintSelectedBill.UseVisualStyleBackColor = true
        '
        'CheckBoxWithHeader
        '
        Me.CheckBoxWithHeader.AutoSize = true
        Me.CheckBoxWithHeader.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxWithHeader.Location = New System.Drawing.Point(992, 276)
        Me.CheckBoxWithHeader.Name = "CheckBoxWithHeader"
        Me.CheckBoxWithHeader.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxWithHeader.TabIndex = 23
        Me.CheckBoxWithHeader.Text = "With Header"
        Me.CheckBoxWithHeader.UseVisualStyleBackColor = true
        '
        'RentalCustomerBillingReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 976)
        Me.Controls.Add(Me.CheckBoxWithHeader)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxBillingYear)
        Me.Controls.Add(Me.PictureBoxClosedAccounts)
        Me.Controls.Add(Me.ComboBoxBillingMonth)
        Me.Controls.Add(Me.LabelSaved)
        Me.Controls.Add(Me.DataGridViewHistory)
        Me.Controls.Add(Me.PictureBoxSaved)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.LabelGenerate)
        Me.Controls.Add(Me.PictureBoxGenerate)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSaveCurrentBill)
        Me.Controls.Add(Me.ButtonCreateBills)
        Me.Controls.Add(Me.ButtonPrintSelectedBill)
        Me.Controls.Add(Me.ButtonPreview)
        Me.Controls.Add(Me.ButtonResetData)
        Me.Controls.Add(Me.LabelCurrentBalance)
        Me.Controls.Add(Me.ListBoxCustomers)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.LabelTotalAmount)
        Me.Controls.Add(Me.LabelViewCompanyCard)
        Me.Controls.Add(Me.LabelBagsPickedUp)
        Me.Controls.Add(Me.LabelAcctNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Controls.Add(Me.DataGridViewItems)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "RentalCustomerBillingReview"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Review"
        CType(Me.DataGridViewItems,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxClosedAccounts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxSaved,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxGenerate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridViewHistory,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CCustomerHistoryLineItemsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridViewItems As System.Windows.Forms.DataGridView
    Friend WithEvents LabelCustomer As System.Windows.Forms.Label
    Friend WithEvents LabelAcctNumber As System.Windows.Forms.Label
    Friend WithEvents LabelBagsPickedUp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ListBoxCustomers As System.Windows.Forms.ListBox
    Friend WithEvents LabelTotalAmount As System.Windows.Forms.Label
    Friend WithEvents LabelCurrentBalance As System.Windows.Forms.Label
    Friend WithEvents ButtonResetData As System.Windows.Forms.Button
    Friend WithEvents ButtonPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonCreateBills As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveCurrentBill As System.Windows.Forms.Button
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
    Friend WithEvents ComboBoxBillingMonth As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxBillingYear As System.Windows.Forms.TextBox
    Friend WithEvents LabelViewCompanyCard As System.Windows.Forms.Label
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonPrintSelectedBill As System.Windows.Forms.Button
    Friend WithEvents CheckBoxWithHeader As System.Windows.Forms.CheckBox
End Class
