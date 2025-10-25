Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmanalytics
    Private conn As MySqlConnection
    Private da As MySqlDataAdapter
    Private dt As DataTable

    Private Sub frmanalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Initialize connection
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password=;database=pacitacmpdb;")
            conn.Open()

            ' Load all charts
            LoadRevenueChart()
            LoadSessionsChart()
            LoadPCStatusChart()
            LoadBillingChart()
            LoadReplacementChart()
            LoadSalesChart()
            LoadUserRolesChart()

            ' Load new charts
            LoadTopUsersChart()
            LoadTopPCsChart()
            LoadPCUsageChart()

        Catch ex As Exception
            MessageBox.Show("Error loading analytics: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' --- DAILY REVENUE ---
    Private Sub LoadRevenueChart()
        Dim query As String = "SELECT SaleDate, DailyRevenue FROM salesanalytics ORDER BY SaleDate"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartRevenue.Series.Clear()
        Dim series As New Series("Revenue") With {.ChartType = SeriesChartType.Column, .XValueType = ChartValueType.String}
        chartRevenue.ChartAreas.Clear()
        chartRevenue.ChartAreas.Add(New ChartArea())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("SaleDate").ToString(), Convert.ToDecimal(row("DailyRevenue")))
        Next

        chartRevenue.Series.Add(series)
        chartRevenue.ChartAreas(0).AxisX.Title = "Date"
        chartRevenue.ChartAreas(0).AxisY.Title = "Revenue (₱)"
        chartRevenue.ChartAreas(0).AxisX.Interval = 1
    End Sub

    ' --- DAILY SESSIONS ---
    Private Sub LoadSessionsChart()
        Dim query As String = "SELECT SaleDate, TotalSessions FROM salesanalytics ORDER BY SaleDate"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartSessions.Series.Clear()
        Dim series As New Series("Sessions") With {.ChartType = SeriesChartType.Line, .XValueType = ChartValueType.String}
        chartSessions.ChartAreas.Clear()
        chartSessions.ChartAreas.Add(New ChartArea())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("SaleDate").ToString(), Convert.ToInt32(row("TotalSessions")))
        Next
        chartSessions.Series.Add(series)
        chartSessions.ChartAreas(0).AxisX.Title = "Date"
        chartSessions.ChartAreas(0).AxisY.Title = "Number of Sessions"
    End Sub

    ' --- PC STATUS ---
    Private Sub LoadPCStatusChart()
        Dim query As String = "SELECT Status, COUNT(*) AS Count FROM computers GROUP BY Status"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartPCStatus.Series.Clear()
        Dim series As New Series("PC Status") With {.ChartType = SeriesChartType.Pie}
        chartPCStatus.ChartAreas.Clear()
        chartPCStatus.ChartAreas.Add(New ChartArea())
        chartPCStatus.Legends.Clear()
        chartPCStatus.Legends.Add(New Legend())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("Status").ToString(), Convert.ToInt32(row("Count")))
        Next
        chartPCStatus.Series.Add(series)
    End Sub

    ' --- BILLING STATUS ---
    Private Sub LoadBillingChart()
        Dim query As String = "SELECT Status, COUNT(*) AS Count FROM billing GROUP BY Status"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartBilling.Series.Clear()
        Dim series As New Series("Billing") With {.ChartType = SeriesChartType.Pie}
        chartBilling.ChartAreas.Clear()
        chartBilling.ChartAreas.Add(New ChartArea())
        chartBilling.Legends.Clear()
        chartBilling.Legends.Add(New Legend())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("Status").ToString(), Convert.ToInt32(row("Count")))
        Next
        chartBilling.Series.Add(series)
    End Sub

    ' --- REPLACEMENT REQUESTS ---
    Private Sub LoadReplacementChart()
        Dim query As String = "SELECT Status, COUNT(*) AS Count FROM replacements GROUP BY Status"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartReplacement.Series.Clear()
        Dim series As New Series("Replacement") With {.ChartType = SeriesChartType.Pie}
        chartReplacement.ChartAreas.Clear()
        chartReplacement.ChartAreas.Add(New ChartArea())
        chartReplacement.Legends.Clear()
        chartReplacement.Legends.Add(New Legend())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("Status").ToString(), Convert.ToInt32(row("Count")))
        Next
        chartReplacement.Series.Add(series)
    End Sub

    ' --- SALES PAYMENT STATUS ---
    Private Sub LoadSalesChart()
        Dim query As String = "SELECT PaymentStatus, COUNT(*) AS Count FROM sales GROUP BY PaymentStatus"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartSales.Series.Clear()
        Dim series As New Series("Sales") With {.ChartType = SeriesChartType.Pie}
        chartSales.ChartAreas.Clear()
        chartSales.ChartAreas.Add(New ChartArea())
        chartSales.Legends.Clear()
        chartSales.Legends.Add(New Legend())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("PaymentStatus").ToString(), Convert.ToInt32(row("Count")))
        Next
        chartSales.Series.Add(series)
    End Sub

    ' --- USER ROLE DISTRIBUTION ---
    Private Sub LoadUserRolesChart()
        Dim query As String = "SELECT Role, COUNT(*) AS Count FROM users GROUP BY Role"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartUserRoles.Series.Clear()
        Dim series As New Series("Users") With {.ChartType = SeriesChartType.Pie}
        chartUserRoles.ChartAreas.Clear()
        chartUserRoles.ChartAreas.Add(New ChartArea())
        chartUserRoles.Legends.Clear()
        chartUserRoles.Legends.Add(New Legend())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("Role").ToString(), Convert.ToInt32(row("Count")))
        Next
        chartUserRoles.Series.Add(series)
    End Sub

    ' --- TOP 5 ACTIVE USERS ---
    Private Sub LoadTopUsersChart()
        Dim query As String = "SELECT u.FullName, COUNT(s.SaleID) AS Sessions FROM users u " &
                              "LEFT JOIN sales s ON u.UserID = s.UserID " &
                              "GROUP BY u.FullName ORDER BY Sessions DESC LIMIT 5"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartTopUsers.Series.Clear()
        Dim series As New Series("TopUsers") With {.ChartType = SeriesChartType.Column, .XValueType = ChartValueType.String}
        chartTopUsers.ChartAreas.Clear()
        chartTopUsers.ChartAreas.Add(New ChartArea())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("FullName").ToString(), Convert.ToInt32(row("Sessions")))
        Next
        chartTopUsers.Series.Add(series)
        chartTopUsers.ChartAreas(0).AxisX.Title = "User"
        chartTopUsers.ChartAreas(0).AxisY.Title = "Sessions"
        chartTopUsers.ChartAreas(0).AxisX.Interval = 1
    End Sub

    ' --- TOP 5 PCs BY USAGE ---
    Private Sub LoadTopPCsChart()
        Dim query As String = "SELECT c.ComputerName, COUNT(s.SaleID) AS Sessions FROM computers c " &
                              "LEFT JOIN sales s ON c.ComputerID = s.ComputerID " &
                              "GROUP BY c.ComputerName ORDER BY Sessions DESC LIMIT 5"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartTopPCs.Series.Clear()
        Dim series As New Series("TopPCs") With {.ChartType = SeriesChartType.Column, .XValueType = ChartValueType.String}
        chartTopPCs.ChartAreas.Clear()
        chartTopPCs.ChartAreas.Add(New ChartArea())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("ComputerName").ToString(), Convert.ToInt32(row("Sessions")))
        Next
        chartTopPCs.Series.Add(series)
        chartTopPCs.ChartAreas(0).AxisX.Title = "PC Name"
        chartTopPCs.ChartAreas(0).AxisY.Title = "Sessions"
        chartTopPCs.ChartAreas(0).AxisX.Interval = 1
    End Sub

    ' --- PC USAGE STATUS ---
    Private Sub LoadPCUsageChart()
        Dim query As String = "SELECT Status, COUNT(*) AS Count FROM computers GROUP BY Status"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)

        chartPCUsage.Series.Clear()
        Dim series As New Series("PCUsage") With {.ChartType = SeriesChartType.Pie}
        chartPCUsage.ChartAreas.Clear()
        chartPCUsage.ChartAreas.Add(New ChartArea())
        chartPCUsage.Legends.Clear()
        chartPCUsage.Legends.Add(New Legend())

        For Each row As DataRow In dt.Rows
            series.Points.AddXY(row("Status").ToString(), Convert.ToInt32(row("Count")))
        Next
        chartPCUsage.Series.Add(series)
    End Sub
End Class
