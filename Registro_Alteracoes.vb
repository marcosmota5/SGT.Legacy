Imports MySql.Data.MySqlClient
Public Class Registro_Alteracoes
    Private Sub Registro_Alteracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim dtb As New DataTable
        Dim dtb_alteracoes As New DataTable
        Dim adapter As MySqlDataAdapter

        Try
            Abrir_Conexao_Proreports()

            adapter = New MySqlDataAdapter("SELECT * FROM tb_versoes ORDER BY id_versao DESC", strConexaoProreports)

            adapter.Fill(dtb)
            Dim crit As String = ""
            For Each dRow As DataRow In dtb.Rows
                If dRow("e_critica").ToString = "True" Then
                    crit = "Sim"
                Else
                    crit = "Não"
                End If
                trv_Registro_Alteracoes.Nodes.Add(dRow("id_versao").ToString, dRow("nome").ToString)

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "detalhes", ">Detalhes da versão")

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "data_lancamento", "Data de lançamento: " & dRow("data_lancamento").ToString)
                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "critica", "Crítica: " & crit)

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "espaco2", "")

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "alteracoes", ">Alterações efetuadas")

            Next

            adapter = New MySqlDataAdapter("SELECT * FROM tb_registro_alteracoes ORDER BY id_registro_alteracao ASC", strConexaoProreports)

            adapter.Fill(dtb_alteracoes)

            For Each dRow As DataRow In dtb_alteracoes.Rows
                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_registro_alteracao").ToString, dRow("descricao").ToString)
            Next

            ' trv_Registro_Alteracoes.scro
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar database. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao_Proreports()
        End Try

        trv_Registro_Alteracoes.SelectedNode = trv_Registro_Alteracoes.Nodes(0)
        trv_Registro_Alteracoes.Nodes(0).Expand()

    End Sub
End Class