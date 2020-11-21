
Imports ERP_Entidad
Imports ERP_Datos

Public Class NegTipoRatio

    Dim ObjTipoRatioEnt As New EntTipoRatio
    Dim ObjTipoRatioDat As New DatTipoRatio
    Public Function ObtenerData(ByVal Id As Integer) As EntTipoRatio
        Dim Dt As New DataTable
        Dt = ObjTipoRatioDat.LeerTipoRatio(Id)
        If (Dt.Rows.Count() > 0) Then
            ObjTipoRatioEnt.IdTipoRatio = Convert.ToInt32(Dt.Rows(0).Item("IdTipoRatio"))
            ObjTipoRatioEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        End If
        Return ObjTipoRatioEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntTipoRatio)
        Dim result = New List(Of EntTipoRatio)
        Dim resultadoElemento As EntTipoRatio
        Dim Dt As DataTable
        Dt = ObjTipoRatioDat.LeerTipoRatio(0)
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntTipoRatio
                resultadoElemento.IdTipoRatio = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntTipoRatio
                resultadoElemento.IdTipoRatio = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntTipoRatio
                resultadoElemento.IdTipoRatio = Convert.ToInt16(Dt.Rows(i).Item("IdTipoRatio"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function
End Class
