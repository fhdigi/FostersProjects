<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentHistory
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.ButtonDeleteSelectedPayment = New System.Windows.Forms.Button()
        Me.ButtonEditSelectedPayment = New System.Windows.Forms.Button()
        Me.ButtonAddNewPayment = New System.Windows.Forms.Button()
        Me.DataGridViewPayments = New System.Windows.Forms.DataGridView()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LabelCustomer = New DevExpress.XtraEditors.LabelControl()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCheckNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDeleteSelectedPayment
        '
        Me.ButtonDeleteSelectedPayment.Location = New System.Drawing.Point(452, 320)
        Me.ButtonDeleteSelectedPayment.Name = "ButtonDeleteSelectedPayment"
        Me.ButtonDeleteSelectedPayment.Size = New System.Drawing.Size(159, 23)
        Me.ButtonDeleteSelectedPayment.TabIndex = 4
        Me.ButtonDeleteSelectedPayment.Text = "Delete Selected Payment..."
        Me.ButtonDeleteSelectedPayment.UseVisualStyleBackColor = True
        '
        'ButtonEditSelectedPayment
        '
        Me.ButtonEditSelectedPayment.Location = New System.Drawing.Point(232, 320)
        Me.ButtonEditSelectedPayment.Name = "ButtonEditSelectedPayment"
        Me.ButtonEditSelectedPayment.Size = New System.Drawing.Size(159, 23)
        Me.ButtonEditSelectedPayment.TabIndex = 3
        Me.ButtonEditSelectedPayment.Text = "Edit Selected Payment..."
        Me.ButtonEditSelectedPayment.UseVisualStyleBackColor = True
        '
        'ButtonAddNewPayment
        '
        Me.ButtonAddNewPayment.Location = New System.Drawing.Point(12, 320)
        Me.ButtonAddNewPayment.Name = "ButtonAddNewPayment"
        Me.ButtonAddNewPayment.Size = New System.Drawing.Size(159, 23)
        Me.ButtonAddNewPayment.TabIndex = 2
        Me.ButtonAddNewPayment.Text = "Add New Payment..."
        Me.ButtonAddNewPayment.UseVisualStyleBackColor = True
        '
        'DataGridViewPayments
        '
        Me.DataGridViewPayments.AllowUserToAddRows = False
        Me.DataGridViewPayments.AllowUserToDeleteRows = False
        Me.DataGridViewPayments.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPayments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colPaymentDate, Me.colPaymentAmount, Me.colMOP, Me.colCheckNumber, Me.colDescription, Me.colCustomerID})
        Me.DataGridViewPayments.DataSource = Me.PaymentsBindingSource
        Me.DataGridViewPayments.Location = New System.Drawing.Point(12, 37)
        Me.DataGridViewPayments.Name = "DataGridViewPayments"
        Me.DataGridViewPayments.ReadOnly = True
        Me.DataGridViewPayments.Size = New System.Drawing.Size(599, 277)
        Me.DataGridViewPayments.TabIndex = 1
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataSource = GetType(PickupTransaction.Payments)
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(635, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(85, 23)
        Me.ButtonClose.TabIndex = 5
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LabelCustomer
        '
        Me.LabelCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomer.Location = New System.Drawing.Point(12, 12)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(114, 19)
        Me.LabelCustomer.TabIndex = 0
        Me.LabelCustomer.Text = "LabelControl1"
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colPaymentDate
        '
        Me.colPaymentDate.DataPropertyName = "PaymentDate"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colPaymentDate.DefaultCellStyle = DataGridViewCellStyle8
        Me.colPaymentDate.HeaderText = "Date"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.ReadOnly = True
        '
        'colPaymentAmount
        '
        Me.colPaymentAmount.DataPropertyName = "PaymentAmount"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.colPaymentAmount.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPaymentAmount.HeaderText = "Amount"
        Me.colPaymentAmount.Name = "colPaymentAmount"
        Me.colPaymentAmount.ReadOnly = True
        '
        'colMOP
        '
        Me.colMOP.DataPropertyName = "MethodOfPaymentDesc"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colMOP.DefaultCellStyle = DataGridViewCellStyle10
        Me.colMOP.HeaderText = "MOP"
        Me.colMOP.Name = "colMOP"
        Me.colMOP.ReadOnly = True
        Me.colMOP.Width = 90
        '
        'colCheckNumber
        '
        Me.colCheckNumber.DataPropertyName = "CheckNumber"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colCheckNumber.DefaultCellStyle = DataGridViewCellStyle11
        Me.colCheckNumber.HeaderText = "CheckNumber"
        Me.colCheckNumber.Name = "colCheckNumber"
        Me.colCheckNumber.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.DataPropertyName = "Description"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle12
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        '
        'colCustomerID
        '
        Me.colCustomerID.DataPropertyName = "CustomerID"
        Me.colCustomerID.HeaderText = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.ReadOnly = True
        Me.colCustomerID.Visible = False
        '
        'PaymentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 355)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonDeleteSelectedPayment)
        Me.Controls.Add(Me.ButtonEditSelectedPayment)
        Me.Controls.Add(Me.ButtonAddNewPayment)
        Me.Controls.Add(Me.DataGridViewPayments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentHistory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment History"
        CType(Me.DataGridViewPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDeleteSelectedPayment As System.Windows.Forms.Button
    Friend WithEvents ButtonEditSelectedPayment As System.Windows.Forms.Button
    Friend WithEvents ButtonAddNewPayment As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPayments As System.Windows.Forms.DataGridView
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelCustomer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCheckNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
