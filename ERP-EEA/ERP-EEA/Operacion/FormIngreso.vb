Imports System.IO
Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormIngreso
#Region "Variables"
    Dim negIngreso As New NegIngreso
    Dim entIngreso As New EntIngreso
    Dim entGrupoIngreso As New EntGrupoIngreso
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim operacion As Boolean = False
    Dim negCliente As New NegCliente
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim negPago As New NegPago
    Dim entPago As New EntPago
    Dim negParametro As New NegParametro
    Dim entParametro As New EntParametro
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim cantIngresos As Integer
    Dim cantPagos As Integer
    Dim blnActualizar As Boolean = False
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        CargarTablaIngreso()
        dgvIngreso.Enabled = True
        Me.Height = 273
        txtIdIngreso.Text = "0"
        txtComentario.Text = ""
        txtNumeroComprobanteIngreso.Text = ""
        txtImporteProvisional.Text = ""
        cbCliente.SelectedValue = 0
        cbPeriodo.SelectedValue = 0
        chkDetraccion.Checked = False
        chkIGV.Checked = False
        btnNuevo.Enabled = True
        If cantIngresos = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnPagar.Enabled = False
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnPagar.Enabled = True
        End If
        dgvIngreso.Enabled = True
        PanelIngreso.Visible = True
        PanelPago.Visible = False

    End Sub

    Private Sub ModoRegistro()
        Me.Height = 460
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        dgvIngreso.Enabled = False
        PanelIngreso.Visible = True
        PanelPago.Visible = False
    End Sub

    Private Sub ModoPago()
        CargarTablaPago()
        dgvIngreso.Enabled = False
        Me.Height = 450
        txtIdPago.Text = "0"
        txtTotal.Text = ""
        txtNumeroComprobante.Text = "0"
        txtComprobanteUbicacion.Text = ""
        txtRespaldoImporte.Text = ""
        'txtSubTotal.Text = "0"
        cbMetodoPago.SelectedValue = 0
        btnNuevo.Enabled = False
        If cantPagos = 0 Then
            btnModificarPago.Enabled = False
            btnEliminarPago.Enabled = False
        Else
            btnModificarPago.Enabled = True
            btnEliminarPago.Enabled = True
            btnNuevoPago.Enabled = True
        End If
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        btnVolver.Enabled = True
        dgvPago.Enabled = True
        PanelIngreso.Visible = False
        PanelPago.Visible = True
    End Sub

    Private Sub ModoRegistrarPago()
        Me.Height = 605
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnModificarPago.Enabled = False
        btnEliminarPago.Enabled = False
        btnVolver.Enabled = False
        dgvPago.Enabled = False
        txtDetraccion.Enabled = False
        txtIGV.Enabled = False
        txtSubTotal.Enabled = True
        txtTotal.Enabled = False
        PanelIngreso.Visible = False
        PanelPago.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaIngreso()
        dataTable = negIngreso.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, 0, 1)
        dgvIngreso.DataSource = dataTable
        cantIngresos = dgvIngreso.Rows.Count
    End Sub

    Private Sub CargarTablaPago()
        dataTable = negPago.ObtenerTabla(0, 1, Int(txtIdIngreso.Text), cbPeriodoFiltro.SelectedValue, 0, 0)
        dgvPago.DataSource = dataTable
        cantPagos = dgvPago.Rows.Count
    End Sub

    Private Sub CargarCombo()
        cboTipoIngreso.ValueMember = "IdGrupoIngreso"
        cboTipoIngreso.DisplayMember = "Descripcion"
        cboTipoIngreso.DataSource = negGrupoIngreso.ObtenerLista(False, True)

        cbCliente.ValueMember = "IdCliente"
        cbCliente.DisplayMember = "Descripcion"
        cbCliente.DataSource = negCliente.ObtenerLista(False, True)

        cbPeriodo.ValueMember = "IdPeriodo"
        cbPeriodo.DisplayMember = "DescripcionPeriodo"
        cbPeriodo.DataSource = negPeriodo.ObtenerLista(False, True)

        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)

        cbMetodoPago.ValueMember = "IdMetodoPago"
        cbMetodoPago.DisplayMember = "Descripcion"
        cbMetodoPago.DataSource = negMetodoPago.ObtenerLista(False, True)
    End Sub


    Private Sub CalculoImpuestos()
        If IsNumeric(txtSubTotal.Text) Then
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text)
        Else
            entPago.ImporteCancelado = 0
        End If

        If entIngreso.IGV Then
            entParametro = negParametro.ObtenerData(2)
            entPago.ImporteIGV = entPago.ImporteCancelado * entParametro.ValorParametro
            txtIGV.Text = entPago.ImporteIGV.ToString(“##,##0.00”)
            'entIngreso.IGV = entPago.
        End If

        If entIngreso.Detraccion Then
            entParametro = negParametro.ObtenerData(1)
            entPago.ImporteDetraccion = (entPago.ImporteCancelado + entPago.ImporteIGV) * entParametro.ValorParametro
            txtDetraccion.Text = entPago.ImporteDetraccion.ToString(“##,##0.00”)
        End If

        entPago.ImporteTotal = (entPago.ImporteIGV + entPago.ImporteCancelado - entPago.ImporteDetraccion).ToString(“##,##0.00”)
        txtTotal.Text = entPago.ImporteTotal.ToString(“##,##0.00”)
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    'INGRESO
    Private Sub CrearIngreso()
        If cboTipoIngreso.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Ingresos")
            Exit Sub
        Else
            entIngreso.GrupoIngresoId = cboTipoIngreso.SelectedValue
        End If

        If cbCliente.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entIngreso.ClienteId = cbCliente.SelectedValue
        End If
        entIngreso.Comentario = txtComentario.Text
        entIngreso.Detraccion = chkDetraccion.Checked
        entIngreso.IGV = chkIGV.Checked
        If cbPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entIngreso.PeriodoId = cbPeriodo.SelectedValue
        End If
        entIngreso.FechaIngresoProvision = dtpFechaIngreso.Value
        entIngreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entIngreso.NumeroComprobanteIngreso = txtNumeroComprobanteIngreso.Text
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entIngreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text, New CultureInfo("en-US"))
        End If
        entIngreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        entIngreso.Deuda = entIngreso.ImporteProvision

        operacion = negIngreso.Guardar(entIngreso)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerIngreso()

        entIngreso = negIngreso.ObtenerData(dgvIngreso.CurrentRow.Cells("IdIngreso").Value)
        txtIdIngreso.Text = entIngreso.IdIngreso
        cbCliente.SelectedValue = entIngreso.ClienteId
        txtComentario.Text = entIngreso.Comentario
        chkDetraccion.Checked = entIngreso.Detraccion
        chkIGV.Checked = entIngreso.IGV
        cbPeriodo.SelectedValue = entIngreso.PeriodoId
        dtpFechaIngreso.Value = entIngreso.FechaIngresoProvision
        txtComprobanteUbicacion.Text = entIngreso.ComprobanteUbicacion
        txtNumeroComprobanteIngreso.Text = entIngreso.NumeroComprobanteIngreso
        txtImporteProvisional.Text = entIngreso.ImporteProvision.ToString(“##,##0.00”)

        txtSubTotal.Text = entIngreso.Deuda.ToString(“##,##0.00”)
        txtTotal.Text = (Convert.ToDecimal(txtIGV.Text) + Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtDetraccion.Text)).ToString(“##,##0.00”)



        If entIngreso.ImporteProvision = 0 Then 'Modifique entIngreso.ImporteProvision = ""
            btnAbrir.Enabled = False
        Else
            btnAbrir.Enabled = True
        End If
    End Sub
    Private Sub ActualizarIngreso(ByVal bln As Boolean)
        If cbCliente.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entIngreso.ClienteId = cbCliente.SelectedValue
        End If
        entIngreso.Comentario = txtComentario.Text
        entIngreso.Detraccion = chkDetraccion.Checked
        entIngreso.IGV = chkIGV.Checked
        If cbPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entIngreso.PeriodoId = cbPeriodo.SelectedValue
        End If
        entIngreso.FechaIngresoProvision = dtpFechaIngreso.Value
        entIngreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entIngreso.NumeroComprobanteIngreso = txtNumeroComprobanteIngreso.Text
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entIngreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text, New CultureInfo("en-US"))
        End If

        entIngreso.Deuda = respaldo

        entIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negIngreso.Actualizar(entIngreso)

        If operacion Then
            If (blnActualizar = False) Then
                MsgBox("Guardo con exito")
                ModoInicial()
            Else
                ModoPago()
            End If

        Else
            MsgBox("No se guardo bien")
        End If
    End Sub
    Private Sub EliminarIngreso()
        entIngreso.IdIngreso = dgvIngreso.CurrentRow.Cells("IdIngreso").Value
        entIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negIngreso.Eliminar(entIngreso)

        If operacion Then
            MsgBox("Elimino con exito")
            ModoInicial()
        Else
            MsgBox("No elimino bien")
        End If
    End Sub

    'PAGO
    Private Sub CrearPago()
        If cbMetodoPago.SelectedValue = 0 Then
            MsgBox("Escoger un método de pago")
            Exit Sub
        Else
            entPago.MetodoPagoId = cbMetodoPago.SelectedValue
        End If

        entPago.NumeroComprobante = txtNumeroComprobante.Text
        entPago.TipoOrigenId = 1
        entPago.OrigenId = Int(txtIdIngreso.Text)
        entPago.FechaPago = dtpFechaPago.Value
        entPago.NroOperacion = txtNroOperacion.Text

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado")
            Exit Sub
        Else
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US")).ToString(“##,##0.00”)
        End If

        entIngreso.Deuda = (entIngreso.Deuda - entPago.ImporteCancelado).ToString(“##,##0.00”)

        respaldo = Convert.ToDecimal(entIngreso.Deuda)

        entIngreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario


        operacion = negPago.Guardar(entPago)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoPago()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerPago()
        entPago = negPago.ObtenerData(dgvPago.CurrentRow.Cells("IdPago").Value, 1)

        txtIdPago.Text = entPago.IdPago
        cbMetodoPago.SelectedValue = entPago.MetodoPagoId
        txtNumeroComprobante.Text = entPago.NumeroComprobante
        dtpFechaPago.Value = entPago.FechaPago
        txtSubTotal.Text = entPago.ImporteCancelado.ToString(“##,##0.00”)
        txtTotal.Text = (entPago.ImporteIGV + entPago.ImporteCancelado - entPago.ImporteDetraccion).ToString(“##,##0.00”)



        txtRespaldoImporte.Text = (entPago.ImporteCancelado + entIngreso.Deuda).ToString(“##,##0.00”)

    End Sub
    Private Sub ActualizarPago()
        If cbMetodoPago.SelectedValue = 0 Then
            MsgBox("Escoger un método de pago")
            Exit Sub
        Else
            entPago.MetodoPagoId = cbMetodoPago.SelectedValue
        End If
        entPago.NumeroComprobante = txtNumeroComprobante.Text


        entPago.FechaPago = dtpFechaPago.Value
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado")
            Exit Sub
        Else
            entPago.ImporteCancelado = txtSubTotal.Text
        End If


        If entIngreso.IGV Then
            entParametro = negParametro.ObtenerData(2)
            entPago.ImporteIGV = entPago.ImporteCancelado * entParametro.ValorParametro
            txtIGV.Text = entPago.ImporteIGV
        End If

        If entIngreso.Detraccion Then
            entParametro = negParametro.ObtenerData(1)
            entPago.ImporteDetraccion = entPago.ImporteIGV * entParametro.ValorParametro
            txtDetraccion.Text = entPago.ImporteDetraccion
        End If

        If entIngreso.IGV Then
            entPago.ImporteTotal = entPago.ImporteCancelado + entPago.ImporteIGV
            If entIngreso.Detraccion Then
                entPago.ImporteTotal = (entPago.ImporteIGV + entPago.ImporteCancelado - entPago.ImporteDetraccion)
            End If
        Else
            entPago.ImporteTotal = entPago.ImporteCancelado
        End If
        entPago.ImporteTotal = entPago.ImporteCancelado

        entPago.NroOperacion = txtNroOperacion.Text
        respaldo = entIngreso.Deuda - entPago.ImporteCancelado

        entPago.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negPago.Actualizar(entPago)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoPago()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarPago()
        entPago.IdPago = dgvPago.CurrentRow.Cells("IdPago").Value
        entPago.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negPago.Eliminar(entPago)

        If operacion Then
            MsgBox("Elimino con exito")
            ModoPago()
        Else
            MsgBox("No elimino bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerIngreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarIngreso()
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdIngreso.Text = "0" Then
            CrearIngreso()
        Else
            ActualizarIngreso(blnActualizar)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerIngreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarIngreso()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub btnNuevoPago_Click(sender As Object, e As EventArgs) Handles btnNuevoPago.Click
        LeerIngreso()
        ModoRegistrarPago()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModoInicial()
    End Sub

    Private Sub btnCancelarPago_Click(sender As Object, e As EventArgs) Handles btnCancelarPago.Click
        ModoPago()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        LeerIngreso()
        ModoPago()
    End Sub

    Private Sub btnModificarPago_Click(sender As Object, e As EventArgs) Handles btnModificarPago.Click
        LeerPago()
        ModoRegistrarPago()
    End Sub

    Private Sub btnEliminarPago_Click(sender As Object, e As EventArgs) Handles btnEliminarPago.Click
        EliminarPago()
    End Sub

    Private Sub btnGuardarPago_Click(sender As Object, e As EventArgs) Handles btnGuardarPago.Click
        blnActualizar = True
        If txtIdPago.Text = "0" Then
            CrearPago()
        Else
            ActualizarPago()
        End If
        ActualizarIngreso(blnActualizar)
    End Sub

    Private Sub btnAdjuntarArchivo_Click(sender As Object, e As EventArgs) Handles btnAdjuntarArchivo.Click
        Dim Abrir As New OpenFileDialog()
        Abrir.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If (Abrir.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            txtComprobanteUbicacion.Text = Abrir.FileName
            btnAbrir.Enabled = True
        End If
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = entIngreso.ComprobanteUbicacion 'validar 
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged
        CalculoImpuestos()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaIngreso()
    End Sub


#End Region
End Class