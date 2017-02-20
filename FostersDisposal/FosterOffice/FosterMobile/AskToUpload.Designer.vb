<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskToUpload
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
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 147)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "If you would like to upload the route data to the server now, please press the Up" & _
    "load button.  You must be connected to the internet for the upload to work. "
        '
        'ButtonUpload
        '
        Me.ButtonUpload.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonUpload.Location = New System.Drawing.Point(124, 159)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(488, 48)
        Me.ButtonUpload.TabIndex = 1
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FosterMobile.My.Resources.Resources.Network_Internet
        Me.PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonCancel.Location = New System.Drawing.Point(124, 379)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(488, 48)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Go Back"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(119, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(493, 103)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "If you hit the End Shift button by mistake and want to go back, hit the Go Back b" & _
    "utton below."
        '
        'AskToUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 454)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AskToUpload"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Upload Data File"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpload As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
