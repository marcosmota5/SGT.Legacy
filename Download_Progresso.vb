Imports System.ComponentModel
Imports System.Net

Public Class Download_Progresso
    Dim client As WebClient = New WebClient()

    Private Sub Download_Progresso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim remoteUri As String = "https://www.proreports.com.br/proreports_sgt_eurolift/SGT.msi"
        Dim fileName As String = Environ("TEMP") & "\SGT\Instaladores\SGT.msi"
        Dim username As String = "proreports_sgt_eurolift"
        Dim password As String = "mo?2vbC@!)wQ"
        pgb_Download.Minimum = 0
        pgb_Download.Maximum = 100

        Dim remoteUri2 As String = "https://www.proreports.com.br/proreports_sgt_eurolift/execute_sgt.bat"
        Dim fileName2 As String = Environ("TEMP") & "\SGT\Instaladores\execute_sgt.bat"

        Using client As New WebClient()

            client.Credentials = New NetworkCredential(username, password)
            client.DownloadFile(remoteUri2, fileName2)
        End Using

        DownLoadFileInBackground4(remoteUri, fileName, username, password)
    End Sub
    Public Sub DownLoadFileInBackground4(ByVal address As String, ByVal filename As String, ByVal username As String, ByVal password As String)

        ' Specify a DownloadFileCompleted handler here...
        AddHandler client.DownloadFileCompleted, AddressOf DownloadFileCallback2
        '  Specify a progress notification handler.
        AddHandler client.DownloadProgressChanged, AddressOf DownloadProgressCallback4

        Dim uri As Uri = New Uri(address)
        client.Credentials = New NetworkCredential(username, password)
        client.DownloadFileAsync(uri, filename)

    End Sub

    Private Sub DownloadProgressCallback4(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        pgb_Download.Value = e.ProgressPercentage
        lbl_Progresso_Percentual.Text = e.ProgressPercentage & "%"

    End Sub
    Private Sub DownloadFileCallback2(sender As Object, e As AsyncCompletedEventArgs)

        If e.Cancelled = True And txt_Observacao.Text = "opcional" Then
            Me.Close()
            Exit Sub
        End If

        If Not e.Error Is Nothing Then
            If txt_Observacao.Text = "opcional" Then
                MessageBox.Show("Erro no download de versão opcional. Caso o problema persista, contate o desenvolvedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            Else
                MessageBox.Show("Erro no download de versão crítica. O sistema será fechado. Caso o problema persista, contate o desenvolvedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Environment.Exit(1223)
            End If
        End If

        Process.Start(Environ("TEMP") & "\SGT\Instaladores\execute_sgt.bat")
        Environment.Exit(0)

    End Sub

    Private Sub Download_Progresso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

            If txt_Observacao.Text = "opcional" Then
                If MessageBox.Show(text:="Tem certeza que deseja cancelar o download da nova versão?", caption:="Atenção", buttons:=vbYesNo, icon:=vbInformation) = vbYes Then
                    client.CancelAsync()

                Else
                    e.Cancel = True
                End If
            Else
                If MessageBox.Show(text:="Tem certeza que deseja cancelar o download da nova versão crítica? Caso continue o sistema será fechado", caption:="Atenção", buttons:=vbYesNo, icon:=vbExclamation) = vbYes Then
                    Environment.Exit(1223)
                Else
                    e.Cancel = True
                End If
            End If

        End If
    End Sub
End Class