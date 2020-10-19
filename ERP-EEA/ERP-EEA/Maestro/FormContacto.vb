Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormContacto
#Region "Variables"

    Dim negContacto As New NegContacto
    Dim entContacto As New EntContacto
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
    Dim dataTableTipoContacto As DataTable
    Dim varTipoContactoId As Integer
    Dim varOrigenId As Integer

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial(ByVal TipoContactoId As Integer, ByVal OrigenId As Integer)
        Me.Height = 197
        txtIdContacto.Text = TipoContactoId
        txtCargo.Text = ""
        txtCelular.Text = ""
        txtCorreo.Text = ""
        txtNombre.Text = ""
        cbCliente.SelectedValue = OrigenId
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        cboEstado.Visible = False
        lblEstado.Visible = False
        CargarTabla(TipoContactoId, OrigenId)
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 338
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub


#End Region

#Region "Funciones Auxiliares"

    Private Sub CargarTabla(ByVal TipoContactoId As Integer, ByVal OrigenId As Integer)
        dataTable = negContacto.ObtenerTabla(TipoContactoId, OrigenId) 'Puedo enviarte filtros si no fueran maestros
        dgvContacto.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearContacto()
        If txtNombre.Text = "" Then
            MsgBox("Ingresar nombre")
            Exit Sub
        Else
            entContacto.NombreCompleto = txtNombre.Text
        End If

        If txtCargo.Text = "" Then
            MsgBox("Ingresar cargo")
            Exit Sub
        Else
            entContacto.Cargo = txtCargo.Text
        End If

        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo")
            Exit Sub
        Else
            entContacto.Correo = txtCorreo.Text
        End If

        If txtCelular.Text = "" Then
            MsgBox("Ingresar celular")
            Exit Sub
        Else
            entContacto.Celular = txtCelular.Text
        End If

        entContacto.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negContacto.Guardar(entContacto)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial(varTipoContactoId, varOrigenId)
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerContacto() 'Item
        entContacto = negContacto.ObtenerData(dgvContacto.CurrentRow.Cells("IdContacto").Value, 1, 0)

        txtIdContacto.Text = entContacto.IdContacto
        txtNombre.Text = entContacto.NombreCompleto
        txtCargo.Text = entContacto.Cargo
        txtCelular.Text = entContacto.Celular
        txtCorreo.Text = entContacto.Correo

        If (entContacto.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lblEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarContacto()

        If txtNombre.Text = "" Then
            MsgBox("Ingresar nombre")
            Exit Sub
        Else
            entContacto.NombreCompleto = txtNombre.Text
        End If

        If txtCargo.Text = "" Then
            MsgBox("Ingresar cargo")
            Exit Sub
        Else
            entContacto.Cargo = txtCargo.Text
        End If

        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo")
            Exit Sub
        Else
            entContacto.Correo = txtCorreo.Text
        End If

        If txtCelular.Text = "" Then
            MsgBox("Ingresar celular")
            Exit Sub
        Else
            entContacto.Celular = txtCelular.Text
        End If

        entContacto.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entContacto.IdEstadoActivo = 1
        Else
            entContacto.IdEstadoActivo = 0
        End If

        operacion = negContacto.Actualizar(entContacto)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial(varTipoContactoId, varOrigenId)
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarContacto()
        entContacto.IdContacto = CInt(dgvContacto.CurrentRow.Cells("IdContacto").Value)
        entContacto.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negContacto.Eliminar(entContacto)

        If operacion Then
            MsgBox("Guardo con exito")
            CargarTabla(varTipoContactoId, varOrigenId)
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varOrigenId = Prueba.OrigenId
        varTipoContactoId = Prueba.TipoContactoId
        ModoInicial(varTipoContactoId, varOrigenId)
    End Sub

    Private Sub FormContacto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerContacto()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarContacto()
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
        ModoInicial(varTipoContactoId, varOrigenId)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial(varTipoContactoId, varOrigenId)
    End Sub

#End Region
End Class