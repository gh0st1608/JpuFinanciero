Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormProveedor
#Region "Variables"
    Dim negProveedor As New NegProveedor
    Dim entProveedor As New EntProveedor
    Dim negParametro As New NegParametro
    Dim entParametro As New EntParametro
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
    Dim dataTableTipoCliente As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 300
        txtIdProveedor.Text = "0"
        txtNombreComercial.Text = ""
        txtRazonSocial.Text = ""
        txtNumeroContacto.Text = ""
        cboEstado.Visible = False
        lbEstado.Visible = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvProveedor.Enabled = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 445
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvProveedor.Enabled = False
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarCombo()
        cboMedicion.ValueMember = "IdParametro"
        cboMedicion.DisplayMember = "Descripcion"
        cboMedicion.DataSource = negParametro.ObtenerLista("MEDICION", False, True)
    End Sub

    Private Sub CargarTabla()
        dataTable = negProveedor.ObtenerTabla()
        dgvProveedor.DataSource = dataTable
        If dgvProveedor.Rows.Count > 0 Then
            dgvProveedor.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearProveedor()
        If txtDocumento.Text = "" Then
            MsgBox("Ingresar RUC")
            Exit Sub
        Else
            entProveedor.Documento = txtDocumento.Text
        End If
        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon Social")
            Exit Sub
        Else
            entProveedor.RazonSocial = txtRazonSocial.Text
        End If
        entProveedor.NombreComercial = txtNombreComercial.Text
        entProveedor.NumeroContacto = txtNumeroContacto.Text
        entProveedor.Correo = txtCorreo.Text
        entProveedor.MedicionId = cboMedicion.SelectedValue
        entProveedor.Tarifa = txtTarifa.Text

        entProveedor.UsuarioCreacionId = VariableGlobal.VGIDUsuario
        operacion = negProveedor.Guardar(entProveedor)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Proveedor")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Proveedor")
        End If
    End Sub
    Private Sub LeerProveedor()
        entProveedor = negProveedor.ObtenerData(dgvProveedor.CurrentRow.Cells("IdProveedor").Value)
        txtIdProveedor.Text = entProveedor.IdProveedor
        txtDocumento.Text = entProveedor.Documento
        txtNombreComercial.Text = entProveedor.NombreComercial
        txtRazonSocial.Text = entProveedor.RazonSocial
        txtNumeroContacto.Text = entProveedor.NumeroContacto
        txtCorreo.Text = entProveedor.Correo
        cboMedicion.SelectedValue = entProveedor.MedicionId
        txtTarifa.Text = entProveedor.Tarifa
        If (entProveedor.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lbEstado.Visible = True
            cboMedicion.Enabled = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarProveedor()
        If txtDocumento.Text = "" Then
            MsgBox("Ingresar RUC")
            Exit Sub
        Else
            entProveedor.Documento = txtDocumento.Text
        End If
        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon Social")
            Exit Sub
        Else
            entProveedor.RazonSocial = txtRazonSocial.Text
        End If
        entProveedor.NombreComercial = txtNombreComercial.Text
        entProveedor.NumeroContacto = txtNumeroContacto.Text
        entProveedor.Correo = txtCorreo.Text
        entProveedor.MedicionId = cboMedicion.SelectedValue
        entProveedor.Tarifa = txtTarifa.Text
        entProveedor.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "INACTIVO") Then
            entProveedor.IdEstadoActivo = 0
        Else
            entProveedor.IdEstadoActivo = 1
        End If

        operacion = negProveedor.Actualizar(entProveedor)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Proveedor")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Proveedor")
        End If
    End Sub
    Private Sub EliminarProveedor()
        entProveedor.IdProveedor = Int(dgvProveedor.CurrentRow.Cells("IdProveedor").Value)
        entProveedor.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negProveedor.Eliminar(entProveedor)
        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Proveedor")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Proveedor")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerProveedor()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarProveedor()
            ModoInicial()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdProveedor.Text = "0" Then
            CrearProveedor()
        Else
            ActualizarProveedor()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerProveedor()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarProveedor()
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class