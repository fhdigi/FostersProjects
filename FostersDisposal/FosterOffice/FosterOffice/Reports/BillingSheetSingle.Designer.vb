<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class BillingSheetSingle
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDesc7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmt7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeaderBillSingle = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BillingDate", "Billing Date: {0:M/d/yyyy}")})
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 90.10416!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(313.5416!, 23.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AccountNumber")})
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(441.4583!, 291.6458!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(100.0!, 16.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:c2}")})
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 291.6458!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(72.91667!, 16.0!)
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AccountNumber")})
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(90.41679!, 291.6458!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(62.5!, 16.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAmt1
        '
        Me.XrLabelAmt1.CanGrow = False
        Me.XrLabelAmt1.Dpi = 100.0!
        Me.XrLabelAmt1.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 133.4791!)
        Me.XrLabelAmt1.Name = "XrLabelAmt1"
        Me.XrLabelAmt1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt1.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt1.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelDesc1
        '
        Me.XrLabelDesc1.CanGrow = False
        Me.XrLabelDesc1.Dpi = 100.0!
        Me.XrLabelDesc1.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 133.4791!)
        Me.XrLabelDesc1.Name = "XrLabelDesc1"
        Me.XrLabelDesc1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc1.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc1.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CSZ")})
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(363.4167!, 195.7646!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Address")})
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(363.4167!, 172.7647!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FullName")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(363.4167!, 149.7648!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tax", "{0:c2}")})
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 275.6458!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(72.91664!, 16.0!)
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelAmt2
        '
        Me.XrLabelAmt2.CanGrow = False
        Me.XrLabelAmt2.Dpi = 100.0!
        Me.XrLabelAmt2.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 149.7648!)
        Me.XrLabelAmt2.Name = "XrLabelAmt2"
        Me.XrLabelAmt2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt2.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt2.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelDesc2
        '
        Me.XrLabelDesc2.CanGrow = False
        Me.XrLabelDesc2.Dpi = 100.0!
        Me.XrLabelDesc2.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 149.7648!)
        Me.XrLabelDesc2.Name = "XrLabelDesc2"
        Me.XrLabelDesc2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc2.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc2.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDesc3
        '
        Me.XrLabelDesc3.CanGrow = False
        Me.XrLabelDesc3.Dpi = 100.0!
        Me.XrLabelDesc3.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 166.0505!)
        Me.XrLabelDesc3.Name = "XrLabelDesc3"
        Me.XrLabelDesc3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc3.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc3.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAmt3
        '
        Me.XrLabelAmt3.CanGrow = False
        Me.XrLabelAmt3.Dpi = 100.0!
        Me.XrLabelAmt3.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 166.0505!)
        Me.XrLabelAmt3.Name = "XrLabelAmt3"
        Me.XrLabelAmt3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt3.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt3.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelAmt4
        '
        Me.XrLabelAmt4.CanGrow = False
        Me.XrLabelAmt4.Dpi = 100.0!
        Me.XrLabelAmt4.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 182.3361!)
        Me.XrLabelAmt4.Name = "XrLabelAmt4"
        Me.XrLabelAmt4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt4.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt4.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelDesc4
        '
        Me.XrLabelDesc4.CanGrow = False
        Me.XrLabelDesc4.Dpi = 100.0!
        Me.XrLabelDesc4.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 182.3361!)
        Me.XrLabelDesc4.Name = "XrLabelDesc4"
        Me.XrLabelDesc4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc4.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc4.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDesc6
        '
        Me.XrLabelDesc6.CanGrow = False
        Me.XrLabelDesc6.Dpi = 100.0!
        Me.XrLabelDesc6.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 214.9077!)
        Me.XrLabelDesc6.Name = "XrLabelDesc6"
        Me.XrLabelDesc6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc6.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc6.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDesc5
        '
        Me.XrLabelDesc5.CanGrow = False
        Me.XrLabelDesc5.Dpi = 100.0!
        Me.XrLabelDesc5.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 198.6218!)
        Me.XrLabelDesc5.Name = "XrLabelDesc5"
        Me.XrLabelDesc5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc5.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc5.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDesc8
        '
        Me.XrLabelDesc8.CanGrow = False
        Me.XrLabelDesc8.Dpi = 100.0!
        Me.XrLabelDesc8.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 247.4792!)
        Me.XrLabelDesc8.Name = "XrLabelDesc8"
        Me.XrLabelDesc8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc8.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc8.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDesc7
        '
        Me.XrLabelDesc7.CanGrow = False
        Me.XrLabelDesc7.Dpi = 100.0!
        Me.XrLabelDesc7.LocationFloat = New DevExpress.Utils.PointFloat(20.41667!, 231.1935!)
        Me.XrLabelDesc7.Name = "XrLabelDesc7"
        Me.XrLabelDesc7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDesc7.SizeF = New System.Drawing.SizeF(203.125!, 16.0!)
        Me.XrLabelDesc7.StylePriority.UseTextAlignment = False
        Me.XrLabelDesc7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAmt6
        '
        Me.XrLabelAmt6.CanGrow = False
        Me.XrLabelAmt6.Dpi = 100.0!
        Me.XrLabelAmt6.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 214.9077!)
        Me.XrLabelAmt6.Name = "XrLabelAmt6"
        Me.XrLabelAmt6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt6.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt6.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelAmt5
        '
        Me.XrLabelAmt5.CanGrow = False
        Me.XrLabelAmt5.Dpi = 100.0!
        Me.XrLabelAmt5.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 198.6218!)
        Me.XrLabelAmt5.Name = "XrLabelAmt5"
        Me.XrLabelAmt5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt5.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt5.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelAmt8
        '
        Me.XrLabelAmt8.CanGrow = False
        Me.XrLabelAmt8.Dpi = 100.0!
        Me.XrLabelAmt8.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 247.4792!)
        Me.XrLabelAmt8.Name = "XrLabelAmt8"
        Me.XrLabelAmt8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt8.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt8.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelAmt7
        '
        Me.XrLabelAmt7.CanGrow = False
        Me.XrLabelAmt7.Dpi = 100.0!
        Me.XrLabelAmt7.LocationFloat = New DevExpress.Utils.PointFloat(235.4167!, 231.1935!)
        Me.XrLabelAmt7.Name = "XrLabelAmt7"
        Me.XrLabelAmt7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmt7.SizeF = New System.Drawing.SizeF(86.45831!, 16.0!)
        Me.XrLabelAmt7.StylePriority.UseTextAlignment = False
        Me.XrLabelAmt7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:c2}")})
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 235.9375!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(72.91667!, 16.0!)
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel8"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeaderBillSingle
        '
        Me.GroupHeaderBillSingle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabelAmt7, Me.XrLabelAmt8, Me.XrLabelAmt5, Me.XrLabelAmt6, Me.XrLabelDesc7, Me.XrLabelDesc8, Me.XrLabelDesc5, Me.XrLabelDesc6, Me.XrLabelDesc4, Me.XrLabelAmt4, Me.XrLabelAmt3, Me.XrLabelDesc3, Me.XrLabelDesc2, Me.XrLabelAmt2, Me.XrLabel7, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabelDesc1, Me.XrLabelAmt1, Me.XrLabel9, Me.XrLabel8, Me.XrLabel10, Me.XrLabel5})
        Me.GroupHeaderBillSingle.Dpi = 100.0!
        Me.GroupHeaderBillSingle.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SequenceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBillSingle.HeightF = 370.0!
        Me.GroupHeaderBillSingle.Name = "GroupHeaderBillSingle"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(FosterOffice.CCustomerBill)
        '
        'BillingSheetSingle
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderBillSingle})
        Me.DataSource = Me.BindingSource1
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(120, 0, 0, 0)
        Me.PageHeight = 370
        Me.PageWidth = 710
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Version = "16.1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDesc2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmt2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderBillSingle As DevExpress.XtraReports.UI.GroupHeaderBand
End Class
