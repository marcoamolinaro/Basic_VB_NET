Imports System

Module Program
    Sub Main(args As String())
        Dim val1 As Integer = 30
        Dim val2 As Double = 4

        'While val1 <= 20
        '    If val1 = 10 Then
        '        Exit While
        '    End If
        '    Console.WriteLine(val1 & " modulus " & val2 & " is " & (val1 Mod val2) & ".")
        '    val1 += 1
        'End While

        'Do
        '    If val1 = 10 Then
        '        Exit Do
        '    End If
        '    Console.WriteLine(val1 & " modulus " & val2 & " is " & (val1 Mod val2) & ".")
        '    val1 += 1
        'Loop While val1 <= 20

        Do
            If val1 = 100 Then
                Exit Do
            End If
            Console.WriteLine(val1 & " modulus " & val2 & " is " & (val1 Mod val2) & ".")
            val1 += 1
        Loop Until val1 <= 20
    End Sub
End Module

