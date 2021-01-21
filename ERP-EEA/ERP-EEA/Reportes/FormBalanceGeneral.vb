Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad


Public Class FormBalanceGeneral
    Dim negActivo As New NegActivo
    Dim negPasivo As New NegPasivo
    Dim entPatrimonio As New EntPatrimonio
    Dim negReporte As New NegReporte
    Dim negPeriodo As New NegPeriodo
    Dim dataSet As New DataSet

    Private Sub modoInicial()
        Me.Height = 178
        Me.Width = 325
        cboPeriodo.SelectedIndex = 0
    End Sub

    Private Sub cargarCombo()
        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True, 1)

    End Sub

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        modoInicial()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger el periodo correctamente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            dataSet = negReporte.ObtenerReporteBalanceGeneral(cboPeriodo.SelectedValue)
            dataSet.Tables(0).TableName = "DtReporteBalanceGeneralFiltro"
            dataSet.Tables(1).TableName = "DtReporteBalanceGeneralDataActivo"
            dataSet.Tables(2).TableName = "DtReporteBalanceGeneralDataPasivo"
            dataSet.Tables(3).TableName = "DtReporteBalanceGeneralDataPatrimonio"

            Dim objForm As New FormReport With {
                .Width = 1090,
                .DsReport = dataSet,
                .Text = "Reporte de Balance General",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteBalanceGeneral,
                .ImageReport = True,
                .SubReport = False
            }
            objForm.Show()
        End If
    End Sub

End Class