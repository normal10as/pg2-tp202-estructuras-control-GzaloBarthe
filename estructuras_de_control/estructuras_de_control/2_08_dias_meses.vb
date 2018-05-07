Module _2_08_dias_meses
    Sub main()
        Dim mes As Byte
        Dim anio As UInteger
        Console.WriteLine("ingrese un nro de mes")
        mes = Console.ReadLine()
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("tiene 31 dias")
            Case 2
                Console.WriteLine("ingrese el Anio")
                anio = Console.ReadLine()
                If (((anio Mod 4) = 0) And Not ((anio Mod 100) = 0)) Or (anio Mod 400) = 0 Then
                    Console.WriteLine("tiene 29 dias")
                Else
                    Console.WriteLine("tiene 28 dias")
                End If
            Case 4, 6, 9, 11
                Console.WriteLine("tiene 30 dias")
        End Select
    End Sub

End Module
