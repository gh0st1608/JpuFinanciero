﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCliente = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetaEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetaEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.gbContacto = New System.Windows.Forms.GroupBox()
        Me.dgvContacto = New PersControlLibrary.ExtendedDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstadoActivoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnContacto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroContacto = New PersControlLibrary.ExtendedTextBox()
        Me.labelCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New PersControlLibrary.ExtendedTextBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New PersControlLibrary.ExtendedTextBox()
        Me.txtDocumento = New PersControlLibrary.ExtendedTextBox()
        Me.labelDocumento = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.labelRazonSocial = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New PersControlLibrary.ExtendedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdCliente = New PersControlLibrary.ExtendedTextBox()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.gbContacto.SuspendLayout()
        CType(Me.dgvContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AllowUserToResizeColumns = False
        Me.dgvCliente.AllowUserToResizeRows = False
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCliente.ColumnHeadersHeight = 20
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.IdCliente, Me.TipoClienteId, Me.TipoCliente, Me.RazonSocial, Me.Documento, Me.Descripcion, Me.MetaEntidad, Me.MetaEmpresa, Me.Correo, Me.NumeroContacto, Me.IdEstadoActivo, Me.EstadoActivo})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCliente.EnableHeadersVisualStyles = False
        Me.dgvCliente.Location = New System.Drawing.Point(14, 50)
        Me.dgvCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.RowHeadersWidth = 22
        Me.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCliente.RowTemplate.Height = 18
        Me.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(809, 200)
        Me.dgvCliente.TabIndex = 467
        Me.dgvCliente.TabStop = False
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
        'IdCliente
        '
        Me.IdCliente.DataPropertyName = "IdCliente"
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Visible = False
        '
        'TipoClienteId
        '
        Me.TipoClienteId.DataPropertyName = "TipoClienteId"
        Me.TipoClienteId.HeaderText = "TipoClienteId"
        Me.TipoClienteId.Name = "TipoClienteId"
        Me.TipoClienteId.ReadOnly = True
        Me.TipoClienteId.Visible = False
        '
        'TipoCliente
        '
        Me.TipoCliente.DataPropertyName = "TipoCliente"
        Me.TipoCliente.HeaderText = "TIPO CLIENTE"
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.ReadOnly = True
        Me.TipoCliente.Visible = False
        Me.TipoCliente.Width = 90
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.HeaderText = "RAZON SOCIAL"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        Me.RazonSocial.Visible = False
        '
        'Documento
        '
        Me.Documento.DataPropertyName = "Documento"
        Me.Documento.HeaderText = "DOCUMENTO"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        Me.Documento.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "NOMBRE COMERCIAL"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion.Width = 300
        '
        'MetaEntidad
        '
        Me.MetaEntidad.DataPropertyName = "MetaEntidad"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.MetaEntidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetaEntidad.HeaderText = "META ENTIDAD"
        Me.MetaEntidad.Name = "MetaEntidad"
        Me.MetaEntidad.ReadOnly = True
        Me.MetaEntidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetaEntidad.Visible = False
        '
        'MetaEmpresa
        '
        Me.MetaEmpresa.DataPropertyName = "MetaEmpresa"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.MetaEmpresa.DefaultCellStyle = DataGridViewCellStyle4
        Me.MetaEmpresa.HeaderText = "META EMPRESA"
        Me.MetaEmpresa.Name = "MetaEmpresa"
        Me.MetaEmpresa.ReadOnly = True
        Me.MetaEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetaEmpresa.Visible = False
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "CORREO"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Width = 250
        '
        'NumeroContacto
        '
        Me.NumeroContacto.DataPropertyName = "NumeroContacto"
        Me.NumeroContacto.HeaderText = "TELEFONO/CELULAR"
        Me.NumeroContacto.Name = "NumeroContacto"
        Me.NumeroContacto.ReadOnly = True
        Me.NumeroContacto.Width = 130
        '
        'IdEstadoActivo
        '
        Me.IdEstadoActivo.DataPropertyName = "IdEstadoActivo"
        Me.IdEstadoActivo.HeaderText = "IdEstadoActivo"
        Me.IdEstadoActivo.Name = "IdEstadoActivo"
        Me.IdEstadoActivo.ReadOnly = True
        Me.IdEstadoActivo.Visible = False
        '
        'EstadoActivo
        '
        Me.EstadoActivo.DataPropertyName = "EstadoActivo"
        Me.EstadoActivo.HeaderText = "ESTADO"
        Me.EstadoActivo.Name = "EstadoActivo"
        Me.EstadoActivo.ReadOnly = True
        Me.EstadoActivo.Width = 80
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(725, 14)
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
        Me.btnModificar.Location = New System.Drawing.Point(622, 14)
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
        Me.btnNuevo.Location = New System.Drawing.Point(541, 14)
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
        Me.Panel.Controls.Add(Me.gbContacto)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.txtNumeroContacto)
        Me.Panel.Controls.Add(Me.labelCorreo)
        Me.Panel.Controls.Add(Me.txtCorreo)
        Me.Panel.Controls.Add(Me.labelDescripcion)
        Me.Panel.Controls.Add(Me.txtDescripcion)
        Me.Panel.Controls.Add(Me.txtDocumento)
        Me.Panel.Controls.Add(Me.labelDocumento)
        Me.Panel.Controls.Add(Me.lbEstado)
        Me.Panel.Controls.Add(Me.cboEstado)
        Me.Panel.Controls.Add(Me.labelRazonSocial)
        Me.Panel.Controls.Add(Me.txtRazonSocial)
        Me.Panel.Controls.Add(Me.btnGuardar)
        Me.Panel.Controls.Add(Me.btnCancelar)
        Me.Panel.Controls.Add(Me.txtIdCliente)
        Me.Panel.Location = New System.Drawing.Point(13, 268)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(809, 199)
        Me.Panel.TabIndex = 463
        '
        'gbContacto
        '
        Me.gbContacto.Controls.Add(Me.dgvContacto)
        Me.gbContacto.Controls.Add(Me.btnContacto)
        Me.gbContacto.Location = New System.Drawing.Point(7, 62)
        Me.gbContacto.Name = "gbContacto"
        Me.gbContacto.Size = New System.Drawing.Size(794, 98)
        Me.gbContacto.TabIndex = 479
        Me.gbContacto.TabStop = False
        Me.gbContacto.Text = "Contacto"
        '
        'dgvContacto
        '
        Me.dgvContacto.AllowUserToAddRows = False
        Me.dgvContacto.AllowUserToDeleteRows = False
        Me.dgvContacto.AllowUserToResizeColumns = False
        Me.dgvContacto.AllowUserToResizeRows = False
        Me.dgvContacto.BackgroundColor = System.Drawing.Color.White
        Me.dgvContacto.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContacto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvContacto.ColumnHeadersHeight = 20
        Me.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvContacto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdContacto, Me.OrigenId, Me.NombreCompleto, Me.Cargo, Me.CorreoContacto, Me.Celular, Me.Estado, Me.IdEstadoActivoContacto})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContacto.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvContacto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvContacto.EnableHeadersVisualStyles = False
        Me.dgvContacto.Location = New System.Drawing.Point(5, 20)
        Me.dgvContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvContacto.Name = "dgvContacto"
        Me.dgvContacto.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContacto.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvContacto.RowHeadersVisible = False
        Me.dgvContacto.RowHeadersWidth = 22
        Me.dgvContacto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvContacto.RowTemplate.Height = 18
        Me.dgvContacto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContacto.Size = New System.Drawing.Size(646, 68)
        Me.dgvContacto.TabIndex = 469
        Me.dgvContacto.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Item"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Cargo.DefaultCellStyle = DataGridViewCellStyle9
        Me.Cargo.HeaderText = "CARGO"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        Me.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CorreoContacto
        '
        Me.CorreoContacto.DataPropertyName = "Correo"
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.CorreoContacto.DefaultCellStyle = DataGridViewCellStyle10
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
        'Estado
        '
        Me.Estado.DataPropertyName = "EstadoActivo"
        Me.Estado.HeaderText = "EstadoActivo"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'IdEstadoActivoContacto
        '
        Me.IdEstadoActivoContacto.DataPropertyName = "IdEstadoActivo"
        Me.IdEstadoActivoContacto.HeaderText = "IdEstadoActivo"
        Me.IdEstadoActivoContacto.Name = "IdEstadoActivoContacto"
        Me.IdEstadoActivoContacto.ReadOnly = True
        Me.IdEstadoActivoContacto.Visible = False
        '
        'btnContacto
        '
        Me.btnContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContacto.Location = New System.Drawing.Point(667, 42)
        Me.btnContacto.Name = "btnContacto"
        Me.btnContacto.Size = New System.Drawing.Size(114, 26)
        Me.btnContacto.TabIndex = 30
        Me.btnContacto.Text = "AGREGAR/EDITAR"
        Me.btnContacto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(581, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 478
        Me.Label1.Text = "Telefono / Celular"
        '
        'txtNumeroContacto
        '
        Me.txtNumeroContacto.AllowClear = True
        Me.txtNumeroContacto.AllowNegatives = False
        Me.txtNumeroContacto.AllowWhiteSpaces = True
        Me.txtNumeroContacto.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumeroContacto.BackColorIdle = System.Drawing.Color.Empty
        Me.txtNumeroContacto.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtNumeroContacto.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtNumeroContacto.EnterIsTab = True
        Me.txtNumeroContacto.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtNumeroContacto.Label = "Descripción"
        Me.txtNumeroContacto.Location = New System.Drawing.Point(680, 6)
        Me.txtNumeroContacto.Mandatory = False
        Me.txtNumeroContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroContacto.MaxLength = 100
        Me.txtNumeroContacto.MinLength = 0
        Me.txtNumeroContacto.Name = "txtNumeroContacto"
        Me.txtNumeroContacto.Precision = 0
        Me.txtNumeroContacto.SelectOnFocus = True
        Me.txtNumeroContacto.Size = New System.Drawing.Size(121, 20)
        Me.txtNumeroContacto.Symbol = Nothing
        Me.txtNumeroContacto.TabIndex = 16
        Me.txtNumeroContacto.Value = Nothing
        '
        'labelCorreo
        '
        Me.labelCorreo.AutoSize = True
        Me.labelCorreo.Location = New System.Drawing.Point(272, 33)
        Me.labelCorreo.Name = "labelCorreo"
        Me.labelCorreo.Size = New System.Drawing.Size(38, 13)
        Me.labelCorreo.TabIndex = 469
        Me.labelCorreo.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.AllowClear = True
        Me.txtCorreo.AllowNegatives = False
        Me.txtCorreo.AllowWhiteSpaces = True
        Me.txtCorreo.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.BackColorIdle = System.Drawing.Color.Empty
        Me.txtCorreo.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCorreo.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtCorreo.EnterIsTab = True
        Me.txtCorreo.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtCorreo.Label = "Descripción"
        Me.txtCorreo.Location = New System.Drawing.Point(370, 30)
        Me.txtCorreo.Mandatory = False
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.MinLength = 0
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Precision = 0
        Me.txtCorreo.SelectOnFocus = True
        Me.txtCorreo.Size = New System.Drawing.Size(196, 20)
        Me.txtCorreo.Symbol = Nothing
        Me.txtCorreo.TabIndex = 15
        Me.txtCorreo.Value = Nothing
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(272, 9)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(93, 13)
        Me.labelDescripcion.TabIndex = 467
        Me.labelDescripcion.Text = "Nombre Comercial"
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
        Me.txtDescripcion.Location = New System.Drawing.Point(370, 6)
        Me.txtDescripcion.Mandatory = False
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MinLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Precision = 0
        Me.txtDescripcion.SelectOnFocus = True
        Me.txtDescripcion.Size = New System.Drawing.Size(196, 20)
        Me.txtDescripcion.Symbol = Nothing
        Me.txtDescripcion.TabIndex = 14
        Me.txtDescripcion.Value = Nothing
        '
        'txtDocumento
        '
        Me.txtDocumento.AllowClear = True
        Me.txtDocumento.AllowNegatives = False
        Me.txtDocumento.AllowWhiteSpaces = True
        Me.txtDocumento.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocumento.BackColorIdle = System.Drawing.Color.Empty
        Me.txtDocumento.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtDocumento.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtDocumento.EnterIsTab = True
        Me.txtDocumento.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtDocumento.Label = "Descripción"
        Me.txtDocumento.Location = New System.Drawing.Point(79, 6)
        Me.txtDocumento.Mandatory = False
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumento.MaxLength = 100
        Me.txtDocumento.MinLength = 0
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Precision = 0
        Me.txtDocumento.SelectOnFocus = True
        Me.txtDocumento.Size = New System.Drawing.Size(174, 20)
        Me.txtDocumento.Symbol = Nothing
        Me.txtDocumento.TabIndex = 12
        Me.txtDocumento.Value = Nothing
        '
        'labelDocumento
        '
        Me.labelDocumento.AutoSize = True
        Me.labelDocumento.Location = New System.Drawing.Point(4, 9)
        Me.labelDocumento.Name = "labelDocumento"
        Me.labelDocumento.Size = New System.Drawing.Size(30, 13)
        Me.labelDocumento.TabIndex = 464
        Me.labelDocumento.Text = "RUC"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(586, 33)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 463
        Me.lbEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboEstado.Location = New System.Drawing.Point(680, 32)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 462
        Me.cboEstado.TabStop = False
        '
        'labelRazonSocial
        '
        Me.labelRazonSocial.AutoSize = True
        Me.labelRazonSocial.Location = New System.Drawing.Point(4, 33)
        Me.labelRazonSocial.Name = "labelRazonSocial"
        Me.labelRazonSocial.Size = New System.Drawing.Size(70, 13)
        Me.labelRazonSocial.TabIndex = 461
        Me.labelRazonSocial.Text = "Razon Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.AllowClear = True
        Me.txtRazonSocial.AllowNegatives = False
        Me.txtRazonSocial.AllowWhiteSpaces = True
        Me.txtRazonSocial.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRazonSocial.BackColorIdle = System.Drawing.Color.Empty
        Me.txtRazonSocial.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtRazonSocial.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtRazonSocial.EnterIsTab = True
        Me.txtRazonSocial.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtRazonSocial.Label = "Descripción"
        Me.txtRazonSocial.Location = New System.Drawing.Point(79, 30)
        Me.txtRazonSocial.Mandatory = False
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.MinLength = 0
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Precision = 0
        Me.txtRazonSocial.SelectOnFocus = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(174, 20)
        Me.txtRazonSocial.Symbol = Nothing
        Me.txtRazonSocial.TabIndex = 13
        Me.txtRazonSocial.Value = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(589, 166)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 26)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "GUARDAR"
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
        Me.btnCancelar.Location = New System.Drawing.Point(701, 166)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 26)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.AllowClear = True
        Me.txtIdCliente.AllowNegatives = False
        Me.txtIdCliente.AllowWhiteSpaces = True
        Me.txtIdCliente.BackColorFocused = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdCliente.BackColorIdle = System.Drawing.Color.Empty
        Me.txtIdCliente.BackColorMandatory = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtIdCliente.Capitalization = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxCapitalizations.Ignore
        Me.txtIdCliente.EnterIsTab = True
        Me.txtIdCliente.Format = PersControlLibrary.ExtendedTextBox.ExtendedTextBoxFormats.AnyText
        Me.txtIdCliente.Label = "Descripción"
        Me.txtIdCliente.Location = New System.Drawing.Point(656, 172)
        Me.txtIdCliente.Mandatory = False
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCliente.MaxLength = 100
        Me.txtIdCliente.MinLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Precision = 0
        Me.txtIdCliente.SelectOnFocus = True
        Me.txtIdCliente.Size = New System.Drawing.Size(26, 20)
        Me.txtIdCliente.Symbol = Nothing
        Me.txtIdCliente.TabIndex = 460
        Me.txtIdCliente.Value = Nothing
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 481)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel)
        Me.KeyPreview = True
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.gbContacto.ResumeLayout(False)
        CType(Me.dgvContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCliente As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents lbEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents labelRazonSocial As Label
    Friend WithEvents txtRazonSocial As PersControlLibrary.ExtendedTextBox
    Private WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdCliente As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtDocumento As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelDocumento As Label
    Friend WithEvents labelDescripcion As Label
    Friend WithEvents txtDescripcion As PersControlLibrary.ExtendedTextBox
    Friend WithEvents labelCorreo As Label
    Friend WithEvents txtCorreo As PersControlLibrary.ExtendedTextBox
    Friend WithEvents txtNumeroContacto As PersControlLibrary.ExtendedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbContacto As GroupBox
    Friend WithEvents dgvContacto As PersControlLibrary.ExtendedDataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents TipoClienteId As DataGridViewTextBoxColumn
    Friend WithEvents TipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents MetaEntidad As DataGridViewTextBoxColumn
    Friend WithEvents MetaEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents NumeroContacto As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActivo As DataGridViewTextBoxColumn
    Private WithEvents btnContacto As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdContacto As DataGridViewTextBoxColumn
    Friend WithEvents OrigenId As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents CorreoContacto As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents IdEstadoActivoContacto As DataGridViewTextBoxColumn
End Class
