Imports MySql.Data.MySqlClient
Public Class Pesquisa_Proposta_Padrao
    Private Sub Pesquisar_Proposta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Limite_Resultados.Text = "*Limitado a " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)) & " resultado (s)"
        Preencher_Filtros()
        Executa_Pesquisa()
    End Sub
    Private Sub btn_Pesquisar_Click(sender As Object, e As EventArgs) Handles btn_Pesquisar.Click
        Executa_Pesquisa()
    End Sub
    Sub Executa_Pesquisa()

        Dim sCondicao As String = ""
        Dim adapter As New MySqlDataAdapter()
        Dim cmd As MySqlCommand

        Dim texto_and_or As String = ""
        Dim cont_parametro As Integer = 1

        Dim listClientes As String = ""
        Dim listStatusAprovacao As String = ""
        Dim listJustificativaAprovacao As String = ""
        Dim listPrioridade As String = ""
        Dim listUsuario As String = ""
        Dim listSetor As String = ""
        Dim textopesquisado As String = ""

        'Verifica clientes selecionados
        If clb_Cliente.CheckedItems.Count > 0 Then
            For Each item In clb_Cliente.CheckedItems
                If listClientes = "" Then
                    listClientes = item.Item("ID_Cliente")
                Else
                    listClientes = listClientes & "," & item.Item("ID_Cliente")
                End If
            Next
        End If

        If listClientes <> "" Then
            If sCondicao = "" Then
                sCondicao = "prop.id_cliente IN (" & listClientes & ")"
            Else
                sCondicao = sCondicao & " AND " & "prop.id_cliente IN (" & listClientes & ")"
            End If
        End If

        'verifica status_aprovacao selecionados
        If clb_Status_Aprovacao.CheckedItems.Count > 0 Then
            For Each item In clb_Status_Aprovacao.CheckedItems
                If listStatusAprovacao = "" Then
                    listStatusAprovacao = item.item("id_Status_Aprovacao")
                Else
                    listStatusAprovacao = listStatusAprovacao & "," & item.item("id_Status_Aprovacao")
                End If
            Next
        End If

        If listStatusAprovacao <> "" Then
            If sCondicao = "" Then
                sCondicao = "itpr.id_status_aprovacao IN (" & listStatusAprovacao & ")"
            Else
                sCondicao = sCondicao & " AND " & "itpr.id_status_aprovacao IN (" & listStatusAprovacao & ")"
            End If
        End If

        'Verifica justificativas de aprovação selecionados
        If clb_Justificativa_Aprovacao.CheckedItems.Count > 0 Then
            For Each item In clb_Justificativa_Aprovacao.CheckedItems
                If listJustificativaAprovacao = "" Then
                    listJustificativaAprovacao = item.Item("ID_Justificativa_Aprovacao")
                Else
                    listJustificativaAprovacao = listJustificativaAprovacao & "," & item.Item("ID_Justificativa_Aprovacao")
                End If
            Next
        End If

        If listJustificativaAprovacao <> "" Then
            If sCondicao = "" Then
                sCondicao = "itpr.id_justificativa_aprovacao IN (" & listJustificativaAprovacao & ")"
            Else
                sCondicao = sCondicao & " AND " & "itpr.id_justificativa_aprovacao IN (" & listJustificativaAprovacao & ")"
            End If
        End If

        'Verifica prioridade selecionadas
        If clb_Prioridade.CheckedItems.Count > 0 Then
            For Each item In clb_Prioridade.CheckedItems
                If listPrioridade = "" Then
                    listPrioridade = item.Item("ID_Prioridade")
                Else
                    listPrioridade = listPrioridade & "," & item.Item("ID_Prioridade")
                End If
            Next
        End If

        If listPrioridade <> "" Then
            If sCondicao = "" Then
                sCondicao = "prop.id_prioridade IN (" & listPrioridade & ")"
            Else
                sCondicao = sCondicao & " AND " & "prop.id_prioridade IN (" & listPrioridade & ")"
            End If
        End If

        'Verifica usuários selecionadas
        If clb_Usuario.CheckedItems.Count > 0 Then
            For Each item In clb_Usuario.CheckedItems
                If listUsuario = "" Then
                    listUsuario = item.Item("ID_Usuario")
                Else
                    listUsuario = listUsuario & "," & item.Item("ID_Usuario")
                End If
            Next
        End If

        If listUsuario <> "" Then
            If sCondicao = "" Then
                sCondicao = "prop.id_usuario_insercao IN (" & listUsuario & ")"
            Else
                sCondicao = sCondicao & " AND " & "prop.id_usuario_insercao IN (" & listUsuario & ")"
            End If
        End If

        'Verifica setores selecionadas
        If clb_Setor.CheckedItems.Count > 0 Then
            For Each item In clb_Setor.CheckedItems
                If listSetor = "" Then
                    listSetor = item.Item("ID_Setor")
                Else
                    listSetor = listSetor & "," & item.Item("ID_Setor")
                End If
            Next
        End If

        If listSetor <> "" Then
            If sCondicao = "" Then
                sCondicao = "prop_usua_ins.id_setor IN (" & listSetor & ")"
            Else
                sCondicao = sCondicao & " AND " & "prop_usua_ins.id_setor IN (" & listSetor & ")"
            End If
        End If

        If dtp_Data_Solicitacao_De.Checked = True And dtp_Data_Solicitacao_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(prop.data_solicitacao) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_De.Value, "yyyy/MM/dd")) & "' AND DATE(prop.data_solicitacao) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(prop.data_solicitacao) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_De.Value, "yyyy/MM/dd")) & "' AND DATE(prop.data_solicitacao) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Solicitacao_De.Checked = True And dtp_Data_Solicitacao_Ate.Checked = False Then
            If sCondicao = "" Then
                sCondicao = "DATE(prop.data_solicitacao) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_De.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(prop.data_solicitacao) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_De.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Solicitacao_De.Checked = False And dtp_Data_Solicitacao_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(prop.data_solicitacao) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(prop.data_solicitacao) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Solicitacao_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Envio_Faturamento_De.Checked = True And dtp_Data_Envio_Faturamento_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(prop.data_envio_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_De.Value, "yyyy/MM/dd")) & "' AND DATE(prop.data_envio_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(prop.data_envio_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_De.Value, "yyyy/MM/dd")) & "' AND DATE(prop.data_envio_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Envio_Faturamento_De.Checked = True And dtp_Data_Envio_Faturamento_Ate.Checked = False Then
            If sCondicao = "" Then
                sCondicao = "DATE(prop.data_envio_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_De.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(prop.data_envio_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_De.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Envio_Faturamento_De.Checked = False And dtp_Data_Envio_Faturamento_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(prop.data_envio_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(prop.data_envio_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Faturamento_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Envio_Cliente_De.Checked = True And dtp_Data_Envio_Cliente_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "date(prop.data_envio) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_De.Value, "yyyy/mm/dd")) & "' AND date(prop.data_envio) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_Ate.Value, "yyyy/mm/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "date(prop.data_envio) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_De.Value, "yyyy/mm/dd")) & "' AND date(prop.data_envio) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_Ate.Value, "yyyy/mm/dd")) & "'"
            End If
        End If

        If dtp_Data_Envio_Cliente_De.Checked = True And dtp_Data_Envio_Cliente_Ate.Checked = False Then
            If sCondicao = "" Then
                sCondicao = "date(prop.data_envio) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_De.Value, "yyyy/mm/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "date(prop.data_envio) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_De.Value, "yyyy/mm/dd")) & "'"
            End If
        End If

        If dtp_Data_Envio_Cliente_De.Checked = False And dtp_Data_Envio_Cliente_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "date(prop.data_envio) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_Ate.Value, "yyyy/mm/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "date(prop.data_envio) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Envio_Cliente_Ate.Value, "yyyy/mm/dd")) & "'"
            End If
        End If

        If dtp_Data_Faturamento_De.Checked = True And dtp_Data_Faturamento_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "date(prop.data_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_De.Value, "yyyy/mm/dd")) & "' AND date(prop.data_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_Ate.Value, "yyyy/mm/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "date(prop.data_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_De.Value, "yyyy/mm/dd")) & "' AND date(prop.data_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_Ate.Value, "yyyy/mm/dd")) & "'"
            End If
        End If

        If dtp_Data_Faturamento_De.Checked = True And dtp_Data_Faturamento_Ate.Checked = False Then
            If sCondicao = "" Then
                sCondicao = "date(prop.data_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_De.Value, "yyyy/mm/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "date(prop.data_faturamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_De.Value, "yyyy/mm/dd")) & "'"
            End If
        End If

        If dtp_Data_Faturamento_De.Checked = False And dtp_Data_Faturamento_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "date(prop.data_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_Ate.Value, "yyyy/mm/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "date(prop.data_faturamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Faturamento_Ate.Value, "yyyy/mm/dd")) & "'"
            End If
        End If

        If txt_Texto_Pesquisa.Text <> "" Then

            textopesquisado = "(fili.nome LIKE @filial OR 
                cont.nome LIKE @contato OR 
                prop.codigo_proposta LIKE @codigoproposta OR 
                fabr.nome LIKE @fabricante OR 
                tieq.nome LIKE @tipoequipamento OR 
                mode.nome LIKE @modelo OR 
                seri.nome LIKE @serie OR 
                prop.comentarios LIKE @comentarios OR 
                tiit.nome LIKE @tipoitem OR 
                forn.nome LIKE @fornecedor OR 
                itpr.codigo_item LIKE @codigoitem OR 
                itpr.descricao_item LIKE @descricaoitem OR 
                itpr.comentarios_item LIKE @comentariositem)"

            If sCondicao = "" Then
                sCondicao = textopesquisado
            Else
                sCondicao = sCondicao & " AND " & textopesquisado
            End If

        End If

        If chb_Considerar_Revisadas.Checked = True Then
            If sCondicao <> "" Then
                sCondicao = " WHERE " & sCondicao
            End If
        Else

            If sCondicao <> "" Then
                sCondicao = " WHERE id_ultima_proposta IS NULL AND " & sCondicao
            Else
                sCondicao = " WHERE id_ultima_proposta IS NULL "
            End If

        End If

        Try
            Abrir_Conexao()

            Dim dtb_Resultados As New DataTable

            Dim dtbStatusAprovacao As New DataTable
            Dim strsqlcommand As String = ""

            cmd = New MySqlCommand("SELECT id_status_aprovacao, nome FROM tb_status_aprovacao", strConexao)
            adapter.SelectCommand = cmd
            adapter.Fill(dtbStatusAprovacao)

            Dim qtIf As Integer = 0

            For Each rowStatusAprovacao As DataRow In dtbStatusAprovacao.Rows
                If strsqlcommand = "" Then
                    strsqlcommand = "IF(SUM(IF(itpr.id_status_aprovacao=" & CONVERT_TO_STRING(rowStatusAprovacao("id_status_aprovacao")) & ",1,0))=COUNT(itpr.id_item_proposta),(SELECT nome FROM tb_status_aprovacao WHERE id_status_aprovacao=" & CONVERT_TO_STRING(rowStatusAprovacao("id_status_aprovacao")) & ")"
                Else
                    strsqlcommand = strsqlcommand & "," & "IF(SUM(IF(itpr.id_status_aprovacao=" & CONVERT_TO_STRING(rowStatusAprovacao("id_status_aprovacao")) & ",1,0))=COUNT(itpr.id_item_proposta),(SELECT nome FROM tb_status_aprovacao WHERE id_status_aprovacao=" & CONVERT_TO_STRING(rowStatusAprovacao("id_status_aprovacao")) & ")"

                End If
                qtIf = qtIf + 1
            Next
            strsqlcommand = strsqlcommand & "," & "IF(SUM(IF(itpr.id_status_aprovacao=1,1,0))>0,(SELECT nome FROM tb_status_aprovacao WHERE id_status_aprovacao=2),'Diversos'"

            For x As Integer = 1 To qtIf
                strsqlcommand = strsqlcommand & ")"
            Next
            strsqlcommand = strsqlcommand & ")"

            cmd = New MySqlCommand("SELECT prop_usua_ins.nome AS Nome_Usuario, prop.id_proposta AS ID_Proposta, prop.codigo_proposta AS Codigo_Proposta, 
                                            prop.data_solicitacao AS Data_Solicitacao, clie.nome AS Nome_Cliente, cont.nome AS Nome_Contato, prop.data_envio AS Data_Envio, 
                                            SUM(itpr.quantidade_item) AS Quantidade_Total, SUM(CASE WHEN itpr.id_tipo_item=1 THEN itpr.preco_total_final_item END) AS Valor_Pecas,
                                            SUM(CASE WHEN itpr.id_tipo_item<>1 THEN itpr.preco_total_final_item END) AS Valor_Servicos, " &
                                            strsqlcommand & " AS Status_Aprovacao,
                                            SUM(itpr.preco_total_final_item) AS Valor_Total, seri.nome AS Nome_Serie,
                                            prop.valor_faturamento AS Valor_Faturamento, prop.data_envio_faturamento AS Data_Envio_Faturamento, prop.data_faturamento AS Data_Faturamento,
                                            prop.nota_fiscal AS Nota_Fiscal, prop.comentarios AS Comentarios_Proposta
                                            FROM tb_propostas AS prop
                                            LEFT JOIN tb_itens_propostas AS itpr ON itpr.id_proposta=prop.id_proposta
                                            LEFT JOIN tb_usuarios AS itpr_usua_ins ON itpr.id_usuario=itpr_usua_ins.id_usuario
                                            LEFT JOIN tb_usuarios AS prop_usua_ins ON prop.id_usuario_insercao=prop_usua_ins.id_usuario
                                            LEFT JOIN tb_status AS itpr_stat ON itpr.id_status=itpr_stat.id_status
                                            LEFT JOIN tb_status_aprovacao AS stap ON itpr.id_status_aprovacao=stap.id_status_aprovacao
                                            LEFT JOIN tb_justificativas_aprovacao AS juap ON itpr.id_justificativa_aprovacao=juap.id_justificativa_aprovacao
                                            LEFT JOIN tb_tipos_item AS tiit ON itpr.id_tipo_item=tiit.id_tipo_item
                                            LEFT JOIN tb_fornecedores AS forn ON itpr.id_fornecedor=forn.id_fornecedor
                                            LEFT JOIN tb_tipos_substituicao_tributaria AS tstr ON itpr.id_tipo_substituicao_tributaria_item=tstr.id_tipo_substituicao_tributaria
                                            LEFT JOIN tb_origens AS orig ON itpr.id_origem_item=orig.id_origem
                                            LEFT JOIN tb_filiais AS fili ON prop.id_filial=fili.id_filial
                                            LEFT JOIN tb_clientes AS clie ON prop.id_cliente=clie.id_cliente
                                            LEFT JOIN tb_contatos AS cont ON prop.id_contato=cont.id_contato
                                            LEFT JOIN tb_prioridades AS prio ON prop.id_prioridade=prio.id_prioridade
                                            LEFT JOIN tb_fabricantes AS fabr ON prop.id_fabricante=fabr.id_fabricante
                                            LEFT JOIN tb_tipos_equipamento AS tieq ON prop.id_tipo_equipamento=tieq.id_tipo_equipamento
                                            LEFT JOIN tb_modelos AS mode ON prop.id_modelo=mode.id_modelo
                                            LEFT JOIN tb_anos AS ano ON prop.id_ano=ano.id_ano
                                            LEFT JOIN tb_series AS seri ON prop.id_serie=seri.id_serie " &
                                            sCondicao & " GROUP BY itpr.id_proposta ORDER BY prop.data_solicitacao LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            If txt_Texto_Pesquisa.Text <> "" Then

                cmd.Parameters.AddWithValue("@filial", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@contato", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@codigoproposta", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@fabricante", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@tipoequipamento", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@modelo", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@serie", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@comentarios", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@tipoitem", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@fornecedor", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@codigoitem", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@descricaoitem", "%" & txt_Texto_Pesquisa.Text & "%")
                cmd.Parameters.AddWithValue("@comentariositem", "%" & txt_Texto_Pesquisa.Text & "%")

            End If

            adapter.SelectCommand = cmd

            adapter.Fill(dtb_Resultados)
            dtg_Resultados.DataSource = dtb_Resultados

            Dim dtbCol As DataColumn
            Dim duration As TimeSpan
            Dim drow As DataRow
            dtbCol = dtb_Resultados.Columns.Add("Tempo_Resposta")

            For Each drow In dtb_Resultados.Rows
                If Not String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Solicitacao"))) Then
                    If String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Envio"))) Then
                        duration = CONVERT_TO_DATE(Now) - CONVERT_TO_DATE(drow("Data_Solicitacao"))
                    Else
                        duration = CONVERT_TO_DATE(drow("Data_Envio")) - CONVERT_TO_DATE(drow("Data_Solicitacao"))
                    End If
                    drow("Tempo_Resposta") = duration.ToString("%d") & " dia(s) e " & duration.ToString("hh\:mm")
                End If
            Next

            dtbCol = dtb_Resultados.Columns.Add("Tempo_Faturamento")

            For Each drow In dtb_Resultados.Rows
                If Not String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Envio_Faturamento"))) Then
                    If String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Faturamento"))) Then
                        duration = CONVERT_TO_DATE(Now) - CONVERT_TO_DATE(drow("Data_Envio_Faturamento"))
                    Else
                        duration = CONVERT_TO_DATE(drow("Data_Faturamento")) - CONVERT_TO_DATE(drow("Data_Envio_Faturamento"))
                    End If
                    drow("Tempo_Faturamento") = duration.ToString("%d") & " dia(s) e " & duration.ToString("hh\:mm")
                End If
            Next

            If dtb_Resultados.Rows.Count = 0 Then
                lbl_Quantidade_Resultados.Text = "Nenhum resultado encontrado"
            Else
                lbl_Quantidade_Resultados.Text = "Resultados encontrados: " & dtb_Resultados.Rows.Count
            End If

            dtg_Resultados.Columns("Nome_Usuario").HeaderText = "Usuário"
            dtg_Resultados.Columns("Codigo_Proposta").HeaderText = "Código da proposta"
            dtg_Resultados.Columns("Data_Solicitacao").HeaderText = "Data da solicitação"
            dtg_Resultados.Columns("Nome_Cliente").HeaderText = "Cliente"
            dtg_Resultados.Columns("Nome_Contato").HeaderText = "Contato"
            dtg_Resultados.Columns("Data_Envio").HeaderText = "Data do envio"
            dtg_Resultados.Columns("Quantidade_Total").HeaderText = "Quantidade de itens"
            dtg_Resultados.Columns("Valor_Pecas").HeaderText = "Valor de peças"
            dtg_Resultados.Columns("Valor_Servicos").HeaderText = "Valor de serviços"
            dtg_Resultados.Columns("Valor_Total").HeaderText = "Valor total"
            dtg_Resultados.Columns("Nome_Serie").HeaderText = "Série"
            dtg_Resultados.Columns("Data_Envio").HeaderText = "Data de envio"
            dtg_Resultados.Columns("Status_Aprovacao").HeaderText = "Status da aprovação"
            dtg_Resultados.Columns("Comentarios_Proposta").HeaderText = "Comentários da proposta"
            dtg_Resultados.Columns("Tempo_Resposta").HeaderText = "Tempo de resposta"

            dtg_Resultados.Columns("Valor_Faturamento").HeaderText = "Valor faturado"
            dtg_Resultados.Columns("Data_Envio_Faturamento").HeaderText = "Data de envio para faturamento"
            dtg_Resultados.Columns("Data_Faturamento").HeaderText = "Faturado em"
            dtg_Resultados.Columns("Nota_Fiscal").HeaderText = "Nota fiscal"
            dtg_Resultados.Columns("Tempo_Faturamento").HeaderText = "Tempo para emissão"

            dtg_Resultados.Columns("Quantidade_Total").DefaultCellStyle.Format = "#,##0"
            dtg_Resultados.Columns("Valor_Pecas").DefaultCellStyle.Format = "#,##0.00"
            dtg_Resultados.Columns("Valor_Servicos").DefaultCellStyle.Format = "#,##0.00"
            dtg_Resultados.Columns("Valor_Total").DefaultCellStyle.Format = "#,##0.00"

            ' dtg_Resultados.Columns("ID_Item_Proposta").Visible = False
            dtg_Resultados.Columns("ID_Proposta").Visible = False

            dtg_Resultados.Columns("Nome_Usuario").DisplayIndex = 0
            dtg_Resultados.Columns("Nome_Cliente").DisplayIndex = 1
            dtg_Resultados.Columns("Nome_Contato").DisplayIndex = 2
            dtg_Resultados.Columns("Nome_Serie").DisplayIndex = 3
            dtg_Resultados.Columns("Codigo_Proposta").DisplayIndex = 4
            dtg_Resultados.Columns("Data_Solicitacao").DisplayIndex = 5
            dtg_Resultados.Columns("Data_Envio").DisplayIndex = 6
            dtg_Resultados.Columns("Tempo_Resposta").DisplayIndex = 7
            dtg_Resultados.Columns("Valor_Pecas").DisplayIndex = 8
            dtg_Resultados.Columns("Valor_Servicos").DisplayIndex = 9
            dtg_Resultados.Columns("Quantidade_Total").DisplayIndex = 10
            dtg_Resultados.Columns("Valor_Total").DisplayIndex = 11
            dtg_Resultados.Columns("Status_Aprovacao").DisplayIndex = 12
            dtg_Resultados.Columns("Valor_Faturamento").DisplayIndex = 13
            dtg_Resultados.Columns("Data_Envio_Faturamento").DisplayIndex = 14
            dtg_Resultados.Columns("Data_Faturamento").DisplayIndex = 15
            dtg_Resultados.Columns("Nota_Fiscal").DisplayIndex = 16
            dtg_Resultados.Columns("Tempo_Faturamento").DisplayIndex = 17
            dtg_Resultados.Columns("Comentarios_Proposta").DisplayIndex = 18

            For Each dtb_row As DataRow In dtb_Resultados.Rows
                dtb_row("Nome_Usuario") = GET_WORD(dtb_row("Nome_Usuario"), " ", Part_Word_Text.First_Last_Word)
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Sub Preencher_Filtros()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            'Preenche a listbox de cliente
            adapter = New MySqlDataAdapter("SELECT DISTINCT prop.id_cliente AS ID_Cliente, clie.nome AS Nome_Cliente FROM tb_propostas AS prop LEFT JOIN tb_clientes AS clie ON prop.id_cliente=clie.id_cliente ORDER BY Nome_Cliente ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "clb_Cliente")
            clb_Cliente.DataSource = ds.Tables("clb_Cliente")
            clb_Cliente.DisplayMember = "Nome_Cliente"
            clb_Cliente.ValueMember = "ID_Cliente"

            'Preenche a listbox de ano de solicitação
            adapter = New MySqlDataAdapter("SELECT DISTINCT itpr.id_status_aprovacao AS ID_Status_Aprovacao, stat.nome AS Nome_Status_Aprovacao FROM tb_itens_propostas AS itpr LEFT JOIN tb_status_aprovacao AS stat ON itpr.id_status_aprovacao=stat.id_status_aprovacao ORDER BY Nome_Status_Aprovacao ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "clb_Status_Aprovacao")
            clb_Status_Aprovacao.DataSource = ds.Tables("clb_Status_Aprovacao")
            clb_Status_Aprovacao.DisplayMember = "Nome_Status_Aprovacao"
            clb_Status_Aprovacao.ValueMember = "ID_Status_Aprovacao"

            'Preenche a listbox de mês de solicitação
            ' adapter = New MySqlDataAdapter("SET lc_time_names = 'pt_BR';SELECT DISTINCT MONTHNAME(data_solicitacao) AS Month FROM tb_propostas", strConexao)
            adapter = New MySqlDataAdapter("SELECT DISTINCT itpr.id_justificativa_aprovacao AS ID_Justificativa_Aprovacao, just.nome AS Nome_Justificativa_Aprovacao FROM tb_itens_propostas AS itpr LEFT JOIN tb_justificativas_aprovacao AS just ON itpr.id_justificativa_aprovacao=just.id_justificativa_aprovacao ORDER BY Nome_Justificativa_Aprovacao ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "clb_Justificativa_Aprovacao")
            clb_Justificativa_Aprovacao.DataSource = ds.Tables("clb_Justificativa_Aprovacao")
            clb_Justificativa_Aprovacao.DisplayMember = "Nome_Justificativa_Aprovacao"
            clb_Justificativa_Aprovacao.ValueMember = "ID_Justificativa_Aprovacao"

            'Preenche a listbox de ano de solicitação
            adapter = New MySqlDataAdapter("SELECT DISTINCT prop.id_prioridade AS ID_Prioridade, prio.nome AS Nome_Prioridade FROM tb_propostas AS prop LEFT JOIN tb_prioridades AS prio ON prop.id_prioridade=prio.id_prioridade ORDER BY Nome_Prioridade ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "clb_Prioridade")
            clb_Prioridade.DataSource = ds.Tables("clb_Prioridade")
            clb_Prioridade.DisplayMember = "Nome_Prioridade"
            clb_Prioridade.ValueMember = "ID_Prioridade"

            'Preenche a listbox de ano de solicitação
            adapter = New MySqlDataAdapter("SELECT DISTINCT prop.id_usuario_insercao AS ID_Usuario, usua.nome AS Nome_Usuario FROM tb_propostas AS prop LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario ORDER BY Nome_Usuario ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "clb_Usuario")
            clb_Usuario.DataSource = ds.Tables("clb_Usuario")
            clb_Usuario.DisplayMember = "Nome_Usuario"
            clb_Usuario.ValueMember = "ID_Usuario"

            For Each dtb_row As DataRow In ds.Tables("clb_Usuario").Rows
                dtb_row("Nome_Usuario") = GET_WORD(dtb_row("Nome_Usuario"), " ", Part_Word_Text.First_Last_Word)
            Next

            'Preenche a listbox de setores
            adapter = New MySqlDataAdapter("SELECT DISTINCT usua.id_setor AS ID_Setor, seto.nome AS Nome_Setor FROM tb_propostas AS prop LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario LEFT JOIN tb_setores AS seto ON usua.id_setor=seto.id_setor ORDER BY Nome_Setor ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "clb_Setor")
            clb_Setor.DataSource = ds.Tables("clb_Setor")

            clb_Setor.DisplayMember = "Nome_Setor"
            clb_Setor.ValueMember = "ID_Setor"

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub dtg_Resultados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Resultados.CellDoubleClick
        Dim dtg_row As DataGridViewRow = dtg_Resultados.Rows(e.RowIndex)
        get_id_proposta = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_row.Cells("ID_Proposta").Value))
        Dim form = New Proposta
        form.ShowDialog()
        Executa_Pesquisa()
    End Sub

    Private Sub ptb_Status_Aprovacao_Click(sender As Object, e As EventArgs) Handles ptb_Status_Aprovacao.Click
        For i As Integer = 0 To clb_Status_Aprovacao.Items.Count - 1
            clb_Status_Aprovacao.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub

    Private Sub ptb_Justificativa_Aprovacao_Click(sender As Object, e As EventArgs) Handles ptb_Justificativa_Aprovacao.Click
        For i As Integer = 0 To clb_Justificativa_Aprovacao.Items.Count - 1
            clb_Justificativa_Aprovacao.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub

    Private Sub ptb_Prioridade_Click(sender As Object, e As EventArgs) Handles ptb_Prioridade.Click
        For i As Integer = 0 To clb_Prioridade.Items.Count - 1
            clb_Prioridade.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Usuario_Click(sender As Object, e As EventArgs) Handles ptb_Usuario.Click
        For i As Integer = 0 To clb_Usuario.Items.Count - 1
            clb_Usuario.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Setor_Click(sender As Object, e As EventArgs) Handles ptb_Setor.Click
        For i As Integer = 0 To clb_Setor.Items.Count - 1
            clb_Setor.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Data_Solicitacao_Click(sender As Object, e As EventArgs) Handles ptb_Data_Solicitacao.Click
        dtp_Data_Solicitacao_De.Checked = False
        dtp_Data_Solicitacao_Ate.Checked = False
        Executa_Pesquisa()
    End Sub

    Private Sub ptb_Data_Envio_Cliente_Click(sender As Object, e As EventArgs) Handles ptb_Data_Envio_Cliente.Click
        dtp_Data_Envio_Cliente_De.Checked = False
        dtp_Data_Envio_Cliente_Ate.Checked = False
        Executa_Pesquisa()
    End Sub

    Private Sub ptb_Data_Envio_Faturamento_Click(sender As Object, e As EventArgs) Handles ptb_Data_Envio_Faturamento.Click
        dtp_Data_Envio_Faturamento_De.Checked = False
        dtp_Data_Envio_Faturamento_Ate.Checked = False
        Executa_Pesquisa()
    End Sub

    Private Sub ptb_Data_Faturamento_Click(sender As Object, e As EventArgs) Handles ptb_Data_Faturamento.Click
        dtp_Data_Faturamento_De.Checked = False
        dtp_Data_Faturamento_Ate.Checked = False
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Cliente_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Cliente.MouseUp
        Executa_Pesquisa()
    End Sub

    Private Sub clb_Status_Aprovacao_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Status_Aprovacao.MouseUp
        Executa_Pesquisa()
    End Sub

    Private Sub clb_Justificativa_Aprovacao_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Justificativa_Aprovacao.MouseUp
        Executa_Pesquisa()
    End Sub

    Private Sub clb_Prioridade_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Prioridade.MouseUp
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Usuario_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Usuario.MouseUp
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Setor_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Setor.MouseUp
        Executa_Pesquisa()
    End Sub
    Private oldData_Solicitacao_DeChecked = False
    Private oldData_Solicitacao_AteChecked = False
    Private Sub dtp_Data_Solicitacao_De_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Solicitacao_De.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Solicitacao_Ate_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Solicitacao_Ate.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Solicitacao_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Solicitacao_De.ValueChanged
        If dtp_Data_Solicitacao_De.Checked <> oldData_Solicitacao_DeChecked Then
            oldData_Solicitacao_DeChecked = dtp_Data_Solicitacao_De.Checked
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub dtp_Data_Solicitacao_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Solicitacao_Ate.ValueChanged
        If dtp_Data_Solicitacao_Ate.Checked <> oldData_Solicitacao_AteChecked Then
            oldData_Solicitacao_AteChecked = dtp_Data_Solicitacao_Ate.Checked
            Executa_Pesquisa()
        End If
    End Sub




    Private oldData_Envio_Cliente_DeChecked = False
    Private oldData_Envio_Cliente_AteChecked = False
    Private Sub dtp_Data_Envio_Cliente_De_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Cliente_De.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Envio_Cliente_Ate_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Cliente_Ate.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Envio_Cliente_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Cliente_De.ValueChanged
        If dtp_Data_Envio_Cliente_De.Checked <> oldData_Envio_Cliente_DeChecked Then
            oldData_Envio_Cliente_DeChecked = dtp_Data_Envio_Cliente_De.Checked
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub dtp_Data_Envio_Cliente_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Cliente_Ate.ValueChanged
        If dtp_Data_Envio_Cliente_Ate.Checked <> oldData_Envio_Cliente_AteChecked Then
            oldData_Envio_Cliente_AteChecked = dtp_Data_Envio_Cliente_Ate.Checked
            Executa_Pesquisa()
        End If
    End Sub



    Private oldData_Envio_Faturamento_DeChecked = False
    Private oldData_Envio_Faturamento_AteChecked = False
    Private Sub dtp_Data_Envio_Faturamento_De_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Faturamento_De.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Envio_Faturamento_Ate_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Faturamento_Ate.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Envio_Faturamento_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Faturamento_De.ValueChanged
        If dtp_Data_Envio_Faturamento_De.Checked <> oldData_Envio_Faturamento_DeChecked Then
            oldData_Envio_Faturamento_DeChecked = dtp_Data_Envio_Faturamento_De.Checked
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub dtp_Data_Envio_Faturamento_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Envio_Faturamento_Ate.ValueChanged
        If dtp_Data_Envio_Faturamento_Ate.Checked <> oldData_Envio_Faturamento_AteChecked Then
            oldData_Envio_Faturamento_AteChecked = dtp_Data_Envio_Faturamento_Ate.Checked
            Executa_Pesquisa()
        End If
    End Sub



    Private oldData_Faturamento_DeChecked = False
    Private oldData_Faturamento_AteChecked = False
    Private Sub dtp_Data_Faturamento_De_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Faturamento_De.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Faturamento_Ate_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Faturamento_Ate.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Faturamento_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Faturamento_De.ValueChanged
        If dtp_Data_Faturamento_De.Checked <> oldData_Faturamento_DeChecked Then
            oldData_Faturamento_DeChecked = dtp_Data_Faturamento_De.Checked
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub dtp_Data_Faturamento_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Faturamento_Ate.ValueChanged
        If dtp_Data_Faturamento_Ate.Checked <> oldData_Faturamento_AteChecked Then
            oldData_Faturamento_AteChecked = dtp_Data_Faturamento_Ate.Checked
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub ptb_Cliente_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Cliente.MouseMove
        ptb_Cliente.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Cliente_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Cliente.MouseLeave
        ptb_Cliente.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Status_Aprovacao_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Status_Aprovacao.MouseMove
        ptb_Status_Aprovacao.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Status_Aprovacao_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Status_Aprovacao.MouseLeave
        ptb_Status_Aprovacao.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Justificativa_Aprovacao_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Justificativa_Aprovacao.MouseMove
        ptb_Justificativa_Aprovacao.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Justificativa_Aprovacao_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Justificativa_Aprovacao.MouseLeave
        ptb_Justificativa_Aprovacao.BackColor = SystemColors.Control
    End Sub


    Private Sub ptb_Prioridade_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Prioridade.MouseMove
        ptb_Prioridade.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Prioridade_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Prioridade.MouseLeave
        ptb_Prioridade.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Usuario_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Usuario.MouseMove
        ptb_Usuario.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Usuario_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Usuario.MouseLeave
        ptb_Usuario.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Setor_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Setor.MouseMove
        ptb_Setor.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Setor_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Setor.MouseLeave
        ptb_Setor.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Data_Solicitacao_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Data_Solicitacao.MouseMove
        ptb_Data_Solicitacao.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Data_Solicitacao_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Data_Solicitacao.MouseLeave
        ptb_Data_Solicitacao.BackColor = SystemColors.Control
    End Sub


    Private Sub ptb_Data_Envio_Cliente_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Data_Envio_Cliente.MouseMove
        ptb_Data_Envio_Cliente.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Data_Envio_Cliente_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Data_Envio_Cliente.MouseLeave
        ptb_Data_Envio_Cliente.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Data_Envio_Faturamento_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Data_Envio_Faturamento.MouseMove
        ptb_Data_Envio_Faturamento.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Data_Envio_Faturamento_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Data_Envio_Faturamento.MouseLeave
        ptb_Data_Envio_Faturamento.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Data_Faturamento_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Data_Faturamento.MouseMove
        ptb_Data_Faturamento.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Data_Faturamento_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Data_Faturamento.MouseLeave
        ptb_Data_Faturamento.BackColor = SystemColors.Control
    End Sub

    Private Sub txt_Texto_Pesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Texto_Pesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub pnl_Cliente_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Cliente.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Cliente.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnl_Status_Aprovacao_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Status_Aprovacao.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Status_Aprovacao.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnl_Justificativa_Aprovacao_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Justificativa_Aprovacao.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Justificativa_Aprovacao.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnl_Prioridade_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Prioridade.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Prioridade.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Usuario_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Usuario.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Usuario.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Setor_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Setor.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Usuario.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Data_Solicitacao_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Data_Solicitacao.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Data_Solicitacao.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnl_Data_Envio_Cliente_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Data_Envio_Cliente.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Data_Envio_Cliente.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub


    Private Sub pnl_Data_Envio_Faturamento_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Data_Envio_Faturamento.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Data_Envio_Faturamento.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnl_Data_Faturamento_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Data_Faturamento.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Data_Faturamento.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub ptb_Cliente_Click(sender As Object, e As EventArgs) Handles ptb_Cliente.Click

    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click

        Dim strarquivoSalvo As String = ""

        Using OFD As New SaveFileDialog With {.FileName = "Pesquisa_SGT_" & Format(Now, "yyyyMMddhhmmss"), .Filter = "Arquivo do Excel (*.xlsx)|*.xlsx"}
            If OFD.ShowDialog = DialogResult.OK Then
                strarquivoSalvo = OFD.FileName
            End If
        End Using

        If String.IsNullOrEmpty(strarquivoSalvo) Then
            Exit Sub
        End If

        Dim elApp As New Microsoft.Office.Interop.Excel.Application()
        Dim elWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim elWorksheet As Microsoft.Office.Interop.Excel.Worksheet

        'Dim elRange As Microsoft.Office.Interop.Excel.Range

        Try

            elApp.Visible = False
            'elApp.Workbooks.Open(WorkbookPath, False, False, Password:=WorkbookPassword)
            elWorkbook = elApp.Workbooks.Add
            elWorksheet = elWorkbook.Worksheets(1)
            elWorksheet.Name = "pesquisa"

            For Each dtg_col As DataGridViewColumn In dtg_Resultados.Columns
                If dtg_col.Visible = True Then
                    elWorksheet.Cells(1, dtg_col.Index + 1).Value = dtg_col.HeaderText
                End If
            Next

            Dim elColumn As Long = 1
            Dim elRow As Long = 2

            For Each dtg_col As DataGridViewColumn In dtg_Resultados.Columns
                If dtg_col.Visible = True Then
                    elWorksheet.Cells(1, elColumn).Value = dtg_col.HeaderText
                    elRow = 2
                    For Each dtb_row As DataGridViewRow In dtg_Resultados.Rows
                        elWorksheet.Cells(elRow, elColumn).Value = dtb_row.Cells(dtg_col.Index).Value
                        elRow = elRow + 1
                    Next
                    elColumn = elColumn + 1
                End If
            Next

            elWorkbook.SaveAs(strarquivoSalvo)

            For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
                wb.Close(False)
            Next

            elApp.Quit()
            releaseObject(elWorksheet)
            elWorksheet = Nothing
            releaseObject(elWorkbook)
            elWorkbook = Nothing
            releaseObject(elApp)
            elApp = Nothing

            MessageBox.Show(text:="Arquivo exportado com sucesso!", caption:="Procedimento concluído", buttons:=vbOKOnly, icon:=vbInformation)

        Catch ex As Exception
            For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
                wb.Close(False)
            Next

            elApp.Quit()
            releaseObject(elWorksheet)
            elWorksheet = Nothing
            releaseObject(elWorkbook)
            elWorkbook = Nothing
            releaseObject(elApp)
            elApp = Nothing
        End Try

    End Sub

    Private Sub chb_Considerar_Revisadas_CheckedChanged(sender As Object, e As EventArgs) Handles chb_Considerar_Revisadas.CheckedChanged
        Executa_Pesquisa()
    End Sub

    Private Sub dtg_Resultados_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtg_Resultados.CellMouseDown
        dtg_Resultados.ContextMenuStrip = Nothing
        If e.Button = MouseButtons.Right And e.ColumnIndex >= 0 And e.RowIndex >= 0 Then

            dtg_Resultados.CurrentCell = dtg_Resultados(e.ColumnIndex, e.RowIndex)

            Dim Quantidade_Itens As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Quantidade_Total").Value.ToString)

            If Quantidade_Itens = 0 Then
                tsmi_Visualizar.Visible = False
            Else
                tsmi_Visualizar.Visible = True
            End If

            Dim Quantidade_Pecas As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Pecas").Value.ToString)

            If Quantidade_Pecas = 0 Then
                tsmi_Exibir_Codigo.Visible = False '
                tsmi_Nao_Exibir_Codigo.Visible = False
            Else
                tsmi_Exibir_Codigo.Visible = True
                tsmi_Nao_Exibir_Codigo.Visible = True
            End If

            dtg_Resultados.ContextMenuStrip = cms_Abrir_Proposta
        End If
    End Sub

    Private Sub tsmi_Visualizar_Click(sender As Object, e As EventArgs) Handles tsmi_Visualizar.Click

        Dim Quantidade_Itens As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Quantidade_Total").Value.ToString)

        If Quantidade_Itens = 0 Then
            Exit Sub
        End If

        Dim Quantidade_Pecas As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Pecas").Value.ToString)

        If Quantidade_Pecas = 0 Then

            get_id_proposta = CONVERT_TO_INTEGER(dtg_Resultados.CurrentRow.Cells("ID_Proposta").Value.ToString)
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()

        End If

    End Sub

    Private Sub tsmi_Nao_Exibir_Codigo_Click(sender As Object, e As EventArgs) Handles tsmi_Nao_Exibir_Codigo.Click
        get_exibir_codigo = "Nao_Exibir"
        get_id_proposta = CONVERT_TO_INTEGER(dtg_Resultados.CurrentRow.Cells("ID_Proposta").Value.ToString)

        Dim Quantidade_Pecas As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Pecas").Value.ToString)
        Dim Quantidade_Servicos As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Servicos").Value.ToString)

        If Quantidade_Pecas > 0 And Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf Quantidade_Pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If
    End Sub

    Private Sub TodosOsCódigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosOsCódigosToolStripMenuItem.Click

        get_exibir_codigo = "Todos"
        get_id_proposta = CONVERT_TO_INTEGER(dtg_Resultados.CurrentRow.Cells("ID_Proposta").Value.ToString)

        Dim Quantidade_Pecas As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Pecas").Value.ToString)
        Dim Quantidade_Servicos As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Servicos").Value.ToString)

        If Quantidade_Pecas > 0 And Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf Quantidade_Pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If

    End Sub

    Private Sub AbreviadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbreviadoToolStripMenuItem.Click
        get_exibir_codigo = "Atual_Abreviado"
        get_id_proposta = CONVERT_TO_INTEGER(dtg_Resultados.CurrentRow.Cells("ID_Proposta").Value.ToString)

        Dim Quantidade_Pecas As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Pecas").Value.ToString)
        Dim Quantidade_Servicos As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Servicos").Value.ToString)

        If Quantidade_Pecas > 0 And Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf Quantidade_Pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If
    End Sub

    Private Sub CompletoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompletoToolStripMenuItem.Click
        get_exibir_codigo = "Atual_Completo"
        get_id_proposta = CONVERT_TO_INTEGER(dtg_Resultados.CurrentRow.Cells("ID_Proposta").Value.ToString)

        Dim Quantidade_Pecas As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Pecas").Value.ToString)
        Dim Quantidade_Servicos As Decimal = CONVERT_TO_DECIMAL(dtg_Resultados.CurrentRow.Cells("Valor_Servicos").Value.ToString)

        If Quantidade_Pecas > 0 And Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf Quantidade_Pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf Quantidade_Servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        get_id_proposta = CONVERT_TO_INTEGER(dtg_Resultados.CurrentRow.Cells("ID_Proposta").Value.ToString)
        Dim form = New Proposta
        form.ShowDialog()
        Executa_Pesquisa()
    End Sub
End Class