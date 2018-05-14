Module Ej3_1

    Friend Sub fecha()
        Dim a As Date = Now
        Console.WriteLine("Fecha: " & a.Date)
    End Sub

    Friend Function hora() As Byte
        Dim a As Date = Now
        Console.WriteLine("Hora: " & a.Hour)
        Return (0)
    End Function

    Sub Main()
        fecha()
        hora()
        Console.ReadKey()
    End Sub

End Module
