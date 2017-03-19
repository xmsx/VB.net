Public Class begin

    Dim flag As Integer = 0
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        Form2.Show()
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

    Sub mymove1()
        Label1.Top = Label1.Top + 1
        Label2.Top = Label2.Top + 1
        Label2.Image = My.Resources.上小鸟
        If (Label1.Top > 70) Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Sub mymove2()
        Label1.Top = Label1.Top - 1
        Label2.Top = Label2.Top - 1
        Label2.Image = My.Resources.下小鸟
        If (Label1.Top < 60) Then
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
        If flag = 0 Then
            Label2.Image = My.Resources.下小鸟
            flag = 1
        ElseIf flag = 1 Then
            Label2.Image = My.Resources.上小鸟
            flag = 0
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 374
        Me.Height = 490
        PictureBox1.Left = 0
        PictureBox1.Top = 434
        PictureBox1.Width = 2 * Me.Width
        PictureBox1.Height = 25
        Label1.Left = 47
        Label1.Top = 60
        Label1.Width = 187
        Label1.Height = 53
        Label2.Left = 253
        Label2.Top = 73
        Label2.Width = 55
        Label2.Height = 38
        Label3.Left = 125
        Label3.Top = 350
        Label3.Width = 100
        Label3.Height = 40
    End Sub
End Class