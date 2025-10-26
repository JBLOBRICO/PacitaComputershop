Imports MySql.Data.MySqlClient

Public Class frmBillingRequest

    '============================
    ' FORM LOAD
    '============================
    Private Sub frmBillingRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
    End Sub

    '============================
    ' OPEN ADD BILLING REQUEST FORM
    '============================
    Private Sub btnRequestBill_Click(sender As Object, e As EventArgs) Handles btnRequestBill.Click
        Dim addForm As New frmAddBillingRequest()
        If addForm.ShowDialog() = DialogResult.OK Then
            LoadBillingData() ' Refresh DataGridView after adding a new bill
        End If
    End Sub

    '============================
    ' LOAD ONLY PENDING BILLING DATA
    '============================
    Private Sub LoadBillingData()
        Try
            OpenConnection()

            Dim query As String = "
                SELECT b.BillID, s.SaleID, b.BillDate, b.Amount, b.Status, 
                       u.FullName AS ApprovedBy
                FROM billing b
                LEFT JOIN users u ON b.ApprovedBy = u.UserID
                LEFT JOIN sales s ON b.SaleID = s.SaleID
                WHERE b.Status = 'Pending'
                ORDER BY b.BillDate DESC
            "

            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            dgvBilling.DataSource = dt

            ' ✅ Update summary labels
            lblTotalBills.Text = $"Total Bills: {dt.Rows.Count} 🧾"
            lblTotalAmount.Text = $"💵 Total Amount: ₱{If(IsDBNull(dt.Compute("SUM(Amount)", "")), 0, dt.Compute("SUM(Amount)", ""))}"
            lblPending.Text = $"🕐 Pending Bills: {dt.Rows.Count}"

        Catch ex As Exception
            MessageBox.Show("Error loading billing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    '============================
    ' MARK BILL AS PAID (REAL-TIME REMOVAL)
    '============================
    Private Sub btnMarkPaid_Click(sender As Object, e As EventArgs) Handles btnMarkPaid.Click
        If dgvBilling.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a bill to mark as paid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvBilling.SelectedRows(0)
        Dim billID As Integer = Convert.ToInt32(selectedRow.Cells("BillID").Value)
        Dim confirm As DialogResult = MessageBox.Show("Mark this bill as PAID?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.No Then Return

        Try
            OpenConnection()

            Dim query As String = "UPDATE billing SET Status='Paid', ApprovedBy=@ApprovedBy WHERE BillID=@BillID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ApprovedBy", LoggedInUserID)
                cmd.Parameters.AddWithValue("@BillID", billID)
                cmd.ExecuteNonQuery()
            End Using

            ' ✅ Remove the row directly from the DataTable (since DataGridView is data-bound)
            Dim dt As DataTable = TryCast(dgvBilling.DataSource, DataTable)
            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    If Convert.ToInt32(row("BillID")) = billID Then
                        dt.Rows.Remove(row)
                        Exit For
                    End If
                Next
                dt.AcceptChanges()
            End If

            ' ✅ Update summary labels
            Dim totalAmount As Decimal = 0
            For Each row As DataGridViewRow In dgvBilling.Rows
                totalAmount += Convert.ToDecimal(row.Cells("Amount").Value)
            Next

            lblTotalBills.Text = $"Total Bills: {dgvBilling.Rows.Count} 🧾"
            lblTotalAmount.Text = $"💵 Total Amount: ₱{totalAmount}"
            lblPending.Text = $"🕐 Pending Bills: {dgvBilling.Rows.Count}"

            MessageBox.Show("Bill marked as Paid successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error updating bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    '============================
    ' RESERVED EVENTS
    '============================
    Private Sub dgvBilling_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBilling.CellContentClick
        ' Reserved for future logic
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        ' Optional custom styling
    End Sub

End Class
