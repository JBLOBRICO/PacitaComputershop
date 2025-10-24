Imports MySql.Data.MySqlClient

Public Class frmBillingRequest

    Private Sub frmBillingRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
    End Sub

    ' Button to open Add Billing Request
    Private Sub btnRequestBill_Click(sender As Object, e As EventArgs) Handles btnRequestBill.Click
        Dim addForm As New frmAddBillingRequest()
        If addForm.ShowDialog() = DialogResult.OK Then
            ' Refresh DataGridView after adding a new bill
            LoadBillingData()
        End If
    End Sub

    ' Load billing data into DataGridView
    Private Sub LoadBillingData()
        Try
            OpenConnection()
            Dim query As String = "SELECT b.BillID, s.SaleID, b.BillDate, b.Amount, b.Status, u.FullName AS ApprovedBy " &
                                  "FROM billing b " &
                                  "LEFT JOIN users u ON b.ApprovedBy = u.UserID " &
                                  "LEFT JOIN sales s ON b.SaleID = s.SaleID " &
                                  "ORDER BY b.BillDate DESC"

            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            dgvBilling.DataSource = dt

            ' Update summary labels
            lblTotalBills.Text = $"Total Bills: {dt.Rows.Count} 🧾"
            lblTotalAmount.Text = $"💵 Total Amount: ₱{dt.Compute("SUM(Amount)", "")}"
            lblPending.Text = $"🕐 Pending Bills: {dt.Select("Status='Pending'").Length}"
        Catch ex As Exception
            MessageBox.Show("Error loading billing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Button to mark selected bill as paid
    Private Sub btnMarkPaid_Click(sender As Object, e As EventArgs) Handles btnMarkPaid.Click
        If dgvBilling.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a bill to mark as paid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim billID As Integer = Convert.ToInt32(dgvBilling.SelectedRows(0).Cells("BillID").Value)

        Try
            OpenConnection()
            Dim query As String = "UPDATE billing SET Status='Paid', ApprovedBy=@ApprovedBy WHERE BillID=@BillID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ApprovedBy", LoggedInUserID)
            cmd.Parameters.AddWithValue("@BillID", billID)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Bill marked as Paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBillingData()
        Catch ex As Exception
            MessageBox.Show("Error updating bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

End Class
