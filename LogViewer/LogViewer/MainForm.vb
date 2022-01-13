#Region "Copyright © 2008 Ashu Fouzdar. All rights reserved."
'
'Copyright © 2008 Ashu Fouzdar. All rights reserved.
'
'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions
'are met:
'
'1. Redistributions of source code must retain the above copyright
'   notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright
'   notice, this list of conditions and the following disclaimer in the
'   documentation and/or other materials provided with the distribution.
'3. The name of the author may not be used to endorse or promote products
'   derived from this software without specific prior written permission.
'
'THIS SOFTWARE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
'IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
'OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
'IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
'NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
'DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
'THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
'(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
'THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
' 
#End Region

#Region "Imports"

Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI.Docking

#End Region

Public Class MainForm

#Region "Member variable declaration"
    Private m_ChildFormNumber As Integer = 0
#End Region

#Region "Form Load and MenuStripButton Click handler"

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DockParent.ShowDocumentIcon = True
        ReadColorSetting()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim dlgSetting As New DlgColorSetting()
        If dlgSetting.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveColorSeting()
        End If
    End Sub

    Private Sub FileListenerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListenerToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim childWnd As New frmFileListener
        m_ChildFormNumber += 1
        childWnd.TabText = "Viewer : " & m_ChildFormNumber
        ' Make it a child of dock parent.
        If (Me.DockParent.DocumentStyle = DocumentStyle.SystemMdi) Then
            childWnd.MdiParent = Me
            childWnd.Show()
        Else
            childWnd.Show(Me.DockParent)
        End If
    End Sub

    Private Sub TCPUDPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCPUDPToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim childWnd As New frmNetworkListener
        m_ChildFormNumber += 1
        childWnd.TabText = "Viewer : " & m_ChildFormNumber
        ' Make it a child of dock parent.
        If (Me.DockParent.DocumentStyle = DocumentStyle.SystemMdi) Then
            childWnd.MdiParent = Me
            childWnd.Show()
        Else
            childWnd.Show(Me.DockParent)
        End If
    End Sub

    Private Sub RemotingListenerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemotingListenerToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim childWnd As New frmRemoteListener()
        m_ChildFormNumber += 1
        childWnd.TabText = "Viewer : " & m_ChildFormNumber
        ' Make it a child of dock parent.
        If (Me.DockParent.DocumentStyle = DocumentStyle.SystemMdi) Then
            childWnd.MdiParent = Me
            childWnd.Show()
        Else
            childWnd.Show(Me.DockParent)
        End If
    End Sub

    Private Sub NewNWLogToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewNWLogToolStripButton.Click
        TCPUDPToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub NewFileLogToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFileLogToolStripButton.Click
        FileListenerToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub NewRemoteLogToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRemoteLogToolStripButton.Click
        RemotingListenerToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As DockContent In Me.DockParent.Documents
            ChildForm.Close()
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abt As New AboutBox()
        abt.ShowDialog()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        NewNWLogToolStripButton_Click(Me, e)
    End Sub

#End Region

End Class
