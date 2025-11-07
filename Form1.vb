Imports System.Drawing.Text

Public Class Form1
    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim nom As String
        Dim note As Double
        Dim prenom As String
        Dim x As etudiants.etudiant
        Dim test As Boolean = True
        ErrorProvider1.Clear()
        nom = Textnom.Text.Trim()
        prenom = Textprenom.Text.Trim()

        If nom = "" Then
            ErrorProvider1.SetError(Textnom, "indiquer le nom:")
            test = False
        End If
        If prenom = "" Then
            ErrorProvider1.SetError(Textprenom, "indiquer le prenom:")
            test = False
        End If
        If Not Double.TryParse(Textnote.Text, note) Then
            ErrorProvider1.SetError(Textnote, "indiquer une numerique")
            test = False
        End If
        If Not (0 <= note <= 20) Then
            ErrorProvider1.SetError(Textnote, "indiquer une note entre 0 et 20")
            test = False
        End If

        If test Then
            note = CDbl(Textnote.Text.Trim())
            x.nom = nom
            x.prenom = prenom
            x.note = note
            ajouter(x)
            'DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(x.nom, x.prenom, x.note)
            vider()
        End If
    End Sub
    Private Sub txtnote_textchanged(sender As Object, e As EventArgs) Handles Textnote.TextChanged

    End Sub
    Sub vider()
        Textnom.Clear()
        Textprenom.Clear()
        Textnote.Clear()

    End Sub
    Private Sub txtnote_keypress(sender As Object, e As KeyPressEventArgs) Handles Textnom.KeyPress


    End Sub

    Private Sub btnafficher_Click(sender As Object, e As EventArgs) Handles btnafficher.Click
        Dim v As etudiant = maxnote()
        MsgBox("l'étudiant ayant la note maximale est :" & v.nom & " " & v.prenom & " avec la note de :" & v.note, MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub btnannuler_Click(sender As Object, e As EventArgs) Handles btnannuler.Click
        vider()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnmoy.Click
        MsgBox("la moyenne génerale est " & moyenne(), MsgBoxStyle.Information, "info")
    End Sub
End Class
