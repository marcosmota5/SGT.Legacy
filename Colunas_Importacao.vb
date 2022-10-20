Imports MySql.Data.MySqlClient
Public Class Colunas_Importacao

    Private Sub Carregar_Colunas_Importacao()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT coic.*, forn.nome AS nome_fornecedor FROM tb_colunas_importacao_cotacoes AS coic 
            LEFT JOIN tb_fornecedores AS forn ON coic.id_fornecedor = forn.id_fornecedor WHERE coic.id_fornecedor = " & CONVERT_TO_STRING(cbo_Fornecedor.SelectedValue) & " ORDER BY coic.id_coluna_importacao_cotacao", strConexao)

            adapter.Fill(dtb)
            dtg_Colunas.DataSource = dtb

            Formatar_Datagrid()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Private Sub Formatar_Datagrid()

        dtg_Colunas.Columns("id_coluna_importacao_cotacao").HeaderText = "ID da Coluna"
        dtg_Colunas.Columns("nome_coluna_sistema").HeaderText = "Nome da coluna"
        dtg_Colunas.Columns("nome_coluna_sistema_formatado").HeaderText = "Coluna no sistema"
        dtg_Colunas.Columns("coluna_existe").HeaderText = "Considerar coluna"
        dtg_Colunas.Columns("nome_coluna_cotacao").HeaderText = "Coluna na cotação"
        dtg_Colunas.Columns("id_fornecedor").HeaderText = "ID do Fornecedor"
        dtg_Colunas.Columns("nome_fornecedor").HeaderText = "Fornecedor"

        dtg_Colunas.Columns("id_coluna_importacao_cotacao").Visible = False
        dtg_Colunas.Columns("nome_coluna_sistema").Visible = False
        dtg_Colunas.Columns("nome_coluna_sistema_formatado").Visible = True
        dtg_Colunas.Columns("coluna_existe").Visible = True
        dtg_Colunas.Columns("nome_coluna_cotacao").Visible = True
        dtg_Colunas.Columns("id_fornecedor").Visible = False
        dtg_Colunas.Columns("nome_fornecedor").Visible = True

        dtg_Colunas.Columns("nome_coluna_sistema_formatado").DisplayIndex = 1
        dtg_Colunas.Columns("coluna_existe").DisplayIndex = 2
        dtg_Colunas.Columns("nome_coluna_cotacao").DisplayIndex = 3
        dtg_Colunas.Columns("nome_fornecedor").DisplayIndex = 0

        dtg_Colunas.Columns("id_coluna_importacao_cotacao").ReadOnly = True
        dtg_Colunas.Columns("nome_coluna_sistema").ReadOnly = True
        dtg_Colunas.Columns("nome_coluna_sistema_formatado").ReadOnly = True
        dtg_Colunas.Columns("coluna_existe").ReadOnly = False
        dtg_Colunas.Columns("nome_coluna_cotacao").ReadOnly = False
        dtg_Colunas.Columns("id_fornecedor").ReadOnly = True
        dtg_Colunas.Columns("nome_fornecedor").ReadOnly = True

        dtg_Colunas.Columns("nome_fornecedor").DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dtg_Colunas.Columns("nome_coluna_sistema_formatado").DefaultCellStyle.BackColor = System.Drawing.Color.LightGray

    End Sub

    Private Sub Colunas_Importacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Preencher_ComboBox(cbo_Fornecedor, "tb_fornecedores", "id_fornecedor", "nome", "id_fornecedor, nome", ordenar_por:="nome")

    End Sub

    Private Sub cbo_Fornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Fornecedor.SelectedIndexChanged
        Carregar_Colunas_Importacao()
    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click

        Dim strObrigatorios As String = ""

        If cbo_Fornecedor.Text = "" Then
            If strObrigatorios = "" Then
                strObrigatorios = lbl_Fornecedor.Text
            Else
                strObrigatorios = strObrigatorios & ", " & lbl_Fornecedor.Text
            End If
            lbl_Fornecedor.ForeColor = Color.Red
        Else
            lbl_Fornecedor.ForeColor = Color.Black
        End If

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand
        Dim conta_erro As Integer = 0

        Try
            Abrir_Conexao()

            For Each dtgRow As DataGridViewRow In dtg_Colunas.Rows

                sqlcmd = New MySqlCommand("sp_editar_coluna_importacao_cotacao", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_coluna_importacao_cotacao", CONVERT_TO_INTEGER(dtgRow.Cells(dtg_Colunas.Columns("id_coluna_importacao_cotacao").Index).Value))
                sqlcmd.Parameters.AddWithValue("p_nome_coluna_sistema", dtgRow.Cells(dtg_Colunas.Columns("nome_coluna_sistema").Index).Value)
                sqlcmd.Parameters.AddWithValue("p_nome_coluna_sistema_formatado", dtgRow.Cells(dtg_Colunas.Columns("nome_coluna_sistema_formatado").Index).Value)
                sqlcmd.Parameters.AddWithValue("p_coluna_existe", dtgRow.Cells(dtg_Colunas.Columns("coluna_existe").Index).Value)
                sqlcmd.Parameters.AddWithValue("p_nome_coluna_cotacao", dtgRow.Cells(dtg_Colunas.Columns("nome_coluna_cotacao").Index).Value)
                sqlcmd.Parameters.AddWithValue("p_id_fornecedor", CONVERT_TO_INTEGER(dtgRow.Cells(dtg_Colunas.Columns("id_fornecedor").Index).Value))
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    conta_erro = conta_erro + 1
                End If

            Next

            If conta_erro > 0 Then
                MessageBox.Show("A edição foi realizada para o fornecedor '" & cbo_Fornecedor.Text & "', porém algumas colunas não foram encontradas", "Edição parcial realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Mapeamento de colunas do fornecedor '" & cbo_Fornecedor.Text & "' editado com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            Carregar_Colunas_Importacao()

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try


    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

End Class