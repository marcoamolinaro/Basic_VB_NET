Imports System

Module Program
    Sub Main(args As String())
        ' If you declar fraction integer its will be arrounded up
        Dim val1 As Integer = 2.5
        Dim val2 As Integer = 3.5
        Console.WriteLine("My numerbers are " & val1 & " and " & val2 & "!" &
                          vbCrLf & "The tatal is " & val1 + val2)

        ' So you need to user double for example
        Dim val3 As Double = 2.5
        Dim val4 As Double = 3.5
        Console.WriteLine("My numerbers are " & val3 & " and " & val4 & "!" &
                          vbCrLf & "The tatal is " & val3 + val4)
    End Sub
End Module

' Byte  0 to 255                            (3 digits)      - 1 byte
' Short -32,768 to +32,768                  (5 digits)      - 2 bytes
' UShort 0 to +65,535
' Integer -2 billion to +2 billion          (10 digits)     - 4 bytes
' Long  -9 quintillion to +9 quintillion    (19 digits)     - 8 bytes
' BaSIL LISB
