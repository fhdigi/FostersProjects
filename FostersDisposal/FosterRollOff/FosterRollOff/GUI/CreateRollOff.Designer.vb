<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateRollOffForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerDropOffDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDailyRate = New System.Windows.Forms.TextBox()
        Me.TextBoxRentalFee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMonthly = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDaily = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDumpingFee = New System.Windows.Forms.TextBox()
        Me.ComboBoxRollOffFees = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSize = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TabControlRollOff = New System.Windows.Forms.TabControl()
        Me.TabPageDelivered = New System.Windows.Forms.TabPage()
        Me.LabelBillingAddress = New System.Windows.Forms.Label()
        Me.LabelServiceAddress = New System.Windows.Forms.Label()
        Me.LabelAccount = New System.Windows.Forms.Label()
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonDeactivate = New System.Windows.Forms.Button()
        Me.CheckBoxRollOffPickedUp = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerRollOffPickedUp = New System.Windows.Forms.DateTimePicker()
        Me.TabPageBilling = New System.Windows.Forms.TabPage()
        Me.ButtonRefreshList = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonViewBill = New System.Windows.Forms.Button()
        Me.ListViewBills = New System.Windows.Forms.ListView()
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.chAmount = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerRollOff = New System.Windows.Forms.Timer(Me.components)
        Me.LabelSpecialBill = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.TabControlRollOff.SuspendLayout
        Me.TabPageDelivered.SuspendLayout
        Me.TabPageBilling.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(28, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date Roll Off Delivered"
        '
        'DateTimePickerDropOffDate
        '
        Me.DateTimePickerDropOffDate.Location = New System.Drawing.Point(31, 152)
        Me.DateTimePickerDropOffDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerDropOffDate.Name = "DateTimePickerDropOffDate"
        Me.DateTimePickerDropOffDate.Size = New System.Drawing.Size(242, 25)
        Me.DateTimePickerDropOffDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(91, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rental Rate"
        '
        'TextBoxDailyRate
        '
        Me.TextBoxDailyRate.Location = New System.Drawing.Point(173, 133)
        Me.TextBoxDailyRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDailyRate.Name = "TextBoxDailyRate"
        Me.TextBoxDailyRate.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxDailyRate.TabIndex = 6
        '
        'TextBoxRentalFee
        '
        Me.TextBoxRentalFee.Location = New System.Drawing.Point(173, 98)
        Me.TextBoxRentalFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRentalFee.Name = "TextBoxRentalFee"
        Me.TextBoxRentalFee.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxRentalFee.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Service Charge (per haul)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonMonthly)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDaily)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxDumpingFee)
        Me.GroupBox1.Controls.Add(Me.ComboBoxRollOffFees)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxSize)
        Me.GroupBox1.Controls.Add(Me.TextBoxRentalFee)
        Me.GroupBox1.Controls.Add(Me.TextBoxDailyRate)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 220)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(272, 243)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Fees"
        '
        'RadioButtonMonthly
        '
        Me.RadioButtonMonthly.AutoSize = true
        Me.RadioButtonMonthly.Location = New System.Drawing.Point(180, 169)
        Me.RadioButtonMonthly.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonMonthly.Name = "RadioButtonMonthly"
        Me.RadioButtonMonthly.Size = New System.Drawing.Size(73, 21)
        Me.RadioButtonMonthly.TabIndex = 8
        Me.RadioButtonMonthly.TabStop = true
        Me.RadioButtonMonthly.Text = "Monthly"
        Me.RadioButtonMonthly.UseVisualStyleBackColor = true
        '
        'RadioButtonDaily
        '
        Me.RadioButtonDaily.AutoSize = true
        Me.RadioButtonDaily.Location = New System.Drawing.Point(117, 169)
        Me.RadioButtonDaily.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonDaily.Name = "RadioButtonDaily"
        Me.RadioButtonDaily.Size = New System.Drawing.Size(54, 21)
        Me.RadioButtonDaily.TabIndex = 7
        Me.RadioButtonDaily.TabStop = true
        Me.RadioButtonDaily.Text = "Daily"
        Me.RadioButtonDaily.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(31, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Dumping Fee (per ton)"
        '
        'TextBoxDumpingFee
        '
        Me.TextBoxDumpingFee.Location = New System.Drawing.Point(173, 199)
        Me.TextBoxDumpingFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDumpingFee.Name = "TextBoxDumpingFee"
        Me.TextBoxDumpingFee.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxDumpingFee.TabIndex = 10
        '
        'ComboBoxRollOffFees
        '
        Me.ComboBoxRollOffFees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRollOffFees.FormattingEnabled = true
        Me.ComboBoxRollOffFees.Location = New System.Drawing.Point(63, 27)
        Me.ComboBoxRollOffFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxRollOffFees.Name = "ComboBoxRollOffFees"
        Me.ComboBoxRollOffFees.Size = New System.Drawing.Size(181, 25)
        Me.ComboBoxRollOffFees.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(135, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Size"
        '
        'TextBoxSize
        '
        Me.TextBoxSize.Location = New System.Drawing.Point(173, 63)
        Me.TextBoxSize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxSize.Name = "TextBoxSize"
        Me.TextBoxSize.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxSize.TabIndex = 2
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Image = Global.FosterRollOff.My.Resources.Resources.Save
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(687, 16)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(100, 30)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(687, 54)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(100, 30)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.Enabled = false
        Me.ButtonDelete.Image = Global.FosterRollOff.My.Resources.Resources.Delete
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(396, 40)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(233, 30)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Delete Roll from Database"
        Me.ButtonDelete.UseVisualStyleBackColor = true
        '
        'TabControlRollOff
        '
        Me.TabControlRollOff.Controls.Add(Me.TabPageDelivered)
        Me.TabControlRollOff.Controls.Add(Me.TabPageBilling)
        Me.TabControlRollOff.Controls.Add(Me.TabPage1)
        Me.TabControlRollOff.Location = New System.Drawing.Point(14, 16)
        Me.TabControlRollOff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControlRollOff.Name = "TabControlRollOff"
        Me.TabControlRollOff.SelectedIndex = 0
        Me.TabControlRollOff.Size = New System.Drawing.Size(650, 552)
        Me.TabControlRollOff.TabIndex = 1
        '
        'TabPageDelivered
        '
        Me.TabPageDelivered.Controls.Add(Me.LabelSpecialBill)
        Me.TabPageDelivered.Controls.Add(Me.LabelBillingAddress)
        Me.TabPageDelivered.Controls.Add(Me.LabelServiceAddress)
        Me.TabPageDelivered.Controls.Add(Me.LabelAccount)
        Me.TabPageDelivered.Controls.Add(Me.LabelCustomer)
        Me.TabPageDelivered.Controls.Add(Me.Label10)
        Me.TabPageDelivered.Controls.Add(Me.TextBoxNotes)
        Me.TabPageDelivered.Controls.Add(Me.Label8)
        Me.TabPageDelivered.Controls.Add(Me.ButtonDeactivate)
        Me.TabPageDelivered.Controls.Add(Me.CheckBoxRollOffPickedUp)
        Me.TabPageDelivered.Controls.Add(Me.Label7)
        Me.TabPageDelivered.Controls.Add(Me.DateTimePickerRollOffPickedUp)
        Me.TabPageDelivered.Controls.Add(Me.Label2)
        Me.TabPageDelivered.Controls.Add(Me.GroupBox1)
        Me.TabPageDelivered.Controls.Add(Me.DateTimePickerDropOffDate)
        Me.TabPageDelivered.Location = New System.Drawing.Point(4, 26)
        Me.TabPageDelivered.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageDelivered.Name = "TabPageDelivered"
        Me.TabPageDelivered.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageDelivered.Size = New System.Drawing.Size(642, 522)
        Me.TabPageDelivered.TabIndex = 0
        Me.TabPageDelivered.Text = "Delivered / Picked Up"
        Me.TabPageDelivered.UseVisualStyleBackColor = true
        '
        'LabelBillingAddress
        '
        Me.LabelBillingAddress.AutoSize = true
        Me.LabelBillingAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelBillingAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelBillingAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelBillingAddress.Location = New System.Drawing.Point(28, 92)
        Me.LabelBillingAddress.Name = "LabelBillingAddress"
        Me.LabelBillingAddress.Size = New System.Drawing.Size(55, 17)
        Me.LabelBillingAddress.TabIndex = 13
        Me.LabelBillingAddress.Text = "Label11"
        '
        'LabelServiceAddress
        '
        Me.LabelServiceAddress.AutoSize = true
        Me.LabelServiceAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelServiceAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelServiceAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelServiceAddress.Location = New System.Drawing.Point(28, 50)
        Me.LabelServiceAddress.Name = "LabelServiceAddress"
        Me.LabelServiceAddress.Size = New System.Drawing.Size(55, 17)
        Me.LabelServiceAddress.TabIndex = 12
        Me.LabelServiceAddress.Text = "Label11"
        '
        'LabelAccount
        '
        Me.LabelAccount.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelAccount.ForeColor = System.Drawing.Color.Red
        Me.LabelAccount.Location = New System.Drawing.Point(373, 21)
        Me.LabelAccount.Name = "LabelAccount"
        Me.LabelAccount.Size = New System.Drawing.Size(218, 29)
        Me.LabelAccount.TabIndex = 11
        Me.LabelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCustomer
        '
        Me.LabelCustomer.AutoSize = true
        Me.LabelCustomer.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelCustomer.ForeColor = System.Drawing.Color.Blue
        Me.LabelCustomer.Location = New System.Drawing.Point(28, 16)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(69, 21)
        Me.LabelCustomer.TabIndex = 10
        Me.LabelCustomer.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(355, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Notes"
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNotes.Location = New System.Drawing.Point(357, 247)
        Me.TextBoxNotes.Multiline = true
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(234, 102)
        Me.TextBoxNotes.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(354, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 98)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Press the button below to deactivate this rolloff.  This is typically done when t"& _ 
    "he roll off has been returned to Foster's Disposal  and any outstanding money ha"& _ 
    "s been paid."
        '
        'ButtonDeactivate
        '
        Me.ButtonDeactivate.Location = New System.Drawing.Point(358, 470)
        Me.ButtonDeactivate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDeactivate.Name = "ButtonDeactivate"
        Me.ButtonDeactivate.Size = New System.Drawing.Size(233, 30)
        Me.ButtonDeactivate.TabIndex = 9
        Me.ButtonDeactivate.Text = "Deactivate Roll Off"
        Me.ButtonDeactivate.UseVisualStyleBackColor = true
        '
        'CheckBoxRollOffPickedUp
        '
        Me.CheckBoxRollOffPickedUp.AutoSize = true
        Me.CheckBoxRollOffPickedUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxRollOffPickedUp.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxRollOffPickedUp.Location = New System.Drawing.Point(358, 125)
        Me.CheckBoxRollOffPickedUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxRollOffPickedUp.Name = "CheckBoxRollOffPickedUp"
        Me.CheckBoxRollOffPickedUp.Size = New System.Drawing.Size(178, 17)
        Me.CheckBoxRollOffPickedUp.TabIndex = 5
        Me.CheckBoxRollOffPickedUp.Text = "Roll Off has been Picked Up"
        Me.CheckBoxRollOffPickedUp.UseVisualStyleBackColor = true
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(354, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date Roll Off Picked Up from Customer"
        '
        'DateTimePickerRollOffPickedUp
        '
        Me.DateTimePickerRollOffPickedUp.Enabled = false
        Me.DateTimePickerRollOffPickedUp.Location = New System.Drawing.Point(358, 184)
        Me.DateTimePickerRollOffPickedUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerRollOffPickedUp.Name = "DateTimePickerRollOffPickedUp"
        Me.DateTimePickerRollOffPickedUp.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePickerRollOffPickedUp.TabIndex = 7
        '
        'TabPageBilling
        '
        Me.TabPageBilling.Controls.Add(Me.ButtonRefreshList)
        Me.TabPageBilling.Controls.Add(Me.Label9)
        Me.TabPageBilling.Controls.Add(Me.ButtonViewBill)
        Me.TabPageBilling.Controls.Add(Me.ListViewBills)
        Me.TabPageBilling.Location = New System.Drawing.Point(4, 26)
        Me.TabPageBilling.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageBilling.Name = "TabPageBilling"
        Me.TabPageBilling.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageBilling.Size = New System.Drawing.Size(642, 522)
        Me.TabPageBilling.TabIndex = 2
        Me.TabPageBilling.Text = "Billing History"
        Me.TabPageBilling.UseVisualStyleBackColor = true
        '
        'ButtonRefreshList
        '
        Me.ButtonRefreshList.Image = Global.FosterRollOff.My.Resources.Resources.Refresh_All
        Me.ButtonRefreshList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshList.Location = New System.Drawing.Point(427, 88)
        Me.ButtonRefreshList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRefreshList.Name = "ButtonRefreshList"
        Me.ButtonRefreshList.Size = New System.Drawing.Size(197, 30)
        Me.ButtonRefreshList.TabIndex = 3
        Me.ButtonRefreshList.Text = "Refresh List"
        Me.ButtonRefreshList.UseVisualStyleBackColor = true
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Billing History"
        '
        'ButtonViewBill
        '
        Me.ButtonViewBill.Location = New System.Drawing.Point(427, 50)
        Me.ButtonViewBill.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonViewBill.Name = "ButtonViewBill"
        Me.ButtonViewBill.Size = New System.Drawing.Size(197, 30)
        Me.ButtonViewBill.TabIndex = 1
        Me.ButtonViewBill.Text = "View Highlighted Bill..."
        Me.ButtonViewBill.UseVisualStyleBackColor = true
        '
        'ListViewBills
        '
        Me.ListViewBills.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chDate, Me.chAmount})
        Me.ListViewBills.FullRowSelect = true
        Me.ListViewBills.Location = New System.Drawing.Point(7, 50)
        Me.ListViewBills.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewBills.Name = "ListViewBills"
        Me.ListViewBills.Size = New System.Drawing.Size(402, 399)
        Me.ListViewBills.TabIndex = 0
        Me.ListViewBills.UseCompatibleStateImageBehavior = false
        Me.ListViewBills.View = System.Windows.Forms.View.Details
        '
        'chDate
        '
        Me.chDate.Text = "Bill Date"
        Me.chDate.Width = 120
        '
        'chAmount
        '
        Me.chAmount.Text = "Bill Amount"
        Me.chAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chAmount.Width = 120
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ButtonDelete)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(642, 522)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Delete"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 64)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "If you would like to completely delete the selected roll off from the database, p"& _ 
    "ress the Delete button."
        '
        'TimerRollOff
        '
        Me.TimerRollOff.Enabled = true
        '
        'LabelSpecialBill
        '
        Me.LabelSpecialBill.AutoSize = true
        Me.LabelSpecialBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelSpecialBill.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelSpecialBill.ForeColor = System.Drawing.Color.Blue
        Me.LabelSpecialBill.Location = New System.Drawing.Point(28, 70)
        Me.LabelSpecialBill.Name = "LabelSpecialBill"
        Me.LabelSpecialBill.Size = New System.Drawing.Size(55, 17)
        Me.LabelSpecialBill.TabIndex = 14
        Me.LabelSpecialBill.Text = "Label11"
        '
        'CreateRollOffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 581)
        Me.Controls.Add(Me.TabControlRollOff)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "CreateRollOffForm"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll Off Rental"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TabControlRollOff.ResumeLayout(false)
        Me.TabPageDelivered.ResumeLayout(false)
        Me.TabPageDelivered.PerformLayout
        Me.TabPageBilling.ResumeLayout(false)
        Me.TabPageBilling.PerformLayout
        Me.TabPage1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerDropOffDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDailyRate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRentalFee As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxRollOffFees As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSize As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDumpingFee As System.Windows.Forms.TextBox
    Friend WithEvents TabControlRollOff As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDelivered As System.Windows.Forms.TabPage
    Friend WithEvents RadioButtonMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDaily As System.Windows.Forms.RadioButton
    Friend WithEvents TabPageBilling As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxRollOffPickedUp As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerRollOffPickedUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonViewBill As System.Windows.Forms.Button
    Friend WithEvents ListViewBills As System.Windows.Forms.ListView
    Friend WithEvents chDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonDeactivate As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
    Friend WithEvents LabelCustomer As System.Windows.Forms.Label
    Friend WithEvents LabelAccount As System.Windows.Forms.Label
    Friend WithEvents LabelBillingAddress As System.Windows.Forms.Label
    Friend WithEvents LabelServiceAddress As System.Windows.Forms.Label
    Friend WithEvents TimerRollOff As System.Windows.Forms.Timer
    Friend WithEvents ButtonRefreshList As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSpecialBill As System.Windows.Forms.Label

End Class
