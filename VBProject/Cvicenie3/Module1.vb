Module Module1

    Sub Main()
        Console.WriteLine("Select Start Date")
        Dim start As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Select End Date")
        Dim endDate As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("****************************")
        'Dim expenddt As Date = Date.ParseExact(edate, "yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        For index = start To endDate
            If (Date.IsLeapYear(index)) Then
                Console.WriteLine(index)
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
