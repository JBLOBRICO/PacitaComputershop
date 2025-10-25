<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmanalytics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenueTitle = New System.Windows.Forms.Label()
        Me.lblRevenueDesc = New System.Windows.Forms.Label()
        Me.chartRevenue = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlSessions = New System.Windows.Forms.Panel()
        Me.lblSessionsTitle = New System.Windows.Forms.Label()
        Me.lblSessionsDesc = New System.Windows.Forms.Label()
        Me.chartSessions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlPCStatus = New System.Windows.Forms.Panel()
        Me.lblPCStatusTitle = New System.Windows.Forms.Label()
        Me.lblPCStatusDesc = New System.Windows.Forms.Label()
        Me.chartPCStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlBilling = New System.Windows.Forms.Panel()
        Me.lblBillingTitle = New System.Windows.Forms.Label()
        Me.lblBillingDesc = New System.Windows.Forms.Label()
        Me.chartBilling = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlReplacement = New System.Windows.Forms.Panel()
        Me.lblReplacementTitle = New System.Windows.Forms.Label()
        Me.lblReplacementDesc = New System.Windows.Forms.Label()
        Me.chartReplacement = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlSales = New System.Windows.Forms.Panel()
        Me.lblSalesTitle = New System.Windows.Forms.Label()
        Me.lblSalesDesc = New System.Windows.Forms.Label()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlUserRoles = New System.Windows.Forms.Panel()
        Me.lblUserRolesTitle = New System.Windows.Forms.Label()
        Me.lblUserRolesDesc = New System.Windows.Forms.Label()
        Me.chartUserRoles = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTopUsers = New System.Windows.Forms.Panel()
        Me.lblTopUsersTitle = New System.Windows.Forms.Label()
        Me.lblTopUsersDesc = New System.Windows.Forms.Label()
        Me.chartTopUsers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTopPCs = New System.Windows.Forms.Panel()
        Me.lblTopPCsTitle = New System.Windows.Forms.Label()
        Me.lblTopPCsDesc = New System.Windows.Forms.Label()
        Me.chartTopPCs = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlPCUsage = New System.Windows.Forms.Panel()
        Me.lblPCUsageTitle = New System.Windows.Forms.Label()
        Me.lblPCUsageDesc = New System.Windows.Forms.Label()
        Me.chartPCUsage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlMain.SuspendLayout()
        Me.pnlRevenue.SuspendLayout()
        CType(Me.chartRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSessions.SuspendLayout()
        CType(Me.chartSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPCStatus.SuspendLayout()
        CType(Me.chartPCStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBilling.SuspendLayout()
        CType(Me.chartBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReplacement.SuspendLayout()
        CType(Me.chartReplacement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSales.SuspendLayout()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserRoles.SuspendLayout()
        CType(Me.chartUserRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopUsers.SuspendLayout()
        CType(Me.chartTopUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopPCs.SuspendLayout()
        CType(Me.chartTopPCs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPCUsage.SuspendLayout()
        CType(Me.chartPCUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMain.Controls.Add(Me.pnlRevenue)
        Me.pnlMain.Controls.Add(Me.pnlSessions)
        Me.pnlMain.Controls.Add(Me.pnlPCStatus)
        Me.pnlMain.Controls.Add(Me.pnlBilling)
        Me.pnlMain.Controls.Add(Me.pnlReplacement)
        Me.pnlMain.Controls.Add(Me.pnlSales)
        Me.pnlMain.Controls.Add(Me.pnlUserRoles)
        Me.pnlMain.Controls.Add(Me.pnlTopUsers)
        Me.pnlMain.Controls.Add(Me.pnlTopPCs)
        Me.pnlMain.Controls.Add(Me.pnlPCUsage)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(13, 11, 13, 11)
        Me.pnlMain.Size = New System.Drawing.Size(814, 563)
        Me.pnlMain.TabIndex = 0
        '
        'pnlRevenue
        '
        Me.pnlRevenue.BackColor = System.Drawing.Color.White
        Me.pnlRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRevenue.Controls.Add(Me.lblRevenueTitle)
        Me.pnlRevenue.Controls.Add(Me.lblRevenueDesc)
        Me.pnlRevenue.Controls.Add(Me.chartRevenue)
        Me.pnlRevenue.Location = New System.Drawing.Point(16, 14)
        Me.pnlRevenue.Name = "pnlRevenue"
        Me.pnlRevenue.Size = New System.Drawing.Size(386, 174)
        Me.pnlRevenue.TabIndex = 0
        '
        'lblRevenueTitle
        '
        Me.lblRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenueTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblRevenueTitle.Name = "lblRevenueTitle"
        Me.lblRevenueTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblRevenueTitle.TabIndex = 0
        Me.lblRevenueTitle.Text = "Daily Revenue"
        '
        'lblRevenueDesc
        '
        Me.lblRevenueDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblRevenueDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblRevenueDesc.Name = "lblRevenueDesc"
        Me.lblRevenueDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblRevenueDesc.TabIndex = 1
        Me.lblRevenueDesc.Text = "Total daily revenue."
        '
        'chartRevenue
        '
        Me.chartRevenue.Location = New System.Drawing.Point(9, 43)
        Me.chartRevenue.Name = "chartRevenue"
        Me.chartRevenue.Size = New System.Drawing.Size(369, 130)
        Me.chartRevenue.TabIndex = 2
        '
        'pnlSessions
        '
        Me.pnlSessions.BackColor = System.Drawing.Color.White
        Me.pnlSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSessions.Controls.Add(Me.lblSessionsTitle)
        Me.pnlSessions.Controls.Add(Me.lblSessionsDesc)
        Me.pnlSessions.Controls.Add(Me.chartSessions)
        Me.pnlSessions.Location = New System.Drawing.Point(16, 194)
        Me.pnlSessions.Name = "pnlSessions"
        Me.pnlSessions.Size = New System.Drawing.Size(386, 174)
        Me.pnlSessions.TabIndex = 1
        '
        'lblSessionsTitle
        '
        Me.lblSessionsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessionsTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblSessionsTitle.Name = "lblSessionsTitle"
        Me.lblSessionsTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblSessionsTitle.TabIndex = 0
        Me.lblSessionsTitle.Text = "Daily Sessions"
        '
        'lblSessionsDesc
        '
        Me.lblSessionsDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblSessionsDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblSessionsDesc.Name = "lblSessionsDesc"
        Me.lblSessionsDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblSessionsDesc.TabIndex = 1
        Me.lblSessionsDesc.Text = "Number of daily sessions."
        '
        'chartSessions
        '
        Me.chartSessions.Location = New System.Drawing.Point(9, 43)
        Me.chartSessions.Name = "chartSessions"
        Me.chartSessions.Size = New System.Drawing.Size(369, 130)
        Me.chartSessions.TabIndex = 2
        '
        'pnlPCStatus
        '
        Me.pnlPCStatus.BackColor = System.Drawing.Color.White
        Me.pnlPCStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPCStatus.Controls.Add(Me.lblPCStatusTitle)
        Me.pnlPCStatus.Controls.Add(Me.lblPCStatusDesc)
        Me.pnlPCStatus.Controls.Add(Me.chartPCStatus)
        Me.pnlPCStatus.Location = New System.Drawing.Point(16, 374)
        Me.pnlPCStatus.Name = "pnlPCStatus"
        Me.pnlPCStatus.Size = New System.Drawing.Size(386, 174)
        Me.pnlPCStatus.TabIndex = 2
        '
        'lblPCStatusTitle
        '
        Me.lblPCStatusTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPCStatusTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblPCStatusTitle.Name = "lblPCStatusTitle"
        Me.lblPCStatusTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblPCStatusTitle.TabIndex = 0
        Me.lblPCStatusTitle.Text = "PC Status Distribution"
        '
        'lblPCStatusDesc
        '
        Me.lblPCStatusDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblPCStatusDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblPCStatusDesc.Name = "lblPCStatusDesc"
        Me.lblPCStatusDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblPCStatusDesc.TabIndex = 1
        Me.lblPCStatusDesc.Text = "PCs by status."
        '
        'chartPCStatus
        '
        Me.chartPCStatus.Location = New System.Drawing.Point(9, 43)
        Me.chartPCStatus.Name = "chartPCStatus"
        Me.chartPCStatus.Size = New System.Drawing.Size(369, 130)
        Me.chartPCStatus.TabIndex = 2
        '
        'pnlBilling
        '
        Me.pnlBilling.BackColor = System.Drawing.Color.White
        Me.pnlBilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBilling.Controls.Add(Me.lblBillingTitle)
        Me.pnlBilling.Controls.Add(Me.lblBillingDesc)
        Me.pnlBilling.Controls.Add(Me.chartBilling)
        Me.pnlBilling.Location = New System.Drawing.Point(16, 554)
        Me.pnlBilling.Name = "pnlBilling"
        Me.pnlBilling.Size = New System.Drawing.Size(386, 174)
        Me.pnlBilling.TabIndex = 3
        '
        'lblBillingTitle
        '
        Me.lblBillingTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillingTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblBillingTitle.Name = "lblBillingTitle"
        Me.lblBillingTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblBillingTitle.TabIndex = 0
        Me.lblBillingTitle.Text = "Billing Status"
        '
        'lblBillingDesc
        '
        Me.lblBillingDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblBillingDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblBillingDesc.Name = "lblBillingDesc"
        Me.lblBillingDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblBillingDesc.TabIndex = 1
        Me.lblBillingDesc.Text = "Pending vs Paid bills."
        '
        'chartBilling
        '
        Me.chartBilling.Location = New System.Drawing.Point(9, 43)
        Me.chartBilling.Name = "chartBilling"
        Me.chartBilling.Size = New System.Drawing.Size(369, 130)
        Me.chartBilling.TabIndex = 2
        '
        'pnlReplacement
        '
        Me.pnlReplacement.BackColor = System.Drawing.Color.White
        Me.pnlReplacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReplacement.Controls.Add(Me.lblReplacementTitle)
        Me.pnlReplacement.Controls.Add(Me.lblReplacementDesc)
        Me.pnlReplacement.Controls.Add(Me.chartReplacement)
        Me.pnlReplacement.Location = New System.Drawing.Point(16, 734)
        Me.pnlReplacement.Name = "pnlReplacement"
        Me.pnlReplacement.Size = New System.Drawing.Size(386, 174)
        Me.pnlReplacement.TabIndex = 4
        '
        'lblReplacementTitle
        '
        Me.lblReplacementTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblReplacementTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblReplacementTitle.Name = "lblReplacementTitle"
        Me.lblReplacementTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblReplacementTitle.TabIndex = 0
        Me.lblReplacementTitle.Text = "Replacement Requests"
        '
        'lblReplacementDesc
        '
        Me.lblReplacementDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblReplacementDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblReplacementDesc.Name = "lblReplacementDesc"
        Me.lblReplacementDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblReplacementDesc.TabIndex = 1
        Me.lblReplacementDesc.Text = "Replacement requests status."
        '
        'chartReplacement
        '
        Me.chartReplacement.Location = New System.Drawing.Point(9, 43)
        Me.chartReplacement.Name = "chartReplacement"
        Me.chartReplacement.Size = New System.Drawing.Size(369, 130)
        Me.chartReplacement.TabIndex = 2
        '
        'pnlSales
        '
        Me.pnlSales.BackColor = System.Drawing.Color.White
        Me.pnlSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSales.Controls.Add(Me.lblSalesTitle)
        Me.pnlSales.Controls.Add(Me.lblSalesDesc)
        Me.pnlSales.Controls.Add(Me.chartSales)
        Me.pnlSales.Location = New System.Drawing.Point(16, 914)
        Me.pnlSales.Name = "pnlSales"
        Me.pnlSales.Size = New System.Drawing.Size(386, 174)
        Me.pnlSales.TabIndex = 5
        '
        'lblSalesTitle
        '
        Me.lblSalesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalesTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblSalesTitle.Name = "lblSalesTitle"
        Me.lblSalesTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblSalesTitle.TabIndex = 0
        Me.lblSalesTitle.Text = "Sales Payment Status"
        '
        'lblSalesDesc
        '
        Me.lblSalesDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblSalesDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblSalesDesc.Name = "lblSalesDesc"
        Me.lblSalesDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblSalesDesc.TabIndex = 1
        Me.lblSalesDesc.Text = "Paid vs Unpaid sales."
        '
        'chartSales
        '
        Me.chartSales.Location = New System.Drawing.Point(9, 43)
        Me.chartSales.Name = "chartSales"
        Me.chartSales.Size = New System.Drawing.Size(369, 130)
        Me.chartSales.TabIndex = 2
        '
        'pnlUserRoles
        '
        Me.pnlUserRoles.BackColor = System.Drawing.Color.White
        Me.pnlUserRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserRoles.Controls.Add(Me.lblUserRolesTitle)
        Me.pnlUserRoles.Controls.Add(Me.lblUserRolesDesc)
        Me.pnlUserRoles.Controls.Add(Me.chartUserRoles)
        Me.pnlUserRoles.Location = New System.Drawing.Point(16, 1094)
        Me.pnlUserRoles.Name = "pnlUserRoles"
        Me.pnlUserRoles.Size = New System.Drawing.Size(386, 174)
        Me.pnlUserRoles.TabIndex = 6
        '
        'lblUserRolesTitle
        '
        Me.lblUserRolesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserRolesTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblUserRolesTitle.Name = "lblUserRolesTitle"
        Me.lblUserRolesTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblUserRolesTitle.TabIndex = 0
        Me.lblUserRolesTitle.Text = "User Role Distribution"
        '
        'lblUserRolesDesc
        '
        Me.lblUserRolesDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblUserRolesDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblUserRolesDesc.Name = "lblUserRolesDesc"
        Me.lblUserRolesDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblUserRolesDesc.TabIndex = 1
        Me.lblUserRolesDesc.Text = "Users per role."
        '
        'chartUserRoles
        '
        Me.chartUserRoles.Location = New System.Drawing.Point(9, 43)
        Me.chartUserRoles.Name = "chartUserRoles"
        Me.chartUserRoles.Size = New System.Drawing.Size(369, 130)
        Me.chartUserRoles.TabIndex = 2
        '
        'pnlTopUsers
        '
        Me.pnlTopUsers.BackColor = System.Drawing.Color.White
        Me.pnlTopUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTopUsers.Controls.Add(Me.lblTopUsersTitle)
        Me.pnlTopUsers.Controls.Add(Me.lblTopUsersDesc)
        Me.pnlTopUsers.Controls.Add(Me.chartTopUsers)
        Me.pnlTopUsers.Location = New System.Drawing.Point(16, 1274)
        Me.pnlTopUsers.Name = "pnlTopUsers"
        Me.pnlTopUsers.Size = New System.Drawing.Size(386, 174)
        Me.pnlTopUsers.TabIndex = 7
        '
        'lblTopUsersTitle
        '
        Me.lblTopUsersTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTopUsersTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblTopUsersTitle.Name = "lblTopUsersTitle"
        Me.lblTopUsersTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblTopUsersTitle.TabIndex = 0
        Me.lblTopUsersTitle.Text = "Top Active Users"
        '
        'lblTopUsersDesc
        '
        Me.lblTopUsersDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblTopUsersDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblTopUsersDesc.Name = "lblTopUsersDesc"
        Me.lblTopUsersDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblTopUsersDesc.TabIndex = 1
        Me.lblTopUsersDesc.Text = "Top 5 active users."
        '
        'chartTopUsers
        '
        Me.chartTopUsers.Location = New System.Drawing.Point(9, 43)
        Me.chartTopUsers.Name = "chartTopUsers"
        Me.chartTopUsers.Size = New System.Drawing.Size(369, 130)
        Me.chartTopUsers.TabIndex = 2
        '
        'pnlTopPCs
        '
        Me.pnlTopPCs.BackColor = System.Drawing.Color.White
        Me.pnlTopPCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTopPCs.Controls.Add(Me.lblTopPCsTitle)
        Me.pnlTopPCs.Controls.Add(Me.lblTopPCsDesc)
        Me.pnlTopPCs.Controls.Add(Me.chartTopPCs)
        Me.pnlTopPCs.Location = New System.Drawing.Point(16, 1454)
        Me.pnlTopPCs.Name = "pnlTopPCs"
        Me.pnlTopPCs.Size = New System.Drawing.Size(386, 174)
        Me.pnlTopPCs.TabIndex = 8
        '
        'lblTopPCsTitle
        '
        Me.lblTopPCsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTopPCsTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblTopPCsTitle.Name = "lblTopPCsTitle"
        Me.lblTopPCsTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblTopPCsTitle.TabIndex = 0
        Me.lblTopPCsTitle.Text = "Top Used PCs"
        '
        'lblTopPCsDesc
        '
        Me.lblTopPCsDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblTopPCsDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblTopPCsDesc.Name = "lblTopPCsDesc"
        Me.lblTopPCsDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblTopPCsDesc.TabIndex = 1
        Me.lblTopPCsDesc.Text = "Top 5 PCs by usage."
        '
        'chartTopPCs
        '
        Me.chartTopPCs.Location = New System.Drawing.Point(9, 43)
        Me.chartTopPCs.Name = "chartTopPCs"
        Me.chartTopPCs.Size = New System.Drawing.Size(369, 130)
        Me.chartTopPCs.TabIndex = 2
        '
        'pnlPCUsage
        '
        Me.pnlPCUsage.BackColor = System.Drawing.Color.White
        Me.pnlPCUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPCUsage.Controls.Add(Me.lblPCUsageTitle)
        Me.pnlPCUsage.Controls.Add(Me.lblPCUsageDesc)
        Me.pnlPCUsage.Controls.Add(Me.chartPCUsage)
        Me.pnlPCUsage.Location = New System.Drawing.Point(16, 1634)
        Me.pnlPCUsage.Name = "pnlPCUsage"
        Me.pnlPCUsage.Size = New System.Drawing.Size(386, 174)
        Me.pnlPCUsage.TabIndex = 9
        '
        'lblPCUsageTitle
        '
        Me.lblPCUsageTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPCUsageTitle.Location = New System.Drawing.Point(9, 4)
        Me.lblPCUsageTitle.Name = "lblPCUsageTitle"
        Me.lblPCUsageTitle.Size = New System.Drawing.Size(171, 20)
        Me.lblPCUsageTitle.TabIndex = 0
        Me.lblPCUsageTitle.Text = "PC Usage Status"
        '
        'lblPCUsageDesc
        '
        Me.lblPCUsageDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblPCUsageDesc.Location = New System.Drawing.Point(9, 26)
        Me.lblPCUsageDesc.Name = "lblPCUsageDesc"
        Me.lblPCUsageDesc.Size = New System.Drawing.Size(343, 17)
        Me.lblPCUsageDesc.TabIndex = 1
        Me.lblPCUsageDesc.Text = "PC status distribution."
        '
        'chartPCUsage
        '
        Me.chartPCUsage.Location = New System.Drawing.Point(9, 43)
        Me.chartPCUsage.Name = "chartPCUsage"
        Me.chartPCUsage.Size = New System.Drawing.Size(369, 130)
        Me.chartPCUsage.TabIndex = 2
        '
        'frmanalytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 563)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmanalytics"
        Me.Text = "Analytics Dashboard"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlRevenue.ResumeLayout(False)
        CType(Me.chartRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSessions.ResumeLayout(False)
        CType(Me.chartSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPCStatus.ResumeLayout(False)
        CType(Me.chartPCStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBilling.ResumeLayout(False)
        CType(Me.chartBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReplacement.ResumeLayout(False)
        CType(Me.chartReplacement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSales.ResumeLayout(False)
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserRoles.ResumeLayout(False)
        CType(Me.chartUserRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopUsers.ResumeLayout(False)
        CType(Me.chartTopUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopPCs.ResumeLayout(False)
        CType(Me.chartTopPCs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPCUsage.ResumeLayout(False)
        CType(Me.chartPCUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As FlowLayoutPanel

    Friend WithEvents pnlRevenue As Panel
    Friend WithEvents lblRevenueTitle As Label
    Friend WithEvents lblRevenueDesc As Label
    Friend WithEvents chartRevenue As DataVisualization.Charting.Chart

    Friend WithEvents pnlSessions As Panel
    Friend WithEvents lblSessionsTitle As Label
    Friend WithEvents lblSessionsDesc As Label
    Friend WithEvents chartSessions As DataVisualization.Charting.Chart

    Friend WithEvents pnlPCStatus As Panel
    Friend WithEvents lblPCStatusTitle As Label
    Friend WithEvents lblPCStatusDesc As Label
    Friend WithEvents chartPCStatus As DataVisualization.Charting.Chart

    Friend WithEvents pnlBilling As Panel
    Friend WithEvents lblBillingTitle As Label
    Friend WithEvents lblBillingDesc As Label
    Friend WithEvents chartBilling As DataVisualization.Charting.Chart

    Friend WithEvents pnlReplacement As Panel
    Friend WithEvents lblReplacementTitle As Label
    Friend WithEvents lblReplacementDesc As Label
    Friend WithEvents chartReplacement As DataVisualization.Charting.Chart

    Friend WithEvents pnlSales As Panel
    Friend WithEvents lblSalesTitle As Label
    Friend WithEvents lblSalesDesc As Label
    Friend WithEvents chartSales As DataVisualization.Charting.Chart

    Friend WithEvents pnlUserRoles As Panel
    Friend WithEvents lblUserRolesTitle As Label
    Friend WithEvents lblUserRolesDesc As Label
    Friend WithEvents chartUserRoles As DataVisualization.Charting.Chart

    Friend WithEvents pnlTopUsers As Panel
    Friend WithEvents lblTopUsersTitle As Label
    Friend WithEvents lblTopUsersDesc As Label
    Friend WithEvents chartTopUsers As DataVisualization.Charting.Chart

    Friend WithEvents pnlTopPCs As Panel
    Friend WithEvents lblTopPCsTitle As Label
    Friend WithEvents lblTopPCsDesc As Label
    Friend WithEvents chartTopPCs As DataVisualization.Charting.Chart

    Friend WithEvents pnlPCUsage As Panel
    Friend WithEvents lblPCUsageTitle As Label
    Friend WithEvents lblPCUsageDesc As Label
    Friend WithEvents chartPCUsage As DataVisualization.Charting.Chart

End Class
