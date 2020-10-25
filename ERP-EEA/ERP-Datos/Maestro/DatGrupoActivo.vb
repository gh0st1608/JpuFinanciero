Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatGrupoActivo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearGrupoActivo(ByVal objGrupoActivo As EntGrupoActivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Tipo", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Tipo").Value = objGrupoActivo.IdTipo
            command.Parameters("@Descripcion").Value = objGrupoActivo.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = objGrupoActivo.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Activo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarGrupoActivo(ByVal objGrupoActivo As EntGrupoActivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoActivo", SqlDbType.Int)
            command.Parameters.Add("@Tipo", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdGrupoActivo").Value = objGrupoActivo.IdGrupoActivo
            command.Parameters("@Tipo").Value = objGrupoActivo.IdTipo
            command.Parameters("@Descripcion").Value = objGrupoActivo.Descripcion
            command.Parameters("@UsuarioModificacionId").Value = objGrupoActivo.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objGrupoActivo.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Activo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarGrupoActivo(ByVal objGrupoActivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoActivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoActivo").Value = objGrupoActivo.IdGrupoActivo
            command.Parameters("@UsuarioModificacionId").Value = objGrupoActivo.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Activo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerGrupoActivo(ByVal IdGrupoActivo As Integer, ByVal Descripcion As String) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoActivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoActivo", SqlDbType.Int)
            command.Parameters("@IdGrupoActivo").Value = IdGrupoActivo
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters("@Descripcion").Value = Descripcion
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Activo")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
