<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ownerdashboardfrm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Overview Controls
    Friend WithEvents pnlOverview As Panel
    Friend WithEvents cardTotalPCs As Panel
    Friend WithEvents lblTotalPCsTitle As Label
    Friend WithEvents lblTotalPCs As Label
    Friend WithEvents cardAvailablePCs As Panel
    Friend WithEvents lblAvailableTitle As Label
    Friend WithEvents lblAvailablePCs As Label
    Friend WithEvents cardPending As Panel
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents lblPendingApprovals As Label

    'Charts Panel
    Friend WithEvents pnlCharts As Panel
    Friend WithEvents chartRevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartPCUsage As DataVisualization.Charting.Chart
    Friend WithEvents chartTopPCs As DataVisualization.Charting.Chart
    Friend WithEvents chartTopUsers As DataVisualization.Charting.Chart

    'Chart Labels
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblPCUsage As Label
    Friend WithEvents lblTopPCs As Label
    Friend WithEvents lblTopUsers As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As New System.Windows.Forms.DataVisualization.Charting.Series()

        Me.pnlOverview = New Panel()
        Me.cardTotalPCs = New Panel()
        Me.lblTotalPCsTitle = New Label()
        Me.lblTotalPCs = New Label()
        Me.cardAvailablePCs = New Panel()
        Me.lblAvailableTitle = New Label()
        Me.lblAvailablePCs = New Label()
        Me.cardPending = New Panel()
        Me.lblPendingTitle = New Label()
        Me.lblPendingApprovals = New Label()
        Me.pnlCharts = New Panel()
        Me.chartRevenue = New DataVisualization.Charting.Chart()
        Me.lblRevenue = New Label()
        Me.chartPCUsage = New DataVisualization.Charting.Chart()
        Me.lblPCUsage = New Label()
        Me.chartTopPCs = New DataVisualization.Charting.Chart()
        Me.lblTopPCs = New Label()
        Me.chartTopUsers = New DataVisualization.Charting.Chart()
        Me.lblTopUsers = New Label()

        Me.pnlOverview.SuspendLayout()
        Me.cardTotalPCs.SuspendLayout()
        Me.cardAvailablePCs.SuspendLayout()
        Me.cardPending.SuspendLayout()
        Me.pnlCharts.SuspendLayout()
        CType(Me.chartRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartPCUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartTopPCs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartTopUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '---------------------------------
        ' pnlOverview
        '---------------------------------
        Me.pnlOverview.BackColor = Color.WhiteSmoke
        Me.pnlOverview.Controls.Add(Me.cardTotalPCs)
        Me.pnlOverview.Controls.Add(Me.cardAvailablePCs)
        Me.pnlOverview.Controls.Add(Me.cardPending)
        Me.pnlOverview.Dock = DockStyle.Top
        Me.pnlOverview.Size = New Size(1245, 150)

        'cardTotalPCs
        Me.cardTotalPCs.BackColor = Color.FromArgb(60, 130, 200)
        Me.cardTotalPCs.Controls.Add(Me.lblTotalPCsTitle)
        Me.cardTotalPCs.Controls.Add(Me.lblTotalPCs)
        Me.cardTotalPCs.Location = New Point(20, 15)
        Me.cardTotalPCs.Size = New Size(200, 120)

        Me.lblTotalPCsTitle.Text = "Total PCs"
        Me.lblTotalPCsTitle.ForeColor = Color.White
        Me.lblTotalPCsTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblTotalPCsTitle.Location = New Point(10, 10)
        Me.lblTotalPCsTitle.Size = New Size(100, 23)

        Me.lblTotalPCs.Text = "0"
        Me.lblTotalPCs.ForeColor = Color.White
        Me.lblTotalPCs.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblTotalPCs.Location = New Point(10, 40)
        Me.lblTotalPCs.Size = New Size(100, 40)

        'cardAvailablePCs
        Me.cardAvailablePCs.BackColor = Color.FromArgb(50, 200, 100)
        Me.cardAvailablePCs.Controls.Add(Me.lblAvailableTitle)
        Me.cardAvailablePCs.Controls.Add(Me.lblAvailablePCs)
        Me.cardAvailablePCs.Location = New Point(240, 15)
        Me.cardAvailablePCs.Size = New Size(200, 120)

        Me.lblAvailableTitle.Text = "Available PCs"
        Me.lblAvailableTitle.ForeColor = Color.White
        Me.lblAvailableTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblAvailableTitle.Location = New Point(10, 10)
        Me.lblAvailableTitle.Size = New Size(100, 23)

        Me.lblAvailablePCs.Text = "0"
        Me.lblAvailablePCs.ForeColor = Color.White
        Me.lblAvailablePCs.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblAvailablePCs.Location = New Point(10, 40)
        Me.lblAvailablePCs.Size = New Size(100, 40)

        'cardPending
        Me.cardPending.BackColor = Color.OrangeRed
        Me.cardPending.Controls.Add(Me.lblPendingTitle)
        Me.cardPending.Controls.Add(Me.lblPendingApprovals)
        Me.cardPending.Location = New Point(460, 15)
        Me.cardPending.Size = New Size(200, 120)

        Me.lblPendingTitle.Text = "Pending Approvals"
        Me.lblPendingTitle.ForeColor = Color.White
        Me.lblPendingTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblPendingTitle.Location = New Point(10, 10)
        Me.lblPendingTitle.Size = New Size(150, 23)

        Me.lblPendingApprovals.Text = "0"
        Me.lblPendingApprovals.ForeColor = Color.White
        Me.lblPendingApprovals.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblPendingApprovals.Location = New Point(10, 40)
        Me.lblPendingApprovals.Size = New Size(100, 40)

        '---------------------------------
        ' pnlCharts
        '---------------------------------
        Me.pnlCharts.AutoScroll = True
        Me.pnlCharts.Padding = New Padding(10)
        Me.pnlCharts.Dock = DockStyle.Fill

        ' Chart Top Users
        ChartArea4.Name = "TopUsersArea"
        Me.chartTopUsers.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chartTopUsers.Legends.Add(Legend4)
        Series4.Name = "TopUsers"
        Series4.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Series4.ChartArea = "TopUsersArea"
        Series4.Legend = "Legend1"
        Me.chartTopUsers.Series.Add(Series4)
        Me.chartTopUsers.Dock = DockStyle.Top
        Me.chartTopUsers.Height = 200
        Me.chartTopUsers.Margin = New Padding(0, 0, 0, 20)

        Me.lblTopUsers.Text = "Top 5 Active Users"
        Me.lblTopUsers.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblTopUsers.Dock = DockStyle.Top
        Me.lblTopUsers.Height = 30
        Me.lblTopUsers.Margin = New Padding(0, 0, 0, 10)
        Me.lblTopUsers.TextAlign = ContentAlignment.MiddleLeft

        ' Chart Top PCs
        ChartArea3.Name = "TopPCsArea"
        Me.chartTopPCs.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartTopPCs.Legends.Add(Legend3)
        Series3.Name = "TopPCs"
        Series3.ChartType = DataVisualization.Charting.SeriesChartType.Column
        Series3.ChartArea = "TopPCsArea"
        Series3.Legend = "Legend1"
        Me.chartTopPCs.Series.Add(Series3)
        Me.chartTopPCs.Dock = DockStyle.Top
        Me.chartTopPCs.Height = 200
        Me.chartTopPCs.Margin = New Padding(0, 0, 0, 20)

        Me.lblTopPCs.Text = "Top 5 PCs by Usage"
        Me.lblTopPCs.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblTopPCs.Dock = DockStyle.Top
        Me.lblTopPCs.Height = 30
        Me.lblTopPCs.Margin = New Padding(0, 0, 0, 10)
        Me.lblTopPCs.TextAlign = ContentAlignment.MiddleLeft

        ' Chart PC Usage
        ChartArea2.Name = "PCUsageArea"
        Me.chartPCUsage.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartPCUsage.Legends.Add(Legend2)
        Series2.Name = "PCUsage"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series2.ChartArea = "PCUsageArea"
        Series2.Legend = "Legend1"
        Me.chartPCUsage.Series.Add(Series2)
        Me.chartPCUsage.Dock = DockStyle.Top
        Me.chartPCUsage.Height = 200
        Me.chartPCUsage.Margin = New Padding(0, 0, 0, 20)

        Me.lblPCUsage.Text = "PC Usage Status"
        Me.lblPCUsage.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblPCUsage.Dock = DockStyle.Top
        Me.lblPCUsage.Height = 30
        Me.lblPCUsage.Margin = New Padding(0, 0, 0, 10)
        Me.lblPCUsage.TextAlign = ContentAlignment.MiddleLeft

        ' Chart Revenue
        ChartArea1.Name = "RevenueArea"
        Me.chartRevenue.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartRevenue.Legends.Add(Legend1)
        Series1.Name = "Revenue"
        Series1.ChartArea = "RevenueArea"
        Series1.Legend = "Legend1"
        Me.chartRevenue.Series.Add(Series1)
        Me.chartRevenue.Dock = DockStyle.Top
        Me.chartRevenue.Height = 200
        Me.chartRevenue.Margin = New Padding(0, 0, 0, 20)

        Me.lblRevenue.Text = "Daily Revenue"
        Me.lblRevenue.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblRevenue.Dock = DockStyle.Top
        Me.lblRevenue.Height = 30
        Me.lblRevenue.Margin = New Padding(0, 0, 0, 10)
        Me.lblRevenue.TextAlign = ContentAlignment.MiddleLeft

        ' Add charts and labels in reverse order (so they stack properly)
        Me.pnlCharts.Controls.Add(Me.chartRevenue)
        Me.pnlCharts.Controls.Add(Me.lblRevenue)
        Me.pnlCharts.Controls.Add(Me.chartPCUsage)
        Me.pnlCharts.Controls.Add(Me.lblPCUsage)
        Me.pnlCharts.Controls.Add(Me.chartTopPCs)
        Me.pnlCharts.Controls.Add(Me.lblTopPCs)
        Me.pnlCharts.Controls.Add(Me.chartTopUsers)
        Me.pnlCharts.Controls.Add(Me.lblTopUsers)

        '---------------------------------
        ' ownerdashboardfrm
        '---------------------------------
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1245, 800)
        Me.Controls.Add(Me.pnlCharts)
        Me.Controls.Add(Me.pnlOverview)
        Me.Name = "ownerdashboardfrm"
        Me.Text = "Owner Dashboard - Overview"
        Me.WindowState = FormWindowState.Maximized

        Me.pnlOverview.ResumeLayout(False)
        Me.cardTotalPCs.ResumeLayout(False)
        Me.cardAvailablePCs.ResumeLayout(False)
        Me.cardPending.ResumeLayout(False)
        Me.pnlCharts.ResumeLayout(False)
        CType(Me.chartRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPCUsage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartTopPCs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartTopUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
