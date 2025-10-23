<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sessionfrm
    Inherits System.Windows.Forms.Form

    'Dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New Panel()
        Me.lblTitle = New Label()
        Me.pnlMain = New Panel()
        Me.grpSessionControl = New Panel()
        Me.lblPC = New Label()
        Me.lblTimeType = New Label()
        Me.lblCustomer = New Label()
        Me.cmbPC = New ComboBox()
        Me.cmbTimeType = New ComboBox()
        Me.txtCustomer = New TextBox()
        Me.btnStart = New Button()
        Me.btnEnd = New Button()
        Me.dgvSessions = New DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.grpSessionControl.SuspendLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '=== FORM ===
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1275, 612)
        Me.BackColor = Color.FromArgb(240, 242, 247)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Manage Sessions"

        '=== HEADER ===
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 65
        Me.pnlHeader.BackColor = Color.FromArgb(34, 40, 49)
        Me.pnlHeader.Controls.Add(Me.lblTitle)

        Me.lblTitle.Text = "🕒 Manage Sessions"
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New Point(30, 15)

        '=== MAIN PANEL ===
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlMain.Padding = New Padding(25)
        Me.pnlMain.BackColor = Color.FromArgb(240, 242, 247)
        Me.pnlMain.Controls.Add(Me.grpSessionControl)
        Me.pnlMain.Controls.Add(Me.dgvSessions)

        '=== DATAGRIDVIEW ===
        Me.dgvSessions.Location = New Point(25, 25)
        Me.dgvSessions.Size = New Size(1220, 400)
        Me.dgvSessions.BackgroundColor = Color.White
        Me.dgvSessions.BorderStyle = BorderStyle.None
        Me.dgvSessions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSessions.ColumnHeadersHeight = 35
        Me.dgvSessions.EnableHeadersVisualStyles = False
        Me.dgvSessions.GridColor = Color.FromArgb(230, 230, 230)
        Me.dgvSessions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219)
        Me.dgvSessions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvSessions.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.dgvSessions.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        Me.dgvSessions.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
        Me.dgvSessions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 245)
        Me.dgvSessions.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.dgvSessions.RowHeadersVisible = False
        Me.dgvSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessions.ReadOnly = True
        Me.dgvSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        '=== SESSION CONTROL PANEL (CARD STYLE) ===
        Me.grpSessionControl.BackColor = Color.White
        Me.grpSessionControl.Location = New Point(25, 450)
        Me.grpSessionControl.Size = New Size(1220, 120)
        Me.grpSessionControl.Padding = New Padding(20)
        Me.grpSessionControl.BorderStyle = BorderStyle.None
        Me.grpSessionControl.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        Me.grpSessionControl.BackColor = Color.White
        Me.grpSessionControl.Controls.Add(Me.lblPC)
        Me.grpSessionControl.Controls.Add(Me.cmbPC)
        Me.grpSessionControl.Controls.Add(Me.lblTimeType)
        Me.grpSessionControl.Controls.Add(Me.cmbTimeType)
        Me.grpSessionControl.Controls.Add(Me.lblCustomer)
        Me.grpSessionControl.Controls.Add(Me.txtCustomer)
        Me.grpSessionControl.Controls.Add(Me.btnStart)
        Me.grpSessionControl.Controls.Add(Me.btnEnd)

        '=== LABELS ===
        Me.lblPC.Text = "Select PC:"
        Me.lblPC.Font = New Font("Segoe UI", 10)
        Me.lblPC.Location = New Point(20, 25)
        Me.lblPC.AutoSize = True

        Me.lblTimeType.Text = "Session Type:"
        Me.lblTimeType.Font = New Font("Segoe UI", 10)
        Me.lblTimeType.Location = New Point(250, 25)
        Me.lblTimeType.AutoSize = True

        Me.lblCustomer.Text = "Customer Name:"
        Me.lblCustomer.Font = New Font("Segoe UI", 10)
        Me.lblCustomer.Location = New Point(480, 25)
        Me.lblCustomer.AutoSize = True

        '=== INPUTS ===
        Me.cmbPC.Font = New Font("Segoe UI", 10)
        Me.cmbPC.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbPC.Size = New Size(120, 27)
        Me.cmbPC.Location = New Point(100, 22)

        Me.cmbTimeType.Font = New Font("Segoe UI", 10)
        Me.cmbTimeType.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbTimeType.Items.AddRange(New Object() {"Open Time", "Fixed Time"})
        Me.cmbTimeType.Size = New Size(150, 27)
        Me.cmbTimeType.Location = New Point(350, 22)

        Me.txtCustomer.Font = New Font("Segoe UI", 10)

        Me.txtCustomer.Size = New Size(220, 27)
        Me.txtCustomer.Location = New Point(600, 22)

        '=== BUTTONS ===
        Me.btnStart.Text = "▶ Start Session"
        Me.btnStart.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnStart.BackColor = Color.FromArgb(46, 204, 113)
        Me.btnStart.ForeColor = Color.White
        Me.btnStart.FlatStyle = FlatStyle.Flat
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.Size = New Size(160, 40)
        Me.btnStart.Location = New Point(860, 22)
        Me.btnStart.Cursor = Cursors.Hand
        Me.btnStart.Region = New Region(New Drawing2D.GraphicsPath())

        Me.btnEnd.Text = "■ End Session"
        Me.btnEnd.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnEnd.BackColor = Color.FromArgb(231, 76, 60)
        Me.btnEnd.ForeColor = Color.White
        Me.btnEnd.FlatStyle = FlatStyle.Flat
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.Size = New Size(160, 40)
        Me.btnEnd.Location = New Point(1040, 22)
        Me.btnEnd.Cursor = Cursors.Hand

        '=== ADD TO FORM ===
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.grpSessionControl.ResumeLayout(False)
        Me.grpSessionControl.PerformLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents grpSessionControl As Panel
    Friend WithEvents lblPC As Label
    Friend WithEvents lblTimeType As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents cmbPC As ComboBox
    Friend WithEvents cmbTimeType As ComboBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnEnd As Button
End Class
