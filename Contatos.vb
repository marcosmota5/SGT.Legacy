Imports MySql.Data.MySqlClient

Public Class Contatos

    Private Sub Carregar_Contatos()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT cont.id_contato, cont.nome, cont.telefone, cont.email, cont.id_pais, cont.id_estado, cont.id_cidade, cont.id_status, cont.id_cliente, 
                                            pais.nome AS nome_pais, esta.nome AS nome_estado, cida.nome AS nome_cidade, stat.nome AS nome_status, clie.nome AS nome_cliente FROM tb_contatos AS cont
                                            LEFT JOIN tb_paises AS pais ON pais.id_pais = cont.id_pais
                                            LEFT JOIN tb_estados AS esta ON esta.id_estado = cont.id_estado
                                            LEFT JOIN tb_cidades AS cida ON cida.id_cidade = cont.id_cidade
                                            LEFT JOIN tb_status AS stat ON stat.id_status = cont.id_status
                                            LEFT JOIN tb_clientes AS clie ON clie.id_cliente = cont.id_cliente ORDER BY cont.nome", strConexao)

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

        dtg_Itens.Columns("id_contato").HeaderText = "ID do Contato"
        dtg_Itens.Columns("nome").HeaderText = "Contato"
        dtg_Itens.Columns("telefone").HeaderText = "Telefone"
        dtg_Itens.Columns("email").HeaderText = "E-mail"
        dtg_Itens.Columns("id_pais").HeaderText = "ID do País"
        dtg_Itens.Columns("id_estado").HeaderText = "ID do Estado"
        dtg_Itens.Columns("id_cidade").HeaderText = "ID da Cidade"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("id_cliente").HeaderText = "ID do Cliente"
        dtg_Itens.Columns("nome_pais").HeaderText = "País"
        dtg_Itens.Columns("nome_estado").HeaderText = "Estado"
        dtg_Itens.Columns("nome_cidade").HeaderText = "Cidade"
        dtg_Itens.Columns("nome_status").HeaderText = "Status"
        dtg_Itens.Columns("nome_cliente").HeaderText = "Cliente"

        dtg_Itens.Columns("id_contato").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("telefone").Visible = True
        dtg_Itens.Columns("email").Visible = True
        dtg_Itens.Columns("id_pais").Visible = False
        dtg_Itens.Columns("id_estado").Visible = False
        dtg_Itens.Columns("id_cidade").Visible = False
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("id_cliente").Visible = False
        dtg_Itens.Columns("nome_pais").Visible = True
        dtg_Itens.Columns("nome_estado").Visible = True
        dtg_Itens.Columns("nome_cidade").Visible = True
        dtg_Itens.Columns("nome_status").Visible = True
        dtg_Itens.Columns("nome_cliente").Visible = True

        dtg_Itens.Columns("nome_cliente").DisplayIndex = 4
        dtg_Itens.Columns("nome_status").DisplayIndex = 5

    End Sub

    Private Sub Contatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Contatos()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Cliente, "tb_clientes", "id_cliente", "nome", condicoes:="id_status=1", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Telefone.Enabled = False
        mkt_Telefone.Enabled = False
        lbl_Email.Enabled = False
        txt_Email.Enabled = False
        lbl_Cliente.Enabled = False
        cbo_Cliente.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        lbl_Pais.Enabled = False
        cbo_Pais.Enabled = False
        lbl_Estado.Enabled = False
        cbo_Estado.Enabled = False
        lbl_Cidade.Enabled = False
        cbo_Cidade.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 565

        txt_id_contato.Text = ""
        txt_Nome.Text = ""
        mkt_Telefone.Text = ""
        txt_Email.Text = ""
        cbo_Cliente.SelectedValue = -1
        cbo_Status.SelectedValue = -1
        cbo_Pais.SelectedValue = -1
        cbo_Estado.SelectedValue = -1
        cbo_Cidade.SelectedValue = -1

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Telefone.Enabled = True
        mkt_Telefone.Enabled = True
        lbl_Email.Enabled = True
        txt_Email.Enabled = True
        lbl_Cliente.Enabled = True
        cbo_Cliente.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        lbl_Pais.Enabled = True
        cbo_Pais.Enabled = True
        lbl_Estado.Enabled = True
        cbo_Estado.Enabled = True
        lbl_Cidade.Enabled = True
        cbo_Cidade.Enabled = True

        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 600

        txt_id_contato.Text = ""
        txt_Nome.Text = ""
        mkt_Telefone.Text = ""
        txt_Email.Text = ""
        cbo_Cliente.SelectedValue = -1
        cbo_Status.SelectedValue = -1
        cbo_Pais.SelectedValue = -1
        cbo_Estado.SelectedValue = -1
        cbo_Cidade.SelectedValue = -1
        txt_Nome.Focus()

    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_contato.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Telefone.Enabled = True
        mkt_Telefone.Enabled = True
        lbl_Email.Enabled = True
        txt_Email.Enabled = True
        lbl_Cliente.Enabled = True
        cbo_Cliente.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        lbl_Pais.Enabled = True
        cbo_Pais.Enabled = True
        lbl_Estado.Enabled = True
        cbo_Estado.Enabled = True
        lbl_Cidade.Enabled = True
        cbo_Cidade.Enabled = True

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 600

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_contato.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o contato " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_contato", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_contato", CONVERT_TO_INTEGER(txt_id_contato.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O contato '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Contato '" & txt_Nome.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Contatos()

            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Cliente, "tb_clientes", "id_cliente", "nome", condicoes:="id_status=1", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Telefone.Enabled = False
            mkt_Telefone.Enabled = False
            lbl_Email.Enabled = False
            txt_Email.Enabled = False
            lbl_Cliente.Enabled = False
            cbo_Cliente.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            lbl_Pais.Enabled = False
            cbo_Pais.Enabled = False
            lbl_Estado.Enabled = False
            cbo_Estado.Enabled = False
            lbl_Cidade.Enabled = False
            cbo_Cidade.Enabled = False

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
        lbl_Telefone.Enabled = False
        mkt_Telefone.Enabled = False
        lbl_Email.Enabled = False
        txt_Email.Enabled = False
        lbl_Cliente.Enabled = False
        cbo_Cliente.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        lbl_Pais.Enabled = False
        cbo_Pais.Enabled = False
        lbl_Estado.Enabled = False
        cbo_Estado.Enabled = False
        lbl_Cidade.Enabled = False
        cbo_Cidade.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 565

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_contato.Text = ""
            txt_Nome.Text = ""
            mkt_Telefone.Text = ""
            txt_Email.Text = ""
            cbo_Cliente.SelectedValue = -1
            cbo_Status.SelectedValue = -1
            cbo_Pais.SelectedValue = -1
            cbo_Estado.SelectedValue = -1
            cbo_Cidade.SelectedValue = -1

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_contato", "id_contato = " & txt_id_contato.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem propostas cadastradas com esse contato. Portanto, não será possível excluí-lo"
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

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then

                sqlcmd = New MySqlCommand("sp_inserir_contato", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)

                If Not String.IsNullOrEmpty(REMOVE_MASK(mkt_Telefone)) Then
                    sqlcmd.Parameters.AddWithValue("p_telefone", REMOVE_MASK(mkt_Telefone))
                Else
                    sqlcmd.Parameters.Add("p_telefone", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                If Not String.IsNullOrEmpty(txt_Email.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_email", CONVERT_TO_STRING(txt_Email.Text))
                Else
                    sqlcmd.Parameters.Add("p_email", MySqlDbType.VarChar).Value = DBNull.Value
                End If

                sqlcmd.Parameters.AddWithValue("p_id_pais", cbo_Pais.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_estado", cbo_Estado.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cidade", cbo_Cidade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cliente", cbo_Cliente.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.Parameters.Add("p_id_contato", MySqlDbType.Int32).Direction = 2
                sqlcmd.ExecuteNonQuery()

                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O contato '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Contato '" & txt_Nome.Text & "' inserido com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_contato.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_contato", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_contato", CONVERT_TO_INTEGER(txt_id_contato.Text))
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_telefone", REMOVE_MASK(mkt_Telefone))
                sqlcmd.Parameters.AddWithValue("p_email", txt_Email.Text)
                sqlcmd.Parameters.AddWithValue("p_id_pais", cbo_Pais.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_estado", cbo_Estado.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cidade", cbo_Cidade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_cliente", cbo_Cliente.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("O contato '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Contato '" & txt_Nome.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


            Carregar_Contatos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Cliente, "tb_clientes", "id_cliente", "nome", condicoes:="id_status=1", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Pais, "tb_paises", "id_pais", "nome", condicoes:="id_status=1", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Telefone.Enabled = False
            mkt_Telefone.Enabled = False
            lbl_Email.Enabled = False
            txt_Email.Enabled = False
            lbl_Cliente.Enabled = False
            cbo_Cliente.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            lbl_Pais.Enabled = False
            cbo_Pais.Enabled = False
            lbl_Estado.Enabled = False
            cbo_Estado.Enabled = False
            lbl_Cidade.Enabled = False
            cbo_Cidade.Enabled = False

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

    Private Sub cbo_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Cliente.SelectedIndexChanged
        If cbo_Cliente.Text = "" Then
            lbl_Cliente.ForeColor = Color.Red
        Else
            lbl_Cliente.ForeColor = Color.Black
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
    Private Sub mkt_Telefone_Enter(sender As Object, e As EventArgs) Handles mkt_Telefone.Enter
        mkt_Telefone.Mask = "(00) 00000-0000"
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
    Private Sub mnsi_Fechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Contatos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_contato.Text = dtg_Itens.CurrentRow.Cells("id_contato").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value
        mkt_Telefone.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("telefone").Value)

        Select Case Len(REMOVE_MASK(mkt_Telefone))
            Case Is < 10
                mkt_Telefone.Text = ""
            Case Is = 10
                mkt_Telefone.Mask = "(00) 0000-0000"
            Case Is = 11
                mkt_Telefone.Mask = "(00) 00000-0000"
        End Select

        txt_Email.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("email").Value)

        cbo_Cliente.SelectedValue = dtg_Itens.CurrentRow.Cells("id_cliente").Value
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value

        cbo_Pais.SelectedValue = dtg_Itens.CurrentRow.Cells("id_pais").Value
        cbo_Estado.SelectedValue = dtg_Itens.CurrentRow.Cells("id_estado").Value
        cbo_Cidade.SelectedValue = dtg_Itens.CurrentRow.Cells("id_cidade").Value

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True

        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_contato", "id_contato = " & txt_id_contato.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem propostas cadastradas com esse contato. Portanto, não será possível excluí-lo"
        End If

    End Sub

End Class