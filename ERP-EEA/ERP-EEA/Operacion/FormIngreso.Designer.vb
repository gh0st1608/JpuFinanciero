<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngreso
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvIngreso = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoIngresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detraccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteProvision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoProvision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PanelIngreso = New System.Windows.Forms.Panel()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.chkDetraccion = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtImporteProvisional = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtComentario = New PersControlLibrary.ExtendedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdIngreso = New PersControlLibrary.ExtendedTextBox()
        Me.cbPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAdjuntarArchivo = New System.Windows.Forms.Button()
        Me.txtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtImporteCancelado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardarPago = New System.Windows.Forms.Button()
        Me.btnCancelarPago = New System.Windows.Forms.Button()
        Me.txtIdPago = New PersControlLibrary.ExtendedTextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.dgvPago = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPagoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedioDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteCancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobanteUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelPago = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnNuevoPago = New System.Windows.Forms.Button()
        Me.btnEliminarPago = New System.Windows.Forms.Button()
        Me.btnModificarPago = New System.Windows.Forms.Button()
        CType(Me.dgvIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIngreso.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvIngreso
        '
        Me.dgvIngreso.AllowUserToAddRows = False
        Me.dgvIngreso.AllowUserToDeleteRows = False
        Me.dgvIngreso.AllowUserToResizeColumns = False
        Me.dgvIngreso.AllowUserToResizeRows = False
        Me.dgvIngreso.BackgroundColor = System.Drawing.Color.White
        Me.dgvIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIngreso.ColumnHeadersHeight = 20
        Me.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdIngreso, Me.GrupoIngresoId, Me.ClienteId, Me.Descripcion, Me.Detraccion, Me.ImporteProvision, Me.PeriodoId, Me.Comentario, Me.FechaIngresoProvision, Me.Deuda})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIngreso.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvIngreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvIngreso.EnableHeadersVisualStyles = False
        Me.dgvIngreso.Location = New System.Drawing.Point(11, 39)
        Me.dgvIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvIngreso.Name = "dgvIngreso"
        Me.dgvIngreso.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvIngreso.RowHeadersVisible = False
        Me.dgvIngreso.RowHeadersWidth = 22
        Me.dgvIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIngreso.RowTemplate.Height = 18
        Me.dgvIngreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIngreso.Size = New System.Drawing.Size(543, 216)
        Me.dgvIngreso.TabIndex = 462
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
        Me.DataGridViewTextBoxColumn7.Width = 25
        '
        'IdIngreso
        '
        Me.IdIngreso.DataPropertyName = "IdIngreso"
        Me.IdIngreso.HeaderText = "IdIngreso"
        Me.IdIngreso.Name = "IdIngreso"
        Me.IdIngreso.ReadOnly = True
        Me.IdIngreso.Visible = False
        '
        'GrupoIngresoId
        '
        Me.GrupoIngresoId.DataPropertyName = "GrupoIngresoId"
        Me.GrupoIngresoId.HeaderText = "GrupoIngresoId"
        Me.GrupoIngresoId.Name = "GrupoIngresoId"
        Me.GrupoIngresoId.ReadOnly = True
        Me.GrupoIngresoId.Visible = False
        '
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "ClienteId"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "CLIENTE"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Detraccion
        '
        Me.Detraccion.DataPropertyName = "Detraccion"
        Me.Detraccion.HeaderText = "Detraccion"
        Me.Detraccion.Name = "Detraccion"
        Me.Detraccion.ReadOnly = True
        Me.Detraccion.Visible = False
        '
        'ImporteProvision
        '
        Me.ImporteProvision.DataPropertyName = "ImporteProvision"
        Me.ImporteProvision.HeaderText = "IMPORTE"
        Me.ImporteProvision.Name = "ImporteProvision"
        Me.ImporteProvision.ReadOnly = True
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
        Me.FechaIngresoProvision.DataPropertyName = "FechaIngresoProvision"
        Me.FechaIngresoProvision.HeaderText = "FECHA"
        Me.FechaIngresoProvision.Name = "FechaIngresoProvision"
        Me.FechaIngresoProvision.ReadOnly = True
        '
        'Deuda
        '
        Me.Deuda.DataPropertyName = "Deuda"
        Me.Deuda.HeaderText = "Deuda"
        Me.Deuda.Name = "Deuda"
        Me.Deuda.ReadOnly = True
        Me.Deuda.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(381, 7)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 461
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "[Supr] ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(278, 7)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 460
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
        Me.btnNuevo.Location = New System.Drawing.Point(197, 7)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 459
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'PanelIngreso
        '
        Me.PanelIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelIngreso.Controls.Add(Me.cbPeriodo)
        Me.PanelIngreso.Controls.Add(Me.chkDetraccion)
        Me.PanelIngreso.Controls.Add(Me.Label16)
        Me.PanelIngreso.Controls.Add(Me.cbCliente)
        Me.PanelIngreso.Controls.Add(Me.Label17)
        Me.PanelIngreso.Controls.Add(Me.dtpFechaIngreso)
        Me.PanelIngreso.Controls.Add(Me.Label18)
        Me.PanelIngreso.Controls.Add(Me.txtImporteProvisional)
        Me.PanelIngreso.Controls.Add(Me.Label20)
        Me.PanelIngreso.Controls.Add(Me.txtComentario)
        Me.PanelIngreso.Controls.Add(Me.Label13)
        Me.PanelIngreso.Controls.Add(Me.btnGuardar)
        Me.PanelIngreso.Controls.Add(Me.btnCancelar)
        Me.PanelIngreso.Controls.Add(Me.txtIdIngreso)
        Me.PanelIngreso.Location = New System.Drawing.Point(12, 271)
        Me.PanelIngreso.Name = "PanelIngreso"
        Me.PanelIngreso.Size = New System.Drawing.Size(542, 135)
        Me.PanelIngreso.TabIndex = 458
        '
        'cbPeriodo
        '
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Location = New System.Drawing.Point(450, 12)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(85, 21)
        Me.cbPeriodo.TabIndex = 475
        '
        'chkDetraccion
        '
        Me.chkDetraccion.AutoSize = True
        Me.chkDetraccion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDetraccion.Location = New System.Drawing.Point(11, 93)
        Me.chkDetraccion.Name = "chkDetraccion"
        Me.chkDetraccion.Size = New System.Drawing.Size(113, 17)
        Me.chkDetraccion.TabIndex = 473
        Me.chkDetraccion.Text = "Aplicar Detracción"
        Me.chkDetraccion.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(369, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "Periodo"
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(109, 13)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(242, 21)
        Me.cbCliente.TabIndex = 471
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(369, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 470
        Me.Label17.Text = "Fecha Ingreso"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(450, 40)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaIngreso.TabIndex = 469
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 468
        Me.Label18.Text = "Nombre Cliente"
        '
        'txtImporteProvisional
        '
        Me.txtImporteProvisional.Location = New System.Drawing.Point(450, 66)
        Me.txtImporteProvisional.Name = "txtImporteProvisional"
        Me.txtImporteProvisional.Size = New System.Drawing.Size(84, 20)
        Me.txtImporteProvisional.TabIndex = 465
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(369, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 464
        Me.Label20.Text = "Importe"
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
        Me.txtComentario.Location = New System.Drawing.Point(109, 41)
        Me.txtComentario.Mandatory = False
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtComentario.MaxLength = 100
        Me.txtComentario.MinLength = 0
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Precision = 0
        Me.txtComentario.SelectOnFocus = True
        Me.txtComentario.Size = New System.Drawing.Size(242, 46)
        Me.txtComentario.Symbol = Nothing
        Me.txtComentario.TabIndex = 458
        Me.txtComentario.Value = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 461
        Me.Label13.Text = "Comentario"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(385, 97)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 26)
        Me.btnGuardar.TabIndex = 410
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
        Me.btnCancelar.Location = New System.Drawing.Point(464, 97)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 409
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdIngreso
        '
        Me.txtIdIngreso.AllowClear = True
        Me.txtIdIngreso.AllowNegatives = False
        Me.txtIdIngreso.AllowWhiteSpaces = True
        Me.txtIdIngreso.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdIngreso.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdIngreso.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdIngreso.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdIngreso.EnterIsTab = True
        Me.txtIdIngreso.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdIngreso.Label = "Descripción"
        Me.txtIdIngreso.Location = New System.Drawing.Point(405, 101)
        Me.txtIdIngreso.Mandatory = False
        Me.txtIdIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdIngreso.MaxLength = 100
        Me.txtIdIngreso.MinLength = 0
        Me.txtIdIngreso.Name = "txtIdIngreso"
        Me.txtIdIngreso.Precision = 0
        Me.txtIdIngreso.SelectOnFocus = True
        Me.txtIdIngreso.Size = New System.Drawing.Size(26, 20)
        Me.txtIdIngreso.Symbol = Nothing
        Me.txtIdIngreso.TabIndex = 460
        Me.txtIdIngreso.Value = Nothing
        '
        'cbPeriodoFiltro
        '
        Me.cbPeriodoFiltro.FormattingEnabled = True
        Me.cbPeriodoFiltro.Location = New System.Drawing.Point(59, 12)
        Me.cbPeriodoFiltro.Name = "cbPeriodoFiltro"
        Me.cbPeriodoFiltro.Size = New System.Drawing.Size(114, 21)
        Me.cbPeriodoFiltro.TabIndex = 465
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 463
        Me.Label23.Text = "Periodo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAdjuntarArchivo)
        Me.Panel2.Controls.Add(Me.txtNumeroComprobante)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cbMetodoPago)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.dtpFechaPago)
        Me.Panel2.Controls.Add(Me.txtImporteCancelado)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnGuardarPago)
        Me.Panel2.Controls.Add(Me.btnCancelarPago)
        Me.Panel2.Controls.Add(Me.txtIdPago)
        Me.Panel2.Location = New System.Drawing.Point(13, 421)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 98)
        Me.Panel2.TabIndex = 467
        '
        'btnAdjuntarArchivo
        '
        Me.btnAdjuntarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdjuntarArchivo.Location = New System.Drawing.Point(120, 6)
        Me.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo"
        Me.btnAdjuntarArchivo.Size = New System.Drawing.Size(162, 26)
        Me.btnAdjuntarArchivo.TabIndex = 480
        Me.btnAdjuntarArchivo.Text = "Adjuntar Archivo"
        Me.btnAdjuntarArchivo.UseVisualStyleBackColor = True
        '
        'txtNumeroComprobante
        '
        Me.txtNumeroComprobante.Location = New System.Drawing.Point(120, 37)
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(163, 20)
        Me.txtNumeroComprobante.TabIndex = 479
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 478
        Me.Label5.Text = "Nº de comprobante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "Comprobante"
        '
        'cbMetodoPago
        '
        Me.cbMetodoPago.FormattingEnabled = True
        Me.cbMetodoPago.Location = New System.Drawing.Point(120, 62)
        Me.cbMetodoPago.Name = "cbMetodoPago"
        Me.cbMetodoPago.Size = New System.Drawing.Size(163, 21)
        Me.cbMetodoPago.TabIndex = 475
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 472
        Me.Label3.Text = "Medio de Pago"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 470
        Me.Label7.Text = "Fecha de Pago"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(417, 11)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaPago.TabIndex = 469
        '
        'txtImporteCancelado
        '
        Me.txtImporteCancelado.Location = New System.Drawing.Point(417, 36)
        Me.txtImporteCancelado.Name = "txtImporteCancelado"
        Me.txtImporteCancelado.Size = New System.Drawing.Size(114, 20)
        Me.txtImporteCancelado.TabIndex = 465
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 464
        Me.Label8.Text = "Importe Cancelado"
        '
        'btnGuardarPago
        '
        Me.btnGuardarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarPago.Location = New System.Drawing.Point(384, 63)
        Me.btnGuardarPago.Name = "btnGuardarPago"
        Me.btnGuardarPago.Size = New System.Drawing.Size(73, 26)
        Me.btnGuardarPago.TabIndex = 410
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
        Me.btnCancelarPago.Location = New System.Drawing.Point(463, 62)
        Me.btnCancelarPago.Name = "btnCancelarPago"
        Me.btnCancelarPago.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelarPago.TabIndex = 409
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
        Me.txtIdPago.Location = New System.Drawing.Point(404, 67)
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
        'btnPagar
        '
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.Black
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(484, 7)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(70, 26)
        Me.btnPagar.TabIndex = 469
        Me.btnPagar.Text = "[F4] PAGAR"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'dgvPago
        '
        Me.dgvPago.AllowUserToAddRows = False
        Me.dgvPago.AllowUserToDeleteRows = False
        Me.dgvPago.AllowUserToResizeColumns = False
        Me.dgvPago.AllowUserToResizeRows = False
        Me.dgvPago.BackgroundColor = System.Drawing.Color.White
        Me.dgvPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPago.ColumnHeadersHeight = 20
        Me.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdPago, Me.OrigenId, Me.NumeroComprobante, Me.MetodoPagoId, Me.MedioDePago, Me.ImporteCancelado, Me.FechaPago, Me.ComprobanteUbicacion, Me.ImporteTotal})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPago.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPago.EnableHeadersVisualStyles = False
        Me.dgvPago.Location = New System.Drawing.Point(5, 5)
        Me.dgvPago.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPago.Name = "dgvPago"
        Me.dgvPago.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPago.RowHeadersVisible = False
        Me.dgvPago.RowHeadersWidth = 22
        Me.dgvPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPago.RowTemplate.Height = 18
        Me.dgvPago.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPago.Size = New System.Drawing.Size(453, 120)
        Me.dgvPago.TabIndex = 470
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.NumeroComprobante.HeaderText = "COMPROBANTE"
        Me.NumeroComprobante.Name = "NumeroComprobante"
        Me.NumeroComprobante.ReadOnly = True
        Me.NumeroComprobante.Width = 117
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
        'ImporteCancelado
        '
        Me.ImporteCancelado.DataPropertyName = "ImporteCancelado"
        Me.ImporteCancelado.HeaderText = "IMPORTE"
        Me.ImporteCancelado.Name = "ImporteCancelado"
        Me.ImporteCancelado.ReadOnly = True
        Me.ImporteCancelado.Width = 88
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaPago"
        Me.FechaPago.HeaderText = "FECHA"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.Width = 90
        '
        'ComprobanteUbicacion
        '
        Me.ComprobanteUbicacion.DataPropertyName = "ComprobanteUbicacion"
        Me.ComprobanteUbicacion.HeaderText = "ComprobanteUbicacion"
        Me.ComprobanteUbicacion.Name = "ComprobanteUbicacion"
        Me.ComprobanteUbicacion.ReadOnly = True
        Me.ComprobanteUbicacion.Visible = False
        '
        'ImporteTotal
        '
        Me.ImporteTotal.DataPropertyName = "ImporteTotal"
        Me.ImporteTotal.HeaderText = "ImporteTotal"
        Me.ImporteTotal.Name = "ImporteTotal"
        Me.ImporteTotal.ReadOnly = True
        Me.ImporteTotal.Visible = False
        '
        'PanelPago
        '
        Me.PanelPago.Controls.Add(Me.btnVolver)
        Me.PanelPago.Controls.Add(Me.btnNuevoPago)
        Me.PanelPago.Controls.Add(Me.dgvPago)
        Me.PanelPago.Controls.Add(Me.btnEliminarPago)
        Me.PanelPago.Controls.Add(Me.btnModificarPago)
        Me.PanelPago.Location = New System.Drawing.Point(12, 271)
        Me.PanelPago.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPago.Name = "PanelPago"
        Me.PanelPago.Size = New System.Drawing.Size(542, 135)
        Me.PanelPago.TabIndex = 471
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Black
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(467, 103)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(69, 26)
        Me.btnVolver.TabIndex = 473
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
        Me.btnNuevoPago.Location = New System.Drawing.Point(467, 5)
        Me.btnNuevoPago.Name = "btnNuevoPago"
        Me.btnNuevoPago.Size = New System.Drawing.Size(69, 26)
        Me.btnNuevoPago.TabIndex = 472
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
        Me.btnEliminarPago.Location = New System.Drawing.Point(467, 71)
        Me.btnEliminarPago.Name = "btnEliminarPago"
        Me.btnEliminarPago.Size = New System.Drawing.Size(69, 26)
        Me.btnEliminarPago.TabIndex = 461
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
        Me.btnModificarPago.Location = New System.Drawing.Point(467, 37)
        Me.btnModificarPago.Name = "btnModificarPago"
        Me.btnModificarPago.Size = New System.Drawing.Size(69, 26)
        Me.btnModificarPago.TabIndex = 460
        Me.btnModificarPago.TabStop = False
        Me.btnModificarPago.Text = "MODIFICAR"
        Me.btnModificarPago.UseVisualStyleBackColor = True
        '
        'FormIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 533)
        Me.Controls.Add(Me.PanelPago)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.dgvIngreso)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.PanelIngreso)
        Me.Name = "FormIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso"
        CType(Me.dgvIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIngreso.ResumeLayout(False)
        Me.PanelIngreso.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPago.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvIngreso As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents PanelIngreso As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtComentario As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdIngreso As PersControlLibrary.ExtendedTextBox
    Friend WithEvents cbPeriodo As ComboBox
    Friend WithEvents chkDetraccion As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents txtImporteProvisional As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel2 As Panel
    Private WithEvents btnAdjuntarArchivo As Button
    Friend WithEvents txtNumeroComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbMetodoPago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents txtImporteCancelado As TextBox
    Friend WithEvents Label8 As Label
    Private WithEvents btnGuardarPago As Button
    Friend WithEvents btnCancelarPago As Button
    Friend WithEvents txtIdPago As PersControlLibrary.ExtendedTextBox
    Friend WithEvents btnPagar As Button
    Friend WithEvents dgvPago As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents PanelPago As Panel
    Friend WithEvents btnNuevoPago As Button
    Friend WithEvents btnEliminarPago As Button
    Friend WithEvents btnModificarPago As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdIngreso As DataGridViewTextBoxColumn
    Friend WithEvents GrupoIngresoId As DataGridViewTextBoxColumn
    Friend WithEvents ClienteId As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Detraccion As DataGridViewTextBoxColumn
    Friend WithEvents ImporteProvision As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoId As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoProvision As DataGridViewTextBoxColumn
    Friend WithEvents Deuda As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdPago As DataGridViewTextBoxColumn
    Friend WithEvents OrigenId As DataGridViewTextBoxColumn
    Friend WithEvents NumeroComprobante As DataGridViewTextBoxColumn
    Friend WithEvents MetodoPagoId As DataGridViewTextBoxColumn
    Friend WithEvents MedioDePago As DataGridViewTextBoxColumn
    Friend WithEvents ImporteCancelado As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotal As DataGridViewTextBoxColumn
End Class
