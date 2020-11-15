Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatGrupoIngreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = objGrupoIngreso.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Ingreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objGrupoIngreso.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Ingreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Ingreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerGrupoIngreso(ByVal IdGrupoIngreso As Integer, ByVal Descripcion As String, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdGrupoIngreso").Value = IdGrupoIngreso
            command.Parameters("@Descripcion").Value = Descripcion
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Ingreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
