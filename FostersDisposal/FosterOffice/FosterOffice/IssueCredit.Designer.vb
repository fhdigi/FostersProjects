<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueCredit
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCustomerNumber = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPaymentAmount = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxMOP = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCheckNumber = New System.Windows.Forms.TextBox()
        Me.TimerPayment = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Number"
        '
        'ComboBoxCustomerNumber
        '
        Me.ComboBoxCustomerNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxCustomerNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCustomerNumber.FormattingEnabled = True
        Me.ComboBoxCustomerNumber.Location = New System.Drawing.Point(111, 16)
        Me.ComboBoxCustomerNumber.Name = "ComboBoxCustomerNumber"
        Me.ComboBoxCustomerNumber.Size = New System.Drawing.Size(260, 21)
        Me.ComboBoxCustomerNumber.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(439, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Credit Date"
        '
        'DateTimePickerPaymentDate
        '
        Me.DateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPaymentDate.Location = New System.Drawing.Point(507, 13)
        Me.DateTimePickerPaymentDate.Name = "DateTimePickerPaymentDate"
        Me.DateTimePickerPaymentDate.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePickerPaymentDate.TabIndex = 3
        Me.DateTimePickerPaymentDate.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Credit Amount"
        '
        'TextBoxPaymentAmount
        '
        Me.TextBoxPaymentAmount.Location = New System.Drawing.Point(111, 54)
        Me.TextBoxPaymentAmount.Name = "TextBoxPaymentAmount"
        Me.TextBoxPaymentAmount.Size = New System.Drawing.Size(73, 21)
        Me.TextBoxPaymentAmount.TabIndex = 5
        '
        'ButtonSave
        '
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.Location = New System.Drawing.Point(447, 104)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 10
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(528, 104)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 11
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Credit Method"
        '
        'ComboBoxMOP
        '
        Me.ComboBoxMOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMOP.FormattingEnabled = True
        Me.ComboBoxMOP.Items.AddRange(New Object() {"Cash", "Check", "Money Order", "Other"})
        Me.ComboBoxMOP.Location = New System.Drawing.Point(271, 54)
        Me.ComboBoxMOP.Name = "ComboBoxMOP"
        Me.ComboBoxMOP.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMOP.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Company Check Number"
        '
        'TextBoxCheckNumber
        '
        Me.TextBoxCheckNumber.Location = New System.Drawing.Point(507, 54)
        Me.TextBoxCheckNumber.Name = "TextBoxCheckNumber"
        Me.TextBoxCheckNumber.Size = New System.Drawing.Size(96, 21)
        Me.TextBoxCheckNumber.TabIndex = 9
        '
        'TimerPayment
        '
        Me.TimerPayment.Enabled = True
        Me.TimerPayment.Interval = 500
        '
        'IssueCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 139)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxCheckNumber)
        Me.Controls.Add(Me.TextBoxPaymentAmount)
        Me.Controls.Add(Me.DateTimePickerPaymentDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxMOP)
        Me.Controls.Add(Me.ComboBoxCustomerNumber)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IssueCredit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Issue Credit to Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCustomerNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPaymentAmount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMOP As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents TimerPayment As System.Windows.Forms.Timer
End Class
