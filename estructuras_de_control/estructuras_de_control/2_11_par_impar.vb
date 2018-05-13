Module _2_11_par_impar
    Sub main()
        Dim nro As Integer
        Dim cont_par As Byte
        Dim cont_impar As Byte
        Dim c As Byte
        cont_par = 0
        cont_impar = 0
        c = 0
        Do
            Console.WriteLine("ingrese nros positivos o cero (0) para salir")
            nro = Console.ReadLine()
            Do While nro < 0
                Console.WriteLine("ingrese nros POSITIVOS!!!")
                nro = Console.ReadLine()
            Loop
            If (nro Mod 2) = 0 And nro <> 0 Then
                cont_par = cont_par + 1
                c = c + 1
            ElseIf nro <> 0 Then
                cont_impar = cont_impar + 1
                c = c + 1
            End If
        Loop While nro <> 0 And c < 254
        If cont_par = c Then
            Console.WriteLine("son todos Pares los {0} nros ingresados", c)
        ElseIf cont_impar = c Then
            Console.WriteLine("son todos Impares los {0} nros ingresados", c)
        Else
            Console.WriteLine("se ingresaron {0} Pares y {1} Impares", cont_par, cont_impar)
        End If
    End Sub

End Module
