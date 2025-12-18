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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
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
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
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
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
