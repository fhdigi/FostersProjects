<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PaymentReceipt
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabelMOPDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelBillingCSZ = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelBillingAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelServiceCSZ = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelServiceAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPaymentAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPaymentDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCustomerName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAccountNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCurrentBalance = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 48.95833!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(629.9999!, 39.37499!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "FOSTER'S DISPOSAL SERVICE LLC"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.ForeColor = System.Drawing.Color.Navy
        Me.XrLine1.LineWidth = 5
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00002!, 39.37499!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(629.9999!, 12.58334!)
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'XrLine2
        '
        Me.XrLine2.ForeColor = System.Drawing.Color.Gray
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.00002!, 51.95832!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(629.9999!, 15.70835!)
        Me.XrLine2.StylePriority.UseForeColor = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLine1, Me.XrLine2})
        Me.ReportHeader.HeightF = 213.5417!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(350.4165!, 101.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(289.5833!, 17.79166!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "607-734-2502"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(350.4165!, 79.12499!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(289.5833!, 17.79166!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Phone"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 101.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(289.5833!, 17.79166!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.Text = "Elmira Heights, New York 14903-1760"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 79.12499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(289.5833!, 17.79166!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.Text = "208 Harrison Street"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 155.8334!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(629.9999!, 32.08332!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Payment Receipt"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelCurrentBalance, Me.XrLabel9, Me.XrLabelMOPDesc, Me.XrLabelBillingCSZ, Me.XrLabelBillingAddress, Me.XrLabelServiceCSZ, Me.XrLabelServiceAddress, Me.XrLabelPaymentAmount, Me.XrLabelPaymentDate, Me.XrLabel10, Me.XrLabel8, Me.XrLabel7, Me.XrLabelCustomerName, Me.XrLabelAccountNumber})
        Me.GroupHeader1.HeightF = 323.625!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabelMOPDesc
        '
        Me.XrLabelMOPDesc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelMOPDesc.ForeColor = System.Drawing.Color.Blue
        Me.XrLabelMOPDesc.LocationFloat = New DevExpress.Utils.PointFloat(249.9999!, 227.0833!)
        Me.XrLabelMOPDesc.Name = "XrLabelMOPDesc"
        Me.XrLabelMOPDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelMOPDesc.SizeF = New System.Drawing.SizeF(389.9995!, 18.83334!)
        Me.XrLabelMOPDesc.StylePriority.UseFont = False
        Me.XrLabelMOPDesc.StylePriority.UseForeColor = False
        Me.XrLabelMOPDesc.StylePriority.UseTextAlignment = False
        Me.XrLabelMOPDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelBillingCSZ
        '
        Me.XrLabelBillingCSZ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelBillingCSZ.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 167.4583!)
        Me.XrLabelBillingCSZ.Name = "XrLabelBillingCSZ"
        Me.XrLabelBillingCSZ.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelBillingCSZ.SizeF = New System.Drawing.SizeF(301.4583!, 23.0!)
        Me.XrLabelBillingCSZ.StylePriority.UseFont = False
        Me.XrLabelBillingCSZ.Text = "XrLabelBillingCSZ"
        '
        'XrLabelBillingAddress
        '
        Me.XrLabelBillingAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelBillingAddress.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 144.4583!)
        Me.XrLabelBillingAddress.Name = "XrLabelBillingAddress"
        Me.XrLabelBillingAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelBillingAddress.SizeF = New System.Drawing.SizeF(301.4584!, 23.0!)
        Me.XrLabelBillingAddress.StylePriority.UseFont = False
        Me.XrLabelBillingAddress.Text = "XrLabelBillingAddress"
        '
        'XrLabelServiceCSZ
        '
        Me.XrLabelServiceCSZ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelServiceCSZ.LocationFloat = New DevExpress.Utils.PointFloat(350.4165!, 167.4583!)
        Me.XrLabelServiceCSZ.Name = "XrLabelServiceCSZ"
        Me.XrLabelServiceCSZ.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelServiceCSZ.SizeF = New System.Drawing.SizeF(289.5831!, 23.0!)
        Me.XrLabelServiceCSZ.StylePriority.UseFont = False
        Me.XrLabelServiceCSZ.Text = "XrLabelServiceCSZ"
        '
        'XrLabelServiceAddress
        '
        Me.XrLabelServiceAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelServiceAddress.LocationFloat = New DevExpress.Utils.PointFloat(350.4165!, 144.4583!)
        Me.XrLabelServiceAddress.Name = "XrLabelServiceAddress"
        Me.XrLabelServiceAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelServiceAddress.SizeF = New System.Drawing.SizeF(289.5832!, 23.0!)
        Me.XrLabelServiceAddress.StylePriority.UseFont = False
        Me.XrLabelServiceAddress.Text = "XrLabelServiceAddress"
        '
        'XrLabelPaymentAmount
        '
        Me.XrLabelPaymentAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelPaymentAmount.LocationFloat = New DevExpress.Utils.PointFloat(151.6666!, 227.0834!)
        Me.XrLabelPaymentAmount.Name = "XrLabelPaymentAmount"
        Me.XrLabelPaymentAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPaymentAmount.SizeF = New System.Drawing.SizeF(73.95836!, 18.83334!)
        Me.XrLabelPaymentAmount.StylePriority.UseFont = False
        Me.XrLabelPaymentAmount.StylePriority.UseTextAlignment = False
        Me.XrLabelPaymentAmount.Text = "0.00"
        Me.XrLabelPaymentAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelPaymentDate
        '
        Me.XrLabelPaymentDate.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelPaymentDate.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 10.00001!)
        Me.XrLabelPaymentDate.Name = "XrLabelPaymentDate"
        Me.XrLabelPaymentDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPaymentDate.SizeF = New System.Drawing.SizeF(289.5833!, 18.83333!)
        Me.XrLabelPaymentDate.StylePriority.UseFont = False
        Me.XrLabelPaymentDate.Text = "Payment Date:"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 227.0833!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(135.4167!, 18.83333!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Payment Amount:"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(350.4165!, 125.625!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(289.583!, 18.83332!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "For Service At:"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 125.625!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(300.4167!, 18.83332!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Billing Address"
        '
        'XrLabelCustomerName
        '
        Me.XrLabelCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelCustomerName.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 79.70835!)
        Me.XrLabelCustomerName.Name = "XrLabelCustomerName"
        Me.XrLabelCustomerName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelCustomerName.SizeF = New System.Drawing.SizeF(389.9995!, 18.83334!)
        Me.XrLabelCustomerName.StylePriority.UseFont = False
        Me.XrLabelCustomerName.Text = "Account Name"
        '
        'XrLabelAccountNumber
        '
        Me.XrLabelAccountNumber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelAccountNumber.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 50.62497!)
        Me.XrLabelAccountNumber.Name = "XrLabelAccountNumber"
        Me.XrLabelAccountNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAccountNumber.SizeF = New System.Drawing.SizeF(216.6667!, 18.83334!)
        Me.XrLabelAccountNumber.StylePriority.UseFont = False
        Me.XrLabelAccountNumber.Text = "Account Number"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 259.375!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(135.4167!, 18.83333!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Current Balance"
        '
        'XrLabelCurrentBalance
        '
        Me.XrLabelCurrentBalance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelCurrentBalance.LocationFloat = New DevExpress.Utils.PointFloat(152.7084!, 259.375!)
        Me.XrLabelCurrentBalance.Name = "XrLabelCurrentBalance"
        Me.XrLabelCurrentBalance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelCurrentBalance.SizeF = New System.Drawing.SizeF(73.95836!, 18.83334!)
        Me.XrLabelCurrentBalance.StylePriority.UseFont = False
        Me.XrLabelCurrentBalance.StylePriority.UseTextAlignment = False
        Me.XrLabelCurrentBalance.Text = "0.00"
        Me.XrLabelCurrentBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PaymentReceipt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1})
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 49, 100)
        Me.Version = "13.2"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabelAccountNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCustomerName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPaymentDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPaymentAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents XrLabelBillingCSZ As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelBillingAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelServiceCSZ As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelServiceAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelMOPDesc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrentBalance As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
End Class
