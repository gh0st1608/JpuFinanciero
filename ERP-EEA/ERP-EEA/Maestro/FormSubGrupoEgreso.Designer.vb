﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSubGrupoEgreso
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSubGrupoEgreso = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSubGrupoEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEgresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemSubGrupoEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.cboGrupoEgreso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdSubGrupoEgreso = New PersControlLibrary.ExtendedTextBox()
        CType(Me.dgvSubGrupoEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSubGrupoEgreso
        '
        Me.dgvSubGrupoEgreso.AllowUserToAddRows = False
        Me.dgvSubGrupoEgreso.AllowUserToDeleteRows = False
        Me.dgvSubGrupoEgreso.AllowUserToResizeColumns = False
        Me.dgvSubGrupoEgreso.AllowUserToResizeRows = False
        Me.dgvSubGrupoEgreso.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubGrupoEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubGrupoEgreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubGrupoEgreso.ColumnHeadersHeight = 20
        Me.dgvSubGrupoEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSubGrupoEgreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdSubGrupoEgreso, Me.GrupoEgresoId, Me.ItemSubGrupoEgreso, Me.EstadoActivo, Me.IdEstadoActivo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubGrupoEgreso.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSubGrupoEgreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubGrupoEgreso.EnableHeadersVisualStyles = False
        Me.dgvSubGrupoEgreso.Location = New System.Drawing.Point(11, 44)
        Me.dgvSubGrupoEgreso.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSubGrupoEgreso.Name = "dgvSubGrupoEgreso"
        Me.dgvSubGrupoEgreso.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubGrupoEgreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSubGrupoEgreso.RowHeadersVisible = False
        Me.dgvSubGrupoEgreso.RowHeadersWidth = 22
        Me.dgvSubGrupoEgreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSubGrupoEgreso.RowTemplate.Height = 18
        Me.dgvSubGrupoEgreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSubGrupoEgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubGrupoEgreso.Size = New System.Drawing.Size(415, 200)
        Me.dgvSubGrupoEgreso.TabIndex = 462
        Me.dgvSubGrupoEgreso.TabStop = False
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
        'IdSubGrupoEgreso
        '
        Me.IdSubGrupoEgreso.DataPropertyName = "IdSubGrupoEgreso"
        Me.IdSubGrupoEgreso.HeaderText = "IdSubGrupoEgreso"
        Me.IdSubGrupoEgreso.Name = "IdSubGrupoEgreso"
        Me.IdSubGrupoEgreso.ReadOnly = True
        Me.IdSubGrupoEgreso.Visible = False
        '
        'GrupoEgresoId
        '
        Me.GrupoEgresoId.DataPropertyName = "GrupoEgresoId"
        Me.GrupoEgresoId.HeaderText = "GrupoEgresoId"
        Me.GrupoEgresoId.Name = "GrupoEgresoId"
        Me.GrupoEgresoId.ReadOnly = True
        Me.GrupoEgresoId.Visible = False
        '
        'ItemSubGrupoEgreso
        '
        Me.ItemSubGrupoEgreso.DataPropertyName = "ItemSubGrupoEgreso"
        Me.ItemSubGrupoEgreso.HeaderText = "NOMBRE"
        Me.ItemSubGrupoEgreso.Name = "ItemSubGrupoEgreso"
        Me.ItemSubGrupoEgreso.ReadOnly = True
        Me.ItemSubGrupoEgreso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemSubGrupoEgreso.Width = 270
        '
        'EstadoActivo
        '
        Me.EstadoActivo.DataPropertyName = "EstadoActivo"
        Me.EstadoActivo.HeaderText = "ESTADO"
        Me.EstadoActivo.Name = "EstadoActivo"
        Me.EstadoActivo.ReadOnly = True
        '
        'IdEstadoActivo
        '
        Me.IdEstadoActivo.DataPropertyName = "IdEstadoActivo"
        Me.IdEstadoActivo.HeaderText = "IdEstadoActivo"
        Me.IdEstadoActivo.Name = "IdEstadoActivo"
        Me.IdEstadoActivo.ReadOnly = True
        Me.IdEstadoActivo.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(327, 11)
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
        Me.btnModificar.Location = New System.Drawing.Point(224, 11)
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
        Me.btnNuevo.Location = New System.Drawing.Point(143, 11)
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
        Me.Panel.Controls.Add(Me.cboGrupoEgreso)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.lbEstado)
        Me.Panel.Controls.Add(Me.cboEstado)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.txtDescripcion)
        Me.Panel.Controls.Add(Me.btnGuardar)
        Me.Panel.Controls.Add(Me.btnCancelar)
        Me.Panel.Controls.Add(Me.txtIdSubGrupoEgreso)
        Me.Panel.Location = New System.Drawing.Point(11, 259)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(414, 93)
        Me.Panel.TabIndex = 458
        '
        'cboGrupoEgreso
        '
        Me.cboGrupoEgreso.FormattingEnabled = True
        Me.cboGrupoEgreso.Location = New System.Drawing.Point(87, 8)
        Me.cboGrupoEgreso.Name = "cboGrupoEgreso"
        Me.cboGrupoEgreso.Size = New System.Drawing.Size(318, 21)
        Me.cboGrupoEgreso.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 463
        Me.Label1.Text = "Grupo Egreso"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(9, 66)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 463
        Me.lbEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboEstado.Location = New System.Drawing.Point(87, 63)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 462
        Me.cboEstado.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 461
        Me.Label2.Text = "Descripción"
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
        Me.txtDescripcion.Location = New System.Drawing.Point(87, 36)
        Me.txtDescripcion.Mandatory = False
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MinLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Precision = 0
        Me.txtDescripcion.SelectOnFocus = True
        Me.txtDescripcion.Size = New System.Drawing.Size(318, 20)
        Me.txtDescripcion.Symbol = Nothing
        Me.txtDescripcion.TabIndex = 11
        Me.txtDescripcion.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(257, 61)
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
        Me.btnCancelar.Location = New System.Drawing.Point(336, 61)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdSubGrupoEgreso
        '
        Me.txtIdSubGrupoEgreso.AllowClear = True
        Me.txtIdSubGrupoEgreso.AllowNegatives = False
        Me.txtIdSubGrupoEgreso.AllowWhiteSpaces = True
        Me.txtIdSubGrupoEgreso.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdSubGrupoEgreso.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdSubGrupoEgreso.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdSubGrupoEgreso.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdSubGrupoEgreso.EnterIsTab = True
        Me.txtIdSubGrupoEgreso.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdSubGrupoEgreso.Label = "Descripción"
        Me.txtIdSubGrupoEgreso.Location = New System.Drawing.Point(278, 65)
        Me.txtIdSubGrupoEgreso.Mandatory = False
        Me.txtIdSubGrupoEgreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdSubGrupoEgreso.MaxLength = 100
        Me.txtIdSubGrupoEgreso.MinLength = 0
        Me.txtIdSubGrupoEgreso.Name = "txtIdSubGrupoEgreso"
        Me.txtIdSubGrupoEgreso.Precision = 0
        Me.txtIdSubGrupoEgreso.SelectOnFocus = True
        Me.txtIdSubGrupoEgreso.Size = New System.Drawing.Size(26, 20)
        Me.txtIdSubGrupoEgreso.Symbol = Nothing
        Me.txtIdSubGrupoEgreso.TabIndex = 460
        Me.txtIdSubGrupoEgreso.Value = Nothing
        '
        'FormSubGrupoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 365)
        Me.Controls.Add(Me.dgvSubGrupoEgreso)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel)
        Me.KeyPreview = True
        Me.Name = "FormSubGrupoEgreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub-Grupo Egreso"
        CType(Me.dgvSubGrupoEgreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSubGrupoEgreso As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents lbEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdSubGrupoEgreso As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdSubGrupoEgreso As DataGridViewTextBoxColumn
    Friend WithEvents GrupoEgresoId As DataGridViewTextBoxColumn
    Friend WithEvents ItemSubGrupoEgreso As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents cboGrupoEgreso As ComboBox
End Class
