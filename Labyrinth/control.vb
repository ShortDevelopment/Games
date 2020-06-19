Public Class control
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        GroupBox1.Show()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "0000" Then
            Username.Text = ComboBox1.Text
            Form4.Show()
        End If
        GroupBox1.Hide()
    End Sub
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Explorer1.Show()
        If Username.Text = "Gast1" Then
            Explorer1.TreeView.Nodes(0).Remove()
        End If
    End Sub
    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Form4.Close()
    End Sub
    Private Sub control_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class