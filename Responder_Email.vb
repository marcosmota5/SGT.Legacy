Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class Responder_Email

    Private pEmailName As String = ""
    Private ndSelected As String = ""

    Private Sub Responder_Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Preenche_Pastas_Email()

        Dim nDate As Date = Now

        dtp_De.Value = DateAdd(DateInterval.Day, -7, nDate)
        dtp_Ate.Value = nDate
        dtp_De.MaxDate = nDate
        dtp_Ate.MaxDate = nDate

        pEmailName = CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.SelectedReplyEmailFolder))

        ndSelected = ""
        RecurseNodes(trv_Pasta_Email.Nodes)

    End Sub

    Private Sub RecurseNodes(ByVal col As TreeNodeCollection)
        If Not String.IsNullOrEmpty(pEmailName) Then
            If String.IsNullOrEmpty(ndSelected) Then
                For Each tn As TreeNode In col
                    If CONVERT_TO_STRING(tn.Name) = pEmailName Then
                        trv_Pasta_Email.SelectedNode = tn
                        ndSelected = tn.Name
                        Exit For
                    End If
                    If tn.Nodes.Count > 0 Then
                        RecurseNodes(tn.Nodes)
                    End If
                Next tn
            End If
        End If
    End Sub

    Sub Preenche_Pastas_Email()

        Dim olApp As New Outlook.Application
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")

        Dim olSubFolder_n1 As MAPIFolder
        Dim olSubFolder_n2 As MAPIFolder
        Dim olSubFolder_n3 As MAPIFolder
        Dim olSubFolder_n4 As MAPIFolder
        Dim olSubFolder_n5 As MAPIFolder

        Dim ndFolder As TreeNode
        Dim ndSubFolder_n1 As TreeNode
        Dim ndSubFolder_n2 As TreeNode
        Dim ndSubFolder_n3 As TreeNode
        Dim ndSubFolder_n4 As TreeNode
        Dim ndSubFolder_n5 As TreeNode

        For Each olFolder As MAPIFolder In olNameSpace.Folders
            ndFolder = trv_Pasta_Email.Nodes.Add(olFolder.EntryID, olFolder.Name)
            For Each olSubFolder_n1 In olFolder.Folders
                ndSubFolder_n1 = ndFolder.Nodes.Add(olSubFolder_n1.EntryID, olSubFolder_n1.Name)
                For Each olSubFolder_n2 In olSubFolder_n1.Folders
                    ndSubFolder_n2 = ndSubFolder_n1.Nodes.Add(olSubFolder_n2.EntryID, olSubFolder_n2.Name)
                    For Each olSubFolder_n3 In olSubFolder_n2.Folders
                        ndSubFolder_n3 = ndSubFolder_n2.Nodes.Add(olSubFolder_n3.EntryID, olSubFolder_n3.Name)
                        For Each olSubFolder_n4 In olSubFolder_n3.Folders
                            ndSubFolder_n4 = ndSubFolder_n3.Nodes.Add(olSubFolder_n4.EntryID, olSubFolder_n4.Name)
                            For Each olSubFolder_n5 In olSubFolder_n4.Folders
                                ndSubFolder_n5 = ndSubFolder_n4.Nodes.Add(olSubFolder_n5.EntryID, olSubFolder_n5.Name)
                            Next
                        Next
                    Next
                Next
            Next
        Next

    End Sub

    Sub Retorna_Emails()

        If trv_Pasta_Email.SelectedNode Is Nothing Then
            Exit Sub
        End If

        Dim EntryID As String = trv_Pasta_Email.SelectedNode.Name
        Dim olApp As New Outlook.Application()
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")
        Dim olFolder As MAPIFolder = olNameSpace.GetFolderFromID(EntryID)
        Dim olMail As MailItem
        Dim olItems As Items
        Dim olItem As Object

        Try

            dtg_Emails.Columns.Clear()
            dtg_Emails.Rows.Clear()

            dtg_Emails.Columns.Add("id", "ID")
            dtg_Emails.Columns.Add("data_recebimento", "Data/hora")
            dtg_Emails.Columns.Add("remetente", "Remetente")
            dtg_Emails.Columns.Add("assunto", "Assunto")

            dtg_Emails.Columns("id").Visible = False

            Dim dtDe As Date = Date.Parse(dtp_De.Value.ToShortDateString)
            Dim dtAte As Date = Date.Parse(dtp_Ate.Value.ToShortDateString)
            Dim dtRev As Date

            olItems = olFolder.Items
            olItems.Sort("[ReceivedTime]", True)

            For Each olItem In olItems
                If (TypeOf olItem Is MailItem) Then
                    olMail = olItem
                    dtRev = Date.Parse(olMail.ReceivedTime.ToShortDateString)
                    If dtRev >= dtDe And dtRev <= dtAte Then
                        dtg_Emails.Rows.Add(olMail.EntryID, olMail.ReceivedTime, olMail.SenderEmailAddress, olMail.Subject)
                    Else
                        Exit For
                    End If
                End If

            Next

        Catch ex As System.Exception

        End Try

    End Sub

    Sub Responde_Email(EntryID As String)

        Dim Texto_Fornecedor As String = ""
        Dim olApp As New Outlook.Application()
        Dim olNameSpace As [NameSpace] = olApp.GetNamespace("MAPI")
        Dim olItem As Object = olNameSpace.GetItemFromID(EntryID)
        Dim olMail As MailItem
        Dim Pasta_Cotacao As String = ""
        'Dim olFolder As MAPIFolder = olNameSpace.GetFolderFromID(EntryID)
        'Dim olItems As Items
        'Dim olItem As Object

        If (TypeOf olItem Is MailItem) Then

            olMail = olItem

            With olMail.ReplyAll()
                .Display()
                .Subject = .Subject & " - Proposta de Venda - " & txt_proposta_pdf.Text
                .CC = .CC & GET_DATA_MYSQL("tb_usuarios", "emails_copia", "id_usuario = " & get_id_usuario)
                .Attachments.Add(txt_local_proposta_pdf.Text)
                Dim signature As String = .HTMLBody
                .HTMLBody = "<b>Prezado (a), </b><br><br>" & GET_DATA_MYSQL("tb_usuarios", "texto_resposta_email", "id_usuario=" & get_id_usuario) & "<br>" & signature
            End With

        End If

        GC.Collect()
        GC.WaitForPendingFinalizers()

        If String.IsNullOrEmpty(CONVERT_TO_STRING(GET_DATA_MYSQL("tb_propostas", "data_envio", "id_proposta=" & get_id_proposta))) Then
            Atualiza_Data_Envio()
        End If

    End Sub

    Private Sub trv_Pasta_Email_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trv_Pasta_Email.AfterSelect
        Retorna_Emails()
    End Sub

    Private Sub dtp_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_De.ValueChanged
        Retorna_Emails()
    End Sub

    Private Sub dtp_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Ate.ValueChanged
        Retorna_Emails()
    End Sub

    Private Sub dtg_Emails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Emails.CellDoubleClick
        Dim dtg_row As DataGridViewRow = dtg_Emails.Rows(e.RowIndex)
        'get_id_proposta = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_row.Cells("ID_Proposta").Value))
        Responde_Email(dtg_Emails.CurrentRow.Cells(0).Value.ToString)
        'Dim form = New Proposta
        'Form.ShowDialog()
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
            MessageBox.Show("Erro ao atualizar data de envio. Detalhes: " + ex.Message + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    'Private Sub dtg_Emails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtg_Emails.CellMouseDown
    '    dtg_Emails.ContextMenuStrip = Nothing
    '    If e.Button = MouseButtons.Right And e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '        dtg_Emails.CurrentCell = dtg_Emails(e.ColumnIndex, e.RowIndex)
    '        dtg_Emails.ContextMenuStrip = cms_Importar
    '    End If
    'End Sub

End Class

