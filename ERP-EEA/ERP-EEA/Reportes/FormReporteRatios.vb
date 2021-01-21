Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormReporteRatios
    Dim negReporte As New NegReporte
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim negTipoRatio As New NegTipoRatio
    Dim dataSet As New DataSet
    Dim verTotal = 0
    Private Sub modoInicial()
        Me.Height = 178
        Me.Width = 325
        cboPeriodoInicialFiltro.SelectedIndex = 0
        cboPeriodoFinalFiltro.SelectedIndex = 0
    End Sub

    Private Sub cargarCombo()
        cboPeriodoInicialFiltro.ValueMember = "IdPeriodo"
        cboPeriodoInicialFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoInicialFiltro.DataSource = negPeriodo.ObtenerLista(False, True, 1)

        cboPeriodoFinalFiltro.ValueMember = "IdPeriodo"
        cboPeriodoFinalFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoFinalFiltro.DataSource = negPeriodo.ObtenerLista(False, True, 1)
    End Sub

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        modoInicial()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cboPeriodoInicialFiltro.SelectedValue = 0 Or cboPeriodoFinalFiltro.SelectedValue = 0 Or cboPeriodoFinalFiltro.SelectedValue < cboPeriodoInicialFiltro.SelectedValue Then
            MsgBox("Escoger el periodo inicio y el periodo fin correctamente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            dataSet = negReporte.ObtenerReporteRatios(cboPeriodoInicialFiltro.SelectedValue, cboPeriodoFinalFiltro.SelectedValue)
            dataSet.Tables(0).TableName = "DtReporteRatioFiltro"
            dataSet.Tables(1).TableName = "DtReporteRatioData"

            Dim objForm As New FormReport With {
                .Width = 1090,
                .DsReport = dataSet,
                .Text = "Reporte de Ratios",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteRatios,
                .ImageReport = True,
                .SubReport = True
            }
            objForm.Show()
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        modoInicial()
    End Sub

    Private Sub cboPeriodoInicialFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoInicialFiltro.TextChanged
        If cboPeriodoInicialFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cboPeriodoInicialFiltro.Text, 0)
            cboPeriodoInicialFiltro.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub

    Private Sub cboPeriodoFinalFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoFinalFiltro.TextChanged
        If cboPeriodoFinalFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cboPeriodoFinalFiltro.Text, 0)
            cboPeriodoFinalFiltro.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub

End Class