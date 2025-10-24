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
            OpenConnection()
            Dim query As String = "SELECT * FROM users WHERE Username=@user AND Password=@pass"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' ✅ Store global login info
                LoggedInUserID = dr("UserID")
                LoggedInUserRole = dr("Role").ToString()
                LoggedInFullName = dr("FullName").ToString()

                MessageBox.Show("Welcome, " & LoggedInFullName & " (" & LoggedInUserRole & ")!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' ✅ Redirect based on role
                Select Case LoggedInUserRole.ToLower()
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

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class
