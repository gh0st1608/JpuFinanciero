Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearEgreso(ByVal objEgreso As EntEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@GrupoEgresoId", SqlDbType.VarChar, 200)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@Deuda", SqlDbType.Float)
            command.Parameters.Add("@IGV", SqlDbType.Bit)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Comentario", SqlDbType.VarChar, 200)
            command.Parameters.Add("@ComprobanteUbicacion", SqlDbType.VarChar, 200)
            command.Parameters.Add("@NumeroComprobanteEgreso", SqlDbType.VarChar, 20)
            command.Parameters.Add("@FechaEgresoProvision", SqlDbType.Date)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters("@GrupoEgresoId").Value = objEgreso.GrupoEgresoId
            command.Parameters("@SubGrupoEgresoId").Value = objEgreso.SubGrupoEgresoId
            command.Parameters("@ProveedorId").Value = objEgreso.ProveedorId
            command.Parameters("@ImporteProvision").Value = objEgreso.ImporteProvision
            command.Parameters("@Deuda").Value = objEgreso.Deuda
            command.Parameters("@IGV").Value = objEgreso.IGV
            command.Parameters("@PeriodoId").Value = objEgreso.PeriodoId
            command.Parameters("@Comentario").Value = objEgreso.Comentario
            command.Parameters("@ComprobanteUbicacion").Value = objEgreso.ComprobanteUbicacion
            command.Parameters("@NumeroComprobanteEgreso").Value = objEgreso.NumeroComprobanteEgreso
            command.Parameters("@FechaEgresoProvision").Value = objEgreso.FechaEgresoProvision
            command.Parameters("@UsuarioCreacionId").Value = objEgreso.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarEgreso(ByVal objEgreso As EntEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdEgreso", SqlDbType.Int)
            command.Parameters.Add("@GrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@IGV", SqlDbType.Bit)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Comentario", SqlDbType.VarChar, 200)
            command.Parameters.Add("@FechaEgresoProvision", SqlDbType.Date)
            command.Parameters.Add("@ComprobanteUbicacion", SqlDbType.VarChar, 200)
            command.Parameters.Add("@NumeroComprobanteEgreso", SqlDbType.VarChar, 20)
            command.Parameters.Add("@Deuda", SqlDbType.Float)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdEgreso").Value = objEgreso.IdEgreso
            command.Parameters("@GrupoEgresoId").Value = objEgreso.GrupoEgresoId
            command.Parameters("@SubGrupoEgresoId").Value = objEgreso.SubGrupoEgresoId
            command.Parameters("@ProveedorId").Value = objEgreso.ProveedorId
            command.Parameters("@ImporteProvision").Value = objEgreso.ImporteProvision
            command.Parameters("@IGV").Value = objEgreso.IGV
            command.Parameters("@PeriodoId").Value = objEgreso.PeriodoId
            command.Parameters("@Comentario").Value = objEgreso.Comentario
            command.Parameters("@FechaEgresoProvision").Value = objEgreso.FechaEgresoProvision
            command.Parameters("@ComprobanteUbicacion").Value = objEgreso.ComprobanteUbicacion
            command.Parameters("@NumeroComprobanteEgreso").Value = objEgreso.NumeroComprobanteEgreso
            command.Parameters("@Deuda").Value = objEgreso.Deuda
            command.Parameters("@UsuarioModificacionId").Value = objEgreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Egreso")
            connection.Close()
            Return False
        End Try

    End Function

    Public Function EliminarEgreso(ByVal objEgreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdEgreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdEgreso").Value = objEgreso.IdEgreso
            command.Parameters("@UsuarioModificacionId").Value = objEgreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Egreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerEgreso(ByVal IdEgreso As Integer, ByVal PeriodoId As Integer, ByVal ProveedorId As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerEgreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdEgreso", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters("@IdEgreso").Value = IdEgreso
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters("@ProveedorId").Value = ProveedorId
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Egreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
