Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp, user, planocodigo, nomeplano, origem, plano, nomeempresa, descconta, depreciacao, tempo, bemsofre, usobem, aux3 As String
    Public cad, cont, aux, codigo, cont2, planocodigoaux, CodigoEmpresa, codigoplano, chamada, diferenca, Chamada1, gatilho, codigoempresar As Integer
    Public hoje As Date
    Public depre, atual, depretotal, base, id, porc As Double

    Public conexao = Application.StartupPath & "\bancodados\banco.mdb"


    Sub conexao_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data source=" & conexao)
        Catch ex As Exception
            MessageBox.Show(ex, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Sub gridEmpresas()
        sql = "select * from Empresas where usuario='" & user & "' order by Cadastro asc"
        rs = db.Execute(sql)
        cont = 1
        CadastroEmpresas.dgv_empresas.Rows.Clear()
        Do While rs.EOF = False
            With CadastroEmpresas.dgv_empresas
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub gridcontascriadas()
        sql = "select * from Planodecontas order by Codigo asc"
        rs = db.Execute(sql)
        cont = 1
        PlanodeContas.dgv_planocontas.Rows.Clear()
        Do While rs.EOF = False
            With PlanodeContas.dgv_planocontas
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub gridcontas()

        sql = "select * from Contas where Codigo like '" & planocodigo & "'order by Codigo asc"
        rs = db.Execute(sql)
        cont = 1
        CadastrodePlanodeContas.dgv_contas.Rows.Clear()
        Do While rs.EOF = False
            With CadastrodePlanodeContas.dgv_contas
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub


    Sub gridbens()

        sql = "select * from Bens where Codigo like '" & CodigoEmpresa & "'order by CodBem asc"
        rs = db.Execute(sql)
        cont = 1
        Cadastrodebens.dgv_controle.Rows.Clear()
        Do While rs.EOF = False
            With Cadastrodebens.dgv_controle
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, FormatCurrency(rs.Fields(6).Value), rs.Fields(7).Value, rs.Fields(13).Value, rs.Fields(14).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub gridcontascriadasvinculos()
        sql = "select * from Planodecontas order by Codigo asc"
        rs = db.Execute(sql)
        cont = 1
        VincularEmpresa.dgv_planos.Rows.Clear()
        Do While rs.EOF = False
            With VincularEmpresa.dgv_planos
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                cont += 1
                rs.MoveNext()
            End With
        Loop
    End Sub

End Module

