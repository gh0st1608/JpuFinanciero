Imports ERP_Entidad
Imports ERP_Datos

Public Class NegPeriodo
    Dim ObjPeriodoEnt As New EntPeriodo
    Dim ObjPeriodoDat As New DatPeriodo

    Public Function ObtenerData(ByVal Id As Integer, ByVal DescripcionPeriodo As String) As EntPeriodo
        Dim Dt As DataTable
        Dt = ObjPeriodoDat.LeerPeriodo(Id, DescripcionPeriodo)
        If (Dt.Rows.Count() > 0) Then
            ObjPeriodoEnt.IdPeriodo = Convert.ToInt32(Dt.Rows(0).Item("IdPeriodo"))
            ObjPeriodoEnt.DescripcionPeriodo = Convert.ToString(Dt.Rows(0).Item("DescripcionPeriodo"))
            ObjPeriodoEnt.FechaInicio = Convert.ToDateTime(Dt.Rows(0).Item("FechaInicio"))
            ObjPeriodoEnt.FechaFin = Convert.ToDateTime(Dt.Rows(0).Item("FechaFin"))
        End If
        Return ObjPeriodoEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntPeriodo)
        Dim result = New List(Of EntPeriodo)
        Dim resultadoElemento As EntPeriodo
        Dim Dt As DataTable
        Dt = ObjPeriodoDat.LeerPeriodo(0, "")
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntPeriodo
                resultadoElemento.IdPeriodo = 0
                resultadoElemento.DescripcionPeriodo = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntPeriodo
                resultadoElemento.IdPeriodo = 0
                resultadoElemento.DescripcionPeriodo = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntPeriodo
                resultadoElemento.IdPeriodo = Convert.ToInt16(Dt.Rows(i).Item("IdPeriodo"))
                resultadoElemento.DescripcionPeriodo = Convert.ToString(Dt.Rows(i)("DescripcionPeriodo"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function
End Class
