Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Gerenciar_Usuarios

    Private Imagem_Carregada As Image

    Private Sub Carregar_Usuarios()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT user.id_usuario, user.nome, user.cpf, user.sexo, user.login, user.email, user.telefone, user.id_filial, user.id_setor, user.id_perfil, 
user.id_status, fili.nome, seto.nome, perf.nome, stat.nome, user.data_ultima_alteracao_login, user.data_ultima_alteracao_email, user.imagem, user.texto_resposta_email, user.emails_copia 
FROM tb_usuarios AS user 
LEFT JOIN tb_filiais AS fili ON user.id_filial = fili.id_filial 
LEFT JOIN tb_setores AS seto ON user.id_setor = seto.id_setor 
LEFT JOIN tb_perfis AS perf ON user.id_perfil = perf.id_perfil 
LEFT JOIN tb_status AS stat ON user.id_status = stat.id_status WHERE user.id_usuario <> 1 AND user.id_usuario <> " & get_id_usuario & " ORDER BY user.nome", strConexao)

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

        dtg_Itens.Columns("id_usuario").HeaderText = "ID do Usuário"
        dtg_Itens.Columns("nome").HeaderText = "Nome"
        dtg_Itens.Columns("cpf").HeaderText = "CPF"
        dtg_Itens.Columns("sexo").HeaderText = "Sexo"
        dtg_Itens.Columns("login").HeaderText = "Login"
        dtg_Itens.Columns("email").HeaderText = "E-mail"
        dtg_Itens.Columns("telefone").HeaderText = "Telefone"
        dtg_Itens.Columns("id_filial").HeaderText = "ID da Filial"
        dtg_Itens.Columns("id_perfil").HeaderText = "ID do Perfil"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("nome1").HeaderText = "Filial"
        dtg_Itens.Columns("nome2").HeaderText = "Setor"
        dtg_Itens.Columns("nome3").HeaderText = "Perfil"
        dtg_Itens.Columns("nome4").HeaderText = "Status"
        dtg_Itens.Columns("data_ultima_alteracao_login").HeaderText = "Data da última alteração do login"
        dtg_Itens.Columns("data_ultima_alteracao_email").HeaderText = "Data da última alteração do e-mail"
        dtg_Itens.Columns("imagem").HeaderText = "Imagem"
        dtg_Itens.Columns("texto_resposta_email").HeaderText = "Texto de resposta do e-mail"
        dtg_Itens.Columns("emails_copia").HeaderText = "E-mails em cópia"

        dtg_Itens.Columns("id_usuario").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("cpf").Visible = True
        dtg_Itens.Columns("sexo").Visible = True
        dtg_Itens.Columns("login").Visible = True
        dtg_Itens.Columns("email").Visible = True
        dtg_Itens.Columns("telefone").Visible = True
        dtg_Itens.Columns("id_filial").Visible = False
        dtg_Itens.Columns("id_perfil").Visible = False
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("nome1").Visible = True
        dtg_Itens.Columns("nome2").Visible = True
        dtg_Itens.Columns("nome3").Visible = True
        dtg_Itens.Columns("nome4").Visible = True
        dtg_Itens.Columns("data_ultima_alteracao_login").Visible = False
        dtg_Itens.Columns("data_ultima_alteracao_email").Visible = False
        dtg_Itens.Columns("imagem").Visible = False
        dtg_Itens.Columns("texto_resposta_email").Visible = False
        dtg_Itens.Columns("emails_copia").Visible = False

    End Sub

    Private Sub Gerenciar_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Usuarios()

        Preencher_ComboBox(cbo_Filial, "tb_filiais", "id_filial", "nome", "id_filial, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Setor, "tb_setores", "id_setor", "nome", "id_setor, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Perfil, "tb_perfis", "id_perfil", "nome", "id_perfil, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False

        lbl_CPF.Enabled = False
        mkt_CPF.Enabled = False

        lbl_Sexo.Enabled = False
        rdo_Sexo_1.Enabled = False
        rdo_Sexo_2.Enabled = False

        lbl_Login.Enabled = False
        txt_Login.Enabled = False

        lbl_Email.Enabled = False
        txt_Email.Enabled = False

        lbl_Telefone.Enabled = False
        mkt_Telefone.Enabled = False

        lbl_Filial.Enabled = False
        cbo_Filial.Enabled = False

        lbl_Setor.Enabled = False
        cbo_Setor.Enabled = False

        lbl_Perfil.Enabled = False
        cbo_Perfil.Enabled = False

        lbl_Status.Enabled = False
        cbo_Status.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 575

        txt_id_usuario.Text = ""
        txt_texto_resposta_email.Text = ""
        txt_emails_copia.Text = ""
        ptb_Imagem_Usuario.Image = Eurolift_Services.My.Resources.Resources.user_picture_128x128
        txt_Nome.Text = ""
        mkt_CPF.Text = ""
        rdo_Sexo_1.Checked = False
        rdo_Sexo_2.Checked = False
        txt_Login.Text = ""
        txt_Email.Text = ""
        mkt_Telefone.Text = ""
        cbo_Filial.SelectedValue = -1
        cbo_Setor.SelectedValue = -1
        cbo_Perfil.SelectedValue = -1
        cbo_Status.SelectedValue = -1

    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_usuario.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True

        lbl_CPF.Enabled = True
        mkt_CPF.Enabled = True

        lbl_Sexo.Enabled = True
        rdo_Sexo_1.Enabled = True
        rdo_Sexo_2.Enabled = True

        lbl_Login.Enabled = True
        txt_Login.Enabled = True

        lbl_Email.Enabled = True
        txt_Email.Enabled = True

        lbl_Telefone.Enabled = True
        mkt_Telefone.Enabled = True

        lbl_Filial.Enabled = True
        cbo_Filial.Enabled = True

        lbl_Setor.Enabled = True
        cbo_Setor.Enabled = True

        lbl_Perfil.Enabled = True
        cbo_Perfil.Enabled = True

        lbl_Status.Enabled = True
        cbo_Status.Enabled = True

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 601

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_usuario.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o usuário " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()

            sqlcmd = New MySqlCommand("DELETE FROM tb_senhas_usuarios WHERE id_usuario = " & CONVERT_TO_INTEGER(txt_id_usuario.Text), strConexao)
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.ExecuteNonQuery()

            sqlcmd = New MySqlCommand("sp_excluir_usuario", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", CONVERT_TO_INTEGER(txt_id_usuario.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O usuário '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Usuário '" & txt_Nome.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Usuarios()

            Preencher_ComboBox(cbo_Filial, "tb_filiais", "id_filial", "nome", "id_filial, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Setor, "tb_setores", "id_setor", "nome", "id_setor, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Perfil, "tb_perfis", "id_perfil", "nome", "id_perfil, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False

            lbl_CPF.Enabled = False
            mkt_CPF.Enabled = False

            lbl_Sexo.Enabled = False
            rdo_Sexo_1.Enabled = False
            rdo_Sexo_2.Enabled = False

            lbl_Login.Enabled = False
            txt_Login.Enabled = False

            lbl_Email.Enabled = False
            txt_Email.Enabled = False

            lbl_Telefone.Enabled = False
            mkt_Telefone.Enabled = False

            lbl_Filial.Enabled = False
            cbo_Filial.Enabled = False

            lbl_Setor.Enabled = False
            cbo_Setor.Enabled = False

            lbl_Perfil.Enabled = False
            cbo_Perfil.Enabled = False

            lbl_Status.Enabled = False
            cbo_Status.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            Me.Height = 575

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        dtg_Itens.Enabled = True
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_CPF.Enabled = False
        mkt_CPF.Enabled = False

        lbl_Sexo.Enabled = False
        rdo_Sexo_1.Enabled = False
        rdo_Sexo_2.Enabled = False

        lbl_Login.Enabled = False
        txt_Login.Enabled = False

        lbl_Email.Enabled = False
        txt_Email.Enabled = False

        lbl_Telefone.Enabled = False
        mkt_Telefone.Enabled = False

        lbl_Filial.Enabled = False
        cbo_Filial.Enabled = False

        lbl_Setor.Enabled = False
        cbo_Setor.Enabled = False

        lbl_Perfil.Enabled = False
        cbo_Perfil.Enabled = False

        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 575

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_usuario.Text = ""
            txt_texto_resposta_email.Text = ""
            txt_emails_copia.Text = ""
            ptb_Imagem_Usuario.Image = Eurolift_Services.My.Resources.Resources.user_picture_128x128
            txt_Nome.Text = ""
            mkt_CPF.Text = ""
            rdo_Sexo_1.Checked = False
            rdo_Sexo_2.Checked = False
            txt_Login.Text = ""
            txt_Email.Text = ""
            mkt_Telefone.Text = ""
            cbo_Filial.SelectedValue = -1
            cbo_Setor.SelectedValue = -1
            cbo_Perfil.SelectedValue = -1
            cbo_Status.SelectedValue = -1

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_usuario_insercao", "id_usuario_insercao = " & txt_id_usuario.Text, Limite:="1")) Or
            String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_usuario_edicao", "id_usuario_edicao = " & txt_id_usuario.Text, Limite:="1")) Or
            String.IsNullOrEmpty(GET_DATA_MYSQL("tb_senhas_usuarios", "id_usuario", "id_usuario = " & txt_id_usuario.Text, Limite:="1")) Or
            String.IsNullOrEmpty(GET_DATA_MYSQL("tb_itens_propostas", "id_usuario", "id_usuario = " & txt_id_usuario.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem propostas ou itens de propostas cadastrados com esse usuário. Portanto, não será possível excluí-lo"
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

        If REMOVE_MASK(mkt_CPF) = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_CPF.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_CPF.Text
            End If
            lbl_CPF.ForeColor = Color.Red
        Else
            lbl_CPF.ForeColor = Color.Black
        End If

        If rdo_Sexo_1.Checked = False And rdo_Sexo_2.Checked = False Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Sexo.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Sexo.Text
            End If
            lbl_Sexo.ForeColor = Color.Red
        Else
            lbl_Sexo.ForeColor = Color.Black
        End If

        If txt_Login.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Login.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Login.Text
            End If
            lbl_Login.ForeColor = Color.Red
        Else
            lbl_Login.ForeColor = Color.Black
        End If

        If txt_Email.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Email.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Email.Text
            End If
            lbl_Email.ForeColor = Color.Red
        Else
            lbl_Email.ForeColor = Color.Black
        End If

        If cbo_Filial.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Filial.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Filial.Text
            End If
            lbl_Filial.ForeColor = Color.Red
        Else
            lbl_Filial.ForeColor = Color.Black
        End If

        If cbo_Setor.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Setor.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Setor.Text
            End If
            lbl_Setor.ForeColor = Color.Red
        Else
            lbl_Setor.ForeColor = Color.Black
        End If

        If cbo_Perfil.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Perfil.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Perfil.Text
            End If
            lbl_Perfil.ForeColor = Color.Red
        Else
            lbl_Perfil.ForeColor = Color.Black
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

        Try

            Dim ms As New IO.MemoryStream
            Imagem_Carregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = ms.ToArray

            Abrir_Conexao()

            If txt_id_usuario.Text = "" Then
                MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            sqlcmd = New MySqlCommand("sp_editar_usuario", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", CONVERT_TO_INTEGER(txt_id_usuario.Text))
            sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
            If rdo_Sexo_1.Checked = True Then
                sqlcmd.Parameters.AddWithValue("p_sexo", "M")
            Else
                sqlcmd.Parameters.AddWithValue("p_sexo", "F")
            End If
            sqlcmd.Parameters.AddWithValue("p_cpf", REMOVE_MASK(mkt_CPF))
            sqlcmd.Parameters.AddWithValue("p_telefone", REMOVE_MASK(mkt_Telefone))

            sqlcmd.Parameters.AddWithValue("p_email", txt_Email.Text)
            If txt_Email.Text <> txt_Email.Tag Then
                sqlcmd.Parameters.AddWithValue("p_data_ultima_alteracao_email", Now)
            Else
                If String.IsNullOrEmpty(txt_data_ultima_alteracao_email.Text) Then
                    sqlcmd.Parameters.Add("p_data_ultima_alteracao_email", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_ultima_alteracao_email", CONVERT_TO_DATE(txt_data_ultima_alteracao_email.Text))
                End If
            End If

            sqlcmd.Parameters.AddWithValue("p_login", txt_Login.Text)
            If txt_Login.Text <> txt_Login.Tag Then
                sqlcmd.Parameters.AddWithValue("p_data_ultima_alteracao_login", Now)
            Else
                If String.IsNullOrEmpty(txt_data_ultima_alteracao_login.Text) Then
                    sqlcmd.Parameters.Add("p_data_ultima_alteracao_login", MySqlDbType.DateTime).Value = DBNull.Value
                Else
                    sqlcmd.Parameters.AddWithValue("p_data_ultima_alteracao_login", CONVERT_TO_DATE(txt_data_ultima_alteracao_login.Text))
                End If
            End If

            sqlcmd.Parameters.AddWithValue("p_id_filial", cbo_Filial.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_setor", cbo_Setor.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_perfil", cbo_Perfil.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)

            sqlcmd.Parameters.AddWithValue("p_texto_resposta_email", txt_texto_resposta_email.Text)
            sqlcmd.Parameters.AddWithValue("p_emails_copia", txt_emails_copia.Text)

            sqlcmd.Parameters.Add("p_imagem", MySqlDbType.LongBlob).Value = byteArray

            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()
            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O usuário '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Usuário '" & txt_Nome.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Usuarios()

            Preencher_ComboBox(cbo_Filial, "tb_filiais", "id_filial", "nome", "id_filial, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Setor, "tb_setores", "id_setor", "nome", "id_setor, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Perfil, "tb_perfis", "id_perfil", "nome", "id_perfil, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_CPF.Enabled = False
            mkt_CPF.Enabled = False

            lbl_Sexo.Enabled = False
            rdo_Sexo_1.Enabled = False
            rdo_Sexo_2.Enabled = False

            lbl_Login.Enabled = False
            txt_Login.Enabled = False

            lbl_Email.Enabled = False
            txt_Email.Enabled = False

            lbl_Telefone.Enabled = False
            mkt_Telefone.Enabled = False

            lbl_Filial.Enabled = False
            cbo_Filial.Enabled = False

            lbl_Setor.Enabled = False
            cbo_Setor.Enabled = False

            lbl_Perfil.Enabled = False
            cbo_Perfil.Enabled = False

            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False
            Me.Height = 575

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub


    Private Sub txt_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_Email.TextChanged

        If txt_Email.Text = "" Then
            lbl_Email.ForeColor = Color.Red
        Else
            lbl_Email.ForeColor = Color.Black
        End If

    End Sub

    Private Sub mkt_CPF_Leave(sender As Object, e As EventArgs) Handles mkt_CPF.Leave

        If Len(REMOVE_MASK(mkt_CPF)) < 11 Then
            mkt_CPF.Text = ""
        End If

        If REMOVE_MASK(mkt_CPF) = "" Then
            lbl_CPF.ForeColor = Color.Red
        Else
            lbl_CPF.ForeColor = Color.Black
        End If

    End Sub

    Private Sub mkt_CPF_TextChanged(sender As Object, e As EventArgs) Handles mkt_CPF.TextChanged
        lbl_CPF.ForeColor = Color.Black
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

    Private Sub txt_Nome_TextChanged(sender As Object, e As EventArgs) Handles txt_Nome.TextChanged
        lbl_Nome.ForeColor = Color.Black
    End Sub

    Private Sub txt_Nome_Leave(sender As Object, e As EventArgs) Handles txt_Nome.Leave
        If txt_Nome.Text = "" Then
            lbl_Nome.ForeColor = Color.Red
        Else
            lbl_Nome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub rdo_Sexo_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Sexo_1.CheckedChanged

        If rdo_Sexo_1.Checked = False And rdo_Sexo_2.Checked = False Then
            lbl_Sexo.ForeColor = Color.Red
        Else
            lbl_Sexo.ForeColor = Color.Black
        End If

    End Sub
    Private Sub rdo_Sexo_2_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Sexo_2.CheckedChanged

        If rdo_Sexo_1.Checked = False And rdo_Sexo_2.Checked = False Then
            lbl_Sexo.ForeColor = Color.Red
        Else
            lbl_Sexo.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txt_Login_TextChanged(sender As Object, e As EventArgs) Handles txt_Login.TextChanged
        lbl_Login.ForeColor = Color.Black
    End Sub

    Private Sub txt_Login_Leave(sender As Object, e As EventArgs) Handles txt_Login.Leave
        If txt_Login.Text = "" Then
            lbl_Login.ForeColor = Color.Red
        Else
            lbl_Login.ForeColor = Color.Black
            txt_Login.Text = REMOVE_CHARACTERS(txt_Login.Text)
        End If
    End Sub

    Private Sub mnsi_Fechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Gerenciar_Usuarios_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_usuario.Text = dtg_Itens.CurrentRow.Cells("id_usuario").Value
        txt_data_ultima_alteracao_login.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("data_ultima_alteracao_login").Value)
        txt_data_ultima_alteracao_email.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("data_ultima_alteracao_email").Value)


        txt_Nome.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("nome").Value)
        mkt_CPF.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("cpf").Value)
        If CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("sexo").Value) = "M" Then
            rdo_Sexo_1.Checked = True
        Else
            rdo_Sexo_2.Checked = True
        End If
        txt_Login.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("login").Value)
        txt_Email.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("email").Value)
        mkt_Telefone.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("telefone").Value)
        cbo_Filial.SelectedValue = CONVERT_TO_INTEGER(dtg_Itens.CurrentRow.Cells("id_filial").Value)
        cbo_Setor.SelectedValue = CONVERT_TO_INTEGER(dtg_Itens.CurrentRow.Cells("id_setor").Value)
        cbo_Perfil.SelectedValue = CONVERT_TO_INTEGER(dtg_Itens.CurrentRow.Cells("id_perfil").Value)
        cbo_Status.SelectedValue = CONVERT_TO_INTEGER(dtg_Itens.CurrentRow.Cells("id_status").Value)
        txt_texto_resposta_email.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("texto_resposta_email").Value)
        txt_emails_copia.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("emails_copia").Value)

        Dim Imagem As Byte() = Nothing

        If dtg_Itens.CurrentRow.Cells("imagem").Value.ToString <> "" Then
            Imagem = DirectCast(dtg_Itens.CurrentRow.Cells("imagem").Value, Byte())
        End If

        If Imagem Is Nothing Then
        Else
            If FOLDER_EXISTS(Environ("TEMP") & "\SGT") = False Then
                CREATE_FOLDER(Environ("TEMP") & "\SGT")
            End If
            Dim strArquivo As String = Environ("TEMP") & "\SGT\userimagegerenciar"
            Dim fs As New FileStream(strArquivo, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(Imagem, 0, Imagem.Length)
            fs.Flush()
            fs.Close()

            Dim imgg As Image = Image.FromFile(strArquivo)
            ptb_Imagem_Usuario.Image = New Bitmap(imgg)
            imgg.Dispose()

        End If

        Imagem_Carregada = ptb_Imagem_Usuario.Image

        mnsi_Editar.Enabled = True
        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_usuario_insercao", "id_usuario_insercao = " & txt_id_usuario.Text, Limite:="1")) Or
            String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_usuario_edicao", "id_usuario_edicao = " & txt_id_usuario.Text, Limite:="1")) Or
            String.IsNullOrEmpty(GET_DATA_MYSQL("tb_senhas_usuarios", "id_usuario", "id_usuario = " & txt_id_usuario.Text, Limite:="1")) Or
            String.IsNullOrEmpty(GET_DATA_MYSQL("tb_itens_propostas", "id_usuario", "id_usuario = " & txt_id_usuario.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem propostas ou itens de propostas cadastrados com esse usuário. Portanto, não será possível excluí-lo"
        End If

    End Sub
End Class