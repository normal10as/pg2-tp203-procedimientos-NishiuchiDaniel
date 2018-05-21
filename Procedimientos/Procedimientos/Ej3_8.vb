Module Ej3_8
    Sub main()
        calcular()
    End Sub

    Enum operaciones As Byte
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Private Sub calcular()
        Console.WriteLine("2 + 3= " & calcular(2, 3))
        Console.WriteLine("2 + 3= " & calcular(operaciones.suma, 2, 3))
        Console.WriteLine("2 + 3 + 5= " & calcular(operaciones.suma, 2, 3, 5))
        Console.WriteLine("2 + 3 + 5 + 7= " & calcular(operaciones.suma, 2, 3, 5, 7))
        Console.WriteLine("2 - 3= " & calcular(operaciones.resta, 2, 3))
        Console.WriteLine("2 - 3 - 5= " & calcular(operaciones.resta, 2, 3, 5))
        Console.WriteLine("2 - 3 - 5 - 7= " & calcular(operaciones.resta, 2, 3, 5, 7))
        Console.WriteLine("2 * 3= " & calcular(operaciones.multiplicacion, 2, 3))
        Console.WriteLine("2 * 3 * 5= " & calcular(operaciones.multiplicacion, 2, 3, 5))
        Console.WriteLine("2 * 3 * 5 * 7= " & calcular(operaciones.multiplicacion, 2, 3, 5, 7))
        Console.WriteLine("2 / 3= " & calcular(operaciones.division, 2, 3))
        Console.WriteLine("2 / 3 / 5= " & calcular(operaciones.division, 2, 3, 5))
        Console.WriteLine("2 / 3 / 5 / 7= " & calcular(operaciones.division, 2, 3, 5, 7))
        Console.ReadKey()
    End Sub

    Private Function calcular(ByVal operacion As Byte, ByVal a As Double, ByVal b As Double) As Double
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

    Private Function calcular(ByVal operacion As Byte, ByVal a As Double, ByVal b As Double, ByVal c As Double) As Double
        Return calcular(operacion, calcular(operacion, a, b), c)
    End Function

    Private Function calcular(ByVal operacion As Byte, ByVal a As Double, ByVal b As Double, ByVal c As Double, ByVal d As Double) As Double
        Return calcular(operacion, calcular(operacion, a, b), calcular(operacion, c, d))
    End Function

    Private Function calcular(ByVal a As Double, ByVal b As Double)
        Return calcular(1, a, b)
    End Function
End Module
