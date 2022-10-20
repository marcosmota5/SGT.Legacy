Imports MySql.Data.MySqlClient
Public Class Filiais


    Private Sub Carregar_Filiais()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT fili.id_filial, fili.nome, fili.id_empresa, fili.id_pais, fili.id_estado, fili.id_cidade, fili.endereco, fili.CEP, fili.telefone_geral, fili.telefone_pecas, 
                                            fili.telefone_servicos, fili.email_geral, fili.email_pecas, fili.email_servicos, fili.id_status, empr.razao_social AS nome_empresa, 
                                            pais.nome AS nome_pais, esta.nome AS nome_estado, cida.nome AS nome_cidade, stat.nome AS nome_status FROM tb_filiais AS fili
                                            LEFT JOIN tb_empresas AS empr ON empr.id_empresa = fili.id_empresa 
                                            LEFT JOIN tb_paises AS pais ON pais.id_pais = fili.id_pais
                                            LEFT JOIN tb_estados AS esta ON esta.id_estado = fili.id_estado
                                            LEFT JOIN tb_cidades AS cida ON cida.id_cidade = fili.id_cidade
                                            LEFT JOIN tb_status AS stat ON stat.id_status = fili.id_status ORDER BY fili.nome", strConexao)

            adapter.Fill(dtb)
            dtg_Itens.DataSource = dtb

            Formatar_Datagrid()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Formatar_Datagrid()

        dtg_Itens.Columns("id_filial").HeaderText = "ID da Filial"
        dtg_Itens.Columns("nome").HeaderText = "Filial"
        dtg_Itens.Columns("id_empresa").HeaderText = "ID da Empresa"
        dtg_Itens.Columns("id_pais").HeaderText = "ID do País"
        dtg_Itens.Columns("id_estado").HeaderText = "ID do Estado"
        dtg_Itens.Columns("id_cidade").HeaderText = "ID da Cidade"
        dtg_Itens.Columns("endereco").HeaderText = "Endereço"
        dtg_Itens.Columns("CEP").HeaderText = "CEP"
        dtg_Itens.Columns("telefone_geral").HeaderText = "Telefone geral"
        dtg_Itens.Columns("telefone_pecas").HeaderText = "Telefone peças"
        dtg_Itens.Columns("telefone_servicos").HeaderText = "Telefone serviços"
        dtg_Itens.Columns("email_geral").HeaderText = "E-mail geral"
        dtg_Itens.Columns("email_pecas").HeaderText = "E-mail peças"
        dtg_Itens.Columns("email_servicos").HeaderText = "E-mail serviços"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("nome_empresa").HeaderText = "Empresa"
        dtg_Itens.Columns("nome_pais").HeaderText = "País"
        dtg_Itens.Columns("nome_estado").HeaderText = "Estado"
        dtg_Itens.Columns("nome_cidade").HeaderText = "Cidade"
        dtg_Itens.Columns("nome_status").HeaderText = "Status"


        dtg_Itens.Columns("id_filial").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("id_empresa").Visible = False
        dtg_Itens.Columns("id_pais").Visible = False
        dtg_Itens.Columns("id_estado").Visible = False
        dtg_Itens.Columns("id_cidade").Visible = False
        dtg_Itens.Columns("telefone_geral").Visible = True
        dtg_Itens.Columns("telefone_pecas").Visible = True
        dtg_Itens.Columns("telefone_servicos").Visible = True
        dtg_Itens.Columns("email_geral").Visible = True
        dtg_Itens.Columns("email_pecas").Visible = True
        dtg_Itens.Columns("email_servicos").Visible = True
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("nome_empresa").Visible = True
        dtg_Itens.Columns("nome_pais").Visible = True
        dtg_Itens.Columns("nome_estado").Visible = True
        dtg_Itens.Columns("nome_cidade").Visible = True
        dtg_Itens.Columns("nome_status").Visible = True

    End Sub

    Private Sub Filiais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Filiais()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Empresa, "tb_empresas", "id_empresa", "razao_social", condicoes:="id_status=1", ordenar_por:="razao_social")
        Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Empresa.Enabled = False
        cbo_Empresa.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        lbl_Telefone_Geral.Enabled = False
        mkt_Telefone_Geral.Enabled = False
        lbl_Telefone_Pecas.Enabled = False
        mkt_Telefone_Pecas.Enabled = False
        lbl_Telefone_Servicos.Enabled = False
        mkt_Telefone_Servicos.Enabled = False
        lbl_Email_Geral.Enabled = False
        txt_Email_Geral.Enabled = False
        lbl_Email_Pecas.Enabled = False
        txt_Email_Pecas.Enabled = False
        lbl_Email_Servicos.Enabled = False
        txt_Email_Servicos.Enabled = False
        lbl_Pais.Enabled = False
        cbo_Pais.Enabled = False
        lbl_Estado.Enabled = False
        cbo_Estado.Enabled = False
        lbl_Cidade.Enabled = False
        cbo_Cidade.Enabled = False
        lbl_Endereco.Enabled = False
        txt_Endereco.Enabled = False
        lbl_CEP.Enabled = False
        mkt_CEP.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 565

        txt_id_filial.Text = ""
        txt_Nome.Text = ""
        cbo_Empresa.SelectedValue = -1
        cbo_Status.SelectedValue = -1
        mkt_Telefone_Geral.Text = ""
        mkt_Telefone_Pecas.Text = ""
        mkt_Telefone_Servicos.Text = ""
        txt_Email_Geral.Text = ""
        txt_Email_Pecas.Text = ""
        txt_Email_Servicos.Text = ""
        cbo_Pais.SelectedValue = -1
        cbo_Estado.SelectedValue = -1
        cbo_Cidade.SelectedValue = -1
        txt_Endereco.Text = ""
        mkt_CEP.Text = ""

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Empresa.Enabled = True
        cbo_Empresa.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        lbl_Telefone_Geral.Enabled = True
        mkt_Telefone_Geral.Enabled = True
        lbl_Telefone_Pecas.Enabled = True
        mkt_Telefone_Pecas.Enabled = True
        lbl_Telefone_Servicos.Enabled = True
        mkt_Telefone_Servicos.Enabled = True
        lbl_Email_Geral.Enabled = True
        txt_Email_Geral.Enabled = True
        lbl_Email_Pecas.Enabled = True
        txt_Email_Pecas.Enabled = True
        lbl_Email_Servicos.Enabled = True
        txt_Email_Servicos.Enabled = True
        lbl_Pais.Enabled = True
        cbo_Pais.Enabled = True
        lbl_Estado.Enabled = True
        cbo_Estado.Enabled = True
        lbl_Cidade.Enabled = True
        cbo_Cidade.Enabled = True
        lbl_Endereco.Enabled = True
        txt_Endereco.Enabled = True
        lbl_CEP.Enabled = True
        mkt_CEP.Enabled = True

        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 600

        txt_id_filial.Text = ""
        txt_Nome.Text = ""
        cbo_Empresa.SelectedValue = -1
        cbo_Status.SelectedValue = -1
        mkt_Telefone_Geral.Text = ""
        mkt_Telefone_Pecas.Text = ""
        mkt_Telefone_Servicos.Text = ""
        txt_Email_Geral.Text = ""
        txt_Email_Pecas.Text = ""
        txt_Email_Servicos.Text = ""
        cbo_Pais.SelectedValue = -1
        cbo_Estado.SelectedValue = -1
        cbo_Cidade.SelectedValue = -1
        txt_Endereco.Text = ""
        mkt_CEP.Text = ""
        txt_Nome.Focus()

    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_filial.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Empresa.Enabled = True
        cbo_Empresa.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        lbl_Telefone_Geral.Enabled = True
        mkt_Telefone_Geral.Enabled = True
        lbl_Telefone_Pecas.Enabled = True
        mkt_Telefone_Pecas.Enabled = True
        lbl_Telefone_Servicos.Enabled = True
        mkt_Telefone_Servicos.Enabled = True
        lbl_Email_Geral.Enabled = True
        txt_Email_Geral.Enabled = True
        lbl_Email_Pecas.Enabled = True
        txt_Email_Pecas.Enabled = True
        lbl_Email_Servicos.Enabled = True
        txt_Email_Servicos.Enabled = True
        lbl_Pais.Enabled = True
        cbo_Pais.Enabled = True
        lbl_Estado.Enabled = True
        cbo_Estado.Enabled = True
        lbl_Cidade.Enabled = True
        cbo_Cidade.Enabled = True
        lbl_Endereco.Enabled = True
        txt_Endereco.Enabled = True
        lbl_CEP.Enabled = True
        mkt_CEP.Enabled = True

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 600

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_filial.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir a filial " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_filial", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_filial", CONVERT_TO_INTEGER(txt_id_filial.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("A filial '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Filial '" & txt_Nome.Text & "' excluída com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Filiais()

            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Empresa, "tb_empresas", "id_empresa", "razao_social", condicoes:="id_status=1", ordenar_por:="razao_social")
            Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Empresa.Enabled = False
            cbo_Empresa.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            lbl_Telefone_Geral.Enabled = False
            mkt_Telefone_Geral.Enabled = False
            lbl_Telefone_Pecas.Enabled = False
            mkt_Telefone_Pecas.Enabled = False
            lbl_Telefone_Servicos.Enabled = False
            mkt_Telefone_Servicos.Enabled = False
            lbl_Email_Geral.Enabled = False
            txt_Email_Geral.Enabled = False
            lbl_Email_Pecas.Enabled = False
            txt_Email_Pecas.Enabled = False
            lbl_Email_Servicos.Enabled = False
            txt_Email_Servicos.Enabled = False
            lbl_Pais.Enabled = False
            cbo_Pais.Enabled = False
            lbl_Estado.Enabled = False
            cbo_Estado.Enabled = False
            lbl_Cidade.Enabled = False
            cbo_Cidade.Enabled = False
            lbl_Endereco.Enabled = False
            txt_Endereco.Enabled = False
            lbl_CEP.Enabled = False
            mkt_CEP.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            Me.Height = 565

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
        lbl_Empresa.Enabled = False
        cbo_Empresa.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        lbl_Telefone_Geral.Enabled = False
        mkt_Telefone_Geral.Enabled = False
        lbl_Telefone_Pecas.Enabled = False
        mkt_Telefone_Pecas.Enabled = False
        lbl_Telefone_Servicos.Enabled = False
        mkt_Telefone_Servicos.Enabled = False
        lbl_Email_Geral.Enabled = False
        txt_Email_Geral.Enabled = False
        lbl_Email_Pecas.Enabled = False
        txt_Email_Pecas.Enabled = False
        lbl_Email_Servicos.Enabled = False
        txt_Email_Servicos.Enabled = False
        lbl_Pais.Enabled = False
        cbo_Pais.Enabled = False
        lbl_Estado.Enabled = False
        cbo_Estado.Enabled = False
        lbl_Cidade.Enabled = False
        cbo_Cidade.Enabled = False
        lbl_Endereco.Enabled = False
        txt_Endereco.Enabled = False
        lbl_CEP.Enabled = False
        mkt_CEP.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 565

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_filial.Text = ""
            txt_Nome.Text = ""
            cbo_Empresa.SelectedValue = -1
            cbo_Status.SelectedValue = -1
            mkt_Telefone_Geral.Text = ""
            mkt_Telefone_Pecas.Text = ""
            mkt_Telefone_Servicos.Text = ""
            txt_Email_Geral.Text = ""
            txt_Email_Pecas.Text = ""
            txt_Email_Servicos.Text = ""
            cbo_Pais.SelectedValue = -1
            cbo_Estado.SelectedValue = -1
            cbo_Cidade.SelectedValue = -1
            txt_Endereco.Text = ""
            mkt_CEP.Text = ""

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_filial", "id_filial = " & txt_id_filial.Text, Limite:="1")) Or
                String.IsNullOrEmpty(GET_DATA_MYSQL("tb_usuarios", "id_filial", "id_filial = " & txt_id_filial.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem propostas e/ou usuários cadastrados com essa filial. Portanto, não será possível excluí-la"
            End If

        End If

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

        If cbo_Empresa.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Empresa.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Empresa.Text
            End If
            lbl_Empresa.ForeColor = Color.Red
        Else
            lbl_Empresa.ForeColor = Color.Black
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

        If cbo_Pais.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Pais.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Pais.Text
            End If
            lbl_Pais.ForeColor = Color.Red
        Else
            lbl_Pais.ForeColor = Color.Black
        End If

        If cbo_Estado.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Estado.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Estado.Text
            End If
            lbl_Estado.ForeColor = Color.Red
        Else
            lbl_Estado.ForeColor = Color.Black
        End If

        If cbo_Cidade.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Cidade.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Cidade.Text
            End If
            lbl_Cidade.ForeColor = Color.Red
        Else
            lbl_Cidade.ForeColor = Color.Black
        End If

        If txt_Endereco.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Endereco.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Endereco.Text
            End If
            lbl_Endereco.ForeColor = Color.Red
        Else
            lbl_Endereco.ForeColor = Color.Black
        End If

        If REMOVE_MASK(mkt_CEP) = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_CEP.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_CEP.Text
            End If
            lbl_CEP.ForeColor = Color.Red
        Else
            lbl_CEP.ForeColor = Color.Black
        End If

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then

                sqlcmd = New MySqlCommand("sp_inserir_filial", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_id_empresa", cbo_Empresa.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_pais", cbo_Pais.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_estado", cbo_Estado.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cidade", cbo_Cidade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_endereco", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_CEP", REMOVE_MASK(mkt_CEP))

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone_Geral)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone_geral", REMOVE_MASK(mkt_Telefone_Geral))
                Else
                    sqlcmd.Parameters.Add("p_telefone_geral", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone_Pecas)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone_pecas", REMOVE_MASK(mkt_Telefone_Pecas))
                Else
                    sqlcmd.Parameters.Add("p_telefone_pecas", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone_Servicos)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone_servicos", REMOVE_MASK(mkt_Telefone_Servicos))
                Else
                    sqlcmd.Parameters.Add("p_telefone_servicos", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email_Geral.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email_geral", CONVERT_TO_STRING(txt_Email_Geral.Text))
                Else
                    sqlcmd.Parameters.Add("p_email_geral", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email_Pecas.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email_pecas", CONVERT_TO_STRING(txt_Email_Pecas.Text))
                Else
                    sqlcmd.Parameters.Add("p_email_pecas", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email_Servicos.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email_servicos", CONVERT_TO_STRING(txt_Email_Servicos.Text))
                Else
                    sqlcmd.Parameters.Add("p_email_servicos", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("A filial '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Filial '" & txt_Nome.Text & "' inserida com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_filial.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_filial", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_filial", CONVERT_TO_INTEGER(txt_id_filial.Text))
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_id_empresa", cbo_Empresa.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_pais", cbo_Pais.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_estado", cbo_Estado.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cidade", cbo_Cidade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_endereco", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_CEP", REMOVE_MASK(mkt_CEP))

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone_Geral)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone_geral", REMOVE_MASK(mkt_Telefone_Geral))
                Else
                    sqlcmd.Parameters.Add("p_telefone_geral", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone_Pecas)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone_pecas", REMOVE_MASK(mkt_Telefone_Pecas))
                Else
                    sqlcmd.Parameters.Add("p_telefone_pecas", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone_Servicos)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone_servicos", REMOVE_MASK(mkt_Telefone_Servicos))
                Else
                    sqlcmd.Parameters.Add("p_telefone_servicos", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email_Geral.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email_geral", CONVERT_TO_STRING(txt_Email_Geral.Text))
                Else
                    sqlcmd.Parameters.Add("p_email_geral", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email_Pecas.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email_pecas", CONVERT_TO_STRING(txt_Email_Pecas.Text))
                Else
                    sqlcmd.Parameters.Add("p_email_pecas", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email_Servicos.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email_servicos", CONVERT_TO_STRING(txt_Email_Servicos.Text))
                Else
                    sqlcmd.Parameters.Add("p_email_servicos", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("A filial '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Filial '" & txt_Nome.Text & "' editada com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


            Carregar_Filiais()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Empresa, "tb_empresas", "id_empresa", "razao_social", condicoes:="id_status=1", ordenar_por:="razao_social")
            Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Empresa.Enabled = False
            cbo_Empresa.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            lbl_Telefone_Geral.Enabled = False
            mkt_Telefone_Geral.Enabled = False
            lbl_Telefone_Pecas.Enabled = False
            mkt_Telefone_Pecas.Enabled = False
            lbl_Telefone_Servicos.Enabled = False
            mkt_Telefone_Servicos.Enabled = False
            lbl_Email_Geral.Enabled = False
            txt_Email_Geral.Enabled = False
            lbl_Email_Pecas.Enabled = False
            txt_Email_Pecas.Enabled = False
            lbl_Email_Servicos.Enabled = False
            txt_Email_Servicos.Enabled = False
            lbl_Pais.Enabled = False
            cbo_Pais.Enabled = False
            lbl_Estado.Enabled = False
            cbo_Estado.Enabled = False
            lbl_Cidade.Enabled = False
            cbo_Cidade.Enabled = False
            lbl_Endereco.Enabled = False
            txt_Endereco.Enabled = False
            lbl_CEP.Enabled = False
            mkt_CEP.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False
            Me.Height = 565

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

    Private Sub cbo_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Empresa.SelectedIndexChanged
        If cbo_Empresa.Text = "" Then
            lbl_Empresa.ForeColor = Color.Red
        Else
            lbl_Empresa.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cbo_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged
        If cbo_Status.Text = "" Then
            lbl_Status.ForeColor = Color.Red
        Else
            lbl_Status.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cbo_Pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Pais.SelectedIndexChanged
        If cbo_Pais.Text = "" Then
            lbl_Pais.ForeColor = Color.Red
        Else
            lbl_Pais.ForeColor = Color.Black
            Preencher_ComboBox(cbo_Estado, "tb_estados", "id_estado", "nome", "id_estado, nome", "id_status=1 AND id_pais=" & cbo_Pais.SelectedValue, "nome")
        End If

    End Sub

    Private Sub cbo_Estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Estado.SelectedIndexChanged
        If cbo_Estado.Text = "" Then
            lbl_Estado.ForeColor = Color.Red
        Else
            lbl_Estado.ForeColor = Color.Black
            Preencher_ComboBox(cbo_Cidade, "tb_cidades", "id_cidade", "nome", "id_cidade, nome", "id_status=1 AND id_pais=" & cbo_Pais.SelectedValue & " AND id_estado=" & cbo_Estado.SelectedValue, "nome")
        End If
    End Sub

    Private Sub cbo_Cidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Cidade.SelectedIndexChanged
        If cbo_Cidade.Text = "" Then
            lbl_Cidade.ForeColor = Color.Red
        Else
            lbl_Cidade.ForeColor = Color.Black
        End If
    End Sub
    Private Sub mkt_Telefone_Geral_Enter(sender As Object, e As EventArgs) Handles mkt_Telefone_Geral.Enter
        mkt_Telefone_Geral.Mask = "(00) 00000-0000"
    End Sub
    Private Sub mkt_Telefone_Geral_Leave(sender As Object, e As EventArgs) Handles mkt_Telefone_Geral.Leave

        Select Case Len(REMOVE_MASK(mkt_Telefone_Geral))
            Case Is < 10
                mkt_Telefone_Geral.Text = ""
            Case Is = 10
                mkt_Telefone_Geral.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone_Geral.Mask = "(00) 00000-0000"
        End Select

    End Sub

    Private Sub mkt_Telefone_Pecas_Enter(sender As Object, e As EventArgs) Handles mkt_Telefone_Pecas.Enter
        mkt_Telefone_Pecas.Mask = "(00) 00000-0000"
    End Sub
    Private Sub mkt_Telefone_Pecas_Leave(sender As Object, e As EventArgs) Handles mkt_Telefone_Pecas.Leave

        Select Case Len(REMOVE_MASK(mkt_Telefone_Pecas))
            Case Is < 10
                mkt_Telefone_Pecas.Text = ""
            Case Is = 10
                mkt_Telefone_Pecas.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone_Pecas.Mask = "(00) 00000-0000"
        End Select

    End Sub

    Private Sub mkt_Telefone_Servicos_Enter(sender As Object, e As EventArgs) Handles mkt_Telefone_Servicos.Enter
        mkt_Telefone_Servicos.Mask = "(00) 00000-0000"
    End Sub
    Private Sub mkt_Telefone_Servicos_Leave(sender As Object, e As EventArgs) Handles mkt_Telefone_Servicos.Leave

        Select Case Len(REMOVE_MASK(mkt_Telefone_Servicos))
            Case Is < 10
                mkt_Telefone_Servicos.Text = ""
            Case Is = 10
                mkt_Telefone_Servicos.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone_Servicos.Mask = "(00) 00000-0000"
        End Select

    End Sub
    Private Sub mnsi_Fechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Filiais_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_filial.Text = dtg_Itens.CurrentRow.Cells("id_filial").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value
        cbo_Empresa.SelectedValue = dtg_Itens.CurrentRow.Cells("id_empresa").Value
        cbo_Pais.SelectedValue = dtg_Itens.CurrentRow.Cells("id_pais").Value
        cbo_Estado.SelectedValue = dtg_Itens.CurrentRow.Cells("id_estado").Value
        cbo_Cidade.SelectedValue = dtg_Itens.CurrentRow.Cells("id_cidade").Value

        mkt_Telefone_Geral.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("telefone_geral").Value)

        Select Case Len(REMOVE_MASK(mkt_Telefone_Geral))
            Case Is < 10
                mkt_Telefone_Geral.Text = ""
            Case Is = 10
                mkt_Telefone_Geral.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone_Geral.Mask = "(00) 00000-0000"
        End Select


        mkt_Telefone_Pecas.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("telefone_pecas").Value)

        Select Case Len(REMOVE_MASK(mkt_Telefone_Pecas))
            Case Is < 10
                mkt_Telefone_Pecas.Text = ""
            Case Is = 10
                mkt_Telefone_Pecas.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone_Pecas.Mask = "(00) 00000-0000"
        End Select


        mkt_Telefone_Servicos.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("telefone_servicos").Value)

        Select Case Len(REMOVE_MASK(mkt_Telefone_Servicos))
            Case Is < 10
                mkt_Telefone_Servicos.Text = ""
            Case Is = 10
                mkt_Telefone_Servicos.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone_Servicos.Mask = "(00) 00000-0000"
        End Select

        txt_Email_Geral.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("email_geral").Value)
        txt_Email_Pecas.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("email_pecas").Value)
        txt_Email_Servicos.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("email_servicos").Value)

        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True

        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_filial", "id_filial = " & txt_id_filial.Text, Limite:="1")) Or
                String.IsNullOrEmpty(GET_DATA_MYSQL("tb_usuarios", "id_filial", "id_filial = " & txt_id_filial.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem propostas e/ou usuários cadastrados com essa filial. Portanto, não será possível excluí-la"
        End If

    End Sub

End Class