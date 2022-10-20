Imports MySql.Data.MySqlClient
Public Class Setores

    Private Sub Carregar_Setores()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT seto.id_setor, seto.nome, seto.prazo_adicional, seto.id_status, stat.nome FROM tb_setores AS seto LEFT JOIN tb_status AS stat ON seto.id_status = stat.id_status ORDER BY seto.nome", strConexao)

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

        dtg_Itens.Columns("id_setor").HeaderText = "ID do Setor"
        dtg_Itens.Columns("nome").HeaderText = "Setor"
        dtg_Itens.Columns("prazo_adicional").HeaderText = "Prazo adicional"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("nome1").HeaderText = "Status"

        dtg_Itens.Columns("id_setor").Visible = False
        dtg_Itens.Columns("nome").Visible = True
        dtg_Itens.Columns("prazo_adicional").Visible = True
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("nome1").Visible = True

    End Sub

    Private Sub Status_Aprovacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Setores()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = False
        txt_Nome.Enabled = False
        lbl_Prazo_Adicional.Enabled = False
        nud_Prazo_Adicional.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 486

        txt_id_setor.Text = ""
        txt_Nome.Text = ""
        nud_Prazo_Adicional.Value = 0
        cbo_Status.SelectedValue = -1

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Prazo_Adicional.Enabled = True
        nud_Prazo_Adicional.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 512

        txt_id_setor.Text = ""
        txt_Nome.Text = ""
        nud_Prazo_Adicional.Value = 0
        cbo_Status.SelectedValue = -1
        txt_Nome.Focus()
    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_setor.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Nome.Enabled = True
        txt_Nome.Enabled = True
        lbl_Prazo_Adicional.Enabled = True
        nud_Prazo_Adicional.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 512

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_setor.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o status de aprovação " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_setor", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_setor", CONVERT_TO_INTEGER(txt_id_setor.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O setor '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Setor '" & txt_Nome.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Setores()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Prazo_Adicional.Enabled = False
            nud_Prazo_Adicional.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            Me.Height = 486

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
        lbl_Prazo_Adicional.Enabled = False
        nud_Prazo_Adicional.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 486

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_setor.Text = ""
            txt_Nome.Text = ""
            nud_Prazo_Adicional.Value = 0
            cbo_Status.SelectedValue = -1

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_usuarios", "id_setor", "id_setor = " & txt_id_setor.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem usuários cadastrados com esse setor. Portanto, não será possível excluí-lo"
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
                sqlcmd = New MySqlCommand("sp_inserir_setor", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_prazo_adicional", CONVERT_TO_INTEGER(nud_Prazo_Adicional.Value))
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O setor '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Setor '" & txt_Nome.Text & "' inserido com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_setor.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_setor", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_setor", CONVERT_TO_INTEGER(txt_id_setor.Text))
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)
                sqlcmd.Parameters.AddWithValue("p_prazo_adicional", CONVERT_TO_INTEGER(nud_Prazo_Adicional.Value))
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("O setor '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Setor '" & txt_Nome.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


            Carregar_Setores()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Nome.Enabled = False
            txt_Nome.Enabled = False
            lbl_Prazo_Adicional.Enabled = False
            nud_Prazo_Adicional.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False
            Me.Height = 486

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

        txt_id_setor.Text = dtg_Itens.CurrentRow.Cells("id_setor").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value
        nud_Prazo_Adicional.Value = dtg_Itens.CurrentRow.Cells("prazo_adicional").Value
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value
        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True
        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_usuarios", "id_setor", "id_setor = " & txt_id_setor.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem usuários cadastrados com esse setor. Portanto, não será possível excluí-lo"
        End If
    End Sub

End Class