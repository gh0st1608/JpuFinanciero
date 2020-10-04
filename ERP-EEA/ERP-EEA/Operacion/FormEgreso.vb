Imports System.IO
Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormEgreso

#Region "Variables"

    Dim negEgreso As New NegEgreso
    Dim entEgreso As New EntEgreso
    Dim entGrupoEgreso As New EntGrupoEgreso
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim entSubGrupoEgreso As New EntSubGrupoEgreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim operacion As Boolean = False
    Dim negProveedor As New NegProveedor
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim negPago As New NegPago
    Dim entPago As New EntPago
    Dim negParametro As New NegParametro
    Dim entParametro As New EntParametro
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim cantEgresos As Integer
    Dim cantPagos As Integer
    Dim blnActualizar As Boolean = False
    Dim vg As New VariableGlobal

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        CargarTablaEgreso()
        dgvEgreso.Enabled = True
        Me.Height = 273
        txtIdEgreso.Text = "0"
        txtComentario.Text = ""
        txtNumeroComprobanteEgreso.Text = ""
        txtImporteProvisional.Text = ""
        cboGrupoEgreso.SelectedValue = 0
        cboSubGrupoEgreso.SelectedValue = 0
        cboProveedor.SelectedValue = 0
        cboPeriodo.SelectedValue = 0
        'chkDetraccion.Checked = False
        chkIGV.Checked = False
        btnNuevo.Enabled = True
        If cantEgresos = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnPagar.Enabled = False
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnPagar.Enabled = True
        End If
        dgvEgreso.Enabled = True
        PanelEgreso.Visible = True
        PanelPago.Visible = False

    End Sub

    Private Sub ModoRegistro()
        Me.Height = 460
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        dgvEgreso.Enabled = False
        PanelEgreso.Visible = True
        PanelPago.Visible = False
    End Sub

    Private Sub ModoPago()
        CargarTablaPago()
        dgvEgreso.Enabled = False
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
        PanelEgreso.Visible = False
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
        'txtDetraccion.Enabled = False
        txtIGV.Enabled = False
        txtSubTotal.Enabled = True
        txtTotal.Enabled = False
        PanelEgreso.Visible = False
        PanelPago.Visible = True
    End Sub
#End Region


#Region "Funciones Auxiliares"
    Private Sub CargarTablaEgreso()
        dataTable = negEgreso.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, 0)
        dgvEgreso.DataSource = dataTable
        cantEgresos = dgvEgreso.Rows.Count
    End Sub

    Private Sub CargarTablaPago()
        dataTable = negPago.ObtenerTabla(0, 1, Int(txtIdEgreso.Text), cbPeriodoFiltro.SelectedValue, 0, 0)
        dgvPago.DataSource = dataTable
        cantPagos = dgvPago.Rows.Count
    End Sub

    Private Sub CargarCombo()

        cboGrupoEgreso.ValueMember = "IdGrupoEgreso"
        cboGrupoEgreso.DisplayMember = "Descripcion"
        cboGrupoEgreso.DataSource = negGrupoEgreso.ObtenerLista(False, True)

        cboProveedor.ValueMember = "IdProveedor"
        cboProveedor.DisplayMember = "NombreComercial"
        cboProveedor.DataSource = negProveedor.ObtenerLista(False, True)

        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True)

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

        If entEgreso.IGV Then
            entParametro = negParametro.ObtenerData(2)
            entPago.ImporteIGV = entPago.ImporteCancelado * entParametro.ValorParametro
            txtIGV.Text = entPago.ImporteIGV.ToString(“##,##0.00”)
            'entIngreso.IGV = entPago.
        End If

        'If entEgreso.Detraccion Then
        'entParametro = negParametro.ObtenerData(1)
        'entPago.ImporteDetraccion = (entPago.ImporteCancelado + entPago.ImporteIGV) * entParametro.ValorParametro
        'txtDetraccion.Text = entPago.ImporteDetraccion.ToString(“##,##0.00”)
        'End If

        entPago.ImporteTotal = (entPago.ImporteIGV + entPago.ImporteCancelado - entPago.ImporteDetraccion).ToString(“##,##0.00”)
        txtTotal.Text = entPago.ImporteTotal.ToString(“##,##0.00”)
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    'INGRESO
    Private Sub CrearEgreso()
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Grupo de Egreso")
            Exit Sub
        Else
            entEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If

        If cboSubGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Item de Egreso")
            Exit Sub
        Else
            entEgreso.SubGrupoEgresoId = cboSubGrupoEgreso.SelectedValue
        End If

        If cboProveedor.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entEgreso.ProveedorId = cboProveedor.SelectedValue
        End If
        entEgreso.Comentario = txtComentario.Text
        'entEgreso.Detraccion = chkDetraccion.Checked
        entEgreso.IGV = chkIGV.Checked
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entEgreso.PeriodoId = cboPeriodo.SelectedValue
        End If
        entEgreso.FechaEgresoProvision = dtpFechaIngreso.Value
        entEgreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entEgreso.NumeroComprobanteEgreso = txtNumeroComprobanteEgreso.Text
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entEgreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text, New CultureInfo("en-US"))
        End If
        entEgreso.UsuarioCreacionId = 1

        entEgreso.Deuda = entEgreso.ImporteProvision

        operacion = negEgreso.Guardar(entEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerEgreso()

        entEgreso = negEgreso.ObtenerData(dgvEgreso.CurrentRow.Cells("IdEgreso").Value)
        cboGrupoEgreso.SelectedValue = entEgreso.GrupoEgresoId
        cboSubGrupoEgreso.SelectedValue = entEgreso.SubGrupoEgresoId
        txtIdEgreso.Text = entEgreso.IdEgreso
        cboProveedor.SelectedValue = entEgreso.ProveedorId
        txtComentario.Text = entEgreso.Comentario
        'chkDetraccion.Checked = entEgreso.Detraccion
        chkIGV.Checked = entEgreso.IGV
        cboPeriodo.SelectedValue = entEgreso.PeriodoId
        dtpFechaIngreso.Value = entEgreso.FechaEgresoProvision
        txtComprobanteUbicacion.Text = entEgreso.ComprobanteUbicacion
        txtNumeroComprobanteEgreso.Text = entEgreso.NumeroComprobanteEgreso
        txtImporteProvisional.Text = entEgreso.ImporteProvision.ToString(“##,##0.00”)

        txtSubTotal.Text = entEgreso.Deuda.ToString(“##,##0.00”)
        txtTotal.Text = (Convert.ToDecimal(txtIGV.Text) + Convert.ToDecimal(txtSubTotal.Text)).ToString(“##,##0.00”)



        If entEgreso.ImporteProvision = 0 Then 'Modifique entIngreso.ImporteProvision = ""
            btnAbrir.Enabled = False
        Else
            btnAbrir.Enabled = True
        End If
    End Sub
    Private Sub ActualizarEgreso(ByVal bln As Boolean)
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Tipo Egreso")
            Exit Sub
        Else
            entEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If

        If cboSubGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Item de Egreso")
            Exit Sub
        Else
            entEgreso.SubGrupoEgresoId = cboSubGrupoEgreso.SelectedValue
        End If

        If cboProveedor.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entEgreso.ProveedorId = cboProveedor.SelectedValue
        End If
        entEgreso.Comentario = txtComentario.Text
        'entEgreso.Detraccion = chkDetraccion.Checked
        entEgreso.IGV = chkIGV.Checked
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entEgreso.PeriodoId = cboPeriodo.SelectedValue
        End If
        entEgreso.FechaEgresoProvision = dtpFechaIngreso.Value
        entEgreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entEgreso.NumeroComprobanteEgreso = txtNumeroComprobanteEgreso.Text
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entEgreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text, New CultureInfo("en-US"))
        End If

        entEgreso.Deuda = respaldo

        entEgreso.UsuarioModificacionId = 1

        operacion = negEgreso.Actualizar(entEgreso)

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
    Private Sub EliminarEgreso()
        entEgreso.IdEgreso = dgvEgreso.CurrentRow.Cells("IdEgreso").Value
        entEgreso.UsuarioModificacionId = 1
        operacion = negEgreso.Eliminar(entEgreso)

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
        entPago.OrigenId = Int(txtIdEgreso.Text)
        entPago.FechaPago = dtpFechaPago.Value
        entPago.NroOperacion = txtNroOperacion.Text

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado")
            Exit Sub
        Else
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US")).ToString(“##,##0.00”)
        End If

        entEgreso.Deuda = (entEgreso.Deuda - entPago.ImporteCancelado).ToString(“##,##0.00”)

        respaldo = Convert.ToDecimal(entEgreso.Deuda)

        entEgreso.UsuarioCreacionId = 1


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



        txtRespaldoImporte.Text = (entPago.ImporteCancelado + entEgreso.Deuda).ToString(“##,##0.00”)

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


        If entEgreso.IGV Then
            entParametro = negParametro.ObtenerData(2)
            entPago.ImporteIGV = entPago.ImporteCancelado * entParametro.ValorParametro
            txtIGV.Text = entPago.ImporteIGV
        End If


        If entEgreso.IGV Then
            entPago.ImporteTotal = entPago.ImporteCancelado + entPago.ImporteIGV
            'If entEgreso.Detraccion Then
            'entPago.ImporteTotal = (entPago.ImporteIGV + entPago.ImporteCancelado - entPago.ImporteDetraccion)
            'End If
        Else
            entPago.ImporteTotal = entPago.ImporteCancelado
        End If
        entPago.ImporteTotal = entPago.ImporteCancelado

        entPago.NroOperacion = txtNroOperacion.Text
        respaldo = entEgreso.Deuda - entPago.ImporteCancelado

        entPago.UsuarioModificacionId = 1

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
        entPago.UsuarioModificacionId = 1
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
            LeerEgreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarEgreso()
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdEgreso.Text = "0" Then
            CrearEgreso()
        Else
            ActualizarEgreso(blnActualizar)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerEgreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarEgreso()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub btnNuevoPago_Click(sender As Object, e As EventArgs) Handles btnNuevoPago.Click
        LeerEgreso()
        ModoRegistrarPago()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModoInicial()
    End Sub

    Private Sub btnCancelarPago_Click(sender As Object, e As EventArgs) Handles btnCancelarPago.Click
        ModoPago()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        LeerEgreso()
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
        ActualizarEgreso(blnActualizar)
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
        myProcess.StartInfo.FileName = entEgreso.ComprobanteUbicacion 'validar 
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged
        CalculoImpuestos()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaEgreso()
    End Sub

    Private Sub cboGrupoEgreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoEgreso.SelectedIndexChanged



        If cboGrupoEgreso.SelectedValue = 0 Then
            cboSubGrupoEgreso.Enabled = False
        Else
            cboSubGrupoEgreso.Enabled = True
            cboSubGrupoEgreso.ValueMember = "IdSubGrupoEgreso" 'indica propiedades del id del combo de select value
            cboSubGrupoEgreso.DisplayMember = "ItemSubGrupoEgreso" 'indica propiedades de lo que se muestra del combo
            cboSubGrupoEgreso.DataSource = negSubGrupoEgreso.ObtenerLista(False, True, cboGrupoEgreso.SelectedValue)

        End If
    End Sub


#End Region


End Class