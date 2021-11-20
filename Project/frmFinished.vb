Imports System.Net

Public Class frmFinished
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If cB_StartWin11Install.Checked = True Then
            Process.Start("https://go.microsoft.com/fwlink/?linkid=2156295")
            Application.Exit()
        ElseIf cB_StartWin11Install.Checked = False Then
            Application.Exit()
        End If
    End Sub
End Class