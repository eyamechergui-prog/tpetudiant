<<<<<<< HEAD
﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_showMsg.Click
        MsgBox("Aya loves Mariem")
    End Sub
End Class
=======
<<<<<<< HEAD
﻿Imports System.Diagnostics.Eventing.Reader
Imports System.Diagnostics.Tracing
Imports System.Reflection.Metadata.Ecma335

Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim commande As String
        Dim prix As Double
        If RadioButton1.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf RadioButton2.checked Then
            commande = "burger"
            prix = 8
        Else
            commande = "Pate"
            prix = 15

        End If
        For Each ctrl In grsupplement.controls
            If ctrl.checked Then
                commande = commande = commande + " " + ctrl.text
                If ctrl.text = "fromage" Then
                    prix = prix + 2
                ElseIf ctrl.text = "dessert" Then
                    prix = prix + 4


                End If
            End If
        Next
        Dim bs As String = ""
        For Each it In lstBoisson.SelectedItems
            bs = bs + it + " "
        Next
        lblAfficher.Text = commande & "  total  " & prix & "      " & bs
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBoisson.Items.Add("café")
        lstBoisson.Items.Add("jus d'orange")
        lstBoisson.Items.Add("Eau minérale ")
        lstBoisson.Items.Add("citronade")
    End Sub
End Class
=======
<<<<<<< HEAD
﻿Public Class Form1
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
=======
﻿Public Class Form1
    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim article As Article
        initArticle(article)
        Dim test As Boolean = False
        ErrorProvider1.Clear()
        For Each ctrl In grvetement.Controls
            If ctrl.checked Then
                article.vetement = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grvetement, "veuillez choisir un vetement")
        End If
        For Each ctrl In grnettoyage.Controls
            If ctrl.checked Then
                article.typenettoyage = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grnettoyage, "veuillez choisir un type")

        End If
        Dim nb As Integer
        nb = CInt(textnb.Text)
        If nb = 0 Then
            ErrorProvider1.SetError(textnb, "veuillez donner un nombre > 0 !")
            Return
        End If
        If chkdefroissage.Checked Then
            article.supplement(0) = True

        End If
        If chkantitache.Checked Then
            article.supplement(1) = True
        End If
        ajouterArticle(article)
        'init()


    End Sub
End Class
>>>>>>> 5fbaeccb7234b4a6fd13a3809525ea4dc4d095b7
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
>>>>>>> ff5b1137935d12eccbd5c555e0c875828ea02b2f
