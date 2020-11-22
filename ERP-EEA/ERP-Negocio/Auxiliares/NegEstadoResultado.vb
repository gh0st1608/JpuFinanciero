
Imports ERP_Entidad
Imports ERP_Datos

Public Class NegEstadoResultado
    Dim ObjEstadoResultadoEnt As New EntEstadoResultado
    Dim ObjEstadoResultadoDat As New DatEstadoResultado

    Public Function ObtenerData(ByVal IdEstadoResultado As Integer, ByVal PeriodoId As Integer, ByVal Orden As Integer) As EntEstadoResultado
        Dim Dt As New DataTable
        Dt = ObjEstadoResultadoDat.LeerEstadoResultado(0, PeriodoId, Orden)
        If (Dt.Rows.Count() > 0) Then
            ObjEstadoResultadoEnt.IdEstadoResultado = Convert.ToInt32(Dt.Rows(0).Item("IdEstadoResultado"))
            ObjEstadoResultadoEnt.Concepto = Convert.ToString(Dt.Rows(0).Item("Concepto"))
            ObjEstadoResultadoEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("Periodo"))
            ObjEstadoResultadoEnt.Valor = Convert.ToDecimal(Dt.Rows(0).Item("Valor"))

        End If
        Return ObjEstadoResultadoEnt
    End Function

    Public Function Guardar(ByVal VarEstadoResultadooEnt As EntEstadoResultado) As Boolean
        Return ObjEstadoResultadoDat.CrearEstadoResultado(VarEstadoResultadooEnt)
    End Function

End Class
