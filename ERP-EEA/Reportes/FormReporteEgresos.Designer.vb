<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteEgresos
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ckbTotalFiltro = New System.Windows.Forms.CheckBox()
        Me.dtpFechaFinalFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGrupoEgresoFiltro = New System.Windows.Forms.ComboBox()
        Me.lblGrupoEgreso = New System.Windows.Forms.Label()
        Me.cboPeriodoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboProveedorFiltro = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFechaInicialFiltro = New System.Windows.Forms.DateTimePicker()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.cboSubGrupoEgresoFiltro = New System.Windows.Forms.ComboBox()
        Me.lblSubGrupoEgresoFiltro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(249, 198)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 512
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(330, 198)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 511
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ckbTotalFiltro
        '
        Me.ckbTotalFiltro.AutoSize = True
        Me.ckbTotalFiltro.Location = New System.Drawing.Point(56, 153)
        Me.ckbTotalFiltro.Name = "ckbTotalFiltro"
        Me.ckbTotalFiltro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbTotalFiltro.Size = New System.Drawing.Size(50, 17)
        Me.ckbTotalFiltro.TabIndex = 510
        Me.ckbTotalFiltro.Text = "Total"
        Me.ckbTotalFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckbTotalFiltro.UseVisualStyleBackColor = True
        '
        'dtpFechaFinalFiltro
        '
        Me.dtpFechaFinalFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinalFiltro.Location = New System.Drawing.Point(319, 148)
        Me.dtpFechaFinalFiltro.Name = "dtpFechaFinalFiltro"
        Me.dtpFechaFinalFiltro.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaFinalFiltro.TabIndex = 509
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 508
        Me.Label1.Text = "Fecha Final"
        '
        'cboGrupoEgresoFiltro
        '
        Me.cboGrupoEgresoFiltro.FormattingEnabled = True
        Me.cboGrupoEgresoFiltro.Location = New System.Drawing.Point(92, 12)
        Me.cboGrupoEgresoFiltro.Name = "cboGrupoEgresoFiltro"
        Me.cboGrupoEgresoFiltro.Size = New System.Drawing.Size(311, 21)
        Me.cboGrupoEgresoFiltro.TabIndex = 507
        '
        'lblGrupoEgreso
        '
        Me.lblGrupoEgreso.AutoSize = True
        Me.lblGrupoEgreso.Location = New System.Drawing.Point(17, 15)
        Me.lblGrupoEgreso.Name = "lblGrupoEgreso"
        Me.lblGrupoEgreso.Size = New System.Drawing.Size(72, 13)
        Me.lblGrupoEgreso.TabIndex = 506
        Me.lblGrupoEgreso.Text = "Grupo Egreso"
        '
        'cboPeriodoFiltro
        '
        Me.cboPeriodoFiltro.FormattingEnabled = True
        Me.cboPeriodoFiltro.Location = New System.Drawing.Point(92, 118)
        Me.cboPeriodoFiltro.Name = "cboPeriodoFiltro"
        Me.cboPeriodoFiltro.Size = New System.Drawing.Size(94, 21)
        Me.cboPeriodoFiltro.TabIndex = 505
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 504
        Me.Label16.Text = "Periodo"
        '
        'cboProveedorFiltro
        '
        Me.cboProveedorFiltro.FormattingEnabled = True
        Me.cboProveedorFiltro.Location = New System.Drawing.Point(92, 86)
        Me.cboProveedorFiltro.Name = "cboProveedorFiltro"
        Me.cboProveedorFiltro.Size = New System.Drawing.Size(311, 21)
        Me.cboProveedorFiltro.TabIndex = 503
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(248, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 502
        Me.Label17.Text = "Fecha Inicio"
        '
        'dtpFechaInicialFiltro
        '
        Me.dtpFechaInicialFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicialFiltro.Location = New System.Drawing.Point(319, 115)
        Me.dtpFechaInicialFiltro.Name = "dtpFechaInicialFiltro"
        Me.dtpFechaInicialFiltro.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaInicialFiltro.TabIndex = 501
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(31, 89)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedor.TabIndex = 500
        Me.lblProveedor.Text = "Proveedor"
        '
        'cboSubGrupoEgresoFiltro
        '
        Me.cboSubGrupoEgresoFiltro.FormattingEnabled = True
        Me.cboSubGrupoEgresoFiltro.Location = New System.Drawing.Point(92, 50)
        Me.cboSubGrupoEgresoFiltro.Name = "cboSubGrupoEgresoFiltro"
        Me.cboSubGrupoEgresoFiltro.Size = New System.Drawing.Size(311, 21)
        Me.cboSubGrupoEgresoFiltro.TabIndex = 514
        '
        'lblSubGrupoEgresoFiltro
        '
        Me.lblSubGrupoEgresoFiltro.AutoSize = True
        Me.lblSubGrupoEgresoFiltro.Location = New System.Drawing.Point(-1, 50)
        Me.lblSubGrupoEgresoFiltro.Name = "lblSubGrupoEgresoFiltro"
        Me.lblSubGrupoEgresoFiltro.Size = New System.Drawing.Size(91, 13)
        Me.lblSubGrupoEgresoFiltro.TabIndex = 513
        Me.lblSubGrupoEgresoFiltro.Text = "SubGrupo Egreso"
        '
        'FormReporteEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 230)
        Me.Controls.Add(Me.cboSubGrupoEgresoFiltro)
        Me.Controls.Add(Me.lblSubGrupoEgresoFiltro)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.ckbTotalFiltro)
        Me.Controls.Add(Me.dtpFechaFinalFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboGrupoEgresoFiltro)
        Me.Controls.Add(Me.lblGrupoEgreso)
        Me.Controls.Add(Me.cboPeriodoFiltro)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboProveedorFiltro)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpFechaInicialFiltro)
        Me.Controls.Add(Me.lblProveedor)
        Me.Name = "FormReporteEgresos"
        Me.Text = "FormReporteEgresos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ckbTotalFiltro As CheckBox
    Friend WithEvents dtpFechaFinalFiltro As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cboGrupoEgresoFiltro As ComboBox
    Friend WithEvents lblGrupoEgreso As Label
    Friend WithEvents cboPeriodoFiltro As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cboProveedorFiltro As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpFechaInicialFiltro As DateTimePicker
    Friend WithEvents lblProveedor As Label
    Friend WithEvents cboSubGrupoEgresoFiltro As ComboBox
    Friend WithEvents lblSubGrupoEgresoFiltro As Label
End Class
