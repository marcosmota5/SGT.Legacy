Imports MySql.Data.MySqlClient

Public Class Proposta_Gerada
    Private Sub Proposta_Gerada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_eurolift_sgtDataSet1.dt_Servicos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_ServicosTableAdapter.Fill(Me.Db_eurolift_sgtDataSet1.dt_Servicos)
        'TODO: esta linha de código carrega dados na tabela 'Db_eurolift_sgtDataSet1.dt_Propostas'. Você pode movê-la ou removê-la conforme necessário.
        Me.dt_PropostasTableAdapter.Fill(Me.Db_eurolift_sgtDataSet1.dt_Propostas)
        'TODO: esta linha de código carrega dados na tabela 'Db_eurolift_sgtDataSet1.dt_Pecas'. Você pode movê-la ou removê-la conforme necessário.
        Me.Dt_PecasTableAdapter.Fill(Me.Db_eurolift_sgtDataSet1.dt_Pecas)

    End Sub
End Class