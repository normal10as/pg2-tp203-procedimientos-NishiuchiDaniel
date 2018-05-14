Module Ej3_4

    Friend Function Comprobar(ByVal b)
        Dim a As Integer = 0
        While a <= 0
            Console.Write(b)
            a = Console.ReadLine()
            If a <= 0 Then
                Console.WriteLine("El valor ingresado debe ser entero positivo")
            End If
        End While
        Return (a)
    End Function

    Friend Function Hipotenusa(ByVal a, ByVal b)
        Return (Math.Sqrt(a ^ 2 + b ^ 2))
    End Function

    Sub main()
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer
        a = Comprobar("Ingrese lado A: ")
        b = Comprobar("Ingrese lado B: ")
        c = Hipotenusa(a, b)
        Console.WriteLine("La hipotenusa es: " & c)
        Console.ReadKey()

    End Sub
End Module
