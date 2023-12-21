Imports System

Module Program
    Sub Main(args As String())
        Dim Mood As String = "Sad"
        Dim TypeOfActitity As String = "Serious"

        If Mood = "Happy" And TypeOfActitity = "Fun" Then
            Console.WriteLine("I am " & Mood & " :-) And the Activity Is " & TypeOfActitity)
        ElseIf Mood = "Sad" And TypeOfActitity = "Serious" Then
            Console.WriteLine("I am " & Mood & " :-) And the Activity Is " & TypeOfActitity)
        Else
            Console.WriteLine("I am not in the mood for this activity.")
        End If

        If Mood = "Happy" Or TypeOfActitity = "Fun" Then
            Console.WriteLine("Either I am happy, or this activity is fun - or both!")
        End If

        Select Case Mood & "/" & TypeOfActitity
            Case "Happy/Fun", "Sad/Serious"
                Console.WriteLine("Let's do it.")
            Case "Happy/Serious"
                Console.WriteLine("Can you do something more fun?")
            Case "Sad/Fun"
                Console.WriteLine("Can you do it later?")
            Case Else
                Console.WriteLine("This seems a error")

        End Select


    End Sub
End Module
