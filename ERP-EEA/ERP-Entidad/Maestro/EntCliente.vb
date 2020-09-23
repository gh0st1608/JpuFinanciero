Public Class EntCliente
    Private VarIdCliente As Integer
    Private VarTipoCliente As String
    Private VarTipoClienteId As Integer
    Private VarRazonSocial As String
    Private VarDocumento As String
    Private VarDescripcion As String
    Private VarMetaEntidad As Integer
    Private VarMetaEmpresa As Integer
    Private VarCorreo As String
    Private VarNumeroContacto As String
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarIdEstadoActivo As Byte
    Private VarEstadoActivo As String


    Public Property IdCliente As Integer
        Get
            Return VarIdCliente
        End Get
        Set(ByVal value As Integer)
            VarIdCliente = value
        End Set
    End Property

    Public Property TipoCliente As String
        Get
            Return VarTipoCliente
        End Get
        Set(ByVal value As String)
            VarTipoCliente = value
        End Set
    End Property
    Public Property TipoClienteId As Integer
        Get
            Return VarTipoClienteId
        End Get
        Set(ByVal value As Integer)
            VarTipoClienteId = value
        End Set
    End Property

    Public Property RazonSocial As String
        Get
            Return VarRazonSocial
        End Get
        Set(ByVal value As String)
            VarRazonSocial = value
        End Set
    End Property

    Public Property Documento As String
        Get
            Return VarDocumento
        End Get
        Set(ByVal value As String)
            VarDocumento = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return VarDescripcion
        End Get
        Set(ByVal value As String)
            VarDescripcion = value
        End Set
    End Property

    Public Property MetaEntidad As Integer
        Get
            Return VarMetaEntidad
        End Get
        Set(ByVal value As Integer)
            VarMetaEntidad = value
        End Set
    End Property

    Public Property MetaEmpresa As Integer
        Get
            Return VarMetaEmpresa
        End Get
        Set(ByVal value As Integer)
            VarMetaEmpresa = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return VarCorreo
        End Get
        Set(ByVal value As String)
            VarCorreo = value
        End Set
    End Property

    Public Property NumeroContacto As String
        Get
            Return VarNumeroContacto
        End Get
        Set(ByVal value As String)
            VarNumeroContacto = value
        End Set
    End Property

    Public Property UsuarioCreacionId As Integer
        Get
            Return VarUsuarioCreacionId
        End Get
        Set(ByVal value As Integer)
            VarUsuarioCreacionId = value
        End Set
    End Property

    Public Property UsuarioModificacionId As Integer
        Get
            Return VarUsuarioModificacionId
        End Get
        Set(ByVal value As Integer)
            VarUsuarioModificacionId = value
        End Set
    End Property



    Public Property IdEstadoActivo As Byte
        Get
            Return VarIdEstadoActivo
        End Get
        Set(ByVal value As Byte)
            VarIdEstadoActivo = value
        End Set
    End Property

    Public Property EstadoActivo As String
        Get
            Return VarEstadoActivo
        End Get
        Set(ByVal value As String)
            VarEstadoActivo = value
        End Set
    End Property

End Class
