Public Class CadastrodePlanodeContas
    Private Sub CadastrodePlanodeContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_codigo.Text = planocodigo
        lbl_nome.Text = nomeplano
        Module1.conexao_banco()
        gridcontas()
        Try
            sql = "select Max(Chamada) FROM Contas"
            rs = db.Execute(sql)
            If rs.EOF = True Then
            Else
                Chamada1 = rs.Fields(0).Value
                Chamada1 = Chamada1 + 1
                txt_chamada.Text = Chamada1
            End If
            txt_chamada.Enabled = False
        Catch ex As Exception
            Chamada1 = 1
            txt_chamada.Text = Chamada1
            txt_chamada.Enabled = False
        End Try
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
        PlanodeContas.Show()

    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        If txt_chamada.Text = "" Or txt_classifica.Text = "" Or txt_desc.Text = "" Or txt_taxa.Text = "" Then
            MsgBox("Preencha TODOS os Campos!")
        Else
            sql = "select * from Contas where Codigo like '" & planocodigo & "' and ClassificacaoInterna like '" & txt_classifica.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into Contas (Codigo, Chamada, ClassificacaoInterna, DescConta, TaxaDep, Origem) values ('" & planocodigo & "', '" & txt_chamada.Text & "','" & txt_classifica.Text & "', '" & txt_desc.Text & "', '" & txt_taxa.Text & "' , '" & origem & "')"
                rs = db.Execute(sql)
                sql = "select Max(Chamada) FROM Contas"
                rs = db.Execute(sql)
                If rs.EOF = True Then

                Else
                    Chamada1 = rs.Fields(0).Value
                    Chamada1 = Chamada1 + 1
                    txt_chamada.Text = Chamada1
                    txt_chamada.Enabled = True
                End If
                txt_chamada.Enabled = False
            Else
                MsgBox("Classificação indisponivel")
            End If
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

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        With dgv_contas
            If .CurrentRow.Cells(0).Selected Or .CurrentRow.Cells(1).Selected Or .CurrentRow.Cells(2).Selected Then
                resp = MsgBox("Deseja Remover a Conta selecionada ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "Delete from Contas where Codigo=" & planocodigo & " and  Chamada=" & aux & "  "
                    rs = db.Execute(sql)
                    MsgBox("Conta Excluida Com Sucesso!")
                    conexao_banco()
                    gridcontas()

                End If
            End If
        End With

    End Sub
End Class
