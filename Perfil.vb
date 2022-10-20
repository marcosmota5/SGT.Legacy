Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Perfil

    Private Imagem_Carregada As Image

    Private Sub Cadastrar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Perfil_Usuario()
        Imagem_Carregada = ptb_Imagem_Usuario.Image
    End Sub
    Sub Carregar_Perfil_Usuario()
        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT usua.nome, usua.sexo, usua.cpf, usua.telefone, usua.email, usua.login, usua.id_status, usua.id_filial, usua.id_setor , usua.id_perfil, stat.nome AS status, fili.nome AS filial, seto.nome AS setor, perf.nome AS perfil, usua.data_ultima_alteracao_login,
            usua.data_ultima_alteracao_email, usua.imagem, usua.texto_resposta_email, usua.emails_copia FROM tb_usuarios AS usua 
            LEFT JOIN tb_perfis AS perf ON usua.id_perfil = perf.id_perfil            
            LEFT JOIN tb_filiais AS fili ON usua.id_filial = fili.id_filial    
            LEFT JOIN tb_setores AS seto ON usua.id_setor = seto.id_setor  
            LEFT JOIN tb_status AS stat ON usua.id_status = stat.id_status WHERE usua.id_usuario = " & get_id_usuario & "  ORDER BY usua.nome", strConexao)

            adapter.Fill(dtb)

            Dim rowUsuario As DataRow = dtb.Rows(0)

            txt_Nome.Text = rowUsuario("nome")
            mkt_CPF.Text = rowUsuario("cpf")

            If rowUsuario("sexo") = "M" Then
                rdo_Sexo_1.Checked = True
                rdo_Sexo_2.Checked = False
            End If

            If rowUsuario("sexo") = "F" Then
                rdo_Sexo_1.Checked = False
                rdo_Sexo_2.Checked = True
            End If

            txt_Login.Tag = rowUsuario("login")
            txt_Email.Tag = rowUsuario("email")

            txt_data_ultima_alteracao_login.Text = CONVERT_TO_STRING(rowUsuario("data_ultima_alteracao_login"))
            txt_data_ultima_alteracao_email.Text = CONVERT_TO_STRING(rowUsuario("data_ultima_alteracao_email"))

            txt_Login.Text = rowUsuario("login")
            txt_Email.Text = rowUsuario("email")
            mkt_Telefone.Text = CONVERT_TO_STRING(rowUsuario("telefone"))
            txt_Filial.Text = rowUsuario("filial")
            txt_Setor.Text = rowUsuario("setor")
            txt_Perfil.Text = rowUsuario("perfil")
            txt_Status.Text = rowUsuario("status")

            txt_Filial.Tag = rowUsuario("id_filial")
            txt_Setor.Tag = rowUsuario("id_setor")
            txt_Perfil.Tag = rowUsuario("id_perfil")
            txt_Status.Tag = rowUsuario("id_status")

            txt_Texto_Padrao.Text = CONVERT_TO_STRING(rowUsuario("texto_resposta_email"))
            txt_Emails_Copia.Text = CONVERT_TO_STRING(rowUsuario("emails_copia"))

            Dim Imagem As Byte() = Nothing

            If rowUsuario("imagem").ToString <> "" Then
                Imagem = DirectCast(rowUsuario("imagem"), Byte())
            End If

            If Imagem Is Nothing Then
            Else
                If FOLDER_EXISTS(Environ("TEMP") & "\SGT") = False Then
                    CREATE_FOLDER(Environ("TEMP") & "\SGT")
                End If
                Dim strArquivo As String = Environ("TEMP") & "\SGT\userimageperfil"
                Dim fs As New FileStream(strArquivo, FileMode.OpenOrCreate, FileAccess.Write)
                fs.Write(Imagem, 0, Imagem.Length)
                fs.Flush()
                fs.Close()

                Dim imgg As Image = Image.FromFile(strArquivo)
                ptb_Imagem_Usuario.Image = New Bitmap(imgg)
                imgg.Dispose()

            End If

            Dim duration As TimeSpan
            Dim ToolTipText As String

            If String.IsNullOrEmpty(CONVERT_TO_STRING(rowUsuario("data_ultima_alteracao_login"))) Then
                txt_Login.ReadOnly = False
            Else
                txt_Login.ReadOnly = True
                duration = CONVERT_TO_DATE(Now) - CONVERT_TO_DATE(rowUsuario("data_ultima_alteracao_login"))
                ToolTipText = "O login foi alterado há menos de 60 dias. Você só poderá alterar o seu login em " & duration.ToString("%d") & " dia(s)"
                ttp_Data_Alteracao.SetToolTip(txt_Login, ToolTipText)
            End If

            If String.IsNullOrEmpty(CONVERT_TO_STRING(rowUsuario("data_ultima_alteracao_email"))) Then
                txt_Email.ReadOnly = False
            Else
                txt_Email.ReadOnly = True
                duration = CONVERT_TO_DATE(Now) - CONVERT_TO_DATE(rowUsuario("data_ultima_alteracao_email"))
                ToolTipText = "O e-mail foi alterado há menos de 60 dias. Você só poderá alterar o seu e-mail em " & duration.ToString("%d") & " dia(s)"
                ttp_Data_Alteracao.SetToolTip(txt_Email, ToolTipText)
            End If

            mkt_CPF.ReadOnly = True
            txt_Perfil.ReadOnly = True
            txt_Filial.ReadOnly = True
            txt_Setor.ReadOnly = True
            txt_Status.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + ex.StackTrace)
        Finally
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
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
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

        If strObrigatorios <> "" Then
            MessageBox.Show("Os campos a seguir são obrigatórios. Preencha-os antes de continuar." & vbNewLine & vbNewLine & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If CHECK_EMAIL(txt_Email.Text) = False Then
            MessageBox.Show("O e-mail inserido não é válido", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txt_Email.Text <> txt_Email.Tag Then
            If Not String.IsNullOrEmpty(GET_DATA_MYSQL("tb_usuarios", "email", "email = '" & Replace(Replace(txt_Email.Text, "'", ""), """", "") & "'", "email", agrupar_por:="email")) Then
                MessageBox.Show("O e-mail inserido já existe. Informe outro e-mail e tente novamente", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If txt_Login.Text <> txt_Login.Tag Then
            If Not String.IsNullOrEmpty(GET_DATA_MYSQL("tb_usuarios", "login", "login = '" & Replace(Replace(txt_Login.Text, "'", ""), """", "") & "'", "login", agrupar_por:="login")) Then
                MessageBox.Show("O login inserido já existe. Informe outro login e tente novamente", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim sqlcmd As MySqlCommand

        Try

            Dim ms As New IO.MemoryStream
            Imagem_Carregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = ms.ToArray

            Abrir_Conexao()

            sqlcmd = New MySqlCommand("sp_editar_usuario", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", get_id_usuario)
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

            sqlcmd.Parameters.AddWithValue("p_id_status", txt_Status.Tag)
            sqlcmd.Parameters.AddWithValue("p_id_filial", txt_Filial.Tag)
            sqlcmd.Parameters.AddWithValue("p_id_setor", txt_Setor.Tag)
            sqlcmd.Parameters.AddWithValue("p_id_perfil", txt_Perfil.Tag)

            sqlcmd.Parameters.AddWithValue("p_texto_resposta_email", txt_Texto_Padrao.Text)
            sqlcmd.Parameters.AddWithValue("p_emails_copia", txt_Emails_Copia.Text)

            sqlcmd.Parameters.Add("p_imagem", MySqlDbType.LongBlob).Value = byteArray

            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            Dim Id_Usuario As Integer = get_id_usuario
            Select Case Mensagem_Conclusao
                Case "Valor não existe"
                    MessageBox.Show("O usuário não foi encontrado na database", "Alteração não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "Valor editado com sucesso"
                    MessageBox.Show("Usuário editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

End Class