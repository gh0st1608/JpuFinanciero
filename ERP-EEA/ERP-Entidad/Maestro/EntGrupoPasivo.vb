Public Class EntGrupoPasivo
    Private VarIdGrupoPasivo As Integer
    Private VarIdTipo As Integer
    Private VarTipo As String
    Private VarDescripcion As String
    Private VarCuenta As Integer
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarIdEstadoActivo As Integer
    Private VarEstadoActivo As String

    Public Property IdGrupoPasivo As Integer
        Get
            Return VarIdGrupoPasivo
        End Get
        Set(value As Integer)
            VarIdGrupoPasivo = value
        End Set
    End Property

    Public Property IdTipo As Integer
        Get
            Return VarIdTipo
        End Get
        Set(value As Integer)
            VarIdTipo = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return VarTipo
        End Get
        Set(value As String)
            VarTipo = value
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

    Public Property Cuenta As Integer
        Get
            Return VarCuenta
        End Get
        Set(value As Integer)
            VarCuenta = value
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

    Public Property IdEstadoActivo As Integer
        Get
            Return VarIdEstadoActivo
        End Get
        Set(ByVal value As Integer)
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
