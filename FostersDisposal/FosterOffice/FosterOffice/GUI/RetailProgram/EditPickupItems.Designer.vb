<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPickupItems
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
        Me.DatabaseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPickupDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGarbageBags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdditionalItems = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPickupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelPerson = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAddItem = New System.Windows.Forms.Button()
        Me.ButtonDeleteItem = New System.Windows.Forms.Button()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPickupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.AllowUserToDeleteRows = False
        Me.DataGridViewItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewItems.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatabaseID, Me.colPickupDate, Me.colGarbageBags, Me.colAdditionalItems, Me.colItemPrice})
        Me.DataGridViewItems.DataSource = Me.CPickupBindingSource
        Me.DataGridViewItems.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.Size = New System.Drawing.Size(485, 299)
        Me.DataGridViewItems.TabIndex = 1
        '
        'DatabaseID
        '
        Me.DatabaseID.DataPropertyName = "DatabaseID"
        Me.DatabaseID.HeaderText = "ID"
        Me.DatabaseID.Name = "DatabaseID"
        Me.DatabaseID.ReadOnly = True
        Me.DatabaseID.Visible = False
        Me.DatabaseID.Width = 50
        '
        'colPickupDate
        '
        Me.colPickupDate.DataPropertyName = "PickupDate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colPickupDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPickupDate.HeaderText = "Pickup Date"
        Me.colPickupDate.Name = "colPickupDate"
        '
        'colGarbageBags
        '
        Me.colGarbageBags.DataPropertyName = "GarbageBags"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colGarbageBags.DefaultCellStyle = DataGridViewCellStyle3
        Me.colGarbageBags.HeaderText = "Garbage Bags"
        Me.colGarbageBags.Name = "colGarbageBags"
        '
        'colAdditionalItems
        '
        Me.colAdditionalItems.DataPropertyName = "AdditionalItem"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colAdditionalItems.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAdditionalItems.HeaderText = "Additional Item"
        Me.colAdditionalItems.Name = "colAdditionalItems"
        Me.colAdditionalItems.Width = 120
        '
        'colItemPrice
        '
        Me.colItemPrice.DataPropertyName = "ItemPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.colItemPrice.DefaultCellStyle = DataGridViewCellStyle5
        Me.colItemPrice.HeaderText = "Item Price"
        Me.colItemPrice.Name = "colItemPrice"
        '
        'CPickupBindingSource
        '
        Me.CPickupBindingSource.DataSource = GetType(FosterOffice.EditPickupItems.CPickup)
        '
        'LabelPerson
        '
        Me.LabelPerson.AutoSize = True
        Me.LabelPerson.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPerson.ForeColor = System.Drawing.Color.Blue
        Me.LabelPerson.Location = New System.Drawing.Point(12, 11)
        Me.LabelPerson.Name = "LabelPerson"
        Me.LabelPerson.Size = New System.Drawing.Size(116, 17)
        Me.LabelPerson.TabIndex = 0
        Me.LabelPerson.Text = "Items Collected"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(422, 344)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonAddItem
        '
        Me.ButtonAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddItem.Location = New System.Drawing.Point(12, 344)
        Me.ButtonAddItem.Name = "ButtonAddItem"
        Me.ButtonAddItem.Size = New System.Drawing.Size(87, 23)
        Me.ButtonAddItem.TabIndex = 2
        Me.ButtonAddItem.Text = "Add Item"
        Me.ButtonAddItem.UseVisualStyleBackColor = True
        '
        'ButtonDeleteItem
        '
        Me.ButtonDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDeleteItem.Location = New System.Drawing.Point(105, 344)
        Me.ButtonDeleteItem.Name = "ButtonDeleteItem"
        Me.ButtonDeleteItem.Size = New System.Drawing.Size(87, 23)
        Me.ButtonDeleteItem.TabIndex = 3
        Me.ButtonDeleteItem.Text = "Delete Item"
        Me.ButtonDeleteItem.UseVisualStyleBackColor = True
        '
        'EditPickupItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 375)
        Me.Controls.Add(Me.ButtonDeleteItem)
        Me.Controls.Add(Me.ButtonAddItem)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.DataGridViewItems)
        Me.Controls.Add(Me.LabelPerson)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditPickupItems"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Pickup Items"
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPickupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewItems As System.Windows.Forms.DataGridView
    Friend WithEvents LabelPerson As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents CPickupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPickupDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGarbageBags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAdditionalItems As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonAddItem As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteItem As System.Windows.Forms.Button
End Class
