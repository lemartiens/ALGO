<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblcamx = New System.Windows.Forms.Label()
        Me.lblcamy = New System.Windows.Forms.Label()
        Me.lblzoom = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.boxJouer = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvellePartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_OeufPondu = New System.Windows.Forms.Label()
        Me.lbl_vie = New System.Windows.Forms.Label()
        Me.lbl_burger = New System.Windows.Forms.Label()
        Me.lbl_numBoid = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkBoid = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 24
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(863, 37)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(462, 405)
        Me.Chart1.TabIndex = 25
        Me.Chart1.Text = "Chart1"
        '
        'lblcamx
        '
        Me.lblcamx.AutoSize = True
        Me.lblcamx.Location = New System.Drawing.Point(1004, 282)
        Me.lblcamx.Name = "lblcamx"
        Me.lblcamx.Size = New System.Drawing.Size(39, 13)
        Me.lblcamx.TabIndex = 26
        Me.lblcamx.Text = "Label2"
        '
        'lblcamy
        '
        Me.lblcamy.AutoSize = True
        Me.lblcamy.Location = New System.Drawing.Point(1004, 308)
        Me.lblcamy.Name = "lblcamy"
        Me.lblcamy.Size = New System.Drawing.Size(39, 13)
        Me.lblcamy.TabIndex = 27
        Me.lblcamy.Text = "Label3"
        '
        'lblzoom
        '
        Me.lblzoom.AutoSize = True
        Me.lblzoom.Location = New System.Drawing.Point(435, 9)
        Me.lblzoom.Name = "lblzoom"
        Me.lblzoom.Size = New System.Drawing.Size(39, 13)
        Me.lblzoom.TabIndex = 28
        Me.lblzoom.Text = "Label2"
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.Location = New System.Drawing.Point(1004, 365)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(39, 13)
        Me.lblH.TabIndex = 29
        Me.lblH.Text = "Label2"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Location = New System.Drawing.Point(1004, 387)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(39, 13)
        Me.lblL.TabIndex = 30
        Me.lblL.Text = "Label2"
        '
        'boxJouer
        '
        Me.boxJouer.AutoSize = True
        Me.boxJouer.Location = New System.Drawing.Point(677, 7)
        Me.boxJouer.Name = "boxJouer"
        Me.boxJouer.Size = New System.Drawing.Size(52, 17)
        Me.boxJouer.TabIndex = 31
        Me.boxJouer.Text = "Jouer"
        Me.boxJouer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.aquarium
        Me.PictureBox1.Location = New System.Drawing.Point(10, 30)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(800, 500)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(800, 500)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 40
        Me.HScrollBar1.Location = New System.Drawing.Point(10, 533)
        Me.HScrollBar1.Maximum = 500
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(800, 20)
        Me.HScrollBar1.SmallChange = 20
        Me.HScrollBar1.TabIndex = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvellePartieToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'NouvellePartieToolStripMenuItem
        '
        Me.NouvellePartieToolStripMenuItem.Name = "NouvellePartieToolStripMenuItem"
        Me.NouvellePartieToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NouvellePartieToolStripMenuItem.Text = "Nouvelle Partie..."
        '
        'lbl_OeufPondu
        '
        Me.lbl_OeufPondu.AutoSize = True
        Me.lbl_OeufPondu.Location = New System.Drawing.Point(985, 501)
        Me.lbl_OeufPondu.Name = "lbl_OeufPondu"
        Me.lbl_OeufPondu.Size = New System.Drawing.Size(39, 13)
        Me.lbl_OeufPondu.TabIndex = 34
        Me.lbl_OeufPondu.Text = "Label2"
        '
        'lbl_vie
        '
        Me.lbl_vie.AutoSize = True
        Me.lbl_vie.Location = New System.Drawing.Point(985, 473)
        Me.lbl_vie.Name = "lbl_vie"
        Me.lbl_vie.Size = New System.Drawing.Size(39, 13)
        Me.lbl_vie.TabIndex = 35
        Me.lbl_vie.Text = "Label2"
        '
        'lbl_burger
        '
        Me.lbl_burger.AutoSize = True
        Me.lbl_burger.Location = New System.Drawing.Point(985, 533)
        Me.lbl_burger.Name = "lbl_burger"
        Me.lbl_burger.Size = New System.Drawing.Size(39, 13)
        Me.lbl_burger.TabIndex = 36
        Me.lbl_burger.Text = "Label2"
        '
        'lbl_numBoid
        '
        Me.lbl_numBoid.AutoSize = True
        Me.lbl_numBoid.Location = New System.Drawing.Point(985, 445)
        Me.lbl_numBoid.Name = "lbl_numBoid"
        Me.lbl_numBoid.Size = New System.Drawing.Size(39, 13)
        Me.lbl_numBoid.TabIndex = 37
        Me.lbl_numBoid.Text = "Label2"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 40
        Me.VScrollBar1.Location = New System.Drawing.Point(813, 30)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(23, 500)
        Me.VScrollBar1.SmallChange = 20
        Me.VScrollBar1.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 21)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Zoom par défaut"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkBoid
        '
        Me.checkBoid.AutoSize = True
        Me.checkBoid.Location = New System.Drawing.Point(735, 7)
        Me.checkBoid.Name = "checkBoid"
        Me.checkBoid.Size = New System.Drawing.Size(75, 17)
        Me.checkBoid.TabIndex = 42
        Me.checkBoid.Text = "Jouer boid"
        Me.checkBoid.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 566)
        Me.Controls.Add(Me.checkBoid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.lbl_numBoid)
        Me.Controls.Add(Me.lbl_burger)
        Me.Controls.Add(Me.lbl_vie)
        Me.Controls.Add(Me.lbl_OeufPondu)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.boxJouer)
        Me.Controls.Add(Me.lblL)
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.lblzoom)
        Me.Controls.Add(Me.lblcamy)
        Me.Controls.Add(Me.lblcamx)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblcamx As System.Windows.Forms.Label
    Friend WithEvents lblcamy As System.Windows.Forms.Label
    Friend WithEvents lblzoom As System.Windows.Forms.Label
    Friend WithEvents lblH As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents boxJouer As System.Windows.Forms.CheckBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvellePartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_OeufPondu As System.Windows.Forms.Label
    Friend WithEvents lbl_vie As System.Windows.Forms.Label
    Friend WithEvents lbl_burger As System.Windows.Forms.Label
    Friend WithEvents lbl_numBoid As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents checkBoid As System.Windows.Forms.CheckBox

End Class
