<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controle_Item
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Controle_Item))
        Me.cbo_Status = New System.Windows.Forms.ComboBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.cbo_Tipo_Item = New System.Windows.Forms.ComboBox()
        Me.lbl_Tipo_Item = New System.Windows.Forms.Label()
        Me.cbo_Justificativa_Aprovacao = New System.Windows.Forms.ComboBox()
        Me.lbl_Justificativa_Aprovacao = New System.Windows.Forms.Label()
        Me.cbo_Status_Aprovacao = New System.Windows.Forms.ComboBox()
        Me.lbl_Status_Aprovacao = New System.Windows.Forms.Label()
        Me.grp_Controles = New System.Windows.Forms.GroupBox()
        Me.grp_Peça = New System.Windows.Forms.GroupBox()
        Me.cbo_Conjunto = New System.Windows.Forms.ComboBox()
        Me.cbo_Especificacao = New System.Windows.Forms.ComboBox()
        Me.txt_Prazo_Final = New System.Windows.Forms.TextBox()
        Me.lbl_Especificacao = New System.Windows.Forms.Label()
        Me.lbl_Conjunto = New System.Windows.Forms.Label()
        Me.lbl_Prazo_Final = New System.Windows.Forms.Label()
        Me.txt_Prazo_Inicial = New System.Windows.Forms.TextBox()
        Me.lbl_Prazo_Inicial = New System.Windows.Forms.Label()
        Me.lbl_Comentarios = New System.Windows.Forms.Label()
        Me.nud_Quantidade = New System.Windows.Forms.NumericUpDown()
        Me.txt_Comentarios = New System.Windows.Forms.TextBox()
        Me.lbl_Quantidade = New System.Windows.Forms.Label()
        Me.lbl_Origem = New System.Windows.Forms.Label()
        Me.nud_Desconto_Final = New System.Windows.Forms.NumericUpDown()
        Me.cbo_Origem = New System.Windows.Forms.ComboBox()
        Me.nud_Valor_ST = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Tipo_Substituicao_Tributaria = New System.Windows.Forms.Label()
        Me.lbl_Desconto_Final = New System.Windows.Forms.Label()
        Me.cbo_Tipo_Substituicao_Tributaria = New System.Windows.Forms.ComboBox()
        Me.cbo_Codigo = New System.Windows.Forms.ComboBox()
        Me.nud_Desconto_Inicial = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Desconto_Inicial = New System.Windows.Forms.Label()
        Me.lbl_Valor_ST = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.nud_Frete_Unitario = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Frete_Unitario = New System.Windows.Forms.Label()
        Me.nud_Preco_Total = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Preco_Total = New System.Windows.Forms.Label()
        Me.lbl_Fornecedor = New System.Windows.Forms.Label()
        Me.cbo_Fornecedor = New System.Windows.Forms.ComboBox()
        Me.nud_MVA = New System.Windows.Forms.NumericUpDown()
        Me.txt_Descricao = New System.Windows.Forms.TextBox()
        Me.lbl_Descricao = New System.Windows.Forms.Label()
        Me.lbl_MVA = New System.Windows.Forms.Label()
        Me.nud_Preco_Unitario = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Preco_Unitario = New System.Windows.Forms.Label()
        Me.lbl_NCM = New System.Windows.Forms.Label()
        Me.nud_Percentual_ICMS = New System.Windows.Forms.NumericUpDown()
        Me.txt_NCM = New System.Windows.Forms.TextBox()
        Me.lbl_Percentual_IPI = New System.Windows.Forms.Label()
        Me.nud_Percentual_IPI = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_ICMS = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_Salvar = New System.Windows.Forms.Button()
        Me.nud_Quantidade_Inicial = New System.Windows.Forms.NumericUpDown()
        Me.grp_Controles.SuspendLayout()
        Me.grp_Peça.SuspendLayout()
        CType(Me.nud_Quantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Desconto_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Valor_ST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Desconto_Inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Frete_Unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Preco_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_MVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Preco_Unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_ICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_IPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Quantidade_Inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_Status
        '
        Me.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Location = New System.Drawing.Point(166, 37)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(109, 21)
        Me.cbo_Status.TabIndex = 5
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(163, 21)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Status.TabIndex = 1
        Me.lbl_Status.Text = "Status"
        '
        'cbo_Tipo_Item
        '
        Me.cbo_Tipo_Item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Tipo_Item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Tipo_Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tipo_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tipo_Item.FormattingEnabled = True
        Me.cbo_Tipo_Item.Location = New System.Drawing.Point(15, 37)
        Me.cbo_Tipo_Item.Name = "cbo_Tipo_Item"
        Me.cbo_Tipo_Item.Size = New System.Drawing.Size(145, 21)
        Me.cbo_Tipo_Item.TabIndex = 4
        '
        'lbl_Tipo_Item
        '
        Me.lbl_Tipo_Item.AutoSize = True
        Me.lbl_Tipo_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo_Item.Location = New System.Drawing.Point(12, 21)
        Me.lbl_Tipo_Item.Name = "lbl_Tipo_Item"
        Me.lbl_Tipo_Item.Size = New System.Drawing.Size(77, 13)
        Me.lbl_Tipo_Item.TabIndex = 0
        Me.lbl_Tipo_Item.Text = "Tipo do item"
        '
        'cbo_Justificativa_Aprovacao
        '
        Me.cbo_Justificativa_Aprovacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Justificativa_Aprovacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Justificativa_Aprovacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Justificativa_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Justificativa_Aprovacao.FormattingEnabled = True
        Me.cbo_Justificativa_Aprovacao.Location = New System.Drawing.Point(432, 37)
        Me.cbo_Justificativa_Aprovacao.Name = "cbo_Justificativa_Aprovacao"
        Me.cbo_Justificativa_Aprovacao.Size = New System.Drawing.Size(235, 21)
        Me.cbo_Justificativa_Aprovacao.TabIndex = 7
        '
        'lbl_Justificativa_Aprovacao
        '
        Me.lbl_Justificativa_Aprovacao.AutoSize = True
        Me.lbl_Justificativa_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Justificativa_Aprovacao.Location = New System.Drawing.Point(429, 21)
        Me.lbl_Justificativa_Aprovacao.Name = "lbl_Justificativa_Aprovacao"
        Me.lbl_Justificativa_Aprovacao.Size = New System.Drawing.Size(157, 13)
        Me.lbl_Justificativa_Aprovacao.TabIndex = 3
        Me.lbl_Justificativa_Aprovacao.Text = "Justificativa da aprovação"
        '
        'cbo_Status_Aprovacao
        '
        Me.cbo_Status_Aprovacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Status_Aprovacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status_Aprovacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Status_Aprovacao.FormattingEnabled = True
        Me.cbo_Status_Aprovacao.Location = New System.Drawing.Point(281, 37)
        Me.cbo_Status_Aprovacao.Name = "cbo_Status_Aprovacao"
        Me.cbo_Status_Aprovacao.Size = New System.Drawing.Size(145, 21)
        Me.cbo_Status_Aprovacao.TabIndex = 6
        '
        'lbl_Status_Aprovacao
        '
        Me.lbl_Status_Aprovacao.AutoSize = True
        Me.lbl_Status_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status_Aprovacao.Location = New System.Drawing.Point(278, 21)
        Me.lbl_Status_Aprovacao.Name = "lbl_Status_Aprovacao"
        Me.lbl_Status_Aprovacao.Size = New System.Drawing.Size(125, 13)
        Me.lbl_Status_Aprovacao.TabIndex = 2
        Me.lbl_Status_Aprovacao.Text = "Status da aprovação"
        '
        'grp_Controles
        '
        Me.grp_Controles.Controls.Add(Me.cbo_Status_Aprovacao)
        Me.grp_Controles.Controls.Add(Me.lbl_Status_Aprovacao)
        Me.grp_Controles.Controls.Add(Me.lbl_Tipo_Item)
        Me.grp_Controles.Controls.Add(Me.cbo_Justificativa_Aprovacao)
        Me.grp_Controles.Controls.Add(Me.lbl_Status)
        Me.grp_Controles.Controls.Add(Me.lbl_Justificativa_Aprovacao)
        Me.grp_Controles.Controls.Add(Me.cbo_Status)
        Me.grp_Controles.Controls.Add(Me.cbo_Tipo_Item)
        Me.grp_Controles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Controles.Location = New System.Drawing.Point(12, 12)
        Me.grp_Controles.Name = "grp_Controles"
        Me.grp_Controles.Size = New System.Drawing.Size(683, 73)
        Me.grp_Controles.TabIndex = 0
        Me.grp_Controles.TabStop = False
        Me.grp_Controles.Text = "Controles"
        '
        'grp_Peça
        '
        Me.grp_Peça.Controls.Add(Me.cbo_Conjunto)
        Me.grp_Peça.Controls.Add(Me.cbo_Especificacao)
        Me.grp_Peça.Controls.Add(Me.txt_Prazo_Final)
        Me.grp_Peça.Controls.Add(Me.lbl_Especificacao)
        Me.grp_Peça.Controls.Add(Me.lbl_Conjunto)
        Me.grp_Peça.Controls.Add(Me.lbl_Prazo_Final)
        Me.grp_Peça.Controls.Add(Me.txt_Prazo_Inicial)
        Me.grp_Peça.Controls.Add(Me.lbl_Prazo_Inicial)
        Me.grp_Peça.Controls.Add(Me.lbl_Comentarios)
        Me.grp_Peça.Controls.Add(Me.nud_Quantidade)
        Me.grp_Peça.Controls.Add(Me.txt_Comentarios)
        Me.grp_Peça.Controls.Add(Me.lbl_Quantidade)
        Me.grp_Peça.Controls.Add(Me.lbl_Origem)
        Me.grp_Peça.Controls.Add(Me.nud_Desconto_Final)
        Me.grp_Peça.Controls.Add(Me.cbo_Origem)
        Me.grp_Peça.Controls.Add(Me.nud_Valor_ST)
        Me.grp_Peça.Controls.Add(Me.lbl_Tipo_Substituicao_Tributaria)
        Me.grp_Peça.Controls.Add(Me.lbl_Desconto_Final)
        Me.grp_Peça.Controls.Add(Me.cbo_Tipo_Substituicao_Tributaria)
        Me.grp_Peça.Controls.Add(Me.cbo_Codigo)
        Me.grp_Peça.Controls.Add(Me.nud_Desconto_Inicial)
        Me.grp_Peça.Controls.Add(Me.lbl_Desconto_Inicial)
        Me.grp_Peça.Controls.Add(Me.lbl_Valor_ST)
        Me.grp_Peça.Controls.Add(Me.lbl_Codigo)
        Me.grp_Peça.Controls.Add(Me.nud_Frete_Unitario)
        Me.grp_Peça.Controls.Add(Me.lbl_Frete_Unitario)
        Me.grp_Peça.Controls.Add(Me.nud_Preco_Total)
        Me.grp_Peça.Controls.Add(Me.lbl_Preco_Total)
        Me.grp_Peça.Controls.Add(Me.lbl_Fornecedor)
        Me.grp_Peça.Controls.Add(Me.cbo_Fornecedor)
        Me.grp_Peça.Controls.Add(Me.nud_MVA)
        Me.grp_Peça.Controls.Add(Me.txt_Descricao)
        Me.grp_Peça.Controls.Add(Me.lbl_Descricao)
        Me.grp_Peça.Controls.Add(Me.lbl_MVA)
        Me.grp_Peça.Controls.Add(Me.nud_Preco_Unitario)
        Me.grp_Peça.Controls.Add(Me.lbl_Preco_Unitario)
        Me.grp_Peça.Controls.Add(Me.lbl_NCM)
        Me.grp_Peça.Controls.Add(Me.nud_Percentual_ICMS)
        Me.grp_Peça.Controls.Add(Me.txt_NCM)
        Me.grp_Peça.Controls.Add(Me.lbl_Percentual_IPI)
        Me.grp_Peça.Controls.Add(Me.nud_Percentual_IPI)
        Me.grp_Peça.Controls.Add(Me.lbl_Percentual_ICMS)
        Me.grp_Peça.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Peça.Location = New System.Drawing.Point(12, 91)
        Me.grp_Peça.Name = "grp_Peça"
        Me.grp_Peça.Size = New System.Drawing.Size(683, 218)
        Me.grp_Peça.TabIndex = 1
        Me.grp_Peça.TabStop = False
        Me.grp_Peça.Text = "Dados da peça"
        '
        'cbo_Conjunto
        '
        Me.cbo_Conjunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Conjunto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Conjunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Conjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Conjunto.FormattingEnabled = True
        Me.cbo_Conjunto.Location = New System.Drawing.Point(523, 133)
        Me.cbo_Conjunto.Name = "cbo_Conjunto"
        Me.cbo_Conjunto.Size = New System.Drawing.Size(145, 21)
        Me.cbo_Conjunto.TabIndex = 10
        '
        'cbo_Especificacao
        '
        Me.cbo_Especificacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Especificacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Especificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Especificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Especificacao.FormattingEnabled = True
        Me.cbo_Especificacao.Location = New System.Drawing.Point(15, 181)
        Me.cbo_Especificacao.Name = "cbo_Especificacao"
        Me.cbo_Especificacao.Size = New System.Drawing.Size(155, 21)
        Me.cbo_Especificacao.TabIndex = 11
        '
        'txt_Prazo_Final
        '
        Me.txt_Prazo_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prazo_Final.Location = New System.Drawing.Point(310, 181)
        Me.txt_Prazo_Final.MaxLength = 255
        Me.txt_Prazo_Final.Multiline = True
        Me.txt_Prazo_Final.Name = "txt_Prazo_Final"
        Me.txt_Prazo_Final.Size = New System.Drawing.Size(129, 22)
        Me.txt_Prazo_Final.TabIndex = 36
        '
        'lbl_Especificacao
        '
        Me.lbl_Especificacao.AutoSize = True
        Me.lbl_Especificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Especificacao.Location = New System.Drawing.Point(12, 165)
        Me.lbl_Especificacao.Name = "lbl_Especificacao"
        Me.lbl_Especificacao.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Especificacao.TabIndex = 9
        Me.lbl_Especificacao.Text = "Especificação"
        '
        'lbl_Conjunto
        '
        Me.lbl_Conjunto.AutoSize = True
        Me.lbl_Conjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Conjunto.Location = New System.Drawing.Point(520, 117)
        Me.lbl_Conjunto.Name = "lbl_Conjunto"
        Me.lbl_Conjunto.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Conjunto.TabIndex = 8
        Me.lbl_Conjunto.Text = "Conjunto"
        '
        'lbl_Prazo_Final
        '
        Me.lbl_Prazo_Final.AutoSize = True
        Me.lbl_Prazo_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prazo_Final.Location = New System.Drawing.Point(307, 165)
        Me.lbl_Prazo_Final.Name = "lbl_Prazo_Final"
        Me.lbl_Prazo_Final.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Prazo_Final.TabIndex = 34
        Me.lbl_Prazo_Final.Text = "Prazo final"
        '
        'txt_Prazo_Inicial
        '
        Me.txt_Prazo_Inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prazo_Inicial.Location = New System.Drawing.Point(175, 181)
        Me.txt_Prazo_Inicial.MaxLength = 255
        Me.txt_Prazo_Inicial.Multiline = True
        Me.txt_Prazo_Inicial.Name = "txt_Prazo_Inicial"
        Me.txt_Prazo_Inicial.Size = New System.Drawing.Size(129, 22)
        Me.txt_Prazo_Inicial.TabIndex = 33
        '
        'lbl_Prazo_Inicial
        '
        Me.lbl_Prazo_Inicial.AutoSize = True
        Me.lbl_Prazo_Inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prazo_Inicial.Location = New System.Drawing.Point(172, 165)
        Me.lbl_Prazo_Inicial.Name = "lbl_Prazo_Inicial"
        Me.lbl_Prazo_Inicial.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Prazo_Inicial.TabIndex = 27
        Me.lbl_Prazo_Inicial.Text = "Prazo inicial"
        '
        'lbl_Comentarios
        '
        Me.lbl_Comentarios.AutoSize = True
        Me.lbl_Comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Comentarios.Location = New System.Drawing.Point(442, 165)
        Me.lbl_Comentarios.Name = "lbl_Comentarios"
        Me.lbl_Comentarios.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Comentarios.TabIndex = 35
        Me.lbl_Comentarios.Text = "Comentários"
        '
        'nud_Quantidade
        '
        Me.nud_Quantidade.DecimalPlaces = 2
        Me.nud_Quantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Quantidade.InterceptArrowKeys = False
        Me.nud_Quantidade.Location = New System.Drawing.Point(16, 88)
        Me.nud_Quantidade.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Quantidade.Name = "nud_Quantidade"
        Me.nud_Quantidade.Size = New System.Drawing.Size(73, 20)
        Me.nud_Quantidade.TabIndex = 14
        Me.nud_Quantidade.ThousandsSeparator = True
        '
        'txt_Comentarios
        '
        Me.txt_Comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Comentarios.Location = New System.Drawing.Point(445, 181)
        Me.txt_Comentarios.Multiline = True
        Me.txt_Comentarios.Name = "txt_Comentarios"
        Me.txt_Comentarios.Size = New System.Drawing.Size(223, 22)
        Me.txt_Comentarios.TabIndex = 37
        '
        'lbl_Quantidade
        '
        Me.lbl_Quantidade.AutoSize = True
        Me.lbl_Quantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quantidade.Location = New System.Drawing.Point(13, 72)
        Me.lbl_Quantidade.Name = "lbl_Quantidade"
        Me.lbl_Quantidade.Size = New System.Drawing.Size(72, 13)
        Me.lbl_Quantidade.TabIndex = 6
        Me.lbl_Quantidade.Text = "Quantidade"
        '
        'lbl_Origem
        '
        Me.lbl_Origem.AutoSize = True
        Me.lbl_Origem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Origem.Location = New System.Drawing.Point(406, 117)
        Me.lbl_Origem.Name = "lbl_Origem"
        Me.lbl_Origem.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Origem.TabIndex = 26
        Me.lbl_Origem.Text = "Origem"
        '
        'nud_Desconto_Final
        '
        Me.nud_Desconto_Final.DecimalPlaces = 2
        Me.nud_Desconto_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Desconto_Final.InterceptArrowKeys = False
        Me.nud_Desconto_Final.Location = New System.Drawing.Point(196, 134)
        Me.nud_Desconto_Final.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Desconto_Final.Name = "nud_Desconto_Final"
        Me.nud_Desconto_Final.Size = New System.Drawing.Size(83, 20)
        Me.nud_Desconto_Final.TabIndex = 30
        Me.nud_Desconto_Final.ThousandsSeparator = True
        '
        'cbo_Origem
        '
        Me.cbo_Origem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Origem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Origem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Origem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Origem.FormattingEnabled = True
        Me.cbo_Origem.Location = New System.Drawing.Point(409, 133)
        Me.cbo_Origem.Name = "cbo_Origem"
        Me.cbo_Origem.Size = New System.Drawing.Size(108, 21)
        Me.cbo_Origem.TabIndex = 32
        '
        'nud_Valor_ST
        '
        Me.nud_Valor_ST.DecimalPlaces = 2
        Me.nud_Valor_ST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Valor_ST.InterceptArrowKeys = False
        Me.nud_Valor_ST.Location = New System.Drawing.Point(488, 87)
        Me.nud_Valor_ST.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Valor_ST.Name = "nud_Valor_ST"
        Me.nud_Valor_ST.Size = New System.Drawing.Size(83, 20)
        Me.nud_Valor_ST.TabIndex = 20
        Me.nud_Valor_ST.ThousandsSeparator = True
        '
        'lbl_Tipo_Substituicao_Tributaria
        '
        Me.lbl_Tipo_Substituicao_Tributaria.AutoSize = True
        Me.lbl_Tipo_Substituicao_Tributaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo_Substituicao_Tributaria.Location = New System.Drawing.Point(279, 117)
        Me.lbl_Tipo_Substituicao_Tributaria.Name = "lbl_Tipo_Substituicao_Tributaria"
        Me.lbl_Tipo_Substituicao_Tributaria.Size = New System.Drawing.Size(104, 13)
        Me.lbl_Tipo_Substituicao_Tributaria.TabIndex = 25
        Me.lbl_Tipo_Substituicao_Tributaria.Text = "Tipo de sub. trib."
        '
        'lbl_Desconto_Final
        '
        Me.lbl_Desconto_Final.AutoSize = True
        Me.lbl_Desconto_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Desconto_Final.Location = New System.Drawing.Point(193, 118)
        Me.lbl_Desconto_Final.Name = "lbl_Desconto_Final"
        Me.lbl_Desconto_Final.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Desconto_Final.TabIndex = 24
        Me.lbl_Desconto_Final.Text = "% Desc. final"
        '
        'cbo_Tipo_Substituicao_Tributaria
        '
        Me.cbo_Tipo_Substituicao_Tributaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Tipo_Substituicao_Tributaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Tipo_Substituicao_Tributaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tipo_Substituicao_Tributaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tipo_Substituicao_Tributaria.FormattingEnabled = True
        Me.cbo_Tipo_Substituicao_Tributaria.Location = New System.Drawing.Point(282, 133)
        Me.cbo_Tipo_Substituicao_Tributaria.Name = "cbo_Tipo_Substituicao_Tributaria"
        Me.cbo_Tipo_Substituicao_Tributaria.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Tipo_Substituicao_Tributaria.TabIndex = 31
        '
        'cbo_Codigo
        '
        Me.cbo_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Codigo.FormattingEnabled = True
        Me.cbo_Codigo.Location = New System.Drawing.Point(123, 39)
        Me.cbo_Codigo.MaxLength = 255
        Me.cbo_Codigo.Name = "cbo_Codigo"
        Me.cbo_Codigo.Size = New System.Drawing.Size(114, 21)
        Me.cbo_Codigo.TabIndex = 4
        '
        'nud_Desconto_Inicial
        '
        Me.nud_Desconto_Inicial.DecimalPlaces = 2
        Me.nud_Desconto_Inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Desconto_Inicial.InterceptArrowKeys = False
        Me.nud_Desconto_Inicial.Location = New System.Drawing.Point(107, 134)
        Me.nud_Desconto_Inicial.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Desconto_Inicial.Name = "nud_Desconto_Inicial"
        Me.nud_Desconto_Inicial.Size = New System.Drawing.Size(83, 20)
        Me.nud_Desconto_Inicial.TabIndex = 29
        Me.nud_Desconto_Inicial.ThousandsSeparator = True
        '
        'lbl_Desconto_Inicial
        '
        Me.lbl_Desconto_Inicial.AutoSize = True
        Me.lbl_Desconto_Inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Desconto_Inicial.Location = New System.Drawing.Point(104, 118)
        Me.lbl_Desconto_Inicial.Name = "lbl_Desconto_Inicial"
        Me.lbl_Desconto_Inicial.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Desconto_Inicial.TabIndex = 23
        Me.lbl_Desconto_Inicial.Text = "% Desc. custo"
        '
        'lbl_Valor_ST
        '
        Me.lbl_Valor_ST.AutoSize = True
        Me.lbl_Valor_ST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Valor_ST.Location = New System.Drawing.Point(485, 71)
        Me.lbl_Valor_ST.Name = "lbl_Valor_ST"
        Me.lbl_Valor_ST.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Valor_ST.TabIndex = 12
        Me.lbl_Valor_ST.Text = "Valor ST"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Codigo.Location = New System.Drawing.Point(120, 23)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Codigo.TabIndex = 1
        Me.lbl_Codigo.Text = "Código"
        '
        'nud_Frete_Unitario
        '
        Me.nud_Frete_Unitario.DecimalPlaces = 2
        Me.nud_Frete_Unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Frete_Unitario.InterceptArrowKeys = False
        Me.nud_Frete_Unitario.Location = New System.Drawing.Point(15, 134)
        Me.nud_Frete_Unitario.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Frete_Unitario.Name = "nud_Frete_Unitario"
        Me.nud_Frete_Unitario.Size = New System.Drawing.Size(83, 20)
        Me.nud_Frete_Unitario.TabIndex = 28
        Me.nud_Frete_Unitario.ThousandsSeparator = True
        '
        'lbl_Frete_Unitario
        '
        Me.lbl_Frete_Unitario.AutoSize = True
        Me.lbl_Frete_Unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frete_Unitario.Location = New System.Drawing.Point(12, 118)
        Me.lbl_Frete_Unitario.Name = "lbl_Frete_Unitario"
        Me.lbl_Frete_Unitario.Size = New System.Drawing.Size(82, 13)
        Me.lbl_Frete_Unitario.TabIndex = 22
        Me.lbl_Frete_Unitario.Text = "Frete unitário"
        '
        'nud_Preco_Total
        '
        Me.nud_Preco_Total.DecimalPlaces = 2
        Me.nud_Preco_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Preco_Total.InterceptArrowKeys = False
        Me.nud_Preco_Total.Location = New System.Drawing.Point(577, 88)
        Me.nud_Preco_Total.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Preco_Total.Name = "nud_Preco_Total"
        Me.nud_Preco_Total.Size = New System.Drawing.Size(91, 20)
        Me.nud_Preco_Total.TabIndex = 21
        Me.nud_Preco_Total.ThousandsSeparator = True
        '
        'lbl_Preco_Total
        '
        Me.lbl_Preco_Total.AutoSize = True
        Me.lbl_Preco_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Preco_Total.Location = New System.Drawing.Point(574, 72)
        Me.lbl_Preco_Total.Name = "lbl_Preco_Total"
        Me.lbl_Preco_Total.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Preco_Total.TabIndex = 13
        Me.lbl_Preco_Total.Text = "Preço total"
        '
        'lbl_Fornecedor
        '
        Me.lbl_Fornecedor.AutoSize = True
        Me.lbl_Fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fornecedor.Location = New System.Drawing.Point(12, 23)
        Me.lbl_Fornecedor.Name = "lbl_Fornecedor"
        Me.lbl_Fornecedor.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Fornecedor.TabIndex = 0
        Me.lbl_Fornecedor.Text = "Fornecedor"
        '
        'cbo_Fornecedor
        '
        Me.cbo_Fornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Fornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Fornecedor.FormattingEnabled = True
        Me.cbo_Fornecedor.Location = New System.Drawing.Point(15, 39)
        Me.cbo_Fornecedor.Name = "cbo_Fornecedor"
        Me.cbo_Fornecedor.Size = New System.Drawing.Size(102, 21)
        Me.cbo_Fornecedor.TabIndex = 3
        '
        'nud_MVA
        '
        Me.nud_MVA.DecimalPlaces = 2
        Me.nud_MVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_MVA.InterceptArrowKeys = False
        Me.nud_MVA.Location = New System.Drawing.Point(422, 87)
        Me.nud_MVA.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_MVA.Name = "nud_MVA"
        Me.nud_MVA.Size = New System.Drawing.Size(60, 20)
        Me.nud_MVA.TabIndex = 19
        Me.nud_MVA.ThousandsSeparator = True
        '
        'txt_Descricao
        '
        Me.txt_Descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descricao.Location = New System.Drawing.Point(243, 39)
        Me.txt_Descricao.Name = "txt_Descricao"
        Me.txt_Descricao.Size = New System.Drawing.Size(424, 20)
        Me.txt_Descricao.TabIndex = 5
        '
        'lbl_Descricao
        '
        Me.lbl_Descricao.AutoSize = True
        Me.lbl_Descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descricao.Location = New System.Drawing.Point(240, 23)
        Me.lbl_Descricao.Name = "lbl_Descricao"
        Me.lbl_Descricao.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Descricao.TabIndex = 2
        Me.lbl_Descricao.Text = "Descrição"
        '
        'lbl_MVA
        '
        Me.lbl_MVA.AutoSize = True
        Me.lbl_MVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MVA.Location = New System.Drawing.Point(419, 71)
        Me.lbl_MVA.Name = "lbl_MVA"
        Me.lbl_MVA.Size = New System.Drawing.Size(33, 13)
        Me.lbl_MVA.TabIndex = 11
        Me.lbl_MVA.Text = "MVA"
        '
        'nud_Preco_Unitario
        '
        Me.nud_Preco_Unitario.DecimalPlaces = 2
        Me.nud_Preco_Unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Preco_Unitario.InterceptArrowKeys = False
        Me.nud_Preco_Unitario.Location = New System.Drawing.Point(95, 88)
        Me.nud_Preco_Unitario.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Preco_Unitario.Name = "nud_Preco_Unitario"
        Me.nud_Preco_Unitario.Size = New System.Drawing.Size(91, 20)
        Me.nud_Preco_Unitario.TabIndex = 15
        Me.nud_Preco_Unitario.ThousandsSeparator = True
        '
        'lbl_Preco_Unitario
        '
        Me.lbl_Preco_Unitario.AutoSize = True
        Me.lbl_Preco_Unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Preco_Unitario.Location = New System.Drawing.Point(92, 72)
        Me.lbl_Preco_Unitario.Name = "lbl_Preco_Unitario"
        Me.lbl_Preco_Unitario.Size = New System.Drawing.Size(86, 13)
        Me.lbl_Preco_Unitario.TabIndex = 7
        Me.lbl_Preco_Unitario.Text = "Preço unitário"
        '
        'lbl_NCM
        '
        Me.lbl_NCM.AutoSize = True
        Me.lbl_NCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NCM.Location = New System.Drawing.Point(324, 71)
        Me.lbl_NCM.Name = "lbl_NCM"
        Me.lbl_NCM.Size = New System.Drawing.Size(34, 13)
        Me.lbl_NCM.TabIndex = 10
        Me.lbl_NCM.Text = "NCM"
        '
        'nud_Percentual_ICMS
        '
        Me.nud_Percentual_ICMS.DecimalPlaces = 2
        Me.nud_Percentual_ICMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_ICMS.InterceptArrowKeys = False
        Me.nud_Percentual_ICMS.Location = New System.Drawing.Point(261, 88)
        Me.nud_Percentual_ICMS.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_ICMS.Name = "nud_Percentual_ICMS"
        Me.nud_Percentual_ICMS.Size = New System.Drawing.Size(60, 20)
        Me.nud_Percentual_ICMS.TabIndex = 17
        Me.nud_Percentual_ICMS.ThousandsSeparator = True
        '
        'txt_NCM
        '
        Me.txt_NCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NCM.Location = New System.Drawing.Point(327, 87)
        Me.txt_NCM.MaxLength = 30
        Me.txt_NCM.Name = "txt_NCM"
        Me.txt_NCM.Size = New System.Drawing.Size(89, 20)
        Me.txt_NCM.TabIndex = 18
        '
        'lbl_Percentual_IPI
        '
        Me.lbl_Percentual_IPI.AutoSize = True
        Me.lbl_Percentual_IPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_IPI.Location = New System.Drawing.Point(189, 72)
        Me.lbl_Percentual_IPI.Name = "lbl_Percentual_IPI"
        Me.lbl_Percentual_IPI.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Percentual_IPI.TabIndex = 8
        Me.lbl_Percentual_IPI.Text = "% IPI"
        '
        'nud_Percentual_IPI
        '
        Me.nud_Percentual_IPI.DecimalPlaces = 2
        Me.nud_Percentual_IPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_IPI.InterceptArrowKeys = False
        Me.nud_Percentual_IPI.Location = New System.Drawing.Point(192, 88)
        Me.nud_Percentual_IPI.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_IPI.Name = "nud_Percentual_IPI"
        Me.nud_Percentual_IPI.Size = New System.Drawing.Size(60, 20)
        Me.nud_Percentual_IPI.TabIndex = 16
        Me.nud_Percentual_IPI.ThousandsSeparator = True
        '
        'lbl_Percentual_ICMS
        '
        Me.lbl_Percentual_ICMS.AutoSize = True
        Me.lbl_Percentual_ICMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_ICMS.Location = New System.Drawing.Point(258, 72)
        Me.lbl_Percentual_ICMS.Name = "lbl_Percentual_ICMS"
        Me.lbl_Percentual_ICMS.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Percentual_ICMS.TabIndex = 9
        Me.lbl_Percentual_ICMS.Text = "% ICMS"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.ImageKey = "remove-button.png"
        Me.btn_Cancelar.ImageList = Me.img_List_16x16
        Me.btn_Cancelar.Location = New System.Drawing.Point(254, 320)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "  Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
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
        'btn_Salvar
        '
        Me.btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salvar.ImageKey = "save-file-option.png"
        Me.btn_Salvar.ImageList = Me.img_List_16x16
        Me.btn_Salvar.Location = New System.Drawing.Point(362, 320)
        Me.btn_Salvar.Name = "btn_Salvar"
        Me.btn_Salvar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Salvar.TabIndex = 3
        Me.btn_Salvar.Text = "  Salvar"
        Me.btn_Salvar.UseVisualStyleBackColor = True
        '
        'nud_Quantidade_Inicial
        '
        Me.nud_Quantidade_Inicial.DecimalPlaces = 2
        Me.nud_Quantidade_Inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Quantidade_Inicial.InterceptArrowKeys = False
        Me.nud_Quantidade_Inicial.Location = New System.Drawing.Point(525, 320)
        Me.nud_Quantidade_Inicial.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Quantidade_Inicial.Name = "nud_Quantidade_Inicial"
        Me.nud_Quantidade_Inicial.Size = New System.Drawing.Size(73, 20)
        Me.nud_Quantidade_Inicial.TabIndex = 15
        Me.nud_Quantidade_Inicial.ThousandsSeparator = True
        Me.nud_Quantidade_Inicial.Visible = False
        '
        'Controle_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 356)
        Me.Controls.Add(Me.nud_Quantidade_Inicial)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Salvar)
        Me.Controls.Add(Me.grp_Peça)
        Me.Controls.Add(Me.grp_Controles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Controle_Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de item"
        Me.grp_Controles.ResumeLayout(False)
        Me.grp_Controles.PerformLayout()
        Me.grp_Peça.ResumeLayout(False)
        Me.grp_Peça.PerformLayout()
        CType(Me.nud_Quantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Desconto_Final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Valor_ST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Desconto_Inicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Frete_Unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Preco_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_MVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Preco_Unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_ICMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_IPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Quantidade_Inicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbo_Status As ComboBox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents cbo_Tipo_Item As ComboBox
    Friend WithEvents lbl_Tipo_Item As Label
    Friend WithEvents cbo_Justificativa_Aprovacao As ComboBox
    Friend WithEvents lbl_Justificativa_Aprovacao As Label
    Friend WithEvents cbo_Status_Aprovacao As ComboBox
    Friend WithEvents lbl_Status_Aprovacao As Label
    Friend WithEvents grp_Controles As GroupBox
    Friend WithEvents grp_Peça As GroupBox
    Friend WithEvents lbl_Fornecedor As Label
    Friend WithEvents cbo_Fornecedor As ComboBox
    Friend WithEvents cbo_Codigo As ComboBox
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents lbl_Percentual_IPI As Label
    Friend WithEvents nud_Percentual_IPI As NumericUpDown
    Friend WithEvents lbl_Descricao As Label
    Friend WithEvents txt_Descricao As TextBox
    Friend WithEvents nud_Percentual_ICMS As NumericUpDown
    Friend WithEvents lbl_Percentual_ICMS As Label
    Friend WithEvents nud_MVA As NumericUpDown
    Friend WithEvents lbl_MVA As Label
    Friend WithEvents lbl_NCM As Label
    Friend WithEvents txt_NCM As TextBox
    Friend WithEvents nud_Quantidade As NumericUpDown
    Friend WithEvents lbl_Quantidade As Label
    Friend WithEvents nud_Valor_ST As NumericUpDown
    Friend WithEvents lbl_Valor_ST As Label
    Friend WithEvents lbl_Tipo_Substituicao_Tributaria As Label
    Friend WithEvents cbo_Tipo_Substituicao_Tributaria As ComboBox
    Friend WithEvents lbl_Origem As Label
    Friend WithEvents cbo_Origem As ComboBox
    Friend WithEvents nud_Frete_Unitario As NumericUpDown
    Friend WithEvents lbl_Frete_Unitario As Label
    Friend WithEvents nud_Preco_Total As NumericUpDown
    Friend WithEvents lbl_Preco_Total As Label
    Friend WithEvents nud_Preco_Unitario As NumericUpDown
    Friend WithEvents lbl_Preco_Unitario As Label
    Friend WithEvents nud_Desconto_Inicial As NumericUpDown
    Friend WithEvents lbl_Desconto_Inicial As Label
    Friend WithEvents nud_Desconto_Final As NumericUpDown
    Friend WithEvents lbl_Desconto_Final As Label
    Friend WithEvents lbl_Comentarios As Label
    Friend WithEvents txt_Comentarios As TextBox
    Friend WithEvents txt_Prazo_Inicial As TextBox
    Friend WithEvents lbl_Prazo_Inicial As Label
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Salvar As Button
    Friend WithEvents txt_Prazo_Final As TextBox
    Friend WithEvents lbl_Prazo_Final As Label
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents cbo_Conjunto As ComboBox
    Friend WithEvents lbl_Conjunto As Label
    Friend WithEvents cbo_Especificacao As ComboBox
    Friend WithEvents lbl_Especificacao As Label
    Friend WithEvents nud_Quantidade_Inicial As NumericUpDown
End Class
