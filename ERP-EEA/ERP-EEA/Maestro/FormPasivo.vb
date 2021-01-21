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
    Dim entPeriodo As New EntPeriodo
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim blnActualizar As Boolean = False
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 298
        operacion = False
        txtIdPasivo.Text = "0"
        cboPeriodo.SelectedValue = 0
        btnNuevo.Enabled = True
        PanelPasivo.Visible = False
        CargarTablaPasivo()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 409
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        PanelPasivo.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaPasivo()
        dataTable = negPasivo.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, 0, True)
        dgvPasivo.DataSource = dataTable
        If dgvPasivo.Rows.Count > 0 Then
            dgvPasivo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvPasivo.Enabled = False
        End If
    End Sub

    Private Sub CargarCombo()
        cboTipoPasivo.ValueMember = "IdGrupoPasivo"
        cboTipoPasivo.DisplayMember = "Descripcion"
        cboTipoPasivo.DataSource = negGrupoPasivo.ObtenerLista(False, True)
        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True, 1)
        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False, 1)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearPasivo()
        If cboTipoPasivo.SelectedValue = 0 Then
            MsgBox("Escoger Tipo Pasivo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPasivo.GrupoPasivoId = cboTipoPasivo.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger el periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPasivo.PeriodoId = cboPeriodo.SelectedValue
        End If
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el subtotal", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPasivo.Monto = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPasivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negPasivo.Guardar(entPasivo)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Pasivo")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Pasivo")
        End If
    End Sub

    Private Sub LeerPasivo()
        If dgvPasivo.Rows.Count > 0 Then
            entPasivo = negPasivo.ObtenerData(dgvPasivo.CurrentRow.Cells("IdPasivo").Value, 0, 0)
            txtIdPasivo.Text = entPasivo.IdPasivo
            cboTipoPasivo.SelectedValue = entPasivo.GrupoPasivoId
            cboPeriodo.SelectedValue = entPasivo.PeriodoId
            txtSubTotal.Text = entPasivo.Monto.ToString(“##,##0.00”)
        End If
    End Sub

    Private Sub ActualizarPasivo()
        If cboTipoPasivo.SelectedValue = 0 Then
            MsgBox("Escoger Tipo Pasivo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPasivo.GrupoPasivoId = cboTipoPasivo.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger el periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPasivo.PeriodoId = cboPeriodo.SelectedValue
        End If
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el subtotal", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPasivo.Monto = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negPasivo.Actualizar(entPasivo)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Pasivo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Pasivo")
        End If
    End Sub

    Private Sub EliminarPasivo()
        If dgvPasivo.Rows.Count > 0 Then
            entPasivo.IdPasivo = dgvPasivo.CurrentRow.Cells("IdPasivo").Value
            entPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario
            operacion = negPasivo.Eliminar(entPasivo)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Pasivo")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Pasivo")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormPasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormPasivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerPasivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarPasivo()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdPasivo.Text = "0" Then
            CrearPasivo()
        Else
            ActualizarPasivo()
        End If
        If operacion Then
            ModoInicial()
        End If
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
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaPasivo()
    End Sub

    Private Sub cbPeriodoFiltro_TextChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.TextChanged
        If cbPeriodoFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cbPeriodoFiltro.Text, 0)
            cbPeriodoFiltro.SelectedValue = EntPeriodo.IdPeriodo
            CargarTablaPasivo()
        End If
    End Sub
#End Region
End Class
