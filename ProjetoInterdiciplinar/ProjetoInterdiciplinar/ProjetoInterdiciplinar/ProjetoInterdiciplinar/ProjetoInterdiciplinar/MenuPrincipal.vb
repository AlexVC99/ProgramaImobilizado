Public Class MenuPrincipal
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btn_cadempresa_Click(sender As Object, e As EventArgs) Handles btn_cadempresa.Click
        Me.Hide()
        CadastroEmpresas.Show()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexao_banco()
        sql = "select count(1) FROM Empresas WHERE usuario='" & user & "'"
        rs = db.Execute(sql)
        lbl_empresas.Text = rs.Fields(0).Value
    End Sub

    Private Sub btn_plano_Click(sender As Object, e As EventArgs) Handles btn_plano.Click
        Me.Hide()
        PlanodeContas.Show()

    End Sub
End Class