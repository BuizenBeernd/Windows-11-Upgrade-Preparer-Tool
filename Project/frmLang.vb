Public Class frmLang
    Private Sub frmLang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbLanguage.Items.Add("English")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmUserChoice.Show()
        Me.Close()
    End Sub
End Class
