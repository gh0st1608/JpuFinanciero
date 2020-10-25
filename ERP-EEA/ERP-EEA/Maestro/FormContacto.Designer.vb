<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContacto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New PersControlLibrary.ExtendedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCelular = New PersControlLibrary.ExtendedTextBox()
        Me.txtNombre = New PersControlLibrary.ExtendedTextBox()
        Me.txtCargo = New PersControlLibrary.ExtendedTextBox()
        Me.dgvContacto = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtOrigenId = New PersControlLibrary.ExtendedTextBox()
        Me.txtIdContacto = New PersControlLibrary.ExtendedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClienteProveedor = New System.Windows.Forms.Label()
        CType(Me.dgvContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 486
        Me.Label2.Text = "Cargo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 487
        Me.Label6.Text = "Telef. / Cel."
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
        Me.txtCorreo.Location = New System.Drawing.Point(410, 13)
        Me.txtCorreo.Mandatory = False
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.MinLength = 0
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Precision = 0
        Me.txtCorreo.SelectOnFocus = True
        Me.txtCorreo.Size = New System.Drawing.Size(217, 20)
        Me.txtCorreo.Symbol = Nothing
        Me.txtCorreo.TabIndex = 13
        Me.txtCorreo.Value = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 485
        Me.Label3.Text = "Correo"
        '
        'txtCelular
        '
        Me.txtCelular.AllowClear = True
        Me.txtCelular.AllowNegatives = False
        Me.txtCelular.AllowWhiteSpaces = True
        Me.txtCelular.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCelular.BackColorIdle = System.Drawing.Color.Empty
        Me.txtCelular.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCelular.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtCelular.EnterIsTab = True
        Me.txtCelular.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtCelular.Label = "Descripción"
        Me.txtCelular.Location = New System.Drawing.Point(410, 39)
        Me.txtCelular.Mandatory = False
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCelular.MaxLength = 100
        Me.txtCelular.MinLength = 0
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Precision = 0
        Me.txtCelular.SelectOnFocus = True
        Me.txtCelular.Size = New System.Drawing.Size(116, 20)
        Me.txtCelular.Symbol = Nothing
        Me.txtCelular.TabIndex = 14
        Me.txtCelular.Value = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.AllowClear = True
        Me.txtNombre.AllowNegatives = False
        Me.txtNombre.AllowWhiteSpaces = True
        Me.txtNombre.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.BackColorIdle = System.Drawing.Color.Empty
        Me.txtNombre.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtNombre.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtNombre.EnterIsTab = True
        Me.txtNombre.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtNombre.Label = "Descripción"
        Me.txtNombre.Location = New System.Drawing.Point(63, 39)
        Me.txtNombre.Mandatory = False
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.MinLength = 0
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Precision = 0
        Me.txtNombre.SelectOnFocus = True
        Me.txtNombre.Size = New System.Drawing.Size(252, 20)
        Me.txtNombre.Symbol = Nothing
        Me.txtNombre.TabIndex = 11
        Me.txtNombre.Value = Nothing
        '
        'txtCargo
        '
        Me.txtCargo.AllowClear = True
        Me.txtCargo.AllowNegatives = False
        Me.txtCargo.AllowWhiteSpaces = True
        Me.txtCargo.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCargo.BackColorIdle = System.Drawing.Color.Empty
        Me.txtCargo.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCargo.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtCargo.EnterIsTab = True
        Me.txtCargo.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtCargo.Label = "Descripción"
        Me.txtCargo.Location = New System.Drawing.Point(63, 63)
        Me.txtCargo.Mandatory = False
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCargo.MaxLength = 100
        Me.txtCargo.MinLength = 0
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Precision = 0
        Me.txtCargo.SelectOnFocus = True
        Me.txtCargo.Size = New System.Drawing.Size(252, 20)
        Me.txtCargo.Symbol = Nothing
        Me.txtCargo.TabIndex = 12
        Me.txtCargo.Value = Nothing
        '
        'dgvContacto
        '
        Me.dgvContacto.AllowUserToAddRows = False
        Me.dgvContacto.AllowUserToDeleteRows = False
        Me.dgvContacto.AllowUserToResizeColumns = False
        Me.dgvContacto.AllowUserToResizeRows = False
        Me.dgvContacto.BackgroundColor = System.Drawing.Color.White
        Me.dgvContacto.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContacto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvContacto.ColumnHeadersHeight = 20
        Me.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvContacto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdContacto, Me.OrigenId, Me.NombreCompleto, Me.Cargo, Me.CorreoContacto, Me.Celular, Me.EstadoActivo})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContacto.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgvContacto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvContacto.EnableHeadersVisualStyles = False
        Me.dgvContacto.Location = New System.Drawing.Point(11, 47)
        Me.dgvContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvContacto.Name = "dgvContacto"
        Me.dgvContacto.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContacto.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvContacto.RowHeadersVisible = False
        Me.dgvContacto.RowHeadersWidth = 22
        Me.dgvContacto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvContacto.RowTemplate.Height = 18
        Me.dgvContacto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContacto.Size = New System.Drawing.Size(646, 110)
        Me.dgvContacto.TabIndex = 479
        Me.dgvContacto.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Item"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'IdContacto
        '
        Me.IdContacto.DataPropertyName = "IdContacto"
        Me.IdContacto.HeaderText = "IdContacto"
        Me.IdContacto.Name = "IdContacto"
        Me.IdContacto.ReadOnly = True
        Me.IdContacto.Visible = False
        '
        'OrigenId
        '
        Me.OrigenId.DataPropertyName = "OrigenId"
        Me.OrigenId.HeaderText = "OrigenId"
        Me.OrigenId.Name = "OrigenId"
        Me.OrigenId.ReadOnly = True
        Me.OrigenId.Visible = False
        '
        'NombreCompleto
        '
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "CONTACTO"
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        Me.NombreCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombreCompleto.Width = 220
        '
        'Cargo
        '
        Me.Cargo.DataPropertyName = "Cargo"
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0"
        Me.Cargo.DefaultCellStyle = DataGridViewCellStyle21
        Me.Cargo.HeaderText = "CARGO"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        Me.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CorreoContacto
        '
        Me.CorreoContacto.DataPropertyName = "Correo"
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = "0"
        Me.CorreoContacto.DefaultCellStyle = DataGridViewCellStyle22
        Me.CorreoContacto.HeaderText = "CORREO"
        Me.CorreoContacto.Name = "CorreoContacto"
        Me.CorreoContacto.ReadOnly = True
        Me.CorreoContacto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorreoContacto.Width = 190
        '
        'Celular
        '
        Me.Celular.DataPropertyName = "Celular"
        Me.Celular.HeaderText = "CELULAR"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        Me.Celular.Width = 90
        '
        'EstadoActivo
        '
        Me.EstadoActivo.DataPropertyName = "EstadoActivo"
        Me.EstadoActivo.HeaderText = "EstadoActivo"
        Me.EstadoActivo.Name = "EstadoActivo"
        Me.EstadoActivo.ReadOnly = True
        Me.EstadoActivo.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(561, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 3
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
        Me.btnModificar.Location = New System.Drawing.Point(458, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 2
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
        Me.btnNuevo.Location = New System.Drawing.Point(377, 12)
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
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Controls.Add(Me.cbCliente)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtCelular)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.txtOrigenId)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtIdContacto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblClienteProveedor)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtCargo)
        Me.Panel1.Location = New System.Drawing.Point(12, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 126)
        Me.Panel1.TabIndex = 491
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cboEstado.Location = New System.Drawing.Point(410, 64)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(116, 21)
        Me.cboEstado.TabIndex = 489
        Me.cboEstado.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(342, 66)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 488
        Me.lblEstado.Text = "Estado"
        '
        'cbCliente
        '
        Me.cbCliente.Enabled = False
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(63, 13)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(252, 21)
        Me.cbCliente.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(479, 95)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 26)
        Me.btnGuardar.TabIndex = 20
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
        Me.btnCancelar.Location = New System.Drawing.Point(558, 94)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtOrigenId
        '
        Me.txtOrigenId.AllowClear = True
        Me.txtOrigenId.AllowNegatives = False
        Me.txtOrigenId.AllowWhiteSpaces = True
        Me.txtOrigenId.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOrigenId.BackColorIdle = System.Drawing.Color.Empty
        Me.txtOrigenId.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtOrigenId.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtOrigenId.EnterIsTab = True
        Me.txtOrigenId.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtOrigenId.Label = "Descripción"
        Me.txtOrigenId.Location = New System.Drawing.Point(513, 99)
        Me.txtOrigenId.Mandatory = False
        Me.txtOrigenId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrigenId.MaxLength = 100
        Me.txtOrigenId.MinLength = 0
        Me.txtOrigenId.Name = "txtOrigenId"
        Me.txtOrigenId.Precision = 0
        Me.txtOrigenId.SelectOnFocus = True
        Me.txtOrigenId.Size = New System.Drawing.Size(26, 20)
        Me.txtOrigenId.Symbol = Nothing
        Me.txtOrigenId.TabIndex = 460
        Me.txtOrigenId.Value = Nothing
        '
        'txtIdContacto
        '
        Me.txtIdContacto.AllowClear = True
        Me.txtIdContacto.AllowNegatives = False
        Me.txtIdContacto.AllowWhiteSpaces = True
        Me.txtIdContacto.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdContacto.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdContacto.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdContacto.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdContacto.EnterIsTab = True
        Me.txtIdContacto.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdContacto.Label = "Descripción"
        Me.txtIdContacto.Location = New System.Drawing.Point(500, 99)
        Me.txtIdContacto.Mandatory = False
        Me.txtIdContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdContacto.MaxLength = 100
        Me.txtIdContacto.MinLength = 0
        Me.txtIdContacto.Name = "txtIdContacto"
        Me.txtIdContacto.Precision = 0
        Me.txtIdContacto.SelectOnFocus = True
        Me.txtIdContacto.Size = New System.Drawing.Size(26, 20)
        Me.txtIdContacto.Symbol = Nothing
        Me.txtIdContacto.TabIndex = 460
        Me.txtIdContacto.Value = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 484
        Me.Label1.Text = "Nombre"
        '
        'lblClienteProveedor
        '
        Me.lblClienteProveedor.AutoSize = True
        Me.lblClienteProveedor.Location = New System.Drawing.Point(14, 16)
        Me.lblClienteProveedor.Name = "lblClienteProveedor"
        Me.lblClienteProveedor.Size = New System.Drawing.Size(39, 13)
        Me.lblClienteProveedor.TabIndex = 484
        Me.lblClienteProveedor.Text = "Cliente"
        '
        'FormContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvContacto)
        Me.KeyPreview = True
        Me.Name = "FormContacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacto"
        CType(Me.dgvContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCelular As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtNombre As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtCargo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents dgvContacto As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtOrigenId As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtIdContacto As PersControlLibrary.ExtendedTextBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClienteProveedor As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdContacto As DataGridViewTextBoxColumn
    Friend WithEvents OrigenId As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents CorreoContacto As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
End Class
