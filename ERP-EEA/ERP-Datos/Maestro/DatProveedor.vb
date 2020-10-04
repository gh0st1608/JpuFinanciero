Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks

Imports ERP_Entidad

Public Class DatProveedor
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function CrearProveedor(ByVal objProveedor As EntProveedor) As Integer

        Dim command As SqlCommand

        Try
            connection.Open()
            'Procedimiento almacenado 
            command = New SqlCommand("CrearProveedor", connection)
            command.CommandType = CommandType.StoredProcedure

            'Dandole uhn tipo de dato a los parametros que van a ser vinculados a la bd
            command.Parameters.Add("@Documento", SqlDbType.VarChar, 50)
            command.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50)
            command.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Correo", SqlDbType.VarChar, 50)
            command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar, 50)
            command.Parameters.Add("@MedicionId", SqlDbType.Int)
            command.Parameters.Add("@Tarifa", SqlDbType.Float)
            command.Parameters.Add("@UsuarioCreacionId", SqlDbType.Int)


            'Preguntar si solo van estos 2 !!
            command.Parameters("@Documento").Value = objProveedor.Documento
            command.Parameters("@NombreComercial").Value = objProveedor.NombreComercial
            command.Parameters("@RazonSocial").Value = objProveedor.RazonSocial
            command.Parameters("@Correo").Value = objProveedor.Correo
            command.Parameters("@NumeroContacto").Value = objProveedor.NumeroContacto
            command.Parameters("@MedicionId").Value = objProveedor.MedicionId
            command.Parameters("@Tarifa").Value = objProveedor.Tarifa
            command.Parameters("@UsuarioCreacionId").Value = 1 'objGrupoIngreso.UsuarioCreacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Proveedor")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function ActualizarProveedor(ByVal objProveedor As EntProveedor) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("ActualizarProveedor", connection)
            command.CommandType = CommandType.StoredProcedure

            'Actualizar
            command.Parameters.Add("@IdProveedor", SqlDbType.Int)
            command.Parameters.Add("@Documento", SqlDbType.VarChar, 50)
            command.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50)
            command.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 50)
            command.Parameters.Add("@Correo", SqlDbType.VarChar, 50)
            command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar, 50)
            command.Parameters.Add("@MedicionId", SqlDbType.Int)
            command.Parameters.Add("@Tarifa", SqlDbType.Float)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)
            command.Parameters.Add("@EstadoActivo", SqlDbType.Int)

            'supuse q la fecha Creacion no era aqui

            command.Parameters("@IdProveedor").Value = objProveedor.IdProveedor
            command.Parameters("@Documento").Value = objProveedor.Documento
            command.Parameters("@NombreComercial").Value = objProveedor.NombreComercial
            command.Parameters("@RazonSocial").Value = objProveedor.RazonSocial
            command.Parameters("@Correo").Value = objProveedor.Correo
            command.Parameters("@NumeroContacto").Value = objProveedor.NumeroContacto
            command.Parameters("@MedicionId").Value = objProveedor.MedicionId
            command.Parameters("@Tarifa").Value = objProveedor.Tarifa
            command.Parameters("@UsuarioModificacionId").Value = objProveedor.UsuarioModificacionId
            command.Parameters("@EstadoActivo").Value = objProveedor.IdEstadoActivo

            command.ExecuteReader()
            connection.Close()
            Return 1 'true

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Proveedor")
            connection.Close()
            Return 0 'false
        End Try

    End Function

    Public Function EliminarProveedor(ByVal objProveedor As EntProveedor) As Integer
        Dim command As SqlCommand
        Try
            connection.Open()
            command = New SqlCommand("EliminarProveedor", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdProveedor", SqlDbType.Int)
            command.Parameters.Add("@UsuarioModificacionId", SqlDbType.Int)

            command.Parameters("@IdProveedor").Value = objProveedor.IdProveedor
            command.Parameters("@UsuarioModificacionId").Value = objProveedor.UsuarioModificacionId

            command.ExecuteReader()
            connection.Close()
            Return 1 'true
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Proveedor")
            connection.Close()
            Return 0 'false
        End Try
    End Function

    Public Function LeerProveedor(ByVal IdProveedor As Integer, ByVal Descripcion As String) As DataTable
        'Dim reader As SqlDataReader
        Dim command As SqlCommand
        Dim resultadoDT As DataTable
        Dim resultadoDS As New DataSet
        Dim adapter As SqlDataAdapter

        Try
            connection.Open()
            command = New SqlCommand("LeerProveedor", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IdProveedor", SqlDbType.Int)
            command.Parameters("@IdProveedor").Value = IdProveedor

            adapter = New SqlDataAdapter(command)
            adapter.Fill(resultadoDS)
            resultadoDT = resultadoDS.Tables(0) 'Asignar la consulta al datatable(La primera consulta "0")
            connection.Close()

            Return resultadoDT

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Proveedor")
            connection.Close()
            Return Nothing

        End Try


    End Function
End Class
