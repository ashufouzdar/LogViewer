<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgColorSetting
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btnWARN = New System.Windows.Forms.Button
        Me.btnTRACE = New System.Windows.Forms.Button
        Me.btnINFO = New System.Windows.Forms.Button
        Me.btnFATAL = New System.Windows.Forms.Button
        Me.btnError = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblDEBUG = New System.Windows.Forms.Label
        Me.lblERROR = New System.Windows.Forms.Label
        Me.lblFATAL = New System.Windows.Forms.Label
        Me.lblTRACE = New System.Windows.Forms.Label
        Me.lblINFO = New System.Windows.Forms.Label
        Me.lblWARN = New System.Windows.Forms.Label
        Me.btnDebug = New System.Windows.Forms.Button
        Me.dlgColor = New System.Windows.Forms.ColorDialog
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 225)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnWARN, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTRACE, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnINFO, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnFATAL, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnError, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDEBUG, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblERROR, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFATAL, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTRACE, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblINFO, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblWARN, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDebug, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(408, 204)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btnWARN
        '
        Me.btnWARN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWARN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWARN.Location = New System.Drawing.Point(371, 173)
        Me.btnWARN.Name = "btnWARN"
        Me.btnWARN.Size = New System.Drawing.Size(34, 23)
        Me.btnWARN.TabIndex = 17
        Me.btnWARN.Text = "..."
        Me.btnWARN.UseVisualStyleBackColor = True
        '
        'btnTRACE
        '
        Me.btnTRACE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTRACE.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTRACE.Location = New System.Drawing.Point(371, 137)
        Me.btnTRACE.Name = "btnTRACE"
        Me.btnTRACE.Size = New System.Drawing.Size(34, 23)
        Me.btnTRACE.TabIndex = 16
        Me.btnTRACE.Text = "..."
        Me.btnTRACE.UseVisualStyleBackColor = True
        '
        'btnINFO
        '
        Me.btnINFO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnINFO.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINFO.Location = New System.Drawing.Point(371, 104)
        Me.btnINFO.Name = "btnINFO"
        Me.btnINFO.Size = New System.Drawing.Size(34, 23)
        Me.btnINFO.TabIndex = 15
        Me.btnINFO.Text = "..."
        Me.btnINFO.UseVisualStyleBackColor = True
        '
        'btnFATAL
        '
        Me.btnFATAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFATAL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFATAL.Location = New System.Drawing.Point(371, 71)
        Me.btnFATAL.Name = "btnFATAL"
        Me.btnFATAL.Size = New System.Drawing.Size(34, 23)
        Me.btnFATAL.TabIndex = 14
        Me.btnFATAL.Text = "..."
        Me.btnFATAL.UseVisualStyleBackColor = True
        '
        'btnError
        '
        Me.btnError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnError.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnError.Location = New System.Drawing.Point(371, 38)
        Me.btnError.Name = "btnError"
        Me.btnError.Size = New System.Drawing.Size(34, 23)
        Me.btnError.TabIndex = 13
        Me.btnError.Text = "..."
        Me.btnError.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEBUG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ERROR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FATAL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "INFO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TRACE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "WARN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDEBUG
        '
        Me.lblDEBUG.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDEBUG.AutoSize = True
        Me.lblDEBUG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDEBUG.Location = New System.Drawing.Point(103, 9)
        Me.lblDEBUG.Name = "lblDEBUG"
        Me.lblDEBUG.Size = New System.Drawing.Size(262, 15)
        Me.lblDEBUG.TabIndex = 6
        '
        'lblERROR
        '
        Me.lblERROR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblERROR.AutoSize = True
        Me.lblERROR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblERROR.Location = New System.Drawing.Point(103, 42)
        Me.lblERROR.Name = "lblERROR"
        Me.lblERROR.Size = New System.Drawing.Size(262, 15)
        Me.lblERROR.TabIndex = 7
        '
        'lblFATAL
        '
        Me.lblFATAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFATAL.AutoSize = True
        Me.lblFATAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFATAL.Location = New System.Drawing.Point(103, 75)
        Me.lblFATAL.Name = "lblFATAL"
        Me.lblFATAL.Size = New System.Drawing.Size(262, 15)
        Me.lblFATAL.TabIndex = 8
        '
        'lblTRACE
        '
        Me.lblTRACE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTRACE.AutoSize = True
        Me.lblTRACE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTRACE.Location = New System.Drawing.Point(103, 141)
        Me.lblTRACE.Name = "lblTRACE"
        Me.lblTRACE.Size = New System.Drawing.Size(262, 15)
        Me.lblTRACE.TabIndex = 9
        '
        'lblINFO
        '
        Me.lblINFO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblINFO.AutoSize = True
        Me.lblINFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblINFO.Location = New System.Drawing.Point(103, 108)
        Me.lblINFO.Name = "lblINFO"
        Me.lblINFO.Size = New System.Drawing.Size(262, 15)
        Me.lblINFO.TabIndex = 10
        '
        'lblWARN
        '
        Me.lblWARN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWARN.AutoSize = True
        Me.lblWARN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWARN.Location = New System.Drawing.Point(103, 177)
        Me.lblWARN.Name = "lblWARN"
        Me.lblWARN.Size = New System.Drawing.Size(262, 15)
        Me.lblWARN.TabIndex = 11
        '
        'btnDebug
        '
        Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebug.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.Location = New System.Drawing.Point(371, 5)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(34, 23)
        Me.btnDebug.TabIndex = 12
        Me.btnDebug.Text = "..."
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'DlgColorSetting
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 263)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgColorSetting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Color Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDEBUG As System.Windows.Forms.Label
    Friend WithEvents lblERROR As System.Windows.Forms.Label
    Friend WithEvents lblFATAL As System.Windows.Forms.Label
    Friend WithEvents lblTRACE As System.Windows.Forms.Label
    Friend WithEvents lblINFO As System.Windows.Forms.Label
    Friend WithEvents lblWARN As System.Windows.Forms.Label
    Friend WithEvents btnWARN As System.Windows.Forms.Button
    Friend WithEvents btnTRACE As System.Windows.Forms.Button
    Friend WithEvents btnINFO As System.Windows.Forms.Button
    Friend WithEvents btnFATAL As System.Windows.Forms.Button
    Friend WithEvents btnError As System.Windows.Forms.Button
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog

End Class
