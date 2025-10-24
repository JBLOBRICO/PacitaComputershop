
Imports MySql.Data.MySqlClient
Module Dbconnection
    Public conn As New MySqlConnection("server=localhost;user id=root;password=;database=pacitacmpdb;")
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public LoggedInUserID As Integer
    Public LoggedInUserRole As String
    Public LoggedInFullName As String
    Public loginusername As String
    Public dt As DataTable

    ' ✅ Function to open the connection safely
    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' ✅ Function to close the connection
    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Module
