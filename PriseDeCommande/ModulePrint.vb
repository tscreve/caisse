'
' Crée par SharpDevelop.
' Utilisateur: tom
' Date: 19/05/2010
' Heure: 20:53
' 
' Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
'
Imports Microsoft.PointOfService
Imports System.IO

Public Module ModulePrint
	Public g_Printer As Microsoft.PointOfService.PosPrinter = Nothing

	Dim adress(3) As String
	
	Dim ESC As String
	
	
	
	 Private Sub ReadAdress()
    	Dim SW As New StreamReader ("Adress")
		Dim i as integer=0
    	
    	Do Until Sw.Peek=-1
			Adress(i)=Sw.ReadLine()
			i+=1				
		Loop
		Sw.Close()
    End Sub
    
	Public Sub InitPrinter()

			Dim LogicalName As String 'Nom de l'imprimante dans Le SetupPos EPSON
	        Dim deviceInfo As DeviceInfo
	        Dim posExplorer As PosExplorer
	
	        LogicalName = "PosPrinter"
			
			ReadAdress()
			
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
		
	Public Sub PrintTicket(Societe As String, Nom As String, Tel as String, Adress As String, Produit as ArrayList, Prix as ArrayList)
		Dim dateTime As DateTime = New DateTime
		Dim strDate As String
		
		dateTime = dateTime.Now()
		strDate = dateTime.ToString("dd/MM/yyyy")
		
		
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
			        
			    	g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|4C"+ adress(0) + vbCrLf)
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ adress(1) + vbCrLf)
			        g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ adress(2) + vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" +ESC + "|bC"+ adress(3) + vbCrLf+ vbCrLf)
					g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N"  +ESC + "|bC"+ "Commandé par : " + Nom + strdate + vbCrLf+ vbCrLf)
	        		
					g_Printer.PrintNormal(PrinterStation.Receipt,"Détail Commande :"+ vbCrLf)
					TraceLigne()
					
					
					
					
					
					
					
					
					
					
					
'					For i As Integer = 0 To T.Item(id).count-1
'						strPrintData = MakePrintString(g_Printer.RecLineChars, _
'						T.Item(id).Item(i).qty & "x ",T.Item(id).Item(i).text, T.Item(id).Item(i).total & " Euro")
'						g_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + vbCrLf)
'					Next
'					
					
					
					
					
					
					
					
					
					
					
					
			Catch ex As PosControlException	
	            End Try
	        End If
	End Sub
		
	Private Function MakePrintString(ByVal Chars as integer, ByVal strQty as string, ByVal strText as string, ByVal strTotal as string)as String
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
	    	Dim Ligne As String =""
	    	
	    	For i As Integer  = 0 To g_Printer.RecLineChars -1
	    		Ligne += "-"
	    	Next i
	 		g_Printer.PrintNormal(PrinterStation.Receipt, Ligne)
	 		
	    End Sub
		
	Private Sub TraceDblLigne()
	    	Dim Ligne As String = ""
	    	
	    	For i As Integer  = 0 To g_Printer.RecLineChars -1
	    		Ligne += "="
	    	Next i
	 		g_Printer.PrintNormal(PrinterStation.Receipt, Ligne)
	 		
	    End Sub
	
	Private Sub PrintFormule()
    	ESC = Chr(&H1B)
    	
    	TraceLigne()
    	g_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|bC" + ESC + "|cA" + "Merci pour votre commande et à  bientôt !" + vbCrLf)
    	TraceLigne()
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
End Module
