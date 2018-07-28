Public Class CriaçãoPlanoContas
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
        PlanodeContas.Show()
    End Sub

    Private Sub Btn_CriarConta_Click(sender As Object, e As EventArgs) Handles btn_CriarConta.Click
        If txt_codigo.Text = "" Or txt_nativo.Text = "" Or txt_ndespesa.Text = "" Or txt_nome.Text = "" Or txt_npassivo.Text = "" Or txt_nreceita.Text = "" Then
            MsgBox("Digite todos o campos corretamente")
        Else
            cont2 = Convert.ToInt32(txt_codigo.Text)
            sql = "select * from Planodecontas where Nome = '" & txt_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into Planodecontas values ('" & txt_codigo.Text & "', '" & txt_nome.Text & "', '" & txt_nativo.Text & "', '" & txt_npassivo.Text & "', '" & txt_nreceita.Text & "' , '" & txt_ndespesa.Text & "' )"
                rs = db.Execute(sql)
                MsgBox("Plano de contas criados")
                resp = MsgBox("Deseja Cadastrar outro Plano de conta ?", vbYesNo)
                If resp = vbYes Then
                    txt_codigo.Enabled = True
                    txt_codigo.Text = ""
                    txt_nome.Text = ""
                    txt_nativo.Text = ""
                    txt_ndespesa.Text = ""
                    txt_npassivo.Text = ""
                    txt_nreceita.Text = ""

                    sql = "select Max(Codigo) FROM Planodecontas"
                    rs = db.Execute(sql)
                    If rs.EOF = True Then

                    Else
                        codigo = rs.Fields(0).Value
                        codigo = codigo + 1
                        txt_codigo.Text = codigo
                    End If
                    txt_codigo.Enabled = False
                Else
                    Close()
                    PlanodeContas.Show()
                End If
            Else
                MsgBox("Nome de plano de conta ja utilizado")
                txt_nome.Text = ""
            End If
        End If
    End Sub

    Private Sub CriaçãoPlanoContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        Try
            sql = "select Max(Codigo) FROM Planodecontas"
            rs = db.Execute(sql)
            If rs.EOF = True Then

            Else
                codigo = rs.Fields(0).Value
                codigo = codigo + 1
                txt_codigo.Text = codigo
            End If
            txt_codigo.Enabled = False
        Catch ex As Exception
            codigo = 0
            txt_codigo.Text = codigo
            txt_codigo.Enabled = False
        End Try

    End Sub


End Class