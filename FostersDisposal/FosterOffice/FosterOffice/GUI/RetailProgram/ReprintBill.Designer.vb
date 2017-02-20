<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReprintBill
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
        Me.ListBoxBills = New System.Windows.Forms.ListBox()
        Me.LabelBillDates = New System.Windows.Forms.Label()
        Me.ListBoxPrintQue = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAddToQue = New System.Windows.Forms.Button()
        Me.ButtonRemoveFromQue = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ListBoxCustomers = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LinkLabelRemoveAllBills = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customers"
        '
        'ListBoxBills
        '
        Me.ListBoxBills.FormattingEnabled = True
        Me.ListBoxBills.Location = New System.Drawing.Point(354, 40)
        Me.ListBoxBills.Name = "ListBoxBills"
        Me.ListBoxBills.Size = New System.Drawing.Size(245, 95)
        Me.ListBoxBills.TabIndex = 4
        '
        'LabelBillDates
        '
        Me.LabelBillDates.AutoSize = True
        Me.LabelBillDates.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillDates.Location = New System.Drawing.Point(351, 21)
        Me.LabelBillDates.Name = "LabelBillDates"
        Me.LabelBillDates.Size = New System.Drawing.Size(53, 13)
        Me.LabelBillDates.TabIndex = 3
        Me.LabelBillDates.Text = "Bill Date"
        '
        'ListBoxPrintQue
        '
        Me.ListBoxPrintQue.FormattingEnabled = True
        Me.ListBoxPrintQue.Location = New System.Drawing.Point(354, 209)
        Me.ListBoxPrintQue.Name = "ListBoxPrintQue"
        Me.ListBoxPrintQue.Size = New System.Drawing.Size(245, 238)
        Me.ListBoxPrintQue.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Print Que"
        '
        'ButtonAddToQue
        '
        Me.ButtonAddToQue.Location = New System.Drawing.Point(354, 153)
        Me.ButtonAddToQue.Name = "ButtonAddToQue"
        Me.ButtonAddToQue.Size = New System.Drawing.Size(115, 23)
        Me.ButtonAddToQue.TabIndex = 5
        Me.ButtonAddToQue.Text = "Add to Que"
        Me.ButtonAddToQue.UseVisualStyleBackColor = True
        '
        'ButtonRemoveFromQue
        '
        Me.ButtonRemoveFromQue.Location = New System.Drawing.Point(484, 153)
        Me.ButtonRemoveFromQue.Name = "ButtonRemoveFromQue"
        Me.ButtonRemoveFromQue.Size = New System.Drawing.Size(115, 23)
        Me.ButtonRemoveFromQue.TabIndex = 6
        Me.ButtonRemoveFromQue.Text = "Remove from Que"
        Me.ButtonRemoveFromQue.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(639, 12)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrint.TabIndex = 9
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(639, 41)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ListBoxCustomers
        '
        Me.ListBoxCustomers.FormattingEnabled = True
        Me.ListBoxCustomers.Location = New System.Drawing.Point(72, 66)
        Me.ListBoxCustomers.Name = "ListBoxCustomers"
        Me.ListBoxCustomers.Size = New System.Drawing.Size(241, 407)
        Me.ListBoxCustomers.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FosterOffice.My.Resources.Resources.Print
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(72, 40)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(241, 21)
        Me.TextBoxSearch.TabIndex = 1
        '
        'LinkLabelRemoveAllBills
        '
        Me.LinkLabelRemoveAllBills.AutoSize = True
        Me.LinkLabelRemoveAllBills.Location = New System.Drawing.Point(387, 460)
        Me.LinkLabelRemoveAllBills.Name = "LinkLabelRemoveAllBills"
        Me.LinkLabelRemoveAllBills.Size = New System.Drawing.Size(172, 13)
        Me.LinkLabelRemoveAllBills.TabIndex = 11
        Me.LinkLabelRemoveAllBills.TabStop = True
        Me.LinkLabelRemoveAllBills.Text = "Remove All Bills from the Print Que"
        '
        'ReprintBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 490)
        Me.Controls.Add(Me.LinkLabelRemoveAllBills)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBoxCustomers)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.ButtonRemoveFromQue)
        Me.Controls.Add(Me.ButtonAddToQue)
        Me.Controls.Add(Me.ListBoxPrintQue)
        Me.Controls.Add(Me.ListBoxBills)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelBillDates)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReprintBill"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reprint Bill"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBoxBills As System.Windows.Forms.ListBox
    Friend WithEvents LabelBillDates As System.Windows.Forms.Label
    Friend WithEvents ListBoxPrintQue As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAddToQue As System.Windows.Forms.Button
    Friend WithEvents ButtonRemoveFromQue As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ListBoxCustomers As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabelRemoveAllBills As System.Windows.Forms.LinkLabel
End Class
