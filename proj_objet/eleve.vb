
Imports System.Globalization

Public Class eleve
    Const MAXNOTES As Double = 10
    Private numero As String
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private numtel As String
    Private datenaiss As String
    Private numclasse As String
    Private tabnotes(MAXNOTES) As Double

    Public Sub New(ByVal pNumero As String, ByVal pNom As String, ByVal pPrenom As String, ByVal pAdresse As String, ByVal pNumtel As String, ByVal pDatenaiss As String, ByVal pnumclasse As String)
        numero = pNumero
        nom = pNom
        prenom = pPrenom
        adresse = pAdresse
        numtel = pNumtel
        datenaiss = pDatenaiss
        numclasse = pnumclasse
        For i = 0 To MAXNOTES
            tabnotes(i) = -1
        Next
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

    Public Function GetNumClasse(ByVal pindice As Integer) As String
        Return numclasse
    End Function

    Public Sub setnumclasse(ByVal pnumclasse As String)
        numclasse = pnumclasse
    End Sub

    Public Function Moyenne() As Double
        Dim total As Double
        Dim compteur As Integer
        For i = 0 To MAXNOTES
            If tabnotes(i) <> -1 Then
                total += tabnotes(i)
                compteur += 1
            End If
        Next
        If compteur <> 0 Then
            Return total / compteur
        Else
            Return -1
        End If
    End Function

    Public Sub SetNote(ByVal nomatiere As Integer, ByVal note As Double)
        tabnotes(nomatiere) = note
    End Sub

    Public Overrides Function tostring() As String
        Dim chaine As String
        chaine = ""
        For i = 0 To MAXNOTES
            chaine += tabnotes(i).ToString() + "|"
        Next
        Return "numero : " + numero + vbNewLine +
            "Nom : " + nom + vbNewLine +
            "prenom : " + prenom + vbNewLine +
            "adresse : " + adresse + vbNewLine +
            "n° de telephone: " + numtel + vbNewLine +
            "date de naissance : " + datenaiss + vbNewLine +
            "n° de la classe : " + numclasse + vbNewLine +
            "Notes : " + chaine
    End Function
End Class

