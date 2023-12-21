Module Module1

    Sub Main()
        Dim UserInput As String
        Dim RunningTotal As Double = 1
        Do
            Console.Write("Please enter your number ")
            UserInput = Console.ReadLine()
            If UserInput = "0 " Then
                Exit Do
            End If
            RunningTotal *= UserInput
        Loop Until UserInput <> "0"
        Console.Write("Your answer is ")
        Console.WriteLine(RunningTotal)
    End Sub

End Module
