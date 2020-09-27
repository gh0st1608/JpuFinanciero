<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem, Me.IngresoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametroToolStripMenuItem, Me.TipoClienteToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ProveedorToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'ParametroToolStripMenuItem
        '
        Me.ParametroToolStripMenuItem.Name = "ParametroToolStripMenuItem"
        Me.ParametroToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ParametroToolStripMenuItem.Text = "Parámetro"
        '
        'TipoClienteToolStripMenuItem
        '
        Me.TipoClienteToolStripMenuItem.Name = "TipoClienteToolStripMenuItem"
        Me.TipoClienteToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.TipoClienteToolStripMenuItem.Text = "Tipo Cliente"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'IngresoToolStripMenuItem
        '
        Me.IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.IngresoToolStripMenuItem.Text = "Ingreso"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EEA-FINANCIERO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
End Class
