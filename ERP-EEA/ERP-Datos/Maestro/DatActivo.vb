Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatActivo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearActivo(ByVal objActivo As EntActivo) As Boolean
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
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Activo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarActivo(ByVal objActivo As EntActivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdActivo", SqlDbType.Int)
            command.Parameters.Add("@GrupoActivoId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Monto", SqlDbType.Money)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdActivo").Value = objActivo.IdActivo
            command.Parameters("@GrupoActivoId").Value = objActivo.GrupoActivoId
            command.Parameters("@PeriodoId").Value = objActivo.PeriodoId
            command.Parameters("@Monto").Value = objActivo.Monto
            command.Parameters("@UsuarioModificacionId").Value = objActivo.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Activo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarActivo(ByVal objActivo As EntActivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdActivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdActivo").Value = objActivo.IdActivo
            command.Parameters("@UsuarioModificacionId").Value = objActivo.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Activo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerActivo(ByVal IdActivo As Integer, ByVal PeriodoId As Integer, ByVal GrupoId As Integer, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdActivo", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@GrupoId", SqlDbType.Int)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdActivo").Value = IdActivo
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters("@GrupoId").Value = GrupoId
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Activo")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
