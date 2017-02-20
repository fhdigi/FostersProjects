<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitingList
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewWaitingList = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDaysOnList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonAddToWaitingList = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonEditItem = New System.Windows.Forms.Button()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonConvertToRollOff = New System.Windows.Forms.Button()
        Me.ButtonCustomerCancelled = New System.Windows.Forms.Button()
        Me.RadioButtonWaitingList = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCancelList = New System.Windows.Forms.RadioButton()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonRemoveFromWaitingList = New System.Windows.Forms.Button()
        Me.ButtonMoveUp = New System.Windows.Forms.Button()
        Me.ButtonMoveDown = New System.Windows.Forms.Button()
        Me.ButtonMoveToBottom = New System.Windows.Forms.Button()
        CType(Me.DataGridViewWaitingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewWaitingList
        '
        Me.DataGridViewWaitingList.AllowUserToAddRows = False
        Me.DataGridViewWaitingList.AllowUserToDeleteRows = False
        Me.DataGridViewWaitingList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewWaitingList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewWaitingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewWaitingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNumber, Me.colCustomer, Me.colDate, Me.colDaysOnList, Me.colSize, Me.colUse, Me.colNotes})
        Me.DataGridViewWaitingList.Location = New System.Drawing.Point(12, 77)
        Me.DataGridViewWaitingList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewWaitingList.Name = "DataGridViewWaitingList"
        Me.DataGridViewWaitingList.Size = New System.Drawing.Size(1018, 489)
        Me.DataGridViewWaitingList.TabIndex = 2
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'colNumber
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNumber.DefaultCellStyle = DataGridViewCellStyle7
        Me.colNumber.HeaderText = "#"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.ReadOnly = True
        Me.colNumber.Width = 30
        '
        'colCustomer
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCustomer.DefaultCellStyle = DataGridViewCellStyle8
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        Me.colCustomer.Width = 150
        '
        'colDate
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle9
        Me.colDate.HeaderText = "Date On List"
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 125
        '
        'colDaysOnList
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDaysOnList.DefaultCellStyle = DataGridViewCellStyle10
        Me.colDaysOnList.HeaderText = "Days On List"
        Me.colDaysOnList.Name = "colDaysOnList"
        Me.colDaysOnList.ReadOnly = True
        Me.colDaysOnList.Width = 125
        '
        'colSize
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSize.DefaultCellStyle = DataGridViewCellStyle11
        Me.colSize.HeaderText = "Size"
        Me.colSize.Name = "colSize"
        Me.colSize.Width = 80
        '
        'colUse
        '
        Me.colUse.HeaderText = "Use"
        Me.colUse.Name = "colUse"
        Me.colUse.Width = 175
        '
        'colNotes
        '
        Me.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colNotes.DefaultCellStyle = DataGridViewCellStyle12
        Me.colNotes.HeaderText = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'ButtonAddToWaitingList
        '
        Me.ButtonAddToWaitingList.Location = New System.Drawing.Point(12, 574)
        Me.ButtonAddToWaitingList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddToWaitingList.Name = "ButtonAddToWaitingList"
        Me.ButtonAddToWaitingList.Size = New System.Drawing.Size(164, 30)
        Me.ButtonAddToWaitingList.TabIndex = 6
        Me.ButtonAddToWaitingList.Text = "Add to Waiting List..."
        Me.ButtonAddToWaitingList.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(934, 12)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(96, 30)
        Me.ButtonClose.TabIndex = 12
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonEditItem
        '
        Me.ButtonEditItem.Enabled = False
        Me.ButtonEditItem.Location = New System.Drawing.Point(191, 574)
        Me.ButtonEditItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEditItem.Name = "ButtonEditItem"
        Me.ButtonEditItem.Size = New System.Drawing.Size(164, 30)
        Me.ButtonEditItem.TabIndex = 7
        Me.ButtonEditItem.Text = "Edit Item..."
        Me.ButtonEditItem.UseVisualStyleBackColor = True
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 500
        '
        'ButtonConvertToRollOff
        '
        Me.ButtonConvertToRollOff.Enabled = False
        Me.ButtonConvertToRollOff.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConvertToRollOff.ForeColor = System.Drawing.Color.Blue
        Me.ButtonConvertToRollOff.Location = New System.Drawing.Point(549, 575)
        Me.ButtonConvertToRollOff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonConvertToRollOff.Name = "ButtonConvertToRollOff"
        Me.ButtonConvertToRollOff.Size = New System.Drawing.Size(164, 30)
        Me.ButtonConvertToRollOff.TabIndex = 9
        Me.ButtonConvertToRollOff.Text = "Convert to Roll Off"
        Me.ButtonConvertToRollOff.UseVisualStyleBackColor = True
        '
        'ButtonCustomerCancelled
        '
        Me.ButtonCustomerCancelled.Enabled = False
        Me.ButtonCustomerCancelled.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCustomerCancelled.ForeColor = System.Drawing.Color.Black
        Me.ButtonCustomerCancelled.Location = New System.Drawing.Point(370, 575)
        Me.ButtonCustomerCancelled.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCustomerCancelled.Name = "ButtonCustomerCancelled"
        Me.ButtonCustomerCancelled.Size = New System.Drawing.Size(164, 30)
        Me.ButtonCustomerCancelled.TabIndex = 8
        Me.ButtonCustomerCancelled.Text = "Customer Cancelled"
        Me.ButtonCustomerCancelled.UseVisualStyleBackColor = True
        '
        'RadioButtonWaitingList
        '
        Me.RadioButtonWaitingList.AutoSize = True
        Me.RadioButtonWaitingList.Location = New System.Drawing.Point(12, 22)
        Me.RadioButtonWaitingList.Name = "RadioButtonWaitingList"
        Me.RadioButtonWaitingList.Size = New System.Drawing.Size(93, 21)
        Me.RadioButtonWaitingList.TabIndex = 0
        Me.RadioButtonWaitingList.TabStop = True
        Me.RadioButtonWaitingList.Text = "Waiting List"
        Me.RadioButtonWaitingList.UseVisualStyleBackColor = True
        '
        'RadioButtonCancelList
        '
        Me.RadioButtonCancelList.AutoSize = True
        Me.RadioButtonCancelList.Location = New System.Drawing.Point(12, 49)
        Me.RadioButtonCancelList.Name = "RadioButtonCancelList"
        Me.RadioButtonCancelList.Size = New System.Drawing.Size(147, 21)
        Me.RadioButtonCancelList.TabIndex = 1
        Me.RadioButtonCancelList.TabStop = True
        Me.RadioButtonCancelList.Text = "Customer Cancel List"
        Me.RadioButtonCancelList.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.Black
        Me.ButtonPrint.Image = Global.FosterRollOff.My.Resources.Resources.Print
        Me.ButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrint.Location = New System.Drawing.Point(728, 575)
        Me.ButtonPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(102, 30)
        Me.ButtonPrint.TabIndex = 10
        Me.ButtonPrint.Text = "Print List..."
        Me.ButtonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonRemoveFromWaitingList
        '
        Me.ButtonRemoveFromWaitingList.Enabled = False
        Me.ButtonRemoveFromWaitingList.Image = Global.FosterRollOff.My.Resources.Resources.Delete
        Me.ButtonRemoveFromWaitingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRemoveFromWaitingList.Location = New System.Drawing.Point(957, 575)
        Me.ButtonRemoveFromWaitingList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRemoveFromWaitingList.Name = "ButtonRemoveFromWaitingList"
        Me.ButtonRemoveFromWaitingList.Size = New System.Drawing.Size(73, 30)
        Me.ButtonRemoveFromWaitingList.TabIndex = 11
        Me.ButtonRemoveFromWaitingList.Text = "Delete"
        Me.ButtonRemoveFromWaitingList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRemoveFromWaitingList.UseVisualStyleBackColor = True
        '
        'ButtonMoveUp
        '
        Me.ButtonMoveUp.Location = New System.Drawing.Point(440, 45)
        Me.ButtonMoveUp.Name = "ButtonMoveUp"
        Me.ButtonMoveUp.Size = New System.Drawing.Size(120, 25)
        Me.ButtonMoveUp.TabIndex = 3
        Me.ButtonMoveUp.Text = "Move Up"
        Me.ButtonMoveUp.UseVisualStyleBackColor = True
        '
        'ButtonMoveDown
        '
        Me.ButtonMoveDown.Location = New System.Drawing.Point(566, 45)
        Me.ButtonMoveDown.Name = "ButtonMoveDown"
        Me.ButtonMoveDown.Size = New System.Drawing.Size(120, 25)
        Me.ButtonMoveDown.TabIndex = 4
        Me.ButtonMoveDown.Text = "Move Down"
        Me.ButtonMoveDown.UseVisualStyleBackColor = True
        '
        'ButtonMoveToBottom
        '
        Me.ButtonMoveToBottom.Location = New System.Drawing.Point(692, 45)
        Me.ButtonMoveToBottom.Name = "ButtonMoveToBottom"
        Me.ButtonMoveToBottom.Size = New System.Drawing.Size(120, 25)
        Me.ButtonMoveToBottom.TabIndex = 5
        Me.ButtonMoveToBottom.Text = "Move To Bottom"
        Me.ButtonMoveToBottom.UseVisualStyleBackColor = True
        '
        'WaitingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 618)
        Me.Controls.Add(Me.ButtonMoveToBottom)
        Me.Controls.Add(Me.ButtonMoveDown)
        Me.Controls.Add(Me.ButtonMoveUp)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.RadioButtonCancelList)
        Me.Controls.Add(Me.RadioButtonWaitingList)
        Me.Controls.Add(Me.ButtonCustomerCancelled)
        Me.Controls.Add(Me.ButtonConvertToRollOff)
        Me.Controls.Add(Me.ButtonEditItem)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonRemoveFromWaitingList)
        Me.Controls.Add(Me.ButtonAddToWaitingList)
        Me.Controls.Add(Me.DataGridViewWaitingList)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WaitingList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Waiting List"
        CType(Me.DataGridViewWaitingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewWaitingList As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAddToWaitingList As System.Windows.Forms.Button
    Friend WithEvents ButtonRemoveFromWaitingList As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonEditItem As System.Windows.Forms.Button
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents ButtonConvertToRollOff As System.Windows.Forms.Button
    Friend WithEvents ButtonCustomerCancelled As System.Windows.Forms.Button
    Friend WithEvents RadioButtonWaitingList As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCancelList As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveUp As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveDown As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDaysOnList As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonMoveToBottom As System.Windows.Forms.Button
End Class
