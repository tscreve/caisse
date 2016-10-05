'
' Created by SharpDevelop.
' User: Admin
' Date: 19/08/2007
' Time: 01:09
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.PointOfService

Namespace q
	
	Public Class FrmAvance
		Inherits System.Windows.Forms.Form
		Private BtnHeureCaisse As System.Windows.Forms.Button
		Private BtnCode As System.Windows.Forms.Button
		Private TxtCode As System.Windows.Forms.TextBox
		Private button3 As System.Windows.Forms.Button
		Private button1 As System.Windows.Forms.Button
		Private button10 As System.Windows.Forms.Button
		Private button11 As System.Windows.Forms.Button
		Private button5 As System.Windows.Forms.Button
		Private button4 As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private button9 As System.Windows.Forms.Button
		Private button8 As System.Windows.Forms.Button
		Private BtnC As System.Windows.Forms.Button
		Private BtnReleveCaisse As System.Windows.Forms.Button
		Private BtnAnnul As System.Windows.Forms.Button
		Private button7 As System.Windows.Forms.Button
		Private button6 As System.Windows.Forms.Button
		Private BtnTiroir As System.Windows.Forms.Button
		
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
			Me.BtnTiroir = New System.Windows.Forms.Button
			Me.button6 = New System.Windows.Forms.Button
			Me.button7 = New System.Windows.Forms.Button
			Me.BtnAnnul = New System.Windows.Forms.Button
			Me.BtnReleveCaisse = New System.Windows.Forms.Button
			Me.BtnC = New System.Windows.Forms.Button
			Me.button8 = New System.Windows.Forms.Button
			Me.button9 = New System.Windows.Forms.Button
			Me.groupBox1 = New System.Windows.Forms.GroupBox
			Me.button4 = New System.Windows.Forms.Button
			Me.button5 = New System.Windows.Forms.Button
			Me.button11 = New System.Windows.Forms.Button
			Me.button10 = New System.Windows.Forms.Button
			Me.button1 = New System.Windows.Forms.Button
			Me.button3 = New System.Windows.Forms.Button
			Me.TxtCode = New System.Windows.Forms.TextBox
			Me.BtnCode = New System.Windows.Forms.Button
			Me.BtnHeureCaisse = New System.Windows.Forms.Button
			Me.groupBox1.SuspendLayout
			Me.SuspendLayout
			'
			'BtnTiroir
			'
			Me.BtnTiroir.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnTiroir.Location = New System.Drawing.Point(8, 8)
			Me.BtnTiroir.Name = "BtnTiroir"
			Me.BtnTiroir.Size = New System.Drawing.Size(96, 64)
			Me.BtnTiroir.TabIndex = 0
			Me.BtnTiroir.Text = "OUVRIR TIROIR"
			AddHandler Me.BtnTiroir.Click, AddressOf Me.BtnTiroirClick
			'
			'button6
			'
			Me.button6.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button6.Location = New System.Drawing.Point(56, 120)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(56, 56)
			Me.button6.TabIndex = 4
			Me.button6.Text = "8"
			AddHandler Me.button6.Click, AddressOf Me.Button6Click
			'
			'button7
			'
			Me.button7.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button7.Location = New System.Drawing.Point(0, 120)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(56, 56)
			Me.button7.TabIndex = 5
			Me.button7.Text = "7"
			AddHandler Me.button7.Click, AddressOf Me.Button7Click
			'
			'BtnAnnul
			'
			Me.BtnAnnul.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAnnul.Location = New System.Drawing.Point(288, 296)
			Me.BtnAnnul.Name = "BtnAnnul"
			Me.BtnAnnul.Size = New System.Drawing.Size(96, 40)
			Me.BtnAnnul.TabIndex = 3
			Me.BtnAnnul.Text = "Annuler"
			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
			'
			'BtnReleveCaisse
			'
			Me.BtnReleveCaisse.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnReleveCaisse.Location = New System.Drawing.Point(8, 80)
			Me.BtnReleveCaisse.Name = "BtnReleveCaisse"
			Me.BtnReleveCaisse.Size = New System.Drawing.Size(96, 64)
			Me.BtnReleveCaisse.TabIndex = 1
			Me.BtnReleveCaisse.Text = "RELEVE DE LA CAISSE"
			AddHandler Me.BtnReleveCaisse.Click, AddressOf Me.BtnReleveCaisseClick
			'
			'BtnC
			'
			Me.BtnC.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnC.Location = New System.Drawing.Point(56, 176)
			Me.BtnC.Name = "BtnC"
			Me.BtnC.Size = New System.Drawing.Size(112, 56)
			Me.BtnC.TabIndex = 10
			Me.BtnC.Text = "Effacer"
			AddHandler Me.BtnC.Click, AddressOf Me.BtnCClick
			'
			'button8
			'
			Me.button8.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button8.Location = New System.Drawing.Point(56, 64)
			Me.button8.Name = "button8"
			Me.button8.Size = New System.Drawing.Size(56, 56)
			Me.button8.TabIndex = 6
			Me.button8.Text = "5"
			AddHandler Me.button8.Click, AddressOf Me.Button8Click
			'
			'button9
			'
			Me.button9.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button9.Location = New System.Drawing.Point(56, 8)
			Me.button9.Name = "button9"
			Me.button9.Size = New System.Drawing.Size(56, 56)
			Me.button9.TabIndex = 7
			Me.button9.Text = "2"
			AddHandler Me.button9.Click, AddressOf Me.Button9Click
			'
			'groupBox1
			'
			Me.groupBox1.Controls.Add(Me.TxtCode)
			Me.groupBox1.Controls.Add(Me.BtnC)
			Me.groupBox1.Controls.Add(Me.button11)
			Me.groupBox1.Controls.Add(Me.button10)
			Me.groupBox1.Controls.Add(Me.button9)
			Me.groupBox1.Controls.Add(Me.button4)
			Me.groupBox1.Controls.Add(Me.button3)
			Me.groupBox1.Controls.Add(Me.button8)
			Me.groupBox1.Controls.Add(Me.button7)
			Me.groupBox1.Controls.Add(Me.button6)
			Me.groupBox1.Controls.Add(Me.button5)
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Location = New System.Drawing.Point(216, 8)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(168, 256)
			Me.groupBox1.TabIndex = 5
			Me.groupBox1.TabStop = false
			'
			'button4
			'
			Me.button4.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button4.Location = New System.Drawing.Point(112, 8)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(56, 56)
			Me.button4.TabIndex = 2
			Me.button4.Text = "3"
			AddHandler Me.button4.Click, AddressOf Me.Button4Click
			'
			'button5
			'
			Me.button5.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button5.Location = New System.Drawing.Point(112, 64)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(56, 56)
			Me.button5.TabIndex = 3
			Me.button5.Text = "6"
			AddHandler Me.button5.Click, AddressOf Me.Button5Click
			'
			'button11
			'
			Me.button11.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button11.Location = New System.Drawing.Point(112, 120)
			Me.button11.Name = "button11"
			Me.button11.Size = New System.Drawing.Size(56, 56)
			Me.button11.TabIndex = 9
			Me.button11.Text = "9"
			AddHandler Me.button11.Click, AddressOf Me.Button11Click
			'
			'button10
			'
			Me.button10.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button10.Location = New System.Drawing.Point(0, 8)
			Me.button10.Name = "button10"
			Me.button10.Size = New System.Drawing.Size(56, 56)
			Me.button10.TabIndex = 8
			Me.button10.Text = "1"
			AddHandler Me.button10.Click, AddressOf Me.Button10Click
			'
			'button1
			'
			Me.button1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button1.Location = New System.Drawing.Point(0, 176)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(56, 56)
			Me.button1.TabIndex = 0
			Me.button1.Text = "0"
			AddHandler Me.button1.Click, AddressOf Me.Button1Click
			'
			'button3
			'
			Me.button3.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.button3.Location = New System.Drawing.Point(0, 64)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(56, 56)
			Me.button3.TabIndex = 1
			Me.button3.Text = "4"
			AddHandler Me.button3.Click, AddressOf Me.Button3Click
			'
			'TxtCode
			'
			Me.TxtCode.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.TxtCode.Location = New System.Drawing.Point(0, 232)
			Me.TxtCode.Name = "TxtCode"
			Me.TxtCode.PasswordChar = Microsoft.VisualBasic.ChrW(88)
			Me.TxtCode.ReadOnly = true
			Me.TxtCode.Size = New System.Drawing.Size(168, 22)
			Me.TxtCode.TabIndex = 11
			Me.TxtCode.Text = ""
			'
			'BtnCode
			'
			Me.BtnCode.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnCode.Location = New System.Drawing.Point(8, 200)
			Me.BtnCode.Name = "BtnCode"
			Me.BtnCode.Size = New System.Drawing.Size(96, 40)
			Me.BtnCode.TabIndex = 6
			Me.BtnCode.Text = "Codes"
			AddHandler Me.BtnCode.Click, AddressOf Me.BtnCodeClick
			'
			'BtnHeureCaisse
			'
			Me.BtnHeureCaisse.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnHeureCaisse.Location = New System.Drawing.Point(8, 248)
			Me.BtnHeureCaisse.Name = "BtnHeureCaisse"
			Me.BtnHeureCaisse.Size = New System.Drawing.Size(96, 40)
			Me.BtnHeureCaisse.TabIndex = 2
			Me.BtnHeureCaisse.Text = "Heures des caisses"
			AddHandler Me.BtnHeureCaisse.Click, AddressOf Me.BtnHeureCaisseClick
			'
			'FrmAvance
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.BackColor = System.Drawing.Color.DimGray
			Me.ClientSize = New System.Drawing.Size(392, 341)
			Me.ControlBox = false
			Me.Controls.Add(Me.BtnCode)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.BtnAnnul)
			Me.Controls.Add(Me.BtnHeureCaisse)
			Me.Controls.Add(Me.BtnReleveCaisse)
			Me.Controls.Add(Me.BtnTiroir)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "FrmAvance"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "MENU AVANCE"
			Me.groupBox1.ResumeLayout(false)
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		Private Sub BtnAnnulClick(sender As System.Object, e As System.EventArgs)
			Me.close
			
		End Sub
		
		Private Sub Button10Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button9Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button4Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button3Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button8Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button5Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button7Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button6Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button11Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub Button1Click(sender As System.Object, e As System.EventArgs)
			TxtCode.Text+=sender.text
			
		End Sub
		
		Private Sub BtnCClick(sender As System.Object, e As System.EventArgs)
			TxtCode.Text=""
			
		End Sub
		
		Private Sub BtnTiroirClick(sender As System.Object, e As System.EventArgs)
			Select Case TxtCode.Text
				Case Config(4), Config(5)
					Try
		           		g_Drawer.OpenDrawer()
		           		Me.close
		            Catch ex As PosControlException
		            	MessageBox.Show(ex.message, "Erreur Tiroir !", MessageBoxButtons.OK, MessageBoxIcon.Error )						            			
			        End Try
			        
			        Me.Close
				Case Else
					Dim Frm As New FrmErreur
				
					Frm.lbltext.text="MAUVAIS CODE !!"
					Frm.showdialog
					
					TxtCode.clear
					Exit Sub
			End Select
		End Sub
		
		Private Sub BtnHeureCaisseClick(sender As System.Object, e As System.EventArgs)
			If Txtcode.Text=Config(5) Then
				Dim Frm as New FrmHeureCaisse
				Frm.showdialog	
			End If
					
		End Sub
		
		Private Sub BtnCodeClick(sender As System.Object, e As System.EventArgs)
			Select Case TxtCode.Text
				Case Config(4), Config(5)
					Dim Frm As New FrmChangeCode
			
					Frm.ShowDialog			
				Case Else
					Dim Frm As New FrmErreur
				
					Frm.lbltext.text="MAUVAIS CODE !!"
					Frm.showdialog
					
					TxtCode.clear
					Exit Sub
			End Select			
		End Sub
		

		Private Sub BtnReleveCaisseClick(sender As System.Object, e As System.EventArgs)
			If Txtcode.Text=Config(5) Then
				Dim Frm as New FrmReleveCaisse
				Frm.showdialog	
			Else
				Dim Frm As New FrmErreur
				
				Frm.lbltext.text="MAUVAIS CODE !!"
				Frm.showdialog
					
				TxtCode.clear
			End If
			
		End Sub

End Class
End Namespace
