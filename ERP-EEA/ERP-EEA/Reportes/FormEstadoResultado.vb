Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormEstadoResultado
    Dim negReporte As New NegReporte
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim negProveedor As New NegProveedor
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo

    Dim dataSet As New DataSet

    Private Sub modoInicial()
        cbPeriodoInicio.SelectedValue = 0
        cbPeriodoFin.SelectedValue = 0
    End Sub

    Private Sub cargarCombo()
        cbPeriodoInicio.ValueMember = "IdPeriodo"
        cbPeriodoInicio.DisplayMember = "DescripcionPeriodo"
        cbPeriodoInicio.DataSource = negPeriodo.ObtenerLista(False, True, 1)

        cbPeriodoFin.ValueMember = "IdPeriodo"
        cbPeriodoFin.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFin.DataSource = negPeriodo.ObtenerLista(False, True, 1)
    End Sub
    Private Sub FormEstadoResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        modoInicial()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cbPeriodoFin.SelectedValue = 0 Or cbPeriodoInicio.SelectedValue = 0 Or cbPeriodoFin.SelectedValue < cbPeriodoInicio.SelectedValue Then
            MsgBox("Escoger el periodo inicio y el periodo fin correctamente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            dataSet = negReporte.ObtenerReporteEstadoResultados(cbPeriodoInicio.SelectedValue, cbPeriodoFin.SelectedValue)
            dataSet.Tables(0).TableName = "DtEstadoResultadoFiltro"
            dataSet.Tables(1).TableName = "DtEstadoResultadoData"
            Dim objForm As New FormReport With {
                .DsReport = dataSet,
                .Text = "Reporte de Estado de Resultados",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteEstadoResultados,
                .ImageReport = True,
                .SubReport = False
            }
            objForm.Show()
        End If
    End Sub

    Private Sub cbPeriodoInicio_TextChanged(sender As Object, e As EventArgs) Handles cbPeriodoInicio.TextChanged
        If cbPeriodoInicio.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cbPeriodoInicio.Text, 0)
            cbPeriodoInicio.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub

    Private Sub cbPeriodoFin_TextChanged(sender As Object, e As EventArgs) Handles cbPeriodoFin.TextChanged
        If cbPeriodoFin.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cbPeriodoFin.Text, 0)
            cbPeriodoFin.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub
End Class