Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Console.Write("Zadejte po�et ��sel: ")
        While Not Integer.TryParse(Console.ReadLine(), pocet)
            Console.WriteLine("Neplatn� vstup. Zadejte pros�m cel� ��slo.")
            Console.Write("Zadejte po�et ��sel: ")
        End While

        Dim cislo As Integer
        For i As Integer = 1 To pocet
            Console.Write("Zadejte ��slo " & i & ": ")
            While Not Integer.TryParse(Console.ReadLine(), cislo)
                Console.WriteLine("Neplatn� vstup. Zadejte pros�m cel� ��slo.")
                Console.Write("Zadejte ��slo " & i & ": ")
            End While
        Next

        Console.WriteLine("V�echna ��sla byla zad�na.")
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�...")
        Console.ReadKey()
    End Sub
End Module
