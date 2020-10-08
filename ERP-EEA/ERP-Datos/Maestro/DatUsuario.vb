Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks
Imports ERP_Entidad
Public Class DatUsuario

    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearUsuario(ByVal objUsuario As EntUsuario) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("CrearUsuario", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@NombreUsuario", SqlDbType.VarChar)
            command.Parameters.Add("@NombreCompleto", SqlDbType.VarChar)
            command.Parameters.Add("@Contraseña", SqlDbType.VarChar)
            command.Parameters("@NombreUsuario").Value = objUsuario.NombreUsuario
            command.Parameters("@NombreCompleto").Value = objUsuario.NombreCompleto
            command.Parameters("@Contraseña").Value = objUsuario.Contraseña
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Usuario")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarUsuario(ByVal objUsuario As EntUsuario) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarUsuario", connection)
            command.CommandType = CommandType.StoredProcedure
            'Actualizar
            command.Parameters.Add("@IdUsuario", SqlDbType.Int)
            command.Parameters.Add("@NombreUsuario", SqlDbType.VarChar)
            command.Parameters.Add("@NombreCompleto", SqlDbType.VarChar)
            command.Parameters.Add("@Contraseña", SqlDbType.VarChar)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdUsuario").Value = objUsuario.IdUsuario
            command.Parameters("@NombreUsuario").Value = objUsuario.NombreUsuario
            command.Parameters("@NombreCompleto").Value = objUsuario.NombreCompleto
            command.Parameters("@Contraseña").Value = objUsuario.Contraseña
            command.Parameters("@EstadoActivo").Value = objUsuario.EstadoId
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Usuario")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarUsuario(ByVal objUsuario As EntUsuario) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarUsuario", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdUsuario", SqlDbType.Int)
            command.Parameters("@IdUsuario").Value = objUsuario.IdUsuario
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Usuario")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerUsuario(ByVal IdUsuario As Integer, ByVal NombreUsuario As String) As DataTable
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerUsuario", connection)
            command.CommandType = CommandType.StoredProcedure
            adapter = New SqlDataAdapter(command)
            command.Parameters.Add("@IdUsuario", SqlDbType.Int)
            command.Parameters.Add("@NombreUsuario", SqlDbType.VarChar)
            command.Parameters("@IdUsuario").Value = IdUsuario
            command.Parameters("@NombreUsuario").Value = NombreUsuario
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Usuario")
            connection.Close()
            Return Nothing
        End Try
    End Function

    Public Function Autenticar(ByVal objUsuario As EntUsuario) As Boolean
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarUsuario", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdUsuario", SqlDbType.Int)
            command.Parameters("@IdUsuario").Value = objUsuario.IdUsuario
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Usuario")
            connection.Close()
            Return False
        End Try
    End Function

End Class
