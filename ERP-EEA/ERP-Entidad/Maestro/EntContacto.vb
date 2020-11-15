Public Class EntContacto
    Private VarIdContacto As Integer
    Private VarTipoContactoId As Integer
    Private VarNombreCompleto As String
    Private VarCargo As String
    Private VarCorreo As String
    Private VarCelular As String
    Private VarOrigenId As Integer
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarIdEstadoActivo As Byte
    Private VarEstadoActivo As String


    Public Property IdContacto As Integer
        Get
            Return VarIdContacto
        End Get
        Set(ByVal value As Integer)
            VarIdContacto = value
        End Set
    End Property

    Public Property TipoContactoId As Integer
        Get
            Return VarTipoContactoId
        End Get
        Set(ByVal value As Integer)
            VarTipoContactoId = value
        End Set
    End Property

    Public Property Cargo As String
        Get
            Return VarCargo
        End Get
        Set(ByVal value As String)
            VarCargo = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return VarNombreCompleto
        End Get
        Set(ByVal value As String)
            VarNombreCompleto = value
        End Set
    End Property

    Public Property OrigenId As Integer
        Get
            Return VarOrigenId
        End Get
        Set(ByVal value As Integer)
            VarOrigenId = value
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

    Public Property Celular As String
        Get
            Return VarCelular
        End Get
        Set(ByVal value As String)
            VarCelular = value
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
