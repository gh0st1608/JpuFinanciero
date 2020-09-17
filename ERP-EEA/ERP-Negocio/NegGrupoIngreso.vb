Imports System
Imports System.Collections.Generic
Imports System.Data



Public Class NegGrupoIngreso

    Dim ObjGrupoIngresoEnt = New ERP_Entidad.EntGrupoIngreso
    Dim ObjGrupoIngresoDat As New ERP_Datos.DatGrupoIngreso
    Public Function ObtenerTabla(ByVal objGrupoIngreso As ERP_Datos.DatGrupoIngreso) As DataTable

        Return ObjGrupoIngresoDat.LeerGrupoIngreso(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function
    Public Function ObtenerData(ByVal Id As Integer) As ERP_Entidad.EntGrupoIngreso

        Dim Dt As DataTable

        Dt = ObjGrupoIngresoDat.LeerGrupoIngreso(Id, "")

        ObjGrupoIngresoEnt.Id = Convert.ToInt32(dt.Rows(0).Item("IdGrupoIngreso"))
        ObjGrupoIngresoEnt.Descripcion = Convert.ToString(dt.Rows(0).Item("Descripcion"))
        ObjGrupoIngresoEnt.UsuarioCreacionId = Convert.ToInt32(dt.Rows(0).Item("UsuarioCreacionId"))
        ObjGrupoIngresoEnt.UsuarioModificacionId = Convert.ToInt32(dt.Rows(0).Item("UsuarioModificacionId"))
        ObjGrupoIngresoEnt.FechaCreacion = Convert.ToString(dt.Rows(0).Item("FechaCreacion"))
        ObjGrupoIngresoEnt.FechaModificacion = Convert.ToString(dt.Rows(0).Item("FechaModificacion"))
        ObjGrupoIngresoEnt.EstadoActivo = Convert.ToInt32(dt.Rows(0).Item("EstadoActivo"))

        Return ObjGrupoIngresoEnt

    End Function

    Public Function ObtenerLista(ByVal Id As Integer, ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of ERP_Entidad.EntGrupoIngreso)

        Dim result = New List(Of ERP_Entidad.EntGrupoIngreso)
        Dim resultadoElemento As ERP_Entidad.EntGrupoIngreso
        Dim Dt As DataTable


        Dt = ObjGrupoIngresoDat.LeerGrupoIngreso(Id, "")

        If (Dt.Rows.Count() > 0) Then

            If (Filtro) Then

                resultadoElemento = New ERP_Entidad.EntGrupoIngreso
                resultadoElemento.IdGrupoIngreso = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)

            End If

            If (Seleccion) Then

                resultadoElemento = New ERP_Entidad.EntGrupoIngreso
                resultadoElemento.IdGrupoIngreso = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)

            End If

            For i = 0 To Dt.Rows.Count Step 1

                resultadoElemento = New ERP_Entidad.EntGrupoIngreso
                resultadoElemento.IdGrupoIngreso = Convert.ToInt16(Dt.Rows(i).Item("IDEmpresa"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("NombreEmpresa"))
                result.Add(resultadoElemento)

            Next i
        Else

            Return Nothing

        End If


        Return result
    End Function

    Public Function Eliminar(ByVal id As Integer) As Boolean

        Return ObjGrupoIngresoDat.EliminarGrupoIngreso(id)

    End Function

    Public Function Guardar(ByVal ObjGrupoIngreso As ERP_Entidad.EntGrupoIngreso, ByVal BlnNuevo As Boolean) As Boolean

        Return ObjGrupoIngresoDat.CrearGrupoIngreso(ObjGrupoIngresoEnt, BlnNuevo)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjGrupoIngresoDat.LeerGrupoIngreso(0, Descripcion)

    End Function

End Class
