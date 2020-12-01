Public Class EntProyectado
    Private VarIdProyectado As Integer
    Private VarTipoOperacionId As Integer
    Private VarGrupoEgresoId As Integer
    Private VarSubGrupoEgresoId As Integer
    Private VarSubGrupoEgresoDescripcion As String
    Private VarImporteProvision As Decimal
    Private VarPeriodoId As Integer
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte

    Public Property IdProyectado As Integer
        Get
            Return VarIdProyectado
        End Get
        Set(value As Integer)
            VarIdProyectado = value
        End Set
    End Property

    Public Property TipoOperacionId As Integer
        Get
            Return VarTipoOperacionId
        End Get
        Set(value As Integer)
            VarTipoOperacionId = value
        End Set
    End Property

    Public Property GrupoEgresoId As Integer
        Get
            Return VarGrupoEgresoId
        End Get
        Set(value As Integer)
            VarGrupoEgresoId = value
        End Set
    End Property

    Public Property SubGrupoEgresoId As Integer
        Get
            Return VarSubGrupoEgresoId
        End Get
        Set(value As Integer)
            VarSubGrupoEgresoId = value
        End Set
    End Property

    Public Property SubGrupoEgresoDescripcion As String
        Get
            Return VarSubGrupoEgresoDescripcion
        End Get
        Set(value As String)
            VarSubGrupoEgresoDescripcion = value
        End Set
    End Property


    Public Property ImporteProvision As Decimal
        Get
            Return VarImporteProvision
        End Get
        Set(ByVal value As Decimal)
            VarImporteProvision = value
        End Set
    End Property

    Public Property PeriodoId As Integer
        Get
            Return VarPeriodoId
        End Get
        Set(ByVal value As Integer)
            VarPeriodoId = value
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
