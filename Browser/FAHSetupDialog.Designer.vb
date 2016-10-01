<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAHSetupDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.lblUsernamePreview = New System.Windows.Forms.Label()
        Me.TextEnteredLower = New System.Windows.Forms.TextBox()
        Me.rbnFoldingCoin = New System.Windows.Forms.RadioButton()
        Me.rbnCureCoin = New System.Windows.Forms.RadioButton()
        Me.rbnOtherTeam = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbxTeamSelection = New System.Windows.Forms.GroupBox()
        Me.lblTeamNotes = New System.Windows.Forms.Label()
        Me.btnGetPasscode = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtMergedFoldingCoin = New System.Windows.Forms.TextBox()
        Me.lblMergedFoldingCoin = New System.Windows.Forms.Label()
        Me.txtBitcoinAddress = New System.Windows.Forms.TextBox()
        Me.lblBitcoinAddress = New System.Windows.Forms.Label()
        Me.lblUnderscore1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPasscodeNotes = New System.Windows.Forms.Label()
        Me.gbxTeamSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(21, 67)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(111, 20)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(145, 277)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(268, 18)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Enter Passcode From Email (Optional):"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(362, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(266, 350)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 28)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'lblUsernamePreview
        '
        Me.lblUsernamePreview.AutoSize = True
        Me.lblUsernamePreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernamePreview.Location = New System.Drawing.Point(103, 9)
        Me.lblUsernamePreview.Name = "lblUsernamePreview"
        Me.lblUsernamePreview.Size = New System.Drawing.Size(144, 18)
        Me.lblUsernamePreview.TabIndex = 1
        Me.lblUsernamePreview.Text = "UsernamePreview"
        Me.lblUsernamePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEnteredLower
        '
        Me.TextEnteredLower.Location = New System.Drawing.Point(129, 298)
        Me.TextEnteredLower.Name = "TextEnteredLower"
        Me.TextEnteredLower.Size = New System.Drawing.Size(314, 20)
        Me.TextEnteredLower.TabIndex = 1
        Me.TextEnteredLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbnFoldingCoin
        '
        Me.rbnFoldingCoin.AutoSize = True
        Me.rbnFoldingCoin.Location = New System.Drawing.Point(62, 23)
        Me.rbnFoldingCoin.Name = "rbnFoldingCoin"
        Me.rbnFoldingCoin.Size = New System.Drawing.Size(167, 22)
        Me.rbnFoldingCoin.TabIndex = 4
        Me.rbnFoldingCoin.Text = "FoldingCoin (226728)"
        Me.rbnFoldingCoin.UseVisualStyleBackColor = True
        '
        'rbnCureCoin
        '
        Me.rbnCureCoin.AutoSize = True
        Me.rbnCureCoin.Checked = True
        Me.rbnCureCoin.Location = New System.Drawing.Point(62, 49)
        Me.rbnCureCoin.Name = "rbnCureCoin"
        Me.rbnCureCoin.Size = New System.Drawing.Size(151, 22)
        Me.rbnCureCoin.TabIndex = 5
        Me.rbnCureCoin.TabStop = True
        Me.rbnCureCoin.Text = "CureCoin (224497)"
        Me.rbnCureCoin.UseVisualStyleBackColor = True
        '
        'rbnOtherTeam
        '
        Me.rbnOtherTeam.AutoSize = True
        Me.rbnOtherTeam.Location = New System.Drawing.Point(62, 76)
        Me.rbnOtherTeam.Name = "rbnOtherTeam"
        Me.rbnOtherTeam.Size = New System.Drawing.Size(109, 22)
        Me.rbnOtherTeam.TabIndex = 6
        Me.rbnOtherTeam.Text = "Other Team:"
        Me.rbnOtherTeam.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxTeamSelection
        '
        Me.gbxTeamSelection.Controls.Add(Me.lblTeamNotes)
        Me.gbxTeamSelection.Controls.Add(Me.rbnOtherTeam)
        Me.gbxTeamSelection.Controls.Add(Me.rbnCureCoin)
        Me.gbxTeamSelection.Controls.Add(Me.rbnFoldingCoin)
        Me.gbxTeamSelection.Controls.Add(Me.TextBox1)
        Me.gbxTeamSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTeamSelection.Location = New System.Drawing.Point(18, 108)
        Me.gbxTeamSelection.Name = "gbxTeamSelection"
        Me.gbxTeamSelection.Size = New System.Drawing.Size(412, 151)
        Me.gbxTeamSelection.TabIndex = 7
        Me.gbxTeamSelection.TabStop = False
        Me.gbxTeamSelection.Text = "Team Number Selection"
        '
        'lblTeamNotes
        '
        Me.lblTeamNotes.AutoSize = True
        Me.lblTeamNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamNotes.Location = New System.Drawing.Point(35, 107)
        Me.lblTeamNotes.Name = "lblTeamNotes"
        Me.lblTeamNotes.Size = New System.Drawing.Size(321, 39)
        Me.lblTeamNotes.TabIndex = 7
        Me.lblTeamNotes.Text = "NOTE: You can fold on any team and earn FoldingCoin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Folding on team CureCoin al" &
    "lows earning both FoldingCoin and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CureCoin (See CureCoin's website for addition" &
    "al setup instructions)."
        '
        'btnGetPasscode
        '
        Me.btnGetPasscode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPasscode.Location = New System.Drawing.Point(9, 290)
        Me.btnGetPasscode.Name = "btnGetPasscode"
        Me.btnGetPasscode.Size = New System.Drawing.Size(114, 32)
        Me.btnGetPasscode.TabIndex = 8
        Me.btnGetPasscode.Text = "Get Passcode"
        Me.btnGetPasscode.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(38, 46)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(77, 18)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'txtMergedFoldingCoin
        '
        Me.txtMergedFoldingCoin.Location = New System.Drawing.Point(160, 67)
        Me.txtMergedFoldingCoin.Name = "txtMergedFoldingCoin"
        Me.txtMergedFoldingCoin.Size = New System.Drawing.Size(63, 20)
        Me.txtMergedFoldingCoin.TabIndex = 0
        Me.txtMergedFoldingCoin.Text = "ALL"
        Me.txtMergedFoldingCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMergedFoldingCoin
        '
        Me.lblMergedFoldingCoin.AutoSize = True
        Me.lblMergedFoldingCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMergedFoldingCoin.Location = New System.Drawing.Point(143, 46)
        Me.lblMergedFoldingCoin.Name = "lblMergedFoldingCoin"
        Me.lblMergedFoldingCoin.Size = New System.Drawing.Size(101, 18)
        Me.lblMergedFoldingCoin.TabIndex = 1
        Me.lblMergedFoldingCoin.Text = "Merged Coins"
        '
        'txtBitcoinAddress
        '
        Me.txtBitcoinAddress.Location = New System.Drawing.Point(251, 67)
        Me.txtBitcoinAddress.Name = "txtBitcoinAddress"
        Me.txtBitcoinAddress.Size = New System.Drawing.Size(173, 20)
        Me.txtBitcoinAddress.TabIndex = 0
        Me.txtBitcoinAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBitcoinAddress
        '
        Me.lblBitcoinAddress.AutoSize = True
        Me.lblBitcoinAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBitcoinAddress.Location = New System.Drawing.Point(283, 46)
        Me.lblBitcoinAddress.Name = "lblBitcoinAddress"
        Me.lblBitcoinAddress.Size = New System.Drawing.Size(111, 18)
        Me.lblBitcoinAddress.TabIndex = 1
        Me.lblBitcoinAddress.Text = "Bitcoin Address"
        '
        'lblUnderscore1
        '
        Me.lblUnderscore1.AutoSize = True
        Me.lblUnderscore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnderscore1.Location = New System.Drawing.Point(138, 66)
        Me.lblUnderscore1.Name = "lblUnderscore1"
        Me.lblUnderscore1.Size = New System.Drawing.Size(16, 18)
        Me.lblUnderscore1.TabIndex = 9
        Me.lblUnderscore1.Text = "_"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "_"
        '
        'lblPasscodeNotes
        '
        Me.lblPasscodeNotes.AutoSize = True
        Me.lblPasscodeNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasscodeNotes.Location = New System.Drawing.Point(141, 319)
        Me.lblPasscodeNotes.Name = "lblPasscodeNotes"
        Me.lblPasscodeNotes.Size = New System.Drawing.Size(265, 13)
        Me.lblPasscodeNotes.TabIndex = 1
        Me.lblPasscodeNotes.Text = "NOTE: Doing this increases the folding points you earn"
        '
        'FAHSetupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 390)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUnderscore1)
        Me.Controls.Add(Me.btnGetPasscode)
        Me.Controls.Add(Me.gbxTeamSelection)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblUsernamePreview)
        Me.Controls.Add(Me.lblBitcoinAddress)
        Me.Controls.Add(Me.lblMergedFoldingCoin)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPasscodeNotes)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.TextEnteredLower)
        Me.Controls.Add(Me.txtBitcoinAddress)
        Me.Controls.Add(Me.txtMergedFoldingCoin)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "FAHSetupDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Folding@Home Setup - Username and Team Selection"
        Me.gbxTeamSelection.ResumeLayout(False)
        Me.gbxTeamSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents lblUsernamePreview As System.Windows.Forms.Label
    Friend WithEvents TextEnteredLower As System.Windows.Forms.TextBox
    Friend WithEvents rbnFoldingCoin As RadioButton
    Friend WithEvents rbnCureCoin As RadioButton
    Friend WithEvents rbnOtherTeam As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gbxTeamSelection As GroupBox
    Friend WithEvents lblTeamNotes As Label
    Friend WithEvents btnGetPasscode As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtMergedFoldingCoin As TextBox
    Friend WithEvents lblMergedFoldingCoin As Label
    Friend WithEvents txtBitcoinAddress As TextBox
    Friend WithEvents lblBitcoinAddress As Label
    Friend WithEvents lblUnderscore1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPasscodeNotes As Label
End Class
