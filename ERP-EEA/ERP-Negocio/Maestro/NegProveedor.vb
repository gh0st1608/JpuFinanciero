﻿Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos



Public Class NegProveedor

    Dim ObjProveedorEnt = New EntProveedor
    Dim ObjProveedorDat As New DatProveedor
    Public Function ObtenerTabla(ByVal ObjProveedorDat As DatProveedor) As DataTable

        Return ObjProveedorDat.LeerProveedor(0, "") '0 entra como IdProveedor = 0 pero en el proc lo filtra

    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntProveedor

        Dim Dt As DataTable

        Dt = ObjProveedorDat.LeerProveedor(Id, "")

        ObjProveedorEnt.Id = Convert.ToInt32(Dt.Rows(0).Item("IdProveedor"))
        ObjProveedorEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
        ObjProveedorEnt.EstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("EstadoActivo"))
        'agrego algo màs  :?
        Return ObjProveedorEnt

    End Function

    Public Function ObtenerLista(ByVal Id As Integer, ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntProveedor)

        Dim result = New List(Of EntProveedor)
        Dim resultadoElemento As EntProveedor
        Dim Dt As DataTable

        Dt = ObjProveedorDat.LeerProveedor(Id, "")

        If (Dt.Rows.Count() > 0) Then

            If (Filtro) Then

                resultadoElemento = New EntProveedor
                resultadoElemento.IdProveedor = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)

            End If

            If (Seleccion) Then

                resultadoElemento = New EntProveedor
                resultadoElemento.IdProveedor = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)

            End If

            For i = 0 To Dt.Rows.Count Step 1

                resultadoElemento = New EntProveedor
                resultadoElemento.IdProveedor = Convert.ToInt16(Dt.Rows(i).Item("IDEmpresa"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("NombreEmpresa"))
                'agrego algo màs  :?
                result.Add(resultadoElemento)

            Next i
        Else

            Return Nothing

        End If


        Return result
    End Function

    Public Function Eliminar(ByVal ObjProveedorEnt As EntProveedor) As Boolean

        Return ObjProveedorDat.EliminarProveedor(ObjProveedorEnt)

    End Function

    Public Function Guardar(ByVal ObjProveedor As EntProveedor) As Boolean

        Return ObjProveedorDat.CrearProveedor(ObjProveedor)

    End Function

    Public Function Actualizar(ByVal ObjProveedor As EntProveedor) As Boolean

        Return ObjProveedorDat.ActualizarProveedor(ObjProveedorEnt)

    End Function

    Public Function ObtenerTablaConFiltro(ByVal Descripcion As String) As DataTable

        Return ObjProveedorDat.LeerProveedor(0, Descripcion)

    End Function

End Class