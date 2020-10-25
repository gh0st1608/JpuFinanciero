Imports ERP_Entidad
Imports ERP_Datos

Public Class NegGrupoEgreso
    Dim ObjGrupoEgresoEnt As New EntGrupoEgreso
    Dim ObjGrupoEgresoDat As New DatGrupoEgreso
    Public Function ObtenerTabla() As DataTable
        Return ObjGrupoEgresoDat.LeerGrupoEgreso(0)
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoEgreso
        Dim Dt As DataTable
        Dt = ObjGrupoEgresoDat.LeerGrupoEgreso(Id)
        If (Dt.Rows.Count() > 0) Then
            ObjGrupoEgresoEnt.IdGrupoEgreso = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoEgreso"))
            ObjGrupoEgresoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
            ObjGrupoEgresoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        End If
        Return ObjGrupoEgresoEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoEgreso)
        Dim result = New List(Of EntGrupoEgreso)
        Dim resultadoElemento As EntGrupoEgreso
        Dim Dt As DataTable
        Dt = ObjGrupoEgresoDat.LeerGrupoEgreso(0)
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntGrupoEgreso
                resultadoElemento.IdGrupoEgreso = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntGrupoEgreso
                resultadoElemento.IdGrupoEgreso = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntGrupoEgreso
                resultadoElemento.IdGrupoEgreso = Convert.ToInt16(Dt.Rows(i).Item("IdGrupoEgreso"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarGrupoEgresoEnt As EntGrupoEgreso) As Boolean
        Return ObjGrupoEgresoDat.EliminarGrupoEgreso(VarGrupoEgresoEnt)
    End Function

    Public Function Guardar(ByVal VarGrupoEgresoEnt As EntGrupoEgreso) As Boolean
        Return ObjGrupoEgresoDat.CrearGrupoEgreso(VarGrupoEgresoEnt)
    End Function

    Public Function Actualizar(ByVal VarGrupoEgresoEnt As EntGrupoEgreso) As Boolean
        Return ObjGrupoEgresoDat.ActualizarGrupoEgreso(VarGrupoEgresoEnt)
    End Function
End Class

