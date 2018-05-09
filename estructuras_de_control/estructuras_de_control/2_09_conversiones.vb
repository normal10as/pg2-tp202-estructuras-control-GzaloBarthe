Module _2_09_conversiones
    Sub main()
        Dim tipo As Byte
        Dim m As Single
        Dim cm As Single
        Dim yard As Single
        Dim foot As Single
        Dim inch As Single
        Console.WriteLine("ingrese unidad de medida")
        Console.WriteLine("1-Metros")
        Console.WriteLine("2-Centimetros")
        Console.WriteLine("3-Yardas")
        Console.WriteLine("4-Pies")
        Console.WriteLine("5-Pulgadas")
        tipo = Console.ReadLine()
        Console.WriteLine("ingrese cantidad a convertir")
        Select Case tipo
            Case 1
                Console.WriteLine("Metros: ")
                m = Console.ReadLine()
                cm = m * 100
                inch = cm / 2.54
                foot = inch / 12
                yard = foot / 3
                Console.WriteLine("{0} metros = {1} centimetros ", m, cm)
                Console.WriteLine("{0} metros = {1} Yardas ", m, yard)
                Console.WriteLine("{0} metros = {1} Pies ", m, foot)
                Console.WriteLine("{0} metros = {1} Pulgadas", m, inch)
            Case 2
                Console.WriteLine("Centimetros: ")
                cm = Console.ReadLine()
                m = cm / 100
                inch = cm / 2.54
                foot = inch / 12
                yard = foot / 3
                Console.WriteLine("{0} centimetros = {1} metros ", cm, m)
                Console.WriteLine("{0} centimetros = {1} Yardas ", cm, yard)
                Console.WriteLine("{0} centimetros = {1} Pies ", cm, foot)
                Console.WriteLine("{0} centimetros = {1} Pulgadas", cm, inch)
            Case 3
                Console.WriteLine("Yardas: ")
                yard = Console.ReadLine()
                foot = yard * 3
                inch = foot * 12
                cm = inch * 2.54
                m = cm / 100
                Console.WriteLine("{0} Yardas = {1} metros ", yard, m)
                Console.WriteLine("{0} Yardas = {1} centimetros ", yard, cm)
                Console.WriteLine("{0} Yardas = {1} Pies ", yard, foot)
                Console.WriteLine("{0} Yardas = {1} Pulgadas", yard, inch)
            Case 4
                Console.WriteLine("Pies: ")
                foot = Console.ReadLine()
                yard = foot / 3
                inch = foot * 12
                cm = inch * 2.54
                m = cm / 100
                Console.WriteLine("{0} Pies = {1} metros ", foot, m)
                Console.WriteLine("{0} Pies = {1} centimetros ", foot, cm)
                Console.WriteLine("{0} Pies = {1} Yardas", foot, yard)
                Console.WriteLine("{0} Pies = {1} Pulgadas", foot, inch)
            Case 5
                Console.WriteLine("Pulgadas: ")
                inch = Console.ReadLine()
                cm = inch * 2.54
                foot = inch / 12
                yard = foot / 3
                m = cm / 100
                Console.WriteLine("{0} Pulgadas = {1} metros ", inch, m)
                Console.WriteLine("{0} Pulgadas = {1} centimetros ", inch, cm)
                Console.WriteLine("{0} Pulgadas = {1} Yardas", inch, yard)
                Console.WriteLine("{0} Pulgadas = {1} Pies", inch, foot)

        End Select
    End Sub

End Module
