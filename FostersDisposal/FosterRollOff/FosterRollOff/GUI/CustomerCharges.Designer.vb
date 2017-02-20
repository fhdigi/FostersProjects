<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerCharges
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewCustomerCharges = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChargeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBilledOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonAddDumpingService = New System.Windows.Forms.Button()
        Me.ButtonAddDumpingOnly = New System.Windows.Forms.Button()
        Me.ButtonAddMiscCharge = New System.Windows.Forms.Button()
        Me.CChargesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridViewCustomerCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CChargesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCustomerCharges
        '
        Me.DataGridViewCustomerCharges.AllowUserToAddRows = False
        Me.DataGridViewCustomerCharges.AllowUserToDeleteRows = False
        Me.DataGridViewCustomerCharges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCustomerCharges.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCustomerCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerCharges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colChargeType, Me.colBilledOn, Me.colDescription, Me.colDate, Me.colUnit, Me.colRate, Me.colTotal})
        Me.DataGridViewCustomerCharges.Location = New System.Drawing.Point(14, 54)
        Me.DataGridViewCustomerCharges.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewCustomerCharges.Name = "DataGridViewCustomerCharges"
        Me.DataGridViewCustomerCharges.Size = New System.Drawing.Size(950, 343)
        Me.DataGridViewCustomerCharges.TabIndex = 1
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'colChargeType
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colChargeType.DefaultCellStyle = DataGridViewCellStyle2
        Me.colChargeType.HeaderText = "Type"
        Me.colChargeType.Name = "colChargeType"
        Me.colChargeType.ReadOnly = True
        '
        'colBilledOn
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colBilledOn.DefaultCellStyle = DataGridViewCellStyle3
        Me.colBilledOn.HeaderText = "Billed On"
        Me.colBilledOn.Name = "colBilledOn"
        Me.colBilledOn.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colDate
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDate.HeaderText = "Charge Date"
        Me.colDate.Name = "colDate"
        '
        'colUnit
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.colUnit.DefaultCellStyle = DataGridViewCellStyle5
        Me.colUnit.HeaderText = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.Width = 60
        '
        'colRate
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.colRate.DefaultCellStyle = DataGridViewCellStyle6
        Me.colRate.HeaderText = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.Width = 60
        '
        'colTotal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Width = 80
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.Blue
        Me.LabelHeader.Location = New System.Drawing.Point(9, 21)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(183, 19)
        Me.LabelHeader.TabIndex = 0
        Me.LabelHeader.Text = "{Customer Charges }"
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonSave.Location = New System.Drawing.Point(971, 16)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(105, 30)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(971, 54)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(105, 30)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.Image = Global.FosterRollOff.My.Resources.Resources.Delete
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(971, 92)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(105, 30)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonAddDumpingService
        '
        Me.ButtonAddDumpingService.Location = New System.Drawing.Point(14, 405)
        Me.ButtonAddDumpingService.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddDumpingService.Name = "ButtonAddDumpingService"
        Me.ButtonAddDumpingService.Size = New System.Drawing.Size(210, 30)
        Me.ButtonAddDumpingService.TabIndex = 2
        Me.ButtonAddDumpingService.Text = "Add Dumping/Service Charge"
        Me.ButtonAddDumpingService.UseVisualStyleBackColor = True
        '
        'ButtonAddDumpingOnly
        '
        Me.ButtonAddDumpingOnly.Location = New System.Drawing.Point(384, 405)
        Me.ButtonAddDumpingOnly.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddDumpingOnly.Name = "ButtonAddDumpingOnly"
        Me.ButtonAddDumpingOnly.Size = New System.Drawing.Size(210, 30)
        Me.ButtonAddDumpingOnly.TabIndex = 3
        Me.ButtonAddDumpingOnly.Text = "Add Dumping Charge Only"
        Me.ButtonAddDumpingOnly.UseVisualStyleBackColor = True
        '
        'ButtonAddMiscCharge
        '
        Me.ButtonAddMiscCharge.Location = New System.Drawing.Point(754, 405)
        Me.ButtonAddMiscCharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddMiscCharge.Name = "ButtonAddMiscCharge"
        Me.ButtonAddMiscCharge.Size = New System.Drawing.Size(210, 30)
        Me.ButtonAddMiscCharge.TabIndex = 4
        Me.ButtonAddMiscCharge.Text = "Add Miscellaneous Charge"
        Me.ButtonAddMiscCharge.UseVisualStyleBackColor = True
        '
        'CChargesBindingSource
        '
        Me.CChargesBindingSource.DataSource = GetType(FosterRollOff.CCharges)
        '
        'CustomerCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 451)
        Me.Controls.Add(Me.ButtonAddMiscCharge)
        Me.Controls.Add(Me.ButtonAddDumpingOnly)
        Me.Controls.Add(Me.ButtonAddDumpingService)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.DataGridViewCustomerCharges)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerCharges"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Charges"
        CType(Me.DataGridViewCustomerCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CChargesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewCustomerCharges As System.Windows.Forms.DataGridView
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents CChargesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonAddDumpingService As System.Windows.Forms.Button
    Friend WithEvents ButtonAddDumpingOnly As System.Windows.Forms.Button
    Friend WithEvents ButtonAddMiscCharge As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChargeType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBilledOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
