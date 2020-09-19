Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos

Public Class NegTipoCliente
    Dim ObjTipoClienteEnt = New EntTipoCliente
    Dim ObjTipoClienteDat As New DatTipoCliente
    Public Function ObtenerTabla(ByVal ObjTipoClienteDat As DatTipoCliente) As DataTable

        Return ObjTipoClienteDat.LeerTipoCliente(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntTipoCliente

        Dim Dt As DataTable

        Dt = ObjTipoClienteDat.LeerTipoCliente(Id, "")

        ObjTipoClienteEnt.IdCliente = Convert.ToInt32(Dt.Rows(0).Item("IdTipoCliente"))
        ObjTipoClienteEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjTipoClienteEnt.EstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjTipoClienteEnt

    End Function

    Public Function ObtenerLista(ByVal Id As Integer, ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntTipoCliente)

        Dim result = New List(Of EntTipoCliente)
        Dim resultadoElemento As EntTipoCliente
        Dim Dt As DataTable


        Dt = ObjTipoClienteDat.LeerTipoCliente(Id, "")

        If (Dt.Rows.Count() > 0) Then

            If (Filtro) Then

                resultadoElemento = New EntTipoCliente
                resultadoElemento.IdTipoCliente = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)

            End If

            If (Seleccion) Then

                resultadoElemento = New EntTipoCliente
                resultadoElemento.IdTipoCliente = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)

            End If

            For i = 0 To Dt.Rows.Count Step 1

                resultadoElemento = New EntTipoCliente
                resultadoElemento.IdTipoCliente = Convert.ToInt16(Dt.Rows(i).Item("IdTipoCliente"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)

            Next i
        Else

            Return Nothing

        End If


        Return result
    End Function

    Public Function Eliminar(ByVal ObjTipoClienteEnt As EntTipoCliente) As Boolean

        Return ObjTipoClienteDat.EliminarTipoCliente(ObjTipoClienteEnt)

    End Function

    Public Function Guardar(ByVal ObjTipoClienteEnt As EntTipoCliente) As Boolean

        Return ObjTipoClienteDat.CrearTipoCliente(ObjTipoClienteEnt)

    End Function

    Public Function Actualizar(ByVal ObjTipoClienteEnt As EntTipoCliente) As Boolean

        Return ObjTipoClienteDat.ActualizarTipoCliente(ObjTipoClienteEnt)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjTipoClienteDat.LeerTipoCliente(0, Descripcion)

    End Function
End Class

