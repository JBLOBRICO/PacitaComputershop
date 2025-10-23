<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminFrm
    Inherits System.Windows.Forms.Form

    'Dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Components
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.btnMonitoring = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlStatsContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlSalesStat = New System.Windows.Forms.Panel()
        Me.lblSalesValue = New System.Windows.Forms.Label()
        Me.lblSalesTitle = New System.Windows.Forms.Label()
        Me.pnlPCStat = New System.Windows.Forms.Panel()
        Me.lblPCValue = New System.Windows.Forms.Label()
        Me.lblPCTitle = New System.Windows.Forms.Label()
        Me.pnlBillStat = New System.Windows.Forms.Panel()
        Me.lblBillValue = New System.Windows.Forms.Label()
        Me.lblBillTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlStatsContainer.SuspendLayout()
        Me.pnlSalesStat.SuspendLayout()
        Me.pnlPCStat.SuspendLayout()
        Me.pnlBillStat.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnAnalytics)
        Me.pnlSidebar.Controls.Add(Me.btnMonitoring)
        Me.pnlSidebar.Controls.Add(Me.btnSales)
        Me.pnlSidebar.Controls.Add(Me.lblLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(173, 729)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 662)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(173, 67)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAnalytics
        '
        Me.btnAnalytics.FlatAppearance.BorderSize = 0
        Me.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalytics.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnAnalytics.ForeColor = System.Drawing.Color.White
        Me.btnAnalytics.Location = New System.Drawing.Point(0, 226)
        Me.btnAnalytics.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(173, 68)
        Me.btnAnalytics.TabIndex = 3
        Me.btnAnalytics.Text = "📊  Analytics"
        Me.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnalytics.UseVisualStyleBackColor = True
        '
        'btnMonitoring
        '
        Me.btnMonitoring.FlatAppearance.BorderSize = 0
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnMonitoring.ForeColor = System.Drawing.Color.White
        Me.btnMonitoring.Location = New System.Drawing.Point(-4, 78)
        Me.btnMonitoring.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(173, 72)
        Me.btnMonitoring.TabIndex = 2
        Me.btnMonitoring.Text = "🧾  Monitoring"
        Me.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonitoring.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(-4, 143)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(173, 79)
        Me.btnSales.TabIndex = 1
        Me.btnSales.Text = "💻  Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(0, 26)
        Me.lblLogo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(173, 32)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "PACITA CAFE"
        Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(173, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1086, 52)
        Me.pnlTop.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 13)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(400, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Admin Dashboard — Pacita Computer Shop"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlStatsContainer)
        Me.pnlMain.Controls.Add(Me.lblWelcome)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(173, 52)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1086, 677)
        Me.pnlMain.TabIndex = 2
        '
        'pnlStatsContainer
        '
        Me.pnlStatsContainer.Controls.Add(Me.pnlSalesStat)
        Me.pnlStatsContainer.Controls.Add(Me.pnlPCStat)
        Me.pnlStatsContainer.Controls.Add(Me.pnlBillStat)
        Me.pnlStatsContainer.Location = New System.Drawing.Point(27, 78)
        Me.pnlStatsContainer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlStatsContainer.Name = "pnlStatsContainer"
        Me.pnlStatsContainer.Size = New System.Drawing.Size(1047, 130)
        Me.pnlStatsContainer.TabIndex = 1
        '
        'pnlSalesStat
        '
        Me.pnlSalesStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlSalesStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalesStat.Controls.Add(Me.lblSalesValue)
        Me.pnlSalesStat.Controls.Add(Me.lblSalesTitle)
        Me.pnlSalesStat.Location = New System.Drawing.Point(7, 6)
        Me.pnlSalesStat.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.pnlSalesStat.Name = "pnlSalesStat"
        Me.pnlSalesStat.Size = New System.Drawing.Size(334, 105)
        Me.pnlSalesStat.TabIndex = 0
        '
        'lblSalesValue
        '
        Me.lblSalesValue.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalesValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblSalesValue.Location = New System.Drawing.Point(13, 39)
        Me.lblSalesValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalesValue.Name = "lblSalesValue"
        Me.lblSalesValue.Size = New System.Drawing.Size(267, 46)
        Me.lblSalesValue.TabIndex = 1
        Me.lblSalesValue.Text = "₱ 0.00"
        '
        'lblSalesTitle
        '
        Me.lblSalesTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblSalesTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSalesTitle.Location = New System.Drawing.Point(17, 6)
        Me.lblSalesTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalesTitle.Name = "lblSalesTitle"
        Me.lblSalesTitle.Size = New System.Drawing.Size(193, 33)
        Me.lblSalesTitle.TabIndex = 0
        Me.lblSalesTitle.Text = "Today's Total Sales"
        '
        'pnlPCStat
        '
        Me.pnlPCStat.BackColor = System.Drawing.Color.White
        Me.pnlPCStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPCStat.Controls.Add(Me.lblPCValue)
        Me.pnlPCStat.Controls.Add(Me.lblPCTitle)
        Me.pnlPCStat.Location = New System.Drawing.Point(355, 6)
        Me.pnlPCStat.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.pnlPCStat.Name = "pnlPCStat"
        Me.pnlPCStat.Size = New System.Drawing.Size(334, 105)
        Me.pnlPCStat.TabIndex = 1
        '
        'lblPCValue
        '
        Me.lblPCValue.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblPCValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblPCValue.Location = New System.Drawing.Point(13, 39)
        Me.lblPCValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPCValue.Name = "lblPCValue"
        Me.lblPCValue.Size = New System.Drawing.Size(267, 46)
        Me.lblPCValue.TabIndex = 1
        Me.lblPCValue.Text = "0"
        '
        'lblPCTitle
        '
        Me.lblPCTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblPCTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblPCTitle.Location = New System.Drawing.Point(17, 13)
        Me.lblPCTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPCTitle.Name = "lblPCTitle"
        Me.lblPCTitle.Size = New System.Drawing.Size(167, 20)
        Me.lblPCTitle.TabIndex = 0
        Me.lblPCTitle.Text = "Active Computers"
        '
        'pnlBillStat
        '
        Me.pnlBillStat.BackColor = System.Drawing.Color.White
        Me.pnlBillStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBillStat.Controls.Add(Me.lblBillValue)
        Me.pnlBillStat.Controls.Add(Me.lblBillTitle)
        Me.pnlBillStat.Location = New System.Drawing.Point(703, 6)
        Me.pnlBillStat.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.pnlBillStat.Name = "pnlBillStat"
        Me.pnlBillStat.Size = New System.Drawing.Size(334, 105)
        Me.pnlBillStat.TabIndex = 2
        '
        'lblBillValue
        '
        Me.lblBillValue.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBillValue.Location = New System.Drawing.Point(13, 39)
        Me.lblBillValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBillValue.Name = "lblBillValue"
        Me.lblBillValue.Size = New System.Drawing.Size(267, 46)
        Me.lblBillValue.TabIndex = 1
        Me.lblBillValue.Text = "0"
        '
        'lblBillTitle
        '
        Me.lblBillTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblBillTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblBillTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblBillTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBillTitle.Name = "lblBillTitle"
        Me.lblBillTitle.Size = New System.Drawing.Size(167, 20)
        Me.lblBillTitle.TabIndex = 0
        Me.lblBillTitle.Text = "Pending Replacements"
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(27, 26)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(467, 39)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome back, Admin!"
        '
        'AdminFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 729)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AdminFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard - Pacita Computer Shop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlStatsContainer.ResumeLayout(False)
        Me.pnlSalesStat.ResumeLayout(False)
        Me.pnlPCStat.ResumeLayout(False)
        Me.pnlBillStat.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAnalytics As Button
    Friend WithEvents btnMonitoring As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents lblLogo As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlStatsContainer As FlowLayoutPanel
    Friend WithEvents pnlSalesStat As Panel
    Friend WithEvents lblSalesValue As Label
    Friend WithEvents lblSalesTitle As Label
    Friend WithEvents pnlPCStat As Panel
    Friend WithEvents lblPCValue As Label
    Friend WithEvents lblPCTitle As Label
    Friend WithEvents pnlBillStat As Panel
    Friend WithEvents lblBillValue As Label
    Friend WithEvents lblBillTitle As Label
End Class
