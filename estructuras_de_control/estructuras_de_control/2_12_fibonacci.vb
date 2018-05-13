Module _2_12_fibonacci
    Sub Main()
        Dim f0 As Integer
        Dim f1 As Integer
        Dim i As Byte
        i = 1
        f0 = 0
        f1 = 1
        Do While i <= 20
            Console.WriteLine("el {0}° numero de fibonnacci es {1}", i, f0)
            i = i + 1
            Console.WriteLine("el {0}° numero de fibonnacci es {1}", i, f1)
            f0 = f0 + f1
            f1 = f1 + f0
            i = i + 1
        Loop
    End Sub

End Module
