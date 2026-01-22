Module test
    Sub main()
        Dim mapile As pile
        Dim choix As Integer
        Dim element As String
        Dim possible As Boolean
        mapile = New pile()
        Do
            Console.WriteLine("1. Empiler")
            Console.WriteLine("2. Dépiler")
            Console.WriteLine("3. Tester si la Pile est vide")
            Console.WriteLine("4. Nombre d'éléments dans la Pile")
            Console.WriteLine("5. Contenu de la Pile")
            Console.WriteLine("6. Quitter")
            Console.WriteLine("choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("Entrer l'élément à empiler.")
                    element = Console.ReadLine
                    possible = mapile.empiler(element)
                    If possible Then
                        Console.WriteLine("OK")
                    Else
                        Console.WriteLine("ajout impossible pile pleine")
                    End If
                Case 2
                    Console.WriteLine("valeur extraite de la pile : " + mapile.depiler)
                Case 3
                    If mapile.EstVide() Then
                        Console.WriteLine("pile vide")
                    Else
                        Console.WriteLine("la pile n'est pas vide")
                    End If
                Case 4
                    Console.WriteLine("le nombre d'element dans la liste est : " + (mapile.NombreDElement()).ToString())
                Case 5
                    Console.WriteLine(mapile.ToString())
                Case 6

                Case Else
                    Console.WriteLine("mauvais choix")
            End Select
        Loop Until choix = 6
        Console.WriteLine("au revoir")
        Console.ReadLine()
    End Sub
End Module
