Imports ERP_Entidad
Imports ERP_Datos
Public Class NegProyectado
    Dim ObjProyectadoEnt As New EntProyectado
    Dim ObjProyectadoDat As New DatProyectado

    Public Function ObtenerTabla(ByVal IdProyectado As Integer, ByVal PeriodoId As Integer) As DataTable
        Return ObjProyectadoDat.LeerProyectado(IdProyectado, 0, PeriodoId)
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal SubGrupoEgresoId As Integer, ByVal PeriodoId As Integer) As EntProyectado
        Dim Dt As DataTable
        Dt = ObjProyectadoDat.LeerProyectado(Id, SubGrupoEgresoId, PeriodoId)
        If (Dt.Rows.Count() > 0) Then
            ObjProyectadoEnt.IdProyectado = Convert.ToInt32(Dt.Rows(0).Item("IdProyectado"))
            ObjProyectadoEnt.GrupoEgresoId = Convert.ToInt32(Dt.Rows(0).Item("GrupoEgresoId"))
            ObjProyectadoEnt.SubGrupoEgresoId = Convert.ToInt32(Dt.Rows(0).Item("SubGrupoEgresoId"))
            ObjProyectadoEnt.ImporteProvision = Convert.ToDecimal(Dt.Rows(0).Item("ImporteProvision"))
            ObjProyectadoEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("PeriodoId"))
        End If
        Return ObjProyectadoEnt
    End Function

    Public Function Eliminar(ByVal VarProyectadoEnt As EntProyectado) As Boolean
        Return ObjProyectadoDat.EliminarProyectado(VarProyectadoEnt)
    End Function

    Public Function Guardar(ByVal VarProyectadoEnt As EntProyectado) As Boolean
        Return ObjProyectadoDat.CrearProyectado(VarProyectadoEnt)
    End Function

    Public Function Actualizar(ByVal VarProyectadoEnt As EntProyectado) As Boolean
        Return ObjProyectadoDat.ActualizarProyectado(VarProyectadoEnt)
    End Function
End Class
