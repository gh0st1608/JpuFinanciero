<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRelacionDebeHaber
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelRelacionDebeHaber = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbGrupoHaber = New System.Windows.Forms.ComboBox()
        Me.cbSignoHaber = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbHaber = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbGrupoDebe = New System.Windows.Forms.ComboBox()
        Me.cbSignoDebe = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDebe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEtapaOperacion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoOperacion = New System.Windows.Forms.ComboBox()
        Me.lblTipoOperacion = New System.Windows.Forms.Label()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdRelacionDebeHaber = New PersControlLibrary.ExtendedTextBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvRelacionDebeHaber = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelRelacionDebeHaber.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRelacionDebeHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRelacionDebeHaber
        '
        Me.PanelRelacionDebeHaber.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelRelacionDebeHaber.Controls.Add(Me.GroupBox2)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.GroupBox1)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.cbEtapaOperacion)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.Label1)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.cbTipoOperacion)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.lblTipoOperacion)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.cbGrupo)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.btnGuardar)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.btnCancelar)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.txtIdRelacionDebeHaber)
        Me.PanelRelacionDebeHaber.Controls.Add(Me.lblGrupo)
        Me.PanelRelacionDebeHaber.Location = New System.Drawing.Point(11, 407)
        Me.PanelRelacionDebeHaber.Name = "PanelRelacionDebeHaber"
        Me.PanelRelacionDebeHaber.Size = New System.Drawing.Size(645, 153)
        Me.PanelRelacionDebeHaber.TabIndex = 496
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbGrupoHaber)
        Me.GroupBox2.Controls.Add(Me.cbSignoHaber)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbHaber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(434, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 108)
        Me.GroupBox2.TabIndex = 493
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Haber"
        '
        'cbGrupoHaber
        '
        Me.cbGrupoHaber.FormattingEnabled = True
        Me.cbGrupoHaber.Items.AddRange(New Object() {"Seleccione", "Activo", "Pasivo", "Patrimonio"})
        Me.cbGrupoHaber.Location = New System.Drawing.Point(53, 19)
        Me.cbGrupoHaber.Name = "cbGrupoHaber"
        Me.cbGrupoHaber.Size = New System.Drawing.Size(130, 21)
        Me.cbGrupoHaber.TabIndex = 489
        '
        'cbSignoHaber
        '
        Me.cbSignoHaber.FormattingEnabled = True
        Me.cbSignoHaber.Items.AddRange(New Object() {"Seleccione", "Positivo", "Negativo"})
        Me.cbSignoHaber.Location = New System.Drawing.Point(53, 73)
        Me.cbSignoHaber.Name = "cbSignoHaber"
        Me.cbSignoHaber.Size = New System.Drawing.Size(130, 21)
        Me.cbSignoHaber.TabIndex = 491
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 484
        Me.Label5.Text = "Item"
        '
        'cbHaber
        '
        Me.cbHaber.FormattingEnabled = True
        Me.cbHaber.Location = New System.Drawing.Point(53, 46)
        Me.cbHaber.Name = "cbHaber"
        Me.cbHaber.Size = New System.Drawing.Size(130, 21)
        Me.cbHaber.TabIndex = 484
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 488
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 490
        Me.Label7.Text = "Signo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbGrupoDebe)
        Me.GroupBox1.Controls.Add(Me.cbSignoDebe)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbDebe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(223, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 108)
        Me.GroupBox1.TabIndex = 492
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debe"
        '
        'cbGrupoDebe
        '
        Me.cbGrupoDebe.FormattingEnabled = True
        Me.cbGrupoDebe.Items.AddRange(New Object() {"Seleccione", "Activo", "Pasivo", "Patrimonio"})
        Me.cbGrupoDebe.Location = New System.Drawing.Point(53, 19)
        Me.cbGrupoDebe.Name = "cbGrupoDebe"
        Me.cbGrupoDebe.Size = New System.Drawing.Size(130, 21)
        Me.cbGrupoDebe.TabIndex = 489
        '
        'cbSignoDebe
        '
        Me.cbSignoDebe.AutoCompleteCustomSource.AddRange(New String() {"Positivo", "Negativo"})
        Me.cbSignoDebe.FormattingEnabled = True
        Me.cbSignoDebe.Items.AddRange(New Object() {"Seleccione", "Positivo", "Negativo"})
        Me.cbSignoDebe.Location = New System.Drawing.Point(53, 73)
        Me.cbSignoDebe.Name = "cbSignoDebe"
        Me.cbSignoDebe.Size = New System.Drawing.Size(130, 21)
        Me.cbSignoDebe.TabIndex = 491
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 484
        Me.Label2.Text = "Item"
        '
        'cbDebe
        '
        Me.cbDebe.FormattingEnabled = True
        Me.cbDebe.Location = New System.Drawing.Point(53, 46)
        Me.cbDebe.Name = "cbDebe"
        Me.cbDebe.Size = New System.Drawing.Size(130, 21)
        Me.cbDebe.TabIndex = 484
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 488
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 490
        Me.Label4.Text = "Signo"
        '
        'cbEtapaOperacion
        '
        Me.cbEtapaOperacion.FormattingEnabled = True
        Me.cbEtapaOperacion.Items.AddRange(New Object() {"Seleccione", "Registro", "Pago/Cobro"})
        Me.cbEtapaOperacion.Location = New System.Drawing.Point(107, 49)
        Me.cbEtapaOperacion.Name = "cbEtapaOperacion"
        Me.cbEtapaOperacion.Size = New System.Drawing.Size(107, 21)
        Me.cbEtapaOperacion.TabIndex = 491
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 490
        Me.Label1.Text = "Etapa Operación"
        '
        'cbTipoOperacion
        '
        Me.cbTipoOperacion.FormattingEnabled = True
        Me.cbTipoOperacion.Items.AddRange(New Object() {"Seleccione", "Ingreso", "Egreso"})
        Me.cbTipoOperacion.Location = New System.Drawing.Point(107, 22)
        Me.cbTipoOperacion.Name = "cbTipoOperacion"
        Me.cbTipoOperacion.Size = New System.Drawing.Size(107, 21)
        Me.cbTipoOperacion.TabIndex = 489
        '
        'lblTipoOperacion
        '
        Me.lblTipoOperacion.AutoSize = True
        Me.lblTipoOperacion.Location = New System.Drawing.Point(14, 25)
        Me.lblTipoOperacion.Name = "lblTipoOperacion"
        Me.lblTipoOperacion.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoOperacion.TabIndex = 488
        Me.lblTipoOperacion.Text = "Tipo Operación"
        '
        'cbGrupo
        '
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.Location = New System.Drawing.Point(107, 76)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(107, 21)
        Me.cbGrupo.TabIndex = 484
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(487, 120)
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
        Me.btnCancelar.Location = New System.Drawing.Point(565, 120)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 409
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdRelacionDebeHaber
        '
        Me.txtIdRelacionDebeHaber.AllowClear = True
        Me.txtIdRelacionDebeHaber.AllowNegatives = False
        Me.txtIdRelacionDebeHaber.AllowWhiteSpaces = True
        Me.txtIdRelacionDebeHaber.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdRelacionDebeHaber.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdRelacionDebeHaber.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdRelacionDebeHaber.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdRelacionDebeHaber.EnterIsTab = True
        Me.txtIdRelacionDebeHaber.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdRelacionDebeHaber.Label = "Descripción"
        Me.txtIdRelacionDebeHaber.Location = New System.Drawing.Point(520, 125)
        Me.txtIdRelacionDebeHaber.Mandatory = False
        Me.txtIdRelacionDebeHaber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdRelacionDebeHaber.MaxLength = 100
        Me.txtIdRelacionDebeHaber.MinLength = 0
        Me.txtIdRelacionDebeHaber.Name = "txtIdRelacionDebeHaber"
        Me.txtIdRelacionDebeHaber.Precision = 0
        Me.txtIdRelacionDebeHaber.SelectOnFocus = True
        Me.txtIdRelacionDebeHaber.Size = New System.Drawing.Size(26, 20)
        Me.txtIdRelacionDebeHaber.Symbol = Nothing
        Me.txtIdRelacionDebeHaber.TabIndex = 460
        Me.txtIdRelacionDebeHaber.Value = Nothing
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(14, 79)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(56, 13)
        Me.lblGrupo.TabIndex = 484
        Me.lblGrupo.Text = "Operación"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(561, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 495
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
        Me.btnModificar.Location = New System.Drawing.Point(458, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 494
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
        Me.btnNuevo.Location = New System.Drawing.Point(377, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 493
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgvRelacionDebeHaber
        '
        Me.dgvRelacionDebeHaber.AllowUserToAddRows = False
        Me.dgvRelacionDebeHaber.AllowUserToDeleteRows = False
        Me.dgvRelacionDebeHaber.AllowUserToResizeColumns = False
        Me.dgvRelacionDebeHaber.AllowUserToResizeRows = False
        Me.dgvRelacionDebeHaber.BackgroundColor = System.Drawing.Color.White
        Me.dgvRelacionDebeHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRelacionDebeHaber.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvRelacionDebeHaber.ColumnHeadersHeight = 20
        Me.dgvRelacionDebeHaber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRelacionDebeHaber.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdContacto, Me.OrigenId, Me.NombreCompleto, Me.Cargo, Me.CorreoContacto, Me.Celular, Me.EstadoActivo})
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelacionDebeHaber.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvRelacionDebeHaber.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRelacionDebeHaber.EnableHeadersVisualStyles = False
        Me.dgvRelacionDebeHaber.Location = New System.Drawing.Point(11, 50)
        Me.dgvRelacionDebeHaber.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRelacionDebeHaber.Name = "dgvRelacionDebeHaber"
        Me.dgvRelacionDebeHaber.ReadOnly = True
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRelacionDebeHaber.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvRelacionDebeHaber.RowHeadersVisible = False
        Me.dgvRelacionDebeHaber.RowHeadersWidth = 22
        Me.dgvRelacionDebeHaber.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRelacionDebeHaber.RowTemplate.Height = 18
        Me.dgvRelacionDebeHaber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRelacionDebeHaber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelacionDebeHaber.Size = New System.Drawing.Size(646, 340)
        Me.dgvRelacionDebeHaber.TabIndex = 492
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Item"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle26
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
        DataGridViewCellStyle27.Format = "N2"
        DataGridViewCellStyle27.NullValue = "0"
        Me.Cargo.DefaultCellStyle = DataGridViewCellStyle27
        Me.Cargo.HeaderText = "CARGO"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        Me.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CorreoContacto
        '
        Me.CorreoContacto.DataPropertyName = "Correo"
        DataGridViewCellStyle28.Format = "N2"
        DataGridViewCellStyle28.NullValue = "0"
        Me.CorreoContacto.DefaultCellStyle = DataGridViewCellStyle28
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
        'FormRelacionDebeHaber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 573)
        Me.Controls.Add(Me.PanelRelacionDebeHaber)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvRelacionDebeHaber)
        Me.Name = "FormRelacionDebeHaber"
        Me.Text = "Relacion Debe-Haber"
        Me.PanelRelacionDebeHaber.ResumeLayout(False)
        Me.PanelRelacionDebeHaber.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRelacionDebeHaber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRelacionDebeHaber As Panel
    Friend WithEvents cbTipoOperacion As ComboBox
    Friend WithEvents lblTipoOperacion As Label
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdRelacionDebeHaber As PersControlLibrary.ExtendedTextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvRelacionDebeHaber As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdContacto As DataGridViewTextBoxColumn
    Friend WithEvents OrigenId As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents CorreoContacto As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents cbSignoDebe As ComboBox
    Friend WithEvents cbEtapaOperacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbGrupoDebe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDebe As ComboBox
    Friend WithEvents cbGrupo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbGrupoHaber As ComboBox
    Friend WithEvents cbSignoHaber As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbHaber As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
