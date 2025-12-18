Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim r As Reservation
        If lstligne.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstligne, "veuillez selectionner une ligne")
            Return
        End If
        r.ligne = lstligne.Text

        If lstvilledepart.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstvilledepart, "veuillez selectionner la ville de depart")
            Return
        End If
        r.villeDepart = lstvilledepart.Text
        If lstarrivé.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstarrivé, "veuillez selectionner l'arrivé")
            Return
        End If
        r.villeArrive = lstarrivé.Text
        If lstarrivé.Text = lstvilledepart.Text Then
            ErrorProvider1.SetError(lstarrivé, "veuillez selectionner une ville de depart different ")
            Return
        End If
        If CInt(textp.Text) <= 0 Then
            ErrorProvider1.SetError(lstarrivé, "nb de places invalide ")
            Return
        End If
        r.places = CInt(textp.Text)
        If timeDepart.Text = "" Then
            ErrorProvider1.SetError(timeDepart, "heure depart")
            Return
        End If
        r.h_Debut = timeDepart.Text
        If timeArrive.Text = "" Then
            ErrorProvider1.SetError(timeArrive, "heure arrivée")
            Return
        End If
        r.f_Fin = timeArrive.Text
        initReservation(r)

        For Each ctrl In groptions.Controls
            If ctrl.checked = True Then
                r.options.Add(ctrl.text)
            End If
        Next
        Dim test = False
        For Each ctrl In grtype.Controls
            If ctrl.checked = True Then
                r.type = ctrl.text
                test = True
                Exit For
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grtype, "choisir un type")
            Return
        End If


        AjouterReservation(r)

        Dim opp As String = ""
        For Each v In r.options
            opp = opp + v + "-"
        Next

        DataGridView1.Rows.Add(r.ligne, r.villeDepart, r.villeArrive, r.h_Debut, r.f_Fin, CStr(r.places), opp, r.type)

    End Sub

End Class
