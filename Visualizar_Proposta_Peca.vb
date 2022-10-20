Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Outlook
Imports MySql.Data.MySqlClient

Public Class Visualizar_Proposta_Peca
    Private Sub Visualizar_Proposta_Peca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta linha de código carrega dados na tabela 'Db_eurolift_sgtDataSet.dt_Data_Aprovacao'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_Data_AprovacaoTableAdapter.Fill(Me.Db_eurolift_sgtDataSet.dt_Data_Aprovacao, get_id_proposta)

        'TODO: esta linha de código carrega dados na tabela 'db_eurolift_sgtDataSet.dt_Servicos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_ServicosTableAdapter.Fill(Me.Db_eurolift_sgtDataSet.dt_Servicos, get_id_proposta)
        'TODO: esta linha de código carrega dados na tabela 'db_eurolift_sgtDataSet.dt_Propostas'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_PropostasTableAdapter.Fill(Me.Db_eurolift_sgtDataSet.dt_Propostas, get_id_proposta)
        'TODO: esta linha de código carrega dados na tabela 'db_eurolift_sgtDataSet.dt_Pecas'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_PecasTableAdapter.Fill(Me.Db_eurolift_sgtDataSet.dt_Pecas, get_id_proposta)
        'TODO: esta linha de código carrega dados na tabela 'db_eurolift_sgtDataSet.dt_Pecas'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_Usuario_FilialTableAdapter.Fill(Me.Db_eurolift_sgtDataSet.dt_Usuario_Filial, get_id_usuario)

        ToolStripComboBox1.SelectedIndex = 0
        ToolStripComboBox2.SelectedIndex = 0

        Select Case get_exibir_codigo
            Case "Nao_Exibir"
                ToolStripComboBox3.SelectedIndex = 0 'Ocultar códigos
            Case "Atual_Abreviado"
                ToolStripComboBox3.SelectedIndex = 1 'Exibir código atual abreviado
            Case "Atual_Completo"
                ToolStripComboBox3.SelectedIndex = 2 'Exibir código atual completo
            Case "Todos"
                ToolStripComboBox3.SelectedIndex = 3 'Exibir todos os códigos
        End Select

        Dim Param1 As New ReportParameter
        Param1.Name = "pm_Exibe_Codigo" '*** The actual name of the parameter in the report ***
        Param1.Values.Add(get_exibir_codigo) 'Atual_Abreviado, Atual_Completo, Todos, Nao_Exibir
        Me.ReportViewer1.LocalReport.SetParameters(Param1)

        Dim Param2 As New ReportParameter
        Param2.Name = "pm_Exibe_NCM" '*** The actual name of the parameter in the report ***
        Param2.Values.Add(ToolStripComboBox1.Text) 'Ocultar, Exibir
        Me.ReportViewer1.LocalReport.SetParameters(Param2)

        Dim Param3 As New ReportParameter
        Param3.Name = "pm_Exibe_Conjunto" '*** The actual name of the parameter in the report ***
        Param3.Values.Add(ToolStripComboBox2.Text) 'Ocultar, Exibir
        Me.ReportViewer1.LocalReport.SetParameters(Param3)

        Me.ReportViewer1.LocalReport.DisplayName = GET_DATA_MYSQL("tb_propostas", "codigo_proposta", "id_proposta=" & get_id_proposta)
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub mnui_Responder_Click(sender As Object, e As EventArgs) Handles mnui_Responder.Click

        Dim pasta_proposta As String = Environ("TEMP") & "\SGT\Proposta_PDF\"

        If CREATE_FOLDER(pasta_proposta) = False Then
            MessageBox.Show("Não foi possível criar a pasta para salvar a proposta. Por favor, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call SaveReportToPdf(pasta_proposta & Me.ReportViewer1.LocalReport.DisplayName & ".pdf", "PDF")

        Dim form = New Responder_Email
        form.txt_local_proposta_pdf.Text = pasta_proposta & Me.ReportViewer1.LocalReport.DisplayName & ".pdf"
        form.txt_proposta_pdf.Text = Me.ReportViewer1.LocalReport.DisplayName & ".pdf"
        form.ShowDialog()

        My.Computer.FileSystem.DeleteFile(pasta_proposta & Me.ReportViewer1.LocalReport.DisplayName & ".pdf")

    End Sub

    Private Sub mnui_Enviar_Click(sender As Object, e As EventArgs) Handles mnui_Enviar.Click

        Dim pasta_proposta As String = Environ("TEMP") & "\SGT\Proposta_PDF\"

        If CREATE_FOLDER(pasta_proposta) = False Then
            MessageBox.Show("Não foi possível criar a pasta para salvar a proposta. Por favor, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call SaveReportToPdf(pasta_proposta & Me.ReportViewer1.LocalReport.DisplayName & ".pdf", "PDF")

        Dim Texto_Fornecedor As String = ""
        Dim olApp As New Outlook.Application()
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")
        Dim olMail As MailItem
        olMail = olApp.CreateItem(0)
        Dim Pasta_Cotacao As String = ""
        'Dim olFolder As MAPIFolder = olNameSpace.GetFolderFromID(EntryID)
        'Dim olItems As Items
        'Dim olItem As Object

        'If (TypeOf olItem Is MailItem) Then

        'olMail = olItem

        With olMail
            .Display()
            .Subject = "Proposta de Venda - " & Me.ReportViewer1.LocalReport.DisplayName
            .CC = GET_DATA_MYSQL("tb_usuarios", "emails_copia", "id_usuario = " & get_id_usuario)
            .Attachments.Add(pasta_proposta & Me.ReportViewer1.LocalReport.DisplayName & ".pdf")
            Dim signature As String = .HTMLBody
            .HTMLBody = "<b>Prezado (a), </b><br><br>" & GET_DATA_MYSQL("tb_usuarios", "texto_resposta_email", "id_usuario=" & get_id_usuario) & "<br>" & signature
        End With

        ' End If

        GC.Collect()
        GC.WaitForPendingFinalizers()

        If String.IsNullOrEmpty(CONVERT_TO_STRING(GET_DATA_MYSQL("tb_propostas", "data_envio", "id_proposta=" & get_id_proposta))) Then
            Atualiza_Data_Envio()
        End If

        My.Computer.FileSystem.DeleteFile(pasta_proposta & Me.ReportViewer1.LocalReport.DisplayName & ".pdf")

    End Sub

    Public Sub SaveReportToPdf(ByVal strNomFichier As String, ByVal strFormat As String)
        Dim bytes() As Byte
        Dim strDeviceInfo As String = ""
        Dim strMimeType As String = ""
        Dim strEncoding As String = ""
        Dim strExtension As String = ""
        Dim strStreams() As String
        Dim warnings() As Warning
        Dim oFileStream As FileStream
        Dim _stream = New List(Of Stream)
        Try
            bytes = Me.ReportViewer1.LocalReport.Render(strFormat, strDeviceInfo, strMimeType, strEncoding, strExtension, strStreams, warnings)

            oFileStream = New FileStream(strNomFichier, FileMode.Create)
            oFileStream.Write(bytes, 0, bytes.Length)
            _stream.Add(oFileStream)
        Finally
            If Not IsNothing(oFileStream) Then
                oFileStream.Close()
                oFileStream.Dispose()
            End If
        End Try
    End Sub

    Sub Atualiza_Data_Envio()

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_atualiza_data_envio", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_proposta", get_id_proposta)
            sqlcmd.Parameters.AddWithValue("p_data_envio", Now)
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Retorno As String = CONVERT_TO_STRING(sqlcmd.Parameters("p_mensagem").Value)

            'txt_Codigo_Proposta.Text = Format(Now, "ddMMyyyy") & CONVERT_TO_LETTER(Contagem_Proposta + 1)

        Catch ex As System.Exception
            MessageBox.Show("Erro ao atualizar última proposta. Detalhes: " + ex.Message + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub


    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim Param2 As New ReportParameter
        Param2.Name = "pm_Exibe_NCM" '*** The actual name of the parameter in the report ***
        Param2.Values.Add(ToolStripComboBox1.Text) 'Ocultar, Exibir
        Me.ReportViewer1.LocalReport.SetParameters(Param2)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub ToolStripComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        Dim Param2 As New ReportParameter
        Param2.Name = "pm_Exibe_Conjunto" '*** The actual name of the parameter in the report ***
        Param2.Values.Add(ToolStripComboBox2.Text) 'Ocultar, Exibir
        Me.ReportViewer1.LocalReport.SetParameters(Param2)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox3.SelectedIndexChanged

        Dim novo_exibir_codigo As String = get_exibir_codigo
        Select Case ToolStripComboBox3.Text
            Case "Ocultar códigos"
                novo_exibir_codigo = "Nao_Exibir"
            Case "Exibir código atual abreviado"
                novo_exibir_codigo = "Atual_Abreviado"
            Case "Exibir código atual completo"
                novo_exibir_codigo = "Atual_Completo"
            Case "Exibir todos os códigos"
                novo_exibir_codigo = "Todos"
        End Select

        Dim Param1 As New ReportParameter
        Param1.Name = "pm_Exibe_Codigo" '*** The actual name of the parameter in the report ***
        Param1.Values.Add(novo_exibir_codigo) 'Atual_Abreviado, Atual_Completo, Todos, Nao_Exibir
        Me.ReportViewer1.LocalReport.SetParameters(Param1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class