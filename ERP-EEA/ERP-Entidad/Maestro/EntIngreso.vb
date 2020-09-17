Public Class EntIngreso

    Private VarIdIngreso As Integer
    Private VarGrupoIngresoId As Integer
    Private VarClienteId As Integer
    Private VarDescripcion As String
    Private VarImporteIngresoProvision As Decimal
    Private VarTipoPagoId As Integer
    Private VarComprobanteURL As String
    Private VarFechaIngresoProvision As Date
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarFechaCreacion As Date
    Private VarFechaModificacion As Date
    Private VarEstadoActivo As Byte

    Public Property IdIngreso As Integer
        Get
            Return VarIdIngreso
        End Get
        Set(value As Integer)
            VarIdIngreso = value
        End Set
    End Property

    Public Property IdGrupoIngresoId As Integer
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


    Public Property Descripcion As String
        Get
            Return VarDescripcion
        End Get
        Set(ByVal value As String)
            VarDescripcion = value
        End Set
    End Property

    Public Property ImporteIngresoProvision As Decimal
        Get
            Return VarImporteIngresoProvision
        End Get
        Set(ByVal value As Decimal)
            VarImporteIngresoProvision = value
        End Set
    End Property

    Public Property TipoPagoId As Integer
        Get
            Return VarTipoPagoId
        End Get
        Set(ByVal value As Integer)
            VarTipoPagoId = value
        End Set
    End Property

    Public Property ComprobanteURL As String
        Get
            Return VarComprobanteURL
        End Get
        Set(ByVal value As String)
            VarComprobanteURL = value
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

    Public Property FechaCreacion As Date
        Get
            Return VarFechaCreacion
        End Get
        Set(ByVal value As Date)
            VarFechaCreacion = value
        End Set
    End Property

    Public Property FechaModificacion As Date
        Get
            Return VarFechaModificacion
        End Get
        Set(ByVal value As Date)
            VarFechaModificacion = value
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
