Public Class EntParametro
    Private VarIdParametro As Integer
    Private VarTipoParametro As String
    Private VarDescripcion As String
    Private VarValorParametro As Decimal
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarEstadoActivo As Byte


    Public Property IdParametro As Integer
        Get
            Return VarIdParametro
        End Get
        Set(value As Integer)
            VarIdParametro = value
        End Set
    End Property

    Public Property TipoParametro As String
        Get
            Return VarTipoParametro
        End Get
        Set(ByVal value As String)
            VarTipoParametro = value
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

    Public Property ValorParametro As Decimal
        Get
            Return VarValorParametro
        End Get
        Set(ByVal value As Decimal)
            VarValorParametro = value
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
