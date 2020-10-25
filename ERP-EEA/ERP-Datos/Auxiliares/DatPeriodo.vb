﻿Imports System.Data.SqlClient
Imports System.Configuration
Public Class DatPeriodo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Dim adapter As SqlDataAdapter
    Public Function LeerPeriodo(ByVal IdPeriodo As Integer, ByVal DescripcionPeriodo As String) As DataTable
        Try
            Dim resultadoDT As DataTable
            Dim resultadoDS As New DataSet
            connection.Open()
            command = New SqlCommand("LeerPeriodo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@DescripcionPeriodo", SqlDbType.VarChar, 10)
            command.Parameters.Add("@IdPeriodo", SqlDbType.Int)
            command.Parameters("@DescripcionPeriodo").Value = DescripcionPeriodo
            command.Parameters("@IdPeriodo").Value = IdPeriodo
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Periodo")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
