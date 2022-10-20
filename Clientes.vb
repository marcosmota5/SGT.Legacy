Imports MySql.Data.MySqlClient
Public Class Clientes

    Private Sub Carregar_Clientes()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT clie.id_cliente, clie.nome, 
            clie.considerar_percentuais_tabela_kion, clie.percentual_tabela_kion_1, clie.percentual_tabela_kion_2, clie.percentual_tabela_kion_3, 
            clie.considerar_acrescimo_especifico, percentual_acrescimo_especifico, clie.id_status, stat.nome FROM tb_clientes AS clie 
            LEFT JOIN tb_status AS stat ON clie.id_status = stat.id_status ORDER BY clie.nome", strConexao)

            adapter.Fill(dtb)
            dtg_Itens.DataSource = dtb

            Formatar_Datagrid()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Formatar_Datagrid()

        dtg_Itens.Columns("id_cliente").HeaderText = "ID do Cliente"
        dtg_Itens.Columns("nome").HeaderText = "Cliente"
        dtg_Itens.Columns("considerar_percentuais_tabela_kion").HeaderText = "Key Account"
        dtg_Itens.Columns("percentual_tabela_kion_1").HeaderText = "Divide por"
        dtg_Itens.Columns("percentual_tabela_kion_2").HeaderText = "Multiplica por"
        dtg_Itens.Columns("percentual_tabela_kion_3").HeaderText = "Divide por"
        dtg_Itens.Columns("considerar_acrescimo_especifico").HeaderText = "Considera acréscimo"
        dtg_Itens.Columns("percentual_acrescimo_especifico").HeaderText = "% Acréscimo"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("nome1").HeaderText = "Status"

        dtg_Itens.Columns("id_cliente").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("considerar_percentuais_tabela_kion").Visible = True
        dtg_Itens.Columns("percentual_tabela_kion_1").Visible = True
        dtg_Itens.Columns("percentual_tabela_kion_2").Visible = True
        dtg_Itens.Columns("percentual_tabela_kion_3").Visible = True
        dtg_Itens.Columns("considerar_acrescimo_especifico").Visible = True
        dtg_Itens.Columns("percentual_acrescimo_especifico").Visible = True
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("nome1").Visible = True

        dtg_Itens.Columns("percentual_tabela_kion_1").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_tabela_kion_2").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_tabela_kion_3").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_acrescimo_especifico").DefaultCellStyle.Format = "0.00%"

        dtg_Itens.Columns("considerar_acrescimo_especifico").DisplayIndex = 4
        dtg_Itens.Columns("percentual_acrescimo_especifico").DisplayIndex = 5

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Clientes()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        dtg_Itens.Enabled = True
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        chb_Acrescimo.Enabled = False
        nud_Acrescimo.Enabled = False

        chb_Considera_Percentuais.Enabled = False
        nud_Percentual_1.Enabled = False
        nud_Percentual_2.Enabled = False
        nud_Percentual_3.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 562

        txt_id_cliente.Text = ""
        txt_Nome.Text = ""
        cbo_Status.SelectedValue = -1

    End Sub
    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True

        chb_Acrescimo.Enabled = True
        nud_Acrescimo.Enabled = False

        chb_Considera_Percentuais.Enabled = True
        nud_Percentual_1.Enabled = False
        nud_Percentual_2.Enabled = False
        nud_Percentual_3.Enabled = False

        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 589

        txt_id_cliente.Text = ""
        txt_Nome.Text = ""
        cbo_Status.SelectedValue = -1
        chb_Acrescimo.Checked = False
        nud_Acrescimo.Value = 0
        chb_Considera_Percentuais.Checked = False
        nud_Percentual_1.Value = 0
        nud_Percentual_2.Value = 0
        nud_Percentual_3.Value = 0

        txt_Nome.Focus()

    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_cliente.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True

        chb_Acrescimo.Enabled = True
        If chb_Acrescimo.Checked = True Then
            nud_Acrescimo.Enabled = True
        Else
            nud_Acrescimo.Enabled = False
        End If

        chb_Considera_Percentuais.Enabled = True
        If chb_Considera_Percentuais.Checked = True Then
            nud_Percentual_1.Enabled = True
            nud_Percentual_2.Enabled = True
            nud_Percentual_3.Enabled = True
        Else
            nud_Percentual_1.Enabled = False
            nud_Percentual_2.Enabled = False
            nud_Percentual_3.Enabled = False
        End If

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 589

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_cliente.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o cliente " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_cliente", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_cliente", CInt(txt_id_cliente.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O cliente '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Cliente '" & txt_Nome.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Clientes()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False

            chb_Acrescimo.Enabled = False
            nud_Acrescimo.Enabled = False

            chb_Considera_Percentuais.Enabled = False
            nud_Percentual_1.Enabled = False
            nud_Percentual_2.Enabled = False
            nud_Percentual_3.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            Me.Height = 562

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False

        chb_Acrescimo.Enabled = False
        nud_Acrescimo.Enabled = False

        chb_Considera_Percentuais.Enabled = False
        nud_Percentual_1.Enabled = False
        nud_Percentual_2.Enabled = False
        nud_Percentual_3.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 562

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_cliente.Text = ""
            txt_Nome.Text = ""
            cbo_Status.SelectedValue = 1

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_cliente", "id_cliente = " & txt_id_cliente.Text, Limite:="1")) Or
           String.IsNullOrEmpty(GET_DATA_MYSQL("tb_contatos", "id_cliente", "id_cliente = " & txt_id_cliente.Text, Limite:="1")) Or
           String.IsNullOrEmpty(GET_DATA_MYSQL("tb_series", "id_cliente", "id_cliente = " & txt_id_cliente.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem propostas, séries ou contatos cadastrados com esse cliente. Portanto, não será possível excluí-lo"
            End If

        End If

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
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then
                sqlcmd = New MySqlCommand("sp_inserir_cliente", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_considerar_percentuais_tabela_kion", chb_Considera_Percentuais.Checked)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_1", CONVERT_TO_DECIMAL(nud_Percentual_1.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_2", CONVERT_TO_DECIMAL(nud_Percentual_2.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_3", CONVERT_TO_DECIMAL(nud_Percentual_3.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_considerar_acrescimo_especifico", chb_Acrescimo.Checked)
                sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_especifico", CONVERT_TO_DECIMAL(nud_Acrescimo.Value) / 100)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O cliente '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cliente '" & txt_Nome.Text & "' inserido com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_cliente.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_cliente", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_cliente", CONVERT_TO_INTEGER(txt_id_cliente.Text))
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_considerar_percentuais_tabela_kion", chb_Considera_Percentuais.Checked)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_1", CONVERT_TO_DECIMAL(nud_Percentual_1.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_2", CONVERT_TO_DECIMAL(nud_Percentual_2.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_tabela_kion_3", CONVERT_TO_DECIMAL(nud_Percentual_3.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_considerar_acrescimo_especifico", chb_Acrescimo.Checked)
                sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_especifico", CONVERT_TO_DECIMAL(nud_Acrescimo.Value) / 100)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("O cliente '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cliente '" & txt_Nome.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


            Carregar_Clientes()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False

            chb_Acrescimo.Enabled = False
            nud_Acrescimo.Enabled = False

            chb_Considera_Percentuais.Enabled = False
            nud_Percentual_1.Enabled = False
            nud_Percentual_2.Enabled = False
            nud_Percentual_3.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False
            Me.Height = 562

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub txt_Nome_TextChanged(sender As Object, e As EventArgs) Handles txt_Nome.TextChanged
        If txt_Nome.Text = "" Then
            lbl_Nome.ForeColor = Color.Red
        Else
            lbl_Nome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cbo_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged
        If cbo_Status.Text = "" Then
            lbl_Status.ForeColor = Color.Red
        Else
            lbl_Status.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Clientes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub


    Private Sub chb_Considera_Percentuais_Click(sender As Object, e As EventArgs) Handles chb_Considera_Percentuais.Click
        If chb_Considera_Percentuais.Checked = True Then
            nud_Percentual_1.Enabled = True
            nud_Percentual_2.Enabled = True
            nud_Percentual_3.Enabled = True
        Else
            nud_Percentual_1.Enabled = False
            nud_Percentual_2.Enabled = False
            nud_Percentual_3.Enabled = False
        End If
    End Sub

    Private Sub chb_Acrescimo_Click(sender As Object, e As EventArgs) Handles chb_Acrescimo.Click
        If chb_Acrescimo.Checked = True Then
            nud_Acrescimo.Enabled = True
        Else
            nud_Acrescimo.Enabled = False
        End If
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_cliente.Text = dtg_Itens.CurrentRow.Cells("id_cliente").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value

        chb_Acrescimo.Checked = dtg_Itens.CurrentRow.Cells("considerar_acrescimo_especifico").Value
        nud_Acrescimo.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_acrescimo_especifico").Value) * 100

        chb_Considera_Percentuais.Checked = dtg_Itens.CurrentRow.Cells("considerar_percentuais_tabela_kion").Value
        nud_Percentual_1.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_tabela_kion_1").Value) * 100
        nud_Percentual_2.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_tabela_kion_2").Value) * 100
        nud_Percentual_3.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_tabela_kion_3").Value) * 100

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True

        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_cliente", "id_cliente = " & txt_id_cliente.Text, Limite:="1")) Or
           String.IsNullOrEmpty(GET_DATA_MYSQL("tb_contatos", "id_cliente", "id_cliente = " & txt_id_cliente.Text, Limite:="1")) Or
           String.IsNullOrEmpty(GET_DATA_MYSQL("tb_series", "id_cliente", "id_cliente = " & txt_id_cliente.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem propostas, séries ou contatos cadastrados com esse cliente. Portanto, não será possível excluí-lo"
        End If
    End Sub
End Class