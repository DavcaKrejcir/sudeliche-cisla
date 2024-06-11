Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Console.Write("Zadejte poèet èísel: ")
        While Not Integer.TryParse(Console.ReadLine(), pocet)
            Console.WriteLine("Neplatný vstup. Zadejte prosím celé èíslo.")
            Console.Write("Zadejte poèet èísel: ")
        End While

        Dim cislo As Integer
        For i As Integer = 1 To pocet
            Console.Write("Zadejte èíslo " & i & ": ")
            While Not Integer.TryParse(Console.ReadLine(), cislo)
                Console.WriteLine("Neplatný vstup. Zadejte prosím celé èíslo.")
                Console.Write("Zadejte èíslo " & i & ": ")
            End While
        Next

        Console.WriteLine("Všechna èísla byla zadána.")
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení...")
        Console.ReadKey()
    End Sub
End Module
