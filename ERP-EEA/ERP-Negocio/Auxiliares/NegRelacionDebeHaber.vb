Imports ERP_Entidad
Imports ERP_Datos

Public Class NegRelacionDebeHaber
    Dim ObjRelacionDebeHaberEnt As New EntRelacionDebeHaber
    Dim ObjRelacionDebeHaberDat As New DatRelacionDebeHaber
    Public Function ObtenerTabla() As DataTable
        Return ObjRelacionDebeHaberDat.LeerRelacionDebeHaber(0, 0, 0, 0)
    End Function

    Public Function ObtenerData(ByVal IdRelacionDebeHaber As Integer, ByVal TipoOperacionId As Integer, ByVal EtapaOperacionId As Integer, ByVal GrupoId As Integer) As EntRelacionDebeHaber
        Dim Dt As DataTable
        Dt = ObjRelacionDebeHaberDat.LeerRelacionDebeHaber(IdRelacionDebeHaber, TipoOperacionId, EtapaOperacionId, GrupoId)
        If (Dt.Rows.Count() > 0) Then
            ObjRelacionDebeHaberEnt.IdRelacionDebeHaber = Convert.ToInt32(Dt.Rows(0).Item("IdRelacionDebeHaber"))
            ObjRelacionDebeHaberEnt.TipoOperacionId = Convert.ToInt32(Dt.Rows(0).Item("TipoOperacionId"))
            ObjRelacionDebeHaberEnt.EtapaOperacionId = Convert.ToInt32(Dt.Rows(0).Item("EtapaOperacionId"))
            ObjRelacionDebeHaberEnt.GrupoId = Convert.ToInt32(Dt.Rows(0).Item("GrupoId"))
            ObjRelacionDebeHaberEnt.GrupoDebeId = Convert.ToInt32(Dt.Rows(0).Item("GrupoDebeId"))
            ObjRelacionDebeHaberEnt.GrupoHaberId = Convert.ToInt32(Dt.Rows(0).Item("GrupoHaberId"))
            ObjRelacionDebeHaberEnt.DebeId = Convert.ToInt32(Dt.Rows(0).Item("DebeId"))
            ObjRelacionDebeHaberEnt.HaberId = Convert.ToInt32(Dt.Rows(0).Item("HaberId"))
            ObjRelacionDebeHaberEnt.SignoDebe = Convert.ToInt32(Dt.Rows(0).Item("SignoDebe"))
            ObjRelacionDebeHaberEnt.SignoHaber = Convert.ToInt32(Dt.Rows(0).Item("SignoHaber"))
        End If
        Return ObjRelacionDebeHaberEnt
    End Function

    Public Function Eliminar(ByVal VarRelacionDebeHaberEnt As EntRelacionDebeHaber) As Boolean
        Return ObjRelacionDebeHaberDat.EliminarRelacionDebeHaber(VarRelacionDebeHaberEnt)
    End Function

    Public Function Guardar(ByVal VarRelacionDebeHaberEnt As EntRelacionDebeHaber) As Boolean
        Return ObjRelacionDebeHaberDat.CrearRelacionDebeHaber(VarRelacionDebeHaberEnt)
    End Function

    Public Function Actualizar(ByVal VarRelacionDebeHaberEnt As EntRelacionDebeHaber) As Boolean
        Return ObjRelacionDebeHaberDat.ActualizarRelacionDebeHaber(VarRelacionDebeHaberEnt)
    End Function

End Class
