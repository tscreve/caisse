'
' Created by SharpDevelop.
' User: Admin
' Date: 25/10/2006
' Time: 17:55
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System

Namespace q

	Public Class Paiement
		Private _lNom As String
		Private _lTotal As String
		Private _lNb As integer 'représente le nb de paiement 
									'(combient de ticket resto ou avoir par ex.
		
		'mode de paiement:especes, ticket resto, avoir ou chèques
		Public Property Nom() As String
        	Get
               Nom = _lNom
          	End Get
          	Set
               _lNom= Value
          	End Set
     	End Property
		
		'montant du paiement
		Public Property Total() As String
        	Get
               Total = _lTotal
          	End Get
          	Set
               _lTotal= Value
          	End Set
     	End Property
     	
     	Public Property Nb() As String
     		Get
               Nb = _lNb
          	End Get
          	Set
               _lNb= Value
          	End Set
     	End Property
	
		Public Sub New(ByVal sNom As String, ByVal sTotal As String, ByVal sNb as integer)
			Nom=sNom
			Total=sTotal
			Nb=sNb
		End Sub
	End Class
End Namespace

