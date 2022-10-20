<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title7 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.mnu_Menu = New System.Windows.Forms.MenuStrip()
        Me.mnui_Ordens_Servico = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Estoque = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Compras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Vendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Nome_Usuario = New System.Windows.Forms.Label()
        Me.lbl_Perfil = New System.Windows.Forms.Label()
        Me.lbl_Filial = New System.Windows.Forms.Label()
        Me.pnl_Usuario = New System.Windows.Forms.Panel()
        Me.sts_Status = New System.Windows.Forms.StatusStrip()
        Me.stsi_Login = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsi_Informacao_Atualizacao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_Nome_Sistema = New System.Windows.Forms.Label()
        Me.clb_Mes = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Mes = New System.Windows.Forms.Label()
        Me.clb_Ano = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Ano = New System.Windows.Forms.Label()
        Me.clb_Status_Aprovacao = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Status_Aprovacao = New System.Windows.Forms.Label()
        Me.clb_Cliente = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.clb_Justificativa_Aprovacao = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Justificativa_Aprovacao = New System.Windows.Forms.Label()
        Me.cht_Propostas_Mes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cht_Quantidade_Status = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cht_Quantidade_Justificativa = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cht_Faturamento_Mes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cht_Top_Itens_Aprovados = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cht_Top_Itens_Nao_Aprovados = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_Tempo_Resposta_Valor = New System.Windows.Forms.Label()
        Me.lbl_Tempo_Resposta_Titulo = New System.Windows.Forms.Label()
        Me.cht_Quantidade_Cliente = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbl_Taxa_Conversao_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Taxa_Conversao_Valor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chb_Considerar_Revisadas = New System.Windows.Forms.CheckBox()
        Me.lbl_Setor = New System.Windows.Forms.Label()
        Me.clb_Setor = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Usuario_Filtro = New System.Windows.Forms.Label()
        Me.clb_Usuario_Filtro = New System.Windows.Forms.CheckedListBox()
        Me.tim_Atualizar = New System.Windows.Forms.Timer(Me.components)
        Me.ttp_Dica = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_Informacao = New System.Windows.Forms.Label()
        Me.ptb_Justificativa_Aprovacao = New System.Windows.Forms.PictureBox()
        Me.ptb_Status_Aprovacao = New System.Windows.Forms.PictureBox()
        Me.ptb_Mes = New System.Windows.Forms.PictureBox()
        Me.ptb_Ano = New System.Windows.Forms.PictureBox()
        Me.ptb_Logo_Empresa_2 = New System.Windows.Forms.PictureBox()
        Me.ptb_Logo_Empresa_1 = New System.Windows.Forms.PictureBox()
        Me.ptb_Imagem_Usuario = New System.Windows.Forms.PictureBox()
        Me.mnui_Propostas = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisaBásicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisaAvançadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Parametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FabricantesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeEquipamentosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamíliasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SériesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropostasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusDaAprovaçãoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JustificativasDaAprovaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjuntosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecificaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiliaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapeamentoDeColunasImportaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Cadastrar_Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Alterar_Senha = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Ferramentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizarDashboardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaDeDadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Ajuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManifestaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarNotificacaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeAlteraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptb_Setor = New System.Windows.Forms.PictureBox()
        Me.ptb_Usuario_Filtro = New System.Windows.Forms.PictureBox()
        Me.ptb_Cliente = New System.Windows.Forms.PictureBox()
        Me.mnu_Menu.SuspendLayout()
        Me.pnl_Usuario.SuspendLayout()
        Me.sts_Status.SuspendLayout()
        CType(Me.cht_Propostas_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_Quantidade_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_Quantidade_Justificativa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_Faturamento_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_Top_Itens_Aprovados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_Top_Itens_Nao_Aprovados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_Quantidade_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ptb_Justificativa_Aprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Status_Aprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Ano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Logo_Empresa_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Logo_Empresa_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Imagem_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Setor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Usuario_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnu_Menu
        '
        Me.mnu_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnui_Propostas, Me.mnui_Parametros, Me.mnui_Ordens_Servico, Me.mnui_Estoque, Me.mnui_Compras, Me.mnui_Vendas, Me.mnui_Usuarios, Me.mnui_Ferramentas, Me.mnui_Ajuda})
        Me.mnu_Menu.Location = New System.Drawing.Point(0, 0)
        Me.mnu_Menu.Name = "mnu_Menu"
        Me.mnu_Menu.Size = New System.Drawing.Size(1280, 24)
        Me.mnu_Menu.TabIndex = 0
        Me.mnu_Menu.Text = "MenuStrip1"
        '
        'mnui_Ordens_Servico
        '
        Me.mnui_Ordens_Servico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirToolStripMenuItem1, Me.PesquisarToolStripMenuItem1})
        Me.mnui_Ordens_Servico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Ordens_Servico.Name = "mnui_Ordens_Servico"
        Me.mnui_Ordens_Servico.Size = New System.Drawing.Size(113, 20)
        Me.mnui_Ordens_Servico.Text = "Ordens de serviço"
        Me.mnui_Ordens_Servico.Visible = False
        '
        'InserirToolStripMenuItem1
        '
        Me.InserirToolStripMenuItem1.Name = "InserirToolStripMenuItem1"
        Me.InserirToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.InserirToolStripMenuItem1.Text = "Inserir"
        '
        'PesquisarToolStripMenuItem1
        '
        Me.PesquisarToolStripMenuItem1.Name = "PesquisarToolStripMenuItem1"
        Me.PesquisarToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.PesquisarToolStripMenuItem1.Text = "Pesquisar"
        '
        'mnui_Estoque
        '
        Me.mnui_Estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Estoque.Name = "mnui_Estoque"
        Me.mnui_Estoque.Size = New System.Drawing.Size(61, 20)
        Me.mnui_Estoque.Text = "Estoque"
        Me.mnui_Estoque.Visible = False
        '
        'mnui_Compras
        '
        Me.mnui_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Compras.Name = "mnui_Compras"
        Me.mnui_Compras.Size = New System.Drawing.Size(67, 20)
        Me.mnui_Compras.Text = "Compras"
        Me.mnui_Compras.Visible = False
        '
        'mnui_Vendas
        '
        Me.mnui_Vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Vendas.Name = "mnui_Vendas"
        Me.mnui_Vendas.Size = New System.Drawing.Size(56, 20)
        Me.mnui_Vendas.Text = "Vendas"
        Me.mnui_Vendas.Visible = False
        '
        'lbl_Nome_Usuario
        '
        Me.lbl_Nome_Usuario.AutoSize = True
        Me.lbl_Nome_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nome_Usuario.Location = New System.Drawing.Point(73, 3)
        Me.lbl_Nome_Usuario.Name = "lbl_Nome_Usuario"
        Me.lbl_Nome_Usuario.Size = New System.Drawing.Size(84, 13)
        Me.lbl_Nome_Usuario.TabIndex = 41
        Me.lbl_Nome_Usuario.Text = "Nome usuário"
        '
        'lbl_Perfil
        '
        Me.lbl_Perfil.AutoSize = True
        Me.lbl_Perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Perfil.Location = New System.Drawing.Point(73, 30)
        Me.lbl_Perfil.Name = "lbl_Perfil"
        Me.lbl_Perfil.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Perfil.TabIndex = 42
        Me.lbl_Perfil.Text = "Perfil"
        '
        'lbl_Filial
        '
        Me.lbl_Filial.AutoSize = True
        Me.lbl_Filial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Filial.Location = New System.Drawing.Point(73, 54)
        Me.lbl_Filial.Name = "lbl_Filial"
        Me.lbl_Filial.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Filial.TabIndex = 43
        Me.lbl_Filial.Text = "Filial"
        '
        'pnl_Usuario
        '
        Me.pnl_Usuario.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_Usuario.Controls.Add(Me.lbl_Filial)
        Me.pnl_Usuario.Controls.Add(Me.ptb_Imagem_Usuario)
        Me.pnl_Usuario.Controls.Add(Me.lbl_Perfil)
        Me.pnl_Usuario.Controls.Add(Me.lbl_Nome_Usuario)
        Me.pnl_Usuario.Location = New System.Drawing.Point(8, 110)
        Me.pnl_Usuario.Name = "pnl_Usuario"
        Me.pnl_Usuario.Size = New System.Drawing.Size(263, 70)
        Me.pnl_Usuario.TabIndex = 7
        '
        'sts_Status
        '
        Me.sts_Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsi_Login, Me.stsi_Informacao_Atualizacao})
        Me.sts_Status.Location = New System.Drawing.Point(0, 585)
        Me.sts_Status.Name = "sts_Status"
        Me.sts_Status.Size = New System.Drawing.Size(1280, 22)
        Me.sts_Status.TabIndex = 8
        Me.sts_Status.Text = "StatusStrip1"
        '
        'stsi_Login
        '
        Me.stsi_Login.BackColor = System.Drawing.Color.Transparent
        Me.stsi_Login.Name = "stsi_Login"
        Me.stsi_Login.Size = New System.Drawing.Size(37, 17)
        Me.stsi_Login.Text = "Login"
        '
        'stsi_Informacao_Atualizacao
        '
        Me.stsi_Informacao_Atualizacao.BackColor = System.Drawing.Color.Transparent
        Me.stsi_Informacao_Atualizacao.Name = "stsi_Informacao_Atualizacao"
        Me.stsi_Informacao_Atualizacao.Size = New System.Drawing.Size(94, 17)
        Me.stsi_Informacao_Atualizacao.Text = " |  Atualizado até"
        '
        'lbl_Nome_Sistema
        '
        Me.lbl_Nome_Sistema.Font = New System.Drawing.Font("Arial", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nome_Sistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lbl_Nome_Sistema.Location = New System.Drawing.Point(141, 27)
        Me.lbl_Nome_Sistema.Name = "lbl_Nome_Sistema"
        Me.lbl_Nome_Sistema.Size = New System.Drawing.Size(911, 75)
        Me.lbl_Nome_Sistema.TabIndex = 16
        Me.lbl_Nome_Sistema.Text = "Sistema de Gerenciamento Total"
        Me.lbl_Nome_Sistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clb_Mes
        '
        Me.clb_Mes.CheckOnClick = True
        Me.clb_Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Mes.FormattingEnabled = True
        Me.clb_Mes.Location = New System.Drawing.Point(140, 204)
        Me.clb_Mes.Name = "clb_Mes"
        Me.clb_Mes.Size = New System.Drawing.Size(125, 64)
        Me.clb_Mes.TabIndex = 13
        '
        'lbl_Mes
        '
        Me.lbl_Mes.AutoSize = True
        Me.lbl_Mes.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mes.Location = New System.Drawing.Point(138, 189)
        Me.lbl_Mes.Name = "lbl_Mes"
        Me.lbl_Mes.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Mes.TabIndex = 42
        Me.lbl_Mes.Text = "Mês"
        '
        'clb_Ano
        '
        Me.clb_Ano.CheckOnClick = True
        Me.clb_Ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Ano.FormattingEnabled = True
        Me.clb_Ano.Location = New System.Drawing.Point(12, 204)
        Me.clb_Ano.Name = "clb_Ano"
        Me.clb_Ano.Size = New System.Drawing.Size(125, 64)
        Me.clb_Ano.TabIndex = 13
        '
        'lbl_Ano
        '
        Me.lbl_Ano.AutoSize = True
        Me.lbl_Ano.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ano.Location = New System.Drawing.Point(9, 189)
        Me.lbl_Ano.Name = "lbl_Ano"
        Me.lbl_Ano.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Ano.TabIndex = 42
        Me.lbl_Ano.Text = "Ano"
        '
        'clb_Status_Aprovacao
        '
        Me.clb_Status_Aprovacao.CheckOnClick = True
        Me.clb_Status_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Status_Aprovacao.FormattingEnabled = True
        Me.clb_Status_Aprovacao.Location = New System.Drawing.Point(11, 285)
        Me.clb_Status_Aprovacao.Name = "clb_Status_Aprovacao"
        Me.clb_Status_Aprovacao.Size = New System.Drawing.Size(125, 64)
        Me.clb_Status_Aprovacao.TabIndex = 13
        '
        'lbl_Status_Aprovacao
        '
        Me.lbl_Status_Aprovacao.AutoSize = True
        Me.lbl_Status_Aprovacao.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Status_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status_Aprovacao.Location = New System.Drawing.Point(9, 270)
        Me.lbl_Status_Aprovacao.Name = "lbl_Status_Aprovacao"
        Me.lbl_Status_Aprovacao.Size = New System.Drawing.Size(107, 13)
        Me.lbl_Status_Aprovacao.TabIndex = 42
        Me.lbl_Status_Aprovacao.Text = "Status aprovação"
        '
        'clb_Cliente
        '
        Me.clb_Cliente.CheckOnClick = True
        Me.clb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Cliente.FormattingEnabled = True
        Me.clb_Cliente.HorizontalScrollbar = True
        Me.clb_Cliente.IntegralHeight = False
        Me.clb_Cliente.Location = New System.Drawing.Point(132, 183)
        Me.clb_Cliente.Name = "clb_Cliente"
        Me.clb_Cliente.Size = New System.Drawing.Size(125, 176)
        Me.clb_Cliente.TabIndex = 13
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(130, 168)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Cliente.TabIndex = 42
        Me.lbl_Cliente.Text = "Cliente"
        '
        'clb_Justificativa_Aprovacao
        '
        Me.clb_Justificativa_Aprovacao.CheckOnClick = True
        Me.clb_Justificativa_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Justificativa_Aprovacao.FormattingEnabled = True
        Me.clb_Justificativa_Aprovacao.Location = New System.Drawing.Point(11, 368)
        Me.clb_Justificativa_Aprovacao.Name = "clb_Justificativa_Aprovacao"
        Me.clb_Justificativa_Aprovacao.Size = New System.Drawing.Size(125, 79)
        Me.clb_Justificativa_Aprovacao.TabIndex = 13
        '
        'lbl_Justificativa_Aprovacao
        '
        Me.lbl_Justificativa_Aprovacao.AutoSize = True
        Me.lbl_Justificativa_Aprovacao.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Justificativa_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Justificativa_Aprovacao.Location = New System.Drawing.Point(9, 353)
        Me.lbl_Justificativa_Aprovacao.Name = "lbl_Justificativa_Aprovacao"
        Me.lbl_Justificativa_Aprovacao.Size = New System.Drawing.Size(115, 13)
        Me.lbl_Justificativa_Aprovacao.TabIndex = 42
        Me.lbl_Justificativa_Aprovacao.Text = "Justificativa aprov."
        '
        'cht_Propostas_Mes
        '
        Me.cht_Propostas_Mes.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Propostas_Mes.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea1.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.cht_Propostas_Mes.ChartAreas.Add(ChartArea1)
        Me.cht_Propostas_Mes.Location = New System.Drawing.Point(481, 110)
        Me.cht_Propostas_Mes.Name = "cht_Propostas_Mes"
        Series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.Name = "Series1"
        Me.cht_Propostas_Mes.Series.Add(Series1)
        Me.cht_Propostas_Mes.Size = New System.Drawing.Size(396, 150)
        Me.cht_Propostas_Mes.TabIndex = 66
        Me.cht_Propostas_Mes.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title1.Name = "Title1"
        Title1.Text = "Propostas enviadas por mês"
        Me.cht_Propostas_Mes.Titles.Add(Title1)
        '
        'cht_Quantidade_Status
        '
        Me.cht_Quantidade_Status.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Quantidade_Status.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea2.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.BorderColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.cht_Quantidade_Status.ChartAreas.Add(ChartArea2)
        Me.cht_Quantidade_Status.Location = New System.Drawing.Point(275, 261)
        Me.cht_Quantidade_Status.Name = "cht_Quantidade_Status"
        Series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.Name = "Series1"
        Me.cht_Quantidade_Status.Series.Add(Series2)
        Me.cht_Quantidade_Status.Size = New System.Drawing.Size(499, 151)
        Me.cht_Quantidade_Status.TabIndex = 67
        Me.cht_Quantidade_Status.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title2.Name = "Title1"
        Title2.Text = "Quantidade de propostas por status"
        Me.cht_Quantidade_Status.Titles.Add(Title2)
        '
        'cht_Quantidade_Justificativa
        '
        Me.cht_Quantidade_Justificativa.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Quantidade_Justificativa.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea3.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.BorderColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.cht_Quantidade_Justificativa.ChartAreas.Add(ChartArea3)
        Me.cht_Quantidade_Justificativa.Location = New System.Drawing.Point(775, 261)
        Me.cht_Quantidade_Justificativa.Name = "cht_Quantidade_Justificativa"
        Series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series3.ChartArea = "ChartArea1"
        Series3.IsValueShownAsLabel = True
        Series3.Name = "Series1"
        Me.cht_Quantidade_Justificativa.Series.Add(Series3)
        Me.cht_Quantidade_Justificativa.Size = New System.Drawing.Size(499, 151)
        Me.cht_Quantidade_Justificativa.TabIndex = 69
        Me.cht_Quantidade_Justificativa.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title3.Name = "Title1"
        Title3.Text = "Quantidade não aprovada por motivo"
        Me.cht_Quantidade_Justificativa.Titles.Add(Title3)
        '
        'cht_Faturamento_Mes
        '
        Me.cht_Faturamento_Mes.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Faturamento_Mes.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea4.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea4.AxisX.MajorGrid.Enabled = False
        ChartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea4.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea4.BorderColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.cht_Faturamento_Mes.ChartAreas.Add(ChartArea4)
        Me.cht_Faturamento_Mes.Location = New System.Drawing.Point(878, 110)
        Me.cht_Faturamento_Mes.Name = "cht_Faturamento_Mes"
        Series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series4.ChartArea = "ChartArea1"
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Series4.IsValueShownAsLabel = True
        Series4.LabelFormat = "R$ #,#0"
        Series4.Name = "Series1"
        Me.cht_Faturamento_Mes.Series.Add(Series4)
        Me.cht_Faturamento_Mes.Size = New System.Drawing.Size(396, 150)
        Me.cht_Faturamento_Mes.TabIndex = 70
        Me.cht_Faturamento_Mes.Text = "Chart2"
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title4.Name = "Title1"
        Title4.Text = "Faturamento mensal"
        Me.cht_Faturamento_Mes.Titles.Add(Title4)
        '
        'cht_Top_Itens_Aprovados
        '
        Me.cht_Top_Itens_Aprovados.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Top_Itens_Aprovados.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea5.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea5.AxisX.MajorGrid.Enabled = False
        ChartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea5.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea5.BorderColor = System.Drawing.Color.Transparent
        ChartArea5.Name = "ChartArea1"
        Me.cht_Top_Itens_Aprovados.ChartAreas.Add(ChartArea5)
        Me.cht_Top_Itens_Aprovados.Location = New System.Drawing.Point(749, 413)
        Me.cht_Top_Itens_Aprovados.Name = "cht_Top_Itens_Aprovados"
        Me.cht_Top_Itens_Aprovados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series5.IsValueShownAsLabel = True
        Series5.Name = "Series1"
        Me.cht_Top_Itens_Aprovados.Series.Add(Series5)
        Me.cht_Top_Itens_Aprovados.Size = New System.Drawing.Size(262, 164)
        Me.cht_Top_Itens_Aprovados.TabIndex = 71
        Me.cht_Top_Itens_Aprovados.Text = "Chart3"
        Title5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Title5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title5.Name = "Title1"
        Title5.Text = "Top 5 itens aprovados*"
        Title5.ToolTip = "*Desconsidera os itens não identificados da carga de dados históricos"
        Me.cht_Top_Itens_Aprovados.Titles.Add(Title5)
        '
        'cht_Top_Itens_Nao_Aprovados
        '
        Me.cht_Top_Itens_Nao_Aprovados.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Top_Itens_Nao_Aprovados.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea6.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea6.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea6.AxisX.MajorGrid.Enabled = False
        ChartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea6.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea6.BorderColor = System.Drawing.Color.Transparent
        ChartArea6.Name = "ChartArea1"
        Me.cht_Top_Itens_Nao_Aprovados.ChartAreas.Add(ChartArea6)
        Me.cht_Top_Itens_Nao_Aprovados.Location = New System.Drawing.Point(1012, 413)
        Me.cht_Top_Itens_Nao_Aprovados.Name = "cht_Top_Itens_Nao_Aprovados"
        Me.cht_Top_Itens_Nao_Aprovados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.cht_Top_Itens_Nao_Aprovados.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Red}
        Series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series6.IsValueShownAsLabel = True
        Series6.Name = "Series1"
        Me.cht_Top_Itens_Nao_Aprovados.Series.Add(Series6)
        Me.cht_Top_Itens_Nao_Aprovados.Size = New System.Drawing.Size(262, 164)
        Me.cht_Top_Itens_Nao_Aprovados.TabIndex = 73
        Me.cht_Top_Itens_Nao_Aprovados.Text = "Chart4"
        Title6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Title6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title6.Name = "Title1"
        Title6.Text = "Top 5 itens não aprovados*"
        Title6.ToolTip = "*Desconsidera os itens não identificados da carga de dados históricos"
        Me.cht_Top_Itens_Nao_Aprovados.Titles.Add(Title6)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(275, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(102, 157)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        '
        'lbl_Tempo_Resposta_Valor
        '
        Me.lbl_Tempo_Resposta_Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tempo_Resposta_Valor.Location = New System.Drawing.Point(276, 181)
        Me.lbl_Tempo_Resposta_Valor.Name = "lbl_Tempo_Resposta_Valor"
        Me.lbl_Tempo_Resposta_Valor.Size = New System.Drawing.Size(100, 77)
        Me.lbl_Tempo_Resposta_Valor.TabIndex = 75
        Me.lbl_Tempo_Resposta_Valor.Text = "1 dia (s) e 21 horas"
        Me.lbl_Tempo_Resposta_Valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Tempo_Resposta_Titulo
        '
        Me.lbl_Tempo_Resposta_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tempo_Resposta_Titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lbl_Tempo_Resposta_Titulo.Location = New System.Drawing.Point(276, 113)
        Me.lbl_Tempo_Resposta_Titulo.Name = "lbl_Tempo_Resposta_Titulo"
        Me.lbl_Tempo_Resposta_Titulo.Size = New System.Drawing.Size(100, 68)
        Me.lbl_Tempo_Resposta_Titulo.TabIndex = 74
        Me.lbl_Tempo_Resposta_Titulo.Text = "Tempo de resposta"
        Me.lbl_Tempo_Resposta_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cht_Quantidade_Cliente
        '
        Me.cht_Quantidade_Cliente.BorderlineColor = System.Drawing.Color.LightGray
        Me.cht_Quantidade_Cliente.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea7.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea7.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea7.AxisX.MajorGrid.Enabled = False
        ChartArea7.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea7.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea7.BorderColor = System.Drawing.Color.Transparent
        ChartArea7.Name = "ChartArea1"
        Me.cht_Quantidade_Cliente.ChartAreas.Add(ChartArea7)
        Me.cht_Quantidade_Cliente.Location = New System.Drawing.Point(275, 413)
        Me.cht_Quantidade_Cliente.Name = "cht_Quantidade_Cliente"
        Series7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series7.ChartArea = "ChartArea1"
        Series7.IsValueShownAsLabel = True
        Series7.Name = "Series1"
        Me.cht_Quantidade_Cliente.Series.Add(Series7)
        Me.cht_Quantidade_Cliente.Size = New System.Drawing.Size(473, 164)
        Me.cht_Quantidade_Cliente.TabIndex = 75
        Me.cht_Quantidade_Cliente.Text = "Chart1"
        Title7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Title7.Name = "Title1"
        Title7.Text = "Top 10 clientes por propostas"
        Me.cht_Quantidade_Cliente.Titles.Add(Title7)
        '
        'lbl_Taxa_Conversao_Titulo
        '
        Me.lbl_Taxa_Conversao_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Taxa_Conversao_Titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lbl_Taxa_Conversao_Titulo.Location = New System.Drawing.Point(379, 112)
        Me.lbl_Taxa_Conversao_Titulo.Name = "lbl_Taxa_Conversao_Titulo"
        Me.lbl_Taxa_Conversao_Titulo.Size = New System.Drawing.Size(100, 65)
        Me.lbl_Taxa_Conversao_Titulo.TabIndex = 74
        Me.lbl_Taxa_Conversao_Titulo.Text = "Taxa de conversão "
        Me.lbl_Taxa_Conversao_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Taxa_Conversao_Valor
        '
        Me.lbl_Taxa_Conversao_Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Taxa_Conversao_Valor.Location = New System.Drawing.Point(379, 180)
        Me.lbl_Taxa_Conversao_Valor.Name = "lbl_Taxa_Conversao_Valor"
        Me.lbl_Taxa_Conversao_Valor.Size = New System.Drawing.Size(100, 78)
        Me.lbl_Taxa_Conversao_Valor.TabIndex = 75
        Me.lbl_Taxa_Conversao_Valor.Text = "65%"
        Me.lbl_Taxa_Conversao_Valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(378, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(102, 157)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
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
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.chb_Considerar_Revisadas)
        Me.Panel1.Controls.Add(Me.ptb_Setor)
        Me.Panel1.Controls.Add(Me.lbl_Setor)
        Me.Panel1.Controls.Add(Me.clb_Setor)
        Me.Panel1.Controls.Add(Me.ptb_Usuario_Filtro)
        Me.Panel1.Controls.Add(Me.lbl_Usuario_Filtro)
        Me.Panel1.Controls.Add(Me.clb_Usuario_Filtro)
        Me.Panel1.Controls.Add(Me.clb_Cliente)
        Me.Panel1.Controls.Add(Me.lbl_Cliente)
        Me.Panel1.Controls.Add(Me.ptb_Cliente)
        Me.Panel1.Location = New System.Drawing.Point(8, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 392)
        Me.Panel1.TabIndex = 79
        '
        'chb_Considerar_Revisadas
        '
        Me.chb_Considerar_Revisadas.AutoSize = True
        Me.chb_Considerar_Revisadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_Considerar_Revisadas.Location = New System.Drawing.Point(5, 367)
        Me.chb_Considerar_Revisadas.Name = "chb_Considerar_Revisadas"
        Me.chb_Considerar_Revisadas.Size = New System.Drawing.Size(173, 17)
        Me.chb_Considerar_Revisadas.TabIndex = 91
        Me.chb_Considerar_Revisadas.Text = "Considerar propostas revisadas"
        Me.chb_Considerar_Revisadas.UseVisualStyleBackColor = True
        '
        'lbl_Setor
        '
        Me.lbl_Setor.AutoSize = True
        Me.lbl_Setor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Setor.Location = New System.Drawing.Point(130, 85)
        Me.lbl_Setor.Name = "lbl_Setor"
        Me.lbl_Setor.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Setor.TabIndex = 84
        Me.lbl_Setor.Text = "Setor"
        '
        'clb_Setor
        '
        Me.clb_Setor.CheckOnClick = True
        Me.clb_Setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Setor.FormattingEnabled = True
        Me.clb_Setor.Location = New System.Drawing.Point(132, 100)
        Me.clb_Setor.Name = "clb_Setor"
        Me.clb_Setor.Size = New System.Drawing.Size(125, 64)
        Me.clb_Setor.TabIndex = 83
        '
        'lbl_Usuario_Filtro
        '
        Me.lbl_Usuario_Filtro.AutoSize = True
        Me.lbl_Usuario_Filtro.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Usuario_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario_Filtro.Location = New System.Drawing.Point(1, 265)
        Me.lbl_Usuario_Filtro.Name = "lbl_Usuario_Filtro"
        Me.lbl_Usuario_Filtro.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Usuario_Filtro.TabIndex = 81
        Me.lbl_Usuario_Filtro.Text = "Usuário"
        '
        'clb_Usuario_Filtro
        '
        Me.clb_Usuario_Filtro.CheckOnClick = True
        Me.clb_Usuario_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Usuario_Filtro.FormattingEnabled = True
        Me.clb_Usuario_Filtro.Location = New System.Drawing.Point(3, 280)
        Me.clb_Usuario_Filtro.Name = "clb_Usuario_Filtro"
        Me.clb_Usuario_Filtro.Size = New System.Drawing.Size(125, 79)
        Me.clb_Usuario_Filtro.TabIndex = 80
        '
        'tim_Atualizar
        '
        '
        'ttp_Dica
        '
        Me.ttp_Dica.AutoPopDelay = 5000
        Me.ttp_Dica.InitialDelay = 100
        Me.ttp_Dica.IsBalloon = True
        Me.ttp_Dica.ReshowDelay = 100
        Me.ttp_Dica.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttp_Dica.ToolTipTitle = "Força da senha"
        '
        'lbl_Informacao
        '
        Me.lbl_Informacao.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Informacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Informacao.Location = New System.Drawing.Point(1086, 94)
        Me.lbl_Informacao.Name = "lbl_Informacao"
        Me.lbl_Informacao.Size = New System.Drawing.Size(188, 13)
        Me.lbl_Informacao.TabIndex = 80
        Me.lbl_Informacao.Text = "*Apenas propostas enviadas"
        Me.lbl_Informacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ptb_Justificativa_Aprovacao
        '
        Me.ptb_Justificativa_Aprovacao.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Justificativa_Aprovacao.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Justificativa_Aprovacao.Location = New System.Drawing.Point(123, 353)
        Me.ptb_Justificativa_Aprovacao.Name = "ptb_Justificativa_Aprovacao"
        Me.ptb_Justificativa_Aprovacao.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Justificativa_Aprovacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Justificativa_Aprovacao.TabIndex = 43
        Me.ptb_Justificativa_Aprovacao.TabStop = False
        '
        'ptb_Status_Aprovacao
        '
        Me.ptb_Status_Aprovacao.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Status_Aprovacao.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Status_Aprovacao.Location = New System.Drawing.Point(123, 270)
        Me.ptb_Status_Aprovacao.Name = "ptb_Status_Aprovacao"
        Me.ptb_Status_Aprovacao.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Status_Aprovacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Status_Aprovacao.TabIndex = 43
        Me.ptb_Status_Aprovacao.TabStop = False
        '
        'ptb_Mes
        '
        Me.ptb_Mes.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Mes.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Mes.Location = New System.Drawing.Point(251, 189)
        Me.ptb_Mes.Name = "ptb_Mes"
        Me.ptb_Mes.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Mes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Mes.TabIndex = 43
        Me.ptb_Mes.TabStop = False
        '
        'ptb_Ano
        '
        Me.ptb_Ano.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Ano.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Ano.Location = New System.Drawing.Point(124, 189)
        Me.ptb_Ano.Name = "ptb_Ano"
        Me.ptb_Ano.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Ano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Ano.TabIndex = 43
        Me.ptb_Ano.TabStop = False
        '
        'ptb_Logo_Empresa_2
        '
        Me.ptb_Logo_Empresa_2.Image = Global.Eurolift_Services.My.Resources.Resources.logo_still_linde
        Me.ptb_Logo_Empresa_2.Location = New System.Drawing.Point(1058, 27)
        Me.ptb_Logo_Empresa_2.Name = "ptb_Logo_Empresa_2"
        Me.ptb_Logo_Empresa_2.Size = New System.Drawing.Size(216, 64)
        Me.ptb_Logo_Empresa_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Logo_Empresa_2.TabIndex = 15
        Me.ptb_Logo_Empresa_2.TabStop = False
        '
        'ptb_Logo_Empresa_1
        '
        Me.ptb_Logo_Empresa_1.Image = Global.Eurolift_Services.My.Resources.Resources.logo_eurolift
        Me.ptb_Logo_Empresa_1.Location = New System.Drawing.Point(8, 27)
        Me.ptb_Logo_Empresa_1.Name = "ptb_Logo_Empresa_1"
        Me.ptb_Logo_Empresa_1.Size = New System.Drawing.Size(125, 77)
        Me.ptb_Logo_Empresa_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Logo_Empresa_1.TabIndex = 14
        Me.ptb_Logo_Empresa_1.TabStop = False
        '
        'ptb_Imagem_Usuario
        '
        Me.ptb_Imagem_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_Imagem_Usuario.Image = Global.Eurolift_Services.My.Resources.Resources.user_picture_64x64
        Me.ptb_Imagem_Usuario.Location = New System.Drawing.Point(3, 3)
        Me.ptb_Imagem_Usuario.Name = "ptb_Imagem_Usuario"
        Me.ptb_Imagem_Usuario.Size = New System.Drawing.Size(64, 64)
        Me.ptb_Imagem_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Imagem_Usuario.TabIndex = 2
        Me.ptb_Imagem_Usuario.TabStop = False
        '
        'mnui_Propostas
        '
        Me.mnui_Propostas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirToolStripMenuItem, Me.PesquisarToolStripMenuItem})
        Me.mnui_Propostas.Image = Global.Eurolift_Services.My.Resources.Resources.hand_shake
        Me.mnui_Propostas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Propostas.Name = "mnui_Propostas"
        Me.mnui_Propostas.Size = New System.Drawing.Size(93, 20)
        Me.mnui_Propostas.Text = "  Propostas"
        '
        'InserirToolStripMenuItem
        '
        Me.InserirToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.add_square_button
        Me.InserirToolStripMenuItem.Name = "InserirToolStripMenuItem"
        Me.InserirToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.InserirToolStripMenuItem.Text = "Inserir"
        '
        'PesquisarToolStripMenuItem
        '
        Me.PesquisarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesquisaBásicaToolStripMenuItem, Me.PesquisaAvançadaToolStripMenuItem})
        Me.PesquisarToolStripMenuItem.Name = "PesquisarToolStripMenuItem"
        Me.PesquisarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PesquisarToolStripMenuItem.Text = "Pesquisar"
        '
        'PesquisaBásicaToolStripMenuItem
        '
        Me.PesquisaBásicaToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.magnifying_glass
        Me.PesquisaBásicaToolStripMenuItem.Name = "PesquisaBásicaToolStripMenuItem"
        Me.PesquisaBásicaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PesquisaBásicaToolStripMenuItem.Text = "Pesquisa básica"
        '
        'PesquisaAvançadaToolStripMenuItem
        '
        Me.PesquisaAvançadaToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.advanced_search
        Me.PesquisaAvançadaToolStripMenuItem.Name = "PesquisaAvançadaToolStripMenuItem"
        Me.PesquisaAvançadaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PesquisaAvançadaToolStripMenuItem.Text = "Pesquisa avançada"
        '
        'mnui_Parametros
        '
        Me.mnui_Parametros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeralToolStripMenuItem, Me.EquipamentosToolStripMenuItem, Me.PropostasToolStripMenuItem, Me.SistemaToolStripMenuItem})
        Me.mnui_Parametros.Image = Global.Eurolift_Services.My.Resources.Resources.settings__3_
        Me.mnui_Parametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Parametros.Name = "mnui_Parametros"
        Me.mnui_Parametros.Size = New System.Drawing.Size(101, 20)
        Me.mnui_Parametros.Text = "  Parâmetros"
        '
        'GeralToolStripMenuItem
        '
        Me.GeralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.ContatosToolStripMenuItem1})
        Me.GeralToolStripMenuItem.Name = "GeralToolStripMenuItem"
        Me.GeralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GeralToolStripMenuItem.Text = "Geral"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.clerk_with_tie
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ContatosToolStripMenuItem1
        '
        Me.ContatosToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.contact_book
        Me.ContatosToolStripMenuItem1.Name = "ContatosToolStripMenuItem1"
        Me.ContatosToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ContatosToolStripMenuItem1.Text = "Contatos"
        '
        'EquipamentosToolStripMenuItem
        '
        Me.EquipamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FabricantesToolStripMenuItem1, Me.TiposDeEquipamentosToolStripMenuItem1, Me.ModelosToolStripMenuItem1, Me.FamíliasToolStripMenuItem1, Me.AnosToolStripMenuItem1, Me.SériesToolStripMenuItem1})
        Me.EquipamentosToolStripMenuItem.Name = "EquipamentosToolStripMenuItem"
        Me.EquipamentosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EquipamentosToolStripMenuItem.Text = "Equipamentos"
        '
        'FabricantesToolStripMenuItem1
        '
        Me.FabricantesToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.manufacturer
        Me.FabricantesToolStripMenuItem1.Name = "FabricantesToolStripMenuItem1"
        Me.FabricantesToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.FabricantesToolStripMenuItem1.Text = "Fabricantes"
        '
        'TiposDeEquipamentosToolStripMenuItem1
        '
        Me.TiposDeEquipamentosToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.technology
        Me.TiposDeEquipamentosToolStripMenuItem1.Name = "TiposDeEquipamentosToolStripMenuItem1"
        Me.TiposDeEquipamentosToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.TiposDeEquipamentosToolStripMenuItem1.Text = "Tipos de equipamentos"
        '
        'ModelosToolStripMenuItem1
        '
        Me.ModelosToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.forklift_truck
        Me.ModelosToolStripMenuItem1.Name = "ModelosToolStripMenuItem1"
        Me.ModelosToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.ModelosToolStripMenuItem1.Text = "Modelos"
        '
        'FamíliasToolStripMenuItem1
        '
        Me.FamíliasToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.motorcade
        Me.FamíliasToolStripMenuItem1.Name = "FamíliasToolStripMenuItem1"
        Me.FamíliasToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.FamíliasToolStripMenuItem1.Text = "Famílias"
        '
        'AnosToolStripMenuItem1
        '
        Me.AnosToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.calendar__1_
        Me.AnosToolStripMenuItem1.Name = "AnosToolStripMenuItem1"
        Me.AnosToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.AnosToolStripMenuItem1.Text = "Anos"
        '
        'SériesToolStripMenuItem1
        '
        Me.SériesToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.steps
        Me.SériesToolStripMenuItem1.Name = "SériesToolStripMenuItem1"
        Me.SériesToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.SériesToolStripMenuItem1.Text = "Séries"
        '
        'PropostasToolStripMenuItem
        '
        Me.PropostasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusDaAprovaçãoToolStripMenuItem1, Me.JustificativasDaAprovaçãoToolStripMenuItem, Me.FornecedoresToolStripMenuItem1, Me.TermosToolStripMenuItem1, Me.ConjuntosToolStripMenuItem, Me.EspecificaçõesToolStripMenuItem})
        Me.PropostasToolStripMenuItem.Name = "PropostasToolStripMenuItem"
        Me.PropostasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PropostasToolStripMenuItem.Text = "Propostas"
        '
        'StatusDaAprovaçãoToolStripMenuItem1
        '
        Me.StatusDaAprovaçãoToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.wireless_signal_interface_status_symbol_of_bars_group
        Me.StatusDaAprovaçãoToolStripMenuItem1.Name = "StatusDaAprovaçãoToolStripMenuItem1"
        Me.StatusDaAprovaçãoToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.StatusDaAprovaçãoToolStripMenuItem1.Text = "Status da aprovação"
        '
        'JustificativasDaAprovaçãoToolStripMenuItem
        '
        Me.JustificativasDaAprovaçãoToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.documents
        Me.JustificativasDaAprovaçãoToolStripMenuItem.Name = "JustificativasDaAprovaçãoToolStripMenuItem"
        Me.JustificativasDaAprovaçãoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.JustificativasDaAprovaçãoToolStripMenuItem.Text = "Justificativas da aprovação"
        '
        'FornecedoresToolStripMenuItem1
        '
        Me.FornecedoresToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.hotel_supplier
        Me.FornecedoresToolStripMenuItem1.Name = "FornecedoresToolStripMenuItem1"
        Me.FornecedoresToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.FornecedoresToolStripMenuItem1.Text = "Fornecedores"
        '
        'TermosToolStripMenuItem1
        '
        Me.TermosToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.terms_and_conditions
        Me.TermosToolStripMenuItem1.Name = "TermosToolStripMenuItem1"
        Me.TermosToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.TermosToolStripMenuItem1.Text = "Termos"
        '
        'ConjuntosToolStripMenuItem
        '
        Me.ConjuntosToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.settings__4_
        Me.ConjuntosToolStripMenuItem.Name = "ConjuntosToolStripMenuItem"
        Me.ConjuntosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ConjuntosToolStripMenuItem.Text = "Conjuntos"
        '
        'EspecificaçõesToolStripMenuItem
        '
        Me.EspecificaçõesToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.specification
        Me.EspecificaçõesToolStripMenuItem.Name = "EspecificaçõesToolStripMenuItem"
        Me.EspecificaçõesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.EspecificaçõesToolStripMenuItem.Text = "Especificações"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem, Me.FiliaisToolStripMenuItem, Me.SetoresToolStripMenuItem1, Me.TaxasToolStripMenuItem1, Me.MapeamentoDeColunasImportaçãoToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.building
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'FiliaisToolStripMenuItem
        '
        Me.FiliaisToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.business_center
        Me.FiliaisToolStripMenuItem.Name = "FiliaisToolStripMenuItem"
        Me.FiliaisToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FiliaisToolStripMenuItem.Text = "Filiais"
        '
        'SetoresToolStripMenuItem1
        '
        Me.SetoresToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.department
        Me.SetoresToolStripMenuItem1.Name = "SetoresToolStripMenuItem1"
        Me.SetoresToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.SetoresToolStripMenuItem1.Text = "Setores"
        '
        'TaxasToolStripMenuItem1
        '
        Me.TaxasToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.taxes
        Me.TaxasToolStripMenuItem1.Name = "TaxasToolStripMenuItem1"
        Me.TaxasToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.TaxasToolStripMenuItem1.Text = "Taxas"
        '
        'MapeamentoDeColunasImportaçãoToolStripMenuItem
        '
        Me.MapeamentoDeColunasImportaçãoToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.two_columns_layout
        Me.MapeamentoDeColunasImportaçãoToolStripMenuItem.Name = "MapeamentoDeColunasImportaçãoToolStripMenuItem"
        Me.MapeamentoDeColunasImportaçãoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MapeamentoDeColunasImportaçãoToolStripMenuItem.Text = "Colunas para importação"
        '
        'mnui_Usuarios
        '
        Me.mnui_Usuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.mnui_Cadastrar_Usuario, Me.GerenciarUsuáriosToolStripMenuItem, Me.mnui_Alterar_Senha, Me.AlterarUsuárioToolStripMenuItem})
        Me.mnui_Usuarios.Image = Global.Eurolift_Services.My.Resources.Resources.user_shape
        Me.mnui_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Usuarios.Name = "mnui_Usuarios"
        Me.mnui_Usuarios.Size = New System.Drawing.Size(81, 20)
        Me.mnui_Usuarios.Text = "  Usuário"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.profile_user
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'mnui_Cadastrar_Usuario
        '
        Me.mnui_Cadastrar_Usuario.Image = Global.Eurolift_Services.My.Resources.Resources.new_user
        Me.mnui_Cadastrar_Usuario.Name = "mnui_Cadastrar_Usuario"
        Me.mnui_Cadastrar_Usuario.Size = New System.Drawing.Size(171, 22)
        Me.mnui_Cadastrar_Usuario.Text = "Cadastrar"
        '
        'GerenciarUsuáriosToolStripMenuItem
        '
        Me.GerenciarUsuáriosToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.profile
        Me.GerenciarUsuáriosToolStripMenuItem.Name = "GerenciarUsuáriosToolStripMenuItem"
        Me.GerenciarUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar usuários"
        '
        'mnui_Alterar_Senha
        '
        Me.mnui_Alterar_Senha.Image = Global.Eurolift_Services.My.Resources.Resources.password
        Me.mnui_Alterar_Senha.Name = "mnui_Alterar_Senha"
        Me.mnui_Alterar_Senha.Size = New System.Drawing.Size(171, 22)
        Me.mnui_Alterar_Senha.Text = "Alterar senha"
        '
        'AlterarUsuárioToolStripMenuItem
        '
        Me.AlterarUsuárioToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.update_profile_user
        Me.AlterarUsuárioToolStripMenuItem.Name = "AlterarUsuárioToolStripMenuItem"
        Me.AlterarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AlterarUsuárioToolStripMenuItem.Text = "Alterar usuário"
        Me.AlterarUsuárioToolStripMenuItem.Visible = False
        '
        'mnui_Ferramentas
        '
        Me.mnui_Ferramentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtualizarDashboardToolStripMenuItem1, Me.OpçõesToolStripMenuItem, Me.CargaDeDadosToolStripMenuItem1})
        Me.mnui_Ferramentas.Image = Global.Eurolift_Services.My.Resources.Resources.open_wrench_tool_silhouette
        Me.mnui_Ferramentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Ferramentas.Name = "mnui_Ferramentas"
        Me.mnui_Ferramentas.Size = New System.Drawing.Size(106, 20)
        Me.mnui_Ferramentas.Text = "  Ferramentas"
        '
        'AtualizarDashboardToolStripMenuItem1
        '
        Me.AtualizarDashboardToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.reload
        Me.AtualizarDashboardToolStripMenuItem1.Name = "AtualizarDashboardToolStripMenuItem1"
        Me.AtualizarDashboardToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.AtualizarDashboardToolStripMenuItem1.Text = "Atualizar dashboard"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.gear_option
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OpçõesToolStripMenuItem.Text = "Opções"
        '
        'CargaDeDadosToolStripMenuItem1
        '
        Me.CargaDeDadosToolStripMenuItem1.Image = Global.Eurolift_Services.My.Resources.Resources.data_copy
        Me.CargaDeDadosToolStripMenuItem1.Name = "CargaDeDadosToolStripMenuItem1"
        Me.CargaDeDadosToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.CargaDeDadosToolStripMenuItem1.Text = "Carga de dados"
        '
        'mnui_Ajuda
        '
        Me.mnui_Ajuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManifestaçõesToolStripMenuItem, Me.EnviarNotificacaoToolStripMenuItem, Me.RegistroDeAlteraçõesToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.mnui_Ajuda.Image = Global.Eurolift_Services.My.Resources.Resources.question_sign
        Me.mnui_Ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Ajuda.Name = "mnui_Ajuda"
        Me.mnui_Ajuda.Size = New System.Drawing.Size(72, 20)
        Me.mnui_Ajuda.Text = "  Ajuda"
        '
        'ManifestaçõesToolStripMenuItem
        '
        Me.ManifestaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirToolStripMenuItem2, Me.PesquisarToolStripMenuItem2})
        Me.ManifestaçõesToolStripMenuItem.Name = "ManifestaçõesToolStripMenuItem"
        Me.ManifestaçõesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ManifestaçõesToolStripMenuItem.Text = "Requisições"
        '
        'InserirToolStripMenuItem2
        '
        Me.InserirToolStripMenuItem2.Image = Global.Eurolift_Services.My.Resources.Resources.add_square_button
        Me.InserirToolStripMenuItem2.Name = "InserirToolStripMenuItem2"
        Me.InserirToolStripMenuItem2.Size = New System.Drawing.Size(124, 22)
        Me.InserirToolStripMenuItem2.Text = "Inserir"
        '
        'PesquisarToolStripMenuItem2
        '
        Me.PesquisarToolStripMenuItem2.Image = Global.Eurolift_Services.My.Resources.Resources.magnifying_glass
        Me.PesquisarToolStripMenuItem2.Name = "PesquisarToolStripMenuItem2"
        Me.PesquisarToolStripMenuItem2.Size = New System.Drawing.Size(124, 22)
        Me.PesquisarToolStripMenuItem2.Text = "Pesquisar"
        '
        'EnviarNotificacaoToolStripMenuItem
        '
        Me.EnviarNotificacaoToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.email
        Me.EnviarNotificacaoToolStripMenuItem.Name = "EnviarNotificacaoToolStripMenuItem"
        Me.EnviarNotificacaoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EnviarNotificacaoToolStripMenuItem.Text = "Enviar notificação"
        Me.EnviarNotificacaoToolStripMenuItem.Visible = False
        '
        'RegistroDeAlteraçõesToolStripMenuItem
        '
        Me.RegistroDeAlteraçõesToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.log_format
        Me.RegistroDeAlteraçõesToolStripMenuItem.Name = "RegistroDeAlteraçõesToolStripMenuItem"
        Me.RegistroDeAlteraçõesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RegistroDeAlteraçõesToolStripMenuItem.Text = "Registro de alterações"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.information_symbol
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ptb_Setor
        '
        Me.ptb_Setor.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Setor.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Setor.Location = New System.Drawing.Point(244, 85)
        Me.ptb_Setor.Name = "ptb_Setor"
        Me.ptb_Setor.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Setor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Setor.TabIndex = 85
        Me.ptb_Setor.TabStop = False
        '
        'ptb_Usuario_Filtro
        '
        Me.ptb_Usuario_Filtro.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Usuario_Filtro.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Usuario_Filtro.Location = New System.Drawing.Point(115, 265)
        Me.ptb_Usuario_Filtro.Name = "ptb_Usuario_Filtro"
        Me.ptb_Usuario_Filtro.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Usuario_Filtro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Usuario_Filtro.TabIndex = 82
        Me.ptb_Usuario_Filtro.TabStop = False
        '
        'ptb_Cliente
        '
        Me.ptb_Cliente.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Cliente.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Cliente.Location = New System.Drawing.Point(243, 168)
        Me.ptb_Cliente.Name = "ptb_Cliente"
        Me.ptb_Cliente.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Cliente.TabIndex = 43
        Me.ptb_Cliente.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1280, 607)
        Me.Controls.Add(Me.lbl_Informacao)
        Me.Controls.Add(Me.lbl_Tempo_Resposta_Valor)
        Me.Controls.Add(Me.lbl_Taxa_Conversao_Valor)
        Me.Controls.Add(Me.lbl_Tempo_Resposta_Titulo)
        Me.Controls.Add(Me.cht_Quantidade_Cliente)
        Me.Controls.Add(Me.lbl_Taxa_Conversao_Titulo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cht_Top_Itens_Nao_Aprovados)
        Me.Controls.Add(Me.cht_Top_Itens_Aprovados)
        Me.Controls.Add(Me.ptb_Justificativa_Aprovacao)
        Me.Controls.Add(Me.ptb_Status_Aprovacao)
        Me.Controls.Add(Me.clb_Justificativa_Aprovacao)
        Me.Controls.Add(Me.lbl_Justificativa_Aprovacao)
        Me.Controls.Add(Me.clb_Status_Aprovacao)
        Me.Controls.Add(Me.lbl_Status_Aprovacao)
        Me.Controls.Add(Me.ptb_Mes)
        Me.Controls.Add(Me.ptb_Ano)
        Me.Controls.Add(Me.clb_Mes)
        Me.Controls.Add(Me.lbl_Mes)
        Me.Controls.Add(Me.cht_Faturamento_Mes)
        Me.Controls.Add(Me.clb_Ano)
        Me.Controls.Add(Me.lbl_Ano)
        Me.Controls.Add(Me.cht_Quantidade_Justificativa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cht_Quantidade_Status)
        Me.Controls.Add(Me.cht_Propostas_Mes)
        Me.Controls.Add(Me.lbl_Nome_Sistema)
        Me.Controls.Add(Me.ptb_Logo_Empresa_2)
        Me.Controls.Add(Me.ptb_Logo_Empresa_1)
        Me.Controls.Add(Me.pnl_Usuario)
        Me.Controls.Add(Me.sts_Status)
        Me.Controls.Add(Me.mnu_Menu)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_Menu
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Início"
        Me.mnu_Menu.ResumeLayout(False)
        Me.mnu_Menu.PerformLayout()
        Me.pnl_Usuario.ResumeLayout(False)
        Me.pnl_Usuario.PerformLayout()
        Me.sts_Status.ResumeLayout(False)
        Me.sts_Status.PerformLayout()
        CType(Me.cht_Propostas_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_Quantidade_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_Quantidade_Justificativa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_Faturamento_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_Top_Itens_Aprovados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_Top_Itens_Nao_Aprovados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_Quantidade_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ptb_Justificativa_Aprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Status_Aprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Ano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Logo_Empresa_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Logo_Empresa_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Imagem_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Setor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Usuario_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_Menu As MenuStrip
    Friend WithEvents mnui_Propostas As ToolStripMenuItem
    Friend WithEvents InserirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnui_Ordens_Servico As ToolStripMenuItem
    Friend WithEvents InserirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PesquisarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnui_Estoque As ToolStripMenuItem
    Friend WithEvents mnui_Compras As ToolStripMenuItem
    Friend WithEvents mnui_Vendas As ToolStripMenuItem
    Friend WithEvents mnui_Parametros As ToolStripMenuItem
    Friend WithEvents mnui_Usuarios As ToolStripMenuItem
    Friend WithEvents mnui_Cadastrar_Usuario As ToolStripMenuItem
    Friend WithEvents mnui_Ferramentas As ToolStripMenuItem
    Friend WithEvents OpçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnui_Ajuda As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ptb_Imagem_Usuario As PictureBox
    Friend WithEvents lbl_Filial As Label
    Friend WithEvents lbl_Perfil As Label
    Friend WithEvents lbl_Nome_Usuario As Label
    Friend WithEvents pnl_Usuario As Panel
    Friend WithEvents sts_Status As StatusStrip
    Friend WithEvents stsi_Login As ToolStripStatusLabel
    Friend WithEvents mnui_Alterar_Senha As ToolStripMenuItem
    Friend WithEvents ptb_Logo_Empresa_1 As PictureBox
    Friend WithEvents ptb_Logo_Empresa_2 As PictureBox
    Friend WithEvents lbl_Nome_Sistema As Label
    Friend WithEvents AlterarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisaBásicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisaAvançadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ptb_Status_Aprovacao As PictureBox
    Friend WithEvents clb_Status_Aprovacao As CheckedListBox
    Friend WithEvents lbl_Status_Aprovacao As Label
    Friend WithEvents ptb_Cliente As PictureBox
    Friend WithEvents clb_Cliente As CheckedListBox
    Friend WithEvents lbl_Cliente As Label
    Friend WithEvents ptb_Justificativa_Aprovacao As PictureBox
    Friend WithEvents clb_Justificativa_Aprovacao As CheckedListBox
    Friend WithEvents lbl_Justificativa_Aprovacao As Label
    Friend WithEvents ptb_Mes As PictureBox
    Friend WithEvents clb_Mes As CheckedListBox
    Friend WithEvents lbl_Mes As Label
    Friend WithEvents ptb_Ano As PictureBox
    Friend WithEvents clb_Ano As CheckedListBox
    Friend WithEvents lbl_Ano As Label
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarUsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cht_Propostas_Mes As DataVisualization.Charting.Chart
    Friend WithEvents cht_Quantidade_Status As DataVisualization.Charting.Chart
    Friend WithEvents cht_Quantidade_Justificativa As DataVisualization.Charting.Chart
    Friend WithEvents cht_Faturamento_Mes As DataVisualization.Charting.Chart
    Friend WithEvents cht_Top_Itens_Aprovados As DataVisualization.Charting.Chart
    Friend WithEvents cht_Top_Itens_Nao_Aprovados As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_Tempo_Resposta_Valor As Label
    Friend WithEvents lbl_Tempo_Resposta_Titulo As Label
    Friend WithEvents cht_Quantidade_Cliente As DataVisualization.Charting.Chart
    Friend WithEvents lbl_Taxa_Conversao_Titulo As Label
    Friend WithEvents lbl_Taxa_Conversao_Valor As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents RegistroDeAlteraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tim_Atualizar As Timer
    Friend WithEvents AtualizarDashboardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnviarNotificacaoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stsi_Informacao_Atualizacao As ToolStripStatusLabel
    Friend WithEvents ttp_Dica As ToolTip
    Friend WithEvents ptb_Usuario_Filtro As PictureBox
    Friend WithEvents clb_Usuario_Filtro As CheckedListBox
    Friend WithEvents lbl_Usuario_Filtro As Label
    Friend WithEvents ptb_Setor As PictureBox
    Friend WithEvents lbl_Setor As Label
    Friend WithEvents clb_Setor As CheckedListBox
    Friend WithEvents chb_Considerar_Revisadas As CheckBox
    Friend WithEvents EquipamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FabricantesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TiposDeEquipamentosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModelosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FamíliasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AnosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SériesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PropostasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusDaAprovaçãoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JustificativasDaAprovaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TermosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiliaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TaxasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContatosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CargaDeDadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConjuntosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecificaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_Informacao As Label
    Friend WithEvents ManifestaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InserirToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PesquisarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MapeamentoDeColunasImportaçãoToolStripMenuItem As ToolStripMenuItem
End Class
