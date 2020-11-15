Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormCierre
#Region "Variables"
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Width = 279
        Me.Height = 286
        btnCerrar.Enabled = True
        CargarTabla()
    End Sub

#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negPeriodo.ObtenerTabla()
        dgvPeriodo.DataSource = dataTable
        If dgvPeriodo.Rows.Count > 0 Then
            dgvPeriodo.Enabled = True
            btnCerrar.Enabled = True
        Else
            btnCerrar.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"

    Private Sub ActualizaPeriodo()
        entPeriodo.IdPeriodo = Int(dgvPeriodo.CurrentRow.Cells("IdPeriodo").Value)
        entPeriodo.Cierre = 1
        operacion = negPeriodo.Actualizar(entPeriodo)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Periodo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Periodo")
        End If
    End Sub

#End Region

#Region "Funciones del formulario"
    Private Sub FormPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

#End Region

#Region "Funciones de elementos del formulario"

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ActualizaPeriodo()
        ModoInicial()
    End Sub

#End Region
End Class