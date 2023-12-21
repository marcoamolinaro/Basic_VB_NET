Imports System

Module Program
    Sub Main(args As String())
        ' This is my First Project
        Dim val1 As Integer = 2 ' 0,1,2,3,4, -1, -2, -3
        Dim val2 As Integer = 3
        Console.WriteLine("My numerbers are " & val1 & "and " & val2 & "!" &
                          vbCrLf & "The tatal is " & val1 + val2)

        ' You can put the expression beetwen ()
        Console.WriteLine("My numerbers are " & val1 & "and " & val2 & "!" &
                          vbCrLf & "The tatal is " & (val1 + val2))

        ' If you don't have the & at the end you need the _ to continue the "lietaral" in the following line 
        Console.WriteLine("My numerbers are " & val1 & "and " & val2 & "!" _
            & vbCrLf & "The tatal is " & val1 + val2)
    End Sub
End Module
