'
' Crée par SharpDevelop.
' Utilisateur: tom
' Date: 04/05/2010
' Heure: 21:01
' 
' Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label
		Me.label2 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.label4 = New System.Windows.Forms.Label
		Me.label5 = New System.Windows.Forms.Label
		Me.label6 = New System.Windows.Forms.Label
		Me.label7 = New System.Windows.Forms.Label
		Me.txtSociete = New System.Windows.Forms.TextBox
		Me.txtNom = New System.Windows.Forms.TextBox
		Me.txtTel = New System.Windows.Forms.TextBox
		Me.txtAdress = New System.Windows.Forms.TextBox
		Me.textBox6 = New System.Windows.Forms.TextBox
		Me.label9 = New System.Windows.Forms.Label
		Me.label10 = New System.Windows.Forms.Label
		Me.btnPrint = New System.Windows.Forms.Button
		Me.btnSaisie = New System.Windows.Forms.Button
		Me.cmbMenu = New System.Windows.Forms.ComboBox
		Me.cmbProduitMenu = New System.Windows.Forms.ComboBox
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.lblSauce = New System.Windows.Forms.Label
		Me.lblProduit = New System.Windows.Forms.Label
		Me.label12 = New System.Windows.Forms.Label
		Me.label11 = New System.Windows.Forms.Label
		Me.btnValidMenu = New System.Windows.Forms.Button
		Me.cmbDessertMenu = New System.Windows.Forms.ComboBox
		Me.cmbBoissonMenu = New System.Windows.Forms.ComboBox
		Me.cmbSauceMenu = New System.Windows.Forms.ComboBox
		Me.groupBox2 = New System.Windows.Forms.GroupBox
		Me.cmbVienn1 = New System.Windows.Forms.ComboBox
		Me.cmbVienn3 = New System.Windows.Forms.ComboBox
		Me.cmbVienn2 = New System.Windows.Forms.ComboBox
		Me.label19 = New System.Windows.Forms.Label
		Me.label18 = New System.Windows.Forms.Label
		Me.label17 = New System.Windows.Forms.Label
		Me.label16 = New System.Windows.Forms.Label
		Me.label15 = New System.Windows.Forms.Label
		Me.label14 = New System.Windows.Forms.Label
		Me.label13 = New System.Windows.Forms.Label
		Me.lblSandwich = New System.Windows.Forms.Label
		Me.cmbBoisson = New System.Windows.Forms.ComboBox
		Me.cmbVienn = New System.Windows.Forms.ComboBox
		Me.cmbDessert = New System.Windows.Forms.ComboBox
		Me.cmbPlat = New System.Windows.Forms.ComboBox
		Me.cmbTarte = New System.Windows.Forms.ComboBox
		Me.cmbSauce = New System.Windows.Forms.ComboBox
		Me.cmbSalade = New System.Windows.Forms.ComboBox
		Me.cmbSandwich = New System.Windows.Forms.ComboBox
		Me.btnEnleve = New System.Windows.Forms.Button
		Me.btnEffaceTout = New System.Windows.Forms.Button
		Me.label8 = New System.Windows.Forms.Label
		Me.txtTotal = New System.Windows.Forms.TextBox
		Me.lstCommande = New System.Windows.Forms.ListView
		Me.colProduit = New System.Windows.Forms.ColumnHeader
		Me.colPrix = New System.Windows.Forms.ColumnHeader
		Me.cmpPaiement = New System.Windows.Forms.ComboBox
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(15, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 25)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Société"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(15, 34)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(117, 25)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Nom"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(15, 62)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(117, 25)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Téléphone"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(15, 90)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(117, 25)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Adresse complète"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(15, 198)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(135, 23)
		Me.label5.TabIndex = 4
		Me.label5.Text = "Détail de la commande"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(15, 507)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(117, 25)
		Me.label6.TabIndex = 5
		Me.label6.Text = "Heure de livraison"
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(15, 536)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(117, 25)
		Me.label7.TabIndex = 6
		Me.label7.Text = "Paiement"
		'
		'txtSociete
		'
		Me.txtSociete.Location = New System.Drawing.Point(138, 6)
		Me.txtSociete.Name = "txtSociete"
		Me.txtSociete.Size = New System.Drawing.Size(116, 20)
		Me.txtSociete.TabIndex = 0
		'
		'txtNom
		'
		Me.txtNom.Location = New System.Drawing.Point(138, 34)
		Me.txtNom.Name = "txtNom"
		Me.txtNom.Size = New System.Drawing.Size(116, 20)
		Me.txtNom.TabIndex = 1
		'
		'txtTel
		'
		Me.txtTel.Location = New System.Drawing.Point(139, 62)
		Me.txtTel.Name = "txtTel"
		Me.txtTel.Size = New System.Drawing.Size(116, 20)
		Me.txtTel.TabIndex = 2
		'
		'txtAdress
		'
		Me.txtAdress.Location = New System.Drawing.Point(139, 90)
		Me.txtAdress.Multiline = true
		Me.txtAdress.Name = "txtAdress"
		Me.txtAdress.Size = New System.Drawing.Size(171, 92)
		Me.txtAdress.TabIndex = 3
		'
		'textBox6
		'
		Me.textBox6.Location = New System.Drawing.Point(138, 507)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(116, 20)
		Me.textBox6.TabIndex = 5
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(15, 115)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(117, 25)
		Me.label9.TabIndex = 15
		Me.label9.Text = "Etage"
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(15, 140)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(117, 25)
		Me.label10.TabIndex = 16
		Me.label10.Text = "Code"
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(139, 580)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(117, 39)
		Me.btnPrint.TabIndex = 7
		Me.btnPrint.Text = "Imprimer"
		Me.btnPrint.UseVisualStyleBackColor = true
		AddHandler Me.btnPrint.Click, AddressOf Me.BtnPrintClick
		'
		'btnSaisie
		'
		Me.btnSaisie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSaisie.Location = New System.Drawing.Point(316, 224)
		Me.btnSaisie.Name = "btnSaisie"
		Me.btnSaisie.Size = New System.Drawing.Size(43, 166)
		Me.btnSaisie.TabIndex = 17
		Me.btnSaisie.Text = ">>>>>>>>>>"
		Me.btnSaisie.UseVisualStyleBackColor = true
		AddHandler Me.btnSaisie.Click, AddressOf Me.BtnSaisieClick
		'
		'cmbMenu
		'
		Me.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMenu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbMenu.FormattingEnabled = true
		Me.cmbMenu.Items.AddRange(New Object() {"Sandwich 7.50€", "Salade 8.50€", "Tarte salée 7.50€", "Plat chaud 9.50€"})
		Me.cmbMenu.Location = New System.Drawing.Point(6, 13)
		Me.cmbMenu.Name = "cmbMenu"
		Me.cmbMenu.Size = New System.Drawing.Size(265, 22)
		Me.cmbMenu.TabIndex = 18
		AddHandler Me.cmbMenu.SelectedIndexChanged, AddressOf Me.CmbMenuSelectedIndexChanged
		'
		'cmbProduitMenu
		'
		Me.cmbProduitMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbProduitMenu.FormattingEnabled = true
		Me.cmbProduitMenu.Location = New System.Drawing.Point(6, 65)
		Me.cmbProduitMenu.Name = "cmbProduitMenu"
		Me.cmbProduitMenu.Size = New System.Drawing.Size(265, 22)
		Me.cmbProduitMenu.TabIndex = 19
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.lblSauce)
		Me.groupBox1.Controls.Add(Me.lblProduit)
		Me.groupBox1.Controls.Add(Me.label12)
		Me.groupBox1.Controls.Add(Me.label11)
		Me.groupBox1.Controls.Add(Me.btnValidMenu)
		Me.groupBox1.Controls.Add(Me.cmbDessertMenu)
		Me.groupBox1.Controls.Add(Me.cmbBoissonMenu)
		Me.groupBox1.Controls.Add(Me.cmbMenu)
		Me.groupBox1.Controls.Add(Me.cmbProduitMenu)
		Me.groupBox1.Controls.Add(Me.cmbSauceMenu)
		Me.groupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.Location = New System.Drawing.Point(368, 2)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(280, 219)
		Me.groupBox1.TabIndex = 20
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "MENU"
		'
		'lblSauce
		'
		Me.lblSauce.Location = New System.Drawing.Point(198, 45)
		Me.lblSauce.Name = "lblSauce"
		Me.lblSauce.Size = New System.Drawing.Size(75, 17)
		Me.lblSauce.TabIndex = 27
		Me.lblSauce.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'lblProduit
		'
		Me.lblProduit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblProduit.Location = New System.Drawing.Point(7, 45)
		Me.lblProduit.Name = "lblProduit"
		Me.lblProduit.Size = New System.Drawing.Size(117, 17)
		Me.lblProduit.TabIndex = 26
		Me.lblProduit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label12
		'
		Me.label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label12.Location = New System.Drawing.Point(6, 90)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(117, 17)
		Me.label12.TabIndex = 25
		Me.label12.Text = "Boisson"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label11
		'
		Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.Location = New System.Drawing.Point(7, 135)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(117, 15)
		Me.label11.TabIndex = 24
		Me.label11.Text = "Dessert"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'btnValidMenu
		'
		Me.btnValidMenu.Location = New System.Drawing.Point(87, 181)
		Me.btnValidMenu.Name = "btnValidMenu"
		Me.btnValidMenu.Size = New System.Drawing.Size(104, 28)
		Me.btnValidMenu.TabIndex = 23
		Me.btnValidMenu.Text = "Valider ce menu"
		Me.btnValidMenu.UseVisualStyleBackColor = true
		AddHandler Me.btnValidMenu.Click, AddressOf Me.BtnValidMenuClick
		'
		'cmbDessertMenu
		'
		Me.cmbDessertMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDessertMenu.FormattingEnabled = true
		Me.cmbDessertMenu.Location = New System.Drawing.Point(6, 153)
		Me.cmbDessertMenu.Name = "cmbDessertMenu"
		Me.cmbDessertMenu.Size = New System.Drawing.Size(265, 22)
		Me.cmbDessertMenu.TabIndex = 21
		'
		'cmbBoissonMenu
		'
		Me.cmbBoissonMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbBoissonMenu.FormattingEnabled = true
		Me.cmbBoissonMenu.Location = New System.Drawing.Point(6, 110)
		Me.cmbBoissonMenu.Name = "cmbBoissonMenu"
		Me.cmbBoissonMenu.Size = New System.Drawing.Size(265, 22)
		Me.cmbBoissonMenu.TabIndex = 20
		'
		'cmbSauceMenu
		'
		Me.cmbSauceMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSauceMenu.FormattingEnabled = true
		Me.cmbSauceMenu.Location = New System.Drawing.Point(197, 65)
		Me.cmbSauceMenu.Name = "cmbSauceMenu"
		Me.cmbSauceMenu.Size = New System.Drawing.Size(74, 22)
		Me.cmbSauceMenu.TabIndex = 22
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.cmbVienn1)
		Me.groupBox2.Controls.Add(Me.cmbVienn3)
		Me.groupBox2.Controls.Add(Me.cmbVienn2)
		Me.groupBox2.Controls.Add(Me.label19)
		Me.groupBox2.Controls.Add(Me.label18)
		Me.groupBox2.Controls.Add(Me.label17)
		Me.groupBox2.Controls.Add(Me.label16)
		Me.groupBox2.Controls.Add(Me.label15)
		Me.groupBox2.Controls.Add(Me.label14)
		Me.groupBox2.Controls.Add(Me.label13)
		Me.groupBox2.Controls.Add(Me.lblSandwich)
		Me.groupBox2.Controls.Add(Me.cmbBoisson)
		Me.groupBox2.Controls.Add(Me.cmbVienn)
		Me.groupBox2.Controls.Add(Me.cmbDessert)
		Me.groupBox2.Controls.Add(Me.cmbPlat)
		Me.groupBox2.Controls.Add(Me.cmbTarte)
		Me.groupBox2.Controls.Add(Me.cmbSauce)
		Me.groupBox2.Controls.Add(Me.cmbSalade)
		Me.groupBox2.Controls.Add(Me.cmbSandwich)
		Me.groupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox2.Location = New System.Drawing.Point(368, 255)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(280, 348)
		Me.groupBox2.TabIndex = 21
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "HORS MENU"
		'
		'cmbVienn1
		'
		Me.cmbVienn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbVienn1.FormattingEnabled = true
		Me.cmbVienn1.Items.AddRange(New Object() {"Croissant", "Pain au chocolat", "Chausson aux pommes", "Pain aux raisins"})
		Me.cmbVienn1.Location = New System.Drawing.Point(6, 319)
		Me.cmbVienn1.Name = "cmbVienn1"
		Me.cmbVienn1.Size = New System.Drawing.Size(90, 22)
		Me.cmbVienn1.TabIndex = 18
		Me.cmbVienn1.Visible = false
		AddHandler Me.cmbVienn1.SelectedIndexChanged, AddressOf Me.CmbVienn1SelectedIndexChanged
		'
		'cmbVienn3
		'
		Me.cmbVienn3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbVienn3.FormattingEnabled = true
		Me.cmbVienn3.Items.AddRange(New Object() {"Croissant", "Pain au chocolat", "Chausson aux pommes", "Pain aux raisins"})
		Me.cmbVienn3.Location = New System.Drawing.Point(190, 319)
		Me.cmbVienn3.Name = "cmbVienn3"
		Me.cmbVienn3.Size = New System.Drawing.Size(90, 22)
		Me.cmbVienn3.TabIndex = 17
		Me.cmbVienn3.Visible = false
		AddHandler Me.cmbVienn3.SelectedIndexChanged, AddressOf Me.CmbVienn3SelectedIndexChanged
		'
		'cmbVienn2
		'
		Me.cmbVienn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbVienn2.FormattingEnabled = true
		Me.cmbVienn2.Items.AddRange(New Object() {"Croissant", "Pain au chocolat", "Chausson aux pommes", "Pain aux raisins"})
		Me.cmbVienn2.Location = New System.Drawing.Point(98, 319)
		Me.cmbVienn2.Name = "cmbVienn2"
		Me.cmbVienn2.Size = New System.Drawing.Size(90, 22)
		Me.cmbVienn2.TabIndex = 16
		Me.cmbVienn2.Visible = false
		AddHandler Me.cmbVienn2.SelectedIndexChanged, AddressOf Me.CmbVienn2SelectedIndexChanged
		'
		'label19
		'
		Me.label19.Location = New System.Drawing.Point(7, 273)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(117, 15)
		Me.label19.TabIndex = 15
		Me.label19.Text = "Viennoiseries"
		'
		'label18
		'
		Me.label18.Location = New System.Drawing.Point(7, 232)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(117, 13)
		Me.label18.TabIndex = 14
		Me.label18.Text = "Boissons"
		Me.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label17
		'
		Me.label17.Location = New System.Drawing.Point(7, 192)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(117, 12)
		Me.label17.TabIndex = 13
		Me.label17.Text = "Desserts"
		Me.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label16
		'
		Me.label16.Location = New System.Drawing.Point(7, 150)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(117, 14)
		Me.label16.TabIndex = 12
		Me.label16.Text = "Plats chauds"
		Me.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label15
		'
		Me.label15.Location = New System.Drawing.Point(7, 108)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(117, 14)
		Me.label15.TabIndex = 11
		Me.label15.Text = "Tartes salées"
		Me.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(198, 66)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(69, 14)
		Me.label14.TabIndex = 10
		Me.label14.Text = "Sauces"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(8, 66)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(117, 14)
		Me.label13.TabIndex = 9
		Me.label13.Text = "Salades"
		Me.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'lblSandwich
		'
		Me.lblSandwich.Location = New System.Drawing.Point(8, 16)
		Me.lblSandwich.Name = "lblSandwich"
		Me.lblSandwich.Size = New System.Drawing.Size(117, 23)
		Me.lblSandwich.TabIndex = 8
		Me.lblSandwich.Text = "Sandwichs"
		Me.lblSandwich.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'cmbBoisson
		'
		Me.cmbBoisson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbBoisson.FormattingEnabled = true
		Me.cmbBoisson.Items.AddRange(New Object() {"Cristaline 50cl 1,50€", "Perrier 33cl 1,70€", "Pampryl Pomme 33cl 1,70€", "Pampryl Orange 33cl 1,70€", "Pampryl Cocktail 33cl 1,70€", "Oasis tea 33cl 1,70€", "Orangina 33cl 1,70€", "Sprite 33cl 1,70€", "Coca-Cola 33cl 1,70€", "Coca light 33cl 1,70€", "Coca-Cola 50cl 2.20€", "Coca zéro 50cl 2.20€", "Oasis Tropical 50cl 2.20€", "Schweppes Agrum' 50cl 2.20€", "1664 33cl 2.20€", "Red-Bull 2.70€", "VitaminWater 2.70€", "Jus d'orange pressé 3.00€"})
		Me.cmbBoisson.Location = New System.Drawing.Point(7, 248)
		Me.cmbBoisson.Name = "cmbBoisson"
		Me.cmbBoisson.Size = New System.Drawing.Size(265, 22)
		Me.cmbBoisson.TabIndex = 7
		AddHandler Me.cmbBoisson.SelectedIndexChanged, AddressOf Me.CmbBoissonSelectedIndexChanged
		'
		'cmbVienn
		'
		Me.cmbVienn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbVienn.FormattingEnabled = true
		Me.cmbVienn.Items.AddRange(New Object() {"3 Viennoiseries au choix 3.00€", "10 mi viennoiseries 4.50€", "10 chouquettes 2.70€"})
		Me.cmbVienn.Location = New System.Drawing.Point(6, 291)
		Me.cmbVienn.Name = "cmbVienn"
		Me.cmbVienn.Size = New System.Drawing.Size(264, 22)
		Me.cmbVienn.TabIndex = 6
		AddHandler Me.cmbVienn.SelectedIndexChanged, AddressOf Me.CmbViennSelectedIndexChanged
		'
		'cmbDessert
		'
		Me.cmbDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDessert.FormattingEnabled = true
		Me.cmbDessert.Items.AddRange(New Object() {"Éclair chocolat 1.90€", "Éclair café 1.90€", "Tartelette poire-amande 2.70€", "Tartelette amandine-cassis 2.70€", "Tartelette citron 2.70€", "Tartelette  chocolat 2.70€", "Tartelette pomme 2.70€", "Tartelette amandine nature 2.70€", "Brownie 2.70€", "Crumble fruits rouges 2.70€", "Moelleux au chocolat 2.70€", "Flan Nature 2.70€", "Clafoutis 2.70€", "Compote 2.70€", "Fromage blanc 2.70€", "Fromage blanc + fruit 2.70€", "Salade de fruit 2.70€", "Fraises 2.70€", "Raisin 1.90€", "Pomme 1.50€", "Orange 1.50€", "Banane 1.50€", "Donut's Nature 1.90€", "Donut's Chocolat 1.90€", "Donut's Fraise 1.90€", "Donut's Vanille 1.90€", "Beignet Chocolat 1.50€", "Beignet Pomme 1.50€", "Beignet Framboise 1.50€", "Cookie 1.50€"})
		Me.cmbDessert.Location = New System.Drawing.Point(7, 207)
		Me.cmbDessert.Name = "cmbDessert"
		Me.cmbDessert.Size = New System.Drawing.Size(264, 22)
		Me.cmbDessert.TabIndex = 5
		AddHandler Me.cmbDessert.SelectedIndexChanged, AddressOf Me.CmbDessertSelectedIndexChanged
		'
		'cmbPlat
		'
		Me.cmbPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPlat.FormattingEnabled = true
		Me.cmbPlat.Items.AddRange(New Object() {"Lasagne bolognaise 6.50€", "Lasagne saumon 6.50€", "Tortellini 6.50€", "Moussaka 6.50€", "Gratin de courgettes 6.50€"})
		Me.cmbPlat.Location = New System.Drawing.Point(7, 167)
		Me.cmbPlat.Name = "cmbPlat"
		Me.cmbPlat.Size = New System.Drawing.Size(264, 22)
		Me.cmbPlat.TabIndex = 4
		AddHandler Me.cmbPlat.SelectedIndexChanged, AddressOf Me.CmbPlatSelectedIndexChanged
		'
		'cmbTarte
		'
		Me.cmbTarte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTarte.FormattingEnabled = true
		Me.cmbTarte.Items.AddRange(New Object() {"Trois Fromages 3.50€", "Lorraine 3.50€", "Poireaux 3.50€", "Saumon 3.50€"})
		Me.cmbTarte.Location = New System.Drawing.Point(7, 125)
		Me.cmbTarte.Name = "cmbTarte"
		Me.cmbTarte.Size = New System.Drawing.Size(264, 22)
		Me.cmbTarte.TabIndex = 3
		AddHandler Me.cmbTarte.SelectedIndexChanged, AddressOf Me.CmbTarteSelectedIndexChanged
		'
		'cmbSauce
		'
		Me.cmbSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSauce.FormattingEnabled = true
		Me.cmbSauce.Items.AddRange(New Object() {"Vinaigrette", "Huile d'olive", "Balsamique"})
		Me.cmbSauce.Location = New System.Drawing.Point(198, 83)
		Me.cmbSauce.Name = "cmbSauce"
		Me.cmbSauce.Size = New System.Drawing.Size(74, 22)
		Me.cmbSauce.TabIndex = 2
		AddHandler Me.cmbSauce.SelectedIndexChanged, AddressOf Me.CmbSauceSelectedIndexChanged
		'
		'cmbSalade
		'
		Me.cmbSalade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSalade.FormattingEnabled = true
		Me.cmbSalade.Items.AddRange(New Object() {"Poulet 5.50€", "Thon 5.50€", "Jambon 5.50€", "Surimi 5.50€", "Mozza 5.50€", "Nature 1.50€"})
		Me.cmbSalade.Location = New System.Drawing.Point(7, 83)
		Me.cmbSalade.Name = "cmbSalade"
		Me.cmbSalade.Size = New System.Drawing.Size(184, 22)
		Me.cmbSalade.TabIndex = 1
		'
		'cmbSandwich
		'
		Me.cmbSandwich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSandwich.FormattingEnabled = true
		Me.cmbSandwich.Items.AddRange(New Object() {"Jambon emmental beurre 4.50€", "Poulet 4.50€", "Jambon emmental crudités 4.50€", "Thon 4.50€", "Chèvre Noix 4.50€", "Végétarien 4.50€", "Mozza 4.50€", "Saumon 4.50€", "", "Suédois Poulet 4.50€", "Suédois Jambon emmental 4.50€", "Suédois Surimi 4.50€", "Suédois Chèvre Noix 4.50€", "Suédois Mozza 4.50€", "Suédois Saumon 4.50€", "", "Mini Rosette 2.50€", "Mini Chèvre Noix 2.50€", "Mini Jambon emmental 2.50€"})
		Me.cmbSandwich.Location = New System.Drawing.Point(8, 41)
		Me.cmbSandwich.Name = "cmbSandwich"
		Me.cmbSandwich.Size = New System.Drawing.Size(264, 22)
		Me.cmbSandwich.TabIndex = 0
		AddHandler Me.cmbSandwich.SelectedIndexChanged, AddressOf Me.CmbSandwichSelectedIndexChanged
		'
		'btnEnleve
		'
		Me.btnEnleve.Location = New System.Drawing.Point(118, 440)
		Me.btnEnleve.Name = "btnEnleve"
		Me.btnEnleve.Size = New System.Drawing.Size(87, 40)
		Me.btnEnleve.TabIndex = 22
		Me.btnEnleve.Text = "Enlever ce produit"
		Me.btnEnleve.UseVisualStyleBackColor = true
		AddHandler Me.btnEnleve.Click, AddressOf Me.BtnEnleveClick
		'
		'btnEffaceTout
		'
		Me.btnEffaceTout.Location = New System.Drawing.Point(218, 440)
		Me.btnEffaceTout.Name = "btnEffaceTout"
		Me.btnEffaceTout.Size = New System.Drawing.Size(87, 40)
		Me.btnEffaceTout.TabIndex = 23
		Me.btnEffaceTout.Text = "Tout effacer"
		Me.btnEffaceTout.UseVisualStyleBackColor = true
		AddHandler Me.btnEffaceTout.Click, AddressOf Me.BtnEffaceToutClick
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(14, 396)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(136, 23)
		Me.label8.TabIndex = 24
		Me.label8.Text = "Total de la commande"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtTotal
		'
		Me.txtTotal.Enabled = false
		Me.txtTotal.Location = New System.Drawing.Point(215, 396)
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.Size = New System.Drawing.Size(95, 20)
		Me.txtTotal.TabIndex = 25
		Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lstCommande
		'
		Me.lstCommande.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProduit, Me.colPrix})
		Me.lstCommande.FullRowSelect = true
		Me.lstCommande.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.lstCommande.Location = New System.Drawing.Point(15, 224)
		Me.lstCommande.MultiSelect = false
		Me.lstCommande.Name = "lstCommande"
		Me.lstCommande.Size = New System.Drawing.Size(295, 166)
		Me.lstCommande.TabIndex = 26
		Me.lstCommande.UseCompatibleStateImageBehavior = false
		Me.lstCommande.View = System.Windows.Forms.View.Details
		'
		'colProduit
		'
		Me.colProduit.Width = 185
		'
		'colPrix
		'
		Me.colPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.colPrix.Width = 82
		'
		'cmpPaiement
		'
		Me.cmpPaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmpPaiement.FormattingEnabled = true
		Me.cmpPaiement.Items.AddRange(New Object() {"Payé à la commande", "Carte bleue", "Ticket restaurant", "Espèces", "Chèque"})
		Me.cmpPaiement.Location = New System.Drawing.Point(138, 533)
		Me.cmpPaiement.Name = "cmpPaiement"
		Me.cmpPaiement.Size = New System.Drawing.Size(121, 22)
		Me.cmpPaiement.TabIndex = 27
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 14!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(649, 740)
		Me.Controls.Add(Me.cmpPaiement)
		Me.Controls.Add(Me.lstCommande)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.btnEffaceTout)
		Me.Controls.Add(Me.btnEnleve)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.btnSaisie)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.textBox6)
		Me.Controls.Add(Me.txtAdress)
		Me.Controls.Add(Me.txtTel)
		Me.Controls.Add(Me.txtNom)
		Me.Controls.Add(Me.txtSociete)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "MainForm"
		Me.Text = "Prise De Commande"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtSociete As System.Windows.Forms.TextBox
	Private txtNom As System.Windows.Forms.TextBox
	Private txtTel As System.Windows.Forms.TextBox
	Private txtAdress As System.Windows.Forms.TextBox
	Private cmpPaiement As System.Windows.Forms.ComboBox
	Private cmbVienn2 As System.Windows.Forms.ComboBox
	Private cmbVienn3 As System.Windows.Forms.ComboBox
	Private cmbVienn1 As System.Windows.Forms.ComboBox
	Private label19 As System.Windows.Forms.Label
	Private cmbVienn As System.Windows.Forms.ComboBox
	Private lblSandwich As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private label18 As System.Windows.Forms.Label
	Private colPrix As System.Windows.Forms.ColumnHeader
	Private colProduit As System.Windows.Forms.ColumnHeader
	Public lstCommande As System.Windows.Forms.ListView
	Private lblSauce As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private lblProduit As System.Windows.Forms.Label
	Private cmbDessertMenu As System.Windows.Forms.ComboBox
	Private cmbBoisson As System.Windows.Forms.ComboBox
	Private txtTotal As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Private btnValidMenu As System.Windows.Forms.Button
	Private btnEffaceTout As System.Windows.Forms.Button
	Private btnEnleve As System.Windows.Forms.Button
	Private cmbDessert As System.Windows.Forms.ComboBox
	Private cmbSalade As System.Windows.Forms.ComboBox
	Private cmbSauce As System.Windows.Forms.ComboBox
	Private cmbTarte As System.Windows.Forms.ComboBox
	Private cmbPlat As System.Windows.Forms.ComboBox
	Private cmbSauceMenu As System.Windows.Forms.ComboBox
	Private cmbSandwich As System.Windows.Forms.ComboBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private cmbBoissonMenu As System.Windows.Forms.ComboBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private cmbProduitMenu As System.Windows.Forms.ComboBox
	Private cmbMenu As System.Windows.Forms.ComboBox
	Private btnSaisie As System.Windows.Forms.Button
	Private btnPrint As System.Windows.Forms.Button
	Private label10 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private textBox6 As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	

	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		ClosePrinter()	
	End Sub
	
	
End Class
