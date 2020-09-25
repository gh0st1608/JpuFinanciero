<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProveedor = New PersControlLibrary.ExtendedDataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboMedicionId = New System.Windows.Forms.ComboBox()
        Me.lblTarifa = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New PersControlLibrary.ExtendedTextBox()
        Me.lblMedicion = New System.Windows.Forms.Label()
        Me.txtTarifa = New PersControlLibrary.ExtendedTextBox()
        Me.lblNumeroContacto = New System.Windows.Forms.Label()
        Me.txtNumeroContacto = New PersControlLibrary.ExtendedTextBox()
        Me.lblNombreComercial = New System.Windows.Forms.Label()
        Me.txtNombreComercial = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdProveedor = New PersControlLibrary.ExtendedTextBox()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMedicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.AllowUserToResizeColumns = False
        Me.dgvProveedor.AllowUserToResizeRows = False
        Me.dgvProveedor.BackgroundColor = System.Drawing.Color.White
        Me.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProveedor.ColumnHeadersHeight = 32
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdProveedor, Me.NombreComercial, Me.RazonSocial, Me.NumeroContacto, Me.MedicionId, Me.TipoMedicion, Me.Tarifa, Me.IdEstadoActivo, Me.EstadoActivo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProveedor.EnableHeadersVisualStyles = False
        Me.dgvProveedor.Location = New System.Drawing.Point(14, 47)
        Me.dgvProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProveedor.RowHeadersVisible = False
        Me.dgvProveedor.RowHeadersWidth = 22
        Me.dgvProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProveedor.RowTemplate.Height = 18
        Me.dgvProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(536, 216)
        Me.dgvProveedor.TabIndex = 462
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(453, 12)
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
        Me.btnModificar.Location = New System.Drawing.Point(350, 12)
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
        Me.btnNuevo.Location = New System.Drawing.Point(269, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 459
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbEstado)
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.cboMedicionId)
        Me.Panel1.Controls.Add(Me.lblTarifa)
        Me.Panel1.Controls.Add(Me.lblRazonSocial)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.lblMedicion)
        Me.Panel1.Controls.Add(Me.txtTarifa)
        Me.Panel1.Controls.Add(Me.lblNumeroContacto)
        Me.Panel1.Controls.Add(Me.txtNumeroContacto)
        Me.Panel1.Controls.Add(Me.lblNombreComercial)
        Me.Panel1.Controls.Add(Me.txtNombreComercial)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtIdProveedor)
        Me.Panel1.Location = New System.Drawing.Point(14, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 169)
        Me.Panel1.TabIndex = 458
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(14, 140)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 471
        Me.lbEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cboEstado.Location = New System.Drawing.Point(123, 133)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 470
        '
        'cboMedicionId
        '
        Me.cboMedicionId.FormattingEnabled = True
        Me.cboMedicionId.Location = New System.Drawing.Point(123, 83)
        Me.cboMedicionId.Name = "cboMedicionId"
        Me.cboMedicionId.Size = New System.Drawing.Size(397, 21)
        Me.cboMedicionId.TabIndex = 469
        '
        'lblTarifa
        '
        Me.lblTarifa.AutoSize = True
        Me.lblTarifa.Location = New System.Drawing.Point(14, 111)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(36, 13)
        Me.lblTarifa.TabIndex = 468
        Me.lblTarifa.Text = "Tarífa"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(14, 38)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(70, 13)
        Me.lblRazonSocial.TabIndex = 467
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.AllowClear = True
        Me.txtRazonSocial.AllowNegatives = False
        Me.txtRazonSocial.AllowWhiteSpaces = True
        Me.txtRazonSocial.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRazonSocial.BackColorIdle = System.Drawing.Color.Empty
        Me.txtRazonSocial.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtRazonSocial.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtRazonSocial.EnterIsTab = True
        Me.txtRazonSocial.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtRazonSocial.Label = "Descripción"
        Me.txtRazonSocial.Location = New System.Drawing.Point(123, 34)
        Me.txtRazonSocial.Mandatory = False
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.MinLength = 0
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Precision = 0
        Me.txtRazonSocial.SelectOnFocus = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(397, 20)
        Me.txtRazonSocial.Symbol = Nothing
        Me.txtRazonSocial.TabIndex = 466
        Me.txtRazonSocial.Value = Nothing
        '
        'lblMedicion
        '
        Me.lblMedicion.AutoSize = True
        Me.lblMedicion.Location = New System.Drawing.Point(14, 86)
        Me.lblMedicion.Name = "lblMedicion"
        Me.lblMedicion.Size = New System.Drawing.Size(50, 13)
        Me.lblMedicion.TabIndex = 465
        Me.lblMedicion.Text = "Medición"
        '
        'txtTarifa
        '
        Me.txtTarifa.AllowClear = True
        Me.txtTarifa.AllowNegatives = False
        Me.txtTarifa.AllowWhiteSpaces = True
        Me.txtTarifa.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTarifa.BackColorIdle = System.Drawing.Color.Empty
        Me.txtTarifa.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtTarifa.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtTarifa.EnterIsTab = True
        Me.txtTarifa.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtTarifa.Label = "Descripción"
        Me.txtTarifa.Location = New System.Drawing.Point(123, 108)
        Me.txtTarifa.Mandatory = False
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTarifa.MaxLength = 100
        Me.txtTarifa.MinLength = 0
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Precision = 0
        Me.txtTarifa.SelectOnFocus = True
        Me.txtTarifa.Size = New System.Drawing.Size(397, 20)
        Me.txtTarifa.Symbol = Nothing
        Me.txtTarifa.TabIndex = 464
        Me.txtTarifa.Value = Nothing
        '
        'lblNumeroContacto
        '
        Me.lblNumeroContacto.AutoSize = True
        Me.lblNumeroContacto.Location = New System.Drawing.Point(14, 62)
        Me.lblNumeroContacto.Name = "lblNumeroContacto"
        Me.lblNumeroContacto.Size = New System.Drawing.Size(104, 13)
        Me.lblNumeroContacto.TabIndex = 463
        Me.lblNumeroContacto.Text = "Número de contacto"
        '
        'txtNumeroContacto
        '
        Me.txtNumeroContacto.AllowClear = True
        Me.txtNumeroContacto.AllowNegatives = False
        Me.txtNumeroContacto.AllowWhiteSpaces = True
        Me.txtNumeroContacto.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumeroContacto.BackColorIdle = System.Drawing.Color.Empty
        Me.txtNumeroContacto.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtNumeroContacto.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtNumeroContacto.EnterIsTab = True
        Me.txtNumeroContacto.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtNumeroContacto.Label = "Descripción"
        Me.txtNumeroContacto.Location = New System.Drawing.Point(123, 58)
        Me.txtNumeroContacto.Mandatory = False
        Me.txtNumeroContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroContacto.MaxLength = 100
        Me.txtNumeroContacto.MinLength = 0
        Me.txtNumeroContacto.Name = "txtNumeroContacto"
        Me.txtNumeroContacto.Precision = 0
        Me.txtNumeroContacto.SelectOnFocus = True
        Me.txtNumeroContacto.Size = New System.Drawing.Size(397, 20)
        Me.txtNumeroContacto.Symbol = Nothing
        Me.txtNumeroContacto.TabIndex = 462
        Me.txtNumeroContacto.Value = Nothing
        '
        'lblNombreComercial
        '
        Me.lblNombreComercial.AutoSize = True
        Me.lblNombreComercial.Location = New System.Drawing.Point(14, 14)
        Me.lblNombreComercial.Name = "lblNombreComercial"
        Me.lblNombreComercial.Size = New System.Drawing.Size(93, 13)
        Me.lblNombreComercial.TabIndex = 461
        Me.lblNombreComercial.Text = "Nombre Comercial"
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.AllowClear = True
        Me.txtNombreComercial.AllowNegatives = False
        Me.txtNombreComercial.AllowWhiteSpaces = True
        Me.txtNombreComercial.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreComercial.BackColorIdle = System.Drawing.Color.Empty
        Me.txtNombreComercial.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtNombreComercial.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtNombreComercial.EnterIsTab = True
        Me.txtNombreComercial.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtNombreComercial.Label = "Descripción"
        Me.txtNombreComercial.Location = New System.Drawing.Point(123, 10)
        Me.txtNombreComercial.Mandatory = False
        Me.txtNombreComercial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreComercial.MaxLength = 100
        Me.txtNombreComercial.MinLength = 0
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Precision = 0
        Me.txtNombreComercial.SelectOnFocus = True
        Me.txtNombreComercial.Size = New System.Drawing.Size(397, 20)
        Me.txtNombreComercial.Symbol = Nothing
        Me.txtNombreComercial.TabIndex = 458
        Me.txtNombreComercial.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(372, 133)
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
        Me.btnCancelar.Location = New System.Drawing.Point(451, 133)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 409
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.AllowClear = True
        Me.txtIdProveedor.AllowNegatives = False
        Me.txtIdProveedor.AllowWhiteSpaces = True
        Me.txtIdProveedor.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdProveedor.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdProveedor.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdProveedor.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdProveedor.EnterIsTab = True
        Me.txtIdProveedor.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdProveedor.Label = "Descripción"
        Me.txtIdProveedor.Location = New System.Drawing.Point(401, 137)
        Me.txtIdProveedor.Mandatory = False
        Me.txtIdProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdProveedor.MaxLength = 100
        Me.txtIdProveedor.MinLength = 0
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Precision = 0
        Me.txtIdProveedor.SelectOnFocus = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(26, 20)
        Me.txtIdProveedor.Symbol = Nothing
        Me.txtIdProveedor.TabIndex = 460
        Me.txtIdProveedor.Value = Nothing
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
        'IdProveedor
        '
        Me.IdProveedor.DataPropertyName = "IdProveedor"
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.ReadOnly = True
        Me.IdProveedor.Visible = False
        '
        'NombreComercial
        '
        Me.NombreComercial.DataPropertyName = "NombreComercial"
        Me.NombreComercial.HeaderText = "NOMBRE COMERCIAL"
        Me.NombreComercial.Name = "NombreComercial"
        Me.NombreComercial.ReadOnly = True
        Me.NombreComercial.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombreComercial.Width = 320
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.HeaderText = "RazonSocial"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        Me.RazonSocial.Visible = False
        '
        'NumeroContacto
        '
        Me.NumeroContacto.DataPropertyName = "NumeroContacto"
        Me.NumeroContacto.HeaderText = "NUMERO DE CONTACTO"
        Me.NumeroContacto.Name = "NumeroContacto"
        Me.NumeroContacto.ReadOnly = True
        Me.NumeroContacto.Width = 120
        '
        'MedicionId
        '
        Me.MedicionId.DataPropertyName = "MedicionId"
        Me.MedicionId.HeaderText = "MedicionId"
        Me.MedicionId.Name = "MedicionId"
        Me.MedicionId.ReadOnly = True
        Me.MedicionId.Visible = False
        '
        'TipoMedicion
        '
        Me.TipoMedicion.DataPropertyName = "TipoMedicion"
        Me.TipoMedicion.HeaderText = "MEDICION"
        Me.TipoMedicion.Name = "TipoMedicion"
        Me.TipoMedicion.ReadOnly = True
        '
        'Tarifa
        '
        Me.Tarifa.DataPropertyName = "Tarifa"
        Me.Tarifa.HeaderText = "Tarifa"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        Me.Tarifa.Visible = False
        '
        'IdEstadoActivo
        '
        Me.IdEstadoActivo.DataPropertyName = "IdEstadoActivo"
        Me.IdEstadoActivo.HeaderText = "IdEstadoActivo"
        Me.IdEstadoActivo.Name = "IdEstadoActivo"
        Me.IdEstadoActivo.ReadOnly = True
        Me.IdEstadoActivo.Visible = False
        '
        'EstadoActivo
        '
        Me.EstadoActivo.DataPropertyName = "EstadoActivo"
        Me.EstadoActivo.HeaderText = "ESTADO"
        Me.EstadoActivo.Name = "EstadoActivo"
        Me.EstadoActivo.ReadOnly = True
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 453)
        Me.Controls.Add(Me.dgvProveedor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProveedor"
        Me.Text = "FormProveedor"
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvProveedor As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboMedicionId As ComboBox
    Friend WithEvents lblTarifa As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents txtRazonSocial As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblMedicion As Label
    Friend WithEvents txtTarifa As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblNumeroContacto As Label
    Friend WithEvents txtNumeroContacto As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblNombreComercial As Label
    Friend WithEvents txtNombreComercial As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdProveedor As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents NombreComercial As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents NumeroContacto As DataGridViewTextBoxColumn
    Friend WithEvents MedicionId As DataGridViewTextBoxColumn
    Friend WithEvents TipoMedicion As DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
End Class
