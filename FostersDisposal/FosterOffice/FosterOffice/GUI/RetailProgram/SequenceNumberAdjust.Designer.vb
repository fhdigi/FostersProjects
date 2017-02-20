<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SequenceNumberAdjust
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStartingSeqNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxEndingSeqNumber = New System.Windows.Forms.TextBox()
        Me.ButtonReSequence = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonCommit = New System.Windows.Forms.Button()
        Me.DataGridViewData = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOldNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNewNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageDistribute = New System.Windows.Forms.TabPage()
        Me.TabPageDuplicates = New System.Windows.Forms.TabPage()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListViewDuplicates = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colNumber = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        CType(Me.DataGridViewData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControlMain.SuspendLayout
        Me.TabPageDistribute.SuspendLayout
        Me.TabPageDuplicates.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Sequence Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(27, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ending Sequence Number"
        '
        'TextBoxStartingSeqNumber
        '
        Me.TextBoxStartingSeqNumber.Location = New System.Drawing.Point(165, 25)
        Me.TextBoxStartingSeqNumber.Name = "TextBoxStartingSeqNumber"
        Me.TextBoxStartingSeqNumber.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxStartingSeqNumber.TabIndex = 2
        '
        'TextBoxEndingSeqNumber
        '
        Me.TextBoxEndingSeqNumber.Location = New System.Drawing.Point(165, 63)
        Me.TextBoxEndingSeqNumber.Name = "TextBoxEndingSeqNumber"
        Me.TextBoxEndingSeqNumber.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxEndingSeqNumber.TabIndex = 3
        '
        'ButtonReSequence
        '
        Me.ButtonReSequence.Location = New System.Drawing.Point(500, 23)
        Me.ButtonReSequence.Name = "ButtonReSequence"
        Me.ButtonReSequence.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReSequence.TabIndex = 4
        Me.ButtonReSequence.Text = "Distribute"
        Me.ButtonReSequence.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(539, 507)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'ButtonCommit
        '
        Me.ButtonCommit.Location = New System.Drawing.Point(385, 419)
        Me.ButtonCommit.Name = "ButtonCommit"
        Me.ButtonCommit.Size = New System.Drawing.Size(190, 23)
        Me.ButtonCommit.TabIndex = 7
        Me.ButtonCommit.Text = "Commit Changes to Database"
        Me.ButtonCommit.UseVisualStyleBackColor = true
        '
        'DataGridViewData
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DataGridViewData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colCustomer, Me.colOldNumber, Me.colNewNumber})
        Me.DataGridViewData.Location = New System.Drawing.Point(27, 104)
        Me.DataGridViewData.Name = "DataGridViewData"
        Me.DataGridViewData.Size = New System.Drawing.Size(548, 309)
        Me.DataGridViewData.TabIndex = 8
        '
        'colID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colID.DefaultCellStyle = DataGridViewCellStyle2
        Me.colID.HeaderText = "Account #"
        Me.colID.Name = "colID"
        Me.colID.Width = 80
        '
        'colCustomer
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colCustomer.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Width = 200
        '
        'colOldNumber
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colOldNumber.DefaultCellStyle = DataGridViewCellStyle4
        Me.colOldNumber.HeaderText = "Old Seq #"
        Me.colOldNumber.Name = "colOldNumber"
        '
        'colNewNumber
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNewNumber.DefaultCellStyle = DataGridViewCellStyle5
        Me.colNewNumber.HeaderText = "New Seq #"
        Me.colNewNumber.Name = "colNewNumber"
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageDistribute)
        Me.TabControlMain.Controls.Add(Me.TabPageDuplicates)
        Me.TabControlMain.Location = New System.Drawing.Point(12, 12)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(606, 484)
        Me.TabControlMain.TabIndex = 9
        '
        'TabPageDistribute
        '
        Me.TabPageDistribute.Controls.Add(Me.Label1)
        Me.TabPageDistribute.Controls.Add(Me.DataGridViewData)
        Me.TabPageDistribute.Controls.Add(Me.Label2)
        Me.TabPageDistribute.Controls.Add(Me.ButtonCommit)
        Me.TabPageDistribute.Controls.Add(Me.TextBoxStartingSeqNumber)
        Me.TabPageDistribute.Controls.Add(Me.TextBoxEndingSeqNumber)
        Me.TabPageDistribute.Controls.Add(Me.ButtonReSequence)
        Me.TabPageDistribute.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDistribute.Name = "TabPageDistribute"
        Me.TabPageDistribute.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDistribute.Size = New System.Drawing.Size(598, 458)
        Me.TabPageDistribute.TabIndex = 0
        Me.TabPageDistribute.Text = "Distribute"
        Me.TabPageDistribute.UseVisualStyleBackColor = true
        '
        'TabPageDuplicates
        '
        Me.TabPageDuplicates.Controls.Add(Me.ButtonRefresh)
        Me.TabPageDuplicates.Controls.Add(Me.Label3)
        Me.TabPageDuplicates.Controls.Add(Me.ListViewDuplicates)
        Me.TabPageDuplicates.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDuplicates.Name = "TabPageDuplicates"
        Me.TabPageDuplicates.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDuplicates.Size = New System.Drawing.Size(598, 458)
        Me.TabPageDuplicates.TabIndex = 1
        Me.TabPageDuplicates.Text = "Duplicates"
        Me.TabPageDuplicates.UseVisualStyleBackColor = true
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(496, 51)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(25, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "The following customers have duplicate sequence numbers"
        '
        'ListViewDuplicates
        '
        Me.ListViewDuplicates.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colNumber})
        Me.ListViewDuplicates.FullRowSelect = true
        Me.ListViewDuplicates.Location = New System.Drawing.Point(25, 51)
        Me.ListViewDuplicates.Name = "ListViewDuplicates"
        Me.ListViewDuplicates.Size = New System.Drawing.Size(440, 379)
        Me.ListViewDuplicates.TabIndex = 0
        Me.ListViewDuplicates.UseCompatibleStateImageBehavior = false
        Me.ListViewDuplicates.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Customer Name"
        Me.colName.Width = 300
        '
        'colNumber
        '
        Me.colNumber.Text = "Sequence Number"
        Me.colNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colNumber.Width = 110
        '
        'SequenceNumberAdjust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 542)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SequenceNumberAdjust"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sequence Numbers"
        CType(Me.DataGridViewData,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControlMain.ResumeLayout(false)
        Me.TabPageDistribute.ResumeLayout(false)
        Me.TabPageDistribute.PerformLayout
        Me.TabPageDuplicates.ResumeLayout(false)
        Me.TabPageDuplicates.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStartingSeqNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndingSeqNumber As System.Windows.Forms.TextBox
    Friend WithEvents ButtonReSequence As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonCommit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewData As System.Windows.Forms.DataGridView
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOldNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNewNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDistribute As System.Windows.Forms.TabPage
    Friend WithEvents TabPageDuplicates As System.Windows.Forms.TabPage
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListViewDuplicates As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNumber As System.Windows.Forms.ColumnHeader
End Class
