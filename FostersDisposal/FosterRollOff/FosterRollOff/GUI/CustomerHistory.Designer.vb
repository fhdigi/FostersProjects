<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerHistory
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
        Me.DataGridViewHistory = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        CType(Me.DataGridViewHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewHistory
        '
        Me.DataGridViewHistory.AllowUserToAddRows = False
        Me.DataGridViewHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colDescription, Me.colCredit, Me.colDebit, Me.colTotal})
        Me.DataGridViewHistory.Location = New System.Drawing.Point(14, 73)
        Me.DataGridViewHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewHistory.Name = "DataGridViewHistory"
        Me.DataGridViewHistory.ReadOnly = True
        Me.DataGridViewHistory.Size = New System.Drawing.Size(729, 405)
        Me.DataGridViewHistory.TabIndex = 0
        '
        'colDate
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        '
        'colCredit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.Width = 80
        '
        'colDebit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.Width = 80
        '
        'colTotal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Width = 80
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.Blue
        Me.LabelHeader.Location = New System.Drawing.Point(14, 29)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(183, 19)
        Me.LabelHeader.TabIndex = 1
        Me.LabelHeader.Text = "{Customer Charges }"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(763, 17)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(87, 30)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Image = Global.FosterRollOff.My.Resources.Resources.Print
        Me.ButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrint.Location = New System.Drawing.Point(763, 55)
        Me.ButtonPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(87, 30)
        Me.ButtonPrint.TabIndex = 3
        Me.ButtonPrint.Text = "Print..."
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'CustomerHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 494)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.DataGridViewHistory)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerHistory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer History"
        CType(Me.DataGridViewHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewHistory As System.Windows.Forms.DataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
End Class
