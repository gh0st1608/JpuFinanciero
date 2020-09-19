Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks
Imports ERP_Entidad
Public Class DatPago


    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    'SqlConnection conn = New SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


    Public Function CrearPago(ByVal objPago As EntPago) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            command = New SqlCommand("CrearPago", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@TipoOrigenId", SqlDbType.Int)
            command.Parameters.Add("@EgresoId", SqlDbType.Int)
            command.Parameters.Add("@ImporteCancelado", SqlDbType.Float)
            command.Parameters.Add("@MetodoPagoId", SqlDbType.Int)
            command.Parameters.Add("@FechaPago", SqlDbType.Date)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            'command.Parameters.Add("@FechaCreacionId", SqlDbType.Date)

            command.Parameters("@TipoOrigenId").Value = objPago.TipoOrigenId
            command.Parameters("@EgresoId").Value = objPago.EgresoId
            command.Parameters("@ImporteCancelado").Value = objPago.ImporteCancelado
            command.Parameters("@MetodoPagoId").Value = objPago.MetodoPagoId
            command.Parameters("@FechaPago").Value = objPago.FechaPago
            command.Parameters("@UsuarioCreacionId").Value = 1 'objPago.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarPago(ByVal objPago As EntPago) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarPago", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdPago", SqlDbType.Int)
            command.Parameters.Add("@TipoOrigenId", SqlDbType.Int)
            command.Parameters.Add("@EgresoId", SqlDbType.VarChar)
            command.Parameters.Add("@ImporteCancelado", SqlDbType.VarChar)
            command.Parameters.Add("@MetodoPagoId", SqlDbType.VarChar)
            command.Parameters.Add("@FechaPago", SqlDbType.Float)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdPago").Value = objPago.IdPago
            command.Parameters("@TipoOrigenId").Value = objPago.TipoOrigenId
            command.Parameters("@EgresoId").Value = objPago.EgresoId
            command.Parameters("@ImporteCancelado").Value = objPago.ImporteCancelado
            command.Parameters("@MetodoPagoId").Value = objPago.MetodoPagoId
            command.Parameters("@FechaPago").Value = objPago.FechaPago
            command.Parameters("@UsuarioModificacionId").Value = 1 'objPago.UsuarioModificacionId
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarPago(ByVal objPago As EntPago) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarPago", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdPago", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModiciacionId", SqlDbType.Int)

            command.Parameters("@IdPago").Value = objPago.IdPago
            command.Parameters("@UsuarioModificacionId").Value = objPago.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pago")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    'Public Function ObtenerItem(ByVal id As Integer) As Area
    '    Dim command As SqlCommand
    '    Dim reader As SqlDataReader
    '    Dim result As Area
    '    Try
    '        connection.Open()
    '        command = New SqlCommand("up_sel_maeArea", connection)
    '        command.CommandType = CommandType.StoredProcedure

    '        command.Parameters.Add("@idArea", SqlDbType.Int)
    '        command.Parameters("@idArea").Value = id
    '        reader = command.ExecuteReader()

    '        If reader.HasRows() Then
    '            If reader.Read() Then
    '                result = New Area()
    '                result.idArea = reader.GetInt32(0)
    '                result.Descripcion = IIf(IsDBNull(reader.GetString(1)), "", reader.GetString(1))
    '                result.idEstado = reader.GetInt32(2)
    '            Else
    '                result = Nothing
    '            End If
    '        Else
    '            result = Nothing
    '        End If
    '        connection.Close()
    '        Return result
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Area")
    '        connection.Close()
    '        Return Nothing
    '    End Try

    'End Function

    'Public Function ObtenerItemNombre(ByVal Nombre As String) As Area
    '    Dim command As SqlCommand
    '    Dim reader As SqlDataReader
    '    Dim result As Area
    '    Try
    '        connection.Open()
    '        command = New SqlCommand("up_sel_maeAreaNombre", connection)
    '        command.CommandType = CommandType.StoredProcedure

    '        command.Parameters.Add("@Nombre", SqlDbType.VarChar, 150)
    '        command.Parameters("@Nombre").Value = Nombre
    '        reader = command.ExecuteReader()

    '        If reader.HasRows() Then
    '            If reader.Read() Then
    '                result = New Area()
    '                result.idArea = reader.GetInt32(0)
    '                result.Descripcion = reader.GetString(1)
    '                result.idEstado = reader.GetInt32(2)
    '            Else
    '                result = Nothing
    '            End If
    '        Else
    '            result = Nothing
    '        End If
    '        connection.Close()
    '        Return result
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Area")
    '        connection.Close()
    '        Return Nothing
    '    End Try

    'End Function

    'Public Function LeerGrupoIngresoPorId(ByVal estado As Integer) As DataSet
    '    Dim command As SqlCommand
    '    Dim adapter As SqlDataAdapter
    '    Dim objResult As DataSet

    '    Try
    '        connection.Open()
    '        command = New SqlCommand("Sel_MaeGrupoIngreso", connection)
    '        command.CommandType = CommandType.StoredProcedure

    '        command.Parameters.Add("@Estado", SqlDbType.Int)
    '        command.Parameters("@Estado").Value = estado

    '        objResult = New DataSet
    '        adapter = New SqlDataAdapter(command)
    '        adapter.Fill(objResult)

    '        connection.Close()
    '        Return objResult
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
    '        connection.Close()
    '        Return Nothing
    '    End Try

    'End Function


    Public Function LeerPago(ByVal IdPago As Integer, ByVal Descripcion As String) As DataTable
        'Dim reader As SqlDataReader
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerPago", connection)
            command.CommandType = CommandType.StoredProcedure

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

