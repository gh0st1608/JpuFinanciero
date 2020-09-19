Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos

Public Class NegParametro
    Dim ObjParametroEnt = New EntParametro
    Dim ObjParametroDat As New DatParametro
    Public Function ObtenerTabla(ByVal ObjParametroDat As DatParametro) As DataTable

        Return ObjParametroDat.LeerParametro(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntPago 'Mostrar el detalle al hacer click en el dgv

        Dim Dt As DataTable

        Dt = ObjParametroDat.LeerParametro(Id, "")

        ObjParametroEnt.Id = Convert.ToInt32(Dt.Rows(0).Item("IdPago"))
        ObjParametroEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjParametroEnt.EstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjParametroEnt

    End Function



    Public Function Eliminar(ByVal ObjParametroEnt As EntParametro) As Boolean

        Return ObjParametroDat.EliminarParametro(ObjParametroEnt)

    End Function

    Public Function Guardar(ByVal ObjParametroEnt As EntParametro) As Boolean

        Return ObjParametroDat.CrearParametro(ObjParametroEnt)

    End Function

    Public Function Actualizar(ByVal ObjParametroEnt As EntParametro) As Boolean

        Return ObjParametroDat.ActualizarParametro(ObjParametroEnt)

    End Function

End Class
