Public Class EntRelacionDebeHaber
    Private VarIdRelacionDebeHaber As Integer
    Private VarTipoOperacionId As Integer
    Private VarEtapaOperacionId As Integer
    Private VarGrupoId As Integer
    Private VarGrupoDebeId As Integer
    Private VarGrupoHaberId As Integer
    Private VarDebeId As Integer
    Private VarHaberId As Integer
    Private VarSignoDebe As Integer
    Private VarSignoHaber As Integer
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarIdEstadoActivo As Byte
    Private VarEstadoActivo As Integer


    Public Property IdRelacionDebeHaber As Integer
        Get
            Return VarIdRelacionDebeHaber
        End Get
        Set(value As Integer)
            VarIdRelacionDebeHaber = value
        End Set
    End Property

    Public Property TipoOperacionId As Integer
        Get
            Return VarTipoOperacionId
        End Get
        Set(ByVal value As Integer)
            VarTipoOperacionId = value
        End Set
    End Property

    Public Property EtapaOperacionId As Integer
        Get
            Return VarEtapaOperacionId
        End Get
        Set(ByVal value As Integer)
            VarEtapaOperacionId = value
        End Set
    End Property


    Public Property GrupoId As Integer
        Get
            Return VarGrupoId
        End Get
        Set(ByVal value As Integer)
            VarGrupoId = value
        End Set
    End Property

    Public Property GrupoDebeId As Integer
        Get
            Return VarGrupoDebeId
        End Get
        Set(ByVal value As Integer)
            VarGrupoDebeId = value
        End Set
    End Property

    Public Property GrupoHaberId As Integer
        Get
            Return VarGrupoHaberId
        End Get
        Set(ByVal value As Integer)
            VarGrupoHaberId = value
        End Set
    End Property

    Public Property DebeId As Integer
        Get
            Return VarDebeId
        End Get
        Set(ByVal value As Integer)
            VarDebeId = value
        End Set
    End Property

    Public Property HaberId As Integer
        Get
            Return VarHaberId
        End Get
        Set(ByVal value As Integer)
            VarHaberId = value
        End Set
    End Property

    Public Property SignoDebe As Integer
        Get
            Return VarSignoDebe
        End Get
        Set(ByVal value As Integer)
            VarSignoDebe = value
        End Set
    End Property

    Public Property SignoHaber As Integer
        Get
            Return VarSignoHaber
        End Get
        Set(ByVal value As Integer)
            VarSignoHaber = value
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

    Public Property EstadoActivo As Integer
        Get
            Return VarEstadoActivo
        End Get
        Set(ByVal value As Integer)
            VarEstadoActivo = value
        End Set
    End Property
End Class
