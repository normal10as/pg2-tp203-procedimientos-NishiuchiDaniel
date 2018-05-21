Module Ej3_9
    Sub main()
        Dim opcion As Byte
        Dim a As UInt32
        Dim b As UInt32
        Dim c As UInt32
        Do
            Console.WriteLine("Seleccione figura de la que quiere calcular el area: ")
            Console.WriteLine("1-Cuadrado")
            Console.WriteLine("2-Rectangulo")
            Console.WriteLine("3-Trapecio")
            Console.WriteLine("0-Para salir")
            opcion = Console.ReadLine()
            Select Case opcion
                Case 1
                    Console.Write("Ingrese lado: ")
                    a = Console.ReadLine()
                    Area(a)
                Case 2
                    Console.Write("Ingrese base: ")
                    a = Console.ReadLine()
                    Console.Write("Ingrese altura: ")
                    b = Console.ReadLine()
                    Area(a, b)
                Case 3
                    Console.Write("Ingrese B: ")
                    a = Console.ReadLine()
                    Console.Write("Ingrese b: ")
                    b = Console.ReadLine()
                    Console.Write("Ingrese h: ")
                    c = Console.ReadLine()
                    Area(a, b, c)
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select
        Loop While opcion
    End Sub

    Private Function Area(ByVal a As UInt32) As UInt32
        Console.WriteLine("El area del cuadrado es: " & a * a)
        Console.WriteLine("---------------------------------------")
        Return (0)
    End Function
    Private Function Area(ByVal a As UInt32, ByVal b As UInt32) As UInt32
        Console.WriteLine("El area del rectangulo es: " & a * b)
        Console.WriteLine("---------------------------------------")
        Return (0)
    End Function
    Private Function Area(ByVal a As UInt32, ByVal b As UInt32, ByVal c As UInt32) As UInt32
        Console.WriteLine("El area del trapecio es: " & a * b / 2 * c)
        Console.WriteLine("---------------------------------------")
        Return (0)
    End Function

End Module
