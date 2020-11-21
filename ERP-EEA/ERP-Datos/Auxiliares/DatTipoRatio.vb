Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad


Public Class DatTipoRatio
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand

    Public Function LeerTipoRatio(ByVal IdTipoRatio As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerTipoRatio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdTipoRatio", SqlDbType.Int)
            command.Parameters("@IdTipoRatio").Value = IdTipoRatio
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Tipo Ratio")
            connection.Close()
            Return Nothing
        End Try
    End Function

End Class
