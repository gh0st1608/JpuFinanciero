Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormGrupoPatrimonio
#Region "Variables"
    Dim negGrupoPatrimonio As New NegGrupoPatrimonio
    Dim entGrupoPatrimonio As New EntGrupoPatrimonio
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 307
        operacion = False
        txtIdGrupoPatrimonio.Text = "0"
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
        dgvGrupoPatrimonio.Enabled = False
        Panel.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negGrupoPatrimonio.ObtenerTabla(True)
        dgvGrupoPatrimonio.DataSource = dataTable
        If dgvGrupoPatrimonio.Rows.Count > 0 Then
            dgvGrupoPatrimonio.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            dgvGrupoPatrimonio.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoPatrimonio()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoPatrimonio.Descripcion = txtDescripcion.Text
        End If
        entGrupoPatrimonio.Cuenta = 0
        entGrupoPatrimonio.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoPatrimonio.Guardar(entGrupoPatrimonio)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Grupo Patrimonio")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Grupo Patrimonio")
        End If
    End Sub
    Private Sub LeerGrupoPatrimonio()
        If dgvGrupoPatrimonio.Rows.Count > 0 Then
            entGrupoPatrimonio = negGrupoPatrimonio.ObtenerData(dgvGrupoPatrimonio.CurrentRow.Cells("IdGrupoPatrimonio").Value)
            txtIdGrupoPatrimonio.Text = entGrupoPatrimonio.IdGrupoPatrimonio
            txtDescripcion.Text = entGrupoPatrimonio.Descripcion
            If (entGrupoPatrimonio.IdEstadoActivo = 0) Then
                cboEstado.Visible = True
                lbEstado.Visible = True
                cboEstado.Text = "Inactivo"
            End If
        End If
    End Sub
    Private Sub ActualizarGrupoPatrimonio()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoPatrimonio.Descripcion = txtDescripcion.Text
        End If
        entGrupoPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        If (cboEstado.SelectedItem = "Inactivo") Then
            entGrupoPatrimonio.IdEstadoActivo = 0
        Else
            entGrupoPatrimonio.IdEstadoActivo = 1
        End If

        operacion = negGrupoPatrimonio.Actualizar(entGrupoPatrimonio)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Grupo Patrimonio")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Grupo Patrimonio")
        End If
    End Sub
    Private Sub EliminarGrupoPatrimonio()
        If dgvGrupoPatrimonio.Rows.Count > 0 Then
            entGrupoPatrimonio.IdGrupoPatrimonio = Int(dgvGrupoPatrimonio.CurrentRow.Cells("IdGrupoPatrimonio").Value)
            entGrupoPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            operacion = negGrupoPatrimonio.Eliminar(entGrupoPatrimonio)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Grupo Patrimonio")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Grupo Patrimonio")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoPatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoPatrimonio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerGrupoPatrimonio()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarGrupoPatrimonio()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoPatrimonio.Text = "0" Then
            CrearGrupoPatrimonio()
        Else
            ActualizarGrupoPatrimonio()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoPatrimonio()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoPatrimonio()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class