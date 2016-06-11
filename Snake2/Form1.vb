Public Class Form1
    Dim level As Integer
    Public scoremax As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fileReadScoreMax As New IO.StreamReader("scoremax.txt")
            scoremax = fileReadScoreMax.ReadLine
        Catch ex As Exception
            MsgBox("Fisierul 'scoremax.txt'nu a putut fi deschis")
        End Try
        Me.BackgroundImage = My.Resources.grr
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Label1.Visible = False
        PictureBox1.Parent = Me ' pentru mancare floare
        Me.SendToBack()
        My.Computer.Audio.Play(My.Resources.Snake_Sound_Effects___Animation, AudioPlayMode.Background)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Label1.Visible = False
        Label2.Visible = True
        PictureBox1.Visible = True
        MsgBox("Purice Rebeca-Ligia, USV, FIESC, Calculatoare, anul II, grupa 3121A", MsgBoxStyle.ApplicationModal, "Snake Game - Author")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Label1.Visible = False
        Me.Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        '' NdLevelToolStripMenuItem.Enabled = False
        '' RdLevelToolStripMenuItem.Enabled = False

    End Sub

    Private Sub InstrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.Sneaky_Snitch_Kevin_MacLeod___Gaming_Background_Mu, AudioPlayMode.Background)
        Label1.Visible = True
        PictureBox1.Visible = False
        Label2.Visible = False

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        My.Computer.Audio.Stop()

        Label1.Visible = False
        Level2.Show()
    End Sub

    Private Sub NdLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NdLevelToolStripMenuItem.Click
        Label1.Visible = False
        Level22.Show()
        My.Computer.Audio.Stop()

    End Sub

    Private Sub RdLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RdLevelToolStripMenuItem.Click
        Label1.Visible = False
        Level3.Show()
        My.Computer.Audio.Stop()

    End Sub

    Private Sub GameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameToolStripMenuItem.Click
        ' scoreRecord = fileReadScorCurentmax.Read()
        'fileReadScorCurentmax.Close()
        Try
            Dim fileReadScorCurentmax As New IO.StreamReader("scoremax.txt")
            scoremax = fileReadScorCurentmax.ReadLine()
            fileReadScorCurentmax.Close()
        Catch ex As Exception
            MsgBox("Fisierul 'scoremax.txt' nu a putut fi deschis")
        End Try

        MsgBox("Scorul maxim inregistrat este: " & scoremax, MsgBoxStyle.Information, "Snake - Scor Record")
    End Sub


End Class
