Public Class CadastroEmpresas
    Private Sub CadastroEmpresas_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexao_banco()
        gridEmpresas()
        txt_busca.Clear()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Hide()
        CadastroEmpresarial.Show()

    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        sql = "select * from Empresas where Cadastro like '" & txt_busca.Text & "%' or Nome like '" & txt_busca.Text & "%' and usuario='" & user & "'"
        rs = db.Execute(sql)
        cont = 1
        dgv_empresas.Rows.Clear()
        Do While rs.EOF = False
            With dgv_empresas
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub

    Private Sub txt_busca_GotFocus(sender As Object, e As EventArgs) Handles txt_busca.GotFocus
        gridEmpresas()

    End Sub

    Private Sub dgv_empresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empresas.CellContentClick
        With dgv_empresas
            If .CurrentRow.Cells(0).Selected Or .CurrentRow.Cells(1).Selected Or .CurrentRow.Cells(2).Selected Or .CurrentRow.Cells(3).Selected Or .CurrentRow.Cells(4).Selected Then
                resp = MsgBox("Deseja Remover a empresa selecionada ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "Delete from Empresas where Cadastro=" & aux & ""
                    rs = db.Execute(sql)
                    MsgBox("Empresa Excluida Com Sucesso!")
                    conexao_banco()
                    gridEmpresas()
                    txt_busca.Clear()
                End If
            End If
        End With
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub
End Class