Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatGrupoEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearGrupoEgreso(ByVal objGrupoIngreso As EntGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = objGrupoIngreso.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarGrupoEgreso(ByVal objGrupoIngreso As EntGrupoEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Estado", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModficacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = objGrupoIngreso.IdGrupoEgreso
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@Estado").Value = objGrupoIngreso.EstadoActivo
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarGrupoEgreso(ByVal objGrupoIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModiciacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerGrupoEgreso(ByVal IdGrupoEgreso As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters("@IdGrupoEgreso").Value = IdGrupoEgreso
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
