Imports System

Module Program
    Sub Main(args As String())
        Dim val1 As Integer
        Dim val2 As Double = 4

        'For val1 = 1 To 20
        '    Console.WriteLine(val1 & " modulus " & val2 & " is " & (val1 Mod val2) & ".")
        'Next

        'Console.WriteLine("The value for val1 is " & val1)

        'For val1 = 30 To 20 Step -1
        '    Console.WriteLine(val1 & " modulus " & val2 & " is " & (val1 Mod val2) & ".")
        'Next

        'For val3 As Double = 1 To 20 Step 0.1
        '    Console.WriteLine(val3 & " modulus " & val2 & " is " & (val3 Mod val2) & ".")
        'Next

        'For val3 As Decimal = 1 To 20 Step 1
        '    Select Case val3
        '        Case 10
        '        Case Else
        '            Console.WriteLine(val3 & " The modulus " & val2 & " is " & (val3 Mod val2) & ".")
        '    End Select
        'Next

        For val3 As Decimal = 1 To 20 Step 1
            If val3 = 10 Then
                Continue For
            End If

            Console.WriteLine(val3 & " The modulus " & val2 & " is " & (val3 Mod val2) & ".")
        Next

        For val3 As Decimal = 1 To 20 Step 1
            If val3 = 10 Then
                Exit For
            End If

            Console.WriteLine(val3 & " The modulus " & val2 & " is " & (val3 Mod val2) & ".")
        Next
    End Sub
End Module

