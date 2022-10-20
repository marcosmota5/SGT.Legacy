Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class Importar_Pecas

    Private pEmailName As String = ""
    Private ndSelected As String = ""

    Private Sub Importar_Pecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Preenche_Pastas_Email()

        Dim nDate As Date = Now

        dtp_De.Value = DateAdd(DateInterval.Day, -7, nDate)
        dtp_Ate.Value = nDate
        dtp_De.MaxDate = nDate
        dtp_Ate.MaxDate = nDate

        Select Case get_id_fornecedor
            Case 1
                pEmailName = CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.SelectedQuotationsFolderSupplier1))
            Case 2
                pEmailName = CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.SelectedQuotationsFolderSupplier2))
        End Select

        ndSelected = ""
        RecurseNodes(trv_Pasta_Email.Nodes)

        Me.Height = 487
        pgb_Importacao_Pecas.Visible = False
        lbl_Importacao_Pecas.Visible = False
        Me.Text = "Importar peças - " & GET_DATA_MYSQL("tb_fornecedores", "nome", "id_fornecedor = " & get_id_fornecedor)

    End Sub

    Private Sub RecurseNodes(ByVal col As TreeNodeCollection)
        If Not String.IsNullOrEmpty(pEmailName) Then
            If String.IsNullOrEmpty(ndSelected) Then
                For Each tn As TreeNode In col
                    If CONVERT_TO_STRING(tn.Name) = pEmailName Then
                        trv_Pasta_Email.SelectedNode = tn
                        ndSelected = tn.Name
                        Exit For
                    End If
                    If tn.Nodes.Count > 0 Then
                        RecurseNodes(tn.Nodes)
                    End If
                Next tn
            End If
        End If
    End Sub

    Sub Preenche_Pastas_Email()

        Dim olApp As New Outlook.Application
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")

        Dim olSubFolder_n1 As MAPIFolder
        Dim olSubFolder_n2 As MAPIFolder
        Dim olSubFolder_n3 As MAPIFolder
        Dim olSubFolder_n4 As MAPIFolder
        Dim olSubFolder_n5 As MAPIFolder

        Dim ndFolder As TreeNode
        Dim ndSubFolder_n1 As TreeNode
        Dim ndSubFolder_n2 As TreeNode
        Dim ndSubFolder_n3 As TreeNode
        Dim ndSubFolder_n4 As TreeNode
        Dim ndSubFolder_n5 As TreeNode

        For Each olFolder As MAPIFolder In olNameSpace.Folders
            ndFolder = trv_Pasta_Email.Nodes.Add(olFolder.EntryID, olFolder.Name)
            For Each olSubFolder_n1 In olFolder.Folders
                ndSubFolder_n1 = ndFolder.Nodes.Add(olSubFolder_n1.EntryID, olSubFolder_n1.Name)
                For Each olSubFolder_n2 In olSubFolder_n1.Folders
                    ndSubFolder_n2 = ndSubFolder_n1.Nodes.Add(olSubFolder_n2.EntryID, olSubFolder_n2.Name)
                    For Each olSubFolder_n3 In olSubFolder_n2.Folders
                        ndSubFolder_n3 = ndSubFolder_n2.Nodes.Add(olSubFolder_n3.EntryID, olSubFolder_n3.Name)
                        For Each olSubFolder_n4 In olSubFolder_n3.Folders
                            ndSubFolder_n4 = ndSubFolder_n3.Nodes.Add(olSubFolder_n4.EntryID, olSubFolder_n4.Name)
                            For Each olSubFolder_n5 In olSubFolder_n4.Folders
                                ndSubFolder_n5 = ndSubFolder_n4.Nodes.Add(olSubFolder_n5.EntryID, olSubFolder_n5.Name)
                            Next
                        Next
                    Next
                Next
            Next
        Next

    End Sub


    Sub Retorna_Emails()

        If trv_Pasta_Email.SelectedNode Is Nothing Then
            Exit Sub
        End If

        Dim EntryID As String = trv_Pasta_Email.SelectedNode.Name
        Dim Texto_Fornecedor As String = ""
        Dim olApp As New Outlook.Application()
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")
        Dim olFolder As MAPIFolder = olNameSpace.GetFolderFromID(EntryID)
        Dim olMail As MailItem
        Dim olItems As Items
        Dim olItemsRestrict As Items
        Dim olItem As Object


        Select Case get_id_fornecedor
            Case 1
                Texto_Fornecedor = "COTACAO-"
            Case 2
                Texto_Fornecedor = "TVH - Orçamento"
        End Select

        Try

            dtg_Emails.Columns.Clear()
            dtg_Emails.Rows.Clear()

            dtg_Emails.Columns.Add("id", "ID")
            dtg_Emails.Columns.Add("data_recebimento", "Data/hora")
            dtg_Emails.Columns.Add("remetente", "Remetente")
            dtg_Emails.Columns.Add("assunto", "Assunto")

            dtg_Emails.Columns("id").Visible = False

            Dim dtDe As Date = Date.Parse(dtp_De.Value.ToShortDateString)
            Dim dtAte As Date = Date.Parse(dtp_Ate.Value.ToShortDateString)
            Dim dtRev As Date

            olItems = olFolder.Items

            olItemsRestrict = olItems.Restrict("[ReceivedTime] >= '" & FormatDateTime(dtDe, DateFormat.ShortDate) & "' And [ReceivedTime] < '" & FormatDateTime(DateAdd(DateInterval.Day, 1, dtAte), DateFormat.ShortDate) & "'")

            For Each olItem In olItemsRestrict

                If (TypeOf olItem Is MailItem) Then
                    olMail = olItem
                    If Strings.InStr(olMail.Subject, Texto_Fornecedor) > 0 Then
                        If get_id_fornecedor = 1 Then

                            Dim contem_proposta As Boolean = False
                            For Each elAtt As Attachment In olMail.Attachments
                                If Strings.Right(elAtt.FileName, 3) = "xls" Then
                                    contem_proposta = True
                                    Exit For
                                End If
                            Next

                            If contem_proposta = True Then
                                dtg_Emails.Rows.Add(olMail.EntryID, olMail.ReceivedTime, olMail.SenderEmailAddress, olMail.Subject)
                            End If

                        Else

                            dtg_Emails.Rows.Add(olMail.EntryID, olMail.ReceivedTime, olMail.SenderEmailAddress, olMail.Subject)

                        End If

                    End If
                End If

            Next

        Catch ex As System.Exception
            MessageBox.Show("Erro ao carregar e-mails. Caso o problema persista, contate o administrador. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Salva_Proposta(EntryID As String)

        Dim Texto_Fornecedor As String = ""
        Dim olApp As New Outlook.Application()
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")
        Dim olItem As Object = olNameSpace.GetItemFromID(EntryID)
        Dim olMail As MailItem
        Dim olAttachment As Attachment
        Dim Pasta_Cotacao As String = ""
        'Dim olFolder As MAPIFolder = olNameSpace.GetFolderFromID(EntryID)
        'Dim olItems As Items
        'Dim olItem As Object

        Select Case get_id_fornecedor
            Case 1
                Pasta_Cotacao = Environ("TEMP") & "\SGT\Cotacoes_Kion"
            Case 2
                Pasta_Cotacao = Environ("TEMP") & "\SGT\Cotacoes_TVH"
        End Select

        If (TypeOf olItem Is MailItem) Then

            If CREATE_FOLDER(Pasta_Cotacao) = False Then
                MessageBox.Show("Não foi possível criar a pasta para salvar a cotação. Por favor, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            olMail = olItem

            Select Case get_id_fornecedor
                Case 1
                    For Each olAttachment In olMail.Attachments
                        olAttachment.SaveAsFile(Pasta_Cotacao & "\Cotacao_Kion" & System.IO.Path.GetExtension(olAttachment.FileName.ToString))
                        Importar_Cotacao_Kion(Pasta_Cotacao & "\Cotacao_Kion" & System.IO.Path.GetExtension(olAttachment.FileName.ToString))
                    Next
                Case 2
                    olMail.SaveAs(Pasta_Cotacao & "\Cotacao_TVH.html", OlSaveAsType.olHTML)
                    Importar_Cotacao_TVH(Pasta_Cotacao & "\Cotacao_TVH.html")
            End Select

            GC.Collect()
            GC.WaitForPendingFinalizers()
            Me.Close()

        End If
    End Sub

    Function GET_COLUMN(Target_Range As Range, Search_Value As String) As Long

        Try
            Return CONVERT_TO_LONG(CONVERT_TO_STRING(Target_Range.Application.WorksheetFunction.Match(Search_Value, Target_Range, 0)))
        Catch ex As System.Exception
            Return 0
        End Try

    End Function

    Sub Importar_Cotacao_TVH(ByVal FilePath As String)

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRangeHeaders As Range
        Dim elRow As Range
        Dim dtbRow As System.Data.DataRow
        Dim sqlcmd As MySqlCommand
        'Dim conta_linhas As Integer = 1

        elApp.Visible = False
        'elApp.Workbooks.Open(WorkbookPath, False, False)
        elWorkbook = elApp.Workbooks.Add()
        'elWorkbook = elApp.Workbooks(System.IO.Path.GetFileName(WorkbookPath))
        elWorksheet = elWorkbook.Worksheets(1)

        With elWorksheet.QueryTables.Add("URL;" & FilePath, elWorksheet.Range("A1"))
            .Name = "PedidoPeca"
            .FieldNames = True
            .RowNumbers = False
            .EnableEditing = True
            .FillAdjacentFormulas = True
            .PreserveFormatting = True
            .RefreshOnFileOpen = False
            .BackgroundQuery = True
            .RefreshStyle = XlCellInsertionMode.xlInsertDeleteCells
            .SavePassword = False
            .SaveData = True
            .AdjustColumnWidth = True
            .RefreshPeriod = 0
            .WebSelectionType = XlWebSelectionType.xlAllTables
            .WebFormatting = XlWebFormatting.xlWebFormattingAll
            .WebPreFormattedTextToColumns = True
            .WebConsecutiveDelimitersAsOne = True
            .WebSingleBlockTextImport = False
            .WebDisableDateRecognition = False
            .WebDisableRedirections = False
            .Refresh(False)
        End With

        elRange = elWorksheet.Range("A22:AC65536")
        elRangeHeaders = elWorksheet.Range("A17:IV17")

        For Each elColHeader As Range In elRangeHeaders
            elColHeader.Formula = "=TRIM(TRIM(" & CONVERT_TO_LETTER(CONVERT_TO_LONG(CONVERT_TO_STRING(elColHeader.Column))) & "19)&"" ""&TRIM(" & CONVERT_TO_LETTER(CONVERT_TO_LONG(CONVERT_TO_STRING(elColHeader.Column))) & "20)&"" ""&TRIM(" & CONVERT_TO_LETTER(CONVERT_TO_LONG(CONVERT_TO_STRING(elColHeader.Column))) & "21))"
        Next

        elWorksheet.Calculate()
        elRangeHeaders.Copy()
        elRangeHeaders.PasteSpecial(XlPasteType.xlPasteValues)
        elWorksheet.Application.CutCopyMode = False

        Try

            Me.Height = 511
            pgb_Importacao_Pecas.Visible = True
            lbl_Importacao_Pecas.Visible = True

            pgb_Importacao_Pecas.Minimum = 0
            pgb_Importacao_Pecas.Maximum = elWorksheet.Range("P65536").End(XlDirection.xlUp).Row - 21
            pgb_Importacao_Pecas.Value = 0

            Dim dtb_colunas As New System.Data.DataTable
            Dim adapter As MySqlDataAdapter

            Try
                Abrir_Conexao()

                adapter = New MySqlDataAdapter("Select nome_coluna_sistema, nome_coluna_cotacao, coluna_existe FROM tb_colunas_importacao_cotacoes WHERE id_fornecedor = 2", strConexao)

                adapter.Fill(dtb_colunas)

            Catch ex As System.Exception
                MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
                Exit Sub
            Finally
                Fechar_Conexao()
            End Try

            Dim rows() As DataRow
            Dim coluna_item As String = ""
            Dim coluna_existe As Boolean = False

            For Each elRow In elRange.Rows

                If String.IsNullOrEmpty(elWorksheet.Range("A" & elRow.Row).Value) Or Trim(elWorksheet.Range("A" & elRow.Row).Value.ToString) = "Totais:" Then
                    Exit For
                End If

                dtbRow = dtbItens.NewRow

                dtbRow("id_item_proposta") = 0
                dtbRow("data_insercao") = Now
                dtbRow("id_usuario") = get_id_usuario
                dtbRow("id_status") = 1
                dtbRow("id_proposta") = get_id_proposta
                dtbRow("id_status_aprovacao") = 3
                dtbRow("id_tipo_item") = 1
                dtbRow("id_fornecedor") = 2
                dtbRow("id_tipo_substituicao_tributaria_item") = 1

                rows = dtb_colunas.Select("nome_coluna_sistema = 'codigo_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("codigo_item") = Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)
                Else
                    dtbRow("codigo_item") = ""
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'descricao_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("descricao_item") = FORMATA_TEXTO_TVH(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("descricao_item") = ""
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'quantidade_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("quantidade_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("quantidade_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'preco_unitario_inicial_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("preco_unitario_inicial_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("preco_unitario_inicial_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'percentual_ipi_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("percentual_ipi_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("percentual_ipi_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'percentual_icms_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("percentual_icms_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("percentual_icms_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'ncm_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("ncm_item") = Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)
                Else
                    dtbRow("ncm_item") = ""
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'mva_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("mva_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("mva_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'valor_st_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("valor_st_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("valor_st_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'valor_total_inicial_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("valor_total_inicial_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("valor_total_inicial_item") = 0.00
                End If

                dtbRow("nome4") = GET_DATA_MYSQL("tb_status", "nome", "id_status = 1")
                dtbRow("nome5") = GET_DATA_MYSQL("tb_status_aprovacao", "nome", "id_status_aprovacao = 3")
                dtbRow("nome6") = GET_DATA_MYSQL("tb_justificativas_aprovacao", "nome", "id_justificativa_aprovacao = 1")

                rows = dtb_colunas.Select("nome_coluna_sistema = 'prazo_inicial_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    If Date.Parse(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)) = Date.Parse(Trim(elWorksheet.Range("G18").Value.ToString)) Then
                        dtbRow("prazo_inicial_item") = "Imediato"
                    Else
                        dtbRow("prazo_inicial_item") = "Qtd: " & dtbRow("quantidade_item").ToString & " - " & Format(Date.Parse(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)), "dd/MM/yyyy")
                    End If
                Else
                    dtbRow("prazo_inicial_item") = ""
                End If

                dtbRow("frete_unitario_item") = 0.00
                dtbRow("id_justificativa_aprovacao") = 1

                If dtbRow("percentual_icms_item") = 0.04 Then
                    dtbRow("id_origem_item") = 2
                Else
                    dtbRow("id_origem_item") = 1
                End If

                dtbRow("login") = get_login_usuario

                Try
                    Abrir_Conexao()

                    sqlcmd = New MySqlCommand("sp_retorna_tipo_item", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_item", dtbRow("id_tipo_item"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome") = sqlcmd.Parameters("p_nome").Value.ToString


                    sqlcmd = New MySqlCommand("sp_retorna_fornecedor", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_fornecedor", dtbRow("id_fornecedor"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome1") = sqlcmd.Parameters("p_nome").Value.ToString


                    sqlcmd = New MySqlCommand("sp_retorna_tipo_substituicao_tributaria", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_substituicao_tributaria", dtbRow("id_tipo_substituicao_tributaria_item"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome2") = sqlcmd.Parameters("p_nome").Value.ToString


                    sqlcmd = New MySqlCommand("sp_retorna_origem", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_origem", dtbRow("id_origem_item"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome3") = sqlcmd.Parameters("p_nome").Value.ToString

                    Fechar_Conexao()
                Catch ex As System.Exception
                    MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Fechar_Conexao()
                End Try

                dtbItens.Rows.Add(dtbRow)

                'conta_linhas = conta_linhas + 1
                pgb_Importacao_Pecas.Value = pgb_Importacao_Pecas.Value + 1
                lbl_Importacao_Pecas.Text = "Importando peças, aguarde... | " & Format(DIVIDE(pgb_Importacao_Pecas.Value, pgb_Importacao_Pecas.Maximum), "0%")
            Next

            Set_Registry_Value(Registry_Values.SelectedQuotationsFolderSupplier2, trv_Pasta_Email.SelectedNode.Name)

        Catch ex As System.Exception

            MessageBox.Show("Erro ao importar a cotação. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            Me.Height = 487
            pgb_Importacao_Pecas.Visible = False
            lbl_Importacao_Pecas.Visible = False

            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing

        End Try

    End Sub

    Private Function FORMATA_TEXTO_TVH(ByVal Texto As String) As String

        Dim TextosRemover As String = "PARA EMPILHADEIRAS,PARA EMPILHADEIRA,P/ EMPILHADEIRAS,P/ EMPILHADEIRA,P EMPILHADEIRAS,P EMPILHADEIRA,P/EMPILHADEIRAS,P/EMPILHADEIRA,DA EMPILHADEIRAS,DA EMPILHADEIRA"
        Dim arrTxt() = Split(TextosRemover, ",")
        Dim TextoFormatado As String = Texto

        For x As Integer = LBound(arrTxt) To UBound(arrTxt)
            TextoFormatado = Trim(Replace(TextoFormatado, arrTxt(x), ""))
        Next

        Return TextoFormatado

    End Function

    Sub Importar_Cotacao_Kion(ByVal WorkbookPath As String)

        Dim elApp As New Excel.Application()
        Dim elWorkbook As Workbook
        Dim elWorksheet As Worksheet
        Dim elRange As Range
        Dim elRangeHeaders As Range
        Dim elRow As Range
        Dim dtbRow As System.Data.DataRow
        Dim sqlcmd As MySqlCommand
        'Dim conta_linhas As Integer = 1

        elApp.Visible = False
        elApp.Workbooks.Open(WorkbookPath, False, False)
        elWorkbook = elApp.Workbooks(System.IO.Path.GetFileName(WorkbookPath))
        elWorksheet = elWorkbook.Worksheets(1)

        elRange = elWorksheet.Range("A23:BC65536")
        elRangeHeaders = elWorksheet.Range("A22:IV22")

        Try
            Me.Height = 511
            pgb_Importacao_Pecas.Visible = True
            lbl_Importacao_Pecas.Visible = True

            pgb_Importacao_Pecas.Minimum = 0
            pgb_Importacao_Pecas.Maximum = elWorksheet.Range("C65536").End(XlDirection.xlUp).Row - 22
            pgb_Importacao_Pecas.Value = 0

            Dim dtb_colunas As New System.Data.DataTable
            Dim adapter As MySqlDataAdapter

            Try
                Abrir_Conexao()

                adapter = New MySqlDataAdapter("Select nome_coluna_sistema, nome_coluna_cotacao, coluna_existe FROM tb_colunas_importacao_cotacoes WHERE id_fornecedor = 1", strConexao)

                adapter.Fill(dtb_colunas)

            Catch ex As System.Exception
                MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
                Exit Sub
            Finally
                Fechar_Conexao()
            End Try

            Dim rows() As DataRow
            Dim coluna_item As String = ""
            Dim coluna_existe As Boolean = False

            For Each elRow In elRange.Rows

                If String.IsNullOrEmpty(elWorksheet.Range("C" & elRow.Row).Value) Then
                    Exit For
                End If

                dtbRow = dtbItens.NewRow

                dtbRow("id_item_proposta") = 0
                dtbRow("data_insercao") = Now
                dtbRow("id_usuario") = get_id_usuario
                dtbRow("id_status") = 1
                dtbRow("id_proposta") = get_id_proposta
                dtbRow("id_status_aprovacao") = 3
                dtbRow("id_tipo_item") = 1
                dtbRow("id_fornecedor") = 1
                dtbRow("id_tipo_substituicao_tributaria_item") = 1

                rows = dtb_colunas.Select("nome_coluna_sistema = 'codigo_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("codigo_item") = Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)
                Else
                    dtbRow("codigo_item") = ""
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'descricao_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("descricao_item") = Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)
                Else
                    dtbRow("descricao_item") = ""
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'quantidade_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("quantidade_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("quantidade_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'preco_unitario_inicial_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("preco_unitario_inicial_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("preco_unitario_inicial_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'percentual_ipi_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("percentual_ipi_item") = DIVIDE(CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)), 100)
                Else
                    dtbRow("percentual_ipi_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'percentual_icms_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("percentual_icms_item") = DIVIDE(CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)), 100)
                Else
                    dtbRow("percentual_icms_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'ncm_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("ncm_item") = Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)
                Else
                    dtbRow("ncm_item") = ""
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'mva_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("mva_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("mva_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'valor_st_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("valor_st_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("valor_st_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'valor_total_inicial_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("valor_total_inicial_item") = CONVERT_TO_DECIMAL(Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString))
                Else
                    dtbRow("valor_total_inicial_item") = 0.00
                End If

                rows = dtb_colunas.Select("nome_coluna_sistema = 'prazo_inicial_item'")
                coluna_item = CONVERT_TO_LETTER(GET_COLUMN(elRangeHeaders, CONVERT_TO_STRING(rows(0).Item("nome_coluna_cotacao").ToString)))
                coluna_existe = rows(0).Item("coluna_existe")

                If coluna_existe = True Then
                    dtbRow("prazo_inicial_item") = Trim(elWorksheet.Range(coluna_item & elRow.Row).Value.ToString)
                Else
                    dtbRow("prazo_inicial_item") = ""
                End If

                dtbRow("frete_unitario_item") = 0.00
                dtbRow("id_justificativa_aprovacao") = 1

                dtbRow("nome4") = GET_DATA_MYSQL("tb_status", "nome", "id_status = 1")
                dtbRow("nome5") = GET_DATA_MYSQL("tb_status_aprovacao", "nome", "id_status_aprovacao = 3")
                dtbRow("nome6") = GET_DATA_MYSQL("tb_justificativas_aprovacao", "nome", "id_justificativa_aprovacao = 1")

                If Strings.Left(dtbRow("codigo_item").ToString, 1) = "I" Then
                    dtbRow("id_origem_item") = 2
                Else
                    dtbRow("id_origem_item") = 1
                End If

                dtbRow("login") = get_login_usuario

                Try
                    Abrir_Conexao()

                    sqlcmd = New MySqlCommand("sp_retorna_tipo_item", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_item", dtbRow("id_tipo_item"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome") = sqlcmd.Parameters("p_nome").Value.ToString


                    sqlcmd = New MySqlCommand("sp_retorna_fornecedor", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_fornecedor", dtbRow("id_fornecedor"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome1") = sqlcmd.Parameters("p_nome").Value.ToString


                    sqlcmd = New MySqlCommand("sp_retorna_tipo_substituicao_tributaria", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_substituicao_tributaria", dtbRow("id_tipo_substituicao_tributaria_item"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome2") = sqlcmd.Parameters("p_nome").Value.ToString


                    sqlcmd = New MySqlCommand("sp_retorna_origem", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_origem", dtbRow("id_origem_item"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()

                    dtbRow("nome3") = sqlcmd.Parameters("p_nome").Value.ToString

                    Fechar_Conexao()
                Catch ex As System.Exception
                    MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Fechar_Conexao()
                End Try

                dtbItens.Rows.Add(dtbRow)

                'conta_linhas = conta_linhas + 1

                pgb_Importacao_Pecas.Value = pgb_Importacao_Pecas.Value + 1
                lbl_Importacao_Pecas.Text = "Importando peças, aguarde... | " & Format(DIVIDE(pgb_Importacao_Pecas.Value, pgb_Importacao_Pecas.Maximum), "0%")
            Next

            Set_Registry_Value(Registry_Values.SelectedQuotationsFolderSupplier1, trv_Pasta_Email.SelectedNode.Name)

        Catch ex As System.Exception

            MessageBox.Show("Erro ao importar a cotação. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            Me.Height = 487
            pgb_Importacao_Pecas.Visible = False
            lbl_Importacao_Pecas.Visible = False

            elWorkbook.Close(False)

            elApp.Quit()

            elWorksheet = Nothing
            elWorkbook = Nothing
            elApp = Nothing

        End Try

    End Sub
    Private Sub trv_Pasta_Email_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trv_Pasta_Email.AfterSelect
        Retorna_Emails()

    End Sub

    Private Sub dtp_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_De.ValueChanged
        Retorna_Emails()
    End Sub

    Private Sub dtp_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Ate.ValueChanged
        Retorna_Emails()
    End Sub

    Private Sub tsmi_Substituir_Click(sender As Object, e As EventArgs) Handles tsmi_Substituir.Click

        If dtg_Emails.CurrentRow IsNot Nothing Then
            dtbItens.Rows.Clear()
            Salva_Proposta(dtg_Emails.CurrentRow.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub tsmi_Adicionar_Click(sender As Object, e As EventArgs) Handles tsmi_Adicionar.Click

        If dtg_Emails.CurrentRow IsNot Nothing Then
            Salva_Proposta(dtg_Emails.CurrentRow.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub dtg_Emails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtg_Emails.CellMouseDown
        dtg_Emails.ContextMenuStrip = Nothing
        If e.Button = MouseButtons.Right And e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            dtg_Emails.CurrentCell = dtg_Emails(e.ColumnIndex, e.RowIndex)
            dtg_Emails.ContextMenuStrip = cms_Importar
        End If
    End Sub

End Class

