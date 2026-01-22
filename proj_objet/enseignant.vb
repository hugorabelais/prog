
Public Class Enseignant
        Const VALEURINDICE As Double = 13.754
        Private numero As String
        Private nom As String
        Private prenom As String
        Private adresse As String
        Private numtel As String
        Private datenaiss As String
        Private indice As Integer
        Private nombreDHeure As Double

        Public Sub New(ByVal pNumero As String, ByVal pNom As String, ByVal pPrenom As String, ByVal pAdresse As String, ByVal pNumtel As String, ByVal pDatenaiss As String, ByVal pIndice As Integer, ByVal pNombreDHeure As Double)
            numero = pNumero
            nom = pNom
            prenom = pPrenom
            adresse = pAdresse
            numtel = pNumtel
            datenaiss = pDatenaiss
            indice = pIndice
            nombreDHeure = pNombreDHeure
        End Sub

        Public Function GetNumero() As String
            Return numero
        End Function

        Public Function GetNom() As String
            Return nom
        End Function

        Public Sub setnom(ByVal pNom As String)
            nom = pNom
        End Sub

        Public Sub setprenom(ByVal pPrenom As String)
            prenom = pPrenom
        End Sub

        Public Function getNumTel() As String
            Return numtel
        End Function

        Public Sub setNumTel(ByVal pnumtel As String)
            numtel = pnumtel
        End Sub

        Public Function getadresse() As String
            Return adresse
        End Function

        Public Sub setAdresse(ByVal padresse As String)
            adresse = padresse
        End Sub

        Public Function getDateNaiss() As String
            Return datenaiss
        End Function

        Public Function AugmenterIndice(ByVal pindice As Integer) As Boolean
        If pindice > 0 Then
            indice = pindice
            Return True
        End If
        Return False
        End Function

        Public Function GetIndice() As Integer
            Return indice
        End Function

        Public Sub SetNombreDHeure(ByVal pNombreDHeure As Integer)
            If pNombreDHeure > 0 Then
                nombreDHeure = pNombreDHeure
            End If
        End Sub

        Public Function getNombreDHeure() As Integer
            Return nombreDHeure
        End Function

        Public Function SalaireMesuelle() As Double
            Return nombreDHeure * indice * VALEURINDICE
        End Function

        Public Overrides Function ToString() As String
        Return "numero : " + numero + vbNewLine +
            "Nom : " + nom + vbNewLine +
            "prenom : " + prenom + vbNewLine +
            "adresse : " + adresse + vbNewLine +
            "n° de telephone: " + numtel + vbNewLine +
            "date de naissance : " + datenaiss + vbNewLine +
            "indice : " + indice.ToString() + vbNewLine +
            "nombre d'heure : " + nombreDHeure.ToString() + vbNewLine
    End Function
    End Class
