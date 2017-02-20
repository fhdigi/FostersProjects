<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerNoteFilter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_Friday = New System.Windows.Forms.RadioButton()
        Me.RB_Thursday = New System.Windows.Forms.RadioButton()
        Me.RB_Wednesday = New System.Windows.Forms.RadioButton()
        Me.RB_Tuesday = New System.Windows.Forms.RadioButton()
        Me.RB_Monday = New System.Windows.Forms.RadioButton()
        Me.RB_AllDays = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_Route4 = New System.Windows.Forms.RadioButton()
        Me.RB_AllRoutes = New System.Windows.Forms.RadioButton()
        Me.RB_Route1 = New System.Windows.Forms.RadioButton()
        Me.RB_Route3 = New System.Windows.Forms.RadioButton()
        Me.RB_Route2 = New System.Windows.Forms.RadioButton()
        Me.ButtonRunReport = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxCurrentBilling = New System.Windows.Forms.CheckBox()
        Me.LabelBillingMonth = New System.Windows.Forms.Label()
        Me.TextBoxBillingMonth = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_Friday)
        Me.GroupBox1.Controls.Add(Me.RB_Thursday)
        Me.GroupBox1.Controls.Add(Me.RB_Wednesday)
        Me.GroupBox1.Controls.Add(Me.RB_Tuesday)
        Me.GroupBox1.Controls.Add(Me.RB_Monday)
        Me.GroupBox1.Controls.Add(Me.RB_AllDays)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pickup Days"
        '
        'RB_Friday
        '
        Me.RB_Friday.AutoSize = True
        Me.RB_Friday.Location = New System.Drawing.Point(17, 147)
        Me.RB_Friday.Name = "RB_Friday"
        Me.RB_Friday.Size = New System.Drawing.Size(55, 17)
        Me.RB_Friday.TabIndex = 5
        Me.RB_Friday.TabStop = True
        Me.RB_Friday.Text = "Friday"
        Me.RB_Friday.UseVisualStyleBackColor = True
        '
        'RB_Thursday
        '
        Me.RB_Thursday.AutoSize = True
        Me.RB_Thursday.Location = New System.Drawing.Point(17, 123)
        Me.RB_Thursday.Name = "RB_Thursday"
        Me.RB_Thursday.Size = New System.Drawing.Size(70, 17)
        Me.RB_Thursday.TabIndex = 4
        Me.RB_Thursday.TabStop = True
        Me.RB_Thursday.Text = "Thursday"
        Me.RB_Thursday.UseVisualStyleBackColor = True
        '
        'RB_Wednesday
        '
        Me.RB_Wednesday.AutoSize = True
        Me.RB_Wednesday.Location = New System.Drawing.Point(17, 99)
        Me.RB_Wednesday.Name = "RB_Wednesday"
        Me.RB_Wednesday.Size = New System.Drawing.Size(82, 17)
        Me.RB_Wednesday.TabIndex = 3
        Me.RB_Wednesday.TabStop = True
        Me.RB_Wednesday.Text = "Wednesday"
        Me.RB_Wednesday.UseVisualStyleBackColor = True
        '
        'RB_Tuesday
        '
        Me.RB_Tuesday.AutoSize = True
        Me.RB_Tuesday.Location = New System.Drawing.Point(17, 75)
        Me.RB_Tuesday.Name = "RB_Tuesday"
        Me.RB_Tuesday.Size = New System.Drawing.Size(66, 17)
        Me.RB_Tuesday.TabIndex = 2
        Me.RB_Tuesday.TabStop = True
        Me.RB_Tuesday.Text = "Tuesday"
        Me.RB_Tuesday.UseVisualStyleBackColor = True
        '
        'RB_Monday
        '
        Me.RB_Monday.AutoSize = True
        Me.RB_Monday.Location = New System.Drawing.Point(17, 51)
        Me.RB_Monday.Name = "RB_Monday"
        Me.RB_Monday.Size = New System.Drawing.Size(63, 17)
        Me.RB_Monday.TabIndex = 1
        Me.RB_Monday.TabStop = True
        Me.RB_Monday.Text = "Monday"
        Me.RB_Monday.UseVisualStyleBackColor = True
        '
        'RB_AllDays
        '
        Me.RB_AllDays.AutoSize = True
        Me.RB_AllDays.Location = New System.Drawing.Point(17, 27)
        Me.RB_AllDays.Name = "RB_AllDays"
        Me.RB_AllDays.Size = New System.Drawing.Size(63, 17)
        Me.RB_AllDays.TabIndex = 0
        Me.RB_AllDays.TabStop = True
        Me.RB_AllDays.Text = "All Days"
        Me.RB_AllDays.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Route4)
        Me.GroupBox2.Controls.Add(Me.RB_AllRoutes)
        Me.GroupBox2.Controls.Add(Me.RB_Route1)
        Me.GroupBox2.Controls.Add(Me.RB_Route3)
        Me.GroupBox2.Controls.Add(Me.RB_Route2)
        Me.GroupBox2.Location = New System.Drawing.Point(199, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Route"
        '
        'RB_Route4
        '
        Me.RB_Route4.AutoSize = True
        Me.RB_Route4.Location = New System.Drawing.Point(26, 123)
        Me.RB_Route4.Name = "RB_Route4"
        Me.RB_Route4.Size = New System.Drawing.Size(63, 17)
        Me.RB_Route4.TabIndex = 4
        Me.RB_Route4.TabStop = True
        Me.RB_Route4.Text = "Route 4"
        Me.RB_Route4.UseVisualStyleBackColor = True
        '
        'RB_AllRoutes
        '
        Me.RB_AllRoutes.AutoSize = True
        Me.RB_AllRoutes.Location = New System.Drawing.Point(26, 27)
        Me.RB_AllRoutes.Name = "RB_AllRoutes"
        Me.RB_AllRoutes.Size = New System.Drawing.Size(73, 17)
        Me.RB_AllRoutes.TabIndex = 0
        Me.RB_AllRoutes.TabStop = True
        Me.RB_AllRoutes.Text = "All Routes"
        Me.RB_AllRoutes.UseVisualStyleBackColor = True
        '
        'RB_Route1
        '
        Me.RB_Route1.AutoSize = True
        Me.RB_Route1.Location = New System.Drawing.Point(26, 51)
        Me.RB_Route1.Name = "RB_Route1"
        Me.RB_Route1.Size = New System.Drawing.Size(63, 17)
        Me.RB_Route1.TabIndex = 1
        Me.RB_Route1.TabStop = True
        Me.RB_Route1.Text = "Route 1"
        Me.RB_Route1.UseVisualStyleBackColor = True
        '
        'RB_Route3
        '
        Me.RB_Route3.AutoSize = True
        Me.RB_Route3.Location = New System.Drawing.Point(26, 99)
        Me.RB_Route3.Name = "RB_Route3"
        Me.RB_Route3.Size = New System.Drawing.Size(63, 17)
        Me.RB_Route3.TabIndex = 3
        Me.RB_Route3.TabStop = True
        Me.RB_Route3.Text = "Route 3"
        Me.RB_Route3.UseVisualStyleBackColor = True
        '
        'RB_Route2
        '
        Me.RB_Route2.AutoSize = True
        Me.RB_Route2.Location = New System.Drawing.Point(26, 75)
        Me.RB_Route2.Name = "RB_Route2"
        Me.RB_Route2.Size = New System.Drawing.Size(63, 17)
        Me.RB_Route2.TabIndex = 2
        Me.RB_Route2.TabStop = True
        Me.RB_Route2.Text = "Route 2"
        Me.RB_Route2.UseVisualStyleBackColor = True
        '
        'ButtonRunReport
        '
        Me.ButtonRunReport.Location = New System.Drawing.Point(346, 12)
        Me.ButtonRunReport.Name = "ButtonRunReport"
        Me.ButtonRunReport.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRunReport.TabIndex = 2
        Me.ButtonRunReport.Text = "Run Report"
        Me.ButtonRunReport.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(346, 41)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FosterOffice.My.Resources.Resources.Filter
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'CheckBoxCurrentBilling
        '
        Me.CheckBoxCurrentBilling.AutoSize = True
        Me.CheckBoxCurrentBilling.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCurrentBilling.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxCurrentBilling.Location = New System.Drawing.Point(62, 193)
        Me.CheckBoxCurrentBilling.Name = "CheckBoxCurrentBilling"
        Me.CheckBoxCurrentBilling.Size = New System.Drawing.Size(350, 17)
        Me.CheckBoxCurrentBilling.TabIndex = 4
        Me.CheckBoxCurrentBilling.Text = "Show only customers in current billing cycle or delinquent"
        Me.CheckBoxCurrentBilling.UseVisualStyleBackColor = True
        '
        'LabelBillingMonth
        '
        Me.LabelBillingMonth.AutoSize = True
        Me.LabelBillingMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillingMonth.Location = New System.Drawing.Point(85, 222)
        Me.LabelBillingMonth.Name = "LabelBillingMonth"
        Me.LabelBillingMonth.Size = New System.Drawing.Size(79, 13)
        Me.LabelBillingMonth.TabIndex = 5
        Me.LabelBillingMonth.Text = "Billing Month"
        '
        'TextBoxBillingMonth
        '
        Me.TextBoxBillingMonth.Location = New System.Drawing.Point(170, 219)
        Me.TextBoxBillingMonth.Name = "TextBoxBillingMonth"
        Me.TextBoxBillingMonth.Size = New System.Drawing.Size(150, 21)
        Me.TextBoxBillingMonth.TabIndex = 6
        '
        'CustomerNoteFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 253)
        Me.Controls.Add(Me.TextBoxBillingMonth)
        Me.Controls.Add(Me.LabelBillingMonth)
        Me.Controls.Add(Me.CheckBoxCurrentBilling)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonRunReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CustomerNoteFilter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Note Filter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Friday As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Thursday As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Wednesday As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Tuesday As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Monday As System.Windows.Forms.RadioButton
    Friend WithEvents RB_AllDays As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Route4 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_AllRoutes As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Route1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Route3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Route2 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonRunReport As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxCurrentBilling As System.Windows.Forms.CheckBox
    Friend WithEvents LabelBillingMonth As System.Windows.Forms.Label
    Friend WithEvents TextBoxBillingMonth As System.Windows.Forms.TextBox
End Class
