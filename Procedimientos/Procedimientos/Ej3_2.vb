Module Ej3_2
    Friend Function FechaSumada(ByRef fecha, ByRef dias) As Date
        Dim listo As Date
        listo = fecha.adddays(dias)

        Return (listo)
    End Function

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

End Module
