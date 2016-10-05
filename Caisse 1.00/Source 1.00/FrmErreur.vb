'
' Created by SharpDevelop.
' User: Admin
' Date: 03/01/2007
' Time: 22:13
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace q
	
	Public Class FrmErreur
		Inherits System.Windows.Forms.Form
		Public LblText As System.Windows.Forms.Label
		Private BtnOk As System.Windows.Forms.Button
		
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
			Me.BtnOk = New System.Windows.Forms.Button
			Me.LblText = New System.Windows.Forms.Label
			Me.SuspendLayout
			'
			'BtnOk
			'
			Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
			Me.BtnOk.Location = New System.Drawing.Point(16, 72)
			Me.BtnOk.Name = "BtnOk"
			Me.BtnOk.Size = New System.Drawing.Size(136, 42)
			Me.BtnOk.TabIndex = 0
			Me.BtnOk.Text = "OK"
			AddHandler Me.BtnOk.Click, AddressOf Me.BtnOkClick
			'
			'LblText
			'
			Me.LblText.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold)
			Me.LblText.Location = New System.Drawing.Point(8, 16)
			Me.LblText.Name = "LblText"
			Me.LblText.Size = New System.Drawing.Size(160, 32)
			Me.LblText.TabIndex = 1
			Me.LblText.Text = "label1"
			Me.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'FrmErreur
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(170, 127)
			Me.ControlBox = false
			Me.Controls.Add(Me.LblText)
			Me.Controls.Add(Me.BtnOk)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "FrmErreur"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Erreur"
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		Private Sub BtnOkClick(sender As System.Object, e As System.EventArgs)
			Me.close
			
		End Sub
		
	End Class
End Namespace
