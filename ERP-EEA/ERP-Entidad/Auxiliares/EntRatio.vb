Public Class EntRatio
    Private VarIdRatio As Integer
    Private VarTipoRatioId As Integer
    Private VarValor As Decimal
    Private VarPeriodoId As Integer
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte


    Public Property IdRatio As Integer
        Get
            Return VarIdRatio
        End Get
        Set(value As Integer)
            VarIdRatio = value
        End Set
    End Property

    Public Property TipoRatioId As Integer
        Get
            Return VarTipoRatioId
        End Get
        Set(ByVal value As Integer)
            VarTipoRatioId = value
        End Set
    End Property

    Public Property Valor As Decimal
        Get
            Return VarValor
        End Get
        Set(ByVal value As Decimal)
            VarValor = value
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

