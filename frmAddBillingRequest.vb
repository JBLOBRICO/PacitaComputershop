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

            ' Decide SaleID
            Dim saleID As Object = DBNull.Value ' default: not linked to a sale
            If Not String.IsNullOrEmpty(txtSaleID.Text.Trim()) Then
                Dim tempID As Integer
                If Integer.TryParse(txtSaleID.Text.Trim(), tempID) Then
                    ' Check if SaleID exists in sales table
                    Dim checkQuery As String = "SELECT COUNT(*) FROM sales WHERE SaleID = @CheckID"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@CheckID", tempID)
                        Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If exists > 0 Then
                            saleID = tempID ' valid SaleID
                        Else
                            MessageBox.Show("SaleID does not exist. Billing will be saved without linking to a sale.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Else
                    MessageBox.Show("Invalid SaleID format. Billing will be saved without linking to a sale.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            ' Insert billing
            Dim query As String = "INSERT INTO billing (SaleID, Amount, Status, ApprovedBy) " &
                              "VALUES (@SaleID, @Amount, @Status, @ApprovedBy)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SaleID", saleID)
                cmd.Parameters.AddWithValue("@Amount", amountValue)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ApprovedBy", DBNull.Value) ' Not approved yet

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Billing request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error adding billing request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub


    ' Cancel button click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
