'
' Created by SharpDevelop.
' User: Admin
' Date: 20/11/2006
' Time: 19:41
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System

Namespace q

	Public Class PaiementEnCours
	
	Private _lTotalTR As Single
	Private _lTotalAvoir As Single
	Private _lReste As Single
	Private _lARendre As Single
	Private _lAvoir As Single
	Private _lTotal As Single
	Private _lRecu As Single
	Private _lTropPercu as single
		
		Public Property TropPercu() As Single
        	Get
               TropPercu = _lTropPercu
          	End Get
          	Set
               _lTropPercu = Value
          	End Set
     	End Property    	
    	
		Public Property Recu() As Single
        	Get
               Recu = _lRecu
          	End Get
          	Set
               _lRecu = Value
          	End Set
     	End Property
     	
		Public Property TotalTR() As Single
        	Get
               TotalTR = _lTotalTR
          	End Get
          	Set
               _lTotalTR = Value
          	End Set
     	End Property
     	
     	Public Property TotalAvoir() As Single
        	Get
               TotalAvoir = _lTotalAvoir
          	End Get
          	Set
               _lTotalAvoir = Value
          	End Set
     	End Property
     	
     	Public Property Reste() As Single
        	Get
               Reste = _lReste
          	End Get
          	Set
               _lReste = Value
          	End Set
     	End Property
     	
     	Public Property ARendre() As Single
        	Get
               ARendre = _lARendre
          	End Get
          	Set
               _lARendre = Value
          	End Set
     	End Property
     	
     	Public Property Avoir() As Single
        	Get
               Avoir = _lAvoir
          	End Get
          	Set
               _lAvoir = Value
          	End Set
     	End Property
     	
     	Public Property Total() As Single
        	Get
               Total = _lTotal
          	End Get
          	Set
               _lTotal = Value
          	End Set
     	End Property
     	
     	Public Function Clear()
		     _lTotalTR=0
			 _lTotalAvoir=0
			 _lReste=0
			 _lARendre=0
			 _lAvoir=0
			 _lTropPercu=0
			 _lRecu=0
     	End Function
	End Class
End Namespace
