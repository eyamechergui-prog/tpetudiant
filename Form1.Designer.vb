<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
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
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
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
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
