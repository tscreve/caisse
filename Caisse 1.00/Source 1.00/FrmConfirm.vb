'
' Created by SharpDevelop.
' User: Admin
' Date: 02/01/2007
' Time: 23:16
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace q
	
	Public Class FrmConfirm
		Inherits System.Windows.Forms.Form
		Public LblText As System.Windows.Forms.Label
		Public BtnOui As System.Windows.Forms.Button
		Public BtnNon As System.Windows.Forms.Button
		
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
			Me.BtnNon = New System.Windows.Forms.Button
			Me.BtnOui = New System.Windows.Forms.Button
			Me.LblText = New System.Windows.Forms.Label
			Me.SuspendLayout
			'
			'BtnNon
			'
			Me.BtnNon.DialogResult = System.Windows.Forms.DialogResult.No
			Me.BtnNon.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
			Me.BtnNon.Location = New System.Drawing.Point(232, 112)
			Me.BtnNon.Name = "BtnNon"
			Me.BtnNon.Size = New System.Drawing.Size(110, 42)
			Me.BtnNon.TabIndex = 1
			Me.BtnNon.Text = "Non"
			AddHandler Me.BtnNon.Click, AddressOf Me.BtnNonClick
			'
			'BtnOui
			'
			Me.BtnOui.BackColor = System.Drawing.SystemColors.Control
			Me.BtnOui.DialogResult = System.Windows.Forms.DialogResult.Yes
			Me.BtnOui.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnOui.ForeColor = System.Drawing.SystemColors.ControlText
			Me.BtnOui.Location = New System.Drawing.Point(16, 112)
			Me.BtnOui.Name = "BtnOui"
			Me.BtnOui.Size = New System.Drawing.Size(110, 40)
			Me.BtnOui.TabIndex = 0
			Me.BtnOui.Text = "Oui"
			'
			'LblText
			'
			Me.LblText.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold)
			Me.LblText.Location = New System.Drawing.Point(16, 16)
			Me.LblText.Name = "LblText"
			Me.LblText.Size = New System.Drawing.Size(328, 80)
			Me.LblText.TabIndex = 2
			Me.LblText.Text = "LblText"
			Me.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'FrmConfirm
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(354, 167)
			Me.ControlBox = false
			Me.Controls.Add(Me.LblText)
			Me.Controls.Add(Me.BtnNon)
			Me.Controls.Add(Me.BtnOui)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "FrmConfirm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "FrmConfirm"
			Me.TopMost = true
			Me.ResumeLayout(false)
		End Sub
		#End Region
		
		Private Sub BtnNonClick(sender As System.Object, e As System.EventArgs)
			Me.close			
		End Sub
	End Class
End Namespace
