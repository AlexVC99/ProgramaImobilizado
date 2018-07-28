Public Class CadastroEmpresa
    Private Sub CadastroEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_pergunta
            .Items.Add("Nome do Pai")
            .Items.Add("Nome da Mãe")
            .Items.Add("Primeiro Carro")
            .Items.Add("Cidade Natal")
        End With
        conexao_banco()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Hide()
        Form1.ShowDialog()


    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        If txt_nome.Text = "" Or txt_email.Text = "" Or txt_resposta.Text = "" Or txt_cpf.Text = "" Or cmb_pergunta.Text = "" Or txt_rsenha.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha Todos os Campos Corretamente!")
            Exit Sub
        Else
            If txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas Não coincidem!")
                Exit Sub
            Else
                sql = "select * from Usuarios where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("CPF ja cadastrado!")
                    Exit Sub
                Else
                    sql = "insert into Usuarios (Nome, cpf , Email , Pergunta, Resposta, Senha) values ('" & txt_nome.Text & "','" & txt_cpf.Text & "','" & txt_email.Text & "','" & cmb_pergunta.Text & "','" & txt_resposta.Text & "','" & txt_senha.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("Usuario Cadastrado Com Sucesso!!")
                    Me.Close()
                    Login.Show()

                End If
            End If
        End If
    End Sub
End Class