﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEgreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.dgvEgreso = New PersControlLibrary.ExtendedDataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cbPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PanelRegistroPago = New System.Windows.Forms.Panel()
        Me.lbNroOperacion = New System.Windows.Forms.Label()
        Me.txtNroOperacion = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.lblIGV = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblImporteCancelado = New System.Windows.Forms.Label()
        Me.btnGuardarPago = New System.Windows.Forms.Button()
        Me.btnCancelarPago = New System.Windows.Forms.Button()
        Me.txtIdPago = New PersControlLibrary.ExtendedTextBox()
        Me.txtRespaldoImporte = New System.Windows.Forms.TextBox()
        Me.txtComprobanteUbicacion = New PersControlLibrary.ExtendedTextBox()
        Me.PanelPago = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnNuevoPago = New System.Windows.Forms.Button()
        Me.btnEliminarPago = New System.Windows.Forms.Button()
        Me.btnModificarPago = New System.Windows.Forms.Button()
        Me.dgvPago = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPagoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedioDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteCancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDetraccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEgreso = New System.Windows.Forms.Panel()
        Me.chkIGV = New System.Windows.Forms.CheckBox()
        Me.lblGrupoEgreso = New System.Windows.Forms.Label()
        Me.cboGrupoEgreso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSubGrupoEgreso = New System.Windows.Forms.ComboBox()
        Me.lblTipoIngreso = New System.Windows.Forms.Label()
        Me.txtNumeroComprobanteEgreso = New System.Windows.Forms.TextBox()
        Me.lblNumeroComprobanteIngreso = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnAdjuntarArchivo = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtImporteProvisional = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComentario = New PersControlLibrary.ExtendedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdEgreso = New PersControlLibrary.ExtendedTextBox()
        Me.btnVerDeudas = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEgresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEgresoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGrupoEgresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGrupoEgresoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroComprobanteIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoProvision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteProvision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobanteUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegistroPago.SuspendLayout()
        Me.PanelPago.SuspendLayout()
        CType(Me.dgvPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEgreso.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPagar
        '
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.Black
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(538, 13)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(75, 26)
        Me.btnPagar.TabIndex = 5
        Me.btnPagar.Text = "[F4] PAGAR"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'dgvEgreso
        '
        Me.dgvEgreso.AllowUserToAddRows = False
        Me.dgvEgreso.AllowUserToDeleteRows = False
        Me.dgvEgreso.AllowUserToResizeColumns = False
        Me.dgvEgreso.AllowUserToResizeRows = False
        Me.dgvEgreso.BackgroundColor = System.Drawing.Color.White
        Me.dgvEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEgreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEgreso.ColumnHeadersHeight = 20
        Me.dgvEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEgreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdEgreso, Me.GrupoEgresoId, Me.GrupoEgresoDescripcion, Me.SubGrupoEgresoId, Me.SubGrupoEgresoDescripcion, Me.ProveedorId, Me.NombreComercial, Me.NumeroComprobanteIngreso, Me.IGV, Me.PeriodoId, Me.Comentario, Me.FechaIngresoProvision, Me.ImporteProvision, Me.ComprobanteUbicacion, Me.Deuda})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEgreso.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEgreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEgreso.EnableHeadersVisualStyles = False
        Me.dgvEgreso.Location = New System.Drawing.Point(16, 47)
        Me.dgvEgreso.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEgreso.Name = "dgvEgreso"
        Me.dgvEgreso.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEgreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEgreso.RowHeadersVisible = False
        Me.dgvEgreso.RowHeadersWidth = 22
        Me.dgvEgreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEgreso.RowTemplate.Height = 18
        Me.dgvEgreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEgreso.Size = New System.Drawing.Size(597, 200)
        Me.dgvEgreso.TabIndex = 476
        Me.dgvEgreso.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(332, 14)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.TabStop = False
        Me.btnModificar.Text = "[F5] MODIFICAR"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(251, 14)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cbPeriodoFiltro
        '
        Me.cbPeriodoFiltro.FormattingEnabled = True
        Me.cbPeriodoFiltro.Location = New System.Drawing.Point(64, 18)
        Me.cbPeriodoFiltro.Name = "cbPeriodoFiltro"
        Me.cbPeriodoFiltro.Size = New System.Drawing.Size(90, 21)
        Me.cbPeriodoFiltro.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 477
        Me.Label23.Text = "Periodo"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(435, 14)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "[Supr] ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PanelRegistroPago
        '
        Me.PanelRegistroPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelRegistroPago.Controls.Add(Me.lbNroOperacion)
        Me.PanelRegistroPago.Controls.Add(Me.txtNroOperacion)
        Me.PanelRegistroPago.Controls.Add(Me.txtSubTotal)
        Me.PanelRegistroPago.Controls.Add(Me.txtIGV)
        Me.PanelRegistroPago.Controls.Add(Me.lblIGV)
        Me.PanelRegistroPago.Controls.Add(Me.lblSubtotal)
        Me.PanelRegistroPago.Controls.Add(Me.txtNumeroComprobante)
        Me.PanelRegistroPago.Controls.Add(Me.Label5)
        Me.PanelRegistroPago.Controls.Add(Me.cbMetodoPago)
        Me.PanelRegistroPago.Controls.Add(Me.Label3)
        Me.PanelRegistroPago.Controls.Add(Me.Label7)
        Me.PanelRegistroPago.Controls.Add(Me.dtpFechaPago)
        Me.PanelRegistroPago.Controls.Add(Me.txtTotal)
        Me.PanelRegistroPago.Controls.Add(Me.lblImporteCancelado)
        Me.PanelRegistroPago.Controls.Add(Me.btnGuardarPago)
        Me.PanelRegistroPago.Controls.Add(Me.btnCancelarPago)
        Me.PanelRegistroPago.Controls.Add(Me.txtIdPago)
        Me.PanelRegistroPago.Controls.Add(Me.txtRespaldoImporte)
        Me.PanelRegistroPago.Location = New System.Drawing.Point(16, 467)
        Me.PanelRegistroPago.Name = "PanelRegistroPago"
        Me.PanelRegistroPago.Size = New System.Drawing.Size(597, 131)
        Me.PanelRegistroPago.TabIndex = 482
        '
        'lbNroOperacion
        '
        Me.lbNroOperacion.AutoSize = True
        Me.lbNroOperacion.Location = New System.Drawing.Point(13, 62)
        Me.lbNroOperacion.Name = "lbNroOperacion"
        Me.lbNroOperacion.Size = New System.Drawing.Size(76, 13)
        Me.lbNroOperacion.TabIndex = 491
        Me.lbNroOperacion.Text = "Nro Operacion"
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Location = New System.Drawing.Point(120, 61)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.Size = New System.Drawing.Size(190, 20)
        Me.txtNroOperacion.TabIndex = 52
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(478, 13)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtSubTotal.TabIndex = 54
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIGV
        '
        Me.txtIGV.Enabled = False
        Me.txtIGV.Location = New System.Drawing.Point(478, 37)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(105, 20)
        Me.txtIGV.TabIndex = 486
        Me.txtIGV.TabStop = False
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIGV
        '
        Me.lblIGV.AutoSize = True
        Me.lblIGV.Location = New System.Drawing.Point(407, 40)
        Me.lblIGV.Name = "lblIGV"
        Me.lblIGV.Size = New System.Drawing.Size(25, 13)
        Me.lblIGV.TabIndex = 488
        Me.lblIGV.Text = "IGV"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(407, 16)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(50, 13)
        Me.lblSubtotal.TabIndex = 483
        Me.lblSubtotal.Text = "SubTotal"
        '
        'txtNumeroComprobante
        '
        Me.txtNumeroComprobante.Location = New System.Drawing.Point(120, 9)
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(190, 20)
        Me.txtNumeroComprobante.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 478
        Me.Label5.Text = "Nº de comprobante"
        '
        'cbMetodoPago
        '
        Me.cbMetodoPago.FormattingEnabled = True
        Me.cbMetodoPago.Location = New System.Drawing.Point(120, 34)
        Me.cbMetodoPago.Name = "cbMetodoPago"
        Me.cbMetodoPago.Size = New System.Drawing.Size(190, 21)
        Me.cbMetodoPago.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 472
        Me.Label3.Text = "Medio de Pago"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 470
        Me.Label7.Text = "Fecha de Pago"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(120, 86)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaPago.TabIndex = 53
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(479, 72)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtTotal.TabIndex = 465
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImporteCancelado
        '
        Me.lblImporteCancelado.AutoSize = True
        Me.lblImporteCancelado.Location = New System.Drawing.Point(407, 77)
        Me.lblImporteCancelado.Name = "lblImporteCancelado"
        Me.lblImporteCancelado.Size = New System.Drawing.Size(31, 13)
        Me.lblImporteCancelado.TabIndex = 464
        Me.lblImporteCancelado.Text = "Total"
        '
        'btnGuardarPago
        '
        Me.btnGuardarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarPago.Location = New System.Drawing.Point(436, 98)
        Me.btnGuardarPago.Name = "btnGuardarPago"
        Me.btnGuardarPago.Size = New System.Drawing.Size(73, 26)
        Me.btnGuardarPago.TabIndex = 60
        Me.btnGuardarPago.Text = "GUARDAR"
        Me.btnGuardarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarPago.UseVisualStyleBackColor = True
        '
        'btnCancelarPago
        '
        Me.btnCancelarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarPago.FlatAppearance.BorderSize = 0
        Me.btnCancelarPago.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPago.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarPago.Location = New System.Drawing.Point(515, 98)
        Me.btnCancelarPago.Name = "btnCancelarPago"
        Me.btnCancelarPago.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelarPago.TabIndex = 61
        Me.btnCancelarPago.Text = "CANCELAR"
        Me.btnCancelarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelarPago.UseVisualStyleBackColor = True
        '
        'txtIdPago
        '
        Me.txtIdPago.AllowClear = True
        Me.txtIdPago.AllowNegatives = False
        Me.txtIdPago.AllowWhiteSpaces = True
        Me.txtIdPago.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdPago.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdPago.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdPago.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdPago.EnterIsTab = True
        Me.txtIdPago.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdPago.Label = "Descripción"
        Me.txtIdPago.Location = New System.Drawing.Point(463, 102)
        Me.txtIdPago.Mandatory = False
        Me.txtIdPago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdPago.MaxLength = 100
        Me.txtIdPago.MinLength = 0
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Precision = 0
        Me.txtIdPago.SelectOnFocus = True
        Me.txtIdPago.Size = New System.Drawing.Size(26, 20)
        Me.txtIdPago.Symbol = Nothing
        Me.txtIdPago.TabIndex = 460
        Me.txtIdPago.Value = Nothing
        '
        'txtRespaldoImporte
        '
        Me.txtRespaldoImporte.Location = New System.Drawing.Point(449, 102)
        Me.txtRespaldoImporte.Name = "txtRespaldoImporte"
        Me.txtRespaldoImporte.Size = New System.Drawing.Size(18, 20)
        Me.txtRespaldoImporte.TabIndex = 485
        '
        'txtComprobanteUbicacion
        '
        Me.txtComprobanteUbicacion.AllowClear = True
        Me.txtComprobanteUbicacion.AllowNegatives = False
        Me.txtComprobanteUbicacion.AllowWhiteSpaces = True
        Me.txtComprobanteUbicacion.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComprobanteUbicacion.BackColorIdle = System.Drawing.Color.Empty
        Me.txtComprobanteUbicacion.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtComprobanteUbicacion.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtComprobanteUbicacion.EnterIsTab = True
        Me.txtComprobanteUbicacion.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtComprobanteUbicacion.Label = "Descripción"
        Me.txtComprobanteUbicacion.Location = New System.Drawing.Point(233, 131)
        Me.txtComprobanteUbicacion.Mandatory = False
        Me.txtComprobanteUbicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtComprobanteUbicacion.MaxLength = 100
        Me.txtComprobanteUbicacion.MinLength = 0
        Me.txtComprobanteUbicacion.Name = "txtComprobanteUbicacion"
        Me.txtComprobanteUbicacion.Precision = 0
        Me.txtComprobanteUbicacion.SelectOnFocus = True
        Me.txtComprobanteUbicacion.Size = New System.Drawing.Size(26, 20)
        Me.txtComprobanteUbicacion.Symbol = Nothing
        Me.txtComprobanteUbicacion.TabIndex = 481
        Me.txtComprobanteUbicacion.Value = Nothing
        '
        'PanelPago
        '
        Me.PanelPago.Controls.Add(Me.btnVolver)
        Me.PanelPago.Controls.Add(Me.btnNuevoPago)
        Me.PanelPago.Controls.Add(Me.btnEliminarPago)
        Me.PanelPago.Controls.Add(Me.btnModificarPago)
        Me.PanelPago.Controls.Add(Me.dgvPago)
        Me.PanelPago.Location = New System.Drawing.Point(16, 266)
        Me.PanelPago.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPago.Name = "PanelPago"
        Me.PanelPago.Size = New System.Drawing.Size(597, 181)
        Me.PanelPago.TabIndex = 484
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Black
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(497, 122)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(88, 26)
        Me.btnVolver.TabIndex = 43
        Me.btnVolver.TabStop = False
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnNuevoPago
        '
        Me.btnNuevoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoPago.FlatAppearance.BorderSize = 0
        Me.btnNuevoPago.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPago.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoPago.Location = New System.Drawing.Point(497, 24)
        Me.btnNuevoPago.Name = "btnNuevoPago"
        Me.btnNuevoPago.Size = New System.Drawing.Size(88, 26)
        Me.btnNuevoPago.TabIndex = 40
        Me.btnNuevoPago.Text = "NUEVO"
        Me.btnNuevoPago.UseVisualStyleBackColor = True
        '
        'btnEliminarPago
        '
        Me.btnEliminarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarPago.FlatAppearance.BorderSize = 0
        Me.btnEliminarPago.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPago.ForeColor = System.Drawing.Color.Black
        Me.btnEliminarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarPago.Location = New System.Drawing.Point(497, 90)
        Me.btnEliminarPago.Name = "btnEliminarPago"
        Me.btnEliminarPago.Size = New System.Drawing.Size(88, 26)
        Me.btnEliminarPago.TabIndex = 42
        Me.btnEliminarPago.TabStop = False
        Me.btnEliminarPago.Text = "ELIMINAR"
        Me.btnEliminarPago.UseVisualStyleBackColor = True
        '
        'btnModificarPago
        '
        Me.btnModificarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarPago.FlatAppearance.BorderSize = 0
        Me.btnModificarPago.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPago.ForeColor = System.Drawing.Color.Black
        Me.btnModificarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPago.Location = New System.Drawing.Point(497, 58)
        Me.btnModificarPago.Name = "btnModificarPago"
        Me.btnModificarPago.Size = New System.Drawing.Size(88, 26)
        Me.btnModificarPago.TabIndex = 41
        Me.btnModificarPago.TabStop = False
        Me.btnModificarPago.Text = "MODIFICAR"
        Me.btnModificarPago.UseVisualStyleBackColor = True
        '
        'dgvPago
        '
        Me.dgvPago.AllowUserToAddRows = False
        Me.dgvPago.AllowUserToDeleteRows = False
        Me.dgvPago.AllowUserToResizeColumns = False
        Me.dgvPago.AllowUserToResizeRows = False
        Me.dgvPago.BackgroundColor = System.Drawing.Color.White
        Me.dgvPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPago.ColumnHeadersHeight = 20
        Me.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdPago, Me.OrigenId, Me.NumeroComprobante, Me.NroOperacion, Me.MetodoPagoId, Me.MedioDePago, Me.FechaPago, Me.ImporteTotal, Me.ImporteCancelado, Me.ImporteDetraccion, Me.ImporteIGV})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPago.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPago.EnableHeadersVisualStyles = False
        Me.dgvPago.Location = New System.Drawing.Point(17, 24)
        Me.dgvPago.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPago.Name = "dgvPago"
        Me.dgvPago.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPago.RowHeadersVisible = False
        Me.dgvPago.RowHeadersWidth = 22
        Me.dgvPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPago.RowTemplate.Height = 18
        Me.dgvPago.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPago.Size = New System.Drawing.Size(468, 135)
        Me.dgvPago.TabIndex = 470
        Me.dgvPago.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'IdPago
        '
        Me.IdPago.DataPropertyName = "IdPago"
        Me.IdPago.HeaderText = "IdPago"
        Me.IdPago.Name = "IdPago"
        Me.IdPago.ReadOnly = True
        Me.IdPago.Visible = False
        '
        'OrigenId
        '
        Me.OrigenId.DataPropertyName = "OrigenId"
        Me.OrigenId.HeaderText = "OrigenId"
        Me.OrigenId.Name = "OrigenId"
        Me.OrigenId.ReadOnly = True
        Me.OrigenId.Visible = False
        '
        'NumeroComprobante
        '
        Me.NumeroComprobante.DataPropertyName = "NumeroComprobante"
        Me.NumeroComprobante.HeaderText = "NUMERO OPERACION"
        Me.NumeroComprobante.Name = "NumeroComprobante"
        Me.NumeroComprobante.ReadOnly = True
        Me.NumeroComprobante.Width = 117
        '
        'NroOperacion
        '
        Me.NroOperacion.DataPropertyName = "NroOperacion"
        Me.NroOperacion.HeaderText = "NRO OPERACION"
        Me.NroOperacion.Name = "NroOperacion"
        Me.NroOperacion.ReadOnly = True
        Me.NroOperacion.Visible = False
        '
        'MetodoPagoId
        '
        Me.MetodoPagoId.DataPropertyName = "MetodoPagoId"
        Me.MetodoPagoId.HeaderText = "MetodoPagoId"
        Me.MetodoPagoId.Name = "MetodoPagoId"
        Me.MetodoPagoId.ReadOnly = True
        Me.MetodoPagoId.Visible = False
        '
        'MedioDePago
        '
        Me.MedioDePago.DataPropertyName = "MedioDePago"
        Me.MedioDePago.HeaderText = "MEDIO DE PAGO"
        Me.MedioDePago.Name = "MedioDePago"
        Me.MedioDePago.ReadOnly = True
        Me.MedioDePago.Width = 115
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaPago"
        Me.FechaPago.HeaderText = "FECHA COBRO"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.Width = 90
        '
        'ImporteTotal
        '
        Me.ImporteTotal.DataPropertyName = "ImporteTotal"
        Me.ImporteTotal.HeaderText = "ImporteTotal"
        Me.ImporteTotal.Name = "ImporteTotal"
        Me.ImporteTotal.ReadOnly = True
        Me.ImporteTotal.Visible = False
        '
        'ImporteCancelado
        '
        Me.ImporteCancelado.DataPropertyName = "ImporteCancelado"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ImporteCancelado.DefaultCellStyle = DataGridViewCellStyle8
        Me.ImporteCancelado.HeaderText = "IMPORTE PAGO"
        Me.ImporteCancelado.Name = "ImporteCancelado"
        Me.ImporteCancelado.ReadOnly = True
        '
        'ImporteDetraccion
        '
        Me.ImporteDetraccion.DataPropertyName = "ImporteDetraccion"
        Me.ImporteDetraccion.HeaderText = "ImporteDetraccion"
        Me.ImporteDetraccion.Name = "ImporteDetraccion"
        Me.ImporteDetraccion.ReadOnly = True
        Me.ImporteDetraccion.Visible = False
        '
        'ImporteIGV
        '
        Me.ImporteIGV.DataPropertyName = "ImporteIGV"
        Me.ImporteIGV.HeaderText = "ImporteIGV"
        Me.ImporteIGV.Name = "ImporteIGV"
        Me.ImporteIGV.ReadOnly = True
        Me.ImporteIGV.Visible = False
        '
        'PanelEgreso
        '
        Me.PanelEgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelEgreso.Controls.Add(Me.chkIGV)
        Me.PanelEgreso.Controls.Add(Me.lblGrupoEgreso)
        Me.PanelEgreso.Controls.Add(Me.cboGrupoEgreso)
        Me.PanelEgreso.Controls.Add(Me.Label1)
        Me.PanelEgreso.Controls.Add(Me.cboSubGrupoEgreso)
        Me.PanelEgreso.Controls.Add(Me.lblTipoIngreso)
        Me.PanelEgreso.Controls.Add(Me.txtNumeroComprobanteEgreso)
        Me.PanelEgreso.Controls.Add(Me.lblNumeroComprobanteIngreso)
        Me.PanelEgreso.Controls.Add(Me.cboPeriodo)
        Me.PanelEgreso.Controls.Add(Me.Label16)
        Me.PanelEgreso.Controls.Add(Me.cboProveedor)
        Me.PanelEgreso.Controls.Add(Me.Label17)
        Me.PanelEgreso.Controls.Add(Me.btnAbrir)
        Me.PanelEgreso.Controls.Add(Me.dtpFechaIngreso)
        Me.PanelEgreso.Controls.Add(Me.btnAdjuntarArchivo)
        Me.PanelEgreso.Controls.Add(Me.Label18)
        Me.PanelEgreso.Controls.Add(Me.txtImporteProvisional)
        Me.PanelEgreso.Controls.Add(Me.txtComprobanteUbicacion)
        Me.PanelEgreso.Controls.Add(Me.Label20)
        Me.PanelEgreso.Controls.Add(Me.Label4)
        Me.PanelEgreso.Controls.Add(Me.txtComentario)
        Me.PanelEgreso.Controls.Add(Me.Label13)
        Me.PanelEgreso.Controls.Add(Me.btnGuardar)
        Me.PanelEgreso.Controls.Add(Me.btnCancelar)
        Me.PanelEgreso.Controls.Add(Me.txtIdEgreso)
        Me.PanelEgreso.Location = New System.Drawing.Point(16, 266)
        Me.PanelEgreso.Name = "PanelEgreso"
        Me.PanelEgreso.Size = New System.Drawing.Size(597, 181)
        Me.PanelEgreso.TabIndex = 483
        '
        'chkIGV
        '
        Me.chkIGV.AutoSize = True
        Me.chkIGV.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIGV.Location = New System.Drawing.Point(410, 101)
        Me.chkIGV.Name = "chkIGV"
        Me.chkIGV.Size = New System.Drawing.Size(79, 17)
        Me.chkIGV.TabIndex = 20
        Me.chkIGV.Text = "Aplicar IGV"
        Me.chkIGV.UseVisualStyleBackColor = True
        '
        'lblGrupoEgreso
        '
        Me.lblGrupoEgreso.AutoSize = True
        Me.lblGrupoEgreso.Location = New System.Drawing.Point(13, 10)
        Me.lblGrupoEgreso.Name = "lblGrupoEgreso"
        Me.lblGrupoEgreso.Size = New System.Drawing.Size(64, 13)
        Me.lblGrupoEgreso.TabIndex = 489
        Me.lblGrupoEgreso.Text = "Tipo Egreso"
        '
        'cboGrupoEgreso
        '
        Me.cboGrupoEgreso.FormattingEnabled = True
        Me.cboGrupoEgreso.Location = New System.Drawing.Point(121, 7)
        Me.cboGrupoEgreso.Name = "cboGrupoEgreso"
        Me.cboGrupoEgreso.Size = New System.Drawing.Size(226, 21)
        Me.cboGrupoEgreso.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 487
        Me.Label1.Text = "(Sin IGV)"
        '
        'cboSubGrupoEgreso
        '
        Me.cboSubGrupoEgreso.FormattingEnabled = True
        Me.cboSubGrupoEgreso.Location = New System.Drawing.Point(121, 32)
        Me.cboSubGrupoEgreso.Name = "cboSubGrupoEgreso"
        Me.cboSubGrupoEgreso.Size = New System.Drawing.Size(227, 21)
        Me.cboSubGrupoEgreso.TabIndex = 12
        '
        'lblTipoIngreso
        '
        Me.lblTipoIngreso.AutoSize = True
        Me.lblTipoIngreso.Location = New System.Drawing.Point(13, 35)
        Me.lblTipoIngreso.Name = "lblTipoIngreso"
        Me.lblTipoIngreso.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoIngreso.TabIndex = 485
        Me.lblTipoIngreso.Text = "Item Egreso"
        '
        'txtNumeroComprobanteEgreso
        '
        Me.txtNumeroComprobanteEgreso.Location = New System.Drawing.Point(120, 156)
        Me.txtNumeroComprobanteEgreso.Name = "txtNumeroComprobanteEgreso"
        Me.txtNumeroComprobanteEgreso.Size = New System.Drawing.Size(163, 20)
        Me.txtNumeroComprobanteEgreso.TabIndex = 16
        '
        'lblNumeroComprobanteIngreso
        '
        Me.lblNumeroComprobanteIngreso.AutoSize = True
        Me.lblNumeroComprobanteIngreso.Location = New System.Drawing.Point(14, 158)
        Me.lblNumeroComprobanteIngreso.Name = "lblNumeroComprobanteIngreso"
        Me.lblNumeroComprobanteIngreso.Size = New System.Drawing.Size(99, 13)
        Me.lblNumeroComprobanteIngreso.TabIndex = 483
        Me.lblNumeroComprobanteIngreso.Text = "Nº de comprobante"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(499, 7)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(85, 21)
        Me.cboPeriodo.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(407, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "Periodo"
        '
        'cboProveedor
        '
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(121, 57)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(228, 21)
        Me.cboProveedor.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(407, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 470
        Me.Label17.Text = "Fecha Emision"
        '
        'btnAbrir
        '
        Me.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrir.Location = New System.Drawing.Point(220, 127)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(63, 26)
        Me.btnAbrir.TabIndex = 482
        Me.btnAbrir.TabStop = False
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(499, 35)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaIngreso.TabIndex = 18
        '
        'btnAdjuntarArchivo
        '
        Me.btnAdjuntarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdjuntarArchivo.Location = New System.Drawing.Point(120, 127)
        Me.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo"
        Me.btnAdjuntarArchivo.Size = New System.Drawing.Size(94, 26)
        Me.btnAdjuntarArchivo.TabIndex = 15
        Me.btnAdjuntarArchivo.Text = "Adjuntar Archivo"
        Me.btnAdjuntarArchivo.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 468
        Me.Label18.Text = "Proveedor"
        '
        'txtImporteProvisional
        '
        Me.txtImporteProvisional.Location = New System.Drawing.Point(499, 61)
        Me.txtImporteProvisional.Name = "txtImporteProvisional"
        Me.txtImporteProvisional.Size = New System.Drawing.Size(84, 20)
        Me.txtImporteProvisional.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(407, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 13)
        Me.Label20.TabIndex = 464
        Me.Label20.Text = "Importe Facturado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "Comprobante"
        '
        'txtComentario
        '
        Me.txtComentario.AllowClear = True
        Me.txtComentario.AllowNegatives = False
        Me.txtComentario.AllowWhiteSpaces = True
        Me.txtComentario.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComentario.BackColorIdle = System.Drawing.Color.Empty
        Me.txtComentario.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtComentario.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtComentario.EnterIsTab = True
        Me.txtComentario.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtComentario.Label = "Descripción"
        Me.txtComentario.Location = New System.Drawing.Point(121, 82)
        Me.txtComentario.Mandatory = False
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtComentario.MaxLength = 100
        Me.txtComentario.MinLength = 0
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Precision = 0
        Me.txtComentario.SelectOnFocus = True
        Me.txtComentario.Size = New System.Drawing.Size(228, 41)
        Me.txtComentario.Symbol = Nothing
        Me.txtComentario.TabIndex = 14
        Me.txtComentario.Value = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 461
        Me.Label13.Text = "Comentario"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(436, 145)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 26)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(515, 145)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdEgreso
        '
        Me.txtIdEgreso.AllowClear = True
        Me.txtIdEgreso.AllowNegatives = False
        Me.txtIdEgreso.AllowWhiteSpaces = True
        Me.txtIdEgreso.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdEgreso.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdEgreso.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdEgreso.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdEgreso.EnterIsTab = True
        Me.txtIdEgreso.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdEgreso.Label = "Descripción"
        Me.txtIdEgreso.Location = New System.Drawing.Point(455, 149)
        Me.txtIdEgreso.Mandatory = False
        Me.txtIdEgreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdEgreso.MaxLength = 100
        Me.txtIdEgreso.MinLength = 0
        Me.txtIdEgreso.Name = "txtIdEgreso"
        Me.txtIdEgreso.Precision = 0
        Me.txtIdEgreso.SelectOnFocus = True
        Me.txtIdEgreso.Size = New System.Drawing.Size(26, 20)
        Me.txtIdEgreso.Symbol = Nothing
        Me.txtIdEgreso.TabIndex = 460
        Me.txtIdEgreso.Value = Nothing
        '
        'btnVerDeudas
        '
        Me.btnVerDeudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerDeudas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDeudas.FlatAppearance.BorderSize = 0
        Me.btnVerDeudas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDeudas.ForeColor = System.Drawing.Color.Black
        Me.btnVerDeudas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDeudas.Location = New System.Drawing.Point(160, 14)
        Me.btnVerDeudas.Name = "btnVerDeudas"
        Me.btnVerDeudas.Size = New System.Drawing.Size(60, 26)
        Me.btnVerDeudas.TabIndex = 2
        Me.btnVerDeudas.Text = "TODOS"
        Me.btnVerDeudas.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "item"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Width = 35
        '
        'IdEgreso
        '
        Me.IdEgreso.DataPropertyName = "IdEgreso"
        Me.IdEgreso.HeaderText = "IdEgreso"
        Me.IdEgreso.Name = "IdEgreso"
        Me.IdEgreso.ReadOnly = True
        Me.IdEgreso.Visible = False
        '
        'GrupoEgresoId
        '
        Me.GrupoEgresoId.DataPropertyName = "GrupoEgresoId"
        Me.GrupoEgresoId.HeaderText = "GrupoEgresoId"
        Me.GrupoEgresoId.Name = "GrupoEgresoId"
        Me.GrupoEgresoId.ReadOnly = True
        Me.GrupoEgresoId.Visible = False
        '
        'GrupoEgresoDescripcion
        '
        Me.GrupoEgresoDescripcion.DataPropertyName = "GrupoEgresoDescripcion"
        Me.GrupoEgresoDescripcion.HeaderText = "TIPO EGRESO"
        Me.GrupoEgresoDescripcion.Name = "GrupoEgresoDescripcion"
        Me.GrupoEgresoDescripcion.ReadOnly = True
        Me.GrupoEgresoDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrupoEgresoDescripcion.Visible = False
        '
        'SubGrupoEgresoId
        '
        Me.SubGrupoEgresoId.DataPropertyName = "SubGrupoEgresoId"
        Me.SubGrupoEgresoId.HeaderText = "SubGrupoEgresoId"
        Me.SubGrupoEgresoId.Name = "SubGrupoEgresoId"
        Me.SubGrupoEgresoId.ReadOnly = True
        Me.SubGrupoEgresoId.Visible = False
        '
        'SubGrupoEgresoDescripcion
        '
        Me.SubGrupoEgresoDescripcion.DataPropertyName = "SubGrupoEgresoDescripcion"
        Me.SubGrupoEgresoDescripcion.HeaderText = "ITEM EGRESO"
        Me.SubGrupoEgresoDescripcion.Name = "SubGrupoEgresoDescripcion"
        Me.SubGrupoEgresoDescripcion.ReadOnly = True
        Me.SubGrupoEgresoDescripcion.Width = 130
        '
        'ProveedorId
        '
        Me.ProveedorId.DataPropertyName = "ProveedorId"
        Me.ProveedorId.HeaderText = "ProveedorId"
        Me.ProveedorId.Name = "ProveedorId"
        Me.ProveedorId.ReadOnly = True
        Me.ProveedorId.Visible = False
        '
        'NombreComercial
        '
        Me.NombreComercial.DataPropertyName = "NombreComercial"
        Me.NombreComercial.HeaderText = "PROVEEDOR"
        Me.NombreComercial.Name = "NombreComercial"
        Me.NombreComercial.ReadOnly = True
        Me.NombreComercial.Width = 160
        '
        'NumeroComprobanteIngreso
        '
        Me.NumeroComprobanteIngreso.DataPropertyName = "NumeroComprobanteEgreso"
        Me.NumeroComprobanteIngreso.HeaderText = "FACTURA"
        Me.NumeroComprobanteIngreso.Name = "NumeroComprobanteIngreso"
        Me.NumeroComprobanteIngreso.ReadOnly = True
        Me.NumeroComprobanteIngreso.Width = 85
        '
        'IGV
        '
        Me.IGV.DataPropertyName = "IGV"
        Me.IGV.HeaderText = "IGV"
        Me.IGV.Name = "IGV"
        Me.IGV.ReadOnly = True
        Me.IGV.Visible = False
        '
        'PeriodoId
        '
        Me.PeriodoId.DataPropertyName = "PeriodoId"
        Me.PeriodoId.HeaderText = "PeriodoId"
        Me.PeriodoId.Name = "PeriodoId"
        Me.PeriodoId.ReadOnly = True
        Me.PeriodoId.Visible = False
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "Comentario"
        Me.Comentario.HeaderText = "Comentario"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.ReadOnly = True
        Me.Comentario.Visible = False
        '
        'FechaIngresoProvision
        '
        Me.FechaIngresoProvision.DataPropertyName = "FechaEgresoProvision"
        Me.FechaIngresoProvision.HeaderText = "FECHA EMISION"
        Me.FechaIngresoProvision.Name = "FechaIngresoProvision"
        Me.FechaIngresoProvision.ReadOnly = True
        '
        'ImporteProvision
        '
        Me.ImporteProvision.DataPropertyName = "ImporteProvision"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.ImporteProvision.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteProvision.HeaderText = "SUBTOTAL"
        Me.ImporteProvision.Name = "ImporteProvision"
        Me.ImporteProvision.ReadOnly = True
        Me.ImporteProvision.Width = 70
        '
        'ComprobanteUbicacion
        '
        Me.ComprobanteUbicacion.DataPropertyName = "ComprobanteUbicacion"
        Me.ComprobanteUbicacion.HeaderText = "ComprobanteUbicacion"
        Me.ComprobanteUbicacion.Name = "ComprobanteUbicacion"
        Me.ComprobanteUbicacion.ReadOnly = True
        Me.ComprobanteUbicacion.Visible = False
        '
        'Deuda
        '
        Me.Deuda.DataPropertyName = "Deuda"
        Me.Deuda.HeaderText = "Deuda"
        Me.Deuda.Name = "Deuda"
        Me.Deuda.ReadOnly = True
        Me.Deuda.Visible = False
        '
        'FormEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 611)
        Me.Controls.Add(Me.PanelRegistroPago)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.dgvEgreso)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnVerDeudas)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PanelPago)
        Me.Controls.Add(Me.PanelEgreso)
        Me.MaximumSize = New System.Drawing.Size(645, 650)
        Me.MinimumSize = New System.Drawing.Size(645, 290)
        Me.Name = "FormEgreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Egreso"
        CType(Me.dgvEgreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegistroPago.ResumeLayout(False)
        Me.PanelRegistroPago.PerformLayout()
        Me.PanelPago.ResumeLayout(False)
        CType(Me.dgvPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEgreso.ResumeLayout(False)
        Me.PanelEgreso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnPagar As Button
    Friend WithEvents dgvEgreso As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PanelRegistroPago As Panel
    Friend WithEvents lbNroOperacion As Label
    Friend WithEvents txtNroOperacion As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtIGV As TextBox
    Friend WithEvents lblIGV As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtNumeroComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbMetodoPago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblImporteCancelado As Label
    Private WithEvents btnGuardarPago As Button
    Friend WithEvents btnCancelarPago As Button
    Friend WithEvents txtIdPago As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtComprobanteUbicacion As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtRespaldoImporte As TextBox
    Friend WithEvents PanelPago As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnNuevoPago As Button
    Friend WithEvents btnEliminarPago As Button
    Friend WithEvents btnModificarPago As Button
    Friend WithEvents dgvPago As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents PanelEgreso As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSubGrupoEgreso As ComboBox
    Friend WithEvents lblTipoIngreso As Label
    Friend WithEvents txtNumeroComprobanteEgreso As TextBox
    Friend WithEvents lblNumeroComprobanteIngreso As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents Label17 As Label
    Private WithEvents btnAbrir As Button
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Private WithEvents btnAdjuntarArchivo As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtImporteProvisional As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComentario As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label13 As Label
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdEgreso As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblGrupoEgreso As Label
    Friend WithEvents cboGrupoEgreso As ComboBox
    Friend WithEvents chkIGV As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdPago As DataGridViewTextBoxColumn
    Friend WithEvents OrigenId As DataGridViewTextBoxColumn
    Friend WithEvents NumeroComprobante As DataGridViewTextBoxColumn
    Friend WithEvents NroOperacion As DataGridViewTextBoxColumn
    Friend WithEvents MetodoPagoId As DataGridViewTextBoxColumn
    Friend WithEvents MedioDePago As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotal As DataGridViewTextBoxColumn
    Friend WithEvents ImporteCancelado As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDetraccion As DataGridViewTextBoxColumn
    Friend WithEvents ImporteIGV As DataGridViewTextBoxColumn
    Friend WithEvents btnVerDeudas As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdEgreso As DataGridViewTextBoxColumn
    Friend WithEvents GrupoEgresoId As DataGridViewTextBoxColumn
    Friend WithEvents GrupoEgresoDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents SubGrupoEgresoId As DataGridViewTextBoxColumn
    Friend WithEvents SubGrupoEgresoDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorId As DataGridViewTextBoxColumn
    Friend WithEvents NombreComercial As DataGridViewTextBoxColumn
    Friend WithEvents NumeroComprobanteIngreso As DataGridViewTextBoxColumn
    Friend WithEvents IGV As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoId As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoProvision As DataGridViewTextBoxColumn
    Friend WithEvents ImporteProvision As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents Deuda As DataGridViewTextBoxColumn
End Class
