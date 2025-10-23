Public Class ownerfrm

    Private Sub btnLogoutHeader_Click(sender As Object, e As EventArgs) Handles btnLogoutHeader.Click
        ' Display a confirmation message box
        If MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Logout") = MsgBoxResult.Yes Then



            Form1.Show()

            Me.Close()
        End If
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class