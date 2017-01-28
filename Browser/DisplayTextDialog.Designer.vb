<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayTextDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayTextDialog))
        Me.txtDisplayText = New System.Windows.Forms.TextBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.MsgTextTop = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.lblWarningInfo = New System.Windows.Forms.Label()
        Me.txtWarningMessage = New System.Windows.Forms.TextBox()
        Me.btnMakeBackup = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtWalletName = New System.Windows.Forms.TextBox()
        Me.cbxWalletId = New System.Windows.Forms.ComboBox()
        Me.txtCureCoinPoolPin = New System.Windows.Forms.TextBox()
        Me.txtExtremeOverclockingId = New System.Windows.Forms.TextBox()
        Me.chkShowAddData = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblCureCoinPoolPin = New System.Windows.Forms.Label()
        Me.txtCureCoinPoolPassword = New System.Windows.Forms.TextBox()
        Me.lblCureCoinPoolPassword = New System.Windows.Forms.Label()
        Me.txtCureCoinAddress = New System.Windows.Forms.TextBox()
        Me.lblCureCoinAddress = New System.Windows.Forms.Label()
        Me.txtCounterParty12WordPassphrase = New System.Windows.Forms.TextBox()
        Me.lblCounterParty12WordPassphrase = New System.Windows.Forms.Label()
        Me.txtBTCAddress = New System.Windows.Forms.TextBox()
        Me.lblBTCAddress = New System.Windows.Forms.Label()
        Me.lblExtremeOverclockingId = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtFAHPasskey = New System.Windows.Forms.TextBox()
        Me.lblFAHPasskey = New System.Windows.Forms.Label()
        Me.txtFAHTeam = New System.Windows.Forms.TextBox()
        Me.lblFAHTeam = New System.Windows.Forms.Label()
        Me.txtFAHUsername = New System.Windows.Forms.TextBox()
        Me.lblFAHUsername = New System.Windows.Forms.Label()
        Me.lblWalletNum = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisplayText
        '
        Me.txtDisplayText.BackColor = System.Drawing.Color.White
        Me.txtDisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDisplayText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDisplayText.Location = New System.Drawing.Point(0, 0)
        Me.txtDisplayText.Multiline = True
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplayText.Size = New System.Drawing.Size(241, 287)
        Me.txtDisplayText.TabIndex = 0
        Me.txtDisplayText.WordWrap = False
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(668, 425)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 28)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'MsgTextTop
        '
        Me.MsgTextTop.AutoSize = True
        Me.MsgTextTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgTextTop.Location = New System.Drawing.Point(21, 9)
        Me.MsgTextTop.Name = "MsgTextTop"
        Me.MsgTextTop.Size = New System.Drawing.Size(233, 18)
        Me.MsgTextTop.TabIndex = 7
        Me.MsgTextTop.Text = "Encrypted Data File Contents:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(24, 425)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(124, 28)
        Me.btnSaveChanges.TabIndex = 3
        Me.btnSaveChanges.Text = "Save Changes"
        Me.ToolTip1.SetToolTip(Me.btnSaveChanges, "If modified, this button allows saving any of those changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the encrypted Dat" &
        " file. Be careful when doing this.")
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'lblWarningInfo
        '
        Me.lblWarningInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarningInfo.BackColor = System.Drawing.Color.Firebrick
        Me.lblWarningInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWarningInfo.Location = New System.Drawing.Point(13, 324)
        Me.lblWarningInfo.Name = "lblWarningInfo"
        Me.lblWarningInfo.Size = New System.Drawing.Size(756, 96)
        Me.lblWarningInfo.TabIndex = 6
        '
        'txtWarningMessage
        '
        Me.txtWarningMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWarningMessage.BackColor = System.Drawing.Color.Tomato
        Me.txtWarningMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarningMessage.Location = New System.Drawing.Point(24, 331)
        Me.txtWarningMessage.Multiline = True
        Me.txtWarningMessage.Name = "txtWarningMessage"
        Me.txtWarningMessage.ReadOnly = True
        Me.txtWarningMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWarningMessage.Size = New System.Drawing.Size(734, 82)
        Me.txtWarningMessage.TabIndex = 5
        Me.txtWarningMessage.Text = resources.GetString("txtWarningMessage.Text")
        Me.txtWarningMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMakeBackup
        '
        Me.btnMakeBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMakeBackup.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnMakeBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeBackup.Location = New System.Drawing.Point(329, 425)
        Me.btnMakeBackup.Name = "btnMakeBackup"
        Me.btnMakeBackup.Size = New System.Drawing.Size(124, 28)
        Me.btnMakeBackup.TabIndex = 4
        Me.btnMakeBackup.Text = "Make Backup"
        Me.ToolTip1.SetToolTip(Me.btnMakeBackup, "Saves a unique folder to a location you selected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save a copy of: FoldingBrowser" &
        " INI and DAT, CureCoin wallet.dat")
        Me.btnMakeBackup.UseVisualStyleBackColor = True
        '
        'txtWalletName
        '
        Me.txtWalletName.Location = New System.Drawing.Point(133, 9)
        Me.txtWalletName.Name = "txtWalletName"
        Me.txtWalletName.Size = New System.Drawing.Size(128, 20)
        Me.txtWalletName.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxWalletId
        '
        Me.cbxWalletId.FormattingEnabled = True
        Me.cbxWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxWalletId.Location = New System.Drawing.Point(102, 9)
        Me.cbxWalletId.Name = "cbxWalletId"
        Me.cbxWalletId.Size = New System.Drawing.Size(30, 21)
        Me.cbxWalletId.TabIndex = 2
        Me.cbxWalletId.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cbxWalletId, "Wallet Id (0-9) to use. Default: 0.")
        '
        'txtCureCoinPoolPin
        '
        Me.txtCureCoinPoolPin.Location = New System.Drawing.Point(165, 233)
        Me.txtCureCoinPoolPin.Name = "txtCureCoinPoolPin"
        Me.txtCureCoinPoolPin.Size = New System.Drawing.Size(296, 20)
        Me.txtCureCoinPoolPin.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtCureCoinPoolPin, "Pin number needed to make any changes to the pool information")
        '
        'txtExtremeOverclockingId
        '
        Me.txtExtremeOverclockingId.Location = New System.Drawing.Point(165, 263)
        Me.txtExtremeOverclockingId.Name = "txtExtremeOverclockingId"
        Me.txtExtremeOverclockingId.Size = New System.Drawing.Size(296, 20)
        Me.txtExtremeOverclockingId.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtExtremeOverclockingId, "Extreme Overclocking Id from your EOC stats URL")
        '
        'chkShowAddData
        '
        Me.chkShowAddData.AutoSize = True
        Me.chkShowAddData.Location = New System.Drawing.Point(479, 9)
        Me.chkShowAddData.Name = "chkShowAddData"
        Me.chkShowAddData.Size = New System.Drawing.Size(162, 17)
        Me.chkShowAddData.TabIndex = 1
        Me.chkShowAddData.Text = "Add New or Existing Settings"
        Me.chkShowAddData.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(24, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCureCoinPoolPin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCureCoinPoolPin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCureCoinPoolPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCureCoinPoolPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCureCoinAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCureCoinAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCounterParty12WordPassphrase)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCounterParty12WordPassphrase)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBTCAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBTCAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtExtremeOverclockingId)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblExtremeOverclockingId)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFAHPasskey)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFAHPasskey)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFAHTeam)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFAHTeam)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFAHUsername)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFAHUsername)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtWalletName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbxWalletId)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblWalletNum)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDisplayText)
        Me.SplitContainer1.Size = New System.Drawing.Size(734, 289)
        Me.SplitContainer1.SplitterDistance = 489
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 2
        '
        'lblCureCoinPoolPin
        '
        Me.lblCureCoinPoolPin.AutoSize = True
        Me.lblCureCoinPoolPin.Location = New System.Drawing.Point(72, 236)
        Me.lblCureCoinPoolPin.Name = "lblCureCoinPoolPin"
        Me.lblCureCoinPoolPin.Size = New System.Drawing.Size(92, 13)
        Me.lblCureCoinPoolPin.TabIndex = 0
        Me.lblCureCoinPoolPin.Text = "CureCoin Pool Pin"
        '
        'txtCureCoinPoolPassword
        '
        Me.txtCureCoinPoolPassword.Location = New System.Drawing.Point(165, 211)
        Me.txtCureCoinPoolPassword.Name = "txtCureCoinPoolPassword"
        Me.txtCureCoinPoolPassword.Size = New System.Drawing.Size(296, 20)
        Me.txtCureCoinPoolPassword.TabIndex = 11
        '
        'lblCureCoinPoolPassword
        '
        Me.lblCureCoinPoolPassword.AutoSize = True
        Me.lblCureCoinPoolPassword.Location = New System.Drawing.Point(41, 214)
        Me.lblCureCoinPoolPassword.Name = "lblCureCoinPoolPassword"
        Me.lblCureCoinPoolPassword.Size = New System.Drawing.Size(123, 13)
        Me.lblCureCoinPoolPassword.TabIndex = 22
        Me.lblCureCoinPoolPassword.Text = "CureCoin Pool Password"
        '
        'txtCureCoinAddress
        '
        Me.txtCureCoinAddress.Location = New System.Drawing.Point(165, 189)
        Me.txtCureCoinAddress.Name = "txtCureCoinAddress"
        Me.txtCureCoinAddress.Size = New System.Drawing.Size(296, 20)
        Me.txtCureCoinAddress.TabIndex = 10
        '
        'lblCureCoinAddress
        '
        Me.lblCureCoinAddress.AutoSize = True
        Me.lblCureCoinAddress.Location = New System.Drawing.Point(73, 192)
        Me.lblCureCoinAddress.Name = "lblCureCoinAddress"
        Me.lblCureCoinAddress.Size = New System.Drawing.Size(91, 13)
        Me.lblCureCoinAddress.TabIndex = 21
        Me.lblCureCoinAddress.Text = "CureCoin Address"
        '
        'txtCounterParty12WordPassphrase
        '
        Me.txtCounterParty12WordPassphrase.Location = New System.Drawing.Point(165, 158)
        Me.txtCounterParty12WordPassphrase.Name = "txtCounterParty12WordPassphrase"
        Me.txtCounterParty12WordPassphrase.Size = New System.Drawing.Size(296, 20)
        Me.txtCounterParty12WordPassphrase.TabIndex = 9
        '
        'lblCounterParty12WordPassphrase
        '
        Me.lblCounterParty12WordPassphrase.AutoSize = True
        Me.lblCounterParty12WordPassphrase.Location = New System.Drawing.Point(3, 161)
        Me.lblCounterParty12WordPassphrase.Name = "lblCounterParty12WordPassphrase"
        Me.lblCounterParty12WordPassphrase.Size = New System.Drawing.Size(161, 13)
        Me.lblCounterParty12WordPassphrase.TabIndex = 20
        Me.lblCounterParty12WordPassphrase.Text = "CounterParty12WordPassphrase"
        '
        'txtBTCAddress
        '
        Me.txtBTCAddress.Location = New System.Drawing.Point(165, 136)
        Me.txtBTCAddress.Name = "txtBTCAddress"
        Me.txtBTCAddress.Size = New System.Drawing.Size(296, 20)
        Me.txtBTCAddress.TabIndex = 8
        '
        'lblBTCAddress
        '
        Me.lblBTCAddress.AutoSize = True
        Me.lblBTCAddress.Location = New System.Drawing.Point(95, 139)
        Me.lblBTCAddress.Name = "lblBTCAddress"
        Me.lblBTCAddress.Size = New System.Drawing.Size(69, 13)
        Me.lblBTCAddress.TabIndex = 19
        Me.lblBTCAddress.Text = "BTC Address"
        '
        'lblExtremeOverclockingId
        '
        Me.lblExtremeOverclockingId.AutoSize = True
        Me.lblExtremeOverclockingId.Location = New System.Drawing.Point(41, 266)
        Me.lblExtremeOverclockingId.Name = "lblExtremeOverclockingId"
        Me.lblExtremeOverclockingId.Size = New System.Drawing.Size(123, 13)
        Me.lblExtremeOverclockingId.TabIndex = 1
        Me.lblExtremeOverclockingId.Text = "Extreme Overclocking Id"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(165, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(296, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(132, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'txtFAHPasskey
        '
        Me.txtFAHPasskey.Location = New System.Drawing.Point(165, 84)
        Me.txtFAHPasskey.Name = "txtFAHPasskey"
        Me.txtFAHPasskey.Size = New System.Drawing.Size(296, 20)
        Me.txtFAHPasskey.TabIndex = 6
        '
        'lblFAHPasskey
        '
        Me.lblFAHPasskey.AutoSize = True
        Me.lblFAHPasskey.Location = New System.Drawing.Point(93, 87)
        Me.lblFAHPasskey.Name = "lblFAHPasskey"
        Me.lblFAHPasskey.Size = New System.Drawing.Size(71, 13)
        Me.lblFAHPasskey.TabIndex = 17
        Me.lblFAHPasskey.Text = "FAH Passkey"
        '
        'txtFAHTeam
        '
        Me.txtFAHTeam.Location = New System.Drawing.Point(165, 62)
        Me.txtFAHTeam.Name = "txtFAHTeam"
        Me.txtFAHTeam.Size = New System.Drawing.Size(296, 20)
        Me.txtFAHTeam.TabIndex = 5
        '
        'lblFAHTeam
        '
        Me.lblFAHTeam.AutoSize = True
        Me.lblFAHTeam.Location = New System.Drawing.Point(106, 65)
        Me.lblFAHTeam.Name = "lblFAHTeam"
        Me.lblFAHTeam.Size = New System.Drawing.Size(58, 13)
        Me.lblFAHTeam.TabIndex = 16
        Me.lblFAHTeam.Text = "FAH Team"
        '
        'txtFAHUsername
        '
        Me.txtFAHUsername.Location = New System.Drawing.Point(165, 40)
        Me.txtFAHUsername.Name = "txtFAHUsername"
        Me.txtFAHUsername.Size = New System.Drawing.Size(296, 20)
        Me.txtFAHUsername.TabIndex = 4
        '
        'lblFAHUsername
        '
        Me.lblFAHUsername.AutoSize = True
        Me.lblFAHUsername.Location = New System.Drawing.Point(85, 43)
        Me.lblFAHUsername.Name = "lblFAHUsername"
        Me.lblFAHUsername.Size = New System.Drawing.Size(79, 13)
        Me.lblFAHUsername.TabIndex = 15
        Me.lblFAHUsername.Text = "FAH Username"
        '
        'lblWalletNum
        '
        Me.lblWalletNum.AutoSize = True
        Me.lblWalletNum.Location = New System.Drawing.Point(33, 12)
        Me.lblWalletNum.Name = "lblWalletNum"
        Me.lblWalletNum.Size = New System.Drawing.Size(72, 13)
        Me.lblWalletNum.TabIndex = 14
        Me.lblWalletNum.Text = "Use Wallet #:"
        '
        'DisplayTextDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 465)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.chkShowAddData)
        Me.Controls.Add(Me.btnMakeBackup)
        Me.Controls.Add(Me.txtWarningMessage)
        Me.Controls.Add(Me.lblWarningInfo)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.MsgTextTop)
        Me.KeyPreview = True
        Me.Name = "DisplayTextDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Saved Data"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplayText As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents MsgTextTop As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents lblWarningInfo As Label
    Friend WithEvents txtWarningMessage As TextBox
    Friend WithEvents btnMakeBackup As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkShowAddData As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtWalletName As TextBox
    Friend WithEvents cbxWalletId As ComboBox
    Friend WithEvents lblWalletNum As Label
    Friend WithEvents txtCureCoinPoolPin As TextBox
    Friend WithEvents lblCureCoinPoolPin As Label
    Friend WithEvents txtCureCoinPoolPassword As TextBox
    Friend WithEvents lblCureCoinPoolPassword As Label
    Friend WithEvents txtCureCoinAddress As TextBox
    Friend WithEvents lblCureCoinAddress As Label
    Friend WithEvents txtCounterParty12WordPassphrase As TextBox
    Friend WithEvents lblCounterParty12WordPassphrase As Label
    Friend WithEvents txtBTCAddress As TextBox
    Friend WithEvents lblBTCAddress As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtFAHPasskey As TextBox
    Friend WithEvents lblFAHPasskey As Label
    Friend WithEvents txtFAHTeam As TextBox
    Friend WithEvents lblFAHTeam As Label
    Friend WithEvents txtFAHUsername As TextBox
    Friend WithEvents lblFAHUsername As Label
    Friend WithEvents txtExtremeOverclockingId As TextBox
    Friend WithEvents lblExtremeOverclockingId As Label
End Class
