Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net
Public Class Entrar

    Private e_id_usuario As Integer
    Private e_nome_usuario As String
    Private e_login_usuario As String
    Private e_email_usuario As String


    Private Sub Entrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versao() As String
        versao = Split(Verifica_Versao, ";")

        Select Case versao(0)
            Case "Erro"
                MessageBox.Show(Me, "Não foi possível verfiicar se há novas versões dispoíveis. Caso o erro persista, contate o desenvolvedor", "Erro na verificação de versão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case "Antiga opcional"
                Dim aform = New Nova_Versao
                aform.txt_tipo_versao.Text = "opcional"
                aform.lbl_Pergunta.Text = "Existe uma nova versão opcional do sistema. Deseja efetuar o download e instalar agora?"
                aform.lbl_Versao_Atual.Text = "Versão instalada:  " & My.Application.Info.Version.ToString
                aform.lbl_Nova_Versao.Text = "Nova versão: " & versao(1)
                aform.ptb_Informacao.Visible = True
                aform.ptb_Exclamacao.Visible = False
                aform.ShowDialog()
                'Me.Show()
                Me.Visible = True
                Me.Focus()
            Case "Antiga crítica"
                Dim aform = New Nova_Versao
                aform.txt_tipo_versao.Text = "crítica"
                aform.lbl_Pergunta.Text = "Existe uma nova versão crítica do sistema, não será possível utilizar a versão instalada. Deseja efetuar o download e instalar agora?"
                aform.lbl_Versao_Atual.Text = "Versão instalada:  " & My.Application.Info.Version.ToString
                aform.lbl_Nova_Versao.Text = "Nova versão: " & versao(1)
                aform.ptb_Informacao.Visible = False
                aform.ptb_Exclamacao.Visible = True
                aform.ShowDialog()
        End Select


        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_retorna_login", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_usuario", GET_REGISTRY_VALUE(Registry_Values.CurrentUserId))
            sqlcmd.Parameters.Add("p_login", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            txt_Login_Email.Text = sqlcmd.Parameters("p_login").Value.ToString

        Catch ex As Exception

        Finally
            Fechar_Conexao()
        End Try

        If Not String.IsNullOrEmpty(txt_Login_Email.Text) Then
            ' Me.Show()
            txt_Senha.Select()
        End If

    End Sub
    Private Sub btn_Entrar_Click(sender As Object, e As EventArgs) Handles btn_Entrar.Click
        Efetua_Login()
    End Sub
    Sub Efetua_Login()

        Dim strObrigatorios As String = ""

        If txt_Login_Email.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Login_Email.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Login_Email.Text
            End If
            lbl_Login_Email.ForeColor = Color.Red
        Else
            lbl_Login_Email.ForeColor = Color.Black
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

        If strObrigatorios <> "" Then
            txt_Login_Email.Focus()
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_efetua_login", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_login", txt_Login_Email.Text)
            sqlcmd.Parameters.AddWithValue("p_email", txt_Login_Email.Text)
            sqlcmd.Parameters.AddWithValue("p_senha", txt_Senha.Text)
            sqlcmd.Parameters.Add("p_id_usuario", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("po_login", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("po_email", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_perfil", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_nome_perfil", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_setor", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_nome_setor", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_filial", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_nome_filial", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_pais", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_nome_pais", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_estado", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_nome_estado", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_id_cidade", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_nome_cidade", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_imagem", MySqlDbType.LongBlob).Direction = 2
            sqlcmd.Parameters.Add("p_data_ultima_alteracao_senha", MySqlDbType.DateTime).Direction = 2
            sqlcmd.Parameters.Add("p_texto_resposta_email", MySqlDbType.Text).Direction = 2
            sqlcmd.Parameters.Add("p_emails_copia", MySqlDbType.Text).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            Dim Data_Ultima_Alteracao As DateTime = sqlcmd.Parameters("p_data_ultima_alteracao_senha").Value
            Dim Imagem As Byte() = Nothing

            get_id_usuario = Integer.Parse(sqlcmd.Parameters("p_id_usuario").Value)
            get_nome_usuario = sqlcmd.Parameters("p_nome").Value.ToString
            get_login_usuario = sqlcmd.Parameters("po_login").Value.ToString
            get_email_usuario = sqlcmd.Parameters("po_email").Value.ToString
            get_id_perfil = Integer.Parse(sqlcmd.Parameters("p_id_perfil").Value)
            get_nome_perfil = sqlcmd.Parameters("p_nome_perfil").Value.ToString
            get_id_setor = Integer.Parse(sqlcmd.Parameters("p_id_setor").Value)
            get_nome_setor = sqlcmd.Parameters("p_nome_setor").Value.ToString
            get_id_filial = Integer.Parse(sqlcmd.Parameters("p_id_filial").Value)
            get_nome_filial = sqlcmd.Parameters("p_nome_filial").Value.ToString
            get_id_pais = Integer.Parse(sqlcmd.Parameters("p_id_pais").Value)
            get_nome_pais = sqlcmd.Parameters("p_nome_pais").Value.ToString
            get_id_estado = Integer.Parse(sqlcmd.Parameters("p_id_estado").Value)
            get_nome_estado = sqlcmd.Parameters("p_nome_estado").Value.ToString
            get_id_cidade = Integer.Parse(sqlcmd.Parameters("p_id_cidade").Value)
            get_nome_cidade = sqlcmd.Parameters("p_nome_cidade").Value.ToString

            If sqlcmd.Parameters("p_imagem").Value.ToString <> "" Then
                Imagem = DirectCast(sqlcmd.Parameters("p_imagem").Value, Byte())
            End If

            Select Case Mensagem_Conclusao
                Case "Login e/ou e-mail não existe"
                    MessageBox.Show("O login ou e-mail informado não existe na database", "Login ou e-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Senha inválida"
                    MessageBox.Show("Senha inválida", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Valor inativo"
                    MessageBox.Show("O usuário informado está inativo. Favor contatar o administrador", "Usuário inativo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Logado com sucesso"

                    Dim duration As TimeSpan

                    duration = Now - Data_Ultima_Alteracao

                    If duration > TimeSpan.FromDays(90) Then
                        MessageBox.Show("Sua senha expirou. Por favor, defina uma nova senha e, após isso, efetue o login novamente", "Senha expirada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim aform = New Alterar_Senha
                        aform.ShowDialog()
                        Exit Sub
                    End If

                    MessageBox.Show("Login efetuado com sucesso. Bem vindo (a), " & GET_WORD(get_nome_usuario, " ", Part_Word_Text.First_Word), "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim form = New Inicio
                    form.lbl_Nome_Usuario.Text = GET_WORD(get_nome_usuario, " ", Part_Word_Text.First_Word) & " " & GET_WORD(get_nome_usuario, " ", Part_Word_Text.Last_Word)
                    form.lbl_Perfil.Text = get_nome_perfil
                    form.lbl_Filial.Text = get_nome_filial & " | " & get_nome_setor
                    form.stsi_Login.Text = "Usuário: " & get_login_usuario
                    'form.stsi_Setor.Text = " | Setor: " & get_nome_setor

                    If Imagem Is Nothing Then
                    Else
                        If FOLDER_EXISTS(Environ("TEMP") & "\SGT") = False Then
                            CREATE_FOLDER(Environ("TEMP") & "\SGT")
                        End If
                        Dim strArquivo As String = Environ("TEMP") & "\SGT\userimage"
                        Dim fs As New FileStream(strArquivo, FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(Imagem, 0, Imagem.Length)
                        fs.Flush()
                        fs.Close()

                        Dim imgg As Image = Image.FromFile(strArquivo)
                        form.ptb_Imagem_Usuario.Image = New Bitmap(imgg)
                        imgg.Dispose()

                    End If

                    Set_Registry_Value(Registry_Values.CurrentUserId, get_id_usuario)

                    Me.Hide()
                    form.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try
    End Sub

    Private Sub btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles btn_Cadastrar.Click

        get_id_usuario = 2
        get_id_proposta = 1
        Dim form = New Visualizar_Proposta
        form.ShowDialog()

        ' MessageBox.Show(GET_DATA_MYSQL("tb_propostas", "codigo_proposta", "id_proposta=1"))


        'Dim sss As String = "CONTROLE DE ESTOQUE 2020"
        'Dim strarquivoSalvo As String = ""

        'Using OFD As New SaveFileDialog With {.FileName = "importacao", .Filter = "Arquivo do Excel (*.xlsx)|*.xlsx"}
        '    If OFD.ShowDialog = DialogResult.OK Then
        '        strarquivoSalvo = OFD.FileName
        '    End If
        'End Using

        'MessageBox.Show(strarquivoSalvo)

        'MessageBox.Show(CONVERT_TO_STRING(GET_LAST_STOCK_FILE("E:\Marcos Mota\Área de Trabalho\Eurolift\SGP - Sistema de Gerenciamento de Propostas\12-12-2019", "CONTROLE DE ESTOQUE*")))
        'Dim form = New Cadastrar_Usuario
        'Form.ShowDialog()
        'Me.Hide()
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

    Private Sub txt_Login_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_Login_Email.TextChanged
        If txt_Login_Email.Text = "" Then
            lbl_Login_Email.ForeColor = Color.Red
        Else
            lbl_Login_Email.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Senha_TextChanged(sender As Object, e As EventArgs) Handles txt_Senha.TextChanged
        If txt_Senha.Text = "" Then
            lbl_Senha.ForeColor = Color.Red
        Else
            lbl_Senha.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Senha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Efetua_Login()
        End If
    End Sub

    Private Sub lnk_Esqueci_Senha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Esqueci_Senha.LinkClicked

        If MessageBox.Show(text:="Deseja enviar um e-mail de recuperação de senha para o seu e-mail cadastrado?", caption:="Recuperação", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
            Exit Sub
        End If

        Envia_Email_Recuperacao()
    End Sub

    Sub Envia_Email_Recuperacao()

        Dim strObrigatorios As String = ""

        If txt_Login_Email.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Login_Email.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Login_Email.Text
            End If
            lbl_Login_Email.ForeColor = Color.Red
        Else
            lbl_Login_Email.ForeColor = Color.Black
        End If

        If strObrigatorios <> "" Then
            txt_Login_Email.Focus()
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_retorna_email", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_login", txt_Login_Email.Text)
            sqlcmd.Parameters.AddWithValue("p_email", txt_Login_Email.Text)
            sqlcmd.Parameters.Add("p_id_usuario", MySqlDbType.Int64).Direction = 2
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("p_nome", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("po_login", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.Parameters.Add("po_email", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

            Select Case Mensagem_Conclusao
                Case "Login e/ou e-mail não existe"
                    MessageBox.Show("O login ou e-mail informado não existe na database", "Login ou e-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Valor inativo"
                    MessageBox.Show("O usuário informado está inativo. Favor contatar o administrador", "Usuário inativo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case "Retornado com sucesso"
                Case Else
                    MessageBox.Show("Erro ao recuperar os dados do usuário. Caso o erro persista, contate o administrador", "Erro não especificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            e_id_usuario = Integer.Parse(sqlcmd.Parameters("p_id_usuario").Value)
            e_nome_usuario = sqlcmd.Parameters("p_nome").Value.ToString
            e_login_usuario = sqlcmd.Parameters("po_login").Value.ToString
            e_email_usuario = sqlcmd.Parameters("po_email").Value.ToString

            get_temp_id_usuario = e_id_usuario

            get_codigo_recuperacao = GET_RANDOM_CODE(6)

            Dim msg_email As String = "<html><head><style>header {    background-color:darkblue;    color:white;    text-align:left;    padding:10px;    width:700px;    height:20px;    line-height:2px} section {    width:500px;    float:left;    padding:1px;    line-height:15px;}" _
& "footer {    background-color:darkblue;    color:white;    clear:both;    text-align:center;    width:700px;    height:1px;    padding:10px;}</style></head><body>" _
& "<header><font size='4'><b>SGT | Sistema de Gerenciamento Total</b></font><section><p align='left'><font size='4' color='black'><br><br><b>Prezado(a) " & GET_WORD(e_nome_usuario, " ", Part_Word_Text.First_Last_Word) & ",</b></font><font size='3' color='black'><br><br>Segue o código de recuperação de senha. Copie esse código e cole na caixa correspondente na ferramenta:" &
"<br><br>" & get_codigo_recuperacao & "<br><br>" &
"</section><footer></footer><section><font size='2' color='black'><center>" & GET_DATA_MYSQL("tb_empresas", "razao_social", "id_empresa=1") & "<br>CNPJ: " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_empresas", "CNPJ", "id_empresa=1")), "00\.000\.000\/0000\-00") & "<br>" & GET_DATA_MYSQL("tb_filiais", "endereco", "id_empresa=1 AND id_filial=1") & " – " &
GET_DATA_MYSQL("tb_filiais AS fili", "cida.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_cidades AS cida ON fili.id_cidade=cida.id_cidade") & "–" & GET_DATA_MYSQL("tb_filiais AS fili", "esta.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_estados AS esta ON fili.id_estado=esta.id_estado") &
" – CEP " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "CEP", "id_empresa=1 AND id_filial=1")), "00\.000\-000") & "<br>Tel " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "telefone_geral", "id_empresa=1 AND id_filial=1")), "(00) 0000-0000") & "<br>2018-" & Format(Now, "yyyy") & ". " & GET_DATA_MYSQL("tb_empresas", "nome_fantasia", "id_empresa=1") & ". Todos os direitos reservados.</center></section></body></html>"

            If SEND_EMAIL(e_email_usuario, "Recuperação de senha", msg_email) = True Then
                MessageBox.Show("Foi enviado um código de recuperação para seu e-mail cadastrado. Lembre-se de checar a caixa de spam. Informe o código no campo correspondente da tela a seguir e defina uma nova senha", "Código de recuperação enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim form = New Recuperar_Senha
                ' Me.Hide()
                form.ShowDialog()
            Else
                MessageBox.Show("Problema no envio do código de recuperação. Caso o erro persista, contate o administrador", "Erro no envio do e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try
    End Sub

End Class
