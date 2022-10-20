Imports MySql.Data.MySqlClient
Public Class Empresas

    Private Sub Carregar_Empresas()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT empr.id_empresa, empr.CNPJ, empr.razao_social, empr.nome_fantasia, empr.site, empr.id_status, stat.nome FROM tb_empresas AS empr LEFT JOIN tb_status AS stat ON empr.id_status = stat.id_status ORDER BY empr.razao_social", strConexao)

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

        dtg_Itens.Columns("id_empresa").HeaderText = "ID da Empresa"
        dtg_Itens.Columns("CNPJ").HeaderText = "CNPJ"
        dtg_Itens.Columns("razao_social").HeaderText = "Razão social"
        dtg_Itens.Columns("nome_fantasia").HeaderText = "Nome fantasia"
        dtg_Itens.Columns("site").HeaderText = "Site"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("nome").HeaderText = "Status"

        dtg_Itens.Columns("id_empresa").Visible = False
        dtg_Itens.Columns("CNPJ").Visible = True
        dtg_Itens.Columns("razao_social").Visible = True
        dtg_Itens.Columns("nome_fantasia").Visible = True
        dtg_Itens.Columns("site").Visible = True
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("nome").Visible = True

    End Sub

    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Empresas()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Razao_Social.Enabled = False
        txt_Razao_Social.Enabled = False
        lbl_CNPJ.Enabled = False
        mkt_CNPJ.Enabled = False
        lbl_Nome_Fantasia.Enabled = False
        txt_Nome_Fantasia.Enabled = False
        lbl_Site.Enabled = False
        txt_Site.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 486

        txt_id_empresa.Text = ""
        txt_Razao_Social.Text = ""
        mkt_CNPJ.Text = ""
        txt_Site.Text = ""
        txt_Nome_Fantasia.Text = ""
        cbo_Status.SelectedValue = -1

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Razao_Social.Enabled = True
        txt_Razao_Social.Enabled = True
        lbl_CNPJ.Enabled = True
        mkt_CNPJ.Enabled = True
        lbl_Nome_Fantasia.Enabled = True
        txt_Nome_Fantasia.Enabled = True
        lbl_Site.Enabled = True
        txt_Site.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 512

        txt_id_empresa.Text = ""
        txt_Razao_Social.Text = ""
        mkt_CNPJ.Text = ""
        txt_Site.Text = ""
        txt_Nome_Fantasia.Text = ""
        cbo_Status.SelectedValue = -1
        txt_Razao_Social.Focus()
    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_empresa.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False
        lbl_Razao_Social.Enabled = True
        txt_Razao_Social.Enabled = True
        lbl_CNPJ.Enabled = True
        mkt_CNPJ.Enabled = True
        lbl_Nome_Fantasia.Enabled = True
        txt_Nome_Fantasia.Enabled = True
        lbl_Site.Enabled = True
        txt_Site.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 512

        txt_Razao_Social.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_empresa.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir a empresa " & txt_Razao_Social.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_empresa", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_empresa", CONVERT_TO_INTEGER(txt_id_empresa.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("A empresa '" & txt_Razao_Social.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Empresa '" & txt_Razao_Social.Text & "' excluída com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Empresas()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Razao_Social.Enabled = False
            txt_Razao_Social.Enabled = False
            lbl_CNPJ.Enabled = False
            mkt_CNPJ.Enabled = False
            lbl_Nome_Fantasia.Enabled = False
            txt_Nome_Fantasia.Enabled = False
            lbl_Site.Enabled = False
            txt_Site.Enabled = False
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
        lbl_Razao_Social.Enabled = False
        txt_Razao_Social.Enabled = False
        lbl_CNPJ.Enabled = False
        mkt_CNPJ.Enabled = False
        lbl_Nome_Fantasia.Enabled = False
        txt_Nome_Fantasia.Enabled = False
        lbl_Site.Enabled = False
        txt_Site.Enabled = False
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

            txt_id_empresa.Text = ""
            txt_Razao_Social.Text = ""
            mkt_CNPJ.Text = ""
            txt_Site.Text = ""
            txt_Nome_Fantasia.Text = ""
            cbo_Status.SelectedValue = -1

        Else

            mnsi_Editar.Enabled = True
            If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_filiais", "id_empresa", "id_empresa = " & txt_id_empresa.Text, Limite:="1")) Then
                mnsi_Excluir.Enabled = True
                mnsi_Excluir.ToolTipText = ""
            Else
                mnsi_Excluir.Enabled = False
                mnsi_Excluir.ToolTipText = "Existem filiais cadastradas com essa empresa. Portanto, não será possível excluí-la"
            End If

        End If

    End Sub
    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Dim strObrigatorios As String = ""

        If REMOVE_MASK(mkt_CNPJ) = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_CNPJ.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_CNPJ.Text
            End If
            lbl_CNPJ.ForeColor = Color.Red
        Else
            lbl_CNPJ.ForeColor = Color.Black
        End If

        If txt_Razao_Social.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Razao_Social.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Razao_Social.Text
            End If
            lbl_Razao_Social.ForeColor = Color.Red
        Else
            lbl_Razao_Social.ForeColor = Color.Black
        End If

        If txt_Nome_Fantasia.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Nome_Fantasia.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Nome_Fantasia.Text
            End If
            lbl_Nome_Fantasia.ForeColor = Color.Red
        Else
            lbl_Nome_Fantasia.ForeColor = Color.Black
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
                sqlcmd = New MySqlCommand("sp_inserir_empresa", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_CNPJ", REMOVE_MASK(mkt_CNPJ))
                sqlcmd.Parameters.AddWithValue("p_razao_social", txt_Razao_Social.Text)
                sqlcmd.Parameters.AddWithValue("p_nome_fantasia", txt_Nome_Fantasia.Text)
                If Not String.IsNullOrEmpty(txt_Site.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_site", CONVERT_TO_STRING(txt_Site.Text))
                Else
                    sqlcmd.Parameters.Add("p_site", MySqlDbType.VarChar).Value = DBNull.Value
                End If
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("A empresa '" & txt_Razao_Social.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Empresa '" & txt_Razao_Social.Text & "' inserida com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_empresa.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_empresa", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_empresa", CONVERT_TO_INTEGER(txt_id_empresa.Text))
                sqlcmd.Parameters.AddWithValue("p_CNPJ", REMOVE_MASK(mkt_CNPJ))
                sqlcmd.Parameters.AddWithValue("p_razao_social", txt_Razao_Social.Text)
                sqlcmd.Parameters.AddWithValue("p_nome_fantasia", txt_Nome_Fantasia.Text)
                If Not String.IsNullOrEmpty(txt_Site.Text) Then
                    sqlcmd.Parameters.AddWithValue("p_site", CONVERT_TO_STRING(txt_Site.Text))
                Else
                    sqlcmd.Parameters.Add("p_site", MySqlDbType.VarChar).Value = DBNull.Value
                End If
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("A empresa '" & txt_Razao_Social.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Empresa '" & txt_Razao_Social.Text & "' editada com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


            Carregar_Empresas()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False
            lbl_Razao_Social.Enabled = False
            txt_Razao_Social.Enabled = False
            lbl_CNPJ.Enabled = False
            mkt_CNPJ.Enabled = False
            lbl_Nome_Fantasia.Enabled = False
            txt_Nome_Fantasia.Enabled = False
            lbl_Site.Enabled = False
            txt_Site.Enabled = False
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

    Private Sub mkt_CNPJ_TextChanged(sender As Object, e As EventArgs) Handles mkt_CNPJ.TextChanged

    End Sub

    Private Sub mkt_CNPJ_Leave(sender As Object, e As EventArgs) Handles mkt_CNPJ.Leave
        If REMOVE_MASK(mkt_CNPJ) = "" Then
            lbl_CNPJ.ForeColor = Color.Red
        Else
            lbl_CNPJ.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Razao_Social_TextChanged(sender As Object, e As EventArgs) Handles txt_Razao_Social.TextChanged
        If txt_Razao_Social.Text = "" Then
            lbl_Razao_Social.ForeColor = Color.Red
        Else
            lbl_Razao_Social.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Nome_Fantasia_TextChanged(sender As Object, e As EventArgs) Handles txt_Nome_Fantasia.TextChanged
        If txt_Nome_Fantasia.Text = "" Then
            lbl_Nome_Fantasia.ForeColor = Color.Red
        Else
            lbl_Nome_Fantasia.ForeColor = Color.Black
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

        txt_id_empresa.Text = dtg_Itens.CurrentRow.Cells("id_empresa").Value
        mkt_CNPJ.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("CNPJ").Value)
        txt_Razao_Social.Text = dtg_Itens.CurrentRow.Cells("razao_social").Value
        txt_Nome_Fantasia.Text = dtg_Itens.CurrentRow.Cells("nome_fantasia").Value
        txt_Site.Text = CONVERT_TO_STRING(dtg_Itens.CurrentRow.Cells("site").Value)
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value
        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True
        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_filiais", "id_empresa", "id_empresa = " & txt_id_empresa.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem filiais cadastradas com essa empresa. Portanto, não será possível excluí-la"
        End If
    End Sub


End Class