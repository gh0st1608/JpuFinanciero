Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration
Public Class DatPeriodo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Dim adapter As SqlDataAdapter

    Public Function ActualizarPeriodo(ByVal objPeriodo As EntPeriodo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarPeriodo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdPeriodo", SqlDbType.Int)
            command.Parameters.Add("@Cierre", SqlDbType.Int)
            command.Parameters("@IdPeriodo").Value = objPeriodo.IdPeriodo
            command.Parameters("@Cierre").Value = objPeriodo.Cierre
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Periodo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerPeriodo(ByVal IdPeriodo As Integer, ByVal DescripcionPeriodo As String, ByVal Modo As Integer) As DataTable
        Try
            Dim resultadoDT As DataTable
            Dim resultadoDS As New DataSet
            connection.Open()
            command = New SqlCommand("LeerPeriodo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@DescripcionPeriodo", SqlDbType.VarChar, 10)
            command.Parameters.Add("@IdPeriodo", SqlDbType.Int)
            command.Parameters.Add("@Modo", SqlDbType.Int)
            command.Parameters("@DescripcionPeriodo").Value = DescripcionPeriodo
            command.Parameters("@IdPeriodo").Value = IdPeriodo
            command.Parameters("@Modo").Value = Modo

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Periodo")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
