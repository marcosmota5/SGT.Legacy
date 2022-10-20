Imports MySql.Data.MySqlClient
Public Class Termos

    Dim dtb_clientes_todos As New DataTable
    Dim dtb_clientes_selecionados As New DataTable
    Dim dtb_setores_todos As New DataTable
    Dim dtb_setores_selecionados As New DataTable

    Private Sub Carregar_Termos()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT term.id_termo, term.nome, term.texto_padrao, term.observacoes, term.prazo_entrega, term.condicao_pagamento, term.garantia, term.validade,
                                            term.id_status, (CASE WHEN LENGTH(term.texto_padrao)>50 THEN CONCAT(LEFT(term.texto_padrao, 50), '...') ELSE term.texto_padrao END) AS texto_padrao_resumido,
                                            (CASE WHEN LENGTH(term.observacoes)>50 THEN CONCAT(LEFT(term.observacoes, 50), '...') ELSE term.observacoes END) AS observacoes_resumidas, 
                                            (CASE WHEN LENGTH(term.prazo_entrega)>50 THEN CONCAT(LEFT(term.prazo_entrega, 50), '...') ELSE term.prazo_entrega END) AS prazo_entrega_resumido, 
                                            (CASE WHEN LENGTH(term.condicao_pagamento)>50 THEN CONCAT(LEFT(term.condicao_pagamento, 50), '...') ELSE term.condicao_pagamento END) AS condicao_pagamento_resumida, 
                                            (CASE WHEN LENGTH(term.garantia)>50 THEN CONCAT(LEFT(term.garantia, 50), '...') ELSE term.garantia END) AS garantia_resumida, 
                                            (CASE WHEN LENGTH(term.validade)>50 THEN CONCAT(LEFT(term.validade, 50), '...') ELSE term.validade END) AS validade_resumida, stat.nome
                                            FROM tb_termos AS term LEFT JOIN tb_status AS stat ON term.id_status = stat.id_status ORDER BY term.nome", strConexao)

            adapter.Fill(dtb)
            dtg_Itens.DataSource = dtb

            Formatar_Datagrid()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub Carregar_Clientes()

        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            dtb_clientes_selecionados.Clear()
            'Carrega clientes selecionados
            adapter = New MySqlDataAdapter("SELECT DISTINCT term_sup.id_cliente, clie.nome FROM tb_termos_suporte AS term_sup LEFT JOIN tb_clientes AS clie ON term_sup.id_cliente = clie.id_cliente WHERE term_sup.id_cliente IS NOT NULL AND term_sup.id_termo = " & CONVERT_TO_INTEGER(txt_id_termo.Text.ToString) & " ORDER BY clie.nome", strConexao)

            adapter.Fill(dtb_clientes_selecionados)
            dtg_Cliente_Selecionados.DataSource = dtb_clientes_selecionados

            dtg_Cliente_Selecionados.Columns("id_cliente").HeaderText = "ID do Cliente"
            dtg_Cliente_Selecionados.Columns("nome").HeaderText = "Nome do cliente"
            dtg_Cliente_Selecionados.Columns("id_cliente").Visible = False
            dtg_Cliente_Selecionados.Columns("nome").Visible = True

            dtb_clientes_todos.Clear()
            'Carrega todos os clientes excluindo os selecionados
            adapter = New MySqlDataAdapter("SELECT id_cliente, nome FROM tb_clientes WHERE id_cliente NOT IN (SELECT DISTINCT id_cliente FROM tb_termos_suporte WHERE id_cliente IS NOT NULL AND id_termo = " & CONVERT_TO_INTEGER(txt_id_termo.Text.ToString) & ") ORDER BY nome", strConexao)

            adapter.Fill(dtb_clientes_todos)
            dtg_Cliente_Todos.DataSource = dtb_clientes_todos

            dtg_Cliente_Todos.Columns("id_cliente").HeaderText = "ID do Cliente"
            dtg_Cliente_Todos.Columns("nome").HeaderText = "Nome do cliente"
            dtg_Cliente_Todos.Columns("id_cliente").Visible = False
            dtg_Cliente_Todos.Columns("nome").Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Carregar_Setores()

        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            'Carrega setores selecionados

            dtb_setores_selecionados.Clear()
            adapter = New MySqlDataAdapter("SELECT DISTINCT term_sup.id_setor, seto.nome FROM tb_termos_suporte AS term_sup LEFT JOIN tb_setores AS seto ON term_sup.id_setor = seto.id_setor WHERE term_sup.id_setor IS NOT NULL AND term_sup.id_termo = " & CONVERT_TO_INTEGER(txt_id_termo.Text.ToString) & " ORDER BY seto.nome", strConexao)

            adapter.Fill(dtb_setores_selecionados)
            dtg_Setor_Selecionados.DataSource = dtb_setores_selecionados

            dtg_Setor_Selecionados.Columns("id_setor").HeaderText = "ID do Setor"
            dtg_Setor_Selecionados.Columns("nome").HeaderText = "Nome do Setor"
            dtg_Setor_Selecionados.Columns("id_setor").Visible = False
            dtg_Setor_Selecionados.Columns("nome").Visible = True

            dtb_setores_todos.Clear()
            'Carrega todos os setores excluindo os selecionados
            adapter = New MySqlDataAdapter("SELECT id_setor, nome FROM tb_setores WHERE id_setor NOT IN (SELECT DISTINCT id_setor FROM tb_termos_suporte WHERE id_setor IS NOT NULL AND id_termo = " & CONVERT_TO_INTEGER(txt_id_termo.Text.ToString) & ") ORDER BY nome", strConexao)

            adapter.Fill(dtb_setores_todos)
            dtg_Setor_Todos.DataSource = dtb_setores_todos

            dtg_Setor_Todos.Columns("id_setor").HeaderText = "ID do Setor"
            dtg_Setor_Todos.Columns("nome").HeaderText = "Nome do Setor"
            dtg_Setor_Todos.Columns("id_setor").Visible = False
            dtg_Setor_Todos.Columns("nome").Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Formatar_Datagrid()

        dtg_Itens.Columns("id_termo").HeaderText = "ID do Termo"
        dtg_Itens.Columns("nome").HeaderText = "Nome do termo"
        dtg_Itens.Columns("texto_padrao").HeaderText = "Texto inicial completo"
        dtg_Itens.Columns("observacoes").HeaderText = "Observações completas"
        dtg_Itens.Columns("prazo_entrega").HeaderText = "Prazo de entrega completo"
        dtg_Itens.Columns("condicao_pagamento").HeaderText = "Condição de pagamento completa"
        dtg_Itens.Columns("garantia").HeaderText = "Garantia completa"
        dtg_Itens.Columns("validade").HeaderText = "Validade completa"

        dtg_Itens.Columns("texto_padrao_resumido").HeaderText = "Texto inicial"
        dtg_Itens.Columns("observacoes_resumidas").HeaderText = "Observações"
        dtg_Itens.Columns("prazo_entrega_resumido").HeaderText = "Prazo de entrega"
        dtg_Itens.Columns("condicao_pagamento_resumida").HeaderText = "Condição de pagamento"
        dtg_Itens.Columns("garantia_resumida").HeaderText = "Garantia"
        dtg_Itens.Columns("validade_resumida").HeaderText = "Validade"

        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("nome1").HeaderText = "Status"

        dtg_Itens.Columns("id_termo").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("texto_padrao").Visible = False
        dtg_Itens.Columns("observacoes").Visible = False
        dtg_Itens.Columns("prazo_entrega").Visible = False
        dtg_Itens.Columns("condicao_pagamento").Visible = False
        dtg_Itens.Columns("garantia").Visible = False
        dtg_Itens.Columns("validade").Visible = False

        dtg_Itens.Columns("texto_padrao_resumido").Visible = True
        dtg_Itens.Columns("observacoes_resumidas").Visible = True
        dtg_Itens.Columns("prazo_entrega_resumido").Visible = True
        dtg_Itens.Columns("condicao_pagamento_resumida").Visible = True
        dtg_Itens.Columns("garantia_resumida").Visible = True
        dtg_Itens.Columns("validade_resumida").Visible = True

        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("nome1").Visible = True

    End Sub

    Private Sub Termos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Termos()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")


        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Texto_Padrao.Enabled = False
        txt_Texto_Padrao.Enabled = False
        lbl_Observacoes.Enabled = False
        txt_Observacoes.Enabled = False
        lbl_Prazo_Entrega.Enabled = False
        txt_Prazo_Entrega.Enabled = False
        lbl_Condicao_Pagamento.Enabled = False
        txt_Condicao_Pagamento.Enabled = False
        lbl_Garantia.Enabled = False
        txt_Garantia.Enabled = False
        lbl_Validade.Enabled = False
        txt_Validade.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False

        btn_Passar_Direita_Setor_Todos.Enabled = False
        btn_Passar_Direita_Setor_Unico.Enabled = False
        btn_Passar_Esquerda_Setor_Unico.Enabled = False
        btn_Passar_Esquerda_Setor_Todos.Enabled = False

        btn_Passar_Direita_Cliente_Todos.Enabled = False
        btn_Passar_Direita_Cliente_Unico.Enabled = False
        btn_Passar_Esquerda_Cliente_Unico.Enabled = False
        btn_Passar_Esquerda_Cliente_Todos.Enabled = False

        Me.Height = 613

        txt_id_termo.Text = ""
        txt_Nome.Text = ""
        txt_Texto_Padrao.Text = ""
        txt_Observacoes.Text = ""
        txt_Prazo_Entrega.Text = ""
        txt_Condicao_Pagamento.Text = ""
        txt_Garantia.Text = ""
        txt_Validade.Text = ""
        cbo_Status.SelectedValue = -1

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Texto_Padrao.Enabled = True
        txt_Texto_Padrao.Enabled = True
        lbl_Observacoes.Enabled = True
        txt_Observacoes.Enabled = True
        lbl_Prazo_Entrega.Enabled = True
        txt_Prazo_Entrega.Enabled = True
        lbl_Condicao_Pagamento.Enabled = True
        txt_Condicao_Pagamento.Enabled = True
        lbl_Garantia.Enabled = True
        txt_Garantia.Enabled = True
        lbl_Validade.Enabled = True
        txt_Validade.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True

        btn_Passar_Direita_Setor_Todos.Enabled = True
        btn_Passar_Direita_Setor_Unico.Enabled = True
        btn_Passar_Esquerda_Setor_Unico.Enabled = True
        btn_Passar_Esquerda_Setor_Todos.Enabled = True

        btn_Passar_Direita_Cliente_Todos.Enabled = True
        btn_Passar_Direita_Cliente_Unico.Enabled = True
        btn_Passar_Esquerda_Cliente_Unico.Enabled = True
        btn_Passar_Esquerda_Cliente_Todos.Enabled = True

        Me.Height = 639

        txt_id_termo.Text = ""
        txt_Nome.Text = ""
        txt_Texto_Padrao.Text = ""
        txt_Observacoes.Text = ""
        txt_Prazo_Entrega.Text = ""
        txt_Condicao_Pagamento.Text = ""
        txt_Garantia.Text = ""
        txt_Validade.Text = ""
        cbo_Status.SelectedValue = -1

        txt_Nome.Focus()
    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_termo.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Texto_Padrao.Enabled = True
        txt_Texto_Padrao.Enabled = True
        lbl_Observacoes.Enabled = True
        txt_Observacoes.Enabled = True
        lbl_Prazo_Entrega.Enabled = True
        txt_Prazo_Entrega.Enabled = True
        lbl_Condicao_Pagamento.Enabled = True
        txt_Condicao_Pagamento.Enabled = True
        lbl_Garantia.Enabled = True
        txt_Garantia.Enabled = True
        lbl_Validade.Enabled = True
        txt_Validade.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True

        btn_Passar_Direita_Setor_Todos.Enabled = True
        btn_Passar_Direita_Setor_Unico.Enabled = True
        btn_Passar_Esquerda_Setor_Unico.Enabled = True
        btn_Passar_Esquerda_Setor_Todos.Enabled = True

        btn_Passar_Direita_Cliente_Todos.Enabled = True
        btn_Passar_Direita_Cliente_Unico.Enabled = True
        btn_Passar_Esquerda_Cliente_Unico.Enabled = True
        btn_Passar_Esquerda_Cliente_Todos.Enabled = True

        Me.Height = 639

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_termo.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o termo " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_termo", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_termo", CONVERT_TO_INTEGER(txt_id_termo.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O termo '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Termo '" & txt_Nome.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Termos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Texto_Padrao.Enabled = False
            txt_Texto_Padrao.Enabled = False
            lbl_Observacoes.Enabled = False
            txt_Observacoes.Enabled = False
            lbl_Prazo_Entrega.Enabled = False
            txt_Prazo_Entrega.Enabled = False
            lbl_Condicao_Pagamento.Enabled = False
            txt_Condicao_Pagamento.Enabled = False
            lbl_Garantia.Enabled = False
            txt_Garantia.Enabled = False
            lbl_Validade.Enabled = False
            txt_Validade.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            btn_Passar_Direita_Setor_Todos.Enabled = False
            btn_Passar_Direita_Setor_Unico.Enabled = False
            btn_Passar_Esquerda_Setor_Unico.Enabled = False
            btn_Passar_Esquerda_Setor_Todos.Enabled = False

            btn_Passar_Direita_Cliente_Todos.Enabled = False
            btn_Passar_Direita_Cliente_Unico.Enabled = False
            btn_Passar_Esquerda_Cliente_Unico.Enabled = False
            btn_Passar_Esquerda_Cliente_Todos.Enabled = False


            Me.Height = 613

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Texto_Padrao.Enabled = False
        txt_Texto_Padrao.Enabled = False
        lbl_Observacoes.Enabled = False
        txt_Observacoes.Enabled = False
        lbl_Prazo_Entrega.Enabled = False
        txt_Prazo_Entrega.Enabled = False
        lbl_Condicao_Pagamento.Enabled = False
        txt_Condicao_Pagamento.Enabled = False
        lbl_Garantia.Enabled = False
        txt_Garantia.Enabled = False
        lbl_Validade.Enabled = False
        txt_Validade.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False

        btn_Passar_Direita_Setor_Todos.Enabled = False
        btn_Passar_Direita_Setor_Unico.Enabled = False
        btn_Passar_Esquerda_Setor_Unico.Enabled = False
        btn_Passar_Esquerda_Setor_Todos.Enabled = False

        btn_Passar_Direita_Cliente_Todos.Enabled = False
        btn_Passar_Direita_Cliente_Unico.Enabled = False
        btn_Passar_Esquerda_Cliente_Unico.Enabled = False
        btn_Passar_Esquerda_Cliente_Todos.Enabled = False

        Me.Height = 613

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_termo.Text = ""
            txt_Nome.Text = ""
            txt_Texto_Padrao.Text = ""
            txt_Observacoes.Text = ""
            txt_Prazo_Entrega.Text = ""
            txt_Condicao_Pagamento.Text = ""
            txt_Garantia.Text = ""
            txt_Validade.Text = ""
            cbo_Status.SelectedValue = -1

        Else

            mnsi_Editar.Enabled = True

            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_clientes", "id_termo", "id_termo = " & txt_id_termo.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem clientes cadastrados com esse termo. Portanto, não será possível excluí-lo"
            End If

        End If

        Carregar_Clientes()
        Carregar_Setores()

    End Sub
    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Dim strObrigatorios As String = ""

        If txt_Nome.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Nome.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Nome.Text
            End If
            lbl_Nome.ForeColor = Color.Red
        Else
            lbl_Nome.ForeColor = Color.Black
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

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand
        Dim id_termo_associar As Integer

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then
                sqlcmd = New MySqlCommand("sp_inserir_termo", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_texto_padrao", txt_Texto_Padrao.Text)
                sqlcmd.Parameters.AddWithValue("p_observacoes", txt_Observacoes.Text)
                sqlcmd.Parameters.AddWithValue("p_prazo_entrega", txt_Prazo_Entrega.Text)
                sqlcmd.Parameters.AddWithValue("p_condicao_pagamento", txt_Condicao_Pagamento.Text)
                sqlcmd.Parameters.AddWithValue("p_garantia", txt_Garantia.Text)
                sqlcmd.Parameters.AddWithValue("p_validade", txt_Validade.Text)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_id_termo", MySqlDbType.Int32).Direction = 2
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O termo '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Termo '" & txt_Nome.Text & "' inserido com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    id_termo_associar = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_termo").Value)
                End If
            Else
                If txt_id_termo.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_termo", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_termo", CONVERT_TO_INTEGER(txt_id_termo.Text))
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_texto_padrao", txt_Texto_Padrao.Text)
                sqlcmd.Parameters.AddWithValue("p_observacoes", txt_Observacoes.Text)
                sqlcmd.Parameters.AddWithValue("p_prazo_entrega", txt_Prazo_Entrega.Text)
                sqlcmd.Parameters.AddWithValue("p_condicao_pagamento", txt_Condicao_Pagamento.Text)
                sqlcmd.Parameters.AddWithValue("p_garantia", txt_Garantia.Text)
                sqlcmd.Parameters.AddWithValue("p_validade", txt_Validade.Text)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("O termo '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Termo '" & txt_Nome.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    id_termo_associar = CONVERT_TO_INTEGER(txt_id_termo.Text)
                End If
            End If

            'Deleta todos os registros do termo suporte
            sqlcmd = New MySqlCommand("sp_excluir_termo_suporte", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_termo", id_termo_associar)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            'Insere termos suporte
            If dtb_setores_selecionados.Rows.Count = 0 Then

                For Each row_cliente As DataRow In dtb_clientes_selecionados.Rows
                    sqlcmd = New MySqlCommand("sp_inserir_termo_suporte", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_termo", id_termo_associar)
                    sqlcmd.Parameters.AddWithValue("p_id_cliente", CONVERT_TO_INTEGER(row_cliente("id_cliente").ToString))
                    sqlcmd.Parameters.AddWithValue("p_id_setor", DBNull.Value)
                    sqlcmd.Parameters.AddWithValue("p_id_status", 1)
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                Next

            Else

                For Each row_setor As DataRow In dtb_setores_selecionados.Rows
                    For Each row_cliente As DataRow In dtb_clientes_selecionados.Rows
                        sqlcmd = New MySqlCommand("sp_inserir_termo_suporte", strConexao)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("p_id_termo", id_termo_associar)
                        sqlcmd.Parameters.AddWithValue("p_id_cliente", CONVERT_TO_INTEGER(row_cliente("id_cliente").ToString))
                        sqlcmd.Parameters.AddWithValue("p_id_setor", CONVERT_TO_INTEGER(row_setor("id_setor").ToString))
                        sqlcmd.Parameters.AddWithValue("p_id_status", 1)
                        sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                        sqlcmd.ExecuteNonQuery()
                    Next
                Next

            End If

            Carregar_Termos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Texto_Padrao.Enabled = False
            txt_Texto_Padrao.Enabled = False
            lbl_Observacoes.Enabled = False
            txt_Observacoes.Enabled = False
            lbl_Prazo_Entrega.Enabled = False
            txt_Prazo_Entrega.Enabled = False
            lbl_Condicao_Pagamento.Enabled = False
            txt_Condicao_Pagamento.Enabled = False
            lbl_Garantia.Enabled = False
            txt_Garantia.Enabled = False
            lbl_Validade.Enabled = False
            txt_Validade.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            btn_Passar_Direita_Setor_Todos.Enabled = False
            btn_Passar_Direita_Setor_Unico.Enabled = False
            btn_Passar_Esquerda_Setor_Unico.Enabled = False
            btn_Passar_Esquerda_Setor_Todos.Enabled = False

            btn_Passar_Direita_Cliente_Todos.Enabled = False
            btn_Passar_Direita_Cliente_Unico.Enabled = False
            btn_Passar_Esquerda_Cliente_Unico.Enabled = False
            btn_Passar_Esquerda_Cliente_Todos.Enabled = False

            Me.Height = 613

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub txt_Nome_TextChanged(sender As Object, e As EventArgs) Handles txt_Nome.TextChanged
        If txt_Nome.Text = "" Then
            lbl_Nome.ForeColor = Color.Red
        Else
            lbl_Nome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cbo_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged
        If cbo_Status.Text = "" Then
            lbl_Status.ForeColor = Color.Red
        Else
            lbl_Status.ForeColor = Color.Black
        End If
    End Sub

    Private Sub mnsi_Fechar_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub Status_Aprovacao_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub

    Private Sub DefinirParaTodosOsClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If txt_id_termo.Text = "" Then
            Exit Sub
        End If

        If MessageBox.Show(text:="Tem certeza que deseja definir o termo'" & txt_Nome.Text & "' para todos os clientes? O procedimento não poderá ser desfeito", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
            Exit Sub
        End If

        Dim cmd As MySqlCommand
        Try
            Abrir_Conexao()

            cmd = New MySqlCommand("UPDATE tb_clientes SET id_termo = " & CONVERT_TO_INTEGER(txt_id_termo.Text), strConexao)
            cmd.ExecuteNonQuery()

            MessageBox.Show("O termo '" & txt_Nome.Text & "' foi definido para todos clientes com sucesso!", "Operação realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged

        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_termo.Text = dtg_Itens.CurrentRow.Cells("id_termo").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value
        txt_Texto_Padrao.Text = dtg_Itens.CurrentRow.Cells("texto_padrao").Value
        txt_Observacoes.Text = dtg_Itens.CurrentRow.Cells("observacoes").Value
        txt_Prazo_Entrega.Text = dtg_Itens.CurrentRow.Cells("prazo_entrega").Value
        txt_Condicao_Pagamento.Text = dtg_Itens.CurrentRow.Cells("condicao_pagamento").Value
        txt_Garantia.Text = dtg_Itens.CurrentRow.Cells("garantia").Value
        txt_Validade.Text = dtg_Itens.CurrentRow.Cells("validade").Value
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value
        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True

        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_clientes", "id_termo", "id_termo = " & txt_id_termo.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem clientes cadastrados com esse termo. Portanto, não será possível excluí-lo"
        End If

        Carregar_Clientes()
        Carregar_Setores()

    End Sub

    Private Sub btn_Passar_Direita_Cliente_Todos_Click(sender As Object, e As EventArgs) Handles btn_Passar_Direita_Cliente_Todos.Click

        Dim nova_linha As DataRow

        For Each row_todos As DataRow In dtb_clientes_todos.Rows

            nova_linha = dtb_clientes_selecionados.NewRow

            nova_linha("id_cliente") = row_todos("id_cliente")
            nova_linha("nome") = row_todos("nome")

            dtb_clientes_selecionados.Rows.Add(nova_linha)

        Next

        dtb_clientes_todos.Rows.Clear()

    End Sub

    Private Sub btn_Passar_Direita_Cliente_Unico_Click(sender As Object, e As EventArgs) Handles btn_Passar_Direita_Cliente_Unico.Click

        Dim linha_selecionada As DataRow
        Dim nova_linha As DataRow
        Dim indice_linha As Integer

        For Each row_todos As DataGridViewRow In dtg_Cliente_Todos.SelectedRows

            indice_linha = CONVERT_TO_INTEGER(CONVERT_TO_STRING(row_todos.Index))
            linha_selecionada = dtb_clientes_todos.Rows(indice_linha)

            nova_linha = dtb_clientes_selecionados.NewRow

            nova_linha("id_cliente") = linha_selecionada("id_cliente")
            nova_linha("nome") = linha_selecionada("nome")

            dtb_clientes_selecionados.Rows.Add(nova_linha)
            dtb_clientes_todos.Rows.Remove(linha_selecionada)

        Next

    End Sub

    Private Sub btn_Passar_Esquerda_Cliente_Todos_Click(sender As Object, e As EventArgs) Handles btn_Passar_Esquerda_Cliente_Todos.Click

        Dim nova_linha As DataRow

        For Each row_todos As DataRow In dtb_clientes_selecionados.Rows

            nova_linha = dtb_clientes_todos.NewRow

            nova_linha("id_cliente") = row_todos("id_cliente")
            nova_linha("nome") = row_todos("nome")

            dtb_clientes_todos.Rows.Add(nova_linha)

        Next

        dtb_clientes_selecionados.Rows.Clear()

    End Sub

    Private Sub btn_Passar_Esquerda_Cliente_Unico_Click(sender As Object, e As EventArgs) Handles btn_Passar_Esquerda_Cliente_Unico.Click

        Dim linha_selecionada As DataRow
        Dim nova_linha As DataRow
        Dim indice_linha As Integer

        For Each row_selecionados As DataGridViewRow In dtg_Cliente_Selecionados.SelectedRows

            indice_linha = CONVERT_TO_INTEGER(CONVERT_TO_STRING(row_selecionados.Index))
            linha_selecionada = dtb_clientes_selecionados.Rows(indice_linha)

            nova_linha = dtb_clientes_todos.NewRow

            nova_linha("id_cliente") = linha_selecionada("id_cliente")
            nova_linha("nome") = linha_selecionada("nome")

            dtb_clientes_todos.Rows.Add(nova_linha)
            dtb_clientes_selecionados.Rows.Remove(linha_selecionada)

        Next

    End Sub


    '''''''''
    '''

    Private Sub btn_Passar_Direita_Setor_Todos_Click(sender As Object, e As EventArgs) Handles btn_Passar_Direita_Setor_Todos.Click

        Dim nova_linha As DataRow

        For Each row_todos As DataRow In dtb_setores_todos.Rows

            nova_linha = dtb_setores_selecionados.NewRow

            nova_linha("id_setor") = row_todos("id_setor")
            nova_linha("nome") = row_todos("nome")

            dtb_setores_selecionados.Rows.Add(nova_linha)

        Next

        dtb_setores_todos.Rows.Clear()

    End Sub

    Private Sub btn_Passar_Direita_Setor_Unico_Click(sender As Object, e As EventArgs) Handles btn_Passar_Direita_Setor_Unico.Click

        Dim linha_selecionada As DataRow
        Dim nova_linha As DataRow
        Dim indice_linha As Integer

        For Each row_todos As DataGridViewRow In dtg_Setor_Todos.SelectedRows

            indice_linha = CONVERT_TO_INTEGER(CONVERT_TO_STRING(row_todos.Index))
            linha_selecionada = dtb_setores_todos.Rows(indice_linha)

            nova_linha = dtb_setores_selecionados.NewRow

            nova_linha("id_setor") = linha_selecionada("id_setor")
            nova_linha("nome") = linha_selecionada("nome")

            dtb_setores_selecionados.Rows.Add(nova_linha)
            dtb_setores_todos.Rows.Remove(linha_selecionada)

        Next

    End Sub

    Private Sub btn_Passar_Esquerda_Setor_Todos_Click(sender As Object, e As EventArgs) Handles btn_Passar_Esquerda_Setor_Todos.Click

        Dim nova_linha As DataRow

        For Each row_todos As DataRow In dtb_setores_selecionados.Rows

            nova_linha = dtb_setores_todos.NewRow

            nova_linha("id_setor") = row_todos("id_setor")
            nova_linha("nome") = row_todos("nome")

            dtb_setores_todos.Rows.Add(nova_linha)

        Next

        dtb_setores_selecionados.Rows.Clear()

    End Sub

    Private Sub btn_Passar_Esquerda_Setor_Unico_Click(sender As Object, e As EventArgs) Handles btn_Passar_Esquerda_Setor_Unico.Click

        Dim linha_selecionada As DataRow
        Dim nova_linha As DataRow
        Dim indice_linha As Integer

        For Each row_selecionados As DataGridViewRow In dtg_Setor_Selecionados.SelectedRows

            indice_linha = CONVERT_TO_INTEGER(CONVERT_TO_STRING(row_selecionados.Index))
            linha_selecionada = dtb_setores_selecionados.Rows(indice_linha)

            nova_linha = dtb_setores_todos.NewRow

            nova_linha("id_setor") = linha_selecionada("id_setor")
            nova_linha("nome") = linha_selecionada("nome")

            dtb_setores_todos.Rows.Add(nova_linha)
            dtb_setores_selecionados.Rows.Remove(linha_selecionada)

        Next

    End Sub

End Class