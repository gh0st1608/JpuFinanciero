Public Class EntGrupoIngreso

    Private VarIdGrupoIngreso As Integer
    Private VarDescripcion As String
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Integer

    Public Property IdGrupoIngreso As Integer
        Get
            Return VarIdGrupoIngreso
        End Get
        Set(value As Integer)
            VarIdGrupoIngreso = value
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

    Public Property EstadoActivo As Integer
        Get
            Return VarEstadoActivo
        End Get
        Set(ByVal value As Integer)
            VarEstadoActivo = value
        End Set
    End Property


End Class
