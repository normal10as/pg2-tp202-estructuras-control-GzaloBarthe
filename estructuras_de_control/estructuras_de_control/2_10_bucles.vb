Module _2_10_bucles
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim i As Integer
        Console.WriteLine("ingrese un primer nro")
        a = Console.ReadLine()
        Console.WriteLine("ingrese un segundo nro")
        b = Console.ReadLine()
        If a > b Then
            c = b
            b = a
            a = c
        End If

        Console.WriteLine("While")
        c = 0
        i = a
        Do While i <= b
            If (i Mod 5) = 0 Then
                c = c + 1
            End If
            i = i + 1
        Loop
        Console.WriteLine("hay {0} multiplos de 5", c)
        Console.WriteLine("Until")
        c = 0
        i = a
        Do Until i > b
            If (i Mod 5) = 0 Then
                c = c + 1
            End If
            i = i + 1

        Loop
        Console.WriteLine("hay {0} multiplos de 5", c)
        Console.WriteLine("Do-While")
        c = 0
        i = a
        Do
            If (i Mod 5) = 0 Then
                c = c + 1
            End If
            i = i + 1
        Loop While i <= b
        Console.WriteLine("hay {0} multiplos de 5", c)
        Console.WriteLine("Do-Until")
        c = 0
        i = a
        Do
            If (i Mod 5) = 0 Then
                c = c + 1
            End If
            i = i + 1
        Loop Until i > b
        Console.WriteLine("hay {0} multiplos de 5", c)
        Console.WriteLine("For")
        c = 0
        For i = a To b
            If (i Mod 5) = 0 Then
                c = c + 1
            End If
        Next
        Console.WriteLine("hay {0} multiplos de 5", c)

    End Sub

End Module
