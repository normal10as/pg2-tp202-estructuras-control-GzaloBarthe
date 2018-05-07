Module mayor_x_posicion
    Enum posiciones As Byte
        primer = 1
        segundo = 2
        tercer = 3
        cuarto = 4
        quinto = 5
    End Enum
    Sub main()
        Dim a As Integer
        Dim posicion(5) As String
        Dim may As Integer
        Dim p As Byte
        posicion = [Enum].GetNames(GetType(posiciones))
        For i As Byte = 0 To 4
            If i = 0 Then
                Console.WriteLine("ingrese un valor")
            Else
                Console.WriteLine("ingrese otro valor")
            End If
            a = Console.ReadLine()
            If a > may Then
                p = i
                may = a
            End If
        Next
        Console.WriteLine("el " & posicion(p) & " nro es el de mayor valor")
    End Sub

End Module
