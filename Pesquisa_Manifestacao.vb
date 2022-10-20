Imports MySql.Data.MySqlClient
Public Class Pesquisa_Manifestacao
    Private Sub Pesquisa_Manifestacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Limite_Resultados.Text = "*Limitado a " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)) & " resultado (s)"
        Preencher_Filtros()
        Executa_Pesquisa()
    End Sub
    Sub Preencher_Filtros()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao_Proreports()

            'Preenche a listbox de prioridade
            adapter = New MySqlDataAdapter("SELECT DISTINCT mani.id_prioridade_manifestacao AS ID_Prioridade, prio.nome AS Nome_Prioridade FROM tb_registro_manifestacoes AS mani
                                            LEFT JOIN tb_prioridades_manifestacoes AS prio ON mani.id_prioridade_manifestacao=prio.id_prioridade_manifestacao
                                            ORDER BY Nome_Prioridade ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexaoProreports)

            adapter.Fill(ds, "clb_Prioridade")
            clb_Prioridade.DataSource = ds.Tables("clb_Prioridade")
            clb_Prioridade.DisplayMember = "Nome_Prioridade"
            clb_Prioridade.ValueMember = "ID_Prioridade"

            'Preenche a listbox de tipo
            adapter = New MySqlDataAdapter("SELECT DISTINCT mani.id_tipo_manifestacao AS ID_Tipo, tipo.nome AS Nome_Tipo FROM tb_registro_manifestacoes AS mani
                                            LEFT JOIN tb_tipos_manifestacoes AS tipo ON mani.id_tipo_manifestacao=tipo.id_tipo_manifestacao
                                            ORDER BY Nome_Tipo ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexaoProreports)

            adapter.Fill(ds, "clb_Tipo")
            clb_Tipo.DataSource = ds.Tables("clb_Tipo")
            clb_Tipo.DisplayMember = "Nome_Tipo"
            clb_Tipo.ValueMember = "ID_Tipo"

            'Preenche a listbox de status
            adapter = New MySqlDataAdapter("SELECT DISTINCT mani.id_status_manifestacao AS ID_Status, stat.nome AS Nome_Status FROM tb_registro_manifestacoes AS mani
                                            LEFT JOIN tb_status_manifestacoes AS stat ON mani.id_status_manifestacao=stat.id_status_manifestacao
                                            ORDER BY Nome_Status ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexaoProreports)

            adapter.Fill(ds, "clb_Status")
            clb_Status.DataSource = ds.Tables("clb_Status")
            clb_Status.DisplayMember = "Nome_Status"
            clb_Status.ValueMember = "ID_Status"

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao_Proreports()
        End Try
    End Sub

    Sub Executa_Pesquisa()

        Dim sCondicao As String = ""
        Dim adapter As New MySqlDataAdapter()
        Dim cmd As MySqlCommand

        Dim listPrioridade As String = ""
        Dim listTipo As String = ""
        Dim listStatus As String = ""

        'Verifica prioridade selecionadas
        If clb_Prioridade.CheckedItems.Count > 0 Then
            For Each item In clb_Prioridade.CheckedItems
                If listPrioridade = "" Then
                    listPrioridade = item.Item("ID_Prioridade")
                Else
                    listPrioridade = listPrioridade & "," & item.Item("ID_Prioridade")
                End If
            Next
        End If

        If listPrioridade <> "" Then
            If sCondicao = "" Then
                sCondicao = "mani.id_prioridade_manifestacao IN (" & listPrioridade & ")"
            Else
                sCondicao = sCondicao & " AND " & "mani.id_prioridade_manifestacao IN (" & listPrioridade & ")"
            End If
        End If

        'Verifica tipo selecionadas
        If clb_Tipo.CheckedItems.Count > 0 Then
            For Each item In clb_Tipo.CheckedItems
                If listTipo = "" Then
                    listTipo = item.Item("ID_Tipo")
                Else
                    listTipo = listTipo & "," & item.Item("ID_Tipo")
                End If
            Next
        End If

        If listTipo <> "" Then
            If sCondicao = "" Then
                sCondicao = "mani.id_tipo_manifestacao IN (" & listTipo & ")"
            Else
                sCondicao = sCondicao & " AND " & "mani.id_tipo_manifestacao IN (" & listTipo & ")"
            End If
        End If

        'Verifica status selecionadas
        If clb_Status.CheckedItems.Count > 0 Then
            For Each item In clb_Status.CheckedItems
                If listStatus = "" Then
                    listStatus = item.Item("ID_Status")
                Else
                    listStatus = listStatus & "," & item.Item("ID_Status")
                End If
            Next
        End If

        If listStatus <> "" Then
            If sCondicao = "" Then
                sCondicao = "mani.id_status_manifestacao IN (" & listStatus & ")"
            Else
                sCondicao = sCondicao & " AND " & "mani.id_status_manifestacao IN (" & listStatus & ")"
            End If
        End If

        If dtp_Data_Abertura_De.Checked = True And dtp_Data_Abertura_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(mani.data_abertura) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_De.Value, "yyyy/MM/dd")) & "' AND DATE(mani.data_abertura) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(mani.data_abertura) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_De.Value, "yyyy/MM/dd")) & "' AND DATE(mani.data_abertura) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Abertura_De.Checked = True And dtp_Data_Abertura_Ate.Checked = False Then
            If sCondicao = "" Then
                sCondicao = "DATE(mani.data_abertura) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_De.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(mani.data_abertura) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_De.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Abertura_De.Checked = False And dtp_Data_Abertura_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(mani.data_abertura) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(mani.data_abertura) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Abertura_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Fechamento_De.Checked = True And dtp_Data_Fechamento_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(mani.data_fechamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_De.Value, "yyyy/MM/dd")) & "' AND DATE(mani.data_fechamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(mani.data_fechamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_De.Value, "yyyy/MM/dd")) & "' AND DATE(mani.data_fechamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Fechamento_De.Checked = True And dtp_Data_Fechamento_Ate.Checked = False Then
            If sCondicao = "" Then
                sCondicao = "DATE(mani.data_fechamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_De.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(mani.data_fechamento) >= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_De.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If dtp_Data_Fechamento_De.Checked = False And dtp_Data_Fechamento_Ate.Checked = True Then
            If sCondicao = "" Then
                sCondicao = "DATE(mani.data_fechamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_Ate.Value, "yyyy/MM/dd")) & "'"
            Else
                sCondicao = sCondicao & " AND " & "DATE(mani.data_fechamento) <= '" & CONVERT_TO_STRING(Format(dtp_Data_Fechamento_Ate.Value, "yyyy/MM/dd")) & "'"
            End If
        End If

        If sCondicao <> "" Then
            sCondicao = " WHERE " & sCondicao
        End If

        Try
            Abrir_Conexao_Proreports()

            Dim dtb_Resultados As New DataTable

            Dim strsqlcommand As String = ""

            Dim qtIf As Integer = 0

            cmd = New MySqlCommand("SELECT mani.id_registro_manifestacao AS ID_Registro_Manifestacao, prio.nome AS Nome_Prioridade, tipo.nome AS Nome_Tipo, stat.nome AS Nome_Status, mani.data_abertura AS Data_Abertura,
                                           mani.nome_pessoa_abertura AS Pessoa_Abertura, mani.descricao_abertura AS Descricao_Abertura, mani.data_fechamento AS Data_Fechamento,
                                           mani.nome_pessoa_fechamento AS Pessoa_Fechamento, mani.descricao_fechamento AS Descricao_Fechamento                                           
                                           FROM tb_registro_manifestacoes AS mani
                                           LEFT JOIN tb_prioridades_manifestacoes AS prio ON mani.id_prioridade_manifestacao=prio.id_prioridade_manifestacao
                                           LEFT JOIN tb_tipos_manifestacoes AS tipo ON mani.id_tipo_manifestacao=tipo.id_tipo_manifestacao
                                           LEFT JOIN tb_status_manifestacoes AS stat ON mani.id_status_manifestacao=stat.id_status_manifestacao " &
                                           sCondicao & " ORDER BY Data_Abertura ASC LIMIT " & CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.ResultsLimit)), strConexaoProreports)

            adapter.SelectCommand = cmd

            adapter.Fill(dtb_Resultados)
            dtg_Resultados.DataSource = dtb_Resultados

            Dim dtbCol As DataColumn
            Dim duration As TimeSpan
            Dim drow As DataRow
            dtbCol = dtb_Resultados.Columns.Add("Tempo_Fechamento")

            For Each drow In dtb_Resultados.Rows
                If Not String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Abertura"))) Then
                    If String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Fechamento"))) Then
                        duration = CONVERT_TO_DATE(Now) - CONVERT_TO_DATE(drow("Data_Abertura"))
                    Else
                        duration = CONVERT_TO_DATE(drow("Data_Fechamento")) - CONVERT_TO_DATE(drow("Data_Abertura"))
                    End If
                    drow("Tempo_Fechamento") = duration.ToString("%d") & " dia(s) e " & duration.ToString("hh\:mm")
                End If
                If Not String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Pessoa_Abertura"))) Then
                    drow("Pessoa_Abertura") = GET_WORD(CONVERT_TO_STRING(drow("Pessoa_Abertura")), " ", Part_Word_Text.First_Last_Word)
                End If
                If Not String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Pessoa_Fechamento"))) Then
                    drow("Pessoa_Fechamento") = GET_WORD(CONVERT_TO_STRING(drow("Pessoa_Fechamento")), " ", Part_Word_Text.First_Last_Word)
                End If
            Next

            If dtb_Resultados.Rows.Count = 0 Then
                lbl_Quantidade_Resultados.Text = "Nenhum resultado encontrado"
            Else
                lbl_Quantidade_Resultados.Text = "Resultados encontrados: " & dtb_Resultados.Rows.Count
            End If

            dtg_Resultados.Columns("Nome_Prioridade").HeaderText = "Prioridade"
            dtg_Resultados.Columns("Nome_Tipo").HeaderText = "Tipo"
            dtg_Resultados.Columns("Nome_Status").HeaderText = "Status"
            dtg_Resultados.Columns("Data_Abertura").HeaderText = "Data de abertura"
            dtg_Resultados.Columns("Pessoa_Abertura").HeaderText = "Solicitante"
            dtg_Resultados.Columns("Descricao_Abertura").HeaderText = "Descrição de abertura"
            dtg_Resultados.Columns("Data_Fechamento").HeaderText = "Data de fechamento"
            dtg_Resultados.Columns("Pessoa_Fechamento").HeaderText = "Responsável fechamento"
            dtg_Resultados.Columns("Descricao_Fechamento").HeaderText = "Descrição de fechamento"

            dtg_Resultados.Columns("Tempo_Fechamento").HeaderText = "Tempo para fechamento"

            dtg_Resultados.Columns("ID_Registro_Manifestacao").Visible = False

            dtg_Resultados.Columns("Nome_Prioridade").DisplayIndex = 0
            dtg_Resultados.Columns("Nome_Tipo").DisplayIndex = 1
            dtg_Resultados.Columns("Nome_Status").DisplayIndex = 2
            dtg_Resultados.Columns("Data_Abertura").DisplayIndex = 3
            dtg_Resultados.Columns("Pessoa_Abertura").DisplayIndex = 4
            dtg_Resultados.Columns("Descricao_Abertura").DisplayIndex = 5
            dtg_Resultados.Columns("Data_Fechamento").DisplayIndex = 6
            dtg_Resultados.Columns("Pessoa_Fechamento").DisplayIndex = 7
            dtg_Resultados.Columns("Descricao_Fechamento").DisplayIndex = 8
            dtg_Resultados.Columns("Tempo_Fechamento").DisplayIndex = 9

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message + vbNewLine + ex.StackTrace)
        Finally
            Fechar_Conexao_Proreports()
        End Try

    End Sub

    Private Sub dtg_Resultados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Resultados.CellDoubleClick
        Dim dtg_row As DataGridViewRow = dtg_Resultados.Rows(e.RowIndex)
        'get_id_registro_manifestacao = CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtg_row.Cells("ID_Registro_Manifestacao").Value))
        Dim form = New Registro_Manifestacoes
        form.txt_id_registro_manifestacao.Text = CONVERT_TO_STRING(dtg_row.Cells("ID_Registro_Manifestacao").Value)
        form.ShowDialog()
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Prioridade_Click(sender As Object, e As EventArgs) Handles ptb_Prioridade.Click
        For i As Integer = 0 To clb_Prioridade.Items.Count - 1
            clb_Prioridade.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Tipo_Click(sender As Object, e As EventArgs) Handles ptb_Tipo.Click
        For i As Integer = 0 To clb_Tipo.Items.Count - 1
            clb_Tipo.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Status_Click(sender As Object, e As EventArgs) Handles ptb_Status.Click
        For i As Integer = 0 To clb_Status.Items.Count - 1
            clb_Status.SetItemCheckState(i, CheckState.Unchecked)
        Next
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Data_Abertura_Click(sender As Object, e As EventArgs) Handles ptb_Data_Abertura.Click
        dtp_Data_Abertura_De.Checked = False
        dtp_Data_Abertura_Ate.Checked = False
        Executa_Pesquisa()
    End Sub
    Private Sub ptb_Data_Fechamento_Click(sender As Object, e As EventArgs) Handles ptb_Data_Fechamento.Click
        dtp_Data_Fechamento_De.Checked = False
        dtp_Data_Fechamento_Ate.Checked = False
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Pessoa_Abertura_MouseUp(sender As Object, e As MouseEventArgs)
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Pessoa_Fechamento_MouseUp(sender As Object, e As MouseEventArgs)
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Prioridade_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Prioridade.MouseUp
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Tipo_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Tipo.MouseUp
        Executa_Pesquisa()
    End Sub
    Private Sub clb_Status_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Status.MouseUp
        Executa_Pesquisa()
    End Sub

    Private oldData_Abertura_DeChecked = False
    Private oldData_Abertura_AteChecked = False
    Private Sub dtp_Data_Abertura_De_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Abertura_De.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Abertura_Ate_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Abertura_Ate.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Abertura_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Abertura_De.ValueChanged
        If dtp_Data_Abertura_De.Checked <> oldData_Abertura_DeChecked Then
            oldData_Abertura_DeChecked = dtp_Data_Abertura_De.Checked
            Executa_Pesquisa()
        End If
    End Sub

    Private Sub dtp_Data_Abertura_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Abertura_Ate.ValueChanged
        If dtp_Data_Abertura_Ate.Checked <> oldData_Abertura_AteChecked Then
            oldData_Abertura_AteChecked = dtp_Data_Abertura_Ate.Checked
            Executa_Pesquisa()
        End If
    End Sub


    Private oldData_Fechamento_DeChecked = False
    Private oldData_Fechamento_AteChecked = False
    Private Sub dtp_Data_Fechamento_De_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Fechamento_De.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Fechamento_Ate_CloseUp(sender As Object, e As EventArgs) Handles dtp_Data_Fechamento_Ate.CloseUp
        Executa_Pesquisa()
    End Sub
    Private Sub dtp_Data_Fechamento_De_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Fechamento_De.ValueChanged
        If dtp_Data_Fechamento_De.Checked <> oldData_Fechamento_DeChecked Then
            oldData_Fechamento_DeChecked = dtp_Data_Fechamento_De.Checked
            Executa_Pesquisa()
        End If
    End Sub
    Private Sub dtp_Data_Fechamento_Ate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Data_Fechamento_Ate.ValueChanged
        If dtp_Data_Fechamento_Ate.Checked <> oldData_Fechamento_AteChecked Then
            oldData_Fechamento_AteChecked = dtp_Data_Fechamento_Ate.Checked
            Executa_Pesquisa()
        End If
    End Sub
    Private Sub ptb_Prioridade_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Prioridade.MouseMove
        ptb_Prioridade.BackColor = SystemColors.ButtonShadow
    End Sub
    Private Sub ptb_Prioridade_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Prioridade.MouseLeave
        ptb_Prioridade.BackColor = SystemColors.Control
    End Sub
    Private Sub ptb_Tipo_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Tipo.MouseMove
        ptb_Tipo.BackColor = SystemColors.ButtonShadow
    End Sub
    Private Sub ptb_Tipo_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Tipo.MouseLeave
        ptb_Tipo.BackColor = SystemColors.Control
    End Sub
    Private Sub ptb_Status_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Status.MouseMove
        ptb_Status.BackColor = SystemColors.ButtonShadow
    End Sub
    Private Sub ptb_Status_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Status.MouseLeave
        ptb_Status.BackColor = SystemColors.Control
    End Sub
    Private Sub ptb_Data_Abertura_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Data_Abertura.MouseMove
        ptb_Data_Abertura.BackColor = SystemColors.ButtonShadow
    End Sub
    Private Sub ptb_Data_Abertura_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Data_Abertura.MouseLeave
        ptb_Data_Abertura.BackColor = SystemColors.Control
    End Sub
    Private Sub ptb_Data_Fechamento_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Data_Fechamento.MouseMove
        ptb_Data_Fechamento.BackColor = SystemColors.ButtonShadow
    End Sub
    Private Sub ptb_Data_Fechamento_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Data_Fechamento.MouseLeave
        ptb_Data_Fechamento.BackColor = SystemColors.Control
    End Sub
    Private Sub pnl_Prioridade_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Prioridade.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Prioridade.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Tipo_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Tipo.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Tipo.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Status_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Status.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Status.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Data_Abertura_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Data_Abertura.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Data_Abertura.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub
    Private Sub pnl_Data_Fechamento_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Data_Fechamento.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Data_Fechamento.ClientRectangle, SystemColors.ScrollBar, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click

        Dim strarquivoSalvo As String = ""

        Using OFD As New SaveFileDialog With {.FileName = "Requisicoes_SGT_" & Format(Now, "yyyyMMddhhmmss"), .Filter = "Arquivo do Excel (*.xlsx)|*.xlsx"}
            If OFD.ShowDialog = DialogResult.OK Then
                strarquivoSalvo = OFD.FileName
            End If
        End Using

        If String.IsNullOrEmpty(strarquivoSalvo) Then
            Exit Sub
        End If

        Dim elApp As New Microsoft.Office.Interop.Excel.Application()
        Dim elWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim elWorksheet As Microsoft.Office.Interop.Excel.Worksheet

        'Dim elRange As Microsoft.Office.Interop.Excel.Range

        Try

            elApp.Visible = False
            'elApp.Workbooks.Open(WorkbookPath, False, False, Password:=WorkbookPassword)
            elWorkbook = elApp.Workbooks.Add
            elWorksheet = elWorkbook.Worksheets(1)
            elWorksheet.Name = "requisicoes"

            For Each dtg_col As DataGridViewColumn In dtg_Resultados.Columns
                If dtg_col.Visible = True Then
                    elWorksheet.Cells(1, dtg_col.Index + 1).Value = dtg_col.HeaderText
                End If
            Next

            Dim elColumn As Long = 1
            Dim elRow As Long = 2

            For Each dtg_col As DataGridViewColumn In dtg_Resultados.Columns
                If dtg_col.Visible = True Then
                    elWorksheet.Cells(1, elColumn).Value = dtg_col.HeaderText
                    elRow = 2
                    For Each dtb_row As DataGridViewRow In dtg_Resultados.Rows
                        elWorksheet.Cells(elRow, elColumn).Value = dtb_row.Cells(dtg_col.Index).Value
                        elRow = elRow + 1
                    Next
                    elColumn = elColumn + 1
                End If
            Next

            elWorkbook.SaveAs(strarquivoSalvo)

            For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
                wb.Close(False)
            Next

            elApp.Quit()
            releaseObject(elWorksheet)
            elWorksheet = Nothing
            releaseObject(elWorkbook)
            elWorkbook = Nothing
            releaseObject(elApp)
            elApp = Nothing

            MessageBox.Show(text:="Arquivo exportado com sucesso!", caption:="Procedimento concluído", buttons:=vbOKOnly, icon:=vbInformation)

        Catch ex As Exception
            For Each wb As Microsoft.Office.Interop.Excel.Workbook In elApp.Workbooks
                wb.Close(False)
            Next

            elApp.Quit()
            releaseObject(elWorksheet)
            elWorksheet = Nothing
            releaseObject(elWorkbook)
            elWorkbook = Nothing
            releaseObject(elApp)
            elApp = Nothing
        End Try

    End Sub

End Class