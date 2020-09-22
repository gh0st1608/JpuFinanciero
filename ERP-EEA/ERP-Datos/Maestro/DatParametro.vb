Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks
Imports ERP_Entidad

Public Class DatParametro
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    'SqlConnection conn = New SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


    Public Function CrearParametro(ByVal objParamtro As EntParametro) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            command = New SqlCommand("CrearParametro", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@TipoParametro", SqlDbType.VarChar, 20)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@ValorParametro", SqlDbType.Float)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)


            command.Parameters("@TipoParametro").Value = objParamtro.TipoParametro
            command.Parameters("@Descripcion").Value = objParamtro.Descripcion
            command.Parameters("@ValorParametro").Value = objParamtro.ValorParametro
            command.Parameters("@UsuarioCreacionId").Value = 1 ' objParamtro.UsuarioCreacionId


            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Parametro")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarParametro(ByVal objParametro As EntParametro) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarParametro", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdParametro", SqlDbType.Int)
            command.Parameters.Add("@TipoParametro", SqlDbType.VarChar, 20)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@ValorParametro", SqlDbType.Float)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)


            command.Parameters("@IdParametro").Value = objParametro.IdParametro
            command.Parameters("@TipoParametro").Value = objParametro.TipoParametro
            command.Parameters("@Descripcion").Value = objParametro.Descripcion
            command.Parameters("@ValorParametro").Value = objParametro.ValorParametro
            command.Parameters("@UsuarioModificacionId").Value = objParametro.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objParametro.IdEstadoActivo

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Parametro")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarParametro(ByVal objParametro As EntParametro) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarParametro", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdParametro", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdParametro").Value = objParametro.IdParametro
            command.Parameters("@UsuarioModificacionId").Value = objParametro.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Parametro")
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


    Public Function LeerParametro(ByVal IdParametro As Integer, ByVal Descripcion As String) As DataTable

        'Dim reader As SqlDataReader
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter

        Try

            connection.Open()

            command = New SqlCommand("LeerParametro", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdParametro", SqlDbType.Int)
            command.Parameters("@IdParametro").Value = IdParametro

            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters("@Descripcion").Value = Descripcion


            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()
            Return resultadoDT

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Parametro")
            connection.Close()
            Return Nothing

        End Try

    End Function


End Class
