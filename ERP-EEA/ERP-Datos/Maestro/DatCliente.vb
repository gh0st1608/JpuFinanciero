Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad
Public Class DatCliente
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearCliente(ByVal objCliente As EntCliente) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("CrearCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@TipoClienteId", SqlDbType.Int)
            command.Parameters.Add("@RazonSocial", SqlDbType.VarChar)
            command.Parameters.Add("@Documento", SqlDbType.VarChar)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar)
            command.Parameters.Add("@MetaEntidad", SqlDbType.Float)
            command.Parameters.Add("@MetaEmpresa", SqlDbType.Float)
            command.Parameters.Add("@Correo", SqlDbType.VarChar)
            command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@TipoClienteId").Value = objCliente.TipoClienteId
            command.Parameters("@RazonSocial").Value = objCliente.RazonSocial
            command.Parameters("@Documento").Value = objCliente.Documento
            command.Parameters("@Descripcion").Value = objCliente.Descripcion
            command.Parameters("@MetaEntidad").Value = objCliente.MetaEntidad
            command.Parameters("@MetaEmpresa").Value = objCliente.MetaEmpresa
            command.Parameters("@Correo").Value = objCliente.Correo
            command.Parameters("@NumeroContacto").Value = objCliente.NumeroContacto
            command.Parameters("@UsuarioCreacionId").Value = objCliente.UsuarioCreacionId
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Cliente")
            connection.Close()
            Return Nothing
        End Try
    End Function

    Public Function ActualizarCliente(ByVal objCliente As EntCliente) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdCliente", SqlDbType.Int)
            command.Parameters.Add("@TipoClienteId", SqlDbType.Int)
            command.Parameters.Add("@RazonSocial", SqlDbType.VarChar)
            command.Parameters.Add("@Documento", SqlDbType.VarChar)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar)
            command.Parameters.Add("@MetaEntidad", SqlDbType.Float)
            command.Parameters.Add("@MetaEmpresa", SqlDbType.Float)
            command.Parameters.Add("@Correo", SqlDbType.VarChar)
            command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@IdEstadoActivo", SqlDbType.Int)
            command.Parameters("@IdCliente").Value = objCliente.IdCliente
            command.Parameters("@TipoClienteId").Value = objCliente.TipoClienteId
            command.Parameters("@RazonSocial").Value = objCliente.RazonSocial
            command.Parameters("@Documento").Value = objCliente.Documento
            command.Parameters("@Descripcion").Value = objCliente.Descripcion
            command.Parameters("@MetaEntidad").Value = objCliente.MetaEntidad
            command.Parameters("@MetaEmpresa").Value = objCliente.MetaEmpresa
            command.Parameters("@Correo").Value = objCliente.Correo
            command.Parameters("@NumeroContacto").Value = objCliente.NumeroContacto
            command.Parameters("@UsuarioModificacionId").Value = objCliente.UsuarioModificacionId
            command.Parameters("@IdEstadoActivo").Value = objCliente.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Cliente")
            connection.Close()
            Return False
        End Try

    End Function

    Public Function EliminarCliente(ByVal objCliente As EntCliente) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdCliente", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdCliente").Value = objCliente.IdCliente
            command.Parameters("@UsuarioModificacionId").Value = objCliente.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Cliente")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerCliente(ByVal IdCliente As Integer, ByVal Descripcion As String) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerCliente", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdCliente", SqlDbType.Int)
            command.Parameters("@IdCliente").Value = IdCliente
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Cliente")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
