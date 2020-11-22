Public Class EntEstadoResultado
    Private VarIdEstadoResultado As Integer
    Private VarOrden As Integer
    Private VarConcepto As String
    Private VarPeriodoId As Integer
    Private VarValor As Decimal
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer


    Public Property IdEstadoResultado As Integer
        Get
            Return VarIdEstadoResultado
        End Get
        Set(value As Integer)
            VarIdEstadoResultado = value
        End Set
    End Property

    Public Property Orden As Integer
        Get
            Return VarOrden
        End Get
        Set(ByVal value As Integer)
            VarOrden = value
        End Set
    End Property

    Public Property Concepto As String
        Get
            Return VarConcepto
        End Get
        Set(value As String)
            VarConcepto = value
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

    Public Property Valor As Decimal
        Get
            Return VarValor
        End Get
        Set(ByVal value As Decimal)
            VarValor = value
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


End Class
