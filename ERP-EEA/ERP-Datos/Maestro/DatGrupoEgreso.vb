Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatGrupoEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearGrupoEgreso(ByVal objGrupoEgreso As EntGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objGrupoEgreso.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = objGrupoEgreso.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarGrupoEgreso(ByVal objGrupoEgreso As EntGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = objGrupoEgreso.IdGrupoEgreso
            command.Parameters("@Descripcion").Value = objGrupoEgreso.Descripcion
            command.Parameters("@EstadoActivo").Value = objGrupoEgreso.IdEstadoActivo
            command.Parameters("@UsuarioModificacionId").Value = objGrupoEgreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarGrupoEgreso(ByVal objGrupoEgreso As EntGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = objGrupoEgreso.IdGrupoEgreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoEgreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerGrupoEgreso(ByVal IdGrupoEgreso As Integer, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdGrupoEgreso").Value = IdGrupoEgreso
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
