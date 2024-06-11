Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Dim soucetLichych As Integer = 0
        Dim soucetSudych As Integer = 0
        Dim cislo As Integer

        Console.Write("Zadejte kladný poèet èísel: ")
        While Not (Integer.TryParse(Console.ReadLine(), pocet) AndAlso pocet > 0)
            Console.WriteLine("Neplatný vstup. Zadejte prosím kladné celé èíslo.")
            Console.Write("Zadejte kladný poèet èísel: ")
        End While

        For i As Integer = 1 To pocet
            Console.Write("Zadejte èíslo " & i & ": ")
            While Not (Integer.TryParse(Console.ReadLine(), cislo) AndAlso cislo >= 0)
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné celé èíslo nebo nulu.")
                Console.Write("Zadejte èíslo " & i & ": ")
            End While

            If cislo Mod 2 = 0 Then
                soucetSudych += cislo
            Else
                soucetLichych += cislo
            End If
        Next

        Console.WriteLine("Souèet všech zadaných lichých èísel je: " & soucetLichych)
        Console.WriteLine("Souèet všech zadaných sudých èísel je: " & soucetSudych)
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení...")
        Console.ReadKey()
    End Sub
End Module
