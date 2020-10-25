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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.IdRelacionDebeHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoOperacionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtapaOperacionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionEtapaOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoDebeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoHaberId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionSignoDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionSignoHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignoDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignoHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PanelRelacionDebeHaber.Location = New System.Drawing.Point(12, 357)
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
        Me.cbGrupoHaber.TabIndex = 16
        '
        'cbSignoHaber
        '
        Me.cbSignoHaber.FormattingEnabled = True
        Me.cbSignoHaber.Items.AddRange(New Object() {"Seleccione", "Positivo", "Negativo"})
        Me.cbSignoHaber.Location = New System.Drawing.Point(53, 73)
        Me.cbSignoHaber.Name = "cbSignoHaber"
        Me.cbSignoHaber.Size = New System.Drawing.Size(130, 21)
        Me.cbSignoHaber.TabIndex = 18
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
        Me.cbHaber.TabIndex = 17
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
        Me.cbGrupoDebe.TabIndex = 13
        '
        'cbSignoDebe
        '
        Me.cbSignoDebe.AutoCompleteCustomSource.AddRange(New String() {"Positivo", "Negativo"})
        Me.cbSignoDebe.FormattingEnabled = True
        Me.cbSignoDebe.Items.AddRange(New Object() {"Seleccione", "Positivo", "Negativo"})
        Me.cbSignoDebe.Location = New System.Drawing.Point(53, 73)
        Me.cbSignoDebe.Name = "cbSignoDebe"
        Me.cbSignoDebe.Size = New System.Drawing.Size(130, 21)
        Me.cbSignoDebe.TabIndex = 15
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
        Me.cbDebe.TabIndex = 14
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
        Me.cbEtapaOperacion.TabIndex = 11
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
        Me.cbTipoOperacion.TabIndex = 10
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
        Me.cbGrupo.TabIndex = 12
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(487, 120)
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
        Me.btnCancelar.Location = New System.Drawing.Point(565, 120)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
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
        Me.btnModificar.Location = New System.Drawing.Point(458, 15)
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
        Me.btnNuevo.Location = New System.Drawing.Point(377, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 1
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRelacionDebeHaber.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRelacionDebeHaber.ColumnHeadersHeight = 20
        Me.dgvRelacionDebeHaber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRelacionDebeHaber.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdRelacionDebeHaber, Me.TipoOperacionId, Me.EtapaOperacionId, Me.GrupoId, Me.DescripcionGrupo, Me.DescripcionEtapaOperacion, Me.GrupoDebeId, Me.GrupoHaberId, Me.DebeId, Me.DescripcionSignoDebe, Me.DescripcionDebe, Me.HaberId, Me.DescripcionSignoHaber, Me.DescripcionHaber, Me.SignoDebe, Me.SignoHaber})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelacionDebeHaber.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRelacionDebeHaber.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRelacionDebeHaber.EnableHeadersVisualStyles = False
        Me.dgvRelacionDebeHaber.Location = New System.Drawing.Point(11, 50)
        Me.dgvRelacionDebeHaber.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRelacionDebeHaber.Name = "dgvRelacionDebeHaber"
        Me.dgvRelacionDebeHaber.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRelacionDebeHaber.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRelacionDebeHaber.RowHeadersVisible = False
        Me.dgvRelacionDebeHaber.RowHeadersWidth = 22
        Me.dgvRelacionDebeHaber.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRelacionDebeHaber.RowTemplate.Height = 18
        Me.dgvRelacionDebeHaber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRelacionDebeHaber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelacionDebeHaber.Size = New System.Drawing.Size(646, 290)
        Me.dgvRelacionDebeHaber.TabIndex = 492
        Me.dgvRelacionDebeHaber.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Item"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'IdRelacionDebeHaber
        '
        Me.IdRelacionDebeHaber.DataPropertyName = "IdRelacionDebeHaber"
        Me.IdRelacionDebeHaber.HeaderText = "IdRelacionDebeHaber"
        Me.IdRelacionDebeHaber.Name = "IdRelacionDebeHaber"
        Me.IdRelacionDebeHaber.ReadOnly = True
        Me.IdRelacionDebeHaber.Visible = False
        '
        'TipoOperacionId
        '
        Me.TipoOperacionId.DataPropertyName = "TipoOperacionId"
        Me.TipoOperacionId.HeaderText = "TipoOperacionId"
        Me.TipoOperacionId.Name = "TipoOperacionId"
        Me.TipoOperacionId.ReadOnly = True
        Me.TipoOperacionId.Visible = False
        '
        'EtapaOperacionId
        '
        Me.EtapaOperacionId.DataPropertyName = "EtapaOperacionId"
        Me.EtapaOperacionId.HeaderText = "EtapaOperacionId"
        Me.EtapaOperacionId.Name = "EtapaOperacionId"
        Me.EtapaOperacionId.ReadOnly = True
        Me.EtapaOperacionId.Visible = False
        '
        'GrupoId
        '
        Me.GrupoId.DataPropertyName = "GrupoId"
        Me.GrupoId.HeaderText = "GrupoId"
        Me.GrupoId.Name = "GrupoId"
        Me.GrupoId.ReadOnly = True
        Me.GrupoId.Visible = False
        '
        'DescripcionGrupo
        '
        Me.DescripcionGrupo.DataPropertyName = "DescripcionGrupo"
        Me.DescripcionGrupo.HeaderText = "OPERACION"
        Me.DescripcionGrupo.Name = "DescripcionGrupo"
        Me.DescripcionGrupo.ReadOnly = True
        Me.DescripcionGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DescripcionGrupo.Width = 188
        '
        'DescripcionEtapaOperacion
        '
        Me.DescripcionEtapaOperacion.DataPropertyName = "DescripcionEtapaOperacion"
        Me.DescripcionEtapaOperacion.HeaderText = "ETAPA"
        Me.DescripcionEtapaOperacion.Name = "DescripcionEtapaOperacion"
        Me.DescripcionEtapaOperacion.ReadOnly = True
        Me.DescripcionEtapaOperacion.Width = 130
        '
        'GrupoDebeId
        '
        Me.GrupoDebeId.DataPropertyName = "GrupoDebeId"
        Me.GrupoDebeId.HeaderText = "GrupoDebeId"
        Me.GrupoDebeId.Name = "GrupoDebeId"
        Me.GrupoDebeId.ReadOnly = True
        Me.GrupoDebeId.Visible = False
        '
        'GrupoHaberId
        '
        Me.GrupoHaberId.DataPropertyName = "GrupoHaberId"
        Me.GrupoHaberId.HeaderText = "GrupoHaberId"
        Me.GrupoHaberId.Name = "GrupoHaberId"
        Me.GrupoHaberId.ReadOnly = True
        Me.GrupoHaberId.Visible = False
        '
        'DebeId
        '
        Me.DebeId.DataPropertyName = "DebeId"
        Me.DebeId.HeaderText = "DebeId"
        Me.DebeId.Name = "DebeId"
        Me.DebeId.ReadOnly = True
        Me.DebeId.Visible = False
        '
        'DescripcionSignoDebe
        '
        Me.DescripcionSignoDebe.DataPropertyName = "DescripcionSignoDebe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DescripcionSignoDebe.DefaultCellStyle = DataGridViewCellStyle3
        Me.DescripcionSignoDebe.HeaderText = ""
        Me.DescripcionSignoDebe.Name = "DescripcionSignoDebe"
        Me.DescripcionSignoDebe.ReadOnly = True
        Me.DescripcionSignoDebe.Width = 20
        '
        'DescripcionDebe
        '
        Me.DescripcionDebe.DataPropertyName = "DescripcionDebe"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.DescripcionDebe.DefaultCellStyle = DataGridViewCellStyle4
        Me.DescripcionDebe.HeaderText = "DEBE"
        Me.DescripcionDebe.Name = "DescripcionDebe"
        Me.DescripcionDebe.ReadOnly = True
        Me.DescripcionDebe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DescripcionDebe.Width = 120
        '
        'HaberId
        '
        Me.HaberId.DataPropertyName = "HaberId"
        Me.HaberId.HeaderText = "HaberId"
        Me.HaberId.Name = "HaberId"
        Me.HaberId.ReadOnly = True
        Me.HaberId.Visible = False
        '
        'DescripcionSignoHaber
        '
        Me.DescripcionSignoHaber.DataPropertyName = "DescripcionSignoHaber"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DescripcionSignoHaber.DefaultCellStyle = DataGridViewCellStyle5
        Me.DescripcionSignoHaber.HeaderText = ""
        Me.DescripcionSignoHaber.Name = "DescripcionSignoHaber"
        Me.DescripcionSignoHaber.ReadOnly = True
        Me.DescripcionSignoHaber.Width = 20
        '
        'DescripcionHaber
        '
        Me.DescripcionHaber.DataPropertyName = "DescripcionHaber"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DescripcionHaber.DefaultCellStyle = DataGridViewCellStyle6
        Me.DescripcionHaber.HeaderText = "HABER"
        Me.DescripcionHaber.Name = "DescripcionHaber"
        Me.DescripcionHaber.ReadOnly = True
        Me.DescripcionHaber.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DescripcionHaber.Width = 120
        '
        'SignoDebe
        '
        Me.SignoDebe.DataPropertyName = "SignoDebe"
        Me.SignoDebe.HeaderText = "SignoDebe"
        Me.SignoDebe.Name = "SignoDebe"
        Me.SignoDebe.ReadOnly = True
        Me.SignoDebe.Visible = False
        '
        'SignoHaber
        '
        Me.SignoHaber.DataPropertyName = "SignoHaber"
        Me.SignoHaber.HeaderText = "SignoHaber"
        Me.SignoHaber.Name = "SignoHaber"
        Me.SignoHaber.ReadOnly = True
        Me.SignoHaber.Visible = False
        '
        'FormRelacionDebeHaber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 524)
        Me.Controls.Add(Me.PanelRelacionDebeHaber)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvRelacionDebeHaber)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(685, 563)
        Me.MinimumSize = New System.Drawing.Size(685, 393)
        Me.Name = "FormRelacionDebeHaber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relación Debe-Haber"
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdRelacionDebeHaber As DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacionId As DataGridViewTextBoxColumn
    Friend WithEvents EtapaOperacionId As DataGridViewTextBoxColumn
    Friend WithEvents GrupoId As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionGrupo As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionEtapaOperacion As DataGridViewTextBoxColumn
    Friend WithEvents GrupoDebeId As DataGridViewTextBoxColumn
    Friend WithEvents GrupoHaberId As DataGridViewTextBoxColumn
    Friend WithEvents DebeId As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionSignoDebe As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDebe As DataGridViewTextBoxColumn
    Friend WithEvents HaberId As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionSignoHaber As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionHaber As DataGridViewTextBoxColumn
    Friend WithEvents SignoDebe As DataGridViewTextBoxColumn
    Friend WithEvents SignoHaber As DataGridViewTextBoxColumn
End Class
