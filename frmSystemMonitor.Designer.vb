<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSystemMonitor
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSummary = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlApprovals = New System.Windows.Forms.Panel()
        Me.lblApprovalsCount = New System.Windows.Forms.Label()
        Me.lblApprovalsTitle = New System.Windows.Forms.Label()
        Me.pnlBilling = New System.Windows.Forms.Panel()
        Me.lblBillingCount = New System.Windows.Forms.Label()
        Me.lblBillingTitle = New System.Windows.Forms.Label()
        Me.pnlSales = New System.Windows.Forms.Panel()
        Me.lblSalesCount = New System.Windows.Forms.Label()
        Me.lblSalesTitle = New System.Windows.Forms.Label()
        Me.pnlReplacements = New System.Windows.Forms.Panel()
        Me.lblReplacementsCount = New System.Windows.Forms.Label()
        Me.lblReplacementsTitle = New System.Windows.Forms.Label()
        Me.dgvActivities = New System.Windows.Forms.DataGridView()
        Me.lblActivityLog = New System.Windows.Forms.Label()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.pnlApprovals.SuspendLayout()
        Me.pnlBilling.SuspendLayout()
        Me.pnlSales.SuspendLayout()
        Me.pnlReplacements.SuspendLayout()
        CType(Me.dgvActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitle)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1414, 49)
        Me.pnlTopBar.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(352, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "📊 System Monitoring Dashboard"
        '
        'pnlSummary
        '
        Me.pnlSummary.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSummary.Controls.Add(Me.pnlApprovals)
        Me.pnlSummary.Controls.Add(Me.pnlBilling)
        Me.pnlSummary.Controls.Add(Me.pnlSales)
        Me.pnlSummary.Controls.Add(Me.pnlReplacements)
        Me.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummary.Location = New System.Drawing.Point(0, 49)
        Me.pnlSummary.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.pnlSummary.Size = New System.Drawing.Size(1414, 114)
        Me.pnlSummary.TabIndex = 2
        '
        'pnlApprovals
        '
        Me.pnlApprovals.BackColor = System.Drawing.Color.White
        Me.pnlApprovals.Controls.Add(Me.lblApprovalsCount)
        Me.pnlApprovals.Controls.Add(Me.lblApprovalsTitle)
        Me.pnlApprovals.Location = New System.Drawing.Point(30, 32)
        Me.pnlApprovals.Margin = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.pnlApprovals.Name = "pnlApprovals"
        Me.pnlApprovals.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.pnlApprovals.Size = New System.Drawing.Size(150, 73)
        Me.pnlApprovals.TabIndex = 0
        '
        'lblApprovalsCount
        '
        Me.lblApprovalsCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblApprovalsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblApprovalsCount.Location = New System.Drawing.Point(8, 24)
        Me.lblApprovalsCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApprovalsCount.Name = "lblApprovalsCount"
        Me.lblApprovalsCount.Size = New System.Drawing.Size(75, 37)
        Me.lblApprovalsCount.TabIndex = 0
        Me.lblApprovalsCount.Text = "0"
        '
        'lblApprovalsTitle
        '
        Me.lblApprovalsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblApprovalsTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblApprovalsTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblApprovalsTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApprovalsTitle.Name = "lblApprovalsTitle"
        Me.lblApprovalsTitle.Size = New System.Drawing.Size(75, 19)
        Me.lblApprovalsTitle.TabIndex = 1
        Me.lblApprovalsTitle.Text = "Total Approvals"
        '
        'pnlBilling
        '
        Me.pnlBilling.BackColor = System.Drawing.Color.White
        Me.pnlBilling.Controls.Add(Me.lblBillingCount)
        Me.pnlBilling.Controls.Add(Me.lblBillingTitle)
        Me.pnlBilling.Location = New System.Drawing.Point(210, 32)
        Me.pnlBilling.Margin = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.pnlBilling.Name = "pnlBilling"
        Me.pnlBilling.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.pnlBilling.Size = New System.Drawing.Size(150, 73)
        Me.pnlBilling.TabIndex = 1
        '
        'lblBillingCount
        '
        Me.lblBillingCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillingCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblBillingCount.Location = New System.Drawing.Point(8, 24)
        Me.lblBillingCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBillingCount.Name = "lblBillingCount"
        Me.lblBillingCount.Size = New System.Drawing.Size(75, 37)
        Me.lblBillingCount.TabIndex = 0
        Me.lblBillingCount.Text = "0"
        '
        'lblBillingTitle
        '
        Me.lblBillingTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBillingTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblBillingTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblBillingTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBillingTitle.Name = "lblBillingTitle"
        Me.lblBillingTitle.Size = New System.Drawing.Size(75, 19)
        Me.lblBillingTitle.TabIndex = 1
        Me.lblBillingTitle.Text = "Billing Requests"
        '
        'pnlSales
        '
        Me.pnlSales.BackColor = System.Drawing.Color.White
        Me.pnlSales.Controls.Add(Me.lblSalesCount)
        Me.pnlSales.Controls.Add(Me.lblSalesTitle)
        Me.pnlSales.Location = New System.Drawing.Point(390, 32)
        Me.pnlSales.Margin = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.pnlSales.Name = "pnlSales"
        Me.pnlSales.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.pnlSales.Size = New System.Drawing.Size(150, 73)
        Me.pnlSales.TabIndex = 2
        '
        'lblSalesCount
        '
        Me.lblSalesCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.lblSalesCount.Location = New System.Drawing.Point(8, 24)
        Me.lblSalesCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalesCount.Name = "lblSalesCount"
        Me.lblSalesCount.Size = New System.Drawing.Size(75, 37)
        Me.lblSalesCount.TabIndex = 0
        Me.lblSalesCount.Text = "0"
        '
        'lblSalesTitle
        '
        Me.lblSalesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSalesTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSalesTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblSalesTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalesTitle.Name = "lblSalesTitle"
        Me.lblSalesTitle.Size = New System.Drawing.Size(75, 19)
        Me.lblSalesTitle.TabIndex = 1
        Me.lblSalesTitle.Text = "Sales Transactions"
        '
        'pnlReplacements
        '
        Me.pnlReplacements.BackColor = System.Drawing.Color.White
        Me.pnlReplacements.Controls.Add(Me.lblReplacementsCount)
        Me.pnlReplacements.Controls.Add(Me.lblReplacementsTitle)
        Me.pnlReplacements.Location = New System.Drawing.Point(570, 32)
        Me.pnlReplacements.Margin = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.pnlReplacements.Name = "pnlReplacements"
        Me.pnlReplacements.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.pnlReplacements.Size = New System.Drawing.Size(150, 73)
        Me.pnlReplacements.TabIndex = 3
        '
        'lblReplacementsCount
        '
        Me.lblReplacementsCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblReplacementsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblReplacementsCount.Location = New System.Drawing.Point(8, 24)
        Me.lblReplacementsCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReplacementsCount.Name = "lblReplacementsCount"
        Me.lblReplacementsCount.Size = New System.Drawing.Size(75, 37)
        Me.lblReplacementsCount.TabIndex = 0
        Me.lblReplacementsCount.Text = "0"
        '
        'lblReplacementsTitle
        '
        Me.lblReplacementsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblReplacementsTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblReplacementsTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblReplacementsTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReplacementsTitle.Name = "lblReplacementsTitle"
        Me.lblReplacementsTitle.Size = New System.Drawing.Size(97, 19)
        Me.lblReplacementsTitle.TabIndex = 1
        Me.lblReplacementsTitle.Text = "Replacement Requests"
        '
        'dgvActivities
        '
        Me.dgvActivities.AllowUserToAddRows = False
        Me.dgvActivities.AllowUserToDeleteRows = False
        Me.dgvActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActivities.BackgroundColor = System.Drawing.Color.White
        Me.dgvActivities.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvActivities.EnableHeadersVisualStyles = False
        Me.dgvActivities.Location = New System.Drawing.Point(19, 192)
        Me.dgvActivities.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvActivities.Name = "dgvActivities"
        Me.dgvActivities.ReadOnly = True
        Me.dgvActivities.RowHeadersVisible = False
        Me.dgvActivities.Size = New System.Drawing.Size(1311, 573)
        Me.dgvActivities.TabIndex = 1
        '
        'lblActivityLog
        '
        Me.lblActivityLog.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblActivityLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblActivityLog.Location = New System.Drawing.Point(19, 171)
        Me.lblActivityLog.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActivityLog.Name = "lblActivityLog"
        Me.lblActivityLog.Size = New System.Drawing.Size(75, 19)
        Me.lblActivityLog.TabIndex = 0
        Me.lblActivityLog.Text = "🕓 Activity Log"
        '
        'frmSystemMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1414, 776)
        Me.Controls.Add(Me.lblActivityLog)
        Me.Controls.Add(Me.dgvActivities)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlTopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSystemMonitor"
        Me.Text = "System Monitoring"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlApprovals.ResumeLayout(False)
        Me.pnlBilling.ResumeLayout(False)
        Me.pnlSales.ResumeLayout(False)
        Me.pnlReplacements.ResumeLayout(False)
        CType(Me.dgvActivities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlSummary As FlowLayoutPanel
    Friend WithEvents pnlApprovals As Panel
    Friend WithEvents lblApprovalsCount As Label
    Friend WithEvents lblApprovalsTitle As Label
    Friend WithEvents pnlBilling As Panel
    Friend WithEvents lblBillingCount As Label
    Friend WithEvents lblBillingTitle As Label
    Friend WithEvents pnlSales As Panel
    Friend WithEvents lblSalesCount As Label
    Friend WithEvents lblSalesTitle As Label
    Friend WithEvents pnlReplacements As Panel
    Friend WithEvents lblReplacementsCount As Label
    Friend WithEvents lblReplacementsTitle As Label
    Friend WithEvents dgvActivities As DataGridView
    Friend WithEvents lblActivityLog As Label
End Class
