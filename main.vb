Public Class main

    Dim g As Double  '重力加速度
    Dim cishu As Double = 0
    Dim sudu As Double = 0    '下坠速度
    Dim Gameover As Boolean = False  '游戏是否结束
    Dim JiFen As Integer = 0    '游戏积分
    Dim Flag As Boolean = False
    Dim Dpicture(2) As PictureBox
    Dim Upicture(2) As PictureBox
    Dim Myimage(10), shuzi(10) As Image
    Dim player As System.Media.SoundPlayer
    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Const SND_FILENAME As Integer = &H20000
    Const SND_ASYNC As Integer = 1
    '定义音效
    Dim sy1 As New System.Media.SoundPlayer(My.Resources.Point)
    Dim sy2 As New System.Media.SoundPlayer(My.Resources.Swooshing)
    Dim sy3 As New System.Media.SoundPlayer(My.Resources.Wing)
    Dim sy4 As New System.Media.SoundPlayer(My.Resources.Die)
    Dim sy5 As New System.Media.SoundPlayer(My.Resources.down)
    Dim sy6 As New System.Media.SoundPlayer(My.Resources.Hit)
    '控件内容、位置初始化
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '界面大小
        Me.Width = 372
        Me.Height = 484
        '积分十位
        shiwei.Left = 136
        shiwei.Top = 9
        shiwei.Width = 35
        shiwei.Height = 54
        '积分个位
        gewei.Left = 173
        gewei.Top = 9
        gewei.Width = 35
        gewei.Height = 54

        Gameover1.Left = 79
        Gameover1.Top = 66
        Gameover1.Width = 220
        Gameover1.Height = 70
        '鸟的初始位置
        bird.Top = 172
        bird.Width = 43
        bird.Height = 35
        '结束积分背板
        scorepai.Left = 79
        scorepai.Top = 199
        scorepai.Width = 235
        scorepai.Height = 120
        '奖牌位置
        jiangpai.Left = 110
        jiangpai.Top = 246
        jiangpai.Width = 50
        jiangpai.Height = 46
        '最终得分十位位置
        Scoshiwei.Left = 250
        Scoshiwei.Top = 235
        Scoshiwei.Width = 18
        Scoshiwei.Height = 22
        '最终积分个位位置
        Scogewei.Left = 268
        Scogewei.Top = 235
        Scogewei.Width = 18
        Scogewei.Height = 22
        '历史最高积分十位
        Bestshiwei.Left = 250
        Bestshiwei.Top = 279
        Bestshiwei.Width = 18
        Bestshiwei.Height = 22
        '历史最高积分个位
        Bestgewei.Left = 268
        Bestgewei.Top = 279
        Bestgewei.Width = 18
        Bestgewei.Height = 22
        '游戏重新开始按键位置
        again.Left = 138
        again.Top = 356
        again.Width = 85
        again.Height = 50
        '地面位置
        dimian.Left = 0
        dimian.Top = 424
        dimian.Width = 2 * Me.Width
        dimian.Height = 35
        '图片放在数组里方便调用
        Myimage(0) = My.Resources._0
        Myimage(1) = My.Resources._1
        Myimage(2) = My.Resources._2
        Myimage(3) = My.Resources._3
        Myimage(4) = My.Resources._4
        Myimage(5) = My.Resources._5
        Myimage(6) = My.Resources._6
        Myimage(7) = My.Resources._7
        Myimage(8) = My.Resources._8
        Myimage(9) = My.Resources._9
        shuzi(0) = My.Resources.number_00
        shuzi(1) = My.Resources.number_01
        shuzi(2) = My.Resources.number_02
        shuzi(3) = My.Resources.number_03
        shuzi(4) = My.Resources.number_04
        shuzi(5) = My.Resources.number_05
        shuzi(6) = My.Resources.number_06
        shuzi(7) = My.Resources.number_07
        shuzi(8) = My.Resources.number_08
        shuzi(9) = My.Resources.number_09
        For i = 0 To 1
            Dpicture(i) = New PictureBox
            Upicture(i) = New PictureBox
        Next

        For i = 0 To 1
            Dpicture(i).Visible = True
            Upicture(i).Visible = True
            Dpicture(i).SizeMode = PictureBoxSizeMode.StretchImage
            Upicture(i).SizeMode = PictureBoxSizeMode.StretchImage
            Dpicture(i).BackColor = Color.Transparent
            Upicture(i).BackColor = Color.Transparent
            Dpicture(i).Image = My.Resources.DownGreen
            Upicture(i).Image = My.Resources.UpGreen
            Dpicture(i).Width = 40
            Upicture(i).Width = 40
            Dpicture(i).Height = 320
            Upicture(i).Height = 320
        Next
        Randomize()
        Upicture(0).Left = 279
        Upicture(1).Left = 490
        Upicture(0).Top = 250
        Upicture(1).Top = 300

        Dpicture(0).Left = 279
        Dpicture(1).Left = 490
        Dpicture(0).Top = Upicture(0).Top - Me.Height \ 4 - 320
        Dpicture(1).Top = Upicture(1).Top - Me.Height \ 4 - 320


        For i = 0 To 1
            Me.Controls.Add(Dpicture(i))
            Me.Controls.Add(Upicture(i))
        Next
    End Sub
    '柱子的移动、变化
    Sub zhuzi()
        Dim i As Integer
        For i = 0 To 1
            Dpicture(i).Left = Dpicture(i).Left - 3
            Upicture(i).Left = Upicture(i).Left - 3
            dimian.Left = dimian.Left - 3
            If (dimian.Left < -Me.Width) Then
                dimian.Left = 0
            End If

            If Upicture(i).Left + Upicture(i).Width >= bird.Left And
               Upicture(i).Left + Upicture(i).Width - 3 < bird.Left Then
                JiFen = JiFen + 1               '小鸟经过柱子得分
                If JiFen >= 10 Then
                    shiwei.Visible = True
                End If
                '积分转化成图片显示
                gewei.Image = Myimage(JiFen Mod 10)
                shiwei.Image = Myimage(JiFen \ 10)
                Scogewei.Image = shuzi(JiFen Mod 10)
                Scoshiwei.Image = shuzi(JiFen \ 10)
                sy1.Play()
            End If

            If Upicture(i).Left < -Upicture(i).Width Then    '柱子从左侧消失，然后从右侧出现
                Randomize()

                Upicture(i).Left = Me.Width - 10
                Upicture(i).Top = Int(Rnd() * 265) + 140   '随机柱子位置

                Dpicture(i).Left = Me.Width - 10
                Dpicture(i).Top = Upicture(i).Top - Me.Height \ 4 - 320

            End If
        Next i

    End Sub
    '小鸟上升
    Sub BirdUp()
        g = 1
        bird.Top = bird.Top + sudu
        sudu = sudu + g       '速度加重力加速度
        If bird.Top + bird.Height > dimian.Top Then
            Gameover = True
        End If
        cishu = cishu + 1
    End Sub
    '小鸟下降
    Sub BirdDown()
        g = 1
        bird.Top = bird.Top + sudu
        sudu = sudu + g       '速度加重力加速度
        If bird.Top + bird.Height >= dimian.Top Then
            bird.Top = dimian.Top - bird.Height
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            sy5.Play()
        End If
    End Sub
    '判断碰撞条件
    Sub PengZhuang()
        Flag = False
        For i = 0 To 1
            If bird.Left + bird.Width > Dpicture(i).Left And bird.Left + bird.Width < Dpicture(i).Left + Dpicture(i).Width And
                bird.Top < Dpicture(i).Top + Dpicture(i).Height Then
                Flag = True
            End If
            If bird.Left > Dpicture(i).Left And bird.Left < Dpicture(i).Left + Dpicture(i).Width And
                bird.Top < Dpicture(i).Top + Dpicture(i).Height Then
                Flag = True
            End If
            If bird.Left + bird.Width > Upicture(i).Left And bird.Left + bird.Width < Upicture(i).Left + Upicture(i).Width And
                bird.Top + bird.Height > Upicture(i).Top Then
                Flag = True
            End If
            If bird.Left > Upicture(i).Left And bird.Left < Upicture(i).Left + Upicture(i).Width And
                bird.Top + bird.Height > Upicture(i).Top Then
                Flag = True
            End If
        Next i
        If Flag = True Then
            sy4.Play()
            sy6.Play()
            Gameover = True
        End If
    End Sub
    'Timer1控件控制柱子运动与小鸟的碰撞判断
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        zhuzi()
        PengZhuang()
    End Sub
    'Timer2控件控制小鸟上升
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        BirdUp()
        If cishu > 8 Then
            Timer2.Enabled = False
            Timer3.Enabled = True
            cishu = 0
        End If
    End Sub
    'Timer3控件控制小鸟下降
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        BirdDown()
    End Sub
    '按下空格键控制上升模块
    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space And Gameover = False Then
            bird.Image = My.Resources.上小鸟
            sudu = -13.5
            Timer1.Enabled = True
            Timer2.Enabled = True
        End If
    End Sub
    '释放空格键控制下降模块
    Private Sub Form3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space And Gameover = False Then
            bird.Image = My.Resources.下小鸟
            sudu = 1.5
            'Timer1.Enabled = True
            Timer3.Enabled = True
        End If
    End Sub
    'Timer4控件控制游戏结束模块
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        '游戏结束，颁发奖牌
        If Gameover = True Then
            If JiFen < 10 Then
                jiangpai.Visible = False
            ElseIf JiFen >= 10 And JiFen < 20 Then
                jiangpai.Visible = True
                jiangpai.Image = My.Resources.铜牌
            ElseIf JiFen >= 20 And JiFen < 30 Then
                jiangpai.Visible = True
                jiangpai.Image = My.Resources.银牌
            ElseIf JiFen >= 30 And JiFen < 40 Then
                jiangpai.Visible = True
                jiangpai.Image = My.Resources.金牌
            ElseIf JiFen >= 40 Then
                jiangpai.Visible = True
                jiangpai.Image = My.Resources.白金牌
            End If
            Scogewei.Visible = True
            Scogewei.Image = shuzi(JiFen Mod 10)
            If JiFen \ 10 = 0 Then
                Scoshiwei.Visible = False
            Else
                Scoshiwei.Visible = True
                Scoshiwei.Image = shuzi(JiFen \ 10)
            End If
            '最大积分记录
            If JiFen > best Then
                best = JiFen
            End If

            Bestgewei.Visible = True
            Bestgewei.Image = shuzi(best Mod 10)
            If best \ 10 = 0 Then
                Bestshiwei.Visible = False
            Else
                Bestshiwei.Visible = True
                Bestshiwei.Image = shuzi(best \ 10)
            End If
            scorepai.Visible = True
            shiwei.Visible = False
            gewei.Visible = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            sudu = 2
            Timer3.Enabled = True
            Timer3.Interval = 10
            Gameover1.Visible = True
            again.Visible = True
            again.Enabled = True
        End If
    End Sub
    '游戏重新开始
    Private Sub again_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles again.Click
        Form2.Show()
        Me.Close()
    End Sub

End Class
