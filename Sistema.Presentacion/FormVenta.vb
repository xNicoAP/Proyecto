Public Class FormVenta
    Private dtdetalle As New DataTable

#Region "encapsular"
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
#End Region

#Region "Load"
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OcultarSubMenu()
        Me.Datos()
        Me.Listar()
        Me.CrearTablaDetalle()
        Me.ListarArt()
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

#Region "Métodos"
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(3).Width = 150
        DgvListado.Columns(4).Width = 150
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 70
        DgvListado.Columns(7).Width = 70
        DgvListado.Columns(8).Width = 60
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100
        DgvListado.Columns(11).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnAnular.Visible = False
        ChbSeleccionar.CheckState = False
    End Sub

    Private Sub FormatoArticulos()
        DgvArticulos.Columns(0).Visible = False
        DgvArticulos.Columns(1).Visible = False
        DgvArticulos.Columns(2).Visible = False
        DgvArticulos.Columns(3).Width = 100
        DgvArticulos.Columns(4).Width = 150
        DgvArticulos.Columns(5).Width = 100
        DgvArticulos.Columns(6).Width = 100
        DgvArticulos.Columns(7).Width = 200
        DgvArticulos.Columns(8).Width = 100
        DgvArticulos.Columns(9).Width = 100
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NVenta
            DgvListado.DataSource = Neg.Listar()
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListarArt()
        Try
            Dim Neg As New Negocio.NArticulo
            DgvArticulos.DataSource = Neg.Listar()
            LblTotalArticulos.Text = "Total Articulos: " & DgvArticulos.DataSource.Rows.count
            Me.FormatoArticulos()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NVenta
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
        TxtValor.Text = ""
        TxtID.Text = ""
        TxtCodigo.Text = ""
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
        TxtSerieComprobante.Text = ""
        TxtNumeroComprobante.Text = ""
        dtdetalle.Clear()
        TxtSubTotal.Text = 0
        TxtTotalImpuesto.Text = 0
        TxtTotal.Text = 0
    End Sub

    Private Sub CrearTablaDetalle()
        Me.dtdetalle = New DataTable("Detalle")
        Me.dtdetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"))
        Me.dtdetalle.Columns.Add("codigo", System.Type.GetType("System.String"))
        Me.dtdetalle.Columns.Add("articulo", System.Type.GetType("System.String"))
        Me.dtdetalle.Columns.Add("stock", System.Type.GetType("System.Int32"))
        Me.dtdetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.dtdetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"))
        Me.dtdetalle.Columns.Add("descuento", System.Type.GetType("System.Int32"))
        Me.dtdetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"))

        DgvDetalle.DataSource = Me.dtdetalle
        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "Codigo"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "Articulo"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "Stock"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "Cantidad"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "Precio"
        DgvDetalle.Columns(5).Width = 100
        DgvDetalle.Columns(6).HeaderText = "Descuento"
        DgvDetalle.Columns(6).Width = 100
        DgvDetalle.Columns(7).HeaderText = "Importe"
        DgvDetalle.Columns(7).Width = 100

        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(3).ReadOnly = True
        DgvDetalle.Columns(7).ReadOnly = True
    End Sub

    Private Sub AgregarDetalle(Fila As Entidades.Articulo)
        Dim Agregar As Boolean = True

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            If (Convert.ToInt32(FilaTemp.Cells("idarticulo").Value) = Convert.ToInt32(Fila.IdArticulo)) Then
                Agregar = False
                MsgBox("El articulo ya ha sido agregado", vbOKOnly + vbCritical, "Error agregando detalles")
            End If
        Next
        If (Agregar = True) Then
            Dim Row As DataRow
            Row = Me.dtdetalle.NewRow()
            Row("idarticulo") = Convert.ToString(Fila.IdArticulo)
            Row("codigo") = Convert.ToString(Fila.Codigo)
            Row("articulo") = Convert.ToString(Fila.Nombre)
            Row("stock") = Convert.ToString(Fila.Stock)
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToString(Fila.Precio_Venta)
            Row("descuento") = Convert.ToString(0)
            Row("importe") = Convert.ToString(Fila.Precio_Venta)
            Me.dtdetalle.Rows.Add(Row)
            Me.CalcularTotales()
            TxtCodigo.Text = ""
        End If
    End Sub

    Private Sub CalcularTotales()
        Dim Total As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim TotalImpuesto As Decimal = 0
        'Dim DescuentoPorcentaje As Integer = 0

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            SubTotal = Math.Round(SubTotal + Convert.ToDecimal(FilaTemp.Cells("importe").Value), 2)
        Next

        TxtTotalImpuesto.Text = Convert.ToString((SubTotal * TxtImpuesto.Text) / 100)

        'For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
        'DescuentoPorcentaje = Convert.ToString((Total * Convert.ToInt32(FilaTemp.Cells("descuento").Value)) / 100)
        'Next

        TxtSubTotal.Text = SubTotal
        Total = Math.Round(SubTotal + Convert.ToDecimal(TxtTotalImpuesto.Text), 2)
        TxtTotal.Text = Total
    End Sub

#End Region

#Region "Funcionalidades"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        FormCliente_Venta.ShowDialog()
        TxtIdCliente.Text = Variables.IdCliente
        TxtNombreCliente.Text = Variables.NombreCliente
    End Sub

    Private Sub BtnLimpiarCliente_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCliente.Click
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Dim Neg As New Negocio.NArticulo
                Dim Obj As New Entidades.Articulo
                Obj = Neg.BuscarCodigoVenta(TxtCodigo.Text)
                If (Obj Is Nothing) Then
                    MsgBox("No existe un articulo con ese codigo de barras", vbOKOnly + vbCritical, "No existe articulo")
                Else
                    Me.AgregarDetalle(Obj)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBuscarIngreso_Click(sender As Object, e As EventArgs) Handles BtnBuscarIngreso.Click
        PanelArticulos.Visible = True
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        PanelArticulos.Visible = False
    End Sub

    Private Sub BtnBuscarArticulosDetalle_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulosDetalle.Click
        Try
            Dim Neg As New Negocio.NArticulo
            Dim Valor As String
            Valor = TxtBuscarArticulos.Text
            DgvArticulos.DataSource = Neg.BuscarVenta(Valor)
            LblTotalArticulos.Text = "Total Articulos: " & DgvArticulos.DataSource.Rows.Count
            Me.FormatoArticulos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArticulos.CellDoubleClick
        Try
            Dim Obj As New Entidades.Articulo
            Obj.IdArticulo = DgvArticulos.SelectedCells.Item(0).Value
            Obj.Codigo = DgvArticulos.SelectedCells.Item(3).Value
            Obj.Nombre = DgvArticulos.SelectedCells.Item(4).Value
            Obj.Precio_Venta = DgvArticulos.SelectedCells.Item(5).Value
            Obj.Stock = DgvArticulos.SelectedCells.Item(6).Value
            Me.AgregarDetalle(Obj)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim Fila As DataGridViewRow = CType(DgvDetalle.Rows(e.RowIndex), DataGridViewRow)
        Dim Precio As Decimal = Fila.Cells("precio").Value
        Dim Cantidad As Integer = Fila.Cells("cantidad").Value
        Dim Descuento As Integer = Fila.Cells("descuento").Value
        Dim Stock As Integer = Fila.Cells("stock").Value
        Dim Articulo As String = Fila.Cells("articulo").Value
        Dim Contenedor As Integer = 0

        If (Cantidad > Stock) Then
            Cantidad = Stock
            MsgBox("La cantidad de venta del artículo " & Articulo & " supera el stock disponible de " & Stock, vbOKOnly + vbCritical, "Stock no disponible")
        End If

        Fila.Cells("cantidad").Value = Cantidad
        Contenedor = ((Precio * Cantidad) * Descuento / 100)
        Fila.Cells("importe").Value = (Precio * Cantidad) - Contenedor

        Me.CalcularTotales()
        'OTRA FORMA DE HACER EL DESCUENTO EN PORCENTAJE
        'Fila.Cells("importe").Value = (Precio - ((Precio * Cantidad) * Descuento / 100))
    End Sub

    Private Sub DgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvDetalle.RowsRemoved
        Me.CalcularTotales()
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If (TxtIdCliente.Text <> "" And CboTipoComprobante.Text <> "" And TxtNumeroComprobante.Text <> "" And dtdetalle.Rows.Count > 0) Then
                Dim Obj As New Entidades.Venta
                Dim Neg As New Negocio.NVenta

                Obj.IdUsuario = Variables.IdUsuario
                Obj.IdCliente = TxtIdCliente.Text
                Obj.TipoComprobante = CboTipoComprobante.Text
                Obj.SerieComprobante = TxtSerieComprobante.Text
                Obj.NumComprobante = TxtNumeroComprobante.Text
                Obj.Impuesto = TxtImpuesto.Text
                Obj.Total = TxtTotal.Text

                If (Neg.Insertar(Obj, dtdetalle)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If

            Else
                MsgBox("Rellene los campos obligatorios, agrege al menos 1 detalle", vbOKOnly + vbCritical, "Faltan ingresar Datos")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarD_Click(sender As Object, e As EventArgs) Handles BtnCerrarD.Click
        PanelMostrar.Visible = False
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            Dim Neg As New Negocio.NVenta
            DgvMostrarDetalles.DataSource = Neg.ListarDetalle(DgvListado.SelectedCells.Item(1).Value)

            Dim SubTotal As Decimal = 0
            Dim TotalImpuesto As Decimal = 0
            Dim Total As Decimal = 0
            Total = DgvListado.SelectedCells.Item(10).Value
            SubTotal = Math.Round(Total / (1 + 0.22), 2)
            TotalImpuesto = Math.Round(((SubTotal * 22) / 100), 2)

            LblTotald.Text = Total
            LblTotalImpuestoD.Text = TotalImpuesto
            LblSubTotalD.Text = SubTotal

            PanelMostrar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub ChbSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbSeleccionar.CheckedChanged
        If ChbSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnAnular.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnAnular.Visible = False
        End If
    End Sub

    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If (MsgBox("¿Estas seguro de anular las ventas seleccionadas?", vbYesNo + vbQuestion, "Anular Ventas") = vbYes) Then
            Try
                Dim Neg As New Negocio.NVenta
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Anular(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
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

#Region "Funcion del formulario"

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
        OcultarSubMenu()
    End Sub

    Private Sub btnVentas2_Click(sender As Object, e As EventArgs) Handles btnVentas2.Click
        'codigo
        'codigo
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

    Private Sub PbInicio_Click(sender As Object, e As EventArgs) Handles PbInicio.Click
        Me.Close()
        FormPrincipal.IdUsuario = IdUsuario
        FormPrincipal.IdRol = IdRol
        FormPrincipal.Rol = Rol
        FormPrincipal.Nombre = Nombre
        FormPrincipal.Show()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Me.Close()
        FormLogin.Show()
        FormPrincipal.Limpiar()
    End Sub
#End Region
#End Region



End Class