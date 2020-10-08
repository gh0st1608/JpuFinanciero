﻿Imports System
Imports System.Collections.Generic
Imports System.Data

Imports ERP_Entidad
Imports ERP_Datos

Public Class NegUsuario
    Dim ObjUsuarioEnt As New EntUsuario
    Dim ObjUsuarioDat As New DatUsuario
    Public Function ObtenerTabla() As DataTable
        Return ObjUsuarioDat.LeerUsuario(0, "")
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal NombreUsuario As String) As EntUsuario
        Dim Dt As DataTable
        Dt = ObjUsuarioDat.LeerUsuario(Id, NombreUsuario)
        ObjUsuarioEnt.IdUsuario = Convert.ToInt32(Dt.Rows(0).Item("IdUsuario"))
        ObjUsuarioEnt.NombreCompleto = Convert.ToString(Dt.Rows(0).Item("NombreCompleto"))
        ObjUsuarioEnt.NombreUsuario = Convert.ToString(Dt.Rows(0).Item("NombreUsuario"))
        ObjUsuarioEnt.Contraseña = Convert.ToString(Dt.Rows(0).Item("Contraseña"))
        ObjUsuarioEnt.EstadoId = Convert.ToInt32(Dt.Rows(0).Item("EstadoId"))
        ObjUsuarioEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))

        Return ObjUsuarioEnt

    End Function


    Public Function Eliminar(ByVal varUsuarioEnt As EntUsuario) As Boolean

        Return ObjUsuarioDat.EliminarUsuario(varUsuarioEnt)

    End Function

    Public Function Guardar(ByVal varUsuarioEnt As EntUsuario) As Boolean

        Return ObjUsuarioDat.CrearUsuario(varUsuarioEnt)

    End Function

    Public Function Actualizar(ByVal varUsuarioEnt As EntUsuario) As Boolean

        Return ObjUsuarioDat.ActualizarUsuario(varUsuarioEnt)

    End Function

    Public Function Autenticar(ByVal varUsuarioEnt As EntUsuario) As Boolean

        Return ObjUsuarioDat.Autenticar(varUsuarioEnt)

    End Function
End Class
