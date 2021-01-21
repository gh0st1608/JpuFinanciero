Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatEstadoResultado

    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearEstadoResultado(ByVal objEstadoResultado As EntEstadoResultado) As Boolean
        Try
            connection.Open()
            Command = New SqlCommand("CrearEstadoResultado", connection)
            Command.CommandType = CommandType.StoredProcedure
            Command.Parameters.Add("@Orden", SqlDbType.Int)
            command.Parameters.Add("@Concepto", SqlDbType.VarChar)
            command.Parameters.Add("@Valor", SqlDbType.Decimal)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@Orden").Value = objEstadoResultado.Orden
            command.Parameters("@Concepto").Value = objEstadoResultado.Concepto
            command.Parameters("@Valor").Value = objEstadoResultado.Valor
            command.Parameters("@PeriodoId").Value = objEstadoResultado.PeriodoId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para EstadoResultado")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerEstadoResultado(ByVal IdEstadoResultado As Integer, ByVal PeriodoId As Integer, ByVal Orden As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerEstadoResultado", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdEstadoResultado", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Orden", SqlDbType.Int)
            command.Parameters("@IdEstadoResultado").Value = IdEstadoResultado
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters("@Orden").Value = Orden
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para EstadoResultado")
            connection.Close()
            Return Nothing
        End Try
    End Function

    Public Function ObtenerEstadoResultado(ByVal IdPeriodo As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerEstadoResultadoCalculado", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPeriodo", SqlDbType.Int)
            command.Parameters("@IdPeriodo").Value = IdPeriodo
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para EstadoResultado")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
