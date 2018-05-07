Module menor_de_3
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim menor As Integer
        Console.WriteLine("ingrese un valor:")
        a = Console.ReadLine()
        Console.WriteLine("ingrese otro valor:")
        b = Console.ReadLine()
        Console.WriteLine("ingrese un valor mas:")
        c = Console.ReadLine()
        If a > b Then
            If b > c Then
                menor = c
            Else
                menor = b

            End If
        ElseIf a > c Then
            menor = c
        Else
            menor = a
        End If
        Console.WriteLine("el menor nro ingresado es:" & menor)
    End Sub

End Module
