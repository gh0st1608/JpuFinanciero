Imports System.Data.SqlClient
Imports System.Configuration
Imports ERP_Entidad
Public Class DatPago


    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    Dim command As SqlCommand

    Public Function CrearPago(ByVal objPago As EntPago) As Integer
        Try
            connection.Open()
            command = New SqlCommand("CrearPago", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@TipoOrigenId", SqlDbType.Int)
            command.Parameters.Add("@OrigenId", SqlDbType.Int)
            command.Parameters.Add("@ImporteCancelado", SqlDbType.Float)
            command.Parameters.Add("@ImporteIGV", SqlDbType.Float)
            command.Parameters.Add("@ImporteDetraccion", SqlDbType.Float)
            command.Parameters.Add("@ImporteTotal", SqlDbType.Float)
            command.Parameters.Add("@MetodoPagoId", SqlDbType.Int)
            command.Parameters.Add("@NroOperacion", SqlDbType.VarChar, 20)
            'command.Parameters.Add("@ComprobanteUbicacion", SqlDbType.VarChar, 200)
            command.Parameters.Add("@NumeroComprobante", SqlDbType.VarChar, 20)
            command.Parameters.Add("@FechaPago", SqlDbType.Date)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)

            command.Parameters("@TipoOrigenId").Value = objPago.TipoOrigenId
            command.Parameters("@OrigenId").Value = objPago.OrigenId
            command.Parameters("@ImporteCancelado").Value = objPago.ImporteCancelado
            command.Parameters("@ImporteIGV").Value = objPago.ImporteIGV
            command.Parameters("@ImporteDetraccion").Value = objPago.ImporteDetraccion
            command.Parameters("@ImporteTotal").Value = objPago.ImporteTotal
            command.Parameters("@MetodoPagoId").Value = objPago.MetodoPagoId
            command.Parameters("@NroOperacion").Value = objPago.NroOperacion
            'command.Parameters("@ComprobanteUbicacion").Value = objPago.ComprobanteUbicacion
            command.Parameters("@NumeroComprobante").Value = objPago.NumeroComprobante
            command.Parameters("@FechaPago").Value = objPago.FechaPago
            command.Parameters("@UsuarioCreacionId").Value = objPago.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return 0
        End Try
    End Function

    Public Function ActualizarPago(ByVal objPago As EntPago) As Integer
        Try
            connection.Open()
            command = New SqlCommand("ActualizarPago", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdPago", SqlDbType.Int)
            command.Parameters.Add("@TipoOrigenId", SqlDbType.Int)
            command.Parameters.Add("@OrigenId", SqlDbType.Int)
            command.Parameters.Add("@ImporteCancelado", SqlDbType.Float)
            command.Parameters.Add("@ImporteIGV", SqlDbType.Float)
            command.Parameters.Add("@ImporteDetraccion", SqlDbType.Float)
            command.Parameters.Add("@ImporteTotal", SqlDbType.Float)
            command.Parameters.Add("@MetodoPagoId", SqlDbType.Int)
            command.Parameters.Add("@NroOperacion", SqlDbType.VarChar, 20)
            command.Parameters.Add("@FechaPago", SqlDbType.Date)
            'command.Parameters.Add("@ComprobanteUbicacion", SqlDbType.VarChar, 200)
            command.Parameters.Add("@NumeroComprobante", SqlDbType.VarChar, 20)
            'command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdPago").Value = objPago.IdPago
            command.Parameters("@TipoOrigenId").Value = objPago.TipoOrigenId
            command.Parameters("@OrigenId").Value = objPago.OrigenId
            command.Parameters("@ImporteCancelado").Value = objPago.ImporteCancelado
            command.Parameters("@ImporteIGV").Value = objPago.ImporteIGV
            command.Parameters("@ImporteDetraccion").Value = objPago.ImporteDetraccion
            command.Parameters("@ImporteTotal").Value = objPago.ImporteTotal
            command.Parameters("@MetodoPagoId").Value = objPago.MetodoPagoId
            command.Parameters("@NroOperacion").Value = objPago.NroOperacion
            command.Parameters("@FechaPago").Value = objPago.FechaPago
            'command.Parameters("@ComprobanteUbicacion").Value = objPago.ComprobanteUbicacion
            command.Parameters("@NumeroComprobante").Value = objPago.NumeroComprobante
            'command.Parameters("@EstadoActivo").Value = objPago.EstadoActivo
            command.Parameters("@UsuarioModificacionId").Value = objPago.UsuarioModificacionId
            command.ExecuteReader()
            connection.Close()
            Return 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return 0
        End Try
    End Function

    Public Function EliminarPago(ByVal objPago As EntPago) As Integer
        Try
            connection.Open()
            command = New SqlCommand("EliminarPago", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdPago", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdPago").Value = objPago.IdPago
            command.Parameters("@UsuarioModificacionId").Value = objPago.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return 0
        End Try
    End Function

    Public Function LeerPago(ByVal IdPago As Integer, ByVal TipoOrigen As Integer, ByVal OrigenId As Integer, ByVal PeriodoId As Integer, ByVal ClienteId As Integer, ByVal ProveedorId As Integer) As DataTable
        Try
            Dim resultadoDT As DataTable
            Dim resultadoDS As New DataSet
            Dim adapter As SqlDataAdapter

            connection.Open()
            command = New SqlCommand("LeerPago", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdPago", SqlDbType.Int)
            command.Parameters.Add("@OrigenId", SqlDbType.Int)
            command.Parameters.Add("@TipoOrigen", SqlDbType.Int)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@ClienteId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)

            command.Parameters("@IdPago").Value = IdPago
            command.Parameters("@OrigenId").Value = OrigenId
            command.Parameters("@TipoOrigen").Value = TipoOrigen
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters("@ClienteId").Value = ClienteId
            command.Parameters("@ProveedorId").Value = ProveedorId

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()

            Return resultadoDT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return Nothing
        End Try
    End Function
End Class

