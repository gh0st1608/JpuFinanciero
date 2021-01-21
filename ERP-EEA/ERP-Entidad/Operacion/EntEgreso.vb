Public Class EntEgreso

    Private VarIdEgreso As Integer
    Private VarGrupoEgresoId As Integer
    Private VarSubGrupoEgresoId As Integer
    Private VarSubGrupoEgresoDescripcion As String
    Private VarProveedorId As Integer
    Private VarProveedorDescripcion As String
    Private VarPeriodoId As Integer
    Private VarIGV As Byte
    Private VarComentario As String
    Private VarComprobanteUbicacion As String
    Private VarNumeroComprobanteEgreso As String
    Private VarFechaEgresoProvision As Date
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte
    Private VarDeuda As Decimal
    Private VarImporteProvision As Decimal
    Private VarIgvProvision As Decimal
    Private VarTotalProvision As Decimal

    Public Property IdEgreso As Integer
        Get
            Return VarIdEgreso
        End Get
        Set(value As Integer)
            VarIdEgreso = value
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

    Public Property ProveedorId As Integer
        Get
            Return VarProveedorId
        End Get
        Set(value As Integer)
            VarProveedorId = value
        End Set
    End Property

    Public Property ProveedorDescripcion As String
        Get
            Return VarProveedorDescripcion
        End Get
        Set(value As String)
            VarProveedorDescripcion = value
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

    Public Property IGV As Byte
        Get
            Return VarIGV
        End Get
        Set(ByVal value As Byte)
            VarIGV = value
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

    Public Property ComprobanteUbicacion As String
        Get
            Return VarComprobanteUbicacion
        End Get
        Set(value As String)
            VarComprobanteUbicacion = value
        End Set
    End Property

    Public Property NumeroComprobanteEgreso As String
        Get
            Return VarNumeroComprobanteEgreso
        End Get
        Set(value As String)
            VarNumeroComprobanteEgreso = value
        End Set
    End Property

    Public Property FechaEgresoProvision As Date
        Get
            Return VarFechaEgresoProvision
        End Get
        Set(ByVal value As Date)
            VarFechaEgresoProvision = value
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

    Public Property Deuda As Decimal
        Get
            Return VarDeuda
        End Get
        Set(ByVal value As Decimal)
            VarDeuda = value
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

    Public Property IgvProvision As Decimal
        Get
            Return VarIgvProvision
        End Get
        Set(ByVal value As Decimal)
            VarIgvProvision = value
        End Set
    End Property

    Public Property TotalProvision As Decimal
        Get
            Return VarTotalProvision
        End Get
        Set(ByVal value As Decimal)
            VarTotalProvision = value
        End Set
    End Property
End Class

