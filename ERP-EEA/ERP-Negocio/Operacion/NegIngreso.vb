Imports ERP_Entidad
Imports ERP_Datos

Public Class NegIngreso
    Dim ObjIngresoEnt As New EntIngreso
    Dim ObjIngresoDat As New DatIngreso

    Public Function ObtenerTabla(ByVal IdIngreso As Integer, ByVal PeriodoId As Integer, ByVal ClienteId As Integer) As DataTable

        Return ObjIngresoDat.LeerIngreso(IdIngreso, PeriodoId, ClienteId)

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntIngreso

        Dim Dt As DataTable

        Dt = ObjIngresoDat.LeerIngreso(Id, 0, 0)

        ObjIngresoEnt.IdIngreso = Convert.ToInt32(Dt.Rows(0).Item("IdIngreso"))
        ObjIngresoEnt.GrupoIngresoId = Convert.ToInt32(Dt.Rows(0).Item("GrupoIngresoId"))
        ObjIngresoEnt.ClienteId = Convert.ToInt32(Dt.Rows(0).Item("ClienteId"))
        ObjIngresoEnt.Cliente = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjIngresoEnt.Detraccion = Convert.ToBoolean(Dt.Rows(0).Item("Detraccion"))
        ObjIngresoEnt.ImporteProvision = Convert.ToDecimal(Dt.Rows(0).Item("ImporteProvision"))
        ObjIngresoEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("PeriodoId"))
        ObjIngresoEnt.FechaIngresoProvision = Convert.ToDateTime(Dt.Rows(0).Item("FechaIngresoProvision"))
        ObjIngresoEnt.Deuda = Convert.ToDecimal(Dt.Rows(0).Item("Deuda"))
        ObjIngresoEnt.Comentario = Convert.ToString(Dt.Rows(0).Item("Comentario"))

        Return ObjIngresoEnt

    End Function

    Public Function Eliminar(ByVal varIngresoEnt As EntIngreso) As Boolean

        Return ObjIngresoDat.EliminarIngreso(varIngresoEnt)

    End Function

    Public Function Guardar(ByVal varIngresoEnt As EntIngreso) As Boolean

        Return ObjIngresoDat.CrearIngreso(varIngresoEnt)

    End Function

    Public Function Actualizar(ByVal varIngresoEnt As EntIngreso) As Boolean

        Return ObjIngresoDat.ActualizarIngreso(varIngresoEnt)

    End Function
End Class
