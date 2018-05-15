Module Ej3_5
    Sub main()
        Dim r As Double
        Dim h As Double
        Dim v As Double
        r = Comprobar("Ingrese radio de la base: ")
        h = Comprobar("Ingrese altura del cilindro: ")
        v = volumen(r, h)
        Console.WriteLine("El volumen es de: " & v)
        Console.ReadKey()
    End Sub

    Friend Function comprobar(ByVal mensaje As String) As Double
        Dim a As Integer = 0
        While a <= 0
            Console.Write(mensaje)
            a = Console.ReadLine()
            If a <= 0 Then
                Console.WriteLine("El valor ingresado debe ser positivo")
            End If
        End While
        Return (a)
    End Function

    Friend Function volumen(ByVal r As Double, ByVal h As Double) As Double
        Return (Math.PI * Math.Pow(r, 2) * h)
    End Function

End Module
