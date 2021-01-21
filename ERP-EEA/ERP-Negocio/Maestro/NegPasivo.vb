Imports ERP_Entidad
Imports ERP_Datos

Public Class NegPasivo
    Dim ObjPasivoEnt As New EntPasivo
    Dim ObjPasivoDat As New DatPasivo

    Public Function ObtenerTabla(ByVal IdPasivo As Integer, ByVal PeriodoId As Integer, ByVal GrupoId As Integer, TablaMaestra As Boolean) As DataTable
        Return ObjPasivoDat.LeerPasivo(IdPasivo, PeriodoId, GrupoId, TablaMaestra)
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal PeriodoId As Integer, ByVal GrupoId As Integer) As EntPasivo
        Dim Dt As New DataTable
        Dt = ObjPasivoDat.LeerPasivo(Id, PeriodoId, GrupoId, True)
        If (Dt.Rows.Count() > 0) Then
            ObjPasivoEnt.IdPasivo = Convert.ToInt32(Dt.Rows(0).Item("IdPasivo"))
            ObjPasivoEnt.GrupoPasivoId = Convert.ToInt32(Dt.Rows(0).Item("GrupoPasivoId"))
            ObjPasivoEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("PeriodoId"))
            ObjPasivoEnt.Monto = Convert.ToInt32(Dt.Rows(0).Item("Monto"))
        End If
        Return ObjPasivoEnt
    End Function

    Public Function Eliminar(ByVal varPasivoEnt As EntPasivo) As Boolean
        Return ObjPasivoDat.EliminarPasivo(varPasivoEnt)
    End Function

    Public Function Guardar(ByVal varPasivoEnt As EntPasivo) As Boolean
        Return ObjPasivoDat.CrearPasivo(varPasivoEnt)
    End Function

    Public Function Actualizar(ByVal varPasivoEnt As EntPasivo) As Boolean
        Return ObjPasivoDat.ActualizarPasivo(varPasivoEnt)
    End Function
End Class
