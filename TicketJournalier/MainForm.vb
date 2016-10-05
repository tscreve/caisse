'
' Created by SharpDevelop.
' User: Administrateur
' Date: 24/03/2009
' Time: 18:07
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.IO
Imports Microsoft.PointOfService
Imports System.Globalization
Imports System.Math

Namespace TicketJournalier
	
	Public Class MainForm
		Inherits System.Windows.Forms.Form
		Private listView1 As System.Windows.Forms.ListView
		Private ColClient As System.Windows.Forms.ColumnHeader
		Private TxtTotalImprim As System.Windows.Forms.TextBox
		Private ColTvaAEmporter As System.Windows.Forms.ColumnHeader
		Private TxtTotalReel As System.Windows.Forms.TextBox
		Private BtnClearList As System.Windows.Forms.Button
		Private ColPanier As System.Windows.Forms.ColumnHeader
		Private BtnIprim As System.Windows.Forms.Button
		Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
		Private ColVraiChiffre As System.Windows.Forms.ColumnHeader
		Private txtSaisieChiffre As System.Windows.Forms.TextBox
		Private ColRatio As System.Windows.Forms.ColumnHeader
		Private CmbRatio As System.Windows.Forms.ComboBox
		Private CmbPourcent As System.Windows.Forms.ComboBox
		Private CmbAdress As System.Windows.Forms.ComboBox
		Private txtPanier As System.Windows.Forms.TextBox
		Private ColDate As System.Windows.Forms.ColumnHeader
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private CmbHeure As System.Windows.Forms.ComboBox
		Private ColHeure As System.Windows.Forms.ColumnHeader
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private ColChiffreImprim As System.Windows.Forms.ColumnHeader
		Private txtAdress As System.Windows.Forms.TextBox
		Private ColTvaSurPlace As System.Windows.Forms.ColumnHeader
		
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
		
		Public Sub InitPrinter()

			Dim LogicalName As String 'Nom de l'imprimante dans Le SetupPos EPSON
	        Dim deviceInfo As DeviceInfo
	        Dim posExplorer As PosExplorer
	
	        LogicalName = "PosPrinter"
	
	        'Crate PosExplorer
	        posExplorer = New PosExplorer
	
	        g_Printer = Nothing
	
	        Try
			deviceInfo = posExplorer.GetDevice(DeviceType.PosPrinter, LogicalName)
			g_Printer = posExplorer.CreateInstance(deviceInfo)
			
			'Open the device
			g_Printer.Open()
			
			'Get the exclusive control right for the opened device.
			'Then the device is disable from other application.
			g_Printer.Claim(1000)
			
			'Enable the device.
			g_Printer.DeviceEnabled = True
	
	        Catch ex As PosControlException
				MessageBox.Show(ex.message, "Erreur Initialisation Imprimante !", MessageBoxButtons.OK, MessageBoxIcon.Error )
	        End Try	
		End Sub
		
		
		Public g_Printer As Microsoft.PointOfService.PosPrinter = Nothing
		
		
		
		#Region " Windows Forms Designer generated code "
		' This method is required for Windows Forms designer support.
		' Do not change the method contents inside the source code editor. The Forms designer might
		' not be able to load this method if it was changed manually.
		Private Sub InitializeComponent()
			Me.ColTvaSurPlace = New System.Windows.Forms.ColumnHeader
			Me.txtAdress = New System.Windows.Forms.TextBox
			Me.ColChiffreImprim = New System.Windows.Forms.ColumnHeader
			Me.label4 = New System.Windows.Forms.Label
			Me.label5 = New System.Windows.Forms.Label
			Me.label6 = New System.Windows.Forms.Label
			Me.ColHeure = New System.Windows.Forms.ColumnHeader
			Me.CmbHeure = New System.Windows.Forms.ComboBox
			Me.label1 = New System.Windows.Forms.Label
			Me.label2 = New System.Windows.Forms.Label
			Me.label3 = New System.Windows.Forms.Label
			Me.ColDate = New System.Windows.Forms.ColumnHeader
			Me.txtPanier = New System.Windows.Forms.TextBox
			Me.CmbAdress = New System.Windows.Forms.ComboBox
			Me.CmbPourcent = New System.Windows.Forms.ComboBox
			Me.CmbRatio = New System.Windows.Forms.ComboBox
			Me.ColRatio = New System.Windows.Forms.ColumnHeader
			Me.txtSaisieChiffre = New System.Windows.Forms.TextBox
			Me.ColVraiChiffre = New System.Windows.Forms.ColumnHeader
			Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker
			Me.BtnIprim = New System.Windows.Forms.Button
			Me.ColPanier = New System.Windows.Forms.ColumnHeader
			Me.BtnClearList = New System.Windows.Forms.Button
			Me.TxtTotalReel = New System.Windows.Forms.TextBox
			Me.ColTvaAEmporter = New System.Windows.Forms.ColumnHeader
			Me.TxtTotalImprim = New System.Windows.Forms.TextBox
			Me.ColClient = New System.Windows.Forms.ColumnHeader
			Me.listView1 = New System.Windows.Forms.ListView
			Me.SuspendLayout
			'
			'ColTvaSurPlace
			'
			Me.ColTvaSurPlace.Text = "19.6%"
			Me.ColTvaSurPlace.Width = 90
			'
			'txtAdress
			'
			Me.txtAdress.Location = New System.Drawing.Point(940, 58)
			Me.txtAdress.Multiline = true
			Me.txtAdress.Name = "txtAdress"
			Me.txtAdress.ReadOnly = true
			Me.txtAdress.Size = New System.Drawing.Size(176, 72)
			Me.txtAdress.TabIndex = 9
			Me.txtAdress.Text = ""
			'
			'ColChiffreImprim
			'
			Me.ColChiffreImprim.Text = "Chiffre Imprimé"
			Me.ColChiffreImprim.Width = 90
			'
			'label4
			'
			Me.label4.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
			Me.label4.Location = New System.Drawing.Point(56, 504)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(100, 24)
			Me.label4.TabIndex = 14
			Me.label4.Text = "Total :"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
			'
			'label5
			'
			Me.label5.Location = New System.Drawing.Point(940, 200)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(100, 18)
			Me.label5.TabIndex = 18
			Me.label5.Text = "Panier moyen :"
			'
			'label6
			'
			Me.label6.Location = New System.Drawing.Point(940, 270)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(110, 23)
			Me.label6.TabIndex = 20
			Me.label6.Text = "Heure de fermeture :"
			'
			'ColHeure
			'
			Me.ColHeure.Text = "Heure"
			Me.ColHeure.Width = 80
			'
			'CmbHeure
			'
			Me.CmbHeure.Items.AddRange(New Object() {"16", "18", "20"})
			Me.CmbHeure.Location = New System.Drawing.Point(940, 290)
			Me.CmbHeure.Name = "CmbHeure"
			Me.CmbHeure.Size = New System.Drawing.Size(121, 21)
			Me.CmbHeure.TabIndex = 21
			AddHandler Me.CmbHeure.SelectedIndexChanged, AddressOf Me.CmbHeureSelectedIndexChanged
			'
			'label1
			'
			Me.label1.Location = New System.Drawing.Point(790, 30)
			Me.label1.Name = "label1"
			Me.label1.TabIndex = 5
			Me.label1.Text = "Saisie du chiffre :"
			'
			'label2
			'
			Me.label2.Location = New System.Drawing.Point(790, 180)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(100, 16)
			Me.label2.TabIndex = 8
			Me.label2.Text = "Pourcentage :"
			'
			'label3
			'
			Me.label3.Location = New System.Drawing.Point(940, 142)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(160, 16)
			Me.label3.TabIndex = 13
			Me.label3.Text = "Ratio Sur Place / A Emporter :"
			'
			'ColDate
			'
			Me.ColDate.Text = "Date"
			Me.ColDate.Width = 150
			'
			'txtPanier
			'
			Me.txtPanier.Location = New System.Drawing.Point(940, 220)
			Me.txtPanier.Name = "txtPanier"
			Me.txtPanier.TabIndex = 22
			Me.txtPanier.Text = ""
			AddHandler Me.txtPanier.KeyDown, AddressOf Me.TxtPanierKeyDown
			AddHandler Me.txtPanier.KeyPress, AddressOf Me.TxtPanierKeyPress
			'
			'CmbAdress
			'
			Me.CmbAdress.Location = New System.Drawing.Point(940, 30)
			Me.CmbAdress.Name = "CmbAdress"
			Me.CmbAdress.Size = New System.Drawing.Size(176, 21)
			Me.CmbAdress.TabIndex = 10
			Me.CmbAdress.Text = "Adresse Boutique :"
			AddHandler Me.CmbAdress.SelectedIndexChanged, AddressOf Me.CmbAdressSelectedIndexChanged
			'
			'CmbPourcent
			'
			Me.CmbPourcent.Items.AddRange(New Object() {"15", "16", "17", "18", "19", "20"})
			Me.CmbPourcent.Location = New System.Drawing.Point(790, 200)
			Me.CmbPourcent.Name = "CmbPourcent"
			Me.CmbPourcent.Size = New System.Drawing.Size(72, 21)
			Me.CmbPourcent.TabIndex = 7
			Me.CmbPourcent.Text = "0"
			AddHandler Me.CmbPourcent.SelectedIndexChanged, AddressOf Me.CmbPourcentSelectedIndexChanged
			'
			'CmbRatio
			'
			Me.CmbRatio.Items.AddRange(New Object() {"0", "2-8", "3-10", "10-23"})
			Me.CmbRatio.Location = New System.Drawing.Point(940, 160)
			Me.CmbRatio.Name = "CmbRatio"
			Me.CmbRatio.Size = New System.Drawing.Size(152, 21)
			Me.CmbRatio.TabIndex = 12
			AddHandler Me.CmbRatio.SelectedIndexChanged, AddressOf Me.CmbRatioSelectedIndexChanged
			'
			'ColRatio
			'
			Me.ColRatio.Text = "Ratio"
			Me.ColRatio.Width = 40
			'
			'txtSaisieChiffre
			'
			Me.txtSaisieChiffre.Location = New System.Drawing.Point(790, 50)
			Me.txtSaisieChiffre.Name = "txtSaisieChiffre"
			Me.txtSaisieChiffre.Size = New System.Drawing.Size(96, 20)
			Me.txtSaisieChiffre.TabIndex = 6
			Me.txtSaisieChiffre.Text = ""
			AddHandler Me.txtSaisieChiffre.KeyDown, AddressOf Me.TxtSaisieChiffreKeyDown
			AddHandler Me.txtSaisieChiffre.KeyPress, AddressOf Me.TxtSaisieChiffreKeyPress
			'
			'ColVraiChiffre
			'
			Me.ColVraiChiffre.Text = "Chiffre Réel"
			Me.ColVraiChiffre.Width = 90
			'
			'dateTimePicker1
			'
			Me.dateTimePicker1.Location = New System.Drawing.Point(8, 8)
			Me.dateTimePicker1.Name = "dateTimePicker1"
			Me.dateTimePicker1.TabIndex = 1
			AddHandler Me.dateTimePicker1.ValueChanged, AddressOf Me.DateTimePicker1ValueChanged
			'
			'BtnIprim
			'
			Me.BtnIprim.Location = New System.Drawing.Point(940, 370)
			Me.BtnIprim.Name = "BtnIprim"
			Me.BtnIprim.Size = New System.Drawing.Size(126, 40)
			Me.BtnIprim.TabIndex = 17
			Me.BtnIprim.Text = "Imprimer"
			AddHandler Me.BtnIprim.Click, AddressOf Me.BtnIprimClick
			'
			'ColPanier
			'
			Me.ColPanier.Text = "Panier "
			'
			'BtnClearList
			'
			Me.BtnClearList.Location = New System.Drawing.Point(464, 0)
			Me.BtnClearList.Name = "BtnClearList"
			Me.BtnClearList.Size = New System.Drawing.Size(96, 23)
			Me.BtnClearList.TabIndex = 11
			Me.BtnClearList.Text = "Vider le tableau"
			AddHandler Me.BtnClearList.Click, AddressOf Me.BtnClearListClick
			'
			'TxtTotalReel
			'
			Me.TxtTotalReel.Location = New System.Drawing.Point(160, 504)
			Me.TxtTotalReel.Name = "TxtTotalReel"
			Me.TxtTotalReel.Size = New System.Drawing.Size(90, 20)
			Me.TxtTotalReel.TabIndex = 15
			Me.TxtTotalReel.Text = ""
			'
			'ColTvaAEmporter
			'
			Me.ColTvaAEmporter.Text = "5.5%"
			Me.ColTvaAEmporter.Width = 90
			'
			'TxtTotalImprim
			'
			Me.TxtTotalImprim.Location = New System.Drawing.Point(250, 504)
			Me.TxtTotalImprim.Name = "TxtTotalImprim"
			Me.TxtTotalImprim.Size = New System.Drawing.Size(90, 20)
			Me.TxtTotalImprim.TabIndex = 16
			Me.TxtTotalImprim.Text = ""
			'
			'ColClient
			'
			Me.ColClient.Text = "Client"
			'
			'listView1
			'
			Me.listView1.BackColor = System.Drawing.SystemColors.HighlightText
			Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDate, Me.ColVraiChiffre, Me.ColChiffreImprim, Me.ColRatio, Me.ColTvaSurPlace, Me.ColTvaAEmporter, Me.ColPanier, Me.ColClient, Me.ColHeure})
			Me.listView1.FullRowSelect = true
			Me.listView1.GridLines = true
			Me.listView1.Location = New System.Drawing.Point(8, 32)
			Me.listView1.MultiSelect = false
			Me.listView1.Name = "listView1"
			Me.listView1.Scrollable = false
			Me.listView1.Size = New System.Drawing.Size(732, 472)
			Me.listView1.TabIndex = 2
			Me.listView1.View = System.Windows.Forms.View.Details
			AddHandler Me.listView1.Click, AddressOf Me.ListView1Click
			'
			'MainForm
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(1126, 536)
			Me.Controls.Add(Me.txtPanier)
			Me.Controls.Add(Me.CmbHeure)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.BtnIprim)
			Me.Controls.Add(Me.TxtTotalImprim)
			Me.Controls.Add(Me.TxtTotalReel)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.CmbRatio)
			Me.Controls.Add(Me.BtnClearList)
			Me.Controls.Add(Me.CmbAdress)
			Me.Controls.Add(Me.txtAdress)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.CmbPourcent)
			Me.Controls.Add(Me.txtSaisieChiffre)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.listView1)
			Me.Controls.Add(Me.dateTimePicker1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = false
			Me.MinimizeBox = false
			Me.Name = "MainForm"
			Me.Text = "Ticket Journalier"
			AddHandler Load, AddressOf Me.MainFormLoad
			Me.ResumeLayout(false)
		End Sub
		#End Region
			
		Private Sub DateTimePicker1ValueChanged(sender As System.Object, e As System.EventArgs)
			Dim DateDebut As datetime
			Dim WriteDate as datetime

			If listview1.items.count > 0 Then
				listview1.Items.clear
			End If
			
			DateDebut=sender.value
			listView1.Items.add(DateDebut.ToLongDateString.ToString)
			
			For i As Integer = 1 To 31
				WriteDate=DateDebut.AddDays(i)
				listView1.Items.add(WriteDate.ToLongDateString.ToString)				
			Next
			
			For i As Integer = 0 To 31
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
				listview1.Items(i).subitems.add(0)
			Next
			
			listview1.Items(0).selected=true
		End Sub
		
	
		Private Sub TxtSaisieChiffreKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
		dim sel as integer			
		
			If e.KeyCode = keys.enter Then
				If TxtSaisieChiffre.Text="" Then
					listview1.selectedItems(0).subitems(1).text="0000"
				Else
					listview1.selectedItems(0).subitems(1).text=TxtSaisieChiffre.Text
				End If					
				TxtSaisieChiffre.Text=""
				sel=listview1.selectedIndices(0)
				If sel<31 Then
					sel+=1
					listview1.Items(sel).selected=True
					
				End If
				CalculPourcent()
			End If
		End Sub

		Private Sub ListView1Click(sender As System.Object, e As System.EventArgs)
			If listview1.selectedItems(0).subitems.count>1 Then
				txtSaisieChiffre.Text=listview1.selectedItems(0).subitems(1).text
				txtSaisieChiffre.select	
			End If
			
		End Sub
		
		Private Sub CmbPourcentSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
			CalculPourcent()
		End Sub
		
		Private Sub CalculPourcent()
			Dim Pourcent As Single
			Dim ChiffreImprim As Single
			Dim VraiChiffre As Single
			Dim TvaSurPlace as single = (19.6/100)
			Dim TvaAEmporter As Single = (5.5/100)
			Dim SurPlace As Single
			Dim AEmporter As Single
			Dim RatioSurPlace As Single
			Dim RatioAEmporter As Single
			Dim TotalVraiChiffre As Single
			Dim TotalChiffreImprim As Single
			Dim strChiffreImprim As String
			Dim j As Integer
			Dim Client As Integer
			Dim Panier As Single
			
						
			Pourcent= (Csng(CmbPourcent.Text) / 100)

			For i As Integer = 0 To listview1.items.count-1
				TotalVraiChiffre += CSng(listview1.Items(i).subitems(1).text)				
			
				VraiChiffre=Csng(listview1.Items(i).subitems(1).text)
				ChiffreImprim = VraiChiffre - (VraiChiffre * Pourcent)
				ChiffreImprim = Math.Round(ChiffreImprim, 2)
				strChiffreImprim=ChiffreImprim.tostring
				j = strChiffreImprim.Length
				Select Case strChiffreImprim.chars(j-1)
					Case "1","2","3","4"
						strChiffreImprim = strChiffreImprim.Remove(j-1,1)
						strChiffreImprim = strChiffreImprim.Insert(j-1,"0")
					Case "6","7","8","9"
						strChiffreImprim = strChiffreImprim.Remove(j-1,1)
						strChiffreImprim = strChiffreImprim.Insert(j-1,"5")
				End Select
				listview1.Items(i).subitems(2).text=strChiffreImprim
				
				TotalChiffreImprim +=Csng(listview1.Items(i).subitems(2).text)
				
				RatioSurPlace=CSng(listview1.Items(i).subitems(3).text) / 100
				RatioAEmporter=1-RatioSurPlace
				
				SurPlace=ChiffreImprim*TvaSurPlace*RatioSurPlace
				SurPlace=Format(SurPlace,"#0.00")
				AEmporter=ChiffreImprim*TvaAEmporter*RatioAEmporter
				AEmporter=Format(AEmporter,"#0.00")
				
				listview1.Items(i).subitems(4).text=SurPlace.tostring
				listview1.Items(i).subitems(5).text=AEmporter.tostring
				
				If CSng(listview1.Items(i).subitems(6).text)<>0 Then
					Panier=Csng(listview1.Items(i).subitems(6).text)
					Client=CInt(ChiffreImprim / Panier)
					listview1.Items(i).subitems(7).text=Client.tostring	
				End If
				
			Next	
			
			TxtTotalReel.Text=TotalVraiChiffre.tostring
			TxtTotalImprim.Text=TotalChiffreImprim.tostring
			
		End Sub
	
		Private Sub TxtSaisieChiffreKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
			Dim pos As Integer
			pos = TxtSaisieChiffre.SelectionStart

			If IsNumeric(e.KeyChar) Then
			    e.Handled = False			
			ElseIf e.KeyChar = "."
				If TxtSaisieChiffre.Text.IndexOf(",") > 0 Then
					e.Handled = True
					exit sub
				End If
			    e.Handled = True
			    TxtSaisieChiffre.Text = TxtSaisieChiffre.Text.Insert(pos, ",")'on insère un ','
				TxtSaisieChiffre.SelectionStart = pos + 1 
			Else
				e.Handled = True
			End If			
		End Sub		
		
		Private Sub MainFormLoad(sender As System.Object, e As System.EventArgs)
			Dim SW As New StreamReader ("Adress")
			Dim LineAdress As String
			Dim i as string=1

			Do Until Sw.Peek=-1
				LineAdress=Sw.ReadLine()
				LineAdress=LineAdress.Replace("%" , (chr(13)& chr(10)))				
				CmbAdress.Items.add(i & (chr(13)& chr(10)) & LineAdress)
				i+=1
			Loop
			
			InitPrinter()
			
			Sw.Close()			
		End Sub
		
		Private Sub CmbAdressSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
			txtAdress.Text=CmbAdress.Text			
		End Sub
		
		Private Sub BtnClearListClick(sender As System.Object, e As System.EventArgs)
			
			For i As Integer=0 To listview1.Items.count-1
				listview1.Items(i).subitems(1).text=0
				listview1.Items(i).subitems(3).text=0
				listview1.Items(i).subitems(6).text=0
				listview1.Items(i).subitems(8).text=0
			Next
			
			CalculPourcent()
		End Sub
		
		Private Sub CmbRatioSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
			Dim Ratio As Single
			Dim First As Integer
			Dim Last As Integer
			Dim Fourchette(2) As String
			
			If CmbRatio.Text="0" Then
				For i As Integer = 0 To listview1.Items.count - 1
					listview1.Items(i).subitems(3).text=0
				Next
				CalculPourcent()
				Exit Sub
			End If
			
			Fourchette = CmbRatio.Text.Split("-")
			First=CSng(Fourchette(0))
			Last=CSng(Fourchette(1))
			
			For i As Integer = 0 To listview1.Items.count - 1
				Ratio=CInt(Int((Last - First + 1) * Rnd()) + First)
				listview1.Items(i).subitems(3).text=ratio		
			Next
			CalculPourcent()
		End Sub
		
		Private Sub BtnIprimClick(sender As System.Object, e As System.EventArgs)
			Dim Chiffre As string
			Dim SurPlace As string
			Dim AEmporter As string
			Dim Adress() As String
			Dim strDate As String
			Dim strPrintData As String = ""	
			
			Dim ESC As String
			
			Adress=txtAdress.lines
			
			
				
			For i As Integer = 0 To listview1.items.count-1
			If CSng(listview1.Items(i).subitems(2).text)=0 Then
					
			Else	
				strDate=listview1.Items(i).subitems(0).text
				Chiffre=listview1.Items(i).subitems(2).text
				SurPlace=listview1.Items(i).subitems(4).text
				AEmporter=listview1.Items(i).subitems(5).text
				
'###################		IMPRESSION		#########		IMPRESSION		#########		IMPRESSION

			'ESC command
	   		ESC = Chr(&H1B)	
			
			'<<<step6>>>--Start
	        'When outputting to a printer,a mouse cursor becomes like a hourglass.
	        Cursor.Current = Cursors.WaitCursor
	
	        If g_Printer.CapRecPresent = True Then	
	            Try	
	                '<<<step6>>>--Start
	                'Batch processing mode
					g_Printer.TransactionPrint(PrinterStation.Receipt _
						,PrinterTransactionControl.Transaction)
	
	                '<<<step3>>>--Start
'	                g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|3B")
	                '<<<step3>>>--End			
			        
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|4C"+ Adress(1) + vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Adress(2) + vbCrLf)
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Adress(3) + vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Adress(4) + vbCrLf+ vbCrLf)
					Traceligne()					
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ "Clôture de la caisse :"+ vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strdate + vbCrLf)
					Tracedblligne()
					
					strPrintData = MakePrintString(g_Printer.RecLineChars, _
					"Total TTC :","", Chiffre & " Euro")
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|2C" + ESC + "|bC" +strPrintData + vbCrLf)
					
					Traceligne()
					strPrintData = MakePrintString(g_Printer.RecLineChars, _
					"Montant TVA à 5,5% :","", AEmporter & " Euro")
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strPrintData + vbCrLf)
					Traceligne()
					strPrintData = MakePrintString(g_Printer.RecLineChars, _
					"Montant TVA à 19,6% :","", SurPlace & " Euro")
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strPrintData + vbCrLf)
					Tracedblligne()

					'Make 10mm speces
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|100uF")
					
					''Feed the receipt to the cutter position automatically, and cut.
	                ''ESC|#fP = Line Feed and Paper cut	
	                g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|fP")
	
	                'print all the buffer data. and exit the batch processing mode.
	                g_Printer.TransactionPrint(PrinterStation.Receipt _
	                  , PrinterTransactionControl.Normal)
	                '<<<step6>>>--End
				
	       		Catch ex As PosControlException	
	            End Try
			End If	
			
'###################		IMPRESSION		#########		IMPRESSION		#########		IMPRESSION			
			end If
			
			Next
			
		End Sub
		
		Private Function MakePrintString(ByVal Chars as integer, ByVal strQty as string, ByVal strText as string, ByVal strTotal as string)
	    	Dim strValue As String
	        Dim iSpace As integer = 0
	        Dim tab As String = ""
	
	        iSpace = Chars - (strQty.Length + strText.Length + strTotal.Length)
	
	        For i As Integer = 0 To iSpace - 1
	            tab += " "
	        Next
	
	        strValue = strQty  + strText + tab + strTotal
	        MakePrintString = strValue
	    End Function
	    
		Private Sub TraceLigne()
	    	Dim Ligne As String
	    	
	    	For i As Integer  = 0 To g_Printer.RecLineChars -1
	    		Ligne += "-"
	    	Next i
	 		g_Printer.PrintNormal(PrinterStation.Receipt, Ligne)
	 		
	    End Sub
		
		Private Sub TraceDblLigne()
	    	Dim Ligne As String
	    	
	    	For i As Integer  = 0 To g_Printer.RecLineChars -1
	    		Ligne += "="
	    	Next i
	 		g_Printer.PrintNormal(PrinterStation.Receipt, Ligne)
	 		
	    End Sub
		
		Public Sub ClosePrinter()
		If g_Printer Is Nothing Then
            Return
        End If

        Try
            'Cancel the device
            g_Printer.DeviceEnabled = False

            'Release the device exclusive control right.
            g_Printer.Release()


        Catch ex As Exception

        Finally
            'Finish using the device.
            g_Printer.Close()

        End Try
	End Sub
	
	
	Private Sub TxtPanierKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
		Dim sel As Integer
		Dim Panier As Single
		Dim PanierMini As Single
		Dim PanierMaxi As Single
	
			If e.KeyCode = keys.enter Then
				If txtPanier.Text="" Then
					Exit Sub
				Else
					Panier=CSng(txtPanier.Text)
					PanierMini=(Panier - 0.2)
					PanierMaxi=(Panier + 0.2)
						For i As Integer = 0 To listview1.Items.count - 1							
							Panier=((PanierMaxi - PanierMini ) * Rnd() + PanierMini)
							Panier=Math.round(Panier,2)
							listview1.Items(i).subitems(6).text=Panier.tostring								
						Next
				End If					
				CalculPourcent()
			End If
		
	End Sub
	
	Private Sub TxtPanierKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
		Dim pos As Integer
			pos = TxtPanier.SelectionStart

			If IsNumeric(e.KeyChar) Then
			    e.Handled = False			
			ElseIf e.KeyChar = "."
				If TxtPanier.Text.IndexOf(",") > 0 Then
					e.Handled = True
					exit sub
				End If
			    e.Handled = True
			    TxtPanier.Text = TxtPanier.Text.Insert(pos, ",")'on insère un ','
				TxtPanier.SelectionStart = pos + 1 
			Else
				e.Handled = True
			End If				
	End Sub
	
	
	Private Sub CmbHeureSelectedIndexChanged(sender As System.Object, e As System.EventArgs)
		Dim Heure As Single
		Dim HeureMin As Single
		Dim HeureMax As Single
		Dim H As Integer
		Dim Min As Single
		Dim strHeure As String
		
		Heure=CmbHeure.Text
		HeureMin=(Heure - 0.17)
		HeureMax=(Heure + 0.085)
		
		For i As Integer = 0 To listview1.Items.count - 1							
			Heure=((HeureMax - HeureMin ) * Rnd() + HeureMin)
			H=Fix(Heure)
			
			Min=(Heure-H)*60
			Min=Math.round(Min,0)
			
			If Min = 60 Then
				H+=1
				Min=0
			End If
			
			strHeure=H & ":" & Min
			
			If strHeure.Length=4 Then
				strHeure=strHeure.Insert(3,"0")
			End If
			
			listview1.Items(i).subitems(8).text=strHeure.tostring								
		Next
		
	End Sub
	
	
	End Class
End Namespace
