Module Module1

    Sub Main()
        Console.WriteLine("Select  1 number")
        Dim select1Number As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Select  2 number")
        Dim select2Number As Integer = Convert.ToInt32(Console.ReadLine())
        Dim delitel As Integer = 1
        For index = 1 To select1Number
            If (select1Number Mod index = 0 AndAlso select2Number Mod index = 0) Then
                delitel = index

            End If
        Next
        Console.WriteLine(delitel)
        Console.ReadKey()
    End Sub

End Module
