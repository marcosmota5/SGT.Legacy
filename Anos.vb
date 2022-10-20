Imports MySql.Data.MySqlClient
Public Class Anos

    Private Sub Carregar_Anos()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT anos.id_ano, anos.ano, anos.id_status, anos.id_fabricante, anos.posicao_inicio_caracteres, anos.caracteres, stat.nome AS Nome_Status, fabr.nome AS Nome_Fabricante FROM tb_anos AS anos 
                                               LEFT JOIN tb_status AS stat ON anos.id_status = stat.id_status              
                                               LEFT JOIN tb_fabricantes AS fabr ON anos.id_fabricante = fabr.id_fabricante ORDER BY anos.ano", strConexao)

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

        dtg_Itens.Columns("id_ano").HeaderText = "ID do Ano"
        dtg_Itens.Columns("ano").HeaderText = "Ano"
        dtg_Itens.Columns("id_status").HeaderText = "ID do Status"
        dtg_Itens.Columns("id_fabricante").HeaderText = "ID do Fabricante"
        dtg_Itens.Columns("posicao_inicio_caracteres").HeaderText = "Início dos caracteres"
        dtg_Itens.Columns("caracteres").HeaderText = "Caracteres"
        dtg_Itens.Columns("Nome_Status").HeaderText = "Status"
        dtg_Itens.Columns("Nome_Fabricante").HeaderText = "Fabricante"

        dtg_Itens.Columns("id_ano").Visible = False
        dtg_Itens.Columns("ano").Visible = True
        dtg_Itens.Columns("id_status").Visible = False
        dtg_Itens.Columns("id_fabricante").Visible = False
        dtg_Itens.Columns("posicao_inicio_caracteres").Visible = True
        dtg_Itens.Columns("caracteres").Visible = True
        dtg_Itens.Columns("Nome_Status").Visible = True
        dtg_Itens.Columns("Nome_Fabricante").Visible = True

    End Sub

    Private Sub Anos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Anos()
        Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
        Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", ordenar_por:="nome")

        For x As Integer = 1 To 255
            cbo_Posicao_Caracteres.Items.Add(x)
        Next

        For x As Integer = 1980 To 2100
            cbo_Ano.Items.Add(x)
        Next

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Ano.Enabled = False
        cbo_Ano.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        lbl_Fabricante.Enabled = False
        cbo_Fabricante.Enabled = False
        lbl_Posicao_Caracteres.Enabled = False
        cbo_Posicao_Caracteres.Enabled = False
        lbl_Caracteres.Enabled = False
        txt_Caracteres.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 526

        txt_id_ano.Text = ""

        cbo_Posicao_Caracteres.SelectedValue = -1
        cbo_Ano.SelectedValue = -1
        cbo_Status.SelectedValue = -1
        cbo_Fabricante.SelectedValue = -1
        txt_Caracteres.Text = ""

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Ano.Enabled = True
        cbo_Ano.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        lbl_Fabricante.Enabled = True
        cbo_Fabricante.Enabled = True
        lbl_Posicao_Caracteres.Enabled = True
        cbo_Posicao_Caracteres.Enabled = True
        lbl_Caracteres.Enabled = True
        txt_Caracteres.Enabled = True

        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 552

        txt_id_ano.Text = ""

        cbo_Posicao_Caracteres.SelectedValue = -1
        cbo_Ano.SelectedValue = -1
        cbo_Status.SelectedValue = -1
        cbo_Fabricante.SelectedValue = -1
        txt_Caracteres.Text = ""
        cbo_Ano.Focus()

    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_ano.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False

        lbl_Ano.Enabled = True
        cbo_Ano.Enabled = True
        lbl_Status.Enabled = True
        cbo_Status.Enabled = True
        lbl_Fabricante.Enabled = True
        cbo_Fabricante.Enabled = True
        lbl_Posicao_Caracteres.Enabled = True
        cbo_Posicao_Caracteres.Enabled = True
        lbl_Caracteres.Enabled = True
        txt_Caracteres.Enabled = True

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 552

        cbo_Ano.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_ano.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir o ano " & cbo_Ano.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_ano", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_ano", CONVERT_TO_INTEGER(txt_id_ano.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("O ano '" & cbo_Ano.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Ano '" & cbo_Ano.Text & "' excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Anos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", ordenar_por:="nome")

            For x As Integer = 1 To 255
                cbo_Posicao_Caracteres.Items.Add(x)
            Next

            For x As Integer = 1980 To 2100
                cbo_Ano.Items.Add(x)
            Next

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            lbl_Ano.Enabled = False
            cbo_Ano.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            lbl_Fabricante.Enabled = False
            cbo_Fabricante.Enabled = False
            lbl_Posicao_Caracteres.Enabled = False
            cbo_Posicao_Caracteres.Enabled = False
            lbl_Caracteres.Enabled = False
            txt_Caracteres.Enabled = False

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

        lbl_Ano.Enabled = False
        cbo_Ano.Enabled = False
        lbl_Status.Enabled = False
        cbo_Status.Enabled = False
        lbl_Fabricante.Enabled = False
        cbo_Fabricante.Enabled = False
        lbl_Posicao_Caracteres.Enabled = False
        cbo_Posicao_Caracteres.Enabled = False
        lbl_Caracteres.Enabled = False
        txt_Caracteres.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 526

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_ano.Text = ""

            cbo_Posicao_Caracteres.SelectedValue = -1
            cbo_Ano.SelectedValue = -1
            cbo_Status.SelectedValue = -1
            cbo_Fabricante.SelectedValue = -1
            txt_Caracteres.Text = ""

        Else

            mnsi_Editar.Enabled = True
            mnsi_Excluir.Enabled = True

        End If

    End Sub
    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Dim strObrigatorios As String = ""

        If cbo_Ano.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Ano.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Ano.Text
            End If
            lbl_Ano.ForeColor = Color.Red
        Else
            lbl_Ano.ForeColor = Color.Black
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

        If cbo_Posicao_Caracteres.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Posicao_Caracteres.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Posicao_Caracteres.Text
            End If
            lbl_Posicao_Caracteres.ForeColor = Color.Red
        Else
            lbl_Posicao_Caracteres.ForeColor = Color.Black
        End If

        If txt_Caracteres.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Caracteres.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Caracteres.Text
            End If
            lbl_Caracteres.ForeColor = Color.Red
        Else
            lbl_Caracteres.ForeColor = Color.Black
        End If

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then
                sqlcmd = New MySqlCommand("sp_inserir_ano", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_fabricante", cbo_Fabricante.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_posicao_inicio_caracteres", cbo_Posicao_Caracteres.Text)
                sqlcmd.Parameters.AddWithValue("p_caracteres", txt_Caracteres.Text)
                sqlcmd.Parameters.AddWithValue("p_ano", cbo_Ano.Text)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("O ano '" & cbo_Ano.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ano '" & cbo_Ano.Text & "' inserido com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_id_ano.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlcmd = New MySqlCommand("sp_editar_ano", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_ano", CONVERT_TO_INTEGER(txt_id_ano.Text))
                sqlcmd.Parameters.AddWithValue("p_id_status", cbo_Status.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_id_fabricante", cbo_Fabricante.SelectedValue)
                sqlcmd.Parameters.AddWithValue("p_posicao_inicio_caracteres", cbo_Posicao_Caracteres.Text)
                sqlcmd.Parameters.AddWithValue("p_caracteres", txt_Caracteres.Text)
                sqlcmd.Parameters.AddWithValue("p_ano", cbo_Ano.Text)
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("O ano '" & cbo_Ano.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ano '" & cbo_Ano.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            Carregar_Anos()
            Preencher_ComboBox(cbo_Status, "tb_status", "id_status", "nome", "id_status, nome", ordenar_por:="nome")
            Preencher_ComboBox(cbo_Fabricante, "tb_fabricantes", "id_fabricante", "nome", "id_fabricante, nome", ordenar_por:="nome")

            For x As Integer = 1 To 255
                cbo_Posicao_Caracteres.Items.Add(x)
            Next

            For x As Integer = 1980 To 2100
                cbo_Ano.Items.Add(x)
            Next

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            lbl_Ano.Enabled = False
            cbo_Ano.Enabled = False
            lbl_Status.Enabled = False
            cbo_Status.Enabled = False
            lbl_Fabricante.Enabled = False
            cbo_Fabricante.Enabled = False
            lbl_Posicao_Caracteres.Enabled = False
            cbo_Posicao_Caracteres.Enabled = False
            lbl_Caracteres.Enabled = False
            txt_Caracteres.Enabled = False

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

    Private Sub cbo_Ano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Ano.SelectedIndexChanged
        If cbo_Ano.Text = "" Then
            lbl_Ano.ForeColor = Color.Red
        Else
            lbl_Ano.ForeColor = Color.Black
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

    Private Sub cbo_Posicao_Caracteres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Posicao_Caracteres.SelectedIndexChanged
        If cbo_Posicao_Caracteres.Text = "" Then
            lbl_Posicao_Caracteres.ForeColor = Color.Red
        Else
            lbl_Posicao_Caracteres.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Caracteres_TextChanged(sender As Object, e As EventArgs) Handles txt_Caracteres.TextChanged
        If txt_Caracteres.Text = "" Then
            lbl_Caracteres.ForeColor = Color.Red
        Else
            lbl_Caracteres.ForeColor = Color.Black
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

        txt_id_ano.Text = dtg_Itens.CurrentRow.Cells("id_ano").Value

        cbo_Ano.Text = dtg_Itens.CurrentRow.Cells("ano").Value
        cbo_Status.SelectedValue = dtg_Itens.CurrentRow.Cells("id_status").Value
        cbo_Fabricante.SelectedValue = dtg_Itens.CurrentRow.Cells("id_fabricante").Value
        cbo_Posicao_Caracteres.Text = dtg_Itens.CurrentRow.Cells("posicao_inicio_caracteres").Value

        txt_Caracteres.Text = dtg_Itens.CurrentRow.Cells("caracteres").Value

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True
        mnsi_Excluir.Enabled = True
        If String.IsNullOrEmpty(GET_DATA_MYSQL("tb_propostas", "id_ano", "id_ano = " & txt_id_ano.Text, Limite:="1")) Then
            mnsi_Excluir.Enabled = True
            mnsi_Excluir.ToolTipText = ""
        Else
            mnsi_Excluir.Enabled = False
            mnsi_Excluir.ToolTipText = "Existem propostas cadastradas com esse ano. Portanto, não será possível excluí-lo"
        End If
    End Sub

End Class