Public Class EntPago
    Private VarIdPago As Integer
    Private VarTipoOrigenId As Integer
    Private VarEgresoId As Integer
    Private VarImporteCancelado As Decimal
    Private VarMetodoPagoId As Integer
    Private VarFechaPago As Date
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte


    Public Property IdPago As Integer
        Get
            Return VarIdPago
        End Get
        Set(ByVal value As Integer)
            VarIdPago = value
        End Set
    End Property

    Public Property TipoOrigenId As Integer
        Get
            Return VarTipoOrigenId
        End Get
        Set(ByVal value As Integer)
            VarTipoOrigenId = value
        End Set
    End Property

    Public Property EgresoId As Integer
        Get
            Return VarEgresoId
        End Get
        Set(ByVal value As Integer)
            VarEgresoId = value
        End Set
    End Property

    Public Property ImporteCancelado As Decimal
        Get
            Return VarImporteCancelado
        End Get
        Set(ByVal value As Decimal)
            VarImporteCancelado = value
        End Set
    End Property


    Public Property MetodoPagoId As Integer
        Get
            Return VarMetodoPagoId
        End Get
        Set(ByVal value As Integer)
            VarMetodoPagoId = value
        End Set
    End Property

    Public Property FechaPago As Date
        Get
            Return VarFechaPago
        End Get
        Set(ByVal value As Date)
            VarFechaPago = value
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
