Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatActivo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearActivo(ByVal objActivo As EntActivo) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("CrearActivo", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@GrupoActivoId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Monto", SqlDbType.Money)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)


            command.Parameters("@GrupoActivoId").Value = objActivo.GrupoActivoId
            command.Parameters("@PeriodoId").Value = objActivo.PeriodoId
            command.Parameters("@Monto").Value = objActivo.Monto
            command.Parameters("@UsuarioCreacionId").Value = objActivo.UsuarioCreacionId


            command.ExecuteReader()
            connection.Close()

            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Activo")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarActivo(ByVal objActivo As EntActivo) As Integer
        Dim command As SqlCommand
        Try

            connection.Open()
            command = New SqlCommand("ActualizarActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdActivo", SqlDbType.Int)
            command.Parameters.Add("@GrupoActivoId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Monto", SqlDbType.Bit)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdActivo").Value = objActivo.IdActivo
            command.Parameters("@GrupoActivoId").Value = objActivo.GrupoActivoId
            command.Parameters("@PeriodoId").Value = objActivo.PeriodoId
            command.Parameters("@Monto").Value = objActivo.Monto
            command.Parameters("@UsuarioModificacionId").Value = objActivo.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Activo")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function EliminarActivo(ByVal objActivo) As Integer
        Dim command As SqlCommand
        Try

            connection.Open()
            command = New SqlCommand("EliminarActivo", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdActivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdActivo").Value = objActivo.IdIngreso
            command.Parameters("@UsuarioModificacionId").Value = objActivo.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Activo")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerActivo(ByVal IdActivo As Integer, ByVal PeriodoId As Integer) As DataTable
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try

            connection.Open()
            command = New SqlCommand("LeerActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdActivo", SqlDbType.Int)
            command.Parameters("@IdActivo").Value = IdActivo
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@PeriodoId").Value = PeriodoId

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()

            Return resultadoDT

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Activo")
            connection.Close()
            Return Nothing

        End Try
    End Function
End Class
