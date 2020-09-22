Imports System
Imports System.Collections.Generic
Imports System.Data


Imports ERP_Entidad
Imports ERP_Datos


Public Class NegParametro
    Dim ObjParametroEnt = New EntParametro
    Dim ObjParametroDat As New DatParametro
    Public Function ObtenerTabla() As DataTable

        Return ObjParametroDat.LeerParametro(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntParametro 'Mostrar el detalle al hacer click en el dgv

        Dim Dt As DataTable

        Dt = ObjParametroDat.LeerParametro(Id, "")

        ObjParametroEnt.IdParametro = Convert.ToInt32(Dt.Rows(0).Item("IdParametro"))
        ObjParametroEnt.TipoParametro = Convert.ToString(Dt.Rows(0).Item("TipoParametro"))
        ObjParametroEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjParametroEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        ObjParametroEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjParametroEnt

    End Function


    Public Function Eliminar(ByVal VarParametroEnt As EntParametro) As Boolean

        Return ObjParametroDat.EliminarParametro(VarParametroEnt)

    End Function

    Public Function Guardar(ByVal VarParametroEnt As EntParametro) As Boolean

        Return ObjParametroDat.CrearParametro(VarParametroEnt)

    End Function

    Public Function Actualizar(ByVal VarParametroEnt As EntParametro) As Boolean

        Return ObjParametroDat.ActualizarParametro(VarParametroEnt)

    End Function

End Class
