Imports ERP_Entidad
Imports ERP_Datos

Public Class NegRatio
    Dim ObjRatioEnt As New EntRatio
    Dim ObjRatioDat As New DatRatio

    Public Function ObtenerData(ByVal Id As Integer) As EntRatio
        Dim Dt As New DataTable
        Dt = ObjRatioDat.LeerRatio(Id)
        If (Dt.Rows.Count() > 0) Then
            ObjRatioEnt.IdRatio = Convert.ToInt32(Dt.Rows(0).Item("IdRatio"))
            ObjRatioEnt.Valor = Convert.ToDecimal(Dt.Rows(0).Item("Valor"))
        End If
        Return ObjRatioEnt
    End Function

    Public Function Guardar(ByVal VarRatiooEnt As EntRatio) As Boolean
        Return ObjRatioDat.CrearRatio(VarRatiooEnt)
    End Function

End Class
