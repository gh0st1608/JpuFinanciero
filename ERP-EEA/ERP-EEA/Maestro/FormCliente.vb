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
        Me.Height = 307
        txtIdCliente.Text = "0"
        txtRazonSocial.Text = ""
        txtDocumento.Text = ""
        txtDescripcion.Text = ""
        txtCorreo.Text = ""
        txtNumeroContacto.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        cboEstado.Visible = False
        lbEstado.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 517
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub


#End Region

#Region "Funciones Auxiliares"

    Private Sub CargarTabla()
        dataTable = negCliente.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvCliente.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearCliente()
        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon social")
            Exit Sub
        Else
            entCliente.RazonSocial = txtRazonSocial.Text
        End If

        If txtDocumento.Text = "" Then
            MsgBox("Ingresar Documento")
            Exit Sub
        Else
            entCliente.Documento = txtDocumento.Text
        End If

        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entCliente.Descripcion = txtDescripcion.Text
        End If

        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo")
            Exit Sub
        Else
            entCliente.Correo = txtCorreo.Text
        End If

        If txtNumeroContacto.Text = "" Then
            MsgBox("Ingresar número contacto")
            Exit Sub
        Else
            entCliente.NumeroContacto = txtNumeroContacto.Text
        End If



        entCliente.UsuarioCreacionId = 1

        operacion = negCliente.Guardar(entCliente)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
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

        dataTable = negContacto.ObtenerTabla(1, entCliente.IdCliente) 'Puedo enviarte filtros si no fueran maestros
        dgvContacto.DataSource = dataTable
        If (entCliente.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lbEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarCliente()

        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon social")
            Exit Sub
        Else
            entCliente.RazonSocial = txtRazonSocial.Text
        End If

        If txtDocumento.Text = "" Then
            MsgBox("Ingresar Documento")
            Exit Sub
        Else
            entCliente.Documento = txtDocumento.Text
        End If

        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entCliente.Descripcion = txtDescripcion.Text
        End If

        If txtCorreo.Text = "" Then
            MsgBox("Ingresar correo")
            Exit Sub
        Else
            entCliente.Correo = txtCorreo.Text
        End If

        If txtNumeroContacto.Text = "" Then
            MsgBox("Ingresar número contacto")
            Exit Sub
        Else
            entCliente.NumeroContacto = txtNumeroContacto.Text
        End If

        entCliente.UsuarioModificacionId = 1

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entCliente.IdEstadoActivo = 1
        Else
            entCliente.IdEstadoActivo = 0
        End If

        operacion = negCliente.Actualizar(entCliente)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarCliente()
        entCliente.IdCliente = Int(dgvCliente.CurrentRow.Cells("IdCliente").Value)
        entCliente.UsuarioModificacionId = 1

        operacion = negCliente.Eliminar(entCliente)

        If operacion Then
            MsgBox("Elimino con exito")
            CargarTabla()
        Else
            MsgBox("No Elimino bien")
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
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdCliente.Text = "0" Then
            CrearCliente()
        Else
            ActualizarCliente()
        End If
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
        Prueba.OrigenId = entCliente.IdCliente
        Prueba.TipoContactoId = 1
        FormContacto.Show()
    End Sub

#End Region
End Class