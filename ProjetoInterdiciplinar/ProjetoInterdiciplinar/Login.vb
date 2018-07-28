Public Class Login
    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        If txt_login.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha Os Campos Corretamente!")
            Exit Sub
        Else
            sql = "select * from Usuarios where Nome='" & txt_login.Text & "' or Email= '" & txt_login.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                MsgBox("Usuario não Encontrado!")
                Exit Sub
            Else
                If txt_senha.Text <> rs.Fields(6).Value Then
                    MsgBox("Senha Incorreta!")
                    Exit Sub
                Else
                    user = rs.Fields(1).Value
                    MsgBox("Logado Com Sucesso!")
                    Close()
                    MenuPrincipal.Show()
                    txt_login.Clear()
                    txt_senha.Clear()
                End If
            End If
            End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexao_banco()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Me.Hide()
        CadastroEmpresa.Show()

    End Sub

    Private Sub btn_esqueci_Click(sender As Object, e As EventArgs) Handles btn_esqueci.Click
        Me.Hide()
        EsqueciSenha.Show()

    End Sub

End Class