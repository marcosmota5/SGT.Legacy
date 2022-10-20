<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proposta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proposta))
        Me.grp_Proposta = New System.Windows.Forms.GroupBox()
        Me.cbo_Prioridade = New System.Windows.Forms.ComboBox()
        Me.lbl_Prioridade = New System.Windows.Forms.Label()
        Me.txt_Codigo_Proposta = New System.Windows.Forms.TextBox()
        Me.cbo_Status = New System.Windows.Forms.ComboBox()
        Me.lbl_Codigo_Proposta = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.dtp_Data_Solicitacao = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Solicitacao = New System.Windows.Forms.Label()
        Me.grp_Faturamento = New System.Windows.Forms.GroupBox()
        Me.nud_Nota_Fiscal = New System.Windows.Forms.NumericUpDown()
        Me.nud_Valor_Faturamento = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Valor_Faturamento = New System.Windows.Forms.Label()
        Me.dtp_Data_Faturamento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Faturamento = New System.Windows.Forms.Label()
        Me.lbl_Nota_Fiscal = New System.Windows.Forms.Label()
        Me.dtp_Data_Envio_Faturamento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Envio_Faturamento = New System.Windows.Forms.Label()
        Me.grp_Solicitante = New System.Windows.Forms.GroupBox()
        Me.cbo_Cidade = New System.Windows.Forms.ComboBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Cidade = New System.Windows.Forms.Label()
        Me.mkt_Telefone = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_Estado = New System.Windows.Forms.ComboBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_Telefone = New System.Windows.Forms.Label()
        Me.cbo_Pais = New System.Windows.Forms.ComboBox()
        Me.lbl_Pais = New System.Windows.Forms.Label()
        Me.cbo_Contato = New System.Windows.Forms.ComboBox()
        Me.lbl_Contato = New System.Windows.Forms.Label()
        Me.cbo_Cliente = New System.Windows.Forms.ComboBox()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.grp_Equipamento = New System.Windows.Forms.GroupBox()
        Me.nud_Ordem_Servico = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Ordem_Servico = New System.Windows.Forms.Label()
        Me.nud_Horimetro = New System.Windows.Forms.NumericUpDown()
        Me.cbo_Modelo = New System.Windows.Forms.ComboBox()
        Me.lbl_Horimetro = New System.Windows.Forms.Label()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.cbo_Ano = New System.Windows.Forms.ComboBox()
        Me.lbl_Ano = New System.Windows.Forms.Label()
        Me.cbo_Serie = New System.Windows.Forms.ComboBox()
        Me.lbl_Serie = New System.Windows.Forms.Label()
        Me.cbo_Tipo_Equipamento = New System.Windows.Forms.ComboBox()
        Me.lbl_Tipo_Equipamento = New System.Windows.Forms.Label()
        Me.cbo_Fabricante = New System.Windows.Forms.ComboBox()
        Me.lbl_Fabricante = New System.Windows.Forms.Label()
        Me.grp_Items = New System.Windows.Forms.GroupBox()
        Me.lbl_Atualizando_Prazo = New System.Windows.Forms.Label()
        Me.sts_Itens_Proposta = New System.Windows.Forms.StatusStrip()
        Me.stsi_Total_Peças = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsi_Total_Servicos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgb_Atualizando_Prazo = New System.Windows.Forms.ProgressBar()
        Me.dtg_Itens = New System.Windows.Forms.DataGridView()
        Me.mnu_Itens = New System.Windows.Forms.MenuStrip()
        Me.mnui_Adicionar_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Peca = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Servico = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Deslocamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Editar_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Remover_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Importar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Importar_Kion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Importar_TVH = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Importar_Arquivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubstituirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Exportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Exportar_Kion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelaCompletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Prazos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Apenas_Completo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Apenas_Abreviado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Por_Peca = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Frete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Inserir_Frete_Valor_Igual = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Inserir_Frete_Valor_Dividido = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Valor_Dividido_Por_Preco = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Valor_Dividido_Por_Quantidade = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorValorTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Desconto = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Colunas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Todas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Outros_Dados_Iniciais = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Calculos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Quantidade_Estoque = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Subir_Ordem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Abaixar_Ordem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Proposta = New System.Windows.Forms.MenuStrip()
        Me.mnui_Salvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Revisar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Deletar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Visualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Exibir_Codigo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Apenas_Codigo_Atual = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Atual_Abreviado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Atual_Completo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Todos_Os_Codigos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Nao_Exibir_Codigo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Cancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssl_Envio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_Aprovacao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_Origem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_Revisao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ttp_Prazo = New System.Windows.Forms.ToolTip(Me.components)
        Me.cms_Datagrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Apenas_Este_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Todos_Itens = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_id_filial = New System.Windows.Forms.TextBox()
        Me.txt_item_excluido = New System.Windows.Forms.TextBox()
        Me.txt_atualizou_prazo = New System.Windows.Forms.TextBox()
        Me.grp_Outros = New System.Windows.Forms.GroupBox()
        Me.txt_Comentarios = New System.Windows.Forms.TextBox()
        Me.lbl_Comentarios = New System.Windows.Forms.Label()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbc_Proposta = New System.Windows.Forms.TabControl()
        Me.tbp_Dados_Gerais = New System.Windows.Forms.TabPage()
        Me.tbp_Termos = New System.Windows.Forms.TabPage()
        Me.lbl_Copiar_Termo = New System.Windows.Forms.Label()
        Me.cbo_Copiar_Termo = New System.Windows.Forms.ComboBox()
        Me.cbo_Carregar_De = New System.Windows.Forms.ComboBox()
        Me.lbl_Copiar_De = New System.Windows.Forms.Label()
        Me.cbo_Copiar_Proposta = New System.Windows.Forms.ComboBox()
        Me.lbl_Copiar_Proposta = New System.Windows.Forms.Label()
        Me.lbl_Copiar_Cliente = New System.Windows.Forms.Label()
        Me.cbo_Copiar_Cliente = New System.Windows.Forms.ComboBox()
        Me.grp_Termos = New System.Windows.Forms.GroupBox()
        Me.lbl_Texto_Padrao = New System.Windows.Forms.Label()
        Me.txt_Texto_Padrao = New System.Windows.Forms.TextBox()
        Me.lbl_Observacoes = New System.Windows.Forms.Label()
        Me.txt_Observacoes = New System.Windows.Forms.TextBox()
        Me.lbl_Prazo_Entrega = New System.Windows.Forms.Label()
        Me.txt_Validade = New System.Windows.Forms.TextBox()
        Me.lbl_Condicao_Pagamento = New System.Windows.Forms.Label()
        Me.lbl_Validade = New System.Windows.Forms.Label()
        Me.txt_Garantia = New System.Windows.Forms.TextBox()
        Me.lbl_Garantia = New System.Windows.Forms.Label()
        Me.txt_Prazo_Entrega = New System.Windows.Forms.TextBox()
        Me.txt_Condicao_Pagamento = New System.Windows.Forms.TextBox()
        Me.btn_Confirmar = New System.Windows.Forms.Button()
        Me.txt_id_proposta_old = New System.Windows.Forms.TextBox()
        Me.grp_Proposta.SuspendLayout()
        Me.grp_Faturamento.SuspendLayout()
        CType(Me.nud_Nota_Fiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Valor_Faturamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Solicitante.SuspendLayout()
        Me.grp_Equipamento.SuspendLayout()
        CType(Me.nud_Ordem_Servico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Horimetro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Items.SuspendLayout()
        Me.sts_Itens_Proposta.SuspendLayout()
        CType(Me.dtg_Itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_Itens.SuspendLayout()
        Me.mnu_Proposta.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.cms_Datagrid.SuspendLayout()
        Me.grp_Outros.SuspendLayout()
        Me.tbc_Proposta.SuspendLayout()
        Me.tbp_Dados_Gerais.SuspendLayout()
        Me.tbp_Termos.SuspendLayout()
        Me.grp_Termos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Proposta
        '
        Me.grp_Proposta.Controls.Add(Me.cbo_Prioridade)
        Me.grp_Proposta.Controls.Add(Me.lbl_Prioridade)
        Me.grp_Proposta.Controls.Add(Me.txt_Codigo_Proposta)
        Me.grp_Proposta.Controls.Add(Me.cbo_Status)
        Me.grp_Proposta.Controls.Add(Me.lbl_Codigo_Proposta)
        Me.grp_Proposta.Controls.Add(Me.lbl_Status)
        Me.grp_Proposta.Controls.Add(Me.dtp_Data_Solicitacao)
        Me.grp_Proposta.Controls.Add(Me.lbl_Data_Solicitacao)
        Me.grp_Proposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Proposta.Location = New System.Drawing.Point(6, 136)
        Me.grp_Proposta.Name = "grp_Proposta"
        Me.grp_Proposta.Size = New System.Drawing.Size(530, 75)
        Me.grp_Proposta.TabIndex = 4
        Me.grp_Proposta.TabStop = False
        Me.grp_Proposta.Text = "Proposta"
        '
        'cbo_Prioridade
        '
        Me.cbo_Prioridade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Prioridade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Prioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Prioridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Prioridade.FormattingEnabled = True
        Me.cbo_Prioridade.Location = New System.Drawing.Point(281, 38)
        Me.cbo_Prioridade.Name = "cbo_Prioridade"
        Me.cbo_Prioridade.Size = New System.Drawing.Size(120, 21)
        Me.cbo_Prioridade.TabIndex = 6
        '
        'lbl_Prioridade
        '
        Me.lbl_Prioridade.AutoSize = True
        Me.lbl_Prioridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prioridade.Location = New System.Drawing.Point(278, 22)
        Me.lbl_Prioridade.Name = "lbl_Prioridade"
        Me.lbl_Prioridade.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Prioridade.TabIndex = 2
        Me.lbl_Prioridade.Text = "Prioridade"
        '
        'txt_Codigo_Proposta
        '
        Me.txt_Codigo_Proposta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_Codigo_Proposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Codigo_Proposta.Location = New System.Drawing.Point(167, 38)
        Me.txt_Codigo_Proposta.MaxLength = 30
        Me.txt_Codigo_Proposta.Name = "txt_Codigo_Proposta"
        Me.txt_Codigo_Proposta.ReadOnly = True
        Me.txt_Codigo_Proposta.Size = New System.Drawing.Size(108, 20)
        Me.txt_Codigo_Proposta.TabIndex = 5
        '
        'cbo_Status
        '
        Me.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Location = New System.Drawing.Point(407, 38)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(109, 21)
        Me.cbo_Status.TabIndex = 7
        '
        'lbl_Codigo_Proposta
        '
        Me.lbl_Codigo_Proposta.AutoSize = True
        Me.lbl_Codigo_Proposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Codigo_Proposta.Location = New System.Drawing.Point(164, 22)
        Me.lbl_Codigo_Proposta.Name = "lbl_Codigo_Proposta"
        Me.lbl_Codigo_Proposta.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Codigo_Proposta.TabIndex = 1
        Me.lbl_Codigo_Proposta.Text = "Código"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(404, 22)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Status.TabIndex = 3
        Me.lbl_Status.Text = "Status"
        '
        'dtp_Data_Solicitacao
        '
        Me.dtp_Data_Solicitacao.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtp_Data_Solicitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Solicitacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Solicitacao.Location = New System.Drawing.Point(15, 38)
        Me.dtp_Data_Solicitacao.Name = "dtp_Data_Solicitacao"
        Me.dtp_Data_Solicitacao.Size = New System.Drawing.Size(146, 20)
        Me.dtp_Data_Solicitacao.TabIndex = 4
        '
        'lbl_Data_Solicitacao
        '
        Me.lbl_Data_Solicitacao.AutoSize = True
        Me.lbl_Data_Solicitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Solicitacao.Location = New System.Drawing.Point(12, 22)
        Me.lbl_Data_Solicitacao.Name = "lbl_Data_Solicitacao"
        Me.lbl_Data_Solicitacao.Size = New System.Drawing.Size(117, 13)
        Me.lbl_Data_Solicitacao.TabIndex = 0
        Me.lbl_Data_Solicitacao.Text = "Data da solicitação"
        '
        'grp_Faturamento
        '
        Me.grp_Faturamento.Controls.Add(Me.nud_Nota_Fiscal)
        Me.grp_Faturamento.Controls.Add(Me.nud_Valor_Faturamento)
        Me.grp_Faturamento.Controls.Add(Me.lbl_Valor_Faturamento)
        Me.grp_Faturamento.Controls.Add(Me.dtp_Data_Faturamento)
        Me.grp_Faturamento.Controls.Add(Me.lbl_Data_Faturamento)
        Me.grp_Faturamento.Controls.Add(Me.lbl_Nota_Fiscal)
        Me.grp_Faturamento.Controls.Add(Me.dtp_Data_Envio_Faturamento)
        Me.grp_Faturamento.Controls.Add(Me.lbl_Data_Envio_Faturamento)
        Me.grp_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Faturamento.Location = New System.Drawing.Point(542, 6)
        Me.grp_Faturamento.Name = "grp_Faturamento"
        Me.grp_Faturamento.Size = New System.Drawing.Size(530, 75)
        Me.grp_Faturamento.TabIndex = 3
        Me.grp_Faturamento.TabStop = False
        Me.grp_Faturamento.Text = "Faturamento"
        '
        'nud_Nota_Fiscal
        '
        Me.nud_Nota_Fiscal.Enabled = False
        Me.nud_Nota_Fiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Nota_Fiscal.InterceptArrowKeys = False
        Me.nud_Nota_Fiscal.Location = New System.Drawing.Point(351, 38)
        Me.nud_Nota_Fiscal.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Nota_Fiscal.Name = "nud_Nota_Fiscal"
        Me.nud_Nota_Fiscal.Size = New System.Drawing.Size(76, 20)
        Me.nud_Nota_Fiscal.TabIndex = 6
        '
        'nud_Valor_Faturamento
        '
        Me.nud_Valor_Faturamento.DecimalPlaces = 2
        Me.nud_Valor_Faturamento.Enabled = False
        Me.nud_Valor_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Valor_Faturamento.InterceptArrowKeys = False
        Me.nud_Valor_Faturamento.Location = New System.Drawing.Point(433, 38)
        Me.nud_Valor_Faturamento.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Valor_Faturamento.Name = "nud_Valor_Faturamento"
        Me.nud_Valor_Faturamento.Size = New System.Drawing.Size(83, 20)
        Me.nud_Valor_Faturamento.TabIndex = 7
        Me.nud_Valor_Faturamento.ThousandsSeparator = True
        '
        'lbl_Valor_Faturamento
        '
        Me.lbl_Valor_Faturamento.AutoSize = True
        Me.lbl_Valor_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Valor_Faturamento.Location = New System.Drawing.Point(430, 22)
        Me.lbl_Valor_Faturamento.Name = "lbl_Valor_Faturamento"
        Me.lbl_Valor_Faturamento.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Valor_Faturamento.TabIndex = 3
        Me.lbl_Valor_Faturamento.Text = "Valor fatur."
        '
        'dtp_Data_Faturamento
        '
        Me.dtp_Data_Faturamento.Checked = False
        Me.dtp_Data_Faturamento.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtp_Data_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Faturamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Faturamento.Location = New System.Drawing.Point(185, 38)
        Me.dtp_Data_Faturamento.Name = "dtp_Data_Faturamento"
        Me.dtp_Data_Faturamento.ShowCheckBox = True
        Me.dtp_Data_Faturamento.Size = New System.Drawing.Size(160, 20)
        Me.dtp_Data_Faturamento.TabIndex = 5
        '
        'lbl_Data_Faturamento
        '
        Me.lbl_Data_Faturamento.AutoSize = True
        Me.lbl_Data_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Faturamento.Location = New System.Drawing.Point(182, 22)
        Me.lbl_Data_Faturamento.Name = "lbl_Data_Faturamento"
        Me.lbl_Data_Faturamento.Size = New System.Drawing.Size(123, 13)
        Me.lbl_Data_Faturamento.TabIndex = 1
        Me.lbl_Data_Faturamento.Text = "Data do faturamento"
        '
        'lbl_Nota_Fiscal
        '
        Me.lbl_Nota_Fiscal.AutoSize = True
        Me.lbl_Nota_Fiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nota_Fiscal.Location = New System.Drawing.Point(350, 22)
        Me.lbl_Nota_Fiscal.Name = "lbl_Nota_Fiscal"
        Me.lbl_Nota_Fiscal.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Nota_Fiscal.TabIndex = 2
        Me.lbl_Nota_Fiscal.Text = "Nota fiscal"
        '
        'dtp_Data_Envio_Faturamento
        '
        Me.dtp_Data_Envio_Faturamento.Checked = False
        Me.dtp_Data_Envio_Faturamento.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtp_Data_Envio_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Envio_Faturamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Envio_Faturamento.Location = New System.Drawing.Point(15, 38)
        Me.dtp_Data_Envio_Faturamento.Name = "dtp_Data_Envio_Faturamento"
        Me.dtp_Data_Envio_Faturamento.ShowCheckBox = True
        Me.dtp_Data_Envio_Faturamento.Size = New System.Drawing.Size(164, 20)
        Me.dtp_Data_Envio_Faturamento.TabIndex = 4
        '
        'lbl_Data_Envio_Faturamento
        '
        Me.lbl_Data_Envio_Faturamento.AutoSize = True
        Me.lbl_Data_Envio_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Faturamento.Location = New System.Drawing.Point(12, 22)
        Me.lbl_Data_Envio_Faturamento.Name = "lbl_Data_Envio_Faturamento"
        Me.lbl_Data_Envio_Faturamento.Size = New System.Drawing.Size(121, 13)
        Me.lbl_Data_Envio_Faturamento.TabIndex = 0
        Me.lbl_Data_Envio_Faturamento.Text = "Data de envio fatur."
        '
        'grp_Solicitante
        '
        Me.grp_Solicitante.Controls.Add(Me.cbo_Cidade)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Email)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Cidade)
        Me.grp_Solicitante.Controls.Add(Me.mkt_Telefone)
        Me.grp_Solicitante.Controls.Add(Me.cbo_Estado)
        Me.grp_Solicitante.Controls.Add(Me.txt_Email)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Estado)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Telefone)
        Me.grp_Solicitante.Controls.Add(Me.cbo_Pais)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Pais)
        Me.grp_Solicitante.Controls.Add(Me.cbo_Contato)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Contato)
        Me.grp_Solicitante.Controls.Add(Me.cbo_Cliente)
        Me.grp_Solicitante.Controls.Add(Me.lbl_Cliente)
        Me.grp_Solicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Solicitante.Location = New System.Drawing.Point(6, 6)
        Me.grp_Solicitante.Name = "grp_Solicitante"
        Me.grp_Solicitante.Size = New System.Drawing.Size(530, 127)
        Me.grp_Solicitante.TabIndex = 2
        Me.grp_Solicitante.TabStop = False
        Me.grp_Solicitante.Text = "Dados do solicitante"
        '
        'cbo_Cidade
        '
        Me.cbo_Cidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Cidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Cidade.FormattingEnabled = True
        Me.cbo_Cidade.Location = New System.Drawing.Point(282, 86)
        Me.cbo_Cidade.Name = "cbo_Cidade"
        Me.cbo_Cidade.Size = New System.Drawing.Size(234, 21)
        Me.cbo_Cidade.TabIndex = 13
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.Location = New System.Drawing.Point(399, 23)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Email.TabIndex = 3
        Me.lbl_Email.Text = "E-mail"
        '
        'lbl_Cidade
        '
        Me.lbl_Cidade.AutoSize = True
        Me.lbl_Cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cidade.Location = New System.Drawing.Point(279, 70)
        Me.lbl_Cidade.Name = "lbl_Cidade"
        Me.lbl_Cidade.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Cidade.TabIndex = 10
        Me.lbl_Cidade.Text = "Cidade"
        '
        'mkt_Telefone
        '
        Me.mkt_Telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkt_Telefone.Location = New System.Drawing.Point(310, 39)
        Me.mkt_Telefone.Mask = "(00) 00000-0000"
        Me.mkt_Telefone.Name = "mkt_Telefone"
        Me.mkt_Telefone.Size = New System.Drawing.Size(87, 20)
        Me.mkt_Telefone.TabIndex = 6
        '
        'cbo_Estado
        '
        Me.cbo_Estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Estado.FormattingEnabled = True
        Me.cbo_Estado.Location = New System.Drawing.Point(167, 86)
        Me.cbo_Estado.Name = "cbo_Estado"
        Me.cbo_Estado.Size = New System.Drawing.Size(109, 21)
        Me.cbo_Estado.TabIndex = 12
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(402, 39)
        Me.txt_Email.MaxLength = 60
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(113, 20)
        Me.txt_Email.TabIndex = 7
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estado.Location = New System.Drawing.Point(164, 70)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Estado.TabIndex = 9
        Me.lbl_Estado.Text = "Estado"
        '
        'lbl_Telefone
        '
        Me.lbl_Telefone.AutoSize = True
        Me.lbl_Telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telefone.Location = New System.Drawing.Point(307, 23)
        Me.lbl_Telefone.Name = "lbl_Telefone"
        Me.lbl_Telefone.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Telefone.TabIndex = 2
        Me.lbl_Telefone.Text = "Telefone"
        '
        'cbo_Pais
        '
        Me.cbo_Pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Pais.FormattingEnabled = True
        Me.cbo_Pais.Location = New System.Drawing.Point(15, 86)
        Me.cbo_Pais.Name = "cbo_Pais"
        Me.cbo_Pais.Size = New System.Drawing.Size(146, 21)
        Me.cbo_Pais.TabIndex = 11
        '
        'lbl_Pais
        '
        Me.lbl_Pais.AutoSize = True
        Me.lbl_Pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pais.Location = New System.Drawing.Point(12, 70)
        Me.lbl_Pais.Name = "lbl_Pais"
        Me.lbl_Pais.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Pais.TabIndex = 8
        Me.lbl_Pais.Text = "País"
        '
        'cbo_Contato
        '
        Me.cbo_Contato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_Contato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Contato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Contato.FormattingEnabled = True
        Me.cbo_Contato.Location = New System.Drawing.Point(196, 38)
        Me.cbo_Contato.MaxLength = 60
        Me.cbo_Contato.Name = "cbo_Contato"
        Me.cbo_Contato.Size = New System.Drawing.Size(109, 21)
        Me.cbo_Contato.TabIndex = 5
        '
        'lbl_Contato
        '
        Me.lbl_Contato.AutoSize = True
        Me.lbl_Contato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contato.Location = New System.Drawing.Point(193, 22)
        Me.lbl_Contato.Name = "lbl_Contato"
        Me.lbl_Contato.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Contato.TabIndex = 1
        Me.lbl_Contato.Text = "Contato"
        '
        'cbo_Cliente
        '
        Me.cbo_Cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.cbo_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Cliente.FormattingEnabled = True
        Me.cbo_Cliente.Location = New System.Drawing.Point(15, 38)
        Me.cbo_Cliente.Name = "cbo_Cliente"
        Me.cbo_Cliente.Size = New System.Drawing.Size(175, 21)
        Me.cbo_Cliente.TabIndex = 4
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(12, 22)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente"
        '
        'grp_Equipamento
        '
        Me.grp_Equipamento.Controls.Add(Me.nud_Ordem_Servico)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Ordem_Servico)
        Me.grp_Equipamento.Controls.Add(Me.nud_Horimetro)
        Me.grp_Equipamento.Controls.Add(Me.cbo_Modelo)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Horimetro)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Modelo)
        Me.grp_Equipamento.Controls.Add(Me.cbo_Ano)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Ano)
        Me.grp_Equipamento.Controls.Add(Me.cbo_Serie)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Serie)
        Me.grp_Equipamento.Controls.Add(Me.cbo_Tipo_Equipamento)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Tipo_Equipamento)
        Me.grp_Equipamento.Controls.Add(Me.cbo_Fabricante)
        Me.grp_Equipamento.Controls.Add(Me.lbl_Fabricante)
        Me.grp_Equipamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Equipamento.Location = New System.Drawing.Point(542, 84)
        Me.grp_Equipamento.Name = "grp_Equipamento"
        Me.grp_Equipamento.Size = New System.Drawing.Size(530, 127)
        Me.grp_Equipamento.TabIndex = 5
        Me.grp_Equipamento.TabStop = False
        Me.grp_Equipamento.Text = "Equipamento"
        '
        'nud_Ordem_Servico
        '
        Me.nud_Ordem_Servico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Ordem_Servico.InterceptArrowKeys = False
        Me.nud_Ordem_Servico.Location = New System.Drawing.Point(369, 87)
        Me.nud_Ordem_Servico.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Ordem_Servico.Name = "nud_Ordem_Servico"
        Me.nud_Ordem_Servico.Size = New System.Drawing.Size(105, 20)
        Me.nud_Ordem_Servico.TabIndex = 13
        '
        'lbl_Ordem_Servico
        '
        Me.lbl_Ordem_Servico.AutoSize = True
        Me.lbl_Ordem_Servico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ordem_Servico.Location = New System.Drawing.Point(368, 71)
        Me.lbl_Ordem_Servico.Name = "lbl_Ordem_Servico"
        Me.lbl_Ordem_Servico.Size = New System.Drawing.Size(106, 13)
        Me.lbl_Ordem_Servico.TabIndex = 12
        Me.lbl_Ordem_Servico.Text = "Ordem de serviço"
        '
        'nud_Horimetro
        '
        Me.nud_Horimetro.DecimalPlaces = 2
        Me.nud_Horimetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Horimetro.InterceptArrowKeys = False
        Me.nud_Horimetro.Location = New System.Drawing.Point(272, 87)
        Me.nud_Horimetro.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Horimetro.Name = "nud_Horimetro"
        Me.nud_Horimetro.Size = New System.Drawing.Size(91, 20)
        Me.nud_Horimetro.TabIndex = 11
        '
        'cbo_Modelo
        '
        Me.cbo_Modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Modelo.FormattingEnabled = True
        Me.cbo_Modelo.Location = New System.Drawing.Point(15, 86)
        Me.cbo_Modelo.Name = "cbo_Modelo"
        Me.cbo_Modelo.Size = New System.Drawing.Size(146, 21)
        Me.cbo_Modelo.TabIndex = 9
        '
        'lbl_Horimetro
        '
        Me.lbl_Horimetro.AutoSize = True
        Me.lbl_Horimetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Horimetro.Location = New System.Drawing.Point(269, 69)
        Me.lbl_Horimetro.Name = "lbl_Horimetro"
        Me.lbl_Horimetro.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Horimetro.TabIndex = 8
        Me.lbl_Horimetro.Text = "Horímetro"
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Modelo.Location = New System.Drawing.Point(12, 70)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Modelo.TabIndex = 6
        Me.lbl_Modelo.Text = "Modelo"
        '
        'cbo_Ano
        '
        Me.cbo_Ano.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Ano.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Ano.FormattingEnabled = True
        Me.cbo_Ano.Location = New System.Drawing.Point(166, 86)
        Me.cbo_Ano.Name = "cbo_Ano"
        Me.cbo_Ano.Size = New System.Drawing.Size(100, 21)
        Me.cbo_Ano.TabIndex = 10
        '
        'lbl_Ano
        '
        Me.lbl_Ano.AutoSize = True
        Me.lbl_Ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ano.Location = New System.Drawing.Point(163, 70)
        Me.lbl_Ano.Name = "lbl_Ano"
        Me.lbl_Ano.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Ano.TabIndex = 7
        Me.lbl_Ano.Text = "Ano"
        '
        'cbo_Serie
        '
        Me.cbo_Serie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_Serie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Serie.FormattingEnabled = True
        Me.cbo_Serie.Location = New System.Drawing.Point(15, 39)
        Me.cbo_Serie.MaxLength = 60
        Me.cbo_Serie.Name = "cbo_Serie"
        Me.cbo_Serie.Size = New System.Drawing.Size(146, 21)
        Me.cbo_Serie.TabIndex = 3
        '
        'lbl_Serie
        '
        Me.lbl_Serie.AutoSize = True
        Me.lbl_Serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Serie.Location = New System.Drawing.Point(12, 23)
        Me.lbl_Serie.Name = "lbl_Serie"
        Me.lbl_Serie.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Serie.TabIndex = 0
        Me.lbl_Serie.Text = "Série"
        '
        'cbo_Tipo_Equipamento
        '
        Me.cbo_Tipo_Equipamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Tipo_Equipamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Tipo_Equipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tipo_Equipamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tipo_Equipamento.FormattingEnabled = True
        Me.cbo_Tipo_Equipamento.Location = New System.Drawing.Point(334, 39)
        Me.cbo_Tipo_Equipamento.Name = "cbo_Tipo_Equipamento"
        Me.cbo_Tipo_Equipamento.Size = New System.Drawing.Size(182, 21)
        Me.cbo_Tipo_Equipamento.TabIndex = 5
        '
        'lbl_Tipo_Equipamento
        '
        Me.lbl_Tipo_Equipamento.AutoSize = True
        Me.lbl_Tipo_Equipamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo_Equipamento.Location = New System.Drawing.Point(331, 23)
        Me.lbl_Tipo_Equipamento.Name = "lbl_Tipo_Equipamento"
        Me.lbl_Tipo_Equipamento.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Tipo_Equipamento.TabIndex = 2
        Me.lbl_Tipo_Equipamento.Text = "Tipo"
        '
        'cbo_Fabricante
        '
        Me.cbo_Fabricante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Fabricante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Fabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Fabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Fabricante.FormattingEnabled = True
        Me.cbo_Fabricante.Location = New System.Drawing.Point(167, 39)
        Me.cbo_Fabricante.Name = "cbo_Fabricante"
        Me.cbo_Fabricante.Size = New System.Drawing.Size(161, 21)
        Me.cbo_Fabricante.TabIndex = 4
        '
        'lbl_Fabricante
        '
        Me.lbl_Fabricante.AutoSize = True
        Me.lbl_Fabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fabricante.Location = New System.Drawing.Point(164, 23)
        Me.lbl_Fabricante.Name = "lbl_Fabricante"
        Me.lbl_Fabricante.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Fabricante.TabIndex = 1
        Me.lbl_Fabricante.Text = "Fabricante"
        '
        'grp_Items
        '
        Me.grp_Items.Controls.Add(Me.lbl_Atualizando_Prazo)
        Me.grp_Items.Controls.Add(Me.sts_Itens_Proposta)
        Me.grp_Items.Controls.Add(Me.pgb_Atualizando_Prazo)
        Me.grp_Items.Controls.Add(Me.dtg_Itens)
        Me.grp_Items.Controls.Add(Me.mnu_Itens)
        Me.grp_Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Items.Location = New System.Drawing.Point(6, 292)
        Me.grp_Items.Name = "grp_Items"
        Me.grp_Items.Size = New System.Drawing.Size(1066, 290)
        Me.grp_Items.TabIndex = 7
        Me.grp_Items.TabStop = False
        Me.grp_Items.Text = "Itens da proposta"
        '
        'lbl_Atualizando_Prazo
        '
        Me.lbl_Atualizando_Prazo.AutoSize = True
        Me.lbl_Atualizando_Prazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Atualizando_Prazo.Location = New System.Drawing.Point(446, 238)
        Me.lbl_Atualizando_Prazo.Name = "lbl_Atualizando_Prazo"
        Me.lbl_Atualizando_Prazo.Size = New System.Drawing.Size(174, 13)
        Me.lbl_Atualizando_Prazo.TabIndex = 56
        Me.lbl_Atualizando_Prazo.Text = "Atualizando prazo, aguarde..."
        Me.lbl_Atualizando_Prazo.Visible = False
        '
        'sts_Itens_Proposta
        '
        Me.sts_Itens_Proposta.Dock = System.Windows.Forms.DockStyle.None
        Me.sts_Itens_Proposta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsi_Total_Peças, Me.stsi_Total_Servicos})
        Me.sts_Itens_Proposta.Location = New System.Drawing.Point(15, 261)
        Me.sts_Itens_Proposta.Name = "sts_Itens_Proposta"
        Me.sts_Itens_Proposta.Size = New System.Drawing.Size(211, 24)
        Me.sts_Itens_Proposta.SizingGrip = False
        Me.sts_Itens_Proposta.TabIndex = 2
        Me.sts_Itens_Proposta.Text = "StatusStrip2"
        '
        'stsi_Total_Peças
        '
        Me.stsi_Total_Peças.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsi_Total_Peças.Name = "stsi_Total_Peças"
        Me.stsi_Total_Peças.Size = New System.Drawing.Size(88, 19)
        Me.stsi_Total_Peças.Text = "Total de peças:"
        '
        'stsi_Total_Servicos
        '
        Me.stsi_Total_Servicos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stsi_Total_Servicos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsi_Total_Servicos.Name = "stsi_Total_Servicos"
        Me.stsi_Total_Servicos.Size = New System.Drawing.Size(106, 19)
        Me.stsi_Total_Servicos.Text = "Total de serviços:"
        '
        'pgb_Atualizando_Prazo
        '
        Me.pgb_Atualizando_Prazo.Location = New System.Drawing.Point(19, 233)
        Me.pgb_Atualizando_Prazo.Name = "pgb_Atualizando_Prazo"
        Me.pgb_Atualizando_Prazo.Size = New System.Drawing.Size(1030, 23)
        Me.pgb_Atualizando_Prazo.TabIndex = 55
        Me.pgb_Atualizando_Prazo.Visible = False
        '
        'dtg_Itens
        '
        Me.dtg_Itens.AllowUserToAddRows = False
        Me.dtg_Itens.AllowUserToDeleteRows = False
        Me.dtg_Itens.AllowUserToResizeColumns = False
        Me.dtg_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Itens.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Itens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Itens.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_Itens.Enabled = False
        Me.dtg_Itens.Location = New System.Drawing.Point(15, 65)
        Me.dtg_Itens.MultiSelect = False
        Me.dtg_Itens.Name = "dtg_Itens"
        Me.dtg_Itens.ReadOnly = True
        Me.dtg_Itens.RowHeadersVisible = False
        Me.dtg_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Itens.Size = New System.Drawing.Size(1037, 193)
        Me.dtg_Itens.TabIndex = 1
        '
        'mnu_Itens
        '
        Me.mnu_Itens.AutoSize = False
        Me.mnu_Itens.BackColor = System.Drawing.Color.Gainsboro
        Me.mnu_Itens.Dock = System.Windows.Forms.DockStyle.None
        Me.mnu_Itens.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnui_Adicionar_Item, Me.mnui_Editar_Item, Me.mnui_Remover_Item, Me.mnui_Importar, Me.mnui_Exportar, Me.mnui_Prazos, Me.mnui_Frete, Me.tsmi_Desconto, Me.mnui_Colunas, Me.tsmi_Subir_Ordem, Me.tsmi_Abaixar_Ordem})
        Me.mnu_Itens.Location = New System.Drawing.Point(15, 26)
        Me.mnu_Itens.Name = "mnu_Itens"
        Me.mnu_Itens.Size = New System.Drawing.Size(1037, 36)
        Me.mnu_Itens.TabIndex = 0
        Me.mnu_Itens.Text = "MenuStrip1"
        '
        'mnui_Adicionar_Item
        '
        Me.mnui_Adicionar_Item.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Peca, Me.tsmi_Servico, Me.tsmi_Deslocamento})
        Me.mnui_Adicionar_Item.Image = Global.Eurolift_Services.My.Resources.Resources.plus_black_symbol
        Me.mnui_Adicionar_Item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Adicionar_Item.Name = "mnui_Adicionar_Item"
        Me.mnui_Adicionar_Item.Size = New System.Drawing.Size(92, 32)
        Me.mnui_Adicionar_Item.Text = "  Adicionar"
        '
        'tsmi_Peca
        '
        Me.tsmi_Peca.Name = "tsmi_Peca"
        Me.tsmi_Peca.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Peca.Text = "Peça"
        '
        'tsmi_Servico
        '
        Me.tsmi_Servico.Name = "tsmi_Servico"
        Me.tsmi_Servico.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Servico.Text = "Serviço"
        '
        'tsmi_Deslocamento
        '
        Me.tsmi_Deslocamento.Name = "tsmi_Deslocamento"
        Me.tsmi_Deslocamento.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Deslocamento.Text = "Deslocamento"
        '
        'mnui_Editar_Item
        '
        Me.mnui_Editar_Item.Image = Global.Eurolift_Services.My.Resources.Resources.edit
        Me.mnui_Editar_Item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Editar_Item.Name = "mnui_Editar_Item"
        Me.mnui_Editar_Item.Size = New System.Drawing.Size(71, 32)
        Me.mnui_Editar_Item.Text = "  Editar"
        '
        'mnui_Remover_Item
        '
        Me.mnui_Remover_Item.Image = Global.Eurolift_Services.My.Resources.Resources.minus_symbol
        Me.mnui_Remover_Item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Remover_Item.Name = "mnui_Remover_Item"
        Me.mnui_Remover_Item.Size = New System.Drawing.Size(88, 32)
        Me.mnui_Remover_Item.Text = "  Remover"
        '
        'mnui_Importar
        '
        Me.mnui_Importar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Importar_Kion, Me.tsmi_Importar_TVH, Me.tsmi_Importar_Arquivo})
        Me.mnui_Importar.Image = Global.Eurolift_Services.My.Resources.Resources.import__4_
        Me.mnui_Importar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Importar.Name = "mnui_Importar"
        Me.mnui_Importar.Size = New System.Drawing.Size(87, 32)
        Me.mnui_Importar.Text = "  Importar"
        '
        'tsmi_Importar_Kion
        '
        Me.tsmi_Importar_Kion.Name = "tsmi_Importar_Kion"
        Me.tsmi_Importar_Kion.Size = New System.Drawing.Size(156, 22)
        Me.tsmi_Importar_Kion.Text = "Kion"
        '
        'tsmi_Importar_TVH
        '
        Me.tsmi_Importar_TVH.Name = "tsmi_Importar_TVH"
        Me.tsmi_Importar_TVH.Size = New System.Drawing.Size(156, 22)
        Me.tsmi_Importar_TVH.Text = "TVH"
        '
        'tsmi_Importar_Arquivo
        '
        Me.tsmi_Importar_Arquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubstituirToolStripMenuItem, Me.AdicionarToolStripMenuItem})
        Me.tsmi_Importar_Arquivo.Name = "tsmi_Importar_Arquivo"
        Me.tsmi_Importar_Arquivo.Size = New System.Drawing.Size(156, 22)
        Me.tsmi_Importar_Arquivo.Text = "Arquivo padrão"
        Me.tsmi_Importar_Arquivo.Visible = False
        '
        'SubstituirToolStripMenuItem
        '
        Me.SubstituirToolStripMenuItem.Name = "SubstituirToolStripMenuItem"
        Me.SubstituirToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SubstituirToolStripMenuItem.Text = "Substituir"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar"
        '
        'mnui_Exportar
        '
        Me.mnui_Exportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Exportar_Kion, Me.TabelaCompletaToolStripMenuItem})
        Me.mnui_Exportar.Image = Global.Eurolift_Services.My.Resources.Resources.export__1_
        Me.mnui_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Exportar.Name = "mnui_Exportar"
        Me.mnui_Exportar.Size = New System.Drawing.Size(85, 32)
        Me.mnui_Exportar.Text = "  Exportar"
        '
        'tsmi_Exportar_Kion
        '
        Me.tsmi_Exportar_Kion.Name = "tsmi_Exportar_Kion"
        Me.tsmi_Exportar_Kion.Size = New System.Drawing.Size(183, 22)
        Me.tsmi_Exportar_Kion.Text = "Formato Fluig (Kion)"
        '
        'TabelaCompletaToolStripMenuItem
        '
        Me.TabelaCompletaToolStripMenuItem.Name = "TabelaCompletaToolStripMenuItem"
        Me.TabelaCompletaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TabelaCompletaToolStripMenuItem.Text = "Tabela completa"
        '
        'mnui_Prazos
        '
        Me.mnui_Prazos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Apenas_Completo, Me.tsmi_Apenas_Abreviado, Me.tsmi_Por_Peca})
        Me.mnui_Prazos.Image = Global.Eurolift_Services.My.Resources.Resources.refresh_page_option
        Me.mnui_Prazos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Prazos.Name = "mnui_Prazos"
        Me.mnui_Prazos.Size = New System.Drawing.Size(119, 32)
        Me.mnui_Prazos.Text = "  Atualizar prazo"
        '
        'tsmi_Apenas_Completo
        '
        Me.tsmi_Apenas_Completo.Name = "tsmi_Apenas_Completo"
        Me.tsmi_Apenas_Completo.Size = New System.Drawing.Size(208, 22)
        Me.tsmi_Apenas_Completo.Text = "Apenas código completo"
        Me.tsmi_Apenas_Completo.ToolTipText = "Selecionando essa opção o item só será procurado no estoque pelo seu código compl" &
    "eto, retornando 0 caso não o encontre."
        '
        'tsmi_Apenas_Abreviado
        '
        Me.tsmi_Apenas_Abreviado.Name = "tsmi_Apenas_Abreviado"
        Me.tsmi_Apenas_Abreviado.Size = New System.Drawing.Size(208, 22)
        Me.tsmi_Apenas_Abreviado.Text = "Apenas código abreviado"
        Me.tsmi_Apenas_Abreviado.ToolTipText = "Selecionando essa opção o item só será procurado no estoque pelo seu código abrev" &
    "iado, retornando 0 caso não o encontre."
        '
        'tsmi_Por_Peca
        '
        Me.tsmi_Por_Peca.Name = "tsmi_Por_Peca"
        Me.tsmi_Por_Peca.Size = New System.Drawing.Size(208, 22)
        Me.tsmi_Por_Peca.Text = "Decidir por peça"
        Me.tsmi_Por_Peca.ToolTipText = resources.GetString("tsmi_Por_Peca.ToolTipText")
        '
        'mnui_Frete
        '
        Me.mnui_Frete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Inserir_Frete_Valor_Igual, Me.tsmi_Inserir_Frete_Valor_Dividido})
        Me.mnui_Frete.Image = Global.Eurolift_Services.My.Resources.Resources.delivery_truck_silhouette
        Me.mnui_Frete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Frete.Name = "mnui_Frete"
        Me.mnui_Frete.Size = New System.Drawing.Size(67, 32)
        Me.mnui_Frete.Text = "  Frete"
        Me.mnui_Frete.ToolTipText = "Define o frete para TODOS os itens"
        '
        'tsmi_Inserir_Frete_Valor_Igual
        '
        Me.tsmi_Inserir_Frete_Valor_Igual.Name = "tsmi_Inserir_Frete_Valor_Igual"
        Me.tsmi_Inserir_Frete_Valor_Igual.Size = New System.Drawing.Size(231, 22)
        Me.tsmi_Inserir_Frete_Valor_Igual.Text = "Valor igual para todos os itens"
        '
        'tsmi_Inserir_Frete_Valor_Dividido
        '
        Me.tsmi_Inserir_Frete_Valor_Dividido.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Valor_Dividido_Por_Preco, Me.tsmi_Valor_Dividido_Por_Quantidade, Me.PorValorTotalToolStripMenuItem})
        Me.tsmi_Inserir_Frete_Valor_Dividido.Name = "tsmi_Inserir_Frete_Valor_Dividido"
        Me.tsmi_Inserir_Frete_Valor_Dividido.Size = New System.Drawing.Size(231, 22)
        Me.tsmi_Inserir_Frete_Valor_Dividido.Text = "Valor dividido"
        '
        'tsmi_Valor_Dividido_Por_Preco
        '
        Me.tsmi_Valor_Dividido_Por_Preco.Name = "tsmi_Valor_Dividido_Por_Preco"
        Me.tsmi_Valor_Dividido_Por_Preco.Size = New System.Drawing.Size(213, 22)
        Me.tsmi_Valor_Dividido_Por_Preco.Text = "Por preço unitário do item"
        '
        'tsmi_Valor_Dividido_Por_Quantidade
        '
        Me.tsmi_Valor_Dividido_Por_Quantidade.Name = "tsmi_Valor_Dividido_Por_Quantidade"
        Me.tsmi_Valor_Dividido_Por_Quantidade.Size = New System.Drawing.Size(213, 22)
        Me.tsmi_Valor_Dividido_Por_Quantidade.Text = "Por quantidade do item"
        '
        'PorValorTotalToolStripMenuItem
        '
        Me.PorValorTotalToolStripMenuItem.Name = "PorValorTotalToolStripMenuItem"
        Me.PorValorTotalToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PorValorTotalToolStripMenuItem.Text = "Por preço total"
        '
        'tsmi_Desconto
        '
        Me.tsmi_Desconto.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustoToolStripMenuItem, Me.FinalToolStripMenuItem})
        Me.tsmi_Desconto.Image = Global.Eurolift_Services.My.Resources.Resources.discount
        Me.tsmi_Desconto.Name = "tsmi_Desconto"
        Me.tsmi_Desconto.Size = New System.Drawing.Size(91, 32)
        Me.tsmi_Desconto.Text = "  Desconto"
        Me.tsmi_Desconto.ToolTipText = "Define o desconto para TODOS os itens"
        '
        'CustoToolStripMenuItem
        '
        Me.CustoToolStripMenuItem.Name = "CustoToolStripMenuItem"
        Me.CustoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CustoToolStripMenuItem.Text = "Desconto no custo"
        Me.CustoToolStripMenuItem.ToolTipText = "Define o desconto no custo - Apenas para o tipo de item 'Peça'"
        '
        'FinalToolStripMenuItem
        '
        Me.FinalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.FinalToolStripMenuItem.Name = "FinalToolStripMenuItem"
        Me.FinalToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.FinalToolStripMenuItem.Text = "Desconto no valor final"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem1.Text = "Apenas peças"
        Me.ToolStripMenuItem1.ToolTipText = "Define o desconto no valor final - Apenas para peças"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem2.Text = "Apenas serviços"
        Me.ToolStripMenuItem2.ToolTipText = "Define o desconto no valor final - Apenas para serviços"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem3.Text = "Apenas deslocamento"
        Me.ToolStripMenuItem3.ToolTipText = "Define o desconto no valor final - Apenas para deslocamento"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem4.Text = "Todos os itens"
        Me.ToolStripMenuItem4.ToolTipText = "Define o desconto no valor final - Para todos os itens"
        '
        'mnui_Colunas
        '
        Me.mnui_Colunas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Todas, Me.tsmi_Outros_Dados_Iniciais, Me.tsmi_Calculos, Me.tsmi_Quantidade_Estoque})
        Me.mnui_Colunas.Image = Global.Eurolift_Services.My.Resources.Resources.table_grid
        Me.mnui_Colunas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Colunas.Name = "mnui_Colunas"
        Me.mnui_Colunas.Size = New System.Drawing.Size(84, 32)
        Me.mnui_Colunas.Text = "  Colunas"
        '
        'tsmi_Todas
        '
        Me.tsmi_Todas.Name = "tsmi_Todas"
        Me.tsmi_Todas.Size = New System.Drawing.Size(227, 22)
        Me.tsmi_Todas.Text = "Exibir todas as colunas extras"
        '
        'tsmi_Outros_Dados_Iniciais
        '
        Me.tsmi_Outros_Dados_Iniciais.Name = "tsmi_Outros_Dados_Iniciais"
        Me.tsmi_Outros_Dados_Iniciais.Size = New System.Drawing.Size(227, 22)
        Me.tsmi_Outros_Dados_Iniciais.Text = "Exibir outros dados iniciais"
        '
        'tsmi_Calculos
        '
        Me.tsmi_Calculos.Name = "tsmi_Calculos"
        Me.tsmi_Calculos.Size = New System.Drawing.Size(227, 22)
        Me.tsmi_Calculos.Text = "Exibir cálculos"
        '
        'tsmi_Quantidade_Estoque
        '
        Me.tsmi_Quantidade_Estoque.Name = "tsmi_Quantidade_Estoque"
        Me.tsmi_Quantidade_Estoque.Size = New System.Drawing.Size(227, 22)
        Me.tsmi_Quantidade_Estoque.Text = "Exibir quantidade de estoque"
        '
        'tsmi_Subir_Ordem
        '
        Me.tsmi_Subir_Ordem.Image = Global.Eurolift_Services.My.Resources.Resources.caret_arrow_up
        Me.tsmi_Subir_Ordem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmi_Subir_Ordem.Name = "tsmi_Subir_Ordem"
        Me.tsmi_Subir_Ordem.Size = New System.Drawing.Size(68, 32)
        Me.tsmi_Subir_Ordem.Text = "  Subir"
        '
        'tsmi_Abaixar_Ordem
        '
        Me.tsmi_Abaixar_Ordem.Image = Global.Eurolift_Services.My.Resources.Resources.caret_down
        Me.tsmi_Abaixar_Ordem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmi_Abaixar_Ordem.Name = "tsmi_Abaixar_Ordem"
        Me.tsmi_Abaixar_Ordem.Size = New System.Drawing.Size(76, 32)
        Me.tsmi_Abaixar_Ordem.Text = "  Descer"
        '
        'mnu_Proposta
        '
        Me.mnu_Proposta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnui_Salvar, Me.mnui_Editar, Me.mnui_Revisar, Me.mnui_Deletar, Me.mnui_Visualizar, Me.mnui_Cancelar})
        Me.mnu_Proposta.Location = New System.Drawing.Point(0, 0)
        Me.mnu_Proposta.Name = "mnu_Proposta"
        Me.mnu_Proposta.Size = New System.Drawing.Size(1106, 24)
        Me.mnu_Proposta.TabIndex = 1
        Me.mnu_Proposta.Text = "MenuStrip1"
        '
        'mnui_Salvar
        '
        Me.mnui_Salvar.Image = Global.Eurolift_Services.My.Resources.Resources.save_file_option
        Me.mnui_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Salvar.Name = "mnui_Salvar"
        Me.mnui_Salvar.Size = New System.Drawing.Size(72, 20)
        Me.mnui_Salvar.Text = "  Salvar"
        '
        'mnui_Editar
        '
        Me.mnui_Editar.Image = Global.Eurolift_Services.My.Resources.Resources.font_selection_editor
        Me.mnui_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Editar.Name = "mnui_Editar"
        Me.mnui_Editar.Size = New System.Drawing.Size(71, 20)
        Me.mnui_Editar.Text = "  Editar"
        '
        'mnui_Revisar
        '
        Me.mnui_Revisar.Image = Global.Eurolift_Services.My.Resources.Resources.writing
        Me.mnui_Revisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Revisar.Name = "mnui_Revisar"
        Me.mnui_Revisar.Size = New System.Drawing.Size(78, 20)
        Me.mnui_Revisar.Text = "  Revisar"
        '
        'mnui_Deletar
        '
        Me.mnui_Deletar.Image = Global.Eurolift_Services.My.Resources.Resources.trash
        Me.mnui_Deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Deletar.Name = "mnui_Deletar"
        Me.mnui_Deletar.Size = New System.Drawing.Size(78, 20)
        Me.mnui_Deletar.Text = "  Deletar"
        Me.mnui_Deletar.Visible = False
        '
        'mnui_Visualizar
        '
        Me.mnui_Visualizar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Exibir_Codigo, Me.tsmi_Nao_Exibir_Codigo})
        Me.mnui_Visualizar.Image = Global.Eurolift_Services.My.Resources.Resources.pdf_file_format_symbol
        Me.mnui_Visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Visualizar.Name = "mnui_Visualizar"
        Me.mnui_Visualizar.Size = New System.Drawing.Size(90, 20)
        Me.mnui_Visualizar.Text = "  Visualizar"
        '
        'tsmi_Exibir_Codigo
        '
        Me.tsmi_Exibir_Codigo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Apenas_Codigo_Atual, Me.tsmi_Todos_Os_Codigos})
        Me.tsmi_Exibir_Codigo.Name = "tsmi_Exibir_Codigo"
        Me.tsmi_Exibir_Codigo.Size = New System.Drawing.Size(168, 22)
        Me.tsmi_Exibir_Codigo.Text = "Exibir código"
        '
        'tsmi_Apenas_Codigo_Atual
        '
        Me.tsmi_Apenas_Codigo_Atual.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Atual_Abreviado, Me.tsmi_Atual_Completo})
        Me.tsmi_Apenas_Codigo_Atual.Name = "tsmi_Apenas_Codigo_Atual"
        Me.tsmi_Apenas_Codigo_Atual.Size = New System.Drawing.Size(192, 22)
        Me.tsmi_Apenas_Codigo_Atual.Text = "Apenas o código atual"
        '
        'tsmi_Atual_Abreviado
        '
        Me.tsmi_Atual_Abreviado.Name = "tsmi_Atual_Abreviado"
        Me.tsmi_Atual_Abreviado.Size = New System.Drawing.Size(128, 22)
        Me.tsmi_Atual_Abreviado.Text = "Abreviado"
        '
        'tsmi_Atual_Completo
        '
        Me.tsmi_Atual_Completo.Name = "tsmi_Atual_Completo"
        Me.tsmi_Atual_Completo.Size = New System.Drawing.Size(128, 22)
        Me.tsmi_Atual_Completo.Text = "Completo"
        '
        'tsmi_Todos_Os_Codigos
        '
        Me.tsmi_Todos_Os_Codigos.Name = "tsmi_Todos_Os_Codigos"
        Me.tsmi_Todos_Os_Codigos.Size = New System.Drawing.Size(192, 22)
        Me.tsmi_Todos_Os_Codigos.Text = "Todos os códigos"
        '
        'tsmi_Nao_Exibir_Codigo
        '
        Me.tsmi_Nao_Exibir_Codigo.Name = "tsmi_Nao_Exibir_Codigo"
        Me.tsmi_Nao_Exibir_Codigo.Size = New System.Drawing.Size(168, 22)
        Me.tsmi_Nao_Exibir_Codigo.Text = "Não exibir código"
        '
        'mnui_Cancelar
        '
        Me.mnui_Cancelar.Image = Global.Eurolift_Services.My.Resources.Resources._error
        Me.mnui_Cancelar.Name = "mnui_Cancelar"
        Me.mnui_Cancelar.Size = New System.Drawing.Size(87, 20)
        Me.mnui_Cancelar.Text = "  Cancelar"
        Me.mnui_Cancelar.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl_Envio, Me.tssl_Aprovacao, Me.tssl_Origem, Me.tssl_Revisao})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 644)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1106, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssl_Envio
        '
        Me.tssl_Envio.Name = "tssl_Envio"
        Me.tssl_Envio.Size = New System.Drawing.Size(159, 17)
        Me.tssl_Envio.Text = "Enviada em 25/10/2020 11:35"
        '
        'tssl_Aprovacao
        '
        Me.tssl_Aprovacao.Name = "tssl_Aprovacao"
        Me.tssl_Aprovacao.Size = New System.Drawing.Size(169, 17)
        Me.tssl_Aprovacao.Text = "Aprovada em 25/10/2020 13:24"
        '
        'tssl_Origem
        '
        Me.tssl_Origem.Name = "tssl_Origem"
        Me.tssl_Origem.Size = New System.Drawing.Size(158, 17)
        Me.tssl_Origem.Text = "Revisão da proposta XXXXXX"
        '
        'tssl_Revisao
        '
        Me.tssl_Revisao.Name = "tssl_Revisao"
        Me.tssl_Revisao.Size = New System.Drawing.Size(293, 17)
        Me.tssl_Revisao.Text = "Revisada em 17/11/2020 21:29 código da revisão xxxxx"
        '
        'ttp_Prazo
        '
        Me.ttp_Prazo.IsBalloon = True
        Me.ttp_Prazo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttp_Prazo.ToolTipTitle = "Importar"
        '
        'cms_Datagrid
        '
        Me.cms_Datagrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Apenas_Este_Item, Me.tsmi_Todos_Itens})
        Me.cms_Datagrid.Name = "ContextMenuStrip1"
        Me.cms_Datagrid.Size = New System.Drawing.Size(165, 48)
        Me.cms_Datagrid.Text = "Alterar todos"
        '
        'tsmi_Apenas_Este_Item
        '
        Me.tsmi_Apenas_Este_Item.Name = "tsmi_Apenas_Este_Item"
        Me.tsmi_Apenas_Este_Item.Size = New System.Drawing.Size(164, 22)
        Me.tsmi_Apenas_Este_Item.Text = "Apenas este item"
        '
        'tsmi_Todos_Itens
        '
        Me.tsmi_Todos_Itens.Name = "tsmi_Todos_Itens"
        Me.tsmi_Todos_Itens.Size = New System.Drawing.Size(164, 22)
        Me.tsmi_Todos_Itens.Text = "Todos os itens"
        '
        'txt_id_filial
        '
        Me.txt_id_filial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_filial.Location = New System.Drawing.Point(1243, 309)
        Me.txt_id_filial.Name = "txt_id_filial"
        Me.txt_id_filial.Size = New System.Drawing.Size(108, 20)
        Me.txt_id_filial.TabIndex = 42
        Me.txt_id_filial.Visible = False
        '
        'txt_item_excluido
        '
        Me.txt_item_excluido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item_excluido.Location = New System.Drawing.Point(1243, 263)
        Me.txt_item_excluido.Name = "txt_item_excluido"
        Me.txt_item_excluido.Size = New System.Drawing.Size(108, 20)
        Me.txt_item_excluido.TabIndex = 43
        Me.txt_item_excluido.Visible = False
        '
        'txt_atualizou_prazo
        '
        Me.txt_atualizou_prazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_atualizou_prazo.Location = New System.Drawing.Point(1243, 351)
        Me.txt_atualizou_prazo.Name = "txt_atualizou_prazo"
        Me.txt_atualizou_prazo.Size = New System.Drawing.Size(108, 20)
        Me.txt_atualizou_prazo.TabIndex = 44
        Me.txt_atualizou_prazo.Visible = False
        '
        'grp_Outros
        '
        Me.grp_Outros.Controls.Add(Me.txt_Comentarios)
        Me.grp_Outros.Controls.Add(Me.lbl_Comentarios)
        Me.grp_Outros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Outros.Location = New System.Drawing.Point(6, 214)
        Me.grp_Outros.Name = "grp_Outros"
        Me.grp_Outros.Size = New System.Drawing.Size(1066, 75)
        Me.grp_Outros.TabIndex = 6
        Me.grp_Outros.TabStop = False
        Me.grp_Outros.Text = "Outros"
        '
        'txt_Comentarios
        '
        Me.txt_Comentarios.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Comentarios.Location = New System.Drawing.Point(14, 38)
        Me.txt_Comentarios.Name = "txt_Comentarios"
        Me.txt_Comentarios.Size = New System.Drawing.Size(1038, 20)
        Me.txt_Comentarios.TabIndex = 1
        '
        'lbl_Comentarios
        '
        Me.lbl_Comentarios.AutoSize = True
        Me.lbl_Comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Comentarios.Location = New System.Drawing.Point(12, 22)
        Me.lbl_Comentarios.Name = "lbl_Comentarios"
        Me.lbl_Comentarios.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Comentarios.TabIndex = 0
        Me.lbl_Comentarios.Text = "Comentários"
        '
        'img_List_16x16
        '
        Me.img_List_16x16.ImageStream = CType(resources.GetObject("img_List_16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_List_16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.img_List_16x16.Images.SetKeyName(0, "add-square-button.png")
        Me.img_List_16x16.Images.SetKeyName(1, "adjust-contrast.png")
        Me.img_List_16x16.Images.SetKeyName(2, "align-justify.png")
        Me.img_List_16x16.Images.SetKeyName(3, "align-to-left.png")
        Me.img_List_16x16.Images.SetKeyName(4, "align-to-right.png")
        Me.img_List_16x16.Images.SetKeyName(5, "ambulance.png")
        Me.img_List_16x16.Images.SetKeyName(6, "anchor-shape.png")
        Me.img_List_16x16.Images.SetKeyName(7, "android-character-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(8, "angle-arrow-down.png")
        Me.img_List_16x16.Images.SetKeyName(9, "angle-arrow-pointing-to-right.png")
        Me.img_List_16x16.Images.SetKeyName(10, "angle-pointing-to-left.png")
        Me.img_List_16x16.Images.SetKeyName(11, "apple-logo.png")
        Me.img_List_16x16.Images.SetKeyName(12, "archive-black-box.png")
        Me.img_List_16x16.Images.SetKeyName(13, "arrow-angle-pointing-down.png")
        Me.img_List_16x16.Images.SetKeyName(14, "arrow-down-on-black-circular-background.png")
        Me.img_List_16x16.Images.SetKeyName(15, "arrowhead-pointing-to-the-right.png")
        Me.img_List_16x16.Images.SetKeyName(16, "arrowhead-pointing-up-inside-a-square-box-outline.png")
        Me.img_List_16x16.Images.SetKeyName(17, "arrowheads-pointing-to-the-left.png")
        Me.img_List_16x16.Images.SetKeyName(18, "arrow-pointing-down.png")
        Me.img_List_16x16.Images.SetKeyName(19, "arrow-pointing-right-in-a-circle.png")
        Me.img_List_16x16.Images.SetKeyName(20, "arrow-pointing-to-left.png")
        Me.img_List_16x16.Images.SetKeyName(21, "arrow-pointing-to-right.png")
        Me.img_List_16x16.Images.SetKeyName(22, "arrow-up.png")
        Me.img_List_16x16.Images.SetKeyName(23, "arrow-up-on-a-black-circle-background.png")
        Me.img_List_16x16.Images.SetKeyName(24, "asterisk.png")
        Me.img_List_16x16.Images.SetKeyName(25, "ban-circle-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(26, "barcode.png")
        Me.img_List_16x16.Images.SetKeyName(27, "bar-graph-on-a-rectangle.png")
        Me.img_List_16x16.Images.SetKeyName(28, "beaker.png")
        Me.img_List_16x16.Images.SetKeyName(29, "beer-jar-black-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(30, "bell-musical-tool.png")
        Me.img_List_16x16.Images.SetKeyName(31, "bitbucket-logotype-camera-lens-in-perspective.png")
        Me.img_List_16x16.Images.SetKeyName(32, "bitbucket-sign.png")
        Me.img_List_16x16.Images.SetKeyName(33, "bitcoin-logo.png")
        Me.img_List_16x16.Images.SetKeyName(34, "blank-file.png")
        Me.img_List_16x16.Images.SetKeyName(35, "bold-text-option.png")
        Me.img_List_16x16.Images.SetKeyName(36, "book.png")
        Me.img_List_16x16.Images.SetKeyName(37, "bookmark-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(38, "bookmark-white.png")
        Me.img_List_16x16.Images.SetKeyName(39, "branch-with-leaves-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(40, "briefcase.png")
        Me.img_List_16x16.Images.SetKeyName(41, "bug.png")
        Me.img_List_16x16.Images.SetKeyName(42, "building-front.png")
        Me.img_List_16x16.Images.SetKeyName(43, "bull-horn-announcer.png")
        Me.img_List_16x16.Images.SetKeyName(44, "bullseye.png")
        Me.img_List_16x16.Images.SetKeyName(45, "calendar-page-empty.png")
        Me.img_List_16x16.Images.SetKeyName(46, "calendar-with-spring-binder-and-date-blocks.png")
        Me.img_List_16x16.Images.SetKeyName(47, "camera-retro.png")
        Me.img_List_16x16.Images.SetKeyName(48, "caret-arrow-up.png")
        Me.img_List_16x16.Images.SetKeyName(49, "caret-down.png")
        Me.img_List_16x16.Images.SetKeyName(50, "center-text-alignment.png")
        Me.img_List_16x16.Images.SetKeyName(51, "certificate-shape.png")
        Me.img_List_16x16.Images.SetKeyName(52, "check.png")
        Me.img_List_16x16.Images.SetKeyName(53, "check-box-empty.png")
        Me.img_List_16x16.Images.SetKeyName(54, "checked-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(55, "checkered-raised-flag.png")
        Me.img_List_16x16.Images.SetKeyName(56, "check-mark.png")
        Me.img_List_16x16.Images.SetKeyName(57, "check-sign-in-a-rounded-black-square.png")
        Me.img_List_16x16.Images.SetKeyName(58, "chevron-arrow-down.png")
        Me.img_List_16x16.Images.SetKeyName(59, "chevron-arrow-up.png")
        Me.img_List_16x16.Images.SetKeyName(60, "chevron-pointing-to-the-left.png")
        Me.img_List_16x16.Images.SetKeyName(61, "chevron-sign-down.png")
        Me.img_List_16x16.Images.SetKeyName(62, "chevron-sign-left.png")
        Me.img_List_16x16.Images.SetKeyName(63, "chevron-sign-to-right.png")
        Me.img_List_16x16.Images.SetKeyName(64, "chevron-up.png")
        Me.img_List_16x16.Images.SetKeyName(65, "circle-shape-outline.png")
        Me.img_List_16x16.Images.SetKeyName(66, "circle-with-an-arrow-pointing-to-left.png")
        Me.img_List_16x16.Images.SetKeyName(67, "circular-shape-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(68, "cloud-storage-download.png")
        Me.img_List_16x16.Images.SetKeyName(69, "cloud-storage-uploading-option.png")
        Me.img_List_16x16.Images.SetKeyName(70, "cocktail-glass.png")
        Me.img_List_16x16.Images.SetKeyName(71, "code.png")
        Me.img_List_16x16.Images.SetKeyName(72, "code-fork-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(73, "coffee-cup-on-a-plate-black-silhouettes.png")
        Me.img_List_16x16.Images.SetKeyName(74, "cog-wheel-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(75, "collapse-window-option.png")
        Me.img_List_16x16.Images.SetKeyName(76, "comment-black-oval-bubble-shape.png")
        Me.img_List_16x16.Images.SetKeyName(77, "comments.png")
        Me.img_List_16x16.Images.SetKeyName(78, "comment-white-oval-bubble.png")
        Me.img_List_16x16.Images.SetKeyName(79, "compass-circular-variant.png")
        Me.img_List_16x16.Images.SetKeyName(80, "computer-tablet.png")
        Me.img_List_16x16.Images.SetKeyName(81, "copy-document.png")
        Me.img_List_16x16.Images.SetKeyName(82, "correct-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(83, "couple-of-arrows-changing-places.png")
        Me.img_List_16x16.Images.SetKeyName(84, "credit-card.png")
        Me.img_List_16x16.Images.SetKeyName(85, "crop-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(86, "cross-mark-on-a-black-circle-background.png")
        Me.img_List_16x16.Images.SetKeyName(87, "css-3-logo.png")
        Me.img_List_16x16.Images.SetKeyName(88, "cursor.png")
        Me.img_List_16x16.Images.SetKeyName(89, "cut.png")
        Me.img_List_16x16.Images.SetKeyName(90, "dashboard.png")
        Me.img_List_16x16.Images.SetKeyName(91, "delivery-truck-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(92, "desktop-monitor.png")
        Me.img_List_16x16.Images.SetKeyName(93, "dollar-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(94, "dot-and-circle.png")
        Me.img_List_16x16.Images.SetKeyName(95, "double-angle-pointing-to-right.png")
        Me.img_List_16x16.Images.SetKeyName(96, "double-left-chevron.png")
        Me.img_List_16x16.Images.SetKeyName(97, "double-sided-eraser.png")
        Me.img_List_16x16.Images.SetKeyName(98, "double-strikethrough-option.png")
        Me.img_List_16x16.Images.SetKeyName(99, "down-arrow.png")
        Me.img_List_16x16.Images.SetKeyName(100, "download-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(101, "download-to-storage-drive.png")
        Me.img_List_16x16.Images.SetKeyName(102, "dribbble-logo.png")
        Me.img_List_16x16.Images.SetKeyName(103, "dropbox-logo.png")
        Me.img_List_16x16.Images.SetKeyName(104, "earth-globe.png")
        Me.img_List_16x16.Images.SetKeyName(105, "edit-interface-sign.png")
        Me.img_List_16x16.Images.SetKeyName(106, "eject-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(107, "envelope.png")
        Me.img_List_16x16.Images.SetKeyName(108, "envelope-of-white-paper.png")
        Me.img_List_16x16.Images.SetKeyName(109, "euro-currency-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(110, "exchange-arrows.png")
        Me.img_List_16x16.Images.SetKeyName(111, "exclamation.png")
        Me.img_List_16x16.Images.SetKeyName(112, "exclamation-sign.png")
        Me.img_List_16x16.Images.SetKeyName(113, "external-link-square-with-an-arrow-in-right-diagonal.png")
        Me.img_List_16x16.Images.SetKeyName(114, "external-link-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(115, "eye-open.png")
        Me.img_List_16x16.Images.SetKeyName(116, "eye-with-a-diagonal-line-interface-symbol-for-invisibility.png")
        Me.img_List_16x16.Images.SetKeyName(117, "facebook-logo.png")
        Me.img_List_16x16.Images.SetKeyName(118, "facebook-logo-1.png")
        Me.img_List_16x16.Images.SetKeyName(119, "facetime-button.png")
        Me.img_List_16x16.Images.SetKeyName(120, "fast-forward-arrows.png")
        Me.img_List_16x16.Images.SetKeyName(121, "female-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(122, "fighter-jet-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(123, "file.png")
        Me.img_List_16x16.Images.SetKeyName(124, "film-strip-with-two-photograms.png")
        Me.img_List_16x16.Images.SetKeyName(125, "filter-tool-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(126, "finger-of-a-hand-pointing-to-right-direction.png")
        Me.img_List_16x16.Images.SetKeyName(127, "fire-extinguisher.png")
        Me.img_List_16x16.Images.SetKeyName(128, "fire-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(129, "flag-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(130, "flickr-website-logo-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(131, "fluffy-cloud-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(132, "folder-closed-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(133, "folder-white-shape.png")
        Me.img_List_16x16.Images.SetKeyName(134, "font-selection-editor.png")
        Me.img_List_16x16.Images.SetKeyName(135, "font-symbol-of-letter-a.png")
        Me.img_List_16x16.Images.SetKeyName(136, "fork-and-knife-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(137, "forward-button.png")
        Me.img_List_16x16.Images.SetKeyName(138, "four-black-squares.png")
        Me.img_List_16x16.Images.SetKeyName(139, "foursquare-button.png")
        Me.img_List_16x16.Images.SetKeyName(140, "frown.png")
        Me.img_List_16x16.Images.SetKeyName(141, "fullscreen-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(142, "gamepad-console.png")
        Me.img_List_16x16.Images.SetKeyName(143, "gift-box.png")
        Me.img_List_16x16.Images.SetKeyName(144, "github-character.png")
        Me.img_List_16x16.Images.SetKeyName(145, "github-logo.png")
        Me.img_List_16x16.Images.SetKeyName(146, "github-sign.png")
        Me.img_List_16x16.Images.SetKeyName(147, "gittip-website-logo.png")
        Me.img_List_16x16.Images.SetKeyName(148, "google-plus-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(149, "google-plus-symbol-1.png")
        Me.img_List_16x16.Images.SetKeyName(150, "great-britain-pound.png")
        Me.img_List_16x16.Images.SetKeyName(151, "group-profile-users.png")
        Me.img_List_16x16.Images.SetKeyName(152, "half-star-shape.png")
        Me.img_List_16x16.Images.SetKeyName(153, "hand-finger-pointing-down.png")
        Me.img_List_16x16.Images.SetKeyName(154, "hand-pointing-to-left-direction.png")
        Me.img_List_16x16.Images.SetKeyName(155, "hand-pointing-upward.png")
        Me.img_List_16x16.Images.SetKeyName(156, "hard-drive.png")
        Me.img_List_16x16.Images.SetKeyName(157, "heart-shape-outline.png")
        Me.img_List_16x16.Images.SetKeyName(158, "heart-shape-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(159, "home.png")
        Me.img_List_16x16.Images.SetKeyName(160, "horizontal-resize-option.png")
        Me.img_List_16x16.Images.SetKeyName(161, "hostpital-building.png")
        Me.img_List_16x16.Images.SetKeyName(162, "hotel-letter-h-sign-inside-a-black-rounded-square.png")
        Me.img_List_16x16.Images.SetKeyName(163, "html-5-logo.png")
        Me.img_List_16x16.Images.SetKeyName(164, "inbox.png")
        Me.img_List_16x16.Images.SetKeyName(165, "increase-size-option.png")
        Me.img_List_16x16.Images.SetKeyName(166, "indent-right.png")
        Me.img_List_16x16.Images.SetKeyName(167, "information-button.png")
        Me.img_List_16x16.Images.SetKeyName(168, "information-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(169, "instagram-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(170, "italicize-text.png")
        Me.img_List_16x16.Images.SetKeyName(171, "keyboard.png")
        Me.img_List_16x16.Images.SetKeyName(172, "left-arrow.png")
        Me.img_List_16x16.Images.SetKeyName(173, "left-arrow-1.png")
        Me.img_List_16x16.Images.SetKeyName(174, "left-indentation-option.png")
        Me.img_List_16x16.Images.SetKeyName(175, "legal-hammer.png")
        Me.img_List_16x16.Images.SetKeyName(176, "lemon.png")
        Me.img_List_16x16.Images.SetKeyName(177, "leter-a-inside-a-black-circle.png")
        Me.img_List_16x16.Images.SetKeyName(178, "letter-p-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(179, "level-up.png")
        Me.img_List_16x16.Images.SetKeyName(180, "light-bulb.png")
        Me.img_List_16x16.Images.SetKeyName(181, "lightning-bolt-shadow.png")
        Me.img_List_16x16.Images.SetKeyName(182, "linkedin-letters.png")
        Me.img_List_16x16.Images.SetKeyName(183, "linkedin-sign.png")
        Me.img_List_16x16.Images.SetKeyName(184, "link-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(185, "linux-logo.png")
        Me.img_List_16x16.Images.SetKeyName(186, "list.png")
        Me.img_List_16x16.Images.SetKeyName(187, "listing-option.png")
        Me.img_List_16x16.Images.SetKeyName(188, "list-on-window.png")
        Me.img_List_16x16.Images.SetKeyName(189, "list-with-dots.png")
        Me.img_List_16x16.Images.SetKeyName(190, "long-arrow-pointing-to-left.png")
        Me.img_List_16x16.Images.SetKeyName(191, "long-arrow-pointing-to-the-right.png")
        Me.img_List_16x16.Images.SetKeyName(192, "long-arrow-pointing-up.png")
        Me.img_List_16x16.Images.SetKeyName(193, "magic-wand.png")
        Me.img_List_16x16.Images.SetKeyName(194, "magnifying-glass.png")
        Me.img_List_16x16.Images.SetKeyName(195, "man.png")
        Me.img_List_16x16.Images.SetKeyName(196, "map-marker.png")
        Me.img_List_16x16.Images.SetKeyName(197, "maxcdn-website-logo.png")
        Me.img_List_16x16.Images.SetKeyName(198, "medical-kit.png")
        Me.img_List_16x16.Images.SetKeyName(199, "meh-face-emoticon.png")
        Me.img_List_16x16.Images.SetKeyName(200, "microphone-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(201, "microphone-off.png")
        Me.img_List_16x16.Images.SetKeyName(202, "minus-button.png")
        Me.img_List_16x16.Images.SetKeyName(203, "minus-sign-inside-a-black-circle.png")
        Me.img_List_16x16.Images.SetKeyName(204, "minus-sign-inside-a-black-rounded-square-shape.png")
        Me.img_List_16x16.Images.SetKeyName(205, "minus-sign-on-a-square-outline.png")
        Me.img_List_16x16.Images.SetKeyName(206, "minus-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(207, "mobile-phone.png")
        Me.img_List_16x16.Images.SetKeyName(208, "moon-phase-outline.png")
        Me.img_List_16x16.Images.SetKeyName(209, "move-option.png")
        Me.img_List_16x16.Images.SetKeyName(210, "musical-bell-outline.png")
        Me.img_List_16x16.Images.SetKeyName(211, "music-headphones.png")
        Me.img_List_16x16.Images.SetKeyName(212, "music-note-black-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(213, "nine-black-tiles.png")
        Me.img_List_16x16.Images.SetKeyName(214, "numbered-list.png")
        Me.img_List_16x16.Images.SetKeyName(215, "open-folder.png")
        Me.img_List_16x16.Images.SetKeyName(216, "open-folder-outline.png")
        Me.img_List_16x16.Images.SetKeyName(217, "open-laptop-computer.png")
        Me.img_List_16x16.Images.SetKeyName(218, "open-padlock-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(219, "open-wrench-tool-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(220, "padlock.png")
        Me.img_List_16x16.Images.SetKeyName(221, "padlock-unlock.png")
        Me.img_List_16x16.Images.SetKeyName(222, "paper-bill.png")
        Me.img_List_16x16.Images.SetKeyName(223, "paper-clip-outline.png")
        Me.img_List_16x16.Images.SetKeyName(224, "paper-push-pin.png")
        Me.img_List_16x16.Images.SetKeyName(225, "paste-from-clipboard.png")
        Me.img_List_16x16.Images.SetKeyName(226, "pause-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(227, "pencil.png")
        Me.img_List_16x16.Images.SetKeyName(228, "photo-camera.png")
        Me.img_List_16x16.Images.SetKeyName(229, "picture.png")
        Me.img_List_16x16.Images.SetKeyName(230, "pinterest-logo.png")
        Me.img_List_16x16.Images.SetKeyName(231, "pinterest-sign.png")
        Me.img_List_16x16.Images.SetKeyName(232, "plane.png")
        Me.img_List_16x16.Images.SetKeyName(233, "plant-leaf-with-white-details.png")
        Me.img_List_16x16.Images.SetKeyName(234, "play-button.png")
        Me.img_List_16x16.Images.SetKeyName(235, "play-circle.png")
        Me.img_List_16x16.Images.SetKeyName(236, "play-sign.png")
        Me.img_List_16x16.Images.SetKeyName(237, "play-video-button.png")
        Me.img_List_16x16.Images.SetKeyName(238, "plus-black-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(239, "plus-sign-in-a-black-circle.png")
        Me.img_List_16x16.Images.SetKeyName(240, "plus-symbol-in-a-rounded-black-square.png")
        Me.img_List_16x16.Images.SetKeyName(241, "power-button-off.png")
        Me.img_List_16x16.Images.SetKeyName(242, "printing-tool.png")
        Me.img_List_16x16.Images.SetKeyName(243, "puzzle-piece-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(244, "qr-code.png")
        Me.img_List_16x16.Images.SetKeyName(245, "question-mark-on-a-circular-black-background.png")
        Me.img_List_16x16.Images.SetKeyName(246, "question-sign.png")
        Me.img_List_16x16.Images.SetKeyName(247, "quote-left.png")
        Me.img_List_16x16.Images.SetKeyName(248, "reduced-volume.png")
        Me.img_List_16x16.Images.SetKeyName(249, "refresh-arrow.png")
        Me.img_List_16x16.Images.SetKeyName(250, "refresh-page-option.png")
        Me.img_List_16x16.Images.SetKeyName(251, "remove-button.png")
        Me.img_List_16x16.Images.SetKeyName(252, "remove-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(253, "renren-social-network-of-china-logotype.png")
        Me.img_List_16x16.Images.SetKeyName(254, "reorder-option.png")
        Me.img_List_16x16.Images.SetKeyName(255, "reply.png")
        Me.img_List_16x16.Images.SetKeyName(256, "reply-arrow.png")
        Me.img_List_16x16.Images.SetKeyName(257, "resize-option.png")
        Me.img_List_16x16.Images.SetKeyName(258, "retweet-arrows-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(259, "rewind-button.png")
        Me.img_List_16x16.Images.SetKeyName(260, "right-arrow-in-a-circle.png")
        Me.img_List_16x16.Images.SetKeyName(261, "right-chevron.png")
        Me.img_List_16x16.Images.SetKeyName(262, "right-quotation-mark.png")
        Me.img_List_16x16.Images.SetKeyName(263, "road-perspective.png")
        Me.img_List_16x16.Images.SetKeyName(264, "rounded-black-square-shape.png")
        Me.img_List_16x16.Images.SetKeyName(265, "rss-feed-button.png")
        Me.img_List_16x16.Images.SetKeyName(266, "rss-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(267, "rupee-indian.png")
        Me.img_List_16x16.Images.SetKeyName(268, "save-file-option.png")
        Me.img_List_16x16.Images.SetKeyName(269, "screenshot.png")
        Me.img_List_16x16.Images.SetKeyName(270, "settings.png")
        Me.img_List_16x16.Images.SetKeyName(271, "share-option.png")
        Me.img_List_16x16.Images.SetKeyName(272, "share-post-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(273, "share-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(274, "shield.png")
        Me.img_List_16x16.Images.SetKeyName(275, "shopping-cart-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(276, "signal-bars.png")
        Me.img_List_16x16.Images.SetKeyName(277, "sign-in.png")
        Me.img_List_16x16.Images.SetKeyName(278, "sign-out-option.png")
        Me.img_List_16x16.Images.SetKeyName(279, "sitemap.png")
        Me.img_List_16x16.Images.SetKeyName(280, "skype-logo.png")
        Me.img_List_16x16.Images.SetKeyName(281, "small-rocket-ship-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(282, "smile.png")
        Me.img_List_16x16.Images.SetKeyName(283, "sort-arrows-couple-pointing-up-and-down.png")
        Me.img_List_16x16.Images.SetKeyName(284, "sort-by-alphabet.png")
        Me.img_List_16x16.Images.SetKeyName(285, "sort-by-attributes.png")
        Me.img_List_16x16.Images.SetKeyName(286, "sort-by-attributes-interface-button-option.png")
        Me.img_List_16x16.Images.SetKeyName(287, "sort-by-numeric-order.png")
        Me.img_List_16x16.Images.SetKeyName(288, "sort-by-order.png")
        Me.img_List_16x16.Images.SetKeyName(289, "sort-down.png")
        Me.img_List_16x16.Images.SetKeyName(290, "sort-reverse-alphabetical-order.png")
        Me.img_List_16x16.Images.SetKeyName(291, "sort-up.png")
        Me.img_List_16x16.Images.SetKeyName(292, "speech-bubbles-comment-option.png")
        Me.img_List_16x16.Images.SetKeyName(293, "spinner-of-dots.png")
        Me.img_List_16x16.Images.SetKeyName(294, "square-shape-shadow.png")
        Me.img_List_16x16.Images.SetKeyName(295, "stack-exchange-logo.png")
        Me.img_List_16x16.Images.SetKeyName(296, "stack-exchange-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(297, "star.png")
        Me.img_List_16x16.Images.SetKeyName(298, "star-1.png")
        Me.img_List_16x16.Images.SetKeyName(299, "star-half-empty.png")
        Me.img_List_16x16.Images.SetKeyName(300, "step-backward.png")
        Me.img_List_16x16.Images.SetKeyName(301, "step-forward.png")
        Me.img_List_16x16.Images.SetKeyName(302, "stethoscope.png")
        Me.img_List_16x16.Images.SetKeyName(303, "strikethrough.png")
        Me.img_List_16x16.Images.SetKeyName(304, "suitcase-with-white-details.png")
        Me.img_List_16x16.Images.SetKeyName(305, "sun.png")
        Me.img_List_16x16.Images.SetKeyName(306, "superscript-text-formatting.png")
        Me.img_List_16x16.Images.SetKeyName(307, "table-grid.png")
        Me.img_List_16x16.Images.SetKeyName(308, "tag-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(309, "tags.png")
        Me.img_List_16x16.Images.SetKeyName(310, "tasks-list.png")
        Me.img_List_16x16.Images.SetKeyName(311, "telephone-handle-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(312, "telephone-symbol-button.png")
        Me.img_List_16x16.Images.SetKeyName(313, "terminal.png")
        Me.img_List_16x16.Images.SetKeyName(314, "text-file.png")
        Me.img_List_16x16.Images.SetKeyName(315, "text-file-1.png")
        Me.img_List_16x16.Images.SetKeyName(316, "text-height-adjustment.png")
        Me.img_List_16x16.Images.SetKeyName(317, "text-width.png")
        Me.img_List_16x16.Images.SetKeyName(318, "thin-arrowheads-pointing-down.png")
        Me.img_List_16x16.Images.SetKeyName(319, "three-small-square-shapes.png")
        Me.img_List_16x16.Images.SetKeyName(320, "thumb-down.png")
        Me.img_List_16x16.Images.SetKeyName(321, "thumbs-down-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(322, "thumbs-up.png")
        Me.img_List_16x16.Images.SetKeyName(323, "thumbs-up-hand-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(324, "ticket.png")
        Me.img_List_16x16.Images.SetKeyName(325, "time.png")
        Me.img_List_16x16.Images.SetKeyName(326, "tint-drop.png")
        Me.img_List_16x16.Images.SetKeyName(327, "trash.png")
        Me.img_List_16x16.Images.SetKeyName(328, "trello-website-logo.png")
        Me.img_List_16x16.Images.SetKeyName(329, "trophy.png")
        Me.img_List_16x16.Images.SetKeyName(330, "tumblr-logo.png")
        Me.img_List_16x16.Images.SetKeyName(331, "tumblr-logo-1.png")
        Me.img_List_16x16.Images.SetKeyName(332, "turkish-lire-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(333, "twitter-black-shape.png")
        Me.img_List_16x16.Images.SetKeyName(334, "twitter-sign.png")
        Me.img_List_16x16.Images.SetKeyName(335, "two-columns-layout.png")
        Me.img_List_16x16.Images.SetKeyName(336, "umbrella-black-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(337, "underline-text-option.png")
        Me.img_List_16x16.Images.SetKeyName(338, "undo-arrow.png")
        Me.img_List_16x16.Images.SetKeyName(339, "unlink-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(340, "up-arrow.png")
        Me.img_List_16x16.Images.SetKeyName(341, "up-chevron-button.png")
        Me.img_List_16x16.Images.SetKeyName(342, "upload.png")
        Me.img_List_16x16.Images.SetKeyName(343, "upload-button.png")
        Me.img_List_16x16.Images.SetKeyName(344, "user-md-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(345, "user-shape.png")
        Me.img_List_16x16.Images.SetKeyName(346, "u-shaped-thick-magnet.png")
        Me.img_List_16x16.Images.SetKeyName(347, "vertical-ellipsis.png")
        Me.img_List_16x16.Images.SetKeyName(348, "vertical-resizing-option.png")
        Me.img_List_16x16.Images.SetKeyName(349, "video-play-square-button.png")
        Me.img_List_16x16.Images.SetKeyName(350, "vimeo-square-logo.png")
        Me.img_List_16x16.Images.SetKeyName(351, "vintage-key-outline.png")
        Me.img_List_16x16.Images.SetKeyName(352, "vk-social-network-logo.png")
        Me.img_List_16x16.Images.SetKeyName(353, "volume-off.png")
        Me.img_List_16x16.Images.SetKeyName(354, "volume-up-interface-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(355, "warning-sign-on-a-triangular-background.png")
        Me.img_List_16x16.Images.SetKeyName(356, "weibo-website-logo.png")
        Me.img_List_16x16.Images.SetKeyName(357, "wheelchair.png")
        Me.img_List_16x16.Images.SetKeyName(358, "white-flag-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(359, "windows-logo-silhouette.png")
        Me.img_List_16x16.Images.SetKeyName(360, "x2-symbol-of-a-letter-and-a-number-subscript.png")
        Me.img_List_16x16.Images.SetKeyName(361, "xing-logo.png")
        Me.img_List_16x16.Images.SetKeyName(362, "xing-logotype.png")
        Me.img_List_16x16.Images.SetKeyName(363, "yen-symbol.png")
        Me.img_List_16x16.Images.SetKeyName(364, "youtube-logo.png")
        Me.img_List_16x16.Images.SetKeyName(365, "youtube-logo-1.png")
        Me.img_List_16x16.Images.SetKeyName(366, "youtube-logo-2.png")
        Me.img_List_16x16.Images.SetKeyName(367, "zoom-in.png")
        Me.img_List_16x16.Images.SetKeyName(368, "zoom-out.png")
        Me.img_List_16x16.Images.SetKeyName(369, "xlsx-file-format-extension.png")
        Me.img_List_16x16.Images.SetKeyName(370, "settings (3).png")
        '
        'tbc_Proposta
        '
        Me.tbc_Proposta.Controls.Add(Me.tbp_Dados_Gerais)
        Me.tbc_Proposta.Controls.Add(Me.tbp_Termos)
        Me.tbc_Proposta.Location = New System.Drawing.Point(12, 27)
        Me.tbc_Proposta.Name = "tbc_Proposta"
        Me.tbc_Proposta.SelectedIndex = 0
        Me.tbc_Proposta.Size = New System.Drawing.Size(1090, 614)
        Me.tbc_Proposta.TabIndex = 45
        '
        'tbp_Dados_Gerais
        '
        Me.tbp_Dados_Gerais.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Dados_Gerais.Controls.Add(Me.grp_Solicitante)
        Me.tbp_Dados_Gerais.Controls.Add(Me.grp_Proposta)
        Me.tbp_Dados_Gerais.Controls.Add(Me.grp_Outros)
        Me.tbp_Dados_Gerais.Controls.Add(Me.grp_Faturamento)
        Me.tbp_Dados_Gerais.Controls.Add(Me.grp_Equipamento)
        Me.tbp_Dados_Gerais.Controls.Add(Me.grp_Items)
        Me.tbp_Dados_Gerais.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Dados_Gerais.Name = "tbp_Dados_Gerais"
        Me.tbp_Dados_Gerais.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Dados_Gerais.Size = New System.Drawing.Size(1082, 588)
        Me.tbp_Dados_Gerais.TabIndex = 0
        Me.tbp_Dados_Gerais.Text = "Proposta"
        '
        'tbp_Termos
        '
        Me.tbp_Termos.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Termos.Controls.Add(Me.lbl_Copiar_Termo)
        Me.tbp_Termos.Controls.Add(Me.cbo_Copiar_Termo)
        Me.tbp_Termos.Controls.Add(Me.cbo_Carregar_De)
        Me.tbp_Termos.Controls.Add(Me.lbl_Copiar_De)
        Me.tbp_Termos.Controls.Add(Me.cbo_Copiar_Proposta)
        Me.tbp_Termos.Controls.Add(Me.lbl_Copiar_Proposta)
        Me.tbp_Termos.Controls.Add(Me.lbl_Copiar_Cliente)
        Me.tbp_Termos.Controls.Add(Me.cbo_Copiar_Cliente)
        Me.tbp_Termos.Controls.Add(Me.grp_Termos)
        Me.tbp_Termos.Controls.Add(Me.btn_Confirmar)
        Me.tbp_Termos.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Termos.Name = "tbp_Termos"
        Me.tbp_Termos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Termos.Size = New System.Drawing.Size(1082, 588)
        Me.tbp_Termos.TabIndex = 1
        Me.tbp_Termos.Text = "Termos"
        '
        'lbl_Copiar_Termo
        '
        Me.lbl_Copiar_Termo.AutoSize = True
        Me.lbl_Copiar_Termo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Copiar_Termo.Location = New System.Drawing.Point(149, 12)
        Me.lbl_Copiar_Termo.Name = "lbl_Copiar_Termo"
        Me.lbl_Copiar_Termo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Copiar_Termo.TabIndex = 45
        Me.lbl_Copiar_Termo.Text = "Termo"
        Me.lbl_Copiar_Termo.Visible = False
        '
        'cbo_Copiar_Termo
        '
        Me.cbo_Copiar_Termo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Copiar_Termo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Copiar_Termo.FormattingEnabled = True
        Me.cbo_Copiar_Termo.Location = New System.Drawing.Point(152, 28)
        Me.cbo_Copiar_Termo.Name = "cbo_Copiar_Termo"
        Me.cbo_Copiar_Termo.Size = New System.Drawing.Size(175, 21)
        Me.cbo_Copiar_Termo.TabIndex = 46
        Me.cbo_Copiar_Termo.Visible = False
        '
        'cbo_Carregar_De
        '
        Me.cbo_Carregar_De.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Carregar_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Carregar_De.FormattingEnabled = True
        Me.cbo_Carregar_De.Items.AddRange(New Object() {"Cliente (Atual)", "Cliente (Todos)", "Cliente e proposta", "Termo padrão"})
        Me.cbo_Carregar_De.Location = New System.Drawing.Point(24, 28)
        Me.cbo_Carregar_De.Name = "cbo_Carregar_De"
        Me.cbo_Carregar_De.Size = New System.Drawing.Size(122, 21)
        Me.cbo_Carregar_De.TabIndex = 44
        '
        'lbl_Copiar_De
        '
        Me.lbl_Copiar_De.AutoSize = True
        Me.lbl_Copiar_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Copiar_De.Location = New System.Drawing.Point(21, 12)
        Me.lbl_Copiar_De.Name = "lbl_Copiar_De"
        Me.lbl_Copiar_De.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Copiar_De.TabIndex = 43
        Me.lbl_Copiar_De.Text = "Copiar de"
        '
        'cbo_Copiar_Proposta
        '
        Me.cbo_Copiar_Proposta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Copiar_Proposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Copiar_Proposta.FormattingEnabled = True
        Me.cbo_Copiar_Proposta.Location = New System.Drawing.Point(333, 28)
        Me.cbo_Copiar_Proposta.Name = "cbo_Copiar_Proposta"
        Me.cbo_Copiar_Proposta.Size = New System.Drawing.Size(122, 21)
        Me.cbo_Copiar_Proposta.TabIndex = 41
        Me.cbo_Copiar_Proposta.Visible = False
        '
        'lbl_Copiar_Proposta
        '
        Me.lbl_Copiar_Proposta.AutoSize = True
        Me.lbl_Copiar_Proposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Copiar_Proposta.Location = New System.Drawing.Point(330, 12)
        Me.lbl_Copiar_Proposta.Name = "lbl_Copiar_Proposta"
        Me.lbl_Copiar_Proposta.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Copiar_Proposta.TabIndex = 40
        Me.lbl_Copiar_Proposta.Text = "Proposta"
        Me.lbl_Copiar_Proposta.Visible = False
        '
        'lbl_Copiar_Cliente
        '
        Me.lbl_Copiar_Cliente.AutoSize = True
        Me.lbl_Copiar_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Copiar_Cliente.Location = New System.Drawing.Point(149, 12)
        Me.lbl_Copiar_Cliente.Name = "lbl_Copiar_Cliente"
        Me.lbl_Copiar_Cliente.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Copiar_Cliente.TabIndex = 38
        Me.lbl_Copiar_Cliente.Text = "Cliente"
        Me.lbl_Copiar_Cliente.Visible = False
        '
        'cbo_Copiar_Cliente
        '
        Me.cbo_Copiar_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Copiar_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Copiar_Cliente.FormattingEnabled = True
        Me.cbo_Copiar_Cliente.Location = New System.Drawing.Point(152, 28)
        Me.cbo_Copiar_Cliente.Name = "cbo_Copiar_Cliente"
        Me.cbo_Copiar_Cliente.Size = New System.Drawing.Size(303, 21)
        Me.cbo_Copiar_Cliente.TabIndex = 39
        Me.cbo_Copiar_Cliente.Visible = False
        '
        'grp_Termos
        '
        Me.grp_Termos.Controls.Add(Me.lbl_Texto_Padrao)
        Me.grp_Termos.Controls.Add(Me.txt_Texto_Padrao)
        Me.grp_Termos.Controls.Add(Me.lbl_Observacoes)
        Me.grp_Termos.Controls.Add(Me.txt_Observacoes)
        Me.grp_Termos.Controls.Add(Me.lbl_Prazo_Entrega)
        Me.grp_Termos.Controls.Add(Me.txt_Validade)
        Me.grp_Termos.Controls.Add(Me.lbl_Condicao_Pagamento)
        Me.grp_Termos.Controls.Add(Me.lbl_Validade)
        Me.grp_Termos.Controls.Add(Me.txt_Garantia)
        Me.grp_Termos.Controls.Add(Me.lbl_Garantia)
        Me.grp_Termos.Controls.Add(Me.txt_Prazo_Entrega)
        Me.grp_Termos.Controls.Add(Me.txt_Condicao_Pagamento)
        Me.grp_Termos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Termos.Location = New System.Drawing.Point(10, 61)
        Me.grp_Termos.Name = "grp_Termos"
        Me.grp_Termos.Size = New System.Drawing.Size(1066, 482)
        Me.grp_Termos.TabIndex = 36
        Me.grp_Termos.TabStop = False
        Me.grp_Termos.Text = "Termos da proposta"
        '
        'lbl_Texto_Padrao
        '
        Me.lbl_Texto_Padrao.AutoSize = True
        Me.lbl_Texto_Padrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Texto_Padrao.Location = New System.Drawing.Point(11, 21)
        Me.lbl_Texto_Padrao.Name = "lbl_Texto_Padrao"
        Me.lbl_Texto_Padrao.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Texto_Padrao.TabIndex = 15
        Me.lbl_Texto_Padrao.Text = "Cabeçalho"
        '
        'txt_Texto_Padrao
        '
        Me.txt_Texto_Padrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Texto_Padrao.Location = New System.Drawing.Point(14, 37)
        Me.txt_Texto_Padrao.Multiline = True
        Me.txt_Texto_Padrao.Name = "txt_Texto_Padrao"
        Me.txt_Texto_Padrao.Size = New System.Drawing.Size(1046, 40)
        Me.txt_Texto_Padrao.TabIndex = 17
        '
        'lbl_Observacoes
        '
        Me.lbl_Observacoes.AutoSize = True
        Me.lbl_Observacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Observacoes.Location = New System.Drawing.Point(11, 84)
        Me.lbl_Observacoes.Name = "lbl_Observacoes"
        Me.lbl_Observacoes.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Observacoes.TabIndex = 19
        Me.lbl_Observacoes.Text = "Observações"
        '
        'txt_Observacoes
        '
        Me.txt_Observacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Observacoes.Location = New System.Drawing.Point(14, 100)
        Me.txt_Observacoes.Multiline = True
        Me.txt_Observacoes.Name = "txt_Observacoes"
        Me.txt_Observacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Observacoes.Size = New System.Drawing.Size(1046, 60)
        Me.txt_Observacoes.TabIndex = 20
        '
        'lbl_Prazo_Entrega
        '
        Me.lbl_Prazo_Entrega.AutoSize = True
        Me.lbl_Prazo_Entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prazo_Entrega.Location = New System.Drawing.Point(11, 165)
        Me.lbl_Prazo_Entrega.Name = "lbl_Prazo_Entrega"
        Me.lbl_Prazo_Entrega.Size = New System.Drawing.Size(104, 13)
        Me.lbl_Prazo_Entrega.TabIndex = 21
        Me.lbl_Prazo_Entrega.Text = "Prazo de entrega"
        '
        'txt_Validade
        '
        Me.txt_Validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Validade.Location = New System.Drawing.Point(14, 423)
        Me.txt_Validade.Multiline = True
        Me.txt_Validade.Name = "txt_Validade"
        Me.txt_Validade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Validade.Size = New System.Drawing.Size(1046, 40)
        Me.txt_Validade.TabIndex = 28
        '
        'lbl_Condicao_Pagamento
        '
        Me.lbl_Condicao_Pagamento.AutoSize = True
        Me.lbl_Condicao_Pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Condicao_Pagamento.Location = New System.Drawing.Point(11, 246)
        Me.lbl_Condicao_Pagamento.Name = "lbl_Condicao_Pagamento"
        Me.lbl_Condicao_Pagamento.Size = New System.Drawing.Size(144, 13)
        Me.lbl_Condicao_Pagamento.TabIndex = 23
        Me.lbl_Condicao_Pagamento.Text = "Condição de pagamento"
        '
        'lbl_Validade
        '
        Me.lbl_Validade.AutoSize = True
        Me.lbl_Validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Validade.Location = New System.Drawing.Point(11, 407)
        Me.lbl_Validade.Name = "lbl_Validade"
        Me.lbl_Validade.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Validade.TabIndex = 27
        Me.lbl_Validade.Text = "Validade"
        '
        'txt_Garantia
        '
        Me.txt_Garantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Garantia.Location = New System.Drawing.Point(14, 344)
        Me.txt_Garantia.Multiline = True
        Me.txt_Garantia.Name = "txt_Garantia"
        Me.txt_Garantia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Garantia.Size = New System.Drawing.Size(1046, 60)
        Me.txt_Garantia.TabIndex = 26
        '
        'lbl_Garantia
        '
        Me.lbl_Garantia.AutoSize = True
        Me.lbl_Garantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Garantia.Location = New System.Drawing.Point(11, 327)
        Me.lbl_Garantia.Name = "lbl_Garantia"
        Me.lbl_Garantia.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Garantia.TabIndex = 25
        Me.lbl_Garantia.Text = "Garantia"
        '
        'txt_Prazo_Entrega
        '
        Me.txt_Prazo_Entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prazo_Entrega.Location = New System.Drawing.Point(14, 181)
        Me.txt_Prazo_Entrega.Multiline = True
        Me.txt_Prazo_Entrega.Name = "txt_Prazo_Entrega"
        Me.txt_Prazo_Entrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Prazo_Entrega.Size = New System.Drawing.Size(1046, 60)
        Me.txt_Prazo_Entrega.TabIndex = 22
        '
        'txt_Condicao_Pagamento
        '
        Me.txt_Condicao_Pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Condicao_Pagamento.Location = New System.Drawing.Point(14, 262)
        Me.txt_Condicao_Pagamento.Multiline = True
        Me.txt_Condicao_Pagamento.Name = "txt_Condicao_Pagamento"
        Me.txt_Condicao_Pagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Condicao_Pagamento.Size = New System.Drawing.Size(1046, 60)
        Me.txt_Condicao_Pagamento.TabIndex = 24
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Confirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Confirmar.ImageKey = "correct-symbol.png"
        Me.btn_Confirmar.ImageList = Me.img_List_16x16
        Me.btn_Confirmar.Location = New System.Drawing.Point(461, 26)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Confirmar.TabIndex = 42
        Me.btn_Confirmar.Text = "  Confirmar"
        Me.btn_Confirmar.UseVisualStyleBackColor = True
        Me.btn_Confirmar.Visible = False
        '
        'txt_id_proposta_old
        '
        Me.txt_id_proposta_old.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_proposta_old.Location = New System.Drawing.Point(1104, 341)
        Me.txt_id_proposta_old.MaxLength = 60
        Me.txt_id_proposta_old.Name = "txt_id_proposta_old"
        Me.txt_id_proposta_old.Size = New System.Drawing.Size(113, 20)
        Me.txt_id_proposta_old.TabIndex = 14
        Me.txt_id_proposta_old.Visible = False
        '
        'Proposta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 666)
        Me.Controls.Add(Me.txt_id_proposta_old)
        Me.Controls.Add(Me.tbc_Proposta)
        Me.Controls.Add(Me.txt_atualizou_prazo)
        Me.Controls.Add(Me.txt_item_excluido)
        Me.Controls.Add(Me.txt_id_filial)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnu_Proposta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_Itens
        Me.MaximizeBox = False
        Me.Name = "Proposta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proposta"
        Me.grp_Proposta.ResumeLayout(False)
        Me.grp_Proposta.PerformLayout()
        Me.grp_Faturamento.ResumeLayout(False)
        Me.grp_Faturamento.PerformLayout()
        CType(Me.nud_Nota_Fiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Valor_Faturamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Solicitante.ResumeLayout(False)
        Me.grp_Solicitante.PerformLayout()
        Me.grp_Equipamento.ResumeLayout(False)
        Me.grp_Equipamento.PerformLayout()
        CType(Me.nud_Ordem_Servico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Horimetro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Items.ResumeLayout(False)
        Me.grp_Items.PerformLayout()
        Me.sts_Itens_Proposta.ResumeLayout(False)
        Me.sts_Itens_Proposta.PerformLayout()
        CType(Me.dtg_Itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_Itens.ResumeLayout(False)
        Me.mnu_Itens.PerformLayout()
        Me.mnu_Proposta.ResumeLayout(False)
        Me.mnu_Proposta.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.cms_Datagrid.ResumeLayout(False)
        Me.grp_Outros.ResumeLayout(False)
        Me.grp_Outros.PerformLayout()
        Me.tbc_Proposta.ResumeLayout(False)
        Me.tbp_Dados_Gerais.ResumeLayout(False)
        Me.tbp_Termos.ResumeLayout(False)
        Me.tbp_Termos.PerformLayout()
        Me.grp_Termos.ResumeLayout(False)
        Me.grp_Termos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_Proposta As GroupBox
    Friend WithEvents dtp_Data_Solicitacao As DateTimePicker
    Friend WithEvents lbl_Data_Solicitacao As Label
    Friend WithEvents txt_Codigo_Proposta As TextBox
    Friend WithEvents lbl_Codigo_Proposta As Label
    Friend WithEvents cbo_Prioridade As ComboBox
    Friend WithEvents lbl_Prioridade As Label
    Friend WithEvents cbo_Status As ComboBox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents grp_Faturamento As GroupBox
    Friend WithEvents lbl_Valor_Faturamento As Label
    Friend WithEvents dtp_Data_Faturamento As DateTimePicker
    Friend WithEvents lbl_Data_Faturamento As Label
    Friend WithEvents lbl_Nota_Fiscal As Label
    Friend WithEvents dtp_Data_Envio_Faturamento As DateTimePicker
    Friend WithEvents lbl_Data_Envio_Faturamento As Label
    Friend WithEvents grp_Solicitante As GroupBox
    Friend WithEvents cbo_Cliente As ComboBox
    Friend WithEvents lbl_Cliente As Label
    Friend WithEvents cbo_Contato As ComboBox
    Friend WithEvents lbl_Contato As Label
    Friend WithEvents cbo_Pais As ComboBox
    Friend WithEvents lbl_Pais As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents mkt_Telefone As MaskedTextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Telefone As Label
    Friend WithEvents cbo_Estado As ComboBox
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents cbo_Cidade As ComboBox
    Friend WithEvents lbl_Cidade As Label
    Friend WithEvents grp_Equipamento As GroupBox
    Friend WithEvents cbo_Modelo As ComboBox
    Friend WithEvents lbl_Horimetro As Label
    Friend WithEvents lbl_Modelo As Label
    Friend WithEvents cbo_Ano As ComboBox
    Friend WithEvents lbl_Ano As Label
    Friend WithEvents cbo_Serie As ComboBox
    Friend WithEvents lbl_Serie As Label
    Friend WithEvents cbo_Tipo_Equipamento As ComboBox
    Friend WithEvents lbl_Tipo_Equipamento As Label
    Friend WithEvents cbo_Fabricante As ComboBox
    Friend WithEvents lbl_Fabricante As Label
    Friend WithEvents grp_Items As GroupBox
    Friend WithEvents mnu_Itens As MenuStrip
    Friend WithEvents mnui_Adicionar_Item As ToolStripMenuItem
    Friend WithEvents mnui_Editar_Item As ToolStripMenuItem
    Friend WithEvents mnui_Remover_Item As ToolStripMenuItem
    Friend WithEvents mnui_Importar As ToolStripMenuItem
    Friend WithEvents mnui_Exportar As ToolStripMenuItem
    Friend WithEvents mnui_Prazos As ToolStripMenuItem
    Friend WithEvents mnui_Frete As ToolStripMenuItem
    Friend WithEvents mnui_Colunas As ToolStripMenuItem
    Friend WithEvents mnu_Proposta As MenuStrip
    Friend WithEvents mnui_Salvar As ToolStripMenuItem
    Friend WithEvents mnui_Editar As ToolStripMenuItem
    Friend WithEvents mnui_Deletar As ToolStripMenuItem
    Friend WithEvents mnui_Visualizar As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssl_Envio As ToolStripStatusLabel
    Friend WithEvents tsmi_Exibir_Codigo As ToolStripMenuItem
    Friend WithEvents tsmi_Nao_Exibir_Codigo As ToolStripMenuItem
    Friend WithEvents tssl_Aprovacao As ToolStripStatusLabel
    Friend WithEvents tsmi_Outros_Dados_Iniciais As ToolStripMenuItem
    Friend WithEvents tsmi_Calculos As ToolStripMenuItem
    Friend WithEvents tsmi_Quantidade_Estoque As ToolStripMenuItem
    Friend WithEvents tsmi_Todas As ToolStripMenuItem
    Friend WithEvents sts_Itens_Proposta As StatusStrip
    Friend WithEvents stsi_Total_Peças As ToolStripStatusLabel
    Friend WithEvents stsi_Total_Servicos As ToolStripStatusLabel
    Friend WithEvents nud_Valor_Faturamento As NumericUpDown
    Friend WithEvents nud_Nota_Fiscal As NumericUpDown
    Friend WithEvents nud_Horimetro As NumericUpDown
    Friend WithEvents tsmi_Peca As ToolStripMenuItem
    Friend WithEvents tsmi_Servico As ToolStripMenuItem
    Friend WithEvents tsmi_Deslocamento As ToolStripMenuItem
    Friend WithEvents tsmi_Importar_Kion As ToolStripMenuItem
    Friend WithEvents tsmi_Importar_TVH As ToolStripMenuItem
    Friend WithEvents dtg_Itens As DataGridView
    Friend WithEvents tsmi_Importar_Arquivo As ToolStripMenuItem
    Friend WithEvents tsmi_Apenas_Completo As ToolStripMenuItem
    Friend WithEvents tsmi_Apenas_Abreviado As ToolStripMenuItem
    Friend WithEvents tsmi_Por_Peca As ToolStripMenuItem
    Friend WithEvents ttp_Prazo As ToolTip
    Friend WithEvents SubstituirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_Subir_Ordem As ToolStripMenuItem
    Friend WithEvents tsmi_Abaixar_Ordem As ToolStripMenuItem
    Friend WithEvents tsmi_Exportar_Kion As ToolStripMenuItem
    Friend WithEvents tsmi_Inserir_Frete_Valor_Igual As ToolStripMenuItem
    Friend WithEvents tsmi_Inserir_Frete_Valor_Dividido As ToolStripMenuItem
    Friend WithEvents tsmi_Valor_Dividido_Por_Preco As ToolStripMenuItem
    Friend WithEvents tsmi_Valor_Dividido_Por_Quantidade As ToolStripMenuItem
    Friend WithEvents PorValorTotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tssl_Revisao As ToolStripStatusLabel
    Friend WithEvents tssl_Origem As ToolStripStatusLabel
    Friend WithEvents cms_Datagrid As ContextMenuStrip
    Friend WithEvents tsmi_Todos_Itens As ToolStripMenuItem
    Friend WithEvents tsmi_Apenas_Este_Item As ToolStripMenuItem
    Friend WithEvents mnui_Revisar As ToolStripMenuItem
    Friend WithEvents txt_id_filial As TextBox
    Friend WithEvents txt_item_excluido As TextBox
    Friend WithEvents tsmi_Apenas_Codigo_Atual As ToolStripMenuItem
    Friend WithEvents tsmi_Todos_Os_Codigos As ToolStripMenuItem
    Friend WithEvents tsmi_Atual_Abreviado As ToolStripMenuItem
    Friend WithEvents tsmi_Atual_Completo As ToolStripMenuItem
    Friend WithEvents txt_atualizou_prazo As TextBox
    Friend WithEvents grp_Outros As GroupBox
    Friend WithEvents txt_Comentarios As TextBox
    Friend WithEvents lbl_Comentarios As Label
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents TabelaCompletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnui_Cancelar As ToolStripMenuItem
    Friend WithEvents tbc_Proposta As TabControl
    Friend WithEvents tbp_Dados_Gerais As TabPage
    Friend WithEvents tbp_Termos As TabPage
    Friend WithEvents txt_Validade As TextBox
    Friend WithEvents lbl_Validade As Label
    Friend WithEvents txt_Garantia As TextBox
    Friend WithEvents lbl_Garantia As Label
    Friend WithEvents txt_Condicao_Pagamento As TextBox
    Friend WithEvents txt_Prazo_Entrega As TextBox
    Friend WithEvents lbl_Condicao_Pagamento As Label
    Friend WithEvents lbl_Prazo_Entrega As Label
    Friend WithEvents txt_Observacoes As TextBox
    Friend WithEvents lbl_Observacoes As Label
    Friend WithEvents txt_Texto_Padrao As TextBox
    Friend WithEvents lbl_Texto_Padrao As Label
    Friend WithEvents grp_Termos As GroupBox
    Friend WithEvents txt_id_proposta_old As TextBox
    Friend WithEvents lbl_Atualizando_Prazo As Label
    Friend WithEvents pgb_Atualizando_Prazo As ProgressBar
    Friend WithEvents nud_Ordem_Servico As NumericUpDown
    Friend WithEvents lbl_Ordem_Servico As Label
    Friend WithEvents lbl_Copiar_Termo As Label
    Friend WithEvents cbo_Copiar_Termo As ComboBox
    Friend WithEvents cbo_Carregar_De As ComboBox
    Friend WithEvents lbl_Copiar_De As Label
    Friend WithEvents btn_Confirmar As Button
    Friend WithEvents cbo_Copiar_Proposta As ComboBox
    Friend WithEvents lbl_Copiar_Proposta As Label
    Friend WithEvents lbl_Copiar_Cliente As Label
    Friend WithEvents cbo_Copiar_Cliente As ComboBox
    Friend WithEvents tsmi_Desconto As ToolStripMenuItem
    Friend WithEvents CustoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
