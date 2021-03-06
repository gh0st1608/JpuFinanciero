﻿Imports ERP_Negocio
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
        Me.Height = 208
        operacion = False
        txtIdTipoCliente.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        cboEstado.Visible = False
        lbEstado.Visible = False
        Panel.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 300
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvTipoCliente.Enabled = False
        Panel.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negTipoCliente.ObtenerTabla(True)
        dgvTipoCliente.DataSource = dataTable
        If dgvTipoCliente.Rows.Count > 0 Then
            dgvTipoCliente.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            dgvTipoCliente.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearTipoCliente()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entTipoCliente.Descripcion = txtDescripcion.Text
        End If
        entTipoCliente.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negTipoCliente.Guardar(entTipoCliente)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Tipo Cliente")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Tipo Cliente")
        End If
    End Sub
    Private Sub LeerTipoCliente()
        If dgvTipoCliente.Rows.Count > 0 Then
            entTipoCliente = negTipoCliente.ObtenerData(dgvTipoCliente.CurrentRow.Cells("IdTipoCliente").Value)
            txtIdTipoCliente.Text = entTipoCliente.IdTipoCliente
            txtDescripcion.Text = entTipoCliente.Descripcion

            If (entTipoCliente.IdEstadoActivo = 0) Then
                cboEstado.Visible = True
                lbEstado.Visible = True
                cboEstado.Text = "Inactivo"
            End If
        End If
    End Sub
    Private Sub ActualizarTipoCliente()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entTipoCliente.Descripcion = txtDescripcion.Text
        End If
        entTipoCliente.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "Inactivo") Then
            entTipoCliente.IdEstadoActivo = 0
        Else
            entTipoCliente.IdEstadoActivo = 1
        End If

        operacion = negTipoCliente.Actualizar(entTipoCliente)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Tipo Cliente")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Tipo Cliente")
        End If
    End Sub
    Private Sub EliminarTipoCliente()
        If dgvTipoCliente.Rows.Count > 0 Then
            entTipoCliente.IdTipoCliente = Int(dgvTipoCliente.CurrentRow.Cells("IdTipoCliente").Value)
            entTipoCliente.UsuarioModificacionId = VariableGlobal.VGIDUsuario

            operacion = negTipoCliente.Eliminar(entTipoCliente)
            If operacion Then
                MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Tipo Cliente")
            Else
                MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Tipo Cliente")
            End If
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormTipoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormTipoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 And btnNuevo.Enabled Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 And btnModificar.Enabled Then
            LeerTipoCliente()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete And btnEliminar.Enabled Then
            EliminarTipoCliente()
            If operacion Then
                ModoInicial()
            End If
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
        If operacion Then
            ModoInicial()
        End If
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
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class