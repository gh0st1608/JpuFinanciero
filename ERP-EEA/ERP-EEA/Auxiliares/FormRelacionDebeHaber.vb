Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormRelacionDebeHaber
#Region "Variables"
    Dim negRelacionDebeHaber As New NegRelacionDebeHaber
    Dim entRelacionDebeHaber As New EntRelacionDebeHaber
    Dim negGrupoActivo As New NegGrupoActivo
    Dim negGrupoPasivo As New NegGrupoPasivo
    Dim negGrupoPatrimonio As New NegGrupoPatrimonio
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim blnActualizar As Boolean = False
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 393
        operacion = False
        txtIdRelacionDebeHaber.Text = "0"
        cbEtapaOperacion.SelectedIndex = 0
        cbGrupoDebe.SelectedIndex = 0
        cbGrupoHaber.SelectedIndex = 0
        cbSignoDebe.SelectedIndex = 0
        cbSignoHaber.SelectedIndex = 0
        cbTipoOperacion.SelectedIndex = 0
        If cbDebe.Items.Count > 0 Then
            cbDebe.SelectedValue = 0
        End If
        If cbHaber.Items.Count > 0 Then
            cbHaber.SelectedValue = 0
        End If
        If cbGrupo.Items.Count > 0 Then
            cbGrupo.SelectedValue = 0
        End If
        cbDebe.Enabled = False
        cbHaber.Enabled = False
        cbGrupo.Enabled = False
        btnNuevo.Enabled = True
        PanelRelacionDebeHaber.Visible = False
        CargarTablaRelacionDebeHaber()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 563
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvRelacionDebeHaber.Enabled = False
        PanelRelacionDebeHaber.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaRelacionDebeHaber()
        dataTable = negRelacionDebeHaber.ObtenerTabla()
        dgvRelacionDebeHaber.DataSource = dataTable
        If dgvRelacionDebeHaber.Rows.Count > 0 Then
            dgvRelacionDebeHaber.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            dgvRelacionDebeHaber.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearRelacionDebeHaber()
        If cbTipoOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de operación (Ingreso/Egreso)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.TipoOperacionId = cbTipoOperacion.SelectedIndex
        End If
        If cbEtapaOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger la etapa de la operación (Registro/Cobro-Pago)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.EtapaOperacionId = cbEtapaOperacion.SelectedIndex
        End If
        If cbGrupo.SelectedValue = 0 Then
            MsgBox("Escoger la operación", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoId = cbGrupo.SelectedValue
        End If
        If cbGrupoDebe.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoDebeId = cbGrupoDebe.SelectedIndex
        End If
        If cbDebe.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.DebeId = cbDebe.SelectedValue
        End If
        If cbSignoDebe.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Debe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoDebe = cbSignoDebe.SelectedIndex
        End If
        If cbGrupoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoHaberId = cbGrupoHaber.SelectedIndex
        End If
        If cbHaber.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.HaberId = cbHaber.SelectedValue
        End If
        If cbSignoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Haber", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoHaber = cbSignoHaber.SelectedIndex
        End If
        entRelacionDebeHaber.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negRelacionDebeHaber.Guardar(entRelacionDebeHaber)
        If operacion Then
            MsgBox("Guardó con exito", MsgBoxStyle.Information, "Crear Relacion Debe-Haber")
        Else
            MsgBox("No guardó", MsgBoxStyle.Critical, "Crear Relacion Debe-Haber")
        End If
    End Sub

    Private Sub LeerRelacionDebeHaber()
        If dgvRelacionDebeHaber.Rows.Count > 0 Then
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(dgvRelacionDebeHaber.CurrentRow.Cells("IdRelacionDebeHaber").Value, 0, 0, 0)
            txtIdRelacionDebeHaber.Text = entRelacionDebeHaber.IdRelacionDebeHaber
            cbTipoOperacion.SelectedIndex = entRelacionDebeHaber.TipoOperacionId
            cbSignoHaber.SelectedIndex = entRelacionDebeHaber.SignoHaber
            cbSignoDebe.SelectedIndex = entRelacionDebeHaber.SignoDebe
            cbGrupoHaber.SelectedIndex = entRelacionDebeHaber.GrupoHaberId
            cbGrupoDebe.SelectedIndex = entRelacionDebeHaber.GrupoDebeId
            cbGrupo.SelectedValue = entRelacionDebeHaber.GrupoId
            cbEtapaOperacion.SelectedIndex = entRelacionDebeHaber.EtapaOperacionId
            cbHaber.SelectedValue = entRelacionDebeHaber.HaberId
            cbDebe.SelectedValue = entRelacionDebeHaber.DebeId
        End If
    End Sub

    Private Sub ActualizarRelacionDebeHaber()
        If cbTipoOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de operación (Ingreso/Egreso)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.TipoOperacionId = cbTipoOperacion.SelectedIndex
        End If
        If cbEtapaOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger la etapa de la operación (Registro/Cobro-Pago)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.EtapaOperacionId = cbEtapaOperacion.SelectedIndex
        End If
        If cbGrupo.SelectedValue = 0 Then
            MsgBox("Escoger la operación", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoId = cbGrupo.SelectedValue
        End If
        If cbGrupoDebe.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoDebeId = cbGrupoDebe.SelectedIndex
        End If
        If cbDebe.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.DebeId = cbDebe.SelectedValue
        End If
        If cbSignoDebe.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Debe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoDebe = cbSignoDebe.SelectedIndex
        End If
        If cbGrupoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoHaberId = cbGrupoHaber.SelectedIndex
        End If
        If cbHaber.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.HaberId = cbHaber.SelectedValue
        End If
        If cbSignoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Haber", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoHaber = cbSignoHaber.SelectedIndex
        End If
        entRelacionDebeHaber.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        entRelacionDebeHaber.IdEstadoActivo = 1

        operacion = negRelacionDebeHaber.Actualizar(entRelacionDebeHaber)
        If operacion Then
            MsgBox("Guardó con exito", MsgBoxStyle.Information, "Actualizar Relacion Debe-Haber")
        Else
            MsgBox("No guardó", MsgBoxStyle.Critical, "Actualizar Relacion Debe-Haber")
        End If
    End Sub
    Private Sub EliminarRelacionDebeHaber()
        If dgvRelacionDebeHaber.Rows.Count > 0 Then
            entRelacionDebeHaber.IdRelacionDebeHaber = dgvRelacionDebeHaber.CurrentRow.Cells("IdRelacionDebeHaber").Value
            entRelacionDebeHaber.UsuarioModificacionId = VariableGlobal.VGIDUsuario
            operacion = negRelacionDebeHaber.Eliminar(entRelacionDebeHaber)

            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Relacion Debe-Haber")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Information, "Eliminar Relacion Debe-Haber")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormRelacionDebeHaber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormRelacionDebeHaber_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerRelacionDebeHaber()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarRelacionDebeHaber()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdRelacionDebeHaber.Text = "0" Then
            CrearRelacionDebeHaber()
        Else
            ActualizarRelacionDebeHaber()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerRelacionDebeHaber()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarRelacionDebeHaber()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbTipoOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoOperacion.SelectedIndexChanged
        If cbTipoOperacion.SelectedIndex = 0 Then
            cbGrupo.Enabled = False
        Else
            If cbTipoOperacion.SelectedIndex = 1 Then
                cbGrupo.Enabled = True
                cbGrupo.DataSource = Nothing
                cbGrupo.ValueMember = "IdGrupoIngreso"
                cbGrupo.DisplayMember = "Descripcion" '
                cbGrupo.DataSource = negGrupoIngreso.ObtenerLista(False, True)
            Else
                cbGrupo.Enabled = True
                cbGrupo.DataSource = Nothing
                cbGrupo.ValueMember = "IdSubGrupoEgreso"
                cbGrupo.DisplayMember = "ItemSubGrupoEgreso" '
                cbGrupo.DataSource = negSubGrupoEgreso.ObtenerLista(False, True, 0)
            End If
        End If
    End Sub

    Private Sub cbGrupoDebe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrupoDebe.SelectedIndexChanged
        If cbTipoOperacion.SelectedIndex = 0 Then
            cbDebe.Enabled = False
        Else
            If cbGrupoDebe.SelectedIndex = 1 Then
                cbDebe.Enabled = True
                cbDebe.DataSource = Nothing
                cbDebe.ValueMember = "IdGrupoActivo"
                cbDebe.DisplayMember = "Descripcion"
                cbDebe.DataSource = negGrupoActivo.ObtenerLista(False, True)
            End If
            If cbGrupoDebe.SelectedIndex = 2 Then
                cbDebe.Enabled = True
                cbDebe.DataSource = Nothing
                cbDebe.ValueMember = "IdGrupoPasivo"
                cbDebe.DisplayMember = "Descripcion"
                cbDebe.DataSource = negGrupoPasivo.ObtenerLista(False, True)
            End If
            If cbGrupoDebe.SelectedIndex = 3 Then
                cbDebe.Enabled = True
                cbDebe.DataSource = Nothing
                cbDebe.ValueMember = "IdGrupoPatrimonio"
                cbDebe.DisplayMember = "Descripcion"
                cbDebe.DataSource = negGrupoPatrimonio.ObtenerLista(False, True)
            End If
        End If
    End Sub

    Private Sub cbGrupoHaber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrupoHaber.SelectedIndexChanged
        If cbGrupoHaber.SelectedIndex = 0 Then
            cbHaber.Enabled = False
        Else
            If cbGrupoHaber.SelectedIndex = 1 Then
                cbHaber.Enabled = True
                cbHaber.DataSource = Nothing
                cbHaber.ValueMember = "IdGrupoActivo"
                cbHaber.DisplayMember = "Descripcion"
                cbHaber.DataSource = negGrupoActivo.ObtenerLista(False, True)
            End If
            If cbGrupoHaber.SelectedIndex = 2 Then
                cbHaber.Enabled = True
                cbHaber.DataSource = Nothing
                cbHaber.ValueMember = "IdGrupoPasivo"
                cbHaber.DisplayMember = "Descripcion"
                cbHaber.DataSource = negGrupoPasivo.ObtenerLista(False, True)
            End If
            If cbGrupoHaber.SelectedIndex = 3 Then
                cbHaber.Enabled = True
                cbHaber.DataSource = Nothing
                cbHaber.ValueMember = "IdGrupoPatrimonio"
                cbHaber.DisplayMember = "Descripcion"
                cbHaber.DataSource = negGrupoPatrimonio.ObtenerLista(False, True)
            End If
        End If
    End Sub
#End Region
End Class