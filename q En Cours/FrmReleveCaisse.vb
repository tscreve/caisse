'
' Created by SharpDevelop.
' User: Admin
' Date: 19/08/2007
' Time: 03:16
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace q
	
	Public Class FrmReleveCaisse
		Inherits System.Windows.Forms.Form
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private BtnPrint As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label
		Private BtnAnnul As System.Windows.Forms.Button
		Private textBox4 As System.Windows.Forms.TextBox
		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox3 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		
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
			Me.textBox2 = New System.Windows.Forms.TextBox
			Me.textBox3 = New System.Windows.Forms.TextBox
			Me.textBox1 = New System.Windows.Forms.TextBox
			Me.textBox4 = New System.Windows.Forms.TextBox
			Me.BtnAnnul = New System.Windows.Forms.Button
			Me.label4 = New System.Windows.Forms.Label
			Me.BtnPrint = New System.Windows.Forms.Button
			Me.groupBox1 = New System.Windows.Forms.GroupBox
			Me.label1 = New System.Windows.Forms.Label
			Me.label2 = New System.Windows.Forms.Label
			Me.label3 = New System.Windows.Forms.Label
			Me.groupBox1.SuspendLayout
			Me.SuspendLayout
			'
			'textBox2
			'
			Me.textBox2.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.textBox2.Location = New System.Drawing.Point(112, 64)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.TabIndex = 7
			Me.textBox2.Text = ""
			'
			'textBox3
			'
			Me.textBox3.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.textBox3.Location = New System.Drawing.Point(112, 32)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.TabIndex = 8
			Me.textBox3.Text = ""
			'
			'textBox1
			'
			Me.textBox1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.textBox1.Location = New System.Drawing.Point(128, 144)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.TabIndex = 6
			Me.textBox1.Text = ""
			'
			'textBox4
			'
			Me.textBox4.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.textBox4.Location = New System.Drawing.Point(128, 176)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.TabIndex = 9
			Me.textBox4.Text = ""
			'
			'BtnAnnul
			'
			Me.BtnAnnul.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAnnul.Location = New System.Drawing.Point(16, 216)
			Me.BtnAnnul.Name = "BtnAnnul"
			Me.BtnAnnul.TabIndex = 0
			Me.BtnAnnul.Text = "Annuler"
			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
			'
			'label4
			'
			Me.label4.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label4.Location = New System.Drawing.Point(8, 144)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(120, 23)
			Me.label4.TabIndex = 5
			Me.label4.Text = "Total de la caisse :"
			'
			'BtnPrint
			'
			Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnPrint.Location = New System.Drawing.Point(152, 216)
			Me.BtnPrint.Name = "BtnPrint"
			Me.BtnPrint.TabIndex = 1
			Me.BtnPrint.Text = "Imprimer"
			'
			'groupBox1
			'
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.textBox2)
			Me.groupBox1.Controls.Add(Me.textBox3)
			Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.groupBox1.Location = New System.Drawing.Point(8, 8)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(232, 104)
			Me.groupBox1.TabIndex = 10
			Me.groupBox1.TabStop = false
			Me.groupBox1.Text = "Depuis la derniere Caisse"
			'
			'label1
			'
			Me.label1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label1.Location = New System.Drawing.Point(8, 176)
			Me.label1.Name = "label1"
			Me.label1.TabIndex = 2
			Me.label1.Text = "Total Client :"
			'
			'label2
			'
			Me.label2.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label2.Location = New System.Drawing.Point(8, 64)
			Me.label2.Name = "label2"
			Me.label2.TabIndex = 3
			Me.label2.Text = "Clients :"
			'
			'label3
			'
			Me.label3.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.label3.Location = New System.Drawing.Point(8, 32)
			Me.label3.Name = "label3"
			Me.label3.TabIndex = 4
			Me.label3.Text = "Chiffre :"
			'
			'FrmReleveCaisse
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(248, 253)
			Me.ControlBox = false
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.textBox4)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.BtnPrint)
			Me.Controls.Add(Me.BtnAnnul)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "FrmReleveCaisse"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "RELEVE CAISSE"
			Me.groupBox1.ResumeLayout(false)
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		Private Sub BtnAnnulClick(sender As System.Object, e As System.EventArgs)
			me.Close
			
		End Sub
		
	End Class
End Namespace
