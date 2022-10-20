Imports MySql.Data.MySqlClient
Public Class Modelos
    Private Sub Carregar_Modelos()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT mode.id_modelo, mode.nome, mode.id_status, mode.id_fabricante, mode.id_tipo_equipamento, stat.nome AS Nome_Status, fabr.nome AS Nome_Fabricante, tieq.nome AS Nome_Tipo_Equipamento FROM tb_modelos AS mode 
                                               LEFT JOIN tb_status AS stat ON mode.id_status = stat.id_status              
                                               LEFT JOIN tb_fabricantes AS fabr ON mode.id_fabricante = fabr.id_fabricante 
                                               LEFT JOIN tb_tipos_equipamento AS tieq ON mode.id_tipo_equipamento = tieq.id_tipo_equipamento ORDER BY mode.nome", strConexao)

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

        dtg_Itens.Columns("id_modelo").HeaderText = "ID do Modelo"
        dtg_Itens.Columns("nome").HeaderText = "Modelo"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("id_fabricante").HeaderText = "ID do Fabricante"
        dtg_Itens.Columns("id_tipo_equipamento").HeaderText = "ID do Tipo de Equipamento"
        dtg_Itens.Columns("Nome_Status").HeaderText = "Status"
        dtg_Itens.Columns("Nome_Fabricante").HeaderText = "Fabricante"
        dtg_Itens.Columns("Nome_Tipo_Equipamento").HeaderText = "Tipo de Equipamento"

        dtg_Itens.Columns("id_modelo").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("id_fabricante").Visible = False
        dtg_Itens.Columns("id_tipo_equipamento").Visible = False
        dtg_Itens.Columns("Nome_Status").Visible = True
        dtg_Itens.Columns("Nome_Fabricante").Visible = True
        dtg_Itens.Columns("Nome_Tipo_Equipamento").Visible = True

    End Sub

    Private Sub Modelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Modelos()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Tipo_Equipamento, "tb_tipos_equipamento", "id_tipo_equipamento", "nome", "id_tipo_equipamento, nome", ordenar_por:="nome")

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False

        lbl_Fabricante.Enabled = False
        cbo_Fabricante.Enabled = False
        lbl_Tipo_Equipamento.Enabled = False
        cbo_Tipo_Equipamento.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 526

        txt_id_modelo.Text = ""
        txt_Nome.Text = ""
        cbo_Status.SelectedValue = -1
        cbo_Fabricante.SelectedValue = -1
        cbo_Tipo_Equipamento.SelectedValue = -1

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True

        lbl_Fabricante.Enabled = True
        cbo_Fabricante.Enabled = True
        lbl_Tipo_Equipamento.Enabled = True
        cbo_Tipo_Equipamento.Enabled = True

        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 552

        txt_id_modelo.Text = ""
        txt_Nome.Text = ""
        cbo_Status.SelectedValue = -1
        cbo_Fabricante.SelectedValue = -1
        cbo_Tipo_Equipamento.SelectedValue = -1
        txt_Nome.Focus()
    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_modelo.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True

        lbl_Fabricante.Enabled = True
        cbo_Fabricante.Enabled = True
        lbl_Tipo_Equipamento.Enabled = True
        cbo_Tipo_Equipamento.Enabled = True

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 552

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_modelo.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o modelo " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_modelo", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_modelo", CONVERT_TO_INTEGER(txt_id_modelo.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O modelo '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Modelo '" & txt_Nome.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Modelos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Tipo_Equipamento, "tb_tipos_equipamento", "id_tipo_equipamento", "nome", "id_tipo_equipamento, nome", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False

            lbl_Fabricante.Enabled = False
            cbo_Fabricante.Enabled = False
            lbl_Tipo_Equipamento.Enabled = False
            cbo_Tipo_Equipamento.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            Me.Height = 526

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

        lbl_Fabricante.Enabled = False
        cbo_Fabricante.Enabled = False
        lbl_Tipo_Equipamento.Enabled = False
        cbo_Tipo_Equipamento.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 526

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_modelo.Text = ""
            txt_Nome.Text = ""
            cbo_Status.SelectedValue = -1
            cbo_Fabricante.SelectedValue = -1
            cbo_Tipo_Equipamento.SelectedValue = -1

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_modelo", "id_modelo = " & txt_id_modelo.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem propostas cadastradas com esse modelo. Portanto, não será possível excluí-lo"
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

        If cbo_Fabricante.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Fabricante.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Fabricante.Text
            End If
            lbl_Fabricante.ForeColor = Color.Red
        Else
            lbl_Fabricante.ForeColor = Color.Black
        End If

        If cbo_Tipo_Equipamento.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Tipo_Equipamento.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Tipo_Equipamento.Text
            End If
            lbl_Tipo_Equipamento.ForeColor = Color.Red
        Else
            lbl_Tipo_Equipamento.ForeColor = Color.Black
        End If

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then
                sqlcmd = New MySqlCommand("sp_inserir_modelo", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_fabricante", cbo_Fabricante.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_tipo_equipamento", cbo_Tipo_Equipamento.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O modelo '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Modelo '" & txt_Nome.Text & "' inserido com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_modelo.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_modelo", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_modelo", CONVERT_TO_INTEGER(txt_id_modelo.Text))
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_fabricante", cbo_Fabricante.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_tipo_equipamento", cbo_Tipo_Equipamento.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("O modelo '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Modelo '" & txt_Nome.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            Carregar_Modelos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Tipo_Equipamento, "tb_tipos_equipamento", "id_tipo_equipamento", "nome", "id_tipo_equipamento, nome", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False

            lbl_Fabricante.Enabled = False
            cbo_Fabricante.Enabled = False
            lbl_Tipo_Equipamento.Enabled = False
            cbo_Tipo_Equipamento.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False
            Me.Height = 526

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

    Private Sub cbo_Fabricante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Fabricante.SelectedIndexChanged
        If cbo_Fabricante.Text = "" Then
            lbl_Fabricante.ForeColor = Color.Red
        Else
            lbl_Fabricante.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cbo_Tipo_Equipamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Tipo_Equipamento.SelectedIndexChanged
        If cbo_Tipo_Equipamento.Text = "" Then
            lbl_Tipo_Equipamento.ForeColor = Color.Red
        Else
            lbl_Tipo_Equipamento.ForeColor = Color.Black
        End If
    End Sub

    Private Sub mnsi_Fechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Status_Aprovacao_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_modelo.Text = dtg_Itens.CurrentRow.Cells("id_modelo").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value
        cbo_Fabricante.SelectedValue = dtg_Itens.CurrentRow.Cells("id_fabricante").Value
        cbo_Tipo_Equipamento.SelectedValue = dtg_Itens.CurrentRow.Cells("id_tipo_equipamento").Value

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True
        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_modelo", "id_modelo = " & txt_id_modelo.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem propostas cadastradas com esse modelo. Portanto, não será possível excluí-lo"
        End If
    End Sub
End Class