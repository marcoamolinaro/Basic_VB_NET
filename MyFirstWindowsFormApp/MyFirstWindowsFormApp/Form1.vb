Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddTogether.Click
        Try
            MessageBox.Show("The total is " &
                        (CDbl(FirstNumber.Text) + CDbl(SecondNumber.Text)))
        Catch ex As Exception
            MessageBox.Show("I cannot add these numbers together!")
        End Try
    End Sub
End Class
