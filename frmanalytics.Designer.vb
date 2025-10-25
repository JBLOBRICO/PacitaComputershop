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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Dashboard Panels
    Friend WithEvents pnlOverview As Panel
    Friend WithEvents cardTotalPCs As Panel
    Friend WithEvents lblTotalPCsTitle As Label
    Friend WithEvents lblTotalPCs As Label
    Friend WithEvents cardAvailablePCs As Panel
    Friend WithEvents lblAvailablePCsTitle As Label
    Friend WithEvents lblAvailablePCs As Label
    Friend WithEvents cardInUsePCs As Panel
    Friend WithEvents lblInUsePCsTitle As Label
    Friend WithEvents lblInUsePCs As Label
    Friend WithEvents cardPendingApprovals As Panel
    Friend WithEvents lblPendingApprovalsTitle As Label
    Friend WithEvents lblPendingApprovals As Label
    Friend WithEvents cardPendingBilling As Panel
    Friend WithEvents lblPendingBillingTitle As Label
    Friend WithEvents lblPendingBilling As Label

    'Charts Panel
    Friend WithEvents pnlCharts As Panel
    Friend WithEvents chartRevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartDailySessions As DataVisualization.Charting.Chart
    Friend WithEvents chartPCUsage As DataVisualization.Charting.Chart
    Friend WithEvents chartTopPCs As DataVisualization.Charting.Chart
    Friend WithEvents chartTopUsers As DataVisualization.Charting.Chart

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlOverview = New System.Windows.Forms.Panel()
        Me.cardTotalPCs = New System.Windows.Forms.Panel()
        Me.lblTotalPCsTitle = New System.Windows.Forms.Label()
        Me.lblTotalPCs = New System.Windows.Forms.Label()
        Me.cardAvailablePCs = New System.Windows.Forms.Panel()
        Me.lblAvailablePCsTitle = New System.Windows.Forms.Label()
        Me.lblAvailablePCs = New System.Windows.Forms.Label()
        Me.cardInUsePCs = New System.Windows.Forms.Panel()
        Me.lblInUsePCsTitle = New System.Windows.Forms.Label()
        Me.lblInUsePCs = New System.Windows.Forms.Label()
        Me.cardPendingApprovals = New System.Windows.Forms.Panel()
        Me.lblPendingApprovalsTitle = New System.Windows.Forms.Label()
        Me.lblPendingApprovals = New System.Windows.Forms.Label()
        Me.cardPendingBilling = New System.Windows.Forms.Panel()
        Me.lblPendingBillingTitle = New System.Windows.Forms.Label()
        Me.lblPendingBilling = New System.Windows.Forms.Label()
        Me.pnlCharts = New System.Windows.Forms.Panel()
        Me.chartRevenue = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartDailySessions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartPCUsage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartTopPCs = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartTopUsers = New System.Windows.Forms.DataVisualization.Charting.Chart()

        ' --- pnlOverview ---
        Me.pnlOverview.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOverview.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlOverview.Size = New System.Drawing.Size(1200, 150)

        ' --- Cards setup ---
        SetupCard(cardTotalPCs, lblTotalPCsTitle, lblTotalPCs, "Total PCs", Color.FromArgb(60, 130, 200), 10)
        SetupCard(cardAvailablePCs, lblAvailablePCsTitle, lblAvailablePCs, "Available PCs", Color.FromArgb(50, 200, 100), 200)
        SetupCard(cardInUsePCs, lblInUsePCsTitle, lblInUsePCs, "In Use PCs", Color.Orange, 390)
        SetupCard(cardPendingApprovals, lblPendingApprovalsTitle, lblPendingApprovals, "Pending Approvals", Color.Red, 580)
        SetupCard(cardPendingBilling, lblPendingBillingTitle, lblPendingBilling, "Pending Billing", Color.Purple, 770)

        Me.pnlOverview.Controls.AddRange({cardTotalPCs, cardAvailablePCs, cardInUsePCs, cardPendingApprovals, cardPendingBilling})

        ' --- pnlCharts ---
        Me.pnlCharts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCharts.AutoScroll = True
        Me.pnlCharts.Padding = New Padding(10)
        Me.pnlCharts.Controls.AddRange({chartRevenue, chartDailySessions, chartPCUsage, chartTopPCs, chartTopUsers})

        ' --- Charts default size ---
        For Each c In {chartRevenue, chartDailySessions, chartPCUsage, chartTopPCs, chartTopUsers}
            c.Size = New System.Drawing.Size(1150, 300)
            c.Dock = DockStyle.Top
        Next

        ' --- Form ---
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.pnlCharts)
        Me.Controls.Add(Me.pnlOverview)
        Me.Text = "Analytics Dashboard"
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SetupCard(card As Panel, lblTitle As Label, lblValue As Label, titleText As String, backColor As Color, leftPos As Integer)
        card.BackColor = backColor
        card.Size = New Size(180, 120)
        card.Left = leftPos

        lblTitle.Text = titleText
        lblTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(10, 10)
        lblTitle.AutoSize = True

        lblValue.Text = "0"
        lblValue.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblValue.ForeColor = Color.White
        lblValue.Location = New Point(10, 40)
        lblValue.AutoSize = True

        card.Controls.Add(lblTitle)
        card.Controls.Add(lblValue)
    End Sub

End Class
