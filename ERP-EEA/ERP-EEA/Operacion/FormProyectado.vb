Imports ERP_Entidad
Imports ERP_Negocio
Public Class FormProyectado

#Region "Variables"
    Dim negProyectado As New NegProyectado
    Dim entProyectado As New EntProyectado
    Dim entPeriodo As New EntPeriodo
    Dim negPeriodo As New NegPeriodo
    Dim entGrupoEgreso As New EntGrupoEgreso
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim entSubGrupoEgreso As New EntSubGrupoEgreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim dataTable As New DataTable
    Dim operacion As Boolean = False

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 290
        operacion = False
        txtIdProyectado.Text = "0"
        txtImporteProyectado.Text = ""
        cboGrupoEgreso.SelectedValue = 0
        cboSubGrupoEgreso.SelectedValue = 0
        cboPeriodo.SelectedValue = 0
        txtImporteProyectado.Enabled = True
        cboPeriodo.Enabled = True
        btnNuevo.Enabled = True
        CargarTablaProyectado()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 397
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvProyectado.Enabled = False

    End Sub

#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaProyectado()
        dataTable = negProyectado.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue)
        dgvProyectado.DataSource = dataTable
        If dgvProyectado.Rows.Count > 0 Then
            dgvProyectado.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvProyectado.Enabled = False
        End If
    End Sub


    Private Sub CargarCombo()
        cboGrupoEgreso.ValueMember = "IdGrupoEgreso"
        cboGrupoEgreso.DisplayMember = "Descripcion"
        cboGrupoEgreso.DataSource = negGrupoEgreso.ObtenerLista(False, True)

        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True, 0)

        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False, 0)

    End Sub

#End Region

#Region "Funciones Principales (CRUD)"
    'EGRESO
    Private Sub CrearProyectado()

        entProyectado.TipoOperacionId = 2 'Egreso

        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Grupo de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If
        If cboSubGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Item de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.SubGrupoEgresoId = cboSubGrupoEgreso.SelectedValue
        End If


        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtImporteProyectado.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.ImporteProvision = Convert.ToDecimal(txtImporteProyectado.Text)
        End If

        entProyectado.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negProyectado.Guardar(entProyectado)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Proyectado")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Proyectado")
        End If

    End Sub

    Private Sub LeerProyectado()
        If dgvProyectado.Rows.Count > 0 Then
            cboPeriodo.Enabled = False
            entProyectado = negProyectado.ObtenerData(dgvProyectado.CurrentRow.Cells("IdProyectado").Value, 0, 0)
            txtIdProyectado.Text = entProyectado.IdProyectado
            cboGrupoEgreso.SelectedValue = entProyectado.GrupoEgresoId
            cboSubGrupoEgreso.SelectedValue = entProyectado.SubGrupoEgresoId
            cboPeriodo.SelectedValue = entProyectado.PeriodoId
            txtImporteProyectado.Text = entProyectado.ImporteProvision.ToString(“##,##0.00”)
        End If
    End Sub

    Private Sub ActualizarProyectado(ByVal actualizarPago As Boolean)
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Grupo de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If

        If cboSubGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Item de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.SubGrupoEgresoId = cboSubGrupoEgreso.SelectedValue
        End If

        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtImporteProyectado.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entProyectado.ImporteProvision = Convert.ToDecimal(txtImporteProyectado.Text)
        End If

        entProyectado.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negProyectado.Actualizar(entProyectado)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Proyectado")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Proyectado")
        End If
    End Sub
    Private Sub EliminarProyectado()
        If dgvProyectado.Rows.Count > 0 Then
            entProyectado = negProyectado.ObtenerData(dgvProyectado.CurrentRow.Cells("IdProyectado").Value, 0, 0)
            entProyectado.UsuarioModificacionId = VariableGlobal.VGIDUsuario
            operacion = negProyectado.Eliminar(entProyectado)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Proyectado")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Proyectado")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormProyectado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormProyectado_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerProyectado()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarProyectado()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdProyectado.Text = "0" Then
            CrearProyectado()
        Else
            ActualizarProyectado(False)
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerProyectado()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarProyectado()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaProyectado()
    End Sub

    Private Sub cboGrupoEgreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoEgreso.SelectedIndexChanged
        If cboGrupoEgreso.SelectedValue = 0 Then
            cboSubGrupoEgreso.Enabled = False
        Else
            cboSubGrupoEgreso.Enabled = True
            cboSubGrupoEgreso.ValueMember = "IdSubGrupoEgreso"
            cboSubGrupoEgreso.DisplayMember = "ItemSubGrupoEgreso"
            cboSubGrupoEgreso.DataSource = negSubGrupoEgreso.ObtenerLista(False, True, cboGrupoEgreso.SelectedValue)
        End If
    End Sub

    Private Sub cbPeriodoFiltro_TextChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.TextChanged
        If cbPeriodoFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cbPeriodoFiltro.Text, 2)
            cbPeriodoFiltro.SelectedValue = entPeriodo.IdPeriodo
            CargarTablaProyectado()
        End If
    End Sub

#End Region

End Class