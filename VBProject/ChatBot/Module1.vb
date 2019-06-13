Module Module1

    Sub Main()
        Dim quit As Boolean = True
        Dim random As Random = New Random
        Dim counter As Int32
        Dim countInput As Integer = 0

        Console.WriteLine("Hlucha babka")
        While (quit)
            Console.WriteLine("ZADAJ OTAZKU")
            Dim question As String = Console.ReadLine()
            Select Case True
                Case question.ToUpper Is question, question.Last = "?"
                    Console.WriteLine("NECHALA SOM TI ICH NA STOLE")
                Case question.ToUpper Is question AndAlso (question.Last <> "?")
                    Console.WriteLine("NIE, NAPOSLEDY V ROKU " + random.Next(1900, 2100).ToString)
                Case question = "AHOJ"
                    counter = random.Next(1, 10)
                    If countInput = 3 Then
                        quit = False
                    ElseIf counter = 1 Then
                        quit = False
                    End If
                    countInput = countInput + 1
                Case Else
                    Console.WriteLine("CO HOVOR HLASNEJSIE")


            End Select
        End While
        Console.ReadKey()

    End Sub

End Module
