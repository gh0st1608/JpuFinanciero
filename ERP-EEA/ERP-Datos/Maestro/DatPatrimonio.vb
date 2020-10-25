Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatPatrimonio
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearPatrimonio(ByVal objPatrimonio As EntPatrimonio) As Boolean
        Try
            connection.Open()
            Command = New SqlCommand("CrearPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@GrupoPatrimonioId", SqlDbType.Int)
            Command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            Command.Parameters.Add("@Monto", SqlDbType.Money)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@GrupoPatrimonioId").Value = objPatrimonio.GrupoPatrimonioId
            Command.Parameters("@PeriodoId").Value = objPatrimonio.PeriodoId
            Command.Parameters("@Monto").Value = objPatrimonio.Monto
            command.Parameters("@UsuarioCreacionId").Value = objPatrimonio.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Patrimonio")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarPatrimonio(ByVal objPatrimonio As EntPatrimonio) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPatrimonio", SqlDbType.Int)
            command.Parameters.Add("@GrupoPatrimonioId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Monto", SqlDbType.Bit)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdPatrimonio").Value = objPatrimonio.IdPatrimonio
            command.Parameters("@GrupoPatrimonioId").Value = objPatrimonio.GrupoPatrimonioId
            command.Parameters("@PeriodoId").Value = objPatrimonio.PeriodoId
            command.Parameters("@Monto").Value = objPatrimonio.Monto
            command.Parameters("@UsuarioModificacionId").Value = objPatrimonio.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Patrimonio")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarPatrimonio(ByVal objPatrimonio) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPatrimonio", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdPatrimonio").Value = objPatrimonio.IdIngreso
            command.Parameters("@UsuarioModificacionId").Value = objPatrimonio.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Patrimonio")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerPatrimonio(ByVal IdPatrimonio As Integer, ByVal PeriodoId As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPatrimonio", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@IdPatrimonio").Value = IdPatrimonio
            command.Parameters("@PeriodoId").Value = PeriodoId
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Patrimonio")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
