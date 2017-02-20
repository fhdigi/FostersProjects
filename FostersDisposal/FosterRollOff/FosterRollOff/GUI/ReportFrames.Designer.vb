﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFrames
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
        Me.CPaymentSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerCustomEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerCustomStart = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonCustomRange = New System.Windows.Forms.RadioButton()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonPrintReport = New System.Windows.Forms.Button()
        Me.DateTimePickerReportDate = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonSpecificDate = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonCurrentYear = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCurrentMonth = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCurrentWeek = New System.Windows.Forms.RadioButton()
        Me.RadioButtonYesterday = New System.Windows.Forms.RadioButton()
        Me.ButtonRefreshReport = New System.Windows.Forms.Button()
        Me.RadioButtonToday = New System.Windows.Forms.RadioButton()
        Me.CRevenueReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentViewerReport = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.RadioButtonLastMonth = New System.Windows.Forms.RadioButton()
        CType(Me.CPaymentSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CRevenueReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPaymentSummaryBindingSource
        '
        Me.CPaymentSummaryBindingSource.DataSource = GetType(FosterRollOff.CReportObjects.CPaymentSummary)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.RadioButtonLastMonth)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePickerCustomEnd)
        Me.Panel1.Controls.Add(Me.DateTimePickerCustomStart)
        Me.Panel1.Controls.Add(Me.RadioButtonCustomRange)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Controls.Add(Me.ButtonPrintReport)
        Me.Panel1.Controls.Add(Me.DateTimePickerReportDate)
        Me.Panel1.Controls.Add(Me.RadioButtonSpecificDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButtonCurrentYear)
        Me.Panel1.Controls.Add(Me.RadioButtonCurrentMonth)
        Me.Panel1.Controls.Add(Me.RadioButtonCurrentWeek)
        Me.Panel1.Controls.Add(Me.RadioButtonYesterday)
        Me.Panel1.Controls.Add(Me.ButtonRefreshReport)
        Me.Panel1.Controls.Add(Me.RadioButtonToday)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 624)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "End"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Start"
        '
        'DateTimePickerCustomEnd
        '
        Me.DateTimePickerCustomEnd.Enabled = False
        Me.DateTimePickerCustomEnd.Location = New System.Drawing.Point(34, 393)
        Me.DateTimePickerCustomEnd.Name = "DateTimePickerCustomEnd"
        Me.DateTimePickerCustomEnd.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePickerCustomEnd.TabIndex = 13
        '
        'DateTimePickerCustomStart
        '
        Me.DateTimePickerCustomStart.Enabled = False
        Me.DateTimePickerCustomStart.Location = New System.Drawing.Point(34, 336)
        Me.DateTimePickerCustomStart.Name = "DateTimePickerCustomStart"
        Me.DateTimePickerCustomStart.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePickerCustomStart.TabIndex = 12
        '
        'RadioButtonCustomRange
        '
        Me.RadioButtonCustomRange.AutoSize = True
        Me.RadioButtonCustomRange.Location = New System.Drawing.Point(16, 287)
        Me.RadioButtonCustomRange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonCustomRange.Name = "RadioButtonCustomRange"
        Me.RadioButtonCustomRange.Size = New System.Drawing.Size(117, 23)
        Me.RadioButtonCustomRange.TabIndex = 11
        Me.RadioButtonCustomRange.TabStop = True
        Me.RadioButtonCustomRange.Text = "Custom Range"
        Me.RadioButtonCustomRange.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(60, 553)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(164, 29)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonPrintReport
        '
        Me.ButtonPrintReport.Image = Global.FosterRollOff.My.Resources.Resources.Print
        Me.ButtonPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrintReport.Location = New System.Drawing.Point(60, 507)
        Me.ButtonPrintReport.Name = "ButtonPrintReport"
        Me.ButtonPrintReport.Size = New System.Drawing.Size(164, 29)
        Me.ButtonPrintReport.TabIndex = 9
        Me.ButtonPrintReport.Text = "Print Report..."
        Me.ButtonPrintReport.UseVisualStyleBackColor = True
        '
        'DateTimePickerReportDate
        '
        Me.DateTimePickerReportDate.Enabled = False
        Me.DateTimePickerReportDate.Location = New System.Drawing.Point(38, 255)
        Me.DateTimePickerReportDate.Name = "DateTimePickerReportDate"
        Me.DateTimePickerReportDate.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePickerReportDate.TabIndex = 8
        '
        'RadioButtonSpecificDate
        '
        Me.RadioButtonSpecificDate.AutoSize = True
        Me.RadioButtonSpecificDate.Location = New System.Drawing.Point(21, 225)
        Me.RadioButtonSpecificDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonSpecificDate.Name = "RadioButtonSpecificDate"
        Me.RadioButtonSpecificDate.Size = New System.Drawing.Size(104, 23)
        Me.RadioButtonSpecificDate.TabIndex = 7
        Me.RadioButtonSpecificDate.TabStop = True
        Me.RadioButtonSpecificDate.Text = "Specific Date"
        Me.RadioButtonSpecificDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Report Date Ranges"
        '
        'RadioButtonCurrentYear
        '
        Me.RadioButtonCurrentYear.AutoSize = True
        Me.RadioButtonCurrentYear.Location = New System.Drawing.Point(21, 194)
        Me.RadioButtonCurrentYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonCurrentYear.Name = "RadioButtonCurrentYear"
        Me.RadioButtonCurrentYear.Size = New System.Drawing.Size(105, 23)
        Me.RadioButtonCurrentYear.TabIndex = 5
        Me.RadioButtonCurrentYear.TabStop = True
        Me.RadioButtonCurrentYear.Text = "Current Year"
        Me.RadioButtonCurrentYear.UseVisualStyleBackColor = True
        '
        'RadioButtonCurrentMonth
        '
        Me.RadioButtonCurrentMonth.AutoSize = True
        Me.RadioButtonCurrentMonth.Location = New System.Drawing.Point(21, 132)
        Me.RadioButtonCurrentMonth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonCurrentMonth.Name = "RadioButtonCurrentMonth"
        Me.RadioButtonCurrentMonth.Size = New System.Drawing.Size(120, 23)
        Me.RadioButtonCurrentMonth.TabIndex = 4
        Me.RadioButtonCurrentMonth.TabStop = True
        Me.RadioButtonCurrentMonth.Text = "Current Month"
        Me.RadioButtonCurrentMonth.UseVisualStyleBackColor = True
        '
        'RadioButtonCurrentWeek
        '
        Me.RadioButtonCurrentWeek.AutoSize = True
        Me.RadioButtonCurrentWeek.Location = New System.Drawing.Point(21, 101)
        Me.RadioButtonCurrentWeek.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonCurrentWeek.Name = "RadioButtonCurrentWeek"
        Me.RadioButtonCurrentWeek.Size = New System.Drawing.Size(112, 23)
        Me.RadioButtonCurrentWeek.TabIndex = 3
        Me.RadioButtonCurrentWeek.TabStop = True
        Me.RadioButtonCurrentWeek.Text = "Current Week"
        Me.RadioButtonCurrentWeek.UseVisualStyleBackColor = True
        '
        'RadioButtonYesterday
        '
        Me.RadioButtonYesterday.AutoSize = True
        Me.RadioButtonYesterday.Location = New System.Drawing.Point(21, 70)
        Me.RadioButtonYesterday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonYesterday.Name = "RadioButtonYesterday"
        Me.RadioButtonYesterday.Size = New System.Drawing.Size(87, 23)
        Me.RadioButtonYesterday.TabIndex = 2
        Me.RadioButtonYesterday.TabStop = True
        Me.RadioButtonYesterday.Text = "Yesterday"
        Me.RadioButtonYesterday.UseVisualStyleBackColor = True
        '
        'ButtonRefreshReport
        '
        Me.ButtonRefreshReport.Image = Global.FosterRollOff.My.Resources.Resources.Refresh_All
        Me.ButtonRefreshReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshReport.Location = New System.Drawing.Point(60, 459)
        Me.ButtonRefreshReport.Name = "ButtonRefreshReport"
        Me.ButtonRefreshReport.Size = New System.Drawing.Size(164, 29)
        Me.ButtonRefreshReport.TabIndex = 1
        Me.ButtonRefreshReport.Text = "Refresh Report"
        Me.ButtonRefreshReport.UseVisualStyleBackColor = True
        '
        'RadioButtonToday
        '
        Me.RadioButtonToday.AutoSize = True
        Me.RadioButtonToday.Location = New System.Drawing.Point(21, 39)
        Me.RadioButtonToday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonToday.Name = "RadioButtonToday"
        Me.RadioButtonToday.Size = New System.Drawing.Size(64, 23)
        Me.RadioButtonToday.TabIndex = 0
        Me.RadioButtonToday.TabStop = True
        Me.RadioButtonToday.Text = "Today"
        Me.RadioButtonToday.UseVisualStyleBackColor = True
        '
        'CRevenueReportBindingSource
        '
        Me.CRevenueReportBindingSource.DataSource = GetType(FosterRollOff.CReportObjects.CRevenueReport)
        '
        'DocumentViewerReport
        '
        Me.DocumentViewerReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocumentViewerReport.IsMetric = False
        Me.DocumentViewerReport.Location = New System.Drawing.Point(305, 16)
        Me.DocumentViewerReport.Name = "DocumentViewerReport"
        Me.DocumentViewerReport.Size = New System.Drawing.Size(659, 623)
        Me.DocumentViewerReport.TabIndex = 2
        '
        'RadioButtonLastMonth
        '
        Me.RadioButtonLastMonth.AutoSize = True
        Me.RadioButtonLastMonth.Location = New System.Drawing.Point(21, 163)
        Me.RadioButtonLastMonth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonLastMonth.Name = "RadioButtonLastMonth"
        Me.RadioButtonLastMonth.Size = New System.Drawing.Size(98, 23)
        Me.RadioButtonLastMonth.TabIndex = 16
        Me.RadioButtonLastMonth.TabStop = True
        Me.RadioButtonLastMonth.Text = "Last Month"
        Me.RadioButtonLastMonth.UseVisualStyleBackColor = True
        '
        'ReportFrames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 655)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DocumentViewerReport)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReportFrames"
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CPaymentSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CRevenueReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPaymentSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButtonToday As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonRefreshReport As System.Windows.Forms.Button
    Friend WithEvents RadioButtonYesterday As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCurrentYear As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCurrentMonth As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCurrentWeek As System.Windows.Forms.RadioButton
    Friend WithEvents CRevenueReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerReportDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButtonSpecificDate As System.Windows.Forms.RadioButton
    Friend WithEvents DocumentViewerReport As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintReport As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerCustomEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerCustomStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButtonCustomRange As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLastMonth As System.Windows.Forms.RadioButton
End Class
