<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomerRecord
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
        Me.PropertyGridCustomer = New System.Windows.Forms.PropertyGrid()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PropertyGridCustomer
        '
        Me.PropertyGridCustomer.Location = New System.Drawing.Point(12, 50)
        Me.PropertyGridCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PropertyGridCustomer.Name = "PropertyGridCustomer"
        Me.PropertyGridCustomer.Size = New System.Drawing.Size(372, 530)
        Me.PropertyGridCustomer.TabIndex = 5
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.Location = New System.Drawing.Point(12, 20)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(48, 17)
        Me.LabelCustomerName.TabIndex = 6
        Me.LabelCustomerName.Text = "Label1"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(410, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 25)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'EditCustomerRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 593)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.PropertyGridCustomer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditCustomerRecord"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Customer Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PropertyGridCustomer As System.Windows.Forms.PropertyGrid
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
End Class
