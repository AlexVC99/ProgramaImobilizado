Public Class VincularEmpresa
    Private Sub VincularEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
    End Sub



    Private Sub txt_codigo_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo.LostFocus
        Try
            sql = "select * from Empresas where Cadastro=" & txt_codigo.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome.Text = rs.Fields(1).Value
                txt_nome.Enabled = False
            Else

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
        Else
            txt_nome.Clear()
            txt_codigo.Clear()
            Exit Sub
        End If
    End Sub



    Private Sub txt_nome_GotFocus(sender As Object, e As EventArgs) Handles txt_nome.GotFocus
        txt_codigo.Clear()
        txt_nome.Clear()

        txt_codigo.Enabled = True
    End Sub

    Private Sub txt_codigo_GotFocus(sender As Object, e As EventArgs) Handles txt_codigo.GotFocus
        txt_codigo.Clear()
        txt_nome.Clear()

        txt_nome.Enabled = True
    End Sub



    Private Sub txt_plano_LostFocus(sender As Object, e As EventArgs) Handles txt_plano.LostFocus
        sql = "select * from Planodecontas where Nome like '" & txt_plano.Text & "%' or Codigo like '" & txt_plano.Text & "%'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_plano.Text = rs.Fields(0).Value
            plano = rs.Fields(0).Value
        Else
            txt_plano.Clear()
        End If

    End Sub



    Private Sub txt_centro_LostFocus(sender As Object, e As EventArgs) Handles txt_centro.LostFocus

        sql = "select * from Contas where Codigo like '" & plano & "%' and DescConta like '" & txt_centro.Text & "%'"
        rs = db.Execute(sql)
            If rs.EOF = False Then
            txt_centro.Text = rs.Fields(3).Value

        Else
                txt_centro.Clear()
            End If

    End Sub
End Class