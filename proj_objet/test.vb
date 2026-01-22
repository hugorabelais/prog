Module test
    Sub main()
        Dim pierre As Enseignant
        Dim noah As eleve
        pierre = New Enseignant("E0112", "Dupont", "Pierre", "1-rue de la paix - 75000 Paris", "0145045540", "1/10/1980", 8, 20)
        Console.WriteLine(pierre.ToString())
        Console.WriteLine("salaire mensuelle : " + (pierre.SalaireMesuelle()).ToString())
        pierre.AugmenterIndice(10)
        Console.WriteLine("indice : " + (pierre.GetIndice()).ToString())
        Console.WriteLine("salaire mensuelle : " + (pierre.SalaireMesuelle()).ToString())
        noah = New eleve("1", "depagne", "noah", "26  rue des champs", "0645360251", "29/04/2006", "btssio1")
        Console.WriteLine(noah.tostring())
        noah.SetNote(0, 19)
        noah.SetNote(1, 12)
        noah.SetNote(2, 16)
        noah.SetNote(3, 15)
        noah.SetNote(4, 20)
        noah.SetNote(5, 17)
        noah.SetNote(6, 16)
        noah.SetNote(7, 13)
        noah.SetNote(8, 18)
        noah.SetNote(9, 15)
        Console.WriteLine("moyenne : " + (noah.Moyenne()).ToString())
        Console.ReadLine()
    End Sub
End Module
