Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim myweb = New webs.MyWebService
        Response.Write(myweb.HelloWorld)
        Response.Write(myweb.AddUp(3, 5))
    End Sub
End Class