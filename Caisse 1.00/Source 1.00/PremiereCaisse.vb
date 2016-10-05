'
' Created by SharpDevelop.
' User: Admin
' Date: 24/01/2007
' Time: 09:43
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System

Namespace q

	Public Class PremiereCaisse
		Private _lTotalCaisse As Single
		
		Private _lNbTotalTR As Integer
		Private _lNbTotalAvoir As Integer
		Private _lNbTotalChk As Integer
		
		Private _lTotalTR As Single
		Private _lTotalAvoir As Single
		Private _lTotalChk As Single
		Private _lTotalEsp As Single
		
				
		Public Property TotalCaisse() As Single
			Get
				TotalCaisse=_lTotalCaisse
			End Get
			Set
				_lTotalCaisse=Value
			End Set
		End Property
		
		Public Property NbTotalTR() As Integer
			Get
				NbTotalTR=_lNbTotalTR
			End Get
			Set
				_lNbTotalTR=Value
			End Set
		End Property
		
		Public Property NbTotalAvoir() As Integer
			Get
				NbTotalAvoir=_lNbTotalAvoir
			End Get
			Set
				_lNbTotalAvoir=Value
			End Set
		End Property
		
		Public Property NbTotalChk() As Integer
			Get
				NbTotalChk=_lNbTotalChk
			End Get
			Set
				_lNbTotalChk=Value
			End Set
		End Property
		
		Public Property TotalTR() as single
			Get
				TotalTR=_lTotalTR
			End Get
			Set
				_lTotalTR=Value
			End Set
		End Property
		
		Public Property TotalAvoir() As single
			Get
				TotalAvoir=_lTotalAvoir
			End Get
			Set
				_lTotalAvoir=Value
			End Set
		End Property
		
		Public Property TotalChk() As single
			Get
				TotalChk=_lTotalChk
			End Get
			Set
				_lTotalChk=Value
			End Set
		End Property
		
		Public Property TotalEsp() As single
			Get
				TotalEsp=_lTotalEsp
			End Get
			Set
				_lTotalEsp=Value
			End Set
		End Property
	End Class
End Namespace
