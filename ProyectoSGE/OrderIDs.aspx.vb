Imports System.Data.OleDb

Public Class OrderIDs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
            Dim conexion As New OleDbConnection(stringconexion)
            Dim SQL As String = "SELECT DISTINCT OrderID FROM [Order Details];"

            Dim adap1 As New OleDbDataAdapter(SQL, conexion)
            Dim das1 As New DataSet
            Dim contador As Integer

            Try
                contador = adap1.Fill(das1, "tabla")
                Me.DropDownList1.DataSource = das1.Tables(0)
                Me.DropDownList1.DataTextField = "OrderId"
                Me.DropDownList1.DataBind()
            Catch ex As Exception
                'Me.LabelContador.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)
        Dim SQL As String = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE OrderID = " & Me.DropDownList1.SelectedValue & ";"

        Dim adap1 As New OleDbDataAdapter(SQL, conexion)
        Dim das1 As New DataSet
        Dim contador As Integer

        Try
            contador = adap1.Fill(das1, "tabla")
            Me.LabelFilas.Text = contador & " filas."
            Me.GridView1.DataSource = das1.Tables(0)
            Me.GridView1.DataBind()
            total()
        Catch ex As Exception
            'Me.LabelContador.Text = ex.Message
        End Try
    End Sub

    Protected Sub total()
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)
        Dim SQL As String = "SELECT sum(UnitPrice * Quantity * (1 - Discount)) FROM [Order Details] WHERE OrderID = " & Me.DropDownList1.SelectedValue & ";"

        Dim adap1 As New OleDbDataAdapter(SQL, conexion)
        Dim das1 As New DataSet
        Dim contador As Integer

        Try
            contador = adap1.Fill(das1, "tabla")
            Dim dinero As Double = das1.Tables(0).Rows(0)(0).ToString
            Me.LabelTotal.Text = "El total es: " & dinero.ToString("C")
        Catch ex As Exception
            'Me.LabelContador.Text = ex.Message
        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        TextBox1.Text = GridView1.SelectedRow.Cells(1).Text
        TextBox2.Text = GridView1.SelectedRow.Cells(2).Text
    End Sub
End Class