Public Class VincularEmpresa
    Private Sub VincularEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        gridcontascriadasvinculos()
    End Sub



    Private Sub txt_codigo_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo.LostFocus
        Try
            sql = "select * from Empresas where Cadastro=" & txt_codigo.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome.Text = rs.Fields(1).Value
                txt_nome.Enabled = False
                CodigoEmpresa = rs.Fields(0).Value
                nomeempresa = rs.Fields(1).Value
                Try
                    sql = "select * from Vinculadas where CodEmpresa=" & txt_codigo.Text & ""
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_nome.Text = rs.Fields(1).Value
                        txt_plano.Text = rs.Fields(2).Value
                        txt_centro.Text = rs.Fields(5).Value
                        txt_livro.Text = rs.Fields(6).Value
                        txt_pagina.Text = rs.Fields(7).Value

                        If rs.Fields(8).Value = "Sim" Then
                            rdb_sim.Checked = True
                        Else
                            rdb_nao.Checked = True
                        End If
                        gatilho = 1
                        Btn_desvincular.Enabled = True
                    Else
                        gatilho = 0
                        txt_plano.Clear()
                        txt_centro.Clear()
                        txt_livro.Clear()
                        txt_pagina.Clear()


                    End If
                Catch ex As Exception

                End Try
            Else
                Btn_desvincular.Enabled = False
                txt_nome.Clear()
                txt_codigo.Clear()
                Exit Sub
            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub txt_nome_LostFocus(sender As Object, e As EventArgs) Handles txt_nome.LostFocus

        sql = "select * from Empresas where Nome like '" & txt_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then

            txt_codigo.Text = rs.Fields(0).Value
            txt_codigo.Enabled = False
            txt_nome.Enabled = True
            CodigoEmpresa = rs.Fields(0).Value
            nomeempresa = rs.Fields(1).Value
            Try
                sql = "select * from Vinculadas where CodEmpresa=" & txt_codigo.Text & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_nome.Text = rs.Fields(1).Value
                    txt_plano.Text = rs.Fields(2).Value
                    txt_centro.Text = rs.Fields(5).Value
                    txt_livro.Text = rs.Fields(6).Value
                    txt_pagina.Text = rs.Fields(7).Value

                    If rs.Fields(8).Value = "Sim" Then
                        rdb_sim.Checked = True
                    Else
                        rdb_nao.Checked = True
                    End If
                    gatilho = 1
                    Btn_desvincular.Enabled = True
                Else
                    gatilho = 0
                    txt_plano.Clear()
                    txt_centro.Clear()
                    txt_livro.Clear()
                    txt_pagina.Clear()


                End If
            Catch ex As Exception

            End Try
        Else
            Btn_desvincular.Enabled = False
            txt_nome.Clear()
            txt_codigo.Clear()
            Exit Sub
        End If

    End Sub



    Private Sub txt_nome_GotFocus(sender As Object, e As EventArgs) Handles txt_nome.GotFocus
        txt_codigo.Clear()
        txt_nome.Clear()
        txt_plano.Clear()
        txt_centro.Clear()
        txt_livro.Clear()
        txt_pagina.Clear()
        Btn_desvincular.Enabled = False
        rdb_nao.Checked = False
        rdb_sim.Checked = False
        txt_codigo.Enabled = True
    End Sub

    Private Sub txt_codigo_GotFocus(sender As Object, e As EventArgs) Handles txt_codigo.GotFocus
        txt_codigo.Clear()
        txt_nome.Clear()
        txt_nome.Enabled = True
        txt_plano.Clear()
        txt_centro.Clear()
        txt_livro.Clear()
        txt_pagina.Clear()
        Btn_desvincular.Enabled = False
        rdb_nao.Checked = False
        rdb_sim.Checked = False
        txt_codigo.Enabled = True
    End Sub



    Private Sub txt_plano_LostFocus(sender As Object, e As EventArgs) Handles txt_plano.LostFocus

    End Sub



    Private Sub txt_centro_LostFocus(sender As Object, e As EventArgs) Handles txt_centro.LostFocus


    End Sub

    Private Sub btn_vincular_Click(sender As Object, e As EventArgs) Handles btn_vincular.Click
        If gatilho = 1 Then
            If txt_codigo.Text = "" Or txt_nome.Text = "" Or txt_plano.Text = "" Or txt_centro.Text = "" Or txt_pagina.Text = "" Or txt_livro.Text = "" Or depreciacao = "" Then
                MsgBox("Digite todos campos corretamente")
            Else
                sql = "update Vinculadas set NomePlano='" & txt_plano.Text & "', CodPlano='" & plano & "', Chamada='" & Chamada1 & "', DescConta='" & txt_centro.Text & "', Livro='" & txt_livro.Text & "', Pagina='" & txt_pagina.Text & "', Depreciacao='" & depreciacao & "' where CodEmpresa=" & CodigoEmpresa & ""
                rs = db.Execute(sql)
                gatilho = 0
                MsgBox("Empresa alterada com sucesso")
                Close()
                CadastroEmpresas.Show()
            End If
        Else
            If txt_codigo.Text = "" Or txt_nome.Text = "" Or txt_plano.Text = "" Or txt_centro.Text = "" Or txt_pagina.Text = "" Or txt_livro.Text = "" Or depreciacao = "" Then
                MsgBox("Digite todos campos corretamente")
            Else

                sql = "insert into Vinculadas  ( CodEmpresa, NomeEmpresa, NomePlano, CodPlano, Chamada, DescConta, Livro, Pagina, Depreciacao) values ('" & CodigoEmpresa & "', '" & nomeempresa & "','" & nomeplano & "', '" & plano & "', '" & Chamada1 & "' , '" & txt_centro.Text & "' , '" & txt_livro.Text & "' , '" & txt_pagina.Text & "' , '" & depreciacao & "' )"
                rs = db.Execute(sql)
                MsgBox("Conta vinculada com sucesso")
                resp = MsgBox("Deseja Vincular outras empresas", vbYesNo)
                If resp = vbYes Then
                    txt_codigo.Clear()
                    txt_nome.Clear()
                    txt_plano.Clear()
                    txt_centro.Clear()
                    txt_pagina.Clear()
                    txt_livro.Clear()
                    dgv_contas.Rows.Clear()
                    rdb_nao.Checked = False
                    rdb_sim.Checked = False
                    Btn_desvincular.Enabled = False
                Else
                    Close()
                    CadastroEmpresas.Show()

                End If
            End If
        End If
    End Sub

    Private Sub rdb_sim_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_sim.CheckedChanged
        depreciacao = "Sim"
    End Sub

    Private Sub rdb_nao_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_nao.CheckedChanged
        depreciacao = "Não"
    End Sub



    Private Sub txt_plano_GotFocus(sender As Object, e As EventArgs) Handles txt_plano.GotFocus
        txt_centro.Clear()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
        CadastroEmpresas.Show()
        gatilho = 0
    End Sub

    Private Sub dgv_planos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_planos.CellContentClick
        With dgv_planos
            If .CurrentRow.Cells(0).Selected Or .CurrentRow.Cells(1).Selected Then
                txt_centro.Clear()
                txt_plano.Text = .CurrentRow.Cells(1).Value

                plano = .CurrentRow.Cells(0).Value
                nomeplano = .CurrentRow.Cells(1).Value
                sql = "select * from Contas where Codigo like '" & plano & "'order by Chamada asc"
                rs = db.Execute(sql)
                cont = 1
                dgv_contas.Rows.Clear()
                Do While rs.EOF = False
                    With dgv_contas
                        .Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value)
                        cont += 1
                        rs.MoveNext()
                    End With
                Loop
            End If
        End With
    End Sub

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        With dgv_contas
            If .CurrentRow.Cells(0).Selected Or .CurrentRow.Cells(1).Selected Then
                txt_centro.Text = .CurrentRow.Cells(1).Value
                Chamada1 = .CurrentRow.Cells(0).Value
                descconta = .CurrentRow.Cells(1).Value
            End If
        End With
    End Sub

    Private Sub Btn_desvincular_Click(sender As Object, e As EventArgs) Handles Btn_desvincular.Click
        resp = MsgBox("Deseja realmente Vincular empresa desse plano de contas ?", vbYesNo)
        If resp = vbYes Then
            sql = "Delete from Vinculadas where CodEmpresa=" & txt_codigo.Text & ""
            rs = db.Execute(sql)
            MsgBox("Conta desvinculada com sucesso")
            txt_codigo.Clear()
            txt_nome.Clear()
            txt_plano.Clear()
            txt_centro.Clear()
            txt_pagina.Clear()
            txt_livro.Clear()
            dgv_contas.Rows.Clear()
            rdb_nao.Checked = False
            rdb_sim.Checked = False
        End If
    End Sub
End Class