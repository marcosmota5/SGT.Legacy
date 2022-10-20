<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visualizar_Proposta
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visualizar_Proposta))
        Me.DtPropostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_eurolift_sgtDataSet = New Eurolift_Services.db_eurolift_sgtDataSet()
        Me.DtPecasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtUsuarioFilialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtDataAprovacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mnu_Visualizar_Proposta = New System.Windows.Forms.MenuStrip()
        Me.mnui_Enviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Responder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Dt_PropostasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_PropostasTableAdapter()
        Me.Dt_PecasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_PecasTableAdapter()
        Me.Dt_ServicosTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_ServicosTableAdapter()
        Me.Dt_Usuario_FilialTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_Usuario_FilialTableAdapter()
        Me.Dt_Data_AprovacaoTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_Data_AprovacaoTableAdapter()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.DtPropostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_eurolift_sgtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPecasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtUsuarioFilialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDataAprovacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_Visualizar_Proposta.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtPropostasBindingSource
        '
        Me.DtPropostasBindingSource.DataMember = "dt_Propostas"
        Me.DtPropostasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'Db_eurolift_sgtDataSet
        '
        Me.Db_eurolift_sgtDataSet.DataSetName = "db_eurolift_sgtDataSet"
        Me.Db_eurolift_sgtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtPecasBindingSource
        '
        Me.DtPecasBindingSource.DataMember = "dt_Pecas"
        Me.DtPecasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'DtServicosBindingSource
        '
        Me.DtServicosBindingSource.DataMember = "dt_Servicos"
        Me.DtServicosBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'DtUsuarioFilialBindingSource
        '
        Me.DtUsuarioFilialBindingSource.DataMember = "dt_Usuario_Filial"
        Me.DtUsuarioFilialBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'DtDataAprovacaoBindingSource
        '
        Me.DtDataAprovacaoBindingSource.DataMember = "dt_Data_Aprovacao"
        Me.DtDataAprovacaoBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dts_Proposta"
        ReportDataSource1.Value = Me.DtPropostasBindingSource
        ReportDataSource2.Name = "dts_Pecas"
        ReportDataSource2.Value = Me.DtPecasBindingSource
        ReportDataSource3.Name = "dts_Servicos"
        ReportDataSource3.Value = Me.DtServicosBindingSource
        ReportDataSource4.Name = "dts_Usuario_Filial"
        ReportDataSource4.Value = Me.DtUsuarioFilialBindingSource
        ReportDataSource5.Name = "dts_Data_Aprovacao"
        ReportDataSource5.Value = Me.DtDataAprovacaoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Eurolift_Services.Relatorio_Proposta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(940, 736)
        Me.ReportViewer1.TabIndex = 0
        '
        'mnu_Visualizar_Proposta
        '
        Me.mnu_Visualizar_Proposta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnui_Enviar, Me.mnui_Responder, Me.ToolStripComboBox1, Me.ToolStripComboBox2, Me.ToolStripComboBox3})
        Me.mnu_Visualizar_Proposta.Location = New System.Drawing.Point(0, 0)
        Me.mnu_Visualizar_Proposta.Name = "mnu_Visualizar_Proposta"
        Me.mnu_Visualizar_Proposta.Size = New System.Drawing.Size(940, 27)
        Me.mnu_Visualizar_Proposta.TabIndex = 1
        Me.mnu_Visualizar_Proposta.Text = "MenuStrip1"
        '
        'mnui_Enviar
        '
        Me.mnui_Enviar.Image = Global.Eurolift_Services.My.Resources.Resources.email
        Me.mnui_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Enviar.Name = "mnui_Enviar"
        Me.mnui_Enviar.Size = New System.Drawing.Size(110, 23)
        Me.mnui_Enviar.Text = "  Enviar e-mail"
        '
        'mnui_Responder
        '
        Me.mnui_Responder.Image = Global.Eurolift_Services.My.Resources.Resources.reply_email
        Me.mnui_Responder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Responder.Name = "mnui_Responder"
        Me.mnui_Responder.Size = New System.Drawing.Size(134, 23)
        Me.mnui_Responder.Text = "  Responder e-mail"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Ocultar NCM", "Exibir NCM"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(100, 23)
        '
        'Dt_PropostasTableAdapter
        '
        Me.Dt_PropostasTableAdapter.ClearBeforeFill = True
        '
        'Dt_PecasTableAdapter
        '
        Me.Dt_PecasTableAdapter.ClearBeforeFill = True
        '
        'Dt_ServicosTableAdapter
        '
        Me.Dt_ServicosTableAdapter.ClearBeforeFill = True
        '
        'Dt_Usuario_FilialTableAdapter
        '
        Me.Dt_Usuario_FilialTableAdapter.ClearBeforeFill = True
        '
        'Dt_Data_AprovacaoTableAdapter
        '
        Me.Dt_Data_AprovacaoTableAdapter.ClearBeforeFill = True
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox2.Items.AddRange(New Object() {"Ocultar conjunto", "Exibir conjunto"})
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(115, 23)
        '
        'ToolStripComboBox3
        '
        Me.ToolStripComboBox3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox3.Items.AddRange(New Object() {"Ocultar códigos", "Exibir código atual abreviado", "Exibir código atual completo", "Exibir todos os códigos"})
        Me.ToolStripComboBox3.Name = "ToolStripComboBox3"
        Me.ToolStripComboBox3.Size = New System.Drawing.Size(180, 23)
        '
        'Visualizar_Proposta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 763)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.mnu_Visualizar_Proposta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_Visualizar_Proposta
        Me.Name = "Visualizar_Proposta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proposta"
        CType(Me.DtPropostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_eurolift_sgtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPecasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtUsuarioFilialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDataAprovacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_Visualizar_Proposta.ResumeLayout(False)
        Me.mnu_Visualizar_Proposta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DtPropostasBindingSource As BindingSource
    Friend WithEvents Db_eurolift_sgtDataSet As db_eurolift_sgtDataSet
    Friend WithEvents DtPecasBindingSource As BindingSource
    Friend WithEvents DtServicosBindingSource As BindingSource
    Friend WithEvents DtUsuarioFilialBindingSource As BindingSource
    Friend WithEvents Dt_PropostasTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_PropostasTableAdapter
    Friend WithEvents Dt_PecasTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_PecasTableAdapter
    Friend WithEvents Dt_ServicosTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_ServicosTableAdapter
    Friend WithEvents Dt_Usuario_FilialTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_Usuario_FilialTableAdapter
    Friend WithEvents DtDataAprovacaoBindingSource As BindingSource
    Friend WithEvents Dt_Data_AprovacaoTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_Data_AprovacaoTableAdapter
    Friend WithEvents mnu_Visualizar_Proposta As MenuStrip
    Friend WithEvents mnui_Enviar As ToolStripMenuItem
    Friend WithEvents mnui_Responder As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox3 As ToolStripComboBox
End Class
