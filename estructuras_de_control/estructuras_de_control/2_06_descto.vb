Module _2_06_descto
    Sub main()
        Dim cant As UInteger
        Dim precio As Single
        Dim dcto As Single
        Dim subtotal As Single
        Dim total As Single
        Dim tot_dcto As Single
        Console.WriteLine("ingrese la cantidad de productos")
        cant = Console.ReadLine()
        Console.WriteLine("ingrese precio unitario")
        precio = Console.ReadLine()
        tot_dcto = 0
        subtotal = precio * cant
        Select Case cant
            Case 10 To 50
                dcto = 0.05
            Case 51 To 250
                dcto = 0.1
            Case Is > 250
                dcto = 0.2
        End Select
        tot_dcto = subtotal * dcto
        total = subtotal - tot_dcto
        Console.WriteLine("el subtotal es $" & subtotal)

        If dcto > 0 Then
            Console.WriteLine("se otorgo un descuento de " & (dcto * 100) & "%")
            Console.WriteLine("descuento = $" & tot_dcto)
        Else
            Console.WriteLine("no se aplica descuento")
        End If
        Console.WriteLine("el TOTAL es = $" & total)

    End Sub


End Module
