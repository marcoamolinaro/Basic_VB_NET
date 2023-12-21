Imports System

Module Program
    Sub Main(args As String())

        Dim val5 As Boolean = True
        Console.WriteLine("The value is " & val5)
        Dim val6 As Boolean
        Console.WriteLine("The value is " & val6)

        Dim val7 As String = "This is my String"
        Console.WriteLine("The value is " & val7)

        val7 &= " And this is appended String"
        Console.WriteLine("The value is " & val7)

        Dim val8 As Char = "A"c
        Console.WriteLine("The value is char " & val8)

        Dim val9 As Date = #2023/11/22#
        Console.WriteLine("The value is a Date " & val9)

        val9 = #2023/11/22 17:15:00#
        Console.WriteLine("The value is a Date " & val9)



    End Sub
End Module

