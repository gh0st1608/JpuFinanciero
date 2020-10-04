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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProveedor = New PersControlLibrary.ExtendedDataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDocumento = New PersControlLibrary.ExtendedTextBox()
        Me.labelDocumento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New PersControlLibrary.ExtendedTextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboMedicion = New System.Windows.Forms.ComboBox()
        Me.lblTarifa = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New PersControlLibrary.ExtendedTextBox()
        Me.lblMedicion = New System.Windows.Forms.Label()
        Me.txtTarifa = New PersControlLibrary.ExtendedTextBox()
        Me.txtNumeroContacto = New PersControlLibrary.ExtendedTextBox()
        Me.lblNombreComercial = New System.Windows.Forms.Label()
        Me.txtNombreComercial = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdProveedor = New PersControlLibrary.ExtendedTextBox()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMedicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProveedor.ColumnHeadersHeight = 20
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdProveedor, Me.Documento, Me.NombreComercial, Me.RazonSocial, Me.NumeroContacto, Me.Correo, Me.MedicionId, Me.TipoMedicion, Me.Tarifa, Me.EstadoActivo, Me.IdEstadoActivo})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedor.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProveedor.EnableHeadersVisualStyles = False
        Me.dgvProveedor.Location = New System.Drawing.Point(11, 46)
        Me.dgvProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvProveedor.RowHeadersVisible = False
        Me.dgvProveedor.RowHeadersWidth = 22
        Me.dgvProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProveedor.RowTemplate.Height = 18
        Me.dgvProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(813, 216)
        Me.dgvProveedor.TabIndex = 467
        Me.dgvProveedor.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(718, 11)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 3
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
        Me.btnModificar.Location = New System.Drawing.Point(615, 11)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 2
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
        Me.btnNuevo.Location = New System.Drawing.Point(534, 11)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtDocumento)
        Me.Panel1.Controls.Add(Me.labelDocumento)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.labelCorreo)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.lbEstado)
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.cboMedicion)
        Me.Panel1.Controls.Add(Me.lblTarifa)
        Me.Panel1.Controls.Add(Me.lblRazonSocial)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.lblMedicion)
        Me.Panel1.Controls.Add(Me.txtTarifa)
        Me.Panel1.Controls.Add(Me.txtNumeroContacto)
        Me.Panel1.Controls.Add(Me.lblNombreComercial)
        Me.Panel1.Controls.Add(Me.txtNombreComercial)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtIdProveedor)
        Me.Panel1.Location = New System.Drawing.Point(11, 273)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 122)
        Me.Panel1.TabIndex = 463
        '
        'txtDocumento
        '
        Me.txtDocumento.AllowClear = True
        Me.txtDocumento.AllowNegatives = False
        Me.txtDocumento.AllowWhiteSpaces = True
        Me.txtDocumento.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocumento.BackColorIdle = System.Drawing.Color.Empty
        Me.txtDocumento.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtDocumento.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtDocumento.EnterIsTab = True
        Me.txtDocumento.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtDocumento.Label = "Descripción"
        Me.txtDocumento.Location = New System.Drawing.Point(121, 9)
        Me.txtDocumento.Mandatory = False
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumento.MaxLength = 100
        Me.txtDocumento.MinLength = 0
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Precision = 0
        Me.txtDocumento.SelectOnFocus = True
        Me.txtDocumento.Size = New System.Drawing.Size(233, 20)
        Me.txtDocumento.Symbol = Nothing
        Me.txtDocumento.TabIndex = 10
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDocumento.Value = Nothing
        '
        'labelDocumento
        '
        Me.labelDocumento.AutoSize = True
        Me.labelDocumento.Location = New System.Drawing.Point(12, 13)
        Me.labelDocumento.Name = "labelDocumento"
        Me.labelDocumento.Size = New System.Drawing.Size(30, 13)
        Me.labelDocumento.TabIndex = 481
        Me.labelDocumento.Text = "RUC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 479
        Me.Label1.Text = "Telefono / Celular"
        '
        'labelCorreo
        '
        Me.labelCorreo.AutoSize = True
        Me.labelCorreo.Location = New System.Drawing.Point(373, 12)
        Me.labelCorreo.Name = "labelCorreo"
        Me.labelCorreo.Size = New System.Drawing.Size(38, 13)
        Me.labelCorreo.TabIndex = 473
        Me.labelCorreo.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.AllowClear = True
        Me.txtCorreo.AllowNegatives = False
        Me.txtCorreo.AllowWhiteSpaces = True
        Me.txtCorreo.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.BackColorIdle = System.Drawing.Color.Empty
        Me.txtCorreo.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCorreo.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtCorreo.EnterIsTab = True
        Me.txtCorreo.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtCorreo.Label = "Descripción"
        Me.txtCorreo.Location = New System.Drawing.Point(470, 9)
        Me.txtCorreo.Mandatory = False
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.MinLength = 0
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Precision = 0
        Me.txtCorreo.SelectOnFocus = True
        Me.txtCorreo.Size = New System.Drawing.Size(155, 20)
        Me.txtCorreo.Symbol = Nothing
        Me.txtCorreo.TabIndex = 13
        Me.txtCorreo.Value = Nothing
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(643, 63)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 471
        Me.lbEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cboEstado.Location = New System.Drawing.Point(699, 60)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(105, 21)
        Me.cboEstado.TabIndex = 17
        '
        'cboMedicion
        '
        Me.cboMedicion.FormattingEnabled = True
        Me.cboMedicion.Location = New System.Drawing.Point(699, 9)
        Me.cboMedicion.Name = "cboMedicion"
        Me.cboMedicion.Size = New System.Drawing.Size(105, 21)
        Me.cboMedicion.TabIndex = 15
        '
        'lblTarifa
        '
        Me.lblTarifa.AutoSize = True
        Me.lblTarifa.Location = New System.Drawing.Point(643, 36)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(36, 13)
        Me.lblTarifa.TabIndex = 468
        Me.lblTarifa.Text = "Tarífa"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(12, 38)
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
        Me.txtRazonSocial.Location = New System.Drawing.Point(121, 34)
        Me.txtRazonSocial.Mandatory = False
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.MinLength = 0
        Me.txtRazonSocial.Multiline = True
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Precision = 0
        Me.txtRazonSocial.SelectOnFocus = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(233, 32)
        Me.txtRazonSocial.Symbol = Nothing
        Me.txtRazonSocial.TabIndex = 11
        Me.txtRazonSocial.Value = Nothing
        '
        'lblMedicion
        '
        Me.lblMedicion.AutoSize = True
        Me.lblMedicion.Location = New System.Drawing.Point(643, 12)
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
        Me.txtTarifa.Location = New System.Drawing.Point(699, 35)
        Me.txtTarifa.Mandatory = False
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTarifa.MaxLength = 100
        Me.txtTarifa.MinLength = 0
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Precision = 0
        Me.txtTarifa.SelectOnFocus = True
        Me.txtTarifa.Size = New System.Drawing.Size(105, 20)
        Me.txtTarifa.Symbol = Nothing
        Me.txtTarifa.TabIndex = 16
        Me.txtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTarifa.Value = Nothing
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
        Me.txtNumeroContacto.Location = New System.Drawing.Point(470, 34)
        Me.txtNumeroContacto.Mandatory = False
        Me.txtNumeroContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroContacto.MaxLength = 100
        Me.txtNumeroContacto.MinLength = 0
        Me.txtNumeroContacto.Name = "txtNumeroContacto"
        Me.txtNumeroContacto.Precision = 0
        Me.txtNumeroContacto.SelectOnFocus = True
        Me.txtNumeroContacto.Size = New System.Drawing.Size(155, 20)
        Me.txtNumeroContacto.Symbol = Nothing
        Me.txtNumeroContacto.TabIndex = 14
        Me.txtNumeroContacto.Value = Nothing
        '
        'lblNombreComercial
        '
        Me.lblNombreComercial.AutoSize = True
        Me.lblNombreComercial.Location = New System.Drawing.Point(12, 75)
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
        Me.txtNombreComercial.Location = New System.Drawing.Point(121, 71)
        Me.txtNombreComercial.Mandatory = False
        Me.txtNombreComercial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreComercial.MaxLength = 100
        Me.txtNombreComercial.MinLength = 0
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Precision = 0
        Me.txtNombreComercial.SelectOnFocus = True
        Me.txtNombreComercial.Size = New System.Drawing.Size(233, 20)
        Me.txtNombreComercial.Symbol = Nothing
        Me.txtNombreComercial.TabIndex = 12
        Me.txtNombreComercial.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(656, 87)
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
        Me.btnCancelar.Location = New System.Drawing.Point(735, 87)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
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
        Me.txtIdProveedor.Location = New System.Drawing.Point(685, 91)
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle10
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
        'Documento
        '
        Me.Documento.DataPropertyName = "Documento"
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        Me.Documento.Visible = False
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
        Me.NumeroContacto.HeaderText = "TELEFONO/CELULAR"
        Me.NumeroContacto.Name = "NumeroContacto"
        Me.NumeroContacto.ReadOnly = True
        Me.NumeroContacto.Width = 120
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Visible = False
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
        Me.TipoMedicion.Width = 120
        '
        'Tarifa
        '
        Me.Tarifa.DataPropertyName = "Tarifa"
        Me.Tarifa.HeaderText = "TARIFA"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        '
        'EstadoActivo
        '
        Me.EstadoActivo.DataPropertyName = "EstadoActivo"
        Me.EstadoActivo.HeaderText = "ESTADO"
        Me.EstadoActivo.Name = "EstadoActivo"
        Me.EstadoActivo.ReadOnly = True
        '
        'IdEstadoActivo
        '
        Me.IdEstadoActivo.DataPropertyName = "IdEstadoActivo"
        Me.IdEstadoActivo.HeaderText = "IdEstadoActivo"
        Me.IdEstadoActivo.Name = "IdEstadoActivo"
        Me.IdEstadoActivo.ReadOnly = True
        Me.IdEstadoActivo.Visible = False
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 406)
        Me.Controls.Add(Me.dgvProveedor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
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
    Friend WithEvents txtDocumento As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelDocumento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labelCorreo As Label
    Friend WithEvents txtCorreo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents cboMedicion As ComboBox
    Friend WithEvents lblTarifa As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents txtRazonSocial As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblMedicion As Label
    Friend WithEvents txtTarifa As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtNumeroContacto As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblNombreComercial As Label
    Friend WithEvents txtNombreComercial As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdProveedor As PersControlLibrary.ExtendedTextBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents NombreComercial As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents NumeroContacto As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents MedicionId As DataGridViewTextBoxColumn
    Friend WithEvents TipoMedicion As DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivo As DataGridViewTextBoxColumn
End Class
