﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastrar_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastrar_Usuario))
        Me.mkt_Telefone = New System.Windows.Forms.MaskedTextBox()
        Me.mkt_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Login = New System.Windows.Forms.TextBox()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Telefone = New System.Windows.Forms.Label()
        Me.lbl_CPF = New System.Windows.Forms.Label()
        Me.lbl_Sexo = New System.Windows.Forms.Label()
        Me.rdo_Sexo_2 = New System.Windows.Forms.RadioButton()
        Me.rdo_Sexo_1 = New System.Windows.Forms.RadioButton()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.lbl_Nome = New System.Windows.Forms.Label()
        Me.txt_Senha = New System.Windows.Forms.TextBox()
        Me.lbl_Senha = New System.Windows.Forms.Label()
        Me.lbl_Setor = New System.Windows.Forms.Label()
        Me.cbo_Setor = New System.Windows.Forms.ComboBox()
        Me.cbo_Filial = New System.Windows.Forms.ComboBox()
        Me.lbl_Filial = New System.Windows.Forms.Label()
        Me.cbo_Perfil = New System.Windows.Forms.ComboBox()
        Me.lbl_Perfil = New System.Windows.Forms.Label()
        Me.img_List_16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.img_List_32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_Confirmacao_Senha = New System.Windows.Forms.TextBox()
        Me.lbl_Confirmacao_Senha = New System.Windows.Forms.Label()
        Me.lbl_Imagem_Usuario = New System.Windows.Forms.Label()
        Me.btn_Selecionar_Imagem = New System.Windows.Forms.Button()
        Me.ptb_Imagem_Usuario = New System.Windows.Forms.PictureBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Esconder_Senha = New System.Windows.Forms.Button()
        Me.btn_Cadastrar = New System.Windows.Forms.Button()
        Me.pnl_Sexo = New System.Windows.Forms.Panel()
        Me.btn_Esconder_Confirmacao_Senha = New System.Windows.Forms.Button()
        Me.btn_Mostrar_Senha = New System.Windows.Forms.Button()
        Me.btn_Mostrar_Confirmacao_Senha = New System.Windows.Forms.Button()
        Me.ttp_Dica = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_File_Path = New System.Windows.Forms.TextBox()
        Me.cbo_Status = New System.Windows.Forms.ComboBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        CType(Me.ptb_Imagem_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Sexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mkt_Telefone
        '
        Me.mkt_Telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkt_Telefone.Location = New System.Drawing.Point(470, 87)
        Me.mkt_Telefone.Mask = "(00) 00000-0000"
        Me.mkt_Telefone.Name = "mkt_Telefone"
        Me.mkt_Telefone.Size = New System.Drawing.Size(100, 20)
        Me.mkt_Telefone.TabIndex = 11
        '
        'mkt_CPF
        '
        Me.mkt_CPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkt_CPF.Location = New System.Drawing.Point(393, 38)
        Me.mkt_CPF.Mask = "000.000.000-00"
        Me.mkt_CPF.Name = "mkt_CPF"
        Me.mkt_CPF.Size = New System.Drawing.Size(100, 20)
        Me.mkt_CPF.TabIndex = 5
        '
        'txt_Login
        '
        Me.txt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Login.Location = New System.Drawing.Point(153, 87)
        Me.txt_Login.MaxLength = 30
        Me.txt_Login.Name = "txt_Login"
        Me.txt_Login.Size = New System.Drawing.Size(115, 20)
        Me.txt_Login.TabIndex = 9
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.Location = New System.Drawing.Point(150, 71)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Login.TabIndex = 6
        Me.lbl_Login.Text = "Login"
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(274, 87)
        Me.txt_Email.MaxLength = 60
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(190, 20)
        Me.txt_Email.TabIndex = 10
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.Location = New System.Drawing.Point(271, 71)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Email.TabIndex = 7
        Me.lbl_Email.Text = "E-mail"
        '
        'lbl_Telefone
        '
        Me.lbl_Telefone.AutoSize = True
        Me.lbl_Telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telefone.Location = New System.Drawing.Point(467, 71)
        Me.lbl_Telefone.Name = "lbl_Telefone"
        Me.lbl_Telefone.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Telefone.TabIndex = 8
        Me.lbl_Telefone.Text = "Telefone"
        '
        'lbl_CPF
        '
        Me.lbl_CPF.AutoSize = True
        Me.lbl_CPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CPF.Location = New System.Drawing.Point(390, 21)
        Me.lbl_CPF.Name = "lbl_CPF"
        Me.lbl_CPF.Size = New System.Drawing.Size(30, 13)
        Me.lbl_CPF.TabIndex = 2
        Me.lbl_CPF.Text = "CPF"
        '
        'lbl_Sexo
        '
        Me.lbl_Sexo.AutoSize = True
        Me.lbl_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sexo.Location = New System.Drawing.Point(495, 23)
        Me.lbl_Sexo.Name = "lbl_Sexo"
        Me.lbl_Sexo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Sexo.TabIndex = 3
        Me.lbl_Sexo.Text = "Sexo"
        '
        'rdo_Sexo_2
        '
        Me.rdo_Sexo_2.AutoSize = True
        Me.rdo_Sexo_2.Location = New System.Drawing.Point(42, 3)
        Me.rdo_Sexo_2.Name = "rdo_Sexo_2"
        Me.rdo_Sexo_2.Size = New System.Drawing.Size(31, 17)
        Me.rdo_Sexo_2.TabIndex = 0
        Me.rdo_Sexo_2.TabStop = True
        Me.rdo_Sexo_2.Text = "F"
        Me.rdo_Sexo_2.UseVisualStyleBackColor = True
        '
        'rdo_Sexo_1
        '
        Me.rdo_Sexo_1.AutoSize = True
        Me.rdo_Sexo_1.Location = New System.Drawing.Point(3, 3)
        Me.rdo_Sexo_1.Name = "rdo_Sexo_1"
        Me.rdo_Sexo_1.Size = New System.Drawing.Size(34, 17)
        Me.rdo_Sexo_1.TabIndex = 1
        Me.rdo_Sexo_1.TabStop = True
        Me.rdo_Sexo_1.Text = "M"
        Me.rdo_Sexo_1.UseVisualStyleBackColor = True
        '
        'txt_Nome
        '
        Me.txt_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nome.Location = New System.Drawing.Point(153, 38)
        Me.txt_Nome.MaxLength = 60
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(234, 20)
        Me.txt_Nome.TabIndex = 4
        '
        'lbl_Nome
        '
        Me.lbl_Nome.AutoSize = True
        Me.lbl_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nome.Location = New System.Drawing.Point(150, 22)
        Me.lbl_Nome.Name = "lbl_Nome"
        Me.lbl_Nome.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Nome.TabIndex = 1
        Me.lbl_Nome.Text = "Nome"
        '
        'txt_Senha
        '
        Me.txt_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Senha.Location = New System.Drawing.Point(269, 177)
        Me.txt_Senha.MaxLength = 255
        Me.txt_Senha.Name = "txt_Senha"
        Me.txt_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Senha.Size = New System.Drawing.Size(115, 20)
        Me.txt_Senha.TabIndex = 21
        Me.ttp_Dica.SetToolTip(Me.txt_Senha, "A senha deve possuir:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pelo menos 8 caracteres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 letra maiúscula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 letra minú" &
        "scula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 caractere especial")
        '
        'lbl_Senha
        '
        Me.lbl_Senha.AutoSize = True
        Me.lbl_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Senha.Location = New System.Drawing.Point(266, 161)
        Me.lbl_Senha.Name = "lbl_Senha"
        Me.lbl_Senha.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Senha.TabIndex = 19
        Me.lbl_Senha.Text = "Senha"
        '
        'lbl_Setor
        '
        Me.lbl_Setor.AutoSize = True
        Me.lbl_Setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Setor.Location = New System.Drawing.Point(291, 114)
        Me.lbl_Setor.Name = "lbl_Setor"
        Me.lbl_Setor.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Setor.TabIndex = 14
        Me.lbl_Setor.Text = "Setor"
        '
        'cbo_Setor
        '
        Me.cbo_Setor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Setor.FormattingEnabled = True
        Me.cbo_Setor.Location = New System.Drawing.Point(294, 130)
        Me.cbo_Setor.Name = "cbo_Setor"
        Me.cbo_Setor.Size = New System.Drawing.Size(135, 21)
        Me.cbo_Setor.TabIndex = 17
        '
        'cbo_Filial
        '
        Me.cbo_Filial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Filial.FormattingEnabled = True
        Me.cbo_Filial.Location = New System.Drawing.Point(153, 130)
        Me.cbo_Filial.Name = "cbo_Filial"
        Me.cbo_Filial.Size = New System.Drawing.Size(135, 21)
        Me.cbo_Filial.TabIndex = 15
        '
        'lbl_Filial
        '
        Me.lbl_Filial.AutoSize = True
        Me.lbl_Filial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Filial.Location = New System.Drawing.Point(150, 114)
        Me.lbl_Filial.Name = "lbl_Filial"
        Me.lbl_Filial.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Filial.TabIndex = 12
        Me.lbl_Filial.Text = "Filial"
        '
        'cbo_Perfil
        '
        Me.cbo_Perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Perfil.FormattingEnabled = True
        Me.cbo_Perfil.Location = New System.Drawing.Point(437, 130)
        Me.cbo_Perfil.Name = "cbo_Perfil"
        Me.cbo_Perfil.Size = New System.Drawing.Size(135, 21)
        Me.cbo_Perfil.TabIndex = 16
        '
        'lbl_Perfil
        '
        Me.lbl_Perfil.AutoSize = True
        Me.lbl_Perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Perfil.Location = New System.Drawing.Point(434, 114)
        Me.lbl_Perfil.Name = "lbl_Perfil"
        Me.lbl_Perfil.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Perfil.TabIndex = 13
        Me.lbl_Perfil.Text = "Perfil"
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
        'img_List_32x32
        '
        Me.img_List_32x32.ImageStream = CType(resources.GetObject("img_List_32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_List_32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.img_List_32x32.Images.SetKeyName(0, "add-square-button.png")
        Me.img_List_32x32.Images.SetKeyName(1, "adjust-contrast.png")
        Me.img_List_32x32.Images.SetKeyName(2, "align-justify.png")
        Me.img_List_32x32.Images.SetKeyName(3, "align-to-left.png")
        Me.img_List_32x32.Images.SetKeyName(4, "align-to-right.png")
        Me.img_List_32x32.Images.SetKeyName(5, "ambulance.png")
        Me.img_List_32x32.Images.SetKeyName(6, "anchor-shape.png")
        Me.img_List_32x32.Images.SetKeyName(7, "android-character-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(8, "angle-arrow-down.png")
        Me.img_List_32x32.Images.SetKeyName(9, "angle-arrow-pointing-to-right.png")
        Me.img_List_32x32.Images.SetKeyName(10, "angle-pointing-to-left.png")
        Me.img_List_32x32.Images.SetKeyName(11, "apple-logo.png")
        Me.img_List_32x32.Images.SetKeyName(12, "archive-black-box.png")
        Me.img_List_32x32.Images.SetKeyName(13, "arrow-angle-pointing-down.png")
        Me.img_List_32x32.Images.SetKeyName(14, "arrow-down-on-black-circular-background.png")
        Me.img_List_32x32.Images.SetKeyName(15, "arrowhead-pointing-to-the-right.png")
        Me.img_List_32x32.Images.SetKeyName(16, "arrowhead-pointing-up-inside-a-square-box-outline.png")
        Me.img_List_32x32.Images.SetKeyName(17, "arrowheads-pointing-to-the-left.png")
        Me.img_List_32x32.Images.SetKeyName(18, "arrow-pointing-down.png")
        Me.img_List_32x32.Images.SetKeyName(19, "arrow-pointing-right-in-a-circle.png")
        Me.img_List_32x32.Images.SetKeyName(20, "arrow-pointing-to-left.png")
        Me.img_List_32x32.Images.SetKeyName(21, "arrow-pointing-to-right.png")
        Me.img_List_32x32.Images.SetKeyName(22, "arrow-up.png")
        Me.img_List_32x32.Images.SetKeyName(23, "arrow-up-on-a-black-circle-background.png")
        Me.img_List_32x32.Images.SetKeyName(24, "asterisk.png")
        Me.img_List_32x32.Images.SetKeyName(25, "ban-circle-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(26, "barcode.png")
        Me.img_List_32x32.Images.SetKeyName(27, "bar-graph-on-a-rectangle.png")
        Me.img_List_32x32.Images.SetKeyName(28, "beaker.png")
        Me.img_List_32x32.Images.SetKeyName(29, "beer-jar-black-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(30, "bell-musical-tool.png")
        Me.img_List_32x32.Images.SetKeyName(31, "bitbucket-logotype-camera-lens-in-perspective.png")
        Me.img_List_32x32.Images.SetKeyName(32, "bitbucket-sign.png")
        Me.img_List_32x32.Images.SetKeyName(33, "bitcoin-logo.png")
        Me.img_List_32x32.Images.SetKeyName(34, "blank-file.png")
        Me.img_List_32x32.Images.SetKeyName(35, "bold-text-option.png")
        Me.img_List_32x32.Images.SetKeyName(36, "book.png")
        Me.img_List_32x32.Images.SetKeyName(37, "bookmark-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(38, "bookmark-white.png")
        Me.img_List_32x32.Images.SetKeyName(39, "branch-with-leaves-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(40, "briefcase.png")
        Me.img_List_32x32.Images.SetKeyName(41, "bug.png")
        Me.img_List_32x32.Images.SetKeyName(42, "building-front.png")
        Me.img_List_32x32.Images.SetKeyName(43, "bull-horn-announcer.png")
        Me.img_List_32x32.Images.SetKeyName(44, "bullseye.png")
        Me.img_List_32x32.Images.SetKeyName(45, "calendar-page-empty.png")
        Me.img_List_32x32.Images.SetKeyName(46, "calendar-with-spring-binder-and-date-blocks.png")
        Me.img_List_32x32.Images.SetKeyName(47, "camera-retro.png")
        Me.img_List_32x32.Images.SetKeyName(48, "caret-arrow-up.png")
        Me.img_List_32x32.Images.SetKeyName(49, "caret-down.png")
        Me.img_List_32x32.Images.SetKeyName(50, "center-text-alignment.png")
        Me.img_List_32x32.Images.SetKeyName(51, "certificate-shape.png")
        Me.img_List_32x32.Images.SetKeyName(52, "check.png")
        Me.img_List_32x32.Images.SetKeyName(53, "check-box-empty.png")
        Me.img_List_32x32.Images.SetKeyName(54, "checked-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(55, "checkered-raised-flag.png")
        Me.img_List_32x32.Images.SetKeyName(56, "check-mark.png")
        Me.img_List_32x32.Images.SetKeyName(57, "check-sign-in-a-rounded-black-square.png")
        Me.img_List_32x32.Images.SetKeyName(58, "chevron-arrow-down.png")
        Me.img_List_32x32.Images.SetKeyName(59, "chevron-arrow-up.png")
        Me.img_List_32x32.Images.SetKeyName(60, "chevron-pointing-to-the-left.png")
        Me.img_List_32x32.Images.SetKeyName(61, "chevron-sign-down.png")
        Me.img_List_32x32.Images.SetKeyName(62, "chevron-sign-left.png")
        Me.img_List_32x32.Images.SetKeyName(63, "chevron-sign-to-right.png")
        Me.img_List_32x32.Images.SetKeyName(64, "chevron-up.png")
        Me.img_List_32x32.Images.SetKeyName(65, "circle-shape-outline.png")
        Me.img_List_32x32.Images.SetKeyName(66, "circle-with-an-arrow-pointing-to-left.png")
        Me.img_List_32x32.Images.SetKeyName(67, "circular-shape-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(68, "cloud-storage-download.png")
        Me.img_List_32x32.Images.SetKeyName(69, "cloud-storage-uploading-option.png")
        Me.img_List_32x32.Images.SetKeyName(70, "cocktail-glass.png")
        Me.img_List_32x32.Images.SetKeyName(71, "code.png")
        Me.img_List_32x32.Images.SetKeyName(72, "code-fork-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(73, "coffee-cup-on-a-plate-black-silhouettes.png")
        Me.img_List_32x32.Images.SetKeyName(74, "cog-wheel-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(75, "collapse-window-option.png")
        Me.img_List_32x32.Images.SetKeyName(76, "comment-black-oval-bubble-shape.png")
        Me.img_List_32x32.Images.SetKeyName(77, "comments.png")
        Me.img_List_32x32.Images.SetKeyName(78, "comment-white-oval-bubble.png")
        Me.img_List_32x32.Images.SetKeyName(79, "compass-circular-variant.png")
        Me.img_List_32x32.Images.SetKeyName(80, "computer-tablet.png")
        Me.img_List_32x32.Images.SetKeyName(81, "copy-document.png")
        Me.img_List_32x32.Images.SetKeyName(82, "correct-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(83, "couple-of-arrows-changing-places.png")
        Me.img_List_32x32.Images.SetKeyName(84, "credit-card.png")
        Me.img_List_32x32.Images.SetKeyName(85, "crop-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(86, "cross-mark-on-a-black-circle-background.png")
        Me.img_List_32x32.Images.SetKeyName(87, "css-3-logo.png")
        Me.img_List_32x32.Images.SetKeyName(88, "cursor.png")
        Me.img_List_32x32.Images.SetKeyName(89, "cut.png")
        Me.img_List_32x32.Images.SetKeyName(90, "dashboard.png")
        Me.img_List_32x32.Images.SetKeyName(91, "delivery-truck-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(92, "desktop-monitor.png")
        Me.img_List_32x32.Images.SetKeyName(93, "dollar-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(94, "dot-and-circle.png")
        Me.img_List_32x32.Images.SetKeyName(95, "double-angle-pointing-to-right.png")
        Me.img_List_32x32.Images.SetKeyName(96, "double-left-chevron.png")
        Me.img_List_32x32.Images.SetKeyName(97, "double-sided-eraser.png")
        Me.img_List_32x32.Images.SetKeyName(98, "double-strikethrough-option.png")
        Me.img_List_32x32.Images.SetKeyName(99, "down-arrow.png")
        Me.img_List_32x32.Images.SetKeyName(100, "download-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(101, "download-to-storage-drive.png")
        Me.img_List_32x32.Images.SetKeyName(102, "dribbble-logo.png")
        Me.img_List_32x32.Images.SetKeyName(103, "dropbox-logo.png")
        Me.img_List_32x32.Images.SetKeyName(104, "earth-globe.png")
        Me.img_List_32x32.Images.SetKeyName(105, "edit-interface-sign.png")
        Me.img_List_32x32.Images.SetKeyName(106, "eject-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(107, "envelope.png")
        Me.img_List_32x32.Images.SetKeyName(108, "envelope-of-white-paper.png")
        Me.img_List_32x32.Images.SetKeyName(109, "euro-currency-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(110, "exchange-arrows.png")
        Me.img_List_32x32.Images.SetKeyName(111, "exclamation.png")
        Me.img_List_32x32.Images.SetKeyName(112, "exclamation-sign.png")
        Me.img_List_32x32.Images.SetKeyName(113, "external-link-square-with-an-arrow-in-right-diagonal.png")
        Me.img_List_32x32.Images.SetKeyName(114, "external-link-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(115, "eye-open.png")
        Me.img_List_32x32.Images.SetKeyName(116, "eye-with-a-diagonal-line-interface-symbol-for-invisibility.png")
        Me.img_List_32x32.Images.SetKeyName(117, "facebook-logo.png")
        Me.img_List_32x32.Images.SetKeyName(118, "facebook-logo-1.png")
        Me.img_List_32x32.Images.SetKeyName(119, "facetime-button.png")
        Me.img_List_32x32.Images.SetKeyName(120, "fast-forward-arrows.png")
        Me.img_List_32x32.Images.SetKeyName(121, "female-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(122, "fighter-jet-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(123, "file.png")
        Me.img_List_32x32.Images.SetKeyName(124, "film-strip-with-two-photograms.png")
        Me.img_List_32x32.Images.SetKeyName(125, "filter-tool-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(126, "finger-of-a-hand-pointing-to-right-direction.png")
        Me.img_List_32x32.Images.SetKeyName(127, "fire-extinguisher.png")
        Me.img_List_32x32.Images.SetKeyName(128, "fire-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(129, "flag-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(130, "flickr-website-logo-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(131, "fluffy-cloud-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(132, "folder-closed-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(133, "folder-white-shape.png")
        Me.img_List_32x32.Images.SetKeyName(134, "font-selection-editor.png")
        Me.img_List_32x32.Images.SetKeyName(135, "font-symbol-of-letter-a.png")
        Me.img_List_32x32.Images.SetKeyName(136, "fork-and-knife-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(137, "forward-button.png")
        Me.img_List_32x32.Images.SetKeyName(138, "four-black-squares.png")
        Me.img_List_32x32.Images.SetKeyName(139, "foursquare-button.png")
        Me.img_List_32x32.Images.SetKeyName(140, "frown.png")
        Me.img_List_32x32.Images.SetKeyName(141, "fullscreen-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(142, "gamepad-console.png")
        Me.img_List_32x32.Images.SetKeyName(143, "gift-box.png")
        Me.img_List_32x32.Images.SetKeyName(144, "github-character.png")
        Me.img_List_32x32.Images.SetKeyName(145, "github-logo.png")
        Me.img_List_32x32.Images.SetKeyName(146, "github-sign.png")
        Me.img_List_32x32.Images.SetKeyName(147, "gittip-website-logo.png")
        Me.img_List_32x32.Images.SetKeyName(148, "google-plus-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(149, "google-plus-symbol-1.png")
        Me.img_List_32x32.Images.SetKeyName(150, "great-britain-pound.png")
        Me.img_List_32x32.Images.SetKeyName(151, "group-profile-users.png")
        Me.img_List_32x32.Images.SetKeyName(152, "half-star-shape.png")
        Me.img_List_32x32.Images.SetKeyName(153, "hand-finger-pointing-down.png")
        Me.img_List_32x32.Images.SetKeyName(154, "hand-pointing-to-left-direction.png")
        Me.img_List_32x32.Images.SetKeyName(155, "hand-pointing-upward.png")
        Me.img_List_32x32.Images.SetKeyName(156, "hard-drive.png")
        Me.img_List_32x32.Images.SetKeyName(157, "heart-shape-outline.png")
        Me.img_List_32x32.Images.SetKeyName(158, "heart-shape-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(159, "home.png")
        Me.img_List_32x32.Images.SetKeyName(160, "horizontal-resize-option.png")
        Me.img_List_32x32.Images.SetKeyName(161, "hostpital-building.png")
        Me.img_List_32x32.Images.SetKeyName(162, "hotel-letter-h-sign-inside-a-black-rounded-square.png")
        Me.img_List_32x32.Images.SetKeyName(163, "html-5-logo.png")
        Me.img_List_32x32.Images.SetKeyName(164, "inbox.png")
        Me.img_List_32x32.Images.SetKeyName(165, "increase-size-option.png")
        Me.img_List_32x32.Images.SetKeyName(166, "indent-right.png")
        Me.img_List_32x32.Images.SetKeyName(167, "information-button.png")
        Me.img_List_32x32.Images.SetKeyName(168, "information-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(169, "instagram-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(170, "italicize-text.png")
        Me.img_List_32x32.Images.SetKeyName(171, "keyboard.png")
        Me.img_List_32x32.Images.SetKeyName(172, "left-arrow.png")
        Me.img_List_32x32.Images.SetKeyName(173, "left-arrow-1.png")
        Me.img_List_32x32.Images.SetKeyName(174, "left-indentation-option.png")
        Me.img_List_32x32.Images.SetKeyName(175, "legal-hammer.png")
        Me.img_List_32x32.Images.SetKeyName(176, "lemon.png")
        Me.img_List_32x32.Images.SetKeyName(177, "leter-a-inside-a-black-circle.png")
        Me.img_List_32x32.Images.SetKeyName(178, "letter-p-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(179, "level-up.png")
        Me.img_List_32x32.Images.SetKeyName(180, "light-bulb.png")
        Me.img_List_32x32.Images.SetKeyName(181, "lightning-bolt-shadow.png")
        Me.img_List_32x32.Images.SetKeyName(182, "linkedin-letters.png")
        Me.img_List_32x32.Images.SetKeyName(183, "linkedin-sign.png")
        Me.img_List_32x32.Images.SetKeyName(184, "link-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(185, "linux-logo.png")
        Me.img_List_32x32.Images.SetKeyName(186, "list.png")
        Me.img_List_32x32.Images.SetKeyName(187, "listing-option.png")
        Me.img_List_32x32.Images.SetKeyName(188, "list-on-window.png")
        Me.img_List_32x32.Images.SetKeyName(189, "list-with-dots.png")
        Me.img_List_32x32.Images.SetKeyName(190, "long-arrow-pointing-to-left.png")
        Me.img_List_32x32.Images.SetKeyName(191, "long-arrow-pointing-to-the-right.png")
        Me.img_List_32x32.Images.SetKeyName(192, "long-arrow-pointing-up.png")
        Me.img_List_32x32.Images.SetKeyName(193, "magic-wand.png")
        Me.img_List_32x32.Images.SetKeyName(194, "magnifying-glass.png")
        Me.img_List_32x32.Images.SetKeyName(195, "man.png")
        Me.img_List_32x32.Images.SetKeyName(196, "map-marker.png")
        Me.img_List_32x32.Images.SetKeyName(197, "maxcdn-website-logo.png")
        Me.img_List_32x32.Images.SetKeyName(198, "medical-kit.png")
        Me.img_List_32x32.Images.SetKeyName(199, "meh-face-emoticon.png")
        Me.img_List_32x32.Images.SetKeyName(200, "microphone-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(201, "microphone-off.png")
        Me.img_List_32x32.Images.SetKeyName(202, "minus-button.png")
        Me.img_List_32x32.Images.SetKeyName(203, "minus-sign-inside-a-black-circle.png")
        Me.img_List_32x32.Images.SetKeyName(204, "minus-sign-inside-a-black-rounded-square-shape.png")
        Me.img_List_32x32.Images.SetKeyName(205, "minus-sign-on-a-square-outline.png")
        Me.img_List_32x32.Images.SetKeyName(206, "minus-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(207, "mobile-phone.png")
        Me.img_List_32x32.Images.SetKeyName(208, "moon-phase-outline.png")
        Me.img_List_32x32.Images.SetKeyName(209, "move-option.png")
        Me.img_List_32x32.Images.SetKeyName(210, "musical-bell-outline.png")
        Me.img_List_32x32.Images.SetKeyName(211, "music-headphones.png")
        Me.img_List_32x32.Images.SetKeyName(212, "music-note-black-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(213, "nine-black-tiles.png")
        Me.img_List_32x32.Images.SetKeyName(214, "numbered-list.png")
        Me.img_List_32x32.Images.SetKeyName(215, "open-folder.png")
        Me.img_List_32x32.Images.SetKeyName(216, "open-folder-outline.png")
        Me.img_List_32x32.Images.SetKeyName(217, "open-laptop-computer.png")
        Me.img_List_32x32.Images.SetKeyName(218, "open-padlock-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(219, "open-wrench-tool-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(220, "padlock.png")
        Me.img_List_32x32.Images.SetKeyName(221, "padlock-unlock.png")
        Me.img_List_32x32.Images.SetKeyName(222, "paper-bill.png")
        Me.img_List_32x32.Images.SetKeyName(223, "paper-clip-outline.png")
        Me.img_List_32x32.Images.SetKeyName(224, "paper-push-pin.png")
        Me.img_List_32x32.Images.SetKeyName(225, "paste-from-clipboard.png")
        Me.img_List_32x32.Images.SetKeyName(226, "pause-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(227, "pencil.png")
        Me.img_List_32x32.Images.SetKeyName(228, "photo-camera.png")
        Me.img_List_32x32.Images.SetKeyName(229, "picture.png")
        Me.img_List_32x32.Images.SetKeyName(230, "pinterest-logo.png")
        Me.img_List_32x32.Images.SetKeyName(231, "pinterest-sign.png")
        Me.img_List_32x32.Images.SetKeyName(232, "plane.png")
        Me.img_List_32x32.Images.SetKeyName(233, "plant-leaf-with-white-details.png")
        Me.img_List_32x32.Images.SetKeyName(234, "play-button.png")
        Me.img_List_32x32.Images.SetKeyName(235, "play-circle.png")
        Me.img_List_32x32.Images.SetKeyName(236, "play-sign.png")
        Me.img_List_32x32.Images.SetKeyName(237, "play-video-button.png")
        Me.img_List_32x32.Images.SetKeyName(238, "plus-black-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(239, "plus-sign-in-a-black-circle.png")
        Me.img_List_32x32.Images.SetKeyName(240, "plus-symbol-in-a-rounded-black-square.png")
        Me.img_List_32x32.Images.SetKeyName(241, "power-button-off.png")
        Me.img_List_32x32.Images.SetKeyName(242, "printing-tool.png")
        Me.img_List_32x32.Images.SetKeyName(243, "puzzle-piece-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(244, "qr-code.png")
        Me.img_List_32x32.Images.SetKeyName(245, "question-mark-on-a-circular-black-background.png")
        Me.img_List_32x32.Images.SetKeyName(246, "question-sign.png")
        Me.img_List_32x32.Images.SetKeyName(247, "quote-left.png")
        Me.img_List_32x32.Images.SetKeyName(248, "reduced-volume.png")
        Me.img_List_32x32.Images.SetKeyName(249, "refresh-arrow.png")
        Me.img_List_32x32.Images.SetKeyName(250, "refresh-page-option.png")
        Me.img_List_32x32.Images.SetKeyName(251, "remove-button.png")
        Me.img_List_32x32.Images.SetKeyName(252, "remove-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(253, "renren-social-network-of-china-logotype.png")
        Me.img_List_32x32.Images.SetKeyName(254, "reorder-option.png")
        Me.img_List_32x32.Images.SetKeyName(255, "reply.png")
        Me.img_List_32x32.Images.SetKeyName(256, "reply-arrow.png")
        Me.img_List_32x32.Images.SetKeyName(257, "resize-option.png")
        Me.img_List_32x32.Images.SetKeyName(258, "retweet-arrows-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(259, "rewind-button.png")
        Me.img_List_32x32.Images.SetKeyName(260, "right-arrow-in-a-circle.png")
        Me.img_List_32x32.Images.SetKeyName(261, "right-chevron.png")
        Me.img_List_32x32.Images.SetKeyName(262, "right-quotation-mark.png")
        Me.img_List_32x32.Images.SetKeyName(263, "road-perspective.png")
        Me.img_List_32x32.Images.SetKeyName(264, "rounded-black-square-shape.png")
        Me.img_List_32x32.Images.SetKeyName(265, "rss-feed-button.png")
        Me.img_List_32x32.Images.SetKeyName(266, "rss-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(267, "rupee-indian.png")
        Me.img_List_32x32.Images.SetKeyName(268, "save-file-option.png")
        Me.img_List_32x32.Images.SetKeyName(269, "screenshot.png")
        Me.img_List_32x32.Images.SetKeyName(270, "settings.png")
        Me.img_List_32x32.Images.SetKeyName(271, "share-option.png")
        Me.img_List_32x32.Images.SetKeyName(272, "share-post-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(273, "share-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(274, "shield.png")
        Me.img_List_32x32.Images.SetKeyName(275, "shopping-cart-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(276, "signal-bars.png")
        Me.img_List_32x32.Images.SetKeyName(277, "sign-in.png")
        Me.img_List_32x32.Images.SetKeyName(278, "sign-out-option.png")
        Me.img_List_32x32.Images.SetKeyName(279, "sitemap.png")
        Me.img_List_32x32.Images.SetKeyName(280, "skype-logo.png")
        Me.img_List_32x32.Images.SetKeyName(281, "small-rocket-ship-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(282, "smile.png")
        Me.img_List_32x32.Images.SetKeyName(283, "sort-arrows-couple-pointing-up-and-down.png")
        Me.img_List_32x32.Images.SetKeyName(284, "sort-by-alphabet.png")
        Me.img_List_32x32.Images.SetKeyName(285, "sort-by-attributes.png")
        Me.img_List_32x32.Images.SetKeyName(286, "sort-by-attributes-interface-button-option.png")
        Me.img_List_32x32.Images.SetKeyName(287, "sort-by-numeric-order.png")
        Me.img_List_32x32.Images.SetKeyName(288, "sort-by-order.png")
        Me.img_List_32x32.Images.SetKeyName(289, "sort-down.png")
        Me.img_List_32x32.Images.SetKeyName(290, "sort-reverse-alphabetical-order.png")
        Me.img_List_32x32.Images.SetKeyName(291, "sort-up.png")
        Me.img_List_32x32.Images.SetKeyName(292, "speech-bubbles-comment-option.png")
        Me.img_List_32x32.Images.SetKeyName(293, "spinner-of-dots.png")
        Me.img_List_32x32.Images.SetKeyName(294, "square-shape-shadow.png")
        Me.img_List_32x32.Images.SetKeyName(295, "stack-exchange-logo.png")
        Me.img_List_32x32.Images.SetKeyName(296, "stack-exchange-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(297, "star.png")
        Me.img_List_32x32.Images.SetKeyName(298, "star-1.png")
        Me.img_List_32x32.Images.SetKeyName(299, "star-half-empty.png")
        Me.img_List_32x32.Images.SetKeyName(300, "step-backward.png")
        Me.img_List_32x32.Images.SetKeyName(301, "step-forward.png")
        Me.img_List_32x32.Images.SetKeyName(302, "stethoscope.png")
        Me.img_List_32x32.Images.SetKeyName(303, "strikethrough.png")
        Me.img_List_32x32.Images.SetKeyName(304, "suitcase-with-white-details.png")
        Me.img_List_32x32.Images.SetKeyName(305, "sun.png")
        Me.img_List_32x32.Images.SetKeyName(306, "superscript-text-formatting.png")
        Me.img_List_32x32.Images.SetKeyName(307, "table-grid.png")
        Me.img_List_32x32.Images.SetKeyName(308, "tag-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(309, "tags.png")
        Me.img_List_32x32.Images.SetKeyName(310, "tasks-list.png")
        Me.img_List_32x32.Images.SetKeyName(311, "telephone-handle-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(312, "telephone-symbol-button.png")
        Me.img_List_32x32.Images.SetKeyName(313, "terminal.png")
        Me.img_List_32x32.Images.SetKeyName(314, "text-file.png")
        Me.img_List_32x32.Images.SetKeyName(315, "text-file-1.png")
        Me.img_List_32x32.Images.SetKeyName(316, "text-height-adjustment.png")
        Me.img_List_32x32.Images.SetKeyName(317, "text-width.png")
        Me.img_List_32x32.Images.SetKeyName(318, "thin-arrowheads-pointing-down.png")
        Me.img_List_32x32.Images.SetKeyName(319, "three-small-square-shapes.png")
        Me.img_List_32x32.Images.SetKeyName(320, "thumb-down.png")
        Me.img_List_32x32.Images.SetKeyName(321, "thumbs-down-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(322, "thumbs-up.png")
        Me.img_List_32x32.Images.SetKeyName(323, "thumbs-up-hand-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(324, "ticket.png")
        Me.img_List_32x32.Images.SetKeyName(325, "time.png")
        Me.img_List_32x32.Images.SetKeyName(326, "tint-drop.png")
        Me.img_List_32x32.Images.SetKeyName(327, "trash.png")
        Me.img_List_32x32.Images.SetKeyName(328, "trello-website-logo.png")
        Me.img_List_32x32.Images.SetKeyName(329, "trophy.png")
        Me.img_List_32x32.Images.SetKeyName(330, "tumblr-logo.png")
        Me.img_List_32x32.Images.SetKeyName(331, "tumblr-logo-1.png")
        Me.img_List_32x32.Images.SetKeyName(332, "turkish-lire-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(333, "twitter-black-shape.png")
        Me.img_List_32x32.Images.SetKeyName(334, "twitter-sign.png")
        Me.img_List_32x32.Images.SetKeyName(335, "two-columns-layout.png")
        Me.img_List_32x32.Images.SetKeyName(336, "umbrella-black-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(337, "underline-text-option.png")
        Me.img_List_32x32.Images.SetKeyName(338, "undo-arrow.png")
        Me.img_List_32x32.Images.SetKeyName(339, "unlink-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(340, "up-arrow.png")
        Me.img_List_32x32.Images.SetKeyName(341, "up-chevron-button.png")
        Me.img_List_32x32.Images.SetKeyName(342, "upload.png")
        Me.img_List_32x32.Images.SetKeyName(343, "upload-button.png")
        Me.img_List_32x32.Images.SetKeyName(344, "user-md-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(345, "user-shape.png")
        Me.img_List_32x32.Images.SetKeyName(346, "u-shaped-thick-magnet.png")
        Me.img_List_32x32.Images.SetKeyName(347, "vertical-ellipsis.png")
        Me.img_List_32x32.Images.SetKeyName(348, "vertical-resizing-option.png")
        Me.img_List_32x32.Images.SetKeyName(349, "video-play-square-button.png")
        Me.img_List_32x32.Images.SetKeyName(350, "vimeo-square-logo.png")
        Me.img_List_32x32.Images.SetKeyName(351, "vintage-key-outline.png")
        Me.img_List_32x32.Images.SetKeyName(352, "vk-social-network-logo.png")
        Me.img_List_32x32.Images.SetKeyName(353, "volume-off.png")
        Me.img_List_32x32.Images.SetKeyName(354, "volume-up-interface-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(355, "warning-sign-on-a-triangular-background.png")
        Me.img_List_32x32.Images.SetKeyName(356, "weibo-website-logo.png")
        Me.img_List_32x32.Images.SetKeyName(357, "wheelchair.png")
        Me.img_List_32x32.Images.SetKeyName(358, "white-flag-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(359, "windows-logo-silhouette.png")
        Me.img_List_32x32.Images.SetKeyName(360, "x2-symbol-of-a-letter-and-a-number-subscript.png")
        Me.img_List_32x32.Images.SetKeyName(361, "xing-logo.png")
        Me.img_List_32x32.Images.SetKeyName(362, "xing-logotype.png")
        Me.img_List_32x32.Images.SetKeyName(363, "yen-symbol.png")
        Me.img_List_32x32.Images.SetKeyName(364, "youtube-logo.png")
        Me.img_List_32x32.Images.SetKeyName(365, "youtube-logo-1.png")
        Me.img_List_32x32.Images.SetKeyName(366, "youtube-logo-2.png")
        Me.img_List_32x32.Images.SetKeyName(367, "zoom-in.png")
        Me.img_List_32x32.Images.SetKeyName(368, "zoom-out.png")
        '
        'txt_Confirmacao_Senha
        '
        Me.txt_Confirmacao_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Confirmacao_Senha.Location = New System.Drawing.Point(424, 177)
        Me.txt_Confirmacao_Senha.MaxLength = 255
        Me.txt_Confirmacao_Senha.Name = "txt_Confirmacao_Senha"
        Me.txt_Confirmacao_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Confirmacao_Senha.Size = New System.Drawing.Size(115, 20)
        Me.txt_Confirmacao_Senha.TabIndex = 23
        Me.ttp_Dica.SetToolTip(Me.txt_Confirmacao_Senha, "A senha deve possuir:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pelo menos 8 caracteres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 letra maiúscula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 letra minú" &
        "scula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 caractere especial")
        '
        'lbl_Confirmacao_Senha
        '
        Me.lbl_Confirmacao_Senha.AutoSize = True
        Me.lbl_Confirmacao_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Confirmacao_Senha.Location = New System.Drawing.Point(421, 161)
        Me.lbl_Confirmacao_Senha.Name = "lbl_Confirmacao_Senha"
        Me.lbl_Confirmacao_Senha.Size = New System.Drawing.Size(77, 13)
        Me.lbl_Confirmacao_Senha.TabIndex = 20
        Me.lbl_Confirmacao_Senha.Text = "Confirmação"
        '
        'lbl_Imagem_Usuario
        '
        Me.lbl_Imagem_Usuario.AutoSize = True
        Me.lbl_Imagem_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Imagem_Usuario.Location = New System.Drawing.Point(9, 22)
        Me.lbl_Imagem_Usuario.Name = "lbl_Imagem_Usuario"
        Me.lbl_Imagem_Usuario.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Imagem_Usuario.TabIndex = 0
        Me.lbl_Imagem_Usuario.Text = "Imagem"
        '
        'btn_Selecionar_Imagem
        '
        Me.btn_Selecionar_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Selecionar_Imagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Selecionar_Imagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Selecionar_Imagem.ImageKey = "picture.png"
        Me.btn_Selecionar_Imagem.ImageList = Me.img_List_16x16
        Me.btn_Selecionar_Imagem.Location = New System.Drawing.Point(12, 172)
        Me.btn_Selecionar_Imagem.Name = "btn_Selecionar_Imagem"
        Me.btn_Selecionar_Imagem.Size = New System.Drawing.Size(128, 25)
        Me.btn_Selecionar_Imagem.TabIndex = 18
        Me.btn_Selecionar_Imagem.TabStop = False
        Me.btn_Selecionar_Imagem.Text = "  Selecionar"
        Me.btn_Selecionar_Imagem.UseVisualStyleBackColor = True
        '
        'ptb_Imagem_Usuario
        '
        Me.ptb_Imagem_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_Imagem_Usuario.Image = Global.Eurolift_Services.My.Resources.Resources.user_picture_128x128
        Me.ptb_Imagem_Usuario.Location = New System.Drawing.Point(12, 38)
        Me.ptb_Imagem_Usuario.Name = "ptb_Imagem_Usuario"
        Me.ptb_Imagem_Usuario.Size = New System.Drawing.Size(128, 128)
        Me.ptb_Imagem_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Imagem_Usuario.TabIndex = 43
        Me.ptb_Imagem_Usuario.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.ImageKey = "remove-button.png"
        Me.btn_Cancelar.ImageList = Me.img_List_16x16
        Me.btn_Cancelar.Location = New System.Drawing.Point(186, 218)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cancelar.TabIndex = 26
        Me.btn_Cancelar.Text = "  Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Esconder_Senha
        '
        Me.btn_Esconder_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Esconder_Senha.ImageKey = "eye-with-a-diagonal-line-interface-symbol-for-invisibility.png"
        Me.btn_Esconder_Senha.ImageList = Me.img_List_16x16
        Me.btn_Esconder_Senha.Location = New System.Drawing.Point(390, 174)
        Me.btn_Esconder_Senha.Name = "btn_Esconder_Senha"
        Me.btn_Esconder_Senha.Size = New System.Drawing.Size(28, 23)
        Me.btn_Esconder_Senha.TabIndex = 5
        Me.btn_Esconder_Senha.TabStop = False
        Me.btn_Esconder_Senha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Esconder_Senha.UseVisualStyleBackColor = True
        '
        'btn_Cadastrar
        '
        Me.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cadastrar.ImageKey = "plus-sign-in-a-black-circle.png"
        Me.btn_Cadastrar.ImageList = Me.img_List_16x16
        Me.btn_Cadastrar.Location = New System.Drawing.Point(294, 218)
        Me.btn_Cadastrar.Name = "btn_Cadastrar"
        Me.btn_Cadastrar.Size = New System.Drawing.Size(102, 25)
        Me.btn_Cadastrar.TabIndex = 27
        Me.btn_Cadastrar.Text = "  Cadastrar"
        Me.btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'pnl_Sexo
        '
        Me.pnl_Sexo.Controls.Add(Me.rdo_Sexo_1)
        Me.pnl_Sexo.Controls.Add(Me.rdo_Sexo_2)
        Me.pnl_Sexo.Location = New System.Drawing.Point(498, 38)
        Me.pnl_Sexo.Name = "pnl_Sexo"
        Me.pnl_Sexo.Size = New System.Drawing.Size(74, 21)
        Me.pnl_Sexo.TabIndex = 47
        '
        'btn_Esconder_Confirmacao_Senha
        '
        Me.btn_Esconder_Confirmacao_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Esconder_Confirmacao_Senha.ImageKey = "eye-with-a-diagonal-line-interface-symbol-for-invisibility.png"
        Me.btn_Esconder_Confirmacao_Senha.ImageList = Me.img_List_16x16
        Me.btn_Esconder_Confirmacao_Senha.Location = New System.Drawing.Point(542, 175)
        Me.btn_Esconder_Confirmacao_Senha.Name = "btn_Esconder_Confirmacao_Senha"
        Me.btn_Esconder_Confirmacao_Senha.Size = New System.Drawing.Size(28, 23)
        Me.btn_Esconder_Confirmacao_Senha.TabIndex = 41
        Me.btn_Esconder_Confirmacao_Senha.TabStop = False
        Me.btn_Esconder_Confirmacao_Senha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Esconder_Confirmacao_Senha.UseVisualStyleBackColor = True
        '
        'btn_Mostrar_Senha
        '
        Me.btn_Mostrar_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Mostrar_Senha.ImageKey = "eye-open.png"
        Me.btn_Mostrar_Senha.ImageList = Me.img_List_16x16
        Me.btn_Mostrar_Senha.Location = New System.Drawing.Point(390, 175)
        Me.btn_Mostrar_Senha.Name = "btn_Mostrar_Senha"
        Me.btn_Mostrar_Senha.Size = New System.Drawing.Size(28, 23)
        Me.btn_Mostrar_Senha.TabIndex = 22
        Me.btn_Mostrar_Senha.TabStop = False
        Me.btn_Mostrar_Senha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar_Senha.UseVisualStyleBackColor = True
        '
        'btn_Mostrar_Confirmacao_Senha
        '
        Me.btn_Mostrar_Confirmacao_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Mostrar_Confirmacao_Senha.ImageKey = "eye-open.png"
        Me.btn_Mostrar_Confirmacao_Senha.ImageList = Me.img_List_16x16
        Me.btn_Mostrar_Confirmacao_Senha.Location = New System.Drawing.Point(542, 175)
        Me.btn_Mostrar_Confirmacao_Senha.Name = "btn_Mostrar_Confirmacao_Senha"
        Me.btn_Mostrar_Confirmacao_Senha.Size = New System.Drawing.Size(28, 23)
        Me.btn_Mostrar_Confirmacao_Senha.TabIndex = 24
        Me.btn_Mostrar_Confirmacao_Senha.TabStop = False
        Me.btn_Mostrar_Confirmacao_Senha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar_Confirmacao_Senha.UseVisualStyleBackColor = True
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
        'txt_File_Path
        '
        Me.txt_File_Path.Location = New System.Drawing.Point(12, 201)
        Me.txt_File_Path.Name = "txt_File_Path"
        Me.txt_File_Path.Size = New System.Drawing.Size(100, 20)
        Me.txt_File_Path.TabIndex = 25
        Me.txt_File_Path.Visible = False
        '
        'cbo_Status
        '
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Location = New System.Drawing.Point(153, 176)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(110, 21)
        Me.cbo_Status.TabIndex = 49
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(150, 160)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Status.TabIndex = 48
        Me.lbl_Status.Text = "Status"
        '
        'Cadastrar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 253)
        Me.Controls.Add(Me.cbo_Status)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.txt_File_Path)
        Me.Controls.Add(Me.pnl_Sexo)
        Me.Controls.Add(Me.btn_Selecionar_Imagem)
        Me.Controls.Add(Me.lbl_Imagem_Usuario)
        Me.Controls.Add(Me.ptb_Imagem_Usuario)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Mostrar_Confirmacao_Senha)
        Me.Controls.Add(Me.txt_Nome)
        Me.Controls.Add(Me.txt_Confirmacao_Senha)
        Me.Controls.Add(Me.lbl_Senha)
        Me.Controls.Add(Me.lbl_Confirmacao_Senha)
        Me.Controls.Add(Me.txt_Senha)
        Me.Controls.Add(Me.cbo_Perfil)
        Me.Controls.Add(Me.lbl_Nome)
        Me.Controls.Add(Me.lbl_Perfil)
        Me.Controls.Add(Me.btn_Mostrar_Senha)
        Me.Controls.Add(Me.cbo_Filial)
        Me.Controls.Add(Me.btn_Esconder_Senha)
        Me.Controls.Add(Me.lbl_Filial)
        Me.Controls.Add(Me.btn_Cadastrar)
        Me.Controls.Add(Me.cbo_Setor)
        Me.Controls.Add(Me.lbl_Setor)
        Me.Controls.Add(Me.mkt_Telefone)
        Me.Controls.Add(Me.lbl_Sexo)
        Me.Controls.Add(Me.mkt_CPF)
        Me.Controls.Add(Me.lbl_CPF)
        Me.Controls.Add(Me.txt_Login)
        Me.Controls.Add(Me.lbl_Telefone)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.btn_Esconder_Confirmacao_Senha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastrar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar usuário"
        CType(Me.ptb_Imagem_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Sexo.ResumeLayout(False)
        Me.pnl_Sexo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents lbl_Nome As Label
    Friend WithEvents txt_Login As TextBox
    Friend WithEvents lbl_Login As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_Telefone As Label
    Friend WithEvents lbl_CPF As Label
    Friend WithEvents lbl_Sexo As Label
    Friend WithEvents rdo_Sexo_2 As RadioButton
    Friend WithEvents rdo_Sexo_1 As RadioButton
    Friend WithEvents btn_Esconder_Senha As Button
    Friend WithEvents txt_Senha As TextBox
    Friend WithEvents lbl_Senha As Label
    Friend WithEvents mkt_Telefone As MaskedTextBox
    Friend WithEvents mkt_CPF As MaskedTextBox
    Friend WithEvents cbo_Setor As ComboBox
    Friend WithEvents lbl_Setor As Label
    Friend WithEvents cbo_Perfil As ComboBox
    Friend WithEvents lbl_Perfil As Label
    Friend WithEvents cbo_Filial As ComboBox
    Friend WithEvents lbl_Filial As Label
    Public WithEvents img_List_16x16 As ImageList
    Friend WithEvents txt_Confirmacao_Senha As TextBox
    Friend WithEvents lbl_Confirmacao_Senha As Label
    Public WithEvents img_List_32x32 As ImageList
    Friend WithEvents btn_Cadastrar As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents ptb_Imagem_Usuario As PictureBox
    Friend WithEvents lbl_Imagem_Usuario As Label
    Friend WithEvents btn_Selecionar_Imagem As Button
    Friend WithEvents pnl_Sexo As Panel
    Friend WithEvents btn_Esconder_Confirmacao_Senha As Button
    Friend WithEvents btn_Mostrar_Senha As Button
    Friend WithEvents btn_Mostrar_Confirmacao_Senha As Button
    Friend WithEvents ttp_Dica As ToolTip
    Friend WithEvents txt_File_Path As TextBox
    Friend WithEvents cbo_Status As ComboBox
    Friend WithEvents lbl_Status As Label
End Class
