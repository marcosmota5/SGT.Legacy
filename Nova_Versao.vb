Imports MySql.Data.MySqlClient
Public Class Nova_Versao
    Private Sub Nova_Versao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "data_lancamento", "   Data de lançamento: " & dRow("data_lancamento").ToString)
                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "critica", "   Crítica: " & crit)

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "espaco2", "")

                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_versao").ToString & "alteracoes", ">Alterações efetuadas")

            Next

            adapter = New MySqlDataAdapter("SELECT * FROM tb_registro_alteracoes ORDER BY id_registro_alteracao ASC", strConexaoProreports)

            adapter.Fill(dtb_alteracoes)

            For Each dRow As DataRow In dtb_alteracoes.Rows
                trv_Registro_Alteracoes.Nodes(dRow("id_versao").ToString).Nodes.Add(dRow("id_registro_alteracao").ToString, "   " & dRow("descricao").ToString)
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

    Private Sub btn_Instalar_Click(sender As Object, e As EventArgs) Handles btn_Instalar.Click

        If CREATE_FOLDER(Environ("TEMP") & "\SGT\Instaladores") = False Then
            MessageBox.Show("Não foi possível criar a pasta para salvar o instalador. Por favor, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Hide()
        Dim aform = New Download_Progresso
        aform.txt_Observacao.Text = txt_tipo_versao.Text
        aform.ShowDialog()

    End Sub

    Private Sub Nova_Versao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

            If txt_tipo_versao.Text = "crítica" Then
                Environment.Exit(1223)
            End If

        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        If txt_tipo_versao.Text = "crítica" Then
            Environment.Exit(1223)
        Else
            Me.Close()
        End If
    End Sub
End Class