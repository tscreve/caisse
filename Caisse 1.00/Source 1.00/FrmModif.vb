'
' Created by SharpDevelop.
' User: Admin
' Date: 17/08/2006
' Time: 20:05
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Namespace q
	
	Public Class FrmModif
		Inherits System.Windows.Forms.Form
		Public BtnSample As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		
		Public TxtTexte As System.Windows.Forms.TextBox
		Private BtnAnnul As System.Windows.Forms.Button
		Public BtnForeColor As System.Windows.Forms.Button
		Public TxtPrix As System.Windows.Forms.TextBox
		Private BtnOk As System.Windows.Forms.Button
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Public BtnBackColor As System.Windows.Forms.Button
		
		
		Dim M As q.Mainform
		
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
			Me.BtnBackColor = New System.Windows.Forms.Button
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog
			Me.BtnOk = New System.Windows.Forms.Button
			Me.TxtPrix = New System.Windows.Forms.TextBox
			Me.BtnForeColor = New System.Windows.Forms.Button
			Me.BtnAnnul = New System.Windows.Forms.Button
			Me.TxtTexte = New System.Windows.Forms.TextBox
			Me.label3 = New System.Windows.Forms.Label
			Me.label4 = New System.Windows.Forms.Label
			Me.label1 = New System.Windows.Forms.Label
			Me.label2 = New System.Windows.Forms.Label
			Me.BtnSample = New System.Windows.Forms.Button
			Me.SuspendLayout
			'
			'BtnBackColor
			'
			Me.BtnBackColor.Location = New System.Drawing.Point(120, 152)
			Me.BtnBackColor.Name = "BtnBackColor"
			Me.BtnBackColor.TabIndex = 7
			AddHandler Me.BtnBackColor.Click, AddressOf Me.BtnBackColorClick
			'
			'BtnOk
			'
			Me.BtnOk.Location = New System.Drawing.Point(112, 272)
			Me.BtnOk.Name = "BtnOk"
			Me.BtnOk.Size = New System.Drawing.Size(88, 23)
			Me.BtnOk.TabIndex = 2
			Me.BtnOk.Text = "OK"
			AddHandler Me.BtnOk.Click, AddressOf Me.BtnOkClick
			'
			'TxtPrix
			'
			Me.TxtPrix.Location = New System.Drawing.Point(96, 64)
			Me.TxtPrix.Name = "TxtPrix"
			Me.TxtPrix.Size = New System.Drawing.Size(96, 20)
			Me.TxtPrix.TabIndex = 1
			Me.TxtPrix.Text = ""
			AddHandler Me.TxtPrix.TextChanged, AddressOf Me.TxtPrixTextChanged
			'
			'BtnForeColor
			'
			Me.BtnForeColor.Location = New System.Drawing.Point(120, 112)
			Me.BtnForeColor.Name = "BtnForeColor"
			Me.BtnForeColor.TabIndex = 6
			AddHandler Me.BtnForeColor.Click, AddressOf Me.BtnForeColorClick
			'
			'BtnAnnul
			'
			Me.BtnAnnul.Location = New System.Drawing.Point(8, 272)
			Me.BtnAnnul.Name = "BtnAnnul"
			Me.BtnAnnul.Size = New System.Drawing.Size(88, 24)
			Me.BtnAnnul.TabIndex = 3
			Me.BtnAnnul.Text = "Annuler"
			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
			'
			'TxtTexte
			'
			Me.TxtTexte.Location = New System.Drawing.Point(96, 8)
			Me.TxtTexte.Multiline = true
			Me.TxtTexte.Name = "TxtTexte"
			Me.TxtTexte.Size = New System.Drawing.Size(96, 48)
			Me.TxtTexte.TabIndex = 0
			Me.TxtTexte.Text = ""
			AddHandler Me.TxtTexte.TextChanged, AddressOf Me.TxtTexteTextChanged
			'
			'label3
			'
			Me.label3.Location = New System.Drawing.Point(0, 112)
			Me.label3.Name = "label3"
			Me.label3.TabIndex = 8
			Me.label3.Text = "Couleur du Texte :"
			'
			'label4
			'
			Me.label4.Location = New System.Drawing.Point(0, 152)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(112, 23)
			Me.label4.TabIndex = 9
			Me.label4.Text = "Couleur du Bouton :"
			'
			'label1
			'
			Me.label1.Location = New System.Drawing.Point(0, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(96, 23)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Nom du produit :"
			'
			'label2
			'
			Me.label2.Location = New System.Drawing.Point(0, 64)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(88, 23)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Prix :"
			'
			'BtnSample
			'
			Me.BtnSample.Location = New System.Drawing.Point(40, 200)
			Me.BtnSample.Name = "BtnSample"
			Me.BtnSample.Size = New System.Drawing.Size(128, 58)
			Me.BtnSample.TabIndex = 10
			'
			'FrmModif
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(210, 303)
			Me.ControlBox = false
			Me.Controls.Add(Me.BtnSample)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.BtnBackColor)
			Me.Controls.Add(Me.BtnForeColor)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.BtnAnnul)
			Me.Controls.Add(Me.BtnOk)
			Me.Controls.Add(Me.TxtPrix)
			Me.Controls.Add(Me.TxtTexte)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "FrmModif"
			Me.Text = "Modifier un bouton"
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
				
		Private Sub BtnOkClick(sender As System.Object, e As System.EventArgs)				
			Dim Texte As String
			Dim Prix As String
			Dim strTexte as string
			Dim ForeColor As Color=BtnForeColor.Backcolor
			Dim BackColor as Color=BtnBackColor.Backcolor					
			
			Prix=txtprix.Text.Replace(".",",")
			Texte=txtTexte.Text
			
			strTexte=Texte.Replace((Chr(13) & Chr(10)),"")
			strTexte=strTexte.replace(" ","")
			
			If strTexte="" Then
				MessageBox.show("Entrer un nom pour ce produit!!","Erreur",0)
				txtTexte.Focus
				txtTexte.SelectAll
			End If
			
			For i As Integer=0 To Texte.Length-1
				If Texte.chars(i)="¤" Then
					MessageBox.show("Caractère : ¤ interdit!!","Erreur",0)
					txtTexte.select
					txtTexte.SelectAll
					Exit Sub
				End If
			Next
			
			If IsNumeric(Prix)=false Then
				MessageBox.show("Entrer un prix valide pour ce produit!!","Erreur",0)
				txtPrix.Focus
				txtPrix.SelectAll
				Exit Sub
			End If
			
			If CSng(Prix)=0 Then
				MessageBox.show("Entrer un prix pour ce produit!!","Erreur",0)
				txtPrix.Focus
				txtPrix.SelectAll
				Exit Sub
			End If
			Texte=txtTexte.Text & (Csng(Prix)).ToString("#,##0.00") & " €"
			
			M.ModifBtn(Texte, prix, ForeColor, BackColor)			
			close()
		End Sub
		
		Private Sub BtnAnnulClick(sender As System.Object, e As System.EventArgs)
			close()			
		End Sub
		
		Private Sub BtnForeColorClick(sender As System.Object, e As System.EventArgs)
			If Colordialog1.showdialog() = dialogresult.OK Then
				BtnSample.ForeColor=Colordialog1.Color
				sender.backcolor=Colordialog1.Color	
			End If				
		End Sub
		
		Private Sub BtnBackColorClick(sender As System.Object, e As System.EventArgs)
			If Colordialog1.showdialog() = dialogresult.OK Then
				BtnSample.BackColor=Colordialog1.Color
				sender.backcolor=Colordialog1.Color			
			End If				
		End Sub		

		Private Sub ChangeSample()
			Dim Texte As string
			Dim Prix As String
			
			Prix=txtprix.Text.Replace(".",",")
			If isnumeric(prix)=True Then				
				Texte=txtTexte.Text & Csng(Prix).ToString("#,##0.00") & " €"
			Else
				Texte=txtTexte.Text & Prix & " €"
			End If

			BtnSample.Text=Texte
		End Sub
		
		
		Private Sub TxtTexteTextChanged(sender As System.Object, e As System.EventArgs)
			ChangeSample()			
		End Sub

		Private Sub TxtPrixTextChanged(sender As System.Object, e As System.EventArgs)
			ChangeSample()			
		End Sub

	End Class
End Namespace
