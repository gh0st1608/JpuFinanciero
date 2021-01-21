Imports ERP_Datos

Public Class NegReporte
    Dim objProformaReporteDat As New DatReporte

    Public Function ObtenerReporteIngresos(ByVal GrupoIngresoId As Integer, ByVal ClienteId As Integer, ByVal PeriodoInicial As Integer, ByVal PeriodoFinal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteIngresos(GrupoIngresoId, ClienteId, PeriodoInicial, PeriodoFinal)
    End Function

    Public Function ObtenerReporteEgresos(ByVal GrupoEgresoId As Integer, ByVal SubGrupoEgresoId As Integer, ByVal ProveedorId As Integer, ByVal PeriodoInicial As Integer, ByVal PeriodoFinal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteEgresos(GrupoEgresoId, SubGrupoEgresoId, ProveedorId, PeriodoInicial, PeriodoFinal)
    End Function

    Public Function ObtenerReporteRatios(ByVal PeriodoInicial As Integer, ByVal PeriodoFinal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteRatios(PeriodoInicial, PeriodoFinal)
    End Function

    Public Function ObtenerReporteBalanceGeneral(ByVal Periodo As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteBalanceGeneral(Periodo)
    End Function

    Public Function ObtenerReporteFCProyectado(ByVal Periodo As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteFCProyectado(Periodo)
    End Function

    Public Function ObtenerReporteEstadoResultados(ByVal PeriodoInicio As Integer, ByVal PeriodoFin As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataEstadoResultados(PeriodoInicio, PeriodoFin)
    End Function
End Class
