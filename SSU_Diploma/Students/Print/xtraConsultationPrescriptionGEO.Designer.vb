<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xtraConsultationPrescriptionGeo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xtraConsultationPrescriptionGeo))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PrescriptionRecommendations = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPatientName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrSignatureLine = New DevExpress.XtraReports.UI.XRLine()
        Me.xrSignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrContactInfo = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrOrganizationName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 36.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 39.27682!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PrescriptionRecommendations})
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        '
        'PrescriptionRecommendations
        '
        Me.PrescriptionRecommendations.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[PrescriptionRecommendations]")})
        Me.PrescriptionRecommendations.LocationFloat = New DevExpress.Utils.PointFloat(3.000426!, 0!)
        Me.PrescriptionRecommendations.Multiline = True
        Me.PrescriptionRecommendations.Name = "PrescriptionRecommendations"
        Me.PrescriptionRecommendations.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PrescriptionRecommendations.SizeF = New System.Drawing.SizeF(739.9993!, 23.0!)
        Me.PrescriptionRecommendations.Text = "PrescriptionRecommendations"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrContactInfo, Me.xrLogo, Me.xrOrganizationName})
        Me.ReportHeader.HeightF = 97.22601!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel3, Me.XrLabel5, Me.XrLabel12, Me.XrLabel4, Me.lblPatientName, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel14, Me.XrLabel13, Me.XrLabel15})
        Me.GroupHeader1.HeightF = 81.53032!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel12.BorderWidth = 1.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(265.708!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(79.16668!, 30.29165!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "პირადი N:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(79.16668!, 30.29165!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "პაციენტი:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblPatientName
        '
        Me.lblPatientName.BackColor = System.Drawing.Color.LightBlue
        Me.lblPatientName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblPatientName.BorderWidth = 1.0!
        Me.lblPatientName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[FullName]")})
        Me.lblPatientName.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.lblPatientName.LocationFloat = New DevExpress.Utils.PointFloat(79.16666!, 0!)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.lblPatientName.SizeF = New System.Drawing.SizeF(186.5414!, 30.29165!)
        Me.lblPatientName.StylePriority.UseBackColor = False
        Me.lblPatientName.StylePriority.UseBorders = False
        Me.lblPatientName.StylePriority.UseBorderWidth = False
        Me.lblPatientName.StylePriority.UseFont = False
        Me.lblPatientName.StylePriority.UsePadding = False
        Me.lblPatientName.StylePriority.UseTextAlignment = False
        Me.lblPatientName.Text = "სახელი გვარი"
        Me.lblPatientName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[Gender]")})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(344.8748!, 30.29162!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(142.7083!, 23.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[PatientDateOfBirth]")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(580.2913!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(162.7085!, 30.29165!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel8.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(241.7497!, 30.29162!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(103.1251!, 23.0!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "სქესი:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(487.5831!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(92.70816!, 30.29165!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "დაბ თარიღი:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(487.5831!, 30.29165!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(42.70819!, 23.0!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "ასაკი:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[PrivateId]")})
        Me.XrLabel13.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(344.8748!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(142.7083!, 30.29165!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UsePadding = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "პირადი N"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.BorderWidth = 1.0!
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[Age]")})
        Me.XrLabel15.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(530.2914!, 30.29162!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(212.7084!, 23.0!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "ას"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSignatureLine, Me.xrSignature, Me.XrLabel16, Me.XrLabel17})
        Me.GroupFooter1.HeightF = 103.6963!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'xrSignatureLine
        '
        Me.xrSignatureLine.LocationFloat = New DevExpress.Utils.PointFloat(550.7915!, 47.00003!)
        Me.xrSignatureLine.Name = "xrSignatureLine"
        Me.xrSignatureLine.SizeF = New System.Drawing.SizeF(171.2502!, 23.0!)
        '
        'xrSignature
        '
        Me.xrSignature.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[ConsultationPrescriptionGEO].[Signature]")})
        Me.xrSignature.LocationFloat = New DevExpress.Utils.PointFloat(550.7915!, 13.69629!)
        Me.xrSignature.Name = "xrSignature"
        Me.xrSignature.SizeF = New System.Drawing.SizeF(171.2502!, 80.0!)
        Me.xrSignature.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel16
        '
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(458.0833!, 47.00003!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(92.70822!, 23.0!)
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "ხელმოწერა:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[PersonalFullName]")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(3.000426!, 47.00003!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(286.5407!, 23.0!)
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel17.TextFormatString = "ექიმი:  {0}"
        '
        'xrContactInfo
        '
        Me.xrContactInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrContactInfo.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.xrContactInfo.LocationFloat = New DevExpress.Utils.PointFloat(200.6181!, 24.13338!)
        Me.xrContactInfo.Multiline = True
        Me.xrContactInfo.Name = "xrContactInfo"
        Me.xrContactInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.xrContactInfo.SizeF = New System.Drawing.SizeF(358.7739!, 68.96761!)
        Me.xrContactInfo.StylePriority.UseBorders = False
        Me.xrContactInfo.StylePriority.UseFont = False
        Me.xrContactInfo.StylePriority.UsePadding = False
        Me.xrContactInfo.StylePriority.UseTextAlignment = False
        Me.xrContactInfo.Text = "საკონტაქტო ინფო"
        Me.xrContactInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLogo
        '
        Me.xrLogo.LocationFloat = New DevExpress.Utils.PointFloat(28.83646!, 3.100999!)
        Me.xrLogo.Name = "xrLogo"
        Me.xrLogo.SizeF = New System.Drawing.SizeF(90.0!, 90.0!)
        Me.xrLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'xrOrganizationName
        '
        Me.xrOrganizationName.Font = New System.Drawing.Font("Sylfaen", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrOrganizationName.LocationFloat = New DevExpress.Utils.PointFloat(148.4161!, 0!)
        Me.xrOrganizationName.Multiline = True
        Me.xrOrganizationName.Name = "xrOrganizationName"
        Me.xrOrganizationName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrOrganizationName.SizeF = New System.Drawing.SizeF(462.0834!, 23.0!)
        Me.xrOrganizationName.StylePriority.UseFont = False
        Me.xrOrganizationName.StylePriority.UseTextAlignment = False
        Me.xrOrganizationName.Text = "კლინიკის დასახელება"
        Me.xrOrganizationName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.00007947286!, 30.29162!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(70.0!, 23.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "თარიღი:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.LightBlue
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsultationPrescriptionGEO].[RecordDate]")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(70.00008!, 30.29162!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(171.7496!, 23.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel7"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel5.TextFormatString = "{0:dd.MM.yyyy}"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(231.3333!, 56.75628!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(272.9167!, 23.00005!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "დანიშნულება"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xtraConsultationPrescriptionGeo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(27, 57, 36, 39)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPatientName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PrescriptionRecommendations As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrSignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrSignatureLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrContactInfo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents xrOrganizationName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
