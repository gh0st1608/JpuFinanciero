Public Class btnParametr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormGrupoIngreso.Show()
    End Sub

    Private Sub btnParametro_Click(sender As Object, e As EventArgs) Handles btnParametro.Click
        FormParametro.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        FormCliente.Show()
    End Sub

    Private Sub btnTipoCliente_Click(sender As Object, e As EventArgs) Handles btnTipoCliente.Click
        FormTipoCliente.Show()
    End Sub
End Class
