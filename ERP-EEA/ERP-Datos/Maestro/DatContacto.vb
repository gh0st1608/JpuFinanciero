﻿Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatContacto
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearContacto(ByVal objContacto As EntContacto) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearContacto", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@TipoContactoId", SqlDbType.Int)
            command.Parameters.Add("@Cargo", SqlDbType.VarChar)
            command.Parameters.Add("@NombreCompleto", SqlDbType.VarChar)
            command.Parameters.Add("@OrigenId", SqlDbType.Int)
            command.Parameters.Add("@Correo", SqlDbType.VarChar)
            command.Parameters.Add("@Celular", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@TipoContactoId").Value = objContacto.TipoContactoId
            command.Parameters("@Cargo").Value = objContacto.Cargo
            command.Parameters("@NombreCompleto").Value = objContacto.NombreCompleto
            command.Parameters("@OrigenId").Value = objContacto.OrigenId
            command.Parameters("@Correo").Value = objContacto.Correo
            command.Parameters("@Celular").Value = objContacto.Celular
            command.Parameters("@UsuarioCreacionId").Value = objContacto.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Contacto")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarContacto(ByVal objContacto As EntContacto) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarContacto", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdContacto", SqlDbType.Int)
            command.Parameters.Add("@TipoContactoId", SqlDbType.Int)
            command.Parameters.Add("@Cargo", SqlDbType.VarChar)
            command.Parameters.Add("@NombreCompleto", SqlDbType.VarChar)
            command.Parameters.Add("@OrigenId", SqlDbType.Int)
            command.Parameters.Add("@Correo", SqlDbType.VarChar)
            command.Parameters.Add("@Celular", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdContacto").Value = objContacto.IdContacto
            command.Parameters("@TipoContactoId").Value = objContacto.TipoContactoId
            command.Parameters("@Cargo").Value = objContacto.Cargo
            command.Parameters("@NombreCompleto").Value = objContacto.NombreCompleto
            command.Parameters("@OrigenId").Value = objContacto.OrigenId
            command.Parameters("@Correo").Value = objContacto.Correo
            command.Parameters("@Celular").Value = objContacto.Celular
            command.Parameters("@UsuarioModificacionId").Value = objContacto.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objContacto.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Contacto")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarContacto(ByVal objContacto As EntContacto) As Boolean
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarContacto", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdContacto", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdContacto").Value = objContacto.IdContacto
            command.Parameters("@UsuarioModificacionId").Value = objContacto.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Contacto")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerContacto(ByVal IdContacto As Integer, ByVal TipoContactoId As Integer, ByVal OrigenId As Integer, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerContacto", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdContacto", SqlDbType.Int)
            command.Parameters.Add("@TipoContactoId", SqlDbType.Int)
            command.Parameters.Add("@OrigenId", SqlDbType.Int)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdContacto").Value = IdContacto
            command.Parameters("@TipoContactoId").Value = TipoContactoId
            command.Parameters("@OrigenId").Value = OrigenId
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Contacto")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class