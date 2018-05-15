Module Ej3_6
    Friend Function comprobar(ByVal mensaje) As UInt16
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

    Friend Function calcular(ByRef i, ByRef acu) As UInt32
        Dim c As UInt16
        c = i ^ 2
        acu += c
        Return acu
    End Function

    Sub main()
        Dim n As Byte
        Dim c As UInt16
        Dim acu As UInt32
        Dim i As Byte = 1
        n = comprobar("Ingrese valor: ")
        Do
            c = calcular(i, acu)
            Console.WriteLine(c)
            i += 1
        Loop While i <= n
        Console.ReadKey()

    End Sub
End Module
