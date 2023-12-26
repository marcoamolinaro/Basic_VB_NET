Public Class Form1
    Private Sub BThis_Click(sender As Object, e As EventArgs) Handles BThis.Click
        MyText.Text = MyText.Text & "This "
    End Sub

    Private Sub BIs_Click(sender As Object, e As EventArgs) Handles BIs.Click
        MyText.Text = MyText.Text & "is "
    End Sub

    Private Sub BMy_Click(sender As Object, e As EventArgs) Handles BMy.Click
        MyText.Text = MyText.Text & "my "
    End Sub

    Private Sub BProgram_Click(sender As Object, e As EventArgs) Handles BProgram.Click
        MyText.Text = MyText.Text & "program. "
    End Sub
End Class
