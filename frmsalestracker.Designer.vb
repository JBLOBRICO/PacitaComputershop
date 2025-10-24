<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsalestracker
    Inherits System.Windows.Forms.Form

    ' Clean up resources
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblTodaySales = New System.Windows.Forms.Label()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(956, 39)
        Me.pnlHeader.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(180, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "💰 Sales Tracker"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.dgvSales)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 39)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlMain.Size = New System.Drawing.Size(731, 359)
        Me.pnlMain.TabIndex = 0
        '
        'dgvSales
        '
        Me.dgvSales.AllowUserToAddRows = False
        Me.dgvSales.AllowUserToDeleteRows = False
        Me.dgvSales.AllowUserToResizeColumns = False
        Me.dgvSales.AllowUserToResizeRows = False
        Me.dgvSales.BackgroundColor = System.Drawing.Color.White
        Me.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSales.Location = New System.Drawing.Point(15, 15)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.ReadOnly = True
        Me.dgvSales.RowHeadersVisible = False
        Me.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSales.Size = New System.Drawing.Size(701, 329)
        Me.dgvSales.TabIndex = 0
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.White
        Me.pnlSide.Controls.Add(Me.btnRefresh)
        Me.pnlSide.Controls.Add(Me.lblTotalSales)
        Me.pnlSide.Controls.Add(Me.lblTodaySales)
        Me.pnlSide.Controls.Add(Me.lblTransactions)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSide.Location = New System.Drawing.Point(731, 39)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSide.Size = New System.Drawing.Size(225, 359)
        Me.pnlSide.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(13, 220)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(188, 32)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "🔄 Refresh Data"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalSales.Location = New System.Drawing.Point(10, 15)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(140, 21)
        Me.lblTotalSales.TabIndex = 1
        Me.lblTotalSales.Text = "Total Sales: ₱0.00"
        '
        'lblTodaySales
        '
        Me.lblTodaySales.AutoSize = True
        Me.lblTodaySales.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTodaySales.ForeColor = System.Drawing.Color.Gray
        Me.lblTodaySales.Location = New System.Drawing.Point(10, 55)
        Me.lblTodaySales.Name = "lblTodaySales"
        Me.lblTodaySales.Size = New System.Drawing.Size(120, 21)
        Me.lblTodaySales.TabIndex = 2
        Me.lblTodaySales.Text = "🗓 Today: ₱0.00"
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTransactions.ForeColor = System.Drawing.Color.Gray
        Me.lblTransactions.Location = New System.Drawing.Point(10, 85)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(138, 21)
        Me.lblTransactions.TabIndex = 3
        Me.lblTransactions.Text = "📦 Transactions: 0"
        '
        'frmsalestracker
        '
        Me.ClientSize = New System.Drawing.Size(956, 398)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsalestracker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Tracker"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSide.ResumeLayout(False)
        Me.pnlSide.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents pnlSide As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblTodaySales As Label
    Friend WithEvents lblTransactions As Label
    Friend WithEvents btnRefresh As Button
End Class
