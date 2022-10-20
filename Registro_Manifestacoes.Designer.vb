<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_Manifestacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Manifestacoes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_Descricao_Abertura = New System.Windows.Forms.TextBox()
        Me.lbl_Descricao_Abertura = New System.Windows.Forms.Label()
        Me.lbl_Data_Abertura = New System.Windows.Forms.Label()
        Me.grp_Abertura = New System.Windows.Forms.GroupBox()
        Me.txt_Email_Abertura = New System.Windows.Forms.TextBox()
        Me.lbl_Email_Abertura = New System.Windows.Forms.Label()
        Me.dtp_Data_Abertura = New System.Windows.Forms.DateTimePicker()
        Me.txt_Pessoa_Abertura = New System.Windows.Forms.TextBox()
        Me.lbl_Pessoa_Abertura = New System.Windows.Forms.Label()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.mns_Menu = New System.Windows.Forms.MenuStrip()
        Me.mnsi_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsi_Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsi_Excluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.grp_Fechamento = New System.Windows.Forms.GroupBox()
        Me.txt_Descricao_Fechamento = New System.Windows.Forms.TextBox()
        Me.lbl_Descricao_Fechamento = New System.Windows.Forms.Label()
        Me.txt_Email_Fechamento = New System.Windows.Forms.TextBox()
        Me.lbl_Email_Fechamento = New System.Windows.Forms.Label()
        Me.dtp_Data_Fechamento = New System.Windows.Forms.DateTimePicker()
        Me.txt_Pessoa_Fechamento = New System.Windows.Forms.TextBox()
        Me.lbl_Pessoa_Fechamento = New System.Windows.Forms.Label()
        Me.lbl_Data_Fechamento = New System.Windows.Forms.Label()
        Me.cbo_Tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.cbo_Prioridade = New System.Windows.Forms.ComboBox()
        Me.lbl_Prioridade = New System.Windows.Forms.Label()
        Me.cbo_Status = New System.Windows.Forms.ComboBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.txt_id_registro_manifestacao = New System.Windows.Forms.TextBox()
        Me.tbp_Historico_Alteracoes = New System.Windows.Forms.TabPage()
        Me.dtg_Historico = New System.Windows.Forms.DataGridView()
        Me.tbp_Comentarios = New System.Windows.Forms.TabPage()
        Me.btn_Excluir_Comentario = New System.Windows.Forms.Button()
        Me.btn_Adicionar_Comentario = New System.Windows.Forms.Button()
        Me.dtg_Comentarios = New System.Windows.Forms.DataGridView()
        Me.tbc_Outros = New System.Windows.Forms.TabControl()
        Me.tbp_Imagens = New System.Windows.Forms.TabPage()
        Me.txt_Tamanho_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Tamanho_Total = New System.Windows.Forms.Label()
        Me.dtg_Imagens = New System.Windows.Forms.DataGridView()
        Me.btn_Excluir_Imagem = New System.Windows.Forms.Button()
        Me.btn_Adicionar_Imagem = New System.Windows.Forms.Button()
        Me.cms_Menu_Imagem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Salvar_Como = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_comentario_excluido = New System.Windows.Forms.TextBox()
        Me.txt_imagem_excluida = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Salvar = New System.Windows.Forms.Button()
        Me.txt_id_status_inicial = New System.Windows.Forms.TextBox()
        Me.grp_Abertura.SuspendLayout()
        Me.mns_Menu.SuspendLayout()
        Me.grp_Fechamento.SuspendLayout()
        Me.tbp_Historico_Alteracoes.SuspendLayout()
        CType(Me.dtg_Historico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_Comentarios.SuspendLayout()
        CType(Me.dtg_Comentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc_Outros.SuspendLayout()
        Me.tbp_Imagens.SuspendLayout()
        CType(Me.dtg_Imagens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Menu_Imagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Descricao_Abertura
        '
        Me.txt_Descricao_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descricao_Abertura.Location = New System.Drawing.Point(16, 37)
        Me.txt_Descricao_Abertura.MaxLength = 255
        Me.txt_Descricao_Abertura.Name = "txt_Descricao_Abertura"
        Me.txt_Descricao_Abertura.Size = New System.Drawing.Size(360, 20)
        Me.txt_Descricao_Abertura.TabIndex = 54
        '
        'lbl_Descricao_Abertura
        '
        Me.lbl_Descricao_Abertura.AutoSize = True
        Me.lbl_Descricao_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descricao_Abertura.Location = New System.Drawing.Point(13, 21)
        Me.lbl_Descricao_Abertura.Name = "lbl_Descricao_Abertura"
        Me.lbl_Descricao_Abertura.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Descricao_Abertura.TabIndex = 53
        Me.lbl_Descricao_Abertura.Text = "Descrição"
        '
        'lbl_Data_Abertura
        '
        Me.lbl_Data_Abertura.AutoSize = True
        Me.lbl_Data_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Abertura.Location = New System.Drawing.Point(379, 21)
        Me.lbl_Data_Abertura.Name = "lbl_Data_Abertura"
        Me.lbl_Data_Abertura.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Data_Abertura.TabIndex = 56
        Me.lbl_Data_Abertura.Text = "Data e hora"
        '
        'grp_Abertura
        '
        Me.grp_Abertura.Controls.Add(Me.txt_Descricao_Abertura)
        Me.grp_Abertura.Controls.Add(Me.lbl_Descricao_Abertura)
        Me.grp_Abertura.Controls.Add(Me.txt_Email_Abertura)
        Me.grp_Abertura.Controls.Add(Me.lbl_Email_Abertura)
        Me.grp_Abertura.Controls.Add(Me.dtp_Data_Abertura)
        Me.grp_Abertura.Controls.Add(Me.txt_Pessoa_Abertura)
        Me.grp_Abertura.Controls.Add(Me.lbl_Pessoa_Abertura)
        Me.grp_Abertura.Controls.Add(Me.lbl_Data_Abertura)
        Me.grp_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Abertura.Location = New System.Drawing.Point(12, 74)
        Me.grp_Abertura.Name = "grp_Abertura"
        Me.grp_Abertura.Size = New System.Drawing.Size(529, 114)
        Me.grp_Abertura.TabIndex = 57
        Me.grp_Abertura.TabStop = False
        Me.grp_Abertura.Text = "Dados de abertura"
        '
        'txt_Email_Abertura
        '
        Me.txt_Email_Abertura.Enabled = False
        Me.txt_Email_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email_Abertura.Location = New System.Drawing.Point(285, 80)
        Me.txt_Email_Abertura.MaxLength = 60
        Me.txt_Email_Abertura.Name = "txt_Email_Abertura"
        Me.txt_Email_Abertura.Size = New System.Drawing.Size(226, 20)
        Me.txt_Email_Abertura.TabIndex = 61
        '
        'lbl_Email_Abertura
        '
        Me.lbl_Email_Abertura.AutoSize = True
        Me.lbl_Email_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email_Abertura.Location = New System.Drawing.Point(282, 64)
        Me.lbl_Email_Abertura.Name = "lbl_Email_Abertura"
        Me.lbl_Email_Abertura.Size = New System.Drawing.Size(103, 13)
        Me.lbl_Email_Abertura.TabIndex = 60
        Me.lbl_Email_Abertura.Text = "E-mail solicitante"
        '
        'dtp_Data_Abertura
        '
        Me.dtp_Data_Abertura.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtp_Data_Abertura.Enabled = False
        Me.dtp_Data_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Abertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Abertura.Location = New System.Drawing.Point(382, 37)
        Me.dtp_Data_Abertura.Name = "dtp_Data_Abertura"
        Me.dtp_Data_Abertura.Size = New System.Drawing.Size(129, 20)
        Me.dtp_Data_Abertura.TabIndex = 60
        '
        'txt_Pessoa_Abertura
        '
        Me.txt_Pessoa_Abertura.Enabled = False
        Me.txt_Pessoa_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pessoa_Abertura.Location = New System.Drawing.Point(16, 80)
        Me.txt_Pessoa_Abertura.MaxLength = 60
        Me.txt_Pessoa_Abertura.Name = "txt_Pessoa_Abertura"
        Me.txt_Pessoa_Abertura.Size = New System.Drawing.Size(263, 20)
        Me.txt_Pessoa_Abertura.TabIndex = 59
        '
        'lbl_Pessoa_Abertura
        '
        Me.lbl_Pessoa_Abertura.AutoSize = True
        Me.lbl_Pessoa_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pessoa_Abertura.Location = New System.Drawing.Point(13, 64)
        Me.lbl_Pessoa_Abertura.Name = "lbl_Pessoa_Abertura"
        Me.lbl_Pessoa_Abertura.Size = New System.Drawing.Size(101, 13)
        Me.lbl_Pessoa_Abertura.TabIndex = 58
        Me.lbl_Pessoa_Abertura.Text = "Nome solicitante"
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
        'mns_Menu
        '
        Me.mns_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsi_Adicionar, Me.mnsi_Editar, Me.mnsi_Excluir})
        Me.mns_Menu.Location = New System.Drawing.Point(0, 0)
        Me.mns_Menu.Name = "mns_Menu"
        Me.mns_Menu.ShowItemToolTips = True
        Me.mns_Menu.Size = New System.Drawing.Size(551, 24)
        Me.mns_Menu.TabIndex = 87
        Me.mns_Menu.Text = "MenuStrip1"
        '
        'mnsi_Adicionar
        '
        Me.mnsi_Adicionar.Image = Global.Eurolift_Services.My.Resources.Resources.add_square_button
        Me.mnsi_Adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnsi_Adicionar.Name = "mnsi_Adicionar"
        Me.mnsi_Adicionar.Size = New System.Drawing.Size(92, 20)
        Me.mnsi_Adicionar.Text = "  Adicionar"
        Me.mnsi_Adicionar.Visible = False
        '
        'mnsi_Editar
        '
        Me.mnsi_Editar.Image = Global.Eurolift_Services.My.Resources.Resources.font_selection_editor
        Me.mnsi_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnsi_Editar.Name = "mnsi_Editar"
        Me.mnsi_Editar.Size = New System.Drawing.Size(71, 20)
        Me.mnsi_Editar.Text = "  Editar"
        '
        'mnsi_Excluir
        '
        Me.mnsi_Excluir.Image = Global.Eurolift_Services.My.Resources.Resources.trash
        Me.mnsi_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnsi_Excluir.Name = "mnsi_Excluir"
        Me.mnsi_Excluir.Size = New System.Drawing.Size(76, 20)
        Me.mnsi_Excluir.Text = "  Excluir"
        Me.mnsi_Excluir.Visible = False
        '
        'grp_Fechamento
        '
        Me.grp_Fechamento.Controls.Add(Me.txt_Descricao_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.lbl_Descricao_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.txt_Email_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.lbl_Email_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.dtp_Data_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.txt_Pessoa_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.lbl_Pessoa_Fechamento)
        Me.grp_Fechamento.Controls.Add(Me.lbl_Data_Fechamento)
        Me.grp_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Fechamento.Location = New System.Drawing.Point(12, 453)
        Me.grp_Fechamento.Name = "grp_Fechamento"
        Me.grp_Fechamento.Size = New System.Drawing.Size(529, 116)
        Me.grp_Fechamento.TabIndex = 88
        Me.grp_Fechamento.TabStop = False
        Me.grp_Fechamento.Text = "Dados de fechamento"
        '
        'txt_Descricao_Fechamento
        '
        Me.txt_Descricao_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descricao_Fechamento.Location = New System.Drawing.Point(16, 37)
        Me.txt_Descricao_Fechamento.MaxLength = 255
        Me.txt_Descricao_Fechamento.Name = "txt_Descricao_Fechamento"
        Me.txt_Descricao_Fechamento.Size = New System.Drawing.Size(360, 20)
        Me.txt_Descricao_Fechamento.TabIndex = 54
        '
        'lbl_Descricao_Fechamento
        '
        Me.lbl_Descricao_Fechamento.AutoSize = True
        Me.lbl_Descricao_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descricao_Fechamento.Location = New System.Drawing.Point(13, 21)
        Me.lbl_Descricao_Fechamento.Name = "lbl_Descricao_Fechamento"
        Me.lbl_Descricao_Fechamento.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Descricao_Fechamento.TabIndex = 53
        Me.lbl_Descricao_Fechamento.Text = "Descrição"
        '
        'txt_Email_Fechamento
        '
        Me.txt_Email_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email_Fechamento.Location = New System.Drawing.Point(285, 80)
        Me.txt_Email_Fechamento.MaxLength = 60
        Me.txt_Email_Fechamento.Name = "txt_Email_Fechamento"
        Me.txt_Email_Fechamento.Size = New System.Drawing.Size(226, 20)
        Me.txt_Email_Fechamento.TabIndex = 61
        '
        'lbl_Email_Fechamento
        '
        Me.lbl_Email_Fechamento.AutoSize = True
        Me.lbl_Email_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email_Fechamento.Location = New System.Drawing.Point(282, 64)
        Me.lbl_Email_Fechamento.Name = "lbl_Email_Fechamento"
        Me.lbl_Email_Fechamento.Size = New System.Drawing.Size(113, 13)
        Me.lbl_Email_Fechamento.TabIndex = 60
        Me.lbl_Email_Fechamento.Text = "E-mail responsável"
        '
        'dtp_Data_Fechamento
        '
        Me.dtp_Data_Fechamento.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtp_Data_Fechamento.Enabled = False
        Me.dtp_Data_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Fechamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Fechamento.Location = New System.Drawing.Point(382, 37)
        Me.dtp_Data_Fechamento.Name = "dtp_Data_Fechamento"
        Me.dtp_Data_Fechamento.Size = New System.Drawing.Size(129, 20)
        Me.dtp_Data_Fechamento.TabIndex = 60
        '
        'txt_Pessoa_Fechamento
        '
        Me.txt_Pessoa_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pessoa_Fechamento.Location = New System.Drawing.Point(16, 80)
        Me.txt_Pessoa_Fechamento.MaxLength = 60
        Me.txt_Pessoa_Fechamento.Name = "txt_Pessoa_Fechamento"
        Me.txt_Pessoa_Fechamento.Size = New System.Drawing.Size(263, 20)
        Me.txt_Pessoa_Fechamento.TabIndex = 59
        '
        'lbl_Pessoa_Fechamento
        '
        Me.lbl_Pessoa_Fechamento.AutoSize = True
        Me.lbl_Pessoa_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pessoa_Fechamento.Location = New System.Drawing.Point(13, 64)
        Me.lbl_Pessoa_Fechamento.Name = "lbl_Pessoa_Fechamento"
        Me.lbl_Pessoa_Fechamento.Size = New System.Drawing.Size(111, 13)
        Me.lbl_Pessoa_Fechamento.TabIndex = 58
        Me.lbl_Pessoa_Fechamento.Text = "Nome responsável"
        '
        'lbl_Data_Fechamento
        '
        Me.lbl_Data_Fechamento.AutoSize = True
        Me.lbl_Data_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Fechamento.Location = New System.Drawing.Point(379, 21)
        Me.lbl_Data_Fechamento.Name = "lbl_Data_Fechamento"
        Me.lbl_Data_Fechamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Data_Fechamento.TabIndex = 56
        Me.lbl_Data_Fechamento.Text = "Data e hora"
        '
        'cbo_Tipo
        '
        Me.cbo_Tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Tipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tipo.FormattingEnabled = True
        Me.cbo_Tipo.Location = New System.Drawing.Point(142, 47)
        Me.cbo_Tipo.Name = "cbo_Tipo"
        Me.cbo_Tipo.Size = New System.Drawing.Size(124, 21)
        Me.cbo_Tipo.TabIndex = 90
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo.Location = New System.Drawing.Point(139, 31)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Tipo.TabIndex = 89
        Me.lbl_Tipo.Text = "Tipo"
        '
        'cbo_Prioridade
        '
        Me.cbo_Prioridade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Prioridade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Prioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Prioridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Prioridade.FormattingEnabled = True
        Me.cbo_Prioridade.Location = New System.Drawing.Point(12, 47)
        Me.cbo_Prioridade.Name = "cbo_Prioridade"
        Me.cbo_Prioridade.Size = New System.Drawing.Size(124, 21)
        Me.cbo_Prioridade.TabIndex = 92
        '
        'lbl_Prioridade
        '
        Me.lbl_Prioridade.AutoSize = True
        Me.lbl_Prioridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prioridade.Location = New System.Drawing.Point(9, 31)
        Me.lbl_Prioridade.Name = "lbl_Prioridade"
        Me.lbl_Prioridade.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Prioridade.TabIndex = 91
        Me.lbl_Prioridade.Text = "Prioridade"
        '
        'cbo_Status
        '
        Me.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Location = New System.Drawing.Point(272, 47)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(124, 21)
        Me.cbo_Status.TabIndex = 94
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(269, 31)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Status.TabIndex = 93
        Me.lbl_Status.Text = "Status"
        '
        'txt_id_registro_manifestacao
        '
        Me.txt_id_registro_manifestacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_registro_manifestacao.Location = New System.Drawing.Point(426, 31)
        Me.txt_id_registro_manifestacao.Name = "txt_id_registro_manifestacao"
        Me.txt_id_registro_manifestacao.Size = New System.Drawing.Size(49, 20)
        Me.txt_id_registro_manifestacao.TabIndex = 96
        Me.txt_id_registro_manifestacao.Visible = False
        '
        'tbp_Historico_Alteracoes
        '
        Me.tbp_Historico_Alteracoes.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Historico_Alteracoes.Controls.Add(Me.dtg_Historico)
        Me.tbp_Historico_Alteracoes.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Historico_Alteracoes.Name = "tbp_Historico_Alteracoes"
        Me.tbp_Historico_Alteracoes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Historico_Alteracoes.Size = New System.Drawing.Size(523, 227)
        Me.tbp_Historico_Alteracoes.TabIndex = 1
        Me.tbp_Historico_Alteracoes.Text = "Histórico"
        '
        'dtg_Historico
        '
        Me.dtg_Historico.AllowUserToAddRows = False
        Me.dtg_Historico.AllowUserToDeleteRows = False
        Me.dtg_Historico.AllowUserToResizeColumns = False
        Me.dtg_Historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Historico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Historico.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Historico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Historico.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_Historico.Location = New System.Drawing.Point(12, 15)
        Me.dtg_Historico.MultiSelect = False
        Me.dtg_Historico.Name = "dtg_Historico"
        Me.dtg_Historico.ReadOnly = True
        Me.dtg_Historico.RowHeadersVisible = False
        Me.dtg_Historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Historico.Size = New System.Drawing.Size(495, 196)
        Me.dtg_Historico.TabIndex = 59
        '
        'tbp_Comentarios
        '
        Me.tbp_Comentarios.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Comentarios.Controls.Add(Me.btn_Excluir_Comentario)
        Me.tbp_Comentarios.Controls.Add(Me.btn_Adicionar_Comentario)
        Me.tbp_Comentarios.Controls.Add(Me.dtg_Comentarios)
        Me.tbp_Comentarios.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Comentarios.Name = "tbp_Comentarios"
        Me.tbp_Comentarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Comentarios.Size = New System.Drawing.Size(523, 227)
        Me.tbp_Comentarios.TabIndex = 0
        Me.tbp_Comentarios.Text = "Comentários"
        '
        'btn_Excluir_Comentario
        '
        Me.btn_Excluir_Comentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Excluir_Comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Excluir_Comentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Excluir_Comentario.ImageKey = "trash.png"
        Me.btn_Excluir_Comentario.ImageList = Me.img_List_16x16
        Me.btn_Excluir_Comentario.Location = New System.Drawing.Point(119, 6)
        Me.btn_Excluir_Comentario.Name = "btn_Excluir_Comentario"
        Me.btn_Excluir_Comentario.Size = New System.Drawing.Size(102, 25)
        Me.btn_Excluir_Comentario.TabIndex = 98
        Me.btn_Excluir_Comentario.Text = "  Excluir"
        Me.btn_Excluir_Comentario.UseVisualStyleBackColor = True
        '
        'btn_Adicionar_Comentario
        '
        Me.btn_Adicionar_Comentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Adicionar_Comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Adicionar_Comentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Adicionar_Comentario.ImageKey = "plus-sign-in-a-black-circle.png"
        Me.btn_Adicionar_Comentario.ImageList = Me.img_List_16x16
        Me.btn_Adicionar_Comentario.Location = New System.Drawing.Point(11, 6)
        Me.btn_Adicionar_Comentario.Name = "btn_Adicionar_Comentario"
        Me.btn_Adicionar_Comentario.Size = New System.Drawing.Size(102, 25)
        Me.btn_Adicionar_Comentario.TabIndex = 96
        Me.btn_Adicionar_Comentario.Text = "  Adicionar"
        Me.btn_Adicionar_Comentario.UseVisualStyleBackColor = True
        '
        'dtg_Comentarios
        '
        Me.dtg_Comentarios.AllowUserToAddRows = False
        Me.dtg_Comentarios.AllowUserToDeleteRows = False
        Me.dtg_Comentarios.AllowUserToResizeColumns = False
        Me.dtg_Comentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Comentarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Comentarios.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Comentarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_Comentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Comentarios.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtg_Comentarios.Location = New System.Drawing.Point(12, 35)
        Me.dtg_Comentarios.MultiSelect = False
        Me.dtg_Comentarios.Name = "dtg_Comentarios"
        Me.dtg_Comentarios.ReadOnly = True
        Me.dtg_Comentarios.RowHeadersVisible = False
        Me.dtg_Comentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Comentarios.Size = New System.Drawing.Size(495, 178)
        Me.dtg_Comentarios.TabIndex = 58
        '
        'tbc_Outros
        '
        Me.tbc_Outros.Controls.Add(Me.tbp_Comentarios)
        Me.tbc_Outros.Controls.Add(Me.tbp_Imagens)
        Me.tbc_Outros.Controls.Add(Me.tbp_Historico_Alteracoes)
        Me.tbc_Outros.Location = New System.Drawing.Point(12, 194)
        Me.tbc_Outros.Name = "tbc_Outros"
        Me.tbc_Outros.SelectedIndex = 0
        Me.tbc_Outros.Size = New System.Drawing.Size(531, 253)
        Me.tbc_Outros.TabIndex = 95
        '
        'tbp_Imagens
        '
        Me.tbp_Imagens.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Imagens.Controls.Add(Me.txt_Tamanho_Total)
        Me.tbp_Imagens.Controls.Add(Me.lbl_Tamanho_Total)
        Me.tbp_Imagens.Controls.Add(Me.dtg_Imagens)
        Me.tbp_Imagens.Controls.Add(Me.btn_Excluir_Imagem)
        Me.tbp_Imagens.Controls.Add(Me.btn_Adicionar_Imagem)
        Me.tbp_Imagens.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Imagens.Name = "tbp_Imagens"
        Me.tbp_Imagens.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Imagens.Size = New System.Drawing.Size(523, 227)
        Me.tbp_Imagens.TabIndex = 2
        Me.tbp_Imagens.Text = "Imagens"
        '
        'txt_Tamanho_Total
        '
        Me.txt_Tamanho_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tamanho_Total.Location = New System.Drawing.Point(333, 204)
        Me.txt_Tamanho_Total.MaxLength = 30
        Me.txt_Tamanho_Total.Name = "txt_Tamanho_Total"
        Me.txt_Tamanho_Total.Size = New System.Drawing.Size(135, 20)
        Me.txt_Tamanho_Total.TabIndex = 104
        Me.txt_Tamanho_Total.Visible = False
        '
        'lbl_Tamanho_Total
        '
        Me.lbl_Tamanho_Total.AutoSize = True
        Me.lbl_Tamanho_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tamanho_Total.Location = New System.Drawing.Point(11, 206)
        Me.lbl_Tamanho_Total.Name = "lbl_Tamanho_Total"
        Me.lbl_Tamanho_Total.Size = New System.Drawing.Size(102, 13)
        Me.lbl_Tamanho_Total.TabIndex = 103
        Me.lbl_Tamanho_Total.Text = "Tamanho total: 0 kb"
        '
        'dtg_Imagens
        '
        Me.dtg_Imagens.AllowUserToAddRows = False
        Me.dtg_Imagens.AllowUserToDeleteRows = False
        Me.dtg_Imagens.AllowUserToResizeColumns = False
        Me.dtg_Imagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Imagens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Imagens.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Imagens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtg_Imagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Imagens.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtg_Imagens.Location = New System.Drawing.Point(12, 35)
        Me.dtg_Imagens.MultiSelect = False
        Me.dtg_Imagens.Name = "dtg_Imagens"
        Me.dtg_Imagens.ReadOnly = True
        Me.dtg_Imagens.RowHeadersVisible = False
        Me.dtg_Imagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Imagens.Size = New System.Drawing.Size(495, 168)
        Me.dtg_Imagens.TabIndex = 99
        '
        'btn_Excluir_Imagem
        '
        Me.btn_Excluir_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Excluir_Imagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Excluir_Imagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Excluir_Imagem.ImageKey = "trash.png"
        Me.btn_Excluir_Imagem.ImageList = Me.img_List_16x16
        Me.btn_Excluir_Imagem.Location = New System.Drawing.Point(119, 6)
        Me.btn_Excluir_Imagem.Name = "btn_Excluir_Imagem"
        Me.btn_Excluir_Imagem.Size = New System.Drawing.Size(102, 25)
        Me.btn_Excluir_Imagem.TabIndex = 102
        Me.btn_Excluir_Imagem.Text = "  Excluir"
        Me.btn_Excluir_Imagem.UseVisualStyleBackColor = True
        '
        'btn_Adicionar_Imagem
        '
        Me.btn_Adicionar_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Adicionar_Imagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Adicionar_Imagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Adicionar_Imagem.ImageKey = "plus-sign-in-a-black-circle.png"
        Me.btn_Adicionar_Imagem.ImageList = Me.img_List_16x16
        Me.btn_Adicionar_Imagem.Location = New System.Drawing.Point(11, 6)
        Me.btn_Adicionar_Imagem.Name = "btn_Adicionar_Imagem"
        Me.btn_Adicionar_Imagem.Size = New System.Drawing.Size(102, 25)
        Me.btn_Adicionar_Imagem.TabIndex = 100
        Me.btn_Adicionar_Imagem.Text = "  Adicionar"
        Me.btn_Adicionar_Imagem.UseVisualStyleBackColor = True
        '
        'cms_Menu_Imagem
        '
        Me.cms_Menu_Imagem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.tsmi_Salvar_Como})
        Me.cms_Menu_Imagem.Name = "ContextMenuStrip1"
        Me.cms_Menu_Imagem.Size = New System.Drawing.Size(140, 48)
        Me.cms_Menu_Imagem.Text = "Importar"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.picture
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AbrirToolStripMenuItem.Text = "Visualizar"
        '
        'tsmi_Salvar_Como
        '
        Me.tsmi_Salvar_Como.Image = Global.Eurolift_Services.My.Resources.Resources.save_file_option
        Me.tsmi_Salvar_Como.Name = "tsmi_Salvar_Como"
        Me.tsmi_Salvar_Como.Size = New System.Drawing.Size(139, 22)
        Me.tsmi_Salvar_Como.Text = "Salvar como"
        '
        'txt_comentario_excluido
        '
        Me.txt_comentario_excluido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentario_excluido.Location = New System.Drawing.Point(481, 31)
        Me.txt_comentario_excluido.Name = "txt_comentario_excluido"
        Me.txt_comentario_excluido.Size = New System.Drawing.Size(49, 20)
        Me.txt_comentario_excluido.TabIndex = 97
        Me.txt_comentario_excluido.Visible = False
        '
        'txt_imagem_excluida
        '
        Me.txt_imagem_excluida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_imagem_excluida.Location = New System.Drawing.Point(481, 57)
        Me.txt_imagem_excluida.Name = "txt_imagem_excluida"
        Me.txt_imagem_excluida.Size = New System.Drawing.Size(49, 20)
        Me.txt_imagem_excluida.TabIndex = 98
        Me.txt_imagem_excluida.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.ImageKey = "remove-button.png"
        Me.btn_Cancelar.ImageList = Me.img_List_16x16
        Me.btn_Cancelar.Location = New System.Drawing.Point(171, 575)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cancelar.TabIndex = 82
        Me.btn_Cancelar.Text = "  Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Salvar
        '
        Me.btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salvar.ImageKey = "save-file-option.png"
        Me.btn_Salvar.ImageList = Me.img_List_16x16
        Me.btn_Salvar.Location = New System.Drawing.Point(279, 575)
        Me.btn_Salvar.Name = "btn_Salvar"
        Me.btn_Salvar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Salvar.TabIndex = 83
        Me.btn_Salvar.Text = "  Salvar"
        Me.btn_Salvar.UseVisualStyleBackColor = True
        '
        'txt_id_status_inicial
        '
        Me.txt_id_status_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_status_inicial.Location = New System.Drawing.Point(426, 57)
        Me.txt_id_status_inicial.Name = "txt_id_status_inicial"
        Me.txt_id_status_inicial.Size = New System.Drawing.Size(49, 20)
        Me.txt_id_status_inicial.TabIndex = 99
        Me.txt_id_status_inicial.Visible = False
        '
        'Registro_Manifestacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 617)
        Me.Controls.Add(Me.txt_id_status_inicial)
        Me.Controls.Add(Me.txt_imagem_excluida)
        Me.Controls.Add(Me.txt_comentario_excluido)
        Me.Controls.Add(Me.txt_id_registro_manifestacao)
        Me.Controls.Add(Me.cbo_Status)
        Me.Controls.Add(Me.lbl_Tipo)
        Me.Controls.Add(Me.tbc_Outros)
        Me.Controls.Add(Me.cbo_Tipo)
        Me.Controls.Add(Me.grp_Fechamento)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.mns_Menu)
        Me.Controls.Add(Me.lbl_Prioridade)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.cbo_Prioridade)
        Me.Controls.Add(Me.grp_Abertura)
        Me.Controls.Add(Me.btn_Salvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Manifestacoes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de requisições"
        Me.grp_Abertura.ResumeLayout(False)
        Me.grp_Abertura.PerformLayout()
        Me.mns_Menu.ResumeLayout(False)
        Me.mns_Menu.PerformLayout()
        Me.grp_Fechamento.ResumeLayout(False)
        Me.grp_Fechamento.PerformLayout()
        Me.tbp_Historico_Alteracoes.ResumeLayout(False)
        CType(Me.dtg_Historico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_Comentarios.ResumeLayout(False)
        CType(Me.dtg_Comentarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc_Outros.ResumeLayout(False)
        Me.tbp_Imagens.ResumeLayout(False)
        Me.tbp_Imagens.PerformLayout()
        CType(Me.dtg_Imagens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Menu_Imagem.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Descricao_Abertura As TextBox
    Friend WithEvents lbl_Descricao_Abertura As Label
    Friend WithEvents lbl_Data_Abertura As Label
    Friend WithEvents grp_Abertura As GroupBox
    Friend WithEvents txt_Pessoa_Abertura As TextBox
    Friend WithEvents lbl_Pessoa_Abertura As Label
    Friend WithEvents dtp_Data_Abertura As DateTimePicker
    Friend WithEvents txt_Email_Abertura As TextBox
    Friend WithEvents lbl_Email_Abertura As Label
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Salvar As Button
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents mns_Menu As MenuStrip
    Friend WithEvents mnsi_Adicionar As ToolStripMenuItem
    Friend WithEvents mnsi_Editar As ToolStripMenuItem
    Friend WithEvents mnsi_Excluir As ToolStripMenuItem
    Friend WithEvents grp_Fechamento As GroupBox
    Friend WithEvents txt_Descricao_Fechamento As TextBox
    Friend WithEvents lbl_Descricao_Fechamento As Label
    Friend WithEvents txt_Email_Fechamento As TextBox
    Friend WithEvents lbl_Email_Fechamento As Label
    Friend WithEvents dtp_Data_Fechamento As DateTimePicker
    Friend WithEvents txt_Pessoa_Fechamento As TextBox
    Friend WithEvents lbl_Pessoa_Fechamento As Label
    Friend WithEvents lbl_Data_Fechamento As Label
    Friend WithEvents cbo_Tipo As ComboBox
    Friend WithEvents lbl_Tipo As Label
    Friend WithEvents cbo_Prioridade As ComboBox
    Friend WithEvents lbl_Prioridade As Label
    Friend WithEvents cbo_Status As ComboBox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents txt_id_registro_manifestacao As TextBox
    Friend WithEvents tbp_Historico_Alteracoes As TabPage
    Friend WithEvents tbp_Comentarios As TabPage
    Friend WithEvents btn_Excluir_Comentario As Button
    Friend WithEvents btn_Adicionar_Comentario As Button
    Friend WithEvents dtg_Comentarios As DataGridView
    Friend WithEvents tbc_Outros As TabControl
    Friend WithEvents tbp_Imagens As TabPage
    Friend WithEvents btn_Excluir_Imagem As Button
    Friend WithEvents btn_Adicionar_Imagem As Button
    Friend WithEvents dtg_Imagens As DataGridView
    Friend WithEvents lbl_Tamanho_Total As Label
    Friend WithEvents txt_Tamanho_Total As TextBox
    Friend WithEvents cms_Menu_Imagem As ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_Salvar_Como As ToolStripMenuItem
    Friend WithEvents txt_comentario_excluido As TextBox
    Friend WithEvents dtg_Historico As DataGridView
    Friend WithEvents txt_imagem_excluida As TextBox
    Friend WithEvents txt_id_status_inicial As TextBox
End Class
