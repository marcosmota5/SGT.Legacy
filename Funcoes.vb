Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.CompilerServices
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Module Funcoes
    Function GET_RANDOM_CODE(Code_Length As Integer) As String

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To Code_Length
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()

    End Function

    Public Function SEND_EMAIL(mailTo As String, mailSubject As String, htmlBody As String, Optional mailCC As String = "", Optional mailAttachments As String = "") As Boolean

        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New _
            Net.NetworkCredential("sgt@euroliftempilhadeiras.com.br", "U74sH,;_f@{y")
            SmtpServer.Port = 587
            SmtpServer.Host = "mail.euroliftempilhadeiras.com.br"


            mail = New MailMessage()
            mail.From = New MailAddress("sgt@euroliftempilhadeiras.com.br")
            mail.To.Add(mailTo)
            If Not String.IsNullOrEmpty(mailCC) Then
                mail.CC.Add(mailCC)
            End If
            mail.Subject = mailSubject
            mail.IsBodyHtml = True
            mail.Body = htmlBody

            If Not String.IsNullOrEmpty(mailAttachments) Then
                Dim attachments() As String
                attachments = Split(mailAttachments, "|")

                For i As Integer = LBound(attachments) To UBound(attachments)
                    mail.Attachments.Add(New Attachment(attachments(i)))
                Next

            End If

            SmtpServer.Send(mail)
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar email. Detalhes: " + ex.Message + ex.StackTrace)
            Return False
        End Try

    End Function

    Public Function CONVERT_TO_INTEGER(ByVal ValueToConvert As String) As Integer
        Try
            If String.IsNullOrEmpty(ValueToConvert) Then
                Return 0
            Else
                Return Integer.Parse(ValueToConvert)
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function CONVERT_TO_LONG(ByVal ValueToConvert As String) As Long
        Try
            If String.IsNullOrEmpty(ValueToConvert) Then
                Return 0
            Else
                Return Long.Parse(ValueToConvert)
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function CONVERT_TO_DECIMAL(ByVal ValueToConvert As String) As Decimal
        Try
            If String.IsNullOrEmpty(ValueToConvert) Then
                Return 0.0
            Else
                Return Decimal.Parse(ValueToConvert)
            End If
        Catch ex As Exception
            Return 0.0
        End Try
    End Function
    Public Function CONVERT_TO_DOUBLE(ByVal ValueToConvert As String) As Double
        Try
            If String.IsNullOrEmpty(ValueToConvert) Then
                Return 0.0
            Else
                Return Double.Parse(ValueToConvert)
            End If
        Catch ex As Exception
            Return 0.0
        End Try
    End Function

    Public Function CONVERT_TO_DATE(ByVal ValueToConvert As String) As Date
        Try
            If String.IsNullOrEmpty(ValueToConvert) Then
                Return Nothing
            Else
                Return Date.Parse(ValueToConvert)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CONVERT_TO_STRING(ByVal ValueToConvert As Object) As String
        Try
            If IsNothing(ValueToConvert) Then
                Return ""
            End If
            Return ValueToConvert.ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function REMOVE_MASK(ByVal Masked_Text_Box As MaskedTextBox) As String
        Masked_Text_Box.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        Dim retString As String = Masked_Text_Box.Text
        Masked_Text_Box.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        Return retString
    End Function

    Function CHECK_PASSWORD_STRENGTH(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Public Function CHECK_EMAIL(ByVal email As String) As Boolean
        Try
            Dim addr = New MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Public Function CONVERT_TO_LETTER(iCol As Long) As String
        Dim a As Long
        Dim b As Long
        a = iCol
        CONVERT_TO_LETTER = ""
        Do While iCol > 0
            a = Int((iCol - 1) / 26)
            b = (iCol - 1) Mod 26
            CONVERT_TO_LETTER = Chr(b + 65) & CONVERT_TO_LETTER
            iCol = a
        Loop
    End Function

    Enum Part_Word_Text

        First_Word = 1
        Mid_Word = 2
        Last_Word = 3
        First_Last_Word = 4

    End Enum
    Public Function GET_WORD(Text As String, Optional Separator As String = " ", Optional Position As Part_Word_Text = Part_Word_Text.First_Word) As String

        Dim vgword() As String
        Dim fWord As String
        Dim mWord As String
        Dim lWord As String

        vgword = Split(Text, Separator)
        fWord = vgword(LBound(vgword))
        mWord = vgword(Int(UBound(vgword) / 2))
        lWord = vgword(UBound(vgword))

        Select Case Position

            Case Part_Word_Text.First_Word
                Return fWord

            Case Part_Word_Text.Mid_Word
                If mWord = fWord Then
                    Return ""
                Else
                    Return mWord
                End If

            Case Part_Word_Text.Last_Word
                If lWord = fWord Or lWord = mWord Then
                    Return ""
                Else
                    Return lWord
                End If
            Case Part_Word_Text.First_Last_Word
                If lWord = fWord Then
                    Return fWord
                Else
                    Return fWord & " " & lWord
                End If

        End Select

        Return ""

    End Function

    Public Function DIVIDE(numerator As Decimal, denominator As Decimal, Optional alternativeresult As Decimal = 0) As Decimal

        Try
            Return numerator / denominator
        Catch ex As DivideByZeroException
            Return alternativeresult
        End Try

    End Function

    Public Function FILE_EXISTS(ByVal FileToTest As String) As Boolean

        Try
            Return (Dir(FileToTest, FileAttribute.Archive) <> "")
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function FOLDER_EXISTS(ByVal PathToTest As String) As Boolean

        Try
            Return (Dir(PathToTest, FileAttribute.Directory) <> "")
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function CREATE_FOLDER(ByVal FolderPath As String) As Boolean

        Try

            If FOLDER_EXISTS(FolderPath) = False Then
                System.IO.Directory.CreateDirectory(FolderPath)
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function IS_WORKBOOK_OPEN(WorkbookName As String) As Boolean

        Dim elApp As New Microsoft.Office.Interop.Excel.Application()
        Dim isAlreadyOpen As Boolean = True

        Try
            Dim tmp As String = elApp.Workbooks(WorkbookName).Name
        Catch theException As Exception
            isAlreadyOpen = False
        End Try

        elApp.Quit()
        elApp = Nothing

        Return isAlreadyOpen
    End Function

    Public Function REMOVE_CODES_IN_DESCRIPTION(ByVal strDescription As String) As String

        Dim arrRemove() As String = Split("(CÓD,( CÓD,(COD,( COD,(CÃ?,( CÃ?", ",")
        Dim tmpText As String = strDescription

        For x As Integer = LBound(arrRemove) To UBound(arrRemove)
            If InStr(tmpText, arrRemove(x)) > 0 Then tmpText = Strings.Trim(Left(tmpText, InStr(tmpText, arrRemove(x)) - 1))
        Next

        Return tmpText

    End Function

    Public Function NUMBERS_FROM_STRING(ByVal strText As String) As Long

        Dim myChars() As Char = strText.ToCharArray()
        Dim strTextNumbers As String = ""

        For Each ch As Char In myChars
            If Char.IsDigit(ch) Then
                strTextNumbers = strTextNumbers & ch.ToString
            End If
        Next

        If String.IsNullOrEmpty(strTextNumbers) Then
            Return 0
        Else
            Return Long.Parse(strTextNumbers)
        End If

    End Function

    Public Function DECIMAL_NUMBERS_FROM_STRING(ByVal strText As String) As Decimal

        Dim myChars() As Char = strText.ToCharArray()
        Dim strTextNumbers As String = ""

        For Each ch As Char In myChars
            If Char.IsDigit(ch) Or ch.ToString = "." Or ch.ToString = "," Then
                strTextNumbers = strTextNumbers & ch.ToString
            End If
        Next

        If String.IsNullOrEmpty(strTextNumbers) Then
            Return 0
        Else
            Return Decimal.Parse(strTextNumbers)
        End If

    End Function

    Public Function GET_REGISTRY_VALUE(valueName As Registry_Values) As Object

        Dim strSubKey As String = ""
        Dim strValueKey As String = ""
        Dim keyKind As New Microsoft.Win32.RegistryValueKind
        Dim defaultValue As Object = Nothing

        Try

            Select Case valueName
                Case Registry_Values.CurrentUserId
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "CurrentUserId"
                    keyKind = Microsoft.Win32.RegistryValueKind.DWord
                    defaultValue = 0
                Case Registry_Values.InstallPath
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "InstallPath"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = Environment.GetEnvironmentVariable("ProgramW6432") & "\SGT"
                Case Registry_Values.VersionId
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "VersionId"
                    keyKind = Microsoft.Win32.RegistryValueKind.DWord
                    defaultValue = 1
                Case Registry_Values.SelectedSignaturePath
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "SelectedSignaturePath"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = System.IO.Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") & "\Microsoft\Signatures", "*.htm").First
                Case Registry_Values.StockFolder
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "StockFolder"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                Case Registry_Values.StockFile
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "StockFile"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = "CONTROLE DE ESTOQUE"
                Case Registry_Values.StockSheet
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "StockSheet"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = "ESTOQUE DE REVENDA"
                Case Registry_Values.StockPassword
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "StockPassword"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = ""
                Case Registry_Values.DaysAmount
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "DaysAmount"
                    keyKind = Microsoft.Win32.RegistryValueKind.DWord
                    defaultValue = 4
                Case Registry_Values.LastSelectedFolder
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "LastSelectedFolder"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                Case Registry_Values.SelectedQuotationsFolderSupplier1
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "SelectedQuotationsFolderSupplier1"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = ""
                Case Registry_Values.SelectedQuotationsFolderSupplier2
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "SelectedQuotationsFolderSupplier2"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = ""
                Case Registry_Values.SelectedQuotationsFolderSupplier3
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "SelectedQuotationsFolderSupplier3"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = ""
                Case Registry_Values.SelectedReplyEmailFolder
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "SelectedReplyEmailFolder"
                    keyKind = Microsoft.Win32.RegistryValueKind.String
                    defaultValue = ""
                Case Registry_Values.AutoRefreshDashboard
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "AutoRefreshDashboard"
                    keyKind = Microsoft.Win32.RegistryValueKind.DWord
                    defaultValue = 1
                Case Registry_Values.AutoRefreshDashboardSeconds
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "AutoRefreshDashboardSeconds"
                    keyKind = Microsoft.Win32.RegistryValueKind.DWord
                    defaultValue = 300
                Case Registry_Values.ResultsLimit
                    strSubKey = "Software\SGT\Settings"
                    strValueKey = "ResultsLimit"
                    keyKind = Microsoft.Win32.RegistryValueKind.DWord
                    defaultValue = 500
            End Select

            If REGKEY_EXISTS(strSubKey) = False Then
                My.Computer.Registry.CurrentUser.CreateSubKey(strSubKey, True)
            End If

            If REGKEYVALUE_EXISTS(strSubKey, strValueKey) = False Then
                My.Computer.Registry.CurrentUser.OpenSubKey(strSubKey, True).SetValue(strValueKey, defaultValue, keyKind)
            End If

            Return My.Computer.Registry.CurrentUser.OpenSubKey(strSubKey, True).GetValue(strValueKey)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function REGKEY_EXISTS(ByVal keyName As String) As Boolean
        Try
            If My.Computer.Registry.CurrentUser.OpenSubKey(keyName, True) Is Nothing Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function REGKEYVALUE_EXISTS(ByVal keyName As String, ByVal valueName As String) As Boolean
        Try
            If My.Computer.Registry.CurrentUser.OpenSubKey(keyName, True).GetValue(valueName) Is Nothing Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GET_LAST_STOCK_FILE(ByVal stockFolder As String, ByVal searchFileName As String) As String
        ' Return System.IO.Directory.GetFiles(stockFolder, searchFileName).Last

        Try

            Dim directoryInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(stockFolder)
            If directoryInfo Is Nothing OrElse Not directoryInfo.Exists Then Return ""
            Dim files As System.IO.FileInfo() = directoryInfo.GetFiles(searchFileName)
            Dim recentWrite As DateTime = DateTime.MinValue
            Dim recentFile As System.IO.FileInfo = Nothing

            For Each file As System.IO.FileInfo In files

                If file.LastWriteTime > recentWrite And Strings.Left(file.Name, 2) <> "~$" Then
                    recentWrite = file.LastWriteTime
                    recentFile = file
                End If
            Next

            If recentFile Is Nothing Then
                Return ""
            End If

            Return recentFile.FullName


        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GET_STOCK_FILE() As String
        Dim resultmsg As MsgBoxResult = vbYes
        Dim fil As String = ""

        Try

            If CONVERT_TO_STRING(GET_LAST_STOCK_FILE(CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFolder)), "*" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFile)) & "*")) = "" Then

                Do Until Not String.IsNullOrEmpty(CONVERT_TO_STRING(GET_LAST_STOCK_FILE(CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFolder)), "*" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFile)) & "*"))) Or resultmsg = vbNo
                    resultmsg = MessageBox.Show(text:="Nenhuma planilha de estoque encontrada na pasta '" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFolder)) & "'. Deseja selecionar outra pasta de estoque?" & vbNewLine & vbNewLine & "Lembre-se que as planilhas de estoque devem conter o nome '" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFile)), caption:="Estoque não econtrado", buttons:=vbYesNo, icon:=vbExclamation)
                    If resultmsg = vbYes Then
                        Using FBD As New FolderBrowserDialog
                            If FBD.ShowDialog = DialogResult.OK Then
                                Dim strFile As String = FBD.SelectedPath
                                Set_Registry_Value(Registry_Values.StockFolder, strFile)
                                'If CONVERT_TO_STRING(GET_LAST_STOCK_FILE(CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFolder)), "*" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFile)) & "*")) = "" Then
                                'GET_STOCK_FILE()
                                '  End If
                                fil = CONVERT_TO_STRING(GET_LAST_STOCK_FILE(CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFolder)), "*" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFile)) & "*"))
                            Else
                                fil = ""
                            End If
                        End Using
                    Else
                        fil = ""
                    End If
                Loop
                Return fil
            End If
            Return CONVERT_TO_STRING(GET_LAST_STOCK_FILE(CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFolder)), "*" & CONVERT_TO_STRING(GET_REGISTRY_VALUE(Registry_Values.StockFile)) & "*"))
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GET_DATA_MYSQL(nome_tabela As String, Optional colunas As String = "*", Optional condicoes As String = "", Optional ordenar_por As String = "", Optional juncao_interna As String = "", Optional Limite As String = "", Optional agrupar_por As String = "") As String

        Dim sqlcmd As MySqlCommand
        Dim cond As String = ""
        Dim od As String = ""
        Dim ij As String = ""
        Dim lm As String = ""
        Dim grp As String = ""

        If condicoes <> "" Then
            cond = " WHERE " & condicoes
        End If

        If ordenar_por <> "" Then
            od = " ORDER BY " & ordenar_por
        End If

        If juncao_interna <> "" Then
            ij = " LEFT JOIN " & juncao_interna
        End If

        If Limite <> "" Then
            lm = " LIMIT " & Limite
        End If

        If agrupar_por <> "" Then
            grp = " GROUP BY " & agrupar_por
        End If

        Try

            Abrir_Conexao()
            sqlcmd = New MySqlCommand("SELECT " & colunas & " FROM " & nome_tabela & ij & cond & grp & od & lm, strConexao)
            sqlcmd.CommandType = CommandType.Text
            Dim cmdreader As MySqlDataReader = sqlcmd.ExecuteReader()
            Dim tmpvl As String = ""
            While cmdreader.Read()
                tmpvl = cmdreader.GetString(0)
            End While

            cmdreader.Close()

            cmdreader = Nothing

            Return tmpvl

        Catch ex As Exception
            Return ""
        Finally
            Fechar_Conexao()
        End Try

        Return ""

    End Function

    Function REMOVE_CHARACTERS(Caract As String)
        Dim a As String
        Dim b As String
        Dim i As Integer
        Const AccChars = "ŠŽšžŸÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïðñòóôõöùúûüýÿ "
        Const RegChars = "SZszYAAAAAACEEEEIIIIDNOOOOOUUUUYaaaaaaceeeeiiiidnooooouuuuyy."
        For i = 1 To Len(AccChars)
            a = Mid(AccChars, i, 1)
            b = Mid(RegChars, i, 1)
            Caract = Replace(Caract, a, b)
        Next
        REMOVE_CHARACTERS = Caract
    End Function

    Function Verifica_Versao() As String

        Dim dtb As New DataTable
        Dim adapter As MySqlDataAdapter
        Dim tmpversao As String = "Atual;" & My.Application.Info.Version.ToString
        Dim tmpcritica As String = "opcional"
        Dim tmpalteracoes As String = ""

        Try

            Abrir_Conexao_Proreports()

            adapter = New MySqlDataAdapter("SELECT id_versao, nome, e_critica FROM tb_versoes ORDER BY id_versao ASC", strConexaoProreports)

            adapter.Fill(dtb)

            For Each dRow As DataRow In dtb.Rows

                If CONVERT_TO_INTEGER(Replace(dRow("nome").ToString, ".", "")) > CONVERT_TO_INTEGER(Replace(My.Application.Info.Version.ToString, ".", "")) Then

                    If tmpcritica = "opcional" Then
                        If dRow("e_critica") = True Then
                            tmpcritica = "crítica"
                        End If
                    End If

                    tmpversao = "Antiga " & tmpcritica & ";" & dRow("nome").ToString

                End If

            Next

            Return tmpversao

        Catch ex As Exception
            Return "Erro;"
        Finally
            Fechar_Conexao_Proreports()
        End Try

        Return ""


    End Function

End Module