
Imports ERP_Datos

Public Class NegReporte

    Dim objProformaReporteDat As New DatReporte

    Public Function ObtenerReporteIngresos(ByVal GrupoIngresoId As Integer, ByVal ClienteId As Integer, ByVal PeriodoId As Integer, ByVal FechaInicio As Date, ByVal FechaFinal As Date, ByVal VerTotal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteIngresos(GrupoIngresoId, ClienteId, PeriodoId, FechaInicio, FechaFinal, VerTotal)
    End Function

End Class
