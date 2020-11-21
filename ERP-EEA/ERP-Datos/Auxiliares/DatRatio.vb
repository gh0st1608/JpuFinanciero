Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatRatio

    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearRatio(ByVal objRatio As EntRatio) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearRatio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@TipoRatioId", SqlDbType.Int)
            command.Parameters.Add("@Valor", SqlDbType.Decimal)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@TipoRatioId").Value = objRatio.TipoRatioId
            command.Parameters("@Valor").Value = objRatio.Valor
            command.Parameters("@PeriodoId").Value = objRatio.PeriodoId
            command.Parameters("@UsuarioCreacionId").Value = objRatio.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Ratio")
            connection.Close()
            Return False
        End Try
    End Function



    Public Function LeerRatio(ByVal IdRatio As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerRatio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdRatio", SqlDbType.Int)
            command.Parameters("@IdRatio").Value = IdRatio
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Ratio")
            connection.Close()
            Return Nothing
        End Try
    End Function

End Class
