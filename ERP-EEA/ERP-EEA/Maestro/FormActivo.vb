Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormActivo
#Region "Variables"
    Dim negActivo As New NegActivo
    Dim entActivo As New EntActivo
    Dim entGrupoActivo As New EntGrupoActivo
    Dim negGrupoActivo As New NegGrupoActivo
    Dim entPeriodo As New EntPeriodo
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 295
        operacion = False
        txtIdActivo.Text = "0"
        cboPeriodo.SelectedValue = 0
        cboTipoActivo.SelectedValue = 0
        txtSubTotal.Text = "0"
        btnNuevo.Enabled = True
        PanelActivo.Visible = False
        CargarTablaActivo()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 404
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvActivo.Enabled = False
        PanelActivo.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaActivo()
        dataTable = negActivo.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, True)
        dgvActivo.DataSource = dataTable
        If dgvActivo.Rows.Count > 0 Then
            dgvActivo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvActivo.Enabled = False
        End If
    End Sub

    Private Sub CargarCombo()
        cboTipoActivo.ValueMember = "IdGrupoActivo"
        cboTipoActivo.DisplayMember = "Descripcion"
        cboTipoActivo.DataSource = negGrupoActivo.ObtenerLista(False, True)
        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True, 1)
        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False, 1)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearActivo()
        If cboTipoActivo.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Activos", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entActivo.GrupoActivoId = cboTipoActivo.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un cliente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entActivo.PeriodoId = cboPeriodo.SelectedValue
        End If
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entActivo.Monto = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entActivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negActivo.Guardar(entActivo)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Activo")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Activo")
        End If
    End Sub

    Private Sub LeerActivo()
        If dgvActivo.Rows.Count > 0 Then
            entActivo = negActivo.ObtenerData(dgvActivo.CurrentRow.Cells("IdActivo").Value, 0, 0)
            txtIdActivo.Text = entActivo.IdActivo
            cboTipoActivo.SelectedValue = entActivo.GrupoActivoId
            cboPeriodo.SelectedValue = entActivo.PeriodoId
            txtSubTotal.Text = entActivo.Monto.ToString(“##,##0.00”)
        End If
    End Sub

    Private Sub ActualizarActivo()
        If cboTipoActivo.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Activos", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entActivo.GrupoActivoId = cboTipoActivo.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un cliente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entActivo.PeriodoId = cboPeriodo.SelectedValue
        End If
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entActivo.Monto = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entActivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negActivo.Actualizar(entActivo)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Activo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Activo")
        End If
    End Sub
    Private Sub EliminarActivo()
        If dgvActivo.Rows.Count > 0 Then
            entActivo.IdActivo = dgvActivo.CurrentRow.Cells("IdActivo").Value
            entActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario
            operacion = negActivo.Eliminar(entActivo)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Activo")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Activo")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormActivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerActivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarActivo()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdActivo.Text = "0" Then
            CrearActivo()
        Else
            ActualizarActivo()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerActivo()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarActivo()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaActivo()
    End Sub


    Private Sub cbPeriodoFiltro_TextChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.TextChanged
        If cbPeriodoFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cbPeriodoFiltro.Text, 0)
            cbPeriodoFiltro.SelectedValue = EntPeriodo.IdPeriodo
            CargarTablaActivo()
        End If
    End Sub
#End Region
End Class