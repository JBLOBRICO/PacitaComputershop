Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class frmSystemMonitor

    '--- Connection String ---


    '--- Load Form ---
    Private Sub frmSystemMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSummaryData()
        LoadActivityLog()
    End Sub

    '====================================
    '   LOAD SUMMARY COUNTS
    '====================================
    Private Sub LoadSummaryData()
        Try
            OpenConnection()

            ' 1️⃣ Total Approvals
            Dim queryApprovals As String = "SELECT COUNT(*) FROM approvals"
            Using cmd As New MySqlCommand(queryApprovals, conn)
                lblApprovalsCount.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' 2️⃣ Billing Requests
            Dim queryBilling As String = "SELECT COUNT(*) FROM billing"
            Using cmd As New MySqlCommand(queryBilling, conn)
                lblBillingCount.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' 3️⃣ Sales Transactions
            Dim querySales As String = "SELECT COUNT(*) FROM sales"
            Using cmd As New MySqlCommand(querySales, conn)
                lblSalesCount.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' 4️⃣ Replacement Requests
            Dim queryReplacements As String = "SELECT COUNT(*) FROM replacements"
            Using cmd As New MySqlCommand(queryReplacements, conn)
                lblReplacementsCount.Text = cmd.ExecuteScalar().ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading summary data: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    '====================================
    '   LOAD ACTIVITY LOG
    '====================================
    Private Sub LoadActivityLog()
        Try
            OpenConnection()

            Dim query As String = "
                SELECT 'Approval' AS ActivityType, a.ApprovalDate AS ActivityDate, u.FullName AS PerformedBy, a.Remarks AS Details
                FROM approvals a
                INNER JOIN users u ON a.ApprovedBy = u.UserID

                UNION ALL

                SELECT 'Billing' AS ActivityType, b.BillDate AS ActivityDate, u.FullName AS PerformedBy,
                       CONCAT('Bill ID: ', b.BillID, ' | Amount: ₱', FORMAT(b.Amount,2), ' | Status: ', b.Status)
                FROM billing b
                LEFT JOIN users u ON b.ApprovedBy = u.UserID

                UNION ALL

                SELECT 'Sales' AS ActivityType, s.StartTime AS ActivityDate, u.FullName AS PerformedBy,
                       CONCAT('Sale ID: ', s.SaleID, ' | Computer: ', c.ComputerName, ' | Amount: ₱', FORMAT(s.TotalAmount,2))
                FROM sales s
                INNER JOIN computers c ON s.ComputerID = c.ComputerID
                INNER JOIN users u ON s.UserID = u.UserID

                UNION ALL

                SELECT 'Replacement' AS ActivityType, r.RequestDate AS ActivityDate, u.FullName AS PerformedBy,
                       CONCAT('Item: ', r.ItemName, ' | Status: ', r.Status)
                FROM replacements r
                LEFT JOIN users u ON r.ApprovedBy = u.UserID

                ORDER BY ActivityDate DESC
                LIMIT 50;
            "

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvActivities.DataSource = dt

            ' Optional: Make column headers more readable
            dgvActivities.Columns("ActivityType").HeaderText = "Activity Type"
            dgvActivities.Columns("ActivityDate").HeaderText = "Date"
            dgvActivities.Columns("PerformedBy").HeaderText = "Performed By"
            dgvActivities.Columns("Details").HeaderText = "Details"

        Catch ex As Exception
            MessageBox.Show("Error loading activity log: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    '====================================
    '   OPTIONAL: REFRESH BUTTON (Add one in UI if you like)
    '====================================
    Private Sub RefreshData()
        LoadSummaryData()
        LoadActivityLog()
    End Sub

    Private Sub dgvActivities_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivities.CellContentClick

    End Sub
End Class
