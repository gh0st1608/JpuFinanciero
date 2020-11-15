
Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormReporteIngresos
    Dim negReporte As New NegReporte
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim negCliente As New NegCliente
    Dim negPeriodo As New NegPeriodo

    Dim dataSet As New DataSet
    Dim verTotal = 0
    Dim columnaSeleccionada As New Boolean
    Private Sub modoInicial()
        Me.Height = 238
        Me.Width = 427
        cboClienteFiltro.SelectedValue = 0
        cboGrupoIngresoFiltro.SelectedValue = 0
        cboPeriodoFiltro.SelectedIndex = 0
        dtpFechaInicialFiltro.Value = DateTime.Now
        dtpFechaFinalFiltro.Value = DateTime.Now
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

        cboPeriodoFiltro.ValueMember = "IdPeriodo"
        cboPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)



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
            dataSet = negReporte.ObtenerReporteIngresos(cboGrupoIngresoFiltro.SelectedValue, cboClienteFiltro.SelectedValue, cboPeriodoFiltro.SelectedValue, dtpFechaInicialFiltro.Value, dtpFechaFinalFiltro.Value, verTotal)


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



End Class