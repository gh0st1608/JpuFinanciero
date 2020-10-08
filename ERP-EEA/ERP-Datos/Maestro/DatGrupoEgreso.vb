Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks

Imports ERP_Entidad

Public Class DatGrupoEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearGrupoEgreso(ByVal objGrupoIngreso As EntGrupoEgreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = 1
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarGrupoEgreso(ByVal objGrupoIngreso As EntGrupoEgreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Estado", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModficacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = objGrupoIngreso.IdGrupoEgreso
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@Estado").Value = objGrupoIngreso.EstadoActivo
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function EliminarGrupoEgreso(ByVal objGrupoIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModiciacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerGrupoEgreso(ByVal IdGrupoEgreso As Integer) As DataTable
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = IdGrupoEgreso
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
