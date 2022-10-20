Imports MySql.Data.MySqlClient
Public Class Recuperar_Senha
    Private Sub btn_Confirmar_Click(sender As Object, e As EventArgs) Handles btn_Confirmar.Click
        Altera_Senha()
    End Sub
    Sub Altera_Senha()
        Dim strObrigatorios As String = ""
        If txt_Codigo_Recuperacao.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Codigo_Recuperacao.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Codigo_Recuperacao.Text
            End If
            lbl_Codigo_Recuperacao.ForeColor = Color.Red
        Else
            lbl_Codigo_Recuperacao.ForeColor = Color.Black
        End If

        If txt_Nova_Senha.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Nova_Senha.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Nova_Senha.Text
            End If
            lbl_Nova_Senha.ForeColor = Color.Red
        Else
            lbl_Nova_Senha.ForeColor = Color.Black
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
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txt_Codigo_Recuperacao.Text <> get_codigo_recuperacao Then
            MessageBox.Show("O código de recuperação não confere com o código enviado", "Código de recuperação inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        If txt_Nova_Senha.Text <> txt_Confirmacao_Senha.Text Then
            MessageBox.Show("A confirmação da senha não confere com a senha digitada", "Confirmação inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CHECK_PASSWORD_STRENGTH(txt_Nova_Senha.Text) = False Then
            MessageBox.Show("Senha inválida. A senha deve atender as seguintes regras:" & vbNewLine & vbNewLine &
                                "Pelo menos 8 caracters" & vbNewLine &
                                "1 letra maiúscula" & vbNewLine &
                                "1 letra minúscula" & vbNewLine &
                                "1 número" & vbNewLine &
                                "1 caractere especial" & vbNewLine, "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_valida_historico_senha", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", get_temp_id_usuario)
            sqlcmd.Parameters.AddWithValue("p_senha", txt_Nova_Senha.Text)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

            Select Case Mensagem_Conclusao
                Case "Senha existe"
                    MessageBox.Show("A nova senha precisa ser diferente das últimas 5 senhas. Informe outra senha e tente novamente", "Senha duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Senha não existe"
                Case Else
                    MessageBox.Show("Não foi possível identificar a senha. Por favor, contate o administrador", "Erro não especificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            Fechar_Conexao()
        End Try

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_altera_senha", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", get_temp_id_usuario)
            sqlcmd.Parameters.AddWithValue("p_senha", txt_Nova_Senha.Text)
            sqlcmd.Parameters.AddWithValue("p_data_ultima_alteracao_senha", Now)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

            Select Case Mensagem_Conclusao
                Case "Valor não existe"
                    MessageBox.Show("O usuário atual não foi encontrado. Faça o login e tente novamente, caso o erro persista contate o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Valor editado com sucesso"
                    sqlcmd = New MySqlCommand("sp_inserir_senha_usuario", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_usuario", get_temp_id_usuario)
                    sqlcmd.Parameters.AddWithValue("p_senha", txt_Nova_Senha.Text)
                    sqlcmd.Parameters.AddWithValue("p_data_definicao", Now)
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                Case Else
                    MessageBox.Show("Não foi possível identificar a senha. Por favor, contate o administrador", "Erro não especificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            Fechar_Conexao()
        End Try

        MessageBox.Show("Senha alterada com sucesso!", "Procedimento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
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
    Private Sub btn_Mostrar_Nova_Senha_Click(sender As Object, e As EventArgs) Handles btn_Mostrar_Nova_Senha.Click
        btn_Mostrar_Nova_Senha.Visible = False
        btn_Esconder_Nova_Senha.Visible = True
        txt_Nova_Senha.PasswordChar = ""
    End Sub
    Private Sub btn_Esconder_Nova_Senha_Click(sender As Object, e As EventArgs) Handles btn_Esconder_Nova_Senha.Click
        btn_Mostrar_Nova_Senha.Visible = True
        btn_Esconder_Nova_Senha.Visible = False
        txt_Nova_Senha.PasswordChar = "*"
    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub


End Class