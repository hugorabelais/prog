Imports System.Runtime.CompilerServices
Imports System.Runtime.Versioning

Class pile
    Const MAX As Integer = 100
    Private tabPile(MAX) As String
    Private positionLibre As Integer
    Public Sub New()
        positionLibre = 0
    End Sub

    Public Function empiler(ByVal pvaleur As String) As Boolean
        If positionLibre <= MAX Then
            tabPile(positionLibre) = pvaleur
            positionLibre += 1
            Return True
        Else
            Return False
        End If
    End Function


    Public Function depiler() As String
        positionLibre -= 1
        Return tabPile(positionLibre)
    End Function

    Public Function EstVide() As Boolean
        If positionLibre = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function NombreDElement() As Integer
        Return positionLibre
    End Function

    Public Overrides Function ToString() As String
        Dim chaine As String
        chaine = ""
        For i = 0 To positionLibre - 1
            chaine += tabPile(i) + vbNewLine + "...." + vbNewLine
        Next
        Return chaine
    End Function

End Class