Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos

Public Class NegGrupoActivo
    Dim ObjGrupoActivoEnt = New EntGrupoActivo
    Dim ObjGrupoActivoDat As New DatGrupoActivo
    Public Function ObtenerTabla() As DataTable

        Return ObjGrupoActivoDat.LeerGrupoActivo(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoActivo 'Detalle de un item

        Dim Dt As DataTable

        Dt = ObjGrupoActivoDat.LeerGrupoActivo(Id, "")

        ObjGrupoActivoEnt.IdGrupoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoActivo"))
        ObjGrupoActivoEnt.IdTipo = Convert.ToInt32(Dt.Rows(0).Item("IdTipo"))
        ObjGrupoActivoEnt.TipoDescripcion = Convert.ToInt32(Dt.Rows(0).Item("Tipo"))
        ObjGrupoActivoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjGrupoActivoEnt.Cuenta = Convert.ToInt32(Dt.Rows(0).Item("Cuenta"))
        ObjGrupoActivoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        ObjGrupoActivoEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjGrupoActivoEnt

    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoActivo)

        Dim result = New List(Of EntGrupoActivo)
        Dim resultadoElemento As EntGrupoActivo
        Dim Dt As DataTable


        Dt = ObjGrupoActivoDat.LeerGrupoActivo(0, "")

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

    Public Function Eliminar(ByVal ObjGrupoActivo As EntGrupoActivo) As Boolean

        Return ObjGrupoActivoDat.EliminarGrupoActivo(ObjGrupoActivo)

    End Function

    Public Function Guardar(ByVal VarGrupoActivo As EntGrupoActivo) As Boolean

        Return ObjGrupoActivoDat.CrearGrupoActivo(VarGrupoActivo)

    End Function

    Public Function Actualizar(ByVal ObjGrupoActivo As EntGrupoActivo) As Boolean

        Return ObjGrupoActivoDat.ActualizarGrupoActivo(ObjGrupoActivo)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjGrupoActivoDat.LeerGrupoActivo(0, Descripcion)

    End Function

End Class
