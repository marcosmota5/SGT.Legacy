Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Cadastrar_Usuario

    Private Imagem_Carregada As Image

    Private Sub Cadastrar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preencher_cbo_Filial()
        Preencher_cbo_Perfil()
        Preencher_cbo_Setor()
        cbo_Perfil.SelectedValue = 2
        Preencher_cbo_Status()
        Imagem_Carregada = ptb_Imagem_Usuario.Image
    End Sub
    Private Sub Preencher_cbo_Status()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT id_status, nome FROM tb_status ORDER BY nome", strConexao)

            adapter.Fill(ds, "tb_status")

            cbo_Status.DisplayMember = "nome"
            cbo_Status.ValueMember = "id_status"
            cbo_Status.DataSource = ds.Tables("tb_status")

            Fechar_Conexao()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub Preencher_cbo_Perfil()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT id_perfil, nome FROM tb_perfis WHERE id_status = 1 ORDER BY nome", strConexao)

            adapter.Fill(ds, "tb_perfis")

            cbo_Perfil.DisplayMember = "nome"
            cbo_Perfil.ValueMember = "id_perfil"
            cbo_Perfil.DataSource = ds.Tables("tb_perfis")

            Fechar_Conexao()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
            Fechar_Conexao()
        End Try
    End Sub
    Private Sub Preencher_cbo_Setor()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT id_setor, nome FROM tb_setores WHERE id_status = 1 ORDER BY nome", strConexao)

            adapter.Fill(ds, "tb_setores")

            cbo_Setor.DisplayMember = "nome"
            cbo_Setor.ValueMember = "id_setor"
            cbo_Setor.DataSource = ds.Tables("tb_setores")

            Fechar_Conexao()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub Preencher_cbo_Filial()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT id_filial, nome FROM tb_filiais WHERE id_status = 1 ORDER BY nome", strConexao)

            adapter.Fill(ds, "tb_filiais")

            cbo_Filial.DisplayMember = "nome"
            cbo_Filial.ValueMember = "id_filial"
            cbo_Filial.DataSource = ds.Tables("tb_filiais")

            Fechar_Conexao()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub btn_Selecionar_Imagem_Click(sender As Object, e As EventArgs) Handles btn_Selecionar_Imagem.Click
        Using OFD As New OpenFileDialog With {.Filter = "Arquivos de imagem (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"}
            If OFD.ShowDialog = DialogResult.OK Then
                Imagem_Carregada = Image.FromFile(OFD.FileName)
                ptb_Imagem_Usuario.Image = Imagem_Carregada
                txt_File_Path.Text = OFD.FileName
            End If
        End Using
    End Sub
    Private Sub btn_Mostrar_Senha_Click(sender As Object, e As EventArgs) Handles btn_Mostrar_Senha.Click

        btn_Mostrar_Senha.Visible = False
        btn_Esconder_Senha.Visible = True
        txt_Senha.PasswordChar = ""

    End Sub

    Private Sub btn_Esconder_Senha_Click(sender As Object, e As EventArgs) Handles btn_Esconder_Senha.Click
        btn_Mostrar_Senha.Visible = True
        btn_Esconder_Senha.Visible = False
        txt_Senha.PasswordChar = "*"
    End Sub

    Private Sub btn_Mostrar_Confirmacao_Senha_Click(sender As Object, e As EventArgs) Handles btn_Mostrar_Confirmacao_Senha.Click

        btn_Mostrar_Confirmacao_Senha.Visible = False
        btn_Esconder_Confirmacao_Senha.Visible = True
        txt_Confirmacao_Senha.PasswordChar = ""

    End Sub

    Private Sub btn_Esconder_Confirmacao_Senha_Click(sender As Object, e As EventArgs) Handles btn_Esconder_Confirmacao_Senha.Click
        btn_Mostrar_Confirmacao_Senha.Visible = True
        btn_Esconder_Confirmacao_Senha.Visible = False
        txt_Confirmacao_Senha.PasswordChar = "*"
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles btn_Cadastrar.Click

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

        If txt_Senha.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Senha.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Senha.Text
            End If
            lbl_Senha.ForeColor = Color.Red
        Else
            lbl_Senha.ForeColor = Color.Black
        End If

        If txt_Confirmacao_Senha.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Confirmacao_Senha.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Confirmacao_Senha.Text
            End If
            lbl_Confirmacao_Senha.ForeColor = Color.Red
        Else
            lbl_Confirmacao_Senha.ForeColor = Color.Black
        End If

        If strObrigatorios <> "" Then
            MessageBox.Show("Os campos a seguir são obrigatórios. Preencha-os antes de continuar." & vbNewLine & vbNewLine & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If CHECK_EMAIL(txt_Email.Text) = False Then
            MessageBox.Show("O e-mail inserido não é válido", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txt_Senha.Text <> txt_Confirmacao_Senha.Text Then
            MessageBox.Show("A confirmação da senha não confere com a senha digitada", "Confirmação inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If CHECK_PASSWORD_STRENGTH(txt_Senha.Text) = False Then
            MessageBox.Show("Senha inválida. A senha deve atender as seguintes regras:" & vbNewLine & vbNewLine &
                            "Pelo menos 8 caracters" & vbNewLine &
                            "1 letra maiúscula" & vbNewLine &
                            "1 letra minúscula" & vbNewLine &
                            "1 número" & vbNewLine &
                            "1 caractere especial" & vbNewLine, "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try

            Dim ms As New IO.MemoryStream
            Imagem_Carregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = ms.ToArray

            Abrir_Conexao()

            sqlcmd = New MySqlCommand("sp_inserir_usuario", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
            If rdo_Sexo_1.Checked = True Then
                sqlcmd.Parameters.AddWithValue("p_sexo", "M")
            Else
                sqlcmd.Parameters.AddWithValue("p_sexo", "F")
            End If
            sqlcmd.Parameters.AddWithValue("p_cpf", REMOVE_MASK(mkt_CPF))
            sqlcmd.Parameters.AddWithValue("p_telefone", REMOVE_MASK(mkt_Telefone))
            sqlcmd.Parameters.AddWithValue("p_email", txt_Email.Text)
            sqlcmd.Parameters.AddWithValue("p_login", txt_Login.Text)
            sqlcmd.Parameters.AddWithValue("p_senha", txt_Senha.Text)
            sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_filial", cbo_Filial.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_perfil", cbo_Perfil.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_id_setor", cbo_Setor.SelectedValue)
            sqlcmd.Parameters.AddWithValue("p_texto_resposta_email", "Conforme vossa solicitação, envio a proposta referente à(s) peça(s) e/ou serviço(s) solicitado(s). Aguardo vossa análise e aprovação.")
            sqlcmd.Parameters.AddWithValue("p_emails_copia", "")
            sqlcmd.Parameters.AddWithValue("p_data_cadastro", Now)
            sqlcmd.Parameters.Add("p_imagem", MySqlDbType.LongBlob).Value = byteArray
            sqlcmd.Parameters.Add("p_id_usuario", MySqlDbType.Int32, 255).Direction = 2
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()
            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            Dim Id_Usuario As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_usuario").Value)
            Select Case Mensagem_Conclusao
                Case "Valor já existe 1"
                    MessageBox.Show("O login '" & txt_Login.Text & "' já existe na database", "Cadastro não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_Login.Focus()
                Case "Valor já existe 2"
                    MessageBox.Show("O CPF '" & mkt_CPF.Text & "' já existe na database", "Cadastro não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mkt_CPF.Focus()
                Case "Valor já existe 3"
                    MessageBox.Show("O e-mail '" & txt_Email.Text & "' já existe na database", "Cadastro não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_Email.Focus()
                Case "Valor inserido com sucesso"
                    sqlcmd = New MySqlCommand("sp_inserir_senha_usuario", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_usuario", Id_Usuario)
                    sqlcmd.Parameters.AddWithValue("p_senha", txt_Senha.Text)
                    sqlcmd.Parameters.AddWithValue("p_data_definicao", Now)
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                    Mensagem_Conclusao = sqlcmd.Parameters("p_mensagem").Value.ToString
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
            End Select

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

            If txt_Login.Text = "" Then
                txt_Login.Text = REMOVE_CHARACTERS(GET_WORD(StrConv(txt_Nome.Text, VbStrConv.Lowercase), Position:=Part_Word_Text.First_Word) & "." & GET_WORD(StrConv(txt_Nome.Text, VbStrConv.Lowercase), Position:=Part_Word_Text.Last_Word))
            End If

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

    Private Sub txt_Senha_TextChanged(sender As Object, e As EventArgs) Handles txt_Senha.TextChanged
        lbl_Senha.ForeColor = Color.Black
    End Sub

    Private Sub txt_Senha_Leave(sender As Object, e As EventArgs) Handles txt_Senha.Leave
        If txt_Senha.Text = "" Then
            lbl_Senha.ForeColor = Color.Red
        Else
            lbl_Senha.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Confirmacao_Senha_TextChanged(sender As Object, e As EventArgs) Handles txt_Confirmacao_Senha.TextChanged
        lbl_Confirmacao_Senha.ForeColor = Color.Black
    End Sub

    Private Sub txt_Confirmacao_Senha_Leave(sender As Object, e As EventArgs) Handles txt_Confirmacao_Senha.Leave
        If txt_Confirmacao_Senha.Text = "" Then
            lbl_Confirmacao_Senha.ForeColor = Color.Red
        Else
            lbl_Confirmacao_Senha.ForeColor = Color.Black
        End If
    End Sub

End Class