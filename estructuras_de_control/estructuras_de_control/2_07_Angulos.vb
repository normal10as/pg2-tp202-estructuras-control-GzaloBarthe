Module _2_07_Angulos
    Sub main()
        Dim angulo As UInteger
        Console.WriteLine("ingrese el angulo")
        angulo = Console.ReadLine()
        Select Case angulo
            Case Is < 90
                Console.WriteLine("Agudo")
            Case 90
                Console.WriteLine("Recto")
            Case 91 To 179
                Console.WriteLine("Obtuso")
            Case 180
                Console.WriteLine("Llano")
            Case 181 To 360
                Console.WriteLine("concavo")
            Case Else
                Console.WriteLine("Error")

        End Select

    End Sub

End Module
