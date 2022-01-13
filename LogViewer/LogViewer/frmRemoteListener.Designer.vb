<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoteListener
    'Inherits System.Windows.Forms.Form
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemoteListener))
        Me.picProcessing = New System.Windows.Forms.PictureBox
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLog = New System.Windows.Forms.RichTextBox
        Me.rtfMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtURI = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnStopListenining = New System.Windows.Forms.Button
        Me.btnStartListenining = New System.Windows.Forms.Button
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.optHTTP = New System.Windows.Forms.RadioButton
        Me.optTCP = New System.Windows.Forms.RadioButton
        Me.ToolTipCntrl = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picProcessing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.rtfMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picProcessing
        '
        Me.picProcessing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picProcessing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProcessing.Image = Global.LogViewer.My.Resources.Resources.processing
        Me.picProcessing.Location = New System.Drawing.Point(521, 388)
        Me.picProcessing.Name = "picProcessing"
        Me.picProcessing.Size = New System.Drawing.Size(161, 17)
        Me.picProcessing.TabIndex = 13
        Me.picProcessing.TabStop = False
        Me.picProcessing.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 386)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(707, 22)
        Me.StatusStrip.TabIndex = 12
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtLog)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(687, 316)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.White
        Me.txtLog.ContextMenuStrip = Me.rtfMenu
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(3, 17)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(681, 296)
        Me.txtLog.TabIndex = 0
        Me.txtLog.Text = ""
        '
        'rtfMenu
        '
        Me.rtfMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.rtfMenu.Name = "rtfMenu"
        Me.rtfMenu.Size = New System.Drawing.Size(129, 70)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtURI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnStopListenining)
        Me.GroupBox1.Controls.Add(Me.btnStartListenining)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.optHTTP)
        Me.GroupBox1.Controls.Add(Me.optTCP)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "URI :"
        '
        'txtURI
        '
        Me.txtURI.Location = New System.Drawing.Point(354, 20)
        Me.txtURI.Name = "txtURI"
        Me.txtURI.Size = New System.Drawing.Size(79, 21)
        Me.txtURI.TabIndex = 3
        Me.txtURI.Text = "LoggingSink"
        Me.ToolTipCntrl.SetToolTip(Me.txtURI, "Specify the URI for Remoting listener. e.g. 11001")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Port :"
        '
        'btnStopListenining
        '
        Me.btnStopListenining.Enabled = False
        Me.btnStopListenining.Image = Global.LogViewer.My.Resources.Resources.stophand
        Me.btnStopListenining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStopListenining.Location = New System.Drawing.Point(562, 19)
        Me.btnStopListenining.Name = "btnStopListenining"
        Me.btnStopListenining.Size = New System.Drawing.Size(112, 23)
        Me.btnStopListenining.TabIndex = 5
        Me.btnStopListenining.Text = "Stop Listenining"
        Me.btnStopListenining.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipCntrl.SetToolTip(Me.btnStopListenining, "Click to Stop listening for Remote Log events")
        Me.btnStopListenining.UseVisualStyleBackColor = True
        '
        'btnStartListenining
        '
        Me.btnStartListenining.Image = Global.LogViewer.My.Resources.Resources.start
        Me.btnStartListenining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartListenining.Location = New System.Drawing.Point(439, 19)
        Me.btnStartListenining.Name = "btnStartListenining"
        Me.btnStartListenining.Size = New System.Drawing.Size(115, 23)
        Me.btnStartListenining.TabIndex = 4
        Me.btnStartListenining.Text = "Start Listenining"
        Me.btnStartListenining.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipCntrl.SetToolTip(Me.btnStartListenining, "Click to Start listening for Remote Log events")
        Me.btnStartListenining.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(241, 21)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(60, 21)
        Me.txtPort.TabIndex = 2
        Me.ToolTipCntrl.SetToolTip(Me.txtPort, "Specify the Port number to be used for Remoting listener. e.g. 11001" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please use " & _
                "port number above 1024.")
        '
        'optHTTP
        '
        Me.optHTTP.AutoSize = True
        Me.optHTTP.Location = New System.Drawing.Point(112, 23)
        Me.optHTTP.Name = "optHTTP"
        Me.optHTTP.Size = New System.Drawing.Size(50, 17)
        Me.optHTTP.TabIndex = 1
        Me.optHTTP.Text = "HTTP"
        Me.ToolTipCntrl.SetToolTip(Me.optHTTP, "Select to use HTTP protocal for Remote Listener")
        Me.optHTTP.UseVisualStyleBackColor = True
        '
        'optTCP
        '
        Me.optTCP.AutoSize = True
        Me.optTCP.Checked = True
        Me.optTCP.Location = New System.Drawing.Point(22, 23)
        Me.optTCP.Name = "optTCP"
        Me.optTCP.Size = New System.Drawing.Size(44, 17)
        Me.optTCP.TabIndex = 0
        Me.optTCP.TabStop = True
        Me.optTCP.Text = "TCP"
        Me.ToolTipCntrl.SetToolTip(Me.optTCP, "Select to use TCP protocal for Remote Listener")
        Me.optTCP.UseVisualStyleBackColor = True
        '
        'ToolTipCntrl
        '
        Me.ToolTipCntrl.ForeColor = System.Drawing.Color.Navy
        Me.ToolTipCntrl.IsBalloon = True
        Me.ToolTipCntrl.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipCntrl.ToolTipTitle = "Hint :"
        '
        'frmRemoteListener
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 408)
        Me.Controls.Add(Me.picProcessing)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRemoteListener"
        Me.TabText = "Remoting Listener"
        Me.Text = "Remoting Listener"
        CType(Me.picProcessing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.rtfMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picProcessing As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLog As System.Windows.Forms.RichTextBox
    Friend WithEvents rtfMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStopListenining As System.Windows.Forms.Button
    Friend WithEvents btnStartListenining As System.Windows.Forms.Button
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents optHTTP As System.Windows.Forms.RadioButton
    Friend WithEvents optTCP As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtURI As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipCntrl As System.Windows.Forms.ToolTip
End Class
