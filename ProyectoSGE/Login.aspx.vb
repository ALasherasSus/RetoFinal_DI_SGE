Imports System.Data.OleDb

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.FindControl("Menu1").Visible = False
    End Sub

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)

        Dim sentencia As String = " SELECT * FROM employees WHERE FirstName='Nancy' And LastName='Davolio'"

        Dim dr As OleDbDataReader
        Dim comando As New OleDbCommand(sentencia, conexion)
        Try
            conexion.Open()
            dr = comando.ExecuteReader
            If dr.HasRows Then
                Response.Redirect("VerProductos.aspx")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            conexion.Close()
        End Try
    End Sub
End Class