Imports ERP_Datos

Public Class NegReporte
    Dim objProformaReporteDat As New DatReporte

    Public Function ObtenerReporteIngresos(ByVal GrupoIngresoId As Integer, ByVal ClienteId As Integer, ByVal PeriodoId As Integer, ByVal FechaInicio As Date, ByVal FechaFinal As Date, ByVal VerTotal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteIngresos(GrupoIngresoId, ClienteId, PeriodoId, FechaInicio, FechaFinal, VerTotal)
    End Function

    Public Function ObtenerReporteEgresos(ByVal GrupoEgresoId As Integer, ByVal SubGrupoEgresoId As Integer, ByVal ProveedorId As Integer, ByVal PeriodoId As Integer, ByVal FechaInicio As Date, ByVal FechaFinal As Date, ByVal VerTotal As Integer) As DataSet
        Return objProformaReporteDat.ObtenerDataReporteEgresos(GrupoEgresoId, SubGrupoEgresoId, ProveedorId, PeriodoId, FechaInicio, FechaFinal, VerTotal)
    End Function
End Class
