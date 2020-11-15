<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteIngresos
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
        Me.cboGrupoIngresoFiltro = New System.Windows.Forms.ComboBox()
        Me.lblTipoIngreso = New System.Windows.Forms.Label()
        Me.cboPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFechaInicialFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFinalFiltro = New System.Windows.Forms.DateTimePicker()
        Me.ckbTotalFiltro = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboGrupoIngresoFiltro
        '
        Me.cboGrupoIngresoFiltro.FormattingEnabled = True
        Me.cboGrupoIngresoFiltro.Location = New System.Drawing.Point(77, 23)
        Me.cboGrupoIngresoFiltro.Name = "cboGrupoIngresoFiltro"
        Me.cboGrupoIngresoFiltro.Size = New System.Drawing.Size(311, 21)
        Me.cboGrupoIngresoFiltro.TabIndex = 494
        '
        'lblTipoIngreso
        '
        Me.lblTipoIngreso.AutoSize = True
        Me.lblTipoIngreso.Location = New System.Drawing.Point(9, 26)
        Me.lblTipoIngreso.Name = "lblTipoIngreso"
        Me.lblTipoIngreso.Size = New System.Drawing.Size(66, 13)
        Me.lblTipoIngreso.TabIndex = 493
        Me.lblTipoIngreso.Text = "Tipo Ingreso"
        '
        'cboPeriodoFiltro
        '
        Me.cboPeriodoFiltro.FormattingEnabled = True
        Me.cboPeriodoFiltro.Location = New System.Drawing.Point(77, 85)
        Me.cboPeriodoFiltro.Name = "cboPeriodoFiltro"
        Me.cboPeriodoFiltro.Size = New System.Drawing.Size(94, 21)
        Me.cboPeriodoFiltro.TabIndex = 492
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 491
        Me.Label16.Text = "Periodo"
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.FormattingEnabled = True
        Me.cboClienteFiltro.Location = New System.Drawing.Point(77, 53)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Size = New System.Drawing.Size(311, 21)
        Me.cboClienteFiltro.TabIndex = 490
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(233, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 489
        Me.Label17.Text = "Fecha Inicio"
        '
        'dtpFechaInicialFiltro
        '
        Me.dtpFechaInicialFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicialFiltro.Location = New System.Drawing.Point(304, 82)
        Me.dtpFechaInicialFiltro.Name = "dtpFechaInicialFiltro"
        Me.dtpFechaInicialFiltro.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaInicialFiltro.TabIndex = 488
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(36, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 487
        Me.Label18.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 495
        Me.Label1.Text = "Fecha Final"
        '
        'dtpFechaFinalFiltro
        '
        Me.dtpFechaFinalFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinalFiltro.Location = New System.Drawing.Point(304, 115)
        Me.dtpFechaFinalFiltro.Name = "dtpFechaFinalFiltro"
        Me.dtpFechaFinalFiltro.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaFinalFiltro.TabIndex = 496
        '
        'ckbTotalFiltro
        '
        Me.ckbTotalFiltro.AutoSize = True
        Me.ckbTotalFiltro.Location = New System.Drawing.Point(41, 120)
        Me.ckbTotalFiltro.Name = "ckbTotalFiltro"
        Me.ckbTotalFiltro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbTotalFiltro.Size = New System.Drawing.Size(50, 17)
        Me.ckbTotalFiltro.TabIndex = 497
        Me.ckbTotalFiltro.Text = "Total"
        Me.ckbTotalFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckbTotalFiltro.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(314, 166)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 498
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(233, 166)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 499
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'ReporteIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 199)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.ckbTotalFiltro)
        Me.Controls.Add(Me.dtpFechaFinalFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboGrupoIngresoFiltro)
        Me.Controls.Add(Me.lblTipoIngreso)
        Me.Controls.Add(Me.cboPeriodoFiltro)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboClienteFiltro)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpFechaInicialFiltro)
        Me.Controls.Add(Me.Label18)
        Me.Name = "ReporteIngresos"
        Me.Text = "Reporte de Ingresos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboGrupoIngresoFiltro As ComboBox
    Friend WithEvents lblTipoIngreso As Label
    Friend WithEvents cboPeriodoFiltro As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cboClienteFiltro As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpFechaInicialFiltro As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaFinalFiltro As DateTimePicker
    Friend WithEvents ckbTotalFiltro As CheckBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGenerar As Button
End Class
