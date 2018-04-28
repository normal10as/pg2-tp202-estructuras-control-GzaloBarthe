Module mayor_menor

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("ingrese un valor:")
        a = Console.ReadLine()
        Console.WriteLine("ingrese otro valor:")
        b = Console.ReadLine()
        If a > b Then
            Console.WriteLine("el 1er nro ingresado es mayor")
        ElseIf a = b Then
            Console.WriteLine("los valores ingresados son iguales")
        Else
            Console.WriteLine("el 2do nro ingresado es mayor")
        End If

    End Sub

End Module
