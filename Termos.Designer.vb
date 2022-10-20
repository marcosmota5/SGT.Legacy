<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Termos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Termos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.lbl_Nome = New System.Windows.Forms.Label()
        Me.cbo_Status = New System.Windows.Forms.ComboBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.mns_Menu = New System.Windows.Forms.MenuStrip()
        Me.mnsi_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsi_Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsi_Excluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.grp_Itens = New System.Windows.Forms.GroupBox()
        Me.dtg_Itens = New System.Windows.Forms.DataGridView()
        Me.txt_id_termo = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Salvar = New System.Windows.Forms.Button()
        Me.tbc_Termo = New System.Windows.Forms.TabControl()
        Me.tbp_Observacoes = New System.Windows.Forms.TabPage()
        Me.txt_Texto_Padrao = New System.Windows.Forms.TextBox()
        Me.lbl_Texto_Padrao = New System.Windows.Forms.Label()
        Me.lbl_Observacoes = New System.Windows.Forms.Label()
        Me.txt_Observacoes = New System.Windows.Forms.TextBox()
        Me.lbl_Prazo_Entrega = New System.Windows.Forms.Label()
        Me.lbl_Condicao_Pagamento = New System.Windows.Forms.Label()
        Me.txt_Validade = New System.Windows.Forms.TextBox()
        Me.txt_Prazo_Entrega = New System.Windows.Forms.TextBox()
        Me.lbl_Validade = New System.Windows.Forms.Label()
        Me.txt_Condicao_Pagamento = New System.Windows.Forms.TextBox()
        Me.txt_Garantia = New System.Windows.Forms.TextBox()
        Me.lbl_Garantia = New System.Windows.Forms.Label()
        Me.tbp_Associacoes = New System.Windows.Forms.TabPage()
        Me.grp_Cliente = New System.Windows.Forms.GroupBox()
        Me.dtg_Cliente_Selecionados = New System.Windows.Forms.DataGridView()
        Me.dtg_Cliente_Todos = New System.Windows.Forms.DataGridView()
        Me.btn_Passar_Esquerda_Cliente_Todos = New System.Windows.Forms.Button()
        Me.btn_Passar_Direita_Cliente_Unico = New System.Windows.Forms.Button()
        Me.btn_Passar_Esquerda_Cliente_Unico = New System.Windows.Forms.Button()
        Me.btn_Passar_Direita_Cliente_Todos = New System.Windows.Forms.Button()
        Me.lbl_Cliente_Selecionados = New System.Windows.Forms.Label()
        Me.lbl_Cliente_Todos = New System.Windows.Forms.Label()
        Me.grp_Setor = New System.Windows.Forms.GroupBox()
        Me.dtg_Setor_Selecionados = New System.Windows.Forms.DataGridView()
        Me.dtg_Setor_Todos = New System.Windows.Forms.DataGridView()
        Me.btn_Passar_Esquerda_Setor_Todos = New System.Windows.Forms.Button()
        Me.btn_Passar_Direita_Setor_Unico = New System.Windows.Forms.Button()
        Me.btn_Passar_Esquerda_Setor_Unico = New System.Windows.Forms.Button()
        Me.btn_Passar_Direita_Setor_Todos = New System.Windows.Forms.Button()
        Me.lbl_Setor_Selecionados = New System.Windows.Forms.Label()
        Me.lbl_Setor_Todos = New System.Windows.Forms.Label()
        Me.mns_Menu.SuspendLayout()
        Me.grp_Itens.SuspendLayout()
        CType(Me.dtg_Itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc_Termo.SuspendLayout()
        Me.tbp_Observacoes.SuspendLayout()
        Me.tbp_Associacoes.SuspendLayout()
        Me.grp_Cliente.SuspendLayout()
        CType(Me.dtg_Cliente_Selecionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_Cliente_Todos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Setor.SuspendLayout()
        CType(Me.dtg_Setor_Selecionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_Setor_Todos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Nome
        '
        Me.txt_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nome.Location = New System.Drawing.Point(13, 45)
        Me.txt_Nome.MaxLength = 60
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(281, 20)
        Me.txt_Nome.TabIndex = 3
        '
        'lbl_Nome
        '
        Me.lbl_Nome.AutoSize = True
        Me.lbl_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nome.Location = New System.Drawing.Point(10, 29)
        Me.lbl_Nome.Name = "lbl_Nome"
        Me.lbl_Nome.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Nome.TabIndex = 1
        Me.lbl_Nome.Text = "Nome do termo"
        '
        'cbo_Status
        '
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Location = New System.Drawing.Point(300, 45)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(122, 21)
        Me.cbo_Status.TabIndex = 4
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(297, 29)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Status.TabIndex = 2
        Me.lbl_Status.Text = "Status"
        '
        'mns_Menu
        '
        Me.mns_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsi_Adicionar, Me.mnsi_Editar, Me.mnsi_Excluir})
        Me.mns_Menu.Location = New System.Drawing.Point(0, 0)
        Me.mns_Menu.Name = "mns_Menu"
        Me.mns_Menu.ShowItemToolTips = True
        Me.mns_Menu.Size = New System.Drawing.Size(1060, 24)
        Me.mns_Menu.TabIndex = 0
        Me.mns_Menu.Text = "MenuStrip1"
        '
        'mnsi_Adicionar
        '
        Me.mnsi_Adicionar.Image = Global.Eurolift_Services.My.Resources.Resources.add_square_button
        Me.mnsi_Adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnsi_Adicionar.Name = "mnsi_Adicionar"
        Me.mnsi_Adicionar.Size = New System.Drawing.Size(92, 20)
        Me.mnsi_Adicionar.Text = "  Adicionar"
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
        'grp_Itens
        '
        Me.grp_Itens.Controls.Add(Me.dtg_Itens)
        Me.grp_Itens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Itens.Location = New System.Drawing.Point(12, 365)
        Me.grp_Itens.Name = "grp_Itens"
        Me.grp_Itens.Size = New System.Drawing.Size(1033, 181)
        Me.grp_Itens.TabIndex = 15
        Me.grp_Itens.TabStop = False
        Me.grp_Itens.Text = "Itens"
        '
        'dtg_Itens
        '
        Me.dtg_Itens.AllowUserToAddRows = False
        Me.dtg_Itens.AllowUserToDeleteRows = False
        Me.dtg_Itens.AllowUserToResizeColumns = False
        Me.dtg_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
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
        Me.dtg_Itens.Location = New System.Drawing.Point(15, 22)
        Me.dtg_Itens.MultiSelect = False
        Me.dtg_Itens.Name = "dtg_Itens"
        Me.dtg_Itens.ReadOnly = True
        Me.dtg_Itens.RowHeadersVisible = False
        Me.dtg_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Itens.Size = New System.Drawing.Size(1008, 147)
        Me.dtg_Itens.TabIndex = 0
        '
        'txt_id_termo
        '
        Me.txt_id_termo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_termo.Location = New System.Drawing.Point(686, 32)
        Me.txt_id_termo.Name = "txt_id_termo"
        Me.txt_id_termo.Size = New System.Drawing.Size(49, 20)
        Me.txt_id_termo.TabIndex = 38
        Me.txt_id_termo.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.ImageKey = "remove-button.png"
        Me.btn_Cancelar.ImageList = Me.img_List_16x16
        Me.btn_Cancelar.Location = New System.Drawing.Point(427, 553)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cancelar.TabIndex = 16
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
        Me.btn_Salvar.Location = New System.Drawing.Point(535, 553)
        Me.btn_Salvar.Name = "btn_Salvar"
        Me.btn_Salvar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Salvar.TabIndex = 17
        Me.btn_Salvar.Text = "  Salvar"
        Me.btn_Salvar.UseVisualStyleBackColor = True
        '
        'tbc_Termo
        '
        Me.tbc_Termo.Controls.Add(Me.tbp_Observacoes)
        Me.tbc_Termo.Controls.Add(Me.tbp_Associacoes)
        Me.tbc_Termo.Location = New System.Drawing.Point(12, 71)
        Me.tbc_Termo.Name = "tbc_Termo"
        Me.tbc_Termo.SelectedIndex = 0
        Me.tbc_Termo.Size = New System.Drawing.Size(1037, 292)
        Me.tbc_Termo.TabIndex = 46
        '
        'tbp_Observacoes
        '
        Me.tbp_Observacoes.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Observacoes.Controls.Add(Me.txt_Texto_Padrao)
        Me.tbp_Observacoes.Controls.Add(Me.lbl_Texto_Padrao)
        Me.tbp_Observacoes.Controls.Add(Me.lbl_Observacoes)
        Me.tbp_Observacoes.Controls.Add(Me.txt_Observacoes)
        Me.tbp_Observacoes.Controls.Add(Me.lbl_Prazo_Entrega)
        Me.tbp_Observacoes.Controls.Add(Me.lbl_Condicao_Pagamento)
        Me.tbp_Observacoes.Controls.Add(Me.txt_Validade)
        Me.tbp_Observacoes.Controls.Add(Me.txt_Prazo_Entrega)
        Me.tbp_Observacoes.Controls.Add(Me.lbl_Validade)
        Me.tbp_Observacoes.Controls.Add(Me.txt_Condicao_Pagamento)
        Me.tbp_Observacoes.Controls.Add(Me.txt_Garantia)
        Me.tbp_Observacoes.Controls.Add(Me.lbl_Garantia)
        Me.tbp_Observacoes.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Observacoes.Name = "tbp_Observacoes"
        Me.tbp_Observacoes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Observacoes.Size = New System.Drawing.Size(1029, 266)
        Me.tbp_Observacoes.TabIndex = 0
        Me.tbp_Observacoes.Text = "Observações"
        '
        'txt_Texto_Padrao
        '
        Me.txt_Texto_Padrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Texto_Padrao.Location = New System.Drawing.Point(9, 23)
        Me.txt_Texto_Padrao.Multiline = True
        Me.txt_Texto_Padrao.Name = "txt_Texto_Padrao"
        Me.txt_Texto_Padrao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Texto_Padrao.Size = New System.Drawing.Size(502, 65)
        Me.txt_Texto_Padrao.TabIndex = 40
        '
        'lbl_Texto_Padrao
        '
        Me.lbl_Texto_Padrao.AutoSize = True
        Me.lbl_Texto_Padrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Texto_Padrao.Location = New System.Drawing.Point(6, 7)
        Me.lbl_Texto_Padrao.Name = "lbl_Texto_Padrao"
        Me.lbl_Texto_Padrao.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Texto_Padrao.TabIndex = 39
        Me.lbl_Texto_Padrao.Text = "Texto inicial"
        '
        'lbl_Observacoes
        '
        Me.lbl_Observacoes.AutoSize = True
        Me.lbl_Observacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Observacoes.Location = New System.Drawing.Point(6, 90)
        Me.lbl_Observacoes.Name = "lbl_Observacoes"
        Me.lbl_Observacoes.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Observacoes.TabIndex = 5
        Me.lbl_Observacoes.Text = "Observações"
        '
        'txt_Observacoes
        '
        Me.txt_Observacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Observacoes.Location = New System.Drawing.Point(9, 106)
        Me.txt_Observacoes.Multiline = True
        Me.txt_Observacoes.Name = "txt_Observacoes"
        Me.txt_Observacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Observacoes.Size = New System.Drawing.Size(502, 65)
        Me.txt_Observacoes.TabIndex = 6
        '
        'lbl_Prazo_Entrega
        '
        Me.lbl_Prazo_Entrega.AutoSize = True
        Me.lbl_Prazo_Entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prazo_Entrega.Location = New System.Drawing.Point(6, 174)
        Me.lbl_Prazo_Entrega.Name = "lbl_Prazo_Entrega"
        Me.lbl_Prazo_Entrega.Size = New System.Drawing.Size(104, 13)
        Me.lbl_Prazo_Entrega.TabIndex = 7
        Me.lbl_Prazo_Entrega.Text = "Prazo de entrega"
        '
        'lbl_Condicao_Pagamento
        '
        Me.lbl_Condicao_Pagamento.AutoSize = True
        Me.lbl_Condicao_Pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Condicao_Pagamento.Location = New System.Drawing.Point(514, 7)
        Me.lbl_Condicao_Pagamento.Name = "lbl_Condicao_Pagamento"
        Me.lbl_Condicao_Pagamento.Size = New System.Drawing.Size(144, 13)
        Me.lbl_Condicao_Pagamento.TabIndex = 9
        Me.lbl_Condicao_Pagamento.Text = "Condição de pagamento"
        '
        'txt_Validade
        '
        Me.txt_Validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Validade.Location = New System.Drawing.Point(517, 191)
        Me.txt_Validade.Multiline = True
        Me.txt_Validade.Name = "txt_Validade"
        Me.txt_Validade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Validade.Size = New System.Drawing.Size(502, 65)
        Me.txt_Validade.TabIndex = 14
        '
        'txt_Prazo_Entrega
        '
        Me.txt_Prazo_Entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prazo_Entrega.Location = New System.Drawing.Point(9, 190)
        Me.txt_Prazo_Entrega.Multiline = True
        Me.txt_Prazo_Entrega.Name = "txt_Prazo_Entrega"
        Me.txt_Prazo_Entrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Prazo_Entrega.Size = New System.Drawing.Size(502, 65)
        Me.txt_Prazo_Entrega.TabIndex = 8
        '
        'lbl_Validade
        '
        Me.lbl_Validade.AutoSize = True
        Me.lbl_Validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Validade.Location = New System.Drawing.Point(514, 175)
        Me.lbl_Validade.Name = "lbl_Validade"
        Me.lbl_Validade.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Validade.TabIndex = 13
        Me.lbl_Validade.Text = "Validade"
        '
        'txt_Condicao_Pagamento
        '
        Me.txt_Condicao_Pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Condicao_Pagamento.Location = New System.Drawing.Point(517, 23)
        Me.txt_Condicao_Pagamento.Multiline = True
        Me.txt_Condicao_Pagamento.Name = "txt_Condicao_Pagamento"
        Me.txt_Condicao_Pagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Condicao_Pagamento.Size = New System.Drawing.Size(502, 65)
        Me.txt_Condicao_Pagamento.TabIndex = 10
        '
        'txt_Garantia
        '
        Me.txt_Garantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Garantia.Location = New System.Drawing.Point(517, 107)
        Me.txt_Garantia.Multiline = True
        Me.txt_Garantia.Name = "txt_Garantia"
        Me.txt_Garantia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Garantia.Size = New System.Drawing.Size(502, 65)
        Me.txt_Garantia.TabIndex = 12
        '
        'lbl_Garantia
        '
        Me.lbl_Garantia.AutoSize = True
        Me.lbl_Garantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Garantia.Location = New System.Drawing.Point(514, 91)
        Me.lbl_Garantia.Name = "lbl_Garantia"
        Me.lbl_Garantia.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Garantia.TabIndex = 11
        Me.lbl_Garantia.Text = "Garantia"
        '
        'tbp_Associacoes
        '
        Me.tbp_Associacoes.BackColor = System.Drawing.SystemColors.Control
        Me.tbp_Associacoes.Controls.Add(Me.grp_Cliente)
        Me.tbp_Associacoes.Controls.Add(Me.grp_Setor)
        Me.tbp_Associacoes.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Associacoes.Name = "tbp_Associacoes"
        Me.tbp_Associacoes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Associacoes.Size = New System.Drawing.Size(1029, 266)
        Me.tbp_Associacoes.TabIndex = 1
        Me.tbp_Associacoes.Text = "Associações"
        '
        'grp_Cliente
        '
        Me.grp_Cliente.Controls.Add(Me.dtg_Cliente_Selecionados)
        Me.grp_Cliente.Controls.Add(Me.dtg_Cliente_Todos)
        Me.grp_Cliente.Controls.Add(Me.btn_Passar_Esquerda_Cliente_Todos)
        Me.grp_Cliente.Controls.Add(Me.btn_Passar_Direita_Cliente_Unico)
        Me.grp_Cliente.Controls.Add(Me.btn_Passar_Esquerda_Cliente_Unico)
        Me.grp_Cliente.Controls.Add(Me.btn_Passar_Direita_Cliente_Todos)
        Me.grp_Cliente.Controls.Add(Me.lbl_Cliente_Selecionados)
        Me.grp_Cliente.Controls.Add(Me.lbl_Cliente_Todos)
        Me.grp_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Cliente.Location = New System.Drawing.Point(518, 9)
        Me.grp_Cliente.Name = "grp_Cliente"
        Me.grp_Cliente.Size = New System.Drawing.Size(501, 240)
        Me.grp_Cliente.TabIndex = 17
        Me.grp_Cliente.TabStop = False
        Me.grp_Cliente.Text = "Clientes"
        '
        'dtg_Cliente_Selecionados
        '
        Me.dtg_Cliente_Selecionados.AllowUserToAddRows = False
        Me.dtg_Cliente_Selecionados.AllowUserToDeleteRows = False
        Me.dtg_Cliente_Selecionados.AllowUserToResizeColumns = False
        Me.dtg_Cliente_Selecionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Cliente_Selecionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Cliente_Selecionados.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Cliente_Selecionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_Cliente_Selecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Cliente_Selecionados.ColumnHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Cliente_Selecionados.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtg_Cliente_Selecionados.Location = New System.Drawing.Point(280, 38)
        Me.dtg_Cliente_Selecionados.Name = "dtg_Cliente_Selecionados"
        Me.dtg_Cliente_Selecionados.ReadOnly = True
        Me.dtg_Cliente_Selecionados.RowHeadersVisible = False
        Me.dtg_Cliente_Selecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Cliente_Selecionados.Size = New System.Drawing.Size(209, 186)
        Me.dtg_Cliente_Selecionados.TabIndex = 69
        '
        'dtg_Cliente_Todos
        '
        Me.dtg_Cliente_Todos.AllowUserToAddRows = False
        Me.dtg_Cliente_Todos.AllowUserToDeleteRows = False
        Me.dtg_Cliente_Todos.AllowUserToResizeColumns = False
        Me.dtg_Cliente_Todos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Cliente_Todos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Cliente_Todos.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Cliente_Todos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtg_Cliente_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Cliente_Todos.ColumnHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Cliente_Todos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtg_Cliente_Todos.Location = New System.Drawing.Point(12, 37)
        Me.dtg_Cliente_Todos.Name = "dtg_Cliente_Todos"
        Me.dtg_Cliente_Todos.ReadOnly = True
        Me.dtg_Cliente_Todos.RowHeadersVisible = False
        Me.dtg_Cliente_Todos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Cliente_Todos.Size = New System.Drawing.Size(209, 186)
        Me.dtg_Cliente_Todos.TabIndex = 68
        '
        'btn_Passar_Esquerda_Cliente_Todos
        '
        Me.btn_Passar_Esquerda_Cliente_Todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Esquerda_Cliente_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Esquerda_Cliente_Todos.ImageKey = "double-left-chevron.png"
        Me.btn_Passar_Esquerda_Cliente_Todos.ImageList = Me.img_List_16x16
        Me.btn_Passar_Esquerda_Cliente_Todos.Location = New System.Drawing.Point(227, 159)
        Me.btn_Passar_Esquerda_Cliente_Todos.Name = "btn_Passar_Esquerda_Cliente_Todos"
        Me.btn_Passar_Esquerda_Cliente_Todos.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Esquerda_Cliente_Todos.TabIndex = 67
        Me.btn_Passar_Esquerda_Cliente_Todos.UseVisualStyleBackColor = True
        '
        'btn_Passar_Direita_Cliente_Unico
        '
        Me.btn_Passar_Direita_Cliente_Unico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Direita_Cliente_Unico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Direita_Cliente_Unico.ImageKey = "angle-arrow-pointing-to-right.png"
        Me.btn_Passar_Direita_Cliente_Unico.ImageList = Me.img_List_16x16
        Me.btn_Passar_Direita_Cliente_Unico.Location = New System.Drawing.Point(227, 97)
        Me.btn_Passar_Direita_Cliente_Unico.Name = "btn_Passar_Direita_Cliente_Unico"
        Me.btn_Passar_Direita_Cliente_Unico.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Direita_Cliente_Unico.TabIndex = 66
        Me.btn_Passar_Direita_Cliente_Unico.UseVisualStyleBackColor = True
        '
        'btn_Passar_Esquerda_Cliente_Unico
        '
        Me.btn_Passar_Esquerda_Cliente_Unico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Esquerda_Cliente_Unico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Esquerda_Cliente_Unico.ImageKey = "angle-pointing-to-left.png"
        Me.btn_Passar_Esquerda_Cliente_Unico.ImageList = Me.img_List_16x16
        Me.btn_Passar_Esquerda_Cliente_Unico.Location = New System.Drawing.Point(227, 128)
        Me.btn_Passar_Esquerda_Cliente_Unico.Name = "btn_Passar_Esquerda_Cliente_Unico"
        Me.btn_Passar_Esquerda_Cliente_Unico.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Esquerda_Cliente_Unico.TabIndex = 65
        Me.btn_Passar_Esquerda_Cliente_Unico.UseVisualStyleBackColor = True
        '
        'btn_Passar_Direita_Cliente_Todos
        '
        Me.btn_Passar_Direita_Cliente_Todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Direita_Cliente_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Direita_Cliente_Todos.ImageKey = "double-angle-pointing-to-right.png"
        Me.btn_Passar_Direita_Cliente_Todos.ImageList = Me.img_List_16x16
        Me.btn_Passar_Direita_Cliente_Todos.Location = New System.Drawing.Point(227, 66)
        Me.btn_Passar_Direita_Cliente_Todos.Name = "btn_Passar_Direita_Cliente_Todos"
        Me.btn_Passar_Direita_Cliente_Todos.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Direita_Cliente_Todos.TabIndex = 64
        Me.btn_Passar_Direita_Cliente_Todos.UseVisualStyleBackColor = True
        '
        'lbl_Cliente_Selecionados
        '
        Me.lbl_Cliente_Selecionados.AutoSize = True
        Me.lbl_Cliente_Selecionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente_Selecionados.Location = New System.Drawing.Point(280, 20)
        Me.lbl_Cliente_Selecionados.Name = "lbl_Cliente_Selecionados"
        Me.lbl_Cliente_Selecionados.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Cliente_Selecionados.TabIndex = 63
        Me.lbl_Cliente_Selecionados.Text = "Clientes associados"
        '
        'lbl_Cliente_Todos
        '
        Me.lbl_Cliente_Todos.AutoSize = True
        Me.lbl_Cliente_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente_Todos.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Cliente_Todos.Name = "lbl_Cliente_Todos"
        Me.lbl_Cliente_Todos.Size = New System.Drawing.Size(107, 13)
        Me.lbl_Cliente_Todos.TabIndex = 61
        Me.lbl_Cliente_Todos.Text = "Todos os clientes"
        '
        'grp_Setor
        '
        Me.grp_Setor.Controls.Add(Me.dtg_Setor_Selecionados)
        Me.grp_Setor.Controls.Add(Me.dtg_Setor_Todos)
        Me.grp_Setor.Controls.Add(Me.btn_Passar_Esquerda_Setor_Todos)
        Me.grp_Setor.Controls.Add(Me.btn_Passar_Direita_Setor_Unico)
        Me.grp_Setor.Controls.Add(Me.btn_Passar_Esquerda_Setor_Unico)
        Me.grp_Setor.Controls.Add(Me.btn_Passar_Direita_Setor_Todos)
        Me.grp_Setor.Controls.Add(Me.lbl_Setor_Selecionados)
        Me.grp_Setor.Controls.Add(Me.lbl_Setor_Todos)
        Me.grp_Setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Setor.Location = New System.Drawing.Point(11, 9)
        Me.grp_Setor.Name = "grp_Setor"
        Me.grp_Setor.Size = New System.Drawing.Size(501, 240)
        Me.grp_Setor.TabIndex = 16
        Me.grp_Setor.TabStop = False
        Me.grp_Setor.Text = "Setores"
        '
        'dtg_Setor_Selecionados
        '
        Me.dtg_Setor_Selecionados.AllowUserToAddRows = False
        Me.dtg_Setor_Selecionados.AllowUserToDeleteRows = False
        Me.dtg_Setor_Selecionados.AllowUserToResizeColumns = False
        Me.dtg_Setor_Selecionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Setor_Selecionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Setor_Selecionados.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Setor_Selecionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtg_Setor_Selecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Setor_Selecionados.ColumnHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Setor_Selecionados.DefaultCellStyle = DataGridViewCellStyle8
        Me.dtg_Setor_Selecionados.Location = New System.Drawing.Point(280, 38)
        Me.dtg_Setor_Selecionados.Name = "dtg_Setor_Selecionados"
        Me.dtg_Setor_Selecionados.ReadOnly = True
        Me.dtg_Setor_Selecionados.RowHeadersVisible = False
        Me.dtg_Setor_Selecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Setor_Selecionados.Size = New System.Drawing.Size(209, 186)
        Me.dtg_Setor_Selecionados.TabIndex = 58
        '
        'dtg_Setor_Todos
        '
        Me.dtg_Setor_Todos.AllowUserToAddRows = False
        Me.dtg_Setor_Todos.AllowUserToDeleteRows = False
        Me.dtg_Setor_Todos.AllowUserToResizeColumns = False
        Me.dtg_Setor_Todos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Setor_Todos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Setor_Todos.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Setor_Todos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtg_Setor_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Setor_Todos.ColumnHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Setor_Todos.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtg_Setor_Todos.Location = New System.Drawing.Point(12, 37)
        Me.dtg_Setor_Todos.Name = "dtg_Setor_Todos"
        Me.dtg_Setor_Todos.ReadOnly = True
        Me.dtg_Setor_Todos.RowHeadersVisible = False
        Me.dtg_Setor_Todos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Setor_Todos.Size = New System.Drawing.Size(209, 186)
        Me.dtg_Setor_Todos.TabIndex = 47
        '
        'btn_Passar_Esquerda_Setor_Todos
        '
        Me.btn_Passar_Esquerda_Setor_Todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Esquerda_Setor_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Esquerda_Setor_Todos.ImageKey = "double-left-chevron.png"
        Me.btn_Passar_Esquerda_Setor_Todos.ImageList = Me.img_List_16x16
        Me.btn_Passar_Esquerda_Setor_Todos.Location = New System.Drawing.Point(227, 158)
        Me.btn_Passar_Esquerda_Setor_Todos.Name = "btn_Passar_Esquerda_Setor_Todos"
        Me.btn_Passar_Esquerda_Setor_Todos.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Esquerda_Setor_Todos.TabIndex = 57
        Me.btn_Passar_Esquerda_Setor_Todos.UseVisualStyleBackColor = True
        '
        'btn_Passar_Direita_Setor_Unico
        '
        Me.btn_Passar_Direita_Setor_Unico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Direita_Setor_Unico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Direita_Setor_Unico.ImageKey = "angle-arrow-pointing-to-right.png"
        Me.btn_Passar_Direita_Setor_Unico.ImageList = Me.img_List_16x16
        Me.btn_Passar_Direita_Setor_Unico.Location = New System.Drawing.Point(227, 96)
        Me.btn_Passar_Direita_Setor_Unico.Name = "btn_Passar_Direita_Setor_Unico"
        Me.btn_Passar_Direita_Setor_Unico.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Direita_Setor_Unico.TabIndex = 56
        Me.btn_Passar_Direita_Setor_Unico.UseVisualStyleBackColor = True
        '
        'btn_Passar_Esquerda_Setor_Unico
        '
        Me.btn_Passar_Esquerda_Setor_Unico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Esquerda_Setor_Unico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Esquerda_Setor_Unico.ImageKey = "angle-pointing-to-left.png"
        Me.btn_Passar_Esquerda_Setor_Unico.ImageList = Me.img_List_16x16
        Me.btn_Passar_Esquerda_Setor_Unico.Location = New System.Drawing.Point(227, 127)
        Me.btn_Passar_Esquerda_Setor_Unico.Name = "btn_Passar_Esquerda_Setor_Unico"
        Me.btn_Passar_Esquerda_Setor_Unico.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Esquerda_Setor_Unico.TabIndex = 55
        Me.btn_Passar_Esquerda_Setor_Unico.UseVisualStyleBackColor = True
        '
        'btn_Passar_Direita_Setor_Todos
        '
        Me.btn_Passar_Direita_Setor_Todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Passar_Direita_Setor_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Passar_Direita_Setor_Todos.ImageKey = "double-angle-pointing-to-right.png"
        Me.btn_Passar_Direita_Setor_Todos.ImageList = Me.img_List_16x16
        Me.btn_Passar_Direita_Setor_Todos.Location = New System.Drawing.Point(227, 65)
        Me.btn_Passar_Direita_Setor_Todos.Name = "btn_Passar_Direita_Setor_Todos"
        Me.btn_Passar_Direita_Setor_Todos.Size = New System.Drawing.Size(47, 25)
        Me.btn_Passar_Direita_Setor_Todos.TabIndex = 54
        Me.btn_Passar_Direita_Setor_Todos.UseVisualStyleBackColor = True
        '
        'lbl_Setor_Selecionados
        '
        Me.lbl_Setor_Selecionados.AutoSize = True
        Me.lbl_Setor_Selecionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Setor_Selecionados.Location = New System.Drawing.Point(280, 19)
        Me.lbl_Setor_Selecionados.Name = "lbl_Setor_Selecionados"
        Me.lbl_Setor_Selecionados.Size = New System.Drawing.Size(117, 13)
        Me.lbl_Setor_Selecionados.TabIndex = 53
        Me.lbl_Setor_Selecionados.Text = "Setores associados"
        '
        'lbl_Setor_Todos
        '
        Me.lbl_Setor_Todos.AutoSize = True
        Me.lbl_Setor_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Setor_Todos.Location = New System.Drawing.Point(12, 19)
        Me.lbl_Setor_Todos.Name = "lbl_Setor_Todos"
        Me.lbl_Setor_Todos.Size = New System.Drawing.Size(104, 13)
        Me.lbl_Setor_Todos.TabIndex = 51
        Me.lbl_Setor_Todos.Text = "Todos os setores"
        '
        'Termos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 586)
        Me.Controls.Add(Me.lbl_Nome)
        Me.Controls.Add(Me.tbc_Termo)
        Me.Controls.Add(Me.txt_Nome)
        Me.Controls.Add(Me.txt_id_termo)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Salvar)
        Me.Controls.Add(Me.mns_Menu)
        Me.Controls.Add(Me.grp_Itens)
        Me.Controls.Add(Me.cbo_Status)
        Me.Controls.Add(Me.lbl_Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Termos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Termos"
        Me.mns_Menu.ResumeLayout(False)
        Me.mns_Menu.PerformLayout()
        Me.grp_Itens.ResumeLayout(False)
        CType(Me.dtg_Itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc_Termo.ResumeLayout(False)
        Me.tbp_Observacoes.ResumeLayout(False)
        Me.tbp_Observacoes.PerformLayout()
        Me.tbp_Associacoes.ResumeLayout(False)
        Me.grp_Cliente.ResumeLayout(False)
        Me.grp_Cliente.PerformLayout()
        CType(Me.dtg_Cliente_Selecionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_Cliente_Todos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Setor.ResumeLayout(False)
        Me.grp_Setor.PerformLayout()
        CType(Me.dtg_Setor_Selecionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_Setor_Todos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents lbl_Nome As Label
    Friend WithEvents cbo_Status As ComboBox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents mns_Menu As MenuStrip
    Friend WithEvents mnsi_Adicionar As ToolStripMenuItem
    Friend WithEvents mnsi_Editar As ToolStripMenuItem
    Friend WithEvents mnsi_Excluir As ToolStripMenuItem
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Salvar As Button
    Friend WithEvents grp_Itens As GroupBox
    Friend WithEvents dtg_Itens As DataGridView
    Friend WithEvents txt_id_termo As TextBox
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents tbc_Termo As TabControl
    Friend WithEvents tbp_Observacoes As TabPage
    Friend WithEvents txt_Texto_Padrao As TextBox
    Friend WithEvents lbl_Texto_Padrao As Label
    Friend WithEvents lbl_Observacoes As Label
    Friend WithEvents txt_Observacoes As TextBox
    Friend WithEvents lbl_Prazo_Entrega As Label
    Friend WithEvents lbl_Condicao_Pagamento As Label
    Friend WithEvents txt_Validade As TextBox
    Friend WithEvents txt_Prazo_Entrega As TextBox
    Friend WithEvents lbl_Validade As Label
    Friend WithEvents txt_Condicao_Pagamento As TextBox
    Friend WithEvents txt_Garantia As TextBox
    Friend WithEvents lbl_Garantia As Label
    Friend WithEvents tbp_Associacoes As TabPage
    Friend WithEvents grp_Cliente As GroupBox
    Friend WithEvents grp_Setor As GroupBox
    Friend WithEvents btn_Passar_Esquerda_Setor_Todos As Button
    Friend WithEvents btn_Passar_Direita_Setor_Unico As Button
    Friend WithEvents btn_Passar_Esquerda_Setor_Unico As Button
    Friend WithEvents btn_Passar_Direita_Setor_Todos As Button
    Friend WithEvents lbl_Setor_Selecionados As Label
    Friend WithEvents lbl_Setor_Todos As Label
    Friend WithEvents btn_Passar_Esquerda_Cliente_Todos As Button
    Friend WithEvents btn_Passar_Direita_Cliente_Unico As Button
    Friend WithEvents btn_Passar_Esquerda_Cliente_Unico As Button
    Friend WithEvents btn_Passar_Direita_Cliente_Todos As Button
    Friend WithEvents lbl_Cliente_Selecionados As Label
    Friend WithEvents lbl_Cliente_Todos As Label
    Friend WithEvents dtg_Cliente_Selecionados As DataGridView
    Friend WithEvents dtg_Cliente_Todos As DataGridView
    Friend WithEvents dtg_Setor_Selecionados As DataGridView
    Friend WithEvents dtg_Setor_Todos As DataGridView
End Class
