<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DockParent = New WeifenLuo.WinFormsUI.Docking.DockPanel
        Me.NewFileLogToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.NewNWLogToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.NewRemoteLogToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TCPUDPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemotingListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(35, 20)
        Me.FileMenu.Text = "&File"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(44, 20)
        Me.ToolsMenu.Text = "&Tools"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(62, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(40, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.aboutdialog
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileLogToolStripButton, Me.NewNWLogToolStripButton, Me.NewRemoteLogToolStripButton, Me.ToolStripSeparator2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DockParent
        '
        Me.DockParent.ActiveAutoHideContent = Nothing
        Me.DockParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockParent.Location = New System.Drawing.Point(0, 49)
        Me.DockParent.Name = "DockParent"
        Me.DockParent.Size = New System.Drawing.Size(632, 404)
        Me.DockParent.TabIndex = 9
        '
        'NewFileLogToolStripButton
        '
        Me.NewFileLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewFileLogToolStripButton.Image = Global.LogViewer.My.Resources.Resources.log
        Me.NewFileLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewFileLogToolStripButton.Name = "NewFileLogToolStripButton"
        Me.NewFileLogToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewFileLogToolStripButton.Text = "New Log file listener"
        '
        'NewNWLogToolStripButton
        '
        Me.NewNWLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewNWLogToolStripButton.Image = Global.LogViewer.My.Resources.Resources.net
        Me.NewNWLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewNWLogToolStripButton.Name = "NewNWLogToolStripButton"
        Me.NewNWLogToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewNWLogToolStripButton.Text = "New TCP/UDP listener"
        '
        'NewRemoteLogToolStripButton
        '
        Me.NewRemoteLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewRemoteLogToolStripButton.Image = Global.LogViewer.My.Resources.Resources.remotelog
        Me.NewRemoteLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewRemoteLogToolStripButton.Name = "NewRemoteLogToolStripButton"
        Me.NewRemoteLogToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewRemoteLogToolStripButton.Text = "New Remoting listener"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileListenerToolStripMenuItem, Me.TCPUDPToolStripMenuItem, Me.RemotingListenerToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.newItem
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'FileListenerToolStripMenuItem
        '
        Me.FileListenerToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.log
        Me.FileListenerToolStripMenuItem.Name = "FileListenerToolStripMenuItem"
        Me.FileListenerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileListenerToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.FileListenerToolStripMenuItem.Text = "File Listener"
        '
        'TCPUDPToolStripMenuItem
        '
        Me.TCPUDPToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.net
        Me.TCPUDPToolStripMenuItem.Name = "TCPUDPToolStripMenuItem"
        Me.TCPUDPToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.TCPUDPToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.TCPUDPToolStripMenuItem.Text = "TCP/UDP Listener"
        '
        'RemotingListenerToolStripMenuItem
        '
        Me.RemotingListenerToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.remotelog
        Me.RemotingListenerToolStripMenuItem.Name = "RemotingListenerToolStripMenuItem"
        Me.RemotingListenerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.RemotingListenerToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RemotingListenerToolStripMenuItem.Text = "Remoting Listener"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.exitApp
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.settingicon
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.newItem
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Image = Global.LogViewer.My.Resources.Resources.closeWin
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.DockParent)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "LogViewer"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockParent As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents TCPUDPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileListenerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemotingListenerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFileLogToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewNWLogToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewRemoteLogToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
End Class
