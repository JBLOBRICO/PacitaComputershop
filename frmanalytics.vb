Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmanalytics

    Private conn As MySqlConnection

    Private Sub frmanalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Initialize MySQL connection ---
        conn = New MySqlConnection("server=127.0.0.1;userid=root;password=;database=pacitacmpdb;SslMode=none")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message)
            Return
        End Try

        ' --- Load dashboard cards ---
        LoadDashboardCards()

        ' --- Load charts ---
        LoadRevenueChart()
        LoadDailySessionsChart()
        LoadPCUsageChart()
        LoadTopPCsChart()
        LoadTopUsersChart()
    End Sub

    Private Sub LoadDashboardCards()
        ' Total PCs
        lblTotalPCs.Text = ExecuteScalar("SELECT COUNT(*) FROM computers")

        ' Available PCs
        lblAvailablePCs.Text = ExecuteScalar("SELECT COUNT(*) FROM computers WHERE Status='Available'")

        ' In Use PCs
        lblInUsePCs.Text = ExecuteScalar("SELECT COUNT(*) FROM computers WHERE Status='In Use'")

        ' Pending Approvals
        lblPendingApprovals.Text = ExecuteScalar("SELECT COUNT(*) FROM approvals WHERE Status IS NULL OR Status='Pending'")

        ' Pending Billing
        lblPendingBilling.Text = ExecuteScalar("SELECT COUNT(*) FROM billing WHERE Status='Pending'")
    End Sub

    Private Sub LoadRevenueChart()
        chartRevenue.Series.Clear()
        chartRevenue.Titles.Clear()
        chartRevenue.Titles.Add("Daily Revenue")
        chartRevenue.ChartAreas.Clear()
        chartRevenue.ChartAreas.Add(New ChartArea("RevenueArea"))

        Dim cmd As New MySqlCommand("SELECT SaleDate, DailyRevenue FROM salesanalytics ORDER BY SaleDate", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim series As New Series("Revenue")
        series.ChartType = SeriesChartType.Column
        While reader.Read()
            series.Points.AddXY(reader("SaleDate"), reader("DailyRevenue"))
        End While
        reader.Close()
        chartRevenue.Series.Add(series)
    End Sub

    Private Sub LoadDailySessionsChart()
        chartDailySessions.Series.Clear()
        chartDailySessions.Titles.Clear()
        chartDailySessions.Titles.Add("Daily Sessions")
        chartDailySessions.ChartAreas.Clear()
        chartDailySessions.ChartAreas.Add(New ChartArea("SessionsArea"))

        Dim cmd As New MySqlCommand("SELECT SaleDate, TotalSessions FROM salesanalytics ORDER BY SaleDate", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim series As New Series("Sessions")
        series.ChartType = SeriesChartType.Line
        While reader.Read()
            series.Points.AddXY(reader("SaleDate"), reader("TotalSessions"))
        End While
        reader.Close()
        chartDailySessions.Series.Add(series)
    End Sub

    Private Sub LoadPCUsageChart()
        chartPCUsage.Series.Clear()
        chartPCUsage.Titles.Clear()
        chartPCUsage.Titles.Add("PC Usage")
        chartPCUsage.ChartAreas.Clear()
        chartPCUsage.ChartAreas.Add(New ChartArea("PCUsageArea"))

        Dim cmd As New MySqlCommand("
            SELECT c.ComputerName, COUNT(s.SaleID) AS UsageCount 
            FROM computers c 
            LEFT JOIN sales s ON c.ComputerID = s.ComputerID 
            GROUP BY c.ComputerName
        ", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim series As New Series("PC Usage")
        series.ChartType = SeriesChartType.Bar
        While reader.Read()
            series.Points.AddXY(reader("ComputerName"), reader("UsageCount"))
        End While
        reader.Close()
        chartPCUsage.Series.Add(series)
    End Sub

    Private Sub LoadTopPCsChart()
        chartTopPCs.Series.Clear()
        chartTopPCs.Titles.Clear()
        chartTopPCs.Titles.Add("Top PCs by Revenue")
        chartTopPCs.ChartAreas.Clear()
        chartTopPCs.ChartAreas.Add(New ChartArea("TopPCsArea"))

        Dim cmd As New MySqlCommand("
            SELECT c.ComputerName, SUM(s.TotalAmount) AS TotalRevenue
            FROM computers c
            LEFT JOIN sales s ON c.ComputerID = s.ComputerID
            GROUP BY c.ComputerName
            ORDER BY TotalRevenue DESC
            LIMIT 5
        ", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim series As New Series("Top PCs")
        series.ChartType = SeriesChartType.Column
        While reader.Read()
            series.Points.AddXY(reader("ComputerName"), reader("TotalRevenue"))
        End While
        reader.Close()
        chartTopPCs.Series.Add(series)
    End Sub

    Private Sub LoadTopUsersChart()
        chartTopUsers.Series.Clear()
        chartTopUsers.Titles.Clear()
        chartTopUsers.Titles.Add("Top Users by Spending")
        chartTopUsers.ChartAreas.Clear()
        chartTopUsers.ChartAreas.Add(New ChartArea("TopUsersArea"))

        Dim cmd As New MySqlCommand("
            SELECT u.Username, SUM(s.TotalAmount) AS TotalSpent
            FROM users u
            LEFT JOIN sales s ON u.UserID = s.UserID
            GROUP BY u.Username
            ORDER BY TotalSpent DESC
            LIMIT 5
        ", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim series As New Series("Top Users")
        series.ChartType = SeriesChartType.Column
        While reader.Read()
            series.Points.AddXY(reader("Username"), reader("TotalSpent"))
        End While
        reader.Close()
        chartTopUsers.Series.Add(series)
    End Sub

    ' --- Helper function to get single scalar value safely ---
    Private Function ExecuteScalar(query As String) As String
        Try
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, result.ToString(), "0")
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Sub frmanalytics_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Class
