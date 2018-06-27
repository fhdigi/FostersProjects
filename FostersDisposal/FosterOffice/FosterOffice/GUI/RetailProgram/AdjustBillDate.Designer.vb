<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustBillDate
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
        Me.DateTimePickerNewDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.ButtonAdjust = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'DateTimePickerNewDate
        '
        Me.DateTimePickerNewDate.Location = New System.Drawing.Point(119, 71)
        Me.DateTimePickerNewDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerNewDate.Name = "DateTimePickerNewDate"
        Me.DateTimePickerNewDate.Size = New System.Drawing.Size(233, 23)
        Me.DateTimePickerNewDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(17, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Bill Date : "
        '
        'LabelMessage
        '
        Me.LabelMessage.AutoSize = true
        Me.LabelMessage.Location = New System.Drawing.Point(17, 32)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(113, 16)
        Me.LabelMessage.TabIndex = 2
        Me.LabelMessage.Text = "Current bill date : "
        '
        'ButtonAdjust
        '
        Me.ButtonAdjust.Location = New System.Drawing.Point(196, 119)
        Me.ButtonAdjust.Name = "ButtonAdjust"
        Me.ButtonAdjust.Size = New System.Drawing.Size(75, 30)
        Me.ButtonAdjust.TabIndex = 3
        Me.ButtonAdjust.Text = "Adjust"
        Me.ButtonAdjust.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(277, 119)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 30)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'AdjustBillDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 168)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAdjust)
        Me.Controls.Add(Me.LabelMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerNewDate)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "AdjustBillDate"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjust Bill Date"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DateTimePickerNewDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMessage As Label
    Friend WithEvents ButtonAdjust As Button
    Friend WithEvents ButtonCancel As Button
End Class
