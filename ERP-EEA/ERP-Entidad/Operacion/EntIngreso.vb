Public Class EntIngreso

    Private VarIdIngreso As Integer
    Private VarGrupoIngresoId As Integer
    Private VarClienteId As Integer
    Private VarComentario As String
    Private VarImporteProvision As Decimal
    Private VarDeuda As Decimal
    Private VarPeriodoId As Integer
    Private VarCliente As String
    Private VarFechaIngresoProvision As Date
    Private VarComprobanteUbicacion As String
    Private VarNumeroComprobanteIngreso As String
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte
    Private VarDetraccion As Boolean
    Private VarIGV As Boolean

    'Private VarSubTotal As Decimal

    Public Property IdIngreso As Integer
        Get
            Return VarIdIngreso
        End Get
        Set(value As Integer)
            VarIdIngreso = value
        End Set
    End Property

    Public Property GrupoIngresoId As Integer
        Get
            Return VarGrupoIngresoId
        End Get
        Set(value As Integer)
            VarGrupoIngresoId = value
        End Set
    End Property

    Public Property ClienteId As Integer
        Get
            Return VarClienteId
        End Get
        Set(value As Integer)
            VarClienteId = value
        End Set
    End Property


    Public Property Comentario As String
        Get
            Return VarComentario
        End Get
        Set(ByVal value As String)
            VarComentario = value
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

    Public Property Deuda As Decimal
        Get
            Return VarDeuda
        End Get
        Set(ByVal value As Decimal)
            VarDeuda = value
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

    Public Property Cliente As String
        Get
            Return VarCliente
        End Get
        Set(ByVal value As String)
            VarCliente = value
        End Set
    End Property

    Public Property FechaIngresoProvision As Date
        Get
            Return VarFechaIngresoProvision
        End Get
        Set(ByVal value As Date)
            VarFechaIngresoProvision = value
        End Set
    End Property

    Public Property ComprobanteUbicacion As String
        Get
            Return VarComprobanteUbicacion
        End Get
        Set(ByVal value As String)
            VarComprobanteUbicacion = value
        End Set
    End Property

    Public Property NumeroComprobanteIngreso As String
        Get
            Return VarNumeroComprobanteIngreso
        End Get
        Set(ByVal value As String)
            VarNumeroComprobanteIngreso = value
        End Set
    End Property


    Public Property Detraccion As Boolean
        Get
            Return VarDetraccion
        End Get
        Set(ByVal value As Boolean)
            VarDetraccion = value
        End Set
    End Property

    Public Property IGV As Boolean
        Get
            Return VarIGV
        End Get
        Set(ByVal value As Boolean)
            VarIGV = value
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
