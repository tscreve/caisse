'
' Created by SharpDevelop.
' User: Admin
' Date: 28/08/2006
' Time: 18:06
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Collections

Namespace q

	Public Class Ticket
     Private Col_Ticket As ArrayList
     Private Col_Paiement As ArrayList
     Private _lTotalTicket As String     
     Private _lAvoirRendu As String
     Private _lArendre As String

     Public Sub New()
          Col_Ticket = New ArrayList()    'cela crée une ArrayList
          Col_Paiement = New ArrayList()
     End Sub

     Public Function GetEnumerator() As IEnumerator    'permet d'utiliser For Each
          GetEnumerator = Col_Ticket.GetEnumerator
          GetEnumerator = Col_Paiement.GetEnumerator
     End Function

     Public Function AddLigne(ByVal LeNom As String, ByVal LeTexte As String, ByVal LeTotal As String) As Ligne
          Dim UneLigne As New Ligne(LeNom, LeTexte, LeTotal)
          Col_Ticket.Add(UneLigne)
          AddLigne = UneLigne
     End Function
     
     Public Function AddPaiement(ByVal LeNom As String, ByVal LeTotal As String, ByVal LeNombre as integer) As Paiement
          Dim UnPaiement As New Paiement(LeNom, LeTotal, LeNombre)
          Col_Paiement.Add(UnPaiement)
          AddPaiement = UnPaiement
     End Function
     
     Public Property TotalTicket() As string
        Get
			TotalTicket = _lTotalTicket
		End Get
		Set
			_lTotalTicket = Value
		End Set
    End Property
    
    Public Property AvoirRendu() As string
        Get
			AvoirRendu = _lAvoirRendu
		End Get
		Set
			_lAvoirRendu = Value
		End Set
    End Property
    
    Public Property Arendre() As string
        Get
			Arendre = _lArendre
		End Get
		Set
			_lArendre = Value
		End Set
    End Property

     Public ReadOnly Property Item(ByVal lIndex As Integer) As Ligne
          Get
              Item = (CType(Col_Ticket.Item(lIndex),Ligne))
          End Get
     End Property
	 
	 Public ReadOnly Property Paiement(ByVal lIndex As Integer) As Paiement
          Get
              Paiement = (CType(Col_Paiement.Item(lIndex),Paiement))
          End Get
     End Property
     
     Public ReadOnly Property Count() As Integer
          Get
              Count = Col_Ticket.Count
          End Get
     End Property
     
     Public ReadOnly Property PaiementCount() As Integer
          Get
              PaiementCount = Col_Paiement.Count
          End Get
     End Property

End Class
End Namespace
