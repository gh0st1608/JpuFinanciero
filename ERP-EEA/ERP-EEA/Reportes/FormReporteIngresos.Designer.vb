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
        Me.cboClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.cboPeriodoInicialFiltro = New System.Windows.Forms.ComboBox()
        Me.cboPeriodoFinalFiltro = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboGrupoIngresoFiltro
        '
        Me.cboGrupoIngresoFiltro.FormattingEnabled = True
        Me.cboGrupoIngresoFiltro.Location = New System.Drawing.Point(86, 16)
        Me.cboGrupoIngresoFiltro.Name = "cboGrupoIngresoFiltro"
        Me.cboGrupoIngresoFiltro.Size = New System.Drawing.Size(277, 21)
        Me.cboGrupoIngresoFiltro.TabIndex = 494
        '
        'lblTipoIngreso
        '
        Me.lblTipoIngreso.AutoSize = True
        Me.lblTipoIngreso.Location = New System.Drawing.Point(9, 19)
        Me.lblTipoIngreso.Name = "lblTipoIngreso"
        Me.lblTipoIngreso.Size = New System.Drawing.Size(66, 13)
        Me.lblTipoIngreso.TabIndex = 493
        Me.lblTipoIngreso.Text = "Tipo Ingreso"
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.FormattingEnabled = True
        Me.cboClienteFiltro.Location = New System.Drawing.Point(86, 43)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Size = New System.Drawing.Size(277, 21)
        Me.cboClienteFiltro.TabIndex = 490
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 489
        Me.Label17.Text = "Periodo Inicio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 487
        Me.Label18.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 495
        Me.Label1.Text = "Periodo Fin"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(288, 101)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 499
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'cboPeriodoInicialFiltro
        '
        Me.cboPeriodoInicialFiltro.FormattingEnabled = True
        Me.cboPeriodoInicialFiltro.Location = New System.Drawing.Point(86, 70)
        Me.cboPeriodoInicialFiltro.Name = "cboPeriodoInicialFiltro"
        Me.cboPeriodoInicialFiltro.Size = New System.Drawing.Size(86, 21)
        Me.cboPeriodoInicialFiltro.TabIndex = 500
        '
        'cboPeriodoFinalFiltro
        '
        Me.cboPeriodoFinalFiltro.FormattingEnabled = True
        Me.cboPeriodoFinalFiltro.Location = New System.Drawing.Point(277, 70)
        Me.cboPeriodoFinalFiltro.Name = "cboPeriodoFinalFiltro"
        Me.cboPeriodoFinalFiltro.Size = New System.Drawing.Size(86, 21)
        Me.cboPeriodoFinalFiltro.TabIndex = 501
        '
        'FormReporteIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 136)
        Me.Controls.Add(Me.cboPeriodoFinalFiltro)
        Me.Controls.Add(Me.cboPeriodoInicialFiltro)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboGrupoIngresoFiltro)
        Me.Controls.Add(Me.lblTipoIngreso)
        Me.Controls.Add(Me.cboClienteFiltro)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(391, 175)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(391, 175)
        Me.Name = "FormReporteIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Ingresos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboGrupoIngresoFiltro As ComboBox
    Friend WithEvents lblTipoIngreso As Label
    Friend WithEvents cboClienteFiltro As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents cboPeriodoInicialFiltro As ComboBox
    Friend WithEvents cboPeriodoFinalFiltro As ComboBox
End Class
