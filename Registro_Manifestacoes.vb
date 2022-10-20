Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Registro_Manifestacoes
    Private Sub Registro_Manifestacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Preenche_Comboboxes()

        If String.IsNullOrEmpty(txt_id_registro_manifestacao.Text) Or CONVERT_TO_STRING(txt_id_registro_manifestacao.Text) = "0" Then

            mnsi_Editar.Enabled = False
            mnsi_Editar.ToolTipText = ""

            For Each ctl As Control In grp_Fechamento.Controls
                ctl.Enabled = False
            Next

            grp_Fechamento.Visible = False

            btn_Cancelar.Top = 453
            btn_Salvar.Top = btn_Cancelar.Top
            'Me.Height = 525

            dtp_Data_Abertura.Value = Now

            txt_Pessoa_Abertura.Text = get_nome_usuario
            txt_Email_Abertura.Text = get_email_usuario
            txt_id_status_inicial.Text = ""

        Else


            cbo_Prioridade.Enabled = False
            cbo_Tipo.Enabled = False
            cbo_Status.Enabled = False
            txt_Descricao_Abertura.Enabled = False
            dtp_Data_Abertura.Enabled = False
            txt_Pessoa_Abertura.Enabled = False
            txt_Email_Abertura.Enabled = False
            btn_Adicionar_Comentario.Enabled = False
            btn_Excluir_Comentario.Enabled = False
            btn_Adicionar_Imagem.Enabled = False
            btn_Excluir_Imagem.Enabled = False

            txt_Descricao_Fechamento.Enabled = False
            dtp_Data_Fechamento.Enabled = False
            txt_Pessoa_Fechamento.Enabled = False
            txt_Email_Fechamento.Enabled = False

            btn_Cancelar.Enabled = False
            btn_Salvar.Enabled = False
            btn_Cancelar.Visible = False
            btn_Salvar.Visible = False


            Dim adapter As MySqlDataAdapter

            Try
                Abrir_Conexao_Proreports()

                Dim dtbRegistroManifestacao As New DataTable

                adapter = New MySqlDataAdapter("SELECT * FROM tb_registro_manifestacoes AS rema
                                                WHERE id_registro_manifestacao = " & txt_id_registro_manifestacao.Text, strConexaoProreports)

                adapter.Fill(dtbRegistroManifestacao)

                Dim rowManifestacao As DataRow = dtbRegistroManifestacao.Rows(0)

                cbo_Prioridade.SelectedValue = rowManifestacao("id_prioridade_manifestacao")
                cbo_Tipo.SelectedValue = rowManifestacao("id_tipo_manifestacao")
                cbo_Status.SelectedValue = rowManifestacao("id_status_manifestacao")
                txt_id_status_inicial.Text = rowManifestacao("id_status_manifestacao")
                txt_Descricao_Abertura.Text = CONVERT_TO_STRING(rowManifestacao("descricao_abertura"))
                dtp_Data_Abertura.Value = rowManifestacao("data_abertura")
                txt_Pessoa_Abertura.Text = CONVERT_TO_STRING(rowManifestacao("nome_pessoa_abertura"))
                txt_Email_Abertura.Text = CONVERT_TO_STRING(rowManifestacao("email_pessoa_abertura"))

                txt_Descricao_Fechamento.Text = CONVERT_TO_STRING(rowManifestacao("descricao_fechamento"))

                If IsDate(rowManifestacao("data_fechamento")) Then
                    dtp_Data_Fechamento.Value = rowManifestacao("data_fechamento")
                End If

                txt_Pessoa_Fechamento.Text = CONVERT_TO_STRING(rowManifestacao("nome_pessoa_fechamento"))
                txt_Email_Fechamento.Text = CONVERT_TO_STRING(rowManifestacao("email_pessoa_fechamento"))

                'Se o usuário atual é o desenvolvedor
                If CONFIRMA_DESENVOLVEDOR(RETORNA_ENDERECO_MAC()) Then

                    mnsi_Editar.Enabled = True
                    mnsi_Editar.ToolTipText = ""

                Else

                    If txt_Pessoa_Abertura.Text = get_nome_usuario Then
                        mnsi_Editar.Enabled = True
                        mnsi_Editar.ToolTipText = ""
                    Else
                        mnsi_Editar.Enabled = False
                        mnsi_Editar.ToolTipText = "Somente o usuário que criou a requisição pode editá-la"
                    End If

                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
            Finally
                Fechar_Conexao_Proreports()
            End Try

        End If

        Carregar_Comentarios()
        Carregar_Imagens()
        Carregar_Historico()
        'mnsi_Editar

    End Sub
    Function RETORNA_ENDERECO_MAC() As String

        Dim mc As System.Management.ManagementClass
        Dim mo As System.Management.ManagementBaseObject
        mc = New Management.ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As Management.ManagementObjectCollection = mc.GetInstances
        For Each mo In moc
            If mo.Item("IPenabled") = True Then
                Return mo.Item("MacAddress")
            End If
        Next

        Return ""

    End Function

    Function CONFIRMA_DESENVOLVEDOR(Endereco_MAC As String) As Boolean

        Dim sqlcmd As MySqlCommand

        Try

            Abrir_Conexao_Proreports()

            sqlcmd = New MySqlCommand("SELECT id_endereco_mac_desenvolvedor FROM tb_enderecos_mac_desenvolvedores WHERE endereco_mac_desenvolvedor = '" & Endereco_MAC & "'", strConexaoProreports)
            sqlcmd.CommandType = CommandType.Text
            Dim cmdreader As MySqlDataReader = sqlcmd.ExecuteReader()
            Dim tmpvl As String = ""
            While cmdreader.Read()
                tmpvl = cmdreader.GetString(0)
            End While

            cmdreader.Close()

            cmdreader = Nothing

            If CONVERT_TO_INTEGER(tmpvl) > 0 Then
                Return True
            End If

        Catch ex As Exception
            Return False
        Finally
            Fechar_Conexao_Proreports()
        End Try

        Return False

    End Function

    Private Sub Preenche_Comboboxes()

        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao_Proreports()

            adapter = New MySqlDataAdapter("SELECT id_prioridade_manifestacao, nome FROM tb_prioridades_manifestacoes", strConexaoProreports)

            adapter.Fill(ds, "tb_prioridades_manifestacoes")

            cbo_Prioridade.DisplayMember = "nome"
            cbo_Prioridade.ValueMember = "id_prioridade_manifestacao"
            cbo_Prioridade.DataSource = ds.Tables("tb_prioridades_manifestacoes")

            adapter = New MySqlDataAdapter("SELECT id_tipo_manifestacao, nome FROM tb_tipos_manifestacoes", strConexaoProreports)

            adapter.Fill(ds, "tb_tipos_manifestacoes")

            cbo_Tipo.DisplayMember = "nome"
            cbo_Tipo.ValueMember = "id_tipo_manifestacao"
            cbo_Tipo.DataSource = ds.Tables("tb_tipos_manifestacoes")

            If String.IsNullOrEmpty(txt_id_registro_manifestacao.Text) Or CONVERT_TO_STRING(txt_id_registro_manifestacao.Text) = "0" Then
                adapter = New MySqlDataAdapter("SELECT id_status_manifestacao, nome FROM tb_status_manifestacoes WHERE id_status_manifestacao = 1", strConexaoProreports)
            Else
                adapter = New MySqlDataAdapter("SELECT id_status_manifestacao, nome FROM tb_status_manifestacoes", strConexaoProreports)
            End If

            adapter.Fill(ds, "tb_status_manifestacoes")

            cbo_Status.DisplayMember = "nome"
            cbo_Status.ValueMember = "id_status_manifestacao"
            cbo_Status.DataSource = ds.Tables("tb_status_manifestacoes")

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message + ex.StackTrace)
        Finally
            Fechar_Conexao_Proreports()
        End Try

    End Sub

    Private Sub Carregar_Comentarios()

        ' Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT * FROM tb_comentarios_registro_manifestacoes AS comen WHERE id_registro_manifestacao = " & CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text) & " ORDER BY data_insercao ASC", strConexaoProreports)
            dtbComenatarios = New DataTable
            adapter.Fill(dtbComenatarios)
            dtg_Comentarios.DataSource = dtbComenatarios

            dtg_Comentarios.Columns("data_insercao").HeaderText = "Data/hora"
            dtg_Comentarios.Columns("comentario").HeaderText = "Comentário"
            dtg_Comentarios.Columns("nome_pessoa_insercao").HeaderText = "Nome responsável"
            dtg_Comentarios.Columns("email_pessoa_insercao").HeaderText = "E-mail responsável"

            dtg_Comentarios.Columns("id_comentario_registro_manifestacao").Visible = False
            dtg_Comentarios.Columns("id_registro_manifestacao").Visible = False
            dtg_Comentarios.Columns("data_insercao").Visible = True
            dtg_Comentarios.Columns("comentario").Visible = True
            dtg_Comentarios.Columns("nome_pessoa_insercao").Visible = True
            dtg_Comentarios.Columns("email_pessoa_insercao").Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Carregar_Imagens()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT * FROM tb_imagens_registro_manifestacoes AS comen WHERE id_registro_manifestacao = " & CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text) & " ORDER BY data_insercao ASC", strConexaoProreports)
            dtbImagens = New DataTable
            adapter.Fill(dtbImagens)
            dtg_Imagens.DataSource = dtbImagens

            Dim Imagem As Byte() = Nothing
            For Each dtRow As DataRow In dtbImagens.Rows
                If dtRow("imagem").ToString <> "" Then
                    Imagem = DirectCast(dtRow("imagem"), Byte())
                End If

                If Imagem Is Nothing Then
                Else
                    If FOLDER_EXISTS(Environ("TEMP") & "\SGT") = False Then
                        CREATE_FOLDER(Environ("TEMP") & "\SGT")
                    End If
                    Dim strArquivo As String = Environ("TEMP") & "\SGT\regmanimage"
                    Dim fs As New FileStream(strArquivo, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(Imagem, 0, Imagem.Length)
                    fs.Flush()
                    fs.Close()

                    Dim imgg As Image = Image.FromFile(strArquivo)

                    Dim Miniatura As Image = ResizeImage(imgg)

                    Dim msMiniatura As New IO.MemoryStream
                    Miniatura.Save(msMiniatura, System.Drawing.Imaging.ImageFormat.Png)
                    Dim byteArrayMiniatura = msMiniatura.ToArray

                    dtRow("miniatura") = byteArrayMiniatura

                    imgg.Dispose()

                End If

            Next

            dtg_Imagens.Columns("data_insercao").HeaderText = "Data/hora"
            dtg_Imagens.Columns("miniatura").HeaderText = "Imagem"
            dtg_Imagens.Columns("nome_pessoa_insercao").HeaderText = "Nome responsável"
            dtg_Imagens.Columns("email_pessoa_insercao").HeaderText = "E-mail responsável"

            dtg_Imagens.Columns("id_imagem_registro_manifestacao").Visible = False
            dtg_Imagens.Columns("id_registro_manifestacao").Visible = False
            dtg_Imagens.Columns("data_insercao").Visible = True
            dtg_Imagens.Columns("miniatura").Visible = True
            dtg_Imagens.Columns("imagem").Visible = False
            dtg_Imagens.Columns("tamanho_imagem").Visible = False
            dtg_Imagens.Columns("nome_pessoa_insercao").Visible = True
            dtg_Imagens.Columns("email_pessoa_insercao").Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Carregar_Historico()

        ' Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT * FROM tb_historico_manifestacoes AS hist WHERE id_registro_manifestacao = " & CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text) & " ORDER BY data_alteracao ASC", strConexaoProreports)
            dtbHistorico = New DataTable
            adapter.Fill(dtbHistorico)
            dtg_Historico.DataSource = dtbHistorico
            dtg_Historico.Columns("data_alteracao").HeaderText = "Data/hora"
            dtg_Historico.Columns("descricao_alteracao").HeaderText = "Descrição"
            dtg_Historico.Columns("nome_pessoa_alteracao").HeaderText = "Nome responsável"
            dtg_Historico.Columns("email_pessoa_alteracao").HeaderText = "E-mail responsável"

            dtg_Historico.Columns("id_historico_manifestacao").Visible = False
            dtg_Historico.Columns("id_registro_manifestacao").Visible = False
            dtg_Historico.Columns("data_alteracao").Visible = True
            dtg_Historico.Columns("descricao_alteracao").Visible = True
            dtg_Historico.Columns("nome_pessoa_alteracao").Visible = True
            dtg_Historico.Columns("email_pessoa_alteracao").Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Dim strObrigatorios As String = ""

        If txt_Descricao_Abertura.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Descricao_Abertura.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Descricao_Abertura.Text
            End If
            lbl_Descricao_Abertura.ForeColor = Color.Red
        Else
            lbl_Descricao_Abertura.ForeColor = Color.Black
        End If

        If txt_Descricao_Fechamento.Visible = True Then
            If txt_Descricao_Fechamento.Text = "" Then
                If strObrigatorios = "" Then
                    strObrigatorios = lbl_Descricao_Fechamento.Text
                Else
                    strObrigatorios = strObrigatorios & ", " & lbl_Descricao_Fechamento.Text
                End If
                lbl_Descricao_Fechamento.ForeColor = Color.Red
            Else
                lbl_Descricao_Fechamento.ForeColor = Color.Black
            End If
        End If

        If cbo_Tipo.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Tipo.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Tipo.Text
            End If
            lbl_Tipo.ForeColor = Color.Red
        Else
            lbl_Tipo.ForeColor = Color.Black
        End If

        If cbo_Prioridade.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Prioridade.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Prioridade.Text
            End If
            lbl_Prioridade.ForeColor = Color.Red
        Else
            lbl_Prioridade.ForeColor = Color.Black
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
            MessageBox.Show("Os campos a seguir são obrigatórios. Preencha-os antes de continuar." & vbNewLine & vbNewLine & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand
        Dim sqlcmd2 As MySqlCommand
        Dim sqlcmd3 As MySqlCommand

        If CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) > 3072000 Then
            lbl_Tamanho_Total.ForeColor = Color.FromArgb(255, 0, 0)
            MessageBox.Show(Me, "O tamanho total das imagens não pode superar 3.000 kb (3mb). Remova algumas imagens e tente novamente", "Tamanho máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            lbl_Tamanho_Total.ForeColor = Color.FromArgb(0, 0, 0)
        End If

        Try
            Abrir_Conexao_Proreports()

            If String.IsNullOrEmpty(txt_id_registro_manifestacao.Text) Or CONVERT_TO_STRING(txt_id_registro_manifestacao.Text) = "0" Then

                sqlcmd = New MySqlCommand("sp_inserir_manifestacao", strConexaoProreports)

                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_descricao_abertura", txt_Descricao_Abertura.Text)
                sqlcmd.Parameters.AddWithValue("p_nome_pessoa_abertura", txt_Pessoa_Abertura.Text)
                sqlcmd.Parameters.AddWithValue("p_email_pessoa_abertura", txt_Email_Abertura.Text)
                sqlcmd.Parameters.AddWithValue("p_id_tipo_manifestacao", cbo_Tipo.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_prioridade_manifestacao", cbo_Prioridade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_status_manifestacao", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_id_registro_manifestacao", MySqlDbType.Int32).Direction = 2
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                Dim id_registro_manifestacao_inserido As Integer = sqlcmd.Parameters("p_id_registro_manifestacao").Value

                txt_id_registro_manifestacao.Text = id_registro_manifestacao_inserido

                For Each drow As DataGridViewRow In dtg_Comentarios.Rows

                    If CONVERT_TO_STRING(drow.Cells("id_comentario_registro_manifestacao").Value) = "0" Then

                        sqlcmd2 = New MySqlCommand("sp_inserir_comentario_manifestacao", strConexaoProreports)

                        sqlcmd2.CommandType = CommandType.StoredProcedure
                        sqlcmd2.Parameters.AddWithValue("p_id_registro_manifestacao", id_registro_manifestacao_inserido)
                        sqlcmd2.Parameters.AddWithValue("p_comentario", drow.Cells("comentario").Value)
                        sqlcmd2.Parameters.AddWithValue("p_nome_pessoa_insercao", txt_Pessoa_Abertura.Text)
                        sqlcmd2.Parameters.AddWithValue("p_email_pessoa_insercao", txt_Email_Abertura.Text)
                        sqlcmd2.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                        sqlcmd2.ExecuteNonQuery()

                    End If

                Next

                For Each drow2 As DataGridViewRow In dtg_Imagens.Rows

                    If CONVERT_TO_STRING(drow2.Cells("id_imagem_registro_manifestacao").Value) = "0" Then

                        sqlcmd3 = New MySqlCommand("sp_inserir_imagem_manifestacao", strConexaoProreports)

                        sqlcmd3.CommandType = CommandType.StoredProcedure
                        sqlcmd3.Parameters.AddWithValue("p_id_registro_manifestacao", id_registro_manifestacao_inserido)
                        sqlcmd3.Parameters.Add("p_imagem", MySqlDbType.LongBlob).Value = drow2.Cells("imagem").Value
                        sqlcmd3.Parameters.AddWithValue("p_tamanho_imagem", drow2.Cells("tamanho_imagem").Value)
                        sqlcmd3.Parameters.AddWithValue("p_nome_pessoa_insercao", txt_Pessoa_Abertura.Text)
                        sqlcmd3.Parameters.AddWithValue("p_email_pessoa_insercao", txt_Email_Abertura.Text)
                        sqlcmd3.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                        sqlcmd3.ExecuteNonQuery()

                    End If

                Next

                Envia_Email_Desenvolvedor(t_tipo_descricao.t_Insercao)
                Envia_Email_Solicitante(t_tipo_descricao.t_Insercao)

                MessageBox.Show("Requisição inserida com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                sqlcmd = New MySqlCommand("sp_editar_manifestacao", strConexaoProreports)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_registro_manifestacao", CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text))
                sqlcmd.Parameters.AddWithValue("p_nome_pessoa_alteracao", get_nome_usuario)
                sqlcmd.Parameters.AddWithValue("p_email_pessoa_alteracao", get_email_usuario)
                sqlcmd.Parameters.AddWithValue("p_descricao_fechamento", txt_Descricao_Fechamento.Text)
                sqlcmd.Parameters.AddWithValue("p_id_tipo_manifestacao", cbo_Tipo.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_prioridade_manifestacao", cbo_Prioridade.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_status_manifestacao", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString

                For Each drow As DataGridViewRow In dtg_Comentarios.Rows

                    If drow.Cells("id_comentario_registro_manifestacao").Value = 0 Then

                        sqlcmd2 = New MySqlCommand("sp_inserir_comentario_manifestacao", strConexaoProreports)

                        sqlcmd2.CommandType = CommandType.StoredProcedure
                        sqlcmd2.Parameters.AddWithValue("p_id_registro_manifestacao", CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text))
                        sqlcmd2.Parameters.AddWithValue("p_comentario", drow.Cells("comentario").Value)
                        sqlcmd2.Parameters.AddWithValue("p_nome_pessoa_insercao", get_nome_usuario)
                        sqlcmd2.Parameters.AddWithValue("p_email_pessoa_insercao", get_email_usuario)
                        sqlcmd2.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                        sqlcmd2.ExecuteNonQuery()

                    End If

                Next

                For Each drow2 As DataGridViewRow In dtg_Imagens.Rows

                    If drow2.Cells("id_imagem_registro_manifestacao").Value = 0 Then

                        sqlcmd3 = New MySqlCommand("sp_inserir_imagem_manifestacao", strConexaoProreports)

                        sqlcmd3.CommandType = CommandType.StoredProcedure
                        sqlcmd3.Parameters.AddWithValue("p_id_registro_manifestacao", CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text))
                        sqlcmd3.Parameters.Add("p_imagem", MySqlDbType.LongBlob).Value = drow2.Cells("imagem").Value
                        sqlcmd3.Parameters.AddWithValue("p_tamanho_imagem", drow2.Cells("tamanho_imagem").Value)
                        sqlcmd3.Parameters.AddWithValue("p_nome_pessoa_insercao", get_nome_usuario)
                        sqlcmd3.Parameters.AddWithValue("p_email_pessoa_insercao", get_email_usuario)
                        sqlcmd3.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                        sqlcmd3.ExecuteNonQuery()

                    End If

                Next

                If CONVERT_TO_STRING(txt_comentario_excluido.Text) = CONVERT_TO_STRING(1) Then
                    Excluir_Comentarios()
                End If

                If CONVERT_TO_STRING(txt_imagem_excluida.Text) = CONVERT_TO_STRING(1) Then
                    Excluir_Imagens()
                End If

                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("A Requisição não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Envia_Email_Desenvolvedor(t_tipo_descricao.t_Edicao)
                    Envia_Email_Solicitante(t_tipo_descricao.t_Edicao)

                    MessageBox.Show("Requisição editada com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao_Proreports()
        End Try

        Me.Close()

    End Sub
    Enum t_tipo_descricao

        t_Insercao = 1
        t_Edicao = 2

    End Enum
    Sub Envia_Email_Desenvolvedor(tipo_descricao As t_tipo_descricao)

        Dim em_email_para As String = "marcos.mota@proreports.com.br"
        Dim em_numero_notificacao As Integer = CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text)
        Dim em_versao As String = My.Application.Info.Version.ToString
        Dim em_data As String = Format(Now, "dd/MM/yyyy")
        Dim em_hora As String = Format(Now, "hh:mm:ss")
        Dim em_tipo As String = cbo_Tipo.Text
        Dim em_prioridade As String = cbo_Prioridade.Text
        Dim em_status As String = cbo_Status.Text

        Dim em_nome_usuario As String = get_nome_usuario
        Dim em_email_usuario As String = get_email_usuario

        Dim em_texto_inicial_requisicao As String

        If tipo_descricao = t_tipo_descricao.t_Insercao Then
            em_texto_inicial_requisicao = "Uma nova requisição foi criada no SGT. Detalhes seguem abaixo. Para mais informações, verifique no sistema."
        Else
            em_texto_inicial_requisicao = "A requisição abaixo foi alterada no SGT. Para mais informações, verifique no sistema."
        End If

        Dim em_assunto_requisicao As String

        If tipo_descricao = t_tipo_descricao.t_Insercao Then
            em_assunto_requisicao = "SGT - Requisição REQN" & Format(em_numero_notificacao, "00000000") & " - Criada"
        Else
            em_assunto_requisicao = "SGT - Requisição REQN" & Format(em_numero_notificacao, "00000000") & " - Alterada"
        End If

        Dim msg_email As String = "<html><head><style>header {    background-color: darkblue;    color:white;    text-align:left;    padding:10px;    width:700px;    height:20px;    line-height:2px} section {    width:500px;    float:left;    padding:1px;    line-height:15px;}" _
        & "footer {    background-color:darkblue;    color:white;    clear:both;    text-align:center;    width:700px;    height:1px;    padding:10px;}</style></head><body>" _
        & "<header><font size='4'><b>SGT | Sistema de Gerenciamento Total</b></font><section><p align='left'><font size='4' color='black'><br><br><b>Prezado(a) desenvolvedor (a),</b></font><font size='3' color='black'><br><br>" & em_texto_inicial_requisicao &
        "<br><br><b>Código:</b> REQN" & Format(em_numero_notificacao, "00000000") &
        "<br><b>Data:</b> " & em_data &
        "<br><b>Hora:</b> " & em_hora &
        "<br><b>Tipo:</b> " & em_tipo &
        "<br><b>Prioridade:</b> " & em_prioridade &
        "<br><b>Status:</b> " & em_status &
        "<br><b>Versão do sistema:</b> " & em_versao &
        "<br><b>Nome do usuário:</b> " & em_nome_usuario &
        "<br><b>E-mail do usuário:</b> " & em_email_usuario &
        "<br></section><footer></footer><section><font size='2' color='black'><center>" & GET_DATA_MYSQL("tb_empresas", "razao_social", "id_empresa=1") & "<br>CNPJ: " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_empresas", "CNPJ", "id_empresa=1")), "00\.000\.000\/0000\-00") & "<br>" & GET_DATA_MYSQL("tb_filiais", "endereco", "id_empresa=1 AND id_filial=1") & " – " &
        GET_DATA_MYSQL("tb_filiais AS fili", "cida.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_cidades AS cida ON fili.id_cidade=cida.id_cidade") & "–" & GET_DATA_MYSQL("tb_filiais AS fili", "esta.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_estados AS esta ON fili.id_estado=esta.id_estado") &
        " – CEP " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "CEP", "id_empresa=1 AND id_filial=1")), "00\.000\-000") & "<br>Tel " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "telefone_geral", "id_empresa=1 AND id_filial=1")), "(00) 0000-0000") & "<br>2018-" & Format(Now, "yyyy") & ". " & GET_DATA_MYSQL("tb_empresas", "nome_fantasia", "id_empresa=1") & ". Todos os direitos reservados.</center></section></body></html>"

        If SEND_EMAIL(em_email_para, em_assunto_requisicao, msg_email) = False Then
            MessageBox.Show("Erro no envio do e-mail para o desenvolvedor, por favor, verifique se a requisição foi criada. Caso o erro persista, contate o administrador", "Erro no envio do e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub
    Sub Envia_Email_Solicitante(tipo_descricao As t_tipo_descricao)

        Dim em_email_para As String = txt_Email_Abertura.Text
        Dim em_numero_notificacao As Integer = CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text)
        Dim em_versao As String = My.Application.Info.Version.ToString
        Dim em_data As String = Format(Now, "dd/MM/yyyy")
        Dim em_hora As String = Format(Now, "hh:mm:ss")
        Dim em_tipo As String = cbo_Tipo.Text
        Dim em_prioridade As String = cbo_Prioridade.Text
        Dim em_status As String = cbo_Status.Text

        Dim em_nome_usuario As String = get_nome_usuario
        Dim em_email_usuario As String = get_email_usuario

        Dim em_texto_inicial_requisicao As String

        If tipo_descricao = t_tipo_descricao.t_Insercao Then
            em_texto_inicial_requisicao = "Sua requisição foi criada no SGT. Detalhes seguem abaixo. Para mais informações, verifique no sistema."
        Else
            em_texto_inicial_requisicao = "Sua requisição abaixo foi alterada no SGT. Para mais informações, verifique no sistema."
        End If

        Dim em_assunto_requisicao As String

        If tipo_descricao = t_tipo_descricao.t_Insercao Then
            em_assunto_requisicao = "SGT - Requisição REQN" & Format(em_numero_notificacao, "00000000") & " - Criada"
        Else
            em_assunto_requisicao = "SGT - Requisição REQN" & Format(em_numero_notificacao, "00000000") & " - Alterada"
        End If

        Dim msg_email As String = "<html><head><style>header {    background-color: darkblue;    color:white;    text-align:left;    padding:10px;    width:700px;    height:20px;    line-height:2px} section {    width:500px;    float:left;    padding:1px;    line-height:15px;}" _
        & "footer {    background-color:darkblue;    color:white;    clear:both;    text-align:center;    width:700px;    height:1px;    padding:10px;}</style></head><body>" _
        & "<header><font size='4'><b>SGT | Sistema de Gerenciamento Total</b></font><section><p align='left'><font size='4' color='black'><br><br><b>Prezado(a) " & GET_WORD(txt_Pessoa_Abertura.Text) & ",</b></font><font size='3' color='black'><br><br>" & em_texto_inicial_requisicao &
        "<br><br><b>Código:</b> REQN" & Format(em_numero_notificacao, "00000000") &
        "<br><b>Data:</b> " & em_data &
        "<br><b>Hora:</b> " & em_hora &
        "<br><b>Tipo:</b> " & em_tipo &
        "<br><b>Prioridade:</b> " & em_prioridade &
        "<br><b>Status:</b> " & em_status &
        "<br><b>Versão do sistema:</b> " & em_versao &
        "<br><b>Nome do usuário:</b> " & em_nome_usuario &
        "<br><b>E-mail do usuário:</b> " & em_email_usuario &
        "<br></section><footer></footer><section><font size='2' color='black'><center>" & GET_DATA_MYSQL("tb_empresas", "razao_social", "id_empresa=1") & "<br>CNPJ: " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_empresas", "CNPJ", "id_empresa=1")), "00\.000\.000\/0000\-00") & "<br>" & GET_DATA_MYSQL("tb_filiais", "endereco", "id_empresa=1 AND id_filial=1") & " – " &
        GET_DATA_MYSQL("tb_filiais AS fili", "cida.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_cidades AS cida ON fili.id_cidade=cida.id_cidade") & "–" & GET_DATA_MYSQL("tb_filiais AS fili", "esta.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_estados AS esta ON fili.id_estado=esta.id_estado") &
        " – CEP " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "CEP", "id_empresa=1 AND id_filial=1")), "00\.000\-000") & "<br>Tel " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "telefone_geral", "id_empresa=1 AND id_filial=1")), "(00) 0000-0000") & "<br>2018-" & Format(Now, "yyyy") & ". " & GET_DATA_MYSQL("tb_empresas", "nome_fantasia", "id_empresa=1") & ". Todos os direitos reservados.</center></section></body></html>"

        If SEND_EMAIL(em_email_para, em_assunto_requisicao, msg_email) = False Then
            MessageBox.Show("Erro no envio do e-mail para o desenvolvedor, por favor, verifique se a requisição foi criada. Caso o erro persista, contate o administrador", "Erro no envio do e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub
    Sub Excluir_Comentarios()

        Dim adapter As MySqlDataAdapter
        Dim sqlcmd As MySqlCommand

        Try
            'Abrir_Conexao()

            Dim dtb_comentarios As New DataTable

            adapter = New MySqlDataAdapter("SELECT id_comentario_registro_manifestacao FROM tb_comentarios_registro_manifestacoes WHERE id_registro_manifestacao = " & CONVERT_TO_STRING(txt_id_registro_manifestacao.Text), strConexaoProreports)

            adapter.Fill(dtb_comentarios)

            For Each dtb_comentarios_row As DataRow In dtb_comentarios.Rows
                Dim comentarios_encontrados As DataRow() = dtbComenatarios.Select("id_comentario_registro_manifestacao = " & dtb_comentarios_row("id_comentario_registro_manifestacao"))
                If comentarios_encontrados.Length = 0 Then
                    sqlcmd = New MySqlCommand("sp_excluir_comentario_manifestacao", strConexaoProreports)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_comentario_registro_manifestacao", dtb_comentarios_row("id_comentario_registro_manifestacao"))
                    sqlcmd.Parameters.AddWithValue("p_id_registro_manifestacao", CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text))
                    sqlcmd.Parameters.AddWithValue("p_nome_pessoa_insercao", get_nome_usuario)
                    sqlcmd.Parameters.AddWithValue("p_email_pessoa_insercao", get_email_usuario)
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                    Dim Mensagem_Retorno As String = CONVERT_TO_STRING(sqlcmd.Parameters("p_mensagem").Value)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            'Fechar_Conexao()
        End Try
    End Sub

    Sub Excluir_Imagens()

        Dim adapter As MySqlDataAdapter
        Dim sqlcmd As MySqlCommand

        Try
            'Abrir_Conexao()

            Dim dtb_imagens As New DataTable

            adapter = New MySqlDataAdapter("SELECT id_imagem_registro_manifestacao FROM tb_imagens_registro_manifestacoes WHERE id_registro_manifestacao = " & CONVERT_TO_STRING(txt_id_registro_manifestacao.Text), strConexaoProreports)

            adapter.Fill(dtb_imagens)

            For Each dtb_imagens_row As DataRow In dtb_imagens.Rows
                Dim imagens_encontrados As DataRow() = dtbImagens.Select("id_imagem_registro_manifestacao = " & dtb_imagens_row("id_imagem_registro_manifestacao"))
                If imagens_encontrados.Length = 0 Then
                    sqlcmd = New MySqlCommand("sp_excluir_imagem_manifestacao", strConexaoProreports)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_imagem_registro_manifestacao", dtb_imagens_row("id_imagem_registro_manifestacao"))
                    sqlcmd.Parameters.AddWithValue("p_id_registro_manifestacao", CONVERT_TO_INTEGER(txt_id_registro_manifestacao.Text))
                    sqlcmd.Parameters.AddWithValue("p_nome_pessoa_insercao", get_nome_usuario)
                    sqlcmd.Parameters.AddWithValue("p_email_pessoa_insercao", get_email_usuario)
                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                    Dim Mensagem_Retorno As String = CONVERT_TO_STRING(sqlcmd.Parameters("p_mensagem").Value)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            'Fechar_Conexao()
        End Try
    End Sub

    Private Sub cbo_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged

        If cbo_Status.SelectedValue = 4 Then

            grp_Fechamento.Visible = True
            btn_Cancelar.Top = 575
            btn_Salvar.Top = btn_Cancelar.Top

            If btn_Cancelar.Visible = True Then
                Me.Height = 651
            Else
                Me.Height = 615
            End If


        Else

            grp_Fechamento.Visible = False
            btn_Cancelar.Top = 453
            btn_Salvar.Top = btn_Cancelar.Top

            If btn_Cancelar.Visible = True Then
                Me.Height = 525
            Else
                Me.Height = 495
            End If

        End If

    End Sub

    Private Sub btn_Adicionar_Comentario_Click(sender As Object, e As EventArgs) Handles btn_Adicionar_Comentario.Click

        Dim form = New Comentario_Manifestacao
        form.ShowDialog()

    End Sub

    Private Sub btn_Excluir_Comentario_Click(sender As Object, e As EventArgs) Handles btn_Excluir_Comentario.Click

        If dtbComenatarios.Rows.Count < 1 Then
            Exit Sub
        End If

        Dim dtb_row As DataRow

        dtb_row = dtbComenatarios.Rows(dtg_Comentarios.SelectedRows(0).Index)

        If dtb_row("id_comentario_registro_manifestacao") > 0 Then
            If MessageBox.Show(text:="Tem certeza que deseja remover o comentário? O processo não poderá ser desfeito", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If

        Dim linha_comentario As Integer = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Comentarios.SelectedRows(0).Index))

        If CONVERT_TO_STRING(txt_comentario_excluido.Text) <> CONVERT_TO_STRING(1) Then
            Dim drow As DataRow = dtbComenatarios.Rows(linha_comentario)
            If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_comentario_registro_manifestacao"))) <> 0 Then
                txt_comentario_excluido.Text = 1
            End If
        End If
        'get_linha_item = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Itens.SelectedRows(0).Index))

        'If CONVERT_TO_STRING(txt_item_excluido.Text) <> CONVERT_TO_STRING(1) Then
        '    Dim drow As DataRow = dtbItens.Rows(get_linha_item)
        '    If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_item_proposta"))) <> 0 Then
        '        txt_item_excluido.Text = 1
        '    End If
        'End If

        dtbComenatarios.Rows.RemoveAt(dtg_Comentarios.SelectedRows(0).Index)
        'dtbItens.Rows(get_linha_item).Delete()


    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        If String.IsNullOrEmpty(txt_id_registro_manifestacao.Text) Or CONVERT_TO_STRING(txt_id_registro_manifestacao.Text) = "0" Then

            Me.Close()

        Else

            cbo_Prioridade.Enabled = False
            cbo_Tipo.Enabled = False
            cbo_Status.Enabled = False
            txt_Descricao_Abertura.Enabled = False
            dtp_Data_Abertura.Enabled = False
            txt_Pessoa_Abertura.Enabled = False
            txt_Email_Abertura.Enabled = False
            btn_Adicionar_Comentario.Enabled = False
            btn_Excluir_Comentario.Enabled = False
            btn_Adicionar_Imagem.Enabled = False
            btn_Excluir_Imagem.Enabled = False

            txt_Descricao_Fechamento.Enabled = False
            dtp_Data_Fechamento.Enabled = False
            txt_Pessoa_Fechamento.Enabled = False
            txt_Email_Fechamento.Enabled = False

            btn_Cancelar.Enabled = False
            btn_Salvar.Enabled = False
            btn_Cancelar.Visible = False
            btn_Salvar.Visible = False
            Me.Height -= 40

            If CONFIRMA_DESENVOLVEDOR(RETORNA_ENDERECO_MAC()) Then

                mnsi_Editar.Enabled = True
                mnsi_Editar.ToolTipText = ""

            Else

                If txt_Pessoa_Abertura.Text = get_nome_usuario Then
                    mnsi_Editar.Enabled = True
                    mnsi_Editar.ToolTipText = ""
                Else
                    mnsi_Editar.Enabled = False
                    mnsi_Editar.ToolTipText = "Somente o usuário que criou a requisição pode editá-la"
                End If

            End If

        End If
    End Sub

    Private Sub btn_Excluir_Imagem_Click(sender As Object, e As EventArgs) Handles btn_Excluir_Imagem.Click
        If dtbImagens.Rows.Count < 1 Then
            Exit Sub
        End If

        Dim dtb_row As DataRow

        dtb_row = dtbImagens.Rows(dtg_Imagens.SelectedRows(0).Index)

        If dtb_row("id_imagem_registro_manifestacao") > 0 Then
            If MessageBox.Show(text:="Tem certeza que deseja remover a imagem? O processo não poderá ser desfeito", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                Exit Sub
            End If
        End If

        Dim linha_imagem As Integer = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_Imagens.SelectedRows(0).Index))

        If CONVERT_TO_STRING(txt_imagem_excluida.Text) <> CONVERT_TO_STRING(1) Then
            Dim drow As DataRow = dtbImagens.Rows(linha_imagem)
            If CONVERT_TO_INTEGER(CONVERT_TO_STRING(drow("id_imagem_registro_manifestacao"))) <> 0 Then
                txt_imagem_excluida.Text = 1
            End If
        End If

        txt_Tamanho_Total.Text = CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) - dtb_row("tamanho_imagem")

        lbl_Tamanho_Total.Text = "Tamanho total: " & Format(Math.Round(CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) / 1024, 0), "#,###") & " kb"

        If CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) > 3072000 Then
            lbl_Tamanho_Total.ForeColor = Color.FromArgb(255, 0, 0)
        Else
            lbl_Tamanho_Total.ForeColor = Color.FromArgb(0, 0, 0)
        End If

        dtbImagens.Rows.RemoveAt(dtg_Imagens.SelectedRows(0).Index)

        'dtbItens.Rows(get_linha_item).Delete()


    End Sub

    Private Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(64, 64))
    End Function
    Private Sub btn_Adicionar_Imagem_Click(sender As Object, e As EventArgs) Handles btn_Adicionar_Imagem.Click
        Using OFD As New OpenFileDialog With {.Filter = "Arquivos permitidos (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"}
            If OFD.ShowDialog = DialogResult.OK Then

                If FileLen(OFD.FileName) > 3072000 Then
                    MessageBox.Show(text:="Não é permitido inserir imagens maiores que 3.000 kb (3mb)", caption:="Operação não permitida", buttons:=vbOKOnly, icon:=vbExclamation)
                    Exit Sub
                End If

                Dim Imagem_Carregada As Image = Image.FromFile(OFD.FileName)
                Dim Miniatura As Image = ResizeImage(Imagem_Carregada)

                Dim msImagem As New IO.MemoryStream
                Imagem_Carregada.Save(msImagem, System.Drawing.Imaging.ImageFormat.Png)
                Dim byteArrayImagem = msImagem.ToArray

                Dim msMiniatura As New IO.MemoryStream
                Miniatura.Save(msMiniatura, System.Drawing.Imaging.ImageFormat.Png)
                Dim byteArrayMiniatura = msMiniatura.ToArray

                Dim dtb_row As DataRow

                dtb_row = dtbImagens.NewRow
                dtb_row("id_imagem_registro_manifestacao") = 0
                dtb_row("id_registro_manifestacao") = get_id_registro_manifestacao
                dtb_row("data_insercao") = Now
                dtb_row("miniatura") = byteArrayMiniatura
                dtb_row("imagem") = byteArrayImagem
                dtb_row("tamanho_imagem") = FileLen(OFD.FileName)
                dtb_row("nome_pessoa_insercao") = get_nome_usuario
                dtb_row("email_pessoa_insercao") = get_email_usuario

                dtbImagens.Rows.Add(dtb_row)

                txt_Tamanho_Total.Text = CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) + FileLen(OFD.FileName)

                lbl_Tamanho_Total.Text = "Tamanho total: " & Format(Math.Round(CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) / 1024, 0), "#,###") & " kb"

                If CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) > 3072000 Then
                    lbl_Tamanho_Total.ForeColor = Color.FromArgb(255, 0, 0)
                Else
                    lbl_Tamanho_Total.ForeColor = Color.FromArgb(0, 0, 0)
                End If

                'ptb_Imagem_Usuario.Image = Imagem_Carregada
                'txt_File_Path.Text = OFD.FileName
            End If
        End Using
    End Sub

    Private Sub dtg_Imagens_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtg_Imagens.CellMouseDown

        dtg_Imagens.ContextMenuStrip = Nothing
        If e.Button = MouseButtons.Right And e.ColumnIndex >= 0 And e.RowIndex >= 0 Then

            dtg_Imagens.CurrentCell = dtg_Imagens(e.ColumnIndex, e.RowIndex)

            dtg_Imagens.ContextMenuStrip = cms_Menu_Imagem
        End If

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

        Dim Imagem As Byte() = Nothing

        If dtg_Imagens.CurrentRow.Cells("imagem").Value.ToString <> "" Then
            Imagem = DirectCast(dtg_Imagens.CurrentRow.Cells("imagem").Value, Byte())
        End If

        If Imagem Is Nothing Then
        Else
            If FOLDER_EXISTS(Environ("TEMP") & "\SGT") = False Then
                CREATE_FOLDER(Environ("TEMP") & "\SGT")
            End If
            Dim strArquivo As String = Environ("TEMP") & "\SGT\imagem_manifestacao.png"
            Dim fs As New FileStream(strArquivo, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(Imagem, 0, Imagem.Length)
            fs.Flush()
            fs.Close()

            Process.Start(Environ("TEMP") & "\SGT\imagem_manifestacao.png")

        End If

    End Sub

    Private Sub tsmi_Salvar_Como_Click(sender As Object, e As EventArgs) Handles tsmi_Salvar_Como.Click

        Dim strarquivoSalvo As String = ""

        Using OFD As New SaveFileDialog With {.FileName = "imagem_manifestacao.png", .Filter = "PNG (*.png)|*.png"}
            If OFD.ShowDialog = DialogResult.OK Then
                strarquivoSalvo = OFD.FileName
            End If
        End Using

        If String.IsNullOrEmpty(strarquivoSalvo) Then
            Exit Sub
        End If

        Dim Imagem As Byte() = Nothing

        If dtg_Imagens.CurrentRow.Cells("imagem").Value.ToString <> "" Then
            Imagem = DirectCast(dtg_Imagens.CurrentRow.Cells("imagem").Value, Byte())
        End If

        If Imagem Is Nothing Then
        Else

            Dim fs As New FileStream(strarquivoSalvo, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(Imagem, 0, Imagem.Length)
            fs.Flush()
            fs.Close()

            If MessageBox.Show(text:="Imagem salva com sucesso! Deseja visualizar?", caption:="Procedimento concluído", buttons:=vbYesNo, icon:=vbQuestion) = vbNo Then
                Exit Sub
            End If

            Process.Start(strarquivoSalvo)

        End If

    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        mnsi_Editar.Enabled = False
        cbo_Prioridade.Enabled = True
        cbo_Tipo.Enabled = True
        btn_Adicionar_Comentario.Enabled = True
        btn_Excluir_Comentario.Enabled = True
        btn_Adicionar_Imagem.Enabled = True
        btn_Excluir_Imagem.Enabled = True
        btn_Cancelar.Enabled = True
        btn_Salvar.Enabled = True
        btn_Cancelar.Visible = True
        btn_Salvar.Visible = True

        Me.Height += 35


        If CONFIRMA_DESENVOLVEDOR(RETORNA_ENDERECO_MAC()) Then

            cbo_Status.Enabled = True

            txt_Descricao_Fechamento.Enabled = True
            dtp_Data_Fechamento.Enabled = True
            ' txt_Versao_Fechamento.Enabled = True
            'txt_Pessoa_Fechamento.Enabled = False
            'txt_Email_Fechamento.Enabled = False

        End If



    End Sub

    Private Sub dtg_Comentarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Comentarios.CellDoubleClick

        Dim dtg_row As DataGridViewRow = dtg_Comentarios.Rows(e.RowIndex)

        Dim form = New Comentario_Manifestacao

        form.txt_Comentario.Text = CONVERT_TO_STRING(dtg_row.Cells("comentario").Value)
        form.txt_Comentario.ReadOnly = True
        form.btn_Ok.Enabled = False

        form.ShowDialog()

    End Sub
End Class