<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Alteracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Alteracoes))
        Me.trv_Registro_Alteracoes = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'trv_Registro_Alteracoes
        '
        Me.trv_Registro_Alteracoes.Location = New System.Drawing.Point(12, 12)
        Me.trv_Registro_Alteracoes.Name = "trv_Registro_Alteracoes"
        Me.trv_Registro_Alteracoes.Size = New System.Drawing.Size(776, 426)
        Me.trv_Registro_Alteracoes.TabIndex = 5
        '
        'Registro_Alteracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.trv_Registro_Alteracoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Alteracoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de alterações"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents trv_Registro_Alteracoes As TreeView
End Class
