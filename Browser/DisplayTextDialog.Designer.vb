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
        Me.btnOK = New System.Windows.Forms.Button()
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
        Me.txtDiscordPassword = New System.Windows.Forms.TextBox()
        Me.txtDiscordEmail = New System.Windows.Forms.TextBox()
        Me.chkShowRawData = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblDiscordPassword = New System.Windows.Forms.Label()
        Me.lblDiscordEmail = New System.Windows.Forms.Label()
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
        Me.chkShowPW = New System.Windows.Forms.CheckBox()
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
        Me.txtDisplayText.Size = New System.Drawing.Size(90, 357)
        Me.txtDisplayText.TabIndex = 0
        Me.txtDisplayText.WordWrap = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(668, 495)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Close"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'MsgTextTop
        '
        Me.MsgTextTop.AutoSize = True
        Me.MsgTextTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgTextTop.Location = New System.Drawing.Point(21, 9)
        Me.MsgTextTop.Name = "MsgTextTop"
        Me.MsgTextTop.Size = New System.Drawing.Size(233, 18)
        Me.MsgTextTop.TabIndex = 1
        Me.MsgTextTop.Text = "Encrypted Data File Contents:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(399, 495)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(124, 28)
        Me.btnSaveChanges.TabIndex = 5
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
        Me.lblWarningInfo.Location = New System.Drawing.Point(13, 394)
        Me.lblWarningInfo.Name = "lblWarningInfo"
        Me.lblWarningInfo.Size = New System.Drawing.Size(756, 96)
        Me.lblWarningInfo.TabIndex = 3
        '
        'txtWarningMessage
        '
        Me.txtWarningMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWarningMessage.BackColor = System.Drawing.Color.Tomato
        Me.txtWarningMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarningMessage.Location = New System.Drawing.Point(24, 401)
        Me.txtWarningMessage.Multiline = True
        Me.txtWarningMessage.Name = "txtWarningMessage"
        Me.txtWarningMessage.ReadOnly = True
        Me.txtWarningMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWarningMessage.Size = New System.Drawing.Size(734, 82)
        Me.txtWarningMessage.TabIndex = 4
        Me.txtWarningMessage.Text = resources.GetString("txtWarningMessage.Text")
        Me.txtWarningMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMakeBackup
        '
        Me.btnMakeBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMakeBackup.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnMakeBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeBackup.Location = New System.Drawing.Point(533, 495)
        Me.btnMakeBackup.Name = "btnMakeBackup"
        Me.btnMakeBackup.Size = New System.Drawing.Size(124, 28)
        Me.btnMakeBackup.TabIndex = 7
        Me.btnMakeBackup.Text = "Make Backup"
        Me.ToolTip1.SetToolTip(Me.btnMakeBackup, "Saves a unique folder to a location you selected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save a copy of: FoldingBrowser" &
        " INI and DAT, CureCoin wallet.dat")
        Me.btnMakeBackup.UseVisualStyleBackColor = True
        '
        'txtWalletName
        '
        Me.txtWalletName.Location = New System.Drawing.Point(130, 6)
        Me.txtWalletName.Name = "txtWalletName"
        Me.txtWalletName.Size = New System.Drawing.Size(128, 20)
        Me.txtWalletName.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxWalletId
        '
        Me.cbxWalletId.FormattingEnabled = True
        Me.cbxWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxWalletId.Location = New System.Drawing.Point(99, 6)
        Me.cbxWalletId.Name = "cbxWalletId"
        Me.cbxWalletId.Size = New System.Drawing.Size(30, 21)
        Me.cbxWalletId.TabIndex = 2
        Me.cbxWalletId.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cbxWalletId, "Wallet Id (0-9) to use. Default: 0.")
        '
        'txtCureCoinPoolPin
        '
        Me.txtCureCoinPoolPin.Location = New System.Drawing.Point(167, 228)
        Me.txtCureCoinPoolPin.Name = "txtCureCoinPoolPin"
        Me.txtCureCoinPoolPin.Size = New System.Drawing.Size(296, 20)
        Me.txtCureCoinPoolPin.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtCureCoinPoolPin, "Pin number needed to make any changes to the pool information")
        '
        'txtExtremeOverclockingId
        '
        Me.txtExtremeOverclockingId.Location = New System.Drawing.Point(167, 310)
        Me.txtExtremeOverclockingId.Name = "txtExtremeOverclockingId"
        Me.txtExtremeOverclockingId.Size = New System.Drawing.Size(296, 20)
        Me.txtExtremeOverclockingId.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtExtremeOverclockingId, "Extreme Overclocking Id from your EOC stats URL")
        '
        'txtDiscordPassword
        '
        Me.txtDiscordPassword.Location = New System.Drawing.Point(167, 280)
        Me.txtDiscordPassword.Name = "txtDiscordPassword"
        Me.txtDiscordPassword.Size = New System.Drawing.Size(296, 20)
        Me.txtDiscordPassword.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.txtDiscordPassword, "Password used for Discord Login")
        '
        'txtDiscordEmail
        '
        Me.txtDiscordEmail.Location = New System.Drawing.Point(167, 258)
        Me.txtDiscordEmail.Name = "txtDiscordEmail"
        Me.txtDiscordEmail.Size = New System.Drawing.Size(296, 20)
        Me.txtDiscordEmail.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.txtDiscordEmail, "Email used for Discord Login")
        '
        'chkShowRawData
        '
        Me.chkShowRawData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkShowRawData.AutoSize = True
        Me.chkShowRawData.Location = New System.Drawing.Point(13, 501)
        Me.chkShowRawData.Name = "chkShowRawData"
        Me.chkShowRawData.Size = New System.Drawing.Size(104, 17)
        Me.chkShowRawData.TabIndex = 6
        Me.chkShowRawData.Text = "Show Raw Data"
        Me.chkShowRawData.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDiscordPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDiscordPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDiscordEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDiscordEmail)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(734, 359)
        Me.SplitContainer1.SplitterDistance = 640
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 2
        '
        'lblDiscordPassword
        '
        Me.lblDiscordPassword.AutoSize = True
        Me.lblDiscordPassword.Location = New System.Drawing.Point(73, 283)
        Me.lblDiscordPassword.Name = "lblDiscordPassword"
        Me.lblDiscordPassword.Size = New System.Drawing.Size(92, 13)
        Me.lblDiscordPassword.TabIndex = 29
        Me.lblDiscordPassword.Text = "Discord Password"
        '
        'lblDiscordEmail
        '
        Me.lblDiscordEmail.AutoSize = True
        Me.lblDiscordEmail.Location = New System.Drawing.Point(94, 261)
        Me.lblDiscordEmail.Name = "lblDiscordEmail"
        Me.lblDiscordEmail.Size = New System.Drawing.Size(71, 13)
        Me.lblDiscordEmail.TabIndex = 27
        Me.lblDiscordEmail.Text = "Discord Email"
        '
        'lblCureCoinPoolPin
        '
        Me.lblCureCoinPoolPin.AutoSize = True
        Me.lblCureCoinPoolPin.Location = New System.Drawing.Point(74, 231)
        Me.lblCureCoinPoolPin.Name = "lblCureCoinPoolPin"
        Me.lblCureCoinPoolPin.Size = New System.Drawing.Size(92, 13)
        Me.lblCureCoinPoolPin.TabIndex = 0
        Me.lblCureCoinPoolPin.Text = "CureCoin Pool Pin"
        '
        'txtCureCoinPoolPassword
        '
        Me.txtCureCoinPoolPassword.Location = New System.Drawing.Point(167, 206)
        Me.txtCureCoinPoolPassword.Name = "txtCureCoinPoolPassword"
        Me.txtCureCoinPoolPassword.Size = New System.Drawing.Size(296, 20)
        Me.txtCureCoinPoolPassword.TabIndex = 11
        '
        'lblCureCoinPoolPassword
        '
        Me.lblCureCoinPoolPassword.AutoSize = True
        Me.lblCureCoinPoolPassword.Location = New System.Drawing.Point(43, 209)
        Me.lblCureCoinPoolPassword.Name = "lblCureCoinPoolPassword"
        Me.lblCureCoinPoolPassword.Size = New System.Drawing.Size(123, 13)
        Me.lblCureCoinPoolPassword.TabIndex = 22
        Me.lblCureCoinPoolPassword.Text = "CureCoin Pool Password"
        '
        'txtCureCoinAddress
        '
        Me.txtCureCoinAddress.Location = New System.Drawing.Point(167, 184)
        Me.txtCureCoinAddress.Name = "txtCureCoinAddress"
        Me.txtCureCoinAddress.Size = New System.Drawing.Size(296, 20)
        Me.txtCureCoinAddress.TabIndex = 10
        '
        'lblCureCoinAddress
        '
        Me.lblCureCoinAddress.AutoSize = True
        Me.lblCureCoinAddress.Location = New System.Drawing.Point(75, 187)
        Me.lblCureCoinAddress.Name = "lblCureCoinAddress"
        Me.lblCureCoinAddress.Size = New System.Drawing.Size(91, 13)
        Me.lblCureCoinAddress.TabIndex = 21
        Me.lblCureCoinAddress.Text = "CureCoin Address"
        '
        'txtCounterParty12WordPassphrase
        '
        Me.txtCounterParty12WordPassphrase.Location = New System.Drawing.Point(167, 154)
        Me.txtCounterParty12WordPassphrase.Name = "txtCounterParty12WordPassphrase"
        Me.txtCounterParty12WordPassphrase.Size = New System.Drawing.Size(296, 20)
        Me.txtCounterParty12WordPassphrase.TabIndex = 9
        '
        'lblCounterParty12WordPassphrase
        '
        Me.lblCounterParty12WordPassphrase.AutoSize = True
        Me.lblCounterParty12WordPassphrase.Location = New System.Drawing.Point(5, 157)
        Me.lblCounterParty12WordPassphrase.Name = "lblCounterParty12WordPassphrase"
        Me.lblCounterParty12WordPassphrase.Size = New System.Drawing.Size(161, 13)
        Me.lblCounterParty12WordPassphrase.TabIndex = 20
        Me.lblCounterParty12WordPassphrase.Text = "CounterParty12WordPassphrase"
        '
        'txtBTCAddress
        '
        Me.txtBTCAddress.Location = New System.Drawing.Point(167, 132)
        Me.txtBTCAddress.Name = "txtBTCAddress"
        Me.txtBTCAddress.Size = New System.Drawing.Size(296, 20)
        Me.txtBTCAddress.TabIndex = 8
        '
        'lblBTCAddress
        '
        Me.lblBTCAddress.AutoSize = True
        Me.lblBTCAddress.Location = New System.Drawing.Point(97, 135)
        Me.lblBTCAddress.Name = "lblBTCAddress"
        Me.lblBTCAddress.Size = New System.Drawing.Size(69, 13)
        Me.lblBTCAddress.TabIndex = 19
        Me.lblBTCAddress.Text = "BTC Address"
        '
        'lblExtremeOverclockingId
        '
        Me.lblExtremeOverclockingId.AutoSize = True
        Me.lblExtremeOverclockingId.Location = New System.Drawing.Point(43, 313)
        Me.lblExtremeOverclockingId.Name = "lblExtremeOverclockingId"
        Me.lblExtremeOverclockingId.Size = New System.Drawing.Size(123, 13)
        Me.lblExtremeOverclockingId.TabIndex = 1
        Me.lblExtremeOverclockingId.Text = "Extreme Overclocking Id"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(167, 102)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(296, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(134, 105)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'txtFAHPasskey
        '
        Me.txtFAHPasskey.Location = New System.Drawing.Point(167, 80)
        Me.txtFAHPasskey.Name = "txtFAHPasskey"
        Me.txtFAHPasskey.Size = New System.Drawing.Size(296, 20)
        Me.txtFAHPasskey.TabIndex = 6
        '
        'lblFAHPasskey
        '
        Me.lblFAHPasskey.AutoSize = True
        Me.lblFAHPasskey.Location = New System.Drawing.Point(95, 83)
        Me.lblFAHPasskey.Name = "lblFAHPasskey"
        Me.lblFAHPasskey.Size = New System.Drawing.Size(71, 13)
        Me.lblFAHPasskey.TabIndex = 17
        Me.lblFAHPasskey.Text = "FAH Passkey"
        '
        'txtFAHTeam
        '
        Me.txtFAHTeam.Location = New System.Drawing.Point(167, 58)
        Me.txtFAHTeam.Name = "txtFAHTeam"
        Me.txtFAHTeam.Size = New System.Drawing.Size(296, 20)
        Me.txtFAHTeam.TabIndex = 5
        '
        'lblFAHTeam
        '
        Me.lblFAHTeam.AutoSize = True
        Me.lblFAHTeam.Location = New System.Drawing.Point(108, 61)
        Me.lblFAHTeam.Name = "lblFAHTeam"
        Me.lblFAHTeam.Size = New System.Drawing.Size(58, 13)
        Me.lblFAHTeam.TabIndex = 16
        Me.lblFAHTeam.Text = "FAH Team"
        '
        'txtFAHUsername
        '
        Me.txtFAHUsername.Location = New System.Drawing.Point(167, 36)
        Me.txtFAHUsername.Name = "txtFAHUsername"
        Me.txtFAHUsername.Size = New System.Drawing.Size(296, 20)
        Me.txtFAHUsername.TabIndex = 4
        '
        'lblFAHUsername
        '
        Me.lblFAHUsername.AutoSize = True
        Me.lblFAHUsername.Location = New System.Drawing.Point(87, 39)
        Me.lblFAHUsername.Name = "lblFAHUsername"
        Me.lblFAHUsername.Size = New System.Drawing.Size(79, 13)
        Me.lblFAHUsername.TabIndex = 15
        Me.lblFAHUsername.Text = "FAH Username"
        '
        'lblWalletNum
        '
        Me.lblWalletNum.AutoSize = True
        Me.lblWalletNum.Location = New System.Drawing.Point(51, 9)
        Me.lblWalletNum.Name = "lblWalletNum"
        Me.lblWalletNum.Size = New System.Drawing.Size(50, 13)
        Me.lblWalletNum.TabIndex = 14
        Me.lblWalletNum.Text = "Wallet #:"
        '
        'chkShowPW
        '
        Me.chkShowPW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkShowPW.AutoSize = True
        Me.chkShowPW.Location = New System.Drawing.Point(123, 501)
        Me.chkShowPW.Name = "chkShowPW"
        Me.chkShowPW.Size = New System.Drawing.Size(107, 17)
        Me.chkShowPW.TabIndex = 8
        Me.chkShowPW.Text = "Show Passwords"
        Me.chkShowPW.UseVisualStyleBackColor = True
        '
        'DisplayTextDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 535)
        Me.Controls.Add(Me.chkShowPW)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.chkShowRawData)
        Me.Controls.Add(Me.btnMakeBackup)
        Me.Controls.Add(Me.txtWarningMessage)
        Me.Controls.Add(Me.lblWarningInfo)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnOK)
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
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents MsgTextTop As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents lblWarningInfo As Label
    Friend WithEvents txtWarningMessage As TextBox
    Friend WithEvents btnMakeBackup As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkShowRawData As CheckBox
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
    Friend WithEvents txtDiscordPassword As TextBox
    Friend WithEvents lblDiscordPassword As Label
    Friend WithEvents txtDiscordEmail As TextBox
    Friend WithEvents lblDiscordEmail As Label
    Friend WithEvents chkShowPW As CheckBox
End Class
