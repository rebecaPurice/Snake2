﻿Public Class Level22
    'NIVEL 2
    Public score As Integer
    Public scoremax As Integer = 0

    Private Sub Level22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        scoremax = Form1.scoremax
        score = Level2.score
        labelScorMaxim.Text = scoremax
        pb_Field.BackgroundImage = My.Resources.water
        pb_Field.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Parent = pb_Field
        pb_Field.SendToBack()
        PictureBox1.Visible = False
        PictureBox2.Parent = pb_Field ' pentru mancare floare
        pb_Field.SendToBack()
        PictureBox2.Visible = False
        PictureBox3.Parent = pb_Field
        pb_Field.SendToBack()
        PictureBox3.Visible = False

        create_head()
        create_eat()
        create_Rock() 'al doilea  nivel are 1  obstacol
        create_SpeedRock()
        lbscore.Text = score

    End Sub
#Region "Snake Stuff" 'sub pentru snake
    Dim snake(1000) As PictureBox
    Dim length_of_snake As Integer = -1
    Dim r As New Random 'folosit pentru mancare, prima aparitie snake ( cap)
    Dim left_right_mover As Integer = 0
    Dim up_down_mover As Integer = 0

    Private Sub create_head()
        length_of_snake += 1
        PictureBox3.Visible = True
        snake(length_of_snake) = PictureBox3
        ' With snake(length_of_snake)
        '.Height = 10
        '.Width = 10
        '.BackColor = Color.White
        '.Top = r.Next(pb_Field.Top + pb_Field.Bottom) / 2 + 30 'apare random, dar in perimetrul pictureBox
        '.Left = r.Next(pb_Field.Right - 30 + pb_Field.Left + 30) / 2 + 30
        'End With
        Me.Controls.Add(snake(length_of_snake))
        snake(length_of_snake).BringToFront()

        lengthenSnake() 'la inceput are lungimea 3: cap+2
        lengthenSnake()

    End Sub
    'sub pentru deplasare snake
    Private Sub Level22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        tm_snakeMover.Start()

        Select Case e.KeyChar
            Case "a"
                left_right_mover = -10
                up_down_mover = 0
            Case "d"
                left_right_mover = 10
                up_down_mover = 0
            Case "w"
                left_right_mover = 0
                up_down_mover = -10
            Case "s"
                left_right_mover = 0
                up_down_mover = 10
            Case "p"
                tm_snakeMover.Stop()



        End Select
    End Sub

    Private Sub tm_snakeMover_Tick(sender As Object, e As EventArgs) Handles tm_snakeMover.Tick
        For i = length_of_snake To 1 Step -1
            snake(i).Top = snake(i - 1).Top
            snake(i).Left = snake(i - 1).Left
        Next

        snake(0).Top += up_down_mover
        snake(0).Left += left_right_mover

        collide_With_walls()
        collide_With_eat()
        collide_With_self()
        collide_With_Rock()
        collide_With_spRock()
    End Sub
    Private Sub lengthenSnake()
        length_of_snake += 1
        snake(length_of_snake) = New PictureBox
        With snake(length_of_snake)
            .Height = 10
            .Width = 10
            .BackColor = Color.Turquoise
            .BorderStyle = BorderStyle.FixedSingle

            .Top = snake(length_of_snake - 1).Top
            .Left = snake(length_of_snake - 1).Left + 10

        End With
        Me.Controls.Add(snake(length_of_snake))
        snake(length_of_snake).BringToFront()
    End Sub
#End Region

#Region "Coliziuni"
    Private Sub collide_With_walls()
        If snake(0).Left < pb_Field.Left Then
            tm_snakeMover.Stop()
            My.Computer.Audio.Play(My.Resources.Aaawwww___Sound_Effect, AudioPlayMode.Background)
            Call Scor_maxim()
            Form1.Show()
            MsgBox("Jocul s-a incheiat! Scorul dumneavoastra este: " & lbscore.Text)
            Me.Close()
        End If
        If snake(0).Right > pb_Field.Right Then
            tm_snakeMover.Stop()
            My.Computer.Audio.Play(My.Resources.Aaawwww___Sound_Effect, AudioPlayMode.Background)
            Call Scor_maxim()
            Form1.Show()
            MsgBox("Jocul s-a incheiat! Scorul dumneavoastra este: " & lbscore.Text)
            Me.Close()
        End If
        If snake(0).Top < pb_Field.Top Then
            tm_snakeMover.Stop()
            My.Computer.Audio.Play(My.Resources.Aaawwww___Sound_Effect, AudioPlayMode.Background)
            Call Scor_maxim()
            Form1.Show()
            MsgBox("Jocul s-a incheiat! Scorul dumneavoastra este: " & lbscore.Text)
            Me.Close()
        End If
        If snake(0).Bottom > pb_Field.Bottom Then
            tm_snakeMover.Stop()
            My.Computer.Audio.Play(My.Resources.Aaawwww___Sound_Effect, AudioPlayMode.Background)
            Call Scor_maxim()
            Form1.Show()
            MsgBox("Jocul s-a incheiat! Scorul dumneavoastra este: " & lbscore.Text)
            Me.Close()
        End If
    End Sub
    Private Sub collide_With_eat()

        If snake(0).Bounds.IntersectsWith(eat.Bounds) Then
            lengthenSnake()
            eat.Top = r.Next(pb_Field.Top, pb_Field.Bottom - 10)
            eat.Left = r.Next(pb_Field.Left, pb_Field.Right - 10)
            score = score + 1
            lbscore.Text = score
            My.Computer.Audio.Play(My.Resources.You_win_sound_effect_1, AudioPlayMode.Background)
            If score = 15 Then
                Level3.Show()
                Me.Close()
            End If
            Dim fileWriteScorCurent As New IO.StreamWriter("score.txt")
            fileWriteScorCurent.Write(score)
            fileWriteScorCurent.Close()


        End If

    End Sub
    Private Sub collide_With_Rock()
        If snake(0).Bounds.IntersectsWith(rock.Bounds) Then
            tm_snakeMover.Stop()
            My.Computer.Audio.Play(My.Resources.Aaawwww___Sound_Effect, AudioPlayMode.Background)
            Call Scor_maxim()
            Form1.Show()
            MsgBox("Jocul s-a incheiat! Scorul dumneavoastra este: " & lbscore.Text)


            Me.Close()

        End If
    End Sub
    Private Sub collide_With_spRock()


        If snake(0).Bounds.IntersectsWith(spRock.Bounds) Then

            tm_snakeMover.Interval -= 15
            spRock.BackColor = Color.Black
            spRock.Hide()

        End If
    End Sub
    Private Sub collide_With_self()
        For i = 1 To length_of_snake
            If snake(0).Bounds.IntersectsWith(snake(i).Bounds) Then
                tm_snakeMover.Stop()
                My.Computer.Audio.Play(My.Resources.Aaawwww___Sound_Effect, AudioPlayMode.Background)
                Call Scor_maxim()
                Form1.Show()
                MsgBox("Jocul s-a incheiat! Scorul dumneavoastra este: " & lbscore.Text)
                Me.Close()
            End If
        Next
    End Sub
#End Region
#Region "Eat" 'iarba
    Dim eat As PictureBox
    Private Sub create_eat()
        eat = New PictureBox
        eat.BackgroundImage = My.Resources.fd
        eat.BackgroundImageLayout = ImageLayout.Stretch
        eat.BackColor = Color.Blue
        With eat
            .Height = 15
            .Width = 15
            .BackColor = Color.Blue
            .Top = r.Next(pb_Field.Top, pb_Field.Bottom - 10)
            .Left = r.Next(pb_Field.Left, pb_Field.Right - 10)
        End With
        Me.Controls.Add(eat)
        eat.BringToFront()

    End Sub
#End Region
#Region "Rocks" 'intersectare cu obstacole => game over, patratel rosu pentru obstacol, verde pentru speed
    Dim rock As PictureBox
    Dim spRock As PictureBox
    Private Sub create_Rock()

        PictureBox1.Visible = True
        rock = PictureBox1

    End Sub
    Private Sub create_SpeedRock()
        spRock = PictureBox4
        ' With spRock
        '.Height = 8
        '.Width = 8
        '.BackColor = Color.Red
        '.Top = r.Next(pb_Field.Top, pb_Field.Bottom - 10)
        '.Left = r.Next(pb_Field.Left, pb_Field.Right - 10)
        'End With
        Me.Controls.Add(spRock)
        spRock.BringToFront()
    End Sub


#End Region
#Region "Scor "
    Public Sub Scor_maxim()
        If score >= scoremax Then


            Dim fileWriteScorCurentmax As New IO.StreamWriter("scoremax.txt")
            fileWriteScorCurentmax.WriteLine(score)
            fileWriteScorCurentmax.Close()
        End If
        Form1.scoremax = scoremax
    End Sub


#End Region


End Class