Module _2_14_vta_productos
    Sub main()
        Dim cant As UInteger
        Dim precio As Single
        Dim dcto As Single
        Dim subtotal As Single
        Dim total As Single
        Dim tot_dcto As Single
        Dim total_final As Single
        Dim tot_dcto_final As Single
        Do
            Console.WriteLine("-----------Nuevo Producto----------")
            Console.WriteLine("ingrese la cantidad de productos. Cero para salir (0)")
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
            total_final = total_final + total
            tot_dcto_final = tot_dcto_final + tot_dcto
            dcto = 0
        Loop While cant <> 0
        Console.WriteLine("------------------")
        Console.WriteLine("| TOTAL A COBRAR | = {0}", total_final)
        Console.WriteLine("------------------")
        Console.WriteLine("------------------")
        Console.WriteLine("| TOTAL DESUENTO | = {0}", tot_dcto_final)
        Console.WriteLine("------------------")
    End Sub

End Module
