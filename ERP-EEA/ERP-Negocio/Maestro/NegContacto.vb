Imports ERP_Entidad
Imports ERP_Datos

Public Class NegContacto
    Dim ObjContactoEnt As New EntContacto
    Dim ObjContactoDat As New DatContacto
    Public Function ObtenerTabla(ByVal TipoContactoId As Integer, ByVal OrigenId As Integer) As DataTable
        Return ObjContactoDat.LeerContacto(0, TipoContactoId, OrigenId)
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal TipoContactoId As Integer, ByVal OrigenId As Integer) As EntContacto
        Dim Dt As DataTable
        Dt = ObjContactoDat.LeerContacto(Id, TipoContactoId, OrigenId)
        If (Dt.Rows.Count() > 0) Then
            ObjContactoEnt.IdContacto = Convert.ToInt32(Dt.Rows(0).Item("IdContacto"))
            ObjContactoEnt.OrigenId = Convert.ToInt32(Dt.Rows(0).Item("OrigenId"))
            ObjContactoEnt.NombreCompleto = Convert.ToString(Dt.Rows(0).Item("NombreCompleto"))
            ObjContactoEnt.Cargo = Convert.ToString(Dt.Rows(0).Item("Cargo"))
            ObjContactoEnt.Correo = Convert.ToString(Dt.Rows(0).Item("Correo"))
            ObjContactoEnt.Celular = Convert.ToString(Dt.Rows(0).Item("Celular"))
            ObjContactoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
            ObjContactoEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))
        End If
        Return ObjContactoEnt
    End Function

    Public Function Eliminar(ByVal VarContactoEnt As EntContacto) As Boolean
        Return ObjContactoDat.EliminarContacto(VarContactoEnt)
    End Function

    Public Function Guardar(ByVal VarContactoEnt As EntContacto) As Boolean
        Return ObjContactoDat.CrearContacto(VarContactoEnt)
    End Function

    Public Function Actualizar(ByVal VarContactoEnt As EntContacto) As Boolean
        Return ObjContactoDat.ActualizarContacto(VarContactoEnt)
    End Function
End Class
