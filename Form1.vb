Public Class Form1
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
