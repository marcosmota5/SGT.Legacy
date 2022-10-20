<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa_Proposta_Padrao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pesquisa_Proposta_Padrao))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grp_Resultados = New System.Windows.Forms.GroupBox()
        Me.lbl_Limite_Resultados = New System.Windows.Forms.Label()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_Quantidade_Resultados = New System.Windows.Forms.Label()
        Me.dtg_Resultados = New System.Windows.Forms.DataGridView()
        Me.btn_Pesquisar = New System.Windows.Forms.Button()
        Me.grp_Opcoes = New System.Windows.Forms.GroupBox()
        Me.chb_Considerar_Revisadas = New System.Windows.Forms.CheckBox()
        Me.txt_Texto_Pesquisa = New System.Windows.Forms.TextBox()
        Me.lbl_Texto_Pesquisa = New System.Windows.Forms.Label()
        Me.lbl_Data_Ate = New System.Windows.Forms.Label()
        Me.grp_Filtros = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_Setor = New System.Windows.Forms.Panel()
        Me.ptb_Setor = New System.Windows.Forms.PictureBox()
        Me.clb_Setor = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Setor = New System.Windows.Forms.Label()
        Me.pnl_Usuario = New System.Windows.Forms.Panel()
        Me.ptb_Usuario = New System.Windows.Forms.PictureBox()
        Me.clb_Usuario = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.pnl_Prioridade = New System.Windows.Forms.Panel()
        Me.ptb_Prioridade = New System.Windows.Forms.PictureBox()
        Me.clb_Prioridade = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Prioridade = New System.Windows.Forms.Label()
        Me.pnl_Data_Faturamento = New System.Windows.Forms.Panel()
        Me.dtp_Data_Faturamento_De = New System.Windows.Forms.DateTimePicker()
        Me.ptb_Data_Faturamento = New System.Windows.Forms.PictureBox()
        Me.dtp_Data_Faturamento_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Faturamento_De = New System.Windows.Forms.Label()
        Me.lbl_Data_Faturamento = New System.Windows.Forms.Label()
        Me.lbl_Data_Faturamento_Ate = New System.Windows.Forms.Label()
        Me.pnl_Status_Aprovacao = New System.Windows.Forms.Panel()
        Me.ptb_Status_Aprovacao = New System.Windows.Forms.PictureBox()
        Me.clb_Status_Aprovacao = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Status_Aprovacao = New System.Windows.Forms.Label()
        Me.pnl_Data_Envio_Faturamento = New System.Windows.Forms.Panel()
        Me.dtp_Data_Envio_Faturamento_De = New System.Windows.Forms.DateTimePicker()
        Me.ptb_Data_Envio_Faturamento = New System.Windows.Forms.PictureBox()
        Me.dtp_Data_Envio_Faturamento_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Envio_Faturamento_De = New System.Windows.Forms.Label()
        Me.lbl_Data_Envio_Faturamento = New System.Windows.Forms.Label()
        Me.lbl_Data_Envio_Faturamento_Ate = New System.Windows.Forms.Label()
        Me.pnl_Cliente = New System.Windows.Forms.Panel()
        Me.ptb_Cliente = New System.Windows.Forms.PictureBox()
        Me.clb_Cliente = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.pnl_Data_Solicitacao = New System.Windows.Forms.Panel()
        Me.dtp_Data_Solicitacao_De = New System.Windows.Forms.DateTimePicker()
        Me.ptb_Data_Solicitacao = New System.Windows.Forms.PictureBox()
        Me.dtp_Data_Solicitacao_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Solicitacao_De = New System.Windows.Forms.Label()
        Me.lbl_Data_Solicitacao = New System.Windows.Forms.Label()
        Me.lbl_Data_Solicitacao_Ate = New System.Windows.Forms.Label()
        Me.pnl_Justificativa_Aprovacao = New System.Windows.Forms.Panel()
        Me.ptb_Justificativa_Aprovacao = New System.Windows.Forms.PictureBox()
        Me.clb_Justificativa_Aprovacao = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Justificativa_Aprovacao = New System.Windows.Forms.Label()
        Me.pnl_Data_Envio_Cliente = New System.Windows.Forms.Panel()
        Me.dtp_Data_Envio_Cliente_De = New System.Windows.Forms.DateTimePicker()
        Me.ptb_Data_Envio_Cliente = New System.Windows.Forms.PictureBox()
        Me.dtp_Data_Envio_Cliente_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Envio_Cliente_De = New System.Windows.Forms.Label()
        Me.lbl_Data_Envio_Cliente = New System.Windows.Forms.Label()
        Me.lbl_Data_Envio_Cliente_Ate = New System.Windows.Forms.Label()
        Me.ttp_Dica = New System.Windows.Forms.ToolTip(Me.components)
        Me.cms_Abrir_Proposta = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Visualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Exibir_Codigo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Nao_Exibir_Codigo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApenasOCódigoAtualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosOsCódigosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbreviadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grp_Resultados.SuspendLayout()
        CType(Me.dtg_Resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Opcoes.SuspendLayout()
        Me.grp_Filtros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_Setor.SuspendLayout()
        CType(Me.ptb_Setor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Usuario.SuspendLayout()
        CType(Me.ptb_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Prioridade.SuspendLayout()
        CType(Me.ptb_Prioridade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Data_Faturamento.SuspendLayout()
        CType(Me.ptb_Data_Faturamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Status_Aprovacao.SuspendLayout()
        CType(Me.ptb_Status_Aprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Data_Envio_Faturamento.SuspendLayout()
        CType(Me.ptb_Data_Envio_Faturamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Cliente.SuspendLayout()
        CType(Me.ptb_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Data_Solicitacao.SuspendLayout()
        CType(Me.ptb_Data_Solicitacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Justificativa_Aprovacao.SuspendLayout()
        CType(Me.ptb_Justificativa_Aprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Data_Envio_Cliente.SuspendLayout()
        CType(Me.ptb_Data_Envio_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Abrir_Proposta.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Resultados
        '
        Me.grp_Resultados.Controls.Add(Me.lbl_Limite_Resultados)
        Me.grp_Resultados.Controls.Add(Me.btn_Exportar)
        Me.grp_Resultados.Controls.Add(Me.lbl_Quantidade_Resultados)
        Me.grp_Resultados.Controls.Add(Me.dtg_Resultados)
        Me.grp_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Resultados.Location = New System.Drawing.Point(311, 106)
        Me.grp_Resultados.Name = "grp_Resultados"
        Me.grp_Resultados.Size = New System.Drawing.Size(896, 470)
        Me.grp_Resultados.TabIndex = 63
        Me.grp_Resultados.TabStop = False
        Me.grp_Resultados.Text = "Resultados"
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
        'dtg_Resultados
        '
        Me.dtg_Resultados.AllowUserToAddRows = False
        Me.dtg_Resultados.AllowUserToDeleteRows = False
        Me.dtg_Resultados.AllowUserToResizeColumns = False
        Me.dtg_Resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Resultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Resultados.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Resultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dtg_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Resultados.DefaultCellStyle = DataGridViewCellStyle16
        Me.dtg_Resultados.Location = New System.Drawing.Point(18, 22)
        Me.dtg_Resultados.MultiSelect = False
        Me.dtg_Resultados.Name = "dtg_Resultados"
        Me.dtg_Resultados.ReadOnly = True
        Me.dtg_Resultados.RowHeadersVisible = False
        Me.dtg_Resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Resultados.Size = New System.Drawing.Size(868, 407)
        Me.dtg_Resultados.TabIndex = 59
        Me.ttp_Dica.SetToolTip(Me.dtg_Resultados, "Clique duas vezes em um resultado para abrir a proposta")
        '
        'btn_Pesquisar
        '
        Me.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Pesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Pesquisar.ImageKey = "magnifying-glass.png"
        Me.btn_Pesquisar.ImageList = Me.img_List_16x16
        Me.btn_Pesquisar.Location = New System.Drawing.Point(1083, 36)
        Me.btn_Pesquisar.Name = "btn_Pesquisar"
        Me.btn_Pesquisar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Pesquisar.TabIndex = 3
        Me.btn_Pesquisar.Text = "  Pesquisar"
        Me.btn_Pesquisar.UseVisualStyleBackColor = True
        '
        'grp_Opcoes
        '
        Me.grp_Opcoes.Controls.Add(Me.chb_Considerar_Revisadas)
        Me.grp_Opcoes.Controls.Add(Me.txt_Texto_Pesquisa)
        Me.grp_Opcoes.Controls.Add(Me.btn_Pesquisar)
        Me.grp_Opcoes.Controls.Add(Me.lbl_Texto_Pesquisa)
        Me.grp_Opcoes.Controls.Add(Me.lbl_Data_Ate)
        Me.grp_Opcoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Opcoes.Location = New System.Drawing.Point(12, 12)
        Me.grp_Opcoes.Name = "grp_Opcoes"
        Me.grp_Opcoes.Size = New System.Drawing.Size(1195, 88)
        Me.grp_Opcoes.TabIndex = 0
        Me.grp_Opcoes.TabStop = False
        Me.grp_Opcoes.Text = "Opções"
        '
        'chb_Considerar_Revisadas
        '
        Me.chb_Considerar_Revisadas.AutoSize = True
        Me.chb_Considerar_Revisadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_Considerar_Revisadas.Location = New System.Drawing.Point(16, 64)
        Me.chb_Considerar_Revisadas.Name = "chb_Considerar_Revisadas"
        Me.chb_Considerar_Revisadas.Size = New System.Drawing.Size(173, 17)
        Me.chb_Considerar_Revisadas.TabIndex = 90
        Me.chb_Considerar_Revisadas.Text = "Considerar propostas revisadas"
        Me.chb_Considerar_Revisadas.UseVisualStyleBackColor = True
        '
        'txt_Texto_Pesquisa
        '
        Me.txt_Texto_Pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Texto_Pesquisa.Location = New System.Drawing.Point(16, 39)
        Me.txt_Texto_Pesquisa.MaxLength = 255
        Me.txt_Texto_Pesquisa.Name = "txt_Texto_Pesquisa"
        Me.txt_Texto_Pesquisa.Size = New System.Drawing.Size(1061, 20)
        Me.txt_Texto_Pesquisa.TabIndex = 2
        '
        'lbl_Texto_Pesquisa
        '
        Me.lbl_Texto_Pesquisa.AutoSize = True
        Me.lbl_Texto_Pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Texto_Pesquisa.Location = New System.Drawing.Point(13, 22)
        Me.lbl_Texto_Pesquisa.Name = "lbl_Texto_Pesquisa"
        Me.lbl_Texto_Pesquisa.Size = New System.Drawing.Size(139, 13)
        Me.lbl_Texto_Pesquisa.TabIndex = 0
        Me.lbl_Texto_Pesquisa.Text = "Texto a ser pesquisado"
        '
        'lbl_Data_Ate
        '
        Me.lbl_Data_Ate.AutoSize = True
        Me.lbl_Data_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Ate.Location = New System.Drawing.Point(17, 22)
        Me.lbl_Data_Ate.Name = "lbl_Data_Ate"
        Me.lbl_Data_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Ate.TabIndex = 1
        Me.lbl_Data_Ate.Text = "Até"
        '
        'grp_Filtros
        '
        Me.grp_Filtros.Controls.Add(Me.Panel1)
        Me.grp_Filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Filtros.Location = New System.Drawing.Point(12, 106)
        Me.grp_Filtros.Name = "grp_Filtros"
        Me.grp_Filtros.Size = New System.Drawing.Size(293, 470)
        Me.grp_Filtros.TabIndex = 64
        Me.grp_Filtros.TabStop = False
        Me.grp_Filtros.Text = "Filtros"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.pnl_Setor)
        Me.Panel1.Controls.Add(Me.pnl_Usuario)
        Me.Panel1.Controls.Add(Me.pnl_Prioridade)
        Me.Panel1.Controls.Add(Me.pnl_Data_Faturamento)
        Me.Panel1.Controls.Add(Me.pnl_Status_Aprovacao)
        Me.Panel1.Controls.Add(Me.pnl_Data_Envio_Faturamento)
        Me.Panel1.Controls.Add(Me.pnl_Cliente)
        Me.Panel1.Controls.Add(Me.pnl_Data_Solicitacao)
        Me.Panel1.Controls.Add(Me.pnl_Justificativa_Aprovacao)
        Me.Panel1.Controls.Add(Me.pnl_Data_Envio_Cliente)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 445)
        Me.Panel1.TabIndex = 65
        '
        'pnl_Setor
        '
        Me.pnl_Setor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnl_Setor.Controls.Add(Me.ptb_Setor)
        Me.pnl_Setor.Controls.Add(Me.clb_Setor)
        Me.pnl_Setor.Controls.Add(Me.lbl_Setor)
        Me.pnl_Setor.Location = New System.Drawing.Point(4, 4)
        Me.pnl_Setor.Name = "pnl_Setor"
        Me.pnl_Setor.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Setor.TabIndex = 69
        '
        'ptb_Setor
        '
        Me.ptb_Setor.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Setor.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Setor.Name = "ptb_Setor"
        Me.ptb_Setor.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Setor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Setor.TabIndex = 43
        Me.ptb_Setor.TabStop = False
        '
        'clb_Setor
        '
        Me.clb_Setor.CheckOnClick = True
        Me.clb_Setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Setor.FormattingEnabled = True
        Me.clb_Setor.Location = New System.Drawing.Point(7, 21)
        Me.clb_Setor.Name = "clb_Setor"
        Me.clb_Setor.Size = New System.Drawing.Size(235, 94)
        Me.clb_Setor.TabIndex = 13
        '
        'lbl_Setor
        '
        Me.lbl_Setor.AutoSize = True
        Me.lbl_Setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Setor.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Setor.Name = "lbl_Setor"
        Me.lbl_Setor.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Setor.TabIndex = 42
        Me.lbl_Setor.Text = "Setor"
        '
        'pnl_Usuario
        '
        Me.pnl_Usuario.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnl_Usuario.Controls.Add(Me.ptb_Usuario)
        Me.pnl_Usuario.Controls.Add(Me.clb_Usuario)
        Me.pnl_Usuario.Controls.Add(Me.lbl_Usuario)
        Me.pnl_Usuario.Location = New System.Drawing.Point(4, 131)
        Me.pnl_Usuario.Name = "pnl_Usuario"
        Me.pnl_Usuario.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Usuario.TabIndex = 65
        '
        'ptb_Usuario
        '
        Me.ptb_Usuario.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Usuario.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Usuario.Name = "ptb_Usuario"
        Me.ptb_Usuario.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Usuario.TabIndex = 43
        Me.ptb_Usuario.TabStop = False
        '
        'clb_Usuario
        '
        Me.clb_Usuario.CheckOnClick = True
        Me.clb_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Usuario.FormattingEnabled = True
        Me.clb_Usuario.Location = New System.Drawing.Point(7, 21)
        Me.clb_Usuario.Name = "clb_Usuario"
        Me.clb_Usuario.Size = New System.Drawing.Size(235, 94)
        Me.clb_Usuario.TabIndex = 13
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Usuario.TabIndex = 42
        Me.lbl_Usuario.Text = "Usuário"
        '
        'pnl_Prioridade
        '
        Me.pnl_Prioridade.Controls.Add(Me.ptb_Prioridade)
        Me.pnl_Prioridade.Controls.Add(Me.clb_Prioridade)
        Me.pnl_Prioridade.Controls.Add(Me.lbl_Prioridade)
        Me.pnl_Prioridade.Location = New System.Drawing.Point(4, 641)
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
        'pnl_Data_Faturamento
        '
        Me.pnl_Data_Faturamento.Controls.Add(Me.dtp_Data_Faturamento_De)
        Me.pnl_Data_Faturamento.Controls.Add(Me.ptb_Data_Faturamento)
        Me.pnl_Data_Faturamento.Controls.Add(Me.dtp_Data_Faturamento_Ate)
        Me.pnl_Data_Faturamento.Controls.Add(Me.lbl_Data_Faturamento_De)
        Me.pnl_Data_Faturamento.Controls.Add(Me.lbl_Data_Faturamento)
        Me.pnl_Data_Faturamento.Controls.Add(Me.lbl_Data_Faturamento_Ate)
        Me.pnl_Data_Faturamento.Location = New System.Drawing.Point(4, 1025)
        Me.pnl_Data_Faturamento.Name = "pnl_Data_Faturamento"
        Me.pnl_Data_Faturamento.Size = New System.Drawing.Size(253, 79)
        Me.pnl_Data_Faturamento.TabIndex = 67
        '
        'dtp_Data_Faturamento_De
        '
        Me.dtp_Data_Faturamento_De.Checked = False
        Me.dtp_Data_Faturamento_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Faturamento_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Faturamento_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Faturamento_De.Location = New System.Drawing.Point(10, 45)
        Me.dtp_Data_Faturamento_De.Name = "dtp_Data_Faturamento_De"
        Me.dtp_Data_Faturamento_De.ShowCheckBox = True
        Me.dtp_Data_Faturamento_De.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Faturamento_De.TabIndex = 75
        Me.dtp_Data_Faturamento_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'ptb_Data_Faturamento
        '
        Me.ptb_Data_Faturamento.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Data_Faturamento.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Data_Faturamento.Name = "ptb_Data_Faturamento"
        Me.ptb_Data_Faturamento.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Data_Faturamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Data_Faturamento.TabIndex = 43
        Me.ptb_Data_Faturamento.TabStop = False
        '
        'dtp_Data_Faturamento_Ate
        '
        Me.dtp_Data_Faturamento_Ate.Checked = False
        Me.dtp_Data_Faturamento_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Faturamento_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Faturamento_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Faturamento_Ate.Location = New System.Drawing.Point(129, 45)
        Me.dtp_Data_Faturamento_Ate.Name = "dtp_Data_Faturamento_Ate"
        Me.dtp_Data_Faturamento_Ate.ShowCheckBox = True
        Me.dtp_Data_Faturamento_Ate.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Faturamento_Ate.TabIndex = 77
        '
        'lbl_Data_Faturamento_De
        '
        Me.lbl_Data_Faturamento_De.AutoSize = True
        Me.lbl_Data_Faturamento_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Faturamento_De.Location = New System.Drawing.Point(7, 29)
        Me.lbl_Data_Faturamento_De.Name = "lbl_Data_Faturamento_De"
        Me.lbl_Data_Faturamento_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Data_Faturamento_De.TabIndex = 76
        Me.lbl_Data_Faturamento_De.Text = "De"
        '
        'lbl_Data_Faturamento
        '
        Me.lbl_Data_Faturamento.AutoSize = True
        Me.lbl_Data_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Faturamento.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Data_Faturamento.Name = "lbl_Data_Faturamento"
        Me.lbl_Data_Faturamento.Size = New System.Drawing.Size(123, 13)
        Me.lbl_Data_Faturamento.TabIndex = 42
        Me.lbl_Data_Faturamento.Text = "Data de faturamento"
        '
        'lbl_Data_Faturamento_Ate
        '
        Me.lbl_Data_Faturamento_Ate.AutoSize = True
        Me.lbl_Data_Faturamento_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Faturamento_Ate.Location = New System.Drawing.Point(126, 29)
        Me.lbl_Data_Faturamento_Ate.Name = "lbl_Data_Faturamento_Ate"
        Me.lbl_Data_Faturamento_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Faturamento_Ate.TabIndex = 78
        Me.lbl_Data_Faturamento_Ate.Text = "Até"
        '
        'pnl_Status_Aprovacao
        '
        Me.pnl_Status_Aprovacao.Controls.Add(Me.ptb_Status_Aprovacao)
        Me.pnl_Status_Aprovacao.Controls.Add(Me.clb_Status_Aprovacao)
        Me.pnl_Status_Aprovacao.Controls.Add(Me.lbl_Status_Aprovacao)
        Me.pnl_Status_Aprovacao.Location = New System.Drawing.Point(4, 387)
        Me.pnl_Status_Aprovacao.Name = "pnl_Status_Aprovacao"
        Me.pnl_Status_Aprovacao.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Status_Aprovacao.TabIndex = 18
        '
        'ptb_Status_Aprovacao
        '
        Me.ptb_Status_Aprovacao.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Status_Aprovacao.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Status_Aprovacao.Name = "ptb_Status_Aprovacao"
        Me.ptb_Status_Aprovacao.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Status_Aprovacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Status_Aprovacao.TabIndex = 43
        Me.ptb_Status_Aprovacao.TabStop = False
        '
        'clb_Status_Aprovacao
        '
        Me.clb_Status_Aprovacao.CheckOnClick = True
        Me.clb_Status_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Status_Aprovacao.FormattingEnabled = True
        Me.clb_Status_Aprovacao.Location = New System.Drawing.Point(7, 21)
        Me.clb_Status_Aprovacao.Name = "clb_Status_Aprovacao"
        Me.clb_Status_Aprovacao.Size = New System.Drawing.Size(235, 94)
        Me.clb_Status_Aprovacao.TabIndex = 13
        '
        'lbl_Status_Aprovacao
        '
        Me.lbl_Status_Aprovacao.AutoSize = True
        Me.lbl_Status_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status_Aprovacao.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Status_Aprovacao.Name = "lbl_Status_Aprovacao"
        Me.lbl_Status_Aprovacao.Size = New System.Drawing.Size(125, 13)
        Me.lbl_Status_Aprovacao.TabIndex = 42
        Me.lbl_Status_Aprovacao.Text = "Status da aprovação"
        '
        'pnl_Data_Envio_Faturamento
        '
        Me.pnl_Data_Envio_Faturamento.Controls.Add(Me.dtp_Data_Envio_Faturamento_De)
        Me.pnl_Data_Envio_Faturamento.Controls.Add(Me.ptb_Data_Envio_Faturamento)
        Me.pnl_Data_Envio_Faturamento.Controls.Add(Me.dtp_Data_Envio_Faturamento_Ate)
        Me.pnl_Data_Envio_Faturamento.Controls.Add(Me.lbl_Data_Envio_Faturamento_De)
        Me.pnl_Data_Envio_Faturamento.Controls.Add(Me.lbl_Data_Envio_Faturamento)
        Me.pnl_Data_Envio_Faturamento.Controls.Add(Me.lbl_Data_Envio_Faturamento_Ate)
        Me.pnl_Data_Envio_Faturamento.Location = New System.Drawing.Point(4, 940)
        Me.pnl_Data_Envio_Faturamento.Name = "pnl_Data_Envio_Faturamento"
        Me.pnl_Data_Envio_Faturamento.Size = New System.Drawing.Size(253, 79)
        Me.pnl_Data_Envio_Faturamento.TabIndex = 66
        '
        'dtp_Data_Envio_Faturamento_De
        '
        Me.dtp_Data_Envio_Faturamento_De.Checked = False
        Me.dtp_Data_Envio_Faturamento_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Envio_Faturamento_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Envio_Faturamento_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Envio_Faturamento_De.Location = New System.Drawing.Point(10, 45)
        Me.dtp_Data_Envio_Faturamento_De.Name = "dtp_Data_Envio_Faturamento_De"
        Me.dtp_Data_Envio_Faturamento_De.ShowCheckBox = True
        Me.dtp_Data_Envio_Faturamento_De.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Envio_Faturamento_De.TabIndex = 75
        Me.dtp_Data_Envio_Faturamento_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'ptb_Data_Envio_Faturamento
        '
        Me.ptb_Data_Envio_Faturamento.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Data_Envio_Faturamento.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Data_Envio_Faturamento.Name = "ptb_Data_Envio_Faturamento"
        Me.ptb_Data_Envio_Faturamento.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Data_Envio_Faturamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Data_Envio_Faturamento.TabIndex = 43
        Me.ptb_Data_Envio_Faturamento.TabStop = False
        '
        'dtp_Data_Envio_Faturamento_Ate
        '
        Me.dtp_Data_Envio_Faturamento_Ate.Checked = False
        Me.dtp_Data_Envio_Faturamento_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Envio_Faturamento_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Envio_Faturamento_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Envio_Faturamento_Ate.Location = New System.Drawing.Point(129, 45)
        Me.dtp_Data_Envio_Faturamento_Ate.Name = "dtp_Data_Envio_Faturamento_Ate"
        Me.dtp_Data_Envio_Faturamento_Ate.ShowCheckBox = True
        Me.dtp_Data_Envio_Faturamento_Ate.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Envio_Faturamento_Ate.TabIndex = 77
        '
        'lbl_Data_Envio_Faturamento_De
        '
        Me.lbl_Data_Envio_Faturamento_De.AutoSize = True
        Me.lbl_Data_Envio_Faturamento_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Faturamento_De.Location = New System.Drawing.Point(7, 29)
        Me.lbl_Data_Envio_Faturamento_De.Name = "lbl_Data_Envio_Faturamento_De"
        Me.lbl_Data_Envio_Faturamento_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Data_Envio_Faturamento_De.TabIndex = 76
        Me.lbl_Data_Envio_Faturamento_De.Text = "De"
        '
        'lbl_Data_Envio_Faturamento
        '
        Me.lbl_Data_Envio_Faturamento.AutoSize = True
        Me.lbl_Data_Envio_Faturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Faturamento.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Data_Envio_Faturamento.Name = "lbl_Data_Envio_Faturamento"
        Me.lbl_Data_Envio_Faturamento.Size = New System.Drawing.Size(175, 13)
        Me.lbl_Data_Envio_Faturamento.TabIndex = 42
        Me.lbl_Data_Envio_Faturamento.Text = "Data de envio p/ faturamento"
        '
        'lbl_Data_Envio_Faturamento_Ate
        '
        Me.lbl_Data_Envio_Faturamento_Ate.AutoSize = True
        Me.lbl_Data_Envio_Faturamento_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Faturamento_Ate.Location = New System.Drawing.Point(126, 29)
        Me.lbl_Data_Envio_Faturamento_Ate.Name = "lbl_Data_Envio_Faturamento_Ate"
        Me.lbl_Data_Envio_Faturamento_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Envio_Faturamento_Ate.TabIndex = 78
        Me.lbl_Data_Envio_Faturamento_Ate.Text = "Até"
        '
        'pnl_Cliente
        '
        Me.pnl_Cliente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnl_Cliente.Controls.Add(Me.ptb_Cliente)
        Me.pnl_Cliente.Controls.Add(Me.clb_Cliente)
        Me.pnl_Cliente.Controls.Add(Me.lbl_Cliente)
        Me.pnl_Cliente.Location = New System.Drawing.Point(4, 259)
        Me.pnl_Cliente.Name = "pnl_Cliente"
        Me.pnl_Cliente.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Cliente.TabIndex = 45
        '
        'ptb_Cliente
        '
        Me.ptb_Cliente.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Cliente.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Cliente.Name = "ptb_Cliente"
        Me.ptb_Cliente.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Cliente.TabIndex = 43
        Me.ptb_Cliente.TabStop = False
        '
        'clb_Cliente
        '
        Me.clb_Cliente.CheckOnClick = True
        Me.clb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Cliente.FormattingEnabled = True
        Me.clb_Cliente.Location = New System.Drawing.Point(7, 21)
        Me.clb_Cliente.Name = "clb_Cliente"
        Me.clb_Cliente.Size = New System.Drawing.Size(235, 94)
        Me.clb_Cliente.TabIndex = 13
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Cliente.TabIndex = 42
        Me.lbl_Cliente.Text = "Cliente"
        '
        'pnl_Data_Solicitacao
        '
        Me.pnl_Data_Solicitacao.Controls.Add(Me.dtp_Data_Solicitacao_De)
        Me.pnl_Data_Solicitacao.Controls.Add(Me.ptb_Data_Solicitacao)
        Me.pnl_Data_Solicitacao.Controls.Add(Me.dtp_Data_Solicitacao_Ate)
        Me.pnl_Data_Solicitacao.Controls.Add(Me.lbl_Data_Solicitacao_De)
        Me.pnl_Data_Solicitacao.Controls.Add(Me.lbl_Data_Solicitacao)
        Me.pnl_Data_Solicitacao.Controls.Add(Me.lbl_Data_Solicitacao_Ate)
        Me.pnl_Data_Solicitacao.Location = New System.Drawing.Point(4, 768)
        Me.pnl_Data_Solicitacao.Name = "pnl_Data_Solicitacao"
        Me.pnl_Data_Solicitacao.Size = New System.Drawing.Size(253, 79)
        Me.pnl_Data_Solicitacao.TabIndex = 46
        '
        'dtp_Data_Solicitacao_De
        '
        Me.dtp_Data_Solicitacao_De.Checked = False
        Me.dtp_Data_Solicitacao_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Solicitacao_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Solicitacao_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Solicitacao_De.Location = New System.Drawing.Point(10, 45)
        Me.dtp_Data_Solicitacao_De.Name = "dtp_Data_Solicitacao_De"
        Me.dtp_Data_Solicitacao_De.ShowCheckBox = True
        Me.dtp_Data_Solicitacao_De.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Solicitacao_De.TabIndex = 75
        Me.dtp_Data_Solicitacao_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'ptb_Data_Solicitacao
        '
        Me.ptb_Data_Solicitacao.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Data_Solicitacao.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Data_Solicitacao.Name = "ptb_Data_Solicitacao"
        Me.ptb_Data_Solicitacao.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Data_Solicitacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Data_Solicitacao.TabIndex = 43
        Me.ptb_Data_Solicitacao.TabStop = False
        '
        'dtp_Data_Solicitacao_Ate
        '
        Me.dtp_Data_Solicitacao_Ate.Checked = False
        Me.dtp_Data_Solicitacao_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Solicitacao_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Solicitacao_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Solicitacao_Ate.Location = New System.Drawing.Point(129, 45)
        Me.dtp_Data_Solicitacao_Ate.Name = "dtp_Data_Solicitacao_Ate"
        Me.dtp_Data_Solicitacao_Ate.ShowCheckBox = True
        Me.dtp_Data_Solicitacao_Ate.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Solicitacao_Ate.TabIndex = 77
        '
        'lbl_Data_Solicitacao_De
        '
        Me.lbl_Data_Solicitacao_De.AutoSize = True
        Me.lbl_Data_Solicitacao_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Solicitacao_De.Location = New System.Drawing.Point(7, 29)
        Me.lbl_Data_Solicitacao_De.Name = "lbl_Data_Solicitacao_De"
        Me.lbl_Data_Solicitacao_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Data_Solicitacao_De.TabIndex = 76
        Me.lbl_Data_Solicitacao_De.Text = "De"
        '
        'lbl_Data_Solicitacao
        '
        Me.lbl_Data_Solicitacao.AutoSize = True
        Me.lbl_Data_Solicitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Solicitacao.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Data_Solicitacao.Name = "lbl_Data_Solicitacao"
        Me.lbl_Data_Solicitacao.Size = New System.Drawing.Size(117, 13)
        Me.lbl_Data_Solicitacao.TabIndex = 42
        Me.lbl_Data_Solicitacao.Text = "Data de solicitação"
        '
        'lbl_Data_Solicitacao_Ate
        '
        Me.lbl_Data_Solicitacao_Ate.AutoSize = True
        Me.lbl_Data_Solicitacao_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Solicitacao_Ate.Location = New System.Drawing.Point(126, 29)
        Me.lbl_Data_Solicitacao_Ate.Name = "lbl_Data_Solicitacao_Ate"
        Me.lbl_Data_Solicitacao_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Solicitacao_Ate.TabIndex = 78
        Me.lbl_Data_Solicitacao_Ate.Text = "Até"
        '
        'pnl_Justificativa_Aprovacao
        '
        Me.pnl_Justificativa_Aprovacao.Controls.Add(Me.ptb_Justificativa_Aprovacao)
        Me.pnl_Justificativa_Aprovacao.Controls.Add(Me.clb_Justificativa_Aprovacao)
        Me.pnl_Justificativa_Aprovacao.Controls.Add(Me.lbl_Justificativa_Aprovacao)
        Me.pnl_Justificativa_Aprovacao.Location = New System.Drawing.Point(4, 514)
        Me.pnl_Justificativa_Aprovacao.Name = "pnl_Justificativa_Aprovacao"
        Me.pnl_Justificativa_Aprovacao.Size = New System.Drawing.Size(253, 121)
        Me.pnl_Justificativa_Aprovacao.TabIndex = 44
        '
        'ptb_Justificativa_Aprovacao
        '
        Me.ptb_Justificativa_Aprovacao.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Justificativa_Aprovacao.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Justificativa_Aprovacao.Name = "ptb_Justificativa_Aprovacao"
        Me.ptb_Justificativa_Aprovacao.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Justificativa_Aprovacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Justificativa_Aprovacao.TabIndex = 43
        Me.ptb_Justificativa_Aprovacao.TabStop = False
        '
        'clb_Justificativa_Aprovacao
        '
        Me.clb_Justificativa_Aprovacao.CheckOnClick = True
        Me.clb_Justificativa_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Justificativa_Aprovacao.FormattingEnabled = True
        Me.clb_Justificativa_Aprovacao.Location = New System.Drawing.Point(7, 21)
        Me.clb_Justificativa_Aprovacao.Name = "clb_Justificativa_Aprovacao"
        Me.clb_Justificativa_Aprovacao.Size = New System.Drawing.Size(235, 94)
        Me.clb_Justificativa_Aprovacao.TabIndex = 13
        '
        'lbl_Justificativa_Aprovacao
        '
        Me.lbl_Justificativa_Aprovacao.AutoSize = True
        Me.lbl_Justificativa_Aprovacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Justificativa_Aprovacao.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Justificativa_Aprovacao.Name = "lbl_Justificativa_Aprovacao"
        Me.lbl_Justificativa_Aprovacao.Size = New System.Drawing.Size(157, 13)
        Me.lbl_Justificativa_Aprovacao.TabIndex = 42
        Me.lbl_Justificativa_Aprovacao.Text = "Justificativa da aprovação"
        '
        'pnl_Data_Envio_Cliente
        '
        Me.pnl_Data_Envio_Cliente.Controls.Add(Me.dtp_Data_Envio_Cliente_De)
        Me.pnl_Data_Envio_Cliente.Controls.Add(Me.ptb_Data_Envio_Cliente)
        Me.pnl_Data_Envio_Cliente.Controls.Add(Me.dtp_Data_Envio_Cliente_Ate)
        Me.pnl_Data_Envio_Cliente.Controls.Add(Me.lbl_Data_Envio_Cliente_De)
        Me.pnl_Data_Envio_Cliente.Controls.Add(Me.lbl_Data_Envio_Cliente)
        Me.pnl_Data_Envio_Cliente.Controls.Add(Me.lbl_Data_Envio_Cliente_Ate)
        Me.pnl_Data_Envio_Cliente.Location = New System.Drawing.Point(4, 855)
        Me.pnl_Data_Envio_Cliente.Name = "pnl_Data_Envio_Cliente"
        Me.pnl_Data_Envio_Cliente.Size = New System.Drawing.Size(253, 79)
        Me.pnl_Data_Envio_Cliente.TabIndex = 65
        '
        'dtp_Data_Envio_Cliente_De
        '
        Me.dtp_Data_Envio_Cliente_De.Checked = False
        Me.dtp_Data_Envio_Cliente_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Envio_Cliente_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Envio_Cliente_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Envio_Cliente_De.Location = New System.Drawing.Point(10, 45)
        Me.dtp_Data_Envio_Cliente_De.Name = "dtp_Data_Envio_Cliente_De"
        Me.dtp_Data_Envio_Cliente_De.ShowCheckBox = True
        Me.dtp_Data_Envio_Cliente_De.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Envio_Cliente_De.TabIndex = 75
        Me.dtp_Data_Envio_Cliente_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'ptb_Data_Envio_Cliente
        '
        Me.ptb_Data_Envio_Cliente.Image = Global.Eurolift_Services.My.Resources.Resources.clear_filter_icon_4
        Me.ptb_Data_Envio_Cliente.Location = New System.Drawing.Point(229, 6)
        Me.ptb_Data_Envio_Cliente.Name = "ptb_Data_Envio_Cliente"
        Me.ptb_Data_Envio_Cliente.Size = New System.Drawing.Size(13, 13)
        Me.ptb_Data_Envio_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Data_Envio_Cliente.TabIndex = 43
        Me.ptb_Data_Envio_Cliente.TabStop = False
        '
        'dtp_Data_Envio_Cliente_Ate
        '
        Me.dtp_Data_Envio_Cliente_Ate.Checked = False
        Me.dtp_Data_Envio_Cliente_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Envio_Cliente_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Envio_Cliente_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Envio_Cliente_Ate.Location = New System.Drawing.Point(129, 45)
        Me.dtp_Data_Envio_Cliente_Ate.Name = "dtp_Data_Envio_Cliente_Ate"
        Me.dtp_Data_Envio_Cliente_Ate.ShowCheckBox = True
        Me.dtp_Data_Envio_Cliente_Ate.Size = New System.Drawing.Size(113, 20)
        Me.dtp_Data_Envio_Cliente_Ate.TabIndex = 77
        '
        'lbl_Data_Envio_Cliente_De
        '
        Me.lbl_Data_Envio_Cliente_De.AutoSize = True
        Me.lbl_Data_Envio_Cliente_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Cliente_De.Location = New System.Drawing.Point(7, 29)
        Me.lbl_Data_Envio_Cliente_De.Name = "lbl_Data_Envio_Cliente_De"
        Me.lbl_Data_Envio_Cliente_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Data_Envio_Cliente_De.TabIndex = 76
        Me.lbl_Data_Envio_Cliente_De.Text = "De"
        '
        'lbl_Data_Envio_Cliente
        '
        Me.lbl_Data_Envio_Cliente.AutoSize = True
        Me.lbl_Data_Envio_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Cliente.Location = New System.Drawing.Point(4, 6)
        Me.lbl_Data_Envio_Cliente.Name = "lbl_Data_Envio_Cliente"
        Me.lbl_Data_Envio_Cliente.Size = New System.Drawing.Size(169, 13)
        Me.lbl_Data_Envio_Cliente.TabIndex = 42
        Me.lbl_Data_Envio_Cliente.Text = "Data de envio para o cliente"
        '
        'lbl_Data_Envio_Cliente_Ate
        '
        Me.lbl_Data_Envio_Cliente_Ate.AutoSize = True
        Me.lbl_Data_Envio_Cliente_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Envio_Cliente_Ate.Location = New System.Drawing.Point(126, 29)
        Me.lbl_Data_Envio_Cliente_Ate.Name = "lbl_Data_Envio_Cliente_Ate"
        Me.lbl_Data_Envio_Cliente_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Data_Envio_Cliente_Ate.TabIndex = 78
        Me.lbl_Data_Envio_Cliente_Ate.Text = "Até"
        '
        'ttp_Dica
        '
        Me.ttp_Dica.AutoPopDelay = 5000
        Me.ttp_Dica.InitialDelay = 100
        Me.ttp_Dica.IsBalloon = True
        Me.ttp_Dica.ReshowDelay = 100
        Me.ttp_Dica.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttp_Dica.ToolTipTitle = "Dica"
        '
        'cms_Abrir_Proposta
        '
        Me.cms_Abrir_Proposta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.tsmi_Visualizar})
        Me.cms_Abrir_Proposta.Name = "ContextMenuStrip1"
        Me.cms_Abrir_Proposta.Size = New System.Drawing.Size(181, 70)
        Me.cms_Abrir_Proposta.Text = "Importar"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = Global.Eurolift_Services.My.Resources.Resources.external_link_symbol
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'tsmi_Visualizar
        '
        Me.tsmi_Visualizar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Exibir_Codigo, Me.tsmi_Nao_Exibir_Codigo})
        Me.tsmi_Visualizar.Image = Global.Eurolift_Services.My.Resources.Resources.pdf_file_format_symbol
        Me.tsmi_Visualizar.Name = "tsmi_Visualizar"
        Me.tsmi_Visualizar.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Visualizar.Text = "Visualizar"
        '
        'tsmi_Exibir_Codigo
        '
        Me.tsmi_Exibir_Codigo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApenasOCódigoAtualToolStripMenuItem, Me.TodosOsCódigosToolStripMenuItem})
        Me.tsmi_Exibir_Codigo.Name = "tsmi_Exibir_Codigo"
        Me.tsmi_Exibir_Codigo.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Exibir_Codigo.Text = "Exibir código"
        '
        'tsmi_Nao_Exibir_Codigo
        '
        Me.tsmi_Nao_Exibir_Codigo.Name = "tsmi_Nao_Exibir_Codigo"
        Me.tsmi_Nao_Exibir_Codigo.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Nao_Exibir_Codigo.Text = "Não exibir código"
        '
        'ApenasOCódigoAtualToolStripMenuItem
        '
        Me.ApenasOCódigoAtualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbreviadoToolStripMenuItem, Me.CompletoToolStripMenuItem})
        Me.ApenasOCódigoAtualToolStripMenuItem.Name = "ApenasOCódigoAtualToolStripMenuItem"
        Me.ApenasOCódigoAtualToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ApenasOCódigoAtualToolStripMenuItem.Text = "Apenas o código atual"
        '
        'TodosOsCódigosToolStripMenuItem
        '
        Me.TodosOsCódigosToolStripMenuItem.Name = "TodosOsCódigosToolStripMenuItem"
        Me.TodosOsCódigosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TodosOsCódigosToolStripMenuItem.Text = "Todos os códigos"
        '
        'AbreviadoToolStripMenuItem
        '
        Me.AbreviadoToolStripMenuItem.Name = "AbreviadoToolStripMenuItem"
        Me.AbreviadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbreviadoToolStripMenuItem.Text = "Abreviado"
        '
        'CompletoToolStripMenuItem
        '
        Me.CompletoToolStripMenuItem.Name = "CompletoToolStripMenuItem"
        Me.CompletoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CompletoToolStripMenuItem.Text = "Completo"
        '
        'Pesquisa_Proposta_Padrao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 584)
        Me.Controls.Add(Me.grp_Filtros)
        Me.Controls.Add(Me.grp_Resultados)
        Me.Controls.Add(Me.grp_Opcoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pesquisa_Proposta_Padrao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisar proposta"
        Me.grp_Resultados.ResumeLayout(False)
        Me.grp_Resultados.PerformLayout()
        CType(Me.dtg_Resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Opcoes.ResumeLayout(False)
        Me.grp_Opcoes.PerformLayout()
        Me.grp_Filtros.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnl_Setor.ResumeLayout(False)
        Me.pnl_Setor.PerformLayout()
        CType(Me.ptb_Setor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Usuario.ResumeLayout(False)
        Me.pnl_Usuario.PerformLayout()
        CType(Me.ptb_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Prioridade.ResumeLayout(False)
        Me.pnl_Prioridade.PerformLayout()
        CType(Me.ptb_Prioridade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Data_Faturamento.ResumeLayout(False)
        Me.pnl_Data_Faturamento.PerformLayout()
        CType(Me.ptb_Data_Faturamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Status_Aprovacao.ResumeLayout(False)
        Me.pnl_Status_Aprovacao.PerformLayout()
        CType(Me.ptb_Status_Aprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Data_Envio_Faturamento.ResumeLayout(False)
        Me.pnl_Data_Envio_Faturamento.PerformLayout()
        CType(Me.ptb_Data_Envio_Faturamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Cliente.ResumeLayout(False)
        Me.pnl_Cliente.PerformLayout()
        CType(Me.ptb_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Data_Solicitacao.ResumeLayout(False)
        Me.pnl_Data_Solicitacao.PerformLayout()
        CType(Me.ptb_Data_Solicitacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Justificativa_Aprovacao.ResumeLayout(False)
        Me.pnl_Justificativa_Aprovacao.PerformLayout()
        CType(Me.ptb_Justificativa_Aprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Data_Envio_Cliente.ResumeLayout(False)
        Me.pnl_Data_Envio_Cliente.PerformLayout()
        CType(Me.ptb_Data_Envio_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Abrir_Proposta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_Resultados As GroupBox
    Friend WithEvents lbl_Quantidade_Resultados As Label
    Friend WithEvents dtg_Resultados As DataGridView
    Friend WithEvents btn_Pesquisar As Button
    Friend WithEvents grp_Opcoes As GroupBox
    Friend WithEvents lbl_Texto_Pesquisa As Label
    Friend WithEvents lbl_Data_Ate As Label
    Friend WithEvents txt_Texto_Pesquisa As TextBox
    Friend WithEvents grp_Filtros As GroupBox
    Friend WithEvents pnl_Cliente As Panel
    Friend WithEvents ptb_Cliente As PictureBox
    Friend WithEvents clb_Cliente As CheckedListBox
    Friend WithEvents lbl_Cliente As Label
    Friend WithEvents pnl_Justificativa_Aprovacao As Panel
    Friend WithEvents ptb_Justificativa_Aprovacao As PictureBox
    Friend WithEvents clb_Justificativa_Aprovacao As CheckedListBox
    Friend WithEvents lbl_Justificativa_Aprovacao As Label
    Friend WithEvents pnl_Status_Aprovacao As Panel
    Friend WithEvents ptb_Status_Aprovacao As PictureBox
    Friend WithEvents clb_Status_Aprovacao As CheckedListBox
    Friend WithEvents lbl_Status_Aprovacao As Label
    Friend WithEvents pnl_Data_Solicitacao As Panel
    Friend WithEvents dtp_Data_Solicitacao_De As DateTimePicker
    Friend WithEvents ptb_Data_Solicitacao As PictureBox
    Friend WithEvents dtp_Data_Solicitacao_Ate As DateTimePicker
    Friend WithEvents lbl_Data_Solicitacao_De As Label
    Friend WithEvents lbl_Data_Solicitacao As Label
    Friend WithEvents lbl_Data_Solicitacao_Ate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_Data_Envio_Cliente As Panel
    Friend WithEvents dtp_Data_Envio_Cliente_De As DateTimePicker
    Friend WithEvents ptb_Data_Envio_Cliente As PictureBox
    Friend WithEvents dtp_Data_Envio_Cliente_Ate As DateTimePicker
    Friend WithEvents lbl_Data_Envio_Cliente_De As Label
    Friend WithEvents lbl_Data_Envio_Cliente As Label
    Friend WithEvents lbl_Data_Envio_Cliente_Ate As Label
    Friend WithEvents pnl_Data_Envio_Faturamento As Panel
    Friend WithEvents dtp_Data_Envio_Faturamento_De As DateTimePicker
    Friend WithEvents ptb_Data_Envio_Faturamento As PictureBox
    Friend WithEvents dtp_Data_Envio_Faturamento_Ate As DateTimePicker
    Friend WithEvents lbl_Data_Envio_Faturamento_De As Label
    Friend WithEvents lbl_Data_Envio_Faturamento As Label
    Friend WithEvents lbl_Data_Envio_Faturamento_Ate As Label
    Friend WithEvents pnl_Data_Faturamento As Panel
    Friend WithEvents dtp_Data_Faturamento_De As DateTimePicker
    Friend WithEvents ptb_Data_Faturamento As PictureBox
    Friend WithEvents dtp_Data_Faturamento_Ate As DateTimePicker
    Friend WithEvents lbl_Data_Faturamento_De As Label
    Friend WithEvents lbl_Data_Faturamento As Label
    Friend WithEvents lbl_Data_Faturamento_Ate As Label
    Friend WithEvents pnl_Prioridade As Panel
    Friend WithEvents ptb_Prioridade As PictureBox
    Friend WithEvents clb_Prioridade As CheckedListBox
    Friend WithEvents lbl_Prioridade As Label
    Friend WithEvents btn_Exportar As Button
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents ttp_Dica As ToolTip
    Friend WithEvents pnl_Usuario As Panel
    Friend WithEvents ptb_Usuario As PictureBox
    Friend WithEvents clb_Usuario As CheckedListBox
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents pnl_Setor As Panel
    Friend WithEvents ptb_Setor As PictureBox
    Friend WithEvents clb_Setor As CheckedListBox
    Friend WithEvents lbl_Setor As Label
    Friend WithEvents lbl_Limite_Resultados As Label
    Friend WithEvents chb_Considerar_Revisadas As CheckBox
    Friend WithEvents cms_Abrir_Proposta As ContextMenuStrip
    Friend WithEvents tsmi_Visualizar As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_Exibir_Codigo As ToolStripMenuItem
    Friend WithEvents tsmi_Nao_Exibir_Codigo As ToolStripMenuItem
    Friend WithEvents ApenasOCódigoAtualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosOsCódigosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbreviadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletoToolStripMenuItem As ToolStripMenuItem
End Class
