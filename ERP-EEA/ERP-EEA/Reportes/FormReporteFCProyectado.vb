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
    End Sub

    Private Sub cargarCombo()

        cboPeriodoInicialFiltro.ValueMember = "IdPeriodo"
        cboPeriodoInicialFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoInicialFiltro.DataSource = negPeriodo.ObtenerLista(False, True, 1)

    End Sub

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        modoInicial()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cboPeriodoInicialFiltro.SelectedValue = 0 Then
            MsgBox("Escoger el periodo correctamente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            dataSet = negReporte.ObtenerReporteFCProyectado(cboPeriodoInicialFiltro.SelectedValue)
            dataSet.Tables(0).TableName = "DtReporteFCProyectadoFiltro"
            dataSet.Tables(1).TableName = "DtReporteFCProyectadoDataEgreso"
            dataSet.Tables(2).TableName = "DtReporteFCProyectadoDataActivo"
            dataSet.Tables(3).TableName = "DtReporteFCProyectadoDataPasivo"
            dataSet.Tables(4).TableName = "DtReporteFCProyectadoVenta"

            Dim objForm As New FormReport With {
                .Width = 1090,
                .DsReport = dataSet,
                .Text = "Reporte FCProyectado",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteFCProyectado,
                .ImageReport = True,
                .SubReport = False
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
End Class