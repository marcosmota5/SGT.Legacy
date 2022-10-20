Imports MySql.Data.MySqlClient

Public Class Inicio
    'Private immobiliser As New FormImmobiliser(Me)
    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height

    Private Sub Form1_Resize(ByVal sender As Object,
            ByVal e As System.EventArgs) Handles Me.Resize
        Exit Sub
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        CW = Me.Width
        CH = Me.Height

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If get_id_perfil = 1 Then
            mnui_Parametros.Visible = True
            mnui_Cadastrar_Usuario.Visible = True
            GerenciarUsuáriosToolStripMenuItem.Visible = True
        Else
            mnui_Parametros.Visible = False
            mnui_Cadastrar_Usuario.Visible = False
            GerenciarUsuáriosToolStripMenuItem.Visible = False
        End If

        If get_id_usuario = 1 Then
            SistemaToolStripMenuItem.Visible = True
            CargaDeDadosToolStripMenuItem1.Visible = True
        Else
            SistemaToolStripMenuItem.Visible = False
            CargaDeDadosToolStripMenuItem1.Visible = False
        End If

        Preencher_Filtros()

        Atualiza_Graficos()

        tim_Atualizar.Interval = CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.AutoRefreshDashboardSeconds)) * 1000

        If CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.AutoRefreshDashboard)) = 1 Then
            tim_Atualizar.Enabled = True
        Else
            tim_Atualizar.Enabled = False
        End If

    End Sub

    Sub Atualiza_Graficos()

        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Dim sCondicao As String = ""
        Dim listAnos As String = ""
        Dim listMeses As String = ""
        Dim listClientes As String = ""
        Dim listStatusAprovacao As String = ""
        Dim listJustificativaAprovacao As String = ""
        Dim listUsuarios As String = ""
        Dim listSetores As String = ""
        Dim condTotal As String = ""

        'Verifica Anos selecionados
        If clb_Ano.CheckedItems.Count > 0 Then
            For Each item In clb_Ano.CheckedItems
                If listAnos = "" Then
                    listAnos = item.Item("Num_Ano")
                Else
                    listAnos = listAnos & "," & item.Item("Num_Ano")
                End If
            Next
        End If

        If listAnos <> "" Then
            If sCondicao = "" Then
                sCondicao = "YEAR(prop.data_envio) IN (" & listAnos & ")"
            Else
                sCondicao = sCondicao & " AND " & "YEAR(prop.data_envio) IN (" & listAnos & ")"
            End If
        End If


        'verifica Mes selecionados
        If clb_Mes.CheckedItems.Count > 0 Then
            For Each item In clb_Mes.CheckedItems
                If listMeses = "" Then
                    listMeses = item.item("Num_Mes")
                Else
                    listMeses = listMeses & "," & item.item("Num_Mes")
                End If
            Next
        End If

        If listMeses <> "" Then
            If sCondicao = "" Then
                sCondicao = "MONTH(prop.data_envio) in (" & listMeses & ")"
            Else
                sCondicao = sCondicao & " AND " & "MONTH(prop.data_envio) IN (" & listMeses & ")"
            End If
        End If

        'Verifica clientes selecionados
        If clb_Cliente.CheckedItems.Count > 0 Then
            For Each item In clb_Cliente.CheckedItems
                If listClientes = "" Then
                    listClientes = item.Item("ID_Cliente")
                Else
                    listClientes = listClientes & "," & item.Item("ID_Cliente")
                End If
            Next
        End If

        If listClientes <> "" Then
            If sCondicao = "" Then
                sCondicao = "prop.id_cliente IN (" & listClientes & ")"
            Else
                sCondicao = sCondicao & " AND " & "prop.id_cliente IN (" & listClientes & ")"
            End If
        End If

        'verifica status_aprovacao selecionados
        If clb_Status_Aprovacao.CheckedItems.Count > 0 Then
            For Each item In clb_Status_Aprovacao.CheckedItems
                If listStatusAprovacao = "" Then
                    listStatusAprovacao = item.item("id_Status_Aprovacao")
                Else
                    listStatusAprovacao = listStatusAprovacao & "," & item.item("id_Status_Aprovacao")
                End If
            Next
        End If

        If listStatusAprovacao <> "" Then
            If sCondicao = "" Then
                sCondicao = "itpr.id_status_aprovacao IN (" & listStatusAprovacao & ")"
            Else
                sCondicao = sCondicao & " AND " & "itpr.id_status_aprovacao IN (" & listStatusAprovacao & ")"
            End If
        End If

        'Verifica justificativas de aprovação selecionados
        If clb_Justificativa_Aprovacao.CheckedItems.Count > 0 Then
            For Each item In clb_Justificativa_Aprovacao.CheckedItems
                If listJustificativaAprovacao = "" Then
                    listJustificativaAprovacao = item.Item("ID_Justificativa_Aprovacao")
                Else
                    listJustificativaAprovacao = listJustificativaAprovacao & "," & item.Item("ID_Justificativa_Aprovacao")
                End If
            Next
        End If

        If listJustificativaAprovacao <> "" Then
            If sCondicao = "" Then
                sCondicao = "itpr.id_justificativa_aprovacao IN (" & listJustificativaAprovacao & ")"
            Else
                sCondicao = sCondicao & " AND " & "itpr.id_justificativa_aprovacao IN (" & listJustificativaAprovacao & ")"
            End If
        End If

        'Verifica usuários selecionados
        If clb_Usuario_Filtro.CheckedItems.Count > 0 Then
            For Each item In clb_Usuario_Filtro.CheckedItems
                If listUsuarios = "" Then
                    listUsuarios = item.Item("ID_Usuario")
                Else
                    listUsuarios = listUsuarios & "," & item.Item("ID_Usuario")
                End If
            Next
        End If

        If listUsuarios <> "" Then
            If sCondicao = "" Then
                sCondicao = "prop.id_usuario_insercao IN (" & listUsuarios & ")"
            Else
                sCondicao = sCondicao & " AND " & "prop.id_usuario_insercao IN (" & listUsuarios & ")"
            End If
        End If

        'Verifica usuários selecionados
        If clb_Setor.CheckedItems.Count > 0 Then
            For Each item In clb_Setor.CheckedItems
                If listSetores = "" Then
                    listSetores = item.Item("ID_Setor")
                Else
                    listSetores = listSetores & "," & item.Item("ID_Setor")
                End If
            Next
        End If

        If listSetores <> "" Then
            If sCondicao = "" Then
                sCondicao = "usua.id_setor IN (" & listSetores & ")"
            Else
                sCondicao = sCondicao & " AND " & "usua.id_setor IN (" & listSetores & ")"
            End If
        End If

        Try
            Abrir_Conexao()

            Dim condChart1 As String = ""

            If chb_Considerar_Revisadas.Checked = True Then
                If sCondicao <> "" Then
                    condChart1 = " WHERE prop.data_envio IS NOT NULL AND " & sCondicao
                Else
                    condChart1 = " WHERE prop.data_envio IS NOT NULL "
                End If
            Else
                If sCondicao <> "" Then
                    condChart1 = " WHERE prop.id_ultima_proposta IS NULL AND prop.data_envio IS NOT NULL  AND " & sCondicao
                Else
                    condChart1 = " WHERE prop.id_ultima_proposta IS NULL AND prop.data_envio IS NOT NULL "
                End If
            End If

            '  If sCondicao <> "" Then
            'condChart1 = " AND " & sCondicao
            ' End If

            adapter = New MySqlDataAdapter("SELECT COUNT(DISTINCT(prop.id_proposta)) AS Quantidade_Enviada, CONCAT(DATE_FORMAT(prop.data_envio, '%m'), '-', 
LEFT(CONCAT(UCase(Left(MONTHNAME(prop.data_envio), 1)), LCase(SUBSTRING(MONTHNAME(prop.data_envio), 2))), 3)) AS Mes FROM tb_propostas AS prop LEFT JOIN tb_itens_propostas AS itpr ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart1 & " GROUP BY Mes ORDER BY Mes", strConexao)

            adapter.Fill(ds, "dtsPropostasMes")

            cht_Propostas_Mes.DataSource = ds.Tables("dtsPropostasMes")
            cht_Propostas_Mes.Series(0).XValueMember = "Mes"
            cht_Propostas_Mes.Series(0).YValueMembers = "Quantidade_Enviada"

            cht_Propostas_Mes.DataBind()

            Dim condChart2 As String = ""

            adapter = New MySqlDataAdapter("SELECT COUNT(DISTINCT(itpr.id_proposta)) AS Quantidade_Proposta, st_ap.nome AS Status_Aprovacao FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_status_aprovacao AS st_ap ON itpr.id_status_aprovacao=st_ap.id_status_aprovacao LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart1 & " GROUP BY Status_Aprovacao ORDER BY Status_Aprovacao", strConexao)

            adapter.Fill(ds, "dtsQuantidadeStatus")

            cht_Quantidade_Status.DataSource = ds.Tables("dtsQuantidadeStatus")
            cht_Quantidade_Status.Series(0).XValueMember = "Status_Aprovacao"
            cht_Quantidade_Status.Series(0).YValueMembers = "Quantidade_Proposta"

            cht_Quantidade_Status.DataBind()

            Dim condChart3 As String = ""

            adapter = New MySqlDataAdapter("SELECT SUM(prop.valor_faturamento) AS Valor_Faturamento, CONCAT(DATE_FORMAT(prop.data_envio, '%m'), '-', 
LEFT(CONCAT(UCase(Left(MONTHNAME(prop.data_envio), 1)), LCase(SUBSTRING(MONTHNAME(prop.data_envio), 2))), 3)) AS Mes FROM (SELECT DISTINCT(prop.id_proposta), prop.valor_faturamento, prop.data_envio FROM tb_propostas AS prop LEFT JOIN tb_itens_propostas AS itpr ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart1 & ") AS prop GROUP BY Mes ORDER BY Mes", strConexao)

            adapter.Fill(ds, "dtsFaturamentoMes")

            cht_Faturamento_Mes.DataSource = ds.Tables("dtsFaturamentoMes")
            cht_Faturamento_Mes.Series(0).XValueMember = "Mes"
            cht_Faturamento_Mes.Series(0).YValueMembers = "Valor_Faturamento"

            cht_Faturamento_Mes.DataBind()

            Dim condChart4 As String = ""

            If condChart1 = "" Then
                condChart4 = " WHERE itpr.id_status_aprovacao <> 1 AND itpr.id_status_aprovacao <> 2"
            Else
                condChart4 = condChart1 & " AND itpr.id_status_aprovacao <> 1 AND itpr.id_status_aprovacao <> 2"
            End If

            adapter = New MySqlDataAdapter("SELECT COUNT(DISTINCT(itpr.id_proposta)) AS Quantidade_Proposta, ju_ap.nome AS Justificativa_Aprovacao FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_justificativas_aprovacao AS ju_ap ON itpr.id_justificativa_aprovacao=ju_ap.id_justificativa_aprovacao LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart4 & " GROUP BY Justificativa_Aprovacao ORDER BY Justificativa_Aprovacao", strConexao)

            adapter.Fill(ds, "dtsQuantidadeJustificativa")

            cht_Quantidade_Justificativa.DataSource = ds.Tables("dtsQuantidadeJustificativa")
            cht_Quantidade_Justificativa.Series(0).XValueMember = "Justificativa_Aprovacao"
            cht_Quantidade_Justificativa.Series(0).YValueMembers = "Quantidade_Proposta"

            cht_Quantidade_Justificativa.DataBind()

            Dim condChart5 As String = ""

            adapter = New MySqlDataAdapter("SELECT COUNT(DISTINCT(itpr.id_proposta)) AS Quantidade_Proposta, LEFT(clie.nome, 10) AS Cliente FROM tb_propostas AS prop LEFT JOIN tb_itens_propostas AS itpr ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_clientes AS clie ON prop.id_cliente=clie.id_cliente LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart1 & " GROUP BY Cliente ORDER BY Quantidade_Proposta DESC LIMIT 10", strConexao)

            adapter.Fill(ds, "dtsQuantidadeCliente")

            cht_Quantidade_Cliente.DataSource = ds.Tables("dtsQuantidadeCliente")
            cht_Quantidade_Cliente.Series(0).XValueMember = "Cliente"
            cht_Quantidade_Cliente.Series(0).YValueMembers = "Quantidade_Proposta"

            cht_Quantidade_Cliente.DataBind()

            Dim condChart6 As String = ""

            If condChart1 = "" Then
                condChart6 = " WHERE itpr.id_tipo_item = 1 AND itpr.id_status_aprovacao IN (1,2) AND itpr.descricao_item <> 'CARGA DE DADOS - ITEM NÃO IDENTIFICADO' AND itpr.descricao_item <> 'CARGA DE DADOS - SERVIÇO' "
            Else
                condChart6 = condChart1 & " AND itpr.id_tipo_item = 1 AND itpr.id_status_aprovacao IN (1,2) AND itpr.descricao_item <> 'CARGA DE DADOS - ITEM NÃO IDENTIFICADO' AND itpr.descricao_item <> 'CARGA DE DADOS - SERVIÇO' "
            End If

            adapter = New MySqlDataAdapter("SELECT COUNT(itpr.codigo_item) AS Quantidade_Item, itpr.codigo_item AS Codigo_Item, itpr.descricao_item AS Nome_Item FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart6 & " GROUP BY Nome_Item ORDER BY Quantidade_Item DESC LIMIT 5", strConexao)

            adapter.Fill(ds, "dtsTopPecasAprovadas")

            For Each dtb_row As DataRow In ds.Tables("dtsTopPecasAprovadas").Rows
                dtb_row("Nome_Item") = REMOVE_CODES_IN_DESCRIPTION(dtb_row("Nome_Item").ToString) & " (" & NUMBERS_FROM_STRING(dtb_row("Codigo_Item").ToString) & ")"
            Next

            cht_Top_Itens_Aprovados.DataSource = ds.Tables("dtsTopPecasAprovadas")
            cht_Top_Itens_Aprovados.Series(0).XValueMember = "Nome_Item"
            cht_Top_Itens_Aprovados.Series(0).YValueMembers = "Quantidade_Item"

            cht_Top_Itens_Aprovados.DataBind()

            Dim condChart7 As String = ""

            If condChart1 = "" Then
                condChart7 = " WHERE itpr.id_tipo_item = 1 AND itpr.id_status_aprovacao = 4 AND itpr.descricao_item <> 'CARGA DE DADOS - ITEM NÃO IDENTIFICADO' AND itpr.descricao_item <> 'CARGA DE DADOS - SERVIÇO' "
            Else
                condChart7 = condChart1 & " AND itpr.id_tipo_item = 1 AND itpr.id_status_aprovacao = 4 AND itpr.descricao_item <> 'CARGA DE DADOS - ITEM NÃO IDENTIFICADO' AND itpr.descricao_item <> 'CARGA DE DADOS - SERVIÇO' "
            End If

            adapter = New MySqlDataAdapter("SELECT COUNT(itpr.codigo_item) AS Quantidade_Item, itpr.codigo_item AS Codigo_Item, itpr.descricao_item AS Nome_Item FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart7 & " GROUP BY Nome_Item ORDER BY Quantidade_Item DESC LIMIT 5", strConexao)

            adapter.Fill(ds, "dtsTopPecasNaoAprovadas")

            For Each dtb_row As DataRow In ds.Tables("dtsTopPecasNaoAprovadas").Rows
                dtb_row("Nome_Item") = REMOVE_CODES_IN_DESCRIPTION(dtb_row("Nome_Item").ToString) & " (" & NUMBERS_FROM_STRING(dtb_row("Codigo_Item").ToString) & ")"
            Next

            cht_Top_Itens_Nao_Aprovados.DataSource = ds.Tables("dtsTopPecasNaoAprovadas")
            cht_Top_Itens_Nao_Aprovados.Series(0).XValueMember = "Nome_Item"
            cht_Top_Itens_Nao_Aprovados.Series(0).YValueMembers = "Quantidade_Item"

            cht_Top_Itens_Nao_Aprovados.DataBind()

            adapter = New MySqlDataAdapter("SELECT prop.data_solicitacao AS Data_Solicitacao, prop.data_envio AS Data_Envio FROM tb_propostas AS prop LEFT JOIN tb_itens_propostas AS itpr ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart1, strConexao)

            adapter.Fill(ds, "dtsTempoResposta")

            Dim dtbCol As DataColumn
            Dim duration As TimeSpan
            Dim drow As DataRow

            dtbCol = ds.Tables("dtsTempoResposta").Columns.Add("Tempo_Resposta", GetType(Decimal))

            For Each drow In ds.Tables("dtsTempoResposta").Rows
                If Not String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Solicitacao"))) Then
                    If String.IsNullOrEmpty(CONVERT_TO_STRING(drow("Data_Envio"))) Then
                        duration = CONVERT_TO_DATE(Now) - CONVERT_TO_DATE(drow("Data_Solicitacao"))
                    Else
                        duration = CONVERT_TO_DATE(drow("Data_Envio")) - CONVERT_TO_DATE(drow("Data_Solicitacao"))
                    End If
                    drow("Tempo_Resposta") = CONVERT_TO_DECIMAL(duration.TotalSeconds.ToString) ' duration.ToString("%d") & " dia(s) e " & duration.ToString("hh\:mm")
                End If
            Next

            Dim durationavg As TimeSpan = TimeSpan.FromSeconds(CONVERT_TO_DOUBLE(Trim(CONVERT_TO_STRING(ds.Tables("dtsTempoResposta").Compute("Avg(Tempo_Resposta)", "")))))
            lbl_Tempo_Resposta_Valor.Text = durationavg.ToString("%d") & " dia(s) e " & duration.ToString("hh\:mm")


            adapter = New MySqlDataAdapter("SELECT itpr.id_status_aprovacao AS Status FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario " & condChart1, strConexao)

            adapter.Fill(ds, "dtsTaxaConversao")

            Dim percentual As Decimal = DIVIDE(CONVERT_TO_DECIMAL(ds.Tables("dtsTaxaConversao").Compute("Count(Status)", "Status = 1 OR Status = 2")), CONVERT_TO_DECIMAL(ds.Tables("dtsTaxaConversao").Compute("Count(Status)", "")))

            lbl_Taxa_Conversao_Valor.Text = percentual.ToString("0%")

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

        stsi_Informacao_Atualizacao.Text = " |  Atualizado em " & Now

    End Sub

    Sub Preencher_Filtros()

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            'Preenche a listbox de ano de solicitação
            adapter = New MySqlDataAdapter("SELECT DISTINCT YEAR(data_envio) AS Num_Ano FROM tb_propostas WHERE data_envio IS NOT NULL ORDER BY Num_Ano DESC", strConexao)

            adapter.Fill(ds, "clb_Ano")
            clb_Ano.DataSource = ds.Tables("clb_Ano")
            clb_Ano.DisplayMember = "Num_Ano"
            clb_Ano.ValueMember = "Num_Ano"

            'Preenche a listbox de mês de solicitação
            ' adapter = New MySqlDataAdapter("SET lc_time_names = 'pt_BR';SELECT DISTINCT MONTHNAME(data_solicitacao) AS Month FROM tb_propostas", strConexao)
            adapter = New MySqlDataAdapter("SET lc_time_names = 'pt_BR';SELECT DISTINCT MONTH(data_envio) AS Num_Mes, CONCAT(UCase(SUBSTRING(MONTHNAME(data_envio), 1, 1)), LOWER(SUBSTRING(MONTHNAME(data_envio), 2))) AS Nome_Mes FROM tb_propostas WHERE data_envio IS NOT NULL ORDER BY Num_Mes", strConexao)

            adapter.Fill(ds, "clb_Mes")
            clb_Mes.DataSource = ds.Tables("clb_Mes")
            clb_Mes.DisplayMember = "Nome_Mes"
            clb_Mes.ValueMember = "Num_Mes"

            'Preenche a listbox de cliente
            adapter = New MySqlDataAdapter("SELECT DISTINCT prop.id_cliente AS ID_Cliente, clie.nome AS Nome_Cliente FROM tb_propostas AS prop LEFT JOIN tb_clientes AS clie ON prop.id_cliente=clie.id_cliente WHERE prop.data_envio IS NOT NULL ORDER BY Nome_Cliente ASC", strConexao)

            adapter.Fill(ds, "clb_Cliente")
            clb_Cliente.DataSource = ds.Tables("clb_Cliente")
            clb_Cliente.DisplayMember = "Nome_Cliente"
            clb_Cliente.ValueMember = "ID_Cliente"

            'Preenche a listbox de status de aprovação
            adapter = New MySqlDataAdapter("SELECT DISTINCT itpr.id_status_aprovacao AS ID_Status_Aprovacao, st_ap.nome AS Nome_Status_Aprovacao FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON itpr.id_proposta = prop.id_proposta LEFT JOIN tb_status_aprovacao AS st_ap ON itpr.id_status_aprovacao=st_ap.id_status_aprovacao WHERE prop.data_envio IS NOT NULL ORDER BY Nome_Status_Aprovacao ASC", strConexao)

            adapter.Fill(ds, "clb_Status_Aprovacao")
            clb_Status_Aprovacao.DataSource = ds.Tables("clb_Status_Aprovacao")
            clb_Status_Aprovacao.DisplayMember = "Nome_Status_Aprovacao"
            clb_Status_Aprovacao.ValueMember = "ID_Status_Aprovacao"

            'Preenche a listbox de justificativa de aprovação
            adapter = New MySqlDataAdapter("SELECT DISTINCT itpr.id_justificativa_aprovacao AS ID_Justificativa_Aprovacao, ju_ap.nome AS Nome_Justificativa_Aprovacao FROM tb_itens_propostas AS itpr LEFT JOIN tb_propostas AS prop ON itpr.id_proposta = prop.id_proposta LEFT JOIN tb_justificativas_aprovacao AS ju_ap ON itpr.id_justificativa_aprovacao=ju_ap.id_justificativa_aprovacao WHERE prop.data_envio IS NOT NULL ORDER BY Nome_Justificativa_Aprovacao ASC", strConexao)

            adapter.Fill(ds, "clb_Justificativa_Aprovacao")
            clb_Justificativa_Aprovacao.DataSource = ds.Tables("clb_Justificativa_Aprovacao")
            clb_Justificativa_Aprovacao.DisplayMember = "Nome_Justificativa_Aprovacao"
            clb_Justificativa_Aprovacao.ValueMember = "ID_Justificativa_Aprovacao"

            'Preenche a listbox de usuários
            adapter = New MySqlDataAdapter("SELECT DISTINCT prop.id_usuario_insercao AS ID_Usuario, usua.nome AS Nome_Usuario FROM tb_propostas AS prop LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario WHERE prop.data_envio IS NOT NULL ORDER BY Nome_Usuario ASC", strConexao)

            adapter.Fill(ds, "clb_Usuario_Filtro")
            clb_Usuario_Filtro.DataSource = ds.Tables("clb_Usuario_Filtro")

            For Each dtb_row As DataRow In ds.Tables("clb_Usuario_Filtro").Rows
                dtb_row("Nome_Usuario") = GET_WORD(dtb_row("Nome_Usuario"), " ", Part_Word_Text.First_Last_Word)
            Next

            clb_Usuario_Filtro.DisplayMember = "Nome_Usuario"
            clb_Usuario_Filtro.ValueMember = "ID_Usuario"

            'Preenche a listbox de setores
            adapter = New MySqlDataAdapter("SELECT DISTINCT usua.id_setor AS ID_Setor, seto.nome AS Nome_Setor FROM tb_propostas AS prop LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario LEFT JOIN tb_setores AS seto ON usua.id_setor=seto.id_setor WHERE prop.data_envio IS NOT NULL ORDER BY Nome_Setor ASC", strConexao)

            adapter.Fill(ds, "clb_Setor")
            clb_Setor.DataSource = ds.Tables("clb_Setor")

            clb_Setor.DisplayMember = "Nome_Setor"
            clb_Setor.ValueMember = "ID_Setor"


        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try
    End Sub


    'Private Sub mnui_Sair_Click(sender As Object, e As EventArgs) Handles mnui_Sair.Click
    '    If MessageBox.Show("Tem certeza que deseja sair do sistema?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        Application.Exit()
    '    End If
    'End Sub

    Private Sub clb_Ano_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Ano.MouseUp
        Atualiza_Graficos()
    End Sub
    Private Sub clb_Mes_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Mes.MouseUp
        Atualiza_Graficos()
    End Sub

    Private Sub clb_Status_Aprovacao_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Status_Aprovacao.MouseUp
        Atualiza_Graficos()
    End Sub

    Private Sub clb_Justificativa_Aprovacao_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Justificativa_Aprovacao.MouseUp
        Atualiza_Graficos()
    End Sub
    Private Sub clb_Status_Envio_MouseUp(sender As Object, e As MouseEventArgs)
        Atualiza_Graficos()
    End Sub
    Private Sub clb_Usuario_Filtro_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Usuario_Filtro.MouseUp
        Atualiza_Graficos()
    End Sub
    Private Sub clb_Setor_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Setor.MouseUp
        Atualiza_Graficos()
    End Sub
    Private Sub clb_Cliente_MouseUp(sender As Object, e As MouseEventArgs) Handles clb_Cliente.MouseUp
        Atualiza_Graficos()
    End Sub


    Private Sub ptb_Ano_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Ano.MouseMove
        ptb_Ano.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Ano_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Ano.MouseLeave
        ptb_Ano.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Mes_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Mes.MouseMove
        ptb_Mes.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Mes_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Mes.MouseLeave
        ptb_Mes.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Cliente_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Cliente.MouseMove
        ptb_Cliente.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Cliente_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Cliente.MouseLeave
        ptb_Cliente.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Status_Aprovacao_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Status_Aprovacao.MouseMove
        ptb_Status_Aprovacao.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Status_Aprovacao_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Status_Aprovacao.MouseLeave
        ptb_Status_Aprovacao.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Justificativa_Aprovacao_MouseMove(sender As Object, e As MouseEventArgs) Handles ptb_Justificativa_Aprovacao.MouseMove
        ptb_Justificativa_Aprovacao.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Justificativa_Aprovacao_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Justificativa_Aprovacao.MouseLeave
        ptb_Justificativa_Aprovacao.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Usuario_Filtro_mousemove(sender As Object, e As MouseEventArgs) Handles ptb_Usuario_Filtro.MouseMove
        ptb_Usuario_Filtro.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Usuario_Filtro_mouseleave(sender As Object, e As EventArgs) Handles ptb_Usuario_Filtro.MouseLeave
        ptb_Usuario_Filtro.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Setor_Filtro_mousemove(sender As Object, e As MouseEventArgs) Handles ptb_Setor.MouseMove
        ptb_Setor.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ptb_Setor_mouseleave(sender As Object, e As EventArgs) Handles ptb_Setor.MouseLeave
        ptb_Setor.BackColor = SystemColors.Control
    End Sub

    Private Sub ptb_Ano_Click(sender As Object, e As EventArgs) Handles ptb_Ano.Click
        If clb_Ano.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Ano.CheckedIndices
                'item.Checked = False
                clb_Ano.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub
    Private Sub ptb_Mes_Click(sender As Object, e As EventArgs) Handles ptb_Mes.Click
        If clb_Mes.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Mes.CheckedIndices
                'item.Checked = False
                clb_Mes.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub

    Private Sub ptb_Cliente_Click(sender As Object, e As EventArgs) Handles ptb_Cliente.Click
        If clb_Cliente.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Cliente.CheckedIndices
                'item.Checked = False
                clb_Cliente.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub

    Private Sub ptb_Status_Aprovacao_Click(sender As Object, e As EventArgs) Handles ptb_Status_Aprovacao.Click
        If clb_Status_Aprovacao.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Status_Aprovacao.CheckedIndices
                'item.Checked = False
                clb_Status_Aprovacao.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub

    Private Sub ptb_Justificativa_Aprovacao_Click(sender As Object, e As EventArgs) Handles ptb_Justificativa_Aprovacao.Click
        If clb_Justificativa_Aprovacao.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Justificativa_Aprovacao.CheckedIndices
                'item.Checked = False
                clb_Justificativa_Aprovacao.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub

    Private Sub ptb_Usuario_Filtro_Click(sender As Object, e As EventArgs) Handles ptb_Usuario_Filtro.Click
        If clb_Usuario_Filtro.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Usuario_Filtro.CheckedIndices
                'item.Checked = False
                clb_Usuario_Filtro.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub

    Private Sub ptb_Setor_Click(sender As Object, e As EventArgs) Handles ptb_Setor.Click
        If clb_Setor.CheckedItems.Count > 0 Then

            For Each i As Integer In clb_Setor.CheckedIndices
                'item.Checked = False
                clb_Setor.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        Atualiza_Graficos()
    End Sub
    Private Sub OpçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpçõesToolStripMenuItem.Click
        Dim form = New Opcoes
        form.ShowDialog()

        tim_Atualizar.Interval = CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.AutoRefreshDashboardSeconds)) * 1000

        If CONVERT_TO_INTEGER(GET_REGISTRY_VALUE(Registry_Values.AutoRefreshDashboard)) = 1 Then
            tim_Atualizar.Enabled = True
        Else
            tim_Atualizar.Enabled = False
        End If

    End Sub

    Private Sub tim_Atualizar_Tick(sender As Object, e As EventArgs) Handles tim_Atualizar.Tick
        Atualiza_Graficos()
    End Sub

    Private Sub RegistroDeAlteraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeAlteraçõesToolStripMenuItem.Click
        Dim form = New Registro_Alteracoes
        form.ShowDialog()
    End Sub

    Private Sub AtualizarDashboardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtualizarDashboardToolStripMenuItem1.Click
        Atualiza_Graficos()
    End Sub

    Private Sub EnviarNotificacaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarNotificacaoToolStripMenuItem.Click
        Dim form = New Enviar_Notificacao
        form.ShowDialog()
    End Sub

    Private Sub chb_Considerar_Revisadas_CheckedChanged(sender As Object, e As EventArgs) Handles chb_Considerar_Revisadas.CheckedChanged
        Atualiza_Graficos()
    End Sub

    Private Sub InserirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserirToolStripMenuItem.Click
        Dim form = New Proposta
        get_id_proposta = 0
        form.ShowDialog()
    End Sub

    Private Sub Inicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnui_Cadastrar_Usuario.Click
        Dim form = New Cadastrar_Usuario
        form.ShowDialog()
    End Sub
    Private Sub mnui_Alterar_Senha_Click(sender As Object, e As EventArgs) Handles mnui_Alterar_Senha.Click
        Dim form = New Alterar_Senha
        form.ShowDialog()
    End Sub
    Private Sub AlterarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarUsuárioToolStripMenuItem.Click
        Dim form = New Entrar
        form.ShowDialog()
        'form.Show()
    End Sub

    Private Sub PesquisaAvançadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisaAvançadaToolStripMenuItem.Click
        Dim form = New Pesquisa_Proposta_Avancada
        form.ShowDialog()
    End Sub

    Private Sub PesquisaBásicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisaBásicaToolStripMenuItem.Click
        Dim form = New Pesquisa_Proposta_Padrao
        form.ShowDialog()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilToolStripMenuItem.Click
        Dim form = New Perfil
        form.ShowDialog()
    End Sub

    Private Sub GerenciarUsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarUsuáriosToolStripMenuItem.Click
        Dim form = New Gerenciar_Usuarios
        form.ShowDialog()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Dim form = New Sobre
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim form = New Clientes
        form.ShowDialog()
    End Sub

    Private Sub ContatosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContatosToolStripMenuItem1.Click
        Dim form = New Contatos
        form.ShowDialog()
    End Sub

    Private Sub StatusDaAprovaçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StatusDaAprovaçãoToolStripMenuItem1.Click
        Dim form = New Status_Aprovacao
        form.ShowDialog()
    End Sub

    Private Sub JustificativasDaAprovaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JustificativasDaAprovaçãoToolStripMenuItem.Click
        Dim form = New Justificativas_Aprovacao
        form.ShowDialog()
    End Sub

    Private Sub TermosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TermosToolStripMenuItem1.Click
        Dim form = New Termos
        form.ShowDialog()
    End Sub
    Private Sub TaxasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TaxasToolStripMenuItem1.Click
        Dim form = New Taxas
        form.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        Dim form = New Fornecedores
        form.ShowDialog()
    End Sub

    Private Sub FabricantesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FabricantesToolStripMenuItem1.Click
        Dim form = New Fabricantes
        form.ShowDialog()
    End Sub

    Private Sub CargaDeDadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargaDeDadosToolStripMenuItem1.Click
        Dim form = New Senha_Carga_Dados
        form.ShowDialog()
    End Sub

    Private Sub TiposDeEquipamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TiposDeEquipamentosToolStripMenuItem1.Click
        Dim form = New Tipos_Equipamentos
        form.ShowDialog()
    End Sub

    Private Sub ModelosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModelosToolStripMenuItem1.Click
        Dim form = New Modelos
        form.ShowDialog()
    End Sub

    Private Sub FamíliasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FamíliasToolStripMenuItem1.Click
        Dim form = New Familias
        form.ShowDialog()
    End Sub

    Private Sub AnosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnosToolStripMenuItem1.Click
        Dim form = New Anos
        form.ShowDialog()
    End Sub

    Private Sub SériesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SériesToolStripMenuItem1.Click
        Dim form = New Series
        form.ShowDialog()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        Dim form = New Empresas
        form.ShowDialog()
    End Sub

    Private Sub SetoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetoresToolStripMenuItem1.Click
        Dim form = New Setores
        form.ShowDialog()
    End Sub

    Private Sub FiliaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiliaisToolStripMenuItem.Click
        Dim form = New Filiais
        form.ShowDialog()
    End Sub

    Private Sub ConjuntosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConjuntosToolStripMenuItem.Click
        Dim form = New Conjuntos
        form.ShowDialog()
    End Sub

    Private Sub EspecificaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecificaçõesToolStripMenuItem.Click
        Dim form = New Especificacoes
        form.ShowDialog()
    End Sub

    Private Sub ManifestaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManifestaçõesToolStripMenuItem.Click

    End Sub

    Private Sub InserirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InserirToolStripMenuItem2.Click
        Dim form = New Registro_Manifestacoes
        form.txt_id_registro_manifestacao.Text = ""
        form.ShowDialog()
    End Sub

    Private Sub PesquisarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PesquisarToolStripMenuItem2.Click
        Dim form = New Pesquisa_Manifestacao
        form.ShowDialog()
    End Sub

    Private Sub MapeamentoDeColunasImportaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapeamentoDeColunasImportaçãoToolStripMenuItem.Click
        Dim form = New Colunas_Importacao
        form.ShowDialog()
    End Sub
End Class