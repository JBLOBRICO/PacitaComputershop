<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ownerdashboardfrm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private lblTitle As Label
    Private flowCards As FlowLayoutPanel
    Private lblRecent As Label
    Private dgvRecentSales As DataGridView
    Private lblRequests As Label
    Private dgvRequests As DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.flowCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.dgvRecentSales = New System.Windows.Forms.DataGridView()
        Me.lblRequests = New System.Windows.Forms.Label()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRecentSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(263, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "📊 Owner Overview"
        '
        'flowCards
        '
        Me.flowCards.BackColor = System.Drawing.Color.Transparent
        Me.flowCards.Location = New System.Drawing.Point(22, 58)
        Me.flowCards.Margin = New System.Windows.Forms.Padding(2)
        Me.flowCards.Name = "flowCards"
        Me.flowCards.Size = New System.Drawing.Size(855, 116)
        Me.flowCards.TabIndex = 1
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblRecent.Location = New System.Drawing.Point(22, 176)
        Me.lblRecent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(145, 25)
        Me.lblRecent.TabIndex = 2
        Me.lblRecent.Text = "🕓 Recent Sales"
        '
        'dgvRecentSales
        '
        Me.dgvRecentSales.AllowUserToAddRows = False
        Me.dgvRecentSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentSales.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecentSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecentSales.Location = New System.Drawing.Point(22, 202)
        Me.dgvRecentSales.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRecentSales.Name = "dgvRecentSales"
        Me.dgvRecentSales.ReadOnly = True
        Me.dgvRecentSales.RowHeadersVisible = False
        Me.dgvRecentSales.Size = New System.Drawing.Size(855, 117)
        Me.dgvRecentSales.TabIndex = 3
        '
        'lblRequests
        '
        Me.lblRequests.AutoSize = True
        Me.lblRequests.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRequests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblRequests.Location = New System.Drawing.Point(22, 338)
        Me.lblRequests.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRequests.Name = "lblRequests"
        Me.lblRequests.Size = New System.Drawing.Size(189, 25)
        Me.lblRequests.TabIndex = 4
        Me.lblRequests.Text = "📋 Pending Requests"
        '
        'dgvRequests
        '
        Me.dgvRequests.AllowUserToAddRows = False
        Me.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequests.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRequests.Location = New System.Drawing.Point(22, 364)
        Me.dgvRequests.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.ReadOnly = True
        Me.dgvRequests.RowHeadersVisible = False
        Me.dgvRequests.Size = New System.Drawing.Size(855, 98)
        Me.dgvRequests.TabIndex = 5
        '
        'ownerdashboardfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 487)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.flowCards)
        Me.Controls.Add(Me.lblRecent)
        Me.Controls.Add(Me.dgvRecentSales)
        Me.Controls.Add(Me.lblRequests)
        Me.Controls.Add(Me.dgvRequests)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ownerdashboardfrm"
        Me.Text = "Owner Dashboard"
        CType(Me.dgvRecentSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
