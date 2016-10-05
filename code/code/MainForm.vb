'
' Created by SharpDevelop.
' User: Admin
' Date: 20/01/2007
' Time: 16:20
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace code
	
	Public Class MainForm
		Inherits System.Windows.Forms.Form
		Private TxtNbAvoir As System.Windows.Forms.TextBox
		Private TxtTotalAvoir As System.Windows.Forms.TextBox
		Private BtnDecode As System.Windows.Forms.Button
		Private TxtNbChk As System.Windows.Forms.TextBox
		Private TxtTotalCaisse As System.Windows.Forms.TextBox
		Private TxtTotalChk As System.Windows.Forms.TextBox
		Private TxtNbTR As System.Windows.Forms.TextBox
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private TxtEsp As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private TxtTotalTR As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		
		Public Shared Sub Main
			Dim fMainForm As New MainForm
			fMainForm.ShowDialog()
		End Sub
		
		Public Sub New()
			MyBase.New
			'
			' The Me.InitializeComponent call is required for Windows Forms designer support.
			'
			Me.InitializeComponent
			'
			' TODO : Add constructor code after InitializeComponents
			'
		End Sub
		
		#Region " Windows Forms Designer generated code "
		' This method is required for Windows Forms designer support.
		' Do not change the method contents inside the source code editor. The Forms designer might
		' not be able to load this method if it was changed manually.
		Private Sub InitializeComponent()
			Me.label8 = New System.Windows.Forms.Label
			Me.label9 = New System.Windows.Forms.Label
			Me.label4 = New System.Windows.Forms.Label
			Me.label5 = New System.Windows.Forms.Label
			Me.label6 = New System.Windows.Forms.Label
			Me.label7 = New System.Windows.Forms.Label
			Me.TxtTotalTR = New System.Windows.Forms.TextBox
			Me.label1 = New System.Windows.Forms.Label
			Me.label2 = New System.Windows.Forms.Label
			Me.label3 = New System.Windows.Forms.Label
			Me.TxtEsp = New System.Windows.Forms.TextBox
			Me.label11 = New System.Windows.Forms.Label
			Me.label10 = New System.Windows.Forms.Label
			Me.TxtNbTR = New System.Windows.Forms.TextBox
			Me.TxtTotalChk = New System.Windows.Forms.TextBox
			Me.TxtTotalCaisse = New System.Windows.Forms.TextBox
			Me.TxtNbChk = New System.Windows.Forms.TextBox
			Me.BtnDecode = New System.Windows.Forms.Button
			Me.TxtTotalAvoir = New System.Windows.Forms.TextBox
			Me.TxtNbAvoir = New System.Windows.Forms.TextBox
			Me.SuspendLayout
			'
			'label8
			'
			Me.label8.Location = New System.Drawing.Point(0, 216)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(56, 23)
			Me.label8.TabIndex = 15
			Me.label8.Text = "Nombre :"
			'
			'label9
			'
			Me.label9.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label9.Location = New System.Drawing.Point(0, 120)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(64, 23)
			Me.label9.TabIndex = 17
			Me.label9.Text = "AVOIR :"
			Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			'
			'label4
			'
			Me.label4.Location = New System.Drawing.Point(0, 152)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(56, 23)
			Me.label4.TabIndex = 9
			Me.label4.Text = "Nombre :"
			'
			'label5
			'
			Me.label5.Location = New System.Drawing.Point(144, 152)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(40, 23)
			Me.label5.TabIndex = 10
			Me.label5.Text = "Total :"
			'
			'label6
			'
			Me.label6.Location = New System.Drawing.Point(144, 88)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(40, 23)
			Me.label6.TabIndex = 12
			Me.label6.Text = "Total :"
			'
			'label7
			'
			Me.label7.Location = New System.Drawing.Point(144, 216)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(40, 23)
			Me.label7.TabIndex = 16
			Me.label7.Text = "Total :"
			'
			'TxtTotalTR
			'
			Me.TxtTotalTR.Location = New System.Drawing.Point(184, 88)
			Me.TxtTotalTR.Name = "TxtTotalTR"
			Me.TxtTotalTR.TabIndex = 2
			Me.TxtTotalTR.Text = ""
			'
			'label1
			'
			Me.label1.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label1.Location = New System.Drawing.Point(0, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(136, 23)
			Me.label1.TabIndex = 5
			Me.label1.Text = "TOTAL DE LA CAISSE :"
			'
			'label2
			'
			Me.label2.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label2.Location = New System.Drawing.Point(0, 56)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(160, 23)
			Me.label2.TabIndex = 6
			Me.label2.Text = "TICKET RESTAURANT :"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			'
			'label3
			'
			Me.label3.Location = New System.Drawing.Point(0, 88)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(56, 23)
			Me.label3.TabIndex = 7
			Me.label3.Text = "Nombre :"
			'
			'TxtEsp
			'
			Me.TxtEsp.Location = New System.Drawing.Point(136, 272)
			Me.TxtEsp.Name = "TxtEsp"
			Me.TxtEsp.TabIndex = 7
			Me.TxtEsp.Text = ""
			'
			'label11
			'
			Me.label11.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label11.Location = New System.Drawing.Point(0, 272)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(128, 23)
			Me.label11.TabIndex = 20
			Me.label11.Text = "TOTAL DES ESPECES :"
			'
			'label10
			'
			Me.label10.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label10.Location = New System.Drawing.Point(0, 192)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(80, 23)
			Me.label10.TabIndex = 18
			Me.label10.Text = "CHEQUES :"
			Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			'
			'TxtNbTR
			'
			Me.TxtNbTR.Location = New System.Drawing.Point(56, 88)
			Me.TxtNbTR.Name = "TxtNbTR"
			Me.TxtNbTR.Size = New System.Drawing.Size(40, 20)
			Me.TxtNbTR.TabIndex = 1
			Me.TxtNbTR.Text = ""
			'
			'TxtTotalChk
			'
			Me.TxtTotalChk.Location = New System.Drawing.Point(184, 216)
			Me.TxtTotalChk.Name = "TxtTotalChk"
			Me.TxtTotalChk.TabIndex = 6
			Me.TxtTotalChk.Text = ""
			'
			'TxtTotalCaisse
			'
			Me.TxtTotalCaisse.Location = New System.Drawing.Point(136, 8)
			Me.TxtTotalCaisse.Name = "TxtTotalCaisse"
			Me.TxtTotalCaisse.TabIndex = 0
			Me.TxtTotalCaisse.Text = ""
			'
			'TxtNbChk
			'
			Me.TxtNbChk.Location = New System.Drawing.Point(56, 216)
			Me.TxtNbChk.Name = "TxtNbChk"
			Me.TxtNbChk.Size = New System.Drawing.Size(40, 20)
			Me.TxtNbChk.TabIndex = 5
			Me.TxtNbChk.Text = ""
			'
			'BtnDecode
			'
			Me.BtnDecode.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnDecode.Location = New System.Drawing.Point(208, 320)
			Me.BtnDecode.Name = "BtnDecode"
			Me.BtnDecode.TabIndex = 8
			Me.BtnDecode.Text = "DECODER"
			AddHandler Me.BtnDecode.Click, AddressOf Me.BtnDecodeClick
			'
			'TxtTotalAvoir
			'
			Me.TxtTotalAvoir.Location = New System.Drawing.Point(184, 152)
			Me.TxtTotalAvoir.Name = "TxtTotalAvoir"
			Me.TxtTotalAvoir.TabIndex = 4
			Me.TxtTotalAvoir.Text = ""
			'
			'TxtNbAvoir
			'
			Me.TxtNbAvoir.Location = New System.Drawing.Point(56, 152)
			Me.TxtNbAvoir.Name = "TxtNbAvoir"
			Me.TxtNbAvoir.Size = New System.Drawing.Size(40, 20)
			Me.TxtNbAvoir.TabIndex = 3
			Me.TxtNbAvoir.Text = ""
			'
			'MainForm
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(296, 351)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.TxtEsp)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.TxtNbChk)
			Me.Controls.Add(Me.TxtTotalChk)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.TxtTotalTR)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.TxtNbAvoir)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.TxtTotalAvoir)
			Me.Controls.Add(Me.BtnDecode)
			Me.Controls.Add(Me.TxtNbTR)
			Me.Controls.Add(Me.TxtTotalCaisse)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = false
			Me.MinimizeBox = false
			Me.Name = "MainForm"
			Me.Text = "Decoder les Tickets"
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		
		
		Private Sub BtnDecodeClick(sender As System.Object, e As System.EventArgs)
			If BtnDecode.Text="DECODER" Then
				TxtTotalCaisse.text=Decode(TxtTotalCaisse.text)
				TxtNbTR.Text=Decode(TxtNbTR.Text)
				TxtTotalTR.Text=Decode(TxtTotalTR.Text)
				TxtNbAvoir.Text=Decode(TxtNbAvoir.Text)
				TxtTotalAvoir.Text=Decode(TxtTotalAvoir.Text)
				TxtNbChk.text=Decode(TxtNbChk.text)
				TxtTotalChk.Text=Decode(TxtTotalChk.Text)
				TxtEsp.text=Decode(TxtEsp.Text)
				
				BtnDecode.Text="RECODER"
			Else
				TxtTotalCaisse.text=code(TxtTotalCaisse.text)
				TxtNbTR.Text=code(TxtNbTR.Text)
				TxtTotalTR.Text=code(TxtTotalTR.Text)
				TxtNbAvoir.Text=code(TxtNbAvoir.Text)
				TxtTotalAvoir.Text=code(TxtTotalAvoir.Text)
				TxtNbChk.text=code(TxtNbChk.text)
				TxtTotalChk.Text=code(TxtTotalChk.Text)
				TxtEsp.text=code(TxtEsp.Text)
				
				BtnDecode.Text="DECODER"
			End If		
		End Sub
		
		Private Function Code(ByVal TextACoder As String)
			Dim TextCoder As String=""
						
			For i As Integer =0 To TextACoder.Length-1
				Select Case TextACoder.chars(i)
				Case "0"
					TextCoder+="F"
				Case "1"
					TextCoder+="N"	
				Case "2"
					TextCoder+="Q"					
				Case "3"
					TextCoder+="P"
				Case "4"
					TextCoder+="C"
				Case "5"
					TextCoder+="R"
				Case "6"
					TextCoder+="L"
				Case "7"
					TextCoder+="W"
				Case "8"
					TextCoder+="B"
				Case "9"
					TextCoder+="X"
				Case ","
					TextCoder+="I"
				End Select
			Next
			
		Code=textCoder
		End Function
		
		Private Function Decode(ByVal TextADecoder As String)
			Dim Text As String=""			
			
			For i As Integer =0 To TextADeCoder.Length-1
				Select Case TextADeCoder.chars(i)
				Case "F"
					Text+="0"
				Case "N"
					Text+="1"	
				Case "Q"
					Text+="2"					
				Case "P"
					Text+="3"
				Case "C"
					Text+="4"
				Case "R"
					Text+="5"
				Case "L"
					Text+="6"
				Case "W"
					Text+="7"
				Case "B"
					Text+="8"
				Case "X"
					Text+="9"	
				Case "I"
					Text+=","	
				End Select
			Next
			
		Decode=text
		End Function
	End Class
End Namespace
