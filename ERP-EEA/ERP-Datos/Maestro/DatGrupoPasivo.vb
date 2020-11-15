Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad

Public Class DatGrupoPasivo
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearGrupoPasivo(ByVal objGrupoPasivo As EntGrupoPasivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Tipo", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Cuenta", SqlDbType.Int)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@Tipo").Value = objGrupoPasivo.IdTipo
            command.Parameters("@Descripcion").Value = objGrupoPasivo.Descripcion
            command.Parameters("@Cuenta").Value = objGrupoPasivo.Cuenta
            command.Parameters("@UsuarioCreacionId").Value = objGrupoPasivo.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Pasivo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarGrupoPasivo(ByVal objGrupoPasivo As EntGrupoPasivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoPasivo", SqlDbType.Int)
            command.Parameters.Add("@Tipo", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Cuenta", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@IdGrupoPasivo").Value = objGrupoPasivo.IdGrupoPasivo
            command.Parameters("@Tipo").Value = objGrupoPasivo.IdTipo
            command.Parameters("@Descripcion").Value = objGrupoPasivo.Descripcion
            command.Parameters("@UsuarioModificacionId").Value = objGrupoPasivo.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objGrupoPasivo.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Pasivo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarGrupoPasivo(ByVal objGrupoPasivo As EntGrupoPasivo) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoPasivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoPasivo").Value = objGrupoPasivo.IdGrupoPasivo
            command.Parameters("@UsuarioModificacionId").Value = objGrupoPasivo.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Pasivo")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerGrupoPasivo(ByVal IdGrupoPasivo As Integer, ByVal Descripcion As String, TablaMaestra As Boolean) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoPasivo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdGrupoPasivo", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@TablaMaestra", SqlDbType.Bit)
            command.Parameters("@IdGrupoPasivo").Value = IdGrupoPasivo
            command.Parameters("@Descripcion").Value = Descripcion
            command.Parameters("@TablaMaestra").Value = TablaMaestra
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Grupo Pasivo")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
