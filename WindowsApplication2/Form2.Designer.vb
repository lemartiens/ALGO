<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_fermer = New System.Windows.Forms.Button()
        Me.lbl_L = New System.Windows.Forms.TextBox()
        Me.lbl_rmin = New System.Windows.Forms.TextBox()
        Me.lbl_rmax = New System.Windows.Forms.TextBox()
        Me.lbl_vmin = New System.Windows.Forms.TextBox()
        Me.lbl_vmax = New System.Windows.Forms.TextBox()
        Me.lbl_nbp = New System.Windows.Forms.TextBox()
        Me.lbl_nbr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.checkPonte = New System.Windows.Forms.CheckBox()
        Me.labelf = New System.Windows.Forms.Label()
        Me.lbl_H = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_fermer
        '
        Me.lbl_fermer.Location = New System.Drawing.Point(189, 427)
        Me.lbl_fermer.Name = "lbl_fermer"
        Me.lbl_fermer.Size = New System.Drawing.Size(90, 22)
        Me.lbl_fermer.TabIndex = 0
        Me.lbl_fermer.Text = "Go !"
        Me.lbl_fermer.UseVisualStyleBackColor = True
        '
        'lbl_L
        '
        Me.lbl_L.Location = New System.Drawing.Point(250, 82)
        Me.lbl_L.Name = "lbl_L"
        Me.lbl_L.Size = New System.Drawing.Size(100, 20)
        Me.lbl_L.TabIndex = 1
        Me.lbl_L.Text = "1000"
        '
        'lbl_rmin
        '
        Me.lbl_rmin.Location = New System.Drawing.Point(250, 108)
        Me.lbl_rmin.Name = "lbl_rmin"
        Me.lbl_rmin.Size = New System.Drawing.Size(100, 20)
        Me.lbl_rmin.TabIndex = 2
        Me.lbl_rmin.Text = "10"
        '
        'lbl_rmax
        '
        Me.lbl_rmax.Location = New System.Drawing.Point(250, 134)
        Me.lbl_rmax.Name = "lbl_rmax"
        Me.lbl_rmax.Size = New System.Drawing.Size(100, 20)
        Me.lbl_rmax.TabIndex = 3
        Me.lbl_rmax.Text = "20"
        '
        'lbl_vmin
        '
        Me.lbl_vmin.Location = New System.Drawing.Point(250, 160)
        Me.lbl_vmin.Name = "lbl_vmin"
        Me.lbl_vmin.Size = New System.Drawing.Size(100, 20)
        Me.lbl_vmin.TabIndex = 4
        Me.lbl_vmin.Text = "5"
        '
        'lbl_vmax
        '
        Me.lbl_vmax.Location = New System.Drawing.Point(250, 186)
        Me.lbl_vmax.Name = "lbl_vmax"
        Me.lbl_vmax.Size = New System.Drawing.Size(100, 20)
        Me.lbl_vmax.TabIndex = 5
        Me.lbl_vmax.Text = "10"
        '
        'lbl_nbp
        '
        Me.lbl_nbp.Location = New System.Drawing.Point(250, 212)
        Me.lbl_nbp.Name = "lbl_nbp"
        Me.lbl_nbp.Size = New System.Drawing.Size(100, 20)
        Me.lbl_nbp.TabIndex = 6
        Me.lbl_nbp.Text = "20"
        '
        'lbl_nbr
        '
        Me.lbl_nbr.Location = New System.Drawing.Point(250, 238)
        Me.lbl_nbr.Name = "lbl_nbr"
        Me.lbl_nbr.Size = New System.Drawing.Size(100, 20)
        Me.lbl_nbr.TabIndex = 7
        Me.lbl_nbr.Text = "5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Veuillez choisir les paramètres suivant :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Largeur de l'aquarium :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Rayon minimum des Boids :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Rayon maximum des Boids :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Vitesse minimum des Boids :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Vitesse maximum des Boids :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombre de Poisson :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nombre de Prédateurs :"
        '
        'checkPonte
        '
        Me.checkPonte.AutoSize = True
        Me.checkPonte.Location = New System.Drawing.Point(250, 290)
        Me.checkPonte.Name = "checkPonte"
        Me.checkPonte.Size = New System.Drawing.Size(60, 17)
        Me.checkPonte.TabIndex = 16
        Me.checkPonte.Text = "Pondre"
        Me.checkPonte.UseVisualStyleBackColor = True
        '
        'labelf
        '
        Me.labelf.AutoSize = True
        Me.labelf.Location = New System.Drawing.Point(101, 59)
        Me.labelf.Name = "labelf"
        Me.labelf.Size = New System.Drawing.Size(116, 13)
        Me.labelf.TabIndex = 18
        Me.labelf.Text = "Hauteur de l'aquarium :"
        '
        'lbl_H
        '
        Me.lbl_H.Location = New System.Drawing.Point(250, 56)
        Me.lbl_H.Name = "lbl_H"
        Me.lbl_H.Size = New System.Drawing.Size(100, 20)
        Me.lbl_H.TabIndex = 17
        Me.lbl_H.Text = "500"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.labelf)
        Me.Controls.Add(Me.lbl_H)
        Me.Controls.Add(Me.checkPonte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nbr)
        Me.Controls.Add(Me.lbl_nbp)
        Me.Controls.Add(Me.lbl_vmax)
        Me.Controls.Add(Me.lbl_vmin)
        Me.Controls.Add(Me.lbl_rmax)
        Me.Controls.Add(Me.lbl_rmin)
        Me.Controls.Add(Me.lbl_L)
        Me.Controls.Add(Me.lbl_fermer)
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form2"
        Me.Text = "Nouvelle Partie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_fermer As System.Windows.Forms.Button
    Friend WithEvents lbl_L As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rmin As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rmax As System.Windows.Forms.TextBox
    Friend WithEvents lbl_vmin As System.Windows.Forms.TextBox
    Friend WithEvents lbl_vmax As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nbp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nbr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents checkPonte As System.Windows.Forms.CheckBox
    Friend WithEvents labelf As System.Windows.Forms.Label
    Friend WithEvents lbl_H As System.Windows.Forms.TextBox
End Class
