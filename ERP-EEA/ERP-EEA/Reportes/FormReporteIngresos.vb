
Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormReporteIngresos
    Dim negReporte As New NegReporte
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim negCliente As New NegCliente
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim dataSet As New DataSet
    Dim columnaSeleccionada As New Boolean

    Private Sub modoInicial()
        cboClienteFiltro.SelectedValue = 0
        cboGrupoIngresoFiltro.SelectedValue = 0
        cboPeriodoInicialFiltro.SelectedIndex = 0
        cboPeriodoFinalFiltro.SelectedIndex = 0
        columnaSeleccionada = False
    End Sub

    Private Sub cargarCombo()
        cboClienteFiltro.ValueMember = "IdCliente"
        cboClienteFiltro.DisplayMember = "Descripcion"
        cboClienteFiltro.DataSource = negCliente.ObtenerLista(True, False)

        cboGrupoIngresoFiltro.ValueMember = "IdGrupoIngreso"
        cboGrupoIngresoFiltro.DisplayMember = "Descripcion"
        cboGrupoIngresoFiltro.DataSource = negGrupoIngreso.ObtenerLista(True, False)

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
            dataSet = negReporte.ObtenerReporteIngresos(cboGrupoIngresoFiltro.SelectedValue, cboClienteFiltro.SelectedValue, cboPeriodoInicialFiltro.SelectedValue, cboPeriodoFinalFiltro.SelectedValue)
            dataSet.Tables(0).TableName = "DtReporteIngresoFiltro"
            dataSet.Tables(1).TableName = "DtReporteIngresoData"

            Dim objForm As New FormReport With {
                .Width = 1090,
                .DsReport = dataSet,
                .Text = "Reporte de Ingresos",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteIngresos,
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
            cboPeriodoInicialFiltro.SelectedValue = EntPeriodo.IdPeriodo
        End If
    End Sub

    Private Sub cboPeriodoFinalFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoFinalFiltro.TextChanged
        If cboPeriodoFinalFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cboPeriodoFinalFiltro.Text, 0)
            cboPeriodoFinalFiltro.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub

End Class