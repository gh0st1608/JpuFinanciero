﻿Imports ERP_Entidad
Imports ERP_Datos



Public Class NegPago

    Dim ObjPagoEnt As New EntPago
    Dim ObjPagoDat As New DatPago

    Public Function ObtenerTabla(ByVal IdPago As Integer, ByVal TipoOrigen As Integer, ByVal OrigenId As Integer, PeriodoId As Integer, ByVal ClienteId As Integer, ByVal ProveedorId As Integer) As DataTable
        Return ObjPagoDat.LeerPago(IdPago, TipoOrigen, OrigenId, PeriodoId, ClienteId, ProveedorId)
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal TipoOrigen As Integer) As EntPago 'Mostrar el detalle al hacer click en el dgv

        Dim Dt As DataTable

        Dt = ObjPagoDat.LeerPago(Id, TipoOrigen, 0, 0, 0, 0)

        ObjPagoEnt.IdPago = Convert.ToInt32(Dt.Rows(0).Item("IdPago"))
        ObjPagoEnt.OrigenId = Convert.ToInt32(Dt.Rows(0).Item("OrigenId"))
        ObjPagoEnt.ImporteCancelado = Convert.ToInt32(Dt.Rows(0).Item("ImporteCancelado"))
        ObjPagoEnt.MetodoPagoId = Convert.ToInt32(Dt.Rows(0).Item("MetodoPagoId"))
        ObjPagoEnt.FechaPago = Convert.ToDateTime(Dt.Rows(0).Item("FechaPago"))
        ObjPagoEnt.ComprobanteUbicacion = Convert.ToString(Dt.Rows(0).Item("ComprobanteUbicacion"))
        ObjPagoEnt.NumeroComprobante = Convert.ToString(Dt.Rows(0).Item("NumeroComprobante"))
        ObjPagoEnt.ImporteTotal = Convert.ToInt32(Dt.Rows(0).Item("ImporteTotal"))

        Return ObjPagoEnt

    End Function



    Public Function Eliminar(ByVal varPagoEnt As EntPago) As Boolean

        Return ObjPagoDat.EliminarPago(varPagoEnt)

    End Function

    Public Function Guardar(ByVal varPagoEnt As EntPago) As Boolean

        Return ObjPagoDat.CrearPago(varPagoEnt)

    End Function

    Public Function Actualizar(ByVal varPagoEnt As EntPago) As Boolean

        Return ObjPagoDat.ActualizarPago(varPagoEnt)

    End Function


End Class
