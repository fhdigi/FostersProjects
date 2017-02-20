<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRentalBills
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
        Me.ListViewBills = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chBillingDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewBills
        '
        Me.ListViewBills.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chBillingDate, Me.chAmount})
        Me.ListViewBills.FullRowSelect = True
        Me.ListViewBills.Location = New System.Drawing.Point(12, 44)
        Me.ListViewBills.Name = "ListViewBills"
        Me.ListViewBills.Size = New System.Drawing.Size(220, 296)
        Me.ListViewBills.TabIndex = 0
        Me.ListViewBills.UseCompatibleStateImageBehavior = False
        Me.ListViewBills.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Bills"
        '
        'chBillingDate
        '
        Me.chBillingDate.Text = "Billing Date"
        Me.chBillingDate.Width = 100
        '
        'chAmount
        '
        Me.chAmount.Text = "Amount"
        Me.chAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chAmount.Width = 100
        '
        'ButtonView
        '
        Me.ButtonView.Location = New System.Drawing.Point(264, 12)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(75, 23)
        Me.ButtonView.TabIndex = 2
        Me.ButtonView.Text = "View"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(264, 41)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ViewRentalBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 352)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewBills)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewRentalBills"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Rental Bills"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewBills As System.Windows.Forms.ListView
    Friend WithEvents chBillingDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonView As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
End Class
