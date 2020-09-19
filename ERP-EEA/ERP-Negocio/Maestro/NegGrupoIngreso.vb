Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos



Public Class NegGrupoIngreso

    Dim ObjGrupoIngresoEnt = New EntGrupoIngreso
    Dim ObjGrupoIngresoDat As New DatGrupoIngreso
    Public Function ObtenerTabla(ByVal objGrupoIngreso As DatGrupoIngreso) As DataTable

        Return ObjGrupoIngresoDat.LeerGrupoIngreso(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoIngreso

        Dim Dt As DataTable

        Dt = ObjGrupoIngresoDat.LeerGrupoIngreso(Id, "")

        ObjGrupoIngresoEnt.Id = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoIngreso"))
        ObjGrupoIngresoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjGrupoIngresoEnt.EstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjGrupoIngresoEnt

    End Function

    Public Function ObtenerLista(ByVal Id As Integer, ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoIngreso)

        Dim result = New List(Of EntGrupoIngreso)
        Dim resultadoElemento As EntGrupoIngreso
        Dim Dt As DataTable


        Dt = ObjGrupoIngresoDat.LeerGrupoIngreso(Id, "")

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

            For i = 0 To Dt.Rows.Count Step 1

                resultadoElemento = New EntGrupoIngreso
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

    Public Function Guardar(ByVal ObjGrupoIngreso As EntGrupoIngreso) As Boolean

        Return ObjGrupoIngresoDat.CrearGrupoIngreso(ObjGrupoIngreso)

    End Function

    Public Function Actualizar(ByVal ObjGrupoIngreso As EntGrupoIngreso) As Boolean

        Return ObjGrupoIngresoDat.ActualizarGrupoIngreso(ObjGrupoIngresoEnt)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjGrupoIngresoDat.LeerGrupoIngreso(0, Descripcion)

    End Function

End Class
