Imports ERP_Entidad
Imports ERP_Datos

Public Class NegRelacionDebeHaber
    Dim ObjRelacionDebeHaberEnt As New EntRelacionDebeHaber
    Dim ObjRelacionDebeHaberDat As New DatRelacionDebeHaber
    Public Function ObtenerTabla(ByVal TipoRelacionDebeHaberId As Integer, ByVal OrigenId As Integer) As DataTable

        Return ObjRelacionDebeHaberDat.LeerRelacionDebeHaber(0, TipoRelacionDebeHaberId)

    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal TipoRelacionDebeHaberId As Integer, ByVal OrigenId As Integer) As EntRelacionDebeHaber

        Dim Dt As DataTable

        Dt = ObjRelacionDebeHaberDat.LeerRelacionDebeHaber(Id, TipoRelacionDebeHaberId)

        ObjRelacionDebeHaberEnt.IdRelacionDebeHaber = Convert.ToInt32(Dt.Rows(0).Item("IdRelacionDebeHaber"))
        'ObjRelacionDebeHaberEnt.OrigenId = Convert.ToInt32(Dt.Rows(0).Item("OrigenId"))
        'ObjRelacionDebeHaberEnt.NombreCompleto = Convert.ToString(Dt.Rows(0).Item("NombreCompleto"))
        'ObjRelacionDebeHaberEnt.Cargo = Convert.ToString(Dt.Rows(0).Item("Cargo"))
        'ObjRelacionDebeHaberEnt.Correo = Convert.ToString(Dt.Rows(0).Item("Correo"))
        'ObjRelacionDebeHaberEnt.Celular = Convert.ToString(Dt.Rows(0).Item("Celular"))
        'ObjRelacionDebeHaberEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        'ObjRelacionDebeHaberEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

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
