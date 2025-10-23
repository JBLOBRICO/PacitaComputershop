Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "SELECT * FROM users WHERE Username=@user AND Password=@pass"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim role As String = reader("Role").ToString()
                    MessageBox.Show("Welcome, " & txtUsername.Text & " (" & role & ")!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Select Case role.ToLower()
                        Case "owner"
                            Dim ownerForm As New ownerfrm()
                            ownerForm.Show()
                        Case "admin"
                            Dim adminForm As New AdminFrm()
                            adminForm.Show()
                        Case "staff"
                            Dim staffForm As New StaffFrm()
                            staffForm.Show()
                    End Select

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
