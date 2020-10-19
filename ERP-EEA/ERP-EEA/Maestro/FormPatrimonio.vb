Imports System.IO
Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormPatrimonio


#Region "Variables"

    Dim negPatrimonio As New NegPatrimonio
    Dim entPatrimonio As New EntPatrimonio
    Dim entGrupoPatrimonio As New EntGrupoPatrimonio
    Dim negGrupoPatrimonio As New NegGrupoPatrimonio
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim cantPatrimonios As Integer

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        CargarTablaPatrimonio()
        dgvPatrimonio.Enabled = True
        Me.Height = 273
        txtIdPatrimonio.Text = "0"
        cboPeriodo.SelectedValue = 0
        btnNuevo.Enabled = True
        If cantPatrimonios = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
        dgvPatrimonio.Enabled = True
        PanelPatrimonio.Visible = True

    End Sub

    Private Sub ModoRegistro()
        Me.Height = 460
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvPatrimonio.Enabled = False
        PanelPatrimonio.Visible = True
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaPatrimonio()
        dataTable = negPatrimonio.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue)
        dgvPatrimonio.DataSource = dataTable
        cantPatrimonios = dgvPatrimonio.Rows.Count
    End Sub


    Private Sub CargarCombo()

        cboTipoPatrimonio.ValueMember = "IdGrupoPatrimonio"
        cboTipoPatrimonio.DisplayMember = "Descripcion"
        cboTipoPatrimonio.DataSource = negGrupoPatrimonio.ObtenerLista(False, True)

        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True)

        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)

    End Sub



#End Region

#Region "Funciones Principales (CRUD)"
    'Patrimonio
    Private Sub CrearPatrimonio()
        If cboTipoPatrimonio.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Patrimonios")
            Exit Sub
        Else
            entPatrimonio.GrupoPatrimonioId = cboTipoPatrimonio.SelectedValue
        End If


        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entPatrimonio.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entPatrimonio.Monto = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US"))
        End If
        entPatrimonio.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negPatrimonio.Guardar(entPatrimonio)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerPatrimonio()

        entPatrimonio = negPatrimonio.ObtenerData(dgvPatrimonio.CurrentRow.Cells("IdPatrimonio").Value)
        txtIdPatrimonio.Text = entPatrimonio.IdPatrimonio
        cboTipoPatrimonio.SelectedValue = entPatrimonio.GrupoPatrimonioId
        cboPeriodo.SelectedValue = entPatrimonio.PeriodoId
        txtSubTotal.Text = entPatrimonio.Monto.ToString(“##,##0.00”)

    End Sub
    Private Sub ActualizarPatrimonio()

        If cboTipoPatrimonio.SelectedValue = 0 Then
            MsgBox("Escoger un Patrimonio")
            Exit Sub
        Else
            entPatrimonio.GrupoPatrimonioId = cboTipoPatrimonio.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entPatrimonio.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entPatrimonio.Monto = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US"))
        End If

        entPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negPatrimonio.Actualizar(entPatrimonio)

        If operacion Then
            MsgBox("Se guardo bien")
            ModoInicial()
        Else
            MsgBox("No se guardo bien")
        End If
    End Sub
    Private Sub EliminarPatrimonio()
        entPatrimonio.IdPatrimonio = dgvPatrimonio.CurrentRow.Cells("IdPatrimonio").Value
        entPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negPatrimonio.Eliminar(entPatrimonio)

        If operacion Then
            MsgBox("Elimino con exito")
            ModoInicial()
        Else
            MsgBox("No elimino bien")
        End If
    End Sub

    'PAGO

#End Region

#Region "Funciones del formulario"
    Private Sub FormPatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormPatrimonio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerPatrimonio()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarPatrimonio()
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerPatrimonio()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarPatrimonio()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaPatrimonio()
    End Sub


#End Region

End Class