Imports MySql.Data.MySqlClient

Module mConexao

    'Conexão local
    Public strConexao As New MySqlConnection("server=localhost;user id=root;password=Test@12345;persistsecurityinfo=True;database=db")

    'Conexão Eurolift
    'Public strConexao As New MySqlConnection("server=localhost;user id=root;password=Test@12345;persistsecurityinfo=True;database=db")

    Sub Abrir_Conexao()
        If strConexao.State = 0 Then
            strConexao.Open()
        End If
    End Sub

    Sub Fechar_Conexao()
        If strConexao.State = 1 Then
            strConexao.Close()
        End If
    End Sub

End Module