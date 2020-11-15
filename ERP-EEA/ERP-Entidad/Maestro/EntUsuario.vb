Public Class EntUsuario

    Private VarIdUsuario As Integer
    Private VarNombreCompleto As String
    Private VarNombreUsuario As String
    Private VarContraseña As String
    Private VarFechaCreacion As Date
    Private VarFechaModificacion As Date
    Private VarEstadoActivo As String
    Private VarEstadoId As Byte

    Public Property IdUsuario As Integer
        Get
            Return VarIdUsuario
        End Get
        Set(value As Integer)
            VarIdUsuario = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return VarNombreCompleto
        End Get
        Set(value As String)
            VarNombreCompleto = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return VarNombreUsuario
        End Get
        Set(value As String)
            VarNombreUsuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return VarContraseña
        End Get
        Set(value As String)
            VarContraseña = value
        End Set
    End Property

    Public Property FechaCreacion As Date
        Get
            Return VarFechaCreacion
        End Get
        Set(ByVal value As Date)
            VarFechaCreacion = value
        End Set
    End Property

    Public Property FechaModificacion As Date
        Get
            Return VarFechaModificacion
        End Get
        Set(ByVal value As Date)
            VarFechaModificacion = value
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

    Public Property EstadoId As Byte
        Get
            Return VarEstadoId
        End Get
        Set(ByVal value As Byte)
            VarEstadoId = value
        End Set
    End Property
End Class
