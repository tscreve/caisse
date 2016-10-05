'
' Created by SharpDevelop.
' User: Admin
' Date: 04/07/2006
' Time: 19:40
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.PointOfService
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.math

Namespace q
	
	Public Class MainForm
		Inherits System.Windows.Forms.Form
		Private BtnPaye1 As System.Windows.Forms.Button
		Private components As System.ComponentModel.IContainer
		Public listBOX As System.Windows.Forms.ListView
		Private button1 As System.Windows.Forms.Button
		Private LblHeure As System.Windows.Forms.Label
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private Txt_TabAvoir_Reste As System.Windows.Forms.TextBox
		Private BtnPaye As System.Windows.Forms.Button
		Private BtnNewTR As System.Windows.Forms.Button
		Private LblDate As System.Windows.Forms.Label
		Private buttonCancel As System.Windows.Forms.Button
		Private BtnTVA As System.Windows.Forms.Button
		Private Btn_TabAvoir_Valid As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private Lbl_NbTR As System.Windows.Forms.Label
		Public BtnCaisse As System.Windows.Forms.Button
		Private BtnPay2 As System.Windows.Forms.Button
		Private BtnEspece As System.Windows.Forms.Button
		Private Btn_TabAvoir_8 As System.Windows.Forms.Button
		Private Btn_TabAvoir_1 As System.Windows.Forms.Button
		Private Btn_TabAvoir_0 As System.Windows.Forms.Button
		Private Btn_DwnNbTR As System.Windows.Forms.Button
		Private Btn_TabAvoir_2 As System.Windows.Forms.Button
		Private Btn_TabAvoir_5 As System.Windows.Forms.Button
		Private Btn_TabAvoir_4 As System.Windows.Forms.Button
		Private Btn_TabAvoir_7 As System.Windows.Forms.Button
		Private Btn_TabAvoir_6 As System.Windows.Forms.Button
		Private Lbl_TabAvoir_Reste As System.Windows.Forms.Label
		Private BtnCheq As System.Windows.Forms.Button
		Private TabPag4 As System.Windows.Forms.TabPage
		Private TabPag5 As System.Windows.Forms.TabPage
		Private TabPag6 As System.Windows.Forms.TabPage
		Private BtnEsp As System.Windows.Forms.Button
		Private TabPag0 As System.Windows.Forms.TabPage
		Private button30 As System.Windows.Forms.Button
		Private button31 As System.Windows.Forms.Button
		Private button32 As System.Windows.Forms.Button
		Private MenuCoupeBtn As System.Windows.Forms.MenuItem
		Private button34 As System.Windows.Forms.Button
		Private button35 As System.Windows.Forms.Button
		Private button36 As System.Windows.Forms.Button
		Private CMenuBtn As System.Windows.Forms.ContextMenu
		Private Btn6 As System.Windows.Forms.Button
		Private Btn0 As System.Windows.Forms.Button
		Private Btn3 As System.Windows.Forms.Button
		Private Lbl_TabTR_Avoir As System.Windows.Forms.Label
		Private BtnAnnul As System.Windows.Forms.Button
		Private TxtTotalNavig As System.Windows.Forms.TextBox
		Private Btn_TabAvoir_9 As System.Windows.Forms.Button
		Private BtnCancel As System.Windows.Forms.Button
		Private DisplayTimer As System.Windows.Forms.Timer
		Private label2 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private BtnCPay As System.Windows.Forms.Button
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private TxtTotal As System.Windows.Forms.TextBox
		Private Btn_TR_9 As System.Windows.Forms.Button
		Private Btn_TR_8 As System.Windows.Forms.Button
		Private BtnAttente As System.Windows.Forms.Button
		Private CMenu1 As System.Windows.Forms.ContextMenu
		Private DisplayTimer2 As System.Windows.Forms.Timer
		Private Btn_TR_3 As System.Windows.Forms.Button
		Private Btn_TR_2 As System.Windows.Forms.Button
		Private Btn_TR_1 As System.Windows.Forms.Button
		Private Btn_TR_0 As System.Windows.Forms.Button
		Private Btn_TR_7 As System.Windows.Forms.Button
		Private Btn_TR_6 As System.Windows.Forms.Button
		Private Btn_TR_5 As System.Windows.Forms.Button
		Private Btn_TR_4 As System.Windows.Forms.Button
		Private TabPag1 As System.Windows.Forms.TabPage
		Private TabPag2 As System.Windows.Forms.TabPage
		Private BtnValidTR As System.Windows.Forms.Button
		Private LsvTR As System.Windows.Forms.ListView
		Private BtnAvance As System.Windows.Forms.Button
		Private BtnValid As System.Windows.Forms.Button
		Private BtnVirgTR As System.Windows.Forms.Button
		Private MenuColleBtn As System.Windows.Forms.MenuItem
		Private Btn_UpNbTR As System.Windows.Forms.Button
		Private BtnPrintTicket As System.Windows.Forms.Button
		Private BtnPayVirg As System.Windows.Forms.Button
		Private columnHeader8 As System.Windows.Forms.ColumnHeader
		Private columnHeader9 As System.Windows.Forms.ColumnHeader
		Private Btn_TabAvoir_C As System.Windows.Forms.Button
		Private LblNbAvoir As System.Windows.Forms.Label
		Private columnHeader4 As System.Windows.Forms.ColumnHeader
		Private BtnPay4 As System.Windows.Forms.Button
		Private columnHeader6 As System.Windows.Forms.ColumnHeader
		Private columnHeader7 As System.Windows.Forms.ColumnHeader
		Private BtnPay1 As System.Windows.Forms.Button
		Private BtnPay0 As System.Windows.Forms.Button
		Private BtnPay3 As System.Windows.Forms.Button
		Private columnHeader3 As System.Windows.Forms.ColumnHeader
		Private BtnTicket As System.Windows.Forms.Button
		Private MenuCopieBtn As System.Windows.Forms.MenuItem
		Private LblTabAvoir_Avoir As System.Windows.Forms.Label
		Private TxtTotalTR As System.Windows.Forms.TextBox
		Private menuColleCoul As System.Windows.Forms.MenuItem
		Private BtnDownAvoir As System.Windows.Forms.Button
		Private Btn_CTR As System.Windows.Forms.Button
		Private Lbl_TabTR_Reste As System.Windows.Forms.Label
		Private menuItem3 As System.Windows.Forms.MenuItem
		Private button22 As System.Windows.Forms.Button
		Private button25 As System.Windows.Forms.Button
		Private button24 As System.Windows.Forms.Button
		Private button27 As System.Windows.Forms.Button
		Private button26 As System.Windows.Forms.Button
		Private button29 As System.Windows.Forms.Button
		Private button28 As System.Windows.Forms.Button
		Private Btn9 As System.Windows.Forms.Button
		Private Btn8 As System.Windows.Forms.Button
		Private LblARendre As System.Windows.Forms.Label
		Private Btn5 As System.Windows.Forms.Button
		Private Btn4 As System.Windows.Forms.Button
		Private Btn7 As System.Windows.Forms.Button
		Private menuCopieCoul As System.Windows.Forms.MenuItem
		Private Btn1 As System.Windows.Forms.Button
		Private Txt_TabTR_Avoir As System.Windows.Forms.TextBox
		Private tabPageAvoir As System.Windows.Forms.TabPage
		Private Btn2 As System.Windows.Forms.Button
		Public LblIdClient As System.Windows.Forms.Label
		Private BtnPay7 As System.Windows.Forms.Button
		Private BtnPay6 As System.Windows.Forms.Button
		Private BtnAnnulPay As System.Windows.Forms.Button
		Private LsvAvoir As System.Windows.Forms.ListView
		Private Txt_TabTR_Reste As System.Windows.Forms.TextBox
		Private TxtTabAvoir_Avoir As System.Windows.Forms.TextBox
		Private BtnPay8 As System.Windows.Forms.Button
		Private columnHeader12 As System.Windows.Forms.ColumnHeader
		Private timer1 As System.Windows.Forms.Timer
		Private columnHeader5 As System.Windows.Forms.ColumnHeader
		Private menuItem2 As System.Windows.Forms.MenuItem
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private Btn_TtAnnulTR As System.Windows.Forms.Button
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private TabPag3 As System.Windows.Forms.TabPage
		Private BtnTab1 As System.Windows.Forms.Button
		Private txtReste As System.Windows.Forms.TextBox
		Private LstNavig As System.Windows.Forms.ListView
		Private tabControl1 As System.Windows.Forms.TabControl
		Private PanelPaveNum As System.Windows.Forms.Panel
		Private BtnTR As System.Windows.Forms.Button
		Private BtnVirg As System.Windows.Forms.Button
		Private BtnRetourPaye As System.Windows.Forms.Button
		Private LblTotalTR As System.Windows.Forms.Label
		Private LsVPaye As System.Windows.Forms.ListView
		Private tabPagPaye As System.Windows.Forms.TabPage
		Private TxtTotalAvoir As System.Windows.Forms.TextBox
		Private BtnPay5 As System.Windows.Forms.Button
		Private tabPagTR As System.Windows.Forms.TabPage
		Private Btn_TabAvoir_Annul As System.Windows.Forms.Button
		Private BtnUpAvoir As System.Windows.Forms.Button
		Private BtnNewAvoir As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		Private Btn_TabAvoir_3 As System.Windows.Forms.Button
		Private TxtAvoir As System.Windows.Forms.TextBox
		Private columnHeader14 As System.Windows.Forms.ColumnHeader
		Private BtnAvoir As System.Windows.Forms.Button
		Private columnHeader10 As System.Windows.Forms.ColumnHeader
		Private TxtArendre As System.Windows.Forms.TextBox
		Private BtnTab2 As System.Windows.Forms.Button
		Private BtnTab3 As System.Windows.Forms.Button
		Private BtnTab0 As System.Windows.Forms.Button
		Private Lbl_TotalAvoir As System.Windows.Forms.Label
		Private BtnTab6 As System.Windows.Forms.Button
		Private BtnTab4 As System.Windows.Forms.Button
		Private BtnTab5 As System.Windows.Forms.Button
		
		Dim FColor As color
		Dim BColor As color
		Dim BtnTexte As String
		Dim BtnPrix as string
		
		Public shared Tickets As New TousLesTickets()
		Public Paiement As New PaiementEnCours()
		Public Shared MonBouton As control 'Bouton a modifier
		
		Dim IdClientAffich As Integer 'index du client a afficher

		Dim TabPage As Integer = 0 'retourne a la bonne page du tabcontrol aprs le paiment
		
		Dim strPaiement As String ="0"
		
		Dim FlagPaveNum As Boolean = False 'flag utilise Pav numrique principal
		Dim FlagPaveNumPaiement as boolean 'flag utilise Pav numrique tabpage paiment
		Dim FlagPaveNumTR As Boolean 'flag utilise Pav numrique tabpage Ticket resto
		Dim FlagPaveNumAvoir as boolean 'flag utilise Pav numrique tabpage RenduAvoir		
		
		Dim Shared FlagModifBouton As Boolean = False 'Flag bouton modifi pour enregistrer

		Public Shared Sub Main()
			Dim FrmMain as new MainForm
			FrmMain.showdialog()
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
			Me.components = New System.ComponentModel.Container
			Me.BtnTab5 = New System.Windows.Forms.Button
			Me.BtnTab4 = New System.Windows.Forms.Button
			Me.BtnTab6 = New System.Windows.Forms.Button
			Me.Lbl_TotalAvoir = New System.Windows.Forms.Label
			Me.BtnTab0 = New System.Windows.Forms.Button
			Me.BtnTab3 = New System.Windows.Forms.Button
			Me.BtnTab2 = New System.Windows.Forms.Button
			Me.TxtArendre = New System.Windows.Forms.TextBox
			Me.columnHeader10 = New System.Windows.Forms.ColumnHeader
			Me.BtnAvoir = New System.Windows.Forms.Button
			Me.columnHeader14 = New System.Windows.Forms.ColumnHeader
			Me.TxtAvoir = New System.Windows.Forms.TextBox
			Me.Btn_TabAvoir_3 = New System.Windows.Forms.Button
			Me.textBox1 = New System.Windows.Forms.TextBox
			Me.BtnNewAvoir = New System.Windows.Forms.Button
			Me.BtnUpAvoir = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_Annul = New System.Windows.Forms.Button
			Me.tabPagTR = New System.Windows.Forms.TabPage
			Me.BtnPay5 = New System.Windows.Forms.Button
			Me.TxtTotalAvoir = New System.Windows.Forms.TextBox
			Me.tabPagPaye = New System.Windows.Forms.TabPage
			Me.LsVPaye = New System.Windows.Forms.ListView
			Me.LblTotalTR = New System.Windows.Forms.Label
			Me.BtnRetourPaye = New System.Windows.Forms.Button
			Me.BtnVirg = New System.Windows.Forms.Button
			Me.BtnTR = New System.Windows.Forms.Button
			Me.PanelPaveNum = New System.Windows.Forms.Panel
			Me.tabControl1 = New System.Windows.Forms.TabControl
			Me.LstNavig = New System.Windows.Forms.ListView
			Me.txtReste = New System.Windows.Forms.TextBox
			Me.BtnTab1 = New System.Windows.Forms.Button
			Me.TabPag3 = New System.Windows.Forms.TabPage
			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
			Me.Btn_TtAnnulTR = New System.Windows.Forms.Button
			Me.menuItem1 = New System.Windows.Forms.MenuItem
			Me.menuItem2 = New System.Windows.Forms.MenuItem
			Me.columnHeader5 = New System.Windows.Forms.ColumnHeader
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.columnHeader12 = New System.Windows.Forms.ColumnHeader
			Me.BtnPay8 = New System.Windows.Forms.Button
			Me.TxtTabAvoir_Avoir = New System.Windows.Forms.TextBox
			Me.Txt_TabTR_Reste = New System.Windows.Forms.TextBox
			Me.LsvAvoir = New System.Windows.Forms.ListView
			Me.BtnAnnulPay = New System.Windows.Forms.Button
			Me.BtnPay6 = New System.Windows.Forms.Button
			Me.BtnPay7 = New System.Windows.Forms.Button
			Me.LblIdClient = New System.Windows.Forms.Label
			Me.Btn2 = New System.Windows.Forms.Button
			Me.tabPageAvoir = New System.Windows.Forms.TabPage
			Me.Txt_TabTR_Avoir = New System.Windows.Forms.TextBox
			Me.Btn1 = New System.Windows.Forms.Button
			Me.menuCopieCoul = New System.Windows.Forms.MenuItem
			Me.Btn7 = New System.Windows.Forms.Button
			Me.Btn4 = New System.Windows.Forms.Button
			Me.Btn5 = New System.Windows.Forms.Button
			Me.LblARendre = New System.Windows.Forms.Label
			Me.Btn8 = New System.Windows.Forms.Button
			Me.Btn9 = New System.Windows.Forms.Button
			Me.button28 = New System.Windows.Forms.Button
			Me.button29 = New System.Windows.Forms.Button
			Me.button26 = New System.Windows.Forms.Button
			Me.button27 = New System.Windows.Forms.Button
			Me.button24 = New System.Windows.Forms.Button
			Me.button25 = New System.Windows.Forms.Button
			Me.button22 = New System.Windows.Forms.Button
			Me.menuItem3 = New System.Windows.Forms.MenuItem
			Me.Lbl_TabTR_Reste = New System.Windows.Forms.Label
			Me.Btn_CTR = New System.Windows.Forms.Button
			Me.BtnDownAvoir = New System.Windows.Forms.Button
			Me.menuColleCoul = New System.Windows.Forms.MenuItem
			Me.TxtTotalTR = New System.Windows.Forms.TextBox
			Me.LblTabAvoir_Avoir = New System.Windows.Forms.Label
			Me.MenuCopieBtn = New System.Windows.Forms.MenuItem
			Me.BtnTicket = New System.Windows.Forms.Button
			Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
			Me.BtnPay3 = New System.Windows.Forms.Button
			Me.BtnPay0 = New System.Windows.Forms.Button
			Me.BtnPay1 = New System.Windows.Forms.Button
			Me.columnHeader7 = New System.Windows.Forms.ColumnHeader
			Me.columnHeader6 = New System.Windows.Forms.ColumnHeader
			Me.BtnPay4 = New System.Windows.Forms.Button
			Me.columnHeader4 = New System.Windows.Forms.ColumnHeader
			Me.LblNbAvoir = New System.Windows.Forms.Label
			Me.Btn_TabAvoir_C = New System.Windows.Forms.Button
			Me.columnHeader9 = New System.Windows.Forms.ColumnHeader
			Me.columnHeader8 = New System.Windows.Forms.ColumnHeader
			Me.BtnPayVirg = New System.Windows.Forms.Button
			Me.BtnPrintTicket = New System.Windows.Forms.Button
			Me.Btn_UpNbTR = New System.Windows.Forms.Button
			Me.MenuColleBtn = New System.Windows.Forms.MenuItem
			Me.BtnVirgTR = New System.Windows.Forms.Button
			Me.BtnValid = New System.Windows.Forms.Button
			Me.BtnAvance = New System.Windows.Forms.Button
			Me.LsvTR = New System.Windows.Forms.ListView
			Me.BtnValidTR = New System.Windows.Forms.Button
			Me.TabPag2 = New System.Windows.Forms.TabPage
			Me.TabPag1 = New System.Windows.Forms.TabPage
			Me.Btn_TR_4 = New System.Windows.Forms.Button
			Me.Btn_TR_5 = New System.Windows.Forms.Button
			Me.Btn_TR_6 = New System.Windows.Forms.Button
			Me.Btn_TR_7 = New System.Windows.Forms.Button
			Me.Btn_TR_0 = New System.Windows.Forms.Button
			Me.Btn_TR_1 = New System.Windows.Forms.Button
			Me.Btn_TR_2 = New System.Windows.Forms.Button
			Me.Btn_TR_3 = New System.Windows.Forms.Button
			Me.DisplayTimer2 = New System.Windows.Forms.Timer(Me.components)
			Me.CMenu1 = New System.Windows.Forms.ContextMenu
			Me.BtnAttente = New System.Windows.Forms.Button
			Me.Btn_TR_8 = New System.Windows.Forms.Button
			Me.Btn_TR_9 = New System.Windows.Forms.Button
			Me.TxtTotal = New System.Windows.Forms.TextBox
			Me.label8 = New System.Windows.Forms.Label
			Me.label9 = New System.Windows.Forms.Label
			Me.label15 = New System.Windows.Forms.Label
			Me.label14 = New System.Windows.Forms.Label
			Me.label4 = New System.Windows.Forms.Label
			Me.label5 = New System.Windows.Forms.Label
			Me.label6 = New System.Windows.Forms.Label
			Me.label7 = New System.Windows.Forms.Label
			Me.BtnCPay = New System.Windows.Forms.Button
			Me.label12 = New System.Windows.Forms.Label
			Me.label2 = New System.Windows.Forms.Label
			Me.DisplayTimer = New System.Windows.Forms.Timer(Me.components)
			Me.BtnCancel = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_9 = New System.Windows.Forms.Button
			Me.TxtTotalNavig = New System.Windows.Forms.TextBox
			Me.BtnAnnul = New System.Windows.Forms.Button
			Me.Lbl_TabTR_Avoir = New System.Windows.Forms.Label
			Me.Btn3 = New System.Windows.Forms.Button
			Me.Btn0 = New System.Windows.Forms.Button
			Me.Btn6 = New System.Windows.Forms.Button
			Me.CMenuBtn = New System.Windows.Forms.ContextMenu
			Me.button36 = New System.Windows.Forms.Button
			Me.button35 = New System.Windows.Forms.Button
			Me.button34 = New System.Windows.Forms.Button
			Me.MenuCoupeBtn = New System.Windows.Forms.MenuItem
			Me.button32 = New System.Windows.Forms.Button
			Me.button31 = New System.Windows.Forms.Button
			Me.button30 = New System.Windows.Forms.Button
			Me.TabPag0 = New System.Windows.Forms.TabPage
			Me.BtnEsp = New System.Windows.Forms.Button
			Me.TabPag6 = New System.Windows.Forms.TabPage
			Me.TabPag5 = New System.Windows.Forms.TabPage
			Me.TabPag4 = New System.Windows.Forms.TabPage
			Me.BtnCheq = New System.Windows.Forms.Button
			Me.Lbl_TabAvoir_Reste = New System.Windows.Forms.Label
			Me.Btn_TabAvoir_6 = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_7 = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_4 = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_5 = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_2 = New System.Windows.Forms.Button
			Me.Btn_DwnNbTR = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_0 = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_1 = New System.Windows.Forms.Button
			Me.Btn_TabAvoir_8 = New System.Windows.Forms.Button
			Me.BtnEspece = New System.Windows.Forms.Button
			Me.BtnPay2 = New System.Windows.Forms.Button
			Me.BtnCaisse = New System.Windows.Forms.Button
			Me.Lbl_NbTR = New System.Windows.Forms.Label
			Me.label1 = New System.Windows.Forms.Label
			Me.Btn_TabAvoir_Valid = New System.Windows.Forms.Button
			Me.BtnTVA = New System.Windows.Forms.Button
			Me.buttonCancel = New System.Windows.Forms.Button
			Me.LblDate = New System.Windows.Forms.Label
			Me.BtnNewTR = New System.Windows.Forms.Button
			Me.BtnPaye = New System.Windows.Forms.Button
			Me.Txt_TabAvoir_Reste = New System.Windows.Forms.TextBox
			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
			Me.LblHeure = New System.Windows.Forms.Label
			Me.button1 = New System.Windows.Forms.Button
			Me.listBOX = New System.Windows.Forms.ListView
			Me.tabPagTR.SuspendLayout
			Me.tabPagPaye.SuspendLayout
			Me.PanelPaveNum.SuspendLayout
			Me.tabControl1.SuspendLayout
			Me.tabPageAvoir.SuspendLayout
			Me.SuspendLayout
			'
			'BtnTab5
			'
			Me.BtnTab5.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab5.Location = New System.Drawing.Point(730, 348)
			Me.BtnTab5.Name = "BtnTab5"
			Me.BtnTab5.Size = New System.Drawing.Size(146, 58)
			Me.BtnTab5.TabIndex = 7
			Me.BtnTab5.Tag = "5"
			Me.BtnTab5.Text = "Boisson"
			AddHandler Me.BtnTab5.Click, AddressOf Me.BtnTabClick
			'
			'BtnTab4
			'
			Me.BtnTab4.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab4.Location = New System.Drawing.Point(584, 348)
			Me.BtnTab4.Name = "BtnTab4"
			Me.BtnTab4.Size = New System.Drawing.Size(146, 58)
			Me.BtnTab4.TabIndex = 50
			Me.BtnTab4.Tag = "4"
			Me.BtnTab4.Text = "Traiteur"
			AddHandler Me.BtnTab4.Click, AddressOf Me.BtnTabClick
			'
			'BtnTab6
			'
			Me.BtnTab6.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab6.Location = New System.Drawing.Point(876, 348)
			Me.BtnTab6.Name = "BtnTab6"
			Me.BtnTab6.Size = New System.Drawing.Size(148, 58)
			Me.BtnTab6.TabIndex = 49
			Me.BtnTab6.Tag = "6"
			Me.BtnTab6.Text = "Confiseries"
			AddHandler Me.BtnTab6.Click, AddressOf Me.BtnTabClick
			'
			'Lbl_TotalAvoir
			'
			Me.Lbl_TotalAvoir.BackColor = System.Drawing.Color.Green
			Me.Lbl_TotalAvoir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.Lbl_TotalAvoir.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Lbl_TotalAvoir.ForeColor = System.Drawing.Color.White
			Me.Lbl_TotalAvoir.Location = New System.Drawing.Point(290, 214)
			Me.Lbl_TotalAvoir.Name = "Lbl_TotalAvoir"
			Me.Lbl_TotalAvoir.Size = New System.Drawing.Size(160, 30)
			Me.Lbl_TotalAvoir.TabIndex = 60
			Me.Lbl_TotalAvoir.Text = "Total Avoir :"
			Me.Lbl_TotalAvoir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'BtnTab0
			'
			Me.BtnTab0.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab0.Location = New System.Drawing.Point(0, 348)
			Me.BtnTab0.Name = "BtnTab0"
			Me.BtnTab0.Size = New System.Drawing.Size(146, 58)
			Me.BtnTab0.TabIndex = 4
			Me.BtnTab0.Tag = "0"
			Me.BtnTab0.Text = "Pain"
			AddHandler Me.BtnTab0.Click, AddressOf Me.BtnTabClick
			'
			'BtnTab3
			'
			Me.BtnTab3.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab3.Location = New System.Drawing.Point(438, 348)
			Me.BtnTab3.Name = "BtnTab3"
			Me.BtnTab3.Size = New System.Drawing.Size(146, 58)
			Me.BtnTab3.TabIndex = 6
			Me.BtnTab3.Tag = "3"
			Me.BtnTab3.Text = "Sandwich"
			AddHandler Me.BtnTab3.Click, AddressOf Me.BtnTabClick
			'
			'BtnTab2
			'
			Me.BtnTab2.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab2.Location = New System.Drawing.Point(292, 348)
			Me.BtnTab2.Name = "BtnTab2"
			Me.BtnTab2.Size = New System.Drawing.Size(146, 58)
			Me.BtnTab2.TabIndex = 48
			Me.BtnTab2.Tag = "2"
			Me.BtnTab2.Text = "Patisseries"
			AddHandler Me.BtnTab2.Click, AddressOf Me.BtnTabClick
			'
			'TxtArendre
			'
			Me.TxtArendre.BackColor = System.Drawing.Color.Yellow
			Me.TxtArendre.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtArendre.ForeColor = System.Drawing.Color.Black
			Me.TxtArendre.Location = New System.Drawing.Point(258, 154)
			Me.TxtArendre.Name = "TxtArendre"
			Me.TxtArendre.Size = New System.Drawing.Size(116, 52)
			Me.TxtArendre.TabIndex = 92
			Me.TxtArendre.Text = "0"
			Me.TxtArendre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			'
			'columnHeader10
			'
			Me.columnHeader10.Width = 70
			'
			'BtnAvoir
			'
			Me.BtnAvoir.BackColor = System.Drawing.Color.Green
			Me.BtnAvoir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnAvoir.ForeColor = System.Drawing.Color.White
			Me.BtnAvoir.Location = New System.Drawing.Point(662, 132)
			Me.BtnAvoir.Name = "BtnAvoir"
			Me.BtnAvoir.Size = New System.Drawing.Size(128, 58)
			Me.BtnAvoir.TabIndex = 73
			Me.BtnAvoir.Text = "AVOIR"
			AddHandler Me.BtnAvoir.Click, AddressOf Me.BtnAvoirClick
			'
			'columnHeader14
			'
			Me.columnHeader14.Width = 70
			'
			'TxtAvoir
			'
			Me.TxtAvoir.BackColor = System.Drawing.Color.Green
			Me.TxtAvoir.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtAvoir.ForeColor = System.Drawing.Color.White
			Me.TxtAvoir.Location = New System.Drawing.Point(258, 212)
			Me.TxtAvoir.Name = "TxtAvoir"
			Me.TxtAvoir.Size = New System.Drawing.Size(116, 36)
			Me.TxtAvoir.TabIndex = 93
			Me.TxtAvoir.Text = "0"
			Me.TxtAvoir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			'
			'Btn_TabAvoir_3
			'
			Me.Btn_TabAvoir_3.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_3.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_3.Location = New System.Drawing.Point(152, 72)
			Me.Btn_TabAvoir_3.Name = "Btn_TabAvoir_3"
			Me.Btn_TabAvoir_3.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_3.TabIndex = 42
			Me.Btn_TabAvoir_3.Text = "3"
			AddHandler Me.Btn_TabAvoir_3.Click, AddressOf Me.Btn_TabAvoir_3Click
			'
			'textBox1
			'
			Me.textBox1.Location = New System.Drawing.Point(280, -79)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.TabIndex = 76
			Me.textBox1.Text = ""
			'
			'BtnNewAvoir
			'
			Me.BtnNewAvoir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnNewAvoir.Location = New System.Drawing.Point(602, 78)
			Me.BtnNewAvoir.Name = "BtnNewAvoir"
			Me.BtnNewAvoir.Size = New System.Drawing.Size(128, 58)
			Me.BtnNewAvoir.TabIndex = 67
			Me.BtnNewAvoir.Text = "Nouvel Avoir"
			AddHandler Me.BtnNewAvoir.Click, AddressOf Me.BtnNewAvoirClick
			'
			'BtnUpAvoir
			'
			Me.BtnUpAvoir.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnUpAvoir.Location = New System.Drawing.Point(920, 136)
			Me.BtnUpAvoir.Name = "BtnUpAvoir"
			Me.BtnUpAvoir.Size = New System.Drawing.Size(56, 40)
			Me.BtnUpAvoir.TabIndex = 54
			Me.BtnUpAvoir.Text = "+"
			AddHandler Me.BtnUpAvoir.Click, AddressOf Me.BtnUpAvoirClick
			'
			'Btn_TabAvoir_Annul
			'
			Me.Btn_TabAvoir_Annul.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_Annul.Location = New System.Drawing.Point(602, 150)
			Me.Btn_TabAvoir_Annul.Name = "Btn_TabAvoir_Annul"
			Me.Btn_TabAvoir_Annul.Size = New System.Drawing.Size(128, 58)
			Me.Btn_TabAvoir_Annul.TabIndex = 47
			Me.Btn_TabAvoir_Annul.Text = "Tout Effacer"
			AddHandler Me.Btn_TabAvoir_Annul.Click, AddressOf Me.Btn_TabAvoir_AnnulClick
			'
			'tabPagTR
			'
			Me.tabPagTR.Controls.Add(Me.BtnVirgTR)
			Me.tabPagTR.Controls.Add(Me.BtnNewTR)
			Me.tabPagTR.Controls.Add(Me.Btn_CTR)
			Me.tabPagTR.Controls.Add(Me.Txt_TabTR_Avoir)
			Me.tabPagTR.Controls.Add(Me.Lbl_TabTR_Avoir)
			Me.tabPagTR.Controls.Add(Me.Txt_TabTR_Reste)
			Me.tabPagTR.Controls.Add(Me.TxtTotalTR)
			Me.tabPagTR.Controls.Add(Me.Lbl_TabTR_Reste)
			Me.tabPagTR.Controls.Add(Me.LblTotalTR)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_0)
			Me.tabPagTR.Controls.Add(Me.BtnValidTR)
			Me.tabPagTR.Controls.Add(Me.label8)
			Me.tabPagTR.Controls.Add(Me.Lbl_NbTR)
			Me.tabPagTR.Controls.Add(Me.Btn_DwnNbTR)
			Me.tabPagTR.Controls.Add(Me.Btn_UpNbTR)
			Me.tabPagTR.Controls.Add(Me.label7)
			Me.tabPagTR.Controls.Add(Me.label6)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_8)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_9)
			Me.tabPagTR.Controls.Add(Me.Btn_TtAnnulTR)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_7)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_6)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_5)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_4)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_3)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_2)
			Me.tabPagTR.Controls.Add(Me.Btn_TR_1)
			Me.tabPagTR.Controls.Add(Me.LsvTR)
			Me.tabPagTR.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.tabPagTR.Location = New System.Drawing.Point(4, 4)
			Me.tabPagTR.Name = "tabPagTR"
			Me.tabPagTR.Size = New System.Drawing.Size(1018, 367)
			Me.tabPagTR.TabIndex = 5
			Me.tabPagTR.Text = "Ticket Resto"
			'
			'BtnPay5
			'
			Me.BtnPay5.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay5.Name = "BtnPay5"
			Me.BtnPay5.TabIndex = 0
			'
			'TxtTotalAvoir
			'
			Me.TxtTotalAvoir.BackColor = System.Drawing.Color.Green
			Me.TxtTotalAvoir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtTotalAvoir.ForeColor = System.Drawing.Color.White
			Me.TxtTotalAvoir.Location = New System.Drawing.Point(470, 214)
			Me.TxtTotalAvoir.Name = "TxtTotalAvoir"
			Me.TxtTotalAvoir.Size = New System.Drawing.Size(76, 32)
			Me.TxtTotalAvoir.TabIndex = 62
			Me.TxtTotalAvoir.Text = "0"
			'
			'tabPagPaye
			'
			Me.tabPagPaye.Controls.Add(Me.BtnRetourPaye)
			Me.tabPagPaye.Controls.Add(Me.BtnTVA)
			Me.tabPagPaye.Controls.Add(Me.button34)
			Me.tabPagPaye.Controls.Add(Me.button35)
			Me.tabPagPaye.Controls.Add(Me.button36)
			Me.tabPagPaye.Controls.Add(Me.BtnTicket)
			Me.tabPagPaye.Controls.Add(Me.BtnValid)
			Me.tabPagPaye.Controls.Add(Me.BtnAnnulPay)
			Me.tabPagPaye.Controls.Add(Me.label4)
			Me.tabPagPaye.Controls.Add(Me.LblARendre)
			Me.tabPagPaye.Controls.Add(Me.TxtAvoir)
			Me.tabPagPaye.Controls.Add(Me.TxtArendre)
			Me.tabPagPaye.Controls.Add(Me.BtnVirg)
			Me.tabPagPaye.Controls.Add(Me.txtReste)
			Me.tabPagPaye.Controls.Add(Me.label2)
			Me.tabPagPaye.Controls.Add(Me.BtnCPay)
			Me.tabPagPaye.Controls.Add(Me.button24)
			Me.tabPagPaye.Controls.Add(Me.button25)
			Me.tabPagPaye.Controls.Add(Me.button26)
			Me.tabPagPaye.Controls.Add(Me.button27)
			Me.tabPagPaye.Controls.Add(Me.button28)
			Me.tabPagPaye.Controls.Add(Me.button29)
			Me.tabPagPaye.Controls.Add(Me.button30)
			Me.tabPagPaye.Controls.Add(Me.button31)
			Me.tabPagPaye.Controls.Add(Me.button32)
			Me.tabPagPaye.Controls.Add(Me.BtnPay1)
			Me.tabPagPaye.Controls.Add(Me.label5)
			Me.tabPagPaye.Controls.Add(Me.textBox1)
			Me.tabPagPaye.Controls.Add(Me.LsVPaye)
			Me.tabPagPaye.Controls.Add(Me.BtnTR)
			Me.tabPagPaye.Controls.Add(Me.BtnAvoir)
			Me.tabPagPaye.Controls.Add(Me.BtnCheq)
			Me.tabPagPaye.Controls.Add(Me.BtnEspece)
			Me.tabPagPaye.Location = New System.Drawing.Point(4, 4)
			Me.tabPagPaye.Name = "tabPagPaye"
			Me.tabPagPaye.Size = New System.Drawing.Size(1018, 367)
			Me.tabPagPaye.TabIndex = 4
			Me.tabPagPaye.Text = "Paiment"
			'
			'LsVPaye
			'
			Me.LsVPaye.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader4, Me.columnHeader5})
			Me.LsVPaye.Font = New System.Drawing.Font("Tahoma", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.LsVPaye.FullRowSelect = true
			Me.LsVPaye.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
			Me.LsVPaye.HideSelection = false
			Me.LsVPaye.Location = New System.Drawing.Point(8, 8)
			Me.LsVPaye.MultiSelect = false
			Me.LsVPaye.Name = "LsVPaye"
			Me.LsVPaye.Size = New System.Drawing.Size(366, 98)
			Me.LsVPaye.TabIndex = 75
			Me.LsVPaye.View = System.Windows.Forms.View.Details
			AddHandler Me.LsVPaye.SelectedIndexChanged, AddressOf Me.LsVPayeSelectedIndexChanged
			'
			'LblTotalTR
			'
			Me.LblTotalTR.BackColor = System.Drawing.Color.SteelBlue
			Me.LblTotalTR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.LblTotalTR.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.LblTotalTR.ForeColor = System.Drawing.Color.White
			Me.LblTotalTR.Location = New System.Drawing.Point(290, 214)
			Me.LblTotalTR.Name = "LblTotalTR"
			Me.LblTotalTR.Size = New System.Drawing.Size(160, 30)
			Me.LblTotalTR.TabIndex = 33
			Me.LblTotalTR.Text = "Total Ticket Resto :"
			Me.LblTotalTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'BtnRetourPaye
			'
			Me.BtnRetourPaye.BackColor = System.Drawing.Color.Red
			Me.BtnRetourPaye.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnRetourPaye.ForeColor = System.Drawing.Color.White
			Me.BtnRetourPaye.Location = New System.Drawing.Point(744, 282)
			Me.BtnRetourPaye.Name = "BtnRetourPaye"
			Me.BtnRetourPaye.Size = New System.Drawing.Size(128, 58)
			Me.BtnRetourPaye.TabIndex = 103
			Me.BtnRetourPaye.Text = "Retour"
			AddHandler Me.BtnRetourPaye.Click, AddressOf Me.BtnRetourPayeClick
			'
			'BtnVirg
			'
			Me.BtnVirg.BackColor = System.Drawing.Color.Gray
			Me.BtnVirg.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnVirg.ForeColor = System.Drawing.Color.Snow
			Me.BtnVirg.Location = New System.Drawing.Point(490, 172)
			Me.BtnVirg.Name = "BtnVirg"
			Me.BtnVirg.Size = New System.Drawing.Size(60, 50)
			Me.BtnVirg.TabIndex = 91
			Me.BtnVirg.Text = ","
			AddHandler Me.BtnVirg.Click, AddressOf Me.BtnVirgClick
			'
			'BtnTR
			'
			Me.BtnTR.Location = New System.Drawing.Point(456, -55)
			Me.BtnTR.Name = "BtnTR"
			Me.BtnTR.TabIndex = 74
			Me.BtnTR.Text = "Ticket Resto"
			AddHandler Me.BtnTR.Click, AddressOf Me.BtnTRClick
			'
			'PanelPaveNum
			'
			Me.PanelPaveNum.Controls.Add(Me.Btn3)
			Me.PanelPaveNum.Controls.Add(Me.Btn1)
			Me.PanelPaveNum.Controls.Add(Me.Btn2)
			Me.PanelPaveNum.Controls.Add(Me.Btn4)
			Me.PanelPaveNum.Controls.Add(Me.Btn5)
			Me.PanelPaveNum.Controls.Add(Me.Btn6)
			Me.PanelPaveNum.Controls.Add(Me.Btn7)
			Me.PanelPaveNum.Controls.Add(Me.Btn8)
			Me.PanelPaveNum.Controls.Add(Me.Btn9)
			Me.PanelPaveNum.Controls.Add(Me.Btn0)
			Me.PanelPaveNum.Controls.Add(Me.BtnCancel)
			Me.PanelPaveNum.Location = New System.Drawing.Point(362, 28)
			Me.PanelPaveNum.Name = "PanelPaveNum"
			Me.PanelPaveNum.Size = New System.Drawing.Size(180, 222)
			Me.PanelPaveNum.TabIndex = 56
			'
			'tabControl1
			'
			Me.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
			Me.tabControl1.Controls.Add(Me.TabPag0)
			Me.tabControl1.Controls.Add(Me.TabPag1)
			Me.tabControl1.Controls.Add(Me.TabPag2)
			Me.tabControl1.Controls.Add(Me.TabPag3)
			Me.tabControl1.Controls.Add(Me.TabPag4)
			Me.tabControl1.Controls.Add(Me.TabPag5)
			Me.tabControl1.Controls.Add(Me.TabPag6)
			Me.tabControl1.Controls.Add(Me.tabPagPaye)
			Me.tabControl1.Controls.Add(Me.tabPagTR)
			Me.tabControl1.Controls.Add(Me.tabPageAvoir)
			Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.tabControl1.ItemSize = New System.Drawing.Size(1, 1)
			Me.tabControl1.Location = New System.Drawing.Point(-2, 411)
			Me.tabControl1.Multiline = true
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New System.Drawing.Size(1026, 376)
			Me.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
			Me.tabControl1.TabIndex = 3
			AddHandler Me.tabControl1.SelectedIndexChanged, AddressOf Me.TabControl1SelectedIndexChanged
			'
			'LstNavig
			'
			Me.LstNavig.AllowColumnReorder = true
			Me.LstNavig.BackColor = System.Drawing.SystemColors.Window
			Me.LstNavig.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader6, Me.columnHeader7, Me.columnHeader8})
			Me.LstNavig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
			Me.LstNavig.FullRowSelect = true
			Me.LstNavig.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
			Me.LstNavig.HideSelection = false
			Me.LstNavig.Location = New System.Drawing.Point(556, 38)
			Me.LstNavig.MultiSelect = false
			Me.LstNavig.Name = "LstNavig"
			Me.LstNavig.Size = New System.Drawing.Size(334, 250)
			Me.LstNavig.TabIndex = 43
			Me.LstNavig.View = System.Windows.Forms.View.Details
			'
			'txtReste
			'
			Me.txtReste.BackColor = System.Drawing.Color.Red
			Me.txtReste.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.txtReste.ForeColor = System.Drawing.Color.White
			Me.txtReste.Location = New System.Drawing.Point(258, 112)
			Me.txtReste.Name = "txtReste"
			Me.txtReste.Size = New System.Drawing.Size(116, 36)
			Me.txtReste.TabIndex = 90
			Me.txtReste.Text = "0"
			Me.txtReste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			'
			'BtnTab1
			'
			Me.BtnTab1.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0,Byte))
			Me.BtnTab1.Location = New System.Drawing.Point(146, 348)
			Me.BtnTab1.Name = "BtnTab1"
			Me.BtnTab1.Size = New System.Drawing.Size(146, 58)
			Me.BtnTab1.TabIndex = 5
			Me.BtnTab1.Tag = "1"
			Me.BtnTab1.Text = "Viennoiseries"
			AddHandler Me.BtnTab1.Click, AddressOf Me.BtnTabClick
			'
			'TabPag3
			'
			Me.TabPag3.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.TabPag3.Location = New System.Drawing.Point(4, 4)
			Me.TabPag3.Name = "TabPag3"
			Me.TabPag3.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag3.TabIndex = 2
			Me.TabPag3.Text = "3"
			'
			'columnHeader1
			'
			Me.columnHeader1.Width = 40
			'
			'Btn_TtAnnulTR
			'
			Me.Btn_TtAnnulTR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TtAnnulTR.Location = New System.Drawing.Point(602, 150)
			Me.Btn_TtAnnulTR.Name = "Btn_TtAnnulTR"
			Me.Btn_TtAnnulTR.Size = New System.Drawing.Size(128, 58)
			Me.Btn_TtAnnulTR.TabIndex = 8
			Me.Btn_TtAnnulTR.Text = "Tout Effacer"
			AddHandler Me.Btn_TtAnnulTR.Click, AddressOf Me.Btn_TtAnnulTRClick
			'
			'menuItem1
			'
			Me.menuItem1.Index = 0
			Me.menuItem1.Text = "DÃ©vÃ©rouillez les boutons"
			AddHandler Me.menuItem1.Click, AddressOf Me.MenuItem1Click
			'
			'menuItem2
			'
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "Modifier"
			AddHandler Me.menuItem2.Click, AddressOf Me.MenuItem2Click
			'
			'columnHeader5
			'
			Me.columnHeader5.Width = 70
			'
			'timer1
			'
			AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
			'
			'columnHeader12
			'
			Me.columnHeader12.Width = 180
			'
			'BtnPay8
			'
			Me.BtnPay8.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay8.Name = "BtnPay8"
			Me.BtnPay8.TabIndex = 0
			'
			'TxtTabAvoir_Avoir
			'
			Me.TxtTabAvoir_Avoir.BackColor = System.Drawing.Color.Green
			Me.TxtTabAvoir_Avoir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtTabAvoir_Avoir.ForeColor = System.Drawing.Color.White
			Me.TxtTabAvoir_Avoir.Location = New System.Drawing.Point(470, 294)
			Me.TxtTabAvoir_Avoir.Name = "TxtTabAvoir_Avoir"
			Me.TxtTabAvoir_Avoir.Size = New System.Drawing.Size(76, 32)
			Me.TxtTabAvoir_Avoir.TabIndex = 65
			Me.TxtTabAvoir_Avoir.Text = "0"
			'
			'Txt_TabTR_Reste
			'
			Me.Txt_TabTR_Reste.BackColor = System.Drawing.Color.Yellow
			Me.Txt_TabTR_Reste.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Txt_TabTR_Reste.ForeColor = System.Drawing.Color.Black
			Me.Txt_TabTR_Reste.Location = New System.Drawing.Point(470, 254)
			Me.Txt_TabTR_Reste.Name = "Txt_TabTR_Reste"
			Me.Txt_TabTR_Reste.Size = New System.Drawing.Size(76, 32)
			Me.Txt_TabTR_Reste.TabIndex = 36
			Me.Txt_TabTR_Reste.Text = "0"
			'
			'LsvAvoir
			'
			Me.LsvAvoir.AllowColumnReorder = true
			Me.LsvAvoir.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader12, Me.columnHeader14})
			Me.LsvAvoir.Font = New System.Drawing.Font("Tahoma", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.LsvAvoir.FullRowSelect = true
			Me.LsvAvoir.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
			Me.LsvAvoir.HideSelection = false
			Me.LsvAvoir.Location = New System.Drawing.Point(290, 78)
			Me.LsvAvoir.MultiSelect = false
			Me.LsvAvoir.Name = "LsvAvoir"
			Me.LsvAvoir.Size = New System.Drawing.Size(256, 128)
			Me.LsvAvoir.TabIndex = 39
			Me.LsvAvoir.View = System.Windows.Forms.View.Details
			AddHandler Me.LsvAvoir.SelectedIndexChanged, AddressOf Me.LsvAvoirSelectedIndexChanged
			'
			'BtnAnnulPay
			'
			Me.BtnAnnulPay.BackColor = System.Drawing.SystemColors.Control
			Me.BtnAnnulPay.Font = New System.Drawing.Font("Tahoma", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAnnulPay.ForeColor = System.Drawing.SystemColors.ControlText
			Me.BtnAnnulPay.Location = New System.Drawing.Point(8, 282)
			Me.BtnAnnulPay.Name = "BtnAnnulPay"
			Me.BtnAnnulPay.Size = New System.Drawing.Size(128, 58)
			Me.BtnAnnulPay.TabIndex = 96
			Me.BtnAnnulPay.Text = "Tout Effacer"
			AddHandler Me.BtnAnnulPay.Click, AddressOf Me.BtnAnnulPayClick
			'
			'BtnPay6
			'
			Me.BtnPay6.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay6.Name = "BtnPay6"
			Me.BtnPay6.TabIndex = 0
			'
			'BtnPay7
			'
			Me.BtnPay7.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay7.Name = "BtnPay7"
			Me.BtnPay7.TabIndex = 0
			'
			'LblIdClient
			'
			Me.LblIdClient.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.LblIdClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.LblIdClient.Location = New System.Drawing.Point(664, 8)
			Me.LblIdClient.Name = "LblIdClient"
			Me.LblIdClient.Size = New System.Drawing.Size(116, 22)
			Me.LblIdClient.TabIndex = 42
			Me.LblIdClient.Text = "1"
			Me.LblIdClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn2
			'
			Me.Btn2.BackColor = System.Drawing.Color.Gray
			Me.Btn2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn2.ForeColor = System.Drawing.Color.Snow
			Me.Btn2.Location = New System.Drawing.Point(60, 10)
			Me.Btn2.Name = "Btn2"
			Me.Btn2.Size = New System.Drawing.Size(60, 50)
			Me.Btn2.TabIndex = 21
			Me.Btn2.Text = "2"
			AddHandler Me.Btn2.Click, AddressOf Me.Btn2Click
			'
			'tabPageAvoir
			'
			Me.tabPageAvoir.Controls.Add(Me.BtnNewAvoir)
			Me.tabPageAvoir.Controls.Add(Me.TxtTabAvoir_Avoir)
			Me.tabPageAvoir.Controls.Add(Me.LblTabAvoir_Avoir)
			Me.tabPageAvoir.Controls.Add(Me.Txt_TabAvoir_Reste)
			Me.tabPageAvoir.Controls.Add(Me.TxtTotalAvoir)
			Me.tabPageAvoir.Controls.Add(Me.Lbl_TabAvoir_Reste)
			Me.tabPageAvoir.Controls.Add(Me.Lbl_TotalAvoir)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_0)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_Valid)
			Me.tabPageAvoir.Controls.Add(Me.label12)
			Me.tabPageAvoir.Controls.Add(Me.LblNbAvoir)
			Me.tabPageAvoir.Controls.Add(Me.BtnDownAvoir)
			Me.tabPageAvoir.Controls.Add(Me.BtnUpAvoir)
			Me.tabPageAvoir.Controls.Add(Me.label14)
			Me.tabPageAvoir.Controls.Add(Me.label15)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_C)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_8)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_9)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_Annul)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_7)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_6)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_5)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_4)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_3)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_2)
			Me.tabPageAvoir.Controls.Add(Me.Btn_TabAvoir_1)
			Me.tabPageAvoir.Controls.Add(Me.LsvAvoir)
			Me.tabPageAvoir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.tabPageAvoir.Location = New System.Drawing.Point(4, 4)
			Me.tabPageAvoir.Name = "tabPageAvoir"
			Me.tabPageAvoir.Size = New System.Drawing.Size(1018, 367)
			Me.tabPageAvoir.TabIndex = 6
			Me.tabPageAvoir.Text = "Avoir"
			'
			'Txt_TabTR_Avoir
			'
			Me.Txt_TabTR_Avoir.BackColor = System.Drawing.Color.Green
			Me.Txt_TabTR_Avoir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Txt_TabTR_Avoir.ForeColor = System.Drawing.Color.White
			Me.Txt_TabTR_Avoir.Location = New System.Drawing.Point(470, 294)
			Me.Txt_TabTR_Avoir.Name = "Txt_TabTR_Avoir"
			Me.Txt_TabTR_Avoir.Size = New System.Drawing.Size(76, 32)
			Me.Txt_TabTR_Avoir.TabIndex = 38
			Me.Txt_TabTR_Avoir.Text = "0"
			'
			'Btn1
			'
			Me.Btn1.BackColor = System.Drawing.Color.Gray
			Me.Btn1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn1.ForeColor = System.Drawing.Color.Snow
			Me.Btn1.Location = New System.Drawing.Point(0, 10)
			Me.Btn1.Name = "Btn1"
			Me.Btn1.Size = New System.Drawing.Size(60, 50)
			Me.Btn1.TabIndex = 20
			Me.Btn1.Text = "1"
			AddHandler Me.Btn1.Click, AddressOf Me.Btn1Click
			'
			'menuCopieCoul
			'
			Me.menuCopieCoul.Index = 2
			Me.menuCopieCoul.Text = "Copier les couleurs"
			AddHandler Me.menuCopieCoul.Click, AddressOf Me.MenuCopieCoulClick
			'
			'Btn7
			'
			Me.Btn7.BackColor = System.Drawing.Color.Gray
			Me.Btn7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn7.ForeColor = System.Drawing.Color.Snow
			Me.Btn7.Location = New System.Drawing.Point(60, 110)
			Me.Btn7.Name = "Btn7"
			Me.Btn7.Size = New System.Drawing.Size(60, 50)
			Me.Btn7.TabIndex = 26
			Me.Btn7.Text = "7"
			AddHandler Me.Btn7.Click, AddressOf Me.Btn7Click
			'
			'Btn4
			'
			Me.Btn4.BackColor = System.Drawing.Color.Gray
			Me.Btn4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn4.ForeColor = System.Drawing.Color.Snow
			Me.Btn4.Location = New System.Drawing.Point(0, 60)
			Me.Btn4.Name = "Btn4"
			Me.Btn4.Size = New System.Drawing.Size(60, 50)
			Me.Btn4.TabIndex = 23
			Me.Btn4.Text = "4"
			AddHandler Me.Btn4.Click, AddressOf Me.Btn4Click
			'
			'Btn5
			'
			Me.Btn5.BackColor = System.Drawing.Color.Gray
			Me.Btn5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn5.ForeColor = System.Drawing.Color.Snow
			Me.Btn5.Location = New System.Drawing.Point(60, 60)
			Me.Btn5.Name = "Btn5"
			Me.Btn5.Size = New System.Drawing.Size(60, 50)
			Me.Btn5.TabIndex = 24
			Me.Btn5.Text = "5"
			AddHandler Me.Btn5.Click, AddressOf Me.Btn5Click
			'
			'LblARendre
			'
			Me.LblARendre.BackColor = System.Drawing.Color.Yellow
			Me.LblARendre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.LblARendre.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.LblARendre.ForeColor = System.Drawing.Color.Black
			Me.LblARendre.Location = New System.Drawing.Point(78, 154)
			Me.LblARendre.Name = "LblARendre"
			Me.LblARendre.Size = New System.Drawing.Size(168, 52)
			Me.LblARendre.TabIndex = 94
			Me.LblARendre.Text = "A rendre : "
			Me.LblARendre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn8
			'
			Me.Btn8.BackColor = System.Drawing.Color.Gray
			Me.Btn8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn8.ForeColor = System.Drawing.Color.Snow
			Me.Btn8.Location = New System.Drawing.Point(0, 110)
			Me.Btn8.Name = "Btn8"
			Me.Btn8.Size = New System.Drawing.Size(60, 50)
			Me.Btn8.TabIndex = 28
			Me.Btn8.Text = "8"
			AddHandler Me.Btn8.Click, AddressOf Me.Btn8Click
			'
			'Btn9
			'
			Me.Btn9.BackColor = System.Drawing.Color.Gray
			Me.Btn9.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn9.ForeColor = System.Drawing.Color.Snow
			Me.Btn9.Location = New System.Drawing.Point(120, 110)
			Me.Btn9.Name = "Btn9"
			Me.Btn9.Size = New System.Drawing.Size(60, 50)
			Me.Btn9.TabIndex = 29
			Me.Btn9.Text = "9"
			AddHandler Me.Btn9.Click, AddressOf Me.Btn9Click
			'
			'button28
			'
			Me.button28.BackColor = System.Drawing.Color.Gray
			Me.button28.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button28.ForeColor = System.Drawing.Color.Snow
			Me.button28.Location = New System.Drawing.Point(550, 72)
			Me.button28.Name = "button28"
			Me.button28.Size = New System.Drawing.Size(60, 50)
			Me.button28.TabIndex = 83
			Me.button28.Text = "6"
			AddHandler Me.button28.Click, AddressOf Me.button28Click
			'
			'button29
			'
			Me.button29.BackColor = System.Drawing.Color.Gray
			Me.button29.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button29.ForeColor = System.Drawing.Color.Snow
			Me.button29.Location = New System.Drawing.Point(490, 72)
			Me.button29.Name = "button29"
			Me.button29.Size = New System.Drawing.Size(60, 50)
			Me.button29.TabIndex = 82
			Me.button29.Text = "5"
			AddHandler Me.button29.Click, AddressOf Me.button29Click
			'
			'button26
			'
			Me.button26.BackColor = System.Drawing.Color.Gray
			Me.button26.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button26.ForeColor = System.Drawing.Color.Snow
			Me.button26.Location = New System.Drawing.Point(490, 122)
			Me.button26.Name = "button26"
			Me.button26.Size = New System.Drawing.Size(60, 50)
			Me.button26.TabIndex = 85
			Me.button26.Text = "8"
			AddHandler Me.button26.Click, AddressOf Me.button26Click
			'
			'button27
			'
			Me.button27.BackColor = System.Drawing.Color.Gray
			Me.button27.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button27.ForeColor = System.Drawing.Color.Snow
			Me.button27.Location = New System.Drawing.Point(430, 122)
			Me.button27.Name = "button27"
			Me.button27.Size = New System.Drawing.Size(60, 50)
			Me.button27.TabIndex = 84
			Me.button27.Text = "7"
			AddHandler Me.button27.Click, AddressOf Me.button27Click
			'
			'button24
			'
			Me.button24.BackColor = System.Drawing.Color.Gray
			Me.button24.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button24.ForeColor = System.Drawing.Color.Snow
			Me.button24.Location = New System.Drawing.Point(430, 172)
			Me.button24.Name = "button24"
			Me.button24.Size = New System.Drawing.Size(60, 50)
			Me.button24.TabIndex = 87
			Me.button24.Text = "0"
			AddHandler Me.button24.Click, AddressOf Me.button24Click
			'
			'button25
			'
			Me.button25.BackColor = System.Drawing.Color.Gray
			Me.button25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button25.ForeColor = System.Drawing.Color.Snow
			Me.button25.Location = New System.Drawing.Point(550, 122)
			Me.button25.Name = "button25"
			Me.button25.Size = New System.Drawing.Size(60, 50)
			Me.button25.TabIndex = 86
			Me.button25.Text = "9"
			AddHandler Me.button25.Click, AddressOf Me.button25Click
			'
			'button22
			'
			Me.button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button22.Location = New System.Drawing.Point(784, 2)
			Me.button22.Name = "button22"
			Me.button22.Size = New System.Drawing.Size(106, 34)
			Me.button22.TabIndex = 41
			Me.button22.Text = "SUIVANT"
			AddHandler Me.button22.Click, AddressOf Me.Button22Click
			'
			'menuItem3
			'
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "Supprimer"
			AddHandler Me.menuItem3.Click, AddressOf Me.MenuItem3Click
			'
			'Lbl_TabTR_Reste
			'
			Me.Lbl_TabTR_Reste.BackColor = System.Drawing.Color.Yellow
			Me.Lbl_TabTR_Reste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.Lbl_TabTR_Reste.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Lbl_TabTR_Reste.ForeColor = System.Drawing.Color.Black
			Me.Lbl_TabTR_Reste.Location = New System.Drawing.Point(290, 254)
			Me.Lbl_TabTR_Reste.Name = "Lbl_TabTR_Reste"
			Me.Lbl_TabTR_Reste.Size = New System.Drawing.Size(160, 30)
			Me.Lbl_TabTR_Reste.TabIndex = 34
			Me.Lbl_TabTR_Reste.Text = "Reste A Payer :"
			Me.Lbl_TabTR_Reste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn_CTR
			'
			Me.Btn_CTR.BackColor = System.Drawing.Color.Gray
			Me.Btn_CTR.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_CTR.ForeColor = System.Drawing.Color.Red
			Me.Btn_CTR.Location = New System.Drawing.Point(92, 222)
			Me.Btn_CTR.Name = "Btn_CTR"
			Me.Btn_CTR.Size = New System.Drawing.Size(120, 50)
			Me.Btn_CTR.TabIndex = 12
			Me.Btn_CTR.Text = "C"
			AddHandler Me.Btn_CTR.Click, AddressOf Me.Btn_CTRClick
			'
			'BtnDownAvoir
			'
			Me.BtnDownAvoir.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnDownAvoir.Location = New System.Drawing.Point(816, 136)
			Me.BtnDownAvoir.Name = "BtnDownAvoir"
			Me.BtnDownAvoir.Size = New System.Drawing.Size(56, 40)
			Me.BtnDownAvoir.TabIndex = 55
			Me.BtnDownAvoir.Text = "-"
			AddHandler Me.BtnDownAvoir.Click, AddressOf Me.BtnDownAvoirClick
			'
			'menuColleCoul
			'
			Me.menuColleCoul.Enabled = false
			Me.menuColleCoul.Index = 3
			Me.menuColleCoul.Text = "Coller les couleurs"
			AddHandler Me.menuColleCoul.Click, AddressOf Me.MenuColleCoulClick
			'
			'TxtTotalTR
			'
			Me.TxtTotalTR.BackColor = System.Drawing.Color.SteelBlue
			Me.TxtTotalTR.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtTotalTR.ForeColor = System.Drawing.Color.White
			Me.TxtTotalTR.Location = New System.Drawing.Point(470, 214)
			Me.TxtTotalTR.Name = "TxtTotalTR"
			Me.TxtTotalTR.Size = New System.Drawing.Size(76, 32)
			Me.TxtTotalTR.TabIndex = 35
			Me.TxtTotalTR.Text = "0"
			'
			'LblTabAvoir_Avoir
			'
			Me.LblTabAvoir_Avoir.BackColor = System.Drawing.Color.Green
			Me.LblTabAvoir_Avoir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.LblTabAvoir_Avoir.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.LblTabAvoir_Avoir.ForeColor = System.Drawing.Color.White
			Me.LblTabAvoir_Avoir.Location = New System.Drawing.Point(290, 294)
			Me.LblTabAvoir_Avoir.Name = "LblTabAvoir_Avoir"
			Me.LblTabAvoir_Avoir.Size = New System.Drawing.Size(160, 30)
			Me.LblTabAvoir_Avoir.TabIndex = 64
			Me.LblTabAvoir_Avoir.Text = "Avoir :"
			Me.LblTabAvoir_Avoir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'MenuCopieBtn
			'
			Me.MenuCopieBtn.Index = 6
			Me.MenuCopieBtn.Text = "Copier le bouton"
			AddHandler Me.MenuCopieBtn.Click, AddressOf Me.MenuCopieBtnClick
			'
			'BtnTicket
			'
			Me.BtnTicket.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnTicket.Location = New System.Drawing.Point(606, 282)
			Me.BtnTicket.Name = "BtnTicket"
			Me.BtnTicket.Size = New System.Drawing.Size(128, 58)
			Me.BtnTicket.TabIndex = 98
			Me.BtnTicket.Text = "Sans Ticket"
			AddHandler Me.BtnTicket.Click, AddressOf Me.BtnTicketClick
			'
			'columnHeader3
			'
			Me.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.columnHeader3.Width = 70
			'
			'BtnPay3
			'
			Me.BtnPay3.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay3.Name = "BtnPay3"
			Me.BtnPay3.TabIndex = 0
			'
			'BtnPay0
			'
			Me.BtnPay0.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay0.Name = "BtnPay0"
			Me.BtnPay0.TabIndex = 0
			'
			'BtnPay1
			'
			Me.BtnPay1.BackColor = System.Drawing.Color.Gray
			Me.BtnPay1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnPay1.ForeColor = System.Drawing.Color.Snow
			Me.BtnPay1.Location = New System.Drawing.Point(430, 22)
			Me.BtnPay1.Name = "BtnPay1"
			Me.BtnPay1.Size = New System.Drawing.Size(60, 50)
			Me.BtnPay1.TabIndex = 78
			Me.BtnPay1.Text = "1"
			AddHandler Me.BtnPay1.Click, AddressOf Me.BtnPay1Click
			'
			'columnHeader7
			'
			Me.columnHeader7.Width = 220
			'
			'columnHeader6
			'
			Me.columnHeader6.Width = 40
			'
			'BtnPay4
			'
			Me.BtnPay4.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay4.Name = "BtnPay4"
			Me.BtnPay4.TabIndex = 0
			'
			'columnHeader4
			'
			Me.columnHeader4.Width = 290
			'
			'LblNbAvoir
			'
			Me.LblNbAvoir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.LblNbAvoir.Location = New System.Drawing.Point(872, 136)
			Me.LblNbAvoir.Name = "LblNbAvoir"
			Me.LblNbAvoir.Size = New System.Drawing.Size(48, 40)
			Me.LblNbAvoir.TabIndex = 56
			Me.LblNbAvoir.Text = "1"
			Me.LblNbAvoir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn_TabAvoir_C
			'
			Me.Btn_TabAvoir_C.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_C.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_C.ForeColor = System.Drawing.Color.Red
			Me.Btn_TabAvoir_C.Location = New System.Drawing.Point(92, 222)
			Me.Btn_TabAvoir_C.Name = "Btn_TabAvoir_C"
			Me.Btn_TabAvoir_C.Size = New System.Drawing.Size(120, 50)
			Me.Btn_TabAvoir_C.TabIndex = 50
			Me.Btn_TabAvoir_C.Text = "C"
			AddHandler Me.Btn_TabAvoir_C.Click, AddressOf Me.Btn_TabAvoir_CClick
			'
			'columnHeader9
			'
			Me.columnHeader9.Width = 180
			'
			'columnHeader8
			'
			Me.columnHeader8.Width = 70
			'
			'BtnPayVirg
			'
			Me.BtnPayVirg.Location = New System.Drawing.Point(0, 0)
			Me.BtnPayVirg.Name = "BtnPayVirg"
			Me.BtnPayVirg.TabIndex = 0
			'
			'BtnPrintTicket
			'
			Me.BtnPrintTicket.Enabled = false
			Me.BtnPrintTicket.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnPrintTicket.Location = New System.Drawing.Point(904, 282)
			Me.BtnPrintTicket.Name = "BtnPrintTicket"
			Me.BtnPrintTicket.Size = New System.Drawing.Size(110, 42)
			Me.BtnPrintTicket.TabIndex = 53
			Me.BtnPrintTicket.Text = "Imprimer le Ticket"
			AddHandler Me.BtnPrintTicket.Click, AddressOf Me.BtnPrintTicketClick
			'
			'Btn_UpNbTR
			'
			Me.Btn_UpNbTR.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_UpNbTR.Location = New System.Drawing.Point(920, 178)
			Me.Btn_UpNbTR.Name = "Btn_UpNbTR"
			Me.Btn_UpNbTR.Size = New System.Drawing.Size(56, 40)
			Me.Btn_UpNbTR.TabIndex = 27
			Me.Btn_UpNbTR.Text = "+"
			AddHandler Me.Btn_UpNbTR.Click, AddressOf Me.Btn_UpNbTRClick
			'
			'MenuColleBtn
			'
			Me.MenuColleBtn.Enabled = false
			Me.MenuColleBtn.Index = 5
			Me.MenuColleBtn.Text = "Coller le bouton"
			AddHandler Me.MenuColleBtn.Click, AddressOf Me.MenuColleBtnClick
			'
			'BtnVirgTR
			'
			Me.BtnVirgTR.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnVirgTR.Location = New System.Drawing.Point(820, 28)
			Me.BtnVirgTR.Name = "BtnVirgTR"
			Me.BtnVirgTR.Size = New System.Drawing.Size(146, 56)
			Me.BtnVirgTR.TabIndex = 42
			Me.BtnVirgTR.Text = "Ticket de 10,00  ou plus"
			AddHandler Me.BtnVirgTR.Click, AddressOf Me.BtnVirgTRClick
			'
			'BtnValid
			'
			Me.BtnValid.BackColor = System.Drawing.Color.Green
			Me.BtnValid.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnValid.ForeColor = System.Drawing.Color.White
			Me.BtnValid.Location = New System.Drawing.Point(882, 282)
			Me.BtnValid.Name = "BtnValid"
			Me.BtnValid.Size = New System.Drawing.Size(128, 58)
			Me.BtnValid.TabIndex = 97
			Me.BtnValid.Text = "Valider"
			AddHandler Me.BtnValid.Click, AddressOf Me.BtnValidClick
			'
			'BtnAvance
			'
			Me.BtnAvance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAvance.Location = New System.Drawing.Point(946, 66)
			Me.BtnAvance.Name = "BtnAvance"
			Me.BtnAvance.Size = New System.Drawing.Size(78, 52)
			Me.BtnAvance.TabIndex = 57
			Me.BtnAvance.Text = "AVANCE"
			AddHandler Me.BtnAvance.Click, AddressOf Me.BtnAvanceClick
			'
			'LsvTR
			'
			Me.LsvTR.AllowColumnReorder = true
			Me.LsvTR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader9, Me.columnHeader10})
			Me.LsvTR.Font = New System.Drawing.Font("Tahoma", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.LsvTR.FullRowSelect = true
			Me.LsvTR.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
			Me.LsvTR.HideSelection = false
			Me.LsvTR.Location = New System.Drawing.Point(290, 78)
			Me.LsvTR.MultiSelect = false
			Me.LsvTR.Name = "LsvTR"
			Me.LsvTR.Size = New System.Drawing.Size(256, 128)
			Me.LsvTR.TabIndex = 0
			Me.LsvTR.View = System.Windows.Forms.View.Details
			AddHandler Me.LsvTR.Click, AddressOf Me.LsvTRClick
			AddHandler Me.LsvTR.SelectedIndexChanged, AddressOf Me.LsvTRSelectedIndexChanged
			'
			'BtnValidTR
			'
			Me.BtnValidTR.BackColor = System.Drawing.Color.Green
			Me.BtnValidTR.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnValidTR.ForeColor = System.Drawing.Color.White
			Me.BtnValidTR.Location = New System.Drawing.Point(882, 284)
			Me.BtnValidTR.Name = "BtnValidTR"
			Me.BtnValidTR.Size = New System.Drawing.Size(128, 58)
			Me.BtnValidTR.TabIndex = 31
			Me.BtnValidTR.Text = "Valider"
			AddHandler Me.BtnValidTR.Click, AddressOf Me.BtnValidTRClick
			'
			'TabPag2
			'
			Me.TabPag2.Location = New System.Drawing.Point(4, 4)
			Me.TabPag2.Name = "TabPag2"
			Me.TabPag2.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag2.TabIndex = 7
			Me.TabPag2.Text = "2"
			'
			'TabPag1
			'
			Me.TabPag1.BackColor = System.Drawing.SystemColors.Control
			Me.TabPag1.Location = New System.Drawing.Point(4, 4)
			Me.TabPag1.Name = "TabPag1"
			Me.TabPag1.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag1.TabIndex = 1
			Me.TabPag1.Text = "1"
			'
			'Btn_TR_4
			'
			Me.Btn_TR_4.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_4.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_4.Location = New System.Drawing.Point(32, 122)
			Me.Btn_TR_4.Name = "Btn_TR_4"
			Me.Btn_TR_4.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_4.TabIndex = 4
			Me.Btn_TR_4.Text = "4"
			AddHandler Me.Btn_TR_4.Click, AddressOf Me.Btn_TR_4Click
			'
			'Btn_TR_5
			'
			Me.Btn_TR_5.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_5.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_5.Location = New System.Drawing.Point(92, 122)
			Me.Btn_TR_5.Name = "Btn_TR_5"
			Me.Btn_TR_5.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_5.TabIndex = 5
			Me.Btn_TR_5.Text = "5"
			AddHandler Me.Btn_TR_5.Click, AddressOf Me.Btn_TR_5Click
			'
			'Btn_TR_6
			'
			Me.Btn_TR_6.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_6.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_6.Location = New System.Drawing.Point(152, 122)
			Me.Btn_TR_6.Name = "Btn_TR_6"
			Me.Btn_TR_6.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_6.TabIndex = 6
			Me.Btn_TR_6.Text = "6"
			AddHandler Me.Btn_TR_6.Click, AddressOf Me.Btn_TR_6Click
			'
			'Btn_TR_7
			'
			Me.Btn_TR_7.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_7.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_7.Location = New System.Drawing.Point(32, 172)
			Me.Btn_TR_7.Name = "Btn_TR_7"
			Me.Btn_TR_7.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_7.TabIndex = 7
			Me.Btn_TR_7.Text = "7"
			AddHandler Me.Btn_TR_7.Click, AddressOf Me.Btn_TR_7Click
			'
			'Btn_TR_0
			'
			Me.Btn_TR_0.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_0.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_0.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_0.Location = New System.Drawing.Point(32, 222)
			Me.Btn_TR_0.Name = "Btn_TR_0"
			Me.Btn_TR_0.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_0.TabIndex = 32
			Me.Btn_TR_0.Text = "0"
			AddHandler Me.Btn_TR_0.Click, AddressOf Me.Btn_TR_0Click
			'
			'Btn_TR_1
			'
			Me.Btn_TR_1.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_1.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_1.Location = New System.Drawing.Point(32, 72)
			Me.Btn_TR_1.Name = "Btn_TR_1"
			Me.Btn_TR_1.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_1.TabIndex = 1
			Me.Btn_TR_1.Text = "1"
			AddHandler Me.Btn_TR_1.Click, AddressOf Me.Btn_TR_9Click
			'
			'Btn_TR_2
			'
			Me.Btn_TR_2.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_2.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_2.Location = New System.Drawing.Point(92, 72)
			Me.Btn_TR_2.Name = "Btn_TR_2"
			Me.Btn_TR_2.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_2.TabIndex = 2
			Me.Btn_TR_2.Text = "2"
			AddHandler Me.Btn_TR_2.Click, AddressOf Me.Btn_TR_2Click
			'
			'Btn_TR_3
			'
			Me.Btn_TR_3.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_3.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_3.Location = New System.Drawing.Point(152, 72)
			Me.Btn_TR_3.Name = "Btn_TR_3"
			Me.Btn_TR_3.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_3.TabIndex = 3
			Me.Btn_TR_3.Text = "3"
			AddHandler Me.Btn_TR_3.Click, AddressOf Me.Btn_TR_3Click
			'
			'DisplayTimer2
			'
			Me.DisplayTimer2.Interval = 3000
			AddHandler Me.DisplayTimer2.Tick, AddressOf Me.DisplayTimer2Tick
			'
			'CMenu1
			'
			Me.CMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
			'
			'BtnAttente
			'
			Me.BtnAttente.BackColor = System.Drawing.Color.Transparent
			Me.BtnAttente.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAttente.ForeColor = System.Drawing.Color.Black
			Me.BtnAttente.Location = New System.Drawing.Point(904, 194)
			Me.BtnAttente.Name = "BtnAttente"
			Me.BtnAttente.Size = New System.Drawing.Size(110, 42)
			Me.BtnAttente.TabIndex = 46
			Me.BtnAttente.Text = "Mettre en Attente"
			AddHandler Me.BtnAttente.Click, AddressOf Me.BtnAttenteClick
			'
			'Btn_TR_8
			'
			Me.Btn_TR_8.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_8.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_8.Location = New System.Drawing.Point(92, 172)
			Me.Btn_TR_8.Name = "Btn_TR_8"
			Me.Btn_TR_8.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_8.TabIndex = 10
			Me.Btn_TR_8.Text = "8"
			AddHandler Me.Btn_TR_8.Click, AddressOf Me.Btn_TR_8Click
			'
			'Btn_TR_9
			'
			Me.Btn_TR_9.BackColor = System.Drawing.Color.Gray
			Me.Btn_TR_9.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TR_9.ForeColor = System.Drawing.Color.White
			Me.Btn_TR_9.Location = New System.Drawing.Point(152, 172)
			Me.Btn_TR_9.Name = "Btn_TR_9"
			Me.Btn_TR_9.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TR_9.TabIndex = 9
			Me.Btn_TR_9.Text = "9"
			AddHandler Me.Btn_TR_9.Click, AddressOf Me.Btn_TR_9Click
			'
			'TxtTotal
			'
			Me.TxtTotal.BackColor = System.Drawing.Color.Red
			Me.TxtTotal.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtTotal.ForeColor = System.Drawing.Color.White
			Me.TxtTotal.Location = New System.Drawing.Point(228, 302)
			Me.TxtTotal.Name = "TxtTotal"
			Me.TxtTotal.Size = New System.Drawing.Size(120, 40)
			Me.TxtTotal.TabIndex = 35
			Me.TxtTotal.Text = ""
			Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			'
			'label8
			'
			Me.label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label8.Location = New System.Drawing.Point(290, 30)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(256, 32)
			Me.label8.TabIndex = 30
			Me.label8.Text = "Ticket Restaurant"
			Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label9
			'
			Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label9.Location = New System.Drawing.Point(708, 296)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(62, 24)
			Me.label9.TabIndex = 45
			Me.label9.Text = "Total :"
			'
			'label15
			'
			Me.label15.BackColor = System.Drawing.Color.Green
			Me.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label15.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label15.ForeColor = System.Drawing.Color.White
			Me.label15.Location = New System.Drawing.Point(26, 22)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(198, 34)
			Me.label15.TabIndex = 52
			Me.label15.Text = "Montant de l'Avoir"
			Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label14
			'
			Me.label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label14.Location = New System.Drawing.Point(806, 96)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(180, 24)
			Me.label14.TabIndex = 53
			Me.label14.Text = "Nombre d'Avoir"
			Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label4
			'
			Me.label4.BackColor = System.Drawing.Color.Green
			Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label4.ForeColor = System.Drawing.Color.White
			Me.label4.Location = New System.Drawing.Point(76, 212)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(170, 36)
			Me.label4.TabIndex = 95
			Me.label4.Text = "Avoir :"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label5
			'
			Me.label5.Location = New System.Drawing.Point(176, -79)
			Me.label5.Name = "label5"
			Me.label5.TabIndex = 77
			Me.label5.Text = "Total :"
			'
			'label6
			'
			Me.label6.BackColor = System.Drawing.Color.SteelBlue
			Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label6.ForeColor = System.Drawing.Color.White
			Me.label6.Location = New System.Drawing.Point(26, 20)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(192, 34)
			Me.label6.TabIndex = 25
			Me.label6.Text = "Montant du Ticket"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label7
			'
			Me.label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label7.Location = New System.Drawing.Point(806, 138)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(180, 24)
			Me.label7.TabIndex = 26
			Me.label7.Text = "Nombre de Ticket"
			Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'BtnCPay
			'
			Me.BtnCPay.BackColor = System.Drawing.Color.Gray
			Me.BtnCPay.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnCPay.ForeColor = System.Drawing.Color.Red
			Me.BtnCPay.Location = New System.Drawing.Point(550, 172)
			Me.BtnCPay.Name = "BtnCPay"
			Me.BtnCPay.Size = New System.Drawing.Size(60, 50)
			Me.BtnCPay.TabIndex = 88
			Me.BtnCPay.Text = "C"
			AddHandler Me.BtnCPay.Click, AddressOf Me.BtnCClick
			'
			'label12
			'
			Me.label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label12.Location = New System.Drawing.Point(290, 30)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(256, 32)
			Me.label12.TabIndex = 57
			Me.label12.Text = "Avoir"
			Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label2
			'
			Me.label2.BackColor = System.Drawing.Color.Red
			Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label2.ForeColor = System.Drawing.Color.White
			Me.label2.Location = New System.Drawing.Point(78, 112)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(168, 36)
			Me.label2.TabIndex = 89
			Me.label2.Text = "Reste A payer :"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'DisplayTimer
			'
			Me.DisplayTimer.Interval = 3000
			AddHandler Me.DisplayTimer.Tick, AddressOf Me.DisplayTimerTick
			'
			'BtnCancel
			'
			Me.BtnCancel.BackColor = System.Drawing.Color.Gray
			Me.BtnCancel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnCancel.ForeColor = System.Drawing.Color.Red
			Me.BtnCancel.Location = New System.Drawing.Point(60, 160)
			Me.BtnCancel.Name = "BtnCancel"
			Me.BtnCancel.Size = New System.Drawing.Size(120, 50)
			Me.BtnCancel.TabIndex = 32
			Me.BtnCancel.Text = "C"
			AddHandler Me.BtnCancel.Click, AddressOf Me.BtnCancelClick
			'
			'Btn_TabAvoir_9
			'
			Me.Btn_TabAvoir_9.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_9.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_9.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_9.Location = New System.Drawing.Point(152, 172)
			Me.Btn_TabAvoir_9.Name = "Btn_TabAvoir_9"
			Me.Btn_TabAvoir_9.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_9.TabIndex = 48
			Me.Btn_TabAvoir_9.Text = "9"
			AddHandler Me.Btn_TabAvoir_9.Click, AddressOf Me.Btn_TabAvoir_9Click
			'
			'TxtTotalNavig
			'
			Me.TxtTotalNavig.Enabled = false
			Me.TxtTotalNavig.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.TxtTotalNavig.ForeColor = System.Drawing.SystemColors.WindowText
			Me.TxtTotalNavig.Location = New System.Drawing.Point(770, 294)
			Me.TxtTotalNavig.Name = "TxtTotalNavig"
			Me.TxtTotalNavig.Size = New System.Drawing.Size(120, 29)
			Me.TxtTotalNavig.TabIndex = 44
			Me.TxtTotalNavig.Text = ""
			Me.TxtTotalNavig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			'
			'BtnAnnul
			'
			Me.BtnAnnul.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnAnnul.Location = New System.Drawing.Point(904, 236)
			Me.BtnAnnul.Name = "BtnAnnul"
			Me.BtnAnnul.Size = New System.Drawing.Size(110, 46)
			Me.BtnAnnul.TabIndex = 33
			Me.BtnAnnul.Text = "Annuler le Panier"
			AddHandler Me.BtnAnnul.Click, AddressOf Me.BtnAnnulClick
			'
			'Lbl_TabTR_Avoir
			'
			Me.Lbl_TabTR_Avoir.BackColor = System.Drawing.Color.Green
			Me.Lbl_TabTR_Avoir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.Lbl_TabTR_Avoir.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Lbl_TabTR_Avoir.ForeColor = System.Drawing.Color.White
			Me.Lbl_TabTR_Avoir.Location = New System.Drawing.Point(290, 294)
			Me.Lbl_TabTR_Avoir.Name = "Lbl_TabTR_Avoir"
			Me.Lbl_TabTR_Avoir.Size = New System.Drawing.Size(160, 30)
			Me.Lbl_TabTR_Avoir.TabIndex = 37
			Me.Lbl_TabTR_Avoir.Text = "Avoir :"
			Me.Lbl_TabTR_Avoir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn3
			'
			Me.Btn3.BackColor = System.Drawing.Color.Gray
			Me.Btn3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn3.ForeColor = System.Drawing.Color.Snow
			Me.Btn3.Location = New System.Drawing.Point(120, 10)
			Me.Btn3.Name = "Btn3"
			Me.Btn3.Size = New System.Drawing.Size(60, 50)
			Me.Btn3.TabIndex = 22
			Me.Btn3.Text = "3"
			AddHandler Me.Btn3.Click, AddressOf Me.Btn3Click
			'
			'Btn0
			'
			Me.Btn0.BackColor = System.Drawing.Color.Gray
			Me.Btn0.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn0.ForeColor = System.Drawing.Color.Snow
			Me.Btn0.Location = New System.Drawing.Point(0, 160)
			Me.Btn0.Name = "Btn0"
			Me.Btn0.Size = New System.Drawing.Size(60, 50)
			Me.Btn0.TabIndex = 30
			Me.Btn0.Text = "0"
			AddHandler Me.Btn0.Click, AddressOf Me.Btn0Click
			'
			'Btn6
			'
			Me.Btn6.BackColor = System.Drawing.Color.Gray
			Me.Btn6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn6.ForeColor = System.Drawing.Color.Snow
			Me.Btn6.Location = New System.Drawing.Point(120, 60)
			Me.Btn6.Name = "Btn6"
			Me.Btn6.Size = New System.Drawing.Size(60, 50)
			Me.Btn6.TabIndex = 25
			Me.Btn6.Text = "6"
			AddHandler Me.Btn6.Click, AddressOf Me.Btn6Click
			'
			'CMenuBtn
			'
			Me.CMenuBtn.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuCopieCoul, Me.menuColleCoul, Me.MenuCoupeBtn, Me.MenuColleBtn, Me.MenuCopieBtn})
			'
			'button36
			'
			Me.button36.BackColor = System.Drawing.Color.Yellow
			Me.button36.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button36.ForeColor = System.Drawing.Color.Black
			Me.button36.Location = New System.Drawing.Point(662, 50)
			Me.button36.Name = "button36"
			Me.button36.Size = New System.Drawing.Size(128, 58)
			Me.button36.TabIndex = 99
			Me.button36.Text = "ESPECES"
			AddHandler Me.button36.Click, AddressOf Me.Button2Click
			'
			'button35
			'
			Me.button35.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button35.Location = New System.Drawing.Point(830, 132)
			Me.button35.Name = "button35"
			Me.button35.Size = New System.Drawing.Size(128, 58)
			Me.button35.TabIndex = 100
			Me.button35.Text = "CHEQUES"
			AddHandler Me.button35.Click, AddressOf Me.BtnCheqClick
			'
			'button34
			'
			Me.button34.BackColor = System.Drawing.Color.SteelBlue
			Me.button34.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button34.ForeColor = System.Drawing.Color.White
			Me.button34.Location = New System.Drawing.Point(830, 50)
			Me.button34.Name = "button34"
			Me.button34.Size = New System.Drawing.Size(128, 58)
			Me.button34.TabIndex = 101
			Me.button34.Text = "TICKET RESTO"
			AddHandler Me.button34.Click, AddressOf Me.BtnTRClick
			'
			'MenuCoupeBtn
			'
			Me.MenuCoupeBtn.Index = 4
			Me.MenuCoupeBtn.Text = "Couper le bouton"
			AddHandler Me.MenuCoupeBtn.Click, AddressOf Me.MenuCoupeBtnClick
			'
			'button32
			'
			Me.button32.BackColor = System.Drawing.Color.Gray
			Me.button32.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button32.ForeColor = System.Drawing.Color.Snow
			Me.button32.Location = New System.Drawing.Point(490, 22)
			Me.button32.Name = "button32"
			Me.button32.Size = New System.Drawing.Size(60, 50)
			Me.button32.TabIndex = 79
			Me.button32.Text = "2"
			AddHandler Me.button32.Click, AddressOf Me.Button32Click
			'
			'button31
			'
			Me.button31.BackColor = System.Drawing.Color.Gray
			Me.button31.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button31.ForeColor = System.Drawing.Color.Snow
			Me.button31.Location = New System.Drawing.Point(550, 22)
			Me.button31.Name = "button31"
			Me.button31.Size = New System.Drawing.Size(60, 50)
			Me.button31.TabIndex = 80
			Me.button31.Text = "3"
			AddHandler Me.button31.Click, AddressOf Me.Button31Click
			'
			'button30
			'
			Me.button30.BackColor = System.Drawing.Color.Gray
			Me.button30.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button30.ForeColor = System.Drawing.Color.Snow
			Me.button30.Location = New System.Drawing.Point(430, 72)
			Me.button30.Name = "button30"
			Me.button30.Size = New System.Drawing.Size(60, 50)
			Me.button30.TabIndex = 81
			Me.button30.Text = "4"
			AddHandler Me.button30.Click, AddressOf Me.Button30Click
			'
			'TabPag0
			'
			Me.TabPag0.Location = New System.Drawing.Point(4, 4)
			Me.TabPag0.Name = "TabPag0"
			Me.TabPag0.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag0.TabIndex = 0
			Me.TabPag0.Text = "0"
			'
			'BtnEsp
			'
			Me.BtnEsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnEsp.Location = New System.Drawing.Point(360, 260)
			Me.BtnEsp.Name = "BtnEsp"
			Me.BtnEsp.Size = New System.Drawing.Size(84, 50)
			Me.BtnEsp.TabIndex = 1
			Me.BtnEsp.Text = "Appoint"
			AddHandler Me.BtnEsp.Click, AddressOf Me.BtnEspClick
			'
			'TabPag6
			'
			Me.TabPag6.Location = New System.Drawing.Point(4, 4)
			Me.TabPag6.Name = "TabPag6"
			Me.TabPag6.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag6.TabIndex = 9
			Me.TabPag6.Text = "6"
			'
			'TabPag5
			'
			Me.TabPag5.Location = New System.Drawing.Point(4, 4)
			Me.TabPag5.Name = "TabPag5"
			Me.TabPag5.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag5.TabIndex = 3
			Me.TabPag5.Text = "5"
			'
			'TabPag4
			'
			Me.TabPag4.Location = New System.Drawing.Point(4, 4)
			Me.TabPag4.Name = "TabPag4"
			Me.TabPag4.Size = New System.Drawing.Size(1018, 367)
			Me.TabPag4.TabIndex = 8
			Me.TabPag4.Text = "4"
			'
			'BtnCheq
			'
			Me.BtnCheq.Location = New System.Drawing.Point(456, -31)
			Me.BtnCheq.Name = "BtnCheq"
			Me.BtnCheq.TabIndex = 72
			Me.BtnCheq.Text = "ChÃ¨ques"
			AddHandler Me.BtnCheq.Click, AddressOf Me.BtnCheqClick
			'
			'Lbl_TabAvoir_Reste
			'
			Me.Lbl_TabAvoir_Reste.BackColor = System.Drawing.Color.Yellow
			Me.Lbl_TabAvoir_Reste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.Lbl_TabAvoir_Reste.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Lbl_TabAvoir_Reste.ForeColor = System.Drawing.Color.Black
			Me.Lbl_TabAvoir_Reste.Location = New System.Drawing.Point(290, 254)
			Me.Lbl_TabAvoir_Reste.Name = "Lbl_TabAvoir_Reste"
			Me.Lbl_TabAvoir_Reste.Size = New System.Drawing.Size(160, 30)
			Me.Lbl_TabAvoir_Reste.TabIndex = 61
			Me.Lbl_TabAvoir_Reste.Text = "Reste A  Payer :"
			Me.Lbl_TabAvoir_Reste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn_TabAvoir_6
			'
			Me.Btn_TabAvoir_6.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_6.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_6.Location = New System.Drawing.Point(152, 122)
			Me.Btn_TabAvoir_6.Name = "Btn_TabAvoir_6"
			Me.Btn_TabAvoir_6.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_6.TabIndex = 45
			Me.Btn_TabAvoir_6.Text = "6"
			AddHandler Me.Btn_TabAvoir_6.Click, AddressOf Me.Btn_TabAvoir_6Click
			'
			'Btn_TabAvoir_7
			'
			Me.Btn_TabAvoir_7.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_7.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_7.Location = New System.Drawing.Point(32, 172)
			Me.Btn_TabAvoir_7.Name = "Btn_TabAvoir_7"
			Me.Btn_TabAvoir_7.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_7.TabIndex = 46
			Me.Btn_TabAvoir_7.Text = "7"
			AddHandler Me.Btn_TabAvoir_7.Click, AddressOf Me.Btn_TabAvoir_7Click
			'
			'Btn_TabAvoir_4
			'
			Me.Btn_TabAvoir_4.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_4.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_4.Location = New System.Drawing.Point(32, 122)
			Me.Btn_TabAvoir_4.Name = "Btn_TabAvoir_4"
			Me.Btn_TabAvoir_4.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_4.TabIndex = 43
			Me.Btn_TabAvoir_4.Text = "4"
			AddHandler Me.Btn_TabAvoir_4.Click, AddressOf Me.Btn_TabAvoir_4Click
			'
			'Btn_TabAvoir_5
			'
			Me.Btn_TabAvoir_5.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_5.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_5.Location = New System.Drawing.Point(92, 122)
			Me.Btn_TabAvoir_5.Name = "Btn_TabAvoir_5"
			Me.Btn_TabAvoir_5.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_5.TabIndex = 44
			Me.Btn_TabAvoir_5.Text = "5"
			AddHandler Me.Btn_TabAvoir_5.Click, AddressOf Me.Btn_TabAvoir_5Click
			'
			'Btn_TabAvoir_2
			'
			Me.Btn_TabAvoir_2.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_2.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_2.Location = New System.Drawing.Point(92, 72)
			Me.Btn_TabAvoir_2.Name = "Btn_TabAvoir_2"
			Me.Btn_TabAvoir_2.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_2.TabIndex = 41
			Me.Btn_TabAvoir_2.Text = "2"
			AddHandler Me.Btn_TabAvoir_2.Click, AddressOf Me.Btn_TabAvoir_2Click
			'
			'Btn_DwnNbTR
			'
			Me.Btn_DwnNbTR.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_DwnNbTR.Location = New System.Drawing.Point(816, 178)
			Me.Btn_DwnNbTR.Name = "Btn_DwnNbTR"
			Me.Btn_DwnNbTR.Size = New System.Drawing.Size(56, 40)
			Me.Btn_DwnNbTR.TabIndex = 28
			Me.Btn_DwnNbTR.Text = "-"
			AddHandler Me.Btn_DwnNbTR.Click, AddressOf Me.Btn_DwnNbTRClick
			'
			'Btn_TabAvoir_0
			'
			Me.Btn_TabAvoir_0.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_0.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_0.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_0.Location = New System.Drawing.Point(32, 222)
			Me.Btn_TabAvoir_0.Name = "Btn_TabAvoir_0"
			Me.Btn_TabAvoir_0.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_0.TabIndex = 59
			Me.Btn_TabAvoir_0.Text = "0"
			AddHandler Me.Btn_TabAvoir_0.Click, AddressOf Me.Btn_TabAvoir_0Click
			'
			'Btn_TabAvoir_1
			'
			Me.Btn_TabAvoir_1.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_1.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_1.Location = New System.Drawing.Point(32, 72)
			Me.Btn_TabAvoir_1.Name = "Btn_TabAvoir_1"
			Me.Btn_TabAvoir_1.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_1.TabIndex = 40
			Me.Btn_TabAvoir_1.Text = "1"
			AddHandler Me.Btn_TabAvoir_1.Click, AddressOf Me.Btn_TabAvoir_1Click
			'
			'Btn_TabAvoir_8
			'
			Me.Btn_TabAvoir_8.BackColor = System.Drawing.Color.Gray
			Me.Btn_TabAvoir_8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_8.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_8.Location = New System.Drawing.Point(92, 172)
			Me.Btn_TabAvoir_8.Name = "Btn_TabAvoir_8"
			Me.Btn_TabAvoir_8.Size = New System.Drawing.Size(60, 50)
			Me.Btn_TabAvoir_8.TabIndex = 49
			Me.Btn_TabAvoir_8.Text = "8"
			AddHandler Me.Btn_TabAvoir_8.Click, AddressOf Me.Btn_TabAvoir_8Click
			'
			'BtnEspece
			'
			Me.BtnEspece.Location = New System.Drawing.Point(456, -79)
			Me.BtnEspece.Name = "BtnEspece"
			Me.BtnEspece.TabIndex = 71
			Me.BtnEspece.Text = "EspÃ¨ces"
			AddHandler Me.BtnEspece.Click, AddressOf Me.Button2Click
			'
			'BtnPay2
			'
			Me.BtnPay2.Location = New System.Drawing.Point(0, 0)
			Me.BtnPay2.Name = "BtnPay2"
			Me.BtnPay2.TabIndex = 0
			'
			'BtnCaisse
			'
			Me.BtnCaisse.Enabled = false
			Me.BtnCaisse.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.BtnCaisse.Location = New System.Drawing.Point(946, 2)
			Me.BtnCaisse.Name = "BtnCaisse"
			Me.BtnCaisse.Size = New System.Drawing.Size(78, 52)
			Me.BtnCaisse.TabIndex = 47
			Me.BtnCaisse.Text = "Faire sa caisse :  14 h"
			AddHandler Me.BtnCaisse.Click, AddressOf Me.BtnCaisseClick
			'
			'Lbl_NbTR
			'
			Me.Lbl_NbTR.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Lbl_NbTR.Location = New System.Drawing.Point(872, 180)
			Me.Lbl_NbTR.Name = "Lbl_NbTR"
			Me.Lbl_NbTR.Size = New System.Drawing.Size(48, 40)
			Me.Lbl_NbTR.TabIndex = 29
			Me.Lbl_NbTR.Text = "1"
			Me.Lbl_NbTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'label1
			'
			Me.label1.BackColor = System.Drawing.Color.Red
			Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(14, 302)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(134, 40)
			Me.label1.TabIndex = 36
			Me.label1.Text = "Total :"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'Btn_TabAvoir_Valid
			'
			Me.Btn_TabAvoir_Valid.BackColor = System.Drawing.Color.Green
			Me.Btn_TabAvoir_Valid.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Btn_TabAvoir_Valid.ForeColor = System.Drawing.Color.White
			Me.Btn_TabAvoir_Valid.Location = New System.Drawing.Point(882, 284)
			Me.Btn_TabAvoir_Valid.Name = "Btn_TabAvoir_Valid"
			Me.Btn_TabAvoir_Valid.Size = New System.Drawing.Size(128, 58)
			Me.Btn_TabAvoir_Valid.TabIndex = 58
			Me.Btn_TabAvoir_Valid.Text = "Valider"
			AddHandler Me.Btn_TabAvoir_Valid.Click, AddressOf Me.Btn_TabAvoir_ValidClick
			'
			'BtnTVA
			'
			Me.BtnTVA.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnTVA.Location = New System.Drawing.Point(468, 282)
			Me.BtnTVA.Name = "BtnTVA"
			Me.BtnTVA.Size = New System.Drawing.Size(128, 58)
			Me.BtnTVA.TabIndex = 102
			Me.BtnTVA.Tag = ""
			Me.BtnTVA.Text = "A Emporter"
			AddHandler Me.BtnTVA.Click, AddressOf Me.BtnTVAClick
			'
			'buttonCancel
			'
			Me.buttonCancel.Location = New System.Drawing.Point(0, 0)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.TabIndex = 0
			'
			'LblDate
			'
			Me.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.LblDate.Font = New System.Drawing.Font("Tahoma", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.LblDate.Location = New System.Drawing.Point(238, 6)
			Me.LblDate.Name = "LblDate"
			Me.LblDate.Size = New System.Drawing.Size(110, 24)
			Me.LblDate.TabIndex = 54
			Me.LblDate.Text = "Mer. 01/01"
			Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'BtnNewTR
			'
			Me.BtnNewTR.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnNewTR.Location = New System.Drawing.Point(602, 78)
			Me.BtnNewTR.Name = "BtnNewTR"
			Me.BtnNewTR.Size = New System.Drawing.Size(128, 58)
			Me.BtnNewTR.TabIndex = 41
			Me.BtnNewTR.Text = "Nouveau Ticket"
			AddHandler Me.BtnNewTR.Click, AddressOf Me.BtnNewTRClick
			'
			'BtnPaye
			'
			Me.BtnPaye.Enabled = false
			Me.BtnPaye.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.BtnPaye.Location = New System.Drawing.Point(444, 260)
			Me.BtnPaye.Name = "BtnPaye"
			Me.BtnPaye.Size = New System.Drawing.Size(98, 50)
			Me.BtnPaye.TabIndex = 38
			Me.BtnPaye.Text = "Paiement"
			AddHandler Me.BtnPaye.Click, AddressOf Me.BtnPayeClick
			'
			'Txt_TabAvoir_Reste
			'
			Me.Txt_TabAvoir_Reste.BackColor = System.Drawing.Color.Yellow
			Me.Txt_TabAvoir_Reste.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.Txt_TabAvoir_Reste.ForeColor = System.Drawing.Color.Black
			Me.Txt_TabAvoir_Reste.Location = New System.Drawing.Point(470, 254)
			Me.Txt_TabAvoir_Reste.Name = "Txt_TabAvoir_Reste"
			Me.Txt_TabAvoir_Reste.Size = New System.Drawing.Size(76, 32)
			Me.Txt_TabAvoir_Reste.TabIndex = 63
			Me.Txt_TabAvoir_Reste.Text = "0"
			'
			'columnHeader2
			'
			Me.columnHeader2.Width = 220
			'
			'LblHeure
			'
			Me.LblHeure.BackColor = System.Drawing.Color.Red
			Me.LblHeure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.LblHeure.Font = New System.Drawing.Font("Tahoma", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
			Me.LblHeure.ForeColor = System.Drawing.Color.White
			Me.LblHeure.Location = New System.Drawing.Point(14, 4)
			Me.LblHeure.Name = "LblHeure"
			Me.LblHeure.Size = New System.Drawing.Size(110, 30)
			Me.LblHeure.TabIndex = 55
			Me.LblHeure.Text = "00:00:00"
			Me.LblHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'button1
			'
			Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.button1.Location = New System.Drawing.Point(556, 2)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(106, 34)
			Me.button1.TabIndex = 39
			Me.button1.Text = "PRECEDANT"
			AddHandler Me.button1.Click, AddressOf Me.Button1Click
			'
			'listBOX
			'
			Me.listBOX.AllowColumnReorder = true
			Me.listBOX.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
			Me.listBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.listBOX.ForeColor = System.Drawing.SystemColors.WindowText
			Me.listBOX.FullRowSelect = true
			Me.listBOX.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
			Me.listBOX.HideSelection = false
			Me.listBOX.Location = New System.Drawing.Point(14, 38)
			Me.listBOX.MultiSelect = false
			Me.listBOX.Name = "listBOX"
			Me.listBOX.Size = New System.Drawing.Size(334, 250)
			Me.listBOX.TabIndex = 18
			Me.listBOX.View = System.Windows.Forms.View.Details
			AddHandler Me.listBOX.SelectedIndexChanged, AddressOf Me.ListBOXSelectedIndexChanged
			'
			'MainForm
			'
			Me.AllowDrop = true
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(1024, 768)
			Me.ControlBox = false
			Me.Controls.Add(Me.BtnAvance)
			Me.Controls.Add(Me.BtnTab3)
			Me.Controls.Add(Me.PanelPaveNum)
			Me.Controls.Add(Me.LblHeure)
			Me.Controls.Add(Me.LblDate)
			Me.Controls.Add(Me.BtnPrintTicket)
			Me.Controls.Add(Me.BtnTab4)
			Me.Controls.Add(Me.BtnTab6)
			Me.Controls.Add(Me.BtnTab2)
			Me.Controls.Add(Me.BtnCaisse)
			Me.Controls.Add(Me.BtnAttente)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.TxtTotalNavig)
			Me.Controls.Add(Me.LstNavig)
			Me.Controls.Add(Me.BtnTab5)
			Me.Controls.Add(Me.BtnTab1)
			Me.Controls.Add(Me.BtnTab0)
			Me.Controls.Add(Me.LblIdClient)
			Me.Controls.Add(Me.button22)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.BtnPaye)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.TxtTotal)
			Me.Controls.Add(Me.BtnAnnul)
			Me.Controls.Add(Me.listBOX)
			Me.Controls.Add(Me.tabControl1)
			Me.Controls.Add(Me.BtnEsp)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "MainForm"
			Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(255,Byte), CType(192,Byte), CType(128,Byte))
			AddHandler Closing, AddressOf Me.MainFormClosing
			AddHandler Load, AddressOf Me.MainFormLoad
			Me.tabPagTR.ResumeLayout(false)
			Me.tabPagPaye.ResumeLayout(false)
			Me.PanelPaveNum.ResumeLayout(false)
			Me.tabControl1.ResumeLayout(false)
			Me.tabPageAvoir.ResumeLayout(false)
			Me.ResumeLayout(false)
		End Sub
	#End Region
		
	Private Sub MainFormLoad(sender As System.Object, e As System.EventArgs)
			Me.contextmenu=CMenu1
			LireBouton()
			ReadConfig()
			
			Tabcontrol1.SelectedIndex=1
			Tabcontrol1.SelectedIndex=0
			
			timer1.Interval=1000
			timer1.Start
			lbldate.Text=now.Date.tostring("ddd d/MM")  
			LblHeure.Text=now.tolongtimestring
			
			BtnTVA.Tag="5,5"
			
			InitPrinter()
			InitLineDisplay()				
			InitDrawer()
			Try
				g_Display.DisplayText("Bonjour !", DisplayTextMode.Normal)
			Catch ex As PosControlException
				MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
       		End Try
		End Sub			
		
'	#####		GESTION DE L'HORLOGE		######
	Private Sub Timer1Tick(sender As System.Object, e As System.EventArgs)
		lbldate.Text=now.Date.tostring("ddd d/MM")  
		LblHeure.Text=now.tolongtimestring
	End Sub
	
	'#####		PROCEDURE APPELEE PAR LES BOUTONS REPRESENTANT LES ONGLETS		######
	Private Sub BtnTabClick(sender As System.Object, e As System.EventArgs)
		Tabcontrol1.SelectedIndex = CInt(sender.tag)		
	End Sub	
	
	Private Sub TabControl1SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
		BtnTab0.BackColor=Color.FromName("Control")
		BtnTab1.BackColor=Color.FromName("Control")
		BtnTab2.BackColor=Color.FromName("Control")
		BtnTab3.BackColor=Color.FromName("Control")
		BtnTab4.BackColor=Color.FromName("Control")
		BtnTab5.BackColor=Color.FromName("Control")
		BtnTab6.BackColor=Color.FromName("Control")
		Select Case Tabcontrol1.SelectedIndex
			Case 0
			BtnTab0.BackColor=Color.Gray
			Case 1
			BtnTab1.BackColor=Color.Gray	
			Case 2
			BtnTab2.BackColor=Color.Gray
			Case 3
			BtnTab3.BackColor=Color.Gray	
			Case 4
			BtnTab4.BackColor=Color.Gray	
			Case 5
			BtnTab5.BackColor=Color.Gray	
			Case 6				
			BtnTab6.BackColor=Color.Gray	
		End Select
		
	End Sub
	
	Public Sub AjouteProduit (Prod as Object)
		Dim LVI As New ListViewItem
		Dim Prix As Single=Prod.tag
		Dim Texte As String =Prod.text
		Dim lTexte as Integer=Texte.length
		Dim lPrix as integer=Cstr(Prix.ToString("#,##0.00")).Length
		Dim Quantite As Integer
		Dim strDisplay As String=""
		Dim strQty as string
		
		label1.BackColor=Color.red
		label1.ForeColor=color.white
		label1.Text="Total :"
		txttotal.BackColor=color.red
		txttotal.ForeColor=color.white
		
		DisplayTimer.Stop
		DisplayTimer2.Stop
		
		Texte=Texte.Remove(lTexte-(lPrix+2),(lPrix+2))
		Texte=Texte.Replace((Chr(13)& Chr(10 )),"")
		FlagPaveNum = False
		
		If lsvpaye.Items.count>0 Then
			lsvpaye.Items.clear
		End If
		
		'si le produit est deja dans le listbox, +1 en quantit
		For i as integer = 0 To Listbox.items.count - 1
			If Listbox.items(i).subitems(1).text = texte Then
				Listbox.items(i).text += 1					
				Quantite = Cint(Listbox.items(i).text)
				Listbox.items(i).subitems(2).text = (Prix * Quantite).ToString("#,##0.00")
				
				'affiche le produit pour le client
				strQty=Cstr(Quantite) & "x "
				strDisplay=strQty & Texte
				Try 
					PrintDisplay(strDisplay, (Prix * Quantite).ToString("#,##0.00"))
				Catch ex As PosControlException		        
					MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
				End Try
				Listbox.items(i).selected = true
				CalculTotal()
				Exit Sub
			End If
		Next i
		
		'ajoute le produit dans le listbox
		LVI.text = "1"
		LVI.SubItems.add(texte)
		LVI.SubItems.add(Prix.ToString("#,##0.00"))
		ListBox.Items.Add(LVI)
		
		'affiche le produit pour le client
		strDisplay=Texte
		try
			PrintDisplay(strDisplay, Cstr(Prix.ToString("#,##0.00")))
		Catch ex As PosControlException		        
			MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
		End Try
		CalculTotal()
		Listbox.items(listbox.items.count-1).selected = True		
	End Sub
	
	Public Sub CalculTotal()
		Dim Total As Single
		
		Total = 0
		For i As Integer = 0 To Listbox.items.count -1
			Total += Listbox.items(i).subitems(2).text	
		Next i
			
		Paiement.total=total
		AffichePaiement()
	End Sub
		
	#Region "Gestion Pav numrique de la Form Principal"
	Private Sub Btn1Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn0Click(sender As System.Object, e As System.EventArgs)
	
		If FlagPaveNum = false then
			Exit Sub
		Else
			ModifyQuantity(sender.text)
		End If
			
	End Sub
	
	Private Sub Btn2Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn3Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn4Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn5Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn6Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn7Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)		
	End Sub
	
	Private Sub Btn8Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)
	End Sub
	
	Private Sub Btn9Click(sender As System.Object, e As System.EventArgs)
		ModifyQuantity(sender.text)	
	End Sub
	
	Private Sub BtnCancelClick(sender As System.Object, e As System.EventArgs)
		If Listbox.selecteditems.count > 0 then
			Listbox.selecteditems(0).remove
			calcultotal()
		End If
		
		try
		PrintDisplay("Reste  payer :", Paiement.total.ToString("#,##0.00"))
		Catch ex As PosControlException		        
			MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
		End Try
	End Sub

	Public Sub ModifyQuantity(ByVal ChiffrePaveNum As Integer )
		Dim Quantite As Integer
		Dim SousTotal As single
		Dim PrixUnitaire As Single = 0
		
			If Listbox.selecteditems.count > 0 then
				If FlagPaveNum = False then
					Quantite = Cint(Listbox.selecteditems(0).text)
					soustotal = Csng(Listbox.selecteditems(0).subitems(2).text)
					Listbox.selecteditems(0).text = ChiffrePaveNum.ToString
					PrixUnitaire = SousTotal / Quantite
					SousTotal = PrixUnitaire * ChiffrePaveNum 	
					Listbox.selecteditems(0).subitems(2).text = soustotal.ToString("#,##0.00")
				Else
					Quantite = Cint(Listbox.selecteditems(0).text)
					soustotal = Csng(Listbox.selecteditems(0).subitems(2).text)
					Listbox.selecteditems(0).text += ChiffrePaveNum.ToString
					PrixUnitaire = SousTotal / Quantite					
					SousTotal = PrixUnitaire * (Quantite & ChiffrePaveNum)
					Listbox.selecteditems(0).subitems(2).text = soustotal.ToString("#,##0.00")
				End If				
			End If					
		FlagPaveNum = True
		CalculTotal()
	End Sub	
		
	#End Region
		
	Private Sub BtnAnnulClick(sender As System.Object, e As System.EventArgs)		
		If listbox.items.count>0 Then
			Listbox.items.clear
			Paiement.clear
			Paiement.Total=0
			
			btncaisse.enabled=true
			panelpavenum.enabled=true
			btnesp.Enabled=true
			btnpaye.Enabled=False
			BtnTab0.enabled=TRUE
			BtnTab1.enabled=TRUE
			BtnTab2.enabled=TRUE
			BtnTab3.enabled=TRUE
			BtnTab4.enabled=TRUE
			BtnTab5.enabled=TRUE
			BtnTab6.enabled=True
			
			AffichePaiement()
			select case tabcontrol1.SelectedIndex
				case 7 to 9
				tabcontrol1.SelectedIndex=0
			End Select
			
			Try
            	g_Display.ClearText()
				g_Display.DisplayText("Bonjour !", DisplayTextMode.Normal)
	        Catch ex As PosControlException	
	        End Try
		End If
	End Sub
	
	Private Sub ListBOXSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
		btnPaye.Enabled=true
		FlagPaveNum = False
	End Sub
		
	Private Sub BtnPayeClick(sender As System.Object, e As System.EventArgs)
		If Listbox.Items.count=0 Then
			Paiement.total=Csng(txttotalnavig.text)
		End If
		
		tabpage=tabcontrol1.SelectedIndex
		tabcontrol1.selectedtab=tabpagpaye
		btnpaye.Enabled=False
		btncaisse.enabled=False
		panelpavenum.enabled=False
		BtnTab0.enabled=false
		BtnTab1.enabled=false
		BtnTab2.enabled=false
		BtnTab3.enabled=false
		BtnTab4.enabled=false
		BtnTab5.enabled=false
		BtnTab6.enabled=False
		btnesp.Enabled=false

		Paiement.Reste=Paiement.Total
		
		'affiche le total du ticket pour le client
		try
		PrintDisplay("Reste  payer :", Paiement.total.tostring("#,##0.00"))
		Catch ex As PosControlException		        
			MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
		End Try
		
		AffichePaiement()
		
		BtnTicket.Text="Sans Ticket"
		BtnTVA.Text="A Emporter"
		BtnTVA.Tag="5,5"
	End Sub
	
	#Region "Gestion du Fichier contenant les infos sur les boutons"
	
'	########	ENREGISTRE LES DONNEES DE CHAQUE BOUTONS DANS LE FICHIER	###########

	Private Sub RecordBouton()
		Dim SW As New StreamWriter ("Boutons")
		Dim strTexte as string
		
		For j As Integer = 0 To tabcontrol1.TabPages.count - 4
			sw.WriteLine("#" & tabcontrol1.TabPages(j).text & "#")
			
			For i As Integer = 0 To tabcontrol1.tabpages(j).controls.count-1
				strTexte=tabcontrol1.tabpages(j).controls(i).text.replace((chr(13)& chr(10)), "||RetourChariot||")
				SW.WriteLine(i.tostring & "§" & strTexte _
							& "§" & tabcontrol1.tabpages(j).controls(i).tag _
							& "§" & tabcontrol1.tabpages(j).controls(i).foreColor.toargb _
							& "§" & tabcontrol1.tabpages(j).controls(i).backColor.toargb)
			Next	
		Next			
		sw.Close()
	End Sub
	
'	###############     LIT LES DONNEES DE CHAQUE BOUTONS :			   			 ##############
'	###############		TEXTE A AFFICHER, PRIX ET COULEURS A PARTIR DU FICHIER   ##############
	
	Private Sub LireBouton() 
		Dim SW As New StreamReader ("Boutons")
		Dim Line As String
		Dim Prod As String() 
		Dim Page As Integer = 0

			For i As Integer=0 To 47
				Dim Btn0 As New Button
				Dim Btn1 As New Button
				Dim Btn2 As New Button
				Dim Btn3 As New Button
				Dim Btn4 As New Button
				Dim Btn5 As New Button
				Dim Btn6 As New Button
				Dim X As Integer = 0
				Dim Y As Integer = 0
				
				select case i
				case < 8 
					X=tabcontrol1.Width-(((8-i)*128)+4)
					Y=0
				case 8 to 15 
					X=tabcontrol1.Width-(((16-i)*128)+4)
					Y=58
				case 16 to 23 
					X=tabcontrol1.Width-(((24-i)*128)+4)
					Y=116
				case 24 to 31 
					X=tabcontrol1.Width-(((32-i)*128)+4)
					Y=174
				case 32 to 39 
					X=tabcontrol1.Width-(((40-i)*128)+4)
					Y=232
				case 40 to 47 
					X=tabcontrol1.Width-(((48-i)*128)+4)
					Y=290
	 			End select
	
				Btn0.Location=New System.Drawing.Point(X,Y)
				Btn1.Location=New System.Drawing.Point(X,Y)
				Btn2.Location=New System.Drawing.Point(X,Y)
				Btn3.Location=New System.Drawing.Point(X,Y)
				Btn4.Location=New System.Drawing.Point(X,Y)
				Btn5.Location=New System.Drawing.Point(X,Y)
				Btn6.Location=New System.Drawing.Point(X,Y)
				
				Btn0.Name="Btn0" & i
				Btn1.Name="Btn1" & i
				Btn2.Name="Btn2" & i
				Btn3.Name="Btn3" & i
				Btn4.Name="Btn4" & i
				Btn5.Name="Btn5" & i
				Btn6.Name="Btn6" & i
				
				Btn0.Size=New System.Drawing.Size(128, 58)
				Btn1.Size=New System.Drawing.Size(128, 58)
				Btn2.Size=New System.Drawing.Size(128, 58)
				Btn3.Size=New System.Drawing.Size(128, 58)
				Btn4.Size=New System.Drawing.Size(128, 58)
				Btn5.Size=New System.Drawing.Size(128, 58)
				Btn6.Size=New System.Drawing.Size(128, 58)
				
				tabcontrol1.tabpages(0).controls.add(Btn0)
				tabcontrol1.tabpages(1).controls.add(Btn1)
				tabcontrol1.tabpages(2).controls.add(Btn2)
				tabcontrol1.tabpages(3).controls.add(Btn3)
				tabcontrol1.tabpages(4).controls.add(Btn4)
				tabcontrol1.tabpages(5).controls.add(Btn5)
				tabcontrol1.tabpages(6).controls.add(Btn6)
				Next

		Do Until Sw.Peek=-1
			Line=Sw.ReadLine()
			Prod=line.Split("¤")			
			
			If line.chars(0)="#" Then
				tabcontrol1.TabPages(Page).text= Prod(0).trim("#")		
				Page+=1
			Else
				With  tabcontrol1.TabPages(Page-1).controls(Prod(0))
					.text=(Prod(1)).replace("||RetourChariot||", (chr(13)& chr(10)))
					.tag=Prod(2)
					.font=New Font(tabcontrol1.Font, fontstyle.Bold)
					.foreColor=Color.FromArgb(Cint(Prod(3)))
					.backColor=Color.FromArgb(Cint(Prod(4)))
				End With
				If Prod(1)="" Then 
					tabcontrol1.TabPages(Page-1).controls(Prod(0)).enabled=False					
				End If
				AddHandler tabcontrol1.TabPages(Page-1).controls(Prod(0)).click, addressof BtnClick
			End If		
		Loop
		Sw.Close()
		
		BtnTab0.Text=TabPag0.text
		BtnTab1.Text=TabPag1.text
		BtnTab2.Text=TabPag2.text
		BtnTab3.Text=TabPag3.text
		BtnTab4.Text=TabPag4.text
		BtnTab5.Text=TabPag5.text
		BtnTab6.Text=TabPag6.text
		
		LockBouton()
	End Sub
	
'	###############     ENABLED=FALSE POUR TOUS LES BOUTONS    ######################
'	###############		DU TABCONTROL POUR MODIFICATIONS	   ######################

	Public Sub UnLockBouton()
		For j As Integer = 0 To tabcontrol1.TabPages.count - 4
			For i As Integer = 0 To tabcontrol1.TabPages(j).controls.count -1
				With tabcontrol1.TabPages(j).controls(i)
					.enabled=True
					.contextmenu = CMenuBtn
				End With
			Next	
		Next	
		Cmenu1.MenuItems(0).text = "Vrouillez les boutons"
	End Sub
	
	
'	###############   ENABLED=TRUE POUR TOUS LES BOUTONS SANS TEXTE   ################
	
	Public Sub LockBouton()
		For j As Integer = 0 To tabcontrol1.TabPages.count - 4
			For i As Integer = 0 To tabcontrol1.TabPages(j).controls.count -1
				If tabcontrol1.TabPages(j).controls(i).text="" Then
					tabcontrol1.TabPages(j).controls(i).enabled=False
				Else
					tabcontrol1.TabPages(j).controls(i).enabled=true
				End If
				tabcontrol1.TabPages(j).controls(i).contextmenu= CMenu1
			Next	
		Next
		Cmenu1.MenuItems(0).text = "Dvrouillez les boutons"
	End Sub
	#End Region
	
	'################
	'Procedure appele par tous les boutons reprsentant un article
	Private Sub BtnClick(sender As System.Object, e As System.EventArgs)
		AjouteProduit (sender)
	End Sub
	'################
	
	#Region "Menu Contextuel"
'	################		MENU VEROUILLE  / DEVEROUILLE LES BOUTONS		################
	Private Sub MenuItem1Click(sender As System.Object, e As System.EventArgs)		
		If Cmenu1.MenuItems(0).text = "Dvrouillez les boutons" Then
			UnLockBouton()	
			BtnCaisse.Text="QUITTER"
			BtnCaisse.Enabled=true
			FlagModifBouton=True
		Else
			LockBouton()			
		End If		
	End Sub
'	################		MENU MODIFIE LE BOUTON		################
	Private Sub MenuItem2Click(sender As System.Object, e As System.EventArgs)
		Dim F As New FrmModif
		Dim Texte As String=CMenuBtn.SourceControl.Text
		Dim Prix As String=CMenuBtn.SourceControl.Tag
		Dim lTexte as Integer=Texte.length
		Dim lPrix as integer
		
		With F.BtnSample
			.text=Texte
			.font=CMenuBtn.SourceControl.Font
			.ForeColor=CMenuBtn.SourceControl.ForeColor
			.BackColor=CMenuBtn.SourceControl.BackColor
		End With
		
		F.BtnForeColor.BackColor=CMenuBtn.SourceControl.ForeColor
		F.BtnBackColor.BackColor=CMenuBtn.SourceControl.BackColor
		F.txtPrix.text=Prix
		
		if prix<>nothing then
			lprix=Csng(prix).ToString("#,##0.00").length
			F.txtTexte.text=Texte.Remove(lTexte-(lPrix+2),(lPrix+2))
		End If
		
		MonBouton=CMenuBtn.SourceControl
		F.Showdialog
	End Sub
	
'	################		MENU SUPPRIME LE BOUTON		################
	Private Sub MenuItem3Click(sender As System.Object, e As System.EventArgs)
		With CMenuBtn.SourceControl
			.Text=""
			.Tag=""
			.ForeColor=Color.Black
			.Backcolor=Color.FromName("Control")
		End With
	End Sub
	
	'	################		MENU copie les couleurs du BOUTON		################
	Private Sub MenuCopieCoulClick(sender As System.Object, e As System.EventArgs)
		FColor=CMenuBtn.SourceControl.ForeColor
		BColor=CMenuBtn.SourceControl.BackColor
		MenuColleCoul.Enabled=true
	End Sub
	
	'	################		MENU colle les couleurs du BOUTON		################
	Private Sub MenuColleCoulClick(sender As System.Object, e As System.EventArgs)
		CMenuBtn.SourceControl.ForeColor=FColor
		CMenuBtn.SourceControl.BackColor=BColor	
		FlagModifBouton=True		
	End Sub
	
	'	################		MENU couper le BOUTON		################
	Private Sub MenuCoupeBtnClick(sender As System.Object, e As System.EventArgs)
		FColor=CMenuBtn.SourceControl.ForeColor
		BColor=CMenuBtn.SourceControl.BackColor
		BtnTexte=CMenuBtn.SourceControl.Text
		BtnPrix=CMenuBtn.SourceControl.Tag
		
		With CMenuBtn.SourceControl
			.Text=""
			.Tag=""
			.ForeColor=Color.Black
			.Backcolor=Color.FromName("Control")
		End With	
		
		MenuColleBtn.Enabled=true
	End Sub
	
	'	################		MENU coller le BOUTON		################
	Private Sub MenuColleBtnClick(sender As System.Object, e As System.EventArgs)
		With CMenuBtn.SourceControl
			.Text=BtnTexte
			.Tag=BtnPrix
			.ForeColor=FColor
			.Backcolor=BColor
		End With
	End Sub
	
	'	################		MENU copier le BOUTON		################
	Private Sub MenuCopieBtnClick(sender As System.Object, e As System.EventArgs)
		FColor=CMenuBtn.SourceControl.ForeColor
		BColor=CMenuBtn.SourceControl.BackColor
		BtnTexte=CMenuBtn.SourceControl.Text
		BtnPrix=CMenuBtn.SourceControl.Tag		
		
		MenuColleBtn.Enabled=true	
	End Sub

	
	Public shared Sub ModifBtn(ByVal Texte as string, ByVal Prix as string, ByVal ForeColor as Color, ByVal BackColor as Color)
	'Procedure appele par FrmModif pour modifier les donnes du bouton
		With MonBouton
			.text=Texte
			.tag=Prix
			.ForeColor=ForeColor
			.BackColor=BackColor
		End With
	End Sub
	
	#End Region

	Private Sub BtnEspClick(sender As System.Object, e As System.EventArgs)
		Dim LVI As New ListViewItem
		TabPage=tabcontrol1.Selectedindex

		If ListBox.items.count<1 Then
			Exit Sub
		Else
			Try
	           	g_Drawer.OpenDrawer()
            Catch ex As PosControlException
            	MessageBox.Show(ex.message, "Erreur Tiroir !", MessageBoxButtons.OK, MessageBoxIcon.Error )						            			
	        End Try			
			AffichePaiement()
			
			lvi.Text="ESPECES"
			lvi.SubItems.add(txttotal.Text)
			lsvpaye.Items.Add(lvi)
			
			RecTicket(ListBox)
			AfficheTicket(Tickets.Count-1)
			
			'afficheur client
			Try
            	g_Display.ClearText()
				g_Display.DisplayText("Merci et  bientt !", DisplayTextMode.Normal)
			Catch ex As PosControlException
				
	        End Try
			DisplayTimer2.Start

			lblidclient.text=Tickets.Count.ToString
			Paiement.clear
			Paiement.Total=0
			
			panelPaveNum.Enabled=True
			btncaisse.Enabled=true			
		End If		
	End Sub
	
	Private Sub BtnAttenteClick(sender As System.Object, e As System.EventArgs)
		If listbox.Items.count>0 Then
			lsvpaye.Items.clear
			
			CalculTotal()			
			RecTicket(ListBox)
			
			BtnTab0.enabled=TRUE
			BtnTab1.enabled=TRUE
			BtnTab2.enabled=TRUE
			BtnTab3.enabled=TRUE
			BtnTab4.enabled=TRUE
			BtnTab5.enabled=TRUE
			BtnTab6.enabled=True
			
			Paiement.total=0
			Paiement.clear
			AffichePaiement()
			
			Try
				g_display.ClearText()
				g_Display.DisplayText("Bonjour !", DisplayTextMode.Normal)
			Catch ex As PosControlException
				
	        End Try
	        
			AfficheTicket(Tickets.Count-1)	
			lblidclient.text=Tickets.Count.ToString
		End If		
	End Sub
	
	Private Sub BtnCaisseClick(sender As System.Object, e As System.EventArgs)
		Dim Frm As New FrmConfirm
		Dim T As Ticket
		Dim PCaisse as New PremiereCaisse
		
		If BtnCaisse.Text="QUITTER" Then
			If FlagModifBouton=True Then
				RecordBouton()
				Me.close
			Else		
				Frm.text="Fermeture de la caisse"
				Frm.LblText.Text="Voulez-vous éteindre la caisse ?"
				Frm.showdialog

				If Frm.DialogResult=DialogResult.Yes Then 
					Me.close
					Dim success As Boolean	
					uFlags = 1
					
					'if running under NT or better,
				    'the shutdown privileges need to
				    'be adjusted to allow the ExitWindowsEx
				    'call. If the adjust call fails on a NT+
				    'system, success holds False, preventing shutdown.
				    If IsWinNTPlus() Then
						success = EnableShutdownPrivledges()
						If success Then
							ExitWindowsEx(12, 0)  ' sinon ne fait rien
						End If		
					Else		
						'9x system, so just do it
						Call ExitWindowsEx(12, 0)
				    End If
				End If
			End If		
		else
			Frm.Text="Faire sa caisse"
			Frm.LblText.Text="Voulez-vous faire votre caisse ?" & Chr(13)& Chr(10)& Chr(13)& Chr(10) & "Aucun retour possible !"
			Frm.ShowDialog
			
			If Frm.dialogresult=DialogResult.Yes Then							
				Try
	            	g_Drawer.OpenDrawer()
	            Catch ex As PosControlException
					MessageBox.Show(ex.message, "Erreur Tiroir !", MessageBoxButtons.OK, MessageBoxIcon.Error )						            
		        End Try			
	'			Supprime tous les tickets en attente
				For i As Integer=Tickets.Count-1 To 0 Step -1
					If Tickets.Item(i).paiementcount=0
						Tickets.Removeat(i)
					End If
				Next				
				AfficheTicket(Tickets.Count-1)
				lblidclient.text=Tickets.Count.ToString	
				
				With Tickets				
					.TotalCaisse=0
					.NbTotalTR=0
					.NbTotalAvoir=0
					.NbTotalChk=0
					.TotalTR=0
					.TotalAvoir=0
					.TotalChk=0
					.TotalEsp=0
				End With
				
				
				
				
				'calcul du total de la caisse

				For i As Integer =0 To Tickets.Count-1
					
					Tickets.TotalCaisse+=Tickets.Item(i).TotalTicket
					
					For j As Integer =0 To Tickets.Item(i).PaiementCount-1
						Select Case Tickets.Item(i).paiement(j).Nom
							Case "ESPECES"
								Tickets.TotalEsp+=Tickets.Item(i).paiement(j).Total
							Case "Ticket Restaurant"
								Tickets.NbTotalTR+=Tickets.Item(i).paiement(j).Nb
								Tickets.TotalTR+=Tickets.Item(i).paiement(j).Total
							Case "Avoir"
								Tickets.NbTotalAvoir+=Tickets.Item(i).paiement(j).Nb
								Tickets.TotalAvoir+=Tickets.Item(i).paiement(j).Total
							Case "CHEQUES"
								Tickets.NbTotalChk+=Tickets.Item(i).paiement(j).Nb
								Tickets.TotalChk+=Tickets.Item(i).paiement(j).Total
						End Select
					Next
				Next
				
				If BtnCaisse.Text="Faire sa caisse :  14 h" Then
					PCaisse.TotalCaisse=Tickets.TotalCaisse
					PCaisse.TotalEsp=Tickets.TotalEsp
					PCaisse.NbTotalTR=Tickets.NbTotalTR
					PCaisse.TotalTR=Tickets.TotalTR
					PCaisse.NbTotalAvoir=Tickets.NbTotalAvoir
					PCaisse.TotalAvoir=Tickets.TotalAvoir
					PCaisse.NbTotalChk=Tickets.NbTotalChk
					PCaisse.TotalChk=Tickets.TotalChk
					
					BtnCaisse.Text="Faire sa caisse : Fermeture"
					
					PrintCaisse(Tickets)
				ElseIf BtnCaisse.Text="Faire sa caisse : Fermeture" Then
					Tickets.TotalCaisse=Tickets.TotalCaisse-PCaisse.TotalCaisse
					Tickets.TotalEsp=Tickets.TotalEsp-PCaisse.TotalEsp
					Tickets.NbTotalTR=Tickets.NbTotalTR-PCaisse.NbTotalTR
					Tickets.TotalTR=Tickets.TotalTR-PCaisse.TotalTR
					Tickets.NbTotalAvoir=Tickets.NbTotalAvoir-PCaisse.NbTotalAvoir
					Tickets.TotalAvoir=Tickets.TotalAvoir-PCaisse.TotalAvoir
					Tickets.NbTotalChk=Tickets.NbTotalChk-PCaisse.NbTotalChk
					Tickets.TotalChk=Tickets.TotalChk-PCaisse.TotalChk
					
					BtnCaisse.Enabled=true
					BtnCaisse.Text="QUITTER"
					
					PrintCaisse(Tickets)
				End If					
			End If							
		End If				
	End Sub
	
	Private Sub BtnPrintTicketClick(sender As System.Object, e As System.EventArgs)
		Dim Id As Integer=CInt(lblidclient.Text)
		
		PrintTicket(Tickets, id-1,id,BtnTVA.Tag)
	End Sub
	
	Private Sub AffichePaiement()		
		txtTotal.Text=(Paiement.total).ToString("#,##0.00")

		
		'TabPage Paiement
		TxtReste.Text=(Paiement.reste).ToString("#,##0.00")
		TxtARendre.Text=(Paiement.ARendre).ToString("#,##0.00")
		TxtAvoir.Text=(Paiement.Avoir).ToString("#,##0.00")
		
		'TabPage Ticket Resto
		TxtTotalTR.Text=(Paiement.TotalTR).ToString("#,##0.00")
		Txt_TabTR_Reste.Text=(Paiement.reste).ToString("#,##0.00")
		Txt_TabTR_Avoir.text=(Paiement.Avoir).ToString("#,##0.00")
		
		'TabPage Avoir
		TxtTotalAvoir.text=(Paiement.TotalAvoir).ToString("#,##0.00")
		Txt_TabAvoir_Reste.Text=(Paiement.reste).ToString("#,##0.00")
		TxtTabAvoir_Avoir.Text=(Paiement.Avoir).ToString("#,##0.00")
		
		If Paiement.troppercu>0 then
			LblArendre.Text="Trop peru :"
			Lbl_TabTR_Reste.text="Trop peru :"
			Lbl_TabAvoir_Reste.text="Trop peru :"
			
			LblArendre.BackColor=Color.Red
			Lbl_TabTR_Reste.BackColor=Color.Red
			Lbl_TabAvoir_Reste.BackColor=Color.Red
			
			LblArendre.ForeColor=Color.White
			Lbl_TabTR_Reste.ForeColor=Color.white
			Lbl_TabAvoir_Reste.ForeColor=Color.White
			
			TxtArendre.BackColor=Color.Red
			Txt_TabTR_Reste.BackColor=Color.Red
			Txt_TabAvoir_Reste.BackColor=Color.Red
			
			TxtArendre.foreColor=Color.white
			Txt_TabTR_Reste.foreColor=Color.White
			Txt_TabAvoir_Reste.foreColor=Color.White
			
			TxtARendre.Text=(Paiement.TropPercu).ToString("#,##0.00")
			Txt_TabTR_Reste.Text=(Paiement.TropPercu).ToString("#,##0.00")
			Txt_TabAvoir_Reste.Text=(Paiement.TropPercu).ToString("#,##0.00")			
		Else
			LblArendre.Text="A rendre"
			Lbl_TabTR_Reste.text="Reste  Payer"
			Lbl_TabAvoir_Reste.text="Reste  Payer"
			
			LblArendre.BackColor=Color.yellow
			Lbl_TabTR_Reste.BackColor=Color.yellow
			Lbl_TabAvoir_Reste.BackColor=Color.yellow
			
			LblArendre.ForeColor=Color.black
			Lbl_TabTR_Reste.ForeColor=Color.Black
			Lbl_TabAvoir_Reste.ForeColor=Color.Black
			
			TxtArendre.BackColor=Color.yellow
			Txt_TabTR_Reste.BackColor=Color.yellow
			Txt_TabAvoir_Reste.BackColor=Color.yellow
			
			TxtArendre.foreColor=Color.black
			Txt_TabTR_Reste.foreColor=Color.black
			Txt_TabAvoir_Reste.foreColor=Color.black
		End If
	End Sub
	
	#Region "Navigation dans les tickets clients"
	
	Private Sub Button1Click(sender As System.Object, e As System.EventArgs)		
		Dim Id As Integer
		Id=CInt(lblidclient.Text)
		id=id-1
		
		If id >= 1 Then
			lblidclient.Text=(Id).ToString
			AfficheTicket(Id-1)
		End If
	End Sub
	
	Private Sub Button22Click(sender As System.Object, e As System.EventArgs)	
		Dim Id As Integer
		Id=CInt(lblidclient.Text)		
		
		If id < Tickets.Count Then
			lblidclient.Text=(Id+1).ToString
			AfficheTicket(id)	
		End If			
	End Sub
	
	Public Sub AfficheTicket(ByVal Id As Integer) 
		LstNavig.items.clear
		lsvpaye.Items.clear
		
		'rcupre chaque ligne du ticket
		For i As Integer = 0 To Tickets.Item(id).count -1
			Dim LVI As New ListViewItem
			Lvi.Text=Tickets.Item(id).Item(i).qty
			Lvi.SubItems.add(Tickets.Item(id).Item(i).text)
			Lvi.SubItems.add(Tickets.Item(id).Item(i).total)		
			LstNavig.items.add(lvi)	
		Next	
			
		'rcupre chaque mode de paiement
		For i As Integer=0 To Tickets.Item(id).paiementcount-1
			Dim LVI As New ListViewItem
			lvi.Text=Tickets.Item(id).paiement(i).nom
			lvi.SubItems.add(Tickets.Item(id).paiement(i).total)
			lsvpaye.items.add(lvi)
		Next
		
		'rcupre le total du ticket, l'avoir et la monnaie a rendre
		txttotalNavig.Text=Tickets.Item(id).totalTicket
		txtarendre.Text=Tickets.Item(id).arendre
		txtavoir.text=Tickets.Item(id).avoirRendu
		
		'si le ticket est pay, dsactive le paiement et active l'impression
		If Tickets.Item(id).paiementcount=0 Then
			lstnavig.Enabled=true
			lstNavig.BackColor=Color.White
			lstnavig.ForeColor=color.Black
			btnpaye.Enabled=True
			btnprintticket.Enabled=false
			txttotal.text=Tickets.Item(id).totalTicket
		Else
			lstNavig.BackColor=Color.FromName("highlight")
			lstnavig.ForeColor=color.White
			btnprintticket.Enabled=true
			btnpaye.Enabled=False
			txttotal.text=""
			txttotalnavig.text=Tickets.Item(id).totalTicket
			tabcontrol1.Selectedindex=TabPage
		End If		
	End Sub
	#End Region		
				
	#Region "Gestion du TabPage Paiement"
    	#Region "Gestion Pave Numrique du TabPage Paiement"
    	
    	'Procedure appele par les boutons
   		Private Sub BtnTabPayPaveNum(Texte As String)
   			Dim Value as single=0
       		Dim Virg As Char()={","}
       		Dim Moy As String       		
       		
       		If lsvpaye.SelectedItems.count>0 Then
       		Moy=lsvpaye.SelectedItems(0).text
       		
       			If Moy="ESPECES" or Moy="CHEQUES" Then
					'control  : pas plus de deux chiffres derriere la virgule
					If strpaiement.lastIndexOf(Virg)<>-1 Then
						If strpaiement.Length-strpaiement.lastIndexOf(Virg)=3 Then	Exit Sub
					End If				
					
					If FlagPaveNumPaiement=True Then
						strPaiement+=Texte
						Value=CSng(strPaiement)
						lsvpaye.selecteditems(0).subitems(1).text= Value.ToString("#,##0.00")
						Calculreste()
					Else
						strPaiement= "0" & Texte
						Value=CSng(strPaiement)
						lsvpaye.selecteditems(0).subitems(1).text= Value.ToString("#,##0.00")
						Calculreste()
					End If				
				FlagPaveNumPaiement=true
				End If
				'affichage pour le client
				try
				PrintDisplay("Reu en " & Moy & " :", Value.ToString("#,##0.00"))
				Catch ex As PosControlException		        
					MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
				End Try
       		End If
       		CalculReste()
    	End Sub       
        
        Private Sub LsVPayeSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
			FlagPaveNumPaiement=False
		End Sub
		
    	Private Sub Button32Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub Button31Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub Button30Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub button29Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub button28Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub button27Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub button26Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub button25Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub button24Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
        
    	Private Sub BtnPay1Click(sender As System.Object, e As System.EventArgs)
        	BtnTabPayPaveNum(sender.text)            
    	End Sub
    	
    	Private Sub BtnCClick(sender As System.Object, e As System.EventArgs)
			Dim Value as single=0	

			If lsvpaye.selecteditems.count>0 Then
				If lsvpaye.selecteditems(0).text="Ticket Restaurant" Then
					lsvtr.Items.clear
					calcultotaltr()
				ElseIf lsvpaye.selecteditems(0).text="Avoir" Then
					lsvavoir.Items.clear
					calcultotalavoir()
				End If

				lsvpaye.selecteditems(0).remove
				Calculreste()	
				affichepaiement()
				strpaiement="0"
			End If	
			
			try
			PrintDisplay("Reste  payer :", Paiement.reste.ToString("#,##0.00"))
			Catch ex As PosControlException		        
				MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
			End Try
		End Sub
		
		Private Sub BtnVirgClick(sender As System.Object, e As System.EventArgs)
			Dim Virg As Char()={","} 
			If strpaiement.lastIndexOf(Virg)=-1 Then 			
				BtnTabPayPaveNum(sender.text) 
			End if	
		End Sub

    	#End Region
    	
		#Region " PROCEDURE CalculReste() "
		Public Sub CalculReste()
			Dim Total As Single=Paiement.Total
			Dim Recu as single
			Dim ARendre As Single
			Dim RecuTR As Single=Paiement.TotalTR
			Dim RecuAv As Single=Paiement.TotalAvoir
			
			Dim RecuEsp As single
			Dim recuChk As Single 			
			
			Dim RenduAvoir As single
			Dim RenduEsp As Single
			DIM TropPercu as single

			Dim LVI_Esp As New ListViewItem
			Dim LVI_Chk As New ListViewItem
			
'########	ITERATION DE TOUS LES MODES DE PAIMENT POUR CONNAITRE LEUR MONTANT RESPECTIF.  	#########
			For i As Integer = 0 To lsvpaye.items.count-1
				Select Case lsvpaye.Items(i).text
				Case "ESPECES"
					LVI_Esp=lsvpaye.Items(i)
					recuesp=lsvpaye.Items(i).subitems(1).text
				Case "CHEQUES"
					LVI_Chk=lsvpaye.Items(i)
					recuchk=lsvpaye.Items(i).subitems(1).text
				End Select
			Next		
'##########		CALCUL DE LA SOMME TOTALE DONNEE PAR LE CLIENT	######################

			Paiement.Recu=0
			Paiement.Recu += recutr+recuesp+recuav+recuchk
			Recu=Paiement.Recu
			
'###########		CALCUL DE LA SOMME A RENDRE AU CLIENT		######################					
			Arendre = Recu - total
			Paiement.Arendre=Arendre
			
			Select Case Arendre
				Case  0
					Paiement.Reste=0
					Paiement.Arendre=0
					Paiement.Avoir=0
					Paiement.TropPercu=0
					AffichePaiement()
					
				Case < 0					
					Paiement.Reste = -arendre
					Paiement.Arendre=0
					Paiement.Avoir=0
					Paiement.TropPercu=0
					AffichePaiement()					
					
				Case > 0 
															
'#################################################################################################				
'#############		EN FONCTION DE LA SOMME TOTALE ET DES DIFFERENTS MONTANTS RECU 
'#############		CALCUL DE LA MONNAIE A RENDRE, D'UN Avoir A FAIRE SUR UN TICKET RESTO (2,5 Maxi) 
					
					
					troppercu=(recuchk+recuav)-total
					Paiement.Reste=0
					
					If (recutr+recuav+recuchk)>total Then
						renduavoir=recutr-total

						If (recuav+recuchk)<total Then
							renduavoir=(recuav+recutr+recuchk)-total
						Elseif (recuav+recuchk)>=total
							renduavoir=0
							troppercu=recu-total						
						Else
							renduavoir=0
						End If
					End If
					
					If recuesp>0 Then
						paiement.arendre=arendre-renduavoir
					Else
						paiement.arendre=0
					End If
					
					If RenduAvoir > 2.5
						RenduAvoir=2.5
						Paiement.Avoir=RenduAvoir
						TropPercu=(recuav+RecuTr+recuchk)-Total-2.5	
					End If
					
					paiement.troppercu=troppercu
					paiement.avoir=renduavoir
					AffichePaiement()
			End Select
		End Sub
	#End Region
	
		#Region "Gestion des moyens de paiement"
		
'		#######		PROCEDURE APPELE PAR LES BOUTONS ESPECES ET CHEQUE	#############
		Public Sub AddPayment (ByVal Payment As string)			
			Dim LVI As New ListViewitem
			Dim Value As Single=0
			Dim Total As Single=Paiement.Total
			Dim Recu As Single=Paiement.Recu
			
			strpaiement="0"
			
			For i As Integer = 0 To lsvpaye.Items.count-1
				Value=Csng(lsvpaye.Items(i).subitems(1).text)
				If Value=0 Then
					lsvpaye.Items(i).remove
				elseIf lsvpaye.Items(i).text = Payment Then
					lsvpaye.Items(i).selected=true
					Exit Sub				
				End If				
			Next
			
			If Recu >= Total
				Dim Frm As New FrmErreur
				
				Frm.lbltext.text="DEJA PAYE !!"
				Frm.showdialog
				Exit Sub
			End If
			
			Value=Csng(txtreste.Text)
			Lvi.Text = Payment
			lvi.SubItems.add(Value.ToString("#,##0.00"))
			LsvPaye.Items.add(lvi)
			lsvpaye.Items(lsvpaye.Items.count-1).selected = True
			
			'affichage pour le client
			try
			PrintDisplay("Reu en " & payment & " :", Value.ToString("#,##0.00"))
			Catch ex As PosControlException		        
				MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
			End Try
			
			Calculreste()
		End Sub			
		
		Private Sub Button2Click(sender As System.Object, e As System.EventArgs)
			AddPayment(sender.text)		
		End Sub
	
		Private Sub BtnCheqClick(sender As System.Object, e As System.EventArgs)
			AddPayment(sender.text)				
		End Sub
		
'		##############		TICKET RESTO	################

		Private Sub BtnTRClick(sender As System.Object, e As System.EventArgs)
			Dim LVI As New ListViewItem
			Dim Total As Single=Paiement.Total
			Dim Recu As Single=Paiement.Recu
			
			If Recu >= Total
				Dim Frm As New FrmErreur
				
				Frm.lbltext.text="Dj pay!!"
				Frm.showdialog
				Exit Sub
			End If
			
			strpaiement="0"			
			tabcontrol1.SelectedTab=tabpagtr
			
			LVI.Text="1"
			Lvi.SubItems.add(0.ToString("#,##0.00"))
			Lvi.SubItems.add(0.ToString("#,##0.00"))			
			LsvTR.items.add(LVI)
			lsvtr.Items(lsvtr.Items.count-1).selected = True
			txt_tabTR_reste.Text=txtreste.text
			txttotaltr.Text=0.ToString("#,##0.00")
			
			Calculreste()
		End Sub

'		##############		AVOIR	################

		Private Sub BtnAvoirClick(sender As System.Object, e As System.EventArgs)
			Dim LVI As New ListViewItem
			Dim Total As Single=Paiement.Total
			Dim Recu As Single=Paiement.Recu
			
			If Recu >= Total
				Dim Frm As New FrmErreur
				
				Frm.lbltext.text="Dj pay!!"
				Frm.showdialog
				Exit Sub
			End If
			
			strpaiement="0"
			tabcontrol1.SelectedTab=tabpageAvoir			

			LVI.Text="1"
			Lvi.SubItems.add(0.ToString("#,##0.00"))
			Lvi.SubItems.add(0.ToString("#,##0.00"))			
			LsvAvoir.items.add(LVI)
					
			lsvAvoir.Items(lsvAvoir.Items.count-1).selected = True
			txt_tabAvoir_reste.Text=txtreste.text
			txttotalAvoir.Text=0.ToString("#,##0.00")
			
			Calculreste()
		End Sub
		
		#End Region
		
		Private Sub BtnValidClick(sender As System.Object, e As System.EventArgs)
			Dim arendre As Single=CSng(txtarendre.Text)
			Dim Id As Integer=CInt(lblidclient.Text)
			
			If CSng(paiement.reste.tostring("#,##0.00"))>0 then
				Dim Frm As New FrmErreur
				
				Frm.lbltext.text="Panier non sold!!"
				Frm.showdialog
				Exit Sub
			End If
			
			If paiement.troppercu>0 Then
				Dim Frm As New FrmConfirm
				
				Frm.lbltext.text="Attention, le client perd " & Paiement.troppercu.tostring("#,##0.00") & "  !"
				With Frm.btnOui
					.location=New drawing.point(16, 98)
					.height=56
					.width=120
					.BackColor=Color.red
					.ForeColor=Color.white
					.text="Valider la perte !"
				End With
				Frm.btnNon.text="Retour"				
				Frm.showdialog
				
				If Frm.dialogresult=dialogresult.no Then
					exit sub
				End If
			End If
			
			If lsvpaye.Items.count<>0 Then							
				Try
            		g_Drawer.OpenDrawer()
            	Catch ex As PosControlException
            		MessageBox.Show(ex.message, "Erreur Tiroir !", MessageBoxButtons.OK, MessageBoxIcon.Error )						            				
		        End Try				

				If listbox.items.count=0 Then
					Tickets.Removeat(id-1)					
					RecTicket(LstNavig)
				Else
					RecTicket(ListBox)
				End If
				
				AfficheTicket(Tickets.Count-1)
				AffichePaiement()
				If CSng(paiement.arendre.tostring("#,##0.00"))>0 then
					label1.BackColor=Color.Yellow
					Label1.ForeColor=Color.Black
					Label1.Text="A Rendre :"
					txttotal.BackColor=Color.Yellow
					txttotal.ForeColor=Color.black
					txttotal.Text=paiement.arendre.tostring("#,##0.00")
				End If
				lblidclient.text=Tickets.Count.ToString				
				Tabcontrol1.SelectedIndex=Tabpage
				btnprintticket.Enabled=True
				panelpavenum.Enabled=TRUE
				btncaisse.Enabled=True
				BtnTab0.enabled=True
				BtnTab1.enabled=True
				BtnTab2.enabled=True
				BtnTab3.enabled=True
				BtnTab4.enabled=True
				BtnTab5.enabled=True
				BtnTab6.enabled=True
				btnesp.Enabled=true
									
				Paiement.clear
				Paiement.Total=0
				
				'afficheur client
				try
		        If Paiement.avoir>0 Then
		        	PrintDisplay("Avoir :", Paiement.avoir.tostring("#,##0.00"))
		        	displaytimer.start
		        elseIf Paiement.arendre>0 Then
		        	PrintDisplay("A Rendre :", Paiement.arendre.tostring("#,##0.00"))
		        	displaytimer.start
		        Else
		        	PrintDisplay("Merci et  bientt !", DisplayTextMode.Normal)
		        	displaytimer2.start
		        End If
		        Catch ex As PosControlException		        
					MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
				End Try
		        
				If BtnTicket.Text="Avec Ticket" Then
					if Tickets.Count=1 then
						PrintTicket(Tickets, 0,1,BtnTVA.Tag)
					Else
						PrintTicket(Tickets, (Tickets.Count-1),Tickets.Count,BtnTVA.Tag)
					End If
				End If
				
				If btnTVa.Text="Sur Place" Then
					if Tickets.Count=1 then
						PrintTicket(Tickets, 0,1,BtnTVA.Tag)
					Else
						PrintTicket(Tickets, (Tickets.Count-1),Tickets.Count,BtnTVA.Tag)
					End If
				End If
				
				If Csng(txtavoir.text) <> 0 Then
					PrintAvoir(txtavoir.text)
				End If
				
			End If			
		End Sub

		Private Sub DisplayTimerTick(sender As System.Object, e As System.EventArgs)
			Try
            	g_Display.ClearText()
				g_Display.DisplayText("Merci et  bientt !", DisplayTextMode.Normal)
				DisplayTimer.Stop
				DisplayTimer2.start
	        Catch ex As PosControlException	
	        End Try			
		End Sub
		
		Private Sub DisplayTimer2Tick(sender As System.Object, e As System.EventArgs)
			Try
            	g_Display.ClearText()
            	g_Display.DisplayText("Bonjour !", DisplayTextMode.Normal)
				DisplayTimer2.Stop
	        Catch ex As PosControlException	
	        End Try			
		End Sub
		
		Private Sub BtnAnnulPayClick(sender As System.Object, e As System.EventArgs)
			strpaiement="0"	
			lsvPaye.Items.clear
			lsvTr.Items.clear
			lsvAvoir.Items.clear
			Paiement.Clear
			
			try
			PrintDisplay("Reste  payer :", Paiement.total.tostring("#,##0.00"))
			Catch ex As PosControlException		        
				MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
			End Try
			
			AffichePaiement()
			
			CalculReste()			
		End Sub
		
		Private Sub BtnRetourPayeClick(sender As System.Object, e As System.EventArgs)
			Tabcontrol1.Selectedindex=tabPage
			panelpavenum.Enabled=true
			btncaisse.Enabled=True
			BtnTab0.enabled=true
			BtnTab1.enabled=true
			BtnTab2.enabled=true
			BtnTab3.enabled=true
			BtnTab4.enabled=true
			BtnTab5.enabled=true
			BtnTab6.enabled=true
			btnesp.Enabled=true
			
			affichepaiement()
			CalculReste()
			
			try
			PrintDisplay("Reste  payer :", Paiement.total.tostring("#,##0.00"))
			Catch ex As PosControlException		        
				MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
			End Try
			
			strpaiement="0"
			lsvPaye.Items.clear
			lsvTr.Items.clear
			lsvAvoir.Items.clear
			paiement.clear
		End Sub

		Private Sub BtnTicketClick(sender As System.Object, e As System.EventArgs)
			If BtnTicket.Text="Sans Ticket" Then
				BtnTicket.Text="Avec Ticket"	
			Else
				BtnTicket.Text="Sans Ticket"	
			End If		
		End Sub
		
		Private Sub BtnTVAClick(sender As System.Object, e As System.EventArgs)
			If BtnTVA.Text="A Emporter" Then
				BtnTVA.Text="Sur Place"
				BtnTVA.Tag="19,6"
			Else
				BtnTVA.Text="A Emporter"
				BtnTVA.Tag="5,5"
			End If		
		End Sub
	
		Public Sub RecTicket(Lst as Listview)
			Dim Qty As String
			Dim Texte As String
			Dim Total As String
			Dim Recu As Single
			Dim Nb as integer
			Dim T As New Ticket()
			
			Recu=0
			IdClientAffich = Tickets.Count
			
			'enregistre les produits achets correspondant aux lignes du ticket
			For i As Integer = 0 To lst.items.count -1
				Qty=lst.items(i).text
				Texte=lst.items(i).subitems(1).text
				Total=lst.items(i).subitems(2).text
				T.AddLigne(Qty, Texte ,Total)
			Next
			
			'enregistre les diffrents moyens de paiement utiliss
			For i As Integer =0 To lsvpaye.Items.count-1
				Texte=lsvpaye.Items(i).text
				Total=lsvpaye.Items(i).subitems(1).text
				Select Case Texte
					Case "ESPECES"
						Nb=0
					Case "Ticket Restaurant"
						For j As Integer = 0 To lsvtr.items.count-1
							Nb+=csng(lsvtr.Items(j).Text)
						Next
					Case "AVOIR"
						For j As Integer = 0 To lsvavoir.items.count-1
							Nb+=csng(lsvavoir.Items(j).Text)
						Next
					Case "CHEQUES"
						Nb=1
				End Select
				T.AddPaiement(Texte, Total, Nb)
				Nb=0
			Next
			
			'enregistre le total du ticket, l'avoir et la monnaie a rendre
			T.TotalTicket=paiement.total.ToString("#,##0.00")
			T.Arendre=paiement.arendre.ToString("#,##0.00")
			T.AvoirRendu=paiement.avoir.ToString("#,##0.00")
			Tickets.Add(T)		
			
			lsvtr.items.Clear
			lsvavoir.items.clear
			Listbox.items.clear	
			lsvpaye.Items.clear
			tabcontrol1.SelectedIndex=TabPage
		End Sub

	#End Region

	#Region "Gestion du TabPage Ticket Resto"
		
		Private Sub BtnNewTRClick(sender As System.Object, e As System.EventArgs)
		'#######	AJOUTE UN TICKET RESTO DANS LA LISTE	#######
		Dim LVI As New ListViewItem
			
			If CSng(lsvtr.Items(lsvtr.Items.count-1).subitems(1).text)<>0 Then
				LVI.Text="1"
				Lvi.SubItems.add(0.ToString("#,##0.00"))
				LsvTR.items.add(LVI)
				lsvtr.Items(lsvtr.Items.count-1).selected = True
				strpaiement="0"
			End If		
		End Sub
		
		Private Sub LsvTRClick(sender As System.Object, e As System.EventArgs)
			Lbl_NbTR.Text=lsvtr.SelectedItems(0).text	
		End Sub

		Private Sub BtnValidTRClick(sender As System.Object, e As System.EventArgs)
			Dim LVI As New ListViewItem
			
			'Supprime la ligne gale  zro dans lsvTR
			For i As Integer=0 To lsvtr.items.count-1
				If CSng(lsvtr.Items(i).subitems(1).text)=0 Then
					lsvtr.Items(i).remove
				end if
			Next	
			
			If CSng(TxtTotaltr.text)<>0 Then
				For i As Integer = 0 To lsvpaye.Items.count-1
					If lsvpaye.Items(i).text="Ticket Restaurant" Then
						lsvpaye.Items(i).remove
					End If
				Next	
				LVI.Text="Ticket Restaurant"
				Lvi.SubItems.add(Paiement.TotalTR.ToString("#,##0.00"))
				lsvpaye.Items.add(lvi)
				try
				PrintDisplay("Reu en Ticket Restaurant :", Paiement.TotalTR.ToString("#,##0.00"))
				Catch ex As PosControlException		        
					MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
				End Try
			End If

			strpaiement="0"
			tabcontrol1.SelectedTab=tabpagpaye			
			CalculReste()
			BtnVirgTr.Text="Ticket de 10,00  ou plus"
		End Sub
		
		Private Sub Btn_TtAnnulTRClick(sender As System.Object, e As System.EventArgs)
			Dim LVI As New ListViewItem			
			
			LsvTR.Items.clear
			strpaiement="0"
			
			LVI.Text="1"
			Lvi.SubItems.add(0.ToString("#,##0.00"))
			lsvtr.Items.add(lvi)	
			lvi.Selected=true
			
			Lbl_NbTR.Text="1"
			
			CalculTotalTR()
			CalculReste()
			AffichePaiement()

		End Sub
		
		Private Sub CalculTotalTR()				
			Dim Value as single 
			Dim NbTR As Integer
			Dim RecuTR as single=0

			For i As Integer= 0 To lsvtr.Items.count-1
				Nbtr=CSng(lsvtr.Items(i).text)
				Value=Csng(lsvtr.Items(i).subitems(1).text)
				RecuTR+=NbTR*Value
			Next
			Paiement.TotalTR=RecuTR
			CalculReste()
		End Sub
		
		#Region "Pav Numrique Ticket Resto"
			
			Private Sub BtnVirgTRClick(sender As System.Object, e As System.EventArgs)
				If sender.text="Ticket de moins de 10,00 " Then
					sender.text="Ticket de 10,00  ou plus"
				Else
					sender.text="Ticket de moins de 10,00 "
				End If	
			End Sub
						
			Private Sub BtnPaveNumTR(strNb As String)
				Dim Virg As Char()={","}				
				Dim Value As Single				
			
				If lsvtr.Items.count>0 Then			
					'control  : pas plus de deux chiffres derriere la virgule
					If strpaiement.IndexOf(Virg)<>-1 then
						If strpaiement.Length-strpaiement.IndexOf(Virg)=3 Then Exit Sub
					End If
					
					If BtnVirgTR.text="Ticket de 10,00  ou plus" Then
						If strpaiement.IndexOf(Virg)=-1 then
							strpaiement+=strnb & ","
						Else
							strpaiement+=strnb
						End if
					Else
						If strpaiement.Length=2 Then
							strpaiement+=strnb & ","
						else
							strpaiement+=strnb
						End If
					End If											
				End If	

				Value=CSng(strPaiement)
				lsvtr.selecteditems(0).subitems(1).text= Value.ToString("#,##0.00")
				CalculTotalTR()
			End Sub
						
			Private Sub Btn_CTRClick(sender As System.Object, e As System.EventArgs)
				If lsvtr.Items.count<=1 then				
					With LsvTR.SelectedItems(0)
						.text=1
						.subitems(1).text=0.ToString("#,##0.00")
						.subitems(2).text=0.ToString("#,##0.00")
					End With
				Else
					LsvTR.SelectedItems(0).remove
					lsvtr.Items(lsvtr.Items.count-1).selected=true
				End if
				strpaiement="0"
				CalculTotalTR()
			End Sub
		
			Private Sub Btn_TR_1Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_2Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_3Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_4Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_5Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_6Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_7Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)			
			End Sub
			
			Private Sub Btn_TR_8Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_9Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_0Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumTR(sender.text)		
			End Sub
			
			Private Sub Btn_TR_VirgClick(sender As System.Object, e As System.EventArgs)
				Dim Virg As Char()={","} 
				If strpaiement.lastIndexOf(Virg)=-1 Then 			
					BtnPaveNumTR(sender.text) 
				End if		
			End Sub
			
		#End Region	
	
		#Region "Up and Down Ticket Resto"
		Private Sub LsvTRSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
			If lsvTR.selecteditems.count > 0 Then
				Lbl_NbTR.Text=lsvTR.selecteditems(0).text
			End If	
		End Sub

		Private Sub Btn_DwnNbTRClick(sender As System.Object, e As System.EventArgs)
			Dim Value As Double
			
			Value=CDbl(Lbl_NbTR.Text)
			
			If Value =1 Then
				Exit Sub	
			Else
				Lbl_NbTR.Text=(Value-1).ToString
			End If
			
			lsvTR.selecteditems(0).text=Lbl_NbTR.Text
			CalculTotalTR()
			CalculReste()
			AffichePaiement()
		End Sub
		
		Private Sub Btn_UpNbTRClick(sender As System.Object, e As System.EventArgs)
			Dim Value As Double
			
			If Lbl_NbTR.Text ="" Then 
				Value=0		
			Else
				Value=CDbl(Lbl_NbTR.Text)
			End If
			
			Lbl_NbTR.Text=(Value+1).ToString
			
			lsvTR.selecteditems(0).text=Lbl_NbTR.Text
			CalculTotalTR()
			CalculReste()
			AffichePaiement()
		End Sub	
		
		#End Region	
	#End Region

	#Region "Gestion Du TabPage Avoir"
		
		Private Sub BtnNewAvoirClick(sender As System.Object, e As System.EventArgs)
		'#######	AJOUTE UN RenduAvoir DANS LA LISTE	#######
			Dim LVI As New ListViewItem
			
			If CSng(lsvavoir.Items(lsvavoir.Items.count-1).subitems(1).text)<>0 Then
				LVI.Text="1"
				Lvi.SubItems.add(0.ToString("#,##0.00"))
				Lvi.SubItems.add(0.ToString("#,##0.00"))			
				Lsvavoir.items.add(LVI)
				lsvavoir.Items(lsvavoir.Items.count-1).selected = True
				strpaiement="0"
			End If
	
		End Sub
	
		Private Sub Btn_TabAvoir_ValidClick(sender As System.Object, e As System.EventArgs)
			Dim LVI As New ListViewItem
			
			For i As Integer=0 To lsvavoir.items.count-1
				If CSng(lsvavoir.Items(i).subitems(1).text)=0 Then
					lsvavoir.Items(i).remove
				end if
			Next	
			
			If CSng(TxtTotalavoir.text)<>0 Then
				For i As Integer = 0 To lsvpaye.Items.count-1
					If lsvpaye.Items(i).text="Avoir" Then
						lsvpaye.Items(i).remove
					End If
				Next
				LVI.Text="Avoir"
				Lvi.SubItems.add(Paiement.TotalAvoir.ToString("#,##0.00"))
				lsvpaye.Items.add(lvi)	
				
				try
				PrintDisplay("Reu en Avoir :", Paiement.TotalAvoir.ToString("#,##0.00"))
				Catch ex As PosControlException		        
					MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
				End Try
			End If	
			
			strpaiement="0"
			tabcontrol1.SelectedTab=tabpagpaye
			CalculReste()			
		End Sub
		
		Private Sub Btn_TabAvoir_AnnulClick(sender As System.Object, e As System.EventArgs)
			Dim LVI As New ListViewItem			
			
			LsvAvoir.Items.clear
			strpaiement="0"
			
			LVI.Text="1"
			Lvi.SubItems.add(0.ToString("#,##0.00"))
			lsvAvoir.Items.add(lvi)	
			lvi.Selected=true
			
			LblNbAvoir.Text="1"
			
			CalculTotalAvoir()
			CalculReste()
			AffichePaiement()
		End Sub
		
		#Region "Pav Numrique Avoir"
		
			Private Sub BtnPaveNumAvoir(strNb As String)
				Dim Virg As Char()={","}				
				Dim Value As Single				
			
				If lsvavoir.Items.count>0 Then			
					'control  : pas plus de deux chiffres derriere la virgule
					If strpaiement.IndexOf(Virg)<>-1 then
						If strpaiement.Length-strpaiement.IndexOf(Virg)=3 Then Exit Sub
					End If
					
					If strpaiement.IndexOf(Virg)=-1 then
						strpaiement+=strnb & ","
					Else
						strpaiement+=strnb
					End if
				End If	

				Value=CSng(strPaiement)
				lsvavoir.selecteditems(0).subitems(1).text= Value.ToString("#,##0.00")
				CalculTotalAvoir()
			End Sub
		
			Private Sub CalculTotalAvoir()
				Dim Value as single 
				Dim NbAvoir As Integer
				Dim recuav as single=0
				
				For i As Integer= 0 To lsvAvoir.Items.count-1
					Value=CSng(lsvAvoir.Items(i).subitems(1).text)
					NbAvoir=CInt(lsvAvoir.Items(i).text)
					RecuAv+=Value*NbAvoir
				Next	
				Paiement.TotalAvoir=RecuAv
				CalculReste()
			End Sub
		
			Private Sub Btn_TabAvoir_CClick(sender As System.Object, e As System.EventArgs)
				If lsvavoir.Items.count<=1 then				
					With Lsvavoir.SelectedItems(0)
						.text=1
						.subitems(1).text=0.ToString("#,##0.00")
						.subitems(2).text=0.ToString("#,##0.00")
					End With
				Else
					Lsvavoir.SelectedItems(0).remove
					lsvavoir.Items(lsvavoir.Items.count-1).selected=true
				End if
				strpaiement="0"
				CalculTotalAvoir()	
			End Sub
				
			Private Sub Btn_TabAvoir_1Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)				
			End Sub
				
			Private Sub Btn_TabAvoir_2Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)				
			End Sub
				
			Private Sub Btn_TabAvoir_3Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)				
			End Sub
				
			Private Sub Btn_TabAvoir_4Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
				
			Private Sub Btn_TabAvoir_5Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
				
			Private Sub Btn_TabAvoir_6Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
				
			Private Sub Btn_TabAvoir_7Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
				
			Private Sub Btn_TabAvoir_8Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
				
			Private Sub Btn_TabAvoir_9Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
				
			Private Sub Btn_TabAvoir_0Click(sender As System.Object, e As System.EventArgs)
				BtnPaveNumAvoir(sender.text)	
			End Sub
		#End Region
	
		#Region "Up and Down Avoir"
			Private Sub LsvAvoirSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
				If lsvAvoir.selecteditems.count > 0 Then
					LblNbAvoir.Text=lsvAvoir.selecteditems(0).text
				End If			
			End Sub
			
			Private Sub BtnDownAvoirClick(sender As System.Object, e As System.EventArgs)
				Dim Value As Double
				
				Value=CDbl(LblNbAvoir.Text)
				
				If Value =1 Then
					Exit Sub	
				Else
					LblNbAvoir.Text=(Value-1).ToString
				End If
				
				lsvAvoir.selecteditems(0).text=LblNbAvoir.Text
				
				CalculTotalAvoir()
				CalculReste()
				AffichePaiement()
			End Sub
			
			Private Sub BtnUpAvoirClick(sender As System.Object, e As System.EventArgs)
				Dim Value As Double
				
				If LblNbAvoir.Text ="" Then 
					Value=0		
				Else
					Value=CDbl(LblNbAvoir.Text)
				End If
				
				LblNbAvoir.Text=(Value+1).ToString
				
				lsvAvoir.selecteditems(0).text=LblNbAvoir.Text
				
				CalculTotalAvoir()
				CalculReste()
				AffichePaiement()
			End Sub
		
		#End Region
#End Region
	
	Private Sub BtnQuitClick(sender As System.Object, e As System.EventArgs)
		If FlagModifBouton=True Then
			RecordBouton()
			Me.close
		Else
			Dim Frm As New FRmConfirm
		
		Frm.text="Fermeture de la caisse"
		Frm.LblText.Text="Voulez-vous teindre la caisse ?"
		Frm.showdialog

		If Frm.DialogResult=DialogResult.Yes Then 
			Me.close
			Dim success As Boolean	
			uFlags = 1
			
			'if running under NT or better,
		    'the shutdown privileges need to
		    'be adjusted to allow the ExitWindowsEx
		    'call. If the adjust call fails on a NT+
		    'system, success holds False, preventing shutdown.
		    If IsWinNTPlus() Then
				success = EnableShutdownPrivledges()
				If success Then
					ExitWindowsEx(12, 0)  ' sinon ne fait rien
				End If		
			Else		
				'9x system, so just do it
				Call ExitWindowsEx(12, 0)
		    End If
		End If
		End If
		
	End Sub	

	Private Sub MainFormClosing(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
		ClosePrinter()
		CloseLineDisplay()
		CloseDrawer()				
	End Sub	

	Private Sub BtnAvanceClick(sender As System.Object, e As System.EventArgs)
		Dim Frm As New FrmAvance
		Frm.ShowDialog
		
	End Sub

End Class

End Namespace

 
