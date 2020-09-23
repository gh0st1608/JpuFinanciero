Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatMetodoPago
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Dim resultadoDT As DataTable
    Dim resultadoDS As New DataSet
    Dim adapter As SqlDataAdapter

    Public Function LeerMetodoPago(ByVal IdMetodoPago As Integer) As DataTable
        Try
            connection.Open()
            command = New SqlCommand("LeerMetodoPago", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdMetodoPago", SqlDbType.Int)
            command.Parameters("@IdMetodoPago").Value = IdMetodoPago

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()

            Return resultadoDT

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MetodoPago")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
