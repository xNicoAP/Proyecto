Public Class FormPrincipal
    Private _IdUsuario As String
    Private _IdRol As String
    Private _Rol As String
    Private _Nombre As String

#Region "Encapsulado"
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
#End Region

#Region "Load"
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
        MsgBox("Bienvenido " & Nombre, vbOKOnly + vbInformation, "Bienvenido al sistema")
        Me.Datos()
        If (Me.Rol = "Administrador") Then
            BtnAlmacen.Enabled = True
            btnIngresos.Enabled = True
            btnVentas1.Enabled = True
            btnAcceso.Enabled = True
            btnConsultas.Enabled = True
        ElseIf (Me.Rol = "Vendedor") Then
            BtnAlmacen.Enabled = False
            btnIngresos.Enabled = False
            btnVentas1.Enabled = True
            btnAcceso.Enabled = False
            btnConsultas.Enabled = False
        ElseIf (Me.Rol = "Almacenero") Then
            BtnAlmacen.Enabled = True
            btnIngresos.Enabled = True
            btnVentas1.Enabled = False
            btnAcceso.Enabled = False
            btnConsultas.Enabled = False
        Else
            BtnAlmacen.Enabled = False
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

    Public Sub Limpiar()
        FormLogin.TxtEmail.Text = ""
        FormLogin.TxtClave.Text = ""
    End Sub

    Public Sub Datos()
        LblNombre.Text = "Nombre: " & Nombre
        LblRol.Text = "Rol: " & Rol
        'LblEmail.Text = "Email: " & Email
        LblEmail.Text = "Email: " & FormLogin.TxtEmail.Text
    End Sub
#End Region

#Region "Botones Principales"
    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles BtnAlmacen.Click
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
        OcultarSubMenu()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Me.Close()
        FormUsuario.IdUsuario = IdUsuario
        FormUsuario.IdRol = IdRol
        FormUsuario.Rol = Rol
        FormUsuario.Nombre = Nombre
        FormUsuario.Show()
        OcultarSubMenu()
    End Sub

    Private Sub BtnConsultasVentas_Click(sender As Object, e As EventArgs) Handles BtnConsultasVentas.Click
        'codigo
        'codigo
        OcultarSubMenu()
    End Sub
#End Region


#Region "Timer (hora y fecha)"
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString
        LblFecha.Text = DateTime.Now.ToLongDateString
    End Sub

#End Region

    Private Sub PbInicio_Click(sender As Object, e As EventArgs) Handles PbInicio.Click
        Me.Show()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Me.Close()
        FormLogin.Show()
        Me.Limpiar()
    End Sub
End Class