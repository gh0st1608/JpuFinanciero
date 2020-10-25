<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatrimonio
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPatrimonio = New PersControlLibrary.ExtendedDataGridView()
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
        Me.PanelPatrimonio = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblGrupoPasivo = New System.Windows.Forms.Label()
        Me.cboTipoPatrimonio = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdPatrimonio = New PersControlLibrary.ExtendedTextBox()
        CType(Me.dgvPatrimonio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPatrimonio.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPatrimonio
        '
        Me.dgvPatrimonio.AllowUserToAddRows = False
        Me.dgvPatrimonio.AllowUserToDeleteRows = False
        Me.dgvPatrimonio.AllowUserToResizeColumns = False
        Me.dgvPatrimonio.AllowUserToResizeRows = False
        Me.dgvPatrimonio.BackgroundColor = System.Drawing.Color.White
        Me.dgvPatrimonio.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatrimonio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatrimonio.ColumnHeadersHeight = 20
        Me.dgvPatrimonio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPatrimonio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdActivo, Me.GrupoActivoId, Me.Descripcion, Me.Monto, Me.PeriodoId})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatrimonio.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPatrimonio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPatrimonio.EnableHeadersVisualStyles = False
        Me.dgvPatrimonio.Location = New System.Drawing.Point(14, 44)
        Me.dgvPatrimonio.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPatrimonio.Name = "dgvPatrimonio"
        Me.dgvPatrimonio.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatrimonio.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPatrimonio.RowHeadersVisible = False
        Me.dgvPatrimonio.RowHeadersWidth = 22
        Me.dgvPatrimonio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPatrimonio.RowTemplate.Height = 18
        Me.dgvPatrimonio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPatrimonio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatrimonio.Size = New System.Drawing.Size(425, 200)
        Me.dgvPatrimonio.TabIndex = 504
        Me.dgvPatrimonio.TabStop = False
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
        Me.Descripcion.Width = 200
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Monto.HeaderText = "SUBTOTAL"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'PeriodoId
        '
        Me.PeriodoId.DataPropertyName = "PeriodoId"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoId.DefaultCellStyle = DataGridViewCellStyle4
        Me.PeriodoId.HeaderText = "PERIODO"
        Me.PeriodoId.Name = "PeriodoId"
        Me.PeriodoId.ReadOnly = True
        Me.PeriodoId.Width = 82
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
        Me.Label23.TabIndex = 505
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
        'PanelPatrimonio
        '
        Me.PanelPatrimonio.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelPatrimonio.Controls.Add(Me.Label2)
        Me.PanelPatrimonio.Controls.Add(Me.cboPeriodo)
        Me.PanelPatrimonio.Controls.Add(Me.txtSubTotal)
        Me.PanelPatrimonio.Controls.Add(Me.lblSubtotal)
        Me.PanelPatrimonio.Controls.Add(Me.lblGrupoPasivo)
        Me.PanelPatrimonio.Controls.Add(Me.cboTipoPatrimonio)
        Me.PanelPatrimonio.Controls.Add(Me.btnGuardar)
        Me.PanelPatrimonio.Controls.Add(Me.btnCancelar)
        Me.PanelPatrimonio.Controls.Add(Me.txtIdPatrimonio)
        Me.PanelPatrimonio.Location = New System.Drawing.Point(14, 260)
        Me.PanelPatrimonio.Name = "PanelPatrimonio"
        Me.PanelPatrimonio.Size = New System.Drawing.Size(425, 94)
        Me.PanelPatrimonio.TabIndex = 506
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
        Me.lblSubtotal.Location = New System.Drawing.Point(266, 38)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(50, 13)
        Me.lblSubtotal.TabIndex = 494
        Me.lblSubtotal.Text = "SubTotal"
        '
        'lblGrupoPasivo
        '
        Me.lblGrupoPasivo.AutoSize = True
        Me.lblGrupoPasivo.Location = New System.Drawing.Point(6, 10)
        Me.lblGrupoPasivo.Name = "lblGrupoPasivo"
        Me.lblGrupoPasivo.Size = New System.Drawing.Size(80, 13)
        Me.lblGrupoPasivo.TabIndex = 489
        Me.lblGrupoPasivo.Text = "Tipo Patrimonio"
        '
        'cboTipoPatrimonio
        '
        Me.cboTipoPatrimonio.FormattingEnabled = True
        Me.cboTipoPatrimonio.Location = New System.Drawing.Point(92, 7)
        Me.cboTipoPatrimonio.Name = "cboTipoPatrimonio"
        Me.cboTipoPatrimonio.Size = New System.Drawing.Size(151, 21)
        Me.cboTipoPatrimonio.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(269, 61)
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
        Me.btnCancelar.Location = New System.Drawing.Point(348, 61)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdPatrimonio
        '
        Me.txtIdPatrimonio.AllowClear = True
        Me.txtIdPatrimonio.AllowNegatives = False
        Me.txtIdPatrimonio.AllowWhiteSpaces = True
        Me.txtIdPatrimonio.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdPatrimonio.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdPatrimonio.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdPatrimonio.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdPatrimonio.EnterIsTab = True
        Me.txtIdPatrimonio.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdPatrimonio.Label = "Descripción"
        Me.txtIdPatrimonio.Location = New System.Drawing.Point(288, 65)
        Me.txtIdPatrimonio.Mandatory = False
        Me.txtIdPatrimonio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdPatrimonio.MaxLength = 100
        Me.txtIdPatrimonio.MinLength = 0
        Me.txtIdPatrimonio.Name = "txtIdPatrimonio"
        Me.txtIdPatrimonio.Precision = 0
        Me.txtIdPatrimonio.SelectOnFocus = True
        Me.txtIdPatrimonio.Size = New System.Drawing.Size(26, 20)
        Me.txtIdPatrimonio.Symbol = Nothing
        Me.txtIdPatrimonio.TabIndex = 460
        Me.txtIdPatrimonio.Value = Nothing
        '
        'FormPatrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 369)
        Me.Controls.Add(Me.dgvPatrimonio)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PanelPatrimonio)
        Me.KeyPreview = True
        Me.Name = "FormPatrimonio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patrimonio"
        CType(Me.dgvPatrimonio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPatrimonio.ResumeLayout(False)
        Me.PanelPatrimonio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPatrimonio As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PanelPatrimonio As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblGrupoPasivo As Label
    Friend WithEvents cboTipoPatrimonio As ComboBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdPatrimonio As PersControlLibrary.ExtendedTextBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdActivo As DataGridViewTextBoxColumn
    Friend WithEvents GrupoActivoId As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoId As DataGridViewTextBoxColumn
End Class
