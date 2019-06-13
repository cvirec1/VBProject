Module Module1

    Sub Main()

        Dim edate = "20/01/1993"
        Dim expenddt As Date = Date.ParseExact(edate, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim time As TimeSpan = DateTime.Now - expenddt
        Dim rozdiel As Decimal = time.TotalSeconds / 31557600
        Console.WriteLine("Merkur " + (rozdiel / 0.2408467).ToString)
        Console.WriteLine("Venusa " + (rozdiel / 0.61519726).ToString)
        Console.WriteLine("Zem " + rozdiel.ToString)
        Console.WriteLine("Mars " + (rozdiel / 1.8808158).ToString)
        Console.WriteLine("Jupiter " + (rozdiel / 11.862615).ToString)
        Console.WriteLine("Saturn " + (rozdiel / 29.447498).ToString)
        Console.WriteLine("Uran " + (rozdiel / 84.016846).ToString)
        Console.WriteLine("Neptun " + (rozdiel / 164.79132).ToString)
        Console.ReadKey()
    End Sub

End Module
