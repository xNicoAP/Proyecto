<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngreso
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
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnConsultasVentas = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.PanelAccesoSubMenu = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.PanelConsultasSubMenu = New System.Windows.Forms.Panel()
        Me.btnAcceso = New System.Windows.Forms.Button()
        Me.PanelVentasSubMenu = New System.Windows.Forms.Panel()
        Me.btnVentas2 = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelHoraFecha = New System.Windows.Forms.Panel()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarD = New System.Windows.Forms.Button()
        Me.LblSubTotalD = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoD = New System.Windows.Forms.Label()
        Me.LblTotald = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalles = New System.Windows.Forms.DataGridView()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.ChbSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblTotalArticulos = New System.Windows.Forms.Label()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarArticulosDetalle = New System.Windows.Forms.Button()
        Me.TxtBuscarArticulos = New System.Windows.Forms.TextBox()
        Me.BtnBuscarIngreso = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSerieComprobante = New System.Windows.Forms.TextBox()
        Me.TxtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.CboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProveedor = New System.Windows.Forms.Button()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.btnAlmacen = New System.Windows.Forms.Button()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnArtículos = New System.Windows.Forms.Button()
        Me.btnIngresos = New System.Windows.Forms.Button()
        Me.PanelAlmacenSubMenu = New System.Windows.Forms.Panel()
        Me.btnProvedores = New System.Windows.Forms.Button()
        Me.btnVentas1 = New System.Windows.Forms.Button()
        Me.PanelIngresoSubMenu = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbInicio = New System.Windows.Forms.PictureBox()
        Me.BtnLimpiarProveedor = New System.Windows.Forms.Button()
        Me.PanelAccesoSubMenu.SuspendLayout()
        Me.PanelConsultasSubMenu.SuspendLayout()
        Me.PanelVentasSubMenu.SuspendLayout()
        Me.PanelHoraFecha.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrarDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelAlmacenSubMenu.SuspendLayout()
        Me.PanelIngresoSubMenu.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelInicio.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogOut.Location = New System.Drawing.Point(0, 616)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(155, 44)
        Me.BtnLogOut.TabIndex = 25
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = True
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Comprobante"
        '
        'PanelHoraFecha
        '
        Me.PanelHoraFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelHoraFecha.Controls.Add(Me.TabGeneral)
        Me.PanelHoraFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHoraFecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelHoraFecha.Location = New System.Drawing.Point(155, 89)
        Me.PanelHoraFecha.Name = "PanelHoraFecha"
        Me.PanelHoraFecha.Size = New System.Drawing.Size(1165, 660)
        Me.PanelHoraFecha.TabIndex = 13
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(6, 9)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1146, 672)
        Me.TabGeneral.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.ChbSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1138, 646)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarD)
        Me.PanelMostrar.Controls.Add(Me.LblSubTotalD)
        Me.PanelMostrar.Controls.Add(Me.LblTotalImpuestoD)
        Me.PanelMostrar.Controls.Add(Me.LblTotald)
        Me.PanelMostrar.Controls.Add(Me.Label9)
        Me.PanelMostrar.Controls.Add(Me.Label10)
        Me.PanelMostrar.Controls.Add(Me.Label11)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrarDetalles)
        Me.PanelMostrar.Location = New System.Drawing.Point(356, 240)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(776, 339)
        Me.PanelMostrar.TabIndex = 29
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarD
        '
        Me.BtnCerrarD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarD.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarD.Location = New System.Drawing.Point(701, 7)
        Me.BtnCerrarD.Name = "BtnCerrarD"
        Me.BtnCerrarD.Size = New System.Drawing.Size(61, 29)
        Me.BtnCerrarD.TabIndex = 52
        Me.BtnCerrarD.Text = "X"
        Me.BtnCerrarD.UseVisualStyleBackColor = True
        '
        'LblSubTotalD
        '
        Me.LblSubTotalD.AutoSize = True
        Me.LblSubTotalD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotalD.Location = New System.Drawing.Point(594, 254)
        Me.LblSubTotalD.Name = "LblSubTotalD"
        Me.LblSubTotalD.Size = New System.Drawing.Size(25, 25)
        Me.LblSubTotalD.TabIndex = 51
        Me.LblSubTotalD.Text = "0"
        '
        'LblTotalImpuestoD
        '
        Me.LblTotalImpuestoD.AutoSize = True
        Me.LblTotalImpuestoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuestoD.Location = New System.Drawing.Point(594, 283)
        Me.LblTotalImpuestoD.Name = "LblTotalImpuestoD"
        Me.LblTotalImpuestoD.Size = New System.Drawing.Size(25, 25)
        Me.LblTotalImpuestoD.TabIndex = 50
        Me.LblTotalImpuestoD.Text = "0"
        '
        'LblTotald
        '
        Me.LblTotald.AutoSize = True
        Me.LblTotald.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotald.Location = New System.Drawing.Point(594, 310)
        Me.LblTotald.Name = "LblTotald"
        Me.LblTotald.Size = New System.Drawing.Size(25, 25)
        Me.LblTotald.TabIndex = 49
        Me.LblTotald.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 25)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Sub total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(445, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 25)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Total impuesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(445, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 25)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Total"
        '
        'DgvMostrarDetalles
        '
        Me.DgvMostrarDetalles.AllowUserToAddRows = False
        Me.DgvMostrarDetalles.AllowUserToDeleteRows = False
        Me.DgvMostrarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarDetalles.Location = New System.Drawing.Point(14, 40)
        Me.DgvMostrarDetalles.Name = "DgvMostrarDetalles"
        Me.DgvMostrarDetalles.ReadOnly = True
        Me.DgvMostrarDetalles.Size = New System.Drawing.Size(748, 204)
        Me.DgvMostrarDetalles.TabIndex = 0
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(160, 443)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(161, 38)
        Me.BtnAnular.TabIndex = 28
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
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
        Me.TxtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtValor.Location = New System.Drawing.Point(20, 23)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(754, 22)
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
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnInsertar)
        Me.TabPage2.Controls.Add(Me.TxtID)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1138, 646)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelArticulos)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarIngreso)
        Me.GroupBox2.Controls.Add(Me.TxtCodigo)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1132, 332)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'PanelArticulos
        '
        Me.PanelArticulos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelArticulos.Controls.Add(Me.BtnCerrar)
        Me.PanelArticulos.Controls.Add(Me.LblTotalArticulos)
        Me.PanelArticulos.Controls.Add(Me.DgvArticulos)
        Me.PanelArticulos.Controls.Add(Me.BtnBuscarArticulosDetalle)
        Me.PanelArticulos.Controls.Add(Me.TxtBuscarArticulos)
        Me.PanelArticulos.Location = New System.Drawing.Point(105, 57)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(1018, 263)
        Me.PanelArticulos.TabIndex = 45
        Me.PanelArticulos.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrar.Location = New System.Drawing.Point(954, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(61, 29)
        Me.BtnCerrar.TabIndex = 48
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblTotalArticulos
        '
        Me.LblTotalArticulos.AutoSize = True
        Me.LblTotalArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalArticulos.Location = New System.Drawing.Point(830, 221)
        Me.LblTotalArticulos.Name = "LblTotalArticulos"
        Me.LblTotalArticulos.Size = New System.Drawing.Size(51, 24)
        Me.LblTotalArticulos.TabIndex = 41
        Me.LblTotalArticulos.Text = "Total"
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Location = New System.Drawing.Point(7, 41)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos.Size = New System.Drawing.Size(822, 200)
        Me.DgvArticulos.TabIndex = 47
        '
        'BtnBuscarArticulosDetalle
        '
        Me.BtnBuscarArticulosDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarArticulosDetalle.Location = New System.Drawing.Point(636, 6)
        Me.BtnBuscarArticulosDetalle.Name = "BtnBuscarArticulosDetalle"
        Me.BtnBuscarArticulosDetalle.Size = New System.Drawing.Size(129, 29)
        Me.BtnBuscarArticulosDetalle.TabIndex = 46
        Me.BtnBuscarArticulosDetalle.Text = "Buscar"
        Me.BtnBuscarArticulosDetalle.UseVisualStyleBackColor = True
        '
        'TxtBuscarArticulos
        '
        Me.TxtBuscarArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarArticulos.Location = New System.Drawing.Point(3, 6)
        Me.TxtBuscarArticulos.Name = "TxtBuscarArticulos"
        Me.TxtBuscarArticulos.Size = New System.Drawing.Size(627, 22)
        Me.TxtBuscarArticulos.TabIndex = 41
        '
        'BtnBuscarIngreso
        '
        Me.BtnBuscarIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarIngreso.Location = New System.Drawing.Point(541, 22)
        Me.BtnBuscarIngreso.Name = "BtnBuscarIngreso"
        Me.BtnBuscarIngreso.Size = New System.Drawing.Size(90, 29)
        Me.BtnBuscarIngreso.TabIndex = 41
        Me.BtnBuscarIngreso.Text = "Buscar"
        Me.BtnBuscarIngreso.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(164, 23)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(371, 20)
        Me.TxtCodigo.TabIndex = 42
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(832, 296)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(168, 20)
        Me.TxtTotal.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 24)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Codigo Artículo"
        '
        'TxtTotalImpuesto
        '
        Me.TxtTotalImpuesto.Location = New System.Drawing.Point(832, 269)
        Me.TxtTotalImpuesto.Name = "TxtTotalImpuesto"
        Me.TxtTotalImpuesto.ReadOnly = True
        Me.TxtTotalImpuesto.Size = New System.Drawing.Size(168, 20)
        Me.TxtTotalImpuesto.TabIndex = 43
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(832, 240)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(168, 20)
        Me.TxtSubTotal.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(689, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Sub total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(689, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Total impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(689, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Total"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToOrderColumns = True
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(10, 57)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(927, 175)
        Me.DgvDetalle.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnLimpiarProveedor)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSerieComprobante)
        Me.GroupBox1.Controls.Add(Me.TxtNumeroComprobante)
        Me.GroupBox1.Controls.Add(Me.CboTipoComprobante)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtIdProveedor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1006, 160)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Cabecera"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(905, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 24)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "%"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.Location = New System.Drawing.Point(871, 93)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(33, 22)
        Me.TxtImpuesto.TabIndex = 40
        Me.TxtImpuesto.Text = "22"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(769, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Impuesto"
        '
        'TxtSerieComprobante
        '
        Me.TxtSerieComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerieComprobante.Location = New System.Drawing.Point(346, 91)
        Me.TxtSerieComprobante.Name = "TxtSerieComprobante"
        Me.TxtSerieComprobante.Size = New System.Drawing.Size(88, 22)
        Me.TxtSerieComprobante.TabIndex = 38
        '
        'TxtNumeroComprobante
        '
        Me.TxtNumeroComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtNumeroComprobante.Location = New System.Drawing.Point(461, 91)
        Me.TxtNumeroComprobante.Name = "TxtNumeroComprobante"
        Me.TxtNumeroComprobante.Size = New System.Drawing.Size(210, 22)
        Me.TxtNumeroComprobante.TabIndex = 37
        '
        'CboTipoComprobante
        '
        Me.CboTipoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoComprobante.FormattingEnabled = True
        Me.CboTipoComprobante.Items.AddRange(New Object() {"Facuta", "Boleta", "Ticket"})
        Me.CboTipoComprobante.Location = New System.Drawing.Point(154, 91)
        Me.CboTipoComprobante.Name = "CboTipoComprobante"
        Me.CboTipoComprobante.Size = New System.Drawing.Size(177, 24)
        Me.CboTipoComprobante.TabIndex = 36
        Me.CboTipoComprobante.Text = "Factura"
        '
        'BtnBuscarProveedor
        '
        Me.BtnBuscarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarProveedor.Location = New System.Drawing.Point(567, 26)
        Me.BtnBuscarProveedor.Name = "BtnBuscarProveedor"
        Me.BtnBuscarProveedor.Size = New System.Drawing.Size(90, 29)
        Me.BtnBuscarProveedor.TabIndex = 35
        Me.BtnBuscarProveedor.Text = "..."
        Me.BtnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(232, 31)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.ReadOnly = True
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(320, 22)
        Me.TxtNombreProveedor.TabIndex = 34
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtIdProveedor.Location = New System.Drawing.Point(140, 31)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(71, 22)
        Me.TxtIdProveedor.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Proovedor(*)"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(238, 538)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(152, 36)
        Me.BtnCancelar.TabIndex = 22
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(33, 538)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(152, 36)
        Me.BtnInsertar.TabIndex = 21
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(252, 6)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(57, 20)
        Me.TxtID.TabIndex = 20
        Me.TxtID.Visible = False
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
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
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
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 660)
        Me.Panel1.TabIndex = 11
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblEmail)
        Me.Panel2.Controls.Add(Me.LblRol)
        Me.Panel2.Controls.Add(Me.LblNombre)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1320, 89)
        Me.Panel2.TabIndex = 12
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(507, 9)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(86, 22)
        Me.LblEmail.TabIndex = 7
        Me.LblEmail.Text = "Principal"
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
        Me.Label1.Size = New System.Drawing.Size(119, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresos"
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
        'BtnLimpiarProveedor
        '
        Me.BtnLimpiarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarProveedor.Location = New System.Drawing.Point(675, 21)
        Me.BtnLimpiarProveedor.Name = "BtnLimpiarProveedor"
        Me.BtnLimpiarProveedor.Size = New System.Drawing.Size(108, 39)
        Me.BtnLimpiarProveedor.TabIndex = 43
        Me.BtnLimpiarProveedor.Text = "Limpiar"
        Me.BtnLimpiarProveedor.UseVisualStyleBackColor = True
        '
        'FormIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 749)
        Me.Controls.Add(Me.PanelHoraFecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormIngreso"
        Me.PanelAccesoSubMenu.ResumeLayout(False)
        Me.PanelConsultasSubMenu.ResumeLayout(False)
        Me.PanelVentasSubMenu.ResumeLayout(False)
        Me.PanelHoraFecha.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrarDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelArticulos.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelAlmacenSubMenu.ResumeLayout(False)
        Me.PanelIngresoSubMenu.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelInicio.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogOut As Button
    Friend WithEvents BtnConsultasVentas As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents PanelAccesoSubMenu As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnRoles As Button
    Friend WithEvents PanelConsultasSubMenu As Panel
    Friend WithEvents btnAcceso As Button
    Friend WithEvents PanelVentasSubMenu As Panel
    Friend WithEvents btnVentas2 As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelHoraFecha As Panel
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnAnular As Button
    Friend WithEvents ChbSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents btnAlmacen As Button
    Friend WithEvents btnCategorias As Button
    Friend WithEvents btnArtículos As Button
    Friend WithEvents btnIngresos As Button
    Friend WithEvents PanelAlmacenSubMenu As Panel
    Friend WithEvents btnProvedores As Button
    Friend WithEvents btnVentas1 As Button
    Friend WithEvents PanelIngresoSubMenu As Panel
    Friend WithEvents btnCompras As Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelInicio As Panel
    Friend WithEvents PbInicio As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblRol As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents CboTipoComprobante As ComboBox
    Friend WithEvents BtnBuscarProveedor As Button
    Friend WithEvents TxtSerieComprobante As TextBox
    Friend WithEvents TxtNumeroComprobante As TextBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTotalImpuesto As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscarIngreso As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents BtnBuscarArticulosDetalle As Button
    Friend WithEvents TxtBuscarArticulos As TextBox
    Friend WithEvents LblTotalArticulos As Label
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents DgvMostrarDetalles As DataGridView
    Friend WithEvents LblSubTotalD As Label
    Friend WithEvents LblTotalImpuestoD As Label
    Friend WithEvents LblTotald As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnCerrarD As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents BtnLimpiarProveedor As Button
End Class
