Module Ej3_2
    Sub main()
        Dim a As Date
        Dim b As Byte
        Dim c As Date
        Console.Write("Ingrese fecha: ")
        a = Console.ReadLine()
        Console.Write("Ingrese dias a sumar: ")
        b = Console.ReadLine()
        c = FechaSumada(a, b)
        Console.WriteLine("Fecha Actual: " & a)
        Console.WriteLine("Resultado: " & c)
        Console.ReadKey()

    End Sub

    Friend Function FechaSumada(ByRef fecha As Date, ByRef dias As Byte) As Date
        Dim listo As Date
        listo = fecha.AddDays(dias)
        Return (listo)
    End Function
End Module
