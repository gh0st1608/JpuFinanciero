Imports System.Globalization
Imports System.Collections.Generic
Imports System.Data


Imports ERP_Entidad
Imports ERP_Datos


Public Class NegParametro
    Dim ObjParametroEnt = New EntParametro
    Dim ObjParametroDat As New DatParametro
    Public Function ObtenerTabla() As DataTable

        Return ObjParametroDat.LeerParametro(0, "", "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntParametro 'Mostrar el detalle al hacer click en el dgv

        Dim Dt As DataTable

        Dt = ObjParametroDat.LeerParametro(Id, "", "")

        ObjParametroEnt.IdParametro = Convert.ToInt32(Dt.Rows(0).Item("IdParametro"))
        ObjParametroEnt.TipoParametro = Convert.ToString(Dt.Rows(0).Item("TipoParametro"))
        ObjParametroEnt.ValorParametro = Convert.ToDecimal(Dt.Rows(0).Item("ValorParametro"))
        ObjParametroEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjParametroEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        ObjParametroEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjParametroEnt

    End Function


    Public Function ObtenerLista(ByVal TipoParametro As String, ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntParametro)

        Dim result = New List(Of EntParametro)
        Dim resultadoElemento As EntParametro
        Dim Dt As DataTable


        Dt = ObjParametroDat.LeerParametro(0, "", TipoParametro)

        If (Dt.Rows.Count() > 0) Then

            If (Filtro) Then

                resultadoElemento = New EntParametro
                resultadoElemento.IdParametro = 0
                resultadoElemento.Descripcion = "Todos" 'le da el primer valor
                result.Add(resultadoElemento)

            End If

            If (Seleccion) Then

                resultadoElemento = New EntParametro
                resultadoElemento.IdParametro = 0
                resultadoElemento.Descripcion = "Seleccione" 'le da el primer valor
                result.Add(resultadoElemento)

            End If

            For i = 0 To Dt.Rows.Count - 1 Step 1

                resultadoElemento = New EntParametro
                resultadoElemento.IdParametro = Convert.ToInt16(Dt.Rows(i).Item("IdParametro"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)

            Next i
        Else

            Return Nothing

        End If


        Return result
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
