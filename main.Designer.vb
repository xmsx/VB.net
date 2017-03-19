<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.shiwei = New System.Windows.Forms.Label()
        Me.gewei = New System.Windows.Forms.Label()
        Me.dimian = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Gameover1 = New System.Windows.Forms.PictureBox()
        Me.again = New System.Windows.Forms.PictureBox()
        Me.scorepai = New System.Windows.Forms.PictureBox()
        Me.jiangpai = New System.Windows.Forms.PictureBox()
        Me.Bestgewei = New System.Windows.Forms.PictureBox()
        Me.Scogewei = New System.Windows.Forms.PictureBox()
        Me.Scoshiwei = New System.Windows.Forms.PictureBox()
        Me.Bestshiwei = New System.Windows.Forms.PictureBox()
        CType(Me.dimian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gameover1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.again, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scorepai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jiangpai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bestgewei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scogewei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scoshiwei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bestshiwei, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shiwei
        '
        Me.shiwei.BackColor = System.Drawing.Color.Transparent
        Me.shiwei.Image = Global.Flaapy_Bird_vb.My.Resources.Resources._0
        Me.shiwei.Location = New System.Drawing.Point(116, 9)
        Me.shiwei.Name = "shiwei"
        Me.shiwei.Size = New System.Drawing.Size(28, 54)
        Me.shiwei.TabIndex = 1
        Me.shiwei.Visible = False
        '
        'gewei
        '
        Me.gewei.BackColor = System.Drawing.Color.Transparent
        Me.gewei.Image = Global.Flaapy_Bird_vb.My.Resources.Resources._0
        Me.gewei.Location = New System.Drawing.Point(145, 9)
        Me.gewei.Name = "gewei"
        Me.gewei.Size = New System.Drawing.Size(32, 54)
        Me.gewei.TabIndex = 3
        '
        'dimian
        '
        Me.dimian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dimian.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.地面
        Me.dimian.Location = New System.Drawing.Point(-2, 425)
        Me.dimian.Name = "dimian"
        Me.dimian.Size = New System.Drawing.Size(859, 35)
        Me.dimian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimian.TabIndex = 8
        Me.dimian.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.中小鸟
        Me.bird.Location = New System.Drawing.Point(28, 172)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(34, 27)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.bird.TabIndex = 9
        Me.bird.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 80
        '
        'Timer3
        '
        Me.Timer3.Interval = 80
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 5
        '
        'Gameover1
        '
        Me.Gameover1.BackColor = System.Drawing.Color.Transparent
        Me.Gameover1.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.gameover
        Me.Gameover1.Location = New System.Drawing.Point(59, 80)
        Me.Gameover1.Name = "Gameover1"
        Me.Gameover1.Size = New System.Drawing.Size(233, 74)
        Me.Gameover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gameover1.TabIndex = 10
        Me.Gameover1.TabStop = False
        Me.Gameover1.Visible = False
        '
        'again
        '
        Me.again.BackColor = System.Drawing.Color.Transparent
        Me.again.Enabled = False
        Me.again.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.重来_play
        Me.again.Location = New System.Drawing.Point(116, 319)
        Me.again.Name = "again"
        Me.again.Size = New System.Drawing.Size(89, 50)
        Me.again.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.again.TabIndex = 11
        Me.again.TabStop = False
        Me.again.Visible = False
        '
        'scorepai
        '
        Me.scorepai.BackColor = System.Drawing.Color.Transparent
        Me.scorepai.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.score
        Me.scorepai.Location = New System.Drawing.Point(78, 198)
        Me.scorepai.Name = "scorepai"
        Me.scorepai.Size = New System.Drawing.Size(230, 115)
        Me.scorepai.TabIndex = 12
        Me.scorepai.TabStop = False
        Me.scorepai.Visible = False
        '
        'jiangpai
        '
        Me.jiangpai.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.jiangpai.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.金牌
        Me.jiangpai.Location = New System.Drawing.Point(94, 228)
        Me.jiangpai.Name = "jiangpai"
        Me.jiangpai.Size = New System.Drawing.Size(50, 46)
        Me.jiangpai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.jiangpai.TabIndex = 13
        Me.jiangpai.TabStop = False
        Me.jiangpai.Visible = False
        '
        'Bestgewei
        '
        Me.Bestgewei.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Bestgewei.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.number_00
        Me.Bestgewei.Location = New System.Drawing.Point(207, 258)
        Me.Bestgewei.Name = "Bestgewei"
        Me.Bestgewei.Size = New System.Drawing.Size(31, 22)
        Me.Bestgewei.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bestgewei.TabIndex = 15
        Me.Bestgewei.TabStop = False
        Me.Bestgewei.Visible = False
        '
        'Scogewei
        '
        Me.Scogewei.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Scogewei.Image = Global.Flaapy_Bird_vb.My.Resources.Resources.number_00
        Me.Scogewei.Location = New System.Drawing.Point(207, 225)
        Me.Scogewei.Name = "Scogewei"
        Me.Scogewei.Size = New System.Drawing.Size(31, 22)
        Me.Scogewei.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Scogewei.TabIndex = 16
        Me.Scogewei.TabStop = False
        Me.Scogewei.Visible = False
        '
        'Scoshiwei
        '
        Me.Scoshiwei.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Scoshiwei.Location = New System.Drawing.Point(184, 225)
        Me.Scoshiwei.Name = "Scoshiwei"
        Me.Scoshiwei.Size = New System.Drawing.Size(23, 22)
        Me.Scoshiwei.TabIndex = 17
        Me.Scoshiwei.TabStop = False
        Me.Scoshiwei.Visible = False
        '
        'Bestshiwei
        '
        Me.Bestshiwei.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Bestshiwei.Location = New System.Drawing.Point(184, 258)
        Me.Bestshiwei.Name = "Bestshiwei"
        Me.Bestshiwei.Size = New System.Drawing.Size(23, 22)
        Me.Bestshiwei.TabIndex = 18
        Me.Bestshiwei.TabStop = False
        Me.Bestshiwei.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = Global.Flaapy_Bird_vb.My.Resources.Resources.白天
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(346, 462)
        Me.Controls.Add(Me.Bestshiwei)
        Me.Controls.Add(Me.Scoshiwei)
        Me.Controls.Add(Me.Scogewei)
        Me.Controls.Add(Me.Bestgewei)
        Me.Controls.Add(Me.jiangpai)
        Me.Controls.Add(Me.scorepai)
        Me.Controls.Add(Me.again)
        Me.Controls.Add(Me.Gameover1)
        Me.Controls.Add(Me.bird)
        Me.Controls.Add(Me.dimian)
        Me.Controls.Add(Me.gewei)
        Me.Controls.Add(Me.shiwei)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Flappy bird"
        CType(Me.dimian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gameover1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.again, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scorepai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jiangpai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bestgewei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scogewei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scoshiwei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bestshiwei, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shiwei As System.Windows.Forms.Label
    Friend WithEvents gewei As System.Windows.Forms.Label
    Friend WithEvents dimian As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bird As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Gameover1 As System.Windows.Forms.PictureBox
    Friend WithEvents again As System.Windows.Forms.PictureBox
    Friend WithEvents scorepai As System.Windows.Forms.PictureBox
    Friend WithEvents jiangpai As System.Windows.Forms.PictureBox
    Friend WithEvents Bestgewei As System.Windows.Forms.PictureBox
    Friend WithEvents Scogewei As System.Windows.Forms.PictureBox
    Friend WithEvents Scoshiwei As System.Windows.Forms.PictureBox
    Friend WithEvents Bestshiwei As System.Windows.Forms.PictureBox

End Class
