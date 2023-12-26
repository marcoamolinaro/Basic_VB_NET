Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddTogether.Click
        Try
            MessageBox.Show("The total is " &
                        (CDbl(FirstNumber.Text) + CDbl(SecondNumber.Text)))
        Catch ex As Exception
            MessageBox.Show("I cannot add these numbers together!")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Load")
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MsgBox("Shown")
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
    End Sub
End Class
