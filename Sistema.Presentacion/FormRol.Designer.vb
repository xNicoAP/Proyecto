<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelHoraFecha = New System.Windows.Forms.Panel()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblTotalRoles = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
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
        Me.PbInicio = New System.Windows.Forms.PictureBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.PanelHoraFecha.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelConsultasSubMenu.SuspendLayout()
        Me.PanelAccesoSubMenu.SuspendLayout()
        Me.PanelVentasSubMenu.SuspendLayout()
        Me.PanelIngresoSubMenu.SuspendLayout()
        Me.PanelAlmacenSubMenu.SuspendLayout()
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHoraFecha
        '
        Me.PanelHoraFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelHoraFecha.Controls.Add(Me.TabGeneral)
        Me.PanelHoraFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHoraFecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelHoraFecha.Location = New System.Drawing.Point(155, 89)
        Me.PanelHoraFecha.Name = "PanelHoraFecha"
        Me.PanelHoraFecha.Size = New System.Drawing.Size(1009, 536)
        Me.PanelHoraFecha.TabIndex = 10
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Location = New System.Drawing.Point(6, 6)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(991, 518)
        Me.TabGeneral.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblTotalRoles)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(983, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblTotalRoles
        '
        Me.LblTotalRoles.AutoSize = True
        Me.LblTotalRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalRoles.Location = New System.Drawing.Point(567, 385)
        Me.LblTotalRoles.Name = "LblTotalRoles"
        Me.LblTotalRoles.Size = New System.Drawing.Size(60, 25)
        Me.LblTotalRoles.TabIndex = 4
        Me.LblTotalRoles.Text = "Total"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(735, 447)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(0, 25)
        Me.LblTotal.TabIndex = 1
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Location = New System.Drawing.Point(20, 21)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(657, 324)
        Me.DgvListado.TabIndex = 0
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 536)
        Me.Panel1.TabIndex = 8
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogOut.Location = New System.Drawing.Point(0, 492)
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
        Me.PanelConsultasSubMenu.Location = New System.Drawing.Point(0, 429)
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
        Me.btnConsultas.Location = New System.Drawing.Point(0, 394)
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
        Me.PanelAccesoSubMenu.Location = New System.Drawing.Point(0, 338)
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
        Me.btnAcceso.Location = New System.Drawing.Point(0, 305)
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
        Me.PanelVentasSubMenu.Location = New System.Drawing.Point(0, 249)
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
        Me.btnVentas1.Location = New System.Drawing.Point(0, 205)
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
        Me.PanelIngresoSubMenu.Location = New System.Drawing.Point(0, 149)
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
        Me.btnIngresos.Location = New System.Drawing.Point(0, 105)
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
        Me.PanelAlmacenSubMenu.Location = New System.Drawing.Point(0, 49)
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
        Me.btnAlmacen.Location = New System.Drawing.Point(0, 0)
        Me.btnAlmacen.Name = "btnAlmacen"
        Me.btnAlmacen.Size = New System.Drawing.Size(155, 49)
        Me.btnAlmacen.TabIndex = 15
        Me.btnAlmacen.Text = "Almacen"
        Me.btnAlmacen.UseVisualStyleBackColor = True
        '
        'PbInicio
        '
        Me.PbInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbInicio.Image = Global.Sistema.Presentacion.My.Resources.Resources.Startupfolder_11173
        Me.PbInicio.Location = New System.Drawing.Point(3, 6)
        Me.PbInicio.Name = "PbInicio"
        Me.PbInicio.Size = New System.Drawing.Size(152, 83)
        Me.PbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbInicio.TabIndex = 0
        Me.PbInicio.TabStop = False
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(179, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roles"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblEmail)
        Me.Panel2.Controls.Add(Me.LblRol)
        Me.Panel2.Controls.Add(Me.LblNombre)
        Me.Panel2.Controls.Add(Me.PbInicio)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1164, 89)
        Me.Panel2.TabIndex = 9
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblRol.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRol.ForeColor = System.Drawing.Color.White
        Me.LblRol.Location = New System.Drawing.Point(294, 49)
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
        Me.LblNombre.Location = New System.Drawing.Point(294, 9)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(86, 22)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Principal"
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(694, 9)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(86, 22)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "Principal"
        '
        'FormRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 625)
        Me.Controls.Add(Me.PanelHoraFecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormRol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRol"
        Me.PanelHoraFecha.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelConsultasSubMenu.ResumeLayout(False)
        Me.PanelAccesoSubMenu.ResumeLayout(False)
        Me.PanelVentasSubMenu.ResumeLayout(False)
        Me.PanelIngresoSubMenu.ResumeLayout(False)
        Me.PanelAlmacenSubMenu.ResumeLayout(False)
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelHoraFecha As Panel
    Friend WithEvents TabGeneral As TabControl
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
    Friend WithEvents PbInicio As PictureBox
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents LblTotalRoles As Label
    Friend WithEvents LblRol As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblEmail As Label
End Class
