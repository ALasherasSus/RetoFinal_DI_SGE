Imports System.Data.OleDb

Public Class AnadirRegistros
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)

        If (TextBoxProductName.Text.Length > 0 And TextBoxQuantityPerUnit.Text.Length > 0 And TextBoxUnitPrice.Text.Length > 0) Then
            Try
                conexion.Open()
                Dim SQL As String = "INSERT INTO Products (ProductName, QuantityPerUnit, UnitPrice) VALUES ('" & TextBoxProductName.Text & "', '" & TextBoxQuantityPerUnit.Text & "', " & TextBoxUnitPrice.Text & ");"
                Dim command As New OleDbCommand(SQL, conexion)
                Dim contador As Double = command.ExecuteNonQuery

                MsgBox("Fila insertada correctamente.")
            Catch ex As Exception
                MsgBox("Fallo al insertar la fila. Compruebe los campos.")
            End Try
        End If
    End Sub
End Class