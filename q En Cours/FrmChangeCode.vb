'
' Created by SharpDevelop.
' User: Admin
' Date: 19/08/2007
' Time: 03:17
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Namespace q
	
	Public Class FrmChangeCode
		Inherits System.Windows.Forms.Form
		Private BtnAnnul As System.Windows.Forms.Button
		Private BtnNewCode As System.Windows.Forms.Button
		Private button3 As System.Windows.Forms.Button
		Private button1 As System.Windows.Forms.Button
		Private BtnConfirmCode As System.Windows.Forms.Button
		Private button10 As System.Windows.Forms.Button
		Private button11 As System.Windows.Forms.Button
		Private button5 As System.Windows.Forms.Button
		Private button4 As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private button9 As System.Windows.Forms.Button
		Private button8 As System.Windows.Forms.Button
		Private BtnC As System.Windows.Forms.Button
		Private BtnValid As System.Windows.Forms.Button
		Private TxtNewCode As System.Windows.Forms.TextBox
		Private button7 As System.Windows.Forms.Button
		Private TxtConfirmCode As System.Windows.Forms.TextBox
		Private button6 As System.Windows.Forms.Button
		
		Public FlagConfirm As Boolean = False
		
		
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
			Me.button6 = New System.Windows.Forms.Button
			Me.TxtConfirmCode = New System.Windows.Forms.TextBox
			Me.button7 = New System.Windows.Forms.Button
			Me.TxtNewCode = New System.Windows.Forms.TextBox
			Me.BtnValid = New System.Windows.Forms.Button
			Me.BtnC = New System.Windows.Forms.Button
			Me.button8 = New System.Windows.Forms.Button
			Me.button9 = New System.Windows.Forms.Button
			Me.groupBox1 = New System.Windows.Forms.GroupBox
			Me.button4 = New System.Windows.Forms.Button
			Me.button5 = New System.Windows.Forms.Button
			Me.button11 = New System.Windows.Forms.Button
			Me.button10 = New System.Windows.Forms.Button
			Me.BtnConfirmCode = New System.Windows.Forms.Button
			Me.button1 = New System.Windows.Forms.Button
			Me.button3 = New System.Windows.Forms.Button
			Me.BtnNewCode = New System.Windows.Forms.Button
			Me.BtnAnnul = New System.Windows.Forms.Button
			Me.groupBox1.SuspendLayout
			Me.SuspendLayout
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
			'TxtConfirmCode
			'
			Me.TxtConfirmCode.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.TxtConfirmCode.Location = New System.Drawing.Point(32, 200)
			Me.TxtConfirmCode.Name = "TxtConfirmCode"
			Me.TxtConfirmCode.PasswordChar = Microsoft.VisualBasic.ChrW(88)
			Me.TxtConfirmCode.ReadOnly = true
			Me.TxtConfirmCode.Size = New System.Drawing.Size(128, 22)
			Me.TxtConfirmCode.TabIndex = 16
			Me.TxtConfirmCode.Text = ""
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
			'TxtNewCode
			'
			Me.TxtNewCode.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.TxtNewCode.Location = New System.Drawing.Point(32, 88)
			Me.TxtNewCode.MaxLength = 4
			Me.TxtNewCode.Name = "TxtNewCode"
			Me.TxtNewCode.PasswordChar = Microsoft.VisualBasic.ChrW(88)
			Me.TxtNewCode.ReadOnly = true
			Me.TxtNewCode.Size = New System.Drawing.Size(128, 22)
			Me.TxtNewCode.TabIndex = 11
			Me.TxtNewCode.Text = ""
			'
			'BtnValid
			'
			Me.BtnValid.Enabled = false
			Me.BtnValid.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnValid.Location = New System.Drawing.Point(280, 288)
			Me.BtnValid.Name = "BtnValid"
			Me.BtnValid.Size = New System.Drawing.Size(104, 40)
			Me.BtnValid.TabIndex = 13
			Me.BtnValid.Text = "Valider"
			AddHandler Me.BtnValid.Click, AddressOf Me.BtnValidClick
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
			Me.groupBox1.Enabled = false
			Me.groupBox1.Location = New System.Drawing.Point(216, 8)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(168, 232)
			Me.groupBox1.TabIndex = 6
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
			'BtnConfirmCode
			'
			Me.BtnConfirmCode.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnConfirmCode.Location = New System.Drawing.Point(32, 152)
			Me.BtnConfirmCode.Name = "BtnConfirmCode"
			Me.BtnConfirmCode.Size = New System.Drawing.Size(128, 40)
			Me.BtnConfirmCode.TabIndex = 14
			Me.BtnConfirmCode.Text = "Confirmer Code"
			AddHandler Me.BtnConfirmCode.Click, AddressOf Me.BtnConfirmCodeClick
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
			'BtnNewCode
			'
			Me.BtnNewCode.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnNewCode.Location = New System.Drawing.Point(32, 40)
			Me.BtnNewCode.Name = "BtnNewCode"
			Me.BtnNewCode.Size = New System.Drawing.Size(128, 40)
			Me.BtnNewCode.TabIndex = 15
			Me.BtnNewCode.Text = "Nouveau Code"
			AddHandler Me.BtnNewCode.Click, AddressOf Me.BtnNewCodeClick
			'
			'BtnAnnul
			'
			Me.BtnAnnul.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAnnul.Location = New System.Drawing.Point(8, 288)
			Me.BtnAnnul.Name = "BtnAnnul"
			Me.BtnAnnul.Size = New System.Drawing.Size(104, 40)
			Me.BtnAnnul.TabIndex = 12
			Me.BtnAnnul.Text = "Annuler"
			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
			'
			'FrmChangeCode
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(390, 339)
			Me.ControlBox = false
			Me.Controls.Add(Me.TxtConfirmCode)
			Me.Controls.Add(Me.BtnNewCode)
			Me.Controls.Add(Me.BtnConfirmCode)
			Me.Controls.Add(Me.BtnValid)
			Me.Controls.Add(Me.BtnAnnul)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.TxtNewCode)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "FrmChangeCode"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "CHANGER CODE"
			Me.groupBox1.ResumeLayout(false)
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		Private Sub BtnAnnulClick(sender As System.Object, e As System.EventArgs)
			Me.Close
			
			
		End Sub
		
		Private Sub BtnNewCodeClick(sender As System.Object, e As System.EventArgs)
			TxtNewCode.Text=""
			groupbox1.Enabled=true
			
		End Sub
		
		Private Sub BtnCClick(sender As System.Object, e As System.EventArgs)
			If FlagConfirm=True Then
				TxtConfirmCode.Text=""
			Else
				TxtNewCode.Text=""
			End If
			
		End Sub
		
		Private Sub Button10Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub AddCharCode(CharCode As Char)
			Select Case FlagConfirm
				Case False
					If TxtNewCode.Text.Length<4 Then
						txtNewCode.Text+=CharCode					
					End If
				Case True
					If TxtConfirmCode.Text.Length<4 Then
						TxtConfirmCode.Text+=CharCode					
					End If
			End Select
			
			
		End Sub
		Private Sub Button9Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button4Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button3Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button8Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button5Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button7Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button6Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button11Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub Button1Click(sender As System.Object, e As System.EventArgs)
			AddCharCode(sender.text)
			
		End Sub
		
		Private Sub BtnConfirmCodeClick(sender As System.Object, e As System.EventArgs)
			If TxtNewCode.Text <> "" Then
				FlagConfirm=True
				BtnValid.Enabled=true
			End If
		End Sub
		
		Private Sub BtnValidClick(sender As System.Object, e As System.EventArgs)
			If txtNewCode.Text=TxtConfirmCode.Text Then		    	
		    	Config(4)=txtNewCode.Text  	
		    	WriteConfig()
		    	Me.Close
		    Else
		    	Dim Frm As New FrmErreur
				
				Frm.lbltext.text="Les codes ne correspondent pas  !!"
				Frm.showdialog
				FlagConfirm=False
				
				Exit Sub
			End If
			
		End Sub
		
	End Class
End Namespace
