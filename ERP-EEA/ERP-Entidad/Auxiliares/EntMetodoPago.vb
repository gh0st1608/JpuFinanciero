Public Class EntMetodoPago
    Private VarIdMetodoPago As Integer
    Private VarDescripcion As String


    Public Property IdMetodoPago As Integer
        Get
            Return VarIdMetodoPago
        End Get
        Set(value As Integer)
            VarIdMetodoPago = value
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
End Class
