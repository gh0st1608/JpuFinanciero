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
        Me.dgvGrupoIngreso = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbMedicionId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New PersControlLibrary.ExtendedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTarifa = New PersControlLibrary.ExtendedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroContacto = New PersControlLibrary.ExtendedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreComercial = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdGrupoIngreso = New PersControlLibrary.ExtendedTextBox()
        CType(Me.dgvGrupoIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGrupoIngreso
        '
        Me.dgvGrupoIngreso.AllowUserToAddRows = False
        Me.dgvGrupoIngreso.AllowUserToDeleteRows = False
        Me.dgvGrupoIngreso.AllowUserToResizeColumns = False
        Me.dgvGrupoIngreso.AllowUserToResizeRows = False
        Me.dgvGrupoIngreso.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrupoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrupoIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrupoIngreso.ColumnHeadersHeight = 32
        Me.dgvGrupoIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGrupoIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdProveedor, Me.NombreComercial, Me.RazonSocial, Me.NumeroContacto, Me.MedicionId, Me.Tarifa})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrupoIngreso.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrupoIngreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGrupoIngreso.EnableHeadersVisualStyles = False
        Me.dgvGrupoIngreso.Location = New System.Drawing.Point(14, 47)
        Me.dgvGrupoIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvGrupoIngreso.Name = "dgvGrupoIngreso"
        Me.dgvGrupoIngreso.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrupoIngreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrupoIngreso.RowHeadersVisible = False
        Me.dgvGrupoIngreso.RowHeadersWidth = 22
        Me.dgvGrupoIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrupoIngreso.RowTemplate.Height = 18
        Me.dgvGrupoIngreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrupoIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupoIngreso.Size = New System.Drawing.Size(536, 216)
        Me.dgvGrupoIngreso.TabIndex = 462
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
        Me.NombreComercial.Width = 373
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
        'Tarifa
        '
        Me.Tarifa.DataPropertyName = "Tarifa"
        Me.Tarifa.HeaderText = "Tarifa"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        Me.Tarifa.Visible = False
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
        Me.Panel1.Controls.Add(Me.cbMedicionId)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTarifa)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumeroContacto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombreComercial)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtIdGrupoIngreso)
        Me.Panel1.Location = New System.Drawing.Point(14, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 169)
        Me.Panel1.TabIndex = 458
        '
        'cbMedicionId
        '
        Me.cbMedicionId.FormattingEnabled = True
        Me.cbMedicionId.Location = New System.Drawing.Point(123, 83)
        Me.cbMedicionId.Name = "cbMedicionId"
        Me.cbMedicionId.Size = New System.Drawing.Size(397, 21)
        Me.cbMedicionId.TabIndex = 469
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 468
        Me.Label5.Text = "Tarífa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 467
        Me.Label4.Text = "Razón Social"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 465
        Me.Label3.Text = "Medición"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 463
        Me.Label1.Text = "Número de contacto"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 461
        Me.Label2.Text = "Nombre Comercial"
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
        'txtIdGrupoIngreso
        '
        Me.txtIdGrupoIngreso.AllowClear = True
        Me.txtIdGrupoIngreso.AllowNegatives = False
        Me.txtIdGrupoIngreso.AllowWhiteSpaces = True
        Me.txtIdGrupoIngreso.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdGrupoIngreso.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdGrupoIngreso.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdGrupoIngreso.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdGrupoIngreso.EnterIsTab = True
        Me.txtIdGrupoIngreso.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdGrupoIngreso.Label = "Descripción"
        Me.txtIdGrupoIngreso.Location = New System.Drawing.Point(401, 137)
        Me.txtIdGrupoIngreso.Mandatory = False
        Me.txtIdGrupoIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdGrupoIngreso.MaxLength = 100
        Me.txtIdGrupoIngreso.MinLength = 0
        Me.txtIdGrupoIngreso.Name = "txtIdGrupoIngreso"
        Me.txtIdGrupoIngreso.Precision = 0
        Me.txtIdGrupoIngreso.SelectOnFocus = True
        Me.txtIdGrupoIngreso.Size = New System.Drawing.Size(26, 20)
        Me.txtIdGrupoIngreso.Symbol = Nothing
        Me.txtIdGrupoIngreso.TabIndex = 460
        Me.txtIdGrupoIngreso.Value = Nothing
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 453)
        Me.Controls.Add(Me.dgvGrupoIngreso)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProveedor"
        Me.Text = "FormProveedor"
        CType(Me.dgvGrupoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvGrupoIngreso As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents NombreComercial As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents NumeroContacto As DataGridViewTextBoxColumn
    Friend WithEvents MedicionId As DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbMedicionId As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRazonSocial As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTarifa As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroContacto As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreComercial As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdGrupoIngreso As PersControlLibrary.ExtendedTextBox
End Class
