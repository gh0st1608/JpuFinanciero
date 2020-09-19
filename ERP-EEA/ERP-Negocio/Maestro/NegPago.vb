Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos



Public Class NegPago

    Dim ObjPagoEnt = New EntPago
    Dim ObjPagoDat As New DatPago
    Public Function ObtenerTabla(ByVal ObjPagoDat As DatPago) As DataTable

        Return ObjPagoDat.LeerPago(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntPago 'Mostrar el detalle al hacer click en el dgv

        Dim Dt As DataTable

        Dt = ObjPagoDat.LeerPago(Id, "")

        ObjPagoEnt.Id = Convert.ToInt32(Dt.Rows(0).Item("IdPago"))
        ObjPagoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjPagoEnt.EstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjPagoEnt

    End Function



    Public Function Eliminar(ByVal ObjPagoEnt As EntPago) As Boolean

        Return ObjPagoDat.EliminarPago(ObjPagoEnt)

    End Function

    Public Function Guardar(ByVal ObjPagoEnt As EntPago) As Boolean

        Return ObjPagoDat.CrearPago(ObjPagoEnt)

    End Function

    Public Function Actualizar(ByVal ObjPagoEnt As EntPago) As Boolean

        Return ObjPagoDat.ActualizarPago(ObjPagoEnt)

    End Function


End Class

