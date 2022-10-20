<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download_Progresso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Download_Progresso))
        Me.pgb_Download = New System.Windows.Forms.ProgressBar()
        Me.lbl_Progresso = New System.Windows.Forms.Label()
        Me.txt_Observacao = New System.Windows.Forms.TextBox()
        Me.lbl_Progresso_Percentual = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pgb_Download
        '
        Me.pgb_Download.Location = New System.Drawing.Point(12, 29)
        Me.pgb_Download.Name = "pgb_Download"
        Me.pgb_Download.Size = New System.Drawing.Size(265, 23)
        Me.pgb_Download.TabIndex = 0
        '
        'lbl_Progresso
        '
        Me.lbl_Progresso.AutoSize = True
        Me.lbl_Progresso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Progresso.Location = New System.Drawing.Point(12, 11)
        Me.lbl_Progresso.Name = "lbl_Progresso"
        Me.lbl_Progresso.Size = New System.Drawing.Size(189, 13)
        Me.lbl_Progresso.TabIndex = 1
        Me.lbl_Progresso.Text = "Efetuando download, aguarde..."
        '
        'txt_Observacao
        '
        Me.txt_Observacao.Location = New System.Drawing.Point(238, 3)
        Me.txt_Observacao.Name = "txt_Observacao"
        Me.txt_Observacao.Size = New System.Drawing.Size(100, 20)
        Me.txt_Observacao.TabIndex = 2
        Me.txt_Observacao.Visible = False
        '
        'lbl_Progresso_Percentual
        '
        Me.lbl_Progresso_Percentual.AutoSize = True
        Me.lbl_Progresso_Percentual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Progresso_Percentual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Progresso_Percentual.Location = New System.Drawing.Point(126, 34)
        Me.lbl_Progresso_Percentual.Name = "lbl_Progresso_Percentual"
        Me.lbl_Progresso_Percentual.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Progresso_Percentual.TabIndex = 3
        Me.lbl_Progresso_Percentual.Text = "0%"
        '
        'Download_Progresso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 64)
        Me.Controls.Add(Me.lbl_Progresso_Percentual)
        Me.Controls.Add(Me.txt_Observacao)
        Me.Controls.Add(Me.lbl_Progresso)
        Me.Controls.Add(Me.pgb_Download)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Download_Progresso"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progresso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pgb_Download As ProgressBar
    Friend WithEvents lbl_Progresso As Label
    Friend WithEvents txt_Observacao As TextBox
    Friend WithEvents lbl_Progresso_Percentual As Label
End Class
