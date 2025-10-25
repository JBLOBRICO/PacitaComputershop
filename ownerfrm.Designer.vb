<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ownerfrm
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnMonitoring = New System.Windows.Forms.Button()
        Me.btnApprovals = New System.Windows.Forms.Button()
        Me.btnSalesAnalytics = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblOwnerName)
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1245, 52)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(17, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(345, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pacita Computer Shop - Owner UI"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblOwnerName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblOwnerName.Location = New System.Drawing.Point(975, 17)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(178, 19)
        Me.lblOwnerName.TabIndex = 2
        Me.lblOwnerName.Text = "Welcome, Owner Username"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1159, 13)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(73, 26)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnMonitoring)
        Me.pnlSidebar.Controls.Add(Me.btnApprovals)
        Me.pnlSidebar.Controls.Add(Me.btnSalesAnalytics)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 52)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(189, 497)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnMonitoring
        '
        Me.btnMonitoring.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMonitoring.FlatAppearance.BorderSize = 0
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMonitoring.ForeColor = System.Drawing.Color.White
        Me.btnMonitoring.Location = New System.Drawing.Point(0, 243)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(189, 80)
        Me.btnMonitoring.TabIndex = 3
        Me.btnMonitoring.Text = "👀  Monitoring (Read-Only)"
        Me.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonitoring.UseVisualStyleBackColor = False
        '
        'btnApprovals
        '
        Me.btnApprovals.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApprovals.FlatAppearance.BorderSize = 0
        Me.btnApprovals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprovals.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnApprovals.ForeColor = System.Drawing.Color.White
        Me.btnApprovals.Location = New System.Drawing.Point(0, 162)
        Me.btnApprovals.Name = "btnApprovals"
        Me.btnApprovals.Size = New System.Drawing.Size(189, 81)
        Me.btnApprovals.TabIndex = 2
        Me.btnApprovals.Text = "✅  Approvals"
        Me.btnApprovals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprovals.UseVisualStyleBackColor = False
        '
        'btnSalesAnalytics
        '
        Me.btnSalesAnalytics.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalesAnalytics.FlatAppearance.BorderSize = 0
        Me.btnSalesAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesAnalytics.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalesAnalytics.ForeColor = System.Drawing.Color.White
        Me.btnSalesAnalytics.Location = New System.Drawing.Point(0, 81)
        Me.btnSalesAnalytics.Name = "btnSalesAnalytics"
        Me.btnSalesAnalytics.Size = New System.Drawing.Size(189, 81)
        Me.btnSalesAnalytics.TabIndex = 1
        Me.btnSalesAnalytics.Text = "📊  Sales & Analytics"
        Me.btnSalesAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesAnalytics.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(189, 81)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "🏠  Dashboard / Overview"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(189, 52)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1056, 497)
        Me.pnlMain.TabIndex = 2
        '
        'ownerfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1245, 549)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ownerfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Owner - Pacita Computer Shop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSalesAnalytics As Button
    Friend WithEvents btnApprovals As Button
    Friend WithEvents btnMonitoring As Button
    Friend WithEvents pnlMain As Panel
End Class
