Imports ERP_Entidad
Imports ERP_Datos

Public Class NegEgreso
    Dim ObjEgresoEnt As New EntEgreso
    Dim ObjEgresoDat As New DatEgreso

    Public Function ObtenerTabla(ByVal IdEgreso As Integer, ByVal PeriodoId As Integer, ByVal ProveedorId As Integer) As DataTable
        Return ObjEgresoDat.LeerEgreso(IdEgreso, 0, PeriodoId, ProveedorId)
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal SubGrupoEgresoId As Integer, ByVal PeriodoId As Integer) As EntEgreso
        Dim Dt As DataTable
        Dt = ObjEgresoDat.LeerEgreso(Id, SubGrupoEgresoId, PeriodoId, 0)
        If (Dt.Rows.Count() > 0) Then
            ObjEgresoEnt.IdEgreso = Convert.ToInt32(Dt.Rows(0).Item("IdEgreso"))
            ObjEgresoEnt.GrupoEgresoId = Convert.ToInt32(Dt.Rows(0).Item("GrupoEgresoId"))
            ObjEgresoEnt.SubGrupoEgresoId = Convert.ToInt32(Dt.Rows(0).Item("SubGrupoEgresoId"))
            ObjEgresoEnt.ProveedorId = Convert.ToInt32(Dt.Rows(0).Item("ProveedorId"))
            ObjEgresoEnt.IGV = Convert.ToBoolean(Dt.Rows(0).Item("IGV"))
            ObjEgresoEnt.Comentario = Convert.ToString(Dt.Rows(0).Item("Comentario"))
            ObjEgresoEnt.ImporteProvision = Convert.ToDecimal(Dt.Rows(0).Item("ImporteProvision"))
            ObjEgresoEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("PeriodoId"))
            ObjEgresoEnt.FechaEgresoProvision = Convert.ToDateTime(Dt.Rows(0).Item("FechaEgresoProvision"))
            ObjEgresoEnt.ComprobanteUbicacion = Convert.ToString(Dt.Rows(0).Item("ComprobanteUbicacion"))
            ObjEgresoEnt.NumeroComprobanteEgreso = Convert.ToString(Dt.Rows(0).Item("NumeroComprobanteEgreso"))
            ObjEgresoEnt.Deuda = Convert.ToDecimal(Dt.Rows(0).Item("Deuda"))
        End If
        Return ObjEgresoEnt
    End Function

    Public Function Eliminar(ByVal VarEgresoEnt As EntEgreso) As Boolean
        Return ObjEgresoDat.EliminarEgreso(VarEgresoEnt)
    End Function

    Public Function Guardar(ByVal VarEgresoEnt As EntEgreso) As Boolean
        Return ObjEgresoDat.CrearEgreso(VarEgresoEnt)
    End Function

    Public Function Actualizar(ByVal VarEgresoEnt As EntEgreso) As Boolean
        Return ObjEgresoDat.ActualizarEgreso(VarEgresoEnt)
    End Function
End Class
