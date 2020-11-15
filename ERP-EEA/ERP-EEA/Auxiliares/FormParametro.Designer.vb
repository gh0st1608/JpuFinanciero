<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParametro
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
        Me.dgvParametro = New PersControlLibrary.ExtendedDataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdParametro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoParametro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorParametro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboTipoParametro = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtValorParametro = New PersControlLibrary.ExtendedTextBox()
        Me.lblTipoParametro = New System.Windows.Forms.Label()
        Me.lblNombreParametro = New System.Windows.Forms.Label()
        Me.txtDescripcion = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdParametro = New PersControlLibrary.ExtendedTextBox()
        CType(Me.dgvParametro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvParametro
        '
        Me.dgvParametro.AllowUserToAddRows = False
        Me.dgvParametro.AllowUserToDeleteRows = False
        Me.dgvParametro.AllowUserToResizeColumns = False
        Me.dgvParametro.AllowUserToResizeRows = False
        Me.dgvParametro.BackgroundColor = System.Drawing.Color.White
        Me.dgvParametro.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvParametro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvParametro.ColumnHeadersHeight = 30
        Me.dgvParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvParametro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.IdParametro, Me.TipoParametro, Me.Descripcion, Me.ValorParametro, Me.IdEstadoActivo, Me.EstadoActivo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvParametro.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvParametro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvParametro.EnableHeadersVisualStyles = False
        Me.dgvParametro.Location = New System.Drawing.Point(11, 50)
        Me.dgvParametro.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvParametro.Name = "dgvParametro"
        Me.dgvParametro.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvParametro.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvParametro.RowHeadersVisible = False
        Me.dgvParametro.RowHeadersWidth = 22
        Me.dgvParametro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvParametro.RowTemplate.Height = 18
        Me.dgvParametro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvParametro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParametro.Size = New System.Drawing.Size(620, 210)
        Me.dgvParametro.TabIndex = 467
        Me.dgvParametro.TabStop = False
        '
        'item
        '
        Me.item.DataPropertyName = "item"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.item.DefaultCellStyle = DataGridViewCellStyle2
        Me.item.HeaderText = "N°"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.item.Width = 25
        '
        'IdParametro
        '
        Me.IdParametro.DataPropertyName = "IdParametro"
        Me.IdParametro.HeaderText = "IdParametro"
        Me.IdParametro.Name = "IdParametro"
        Me.IdParametro.ReadOnly = True
        Me.IdParametro.Visible = False
        '
        'TipoParametro
        '
        Me.TipoParametro.DataPropertyName = "TipoParametro"
        Me.TipoParametro.HeaderText = "TIPO PARAMETRO"
        Me.TipoParametro.Name = "TipoParametro"
        Me.TipoParametro.ReadOnly = True
        Me.TipoParametro.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "NOMBRE PARAMETRO"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion.Width = 315
        '
        'ValorParametro
        '
        Me.ValorParametro.DataPropertyName = "ValorParametro"
        Me.ValorParametro.HeaderText = "VALOR PARAMETRO"
        Me.ValorParametro.Name = "ValorParametro"
        Me.ValorParametro.ReadOnly = True
        Me.ValorParametro.Width = 90
        '
        'IdEstadoActivo
        '
        Me.IdEstadoActivo.DataPropertyName = "IdEstadoActivo"
        Me.IdEstadoActivo.HeaderText = "IdEstadoActivo"
        Me.IdEstadoActivo.Name = "IdEstadoActivo"
        Me.IdEstadoActivo.ReadOnly = True
        Me.IdEstadoActivo.Visible = False
        Me.IdEstadoActivo.Width = 120
        '
        'EstadoActivo
        '
        Me.EstadoActivo.DataPropertyName = "EstadoActivo"
        Me.EstadoActivo.HeaderText = "ESTADO"
        Me.EstadoActivo.Name = "EstadoActivo"
        Me.EstadoActivo.ReadOnly = True
        Me.EstadoActivo.Width = 90
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(533, 15)
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
        Me.btnModificar.Location = New System.Drawing.Point(430, 15)
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
        Me.btnNuevo.Location = New System.Drawing.Point(349, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 26)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel.Controls.Add(Me.cboEstado)
        Me.Panel.Controls.Add(Me.lblEstado)
        Me.Panel.Controls.Add(Me.cboTipoParametro)
        Me.Panel.Controls.Add(Me.lblDescripcion)
        Me.Panel.Controls.Add(Me.txtValorParametro)
        Me.Panel.Controls.Add(Me.lblTipoParametro)
        Me.Panel.Controls.Add(Me.lblNombreParametro)
        Me.Panel.Controls.Add(Me.txtDescripcion)
        Me.Panel.Controls.Add(Me.btnGuardar)
        Me.Panel.Controls.Add(Me.btnCancelar)
        Me.Panel.Controls.Add(Me.txtIdParametro)
        Me.Panel.Location = New System.Drawing.Point(11, 277)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(615, 99)
        Me.Panel.TabIndex = 463
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboEstado.Location = New System.Drawing.Point(442, 36)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(160, 21)
        Me.cboEstado.TabIndex = 471
        Me.cboEstado.TabStop = False
        Me.cboEstado.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(357, 37)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 470
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.Visible = False
        '
        'cboTipoParametro
        '
        Me.cboTipoParametro.FormattingEnabled = True
        Me.cboTipoParametro.Items.AddRange(New Object() {"Selecciones", "Auxiliar", "Medicion"})
        Me.cboTipoParametro.Location = New System.Drawing.Point(442, 9)
        Me.cboTipoParametro.Name = "cboTipoParametro"
        Me.cboTipoParametro.Size = New System.Drawing.Size(160, 21)
        Me.cboTipoParametro.TabIndex = 12
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(9, 37)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 13)
        Me.lblDescripcion.TabIndex = 467
        Me.lblDescripcion.Text = "Valor Parametro"
        '
        'txtValorParametro
        '
        Me.txtValorParametro.AllowClear = True
        Me.txtValorParametro.AllowNegatives = False
        Me.txtValorParametro.AllowWhiteSpaces = True
        Me.txtValorParametro.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValorParametro.BackColorIdle = System.Drawing.Color.Empty
        Me.txtValorParametro.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtValorParametro.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtValorParametro.EnterIsTab = True
        Me.txtValorParametro.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtValorParametro.Label = "Descripción"
        Me.txtValorParametro.Location = New System.Drawing.Point(112, 34)
        Me.txtValorParametro.Mandatory = False
        Me.txtValorParametro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorParametro.MaxLength = 100
        Me.txtValorParametro.MinLength = 0
        Me.txtValorParametro.Name = "txtValorParametro"
        Me.txtValorParametro.Precision = 0
        Me.txtValorParametro.SelectOnFocus = True
        Me.txtValorParametro.Size = New System.Drawing.Size(144, 20)
        Me.txtValorParametro.Symbol = Nothing
        Me.txtValorParametro.TabIndex = 11
        Me.txtValorParametro.Value = Nothing
        '
        'lblTipoParametro
        '
        Me.lblTipoParametro.AutoSize = True
        Me.lblTipoParametro.Location = New System.Drawing.Point(357, 12)
        Me.lblTipoParametro.Name = "lblTipoParametro"
        Me.lblTipoParametro.Size = New System.Drawing.Size(79, 13)
        Me.lblTipoParametro.TabIndex = 465
        Me.lblTipoParametro.Text = "Tipo Parametro"
        '
        'lblNombreParametro
        '
        Me.lblNombreParametro.AutoSize = True
        Me.lblNombreParametro.Location = New System.Drawing.Point(9, 13)
        Me.lblNombreParametro.Name = "lblNombreParametro"
        Me.lblNombreParametro.Size = New System.Drawing.Size(95, 13)
        Me.lblNombreParametro.TabIndex = 461
        Me.lblNombreParametro.Text = "Nombre Parametro"
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
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 10)
        Me.txtDescripcion.Mandatory = False
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MinLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Precision = 0
        Me.txtDescripcion.SelectOnFocus = True
        Me.txtDescripcion.Size = New System.Drawing.Size(224, 20)
        Me.txtDescripcion.Symbol = Nothing
        Me.txtDescripcion.TabIndex = 10
        Me.txtDescripcion.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(454, 63)
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
        Me.btnCancelar.Location = New System.Drawing.Point(533, 63)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdParametro
        '
        Me.txtIdParametro.AllowClear = True
        Me.txtIdParametro.AllowNegatives = False
        Me.txtIdParametro.AllowWhiteSpaces = True
        Me.txtIdParametro.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdParametro.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdParametro.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdParametro.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdParametro.EnterIsTab = True
        Me.txtIdParametro.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdParametro.Label = "Descripción"
        Me.txtIdParametro.Location = New System.Drawing.Point(482, 67)
        Me.txtIdParametro.Mandatory = False
        Me.txtIdParametro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdParametro.MaxLength = 100
        Me.txtIdParametro.MinLength = 0
        Me.txtIdParametro.Name = "txtIdParametro"
        Me.txtIdParametro.Precision = 0
        Me.txtIdParametro.SelectOnFocus = True
        Me.txtIdParametro.Size = New System.Drawing.Size(26, 20)
        Me.txtIdParametro.Symbol = Nothing
        Me.txtIdParametro.TabIndex = 460
        Me.txtIdParametro.Value = Nothing
        '
        'FormParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 389)
        Me.Controls.Add(Me.dgvParametro)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(658, 428)
        Me.MinimumSize = New System.Drawing.Size(658, 316)
        Me.Name = "FormParametro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros"
        CType(Me.dgvParametro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvParametro As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents cboTipoParametro As ComboBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtValorParametro As PersControlLibrary.ExtendedTextBox
    Friend WithEvents lblTipoParametro As Label
    Friend WithEvents lblNombreParametro As Label
    Friend WithEvents txtDescripcion As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdParametro As PersControlLibrary.ExtendedTextBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents IdParametro As DataGridViewTextBoxColumn
    Friend WithEvents TipoParametro As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents ValorParametro As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
End Class
