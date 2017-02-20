<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRentalPickupItems
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
        Me.DataGridViewRentals = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTrash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecycle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCardboard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRollOff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiscCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.ButtonDeleteSelectedItem = New System.Windows.Forms.Button()
        CType(Me.DataGridViewRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewRentals
        '
        Me.DataGridViewRentals.AllowUserToAddRows = False
        Me.DataGridViewRentals.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewRentals.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRentals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTrash, Me.colRecycle, Me.colCardboard, Me.colCart, Me.colRollOff, Me.colMiscCharge, Me.colNotes, Me.colID})
        Me.DataGridViewRentals.Location = New System.Drawing.Point(6, 57)
        Me.DataGridViewRentals.Name = "DataGridViewRentals"
        Me.DataGridViewRentals.RowHeadersWidth = 20
        Me.DataGridViewRentals.Size = New System.Drawing.Size(760, 426)
        Me.DataGridViewRentals.TabIndex = 1
        '
        'colDate
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        '
        'colTrash
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTrash.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTrash.HeaderText = "Trash"
        Me.colTrash.Name = "colTrash"
        Me.colTrash.Width = 70
        '
        'colRecycle
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colRecycle.DefaultCellStyle = DataGridViewCellStyle4
        Me.colRecycle.HeaderText = "Recycle"
        Me.colRecycle.Name = "colRecycle"
        Me.colRecycle.Width = 70
        '
        'colCardboard
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colCardboard.DefaultCellStyle = DataGridViewCellStyle5
        Me.colCardboard.HeaderText = "Cardboard"
        Me.colCardboard.Name = "colCardboard"
        Me.colCardboard.Width = 70
        '
        'colCart
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colCart.DefaultCellStyle = DataGridViewCellStyle6
        Me.colCart.HeaderText = "Cart"
        Me.colCart.Name = "colCart"
        Me.colCart.Width = 70
        '
        'colRollOff
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colRollOff.DefaultCellStyle = DataGridViewCellStyle7
        Me.colRollOff.HeaderText = "Roll Off"
        Me.colRollOff.Name = "colRollOff"
        Me.colRollOff.Width = 70
        '
        'colMiscCharge
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.colMiscCharge.DefaultCellStyle = DataGridViewCellStyle8
        Me.colMiscCharge.HeaderText = "Misc Charge"
        Me.colMiscCharge.Name = "colMiscCharge"
        Me.colMiscCharge.Width = 90
        '
        'colNotes
        '
        Me.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colNotes.DefaultCellStyle = DataGridViewCellStyle9
        Me.colNotes.HeaderText = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(691, 491)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.ForeColor = System.Drawing.Color.Blue
        Me.LabelCustomerName.Location = New System.Drawing.Point(12, 25)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(139, 19)
        Me.LabelCustomerName.TabIndex = 3
        Me.LabelCustomerName.Text = "Customer Name"
        '
        'ButtonDeleteSelectedItem
        '
        Me.ButtonDeleteSelectedItem.Location = New System.Drawing.Point(6, 491)
        Me.ButtonDeleteSelectedItem.Name = "ButtonDeleteSelectedItem"
        Me.ButtonDeleteSelectedItem.Size = New System.Drawing.Size(145, 23)
        Me.ButtonDeleteSelectedItem.TabIndex = 4
        Me.ButtonDeleteSelectedItem.Text = "Delete Selected Item..."
        Me.ButtonDeleteSelectedItem.UseVisualStyleBackColor = True
        '
        'ViewRentalPickupItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 526)
        Me.Controls.Add(Me.ButtonDeleteSelectedItem)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.DataGridViewRentals)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewRentalPickupItems"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Rental Pickup Items"
        CType(Me.DataGridViewRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewRentals As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents ButtonDeleteSelectedItem As System.Windows.Forms.Button
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTrash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRecycle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCardboard As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRollOff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMiscCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
