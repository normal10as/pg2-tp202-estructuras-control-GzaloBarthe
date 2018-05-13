Module _2_13_primos
    Sub main()
        Dim nro As UInteger
        Dim divisores As UInteger
        Dim primos As UInteger
        primos = 0
        divisores = 0
        For i As Integer = 0 To 1000
            nro = i
            For j As Integer = 2 To nro
                If (nro Mod j) = 0 Then
                    divisores = divisores + 1
                End If
            Next
            If divisores = 1 Then
                Console.WriteLine("{0} es nro Primo", nro)
                primos = primos + 1
            End If
            divisores = 0
        Next
        Console.WriteLine("hay {0} nros primos entre 1 y 1000", primos)

    End Sub

End Module
