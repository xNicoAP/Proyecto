Imports System.Data.SqlClient
Public Class Conexion
    Public conn As SqlConnection

    Public Sub New()
        Me.conn = New SqlConnection("Data Source=DESKTOP-QGVN1Q9;Initial Catalog=dbsistema;User ID=sa;Password=56035895")
    End Sub
End Class