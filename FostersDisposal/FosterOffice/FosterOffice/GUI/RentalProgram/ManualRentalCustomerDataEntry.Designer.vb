<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualRentalCustomerDataEntry
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
        Me.ComboBoxCustomerList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickupDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTrash = New System.Windows.Forms.TextBox()
        Me.TextBoxRecycle = New System.Windows.Forms.TextBox()
        Me.TextBoxCardBoard = New System.Windows.Forms.TextBox()
        Me.TextBoxCart = New System.Windows.Forms.TextBox()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSaveAndNew = New System.Windows.Forms.Button()
        Me.ButtonSaveAndClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxRollOff = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxMiscCharge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer"
        '
        'ComboBoxCustomerList
        '
        Me.ComboBoxCustomerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxCustomerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCustomerList.FormattingEnabled = True
        Me.ComboBoxCustomerList.Location = New System.Drawing.Point(76, 12)
        Me.ComboBoxCustomerList.Name = "ComboBoxCustomerList"
        Me.ComboBoxCustomerList.Size = New System.Drawing.Size(422, 21)
        Me.ComboBoxCustomerList.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'DateTimePickupDate
        '
        Me.DateTimePickupDate.Location = New System.Drawing.Point(76, 47)
        Me.DateTimePickupDate.Name = "DateTimePickupDate"
        Me.DateTimePickupDate.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickupDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(76, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Trash"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(140, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Recycle"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(204, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cardboard"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(268, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cart"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(460, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Notes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxTrash
        '
        Me.TextBoxTrash.Location = New System.Drawing.Point(76, 102)
        Me.TextBoxTrash.Name = "TextBoxTrash"
        Me.TextBoxTrash.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxTrash.TabIndex = 5
        Me.TextBoxTrash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRecycle
        '
        Me.TextBoxRecycle.Location = New System.Drawing.Point(140, 102)
        Me.TextBoxRecycle.Name = "TextBoxRecycle"
        Me.TextBoxRecycle.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxRecycle.TabIndex = 7
        Me.TextBoxRecycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxCardBoard
        '
        Me.TextBoxCardBoard.Location = New System.Drawing.Point(204, 102)
        Me.TextBoxCardBoard.Name = "TextBoxCardBoard"
        Me.TextBoxCardBoard.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxCardBoard.TabIndex = 9
        Me.TextBoxCardBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxCart
        '
        Me.TextBoxCart.Location = New System.Drawing.Point(268, 102)
        Me.TextBoxCart.Name = "TextBoxCart"
        Me.TextBoxCart.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxCart.TabIndex = 11
        Me.TextBoxCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Location = New System.Drawing.Point(460, 102)
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(163, 21)
        Me.TextBoxNotes.TabIndex = 17
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(500, 151)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(122, 23)
        Me.ButtonCancel.TabIndex = 20
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSaveAndNew
        '
        Me.ButtonSaveAndNew.Location = New System.Drawing.Point(372, 151)
        Me.ButtonSaveAndNew.Name = "ButtonSaveAndNew"
        Me.ButtonSaveAndNew.Size = New System.Drawing.Size(122, 23)
        Me.ButtonSaveAndNew.TabIndex = 19
        Me.ButtonSaveAndNew.Text = "Save and New"
        Me.ButtonSaveAndNew.UseVisualStyleBackColor = True
        '
        'ButtonSaveAndClose
        '
        Me.ButtonSaveAndClose.Location = New System.Drawing.Point(244, 151)
        Me.ButtonSaveAndClose.Name = "ButtonSaveAndClose"
        Me.ButtonSaveAndClose.Size = New System.Drawing.Size(122, 23)
        Me.ButtonSaveAndClose.TabIndex = 18
        Me.ButtonSaveAndClose.Text = "Save and Close"
        Me.ButtonSaveAndClose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(332, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Roll Off"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxRollOff
        '
        Me.TextBoxRollOff.Location = New System.Drawing.Point(332, 102)
        Me.TextBoxRollOff.Name = "TextBoxRollOff"
        Me.TextBoxRollOff.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxRollOff.TabIndex = 13
        Me.TextBoxRollOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(396, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Misc Chg"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxMiscCharge
        '
        Me.TextBoxMiscCharge.Location = New System.Drawing.Point(396, 102)
        Me.TextBoxMiscCharge.Name = "TextBoxMiscCharge"
        Me.TextBoxMiscCharge.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxMiscCharge.TabIndex = 15
        Me.TextBoxMiscCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ManualRentalCustomerDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 186)
        Me.Controls.Add(Me.ButtonSaveAndClose)
        Me.Controls.Add(Me.ButtonSaveAndNew)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.TextBoxMiscCharge)
        Me.Controls.Add(Me.TextBoxRollOff)
        Me.Controls.Add(Me.TextBoxCart)
        Me.Controls.Add(Me.TextBoxRecycle)
        Me.Controls.Add(Me.TextBoxNotes)
        Me.Controls.Add(Me.TextBoxCardBoard)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxTrash)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePickupDate)
        Me.Controls.Add(Me.ComboBoxCustomerList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManualRentalCustomerDataEntry"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Customer Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCustomerList As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickupDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTrash As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecycle As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCardBoard As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCart As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveAndNew As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveAndClose As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRollOff As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMiscCharge As System.Windows.Forms.TextBox
End Class
