Public Class NovoBen
    Private Sub NovoBen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()


        Try
            sql = "select Max(CodBem) FROM Bens"
            rs = db.Execute(sql)

            If rs.EOF = True Then

            Else
                codigo = rs.Fields(0).Value
                codigo = codigo + 1
                txt_codigo.Text = codigo
            End If
        Catch ex As Exception
            codigo = 200
            txt_codigo.Text = codigo
        End Try
        Try
            sql = "select * from Vinculadas where CodEmpresa like '" & CodigoEmpresa & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_conta.Text = rs.Fields(3).Value
                txt_depconta.Text = rs.Fields(4).Value
                txt_nomedep.Text = rs.Fields(5).Value
                sql = "select * from Contas where Chamada like '" & txt_depconta.Text & "' and descConta like'" & txt_nomedep.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_dep.Text = rs.Fields(4).Value
                End If
            End If
        Catch ex As Exception

        End Try

        txt_codigo.Enabled = False
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If txt_codigo.Text = "" Or txt_conta.Text = "" Or txt_desc.Text = "" Or bemsofre = "" Or usobem = "" Or txt_valorbase.Text = "" Or txt_dep.Text = "" Or txt_data.Text = "" Or txt_depconta.Text = "" Or txt_nomedep.Text = "" Or txt_valorinicial.Text = "" Or txt_valorCorrigido.Text = "" Then
            MsgBox("Digite os valores corretamente")
        Else
            Dim aux30 As Double
            aux30 = 0
            sql = "insert into Bens values ('" & CodigoEmpresa & "','" & txt_codigo.Text & "', '" & txt_conta.Text & "','" & txt_desc.Text & "','" & bemsofre & "','" & usobem & "', '" & txt_valorbase.Text & "', '" & txt_dep.Text & "', '" & txt_data.Text & "', '" & txt_depconta.Text & "', '" & txt_nomedep.Text & "', '" & txt_valorinicial.Text & "', '" & txt_valorCorrigido.Text & "', '" & FormatCurrency(aux30) & " ', '" & FormatCurrency(aux30) & "')"
            rs = db.Execute(sql)
            MsgBox("Bem adicionado com sucesso !!")
            Close()
            Cadastrodebens.Show()
        End If
    End Sub

    Private Sub rdb_sim_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_sim.CheckedChanged
        txt_dep.Enabled = True
        txt_depconta.Enabled = True
        txt_nomedep.Enabled = True
        txt_valorinicial.Enabled = True
        txt_valorCorrigido.Text = ""
        txt_valorinicial.Text = ""
        Try
            sql = "select * from Vinculadas where CodEmpresa like '" & CodigoEmpresa & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_conta.Text = rs.Fields(3).Value
                txt_depconta.Text = rs.Fields(4).Value
                txt_nomedep.Text = rs.Fields(5).Value
                sql = "select * from Contas where Chamada like '" & txt_depconta.Text & "' and descConta like'" & txt_nomedep.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_dep.Text = rs.Fields(4).Value
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdb_nao_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_nao.CheckedChanged
        bemsofre = "Não"
        txt_dep.Text = "0"
        txt_depconta.Text = "0"
        txt_nomedep.Text = "Não existe depreciação"
        txt_valorinicial.Text = "0"
        txt_dep.Enabled = False
        txt_depconta.Enabled = False
        txt_nomedep.Enabled = False
        txt_valorinicial.Enabled = False
        txt_valorCorrigido.Text = "0"

    End Sub

    Private Sub rdb_administrativo_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_administrativo.CheckedChanged
        usobem = "Administrativo"
    End Sub

    Private Sub rdb_industrial_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_industrial.CheckedChanged
        usobem = "Industrial"
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
        Cadastrodebens.Show()

    End Sub

    Private Sub txt_valorinicial_LostFocus(sender As Object, e As EventArgs) Handles txt_valorinicial.LostFocus
        Dim base As Double
        Dim dep As Double
        Dim final As Double
        base = FormatCurrency(txt_valorbase.Text)
        dep = FormatCurrency(txt_valorinicial.Text)
        final = base - dep
        txt_valorCorrigido.Text = FormatCurrency(final)
        txt_valorinicial.Text = FormatCurrency(txt_valorinicial.Text)

    End Sub

    Private Sub txt_valorbase_LostFocus(sender As Object, e As EventArgs) Handles txt_valorbase.LostFocus
        txt_valorbase.Text = FormatCurrency(txt_valorbase.Text)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class