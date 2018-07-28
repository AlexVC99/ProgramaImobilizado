Public Class MenuPrincipal
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        resp = MsgBox("Deseja realmente deslogar do sistema ?", vbYesNo)
        If resp = vbYes Then
            Me.Close()
            Login.Show()
        Else

        End If
    End Sub

    Private Sub btn_cadempresa_Click(sender As Object, e As EventArgs) Handles btn_cadempresa.Click
        Me.Hide()
        CadastroEmpresas.Show()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexao_banco()
        sql = "select count(1) FROM Empresas WHERE usuario='" & user & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            sql = "select count(1) FROM bens "
            rs = db.Execute(sql)
            lbl_bens.Text = rs.Fields(0).Value
            lbl_empresas.Text = rs.Fields(0).Value
        End If

    End Sub

    Private Sub btn_plano_Click(sender As Object, e As EventArgs) Handles btn_plano.Click
        Me.Hide()
        PlanodeContas.Show()

    End Sub

    Private Sub btn_relatorio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_bens_Click(sender As Object, e As EventArgs) Handles btn_bens.Click
        Me.Hide()
        Cadastrodebens.Show()
    End Sub


End Class