Public Class EntPasivo
    Private VarIdPasivo As Integer
    Private VarGrupoPasivoId As Integer
    Private VarPeriodoId As Integer
    Private VarMonto As Decimal
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Integer



    Public Property IdPasivo As Integer
        Get
            Return VarIdPasivo
        End Get
        Set(value As Integer)
            VarIdPasivo = value
        End Set
    End Property

    Public Property GrupoPasivoId As Integer
        Get
            Return VarGrupoPasivoId
        End Get
        Set(value As Integer)
            VarGrupoPasivoId = value
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
