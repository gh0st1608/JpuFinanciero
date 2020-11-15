
Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormGrupoIngreso
#Region "Variables"
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim entGrupoIngreso As New EntGrupoIngreso
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 307
        operacion = False
        txtIdGrupoIngreso.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        cboEstado.Visible = False
        lbEstado.Visible = False
        Panel.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 392
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvGrupoIngreso.Enabled = False
        Panel.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negGrupoIngreso.ObtenerTabla(True)
        dgvGrupoIngreso.DataSource = dataTable
        If dgvGrupoIngreso.Rows.Count > 0 Then
            dgvGrupoIngreso.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvGrupoIngreso.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoIngreso()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoIngreso.Descripcion = txtDescripcion.Text
        End If

        entGrupoIngreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoIngreso.Guardar(entGrupoIngreso)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Grupo Ingreso")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Grupo Ingreso")
        End If
    End Sub
    Private Sub LeerGrupoIngreso()
        If dgvGrupoIngreso.Rows.Count > 0 Then
            entGrupoIngreso = negGrupoIngreso.ObtenerData(dgvGrupoIngreso.CurrentRow.Cells("IdGrupoIngreso").Value)

            txtIdGrupoIngreso.Text = entGrupoIngreso.IdGrupoIngreso
            txtDescripcion.Text = entGrupoIngreso.Descripcion

            If (entGrupoIngreso.IdEstadoActivo = 0) Then
                cboEstado.Visible = True
                lbEstado.Visible = True
                cboEstado.Text = "Inactivo"
            End If
        End If
    End Sub
    Private Sub ActualizarGrupoIngreso()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoIngreso.Descripcion = txtDescripcion.Text
        End If
        entGrupoIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "Inactivo") Then
            entGrupoIngreso.IdEstadoActivo = 0
        Else
            entGrupoIngreso.IdEstadoActivo = 1
        End If

        operacion = negGrupoIngreso.Actualizar(entGrupoIngreso)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Grupo Ingreso")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Grupo Ingreso")
        End If
    End Sub
    Private Sub EliminarGrupoIngreso()
        If dgvGrupoIngreso.Rows.Count > 0 Then
            entGrupoIngreso.IdGrupoIngreso = Int(dgvGrupoIngreso.CurrentRow.Cells("IdGrupoIngreso").Value)
            entGrupoIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            operacion = negGrupoIngreso.Eliminar(entGrupoIngreso)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Grupo Ingreso")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Grupo Ingreso")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerGrupoIngreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarGrupoIngreso()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoIngreso.Text = "0" Then
            CrearGrupoIngreso()
        Else
            ActualizarGrupoIngreso()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoIngreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoIngreso()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class