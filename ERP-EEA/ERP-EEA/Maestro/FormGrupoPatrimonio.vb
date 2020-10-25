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
        txtIdGrupoPatrimonio.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvGrupoPatrimonio.Enabled = False
        cboEstado.Visible = False
        lbEstado.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 392
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvGrupoPatrimonio.Enabled = False
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negGrupoPatrimonio.ObtenerTabla()
        dgvGrupoPatrimonio.DataSource = dataTable
        If dgvGrupoPatrimonio.Rows.Count > 0 Then
            dgvGrupoPatrimonio.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
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
        entGrupoPatrimonio = negGrupoPatrimonio.ObtenerData(dgvGrupoPatrimonio.CurrentRow.Cells("IdGrupoPatrimonio").Value)
        txtIdGrupoPatrimonio.Text = entGrupoPatrimonio.IdGrupoPatrimonio
        txtDescripcion.Text = entGrupoPatrimonio.Descripcion
        If (entGrupoPatrimonio.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lbEstado.Visible = True
            cboEstado.Text = "INACTIVO"
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
        If (cboEstado.SelectedItem = "INACTIVO") Then
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
        entGrupoPatrimonio.IdGrupoPatrimonio = Int(dgvGrupoPatrimonio.CurrentRow.Cells("IDGrupoPatrimonio").Value)
        entGrupoPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoPatrimonio.Eliminar(entGrupoPatrimonio)
        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Grupo Patrimonio")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Grupo Patrimonio")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoPatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoPatrimonio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerGrupoPatrimonio()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarGrupoPatrimonio()
            ModoInicial()
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
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class