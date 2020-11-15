Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatIngreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand
    Public Function CrearIngreso(ByVal objIngreso As EntIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("CrearIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@Comentario", SqlDbType.VarChar, 200)
            command.Parameters.Add("@GrupoIngresoId", SqlDbType.Int)
            command.Parameters.Add("@ClienteId", SqlDbType.Int)
            command.Parameters.Add("@Detraccion", SqlDbType.Bit)
            command.Parameters.Add("@IGV", SqlDbType.Bit)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@ComprobanteUbicacion", SqlDbType.VarChar, 200)
            command.Parameters.Add("@NumeroComprobanteIngreso", SqlDbType.VarChar, 20)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            command.Parameters.Add("@FechaIngresoProvision", SqlDbType.Date)
            command.Parameters("@Comentario").Value = objIngreso.Comentario
            command.Parameters("@GrupoIngresoId").Value = objIngreso.GrupoIngresoId
            command.Parameters("@ClienteId").Value = objIngreso.ClienteId
            command.Parameters("@Detraccion").Value = objIngreso.Detraccion
            command.Parameters("@IGV").Value = objIngreso.IGV
            command.Parameters("@ImporteProvision").Value = objIngreso.ImporteProvision
            command.Parameters("@PeriodoId").Value = objIngreso.PeriodoId
            command.Parameters("@FechaIngresoProvision").Value = objIngreso.FechaIngresoProvision
            command.Parameters("@ComprobanteUbicacion").Value = objIngreso.ComprobanteUbicacion
            command.Parameters("@NumeroComprobanteIngreso").Value = objIngreso.NumeroComprobanteIngreso
            command.Parameters("@UsuarioCreacionId").Value = objIngreso.UsuarioCreacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Ingreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function ActualizarIngreso(ByVal objIngreso As EntIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("ActualizarIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdIngreso", SqlDbType.Int)
            command.Parameters.Add("@GrupoIngresoId", SqlDbType.Int)
            command.Parameters.Add("@ClienteId", SqlDbType.Int)
            command.Parameters.Add("@Detraccion", SqlDbType.Bit)
            command.Parameters.Add("@IGV", SqlDbType.Bit)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Comentario", SqlDbType.VarChar, 200)
            command.Parameters.Add("@FechaIngresoProvision", SqlDbType.Date)
            command.Parameters.Add("@Deuda", SqlDbType.Float)
            command.Parameters.Add("@ComprobanteUbicacion", SqlDbType.VarChar, 200)
            command.Parameters.Add("@NumeroComprobanteIngreso", SqlDbType.VarChar, 20)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdIngreso").Value = objIngreso.IdIngreso
            command.Parameters("@GrupoIngresoId").Value = objIngreso.GrupoIngresoId
            command.Parameters("@ClienteId").Value = objIngreso.ClienteId
            command.Parameters("@Detraccion").Value = objIngreso.Detraccion
            command.Parameters("@IGV").Value = objIngreso.IGV
            command.Parameters("@ImporteProvision").Value = objIngreso.ImporteProvision
            command.Parameters("@Deuda").Value = objIngreso.Deuda
            command.Parameters("@PeriodoId").Value = objIngreso.PeriodoId
            command.Parameters("@Comentario").Value = objIngreso.Comentario
            command.Parameters("@FechaIngresoProvision").Value = objIngreso.FechaIngresoProvision
            command.Parameters("@ComprobanteUbicacion").Value = objIngreso.ComprobanteUbicacion
            command.Parameters("@NumeroComprobanteIngreso").Value = objIngreso.NumeroComprobanteIngreso
            command.Parameters("@UsuarioModificacionId").Value = objIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Ingreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function EliminarIngreso(ByVal objIngreso As EntIngreso) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("EliminarIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdIngreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters("@IdIngreso").Value = objIngreso.IdIngreso
            command.Parameters("@UsuarioModificacionId").Value = objIngreso.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Ingreso")
            connection.Close()
            Return False
        End Try
    End Function

    Public Function LeerIngreso(ByVal IdIngreso As Integer, ByVal PeriodoId As Integer, ByVal ClienteId As Integer) As DataTable
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter
        Try
            connection.Open()
            command = New SqlCommand("LeerIngreso", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@IdIngreso", SqlDbType.Int)
            command.Parameters("@IdIngreso").Value = IdIngreso
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters.Add("@ClienteId", SqlDbType.Int)
            command.Parameters("@ClienteId").Value = ClienteId
            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de consulta SQL para Ingreso")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class
