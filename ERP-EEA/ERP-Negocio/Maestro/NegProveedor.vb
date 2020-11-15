Imports ERP_Entidad
Imports ERP_Datos

Public Class NegProveedor
    Dim ObjProveedorEnt As New EntProveedor
    Dim ObjProveedorDat As New DatProveedor
    Public Function ObtenerTabla(TablaMaestra As Boolean) As DataTable
        Return ObjProveedorDat.LeerProveedor(0, "", TablaMaestra)
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntProveedor
        Dim Dt As DataTable
        Dt = ObjProveedorDat.LeerProveedor(Id, "", True)
        If (Dt.Rows.Count() > 0) Then
            ObjProveedorEnt.IdProveedor = Convert.ToInt32(Dt.Rows(0).Item("IdProveedor"))
            ObjProveedorEnt.Documento = Convert.ToString(Dt.Rows(0).Item("Documento"))
            ObjProveedorEnt.NombreComercial = Convert.ToString(Dt.Rows(0).Item("NombreComercial"))
            ObjProveedorEnt.RazonSocial = Convert.ToString(Dt.Rows(0).Item("RazonSocial"))
            ObjProveedorEnt.NumeroContacto = Convert.ToString(Dt.Rows(0).Item("NumeroContacto"))
            ObjProveedorEnt.Correo = Convert.ToString(Dt.Rows(0).Item("Correo"))
            ObjProveedorEnt.MedicionId = Convert.ToInt32(Dt.Rows(0).Item("MedicionId"))
            ObjProveedorEnt.Tarifa = Convert.ToString(Dt.Rows(0).Item("Tarifa"))
            ObjProveedorEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
        End If
        Return ObjProveedorEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntProveedor)
        Dim result = New List(Of EntProveedor)
        Dim resultadoElemento As EntProveedor
        Dim Dt As DataTable
        Dt = ObjProveedorDat.LeerProveedor(0, "", False)
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntProveedor
                resultadoElemento.IdProveedor = 0
                resultadoElemento.NombreComercial = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntProveedor
                resultadoElemento.IdProveedor = 0
                resultadoElemento.NombreComercial = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntProveedor
                resultadoElemento.IdProveedor = Convert.ToInt16(Dt.Rows(i).Item("IdProveedor"))
                resultadoElemento.NombreComercial = Convert.ToString(Dt.Rows(i)("NombreComercial"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarProveedorEnt As EntProveedor) As Boolean
        Return ObjProveedorDat.EliminarProveedor(VarProveedorEnt)
    End Function

    Public Function Guardar(ByVal VarProveedorEnt As EntProveedor) As Boolean
        Return ObjProveedorDat.CrearProveedor(VarProveedorEnt)
    End Function

    Public Function Actualizar(ByVal VarProveedorEnt As EntProveedor) As Boolean
        Return ObjProveedorDat.ActualizarProveedor(VarProveedorEnt)
    End Function
End Class
