'
' Created by SharpDevelop.
' User: Admin
' Date: 19/08/2007
' Time: 03:18
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace q
	
	Public Class FrmHeureCaisse
		Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private BtnAnnul As System.Windows.Forms.Button
		Private BtnValid As System.Windows.Forms.Button
		Private checkBox4 As System.Windows.Forms.CheckBox
		Private checkBox2 As System.Windows.Forms.CheckBox
		Private checkBox3 As System.Windows.Forms.CheckBox
		Private checkBox1 As System.Windows.Forms.CheckBox
		
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
			Me.checkBox1 = New System.Windows.Forms.CheckBox
			Me.checkBox3 = New System.Windows.Forms.CheckBox
			Me.checkBox2 = New System.Windows.Forms.CheckBox
			Me.checkBox4 = New System.Windows.Forms.CheckBox
			Me.BtnValid = New System.Windows.Forms.Button
			Me.BtnAnnul = New System.Windows.Forms.Button
			Me.label1 = New System.Windows.Forms.Label
			Me.SuspendLayout
			'
			'checkBox1
			'
			Me.checkBox1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.checkBox1.Location = New System.Drawing.Point(88, 48)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.TabIndex = 0
			Me.checkBox1.Text = "11 H"
			AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
			'
			'checkBox3
			'
			Me.checkBox3.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.checkBox3.Location = New System.Drawing.Point(88, 144)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.TabIndex = 2
			Me.checkBox3.Text = "Fermeture"
			AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
			'
			'checkBox2
			'
			Me.checkBox2.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.checkBox2.Location = New System.Drawing.Point(88, 112)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.TabIndex = 1
			Me.checkBox2.Text = "14 H"
			AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
			'
			'checkBox4
			'
			Me.checkBox4.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.checkBox4.Location = New System.Drawing.Point(88, 80)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.TabIndex = 3
			Me.checkBox4.Text = "13 H"
			AddHandler Me.checkBox4.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
			'
			'BtnValid
			'
			Me.BtnValid.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnValid.Location = New System.Drawing.Point(168, 184)
			Me.BtnValid.Name = "BtnValid"
			Me.BtnValid.TabIndex = 5
			Me.BtnValid.Text = "Valider"
			AddHandler Me.BtnValid.Click, AddressOf Me.BtnValidClick
			'
			'BtnAnnul
			'
			Me.BtnAnnul.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAnnul.Location = New System.Drawing.Point(48, 184)
			Me.BtnAnnul.Name = "BtnAnnul"
			Me.BtnAnnul.TabIndex = 4
			Me.BtnAnnul.Text = "Annuler"
			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
			'
			'label1
			'
			Me.label1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(280, 32)
			Me.label1.TabIndex = 6
			Me.label1.Text = "Selectionner les heures pour faire la caisse :"
			'
			'FrmHeureCaisse
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(280, 221)
			Me.ControlBox = false
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.BtnValid)
			Me.Controls.Add(Me.BtnAnnul)
			Me.Controls.Add(Me.checkBox4)
			Me.Controls.Add(Me.checkBox3)
			Me.Controls.Add(Me.checkBox2)
			Me.Controls.Add(Me.checkBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "FrmHeureCaisse"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Heures Caisse"
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		Private Sub CheckBox1CheckedChanged(sender As System.Object, e As System.EventArgs)
			
			
		End Sub
		
		Private Sub BtnAnnulClick(sender As System.Object, e As System.EventArgs)
			Me.close
			
		End Sub
		
		Private Sub BtnValidClick(sender As System.Object, e As System.EventArgs)
			
			
		End Sub
		
	End Class
End Namespace
