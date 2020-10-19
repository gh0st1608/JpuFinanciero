Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormLogin
#Region "Variables"

    Dim negocioUsuario As New NegUsuario
    Dim entidadUsuario As New EntUsuario
    Dim Resultado As Boolean = False

#End Region

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña.Text = ""
        txtUsuario.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If (txtUsuario.Text.Trim().Length = 0) Then
                MessageBox.Show("Datos incompletos", "Autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsuario.Focus()
                Exit Sub
            End If
            entidadUsuario.NombreUsuario = txtUsuario.Text
            If (txtContraseña.Text.Trim().Length = 0) Then
                MessageBox.Show("Datos incompletos", "Autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsuario.Focus()
                Exit Sub
            End If
            entidadUsuario.Contraseña = txtContraseña.Text

            Resultado = negocioUsuario.Autenticar(entidadUsuario)

            If (Resultado) Then
                entidadUsuario = negocioUsuario.ObtenerData(0, entidadUsuario.NombreUsuario)
                VariableGlobal.VGIDUsuario = entidadUsuario.IdUsuario
                VariableGlobal.VGCuentaUsuario = entidadUsuario.NombreUsuario
                Me.Hide()
                FormMenu.Show()
            Else
                MessageBox.Show("Los datos digitados son incorrectos", "Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MsgBox(e)
        End Try
    End Sub
End Class