Module Ej3_3


    Friend Function Potencia(ByVal a, ByVal i) As Integer

        Return (Math.Pow(a, i))
    End Function


    Sub main()
        Dim a As Decimal
        Dim resultado As Decimal

        Console.Write("Ingrese valor: ")
        a = Console.ReadLine()

        For i As Byte = 2 To 6
            resultado = Potencia(a, i)
            Console.WriteLine("La potencia de {0} a la {1} es {2}", a, i, resultado)
        Next
        Console.ReadKey()


    End Sub
End Module
