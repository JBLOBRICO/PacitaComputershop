Imports MySql.Data.MySqlClient

Public Class frmsalestracker

    Private Sub frmsalestracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTodaySales()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTodaySales()
    End Sub

    Private Sub LoadTodaySales()
        Try
            OpenConnection()

            Dim query As String =
                "SELECT s.SaleID, c.ComputerName, u.FullName AS StaffName, " &
                "s.StartTime, s.EndTime, s.RatePerHour, s.TotalAmount, s.PaymentStatus " &
                "FROM sales s " &
                "INNER JOIN computers c ON s.ComputerID = c.ComputerID " &
                "INNER JOIN users u ON s.UserID = u.UserID " &
                "WHERE DATE(s.StartTime) = CURDATE() " &
                "ORDER BY s.StartTime DESC;"

            da = New MySqlDataAdapter(query, conn)
            dt = New DataTable()
            da.Fill(dt)
            dgvSales.DataSource = dt

            ' --- Auto format columns ---
            dgvSales.Columns("SaleID").HeaderText = "Sale ID"
            dgvSales.Columns("ComputerName").HeaderText = "Computer"
            dgvSales.Columns("StaffName").HeaderText = "Handled By"
            dgvSales.Columns("StartTime").HeaderText = "Start Time"
            dgvSales.Columns("EndTime").HeaderText = "End Time"
            dgvSales.Columns("RatePerHour").HeaderText = "Rate/Hr"
            dgvSales.Columns("TotalAmount").HeaderText = "Total"
            dgvSales.Columns("PaymentStatus").HeaderText = "Status"

            dgvSales.Columns("RatePerHour").DefaultCellStyle.Format = "₱#,##0.00"
            dgvSales.Columns("TotalAmount").DefaultCellStyle.Format = "₱#,##0.00"
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' --- Compute Total Sales ---
            Dim total As Decimal = 0
            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row("TotalAmount")) Then
                    total += Convert.ToDecimal(row("TotalAmount"))
                End If
            Next

            lblTotalSales.Text = "₱ " & total.ToString("N2")


        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

End Class
