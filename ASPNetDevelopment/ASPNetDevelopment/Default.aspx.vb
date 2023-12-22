Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")

    End Sub

    Private Sub _Default_PreInit(sender As Object, e As EventArgs) Handles Me.PreInit
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_Init(sender As Object, e As EventArgs) Handles Me.Init
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_InitComplete(sender As Object, e As EventArgs) Handles Me.InitComplete
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_PreLoad(sender As Object, e As EventArgs) Handles Me.PreLoad
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_PreRenderComplete(sender As Object, e As EventArgs) Handles Me.PreRenderComplete
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub

    Private Sub _Default_SaveStateComplete(sender As Object, e As EventArgs) Handles Me.SaveStateComplete
        Response.Write("Event: " & System.Reflection.MethodBase.GetCurrentMethod().Name & ".</br>")
    End Sub
End Class