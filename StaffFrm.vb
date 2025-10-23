Imports Mysqlx.XDevAPI

Public Class StaffFrm
    Private Sub LoadChildForm(ByVal childForm As Form)


        pnlMain.Controls.Clear()

        ' 2. Set the child form's properties to fit inside the panel.
        childForm.TopLevel = False  ' Required to put a Form inside a Control (the Panel)
        childForm.FormBorderStyle = FormBorderStyle.None ' Removes the title bar/borders of the child form
        childForm.Dock = DockStyle.Fill ' Makes the child form automatically resize to fill the whole panel


        pnlMain.Controls.Add(childForm)


        childForm.Show()

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnSession_Click(sender As Object, e As EventArgs) Handles btnSession.Click
        LoadChildForm(New Sessionfrm())
    End Sub
End Class