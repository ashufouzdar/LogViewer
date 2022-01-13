
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

Module CommonSetting
    'Dim key As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\FSDC", True)
    Public cDEBUG As Color
    Public cERROR As Color
    Public cFATAL As Color
    Public cINFO As Color
    Public cTRACE As Color
    Public cWARN As Color

    Public Sub ReadColorSetting()
        Dim key As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\FSDC", True)
        If key IsNot Nothing Then
            Dim tmpColor As Integer
            tmpColor = Convert.ToInt32(key.GetValue("DEBUG", Color.Blue.ToArgb()))
            cDEBUG = Color.FromArgb(tmpColor)

            tmpColor = Convert.ToInt32(key.GetValue("ERROR", Color.DarkRed.ToArgb()))
            cERROR = Color.FromArgb(tmpColor)

            tmpColor = Convert.ToInt32(key.GetValue("FATAL", Color.Red.ToArgb()))
            cFATAL = Color.FromArgb(tmpColor)

            tmpColor = Convert.ToInt32(key.GetValue("INFO", Color.BlueViolet.ToArgb()))
            cINFO = Color.FromArgb(tmpColor)

            tmpColor = Convert.ToInt32(key.GetValue("TRACE", Color.Green.ToArgb()))
            cTRACE = Color.FromArgb(tmpColor)

            tmpColor = Convert.ToInt32(key.GetValue("WARN", Color.Brown.ToArgb()))
            cWARN = Color.FromArgb(tmpColor)
        Else
            cDEBUG = Color.Blue
            cERROR = Color.DarkRed
            cFATAL = Color.Red
            cINFO = Color.BlueViolet
            cTRACE = Color.Green
            cWARN = Color.Brown
        End If
    End Sub

    Public Sub SaveColorSeting()
        Dim key As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\FSDC", True)
        If key Is Nothing Then
            key = My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\FSDC", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
        End If
        key.SetValue("DEBUG", cDEBUG.ToArgb())
        key.SetValue("ERROR", cERROR.ToArgb())
        key.SetValue("FATAL", cFATAL.ToArgb())
        key.SetValue("INFO", cINFO.ToArgb())
        key.SetValue("TRACE", cTRACE.ToArgb())
        key.SetValue("WARN", cWARN.ToArgb())
    End Sub
End Module
