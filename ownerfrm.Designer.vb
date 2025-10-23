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

    'NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.btnLogoutHeader = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnMonitoring = New System.Windows.Forms.Button()
        Me.btnPCStatus = New System.Windows.Forms.Button()
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblOwnerName)
        Me.pnlHeader.Controls.Add(Me.btnLogoutHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1141, 52)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(17, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pacita Computer Shop - Admin"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblOwnerName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblOwnerName.Location = New System.Drawing.Point(872, 17)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(177, 19)
        Me.lblOwnerName.TabIndex = 2
        Me.lblOwnerName.Text = "Welcome, Admin Username"
        '
        'btnLogoutHeader
        '
        Me.btnLogoutHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogoutHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogoutHeader.FlatAppearance.BorderSize = 0
        Me.btnLogoutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogoutHeader.ForeColor = System.Drawing.Color.White
        Me.btnLogoutHeader.Location = New System.Drawing.Point(1055, 13)
        Me.btnLogoutHeader.Name = "btnLogoutHeader"
        Me.btnLogoutHeader.Size = New System.Drawing.Size(73, 26)
        Me.btnLogoutHeader.TabIndex = 1
        Me.btnLogoutHeader.Text = "Logout"
        Me.btnLogoutHeader.UseVisualStyleBackColor = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnUsers)
        Me.pnlSidebar.Controls.Add(Me.btnMonitoring)
        Me.pnlSidebar.Controls.Add(Me.btnPCStatus)
        Me.pnlSidebar.Controls.Add(Me.btnAnalytics)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 52)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(189, 478)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnUsers
        '
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(0, 332)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(189, 80)
        Me.btnUsers.TabIndex = 4
        Me.btnUsers.Text = "👤  Manage Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnMonitoring
        '
        Me.btnMonitoring.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMonitoring.FlatAppearance.BorderSize = 0
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMonitoring.ForeColor = System.Drawing.Color.White
        Me.btnMonitoring.Location = New System.Drawing.Point(0, 246)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(189, 86)
        Me.btnMonitoring.TabIndex = 3
        Me.btnMonitoring.Text = "🧾  Monitoring"
        Me.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonitoring.UseVisualStyleBackColor = False
        '
        'btnPCStatus
        '
        Me.btnPCStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPCStatus.FlatAppearance.BorderSize = 0
        Me.btnPCStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPCStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPCStatus.ForeColor = System.Drawing.Color.White
        Me.btnPCStatus.Location = New System.Drawing.Point(0, 166)
        Me.btnPCStatus.Name = "btnPCStatus"
        Me.btnPCStatus.Size = New System.Drawing.Size(189, 80)
        Me.btnPCStatus.TabIndex = 2
        Me.btnPCStatus.Text = "💻  PC Status"
        Me.btnPCStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPCStatus.UseVisualStyleBackColor = False
        '
        'btnAnalytics
        '
        Me.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAnalytics.FlatAppearance.BorderSize = 0
        Me.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalytics.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnalytics.ForeColor = System.Drawing.Color.White
        Me.btnAnalytics.Location = New System.Drawing.Point(0, 86)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(189, 80)
        Me.btnAnalytics.TabIndex = 1
        Me.btnAnalytics.Text = "📊  Analytics"
        Me.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnalytics.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(189, 86)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "🏠  Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(189, 52)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(952, 478)
        Me.pnlMain.TabIndex = 2
        '
        'ownerfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 530)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ownerfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Pacita Computer Shop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogoutHeader As Button
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAnalytics As Button
    Friend WithEvents btnPCStatus As Button
    Friend WithEvents btnMonitoring As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents pnlMain As Panel
End Class
