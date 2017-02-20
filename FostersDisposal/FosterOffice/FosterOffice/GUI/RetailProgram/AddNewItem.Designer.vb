<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewItem
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
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.DateTimePickerEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxGarbageBags = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.RadioButtonGarbageBag = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAdditionalItem = New System.Windows.Forms.RadioButton()
        Me.ComboBoxAdditionalItems = New System.Windows.Forms.ComboBox()
        Me.TextBoxItemPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelCustomer
        '
        Me.LabelCustomer.AutoSize = True
        Me.LabelCustomer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomer.ForeColor = System.Drawing.Color.Blue
        Me.LabelCustomer.Location = New System.Drawing.Point(23, 9)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(131, 19)
        Me.LabelCustomer.TabIndex = 0
        Me.LabelCustomer.Text = "LabelCustomer"
        '
        'DateTimePickerEntryDate
        '
        Me.DateTimePickerEntryDate.Location = New System.Drawing.Point(63, 47)
        Me.DateTimePickerEntryDate.Name = "DateTimePickerEntryDate"
        Me.DateTimePickerEntryDate.Size = New System.Drawing.Size(227, 21)
        Me.DateTimePickerEntryDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'TextBoxGarbageBags
        '
        Me.TextBoxGarbageBags.Location = New System.Drawing.Point(136, 85)
        Me.TextBoxGarbageBags.Name = "TextBoxGarbageBags"
        Me.TextBoxGarbageBags.Size = New System.Drawing.Size(51, 21)
        Me.TextBoxGarbageBags.TabIndex = 4
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(146, 188)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(227, 188)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 9
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'RadioButtonGarbageBag
        '
        Me.RadioButtonGarbageBag.AutoSize = True
        Me.RadioButtonGarbageBag.Location = New System.Drawing.Point(30, 85)
        Me.RadioButtonGarbageBag.Name = "RadioButtonGarbageBag"
        Me.RadioButtonGarbageBag.Size = New System.Drawing.Size(100, 17)
        Me.RadioButtonGarbageBag.TabIndex = 3
        Me.RadioButtonGarbageBag.TabStop = True
        Me.RadioButtonGarbageBag.Text = "Garbage Bag(s)"
        Me.RadioButtonGarbageBag.UseVisualStyleBackColor = True
        '
        'RadioButtonAdditionalItem
        '
        Me.RadioButtonAdditionalItem.AutoSize = True
        Me.RadioButtonAdditionalItem.Location = New System.Drawing.Point(30, 114)
        Me.RadioButtonAdditionalItem.Name = "RadioButtonAdditionalItem"
        Me.RadioButtonAdditionalItem.Size = New System.Drawing.Size(97, 17)
        Me.RadioButtonAdditionalItem.TabIndex = 5
        Me.RadioButtonAdditionalItem.TabStop = True
        Me.RadioButtonAdditionalItem.Text = "Additional Item"
        Me.RadioButtonAdditionalItem.UseVisualStyleBackColor = True
        '
        'ComboBoxAdditionalItems
        '
        Me.ComboBoxAdditionalItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdditionalItems.FormattingEnabled = True
        Me.ComboBoxAdditionalItems.Location = New System.Drawing.Point(51, 137)
        Me.ComboBoxAdditionalItems.Name = "ComboBoxAdditionalItems"
        Me.ComboBoxAdditionalItems.Size = New System.Drawing.Size(170, 21)
        Me.ComboBoxAdditionalItems.TabIndex = 6
        '
        'TextBoxItemPrice
        '
        Me.TextBoxItemPrice.Location = New System.Drawing.Point(236, 137)
        Me.TextBoxItemPrice.Name = "TextBoxItemPrice"
        Me.TextBoxItemPrice.Size = New System.Drawing.Size(66, 21)
        Me.TextBoxItemPrice.TabIndex = 7
        '
        'AddNewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 222)
        Me.Controls.Add(Me.TextBoxItemPrice)
        Me.Controls.Add(Me.ComboBoxAdditionalItems)
        Me.Controls.Add(Me.RadioButtonAdditionalItem)
        Me.Controls.Add(Me.RadioButtonGarbageBag)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxGarbageBags)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerEntryDate)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCustomer As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEntryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGarbageBags As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents RadioButtonGarbageBag As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAdditionalItem As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxAdditionalItems As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxItemPrice As System.Windows.Forms.TextBox
End Class
