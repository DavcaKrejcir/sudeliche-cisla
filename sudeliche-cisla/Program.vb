Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Dim soucetLichych As Integer = 0
        Dim soucetSudych As Integer = 0
        Dim cislo As Integer

        Console.Write("Zadejte kladn� po�et ��sel: ")
        While Not (Integer.TryParse(Console.ReadLine(), pocet) AndAlso pocet > 0)
            Console.WriteLine("Neplatn� vstup. Zadejte pros�m kladn� cel� ��slo.")
            Console.Write("Zadejte kladn� po�et ��sel: ")
        End While

        For i As Integer = 1 To pocet
            Console.Write("Zadejte ��slo " & i & ": ")
            While Not (Integer.TryParse(Console.ReadLine(), cislo) AndAlso cislo >= 0)
                Console.WriteLine("Neplatn� vstup. Zadejte pros�m kladn� cel� ��slo nebo nulu.")
                Console.Write("Zadejte ��slo " & i & ": ")
            End While

            If cislo Mod 2 = 0 Then
                soucetSudych += cislo
            Else
                soucetLichych += cislo
            End If
        Next

        Console.WriteLine("Sou�et v�ech zadan�ch lich�ch ��sel je: " & soucetLichych)
        Console.WriteLine("Sou�et v�ech zadan�ch sud�ch ��sel je: " & soucetSudych)
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�...")
        Console.ReadKey()
    End Sub
End Module
