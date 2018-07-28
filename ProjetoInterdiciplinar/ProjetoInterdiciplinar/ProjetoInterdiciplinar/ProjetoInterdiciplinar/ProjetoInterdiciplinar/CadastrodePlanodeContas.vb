Public Class CadastrodePlanodeContas
    Private Sub CadastrodePlanodeContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_codigo.Text = planocodigo
        lbl_nome.Text = nomeplano
        Module1.conexao_banco()
        gridcontas()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
        PlanodeContas.Show()

    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        If txt_chamada.Text = "" Or txt_classifica.Text = "" Or txt_desc.Text = "" Or txt_taxa.Text = "" Then
            MsgBox("Preencha TODOS os Campos!")
        Else

            sql = "insert into Contas (Codigo, Chamada, ClassificacaoInterna, DescConta, TaxaDep, Origem) values ('" & planocodigo & "', '" & txt_chamada.Text & "','" & txt_classifica.Text & "', '" & txt_desc.Text & "', '" & txt_taxa.Text & "' , '" & origem & "')"
            rs = db.Execute(sql)

        End If
        gridcontas()
    End Sub

    Private Sub rdb_credora_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_credora.CheckedChanged
        origem = "credora"
    End Sub

    Private Sub rdb_dev_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_dev.CheckedChanged
        origem = "devedora"
    End Sub

    Private Sub rdb_indefinida_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_indefinida.CheckedChanged
        origem = "Indefinida"
    End Sub


End Class
