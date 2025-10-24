Imports MySql.Data.MySqlClient

Public Class Frmpcstatus

    Private Sub Frmpcstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPCStatus()
    End Sub

    Private Sub LoadPCStatus()
        Try
            OpenConnection()

            Dim query As String = "SELECT ComputerID, ComputerName, Status FROM computers"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvPCStatus.DataSource = dt

            ' ✅ Format DataGridView
            dgvPCStatus.Columns("ComputerID").HeaderText = "ID"
            dgvPCStatus.Columns("ComputerName").HeaderText = "Computer Name"
            dgvPCStatus.Columns("Status").HeaderText = "Status"
            dgvPCStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPCStatus.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            dgvPCStatus.DefaultCellStyle.Font = New Font("Segoe UI", 10)

            ' ✅ Count totals
            Dim totalCount As Integer = dt.Rows.Count
            Dim availableCount As Integer = dt.Select("Status = 'Available'").Length
            Dim inUseCount As Integer = dt.Select("Status = 'In Use'").Length
            Dim maintenanceCount As Integer = dt.Select("Status = 'Maintenance'").Length

            lblTotal.Text = $"Total PCs: {totalCount}"
            lblAvailable.Text = $"🟢 Available: {availableCount}"
            lblInUse.Text = $"🟡 In Use: {inUseCount}"
            lblMaintenance.Text = $"🔧 Maintenance: {maintenanceCount}"

        Catch ex As Exception
            MessageBox.Show("Error loading computer status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPCStatus()
    End Sub

End Class
