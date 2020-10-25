Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatParametro
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearParametro(ByVal objParametro As EntParametro) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearParametro", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@TipoParametro", SqlDbType.VarChar, 20)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@ValorParametro", SqlDbType.Float)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@TipoParametro").Value = objParametro.TipoParametro
            command.Parameters("@Descripcion").Value = objParametro.Descripcion
            command.Parameters("@ValorParametro").Value = objParametro.ValorParametro
            command.Parameters("@UsuarioCreacionId").Value = objParametro.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Parametro")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarParametro(ByVal objParametro As EntParametro) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarParametro", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdParametro", SqlDbType.Int)
            'command.Parameters.Add("@TipoParametro", SqlDbType.VarChar, 20)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@ValorParametro", SqlDbType.Float)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdParametro").Value = objParametro.IdParametro
            'command.Parameters("@TipoParametro").Value = objParametro.TipoParametro
            command.Parameters("@Descripcion").Value = objParametro.Descripcion
            command.Parameters("@ValorParametro").Value = objParametro.ValorParametro
            command.Parameters("@UsuarioModificacionId").Value = objParametro.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objParametro.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Parametro")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarParametro(ByVal objParametro As EntParametro) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarParametro", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdParametro", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdParametro").Value = objParametro.IdParametro
            command.Parameters("@UsuarioModificacionId").Value = objParametro.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Parametro")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerParametro(ByVal IdParametro As Integer, ByVal Descripcion As String, ByVal TipoParametro As String) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerParametro", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdParametro", SqlDbType.Int)
            command.Parameters("@IdParametro").Value = IdParametro
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters("@Descripcion").Value = Descripcion
            command.Parameters.Add("@TipoParametro", SqlDbType.VarChar, 50)
            command.Parameters("@TipoParametro").Value = TipoParametro
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Parametro")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
