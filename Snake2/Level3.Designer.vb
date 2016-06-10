<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tm_snakeMover = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbscore = New System.Windows.Forms.Label()
        Me.tm_Rockdr = New System.Windows.Forms.Timer(Me.components)
        Me.tm_Rockst = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb_Field = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.labelScorMaxim = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tm_snakeMover
        '
        Me.tm_snakeMover.Interval = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Scor: "
        '
        'lbscore
        '
        Me.lbscore.AutoSize = True
        Me.lbscore.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbscore.Location = New System.Drawing.Point(72, 416)
        Me.lbscore.Name = "lbscore"
        Me.lbscore.Size = New System.Drawing.Size(56, 17)
        Me.lbscore.TabIndex = 25
        Me.lbscore.Text = "Label2"
        '
        'tm_Rockdr
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Snake2.My.Resources.Resources.rk1
        Me.PictureBox3.Location = New System.Drawing.Point(404, 265)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Snake2.My.Resources.Resources.rk1
        Me.PictureBox1.Location = New System.Drawing.Point(119, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'pb_Field
        '
        Me.pb_Field.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pb_Field.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb_Field.Location = New System.Drawing.Point(0, 0)
        Me.pb_Field.Name = "pb_Field"
        Me.pb_Field.Size = New System.Drawing.Size(575, 400)
        Me.pb_Field.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_Field.TabIndex = 22
        Me.pb_Field.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Snake2.My.Resources.Resources.head
        Me.PictureBox4.Location = New System.Drawing.Point(282, 209)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 12)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'labelScorMaxim
        '
        Me.labelScorMaxim.AutoSize = True
        Me.labelScorMaxim.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelScorMaxim.Location = New System.Drawing.Point(134, 416)
        Me.labelScorMaxim.Name = "labelScorMaxim"
        Me.labelScorMaxim.Size = New System.Drawing.Size(12, 17)
        Me.labelScorMaxim.TabIndex = 29
        Me.labelScorMaxim.Text = "/"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Snake2.My.Resources.Resources.food1
        Me.PictureBox2.Location = New System.Drawing.Point(119, 221)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Level3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(575, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.labelScorMaxim)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbscore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pb_Field)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Level3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level3"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pb_Field As PictureBox
    Friend WithEvents tm_snakeMover As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lbscore As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents tm_Rockdr As Timer
    Friend WithEvents tm_Rockst As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents labelScorMaxim As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
