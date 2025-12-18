Module Articles
    Public Structure Article
        Dim code As String
        Dim vetement As String
        Dim typenettoyage As String
        Dim nombre As Integer
        Dim supplement() As Boolean
    End Structure
    Public Sub initArticle(A As Article)
        A.supplement(0) = False
        A.supplement(1) = False
    End Sub

    Public listeArticles As New List(Of Article)
    Public Sub ajouterArticle(A As Article)
        A.code = A.vetement.Substring(1, 2) & "_" & listeArticles.Count
        listeArticles.Add(A)
    End Sub




End Module
