Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks

Imports ERP_Entidad

Public Class DatGrupoEgreso
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    'SqlConnection conn = New SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


    Public Function CrearGrupoEgreso(ByVal objGrupoIngreso As EntGrupoEgreso) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)

            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@UsuarioCreacionId").Value = 1 'objGrupoIngreso.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarGrupoEgreso(ByVal objGrupoIngreso As EntGrupoEgreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Estado", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModficacionId", SqlDbType.Int)

            command.Parameters("@IdGrupoEgreso").Value = objGrupoIngreso.IdGrupoEgreso
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@Estado").Value = objGrupoIngreso.EstadoActivo
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId

            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarGrupoEgreso(ByVal objGrupoIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdGrupoEgreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModiciacionId", SqlDbType.Int)

            command.Parameters("@IdGrupoEgreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
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


    Public Function LeerGrupoEgreso(ByVal IdGrupoEgreso As Integer, ByVal Descripcion As String) As DataTable
        'Dim reader As SqlDataReader
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerGrupoEgreso", connection)
            command.CommandType = CommandType.StoredProcedure

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0)
            connection.Close()

            Return resultadoDT

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoEgreso")
            connection.Close()
            Return Nothing

        End Try


    End Function
End Class
