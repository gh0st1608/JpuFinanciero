Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos

Public Class NegGrupoPatrimonio
    Dim ObjGrupoPatrimonioEnt = New EntGrupoPatrimonio
    Dim ObjGrupoPatrimonioDat As New DatGrupoPatrimonio
    Public Function ObtenerTabla() As DataTable

        Return ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoPatrimonio 'Detalle de un item

        Dim Dt As DataTable

        Dt = ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(Id, "")

        ObjGrupoPatrimonioEnt.IdGrupoPatrimonio = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoPatrimonio"))
        ObjGrupoPatrimonioEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjGrupoPatrimonioEnt.Cuenta = Convert.ToInt32(Dt.Rows(0).Item("Cuenta"))
        ObjGrupoPatrimonioEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        ObjGrupoPatrimonioEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjGrupoPatrimonioEnt

    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoPatrimonio)

        Dim result = New List(Of EntGrupoPatrimonio)
        Dim resultadoElemento As EntGrupoPatrimonio
        Dim Dt As DataTable


        Dt = ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(0, "")

        If (Dt.Rows.Count() > 0) Then

            If (Filtro) Then

                resultadoElemento = New EntGrupoPatrimonio
                resultadoElemento.IdGrupoPatrimonio = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)

            End If

            If (Seleccion) Then

                resultadoElemento = New EntGrupoPatrimonio
                resultadoElemento.IdGrupoPatrimonio = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)

            End If

            For i = 0 To Dt.Rows.Count - 1 Step 1

                resultadoElemento = New EntGrupoPatrimonio
                resultadoElemento.IdGrupoPatrimonio = Convert.ToInt32(Dt.Rows(i).Item("IdGrupoPatrimonio"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)

            Next i
        Else

            Return Nothing

        End If


        Return result
    End Function

    Public Function Eliminar(ByVal ObjGrupoPatrimonio As EntGrupoPatrimonio) As Boolean

        Return ObjGrupoPatrimonioDat.EliminarGrupoPatrimonio(ObjGrupoPatrimonio)

    End Function

    Public Function Guardar(ByVal ObjGrupoPatrimonio As EntGrupoPatrimonio) As Boolean

        Return ObjGrupoPatrimonioDat.CrearGrupoPatrimonio(ObjGrupoPatrimonio)

    End Function

    Public Function Actualizar(ByVal ObjGrupoPatrimonio As EntGrupoPatrimonio) As Boolean

        Return ObjGrupoPatrimonioDat.ActualizarGrupoPatrimonio(ObjGrupoPatrimonio)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjGrupoPatrimonioDat.LeerGrupoPatrimonio(0, Descripcion)

    End Function
End Class
