<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explorer1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeNodeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForwardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FoldersToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ListViewLargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ListViewSmallImageList As System.Windows.Forms.ImageList

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Explorer1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Users", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gast1")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gast", New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TreeNodeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.FoldersToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gast1 = New System.Windows.Forms.Label()
        Me.User2 = New System.Windows.Forms.Label()
        Me.User1 = New System.Windows.Forms.Label()
        Me.ListViewLargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewSmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Spielstand = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.Spielstand, Me.ToolStripStatusLabel1, Me.username})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(117, 17)
        Me.ToolStripStatusLabel.Text = " Aktueller Spielstand."
        '
        'TreeNodeImageList
        '
        Me.TreeNodeImageList.ImageStream = CType(resources.GetObject("TreeNodeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeNodeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder")
        Me.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripButton, Me.ForwardToolStripButton, Me.ToolStripSeparator7, Me.FoldersToolStripButton, Me.ToolStripSeparator8})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(224, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.Enabled = False
        Me.BackToolStripButton.Image = CType(resources.GetObject("BackToolStripButton.Image"), System.Drawing.Image)
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(64, 22)
        Me.BackToolStripButton.Text = "Zurück"
        Me.BackToolStripButton.ToolTipText = "Zurück zum vorherigen Element"
        '
        'ForwardToolStripButton
        '
        Me.ForwardToolStripButton.Enabled = False
        Me.ForwardToolStripButton.Image = CType(resources.GetObject("ForwardToolStripButton.Image"), System.Drawing.Image)
        Me.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.ForwardToolStripButton.Name = "ForwardToolStripButton"
        Me.ForwardToolStripButton.Size = New System.Drawing.Size(72, 22)
        Me.ForwardToolStripButton.Text = "Vorwärts"
        Me.ForwardToolStripButton.ToolTipText = "Weiter zum nächsten Element"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'FoldersToolStripButton
        '
        Me.FoldersToolStripButton.Checked = True
        Me.FoldersToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FoldersToolStripButton.Image = CType(resources.GetObject("FoldersToolStripButton.Image"), System.Drawing.Image)
        Me.FoldersToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.FoldersToolStripButton.Name = "FoldersToolStripButton"
        Me.FoldersToolStripButton.Size = New System.Drawing.Size(64, 22)
        Me.FoldersToolStripButton.Text = "Ordner"
        Me.FoldersToolStripButton.ToolTipText = "Ordneransicht umschalten"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.SplitContainer)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(632, 406)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(632, 453)
        Me.ToolStripContainer.TabIndex = 7
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.TreeView)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer.Size = New System.Drawing.Size(632, 406)
        Me.SplitContainer.SplitterDistance = 211
        Me.SplitContainer.TabIndex = 0
        Me.SplitContainer.Text = "SplitContainer1"
        '
        'TreeView
        '
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView.ImageIndex = 0
        Me.TreeView.ImageList = Me.TreeNodeImageList
        Me.TreeView.Location = New System.Drawing.Point(0, 0)
        Me.TreeView.Name = "TreeView"
        TreeNode1.Name = "Knoten1"
        TreeNode1.Text = "User1"
        TreeNode2.Name = "Knoten3"
        TreeNode2.Text = "User2"
        TreeNode3.Name = "Knoten0"
        TreeNode3.Text = "Users"
        TreeNode4.Name = "Knoten5"
        TreeNode4.Text = "Gast1"
        TreeNode5.Name = "Knoten4"
        TreeNode5.Text = "Gast"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5})
        Me.TreeView.SelectedImageIndex = 0
        Me.TreeView.ShowLines = False
        Me.TreeView.Size = New System.Drawing.Size(211, 406)
        Me.TreeView.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(417, 406)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Gast1)
        Me.Panel1.Controls.Add(Me.User2)
        Me.Panel1.Controls.Add(Me.User1)
        Me.Panel1.Location = New System.Drawing.Point(3, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.spexalolabyrinto.My.MySettings.Default, "Gast1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label3.Location = New System.Drawing.Point(45, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = Global.spexalolabyrinto.My.MySettings.Default.Gast1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.spexalolabyrinto.My.MySettings.Default, "User2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Location = New System.Drawing.Point(60, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = Global.spexalolabyrinto.My.MySettings.Default.User2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.spexalolabyrinto.My.MySettings.Default, "User1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = Global.spexalolabyrinto.My.MySettings.Default.User1
        '
        'Gast1
        '
        Me.Gast1.AutoSize = True
        Me.Gast1.Location = New System.Drawing.Point(8, 64)
        Me.Gast1.Name = "Gast1"
        Me.Gast1.Size = New System.Drawing.Size(0, 13)
        Me.Gast1.TabIndex = 2
        '
        'User2
        '
        Me.User2.AutoSize = True
        Me.User2.Location = New System.Drawing.Point(8, 38)
        Me.User2.Name = "User2"
        Me.User2.Size = New System.Drawing.Size(0, 13)
        Me.User2.TabIndex = 1
        '
        'User1
        '
        Me.User1.AutoSize = True
        Me.User1.Location = New System.Drawing.Point(8, 12)
        Me.User1.Name = "User1"
        Me.User1.Size = New System.Drawing.Size(0, 13)
        Me.User1.TabIndex = 0
        '
        'ListViewLargeImageList
        '
        Me.ListViewLargeImageList.ImageStream = CType(resources.GetObject("ListViewLargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewLargeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewLargeImageList.Images.SetKeyName(0, "Graph1")
        Me.ListViewLargeImageList.Images.SetKeyName(1, "Graph2")
        Me.ListViewLargeImageList.Images.SetKeyName(2, "Graph3")
        '
        'ListViewSmallImageList
        '
        Me.ListViewSmallImageList.ImageStream = CType(resources.GetObject("ListViewSmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewSmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewSmallImageList.Images.SetKeyName(0, "Graph1")
        Me.ListViewSmallImageList.Images.SetKeyName(1, "Graph2")
        Me.ListViewSmallImageList.Images.SetKeyName(2, "Graph3")
        '
        'Spielstand
        '
        Me.Spielstand.Name = "Spielstand"
        Me.Spielstand.Size = New System.Drawing.Size(13, 17)
        Me.Spielstand.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = " Name:"
        '
        'username
        '
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(120, 17)
        Me.username.Text = "ToolStripStatusLabel2"
        '
        'Explorer1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Location = New System.Drawing.Point(280, 100)
        Me.MaximizeBox = False
        Me.Name = "Explorer1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "user explorer"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Gast1 As System.Windows.Forms.Label
    Friend WithEvents User2 As System.Windows.Forms.Label
    Friend WithEvents User1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Spielstand As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents username As System.Windows.Forms.ToolStripStatusLabel

End Class
