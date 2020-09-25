
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
        Me.Height = 307
        txtIdProveedor.Text = "0"
        txtNombreComercial.Text = ""
        txtRazonSocial.Text = ""
        txtNumeroContacto.Text = ""
        cboMedicionId.Visible = False
        cboEstado.Visible = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True

        lbEstado.Visible = False

        CargarCombo()
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 656
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False

    End Sub


#End Region

#Region "Funciones Auxiliares"

    Private Sub CargarCombo()


        cboMedicionId.ValueMember = "IdParametro" 'Lo que yo obtengo con el select value
        cboMedicionId.DisplayMember = "Descripcion" 'Lo que yo no puedo mandar a la bd 
        cboMedicionId.DataSource = negParametro.ObtenerLista(False, True) ' Seleccion

    End Sub

    Private Sub CargarTabla()
        dataTable = negProveedor.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvProveedor.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearProveedor()
        If txtNombreComercial.Text = "" Then
            MsgBox("Ingresar Nombre Comercial")
            Exit Sub
        Else
            entProveedor.NombreComercial = txtNombreComercial.Text
        End If

        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon Social")
            Exit Sub
        Else
            entProveedor.RazonSocial = txtRazonSocial.Text
        End If

        If txtNumeroContacto.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entProveedor.NumeroContacto = txtNumeroContacto.Text
        End If


        cboEstado.Enabled = True
        cboMedicionId.Enabled = True

        entProveedor.UsuarioCreacionId = 1
        entProveedor.MedicionId = cboMedicionId.SelectedValue

        operacion = negProveedor.Guardar(entProveedor)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerProveedor() 'Item
        entProveedor = negProveedor.ObtenerData(dgvProveedor.CurrentRow.Cells("IdProveedor").Value)

        txtIdProveedor.Text = entProveedor.IdProveedor
        txtNombreComercial.Text = entProveedor.NombreComercial
        txtRazonSocial.Text = entProveedor.RazonSocial
        txtNumeroContacto.Text = entProveedor.NumeroContacto
        cboMedicionId.SelectedValue = entProveedor.MedicionId


        If (entProveedor.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lbEstado.Visible = True
            cboMedicionId.Enabled = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarProveedor()

        If txtNombreComercial.Text = "" Then
            MsgBox("Ingresar Nombre Comercial")
            Exit Sub
        Else
            entProveedor.NombreComercial = txtNombreComercial.Text
        End If

        If txtRazonSocial.Text = "" Then
            MsgBox("Ingresar Razon Social")
            Exit Sub
        Else
            entProveedor.RazonSocial = txtRazonSocial.Text
        End If


        If txtNumeroContacto.Text = "" Then
            MsgBox("Ingresar número contacto")
            Exit Sub
        Else
            entProveedor.NumeroContacto = txtNumeroContacto.Text
        End If

        entProveedor.UsuarioModificacionId = 1

        entProveedor.MedicionId = cboMedicionId.SelectedValue
        'entCliente.TipoClienteId = cboTipoCliente.SelectedIndex
        'entCliente.TipoClienteId = cboTipoCliente.ValueMember


        If (cboEstado.SelectedItem = "ACTIVO") Then
            entProveedor.IdEstadoActivo = 1
        Else
            entProveedor.IdEstadoActivo = 0
        End If

        operacion = negProveedor.Actualizar(entProveedor)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarProveedor()
        entProveedor.IdProveedor = Int(dgvProveedor.CurrentRow.Cells("IdProveedor").Value)
        entProveedor.UsuarioModificacionId = 1

        operacion = negProveedor.Eliminar(entProveedor)

        If operacion Then
            MsgBox("Elimino con exito")
        Else
            MsgBox("No Elimino bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ModoInicial()
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