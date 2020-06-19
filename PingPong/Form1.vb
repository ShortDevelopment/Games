'
'© 2018 KPFiMa-Medien, Lukas Kurz
'
Public Class Form1
    Dim x As Integer
    Dim y As Integer
    Dim drag As Boolean
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        x = Cursor.Position.X - Me.Left
        y = Cursor.Position.Y - Me.Top
        drag = True
    End Sub
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag = False Then Exit Sub
        Me.Left = Cursor.Position.X - x
        Me.Top = Cursor.Position.Y - y
    End Sub
    Private Sub lblClose_MouseEnter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter
        lblClose.ForeColor = Color.Red
    End Sub
    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        lblClose.ForeColor = Color.LightGray
    End Sub
    Private Sub lblMinimize_MouseEnter(sender As Object, e As EventArgs) Handles lblMinimize.MouseEnter
        lblMinimize.ForeColor = Color.Blue
    End Sub
    Private Sub lblMinimize_MouseLeave(sender As Object, e As EventArgs) Handles lblMinimize.MouseLeave
        lblMinimize.ForeColor = Color.LightGray
    End Sub
    Dim BUp As Integer = 1
    Dim BRight As Integer = 3
    Dim speed As Integer = 5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BallLabel.Location.Y <= 25 Then BUp = -1 * BUp
        If BallLabel.Location.Y >= 325 Then BUp = -1 * BUp
        If BallLabel.Location.X <= 15 Then BRight = -1 * BRight
        If BallLabel.Location.X >= 625 And BallLabel.Location.X <= 650 And checkY(BallLabel, PictureBox1) Then BRight = -1 * BRight
        If BallLabel.Location.X >= 625 And checkY(BallLabel, PictureBox1) = False Then gameover()
        BallLabel.Location = New Point(BallLabel.Location.X + BRight * speed, BallLabel.Location.Y + BUp * speed)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        Cursor.Position = New Point(Me.Left + Me.Width / 2, Me.Top + (Me.Height - 25) / 2)
        Timer1.Enabled = True
    End Sub
    Function checkOverlay(cont1 As Control, cont2 As Control) As Boolean
        If checkX(cont1, cont2) And checkY(cont1, cont2) Then Return True
        Return False
    End Function
    Function checkY(cont1 As Control, cont2 As Control) As Boolean
        'cont1 innerhalb cont2
        If cont1.Top >= cont2.Top And cont1.Top <= cont2.Bottom Then Return True
        If cont1.Bottom <= cont2.Bottom And cont1.Bottom >= cont2.Top Then Return True
        'cont2 innerhalb cont1
        If cont2.Top >= cont1.Top And cont2.Top <= cont1.Bottom Then Return True
        If cont2.Bottom <= cont1.Bottom And cont2.Bottom >= cont1.Top Then Return True
        Return False
    End Function
    Function checkX(cont1 As Control, cont2 As Control) As Boolean
        'cont1 innerhalb cont2
        If cont1.Right >= cont2.Right And cont1.Right <= cont2.Left Then Return True
        If cont1.Left <= cont2.Left And cont1.Left >= cont2.Right Then Return True
        'cont2 innerhalb cont1
        If cont2.Right >= cont1.Right And cont2.Right <= cont1.Left Then Return True
        If cont2.Left <= cont1.Left And cont2.Left >= cont1.Right Then Return True
        Return False
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Hide()
        Button1.Show()
        Timer1.Enabled = False
        BallLabel.Location = New Point(51, 30)
    End Sub
    Sub gameover()
        Timer2.Enabled = False
        a = 1
        Label3.Hide()
        Label2.Text = "G"
        Timer2.Enabled = True
        Panel1.Show()
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub
    Dim a As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If a = 0 Then
            Label2.Text = "Ga"
        ElseIf a = 1 Then
            Label2.Text = "Gam"
        ElseIf a = 2 Then
            Label2.Text = "Game"
        ElseIf a = 3 Then
            Label3.Show()
            Label3.Font = New Font(Label3.Font.Name, 10)
        ElseIf a = 4 Then
            Label3.Font = New Font(Label3.Font.Name, 20)
        ElseIf a = 5 Then
            Label3.Font = New Font(Label3.Font.Name, 30)
        ElseIf a = 6 Then
            Label3.Font = New Font(Label3.Font.Name, 40)
        ElseIf a = 7 Then
            Label3.Font = New Font(Label3.Font.Name, 50)
        ElseIf a = 8 Then
            Label3.Font = New Font(Label3.Font.Name, 60)
        ElseIf a = 9 Then
            Label3.Font = New Font(Label3.Font.Name, 72)
        Else
            Timer2.Enabled = False
            a = 1
            Exit Sub
        End If
        a += 1
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Backgrounds.Abrunden(Me, 0, 0, Me.Width, Me.Height, 5)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, Button2.KeyDown, Button1.KeyDown
        If e.KeyData = Keys.Up Then
            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - speed)
        ElseIf e.KeyData = Keys.Down Then
            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + speed)
        End If
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Not Button1.Visible Then
            Label1.Text = (e.Y - (Me.Height - 25) / 2).ToString()
            PictureBox1.Location = New Point(PictureBox1.Location.X, 85 + (e.Y - (Me.Height - 25) / 2))
        End If
    End Sub
End Class
Public Class Backgrounds
    Public Shared Sub Abrunden(was As Control, x As Integer, y As Integer, width As Integer, height As Integer, radius As Integer)
        Dim gp As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
        gp.AddLine(x + radius, y, x + width - radius, y)
        gp.AddArc(x - 1 + width - radius, y, radius, radius, 270, 90)
        gp.AddLine(x + width, y + radius, x + width, y + height - radius)
        gp.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90)

        gp.AddLine(x + width - radius, y + height, x + radius, y + height)
        gp.AddArc(x, y + height - radius, radius, radius, 90, 90)

        gp.AddLine(x, y + height - radius, x, y + radius)
        gp.AddArc(x, y, radius, radius, 180, 90)
        gp.CloseFigure()
        was.Region = New System.Drawing.Region(gp)
        gp.Dispose()
    End Sub
End Class
