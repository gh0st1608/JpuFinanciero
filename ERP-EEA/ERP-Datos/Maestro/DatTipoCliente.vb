Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad
Public Class DatTipoCliente
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearTipoCliente(ByVal objTipoCliente As EntTipoCliente) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearTipoCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objTipoCliente.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = objTipoCliente.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Tipo Cliente")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarTipoCliente(ByVal objTipoCliente As EntTipoCliente) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarTipoCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdTipoCliente", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdTipoCliente").Value = objTipoCliente.IdTipoCliente
            command.Parameters("@Descripcion").Value = objTipoCliente.Descripcion
            command.Parameters("@UsuarioModificacionId").Value = objTipoCliente.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objTipoCliente.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Tipo Cliente")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarTipoCliente(ByVal objTipoCliente As EntTipoCliente) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarTipoCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdTipoCliente", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdTipoCliente").Value = objTipoCliente.IdTipoCliente
            command.Parameters("@UsuarioModificacionId").Value = objTipoCliente.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Tipo Cliente")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerTipoCliente(ByVal IdTipoCliente As Integer, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerTipoCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdTipoCliente", SqlDbType.Int)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdTipoCliente").Value = IdTipoCliente
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Tipo Cliente")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
