<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChbSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PicImagen = New System.Windows.Forms.PictureBox()
        Me.BtnCargarImagen = New System.Windows.Forms.Button()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.PbInicio = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.PanelConsultasSubMenu = New System.Windows.Forms.Panel()
        Me.BtnConsultasVentas = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.PanelAccesoSubMenu = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.btnAcceso = New System.Windows.Forms.Button()
        Me.PanelVentasSubMenu = New System.Windows.Forms.Panel()
        Me.btnVentas2 = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVentas1 = New System.Windows.Forms.Button()
        Me.PanelIngresoSubMenu = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnProvedores = New System.Windows.Forms.Button()
        Me.btnIngresos = New System.Windows.Forms.Button()
        Me.PanelAlmacenSubMenu = New System.Windows.Forms.Panel()
        Me.btnArtículos = New System.Windows.Forms.Button()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnAlmacen = New System.Windows.Forms.Button()
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.PanelHoraFecha = New System.Windows.Forms.Panel()
        Me.LblEmail = New System.Windows.Forms.Label()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelConsultasSubMenu.SuspendLayout()
        Me.PanelAccesoSubMenu.SuspendLayout()
        Me.PanelVentasSubMenu.SuspendLayout()
        Me.PanelIngresoSubMenu.SuspendLayout()
        Me.PanelAlmacenSubMenu.SuspendLayout()
        Me.PanelInicio.SuspendLayout()
        Me.PanelHoraFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnDesactivar)
        Me.TabPage1.Controls.Add(Me.BtnActivar)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.ChbSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1138, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.Location = New System.Drawing.Point(450, 439)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(161, 38)
        Me.BtnDesactivar.TabIndex = 28
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = True
        '
        'BtnActivar
        '
        Me.BtnActivar.Location = New System.Drawing.Point(283, 439)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(161, 38)
        Me.BtnActivar.TabIndex = 27
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(116, 439)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(161, 38)
        Me.BtnEliminar.TabIndex = 26
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'ChbSeleccionar
        '
        Me.ChbSeleccionar.AutoSize = True
        Me.ChbSeleccionar.Location = New System.Drawing.Point(20, 455)
        Me.ChbSeleccionar.Name = "ChbSeleccionar"
        Me.ChbSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChbSeleccionar.TabIndex = 25
        Me.ChbSeleccionar.Text = "Seleccionar"
        Me.ChbSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(863, 15)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(208, 45)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(20, 23)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(754, 20)
        Me.TxtValor.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(735, 447)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(60, 25)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total"
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(20, 66)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(1098, 357)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Controls.Add(Me.TxtPrecioVenta)
        Me.TabPage2.Controls.Add(Me.TxtCodigo)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.PicImagen)
        Me.TabPage2.Controls.Add(Me.BtnCargarImagen)
        Me.TabPage2.Controls.Add(Me.TxtImagen)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.CboCategoria)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnInsertar)
        Me.TabPage2.Controls.Add(Me.TxtID)
        Me.TabPage2.Controls.Add(Me.TxtDescripcion)
        Me.TabPage2.Controls.Add(Me.TxtStock)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1138, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 24)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Nombre(*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Precio de Venta(*)"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(160, 94)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(428, 24)
        Me.TxtNombre.TabIndex = 34
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(160, 254)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(207, 24)
        Me.TxtPrecioVenta.TabIndex = 33
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(160, 145)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(207, 24)
        Me.TxtCodigo.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Codigo"
        '
        'PicImagen
        '
        Me.PicImagen.Location = New System.Drawing.Point(722, 114)
        Me.PicImagen.Name = "PicImagen"
        Me.PicImagen.Size = New System.Drawing.Size(383, 261)
        Me.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImagen.TabIndex = 30
        Me.PicImagen.TabStop = False
        '
        'BtnCargarImagen
        '
        Me.BtnCargarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarImagen.Location = New System.Drawing.Point(1015, 71)
        Me.BtnCargarImagen.Name = "BtnCargarImagen"
        Me.BtnCargarImagen.Size = New System.Drawing.Size(90, 29)
        Me.BtnCargarImagen.TabIndex = 29
        Me.BtnCargarImagen.Text = "..."
        Me.BtnCargarImagen.UseVisualStyleBackColor = True
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImagen.Location = New System.Drawing.Point(722, 74)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(287, 22)
        Me.TxtImagen.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(619, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Imagen"
        '
        'CboCategoria
        '
        Me.CboCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(160, 46)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(207, 28)
        Me.CboCategoria.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Categoria(*)"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(20, 429)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(168, 42)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(257, 429)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(168, 42)
        Me.BtnCancelar.TabIndex = 22
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(20, 429)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(168, 42)
        Me.BtnInsertar.TabIndex = 21
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(252, 9)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(57, 20)
        Me.TxtID.TabIndex = 20
        Me.TxtID.Visible = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(160, 307)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(428, 91)
        Me.TxtDescripcion.TabIndex = 19
        '
        'TxtStock
        '
        Me.TxtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtStock.Location = New System.Drawing.Point(160, 197)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(207, 24)
        Me.TxtStock.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Stock(*)"
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(161, 98)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1146, 515)
        Me.TabGeneral.TabIndex = 0
        '
        'PbInicio
        '
        Me.PbInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbInicio.Image = Global.Sistema.Presentacion.My.Resources.Resources.Startupfolder_11173
        Me.PbInicio.Location = New System.Drawing.Point(0, 3)
        Me.PbInicio.Name = "PbInicio"
        Me.PbInicio.Size = New System.Drawing.Size(152, 83)
        Me.PbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbInicio.TabIndex = 0
        Me.PbInicio.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblEmail)
        Me.Panel2.Controls.Add(Me.LblRol)
        Me.Panel2.Controls.Add(Me.LblNombre)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(155, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 89)
        Me.Panel2.TabIndex = 9
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblRol.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRol.ForeColor = System.Drawing.Color.White
        Me.LblRol.Location = New System.Drawing.Point(182, 49)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(86, 22)
        Me.LblRol.TabIndex = 5
        Me.LblRol.Text = "Principal"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(182, 9)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(86, 22)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Principal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnLogOut)
        Me.Panel1.Controls.Add(Me.PanelConsultasSubMenu)
        Me.Panel1.Controls.Add(Me.btnConsultas)
        Me.Panel1.Controls.Add(Me.PanelAccesoSubMenu)
        Me.Panel1.Controls.Add(Me.btnAcceso)
        Me.Panel1.Controls.Add(Me.PanelVentasSubMenu)
        Me.Panel1.Controls.Add(Me.btnVentas1)
        Me.Panel1.Controls.Add(Me.PanelIngresoSubMenu)
        Me.Panel1.Controls.Add(Me.btnIngresos)
        Me.Panel1.Controls.Add(Me.PanelAlmacenSubMenu)
        Me.Panel1.Controls.Add(Me.btnAlmacen)
        Me.Panel1.Controls.Add(Me.PanelInicio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 625)
        Me.Panel1.TabIndex = 8
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogOut.Location = New System.Drawing.Point(0, 581)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(155, 44)
        Me.BtnLogOut.TabIndex = 25
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'PanelConsultasSubMenu
        '
        Me.PanelConsultasSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelConsultasSubMenu.Controls.Add(Me.BtnConsultasVentas)
        Me.PanelConsultasSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelConsultasSubMenu.Location = New System.Drawing.Point(0, 518)
        Me.PanelConsultasSubMenu.Name = "PanelConsultasSubMenu"
        Me.PanelConsultasSubMenu.Size = New System.Drawing.Size(155, 54)
        Me.PanelConsultasSubMenu.TabIndex = 24
        '
        'BtnConsultasVentas
        '
        Me.BtnConsultasVentas.FlatAppearance.BorderSize = 0
        Me.BtnConsultasVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultasVentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnConsultasVentas.Location = New System.Drawing.Point(30, 18)
        Me.BtnConsultasVentas.Name = "BtnConsultasVentas"
        Me.BtnConsultasVentas.Size = New System.Drawing.Size(106, 27)
        Me.BtnConsultasVentas.TabIndex = 4
        Me.BtnConsultasVentas.Text = "Consultas - Ventas"
        Me.BtnConsultasVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultasVentas.UseVisualStyleBackColor = True
        '
        'btnConsultas
        '
        Me.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultas.Location = New System.Drawing.Point(0, 483)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(155, 35)
        Me.btnConsultas.TabIndex = 23
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'PanelAccesoSubMenu
        '
        Me.PanelAccesoSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelAccesoSubMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelAccesoSubMenu.Controls.Add(Me.btnRoles)
        Me.PanelAccesoSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAccesoSubMenu.Location = New System.Drawing.Point(0, 427)
        Me.PanelAccesoSubMenu.Name = "PanelAccesoSubMenu"
        Me.PanelAccesoSubMenu.Size = New System.Drawing.Size(155, 56)
        Me.PanelAccesoSubMenu.TabIndex = 22
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.Location = New System.Drawing.Point(30, 33)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(106, 27)
        Me.btnUsuarios.TabIndex = 3
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnRoles
        '
        Me.btnRoles.FlatAppearance.BorderSize = 0
        Me.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoles.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRoles.Location = New System.Drawing.Point(30, 0)
        Me.btnRoles.Name = "btnRoles"
        Me.btnRoles.Size = New System.Drawing.Size(106, 27)
        Me.btnRoles.TabIndex = 2
        Me.btnRoles.Text = "Roles"
        Me.btnRoles.UseVisualStyleBackColor = True
        '
        'btnAcceso
        '
        Me.btnAcceso.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAcceso.Location = New System.Drawing.Point(0, 394)
        Me.btnAcceso.Name = "btnAcceso"
        Me.btnAcceso.Size = New System.Drawing.Size(155, 33)
        Me.btnAcceso.TabIndex = 21
        Me.btnAcceso.Text = "Acceso"
        Me.btnAcceso.UseVisualStyleBackColor = True
        '
        'PanelVentasSubMenu
        '
        Me.PanelVentasSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelVentasSubMenu.Controls.Add(Me.btnVentas2)
        Me.PanelVentasSubMenu.Controls.Add(Me.btnClientes)
        Me.PanelVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVentasSubMenu.Location = New System.Drawing.Point(0, 338)
        Me.PanelVentasSubMenu.Name = "PanelVentasSubMenu"
        Me.PanelVentasSubMenu.Size = New System.Drawing.Size(155, 56)
        Me.PanelVentasSubMenu.TabIndex = 20
        '
        'btnVentas2
        '
        Me.btnVentas2.FlatAppearance.BorderSize = 0
        Me.btnVentas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas2.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVentas2.Location = New System.Drawing.Point(30, 33)
        Me.btnVentas2.Name = "btnVentas2"
        Me.btnVentas2.Size = New System.Drawing.Size(106, 27)
        Me.btnVentas2.TabIndex = 3
        Me.btnVentas2.Text = "Ventas"
        Me.btnVentas2.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.Location = New System.Drawing.Point(30, 0)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(106, 27)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnVentas1
        '
        Me.btnVentas1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas1.Location = New System.Drawing.Point(0, 294)
        Me.btnVentas1.Name = "btnVentas1"
        Me.btnVentas1.Size = New System.Drawing.Size(155, 44)
        Me.btnVentas1.TabIndex = 19
        Me.btnVentas1.Text = "Ventas"
        Me.btnVentas1.UseVisualStyleBackColor = True
        '
        'PanelIngresoSubMenu
        '
        Me.PanelIngresoSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelIngresoSubMenu.Controls.Add(Me.btnCompras)
        Me.PanelIngresoSubMenu.Controls.Add(Me.btnProvedores)
        Me.PanelIngresoSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelIngresoSubMenu.Location = New System.Drawing.Point(0, 238)
        Me.PanelIngresoSubMenu.Name = "PanelIngresoSubMenu"
        Me.PanelIngresoSubMenu.Size = New System.Drawing.Size(155, 56)
        Me.PanelIngresoSubMenu.TabIndex = 18
        '
        'btnCompras
        '
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCompras.Location = New System.Drawing.Point(30, 33)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(106, 27)
        Me.btnCompras.TabIndex = 3
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnProvedores
        '
        Me.btnProvedores.FlatAppearance.BorderSize = 0
        Me.btnProvedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProvedores.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProvedores.Location = New System.Drawing.Point(30, 0)
        Me.btnProvedores.Name = "btnProvedores"
        Me.btnProvedores.Size = New System.Drawing.Size(106, 27)
        Me.btnProvedores.TabIndex = 2
        Me.btnProvedores.Text = "Provedores"
        Me.btnProvedores.UseVisualStyleBackColor = True
        '
        'btnIngresos
        '
        Me.btnIngresos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIngresos.Location = New System.Drawing.Point(0, 194)
        Me.btnIngresos.Name = "btnIngresos"
        Me.btnIngresos.Size = New System.Drawing.Size(155, 44)
        Me.btnIngresos.TabIndex = 17
        Me.btnIngresos.Text = "Ingresos"
        Me.btnIngresos.UseVisualStyleBackColor = True
        '
        'PanelAlmacenSubMenu
        '
        Me.PanelAlmacenSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelAlmacenSubMenu.Controls.Add(Me.btnArtículos)
        Me.PanelAlmacenSubMenu.Controls.Add(Me.btnCategorias)
        Me.PanelAlmacenSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAlmacenSubMenu.Location = New System.Drawing.Point(0, 138)
        Me.PanelAlmacenSubMenu.Name = "PanelAlmacenSubMenu"
        Me.PanelAlmacenSubMenu.Size = New System.Drawing.Size(155, 56)
        Me.PanelAlmacenSubMenu.TabIndex = 16
        '
        'btnArtículos
        '
        Me.btnArtículos.FlatAppearance.BorderSize = 0
        Me.btnArtículos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArtículos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnArtículos.Location = New System.Drawing.Point(30, 33)
        Me.btnArtículos.Name = "btnArtículos"
        Me.btnArtículos.Size = New System.Drawing.Size(106, 27)
        Me.btnArtículos.TabIndex = 3
        Me.btnArtículos.Text = "Articulos"
        Me.btnArtículos.UseVisualStyleBackColor = True
        '
        'btnCategorias
        '
        Me.btnCategorias.FlatAppearance.BorderSize = 0
        Me.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategorias.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCategorias.Location = New System.Drawing.Point(30, 0)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(106, 27)
        Me.btnCategorias.TabIndex = 2
        Me.btnCategorias.Text = "Categorias"
        Me.btnCategorias.UseVisualStyleBackColor = True
        '
        'btnAlmacen
        '
        Me.btnAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlmacen.Location = New System.Drawing.Point(0, 89)
        Me.btnAlmacen.Name = "btnAlmacen"
        Me.btnAlmacen.Size = New System.Drawing.Size(155, 49)
        Me.btnAlmacen.TabIndex = 15
        Me.btnAlmacen.Text = "Almacen"
        Me.btnAlmacen.UseVisualStyleBackColor = True
        '
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.PbInicio)
        Me.PanelInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInicio.Location = New System.Drawing.Point(0, 0)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(155, 89)
        Me.PanelInicio.TabIndex = 0
        '
        'PanelHoraFecha
        '
        Me.PanelHoraFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelHoraFecha.Controls.Add(Me.TabGeneral)
        Me.PanelHoraFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHoraFecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelHoraFecha.Location = New System.Drawing.Point(0, 0)
        Me.PanelHoraFecha.Name = "PanelHoraFecha"
        Me.PanelHoraFecha.Size = New System.Drawing.Size(1339, 625)
        Me.PanelHoraFecha.TabIndex = 10
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(535, 9)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(86, 22)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "Principal"
        '
        'FormArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 625)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHoraFecha)
        Me.Name = "FormArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormArticulo"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelConsultasSubMenu.ResumeLayout(False)
        Me.PanelAccesoSubMenu.ResumeLayout(False)
        Me.PanelVentasSubMenu.ResumeLayout(False)
        Me.PanelIngresoSubMenu.ResumeLayout(False)
        Me.PanelAlmacenSubMenu.ResumeLayout(False)
        Me.PanelInicio.ResumeLayout(False)
        Me.PanelHoraFecha.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents PanelConsultasSubMenu As Panel
    Friend WithEvents BtnConsultasVentas As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents PanelAccesoSubMenu As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnRoles As Button
    Friend WithEvents btnAcceso As Button
    Friend WithEvents PanelVentasSubMenu As Panel
    Friend WithEvents btnVentas2 As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVentas1 As Button
    Friend WithEvents PanelIngresoSubMenu As Panel
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnProvedores As Button
    Friend WithEvents btnIngresos As Button
    Friend WithEvents PanelAlmacenSubMenu As Panel
    Friend WithEvents btnArtículos As Button
    Friend WithEvents btnCategorias As Button
    Friend WithEvents btnAlmacen As Button
    Friend WithEvents PanelInicio As Panel
    Friend WithEvents PbInicio As PictureBox
    Friend WithEvents PanelHoraFecha As Panel
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChbSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PicImagen As PictureBox
    Friend WithEvents BtnCargarImagen As Button
    Friend WithEvents TxtImagen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblRol As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblEmail As Label
End Class
