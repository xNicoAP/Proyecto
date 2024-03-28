Imports System.IO
Public Class FormArticulo
    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = "C:\sistema\"

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

#Region "Métodos"
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 190
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 200
        DgvListado.Columns(9).Width = 150
        DgvListado.Columns(10).Width = 80

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChbSeleccionar.CheckState = False
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NArticulo
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
            Dim Neg As New Negocio.NArticulo
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
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtPrecioVenta.Text = ""
        TxtStock.Text = ""
        TxtImagen.Text = ""
        PicImagen.Image = Nothing
        TxtDescripcion.Text = ""
        RutaOrigen = ""
    End Sub

    Private Sub CargarCategoria()
        Try
            Dim Neg As New Negocio.NCategoria
            CboCategoria.DataSource = Neg.Seleccionar
            CboCategoria.ValueMember = "idcategoria"
            CboCategoria.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub FormArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OcultarSubMenu()
        Me.Listar()
        Me.CargarCategoria()
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
        LblEmail.Text = "Email: " & FormPrincipal.LblEmail.Text
    End Sub
#End Region

#Region "Botones Principales"
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
        'codigo
        'codigo
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


    Private Sub PbInicio_Click(sender As Object, e As EventArgs) Handles PbInicio.Click
        Me.Close()
        FormPrincipal.IdUsuario = IdUsuario
        FormPrincipal.IdRol = IdRol
        FormPrincipal.Rol = Rol
        FormPrincipal.Nombre = Nombre
        FormPrincipal.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Dim File As New OpenFileDialog()
        File.Filter = "Image Files(*.jpg, *.jpeg, *.png, *.jpe, *.jfif) | *.jpg; *.jpeg; *.png; *.jpe; *.jfif"
        If File.ShowDialog() = DialogResult.OK Then
            PicImagen.Image = Image.FromFile(File.FileName)
            RutaOrigen = File.FileName
            TxtImagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\") + 1)
        End If

    End Sub


#Region "Botones Insertar, Actualizar, Eliminar y Cancelar"
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If TxtNombre.Text = "" Or CboCategoria.Text = "" Or TxtPrecioVenta.Text = "" Or TxtStock.Text = "" Then
                MsgBox("Hay campos vacios, completelos", vbOKOnly + vbCritical, "Falta ingresar datos")
            Else
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.Codigo = TxtCodigo.Text
                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.Precio_Venta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = TxtImagen.Text
                Obj.Descripcion = TxtDescripcion.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    If (TxtImagen.Text <> "") Then
                        RutaDestino = Directorio & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                    'Me.CargarCategoria()
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

            If TxtNombre.Text = "" Or CboCategoria.Text = "" Or TxtPrecioVenta.Text = "" Or TxtStock.Text = "" Then
                MsgBox("Hay campos vacios, completelos", vbOKOnly + vbCritical, "Falta ingresar datos")

            Else
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.IdArticulo = TxtID.Text
                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.Precio_Venta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Descripcion = TxtDescripcion.Text
                Obj.Imagen = TxtImagen.Text


                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización correcta")
                    If (TxtImagen.Text <> "" And RutaOrigen <> "") Then
                        RutaDestino = Directorio & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización incorrecta")
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
#End Region

#Region "Doble click en un dato para actualizar"
    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtID.Text = DgvListado.SelectedCells.Item(1).Value
            CboCategoria.SelectedValue = DgvListado.SelectedCells.Item(2).Value
            TxtCodigo.Text = DgvListado.SelectedCells.Item(4).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(5).Value
            TxtPrecioVenta.Text = DgvListado.SelectedCells.Item(6).Value
            TxtStock.Text = DgvListado.SelectedCells.Item(7).Value
            TxtDescripcion.Text = DgvListado.SelectedCells.Item(8).Value
            Dim Imagen As String
            Imagen = DgvListado.SelectedCells.Item(9).Value
            If (Imagen <> "") Then
                PicImagen.Image = Image.FromFile(Directorio & Imagen)
                TxtImagen.Text = Imagen
            Else
                PicImagen.Image = Nothing
                TxtImagen.Text = ""
            End If
            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Seccion inferior - Mostrar columna Seleccionar, checkbox seleccionar,BTN eliminar, activar y desactivar"
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
                Dim Neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim imagen As String = Convert.ToString(row.Cells("Imagen").Value)
                        Neg.Eliminar(OneKey)
                        File.Delete(Directorio & imagen)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("¿Estas seguro de activar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulo
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
        If (MsgBox("¿Estas seguro de Desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulo
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

#Region "Validaciones ErrorIcon"
    Private Sub CboCategoria_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CboCategoria.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre de la categotia")
        End If
    End Sub

    Private Sub TxtStock_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtStock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese la cantidad de stock que hay")
        End If
    End Sub

    Private Sub TxtPrecioVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtPrecioVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el precio unitario del articulo")
        End If
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del Articulo")
        End If
    End Sub

#End Region

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Me.Close()
        FormLogin.Show()
        FormPrincipal.Limpiar()
    End Sub
End Class