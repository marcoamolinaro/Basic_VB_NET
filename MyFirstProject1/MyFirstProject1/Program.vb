Imports System

Module Program
    Sub Main(args As String())
        Dim val1 As Integer = 30
        Dim val2 As Double = 4
        Dim userInput As String
        Console.Write("Enter a number ")
        userInput = Console.ReadLine()
        Console.WriteLine(userInput)
        val2 = CDbl(userInput)
        Console.WriteLine("Soma " & (val1 + val2))
    End Sub
End Module

