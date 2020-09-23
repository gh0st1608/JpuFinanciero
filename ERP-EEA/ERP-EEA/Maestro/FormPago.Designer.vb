<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPago
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvIngreso = New PersControlLibrary.ExtendedDataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.ImporteCancelado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtOrigenId = New PersControlLibrary.ExtendedTextBox()
        Me.txtIdPago = New PersControlLibrary.ExtendedTextBox()
        Me.cbTipoOrigen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblTercero = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComentario = New PersControlLibrary.ExtendedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.dgvIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbPeriodoFiltro
        '
        Me.cbPeriodoFiltro.FormattingEnabled = True
        Me.cbPeriodoFiltro.Location = New System.Drawing.Point(125, 51)
        Me.cbPeriodoFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPeriodoFiltro.Name = "cbPeriodoFiltro"
        Me.cbPeriodoFiltro.Size = New System.Drawing.Size(109, 24)
        Me.cbPeriodoFiltro.TabIndex = 472
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 52)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 17)
        Me.Label23.TabIndex = 471
        Me.Label23.Text = "Periodo"
        '
        'dgvIngreso
        '
        Me.dgvIngreso.AllowUserToAddRows = False
        Me.dgvIngreso.AllowUserToDeleteRows = False
        Me.dgvIngreso.AllowUserToResizeColumns = False
        Me.dgvIngreso.AllowUserToResizeRows = False
        Me.dgvIngreso.BackgroundColor = System.Drawing.Color.White
        Me.dgvIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvIngreso.ColumnHeadersHeight = 20
        Me.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdIngreso, Me.GrupoIngresoId, Me.ClienteId, Me.Descripcion, Me.Detraccion, Me.ImporteProvision, Me.PeriodoId, Me.Comentario, Me.FechaIngresoProvision, Me.Deuda})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIngreso.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvIngreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvIngreso.EnableHeadersVisualStyles = False
        Me.dgvIngreso.Location = New System.Drawing.Point(12, 90)
        Me.dgvIngreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvIngreso.Name = "dgvIngreso"
        Me.dgvIngreso.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvIngreso.RowHeadersVisible = False
        Me.dgvIngreso.RowHeadersWidth = 22
        Me.dgvIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIngreso.RowTemplate.Height = 18
        Me.dgvIngreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIngreso.Size = New System.Drawing.Size(753, 266)
        Me.dgvIngreso.TabIndex = 470
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(896, 204)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 32)
        Me.btnEliminar.TabIndex = 469
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
        Me.btnModificar.Location = New System.Drawing.Point(896, 153)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(119, 32)
        Me.btnModificar.TabIndex = 468
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
        Me.btnNuevo.Location = New System.Drawing.Point(554, 18)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(91, 32)
        Me.btnNuevo.TabIndex = 467
        Me.btnNuevo.Text = "[F2] PAGAR"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtComentario)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbPeriodo)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.dtpFechaIngreso)
        Me.Panel1.Controls.Add(Me.ImporteCancelado)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtOrigenId)
        Me.Panel1.Controls.Add(Me.txtIdPago)
        Me.Panel1.Location = New System.Drawing.Point(12, 374)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 210)
        Me.Panel1.TabIndex = 466
        '
        'cbPeriodo
        '
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Location = New System.Drawing.Point(616, 75)
        Me.cbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(123, 24)
        Me.cbPeriodo.TabIndex = 475
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(473, 81)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 17)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "Medio de Pago"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(472, 112)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 17)
        Me.Label17.TabIndex = 470
        Me.Label17.Text = "Fecha de Pago"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(616, 107)
        Me.dtpFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(123, 22)
        Me.dtpFechaIngreso.TabIndex = 469
        '
        'ImporteCancelado
        '
        Me.ImporteCancelado.Location = New System.Drawing.Point(616, 137)
        Me.ImporteCancelado.Margin = New System.Windows.Forms.Padding(4)
        Me.ImporteCancelado.Name = "ImporteCancelado"
        Me.ImporteCancelado.Size = New System.Drawing.Size(123, 22)
        Me.ImporteCancelado.TabIndex = 465
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(472, 140)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 17)
        Me.Label20.TabIndex = 464
        Me.Label20.Text = "Importe Cancelado"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(542, 168)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 32)
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
        Me.btnCancelar.Location = New System.Drawing.Point(647, 167)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 32)
        Me.btnCancelar.TabIndex = 409
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
        Me.txtOrigenId.Location = New System.Drawing.Point(586, 174)
        Me.txtOrigenId.Mandatory = False
        Me.txtOrigenId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrigenId.MaxLength = 100
        Me.txtOrigenId.MinLength = 0
        Me.txtOrigenId.Name = "txtOrigenId"
        Me.txtOrigenId.Precision = 0
        Me.txtOrigenId.SelectOnFocus = True
        Me.txtOrigenId.Size = New System.Drawing.Size(33, 22)
        Me.txtOrigenId.Symbol = Nothing
        Me.txtOrigenId.TabIndex = 460
        Me.txtOrigenId.Value = Nothing
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
        Me.txtIdPago.Location = New System.Drawing.Point(569, 173)
        Me.txtIdPago.Mandatory = False
        Me.txtIdPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdPago.MaxLength = 100
        Me.txtIdPago.MinLength = 0
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Precision = 0
        Me.txtIdPago.SelectOnFocus = True
        Me.txtIdPago.Size = New System.Drawing.Size(33, 22)
        Me.txtIdPago.Symbol = Nothing
        Me.txtIdPago.TabIndex = 460
        Me.txtIdPago.Value = Nothing
        '
        'cbTipoOrigen
        '
        Me.cbTipoOrigen.FormattingEnabled = True
        Me.cbTipoOrigen.Location = New System.Drawing.Point(125, 17)
        Me.cbTipoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoOrigen.Name = "cbTipoOrigen"
        Me.cbTipoOrigen.Size = New System.Drawing.Size(109, 24)
        Me.cbTipoOrigen.TabIndex = 474
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 473
        Me.Label1.Text = "Tipo Operación"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(866, 312)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(393, 24)
        Me.ComboBox2.TabIndex = 476
        '
        'lblTercero
        '
        Me.lblTercero.AutoSize = True
        Me.lblTercero.Location = New System.Drawing.Point(807, 315)
        Me.lblTercero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTercero.Name = "lblTercero"
        Me.lblTercero.Size = New System.Drawing.Size(51, 17)
        Me.lblTercero.TabIndex = 475
        Me.lblTercero.Text = "Cliente"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(276, 43)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 32)
        Me.btnBuscar.TabIndex = 477
        Me.btnBuscar.Text = "[F3] BUSCAR"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "Comprobante"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(616, 46)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 22)
        Me.TextBox2.TabIndex = 479
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(473, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 478
        Me.Label5.Text = "Nº de comprobante"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(616, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 32)
        Me.Button1.TabIndex = 480
        Me.Button1.Text = "Adjuntar Archivo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(127, 12)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(320, 24)
        Me.ComboBox4.TabIndex = 484
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 483
        Me.Label6.Text = "Nombre Cliente"
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
        Me.txtComentario.Location = New System.Drawing.Point(127, 42)
        Me.txtComentario.Mandatory = False
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtComentario.MaxLength = 100
        Me.txtComentario.MinLength = 0
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Precision = 0
        Me.txtComentario.SelectOnFocus = True
        Me.txtComentario.Size = New System.Drawing.Size(320, 56)
        Me.txtComentario.Symbol = Nothing
        Me.txtComentario.TabIndex = 481
        Me.txtComentario.Value = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 482
        Me.Label13.Text = "Comentario"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 104)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 486
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 485
        Me.Label2.Text = "Deuda"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "item"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.Descripcion.Width = 390
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
        Me.ImporteProvision.HeaderText = "DEUDA"
        Me.ImporteProvision.Name = "ImporteProvision"
        Me.ImporteProvision.ReadOnly = True
        Me.ImporteProvision.Width = 130
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
        Me.FechaIngresoProvision.Width = 120
        '
        'Deuda
        '
        Me.Deuda.DataPropertyName = "Deuda"
        Me.Deuda.HeaderText = "Deuda"
        Me.Deuda.Name = "Deuda"
        Me.Deuda.ReadOnly = True
        Me.Deuda.Visible = False
        '
        'FormPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 596)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblTercero)
        Me.Controls.Add(Me.cbTipoOrigen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.dgvIngreso)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPago"
        Me.Text = "Pago"
        CType(Me.dgvIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents dgvIngreso As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbPeriodo As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents ImporteCancelado As TextBox
    Friend WithEvents Label20 As Label
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdPago As PersControlLibrary.ExtendedTextBox
    Friend WithEvents cbTipoOrigen As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lblTercero As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtOrigenId As PersControlLibrary.ExtendedTextBox
    Private WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtComentario As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label13 As Label
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
End Class
