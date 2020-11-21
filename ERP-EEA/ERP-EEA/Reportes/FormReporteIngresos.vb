
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
    Dim verTotal = 0
    Dim columnaSeleccionada As New Boolean
    Private Sub modoInicial()
        'Me.Height = 238
        'Me.Width = 427
        cboClienteFiltro.SelectedValue = 0
        cboGrupoIngresoFiltro.SelectedValue = 0
        cboPeriodoInicialFiltro.SelectedIndex = 0
        cboPeriodoFinalFiltro.SelectedIndex = 0
        ckbTotalFiltro.Checked = True
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
        columnaSeleccionada = False

        If ckbTotalFiltro.Checked Then
            verTotal = 1
            columnaSeleccionada = True
        Else
            verTotal = 0
        End If

        If columnaSeleccionada Then
            dataSet = negReporte.ObtenerReporteIngresos(cboGrupoIngresoFiltro.SelectedValue, cboClienteFiltro.SelectedValue, cboPeriodoInicialFiltro.SelectedValue, cboPeriodoFinalFiltro.SelectedValue, verTotal)


            dataSet.Tables(0).TableName = "DtReporteIngresoFiltro"
            dataSet.Tables(1).TableName = "DtReporteIngresoData"

            Dim objForm As New FormReport With {
                .Width = 1090,
                .DsReport = dataSet,
                .Text = "Reporte de Ingresos",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteIngresos,
                .ImageReport = True
            }
            objForm.Show()


        End If

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        modoInicial()
    End Sub

    Private Sub cboPeriodoInicialFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoInicialFiltro.TextChanged
        If cboPeriodoInicialFiltro.Text.Length = 7 Then
            EntPeriodo = negPeriodo.ObtenerData(0, cboPeriodoInicialFiltro.Text)
            cboPeriodoInicialFiltro.SelectedValue = EntPeriodo.IdPeriodo
        End If
    End Sub

    Private Sub cboPeriodoFinalFiltro_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodoFinalFiltro.TextChanged
        If cboPeriodoFinalFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cboPeriodoFinalFiltro.Text)
            cboPeriodoFinalFiltro.SelectedValue = entPeriodo.IdPeriodo
        End If
    End Sub

End Class