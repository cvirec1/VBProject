Module Module1

    Sub Main()
        Console.WriteLine("First word")
        Dim word1 As String = Console.ReadLine()
        Console.WriteLine("Second word")
        Dim word2 As String = Console.ReadLine()
        Dim test As Boolean() = word1.Select(Function(x) word2.Contains(x)).ToArray()
        If test.Contains(False) Then
            Console.WriteLine("Nie je presmycka")
        Else
            Console.WriteLine("Je presmycka")
        End If

        Console.ReadKey()


    End Sub

End Module
