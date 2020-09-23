Public Class EntTipoCliente

    Private VarIdTipoCliente As Integer
    Private VarDescripcion As String
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarFechaCreacion As Date
    Private VarFechaModificacion As Date
    Private VarIdEstadoActivo As Byte
    Private VarEstadoActivo As String

    Public Property IdTipoCliente As Integer
        Get
            Return VarIdTipoCliente
        End Get
        Set(ByVal value As Integer)
            VarIdTipoCliente = value
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
