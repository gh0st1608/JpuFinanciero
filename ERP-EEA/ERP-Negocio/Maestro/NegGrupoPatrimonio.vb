Imports ERP_Entidad
Imports ERP_Datos

Public Class NegGrupoPatrimonio
    Dim ObjGrupoPatrimonioEnt As New EntGrupoPatrimonio
    Dim ObjGrupoPatrimonioDat As New DatGrupoPatrimonio
    Public Function ObtenerTabla(TablaMaestra As Boolean) As DataTable
        Return ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(0, "", TablaMaestra)
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoPatrimonio
        Dim Dt As DataTable
        Dt = ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(Id, "", True)
        If (Dt.Rows.Count() > 0) Then
            ObjGrupoPatrimonioEnt.IdGrupoPatrimonio = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoPatrimonio"))
            ObjGrupoPatrimonioEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
            ObjGrupoPatrimonioEnt.Cuenta = Convert.ToInt32(Dt.Rows(0).Item("Cuenta"))
            ObjGrupoPatrimonioEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
            ObjGrupoPatrimonioEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))
        End If
        Return ObjGrupoPatrimonioEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoPatrimonio)
        Dim result = New List(Of EntGrupoPatrimonio)
        Dim resultadoElemento As EntGrupoPatrimonio
        Dim Dt As DataTable
        Dt = ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(0, "", False)
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntGrupoPatrimonio
                resultadoElemento.IdGrupoPatrimonio = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntGrupoPatrimonio
                resultadoElemento.IdGrupoPatrimonio = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntGrupoPatrimonio
                resultadoElemento.IdGrupoPatrimonio = Convert.ToInt32(Dt.Rows(i).Item("IdGrupoPatrimonio"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarGrupoPatrimonio As EntGrupoPatrimonio) As Boolean
        Return ObjGrupoPatrimonioDat.EliminarGrupoPatrimonio(VarGrupoPatrimonio)
    End Function

    Public Function Guardar(ByVal VarGrupoPatrimonio As EntGrupoPatrimonio) As Boolean
        Return ObjGrupoPatrimonioDat.CrearGrupoPatrimonio(VarGrupoPatrimonio)
    End Function

    Public Function Actualizar(ByVal VarGrupoPatrimonio As EntGrupoPatrimonio) As Boolean
        Return ObjGrupoPatrimonioDat.ActualizarGrupoPatrimonio(VarGrupoPatrimonio)
    End Function
End Class
