Imports System.Data.SqlClient
Imports System.Configuration

Imports ERP_Entidad

Public Class DatRelacionDebeHaber
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearRelacionDebeHaber(ByVal objRelacionDebeHaber As EntRelacionDebeHaber) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("CrearRelacionDebeHaber", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@TipoOperacionId", SqlDbType.Int)
            command.Parameters.Add("@EtapaOperacionId", SqlDbType.Int)
            command.Parameters.Add("@GrupoId", SqlDbType.Int)
            command.Parameters.Add("@GrupoDebeId", SqlDbType.Int)
            command.Parameters.Add("@GrupoHaberId", SqlDbType.Int)
            command.Parameters.Add("@DebeId", SqlDbType.Int)
            command.Parameters.Add("@HaberId", SqlDbType.Int)
            command.Parameters.Add("@SignoDebe", SqlDbType.Int)
            command.Parameters.Add("@SignoHaber", SqlDbType.Int)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)

            command.Parameters("@TipoOperacionId").Value = objRelacionDebeHaber.TipoOperacionId
            command.Parameters("@EtapaOperacionId").Value = objRelacionDebeHaber.EtapaOperacionId
            command.Parameters("@GrupoId").Value = objRelacionDebeHaber.GrupoId
            command.Parameters("@GrupoDebeId").Value = objRelacionDebeHaber.GrupoDebeId
            command.Parameters("@GrupoHaberId").Value = objRelacionDebeHaber.GrupoHaberId
            command.Parameters("@DebeId").Value = objRelacionDebeHaber.DebeId
            command.Parameters("@HaberId").Value = objRelacionDebeHaber.HaberId
            command.Parameters("@SignoDebe").Value = objRelacionDebeHaber.SignoDebe
            command.Parameters("@SignoHaber").Value = objRelacionDebeHaber.SignoHaber
            command.Parameters("@UsuarioCreacionId").Value = objRelacionDebeHaber.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "RelacionDebeHaber")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarRelacionDebeHaber(ByVal objRelacionDebeHaber As EntRelacionDebeHaber) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarRelacionDebeHaber", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdRelacionDebeHaber", SqlDbType.Int)
            command.Parameters.Add("@TipoOperacionId", SqlDbType.Int)
            command.Parameters.Add("@EtapaOperacionId", SqlDbType.Int)
            command.Parameters.Add("@GrupoId", SqlDbType.Int)
            command.Parameters.Add("@GrupoDebeId", SqlDbType.Int)
            command.Parameters.Add("@GrupoHaberId", SqlDbType.Int)
            command.Parameters.Add("@DebeId", SqlDbType.Int)
            command.Parameters.Add("@HaberId", SqlDbType.Int)
            command.Parameters.Add("@SignoDebe", SqlDbType.Int)
            command.Parameters.Add("@SignoHaber", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)

            command.Parameters("@IdRelacionDebeHaber").Value = objRelacionDebeHaber.IdRelacionDebeHaber
            command.Parameters("@TipoOperacionId").Value = objRelacionDebeHaber.TipoOperacionId
            command.Parameters("@EtapaOperacionId").Value = objRelacionDebeHaber.EtapaOperacionId
            command.Parameters("@GrupoId").Value = objRelacionDebeHaber.GrupoId
            command.Parameters("@GrupoDebeId").Value = objRelacionDebeHaber.GrupoDebeId
            command.Parameters("@GrupoHaberId").Value = objRelacionDebeHaber.GrupoHaberId
            command.Parameters("@DebeId").Value = objRelacionDebeHaber.DebeId
            command.Parameters("@HaberId").Value = objRelacionDebeHaber.HaberId
            command.Parameters("@SignoDebe").Value = objRelacionDebeHaber.SignoDebe
            command.Parameters("@SignoHaber").Value = objRelacionDebeHaber.SignoHaber
            command.Parameters("@UsuarioModificacionId").Value = objRelacionDebeHaber.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objRelacionDebeHaber.IdEstadoActivo
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "RelacionDebeHaber")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarRelacionDebeHaber(ByVal objRelacionDebeHaber) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarRelacionDebeHaber", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdRelacionDebeHaber", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdRelacionDebeHaber").Value = objRelacionDebeHaber.IdRelacionDebeHaber
            command.Parameters("@UsuarioModificacionId").Value = objRelacionDebeHaber.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "RelacionDebeHaber")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerRelacionDebeHaber(ByVal IdRelacionDebeHaber As Integer, ByVal Descripcion As String) As DataTable
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerRelacionDebeHaber", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdRelacionDebeHaber", SqlDbType.Int)
            command.Parameters("@IdRelacionDebeHaber").Value = IdRelacionDebeHaber
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "RelacionDebeHaber")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class

