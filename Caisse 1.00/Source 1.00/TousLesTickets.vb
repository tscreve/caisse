'
' Created by SharpDevelop.
' User: Admin
' Date: 29/08/2006
' Time: 20:01
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Collections

Namespace q

	Public Class TousLesTickets
		Private Col_TousLesTickets As ArrayList
		Private _lTotalCaisse As Single
		
		Private _lNbTotalTR As Integer
		Private _lNbTotalAvoir As Integer
		Private _lNbTotalChk As Integer
		
		Private _lTotalTR As Single
		Private _lTotalAvoir As Single
		Private _lTotalChk As Single
		Private _lTotalEsp as single
		
     	Public Sub New()
          	Col_TousLesTickets = New ArrayList()    'cela crée une ArrayList
     	End Sub

     	Public Function GetEnumerator() As IEnumerator    'permet d'utiliser For Each
          	GetEnumerator = Col_TousLesTickets.GetEnumerator
     	End Function

     	Public Function Add(ByVal T as Ticket) As Ticket
          	Col_TousLesTickets.Add(T)
          	Add = T
     	End Function

     	Public ReadOnly Property Item(ByVal lIndex As Integer) As Ticket
         	Get
               Item = (CType(Col_TousLesTickets.Item(lIndex),Ticket))
         	End Get
     	End Property

		Public ReadOnly Property Count() As Integer
            Get
               Count = Col_TousLesTickets.Count
            End Get
     	End Property

        Public Sub Removeat(ByVal Key As integer)
          	Col_TousLesTickets.Removeat(Key)
        End Sub
        
        Public Sub Remove(ByVal T As Object)
        	Col_TousLesTickets.Remove(T)
        End Sub
		
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
