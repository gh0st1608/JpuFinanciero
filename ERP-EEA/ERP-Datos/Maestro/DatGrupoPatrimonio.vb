Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatGrupoPatrimonio
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand

    Public Function CrearGrupoPatrimonio(ByVal objGrupoPatrimonio As EntGrupoPatrimonio) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Cuenta", SqlDbType.Int)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objGrupoPatrimonio.Descripcion
            command.Parameters("@Cuenta").Value = objGrupoPatrimonio.Cuenta
            command.Parameters("@UsuarioCreacionId").Value = objGrupoPatrimonio.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Patrimonio")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarGrupoPatrimonio(ByVal objGrupoPatrimonio As EntGrupoPatrimonio) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoPatrimonio", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Cuenta", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdGrupoPatrimonio").Value = objGrupoPatrimonio.IdGrupoPatrimonio
            command.Parameters("@Descripcion").Value = objGrupoPatrimonio.Descripcion
            command.Parameters("@Cuenta").Value = objGrupoPatrimonio.Cuenta
            command.Parameters("@UsuarioModificacionId").Value = objGrupoPatrimonio.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objGrupoPatrimonio.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Patrimonio")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarGrupoPatrimonio(ByVal objGrupoPatrimonio) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoPatrimonio", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoPatrimonio").Value = objGrupoPatrimonio.IdGrupoPatrimonio
            command.Parameters("@UsuarioModificacionId").Value = objGrupoPatrimonio.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Patrimonio")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerGrupoPatrimonio(ByVal IdGrupoPatrimonio As Integer, ByVal Descripcion As String) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoPatrimonio", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoPatrimonio", SqlDbType.Int)
            command.Parameters("@IdGrupoPatrimonio").Value = IdGrupoPatrimonio
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters("@Descripcion").Value = Descripcion
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Patrimonio")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
