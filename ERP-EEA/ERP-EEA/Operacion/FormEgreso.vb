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
    Dim entRelacionDebeHaber As New EntRelacionDebeHaber
    Dim negRelacionDebeHaber As New NegRelacionDebeHaber
    Dim entActivo As New EntActivo
    Dim entPasivo As New EntPasivo
    Dim entPatrimonio As New EntPatrimonio
    Dim entPeriodo As New EntPeriodo
    Dim negActivo As New NegActivo
    Dim negPasivo As New NegPasivo
    Dim negPatrimonio As New NegPatrimonio
    Dim list As New List(Of String)
    Dim respaldoRegistro As Decimal
    Dim respaldoPago As Decimal
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 300
        operacion = False
        respaldoRegistro = 0
        txtIdEgreso.Text = "0"
        txtComentario.Text = ""
        txtNumeroComprobanteEgreso.Text = ""
        txtComprobanteUbicacion.Text = ""
        txtImporteProvisional.Text = ""
        cboGrupoEgreso.SelectedValue = 0
        cboSubGrupoEgreso.SelectedValue = 0
        cboProveedor.SelectedValue = 0
        cboPeriodo.SelectedValue = 0
        chkIGV.Checked = False
        txtImporteProvisional.Enabled = True
        cboPeriodo.Enabled = True
        btnNuevo.Enabled = True
        PanelEgreso.Visible = False
        PanelPago.Visible = False
        PanelRegistroPago.Visible = False
        If VariableGlobal.VGAlertaEgreso Then
            btnVerDeudas.Text = "TODOS"
        Else
            btnVerDeudas.Text = "DEUDAS"
        End If
        CargarTablaEgreso()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 500
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        dgvEgreso.Enabled = False
        PanelEgreso.Visible = True
    End Sub

    Private Sub ModoPago()
        Me.Height = 500
        operacion = False
        respaldoPago = 0
        txtIdPago.Text = "0"
        txtNroOperacion.Text = ""
        txtNumeroComprobante.Text = ""
        txtRespaldoImporte.Text = ""
        cbMetodoPago.SelectedValue = 0
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnPagar.Enabled = False
        dgvEgreso.Enabled = False
        If entEgreso.Deuda = 0 Then
            btnNuevoPago.Enabled = False
        Else
            btnNuevoPago.Enabled = True
        End If
        btnVolver.Enabled = True
        txtSubTotal.Enabled = True
        PanelEgreso.Visible = False
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
    Private Sub CargarTablaEgreso()
        dataTable = negEgreso.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue, 0, VariableGlobal.VGAlertaEgreso)
        dgvEgreso.DataSource = dataTable
        If dgvEgreso.Rows.Count > 0 Then
            dgvEgreso.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnPagar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnPagar.Enabled = False
            dgvEgreso.Enabled = False
        End If
    End Sub

    Private Sub CargarTablaPago()
        dataTable = negPago.ObtenerTabla(0, 2, Int(txtIdEgreso.Text), cbPeriodoFiltro.SelectedValue, 0, 0)
        dgvPago.DataSource = dataTable
        If dgvPago.Rows.Count > 0 Then
            dgvPago.Enabled = True
            btnModificarPago.Enabled = True
            btnEliminarPago.Enabled = True
        Else
            btnModificarPago.Enabled = False
            btnEliminarPago.Enabled = False
            dgvPago.Enabled = False
        End If
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
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True, 1)

        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False, 1)

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
            txtTotal.Text = "0"
            Exit Sub
        End If
        If entEgreso.IGV Then
            entParametro = negParametro.ObtenerData(2)
            entPago.ImporteIGV = entPago.ImporteCancelado * entParametro.ValorParametro
            txtIGV.Text = entPago.ImporteIGV.ToString(“##,##0.00”)
            entPago.ImporteTotal = (entPago.ImporteIGV + entPago.ImporteCancelado)
        Else
            entPago.ImporteTotal = (entPago.ImporteCancelado)
        End If
        txtTotal.Text = entPago.ImporteTotal.ToString(“##,##0.00”)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    'EGRESO
    Private Sub CrearEgreso()
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Grupo de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If
        If cboSubGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Item de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.SubGrupoEgresoId = cboSubGrupoEgreso.SelectedValue
        End If
        If cboProveedor.SelectedValue = 0 Then
            MsgBox("Escoger un cliente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.ProveedorId = cboProveedor.SelectedValue
        End If
        entEgreso.Comentario = txtComentario.Text
        entEgreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entEgreso.NumeroComprobanteEgreso = txtNumeroComprobanteEgreso.Text
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.PeriodoId = cboPeriodo.SelectedValue
        End If
        entEgreso.FechaEgresoProvision = dtpFechaIngreso.Value
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.ImporteProvision = Convert.ToDecimal(txtImporteProvisional.Text)
            entEgreso.Deuda = entEgreso.ImporteProvision
            entParametro = negParametro.ObtenerData(2)
            entEgreso.IgvProvision = entEgreso.ImporteProvision * entParametro.ValorParametro
            entEgreso.TotalProvision = entEgreso.ImporteProvision + entEgreso.IgvProvision
        End If
        entEgreso.IGV = chkIGV.Checked
        entEgreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        'Cuenta Contable
        entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 2, 1, entEgreso.SubGrupoEgresoId)
        Select Case entRelacionDebeHaber.GrupoDebeId
            Case 1
                entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entEgreso.SubGrupoEgresoId)
                If entActivo.IdActivo = 0 Then
                    entActivo.PeriodoId = entEgreso.PeriodoId
                    entActivo.GrupoActivoId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entEgreso.ImporteProvision
                    Else
                        entActivo.Monto = -1 * entEgreso.ImporteProvision
                    End If
                    operacion = negActivo.Guardar(entActivo)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entEgreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto - entEgreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                End If
            Case 2
                entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entEgreso.SubGrupoEgresoId)
                If entPasivo.IdPasivo = 0 Then
                    entPasivo.PeriodoId = entEgreso.PeriodoId
                    entPasivo.GrupoPasivoId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entEgreso.ImporteProvision
                    Else
                        entPasivo.Monto = -1 * entEgreso.ImporteProvision
                    End If
                    operacion = negPasivo.Guardar(entPasivo)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entEgreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto - entEgreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                End If
            Case 3
                entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entEgreso.SubGrupoEgresoId)
                If entPatrimonio.IdPatrimonio = 0 Then
                    entPatrimonio.PeriodoId = entEgreso.PeriodoId
                    entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.DebeId
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entEgreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = -1 * entEgreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Guardar(entPatrimonio)
                Else
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entEgreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entEgreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                End If
            Case Else
                operacion = False
        End Select
        If operacion = False Then
            MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear Debe")
            Exit Sub
        End If
        Select Case entRelacionDebeHaber.GrupoHaberId
            Case 1
                entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entEgreso.SubGrupoEgresoId)
                If entActivo.IdActivo = 0 Then
                    entActivo.PeriodoId = entEgreso.PeriodoId
                    entActivo.GrupoActivoId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entEgreso.ImporteProvision
                    Else
                        entActivo.Monto = -1 * entEgreso.ImporteProvision
                    End If
                    operacion = negActivo.Guardar(entActivo)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entEgreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto - entEgreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                End If
            Case 2
                entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entEgreso.SubGrupoEgresoId)
                If entPasivo.IdPasivo = 0 Then
                    entPasivo.PeriodoId = entEgreso.PeriodoId
                    entPasivo.GrupoPasivoId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entEgreso.ImporteProvision
                    Else
                        entPasivo.Monto = -1 * entEgreso.ImporteProvision
                    End If
                    operacion = negPasivo.Guardar(entPasivo)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entEgreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto - entEgreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                End If
            Case 3
                entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entEgreso.SubGrupoEgresoId)
                If entPatrimonio.IdPatrimonio = 0 Then
                    entPatrimonio.PeriodoId = entEgreso.PeriodoId
                    entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.HaberId
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entEgreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = -1 * entEgreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Guardar(entPatrimonio)
                Else
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entEgreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entEgreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                End If
            Case Else
                operacion = False
        End Select
        If operacion = False Then
            MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear Haber")
            Exit Sub
        End If

        operacion = negEgreso.Guardar(entEgreso)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Egreso")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Egreso")
        End If
    End Sub
    Private Sub LeerEgreso()
        If dgvEgreso.Rows.Count > 0 Then
            cboPeriodo.Enabled = False
            entEgreso = negEgreso.ObtenerData(dgvEgreso.CurrentRow.Cells("IdEgreso").Value, 0)
            txtIdEgreso.Text = entEgreso.IdEgreso
            cboGrupoEgreso.SelectedValue = entEgreso.GrupoEgresoId
            cboSubGrupoEgreso.SelectedValue = entEgreso.SubGrupoEgresoId
            cboProveedor.SelectedValue = entEgreso.ProveedorId
            txtComentario.Text = entEgreso.Comentario
            txtComprobanteUbicacion.Text = entEgreso.ComprobanteUbicacion
            txtNumeroComprobanteEgreso.Text = entEgreso.NumeroComprobanteEgreso
            cboPeriodo.SelectedValue = entEgreso.PeriodoId
            dtpFechaIngreso.Value = entEgreso.FechaEgresoProvision
            txtImporteProvisional.Text = entEgreso.ImporteProvision.ToString(“##,##0.00”)
            chkIGV.Checked = entEgreso.IGV
            txtSubTotal.Text = entEgreso.Deuda.ToString(“##,##0.00”)
            respaldoRegistro = entEgreso.ImporteProvision
            If entEgreso.ImporteProvision <> entEgreso.Deuda Then
                txtImporteProvisional.Enabled = False
            End If
            If txtComprobanteUbicacion.Text = "" Then
                btnAbrir.Enabled = False
            Else
                btnAbrir.Enabled = True
            End If
        End If
    End Sub
    Private Sub ActualizarEgreso(ByVal actualizarPago As Boolean)
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Grupo de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If
        If cboSubGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger Item de Egreso", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.SubGrupoEgresoId = cboSubGrupoEgreso.SelectedValue
        End If
        If cboProveedor.SelectedValue = 0 Then
            MsgBox("Escoger un cliente", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.ProveedorId = cboProveedor.SelectedValue
        End If
        entEgreso.Comentario = txtComentario.Text
        entEgreso.ComprobanteUbicacion = txtComprobanteUbicacion.Text
        entEgreso.NumeroComprobanteEgreso = txtNumeroComprobanteEgreso.Text
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entEgreso.PeriodoId = cboPeriodo.SelectedValue
        End If
        entEgreso.FechaEgresoProvision = dtpFechaIngreso.Value
        If txtImporteProvisional.Text = "" Then
            MsgBox("Ingresar el importe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            If actualizarPago = False Then
                entEgreso.Deuda = entEgreso.ImporteProvision
            End If
            entParametro = negParametro.ObtenerData(2)
            entEgreso.IgvProvision = entEgreso.ImporteProvision * entParametro.ValorParametro
            entEgreso.TotalProvision = entEgreso.ImporteProvision + entEgreso.IgvProvision
        End If
        entEgreso.IGV = chkIGV.Checked
        entEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If actualizarPago = False Then
            'Cuenta Contable
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 2, 1, entEgreso.SubGrupoEgresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entEgreso.ImporteProvision - respaldoRegistro
                    Else
                        entActivo.Monto = entActivo.Monto - entEgreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entEgreso.ImporteProvision - respaldoRegistro
                    Else
                        entPasivo.Monto = entPasivo.Monto - entEgreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entEgreso.ImporteProvision - respaldoRegistro
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entEgreso.ImporteProvision + respaldoRegistro
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
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entEgreso.ImporteProvision - respaldoRegistro
                    Else
                        entActivo.Monto = entActivo.Monto - entEgreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entEgreso.ImporteProvision - respaldoRegistro
                    Else
                        entPasivo.Monto = entPasivo.Monto - entEgreso.ImporteProvision + respaldoRegistro
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto + entEgreso.ImporteProvision - respaldoRegistro
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto - entEgreso.ImporteProvision + respaldoRegistro
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

        operacion = negEgreso.Actualizar(entEgreso)
        If operacion Then
            If (actualizarPago = False) Then
                MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Egreso")
            End If
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Egreso")
        End If
    End Sub

    Private Sub EliminarEgreso()
        If dgvEgreso.Rows.Count > 0 Then
            entEgreso = negEgreso.ObtenerData(dgvEgreso.CurrentRow.Cells("IdEgreso").Value, 0)
            If entEgreso.ImporteProvision <> entEgreso.Deuda Then
                MsgBox("Primero de debe eliminar los pagos realizados a este egreso", MsgBoxStyle.Critical, "Eliminar Ingreso")
                Exit Sub
            End If
            entEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            'Cuenta Contable
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 2, 1, entEgreso.SubGrupoEgresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto - entEgreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto + entEgreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entEgreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto + entEgreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entEgreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto + entEgreso.ImporteProvision
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
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto - entEgreso.ImporteProvision
                    Else
                        entActivo.Monto = entActivo.Monto + entEgreso.ImporteProvision
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entEgreso.ImporteProvision
                    Else
                        entPasivo.Monto = entPasivo.Monto + entEgreso.ImporteProvision
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entEgreso.ImporteProvision
                    Else
                        entPatrimonio.Monto = entPatrimonio.Monto + entEgreso.ImporteProvision
                    End If
                    operacion = negPatrimonio.Actualizar(entPatrimonio)
                Case Else
                    operacion = False
            End Select
            If operacion = False Then
                MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Haber")
                Exit Sub
            End If

            operacion = negEgreso.Eliminar(entEgreso)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Egreso")
                ModoInicial()
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Egreso")
            End If
        End If
    End Sub

    'PAGO
    Private Sub CrearPago()
        entPago.OrigenId = CInt(txtIdEgreso.Text)
        entPago.NumeroComprobante = txtNumeroComprobante.Text
        If cbMetodoPago.SelectedValue = 0 Then
            MsgBox("Escoger un método de pago")
            Exit Sub
        Else
            entPago.MetodoPagoId = cbMetodoPago.SelectedValue
        End If
        entPago.NroOperacion = txtNroOperacion.Text
        entPago.FechaPago = dtpFechaPago.Value
        entPago.TipoOrigenId = 2
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado")
            Exit Sub
        Else
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPago.ImporteDetraccion = 0
        entPago.ImporteIGV = Convert.ToDecimal(txtIGV.Text)
        entPago.ImporteTotal = Convert.ToDecimal(txtTotal.Text)
        entPago.UsuarioCreacionId = VariableGlobal.VGIDUsuario
        'Actualizar deuda según pago realizado
        entEgreso.Deuda = entEgreso.Deuda - entPago.ImporteCancelado
        entEgreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        'Cuenta Contable
        'entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 2, 2, entEgreso.SubGrupoEgresoId)
        'Select Case entRelacionDebeHaber.GrupoDebeId
        '    Case 1
        '        entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
        '        If entActivo.IdActivo = 0 Then
        '            entActivo.PeriodoId = entEgreso.PeriodoId
        '            entActivo.GrupoActivoId = entRelacionDebeHaber.DebeId
        '            If entRelacionDebeHaber.SignoDebe = 1 Then
        '                entActivo.Monto = entPago.ImporteCancelado
        '            Else
        '                entActivo.Monto = -1 * entPago.ImporteCancelado
        '            End If
        '            operacion = negActivo.Guardar(entActivo)
        '        Else
        '            If entRelacionDebeHaber.SignoDebe = 1 Then
        '                entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
        '            Else
        '                entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
        '            End If
        '            operacion = negActivo.Actualizar(entActivo)
        '        End If
        '    Case 2
        '        entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
        '        If entPasivo.IdPasivo = 0 Then
        '            entPasivo.PeriodoId = entEgreso.PeriodoId
        '            entPasivo.GrupoPasivoId = entRelacionDebeHaber.DebeId
        '            If entRelacionDebeHaber.SignoDebe = 1 Then
        '                entPasivo.Monto = entPago.ImporteCancelado
        '            Else
        '                entPasivo.Monto = -1 * entPago.ImporteCancelado
        '            End If
        '            operacion = negPasivo.Guardar(entPasivo)
        '        Else
        '            If entRelacionDebeHaber.SignoDebe = 1 Then
        '                entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
        '            Else
        '                entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
        '            End If
        '            operacion = negPasivo.Actualizar(entPasivo)
        '        End If
        '    Case 3
        '        entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
        '        If entPatrimonio.IdPatrimonio = 0 Then
        '            entPatrimonio.PeriodoId = entEgreso.PeriodoId
        '            entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.DebeId
        '            If entRelacionDebeHaber.SignoDebe = 1 Then
        '                entPatrimonio.Monto = entPago.ImporteCancelado
        '            Else
        '                entPatrimonio.Monto = -1 * entPago.ImporteCancelado
        '            End If
        '            operacion = negPatrimonio.Guardar(entPatrimonio)
        '        Else
        '            If entRelacionDebeHaber.SignoDebe = 1 Then
        '                entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteCancelado
        '            Else
        '                entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
        '            End If
        '            operacion = negPatrimonio.Actualizar(entPatrimonio)
        '        End If
        '    Case Else
        '        operacion = False
        'End Select
        'If operacion = False Then
        '    MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Debe")
        '    Exit Sub
        'End If
        'Select Case entRelacionDebeHaber.GrupoHaberId
        '    Case 1
        '        entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
        '        If entActivo.IdActivo = 0 Then
        '            entActivo.PeriodoId = entEgreso.PeriodoId
        '            entActivo.GrupoActivoId = entRelacionDebeHaber.HaberId
        '            If entRelacionDebeHaber.SignoHaber = 1 Then
        '                entActivo.Monto = entPago.ImporteCancelado
        '            Else
        '                entActivo.Monto = -1 * entPago.ImporteCancelado
        '            End If
        '            operacion = negActivo.Guardar(entActivo)
        '        Else
        '            If entRelacionDebeHaber.SignoHaber = 1 Then
        '                entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
        '            Else
        '                entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
        '            End If
        '            operacion = negActivo.Actualizar(entActivo)
        '        End If
        '    Case 2
        '        entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
        '        If entPasivo.IdPasivo = 0 Then
        '            entPasivo.PeriodoId = entEgreso.PeriodoId
        '            entPasivo.GrupoPasivoId = entRelacionDebeHaber.HaberId
        '            If entRelacionDebeHaber.SignoHaber = 1 Then
        '                entPasivo.Monto = entPago.ImporteCancelado
        '            Else
        '                entPasivo.Monto = -1 * entPago.ImporteCancelado
        '            End If
        '            operacion = negPasivo.Guardar(entPasivo)
        '        Else
        '            If entRelacionDebeHaber.SignoHaber = 1 Then
        '                entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
        '            Else
        '                entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
        '            End If
        '            operacion = negPasivo.Actualizar(entPasivo)
        '        End If
        '    Case 3
        '        entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
        '        If entPatrimonio.IdPatrimonio = 0 Then
        '            entPatrimonio.PeriodoId = entEgreso.PeriodoId
        '            entPatrimonio.GrupoPatrimonioId = entRelacionDebeHaber.HaberId
        '            If entRelacionDebeHaber.SignoHaber = 1 Then
        '                entPatrimonio.Monto = entPago.ImporteCancelado
        '            Else
        '                entPatrimonio.Monto = -1 * entPago.ImporteCancelado
        '            End If
        '            operacion = negPatrimonio.Guardar(entPatrimonio)
        '        Else
        '            If entRelacionDebeHaber.SignoHaber = 1 Then
        '                entPatrimonio.Monto = entPatrimonio.Monto + entPago.ImporteCancelado
        '            Else
        '                entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
        '            End If
        '            operacion = negPatrimonio.Actualizar(entPatrimonio)
        '        End If
        '    Case Else
        '        operacion = False
        'End Select
        'If operacion = False Then
        '    MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Haber")
        '    Exit Sub
        'End If
        'If entEgreso.IGV Then
        '    entPasivo = negPasivo.ObtenerData(1, entEgreso.PeriodoId, 3)
        '    If entPasivo.IdPasivo = 0 Then
        '        entPasivo.PeriodoId = entEgreso.PeriodoId
        '        entPasivo.GrupoPasivoId = 3
        '        entPasivo.Monto = -1 * entPago.ImporteIGV
        '        operacion = negPasivo.Guardar(entPasivo)
        '    Else
        '        entPasivo.Monto = entPasivo.Monto - entPago.ImporteIGV
        '        operacion = negPasivo.Actualizar(entPasivo)
        '    End If
        '    If operacion = False Then
        '        MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar IGV")
        '        Exit Sub
        '    End If
        '    entPatrimonio = negPatrimonio.ObtenerData(1, entEgreso.PeriodoId, 4)
        '    If entPatrimonio.IdPatrimonio = 0 Then
        '        entPatrimonio.PeriodoId = entEgreso.PeriodoId
        '        entPatrimonio.GrupoPatrimonioId = 4
        '        entPatrimonio.Monto = -1 * entPago.ImporteIGV
        '        operacion = negPatrimonio.Guardar(entPatrimonio)
        '    Else
        '        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteIGV
        '        operacion = negPatrimonio.Actualizar(entPatrimonio)
        '    End If
        '    If operacion = False Then
        '        MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Utilidad Neta")
        '        Exit Sub
        '    End If
        'End If

        operacion = negPago.Guardar(entPago)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Cobro")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Cobro")
        End If
    End Sub
    Private Sub LeerPago()
        If dgvPago.Rows.Count > 0 Then
            entPago = negPago.ObtenerData(dgvPago.CurrentRow.Cells("IdPago").Value, 2)
            txtIdPago.Text = entPago.IdPago
            txtNumeroComprobante.Text = entPago.NumeroComprobante
            cbMetodoPago.SelectedValue = entPago.MetodoPagoId
            txtNroOperacion.Text = entPago.NroOperacion
            dtpFechaPago.Value = entPago.FechaPago
            txtSubTotal.Text = entPago.ImporteCancelado.ToString(“##,##0.00”)
            txtSubTotal.Enabled = False
            respaldoPago = entPago.ImporteCancelado + entEgreso.Deuda
        End If
    End Sub
    Private Sub ActualizarPago()
        entPago.OrigenId = CInt(txtIdEgreso.Text)
        entPago.NumeroComprobante = txtNumeroComprobante.Text
        If cbMetodoPago.SelectedValue = 0 Then
            MsgBox("Escoger un método de pago", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPago.MetodoPagoId = cbMetodoPago.SelectedValue
        End If
        entPago.NroOperacion = txtNroOperacion.Text
        entPago.FechaPago = dtpFechaPago.Value
        entPago.TipoOrigenId = 2
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el Importe Cancelado", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPago.ImporteCancelado = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPago.ImporteIGV = Convert.ToDecimal(txtIGV.Text)
        entPago.ImporteDetraccion = 0
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
            entPago = negPago.ObtenerData(dgvPago.CurrentRow.Cells("IdPago").Value, 2)
            entPago.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            entEgreso.Deuda = entEgreso.Deuda + entPago.ImporteCancelado
            entEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario
            operacion = negEgreso.Actualizar(entEgreso)

            'Cuenta contable - Eliminar efectos de pago
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 2, 2, entEgreso.SubGrupoEgresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    Else
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    Else
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
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
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    Else
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    Else
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPatrimonio.Monto = entPatrimonio.Monto - entPago.ImporteCancelado
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

            If entEgreso.IGV Then
                entPasivo = negPasivo.ObtenerData(1, entEgreso.PeriodoId, 3)
                entPasivo.Monto = entPasivo.Monto + entPago.ImporteIGV
                operacion = negPasivo.Actualizar(entPasivo)
                If operacion = False Then
                    MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar IGV")
                    Exit Sub
                End If
                entPatrimonio = negPatrimonio.ObtenerData(1, entEgreso.PeriodoId, 4)
                entPatrimonio.Monto = entPasivo.Monto + entPago.ImporteIGV
                operacion = negPatrimonio.Actualizar(entPatrimonio)
                If operacion = False Then
                    MsgBox("No creó/actualizó", MsgBoxStyle.Critical, "Crear/Actualizar Utilidad Neta")
                    Exit Sub
                End If
            End If

            'Cuenta contable - retornar efectos de registro
            entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(0, 2, 1, entEgreso.SubGrupoEgresoId)
            Select Case entRelacionDebeHaber.GrupoDebeId
                Case 1
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    Else
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
                    If entRelacionDebeHaber.SignoDebe = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    Else
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.DebeId)
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
                    entActivo = negActivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entActivo.Monto = entActivo.Monto + entPago.ImporteCancelado
                    Else
                        entActivo.Monto = entActivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negActivo.Actualizar(entActivo)
                Case 2
                    entPasivo = negPasivo.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
                    If entRelacionDebeHaber.SignoHaber = 1 Then
                        entPasivo.Monto = entPasivo.Monto + entPago.ImporteCancelado
                    Else
                        entPasivo.Monto = entPasivo.Monto - entPago.ImporteCancelado
                    End If
                    operacion = negPasivo.Actualizar(entPasivo)
                Case 3
                    entPatrimonio = negPatrimonio.ObtenerData(0, entEgreso.PeriodoId, entRelacionDebeHaber.HaberId)
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
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerEgreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarEgreso()
            If operacion Then
                ModoInicial()
            End If
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdEgreso.Text = "0" Then
            CrearEgreso()
        Else
            ActualizarEgreso(False)
        End If
        If operacion Then
            ModoInicial()
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
        If operacion Then
            ModoInicial()
        End If
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
        If operacion Then
            ModoPago()
        End If
    End Sub

    Private Sub btnGuardarPago_Click(sender As Object, e As EventArgs) Handles btnGuardarPago.Click
        If txtIdPago.Text = "0" Then
            CrearPago()
        Else
            ActualizarPago()
        End If
        ActualizarEgreso(True)
        LeerEgreso()
        If operacion Then
            ModoPago()
        End If
    End Sub

    Private Sub btnVerDeudas_Click(sender As Object, e As EventArgs) Handles btnVerDeudas.Click
        If VariableGlobal.VGAlertaEgreso Then
            VariableGlobal.VGAlertaEgreso = False
            CargarTablaEgreso()
            btnVerDeudas.Text = "DEUDAS"
        Else
            VariableGlobal.VGAlertaEgreso = True
            CargarTablaEgreso()
            btnVerDeudas.Text = "TODOS"
        End If
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
            cboSubGrupoEgreso.ValueMember = "IdSubGrupoEgreso"
            cboSubGrupoEgreso.DisplayMember = "ItemSubGrupoEgreso"
            cboSubGrupoEgreso.DataSource = negSubGrupoEgreso.ObtenerLista(False, True, cboGrupoEgreso.SelectedValue)
        End If
    End Sub

    Private Sub cbPeriodoFiltro_TextChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.TextChanged
        If cbPeriodoFiltro.Text.Length = 7 Then
            entPeriodo = negPeriodo.ObtenerData(0, cbPeriodoFiltro.Text, 0)
            cbPeriodoFiltro.SelectedValue = EntPeriodo.IdPeriodo
            CargarTablaEgreso()
        End If
    End Sub
#End Region
End Class