Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormGrupoActivo
#Region "Variables"
    Dim negGrupoActivo As New NegGrupoActivo
    Dim entGrupoActivo As New EntGrupoActivo
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 311
        operacion = False
        txtIdGrupoActivo.Text = "0"
        txtDescripcion.Text = ""
        cbTipo.SelectedIndex = 0
        btnNuevo.Enabled = True
        cboEstado.Visible = False
        lbEstado.Visible = False
        Panel.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 422
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvGrupoActivo.Enabled = False
        Panel.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negGrupoActivo.ObtenerTabla(True)
        dgvGrupoActivo.DataSource = dataTable
        If dgvGrupoActivo.Rows.Count > 0 Then
            dgvGrupoActivo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvGrupoActivo.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoActivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoActivo.Descripcion = txtDescripcion.Text
        End If
        If cbTipo.SelectedIndex = 0 Then
            MsgBox("Escoger tipo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoActivo.IdTipo = cbTipo.SelectedIndex
        End If
        entGrupoActivo.Cuenta = 0
        entGrupoActivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoActivo.Guardar(entGrupoActivo)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Grupo Activo")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Grupo Activo")
        End If
    End Sub

    Private Sub LeerGrupoActivo()
        If dgvGrupoActivo.Rows.Count > 0 Then
            entGrupoActivo = negGrupoActivo.ObtenerData(dgvGrupoActivo.CurrentRow.Cells("IdGrupoActivo").Value)
            txtIdGrupoActivo.Text = entGrupoActivo.IdGrupoActivo
            cbTipo.SelectedIndex = entGrupoActivo.IdTipo
            txtDescripcion.Text = entGrupoActivo.Descripcion

            If (entGrupoActivo.IdEstadoActivo = 0) Then
                cboEstado.Visible = True
                lbEstado.Visible = True
                cboEstado.Text = "Inactivo"
            End If
        End If
    End Sub

    Private Sub ActualizarGrupoActivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoActivo.Descripcion = txtDescripcion.Text
        End If
        If cbTipo.SelectedIndex = 0 Then
            MsgBox("Escoger tipo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoActivo.IdTipo = cbTipo.SelectedIndex
        End If
        entGrupoActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entGrupoActivo.IdEstadoActivo = 1
        Else
            entGrupoActivo.IdEstadoActivo = 0
        End If

        operacion = negGrupoActivo.Actualizar(entGrupoActivo)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Grupo Activo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Grupo Activo")
        End If
    End Sub

    Private Sub EliminarGrupoActivo()
        If dgvGrupoActivo.Rows.Count > 0 Then
            entGrupoActivo.IdGrupoActivo = Int(dgvGrupoActivo.CurrentRow.Cells("IdGrupoActivo").Value)
            entGrupoActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            operacion = negGrupoActivo.Eliminar(entGrupoActivo)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Grupo Activo")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Grupo Activo")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoActivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerGrupoActivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarGrupoActivo()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoActivo.Text = "0" Then
            CrearGrupoActivo()
        Else
            ActualizarGrupoActivo()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoActivo()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoActivo()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class