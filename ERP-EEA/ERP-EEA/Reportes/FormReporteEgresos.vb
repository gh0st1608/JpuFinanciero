Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormReporteEgresos
    Dim negReporte As New NegReporte
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim negProveedor As New NegProveedor
    Dim negPeriodo As New NegPeriodo

    Dim dataSet As New DataSet
    Dim verTotal = 0
    Dim columnaSeleccionada As New Boolean
    Private Sub modoInicial()
        'Me.Height = 269
        'Me.Width = 433
        cboProveedorFiltro.SelectedValue = 0
        cboGrupoEgresoFiltro.SelectedValue = 0
        cboSubGrupoEgresoFiltro.SelectedValue = 0
        cboPeriodoFiltro.SelectedIndex = 0
        dtpFechaInicialFiltro.Value = DateTime.Now
        dtpFechaFinalFiltro.Value = DateTime.Now
        ckbTotalFiltro.Checked = True
        columnaSeleccionada = False
    End Sub

    Private Sub cargarCombo()

        cboProveedorFiltro.ValueMember = "IdProveedor"
        cboProveedorFiltro.DisplayMember = "NombreComercial"
        cboProveedorFiltro.DataSource = negProveedor.ObtenerLista(True, False)

        cboGrupoEgresoFiltro.ValueMember = "IdGrupoEgreso"
        cboGrupoEgresoFiltro.DisplayMember = "Descripcion"
        cboGrupoEgresoFiltro.DataSource = negGrupoEgreso.ObtenerLista(True, False)

        cboPeriodoFiltro.ValueMember = "IdPeriodo"
        cboPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)



    End Sub

    Private Sub FormEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            dataSet = negReporte.ObtenerReporteEgresos(cboGrupoEgresoFiltro.SelectedValue, cboSubGrupoEgresoFiltro.SelectedValue, cboProveedorFiltro.SelectedValue, cboPeriodoFiltro.SelectedValue, dtpFechaInicialFiltro.Value, dtpFechaFinalFiltro.Value, verTotal)
            'dataTableFiltro = dataSet.Tables(0)
            'dataTableData = dataSet.Tables(1)

            dataSet.Tables(0).TableName = "DtReporteEgresoFiltro"
            dataSet.Tables(1).TableName = "DtReporteEgresoData"

            Dim objForm As New FormReport With {
                .Width = 1090,
                .DsReport = dataSet,
                .Text = "Reporte de Egresos",
                .ObjParamList = New List(Of ReportParameter),
                .PathReport = VariableGlobal.VGRutaReporteEgresos,
                .ImageReport = True
            }
            objForm.Show()


        End If

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboGrupoEgresoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoEgresoFiltro.SelectedIndexChanged

        If cboGrupoEgresoFiltro.SelectedValue = 0 Then
            cboSubGrupoEgresoFiltro.Enabled = False

        Else
            cboSubGrupoEgresoFiltro.Enabled = True
            cboSubGrupoEgresoFiltro.ValueMember = "IdSubGrupoEgreso" 'indica propiedades del id del combo de select value
            cboSubGrupoEgresoFiltro.DisplayMember = "ItemSubGrupoEgreso" 'indica propiedades de lo que se muestra del combo
            cboSubGrupoEgresoFiltro.DataSource = negSubGrupoEgreso.ObtenerLista(True, False, cboGrupoEgresoFiltro.SelectedValue)

        End If

    End Sub
End Class