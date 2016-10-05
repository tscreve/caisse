''
'' Created by SharpDevelop.
'' User: Admin
'' Date: 30/07/2006
'' Time: 11:34
'' 
'' To change this template use Tools | Options | Coding | Edit Standard Headers.
''
'Private txtReste As System.Windows.Forms.TextBox
'Private TxtArendre As System.Windows.Forms.TextBox
'Private Btn9 As System.Windows.Forms.Button
'Private Btn8 As System.Windows.Forms.Button
'Private BtnVirg As System.Windows.Forms.Button
'Private TxtAvoir As System.Windows.Forms.TextBox
'Private Btn4 As System.Windows.Forms.Button
'Private Btn7 As System.Windows.Forms.Button
'Private Btn6 As System.Windows.Forms.Button
'Private Btn1 As System.Windows.Forms.Button
'Private Btn0 As System.Windows.Forms.Button
'Private Btn3 As System.Windows.Forms.Button
'Private Btn2 As System.Windows.Forms.Button
'Private BtnValid As System.Windows.Forms.Button
'Private BtnAvoir As System.Windows.Forms.Button
'Private Btn5 As System.Windows.Forms.Button
'Private label3 As System.Windows.Forms.Label
'Private label2 As System.Windows.Forms.Label
'Private BtnAnnul As System.Windows.Forms.Button
'Private columnHeader1 As System.Windows.Forms.ColumnHeader
'Private label4 As System.Windows.Forms.Label
'Private columnHeader2 As System.Windows.Forms.ColumnHeader
'Private BtnTicket As System.Windows.Forms.Button
'Private LsVPaye As System.Windows.Forms.ListView
'Private BtnCancel As System.Windows.Forms.Button
'
'Imports System
'Imports System.Windows.Forms
'Namespace q
'	Public Class FrmPaye
'		
'		Private Btn7 As System.Windows.Forms.Button
'		
'		
'		
'		
'		
'		
'		
'		
'		
'		
'		
'		
'		
'		
'				
'			MyBase.New
'			' The Me.InitializeComponent call is required for Windows Forms designer support.
'			Me.InitializeComponent
'			' TODO : Add constructor code after InitializeComponents
'		End Sub
'		
'		#Region " Windows Forms Designer generated code "
'		' This method is required for Windows Forms designer support.
'		' Do not change the method contents inside the source code editor. The Forms designer might
'		' not be able to load this method if it was changed manually.
'		Private : Add constructor code after InitializeComponents
'			'
'		End Sub
'		
'		Private Sub InitializeComponent()
'			Me.BtnCancel = New System.Windows.Forms.Button
'			Me.LsVPaye = New System.Windows.Forms.ListView
'			Me.BtnTicket = New System.Windows.Forms.Button
'			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
'			Me.label4 = New System.Windows.Forms.Label
'			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
'			Me.BtnAnnul = New System.Windows.Forms.Button
'			Me.label2 = New System.Windows.Forms.Label
'			Me.label3 = New System.Windows.Forms.Label
'			Me.Btn5 = New System.Windows.Forms.Button
'			Me.BtnAvoir = New System.Windows.Forms.Button
'			Me.BtnValid = New System.Windows.Forms.Button
'			Me.Btn2 = New System.Windows.Forms.Button
'			Me.Btn3 = New System.Windows.Forms.Button
'			Me.Btn0 = New System.Windows.Forms.Button
'			Me.Btn1 = New System.Windows.Forms.Button
'			Me.Btn6 = New System.Windows.Forms.Button
'			Me.Btn7 = New System.Windows.Forms.Button
'			Me.Btn4 = New System.Windows.Forms.Button
'			Me.TxtAvoir = New System.Windows.Forms.TextBox
'			Me.BtnVirg = New System.Windows.Forms.Button
'			Me.Btn8 = New System.Windows.Forms.Button
'			Me.Btn9 = New System.Windows.Forms.Button
'			Me.TxtArendre = New System.Windows.Forms.TextBox
'			Me.txtRSub InitializeComponent()
'			Me.BtnCancel = New System.Windows.Forms.Button
'			Me.LsVPaye = New System.Windows.Forms.ListView
'			Me.BtnTicket = New System.Windows.Forms.Button
'			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
'			Me.label4 = New System.Windows.Forms.Label
'			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
'			Me.BtnAnnul = New System.Windows.Forms.Button
'			Me.label2 = New System.Windows.Forms.Label
'			Me.label3 = New System.Windows.Forms.Label
'			Me.Btn5 = New System.Windows.Forms.Button
'			Me.BtnAvoir = New System.Windows.Forms.Button
'			Me.BtnValid = New System.Windows.Forms.Button
'			Me.Btn2 = New System.Windows.Forms.Button
'			Me.Btn3 = New System.Windows.Forms.Button
'			Me.Btn0 = New System.Windows.Forms.Button
'			Me.Btn1 = New System.Windows.Forms.Button
'			Me.Btn6 = New System.Windows.Forms.Button
'			Me.Btn7 = New System.Windows.Forms.Button
'			Me.Btn4 = New System.Windows.Forms.Button
'			Me.TxtAvoir = New System.Windows.Forms.TextBox
'			Me.BtnVirg = New System.Windows.Forms.Button
'			Me.Btn8 = New System.Windows.Forms.Button
'			Me.Btn9 = New System.Windows.Forms.Button
'			Me.TxtArendre = New System.Windows.Forms.TextBox
'			Me.txtReste = New System.Windows.Forms.TextBox
'			Me.SuspendLayout
'			'
'			'BtnCancel
'			'
'			Me.BtnCancel.Location = New System.Drawing.Point(520, 272)
'			Me.BtnCancel.Name = "BtnCancel"
'			Me.BtnCancel.Size = New System.Drawing.Size(56, 40)
'			Me.BtnCancel.TabIndex = 59
'			Me.BtnCancel.Text = "C"
'			AddHandler Me.BtnCancel.Click, AddressOf Me.BtnCancelClick
'			'
'			'LsVPaye
'			'
'			Me.LsVPaye.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
'			Me.LsVPaye.FullRowSelect = true
'			Me.LsVPaye.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
'			Me.LsVPaye.HideSelection = false
'			Me.LsVPaye.Location = New System.Drawing.Point(24, 64)
'			Me.LsVPaye.MultiSelect = false
'			Me.LsVPaye.Name = "LsVPaye"
'			Me.LsVPaye.Size = New System.Drawing.Size(344, 152)
'			Me.LsVPaye.TabIndex = 46
'			Me.LsVPaye.View = System.Windows.Forms.View.Details
'			'
'			'BtnTicket
'			'
'			Me.BtnTicket.Location = New System.Drawing.Point(464, 312)
'			Me.BtnTicket.Name = "BtnTicket"
'			Me.BtnTicket.Size = New System.Drawing.Size(56, 40)
'			Me.BtnTicket.TabIndex = 70
'			Me.BtnTicket.Text = "Sans Ticket"
'			AddHandler Me.BtnTicket.Click, AddressOf Me.BtnTicketClick
'			'
'			'label4
'			'
'			Me.label4.Location = New System.Drawing.Point(160, 296)
'			Me.label4.Name = "label4"
'			Me.label4.TabIndex = 66
'			Me.label4.Text = "Avoir :"
'			'
'			'BtnAnnul
'			'
'			Me.BtnAnnul.Location = New System.Drawing.Point(408, 312)
'			Me.BtnAnnul.Name = "BtnAnnul"
'			Me.BtnAnnul.Size = New System.Drawing.Size(56, 40)
'			Me.BtnAnnul.TabIndex = 68
'			Me.BtnAnnul.Text = "Tout Annuler"
'			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
'			'
'			'label2
'			'
'			Me.label2.Location = New System.Drawing.Point(160, 232)
'			Me.label2.Name = "label2"
'			Me.label2.TabIndex = 60
'			Me.label2.Text = "Reste à payer :"
'			'
'			'label3
'			'
'			Me.label3.Location = New System.Drawing.Point(160, 264)
'			Me.label3.Name = "label3"
'			Me.label3.TabIndex = 65
'			Me.label3.Text = "A rendre : "
'			'
'			'Btn5
'			'
'			Me.Btn5.Location = New System.Drawing.Point(464, 192)
'			Me.Btn5.Name = "Btn5"
'			Me.Btn5.Size = New System.Drawing.Size(56, 40)
'			Me.Btn5.TabIndex = 53
'			Me.Btn5.Text = "5"
'			AddHandler Me.Btn5.Click, AddressOf Me.Btn5Click
'			'
'			'BtnAvoir
'			'
'			Me.BtnAvoir.Location = New System.Drawing.Point(440, 96)
'			Me.BtnAvoir.Name = "BtnAvoir"
'			Me.BtnAvoir.TabIndex = 44
'			Me.BtnAvoir.Text = "Avoir"
'			AddHandler Me.BtnAvoir.Click, AddressOf Me.BtnAvoirClick
'			'
'			'BtnValid
'			'
'			Me.BtnValid.Location = New System.Drawing.Point(520, 312)
'			Me.BtnValid.Name = "BtnValid"
'			Me.BtnValid.Size = New System.Drawing.Size(56, 40)
'			Me.BtnValid.TabIndex = 69
'			Me.BtnValid.Text = "Valider"
'			AddHandler Me.BtnValid.Click, AddressOf Me.BtnValidClick
'			'
'			'Btn2
'			'
'			Me.Btn2.Location = New System.Drawing.Point(464, 152)
'			Me.Btn2.Name = "Btn2"
'			Me.Btn2.Size = New System.Drawing.Size(56, 40)
'			Me.Btn2.TabIndex = 50
'			Me.Btn2.Text = "2"
'			AddHandler Me.Btn2.Click, AddressOf Me.Btn2Click
'			'
'			'Btn3
'			'
'			Me.Btn3.Location = New System.Drawing.Point(520, 152)
'			Me.Btn3.Name = "Btn3"
'			Me.Btn3.Size = New System.Drawing.Size(56, 40)
'			Me.Btn3.TabIndex = 51
'			Me.Btn3.Text = "3"
'			AddHandler Me.Btn3.Click, AddressOf Me.Btn3Click
'			'
'			'Btn0
'			'
'			Me.Btn0.Location = New System.Drawing.Point(408, 272)
'			Me.Btn0.Name = "Btn0"
'			Me.Btn0.Size = New System.Drawing.Size(56, 40)
'			Me.Btn0.TabIndex = 58
'			Me.Btn0.Text = "0"
'			AddHandler Me.Btn0.Click, AddressOf Me.Btn0Click
'			'
'			'Btn1
'			'
'			Me.Btn1.Location = New System.Drawing.Point(408, 152)
'			Me.Btn1.Name = "Btn1"
'			Me.Btn1.Size = New System.Drawing.Size(56, 40)
'			Me.Btn1.TabIndex = 49
'			Me.Btn1.Text = "1"
'			AddHandler Me.Btn1.Click, AddressOf Me.Btn1Click
'			'
'			'Btn6
'			'
'			Me.Btn6.Location = New System.Drawing.Point(520, 192)
'			Me.Btn6.Name = "Btn6"
'			Me.Btn6.Size = New System.Drawing.Size(56, 40)
'			Me.Btn6.TabIndex = 54
'			Me.Btn6.Text = "6"
'			AddHandler Me.Btn6.Click, AddressOf Me.Btn6Click
'			'
'			'Btn7
'			'
'			Me.Btn7.Location = New System.Drawing.Point(408, 232)
'			Me.Btn7.Name = "Btn7"
'			Me.Btn7.Size = New System.Drawing.Size(56, 40)
'			Me.Btn7.TabIndex = 55
'			Me.Btn7.Text = "7"
'			AddHandler Me.Btn7.Click, AddressOf Me.Btn7Click
'			'
'			'Btn4
'			'
'			Me.Btn4.Location = New System.Drawing.Point(408, 192)
'			Me.Btn4.Name = "Btn4"
'			Me.Btn4.Size = New System.Drawing.Size(56, 40)
'			Me.Btn4.TabIndex = 52
'			Me.Btn4.Text = "4"
'			AddHandler Me.Btn4.Click, AddressOf Me.Btn4Click
'			'
'			'TxtAvoir
'			'
'			Me.TxtAvoir.Location = New System.Drawing.Point(264, 296)
'			Me.TxtAvoir.Name = "TxtAvoir"
'			Me.TxtAvoir.TabIndex = 64
'			Me.TxtAvoir.Text = ""
'			'
'			'BtnVirg
'			'
'			Me.BtnVirg.Location = New System.Drawing.Point(464, 272)
'			Me.BtnVirg.Name = "BtnVirg"
'			Me.BtnVirg.Size = New System.Drawing.Size(56, 40)
'			Me.BtnVirg.TabIndex = 62
'			Me.BtnVirg.Text = ","
'			AddHandler Me.BtnVirg.Click, AddressOf Me.BtnVirgClick
'			'
'			'Btn8
'			'
'			Me.Btn8.Location = New System.Drawing.Point(464, 232)
'			Me.Btn8.Name = "Btn8"
'			Me.Btn8.Size = New System.Drawing.Size(56, 40)
'			Me.Btn8.TabIndex = 56
'			Me.Btn8.Text = "8"
'			AddHandler Me.Btn8.Click, AddressOf Me.Btn8Click
'			'
'			'Btn9
'			'
'			Me.Btn9.Location = New System.Drawing.Point(520, 232)
'			Me.Btn9.Name = "Btn9"
'			Me.Btn9.Size = New System.Drawing.Size(56, 40)
'			Me.Btn9.TabIndex = 57
'			Me.Btn9.Text = "9"
'			AddHandler Me.Btn9.Click, AddressOf Me.Btn9Click
'			'
'			'TxtArendre
'			'
'			Me.TxtArendre.Location = New System.Drawing.Point(264, 264)
'			Me.TxtArendre.Name = "TxtArendre"
'			Me.TxtArendre.TabIndex = 63
'			Me.TxtArendre.Text = ""
'			'
'			'txtReste
'			'
'			Me.txtReste.Location = New System.Drawing.Point(264, 232)
'			Me.txtReste.Name = "txtReste"
'			Me.txtReste.TabIndex = 61
'			Me.txtReste.Text = ""
'			'
'			'FrmPaye
'			'
'			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
'			Me.ClientSize = New System.Drawing.Size(624, 373)
'			Me.Controls.Add(Me.BtnTicket)
'			Me.Controls.Add(Me.BtnValid)
'			Me.Controls.Add(Me.BtnAnnul)
'			Me.Controls.Add(Me.label4)
'			Me.Controls.Add(Me.label3)
'			Me.Controls.Add(Me.TxtAvoir)
'			Me.Controls.Add(Me.TxtArendre)
'			Me.Controls.Add(Me.BtnVirg)
'			Me.Controls.Add(Me.txtReste)
'			Me.Controls.Add(Me.label2)
'			Me.Controls.Add(Me.BtnCancel)
'			Me.Controls.Add(Me.Btn0)
'			Me.Controls.Add(Me.Btn9)
'			Me.Controls.Add(Me.Btn8)
'			Me.Controls.Add(Me.Btn7)
'			Me.Controls.Add(Me.Btn6)
'			Me.Controls.Add(Me.Btn5)
'			Me.Controls.Add(Me.Btn4)
'			Me.Controls.Add(Me.Btn3)
'			Me.Controls.Add(Me.Btn2)
'			Me.Controls.Add(Me.Btn1)
'			Me.Controls.Add(Me.LsVPaye)
'			Me.Controls.Add(Me.BtnAvoir)
'			Me.Name = "FrmPaye"
'			Me.Text = "FrmPaye"
'			AddHandler Load, AddressOf Me.FrmPayeLoad
'			Me.ResumeLayout(false)
'		End Sund Sub
'		
'		Private Sub Btn2Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn3Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn4Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn5Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn6Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn7Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn8Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn9Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'		Private Sub Btn0Click(sender As System.Object, e As System.EventArgs)
'			lsvpaye.selecteditems(0).subitems(1).text += sender.text
'			lsvpaye.selecteditems(0).subitems(1).text = CSng(lsvpaye.selecteditems(0).subitems(1).text)
'			Calculreste()
'		End Sub
'		
'	End Class
'End Namespace
