Imports System.Runtime.InteropServices

Public Class FormLogin

#Region "Botones superiores"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Arrastrar"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "Personalizar controles"
    Private Sub CustomizeComponents()
        'TxtEmail
        TxtEmail.AutoSize = False
        TxtEmail.Size = New Size(320, 35)

        'TxtClave
        TxtClave.AutoSize = False
        TxtClave.Size = New Size(320, 35)
        TxtClave.UseSystemPasswordChar = True
    End Sub
#End Region

#Region "Llamada exigida por el diseñador"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub
#End Region

#Region "Limpiar"
    Private Sub Limpiar()
        TxtEmail.Text = ""
        TxtClave.Text = ""
    End Sub
#End Region

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtEmail.Text = "" Or TxtClave.Text = "" Then
            MsgBox("Debe colocar Email y Clave correspondiente", vbOKOnly + vbCritical, "Falta ingresar datos")
        Else

            Try
                Dim Email As String, Clave As String
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.NUsuario
                Email = TxtEmail.Text.Trim()
                Clave = TxtClave.Text.Trim()
                Obj = Neg.Login(Email, Clave)
                If (Obj Is Nothing) Then
                    Me.Limpiar()
                    MsgBox("No existe un usuario con esos datos", vbOKOnly + vbCritical, "Datos incorrectos")
                Else
                    If (Obj.Estado = False) Then
                        Me.Limpiar()
                        MsgBox("El usuario no esta activo y no tiene acceso", vbOKOnly + vbCritical, "Sin accseso")
                    Else
                        Me.Hide()
                        FormPrincipal.IdUsuario = Obj.IdUsuario
                        Variables.IdUsuario = Obj.IdUsuario
                        FormPrincipal.IdRol = Obj.IdRol
                        FormPrincipal.Rol = Obj.Rol
                        FormPrincipal.Nombre = Obj.Nombre
                        FormPrincipal.Show()
                        Me.Limpiar()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEmail.Text = "mendezbernardo24@gmail.com"
        TxtClave.Text = "56035895"
    End Sub
End Class