Imports System.Diagnostics.Eventing.Reader
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
