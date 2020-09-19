Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos

Public Class NegCliente
    Dim ObjClienteEnt = New EntCliente
    Dim ObjClienteDat As New DatCliente
    Public Function ObtenerTabla(ByVal objGrupoIngreso As EntGrupoIngreso) As DataTable

        Return ObjClienteDat.LeerCliente(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntCliente

        Dim Dt As DataTable

        Dt = ObjClienteDat.LeerCliente(Id, "")

        ObjClienteEnt.IdCliente = Convert.ToInt32(Dt.Rows(0).Item("IdCliente"))
        ObjClienteEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjClienteEnt.EstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjClienteEnt

    End Function

    Public Function ObtenerLista(ByVal Id As Integer, ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntCliente)

        Dim result = New List(Of EntCliente)
        Dim resultadoElemento As EntCliente
        Dim Dt As DataTable


        Dt = ObjClienteDat.LeerCliente(Id, "")

        If (Dt.Rows.Count() > 0) Then

            If (Filtro) Then

                resultadoElemento = New EntCliente
                resultadoElemento.IdCliente = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)

            End If

            If (Seleccion) Then

                resultadoElemento = New EntCliente
                resultadoElemento.IdCliente = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)

            End If

            For i = 0 To Dt.Rows.Count Step 1

                resultadoElemento = New EntCliente
                resultadoElemento.IdCliente = Convert.ToInt16(Dt.Rows(i).Item("IdCliente"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)

            Next i
        Else

            Return Nothing

        End If


        Return result
    End Function

    Public Function Eliminar(ByVal ObjClienteEnt As EntCliente) As Boolean

        Return ObjClienteDat.EliminarCliente(ObjClienteEnt)

    End Function

    Public Function Guardar(ByVal ObjClienteEnt As EntCliente) As Boolean

        Return ObjClienteDat.CrearCliente(ObjClienteEnt)

    End Function

    Public Function Actualizar(ByVal ObjGrupoIngreso As EntGrupoIngreso) As Boolean

        Return ObjClienteDat.ActualizarCliente(ObjClienteEnt)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjClienteDat.LeerCliente(0, Descripcion)

    End Function
End Class
