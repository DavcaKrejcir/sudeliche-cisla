Module JednoduchyVstup
    Sub Main()
        While True
            Dim pocet As Integer
            Dim soucetLichych As Integer = 0
            Dim soucetSudych As Integer = 0
            Dim pocetLichych As Integer = 0
            Dim pocetSudych As Integer = 0
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
                    pocetSudych += 1
                Else
                    soucetLichych += cislo
                    pocetLichych += 1
                End If
            Next

            Console.WriteLine("Poèet zadaných lichých èísel: " & pocetLichych)
            Console.WriteLine("Souèet všech zadaných lichých èísel: " & soucetLichych)
            Console.WriteLine("Poèet zadaných sudých èísel: " & pocetSudych)
            Console.WriteLine("Souèet všech zadaných sudých èísel: " & soucetSudych)

            Console.WriteLine("Chcete provést další výpoèet? (ano/ne)")
            If Console.ReadLine().ToLower() <> "ano" Then
                Exit While
            End If
        End While

        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení...")
        Console.ReadKey()
    End Sub
End Module

