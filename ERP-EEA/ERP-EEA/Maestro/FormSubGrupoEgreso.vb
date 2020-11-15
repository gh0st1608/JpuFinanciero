Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormSubGrupoEgreso
#Region "Variables"
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim entSubGrupoEgreso As New EntSubGrupoEgreso
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 295
        operacion = False
        txtIdSubGrupoEgreso.Text = "0"
        cboGrupoEgreso.SelectedValue = 0
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        lbEstado.Visible = False
        cboEstado.Visible = False
        Panel.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 404
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvSubGrupoEgreso.Enabled = False
        Panel.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negSubGrupoEgreso.ObtenerTabla(True)
        dgvSubGrupoEgreso.DataSource = dataTable
        If dgvSubGrupoEgreso.Rows.Count > 0 Then
            dgvSubGrupoEgreso.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvSubGrupoEgreso.Enabled = False
        End If
    End Sub

    Private Sub CargarCombo()
        cboGrupoEgreso.ValueMember = "IdGrupoEgreso"
        cboGrupoEgreso.DisplayMember = "Descripcion"
        cboGrupoEgreso.DataSource = negGrupoEgreso.ObtenerLista(False, True)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearSubGrupoEgreso()
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger grupo egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entSubGrupoEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entSubGrupoEgreso.ItemSubGrupoEgreso = txtDescripcion.Text
        End If
        entSubGrupoEgreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negSubGrupoEgreso.Guardar(entSubGrupoEgreso)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Sub-Grupo Pasivo")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Sub-Grupo Pasivo")
        End If
    End Sub

    Private Sub LeerSubGrupoEgreso()
        If dgvSubGrupoEgreso.Rows.Count > 0 Then
            entSubGrupoEgreso = negSubGrupoEgreso.ObtenerData(dgvSubGrupoEgreso.CurrentRow.Cells("IdSubGrupoEgreso").Value)
            txtIdSubGrupoEgreso.Text = entSubGrupoEgreso.IdSubGrupoEgreso
            cboGrupoEgreso.SelectedValue = entSubGrupoEgreso.GrupoEgresoId
            txtDescripcion.Text = entSubGrupoEgreso.ItemSubGrupoEgreso

            If (entSubGrupoEgreso.IdEstadoActivo = 0) Then
                cboEstado.Visible = True
                lbEstado.Visible = True
                cboEstado.Text = "Inactivo"
            End If
        End If
    End Sub

    Private Sub ActualizarSubGrupoEgreso()
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger grupo egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entSubGrupoEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entSubGrupoEgreso.ItemSubGrupoEgreso = txtDescripcion.Text
        End If
        entSubGrupoEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "Inactivo") Then
            entSubGrupoEgreso.IdEstadoActivo = 0
        Else
            entSubGrupoEgreso.IdEstadoActivo = 1
        End If

        operacion = negSubGrupoEgreso.Actualizar(entSubGrupoEgreso)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Sub-Grupo Pasivo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Sub-Grupo Pasivo")
        End If
    End Sub

    Private Sub EliminarSubGrupoEgreso()
        If dgvSubGrupoEgreso.Rows.Count > 0 Then
            entSubGrupoEgreso.IdSubGrupoEgreso = Int(dgvSubGrupoEgreso.CurrentRow.Cells("IdSubGrupoEgreso").Value)
            entSubGrupoEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            operacion = negSubGrupoEgreso.Eliminar(entSubGrupoEgreso)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Sub-Grupo Pasivo")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Sub-Grupo Pasivo")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormSubGrupoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormSubGrupoEgreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerSubGrupoEgreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarSubGrupoEgreso()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdSubGrupoEgreso.Text = "0" Then
            CrearSubGrupoEgreso()
        Else
            ActualizarSubGrupoEgreso()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerSubGrupoEgreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarSubGrupoEgreso()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class