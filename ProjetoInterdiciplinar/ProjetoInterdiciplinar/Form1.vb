Public Class Form1
    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click

        Me.Hide()
        Login.ShowDialog()


    End Sub

    Private Sub btn_criarconta_Click(sender As Object, e As EventArgs) Handles btn_criarconta.Click
        Me.Hide()
        CadastroEmpresa.Show()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()

    End Sub


End Class
