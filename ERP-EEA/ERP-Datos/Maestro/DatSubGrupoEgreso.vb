Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatSubGrupoEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearSubGrupoEgreso(ByVal objSubGrupoEgreso As EntSubGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearSubGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@GrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ItemSubGrupoEgreso", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@GrupoEgresoId").Value = objSubGrupoEgreso.GrupoEgresoId
            command.Parameters("@ItemSubGrupoEgreso").Value = objSubGrupoEgreso.ItemSubGrupoEgreso
            command.Parameters("@UsuarioCreacionId").Value = objSubGrupoEgreso.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Sub-Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarSubGrupoEgreso(ByVal objSubGrupoIngreso As EntSubGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarSubGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdSubGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@GrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ItemSubGrupoEgreso", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdSubGrupoEgreso").Value = objSubGrupoIngreso.IdSubGrupoEgreso
            command.Parameters("@GrupoEgresoId").Value = objSubGrupoIngreso.GrupoEgresoId
            command.Parameters("@ItemSubGrupoEgreso").Value = objSubGrupoIngreso.ItemSubGrupoEgreso
            command.Parameters("@UsuarioModificacionId").Value = objSubGrupoIngreso.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objSubGrupoIngreso.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Sub-Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarSubGrupoEgreso(ByVal objSubGrupoEgreso As EntSubGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarSubGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdSubGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdSubGrupoEgreso").Value = objSubGrupoEgreso.IdSubGrupoEgreso
            command.Parameters("@UsuarioModificacionId").Value = objSubGrupoEgreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Sub-Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerSubGrupoEgreso(ByVal IdSubGrupoEgreso As Integer, ByVal GrupoEgresoId As Integer, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerSubGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdSubGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@FiltroCombo", SqlDbType.Int)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdSubGrupoEgreso").Value = IdSubGrupoEgreso
            command.Parameters("@FiltroCombo").Value = GrupoEgresoId
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Sub-Grupo Egreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
