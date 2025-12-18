Imports System.Runtime.InteropServices
Imports System.Windows.Forms.Design.AxImporter

Module Reservations
    Dim nbplacesDisponible As Integer = 50
    Public Structure Reservation
        Dim ligne As String
        Dim villeDepart As String
        Dim villeArrive As String
        Dim h_Debut As String
        Dim f_Fin As String
        Dim places As Integer
        Dim options As List(Of String)
        Dim type As String
    End Structure
    Public Sub initReservation(ByRef r As Reservation)
            r.options = New List(Of String)
        End Sub


        Public listeReservation As New List(Of Reservation)
    Public Function AjouterReservation(r As Reservation)
        If r.places <= nbplacesDisponible Then
            listeReservation.Add(r)
            nbplacesDisponible = nbplacesDisponible - r.places
            Return True
        Else
            Return False
        End If
    End Function
End Module
