Public Class Relatorio
    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'bancoDataSet1.Bens'. Você pode movê-la ou removê-la conforme necessário.
        Me.BensTableAdapter.Consulta_benscodigo(Me.bancoDataSet1.Bens, CodigoEmpresa)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
        Cadastrodebens.Show()
    End Sub
End Class