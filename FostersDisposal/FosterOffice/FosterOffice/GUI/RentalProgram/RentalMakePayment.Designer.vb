<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalMakePayment
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
        Me.ButtonPrintReceipt = New System.Windows.Forms.Button()
        Me.LabelCollectionMessage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxCcAuthorization = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
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
        Me.ComboBoxCustomerNumber.FormattingEnabled = true
        Me.ComboBoxCustomerNumber.Location = New System.Drawing.Point(111, 16)
        Me.ComboBoxCustomerNumber.Name = "ComboBoxCustomerNumber"
        Me.ComboBoxCustomerNumber.Size = New System.Drawing.Size(260, 21)
        Me.ComboBoxCustomerNumber.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(377, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payment Date"
        '
        'DateTimePickerPaymentDate
        '
        Me.DateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPaymentDate.Location = New System.Drawing.Point(458, 15)
        Me.DateTimePickerPaymentDate.Name = "DateTimePickerPaymentDate"
        Me.DateTimePickerPaymentDate.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePickerPaymentDate.TabIndex = 3
        Me.DateTimePickerPaymentDate.TabStop = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(16, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Payment Amount"
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
        Me.ButtonSave.Enabled = false
        Me.ButtonSave.Location = New System.Drawing.Point(398, 158)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 16
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(479, 158)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(190, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Method of Payment"
        '
        'ComboBoxMOP
        '
        Me.ComboBoxMOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMOP.FormattingEnabled = true
        Me.ComboBoxMOP.Items.AddRange(New Object() {"Cash", "Check", "Money Order", "Other", "Credit Card"})
        Me.ComboBoxMOP.Location = New System.Drawing.Point(297, 54)
        Me.ComboBoxMOP.Name = "ComboBoxMOP"
        Me.ComboBoxMOP.Size = New System.Drawing.Size(97, 21)
        Me.ComboBoxMOP.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(400, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Check Number"
        '
        'TextBoxCheckNumber
        '
        Me.TextBoxCheckNumber.Location = New System.Drawing.Point(481, 54)
        Me.TextBoxCheckNumber.Name = "TextBoxCheckNumber"
        Me.TextBoxCheckNumber.Size = New System.Drawing.Size(73, 21)
        Me.TextBoxCheckNumber.TabIndex = 9
        '
        'TimerPayment
        '
        Me.TimerPayment.Enabled = true
        Me.TimerPayment.Interval = 500
        '
        'ButtonPrintReceipt
        '
        Me.ButtonPrintReceipt.Location = New System.Drawing.Point(15, 97)
        Me.ButtonPrintReceipt.Name = "ButtonPrintReceipt"
        Me.ButtonPrintReceipt.Size = New System.Drawing.Size(108, 23)
        Me.ButtonPrintReceipt.TabIndex = 14
        Me.ButtonPrintReceipt.Text = "Print Receipt..."
        Me.ButtonPrintReceipt.UseVisualStyleBackColor = true
        Me.ButtonPrintReceipt.Visible = false
        '
        'LabelCollectionMessage
        '
        Me.LabelCollectionMessage.AutoSize = true
        Me.LabelCollectionMessage.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelCollectionMessage.Location = New System.Drawing.Point(15, 125)
        Me.LabelCollectionMessage.Name = "LabelCollectionMessage"
        Me.LabelCollectionMessage.Size = New System.Drawing.Size(0, 23)
        Me.LabelCollectionMessage.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(401, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Description"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Enabled = false
        Me.TextBoxDescription.Location = New System.Drawing.Point(404, 107)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(150, 21)
        Me.TextBoxDescription.TabIndex = 11
        '
        'TextBoxCcAuthorization
        '
        Me.TextBoxCcAuthorization.Enabled = false
        Me.TextBoxCcAuthorization.Location = New System.Drawing.Point(297, 107)
        Me.TextBoxCcAuthorization.Name = "TextBoxCcAuthorization"
        Me.TextBoxCcAuthorization.Size = New System.Drawing.Size(101, 21)
        Me.TextBoxCcAuthorization.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(294, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CC Authorization #"
        '
        'RentalMakePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 191)
        Me.Controls.Add(Me.TextBoxCcAuthorization)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelCollectionMessage)
        Me.Controls.Add(Me.ButtonPrintReceipt)
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
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "RentalMakePayment"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rental Program - Receive Payment"
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents ButtonPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents LabelCollectionMessage As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCcAuthorization As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
