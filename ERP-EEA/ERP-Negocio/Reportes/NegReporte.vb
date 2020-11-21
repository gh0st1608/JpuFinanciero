Imports ERP_Datos

Public Class NegReporte
    Dim objProformaReporteDat As New DatReporte

    Public Function ObtenerReporteIngresos(ByVal GrupoIngresoId As Integer, ByVal ClienteId As Integer, ByVal PeriodoInicial As Integer, ByVal PeriodoFinal As Integer, ByVal VerTotal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteIngresos(GrupoIngresoId, ClienteId, PeriodoInicial, PeriodoFinal, VerTotal)
    End Function

    Public Function ObtenerReporteEgresos(ByVal GrupoEgresoId As Integer, ByVal SubGrupoEgresoId As Integer, ByVal ProveedorId As Integer, ByVal PeriodoInicial As Integer, ByVal PeriodoFinal As Integer, ByVal VerTotal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteEgresos(GrupoEgresoId, SubGrupoEgresoId, ProveedorId, PeriodoInicial, PeriodoFinal, VerTotal)
    End Function

    Public Function ObtenerReporteRatios(ByVal RatioId As Integer, ByVal PeriodoInicial As Integer, ByVal PeriodoFinal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteRatios(RatioId, PeriodoInicial, PeriodoFinal)
    End Function

End Class
