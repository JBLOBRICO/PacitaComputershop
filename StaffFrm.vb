Imports Mysqlx.XDevAPI

Public Class StaffFrm
    Private Sub LoadChildForm(childForm As Form)
        pnlMain.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Public Sub New()
        InitializeComponent()

        ' Turn on double buffering to prevent flicker
        Me.DoubleBuffered = True
        SetDoubleBuffered(pnlMain)
    End Sub

    Private Sub SetDoubleBuffered(ctrl As Control)
        If SystemInformation.TerminalServerSession Then Return
        Dim prop = ctrl.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        prop.SetValue(ctrl, True, Nothing)
    End Sub


    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnSession_Click(sender As Object, e As EventArgs) Handles btnSession.Click
        LoadChildForm(New Sessionfrm())
    End Sub

    Private Sub btnPCStatus_Click(sender As Object, e As EventArgs) Handles btnPCStatus.Click
        LoadChildForm(New Frmpcstatus())
    End Sub
End Class