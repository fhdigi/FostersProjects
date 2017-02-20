<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerPayments
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewCustomerPayments = New System.Windows.Forms.DataGridView()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonQuickPayment = New System.Windows.Forms.Button()
        Me.ButtonPrintReceipt = New System.Windows.Forms.Button()
        Me.ButtonPrintPaymentReport = New System.Windows.Forms.Button()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCheckNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreditCard = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAuthNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransactionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewCustomerPayments,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridViewCustomerPayments
        '
        Me.DataGridViewCustomerPayments.AllowUserToAddRows = false
        Me.DataGridViewCustomerPayments.AllowUserToDeleteRows = false
        Me.DataGridViewCustomerPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCustomerPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colBillDate, Me.colDescription, Me.colPaymentDate, Me.colPaymentAmount, Me.colCheckNumber, Me.colCreditCard, Me.colAuthNumber, Me.colTransactionId})
        Me.DataGridViewCustomerPayments.Location = New System.Drawing.Point(14, 54)
        Me.DataGridViewCustomerPayments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewCustomerPayments.Name = "DataGridViewCustomerPayments"
        Me.DataGridViewCustomerPayments.Size = New System.Drawing.Size(924, 343)
        Me.DataGridViewCustomerPayments.TabIndex = 1
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = true
        Me.LabelHeader.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.Blue
        Me.LabelHeader.Location = New System.Drawing.Point(9, 21)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(183, 19)
        Me.LabelHeader.TabIndex = 0
        Me.LabelHeader.Text = "{Customer Charges }"
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonSave.Location = New System.Drawing.Point(945, 16)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(105, 30)
        Me.ButtonSave.TabIndex = 3
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(945, 54)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(105, 30)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.Image = Global.FosterRollOff.My.Resources.Resources.Delete
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(945, 92)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(105, 30)
        Me.ButtonDelete.TabIndex = 5
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = true
        '
        'ButtonQuickPayment
        '
        Me.ButtonQuickPayment.Location = New System.Drawing.Point(14, 405)
        Me.ButtonQuickPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonQuickPayment.Name = "ButtonQuickPayment"
        Me.ButtonQuickPayment.Size = New System.Drawing.Size(136, 30)
        Me.ButtonQuickPayment.TabIndex = 2
        Me.ButtonQuickPayment.Text = "Quick Payment"
        Me.ButtonQuickPayment.UseVisualStyleBackColor = true
        '
        'ButtonPrintReceipt
        '
        Me.ButtonPrintReceipt.Location = New System.Drawing.Point(605, 405)
        Me.ButtonPrintReceipt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonPrintReceipt.Name = "ButtonPrintReceipt"
        Me.ButtonPrintReceipt.Size = New System.Drawing.Size(136, 30)
        Me.ButtonPrintReceipt.TabIndex = 6
        Me.ButtonPrintReceipt.Text = "Print Receipt..."
        Me.ButtonPrintReceipt.UseVisualStyleBackColor = true
        '
        'ButtonPrintPaymentReport
        '
        Me.ButtonPrintPaymentReport.Location = New System.Drawing.Point(747, 405)
        Me.ButtonPrintPaymentReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonPrintPaymentReport.Name = "ButtonPrintPaymentReport"
        Me.ButtonPrintPaymentReport.Size = New System.Drawing.Size(191, 30)
        Me.ButtonPrintPaymentReport.TabIndex = 7
        Me.ButtonPrintPaymentReport.Text = "Payment History Report..."
        Me.ButtonPrintPaymentReport.UseVisualStyleBackColor = true
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = false
        '
        'colBillDate
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.colBillDate.DefaultCellStyle = DataGridViewCellStyle5
        Me.colBillDate.HeaderText = "Billed On"
        Me.colBillDate.Name = "colBillDate"
        Me.colBillDate.ReadOnly = true
        Me.colBillDate.Width = 80
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colPaymentDate
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        Me.colPaymentDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPaymentDate.HeaderText = "Date"
        Me.colPaymentDate.Name = "colPaymentDate"
        '
        'colPaymentAmount
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.colPaymentAmount.DefaultCellStyle = DataGridViewCellStyle7
        Me.colPaymentAmount.HeaderText = "Amount"
        Me.colPaymentAmount.Name = "colPaymentAmount"
        '
        'colCheckNumber
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colCheckNumber.DefaultCellStyle = DataGridViewCellStyle8
        Me.colCheckNumber.HeaderText = "CheckNumber"
        Me.colCheckNumber.Name = "colCheckNumber"
        '
        'colCreditCard
        '
        Me.colCreditCard.HeaderText = "Credit Card"
        Me.colCreditCard.Name = "colCreditCard"
        Me.colCreditCard.Width = 60
        '
        'colAuthNumber
        '
        Me.colAuthNumber.HeaderText = "Authorization"
        Me.colAuthNumber.Name = "colAuthNumber"
        Me.colAuthNumber.Width = 90
        '
        'colTransactionId
        '
        Me.colTransactionId.HeaderText = "Transaction ID"
        Me.colTransactionId.Name = "colTransactionId"
        Me.colTransactionId.Width = 90
        '
        'CustomerPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 451)
        Me.Controls.Add(Me.ButtonPrintPaymentReport)
        Me.Controls.Add(Me.ButtonPrintReceipt)
        Me.Controls.Add(Me.ButtonQuickPayment)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.DataGridViewCustomerPayments)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "CustomerPayments"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Payments"
        CType(Me.DataGridViewCustomerPayments,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridViewCustomerPayments As System.Windows.Forms.DataGridView
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonQuickPayment As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintPaymentReport As System.Windows.Forms.Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colBillDate As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colPaymentDate As DataGridViewTextBoxColumn
    Friend WithEvents colPaymentAmount As DataGridViewTextBoxColumn
    Friend WithEvents colCheckNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCreditCard As DataGridViewCheckBoxColumn
    Friend WithEvents colAuthNumber As DataGridViewTextBoxColumn
    Friend WithEvents colTransactionId As DataGridViewTextBoxColumn
End Class
