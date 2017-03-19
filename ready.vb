Public Class Form2
    Dim h As Integer = 200
    Dim flag As Integer = 0
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call mymove1()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Call mymove2()

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Call mymove3()

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Call mymove4()
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Call mymove5()
    End Sub

    Sub mymove1()
        PictureBox2.Top = PictureBox2.Top + 1
        'PictureBox2.Image = My.Resources.下小鸟
        If (PictureBox2.Top > h + 20) Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Sub mymove2()
        PictureBox2.Top = PictureBox2.Top - 1
        PictureBox2.Image = My.Resources.上小鸟
        If (PictureBox2.Top < h) Then
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub

    Sub mymove3()
        PictureBox1.Left = PictureBox1.Left - 10
        If (PictureBox1.Left = -200) Then
            PictureBox1.Left = 0
        End If
    End Sub

    Sub mymove4()
        h = h - 10
        If h = -10 Then
            h = h + 10
        End If
    End Sub

    Sub mymove5()
        If flag = 0 Then
            PictureBox2.Image = My.Resources.下小鸟
            flag = 1
        ElseIf flag = 1 Then
            PictureBox2.Image = My.Resources.上小鸟
            flag = 0
        End If
    End Sub
   

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 367
        Me.Height = 520
        PictureBox1.Left = 0
        PictureBox1.Top = 457
        PictureBox1.Width = 2 * Me.Width
        PictureBox1.Height = 36
        PictureBox2.Left = 27
        PictureBox2.Top = 220
        PictureBox2.Width = 46
        PictureBox2.Height = 32
        Label1.Left = 113
        Label1.Top = 240
        Label1.Width = 133
        Label1.Height = 112
        Label2.Left = 79
        Label2.Top = 94
        Label2.Width = 194
        Label2.Height = 64

    End Sub
End Class