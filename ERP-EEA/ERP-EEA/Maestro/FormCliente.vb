Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormCliente
#Region "Variables"
    Dim negCliente As New NegCliente
    Dim entCliente As New EntCliente
    Dim negTipoCliente As New NegTipoCliente
    Dim entTipoCliente As New EntTipoCliente
    Dim negContacto As New NegContacto
    Dim entContacto As New EntContacto
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
    Dim dataTableTipoCliente As DataTable
#End Region
#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 305
        txtIdCliente.Text = "0"
        txtRazonSocial.Text = ""
        txtDocumento.Text = ""
        txtDescripcion.Text = ""
        txtCorreo.Text = ""
        txtNumeroContacto.Text = ""
        btnNuevo.Enabled = True
        dgvCliente.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cboEstado.Visible = False
        lbEstado.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 520
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvCliente.Enabled = False
    End Sub
#End Region
#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negCliente.ObtenerTabla()
        dgvCliente.DataSource = dataTable
        If dgvCliente.Rows.Count > 0 Then
            dgvCliente.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub
#End Region
#Region "Funciones Principales (CRUD)"
    Private Sub CrearCliente(tipoIngreso As Integer)
        operacion = False
        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon social", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.RazonSocial = txtRazonSocial.Text
        End If
        If txtDocumento.Text = "" Then
            MsgBox("Ingresar Documento", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.Documento = txtDocumento.Text
        End If
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.Descripcion = txtDescripcion.Text
        End If
        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.Correo = txtCorreo.Text
        End If
        If txtNumeroContacto.Text = "" Then
            MsgBox("Ingresar número contacto", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.NumeroContacto = txtNumeroContacto.Text
        End If
        entCliente.MetaEmpresa = 0
        entCliente.MetaEntidad = 0
        entCliente.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        dataTable = negCliente.Guardar(entCliente)

        If dataTable.Rows.Count > 0 Then
            ClienteId = Convert.ToInt32(dataTable.Rows(0).Item("IdCliente"))
            If tipoIngreso = 0 Then
                MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Cliente")
                operacion = True
            End If
        Else
            operacion = False
            ClienteId = 0
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Cliente")
        End If
    End Sub
    Private Sub LeerCliente() 'Item
        entCliente = negCliente.ObtenerData(dgvCliente.CurrentRow.Cells("IdCliente").Value)

        txtIdCliente.Text = entCliente.IdCliente
        txtRazonSocial.Text = entCliente.RazonSocial
        txtDocumento.Text = entCliente.Documento
        txtDescripcion.Text = entCliente.Descripcion
        txtCorreo.Text = entCliente.Correo
        txtNumeroContacto.Text = entCliente.NumeroContacto

        dataTable = negContacto.ObtenerTabla(1, entCliente.IdCliente)
        dgvContacto.DataSource = dataTable
        If (entCliente.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lbEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarCliente(tipoIngreso As Integer)
        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon social", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.RazonSocial = txtRazonSocial.Text
        End If
        If txtDocumento.Text = "" Then
            MsgBox("Ingresar Documento", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.Documento = txtDocumento.Text
        End If
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.Descripcion = txtDescripcion.Text
        End If
        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.Correo = txtCorreo.Text
        End If
        If txtNumeroContacto.Text = "" Then
            MsgBox("Ingresar número contacto", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entCliente.NumeroContacto = txtNumeroContacto.Text
        End If
        entCliente.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "INACTIVO") Then
            entCliente.IdEstadoActivo = 0
        Else
            entCliente.IdEstadoActivo = 1
        End If

        operacion = negCliente.Actualizar(entCliente)
        If operacion Then
            ClienteId = entCliente.IdCliente
            If tipoIngreso = 0 Then
                MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Cliente")
            End If
        Else
            ClienteId = 0
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Cliente")
        End If
    End Sub
    Private Sub EliminarCliente()
        entCliente.IdCliente = Int(dgvCliente.CurrentRow.Cells("IdCliente").Value)
        entCliente.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negCliente.Eliminar(entCliente)
        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Cliente")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Cliente")
        End If
    End Sub
#End Region
#Region "Funciones del formulario"
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTabla()
        ModoInicial()
    End Sub

    Private Sub FormCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerCliente()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarCliente()
            ModoInicial()
        End If
    End Sub
#End Region
#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdCliente.Text = "0" Then
            CrearCliente(0)
        Else
            ActualizarCliente(0)
        End If
        ModoInicial()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerCliente()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarCliente()
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub btnContacto_Click(sender As Object, e As EventArgs) Handles btnContacto.Click
        If txtIdCliente.Text = "0" Then
            CrearCliente(1)
        Else
            ActualizarCliente(1)
        End If
        If ClienteId > 0 And operacion Then
            FormContacto.Show()
            Me.Close()
        End If
    End Sub
#End Region
End Class