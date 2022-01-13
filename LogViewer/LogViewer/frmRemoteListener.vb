
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

Imports System
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Runtime.Remoting.Channels.Tcp

#End Region

Public Class frmRemoteListener

#Region "Member variable declaration"
    Private channel As IChannel
    Private refObject As ObjRef
    Private WithEvents localObject As RemoteSink
    Private Delegate Sub dlgtLogEvents(ByVal events() As log4net.Core.LoggingEvent)
    Private LogEvents As dlgtLogEvents
#End Region

#Region "Appender method and events"

    Private Sub AppendEvents(ByVal events() As log4net.Core.LoggingEvent)
        For Each evt As log4net.Core.LoggingEvent In events
            If evt.Level = log4net.Core.Level.Debug Then
                txtLog.SelectionColor = cDEBUG
            ElseIf evt.Level = log4net.Core.Level.Error Then
                txtLog.SelectionColor = cERROR
            ElseIf evt.Level = log4net.Core.Level.Fatal Then
                txtLog.SelectionColor = cFATAL
            ElseIf evt.Level = log4net.Core.Level.Info Then
                txtLog.SelectionColor = cINFO
            ElseIf evt.Level = log4net.Core.Level.Trace Then
                txtLog.SelectionColor = cTRACE
            ElseIf evt.Level = log4net.Core.Level.Warn Then
                txtLog.SelectionColor = cWARN
            Else
                txtLog.SelectionColor = Color.Black
            End If
            txtLog.SelectedText = String.Format("Level :{1}{0}Logger :{2}{0}User :{3}{0}TimeStamp :{4}{0}Message :{5}{0}-----------------------------------{0}", System.Environment.NewLine, evt.Level, evt.LoggerName, evt.UserName, evt.TimeStamp, evt.RenderedMessage)
        Next
    End Sub

    Private Sub localObject_Log(ByVal events() As log4net.Core.LoggingEvent) Handles localObject.Log
        Try
            If Me.InvokeRequired() Then
                Me.Invoke(LogEvents, New Object() {events})
            Else
                AppendEvents(events)
            End If
        Catch ex As Exception
            'Do nothing since sending application is dead
        End Try
    End Sub

#End Region

#Region "Button Click event handler"

    Private Sub btnStartListenining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartListenining.Click
        Try
            LogEvents = New dlgtLogEvents(AddressOf AppendEvents)
            localObject = New RemoteSink()
            If optTCP.Checked Then
                channel = New TcpServerChannel(txtPort.Text)
            Else
                channel = New HttpServerChannel(txtPort.Text)
            End If
            ChannelServices.RegisterChannel(channel, False)
            If txtURI.Text = String.Empty Then
                refObject = RemotingServices.Marshal(localObject, "LoggingSink")
            Else
                refObject = RemotingServices.Marshal(localObject, txtURI.Text)
            End If
            Me.StatusLabel.Text = "Listening log events on Remoting URI : " + refObject.URI
            Me.picProcessing.Visible = True
            btnStartListenining.Enabled = False
            btnStopListenining.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in listening", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnStopListenining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopListenining.Click
        Try
            Me.picProcessing.Visible = False
            Me.StatusLabel.Text = String.Empty
            btnStartListenining.Enabled = True
            btnStopListenining.Enabled = False
            RemotingServices.Disconnect(localObject)
            ChannelServices.UnregisterChannel(channel)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in stop listening", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#End Region

#Region "Richtextbox context menu item handlers"

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtLog.SelectAll()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        txtLog.Clear()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Try
            Dim dlgSave As New SaveFileDialog()
            dlgSave.DefaultExt = "*.txt"
            dlgSave.Filter = "Txt File|*.txt"
            dlgSave.FilterIndex = 1
            dlgSave.OverwritePrompt = True
            dlgSave.SupportMultiDottedExtensions = True
            dlgSave.CheckPathExists = True
            dlgSave.ValidateNames = True
            If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtLog.SaveFile(dlgSave.FileName, RichTextBoxStreamType.PlainText)
                MessageBox.Show("Exported to : " + dlgSave.FileName, "Export successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in export", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region

End Class