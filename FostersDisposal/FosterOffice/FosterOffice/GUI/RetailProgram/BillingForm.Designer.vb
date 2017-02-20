<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewBilling = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SequenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartingBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BagsAllowedThisPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BagsPickedUpThisPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalItemCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.DateTimePickerBillingDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.AccountNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillingTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtraBagsQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtraBagsCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalItemsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBillingDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxBillingPeriod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBillingDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Date"
        '
        'DataGridViewBilling
        '
        Me.DataGridViewBilling.AllowUserToAddRows = False
        Me.DataGridViewBilling.AllowUserToDeleteRows = False
        Me.DataGridViewBilling.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBilling.AutoGenerateColumns = False
        Me.DataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBilling.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.AccountNumberDataGridViewTextBoxColumn, Me.SequenceNumber, Me.CustomerNameDataGridViewTextBoxColumn, Me.StartingBalance, Me.BillingTypeDataGridViewTextBoxColumn, Me.MonthlyChargeDataGridViewTextBoxColumn, Me.TotalCharge, Me.BagsAllowedThisPeriod, Me.BagsPickedUpThisPeriod, Me.ExtraBagsQtyDataGridViewTextBoxColumn, Me.ExtraBagsCostDataGridViewTextBoxColumn, Me.AdditionalItemsDataGridViewTextBoxColumn, Me.AdditionalItemCost})
        Me.DataGridViewBilling.DataSource = Me.CBillingDataBindingSource
        Me.DataGridViewBilling.Location = New System.Drawing.Point(15, 39)
        Me.DataGridViewBilling.Name = "DataGridViewBilling"
        Me.DataGridViewBilling.RowHeadersVisible = False
        Me.DataGridViewBilling.Size = New System.Drawing.Size(1435, 501)
        Me.DataGridViewBilling.TabIndex = 3
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "Select"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Width = 60
        '
        'SequenceNumber
        '
        Me.SequenceNumber.DataPropertyName = "SequenceNumber"
        Me.SequenceNumber.HeaderText = "Seq. #"
        Me.SequenceNumber.Name = "SequenceNumber"
        Me.SequenceNumber.Width = 70
        '
        'StartingBalance
        '
        Me.StartingBalance.DataPropertyName = "StartingBalance"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.StartingBalance.DefaultCellStyle = DataGridViewCellStyle2
        Me.StartingBalance.HeaderText = "Bal"
        Me.StartingBalance.Name = "StartingBalance"
        Me.StartingBalance.Width = 70
        '
        'TotalCharge
        '
        Me.TotalCharge.DataPropertyName = "TotalCharge"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.TotalCharge.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalCharge.HeaderText = "TotalCharge"
        Me.TotalCharge.Name = "TotalCharge"
        Me.TotalCharge.ReadOnly = True
        '
        'BagsAllowedThisPeriod
        '
        Me.BagsAllowedThisPeriod.DataPropertyName = "BagsAllowedThisPeriod"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BagsAllowedThisPeriod.DefaultCellStyle = DataGridViewCellStyle6
        Me.BagsAllowedThisPeriod.HeaderText = "Bags Allowed"
        Me.BagsAllowedThisPeriod.Name = "BagsAllowedThisPeriod"
        Me.BagsAllowedThisPeriod.ReadOnly = True
        Me.BagsAllowedThisPeriod.Width = 80
        '
        'BagsPickedUpThisPeriod
        '
        Me.BagsPickedUpThisPeriod.DataPropertyName = "BagsPickedUpThisPeriod"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BagsPickedUpThisPeriod.DefaultCellStyle = DataGridViewCellStyle7
        Me.BagsPickedUpThisPeriod.HeaderText = "Bags PickedUp"
        Me.BagsPickedUpThisPeriod.Name = "BagsPickedUpThisPeriod"
        Me.BagsPickedUpThisPeriod.ReadOnly = True
        Me.BagsPickedUpThisPeriod.Width = 80
        '
        'AdditionalItemCost
        '
        Me.AdditionalItemCost.DataPropertyName = "AdditionalItemCost"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.AdditionalItemCost.DefaultCellStyle = DataGridViewCellStyle10
        Me.AdditionalItemCost.HeaderText = "AdditionalItemCost"
        Me.AdditionalItemCost.Name = "AdditionalItemCost"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(1375, 546)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'DateTimePickerBillingDate
        '
        Me.DateTimePickerBillingDate.Location = New System.Drawing.Point(77, 12)
        Me.DateTimePickerBillingDate.Name = "DateTimePickerBillingDate"
        Me.DateTimePickerBillingDate.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerBillingDate.TabIndex = 5
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(513, 11)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 8
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.Red
        Me.LabelStatus.Location = New System.Drawing.Point(12, 550)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 14)
        Me.LabelStatus.TabIndex = 9
        '
        'AccountNumberDataGridViewTextBoxColumn
        '
        Me.AccountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AccountNumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.AccountNumberDataGridViewTextBoxColumn.HeaderText = "Account #"
        Me.AccountNumberDataGridViewTextBoxColumn.Name = "AccountNumberDataGridViewTextBoxColumn"
        Me.AccountNumberDataGridViewTextBoxColumn.Width = 70
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 150
        '
        'BillingTypeDataGridViewTextBoxColumn
        '
        Me.BillingTypeDataGridViewTextBoxColumn.DataPropertyName = "BillingType"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BillingTypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.BillingTypeDataGridViewTextBoxColumn.HeaderText = "BillingType"
        Me.BillingTypeDataGridViewTextBoxColumn.Name = "BillingTypeDataGridViewTextBoxColumn"
        Me.BillingTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonthlyChargeDataGridViewTextBoxColumn
        '
        Me.MonthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.MonthlyChargeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MonthlyChargeDataGridViewTextBoxColumn.HeaderText = "MonthlyCharge"
        Me.MonthlyChargeDataGridViewTextBoxColumn.Name = "MonthlyChargeDataGridViewTextBoxColumn"
        Me.MonthlyChargeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExtraBagsQtyDataGridViewTextBoxColumn
        '
        Me.ExtraBagsQtyDataGridViewTextBoxColumn.DataPropertyName = "ExtraBagsQty"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ExtraBagsQtyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ExtraBagsQtyDataGridViewTextBoxColumn.HeaderText = "ExtraBagsQty"
        Me.ExtraBagsQtyDataGridViewTextBoxColumn.Name = "ExtraBagsQtyDataGridViewTextBoxColumn"
        '
        'ExtraBagsCostDataGridViewTextBoxColumn
        '
        Me.ExtraBagsCostDataGridViewTextBoxColumn.DataPropertyName = "ExtraBagsCost"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.ExtraBagsCostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.ExtraBagsCostDataGridViewTextBoxColumn.HeaderText = "ExtraBagsCost"
        Me.ExtraBagsCostDataGridViewTextBoxColumn.Name = "ExtraBagsCostDataGridViewTextBoxColumn"
        '
        'AdditionalItemsDataGridViewTextBoxColumn
        '
        Me.AdditionalItemsDataGridViewTextBoxColumn.DataPropertyName = "AdditionalItems"
        Me.AdditionalItemsDataGridViewTextBoxColumn.HeaderText = "AdditionalItems"
        Me.AdditionalItemsDataGridViewTextBoxColumn.Name = "AdditionalItemsDataGridViewTextBoxColumn"
        Me.AdditionalItemsDataGridViewTextBoxColumn.Width = 125
        '
        'CBillingDataBindingSource
        '
        Me.CBillingDataBindingSource.DataSource = GetType(PickupTransaction.CBillingData)
        '
        'ComboBoxBillingPeriod
        '
        Me.ComboBoxBillingPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBillingPeriod.FormattingEnabled = True
        Me.ComboBoxBillingPeriod.Items.AddRange(New Object() {"Delinquent Customers", "1 Month Customers", "2 Month Customers", "3 Month Customers"})
        Me.ComboBoxBillingPeriod.Location = New System.Drawing.Point(355, 13)
        Me.ComboBoxBillingPeriod.Name = "ComboBoxBillingPeriod"
        Me.ComboBoxBillingPeriod.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxBillingPeriod.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Billing Period"
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 581)
        Me.Controls.Add(Me.ComboBoxBillingPeriod)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.DateTimePickerBillingDate)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.DataGridViewBilling)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Billing Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBillingDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewBilling As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerBillingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents CBillingDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AccountNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SequenceNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartingBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillingTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthlyChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BagsAllowedThisPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BagsPickedUpThisPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtraBagsQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtraBagsCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdditionalItemsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdditionalItemCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxBillingPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
