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
        Me.txtDisplayText.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDisplayText.Multiline = True
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplayText.Size = New System.Drawing.Size(48, 403)
        Me.txtDisplayText.TabIndex = 0
        Me.txtDisplayText.WordWrap = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(634, 563)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 34)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Close"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'MsgTextTop
        '
        Me.MsgTextTop.AutoSize = True
        Me.MsgTextTop.Location = New System.Drawing.Point(24, 9)
        Me.MsgTextTop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MsgTextTop.Name = "MsgTextTop"
        Me.MsgTextTop.Size = New System.Drawing.Size(184, 16)
        Me.MsgTextTop.TabIndex = 6
        Me.MsgTextTop.Text = "Encrypted Data File Contents:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.Location = New System.Drawing.Point(315, 563)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(142, 34)
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
        Me.lblWarningInfo.Location = New System.Drawing.Point(11, 437)
        Me.lblWarningInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWarningInfo.Name = "lblWarningInfo"
        Me.lblWarningInfo.Size = New System.Drawing.Size(740, 111)
        Me.lblWarningInfo.TabIndex = 7
        '
        'txtWarningMessage
        '
        Me.txtWarningMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWarningMessage.BackColor = System.Drawing.Color.Tomato
        Me.txtWarningMessage.Location = New System.Drawing.Point(26, 446)
        Me.txtWarningMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarningMessage.Multiline = True
        Me.txtWarningMessage.Name = "txtWarningMessage"
        Me.txtWarningMessage.ReadOnly = True
        Me.txtWarningMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWarningMessage.Size = New System.Drawing.Size(710, 93)
        Me.txtWarningMessage.TabIndex = 8
        Me.txtWarningMessage.Text = resources.GetString("txtWarningMessage.Text")
        Me.txtWarningMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMakeBackup
        '
        Me.btnMakeBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMakeBackup.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnMakeBackup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMakeBackup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnMakeBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeBackup.Location = New System.Drawing.Point(475, 563)
        Me.btnMakeBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMakeBackup.Name = "btnMakeBackup"
        Me.btnMakeBackup.Size = New System.Drawing.Size(141, 34)
        Me.btnMakeBackup.TabIndex = 4
        Me.btnMakeBackup.Text = "Make Backup"
        Me.ToolTip1.SetToolTip(Me.btnMakeBackup, "Saves a unique folder to a location you selected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save a copy of: FoldingBrowser" &
        " INI and DAT, CureCoin wallet.dat")
        Me.btnMakeBackup.UseVisualStyleBackColor = True
        '
        'txtWalletName
        '
        Me.txtWalletName.Location = New System.Drawing.Point(173, 7)
        Me.txtWalletName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWalletName.Name = "txtWalletName"
        Me.txtWalletName.Size = New System.Drawing.Size(169, 22)
        Me.txtWalletName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxWalletId
        '
        Me.cbxWalletId.FormattingEnabled = True
        Me.cbxWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxWalletId.Location = New System.Drawing.Point(132, 7)
        Me.cbxWalletId.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxWalletId.Name = "cbxWalletId"
        Me.cbxWalletId.Size = New System.Drawing.Size(39, 24)
        Me.cbxWalletId.TabIndex = 0
        Me.cbxWalletId.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cbxWalletId, "Wallet Id (0-9) to use. Default: 0.")
        '
        'txtCureCoinPoolPin
        '
        Me.txtCureCoinPoolPin.Location = New System.Drawing.Point(220, 269)
        Me.txtCureCoinPoolPin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCureCoinPoolPin.Name = "txtCureCoinPoolPin"
        Me.txtCureCoinPoolPin.Size = New System.Drawing.Size(411, 22)
        Me.txtCureCoinPoolPin.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtCureCoinPoolPin, "Pin number needed to make any changes to the pool information")
        '
        'txtExtremeOverclockingId
        '
        Me.txtExtremeOverclockingId.Location = New System.Drawing.Point(220, 367)
        Me.txtExtremeOverclockingId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExtremeOverclockingId.Name = "txtExtremeOverclockingId"
        Me.txtExtremeOverclockingId.Size = New System.Drawing.Size(411, 22)
        Me.txtExtremeOverclockingId.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtExtremeOverclockingId, "Extreme Overclocking Id from your EOC stats URL")
        '
        'txtDiscordPassword
        '
        Me.txtDiscordPassword.Location = New System.Drawing.Point(220, 331)
        Me.txtDiscordPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscordPassword.Name = "txtDiscordPassword"
        Me.txtDiscordPassword.Size = New System.Drawing.Size(411, 22)
        Me.txtDiscordPassword.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtDiscordPassword, "Password used for Discord Login")
        '
        'txtDiscordEmail
        '
        Me.txtDiscordEmail.Location = New System.Drawing.Point(220, 305)
        Me.txtDiscordEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscordEmail.Name = "txtDiscordEmail"
        Me.txtDiscordEmail.Size = New System.Drawing.Size(411, 22)
        Me.txtDiscordEmail.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtDiscordEmail, "Email used for Discord Login")
        '
        'chkShowRawData
        '
        Me.chkShowRawData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShowRawData.AutoSize = True
        Me.chkShowRawData.Location = New System.Drawing.Point(13, 571)
        Me.chkShowRawData.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowRawData.Name = "chkShowRawData"
        Me.chkShowRawData.Size = New System.Drawing.Size(122, 20)
        Me.chkShowRawData.TabIndex = 1
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
        Me.SplitContainer1.Location = New System.Drawing.Point(26, 28)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
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
        Me.SplitContainer1.Size = New System.Drawing.Size(710, 405)
        Me.SplitContainer1.SplitterDistance = 657
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 5
        '
        'lblDiscordPassword
        '
        Me.lblDiscordPassword.AutoSize = True
        Me.lblDiscordPassword.Location = New System.Drawing.Point(100, 334)
        Me.lblDiscordPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscordPassword.Name = "lblDiscordPassword"
        Me.lblDiscordPassword.Size = New System.Drawing.Size(118, 16)
        Me.lblDiscordPassword.TabIndex = 25
        Me.lblDiscordPassword.Text = "Discord Password"
        '
        'lblDiscordEmail
        '
        Me.lblDiscordEmail.AutoSize = True
        Me.lblDiscordEmail.Location = New System.Drawing.Point(126, 308)
        Me.lblDiscordEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscordEmail.Name = "lblDiscordEmail"
        Me.lblDiscordEmail.Size = New System.Drawing.Size(92, 16)
        Me.lblDiscordEmail.TabIndex = 24
        Me.lblDiscordEmail.Text = "Discord Email"
        '
        'lblCureCoinPoolPin
        '
        Me.lblCureCoinPoolPin.AutoSize = True
        Me.lblCureCoinPoolPin.Location = New System.Drawing.Point(102, 272)
        Me.lblCureCoinPoolPin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCureCoinPoolPin.Name = "lblCureCoinPoolPin"
        Me.lblCureCoinPoolPin.Size = New System.Drawing.Size(116, 16)
        Me.lblCureCoinPoolPin.TabIndex = 23
        Me.lblCureCoinPoolPin.Text = "CureCoin Pool Pin"
        '
        'txtCureCoinPoolPassword
        '
        Me.txtCureCoinPoolPassword.Location = New System.Drawing.Point(220, 243)
        Me.txtCureCoinPoolPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCureCoinPoolPassword.Name = "txtCureCoinPoolPassword"
        Me.txtCureCoinPoolPassword.Size = New System.Drawing.Size(411, 22)
        Me.txtCureCoinPoolPassword.TabIndex = 9
        '
        'lblCureCoinPoolPassword
        '
        Me.lblCureCoinPoolPassword.AutoSize = True
        Me.lblCureCoinPoolPassword.Location = New System.Drawing.Point(61, 246)
        Me.lblCureCoinPoolPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCureCoinPoolPassword.Name = "lblCureCoinPoolPassword"
        Me.lblCureCoinPoolPassword.Size = New System.Drawing.Size(157, 16)
        Me.lblCureCoinPoolPassword.TabIndex = 22
        Me.lblCureCoinPoolPassword.Text = "CureCoin Pool Password"
        '
        'txtCureCoinAddress
        '
        Me.txtCureCoinAddress.Location = New System.Drawing.Point(220, 216)
        Me.txtCureCoinAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCureCoinAddress.Name = "txtCureCoinAddress"
        Me.txtCureCoinAddress.Size = New System.Drawing.Size(411, 22)
        Me.txtCureCoinAddress.TabIndex = 8
        '
        'lblCureCoinAddress
        '
        Me.lblCureCoinAddress.AutoSize = True
        Me.lblCureCoinAddress.Location = New System.Drawing.Point(101, 219)
        Me.lblCureCoinAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCureCoinAddress.Name = "lblCureCoinAddress"
        Me.lblCureCoinAddress.Size = New System.Drawing.Size(117, 16)
        Me.lblCureCoinAddress.TabIndex = 21
        Me.lblCureCoinAddress.Text = "CureCoin Address"
        '
        'txtCounterParty12WordPassphrase
        '
        Me.txtCounterParty12WordPassphrase.Location = New System.Drawing.Point(220, 181)
        Me.txtCounterParty12WordPassphrase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCounterParty12WordPassphrase.Name = "txtCounterParty12WordPassphrase"
        Me.txtCounterParty12WordPassphrase.Size = New System.Drawing.Size(411, 22)
        Me.txtCounterParty12WordPassphrase.TabIndex = 7
        '
        'lblCounterParty12WordPassphrase
        '
        Me.lblCounterParty12WordPassphrase.AutoSize = True
        Me.lblCounterParty12WordPassphrase.Location = New System.Drawing.Point(13, 184)
        Me.lblCounterParty12WordPassphrase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCounterParty12WordPassphrase.Name = "lblCounterParty12WordPassphrase"
        Me.lblCounterParty12WordPassphrase.Size = New System.Drawing.Size(205, 16)
        Me.lblCounterParty12WordPassphrase.TabIndex = 20
        Me.lblCounterParty12WordPassphrase.Text = "CounterParty12WordPassphrase"
        '
        'txtBTCAddress
        '
        Me.txtBTCAddress.Location = New System.Drawing.Point(220, 154)
        Me.txtBTCAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBTCAddress.Name = "txtBTCAddress"
        Me.txtBTCAddress.Size = New System.Drawing.Size(411, 22)
        Me.txtBTCAddress.TabIndex = 6
        '
        'lblBTCAddress
        '
        Me.lblBTCAddress.AutoSize = True
        Me.lblBTCAddress.Location = New System.Drawing.Point(129, 157)
        Me.lblBTCAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBTCAddress.Name = "lblBTCAddress"
        Me.lblBTCAddress.Size = New System.Drawing.Size(89, 16)
        Me.lblBTCAddress.TabIndex = 19
        Me.lblBTCAddress.Text = "BTC Address"
        '
        'lblExtremeOverclockingId
        '
        Me.lblExtremeOverclockingId.AutoSize = True
        Me.lblExtremeOverclockingId.Location = New System.Drawing.Point(65, 370)
        Me.lblExtremeOverclockingId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremeOverclockingId.Name = "lblExtremeOverclockingId"
        Me.lblExtremeOverclockingId.Size = New System.Drawing.Size(153, 16)
        Me.lblExtremeOverclockingId.TabIndex = 26
        Me.lblExtremeOverclockingId.Text = "Extreme Overclocking Id"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(220, 119)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(411, 22)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(176, 122)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 16)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'txtFAHPasskey
        '
        Me.txtFAHPasskey.Location = New System.Drawing.Point(220, 92)
        Me.txtFAHPasskey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFAHPasskey.Name = "txtFAHPasskey"
        Me.txtFAHPasskey.Size = New System.Drawing.Size(411, 22)
        Me.txtFAHPasskey.TabIndex = 4
        '
        'lblFAHPasskey
        '
        Me.lblFAHPasskey.AutoSize = True
        Me.lblFAHPasskey.Location = New System.Drawing.Point(127, 95)
        Me.lblFAHPasskey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFAHPasskey.Name = "lblFAHPasskey"
        Me.lblFAHPasskey.Size = New System.Drawing.Size(91, 16)
        Me.lblFAHPasskey.TabIndex = 17
        Me.lblFAHPasskey.Text = "FAH Passkey"
        '
        'txtFAHTeam
        '
        Me.txtFAHTeam.Location = New System.Drawing.Point(220, 66)
        Me.txtFAHTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFAHTeam.Name = "txtFAHTeam"
        Me.txtFAHTeam.Size = New System.Drawing.Size(411, 22)
        Me.txtFAHTeam.TabIndex = 3
        '
        'lblFAHTeam
        '
        Me.lblFAHTeam.AutoSize = True
        Me.lblFAHTeam.Location = New System.Drawing.Point(144, 69)
        Me.lblFAHTeam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFAHTeam.Name = "lblFAHTeam"
        Me.lblFAHTeam.Size = New System.Drawing.Size(74, 16)
        Me.lblFAHTeam.TabIndex = 16
        Me.lblFAHTeam.Text = "FAH Team"
        '
        'txtFAHUsername
        '
        Me.txtFAHUsername.Location = New System.Drawing.Point(220, 40)
        Me.txtFAHUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFAHUsername.Name = "txtFAHUsername"
        Me.txtFAHUsername.Size = New System.Drawing.Size(411, 22)
        Me.txtFAHUsername.TabIndex = 2
        '
        'lblFAHUsername
        '
        Me.lblFAHUsername.AutoSize = True
        Me.lblFAHUsername.Location = New System.Drawing.Point(117, 43)
        Me.lblFAHUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFAHUsername.Name = "lblFAHUsername"
        Me.lblFAHUsername.Size = New System.Drawing.Size(101, 16)
        Me.lblFAHUsername.TabIndex = 15
        Me.lblFAHUsername.Text = "FAH Username"
        '
        'lblWalletNum
        '
        Me.lblWalletNum.AutoSize = True
        Me.lblWalletNum.Location = New System.Drawing.Point(68, 11)
        Me.lblWalletNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWalletNum.Name = "lblWalletNum"
        Me.lblWalletNum.Size = New System.Drawing.Size(59, 16)
        Me.lblWalletNum.TabIndex = 14
        Me.lblWalletNum.Text = "Wallet #:"
        '
        'chkShowPW
        '
        Me.chkShowPW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShowPW.AutoSize = True
        Me.chkShowPW.Location = New System.Drawing.Point(147, 571)
        Me.chkShowPW.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowPW.Name = "chkShowPW"
        Me.chkShowPW.Size = New System.Drawing.Size(130, 20)
        Me.chkShowPW.TabIndex = 2
        Me.chkShowPW.Text = "Show Passwords"
        Me.chkShowPW.UseVisualStyleBackColor = True
        '
        'DisplayTextDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(761, 610)
        Me.Controls.Add(Me.chkShowPW)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.chkShowRawData)
        Me.Controls.Add(Me.btnMakeBackup)
        Me.Controls.Add(Me.txtWarningMessage)
        Me.Controls.Add(Me.lblWarningInfo)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.MsgTextTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
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
