<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taxas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taxas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional = New System.Windows.Forms.Label()
        Me.dtp_Data_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Data_Inicio = New System.Windows.Forms.Label()
        Me.lbl_Data_Fim = New System.Windows.Forms.Label()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_id_taxa = New System.Windows.Forms.TextBox()
        Me.grp_Itens = New System.Windows.Forms.GroupBox()
        Me.dtg_Itens = New System.Windows.Forms.DataGridView()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.lbl_Nome = New System.Windows.Forms.Label()
        Me.mns_Menu = New System.Windows.Forms.MenuStrip()
        Me.mnsi_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsi_Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsi_Excluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbc_Taxas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_Percentual_Acrescimo_Item_Nacional = New System.Windows.Forms.Label()
        Me.nud_Percentual_Acrescimo_Item_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional = New System.Windows.Forms.Label()
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional = New System.Windows.Forms.Label()
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional = New System.Windows.Forms.Label()
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Impostos_Federais_Item_Nacional = New System.Windows.Forms.Label()
        Me.nud_Impostos_Federais_Item_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional = New System.Windows.Forms.Label()
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_MVA_Item_Nacional = New System.Windows.Forms.Label()
        Me.nud_Percentual_MVA_Item_Nacional = New System.Windows.Forms.NumericUpDown()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_Percentual_Acrescimo_Item_Importado = New System.Windows.Forms.Label()
        Me.nud_Percentual_Acrescimo_Item_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado = New System.Windows.Forms.Label()
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado = New System.Windows.Forms.Label()
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado = New System.Windows.Forms.Label()
        Me.nud_Rateio_Despesa_Fixa_Item_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Impostos_Federais_Item_Importado = New System.Windows.Forms.Label()
        Me.nud_Impostos_Federais_Item_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado = New System.Windows.Forms.Label()
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_MVA_Item_Importado = New System.Windows.Forms.Label()
        Me.nud_Percentual_MVA_Item_Importado = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado = New System.Windows.Forms.Label()
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado = New System.Windows.Forms.NumericUpDown()
        Me.dtp_Data_Fim = New System.Windows.Forms.DateTimePicker()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Salvar = New System.Windows.Forms.Button()
        CType(Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Itens.SuspendLayout()
        CType(Me.dtg_Itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mns_Menu.SuspendLayout()
        Me.tbc_Taxas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nud_Percentual_Acrescimo_Item_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Rateio_Despesa_Fixa_Item_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Impostos_Federais_Item_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_MVA_Item_Nacional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.nud_Percentual_Acrescimo_Item_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Rateio_Despesa_Fixa_Item_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Impostos_Federais_Item_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_MVA_Item_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional
        '
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.DecimalPlaces = 2
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Enabled = False
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.InterceptArrowKeys = False
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Location = New System.Drawing.Point(232, 8)
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Name = "nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional"
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional.TabIndex = 8
        '
        'lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional
        '
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.AutoSize = True
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Location = New System.Drawing.Point(13, 12)
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Name = "lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional"
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Size = New System.Drawing.Size(200, 13)
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.TabIndex = 7
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional.Text = "% Alíquota externa ICMS nacional"
        '
        'dtp_Data_Inicio
        '
        Me.dtp_Data_Inicio.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Inicio.Location = New System.Drawing.Point(15, 50)
        Me.dtp_Data_Inicio.Name = "dtp_Data_Inicio"
        Me.dtp_Data_Inicio.Size = New System.Drawing.Size(97, 20)
        Me.dtp_Data_Inicio.TabIndex = 53
        Me.dtp_Data_Inicio.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'lbl_Data_Inicio
        '
        Me.lbl_Data_Inicio.AutoSize = True
        Me.lbl_Data_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Inicio.Location = New System.Drawing.Point(12, 34)
        Me.lbl_Data_Inicio.Name = "lbl_Data_Inicio"
        Me.lbl_Data_Inicio.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Data_Inicio.TabIndex = 55
        Me.lbl_Data_Inicio.Text = "Data de início"
        '
        'lbl_Data_Fim
        '
        Me.lbl_Data_Fim.AutoSize = True
        Me.lbl_Data_Fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Data_Fim.Location = New System.Drawing.Point(118, 34)
        Me.lbl_Data_Fim.Name = "lbl_Data_Fim"
        Me.lbl_Data_Fim.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Data_Fim.TabIndex = 56
        Me.lbl_Data_Fim.Text = "Data fim"
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
        'txt_id_taxa
        '
        Me.txt_id_taxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_taxa.Location = New System.Drawing.Point(492, 488)
        Me.txt_id_taxa.Name = "txt_id_taxa"
        Me.txt_id_taxa.Size = New System.Drawing.Size(49, 20)
        Me.txt_id_taxa.TabIndex = 82
        Me.txt_id_taxa.Visible = False
        '
        'grp_Itens
        '
        Me.grp_Itens.Controls.Add(Me.dtg_Itens)
        Me.grp_Itens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Itens.Location = New System.Drawing.Point(15, 232)
        Me.grp_Itens.Name = "grp_Itens"
        Me.grp_Itens.Size = New System.Drawing.Size(671, 227)
        Me.grp_Itens.TabIndex = 79
        Me.grp_Itens.TabStop = False
        Me.grp_Itens.Text = "Itens"
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
        Me.dtg_Itens.Location = New System.Drawing.Point(15, 22)
        Me.dtg_Itens.MultiSelect = False
        Me.dtg_Itens.Name = "dtg_Itens"
        Me.dtg_Itens.ReadOnly = True
        Me.dtg_Itens.RowHeadersVisible = False
        Me.dtg_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Itens.Size = New System.Drawing.Size(639, 186)
        Me.dtg_Itens.TabIndex = 0
        '
        'txt_Nome
        '
        Me.txt_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nome.Location = New System.Drawing.Point(224, 50)
        Me.txt_Nome.MaxLength = 60
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(308, 20)
        Me.txt_Nome.TabIndex = 84
        '
        'lbl_Nome
        '
        Me.lbl_Nome.AutoSize = True
        Me.lbl_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nome.Location = New System.Drawing.Point(221, 34)
        Me.lbl_Nome.Name = "lbl_Nome"
        Me.lbl_Nome.Size = New System.Drawing.Size(85, 13)
        Me.lbl_Nome.TabIndex = 83
        Me.lbl_Nome.Text = "Nome da taxa"
        '
        'mns_Menu
        '
        Me.mns_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsi_Adicionar, Me.mnsi_Editar, Me.mnsi_Excluir})
        Me.mns_Menu.Location = New System.Drawing.Point(0, 0)
        Me.mns_Menu.Name = "mns_Menu"
        Me.mns_Menu.ShowItemToolTips = True
        Me.mns_Menu.Size = New System.Drawing.Size(702, 24)
        Me.mns_Menu.TabIndex = 86
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
        Me.mnsi_Excluir.Visible = False
        '
        'tbc_Taxas
        '
        Me.tbc_Taxas.Controls.Add(Me.TabPage1)
        Me.tbc_Taxas.Controls.Add(Me.TabPage2)
        Me.tbc_Taxas.Location = New System.Drawing.Point(15, 76)
        Me.tbc_Taxas.Name = "tbc_Taxas"
        Me.tbc_Taxas.SelectedIndex = 0
        Me.tbc_Taxas.Size = New System.Drawing.Size(671, 150)
        Me.tbc_Taxas.TabIndex = 87
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.lbl_Percentual_Acrescimo_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Percentual_Acrescimo_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Rateio_Despesa_Fixa_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Rateio_Despesa_Fixa_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Impostos_Federais_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Impostos_Federais_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Percentual_MVA_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Percentual_MVA_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional)
        Me.TabPage1.Controls.Add(Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(663, 124)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Taxas nacionais"
        '
        'lbl_Percentual_Acrescimo_Item_Nacional
        '
        Me.lbl_Percentual_Acrescimo_Item_Nacional.AutoSize = True
        Me.lbl_Percentual_Acrescimo_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Acrescimo_Item_Nacional.Location = New System.Drawing.Point(317, 95)
        Me.lbl_Percentual_Acrescimo_Item_Nacional.Name = "lbl_Percentual_Acrescimo_Item_Nacional"
        Me.lbl_Percentual_Acrescimo_Item_Nacional.Size = New System.Drawing.Size(130, 13)
        Me.lbl_Percentual_Acrescimo_Item_Nacional.TabIndex = 21
        Me.lbl_Percentual_Acrescimo_Item_Nacional.Text = "% Acréscimo nacional"
        '
        'nud_Percentual_Acrescimo_Item_Nacional
        '
        Me.nud_Percentual_Acrescimo_Item_Nacional.DecimalPlaces = 2
        Me.nud_Percentual_Acrescimo_Item_Nacional.Enabled = False
        Me.nud_Percentual_Acrescimo_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Acrescimo_Item_Nacional.InterceptArrowKeys = False
        Me.nud_Percentual_Acrescimo_Item_Nacional.Location = New System.Drawing.Point(574, 91)
        Me.nud_Percentual_Acrescimo_Item_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Acrescimo_Item_Nacional.Name = "nud_Percentual_Acrescimo_Item_Nacional"
        Me.nud_Percentual_Acrescimo_Item_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Acrescimo_Item_Nacional.TabIndex = 22
        '
        'lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional
        '
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.AutoSize = True
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.Location = New System.Drawing.Point(13, 95)
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.Name = "lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional"
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.Size = New System.Drawing.Size(208, 13)
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.TabIndex = 19
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional.Text = "% Lucro necessário outros nacional"
        '
        'nud_Percentual_Lucro_Necessario_Item_Outros_Nacional
        '
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.DecimalPlaces = 2
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Enabled = False
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.InterceptArrowKeys = False
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Location = New System.Drawing.Point(232, 91)
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Name = "nud_Percentual_Lucro_Necessario_Item_Outros_Nacional"
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional.TabIndex = 20
        '
        'lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional
        '
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.AutoSize = True
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Location = New System.Drawing.Point(317, 67)
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Name = "lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional"
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Size = New System.Drawing.Size(239, 13)
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.TabIndex = 17
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Text = "% Lucro necessário revenda ST nacional"
        '
        'nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional
        '
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.DecimalPlaces = 2
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Enabled = False
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.InterceptArrowKeys = False
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Location = New System.Drawing.Point(574, 63)
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Name = "nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional"
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional.TabIndex = 18
        '
        'lbl_Rateio_Despesa_Fixa_Item_Nacional
        '
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.AutoSize = True
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.Location = New System.Drawing.Point(13, 67)
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.Name = "lbl_Rateio_Despesa_Fixa_Item_Nacional"
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.Size = New System.Drawing.Size(184, 13)
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.TabIndex = 15
        Me.lbl_Rateio_Despesa_Fixa_Item_Nacional.Text = "% Rateio despesa fixa nacional"
        '
        'nud_Rateio_Despesa_Fixa_Item_Nacional
        '
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.DecimalPlaces = 2
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.Enabled = False
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.InterceptArrowKeys = False
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.Location = New System.Drawing.Point(232, 63)
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.Name = "nud_Rateio_Despesa_Fixa_Item_Nacional"
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Rateio_Despesa_Fixa_Item_Nacional.TabIndex = 16
        '
        'lbl_Impostos_Federais_Item_Nacional
        '
        Me.lbl_Impostos_Federais_Item_Nacional.AutoSize = True
        Me.lbl_Impostos_Federais_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Impostos_Federais_Item_Nacional.Location = New System.Drawing.Point(317, 39)
        Me.lbl_Impostos_Federais_Item_Nacional.Name = "lbl_Impostos_Federais_Item_Nacional"
        Me.lbl_Impostos_Federais_Item_Nacional.Size = New System.Drawing.Size(171, 13)
        Me.lbl_Impostos_Federais_Item_Nacional.TabIndex = 13
        Me.lbl_Impostos_Federais_Item_Nacional.Text = "% Impostos federais nacional"
        '
        'nud_Impostos_Federais_Item_Nacional
        '
        Me.nud_Impostos_Federais_Item_Nacional.DecimalPlaces = 2
        Me.nud_Impostos_Federais_Item_Nacional.Enabled = False
        Me.nud_Impostos_Federais_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Impostos_Federais_Item_Nacional.InterceptArrowKeys = False
        Me.nud_Impostos_Federais_Item_Nacional.Location = New System.Drawing.Point(574, 35)
        Me.nud_Impostos_Federais_Item_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Impostos_Federais_Item_Nacional.Name = "nud_Impostos_Federais_Item_Nacional"
        Me.nud_Impostos_Federais_Item_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Impostos_Federais_Item_Nacional.TabIndex = 14
        '
        'lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional
        '
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.AutoSize = True
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Location = New System.Drawing.Point(13, 39)
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Name = "lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional"
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Size = New System.Drawing.Size(197, 13)
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.TabIndex = 11
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Text = "% Alíquota interna ICMS nacional"
        '
        'nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional
        '
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.DecimalPlaces = 2
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Enabled = False
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.InterceptArrowKeys = False
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Location = New System.Drawing.Point(232, 35)
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Name = "nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional"
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional.TabIndex = 12
        '
        'lbl_Percentual_MVA_Item_Nacional
        '
        Me.lbl_Percentual_MVA_Item_Nacional.AutoSize = True
        Me.lbl_Percentual_MVA_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_MVA_Item_Nacional.Location = New System.Drawing.Point(317, 12)
        Me.lbl_Percentual_MVA_Item_Nacional.Name = "lbl_Percentual_MVA_Item_Nacional"
        Me.lbl_Percentual_MVA_Item_Nacional.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Percentual_MVA_Item_Nacional.TabIndex = 9
        Me.lbl_Percentual_MVA_Item_Nacional.Text = "% MVA nacional"
        '
        'nud_Percentual_MVA_Item_Nacional
        '
        Me.nud_Percentual_MVA_Item_Nacional.DecimalPlaces = 2
        Me.nud_Percentual_MVA_Item_Nacional.Enabled = False
        Me.nud_Percentual_MVA_Item_Nacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_MVA_Item_Nacional.InterceptArrowKeys = False
        Me.nud_Percentual_MVA_Item_Nacional.Location = New System.Drawing.Point(574, 8)
        Me.nud_Percentual_MVA_Item_Nacional.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_MVA_Item_Nacional.Name = "nud_Percentual_MVA_Item_Nacional"
        Me.nud_Percentual_MVA_Item_Nacional.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_MVA_Item_Nacional.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.lbl_Percentual_Acrescimo_Item_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Percentual_Acrescimo_Item_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Rateio_Despesa_Fixa_Item_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Rateio_Despesa_Fixa_Item_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Impostos_Federais_Item_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Impostos_Federais_Item_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Percentual_MVA_Item_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Percentual_MVA_Item_Importado)
        Me.TabPage2.Controls.Add(Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado)
        Me.TabPage2.Controls.Add(Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(663, 124)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Taxas importadas"
        '
        'lbl_Percentual_Acrescimo_Item_Importado
        '
        Me.lbl_Percentual_Acrescimo_Item_Importado.AutoSize = True
        Me.lbl_Percentual_Acrescimo_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Acrescimo_Item_Importado.Location = New System.Drawing.Point(317, 95)
        Me.lbl_Percentual_Acrescimo_Item_Importado.Name = "lbl_Percentual_Acrescimo_Item_Importado"
        Me.lbl_Percentual_Acrescimo_Item_Importado.Size = New System.Drawing.Size(137, 13)
        Me.lbl_Percentual_Acrescimo_Item_Importado.TabIndex = 37
        Me.lbl_Percentual_Acrescimo_Item_Importado.Text = "% Acréscimo importado"
        '
        'nud_Percentual_Acrescimo_Item_Importado
        '
        Me.nud_Percentual_Acrescimo_Item_Importado.DecimalPlaces = 2
        Me.nud_Percentual_Acrescimo_Item_Importado.Enabled = False
        Me.nud_Percentual_Acrescimo_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Acrescimo_Item_Importado.InterceptArrowKeys = False
        Me.nud_Percentual_Acrescimo_Item_Importado.Location = New System.Drawing.Point(574, 91)
        Me.nud_Percentual_Acrescimo_Item_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Acrescimo_Item_Importado.Name = "nud_Percentual_Acrescimo_Item_Importado"
        Me.nud_Percentual_Acrescimo_Item_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Acrescimo_Item_Importado.TabIndex = 38
        '
        'lbl_Percentual_Lucro_Necessario_Item_Outros_Importado
        '
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.AutoSize = True
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.Location = New System.Drawing.Point(13, 95)
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.Name = "lbl_Percentual_Lucro_Necessario_Item_Outros_Importado"
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.Size = New System.Drawing.Size(215, 13)
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.TabIndex = 35
        Me.lbl_Percentual_Lucro_Necessario_Item_Outros_Importado.Text = "% Lucro necessário outros importado"
        '
        'nud_Percentual_Lucro_Necessario_Item_Outros_Importado
        '
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.DecimalPlaces = 2
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Enabled = False
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.InterceptArrowKeys = False
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Location = New System.Drawing.Point(232, 91)
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Name = "nud_Percentual_Lucro_Necessario_Item_Outros_Importado"
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado.TabIndex = 36
        '
        'lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado
        '
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.AutoSize = True
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Location = New System.Drawing.Point(317, 67)
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Name = "lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado"
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Size = New System.Drawing.Size(246, 13)
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.TabIndex = 33
        Me.lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Text = "% Lucro necessário revenda ST importado"
        '
        'nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado
        '
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.DecimalPlaces = 2
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Enabled = False
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.InterceptArrowKeys = False
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Location = New System.Drawing.Point(574, 63)
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Name = "nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado"
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado.TabIndex = 34
        '
        'lbl_Rateio_Despesa_Fixa_Item_Importado
        '
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.AutoSize = True
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.Location = New System.Drawing.Point(13, 67)
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.Name = "lbl_Rateio_Despesa_Fixa_Item_Importado"
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.Size = New System.Drawing.Size(191, 13)
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.TabIndex = 31
        Me.lbl_Rateio_Despesa_Fixa_Item_Importado.Text = "% Rateio despesa fixa importado"
        '
        'nud_Rateio_Despesa_Fixa_Item_Importado
        '
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.DecimalPlaces = 2
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.Enabled = False
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.InterceptArrowKeys = False
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.Location = New System.Drawing.Point(232, 63)
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.Name = "nud_Rateio_Despesa_Fixa_Item_Importado"
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Rateio_Despesa_Fixa_Item_Importado.TabIndex = 32
        '
        'lbl_Impostos_Federais_Item_Importado
        '
        Me.lbl_Impostos_Federais_Item_Importado.AutoSize = True
        Me.lbl_Impostos_Federais_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Impostos_Federais_Item_Importado.Location = New System.Drawing.Point(317, 39)
        Me.lbl_Impostos_Federais_Item_Importado.Name = "lbl_Impostos_Federais_Item_Importado"
        Me.lbl_Impostos_Federais_Item_Importado.Size = New System.Drawing.Size(178, 13)
        Me.lbl_Impostos_Federais_Item_Importado.TabIndex = 29
        Me.lbl_Impostos_Federais_Item_Importado.Text = "% Impostos federais importado"
        '
        'nud_Impostos_Federais_Item_Importado
        '
        Me.nud_Impostos_Federais_Item_Importado.DecimalPlaces = 2
        Me.nud_Impostos_Federais_Item_Importado.Enabled = False
        Me.nud_Impostos_Federais_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Impostos_Federais_Item_Importado.InterceptArrowKeys = False
        Me.nud_Impostos_Federais_Item_Importado.Location = New System.Drawing.Point(574, 35)
        Me.nud_Impostos_Federais_Item_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Impostos_Federais_Item_Importado.Name = "nud_Impostos_Federais_Item_Importado"
        Me.nud_Impostos_Federais_Item_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Impostos_Federais_Item_Importado.TabIndex = 30
        '
        'lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado
        '
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.AutoSize = True
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.Location = New System.Drawing.Point(13, 39)
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.Name = "lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado"
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.Size = New System.Drawing.Size(204, 13)
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.TabIndex = 27
        Me.lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado.Text = "% Alíquota interna ICMS importado"
        '
        'nud_Percentual_Aliquota_Interna_ICMS_Item_Importado
        '
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.DecimalPlaces = 2
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Enabled = False
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.InterceptArrowKeys = False
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Location = New System.Drawing.Point(232, 35)
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Name = "nud_Percentual_Aliquota_Interna_ICMS_Item_Importado"
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado.TabIndex = 28
        '
        'lbl_Percentual_MVA_Item_Importado
        '
        Me.lbl_Percentual_MVA_Item_Importado.AutoSize = True
        Me.lbl_Percentual_MVA_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_MVA_Item_Importado.Location = New System.Drawing.Point(317, 12)
        Me.lbl_Percentual_MVA_Item_Importado.Name = "lbl_Percentual_MVA_Item_Importado"
        Me.lbl_Percentual_MVA_Item_Importado.Size = New System.Drawing.Size(105, 13)
        Me.lbl_Percentual_MVA_Item_Importado.TabIndex = 25
        Me.lbl_Percentual_MVA_Item_Importado.Text = "% MVA importado"
        '
        'nud_Percentual_MVA_Item_Importado
        '
        Me.nud_Percentual_MVA_Item_Importado.DecimalPlaces = 2
        Me.nud_Percentual_MVA_Item_Importado.Enabled = False
        Me.nud_Percentual_MVA_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_MVA_Item_Importado.InterceptArrowKeys = False
        Me.nud_Percentual_MVA_Item_Importado.Location = New System.Drawing.Point(574, 8)
        Me.nud_Percentual_MVA_Item_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_MVA_Item_Importado.Name = "nud_Percentual_MVA_Item_Importado"
        Me.nud_Percentual_MVA_Item_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_MVA_Item_Importado.TabIndex = 26
        '
        'lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado
        '
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.AutoSize = True
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.Location = New System.Drawing.Point(13, 12)
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.Name = "lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado"
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.Size = New System.Drawing.Size(207, 13)
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.TabIndex = 23
        Me.lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado.Text = "% Alíquota externa ICMS importado"
        '
        'nud_Percentual_Aliquota_Externa_ICMS_Item_Importado
        '
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.DecimalPlaces = 2
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Enabled = False
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.InterceptArrowKeys = False
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Location = New System.Drawing.Point(232, 8)
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Name = "nud_Percentual_Aliquota_Externa_ICMS_Item_Importado"
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.Size = New System.Drawing.Size(76, 20)
        Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado.TabIndex = 24
        '
        'dtp_Data_Fim
        '
        Me.dtp_Data_Fim.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Data_Fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Data_Fim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Data_Fim.Location = New System.Drawing.Point(121, 50)
        Me.dtp_Data_Fim.Name = "dtp_Data_Fim"
        Me.dtp_Data_Fim.Size = New System.Drawing.Size(97, 20)
        Me.dtp_Data_Fim.TabIndex = 88
        Me.dtp_Data_Fim.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.ImageKey = "remove-button.png"
        Me.btn_Cancelar.ImageList = Me.img_List_16x16
        Me.btn_Cancelar.Location = New System.Drawing.Point(247, 471)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cancelar.TabIndex = 80
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
        Me.btn_Salvar.Location = New System.Drawing.Point(355, 471)
        Me.btn_Salvar.Name = "btn_Salvar"
        Me.btn_Salvar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Salvar.TabIndex = 81
        Me.btn_Salvar.Text = "  Salvar"
        Me.btn_Salvar.UseVisualStyleBackColor = True
        '
        'Taxas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 509)
        Me.Controls.Add(Me.dtp_Data_Fim)
        Me.Controls.Add(Me.tbc_Taxas)
        Me.Controls.Add(Me.mns_Menu)
        Me.Controls.Add(Me.txt_Nome)
        Me.Controls.Add(Me.lbl_Nome)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Salvar)
        Me.Controls.Add(Me.txt_id_taxa)
        Me.Controls.Add(Me.grp_Itens)
        Me.Controls.Add(Me.lbl_Data_Fim)
        Me.Controls.Add(Me.lbl_Data_Inicio)
        Me.Controls.Add(Me.dtp_Data_Inicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Taxas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taxas"
        CType(Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Itens.ResumeLayout(False)
        CType(Me.dtg_Itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mns_Menu.ResumeLayout(False)
        Me.mns_Menu.PerformLayout()
        Me.tbc_Taxas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.nud_Percentual_Acrescimo_Item_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Outros_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Rateio_Despesa_Fixa_Item_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Impostos_Federais_Item_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_MVA_Item_Nacional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nud_Percentual_Acrescimo_Item_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Outros_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Rateio_Despesa_Fixa_Item_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Impostos_Federais_Item_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Aliquota_Interna_ICMS_Item_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_MVA_Item_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Percentual_Aliquota_Externa_ICMS_Item_Importado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nud_Percentual_Aliquota_Externa_ICMS_Item_Nacional As NumericUpDown
    Friend WithEvents lbl_Percentual_Aliquota_Externa_ICMS_Item_Nacional As Label
    Friend WithEvents dtp_Data_Inicio As DateTimePicker
    Friend WithEvents lbl_Data_Inicio As Label
    Friend WithEvents lbl_Data_Fim As Label
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Salvar As Button
    Friend WithEvents txt_id_taxa As TextBox
    Friend WithEvents grp_Itens As GroupBox
    Friend WithEvents dtg_Itens As DataGridView
    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents lbl_Nome As Label
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents mns_Menu As MenuStrip
    Friend WithEvents mnsi_Adicionar As ToolStripMenuItem
    Friend WithEvents mnsi_Editar As ToolStripMenuItem
    Friend WithEvents mnsi_Excluir As ToolStripMenuItem
    Friend WithEvents tbc_Taxas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbl_Percentual_Acrescimo_Item_Nacional As Label
    Friend WithEvents nud_Percentual_Acrescimo_Item_Nacional As NumericUpDown
    Friend WithEvents lbl_Percentual_Lucro_Necessario_Item_Outros_Nacional As Label
    Friend WithEvents nud_Percentual_Lucro_Necessario_Item_Outros_Nacional As NumericUpDown
    Friend WithEvents lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional As Label
    Friend WithEvents nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Nacional As NumericUpDown
    Friend WithEvents lbl_Rateio_Despesa_Fixa_Item_Nacional As Label
    Friend WithEvents nud_Rateio_Despesa_Fixa_Item_Nacional As NumericUpDown
    Friend WithEvents lbl_Impostos_Federais_Item_Nacional As Label
    Friend WithEvents nud_Impostos_Federais_Item_Nacional As NumericUpDown
    Friend WithEvents lbl_Percentual_Aliquota_Interna_ICMS_Item_Nacional As Label
    Friend WithEvents nud_Percentual_Aliquota_Interna_ICMS_Item_Nacional As NumericUpDown
    Friend WithEvents lbl_Percentual_MVA_Item_Nacional As Label
    Friend WithEvents nud_Percentual_MVA_Item_Nacional As NumericUpDown
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_Percentual_Acrescimo_Item_Importado As Label
    Friend WithEvents nud_Percentual_Acrescimo_Item_Importado As NumericUpDown
    Friend WithEvents lbl_Percentual_Lucro_Necessario_Item_Outros_Importado As Label
    Friend WithEvents nud_Percentual_Lucro_Necessario_Item_Outros_Importado As NumericUpDown
    Friend WithEvents lbl_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado As Label
    Friend WithEvents nud_Percentual_Lucro_Necessario_Item_Revenda_ST_Importado As NumericUpDown
    Friend WithEvents lbl_Rateio_Despesa_Fixa_Item_Importado As Label
    Friend WithEvents nud_Rateio_Despesa_Fixa_Item_Importado As NumericUpDown
    Friend WithEvents lbl_Impostos_Federais_Item_Importado As Label
    Friend WithEvents nud_Impostos_Federais_Item_Importado As NumericUpDown
    Friend WithEvents lbl_Percentual_Aliquota_Interna_ICMS_Item_Importado As Label
    Friend WithEvents nud_Percentual_Aliquota_Interna_ICMS_Item_Importado As NumericUpDown
    Friend WithEvents lbl_Percentual_MVA_Item_Importado As Label
    Friend WithEvents nud_Percentual_MVA_Item_Importado As NumericUpDown
    Friend WithEvents lbl_Percentual_Aliquota_Externa_ICMS_Item_Importado As Label
    Friend WithEvents nud_Percentual_Aliquota_Externa_ICMS_Item_Importado As NumericUpDown
    Friend WithEvents dtp_Data_Fim As DateTimePicker
End Class
