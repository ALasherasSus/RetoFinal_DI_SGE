Imports System.Data.OleDb

Public Class Filtrar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
            Dim conexion As New OleDbConnection(stringconexion)
            Dim SQL As String = "SELECT DISTINCT Country FROM [Customers];"

            Dim adap1 As New OleDbDataAdapter(SQL, conexion)
            Dim das1 As New DataSet
            Dim contador As Integer

            Try
                contador = adap1.Fill(das1, "tabla")
                Me.DropDownList1.DataSource = das1.Tables(0)
                Me.DropDownList1.DataTextField = "Country"
                Me.DropDownList1.DataBind()
            Catch ex As Exception
                'Me.LabelContador.Text = ex.Message
            End Try
            cargarCiudad()
        End If
    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        cargarCiudad()
    End Sub

    Private Sub cargarCiudad()
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)
        Dim SQL As String = "SELECT DISTINCT City FROM [Customers] WHERE Country = '" & Me.DropDownList1.SelectedValue & "';"

        Dim adap1 As New OleDbDataAdapter(SQL, conexion)
        Dim das1 As New DataSet
        Dim contador As Integer

        Try
            contador = adap1.Fill(das1, "tabla")
            Me.DropDownList2.DataSource = das1.Tables(0)
            Me.DropDownList2.DataTextField = "City"
            Me.DropDownList2.DataBind()
        Catch ex As Exception
            'Me.LabelContador.Text = ex.Message
        End Try
        cargarTabla()
    End Sub

    Private Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        cargarTabla()
    End Sub

    Private Sub cargarTabla()
        Dim stringconexion As String =
            ConfigurationManager.ConnectionStrings("ELORRIETA").ConnectionString
        Dim conexion As New OleDbConnection(stringconexion)
        Dim SQL As String = "SELECT CustomerID, CompanyName, City, Country FROM [Customers] WHERE City = '" & Me.DropDownList2.SelectedValue & "' AND Country = '" & Me.DropDownList1.SelectedValue & "';"

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

    Private Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        cargarTextBoxes()
    End Sub

    Private Sub cargarTextBoxes()
        TextBoxCity.Text = HttpUtility.HtmlDecode(GridView1.SelectedRow.Cells(3).Text)
        TextBoxCountry.Text = HttpUtility.HtmlDecode(GridView1.SelectedRow.Cells(4).Text)
        TextBoxCompanyName.Text = HttpUtility.HtmlDecode(GridView1.SelectedRow.Cells(2).Text)
    End Sub
End Class