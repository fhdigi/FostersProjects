<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Me.DataGridViewBilling = New System.Windows.Forms.DataGridView()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.DateTimePickerBillingDate = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonShowBiMonthly = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Date"
        '
        'DataGridViewBilling
        '
        Me.DataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBilling.Location = New System.Drawing.Point(15, 121)
        Me.DataGridViewBilling.Name = "DataGridViewBilling"
        Me.DataGridViewBilling.Size = New System.Drawing.Size(592, 281)
        Me.DataGridViewBilling.TabIndex = 3
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(531, 417)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'DateTimePickerBillingDate
        '
        Me.DateTimePickerBillingDate.Location = New System.Drawing.Point(77, 12)
        Me.DateTimePickerBillingDate.Name = "DateTimePickerBillingDate"
        Me.DateTimePickerBillingDate.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerBillingDate.TabIndex = 5
        '
        'RadioButtonShowBiMonthly
        '
        Me.RadioButtonShowBiMonthly.AutoSize = True
        Me.RadioButtonShowBiMonthly.Checked = True
        Me.RadioButtonShowBiMonthly.Location = New System.Drawing.Point(15, 82)
        Me.RadioButtonShowBiMonthly.Name = "RadioButtonShowBiMonthly"
        Me.RadioButtonShowBiMonthly.Size = New System.Drawing.Size(213, 17)
        Me.RadioButtonShowBiMonthly.TabIndex = 6
        Me.RadioButtonShowBiMonthly.Text = "Show Bi-Monthly Customers to be Billed"
        Me.RadioButtonShowBiMonthly.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 59)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(201, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "Show Monthly Customers to be Billed"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(531, 92)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 8
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 452)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButtonShowBiMonthly)
        Me.Controls.Add(Me.DateTimePickerBillingDate)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.DataGridViewBilling)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Billing Form"
        CType(Me.DataGridViewBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewBilling As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerBillingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButtonShowBiMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
End Class
