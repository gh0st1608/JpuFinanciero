Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormReporteFCProyectado

    Dim negReporte As New NegReporte
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim dataSet As New DataSet


    Private Sub modoInicial()
        Me.Height = 138
        Me.Width = 214
        cboPeriodoInicialFiltro.SelectedIndex = 0
        cboPeriodoFinalFiltro.SelectedIndex = 0
    End Sub

    Private Sub cargarCombo()

        cboPeriodoInicialFiltro.ValueMember = "IdPeriodo"
        cboPeriodoInicialFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoInicialFiltro.DataSource = negPeriodo.ObtenerLista(True, False)

        cboPeriodoFinalFiltro.ValueMember = "IdPeriodo"
        cboPeriodoFinalFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoFinalFiltro.DataSource = negPeriodo.ObtenerLista(True, False)

    End Sub

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        modoInicial()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        dataSet = negReporte.ObtenerReporteFCProyectado(cboPeriodoInicialFiltro.SelectedValue, cboPeriodoFinalFiltro.SelectedValue)
        dataSet.Tables(0).TableName = "DtReporteFCProyectadoFiltro"
        dataSet.Tables(1).TableName = "DtReporteFCProyectadoDataActivo"
        dataSet.Tables(2).TableName = "DtReporteFCProyectadoDataPasivo"
        dataSet.Tables(3).TableName = "DtReporteFCProyectadoDataEgreso"

        Dim objForm As New FormReport With {
            .Width = 1090,
            .DsReport = dataSet,
            .Text = "Reporte FCProyectado",
            .ObjParamList = New List(Of ReportParameter),
            .PathReport = VariableGlobal.VGRutaReporteFCProyectado,
            .ImageReport = True
        }
        objForm.Show()
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        modoInicial()
    End Sub

    Private Sub cboPeriodoInicialFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoInicialFiltro.TextChanged
        If cboPeriodoInicialFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cboPeriodoInicialFiltro.Text)
            cboPeriodoInicialFiltro.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub

    Private Sub cboPeriodoFinalFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoFinalFiltro.TextChanged
        If cboPeriodoFinalFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cboPeriodoFinalFiltro.Text)
            cboPeriodoFinalFiltro.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub
End Class