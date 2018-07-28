Public Class PlanodeContas
    Private Sub PlanodeContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        gridcontascriadas()
        txt_busca.Clear()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        sql = "select * from Planodecontas where Codigo like '" & txt_busca.Text & "%' or Nome like '" & txt_busca.Text & "%'"
        rs = db.Execute(sql)
        cont = 1
        dgv_planocontas.Rows.Clear()
        Do While rs.EOF = False
            With dgv_planocontas
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub
    Private Sub dgv_planocontas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_planocontas.CellContentClick
        With dgv_planocontas
            If .CurrentRow.Cells(0).Selected Or .CurrentRow.Cells(1).Selected Then
                resp = MsgBox("Deseja Adicionar Contas ao plano desejado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    planocodigo = .CurrentRow.Cells(0).Value
                    nomeplano = .CurrentRow.Cells(1).Value
                    Me.Hide()
                    CadastrodePlanodeContas.Show()
                End If
            End If
        End With
        With dgv_planocontas
            If .CurrentRow.Cells(2).Selected Then
                resp = MsgBox("Deseja Excluir o plano de contas e todos seus vinculos e contas desejado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "Delete from Planodecontas where Codigo=" & aux & ""
                    rs = db.Execute(sql)
                    sql = "Delete from Contas where Codigo=" & aux & ""
                    rs = db.Execute(sql)
                    sql = "Delete from Vinculadas where CodPlano=" & aux & ""
                    rs = db.Execute(sql)
                    MsgBox("Conta Excluida Com Sucesso!")
                    conexao_banco()
                    gridcontascriadas()
                End If
            End If
        End With
    End Sub

    Private Sub Btn_CriarConta_Click(sender As Object, e As EventArgs) Handles Btn_CriarConta.Click
        gridcontascriadas()
        Close()
        CriaçãoPlanoContas.Show()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        gridcontascriadas()
        Me.Close()
        MenuPrincipal.Show()


    End Sub
End Class