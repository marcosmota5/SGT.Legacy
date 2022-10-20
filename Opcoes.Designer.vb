<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opcoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opcoes))
        Me.txt_File_Path = New System.Windows.Forms.TextBox()
        Me.lbl_Local_Estoque = New System.Windows.Forms.Label()
        Me.txt_Local_Estoque = New System.Windows.Forms.TextBox()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.grp_Estoque = New System.Windows.Forms.GroupBox()
        Me.txt_Senha_Estoque = New System.Windows.Forms.TextBox()
        Me.lbl_Senha_Estoque = New System.Windows.Forms.Label()
        Me.txt_Nome_Estoque = New System.Windows.Forms.TextBox()
        Me.lbl_Aba_Estoque = New System.Windows.Forms.Label()
        Me.lbl_Nome_Estoque = New System.Windows.Forms.Label()
        Me.txt_Aba_Estoque = New System.Windows.Forms.TextBox()
        Me.txt_Texto_Padrao = New System.Windows.Forms.TextBox()
        Me.lbl_Texto_Padrao = New System.Windows.Forms.Label()
        Me.txt_Emails_Copia = New System.Windows.Forms.TextBox()
        Me.lbl_Emails_Copia = New System.Windows.Forms.Label()
        Me.grp_Outros = New System.Windows.Forms.GroupBox()
        Me.nud_Limite_Resultados = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Limite_Resultados = New System.Windows.Forms.Label()
        Me.nud_Segundos = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Segundos = New System.Windows.Forms.Label()
        Me.chb_Atualizacao_Automatica = New System.Windows.Forms.CheckBox()
        Me.ttp_Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Salvar = New System.Windows.Forms.Button()
        Me.btn_Esconder_Senha = New System.Windows.Forms.Button()
        Me.btn_Mostrar_Senha = New System.Windows.Forms.Button()
        Me.btn_Selecionar_Estoque = New System.Windows.Forms.Button()
        Me.grp_Estoque.SuspendLayout()
        Me.grp_Outros.SuspendLayout()
        CType(Me.nud_Limite_Resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Segundos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_File_Path
        '
        Me.txt_File_Path.Location = New System.Drawing.Point(460, 285)
        Me.txt_File_Path.Name = "txt_File_Path"
        Me.txt_File_Path.Size = New System.Drawing.Size(100, 20)
        Me.txt_File_Path.TabIndex = 46
        Me.txt_File_Path.Visible = False
        '
        'lbl_Local_Estoque
        '
        Me.lbl_Local_Estoque.AutoSize = True
        Me.lbl_Local_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Local_Estoque.Location = New System.Drawing.Point(12, 19)
        Me.lbl_Local_Estoque.Name = "lbl_Local_Estoque"
        Me.lbl_Local_Estoque.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Local_Estoque.TabIndex = 50
        Me.lbl_Local_Estoque.Text = "Local"
        '
        'txt_Local_Estoque
        '
        Me.txt_Local_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Local_Estoque.Location = New System.Drawing.Point(15, 35)
        Me.txt_Local_Estoque.Name = "txt_Local_Estoque"
        Me.txt_Local_Estoque.Size = New System.Drawing.Size(176, 20)
        Me.txt_Local_Estoque.TabIndex = 51
        Me.ttp_Info.SetToolTip(Me.txt_Local_Estoque, "Local em que estão armazenadas os arquivos do estoque")
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
        'grp_Estoque
        '
        Me.grp_Estoque.Controls.Add(Me.btn_Esconder_Senha)
        Me.grp_Estoque.Controls.Add(Me.txt_Local_Estoque)
        Me.grp_Estoque.Controls.Add(Me.btn_Mostrar_Senha)
        Me.grp_Estoque.Controls.Add(Me.lbl_Local_Estoque)
        Me.grp_Estoque.Controls.Add(Me.txt_Senha_Estoque)
        Me.grp_Estoque.Controls.Add(Me.lbl_Senha_Estoque)
        Me.grp_Estoque.Controls.Add(Me.btn_Selecionar_Estoque)
        Me.grp_Estoque.Controls.Add(Me.txt_Nome_Estoque)
        Me.grp_Estoque.Controls.Add(Me.lbl_Aba_Estoque)
        Me.grp_Estoque.Controls.Add(Me.lbl_Nome_Estoque)
        Me.grp_Estoque.Controls.Add(Me.txt_Aba_Estoque)
        Me.grp_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Estoque.Location = New System.Drawing.Point(12, 12)
        Me.grp_Estoque.Name = "grp_Estoque"
        Me.grp_Estoque.Size = New System.Drawing.Size(387, 111)
        Me.grp_Estoque.TabIndex = 53
        Me.grp_Estoque.TabStop = False
        Me.grp_Estoque.Text = "Estoque"
        '
        'txt_Senha_Estoque
        '
        Me.txt_Senha_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Senha_Estoque.Location = New System.Drawing.Point(234, 79)
        Me.txt_Senha_Estoque.MaxLength = 255
        Me.txt_Senha_Estoque.Name = "txt_Senha_Estoque"
        Me.txt_Senha_Estoque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Senha_Estoque.Size = New System.Drawing.Size(106, 20)
        Me.txt_Senha_Estoque.TabIndex = 90
        Me.ttp_Info.SetToolTip(Me.txt_Senha_Estoque, "Senha para abrir o arquivo de estoque. Caso não possua senha deixe o campo vazio")
        '
        'lbl_Senha_Estoque
        '
        Me.lbl_Senha_Estoque.AutoSize = True
        Me.lbl_Senha_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Senha_Estoque.Location = New System.Drawing.Point(231, 63)
        Me.lbl_Senha_Estoque.Name = "lbl_Senha_Estoque"
        Me.lbl_Senha_Estoque.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Senha_Estoque.TabIndex = 58
        Me.lbl_Senha_Estoque.Text = "Senha"
        '
        'txt_Nome_Estoque
        '
        Me.txt_Nome_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nome_Estoque.Location = New System.Drawing.Point(234, 36)
        Me.txt_Nome_Estoque.Name = "txt_Nome_Estoque"
        Me.txt_Nome_Estoque.Size = New System.Drawing.Size(140, 20)
        Me.txt_Nome_Estoque.TabIndex = 55
        Me.ttp_Info.SetToolTip(Me.txt_Nome_Estoque, "Nome do arquivo de estoque. Não coloque referências de datas, apenas o nome padrã" &
        "o do arquivo pois será feita uma busca aproximada")
        '
        'lbl_Aba_Estoque
        '
        Me.lbl_Aba_Estoque.AutoSize = True
        Me.lbl_Aba_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Aba_Estoque.Location = New System.Drawing.Point(12, 63)
        Me.lbl_Aba_Estoque.Name = "lbl_Aba_Estoque"
        Me.lbl_Aba_Estoque.Size = New System.Drawing.Size(82, 13)
        Me.lbl_Aba_Estoque.TabIndex = 56
        Me.lbl_Aba_Estoque.Text = "Nome da aba"
        '
        'lbl_Nome_Estoque
        '
        Me.lbl_Nome_Estoque.AutoSize = True
        Me.lbl_Nome_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nome_Estoque.Location = New System.Drawing.Point(231, 20)
        Me.lbl_Nome_Estoque.Name = "lbl_Nome_Estoque"
        Me.lbl_Nome_Estoque.Size = New System.Drawing.Size(103, 13)
        Me.lbl_Nome_Estoque.TabIndex = 54
        Me.lbl_Nome_Estoque.Text = "Nome do arquivo"
        '
        'txt_Aba_Estoque
        '
        Me.txt_Aba_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Aba_Estoque.Location = New System.Drawing.Point(15, 79)
        Me.txt_Aba_Estoque.MaxLength = 31
        Me.txt_Aba_Estoque.Name = "txt_Aba_Estoque"
        Me.txt_Aba_Estoque.Size = New System.Drawing.Size(213, 20)
        Me.txt_Aba_Estoque.TabIndex = 57
        Me.ttp_Info.SetToolTip(Me.txt_Aba_Estoque, "Nome da aba do estoque no arquivo do Excel. Precisa ser o nome exato")
        '
        'txt_Texto_Padrao
        '
        Me.txt_Texto_Padrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Texto_Padrao.Location = New System.Drawing.Point(15, 33)
        Me.txt_Texto_Padrao.Name = "txt_Texto_Padrao"
        Me.txt_Texto_Padrao.Size = New System.Drawing.Size(359, 20)
        Me.txt_Texto_Padrao.TabIndex = 86
        Me.ttp_Info.SetToolTip(Me.txt_Texto_Padrao, "Texto padrão do email da proposta")
        '
        'lbl_Texto_Padrao
        '
        Me.lbl_Texto_Padrao.AutoSize = True
        Me.lbl_Texto_Padrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Texto_Padrao.Location = New System.Drawing.Point(12, 17)
        Me.lbl_Texto_Padrao.Name = "lbl_Texto_Padrao"
        Me.lbl_Texto_Padrao.Size = New System.Drawing.Size(137, 13)
        Me.lbl_Texto_Padrao.TabIndex = 85
        Me.lbl_Texto_Padrao.Text = "Texto padrão de e-mail"
        '
        'txt_Emails_Copia
        '
        Me.txt_Emails_Copia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Emails_Copia.Location = New System.Drawing.Point(15, 78)
        Me.txt_Emails_Copia.Name = "txt_Emails_Copia"
        Me.txt_Emails_Copia.Size = New System.Drawing.Size(247, 20)
        Me.txt_Emails_Copia.TabIndex = 88
        '
        'lbl_Emails_Copia
        '
        Me.lbl_Emails_Copia.AutoSize = True
        Me.lbl_Emails_Copia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emails_Copia.Location = New System.Drawing.Point(12, 62)
        Me.lbl_Emails_Copia.Name = "lbl_Emails_Copia"
        Me.lbl_Emails_Copia.Size = New System.Drawing.Size(102, 13)
        Me.lbl_Emails_Copia.TabIndex = 87
        Me.lbl_Emails_Copia.Text = "E-mails em cópia"
        Me.ttp_Info.SetToolTip(Me.lbl_Emails_Copia, "Endereços de e-mail para ir no campo de cópia do e-mail de proposta. Separar por " &
        "ponto e vírgula")
        '
        'grp_Outros
        '
        Me.grp_Outros.Controls.Add(Me.nud_Limite_Resultados)
        Me.grp_Outros.Controls.Add(Me.lbl_Limite_Resultados)
        Me.grp_Outros.Controls.Add(Me.nud_Segundos)
        Me.grp_Outros.Controls.Add(Me.lbl_Segundos)
        Me.grp_Outros.Controls.Add(Me.chb_Atualizacao_Automatica)
        Me.grp_Outros.Controls.Add(Me.lbl_Texto_Padrao)
        Me.grp_Outros.Controls.Add(Me.txt_Emails_Copia)
        Me.grp_Outros.Controls.Add(Me.txt_Texto_Padrao)
        Me.grp_Outros.Controls.Add(Me.lbl_Emails_Copia)
        Me.grp_Outros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Outros.Location = New System.Drawing.Point(12, 129)
        Me.grp_Outros.Name = "grp_Outros"
        Me.grp_Outros.Size = New System.Drawing.Size(387, 140)
        Me.grp_Outros.TabIndex = 89
        Me.grp_Outros.TabStop = False
        Me.grp_Outros.Text = "Outros"
        '
        'nud_Limite_Resultados
        '
        Me.nud_Limite_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Limite_Resultados.InterceptArrowKeys = False
        Me.nud_Limite_Resultados.Location = New System.Drawing.Point(268, 78)
        Me.nud_Limite_Resultados.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Limite_Resultados.Name = "nud_Limite_Resultados"
        Me.nud_Limite_Resultados.Size = New System.Drawing.Size(106, 20)
        Me.nud_Limite_Resultados.TabIndex = 95
        Me.ttp_Info.SetToolTip(Me.nud_Limite_Resultados, "Limite de resultados das pesquisas")
        '
        'lbl_Limite_Resultados
        '
        Me.lbl_Limite_Resultados.AutoSize = True
        Me.lbl_Limite_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Limite_Resultados.Location = New System.Drawing.Point(265, 62)
        Me.lbl_Limite_Resultados.Name = "lbl_Limite_Resultados"
        Me.lbl_Limite_Resultados.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Limite_Resultados.TabIndex = 94
        Me.lbl_Limite_Resultados.Text = "Lim. resultados"
        '
        'nud_Segundos
        '
        Me.nud_Segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Segundos.InterceptArrowKeys = False
        Me.nud_Segundos.Location = New System.Drawing.Point(199, 106)
        Me.nud_Segundos.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Segundos.Name = "nud_Segundos"
        Me.nud_Segundos.Size = New System.Drawing.Size(63, 20)
        Me.nud_Segundos.TabIndex = 92
        Me.ttp_Info.SetToolTip(Me.nud_Segundos, "Prazo adicional a ser considerado em relação ao prazo inicial das peças")
        '
        'lbl_Segundos
        '
        Me.lbl_Segundos.AutoSize = True
        Me.lbl_Segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Segundos.Location = New System.Drawing.Point(265, 109)
        Me.lbl_Segundos.Name = "lbl_Segundos"
        Me.lbl_Segundos.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Segundos.TabIndex = 93
        Me.lbl_Segundos.Text = "segundos"
        '
        'chb_Atualizacao_Automatica
        '
        Me.chb_Atualizacao_Automatica.AutoSize = True
        Me.chb_Atualizacao_Automatica.Location = New System.Drawing.Point(15, 108)
        Me.chb_Atualizacao_Automatica.Name = "chb_Atualizacao_Automatica"
        Me.chb_Atualizacao_Automatica.Size = New System.Drawing.Size(181, 17)
        Me.chb_Atualizacao_Automatica.TabIndex = 89
        Me.chb_Atualizacao_Automatica.Text = "Atualizar dashboard a cada"
        Me.ttp_Info.SetToolTip(Me.chb_Atualizacao_Automatica, "Marque aqui caso queira que o dashboard da págiona inicial atualize a cada x segu" &
        "ndos")
        Me.chb_Atualizacao_Automatica.UseVisualStyleBackColor = True
        '
        'ttp_Info
        '
        Me.ttp_Info.Active = False
        Me.ttp_Info.AutoPopDelay = 5000
        Me.ttp_Info.InitialDelay = 500
        Me.ttp_Info.IsBalloon = True
        Me.ttp_Info.ReshowDelay = 0
        Me.ttp_Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttp_Info.ToolTipTitle = "Importar"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.ImageKey = "remove-button.png"
        Me.btn_Cancelar.ImageList = Me.img_List_16x16
        Me.btn_Cancelar.Location = New System.Drawing.Point(101, 282)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cancelar.TabIndex = 90
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
        Me.btn_Salvar.Location = New System.Drawing.Point(209, 282)
        Me.btn_Salvar.Name = "btn_Salvar"
        Me.btn_Salvar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Salvar.TabIndex = 91
        Me.btn_Salvar.Text = "  Salvar"
        Me.btn_Salvar.UseVisualStyleBackColor = True
        '
        'btn_Esconder_Senha
        '
        Me.btn_Esconder_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Esconder_Senha.ImageKey = "eye-with-a-diagonal-line-interface-symbol-for-invisibility.png"
        Me.btn_Esconder_Senha.ImageList = Me.img_List_16x16
        Me.btn_Esconder_Senha.Location = New System.Drawing.Point(346, 77)
        Me.btn_Esconder_Senha.Name = "btn_Esconder_Senha"
        Me.btn_Esconder_Senha.Size = New System.Drawing.Size(28, 23)
        Me.btn_Esconder_Senha.TabIndex = 92
        Me.btn_Esconder_Senha.TabStop = False
        Me.btn_Esconder_Senha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Esconder_Senha.UseVisualStyleBackColor = True
        Me.btn_Esconder_Senha.Visible = False
        '
        'btn_Mostrar_Senha
        '
        Me.btn_Mostrar_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Mostrar_Senha.ImageKey = "eye-open.png"
        Me.btn_Mostrar_Senha.ImageList = Me.img_List_16x16
        Me.btn_Mostrar_Senha.Location = New System.Drawing.Point(346, 77)
        Me.btn_Mostrar_Senha.Name = "btn_Mostrar_Senha"
        Me.btn_Mostrar_Senha.Size = New System.Drawing.Size(28, 23)
        Me.btn_Mostrar_Senha.TabIndex = 91
        Me.btn_Mostrar_Senha.TabStop = False
        Me.btn_Mostrar_Senha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar_Senha.UseVisualStyleBackColor = True
        '
        'btn_Selecionar_Estoque
        '
        Me.btn_Selecionar_Estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Selecionar_Estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Selecionar_Estoque.ImageKey = "open-folder.png"
        Me.btn_Selecionar_Estoque.ImageList = Me.img_List_16x16
        Me.btn_Selecionar_Estoque.Location = New System.Drawing.Point(198, 34)
        Me.btn_Selecionar_Estoque.Name = "btn_Selecionar_Estoque"
        Me.btn_Selecionar_Estoque.Size = New System.Drawing.Size(30, 23)
        Me.btn_Selecionar_Estoque.TabIndex = 52
        Me.btn_Selecionar_Estoque.UseVisualStyleBackColor = True
        '
        'Opcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 320)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Salvar)
        Me.Controls.Add(Me.grp_Outros)
        Me.Controls.Add(Me.grp_Estoque)
        Me.Controls.Add(Me.txt_File_Path)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Opcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opções"
        Me.grp_Estoque.ResumeLayout(False)
        Me.grp_Estoque.PerformLayout()
        Me.grp_Outros.ResumeLayout(False)
        Me.grp_Outros.PerformLayout()
        CType(Me.nud_Limite_Resultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Segundos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_File_Path As TextBox
    Friend WithEvents lbl_Local_Estoque As Label
    Friend WithEvents txt_Local_Estoque As TextBox
    Friend WithEvents btn_Selecionar_Estoque As Button
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents grp_Estoque As GroupBox
    Friend WithEvents lbl_Nome_Estoque As Label
    Friend WithEvents txt_Nome_Estoque As TextBox
    Friend WithEvents lbl_Aba_Estoque As Label
    Friend WithEvents txt_Aba_Estoque As TextBox
    Friend WithEvents lbl_Senha_Estoque As Label
    Friend WithEvents txt_Texto_Padrao As TextBox
    Friend WithEvents lbl_Texto_Padrao As Label
    Friend WithEvents txt_Emails_Copia As TextBox
    Friend WithEvents lbl_Emails_Copia As Label
    Friend WithEvents grp_Outros As GroupBox
    Friend WithEvents btn_Esconder_Senha As Button
    Friend WithEvents btn_Mostrar_Senha As Button
    Friend WithEvents txt_Senha_Estoque As TextBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Salvar As Button
    Friend WithEvents ttp_Info As ToolTip
    Friend WithEvents chb_Atualizacao_Automatica As CheckBox
    Friend WithEvents lbl_Segundos As Label
    Friend WithEvents nud_Segundos As NumericUpDown
    Friend WithEvents lbl_Limite_Resultados As Label
    Friend WithEvents nud_Limite_Resultados As NumericUpDown
End Class
