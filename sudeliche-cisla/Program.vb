Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Console.Write("Zadejte kladný poèet èísel: ")
        While Not (Integer.TryParse(Console.ReadLine(), pocet) AndAlso pocet > 0)
            Console.WriteLine("Neplatný vstup. Zadejte prosím kladné celé èíslo.")
            Console.Write("Zadejte kladný poèet èísel: ")
        End While

        Dim cislo As Integer
        For i As Integer = 1 To pocet
            Console.Write("Zadejte kladné èíslo " & i & ": ")
            While Not (Integer.TryParse(Console.ReadLine(), cislo) AndAlso cislo >= 0)
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné celé èíslo nebo nulu.")
                Console.Write("Zadejte kladné èíslo " & i & ": ")
            End While
        Next

        Console.WriteLine("Všechna èísla byla zadána.")
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení...")
        Console.ReadKey()
    End Sub
End Module
