<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerListing
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
        Me.ListBoxCustomers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGoto = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxCustomers
        '
        Me.ListBoxCustomers.FormattingEnabled = True
        Me.ListBoxCustomers.ItemHeight = 42
        Me.ListBoxCustomers.Location = New System.Drawing.Point(12, 61)
        Me.ListBoxCustomers.Name = "ListBoxCustomers"
        Me.ListBoxCustomers.Size = New System.Drawing.Size(567, 508)
        Me.ListBoxCustomers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Customer"
        '
        'ButtonGoto
        '
        Me.ButtonGoto.Location = New System.Drawing.Point(592, 12)
        Me.ButtonGoto.Name = "ButtonGoto"
        Me.ButtonGoto.Size = New System.Drawing.Size(190, 51)
        Me.ButtonGoto.TabIndex = 2
        Me.ButtonGoto.Text = "Go To"
        Me.ButtonGoto.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(592, 88)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(190, 51)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'CustomerListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 42.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 580)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonGoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxCustomers)
        Me.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerListing"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CustomerListing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxCustomers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonGoto As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
