'
' Created By SharpDevelop.
' User: Admin
' Date: 28/08/2006
' Time: 18:22
' 
' To Change This Template Use Tools | Options | Coding | Edit Standard Headers.
'

Imports System

Namespace Q


'################	REPRESENTE UNE LIGNE D'UN TICKET	################


	Public Class Ligne
		Private _lQty As String
		Private _lText As String		
		Private _lTotal As String

		Public Property Qty() As String
        	Get
               Qty = _lQty
          	End Get
          	Set
               _lQty = Value
          	End Set
     	End Property
     	
     	Public Property Text() As String
        	Get
               Text = _lText
          	End Get
          	Set
               _lText = Value
          	End Set
     	End Property
     	
     	Public Property Total() As String
        	Get
               Total = _lTotal
          	End Get
          	Set
               _lTotal = Value
          	End Set
     	End Property


		Public Sub New(ByVal sQty as string, ByVal SText as string, ByVal sTotal as string)
			Qty=sQty
			Text=SText
			Total=sTotal
		End Sub 
		
	End Class
End Namespace
