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
    Dim entRelacionDebeHaber As New EntRelacionDebeHaber
    Dim negRelacionDebeHaber As New NegRelacionDebeHaber
    Dim entActivo As New EntActivo
    Dim entPasivo As New EntPasivo
    Dim entPatrimonio As New EntPatrimonio
    Dim negActivo As New NegActivo
    Dim negPasivo As New NegPasivo
    Dim negPatrimonio As New NegPatrimonio
    Dim list As New List(Of String)
    Dim respaldoPago As Decimal
    Dim respaldoRegistro As Decimal
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 295
        operacion = False
        respaldoRegistro = 0
        txtIdIngreso.Text = "0"
        txtComentario.Text = ""
        txtNumeroComprobanteIngreso.Text = ""
        txtComprobanteUbicacion.Text = ""
        txtImporteProvisional.Text = ""
        cboTipoIngreso.SelectedValue = 0
        cbCliente.SelectedValue = 0
        cbPeriodo.SelectedValue = 0
        chkDetraccion.Checked = False
        chkIGV.Checked = False
        txtImporteProvisional.Enabled = True
        cbPeriodo.Enabled = True
        btnNuevo.Enabled = True
        PanelIngreso.Visible = False
        PanelPago.Visible = False
        PanelRegistroPago.Visible = False
        CargarTablaIngreso()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 495
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        dgvIngreso.Enabled = False
        PanelIngreso.Visible = True
    End Sub

    Private Sub ModoPago()
        Me.Height = 495
        operacion = False
        respaldoPago = 0
        txtIdPago.Text = "0"
        txtNumeroComprobante.Text = ""
        txtComprobanteUbicacion.Text = ""
        txtRespaldoImporte.Text = ""
        cbMetodoPago.SelectedValue = 0
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        dgvIngreso.Enabled = False
        If entIngreso.Deuda = 0 Then
            btnNuevoPago.Enabled = False
        Else
            btnNuevoPago.Enabled = True
        End If
        btnVolver.Enabled = True
        txtSubTotal.Enabled = True
        PanelIngreso.Visible = False
        PanelPago.Visible = True
        PanelRegistroPago.Visible = False
        CargarTablaPago()
    End Sub

    Private Sub ModoRegistrarPago()
        Me.Height = 650
        btnNuevoPago.Enabled = False
        btnModificarPago.Enabled = False
        btnEliminarPago.Enabled = False
        btnVolver.Enabled = False
        dgvPago.Enabled = False
        PanelRegistroPago.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaIngreso()
        dataTable = negIngreso.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, 0, 1)
        dgvIngreso.DataSource = dataTable
        If dgvIngreso.Rows.Count > 0 Then
            dgvIngreso.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnPagar.Enabled = True
        Else
            dgvIngreso.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnPagar.Enabled = False
        End If
    End Sub

    Private Sub CargarTablaPago()
        dataTable = negPago.ObtenerTabla(0, 1, Int(txtIdIngreso.Text), cbPeriodoFiltro.SelectedValue, 0, 0)
        dgvPago.DataSource = dataTable
        If dgvPago.Rows.Count > 0 Then
            dgvPago.Enabled = True
            btnModificarPago.Enabled = True
            btnEliminarPago.Enabled = True
        Else
            dgvPago.Enabled = False
            btnModificarPago.Enabled = False
            btnEliminarPago.Enabled = False
        End If
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
            txtIGV.Text = "0"
            txtDetraccion.Text = "0"
            txtTotal.Text = "0"
            Exit Sub
        End If
        If entIngreso.IGV Then
            entParametro = negParametro.ObtenerData(2)
            entPago.ImporteIGV = entPago.ImporteCancelado * entParametro.ValorParametro
            txtIGV.Text = entPago.ImporteIGV.ToString(“##,##0.00”)
        Else
            entPago.ImporteIGV = 0
            txtIGV.Text = "0"
        End If
        If entIngreso.Detraccion Then
            entParametro = negParametro.ObtenerData(1)
            entPago.ImporteDetraccion = (entPago.ImporteCancelado + entPago.ImporteIGV) * entParametro.ValorParametro
            txtDetraccion.Text = entPago.ImporteDetraccion.ToString(“##,##0.00”)
        Else
            entPago.ImporteDetraccion = 0
            txtDetraccion.Text = "0"
        End If
        entPago.ImporteTotal = (entPago.ImporteCancelado + entPago.ImporteIGV - entPago.ImporteDetraccion).ToString(“##,##0.00”)
        txtTotal.Text = entPago.ImporteTotal.ToString(“##,##0.00”)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    'INGRESO
    Private Sub CrearIngreso()
        If cboTipoIngreso.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Ingresos", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.GrupoIngresoId = cboTipoIngreso.SelectedValue
        End If
        If cbCliente.SelectedValue = 0 Then
            MsgBox("Escoger un cliente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.ClienteId = cbCliente.SelectedValue
        End If
        entIngreso.Comentario = txtComentario.Text
        entIngreso.Detraccion = chkDetraccion.Checked
        entIngreso.IGV = chkIGV.Checked
        If cbPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.PeriodoId = cbPeriodo.SelectedValue
        End If
        entIngreso.FechaIngresoProvision = dtpFechaIngreso.Value
        entIngreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entIngreso.NumeroComprobanteIngreso = txtNumeroComprobanteIngreso.Text
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text)
            entIngreso.Deuda = entIngreso.ImporteProvision
        End If
        entIngreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        'Cuenta Contable
        entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 1, 1, entIngreso.GrupoIngresoId)
        Select Case entRelacionDebeHaber.GrupoDebeId
            Case 1
                entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                If entActivo.IdActivo = 0 Then
                    entActivo.PeriodoId = entIngreso.PeriodoId
                    entActivo.GrupoActivoId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entIngreso.ImporteProvision
                    Else
                        entActivo.Monto = -1 * entIngreso.ImporteProvision
                    End If
                    operacion = negActivo.Guardar(entActivo)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entIngreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto - entIngreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                End If
            Case 2
                entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                If entPasivo.IdPasivo = 0 Then
                    entPasivo.PeriodoId = entIngreso.PeriodoId
                    entPasivo.GrupoPasivoId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entIngreso.ImporteProvision
                    Else
                        entPasivo.Monto = -1 * entIngreso.ImporteProvision
                    End If
                    operacion = negPasivo.Guardar(entPasivo)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entIngreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto - entIngreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                End If
            Case 3
                entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                If entPatrimonio.IdPatrimonio = 0 Then
                    entPatrimonio.PeriodoId = entIngreso.PeriodoId
                    entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entIngreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = -1 * entIngreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Guardar(entPatrimonio)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entIngreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entIngreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                End If
            Case Else
                operacion = False
        End Select
        If operacion = False Then
            MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Debe")
            Exit Sub
        End If
        Select Case entRelacionDebeHaber.GrupoHaberId
            Case 1
                entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                If entActivo.IdActivo = 0 Then
                    entActivo.PeriodoId = entIngreso.PeriodoId
                    entActivo.GrupoActivoId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entIngreso.ImporteProvision
                    Else
                        entActivo.Monto = -1 * entIngreso.ImporteProvision
                    End If
                    operacion = negActivo.Guardar(entActivo)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entIngreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto - entIngreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                End If
            Case 2
                entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                If entPasivo.IdPasivo = 0 Then
                    entPasivo.PeriodoId = entIngreso.PeriodoId
                    entPasivo.GrupoPasivoId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entIngreso.ImporteProvision
                    Else
                        entPasivo.Monto = -1 * entIngreso.ImporteProvision
                    End If
                    operacion = negPasivo.Guardar(entPasivo)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entIngreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto - entIngreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                End If
            Case 3
                entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                If entPatrimonio.IdPatrimonio = 0 Then
                    entPatrimonio.PeriodoId = entIngreso.PeriodoId
                    entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entIngreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = -1 * entIngreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Guardar(entPatrimonio)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entIngreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entIngreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                End If
            Case Else
                operacion = False
        End Select
        If operacion = False Then
            MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Haber")
            Exit Sub
        End If

        operacion = negIngreso.Guardar(entIngreso)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Ingreso")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Ingreso")
        End If
    End Sub
    Private Sub LeerIngreso()
        If dgvIngreso.Rows.Count > 0 Then
            cbPeriodo.Enabled = False
            entIngreso = negIngreso.ObtenerData(dgvIngreso.CurrentRow.Cells("IdIngreso").Value)
            txtIdIngreso.Text = entIngreso.IdIngreso
            cboTipoIngreso.SelectedValue = entIngreso.GrupoIngresoId
            cbCliente.SelectedValue = entIngreso.ClienteId
            txtComentario.Text = entIngreso.Comentario
            txtComprobanteUbicacion.Text = entIngreso.ComprobanteUbicacion
            txtNumeroComprobanteIngreso.Text = entIngreso.NumeroComprobanteIngreso
            cbPeriodo.SelectedValue = entIngreso.PeriodoId
            dtpFechaIngreso.Value = entIngreso.FechaIngresoProvision
            txtImporteProvisional.Text = entIngreso.ImporteProvision.ToString(“##,##0.00”)
            chkDetraccion.Checked = entIngreso.Detraccion
            chkIGV.Checked = entIngreso.IGV
            txtSubTotal.Text = entIngreso.Deuda.ToString(“##,##0.00”)
            respaldoRegistro = entIngreso.ImporteProvision
            If entIngreso.ImporteProvision <> entIngreso.Deuda Then
                txtImporteProvisional.Enabled = False
            End If
            If txtComprobanteUbicacion.Text = "" Then
                btnAbrir.Enabled = False
            Else
                btnAbrir.Enabled = True
            End If
        End If
    End Sub
    Private Sub ActualizarIngreso(ByVal actualizaPago As Boolean)
        If cboTipoIngreso.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Ingresos", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.GrupoIngresoId = cboTipoIngreso.SelectedValue
        End If
        If cbCliente.SelectedValue = 0 Then
            MsgBox("Escoger un cliente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.ClienteId = cbCliente.SelectedValue
        End If
        entIngreso.Comentario = txtComentario.Text
        entIngreso.Detraccion = chkDetraccion.Checked
        entIngreso.IGV = chkIGV.Checked
        If cbPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.PeriodoId = cbPeriodo.SelectedValue
        End If
        entIngreso.FechaIngresoProvision = dtpFechaIngreso.Value
        entIngreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entIngreso.NumeroComprobanteIngreso = txtNumeroComprobanteIngreso.Text
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entIngreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text)
            If actualizaPago = False Then
                entIngreso.Deuda = entIngreso.ImporteProvision
            End If
        End If
        entIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If actualizaPago = False Then
            'Cuenta Contable
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 1, 1, entIngreso.GrupoIngresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entIngreso.ImporteProvision - respaldoRegistro
                    Else
                        entActivo.Monto = entActivo.Monto - entIngreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entIngreso.ImporteProvision - respaldoRegistro
                    Else
                        entPasivo.Monto = entPasivo.Monto - entIngreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entIngreso.ImporteProvision - respaldoRegistro
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entIngreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Debe")
                Exit Sub
            End If
            Select Case entRelacionDebeHaber.GrupoHaberId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entIngreso.ImporteProvision - respaldoRegistro
                    Else
                        entActivo.Monto = entActivo.Monto - entIngreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entIngreso.ImporteProvision - respaldoRegistro
                    Else
                        entPasivo.Monto = entPasivo.Monto - entIngreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entIngreso.ImporteProvision - respaldoRegistro
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entIngreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear Haber")
                Exit Sub
            End If
        End If

        operacion = negIngreso.Actualizar(entIngreso)
        If operacion Then
            If (actualizaPago = False) Then
                MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Ingreso")
            End If
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Ingreso")
        End If
    End Sub
    Private Sub EliminarIngreso()
        If dgvIngreso.Rows.Count > 0 Then
            entIngreso = negIngreso.ObtenerData(dgvIngreso.CurrentRow.Cells("IdIngreso").Value)
            If entIngreso.ImporteProvision <> entIngreso.Deuda Then
                MsgBox("Primero de debe eliminar los cobros realizados a este ingreso", MsgBoxStyle.Critical, "Eliminar Ingreso")
                Exit Sub
            End If
            entIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            'Cuenta Contable
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 1, 1, entIngreso.GrupoIngresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto - entIngreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto + entIngreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entIngreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto + entIngreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entIngreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto + entIngreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Debe")
                Exit Sub
            End If
            Select Case entRelacionDebeHaber.GrupoHaberId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto - entIngreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto + entIngreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entIngreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto + entIngreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entIngreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto + entIngreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Haber")
                Exit Sub
            End If

            operacion = negIngreso.Eliminar(entIngreso)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Ingreso")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Ingreso")
            End If
        End If
    End Sub

    'PAGO
    Private Sub CrearPago()
        entPago.OrigenId = CInt(txtIdIngreso.Text)
        entPago.NumeroComprobante = txtNumeroComprobante.Text
        If cbMetodoPago.SelectedValue = 0 Then
            MsgBox("Escoger un método de pago", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPago.MetodoPagoId = cbMetodoPago.SelectedValue
        End If
        entPago.NroOperacion = txtNroOperacion.Text
        entPago.FechaPago = dtpFechaPago.Value
        entPago.TipoOrigenId = 1
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPago.ImporteIGV = Convert.ToDecimal(txtIGV.Text)
        entPago.ImporteDetraccion = Convert.ToDecimal(txtDetraccion.Text)
        entPago.ImporteTotal = Convert.ToDecimal(txtTotal.Text)
        entPago.UsuarioCreacionId = VariableGlobal.VGIDUsuario
        'Actualizar deuda según pago realizado
        entIngreso.Deuda = entIngreso.Deuda - entPago.ImporteCancelado
        entIngreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        'Cuenta Contable
        entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 1, 2, entIngreso.GrupoIngresoId)
        Select Case entRelacionDebeHaber.GrupoDebeId
            Case 1
                entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                If entActivo.IdActivo = 0 Then
                    entActivo.PeriodoId = entIngreso.PeriodoId
                    entActivo.GrupoActivoId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entPago.ImporteTotal
                    Else
                        entActivo.Monto = -1 * entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Guardar(entActivo)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entPago.ImporteTotal
                    Else
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                End If
            Case 2
                entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                If entPasivo.IdPasivo = 0 Then
                    entPasivo.PeriodoId = entIngreso.PeriodoId
                    entPasivo.GrupoPasivoId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPago.ImporteTotal
                    Else
                        entPasivo.Monto = -1 * entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Guardar(entPasivo)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteTotal
                    Else
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                End If
            Case 3
                entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                If entPatrimonio.IdPatrimonio = 0 Then
                    entPatrimonio.PeriodoId = entIngreso.PeriodoId
                    entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPago.ImporteTotal
                    Else
                        entPatrimonio.Monto = -1 * entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Guardar(entPatrimonio)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteTotal
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                End If
            Case Else
                operacion = False
        End Select
        If operacion = False Then
            MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Debe")
            Exit Sub
        End If
        Select Case entRelacionDebeHaber.GrupoHaberId
            Case 1
                entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                If entActivo.IdActivo = 0 Then
                    entActivo.PeriodoId = entIngreso.PeriodoId
                    entActivo.GrupoActivoId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entPago.ImporteTotal
                    Else
                        entActivo.Monto = -1 * entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Guardar(entActivo)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entPago.ImporteTotal
                    Else
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                End If
            Case 2
                entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                If entPasivo.IdPasivo = 0 Then
                    entPasivo.PeriodoId = entIngreso.PeriodoId
                    entPasivo.GrupoPasivoId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPago.ImporteTotal
                    Else
                        entPasivo.Monto = -1 * entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Guardar(entPasivo)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteTotal
                    Else
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                End If
            Case 3
                entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                If entPatrimonio.IdPatrimonio = 0 Then
                    entPatrimonio.PeriodoId = entIngreso.PeriodoId
                    entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPago.ImporteTotal
                    Else
                        entPatrimonio.Monto = -1 * entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Guardar(entPatrimonio)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteTotal
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                End If
            Case Else
                operacion = False
        End Select
        If operacion = False Then
            MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Haber")
            Exit Sub
        End If
        If entIngreso.IGV Then
            entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, 3)
            If entPasivo.IdPasivo = 0 Then
                entPasivo.PeriodoId = entIngreso.PeriodoId
                entPasivo.GrupoPasivoId = 3
                entPasivo.Monto = entPago.ImporteIGV
                operacion = negPasivo.Guardar(entPasivo)
            Else
                entPasivo.Monto = entPasivo.Monto + entPago.ImporteIGV
                operacion = negPasivo.Actualizar(entPasivo)
            End If
        End If
        If entIngreso.Detraccion Then
            entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, 2)
            If entActivo.IdActivo = 0 Then
                entActivo.PeriodoId = entIngreso.PeriodoId
                entActivo.GrupoActivoId = 2
                entActivo.Monto = entPago.ImporteDetraccion
                operacion = negActivo.Guardar(entActivo)
            Else
                entActivo.Monto = entActivo.Monto + entPago.ImporteDetraccion
                operacion = negActivo.Actualizar(entActivo)
            End If
        End If

        operacion = negPago.Guardar(entPago)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Cobro")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Cobro")
        End If
    End Sub
    Private Sub LeerPago()
        If dgvPago.Rows.Count > 0 Then
            entPago = negPago.ObtenerData(dgvPago.CurrentRow.Cells("IdPago").Value, 1)
            txtIdPago.Text = entPago.IdPago
            txtNumeroComprobante.Text = entPago.NumeroComprobante
            cbMetodoPago.SelectedValue = entPago.MetodoPagoId
            txtNroOperacion.Text = entPago.NroOperacion
            dtpFechaPago.Value = entPago.FechaPago
            txtSubTotal.Text = entPago.ImporteCancelado.ToString(“##,##0.00”)
            txtSubTotal.Enabled = False
            respaldoPago = entPago.ImporteCancelado + entIngreso.Deuda
        End If
    End Sub
    Private Sub ActualizarPago()
        entPago.OrigenId = CInt(txtIdIngreso.Text)
        entPago.NumeroComprobante = txtNumeroComprobante.Text
        If cbMetodoPago.SelectedValue = 0 Then
            MsgBox("Escoger un método de pago", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPago.MetodoPagoId = cbMetodoPago.SelectedValue
        End If
        entPago.NroOperacion = txtNroOperacion.Text
        entPago.FechaPago = dtpFechaPago.Value
        entPago.TipoOrigenId = 1
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPago.ImporteIGV = Convert.ToDecimal(txtIGV.Text)
        entPago.ImporteDetraccion = Convert.ToDecimal(txtDetraccion.Text)
        entPago.ImporteTotal = Convert.ToDecimal(txtTotal.Text)
        entPago.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negPago.Actualizar(entPago)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Cobro")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Cobro")
        End If
    End Sub
    Private Sub EliminarPago()
        If dgvPago.Rows.Count > 0 Then
            entPago = negPago.ObtenerData(dgvPago.CurrentRow.Cells("IdPago").Value, 1)
            entPago.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            entIngreso.Deuda = entIngreso.Deuda + entPago.ImporteCancelado
            entIngreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario
            operacion = negIngreso.Actualizar(entIngreso)

            'Cuenta contable - Eliminar efectos de pago
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 1, 2, entIngreso.GrupoIngresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto - entPago.ImporteTotal
                    Else
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteTotal
                    Else
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteTotal
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Debe")
                Exit Sub
            End If
            Select Case entRelacionDebeHaber.GrupoHaberId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto - entPago.ImporteTotal
                    Else
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteTotal
                    Else
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteTotal
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear Haber")
                Exit Sub
            End If

            If entIngreso.IGV Then
                entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, 3)
                entPasivo.Monto = entPasivo.Monto - entPago.ImporteIGV
                operacion = negPasivo.Actualizar(entPasivo)
            End If
            If entIngreso.Detraccion Then
                entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, 2)
                entActivo.Monto = entActivo.Monto - entPago.ImporteDetraccion
                operacion = negActivo.Actualizar(entActivo)
            End If

            'Cuenta contable - retornar efectos de registro
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 1, 1, entIngreso.GrupoIngresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    Else
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    Else
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteCancelado
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Debe")
                Exit Sub
            End If
            Select Case entRelacionDebeHaber.GrupoHaberId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    Else
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    Else
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entIngreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteCancelado
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear Haber")
                Exit Sub
            End If

            operacion = negPago.Eliminar(entPago)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Cobro")
            Else
                MsgBox("No eliminó bien", MsgBoxStyle.Critical, "Eliminar Cobro")
            End If
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
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdIngreso.Text = "0" Then
            CrearIngreso()
        Else
            ActualizarIngreso(False)
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
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
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        LeerIngreso()
        ModoPago()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModoInicial()
    End Sub

    Private Sub btnNuevoPago_Click(sender As Object, e As EventArgs) Handles btnNuevoPago.Click
        LeerIngreso()
        ModoRegistrarPago()
    End Sub

    Private Sub btnModificarPago_Click(sender As Object, e As EventArgs) Handles btnModificarPago.Click
        LeerPago()
        ModoRegistrarPago()
    End Sub

    Private Sub btnEliminarPago_Click(sender As Object, e As EventArgs) Handles btnEliminarPago.Click
        EliminarPago()
    End Sub

    Private Sub btnGuardarPago_Click(sender As Object, e As EventArgs) Handles btnGuardarPago.Click
        If txtIdPago.Text = "0" Then
            CrearPago()
        Else
            ActualizarPago()
        End If
        ActualizarIngreso(True)
        LeerIngreso()
        If operacion Then
            ModoPago()
        End If
    End Sub

    Private Sub btnCancelarPago_Click(sender As Object, e As EventArgs) Handles btnCancelarPago.Click
        ModoPago()
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
        myProcess.StartInfo.FileName = entIngreso.ComprobanteUbicacion
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