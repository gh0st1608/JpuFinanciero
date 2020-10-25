Imports ERP_Entidad
Imports ERP_Datos

Public Class NegGrupoPasivo
    Dim ObjGrupoPasivoEnt As New EntGrupoPasivo
    Dim ObjGrupoPasivoDat As New DatGrupoPasivo
    Public Function ObtenerTabla() As DataTable
        Return ObjGrupoPasivoDat.LeerGrupoPasivo(0, "")
    End Function

    Public Function ObtenerData(ByVal Id As Integer) As EntGrupoPasivo
        Dim Dt As DataTable
        Dt = ObjGrupoPasivoDat.LeerGrupoPasivo(Id, "")
        If (Dt.Rows.Count() > 0) Then
            ObjGrupoPasivoEnt.IdGrupoPasivo = Convert.ToInt32(Dt.Rows(0).Item("IdGrupoPasivo"))
            ObjGrupoPasivoEnt.IdTipo = Convert.ToInt32(Dt.Rows(0).Item("TipoId"))
            ObjGrupoPasivoEnt.DescripcionTipo = Convert.ToString(Dt.Rows(0).Item("TipoDescripcion"))
            ObjGrupoPasivoEnt.Descripcion = Convert.ToString(Dt.Rows(0).Item("Descripcion"))
            ObjGrupoPasivoEnt.Cuenta = Convert.ToInt32(Dt.Rows(0).Item("Cuenta"))
            ObjGrupoPasivoEnt.IdEstadoActivo = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoActivo"))
            ObjGrupoPasivoEnt.EstadoActivo = Convert.ToString(Dt.Rows(0).Item("EstadoActivo"))
        End If
        Return ObjGrupoPasivoEnt
    End Function

    Public Function ObtenerLista(ByVal Filtro As Boolean, ByVal Seleccion As Boolean) As List(Of EntGrupoPasivo)
        Dim result = New List(Of EntGrupoPasivo)
        Dim resultadoElemento As EntGrupoPasivo
        Dim Dt As DataTable
        Dt = ObjGrupoPasivoDat.LeerGrupoPasivo(0, "")
        If (Dt.Rows.Count() > 0) Then
            If (Filtro) Then
                resultadoElemento = New EntGrupoPasivo
                resultadoElemento.IdGrupoPasivo = 0
                resultadoElemento.Descripcion = "Todos"
                result.Add(resultadoElemento)
            End If
            If (Seleccion) Then
                resultadoElemento = New EntGrupoPasivo
                resultadoElemento.IdGrupoPasivo = 0
                resultadoElemento.Descripcion = "Seleccione"
                result.Add(resultadoElemento)
            End If
            For i = 0 To Dt.Rows.Count - 1 Step 1
                resultadoElemento = New EntGrupoPasivo
                resultadoElemento.IdGrupoPasivo = Convert.ToInt32(Dt.Rows(i).Item("IdGrupoPasivo"))
                resultadoElemento.Descripcion = Convert.ToString(Dt.Rows(i)("Descripcion"))
                result.Add(resultadoElemento)
            Next i
        Else
            Return Nothing
        End If
        Return result
    End Function

    Public Function Eliminar(ByVal VarGrupoPasivo As EntGrupoPasivo) As Boolean
        Return ObjGrupoPasivoDat.EliminarGrupoPasivo(VarGrupoPasivo)
    End Function

    Public Function Guardar(ByVal VarGrupoPasivo As EntGrupoPasivo) As Boolean
        Return ObjGrupoPasivoDat.CrearGrupoPasivo(VarGrupoPasivo)
    End Function

    Public Function Actualizar(ByVal VarGrupoPasivo As EntGrupoPasivo) As Boolean
        Return ObjGrupoPasivoDat.ActualizarGrupoPasivo(VarGrupoPasivo)
    End Function
End Class
