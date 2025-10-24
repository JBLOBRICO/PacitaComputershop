Imports MySql.Data.MySqlClient

Public Class frmAddBillingRequest

    ' Load event: set default values
    Private Sub frmAddBillingRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default Status
        cmbStatus.SelectedIndex = 0 ' Pending
    End Sub

    ' Save button click
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate Amount
        Dim amountValue As Decimal
        If Not Decimal.TryParse(txtAmount.Text.Trim(), amountValue) Then
            MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Return
        End If

        Try
            OpenConnection() ' Your function to open MySQL connection

            Dim query As String = "INSERT INTO billing (SaleID, Amount, Status, ApprovedBy) " &
                                  "VALUES (@SaleID, @Amount, @Status, @ApprovedBy)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SaleID", 0) ' placeholder
                cmd.Parameters.AddWithValue("@Amount", amountValue)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ApprovedBy", DBNull.Value) ' NULL since not approved yet

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Billing request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error adding billing request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection() ' Your function to close MySQL connection
        End Try
    End Sub

    ' Cancel button click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
