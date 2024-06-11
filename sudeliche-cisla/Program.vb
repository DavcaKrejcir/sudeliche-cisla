Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Console.Write("Zadejte poèet èísel: ")
        pocet = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To pocet
            Console.Write("Zadejte èíslo " & i & ": ")
            Console.ReadLine() ' Èíslo je pøeèteno, ale není nikam uloženo
        Next

        Console.WriteLine("Všechna èísla byla zadána.")
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení...")
        Console.ReadKey()
    End Sub
End Module