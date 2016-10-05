'
' Crée par SharpDevelop.
' Utilisateur: tom
' Date: 04/05/2010
' Heure: 21:01
'
' Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
'
	
Public Partial Class MainForm
	
Dim produit As String
Dim prix As String
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.Width=370
		InitPrinter()
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnSaisieClick(sender As Object, e As EventArgs)
		Dim str1 As String
		Dim str2 As String
		Dim l As Integer
		Dim c As Char = " "
		Dim pos As Integer

		If Me.Width=370 Then
			Me.Width=655
			BtnSaisie.Text="<<<<<<<<<<"
			
			For i=0 To cmbSauce.Items.Count-1
				cmbSauceMenu.Items.Add(cmbSauce.Items(i))
			Next
			For i=0 To cmbBoisson.Items.Count-2
				str1=cmbBoisson.Items(i)
				l=str1.Length
				pos=str1.LastIndexOf(c)
				str2=str1.Substring(pos,(l-pos))
				
				str1=str1.Remove(pos,(l-pos))
				Select Case str2
					Case " 2.20€"
						str2="+0.50€"
						str1 += " " & str2
						cmbBoissonMenu.Items.Add(str1)
					Case " 2.70€"
						str2="+1.00€"
						str1 += " " & str2
						cmbBoissonMenu.Items.Add(str1)
					Case Else
						str2=""
						cmbBoissonMenu.Items.Add(str1)
				End Select
				
				
				
				
			Next
			For i=0 To cmbDessert.Items.Count-1
				str1=cmbDessert.Items(i)
				str2=EnlevePrix(str1)
				cmbDessertMenu.Items.Add(str2)
			Next
		Else
			Me.Width=370
			BtnSaisie.Text=">>>>>>>>>>"
			
			cmbBoissonMenu.Items.Clear
			cmbDessertMenu.Items.Clear
			cmbSauceMenu.Items.Clear
		End If
		
			
	End Sub
	
	Function EnlevePrix(str as String) as String
		Dim l As Integer 'longueur de la chaine
		Dim c As Char = " " 'on cherche le dernier " " pour enlever le prix après le " "
		Dim pos As Integer 'position du dernier " "
		
		If str = "" Then
			EnlevePrix=""
			Exit Function
		End If
		
		l=str.Length
		pos=str.LastIndexOf(c)
		EnlevePrix=str.Remove(pos,(l-pos))
				
		Exit Function
	End Function
	
	Sub CmbMenuSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str1 As String
		Dim str2 As String
		
		cmbProduitMenu.width=265
		lblSauce.Text=""
		cmbProduitMenu.Items.Clear
		Select Case CmbMenu.SelectedIndex
			Case 0
				lblProduit.Text="Sandwichs"
				For i=0 To cmbSandwich.Items.Count-1
					str1=cmbSandwich.Items(i)
					str2=EnlevePrix(str1)
					cmbProduitMenu.Items.Add(str2)
				Next
			
			Case 1
				lblProduit.Text="Salades"
				cmbProduitMenu.width=158
				lblSauce.Text="Sauce"
				For i=0 To cmbSalade.Items.Count-1
					str1=cmbSalade.Items(i)
					str2=EnlevePrix(str1)
					cmbProduitMenu.Items.Add(str2)
				Next
				
			Case 2
				lblProduit.Text="Tartes salées"
				For i=0 To cmbTarte.Items.Count-1
					str1=cmbTarte.Items(i)
					str2=EnlevePrix(str1)
					cmbProduitMenu.Items.Add(str2)
				Next
			
			Case 3
				lblProduit.Text="Plats chaud"
				For i=0 To cmbPlat.Items.Count-1
					str1=cmbPlat.Items(i)
					str2=EnlevePrix(str1)
					cmbProduitMenu.Items.Add(str2)
				Next
			Case Else
				lblProduit.Text=""
		End Select
	End Sub
		
	Sub SeparePrix(str as String)
		Dim l As Integer 'longueur de la chaine
		Dim c As Char = " " 'on cherche le dernier " " pour séparer le prix du produit
		Dim pos As Integer 'position du dernier " "
		
		If str = "" Then
			Exit Sub
		End If
		
		l=str.Length
		pos=str.LastIndexOf(c)
		produit=str.Remove(pos,(l-pos))
		prix=str.Remove(0,pos)
	End sub
	
	Sub BtnValidMenuClick(sender As Object, e As EventArgs)
		Dim lvi As New ListViewItem
		Dim lvi1 As New ListViewItem
		Dim lvi2 As New ListViewItem
		Dim lvi3 as New ListViewItem
		Dim str As String
		
		'on verifie que le menu est bien complet
		If cmbMenu.Text="" Or cmbProduitMenu.text = "" or cmbBoissonMenu.text = "" Or cmbDessertMenu.Text ="" Then
			messagebox.Show("Le menu n'est pas complet !")
			exit sub
		End If
		
		str=cmbMenu.Text
		SeparePrix(str)
		lvi.Text="Menu " & produit
		lvi.SubItems.Add(prix)
		lstCommande.Items.Add(lvi)
		
		lvi1.Text= "   " & cmbProduitMenu.text
		If cmbSauceMenu.Text<>"" Then
			lvi1.text += " + " & cmbSauceMenu.Text
		End If
		lstCommande.Items.Add(lvi1)
		
		str=cmbBoissonMenu.Text
		If str.Contains("€") Then
			SeparePrix(str)
			lvi2.Text="   " & produit
			lvi2.SubItems.Add(prix)
			lstcommande.Items.Add(lvi2)
		Else
			lvi2.Text= "   " & str
			lstCommande.Items.Add(lvi2)
		End If
		
		lvi3.Text= "   " & cmbDessertMenu.Text
		lstCommande.Items.Add(lvi3)
		
		cmbMenu.SelectedIndex=-1
		cmbProduitMenu.SelectedIndex=-1
		cmbSauceMenu.SelectedIndex=-1
		cmbBoissonMenu.SelectedIndex=-1
		cmbDessertMenu.SelectedIndex=-1
		
		CalculTotal()
	End Sub
	
	Sub CalculTotal()
		Dim strtotal As String
		Dim total as Single
		
		For i=0 To lstcommande.Items.Count -1
			If lstcommande.Items(i).subitems.count = 2 Then
				strtotal = lstcommande.Items(i).subitems(1).text
				strtotal = strtotal.Replace("€","")
				strtotal = strtotal.Replace(".",",")
				strtotal = strtotal.Replace("+","")
				total += strtotal
			End If
			
		Next
		txtTotal.Text=Format(total, "0.00€")
	End Sub
	
	Sub CmbSandwichSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi As New ListViewItem
		
		If CmbSandwich.Text<>"" Then
			str=CmbSandwich.Text
			SeparePrix(str)
			lvi.Text="Sandwich " & produit
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			CmbSandwich.SelectedIndex=-1
			CalculTotal()
		End If
	End Sub
		
	Sub CmbSauceSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi As New ListViewItem
		
		If CmbSalade.Text<>"" Then
			str=CmbSalade.Text
			SeparePrix(str)
			lvi.Text="Salade " & produit & "+ " & CmbSauce.Text
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			CmbSalade.SelectedIndex=-1
			CmbSauce.SelectedIndex=-1
			CalculTotal()
		End If
		
	End Sub
	
	Sub CmbTarteSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi As New ListViewItem
		
		If CmbTarte.Text<>"" Then
			str=CmbTarte.Text
			SeparePrix(str)
			lvi.Text="Tarte salée : " & produit
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			CmbTarte.SelectedIndex=-1
			CalculTotal()
		End If
		
	End Sub
	
	Sub CmbPlatSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi As New ListViewItem
		
		If CmbPlat.Text<>"" Then
			str=CmbPlat.Text
			SeparePrix(str)
			lvi.Text="Plat chaud : " & produit
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			CmbPlat.SelectedIndex=-1
			CalculTotal()
		End If
	End Sub
	
	Sub CmbDessertSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi As New ListViewItem
		
		If CmbDessert.Text<>"" Then
			str=CmbDessert.Text
			SeparePrix(str)
			lvi.Text=produit
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			CmbDessert.SelectedIndex=-1
			CalculTotal()
		End If
	End Sub
	
	Sub CmbBoissonSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi As New ListViewItem
		
		If CmbBoisson.Text<>"" Then
			str=CmbBoisson.Text
			SeparePrix(str)
			lvi.Text=produit
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			CmbBoisson.SelectedIndex=-1
			CalculTotal()
		End If
	End Sub
	
	Sub BtnEffaceToutClick(sender As Object, e As EventArgs)
		lstcommande.Items.Clear
		CalculTotal()
	End Sub
	
	Sub BtnEnleveClick(sender As Object, e As EventArgs)
		Dim str As String
		Dim pos As Integer
		Dim c as char
		
		If lstcommande.SelectedItems.Count > 0 Then
			str=lstcommande.SelectedItems(0).tostring
			pos=lstcommande.SelectedIndices(0)
			c=lstcommande.SelectedItems(0).subitems(0).text
			If str.Contains("Menu") or str.Contains("3 Viennoiseries au choix") Then
				lstcommande.Items(pos+3).remove
				lstcommande.Items(pos+2).remove
				lstcommande.Items(pos+1).remove
				lstcommande.Items(pos).remove
			Else If  c = " " Then
				exit sub
			else
				lstcommande.Items(pos).remove
			End If
		End If
		
		CalculTotal()
	End Sub
	
	Sub CmbViennSelectedIndexChanged(sender As Object, e As EventArgs)
		Dim str As String
		Dim lvi as New ListViewItem
		
		If cmbVienn.Text<>"" Then
			Select Case cmbVienn.SelectedIndex
			Case 0
				cmbVienn1.Visible=True
				cmbVienn2.Visible=True
				cmbVienn3.Visible=True
			Case Else
				str=CmbVienn.Text
				SeparePrix(str)
				lvi.Text=produit
				lvi.SubItems.Add(prix)
				lstcommande.Items.Add(lvi)
				CalculTotal()
				CmbVienn.SelectedIndex=-1
			End Select
			
			
		End If
		
	End Sub
	
	Sub CmbVienn1SelectedIndexChanged(sender As Object, e As EventArgs)
		TroisVienn()
	End Sub
	
	Sub CmbVienn2SelectedIndexChanged(sender As Object, e As EventArgs)
		TroisVienn()
	End Sub
	
	Sub CmbVienn3SelectedIndexChanged(sender As Object, e As EventArgs)
		TroisVienn()
	End Sub
	
	Sub TroisVienn()
		Dim lvi As New ListViewItem
		Dim lvi1 As New ListViewItem
		Dim lvi2 As New ListViewItem
		Dim lvi3 As New ListViewItem
		Dim str As String
		
		If CmbVienn1.Text= "" Or CmbVienn2.Text= "" Or CmbVienn3.Text= "" Then
			Exit Sub
		Else
			str=CmbVienn.Text
			SeparePrix(str)
			lvi.Text=produit
			lvi.SubItems.Add(prix)
			lstcommande.Items.Add(lvi)
			
			lvi1.Text="   " & cmbVienn1.Text
			lstcommande.Items.Add(lvi1)
			
			lvi2.Text="   " & cmbVienn2.Text
			lstcommande.Items.Add(lvi2)
			
			lvi3.Text="   " & cmbVienn3.Text
			lstcommande.Items.Add(lvi3)
			
			CalculTotal()
			
			CmbVienn.SelectedIndex=-1
			CmbVienn1.SelectedIndex=-1
			CmbVienn2.SelectedIndex=-1
			CmbVienn3.SelectedIndex=-1
			
			CmbVienn1.visible=false
			CmbVienn2.visible=false
			CmbVienn3.visible=false
			
		End If
	End Sub
	
	Sub BtnPrintClick(sender As Object, e As EventArgs)
		Dim Societe As String = txtSociete.Text
		Dim Nom As String = txtNom.Text
		Dim Tel As String = txtTel.Text
		Dim Adress As String = txtAdress.Text
		Dim Produit as New ArrayList
		Dim Prix as New ArrayList
		
		For i=0 To lstCommande.Items.Count - 1
			Produit.Add(lstCommande.Items(i).text)
			Prix.Add(lstCommande.Items(i).subitems(1).text)
		Next
		
		PrintTicket(Societe, Nom, Tel, Adress, Produit, Prix)
	End Sub
End Class
