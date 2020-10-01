Imports ERP_Entidad
Imports ERP_Datos

Public Class NegContacto
    Dim ObjContactoEnt As New EntContacto
    Dim ObjContactoDat As New DatContacto
    Public Function ObtenerTabla(ByVal TipoContactoId As Integer, ByVal OrigenId As Integer) As DataTable

        Return ObjContactoDat.LeerContacto(0, TipoContactoId, OrigenId) '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal TipoContactoId As Integer, ByVal OrigenId As Integer) As EntContacto

        Dim Dt As DataTable

        Dt = ObjContactoDat.LeerContacto(Id, TipoContactoId, OrigenId)
        'Traspasar los datos Del datagrid a la entidad
        ObjContactoEnt.IdContacto = Convert.ToInt32(Dt.Rows(0).Item("IdContacto"))
        ObjContactoEnt.OrigenId = Convert.ToInt32(Dt.Rows(0).Item("OrigenId"))
        ObjContactoEnt.NombreCompleto = Convert.ToString(Dt.Rows(0).Item("NombreCompleto"))
        ObjContactoEnt.Cargo = Convert.ToString(Dt.Rows(0).Item("Cargo"))
        ObjContactoEnt.Correo = Convert.ToString(Dt.Rows(0).Item("Correo"))
        ObjContactoEnt.Celular = Convert.ToString(Dt.Rows(0).Item("Celular"))
        ObjContactoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        ObjContactoEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjContactoEnt

    End Function

    Public Function Eliminar(ByVal ObjContactoEnt As EntContacto) As Boolean

        Return ObjContactoDat.EliminarContacto(ObjContactoEnt)

    End Function

    Public Function Guardar(ByVal ObjContactoEnt As EntContacto) As Boolean

        Return ObjContactoDat.CrearContacto(ObjContactoEnt)

    End Function

    Public Function Actualizar(ByVal ObjContactoEnt As EntContacto) As Boolean

        Return ObjContactoDat.ActualizarContacto(ObjContactoEnt)

    End Function
End Class
