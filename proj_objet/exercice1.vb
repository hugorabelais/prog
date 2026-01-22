Module exercice1
    Public Class Compteur
        Private valeur As Integer
        Public Sub New(ByVal pvaleur As Integer)
            valeur = pvaleur
        End Sub

        Public Function GetValeur() As Integer
            Return valeur
        End Function

        Public Sub PlusUn()
            valeur += 1
        End Sub

        Public Sub Raz()
            valeur = 0
        End Sub

        Public Sub IncrementeDe(ByVal pincrement As Integer)
            If pincrement > 0 Then
                valeur += pincrement
            End If
        End Sub

        Public Sub DecrementeDe(ByVal pdecrement As Integer)
            If pdecrement Then
                valeur -= pdecrement
            End If
        End Sub
    End Class
    Sub Main()
        Dim cB, cC As compteur
        cB = New compteur(50)
        cC = New Compteur(0)
        cC = cB
        cB.PlusUn()
        Console.WriteLine("cB : " + (cB.GetValeur()).ToString())
        Console.WriteLine(("cC : " + (cC.GetValeur()).ToString()))
    End Sub

End Module
