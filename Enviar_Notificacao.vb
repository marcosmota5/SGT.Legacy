
Public Class Enviar_Notificacao
    Private Sub btn_Adicionar_Anexo_Click(sender As Object, e As EventArgs) Handles btn_Adicionar_Anexo.Click
        Using OFD As New OpenFileDialog ' With {.Filter = "Arquivos de imagem (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"}
            OFD.Multiselect = True

            If OFD.ShowDialog = DialogResult.OK Then

                For Each file As String In OFD.FileNames

                    lsv_Anexos.Items.Add(New ListViewItem({Math.Round(FileLen(file) / 1024, 0) & " kb", file}))

                    For Each column As ColumnHeader In lsv_Anexos.Columns
                        column.Width = -2
                    Next

                    txt_Tamanho_Total.Text = CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) + FileLen(file)

                    lbl_Tamanho_Total.Text = "Tamanho total: " & Format(Math.Round(CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) / 1024, 0), "#,###") & " kb"

                    If CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) > 10000000 Then
                        lbl_Tamanho_Total.ForeColor = Color.FromArgb(255, 0, 0)
                    Else
                        lbl_Tamanho_Total.ForeColor = Color.FromArgb(0, 0, 0)
                    End If

                Next
            End If
        End Using
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_Remover_Anexo_Click(sender As Object, e As EventArgs) Handles btn_Remover_Anexo.Click
        For Each it As ListViewItem In lsv_Anexos.Items
            If it.Selected = True Then

                txt_Tamanho_Total.Text = CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) - FileLen(it.SubItems(1).Text)

                lbl_Tamanho_Total.Text = "Tamanho total: " & Format(Math.Round(CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) / 1024, 0), "#,###") & " kb"

                If CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) > 10000000 Then
                    lbl_Tamanho_Total.ForeColor = Color.FromArgb(255, 0, 0)
                Else
                    lbl_Tamanho_Total.ForeColor = Color.FromArgb(0, 0, 0)
                End If

                it.Remove()

            End If
        Next
    End Sub

    Sub Envia_Email_Reportar_Erro()

        Dim strObrigatorios As String = ""

        If txt_Descricao.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Descricao.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Descricao.Text
            End If
            lbl_Descricao.ForeColor = Color.Red
        Else
            lbl_Descricao.ForeColor = Color.Black
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

        If strObrigatorios <> "" Then
            txt_Descricao.Focus()
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If CONVERT_TO_DECIMAL(txt_Tamanho_Total.Text) > 10000000 Then
            lbl_Tamanho_Total.ForeColor = Color.FromArgb(255, 0, 0)
            MessageBox.Show(Me, "O tamanho total dos anexos não pode superar 10.000 kb. Remova alguns anexos e tente novamente", "Tamanho máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim anexos As String = ""

        For Each it As ListViewItem In lsv_Anexos.Items
            If anexos = "" Then
                anexos = it.SubItems(1).Text
            Else
                anexos = anexos & "|" & it.SubItems(1).Text
            End If
        Next

        Dim em_email_para As String = "marcos.mota@proreports.com.br"
        Dim em_numero_notificacao As String = Format(Now, "yyyyMMddhhmmss")
        Dim em_versao As String = My.Application.Info.Version.ToString
        Dim em_data As String = Format(Now, "dd/MM/yyyy")
        Dim em_hora As String = Format(Now, "hh:mm:ss")
        Dim em_tipo As String = cbo_Tipo.Text
        Dim em_prioridade As String = cbo_Prioridade.Text


        Dim em_id_usuario As String = GET_DATA_MYSQL("tb_usuarios", "id_usuario", "id_usuario = " & get_id_usuario)
        Dim em_nome_usuario As String = GET_DATA_MYSQL("tb_usuarios", "nome", "id_usuario = " & get_id_usuario)
        Dim em_login_usuario As String = GET_DATA_MYSQL("tb_usuarios", "login", "id_usuario = " & get_id_usuario)
        Dim em_telefone_usuario As String = GET_DATA_MYSQL("tb_usuarios", "telefone", "id_usuario = " & get_id_usuario)
        Dim em_email_usuario As String = GET_DATA_MYSQL("tb_usuarios", "email", "id_usuario = " & get_id_usuario)

        Dim msg_email As String = "<html><head><style>header {    background-color: darkblue;    color:white;    text-align:left;    padding:10px;    width:700px;    height:20px;    line-height:2px} section {    width:500px;    float:left;    padding:1px;    line-height:15px;}" _
        & "footer {    background-color:darkblue;    color:white;    clear:both;    text-align:center;    width:700px;    height:1px;    padding:10px;}</style></head><body>" _
        & "<header><font size='4'><b>SGT | Sistema de Gerenciamento Total</b></font><section><p align='left'><font size='4' color='black'><br><br><b>Prezado(a) desenvolvedor (a),</b></font><font size='3' color='black'><br><br>O usuário abaixo deseja enviar uma notificação. Detalhes seguem abaixo:" &
        "<br><br><b>Número da notificação:</b> " & em_numero_notificacao &
        "<br><b>Data:</b> " & em_data &
        "<br><b>Hora:</b> " & em_hora &
        "<br><b>Tipo:</b> " & em_tipo &
        "<br><b>Prioridade:</b> " & em_prioridade &
        "<br><b>Versão do sistema:</b> " & em_versao &
        "<br><b>ID do usuário:</b> " & em_id_usuario &
        "<br><b>Nome do usuário:</b> " & em_nome_usuario &
        "<br><b>Login do usuário:</b> " & em_login_usuario &
        "<br><b>E-mail do usuário:</b> " & em_email_usuario &
        "<br><b>Telefone do usuário:</b> " & em_telefone_usuario &
        "<br><b>Descrição:</b> " & txt_Descricao.Text &
        "<br><b>Comentários:</b> " & txt_Comentarios.Text &
        "<br></section><footer></footer><section><font size='2' color='black'><center>" & GET_DATA_MYSQL("tb_empresas", "razao_social", "id_empresa=1") & "<br>CNPJ: " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_empresas", "CNPJ", "id_empresa=1")), "00\.000\.000\/0000\-00") & "<br>" & GET_DATA_MYSQL("tb_filiais", "endereco", "id_empresa=1 AND id_filial=1") & " – " &
        GET_DATA_MYSQL("tb_filiais AS fili", "cida.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_cidades AS cida ON fili.id_cidade=cida.id_cidade") & "–" & GET_DATA_MYSQL("tb_filiais AS fili", "esta.nome", "fili.id_empresa=1 AND fili.id_filial=1", juncao_interna:="tb_estados AS esta ON fili.id_estado=esta.id_estado") &
        " – CEP " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "CEP", "id_empresa=1 AND id_filial=1")), "00\.000\-000") & "<br>Tel " & Format(CONVERT_TO_LONG(GET_DATA_MYSQL("tb_filiais", "telefone_geral", "id_empresa=1 AND id_filial=1")), "(00) 0000-0000") & "<br>2018-" & Format(Now, "yyyy") & ". " & GET_DATA_MYSQL("tb_empresas", "nome_fantasia", "id_empresa=1") & ". Todos os direitos reservados.</center></section></body></html>"

        If SEND_EMAIL(em_email_para, "SGT - Notificação - " & em_tipo & " - " & em_prioridade & " - " & em_numero_notificacao, msg_email, mailAttachments:=anexos) = True Then
            MessageBox.Show("A notificação foi enviada ao desenvolvedor. Caso necessário você receberá uma resposta por e-mail. O número da notificação é: " & em_numero_notificacao, "Notificação enviada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Problema no envio da notificação. Caso o erro persista, contate o administrador", "Erro no envio do e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Close()

    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click
        Envia_Email_Reportar_Erro()
    End Sub
End Class