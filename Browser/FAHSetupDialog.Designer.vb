<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAHSetupDialog
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPasskeyFromEmail = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblUsernamePreview = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.rbnFoldingCoin = New System.Windows.Forms.RadioButton()
        Me.rbnCureCoin = New System.Windows.Forms.RadioButton()
        Me.rbnOtherTeam = New System.Windows.Forms.RadioButton()
        Me.txtOtherTeam = New System.Windows.Forms.TextBox()
        Me.gbxTeamSelection = New System.Windows.Forms.GroupBox()
        Me.lblTeamNumber = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lllTeamNumbersLink = New System.Windows.Forms.LinkLabel()
        Me.lblTeamNotes = New System.Windows.Forms.Label()
        Me.btnGetPasskey = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.txtBitcoinAddress = New System.Windows.Forms.TextBox()
        Me.lblBitcoinAddress = New System.Windows.Forms.Label()
        Me.lblPasskeyNotes = New System.Windows.Forms.Label()
        Me.gbxUsername = New System.Windows.Forms.GroupBox()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.cbxSeparator = New System.Windows.Forms.ComboBox()
        Me.lblErrorNote = New System.Windows.Forms.Label()
        Me.gbxPasskey = New System.Windows.Forms.GroupBox()
        Me.txtPasskey = New System.Windows.Forms.TextBox()
        Me.lblPasskeyError = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.gbxConfigPreview = New System.Windows.Forms.GroupBox()
        Me.txtCfgPath = New System.Windows.Forms.TextBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtXmlBefore = New System.Windows.Forms.TextBox()
        Me.txtXmlAfter = New System.Windows.Forms.TextBox()
        Me.lblPreviewBefore = New System.Windows.Forms.Label()
        Me.lblPreviewAfter = New System.Windows.Forms.Label()
        Me.chkShowFAHCfg = New System.Windows.Forms.CheckBox()
        Me.gbxFAHVerifyConfig = New System.Windows.Forms.GroupBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnTelnetSave = New System.Windows.Forms.Button()
        Me.txtTelnetFAHCfg = New System.Windows.Forms.TextBox()
        Me.lblTelnet = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxTeamSelection.SuspendLayout()
        Me.gbxUsername.SuspendLayout()
        Me.gbxPasskey.SuspendLayout()
        Me.gbxConfigPreview.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbxFAHVerifyConfig.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(7, 83)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(142, 22)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Existing users can paste their entire FAH username here")
        '
        'lblPasskeyFromEmail
        '
        Me.lblPasskeyFromEmail.AutoSize = True
        Me.lblPasskeyFromEmail.Location = New System.Drawing.Point(123, 77)
        Me.lblPasskeyFromEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasskeyFromEmail.Name = "lblPasskeyFromEmail"
        Me.lblPasskeyFromEmail.Size = New System.Drawing.Size(200, 16)
        Me.lblPasskeyFromEmail.TabIndex = 1
        Me.lblPasskeyFromEmail.Text = "Enter Passkey From Your Email:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(487, 526)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(389, 526)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 34)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblUsernamePreview
        '
        Me.lblUsernamePreview.AutoSize = True
        Me.lblUsernamePreview.BackColor = System.Drawing.Color.White
        Me.lblUsernamePreview.Location = New System.Drawing.Point(25, 36)
        Me.lblUsernamePreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsernamePreview.Name = "lblUsernamePreview"
        Me.lblUsernamePreview.Size = New System.Drawing.Size(119, 16)
        Me.lblUsernamePreview.TabIndex = 1
        Me.lblUsernamePreview.Text = "UsernamePreview"
        Me.lblUsernamePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(51, 24)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(352, 22)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbnFoldingCoin
        '
        Me.rbnFoldingCoin.AutoSize = True
        Me.rbnFoldingCoin.BackColor = System.Drawing.SystemColors.Window
        Me.rbnFoldingCoin.Location = New System.Drawing.Point(50, 48)
        Me.rbnFoldingCoin.Margin = New System.Windows.Forms.Padding(4)
        Me.rbnFoldingCoin.Name = "rbnFoldingCoin"
        Me.rbnFoldingCoin.Size = New System.Drawing.Size(151, 20)
        Me.rbnFoldingCoin.TabIndex = 1
        Me.rbnFoldingCoin.Text = "FoldingCoin (226728)"
        Me.rbnFoldingCoin.UseVisualStyleBackColor = False
        '
        'rbnCureCoin
        '
        Me.rbnCureCoin.AutoSize = True
        Me.rbnCureCoin.BackColor = System.Drawing.SystemColors.Window
        Me.rbnCureCoin.Checked = True
        Me.rbnCureCoin.Location = New System.Drawing.Point(50, 23)
        Me.rbnCureCoin.Margin = New System.Windows.Forms.Padding(4)
        Me.rbnCureCoin.Name = "rbnCureCoin"
        Me.rbnCureCoin.Size = New System.Drawing.Size(134, 20)
        Me.rbnCureCoin.TabIndex = 0
        Me.rbnCureCoin.TabStop = True
        Me.rbnCureCoin.Text = "CureCoin (224497)"
        Me.rbnCureCoin.UseVisualStyleBackColor = False
        '
        'rbnOtherTeam
        '
        Me.rbnOtherTeam.AutoSize = True
        Me.rbnOtherTeam.BackColor = System.Drawing.SystemColors.Window
        Me.rbnOtherTeam.Location = New System.Drawing.Point(50, 73)
        Me.rbnOtherTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.rbnOtherTeam.Name = "rbnOtherTeam"
        Me.rbnOtherTeam.Size = New System.Drawing.Size(100, 20)
        Me.rbnOtherTeam.TabIndex = 2
        Me.rbnOtherTeam.Text = "Other Team:"
        Me.rbnOtherTeam.UseVisualStyleBackColor = False
        '
        'txtOtherTeam
        '
        Me.txtOtherTeam.Location = New System.Drawing.Point(149, 72)
        Me.txtOtherTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOtherTeam.Name = "txtOtherTeam"
        Me.txtOtherTeam.Size = New System.Drawing.Size(120, 22)
        Me.txtOtherTeam.TabIndex = 3
        Me.txtOtherTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxTeamSelection
        '
        Me.gbxTeamSelection.Controls.Add(Me.lblTeamNumber)
        Me.gbxTeamSelection.Controls.Add(Me.lblTeam)
        Me.gbxTeamSelection.Controls.Add(Me.lllTeamNumbersLink)
        Me.gbxTeamSelection.Controls.Add(Me.lblTeamNotes)
        Me.gbxTeamSelection.Controls.Add(Me.rbnCureCoin)
        Me.gbxTeamSelection.Controls.Add(Me.rbnFoldingCoin)
        Me.gbxTeamSelection.Controls.Add(Me.txtOtherTeam)
        Me.gbxTeamSelection.Controls.Add(Me.rbnOtherTeam)
        Me.gbxTeamSelection.Location = New System.Drawing.Point(44, 129)
        Me.gbxTeamSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxTeamSelection.Name = "gbxTeamSelection"
        Me.gbxTeamSelection.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxTeamSelection.Size = New System.Drawing.Size(533, 154)
        Me.gbxTeamSelection.TabIndex = 7
        Me.gbxTeamSelection.TabStop = False
        Me.gbxTeamSelection.Text = "Team Number Selection"
        '
        'lblTeamNumber
        '
        Me.lblTeamNumber.AutoSize = True
        Me.lblTeamNumber.BackColor = System.Drawing.Color.White
        Me.lblTeamNumber.Location = New System.Drawing.Point(432, 0)
        Me.lblTeamNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeamNumber.Name = "lblTeamNumber"
        Me.lblTeamNumber.Size = New System.Drawing.Size(50, 16)
        Me.lblTeamNumber.TabIndex = 9
        Me.lblTeamNumber.Text = "224497"
        Me.lblTeamNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(387, 0)
        Me.lblTeam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(47, 16)
        Me.lblTeam.TabIndex = 9
        Me.lblTeam.Text = "Team:"
        Me.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lllTeamNumbersLink
        '
        Me.lllTeamNumbersLink.AutoSize = True
        Me.lllTeamNumbersLink.Location = New System.Drawing.Point(78, 131)
        Me.lllTeamNumbersLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lllTeamNumbersLink.Name = "lllTeamNumbersLink"
        Me.lllTeamNumbersLink.Size = New System.Drawing.Size(227, 16)
        Me.lllTeamNumbersLink.TabIndex = 5
        Me.lllTeamNumbersLink.TabStop = True
        Me.lllTeamNumbersLink.Text = "https://stats.foldingathome.org/teams"
        '
        'lblTeamNotes
        '
        Me.lblTeamNotes.AutoSize = True
        Me.lblTeamNotes.Location = New System.Drawing.Point(5, 99)
        Me.lblTeamNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeamNotes.Name = "lblTeamNotes"
        Me.lblTeamNotes.Size = New System.Drawing.Size(442, 48)
        Me.lblTeamNotes.TabIndex = 7
        Me.lblTeamNotes.Text = "NOTE: You can fold on any team and earn FoldingCoin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Folding on team CureCoin al" &
    "lows earning both FoldingCoin and CureCoin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team List:"
        '
        'btnGetPasskey
        '
        Me.btnGetPasskey.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGetPasskey.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnGetPasskey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetPasskey.Location = New System.Drawing.Point(411, 18)
        Me.btnGetPasskey.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetPasskey.Name = "btnGetPasskey"
        Me.btnGetPasskey.Size = New System.Drawing.Size(115, 34)
        Me.btnGetPasskey.TabIndex = 1
        Me.btnGetPasskey.Text = "Get Passkey"
        Me.btnGetPasskey.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(42, 65)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(71, 16)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(151, 65)
        Me.lblSeparator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(68, 16)
        Me.lblSeparator.TabIndex = 1
        Me.lblSeparator.Text = "Separator"
        '
        'txtBitcoinAddress
        '
        Me.txtBitcoinAddress.Location = New System.Drawing.Point(223, 83)
        Me.txtBitcoinAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBitcoinAddress.Name = "txtBitcoinAddress"
        Me.txtBitcoinAddress.Size = New System.Drawing.Size(303, 22)
        Me.txtBitcoinAddress.TabIndex = 2
        Me.txtBitcoinAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtBitcoinAddress, "BTC address must be compatible with Counterparty." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do Not Use An Exchange BTC/FLD" &
        "C Address:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     You will lose other Merged Folding tokens")
        '
        'lblBitcoinAddress
        '
        Me.lblBitcoinAddress.AutoSize = True
        Me.lblBitcoinAddress.Location = New System.Drawing.Point(279, 65)
        Me.lblBitcoinAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBitcoinAddress.Name = "lblBitcoinAddress"
        Me.lblBitcoinAddress.Size = New System.Drawing.Size(181, 16)
        Me.lblBitcoinAddress.TabIndex = 1
        Me.lblBitcoinAddress.Text = "Counterparty Bitcoin Address"
        '
        'lblPasskeyNotes
        '
        Me.lblPasskeyNotes.AutoSize = True
        Me.lblPasskeyNotes.Location = New System.Drawing.Point(23, 48)
        Me.lblPasskeyNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasskeyNotes.Name = "lblPasskeyNotes"
        Me.lblPasskeyNotes.Size = New System.Drawing.Size(380, 16)
        Me.lblPasskeyNotes.TabIndex = 1
        Me.lblPasskeyNotes.Text = "NOTE: Getting a passkey increases the folding points you earn"
        '
        'gbxUsername
        '
        Me.gbxUsername.Controls.Add(Me.pnlDivider)
        Me.gbxUsername.Controls.Add(Me.cbxSeparator)
        Me.gbxUsername.Controls.Add(Me.lblUsernamePreview)
        Me.gbxUsername.Controls.Add(Me.lblErrorNote)
        Me.gbxUsername.Controls.Add(Me.lblBitcoinAddress)
        Me.gbxUsername.Controls.Add(Me.lblSeparator)
        Me.gbxUsername.Controls.Add(Me.lblUsername)
        Me.gbxUsername.Controls.Add(Me.txtBitcoinAddress)
        Me.gbxUsername.Controls.Add(Me.txtUsername)
        Me.gbxUsername.Location = New System.Drawing.Point(44, 4)
        Me.gbxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxUsername.Name = "gbxUsername"
        Me.gbxUsername.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxUsername.Size = New System.Drawing.Size(533, 117)
        Me.gbxUsername.TabIndex = 10
        Me.gbxUsername.TabStop = False
        Me.gbxUsername.Text = "Username (Case Sensitive)"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlDivider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlDivider.Location = New System.Drawing.Point(26, 55)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(482, 2)
        Me.pnlDivider.TabIndex = 9
        '
        'cbxSeparator
        '
        Me.cbxSeparator.FormattingEnabled = True
        Me.cbxSeparator.Items.AddRange(New Object() {"_", "_ALL_", "_FLDC_"})
        Me.cbxSeparator.Location = New System.Drawing.Point(151, 83)
        Me.cbxSeparator.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxSeparator.Name = "cbxSeparator"
        Me.cbxSeparator.Size = New System.Drawing.Size(70, 24)
        Me.cbxSeparator.TabIndex = 1
        Me.cbxSeparator.Text = "_"
        '
        'lblErrorNote
        '
        Me.lblErrorNote.AutoSize = True
        Me.lblErrorNote.BackColor = System.Drawing.Color.Tomato
        Me.lblErrorNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblErrorNote.Location = New System.Drawing.Point(76, 17)
        Me.lblErrorNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorNote.Name = "lblErrorNote"
        Me.lblErrorNote.Size = New System.Drawing.Size(42, 18)
        Me.lblErrorNote.TabIndex = 7
        Me.lblErrorNote.Text = "Note:"
        Me.lblErrorNote.Visible = False
        '
        'gbxPasskey
        '
        Me.gbxPasskey.Controls.Add(Me.btnGetPasskey)
        Me.gbxPasskey.Controls.Add(Me.txtPasskey)
        Me.gbxPasskey.Controls.Add(Me.txtEmail)
        Me.gbxPasskey.Controls.Add(Me.lblPasskeyError)
        Me.gbxPasskey.Controls.Add(Me.lblPasskeyNotes)
        Me.gbxPasskey.Controls.Add(Me.lblPasskeyFromEmail)
        Me.gbxPasskey.Controls.Add(Me.lblEmail)
        Me.gbxPasskey.Location = New System.Drawing.Point(44, 291)
        Me.gbxPasskey.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxPasskey.Name = "gbxPasskey"
        Me.gbxPasskey.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxPasskey.Size = New System.Drawing.Size(533, 123)
        Me.gbxPasskey.TabIndex = 11
        Me.gbxPasskey.TabStop = False
        Me.gbxPasskey.Text = "Get Passkey by Email (Optional)"
        '
        'txtPasskey
        '
        Me.txtPasskey.Location = New System.Drawing.Point(125, 95)
        Me.txtPasskey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPasskey.Name = "txtPasskey"
        Me.txtPasskey.Size = New System.Drawing.Size(401, 22)
        Me.txtPasskey.TabIndex = 2
        Me.txtPasskey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPasskeyError
        '
        Me.lblPasskeyError.AutoSize = True
        Me.lblPasskeyError.BackColor = System.Drawing.Color.Tomato
        Me.lblPasskeyError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPasskeyError.Location = New System.Drawing.Point(378, 75)
        Me.lblPasskeyError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasskeyError.Name = "lblPasskeyError"
        Me.lblPasskeyError.Size = New System.Drawing.Size(131, 18)
        Me.lblPasskeyError.TabIndex = 1
        Me.lblPasskeyError.Text = "(Should be 32 digits)"
        Me.lblPasskeyError.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 27)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(-4, 35)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(18, 16)
        Me.lbl1.TabIndex = 12
        Me.lbl1.Text = "1."
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl2.Location = New System.Drawing.Point(-4, 169)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(18, 16)
        Me.lbl2.TabIndex = 13
        Me.lbl2.Text = "2."
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl3.Location = New System.Drawing.Point(-4, 324)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(18, 16)
        Me.lbl3.TabIndex = 14
        Me.lbl3.Text = "3."
        '
        'gbxConfigPreview
        '
        Me.gbxConfigPreview.BackColor = System.Drawing.SystemColors.Window
        Me.gbxConfigPreview.Controls.Add(Me.txtCfgPath)
        Me.gbxConfigPreview.Controls.Add(Me.btnReload)
        Me.gbxConfigPreview.Controls.Add(Me.SplitContainer1)
        Me.gbxConfigPreview.Controls.Add(Me.lblPreviewBefore)
        Me.gbxConfigPreview.Controls.Add(Me.lblPreviewAfter)
        Me.gbxConfigPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxConfigPreview.Location = New System.Drawing.Point(0, 0)
        Me.gbxConfigPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxConfigPreview.Name = "gbxConfigPreview"
        Me.gbxConfigPreview.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxConfigPreview.Size = New System.Drawing.Size(526, 572)
        Me.gbxConfigPreview.TabIndex = 15
        Me.gbxConfigPreview.TabStop = False
        Me.gbxConfigPreview.Text = "Folding@Home Config File Preview:"
        '
        'txtCfgPath
        '
        Me.txtCfgPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCfgPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtCfgPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCfgPath.Location = New System.Drawing.Point(265, 0)
        Me.txtCfgPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCfgPath.Multiline = True
        Me.txtCfgPath.Name = "txtCfgPath"
        Me.txtCfgPath.ReadOnly = True
        Me.txtCfgPath.Size = New System.Drawing.Size(253, 23)
        Me.txtCfgPath.TabIndex = 3
        Me.txtCfgPath.Text = "Path"
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(381, 23)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(111, 30)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload XML"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 41)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtXmlBefore)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtXmlAfter)
        Me.SplitContainer1.Size = New System.Drawing.Size(510, 524)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'txtXmlBefore
        '
        Me.txtXmlBefore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtXmlBefore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXmlBefore.Location = New System.Drawing.Point(0, 0)
        Me.txtXmlBefore.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXmlBefore.Multiline = True
        Me.txtXmlBefore.Name = "txtXmlBefore"
        Me.txtXmlBefore.ReadOnly = True
        Me.txtXmlBefore.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXmlBefore.Size = New System.Drawing.Size(226, 522)
        Me.txtXmlBefore.TabIndex = 0
        Me.txtXmlBefore.WordWrap = False
        '
        'txtXmlAfter
        '
        Me.txtXmlAfter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtXmlAfter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXmlAfter.Location = New System.Drawing.Point(0, 0)
        Me.txtXmlAfter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXmlAfter.Multiline = True
        Me.txtXmlAfter.Name = "txtXmlAfter"
        Me.txtXmlAfter.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXmlAfter.Size = New System.Drawing.Size(277, 522)
        Me.txtXmlAfter.TabIndex = 0
        Me.txtXmlAfter.WordWrap = False
        '
        'lblPreviewBefore
        '
        Me.lblPreviewBefore.AutoSize = True
        Me.lblPreviewBefore.BackColor = System.Drawing.Color.Transparent
        Me.lblPreviewBefore.Location = New System.Drawing.Point(115, 21)
        Me.lblPreviewBefore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreviewBefore.Name = "lblPreviewBefore"
        Me.lblPreviewBefore.Size = New System.Drawing.Size(51, 16)
        Me.lblPreviewBefore.TabIndex = 1
        Me.lblPreviewBefore.Text = "Before:"
        '
        'lblPreviewAfter
        '
        Me.lblPreviewAfter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPreviewAfter.AutoSize = True
        Me.lblPreviewAfter.BackColor = System.Drawing.Color.Transparent
        Me.lblPreviewAfter.Location = New System.Drawing.Point(254, 21)
        Me.lblPreviewAfter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreviewAfter.Name = "lblPreviewAfter"
        Me.lblPreviewAfter.Size = New System.Drawing.Size(38, 16)
        Me.lblPreviewAfter.TabIndex = 2
        Me.lblPreviewAfter.Text = "After:"
        '
        'chkShowFAHCfg
        '
        Me.chkShowFAHCfg.AutoSize = True
        Me.chkShowFAHCfg.Checked = True
        Me.chkShowFAHCfg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowFAHCfg.Location = New System.Drawing.Point(408, 61)
        Me.chkShowFAHCfg.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowFAHCfg.Name = "chkShowFAHCfg"
        Me.chkShowFAHCfg.Size = New System.Drawing.Size(117, 20)
        Me.chkShowFAHCfg.TabIndex = 5
        Me.chkShowFAHCfg.Text = "Show Changes"
        Me.chkShowFAHCfg.UseVisualStyleBackColor = True
        '
        'gbxFAHVerifyConfig
        '
        Me.gbxFAHVerifyConfig.Controls.Add(Me.txtPwd)
        Me.gbxFAHVerifyConfig.Controls.Add(Me.txtPort)
        Me.gbxFAHVerifyConfig.Controls.Add(Me.txtAddress)
        Me.gbxFAHVerifyConfig.Controls.Add(Me.btnTelnetSave)
        Me.gbxFAHVerifyConfig.Controls.Add(Me.txtTelnetFAHCfg)
        Me.gbxFAHVerifyConfig.Controls.Add(Me.chkShowFAHCfg)
        Me.gbxFAHVerifyConfig.Controls.Add(Me.lblTelnet)
        Me.gbxFAHVerifyConfig.Location = New System.Drawing.Point(44, 422)
        Me.gbxFAHVerifyConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxFAHVerifyConfig.Name = "gbxFAHVerifyConfig"
        Me.gbxFAHVerifyConfig.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxFAHVerifyConfig.Size = New System.Drawing.Size(533, 94)
        Me.gbxFAHVerifyConfig.TabIndex = 17
        Me.gbxFAHVerifyConfig.TabStop = False
        Me.gbxFAHVerifyConfig.Text = "Save Folding@Home Changes"
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.SystemColors.Control
        Me.txtPwd.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPwd.Location = New System.Drawing.Point(249, 59)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(43, 22)
        Me.txtPwd.TabIndex = 3
        Me.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPwd, "Telnet FAH Password (blank, unless you've set a FAH PW)")
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.Control
        Me.txtPort.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPort.Location = New System.Drawing.Point(185, 59)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(59, 22)
        Me.txtPort.TabIndex = 2
        Me.txtPort.Text = "36330"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPort, "Telnet Port (FAH default: 36330)")
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtAddress.Location = New System.Drawing.Point(57, 59)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(123, 22)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.Text = "localhost"
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtAddress, "Telnet Address (IP or Hostname). Default: localhost")
        '
        'btnTelnetSave
        '
        Me.btnTelnetSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnTelnetSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnTelnetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTelnetSave.Location = New System.Drawing.Point(300, 53)
        Me.btnTelnetSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTelnetSave.Name = "btnTelnetSave"
        Me.btnTelnetSave.Size = New System.Drawing.Size(100, 34)
        Me.btnTelnetSave.TabIndex = 4
        Me.btnTelnetSave.Text = "Save"
        Me.btnTelnetSave.UseVisualStyleBackColor = True
        '
        'txtTelnetFAHCfg
        '
        Me.txtTelnetFAHCfg.BackColor = System.Drawing.SystemColors.Control
        Me.txtTelnetFAHCfg.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtTelnetFAHCfg.Location = New System.Drawing.Point(7, 26)
        Me.txtTelnetFAHCfg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelnetFAHCfg.Name = "txtTelnetFAHCfg"
        Me.txtTelnetFAHCfg.Size = New System.Drawing.Size(519, 22)
        Me.txtTelnetFAHCfg.TabIndex = 0
        '
        'lblTelnet
        '
        Me.lblTelnet.AutoSize = True
        Me.lblTelnet.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTelnet.Location = New System.Drawing.Point(7, 62)
        Me.lblTelnet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelnet.Name = "lblTelnet"
        Me.lblTelnet.Size = New System.Drawing.Size(49, 16)
        Me.lblTelnet.TabIndex = 21
        Me.lblTelnet.Text = "Telnet:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl4.Location = New System.Drawing.Point(-4, 442)
        Me.lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(18, 16)
        Me.lbl4.TabIndex = 18
        Me.lbl4.Text = "4."
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbxFAHVerifyConfig)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnOK)
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbxPasskey)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnCancel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbxUsername)
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbxTeamSelection)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer2.Panel2.Controls.Add(Me.gbxConfigPreview)
        Me.SplitContainer2.Panel2MinSize = 2
        Me.SplitContainer2.Size = New System.Drawing.Size(1118, 574)
        Me.SplitContainer2.SplitterDistance = 587
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 19
        '
        'FAHSetupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1118, 574)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FAHSetupDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Folding@Home Setup - Username and Team Selection"
        Me.gbxTeamSelection.ResumeLayout(False)
        Me.gbxTeamSelection.PerformLayout()
        Me.gbxUsername.ResumeLayout(False)
        Me.gbxUsername.PerformLayout()
        Me.gbxPasskey.ResumeLayout(False)
        Me.gbxPasskey.PerformLayout()
        Me.gbxConfigPreview.ResumeLayout(False)
        Me.gbxConfigPreview.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbxFAHVerifyConfig.ResumeLayout(False)
        Me.gbxFAHVerifyConfig.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPasskeyFromEmail As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblUsernamePreview As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents rbnFoldingCoin As RadioButton
    Friend WithEvents rbnCureCoin As RadioButton
    Friend WithEvents rbnOtherTeam As RadioButton
    Friend WithEvents txtOtherTeam As TextBox
    Friend WithEvents gbxTeamSelection As GroupBox
    Friend WithEvents lblTeamNotes As Label
    Friend WithEvents btnGetPasskey As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents txtBitcoinAddress As TextBox
    Friend WithEvents lblBitcoinAddress As Label
    Friend WithEvents lblPasskeyNotes As Label
    Friend WithEvents lllTeamNumbersLink As LinkLabel
    Friend WithEvents gbxUsername As GroupBox
    Friend WithEvents gbxPasskey As GroupBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents cbxSeparator As ComboBox
    Friend WithEvents txtPasskey As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents gbxConfigPreview As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblPreviewAfter As Label
    Friend WithEvents lblPreviewBefore As Label
    Friend WithEvents lblTeamNumber As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblErrorNote As Label
    Friend WithEvents txtCfgPath As TextBox
    Friend WithEvents txtXmlBefore As TextBox
    Friend WithEvents txtXmlAfter As TextBox
    Friend WithEvents chkShowFAHCfg As CheckBox
    Friend WithEvents gbxFAHVerifyConfig As GroupBox
    Friend WithEvents lblPasskeyError As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtTelnetFAHCfg As TextBox
    Friend WithEvents btnTelnetSave As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblTelnet As Label
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents pnlDivider As Panel
End Class
