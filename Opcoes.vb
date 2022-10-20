Imports MySql.Data.MySqlClient
Imports Ookii.Dialogs.WinForms

Public Class Opcoes
    Private Sub btn_Selecionar_Estoque_Click(sender As Object, e As EventArgs) Handles btn_Selecionar_Estoque.Click

        Dim dlgFolder2 = New VistaFolderBrowserDialog

        If dlgFolder2.ShowDialog() = DialogResult.OK Then
            txt_Local_Estoque.Text = dlgFolder2.SelectedPath
        End If

        'Dim dlgFolder = New FolderBrowserDialog

        'If dlgFolder.ShowDialog() = DialogResult.OK Then
        '    txt_Local_Estoque.Text = dlgFolder.SelectedPath
        'End If

    End Sub

    Private Sub btn_Mostrar_Senha_Click(sender As Object, e As EventArgs) Handles btn_Mostrar_Senha.Click

        btn_Mostrar_Senha.Visible = False
        btn_Esconder_Senha.Visible = True
        txt_Senha_Estoque.PasswordChar = ""

    End Sub

    Private Sub btn_Esconder_Senha_Click(sender As Object, e As EventArgs) Handles btn_Esconder_Senha.Click
        btn_Mostrar_Senha.Visible = True
        btn_Esconder_Senha.Visible = False
        txt_Senha_Estoque.PasswordChar = "*"
    End Sub

    Private Sub Opcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_Texto_Padrao.Text = GET_DATA_MYSQL("tb_usuarios", "texto_resposta_email", "id_usuario = " & get_id_usuario)
        txt_Emails_Copia.Text = GET_DATA_MYSQL("tb_usuarios", "emails_copia", "id_usuario = " & get_id_usuario)

        txt_Local_Estoque.Text = GET_REGISTRY_VALUE(Registry_Values.StockFolder)
        txt_Nome_Estoque.Text = GET_REGISTRY_VALUE(Registry_Values.StockFile)
        txt_Aba_Estoque.Text = GET_REGISTRY_VALUE(Registry_Values.StockSheet)
        txt_Senha_Estoque.Text = GET_REGISTRY_VALUE(Registry_Values.StockPassword)
        nud_Limite_Resultados.Value = GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)
        'nud_Prazo_Adicional.Value = GET_REGISTRY_VALUE(Registry_Values.DaysAmount)

        nud_Segundos.Value = GET_REGISTRY_VALUE(Registry_Values.AutoRefreshDashboardSeconds)

        If CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.AutoRefreshDashboard)) = 1 Then
            chb_Atualizacao_Automatica.Checked = True
            nud_Segundos.Enabled = True
        Else
            chb_Atualizacao_Automatica.Checked = False
            nud_Segundos.Enabled = False
        End If

    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Set_Registry_Value(Registry_Values.StockFolder, txt_Local_Estoque.Text)
        Set_Registry_Value(Registry_Values.StockFile, txt_Nome_Estoque.Text)
        Set_Registry_Value(Registry_Values.StockSheet, txt_Aba_Estoque.Text)
        Set_Registry_Value(Registry_Values.StockPassword, txt_Senha_Estoque.Text)
        Set_Registry_Value(Registry_Values.ResultsLimit, nud_Limite_Resultados.Value)
        'Set_Registry_Value(Registry_Values.DaysAmount, nud_Prazo_Adicional.Value)
        Set_Registry_Value(Registry_Values.AutoRefreshDashboardSeconds, nud_Segundos.Value)

        If chb_Atualizacao_Automatica.Checked = True Then
            Set_Registry_Value(Registry_Values.AutoRefreshDashboard, 1)
        Else
            Set_Registry_Value(Registry_Values.AutoRefreshDashboard, 0)
        End If


        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_altera_texto_padrao_email_copia", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", get_id_usuario)
            sqlcmd.Parameters.AddWithValue("p_texto_resposta_email", txt_Texto_Padrao.Text)
            sqlcmd.Parameters.AddWithValue("p_emails_copia", txt_Emails_Copia.Text)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

            Select Case Mensagem_Conclusao
                Case "Valor não existe"
                    MessageBox.Show("O usuário atual não foi encontrado. Faça o login e tente novamente, caso o erro persista contate o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Valor editado com sucesso"
                    MessageBox.Show("Opções alteradas com sucesso!", "Procedimento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case Else
                    MessageBox.Show("Erro não especificado. Por favor, contate o administrador", "Erro não especificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            Fechar_Conexao()
        End Try

        Me.Close()

    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub chb_Atualizacao_Automatica_CheckedChanged(sender As Object, e As EventArgs) Handles chb_Atualizacao_Automatica.CheckedChanged
        If chb_Atualizacao_Automatica.Checked = True Then
            nud_Segundos.Enabled = True
        Else
            nud_Segundos.Enabled = False
        End If
    End Sub

    Private Sub txt_Local_Estoque_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_Local_Estoque.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub

    Private Sub txt_Nome_Estoque_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_Nome_Estoque.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub

    Private Sub txt_Aba_Estoque_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_Aba_Estoque.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub

    Private Sub txt_Senha_Estoque_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_Senha_Estoque.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub

    Private Sub txt_Texto_Padrao_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_Texto_Padrao.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub

    Private Sub txt_Emails_Copia_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_Emails_Copia.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub

    Private Sub chb_Atualizacao_Automatica_MouseMove(sender As Object, e As MouseEventArgs) Handles chb_Atualizacao_Automatica.MouseMove
        ttp_Info.Active = False
        ttp_Info.Active = True
    End Sub
End Class