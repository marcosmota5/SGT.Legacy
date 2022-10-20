Imports MySql.Data.MySqlClient

Public Class Pesquisa_Proposta_Avancada

    Private Sub Pesquisar_Proposta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Limite_Resultados.Text = "*Limitado a " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)) & " resultado (s)"
        dtg_Filtros.Columns.Add("titulo_coluna", "Parâmetro")
        dtg_Filtros.Columns.Add("texto_filtro", "Filtro")
        'dtg_Filtros.Columns.Add("titulo_texto_parametro_1", "Operador 1")
        'dtg_Filtros.Columns.Add("valor_texto_parametro_1", "Valor 1")
        'dtg_Filtros.Columns.Add("titulo_texto_parametro_2", "Operador 2")
        'dtg_Filtros.Columns.Add("valor_texto_parametro_2", "Valor 2")
        'dtg_Filtros.Columns.Add("coluna_filtro", "Coluna filtro")
        dtg_Filtros.Columns.Add("coluna", "Coluna")
        dtg_Filtros.Columns.Add("tipo", "Tipo")
        dtg_Filtros.Columns.Add("operador1", "Operador 1")
        dtg_Filtros.Columns.Add("parametro1", "Parâmetro 1")
        dtg_Filtros.Columns.Add("valor1", "Valor 1")
        dtg_Filtros.Columns.Add("operador2", "Operador 2")
        dtg_Filtros.Columns.Add("parametro2", "Parâmetro 2")
        dtg_Filtros.Columns.Add("valor2", "Valor 2")
        dtg_Filtros.Columns.Add("e_ou", "E/Ou")
        dtg_Filtros.Columns.Add("and_or", "And/Or")

        dtg_Filtros.Columns("coluna").Visible = False
        dtg_Filtros.Columns("tipo").Visible = False
        dtg_Filtros.Columns("operador1").Visible = False
        dtg_Filtros.Columns("parametro1").Visible = False
        dtg_Filtros.Columns("valor1").Visible = False
        dtg_Filtros.Columns("operador2").Visible = False
        dtg_Filtros.Columns("parametro2").Visible = False
        dtg_Filtros.Columns("valor2").Visible = False
        'dtg_Filtros.Columns("e_ou").Visible = False
        dtg_Filtros.Columns("and_or").Visible = False

        'dtg_Filtros.Columns.Add("condicao_total", "Condicao where")
        'dtg_Filtros.Columns.Add("", "Condicao where")

        Adiciona_Parametros()
        Executa_Pesquisa()
    End Sub

    Private Sub Adiciona_Parametros()

        cbo_Parametro.DisplayMember = "Parametro"
        cbo_Parametro.ValueMember = "Valor"

        Dim tbPar As New DataTable

        tbPar.Columns.Add("Parametro", GetType(String))
        tbPar.Columns.Add("Valor", GetType(String))

        'Adiciona na combobox os itens referentes a tabela de propostas
        tbPar.Rows.Add("Data de solicitação", "prop.data_solicitacao,date")
        tbPar.Rows.Add("Data de inserção", "prop.data_insercao,date")
        tbPar.Rows.Add("Data de envio para o faturamento", "prop.data_envio_faturamento,date")
        tbPar.Rows.Add("Data de faturamento", "prop.data_faturamento,date")
        tbPar.Rows.Add("Nota fiscal", "prop.nota_fiscal,integer")
        tbPar.Rows.Add("Valor do faturamento", "prop.valor_faturamento,decimal")
        tbPar.Rows.Add("Filial", "fili.nome,string")
        tbPar.Rows.Add("Cliente", "clie.nome,string")
        tbPar.Rows.Add("Contato", "cont.nome,string")
        tbPar.Rows.Add("Código da proposta", "prop.codigo_proposta,string")
        tbPar.Rows.Add("Setor do usuário de inserção", "seto_ins.nome,string")
        tbPar.Rows.Add("Usuário de inserção", "prop_usua_ins.nome,string")
        tbPar.Rows.Add("Setor do usuário de edição", "seto_edi.nome,string")
        tbPar.Rows.Add("Usuário de edição", "prop_usua_edi.nome,string")
        tbPar.Rows.Add("Status da proposta", "prop_stat.nome,string")
        tbPar.Rows.Add("Prioridade da proposta", "prio.nome,string")
        tbPar.Rows.Add("Fabricante do equipamento", "fabr.nome,string")
        tbPar.Rows.Add("Tipo do equipamento", "tieq.nome,string")
        tbPar.Rows.Add("Modelo do equipamento", "mode.nome,string")
        tbPar.Rows.Add("Ano do equipamento", "ano.ano,integer")
        tbPar.Rows.Add("Série do equipamento", "seri.nome,string")
        tbPar.Rows.Add("Horímetro", "prop.horimetro,decimal")
        tbPar.Rows.Add("Ordem de serviço", "prop.ordem_servico,integer")
        tbPar.Rows.Add("Data de envio da proposta", "prop.data_envio,date")
        tbPar.Rows.Add("Data de edição da proposta", "prop.data_edicao,date")
        tbPar.Rows.Add("Texto inicial", "prop.texto_padrao,string")
        tbPar.Rows.Add("Observações", "prop.observacoes,string")
        tbPar.Rows.Add("Prazo de entrega", "prop.prazo_entrega,string")
        tbPar.Rows.Add("Condição de pagamento", "prop.condicao_pagamento,string")
        tbPar.Rows.Add("Garantia", "prop.garantia,string")
        tbPar.Rows.Add("Validade", "prop.validade,string")
        tbPar.Rows.Add("Comentários da proposta", "prop.comentarios,string")
        'tbPar.Rows.Add("Valor total da proposta", "prop.valor_total_proposta,decimal")

        'Adiciona na combobox os itens referentes a tabela de itens da proposta
        tbPar.Rows.Add("Data de inserção do item", "itpr.data_insercao,date")
        tbPar.Rows.Add("Setor do usuário de inserção do item", "itpr_seto_ins.nome,string")
        tbPar.Rows.Add("Usuário de inserção do item", "itpr_usua_ins.nome,string")
        tbPar.Rows.Add("Status do item", "itpr_stat.nome,string")
        tbPar.Rows.Add("Status da aprovação do item", "stap.nome,string")
        tbPar.Rows.Add("Justificativa da aprovação do item", "juap.nome,string")
        tbPar.Rows.Add("Conjunto do item", "conj.nome,string")
        tbPar.Rows.Add("Especificação do item", "espe.nome,string")
        tbPar.Rows.Add("Tipo do item", "tiit.nome,string")
        tbPar.Rows.Add("Fornecedor do item", "forn.nome,string")
        tbPar.Rows.Add("Código do item", "itpr.codigo_item,string")
        tbPar.Rows.Add("Descrição do item", "itpr.descricao_item,string")
        tbPar.Rows.Add("Quantidade do item", "itpr.quantidade_item,decimal")
        tbPar.Rows.Add("Preço unitário inicial do item", "itpr.preco_unitario_inicial_item,decimal")
        tbPar.Rows.Add("Percentual de IPI do item", "itpr.percentual_ipi_item,decimal")
        tbPar.Rows.Add("Percentual de ICMS do item", "itpr.percentual_icms_item,decimal")
        tbPar.Rows.Add("NCM do item", "itpr.ncm_item,string")
        tbPar.Rows.Add("MVA do item", "itpr.mva_item,decimal")
        tbPar.Rows.Add("Valor ST do item", "itpr.valor_st_item,decimal")
        tbPar.Rows.Add("Valor total inicial do item", "itpr.valor_total_inicial_item,decimal")
        tbPar.Rows.Add("Prazo inicial do item", "itpr.prazo_inicial_item,string")
        tbPar.Rows.Add("Frete unitário do item", "itpr.frete_unitario_item,decimal")
        tbPar.Rows.Add("Desconto inicial do item", "itpr.desconto_inicial_item,decimal")
        tbPar.Rows.Add("Tipo de substituição tributária do item", "tstr.nome,string")
        tbPar.Rows.Add("Origem do item", "orig.nome,string")
        tbPar.Rows.Add("Preço após desconto inicial do item", "itpr.preco_apos_desconto_inicial_item,decimal")
        tbPar.Rows.Add("Preço com IPI e ICMS do item", "itpr.preco_com_ipi_e_icms_item,decimal")
        tbPar.Rows.Add("Percentual de alíquota externa ICMS do item", "itpr.percentual_aliquota_externa_icms_item,decimal")
        tbPar.Rows.Add("Valor ICMS crédito do item", "itpr.valor_icms_credito_item,decimal")
        tbPar.Rows.Add("Percentual do MVA do item", "itpr.percentual_mva_item,decimal")
        tbPar.Rows.Add("Valor do MVA do item", "itpr.valor_mva_item,decimal")
        tbPar.Rows.Add("Preço com MVA do item", "itpr.preco_com_mva_item,decimal")
        tbPar.Rows.Add("Percentual de alíquota interna ICMS do item", "itpr.percentual_aliquota_interna_icms_item,decimal")
        tbPar.Rows.Add("Valor do ICMS débito do item", "itpr.valor_icms_debito_item,decimal")
        tbPar.Rows.Add("Saldo do ICMS do item", "itpr.saldo_icms_item,decimal")
        tbPar.Rows.Add("Preço unitário para revendedor do item", "itpr.preco_unitario_para_revendedor_item,decimal")
        tbPar.Rows.Add("Impostos federais do item", "itpr.impostos_federais_item,decimal")
        tbPar.Rows.Add("Rateio despesa fixa do item", "itpr.rateio_despesa_fixa_item,decimal")
        tbPar.Rows.Add("Percentual de lucro necessário do item", "itpr.percentual_lucro_necessario_item,decimal")
        tbPar.Rows.Add("Preço da lista de venda do item", "itpr.preco_lista_venda_item,decimal")
        tbPar.Rows.Add("Desconto final do item", "itpr.desconto_final_item,decimal")
        tbPar.Rows.Add("Preço unitário final do item", "itpr.preco_unitario_final_item,decimal")
        tbPar.Rows.Add("Preço total final do item", "itpr.preco_total_final_item,decimal")
        tbPar.Rows.Add("Quantidade em estoque (código completo) do item", "itpr.quantidade_estoque_codigo_completo_item,decimal")
        tbPar.Rows.Add("Quantidade em estoque (código abreviado) do item", "itpr.quantidade_estoque_codigo_abreviado_item,decimal")
        tbPar.Rows.Add("Informação do estoque (código completo) do item", "itpr.informacao_estoque_codigo_completo_item,string")
        tbPar.Rows.Add("Informação em estoque (código abreviado) do item", "itpr.informacao_estoque_codigo_abreviado_item,string")
        tbPar.Rows.Add("Prazo final do item", "itpr.prazo_final_item,string")
        tbPar.Rows.Add("Comentários do item", "itpr.comentarios_item,string")
        tbPar.Rows.Add("Data de aprovação do item", "itpr.data_aprovacao_item,date")
        tbPar.Rows.Add("Data de edição do item", "itpr.data_edicao_item,date")

        cbo_Parametro.DataSource = tbPar

        cbo_Parametro_Texto.DisplayMember = "Texto_Parametro"
        cbo_Parametro_Texto.ValueMember = "Valor_Parametro"

        Dim tbParTxt As New DataTable

        tbParTxt.Columns.Add("Texto_Parametro", GetType(String))
        tbParTxt.Columns.Add("Valor_Parametro", GetType(String))

        'Adiciona na combobox os itens referentes a tabela de propostas
        tbParTxt.Rows.Add("É igual a", "igual_a")
        tbParTxt.Rows.Add("É diferente de", "diferente_de")
        tbParTxt.Rows.Add("Começa com", "comeca_com")
        tbParTxt.Rows.Add("Não começa com", "nao_comeca_com")
        tbParTxt.Rows.Add("Termina com", "termina_com")
        tbParTxt.Rows.Add("Não termina com", "nao_termina_com")
        tbParTxt.Rows.Add("Contém", "contem")
        tbParTxt.Rows.Add("Não contém", "nao_contem")

        cbo_Parametro_Texto.DataSource = tbParTxt

        cbo_E_Ou.DisplayMember = "Texto_E_Ou"
        cbo_E_Ou.ValueMember = "Valor_E_Ou"

        Dim tbPar_E_Ou As New DataTable

        tbPar_E_Ou.Columns.Add("Texto_E_Ou", GetType(String))
        tbPar_E_Ou.Columns.Add("Valor_E_Ou", GetType(String))

        'Adiciona na combobox os itens referentes a tabela de propostas
        tbPar_E_Ou.Rows.Add("E", "AND")
        tbPar_E_Ou.Rows.Add("Ou", "OR")

        cbo_E_Ou.DataSource = tbPar_E_Ou

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

        For Each dtgRow As DataGridViewRow In dtg_Filtros.Rows
            texto_and_or = " " & dtgRow.Cells("and_or").Value & " "
            If sCondicao = "" Then
                sCondicao = dtgRow.Cells("coluna").Value & " " & dtgRow.Cells("operador1").Value & " " & dtgRow.Cells("parametro1").Value & cont_parametro
                If dtgRow.Cells("operador2").Value <> "" Then
                    sCondicao = sCondicao & " AND " & dtgRow.Cells("coluna").Value & " " & dtgRow.Cells("operador2").Value & " " & dtgRow.Cells("parametro2").Value & cont_parametro
                End If
            Else
                sCondicao = sCondicao & texto_and_or & dtgRow.Cells("coluna").Value & " " & dtgRow.Cells("operador1").Value & " " & dtgRow.Cells("parametro1").Value & cont_parametro
                If dtgRow.Cells("operador2").Value <> "" Then
                    sCondicao = sCondicao & " AND " & dtgRow.Cells("coluna").Value & " " & dtgRow.Cells("operador2").Value & " " & dtgRow.Cells("parametro2").Value & cont_parametro
                End If
            End If
            cont_parametro = cont_parametro + 1
        Next

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

            cmd = New MySqlCommand("SELECT prop_usua_ins.nome AS Nome_Usuario, itpr.id_item_proposta AS ID_Item_Proposta, prop.id_proposta AS ID_Proposta, prop.codigo_proposta AS Codigo_Proposta, 
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
                                            LEFT JOIN tb_usuarios AS prop_usua_edi ON prop.id_usuario_edicao=prop_usua_edi.id_usuario
                                            LEFT JOIN tb_setores AS seto_ins ON prop_usua_ins.id_setor=seto_ins.id_setor
                                            LEFT JOIN tb_setores AS seto_edi ON prop_usua_edi.id_setor=seto_edi.id_setor
                                            LEFT JOIN tb_setores AS itpr_seto_ins ON itpr_usua_ins.id_setor=itpr_seto_ins.id_setor
                                            LEFT JOIN tb_status AS itpr_stat ON itpr.id_status=itpr_stat.id_status
                                            LEFT JOIN tb_status AS prop_stat ON prop.id_status=prop_stat.id_status
                                            LEFT JOIN tb_status_aprovacao AS stap ON itpr.id_status_aprovacao=stap.id_status_aprovacao
                                            LEFT JOIN tb_justificativas_aprovacao AS juap ON itpr.id_justificativa_aprovacao=juap.id_justificativa_aprovacao
                                            LEFT JOIN tb_conjuntos AS conj ON itpr.id_conjunto=conj.id_conjunto
                                            LEFT JOIN tb_especificacoes AS espe ON itpr.id_especificacao=espe.id_especificacao
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
            If sCondicao <> "" Then
                cont_parametro = 1
                For Each dtgRow As DataGridViewRow In dtg_Filtros.Rows
                    '  MessageBox.Show(Replace(Replace(Replace(Replace(dtgRow.Cells("parametro1").Value, "%", ""), "+", ""), " ", ""), "'", "") & vbNewLine & dtgRow.Cells("valor1").Value)
                    cmd.Parameters.AddWithValue(Replace(Replace(Replace(Replace(dtgRow.Cells("parametro1").Value, "%", ""), "+", ""), " ", ""), "'", "") & cont_parametro, dtgRow.Cells("valor1").Value)
                    If dtgRow.Cells("parametro2").Value <> "" Then
                        cmd.Parameters.AddWithValue(Replace(Replace(Replace(Replace(dtgRow.Cells("parametro2").Value, "%", ""), "+", ""), " ", ""), "'", "") & cont_parametro, dtgRow.Cells("valor2").Value)
                    End If
                    cont_parametro = cont_parametro + 1
                Next
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

            dtg_Resultados.Columns("ID_Item_Proposta").Visible = False
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

    Private Sub cbo_Parametro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Parametro.SelectedIndexChanged

        Dim arrPar() As String
        arrPar = Split(cbo_Parametro.SelectedValue, ",")
        Select Case arrPar(1)
            Case "date"
                lbl_Data_De.Visible = True
                dtp_Data_De.Visible = True
                lbl_Data_Ate.Visible = True
                dtp_Data_Ate.Visible = True

                lbl_Valor_De.Visible = False
                nud_Valor_De.Visible = False
                lbl_Valor_Ate.Visible = False
                nud_Valor_Ate.Visible = False

                lbl_Parametro_Texto.Visible = False
                cbo_Parametro_Texto.Visible = False
                lbl_Texto_Pesquisa.Visible = False
                cbo_Texto_Pesquisa.Visible = False
                cbo_E_Ou.Left = dtp_Data_Ate.Width + dtp_Data_Ate.Left + 6
                btn_Adicionar.Left = cbo_E_Ou.Width + cbo_E_Ou.Left + 6

            Case "integer"
                lbl_Data_De.Visible = False
                dtp_Data_De.Visible = False
                lbl_Data_Ate.Visible = False
                dtp_Data_Ate.Visible = False

                lbl_Valor_De.Visible = True
                nud_Valor_De.Visible = True
                lbl_Valor_Ate.Visible = True
                nud_Valor_Ate.Visible = True

                lbl_Parametro_Texto.Visible = False
                cbo_Parametro_Texto.Visible = False
                lbl_Texto_Pesquisa.Visible = False
                cbo_Texto_Pesquisa.Visible = False

                cbo_E_Ou.Left = nud_Valor_Ate.Width + nud_Valor_Ate.Left + 6
                btn_Adicionar.Left = cbo_E_Ou.Width + cbo_E_Ou.Left + 6

                nud_Valor_De.DecimalPlaces = 0
                nud_Valor_Ate.DecimalPlaces = 0

            Case "decimal"
                lbl_Data_De.Visible = False
                dtp_Data_De.Visible = False
                lbl_Data_Ate.Visible = False
                dtp_Data_Ate.Visible = False

                lbl_Valor_De.Visible = True
                nud_Valor_De.Visible = True
                lbl_Valor_Ate.Visible = True
                nud_Valor_Ate.Visible = True

                lbl_Parametro_Texto.Visible = False
                cbo_Parametro_Texto.Visible = False
                lbl_Texto_Pesquisa.Visible = False
                cbo_Texto_Pesquisa.Visible = False

                cbo_E_Ou.Left = nud_Valor_Ate.Width + nud_Valor_Ate.Left + 6
                btn_Adicionar.Left = cbo_E_Ou.Width + cbo_E_Ou.Left + 6

                nud_Valor_De.DecimalPlaces = 2
                nud_Valor_Ate.DecimalPlaces = 2

            Case "string"
                lbl_Data_De.Visible = False
                dtp_Data_De.Visible = False
                lbl_Data_Ate.Visible = False
                dtp_Data_Ate.Visible = False

                lbl_Valor_De.Visible = False
                nud_Valor_De.Visible = False
                lbl_Valor_Ate.Visible = False
                nud_Valor_Ate.Visible = False

                lbl_Parametro_Texto.Visible = True
                cbo_Parametro_Texto.Visible = True
                lbl_Texto_Pesquisa.Visible = True
                cbo_Texto_Pesquisa.Visible = True

                cbo_E_Ou.Left = cbo_Texto_Pesquisa.Width + cbo_Texto_Pesquisa.Left + 6
                btn_Adicionar.Left = cbo_E_Ou.Width + cbo_E_Ou.Left + 6

                Call Preencher_ComboBox(cbo_Texto_Pesquisa, cbo_Parametro.SelectedValue)

        End Select

    End Sub
    Public Sub Preencher_ComboBox(cbo As ComboBox, coluna_select As String)

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter
        Dim vcol() As String = Split(coluna_select, ",")
        Dim coluna_real As String = vcol(0)

        cbo.DataSource = Nothing

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT " & coluna_real & " AS Coluna_Usada FROM tb_itens_propostas AS itpr
                                            LEFT JOIN tb_propostas AS prop ON itpr.id_proposta=prop.id_proposta
                                            LEFT JOIN tb_usuarios AS itpr_usua_ins ON itpr.id_usuario=itpr_usua_ins.id_usuario
                                            LEFT JOIN tb_usuarios AS prop_usua_ins ON prop.id_usuario_insercao=prop_usua_ins.id_usuario
                                            LEFT JOIN tb_usuarios AS prop_usua_edi ON prop.id_usuario_edicao=prop_usua_edi.id_usuario
                                            LEFT JOIN tb_setores AS seto_ins ON prop_usua_ins.id_setor=seto_ins.id_setor
                                            LEFT JOIN tb_setores AS seto_edi ON prop_usua_edi.id_setor=seto_edi.id_setor
                                            LEFT JOIN tb_setores AS itpr_seto_ins ON itpr_usua_ins.id_setor=itpr_seto_ins.id_setor
                                            LEFT JOIN tb_status AS itpr_stat ON itpr.id_status=itpr_stat.id_status
                                            LEFT JOIN tb_status AS prop_stat ON prop.id_status=prop_stat.id_status
                                            LEFT JOIN tb_status_aprovacao AS stap ON itpr.id_status_aprovacao=stap.id_status_aprovacao
                                            LEFT JOIN tb_justificativas_aprovacao AS juap ON itpr.id_justificativa_aprovacao=juap.id_justificativa_aprovacao
                                            LEFT JOIN tb_conjuntos AS conj ON itpr.id_conjunto=conj.id_conjunto
                                            LEFT JOIN tb_especificacoes AS espe ON itpr.id_especificacao=espe.id_especificacao
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
                                            LEFT JOIN tb_series AS seri ON prop.id_serie=seri.id_serie 
                                            GROUP BY " & coluna_real & " ORDER BY " & coluna_real & " LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexao)

            adapter.Fill(ds, "tb_itens_propostas")

            cbo.DisplayMember = "Coluna_Usada"
            cbo.ValueMember = "Coluna_Usada"
            cbo.DataSource = ds.Tables("tb_itens_propostas")
            cbo.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub btn_Adicionar_Click(sender As Object, e As EventArgs) Handles btn_Adicionar.Click

        'dtg_Filtros.Columns.Add("titulo_coluna", "Parâmetro")
        'dtg_Filtros.Columns.Add("nome_coluna", "Nome da Coluna na Database")
        'dtg_Filtros.Columns.Add("titulo_texto_parametro_1", "Operador 1")
        'dtg_Filtros.Columns.Add("valor_texto_parametro_1", "Valor 1")
        'dtg_Filtros.Columns.Add("titulo_texto_parametro_2", "Operador 2")
        'dtg_Filtros.Columns.Add("valor_texto_parametro_2", "Valor 2")
        'dtg_Filtros.Columns.Add("condicao_total", "Condicao where")

        Dim Texto_E_Ou As String
        Dim arrPar() As String
        Dim arrSeparaColuna() As String

        arrPar = Split(cbo_Parametro.SelectedValue, ",")

        Dim nome_coluna As String = arrPar(LBound(arrPar))
        Dim tipo_coluna As String = arrPar(UBound(arrPar))

        arrSeparaColuna = Split(nome_coluna, ".")

        Dim nome_parametro As String = "@" & arrSeparaColuna(UBound(arrSeparaColuna))

        Select Case tipo_coluna
            Case "date"

                If dtp_Data_De.Checked = True And dtp_Data_Ate.Checked = True Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "De: " & Format(dtp_Data_De.Value, "dd/MM/yyyy") & vbNewLine & "Até " & Format(dtp_Data_Ate.Value, "dd/MM/yyyy"),
                                            "DATE(" & nome_coluna & ")", tipo_coluna,
                                            ">=", nome_parametro & "_de", CONVERT_TO_STRING(Format(dtp_Data_De.Value, "yyyy/MM/dd")),
                                            "<=", nome_parametro & "_ate", CONVERT_TO_STRING(Format(dtp_Data_Ate.Value, "yyyy/MM/dd")), cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

                If dtp_Data_De.Checked = True And dtp_Data_Ate.Checked = False Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Após " & Format(dtp_Data_De.Value, "dd/MM/yyyy"),
                                            "DATE(" & nome_coluna & ")", tipo_coluna,
                                            ">=", nome_parametro & "_de", CONVERT_TO_STRING(Format(dtp_Data_De.Value, "yyyy/MM/dd")),
                                            "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

                If dtp_Data_De.Checked = False And dtp_Data_Ate.Checked = True Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Antes de " & Format(dtp_Data_Ate.Value, "dd/MM/yyyy"),
                                            "DATE(" & nome_coluna & ")", tipo_coluna,
                                            "<=", nome_parametro & "_ate", CONVERT_TO_STRING(Format(dtp_Data_Ate.Value, "yyyy/MM/dd")),
                                            "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

            Case "integer"

                If CONVERT_TO_INTEGER(nud_Valor_De.Value) > 0 And CONVERT_TO_INTEGER(nud_Valor_Ate.Value) > 0 Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Maior ou igual a " & CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_De.Value)) & vbNewLine & "Menor ou igual a " & CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_Ate.Value)),
                                            nome_coluna, tipo_coluna,
                                            ">=", nome_parametro & "_de", CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_De.Value)),
                                            "<=", nome_parametro & "_ate", CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_Ate.Value)), cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

                If CONVERT_TO_INTEGER(nud_Valor_De.Value) > 0 And CONVERT_TO_INTEGER(nud_Valor_Ate.Value) = 0 Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Maior ou igual a " & CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_De.Value)),
                                            nome_coluna, tipo_coluna,
                                            ">=", nome_parametro & "_de", CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_De.Value)),
                                            "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

                If CONVERT_TO_INTEGER(nud_Valor_De.Value) = 0 And CONVERT_TO_INTEGER(nud_Valor_Ate.Value) > 0 Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Menor ou igual a " & CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_Ate.Value)),
                                            nome_coluna, tipo_coluna,
                                            "<=", nome_parametro & "_ate", CONVERT_TO_STRING(CONVERT_TO_INTEGER(nud_Valor_Ate.Value)),
                                            "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If


            Case "decimal"

                If CONVERT_TO_DECIMAL(nud_Valor_De.Value) > 0 And CONVERT_TO_DECIMAL(nud_Valor_Ate.Value) > 0 Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Maior ou igual a " & CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_De.Value)) & vbNewLine & "Menor ou igual a " & CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_Ate.Value)),
                                            nome_coluna, tipo_coluna,
                                            ">=", nome_parametro & "_de", CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_De.Value)),
                                            "<=", nome_parametro & "_ate", CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_Ate.Value)), cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

                If CONVERT_TO_DECIMAL(nud_Valor_De.Value) > 0 And CONVERT_TO_DECIMAL(nud_Valor_Ate.Value) = 0 Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Maior ou igual a " & CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_De.Value)),
                                            nome_coluna, tipo_coluna,
                                            ">=", nome_parametro & "_de", CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_De.Value)),
                                            "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

                If CONVERT_TO_DECIMAL(nud_Valor_De.Value) = 0 And CONVERT_TO_DECIMAL(nud_Valor_Ate.Value) > 0 Then
                    dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Menor ou igual a " & CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_Ate.Value)),
                                            nome_coluna, tipo_coluna,
                                            "<=", nome_parametro & "_ate", CONVERT_TO_STRING(CONVERT_TO_DECIMAL(nud_Valor_Ate.Value)),
                                            "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End If

            Case "string"

                Select Case cbo_Parametro_Texto.SelectedValue
                    Case "igual_a"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Igual a '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "=", nome_parametro, CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text),
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "diferente_de"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Diferente de '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        "NOT " & nome_coluna, tipo_coluna,
                        "=", nome_parametro, CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text),
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "comeca_com"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Começa com '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "LIKE", nome_parametro, CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "%",
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "nao_comeca_com"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Não começa com '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "NOT LIKE", nome_parametro, CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "%",
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "termina_com"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Termina com '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "LIKE", nome_parametro, "%" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text),
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "nao_termina_com"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Não termina com '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "NOT LIKE", nome_parametro, "%" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text),
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "contem"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Contém '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "LIKE", nome_parametro, "%" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "%",
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                    Case "nao_contem"
                        dtg_Filtros.Rows.Add(cbo_Parametro.Text, "Não contém '" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "'",
                        nome_coluna, tipo_coluna,
                        "NOT LIKE", nome_parametro, "%" & CONVERT_TO_STRING(cbo_Texto_Pesquisa.Text) & "%",
                        "", "", "", cbo_E_Ou.Text, cbo_E_Ou.SelectedValue)
                End Select

        End Select
    End Sub

    Function TEXTO_EXISTE_NA_COLUNA(dDataGrid As DataGridView, Nome_Coluna As String, Texto_Procurado As String) As Boolean
        For Each dtgRow As DataGridViewRow In dDataGrid.Rows
            If CONVERT_TO_STRING(dtgRow.Cells(Nome_Coluna).Value) = CONVERT_TO_STRING(Texto_Procurado) Then
                Return True
            End If
        Next

        Return False
    End Function
    Private Sub dtg_Resultados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Resultados.CellDoubleClick
        Dim dtg_row As DataGridViewRow = dtg_Resultados.Rows(e.RowIndex)
        get_id_proposta = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_row.Cells("ID_Proposta").Value))
        Dim form = New Proposta
        form.ShowDialog()
        Executa_Pesquisa()
    End Sub

    Private Sub tsmi_Subir_Ordem_Click(sender As Object, e As EventArgs) Handles tsmi_Subir_Ordem.Click
        If dtg_Filtros.RowCount > 0 Then

            If dtg_Filtros.SelectedRows.Count > 0 Then
                Dim rowCount As Integer = dtg_Filtros.Rows.Count
                Dim index As Integer = dtg_Filtros.SelectedCells(0).OwningRow.Index

                If index = 0 Then
                    Return
                End If

                Dim rows As DataGridViewRowCollection = dtg_Filtros.Rows
                Dim prevRow As DataGridViewRow = rows(index - 1)
                rows.Remove(prevRow)
                prevRow.Frozen = False
                rows.Insert(index, prevRow)
                dtg_Filtros.ClearSelection()
                dtg_Filtros.Rows(index - 1).Selected = True
            End If
        End If
    End Sub

    Private Sub tsmi_Descer_Ordem_Click(sender As Object, e As EventArgs) Handles tsmi_Descer_Ordem.Click
        If dtg_Filtros.RowCount > 0 Then

            If dtg_Filtros.SelectedRows.Count > 0 Then
                Dim rowCount As Integer = dtg_Filtros.Rows.Count
                Dim index As Integer = dtg_Filtros.SelectedCells(0).OwningRow.Index

                If index = (rowCount - 1) Then
                    Return
                End If

                Dim rows As DataGridViewRowCollection = dtg_Filtros.Rows
                Dim nextRow As DataGridViewRow = rows(index + 1)
                rows.Remove(nextRow)
                nextRow.Frozen = False
                rows.Insert(index, nextRow)
                dtg_Filtros.ClearSelection()
                dtg_Filtros.Rows(index + 1).Selected = True
            End If
        End If
    End Sub

    Private Sub tsmi_Remover_Filtro_Click(sender As Object, e As EventArgs) Handles tsmi_Remover_Filtro.Click
        dtg_Filtros.Rows.Remove(dtg_Filtros.SelectedRows(0))
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


