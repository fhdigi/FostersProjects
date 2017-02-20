<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftStartOptions
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
        Me.ButtonStartRoute = New System.Windows.Forms.Button()
        Me.ButtonResumePreviousRoute = New System.Windows.Forms.Button()
        Me.ButtonCloseProgram = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ComboBoxRouteDay = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonGetLatestDatabase = New System.Windows.Forms.Button()
        Me.LabelDBDownload = New System.Windows.Forms.Label()
        Me.ComboBoxRouteNumber = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtonStartRoute
        '
        Me.ButtonStartRoute.Location = New System.Drawing.Point(42, 256)
        Me.ButtonStartRoute.Name = "ButtonStartRoute"
        Me.ButtonStartRoute.Size = New System.Drawing.Size(463, 91)
        Me.ButtonStartRoute.TabIndex = 0
        Me.ButtonStartRoute.Text = "Start New Route"
        Me.ButtonStartRoute.UseVisualStyleBackColor = True
        '
        'ButtonResumePreviousRoute
        '
        Me.ButtonResumePreviousRoute.Location = New System.Drawing.Point(42, 373)
        Me.ButtonResumePreviousRoute.Name = "ButtonResumePreviousRoute"
        Me.ButtonResumePreviousRoute.Size = New System.Drawing.Size(463, 91)
        Me.ButtonResumePreviousRoute.TabIndex = 0
        Me.ButtonResumePreviousRoute.Text = "Resume Previous Route"
        Me.ButtonResumePreviousRoute.UseVisualStyleBackColor = True
        '
        'ButtonCloseProgram
        '
        Me.ButtonCloseProgram.Location = New System.Drawing.Point(511, 373)
        Me.ButtonCloseProgram.Name = "ButtonCloseProgram"
        Me.ButtonCloseProgram.Size = New System.Drawing.Size(270, 91)
        Me.ButtonCloseProgram.TabIndex = 0
        Me.ButtonCloseProgram.Text = "Close Program"
        Me.ButtonCloseProgram.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(962, 85)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FOSTER'S"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(990, 554)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Navy
        Me.LineShape3.BorderWidth = 6
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 25
        Me.LineShape3.X2 = 975
        Me.LineShape3.Y1 = 115
        Me.LineShape3.Y2 = 115
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.BorderWidth = 6
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 25
        Me.LineShape1.X2 = 975
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(964, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DISPOSAL SERVICE LLC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Enabled = False
        Me.ButtonUpdate.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.Red
        Me.ButtonUpdate.Location = New System.Drawing.Point(787, 373)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(187, 91)
        Me.ButtonUpdate.TabIndex = 3
        Me.ButtonUpdate.Text = "Update..."
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ComboBoxRouteDay
        '
        Me.ComboBoxRouteDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRouteDay.FormattingEnabled = True
        Me.ComboBoxRouteDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.ComboBoxRouteDay.Location = New System.Drawing.Point(99, 186)
        Me.ComboBoxRouteDay.Name = "ComboBoxRouteDay"
        Me.ComboBoxRouteDay.Size = New System.Drawing.Size(322, 34)
        Me.ComboBoxRouteDay.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(507, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Route #"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Day"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonGetLatestDatabase
        '
        Me.ButtonGetLatestDatabase.Location = New System.Drawing.Point(511, 256)
        Me.ButtonGetLatestDatabase.Name = "ButtonGetLatestDatabase"
        Me.ButtonGetLatestDatabase.Size = New System.Drawing.Size(463, 91)
        Me.ButtonGetLatestDatabase.TabIndex = 6
        Me.ButtonGetLatestDatabase.Text = "Set Database Location (Admin Only)"
        Me.ButtonGetLatestDatabase.UseVisualStyleBackColor = True
        '
        'LabelDBDownload
        '
        Me.LabelDBDownload.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDBDownload.ForeColor = System.Drawing.Color.Blue
        Me.LabelDBDownload.Location = New System.Drawing.Point(12, 504)
        Me.LabelDBDownload.Name = "LabelDBDownload"
        Me.LabelDBDownload.Size = New System.Drawing.Size(962, 32)
        Me.LabelDBDownload.TabIndex = 1
        Me.LabelDBDownload.Text = "DISPOSAL SERVICE LLC"
        Me.LabelDBDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxRouteNumber
        '
        Me.ComboBoxRouteNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRouteNumber.FormattingEnabled = True
        Me.ComboBoxRouteNumber.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxRouteNumber.Location = New System.Drawing.Point(598, 185)
        Me.ComboBoxRouteNumber.Name = "ComboBoxRouteNumber"
        Me.ComboBoxRouteNumber.Size = New System.Drawing.Size(74, 34)
        Me.ComboBoxRouteNumber.TabIndex = 7
        '
        'ShiftStartOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 554)
        Me.Controls.Add(Me.ComboBoxRouteNumber)
        Me.Controls.Add(Me.LabelDBDownload)
        Me.Controls.Add(Me.ButtonGetLatestDatabase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxRouteDay)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCloseProgram)
        Me.Controls.Add(Me.ButtonResumePreviousRoute)
        Me.Controls.Add(Me.ButtonStartRoute)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShiftStartOptions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start Options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonStartRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonResumePreviousRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonCloseProgram As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ComboBoxRouteDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonGetLatestDatabase As System.Windows.Forms.Button
    Friend WithEvents LabelDBDownload As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRouteNumber As System.Windows.Forms.ComboBox
End Class
