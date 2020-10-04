Public Class EntProveedor
    Private VarIdProveedor As Integer
    Private VarMedicionId As Integer
    Private VarDocumento As String
    Private VarNombreComercial As String
    Private VarRazonSocial As String
    Private VarNumeroContacto As String
    Private VarCorreo As String
    Private VarTarifa As Decimal
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarIdEstadoActivo As Byte
    Private VarEstadoActivo As String


    Public Property IdProveedor As Integer
        Get
            Return VarIdProveedor
        End Get
        Set(value As Integer)
            VarIdProveedor = value
        End Set
    End Property

    Public Property MedicionId As Integer
        Get
            Return VarMedicionId
        End Get
        Set(ByVal value As Integer)
            VarMedicionId = value
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
    Public Property NombreComercial As String
        Get
            Return VarNombreComercial
        End Get
        Set(ByVal value As String)
            VarNombreComercial = value
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

    Public Property NumeroContacto As String
        Get
            Return VarNumeroContacto
        End Get
        Set(ByVal value As String)
            VarNumeroContacto = value
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
    Public Property Tarifa As Decimal
        Get
            Return VarTarifa
        End Get
        Set(ByVal value As Decimal)
            VarTarifa = value
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
