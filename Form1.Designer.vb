<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
>>>>>>> ff5b1137935d12eccbd5c555e0c875828ea02b2f
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
<<<<<<< HEAD
        Btn_showMsg = New Button()
        SuspendLayout()
        ' 
        ' Btn_showMsg
        ' 
        Btn_showMsg.BackColor = Color.Lime
        Btn_showMsg.Location = New Point(309, 104)
        Btn_showMsg.Name = "Btn_showMsg"
        Btn_showMsg.Size = New Size(137, 65)
        Btn_showMsg.TabIndex = 0
        Btn_showMsg.Text = "Click Me"
        Btn_showMsg.UseVisualStyleBackColor = False
=======
<<<<<<< HEAD
        Label1 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        Label3 = New Label()
        lstBoisson = New ListBox()
        lblAfficher = New Label()
        Button1 = New Button()
        Button2 = New Button()
        grsupplement = New GroupBox()
        grsupplement.SuspendLayout()
=======
        components = New ComponentModel.Container()
        Label1 = New Label()
        btnajouter = New Button()
        GroupBox1 = New GroupBox()
        textp = New NumericUpDown()
        timeArrive = New DateTimePicker()
        timeDepart = New DateTimePicker()
        lstvilledepart = New ComboBox()
        lstarrivé = New ComboBox()
        lstligne = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        label = New Label()
        grtype = New GroupBox()
        rdnocturne = New RadioButton()
        rdregulier = New RadioButton()
        rdexpress = New RadioButton()
        groptions = New GroupBox()
        chketage = New CheckBox()
        chkwifi = New CheckBox()
        chkclimatisation = New CheckBox()
        DataGridView1 = New DataGridView()
        ligne = New DataGridViewTextBoxColumn()
        départ = New DataGridViewTextBoxColumn()
        arrivé = New DataGridViewTextBoxColumn()
        heure_départ = New DataGridViewTextBoxColumn()
        heure_arrivée = New DataGridViewTextBoxColumn()
        places = New DataGridViewTextBoxColumn()
        options = New DataGridViewTextBoxColumn()
        type = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(textp, ComponentModel.ISupportInitialize).BeginInit()
        grtype.SuspendLayout()
        groptions.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
<<<<<<< HEAD
        Label1.Location = New Point(37, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 20)
        Label1.TabIndex = 0
        Label1.Text = "choix du plat"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(47, 75)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(65, 24)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "pizza"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(47, 186)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(66, 24)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "pates"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(47, 123)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(74, 24)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "Burger"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(35, 46)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(88, 24)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "fromage"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(35, 106)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(80, 24)
        CheckBox2.TabIndex = 6
        CheckBox2.Text = "Dessert"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(35, 76)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(71, 24)
        CheckBox3.TabIndex = 7
        CheckBox3.Text = "Frittes"
        CheckBox3.UseVisualStyleBackColor = True
=======
        Label1.Location = New Point(346, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 20)
        Label1.TabIndex = 0
        Label1.Text = "Gestion des horaires de bus"
        ' 
        ' btnajouter
        ' 
        btnajouter.Location = New Point(397, 38)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(140, 78)
        btnajouter.TabIndex = 2
        btnajouter.Text = "Ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(textp)
        GroupBox1.Controls.Add(timeArrive)
        GroupBox1.Controls.Add(timeDepart)
        GroupBox1.Controls.Add(lstvilledepart)
        GroupBox1.Controls.Add(lstarrivé)
        GroupBox1.Controls.Add(lstligne)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(label)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(347, 359)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "information de trajet"
        ' 
        ' textp
        ' 
        textp.Location = New Point(130, 320)
        textp.Name = "textp"
        textp.Size = New Size(150, 27)
        textp.TabIndex = 15
        ' 
        ' timeArrive
        ' 
        timeArrive.Format = DateTimePickerFormat.Time
        timeArrive.Location = New Point(144, 266)
        timeArrive.Name = "timeArrive"
        timeArrive.Size = New Size(199, 27)
        timeArrive.TabIndex = 14
        ' 
        ' timeDepart
        ' 
        timeDepart.Format = DateTimePickerFormat.Time
        timeDepart.Location = New Point(93, 211)
        timeDepart.Name = "timeDepart"
        timeDepart.Size = New Size(250, 27)
        timeDepart.TabIndex = 6
        ' 
        ' lstvilledepart
        ' 
        lstvilledepart.FormattingEnabled = True
        lstvilledepart.Items.AddRange(New Object() {"bizerte", "Menzel jemil", "Menzel abderahmen"})
        lstvilledepart.Location = New Point(99, 108)
        lstvilledepart.Name = "lstvilledepart"
        lstvilledepart.Size = New Size(151, 28)
        lstvilledepart.TabIndex = 13
        ' 
        ' lstarrivé
        ' 
        lstarrivé.FormattingEnabled = True
        lstarrivé.Items.AddRange(New Object() {"bizerte", "Menzel jemil", "menzel abderahmen"})
        lstarrivé.Location = New Point(134, 145)
        lstarrivé.Name = "lstarrivé"
        lstarrivé.Size = New Size(151, 28)
        lstarrivé.TabIndex = 12
        ' 
        ' lstligne
        ' 
        lstligne.FormattingEnabled = True
        lstligne.Items.AddRange(New Object() {"ligne 1", "ligne 2", "ligne 3"})
        lstligne.Location = New Point(99, 57)
        lstligne.Name = "lstligne"
        lstligne.Size = New Size(151, 28)
        lstligne.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(29, 271)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 5
        Label7.Text = "heure d'arrivé"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(0, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 20)
        Label6.TabIndex = 4
        Label6.Text = "heure depart"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 3
        Label5.Text = "places"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 2
        Label4.Text = "ville depart"
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
<<<<<<< HEAD
        Label3.Location = New Point(395, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 8
        Label3.Text = "Boisson"
        ' 
        ' lstBoisson
        ' 
        lstBoisson.FormattingEnabled = True
        lstBoisson.Location = New Point(489, 31)
        lstBoisson.Name = "lstBoisson"
        lstBoisson.SelectionMode = SelectionMode.MultiSimple
        lstBoisson.Size = New Size(150, 104)
        lstBoisson.TabIndex = 9
        ' 
        ' lblAfficher
        ' 
        lblAfficher.AutoSize = True
        lblAfficher.ForeColor = Color.Red
        lblAfficher.Location = New Point(402, 174)
        lblAfficher.Name = "lblAfficher"
        lblAfficher.Size = New Size(55, 20)
        lblAfficher.TabIndex = 10
        lblAfficher.Text = "facture"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(416, 302)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "commander"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(636, 302)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' grsupplement
        ' 
        grsupplement.Controls.Add(CheckBox1)
        grsupplement.Controls.Add(CheckBox3)
        grsupplement.Controls.Add(CheckBox2)
        grsupplement.Location = New Point(37, 236)
        grsupplement.Name = "grsupplement"
        grsupplement.Size = New Size(250, 202)
        grsupplement.TabIndex = 13
        grsupplement.TabStop = False
        grsupplement.Text = "supplement"
=======
        Label3.Location = New Point(29, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 1
        Label3.Text = "ville d'arrivé"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(29, 65)
        label.Name = "label"
        label.Size = New Size(42, 20)
        label.TabIndex = 0
        label.Text = "ligne"
        ' 
        ' grtype
        ' 
        grtype.Controls.Add(rdnocturne)
        grtype.Controls.Add(rdregulier)
        grtype.Controls.Add(rdexpress)
        grtype.Location = New Point(525, 143)
        grtype.Name = "grtype"
        grtype.Size = New Size(250, 125)
        grtype.TabIndex = 5
        grtype.TabStop = False
        grtype.Text = "type de trajet"
        ' 
        ' rdnocturne
        ' 
        rdnocturne.AutoSize = True
        rdnocturne.Location = New Point(21, 80)
        rdnocturne.Name = "rdnocturne"
        rdnocturne.Size = New Size(88, 24)
        rdnocturne.TabIndex = 2
        rdnocturne.TabStop = True
        rdnocturne.Text = "nocturne"
        rdnocturne.UseVisualStyleBackColor = True
        ' 
        ' rdregulier
        ' 
        rdregulier.AutoSize = True
        rdregulier.Location = New Point(26, 26)
        rdregulier.Name = "rdregulier"
        rdregulier.Size = New Size(81, 24)
        rdregulier.TabIndex = 1
        rdregulier.TabStop = True
        rdregulier.Text = "régulier"
        rdregulier.UseVisualStyleBackColor = True
        ' 
        ' rdexpress
        ' 
        rdexpress.AutoSize = True
        rdexpress.Location = New Point(26, 50)
        rdexpress.Name = "rdexpress"
        rdexpress.Size = New Size(79, 24)
        rdexpress.TabIndex = 0
        rdexpress.TabStop = True
        rdexpress.Text = "express"
        rdexpress.UseVisualStyleBackColor = True
        ' 
        ' groptions
        ' 
        groptions.Controls.Add(chketage)
        groptions.Controls.Add(chkwifi)
        groptions.Controls.Add(chkclimatisation)
        groptions.Location = New Point(570, 12)
        groptions.Name = "groptions"
        groptions.Size = New Size(250, 125)
        groptions.TabIndex = 5
        groptions.TabStop = False
        groptions.Text = "option"
        ' 
        ' chketage
        ' 
        chketage.AutoSize = True
        chketage.Location = New Point(42, 93)
        chketage.Name = "chketage"
        chketage.Size = New Size(108, 24)
        chketage.TabIndex = 2
        chketage.Text = "bus à étage"
        chketage.UseVisualStyleBackColor = True
        ' 
        ' chkwifi
        ' 
        chkwifi.AutoSize = True
        chkwifi.Location = New Point(26, 56)
        chkwifi.Name = "chkwifi"
        chkwifi.Size = New Size(55, 24)
        chkwifi.TabIndex = 1
        chkwifi.Text = "wifi"
        chkwifi.UseVisualStyleBackColor = True
        ' 
        ' chkclimatisation
        ' 
        chkclimatisation.AutoSize = True
        chkclimatisation.Location = New Point(34, 26)
        chkclimatisation.Name = "chkclimatisation"
        chkclimatisation.Size = New Size(116, 24)
        chkclimatisation.TabIndex = 0
        chkclimatisation.Text = "climatisation"
        chkclimatisation.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ligne, départ, arrivé, heure_départ, heure_arrivée, places, options, type})
        DataGridView1.Location = New Point(365, 334)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1004, 287)
        DataGridView1.TabIndex = 7
        ' 
        ' ligne
        ' 
        ligne.HeaderText = "ligne"
        ligne.MinimumWidth = 6
        ligne.Name = "ligne"
        ligne.Width = 125
        ' 
        ' départ
        ' 
        départ.HeaderText = "départ"
        départ.MinimumWidth = 6
        départ.Name = "départ"
        départ.Width = 125
        ' 
        ' arrivé
        ' 
        arrivé.HeaderText = "arrivé"
        arrivé.MinimumWidth = 6
        arrivé.Name = "arrivé"
        arrivé.Width = 125
        ' 
        ' heure_départ
        ' 
        heure_départ.HeaderText = "heure_départ"
        heure_départ.MinimumWidth = 6
        heure_départ.Name = "heure_départ"
        heure_départ.Width = 125
        ' 
        ' heure_arrivée
        ' 
        heure_arrivée.HeaderText = "heure_arrivée"
        heure_arrivée.MinimumWidth = 6
        heure_arrivée.Name = "heure_arrivée"
        heure_arrivée.Width = 125
        ' 
        ' places
        ' 
        places.HeaderText = "places"
        places.MinimumWidth = 6
        places.Name = "places"
        places.Width = 125
        ' 
        ' options
        ' 
        options.HeaderText = "options"
        options.MinimumWidth = 6
        options.Name = "options"
        options.Width = 125
        ' 
        ' type
        ' 
        type.HeaderText = "type"
        type.MinimumWidth = 6
        type.Name = "type"
        type.Width = 125
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
>>>>>>> ff5b1137935d12eccbd5c555e0c875828ea02b2f
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
<<<<<<< HEAD
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_showMsg)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_showMsg As Button

End Class
=======
<<<<<<< HEAD
        ClientSize = New Size(800, 450)
        Controls.Add(grsupplement)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblAfficher)
        Controls.Add(lstBoisson)
        Controls.Add(Label3)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        grsupplement.ResumeLayout(False)
        grsupplement.PerformLayout()
=======
        ClientSize = New Size(1353, 513)
        Controls.Add(DataGridView1)
        Controls.Add(grtype)
        Controls.Add(groptions)
        Controls.Add(GroupBox1)
        Controls.Add(btnajouter)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(textp, ComponentModel.ISupportInitialize).EndInit()
        grtype.ResumeLayout(False)
        grtype.PerformLayout()
        groptions.ResumeLayout(False)
        groptions.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
<<<<<<< HEAD
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstBoisson As ListBox
    Friend WithEvents lblAfficher As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grsupplement As GroupBox

End Class
=======
    Friend WithEvents btnajouter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents grtype As GroupBox
    Friend WithEvents groptions As GroupBox
    Friend WithEvents timeDepart As DateTimePicker
    Friend WithEvents timeArrive As DateTimePicker
    Friend WithEvents lstvilledepart As ComboBox
    Friend WithEvents lstarrivé As ComboBox
    Friend WithEvents lstligne As ComboBox
    Friend WithEvents rdnocturne As RadioButton
    Friend WithEvents rdregulier As RadioButton
    Friend WithEvents rdexpress As RadioButton
    Friend WithEvents chketage As CheckBox
    Friend WithEvents chkwifi As CheckBox
    Friend WithEvents chkclimatisation As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents textp As NumericUpDown
    Friend WithEvents ligne As DataGridViewTextBoxColumn
    Friend WithEvents départ As DataGridViewTextBoxColumn
    Friend WithEvents arrivé As DataGridViewTextBoxColumn
    Friend WithEvents heure_départ As DataGridViewTextBoxColumn
    Friend WithEvents heure_arrivée As DataGridViewTextBoxColumn
    Friend WithEvents places As DataGridViewTextBoxColumn
    Friend WithEvents options As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        grvetement = New GroupBox()
        rdpantallon = New RadioButton()
        rdrobe = New RadioButton()
        rdchemise = New RadioButton()
        chkdefroissage = New CheckBox()
        chkantitache = New CheckBox()
        grnettoyage = New GroupBox()
        rdlavage = New RadioButton()
        rdreppassage = New RadioButton()
        rdsc = New RadioButton()
        grsupplement = New GroupBox()
        DataGridView1 = New DataGridView()
        vetement = New DataGridViewTextBoxColumn()
        type_nettoyage = New DataGridViewTextBoxColumn()
        supplement = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        textnb = New NumericUpDown()
        Label1 = New Label()
        btnajouter = New Button()
        btnannuler = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        code = New DataGridViewTextBoxColumn()
        grvetement.SuspendLayout()
        grnettoyage.SuspendLayout()
        grsupplement.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(textnb, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grvetement
        ' 
        grvetement.AccessibleName = "grvetement"
        grvetement.Controls.Add(rdpantallon)
        grvetement.Controls.Add(rdrobe)
        grvetement.Controls.Add(rdchemise)
        grvetement.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grvetement.Location = New Point(289, 12)
        grvetement.Name = "grvetement"
        grvetement.Size = New Size(178, 235)
        grvetement.TabIndex = 0
        grvetement.TabStop = False
        grvetement.Text = "choix vetement"
        ' 
        ' rdpantallon
        ' 
        rdpantallon.AutoSize = True
        rdpantallon.Location = New Point(6, 41)
        rdpantallon.Name = "rdpantallon"
        rdpantallon.Size = New Size(92, 24)
        rdpantallon.TabIndex = 1
        rdpantallon.TabStop = True
        rdpantallon.Text = "pantalon"
        rdpantallon.UseVisualStyleBackColor = True
        ' 
        ' rdrobe
        ' 
        rdrobe.AutoSize = True
        rdrobe.Location = New Point(0, 81)
        rdrobe.Name = "rdrobe"
        rdrobe.Size = New Size(62, 24)
        rdrobe.TabIndex = 3
        rdrobe.TabStop = True
        rdrobe.Text = "robe"
        rdrobe.UseVisualStyleBackColor = True
        ' 
        ' rdchemise
        ' 
        rdchemise.AutoSize = True
        rdchemise.Location = New Point(0, 133)
        rdchemise.Name = "rdchemise"
        rdchemise.Size = New Size(87, 24)
        rdchemise.TabIndex = 4
        rdchemise.TabStop = True
        rdchemise.Text = "chemise"
        rdchemise.UseVisualStyleBackColor = True
        ' 
        ' chkdefroissage
        ' 
        chkdefroissage.AutoSize = True
        chkdefroissage.Location = New Point(51, 42)
        chkdefroissage.Name = "chkdefroissage"
        chkdefroissage.Size = New Size(112, 24)
        chkdefroissage.TabIndex = 6
        chkdefroissage.Text = "défroissage"
        chkdefroissage.UseVisualStyleBackColor = True
        ' 
        ' chkantitache
        ' 
        chkantitache.AutoSize = True
        chkantitache.Location = New Point(62, 72)
        chkantitache.Name = "chkantitache"
        chkantitache.Size = New Size(100, 24)
        chkantitache.TabIndex = 7
        chkantitache.Text = "anti tache"
        chkantitache.UseVisualStyleBackColor = True
        ' 
        ' grnettoyage
        ' 
        grnettoyage.AccessibleName = "grtype"
        grnettoyage.Controls.Add(rdlavage)
        grnettoyage.Controls.Add(rdreppassage)
        grnettoyage.Controls.Add(rdsc)
        grnettoyage.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grnettoyage.Location = New Point(12, 54)
        grnettoyage.Name = "grnettoyage"
        grnettoyage.Size = New Size(249, 193)
        grnettoyage.TabIndex = 8
        grnettoyage.TabStop = False
        grnettoyage.Text = "type nettoyage"
        ' 
        ' rdlavage
        ' 
        rdlavage.AutoSize = True
        rdlavage.Location = New Point(14, 77)
        rdlavage.Name = "rdlavage"
        rdlavage.Size = New Size(75, 24)
        rdlavage.TabIndex = 2
        rdlavage.TabStop = True
        rdlavage.Text = "lavage"
        rdlavage.UseVisualStyleBackColor = True
        ' 
        ' rdreppassage
        ' 
        rdreppassage.AutoSize = True
        rdreppassage.Location = New Point(26, 127)
        rdreppassage.Name = "rdreppassage"
        rdreppassage.Size = New Size(109, 24)
        rdreppassage.TabIndex = 1
        rdreppassage.TabStop = True
        rdreppassage.Text = "reppassage"
        rdreppassage.UseVisualStyleBackColor = True
        ' 
        ' rdsc
        ' 
        rdsc.AccessibleName = ""
        rdsc.AutoSize = True
        rdsc.Location = New Point(14, 47)
        rdsc.Name = "rdsc"
        rdsc.Size = New Size(126, 24)
        rdsc.TabIndex = 0
        rdsc.TabStop = True
        rdsc.Text = "nettayage sec"
        rdsc.UseVisualStyleBackColor = True
        ' 
        ' grsupplement
        ' 
        grsupplement.Controls.Add(chkdefroissage)
        grsupplement.Controls.Add(chkantitache)
        grsupplement.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grsupplement.Location = New Point(49, 279)
        grsupplement.Name = "grsupplement"
        grsupplement.Size = New Size(250, 125)
        grsupplement.TabIndex = 9
        grsupplement.TabStop = False
        grsupplement.Text = "supplement"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {vetement, type_nettoyage, supplement, nombre, code})
        DataGridView1.Location = New Point(396, 253)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(660, 188)
        DataGridView1.TabIndex = 10
        ' 
        ' vetement
        ' 
        vetement.HeaderText = "vetement"
        vetement.MinimumWidth = 6
        vetement.Name = "vetement"
        vetement.Width = 125
        ' 
        ' type_nettoyage
        ' 
        type_nettoyage.HeaderText = "type_nettoyage"
        type_nettoyage.MinimumWidth = 6
        type_nettoyage.Name = "type_nettoyage"
        type_nettoyage.Width = 125
        ' 
        ' supplement
        ' 
        supplement.HeaderText = "supplement"
        supplement.MinimumWidth = 6
        supplement.Name = "supplement"
        supplement.Width = 125
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "nombre"
        nombre.MinimumWidth = 6
        nombre.Name = "nombre"
        nombre.Width = 125
        ' 
        ' textnb
        ' 
        textnb.Location = New Point(731, 154)
        textnb.Name = "textnb"
        textnb.Size = New Size(150, 27)
        textnb.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(573, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 23)
        Label1.TabIndex = 12
        Label1.Text = "nombre d'article"
        ' 
        ' btnajouter
        ' 
        btnajouter.ForeColor = Color.Red
        btnajouter.Location = New Point(597, 88)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(94, 29)
        btnajouter.TabIndex = 13
        btnajouter.Text = "Ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' btnannuler
        ' 
        btnannuler.ForeColor = Color.Red
        btnannuler.Location = New Point(787, 88)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 14
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' code
        ' 
        code.HeaderText = "code"
        code.MinimumWidth = 6
        code.Name = "code"
        code.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1068, 505)
        Controls.Add(btnannuler)
        Controls.Add(btnajouter)
        Controls.Add(Label1)
        Controls.Add(textnb)
        Controls.Add(DataGridView1)
        Controls.Add(grsupplement)
        Controls.Add(grnettoyage)
        Controls.Add(grvetement)
        Name = "Form1"
        Text = "Form1"
        grvetement.ResumeLayout(False)
        grvetement.PerformLayout()
        grnettoyage.ResumeLayout(False)
        grnettoyage.PerformLayout()
        grsupplement.ResumeLayout(False)
        grsupplement.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(textnb, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grvetement As GroupBox
    Friend WithEvents rdpantallon As RadioButton
    Friend WithEvents rdrobe As RadioButton
    Friend WithEvents rdchemise As RadioButton
    Friend WithEvents chkdefroissage As CheckBox
    Friend WithEvents chkantitache As CheckBox
    Friend WithEvents grnettoyage As GroupBox
    Friend WithEvents rdlavage As RadioButton
    Friend WithEvents rdreppassage As RadioButton
    Friend WithEvents rdsc As RadioButton
    Friend WithEvents grsupplement As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents textnb As NumericUpDown
    Friend WithEvents vetement As DataGridViewTextBoxColumn
    Friend WithEvents type_nettoyage As DataGridViewTextBoxColumn
    Friend WithEvents supplement As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnajouter As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents code As DataGridViewTextBoxColumn

End Class
>>>>>>> 5fbaeccb7234b4a6fd13a3809525ea4dc4d095b7
>>>>>>> 57946feff5fac43c88c4370cb0105310d9fe5c99
>>>>>>> ff5b1137935d12eccbd5c555e0c875828ea02b2f
