Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormRelacionDebeHaber
#Region "Variables"

    Dim negRelacionDebeHaber As New NegRelacionDebeHaber
    Dim entRelacionDebeHaber As New EntRelacionDebeHaber
    Dim negGrupoActivo As New NegGrupoActivo
    Dim negGrupoPasivo As New NegGrupoPasivo
    Dim negGrupoPatrimonio As New NegGrupoPatrimonio
    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim cantRelacionDebeHabers As Integer = 0
    Dim blnActualizar As Boolean = False

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        CargarTablaRelacionDebeHaber()
        dgvRelacionDebeHaber.Enabled = True
        Me.Height = 442
        txtIdRelacionDebeHaber.Text = "0"
        cbEtapaOperacion.SelectedIndex = 0
        cbGrupoDebe.SelectedIndex = 0
        cbGrupoHaber.SelectedIndex = 0
        cbSignoDebe.SelectedIndex = 0
        cbSignoHaber.SelectedIndex = 0
        cbTipoOperacion.SelectedIndex = 0
        cbDebe.Enabled = False
        cbHaber.Enabled = False
        cbGrupo.Enabled = False
        btnNuevo.Enabled = True
        If cantRelacionDebeHabers = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
        PanelRelacionDebeHaber.Visible = False

    End Sub

    Private Sub ModoRegistro()
        Me.Height = 612
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvRelacionDebeHaber.Enabled = False
        PanelRelacionDebeHaber.Visible = True
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaRelacionDebeHaber()
        dataTable = negRelacionDebeHaber.ObtenerTabla(0, 0)
        dgvRelacionDebeHaber.DataSource = dataTable
        cantRelacionDebeHabers = dgvRelacionDebeHaber.Rows.Count
    End Sub

#End Region

#Region "Funciones Principales (CRUD)"
    'RelacionDebeHaber
    Private Sub CrearRelacionDebeHaber()
        If cbTipoOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de operación (Ingreso/Egreso)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.TipoOperacionId = cbTipoOperacion.SelectedIndex
        End If

        If cbEtapaOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger la etapa de la operación (Registro/Cobro-Pago)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.EtapaOperacionId = cbEtapaOperacion.SelectedIndex
        End If

        If cbGrupo.SelectedValue = 0 Then
            MsgBox("Escoger la operación", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoId = cbGrupo.SelectedValue
        End If

        If cbGrupoDebe.SelectedValue = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoDebeId = cbGrupoDebe.SelectedValue
        End If

        If cbDebe.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.DebeId = cbDebe.SelectedValue
        End If

        If cbSignoDebe.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Debe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoDebe = cbSignoDebe.SelectedIndex
        End If

        If cbGrupoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoHaberId = cbGrupoHaber.SelectedIndex
        End If

        If cbHaber.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.HaberId = cbHaber.SelectedValue
        End If

        If cbSignoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Haber", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoHaber = cbSignoHaber.SelectedIndex
        End If

        entRelacionDebeHaber.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negRelacionDebeHaber.Guardar(entRelacionDebeHaber)

        If operacion Then
            MsgBox("Guardo con exito", MsgBoxStyle.Information, "Crear Relacion Debe-Haber")
            ModoInicial()
        Else
            MsgBox("No guardo bien", MsgBoxStyle.Critical, "Crear Relacion Debe-Haber")
        End If
    End Sub
    Private Sub LeerRelacionDebeHaber()

        entRelacionDebeHaber = negRelacionDebeHaber.ObtenerData(dgvRelacionDebeHaber.CurrentRow.Cells("IdRelacionDebeHaber").Value, 0, 0)
        txtIdRelacionDebeHaber.Text = entRelacionDebeHaber.IdRelacionDebeHaber
        cbTipoOperacion.SelectedIndex = entRelacionDebeHaber.TipoOperacionId
        cbSignoHaber.SelectedIndex = entRelacionDebeHaber.SignoHaber
        cbSignoDebe.SelectedIndex = entRelacionDebeHaber.SignoDebe
        cbHaber.SelectedValue = entRelacionDebeHaber.HaberId
        cbGrupoHaber.SelectedIndex = entRelacionDebeHaber.GrupoHaberId
        cbGrupoDebe.SelectedIndex = entRelacionDebeHaber.GrupoDebeId
        cbGrupo.SelectedValue = entRelacionDebeHaber.GrupoId
        cbEtapaOperacion.SelectedIndex = entRelacionDebeHaber.EtapaOperacionId
        cbDebe.SelectedValue = entRelacionDebeHaber.DebeId

    End Sub
    Private Sub ActualizarRelacionDebeHaber()
        If cbTipoOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de operación (Ingreso/Egreso)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.TipoOperacionId = cbTipoOperacion.SelectedIndex
        End If

        If cbEtapaOperacion.SelectedIndex = 0 Then
            MsgBox("Escoger la etapa de la operación (Registro/Cobro-Pago)", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.EtapaOperacionId = cbEtapaOperacion.SelectedIndex
        End If

        If cbGrupo.SelectedValue = 0 Then
            MsgBox("Escoger la operación", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoId = cbGrupo.SelectedValue
        End If

        If cbGrupoDebe.SelectedValue = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoDebeId = cbGrupoDebe.SelectedValue
        End If

        If cbDebe.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.DebeId = cbDebe.SelectedValue
        End If

        If cbSignoDebe.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Debe", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoDebe = cbSignoDebe.SelectedIndex
        End If

        If cbGrupoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de componente financiero (Activo/Pasivo/Patrimonio", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.GrupoHaberId = cbGrupoHaber.SelectedIndex
        End If

        If cbHaber.SelectedValue = 0 Then
            MsgBox("Escoger el componente financiero", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.HaberId = cbHaber.SelectedValue
        End If

        If cbSignoHaber.SelectedIndex = 0 Then
            MsgBox("Escoger el signo del Haber", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entRelacionDebeHaber.SignoHaber = cbSignoHaber.SelectedIndex
        End If

        entRelacionDebeHaber.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negRelacionDebeHaber.Actualizar(entRelacionDebeHaber)

        If operacion Then
            MsgBox("Se guardo bien")
            ModoInicial()
        Else
            MsgBox("No se guardo bien")
        End If
    End Sub
    Private Sub EliminarRelacionDebeHaber()
        entRelacionDebeHaber.IdRelacionDebeHaber = dgvRelacionDebeHaber.CurrentRow.Cells("IdRelacionDebeHaber").Value
        entRelacionDebeHaber.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negRelacionDebeHaber.Eliminar(entRelacionDebeHaber)

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
    Private Sub FormRelacionDebeHaber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormRelacionDebeHaber_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerRelacionDebeHaber()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarRelacionDebeHaber()
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdRelacionDebeHaber.Text = "0" Then
            CrearRelacionDebeHaber()
        Else
            ActualizarRelacionDebeHaber()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerRelacionDebeHaber()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarRelacionDebeHaber()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbTipoOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoOperacion.SelectedIndexChanged
        If cbTipoOperacion.SelectedIndex = 0 Then
            cbGrupo.Enabled = False
        Else
            If cbTipoOperacion.SelectedIndex = 1 Then
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdSubGrupoEgreso"
                cbGrupo.DisplayMember = "ItemSubGrupoEgreso" '
                cbGrupo.DataSource = negGrupoIngreso.ObtenerLista(False, True)
            Else
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdSubGrupoEgreso"
                cbGrupo.DisplayMember = "ItemSubGrupoEgreso" '
                cbGrupo.DataSource = negSubGrupoEgreso.ObtenerLista(False, True, 0)
            End If
        End If
    End Sub

    Private Sub cbGrupoDebe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrupoDebe.SelectedIndexChanged
        If cbTipoOperacion.SelectedIndex = 0 Then
            cbGrupo.Enabled = False
        Else
            If cbTipoOperacion.SelectedIndex = 1 Then
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdGrupoIngreso"
                cbGrupo.DisplayMember = "Descripcion" '
                cbGrupo.DataSource = negGrupoIngreso.ObtenerLista(False, True)
            End If
            If cbTipoOperacion.SelectedIndex = 2 Then
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdSubGrupoEgreso"
                cbGrupo.DisplayMember = "ItemSubGrupoEgreso" '
                cbGrupo.DataSource = negSubGrupoEgreso.ObtenerLista(False, True, 0)
            End If
        End If
    End Sub

    Private Sub cbGrupoHaber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrupoHaber.SelectedIndexChanged
        If cbGrupoHaber.SelectedIndex = 0 Then
            cbGrupo.Enabled = False
        Else
            If cbGrupoHaber.SelectedIndex = 1 Then
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdGrupoActivo"
                cbGrupo.DisplayMember = "Descripcion"
                cbGrupo.DataSource = negGrupoActivo.ObtenerLista(False, True)
            End If
            If cbGrupoHaber.SelectedIndex = 2 Then
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdGrupoPasivo"
                cbGrupo.DisplayMember = "Descripcion"
                cbGrupo.DataSource = negGrupoPasivo.ObtenerLista(False, True)
            End If
            If cbGrupoHaber.SelectedIndex = 3 Then
                cbGrupo.Enabled = True
                cbGrupo.ValueMember = "IdGrupoPatrimonio"
                cbGrupo.DisplayMember = "Descripcion"
                cbGrupo.DataSource = negGrupoPatrimonio.ObtenerLista(False, True)
            End If
        End If
    End Sub


#End Region
End Class