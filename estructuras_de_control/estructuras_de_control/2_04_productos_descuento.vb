Module _2_04_productos_descuento
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
        If cant >= 10 And cant <= 50 Then
            dcto = 0.05
        ElseIf cant > 50 And cant <= 250 Then
            dcto = 0.1
        ElseIf cant > 250 Then
            dcto = 0.2
        End If
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
