<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Importar_Pecas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Importar_Pecas))
        Me.lbl_Pasta_Email = New System.Windows.Forms.Label()
        Me.trv_Pasta_Email = New System.Windows.Forms.TreeView()
        Me.dtg_Emails = New System.Windows.Forms.DataGridView()
        Me.cms_Importar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Importar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Substituir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Emails = New System.Windows.Forms.Label()
        Me.dtp_De = New System.Windows.Forms.DateTimePicker()
        Me.lbl_De = New System.Windows.Forms.Label()
        Me.dtp_Ate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Ate = New System.Windows.Forms.Label()
        Me.ttp_Dica = New System.Windows.Forms.ToolTip(Me.components)
        Me.pgb_Importacao_Pecas = New System.Windows.Forms.ProgressBar()
        Me.lbl_Importacao_Pecas = New System.Windows.Forms.Label()
        CType(Me.dtg_Emails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Importar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Pasta_Email
        '
        Me.lbl_Pasta_Email.AutoSize = True
        Me.lbl_Pasta_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pasta_Email.Location = New System.Drawing.Point(9, 17)
        Me.lbl_Pasta_Email.Name = "lbl_Pasta_Email"
        Me.lbl_Pasta_Email.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Pasta_Email.TabIndex = 0
        Me.lbl_Pasta_Email.Text = "Pastas de e-mail"
        '
        'trv_Pasta_Email
        '
        Me.trv_Pasta_Email.Location = New System.Drawing.Point(12, 33)
        Me.trv_Pasta_Email.Name = "trv_Pasta_Email"
        Me.trv_Pasta_Email.Size = New System.Drawing.Size(209, 405)
        Me.trv_Pasta_Email.TabIndex = 4
        '
        'dtg_Emails
        '
        Me.dtg_Emails.AllowUserToAddRows = False
        Me.dtg_Emails.AllowUserToDeleteRows = False
        Me.dtg_Emails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_Emails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtg_Emails.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Emails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_Emails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Emails.Location = New System.Drawing.Point(227, 33)
        Me.dtg_Emails.MultiSelect = False
        Me.dtg_Emails.Name = "dtg_Emails"
        Me.dtg_Emails.ReadOnly = True
        Me.dtg_Emails.RowHeadersVisible = False
        Me.dtg_Emails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Emails.Size = New System.Drawing.Size(602, 405)
        Me.dtg_Emails.TabIndex = 5
        Me.ttp_Dica.SetToolTip(Me.dtg_Emails, "Clique com o botão direito sobre um resultado para selecionar as opções de import" &
        "ação")
        '
        'cms_Importar
        '
        Me.cms_Importar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Importar})
        Me.cms_Importar.Name = "ContextMenuStrip1"
        Me.cms_Importar.Size = New System.Drawing.Size(121, 26)
        Me.cms_Importar.Text = "Importar"
        '
        'tsmi_Importar
        '
        Me.tsmi_Importar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Substituir, Me.tsmi_Adicionar})
        Me.tsmi_Importar.Name = "tsmi_Importar"
        Me.tsmi_Importar.Size = New System.Drawing.Size(120, 22)
        Me.tsmi_Importar.Text = "Importar"
        '
        'tsmi_Substituir
        '
        Me.tsmi_Substituir.Name = "tsmi_Substituir"
        Me.tsmi_Substituir.Size = New System.Drawing.Size(125, 22)
        Me.tsmi_Substituir.Text = "Substituir"
        '
        'tsmi_Adicionar
        '
        Me.tsmi_Adicionar.Name = "tsmi_Adicionar"
        Me.tsmi_Adicionar.Size = New System.Drawing.Size(125, 22)
        Me.tsmi_Adicionar.Text = "Adicionar"
        '
        'lbl_Emails
        '
        Me.lbl_Emails.AutoSize = True
        Me.lbl_Emails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emails.Location = New System.Drawing.Point(224, 17)
        Me.lbl_Emails.Name = "lbl_Emails"
        Me.lbl_Emails.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Emails.TabIndex = 1
        Me.lbl_Emails.Text = "E-mails"
        '
        'dtp_De
        '
        Me.dtp_De.CustomFormat = "dd/MM/yyyy"
        Me.dtp_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_De.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_De.Location = New System.Drawing.Point(598, 10)
        Me.dtp_De.Name = "dtp_De"
        Me.dtp_De.Size = New System.Drawing.Size(97, 20)
        Me.dtp_De.TabIndex = 2
        Me.dtp_De.Value = New Date(2020, 11, 4, 23, 8, 0, 0)
        '
        'lbl_De
        '
        Me.lbl_De.AutoSize = True
        Me.lbl_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_De.Location = New System.Drawing.Point(569, 17)
        Me.lbl_De.Name = "lbl_De"
        Me.lbl_De.Size = New System.Drawing.Size(23, 13)
        Me.lbl_De.TabIndex = 50
        Me.lbl_De.Text = "De"
        '
        'dtp_Ate
        '
        Me.dtp_Ate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Ate.Location = New System.Drawing.Point(733, 10)
        Me.dtp_Ate.Name = "dtp_Ate"
        Me.dtp_Ate.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Ate.TabIndex = 3
        '
        'lbl_Ate
        '
        Me.lbl_Ate.AutoSize = True
        Me.lbl_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ate.Location = New System.Drawing.Point(701, 17)
        Me.lbl_Ate.Name = "lbl_Ate"
        Me.lbl_Ate.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Ate.TabIndex = 52
        Me.lbl_Ate.Text = "Até"
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
        'pgb_Importacao_Pecas
        '
        Me.pgb_Importacao_Pecas.Location = New System.Drawing.Point(12, 445)
        Me.pgb_Importacao_Pecas.Name = "pgb_Importacao_Pecas"
        Me.pgb_Importacao_Pecas.Size = New System.Drawing.Size(817, 23)
        Me.pgb_Importacao_Pecas.TabIndex = 53
        '
        'lbl_Importacao_Pecas
        '
        Me.lbl_Importacao_Pecas.AutoSize = True
        Me.lbl_Importacao_Pecas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Importacao_Pecas.Location = New System.Drawing.Point(333, 450)
        Me.lbl_Importacao_Pecas.Name = "lbl_Importacao_Pecas"
        Me.lbl_Importacao_Pecas.Size = New System.Drawing.Size(174, 13)
        Me.lbl_Importacao_Pecas.TabIndex = 54
        Me.lbl_Importacao_Pecas.Text = "Importando peças, aguarde..."
        '
        'Importar_Pecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 472)
        Me.Controls.Add(Me.lbl_Importacao_Pecas)
        Me.Controls.Add(Me.pgb_Importacao_Pecas)
        Me.Controls.Add(Me.dtp_Ate)
        Me.Controls.Add(Me.lbl_Ate)
        Me.Controls.Add(Me.dtp_De)
        Me.Controls.Add(Me.lbl_De)
        Me.Controls.Add(Me.lbl_Emails)
        Me.Controls.Add(Me.dtg_Emails)
        Me.Controls.Add(Me.trv_Pasta_Email)
        Me.Controls.Add(Me.lbl_Pasta_Email)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Importar_Pecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar peças"
        CType(Me.dtg_Emails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Importar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Pasta_Email As Label
    Friend WithEvents trv_Pasta_Email As TreeView
    Friend WithEvents dtg_Emails As DataGridView
    Friend WithEvents lbl_Emails As Label
    Friend WithEvents dtp_De As DateTimePicker
    Friend WithEvents lbl_De As Label
    Friend WithEvents dtp_Ate As DateTimePicker
    Friend WithEvents lbl_Ate As Label
    Friend WithEvents ttp_Dica As ToolTip
    Friend WithEvents cms_Importar As ContextMenuStrip
    Friend WithEvents tsmi_Importar As ToolStripMenuItem
    Friend WithEvents tsmi_Substituir As ToolStripMenuItem
    Friend WithEvents tsmi_Adicionar As ToolStripMenuItem
    Friend WithEvents pgb_Importacao_Pecas As ProgressBar
    Friend WithEvents lbl_Importacao_Pecas As Label
End Class
