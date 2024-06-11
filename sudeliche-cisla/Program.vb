Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Console.Write("Zadejte kladn� po�et ��sel: ")
        While Not (Integer.TryParse(Console.ReadLine(), pocet) AndAlso pocet > 0)
            Console.WriteLine("Neplatn� vstup. Zadejte pros�m kladn� cel� ��slo.")
            Console.Write("Zadejte kladn� po�et ��sel: ")
        End While

        Dim cislo As Integer
        For i As Integer = 1 To pocet
            Console.Write("Zadejte kladn� ��slo " & i & ": ")
            While Not (Integer.TryParse(Console.ReadLine(), cislo) AndAlso cislo >= 0)
                Console.WriteLine("Neplatn� vstup. Zadejte pros�m kladn� cel� ��slo nebo nulu.")
                Console.Write("Zadejte kladn� ��slo " & i & ": ")
            End While
        Next

        Console.WriteLine("V�echna ��sla byla zad�na.")
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�...")
        Console.ReadKey()
    End Sub
End Module
