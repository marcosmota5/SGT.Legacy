<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proposta_Gerada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proposta_Gerada))
        Me.tb_itens_propostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_eurolift_sgtDataSet = New Eurolift_Services.db_eurolift_sgtDataSet()
        Me.tb_itens_propostasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.tb_itens_propostasTableAdapter()
        Me.dt_Itens_PropostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dt_PropostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dt_PropostasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_PropostasTableAdapter()
        Me.dt_Itens_PropostasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_Itens_PropostasTableAdapter()
        Me.Db_eurolift_sgtDataSet1 = New Eurolift_Services.db_eurolift_sgtDataSet()
        Me.DtPecasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dt_PecasTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_PecasTableAdapter()
        Me.DtPropostasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dt_ServicosTableAdapter = New Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_ServicosTableAdapter()
        CType(Me.tb_itens_propostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_eurolift_sgtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_Itens_PropostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_PropostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_eurolift_sgtDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPecasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPropostasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_itens_propostasBindingSource
        '
        Me.tb_itens_propostasBindingSource.DataMember = "tb_itens_propostas"
        Me.tb_itens_propostasBindingSource.DataSource = Me.db_eurolift_sgtDataSet
        '
        'db_eurolift_sgtDataSet
        '
        Me.db_eurolift_sgtDataSet.DataSetName = "db_eurolift_sgtDataSet"
        Me.db_eurolift_sgtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_itens_propostasTableAdapter
        '
        Me.tb_itens_propostasTableAdapter.ClearBeforeFill = True
        '
        'dt_Itens_PropostasBindingSource
        '
        Me.dt_Itens_PropostasBindingSource.DataMember = "dt_Itens_Propostas"
        Me.dt_Itens_PropostasBindingSource.DataSource = Me.db_eurolift_sgtDataSet
        '
        'dt_PropostasBindingSource
        '
        Me.dt_PropostasBindingSource.DataMember = "dt_Propostas"
        Me.dt_PropostasBindingSource.DataSource = Me.db_eurolift_sgtDataSet
        '
        'dt_PropostasTableAdapter
        '
        Me.dt_PropostasTableAdapter.ClearBeforeFill = True
        '
        'dt_Itens_PropostasTableAdapter
        '
        Me.dt_Itens_PropostasTableAdapter.ClearBeforeFill = True
        '
        'Db_eurolift_sgtDataSet1
        '
        Me.Db_eurolift_sgtDataSet1.DataSetName = "db_eurolift_sgtDataSet"
        Me.Db_eurolift_sgtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtPecasBindingSource
        '
        Me.DtPecasBindingSource.DataMember = "dt_Pecas"
        Me.DtPecasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet1
        '
        'Dt_PecasTableAdapter
        '
        Me.Dt_PecasTableAdapter.ClearBeforeFill = True
        '
        'DtPropostasBindingSource
        '
        Me.DtPropostasBindingSource.DataMember = "dt_Propostas"
        Me.DtPropostasBindingSource.DataSource = Me.Db_eurolift_sgtDataSet1
        '
        'DtServicosBindingSource
        '
        Me.DtServicosBindingSource.DataMember = "dt_Servicos"
        Me.DtServicosBindingSource.DataSource = Me.Db_eurolift_sgtDataSet1
        '
        'Dt_ServicosTableAdapter
        '
        Me.Dt_ServicosTableAdapter.ClearBeforeFill = True
        '
        'Proposta_Gerada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Proposta_Gerada"
        Me.Text = "Proposta_Gerada"
        CType(Me.tb_itens_propostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_eurolift_sgtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_Itens_PropostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_PropostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_eurolift_sgtDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPecasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPropostasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_itens_propostasBindingSource As BindingSource
    Friend WithEvents db_eurolift_sgtDataSet As db_eurolift_sgtDataSet
    Friend WithEvents tb_itens_propostasTableAdapter As db_eurolift_sgtDataSetTableAdapters.tb_itens_propostasTableAdapter
    Friend WithEvents dt_Itens_PropostasBindingSource As BindingSource
    Friend WithEvents dt_PropostasBindingSource As BindingSource
    Friend WithEvents dt_PropostasTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_PropostasTableAdapter
    Friend WithEvents dt_Itens_PropostasTableAdapter As Eurolift_Services.db_eurolift_sgtDataSetTableAdapters.dt_Itens_PropostasTableAdapter
    Friend WithEvents Db_eurolift_sgtDataSet1 As db_eurolift_sgtDataSet
    Friend WithEvents DtPecasBindingSource As BindingSource
    Friend WithEvents Dt_PecasTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_PecasTableAdapter
    Friend WithEvents DtPropostasBindingSource As BindingSource
    Friend WithEvents DtServicosBindingSource As BindingSource
    Friend WithEvents Dt_ServicosTableAdapter As db_eurolift_sgtDataSetTableAdapters.dt_ServicosTableAdapter
End Class
