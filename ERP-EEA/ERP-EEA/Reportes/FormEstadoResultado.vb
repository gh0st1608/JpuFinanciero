Imports Microsoft.Reporting.WinForms
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormEstadoResultado
    Dim negReporte As New NegReporte
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim negProveedor As New NegProveedor
    Dim negPeriodo As New NegPeriodo

    Dim dataSet As New DataSet

    Private Sub modoInicial()
        cbPeriodoInicio.SelectedValue = 0
        cbPeriodoFin.SelectedValue = 0
    End Sub

    Private Sub cargarCombo()
        cbPeriodoInicio.ValueMember = "IdPeriodo"
        cbPeriodoInicio.DisplayMember = "DescripcionPeriodo"
        cbPeriodoInicio.DataSource = negPeriodo.ObtenerLista(True, False)

        cbPeriodoFin.ValueMember = "IdPeriodo"
        cbPeriodoFin.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFin.DataSource = negPeriodo.ObtenerLista(True, False)
    End Sub
    Private Sub FormEstadoResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class