﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedor
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
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChbSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumDocumento = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.PbInicio = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.PanelHoraFecha = New System.Windows.Forms.Panel()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnProvedores = New System.Windows.Forms.Button()
        Me.PanelIngresoSubMenu = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnIngresos = New System.Windows.Forms.Button()
        Me.PanelAlmacenSubMenu = New System.Windows.Forms.Panel()
        Me.btnArtículos = New System.Windows.Forms.Button()
        Me.btnAlmacen = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PanelConsultasSubMenu.SuspendLayout()
        Me.PanelAccesoSubMenu.SuspendLayout()
        Me.PanelVentasSubMenu.SuspendLayout()
        Me.PanelInicio.SuspendLayout()
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelHoraFecha.SuspendLayout()
        Me.PanelIngresoSubMenu.SuspendLayout()
        Me.PanelAlmacenSubMenu.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(3, 98)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(991, 515)
        Me.TabGeneral.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.ChbSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(983, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ChbSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbSeleccionar.Location = New System.Drawing.Point(11, 452)
        Me.ChbSeleccionar.Name = "ChbSeleccionar"
        Me.ChbSeleccionar.Size = New System.Drawing.Size(99, 20)
        Me.ChbSeleccionar.TabIndex = 25
        Me.ChbSeleccionar.Text = "Seleccionar"
        Me.ChbSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(731, 10)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(208, 45)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(20, 23)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(657, 22)
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
        Me.DgvListado.Size = New System.Drawing.Size(941, 357)
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
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TxtNumDocumento)
        Me.TabPage2.Controls.Add(Me.TxtEmail)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TxtTelefono)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtDireccion)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.CboTipoDocumento)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnInsertar)
        Me.TabPage2.Controls.Add(Me.TxtID)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(983, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 24)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Numero Documento"
        '
        'TxtNumDocumento
        '
        Me.TxtNumDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtNumDocumento.Location = New System.Drawing.Point(207, 154)
        Me.TxtNumDocumento.Name = "TxtNumDocumento"
        Me.TxtNumDocumento.Size = New System.Drawing.Size(252, 22)
        Me.TxtNumDocumento.TabIndex = 46
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtEmail.Location = New System.Drawing.Point(207, 319)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(252, 22)
        Me.TxtEmail.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Email"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtTelefono.Location = New System.Drawing.Point(207, 266)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(182, 22)
        Me.TxtTelefono.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Dirección"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtDireccion.Location = New System.Drawing.Point(207, 210)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(252, 22)
        Me.TxtDireccion.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Telefono"
        '
        'CboTipoDocumento
        '
        Me.CboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CboTipoDocumento.FormattingEnabled = True
        Me.CboTipoDocumento.Items.AddRange(New Object() {"DNI", "PASAPORTE", "CREDENCIAL", "RUT", "CEDULA"})
        Me.CboTipoDocumento.Location = New System.Drawing.Point(207, 98)
        Me.CboTipoDocumento.Name = "CboTipoDocumento"
        Me.CboTipoDocumento.Size = New System.Drawing.Size(182, 24)
        Me.CboTipoDocumento.TabIndex = 39
        Me.CboTipoDocumento.Text = "CEDULA"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(40, 410)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(210, 45)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(277, 410)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(210, 45)
        Me.BtnCancelar.TabIndex = 22
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(40, 410)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(210, 45)
        Me.BtnInsertar.TabIndex = 21
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(207, 3)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(57, 20)
        Me.TxtID.TabIndex = 20
        Me.TxtID.Visible = False
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(208, 42)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(402, 22)
        Me.TxtNombre.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo de Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre(*)"
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
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.PbInicio)
        Me.PanelInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInicio.Location = New System.Drawing.Point(0, 0)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(155, 89)
        Me.PanelInicio.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedores"
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
        Me.Panel2.Size = New System.Drawing.Size(1009, 89)
        Me.Panel2.TabIndex = 9
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblRol.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRol.ForeColor = System.Drawing.Color.White
        Me.LblRol.Location = New System.Drawing.Point(219, 49)
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
        Me.LblNombre.Location = New System.Drawing.Point(219, 9)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(86, 22)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Principal"
        '
        'PanelHoraFecha
        '
        Me.PanelHoraFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelHoraFecha.Controls.Add(Me.TabGeneral)
        Me.PanelHoraFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHoraFecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelHoraFecha.Location = New System.Drawing.Point(155, 0)
        Me.PanelHoraFecha.Name = "PanelHoraFecha"
        Me.PanelHoraFecha.Size = New System.Drawing.Size(1009, 625)
        Me.PanelHoraFecha.TabIndex = 10
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 625)
        Me.Panel1.TabIndex = 8
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(547, 9)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(86, 22)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "Principal"
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 625)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelHoraFecha)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProveedor"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.PanelConsultasSubMenu.ResumeLayout(False)
        Me.PanelAccesoSubMenu.ResumeLayout(False)
        Me.PanelVentasSubMenu.ResumeLayout(False)
        Me.PanelInicio.ResumeLayout(False)
        CType(Me.PbInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelHoraFecha.ResumeLayout(False)
        Me.PanelIngresoSubMenu.ResumeLayout(False)
        Me.PanelAlmacenSubMenu.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChbSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents PbInicio As PictureBox
    Friend WithEvents btnVentas1 As Button
    Friend WithEvents PanelInicio As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblRol As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents PanelHoraFecha As Panel
    Friend WithEvents btnCategorias As Button
    Friend WithEvents btnProvedores As Button
    Friend WithEvents PanelIngresoSubMenu As Panel
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnIngresos As Button
    Friend WithEvents PanelAlmacenSubMenu As Panel
    Friend WithEvents btnArtículos As Button
    Friend WithEvents btnAlmacen As Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents CboTipoDocumento As ComboBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumDocumento As TextBox
    Friend WithEvents LblEmail As Label
End Class
