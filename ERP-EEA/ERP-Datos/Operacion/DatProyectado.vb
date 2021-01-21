Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatProyectado
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearProyectado(ByVal objProyectado As EntProyectado) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearProyectado", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@GrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@GrupoEgresoId").Value = objProyectado.GrupoEgresoId
            command.Parameters("@SubGrupoEgresoId").Value = objProyectado.SubGrupoEgresoId
            command.Parameters("@ImporteProvision").Value = objProyectado.ImporteProvision
            command.Parameters("@PeriodoId").Value = objProyectado.PeriodoId
            command.Parameters("@UsuarioCreacionId").Value = objProyectado.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Proyectado")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarProyectado(ByVal objProyectado As EntProyectado) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarProyectado", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdProyectado", SqlDbType.Int)
            command.Parameters.Add("@GrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdProyectado").Value = objProyectado.IdProyectado
            command.Parameters("@GrupoEgresoId").Value = objProyectado.GrupoEgresoId
            command.Parameters("@SubGrupoEgresoId").Value = objProyectado.SubGrupoEgresoId
            command.Parameters("@ImporteProvision").Value = objProyectado.ImporteProvision
            command.Parameters("@PeriodoId").Value = objProyectado.PeriodoId
            command.Parameters("@UsuarioModificacionId").Value = objProyectado.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Proyectado")
            connection.Close()
            Return False
        End Try

    End Function

    Public Function EliminarProyectado(ByVal objProyectado As EntProyectado) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarProyectado", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdProyectado", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdProyectado").Value = objProyectado.IdProyectado
            command.Parameters("@UsuarioModificacionId").Value = objProyectado.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Proyectado")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerProyectado(ByVal IdProyectado As Integer, ByVal SubGrupoEgresoId As Integer, ByVal PeriodoId As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerProyectado", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdProyectado", SqlDbType.Int)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@IdProyectado").Value = IdProyectado
            command.Parameters("@SubGrupoEgresoId").Value = SubGrupoEgresoId
            command.Parameters("@PeriodoId").Value = PeriodoId
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Proyectado")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class

