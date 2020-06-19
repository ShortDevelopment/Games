Imports System.Runtime.InteropServices
Public Class Form4
    Dim a, b, c, d, e, f, g, h As Boolean
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Label15.Location = Point.Ceiling(New PointF(177, 76)) Then a = True
        If Label15.Location = Point.Ceiling(New PointF(177, 125)) Then a = False
        If a = False Then Label15.Location = Point.Ceiling(New PointF(177, Label15.Location.Y - 1)) ' 177; 76; 177; 125
        If a = True Then Label15.Location = Point.Ceiling(New PointF(177, Label15.Location.Y + 1))
        If Label17.Location = Point.Ceiling(New PointF(80, 227)) Then d = False
        If Label17.Location = Point.Ceiling(New PointF(194, 227)) Then d = True
        If d = False Then Label17.Location = Point.Ceiling(New PointF(Label17.Location.X + 1, 227))
        If d = True Then Label17.Location = Point.Ceiling(New PointF(Label17.Location.X - 1, 227))

        ' label18 1.291; 138 2.291; 138 label23 1.347; 138 2.374; 138
        If Label28.Location = Point.Ceiling(New PointF(347, 184)) Then f = False
        If Label28.Location = Point.Ceiling(New PointF(365, 184)) Then f = True
        If f = False Then Label28.Location = Point.Ceiling(New PointF(Label28.Location.X + 1, 184))
        If f = True Then Label28.Location = Point.Ceiling(New PointF(Label28.Location.X - 1, 184))
        If f = False Then Label29.Location = Point.Ceiling(New PointF(Label29.Location.X - 1, 184))
        If f = True Then Label29.Location = Point.Ceiling(New PointF(Label29.Location.X + 1, 184))
        If f = False Then Label18.Location = Point.Ceiling(New PointF(Label18.Location.X + 1, 138))
        If f = True Then Label18.Location = Point.Ceiling(New PointF(Label18.Location.X - 1, 138))
        If f = False Then Label23.Location = Point.Ceiling(New PointF(Label23.Location.X - 1, 138))
        If f = True Then Label23.Location = Point.Ceiling(New PointF(Label23.Location.X + 1, 138))
        If f = False Then Label25.Location = Point.Ceiling(New PointF(Label25.Location.X + 1, 99))
        If f = True Then Label25.Location = Point.Ceiling(New PointF(Label25.Location.X - 1, 99))
        If f = False Then Label24.Location = Point.Ceiling(New PointF(Label24.Location.X - 1, 99))
        If f = True Then Label24.Location = Point.Ceiling(New PointF(Label24.Location.X + 1, 99))
        If Label33.Location = Point.Ceiling(New PointF(238, -45)) Then h = False
        If Label33.Location = Point.Ceiling(New PointF(238, 80)) Then h = True
        If h = False Then Label33.Location = Point.Ceiling(New PointF(238, Label33.Location.Y + 1))
        If h = True Then Label33.Location = Point.Ceiling(New PointF(238, Label33.Location.Y - 1))
        '238; 8
        Timer1.Start()
    End Sub
    Private Sub wallcrash() Handles Label1.MouseEnter, Label2.MouseEnter, Label3.MouseEnter, Label4.MouseEnter, Label5.MouseEnter, Label6.MouseEnter, Label8.MouseEnter, Label9.MouseEnter, Label7.MouseEnter, Label10.MouseEnter, Label11.MouseEnter, Label12.MouseEnter, Label13.MouseEnter, Label14.MouseEnter, Label15.MouseEnter, Label16.MouseEnter, Label18.MouseEnter, Label19.MouseEnter, Label20.MouseEnter, Label21.MouseEnter, Label22.MouseEnter, Label23.MouseEnter, Label24.MouseEnter, Label25.MouseEnter, Label26.MouseEnter, Label27.MouseEnter, Label28.MouseEnter, Label29.MouseEnter
        Cursor.Position = Point.Ceiling(New PointF(0, 0))
        Dim a As Integer = TextBox1.Text - 1
        If a = 0 Then
            Label32.Visible = True
            Button1.Visible = True
            Exit Sub
        End If
        TextBox1.Text = a
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If Label14.Location = Point.Ceiling(New PointF(148, 173)) Then b = True
        If Label14.Location = Point.Ceiling(New PointF(148, 139)) Then b = False
        If b = False Then Label14.Location = Point.Ceiling(New PointF(148, 173))
        If b = True Then Label14.Location = Point.Ceiling(New PointF(148, 139))
        If Label13.Location = Point.Ceiling(New PointF(113, 138)) Then c = True
        If Label13.Location = Point.Ceiling(New PointF(113, 173)) Then c = False
        If c = False Then Label13.Location = Point.Ceiling(New PointF(113, 138))
        If c = True Then Label13.Location = Point.Ceiling(New PointF(113, 173)) '80, 227; 179, 227
    End Sub
    Private Sub Label31_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label31.MouseEnter
        Dim a As Integer = TextBox1.Text
        TextBox1.Text = a + 1
        Cursor.Position = Point.Ceiling(New PointF(0, 0))
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label32.Visible = False
        Button1.Visible = False
        TextBox1.Text = "10"
        Cursor.Position = Point.Ceiling(New PointF(0, 0))
    End Sub
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class
