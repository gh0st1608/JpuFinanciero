Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatPasivo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearPasivo(ByVal objPasivo As EntPasivo) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("CrearPasivo", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@GrupoPasivoId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Monto", SqlDbType.Money)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)


            command.Parameters("@GrupoPasivoId").Value = objPasivo.GrupoPasivoId
            command.Parameters("@PeriodoId").Value = objPasivo.PeriodoId
            command.Parameters("@Monto").Value = objPasivo.Monto
            command.Parameters("@UsuarioCreacionId").Value = objPasivo.UsuarioCreacionId


            command.ExecuteReader()
            connection.Close()

            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pasivo")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarPasivo(ByVal objPasivo As EntPasivo) As Integer
        Dim command As SqlCommand
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
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pasivo")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function EliminarPasivo(ByVal objPasivo) As Integer
        Dim command As SqlCommand
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
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pasivo")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerPasivo(ByVal IdPasivo As Integer, ByVal PeriodoId As Integer, ByVal ClienteId As Integer) As DataTable
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try

            connection.Open()
            command = New SqlCommand("LeerPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPasivo", SqlDbType.Int)
            command.Parameters("@IdPasivo").Value = IdPasivo
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters.Add("@ClienteId", SqlDbType.Int)
            command.Parameters("@ClienteId").Value = ClienteId

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()

            Return resultadoDT

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pasivo")
            connection.Close()
            Return Nothing

        End Try
    End Function
End Class
