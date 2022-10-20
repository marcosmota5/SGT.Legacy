Imports System.Configuration
Imports MySql.Data.MySqlClient

Module Subs
    Public Sub Preencher_ComboBox(cbo As ComboBox, nome_tabela As String, valor_membro As String, display_membro As String, Optional colunas As String = "*", Optional condicoes As String = "", Optional ordenar_por As String = "", Optional juncao_interna As String = "", Optional Limite As String = "", Optional agrupar_por As String = "")

        'Preenche combobox
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter
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

            adapter = New MySqlDataAdapter("SELECT " & colunas & " FROM " & nome_tabela & ij & cond & grp & od & lm, strConexao)

            adapter.Fill(ds, nome_tabela)

            cbo.DisplayMember = display_membro
            cbo.ValueMember = valor_membro
            cbo.DataSource = ds.Tables(nome_tabela)

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message + ex.StackTrace)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Public Sub Preencher_DataGridViewComboBoxColumn(cbo As DataGridViewComboBoxColumn, nome_tabela As String, valor_membro As String, display_membro As String, Optional colunas As String = "*", Optional condicoes As String = "", Optional ordenar_por As String = "", Optional juncao_interna As String = "", Optional Limite As String = "", Optional agrupar_por As String = "")

        'Preenche combobox do datagridview
        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter
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

            adapter = New MySqlDataAdapter("SELECT " & colunas & " FROM " & nome_tabela & ij & cond & grp & od & lm, strConexao)

            adapter.Fill(ds, nome_tabela)

            cbo.DisplayMember = display_membro
            cbo.ValueMember = valor_membro
            cbo.DataSource = ds.Tables(nome_tabela)

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Public Sub Preencher_Combobox_Ano(cboAno As ComboBox, ByVal serie As String, id_fabricante As Integer)

        Dim ds As New DataSet
        Dim adapter As MySqlDataAdapter
        Dim ds2 As New DataSet
        Dim adapter2 As MySqlDataAdapter
        Dim posicao As Integer
        Dim caracteres As String = ""
        Dim id_ano As Integer

        Try
            Abrir_Conexao()

            adapter = New MySqlDataAdapter("SELECT posicao_inicio_caracteres, caracteres, id_ano FROM tb_anos WHERE id_status=1 AND ano<" & (Now.Year + 2) & " AND id_fabricante=" & id_fabricante & " ORDER BY ano DESC", strConexao)

            adapter.Fill(ds, "tb_anos")

            Dim col_p As DataColumn = ds.Tables(0).Columns(0)
            Dim col_c As DataColumn = ds.Tables(0).Columns(1)
            Dim col_a As DataColumn = ds.Tables(0).Columns(2)

            For Each row_d As DataRow In ds.Tables(0).Rows
                posicao = CInt(row_d(col_p.ColumnName))
                caracteres = row_d(col_c.ColumnName).ToString
                id_ano = CInt(row_d(col_a.ColumnName))
                Dim lca As Integer = CInt(Strings.Len(caracteres))

                If Strings.Mid(serie, posicao, lca).ToString = caracteres.ToString Then
                    Exit For
                End If

            Next

            If caracteres = "" Then

                If ds.Tables(0).Rows.Count = 0 Then
                    adapter2 = New MySqlDataAdapter("SELECT id_ano, ano FROM tb_anos WHERE id_status=1 AND ano<" & (Now.Year + 2) & " GROUP BY ano ORDER BY ano", strConexao)
                Else
                    adapter2 = New MySqlDataAdapter("SELECT id_ano, ano FROM tb_anos WHERE id_status=1 AND ano<" & (Now.Year + 2) & " AND id_fabricante=" & id_fabricante & " ORDER BY ano", strConexao)
                End If

                adapter2.Fill(ds2, "tb_anos")

                cboAno.DisplayMember = "ano"
                cboAno.ValueMember = "id_ano"
                cboAno.DataSource = ds2.Tables("tb_anos")
                cboAno.SelectedValue = id_ano

            Else

                adapter2 = New MySqlDataAdapter("SELECT id_ano, ano FROM tb_anos WHERE id_status=1 AND id_fabricante=" & id_fabricante & " AND posicao_inicio_caracteres=" & posicao & " AND caracteres='" & caracteres & "' ORDER BY ano", strConexao)

                adapter2.Fill(ds2, "tb_anos")

                cboAno.DisplayMember = "ano"
                cboAno.ValueMember = "id_ano"
                cboAno.DataSource = ds2.Tables("tb_anos")
                cboAno.SelectedValue = id_ano


            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados. Detalhes: " + ex.Message)
        Finally
            Fechar_Conexao()
        End Try

    End Sub

    Public Sub Set_Registry_Value(valueName As Registry_Values, keyValue As Object)

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

            My.Computer.Registry.CurrentUser.OpenSubKey(strSubKey, True).SetValue(strValueKey, keyValue)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'Public Sub EncryptConfigSection()
    '    Dim Config As Configuration
    '    Dim Section As ConfigurationSection

    '    Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '    Section = Config.GetSection("connectionStrings")
    '    If (Section IsNot Nothing) Then

    '        If (Not Section.SectionInformation.IsProtected) Then

    '            If (Not Section.ElementInformation.IsLocked) Then
    '                Section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
    '                Section.SectionInformation.ForceSave = True
    '                Config.Save(ConfigurationSaveMode.Full)
    '            End If
    '        End If
    '    End If

    'End Sub

End Module
