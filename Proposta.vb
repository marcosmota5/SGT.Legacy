Imports MySql.Data.MySqlClient

Public Class Proposta

    Private Serie_Existe As Boolean = False
    Private Familia_Existe As Boolean = False

    Private Sub Proposta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If get_id_perfil = 1 Then
            mnui_Deletar.Visible = True
        Else
            mnui_Deletar.Visible = False
        End If

        txt_atualizou_prazo.Text = 0

        Preencher_ComboBox(cbo_Prioridade, "tb_prioridades", "id_prioridade", "nome", condicoes:="id_status=1", ordenar_por:="id_prioridade")
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Cliente, "tb_clientes", "id_cliente", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

        If get_id_proposta = 0 Then

            cbo_Cliente.SelectedValue = -1
            cbo_Serie.SelectedValue = -1
            cbo_Modelo.SelectedValue = -1

            cbo_Pais.SelectedValue = get_id_pais
            cbo_Estado.SelectedValue = get_id_estado
            cbo_Cidade.SelectedValue = get_id_cidade

            tssl_Envio.Text = "Não gerada"
            tssl_Aprovacao.Text = ""
            tssl_Origem.Text = ""
            tssl_Revisao.Text = ""

            tssl_Envio.Tag = ""
            tssl_Aprovacao.Tag = ""
            tssl_Origem.Tag = ""
            tssl_Revisao.Tag = ""

            mnui_Salvar.Enabled = True
            mnui_Visualizar.Enabled = False
            mnui_Editar.Enabled = False
            mnui_Revisar.Enabled = False
            mnui_Deletar.Enabled = False

            ' Edicao_Campos(True)
            'mnu_Itens.Enabled = False

            mnui_Adicionar_Item.Enabled = False
            mnui_Editar_Item.Enabled = False
            mnui_Remover_Item.Enabled = False
            mnui_Importar.Enabled = False
            mnui_Exportar.Enabled = True
            mnui_Prazos.Enabled = False
            mnui_Frete.Enabled = False
            tsmi_Desconto.Enabled = False
            mnui_Colunas.Enabled = True
            tsmi_Subir_Ordem.Enabled = False
            tsmi_Abaixar_Ordem.Enabled = False

        Else

            mnui_Salvar.Enabled = False
            mnui_Visualizar.Enabled = True
            mnui_Editar.Enabled = True
            mnui_Revisar.Enabled = True
            mnui_Deletar.Enabled = True

            Edicao_Campos(False)

        End If

        Carregar_Proposta(get_id_proposta)

        Dim dtbCol As DataColumn = dtbItens.Columns.Add("texto_estoque_encontrado")
        dtg_Itens.Columns("texto_estoque_encontrado").Visible = False

        Formatar_Datagrid()

        Colunas_Visiveis("todas", False)

        Atualiza_Statusbar()

        'Carrega_Dados_Serie()

        If get_id_proposta <> 0 Then
            Edicao_Campos(False)
        End If

    End Sub

    Private Sub Retorna_Codigo_Proposta()

        If get_id_proposta = 0 Then

            Dim sqlcmd As MySqlCommand

            Try
                Abrir_Conexao()
                sqlcmd = New MySqlCommand("sp_contagem_propostas_iniciais", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_cliente", CONVERT_TO_INTEGER(cbo_Cliente.SelectedValue))
                sqlcmd.Parameters.AddWithValue("p_data_insercao", Now)
                sqlcmd.Parameters.Add("p_contagem", MySqlDbType.Int64).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim Contagem_Proposta As Long = CONVERT_TO_LONG(sqlcmd.Parameters("p_contagem").Value)

                txt_Codigo_Proposta.Text = Format(Now, "ddMMyyyy") & CONVERT_TO_LETTER(Contagem_Proposta + 1)

            Catch ex As Exception
                MessageBox.Show("Erro ao retornar o código da proposta. Detalhes: " + ex.Message + ex.StackTrace)
            Finally
                Fechar_Conexao()
            End Try

        End If

    End Sub
    Function REMOVE_REV_PROPOSTA(codigo_proposta As String) As String

        Dim vcod_prop() As String = Split(codigo_proposta, "_")
        Return vcod_prop(0)

    End Function
    Private Sub Retorna_Codigo_Proposta_Revisada()

        Dim cod_sem_rev As String = REMOVE_REV_PROPOSTA(txt_Codigo_Proposta.Text.ToString)
        Dim cod_com_rev As String = cod_sem_rev & "_REV"

        If get_id_proposta > 0 Then

            Dim sqlcmd As MySqlCommand

            Try

                Abrir_Conexao()
                sqlcmd = New MySqlCommand("SELECT codigo_proposta FROM tb_propostas WHERE (id_cliente = " & CONVERT_TO_INTEGER(cbo_Cliente.SelectedValue) & " 
AND codigo_proposta = '" & Replace(cod_sem_rev, "'", "") & "') OR (id_cliente = " & CONVERT_TO_INTEGER(cbo_Cliente.SelectedValue) & " AND codigo_proposta LIKE '" & Replace(cod_com_rev, "'", "") & "%') ORDER BY id_proposta DESC LIMIT 1", strConexao)
                sqlcmd.CommandType = CommandType.Text
                Dim cmdreader As MySqlDataReader = sqlcmd.ExecuteReader()
                Dim codigo_retornado As String = cod_sem_rev

                While cmdreader.Read()
                    codigo_retornado = cmdreader.GetString(0)
                End While

                cmdreader.Close()
                cmdreader = Nothing

                If Strings.InStr(codigo_retornado, "REV") <= 0 Then
                    txt_Codigo_Proposta.Text = REMOVE_REV_PROPOSTA(txt_Codigo_Proposta.Text.ToString) & "_REV1"
                Else
                    Dim vcod_prop() As String = Split(codigo_retornado, "_REV")
                    txt_Codigo_Proposta.Text = REMOVE_REV_PROPOSTA(txt_Codigo_Proposta.Text.ToString) & "_REV" & CONVERT_TO_INTEGER(vcod_prop(UBound(vcod_prop))) + 1
                End If


            Catch ex As Exception
                MessageBox.Show("Erro ao retornar o código da proposta. Detalhes: " + ex.Message + ex.StackTrace)
            Finally
                Fechar_Conexao()
            End Try

        End If

    End Sub

    Private Sub Edicao_Campos(Habilita_Edicao As Boolean)

        For Each tbp As TabPage In tbc_Proposta.TabPages
            For Each ctl_holder As Control In tbp.Controls
                If TypeName(ctl_holder) = "GroupBox" Then
                    Dim grp As GroupBox = ctl_holder
                    For Each ctl As Control In grp.Controls
                        Select Case TypeName(ctl)
                            Case "DateTimePicker"
                                Dim dtp_Origem As DateTimePicker = ctl
                                If CntrlExistsIn("txt_ReadOnly" + dtp_Origem.Name, grp) Then
                                    If dtp_Origem.Checked = True Then
                                        grp.Controls("txt_ReadOnly" + dtp_Origem.Name).Text = dtp_Origem.Value
                                    Else
                                        grp.Controls("txt_ReadOnly" + dtp_Origem.Name).Text = ""
                                    End If
                                    If Habilita_Edicao = True Then
                                        grp.Controls("txt_ReadOnly" + dtp_Origem.Name).Visible = False
                                        dtp_Origem.Visible = True
                                    Else
                                        grp.Controls("txt_ReadOnly" + dtp_Origem.Name).Visible = True
                                        dtp_Origem.Visible = False
                                    End If
                                    Continue For
                                End If
                                Dim txt_Espelho As New TextBox
                                With txt_Espelho
                                    .Name = "txt_ReadOnly" + dtp_Origem.Name
                                    .Left = dtp_Origem.Left
                                    .Top = dtp_Origem.Top
                                    .Height = dtp_Origem.Height
                                    .Width = dtp_Origem.Width
                                    If dtp_Origem.Checked = True Then
                                        .Text = dtp_Origem.Value
                                    Else
                                        .Text = ""
                                    End If
                                    .Font = New Font(.Font, FontStyle.Bold = False)
                                    .ReadOnly = True
                                    .BackColor = SystemColors.Control
                                    If Habilita_Edicao = True Then
                                        .Visible = False
                                        dtp_Origem.Visible = True
                                    Else
                                        .Visible = True
                                        dtp_Origem.Visible = False
                                    End If
                                End With
                                grp.Controls.Add(txt_Espelho)
                            Case "NumericUpDown"
                                Dim nud_Origem As NumericUpDown = ctl
                                If CntrlExistsIn("txt_ReadOnly" + nud_Origem.Name, grp) Then
                                    If nud_Origem.Enabled = True Then
                                        grp.Controls("txt_ReadOnly" + nud_Origem.Name).Text = nud_Origem.Value
                                    Else
                                        grp.Controls("txt_ReadOnly" + nud_Origem.Name).Text = ""
                                    End If
                                    If Habilita_Edicao = True Then
                                        grp.Controls("txt_ReadOnly" + nud_Origem.Name).Visible = False
                                        nud_Origem.Visible = True
                                    Else
                                        grp.Controls("txt_ReadOnly" + nud_Origem.Name).Visible = True
                                        nud_Origem.Visible = False
                                    End If
                                    Continue For
                                End If
                                Dim txt_Espelho As New TextBox
                                With txt_Espelho
                                    .Name = "txt_ReadOnly" + nud_Origem.Name
                                    .Left = nud_Origem.Left
                                    .Top = nud_Origem.Top
                                    .Height = nud_Origem.Height
                                    .Width = nud_Origem.Width
                                    If nud_Origem.Enabled = True Then
                                        .Text = nud_Origem.Value
                                    Else
                                        .Text = ""
                                    End If
                                    .Font = New Font(.Font, FontStyle.Bold = False)
                                    .ReadOnly = True
                                    .BackColor = SystemColors.Control
                                    If Habilita_Edicao = True Then
                                        .Visible = False
                                        nud_Origem.Visible = True
                                    Else
                                        .Visible = True
                                        nud_Origem.Visible = False
                                    End If
                                End With
                                grp.Controls.Add(txt_Espelho)
                            Case "ComboBox"
                                Dim cbo_Origem As ComboBox = ctl
                                If CntrlExistsIn("txt_ReadOnly" + cbo_Origem.Name, grp) Then
                                    grp.Controls("txt_ReadOnly" + cbo_Origem.Name).Text = cbo_Origem.Text
                                    If Habilita_Edicao = True Then
                                        grp.Controls("txt_ReadOnly" + cbo_Origem.Name).Visible = False
                                        cbo_Origem.Visible = True
                                    Else
                                        grp.Controls("txt_ReadOnly" + cbo_Origem.Name).Visible = True
                                        cbo_Origem.Visible = False
                                    End If
                                    Continue For
                                End If
                                Dim txt_Espelho As New TextBox
                                With txt_Espelho
                                    .Name = "txt_ReadOnly" + cbo_Origem.Name
                                    .Left = cbo_Origem.Left
                                    .Top = cbo_Origem.Top
                                    .Height = cbo_Origem.Height
                                    .Width = cbo_Origem.Width
                                    .Text = cbo_Origem.Text
                                    .Font = New Font(.Font, FontStyle.Bold = False)
                                    .ReadOnly = True
                                    .BackColor = SystemColors.Control
                                    If Habilita_Edicao = True Then
                                        .Visible = False
                                        cbo_Origem.Visible = True
                                    Else
                                        .Visible = True
                                        cbo_Origem.Visible = False
                                    End If
                                End With
                                grp.Controls.Add(txt_Espelho)
                            Case "MaskedTextBox"
                                Dim mkt_Origem As MaskedTextBox = ctl
                                If CntrlExistsIn("txt_ReadOnly" + mkt_Origem.Name, grp) Then
                                    grp.Controls("txt_ReadOnly" + mkt_Origem.Name).Text = mkt_Origem.Text
                                    If Habilita_Edicao = True Then
                                        grp.Controls("txt_ReadOnly" + mkt_Origem.Name).Visible = False
                                        mkt_Origem.Visible = True
                                    Else
                                        grp.Controls("txt_ReadOnly" + mkt_Origem.Name).Visible = True
                                        mkt_Origem.Visible = False
                                    End If
                                    Continue For
                                End If
                                Dim txt_Espelho As New TextBox
                                With txt_Espelho
                                    .Name = "txt_ReadOnly" + mkt_Origem.Name
                                    .Left = mkt_Origem.Left
                                    .Top = mkt_Origem.Top
                                    .Height = mkt_Origem.Height
                                    .Width = mkt_Origem.Width
                                    .Text = mkt_Origem.Text
                                    .Font = New Font(.Font, FontStyle.Bold = False)
                                    .ReadOnly = True
                                    .BackColor = SystemColors.Control
                                    If Habilita_Edicao = True Then
                                        .Visible = False
                                        mkt_Origem.Visible = True
                                    Else
                                        .Visible = True
                                        mkt_Origem.Visible = False
                                    End If
                                End With
                                grp.Controls.Add(txt_Espelho)
                            Case "TextBox"
                                Dim txt_Origem As TextBox = ctl
                                If CntrlExistsIn("txt_ReadOnly" + txt_Origem.Name, grp) Then
                                    grp.Controls("txt_ReadOnly" + txt_Origem.Name).Text = txt_Origem.Text
                                    If Habilita_Edicao = True Then
                                        grp.Controls("txt_ReadOnly" + txt_Origem.Name).Visible = False
                                        txt_Origem.Visible = True
                                    Else
                                        grp.Controls("txt_ReadOnly" + txt_Origem.Name).Visible = True
                                        txt_Origem.Visible = False
                                    End If
                                    Continue For
                                End If
                                Dim txt_Espelho As New TextBox
                                With txt_Espelho
                                    .Name = "txt_ReadOnly" + txt_Origem.Name
                                    .Multiline = txt_Origem.Multiline
                                    .Left = txt_Origem.Left
                                    .Top = txt_Origem.Top
                                    .Height = txt_Origem.Height
                                    .Width = txt_Origem.Width
                                    .Text = txt_Origem.Text
                                    .Font = New Font(.Font, FontStyle.Bold = False)
                                    .ReadOnly = True
                                    .BackColor = SystemColors.Control
                                    If Habilita_Edicao = True Then
                                        .Visible = False
                                        txt_Origem.Visible = True
                                    Else
                                        .Visible = True
                                        txt_Origem.Visible = False
                                    End If
                                End With
                                grp.Controls.Add(txt_Espelho)
                                'Case "MenuStrip"
                                '   If Habilita_Edicao = True Then
                                '  ctl.Enabled = True
                                ' Else
                                'ctl.Enabled = False
                                ' End If
                        End Select
                    Next
                End If
            Next
        Next

        If Habilita_Edicao = True Then
            dtg_Itens.BackgroundColor = SystemColors.Window

            mnui_Adicionar_Item.Enabled = True
            mnui_Editar_Item.Enabled = True
            mnui_Remover_Item.Enabled = True
            mnui_Importar.Enabled = True
            mnui_Exportar.Enabled = True
            mnui_Prazos.Enabled = True
            mnui_Frete.Enabled = True
            tsmi_Desconto.Enabled = True
            mnui_Colunas.Enabled = True
            tsmi_Subir_Ordem.Enabled = True
            tsmi_Abaixar_Ordem.Enabled = True

            cbo_Carregar_De.SelectedIndex = -1

            lbl_Copiar_De.Visible = True
            cbo_Carregar_De.Visible = True
            lbl_Copiar_Cliente.Visible = False
            cbo_Copiar_Cliente.Visible = False
            lbl_Copiar_Termo.Visible = False
            cbo_Copiar_Termo.Visible = False
            lbl_Copiar_Proposta.Visible = False
            cbo_Copiar_Proposta.Visible = False
            btn_Confirmar.Visible = False

            grp_Termos.Top = 61

        Else
            dtg_Itens.BackgroundColor = SystemColors.Control

            mnui_Adicionar_Item.Enabled = False
            mnui_Editar_Item.Enabled = False
            mnui_Remover_Item.Enabled = False
            mnui_Importar.Enabled = False
            mnui_Exportar.Enabled = True
            mnui_Prazos.Enabled = False
            mnui_Frete.Enabled = False
            tsmi_Desconto.Enabled = False
            mnui_Colunas.Enabled = True
            tsmi_Subir_Ordem.Enabled = False
            tsmi_Abaixar_Ordem.Enabled = False

            cbo_Carregar_De.SelectedIndex = -1

            lbl_Copiar_De.Visible = False
            cbo_Carregar_De.Visible = False
            lbl_Copiar_Cliente.Visible = False
            cbo_Copiar_Cliente.Visible = False
            lbl_Copiar_Termo.Visible = False
            cbo_Copiar_Termo.Visible = False
            lbl_Copiar_Proposta.Visible = False
            cbo_Copiar_Proposta.Visible = False
            btn_Confirmar.Visible = False

            grp_Termos.Top = 12

        End If

    End Sub
    Function CntrlExistsIn(ctrlName As String, parent As Control) As Boolean
        Dim bResult As Boolean = False
        For Each elem As Control In parent.Controls
            If elem.Name = ctrlName Then
                bResult = True
                Exit For
            End If
        Next
        Return bResult
    End Function
    Private Sub Carregar_Proposta(db_id_proposta As Integer)

        'Carrega as propostas da database para o caso de edição ou insere as colunas para o caso de inserção

        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            If db_id_proposta = 0 Then
                txt_id_filial.Text = get_id_filial
            Else

                Dim dtbProposta As New DataTable

                adapter = New MySqlDataAdapter("SELECT * FROM tb_propostas WHERE id_proposta=" & db_id_proposta, strConexao)
                adapter.Fill(dtbProposta)

                Dim rowProposta As DataRow = dtbProposta.Rows(0)

                dtp_Data_Solicitacao.Value = rowProposta("data_solicitacao")
                txt_Codigo_Proposta.Text = CONVERT_TO_STRING(rowProposta("codigo_proposta"))
                cbo_Prioridade.SelectedValue = rowProposta("id_prioridade")
                cbo_Status.SelectedValue = rowProposta("id_status")
                cbo_Cliente.SelectedValue = rowProposta("id_cliente")

                If IsNumeric(rowProposta("id_contato")) Then
                    cbo_Contato.SelectedValue = rowProposta("id_contato")
                End If

                'mkt_Telefone.Text = rowProposta("telefone")
                If IsDate(rowProposta("data_envio")) Then
                    tssl_Envio.Text = "Enviada em " & rowProposta("data_envio")
                    tssl_Envio.Tag = rowProposta("data_envio")
                Else
                    tssl_Envio.Text = "Não enviada"
                    tssl_Envio.Tag = ""
                End If

                If IsNumeric(rowProposta("id_proposta_origem")) Then
                    tssl_Origem.Text = "Revisão da proposta " & CONVERT_TO_STRING(Trim(GET_DATA_MYSQL("tb_propostas", "codigo_proposta", "id_proposta = " & rowProposta("id_proposta_origem"))))
                    tssl_Origem.Tag = rowProposta("id_proposta_origem")
                Else
                    tssl_Origem.Text = ""
                    tssl_Origem.Tag = ""
                End If

                If IsNumeric(rowProposta("id_ultima_proposta")) Then
                    tssl_Revisao.Text = "Revisada em " & CONVERT_TO_DATE(Trim(GET_DATA_MYSQL("tb_propostas", "data_insercao", "id_proposta = " & rowProposta("id_ultima_proposta")))) & ". Código: " & CONVERT_TO_STRING(Trim(GET_DATA_MYSQL("tb_propostas", "codigo_proposta", "id_proposta = " & rowProposta("id_ultima_proposta"))))
                    tssl_Revisao.Tag = rowProposta("id_ultima_proposta")
                Else
                    tssl_Revisao.Text = ""
                    tssl_Revisao.Tag = ""
                End If

                If IsDate(GET_DATA_MYSQL("tb_itens_propostas", "data_aprovacao_item", "id_proposta=" & db_id_proposta, "data_aprovacao_item DESC", Limite:="1")) Then
                    tssl_Aprovacao.Text = "Aprovada em " & CONVERT_TO_DATE(GET_DATA_MYSQL("tb_itens_propostas", "data_aprovacao_item", "id_proposta=" & db_id_proposta, "data_aprovacao_item DESC", Limite:="1"))
                    tssl_Aprovacao.Tag = GET_DATA_MYSQL("tb_itens_propostas", "data_aprovacao_item", "id_proposta=" & db_id_proposta, "data_aprovacao_item DESC", Limite:="1")
                Else
                    tssl_Aprovacao.Text = ""
                    tssl_Aprovacao.Tag = ""
                End If

                If IsDate(rowProposta("data_envio_faturamento")) Then
                    dtp_Data_Envio_Faturamento.Value = rowProposta("data_envio_faturamento")
                End If

                If IsDate(rowProposta("data_faturamento")) Then
                    dtp_Data_Faturamento.Value = rowProposta("data_faturamento")
                End If

                If IsNumeric(rowProposta("nota_fiscal")) Then
                    nud_Nota_Fiscal.Value = rowProposta("nota_fiscal")
                    nud_Nota_Fiscal.Enabled = True
                Else
                    nud_Nota_Fiscal.Enabled = False
                End If

                If IsNumeric(rowProposta("valor_faturamento")) Then
                    nud_Valor_Faturamento.Value = rowProposta("valor_faturamento")
                    nud_Valor_Faturamento.Enabled = True
                Else
                    nud_Valor_Faturamento.Enabled = False
                End If

                If IsNumeric(rowProposta("id_filial")) Then
                    txt_id_filial.Text = rowProposta("id_filial")
                End If

                If IsNumeric(rowProposta("id_serie")) Then
                    cbo_Serie.SelectedValue = rowProposta("id_serie")
                    Carrega_Dados_Serie()
                End If

                If IsNumeric(rowProposta("id_fabricante")) Then
                    If cbo_Fabricante.Items.Count = 0 Then
                        Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", "id_status=1", "nome")
                    End If

                    cbo_Fabricante.SelectedValue = rowProposta("id_fabricante")
                End If

                If IsNumeric(rowProposta("id_tipo_equipamento")) Then
                    cbo_Tipo_Equipamento.SelectedValue = rowProposta("id_tipo_equipamento")
                End If

                If IsNumeric(rowProposta("id_modelo")) Then
                    cbo_Modelo.SelectedValue = rowProposta("id_modelo")
                End If

                If IsNumeric(rowProposta("id_ano")) Then
                    cbo_Ano.SelectedValue = rowProposta("id_ano")
                End If

                If IsNumeric(rowProposta("horimetro")) Then
                    nud_Horimetro.Value = rowProposta("horimetro")
                End If

                If IsNumeric(rowProposta("ordem_servico")) Then
                    nud_Ordem_Servico.Value = rowProposta("ordem_servico")
                End If

                If IsNumeric(rowProposta("valor_faturamento")) Then
                    nud_Valor_Faturamento.Value = rowProposta("valor_faturamento")
                End If

                'If Not String.IsNullOrEmpty(rowProposta("comentarios")) Then
                txt_Comentarios.Text = CONVERT_TO_STRING(rowProposta("comentarios"))
                txt_Texto_Padrao.Text = CONVERT_TO_STRING(rowProposta("texto_padrao"))
                txt_Observacoes.Text = CONVERT_TO_STRING(rowProposta("observacoes"))
                txt_Prazo_Entrega.Text = CONVERT_TO_STRING(rowProposta("prazo_entrega"))
                txt_Condicao_Pagamento.Text = CONVERT_TO_STRING(rowProposta("condicao_pagamento"))
                txt_Garantia.Text = CONVERT_TO_STRING(rowProposta("garantia"))
                txt_Validade.Text = CONVERT_TO_STRING(rowProposta("validade"))
                'End If

            End If

                dtbItens = New DataTable

            ' If db_id_proposta = 0 Then
            'adapter = New MySqlDataAdapter("SELECT ip.id_item_proposta, ip.data_insercao, ip.id_usuario, ip.id_status, ip.id_proposta, " &
            '                                   "ip.id_status_aprovacao, ip.id_justificativa_aprovacao, ip.id_tipo_item, ip.id_fornecedor, ip.codigo_item, " &
            '                                   "ip.descricao_item, ip.quantidade_item, ip.preco_unitario_inicial_item, ip.percentual_ipi_item, ip.percentual_icms_item, " &
            '                                   "ip.ncm_item, ip.mva_item, ip.valor_st_item, ip.valor_total_inicial_item, ip.prazo_inicial_item, ip.frete_unitario_item, " &
            '                                   "ip.desconto_inicial_item, ip.id_tipo_substituicao_tributaria_item, ip.id_origem_item, ip.preco_apos_desconto_inicial_item, " &
            '                                   "ip.preco_com_ipi_e_icms_item, ip.percentual_aliquota_externa_icms_item, ip.valor_icms_credito_item, ip.percentual_mva_item, " &
            '                                   "ip.valor_mva_item, ip.preco_com_mva_item, ip.percentual_aliquota_interna_icms_item, ip.valor_icms_debito_item, ip.saldo_icms_item, " &
            '                                   "ip.preco_unitario_para_revendedor_item, ip.impostos_federais_item, ip.rateio_despesa_fixa_item, ip.percentual_lucro_necessario_item, " &
            '                                   "ip.preco_lista_venda_item, ip.desconto_final_item, ip.preco_unitario_final_item, ip.preco_total_final_item, " &
            '                                   "ip.quantidade_estoque_codigo_completo_item, ip.quantidade_estoque_codigo_abreviado_item, ip.informacao_estoque_codigo_completo_item, " &
            '                                   "ip.informacao_estoque_codigo_abreviado_item, ip.prazo_final_item, ip.comentarios_item, " &
            '                                   "us.login, ti.nome, fo.nome, ts.nome, oi.nome " &
            '                                   "FROM tb_itens_propostas AS ip " &
            '                                   "INNER JOIN tb_usuarios AS us ON ip.id_usuario=us.id_usuario " &
            '                                   "INNER JOIN tb_tipos_item AS ti ON ip.id_tipo_item=ti.id_tipo_item " &
            '                                   "INNER JOIN tb_fornecedores AS fo ON ip.id_fornecedor=fo.id_fornecedor " &
            '                                   "INNER JOIN tb_tipos_substituicao_tributaria AS ts ON ip.id_tipo_substituicao_tributaria_item=ts.id_tipo_substituicao_tributaria " &
            '                                   "INNER JOIN tb_origens AS oi ON ip.id_origem_item=oi.id_origem " &
            '                                   "WHERE 1=0 ORDER BY ip.descricao_item", strConexao)
            'Else

            adapter = New MySqlDataAdapter("SELECT ip.id_item_proposta, ip.data_insercao, ip.id_usuario, ip.id_status, ip.id_proposta, " &
                                               "ip.id_status_aprovacao, ip.id_justificativa_aprovacao, ip.id_tipo_item, ip.id_fornecedor, ip.codigo_item, " &
                                               "ip.descricao_item, ip.quantidade_item, ip.preco_unitario_inicial_item, ip.percentual_ipi_item, ip.percentual_icms_item, " &
                                               "ip.ncm_item, ip.mva_item, ip.valor_st_item, ip.valor_total_inicial_item, ip.prazo_inicial_item, ip.frete_unitario_item, " &
                                               "ip.desconto_inicial_item, ip.id_tipo_substituicao_tributaria_item, ip.id_origem_item, ip.preco_apos_desconto_inicial_item, " &
                                               "ip.preco_com_ipi_e_icms_item, ip.percentual_aliquota_externa_icms_item, ip.valor_icms_credito_item, ip.percentual_mva_item, " &
                                               "ip.valor_mva_item, ip.preco_com_mva_item, ip.percentual_aliquota_interna_icms_item, ip.valor_icms_debito_item, ip.saldo_icms_item, " &
                                               "ip.preco_unitario_para_revendedor_item, ip.impostos_federais_item, ip.rateio_despesa_fixa_item, ip.percentual_lucro_necessario_item, " &
                                               "ip.preco_lista_venda_item, ip.desconto_final_item, ip.preco_unitario_final_item, ip.preco_total_final_item, " &
                                               "ip.quantidade_estoque_codigo_completo_item, ip.quantidade_estoque_codigo_abreviado_item, ip.informacao_estoque_codigo_completo_item, " &
                                               "ip.informacao_estoque_codigo_abreviado_item, ip.prazo_final_item, ip.comentarios_item, ip.data_aprovacao_item, ip.data_edicao_item, ip.id_conjunto, ip.id_especificacao, " &
                                               "us.login, ti.nome, fo.nome, ts.nome, oi.nome, st.nome, sa.nome, ja.nome, co.nome, es.nome " &
                                               "FROM tb_itens_propostas AS ip " &
                                               "LEFT JOIN tb_usuarios AS us ON ip.id_usuario=us.id_usuario " &
                                               "LEFT JOIN tb_tipos_item AS ti ON ip.id_tipo_item=ti.id_tipo_item " &
                                               "LEFT JOIN tb_fornecedores AS fo ON ip.id_fornecedor=fo.id_fornecedor " &
                                               "LEFT JOIN tb_tipos_substituicao_tributaria AS ts ON ip.id_tipo_substituicao_tributaria_item=ts.id_tipo_substituicao_tributaria " &
                                               "LEFT JOIN tb_origens AS oi ON ip.id_origem_item=oi.id_origem " &
                                               "LEFT JOIN tb_status AS st ON ip.id_status=st.id_status " &
                                               "LEFT JOIN tb_status_aprovacao AS sa ON ip.id_status_aprovacao=sa.id_status_aprovacao " &
                                               "LEFT JOIN tb_justificativas_aprovacao AS ja ON ip.id_justificativa_aprovacao=ja.id_justificativa_aprovacao " &
                                               "LEFT JOIN tb_conjuntos AS co ON ip.id_conjunto=co.id_conjunto " &
                                               "LEFT JOIN tb_especificacoes AS es ON ip.id_especificacao=es.id_especificacao " &
                                               "WHERE ip.id_proposta = " & db_id_proposta & " ORDER BY ip.descricao_item", strConexao)
            ' End If

            adapter.Fill(dtbItens)

            dtg_Itens.DataSource = dtbItens

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Sub Atualiza_Statusbar()

        Try

            Dim Quantidade_Itens As Integer = dtg_Itens.Rows.Count
            Dim Soma_Pecas As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(preco_total_final_item)", "id_tipo_item = 1"))))
            Dim Soma_Servicos As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(preco_total_final_item)", "id_tipo_item = 2"))))
            Dim Soma_Deslocamento As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(preco_total_final_item)", "id_tipo_item = 3"))))

            ' Dim dtg_id_tipo_item As Integer = 0

            ' Soma_Pecas = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(preco_total_final_item)", "id_tipo_item = 1"))))
            ' Soma_Servicos = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(preco_total_final_item)", "id_tipo_item <> 1"))))

            'For Each dtb_row As DataRow In dtbItens.Rows

            '    dtg_id_tipo_item = CONVERT_TO_INTEGER(dtb_row("id_tipo_item").ToString)

            '    Select Case dtg_id_tipo_item
            '        Case 1
            '            Soma_Pecas = Soma_Pecas + CONVERT_TO_DECIMAL(dtb_row("preco_total_final_item").ToString)
            '        Case 2
            '            Soma_Servicos = Soma_Servicos + CONVERT_TO_DECIMAL(dtb_row("preco_total_final_item").ToString)
            '            '    Case 3

            '    End Select

            'Next

            stsi_Total_Peças.Text = "Total de peças: " + Format(Soma_Pecas, "#,##0.00")
            stsi_Total_Servicos.Text = "Total de serviços: " + Format(Soma_Servicos + Soma_Deslocamento, "#,##0.00")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Formatar_Datagrid()

        Try

            dtg_Itens.Columns("id_item_proposta").HeaderText = "ID"
            dtg_Itens.Columns("data_insercao").HeaderText = "Data de inserção"
            dtg_Itens.Columns("id_usuario").HeaderText = "ID do usuário"
            dtg_Itens.Columns("id_status").HeaderText = "ID do status"
            dtg_Itens.Columns("id_proposta").HeaderText = "ID da proposta"
            dtg_Itens.Columns("id_status_aprovacao").HeaderText = "ID do status da aprovação"
            dtg_Itens.Columns("id_justificativa_aprovacao").HeaderText = "ID da justificativa da aprovação"
            dtg_Itens.Columns("id_tipo_item").HeaderText = "ID do tipo do item"
            dtg_Itens.Columns("id_fornecedor").HeaderText = "ID do fornecedor"
            dtg_Itens.Columns("codigo_item").HeaderText = "Código"
            dtg_Itens.Columns("descricao_item").HeaderText = "Descrição"
            dtg_Itens.Columns("quantidade_item").HeaderText = "Quantidade"
            dtg_Itens.Columns("preco_unitario_inicial_item").HeaderText = "Preço unitário inicial"
            dtg_Itens.Columns("percentual_ipi_item").HeaderText = "% IPI"
            dtg_Itens.Columns("percentual_icms_item").HeaderText = "% ICMS"
            dtg_Itens.Columns("ncm_item").HeaderText = "NCM"
            dtg_Itens.Columns("mva_item").HeaderText = "MVA"
            dtg_Itens.Columns("valor_st_item").HeaderText = "Valor ST"
            dtg_Itens.Columns("valor_total_inicial_item").HeaderText = "Preço total inicial"
            dtg_Itens.Columns("prazo_inicial_item").HeaderText = "Prazo inicial"
            dtg_Itens.Columns("frete_unitario_item").HeaderText = "Frete unitário"
            dtg_Itens.Columns("desconto_inicial_item").HeaderText = "Desconto no custo"
            dtg_Itens.Columns("id_tipo_substituicao_tributaria_item").HeaderText = "ID do tipo de substituição tributária"
            dtg_Itens.Columns("id_origem_item").HeaderText = "ID da origem"
            dtg_Itens.Columns("preco_apos_desconto_inicial_item").HeaderText = "Preço unitário após desconto inicial"
            dtg_Itens.Columns("preco_com_ipi_e_icms_item").HeaderText = "Valor com IPI e ICMS"
            dtg_Itens.Columns("percentual_aliquota_externa_icms_item").HeaderText = "Alíquota externa ICMS"
            dtg_Itens.Columns("valor_icms_credito_item").HeaderText = "Valor do ICMS crédito"
            dtg_Itens.Columns("percentual_mva_item").HeaderText = "Percentual do MVA"
            dtg_Itens.Columns("valor_mva_item").HeaderText = "Valor do MVA"
            dtg_Itens.Columns("preco_com_mva_item").HeaderText = "Valor do item + MVA"
            dtg_Itens.Columns("percentual_aliquota_interna_icms_item").HeaderText = "Alíquota interna do ICMS"
            dtg_Itens.Columns("valor_icms_debito_item").HeaderText = "Valor do ICMS débito"
            dtg_Itens.Columns("saldo_icms_item").HeaderText = "Saldo do ICMS"
            dtg_Itens.Columns("preco_unitario_para_revendedor_item").HeaderText = "Total com imposto para o revendedor"
            dtg_Itens.Columns("impostos_federais_item").HeaderText = "Impostos federais"
            dtg_Itens.Columns("rateio_despesa_fixa_item").HeaderText = "Rateio despesa fixa"
            dtg_Itens.Columns("percentual_lucro_necessario_item").HeaderText = "% Lucro necessário"
            dtg_Itens.Columns("preco_lista_venda_item").HeaderText = "Preço lista de venda"
            dtg_Itens.Columns("desconto_final_item").HeaderText = "Desconto final"
            dtg_Itens.Columns("preco_unitario_final_item").HeaderText = "Preço unitário final com desconto"
            dtg_Itens.Columns("preco_total_final_item").HeaderText = "Preço total final com desconto"
            dtg_Itens.Columns("quantidade_estoque_codigo_completo_item").HeaderText = "Quantidade em estoque (código completo)"
            dtg_Itens.Columns("quantidade_estoque_codigo_abreviado_item").HeaderText = "Quantidade em estoque (código abreviado)"
            dtg_Itens.Columns("informacao_estoque_codigo_completo_item").HeaderText = "Informação do estoque (código completo)"
            dtg_Itens.Columns("informacao_estoque_codigo_abreviado_item").HeaderText = "Informação do estoque (código abreviado)"
            dtg_Itens.Columns("prazo_final_item").HeaderText = "Prazo para o cliente"
            dtg_Itens.Columns("comentarios_item").HeaderText = "Comentários"
            dtg_Itens.Columns("data_aprovacao_item").HeaderText = "Data da aprovação"
            dtg_Itens.Columns("id_conjunto").HeaderText = "ID do conjunto"
            dtg_Itens.Columns("id_especificacao").HeaderText = "ID da especificação"
            dtg_Itens.Columns("login").HeaderText = "Usuário"
            dtg_Itens.Columns("nome").HeaderText = "Tipo do item"
            dtg_Itens.Columns("nome1").HeaderText = "Fornecedor"
            dtg_Itens.Columns("nome2").HeaderText = "Tipo de substituição tributária"
            dtg_Itens.Columns("nome3").HeaderText = "Origem"
            dtg_Itens.Columns("nome4").HeaderText = "Status"
            dtg_Itens.Columns("nome5").HeaderText = "Status da aprovação"
            dtg_Itens.Columns("nome6").HeaderText = "Justificativa da aprovação"
            dtg_Itens.Columns("nome7").HeaderText = "Conjunto"
            dtg_Itens.Columns("nome8").HeaderText = "Especificação"

            dtg_Itens.Columns("id_item_proposta").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("data_insercao").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dtg_Itens.Columns("id_usuario").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_status").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_proposta").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_status_aprovacao").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_justificativa_aprovacao").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_tipo_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_fornecedor").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("codigo_item").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("descricao_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("quantidade_item").DefaultCellStyle.Format = "#,##0"
            dtg_Itens.Columns("preco_unitario_inicial_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("percentual_ipi_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("percentual_icms_item").DefaultCellStyle.Format = "0.00%"
            'dtg_Itens.Columns("ncm_item").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("mva_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("valor_st_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("valor_total_inicial_item").DefaultCellStyle.Format = "#,##0.00"
            'dtg_Itens.Columns("prazo_inicial_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("frete_unitario_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("desconto_inicial_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("id_tipo_substituicao_tributaria_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_origem_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("preco_apos_desconto_inicial_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("preco_com_ipi_e_icms_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("percentual_aliquota_externa_icms_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("valor_icms_credito_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("percentual_mva_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("valor_mva_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("preco_com_mva_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("percentual_aliquota_interna_icms_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("valor_icms_debito_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("saldo_icms_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("preco_unitario_para_revendedor_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("impostos_federais_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("rateio_despesa_fixa_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("percentual_lucro_necessario_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("preco_lista_venda_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("desconto_final_item").DefaultCellStyle.Format = "0.00%"
            dtg_Itens.Columns("preco_unitario_final_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("preco_total_final_item").DefaultCellStyle.Format = "#,##0.00"
            dtg_Itens.Columns("quantidade_estoque_codigo_completo_item").DefaultCellStyle.Format = "#,##0"
            dtg_Itens.Columns("quantidade_estoque_codigo_abreviado_item").DefaultCellStyle.Format = "#,##0"
            'dtg_Itens.Columns("informacao_estoque_codigo_completo_item").DefaultCellStyle.Format = "0"
            ' dtg_Itens.Columns("informacao_estoque_codigo_abreviado_item").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("prazo_final_item").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("comentarios_item").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("data_aprovacao_item").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dtg_Itens.Columns("data_edicao_item").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dtg_Itens.Columns("id_conjunto").DefaultCellStyle.Format = "0"
            dtg_Itens.Columns("id_especificacao").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome1").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome2").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome3").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome4").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome5").DefaultCellStyle.Format = "0"
            'dtg_Itens.Columns("nome6").DefaultCellStyle.Format = "0"

            dtg_Itens.Columns("id_item_proposta").Visible = False
            dtg_Itens.Columns("data_insercao").Visible = False
            dtg_Itens.Columns("id_usuario").Visible = False
            dtg_Itens.Columns("id_status").Visible = False
            dtg_Itens.Columns("id_proposta").Visible = False
            dtg_Itens.Columns("id_status_aprovacao").Visible = False
            dtg_Itens.Columns("id_justificativa_aprovacao").Visible = False
            dtg_Itens.Columns("id_tipo_item").Visible = False
            dtg_Itens.Columns("id_fornecedor").Visible = False
            dtg_Itens.Columns("id_tipo_substituicao_tributaria_item").Visible = False
            dtg_Itens.Columns("id_origem_item").Visible = False
            dtg_Itens.Columns("data_aprovacao_item").Visible = False
            dtg_Itens.Columns("data_edicao_item").Visible = False
            dtg_Itens.Columns("id_conjunto").Visible = False
            dtg_Itens.Columns("id_especificacao").Visible = False

            dtg_Itens.Columns("login").DisplayIndex = 3
            dtg_Itens.Columns("nome").DisplayIndex = 4
            dtg_Itens.Columns("nome1").DisplayIndex = 7
            dtg_Itens.Columns("nome2").DisplayIndex = 22
            dtg_Itens.Columns("nome3").DisplayIndex = 23
            dtg_Itens.Columns("nome4").DisplayIndex = 0
            dtg_Itens.Columns("nome5").DisplayIndex = 1
            dtg_Itens.Columns("nome6").DisplayIndex = 2
            dtg_Itens.Columns("nome7").DisplayIndex = 5
            dtg_Itens.Columns("nome8").DisplayIndex = 6

            For Each dc As DataGridViewColumn In dtg_Itens.Columns
                dc.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        Catch ex As Exception

        End Try

    End Sub

    'Private Sub dtg_Itens_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Itens.CellValueChanged

    'Dim dtb_row As DataRow = dtbItens.Rows(e.RowIndex)

    'Select Case e.ColumnIndex
    '    Case dtg_Itens.Columns("status_combobox").Index
    '        dtb_row("id_status") = dtg_Itens(e.ColumnIndex, e.RowIndex).Value
    '    Case dtg_Itens.Columns("status_aprovacao_combobox").Index
    '        dtb_row("id_status_aprovacao") = dtg_Itens(e.ColumnIndex, e.RowIndex).Value
    '    Case dtg_Itens.Columns("justificativa_aprovacao_combobox").Index
    '        dtb_row("id_justificativa_aprovacao") = dtg_Itens(e.ColumnIndex, e.RowIndex).Value
    'End Select

    'dtb_row = Nothing

    ' End Sub

    Private Sub tsmi_Exportar_Kion_Click(sender As Object, e As EventArgs) Handles tsmi_Exportar_Kion.Click

        Dim strarquivoSalvo As String = ""

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1 AND id_fornecedor = 1 ").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças para o fornecedor selecionado na proposta informada. Adicione ou importe peças para poder exportar", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Using OFD As New SaveFileDialog With {.FileName = "importacao", .Filter = "Arquivo do Excel (*.xlsx)|*.xlsx"}
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
            elWorksheet.Name = "importacao1"

            elWorksheet.Range("A1").Value = "item"
            elWorksheet.Range("B1").Value = "quantidade"

            Dim elRow As Long = 2

            For Each dtb_row As DataRow In dtbItens.Rows
                If CONVERT_TO_INTEGER(Trim(CONVERT_TO_STRING(dtb_row("id_tipo_item")))) = 1 And CONVERT_TO_INTEGER(Trim(CONVERT_TO_STRING(dtb_row("id_fornecedor")))) = 1 Then
                    elWorksheet.Range("A" & elRow).Value = CONVERT_TO_STRING(Trim(CONVERT_TO_STRING(dtb_row("codigo_item"))))
                    elWorksheet.Range("B" & elRow).Value = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtb_row("quantidade_item"))))
                    elRow = elRow + 1
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
    Sub Atualizar_Estoque(Optional ByVal Tipo_Info_Estoque As String = "Por peca")

        Dim elApp As New Microsoft.Office.Interop.Excel.Application()
        Dim elWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim elWorksheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim elRange As Microsoft.Office.Interop.Excel.Range
        Dim elRangeFind As Microsoft.Office.Interop.Excel.Range
        ' Dim elRow As Microsoft.Office.Interop.Excel.Range
        'Dim dtbRow As System.Data.DataRow
        ' Dim sqlcmd As MySqlCommand
        Dim conta_linhas As Integer = 1
        Dim Fornecedor_Encontrado As Integer = 0
        Dim Texto_Encontrado_Abreviado As String = ""
        Dim Quantidade_Estoque_Abreviado As Decimal = 0.0
        Dim Quantidade_Estoque_Completo As Decimal = 0.0
        Dim Informacao_Estoque_Abreviado As String = ""
        Dim Informacao_Estoque_Completo As String = ""
        Dim Quantidade_Usada_Prazo As Decimal = 0.0
        Dim Prazo_Final As String = ""
        Dim Primeiro_Endereco_Encontrado As String = ""
        Dim WorkbookPath As String = GET_STOCK_FILE()
        Dim WorkbookPassword As String = CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockPassword))
        Dim WorksheetName As String = CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockSheet))
        Dim Quantidade_Padrao_Dias As Long = CONVERT_TO_LONG(GET_DATA_MYSQL("tb_usuarios AS user", "seto.prazo_adicional", "user.id_usuario = " & get_id_usuario, juncao_interna:="tb_setores AS seto ON user.id_setor = seto.id_setor", Limite:="1"))

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças na proposta informada. Adicione ou importe peças para poder atualizar o prazo", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Try

            elApp.Visible = False
            elApp.Workbooks.Open(WorkbookPath, False, True, Password:=WorkbookPassword)
            elWorkbook = elApp.Workbooks(System.IO.Path.GetFileName(WorkbookPath))

            For Each tSheet As Microsoft.Office.Interop.Excel.Worksheet In elWorkbook.Worksheets
                If CONVERT_TO_STRING(tSheet.Name).Contains(WorksheetName) Then
                    elWorksheet = tSheet
                    Exit For
                End If
            Next

            If elWorksheet Is Nothing Then
                MessageBox.Show(text:="Não foi encontrada nenhuma aba contendo o nome '" & WorksheetName & "'. Altere o nome a ser procurado através das configurações e tente novamente", caption:="Aba não encontrada", buttons:=vbOKOnly, icon:=vbExclamation)

                For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
                    wb.Close(False)
                Next

                elApp.Quit()
                ' releaseObject(elWorksheet)
                elWorksheet = Nothing
                ' releaseObject(elWorkbook)
                elWorkbook = Nothing
                'releaseObject(elApp)
                elApp = Nothing

                Exit Sub
            End If
            ' elWorksheet = elWorkbook.Worksheets(WorksheetName)

            elRange = elWorksheet.Range("A1:AAA65536")

        Catch ex As Exception

            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
            For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
                wb.Close(False)
            Next

            elApp.Quit()
            '  releaseObject(elWorksheet)
            elWorksheet = Nothing
            '  releaseObject(elWorkbook)
            elWorkbook = Nothing
            '  releaseObject(elApp)
            elApp = Nothing

            Exit Sub

        End Try

        Try
            elWorksheet.ShowAllData()
        Catch ex As Exception

        End Try

        pgb_Atualizando_Prazo.Visible = True
        lbl_Atualizando_Prazo.Visible = True

        pgb_Atualizando_Prazo.Minimum = 0
        pgb_Atualizando_Prazo.Maximum = dtbItens.Rows.Count
        pgb_Atualizando_Prazo.Value = 0

        For Each dtb_row As DataRow In dtbItens.Rows

            Try
                If CONVERT_TO_INTEGER(dtb_row("id_tipo_item")) = 1 Then
                    'Retorna pelo codigo completo

                    If Tipo_Info_Estoque = "Codigo completo" Or Tipo_Info_Estoque = "Por peca" Then

                        elRangeFind = elRange.Find(Trim(CONVERT_TO_STRING(dtb_row("codigo_item"))), LookIn:=Microsoft.Office.Interop.Excel.XlFindLookIn.xlValues, LookAt:=Microsoft.Office.Interop.Excel.XlLookAt.xlPart)

                        Quantidade_Estoque_Completo = 0.0
                        Informacao_Estoque_Completo = "-"

                        If elRangeFind IsNot Nothing Then

                            '  Quantidade_Estoque_Completo = 0.0
                            '   Informacao_Estoque_Completo = "-"

                            '  Else
                            Primeiro_Endereco_Encontrado = CONVERT_TO_STRING(elRangeFind.Address)
                            Do

                                Select Case Trim(elWorksheet.Range("D" & elRangeFind.Row).Value)
                                    Case "STILL"
                                        Fornecedor_Encontrado = 1
                                    Case "LINDE"
                                        Fornecedor_Encontrado = 1
                                    Case "TVH"
                                        Fornecedor_Encontrado = 2
                                    Case Else
                                        Fornecedor_Encontrado = 0
                                End Select

                                If Fornecedor_Encontrado = CONVERT_TO_INTEGER(dtb_row("id_fornecedor").ToString) Then
                                    Quantidade_Estoque_Completo = Quantidade_Estoque_Completo + CONVERT_TO_DECIMAL(elWorksheet.Range("H" & elRangeFind.Row).Value)
                                End If

                                If String.IsNullOrEmpty(Informacao_Estoque_Completo) Or Informacao_Estoque_Completo = "-" Then
                                    Informacao_Estoque_Completo = CONVERT_TO_STRING(elWorksheet.Range("D" & elRangeFind.Row).Value) & ": " & CONVERT_TO_STRING(elWorksheet.Range("H" & elRangeFind.Row).Value) & ";"
                                Else
                                    Informacao_Estoque_Completo = Informacao_Estoque_Completo & vbNewLine & CONVERT_TO_STRING(elWorksheet.Range("D" & elRangeFind.Row).Value) & ": " & CONVERT_TO_STRING(elWorksheet.Range("H" & elRangeFind.Row).Value) & ";"
                                End If

                                elRangeFind = elRange.FindNext(elRangeFind)
                            Loop While elRangeFind IsNot Nothing And elRangeFind.Address.ToString <> Primeiro_Endereco_Encontrado

                        End If

                    End If

                    'Retorna pelo codigo abreviado

                    If Tipo_Info_Estoque = "Codigo abreviado" Or Tipo_Info_Estoque = "Por peca" Then

                        elRangeFind = elRange.Find(CONVERT_TO_STRING(NUMBERS_FROM_STRING(Trim(CONVERT_TO_STRING(dtb_row("codigo_item"))))), LookIn:=Microsoft.Office.Interop.Excel.XlFindLookIn.xlValues, LookAt:=Microsoft.Office.Interop.Excel.XlLookAt.xlPart)

                        Quantidade_Estoque_Abreviado = 0.0
                        Informacao_Estoque_Abreviado = "-"

                        If elRangeFind IsNot Nothing Then

                            ' Quantidade_Estoque_Abreviado = 0.0
                            '   Informacao_Estoque_Abreviado = "-"

                            ' Else
                            Primeiro_Endereco_Encontrado = CONVERT_TO_STRING(elRangeFind.Address)
                            Do

                                Select Case Trim(elWorksheet.Range("D" & elRangeFind.Row).Value)
                                    Case "STILL"
                                        Fornecedor_Encontrado = 1
                                    Case "LINDE"
                                        Fornecedor_Encontrado = 1
                                    Case "TVH"
                                        Fornecedor_Encontrado = 2
                                    Case Else
                                        Fornecedor_Encontrado = 0
                                End Select

                                If Fornecedor_Encontrado = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtb_row("id_fornecedor"))) Then
                                    Quantidade_Estoque_Abreviado = Quantidade_Estoque_Abreviado + CONVERT_TO_DECIMAL(CONVERT_TO_STRING(elWorksheet.Range("H" & elRangeFind.Row).Value))

                                    If CONVERT_TO_LETTER(elRangeFind.Column) = "L" Then
                                        Texto_Encontrado_Abreviado = Trim(CONVERT_TO_STRING(elWorksheet.Range("D" & elRangeFind.Row).Value) & " - " & CONVERT_TO_STRING(elRangeFind.Value))
                                    Else
                                        Texto_Encontrado_Abreviado = Trim(CONVERT_TO_STRING(elWorksheet.Range("D" & elRangeFind.Row).Value) & " - " & CONVERT_TO_STRING(elRangeFind.Value) & " - " & CONVERT_TO_STRING(elWorksheet.Range("L" & elRangeFind.Row).Value))
                                    End If

                                End If

                                If String.IsNullOrEmpty(Informacao_Estoque_Abreviado) Or Informacao_Estoque_Abreviado = "-" Then
                                    Informacao_Estoque_Abreviado = CONVERT_TO_STRING(elWorksheet.Range("D" & elRangeFind.Row).Value) & ": " & CONVERT_TO_STRING(elWorksheet.Range("H" & elRangeFind.Row).Value) & ";"
                                Else
                                    Informacao_Estoque_Abreviado = Informacao_Estoque_Abreviado & vbNewLine & CONVERT_TO_STRING(elWorksheet.Range("D" & elRangeFind.Row).Value) & ": " & CONVERT_TO_STRING(elWorksheet.Range("H" & elRangeFind.Row).Value) & ";"
                                End If

                                elRangeFind = elRange.FindNext(elRangeFind)
                            Loop While elRangeFind IsNot Nothing And CONVERT_TO_STRING(elRangeFind.Address) <> Primeiro_Endereco_Encontrado

                        End If

                    End If

                    If Tipo_Info_Estoque = "Codigo abreviado" Then
                        Quantidade_Usada_Prazo = Quantidade_Estoque_Abreviado
                    Else
                        If Quantidade_Estoque_Completo > 0 Then
                            Quantidade_Usada_Prazo = Quantidade_Estoque_Completo
                        Else

                            If Quantidade_Estoque_Abreviado > 0 Then
                                Dim Texto_Pergunta As String = "O item foi encontrado em estoque apenas através do código abreviado, por isso é necessário a validação manual. " & vbNewLine & vbNewLine & "O item '" & Texto_Encontrado_Abreviado & "' encontrado em estoque corresponde ao item '" & CONVERT_TO_STRING(dtb_row("nome1")) & " - " & CONVERT_TO_STRING(dtb_row("codigo_item")) & " - " & CONVERT_TO_STRING(dtb_row("descricao_item")) & "' presente na proposta?"
                                If MessageBox.Show(Texto_Pergunta, "Confirmação de item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    Quantidade_Usada_Prazo = Quantidade_Estoque_Abreviado
                                Else
                                    Quantidade_Usada_Prazo = Quantidade_Estoque_Completo
                                End If
                            Else
                                Quantidade_Usada_Prazo = Quantidade_Estoque_Completo
                            End If
                        End If
                    End If
                    dtb_row("quantidade_estoque_codigo_completo_item") = Quantidade_Estoque_Completo
                    dtb_row("quantidade_estoque_codigo_abreviado_item") = Quantidade_Estoque_Abreviado
                    dtb_row("informacao_estoque_codigo_completo_item") = Informacao_Estoque_Completo
                    dtb_row("informacao_estoque_codigo_abreviado_item") = Informacao_Estoque_Abreviado
                    dtb_row("prazo_final_item") = RETORNA_PRAZO(CONVERT_TO_DECIMAL(CONVERT_TO_STRING(dtb_row("quantidade_item"))), Strings.Trim(Replace(CONVERT_TO_STRING(dtb_row("prazo_inicial_item")), "*", "")), Quantidade_Usada_Prazo, Quantidade_Padrao_Dias)

                Else
                    dtb_row("prazo_final_item") = dtb_row("prazo_inicial_item")
                End If
            Catch ex As Exception
                ' MessageBox.Show("Não foi possível atualizar o prazo do item")
            End Try

            pgb_Atualizando_Prazo.Value = pgb_Atualizando_Prazo.Value + 1
            lbl_Atualizando_Prazo.Text = "Atualizando prazo, aguarde... | " & Format(DIVIDE(pgb_Atualizando_Prazo.Value, pgb_Atualizando_Prazo.Maximum), "0%")

        Next

        For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
            wb.Close(False)
        Next

        elApp.Quit()
        'releaseObject(elWorksheet)
        elWorksheet = Nothing
        ' releaseObject(elWorkbook)
        elWorkbook = Nothing
        ' releaseObject(elApp)
        elApp = Nothing

        'dtbItens.Columns.Remove(dtbCol.ColumnName)

        pgb_Atualizando_Prazo.Visible = False
        lbl_Atualizando_Prazo.Visible = False

        txt_atualizou_prazo.Text = 1

    End Sub

    Private Function RETORNA_PRAZO(ByVal Quantidade_Inicial As Decimal, ByVal Prazo_Fornecedor As String, ByVal Quantidade_Estoque As Decimal, ByVal Quantidade_Dias_Para_Cliente As Long) As String

        Dim arrPrazos() As String
        Dim Novo_Texto_Prazo As String = ""
        Dim arrQuantidade_Data() As String
        Dim Novo_Texto_Quantidade_Data As String = ""
        Dim Quantidade_Fornecedor As Decimal = 0.0
        Dim tDias As String = ""
        Dim tPrazo As String = ""
        Dim dias_prazo As Long = 0

        'Código para retornar o texto do prazo de cada item da proposta

        'Tenta fazer retornar o prazo, caso contrário retorna "-"
        Try
            'Verifica a quantidade de itens em estoque
            Select Case Quantidade_Estoque
                'Caso seja maior ou igual a quantidade solicitada, retorna 'Imediato' pois tem quantidade suficiente em estoque
                Case Is >= Quantidade_Inicial
                    Return "Imediato"
                    'Caso a quantidade em estoque seja menor ou igual a zero, calcula o prazo para o cliente considerando a quantidade de dias padrão
                Case Is <= 0.0

                    arrPrazos = Split(Prazo_Fornecedor, "|")

                    For x As Integer = LBound(arrPrazos) To UBound(arrPrazos)

                        If InStr(Strings.Trim(CONVERT_TO_STRING(arrPrazos(x))), "-") <= 0 Then

                            If Strings.Trim(CONVERT_TO_STRING(arrPrazos(x))).ToLower = "ordem em atraso" Then
                                Novo_Texto_Prazo = "Prazo indefinido"
                            Else
                                Select Case Quantidade_Dias_Para_Cliente
                                    Case 0
                                        Novo_Texto_Prazo = "Imediato"
                                    Case 1
                                        Novo_Texto_Prazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dia"
                                    Case Else
                                        Novo_Texto_Prazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dias"
                                End Select
                            End If

                        Else

                            arrQuantidade_Data = Split(Strings.Trim(CONVERT_TO_STRING(arrPrazos(x))), "-")

                            Quantidade_Fornecedor = DECIMAL_NUMBERS_FROM_STRING(CONVERT_TO_STRING(arrQuantidade_Data(0)))

                            If IsDate(Strings.Trim(CONVERT_TO_STRING(arrQuantidade_Data(1)))) Then
                                dias_prazo = DateDiff(DateInterval.Day, Now, Date.Parse(Strings.Trim(CONVERT_TO_STRING(arrQuantidade_Data(1))))) + Quantidade_Dias_Para_Cliente
                                Select Case dias_prazo
                                    Case 0
                                        tPrazo = "Imediato"
                                    Case 1
                                        tPrazo = CONVERT_TO_STRING(dias_prazo) & " dia"
                                    Case Else
                                        tPrazo = CONVERT_TO_STRING(dias_prazo) & " dias"
                                End Select
                            Else
                                If Strings.Trim(CONVERT_TO_STRING(arrQuantidade_Data(1))).ToLower = "ordem em atraso" Then
                                    tPrazo = "Prazo indefinido"
                                Else
                                    Select Case Quantidade_Dias_Para_Cliente
                                        Case 0
                                            tPrazo = "Imediato"
                                        Case 1
                                            tPrazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dia"
                                        Case Else
                                            tPrazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dias"
                                    End Select
                                End If
                            End If

                            If Novo_Texto_Prazo = "" Then
                                Novo_Texto_Prazo = "Qtd: " & CONVERT_TO_STRING(Quantidade_Fornecedor) & " - " & tPrazo
                            Else
                                Novo_Texto_Prazo = Novo_Texto_Prazo & " | Qtd: " & CONVERT_TO_STRING(Quantidade_Fornecedor) & " - " & tPrazo
                            End If

                        End If

                    Next

                    Novo_Texto_Prazo = Replace(Novo_Texto_Prazo, "- -", "-")

                    Dim tmparr() As String = Split(Novo_Texto_Prazo, "-")

                    If tmparr.Length <= 2 Then
                        Novo_Texto_Prazo = Trim(tmparr(UBound(tmparr)))
                    End If

                    Return Novo_Texto_Prazo

                    'Caso a quantidade em estoque seja maior que zero mas seja menor que a quantidade solicitada
                Case Else
                    'Verifica se o texto do prazo possui um "-", indicando que o prazo está quebrado em mais de 1

                    arrPrazos = Split(Prazo_Fornecedor, "|")

                    Novo_Texto_Prazo = "Qtd: " & CONVERT_TO_STRING(Quantidade_Estoque) & " - Imediato"

                    Dim Total_Quantidade As Decimal = Quantidade_Inicial - Quantidade_Estoque

                    For x As Integer = LBound(arrPrazos) To UBound(arrPrazos)

                        If InStr(Strings.Trim(CONVERT_TO_STRING(arrPrazos(x))), "-") <= 0 Then

                            If Strings.Trim(CONVERT_TO_STRING(arrPrazos(x))).ToLower = "ordem em atraso" Then
                                Novo_Texto_Prazo = "Prazo indefinido"
                            Else
                                Select Case Quantidade_Dias_Para_Cliente
                                    Case 0
                                        Novo_Texto_Prazo = "Imediato"
                                    Case 1
                                        Novo_Texto_Prazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dia"
                                    Case Else
                                        Novo_Texto_Prazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dias"
                                End Select
                            End If

                        Else

                            arrQuantidade_Data = Split(Strings.Trim(CONVERT_TO_STRING(arrPrazos(x))), "-")

                            If DECIMAL_NUMBERS_FROM_STRING(CONVERT_TO_STRING(arrQuantidade_Data(0))) >= Total_Quantidade Then
                                Quantidade_Fornecedor = Total_Quantidade
                            Else
                                Quantidade_Fornecedor = Total_Quantidade - DECIMAL_NUMBERS_FROM_STRING(CONVERT_TO_STRING(arrQuantidade_Data(0)))
                            End If

                            If IsDate(Strings.Trim(CONVERT_TO_STRING(arrQuantidade_Data(1)))) Then
                                dias_prazo = DateDiff(DateInterval.Day, Now, Date.Parse(Strings.Trim(CONVERT_TO_STRING(arrQuantidade_Data(1))))) + Quantidade_Dias_Para_Cliente
                                Select Case dias_prazo
                                    Case 0
                                        tPrazo = "Imediato"
                                    Case 1
                                        tPrazo = CONVERT_TO_STRING(dias_prazo) & " dia"
                                    Case Else
                                        tPrazo = CONVERT_TO_STRING(dias_prazo) & " dias"
                                End Select
                            Else
                                If Strings.Trim(CONVERT_TO_STRING(arrQuantidade_Data(1))).ToLower = "ordem em atraso" Then
                                    tPrazo = "Prazo indefinido"
                                Else
                                    Select Case Quantidade_Dias_Para_Cliente
                                        Case 0
                                            tPrazo = "Imediato"
                                        Case 1
                                            tPrazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dia"
                                        Case Else
                                            tPrazo = CONVERT_TO_STRING(Quantidade_Dias_Para_Cliente) & " dias"
                                    End Select
                                End If
                            End If

                            If Novo_Texto_Prazo = "" Then
                                Novo_Texto_Prazo = "Qtd: " & CONVERT_TO_STRING(Quantidade_Fornecedor) & " - " & tPrazo
                            Else
                                Novo_Texto_Prazo = Novo_Texto_Prazo & " | Qtd: " & CONVERT_TO_STRING(Quantidade_Fornecedor) & " - " & tPrazo
                            End If

                            If Quantidade_Fornecedor + Quantidade_Estoque >= Quantidade_Inicial Then
                                Exit For
                            End If
                        End If
                    Next

                    Novo_Texto_Prazo = Replace(Novo_Texto_Prazo, "- -", "-")

                    Dim tmparr() As String = Split(Novo_Texto_Prazo, "-")

                    If tmparr.Length <= 2 Then
                        Novo_Texto_Prazo = Trim(tmparr(UBound(tmparr)))
                    End If

                    Return Novo_Texto_Prazo

            End Select

        Catch ex As Exception
            Return "-"
        End Try

    End Function

    Private Sub Colunas_Visiveis(smodo As String, estado As Boolean)

        Select Case smodo
            Case "dados_iniciais"
                dtg_Itens.Columns("percentual_ipi_item").Visible = estado
                dtg_Itens.Columns("percentual_icms_item").Visible = estado
                dtg_Itens.Columns("ncm_item").Visible = estado
                dtg_Itens.Columns("mva_item").Visible = estado
                dtg_Itens.Columns("valor_st_item").Visible = estado
            Case "calculos"
                dtg_Itens.Columns("preco_apos_desconto_inicial_item").Visible = estado
                dtg_Itens.Columns("preco_com_ipi_e_icms_item").Visible = estado
                dtg_Itens.Columns("percentual_aliquota_externa_icms_item").Visible = estado
                dtg_Itens.Columns("valor_icms_credito_item").Visible = estado
                dtg_Itens.Columns("percentual_mva_item").Visible = estado
                dtg_Itens.Columns("valor_mva_item").Visible = estado
                dtg_Itens.Columns("preco_com_mva_item").Visible = estado
                dtg_Itens.Columns("percentual_aliquota_interna_icms_item").Visible = estado
                dtg_Itens.Columns("valor_icms_debito_item").Visible = estado
                dtg_Itens.Columns("saldo_icms_item").Visible = estado
                dtg_Itens.Columns("preco_unitario_para_revendedor_item").Visible = estado
                dtg_Itens.Columns("impostos_federais_item").Visible = estado
                dtg_Itens.Columns("rateio_despesa_fixa_item").Visible = estado
                dtg_Itens.Columns("percentual_lucro_necessario_item").Visible = estado
                dtg_Itens.Columns("preco_lista_venda_item").Visible = estado
            Case "estoque"
                dtg_Itens.Columns("quantidade_estoque_codigo_completo_item").Visible = estado
                dtg_Itens.Columns("quantidade_estoque_codigo_abreviado_item").Visible = estado
            Case "todas"
                dtg_Itens.Columns("percentual_ipi_item").Visible = estado
                dtg_Itens.Columns("percentual_icms_item").Visible = estado
                dtg_Itens.Columns("ncm_item").Visible = estado
                dtg_Itens.Columns("mva_item").Visible = estado
                dtg_Itens.Columns("valor_st_item").Visible = estado
                dtg_Itens.Columns("preco_apos_desconto_inicial_item").Visible = estado
                dtg_Itens.Columns("preco_com_ipi_e_icms_item").Visible = estado
                dtg_Itens.Columns("percentual_aliquota_externa_icms_item").Visible = estado
                dtg_Itens.Columns("valor_icms_credito_item").Visible = estado
                dtg_Itens.Columns("percentual_mva_item").Visible = estado
                dtg_Itens.Columns("valor_mva_item").Visible = estado
                dtg_Itens.Columns("preco_com_mva_item").Visible = estado
                dtg_Itens.Columns("percentual_aliquota_interna_icms_item").Visible = estado
                dtg_Itens.Columns("valor_icms_debito_item").Visible = estado
                dtg_Itens.Columns("saldo_icms_item").Visible = estado
                dtg_Itens.Columns("preco_unitario_para_revendedor_item").Visible = estado
                dtg_Itens.Columns("impostos_federais_item").Visible = estado
                dtg_Itens.Columns("rateio_despesa_fixa_item").Visible = estado
                dtg_Itens.Columns("percentual_lucro_necessario_item").Visible = estado
                dtg_Itens.Columns("preco_lista_venda_item").Visible = estado
                dtg_Itens.Columns("quantidade_estoque_codigo_completo_item").Visible = estado
                dtg_Itens.Columns("quantidade_estoque_codigo_abreviado_item").Visible = estado
        End Select

    End Sub
    Function Retorna_ID_Contato() As Integer
        Dim sqlcmd As MySqlCommand

        If Not IsNothing(cbo_Contato.SelectedValue) Then

            Try
                'Abrir_Conexao()

                sqlcmd = New MySqlCommand("sp_editar_contato", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_contato", cbo_Contato.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_nome", cbo_Contato.Text)
                sqlcmd.Parameters.AddWithValue("p_telefone", REMOVE_MASK(mkt_Telefone))
                sqlcmd.Parameters.AddWithValue("p_email", txt_Email.Text)
                sqlcmd.Parameters.AddWithValue("p_id_pais", cbo_Pais.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_estado", cbo_Estado.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cidade", cbo_Cidade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_status", 1)
                sqlcmd.Parameters.AddWithValue("p_id_cliente", cbo_Cliente.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                ' Fechar_Conexao()
                sqlcmd = Nothing
            Catch ex As Exception
                'Fechar_Conexao()
            End Try

            Return cbo_Contato.SelectedValue
        End If


        Try
            'Abrir_Conexao()

            sqlcmd = New MySqlCommand("sp_inserir_contato", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_nome", cbo_Contato.Text)
            sqlcmd.Parameters.AddWithValue("p_telefone", REMOVE_MASK(mkt_Telefone))
            sqlcmd.Parameters.AddWithValue("p_email", txt_Email.Text)
            sqlcmd.Parameters.AddWithValue("p_id_pais", cbo_Pais.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_estado", cbo_Estado.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_cidade", cbo_Cidade.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_status", 1)
            sqlcmd.Parameters.AddWithValue("p_id_cliente", cbo_Cliente.SelectedValue)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_contato", MySqlDbType.Int32).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim p_id_contato As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_contato").Value)

            ' Fechar_Conexao()
            sqlcmd = Nothing
            Return p_id_contato
        Catch ex As Exception
            'Fechar_Conexao()
            Return 0
        End Try

    End Function

    Function Retorna_ID_Serie() As Integer
        Dim sqlcmd As MySqlCommand

        If Not IsNothing(cbo_Serie.SelectedValue) Then
            Return cbo_Serie.SelectedValue
        End If

        Try
            ' Abrir_Conexao()

            sqlcmd = New MySqlCommand("sp_inserir_serie", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_nome", cbo_Serie.Text)
            sqlcmd.Parameters.AddWithValue("p_id_status", 1)
            sqlcmd.Parameters.AddWithValue("p_id_cliente", cbo_Cliente.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_fabricante", cbo_Fabricante.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_tipo_equipamento", cbo_Tipo_Equipamento.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_modelo", cbo_Modelo.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_ano", cbo_Ano.SelectedValue)
            sqlcmd.Parameters.Add("p_id_serie", MySqlDbType.Int32).Direction = 2
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim id_serie As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_serie").Value)
            'Fechar_Conexao()
            sqlcmd = Nothing
            Return id_serie

        Catch ex As Exception
            ' Fechar_Conexao()
            Return 0
        End Try

    End Function
    Private Sub mnui_Salvar_Click(sender As Object, e As EventArgs) Handles mnui_Salvar.Click

        Dim strObrigatorios As String = ""

        If cbo_Cliente.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Cliente.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Cliente.Text
            End If
            lbl_Cliente.ForeColor = Color.Red
        Else
            lbl_Cliente.ForeColor = Color.Black
        End If

        If cbo_Contato.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Contato.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Contato.Text
            End If
            lbl_Contato.ForeColor = Color.Red
        Else
            lbl_Contato.ForeColor = Color.Black
        End If

        If txt_Texto_Padrao.Text = "" Or
            txt_Observacoes.Text = "" Or
            txt_Prazo_Entrega.Text = "" Or
            txt_Condicao_Pagamento.Text = "" Or
            txt_Garantia.Text = "" Or
            txt_Validade.Text = "" Then

            If MessageBox.Show(text:="Existem campos dos termos vazios. Tem certeza que deseja continar?", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If dtg_Itens.Rows.Count < 1 Then
            MessageBox.Show(Me, "Não é possível salvar propostas sem nenhum item. Adicione ao menos um item e tente novamente", "Proposta sem itens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If Not String.IsNullOrEmpty(txt_Email.Text) And CHECK_EMAIL(txt_Email.Text) = False Then
            MessageBox.Show("O e-mail inserido não é válido", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CONVERT_TO_INTEGER(txt_item_excluido.Text) = 1 Then
            If MessageBox.Show(text:="Você removeu itens dessa proposta. Eles serão excluídos da database permanentemente e não poderão ser recuperados. Tem certeza que deseja continuar?", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If

        If CONVERT_TO_INTEGER(txt_atualizou_prazo.Text) <> 1 And txt_Codigo_Proposta.Visible = True Then
            If MessageBox.Show(text:="Você não atualizou o prazo nenhuma vez, caso não faça isso poderá informar um prazo errado para o cliente. Tem certeza que deseja continuar?", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If
        Salvar_Proposta()
    End Sub

    Private Sub tsmi_Todas_Click(sender As Object, e As EventArgs) Handles tsmi_Todas.Click
        If Strings.Left(tsmi_Todas.Text, 6) = "Exibir" Then
            tsmi_Todas.Text = "Ocultar todas as colunas extras"
            Colunas_Visiveis("todas", True)
        Else
            tsmi_Todas.Text = "Exibir todas as colunas extras"
            Colunas_Visiveis("todas", False)
        End If
    End Sub

    Private Sub tsmi_Outros_Dados_Iniciais_Data_Click(sender As Object, e As EventArgs) Handles tsmi_Outros_Dados_Iniciais.Click
        If Strings.Left(tsmi_Outros_Dados_Iniciais.Text, 6) = "Exibir" Then
            tsmi_Outros_Dados_Iniciais.Text = "Ocultar outros dados iniciais"
            Colunas_Visiveis("dados_iniciais", True)
        Else
            tsmi_Outros_Dados_Iniciais.Text = "Exibir outros dados iniciais"
            Colunas_Visiveis("dados_iniciais", False)
        End If
    End Sub

    Private Sub tsmi_Calculos_Click(sender As Object, e As EventArgs) Handles tsmi_Calculos.Click
        If Strings.Left(tsmi_Calculos.Text, 6) = "Exibir" Then
            tsmi_Calculos.Text = "Ocultar cálculos"
            Colunas_Visiveis("calculos", True)
        Else
            tsmi_Calculos.Text = "Exibir cálculos"
            Colunas_Visiveis("calculos", False)
        End If
    End Sub

    Private Sub tsmi_Quantidade_Estoque_Click(sender As Object, e As EventArgs) Handles tsmi_Quantidade_Estoque.Click
        If Strings.Left(tsmi_Quantidade_Estoque.Text, 6) = "Exibir" Then
            tsmi_Quantidade_Estoque.Text = "Ocultar quantidade de estoque"
            Colunas_Visiveis("estoque", True)
        Else
            tsmi_Quantidade_Estoque.Text = "Exibir quantidade de estoque"
            Colunas_Visiveis("estoque", False)
        End If
    End Sub

    Private Sub cbo_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Cliente.SelectedIndexChanged

        cbo_Contato.DataSource = Nothing
        cbo_Serie.DataSource = Nothing

        If Not String.IsNullOrEmpty(cbo_Cliente.Text) Then

            'mnu_Itens.Enabled = True

            mnui_Adicionar_Item.Enabled = True
            mnui_Editar_Item.Enabled = True
            mnui_Remover_Item.Enabled = True
            mnui_Importar.Enabled = True
            mnui_Exportar.Enabled = True
            mnui_Prazos.Enabled = True
            mnui_Frete.Enabled = True
            tsmi_Desconto.Enabled = True
            mnui_Colunas.Enabled = True
            tsmi_Subir_Ordem.Enabled = True
            tsmi_Abaixar_Ordem.Enabled = True

            dtg_Itens.Enabled = True

            Preencher_ComboBox(cbo_Contato, "tb_contatos", "id_contato", "nome", "id_contato, nome", "id_status=1 AND id_cliente=" & cbo_Cliente.SelectedValue, "nome")
            cbo_Contato.SelectedValue = -1

            Preencher_ComboBox(cbo_Serie, "tb_series", "id_serie", "nome", condicoes:="id_status=1 AND id_cliente=" & cbo_Cliente.SelectedValue, ordenar_por:="nome")
            cbo_Serie.SelectedValue = -1

            Calcula_Valores_Datagrid()

            Retorna_Codigo_Proposta()

            Habilita_Opcoes()

            Dim dtb As New DataTable
            Dim adapter As MySqlDataAdapter


            Try
                Abrir_Conexao()

                adapter = New MySqlDataAdapter("SELECT term.texto_padrao, term.observacoes, term.prazo_entrega, term.condicao_pagamento, term.garantia, term.validade FROM tb_termos_suporte AS tesu
                                LEFT JOIN tb_termos AS term ON tesu.id_termo = term.id_termo WHERE (tesu.id_setor IS NULL OR tesu.id_setor = " & get_id_setor & ") AND tesu.id_cliente = " & cbo_Cliente.SelectedValue, strConexao)

                adapter.Fill(dtb)

                If dtb.Rows.Count > 0 Then
                    Dim rowTermo As DataRow = dtb.Rows(0)

                    txt_Texto_Padrao.Text = rowTermo("texto_padrao")
                    txt_Observacoes.Text = rowTermo("observacoes")
                    txt_Prazo_Entrega.Text = rowTermo("prazo_entrega")
                    txt_Condicao_Pagamento.Text = rowTermo("condicao_pagamento")
                    txt_Garantia.Text = rowTermo("garantia")
                    txt_Validade.Text = rowTermo("validade")

                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
            Finally
                Fechar_Conexao()
            End Try

            If cbo_Carregar_De.SelectedItem = "Cliente (Atual)" Then

                Preencher_ComboBox(cbo_Copiar_Cliente, "tb_termos_suporte AS tesu", "id_termo", "termo", colunas:="DISTINCT tesu.id_termo, term.nome AS termo", condicoes:="(tesu.id_setor = " & get_id_setor & " OR tesu.id_setor IS NULL) AND tesu.id_cliente = " & cbo_Cliente.SelectedValue,
                                   ordenar_por:="clie.nome", juncao_interna:="tb_clientes AS clie ON tesu.id_cliente = clie.id_cliente LEFT JOIN tb_termos AS term ON tesu.id_termo = term.id_termo")

                lbl_Copiar_Cliente.Text = cbo_Cliente.Text
                btn_Confirmar.Left = 460
                cbo_Copiar_Cliente.Width = 303
                lbl_Copiar_Cliente.Visible = True
                cbo_Copiar_Cliente.Visible = True
                lbl_Copiar_Proposta.Visible = False
                cbo_Copiar_Proposta.Visible = False
                lbl_Copiar_Termo.Visible = False
                cbo_Copiar_Termo.Visible = False
                btn_Confirmar.Visible = True

                If cbo_Cliente.SelectedValue > 0 Then
                    cbo_Copiar_Cliente.SelectedValue = cbo_Cliente.SelectedValue
                End If


            End If

        Else
            txt_Codigo_Proposta.Text = ""
            'mnu_Itens.Enabled = False

            mnui_Adicionar_Item.Enabled = False
            mnui_Editar_Item.Enabled = False
            mnui_Remover_Item.Enabled = False
            mnui_Importar.Enabled = False
            mnui_Exportar.Enabled = True
            mnui_Prazos.Enabled = False
            mnui_Frete.Enabled = False
            tsmi_Desconto.Enabled = False
            mnui_Colunas.Enabled = True
            tsmi_Subir_Ordem.Enabled = False
            tsmi_Abaixar_Ordem.Enabled = False

            dtg_Itens.Enabled = False
        End If

    End Sub
    Private Sub cbo_Contato_TextChanged(sender As Object, e As EventArgs) Handles cbo_Contato.TextChanged
        If cbo_Contato.SelectedValue Is Nothing Then
            mkt_Telefone.Text = ""
            txt_Email.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub cbo_Contato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Contato.SelectedIndexChanged

        If cbo_Contato.SelectedValue Is Nothing Then
            mkt_Telefone.Text = ""
            txt_Email.Text = ""
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_retorna_dados_contato", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_contato", CONVERT_TO_INTEGER(cbo_Contato.SelectedValue))
            sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_telefone", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_email", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_pais", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_id_estado", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_id_cidade", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Nome_Contato As String = sqlcmd.Parameters("p_nome").Value.ToString
            Dim Telefone_Contato As String = sqlcmd.Parameters("p_telefone").Value.ToString
            Dim Email_Contato As String = sqlcmd.Parameters("p_email").Value.ToString
            Dim ID_Pais As String = sqlcmd.Parameters("p_id_pais").Value
            Dim ID_Estado As String = sqlcmd.Parameters("p_id_estado").Value
            Dim ID_Cidade As String = sqlcmd.Parameters("p_id_cidade").Value
            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

            cbo_Pais.SelectedValue = CONVERT_TO_INTEGER(ID_Pais)
            cbo_Estado.SelectedValue = CONVERT_TO_INTEGER(ID_Estado)
            cbo_Cidade.SelectedValue = CONVERT_TO_INTEGER(ID_Cidade)

            mkt_Telefone.Text = Telefone_Contato
            txt_Email.Text = Email_Contato

            Select Case Len(REMOVE_MASK(mkt_Telefone))
                Case Is < 10
                    mkt_Telefone.Text = ""
                Case Is = 10
                    mkt_Telefone.Mask = "(00) 0000-0000"
                Case Is = 11
                    mkt_Telefone.Mask = "(00) 00000-0000"
            End Select

            Fechar_Conexao()

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub cbo_Pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Pais.SelectedIndexChanged

        If cbo_Pais.Text <> "" Then
            Preencher_ComboBox(cbo_Estado, "tb_estados", "id_estado", "nome", "id_estado, nome", "id_status=1 AND id_pais=" & cbo_Pais.SelectedValue, "nome")
        End If

    End Sub

    Private Sub cbo_Estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Estado.SelectedIndexChanged

        If cbo_Estado.Text <> "" Then
            Preencher_ComboBox(cbo_Cidade, "tb_cidades", "id_cidade", "nome", "id_cidade, nome", "id_status=1 AND id_pais=" & cbo_Pais.SelectedValue & " AND id_estado=" & cbo_Estado.SelectedValue, "nome")
        End If

    End Sub

    Private Sub mkt_Telefone_Leave(sender As Object, e As EventArgs) Handles mkt_Telefone.Leave

        Select Case Len(REMOVE_MASK(mkt_Telefone))
            Case Is < 10
                mkt_Telefone.Text = ""
            Case Is = 10
                mkt_Telefone.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone.Mask = "(00) 00000-0000"
        End Select

    End Sub

    Private Sub mkt_Telefone_Enter(sender As Object, e As EventArgs) Handles mkt_Telefone.Enter
        mkt_Telefone.Mask = "(00) 00000-0000"
    End Sub

    Private Sub cbo_Fabricante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Fabricante.SelectedIndexChanged

        If cbo_Fabricante.SelectedValue Is Nothing Then
            cbo_Tipo_Equipamento.DataSource = Nothing
            Exit Sub
        End If

        If Serie_Existe = False Then
            Preencher_ComboBox(cbo_Tipo_Equipamento, "tb_tipos_equipamento", "id_tipo_equipamento", "nome", "id_tipo_equipamento, nome", "id_status=1", "nome")
            cbo_Tipo_Equipamento.SelectedValue = -1
        End If

        If String.IsNullOrEmpty(cbo_Serie.Text.ToString) Then
            Preencher_ComboBox(cbo_Ano, "tb_anos", "id_ano", "ano", "id_ano, ano", "id_status=1 AND ano<" & (Now.Year + 2), "ano", agrupar_por:="ano")
            cbo_Ano.SelectedIndex = -1
        Else
            Preencher_Combobox_Ano(cbo_Ano, cbo_Serie.Text, cbo_Fabricante.SelectedValue)

        End If

    End Sub

    Private Sub cbo_Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Tipo_Equipamento.SelectedIndexChanged

        If cbo_Fabricante.SelectedValue Is Nothing Or cbo_Tipo_Equipamento.SelectedValue Is Nothing Then
            cbo_Modelo.DataSource = Nothing
            Exit Sub
        End If

        If Serie_Existe = False Then
            Preencher_ComboBox(cbo_Modelo, "tb_modelos", "id_modelo", "nome", "id_modelo, nome", "id_status=1 AND id_fabricante=" & cbo_Fabricante.SelectedValue & " AND id_tipo_equipamento = " & cbo_Tipo_Equipamento.SelectedValue, "nome")
            cbo_Modelo.SelectedValue = -1
            'Preencher_cbo_Ano()

        End If

    End Sub

    Private Sub Calcula_Valores_Datagrid()

        'Dim ds_taxas As New DataSet
        Dim dtbTaxas As New DataTable
        Dim adapter_taxas As MySqlDataAdapter
        'Dim ds_clientes As New DataSet
        Dim dtbClientes As New DataTable
        Dim adapter_clientes As MySqlDataAdapter
        Dim row_taxas As DataRow
        Dim row_clientes As DataRow
        Dim origem_string As String
        Dim sub_trib_string As String

        'If Not String.IsNullOrEmpty(CONVERT_TO_STRING(GET_DATA_MYSQL("tb_propostas", "data_envio", "id_proposta=" & get_id_proposta))) Then
        '    Exit Sub
        'End If

        Try
            Abrir_Conexao()

            adapter_taxas = New MySqlDataAdapter("SELECT * FROM tb_taxas WHERE data_fim IS NULL AND data_inicio = (SELECT MAX(data_inicio) FROM tb_taxas WHERE data_fim IS NULL)", strConexao)
            adapter_taxas.Fill(dtbTaxas)

            adapter_clientes = New MySqlDataAdapter("SELECT * FROM tb_clientes WHERE id_cliente=" & cbo_Cliente.SelectedValue, strConexao)
            adapter_clientes.Fill(dtbClientes)

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message + ex.StackTrace)
            Exit Sub
        Finally
            Fechar_Conexao()
        End Try

        row_taxas = dtbTaxas.Rows(0)
        row_clientes = dtbClientes.Rows(0)

        Dim dtg_id_tipo_item As Integer
        Dim dtg_id_fornecedor As Integer
        Dim dtg_quantidade_item As Decimal
        Dim dtg_preco_unitario_inicial_item As Decimal
        Dim dtg_percentual_ipi_item As Decimal
        Dim dtg_percentual_icms_item As Decimal
        Dim dtg_mva_item As Decimal
        Dim dtg_valor_st_item As Decimal
        Dim dtg_valor_total_inicial_item As Decimal
        Dim dtg_frete_unitario_item As Decimal
        Dim dtg_desconto_inicial_item As Decimal
        Dim dtg_id_tipo_substituicao_tributaria_item As Integer
        Dim dtg_id_origem_item As Integer
        Dim dtg_preco_apos_desconto_inicial_item As Decimal
        Dim dtg_preco_com_ipi_e_icms_item As Decimal
        Dim dtg_percentual_aliquota_externa_icms_item As Decimal
        Dim dtg_valor_icms_credito_item As Decimal
        Dim dtg_percentual_mva_item As Decimal
        Dim dtg_valor_mva_item As Decimal
        Dim dtg_preco_com_mva_item As Decimal
        Dim dtg_percentual_aliquota_interna_icms_item As Decimal
        Dim dtg_valor_icms_debito_item As Decimal
        Dim dtg_saldo_icms_item As Decimal
        Dim dtg_preco_unitario_para_revendedor_item As Decimal
        Dim dtg_impostos_federais_item As Decimal
        Dim dtg_rateio_despesa_fixa_item As Decimal
        Dim dtg_percentual_lucro_necessario_item As Decimal
        Dim dtg_preco_lista_venda_item As Decimal
        Dim dtg_desconto_final_item As Decimal
        Dim dtg_preco_unitario_final_item As Decimal
        Dim dtg_preco_total_final_item As Decimal

        Dim tax_percentual_aliquota_externa_icms_item As Decimal
        Dim tax_percentual_mva_item As Decimal
        Dim tax_percentual_aliquota_interna_icms_item As Decimal
        Dim tax_impostos_federais_item As Decimal
        Dim tax_rateio_despesa_fixa_item As Decimal
        Dim tax_percentual_lucro_necessario_item As Decimal
        Dim tax_percentual_acrescimo_item As Decimal

        Dim cli_considerar_percentuais_tabela_kion As Integer
        Dim cli_percentual_tabela_kion_1 As Decimal
        Dim cli_percentual_tabela_kion_2 As Decimal
        Dim cli_percentual_tabela_kion_3 As Decimal
        Dim cli_considerar_acrescimo_especifico As Integer
        Dim cli_percentual_acrescimo_especifico As Decimal

        For Each dtb_row As DataRow In dtbItens.Rows

            dtg_id_tipo_item = CONVERT_TO_INTEGER(dtb_row("id_tipo_item").ToString)
            dtg_id_fornecedor = CONVERT_TO_INTEGER(dtb_row("id_fornecedor").ToString)
            dtg_quantidade_item = CONVERT_TO_DECIMAL(dtb_row("quantidade_item").ToString)
            dtg_preco_unitario_inicial_item = CONVERT_TO_DECIMAL(dtb_row("preco_unitario_inicial_item").ToString)
            dtg_percentual_ipi_item = CONVERT_TO_DECIMAL(dtb_row("percentual_ipi_item").ToString)
            dtg_percentual_icms_item = CONVERT_TO_DECIMAL(dtb_row("percentual_icms_item").ToString)
            dtg_mva_item = CONVERT_TO_DECIMAL(dtb_row("mva_item").ToString)
            dtg_valor_st_item = CONVERT_TO_DECIMAL(dtb_row("valor_st_item").ToString)
            dtg_valor_total_inicial_item = CONVERT_TO_DECIMAL(dtb_row("valor_total_inicial_item").ToString)
            dtg_frete_unitario_item = CONVERT_TO_DECIMAL(dtb_row("frete_unitario_item").ToString)
            dtg_desconto_inicial_item = CONVERT_TO_DECIMAL(dtb_row("desconto_inicial_item").ToString)
            dtg_id_tipo_substituicao_tributaria_item = CONVERT_TO_INTEGER(dtb_row("id_tipo_substituicao_tributaria_item").ToString)
            dtg_id_origem_item = CONVERT_TO_INTEGER(dtb_row("id_origem_item").ToString)
            dtg_desconto_final_item = CONVERT_TO_DECIMAL(dtb_row("desconto_final_item").ToString)

            If dtg_id_origem_item = 1 Then
                origem_string = "nacional"
            Else
                origem_string = "importado"
            End If

            If dtg_id_tipo_substituicao_tributaria_item = 1 Then
                sub_trib_string = "revenda_st"
            Else
                sub_trib_string = "outros"
            End If

            tax_percentual_aliquota_externa_icms_item = CONVERT_TO_DECIMAL(row_taxas("percentual_aliquota_externa_icms_item_" & origem_string))
            tax_percentual_mva_item = CONVERT_TO_DECIMAL(row_taxas("percentual_mva_item_" & origem_string))
            tax_percentual_aliquota_interna_icms_item = CONVERT_TO_DECIMAL(row_taxas("percentual_aliquota_interna_icms_item_" & origem_string))
            tax_impostos_federais_item = CONVERT_TO_DECIMAL(row_taxas("impostos_federais_item_" & origem_string))
            tax_rateio_despesa_fixa_item = CONVERT_TO_DECIMAL(row_taxas("rateio_despesa_fixa_item_" & origem_string))
            tax_percentual_lucro_necessario_item = CONVERT_TO_DECIMAL(row_taxas("percentual_lucro_necessario_item_" & sub_trib_string & "_" & origem_string))
            tax_percentual_acrescimo_item = CONVERT_TO_DECIMAL(row_taxas("percentual_acrescimo_item_" & origem_string))

            cli_percentual_tabela_kion_1 = CONVERT_TO_DECIMAL(row_clientes("percentual_tabela_kion_1"))
            cli_percentual_tabela_kion_2 = CONVERT_TO_DECIMAL(row_clientes("percentual_tabela_kion_2"))
            cli_percentual_tabela_kion_3 = CONVERT_TO_DECIMAL(row_clientes("percentual_tabela_kion_3"))
            cli_percentual_acrescimo_especifico = CONVERT_TO_DECIMAL(row_clientes("percentual_acrescimo_especifico"))

            If dtg_id_fornecedor = 1 Then
                dtg_preco_apos_desconto_inicial_item = dtg_preco_unitario_inicial_item * (1 + tax_percentual_acrescimo_item) * (1 - dtg_desconto_inicial_item)
            Else
                dtg_preco_apos_desconto_inicial_item = dtg_preco_unitario_inicial_item * (1 - dtg_desconto_inicial_item)
            End If

            dtg_preco_com_ipi_e_icms_item = dtg_preco_apos_desconto_inicial_item * (1 + dtg_percentual_ipi_item)
            dtg_percentual_aliquota_externa_icms_item = tax_percentual_aliquota_externa_icms_item
            dtg_percentual_aliquota_interna_icms_item = tax_percentual_aliquota_interna_icms_item

            dtg_impostos_federais_item = tax_impostos_federais_item
            dtg_rateio_despesa_fixa_item = tax_rateio_despesa_fixa_item
            dtg_percentual_lucro_necessario_item = tax_percentual_lucro_necessario_item

            If sub_trib_string = "revenda_st" Then
                dtg_valor_icms_credito_item = dtg_preco_apos_desconto_inicial_item * dtg_percentual_aliquota_externa_icms_item
                dtg_percentual_mva_item = tax_percentual_mva_item
                dtg_valor_mva_item = dtg_preco_com_ipi_e_icms_item * dtg_percentual_mva_item
                dtg_preco_com_mva_item = dtg_preco_com_ipi_e_icms_item + dtg_valor_mva_item
                dtg_valor_icms_debito_item = dtg_preco_com_mva_item * dtg_percentual_aliquota_interna_icms_item
                dtg_saldo_icms_item = dtg_valor_icms_debito_item - dtg_valor_icms_credito_item
                dtg_preco_unitario_para_revendedor_item = dtg_preco_com_ipi_e_icms_item + dtg_saldo_icms_item
                dtg_preco_lista_venda_item = DIVIDE(dtg_preco_unitario_para_revendedor_item, (1 - dtg_percentual_lucro_necessario_item - dtg_impostos_federais_item - dtg_rateio_despesa_fixa_item))
            Else
                dtg_valor_icms_credito_item = 0
                dtg_percentual_mva_item = 0
                dtg_valor_mva_item = 0
                dtg_preco_com_mva_item = dtg_preco_com_ipi_e_icms_item + dtg_valor_mva_item
                dtg_valor_icms_debito_item = dtg_preco_com_ipi_e_icms_item * (dtg_percentual_aliquota_interna_icms_item - dtg_percentual_aliquota_externa_icms_item)
                dtg_saldo_icms_item = dtg_valor_icms_debito_item
                dtg_preco_unitario_para_revendedor_item = dtg_preco_com_ipi_e_icms_item
                dtg_preco_lista_venda_item = DIVIDE((dtg_preco_unitario_para_revendedor_item - dtg_preco_apos_desconto_inicial_item * dtg_percentual_aliquota_interna_icms_item), (1 - dtg_percentual_lucro_necessario_item - dtg_impostos_federais_item - dtg_percentual_aliquota_interna_icms_item - dtg_rateio_despesa_fixa_item))
            End If

            If dtg_id_tipo_substituicao_tributaria_item = 3 Or dtg_id_tipo_item <> 1 Then

                If cli_considerar_acrescimo_especifico = 1 Then
                    dtg_preco_unitario_final_item = dtg_preco_unitario_inicial_item * (1 - dtg_desconto_final_item) * (1 + cli_percentual_acrescimo_especifico)
                Else
                    dtg_preco_unitario_final_item = dtg_preco_unitario_inicial_item * (1 - dtg_desconto_final_item)
                End If

            Else
                If dtg_id_fornecedor = 1 And cli_considerar_percentuais_tabela_kion = 1 Then

                    If cli_considerar_acrescimo_especifico = 1 Then
                        dtg_preco_unitario_final_item = (((DIVIDE(((DIVIDE(((dtg_preco_unitario_inicial_item + (dtg_preco_unitario_inicial_item * tax_percentual_acrescimo_item)) * (1 - dtg_desconto_inicial_item)), cli_percentual_tabela_kion_1)) * cli_percentual_tabela_kion_2), cli_percentual_tabela_kion_3)) + ((DIVIDE(((DIVIDE(((dtg_preco_unitario_inicial_item + (dtg_preco_unitario_inicial_item * tax_percentual_acrescimo_item)) * (1 - dtg_desconto_inicial_item)), cli_percentual_tabela_kion_1)) * cli_percentual_tabela_kion_2), cli_percentual_tabela_kion_3)) * cli_percentual_acrescimo_especifico)) * (1 - dtg_desconto_final_item)) + dtg_frete_unitario_item
                    Else
                        dtg_preco_unitario_final_item = (((DIVIDE(((DIVIDE(((dtg_preco_unitario_inicial_item + (dtg_preco_unitario_inicial_item * tax_percentual_acrescimo_item)) * (1 - dtg_desconto_inicial_item)), cli_percentual_tabela_kion_1)) * cli_percentual_tabela_kion_2), cli_percentual_tabela_kion_3)) + ((DIVIDE(((DIVIDE(((dtg_preco_unitario_inicial_item + (dtg_preco_unitario_inicial_item * tax_percentual_acrescimo_item)) * (1 - dtg_desconto_inicial_item)), cli_percentual_tabela_kion_1)) * cli_percentual_tabela_kion_2), cli_percentual_tabela_kion_3)) * 0)) * (1 - dtg_desconto_final_item)) + dtg_frete_unitario_item
                    End If

                Else

                    If cli_considerar_acrescimo_especifico = 1 Then
                        dtg_preco_unitario_final_item = (dtg_preco_lista_venda_item * (1 - dtg_desconto_final_item) * (1 + cli_percentual_acrescimo_especifico)) + dtg_frete_unitario_item
                    Else
                        dtg_preco_unitario_final_item = dtg_preco_lista_venda_item * (1 - dtg_desconto_final_item) + dtg_frete_unitario_item
                    End If

                End If
            End If

            dtg_preco_total_final_item = dtg_preco_unitario_final_item * dtg_quantidade_item

            If dtg_id_tipo_item = 1 Then

                dtb_row("preco_apos_desconto_inicial_item") = dtg_preco_apos_desconto_inicial_item
                dtb_row("preco_com_ipi_e_icms_item") = dtg_preco_com_ipi_e_icms_item
                dtb_row("percentual_aliquota_externa_icms_item") = dtg_percentual_aliquota_externa_icms_item
                dtb_row("percentual_aliquota_interna_icms_item") = dtg_percentual_aliquota_interna_icms_item
                dtb_row("impostos_federais_item") = dtg_impostos_federais_item
                dtb_row("rateio_despesa_fixa_item") = dtg_rateio_despesa_fixa_item
                dtb_row("percentual_lucro_necessario_item") = dtg_percentual_lucro_necessario_item
                dtb_row("valor_icms_credito_item") = dtg_valor_icms_credito_item
                dtb_row("percentual_mva_item") = dtg_percentual_mva_item
                dtb_row("valor_mva_item") = dtg_valor_mva_item
                dtb_row("preco_com_mva_item") = dtg_preco_com_mva_item
                dtb_row("valor_icms_debito_item") = dtg_valor_icms_debito_item
                dtb_row("saldo_icms_item") = dtg_saldo_icms_item
                dtb_row("preco_unitario_para_revendedor_item") = dtg_preco_unitario_para_revendedor_item
                dtb_row("preco_lista_venda_item") = dtg_preco_lista_venda_item
                dtb_row("preco_unitario_final_item") = dtg_preco_unitario_final_item
                dtb_row("preco_total_final_item") = dtg_preco_total_final_item

            Else

                dtb_row("preco_unitario_final_item") = dtg_preco_unitario_inicial_item - (dtg_preco_unitario_inicial_item * dtg_desconto_final_item)
                dtb_row("preco_total_final_item") = dtg_preco_unitario_inicial_item - (dtg_preco_unitario_inicial_item * dtg_desconto_final_item)

            End If

        Next

        Atualiza_Statusbar()

    End Sub

    Private Sub tsmi_Kion_Click(sender As Object, e As EventArgs) Handles tsmi_Importar_Kion.Click

        Dim form = New Importar_Pecas

        get_id_fornecedor = 1

        form.ShowDialog()

        Calcula_Valores_Datagrid()
        Formatar_Datagrid()

    End Sub

    Private Sub tsmi_TVH_Click(sender As Object, e As EventArgs) Handles tsmi_Importar_TVH.Click
        Dim form = New Importar_Pecas

        get_id_fornecedor = 2

        form.ShowDialog()

        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub tsmi_Peca_Click(sender As Object, e As EventArgs) Handles tsmi_Peca.Click

        Dim form = New Controle_Item
        get_id_tipo_item = 1
        get_linha_item = -1

        form.ShowDialog()

        Calcula_Valores_Datagrid()

    End Sub

    Private Sub tsmi_Servico_Click(sender As Object, e As EventArgs) Handles tsmi_Servico.Click
        Dim form = New Controle_Item
        get_id_tipo_item = 2
        get_linha_item = -1

        form.ShowDialog()

        Calcula_Valores_Datagrid()

    End Sub

    Private Sub tsmi_Deslocamento_Click(sender As Object, e As EventArgs) Handles tsmi_Deslocamento.Click
        Dim form = New Controle_Item
        get_id_tipo_item = 3
        get_linha_item = -1
        get_id_cliente = cbo_Cliente.SelectedValue

        form.ShowDialog()

        Calcula_Valores_Datagrid()

    End Sub

    Private Sub tsmi_Apenas_Completo_Click(sender As Object, e As EventArgs) Handles tsmi_Apenas_Completo.Click
        Atualizar_Estoque("Codigo completo")
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Sub tsmi_Apenas_Abreviado_Click(sender As Object, e As EventArgs) Handles tsmi_Apenas_Abreviado.Click
        Atualizar_Estoque("Codigo abreviado")
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Sub tsmi_Por_Peca_Click(sender As Object, e As EventArgs) Handles tsmi_Por_Peca.Click
        Atualizar_Estoque("Por peca")
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
    Sub Habilita_Opcoes()

        If dtg_Itens.CurrentRow IsNot Nothing Then

            If mnui_Adicionar_Item.Enabled = True Then
                mnui_Editar_Item.Enabled = True
                mnui_Remover_Item.Enabled = True
                ' mnui_Prazos.Enabled = True
                tsmi_Subir_Ordem.Enabled = True
                tsmi_Abaixar_Ordem.Enabled = True
            End If
        Else

                mnui_Editar_Item.Enabled = False
            mnui_Remover_Item.Enabled = False
            'mnui_Prazos.Enabled = False
            tsmi_Subir_Ordem.Enabled = False
            tsmi_Abaixar_Ordem.Enabled = False
        End If

    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        Habilita_Opcoes()
    End Sub

    Private Sub mnui_Editar_Item_Click(sender As Object, e As EventArgs) Handles mnui_Editar_Item.Click

        If dtbItens.Rows.Count < 1 Then
            Exit Sub
        End If

        Dim form = New Controle_Item
        get_id_tipo_item = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens.SelectedRows(0).Cells("id_tipo_item").Value))
        get_linha_item = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens.SelectedRows(0).Index))

        form.ShowDialog()

        Calcula_Valores_Datagrid()


    End Sub

    Private Sub mnui_Remover_Item_Click(sender As Object, e As EventArgs) Handles mnui_Remover_Item.Click

        If dtbItens.Rows.Count < 1 Then
            Exit Sub
        End If

        If get_id_proposta > 0 And Strings.InStr(txt_Codigo_Proposta.Text, "REV") < 1 Then
            If MessageBox.Show(text:="Tem certeza que deseja remover o item? O processo não poderá ser desfeito", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If

        get_linha_item = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens.SelectedRows(0).Index))

        If CONVERT_TO_STRING(txt_item_excluido.Text) <> CONVERT_TO_STRING(1) Then
            Dim drow As DataRow = dtbItens.Rows(get_linha_item)
            If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_item_proposta"))) <> 0 Then
                txt_item_excluido.Text = 1
            End If
        End If

        dtbItens.Rows.RemoveAt(get_linha_item)
        'dtbItens.Rows(get_linha_item).Delete()

    End Sub
    Private Sub tsmi_Subir_Ordem_Click(sender As Object, e As EventArgs) Handles tsmi_Subir_Ordem.Click

        If dtbItens.Rows.Count < 1 Then
            Exit Sub
        End If

        get_linha_item = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens.SelectedRows(0).Index))

        If get_linha_item > 0 Then

            DataTableMoveRow(dtbItens, get_linha_item, get_linha_item - 1)

            dtg_Itens.Rows(get_linha_item - 1).Selected = True

            'MessageBox.Show()

            EnsureVisibleRow(dtg_Itens, get_linha_item - 1)
            '  dtg_Itens.FirstDisplayedScrollingRowIndex = dtg_Itens.SelectedRows(0).Index

        End If
        'dtg_Itens.ClearSelection()
        'dtg_Itens.CurrentCell = dtg_Itens.Rows(get_linha_item - 1).Cells(0)
        'dtg_Itens.Rows(get_linha_item - 1).Selected = True

    End Sub

    Private Sub tsmi_Abaixar_Ordem_Click(sender As Object, e As EventArgs) Handles tsmi_Abaixar_Ordem.Click

        If dtbItens.Rows.Count < 1 Then
            Exit Sub
        End If

        get_linha_item = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens.SelectedRows(0).Index))

        If get_linha_item < dtbItens.Rows.Count - 1 Then

            DataTableMoveRow(dtbItens, get_linha_item, get_linha_item + 2)

            dtg_Itens.Rows(get_linha_item + 1).Selected = True
            EnsureVisibleRow(dtg_Itens, get_linha_item + 1)
            'dtg_Itens.FirstDisplayedScrollingRowIndex = dtg_Itens.SelectedRows(0).Index


        End If
        'dtg_Itens.ClearSelection()
        'dtg_Itens.CurrentCell = dtg_Itens.Rows(get_linha_item - 1).Cells(0)
        'dtg_Itens.Rows(get_linha_item - 1).Selected = True

    End Sub

    Sub DataTableMoveRow(ByRef dt As DataTable, ByVal FromIndex As Integer, ByVal ToIndex As Integer)
        dtbItens.DefaultView.Sort = String.Empty
        Dim oldRow As DataRow = dt.Rows(FromIndex)
        Dim newRow As DataRow = dt.NewRow()
        newRow.ItemArray = oldRow.ItemArray
        dt.Rows.InsertAt(newRow, ToIndex)
        dt.Rows.Remove(oldRow)
    End Sub

    Private Shared Sub EnsureVisibleRow(ByVal view As DataGridView, ByVal rowToShow As Integer)
        If rowToShow >= 0 AndAlso rowToShow < view.RowCount Then
            Dim countVisible = view.DisplayedRowCount(False)
            Dim firstVisible = view.FirstDisplayedScrollingRowIndex

            If rowToShow < firstVisible Then
                view.FirstDisplayedScrollingRowIndex = rowToShow
            ElseIf rowToShow >= firstVisible + countVisible Then
                view.FirstDisplayedScrollingRowIndex = rowToShow - countVisible + 1
            End If
        End If
    End Sub

    Private Sub tsmi_Inserir_Frete_Valor_Igual_Click(sender As Object, e As EventArgs) Handles tsmi_Inserir_Frete_Valor_Igual.Click

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças na proposta informada. Adicione ou importe peças para poder definir o frete", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Dim form = New Inserir_Frete
        get_tipo_inserir_frete = 1
        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub tsmi_Valor_Dividido_Por_Preco_Click(sender As Object, e As EventArgs) Handles tsmi_Valor_Dividido_Por_Preco.Click

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças na proposta informada. Adicione ou importe peças para poder definir o frete", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Dim form = New Inserir_Frete
        get_tipo_inserir_frete = 2
        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub tsmi_Valor_Dividido_Por_Quantidade_Click(sender As Object, e As EventArgs) Handles tsmi_Valor_Dividido_Por_Quantidade.Click

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças na proposta informada. Adicione ou importe peças para poder definir o frete", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Dim form = New Inserir_Frete
        get_tipo_inserir_frete = 3
        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub PorValorTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorValorTotalToolStripMenuItem.Click

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças na proposta informada. Adicione ou importe peças para poder definir o frete", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Dim form = New Inserir_Frete
        get_tipo_inserir_frete = 4
        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub
    Private Sub dtg_Itens_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtg_Itens.CellMouseDown
        If dtp_Data_Faturamento.Visible = True Then
            dtg_Itens.ContextMenuStrip = Nothing
            If e.Button = MouseButtons.Right And e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                If dtg_Itens.Columns(e.ColumnIndex).Name = "nome4" Or dtg_Itens.Columns(e.ColumnIndex).Name = "nome5" Or dtg_Itens.Columns(e.ColumnIndex).Name = "nome6" Then
                    dtg_Itens.CurrentCell = dtg_Itens(e.ColumnIndex, e.RowIndex)
                    Criar_Menu_Botao_Direito(e.RowIndex, dtg_Itens.Columns(e.ColumnIndex).Name)
                    dtg_Itens.ContextMenuStrip = cms_Datagrid
                End If


                If dtg_Itens.Columns(e.ColumnIndex).Name = "nome7" Or dtg_Itens.Columns(e.ColumnIndex).Name = "nome8" Then
                    If CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens("id_tipo_item", e.RowIndex).Value)) = 1 Then
                        dtg_Itens.CurrentCell = dtg_Itens(e.ColumnIndex, e.RowIndex)
                        Criar_Menu_Botao_Direito(e.RowIndex, dtg_Itens.Columns(e.ColumnIndex).Name)
                        dtg_Itens.ContextMenuStrip = cms_Datagrid
                    End If
                End If


            End If
        End If
    End Sub
    Sub Criar_Menu_Botao_Direito(ByVal linha As Long, ByVal coluna As String)

        Dim dtbSeletor As New DataTable
        Dim adapter_seletor As MySqlDataAdapter
        Dim cmStr As String = ""
        Dim colnome As String = ""
        Dim colref As String = ""
        Dim colid As String = ""

        Select Case coluna
            Case "nome4"
                cmStr = "SELECT id_status, nome FROM tb_status"
                colnome = "nome"
                colref = linha & ",id_status,nome4"
                colid = "id_status"
            Case "nome5"
                cmStr = "SELECT id_status_aprovacao, nome FROM tb_status_aprovacao WHERE id_status=1"
                colnome = "nome"
                colref = linha & ",id_status_aprovacao,nome5"
                colid = "id_status_aprovacao"
            Case "nome6"
                cmStr = "SELECT id_justificativa_aprovacao, nome FROM tb_justificativas_aprovacao WHERE id_status=1"
                colnome = "nome"
                colref = linha & ",id_justificativa_aprovacao,nome6"
                colid = "id_justificativa_aprovacao"
            Case "nome7"
                cmStr = "SELECT id_conjunto, nome FROM tb_conjuntos WHERE id_status=1"
                colnome = "nome"
                colref = linha & ",id_conjunto,nome7"
                colid = "id_conjunto"
            Case "nome8"
                If String.IsNullOrEmpty(CONVERT_TO_STRING(dtg_Itens("id_conjunto", CONVERT_TO_INTEGER(linha)).Value)) Then
                    cmStr = "SELECT id_especificacao, nome FROM tb_especificacoes WHERE id_status=1"
                Else
                    cmStr = "SELECT id_especificacao, nome FROM tb_especificacoes WHERE id_status=1 AND id_conjunto = " & dtg_Itens("id_conjunto", CONVERT_TO_INTEGER(linha)).Value
                End If
                colnome = "nome"
                colref = linha & ",id_especificacao,nome8"
                colid = "id_especificacao"
        End Select

        Try
            Abrir_Conexao()

            tsmi_Apenas_Este_Item.DropDownItems.Clear()
            tsmi_Todos_Itens.DropDownItems.Clear()

            If coluna = "nome7" Or coluna = "nome8" Then
                Dim menuUnico1 As New ToolStripMenuItem(text:="Limpar")
                Dim menuTodos1 As New ToolStripMenuItem(text:="Limpar")

                menuUnico1.Tag = linha & "," & colid
                menuTodos1.Tag = linha & "," & colid

                'Click handler to your menuItem.
                AddHandler menuUnico1.Click, AddressOf Me.LimparUnico_Click 'CLICK EVENT HANDLER ALSO UNIQUE
                AddHandler menuTodos1.Click, AddressOf Me.LimparTodos_Click 'CLICK EVENT HANDLER ALSO UNIQUE

                'Add menuItem to ToolStripMenu
                tsmi_Apenas_Este_Item.DropDownItems.Add(menuUnico1)
                tsmi_Todos_Itens.DropDownItems.Add(menuTodos1)
            End If

            adapter_seletor = New MySqlDataAdapter(cmStr, strConexao)
            adapter_seletor.Fill(dtbSeletor)

            For Each row_seletor As DataRow In dtbSeletor.Rows
                Dim menuUnico As New ToolStripMenuItem(text:="menuUnico_" & row_seletor(colnome))
                Dim menuTodos As New ToolStripMenuItem(text:="menuTodos_" & row_seletor(colnome))

                menuUnico.Text = row_seletor(colnome)
                menuUnico.Tag = colref & "," & row_seletor(colid) & "," & row_seletor(colnome)

                menuTodos.Text = row_seletor(colnome)
                menuTodos.Tag = colref & "," & row_seletor(colid) & "," & row_seletor(colnome)

                'Click handler to your menuItem.
                AddHandler menuUnico.Click, AddressOf Me.AlterarUnico_Click 'CLICK EVENT HANDLER ALSO UNIQUE
                AddHandler menuTodos.Click, AddressOf Me.AlterarTodos_Click 'CLICK EVENT HANDLER ALSO UNIQUE

                'Add menuItem to ToolStripMenu
                tsmi_Apenas_Este_Item.DropDownItems.Add(menuUnico)
                tsmi_Todos_Itens.DropDownItems.Add(menuTodos)
            Next

        Catch ex As Exception

        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub AlterarUnico_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim vct() As String = Split(sender.Tag, ",")

            Dim drow As DataRow = dtbItens.Rows(vct(0))

            ' For Each drow As DataRow In dtbItens.Rows()

            Select Case vct(1)

                Case "id_conjunto"

                    If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_tipo_item"))) = 1 Then
                        drow(vct(1)) = vct(3)
                        drow(vct(2)) = vct(4)
                        drow("id_especificacao") = DBNull.Value
                        drow("nome8") = DBNull.Value
                    End If

                Case "id_especificacao"

                    If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_tipo_item"))) = 1 Then
                        drow(vct(1)) = vct(3)
                        drow(vct(2)) = vct(4)

                        If String.IsNullOrEmpty(CONVERT_TO_STRING(drow("id_conjunto"))) Then
                            drow("id_conjunto") = GET_DATA_MYSQL("tb_especificacoes", "id_conjunto", "id_especificacao = " & vct(3))
                            drow("nome7") = GET_DATA_MYSQL("tb_conjuntos", "nome", "id_conjunto = " & drow("id_conjunto"))
                        End If

                    End If

                Case "id_status_aprovacao"

                    drow(vct(1)) = vct(3)
                    drow(vct(2)) = vct(4)

                    If vct(3) = 1 Then
                        drow("data_aprovacao_item") = Now
                    Else
                        drow("data_aprovacao_item") = DBNull.Value
                    End If

                Case Else
                    drow(vct(1)) = vct(3)
                    drow(vct(2)) = vct(4)
            End Select


            ' Next

            'Call Define_DataGridViewCombobox()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub AlterarTodos_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Dim vct() As String = Split(sender.Tag, ",")

            'Dim drow As DataRow = dtbItens.Rows(vct(0))

            For Each drow As DataRow In dtbItens.Rows()

                Select Case vct(1)

                    Case "id_conjunto"

                        If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_tipo_item"))) = 1 Then
                            drow(vct(1)) = vct(3)
                            drow(vct(2)) = vct(4)
                            drow("id_especificacao") = DBNull.Value
                            drow("nome8") = DBNull.Value
                        End If

                    Case "id_especificacao"

                        If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_tipo_item"))) = 1 Then
                            drow(vct(1)) = vct(3)
                            drow(vct(2)) = vct(4)
                            drow("id_conjunto") = GET_DATA_MYSQL("tb_especificacoes", "id_conjunto", "id_especificacao = " & vct(3))
                            drow("nome7") = GET_DATA_MYSQL("tb_conjuntos", "nome", "id_conjunto = " & drow("id_conjunto"))
                        End If

                    Case "id_status_aprovacao"

                        drow(vct(1)) = vct(3)
                        drow(vct(2)) = vct(4)

                        If vct(3) = 1 Then
                            drow("data_aprovacao_item") = Now
                        Else
                            drow("data_aprovacao_item") = DBNull.Value
                        End If

                    Case Else
                        drow(vct(1)) = vct(3)
                        drow(vct(2)) = vct(4)
                End Select


            Next

            'Call Define_DataGridViewCombobox()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimparUnico_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim vct() As String = Split(sender.Tag, ",")

            Dim drow As DataRow = dtbItens.Rows(vct(0))

            ' For Each drow As DataRow In dtbItens.Rows()

            Select Case vct(1)

                Case "id_conjunto"

                    drow("id_conjunto") = DBNull.Value
                    drow("nome7") = DBNull.Value
                    drow("id_especificacao") = DBNull.Value
                    drow("nome8") = DBNull.Value

                Case "id_especificacao"

                    drow("id_especificacao") = DBNull.Value
                    drow("nome8") = DBNull.Value

            End Select


            ' Next

            'Call Define_DataGridViewCombobox()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimparTodos_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Dim vct() As String = Split(sender.Tag, ",")

            'Dim drow As DataRow = dtbItens.Rows(vct(0))

            For Each drow As DataRow In dtbItens.Rows()

                Select Case vct(1)

                    Case "id_conjunto"

                        drow("id_conjunto") = DBNull.Value
                        drow("nome7") = DBNull.Value
                        drow("id_especificacao") = DBNull.Value
                        drow("nome8") = DBNull.Value

                    Case "id_especificacao"

                        drow("id_especificacao") = DBNull.Value
                        drow("nome8") = DBNull.Value

                End Select


            Next

            'Call Define_DataGridViewCombobox()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dtp_Data_Faturamento_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Faturamento.ValueChanged
        If dtp_Data_Faturamento.Checked = True Then
            nud_Nota_Fiscal.Enabled = True
            nud_Valor_Faturamento.Enabled = True
        Else
            nud_Nota_Fiscal.Enabled = False
            nud_Valor_Faturamento.Enabled = False
        End If
    End Sub

    Private Sub Atualiza_Ultima_Proposta(id_proposta As Integer, id_ultima_proposta As Integer)

        Dim sqlcmd2 As MySqlCommand

        Try
            'Abrir_Conexao()
            sqlcmd2 = New MySqlCommand("sp_atualiza_ultima_proposta", strConexao)
            sqlcmd2.CommandType = CommandType.StoredProcedure
            sqlcmd2.Parameters.AddWithValue("p_id_proposta", id_proposta)
            sqlcmd2.Parameters.AddWithValue("p_id_ultima_proposta", id_ultima_proposta)
            sqlcmd2.Parameters.Add("p_mensagem", MySqlDbType.VarChar).Direction = 2
            sqlcmd2.ExecuteNonQuery()

            Dim Mensagem_Retorno As String = CONVERT_TO_STRING(sqlcmd2.Parameters("p_mensagem").Value)

            'txt_Codigo_Proposta.Text = Format(Now, "ddMMyyyy") & CONVERT_TO_LETTER(Contagem_Proposta + 1)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar última proposta. Detalhes: " + ex.Message + ex.StackTrace)
        Finally
            'Fechar_Conexao()
        End Try

    End Sub

    Sub Salvar_Proposta()

        Dim sqlcmd As MySqlCommand
        Dim id_proposta_real As Integer

        Try
            Abrir_Conexao()

            'Verifica se o id é 0 e portanto deverá ser inserida uma nova proposta
            If get_id_proposta = 0 Then
                sqlcmd = New MySqlCommand("sp_inserir_proposta", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_data_insercao", Now)
                sqlcmd.Parameters.AddWithValue("p_id_usuario_insercao", get_id_usuario)
                sqlcmd.Parameters.Add("p_id_proposta", MySqlDbType.Int32).Direction = 2
            Else
                'Como o id não é 0 essa proposta já existe, então ela será editada
                sqlcmd = New MySqlCommand("sp_editar_proposta", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_proposta", get_id_proposta)
                sqlcmd.Parameters.AddWithValue("p_data_edicao", Now)
                sqlcmd.Parameters.AddWithValue("p_id_usuario_edicao", get_id_usuario)
            End If

            sqlcmd.Parameters.AddWithValue("p_data_solicitacao", dtp_Data_Solicitacao.Value)

            If dtp_Data_Envio_Faturamento.Checked = True Then
                sqlcmd.Parameters.AddWithValue("p_data_envio_faturamento", dtp_Data_Envio_Faturamento.Value)
            Else
                sqlcmd.Parameters.Add("p_data_envio_faturamento", MySqlDbType.DateTime).Value = DBNull.Value
            End If

            If dtp_Data_Faturamento.Checked = True Then
                sqlcmd.Parameters.AddWithValue("p_data_faturamento", dtp_Data_Faturamento.Value)
                sqlcmd.Parameters.AddWithValue("p_nota_fiscal", nud_Nota_Fiscal.Value)
                sqlcmd.Parameters.AddWithValue("p_valor_faturamento", nud_Valor_Faturamento.Value)
            Else
                sqlcmd.Parameters.Add("p_data_faturamento", MySqlDbType.DateTime).Value = DBNull.Value
                sqlcmd.Parameters.Add("p_nota_fiscal", MySqlDbType.Int32).Value = DBNull.Value
                sqlcmd.Parameters.Add("p_valor_faturamento", MySqlDbType.Decimal).Value = DBNull.Value
            End If

            sqlcmd.Parameters.AddWithValue("p_id_filial", txt_id_filial.Text)
            sqlcmd.Parameters.AddWithValue("p_id_cliente", cbo_Cliente.SelectedValue)

            Dim id_contato_real As Integer = Retorna_ID_Contato()

            If Not String.IsNullOrEmpty(cbo_Contato.Text) And id_contato_real <> 0 Then
                sqlcmd.Parameters.AddWithValue("p_id_contato", id_contato_real)
            Else
                sqlcmd.Parameters.Add("p_id_contato", MySqlDbType.Int32).Value = DBNull.Value
            End If

            Dim id_serie_real As Integer = Retorna_ID_Serie()

            If Not String.IsNullOrEmpty(cbo_Serie.Text) And id_serie_real <> 0 Then
                sqlcmd.Parameters.AddWithValue("p_id_serie", id_serie_real)
            Else
                sqlcmd.Parameters.Add("p_id_serie", MySqlDbType.Int32).Value = DBNull.Value
            End If

            sqlcmd.Parameters.AddWithValue("p_codigo_proposta", txt_Codigo_Proposta.Text)
            sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_prioridade", cbo_Prioridade.SelectedValue)

            If Not IsNothing(cbo_Fabricante.SelectedValue) Then
                sqlcmd.Parameters.AddWithValue("p_id_fabricante", cbo_Fabricante.SelectedValue)
            Else
                sqlcmd.Parameters.Add("p_id_fabricante", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not IsNothing(cbo_Tipo_Equipamento.SelectedValue) Then
                sqlcmd.Parameters.AddWithValue("p_id_tipo_equipamento", cbo_Tipo_Equipamento.SelectedValue)
            Else
                sqlcmd.Parameters.Add("p_id_tipo_equipamento", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not IsNothing(cbo_Modelo.SelectedValue) Then
                sqlcmd.Parameters.AddWithValue("p_id_modelo", cbo_Modelo.SelectedValue)
            Else
                sqlcmd.Parameters.Add("p_id_modelo", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not IsNothing(cbo_Ano.SelectedValue) Then
                sqlcmd.Parameters.AddWithValue("p_id_ano", cbo_Ano.SelectedValue)
            Else
                sqlcmd.Parameters.Add("p_id_ano", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not IsNothing(nud_Horimetro.Value) Then
                sqlcmd.Parameters.AddWithValue("p_horimetro", nud_Horimetro.Value)
            Else
                sqlcmd.Parameters.Add("p_horimetro", MySqlDbType.Decimal).Value = DBNull.Value
            End If

            If Not IsNothing(nud_Ordem_Servico.Value) Then
                sqlcmd.Parameters.AddWithValue("p_ordem_servico", nud_Ordem_Servico.Value)
            Else
                sqlcmd.Parameters.Add("p_ordem_servico", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(tssl_Envio.Tag) Then
                sqlcmd.Parameters.AddWithValue("p_data_envio", tssl_Envio.Tag)
            Else
                sqlcmd.Parameters.Add("p_data_envio", MySqlDbType.DateTime).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(tssl_Origem.Tag) Then
                sqlcmd.Parameters.AddWithValue("p_id_proposta_origem", tssl_Origem.Tag)
            Else
                sqlcmd.Parameters.Add("p_id_proposta_origem", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(tssl_Revisao.Tag) Then
                sqlcmd.Parameters.AddWithValue("p_id_ultima_proposta", tssl_Revisao.Tag)
            Else
                sqlcmd.Parameters.Add("p_id_ultima_proposta", MySqlDbType.Int32).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Comentarios.Text) Then
                sqlcmd.Parameters.AddWithValue("p_comentarios", CONVERT_TO_STRING(txt_Comentarios.Text))
            Else
                sqlcmd.Parameters.Add("p_comentarios", MySqlDbType.Text).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Texto_Padrao.Text) Then
                sqlcmd.Parameters.AddWithValue("p_texto_padrao", CONVERT_TO_STRING(txt_Texto_Padrao.Text))
            Else
                sqlcmd.Parameters.Add("p_texto_padrao", MySqlDbType.Text).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Observacoes.Text) Then
                sqlcmd.Parameters.AddWithValue("p_observacoes", CONVERT_TO_STRING(txt_Observacoes.Text))
            Else
                sqlcmd.Parameters.Add("p_observacoes", MySqlDbType.Text).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Prazo_Entrega.Text) Then
                sqlcmd.Parameters.AddWithValue("p_prazo_entrega", CONVERT_TO_STRING(txt_Prazo_Entrega.Text))
            Else
                sqlcmd.Parameters.Add("p_prazo_entrega", MySqlDbType.Text).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Condicao_Pagamento.Text) Then
                sqlcmd.Parameters.AddWithValue("p_condicao_pagamento", CONVERT_TO_STRING(txt_Condicao_Pagamento.Text))
            Else
                sqlcmd.Parameters.Add("p_condicao_pagamento", MySqlDbType.Text).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Garantia.Text) Then
                sqlcmd.Parameters.AddWithValue("p_garantia", CONVERT_TO_STRING(txt_Garantia.Text))
            Else
                sqlcmd.Parameters.Add("p_garantia", MySqlDbType.Text).Value = DBNull.Value
            End If

            If Not String.IsNullOrEmpty(txt_Validade.Text) Then
                sqlcmd.Parameters.AddWithValue("p_validade", CONVERT_TO_STRING(txt_Validade.Text))
            Else
                sqlcmd.Parameters.Add("p_validade", MySqlDbType.Text).Value = DBNull.Value
            End If

            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            'Verifica se a proposta é uma revisão e caso verdadeiro atualiza o último id na proposta inicial
            If Strings.InStr(txt_Codigo_Proposta.Text, "REV") > 0 Then
                Atualiza_Ultima_Proposta(tssl_Origem.Tag, CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_proposta").Value))
            End If

            'Como o id da propsota é zero, ou seja, é uma nova proposta, define o id como o último inserido. Isso precisa vir após
            'a inserção pois senão não há id definido ainda
            If get_id_proposta = 0 Then
                get_id_proposta = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_proposta").Value)
            End If

            Dim Mensagem_Retorno As String = CONVERT_TO_STRING(sqlcmd.Parameters("p_mensagem").Value)

            For Each dtRow As DataRow In dtbItens.Rows

                'Verifica se o id do item da proposta já existe, caso não exista insere um novo
                If CONVERT_TO_INTEGER(dtRow("id_item_proposta")) = 0 Then
                    sqlcmd = New MySqlCommand("sp_inserir_item_proposta", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_data_insercao", Now)
                Else
                    'Como o id do item da proposta não é 0 esse item já existe, então ele será editado
                    sqlcmd = New MySqlCommand("sp_editar_item_proposta", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_item_proposta", CONVERT_TO_INTEGER(dtRow("id_item_proposta")))
                    sqlcmd.Parameters.AddWithValue("p_data_edicao_item", Now)
                End If

                sqlcmd.Parameters.AddWithValue("p_id_usuario", get_id_usuario)
                sqlcmd.Parameters.AddWithValue("p_id_status", CONVERT_TO_INTEGER(dtRow("id_status")))
                sqlcmd.Parameters.AddWithValue("p_id_proposta", get_id_proposta)
                sqlcmd.Parameters.AddWithValue("p_id_status_aprovacao", CONVERT_TO_INTEGER(dtRow("id_status_aprovacao")))
                sqlcmd.Parameters.AddWithValue("p_id_justificativa_aprovacao", CONVERT_TO_INTEGER(dtRow("id_justificativa_aprovacao")))
                sqlcmd.Parameters.AddWithValue("p_id_tipo_item", CONVERT_TO_INTEGER(dtRow("id_tipo_item")))

                If Not IsDBNull(dtRow("id_conjunto")) Then
                    sqlcmd.Parameters.AddWithValue("p_id_conjunto", CONVERT_TO_INTEGER(dtRow("id_conjunto")))
                Else
                    sqlcmd.Parameters.Add("p_id_conjunto", MySqlDbType.Int32).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("id_especificacao")) Then
                    sqlcmd.Parameters.AddWithValue("p_id_especificacao", CONVERT_TO_INTEGER(dtRow("id_especificacao")))
                Else
                    sqlcmd.Parameters.Add("p_id_especificacao", MySqlDbType.Int32).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("id_fornecedor")) Then
                    sqlcmd.Parameters.AddWithValue("p_id_fornecedor", CONVERT_TO_INTEGER(dtRow("id_fornecedor")))
                Else
                    sqlcmd.Parameters.Add("p_id_fornecedor", MySqlDbType.Int32).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("codigo_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_codigo_item", CONVERT_TO_STRING(dtRow("codigo_item")))
                Else
                    sqlcmd.Parameters.Add("p_codigo_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("descricao_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_descricao_item", CONVERT_TO_STRING(dtRow("descricao_item")))
                Else
                    sqlcmd.Parameters.Add("p_descricao_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("quantidade_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_quantidade_item", CONVERT_TO_DECIMAL(dtRow("quantidade_item")))
                Else
                    sqlcmd.Parameters.Add("p_quantidade_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_unitario_inicial_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_unitario_inicial_item", CONVERT_TO_DECIMAL(dtRow("preco_unitario_inicial_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_unitario_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("percentual_ipi_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_percentual_ipi_item", CONVERT_TO_DECIMAL(dtRow("percentual_ipi_item")))
                Else
                    sqlcmd.Parameters.Add("p_percentual_ipi_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("percentual_icms_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_percentual_icms_item", CONVERT_TO_DECIMAL(dtRow("percentual_icms_item")))
                Else
                    sqlcmd.Parameters.Add("p_percentual_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("ncm_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_ncm_item", CONVERT_TO_STRING(dtRow("ncm_item")))
                Else
                    sqlcmd.Parameters.Add("p_ncm_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("mva_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_mva_item", CONVERT_TO_DECIMAL(dtRow("mva_item")))
                Else
                    sqlcmd.Parameters.Add("p_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("valor_st_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_valor_st_item", CONVERT_TO_DECIMAL(dtRow("valor_st_item")))
                Else
                    sqlcmd.Parameters.Add("p_valor_st_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("valor_total_inicial_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_valor_total_inicial_item", CONVERT_TO_DECIMAL(dtRow("valor_total_inicial_item")))
                Else
                    sqlcmd.Parameters.Add("p_valor_total_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("prazo_inicial_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_prazo_inicial_item", CONVERT_TO_STRING(dtRow("prazo_inicial_item")))
                Else
                    sqlcmd.Parameters.Add("p_prazo_inicial_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("frete_unitario_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_frete_unitario_item", CONVERT_TO_DECIMAL(dtRow("frete_unitario_item")))
                Else
                    sqlcmd.Parameters.Add("p_frete_unitario_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("desconto_inicial_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_desconto_inicial_item", CONVERT_TO_DECIMAL(dtRow("desconto_inicial_item")))
                Else
                    sqlcmd.Parameters.Add("p_desconto_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("id_tipo_substituicao_tributaria_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_id_tipo_substituicao_tributaria_item", CONVERT_TO_INTEGER(dtRow("id_tipo_substituicao_tributaria_item")))
                Else
                    sqlcmd.Parameters.Add("p_id_tipo_substituicao_tributaria_item", MySqlDbType.Int32).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("id_origem_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_id_origem_item", CONVERT_TO_INTEGER(dtRow("id_origem_item")))
                Else
                    sqlcmd.Parameters.Add("p_id_origem_item", MySqlDbType.Int32).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_apos_desconto_inicial_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_apos_desconto_inicial_item", CONVERT_TO_DECIMAL(dtRow("preco_apos_desconto_inicial_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_apos_desconto_inicial_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_com_ipi_e_icms_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_com_ipi_e_icms_item", CONVERT_TO_DECIMAL(dtRow("preco_com_ipi_e_icms_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_com_ipi_e_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("percentual_aliquota_externa_icms_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_externa_icms_item", CONVERT_TO_DECIMAL(dtRow("percentual_aliquota_externa_icms_item")))
                Else
                    sqlcmd.Parameters.Add("p_percentual_aliquota_externa_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("valor_icms_credito_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_valor_icms_credito_item", CONVERT_TO_DECIMAL(dtRow("valor_icms_credito_item")))
                Else
                    sqlcmd.Parameters.Add("p_valor_icms_credito_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("percentual_mva_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_percentual_mva_item", CONVERT_TO_DECIMAL(dtRow("percentual_mva_item")))
                Else
                    sqlcmd.Parameters.Add("p_percentual_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("valor_mva_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_valor_mva_item", CONVERT_TO_DECIMAL(dtRow("valor_mva_item")))
                Else
                    sqlcmd.Parameters.Add("p_valor_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_com_mva_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_com_mva_item", CONVERT_TO_DECIMAL(dtRow("preco_com_mva_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_com_mva_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("percentual_aliquota_interna_icms_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_interna_icms_item", CONVERT_TO_DECIMAL(dtRow("percentual_aliquota_interna_icms_item")))
                Else
                    sqlcmd.Parameters.Add("p_percentual_aliquota_interna_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("valor_icms_debito_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_valor_icms_debito_item", CONVERT_TO_DECIMAL(dtRow("valor_icms_debito_item")))
                Else
                    sqlcmd.Parameters.Add("p_valor_icms_debito_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("saldo_icms_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_saldo_icms_item", CONVERT_TO_DECIMAL(dtRow("saldo_icms_item")))
                Else
                    sqlcmd.Parameters.Add("p_saldo_icms_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_unitario_para_revendedor_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_unitario_para_revendedor_item", CONVERT_TO_DECIMAL(dtRow("preco_unitario_para_revendedor_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_unitario_para_revendedor_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("impostos_federais_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_impostos_federais_item", CONVERT_TO_DECIMAL(dtRow("impostos_federais_item")))
                Else
                    sqlcmd.Parameters.Add("p_impostos_federais_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("rateio_despesa_fixa_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_rateio_despesa_fixa_item", CONVERT_TO_DECIMAL(dtRow("rateio_despesa_fixa_item")))
                Else
                    sqlcmd.Parameters.Add("p_rateio_despesa_fixa_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("percentual_lucro_necessario_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item", CONVERT_TO_DECIMAL(dtRow("percentual_lucro_necessario_item")))
                Else
                    sqlcmd.Parameters.Add("p_percentual_lucro_necessario_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_lista_venda_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_lista_venda_item", CONVERT_TO_DECIMAL(dtRow("preco_lista_venda_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_lista_venda_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("desconto_final_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_desconto_final_item", CONVERT_TO_DECIMAL(dtRow("desconto_final_item")))
                Else
                    sqlcmd.Parameters.Add("p_desconto_final_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_unitario_final_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_unitario_final_item", CONVERT_TO_DECIMAL(dtRow("preco_unitario_final_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_unitario_final_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("preco_total_final_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_preco_total_final_item", CONVERT_TO_DECIMAL(dtRow("preco_total_final_item")))
                Else
                    sqlcmd.Parameters.Add("p_preco_total_final_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("quantidade_estoque_codigo_completo_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_quantidade_estoque_codigo_completo_item", CONVERT_TO_DECIMAL(dtRow("quantidade_estoque_codigo_completo_item")))
                Else
                    sqlcmd.Parameters.Add("p_quantidade_estoque_codigo_completo_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("quantidade_estoque_codigo_abreviado_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_quantidade_estoque_codigo_abreviado_item", CONVERT_TO_DECIMAL(dtRow("quantidade_estoque_codigo_abreviado_item")))
                Else
                    sqlcmd.Parameters.Add("p_quantidade_estoque_codigo_abreviado_item", MySqlDbType.Decimal).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("informacao_estoque_codigo_completo_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_informacao_estoque_codigo_completo_item", CONVERT_TO_STRING(dtRow("informacao_estoque_codigo_completo_item")))
                Else
                    sqlcmd.Parameters.Add("p_informacao_estoque_codigo_completo_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("informacao_estoque_codigo_abreviado_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_informacao_estoque_codigo_abreviado_item", CONVERT_TO_STRING(dtRow("informacao_estoque_codigo_abreviado_item")))
                Else
                    sqlcmd.Parameters.Add("p_informacao_estoque_codigo_abreviado_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("prazo_final_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_prazo_final_item", CONVERT_TO_STRING(dtRow("prazo_final_item")))
                Else
                    sqlcmd.Parameters.Add("p_prazo_final_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("comentarios_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_comentarios_item", CONVERT_TO_STRING(dtRow("comentarios_item")))
                Else
                    sqlcmd.Parameters.Add("p_comentarios_item", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not IsDBNull(dtRow("data_aprovacao_item")) Then
                    sqlcmd.Parameters.AddWithValue("p_data_aprovacao_item", CONVERT_TO_DATE(dtRow("data_aprovacao_item")))
                Else
                    sqlcmd.Parameters.Add("p_data_aprovacao_item", MySqlDbType.DateTime).Value = DBNull.Value
                End If

                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

            Next

            If CONVERT_TO_STRING(txt_item_excluido.Text) = CONVERT_TO_STRING(1) Then
                Excluir_Itens_Proposta(get_id_proposta)
            End If

            mnui_Salvar.Enabled = False
            mnui_Editar.Enabled = True
            mnui_Revisar.Enabled = True
            mnui_Visualizar.Enabled = True
            mnui_Cancelar.Visible = False

            Carregar_Proposta(get_id_proposta)

            MessageBox.Show(Me, "Proposta salva com sucesso!", "Procedimento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Edicao_Campos(False)

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Sub Excluir_Itens_Proposta(db_id_proposta As Integer)

        Dim adapter As MySqlDataAdapter
        Dim sqlcmd As MySqlCommand

        Try
            'Abrir_Conexao()

            Dim dtb_itens_proposta As New DataTable

            adapter = New MySqlDataAdapter("SELECT id_item_proposta FROM tb_itens_propostas WHERE id_proposta = " & db_id_proposta, strConexao)

            adapter.Fill(dtb_itens_proposta)

            For Each dtb_itens_row As DataRow In dtb_itens_proposta.Rows
                Dim itens_encontrados As DataRow() = dtbItens.Select("id_item_proposta = " & dtb_itens_row("id_item_proposta"))
                If itens_encontrados.Length = 0 Then
                    sqlcmd = New MySqlCommand("sp_excluir_item_proposta", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_item_proposta", dtb_itens_row("id_item_proposta"))
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                    Dim Mensagem_Retorno As String = CONVERT_TO_STRING(sqlcmd.Parameters("p_mensagem").Value)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            'Fechar_Conexao()
        End Try
    End Sub

    Private Sub tsmi_Nao_Exibir_Codigo_Click(sender As Object, e As EventArgs) Handles tsmi_Nao_Exibir_Codigo.Click
        get_exibir_codigo = "Nao_Exibir"

        Dim tmp_dtb As DataTable = dtg_Itens.DataSource

        Dim qtd_pecas As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item = 1")
        Dim qtd_servicos As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item <> 1")

        If qtd_pecas > 0 And qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf qtd_pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If

    End Sub

    Private Sub tsmi_Atual_Abreviado_Click(sender As Object, e As EventArgs) Handles tsmi_Atual_Abreviado.Click
        get_exibir_codigo = "Atual_Abreviado"

        Dim tmp_dtb As DataTable = dtg_Itens.DataSource

        Dim qtd_pecas As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item = 1")
        Dim qtd_servicos As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item <> 1")

        If qtd_pecas > 0 And qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf qtd_pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If

    End Sub

    Private Sub tsmi_Atual_Completo_Click(sender As Object, e As EventArgs) Handles tsmi_Atual_Completo.Click
        get_exibir_codigo = "Atual_Completo"

        Dim tmp_dtb As DataTable = dtg_Itens.DataSource

        Dim qtd_pecas As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item = 1")
        Dim qtd_servicos As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item <> 1")

        If qtd_pecas > 0 And qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf qtd_pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If

    End Sub

    Private Sub tsmi_Todos_Os_Codigos_Click(sender As Object, e As EventArgs) Handles tsmi_Todos_Os_Codigos.Click
        get_exibir_codigo = "Todos"

        Dim tmp_dtb As DataTable = dtg_Itens.DataSource

        Dim qtd_pecas As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item = 1")
        Dim qtd_servicos As Integer = tmp_dtb.Compute("Count(id_item_proposta)", "id_tipo_item <> 1")

        If qtd_pecas > 0 And qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta
            form.ShowDialog()
        ElseIf qtd_pecas > 0 Then
            Dim form = New Visualizar_Proposta_Peca
            form.ShowDialog()
        ElseIf qtd_servicos > 0 Then
            Dim form = New Visualizar_Proposta_Servico
            form.ShowDialog()
        End If

    End Sub

    Private Sub mnui_Editar_Click(sender As Object, e As EventArgs) Handles mnui_Editar.Click

        txt_id_proposta_old.Text = get_id_proposta

        If Not String.IsNullOrEmpty(CONVERT_TO_STRING(GET_DATA_MYSQL("tb_propostas", "data_envio", "id_proposta=" & get_id_proposta))) Then
            MessageBox.Show(Me, "Essa proposta já foi enviada, portanto só é possível alterar os dados de faturamento, comentários e aprovação dos itens. Caso queira alterar outras informações, revise a proposta através da opção 'Revisar'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Dim ctlReadOnly As Control

            Edicao_Campos(False)

            mnui_Revisar.Enabled = False
            mnui_Salvar.Enabled = True
            mnui_Deletar.Enabled = False
            mnui_Visualizar.Enabled = False
            mnui_Cancelar.Visible = True

            ctlReadOnly = grp_Faturamento.Controls("txt_ReadOnly" + dtp_Data_Envio_Faturamento.Name)
            If CntrlExistsIn(ctlReadOnly.Name, grp_Faturamento) Then
                ctlReadOnly.Visible = False
            End If
            dtp_Data_Envio_Faturamento.Visible = True

            ctlReadOnly = grp_Faturamento.Controls("txt_ReadOnly" + dtp_Data_Faturamento.Name)
            If CntrlExistsIn(ctlReadOnly.Name, grp_Faturamento) Then
                ctlReadOnly.Visible = False
            End If
            dtp_Data_Faturamento.Visible = True

            ctlReadOnly = grp_Faturamento.Controls("txt_ReadOnly" + nud_Nota_Fiscal.Name)
            If CntrlExistsIn(ctlReadOnly.Name, grp_Faturamento) Then
                ctlReadOnly.Visible = False
            End If
            nud_Nota_Fiscal.Visible = True

            ctlReadOnly = grp_Faturamento.Controls("txt_ReadOnly" + nud_Valor_Faturamento.Name)
            If CntrlExistsIn(ctlReadOnly.Name, grp_Faturamento) Then
                ctlReadOnly.Visible = False
            End If
            nud_Valor_Faturamento.Visible = True

            ctlReadOnly = grp_Outros.Controls("txt_ReadOnly" + txt_Comentarios.Name)
            If CntrlExistsIn(ctlReadOnly.Name, grp_Faturamento) Then
                ctlReadOnly.Visible = False
            End If
            txt_Comentarios.Visible = True

        Else

            Edicao_Campos(True)

            mnui_Revisar.Enabled = False
            mnui_Salvar.Enabled = True
            mnui_Deletar.Enabled = False
            mnui_Visualizar.Enabled = False
            mnui_Cancelar.Visible = True

        End If

    End Sub

    Private Sub mnui_Revisar_Click(sender As Object, e As EventArgs) Handles mnui_Revisar.Click

        Edicao_Campos(True)
        mnui_Editar.Enabled = False
        mnui_Salvar.Enabled = True
        mnui_Deletar.Enabled = False
        mnui_Visualizar.Enabled = False
        mnui_Cancelar.Visible = True

        Retorna_Codigo_Proposta_Revisada()
        tssl_Origem.Tag = get_id_proposta
        txt_id_proposta_old.Text = get_id_proposta
        get_id_proposta = 0

        tssl_Envio.Text = ""
        tssl_Envio.Tag = ""

        dtp_Data_Envio_Faturamento.Checked = False
        dtp_Data_Faturamento.Checked = False
        nud_Nota_Fiscal.Value = 0
        nud_Valor_Faturamento.Value = 0

        For Each dtRow As DataRow In dtbItens.Rows
            dtRow("id_item_proposta") = 0
        Next

        Calcula_Valores_Datagrid()

        MessageBox.Show(Me, "Lembre-se de atualizar o prazo dos itens após a revisão, pois pode ter acontecido mudança no prazo. É extremamente recomendado a verificação dos preços pois estes podem ter sido alterados desde a última proposta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub cbo_Serie_Leave(sender As Object, e As EventArgs) Handles cbo_Serie.Leave
        Carrega_Dados_Serie()
    End Sub

    Sub Carrega_Dados_Serie()

        If cbo_Serie.Text = "" Or cbo_Serie.FindString(cbo_Serie.Text) < 0 Then

            Serie_Existe = False

            Dim sqlcmd As MySqlCommand

            Try
                Abrir_Conexao()
                sqlcmd = New MySqlCommand("sp_verifica_familia", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_serie", cbo_Serie.Text)
                sqlcmd.Parameters.Add("p_familia", MySqlDbType.VarChar, 10).Direction = 2
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim Familia As String = sqlcmd.Parameters("p_familia").Value.ToString
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

                If Mensagem_Conclusao = "Valor encontrado" Then
                    Familia_Existe = True
                    Preencher_ComboBox(cbo_Fabricante, "tb_familias AS fm", "id_fabricante", "nome", "fm.id_fabricante, fb.nome", "fm.id_status=1 AND fm.familia=" & Familia, "", " tb_fabricantes AS fb ON fm.id_fabricante=fb.id_fabricante", "1")
                    Preencher_ComboBox(cbo_Tipo_Equipamento, "tb_familias AS fm", "id_tipo_equipamento", "nome", "fm.id_tipo_equipamento, te.nome", "fm.id_status=1 AND fm.familia=" & Familia, "", " tb_tipos_equipamento AS te ON fm.id_tipo_equipamento=te.id_tipo_equipamento", "1")
                    Preencher_ComboBox(cbo_Modelo, "tb_familias AS fm", "id_modelo", "nome", "fm.id_modelo, md.nome", "fm.id_status=1 AND fm.familia=" & Familia, "nome", " tb_modelos AS md ON fm.id_modelo=md.id_modelo")
                    '     Preencher_cbo_Ano()
                Else
                    Familia_Existe = False
                End If
                Fechar_Conexao()
            Catch ex As Exception
                MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Fechar_Conexao()
            End Try

            If Familia_Existe = False Then
                Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", "id_status=1", "nome")
                cbo_Fabricante.SelectedValue = -1
            End If

        Else

            cbo_Serie.SelectedIndex = cbo_Serie.FindString(cbo_Serie.Text)

            Serie_Existe = True
            Preencher_ComboBox(cbo_Fabricante, "tb_series AS se", "id_fabricante", "nome", "se.id_fabricante, fb.nome", "se.id_status=1 AND se.id_serie=" & cbo_Serie.SelectedValue, "", " tb_fabricantes AS fb ON se.id_fabricante=fb.id_fabricante", "1")
            Preencher_ComboBox(cbo_Tipo_Equipamento, "tb_series AS se", "id_tipo_equipamento", "nome", "se.id_tipo_equipamento, te.nome", "se.id_status=1 AND se.id_serie=" & cbo_Serie.SelectedValue, "", " tb_tipos_equipamento AS te ON se.id_tipo_equipamento=te.id_tipo_equipamento", "1")
            Preencher_ComboBox(cbo_Modelo, "tb_series AS se", "id_modelo", "nome", "se.id_modelo, md.nome", "se.id_status=1 AND se.id_serie=" & cbo_Serie.SelectedValue, "nome", " tb_modelos AS md ON se.id_modelo=md.id_modelo")
            ' Preencher_cbo_Ano()

        End If
    End Sub

    Private Sub TabelaCompletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabelaCompletaToolStripMenuItem.Click


        Dim strarquivoSalvo As String = ""

        Using OFD As New SaveFileDialog With {.FileName = "Itens_Proposta_" & txt_Codigo_Proposta.Text & "_" & cbo_Cliente.Text, .Filter = "Arquivo do Excel (*.xlsx)|*.xlsx"}
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

            For Each dtg_col As DataGridViewColumn In dtg_Itens.Columns
                If dtg_col.Visible = True Then
                    elWorksheet.Cells(1, dtg_col.DisplayIndex + 1).Value = dtg_col.HeaderText
                End If
            Next

            Dim elColumn As Long = 1
            Dim elRow As Long = 2

            For Each dtg_col As DataGridViewColumn In dtg_Itens.Columns
                If dtg_col.Visible = True Then
                    elWorksheet.Cells(1, elColumn).Value = dtg_col.HeaderText
                    elRow = 2
                    For Each dtb_row As DataGridViewRow In dtg_Itens.Rows
                        elWorksheet.Cells(elRow, elColumn).Value = dtb_row.Cells(dtg_col.DisplayIndex).Value
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

    Private Sub mnui_Cancelar_Click(sender As Object, e As EventArgs) Handles mnui_Cancelar.Click

        get_id_proposta = txt_id_proposta_old.Text

        txt_atualizou_prazo.Text = 0

        Preencher_ComboBox(cbo_Prioridade, "tb_prioridades", "id_prioridade", "nome", condicoes:="id_status=1", ordenar_por:="id_prioridade")
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Cliente, "tb_clientes", "id_cliente", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

        Carregar_Proposta(get_id_proposta)

        Dim dtbCol As DataColumn = dtbItens.Columns.Add("texto_estoque_encontrado")
        dtg_Itens.Columns("texto_estoque_encontrado").Visible = False

        Formatar_Datagrid()

        Colunas_Visiveis("todas", False)

        Atualiza_Statusbar()

        'Carrega_Dados_Serie()

        mnui_Salvar.Enabled = False
        mnui_Editar.Enabled = True
        mnui_Revisar.Enabled = True
        mnui_Visualizar.Enabled = True
        mnui_Cancelar.Visible = False

        Edicao_Campos(False)

    End Sub

    Private Sub mnui_Visualizar_Click(sender As Object, e As EventArgs) Handles mnui_Visualizar.Click
        Dim Quantidade_Itens As Integer = CONVERT_TO_INTEGER(Trim(CONVERT_TO_STRING(dtbItens.Compute("Count(id_item_proposta)", ""))))

        If Quantidade_Itens = 0 Then
            Exit Sub
        End If

        Dim Quantidade_Pecas As Integer = CONVERT_TO_INTEGER(Trim(CONVERT_TO_STRING(dtbItens.Compute("Count(id_item_proposta)", "id_tipo_item = 1"))))

        If Quantidade_Pecas = 0 Then

            Dim form = New Visualizar_Proposta_Servico
                form.ShowDialog()

        End If

    End Sub

    Private Sub mnui_Visualizar_MouseEnter(sender As Object, e As EventArgs) Handles mnui_Visualizar.MouseEnter

        Dim Quantidade_Itens As Integer = CONVERT_TO_INTEGER(Trim(CONVERT_TO_STRING(dtbItens.Compute("Count(id_item_proposta)", ""))))

        If Quantidade_Itens = 0 Then
            tsmi_Exibir_Codigo.Visible = False
            tsmi_Nao_Exibir_Codigo.Visible = False
            Exit Sub
        End If

        Dim Quantidade_Pecas As Integer = CONVERT_TO_INTEGER(Trim(CONVERT_TO_STRING(dtbItens.Compute("Count(id_item_proposta)", "id_tipo_item = 1"))))

        If Quantidade_Pecas = 0 Then
            tsmi_Exibir_Codigo.Visible = False
            tsmi_Nao_Exibir_Codigo.Visible = False

        Else
            tsmi_Exibir_Codigo.Visible = True
            tsmi_Nao_Exibir_Codigo.Visible = True
        End If

    End Sub

    Private Sub mnui_Deletar_Click(sender As Object, e As EventArgs) Handles mnui_Deletar.Click

        If MessageBox.Show("Tem certeza que deseja excluir a proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' e seus respectivos itens? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim sqlcmd As MySqlCommand
        Dim qtd_itens_sucesso As Integer = 0

        Try

            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT id_item_proposta FROM tb_itens_propostas WHERE id_proposta = " & get_id_proposta & " ORDER BY id_item_proposta DESC", strConexao)

            adapter.Fill(dtb)

            Dim qtd_itens_total As Integer = dtb.Rows.Count

            For Each dRow As DataRow In dtb.Rows

                sqlcmd = New MySqlCommand("sp_excluir_item_proposta", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_item_proposta", CONVERT_TO_INTEGER(dRow("id_item_proposta").ToString))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor excluído com sucesso" Then
                    qtd_itens_sucesso = qtd_itens_sucesso + 1
                End If

            Next

            sqlcmd = New MySqlCommand("sp_excluir_proposta", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_proposta", get_id_proposta)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao2 As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao2 = "Valor não existe" Then
                If qtd_itens_total = 0 Then
                    MessageBox.Show("A proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' bem como seus itens não existem na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf qtd_itens_sucesso <> qtd_itens_total Then
                    MessageBox.Show("A proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' não existe na database, porém foram encontrados itens referentes à essa proposta, entretanto apenas parte desses itens foram excluídos com sucesso. ", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("A proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' não existe na database, porém foram encontrados itens referentes à essa proposta, sendo que todos eles foram excluídos com sucesso. ", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                If qtd_itens_total = 0 Then
                    MessageBox.Show("Proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' excluída com sucesso. Não foram encontrados itens dessa proposta para serem excluídos", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf qtd_itens_sucesso <> qtd_itens_total Then
                    MessageBox.Show("Proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' excluída com sucesso, porém apenas parte dos itens dessa proposta foram excluídos com sucesso", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Proposta '" & cbo_Cliente.Text & " - " & txt_Codigo_Proposta.Text & "' excluída com sucesso! ", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

        Me.Close()

    End Sub
    Private Sub cbo_Copiar_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Copiar_Cliente.SelectedIndexChanged

        If cbo_Carregar_De.SelectedItem = "Cliente e proposta" And cbo_Copiar_Cliente.SelectedValue > 0 Then
            Preencher_ComboBox(cbo_Copiar_Proposta, "tb_propostas", "id_proposta", "codigo_proposta", condicoes:="id_status=1 AND id_cliente=" & cbo_Copiar_Cliente.SelectedValue, ordenar_por:="id_proposta")
        End If

    End Sub

    Private Sub cbo_Carregar_De_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Carregar_De.SelectedIndexChanged

        Select Case cbo_Carregar_De.SelectedItem
            Case "Cliente (Atual)"
                cbo_Copiar_Cliente.DataSource = Nothing

                If String.IsNullOrEmpty(cbo_Cliente.SelectedValue) Then
                    MessageBox.Show(text:="Selecione um cliente antes", caption:="Nenhum cliente selecionado", buttons:=vbOKOnly, icon:=vbExclamation)
                Else
                    Preencher_ComboBox(cbo_Copiar_Cliente, "tb_termos_suporte AS tesu", "id_termo", "termo", colunas:="DISTINCT tesu.id_termo, term.nome AS termo", condicoes:="(tesu.id_setor = " & get_id_setor & " OR tesu.id_setor IS NULL) AND tesu.id_cliente = " & cbo_Cliente.SelectedValue,
                                   ordenar_por:="clie.nome", juncao_interna:="tb_clientes AS clie ON tesu.id_cliente = clie.id_cliente LEFT JOIN tb_termos AS term ON tesu.id_termo = term.id_termo")
                End If

                lbl_Copiar_Cliente.Text = cbo_Cliente.Text
                btn_Confirmar.Left = 460
                cbo_Copiar_Cliente.Width = 303
                lbl_Copiar_Cliente.Visible = True
                cbo_Copiar_Cliente.Visible = True
                lbl_Copiar_Proposta.Visible = False
                cbo_Copiar_Proposta.Visible = False
                lbl_Copiar_Termo.Visible = False
                cbo_Copiar_Termo.Visible = False
                btn_Confirmar.Visible = True

                If cbo_Cliente.SelectedValue > 0 Then
                    cbo_Copiar_Cliente.SelectedValue = cbo_Cliente.SelectedValue
                End If

            Case "Cliente (Todos)"
                cbo_Copiar_Cliente.DataSource = Nothing
                Preencher_ComboBox(cbo_Copiar_Cliente, "tb_termos_suporte AS tesu", "id_termo", "cliente_termo", colunas:="DISTINCT tesu.id_termo, CONCAT(clie.nome, ' - ', term.nome) AS cliente_termo", condicoes:="tesu.id_setor = " & get_id_setor & " OR tesu.id_setor IS NULL",
                                   ordenar_por:="clie.nome", juncao_interna:="tb_clientes AS clie ON tesu.id_cliente = clie.id_cliente LEFT JOIN tb_termos AS term ON tesu.id_termo = term.id_termo")

                lbl_Copiar_Cliente.Text = "Cliente - Termo"
                btn_Confirmar.Left = 460
                cbo_Copiar_Cliente.Width = 303
                lbl_Copiar_Cliente.Visible = True
                cbo_Copiar_Cliente.Visible = True
                lbl_Copiar_Proposta.Visible = False
                cbo_Copiar_Proposta.Visible = False
                lbl_Copiar_Termo.Visible = False
                cbo_Copiar_Termo.Visible = False
                btn_Confirmar.Visible = True

                If cbo_Cliente.SelectedValue > 0 Then
                    cbo_Copiar_Cliente.SelectedValue = cbo_Cliente.SelectedValue
                End If

            Case "Cliente e proposta"
                lbl_Copiar_Cliente.Text = "Cliente"
                btn_Confirmar.Left = 460
                cbo_Copiar_Cliente.Width = 175
                lbl_Copiar_Cliente.Visible = True
                cbo_Copiar_Cliente.Visible = True
                lbl_Copiar_Proposta.Visible = True
                cbo_Copiar_Proposta.Visible = True
                lbl_Copiar_Termo.Visible = False
                cbo_Copiar_Termo.Visible = False
                btn_Confirmar.Visible = True
                cbo_Copiar_Cliente.DataSource = Nothing
                Preencher_ComboBox(cbo_Copiar_Cliente, "tb_clientes", "id_cliente", "nome", condicoes:="id_status=1", ordenar_por:="nome")

                If cbo_Cliente.SelectedValue > 0 Then
                    cbo_Copiar_Cliente.SelectedValue = cbo_Cliente.SelectedValue
                End If

                cbo_Copiar_Proposta.DataSource = Nothing
                Preencher_ComboBox(cbo_Copiar_Proposta, "tb_propostas", "id_proposta", "codigo_proposta", condicoes:="id_status=1 AND id_cliente=" & cbo_Copiar_Cliente.SelectedValue, ordenar_por:="id_proposta")

            Case "Termo padrão"
                cbo_Copiar_Termo.DataSource = Nothing
                Preencher_ComboBox(cbo_Copiar_Termo, "tb_termos", "id_termo", "nome", condicoes:="id_status=1", ordenar_por:="nome")

                btn_Confirmar.Left = 332
                lbl_Copiar_Cliente.Visible = False
                cbo_Copiar_Cliente.Visible = False
                lbl_Copiar_Proposta.Visible = False
                cbo_Copiar_Proposta.Visible = False
                lbl_Copiar_Termo.Visible = True
                cbo_Copiar_Termo.Visible = True
                btn_Confirmar.Visible = True

            Case Else

                btn_Confirmar.Visible = False
                lbl_Copiar_Cliente.Visible = False
                cbo_Copiar_Cliente.Visible = False
                lbl_Copiar_Proposta.Visible = False
                cbo_Copiar_Proposta.Visible = False
                lbl_Copiar_Termo.Visible = False
                cbo_Copiar_Termo.Visible = False
        End Select

    End Sub

    Private Sub btn_Confirmar_Click(sender As Object, e As EventArgs) Handles btn_Confirmar.Click

        If txt_Texto_Padrao.Text <> "" Or
            txt_Observacoes.Text <> "" Or
            txt_Prazo_Entrega.Text <> "" Or
            txt_Condicao_Pagamento.Text <> "" Or
            txt_Garantia.Text <> "" Or
            txt_Validade.Text <> "" Then

            If MessageBox.Show(text:="Os termos atuais serão substituídos. Deseja continar?", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If

        Dim strcommand As String = ""
        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Select Case cbo_Carregar_De.SelectedItem
            Case "Cliente (Atual)"
                If cbo_Copiar_Cliente.SelectedIndex = -1 Then
                    Exit Sub
                End If
                strcommand = "SELECT term.texto_padrao, term.observacoes, term.prazo_entrega, term.condicao_pagamento, term.garantia, term.validade FROM tb_termos_suporte AS tesu
                                LEFT JOIN tb_termos AS term ON tesu.id_termo = term.id_termo WHERE tesu.id_termo = " & cbo_Copiar_Cliente.SelectedValue
            Case "Cliente (Todos)"
                If cbo_Copiar_Cliente.SelectedIndex = -1 Then
                    Exit Sub
                End If
                strcommand = "SELECT term.texto_padrao, term.observacoes, term.prazo_entrega, term.condicao_pagamento, term.garantia, term.validade FROM tb_termos_suporte AS tesu
                                LEFT JOIN tb_termos AS term ON tesu.id_termo = term.id_termo WHERE tesu.id_termo = " & cbo_Copiar_Cliente.SelectedValue
            Case "Cliente e proposta"
                If cbo_Copiar_Proposta.SelectedIndex = -1 Then
                    Exit Sub
                End If
                strcommand = "SELECT prop.texto_padrao, prop.observacoes, prop.prazo_entrega, prop.condicao_pagamento, prop.garantia, prop.validade FROM tb_propostas AS prop
                                WHERE prop.id_proposta = " & cbo_Copiar_Proposta.SelectedValue & " ORDER BY id_proposta DESC LIMIT 1"
            Case "Termo padrão"
                If cbo_Copiar_Termo.SelectedIndex = -1 Then
                    Exit Sub
                End If
                strcommand = "SELECT term.texto_padrao, term.observacoes, term.prazo_entrega, term.condicao_pagamento, term.garantia, term.validade FROM tb_termos AS term
                                WHERE term.id_termo = " & cbo_Copiar_Termo.SelectedValue & " ORDER BY nome DESC LIMIT 1"
            Case Else
                Exit Sub
        End Select

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter(strcommand, strConexao)

            adapter.Fill(dtb)

            Dim rowTermo As DataRow = dtb.Rows(0)

            txt_Texto_Padrao.Text = rowTermo("texto_padrao")
            txt_Observacoes.Text = rowTermo("observacoes")
            txt_Prazo_Entrega.Text = rowTermo("prazo_entrega")
            txt_Condicao_Pagamento.Text = rowTermo("condicao_pagamento")
            txt_Garantia.Text = rowTermo("garantia")
            txt_Validade.Text = rowTermo("validade")

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub CustoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustoToolStripMenuItem.Click

        Dim result As Integer = dtbItens.Select("id_tipo_item = 1").Count

        If result = 0 Then
            MessageBox.Show(text:="Não há peças na proposta informada. Adicione ou importe peças para poder definir o desconto no custo", caption:="Nenhuma peça informada", buttons:=vbOKOnly, icon:=vbExclamation)
            Exit Sub
        End If

        Dim form = New Desconto
        get_coluna_desconto = "desconto_inicial_item"
        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim form = New Desconto
        get_coluna_desconto = "desconto_final_item"
        get_id_tipo_item_desconto = 1

        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim form = New Desconto
        get_coluna_desconto = "desconto_final_item"
        get_id_tipo_item_desconto = 2

        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim form = New Desconto
        get_coluna_desconto = "desconto_final_item"
        get_id_tipo_item_desconto = 3

        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim form = New Desconto
        get_coluna_desconto = "desconto_final_item"
        get_id_tipo_item_desconto = 0

        form.ShowDialog()
        Calcula_Valores_Datagrid()
        Formatar_Datagrid()
    End Sub

End Class