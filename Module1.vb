Module etudiants
    Public Structure etudiant
        Dim nom As String
        Dim note As Double
        Dim prenom As String
    End Structure
    Public listeetudiants As New List(Of etudiant)
    Function ajouter(E As etudiant)
        If Not exist(E.nom) Then
            listeetudiants.Add(E)
            MessageBox.Show("ajout terminé" & listeetudiants.Count())
            Return True
        Else
            MessageBox.Show("existe déja")
            Return False
        End If
    End Function
    Function exist(ch As String)
        Dim test As Boolean = False
        For Each E As etudiant In listeetudiants
            If E.nom = ch Then
                test = True
                Exit For
            End If
        Next
        Return test
    End Function
    Function exist2(ch As String)
        For i As Integer = 0 To listeetudiants.Count - 1
            If listeetudiants(i).nom = ch Then
                Return True
            End If
        Next
        Return False
    End Function
    Function maxnote()
        Dim max As etudiant = listeetudiants(0)
        For i As Integer = 0 To listeetudiants.Count - 1
            If listeetudiants(i).note > max.note Then
                max = listeetudiants(i)
            End If
        Next
        Return max


    End Function
    Function moyenne()
        Dim s As Double = 0
        For i As Integer = 0 To listeetudiants.Count - 1
            s += listeetudiants(i).note
        Next
        Return s / listeetudiants.Count
    End Function


End Module
