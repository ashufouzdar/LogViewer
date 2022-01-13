Imports System.Windows.Forms

Public Class DlgColorSetting

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        cDEBUG = lblDEBUG.BackColor
        cERROR = lblERROR.BackColor
        cFATAL = lblFATAL.BackColor
        cINFO = lblINFO.BackColor
        cTRACE = lblTRACE.BackColor
        cWARN = lblWARN.BackColor
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        If dlgColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblDEBUG.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnError.Click
        If dlgColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblERROR.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnFATAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFATAL.Click
        If dlgColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblFATAL.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnINFO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINFO.Click
        If dlgColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblINFO.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnTRACE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTRACE.Click
        If dlgColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblTRACE.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnWARN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWARN.Click
        If dlgColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblWARN.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub DlgColorSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDEBUG.BackColor = cDEBUG
        lblERROR.BackColor = cERROR
        lblFATAL.BackColor = cFATAL
        lblINFO.BackColor = cINFO
        lblTRACE.BackColor = cTRACE
        lblWARN.BackColor = cWARN
    End Sub
End Class
