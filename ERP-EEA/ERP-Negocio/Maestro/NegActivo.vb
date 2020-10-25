Imports ERP_Entidad
Imports ERP_Datos

Public Class NegActivo
    Dim ObjActivoEnt As New EntActivo
    Dim ObjActivoDat As New DatActivo

    Public Function ObtenerTabla(ByVal IdActivo As Integer, ByVal PeriodoId As Integer) As DataTable
        Return ObjActivoDat.LeerActivo(IdActivo, PeriodoId)
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntActivo
        Dim Dt As DataTable
        Dt = ObjActivoDat.LeerActivo(Id, 0)
        If (Dt.Rows.Count() > 0) Then
            ObjActivoEnt.IdActivo = Convert.ToInt32(Dt.Rows(0).Item("IdActivo"))
            ObjActivoEnt.GrupoActivoId = Convert.ToInt32(Dt.Rows(0).Item("ActivoId"))
            ObjActivoEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("PeriodoId"))
            ObjActivoEnt.Monto = Convert.ToInt32(Dt.Rows(0).Item("Monto"))
        End If
        Return ObjActivoEnt
    End Function

    Public Function Eliminar(ByVal varActivoEnt As EntActivo) As Boolean
        Return ObjActivoDat.EliminarActivo(varActivoEnt)
    End Function

    Public Function Guardar(ByVal varActivoEnt As EntActivo) As Boolean
        Return ObjActivoDat.CrearActivo(varActivoEnt)
    End Function

    Public Function Actualizar(ByVal varActivoEnt As EntActivo) As Boolean
        Return ObjActivoDat.ActualizarActivo(varActivoEnt)
    End Function
End Class
