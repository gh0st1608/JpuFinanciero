Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormTipoCliente

#Region "Variables"

    Dim negTipoCliente As New NegTipoCliente
    Dim entTipoCliente As New EntTipoCliente
    Dim operacion As Boolean = False
    Dim dataTable As DataTable

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 307
        txtIdTipoCliente.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        cboEstado.Visible = false

        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 392
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negTipoCliente.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvTipoCliente.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearTipoCliente()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entTipoCliente.Descripcion = txtDescripcion.Text
        End If

        entTipoCliente.UsuarioCreacionId = 1

        operacion = negTipoCliente.Guardar(entTipoCliente)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerTipoCliente() 'Item
        entTipoCliente = negTipoCliente.ObtenerData(dgvTipoCliente.CurrentRow.Cells("IdTipoCliente").Value)

        txtIdTipoCliente.Text = entTipoCliente.IdTipoCliente
        txtDescripcion.Text = entTipoCliente.Descripcion

        If (entTipoCliente.EstadoActivo = 0) Then
            cboEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarTipoCliente()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entTipoCliente.Descripcion = txtDescripcion.Text
        End If

        entTipoCliente.UsuarioModificacionId = 1

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entTipoCliente.EstadoActivo = 1
        Else
            entTipoCliente.EstadoActivo = 0
        End If

        operacion = negTipoCliente.Actualizar(entTipoCliente)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarTipoCliente()
        entTipoCliente.IdTipoCliente = Int(dgvTipoCliente.CurrentRow.Cells("IdTipoCliente").Value)
        entTipoCliente.UsuarioModificacionId = 1

        operacion = negTipoCliente.Eliminar(entTipoCliente)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormTipoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormTipoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerTipoCliente()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarTipoCliente()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdTipoCliente.Text = "0" Then
            CrearTipoCliente()
        Else
            ActualizarTipoCliente()
        End If
        ModoInicial()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerTipoCliente()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarTipoCliente()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region

End Class