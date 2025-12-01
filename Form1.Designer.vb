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
