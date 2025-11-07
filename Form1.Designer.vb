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
        Textnom = New TextBox()
        Textnote = New TextBox()
        btnannuler = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Textprenom = New TextBox()
        btnafficher = New Button()
        DataGridView1 = New DataGridView()
        nom = New DataGridViewTextBoxColumn()
        prenom = New DataGridViewTextBoxColumn()
        note = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        Btnmoy = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(136, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 0
        Label1.Text = "nom"
        ' 
        ' btnajouter
        ' 
        btnajouter.Location = New Point(111, 202)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(94, 29)
        btnajouter.TabIndex = 1
        btnajouter.Text = "ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' Textnom
        ' 
        Textnom.Location = New Point(229, 56)
        Textnom.Name = "Textnom"
        Textnom.Size = New Size(125, 27)
        Textnom.TabIndex = 2
        ' 
        ' Textnote
        ' 
        Textnote.Location = New Point(229, 113)
        Textnote.Name = "Textnote"
        Textnote.Size = New Size(125, 27)
        Textnote.TabIndex = 3
        ' 
        ' btnannuler
        ' 
        btnannuler.Location = New Point(81, 292)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 4
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(136, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 5
        Label2.Text = "note"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(141, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 6
        Label3.Text = "prénom"
        ' 
        ' Textprenom
        ' 
        Textprenom.Location = New Point(272, 158)
        Textprenom.Name = "Textprenom"
        Textprenom.Size = New Size(125, 27)
        Textprenom.TabIndex = 7
        ' 
        ' btnafficher
        ' 
        btnafficher.Location = New Point(111, 257)
        btnafficher.Name = "btnafficher"
        btnafficher.Size = New Size(94, 29)
        btnafficher.TabIndex = 8
        btnafficher.Text = "afficher"
        btnafficher.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nom, prenom, note})
        DataGridView1.Location = New Point(300, 231)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(471, 188)
        DataGridView1.TabIndex = 9
        ' 
        ' nom
        ' 
        nom.HeaderText = "Nom"
        nom.MinimumWidth = 6
        nom.Name = "nom"
        nom.Width = 125
        ' 
        ' prenom
        ' 
        prenom.HeaderText = "Prenom"
        prenom.MinimumWidth = 6
        prenom.Name = "prenom"
        prenom.Width = 125
        ' 
        ' note
        ' 
        note.HeaderText = "Note"
        note.MinimumWidth = 6
        note.Name = "note"
        note.Width = 125
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Btnmoy
        ' 
        Btnmoy.Location = New Point(70, 386)
        Btnmoy.Name = "Btnmoy"
        Btnmoy.Size = New Size(94, 29)
        Btnmoy.TabIndex = 10
        Btnmoy.Text = "moyenne"
        Btnmoy.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btnmoy)
        Controls.Add(DataGridView1)
        Controls.Add(btnafficher)
        Controls.Add(Textprenom)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnannuler)
        Controls.Add(Textnote)
        Controls.Add(Textnom)
        Controls.Add(btnajouter)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnajouter As Button
    Friend WithEvents Textnom As TextBox
    Friend WithEvents Textnote As TextBox
    Friend WithEvents btnannuler As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Textprenom As TextBox
    Friend WithEvents btnafficher As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents note As DataGridViewTextBoxColumn
    Friend WithEvents Btnmoy As Button

End Class
