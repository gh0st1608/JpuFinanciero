Imports ERP_Entidad
Imports ERP_Datos

Public Class NegMetodoPago
    Dim ObjMetodoPagoEnt As New EntMetodoPago
    Dim ObjMetodoPagoDat As New DatMetodoPago

    Public Function ObtenerData(ByVal Id As Integer) As EntMetodoPago

        Dim Dt As DataTable

        Dt = ObjMetodoPagoDat.LeerMetodoPago(Id)

        ObjMetodoPagoEnt.IdMetodoPago = Convert.ToInt32(Dt.Rows(0).Item("IdMetodoPago"))
        ObjMetodoPagoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))

        Return ObjMetodoPagoEnt

    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntMetodoPago)

        Dim result = New List(Of EntMetodoPago)
        Dim resultadoElemento As EntMetodoPago
        Dim Dt As DataTable
        Dt = ObjMetodoPagoDat.LeerMetodoPago(0)

        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntMetodoPago
                resultadoElemento.IdMetodoPago = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntMetodoPago
                resultadoElemento.IdMetodoPago = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count-1 Step 1
                resultadoElemento = New EntMetodoPago
                resultadoElemento.IdMetodoPago = Convert.ToInt16(Dt.Rows(i).Item("IdMetodoPago"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function
End Class
