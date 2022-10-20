Imports MySql.Data.MySqlClient

Public Class Taxas

    Private Sub Carregar_Taxas()

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT * FROM tb_taxas AS taxas ORDER BY data_inicio DESC", strConexao)

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

        dtg_Itens.Columns("data_inicio").HeaderText = "Data de início"
        dtg_Itens.Columns("data_fim").HeaderText = "Data fim"
        dtg_Itens.Columns("nome").HeaderText = "Nome da taxa"

        dtg_Itens.Columns("percentual_aliquota_externa_icms_item_nacional").HeaderText = "% Alíquota externa ICMS nacional"
        dtg_Itens.Columns("percentual_aliquota_externa_icms_item_importado").HeaderText = "% Alíquota externa ICMS importado"

        dtg_Itens.Columns("percentual_mva_item_nacional").HeaderText = "% MVA nacional"
        dtg_Itens.Columns("percentual_mva_item_importado").HeaderText = "% MVA importado"

        dtg_Itens.Columns("percentual_aliquota_interna_icms_item_nacional").HeaderText = "% Alíquota interna do ICMS nacional"
        dtg_Itens.Columns("percentual_aliquota_interna_icms_item_importado").HeaderText = "% Alíquota interna do ICMS importado"

        dtg_Itens.Columns("impostos_federais_item_nacional").HeaderText = "% Impostos federais nacional"
        dtg_Itens.Columns("impostos_federais_item_importado").HeaderText = "% Impostos federais importado"

        dtg_Itens.Columns("rateio_despesa_fixa_item_nacional").HeaderText = "% Rateio despesa fixa nacional"
        dtg_Itens.Columns("rateio_despesa_fixa_item_importado").HeaderText = "% Rateio despesa fixa importado"

        dtg_Itens.Columns("percentual_lucro_necessario_item_revenda_st_nacional").HeaderText = "% Lucro necessário revenda ST nacional"
        dtg_Itens.Columns("percentual_lucro_necessario_item_revenda_st_importado").HeaderText = "% Lucro necessário revenda ST importado"

        dtg_Itens.Columns("percentual_lucro_necessario_item_outros_nacional").HeaderText = "% Lucro necessário outros nacional"
        dtg_Itens.Columns("percentual_lucro_necessario_item_outros_importado").HeaderText = "% Lucro necessário outros importado"

        dtg_Itens.Columns("percentual_acrescimo_item_nacional").HeaderText = "% Acréscimo nacional"
        dtg_Itens.Columns("percentual_acrescimo_item_importado").HeaderText = "% Acréscimo importado"

        dtg_Itens.Columns("data_inicio").DisplayIndex = 0
        dtg_Itens.Columns("data_fim").DisplayIndex = 1
        dtg_Itens.Columns("nome").DisplayIndex = 2

        dtg_Itens.Columns("percentual_aliquota_externa_icms_item_nacional").DisplayIndex = 3
        dtg_Itens.Columns("percentual_mva_item_nacional").DisplayIndex = 4
        dtg_Itens.Columns("percentual_aliquota_interna_icms_item_nacional").DisplayIndex = 5
        dtg_Itens.Columns("impostos_federais_item_nacional").DisplayIndex = 6
        dtg_Itens.Columns("rateio_despesa_fixa_item_nacional").DisplayIndex = 7
        dtg_Itens.Columns("percentual_lucro_necessario_item_revenda_st_nacional").DisplayIndex = 8
        dtg_Itens.Columns("percentual_lucro_necessario_item_outros_nacional").DisplayIndex = 9
        dtg_Itens.Columns("percentual_acrescimo_item_nacional").DisplayIndex = 10

        dtg_Itens.Columns("percentual_aliquota_externa_icms_item_importado").DisplayIndex = 11
        dtg_Itens.Columns("percentual_mva_item_importado").DisplayIndex = 12
        dtg_Itens.Columns("percentual_aliquota_interna_icms_item_importado").DisplayIndex = 13
        dtg_Itens.Columns("impostos_federais_item_importado").DisplayIndex = 14
        dtg_Itens.Columns("rateio_despesa_fixa_item_importado").DisplayIndex = 15
        dtg_Itens.Columns("percentual_lucro_necessario_item_revenda_st_importado").DisplayIndex = 16
        dtg_Itens.Columns("percentual_lucro_necessario_item_outros_importado").DisplayIndex = 17
        dtg_Itens.Columns("percentual_acrescimo_item_importado").DisplayIndex = 18

        dtg_Itens.Columns("id_taxa").Visible = False

        dtg_Itens.Columns("data_inicio").DefaultCellStyle.Format = "dd/MM/yyyy"
        dtg_Itens.Columns("data_fim").DefaultCellStyle.Format = "dd/MM/yyyy"

        dtg_Itens.Columns("percentual_aliquota_externa_icms_item_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_aliquota_externa_icms_item_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_mva_item_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_mva_item_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_aliquota_interna_icms_item_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_aliquota_interna_icms_item_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("impostos_federais_item_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("impostos_federais_item_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("rateio_despesa_fixa_item_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("rateio_despesa_fixa_item_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_lucro_necessario_item_revenda_st_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_lucro_necessario_item_revenda_st_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_lucro_necessario_item_outros_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_lucro_necessario_item_outros_importado").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_acrescimo_item_nacional").DefaultCellStyle.Format = "0.00%"
        dtg_Itens.Columns("percentual_acrescimo_item_importado").DefaultCellStyle.Format = "0.00%"



    End Sub

    Private Sub Taxas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_Taxas()

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        txt_Nome.Enabled = False

        dtp_Data_Inicio.Enabled = False
        dtp_Data_Fim.Enabled = False

        nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = False
        nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = False
        nud_Percentual_MVA_Item_Nacional.Enabled = False
        nud_Percentual_MVA_Item_Importado.Enabled = False
        nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = False
        nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = False
        nud_Impostos_Federais_Item_Nacional.Enabled = False
        nud_Impostos_Federais_Item_Importado.Enabled = False
        nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = False
        nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = False
        nud_Percentual_Acrescimo_Item_Nacional.Enabled = False
        nud_Percentual_Acrescimo_Item_Importado.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 522

        txt_id_taxa.Text = ""
        txt_Nome.Text = ""
        dtp_Data_Inicio.Value = Now
        dtp_Data_Fim.CustomFormat = " "

    End Sub

    Private Sub mnsi_Adicionar_Click(sender As Object, e As EventArgs) Handles mnsi_Adicionar.Click

        btn_Salvar.Tag = "adicionar"
        mnsi_Editar.Enabled = False
        mnsi_Excluir.Enabled = False

        txt_Nome.Enabled = True

        dtp_Data_Inicio.Enabled = True
        dtp_Data_Fim.Enabled = False

        nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = True
        nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = True
        nud_Percentual_MVA_Item_Nacional.Enabled = True
        nud_Percentual_MVA_Item_Importado.Enabled = True
        nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = True
        nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = True
        nud_Impostos_Federais_Item_Nacional.Enabled = True
        nud_Impostos_Federais_Item_Importado.Enabled = True
        nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = True
        nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = True
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = True
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = True
        nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = True
        nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = True
        nud_Percentual_Acrescimo_Item_Nacional.Enabled = True
        nud_Percentual_Acrescimo_Item_Importado.Enabled = True

        dtg_Itens.Enabled = False
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 548

        txt_id_taxa.Text = ""
        txt_Nome.Text = ""
        dtp_Data_Inicio.Value = Now
        dtp_Data_Fim.CustomFormat = " "
        txt_Nome.Focus()
    End Sub

    Private Sub mnsi_Editar_Click(sender As Object, e As EventArgs) Handles mnsi_Editar.Click

        If txt_id_taxa.Text = "" Then
            Exit Sub
        End If

        btn_Salvar.Tag = "editar"
        mnsi_Adicionar.Enabled = False
        mnsi_Excluir.Enabled = False

        txt_Nome.Enabled = True

        dtp_Data_Inicio.Enabled = False
        dtp_Data_Fim.Enabled = False

        nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = False
        nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = False
        nud_Percentual_MVA_Item_Nacional.Enabled = False
        nud_Percentual_MVA_Item_Importado.Enabled = False
        nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = False
        nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = False
        nud_Impostos_Federais_Item_Nacional.Enabled = False
        nud_Impostos_Federais_Item_Importado.Enabled = False
        nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = False
        nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = False
        nud_Percentual_Acrescimo_Item_Nacional.Enabled = False
        nud_Percentual_Acrescimo_Item_Importado.Enabled = False

        dtg_Itens.Enabled = True
        btn_Salvar.Enabled = True
        btn_Salvar.Visible = True
        btn_Cancelar.Enabled = True
        btn_Cancelar.Visible = True
        Me.Height = 548

        txt_Nome.Focus()
    End Sub
    Private Sub mnsi_Excluir_Click(sender As Object, e As EventArgs) Handles mnsi_Excluir.Click

        If txt_id_taxa.Text = "" Then
            MessageBox.Show(Me, "Selecione um registro para excluir", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Tem certeza que deseja excluir a taxa " & txt_Nome.Text & "? O processo não poderá ser desfeito", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            sqlcmd = New MySqlCommand("sp_excluir_taxa", strConexao)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("p_id_taxa", CONVERT_TO_INTEGER(txt_id_taxa.Text))
            sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
            sqlcmd.ExecuteNonQuery()

            Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
            If Mensagem_Conclusao = "Valor não existe" Then
                MessageBox.Show("A taxa '" & txt_Nome.Text & "' não existe na database", "Exclusão não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Taxa '" & txt_Nome.Text & "' excluída com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Carregar_Taxas()

            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_Nome.Enabled = False

            dtp_Data_Inicio.Enabled = False
            dtp_Data_Fim.Enabled = False

            nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = False
            nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = False
            nud_Percentual_MVA_Item_Nacional.Enabled = False
            nud_Percentual_MVA_Item_Importado.Enabled = False
            nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = False
            nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = False
            nud_Impostos_Federais_Item_Nacional.Enabled = False
            nud_Impostos_Federais_Item_Importado.Enabled = False
            nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = False
            nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = False
            nud_Percentual_Acrescimo_Item_Nacional.Enabled = False
            nud_Percentual_Acrescimo_Item_Importado.Enabled = False

            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False

            Me.Height = 522

        Catch ex As Exception
            MessageBox.Show("Erro na database. Detalhes: " & ex.Message & vbNewLine & ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Fechar_Conexao()
        End Try

    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        mnsi_Adicionar.Enabled = True
        dtg_Itens.Enabled = True

        txt_Nome.Enabled = False

        dtp_Data_Inicio.Enabled = False
        dtp_Data_Fim.Enabled = False

        nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = False
        nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = False
        nud_Percentual_MVA_Item_Nacional.Enabled = False
        nud_Percentual_MVA_Item_Importado.Enabled = False
        nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = False
        nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = False
        nud_Impostos_Federais_Item_Nacional.Enabled = False
        nud_Impostos_Federais_Item_Importado.Enabled = False
        nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = False
        nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = False
        nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = False
        nud_Percentual_Acrescimo_Item_Nacional.Enabled = False
        nud_Percentual_Acrescimo_Item_Importado.Enabled = False

        btn_Salvar.Enabled = False
        btn_Salvar.Visible = False
        btn_Cancelar.Enabled = False
        btn_Cancelar.Visible = False
        Me.Height = 522

        If btn_Salvar.Tag = "adicionar" Then

            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_id_taxa.Text = ""
            txt_Nome.Text = ""
            dtp_Data_Inicio.Value = Now
            dtp_Data_Fim.CustomFormat = " "

        Else

            mnsi_Editar.Enabled = True
            mnsi_Excluir.Enabled = False

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

        For Each ctl As Control In TabPage1.Controls

            If TypeName(ctl) = "NumericUpDown" Then
                Dim nud As NumericUpDown = ctl
                Dim lbl As Label = TabPage1.Controls(Replace(nud.Name, "nud", "lbl"))
                If String.IsNullOrEmpty(nud.Value.ToString) Then
                    If strObrigatorios = "" Then
                        strObrigatorios = lbl.Text
                    Else
                        strObrigatorios = strObrigatorios & ", " & lbl.Text
                    End If
                    lbl.ForeColor = Color.Red
                Else
                    lbl.ForeColor = Color.Black
                End If
            End If
        Next


        For Each ctl As Control In TabPage2.Controls

            If TypeName(ctl) = "NumericUpDown" Then
                Dim nud As NumericUpDown = ctl
                'MessageBox.Show(nud.Name)
                Dim lbl As Label = TabPage2.Controls(Replace(nud.Name, "nud", "lbl"))
                If String.IsNullOrEmpty(nud.Value.ToString) Then
                    If strObrigatorios = "" Then
                        strObrigatorios = lbl.Text
                    Else
                        strObrigatorios = strObrigatorios & ", " & lbl.Text
                    End If
                    lbl.ForeColor = Color.Red
                Else
                    lbl.ForeColor = Color.Black
                End If
            End If
        Next

        If strObrigatorios <> "" Then
            MessageBox.Show(Me, "Os campos a seguir são obrigatórios: " & strObrigatorios, "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlcmd As MySqlCommand

        Try
            Abrir_Conexao()
            If btn_Salvar.Tag = "adicionar" Then

                If MessageBox.Show(text:="Ao adicionar uma nova taxa, as taxas anteriores terão a data fim definida como o dia anterior a data de início atual, pois não pode haver mais de uma taxa em vigência. Tem certeza que deseja continuar?", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbNo Then
                    Exit Sub
                End If

                sqlcmd = New MySqlCommand("sp_inserir_taxa", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_data_inicio", dtp_Data_Inicio.Value)
                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)

                sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_externa_icms_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_externa_icms_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_mva_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_MVA_Item_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_mva_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_MVA_Item_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_interna_icms_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_interna_icms_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_impostos_federais_item_nacional", CONVERT_TO_DECIMAL(nud_Impostos_Federais_Item_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_impostos_federais_item_importado", CONVERT_TO_DECIMAL(nud_Impostos_Federais_Item_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_rateio_despesa_fixa_item_nacional", CONVERT_TO_DECIMAL(nud_Rateio_Despesa_Fixa_Item_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_rateio_despesa_fixa_item_importado", CONVERT_TO_DECIMAL(nud_Rateio_Despesa_Fixa_Item_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_revenda_st_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_outros_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_revenda_st_importado", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_outros_importado", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Acrescimo_Item_Nacional.Value) / 100)
                sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_Acrescimo_Item_Importado.Value) / 100)

                sqlcmd.Parameters.Add("p_id_taxa", MySqlDbType.Int32).Direction = 2
                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2

                sqlcmd.ExecuteNonQuery()
                Dim novo_id_taxa As Integer = CONVERT_TO_INTEGER(sqlcmd.Parameters("p_id_taxa").Value)
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor já existe" Then
                    MessageBox.Show("A taxa '" & txt_Nome.Text & "' já existe na database", "Inserção não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    sqlcmd = New MySqlCommand("sp_editar_taxa_data_fim", strConexao)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("p_id_taxa", novo_id_taxa)
                    sqlcmd.Parameters.AddWithValue("p_data_fim", DateAdd("d", -1, dtp_Data_Inicio.Value))

                    sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                    sqlcmd.ExecuteNonQuery()
                    Dim Mensagem_Conclusao2 As String = sqlcmd.Parameters("p_mensagem").Value.ToString

                    If Mensagem_Conclusao2 <> "Valor editado com sucesso" Then
                        MessageBox.Show("Taxa '" & txt_Nome.Text & "' inserida com sucesso, porém houve uma falha para atualizar a data fim das taxas anteriores. Por favor, contate o administrador", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Taxa '" & txt_Nome.Text & "' inserida com sucesso!", "Inserção realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If

            Else

                If txt_id_taxa.Text = "" Then
                    MessageBox.Show(Me, "Selecione um registro para editar", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                sqlcmd = New MySqlCommand("sp_editar_taxa", strConexao)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("p_id_taxa", CONVERT_TO_INTEGER(txt_id_taxa.Text))
                'sqlcmd.Parameters.AddWithValue("p_data_inicio", txt_Nome.Text)

                sqlcmd.Parameters.AddWithValue("p_nome", txt_Nome.Text)

                'sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_externa_icms_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_externa_icms_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_mva_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_MVA_Item_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_mva_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_MVA_Item_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_interna_icms_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_aliquota_interna_icms_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_impostos_federais_item_nacional", CONVERT_TO_DECIMAL(nud_Impostos_Federais_Item_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_impostos_federais_item_importado", CONVERT_TO_DECIMAL(nud_Impostos_Federais_Item_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_rateio_despesa_fixa_item_nacional", CONVERT_TO_DECIMAL(nud_Rateio_Despesa_Fixa_Item_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_rateio_despesa_fixa_item_importado", CONVERT_TO_DECIMAL(nud_Rateio_Despesa_Fixa_Item_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_revenda_st_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_outros_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_revenda_st_importado", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_lucro_necessario_item_outros_importado", CONVERT_TO_DECIMAL(nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_item_nacional", CONVERT_TO_DECIMAL(nud_Percentual_Acrescimo_Item_Nacional.Value) / 100)
                'sqlcmd.Parameters.AddWithValue("p_percentual_acrescimo_item_importado", CONVERT_TO_DECIMAL(nud_Percentual_Acrescimo_Item_Importado.Value) / 100)

                sqlcmd.Parameters.Add("p_mensagem", MySqlDbType.VarChar, 255).Direction = 2
                sqlcmd.ExecuteNonQuery()
                Dim Mensagem_Conclusao As String = sqlcmd.Parameters("p_mensagem").Value.ToString
                If Mensagem_Conclusao = "Valor não existe" Then
                    MessageBox.Show("A taxa '" & txt_Nome.Text & "' não existe na database", "Edição não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Taxa '" & txt_Nome.Text & "' editada com sucesso!", "Edição realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


            Carregar_Taxas()

            btn_Salvar.Tag = ""
            mnsi_Adicionar.Enabled = True
            mnsi_Editar.Enabled = False
            mnsi_Excluir.Enabled = False

            txt_Nome.Enabled = False

            dtp_Data_Inicio.Enabled = False
            dtp_Data_Fim.Enabled = False

            nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = False
            nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = False
            nud_Percentual_MVA_Item_Nacional.Enabled = False
            nud_Percentual_MVA_Item_Importado.Enabled = False
            nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = False
            nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = False
            nud_Impostos_Federais_Item_Nacional.Enabled = False
            nud_Impostos_Federais_Item_Importado.Enabled = False
            nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = False
            nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = False
            nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = False
            nud_Percentual_Acrescimo_Item_Nacional.Enabled = False
            nud_Percentual_Acrescimo_Item_Importado.Enabled = False


            dtg_Itens.Enabled = True
            btn_Salvar.Enabled = False
            btn_Salvar.Visible = False
            btn_Cancelar.Enabled = False
            btn_Cancelar.Visible = False
            Me.Height = 522

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

    Private Sub Status_Aprovacao_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dtg_Itens.ClearSelection()
    End Sub

    Private Sub dtg_Itens_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_Itens.SelectionChanged
        If dtg_Itens.CurrentRow Is Nothing Then
            Exit Sub
        End If

        txt_id_taxa.Text = dtg_Itens.CurrentRow.Cells("id_taxa").Value
        txt_Nome.Text = dtg_Itens.CurrentRow.Cells("nome").Value

        dtp_Data_Inicio.Value = dtg_Itens.CurrentRow.Cells("data_inicio").Value

        If IsDate(dtg_Itens.CurrentRow.Cells("data_fim").Value) Then
            dtp_Data_Fim.CustomFormat = "dd/MM/yyyy"
            dtp_Data_Fim.Value = dtg_Itens.CurrentRow.Cells("data_fim").Value
        Else
            dtp_Data_Fim.CustomFormat = " "
        End If

        nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_aliquota_externa_icms_item_nacional").Value) * 100
        nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_aliquota_externa_icms_item_importado").Value) * 100
        nud_Percentual_MVA_Item_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_mva_item_nacional").Value) * 100
        nud_Percentual_MVA_Item_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_mva_item_importado").Value) * 100
        nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_aliquota_interna_icms_item_nacional").Value) * 100
        nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_aliquota_interna_icms_item_importado").Value) * 100
        nud_Impostos_Federais_Item_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("impostos_federais_item_nacional").Value) * 100
        nud_Impostos_Federais_Item_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("impostos_federais_item_importado").Value) * 100
        nud_Rateio_Despesa_Fixa_Item_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("rateio_despesa_fixa_item_nacional").Value) * 100
        nud_Rateio_Despesa_Fixa_Item_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("rateio_despesa_fixa_item_importado").Value) * 100
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_lucro_necessario_item_revenda_st_nacional").Value) * 100
        nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_lucro_necessario_item_revenda_st_importado").Value) * 100
        nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_lucro_necessario_item_outros_nacional").Value) * 100
        nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_lucro_necessario_item_outros_importado").Value) * 100
        nud_Percentual_Acrescimo_Item_Nacional.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_acrescimo_item_nacional").Value) * 100
        nud_Percentual_Acrescimo_Item_Importado.Value = CONVERT_TO_DECIMAL(dtg_Itens.CurrentRow.Cells("percentual_acrescimo_item_importado").Value) * 100

        mnsi_Adicionar.Enabled = True
        mnsi_Editar.Enabled = True
        mnsi_Excluir.Enabled = False
    End Sub
End Class
