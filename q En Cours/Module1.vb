'
' Created by SharpDevelop.
' User: Admin
' Date: 03/07/2006
' Time: 18:29
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.PointOfService
Imports Microsoft.VisualBasic
Imports System.Globalization
Imports System.IO



Module Module1
	
	Public g_Printer As Microsoft.PointOfService.PosPrinter = Nothing
	Public g_Drawer As Microsoft.PointOfService.CashDrawer = Nothing
	Public g_Display As Microsoft.PointOfService.LineDisplay = Nothing

	Public Config(5) As String
	
	Dim ESC As String
    
    Public Sub ReadConfig()
    	Dim SW As New StreamReader ("Config")
		Dim i as integer=0
    	
    	Do Until Sw.Peek=-1
			Config(i)=Sw.ReadLine()
			i+=1				
		Loop
		Sw.Close()
    End Sub
    
    Public Sub WriteConfig()
    	Dim SW As New StreamWriter ("Config")
		Dim i As Integer=0
				
		For i=0 To Config.Length-1
		    SW.writeline(Config(i))
		Next
		
		Sw.Close()
				
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
		
	Public Sub InitDrawer()
		Dim LogicalName As String 'Nom donnÃ© au tiroir caisse dans Le SetupPos EPSON
        Dim deviceInfo As DeviceInfo
        Dim posExplorer As PosExplorer

        LogicalName = "CashDrawer"

        'Crate PosExplorer
        posExplorer = New PosExplorer

        g_Drawer = Nothing

        Try
		deviceInfo = posExplorer.GetDevice(DeviceType.CashDrawer, LogicalName)
		g_Drawer = posExplorer.CreateInstance(deviceInfo)
		
		'Open the device
		g_Drawer.Open()
		
		'Get the exclusive control right for the opened device.
		'Then the device is disable from other application.
		g_Drawer.Claim(1000)
		
		'Enable the device.
		g_Drawer.DeviceEnabled = True

        Catch ex As PosControlException
            MessageBox.Show(ex.message, "Erreur Initialisation Tiroir !", MessageBoxButtons.OK, MessageBoxIcon.Error )						            
        End Try
	End Sub
	
	Public Sub InitLineDisplay()
		 '<<<step1>>>--Start
        'Use a Logical Device Name which has been set on the SetupPOS.
        Dim strLogicalName As String
        Dim deviceInfo As DeviceInfo
        Dim posExplorer As PosExplorer

        strLogicalName = "LineDisplay"

        'Crate PosExplorer
        posExplorer = New PosExplorer

		Try		
		deviceInfo = posExplorer.GetDevice(DeviceType.LineDisplay, strLogicalName)
		g_Display = posExplorer.CreateInstance(deviceInfo)
		
		'Open the device
		g_Display.Open()
		
		'Get the exclusive control right for the opened device.
		'Then the device is disable from other application.
		g_Display.Claim(1000)
		
		'If support the CapPowerReporting, enable the Power Reporting Requirements.
		If Not g_Display.CapPowerReporting = PowerReporting.None Then		
			g_Display.PowerNotify = PowerNotification.Enabled		
		End If
		
		'Enable the device.
		g_Display.DeviceEnabled = True
		
		Catch ex As Exception
			MessageBox.Show(ex.message, "Erreur Initialisation Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )						            
       	End Try
       	
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
		
	Public Sub CloseDrawer()
		If g_Drawer Is Nothing Then
            Return
        End If

        Try
            'Cancel the device
            g_Drawer.DeviceEnabled = False

            'Release the device exclusive control right.
            g_Drawer.Release()

        Catch ex As Exception

        Finally
            'Finish using the device.
            g_Drawer.Close()

        End Try
        
        
        

	End Sub	

	Public Sub CloseLineDisplay()
		 '<<<step1>>>--Start
        If g_Display Is Nothing Then
            Return
        End If

        Try
            'Cancel the device
            g_Display.DeviceEnabled = False

            'Release the device exclusive control right.
            g_Display.Release()

        Catch ex As PosControlException

        Finally
            'Finish using the device.
            g_Display.Close()

        End Try
        '<<<step1>>>--End
	End Sub
    #Region "Impression"
    
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
    
    Private Sub PrintFormule()
    	ESC = Chr(&H1B)
    	
    	TraceLigne()
    	g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|bC" + ESC + "|cA" + "Merci de votre visite et à  bientôt !" + vbCrLf)
    	TraceLigne()
    End Sub
    
    	#Region "Impression du Ticket"
    	
		Public Sub PrintTicket(T as object, Id as integer, NumFacture as integer, ValTVA as single)
			Dim TTC as single
			Dim MontantTVA As Single=0
			Dim strDate As String
			Dim dateTime As DateTime = New DateTime
			    	
			dateTime = dateTime.Now()
			strDate = dateTime.ToString("dd/MM/yyyy")
			
	        Dim strPrintData As String = ""	
	
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
	                g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|3B")
	                '<<<step3>>>--End			
			        
			    	g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|4C"+ Config(0) + vbCrLf)
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Config(1) + vbCrLf)
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Config(2) + vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Config(3) + vbCrLf+ vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ "Facture N°: " + Cstr(NumFacture) +" du " + strdate + vbCrLf+ vbCrLf)
	        		
					g_Printer.PrintNormal(PrinterStation.Receipt,"Détail Commande :"+ vbCrLf)
					TraceLigne()
					
					For i As Integer = 0 To T.Item(id).count-1
						strPrintData = MakePrintString(g_Printer.RecLineChars, _
						T.Item(id).Item(i).qty & "x ",T.Item(id).Item(i).text, T.Item(id).Item(i).total & " Euro")
						g_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + vbCrLf)
					Next
					
					g_Printer.PrintNormal(PrinterStation.Receipt,  vbCrLf)
					TraceDblLigne()
	'				
	'				'######		TOTAL		######	
					strPrintData = MakePrintString(g_Printer.RecLineChars, _
					"Total TTC :","", T.Item(id).totalTicket & " Euro")
					
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|2C" + ESC + "|bC" +strPrintData + vbCrLf)					
					TraceDblLigne()
					
					'#######	TVA		######	
					TTC=T.Item(id).totalTicket
					MontantTVA=TTC-(TTC/(1+ValTVA/100))
					
					strPrintData = MakePrintString(g_Printer.RecLineChars, _
					"TVA à " & ValTVA & " %","", MontantTVA.ToString("#,##0.00") & " Euro")
					
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|1C" +strPrintData + vbCrLf)

					PrintFormule()
					
					'Make 5mm speces
'					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|50uF")
					
					'Impression des moyens de paiement
					g_Printer.PrintNormal(PrinterStation.Receipt,"Payé en :" + vbCrLf)					
					
	                
					For i As Integer=0 To T.item(id).paiementcount-1
						strPrintData = MakePrintString(g_Printer.RecLineChars, _
						"- " & T.Item(id).paiement(i).nom, "", T.Item(id).paiement(i).total & " Euro")
						g_Printer.PrintNormal(PrinterStation.Receipt, strPrintData)
					Next
					
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
	        '//<<<step2>>>--End	    
	    End Sub    
	    
	    #End Region
	    
	    #Region "Impression de l'avoir"
	    
	    Public Sub PrintAvoir(strAvoir As String)
	    	Dim strPrintData As String = ""	
	    	Dim strDate As String
		    Dim dateTime As DateTime = New DateTime
		    
		    dateTime = dateTime.Now()
		    strDate = dateTime.ToString("le dd/MM/yyyy")
	    	ESC = Chr(&H1B)
	    	
		    If g_Printer.CapRecPresent = True Then	
				Try	
				'<<<step6>>>--Start
				'Batch processing mode
				g_Printer.TransactionPrint(PrinterStation.Receipt _
				,PrinterTransactionControl.Transaction)
				
				'<<<step3>>>--Start
				g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|3B")			
	        
		        'ENTETE
		    	g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|4C"+ Config(0) + vbCrLf)
		        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Config(1) + vbCrLf)
		        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Config(2) + vbCrLf)
				g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ Config(3) + vbCrLf+ vbCrLf)
				g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+strdate + vbCrLf+ vbCrLf)
				
				strPrintData=MakePrintString(g_Printer.RecLineChars, _
				"AVOIR :", "", strAvoir & " Euro")
						
				g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|2C" + ESC + "|bC" + strPrintData)
				
				PrintFormule()
				
				g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|fP")	    
				
				g_Printer.TransactionPrint(PrinterStation.Receipt _
				, PrinterTransactionControl.Normal)
				Catch ex As PosControlException	
				End Try
		    End If
	    End Sub
	   
	    #End Region	    
	    
	    #Region "Impression du ticket de fin de caisse"
	    
	    Private Function Coder(ByVal TextACoder as string)
	    	Dim TextCoder As String =""
	    	
	    	For i As Integer =0 To TextACoder.Length-1
				Select Case TextACoder.chars(i)
				Case "0"
					TextCoder+="F"
				Case "1"
					TextCoder+="N"	
				Case "2"
					TextCoder+="Q"					
				Case "3"
					TextCoder+="P"
				Case "4"
					TextCoder+="C"
				Case "5"
					TextCoder+="R"
				Case "6"
					TextCoder+="L"
				Case "7"
					TextCoder+="W"
				Case "8"
					TextCoder+="B"
				Case "9"
					TextCoder+="X"
				Case ","
					TextCoder+="I"
				End Select
			Next
	    	
	    	Coder=TextCoder
	    End Function
	    
	    Public Sub PrintCaisse(TslesT as q.TousLesTickets)
	    	Dim strDate As String
	    	Dim strTime As String
	    	
	    	Dim strTotalCaisse As String= Coder(TslesT.totalcaisse)
	    	Dim strTR As String = Coder(TslesT.NbTotalTR) & "#" & Coder(TslesT.TotalTR)
	    	Dim strAvoir As String= Coder(TslesT.NbTotalAvoir) & "#" & Coder(TslesT.TotalAvoir)
	    	Dim strChk As String = Coder(TslesT.NbTotalChk) & "#" & Coder(TslesT.TotalChk)
	    	Dim strEsp As String = Coder(TslesT.TotalEsp)
	    	
			Dim dateTime As DateTime = New DateTime
			    	
			dateTime = dateTime.Now()
			strDate = dateTime.ToString("dd/MM/yyyy")
			strTime=now.toshorttimestring
	        Dim strPrintData As String = ""	
	    	
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
			        
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N" +ESC + "|bC" + "Magasin : " + Config(1) & " " & Config(2) + vbCrLf)
			        traceligne()
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ "Caisse du " + strdate + " à " + strTime + vbCrLf+ vbCrLf)
					traceligne()
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ "Nombre de client : " & TslesT.Count.ToString+ vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strTotalCaisse+ vbCrLf+ vbCrLf)					
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strTR+ vbCrLf)					
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strAvoir+ vbCrLf)					
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strChk+ vbCrLf)						
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ strEsp+ vbCrLf+ vbCrLf)
					traceligne()
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ "Nom et signature de la vendeuse :" + vbCrLf)
					
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
			
	    End Sub
	    
	    #End Region
   #End Region

	#Region "Display"
		Public Sub PrintDisplay(ByVal strTexte as string,ByVal strPrix as string)			
			Dim StrDisplay As String
			Dim strSpace as string =""
			Dim lStrDisplay As Integer
			
			Try
            	g_Display.ClearText()
				lStrDisplay=40-(strTexte.length+strPrix.Length+4)			
					For i As integer=0 To lStrDisplay
						strSpace+=" "
					Next			
				StrDisplay=strTexte & strSpace & strPrix & " E."
				g_Display.DisplayText(StrDisplay, DisplayTextMode.Normal)
				
			Catch ex As PosControlException
	        	MessageBox.Show(ex.message, "Erreur Afficheur !", MessageBoxButtons.OK, MessageBoxIcon.Error )
	        End Try
			
		End Sub
	#End Region
	
End Module
