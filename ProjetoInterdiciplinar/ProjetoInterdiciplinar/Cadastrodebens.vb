Public Class Cadastrodebens


    Private Sub txt_codigo_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo.LostFocus
        sql = "select * from Empresas where Cadastro like '" & txt_codigo.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nome.Text = rs.Fields(1).Value
            txt_nome.Enabled = False
            txt_codigo.Enabled = True
            CodigoEmpresa = rs.Fields(0).Value
        Else
            txt_nome.Clear()
            txt_codigo.Clear()
        End If
    End Sub

    Private Sub Cadastrodebens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()

    End Sub

    Private Sub txt_codigo_GotFocus(sender As Object, e As EventArgs) Handles txt_codigo.GotFocus
        txt_nome.Enabled = True
        txt_nome.Clear()
        txt_codigo.Clear()
        dgv_controle.Rows.Clear()
        btn_adicionar.Enabled = False
        Button1.Enabled = False
    End Sub



    Private Sub txt_nome_LostFocus(sender As Object, e As EventArgs) Handles txt_nome.LostFocus
        sql = "select * from Empresas where Nome like '" & txt_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_codigo.Text = rs.Fields(0).Value
            txt_codigo.Enabled = False
            CodigoEmpresa = rs.Fields(0).Value

        Else
            txt_nome.Clear()
            txt_codigo.Clear()
        End If
    End Sub

    Private Sub txt_nome_GotFocus(sender As Object, e As EventArgs) Handles txt_nome.GotFocus
        txt_codigo.Enabled = True
        txt_codigo.Clear()
        dgv_controle.Rows.Clear()
        btn_adicionar.Enabled = False
        Button1.Enabled = False
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If txt_codigo.Text = "" Or txt_nome.Text = "" Then
            MsgBox("Prencha os campos para a pesquisa de empresas")

        Else
            btn_adicionar.Enabled = True
            Button1.Enabled = True
            gridbens()
            For Each row As DataGridViewRow In dgv_controle.Rows
                id = row.Cells(0).Value
                sql = "select DateDiff('yyyy',[DataBase],Date()) as dif_ano from Bens where CodBem=" & id & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    diferenca = rs.Fields(0).Value
                    sql = "select * from Bens where CodBem=" & id & ""
                    rs = db.Execute(sql)
                    If rs.EOF = False Then

                        base = row.Cells(3).Value
                        depre = row.Cells(4).Value
                        atual = rs.Fields(12).Value
                        depretotal = base * (depre / 100)
                        depretotal = depretotal * diferenca
                        atual = atual - depretotal
                        depretotal = depretotal + rs.Fields(11).Value
                        row.Cells(5).Value = atual
                        row.Cells(6).Value = depretotal
                        row.Cells(1).Value = codigoempresar
                        sql = "update bens set ValorAtual='" & atual & "', ValorDepreciado='" & depretotal & "' where CodBem=" & id & ""
                        rs = db.Execute(sql)
                    End If


                End If
            Next
        End If
    End Sub


    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Me.Hide()
        NovoBen.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Relatorio.Show()
    End Sub

    Private Sub dgv_controle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_controle.CellContentClick

    End Sub
End Class