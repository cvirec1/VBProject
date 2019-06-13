Module Module1

    Sub Main()
        Console.WriteLine("Select number")
        Dim selectNumber As Integer = Convert.ToInt32(Console.ReadLine())
        For index = 1 To selectNumber
            If (selectNumber Mod index = 0) Then
                Console.WriteLine(index)

            End If
        Next
        Console.ReadKey()
    End Sub

End Module
