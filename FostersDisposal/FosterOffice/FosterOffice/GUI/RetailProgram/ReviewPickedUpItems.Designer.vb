<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewPickedUpItems
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewCollectedItems = New System.Windows.Forms.DataGridView()
        Me.DatabaseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SequenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colPickupDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdditionalItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickupRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerItems = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxRoute = New System.Windows.Forms.ComboBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxRoutesToImport = New System.Windows.Forms.ListBox()
        Me.ButtonImportSelected = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.RadioButtonLocal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFTP = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridViewCollectedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickupRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCollectedItems
        '
        Me.DataGridViewCollectedItems.AllowUserToAddRows = False
        Me.DataGridViewCollectedItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCollectedItems.AutoGenerateColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCollectedItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewCollectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCollectedItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatabaseID, Me.colAddress, Me.SequenceNumber, Me.AccountNumber, Me.colCustomer, Me.colPickupDate, Me.colBags, Me.colAdditionalItem, Me.colItemPrice})
        Me.DataGridViewCollectedItems.DataSource = Me.PickupRecordsBindingSource
        Me.DataGridViewCollectedItems.Location = New System.Drawing.Point(12, 197)
        Me.DataGridViewCollectedItems.Name = "DataGridViewCollectedItems"
        Me.DataGridViewCollectedItems.RowHeadersVisible = False
        Me.DataGridViewCollectedItems.Size = New System.Drawing.Size(867, 433)
        Me.DataGridViewCollectedItems.TabIndex = 4
        '
        'DatabaseID
        '
        Me.DatabaseID.DataPropertyName = "DatabaseID"
        Me.DatabaseID.HeaderText = "DatabaseID"
        Me.DatabaseID.Name = "DatabaseID"
        Me.DatabaseID.Visible = False
        '
        'colAddress
        '
        Me.colAddress.DataPropertyName = "CustomerAddress"
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = False
        '
        'SequenceNumber
        '
        Me.SequenceNumber.DataPropertyName = "SequenceNumber"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SequenceNumber.DefaultCellStyle = DataGridViewCellStyle9
        Me.SequenceNumber.HeaderText = "Sequence"
        Me.SequenceNumber.Name = "SequenceNumber"
        '
        'AccountNumber
        '
        Me.AccountNumber.DataPropertyName = "AccountNumber"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AccountNumber.DefaultCellStyle = DataGridViewCellStyle10
        Me.AccountNumber.HeaderText = "Account"
        Me.AccountNumber.Name = "AccountNumber"
        '
        'colCustomer
        '
        Me.colCustomer.DataPropertyName = "CustomerName"
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        Me.colCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCustomer.Width = 150
        '
        'colPickupDate
        '
        Me.colPickupDate.DataPropertyName = "PickupDate"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.colPickupDate.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPickupDate.HeaderText = "Pickup Date"
        Me.colPickupDate.Name = "colPickupDate"
        '
        'colBags
        '
        Me.colBags.DataPropertyName = "GarbageBags"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colBags.DefaultCellStyle = DataGridViewCellStyle12
        Me.colBags.HeaderText = "Bags"
        Me.colBags.Name = "colBags"
        '
        'colAdditionalItem
        '
        Me.colAdditionalItem.DataPropertyName = "AdditionalItem"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colAdditionalItem.DefaultCellStyle = DataGridViewCellStyle13
        Me.colAdditionalItem.HeaderText = "Additional Item"
        Me.colAdditionalItem.Name = "colAdditionalItem"
        Me.colAdditionalItem.Width = 125
        '
        'colItemPrice
        '
        Me.colItemPrice.DataPropertyName = "AdditionalItemPrice"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = "0.00"
        Me.colItemPrice.DefaultCellStyle = DataGridViewCellStyle14
        Me.colItemPrice.HeaderText = "Additional Item Price"
        Me.colItemPrice.Name = "colItemPrice"
        '
        'PickupRecordsBindingSource
        '
        Me.PickupRecordsBindingSource.DataSource = GetType(PickupTransaction.CollectionRecord.PickupRecords)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Route"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'DateTimePickerItems
        '
        Me.DateTimePickerItems.Location = New System.Drawing.Point(182, 165)
        Me.DateTimePickerItems.Name = "DateTimePickerItems"
        Me.DateTimePickerItems.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerItems.TabIndex = 3
        '
        'ComboBoxRoute
        '
        Me.ComboBoxRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRoute.FormattingEnabled = True
        Me.ComboBoxRoute.Location = New System.Drawing.Point(51, 165)
        Me.ComboBoxRoute.Name = "ComboBoxRoute"
        Me.ComboBoxRoute.Size = New System.Drawing.Size(89, 21)
        Me.ComboBoxRoute.TabIndex = 1
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(804, 636)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Routes Ready for Import"
        '
        'ListBoxRoutesToImport
        '
        Me.ListBoxRoutesToImport.FormattingEnabled = True
        Me.ListBoxRoutesToImport.Location = New System.Drawing.Point(12, 32)
        Me.ListBoxRoutesToImport.Name = "ListBoxRoutesToImport"
        Me.ListBoxRoutesToImport.Size = New System.Drawing.Size(707, 108)
        Me.ListBoxRoutesToImport.TabIndex = 7
        '
        'ButtonImportSelected
        '
        Me.ButtonImportSelected.Location = New System.Drawing.Point(725, 32)
        Me.ButtonImportSelected.Name = "ButtonImportSelected"
        Me.ButtonImportSelected.Size = New System.Drawing.Size(153, 23)
        Me.ButtonImportSelected.TabIndex = 8
        Me.ButtonImportSelected.Text = "Import Selected"
        Me.ButtonImportSelected.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(584, 168)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(212, 21)
        Me.TextBoxSearch.TabIndex = 9
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(803, 168)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 10
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'RadioButtonLocal
        '
        Me.RadioButtonLocal.AutoSize = True
        Me.RadioButtonLocal.Checked = True
        Me.RadioButtonLocal.Location = New System.Drawing.Point(204, 9)
        Me.RadioButtonLocal.Name = "RadioButtonLocal"
        Me.RadioButtonLocal.Size = New System.Drawing.Size(49, 17)
        Me.RadioButtonLocal.TabIndex = 11
        Me.RadioButtonLocal.TabStop = True
        Me.RadioButtonLocal.Text = "Local"
        Me.RadioButtonLocal.UseVisualStyleBackColor = True
        '
        'RadioButtonFTP
        '
        Me.RadioButtonFTP.AutoSize = True
        Me.RadioButtonFTP.Location = New System.Drawing.Point(268, 9)
        Me.RadioButtonFTP.Name = "RadioButtonFTP"
        Me.RadioButtonFTP.Size = New System.Drawing.Size(43, 17)
        Me.RadioButtonFTP.TabIndex = 12
        Me.RadioButtonFTP.Text = "FTP"
        Me.RadioButtonFTP.UseVisualStyleBackColor = True
        '
        'ReviewPickedUpItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 671)
        Me.Controls.Add(Me.RadioButtonFTP)
        Me.Controls.Add(Me.RadioButtonLocal)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonImportSelected)
        Me.Controls.Add(Me.ListBoxRoutesToImport)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ComboBoxRoute)
        Me.Controls.Add(Me.DateTimePickerItems)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewCollectedItems)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReviewPickedUpItems"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Review Items"
        CType(Me.DataGridViewCollectedItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickupRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewCollectedItems As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerItems As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxRoute As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents PickupRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBoxRoutesToImport As System.Windows.Forms.ListBox
    Friend WithEvents ButtonImportSelected As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents DatabaseID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SequenceNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colPickupDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAdditionalItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButtonLocal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFTP As System.Windows.Forms.RadioButton
End Class
