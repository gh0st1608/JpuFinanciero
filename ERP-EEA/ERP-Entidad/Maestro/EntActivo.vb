Public Class EntActivo
    Private VarIdActivo As Integer
    Private VarGrupoActivoId As Integer
    Private VarPeriodoId As Integer
    Private VarMonto As Decimal
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Integer



    Public Property IdActivo As Integer
        Get
            Return VarIdActivo
        End Get
        Set(value As Integer)
            VarIdActivo = value
        End Set
    End Property

    Public Property GrupoActivoId As Integer
        Get
            Return VarGrupoActivoId
        End Get
        Set(value As Integer)
            VarGrupoActivoId = value
        End Set
    End Property

    Public Property PeriodoId As Integer
        Get
            Return VarPeriodoId
        End Get
        Set(value As Integer)
            VarPeriodoId = value
        End Set
    End Property

    Public Property Monto As Decimal
        Get
            Return VarMonto
        End Get
        Set(value As Decimal)
            VarMonto = value
        End Set
    End Property


    Public Property UsuarioCreacionId As Integer
        Get
            Return VarUsuarioCreacionId
        End Get
        Set(value As Integer)
            VarUsuarioCreacionId = value
        End Set
    End Property

    Public Property UsuarioModificacionId As Integer
        Get
            Return VarUsuarioModificacionId
        End Get
        Set(value As Integer)
            VarUsuarioModificacionId = value
        End Set
    End Property

    Public Property EstadoActivo As Integer
        Get
            Return VarEstadoActivo
        End Get
        Set(value As Integer)
            VarEstadoActivo = value
        End Set
    End Property


End Class
