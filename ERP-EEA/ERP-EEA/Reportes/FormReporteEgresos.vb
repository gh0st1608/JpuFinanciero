Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormReporteEgresos
    Dim negReporte As New NegReporte
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim negProveedor As New NegProveedor
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim dataSet As New DataSet
    Dim verTotal = 0
    Dim columnaSeleccionada As New Boolean

    Private Sub modoInicial()
        cboProveedorFiltro.SelectedValue = 0
        cboGrupoEgresoFiltro.SelectedValue = 0
        cboSubGrupoEgresoFiltro.SelectedValue = 0
        cboPeriodoInicialFiltro.SelectedValue = 0
        cboPeriodoFinalFiltro.SelectedValue = 0
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

        cboPeriodoFinalFiltro.ValueMember = "IdPeriodo"
        cboPeriodoFinalFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoFinalFiltro.DataSource = negPeriodo.ObtenerLista(False, True, 1)

        cboPeriodoInicialFiltro.ValueMember = "IdPeriodo"
        cboPeriodoInicialFiltro.DisplayMember = "DescripcionPeriodo"
        cboPeriodoInicialFiltro.DataSource = negPeriodo.ObtenerLista(False, True, 1)
    End Sub

    Private Sub FormEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        modoInicial()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cboPeriodoInicialFiltro.SelectedValue = 0 Or cboPeriodoFinalFiltro.SelectedValue = 0 Or cboPeriodoFinalFiltro.SelectedValue < cboPeriodoInicialFiltro.SelectedValue Then
            MsgBox("Escoger el periodo inicio y el periodo fin correctamente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            dataSet = negReporte.ObtenerReporteEgresos(cboGrupoEgresoFiltro.SelectedValue, cboSubGrupoEgresoFiltro.SelectedValue, cboProveedorFiltro.SelectedValue, cboPeriodoInicialFiltro.SelectedValue, cboPeriodoFinalFiltro.SelectedValue)

            dataSet.Tables(0).TableName = "DtReporteEgresoFiltro"
            dataSet.Tables(1).TableName = "DtReporteEgresoData"

            Dim objForm As New FormReport With {
                    .Width = 1090,
                    .DsReport = dataSet,
                    .Text = "Reporte de Egresos",
                    .ObjParamList = New List(Of ReportParameter),
                    .PathReport = VariableGlobal.VGRutaReporteEgresos,
                    .ImageReport = True,
                    .SubReport = False
                }
            objForm.Show()
        End If

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
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