
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
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.ComponentModel

#End Region

Public Class frmNetworkListener

#Region "Member variable declaration"

    Private ipHostInfo As IPHostEntry
    Private ipAddress As IPAddress
    Private localEndPoint As IPEndPoint
    Private WithEvents bgWrkrUDPLsnr As BackgroundWorker
    Private listener As Socket
    Private udpListener As UdpClient
    Private isConnected As Boolean
    Private isTCP As Boolean = False
    Private Delegate Sub dlgtAppendText(ByVal txt As String)
    Private logTxt As dlgtAppendText

#End Region

#Region "Appender and network callback handlers"

    Private Sub AppendText(ByVal txt As String)
        If txt.Contains("Debug") Or txt.Contains("DEBUG") Then
            txtLog.SelectionColor = cDEBUG
        ElseIf txt.Contains("Error") Or txt.Contains("ERROR") Then
            txtLog.SelectionColor = cERROR
        ElseIf txt.Contains("Fatal") Or txt.Contains("FATAL") Then
            txtLog.SelectionColor = cFATAL
        ElseIf txt.Contains("Info") Or txt.Contains("INFO") Then
            txtLog.SelectionColor = cINFO
        ElseIf txt.Contains("Trace") Or txt.Contains("TRACE") Then
            txtLog.SelectionColor = cTRACE
        ElseIf txt.Contains("Warn") Or txt.Contains("WARN") Then
            txtLog.SelectionColor = cWARN
        Else
            txtLog.SelectionColor = Color.Black
        End If
        txtLog.SelectedText = txt + System.Environment.NewLine
    End Sub

    Private Sub AcceptConnectionCallback(ByVal ar As IAsyncResult)
        Try
            If isConnected = False Then Exit Sub
            Dim lsnr As Socket = CType(ar.AsyncState, Socket)
            Dim handler As Socket = lsnr.EndAccept(ar)
            Dim state As New StateObject
            state.workSocket = handler
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, New AsyncCallback(AddressOf DateReadCallback), state)
            lsnr.BeginAccept(New AsyncCallback(AddressOf AcceptConnectionCallback), lsnr)
        Catch ex As Exception
            'Do nothing, it will occur due to invalid socket error
        End Try
    End Sub

    Private Sub DateReadCallback(ByVal ar As IAsyncResult)
        If isConnected = False Then Exit Sub
        Dim content As String = String.Empty
        Try
            Dim state As StateObject = CType(ar.AsyncState, StateObject)
            Dim handler As Socket = state.workSocket
            Dim bytesRead As Integer = handler.EndReceive(ar)
            If bytesRead > 0 Then
                content = Encoding.ASCII.GetString(state.buffer, 0, bytesRead)
                For Each tmpStr As String In content.Split(New Char() {Chr(10), Chr(13)})
                    If tmpStr <> String.Empty Then
                        Me.Invoke(logTxt, New Object() {tmpStr})
                    End If
                Next
                ' Not all data received. Get more.
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, New AsyncCallback(AddressOf DateReadCallback), state)
            End If
        Catch ex As SocketException
            listener.BeginAccept(New AsyncCallback(AddressOf AcceptConnectionCallback), listener)
        End Try
    End Sub

    Private Sub bgWrkrUDPLsnr_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWrkrUDPLsnr.DoWork
        While isConnected
            Try
                Dim content As String = Encoding.ASCII.GetString(udpListener.Receive(localEndPoint))
                For Each tmpStr As String In content.Split(New Char() {Chr(10), Chr(13)})
                    If tmpStr <> String.Empty Then
                        Me.Invoke(logTxt, New Object() {tmpStr})
                    End If
                Next
            Catch ex As Exception
                'Do nothing
            End Try
            Thread.Sleep(100)
        End While
    End Sub

#End Region

#Region "Button Click event handler"

    Private Sub btnStartListenining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartListenining.Click
        Try
            logTxt = New dlgtAppendText(AddressOf AppendText)
            ipHostInfo = Dns.GetHostEntry(Dns.GetHostName())
            ipAddress = ipHostInfo.AddressList(0)
            localEndPoint = New IPEndPoint(ipAddress, txtPort.Text)
            isConnected = True
            If optTCP.Checked Then
                isTCP = True
                listener = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                ' Bind the socket to the local endpoint and listen for incoming connections.
                listener.Bind(localEndPoint)
                listener.Listen(100)
                listener.BeginAccept(New AsyncCallback(AddressOf AcceptConnectionCallback), listener)
            Else
                isTCP = False
                If udpListener Is Nothing Then udpListener = New UdpClient(localEndPoint)
                bgWrkrUDPLsnr = New BackgroundWorker()
                bgWrkrUDPLsnr.RunWorkerAsync()
            End If

            btnStartListenining.Enabled = False
            btnStopListenining.Enabled = True
            If isTCP Then
                Me.StatusLabel.Text = "Listening log events on TCP port : " + txtPort.Text
            Else
                Me.StatusLabel.Text = "Listening log events on UDP port : " + txtPort.Text
            End If
            Me.picProcessing.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in listening", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnStopListenining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopListenining.Click
        If isTCP Then listener.Close()
        isConnected = False
        Me.picProcessing.Visible = False
        Me.StatusLabel.Text = String.Empty
        btnStartListenining.Enabled = True
        btnStopListenining.Enabled = False
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
