Module JednoduchyVstup
    Sub Main()
        Dim pocet As Integer
        Console.Write("Zadejte po�et ��sel: ")
        pocet = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To pocet
            Console.Write("Zadejte ��slo " & i & ": ")
            Console.ReadLine() ' ��slo je p�e�teno, ale nen� nikam ulo�eno
        Next

        Console.WriteLine("V�echna ��sla byla zad�na.")
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�...")
        Console.ReadKey()
    End Sub
End Module