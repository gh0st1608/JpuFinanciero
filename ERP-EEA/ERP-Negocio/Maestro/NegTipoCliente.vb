Imports ERP_Entidad
Imports ERP_Datos

Public Class NegTipoCliente
    Dim ObjTipoClienteEnt As New EntTipoCliente
    Dim ObjTipoClienteDat As New DatTipoCliente
    Public Function ObtenerTabla() As DataTable
        Return ObjTipoClienteDat.LeerTipoCliente(0, "")
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntTipoCliente
        Dim Dt As DataTable
        Dt = ObjTipoClienteDat.LeerTipoCliente(Id, "")
        If (Dt.Rows.Count() > 0) Then
            ObjTipoClienteEnt.IdTipoCliente = Convert.ToInt32(Dt.Rows(0).Item("IdTipoCliente"))
            ObjTipoClienteEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
            ObjTipoClienteEnt.IdEstadoActivo = Convert.ToString(Dt.Rows(0).Item("IdEstadoActivo"))
            ObjTipoClienteEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))
        End If
        Return ObjTipoClienteEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntTipoCliente)
        Dim result = New List(Of EntTipoCliente)
        Dim resultadoElemento As EntTipoCliente
        Dim Dt As DataTable
        Dt = ObjTipoClienteDat.LeerTipoCliente(0, "")
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntTipoCliente
                resultadoElemento.IdTipoCliente = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntTipoCliente
                resultadoElemento.IdTipoCliente = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntTipoCliente
                resultadoElemento.IdTipoCliente = Convert.ToInt16(Dt.Rows(i).Item("IdTipoCliente"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarTipoClienteEnt As EntTipoCliente) As Boolean
        Return ObjTipoClienteDat.EliminarTipoCliente(VarTipoClienteEnt)
    End Function

    Public Function Guardar(ByVal VarTipoClienteEnt As EntTipoCliente) As Boolean
        Return ObjTipoClienteDat.CrearTipoCliente(VarTipoClienteEnt)
    End Function

    Public Function Actualizar(ByVal VarTipoClienteEnt As EntTipoCliente) As Boolean
        Return ObjTipoClienteDat.ActualizarTipoCliente(VarTipoClienteEnt)
    End Function
End Class

