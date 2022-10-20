

Partial Class db_eurolift_sgtDataSet
    Partial Public Class dt_GraficosDataTable
        Private Sub dt_GraficosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.data_insercaoColumn.ColumnName) Then
            '    'Adicionar o código do usuário aqui
            'End If

        End Sub

    End Class
End Class

Namespace db_eurolift_sgtDataSetTableAdapters
    Partial Public Class dt_PropostasTableAdapter
    End Class

    Partial Public Class dt_GraficosTableAdapter
    End Class
End Namespace

Namespace db_eurolift_sgtDataSetTableAdapters
    Partial Public Class dt_GraficosTableAdapter
    End Class
End Namespace
