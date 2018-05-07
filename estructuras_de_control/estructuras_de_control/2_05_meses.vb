Module _2_05_meses
    Sub main()
        Dim mes As Byte
        Console.WriteLine("ingrese el nro de mes")
        mes = Console.ReadLine()
        Select Case mes
            Case 1
                Console.WriteLine("Enero")
            Case 2
                Console.WriteLine("Febrero")
            Case 3
                Console.WriteLine("Marzo")
            Case 4
                Console.WriteLine("Abril")
            Case 5
                Console.WriteLine("Mayo")
            Case 6
                Console.WriteLine("Junio")
            Case 7
                Console.WriteLine("Julio")
            Case 8
                Console.WriteLine("Agosto")
            Case 9
                Console.WriteLine("Septiembre")
            Case 10
                Console.WriteLine("Octubre")
            Case 11
                Console.WriteLine("Noviembre")
            Case 12
                Console.WriteLine("Diciembre")
            Case Else
                Console.WriteLine("NO EXISTTE MES CON ESE NRO!!")
        End Select

    End Sub

End Module
