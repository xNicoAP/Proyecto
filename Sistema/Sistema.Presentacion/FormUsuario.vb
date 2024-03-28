Public Class FormUsuario

    Private _IdUsuario As String
    Private _IdRol As String
    Private _Rol As String
    Private _Nombre As String

    Public Property IdUsuario As String
        Get
            Return _IdUsuario
        End Get
        Set(value As String)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdRol As String
        Get
            Return _IdRol
        End Get
        Set(value As String)
            _IdRol = value
        End Set
    End Property

    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property


#Region "Load"
    Private Sub FormRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OcultarSubMenu()
        Me.Listar()
        Me.CargarRol()
        Me.Datos()
        If (Me.Rol = "Administrador") Then
            btnAlmacen.Enabled = True
            btnIngresos.Enabled = True
            btnVentas1.Enabled = True
            btnAcceso.Enabled = True
            btnConsultas.Enabled = True
        ElseIf (Me.Rol = "Vendedor") Then
            btnAlmacen.Enabled = False
            btnIngresos.Enabled = False
            btnVentas1.Enabled = True
            btnAcceso.Enabled = False
            btnConsultas.Enabled = False
        ElseIf (Me.Rol = "Almacenero") Then
            btnAlmacen.Enabled = True
            btnIngresos.Enabled = True
            btnVentas1.Enabled = False
            btnAcceso.Enabled = False
            btnConsultas.Enabled = False
        Else
            btnAlmacen.Enabled = False
            btnIngresos.Enabled = False
            btnVentas1.Enabled = False
            btnAcceso.Enabled = False
            btnConsultas.Enabled = False
        End If
    End Sub
#End Region

#Region "Funciones"
    Private Sub OcultarSubMenu()
        PanelAccesoSubMenu.Visible = False
        PanelAlmacenSubMenu.Visible = False
        PanelConsultasSubMenu.Visible = False
        PanelIngresoSubMenu.Visible = False
        PanelVentasSubMenu.Visible = False
    End Sub

    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Public Sub Datos()
        LblNombre.Text = "Nombre: " & Nombre
        LblRol.Text = "Rol: " & Rol
        LblEmail.Text = "Email: " & FormLogin.TxtEmail.Text
    End Sub
#End Region

#Region "Botones Principales"
    Private Sub PbInicio_Click(sender As Object, e As EventArgs) Handles PbInicio.Click
        Me.Close()
        FormPrincipal.IdUsuario = IdUsuario
        FormPrincipal.IdRol = IdRol
        FormPrincipal.Rol = Rol
        FormPrincipal.Nombre = Nombre
        FormPrincipal.Show()
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        MostrarSubMenu(PanelAlmacenSubMenu)
    End Sub

    Private Sub btnIngresos_Click(sender As Object, e As EventArgs) Handles btnIngresos.Click
        MostrarSubMenu(PanelIngresoSubMenu)
    End Sub

    Private Sub btnVentas1_Click(sender As Object, e As EventArgs) Handles btnVentas1.Click
        MostrarSubMenu(PanelVentasSubMenu)
    End Sub

    Private Sub btnAcceso_Click(sender As Object, e As EventArgs) Handles btnAcceso.Click
        MostrarSubMenu(PanelAccesoSubMenu)
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        MostrarSubMenu(PanelConsultasSubMenu)
    End Sub

#End Region

#Region "Sub botones"
    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        Me.Close()
        FormCategoria.IdUsuario = IdUsuario
        FormCategoria.IdRol = IdRol
        FormCategoria.Rol = Rol
        FormCategoria.Nombre = Nombre
        FormCategoria.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnArtículos_Click(sender As Object, e As EventArgs) Handles btnArtículos.Click
        Me.Close()
        FormArticulo.IdUsuario = IdUsuario
        FormArticulo.IdRol = IdRol
        FormArticulo.Rol = Rol
        FormArticulo.Nombre = Nombre
        FormArticulo.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnProvedores_Click(sender As Object, e As EventArgs) Handles btnProvedores.Click
        Me.Close()
        FormProveedor.IdUsuario = IdUsuario
        FormProveedor.IdRol = IdRol
        FormProveedor.Rol = Rol
        FormProveedor.Nombre = Nombre
        FormProveedor.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Me.Close()
        FormIngreso.IdUsuario = IdUsuario
        FormIngreso.IdRol = IdRol
        FormIngreso.Rol = Rol
        FormIngreso.Nombre = Nombre
        FormIngreso.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Me.Close()
        FormCliente.IdUsuario = IdUsuario
        FormCliente.IdRol = IdRol
        FormCliente.Rol = Rol
        FormCliente.Nombre = Nombre
        FormCliente.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnVentas2_Click(sender As Object, e As EventArgs) Handles btnVentas2.Click
        Me.Close()
        FormVenta.IdUsuario = IdUsuario
        FormVenta.IdRol = IdRol
        FormVenta.Rol = Rol
        FormVenta.Nombre = Nombre
        FormVenta.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Me.Close()
        FormRol.IdUsuario = IdUsuario
        FormRol.IdRol = IdRol
        FormRol.Rol = Rol
        FormRol.Nombre = Nombre
        FormRol.Show()
        FormRol.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        'codigo
        'codigo
        OcultarSubMenu()
    End Sub

    Private Sub BtnConsultasVentas_Click(sender As Object, e As EventArgs) Handles BtnConsultasVentas.Click
        'codigo
        'codigo
        OcultarSubMenu()
    End Sub
#End Region

#Region "Métodos"
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 120
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 120
        DgvListado.Columns(8).Width = 100
        DgvListado.Columns(9).Width = 120
        DgvListado.Columns(10).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChbSeleccionar.CheckState = False
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NUsuario
            DgvListado.DataSource = Neg.Listar()
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NUsuario
            Dim Valor As String
            Valor = TxtValor.Text

            DgvListado.DataSource = Neg.Buscar(Valor)
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtID.Text = ""
        TxtNombre.Text = ""
        TxtTelefono.Text = ""
        TxtDireccion.Text = ""
        TxtNumeroDocumento.Text = ""
        TxtEmail.Text = ""
        TxtClave.Text = ""
    End Sub

    Private Sub CargarRol()
        Try
            Dim Neg As New Negocio.NRol
            CboRol.DataSource = Neg.Listar()
            CboRol.ValueMember = "idrol"
            CboRol.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub



#Region "Botones Insertar, Actualizar, Eliminar y Cancelar"
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If TxtNombre.Text = "" Or CboRol.Text = "" Or TxtEmail.Text = "" Or TxtClave.Text = "" Then
                MsgBox("Hay campos vacios, completelos", vbOKOnly + vbCritical, "Falta ingresar datos")
            Else
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.NUsuario

                Obj.IdRol = CboRol.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text
                Obj.NumDocumento = TxtNumeroDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text
                Obj.Clave = TxtClave.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If TxtNombre.Text = "" Or CboRol.Text = "" Or TxtEmail.Text = "" And TxtID.Text = "" Then
                MsgBox("Hay campos vacios, completelos", vbOKOnly + vbCritical, "Falta ingresar datos")
            Else
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.NUsuario

                Obj.IdUsuario = TxtID.Text
                Obj.IdRol = CboRol.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text
                Obj.NumDocumento = TxtNumeroDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text
                Obj.Clave = TxtClave.Text

                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualizado correcto")
                    Me.Listar()
                Else
                    MsgBox("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización incorrecto")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtID.Text = DgvListado.SelectedCells.Item(1).Value
            CboRol.Text = DgvListado.SelectedCells.Item(3).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(4).Value
            CboTipoDocumento.Text = DgvListado.SelectedCells.Item(5).Value
            TxtNumeroDocumento.Text = DgvListado.SelectedCells.Item(6).Value
            TxtDireccion.Text = DgvListado.SelectedCells.Item(7).Value
            TxtTelefono.Text = DgvListado.SelectedCells.Item(8).Value
            TxtEmail.Text = DgvListado.SelectedCells.Item(9).Value

            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub ChbSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbSeleccionar.CheckedChanged
        If ChbSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("¿Estas seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Eliminar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("¿Estas seguro de Activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Activar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("¿Estas seguro de Desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Desactivar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
#End Region
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Me.Close()
        FormLogin.Show()
        FormPrincipal.Limpiar()
    End Sub
End Class