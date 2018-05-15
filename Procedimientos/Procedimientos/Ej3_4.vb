Module Ej3_4
    Sub main()
        Dim a As UInt32 = 0
        Dim b As UInt32 = 0
        Dim c As UInt32
        a = comprobar("Ingrese lado A: ")
        b = comprobar("Ingrese lado B: ")
        c = Hipotenusa(a, b)
        Console.WriteLine("La hipotenusa es: " & c)
        Console.ReadKey()
    End Sub

    Friend Function Comprobar(ByVal mensaje As String) As Integer
        Dim a As Integer = 0
        While a <= 0
            Console.Write(mensaje)
            a = Console.ReadLine()
            If a <= 0 Then
                Console.WriteLine("El valor ingresado debe ser entero positivo")
            End If
        End While
        Return (a)
    End Function

    Friend Function Hipotenusa(ByVal a As UInt32, ByVal b As UInt32) As Integer
        Return (Math.Sqrt(a ^ 2 + b ^ 2))
    End Function

End Module
