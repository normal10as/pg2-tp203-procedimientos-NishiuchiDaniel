Module Ej3_7
    Sub main()
        Console.WriteLine(calcular(2, 3))
        Console.WriteLine(calcular(operaciones.suma, 2, 3))
        Console.WriteLine(calcular(operaciones.suma, 2, 3, 5))
        Console.WriteLine(calcular(operaciones.suma, 2, 3, 5, 7))
        Console.WriteLine(calcular(operaciones.resta, 2, 3))
        Console.WriteLine(calcular(operaciones.resta, 2, 3, 5))
        Console.WriteLine(calcular(operaciones.resta, 2, 3, 5, 7))
        Console.WriteLine(calcular(operaciones.multiplicacion, 2, 3))
        Console.WriteLine(calcular(operaciones.multiplicacion, 2, 3, 5))
        Console.WriteLine(calcular(operaciones.multiplicacion, 2, 3, 5, 7))
        Console.WriteLine(calcular(operaciones.division, 2, 3))
        Console.WriteLine(calcular(operaciones.division, 2, 3, 5))
        Console.WriteLine(calcular(operaciones.division, 2, 3, 5, 7))
        Console.ReadKey()
    End Sub

    Enum operaciones As Byte
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Friend Function calcular(operacion, a, b) As Double
        Dim x As Double
        Select Case operacion
            Case 1
                x = a + b
            Case 2
                x = a - b
            Case 3
                x = a * b
            Case 4
                x = a / b
        End Select
        Return x
    End Function

    Friend Function calcular(operacion, a, b, c) As Double
        Return calcular(operacion, calcular(operacion, a, b), c)
    End Function

    Friend Function calcular(operacion, a, b, c, d) As Double
        Return calcular(operacion, calcular(operacion, a, b), calcular(operacion, c, d))
    End Function

    Friend Function calcular(a, b)
        Return calcular(1, a, b)
    End Function
End Module
