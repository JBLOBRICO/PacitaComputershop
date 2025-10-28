Imports MySql.Data.MySqlClient

Public Class sessionfrm
    ' ====== CONFIGURABLE SETTINGS ======
    Private ratePerHour As Decimal = 20D
    Private sessionDuration As TimeSpan = TimeSpan.FromMinutes(60) ' Default 1 hour session

    ' ====== TRACKING VARIABLES ======
    Private PCStatus As New Dictionary(Of Integer, Boolean)
    Private StartTimes As New Dictionary(Of Integer, DateTime)
    Private SelectedPCID As Integer = -1
    Private SelectedPCName As String = ""
    Private currentStartTime As DateTime
    Private timerRunning As Boolean = False
    Private notificationShown As Boolean = False

    ' ====== FORM LOAD ======
    Private Sub sessionfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComputers()
        lblTimer.Text = "Usage Time: 00:00"
    End Sub

    ' ====== LOAD COMPUTERS ======
    Private Sub LoadComputers()
        Try
            pnlComputers.Controls.Clear()
            OpenConnection()

            Dim query As String = "SELECT * FROM computers"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim pcID As Integer = dr("ComputerID")
                Dim pcName As String = dr("ComputerName").ToString()
                Dim status As String = dr("Status").ToString()

                Dim btnPC As New Button()
                btnPC.Text = pcName
                btnPC.Name = "btnPC" & pcID
                btnPC.Tag = pcID
                btnPC.Width = 120
                btnPC.Height = 100
                btnPC.Margin = New Padding(10)
                btnPC.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                btnPC.FlatStyle = FlatStyle.Flat

                Select Case status
                    Case "Available"
                        btnPC.BackColor = Color.LightGray
                    Case "In Use"
                        btnPC.BackColor = Color.LightGreen
                    Case "Maintenance"
                        btnPC.BackColor = Color.IndianRed
                End Select

                AddHandler btnPC.Click, AddressOf PC_Click
                pnlComputers.Controls.Add(btnPC)

                PCStatus(pcID) = (status = "In Use")
            End While
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading computers: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' ====== SELECT COMPUTER ======
    Private Sub PC_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        SelectedPCID = btn.Tag
        SelectedPCName = btn.Text
        lblPCName.Text = "PC Name: " & SelectedPCName
    End Sub

    ' ====== START SESSION ======
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If SelectedPCID = -1 Then
            MessageBox.Show("Please select a PC first.")
            Return
        End If

        Try
            OpenConnection()

            ' ✅ Check current PC status
            Dim statusQuery As String = "SELECT Status FROM computers WHERE ComputerID=@id"
            cmd = New MySqlCommand(statusQuery, conn)
            cmd.Parameters.AddWithValue("@id", SelectedPCID)
            Dim currentStatus As String = cmd.ExecuteScalar()?.ToString()

            If currentStatus = "In Use" Then
                MessageBox.Show("This PC is already in use.")
                Return
            ElseIf currentStatus = "Maintenance" Then
                MessageBox.Show("This PC is under maintenance and cannot start a session.")
                Return
            End If

            ' ✅ Start the session
            Dim insertQuery As String = "
            INSERT INTO sales (ComputerID, UserID, StartTime, RatePerHour, PaymentStatus)
            VALUES (@compID, @userID, NOW(), @rate, 'Unpaid');"
            cmd = New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@compID", SelectedPCID)
            cmd.Parameters.AddWithValue("@userID", LoggedInUserID)
            cmd.Parameters.AddWithValue("@rate", ratePerHour)
            cmd.ExecuteNonQuery()

            Dim updateQuery As String = "UPDATE computers SET Status='In Use' WHERE ComputerID=@id"
            cmd = New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@id", SelectedPCID)
            cmd.ExecuteNonQuery()

            ' ✅ Start timer
            currentStartTime = DateTime.Now
            timerRunning = True
            sessionTimer.Start()
            lblTimer.Text = "Usage Time: 00:00"
            notificationShown = False

            MessageBox.Show("Session started for " & SelectedPCName)
            LoadComputers()

        Catch ex As Exception
            MessageBox.Show("Error starting session: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub


    ' ====== END SESSION ======
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        If SelectedPCID = -1 Then
            MessageBox.Show("Please select a PC first.")
            Return
        End If

        Try
            OpenConnection()

            ' ✅ Check current PC status
            Dim statusQuery As String = "SELECT Status FROM computers WHERE ComputerID=@id"
            cmd = New MySqlCommand(statusQuery, conn)
            cmd.Parameters.AddWithValue("@id", SelectedPCID)
            Dim currentStatus As String = cmd.ExecuteScalar()?.ToString()

            If currentStatus = "Maintenance" Then
                MessageBox.Show("You cannot end a session for a PC under maintenance.")
                Return
            ElseIf currentStatus = "Available" Then
                MessageBox.Show("No active session found for this PC.")
                Return
            End If

            ' ✅ Get the active unpaid session
            Dim getSaleQuery As String = "SELECT SaleID, StartTime FROM sales WHERE ComputerID=@id AND PaymentStatus='Unpaid' ORDER BY SaleID DESC LIMIT 1"
            cmd = New MySqlCommand(getSaleQuery, conn)
            cmd.Parameters.AddWithValue("@id", SelectedPCID)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim saleID As Integer = dr("SaleID")
                Dim startTime As DateTime = dr("StartTime")
                dr.Close()

                Dim duration As TimeSpan = DateTime.Now - startTime
                Dim hours As Decimal = CDec(duration.TotalHours)
                Dim totalAmount As Decimal = Math.Round(hours * ratePerHour, 2)

                Dim updateSale As String = "UPDATE sales SET EndTime=NOW(), TotalAmount=@total, PaymentStatus='Paid' WHERE SaleID=@saleID"
                cmd = New MySqlCommand(updateSale, conn)
                cmd.Parameters.AddWithValue("@total", totalAmount)
                cmd.Parameters.AddWithValue("@saleID", saleID)
                cmd.ExecuteNonQuery()

                Dim updatePC As String = "UPDATE computers SET Status='Available' WHERE ComputerID=@id"
                cmd = New MySqlCommand(updatePC, conn)
                cmd.Parameters.AddWithValue("@id", SelectedPCID)
                cmd.ExecuteNonQuery()

                sessionTimer.Stop()
                timerRunning = False
                lblTimer.Text = "Usage Time: 00:00"

                MessageBox.Show($"{SelectedPCName} session ended. Total: ₱{totalAmount}", "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadComputers()
            Else
                MessageBox.Show("No active unpaid session found for this PC.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error ending session: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub


    ' ====== SESSION TIMER ======
    Private Sub sessionTimer_Tick(sender As Object, e As EventArgs) Handles sessionTimer.Tick
        If timerRunning Then
            Dim elapsed As TimeSpan = DateTime.Now - currentStartTime
            lblTimer.Text = "Usage Time: " & elapsed.ToString("hh\:mm\:ss")

            ' ⏰ Show 5-minute warning
            Dim remaining As TimeSpan = sessionDuration - elapsed
            If remaining.TotalMinutes <= 5 AndAlso Not notificationShown Then
                MessageBox.Show("⚠️ Session will end in 5 minutes. Please save your work.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
                notificationShown = True
            End If

            ' ⏰ Auto-stop when session time is up
            If elapsed >= sessionDuration Then
                sessionTimer.Stop()
                timerRunning = False
                lblTimer.Text = "Usage Time: 00:00"
                MessageBox.Show("⏰ Session time is over!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub
End Class
