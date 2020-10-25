<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActivo
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvActivo = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoActivoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cbPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PanelActivo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblGrupoEgreso = New System.Windows.Forms.Label()
        Me.cboTipoActivo = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdActivo = New PersControlLibrary.ExtendedTextBox()
        CType(Me.dgvActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvActivo
        '
        Me.dgvActivo.AllowUserToAddRows = False
        Me.dgvActivo.AllowUserToDeleteRows = False
        Me.dgvActivo.AllowUserToResizeColumns = False
        Me.dgvActivo.AllowUserToResizeRows = False
        Me.dgvActivo.BackgroundColor = System.Drawing.Color.White
        Me.dgvActivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActivo.ColumnHeadersHeight = 20
        Me.dgvActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdActivo, Me.GrupoActivoId, Me.Descripcion, Me.Monto, Me.PeriodoId})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActivo.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvActivo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvActivo.EnableHeadersVisualStyles = False
        Me.dgvActivo.Location = New System.Drawing.Point(14, 44)
        Me.dgvActivo.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvActivo.Name = "dgvActivo"
        Me.dgvActivo.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivo.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvActivo.RowHeadersVisible = False
        Me.dgvActivo.RowHeadersWidth = 22
        Me.dgvActivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvActivo.RowTemplate.Height = 18
        Me.dgvActivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvActivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivo.Size = New System.Drawing.Size(427, 200)
        Me.dgvActivo.TabIndex = 490
        Me.dgvActivo.TabStop = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "item"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Width = 25
        '
        'IdActivo
        '
        Me.IdActivo.DataPropertyName = "IdActivo"
        Me.IdActivo.HeaderText = "IdActivo"
        Me.IdActivo.Name = "IdActivo"
        Me.IdActivo.ReadOnly = True
        Me.IdActivo.Visible = False
        '
        'GrupoActivoId
        '
        Me.GrupoActivoId.DataPropertyName = "GrupoActivoId"
        Me.GrupoActivoId.HeaderText = "GrupoActivoId"
        Me.GrupoActivoId.Name = "GrupoActivoId"
        Me.GrupoActivoId.ReadOnly = True
        Me.GrupoActivoId.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "NOMBRE"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.Width = 202
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        Me.Monto.HeaderText = "SUBTOTAL"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'PeriodoId
        '
        Me.PeriodoId.DataPropertyName = "PeriodoId"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoId.DefaultCellStyle = DataGridViewCellStyle8
        Me.PeriodoId.HeaderText = "PERIODO"
        Me.PeriodoId.Name = "PeriodoId"
        Me.PeriodoId.ReadOnly = True
        Me.PeriodoId.Width = 80
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(239, 11)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 26)
        Me.btnModificar.TabIndex = 3
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
        Me.btnNuevo.Location = New System.Drawing.Point(158, 11)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cbPeriodoFiltro
        '
        Me.cbPeriodoFiltro.FormattingEnabled = True
        Me.cbPeriodoFiltro.Location = New System.Drawing.Point(62, 15)
        Me.cbPeriodoFiltro.Name = "cbPeriodoFiltro"
        Me.cbPeriodoFiltro.Size = New System.Drawing.Size(75, 21)
        Me.cbPeriodoFiltro.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 491
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
        Me.btnEliminar.Location = New System.Drawing.Point(342, 11)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "[Supr] ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PanelActivo
        '
        Me.PanelActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelActivo.Controls.Add(Me.Label2)
        Me.PanelActivo.Controls.Add(Me.cboPeriodo)
        Me.PanelActivo.Controls.Add(Me.txtSubTotal)
        Me.PanelActivo.Controls.Add(Me.lblSubtotal)
        Me.PanelActivo.Controls.Add(Me.lblGrupoEgreso)
        Me.PanelActivo.Controls.Add(Me.cboTipoActivo)
        Me.PanelActivo.Controls.Add(Me.btnGuardar)
        Me.PanelActivo.Controls.Add(Me.btnCancelar)
        Me.PanelActivo.Controls.Add(Me.txtIdActivo)
        Me.PanelActivo.Location = New System.Drawing.Point(14, 259)
        Me.PanelActivo.Name = "PanelActivo"
        Me.PanelActivo.Size = New System.Drawing.Size(427, 95)
        Me.PanelActivo.TabIndex = 492
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 502
        Me.Label2.Text = "Periodo"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(323, 8)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(94, 21)
        Me.cboPeriodo.TabIndex = 11
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(323, 35)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(94, 20)
        Me.txtSubTotal.TabIndex = 12
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(267, 38)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(50, 13)
        Me.lblSubtotal.TabIndex = 494
        Me.lblSubtotal.Text = "SubTotal"
        '
        'lblGrupoEgreso
        '
        Me.lblGrupoEgreso.AutoSize = True
        Me.lblGrupoEgreso.Location = New System.Drawing.Point(6, 10)
        Me.lblGrupoEgreso.Name = "lblGrupoEgreso"
        Me.lblGrupoEgreso.Size = New System.Drawing.Size(61, 13)
        Me.lblGrupoEgreso.TabIndex = 489
        Me.lblGrupoEgreso.Text = "Tipo Activo"
        '
        'cboTipoActivo
        '
        Me.cboTipoActivo.FormattingEnabled = True
        Me.cboTipoActivo.Location = New System.Drawing.Point(70, 7)
        Me.cboTipoActivo.Name = "cboTipoActivo"
        Me.cboTipoActivo.Size = New System.Drawing.Size(151, 21)
        Me.cboTipoActivo.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(269, 63)
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
        Me.btnCancelar.Location = New System.Drawing.Point(348, 63)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdActivo
        '
        Me.txtIdActivo.AllowClear = True
        Me.txtIdActivo.AllowNegatives = False
        Me.txtIdActivo.AllowWhiteSpaces = True
        Me.txtIdActivo.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdActivo.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdActivo.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdActivo.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdActivo.EnterIsTab = True
        Me.txtIdActivo.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdActivo.Label = "Descripción"
        Me.txtIdActivo.Location = New System.Drawing.Point(288, 67)
        Me.txtIdActivo.Mandatory = False
        Me.txtIdActivo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdActivo.MaxLength = 100
        Me.txtIdActivo.MinLength = 0
        Me.txtIdActivo.Name = "txtIdActivo"
        Me.txtIdActivo.Precision = 0
        Me.txtIdActivo.SelectOnFocus = True
        Me.txtIdActivo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdActivo.Symbol = Nothing
        Me.txtIdActivo.TabIndex = 460
        Me.txtIdActivo.Value = Nothing
        '
        'FormActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 365)
        Me.Controls.Add(Me.dgvActivo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PanelActivo)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(472, 404)
        Me.MinimumSize = New System.Drawing.Size(472, 295)
        Me.Name = "FormActivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Activo"
        CType(Me.dgvActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelActivo.ResumeLayout(False)
        Me.PanelActivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvActivo As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PanelActivo As Panel
    Friend WithEvents lblGrupoEgreso As Label
    Friend WithEvents cboTipoActivo As ComboBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdActivo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdActivo As DataGridViewTextBoxColumn
    Friend WithEvents GrupoActivoId As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoId As DataGridViewTextBoxColumn
End Class
