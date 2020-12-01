Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatReporte
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand

    Public Function ObtenerDataReporteIngresos(ByVal ParGrupoIngresoId As Integer, ByVal ParClienteId As Integer, ByVal ParPeriodoInicio As Integer, ByVal ParPeriodoFin As Integer, ByVal ParTotal As Integer) As DataSet

        Dim resultadoDS As New DataSet
        Dim adapter As New SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerReporteIngresos", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@GrupoIngresoId", SqlDbType.Int)
            command.Parameters.Add("@ClienteId", SqlDbType.Int)
            command.Parameters.Add("@FechaInicio", SqlDbType.Int)
            command.Parameters.Add("@FechaFin", SqlDbType.Int)
            command.Parameters.Add("@Total", SqlDbType.VarChar)

            command.Parameters("@GrupoIngresoId").Value = ParGrupoIngresoId
            command.Parameters("@ClienteId").Value = ParClienteId
            command.Parameters("@PeriodoInicio").Value = ParPeriodoInicio
            command.Parameters("@PeriodoFin").Value = ParPeriodoFin
            command.Parameters("@Total").Value = ParTotal

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            connection.Close()
            Return resultadoDS

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ObtenerIngresos")
            connection.Close()
            Return Nothing

        End Try
    End Function

    Public Function ObtenerDataReporteEgresos(ByVal ParGrupoEgresoId As Integer, ByVal ParSubGrupoEgresoId As Integer, ByVal ParProveedorId As Integer, ByVal ParPeriodoInicio As Integer, ByVal ParPeriodoFin As Integer, ByVal ParTotal As Integer) As DataSet

        Dim resultadoDS As New DataSet
        Dim adapter As New SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerReporteEgresos", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@GrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoInicio", SqlDbType.Int)
            command.Parameters.Add("@PeriodoFin", SqlDbType.Int)
            command.Parameters.Add("@Total", SqlDbType.VarChar)

            command.Parameters("@GrupoEgresoId").Value = ParGrupoEgresoId
            command.Parameters("@SubGrupoEgresoId").Value = ParSubGrupoEgresoId
            command.Parameters("@ProveedorId").Value = ParProveedorId
            command.Parameters("@PeriodoInicio").Value = ParPeriodoInicio
            command.Parameters("@PeriodoFin").Value = ParPeriodoFin
            command.Parameters("@Total").Value = ParTotal

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            connection.Close()
            Return resultadoDS

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ObtenerEgresos")
            connection.Close()
            Return Nothing

        End Try
    End Function

    Public Function ObtenerDataReporteRatios(ByVal ParPeriodoInicio As Integer, ByVal ParPeriodoFin As Integer) As DataSet

        Dim resultadoDS As New DataSet
        Dim adapter As New SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerReporteRatios", connection)
            command.CommandType = CommandType.StoredProcedure


            command.Parameters.Add("@PeriodoInicio", SqlDbType.Int)
            command.Parameters.Add("@PeriodoFin", SqlDbType.Int)

            command.Parameters("@PeriodoInicio").Value = ParPeriodoInicio
            command.Parameters("@PeriodoFin").Value = ParPeriodoFin


            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            connection.Close()
            Return resultadoDS

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ObtenerRatios")
            connection.Close()
            Return Nothing

        End Try
    End Function

    Public Function ObtenerDataReporteBalanceGeneral(ByVal ParPeriodo As Integer) As DataSet

        Dim resultadoDS As New DataSet
        Dim adapter As New SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerReporteBalanceGeneral", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Periodo", SqlDbType.Int)
            command.Parameters("@Periodo").Value = ParPeriodo


            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            connection.Close()
            Return resultadoDS

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ObtenerBalanceGeneral")
            connection.Close()
            Return Nothing

        End Try
    End Function


    Public Function ObtenerDataReporteFCProyectado(ByVal ParPeriodoInicio As Integer, ByVal ParPeriodoFin As Integer) As DataSet

        Dim resultadoDS As New DataSet
        Dim adapter As New SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerReporteFCProyectado", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@PeriodoInicio", SqlDbType.Int)
            command.Parameters.Add("@PeriodoFin", SqlDbType.Int)
            command.Parameters("@PeriodoInicio").Value = ParPeriodoInicio
            command.Parameters("@PeriodoFin").Value = ParPeriodoFin


            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            connection.Close()
            Return resultadoDS

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ObtenerFCProyectado")
            connection.Close()
            Return Nothing

        End Try
    End Function


End Class
