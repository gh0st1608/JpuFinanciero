Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormCierre
#Region "Variables"
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim negEgreso As New NegEgreso
    Dim entEgreso As New EntEgreso
    Dim negIngreso As New NegIngreso
    Dim entIngreso As New EntEgreso
    Dim negActivo As New NegActivo
    Dim entActivo As New EntActivo
    Dim negPasivo As New NegPasivo
    Dim entPasivo As New EntPasivo
    Dim negPatrimonio As New NegPatrimonio
    Dim entPatrimonio As New EntPatrimonio
    Dim negRatio As New NegRatio
    Dim entRatio As New EntRatio
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

    '1 Razon Corriente [activo coriente/pasivo corriente] (veces)
    '2 Razon Endeudamiento [pasivo total /activo total] x100 (%)
    '3 Razon de Endeudamiento Patrimonial [pasivo total / patrimonio] (veces)
    '4 Periodo Promedio de Pagos
    '5 Rotacion de Activos
    '6 Margen de Utilidad Bruta
    '7 Margen de Utilidad Operativa
    '8 Margen de utilidad neta
    '9 Rendimiento sobre activos
    '10 Rendimiento sobre patrimonio
    '11 Margen de Gasto Operativo

    Private Sub CrearRatios()

        entPasivo = negPasivo.ObtenerData(0, entPeriodo.IdPeriodo, 0)
        entActivo = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 0)
        entPatrimonio = negPatrimonio.ObtenerData(0, entPeriodo.IdPeriodo, 0)
        entRatio.PeriodoId = Int(dgvPeriodo.CurrentRow.Cells("IdPeriodo").Value)

        '1 Razon Corriente [activo coriente/pasivo corriente] (veces)
        entRatio.TipoRatioId = 1
        entRatio.Valor = (entActivo.Monto / entPasivo.Monto)
        operacion = negRatio.Guardar(entRatio)

        '2 Razon Endeudamiento [pasivo total /activo total] x100 (%)
        entRatio.TipoRatioId = 2
        entRatio.Valor = (entPasivo.Monto / entActivo.Monto) * 100
        operacion = negRatio.Guardar(entRatio)

        '3 Razon de Endeudamiento Patrimonial [pasivo total / patrimonio] (veces)
        entRatio.TipoRatioId = 3
        entRatio.Valor = (entPasivo.Monto / entPatrimonio.Monto)
        operacion = negRatio.Guardar(entRatio)

        '6 Margen de Utilidad Bruta



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
        CrearRatios()
        ModoInicial()
    End Sub

#End Region
End Class