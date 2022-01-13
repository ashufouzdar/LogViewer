
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
Imports System.IO
#End Region

Public Class frmFileListener

#Region "Member variable declaration's"

    Private logRdr As StreamReader
    Private logFilename As String
    Private line As String

#End Region

#Region "Appender and File watcher event handler"

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

    Private Sub LogFileWatcher_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles LogFileWatcher.Changed
        If e.ChangeType = WatcherChangeTypes.Changed Then
            Try
                If logRdr Is Nothing Then logRdr = New StreamReader(New FileStream(logFilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), True)
                Do Until logRdr.EndOfStream
                    line = logRdr.ReadLine()
                    If line <> String.Empty Then AppendText(line)
                Loop
            Catch ex As Exception

            End Try
        End If
    End Sub

#End Region

#Region "Button Click event handler"

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim dlgOpenLog As New OpenFileDialog()
            dlgOpenLog.DefaultExt = "*.*"
            dlgOpenLog.Filter = "All files|*.*"
            dlgOpenLog.FilterIndex = 1
            dlgOpenLog.SupportMultiDottedExtensions = True
            dlgOpenLog.CheckFileExists = False
            dlgOpenLog.ValidateNames = True
            If dlgOpenLog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtPort.Text = dlgOpenLog.FileName
                logFilename = dlgOpenLog.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in opening log", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnStartListenining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartListenining.Click
        Try
            btnStartListenining.Enabled = False
            btnStopListenining.Enabled = True
            Me.StatusLabel.Text = "Listening log events on log file : " + logFilename
            Me.picProcessing.Visible = True
            LogFileWatcher.Filter = Path.GetFileName(logFilename)
            LogFileWatcher.Path = Path.GetDirectoryName(logFilename)
            LogFileWatcher.IncludeSubdirectories = False
            LogFileWatcher.NotifyFilter = NotifyFilters.Size Or NotifyFilters.LastWrite Or NotifyFilters.LastWrite
            LogFileWatcher.EnableRaisingEvents = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in listening", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnStopListenining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopListenining.Click
        LogFileWatcher.EnableRaisingEvents = False
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