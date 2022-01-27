Imports System.Data.OleDb

Public Class BorrarRegistros
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)
        Dim SQL As String = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice FROM Products WHERE ProductID = " & TextBoxBuscar.Text & ";"

        Dim adap1 As New OleDbDataAdapter(SQL, conexion)
        Dim das1 As New DataSet
        Dim contador As Integer

        Try
            contador = adap1.Fill(das1, "tabla")
            Me.GridView1.DataSource = das1.Tables(0)
            Me.GridView1.DataBind()
        Catch ex As Exception
            'Me.LabelContador.Text = ex.Message
        End Try
    End Sub

    Protected Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)

        If (IsNumeric(TextBoxBuscar.Text)) Then
            Try
                conexion.Open()
                Dim SQL As String = "DELETE FROM Products WHERE ProductID=" & TextBoxBuscar.Text & ";"
                Dim command As New OleDbCommand(SQL, conexion)
                Dim contador As Double = command.ExecuteNonQuery

                MsgBox("Fila borrada correctamente.")
            Catch ex As Exception
                MsgBox("Fallo al borrar la fila. Compruebe los campos.")
            End Try
        End If
    End Sub
End Class