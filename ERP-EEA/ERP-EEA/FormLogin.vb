Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormLogin
#Region "Variables"
    Dim negocioUsuario As New NegUsuario
    Dim entidadUsuario As New EntUsuario
    Dim Resultado As Boolean = False
#End Region
    Public Sub ValidarIngreso()
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
                MessageBox.Show("El usuario y/o la contraseña es incorrecto", "Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña.Text = ""
        txtUsuario.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ValidarIngreso()
    End Sub

    Private Sub FormLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidarIngreso()
        End If
    End Sub
End Class