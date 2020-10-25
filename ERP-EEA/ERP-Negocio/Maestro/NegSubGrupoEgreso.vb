Imports ERP_Entidad
Imports ERP_Datos

Public Class NegSubGrupoEgreso
    Dim ObjSubGrupoEgresoEnt As New EntSubGrupoEgreso
    Dim ObjSubGrupoEgresoDat As New DatSubGrupoEgreso
    Public Function ObtenerTabla() As DataTable
        Return ObjSubGrupoEgresoDat.LeerSubGrupoEgreso(0, 0)
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntSubGrupoEgreso
        Dim Dt As DataTable
        Dt = ObjSubGrupoEgresoDat.LeerSubGrupoEgreso(Id, 0)
        If (Dt.Rows.Count() > 0) Then
            ObjSubGrupoEgresoEnt.IdSubGrupoEgreso = Convert.ToInt32(Dt.Rows(0).Item("IdSubGrupoEgreso"))
            ObjSubGrupoEgresoEnt.GrupoEgresoId = Convert.ToString(Dt.Rows(0).Item("GrupoEgresoId"))
            ObjSubGrupoEgresoEnt.ItemSubGrupoEgreso = Convert.ToString(Dt.Rows(0).Item("ItemSubGrupoEgreso"))
            ObjSubGrupoEgresoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        End If
        Return ObjSubGrupoEgresoEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean, ByVal GrupoEgresoId As Integer) As List(Of EntSubGrupoEgreso)
        Dim result = New List(Of EntSubGrupoEgreso)
        Dim resultadoElemento As EntSubGrupoEgreso
        Dim Dt As DataTable
        Dt = ObjSubGrupoEgresoDat.LeerSubGrupoEgreso(0, GrupoEgresoId)
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntSubGrupoEgreso
                resultadoElemento.IdSubGrupoEgreso = 0
                resultadoElemento.ItemSubGrupoEgreso = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntSubGrupoEgreso
                resultadoElemento.IdSubGrupoEgreso = 0
                resultadoElemento.ItemSubGrupoEgreso = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntSubGrupoEgreso
                resultadoElemento.IdSubGrupoEgreso = Convert.ToInt16(Dt.Rows(i).Item("IdSubGrupoEgreso"))
                resultadoElemento.ItemSubGrupoEgreso = Convert.ToString(Dt.Rows(i)("ItemSubGrupoEgreso"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarSubGrupoEgresoEnt As EntSubGrupoEgreso) As Boolean
        Return ObjSubGrupoEgresoDat.EliminarSubGrupoEgreso(VarSubGrupoEgresoEnt)
    End Function

    Public Function Guardar(ByVal VarSubGrupoEgresoEnt As EntSubGrupoEgreso) As Boolean
        Return ObjSubGrupoEgresoDat.CrearSubGrupoEgreso(VarSubGrupoEgresoEnt)
    End Function

    Public Function Actualizar(ByVal VarSubGrupoEgresoEnt As EntSubGrupoEgreso) As Boolean
        Return ObjSubGrupoEgresoDat.ActualizarSubGrupoEgreso(VarSubGrupoEgresoEnt)
    End Function
End Class
