﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedor
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
        Me.dgvGrupoIngreso = New PersControlLibrary.ExtendedDataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdGrupoIngreso = New PersControlLibrary.ExtendedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExtendedTextBox1 = New PersControlLibrary.ExtendedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGrupoIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreGrupoIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGrupoIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGrupoIngreso
        '
        Me.dgvGrupoIngreso.AllowUserToAddRows = False
        Me.dgvGrupoIngreso.AllowUserToDeleteRows = False
        Me.dgvGrupoIngreso.AllowUserToResizeColumns = False
        Me.dgvGrupoIngreso.AllowUserToResizeRows = False
        Me.dgvGrupoIngreso.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrupoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrupoIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrupoIngreso.ColumnHeadersHeight = 20
        Me.dgvGrupoIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGrupoIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.MedicionId, Me.IDGrupoIngreso, Me.NombreGrupoIngreso})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrupoIngreso.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrupoIngreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGrupoIngreso.EnableHeadersVisualStyles = False
        Me.dgvGrupoIngreso.Location = New System.Drawing.Point(19, 57)
        Me.dgvGrupoIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvGrupoIngreso.Name = "dgvGrupoIngreso"
        Me.dgvGrupoIngreso.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrupoIngreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrupoIngreso.RowHeadersVisible = False
        Me.dgvGrupoIngreso.RowHeadersWidth = 22
        Me.dgvGrupoIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrupoIngreso.RowTemplate.Height = 18
        Me.dgvGrupoIngreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrupoIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupoIngreso.Size = New System.Drawing.Size(414, 216)
        Me.dgvGrupoIngreso.TabIndex = 462
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(317, 26)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(115, 26)
        Me.btnEliminar.TabIndex = 461
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
        Me.btnModificar.Location = New System.Drawing.Point(196, 26)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 26)
        Me.btnModificar.TabIndex = 460
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
        Me.btnNuevo.Location = New System.Drawing.Point(98, 26)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 26)
        Me.btnNuevo.TabIndex = 459
        Me.btnNuevo.Text = "[F2] NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ExtendedTextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtIdGrupoIngreso)
        Me.Panel1.Location = New System.Drawing.Point(19, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 112)
        Me.Panel1.TabIndex = 458
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
        Me.txtNombre.Location = New System.Drawing.Point(82, 11)
        Me.txtNombre.Mandatory = False
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.MinLength = 0
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Precision = 0
        Me.txtNombre.SelectOnFocus = True
        Me.txtNombre.Size = New System.Drawing.Size(331, 20)
        Me.txtNombre.Symbol = Nothing
        Me.txtNombre.TabIndex = 458
        Me.txtNombre.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(230, 83)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 26)
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
        Me.btnCancelar.Location = New System.Drawing.Point(328, 83)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 26)
        Me.btnCancelar.TabIndex = 409
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdGrupoIngreso
        '
        Me.txtIdGrupoIngreso.AllowClear = True
        Me.txtIdGrupoIngreso.AllowNegatives = False
        Me.txtIdGrupoIngreso.AllowWhiteSpaces = True
        Me.txtIdGrupoIngreso.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdGrupoIngreso.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdGrupoIngreso.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdGrupoIngreso.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdGrupoIngreso.EnterIsTab = True
        Me.txtIdGrupoIngreso.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdGrupoIngreso.Label = "Descripción"
        Me.txtIdGrupoIngreso.Location = New System.Drawing.Point(266, 83)
        Me.txtIdGrupoIngreso.Mandatory = False
        Me.txtIdGrupoIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdGrupoIngreso.MaxLength = 100
        Me.txtIdGrupoIngreso.MinLength = 0
        Me.txtIdGrupoIngreso.Name = "txtIdGrupoIngreso"
        Me.txtIdGrupoIngreso.Precision = 0
        Me.txtIdGrupoIngreso.SelectOnFocus = True
        Me.txtIdGrupoIngreso.Size = New System.Drawing.Size(26, 20)
        Me.txtIdGrupoIngreso.Symbol = Nothing
        Me.txtIdGrupoIngreso.TabIndex = 460
        Me.txtIdGrupoIngreso.Value = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 463
        Me.Label1.Text = "Descripcion"
        '
        'ExtendedTextBox1
        '
        Me.ExtendedTextBox1.AllowClear = True
        Me.ExtendedTextBox1.AllowNegatives = False
        Me.ExtendedTextBox1.AllowWhiteSpaces = True
        Me.ExtendedTextBox1.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExtendedTextBox1.BackColorIdle = System.Drawing.Color.Empty
        Me.ExtendedTextBox1.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ExtendedTextBox1.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.ExtendedTextBox1.EnterIsTab = True
        Me.ExtendedTextBox1.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.ExtendedTextBox1.Label = "Descripción"
        Me.ExtendedTextBox1.Location = New System.Drawing.Point(82, 44)
        Me.ExtendedTextBox1.Mandatory = False
        Me.ExtendedTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ExtendedTextBox1.MaxLength = 100
        Me.ExtendedTextBox1.MinLength = 0
        Me.ExtendedTextBox1.Name = "ExtendedTextBox1"
        Me.ExtendedTextBox1.Precision = 0
        Me.ExtendedTextBox1.SelectOnFocus = True
        Me.ExtendedTextBox1.Size = New System.Drawing.Size(36, 20)
        Me.ExtendedTextBox1.Symbol = Nothing
        Me.ExtendedTextBox1.TabIndex = 464
        Me.ExtendedTextBox1.Value = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 465
        Me.Label2.Text = "Tarifa"
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
        'MedicionId
        '
        Me.MedicionId.HeaderText = "MEDICION"
        Me.MedicionId.Name = "MedicionId"
        Me.MedicionId.ReadOnly = True
        '
        'IDGrupoIngreso
        '
        Me.IDGrupoIngreso.DataPropertyName = "IDGrupoIngreso"
        Me.IDGrupoIngreso.HeaderText = "IDGrupoIngreso"
        Me.IDGrupoIngreso.Name = "IDGrupoIngreso"
        Me.IDGrupoIngreso.ReadOnly = True
        Me.IDGrupoIngreso.Visible = False
        '
        'NombreGrupoIngreso
        '
        Me.NombreGrupoIngreso.DataPropertyName = "NombreGrupoIngreso"
        Me.NombreGrupoIngreso.HeaderText = "NOMBRE"
        Me.NombreGrupoIngreso.Name = "NombreGrupoIngreso"
        Me.NombreGrupoIngreso.ReadOnly = True
        Me.NombreGrupoIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombreGrupoIngreso.Width = 373
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvGrupoIngreso)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProveedor"
        Me.Text = "FormProveedor"
        CType(Me.dgvGrupoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvGrupoIngreso As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdGrupoIngreso As PersControlLibrary.ExtendedTextBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents MedicionId As DataGridViewTextBoxColumn
    Friend WithEvents IDGrupoIngreso As DataGridViewTextBoxColumn
    Friend WithEvents NombreGrupoIngreso As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents ExtendedTextBox1 As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label1 As Label
End Class