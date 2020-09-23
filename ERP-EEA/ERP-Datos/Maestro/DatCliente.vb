Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks
Imports ERP_Entidad
Public Class DatCliente


    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    'SqlConnection conn = New SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


    Public Function CrearCliente(ByVal objCliente As EntCliente) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            command = New SqlCommand("CrearCliente", connection)
            command.CommandType = CommandType.StoredProcedure

            'command.Parameters.Add("@TipoClienteId", SqlDbType.Int)
            command.Parameters.Add("@RazonSocial", SqlDbType.VarChar)
            command.Parameters.Add("@Documento", SqlDbType.VarChar)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar)
            command.Parameters.Add("@MetaEntidad", SqlDbType.Float)
            command.Parameters.Add("@MetaEmpresa", SqlDbType.Float)
            command.Parameters.Add("@Correo", SqlDbType.VarChar)
            command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)
            'command.Parameters.Add("@FechaCreacionId", SqlDbType.Date)

            'command.Parameters("@TipoClienteId").Value = objCliente.TipoClienteId
            command.Parameters("@RazonSocial").Value = objCliente.RazonSocial
            command.Parameters("@Documento").Value = objCliente.Documento
            command.Parameters("@Descripcion").Value = objCliente.Descripcion
            command.Parameters("@MetaEntidad").Value = objCliente.MetaEntidad
            command.Parameters("@MetaEmpresa").Value = objCliente.MetaEmpresa
            command.Parameters("@Correo").Value = objCliente.Correo
            command.Parameters("@NumeroContacto").Value = objCliente.NumeroContacto
            command.Parameters("@UsuarioCreacionId").Value = objCliente.UsuarioCreacionId
            'command.Parameters("@FechaCreacionId").Value = objCliente.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarCliente(ByVal objCliente As EntCliente) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarCliente", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdCliente", SqlDbType.Int)
            'command.Parameters.Add("@IdTipoCliente", SqlDbType.Int)
            command.Parameters.Add("@RazonSocial", SqlDbType.VarChar)
            command.Parameters.Add("@Documento", SqlDbType.VarChar)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar)
            command.Parameters.Add("@MetaEntidad", SqlDbType.Float)
            command.Parameters.Add("@MetaEmpresa", SqlDbType.Float)
            command.Parameters.Add("@Correo", SqlDbType.VarChar)
            command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@IdEstadoActivo", SqlDbType.Int)

            command.Parameters("@IdCliente").Value = objCliente.TipoClienteId
            'command.Parameters("@TipoClienteId").Value = objCliente.TipoClienteId
            command.Parameters("@RazonSocial").Value = objCliente.RazonSocial
            command.Parameters("@Documento").Value = objCliente.Documento
            command.Parameters("@Descripcion").Value = objCliente.Descripcion
            command.Parameters("@MetaEntidad").Value = objCliente.MetaEntidad
            command.Parameters("@MetaEmpresa").Value = objCliente.MetaEmpresa
            command.Parameters("@Correo").Value = objCliente.Correo
            command.Parameters("@NumeroContacto").Value = objCliente.NumeroContacto
            command.Parameters("@UsuarioModificacionId").Value = objCliente.UsuarioModificacionId
            command.Parameters("@IdEstadoActivo").Value = objCliente.IdEstadoActivo

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarCliente(ByVal objCliente As EntCliente) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarCliente", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdCliente", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdCliente").Value = objCliente.IdCliente
            command.Parameters("@UsuarioModificacionId").Value = objCliente.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
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


    Public Function LeerCliente(ByVal IdCliente As Integer, ByVal Descripcion As String) As DataTable
        'Dim reader As SqlDataReader
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerCliente", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdCliente", SqlDbType.Int)
            command.Parameters("@IdCliente").Value = IdCliente

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()

            Return resultadoDT

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
            connection.Close()
            Return Nothing

        End Try


    End Function

End Class
