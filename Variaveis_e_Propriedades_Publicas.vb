Module Variaveis_e_Propriedades_Publicas
    'Variáveis
    Public dtbItens As New DataTable
    Public dtbComenatarios As New DataTable
    Public dtbImagens As New DataTable
    Public dtbHistorico As New DataTable

    'Enums
    Public Enum Registry_Values
        CurrentUserId = 1
        InstallPath = 2
        VersionId = 3
        SelectedSignaturePath = 4
        StockFolder = 5
        LastSelectedFolder = 6
        SelectedQuotationsFolderSupplier1 = 7
        SelectedQuotationsFolderSupplier2 = 8
        SelectedQuotationsFolderSupplier3 = 9
        StockFile = 10
        StockSheet = 11
        StockPassword = 12
        DaysAmount = 13
        SelectedReplyEmailFolder = 14
        AutoRefreshDashboard = 15
        AutoRefreshDashboardSeconds = 16
        ResultsLimit = 17
    End Enum

    'Propriedades
    Private int_id_usuario_INT As Integer
    Private str_nome_usuario_STR As String
    Private str_login_usuario_STR As String
    Private str_email_usuario_STR As String
    Private int_id_perfil_INT As Integer
    Private str_nome_perfil_STR As String
    Private int_id_filial_INT As Integer
    Private str_nome_filial_STR As String
    Private int_id_pais_INT As Integer
    Private str_nome_pais_STR As String
    Private int_id_estado_INT As Integer
    Private str_nome_estado_STR As String
    Private int_id_cidade_INT As Integer
    Private str_nome_cidade_STR As String
    Private int_id_proposta_INT As Integer
    Private int_id_tipo_item_INT As Integer
    Private int_id_fornecedor_INT As Integer
    Private int_linha_item_INT As Integer
    Private int_id_registro_manifestacao_INT As Integer
    Private int_tipo_inserir_frete_INT As Integer
    Private str_exibir_codigo_STR As String
    Private str_codigo_recuperacao_STR As String
    Private int_temp_id_usuario_INT As Integer
    Private int_id_cliente_INT As Integer
    Private int_id_termo_INT As Integer
    Private str_exibir_NCM_STR As String
    Private int_id_setor_INT As Integer
    Private str_nome_setor_STR As String
    Private str_coluna_desconto_STR As String
    Private int_id_tipo_item_desconto_INT As Integer

    Public Property get_temp_id_usuario() As Integer
        Get
            Return int_temp_id_usuario_INT
        End Get
        Set(ByVal int_temp_id_usuario As Integer)
            int_temp_id_usuario_INT = int_temp_id_usuario
        End Set
    End Property
    Public Property get_codigo_recuperacao() As String
        Get
            Return str_codigo_recuperacao_STR
        End Get
        Set(ByVal str_codigo_recuperacao As String)
            str_codigo_recuperacao_STR = str_codigo_recuperacao
        End Set
    End Property
    Public Property get_exibir_NCM() As String
        Get
            Return str_exibir_NCM_STR
        End Get
        Set(ByVal str_exibir_NCM As String)
            str_exibir_NCM_STR = str_exibir_NCM
        End Set
    End Property
    Public Property get_exibir_codigo() As String
        Get
            Return str_exibir_codigo_STR
        End Get
        Set(ByVal str_exibir_codigo As String)
            str_exibir_codigo_STR = str_exibir_codigo
        End Set
    End Property
    Public Property get_tipo_inserir_frete() As Integer
        Get
            Return int_tipo_inserir_frete_INT
        End Get
        Set(ByVal int_tipo_inserir_frete As Integer)
            int_tipo_inserir_frete_INT = int_tipo_inserir_frete
        End Set
    End Property

    Public Property get_linha_item() As Integer
        Get
            Return int_linha_item_INT
        End Get
        Set(ByVal int_linha_item As Integer)
            int_linha_item_INT = int_linha_item
        End Set
    End Property
    Public Property get_id_registro_manifestacao() As Integer
        Get
            Return int_id_registro_manifestacao_INT
        End Get
        Set(ByVal int_id_registro_manifestacao As Integer)
            int_id_registro_manifestacao_INT = int_id_registro_manifestacao
        End Set
    End Property
    Public Property get_id_fornecedor() As Integer
        Get
            Return int_id_fornecedor_INT
        End Get
        Set(ByVal int_id_fornecedor As Integer)
            int_id_fornecedor_INT = int_id_fornecedor
        End Set
    End Property

    Public Property get_id_tipo_item() As Integer
        Get
            Return int_id_tipo_item_INT
        End Get
        Set(ByVal int_id_tipo_item As Integer)
            int_id_tipo_item_INT = int_id_tipo_item
        End Set
    End Property
    Public Property get_id_tipo_item_desconto() As Integer
        Get
            Return int_id_tipo_item_desconto_INT
        End Get
        Set(ByVal int_id_tipo_item_desconto As Integer)
            int_id_tipo_item_desconto_INT = int_id_tipo_item_desconto
        End Set
    End Property

    Public Property get_id_usuario() As Integer
        Get
            Return int_id_usuario_INT
        End Get
        Set(ByVal int_id_usuario As Integer)
            int_id_usuario_INT = int_id_usuario
        End Set
    End Property

    Public Property get_nome_usuario() As String
        Get
            Return str_nome_usuario_STR
        End Get
        Set(ByVal str_nome_usuario As String)
            str_nome_usuario_STR = str_nome_usuario
        End Set
    End Property

    Public Property get_login_usuario() As String
        Get
            Return str_login_usuario_STR
        End Get
        Set(ByVal str_login_usuario As String)
            str_login_usuario_STR = str_login_usuario
        End Set
    End Property

    Public Property get_email_usuario() As String
        Get
            Return str_email_usuario_STR
        End Get
        Set(ByVal str_email_usuario As String)
            str_email_usuario_STR = str_email_usuario
        End Set
    End Property

    Public Property get_id_perfil() As Integer
        Get
            Return int_id_perfil_INT
        End Get
        Set(ByVal int_id_perfil As Integer)
            int_id_perfil_INT = int_id_perfil
        End Set
    End Property

    Public Property get_nome_perfil() As String
        Get
            Return str_nome_perfil_STR
        End Get
        Set(ByVal str_nome_perfil As String)
            str_nome_perfil_STR = str_nome_perfil
        End Set
    End Property

    Public Property get_id_setor() As Integer
        Get
            Return int_id_setor_INT
        End Get
        Set(ByVal int_id_setor As Integer)
            int_id_setor_INT = int_id_setor
        End Set
    End Property

    Public Property get_nome_setor() As String
        Get
            Return str_nome_setor_STR
        End Get
        Set(ByVal str_nome_setor As String)
            str_nome_setor_STR = str_nome_setor
        End Set
    End Property
    Public Property get_coluna_desconto() As String
        Get
            Return str_coluna_desconto_STR
        End Get
        Set(ByVal str_coluna_desconto As String)
            str_coluna_desconto_STR = str_coluna_desconto
        End Set
    End Property

    Public Property get_id_filial() As Integer
        Get
            Return int_id_filial_INT
        End Get
        Set(ByVal int_id_filial As Integer)
            int_id_filial_INT = int_id_filial
        End Set
    End Property

    Public Property get_nome_filial() As String
        Get
            Return str_nome_filial_STR
        End Get
        Set(ByVal str_nome_filial As String)
            str_nome_filial_STR = str_nome_filial
        End Set
    End Property

    Public Property get_id_pais() As Integer
        Get
            Return int_id_pais_INT
        End Get
        Set(ByVal int_id_pais As Integer)
            int_id_pais_INT = int_id_pais
        End Set
    End Property

    Public Property get_nome_pais() As String
        Get
            Return str_nome_pais_STR
        End Get
        Set(ByVal str_nome_pais As String)
            str_nome_pais_STR = str_nome_pais
        End Set
    End Property

    Public Property get_id_estado() As Integer
        Get
            Return int_id_estado_INT
        End Get
        Set(ByVal int_id_estado As Integer)
            int_id_estado_INT = int_id_estado
        End Set
    End Property

    Public Property get_nome_estado() As String
        Get
            Return str_nome_estado_STR
        End Get
        Set(ByVal str_nome_estado As String)
            str_nome_estado_STR = str_nome_estado
        End Set
    End Property

    Public Property get_id_cidade() As Integer
        Get
            Return int_id_cidade_INT
        End Get
        Set(ByVal int_id_cidade As Integer)
            int_id_cidade_INT = int_id_cidade
        End Set
    End Property

    Public Property get_nome_cidade() As String
        Get
            Return str_nome_cidade_STR
        End Get
        Set(ByVal str_nome_cidade As String)
            str_nome_cidade_STR = str_nome_cidade
        End Set
    End Property

    Public Property get_id_proposta() As Integer
        Get
            Return int_id_proposta_INT
        End Get
        Set(ByVal int_id_proposta As Integer)
            int_id_proposta_INT = int_id_proposta
        End Set
    End Property
    Public Property get_id_cliente() As Integer
        Get
            Return int_id_cliente_INT
        End Get
        Set(ByVal int_id_cliente As Integer)
            int_id_cliente_INT = int_id_cliente
        End Set
    End Property

    Public Property get_id_termo() As Integer
        Get
            Return int_id_termo_INT
        End Get
        Set(ByVal int_id_termo As Integer)
            int_id_termo_INT = int_id_termo
        End Set
    End Property

End Module
