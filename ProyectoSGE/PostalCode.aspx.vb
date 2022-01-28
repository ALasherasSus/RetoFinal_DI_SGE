Public Class PostalCode
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        For Each x In e.Row.Cells
            Dim i As TableCell = x
            i.BackColor = Drawing.Color.Transparent
        Next
        Try
            Dim postal As Integer = CInt(e.Row.Cells(4).Text)

            If postal Mod 2 = 0 Then
                e.Row.BackColor = Drawing.Color.LightGreen
            Else
                e.Row.BackColor = Drawing.Color.Pink
            End If
        Catch ex As Exception
            If e.Row.RowIndex <> -1 Then
                e.Row.BackColor = Drawing.Color.Green
            End If
        End Try
    End Sub

End Class