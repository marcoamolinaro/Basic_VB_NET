Imports System

Module Program
    Sub Main(args As String())
        Dim val1 As Integer = 30
        Dim val2 As Double = 4
        Dim userInput As String
        Console.Write("Enter a number ")
        userInput = Console.ReadLine()
        Try
            val2 = CDbl(userInput)
            Console.WriteLine("Soma " & (val1 + val2))
        Catch ex As FormatException
            Console.WriteLine("There is an error format exceptions")
        Catch ex As Exception
            Console.WriteLine("There is an error with the input")
        Finally
            Console.WriteLine("This is the end")
        End Try
    End Sub
End Module

