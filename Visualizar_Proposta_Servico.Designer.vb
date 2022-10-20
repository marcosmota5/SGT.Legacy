<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visualizar_Proposta_Servico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visualizar_Proposta_Servico))
        Me.dt_PropostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_eurolift_sgtDataSet = New Eurolift_Services.db_eurolift_sgtDataSet()
        Me.dt_PecasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dt_ServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dt_Usuario_FilialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dt_Data_AprovacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtPropostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtPecasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtUsuarioFilialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtDataAprovacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mnu_Visualizar_Proposta = New System.Windows.Forms.MenuStrip()
        Me.mnui_Enviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnui_Responder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Dt_PropostasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_PropostasTableAdapter()
        Me.Dt_PecasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_PecasTableAdapter()
        Me.Dt_ServicosTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_ServicosTableAdapter()
        Me.Dt_Usuario_FilialTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_Usuario_FilialTableAdapter()
        Me.Dt_Data_AprovacaoTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_Data_AprovacaoTableAdapter()
        CType(Me.dt_PropostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_eurolift_sgtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_PecasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_Usuario_FilialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_Data_AprovacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPropostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPecasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtUsuarioFilialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDataAprovacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_Visualizar_Proposta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dt_PropostasBindingSource
        '
        Me.dt_PropostasBindingSource.DataMember = "dt_Propostas"
        Me.dt_PropostasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'Db_eurolift_sgtDataSet
        '
        Me.Db_eurolift_sgtDataSet.DataSetName = "db_eurolift_sgtDataSet"
        Me.Db_eurolift_sgtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dt_PecasBindingSource
        '
        Me.dt_PecasBindingSource.DataMember = "dt_Pecas"
        Me.dt_PecasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'dt_ServicosBindingSource
        '
        Me.dt_ServicosBindingSource.DataMember = "dt_Servicos"
        Me.dt_ServicosBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'dt_Usuario_FilialBindingSource
        '
        Me.dt_Usuario_FilialBindingSource.DataMember = "dt_Usuario_Filial"
        Me.dt_Usuario_FilialBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'dt_Data_AprovacaoBindingSource
        '
        Me.dt_Data_AprovacaoBindingSource.DataMember = "dt_Data_Aprovacao"
        Me.dt_Data_AprovacaoBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
        '
        'DtPropostasBindingSource
        '
        Me.DtPropostasBindingSource.DataMember = "dt_Propostas"
        Me.DtPropostasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet
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
        'mnu_Visualizar_Proposta
        '
        Me.mnu_Visualizar_Proposta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnui_Enviar, Me.mnui_Responder})
        Me.mnu_Visualizar_Proposta.Location = New System.Drawing.Point(0, 0)
        Me.mnu_Visualizar_Proposta.Name = "mnu_Visualizar_Proposta"
        Me.mnu_Visualizar_Proposta.Size = New System.Drawing.Size(940, 24)
        Me.mnu_Visualizar_Proposta.TabIndex = 3
        Me.mnu_Visualizar_Proposta.Text = "MenuStrip1"
        '
        'mnui_Enviar
        '
        Me.mnui_Enviar.Image = Global.Eurolift_Services.My.Resources.Resources.email
        Me.mnui_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Enviar.Name = "mnui_Enviar"
        Me.mnui_Enviar.Size = New System.Drawing.Size(110, 20)
        Me.mnui_Enviar.Text = "  Enviar e-mail"
        '
        'mnui_Responder
        '
        Me.mnui_Responder.Image = Global.Eurolift_Services.My.Resources.Resources.reply_email
        Me.mnui_Responder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnui_Responder.Name = "mnui_Responder"
        Me.mnui_Responder.Size = New System.Drawing.Size(134, 20)
        Me.mnui_Responder.Text = "  Responder e-mail"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dts_Proposta"
        ReportDataSource1.Value = Me.dt_PropostasBindingSource
        ReportDataSource2.Name = "dts_Pecas"
        ReportDataSource2.Value = Me.dt_PecasBindingSource
        ReportDataSource3.Name = "dts_Servicos"
        ReportDataSource3.Value = Me.dt_ServicosBindingSource
        ReportDataSource4.Name = "dts_Usuario_Filial"
        ReportDataSource4.Value = Me.dt_Usuario_FilialBindingSource
        ReportDataSource5.Name = "dts_Data_Aprovacao"
        ReportDataSource5.Value = Me.dt_Data_AprovacaoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Eurolift_Services.Relatorio_Proposta_Servico .rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(940, 739)
        Me.ReportViewer1.TabIndex = 4
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
        'Visualizar_Proposta_Servico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 763)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.mnu_Visualizar_Proposta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Visualizar_Proposta_Servico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proposta"
        CType(Me.dt_PropostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_eurolift_sgtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_PecasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_Usuario_FilialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_Data_AprovacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPropostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPecasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtUsuarioFilialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDataAprovacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_Visualizar_Proposta.ResumeLayout(False)
        Me.mnu_Visualizar_Proposta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_Visualizar_Proposta As MenuStrip
    Friend WithEvents mnui_Enviar As ToolStripMenuItem
    Friend WithEvents mnui_Responder As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DtPropostasBindingSource As BindingSource
    Friend WithEvents Db_eurolift_sgtDataSet As db_eurolift_sgtDataSet
    Friend WithEvents DtPecasBindingSource As BindingSource
    Friend WithEvents DtServicosBindingSource As BindingSource
    Friend WithEvents DtUsuarioFilialBindingSource As BindingSource
    Friend WithEvents DtDataAprovacaoBindingSource As BindingSource
    Friend WithEvents Dt_PropostasTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_PropostasTableAdapter
    Friend WithEvents Dt_PecasTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_PecasTableAdapter
    Friend WithEvents Dt_ServicosTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_ServicosTableAdapter
    Friend WithEvents Dt_Usuario_FilialTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_Usuario_FilialTableAdapter
    Friend WithEvents Dt_Data_AprovacaoTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_Data_AprovacaoTableAdapter
    Friend WithEvents dt_PropostasBindingSource As BindingSource
    Friend WithEvents dt_PecasBindingSource As BindingSource
    Friend WithEvents dt_ServicosBindingSource As BindingSource
    Friend WithEvents dt_Usuario_FilialBindingSource As BindingSource
    Friend WithEvents dt_Data_AprovacaoBindingSource As BindingSource
End Class
