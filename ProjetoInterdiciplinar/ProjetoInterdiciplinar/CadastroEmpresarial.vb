Public Class CadastroEmpresarial
    Private Sub CadastroEmpresarial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        With cmb_uf
            .Items.Add("AC")
            .Items.Add("AL")
            .Items.Add("AM")
            .Items.Add("AP")
            .Items.Add("BA")
            .Items.Add("CE")
            .Items.Add("DF")
            .Items.Add("ES")
            .Items.Add("GO")
            .Items.Add("MA")
            .Items.Add("MG")
            .Items.Add("MS")
            .Items.Add("MT")
            .Items.Add("PA")
            .Items.Add("PB")
            .Items.Add("PE")
            .Items.Add("PI")
            .Items.Add("PR")
            .Items.Add("RJ")
            .Items.Add("RN")
            .Items.Add("RO")
            .Items.Add("RR")
            .Items.Add("RS")
            .Items.Add("SC")
            .Items.Add("SE")
            .Items.Add("SP")
            .Items.Add("TO")
        End With
        If gatilho = 1 Then
            sql = "select * from Empresas where Cadastro like '" & aux & "' "
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_cad.Text = rs.Fields(0).Value
                txt_nome.Text = rs.Fields(1).Value
                txt_resp.Text = rs.Fields(2).Value
                txt_cnpj.Text = rs.Fields(3).Value
                txt_crc.Text = rs.Fields(4).Value
                txt_cpf.Text = rs.Fields(5).Value
                txt_endereco.Text = rs.Fields(6).Value
                cmb_uf.Text = rs.Fields(7).Value
                txt_municipio.Text = rs.Fields(8).Value
                txt_bairro.Text = rs.Fields(9).Value
                txt_cidade.Text = rs.Fields(10).Value
                txt_cep.Text = rs.Fields(11).Value
                txt_cel.Text = rs.Fields(12).Value
                txt_tel.Text = rs.Fields(13).Value
                txt_email.Text = rs.Fields(14).Value
            Else

            End If
        Else
            sql = "select MAX(Cadastro) From Empresas"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                cad = rs.Fields(0).Value + 1
                txt_cad.Text = cad

            End If
        End If


    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        With CadastroEmpresa
            gridEmpresas()

        End With
        Close()
        CadastroEmpresas.Show()
        gatilho = 0
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If gatilho = 1 Then

            If txt_nome.Text = "" Or txt_resp.Text = "" Or txt_cnpj.Text = "" Or txt_crc.Text = "" Or txt_cpf.Text = "" Or txt_endereco.Text = "" Or cmb_uf.Text = "" Or txt_municipio.Text = "" Or txt_bairro.Text = "" Or txt_cidade.Text = "" Or txt_cep.Text = "" Or txt_cel.Text = "" Or txt_tel.Text = "" Or txt_email.Text = "" Then
                MsgBox("Preencha Todos os Campos Corretamente!")
                Exit Sub
            Else
                sql = "update Empresas set Nome='" & txt_nome.Text & "', Responsavel='" & txt_resp.Text & "', cnpj='" & txt_cnpj.Text & "', creci='" & txt_crc.Text & "', cpf='" & txt_cpf.Text & "', endereco='" & txt_endereco.Text & "', uf='" & cmb_uf.Text & "', codmuni='" & txt_municipio.Text & "', bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text & "', cep='" & txt_cep.Text & "', celular='" & txt_cel.Text & "', telefone='" & txt_tel.Text & "', email='" & txt_email.Text & "' where Cadastro=" & txt_cad.Text & ""
                rs = db.Execute(sql)
                gatilho = 0
                MsgBox("Empresa alterada com sucesso")
                Close()
                CadastroEmpresas.Show()
            End If
        Else

            If txt_nome.Text = "" Or txt_resp.Text = "" Or txt_cnpj.Text = "" Or txt_crc.Text = "" Or txt_cpf.Text = "" Or txt_endereco.Text = "" Or cmb_uf.Text = "" Or txt_municipio.Text = "" Or txt_bairro.Text = "" Or txt_cidade.Text = "" Or txt_cep.Text = "" Or txt_cel.Text = "" Or txt_tel.Text = "" Or txt_email.Text = "" Then
                MsgBox("Preencha Todos os Campos Corretamente!")
                Exit Sub
            Else
                Try
                    sql = "Select * from Empresas where cnpj= '" & txt_cnpj.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        MsgBox("Cnpj Ja cadastrado !!")
                        Exit Sub
                    Else
                        sql = "insert into Empresas (Nome, Responsavel, cnpj, creci, cpf, endereco, uf, codmuni, bairro, cidade, cep, celular, telefone, email, usuario) values ('" & txt_nome.Text & "','" & txt_resp.Text & "','" & txt_cnpj.Text & "','" & txt_crc.Text & "','" & txt_cpf.Text & "','" & txt_endereco.Text & "','" & cmb_uf.Text & "'," & txt_municipio.Text & ",'" & txt_bairro.Text & "','" & txt_cidade.Text & "','" & txt_cep.Text & "','" & txt_cel.Text & "','" & txt_tel.Text & "','" & txt_email.Text & "','" & user & "')"
                        rs = db.Execute(sql)
                        MsgBox("Cadastrado Com Sucesso!!")
                        txt_nome.Clear()
                        txt_resp.Clear()
                        txt_cnpj.Clear()
                        txt_crc.Clear()
                        txt_cpf.Clear()
                        txt_endereco.Clear()
                        txt_municipio.Clear()
                        cmb_uf.ResetText()
                        txt_bairro.Clear()
                        txt_cidade.Clear()
                        txt_cep.Clear()
                        txt_cel.Clear()
                        txt_tel.Clear()
                        txt_email.Clear()
                        With CadastroEmpresa
                            gridEmpresas()

                        End With

                        sql = "select MAX(Cadastro) From Empresas"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            cad = rs.Fields(0).Value + 1
                            txt_cad.Text = cad

                        End If


                    End If
                Catch ex As Exception
                    MsgBox("Erro ao Gravar")
                End Try
            End If
        End If
    End Sub

End Class