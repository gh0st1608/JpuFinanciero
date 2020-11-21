Public Class EntTipoRatio
    Private VarIdTipoRatio As Integer
    Private VarDescripcion As String
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte

    Public Property IdTipoRatio As Integer
        Get
            Return VarIdTipoRatio
        End Get
        Set(ByVal value As Integer)
            VarIdTipoRatio = value
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


    Public Property EstadoActivo As Byte
        Get
            Return VarEstadoActivo
        End Get
        Set(ByVal value As Byte)
            VarEstadoActivo = value
        End Set
    End Property

End Class


