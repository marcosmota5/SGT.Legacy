<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa_Manifestacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pesquisa_Manifestacao))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtg_Resultados = New System.Windows.Forms.DataGridView()
        Me.lbl_Quantidade_Resultados = New System.Windows.Forms.Label()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.lbl_Limite_Resultados = New System.Windows.Forms.Label()
        Me.grp_Resultados = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_Status = New System.Windows.Forms.Panel()
        Me.ptb_Status = New System.Windows.Forms.PictureBox()
        Me.clb_Status = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.pnl_Data_Abertura = New System.Windows.Forms.Panel()
        Me.dtp_Data_Abertura_De = New System.Windows.Forms.DateTimePicker()
        Me.ptb_Data_Abertura = New System.Windows.Forms.PictureBox()
        Me.dtp_Data_Abertura_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Abertura_De = New System.Windows.Forms.Label()
        Me.lbl_Data_Abertura = New System.Windows.Forms.Label()
        Me.lbl_Data_Abertura_Ate = New System.Windows.Forms.Label()
        Me.pnl_Data_Fechamento = New System.Windows.Forms.Panel()
        Me.dtp_Data_Fechamento_De = New System.Windows.Forms.DateTimePicker()
        Me.ptb_Data_Fechamento = New System.Windows.Forms.PictureBox()
        Me.dtp_Data_Fechamento_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Fechamento_De = New System.Windows.Forms.Label()
        Me.lbl_Data_Fechamento = New System.Windows.Forms.Label()
        Me.lbl_Data_Fechamento_Ate = New System.Windows.Forms.Label()
        Me.pnl_Tipo = New System.Windows.Forms.Panel()
        Me.ptb_Tipo = New System.Windows.Forms.PictureBox()
        Me.clb_Tipo = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.pnl_Prioridade = New System.Windows.Forms.Panel()
        Me.ptb_Prioridade = New System.Windows.Forms.PictureBox()
        Me.clb_Prioridade = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Prioridade = New System.Windows.Forms.Label()
        Me.grp_Filtros = New System.Windows.Forms.GroupBox()
        CType(Me.dtg_Resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Resultados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_Status.SuspendLayout()
        CType(Me.ptb_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Data_Abertura.SuspendLayout()
        CType(Me.ptb_Data_Abertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Data_Fechamento.SuspendLayout()
        CType(Me.ptb_Data_Fechamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Tipo.SuspendLayout()
        CType(Me.ptb_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Prioridade.SuspendLayout()
        CType(Me.ptb_Prioridade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Filtros.SuspendLayout()
        Me.SuspendLayout()
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
        '
        'dtg_Resultados
        '
        Me.dtg_Resultados.AllowUserToAddRows = False
        Me.dtg_Resultados.AllowUserToDeleteRows = False
        Me.dtg_Resultados.AllowUserToResizeColumns = False
        Me.dtg_Resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Resultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Resultados.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Resultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Resultados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_Resultados.Location = New System.Drawing.Point(18, 22)
        Me.dtg_Resultados.MultiSelect = False
        Me.dtg_Resultados.Name = "dtg_Resultados"
        Me.dtg_Resultados.ReadOnly = True
        Me.dtg_Resultados.RowHeadersVisible = False
        Me.dtg_Resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Resultados.Size = New System.Drawing.Size(868, 407)
        Me.dtg_Resultados.TabIndex = 59
        '
        'lbl_Quantidade_Resultados
        '
        Me.lbl_Quantidade_Resultados.AutoSize = True
        Me.lbl_Quantidade_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quantidade_Resultados.Location = New System.Drawing.Point(14, 435)
        Me.lbl_Quantidade_Resultados.Name = "lbl_Quantidade_Resultados"
        Me.lbl_Quantidade_Resultados.Size = New System.Drawing.Size(177, 13)
        Me.lbl_Quantidade_Resultados.TabIndex = 61
        Me.lbl_Quantidade_Resultados.Text = "Nenhum resultado encontrado"
        '
        'btn_Exportar
        '
        Me.btn_Exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.ImageKey = "xlsx-file-format-extension.png"
        Me.btn_Exportar.ImageList = Me.img_List_16x16
        Me.btn_Exportar.Location = New System.Drawing.Point(784, 435)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Exportar.TabIndex = 62
        Me.btn_Exportar.Text = "  Exportar"
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'lbl_Limite_Resultados
        '
        Me.lbl_Limite_Resultados.AutoSize = True
        Me.lbl_Limite_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Limite_Resultados.Location = New System.Drawing.Point(17, 452)
        Me.lbl_Limite_Resultados.Name = "lbl_Limite_Resultados"
        Me.lbl_Limite_Resultados.Size = New System.Drawing.Size(127, 13)
        Me.lbl_Limite_Resultados.TabIndex = 63
        Me.lbl_Limite_Resultados.Text = "*Limitado a x resultado (s)"
        '
        'grp_Resultados
        '
        Me.grp_Resultados.Controls.Add(Me.lbl_Limite_Resultados)
        Me.grp_Resultados.Controls.Add(Me.btn_Exportar)
        Me.grp_Resultados.Controls.Add(Me.lbl_Quantidade_Resultados)
        Me.grp_Resultados.Controls.Add(Me.dtg_Resultados)
        Me.grp_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Resultados.Location = New System.Drawing.Point(311, 12)
        Me.grp_Resultados.Name = "grp_Resultados"
        Me.grp_Resultados.Size = New System.Drawing.Size(896, 470)
        Me.grp_Resultados.TabIndex = 66
        Me.grp_Resultados.TabStop = False
        Me.grp_Resultados.Text = "Resultados"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.pnl_Status)
        Me.Panel1.Controls.Add(Me.pnl_Data_Abertura)
        Me.Panel1.Controls.Add(Me.pnl_Data_Fechamento)
        Me.Panel1.Controls.Add(Me.pnl_Tipo)
        Me.Panel1.Controls.Add(Me.pnl_Prioridade)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 445)
        Me.Panel1.TabIndex = 65
        '
        'pnl_Status
        '
        Me.pnl_Status.Controls.Add(Me.ptb_Status)
        Me.pnl_Status.Controls.Add(Me.clb_Status)
        Me.pnl_Status.Controls.Add(Me.lbl_Status)
        Me.pnl_Status.Location = New System.Drawing.Point(3, 257)
        Me.pnl_Status.Name = "pnl_Status"
        Me.pnl_Status.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Status.TabIndex = 70
        '
        'ptb_Status
        '
        Me.ptb_Status.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Status.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Status.Name = "ptb_Status"
        Me.ptb_Status.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Status.TabIndex = 43
        Me.ptb_Status.TabStop = False
        '
        'clb_Status
        '
        Me.clb_Status.CheckOnClick = True
        Me.clb_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Status.FormattingEnabled = True
        Me.clb_Status.Location = New System.Drawing.Point(7, 21)
        Me.clb_Status.Name = "clb_Status"
        Me.clb_Status.Size = New System.Drawing.Size(235, 94)
        Me.clb_Status.TabIndex = 13
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Status.TabIndex = 42
        Me.lbl_Status.Text = "Status"
        '
        'pnl_Data_Abertura
        '
        Me.pnl_Data_Abertura.Controls.Add(Me.dtp_Data_Abertura_De)
        Me.pnl_Data_Abertura.Controls.Add(Me.ptb_Data_Abertura)
        Me.pnl_Data_Abertura.Controls.Add(Me.dtp_Data_Abertura_Ate)
        Me.pnl_Data_Abertura.Controls.Add(Me.lbl_Data_Abertura_De)
        Me.pnl_Data_Abertura.Controls.Add(Me.lbl_Data_Abertura)
        Me.pnl_Data_Abertura.Controls.Add(Me.lbl_Data_Abertura_Ate)
        Me.pnl_Data_Abertura.Location = New System.Drawing.Point(3, 384)
        Me.pnl_Data_Abertura.Name = "pnl_Data_Abertura"
        Me.pnl_Data_Abertura.Size = New System.Drawing.Size(253, 79)
        Me.pnl_Data_Abertura.TabIndex = 46
        '
        'dtp_Data_Abertura_De
        '
        Me.dtp_Data_Abertura_De.Checked = False
        Me.dtp_Data_Abertura_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Abertura_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Abertura_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Abertura_De.Location = New System.Drawing.Point(10, 45)
        Me.dtp_Data_Abertura_De.Name = "dtp_Data_Abertura_De"
        Me.dtp_Data_Abertura_De.ShowCheckBox = True
        Me.dtp_Data_Abertura_De.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Abertura_De.TabIndex = 75
        Me.dtp_Data_Abertura_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'ptb_Data_Abertura
        '
        Me.ptb_Data_Abertura.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Data_Abertura.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Data_Abertura.Name = "ptb_Data_Abertura"
        Me.ptb_Data_Abertura.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Data_Abertura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Data_Abertura.TabIndex = 43
        Me.ptb_Data_Abertura.TabStop = False
        '
        'dtp_Data_Abertura_Ate
        '
        Me.dtp_Data_Abertura_Ate.Checked = False
        Me.dtp_Data_Abertura_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Abertura_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Abertura_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Abertura_Ate.Location = New System.Drawing.Point(129, 45)
        Me.dtp_Data_Abertura_Ate.Name = "dtp_Data_Abertura_Ate"
        Me.dtp_Data_Abertura_Ate.ShowCheckBox = True
        Me.dtp_Data_Abertura_Ate.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Abertura_Ate.TabIndex = 77
        '
        'lbl_Data_Abertura_De
        '
        Me.lbl_Data_Abertura_De.AutoSize = True
        Me.lbl_Data_Abertura_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Abertura_De.Location = New System.Drawing.Point(7, 29)
        Me.lbl_Data_Abertura_De.Name = "lbl_Data_Abertura_De"
        Me.lbl_Data_Abertura_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Data_Abertura_De.TabIndex = 76
        Me.lbl_Data_Abertura_De.Text = "De"
        '
        'lbl_Data_Abertura
        '
        Me.lbl_Data_Abertura.AutoSize = True
        Me.lbl_Data_Abertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Abertura.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Data_Abertura.Name = "lbl_Data_Abertura"
        Me.lbl_Data_Abertura.Size = New System.Drawing.Size(103, 13)
        Me.lbl_Data_Abertura.TabIndex = 42
        Me.lbl_Data_Abertura.Text = "Data de abertura"
        '
        'lbl_Data_Abertura_Ate
        '
        Me.lbl_Data_Abertura_Ate.AutoSize = True
        Me.lbl_Data_Abertura_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Abertura_Ate.Location = New System.Drawing.Point(126, 29)
        Me.lbl_Data_Abertura_Ate.Name = "lbl_Data_Abertura_Ate"
        Me.lbl_Data_Abertura_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Abertura_Ate.TabIndex = 78
        Me.lbl_Data_Abertura_Ate.Text = "Até"
        '
        'pnl_Data_Fechamento
        '
        Me.pnl_Data_Fechamento.Controls.Add(Me.dtp_Data_Fechamento_De)
        Me.pnl_Data_Fechamento.Controls.Add(Me.ptb_Data_Fechamento)
        Me.pnl_Data_Fechamento.Controls.Add(Me.dtp_Data_Fechamento_Ate)
        Me.pnl_Data_Fechamento.Controls.Add(Me.lbl_Data_Fechamento_De)
        Me.pnl_Data_Fechamento.Controls.Add(Me.lbl_Data_Fechamento)
        Me.pnl_Data_Fechamento.Controls.Add(Me.lbl_Data_Fechamento_Ate)
        Me.pnl_Data_Fechamento.Location = New System.Drawing.Point(3, 471)
        Me.pnl_Data_Fechamento.Name = "pnl_Data_Fechamento"
        Me.pnl_Data_Fechamento.Size = New System.Drawing.Size(253, 79)
        Me.pnl_Data_Fechamento.TabIndex = 65
        '
        'dtp_Data_Fechamento_De
        '
        Me.dtp_Data_Fechamento_De.Checked = False
        Me.dtp_Data_Fechamento_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Fechamento_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Fechamento_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Fechamento_De.Location = New System.Drawing.Point(10, 45)
        Me.dtp_Data_Fechamento_De.Name = "dtp_Data_Fechamento_De"
        Me.dtp_Data_Fechamento_De.ShowCheckBox = True
        Me.dtp_Data_Fechamento_De.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Fechamento_De.TabIndex = 75
        Me.dtp_Data_Fechamento_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'ptb_Data_Fechamento
        '
        Me.ptb_Data_Fechamento.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Data_Fechamento.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Data_Fechamento.Name = "ptb_Data_Fechamento"
        Me.ptb_Data_Fechamento.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Data_Fechamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Data_Fechamento.TabIndex = 43
        Me.ptb_Data_Fechamento.TabStop = False
        '
        'dtp_Data_Fechamento_Ate
        '
        Me.dtp_Data_Fechamento_Ate.Checked = False
        Me.dtp_Data_Fechamento_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Fechamento_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Fechamento_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Fechamento_Ate.Location = New System.Drawing.Point(129, 45)
        Me.dtp_Data_Fechamento_Ate.Name = "dtp_Data_Fechamento_Ate"
        Me.dtp_Data_Fechamento_Ate.ShowCheckBox = True
        Me.dtp_Data_Fechamento_Ate.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Fechamento_Ate.TabIndex = 77
        '
        'lbl_Data_Fechamento_De
        '
        Me.lbl_Data_Fechamento_De.AutoSize = True
        Me.lbl_Data_Fechamento_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Fechamento_De.Location = New System.Drawing.Point(7, 29)
        Me.lbl_Data_Fechamento_De.Name = "lbl_Data_Fechamento_De"
        Me.lbl_Data_Fechamento_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Data_Fechamento_De.TabIndex = 76
        Me.lbl_Data_Fechamento_De.Text = "De"
        '
        'lbl_Data_Fechamento
        '
        Me.lbl_Data_Fechamento.AutoSize = True
        Me.lbl_Data_Fechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Fechamento.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Data_Fechamento.Name = "lbl_Data_Fechamento"
        Me.lbl_Data_Fechamento.Size = New System.Drawing.Size(122, 13)
        Me.lbl_Data_Fechamento.TabIndex = 42
        Me.lbl_Data_Fechamento.Text = "Data de fechamento"
        '
        'lbl_Data_Fechamento_Ate
        '
        Me.lbl_Data_Fechamento_Ate.AutoSize = True
        Me.lbl_Data_Fechamento_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Fechamento_Ate.Location = New System.Drawing.Point(126, 29)
        Me.lbl_Data_Fechamento_Ate.Name = "lbl_Data_Fechamento_Ate"
        Me.lbl_Data_Fechamento_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Fechamento_Ate.TabIndex = 78
        Me.lbl_Data_Fechamento_Ate.Text = "Até"
        '
        'pnl_Tipo
        '
        Me.pnl_Tipo.Controls.Add(Me.ptb_Tipo)
        Me.pnl_Tipo.Controls.Add(Me.clb_Tipo)
        Me.pnl_Tipo.Controls.Add(Me.lbl_Tipo)
        Me.pnl_Tipo.Location = New System.Drawing.Point(3, 130)
        Me.pnl_Tipo.Name = "pnl_Tipo"
        Me.pnl_Tipo.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Tipo.TabIndex = 44
        '
        'ptb_Tipo
        '
        Me.ptb_Tipo.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Tipo.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Tipo.Name = "ptb_Tipo"
        Me.ptb_Tipo.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Tipo.TabIndex = 43
        Me.ptb_Tipo.TabStop = False
        '
        'clb_Tipo
        '
        Me.clb_Tipo.CheckOnClick = True
        Me.clb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Tipo.FormattingEnabled = True
        Me.clb_Tipo.Location = New System.Drawing.Point(7, 21)
        Me.clb_Tipo.Name = "clb_Tipo"
        Me.clb_Tipo.Size = New System.Drawing.Size(235, 94)
        Me.clb_Tipo.TabIndex = 13
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Tipo.TabIndex = 42
        Me.lbl_Tipo.Text = "Tipo"
        '
        'pnl_Prioridade
        '
        Me.pnl_Prioridade.Controls.Add(Me.ptb_Prioridade)
        Me.pnl_Prioridade.Controls.Add(Me.clb_Prioridade)
        Me.pnl_Prioridade.Controls.Add(Me.lbl_Prioridade)
        Me.pnl_Prioridade.Location = New System.Drawing.Point(3, 3)
        Me.pnl_Prioridade.Name = "pnl_Prioridade"
        Me.pnl_Prioridade.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Prioridade.TabIndex = 68
        '
        'ptb_Prioridade
        '
        Me.ptb_Prioridade.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Prioridade.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Prioridade.Name = "ptb_Prioridade"
        Me.ptb_Prioridade.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Prioridade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Prioridade.TabIndex = 43
        Me.ptb_Prioridade.TabStop = False
        '
        'clb_Prioridade
        '
        Me.clb_Prioridade.CheckOnClick = True
        Me.clb_Prioridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Prioridade.FormattingEnabled = True
        Me.clb_Prioridade.Location = New System.Drawing.Point(7, 21)
        Me.clb_Prioridade.Name = "clb_Prioridade"
        Me.clb_Prioridade.Size = New System.Drawing.Size(235, 94)
        Me.clb_Prioridade.TabIndex = 13
        '
        'lbl_Prioridade
        '
        Me.lbl_Prioridade.AutoSize = True
        Me.lbl_Prioridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prioridade.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Prioridade.Name = "lbl_Prioridade"
        Me.lbl_Prioridade.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Prioridade.TabIndex = 42
        Me.lbl_Prioridade.Text = "Prioridade"
        '
        'grp_Filtros
        '
        Me.grp_Filtros.Controls.Add(Me.Panel1)
        Me.grp_Filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Filtros.Location = New System.Drawing.Point(12, 12)
        Me.grp_Filtros.Name = "grp_Filtros"
        Me.grp_Filtros.Size = New System.Drawing.Size(293, 470)
        Me.grp_Filtros.TabIndex = 67
        Me.grp_Filtros.TabStop = False
        Me.grp_Filtros.Text = "Filtros"
        '
        'Pesquisa_Manifestacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 493)
        Me.Controls.Add(Me.grp_Filtros)
        Me.Controls.Add(Me.grp_Resultados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pesquisa_Manifestacao"
        Me.Text = "Pesquisar manifestação"
        CType(Me.dtg_Resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Resultados.ResumeLayout(False)
        Me.grp_Resultados.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnl_Status.ResumeLayout(False)
        Me.pnl_Status.PerformLayout()
        CType(Me.ptb_Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Data_Abertura.ResumeLayout(False)
        Me.pnl_Data_Abertura.PerformLayout()
        CType(Me.ptb_Data_Abertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Data_Fechamento.ResumeLayout(False)
        Me.pnl_Data_Fechamento.PerformLayout()
        CType(Me.ptb_Data_Fechamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Tipo.ResumeLayout(False)
        Me.pnl_Tipo.PerformLayout()
        CType(Me.ptb_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Prioridade.ResumeLayout(False)
        Me.pnl_Prioridade.PerformLayout()
        CType(Me.ptb_Prioridade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Filtros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents dtg_Resultados As DataGridView
    Friend WithEvents lbl_Quantidade_Resultados As Label
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents lbl_Limite_Resultados As Label
    Friend WithEvents grp_Resultados As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_Data_Abertura As Panel
    Friend WithEvents dtp_Data_Abertura_De As DateTimePicker
    Friend WithEvents ptb_Data_Abertura As PictureBox
    Friend WithEvents dtp_Data_Abertura_Ate As DateTimePicker
    Friend WithEvents lbl_Data_Abertura_De As Label
    Friend WithEvents lbl_Data_Abertura As Label
    Friend WithEvents lbl_Data_Abertura_Ate As Label
    Friend WithEvents pnl_Data_Fechamento As Panel
    Friend WithEvents dtp_Data_Fechamento_De As DateTimePicker
    Friend WithEvents ptb_Data_Fechamento As PictureBox
    Friend WithEvents dtp_Data_Fechamento_Ate As DateTimePicker
    Friend WithEvents lbl_Data_Fechamento_De As Label
    Friend WithEvents lbl_Data_Fechamento As Label
    Friend WithEvents lbl_Data_Fechamento_Ate As Label
    Friend WithEvents pnl_Tipo As Panel
    Friend WithEvents ptb_Tipo As PictureBox
    Friend WithEvents clb_Tipo As CheckedListBox
    Friend WithEvents lbl_Tipo As Label
    Friend WithEvents pnl_Prioridade As Panel
    Friend WithEvents ptb_Prioridade As PictureBox
    Friend WithEvents clb_Prioridade As CheckedListBox
    Friend WithEvents lbl_Prioridade As Label
    Friend WithEvents grp_Filtros As GroupBox
    Friend WithEvents pnl_Status As Panel
    Friend WithEvents ptb_Status As PictureBox
    Friend WithEvents clb_Status As CheckedListBox
    Friend WithEvents lbl_Status As Label
End Class
