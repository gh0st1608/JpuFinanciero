Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormUsuario
#Region "Variables"
    Dim negUsuario As New NegUsuario
    Dim entUsuario As New EntUsuario
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 204
        txtIdUsuario.Text = "0"
        txtNombreUsuario.Text = ""
        txtNombreCompleto.Text = ""
        txtContraseña.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvUsuario.Enabled = False
        cboEstado.Visible = False
        lblEstado.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 340
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvUsuario.Enabled = False
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negUsuario.ObtenerTabla()
        dgvUsuario.DataSource = dataTable
        If dgvUsuario.Rows.Count > 0 Then
            dgvUsuario.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearUsuario()
        If txtNombreCompleto.Text = "" Then
            MsgBox("Ingresar Nombres y apellidos", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entUsuario.NombreCompleto = txtNombreCompleto.Text
        End If
        If txtNombreUsuario.Text = "" Then
            MsgBox("Ingresar Nombre de usuario", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entUsuario.NombreUsuario = txtNombreUsuario.Text
        End If
        If txtContraseña.Text = "" Then
            MsgBox("Ingresar Contraseña", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entUsuario.Contraseña = txtContraseña.Text
        End If

        operacion = negUsuario.Guardar(entUsuario)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Usuario")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Usuario")
        End If
    End Sub

    Private Sub LeerUsuario()
        entUsuario = negUsuario.ObtenerData(dgvUsuario.CurrentRow.Cells("IdUsuario").Value, "")
        txtIdUsuario.Text = entUsuario.IdUsuario
        txtNombreCompleto.Text = entUsuario.NombreCompleto
        txtNombreUsuario.Text = entUsuario.NombreUsuario
        txtContraseña.Text = entUsuario.Contraseña

        If (entUsuario.EstadoId = 0) Then
            cboEstado.Visible = True
            lblEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub

    Private Sub ActualizarUsuario()
        If txtNombreCompleto.Text = "" Then
            MsgBox("Ingresar Nombres y apellidos", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entUsuario.NombreCompleto = txtNombreCompleto.Text
        End If
        If txtNombreUsuario.Text = "" Then
            MsgBox("Ingresar Nombre de usuario", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entUsuario.NombreUsuario = txtNombreUsuario.Text
        End If
        If txtContraseña.Text = "" Then
            MsgBox("Ingresar Contraseña", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entUsuario.Contraseña = txtContraseña.Text
        End If

        If (cboEstado.SelectedItem = "INACTIVO") Then
            entUsuario.EstadoId = 0
        Else
            entUsuario.EstadoId = 1
        End If

        operacion = negUsuario.Actualizar(entUsuario)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Usuario")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Usuario")
        End If
    End Sub

    Private Sub EliminarUsuario()
        entUsuario.IdUsuario = Int(dgvUsuario.CurrentRow.Cells("IDUsuario").Value)

        operacion = negUsuario.Eliminar(entUsuario)
        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Usuario")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Usuario")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerUsuario()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarUsuario()
            ModoInicial()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdUsuario.Text = "0" Then
            CrearUsuario()
        Else
            ActualizarUsuario()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerUsuario()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarUsuario()
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

#End Region

End Class