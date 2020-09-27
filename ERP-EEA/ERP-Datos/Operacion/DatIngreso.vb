Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatIngreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearIngreso(ByVal objIngreso As EntIngreso) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            'Procedimiento almacenado 
            command = New SqlCommand("CrearIngreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Dandole uhn tipo de dato a los parametros que van a ser vinculados a la bd
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
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Ingreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarIngreso(ByVal objIngreso As EntIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarIngreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
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
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)

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
            command.Parameters("@EstadoActivo").Value = objIngreso.EstadoActivo

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Ingreso")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarIngreso(ByVal objIngreso) As Integer
        Dim command As SqlCommand
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
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Ingreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerIngreso(ByVal IdIngreso As Integer, ByVal PeriodoId As Integer, ByVal ClienteId As Integer, ByVal EstadoActivo As Integer) As DataTable
        'Dim reader As SqlDataReader
        Dim command As SqlCommand
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
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)
            command.Parameters("@EstadoActivo").Value = EstadoActivo

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0) 'Asignar la consulta al datatable(La primera consulta "0")
            connection.Close()
            Return resultadoDT

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Ingreso")
            connection.Close()
            Return Nothing
        End Try

    End Function
End Class
