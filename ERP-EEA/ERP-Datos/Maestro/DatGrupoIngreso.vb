Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks

Imports ERP_Entidad

Public Class DatGrupoIngreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = 1
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objGrupoIngreso.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarGrupoIngreso(ByVal objGrupoIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerGrupoIngreso(ByVal IdGrupoIngreso As Integer, ByVal Descripcion As String) As DataTable
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters("@IdGrupoIngreso").Value = IdGrupoIngreso
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters("@Descripcion").Value = Descripcion
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
