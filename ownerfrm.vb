﻿Public Class ownerfrm

    Public Sub New()
        InitializeComponent()
        ' Turn on double buffering to prevent flicker
        Me.DoubleBuffered = True
        SetDoubleBuffered(pnlMain)
    End Sub

    Private Sub LoadChildForm(childForm As Form)
        pnlMain.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadChildForm(New ownerdashboardfrm())
    End Sub

    Private Sub SetDoubleBuffered(ByVal c As Control)
        ' Enable double buffering via reflection
        Dim pi As System.Reflection.PropertyInfo = c.GetType().GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        If pi IsNot Nothing Then
            pi.SetValue(c, True, Nothing)
        End If
    End Sub

    Private Sub btnSalesAnalytics_Click(sender As Object, e As EventArgs) Handles btnSalesAnalytics.Click
        LoadChildForm(New frmanalytics())
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnApprovals_Click(sender As Object, e As EventArgs) Handles btnApprovals.Click
        LoadChildForm(New frmBillingApproval())
    End Sub

    Private Sub btnMonitoring_Click(sender As Object, e As EventArgs) Handles btnMonitoring.Click
        LoadChildForm(New frmSystemMonitor())
    End Sub
End Class
