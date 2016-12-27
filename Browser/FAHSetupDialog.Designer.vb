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
        Me.btnReload = New System.Windows.Forms.Button()
        Me.txtCfgPath = New System.Windows.Forms.TextBox()
        Me.lblPreviewAfter = New System.Windows.Forms.Label()
        Me.lblPreviewBefore = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtXmlBefore = New System.Windows.Forms.TextBox()
        Me.txtXmlAfter = New System.Windows.Forms.TextBox()
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
        Me.txtUsername.Location = New System.Drawing.Point(4, 78)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(111, 24)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Existing users can paste their entire FAH username here")
        '
        'lblPasskeyFromEmail
        '
        Me.lblPasskeyFromEmail.AutoSize = True
        Me.lblPasskeyFromEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasskeyFromEmail.Location = New System.Drawing.Point(184, 69)
        Me.lblPasskeyFromEmail.Name = "lblPasskeyFromEmail"
        Me.lblPasskeyFromEmail.Size = New System.Drawing.Size(224, 18)
        Me.lblPasskeyFromEmail.TabIndex = 1
        Me.lblPasskeyFromEmail.Text = "Enter Passkey From Your Email:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(997, 542)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(901, 542)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblUsernamePreview
        '
        Me.lblUsernamePreview.AutoSize = True
        Me.lblUsernamePreview.BackColor = System.Drawing.Color.White
        Me.lblUsernamePreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernamePreview.Location = New System.Drawing.Point(9, 30)
        Me.lblUsernamePreview.Name = "lblUsernamePreview"
        Me.lblUsernamePreview.Size = New System.Drawing.Size(144, 18)
        Me.lblUsernamePreview.TabIndex = 1
        Me.lblUsernamePreview.Text = "UsernamePreview"
        Me.lblUsernamePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(52, 24)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(345, 24)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbnFoldingCoin
        '
        Me.rbnFoldingCoin.AutoSize = True
        Me.rbnFoldingCoin.Location = New System.Drawing.Point(62, 49)
        Me.rbnFoldingCoin.Name = "rbnFoldingCoin"
        Me.rbnFoldingCoin.Size = New System.Drawing.Size(167, 22)
        Me.rbnFoldingCoin.TabIndex = 1
        Me.rbnFoldingCoin.Text = "FoldingCoin (226728)"
        Me.rbnFoldingCoin.UseVisualStyleBackColor = True
        '
        'rbnCureCoin
        '
        Me.rbnCureCoin.AutoSize = True
        Me.rbnCureCoin.Checked = True
        Me.rbnCureCoin.Location = New System.Drawing.Point(62, 23)
        Me.rbnCureCoin.Name = "rbnCureCoin"
        Me.rbnCureCoin.Size = New System.Drawing.Size(151, 22)
        Me.rbnCureCoin.TabIndex = 0
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
        Me.rbnOtherTeam.TabIndex = 2
        Me.rbnOtherTeam.Text = "Other Team:"
        Me.rbnOtherTeam.UseVisualStyleBackColor = True
        '
        'txtOtherTeam
        '
        Me.txtOtherTeam.Location = New System.Drawing.Point(172, 75)
        Me.txtOtherTeam.Name = "txtOtherTeam"
        Me.txtOtherTeam.Size = New System.Drawing.Size(91, 24)
        Me.txtOtherTeam.TabIndex = 3
        Me.txtOtherTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxTeamSelection
        '
        Me.gbxTeamSelection.Controls.Add(Me.lblTeamNumber)
        Me.gbxTeamSelection.Controls.Add(Me.lblTeam)
        Me.gbxTeamSelection.Controls.Add(Me.lllTeamNumbersLink)
        Me.gbxTeamSelection.Controls.Add(Me.lblTeamNotes)
        Me.gbxTeamSelection.Controls.Add(Me.rbnOtherTeam)
        Me.gbxTeamSelection.Controls.Add(Me.rbnCureCoin)
        Me.gbxTeamSelection.Controls.Add(Me.rbnFoldingCoin)
        Me.gbxTeamSelection.Controls.Add(Me.txtOtherTeam)
        Me.gbxTeamSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTeamSelection.Location = New System.Drawing.Point(43, 128)
        Me.gbxTeamSelection.Name = "gbxTeamSelection"
        Me.gbxTeamSelection.Size = New System.Drawing.Size(510, 171)
        Me.gbxTeamSelection.TabIndex = 7
        Me.gbxTeamSelection.TabStop = False
        Me.gbxTeamSelection.Text = "Team Number Selection"
        '
        'lblTeamNumber
        '
        Me.lblTeamNumber.AutoSize = True
        Me.lblTeamNumber.BackColor = System.Drawing.Color.White
        Me.lblTeamNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamNumber.Location = New System.Drawing.Point(425, 0)
        Me.lblTeamNumber.Name = "lblTeamNumber"
        Me.lblTeamNumber.Size = New System.Drawing.Size(62, 18)
        Me.lblTeamNumber.TabIndex = 9
        Me.lblTeamNumber.Text = "224497"
        Me.lblTeamNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(371, 0)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(55, 18)
        Me.lblTeam.TabIndex = 9
        Me.lblTeam.Text = "Team:"
        Me.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lllTeamNumbersLink
        '
        Me.lllTeamNumbersLink.AutoSize = True
        Me.lllTeamNumbersLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lllTeamNumbersLink.Location = New System.Drawing.Point(90, 146)
        Me.lllTeamNumbersLink.Name = "lllTeamNumbersLink"
        Me.lllTeamNumbersLink.Size = New System.Drawing.Size(298, 13)
        Me.lllTeamNumbersLink.TabIndex = 5
        Me.lllTeamNumbersLink.TabStop = True
        Me.lllTeamNumbersLink.Text = "http://fah-web.stanford.edu/cgi-bin/main.py?qtype=teamstats"
        '
        'lblTeamNotes
        '
        Me.lblTeamNotes.AutoSize = True
        Me.lblTeamNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamNotes.Location = New System.Drawing.Point(35, 107)
        Me.lblTeamNotes.Name = "lblTeamNotes"
        Me.lblTeamNotes.Size = New System.Drawing.Size(350, 52)
        Me.lblTeamNotes.TabIndex = 7
        Me.lblTeamNotes.Text = "NOTE: You can fold on any team and earn FoldingCoin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Folding on team CureCoin al" &
    "lows earning both FoldingCoin and CureCoin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team List:"
        '
        'btnGetPasskey
        '
        Me.btnGetPasskey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPasskey.Location = New System.Drawing.Point(402, 22)
        Me.btnGetPasskey.Name = "btnGetPasskey"
        Me.btnGetPasskey.Size = New System.Drawing.Size(103, 27)
        Me.btnGetPasskey.TabIndex = 1
        Me.btnGetPasskey.Text = "Get Passkey"
        Me.btnGetPasskey.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(20, 57)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(77, 18)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparator.Location = New System.Drawing.Point(117, 57)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(73, 18)
        Me.lblSeparator.TabIndex = 1
        Me.lblSeparator.Text = "Separator"
        '
        'txtBitcoinAddress
        '
        Me.txtBitcoinAddress.Location = New System.Drawing.Point(189, 78)
        Me.txtBitcoinAddress.Name = "txtBitcoinAddress"
        Me.txtBitcoinAddress.Size = New System.Drawing.Size(316, 24)
        Me.txtBitcoinAddress.TabIndex = 2
        Me.txtBitcoinAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtBitcoinAddress, "BTC address must be compatible with Counterparty." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do Not Use An Exchange BTC/FLD" &
        "C Address:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     You will lose other Merged Folding tokens")
        '
        'lblBitcoinAddress
        '
        Me.lblBitcoinAddress.AutoSize = True
        Me.lblBitcoinAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBitcoinAddress.Location = New System.Drawing.Point(245, 57)
        Me.lblBitcoinAddress.Name = "lblBitcoinAddress"
        Me.lblBitcoinAddress.Size = New System.Drawing.Size(200, 18)
        Me.lblBitcoinAddress.TabIndex = 1
        Me.lblBitcoinAddress.Text = "Counterparty Bitcoin Address"
        '
        'lblPasskeyNotes
        '
        Me.lblPasskeyNotes.AutoSize = True
        Me.lblPasskeyNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasskeyNotes.Location = New System.Drawing.Point(63, 47)
        Me.lblPasskeyNotes.Name = "lblPasskeyNotes"
        Me.lblPasskeyNotes.Size = New System.Drawing.Size(303, 13)
        Me.lblPasskeyNotes.TabIndex = 1
        Me.lblPasskeyNotes.Text = "NOTE: Getting a passkey increases the folding points you earn"
        '
        'gbxUsername
        '
        Me.gbxUsername.Controls.Add(Me.cbxSeparator)
        Me.gbxUsername.Controls.Add(Me.lblUsernamePreview)
        Me.gbxUsername.Controls.Add(Me.lblErrorNote)
        Me.gbxUsername.Controls.Add(Me.lblBitcoinAddress)
        Me.gbxUsername.Controls.Add(Me.lblSeparator)
        Me.gbxUsername.Controls.Add(Me.lblUsername)
        Me.gbxUsername.Controls.Add(Me.txtBitcoinAddress)
        Me.gbxUsername.Controls.Add(Me.txtUsername)
        Me.gbxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxUsername.Location = New System.Drawing.Point(43, 7)
        Me.gbxUsername.Name = "gbxUsername"
        Me.gbxUsername.Size = New System.Drawing.Size(510, 109)
        Me.gbxUsername.TabIndex = 10
        Me.gbxUsername.TabStop = False
        Me.gbxUsername.Text = "Username (Case Sensitive)"
        '
        'cbxSeparator
        '
        Me.cbxSeparator.FormattingEnabled = True
        Me.cbxSeparator.Items.AddRange(New Object() {"_", "_ALL_", "_FLDC_"})
        Me.cbxSeparator.Location = New System.Drawing.Point(116, 78)
        Me.cbxSeparator.Name = "cbxSeparator"
        Me.cbxSeparator.Size = New System.Drawing.Size(72, 26)
        Me.cbxSeparator.TabIndex = 1
        Me.cbxSeparator.Text = "_ALL_"
        '
        'lblErrorNote
        '
        Me.lblErrorNote.AutoSize = True
        Me.lblErrorNote.BackColor = System.Drawing.Color.Tomato
        Me.lblErrorNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorNote.Location = New System.Drawing.Point(201, 12)
        Me.lblErrorNote.Name = "lblErrorNote"
        Me.lblErrorNote.Size = New System.Drawing.Size(33, 13)
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
        Me.gbxPasskey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPasskey.Location = New System.Drawing.Point(43, 313)
        Me.gbxPasskey.Name = "gbxPasskey"
        Me.gbxPasskey.Size = New System.Drawing.Size(510, 118)
        Me.gbxPasskey.TabIndex = 11
        Me.gbxPasskey.TabStop = False
        Me.gbxPasskey.Text = "Get Passkey by Email (Optional)"
        '
        'txtPasskey
        '
        Me.txtPasskey.Location = New System.Drawing.Point(186, 88)
        Me.txtPasskey.Name = "txtPasskey"
        Me.txtPasskey.Size = New System.Drawing.Size(319, 24)
        Me.txtPasskey.TabIndex = 2
        Me.txtPasskey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPasskeyError
        '
        Me.lblPasskeyError.AutoSize = True
        Me.lblPasskeyError.BackColor = System.Drawing.Color.Tomato
        Me.lblPasskeyError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasskeyError.Location = New System.Drawing.Point(417, 73)
        Me.lblPasskeyError.Name = "lblPasskeyError"
        Me.lblPasskeyError.Size = New System.Drawing.Size(52, 13)
        Me.lblPasskeyError.TabIndex = 1
        Me.lblPasskeyError.Text = "(32 digits)"
        Me.lblPasskeyError.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(4, 27)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 18)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(-8, 42)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(66, 55)
        Me.lbl1.TabIndex = 12
        Me.lbl1.Text = "1."
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl2.Location = New System.Drawing.Point(-8, 155)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(66, 55)
        Me.lbl2.TabIndex = 13
        Me.lbl2.Text = "2."
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl3.Location = New System.Drawing.Point(-8, 333)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(66, 55)
        Me.lbl3.TabIndex = 14
        Me.lbl3.Text = "3."
        '
        'gbxConfigPreview
        '
        Me.gbxConfigPreview.Controls.Add(Me.btnReload)
        Me.gbxConfigPreview.Controls.Add(Me.txtCfgPath)
        Me.gbxConfigPreview.Controls.Add(Me.lblPreviewAfter)
        Me.gbxConfigPreview.Controls.Add(Me.lblPreviewBefore)
        Me.gbxConfigPreview.Controls.Add(Me.SplitContainer1)
        Me.gbxConfigPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxConfigPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxConfigPreview.Location = New System.Drawing.Point(0, 0)
        Me.gbxConfigPreview.Name = "gbxConfigPreview"
        Me.gbxConfigPreview.Size = New System.Drawing.Size(548, 532)
        Me.gbxConfigPreview.TabIndex = 15
        Me.gbxConfigPreview.TabStop = False
        Me.gbxConfigPreview.Text = "Folding@Home Config File Preview:"
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReload.Location = New System.Drawing.Point(413, 18)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(103, 27)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload XML"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'txtCfgPath
        '
        Me.txtCfgPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCfgPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtCfgPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCfgPath.Location = New System.Drawing.Point(253, 1)
        Me.txtCfgPath.Name = "txtCfgPath"
        Me.txtCfgPath.ReadOnly = True
        Me.txtCfgPath.Size = New System.Drawing.Size(289, 17)
        Me.txtCfgPath.TabIndex = 3
        Me.txtCfgPath.Text = "Path"
        '
        'lblPreviewAfter
        '
        Me.lblPreviewAfter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPreviewAfter.AutoSize = True
        Me.lblPreviewAfter.BackColor = System.Drawing.SystemColors.Window
        Me.lblPreviewAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreviewAfter.Location = New System.Drawing.Point(361, 21)
        Me.lblPreviewAfter.Name = "lblPreviewAfter"
        Me.lblPreviewAfter.Size = New System.Drawing.Size(44, 20)
        Me.lblPreviewAfter.TabIndex = 2
        Me.lblPreviewAfter.Text = "After:"
        '
        'lblPreviewBefore
        '
        Me.lblPreviewBefore.AutoSize = True
        Me.lblPreviewBefore.BackColor = System.Drawing.SystemColors.Window
        Me.lblPreviewBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreviewBefore.Location = New System.Drawing.Point(86, 21)
        Me.lblPreviewBefore.Name = "lblPreviewBefore"
        Me.lblPreviewBefore.Size = New System.Drawing.Size(58, 20)
        Me.lblPreviewBefore.TabIndex = 1
        Me.lblPreviewBefore.Text = "Before:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 33)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(536, 493)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        '
        'txtXmlBefore
        '
        Me.txtXmlBefore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtXmlBefore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXmlBefore.Location = New System.Drawing.Point(0, 0)
        Me.txtXmlBefore.Multiline = True
        Me.txtXmlBefore.Name = "txtXmlBefore"
        Me.txtXmlBefore.ReadOnly = True
        Me.txtXmlBefore.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXmlBefore.Size = New System.Drawing.Size(249, 491)
        Me.txtXmlBefore.TabIndex = 0
        Me.txtXmlBefore.WordWrap = False
        '
        'txtXmlAfter
        '
        Me.txtXmlAfter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtXmlAfter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXmlAfter.Location = New System.Drawing.Point(0, 0)
        Me.txtXmlAfter.Multiline = True
        Me.txtXmlAfter.Name = "txtXmlAfter"
        Me.txtXmlAfter.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXmlAfter.Size = New System.Drawing.Size(281, 491)
        Me.txtXmlAfter.TabIndex = 0
        Me.txtXmlAfter.WordWrap = False
        '
        'chkShowFAHCfg
        '
        Me.chkShowFAHCfg.AutoSize = True
        Me.chkShowFAHCfg.Checked = True
        Me.chkShowFAHCfg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowFAHCfg.Location = New System.Drawing.Point(380, 56)
        Me.chkShowFAHCfg.Name = "chkShowFAHCfg"
        Me.chkShowFAHCfg.Size = New System.Drawing.Size(128, 22)
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
        Me.gbxFAHVerifyConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.gbxFAHVerifyConfig.Location = New System.Drawing.Point(43, 445)
        Me.gbxFAHVerifyConfig.Name = "gbxFAHVerifyConfig"
        Me.gbxFAHVerifyConfig.Size = New System.Drawing.Size(510, 83)
        Me.gbxFAHVerifyConfig.TabIndex = 17
        Me.gbxFAHVerifyConfig.TabStop = False
        Me.gbxFAHVerifyConfig.Text = "Save Folding@Home Changes"
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.SystemColors.Control
        Me.txtPwd.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPwd.Location = New System.Drawing.Point(226, 54)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(39, 24)
        Me.txtPwd.TabIndex = 3
        Me.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPwd, "Telnet FAH Password (blank, unless you've set a FAH PW)")
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.Control
        Me.txtPort.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPort.Location = New System.Drawing.Point(176, 54)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(49, 24)
        Me.txtPort.TabIndex = 2
        Me.txtPort.Text = "36330"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPort, "Telnet Port (FAH default: 36330)")
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtAddress.Location = New System.Drawing.Point(58, 54)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(117, 24)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.Text = "localhost"
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtAddress, "Telnet Address (IP or Hostname). Default: localhost")
        '
        'btnTelnetSave
        '
        Me.btnTelnetSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTelnetSave.Location = New System.Drawing.Point(269, 53)
        Me.btnTelnetSave.Name = "btnTelnetSave"
        Me.btnTelnetSave.Size = New System.Drawing.Size(103, 27)
        Me.btnTelnetSave.TabIndex = 4
        Me.btnTelnetSave.Text = "Save"
        Me.btnTelnetSave.UseVisualStyleBackColor = True
        '
        'txtTelnetFAHCfg
        '
        Me.txtTelnetFAHCfg.BackColor = System.Drawing.SystemColors.Control
        Me.txtTelnetFAHCfg.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtTelnetFAHCfg.Location = New System.Drawing.Point(4, 24)
        Me.txtTelnetFAHCfg.Name = "txtTelnetFAHCfg"
        Me.txtTelnetFAHCfg.Size = New System.Drawing.Size(501, 24)
        Me.txtTelnetFAHCfg.TabIndex = 0
        '
        'lblTelnet
        '
        Me.lblTelnet.AutoSize = True
        Me.lblTelnet.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTelnet.Location = New System.Drawing.Point(6, 57)
        Me.lblTelnet.Name = "lblTelnet"
        Me.lblTelnet.Size = New System.Drawing.Size(52, 18)
        Me.lblTelnet.TabIndex = 21
        Me.lblTelnet.Text = "Telnet:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl4.Location = New System.Drawing.Point(-8, 458)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(66, 55)
        Me.lbl4.TabIndex = 18
        Me.lbl4.Text = "4."
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbxFAHVerifyConfig)
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbxPasskey)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1110, 534)
        Me.SplitContainer2.SplitterDistance = 558
        Me.SplitContainer2.SplitterWidth = 2
        Me.SplitContainer2.TabIndex = 19
        '
        'FAHSetupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 580)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
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
End Class
