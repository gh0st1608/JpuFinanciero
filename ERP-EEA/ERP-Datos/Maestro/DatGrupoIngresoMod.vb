Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

'Enlazar la entidad GrupoIngreso

Imports ERP_Entidad

Module DatGrupoIngresoMod
    Dim connection As SqlConnection
    Public Function CrearGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso, ByVal blnNuevo As Boolean) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            command = New SqlCommand("CrearGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Crear
            'If blnNuevo Then
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioId", SqlDbType.Int)
            command.Parameters.Add("@ManOpcion", SqlDbType.Int)

            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioId").Value = objGrupoIngreso.UsuarioModificacionId
            command.Parameters("@ManOpcion").Value = blnNuevo

            command.ExecuteReader()
            connection.Close()
            Return 0 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return 1 'false
        End Try

    End Function


    Public Function ActualizarGrupoIngreso(ByVal objGrupoIngreso As EntGrupoIngreso, ByVal blnNuevo As Boolean) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar)
            command.Parameters.Add("@Estado", SqlDbType.Int)
            command.Parameters.Add("@UsuarioId", SqlDbType.Int)
            command.Parameters.Add("@ManOpcion", SqlDbType.Int)

            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@Descripcion").Value = objGrupoIngreso.Descripcion
            command.Parameters("@Estado").Value = objGrupoIngreso.EstadoActivo
            command.Parameters("@UsuarioId").Value = objGrupoIngreso.UsuarioCreacionId
            command.Parameters("@ManOpcion").Value = blnNuevo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return 1 'false
        End Try

    End Function

    Public Function EliminarGrupoIngreso(ByVal objGrupoIngreso) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminraGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdGrupoIngreso", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModiciacionId", SqlDbType.Int)
            command.Parameters("@IdGrupoIngreso").Value = objGrupoIngreso.IdGrupoIngreso
            command.Parameters("@UsuarioModificacionId").Value = objGrupoIngreso.UsuarioModificacionId


            command.ExecuteReader()
            connection.Close()
            Return 0 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return 1 'false
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

    Public Function LeerGrupoIngresoPorId(ByVal estado As Integer) As DataSet
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim result As DataSet

        Try
            connection.Open()
            command = New SqlCommand("Sel_MaeGrupoIngreso", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Estado", SqlDbType.Int)
            command.Parameters("@Estado").Value = estado

            result = New DataSet
            adapter = New SqlDataAdapter(command)
            adapter.Fill(result)

            connection.Close()
            Return result
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GrupoIngreso")
            connection.Close()
            Return Nothing
        End Try

    End Function


    'Public Function ObtenerLista(ByVal forFilter As Boolean, ByVal estado As Integer, ByVal indObject As String) As List(Of GrupoIngreso)
    '    Dim command As SqlCommand
    '    Dim reader As SqlDataReader
    '    Dim result As List(Of Area)
    '    Dim resultElement As Area

    '    Try
    '        connection.Open()
    '        command = New SqlCommand("up_sel_maeArea", connection)
    '        command.CommandType = CommandType.StoredProcedure

    '        command.Parameters.Add("@Estado", SqlDbType.Int)
    '        command.Parameters.Add("@indObject", SqlDbType.Char)

    '        command.Parameters("@Estado").Value = estado
    '        command.Parameters("@indObject").Value = indObject

    '        reader = command.ExecuteReader()

    '        If reader.HasRows() Then
    '            result = New List(Of Area)

    '            If forFilter Then
    '                resultElement = New Area()
    '                resultElement.idArea = 0
    '                resultElement.Descripcion = "TODOS"
    '                result.Add(resultElement)
    '            End If

    '            While reader.Read()
    '                resultElement = New Area()
    '                resultElement.idArea = reader.GetInt32(0)
    '                resultElement.Descripcion = reader.GetString(1).ToUpper
    '                result.Add(resultElement)
    '            End While
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







End Module
