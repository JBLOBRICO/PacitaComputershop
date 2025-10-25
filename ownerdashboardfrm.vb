Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ownerdashboardfrm

    Private Sub ownerdashboardfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboard()
    End Sub

    Private Sub LoadDashboard()
        Try
            ' Open your MySQL connection
            Dbconnection.OpenConnection()

            '-----------------------------
            ' OVERVIEW CARDS
            '-----------------------------
            ' Total PCs
            Dim totalPCsCmd As New MySqlCommand("SELECT COUNT(*) FROM computers", Dbconnection.conn)
            lblTotalPCs.Text = totalPCsCmd.ExecuteScalar().ToString()

            ' Available PCs
            Dim availablePCsCmd As New MySqlCommand("SELECT COUNT(*) FROM computers WHERE Status='Available'", Dbconnection.conn)
            lblAvailablePCs.Text = availablePCsCmd.ExecuteScalar().ToString()

            ' Pending Approvals
            Dim pendingCmd As New MySqlCommand("SELECT COUNT(*) FROM approvals", Dbconnection.conn)
            lblPendingApprovals.Text = pendingCmd.ExecuteScalar().ToString()

            ' Unpaid Bills
            Dim unpaidCmd As New MySqlCommand("SELECT COUNT(*) FROM billing WHERE Status='Pending'", Dbconnection.conn)
            Dim lblUnpaidBills As New Label()
            lblUnpaidBills.Text = unpaidCmd.ExecuteScalar().ToString()

            ' Paid Bills
            Dim paidCmd As New MySqlCommand("SELECT COUNT(*) FROM billing WHERE Status='Paid'", Dbconnection.conn)
            Dim lblPaidBills As New Label()
            lblPaidBills.Text = paidCmd.ExecuteScalar().ToString()

            '-----------------------------
            ' REVENUE CHART
            '-----------------------------
            chartRevenue.Series("Revenue").Points.Clear()
            Dim revenueCmd As New MySqlCommand("SELECT SaleDate, DailyRevenue FROM salesanalytics ORDER BY SaleDate", Dbconnection.conn)
            Dim reader As MySqlDataReader = revenueCmd.ExecuteReader()
            While reader.Read()
                Dim dateStr As String = Convert.ToDateTime(reader("SaleDate")).ToString("yyyy-MM-dd")
                Dim revenue As Decimal = Convert.ToDecimal(reader("DailyRevenue"))
                chartRevenue.Series("Revenue").Points.AddXY(dateStr, revenue)
            End While
            reader.Close()

            '-----------------------------
            ' PC USAGE PIE CHART
            '-----------------------------
            chartPCUsage.Series("PCUsage").Points.Clear()
            Dim pcUsageCmd As New MySqlCommand("SELECT Status, COUNT(*) AS CountStatus FROM computers GROUP BY Status", Dbconnection.conn)
            reader = pcUsageCmd.ExecuteReader()
            While reader.Read()
                chartPCUsage.Series("PCUsage").Points.AddXY(reader("Status").ToString(), Convert.ToInt32(reader("CountStatus")))
            End While
            reader.Close()

            '-----------------------------
            ' TOP 5 PCs COLUMN CHART
            '-----------------------------
            chartTopPCs.Series("TopPCs").Points.Clear()
            Dim topPCsCmd As New MySqlCommand("
                SELECT c.ComputerName, COUNT(s.SaleID) AS SessionCount
                FROM sales s
                JOIN computers c ON s.ComputerID = c.ComputerID
                GROUP BY s.ComputerID
                ORDER BY SessionCount DESC
                LIMIT 5", Dbconnection.conn)
            reader = topPCsCmd.ExecuteReader()
            While reader.Read()
                chartTopPCs.Series("TopPCs").Points.AddXY(reader("ComputerName").ToString(), Convert.ToInt32(reader("SessionCount")))
            End While
            reader.Close()

            '-----------------------------
            ' TOP 5 USERS BAR CHART
            '-----------------------------
            chartTopUsers.Series("TopUsers").Points.Clear()
            Dim topUsersCmd As New MySqlCommand("
                SELECT u.Username, COUNT(s.SaleID) AS SessionCount
                FROM sales s
                JOIN users u ON s.UserID = u.UserID
                GROUP BY s.UserID
                ORDER BY SessionCount DESC
                LIMIT 5", Dbconnection.conn)
            reader = topUsersCmd.ExecuteReader()
            While reader.Read()
                chartTopUsers.Series("TopUsers").Points.AddXY(reader("Username").ToString(), Convert.ToInt32(reader("SessionCount")))
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Dbconnection.CloseConnection()
        End Try
    End Sub

End Class
