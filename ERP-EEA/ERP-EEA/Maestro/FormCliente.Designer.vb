<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Me.dgvCliente = New PersControlLibrary.ExtendedDataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboTipoCliente = New System.Windows.Forms.ComboBox()
        Me.labelTipoCliente = New System.Windows.Forms.Label()
        Me.labelMetaEmpresa = New System.Windows.Forms.Label()
        Me.txtMetaEmpresa = New PersControlLibrary.ExtendedTextBox()
        Me.labelMetaEntidad = New System.Windows.Forms.Label()
        Me.txtMetaEntidad = New PersControlLibrary.ExtendedTextBox()
        Me.labelNumeroContacto = New System.Windows.Forms.Label()
        Me.txtNumeroContacto = New PersControlLibrary.ExtendedTextBox()
        Me.labelCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New PersControlLibrary.ExtendedTextBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New PersControlLibrary.ExtendedTextBox()
        Me.txtDocumento = New PersControlLibrary.ExtendedTextBox()
        Me.labelDocumento = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.labelRazonSocial = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdCliente = New PersControlLibrary.ExtendedTextBox()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetaEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetaEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AllowUserToResizeColumns = False
        Me.dgvCliente.AllowUserToResizeRows = False
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCliente.ColumnHeadersHeight = 20
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdCliente, Me.TipoCliente, Me.RazonSocial, Me.Documento, Me.Descripcion, Me.MetaEntidad, Me.MetaEmpresa, Me.Correo, Me.NumeroContacto, Me.IdEstadoActivo, Me.EstadoActivo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCliente.EnableHeadersVisualStyles = False
        Me.dgvCliente.Location = New System.Drawing.Point(11, 43)
        Me.dgvCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.RowHeadersWidth = 22
        Me.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCliente.RowTemplate.Height = 18
        Me.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(706, 216)
        Me.dgvCliente.TabIndex = 467
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(622, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 466
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
        Me.btnModificar.Location = New System.Drawing.Point(519, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 465
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
        Me.btnNuevo.Location = New System.Drawing.Point(438, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 464
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboTipoCliente)
        Me.Panel1.Controls.Add(Me.labelTipoCliente)
        Me.Panel1.Controls.Add(Me.labelMetaEmpresa)
        Me.Panel1.Controls.Add(Me.txtMetaEmpresa)
        Me.Panel1.Controls.Add(Me.labelMetaEntidad)
        Me.Panel1.Controls.Add(Me.txtMetaEntidad)
        Me.Panel1.Controls.Add(Me.labelNumeroContacto)
        Me.Panel1.Controls.Add(Me.txtNumeroContacto)
        Me.Panel1.Controls.Add(Me.labelCorreo)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.labelDescripcion)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtDocumento)
        Me.Panel1.Controls.Add(Me.labelDocumento)
        Me.Panel1.Controls.Add(Me.lbEstado)
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.labelRazonSocial)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtIdCliente)
        Me.Panel1.Location = New System.Drawing.Point(11, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 331)
        Me.Panel1.TabIndex = 463
        '
        'cboTipoCliente
        '
        Me.cboTipoCliente.FormattingEnabled = True
        Me.cboTipoCliente.Location = New System.Drawing.Point(89, 17)
        Me.cboTipoCliente.Name = "cboTipoCliente"
        Me.cboTipoCliente.Size = New System.Drawing.Size(599, 21)
        Me.cboTipoCliente.TabIndex = 468
        '
        'labelTipoCliente
        '
        Me.labelTipoCliente.AutoSize = True
        Me.labelTipoCliente.Location = New System.Drawing.Point(14, 20)
        Me.labelTipoCliente.Name = "labelTipoCliente"
        Me.labelTipoCliente.Size = New System.Drawing.Size(63, 13)
        Me.labelTipoCliente.TabIndex = 477
        Me.labelTipoCliente.Text = "Tipo Cliente"
        '
        'labelMetaEmpresa
        '
        Me.labelMetaEmpresa.AutoSize = True
        Me.labelMetaEmpresa.Location = New System.Drawing.Point(424, 246)
        Me.labelMetaEmpresa.Name = "labelMetaEmpresa"
        Me.labelMetaEmpresa.Size = New System.Drawing.Size(48, 26)
        Me.labelMetaEmpresa.TabIndex = 475
        Me.labelMetaEmpresa.Text = "Meta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empresa"
        '
        'txtMetaEmpresa
        '
        Me.txtMetaEmpresa.AllowClear = True
        Me.txtMetaEmpresa.AllowNegatives = False
        Me.txtMetaEmpresa.AllowWhiteSpaces = True
        Me.txtMetaEmpresa.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMetaEmpresa.BackColorIdle = System.Drawing.Color.Empty
        Me.txtMetaEmpresa.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtMetaEmpresa.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtMetaEmpresa.EnterIsTab = True
        Me.txtMetaEmpresa.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtMetaEmpresa.Label = "Descripción"
        Me.txtMetaEmpresa.Location = New System.Drawing.Point(477, 246)
        Me.txtMetaEmpresa.Mandatory = False
        Me.txtMetaEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMetaEmpresa.MaxLength = 100
        Me.txtMetaEmpresa.MinLength = 0
        Me.txtMetaEmpresa.Name = "txtMetaEmpresa"
        Me.txtMetaEmpresa.Precision = 0
        Me.txtMetaEmpresa.SelectOnFocus = True
        Me.txtMetaEmpresa.Size = New System.Drawing.Size(211, 20)
        Me.txtMetaEmpresa.Symbol = Nothing
        Me.txtMetaEmpresa.TabIndex = 474
        Me.txtMetaEmpresa.Value = Nothing
        '
        'labelMetaEntidad
        '
        Me.labelMetaEntidad.AutoSize = True
        Me.labelMetaEntidad.Location = New System.Drawing.Point(14, 249)
        Me.labelMetaEntidad.Name = "labelMetaEntidad"
        Me.labelMetaEntidad.Size = New System.Drawing.Size(43, 26)
        Me.labelMetaEntidad.TabIndex = 473
        Me.labelMetaEntidad.Text = "Meta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entidad"
        '
        'txtMetaEntidad
        '
        Me.txtMetaEntidad.AllowClear = True
        Me.txtMetaEntidad.AllowNegatives = False
        Me.txtMetaEntidad.AllowWhiteSpaces = True
        Me.txtMetaEntidad.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMetaEntidad.BackColorIdle = System.Drawing.Color.Empty
        Me.txtMetaEntidad.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtMetaEntidad.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtMetaEntidad.EnterIsTab = True
        Me.txtMetaEntidad.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtMetaEntidad.Label = "Descripción"
        Me.txtMetaEntidad.Location = New System.Drawing.Point(89, 249)
        Me.txtMetaEntidad.Mandatory = False
        Me.txtMetaEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMetaEntidad.MaxLength = 100
        Me.txtMetaEntidad.MinLength = 0
        Me.txtMetaEntidad.Name = "txtMetaEntidad"
        Me.txtMetaEntidad.Precision = 0
        Me.txtMetaEntidad.SelectOnFocus = True
        Me.txtMetaEntidad.Size = New System.Drawing.Size(221, 20)
        Me.txtMetaEntidad.Symbol = Nothing
        Me.txtMetaEntidad.TabIndex = 472
        Me.txtMetaEntidad.Value = Nothing
        '
        'labelNumeroContacto
        '
        Me.labelNumeroContacto.AutoSize = True
        Me.labelNumeroContacto.Location = New System.Drawing.Point(14, 204)
        Me.labelNumeroContacto.Name = "labelNumeroContacto"
        Me.labelNumeroContacto.Size = New System.Drawing.Size(50, 26)
        Me.labelNumeroContacto.TabIndex = 471
        Me.labelNumeroContacto.Text = "Número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contacto"
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
        Me.txtNumeroContacto.Location = New System.Drawing.Point(89, 204)
        Me.txtNumeroContacto.Mandatory = False
        Me.txtNumeroContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroContacto.MaxLength = 100
        Me.txtNumeroContacto.MinLength = 0
        Me.txtNumeroContacto.Name = "txtNumeroContacto"
        Me.txtNumeroContacto.Precision = 0
        Me.txtNumeroContacto.SelectOnFocus = True
        Me.txtNumeroContacto.Size = New System.Drawing.Size(599, 20)
        Me.txtNumeroContacto.Symbol = Nothing
        Me.txtNumeroContacto.TabIndex = 470
        Me.txtNumeroContacto.Value = Nothing
        '
        'labelCorreo
        '
        Me.labelCorreo.AutoSize = True
        Me.labelCorreo.Location = New System.Drawing.Point(14, 167)
        Me.labelCorreo.Name = "labelCorreo"
        Me.labelCorreo.Size = New System.Drawing.Size(38, 13)
        Me.labelCorreo.TabIndex = 469
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
        Me.txtCorreo.Location = New System.Drawing.Point(89, 167)
        Me.txtCorreo.Mandatory = False
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.MinLength = 0
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Precision = 0
        Me.txtCorreo.SelectOnFocus = True
        Me.txtCorreo.Size = New System.Drawing.Size(599, 20)
        Me.txtCorreo.Symbol = Nothing
        Me.txtCorreo.TabIndex = 468
        Me.txtCorreo.Value = Nothing
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(14, 128)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.labelDescripcion.TabIndex = 467
        Me.labelDescripcion.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AllowClear = True
        Me.txtDescripcion.AllowNegatives = False
        Me.txtDescripcion.AllowWhiteSpaces = True
        Me.txtDescripcion.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescripcion.BackColorIdle = System.Drawing.Color.Empty
        Me.txtDescripcion.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtDescripcion.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtDescripcion.EnterIsTab = True
        Me.txtDescripcion.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtDescripcion.Label = "Descripción"
        Me.txtDescripcion.Location = New System.Drawing.Point(89, 128)
        Me.txtDescripcion.Mandatory = False
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MinLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Precision = 0
        Me.txtDescripcion.SelectOnFocus = True
        Me.txtDescripcion.Size = New System.Drawing.Size(599, 20)
        Me.txtDescripcion.Symbol = Nothing
        Me.txtDescripcion.TabIndex = 466
        Me.txtDescripcion.Value = Nothing
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
        Me.txtDocumento.Location = New System.Drawing.Point(89, 90)
        Me.txtDocumento.Mandatory = False
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumento.MaxLength = 100
        Me.txtDocumento.MinLength = 0
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Precision = 0
        Me.txtDocumento.SelectOnFocus = True
        Me.txtDocumento.Size = New System.Drawing.Size(599, 20)
        Me.txtDocumento.Symbol = Nothing
        Me.txtDocumento.TabIndex = 465
        Me.txtDocumento.Value = Nothing
        '
        'labelDocumento
        '
        Me.labelDocumento.AutoSize = True
        Me.labelDocumento.Location = New System.Drawing.Point(14, 90)
        Me.labelDocumento.Name = "labelDocumento"
        Me.labelDocumento.Size = New System.Drawing.Size(62, 13)
        Me.labelDocumento.TabIndex = 464
        Me.labelDocumento.Text = "Documento"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(14, 301)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 463
        Me.lbEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cboEstado.Location = New System.Drawing.Point(89, 293)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(221, 21)
        Me.cboEstado.TabIndex = 462
        '
        'labelRazonSocial
        '
        Me.labelRazonSocial.AutoSize = True
        Me.labelRazonSocial.Location = New System.Drawing.Point(14, 55)
        Me.labelRazonSocial.Name = "labelRazonSocial"
        Me.labelRazonSocial.Size = New System.Drawing.Size(70, 13)
        Me.labelRazonSocial.TabIndex = 461
        Me.labelRazonSocial.Text = "Razon Social"
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
        Me.txtRazonSocial.Location = New System.Drawing.Point(89, 52)
        Me.txtRazonSocial.Mandatory = False
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.MinLength = 0
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Precision = 0
        Me.txtRazonSocial.SelectOnFocus = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(599, 20)
        Me.txtRazonSocial.Symbol = Nothing
        Me.txtRazonSocial.TabIndex = 458
        Me.txtRazonSocial.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(427, 289)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 26)
        Me.btnGuardar.TabIndex = 410
        Me.btnGuardar.Text = "GUARDAR"
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
        Me.btnCancelar.Location = New System.Drawing.Point(588, 289)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 26)
        Me.btnCancelar.TabIndex = 409
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.AllowClear = True
        Me.txtIdCliente.AllowNegatives = False
        Me.txtIdCliente.AllowWhiteSpaces = True
        Me.txtIdCliente.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdCliente.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdCliente.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdCliente.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdCliente.EnterIsTab = True
        Me.txtIdCliente.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdCliente.Label = "Descripción"
        Me.txtIdCliente.Location = New System.Drawing.Point(477, 293)
        Me.txtIdCliente.Mandatory = False
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCliente.MaxLength = 100
        Me.txtIdCliente.MinLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Precision = 0
        Me.txtIdCliente.SelectOnFocus = True
        Me.txtIdCliente.Size = New System.Drawing.Size(26, 20)
        Me.txtIdCliente.Symbol = Nothing
        Me.txtIdCliente.TabIndex = 460
        Me.txtIdCliente.Value = Nothing
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Item"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Width = 25
        '
        'IdCliente
        '
        Me.IdCliente.DataPropertyName = "IdCliente"
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Visible = False
        '
        'TipoCliente
        '
        Me.TipoCliente.DataPropertyName = "TipoCliente"
        Me.TipoCliente.HeaderText = "TIPO CLIENTE"
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.ReadOnly = True
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.HeaderText = "RAZON SOCIAL"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        Me.RazonSocial.Visible = False
        '
        'Documento
        '
        Me.Documento.DataPropertyName = "Documento"
        Me.Documento.HeaderText = "DOCUMENTO"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        Me.Documento.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "NOMBRE COMERCIAL"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion.Width = 320
        '
        'MetaEntidad
        '
        Me.MetaEntidad.DataPropertyName = "MetaEntidad"
        Me.MetaEntidad.HeaderText = "META ENTIDAD"
        Me.MetaEntidad.Name = "MetaEntidad"
        Me.MetaEntidad.ReadOnly = True
        Me.MetaEntidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'MetaEmpresa
        '
        Me.MetaEmpresa.DataPropertyName = "MetaEmpresa"
        Me.MetaEmpresa.HeaderText = "META EMPRESA"
        Me.MetaEmpresa.Name = "MetaEmpresa"
        Me.MetaEmpresa.ReadOnly = True
        Me.MetaEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "CORREO"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Visible = False
        '
        'NumeroContacto
        '
        Me.NumeroContacto.DataPropertyName = "NumeroContacto"
        Me.NumeroContacto.HeaderText = "NUMERO CONTACTO"
        Me.NumeroContacto.Name = "NumeroContacto"
        Me.NumeroContacto.ReadOnly = True
        Me.NumeroContacto.Visible = False
        '
        'IdEstadoActivo
        '
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
        Me.EstadoActivo.Width = 80
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 613)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCliente"
        Me.Text = "FormCliente"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCliente As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents labelRazonSocial As Label
    Friend WithEvents txtRazonSocial As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdCliente As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtDocumento As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelDocumento As Label
    Friend WithEvents labelDescripcion As Label
    Friend WithEvents txtDescripcion As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelCorreo As Label
    Friend WithEvents txtCorreo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelNumeroContacto As Label
    Friend WithEvents txtNumeroContacto As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelMetaEmpresa As Label
    Friend WithEvents txtMetaEmpresa As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelMetaEntidad As Label
    Friend WithEvents txtMetaEntidad As PersControlLibrary.ExtendedTextBox
    Friend WithEvents cboTipoCliente As ComboBox
    Friend WithEvents labelTipoCliente As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents TipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents MetaEntidad As DataGridViewTextBoxColumn
    Friend WithEvents MetaEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents NumeroContacto As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
End Class
