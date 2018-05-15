Module Ej3_6
    Friend Function comprobar(ByVal b) As UInt16
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

    Friend Function calcular(ByRef i, ByRef acu)
        Dim c As UInt16
        c = i ^ 2
        acu += c
        Return acu
    End Function

    Sub main()
        Dim n As UInt16
        Dim c As UInt16
        Dim acu As UInt32
        n = comprobar("Ingrese valor: ")
        For i As Byte = 1 To n
            c = calcular(i, acu)
            Console.WriteLine(c)
        Next
        Console.ReadKey()

    End Sub
End Module
