Imports Microsoft.Reporting.WinForms

Public Class FormReportes
    Dim listado As New List(Of ReportParameter)
    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer.RefreshReport()
    End Sub
End Class