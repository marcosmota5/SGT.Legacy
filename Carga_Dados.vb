Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class Carga_Dados
    Sub Carrega_Clientes(Caminho_Arquivo As String)

        Dim sqlcmd As MySqlCommand
        Dim fi As New IO.FileInfo(Caminho_Arquivo)
        Dim caminho_completo As String = fi.FullName
        Dim arquivo As String = fi.Name

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRow As Range

        elApp.Visible = False
        elApp.Workbooks.Open(caminho_completo, False, False)
        elWorkbook = elApp.Workbooks(arquivo)
        elWorksheet = elWorkbook.Worksheets(1)
        elRange = elWorksheet.Range("A2:I" & elWorksheet.Range("A1048576").End(XlDirection.xlUp).Row)

        pgb_Carregamento.Value = 0
        pgb_Carregamento.Maximum = elWorksheet.Range("A1048576").End(XlDirection.xlUp).Row + 1
        pgb_Carregamento.Minimum = 2

        Try
            Abrir_Conexao()

            For Each elRng2 As Range In elRange
                If String.IsNullOrEmpty(elRng2.Value) Then
                    elRng2.ClearContents()
                End If
            Next

            For Each elRow In elRange.Rows

                Dim p1 As Boolean
                Dim p2 As Boolean

                If CONVERT_TO_INTEGER(elWorksheet.Range("D" & elRow.Row).Value.ToString) = 1 Then
                    p1 = True
                Else
                    p1 = False
                End If

                If CONVERT_TO_INTEGER(elWorksheet.Range("H" & elRow.Row).Value.ToString) = 1 Then
                    p2 = True
                Else
                    p2 = False
                End If

                sqlcmd = New MySqlCommand("sp_inserir_cliente", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", Trim(elWorksheet.Range("A" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_termo", CONVERT_TO_INTEGER(elWorksheet.Range("B" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_status", CONVERT_TO_INTEGER(elWorksheet.Range("C" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_considerar_percentuais_tabela_kion", p1)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_1", CONVERT_TO_DECIMAL(elWorksheet.Range("E" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_2", CONVERT_TO_DECIMAL(elWorksheet.Range("F" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_3", CONVERT_TO_DECIMAL(elWorksheet.Range("G" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_considerar_acrescimo_especifico", p2)
                sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_especifico", CONVERT_TO_DECIMAL(elWorksheet.Range("I" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O cliente '" & Trim(elWorksheet.Range("A" & elRow.Row).Value.ToString) & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                pgb_Carregamento.Value = pgb_Carregamento.Value + 1
                lbl_Status_Carregamento.Text = "Carregando dados, aguarde... | " & Format(pgb_Carregamento.Value / pgb_Carregamento.Maximum, "0%")

            Next

            MessageBox.Show("Carga realizada com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing
        End Try
    End Sub

    Sub Carrega_Contatos(Caminho_Arquivo As String)

        Dim sqlcmd As MySqlCommand
        Dim fi As New IO.FileInfo(Caminho_Arquivo)
        Dim caminho_completo As String = fi.FullName
        Dim arquivo As String = fi.Name

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRow As Range

        elApp.Visible = False
        elApp.Workbooks.Open(caminho_completo, False, False)
        elWorkbook = elApp.Workbooks(arquivo)
        elWorksheet = elWorkbook.Worksheets(1)
        elRange = elWorksheet.Range("A2:H" & elWorksheet.Range("A1048576").End(XlDirection.xlUp).Row)

        pgb_Carregamento.Value = 0
        pgb_Carregamento.Maximum = elWorksheet.Range("A1048576").End(XlDirection.xlUp).Row + 1
        pgb_Carregamento.Minimum = 2

        Try
            Abrir_Conexao()

            For Each elRng2 As Range In elRange
                If String.IsNullOrEmpty(elRng2.Value) Then
                    elRng2.ClearContents()
                End If
            Next

            For Each elRow In elRange.Rows

                Dim p_telefone As String
                Dim p_email As String

                If elWorksheet.Range("C" & elRow.Row).Value Is Nothing Then
                    p_email = ""
                Else
                    p_email = CONVERT_TO_STRING(elWorksheet.Range("C" & elRow.Row).Value.ToString)
                End If

                If elWorksheet.Range("B" & elRow.Row).Value Is Nothing Then
                    p_telefone = ""
                Else
                    p_telefone = CONVERT_TO_STRING(elWorksheet.Range("B" & elRow.Row).Value.ToString)
                End If

                sqlcmd = New MySqlCommand("sp_inserir_contato", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", elWorksheet.Range("A" & elRow.Row).Value.ToString)
                sqlcmd.Parameters.AddWithValue("p_telefone", p_telefone)
                sqlcmd.Parameters.AddWithValue("p_email", p_email)
                sqlcmd.Parameters.AddWithValue("p_id_pais", CONVERT_TO_INTEGER(elWorksheet.Range("D" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_estado", CONVERT_TO_INTEGER(elWorksheet.Range("E" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_cidade", CONVERT_TO_INTEGER(elWorksheet.Range("F" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_status", CONVERT_TO_INTEGER(elWorksheet.Range("G" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_cliente", CONVERT_TO_INTEGER(elWorksheet.Range("H" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.Parameters.Add("p_id_contato", MySqlDbType.Int32).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim p_id_contato As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_contato").Value)

                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O contato '" & Trim(elWorksheet.Range("A" & elRow.Row).Value.ToString) & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                pgb_Carregamento.Value = pgb_Carregamento.Value + 1
                lbl_Status_Carregamento.Text = "Carregando dados, aguarde... | " & Format(pgb_Carregamento.Value / pgb_Carregamento.Maximum, "0%")

            Next

            MessageBox.Show("Carga realizada com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing
        End Try

    End Sub

    Sub Carrega_Propostas(Caminho_Arquivo As String)

        Dim sqlcmd As MySqlCommand
        Dim fi As New IO.FileInfo(Caminho_Arquivo)
        Dim caminho_completo As String = fi.FullName
        Dim arquivo As String = fi.Name

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRow As Range

        elApp.Visible = False
        elApp.Workbooks.Open(caminho_completo, False, False)
        elWorkbook = elApp.Workbooks(arquivo)
        elWorksheet = elWorkbook.Worksheets(1)
        elRange = elWorksheet.Range("A2:AG" & elWorksheet.Range("B1048576").End(XlDirection.xlUp).Row)

        pgb_Carregamento.Value = 0
        pgb_Carregamento.Maximum = elWorksheet.Range("B1048576").End(XlDirection.xlUp).Row + 1
        pgb_Carregamento.Minimum = 2

        Try
            Abrir_Conexao()

            For Each elRng2 As Range In elRange
                If String.IsNullOrEmpty(elRng2.Value) Then
                    elRng2.ClearContents()
                End If
            Next

            For Each elRow In elRange.Rows

                sqlcmd = New MySqlCommand("sp_inserir_proposta", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure

                If elWorksheet.Range("B" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_solicitacao", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_solicitacao", elWorksheet.Range("B" & elRow.Row).Value)
                End If

                If elWorksheet.Range("C" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_insercao", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_insercao", elWorksheet.Range("C" & elRow.Row).Value)
                End If

                If elWorksheet.Range("D" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_envio_faturamento", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_envio_faturamento", elWorksheet.Range("D" & elRow.Row).Value)
                End If

                If elWorksheet.Range("E" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_faturamento", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_faturamento", elWorksheet.Range("E" & elRow.Row).Value)
                End If

                If elWorksheet.Range("F" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_nota_fiscal", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_nota_fiscal", elWorksheet.Range("F" & elRow.Row).Value)
                End If

                If elWorksheet.Range("G" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_valor_faturamento", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_valor_faturamento", elWorksheet.Range("G" & elRow.Row).Value)
                End If

                sqlcmd.Parameters.AddWithValue("p_id_filial", elWorksheet.Range("H" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_cliente", elWorksheet.Range("I" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_contato", elWorksheet.Range("J" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_codigo_proposta", elWorksheet.Range("K" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_usuario_insercao", elWorksheet.Range("L" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_status", elWorksheet.Range("N" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_prioridade", elWorksheet.Range("O" & elRow.Row).Value)

                If elWorksheet.Range("P" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_fabricante", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_fabricante", elWorksheet.Range("P" & elRow.Row).Value)
                End If

                If elWorksheet.Range("Q" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_tipo_equipamento", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_equipamento", elWorksheet.Range("Q" & elRow.Row).Value)
                End If

                If elWorksheet.Range("R" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_modelo", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_modelo", elWorksheet.Range("R" & elRow.Row).Value)
                End If

                If elWorksheet.Range("S" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_ano", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_ano", elWorksheet.Range("S" & elRow.Row).Value)
                End If

                If elWorksheet.Range("T" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_serie", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_serie", elWorksheet.Range("T" & elRow.Row).Value)
                End If

                If elWorksheet.Range("U" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_horimetro", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_horimetro", elWorksheet.Range("U" & elRow.Row).Value)
                End If

                If elWorksheet.Range("V" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_ordem_servico", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_ordem_servico", elWorksheet.Range("V" & elRow.Row).Value)
                End If

                If elWorksheet.Range("W" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_envio", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_envio", elWorksheet.Range("W" & elRow.Row).Value)
                End If

                If elWorksheet.Range("Y" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_proposta_origem", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_proposta_origem", elWorksheet.Range("Y" & elRow.Row).Value)
                End If

                If elWorksheet.Range("Z" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_ultima_proposta", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_ultima_proposta", elWorksheet.Range("Z" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AA" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_texto_padrao", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_texto_padrao", elWorksheet.Range("AA" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AB" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_observacoes", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_observacoes", elWorksheet.Range("AB" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AC" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_prazo_entrega", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_prazo_entrega", elWorksheet.Range("AC" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AD" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_condicao_pagamento", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_condicao_pagamento", elWorksheet.Range("AD" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AE" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_garantia", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_garantia", elWorksheet.Range("AE" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AF" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_validade", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_validade", elWorksheet.Range("AF" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AG" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_comentarios", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_comentarios", elWorksheet.Range("AG" & elRow.Row).Value)
                End If

                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.Parameters.Add("p_id_proposta", MySqlDbType.Int32).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim p_id_proposta As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_proposta").Value)


                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("A proposta '" & Trim(elWorksheet.Range("K" & elRow.Row).Value.ToString) & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                pgb_Carregamento.Value = pgb_Carregamento.Value + 1
                lbl_Status_Carregamento.Text = "Carregando dados, aguarde... | " & Format(pgb_Carregamento.Value / pgb_Carregamento.Maximum, "0%")

            Next

            MessageBox.Show("Carga realizada com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing
        End Try


    End Sub

    Sub Carrega_Series(Caminho_Arquivo As String)

        Dim sqlcmd As MySqlCommand
        Dim fi As New IO.FileInfo(Caminho_Arquivo)
        Dim caminho_completo As String = fi.FullName
        Dim arquivo As String = fi.Name

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRow As Range

        elApp.Visible = False
        elApp.Workbooks.Open(caminho_completo, False, False)
        elWorkbook = elApp.Workbooks(arquivo)
        elWorksheet = elWorkbook.Worksheets(1)
        elRange = elWorksheet.Range("A2:G" & elWorksheet.Range("A1048576").End(XlDirection.xlUp).Row)

        pgb_Carregamento.Value = 0
        pgb_Carregamento.Maximum = elWorksheet.Range("A1048576").End(XlDirection.xlUp).Row + 1
        pgb_Carregamento.Minimum = 2

        Try
            Abrir_Conexao()

            For Each elRng2 As Range In elRange
                If String.IsNullOrEmpty(elRng2.Value) Then
                    elRng2.ClearContents()
                End If
            Next

            For Each elRow In elRange.Rows

                sqlcmd = New MySqlCommand("sp_inserir_serie", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", elWorksheet.Range("A" & elRow.Row).Value.ToString)
                sqlcmd.Parameters.AddWithValue("p_id_status", CONVERT_TO_INTEGER(elWorksheet.Range("B" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_cliente", CONVERT_TO_INTEGER(elWorksheet.Range("C" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_fabricante", CONVERT_TO_INTEGER(elWorksheet.Range("D" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_tipo_equipamento", CONVERT_TO_INTEGER(elWorksheet.Range("E" & elRow.Row).Value.ToString))
                sqlcmd.Parameters.AddWithValue("p_id_modelo", CONVERT_TO_INTEGER(elWorksheet.Range("F" & elRow.Row).Value.ToString))

                If elWorksheet.Range("G" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_ano", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_ano", CONVERT_TO_INTEGER(elWorksheet.Range("G" & elRow.Row).Value.ToString))
                End If

                sqlcmd.Parameters.Add("p_id_serie", MySqlDbType.Int32).Direction = 2
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim p_id_serie As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_serie").Value)

                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("A série '" & Trim(elWorksheet.Range("A" & elRow.Row).Value.ToString) & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                pgb_Carregamento.Value = pgb_Carregamento.Value + 1
                lbl_Status_Carregamento.Text = "Carregando dados, aguarde... | " & Format(pgb_Carregamento.Value / pgb_Carregamento.Maximum, "0%")

            Next

            MessageBox.Show("Carga realizada com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing
        End Try

    End Sub

    Sub Carrega_Itens_Propostas(Caminho_Arquivo As String)

        Dim sqlcmd As MySqlCommand
        Dim fi As New IO.FileInfo(Caminho_Arquivo)
        Dim caminho_completo As String = fi.FullName
        Dim arquivo As String = fi.Name

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRow As Range

        elApp.Visible = False
        elApp.Workbooks.Open(caminho_completo, False, False)
        elWorkbook = elApp.Workbooks(arquivo)
        elWorksheet = elWorkbook.Worksheets(1)
        elRange = elWorksheet.Range("A2:AZ" & elWorksheet.Range("B1048576").End(XlDirection.xlUp).Row)

        pgb_Carregamento.Value = 0
        pgb_Carregamento.Maximum = elWorksheet.Range("B1048576").End(XlDirection.xlUp).Row + 1
        pgb_Carregamento.Minimum = 2

        Try
            Abrir_Conexao()

            For Each elRng2 As Range In elRange
                If String.IsNullOrEmpty(elRng2.Value) Then
                    elRng2.ClearContents()
                End If
            Next

            For Each elRow In elRange.Rows

                sqlcmd = New MySqlCommand("sp_inserir_item_proposta", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure

                If elWorksheet.Range("B" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_insercao", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_insercao", elWorksheet.Range("B" & elRow.Row).Value)
                End If

                sqlcmd.Parameters.AddWithValue("p_id_usuario", elWorksheet.Range("C" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_status", elWorksheet.Range("D" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_proposta", elWorksheet.Range("E" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_status_aprovacao", elWorksheet.Range("F" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_justificativa_aprovacao", elWorksheet.Range("G" & elRow.Row).Value)
                sqlcmd.Parameters.AddWithValue("p_id_tipo_item", elWorksheet.Range("H" & elRow.Row).Value)

                If elWorksheet.Range("I" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_conjunto", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_conjunto", elWorksheet.Range("I" & elRow.Row).Value)
                End If

                If elWorksheet.Range("J" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_especificacao", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_especificacao", elWorksheet.Range("J" & elRow.Row).Value)
                End If

                If elWorksheet.Range("K" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_fornecedor", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_fornecedor", elWorksheet.Range("K" & elRow.Row).Value)
                End If

                If elWorksheet.Range("L" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_codigo_item", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_codigo_item", elWorksheet.Range("L" & elRow.Row).Value)
                End If

                If elWorksheet.Range("M" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_descricao_item", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_descricao_item", elWorksheet.Range("M" & elRow.Row).Value)
                End If

                If elWorksheet.Range("N" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_quantidade_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_quantidade_item", elWorksheet.Range("N" & elRow.Row).Value)
                End If

                If elWorksheet.Range("O" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_unitario_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_unitario_inicial_item", elWorksheet.Range("O" & elRow.Row).Value)
                End If


                If elWorksheet.Range("P" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_percentual_ipi_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_percentual_ipi_item", elWorksheet.Range("P" & elRow.Row).Value)
                End If

                If elWorksheet.Range("Q" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_percentual_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_percentual_icms_item", elWorksheet.Range("Q" & elRow.Row).Value)
                End If

                If elWorksheet.Range("R" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_ncm_item", MySqlDbType.VarChar).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_ncm_item", elWorksheet.Range("R" & elRow.Row).Value)
                End If

                If elWorksheet.Range("S" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_mva_item", elWorksheet.Range("S" & elRow.Row).Value)
                End If

                If elWorksheet.Range("T" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_valor_st_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_valor_st_item", elWorksheet.Range("T" & elRow.Row).Value)
                End If

                If elWorksheet.Range("U" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_valor_total_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_valor_total_inicial_item", elWorksheet.Range("U" & elRow.Row).Value)
                End If


                If elWorksheet.Range("V" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_prazo_inicial_item", MySqlDbType.VarChar).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_prazo_inicial_item", elWorksheet.Range("V" & elRow.Row).Value)
                End If

                If elWorksheet.Range("W" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_frete_unitario_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_frete_unitario_item", elWorksheet.Range("W" & elRow.Row).Value)
                End If

                If elWorksheet.Range("X" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_desconto_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_desconto_inicial_item", elWorksheet.Range("X" & elRow.Row).Value)
                End If

                If elWorksheet.Range("Y" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_tipo_substituicao_tributaria_item", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_substituicao_tributaria_item", elWorksheet.Range("Y" & elRow.Row).Value)
                End If

                If elWorksheet.Range("Z" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_id_origem_item", MySqlDbType.Int32).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_id_origem_item", elWorksheet.Range("Z" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AA" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_apos_desconto_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_apos_desconto_inicial_item", elWorksheet.Range("AA" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AB" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_com_ipi_e_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_com_ipi_e_icms_item", elWorksheet.Range("AB" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AC" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_percentual_aliquota_externa_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_externa_icms_item", elWorksheet.Range("AC" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AD" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_valor_icms_credito_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_valor_icms_credito_item", elWorksheet.Range("AD" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AE" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_percentual_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_percentual_mva_item", elWorksheet.Range("AE" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AF" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_valor_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_valor_mva_item", elWorksheet.Range("AF" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AG" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_com_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_com_mva_item", elWorksheet.Range("AG" & elRow.Row).Value)
                End If


                If elWorksheet.Range("AH" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_percentual_aliquota_interna_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_interna_icms_item", elWorksheet.Range("AH" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AI" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_valor_icms_debito_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_valor_icms_debito_item", elWorksheet.Range("AI" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AJ" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_saldo_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_saldo_icms_item", elWorksheet.Range("AJ" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AK" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_unitario_para_revendedor_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_unitario_para_revendedor_item", elWorksheet.Range("AK" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AL" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_impostos_federais_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_impostos_federais_item", elWorksheet.Range("AL" & elRow.Row).Value)
                End If


                If elWorksheet.Range("AM" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_rateio_despesa_fixa_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_rateio_despesa_fixa_item", elWorksheet.Range("AM" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AN" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_percentual_lucro_necessario_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item", elWorksheet.Range("AN" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AO" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_lista_venda_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_lista_venda_item", elWorksheet.Range("AO" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AP" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_desconto_final_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_desconto_final_item", elWorksheet.Range("AP" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AQ" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_unitario_final_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_unitario_final_item", elWorksheet.Range("AQ" & elRow.Row).Value)
                End If


                If elWorksheet.Range("AR" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_preco_total_final_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_preco_total_final_item", elWorksheet.Range("AR" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AS" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_quantidade_estoque_codigo_completo_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_quantidade_estoque_codigo_completo_item", elWorksheet.Range("AS" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AT" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_quantidade_estoque_codigo_abreviado_item", MySqlDbType.Decimal).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_quantidade_estoque_codigo_abreviado_item", elWorksheet.Range("AT" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AU" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_informacao_estoque_codigo_completo_item", MySqlDbType.VarChar).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_informacao_estoque_codigo_completo_item", elWorksheet.Range("AU" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AV" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_informacao_estoque_codigo_abreviado_item", MySqlDbType.VarChar).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_informacao_estoque_codigo_abreviado_item", elWorksheet.Range("AV" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AW" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_prazo_final_item", MySqlDbType.VarChar).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_prazo_final_item", elWorksheet.Range("AW" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AX" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_comentarios_item", MySqlDbType.Text).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_comentarios_item", elWorksheet.Range("AX" & elRow.Row).Value)
                End If

                If elWorksheet.Range("AY" & elRow.Row).Value Is Nothing Then
                    sqlcmd.Parameters.Add("p_data_aprovacao_item", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_aprovacao_item", elWorksheet.Range("AY" & elRow.Row).Value)
                End If

                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim Mensagem_Conclusao2 As String = sqlcmd.Parameters("p_mensagem").Value.ToString

                pgb_Carregamento.Value = pgb_Carregamento.Value + 1
                lbl_Status_Carregamento.Text = "Carregando dados, aguarde... | " & Format(pgb_Carregamento.Value / pgb_Carregamento.Maximum, "0%")

            Next

            MessageBox.Show("Carga realizada com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing
        End Try

    End Sub

    Private Sub btn_Selecionar_Arquivo_Click(sender As Object, e As EventArgs) Handles btn_Selecionar_Arquivo.Click

        Using OFD As New OpenFileDialog With {.Filter = "Arquivos do Excel (*.xlsx;*.xlsm;*.xlsb)|*.xlsx;*.xlsm;*.xlsb"}
            If OFD.ShowDialog = DialogResult.OK Then
                txt_Arquivo.Text = OFD.FileName
            End If
        End Using

    End Sub

    Private Sub btn_Carregar_Click(sender As Object, e As EventArgs) Handles btn_Carregar.Click

        If String.IsNullOrEmpty(txt_Arquivo.Text) Then
            MessageBox.Show("Selecione uma base para executar a carga de dados", "Nenhuma base selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Select Case cbo_Tipo_Carga.Text
            Case "Clientes"
                Carrega_Clientes(txt_Arquivo.Text)
            Case "Contatos"
                Carrega_Contatos(txt_Arquivo.Text)
            Case "Séries"
                Carrega_Series(txt_Arquivo.Text)
            Case "Propostas"
                Carrega_Propostas(txt_Arquivo.Text)
            Case "Itens da proposta"
                Carrega_Itens_Propostas(txt_Arquivo.Text)
        End Select

    End Sub
End Class