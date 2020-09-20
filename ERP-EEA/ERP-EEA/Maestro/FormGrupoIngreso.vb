
Imports ERP_Negocio
Imports ERP_Entidad


Public Class FormGrupoIngreso
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim entGrupoIngreso As New EntGrupoIngreso

#Region "Variables"


#End Region

#Region "Modo Ventana"

    Private Sub ModoRegistro()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub ModoVer()
        Dim dt As DataTable
        dt = negGrupoIngreso.ObtenerTabla()
        dgvGrupoIngreso.DataSource = dt
        Me.Height = 306
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub




#End Region

#Region "Funciones Auxiliares"

#End Region

#Region "Funciones Principales"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim operacion As Boolean = False
        If txtNombre.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoIngreso.Descripcion = txtNombre.Text
            entGrupoIngreso.UsuarioCreacionId = 1
        End If

        If txtIdGrupoIngreso.Text = "0" Then
            operacion = negGrupoIngreso.Guardar(entGrupoIngreso)
        Else
            operacion = negGrupoIngreso.Actualizar(entGrupoIngreso)
        End If
        If Not operacion Then
            MsgBox("No guardo bien")
        Else
            MsgBox("Guardo con exito")
        End If

        ModoVer()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Height = 390
        txtIdGrupoIngreso.Text = "0"
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        entGrupoIngreso = negGrupoIngreso.ObtenerData(dgvGrupoIngreso.CurrentRow.Cells("IDGrupoIngreso").Value)
        txtIdGrupoIngreso.Text = entGrupoIngreso.IdGrupoIngreso
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim operacion As Boolean = False
        operacion = negGrupoIngreso.Eliminar(dgvGrupoIngreso.CurrentRow.Cells("IDGrupoIngreso").Value)
        If Not operacion Then
            MsgBox("No elimino bien")
        Else
            MsgBox("Elimino con exito")
        End If
    End Sub


#End Region

#Region "Funciones de Formulario"
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Height = 306
        txtIdGrupoIngreso.Text = "0"
        txtNombre.Text = ""
    End Sub
#End Region

#Region "Funciones de Botones"

#End Region


    Private Sub FormGrupoIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoVer()
    End Sub
End Class