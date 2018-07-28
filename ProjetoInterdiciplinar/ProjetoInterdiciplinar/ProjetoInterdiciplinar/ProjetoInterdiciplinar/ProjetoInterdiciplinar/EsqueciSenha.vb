Public Class EsqueciSenha
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub EsqueciSenha_Load(sender As Object, e As EventArgs) Handles Me.Load
        With cmb_pergunta
            .Items.Add("Nome do Pai")
            .Items.Add("Nome da Mãe")
            .Items.Add("Primeiro Carro")
            .Items.Add("Cidade Natal")
        End With
        conexao_banco()
    End Sub

    Private Sub btn_obter_Click(sender As Object, e As EventArgs) Handles btn_obter.Click
        If txt_user.Text = "" Or txt_resp.Text = "" Or txt_cpf.Text = "" Or cmb_pergunta.Text = "" Then
            MsgBox("Preencha Todos os Campos!!")
            Exit Sub
        Else
            sql = "select * from Usuarios where Nome='" & txt_user.Text & "' or Email='" & txt_user.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                MsgBox("Conta Não Encontrada!!")
                Exit Sub
            Else
                If txt_cpf.Text <> rs.Fields(2).Value Or txt_resp.Text <> rs.Fields(5).Value Or cmb_pergunta.Text <> rs.Fields(4).Value Then
                    MsgBox("Dados Incorretos!")
                    Exit Sub
                Else
                    Dim senha As String
                    senha = rs.Fields(6).Value
                    MsgBox("Senha : " & senha & "")
                    Exit Sub
                    Me.Hide()
                    Login.Show()

                End If
            End If
        End If
    End Sub
End Class