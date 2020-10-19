Imports System.IO
Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormPasivo



#Region "Variables"

    Dim negPasivo As New NegPasivo
    Dim entPasivo As New EntPasivo
    Dim entGrupoPasivo As New EntGrupoPasivo
    Dim negGrupoPasivo As New NegGrupoPasivo
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim cantPasivos As Integer
    Dim blnActualizar As Boolean = False

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        CargarTablaPasivo()
        dgvPasivo.Enabled = True
        Me.Height = 273
        txtIdPasivo.Text = "0"
        cboPeriodo.SelectedValue = 0
        btnNuevo.Enabled = True
        If cantPasivos = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
        dgvPasivo.Enabled = True
        PanelPasivo.Visible = True

    End Sub

    Private Sub ModoRegistro()
        Me.Height = 460
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvPasivo.Enabled = False
        PanelPasivo.Visible = True
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaPasivo()
        dataTable = negPasivo.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, 0)
        dgvPasivo.DataSource = dataTable
        cantPasivos = dgvPasivo.Rows.Count
    End Sub


    Private Sub CargarCombo()

        cboTipoPasivo.ValueMember = "IdGrupoPasivo"
        cboTipoPasivo.DisplayMember = "Descripcion"
        cboTipoPasivo.DataSource = negGrupoPasivo.ObtenerLista(False, True)

        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True)

        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)

    End Sub



#End Region

#Region "Funciones Principales (CRUD)"
    'Pasivo
    Private Sub CrearPasivo()
        If cboTipoPasivo.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Pasivos")
            Exit Sub
        Else
            entPasivo.GrupoPasivoId = cboTipoPasivo.SelectedValue
        End If


        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entPasivo.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entPasivo.Monto = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US"))
        End If
        entPasivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negPasivo.Guardar(entPasivo)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerPasivo()

        entPasivo = negPasivo.ObtenerData(dgvPasivo.CurrentRow.Cells("IdPasivo").Value)
        txtIdPasivo.Text = entPasivo.IdPasivo
        cboTipoPasivo.SelectedValue = entPasivo.GrupoPasivoId
        cboPeriodo.SelectedValue = entPasivo.PeriodoId
        txtSubTotal.Text = entPasivo.Monto.ToString(“##,##0.00”)

    End Sub
    Private Sub ActualizarPasivo()

        If cboTipoPasivo.SelectedValue = 0 Then
            MsgBox("Escoger un Pasivo")
            Exit Sub
        Else
            entPasivo.GrupoPasivoId = cboTipoPasivo.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entPasivo.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entPasivo.Monto = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US"))
        End If

        entPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negPasivo.Actualizar(entPasivo)

        If operacion Then
            MsgBox("Se guardo bien")
            ModoInicial()
        Else
            MsgBox("No se guardo bien")
        End If
    End Sub
    Private Sub EliminarPasivo()
        entPasivo.IdPasivo = dgvPasivo.CurrentRow.Cells("IdPasivo").Value
        entPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negPasivo.Eliminar(entPasivo)

        If operacion Then
            MsgBox("Elimino con exito")
            ModoInicial()
        Else
            MsgBox("No elimino bien")
        End If
    End Sub

    'PAGO

#End Region

#Region "Funciones del formulario"
    Private Sub FormPasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormPasivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerPasivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarPasivo()
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerPasivo()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarPasivo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaPasivo()
    End Sub


#End Region
End Class
