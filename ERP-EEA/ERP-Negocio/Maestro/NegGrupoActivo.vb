Imports ERP_Entidad
Imports ERP_Datos

Public Class NegGrupoActivo
    Dim ObjGrupoActivoEnt As New EntGrupoActivo
    Dim ObjGrupoActivoDat As New DatGrupoActivo
    Public Function ObtenerTabla(TablaMaestra As Boolean) As DataTable
        Return ObjGrupoActivoDat.LeerGrupoActivo(0, "", TablaMaestra)
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoActivo
        Dim Dt As DataTable
        Dt = ObjGrupoActivoDat.LeerGrupoActivo(Id, "", True)
        If (Dt.Rows.Count() > 0) Then
            ObjGrupoActivoEnt.IdGrupoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoActivo"))
            ObjGrupoActivoEnt.IdTipo = Convert.ToInt32(Dt.Rows(0).Item("IdTipo"))
            ObjGrupoActivoEnt.DescripcionTipo = Convert.ToString(Dt.Rows(0).Item("Tipo"))
            ObjGrupoActivoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
            ObjGrupoActivoEnt.Cuenta = Convert.ToInt32(Dt.Rows(0).Item("Cuenta"))
            ObjGrupoActivoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
            ObjGrupoActivoEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))
        End If
        Return ObjGrupoActivoEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoActivo)
        Dim result = New List(Of EntGrupoActivo)
        Dim resultadoElemento As EntGrupoActivo
        Dim Dt As DataTable
        Dt = ObjGrupoActivoDat.LeerGrupoActivo(0, "", False)
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntGrupoActivo
                resultadoElemento.IdGrupoActivo = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntGrupoActivo
                resultadoElemento.IdGrupoActivo = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If

            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntGrupoActivo
                resultadoElemento.IdGrupoActivo = Convert.ToInt32(Dt.Rows(i).Item("IdGrupoActivo"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarGrupoActivo As EntGrupoActivo) As Boolean
        Return ObjGrupoActivoDat.EliminarGrupoActivo(VarGrupoActivo)
    End Function

    Public Function Guardar(ByVal VarGrupoActivo As EntGrupoActivo) As Boolean
        Return ObjGrupoActivoDat.CrearGrupoActivo(VarGrupoActivo)
    End Function

    Public Function Actualizar(ByVal ObjGrupoActivo As EntGrupoActivo) As Boolean
        Return ObjGrupoActivoDat.ActualizarGrupoActivo(ObjGrupoActivo)
    End Function
End Class
