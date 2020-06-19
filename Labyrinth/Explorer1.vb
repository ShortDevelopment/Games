Public Class Explorer1
    Private Sub TreeView_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        If TreeView.SelectedNode.Text = "User1" Then
            TextBox1.Text = "Name:" + "User1" + vbNewLine + "Password:" + "0000" + vbNewLine + "Spielstand:" + My.Settings.User1
        ElseIf TreeView.SelectedNode.Text = "User2" Then
            TextBox1.Text = "Name:" + "User2" + vbNewLine + "Password:" + "0000" + vbNewLine + "Spielstand:" + My.Settings.User2
        ElseIf TreeView.SelectedNode.Text = "Gast1" Then
            TextBox1.Text = "Name:" + "Gast1" + vbNewLine + "Password:" + "0000" + vbNewLine + "Spielstand:" + My.Settings.Gast1
        End If
    End Sub
    Private Sub Explorer1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Spielstand.Text = Form4.TextBox1.Text
        username.Text = control.Username.Text
    End Sub
End Class
