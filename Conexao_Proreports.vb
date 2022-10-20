Imports MySql.Data.MySqlClient

Module mConexao_Proreports
    Public strConexaoProreports As New MySqlConnection("server=localhost;user id=root;password=Test@12345;persistsecurityinfo=True;database=db_cloud")

    Sub Abrir_Conexao_Proreports()
        If strConexaoProreports.State = 0 Then
            strConexaoProreports.Open()
        End If
    End Sub

    Sub Fechar_Conexao_Proreports()
        If strConexaoProreports.State = 1 Then
            strConexaoProreports.Close()
        End If
    End Sub

End Module