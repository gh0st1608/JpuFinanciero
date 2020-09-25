Public Class FormMenu
    Private Sub IngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoToolStripMenuItem.Click
        FormIngreso.Show()
    End Sub

    Private Sub ParámetroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametroToolStripMenuItem.Click
        FormParametro.Show()
    End Sub

    Private Sub TipoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoClienteToolStripMenuItem.Click
        FormTipoCliente.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        FormCliente.Show()
    End Sub
End Class
