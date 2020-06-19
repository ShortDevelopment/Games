Public Class Form2
    Dim a As Integer = -17
    Dim b As Integer = 255
    Dim c As Integer
    Dim ab As Boolean = True
    Dim bb As Boolean = False
    Dim cb As Boolean = True
    Private Sub Label1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Label1.MouseEnter, Label2.MouseEnter, Label3.MouseEnter, Label4.MouseEnter, Label5.MouseEnter, Label6.MouseEnter, Label7.MouseEnter, Label8.MouseEnter, Label9.MouseEnter, Label10.MouseEnter, Label12.MouseEnter, Label13.MouseEnter, Label14.MouseEnter, Label15.MouseEnter, Label16.MouseEnter, Label17.MouseEnter
        Dim a As Integer = Form4.TextBox1.Text - 1
        If a = 0 Then
            Me.Close()
            Form4.Visible = True
            Form4.Label32.Visible = True
            Try
                My.Computer.Audio.Play("C:\Windows\Media\Alarm01.wav")
            Catch ex As Exception
            End Try
            Exit Sub
        End If
        Try
            My.Computer.Audio.Play("C:\Windows\Media\chord.wav")
        Catch ex As Exception
        End Try
        Cursor.Position = Point.Ceiling(New PointF(0, 0))
        Form4.TextBox1.Text = a
    End Sub
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Enabled = True
        Label11.BackColor = Color.Lime
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If a = -17 Then ab = False
        If a = 200 Then ab = True
        If ab = True Then
            Label8.Location = Point.Ceiling(New PointF(77, a - 1))
            a = a - 1
        Else
            Label8.Location = Point.Ceiling(New PointF(77, a + 1))
            a += 1
        End If


        If b = 255 Then bb = False
        If b = 500 Then bb = True
        If bb = True Then
            Label9.Location = Point.Ceiling(New PointF(b - 1, 112))
            b = b - 1
        Else
            Label9.Location = Point.Ceiling(New PointF(b + 1, 112))
            b += 1
        End If

        If c = -15 Then cb = False
        If c = 75 Then cb = True
        If cb = True Then
            Label15.Location = Point.Ceiling(New PointF(c - 1, 204))
            c = c - 1
        Else
            Label15.Location = Point.Ceiling(New PointF(c + 1, 204))
            c += 1
        End If
        Timer1.Start()
    End Sub
    Private Sub Label11_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label11.MouseEnter
        Try
            My.Computer.Audio.Play("C:\Windows\Media\chimes.wav")
        Catch ex As Exception
        End Try
        Dim a As Integer = Form4.TextBox1.Text
        Form4.TextBox1.Text = a + 3
        Cursor.Position = Point.Ceiling(New PointF(0, 0))
    End Sub
    Private Sub Label18_MouseEnter(sender As Object, e As EventArgs) Handles Label18.MouseEnter
        Timer2.Enabled = True
        Label11.BackColor = Color.Lime
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim rand As New Random
        Dim x, y As Integer
        Dim a As Boolean = True
        Label11.Text = 1
        While a
            Label11.Text = Int(Label11.Text) + 1
            x = Label11.Location.X + rand.Next(-30, 30)

            If Not x > -1 Or x < 591 Then a = False
        End While
        a = False
        While a = False
            y = Label11.Location.Y + rand.Next(-30, 30)
            If Not y > -1 Or y < 425 Then a = True
        End While
        Label11.Location = New Point(x, y)
    End Sub
End Class