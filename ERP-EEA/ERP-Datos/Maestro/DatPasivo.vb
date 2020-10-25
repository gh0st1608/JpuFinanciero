Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatPasivo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearPasivo(ByVal objPasivo As EntPasivo) As Boolean
        Try
            connection.Open()
            Command = New SqlCommand("CrearPasivo", connection)
            Command.CommandType = CommandType.StoredProcedure
            Command.Parameters.Add("@GrupoPasivoId", SqlDbType.Int)
            Command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            Command.Parameters.Add("@Monto", SqlDbType.Money)
            Command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            Command.Parameters("@GrupoPasivoId").Value = objPasivo.GrupoPasivoId
            Command.Parameters("@PeriodoId").Value = objPasivo.PeriodoId
            Command.Parameters("@Monto").Value = objPasivo.Monto
            Command.Parameters("@UsuarioCreacionId").Value = objPasivo.UsuarioCreacionId
            Command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Pasivo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarPasivo(ByVal objPasivo As EntPasivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPasivo", SqlDbType.Int)
            command.Parameters.Add("@GrupoPasivoId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Monto", SqlDbType.Bit)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdPasivo").Value = objPasivo.IdPasivo
            command.Parameters("@GrupoPasivoId").Value = objPasivo.GrupoPasivoId
            command.Parameters("@PeriodoId").Value = objPasivo.PeriodoId
            command.Parameters("@Monto").Value = objPasivo.Monto
            command.Parameters("@UsuarioModificacionId").Value = objPasivo.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Pasivo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarPasivo(ByVal objPasivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPasivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdPasivo").Value = objPasivo.IdIngreso
            command.Parameters("@UsuarioModificacionId").Value = objPasivo.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Pasivo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerPasivo(ByVal IdPasivo As Integer, ByVal PeriodoId As Integer, ByVal ClienteId As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPasivo", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@IdPasivo").Value = IdPasivo
            command.Parameters("@PeriodoId").Value = PeriodoId
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Pasivo")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
