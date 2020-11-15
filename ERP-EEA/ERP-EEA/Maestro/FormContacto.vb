Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormContacto
#Region "Variables"
    Dim negContacto As New NegContacto
    Dim entContacto As New EntContacto
    Dim negCliente As New NegCliente
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
    Dim dataTableTipoContacto As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 210
        operacion = False
        txtIdContacto.Text = "0"
        txtCargo.Text = ""
        txtCelular.Text = ""
        txtCorreo.Text = ""
        txtNombre.Text = ""
        If cbClienteFiltro.SelectedValue = 0 Then
            cbCliente.Enabled = True
        Else
            cbCliente.Enabled = False
        End If
        cbCliente.SelectedValue = cbClienteFiltro.SelectedValue
        btnNuevo.Enabled = True
        cboEstado.Visible = False
        lblEstado.Visible = False
        Panel.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 350
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvContacto.Enabled = False
        Panel.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarCombo()
        cbCliente.ValueMember = "IdCliente"
        cbCliente.DisplayMember = "Descripcion"
        cbCliente.DataSource = negCliente.ObtenerLista(False, True)
        cbClienteFiltro.ValueMember = "IdCliente"
        cbClienteFiltro.DisplayMember = "Descripcion"
        cbClienteFiltro.DataSource = negCliente.ObtenerLista(False, True)
    End Sub

    Private Sub CargarTabla()
        dataTable = negContacto.ObtenerTabla(1, cbClienteFiltro.SelectedValue, True)
        dgvContacto.DataSource = dataTable
        If dgvContacto.Rows.Count > 0 Then
            dgvContacto.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvContacto.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearContacto()
        If txtNombre.Text = "" Then
            MsgBox("Ingresar nombre", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.NombreCompleto = txtNombre.Text
        End If
        If txtCargo.Text = "" Then
            MsgBox("Ingresar cargo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.Cargo = txtCargo.Text
        End If
        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.Correo = txtCorreo.Text
        End If
        If txtCelular.Text = "" Then
            MsgBox("Ingresar celular", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.Celular = txtCelular.Text
        End If
        entContacto.TipoContactoId = 1
        entContacto.OrigenId = cbCliente.SelectedValue
        entContacto.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negContacto.Guardar(entContacto)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Contacto")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Contacto")
        End If
    End Sub
    Private Sub LeerContacto()
        If dgvContacto.Rows.Count > 0 Then
            entContacto = negContacto.ObtenerData(dgvContacto.CurrentRow.Cells("IdContacto").Value, 1, 0)

            txtIdContacto.Text = entContacto.IdContacto
            txtNombre.Text = entContacto.NombreCompleto
            txtCargo.Text = entContacto.Cargo
            txtCelular.Text = entContacto.Celular
            txtCorreo.Text = entContacto.Correo

            If (entContacto.IdEstadoActivo = 0) Then
                cboEstado.Visible = True
                lblEstado.Visible = True
                cboEstado.Text = "Inactivo"
            End If
        End If
    End Sub
    Private Sub ActualizarContacto()
        If txtNombre.Text = "" Then
            MsgBox("Ingresar nombre", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.NombreCompleto = txtNombre.Text
        End If
        If txtCargo.Text = "" Then
            MsgBox("Ingresar cargo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.Cargo = txtCargo.Text
        End If
        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.Correo = txtCorreo.Text
        End If
        If txtCelular.Text = "" Then
            MsgBox("Ingresar celular", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entContacto.Celular = txtCelular.Text
        End If
        entContacto.TipoContactoId = 1
        entContacto.OrigenId = cbCliente.SelectedValue
        entContacto.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "Inactivo") Then
            entContacto.IdEstadoActivo = 0
        Else
            entContacto.IdEstadoActivo = 1
        End If

        operacion = negContacto.Actualizar(entContacto)

        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Contacto")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Contacto")
        End If
    End Sub
    Private Sub EliminarContacto()
        If dgvContacto.Rows.Count > 0 Then
            entContacto.IdContacto = CInt(dgvContacto.CurrentRow.Cells("IdContacto").Value)
            entContacto.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            operacion = negContacto.Eliminar(entContacto)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Contacto")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Contacto")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        cbClienteFiltro.SelectedValue = ClienteId
        ModoInicial()
    End Sub

    Private Sub FormContacto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerContacto()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarContacto()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdContacto.Text = "0" Then
            CrearContacto()
        Else
            ActualizarContacto()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerContacto()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarContacto()
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbClienteFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClienteFiltro.SelectedIndexChanged
        If cbClienteFiltro.SelectedValue = 0 Then
            cbCliente.Enabled = True
        Else
            cbCliente.Enabled = False
        End If
        If cbClienteFiltro.SelectedValue <> Nothing Then
            cbCliente.SelectedValue = cbClienteFiltro.SelectedValue
            CargarTabla()
        End If
    End Sub
#End Region
End Class