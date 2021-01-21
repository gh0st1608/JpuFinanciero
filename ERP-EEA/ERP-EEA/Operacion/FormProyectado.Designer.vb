<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProyectado
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProyectado = New PersControlLibrary.ExtendedDataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cbPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PanelEgreso = New System.Windows.Forms.Panel()
        Me.lblGrupoEgreso = New System.Windows.Forms.Label()
        Me.cboGrupoEgreso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSubGrupoEgreso = New System.Windows.Forms.ComboBox()
        Me.lblTipoIngreso = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtImporteProyectado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdProyectado = New PersControlLibrary.ExtendedTextBox()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyectado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEgresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEgresoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGrupoEgresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGrupoEgresoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteProvision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProyectado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEgreso.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProyectado
        '
        Me.dgvProyectado.AllowUserToAddRows = False
        Me.dgvProyectado.AllowUserToDeleteRows = False
        Me.dgvProyectado.AllowUserToResizeColumns = False
        Me.dgvProyectado.AllowUserToResizeRows = False
        Me.dgvProyectado.BackgroundColor = System.Drawing.Color.White
        Me.dgvProyectado.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProyectado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProyectado.ColumnHeadersHeight = 20
        Me.dgvProyectado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProyectado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdProyectado, Me.GrupoEgresoId, Me.GrupoEgresoDescripcion, Me.SubGrupoEgresoId, Me.SubGrupoEgresoDescripcion, Me.PeriodoId, Me.Periodo, Me.ImporteProvision})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProyectado.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProyectado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProyectado.EnableHeadersVisualStyles = False
        Me.dgvProyectado.Location = New System.Drawing.Point(11, 41)
        Me.dgvProyectado.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProyectado.Name = "dgvProyectado"
        Me.dgvProyectado.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProyectado.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProyectado.RowHeadersVisible = False
        Me.dgvProyectado.RowHeadersWidth = 22
        Me.dgvProyectado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProyectado.RowTemplate.Height = 18
        Me.dgvProyectado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProyectado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProyectado.Size = New System.Drawing.Size(486, 200)
        Me.dgvProyectado.TabIndex = 483
        Me.dgvProyectado.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(297, 8)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 480
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
        Me.btnNuevo.Location = New System.Drawing.Point(216, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 479
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cbPeriodoFiltro
        '
        Me.cbPeriodoFiltro.FormattingEnabled = True
        Me.cbPeriodoFiltro.Location = New System.Drawing.Point(59, 12)
        Me.cbPeriodoFiltro.Name = "cbPeriodoFiltro"
        Me.cbPeriodoFiltro.Size = New System.Drawing.Size(90, 21)
        Me.cbPeriodoFiltro.TabIndex = 478
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 484
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
        Me.btnEliminar.Location = New System.Drawing.Point(400, 8)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 481
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "[Supr] ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PanelEgreso
        '
        Me.PanelEgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelEgreso.Controls.Add(Me.lblGrupoEgreso)
        Me.PanelEgreso.Controls.Add(Me.cboGrupoEgreso)
        Me.PanelEgreso.Controls.Add(Me.Label1)
        Me.PanelEgreso.Controls.Add(Me.cboSubGrupoEgreso)
        Me.PanelEgreso.Controls.Add(Me.lblTipoIngreso)
        Me.PanelEgreso.Controls.Add(Me.cboPeriodo)
        Me.PanelEgreso.Controls.Add(Me.Label16)
        Me.PanelEgreso.Controls.Add(Me.txtImporteProyectado)
        Me.PanelEgreso.Controls.Add(Me.Label20)
        Me.PanelEgreso.Controls.Add(Me.btnGuardar)
        Me.PanelEgreso.Controls.Add(Me.btnCancelar)
        Me.PanelEgreso.Controls.Add(Me.txtIdProyectado)
        Me.PanelEgreso.Location = New System.Drawing.Point(11, 257)
        Me.PanelEgreso.Name = "PanelEgreso"
        Me.PanelEgreso.Size = New System.Drawing.Size(486, 91)
        Me.PanelEgreso.TabIndex = 485
        '
        'lblGrupoEgreso
        '
        Me.lblGrupoEgreso.AutoSize = True
        Me.lblGrupoEgreso.Location = New System.Drawing.Point(7, 10)
        Me.lblGrupoEgreso.Name = "lblGrupoEgreso"
        Me.lblGrupoEgreso.Size = New System.Drawing.Size(64, 13)
        Me.lblGrupoEgreso.TabIndex = 489
        Me.lblGrupoEgreso.Text = "Tipo Egreso"
        '
        'cboGrupoEgreso
        '
        Me.cboGrupoEgreso.FormattingEnabled = True
        Me.cboGrupoEgreso.Location = New System.Drawing.Point(77, 7)
        Me.cboGrupoEgreso.Name = "cboGrupoEgreso"
        Me.cboGrupoEgreso.Size = New System.Drawing.Size(194, 21)
        Me.cboGrupoEgreso.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 487
        Me.Label1.Text = "(Sin IGV)"
        '
        'cboSubGrupoEgreso
        '
        Me.cboSubGrupoEgreso.FormattingEnabled = True
        Me.cboSubGrupoEgreso.Location = New System.Drawing.Point(77, 32)
        Me.cboSubGrupoEgreso.Name = "cboSubGrupoEgreso"
        Me.cboSubGrupoEgreso.Size = New System.Drawing.Size(194, 21)
        Me.cboSubGrupoEgreso.TabIndex = 12
        '
        'lblTipoIngreso
        '
        Me.lblTipoIngreso.AutoSize = True
        Me.lblTipoIngreso.Location = New System.Drawing.Point(7, 35)
        Me.lblTipoIngreso.Name = "lblTipoIngreso"
        Me.lblTipoIngreso.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoIngreso.TabIndex = 485
        Me.lblTipoIngreso.Text = "Item Egreso"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(394, 7)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(85, 21)
        Me.cboPeriodo.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(343, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "Periodo"
        '
        'txtImporteProyectado
        '
        Me.txtImporteProyectado.Location = New System.Drawing.Point(394, 32)
        Me.txtImporteProyectado.Name = "txtImporteProyectado"
        Me.txtImporteProyectado.Size = New System.Drawing.Size(84, 20)
        Me.txtImporteProyectado.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(289, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 13)
        Me.Label20.TabIndex = 464
        Me.Label20.Text = "Importe Proyectado"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(331, 59)
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
        Me.btnCancelar.Location = New System.Drawing.Point(410, 59)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdProyectado
        '
        Me.txtIdProyectado.AllowClear = True
        Me.txtIdProyectado.AllowNegatives = False
        Me.txtIdProyectado.AllowWhiteSpaces = True
        Me.txtIdProyectado.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdProyectado.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdProyectado.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdProyectado.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdProyectado.EnterIsTab = True
        Me.txtIdProyectado.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdProyectado.Label = "Descripción"
        Me.txtIdProyectado.Location = New System.Drawing.Point(350, 63)
        Me.txtIdProyectado.Mandatory = False
        Me.txtIdProyectado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdProyectado.MaxLength = 100
        Me.txtIdProyectado.MinLength = 0
        Me.txtIdProyectado.Name = "txtIdProyectado"
        Me.txtIdProyectado.Precision = 0
        Me.txtIdProyectado.SelectOnFocus = True
        Me.txtIdProyectado.Size = New System.Drawing.Size(26, 20)
        Me.txtIdProyectado.Symbol = Nothing
        Me.txtIdProyectado.TabIndex = 460
        Me.txtIdProyectado.Value = Nothing
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
        Me.DataGridViewTextBoxColumn7.Width = 28
        '
        'IdProyectado
        '
        Me.IdProyectado.DataPropertyName = "IdProyectado"
        Me.IdProyectado.HeaderText = "IdProyectado"
        Me.IdProyectado.Name = "IdProyectado"
        Me.IdProyectado.ReadOnly = True
        Me.IdProyectado.Visible = False
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
        Me.GrupoEgresoDescripcion.Width = 110
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
        Me.SubGrupoEgresoDescripcion.Width = 170
        '
        'PeriodoId
        '
        Me.PeriodoId.DataPropertyName = "PeriodoId"
        Me.PeriodoId.HeaderText = "PeriodoId"
        Me.PeriodoId.Name = "PeriodoId"
        Me.PeriodoId.ReadOnly = True
        Me.PeriodoId.Visible = False
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "PeriodoDescripcion"
        Me.Periodo.HeaderText = "PERIODO"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        Me.Periodo.Width = 80
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
        Me.ImporteProvision.Width = 80
        '
        'FormProyectado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 358)
        Me.Controls.Add(Me.PanelEgreso)
        Me.Controls.Add(Me.dgvProyectado)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnEliminar)
        Me.MaximumSize = New System.Drawing.Size(525, 397)
        Me.MinimumSize = New System.Drawing.Size(525, 290)
        Me.Name = "FormProyectado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de egreso proyectado"
        CType(Me.dgvProyectado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEgreso.ResumeLayout(False)
        Me.PanelEgreso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProyectado As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PanelEgreso As Panel
    Friend WithEvents lblGrupoEgreso As Label
    Friend WithEvents cboGrupoEgreso As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSubGrupoEgreso As ComboBox
    Friend WithEvents lblTipoIngreso As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtImporteProyectado As TextBox
    Friend WithEvents Label20 As Label
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdProyectado As PersControlLibrary.ExtendedTextBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdProyectado As DataGridViewTextBoxColumn
    Friend WithEvents GrupoEgresoId As DataGridViewTextBoxColumn
    Friend WithEvents GrupoEgresoDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents SubGrupoEgresoId As DataGridViewTextBoxColumn
    Friend WithEvents SubGrupoEgresoDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoId As DataGridViewTextBoxColumn
    Friend WithEvents Periodo As DataGridViewTextBoxColumn
    Friend WithEvents ImporteProvision As DataGridViewTextBoxColumn
End Class
