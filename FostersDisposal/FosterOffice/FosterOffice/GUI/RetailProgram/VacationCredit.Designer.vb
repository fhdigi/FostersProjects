<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VacationCreditForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerVacEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerVacStart = New System.Windows.Forms.DateTimePicker()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vacation Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vacation End Date"
        '
        'DateTimePickerVacEnd
        '
        Me.DateTimePickerVacEnd.Location = New System.Drawing.Point(118, 95)
        Me.DateTimePickerVacEnd.Name = "DateTimePickerVacEnd"
        Me.DateTimePickerVacEnd.Size = New System.Drawing.Size(185, 21)
        Me.DateTimePickerVacEnd.TabIndex = 3
        '
        'DateTimePickerVacStart
        '
        Me.DateTimePickerVacStart.Location = New System.Drawing.Point(118, 55)
        Me.DateTimePickerVacStart.Name = "DateTimePickerVacStart"
        Me.DateTimePickerVacStart.Size = New System.Drawing.Size(185, 21)
        Me.DateTimePickerVacStart.TabIndex = 1
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(227, 140)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(146, 140)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.ForeColor = System.Drawing.Color.Blue
        Me.LabelCustomerName.Location = New System.Drawing.Point(18, 13)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(53, 16)
        Me.LabelCustomerName.TabIndex = 6
        Me.LabelCustomerName.Text = "#####"
        '
        'VacationCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 175)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.DateTimePickerVacStart)
        Me.Controls.Add(Me.DateTimePickerVacEnd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VacationCredit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacation Credit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerVacEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerVacStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
End Class
