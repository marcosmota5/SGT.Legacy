Imports MySql.Data.MySqlClient

Public Class Controle_Item
    Private Sub Controle_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Preencher_ComboBox(cbo_Tipo_Item, "tb_tipos_item", "id_tipo_item", "nome", condicoes:="id_status=1", ordenar_por:="id_tipo_item")
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Status_Aprovacao, "tb_status_aprovacao", "id_status_aprovacao", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Justificativa_Aprovacao, "tb_justificativas_aprovacao", "id_justificativa_aprovacao", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Fornecedor, "tb_fornecedores", "id_fornecedor", "nome", condicoes:="id_status=1", ordenar_por:="id_fornecedor")
        Preencher_ComboBox(cbo_Tipo_Substituicao_Tributaria, "tb_tipos_substituicao_tributaria", "id_tipo_substituicao_tributaria", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Origem, "tb_origens", "id_origem", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Conjunto, "tb_conjuntos", "id_conjunto", "nome", condicoes:="id_status=1", ordenar_por:="nome")

        'nud_Desconto_Final.ResetText()
        'nud_Desconto_Inicial.ResetText()
        'nud_Frete_Unitario.ResetText()
        'nud_MVA.ResetText()
        'nud_Percentual_ICMS.ResetText()
        'nud_Percentual_IPI.ResetText()
        'nud_Preco_Total.ResetText()
        'nud_Preco_Unitario.ResetText()
        'nud_Quantidade.ResetText()
        'nud_Valor_ST.ResetText()

        'nud_Desconto_Final.Controls(0).Visible = False
        'nud_Desconto_Inicial.Controls(0).Visible = False
        'nud_Frete_Unitario.Controls(0).Visible = False
        'nud_MVA.Controls(0).Visible = False
        'nud_Percentual_ICMS.Controls(0).Visible = False
        'nud_Percentual_IPI.Controls(0).Visible = False
        'nud_Preco_Total.Controls(0).Visible = False
        'nud_Preco_Unitario.Controls(0).Visible = False
        'nud_Quantidade.Controls(0).Visible = False
        'nud_Valor_ST.Controls(0).Visible = False

        If get_linha_item = -1 Then

            cbo_Tipo_Item.SelectedValue = get_id_tipo_item
            cbo_Status.SelectedValue = 1
            cbo_Status_Aprovacao.SelectedValue = 3
            cbo_Justificativa_Aprovacao.SelectedValue = 1

            cbo_Conjunto.SelectedValue = -1
            cbo_Especificacao.SelectedValue = -1
            cbo_Fornecedor.SelectedValue = -1
            cbo_Tipo_Substituicao_Tributaria.SelectedValue = -1
            cbo_Origem.SelectedValue = -1
            cbo_Codigo.SelectedValue = -1
            cbo_Codigo.Text = ""

            If get_id_tipo_item = 3 Then
                txt_Descricao.Text = "DESLOCAMENTO"

                If get_id_cliente <> -1 Then
                    nud_Preco_Unitario.Value = CONVERT_TO_DECIMAL(GET_DATA_MYSQL("tb_itens_propostas AS itpr", "itpr.preco_unitario_inicial_item",
                                                                                "itpr.id_tipo_item = 3 AND prop.id_cliente = " & get_id_cliente, "itpr.data_insercao DESC", "tb_propostas AS prop ON itpr.id_proposta = prop.id_proposta", "1"))
                    ' nud_Preco_Unitario.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("preco_unitario_inicial_item").ToString))
                End If


            Else
                txt_Descricao.Text = ""
            End If


        Else

            Dim dtb_row As DataRow = dtbItens.Rows(get_linha_item)

            cbo_Tipo_Item.SelectedValue = CONVERT_TO_INTEGER(dtb_row("id_tipo_item").ToString)
            cbo_Status.SelectedValue = CONVERT_TO_INTEGER(dtb_row("id_status").ToString)
            cbo_Status_Aprovacao.SelectedValue = CONVERT_TO_INTEGER(dtb_row("id_status_aprovacao").ToString)
            cbo_Justificativa_Aprovacao.SelectedValue = CONVERT_TO_INTEGER(dtb_row("id_justificativa_aprovacao").ToString)

            'If cbo_Tipo_Item.SelectedValue = 1 Then
            If String.IsNullOrEmpty(Trim(dtb_row("id_conjunto").ToString)) Then
                cbo_Conjunto.SelectedValue = -1
            Else
                cbo_Conjunto.SelectedValue = CONVERT_TO_INTEGER(Trim(dtb_row("id_conjunto").ToString))
            End If

            If String.IsNullOrEmpty(Trim(dtb_row("id_especificacao").ToString)) Then
                cbo_Especificacao.SelectedValue = -1
            Else
                cbo_Especificacao.SelectedValue = CONVERT_TO_INTEGER(Trim(dtb_row("id_especificacao").ToString))
            End If

            cbo_Fornecedor.SelectedValue = CONVERT_TO_INTEGER(Trim(dtb_row("id_fornecedor").ToString))
            cbo_Tipo_Substituicao_Tributaria.SelectedValue = CONVERT_TO_INTEGER(Trim(dtb_row("id_tipo_substituicao_tributaria_item").ToString))
            cbo_Codigo.Text = Trim(dtb_row("codigo_item").ToString)
            txt_Descricao.Text = Trim(dtb_row("descricao_item").ToString)
            nud_Quantidade.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("quantidade_item").ToString))
            nud_Quantidade_Inicial.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("quantidade_item").ToString))

            nud_Percentual_IPI.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("percentual_ipi_item").ToString)) * 100
            nud_Percentual_ICMS.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("percentual_icms_item").ToString)) * 100
            txt_NCM.Text = Trim(dtb_row("ncm_item").ToString)
            nud_MVA.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("mva_item").ToString)) * 100
            nud_Valor_ST.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("valor_st_item").ToString))

            nud_Frete_Unitario.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("frete_unitario_item").ToString))
            cbo_Justificativa_Aprovacao.SelectedValue = CONVERT_TO_INTEGER(Trim(dtb_row("id_justificativa_aprovacao").ToString))

            cbo_Origem.SelectedValue = CONVERT_TO_INTEGER(Trim(dtb_row("id_origem_item").ToString))

            'End If

            nud_Preco_Unitario.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("preco_unitario_inicial_item").ToString))
            nud_Desconto_Inicial.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("desconto_inicial_item").ToString)) * 100
            nud_Desconto_Final.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("desconto_final_item").ToString)) * 100
            nud_Preco_Total.Value = CONVERT_TO_DECIMAL(Trim(dtb_row("valor_total_inicial_item").ToString))
            txt_Prazo_Inicial.Text = Trim(dtb_row("prazo_inicial_item").ToString)
            txt_Prazo_Final.Text = Trim(dtb_row("prazo_final_item").ToString)
            txt_Comentarios.Text = Trim(dtb_row("comentarios_item").ToString)


        End If


    End Sub

    Private Sub cbo_Tipo_Item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Tipo_Item.SelectedIndexChanged

        If cbo_Tipo_Item.SelectedValue = 1 Then

            grp_Peça.Text = "Dados da peça"

            lbl_Conjunto.Visible = True
            lbl_Especificacao.Visible = True
            lbl_Fornecedor.Visible = True
            lbl_Codigo.Visible = True
            lbl_Percentual_IPI.Visible = True
            lbl_Percentual_ICMS.Visible = True
            lbl_NCM.Visible = True
            lbl_MVA.Visible = True
            lbl_Valor_ST.Visible = True
            lbl_Quantidade.Visible = True
            lbl_Tipo_Substituicao_Tributaria.Visible = True
            lbl_Origem.Visible = True
            lbl_Frete_Unitario.Visible = True
            lbl_Preco_Total.Visible = True
            lbl_Desconto_Inicial.Visible = True
            'lbl_Desconto_Final.Visible = True

            cbo_Conjunto.Visible = True
            cbo_Especificacao.Visible = True
            cbo_Fornecedor.Visible = True
            cbo_Codigo.Visible = True
            nud_Percentual_IPI.Visible = True
            nud_Percentual_ICMS.Visible = True
            txt_NCM.Visible = True
            nud_MVA.Visible = True
            nud_Valor_ST.Visible = True
            nud_Quantidade.Visible = True
            cbo_Tipo_Substituicao_Tributaria.Visible = True
            cbo_Origem.Visible = True
            nud_Frete_Unitario.Visible = True
            nud_Preco_Total.Visible = True
            nud_Desconto_Inicial.Visible = True
            'nud_Desconto_Final.Visible = True

            lbl_Descricao.Left = 240
            txt_Descricao.Left = 243
            txt_Descricao.Width = 424

            lbl_Preco_Unitario.Left = 92
            nud_Preco_Unitario.Left = 95
            lbl_Preco_Unitario.Top = 72
            nud_Preco_Unitario.Top = 88
            lbl_Desconto_Final.Top = 72
            nud_Desconto_Final.Top = 88

            lbl_Desconto_Final.Left = 193
            nud_Desconto_Final.Left = 196
            lbl_Desconto_Final.Top = 118
            nud_Desconto_Final.Top = 134

            txt_Prazo_Inicial.Width = 129
            lbl_Prazo_Inicial.Left = 172
            txt_Prazo_Inicial.Left = 175
            lbl_Prazo_Inicial.Top = 165
            txt_Prazo_Inicial.Top = 181

            txt_Prazo_Final.Width = 129
            lbl_Prazo_Final.Left = 307
            txt_Prazo_Final.Left = 310
            lbl_Prazo_Final.Top = 164
            txt_Prazo_Final.Top = 180

            txt_Comentarios.Width = 223
            lbl_Comentarios.Left = 442
            txt_Comentarios.Left = 445
            lbl_Comentarios.Top = 164
            txt_Comentarios.Top = 180

            'txt_Prazo_Inicial.Text = "Imediato"
            'txt_Prazo_Final.Text = "Imediato"

            grp_Peça.Height = 218
            btn_Cancelar.Top = 322
            btn_Salvar.Top = 322
            Me.Height = 395

        Else

            grp_Peça.Text = "Dados do serviço/deslocamento"

            lbl_Conjunto.Visible = False
            lbl_Especificacao.Visible = False
            lbl_Fornecedor.Visible = False
            lbl_Codigo.Visible = False
            lbl_Percentual_IPI.Visible = False
            lbl_Percentual_ICMS.Visible = False
            lbl_NCM.Visible = False
            lbl_MVA.Visible = False
            lbl_Valor_ST.Visible = False
            lbl_Quantidade.Visible = False
            lbl_Tipo_Substituicao_Tributaria.Visible = False
            lbl_Origem.Visible = False
            lbl_Frete_Unitario.Visible = False
            lbl_Preco_Total.Visible = False
            lbl_Desconto_Inicial.Visible = False

            cbo_Conjunto.Visible = False
            cbo_Especificacao.Visible = False
            cbo_Fornecedor.Visible = False
            cbo_Codigo.Visible = False
            nud_Percentual_IPI.Visible = False
            nud_Percentual_ICMS.Visible = False
            txt_NCM.Visible = False
            nud_MVA.Visible = False
            nud_Valor_ST.Visible = False
            nud_Quantidade.Visible = False
            cbo_Tipo_Substituicao_Tributaria.Visible = False
            cbo_Origem.Visible = False
            nud_Frete_Unitario.Visible = False
            nud_Preco_Total.Visible = False
            nud_Desconto_Inicial.Visible = False

            lbl_Descricao.Left = 13
            txt_Descricao.Left = 16
            txt_Descricao.Width = 462

            lbl_Preco_Unitario.Left = 482
            nud_Preco_Unitario.Left = 485
            lbl_Preco_Unitario.Top = 23
            nud_Preco_Unitario.Top = 39

            lbl_Desconto_Final.Left = 580
            nud_Desconto_Final.Left = 583
            lbl_Desconto_Final.Top = 23
            nud_Desconto_Final.Top = 39

            txt_Prazo_Inicial.Width = 152
            lbl_Prazo_Inicial.Left = 12
            txt_Prazo_Inicial.Left = 15
            lbl_Prazo_Inicial.Top = 70
            txt_Prazo_Inicial.Top = 86

            txt_Prazo_Final.Width = 152
            lbl_Prazo_Final.Left = 170
            txt_Prazo_Final.Left = 173
            lbl_Prazo_Final.Top = 70
            txt_Prazo_Final.Top = 86
            txt_Comentarios.Width = 337
            lbl_Comentarios.Left = 327
            txt_Comentarios.Left = 330
            lbl_Comentarios.Top = 70
            txt_Comentarios.Top = 86

            txt_Prazo_Inicial.Text = "A realizar"
            txt_Prazo_Final.Text = "A realizar"

            grp_Peça.Height = 126
            btn_Cancelar.Top = 234
            btn_Salvar.Top = 234
            Me.Height = 312

        End If

    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Dim sqlcmd As MySqlCommand
        Dim dtb_row As DataRow

        Dim strObrigatorios As String = ""

        If cbo_Tipo_Item.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Tipo_Item.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Tipo_Item.Text
            End If
            lbl_Tipo_Item.ForeColor = Color.Red
        Else
            lbl_Tipo_Item.ForeColor = Color.Black
        End If

        If cbo_Status.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Status.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Status.Text
            End If
            lbl_Status.ForeColor = Color.Red
        Else
            lbl_Status.ForeColor = Color.Black
        End If

        If cbo_Status_Aprovacao.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Status_Aprovacao.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Status_Aprovacao.Text
            End If
            lbl_Status_Aprovacao.ForeColor = Color.Red
        Else
            lbl_Status_Aprovacao.ForeColor = Color.Black
        End If


        If cbo_Justificativa_Aprovacao.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Justificativa_Aprovacao.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Justificativa_Aprovacao.Text
            End If
            lbl_Justificativa_Aprovacao.ForeColor = Color.Red
        Else
            lbl_Justificativa_Aprovacao.ForeColor = Color.Black
        End If

        Select Case cbo_Tipo_Item.SelectedValue
            Case 1

                If cbo_Fornecedor.Text = "" Then
                    If strObrigatorios = "" Then
                        strObrigatorios = lbl_Fornecedor.Text
                    Else
                        strObrigatorios = strObrigatorios & ", " & lbl_Fornecedor.Text
                    End If
                    lbl_Fornecedor.ForeColor = Color.Red
                Else
                    lbl_Fornecedor.ForeColor = Color.Black
                End If

                If cbo_Tipo_Substituicao_Tributaria.Text = "" Then
                    If strObrigatorios = "" Then
                        strObrigatorios = lbl_Tipo_Substituicao_Tributaria.Text
                    Else
                        strObrigatorios = strObrigatorios & ", " & lbl_Tipo_Substituicao_Tributaria.Text
                    End If
                    lbl_Tipo_Substituicao_Tributaria.ForeColor = Color.Red
                Else
                    lbl_Tipo_Substituicao_Tributaria.ForeColor = Color.Black
                End If

                If cbo_Origem.Text = "" Then
                    If strObrigatorios = "" Then
                        strObrigatorios = lbl_Origem.Text
                    Else
                        strObrigatorios = strObrigatorios & ", " & lbl_Origem.Text
                    End If
                    lbl_Origem.ForeColor = Color.Red
                Else
                    lbl_Origem.ForeColor = Color.Black
                End If

        End Select


        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try

            If get_linha_item = -1 Then
                dtb_row = dtbItens.NewRow
                dtb_row("id_item_proposta") = 0
                dtb_row("data_insercao") = Now
                dtb_row("id_proposta") = get_id_proposta
            Else
                dtb_row = dtbItens.Rows(get_linha_item)
            End If

            dtb_row("id_status") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Status.SelectedValue))
            dtb_row("id_status_aprovacao") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Status_Aprovacao.SelectedValue))
            dtb_row("id_justificativa_aprovacao") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Justificativa_Aprovacao.SelectedValue))

            dtb_row("nome4") = GET_DATA_MYSQL("tb_status", "nome", "id_status = " & dtb_row("id_status"))
            dtb_row("nome5") = GET_DATA_MYSQL("tb_status_aprovacao", "nome", "id_status_aprovacao = " & dtb_row("id_status_aprovacao"))
            dtb_row("nome6") = GET_DATA_MYSQL("tb_justificativas_aprovacao", "nome", "id_justificativa_aprovacao = " & dtb_row("id_justificativa_aprovacao"))

            dtb_row("id_usuario") = get_id_usuario
            dtb_row("id_tipo_item") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Tipo_Item.SelectedValue))
            dtb_row("quantidade_item") = 1
            dtb_row("descricao_item") = Trim(txt_Descricao.Text.ToString)
            dtb_row("preco_unitario_inicial_item") = CONVERT_TO_DECIMAL(Trim(nud_Preco_Unitario.Value.ToString))
            dtb_row("login") = get_login_usuario
            dtb_row("prazo_inicial_item") = Trim(txt_Prazo_Inicial.Text.ToString)
            dtb_row("prazo_final_item") = Trim(txt_Prazo_Final.Text.ToString)
            dtb_row("comentarios_item") = Trim(txt_Comentarios.Text.ToString)

            Abrir_Conexao()

            sqlcmd = New MySqlCommand("sp_retorna_tipo_item", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_tipo_item", dtb_row("id_tipo_item"))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            dtb_row("nome") = sqlcmd.Parameters("p_nome").Value.ToString

            If cbo_Tipo_Item.SelectedValue = 1 Then

                dtb_row("quantidade_item") = CONVERT_TO_DECIMAL(Trim(nud_Quantidade.Value.ToString))

                If cbo_Conjunto.SelectedValue > 0 Then
                    dtb_row("id_conjunto") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Conjunto.SelectedValue))
                    dtb_row("nome7") = CONVERT_TO_STRING(cbo_Conjunto.Text)
                Else
                    dtb_row("id_conjunto") = DBNull.Value
                    dtb_row("nome8") = DBNull.Value
                End If

                If cbo_Especificacao.SelectedValue > 0 Then
                    dtb_row("id_especificacao") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Especificacao.SelectedValue))
                    dtb_row("nome8") = CONVERT_TO_STRING(cbo_Especificacao.Text)
                Else
                    dtb_row("id_especificacao") = DBNull.Value
                    dtb_row("nome8") = DBNull.Value
                End If

                dtb_row("id_fornecedor") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Fornecedor.SelectedValue))
                dtb_row("id_tipo_substituicao_tributaria_item") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Tipo_Substituicao_Tributaria.SelectedValue))
                dtb_row("codigo_item") = Trim(cbo_Codigo.Text.ToString)

                dtb_row("percentual_ipi_item") = CONVERT_TO_DECIMAL(Trim(nud_Percentual_IPI.Value.ToString)) / 100
                dtb_row("percentual_icms_item") = CONVERT_TO_DECIMAL(Trim(nud_Percentual_ICMS.Value.ToString)) / 100
                dtb_row("ncm_item") = Trim(txt_NCM.Text.ToString)
                dtb_row("mva_item") = CONVERT_TO_DECIMAL(Trim(nud_Percentual_ICMS.Value.ToString))
                dtb_row("valor_st_item") = CONVERT_TO_DECIMAL(Trim(nud_Valor_ST.Value.ToString))
                dtb_row("valor_total_inicial_item") = CONVERT_TO_DECIMAL(Trim(nud_Preco_Total.Value.ToString))

                dtb_row("desconto_inicial_item") = CONVERT_TO_DECIMAL(Trim(nud_Desconto_Inicial.Value.ToString)) / 100
                dtb_row("desconto_final_item") = CONVERT_TO_DECIMAL(Trim(nud_Desconto_Final.Value.ToString)) / 100

                dtb_row("frete_unitario_item") = CONVERT_TO_DECIMAL(Trim(nud_Frete_Unitario.Value.ToString))
                dtb_row("id_origem_item") = CONVERT_TO_INTEGER(CONVERT_TO_STRING(cbo_Origem.SelectedValue))

                sqlcmd = New MySqlCommand("sp_retorna_fornecedor", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_fornecedor", dtb_row("id_fornecedor"))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                dtb_row("nome1") = sqlcmd.Parameters("p_nome").Value.ToString


                sqlcmd = New MySqlCommand("sp_retorna_tipo_substituicao_tributaria", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_tipo_substituicao_tributaria", dtb_row("id_tipo_substituicao_tributaria_item"))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                dtb_row("nome2") = sqlcmd.Parameters("p_nome").Value.ToString


                sqlcmd = New MySqlCommand("sp_retorna_origem", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_origem", dtb_row("id_origem_item"))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                dtb_row("nome3") = sqlcmd.Parameters("p_nome").Value.ToString

            Else
                dtb_row("valor_total_inicial_item") = CONVERT_TO_DECIMAL(Trim(nud_Preco_Unitario.Value.ToString))
                dtb_row("desconto_final_item") = CONVERT_TO_DECIMAL(Trim(nud_Desconto_Final.Value.ToString)) / 100
                '  dtb_row("prazo_final_item") = Trim(txt_Prazo_Inicial.Text.ToString)
            End If

            Fechar_Conexao()
        Catch ex As System.Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Fechar_Conexao()
        End Try


        If get_linha_item = -1 Then
            dtbItens.Rows.Add(dtb_row)
        End If

        Me.Close()

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub cbo_Fornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Fornecedor.SelectedIndexChanged

        Select Case cbo_Fornecedor.SelectedValue
            Case 1
                If Strings.Left(cbo_Codigo.ToString, 1) = "I" Then
                    cbo_Origem.SelectedValue = 2
                Else
                    cbo_Origem.SelectedValue = 1
                End If
            Case 2
                If CONVERT_TO_DECIMAL(Trim(nud_Percentual_ICMS.ToString)) = 0.04 Then
                    cbo_Origem.SelectedValue = 2
                Else
                    cbo_Origem.SelectedValue = 1
                End If
        End Select

        If cbo_Fornecedor.SelectedValue > 0 Then
            Preencher_ComboBox(cbo_Codigo, "tb_itens_propostas", "descricao_item", "codigo_item", "codigo_item, descricao_item", "id_status=1 AND id_tipo_item=1 AND id_fornecedor=" & cbo_Fornecedor.SelectedValue, "codigo_item", agrupar_por:="codigo_item")
            cbo_Codigo.SelectedValue = -1
            txt_Descricao.Text = ""
        Else
            cbo_Codigo.DataSource = Nothing
        End If

    End Sub

    Private Sub nud_Percentual_ICMS_ValueChanged(sender As Object, e As EventArgs) Handles nud_Percentual_ICMS.ValueChanged
        Select Case cbo_Fornecedor.SelectedValue
            Case 1
                If Strings.Left(cbo_Codigo.ToString, 1) = "I" Then
                    cbo_Origem.SelectedValue = 2
                Else
                    cbo_Origem.SelectedValue = 1
                End If
            Case 2
                If CONVERT_TO_DECIMAL(Trim(nud_Percentual_ICMS.ToString)) = 0.04 Then
                    cbo_Origem.SelectedValue = 2
                Else
                    cbo_Origem.SelectedValue = 1
                End If
        End Select

    End Sub

    Private Sub cbo_Codigo_Leave(sender As Object, e As EventArgs) Handles cbo_Codigo.Leave
        If cbo_Fornecedor.SelectedValue = 1 Then
            If Strings.Left(cbo_Codigo.ToString, 1) = "I" Then
                cbo_Origem.SelectedValue = 2
            Else
                cbo_Origem.SelectedValue = 1
            End If
        Else

        End If
        If CONVERT_TO_DECIMAL(Trim(nud_Percentual_ICMS.ToString)) = 0.04 Then
            cbo_Origem.SelectedValue = 2
        Else
            cbo_Origem.SelectedValue = 1
        End If
        cbo_Codigo.SelectedIndex = cbo_Codigo.FindString(cbo_Codigo.Text)

        txt_Descricao.Text = cbo_Codigo.SelectedValue

        'If cbo_Codigo.Items.Contains(cbo_Codigo.Text) Then
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            Dim dtbCodigoItem = New DataTable

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
                                                   "ip.informacao_estoque_codigo_abreviado_item, ip.prazo_final_item, ip.comentarios_item, ip.data_aprovacao_item, ip.data_edicao_item, ip.id_conjunto, ip.id_especificacao " &
                                                   "FROM tb_itens_propostas AS ip " &
                                                   "WHERE ip.codigo_item = '" & cbo_Codigo.Text & "' ORDER BY ip.data_insercao DESC LIMIT 1", strConexao)

            adapter.Fill(dtbCodigoItem)

            If dtbCodigoItem.Rows.Count > 0 Then
                Dim rowCodigoItem As DataRow = dtbCodigoItem.Rows(0)
                'nud_Quantidade
                nud_Preco_Unitario.Value = CONVERT_TO_DECIMAL(rowCodigoItem("preco_unitario_inicial_item"))
                nud_Percentual_IPI.Value = CONVERT_TO_DECIMAL(rowCodigoItem("percentual_ipi_item")) * 100
                nud_Percentual_ICMS.Value = CONVERT_TO_DECIMAL(rowCodigoItem("percentual_icms_item")) * 100
                txt_NCM.Text = rowCodigoItem("ncm_item")
                nud_MVA.Value = CONVERT_TO_DECIMAL(rowCodigoItem("mva_item"))
                nud_Valor_ST.Value = CONVERT_TO_DECIMAL(rowCodigoItem("valor_st_item"))
                'nud_Preco_Total
                'nud_Frete_Unitario
                'nud_Desconto_Inicial
                'nud_Desconto_Final
                cbo_Tipo_Substituicao_Tributaria.SelectedValue = rowCodigoItem("id_tipo_substituicao_tributaria_item")
                cbo_Origem.SelectedValue = rowCodigoItem("id_origem_item")

                If String.IsNullOrEmpty(CONVERT_TO_STRING(rowCodigoItem("id_conjunto"))) Then
                    cbo_Conjunto.SelectedValue = -1
                Else
                    cbo_Conjunto.SelectedValue = CONVERT_TO_INTEGER(CONVERT_TO_STRING(rowCodigoItem("id_conjunto")))
                End If

                If String.IsNullOrEmpty(CONVERT_TO_STRING(rowCodigoItem("id_especificacao"))) Then
                    cbo_Especificacao.SelectedValue = -1
                Else
                    cbo_Especificacao.SelectedValue = CONVERT_TO_INTEGER(CONVERT_TO_STRING(rowCodigoItem("id_especificacao")))
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub cbo_Codigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Codigo.SelectedIndexChanged
        'If String.IsNullOrEmpty(txt_Descricao.Text) Then
        'txt_Descricao.Text = cbo_Codigo.SelectedValue

        ''If cbo_Codigo.Items.Contains(cbo_Codigo.Text) Then
        'Dim adapter As MySqlDataAdapter

        'Try
        '    Abrir_Conexao()

        '    Dim dtbCodigoItem = New DataTable

        '    adapter = New MySqlDataAdapter("SELECT ip.id_item_proposta, ip.data_insercao, ip.id_usuario, ip.id_status, ip.id_proposta, " &
        '                                           "ip.id_status_aprovacao, ip.id_justificativa_aprovacao, ip.id_tipo_item, ip.id_fornecedor, ip.codigo_item, " &
        '                                           "ip.descricao_item, ip.quantidade_item, ip.preco_unitario_inicial_item, ip.percentual_ipi_item, ip.percentual_icms_item, " &
        '                                           "ip.ncm_item, ip.mva_item, ip.valor_st_item, ip.valor_total_inicial_item, ip.prazo_inicial_item, ip.frete_unitario_item, " &
        '                                           "ip.desconto_inicial_item, ip.id_tipo_substituicao_tributaria_item, ip.id_origem_item, ip.preco_apos_desconto_inicial_item, " &
        '                                           "ip.preco_com_ipi_e_icms_item, ip.percentual_aliquota_externa_icms_item, ip.valor_icms_credito_item, ip.percentual_mva_item, " &
        '                                           "ip.valor_mva_item, ip.preco_com_mva_item, ip.percentual_aliquota_interna_icms_item, ip.valor_icms_debito_item, ip.saldo_icms_item, " &
        '                                           "ip.preco_unitario_para_revendedor_item, ip.impostos_federais_item, ip.rateio_despesa_fixa_item, ip.percentual_lucro_necessario_item, " &
        '                                           "ip.preco_lista_venda_item, ip.desconto_final_item, ip.preco_unitario_final_item, ip.preco_total_final_item, " &
        '                                           "ip.quantidade_estoque_codigo_completo_item, ip.quantidade_estoque_codigo_abreviado_item, ip.informacao_estoque_codigo_completo_item, " &
        '                                           "ip.informacao_estoque_codigo_abreviado_item, ip.prazo_final_item, ip.comentarios_item, ip.data_aprovacao_item, ip.data_edicao_item " &
        '                                           "FROM tb_itens_propostas AS ip " &
        '                                           "WHERE ip.codigo_item = '" & cbo_Codigo.Text & "' ORDER BY ip.data_insercao DESC LIMIT 1", strConexao)

        '    adapter.Fill(dtbCodigoItem)

        '    If dtbCodigoItem.Rows.Count > 0 Then
        '        Dim rowCodigoItem As DataRow = dtbCodigoItem.Rows(0)
        '        'nud_Quantidade
        '        nud_Preco_Unitario.Value = CONVERT_TO_DECIMAL(rowCodigoItem("preco_unitario_inicial_item"))
        '        nud_Percentual_IPI.Value = CONVERT_TO_DECIMAL(rowCodigoItem("percentual_ipi_item")) * 100
        '        nud_Percentual_ICMS.Value = CONVERT_TO_DECIMAL(rowCodigoItem("percentual_icms_item")) * 100
        '        txt_NCM.Text = rowCodigoItem("ncm_item")
        '        nud_MVA.Value = CONVERT_TO_DECIMAL(rowCodigoItem("mva_item"))
        '        nud_Valor_ST.Value = CONVERT_TO_DECIMAL(rowCodigoItem("valor_st_item"))
        '        'nud_Preco_Total
        '        'nud_Frete_Unitario
        '        'nud_Desconto_Inicial
        '        'nud_Desconto_Final
        '        cbo_Tipo_Substituicao_Tributaria.SelectedValue = rowCodigoItem("id_tipo_substituicao_tributaria_item")
        '        cbo_Origem.SelectedValue = rowCodigoItem("id_origem_item")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        'Finally
        '    Fechar_Conexao()
        'End Try

        'End If
    End Sub

    Private Sub nud_Preco_Unitario_ValueChanged(sender As Object, e As EventArgs) Handles nud_Preco_Unitario.ValueChanged
        If cbo_Tipo_Item.SelectedValue = 1 Then
            nud_Preco_Total.Value = nud_Quantidade.Value * nud_Preco_Unitario.Value
        Else
            nud_Preco_Total.Value = nud_Preco_Unitario.Value
        End If
    End Sub

    Private Sub nud_Quantidade_ValueChanged(sender As Object, e As EventArgs) Handles nud_Quantidade.ValueChanged
        If cbo_Tipo_Item.SelectedValue = 1 Then
            nud_Preco_Total.Value = nud_Quantidade.Value * nud_Preco_Unitario.Value
        Else
            nud_Preco_Total.Value = nud_Preco_Unitario.Value
        End If
    End Sub

    Private Sub cbo_Conjunto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Conjunto.SelectedIndexChanged
        If cbo_Conjunto.Text = "" Then
            cbo_Especificacao.DataSource = Nothing
        Else
            Preencher_ComboBox(cbo_Especificacao, "tb_especificacoes", "id_especificacao", "nome", condicoes:="id_status=1 AND id_conjunto = " & cbo_Conjunto.SelectedValue, ordenar_por:="nome")
            cbo_Especificacao.SelectedValue = -1
        End If
    End Sub

    Private Sub nud_Quantidade_Leave(sender As Object, e As EventArgs) Handles nud_Quantidade.Leave
        If nud_Quantidade.Value <> nud_Quantidade_Inicial.Value Then
            If get_linha_item = -1 Then
                MessageBox.Show("Atenção! Lembre-se de verificar o prazo atualizado do fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Atenção! Foi verificado que você alterou a quantidade de peças. Lembre-se que o prazo inicial do fornecedor depende da quantidade de peças que ele
tem disponível, então é altamente recomendável que a quantidade seja sempre a mesma importada do fornecedor." & vbNewLine & "Caso não seja possível manter a quantidade informada da importação
do fornecedor, lembre-se de ajustar o prazo inicial de acordo com a nova quantidade informada, caso contrário o prazo pode não ser calculado devidamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub
End Class