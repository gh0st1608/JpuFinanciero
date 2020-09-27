Imports ERP_Entidad
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearEgreso(ByVal objEgreso As EntEgreso) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            'Procedimiento almacenado 
            command = New SqlCommand("CrearEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Dandole uhn tipo de dato a los parametros que van a ser vinculados a la bd
            command.Parameters.Add("@Comentario", SqlDbType.VarChar, 200)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@FechaEgresoProvision", SqlDbType.Date)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)

            command.Parameters("@Comentario").Value = objEgreso.Comentario
            command.Parameters("@SubGrupoEgresoId").Value = objEgreso.SubGrupoEgresoId
            command.Parameters("@ProveedorId").Value = objEgreso.ProveedorId
            command.Parameters("@ImporteProvision").Value = objEgreso.ImporteProvision
            command.Parameters("@PeriodoId").Value = objEgreso.PeriodoId
            command.Parameters("@FechaEgresoProvision").Value = objEgreso.FechaEgresoProvision
            command.Parameters("@UsuarioCreacionId").Value = objEgreso.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Egreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarEgreso(ByVal objEgreso As EntEgreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdIngreso", SqlDbType.Int)
            command.Parameters.Add("@SubGrupoEgresoId", SqlDbType.Int)
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters.Add("@ImporteProvision", SqlDbType.Money)
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters.Add("@Comentario", SqlDbType.VarChar, 200)
            command.Parameters.Add("@FechaEgresoProvision", SqlDbType.Date)
            command.Parameters.Add("@Deuda", SqlDbType.Money)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)

            command.Parameters("@IdIngreso").Value = objEgreso.IdEgreso
            command.Parameters("@SubGrupoEgresoId").Value = objEgreso.SubGrupoEgresoId
            command.Parameters("@ProveedorId").Value = objEgreso.ProveedorId
            command.Parameters("@ImporteProvision").Value = objEgreso.ImporteProvision
            command.Parameters("@Deuda").Value = objEgreso.SubTotal
            command.Parameters("@PeriodoId").Value = objEgreso.PeriodoId
            command.Parameters("@Comentario").Value = objEgreso.Comentario
            command.Parameters("@FechaEgresoProvision").Value = objEgreso.FechaEgresoProvision
            command.Parameters("@UsuarioModificacionId").Value = objEgreso.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objEgreso.EstadoActivo

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Egreso")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarEgreso(ByVal objEgreso) As Integer
        Dim command As SqlCommand
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
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Egreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerEgreso(ByVal IdEgreso As Integer, ByVal PeriodoId As Integer, ByVal ProveedorId As Integer) As DataTable
        'Dim reader As SqlDataReader
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdEgreso", SqlDbType.Int)
            command.Parameters("@IdEgreso").Value = IdEgreso
            command.Parameters.Add("@PeriodoId", SqlDbType.Int)
            command.Parameters("@PeriodoId").Value = PeriodoId
            command.Parameters.Add("@ProveedorId", SqlDbType.Int)
            command.Parameters("@ProveedorId").Value = ProveedorId

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0) 'Asignar la consulta al datatable(La primera consulta "0")
            connection.Close()
            Return resultadoDT

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Egreso")
            connection.Close()
            Return Nothing
        End Try

    End Function
End Class
