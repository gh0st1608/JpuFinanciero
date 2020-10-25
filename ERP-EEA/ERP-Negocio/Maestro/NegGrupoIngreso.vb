Imports ERP_Entidad
Imports ERP_Datos
Public Class NegGrupoIngreso
    Dim ObjGrupoIngresoEnt As New EntGrupoIngreso
    Dim ObjGrupoIngresoDat As New DatGrupoIngreso
    Public Function ObtenerTabla() As DataTable
        Return ObjGrupoIngresoDat.LeerGrupoIngreso(0, "")
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoIngreso
        Dim Dt As DataTable
        Dt = ObjGrupoIngresoDat.LeerGrupoIngreso(Id, "")
        If (Dt.Rows.Count() > 0) Then
            ObjGrupoIngresoEnt.IdGrupoIngreso = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoIngreso"))
            ObjGrupoIngresoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
            ObjGrupoIngresoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
            ObjGrupoIngresoEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))
        End If
        Return ObjGrupoIngresoEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoIngreso)
        Dim result = New List(Of EntGrupoIngreso)
        Dim resultadoElemento As EntGrupoIngreso
        Dim Dt As DataTable
        Dt = ObjGrupoIngresoDat.LeerGrupoIngreso(0, "")
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntGrupoIngreso
                resultadoElemento.IdGrupoIngreso = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntGrupoIngreso
                resultadoElemento.IdGrupoIngreso = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntGrupoIngreso
                resultadoElemento.IdGrupoIngreso = Convert.ToInt32(Dt.Rows(i).Item("IdGrupoIngreso"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarGrupoIngreso As EntGrupoIngreso) As Boolean
        Return ObjGrupoIngresoDat.EliminarGrupoIngreso(VarGrupoIngreso)
    End Function

    Public Function Guardar(ByVal VarGrupoIngreso As EntGrupoIngreso) As Boolean
        Return ObjGrupoIngresoDat.CrearGrupoIngreso(VarGrupoIngreso)
    End Function

    Public Function Actualizar(ByVal VarGrupoIngreso As EntGrupoIngreso) As Boolean
        Return ObjGrupoIngresoDat.ActualizarGrupoIngreso(VarGrupoIngreso)
    End Function
End Class
