﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPasivo
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPasivo = New PersControlLibrary.ExtendedDataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cbPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PanelPasivo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblGrupoPasivo = New System.Windows.Forms.Label()
        Me.cboTipoPasivo = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdPasivo = New PersControlLibrary.ExtendedTextBox()
        Me.PeriodoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoPasivoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPasivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPasivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPasivo
        '
        Me.dgvPasivo.AllowUserToAddRows = False
        Me.dgvPasivo.AllowUserToDeleteRows = False
        Me.dgvPasivo.AllowUserToResizeColumns = False
        Me.dgvPasivo.AllowUserToResizeRows = False
        Me.dgvPasivo.BackgroundColor = System.Drawing.Color.White
        Me.dgvPasivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPasivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPasivo.ColumnHeadersHeight = 20
        Me.dgvPasivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPasivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdPasivo, Me.GrupoPasivoId, Me.Periodo, Me.Descripcion, Me.Monto, Me.PeriodoId})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPasivo.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPasivo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPasivo.EnableHeadersVisualStyles = False
        Me.dgvPasivo.Location = New System.Drawing.Point(13, 46)
        Me.dgvPasivo.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPasivo.Name = "dgvPasivo"
        Me.dgvPasivo.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPasivo.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPasivo.RowHeadersVisible = False
        Me.dgvPasivo.RowHeadersWidth = 22
        Me.dgvPasivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPasivo.RowTemplate.Height = 18
        Me.dgvPasivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPasivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPasivo.Size = New System.Drawing.Size(425, 200)
        Me.dgvPasivo.TabIndex = 497
        Me.dgvPasivo.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(238, 15)
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
        Me.btnNuevo.Location = New System.Drawing.Point(157, 15)
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
        Me.cbPeriodoFiltro.Location = New System.Drawing.Point(61, 19)
        Me.cbPeriodoFiltro.Name = "cbPeriodoFiltro"
        Me.cbPeriodoFiltro.Size = New System.Drawing.Size(75, 21)
        Me.cbPeriodoFiltro.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 498
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
        Me.btnEliminar.Location = New System.Drawing.Point(341, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 26)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "[Supr] ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PanelPasivo
        '
        Me.PanelPasivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelPasivo.Controls.Add(Me.Label2)
        Me.PanelPasivo.Controls.Add(Me.cboPeriodo)
        Me.PanelPasivo.Controls.Add(Me.txtSubTotal)
        Me.PanelPasivo.Controls.Add(Me.lblSubtotal)
        Me.PanelPasivo.Controls.Add(Me.lblGrupoPasivo)
        Me.PanelPasivo.Controls.Add(Me.cboTipoPasivo)
        Me.PanelPasivo.Controls.Add(Me.btnGuardar)
        Me.PanelPasivo.Controls.Add(Me.btnCancelar)
        Me.PanelPasivo.Controls.Add(Me.txtIdPasivo)
        Me.PanelPasivo.Location = New System.Drawing.Point(13, 262)
        Me.PanelPasivo.Name = "PanelPasivo"
        Me.PanelPasivo.Size = New System.Drawing.Size(425, 93)
        Me.PanelPasivo.TabIndex = 499
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 502
        Me.Label2.Text = "Periodo"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(321, 8)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(94, 21)
        Me.cboPeriodo.TabIndex = 11
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(321, 35)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(94, 20)
        Me.txtSubTotal.TabIndex = 495
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(265, 38)
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
        Me.lblGrupoPasivo.Size = New System.Drawing.Size(63, 13)
        Me.lblGrupoPasivo.TabIndex = 489
        Me.lblGrupoPasivo.Text = "Tipo Pasivo"
        '
        'cboTipoPasivo
        '
        Me.cboTipoPasivo.FormattingEnabled = True
        Me.cboTipoPasivo.Location = New System.Drawing.Point(70, 7)
        Me.cboTipoPasivo.Name = "cboTipoPasivo"
        Me.cboTipoPasivo.Size = New System.Drawing.Size(151, 21)
        Me.cboTipoPasivo.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(267, 61)
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
        Me.btnCancelar.Location = New System.Drawing.Point(346, 61)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 26)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdPasivo
        '
        Me.txtIdPasivo.AllowClear = True
        Me.txtIdPasivo.AllowNegatives = False
        Me.txtIdPasivo.AllowWhiteSpaces = True
        Me.txtIdPasivo.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdPasivo.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdPasivo.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdPasivo.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdPasivo.EnterIsTab = True
        Me.txtIdPasivo.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdPasivo.Label = "Descripción"
        Me.txtIdPasivo.Location = New System.Drawing.Point(281, 67)
        Me.txtIdPasivo.Mandatory = False
        Me.txtIdPasivo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdPasivo.MaxLength = 100
        Me.txtIdPasivo.MinLength = 0
        Me.txtIdPasivo.Name = "txtIdPasivo"
        Me.txtIdPasivo.Precision = 0
        Me.txtIdPasivo.SelectOnFocus = True
        Me.txtIdPasivo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdPasivo.Symbol = Nothing
        Me.txtIdPasivo.TabIndex = 460
        Me.txtIdPasivo.Value = Nothing
        '
        'PeriodoId
        '
        Me.PeriodoId.DataPropertyName = "PeriodoId"
        Me.PeriodoId.HeaderText = "PeriodoId"
        Me.PeriodoId.Name = "PeriodoId"
        Me.PeriodoId.ReadOnly = True
        Me.PeriodoId.Visible = False
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Monto.HeaderText = "SUBTOTAL"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "NOMBRE"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.Width = 193
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "Periodo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Periodo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Periodo.HeaderText = "PERIODO"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        Me.Periodo.Width = 90
        '
        'GrupoPasivoId
        '
        Me.GrupoPasivoId.DataPropertyName = "GrupoPasivoId"
        Me.GrupoPasivoId.HeaderText = "GrupoPasivoId"
        Me.GrupoPasivoId.Name = "GrupoPasivoId"
        Me.GrupoPasivoId.ReadOnly = True
        Me.GrupoPasivoId.Visible = False
        '
        'IdPasivo
        '
        Me.IdPasivo.DataPropertyName = "IdPasivo"
        Me.IdPasivo.HeaderText = "IdPasivo"
        Me.IdPasivo.Name = "IdPasivo"
        Me.IdPasivo.ReadOnly = True
        Me.IdPasivo.Visible = False
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
        'FormPasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 369)
        Me.Controls.Add(Me.dgvPasivo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbPeriodoFiltro)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PanelPasivo)
        Me.KeyPreview = True
        Me.Name = "FormPasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pasivo"
        CType(Me.dgvPasivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPasivo.ResumeLayout(False)
        Me.PanelPasivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPasivo As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbPeriodoFiltro As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PanelPasivo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblGrupoPasivo As Label
    Friend WithEvents cboTipoPasivo As ComboBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdPasivo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdPasivo As DataGridViewTextBoxColumn
    Friend WithEvents GrupoPasivoId As DataGridViewTextBoxColumn
    Friend WithEvents Periodo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoId As DataGridViewTextBoxColumn
End Class
