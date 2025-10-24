<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffFrm
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
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnPCStatus = New System.Windows.Forms.Button()
        Me.btnSession = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblStaffName)
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
        Me.lblTitle.Size = New System.Drawing.Size(326, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pacita Computer Shop - Staff UI"
        '
        'lblStaffName
        '
        Me.lblStaffName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStaffName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStaffName.Location = New System.Drawing.Point(989, 17)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(164, 19)
        Me.lblStaffName.TabIndex = 2
        Me.lblStaffName.Text = "Welcome, Staff Username"
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
        Me.pnlSidebar.Controls.Add(Me.btnBilling)
        Me.pnlSidebar.Controls.Add(Me.btnSales)
        Me.pnlSidebar.Controls.Add(Me.btnPCStatus)
        Me.pnlSidebar.Controls.Add(Me.btnSession)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 52)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(189, 497)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnBilling
        '
        Me.btnBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBilling.FlatAppearance.BorderSize = 0
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBilling.ForeColor = System.Drawing.Color.White
        Me.btnBilling.Location = New System.Drawing.Point(0, 241)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(189, 89)
        Me.btnBilling.TabIndex = 3
        Me.btnBilling.Text = "🧾  Billing/Replacements"
        Me.btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(0, 160)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(189, 81)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "💵  Sales Tracker"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnPCStatus
        '
        Me.btnPCStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPCStatus.FlatAppearance.BorderSize = 0
        Me.btnPCStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPCStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPCStatus.ForeColor = System.Drawing.Color.White
        Me.btnPCStatus.Location = New System.Drawing.Point(0, 80)
        Me.btnPCStatus.Name = "btnPCStatus"
        Me.btnPCStatus.Size = New System.Drawing.Size(189, 80)
        Me.btnPCStatus.TabIndex = 1
        Me.btnPCStatus.Text = "💻  PC Status"
        Me.btnPCStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPCStatus.UseVisualStyleBackColor = False
        '
        'btnSession
        '
        Me.btnSession.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSession.FlatAppearance.BorderSize = 0
        Me.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSession.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSession.ForeColor = System.Drawing.Color.White
        Me.btnSession.Location = New System.Drawing.Point(0, 0)
        Me.btnSession.Name = "btnSession"
        Me.btnSession.Size = New System.Drawing.Size(189, 80)
        Me.btnSession.TabIndex = 0
        Me.btnSession.Text = "🕒  Manage Sessions"
        Me.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSession.UseVisualStyleBackColor = False
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
        'StaffFrm
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
        Me.Name = "StaffFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff - Pacita Computer Shop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStaffName As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnSession As Button
    Friend WithEvents btnPCStatus As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents pnlMain As Panel
End Class
