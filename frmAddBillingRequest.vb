Imports MySql.Data.MySqlClient

Public Class frmAddBillingRequest

    Private Sub frmAddBillingRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default values
        cmbStatus.SelectedIndex = 0 ' Pending
        cmbCategory.SelectedIndex = 0 ' Billing by default
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic validation
        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim amountValue As Decimal
        If Not Decimal.TryParse(txtAmount.Text.Trim(), amountValue) Then
            MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenConnection() ' Make sure you have this function in your Dbconnection module

            Dim category As String = cmbCategory.SelectedItem.ToString()

            If category = "Replacement" Then
                ' =============================
                ' INSERT INTO replacements
                ' =============================
                Dim query As String = "INSERT INTO replacements (ComputerID, ItemName, Description, Cost, Status, ApprovedBy) " &
                                      "VALUES (@ComputerID, @ItemName, @Description, @Cost, @Status, NULL)"
                Using cmd As New MySqlCommand(query, conn)
                    ' For demo, let’s assume default ComputerID = 1 (you can replace this with a ComboBox if needed)
                    cmd.Parameters.AddWithValue("@ComputerID", 1)
                    cmd.Parameters.AddWithValue("@ItemName", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@Cost", amountValue)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Replacement request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                ' =============================
                ' INSERT INTO billing
                ' =============================
                Dim saleID As Object = DBNull.Value
                If Not String.IsNullOrEmpty(txtsaleid.Text.Trim()) Then
                    Dim tempID As Integer
                    If Integer.TryParse(txtsaleid.Text.Trim(), tempID) Then
                        saleID = tempID
                    End If
                End If

                Dim query As String = "INSERT INTO billing (SaleID, Amount, Status, ApprovedBy) " &
                                      "VALUES (@SaleID, @Amount, @Status, NULL)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SaleID", saleID)
                    cmd.Parameters.AddWithValue("@Amount", amountValue)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Billing request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Close the form after successful insert
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error adding request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
