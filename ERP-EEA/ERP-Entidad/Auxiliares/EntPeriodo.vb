Public Class EntPeriodo
    Private VarIdPeriodo As Integer
    Private VarDescripcionPeriodo As String
    Private VarFechaInicio As Date
    Private VarFechaFin As Date


    Public Property IdPeriodo As Integer
        Get
            Return VarIdPeriodo
        End Get
        Set(value As Integer)
            VarIdPeriodo = value
        End Set
    End Property

    Public Property DescripcionPeriodo As String
        Get
            Return VarDescripcionPeriodo
        End Get
        Set(ByVal value As String)
            VarDescripcionPeriodo = value
        End Set
    End Property

    Public Property FechaInicio As Date
        Get
            Return VarFechaInicio
        End Get
        Set(ByVal value As Date)
            VarFechaInicio = value
        End Set
    End Property

    Public Property FechaFin As Date
        Get
            Return VarFechaFin
        End Get
        Set(ByVal value As Date)
            VarFechaFin = value
        End Set
    End Property

End Class
