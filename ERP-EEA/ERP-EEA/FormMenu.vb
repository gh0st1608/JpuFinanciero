
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

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        FormProveedor.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")

        r.NumberFormat.NumberGroupSeparator = ","
        r.NumberFormat.NumberDecimalSeparator = "."

        System.Threading.Thread.CurrentThread.CurrentCulture = r

    End Sub

    Private Sub GrupoIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoIngresoToolStripMenuItem.Click
        FormGrupoIngreso.Show()
    End Sub

    Private Sub GrupoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoEgresoToolStripMenuItem.Click
        FormGrupoEgreso.Show()
    End Sub

    Private Sub SubGrupoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubGrupoEgresoToolStripMenuItem.Click
        FormSubGrupoEgreso.Show()
    End Sub

    Private Sub RegistroDeEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeEgresoToolStripMenuItem.Click
        FormEgreso.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        FormUsuario.Show()
    End Sub

    Private Sub FormMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Close()
    End Sub

    Private Sub ReporteIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteIngresoToolStripMenuItem.Click
        FormReporteIngresos.Show()
    End Sub

    Private Sub GrupoActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoActivoToolStripMenuItem.Click
        FormGrupoActivo.Show()
    End Sub

    Private Sub ActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivoToolStripMenuItem.Click
        FormActivo.Show()
    End Sub

    Private Sub GrupoPasivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoPasivoToolStripMenuItem.Click
        formGrupoPasivo.Show()
    End Sub

    Private Sub PasivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasivoToolStripMenuItem.Click
        FormPasivo.Show()
    End Sub

    Private Sub GrupoPatrimonioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoPatrimonioToolStripMenuItem.Click
        FormGrupoPatrimonio.Show()
    End Sub

    Private Sub PatrimonioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatrimonioToolStripMenuItem.Click
        FormPatrimonio.Show()
    End Sub

    Private Sub RelacionDebeHaberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionDebeHaberToolStripMenuItem.Click
        FormRelacionDebeHaber.Show()
    End Sub

    Private Sub ReporteEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteEgresoToolStripMenuItem.Click
        FormReporteEgresos.Show()
    End Sub

    Private Sub CierreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreToolStripMenuItem.Click
        FormCierre.Show()
    End Sub

    Private Sub ReporteRatiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteRatiosToolStripMenuItem.Click
        FormReporteRatios.Show()
    End Sub

    Private Sub ReporteBalanceGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteBalanceGeneralToolStripMenuItem.Click
        FormBalanceGeneral.Show()
    End Sub

    Private Sub ProyectadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormProyectado.Show()
    End Sub

    Private Sub ProyectadoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProyectadoToolStripMenuItem.Click
        FormProyectado.Show()
    End Sub

    Private Sub ReporteFlujoCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteFlujoCajaToolStripMenuItem.Click
        FormReporteFCProyectado.Show()
    End Sub
End Class
