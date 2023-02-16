﻿Public Class FAHSetupDialog
    'Leave this at the top to turn off auto-updating during initialization
    Private m_bSkipUpdating As Boolean = True
    Public m_bInitialInstall As Boolean = False

    Private Const c_EarnTypeBoth As String = "Both: CureCoin, and FoldingCoin (not currently distributed)"
    Private Const c_EarnTypeCURE As String = "CureCoin Only"
    Private Const c_EarnTypeFLDC As String = "FoldingCoin only (not currently distributed)"

    Private Const PATH_FAH_ALL_USER_CFG As String = "C:\ProgramData\FAHClient\config.xml"
    Private Const PAUSE_FAH As String = "options idle=true open-web-control=false"  'Disabling the web control pop-up doesn't happen soon enough to stop it
    Private Path_FAH_CurrentUserCfg As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FAHClient\config.xml")
    Private m_strFAHCfgPath As String = ""

    'BTC public address regular expression matching pattern. Base58 encoding (excludes: 0, O, I, l characters that look similar)
    Private m_regexBTC As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("^[13][a-km-zA-HJ-NP-Z1-9]{25,34}$")
    Private m_regexFAH_Warning As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9_]")
    Private m_regexFAH_Forbidden As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[\s#~|@^]")

    Private m_xmlCfg As New System.Xml.XmlDocument

#Region "Initialize Form"
    Private Sub FAHSetupDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strTeam As String = ""
        Me.Icon = My.Resources.L_cysteine_16_24_32_48_256

        'Set the new font scalar to resize the form (For display scaling percentages other than 100% / 96 DPI)
        If g_sScaleFactor <> DefaultFontScalar Then
            'Scale font. This will force the child controls to resize and scale fonts (as long as they are the default font)
            Me.Font = New Font(Me.Font.FontFamily, Me.Font.Size * g_sScaleFactor, Me.Font.Style)
        End If

        'Make the step numbers large after the form gets scaled
        Me.lbl1.Font = New Font(Me.lbl1.Font.FontFamily, Me.lbl1.Font.Size * 3.5!, FontStyle.Bold)
        Me.lbl2.Font = Me.lbl1.Font
        Me.lbl3.Font = Me.lbl1.Font
        Me.lbl4.Font = Me.lbl1.Font

        Me.cbxUsernameEarnSelect.Items.AddRange({c_EarnTypeBoth, c_EarnTypeCURE, c_EarnTypeFLDC})

        'Hide the form while it's being adjusted
        Me.WindowState = FormWindowState.Minimized
        'Create the main form (needs to come before the window size restore)
        Me.Show()
        m_bSkipUpdating = True

        'Try pausing FAH during the initial FAH setup. This keeps things from slowing down too much when CPU folding starts up during the setup process.
        'NOTE: the option "paused=true" didn't work on v7.4.16. Using "idle=true" instead. "power=light" starts running the CPU at ~50%, and has the GPU paused for idle
        If m_bInitialInstall = True Then
            Me.txtTelnetFAHCfg.Text = PAUSE_FAH
            'NOTE: the Telnet settings change is not Awaited, and this sets the OK button state
            btnTelnetSave_Click(Nothing, Nothing)
            Delay(500)
        End If

        Try
            'Find the FAH Config file location
            If System.IO.File.Exists(PATH_FAH_ALL_USER_CFG) = True Then
                'First try: C:\ProgramData\FAHClient
                m_strFAHCfgPath = PATH_FAH_ALL_USER_CFG

            ElseIf System.IO.File.Exists(Path_FAH_CurrentUserCfg) = True Then
                'Then try: <user account>\FAHClient
                m_strFAHCfgPath = Path_FAH_CurrentUserCfg
            End If

        Catch ex As Exception
            MessageBox.Show("Could not find the FAH Config file: " & vbNewLine & m_strFAHCfgPath & vbNewLine & vbNewLine & ex.ToString)
        End Try

        'Load Username (if exists), CounterWallet Bitcoin (BTC) address from saved CounterWallet info. Fill-in Email Address / Passkey from saved settings, if exists
        If System.IO.File.Exists(DatFilePath) = True Then
            Dim DAT As New IniFile
            'Load DAT file, decrypt it
            DAT.LoadText(Decrypt(LoadDat))
            If DAT.ToString.Length = 0 Then
                'Decryption failed
                g_Main.Msg(DAT_ErrorMsg)
                MessageBox.Show(DAT_ErrorMsg)
            End If

            'Try loading a stored Username first, if it exists already
            If Me.txtUsername.Text.Length = 0 Then
                Try
                    If DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                        Me.txtUsername.Text = DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
                    End If
                Catch ex As Exception
                    g_Main.Msg("FAH Cfg: Error loading Username: " & ex.Message.ToString)
                End Try
            End If

            'Try loading the CounterWallet Bitcoin (BTC) address
            If Me.txtBitcoinAddress.Text.Length = 0 Then
                Try
                    If DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_BTC_Addr) IsNot Nothing Then
                        Me.txtBitcoinAddress.Text = DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_BTC_Addr).GetValue()
                    End If
                Catch ex As Exception
                    g_Main.Msg("FAH Cfg: Error loading BTC Address: " & ex.Message.ToString)
                End Try
            End If

            'Try loading the FAH Team #
            Try
                If DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_FAH_Team) IsNot Nothing Then
                    strTeam = DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_FAH_Team).GetValue()
                    If strTeam = "224497" Then
                        Me.rbnCureCoin.Checked = True
                    ElseIf strTeam = "226728" Then
                        Me.rbnFoldingCoin.Checked = True
                    Else
                        Me.txtOtherTeam.Text = strTeam
                    End If
                End If
            Catch ex As Exception
                g_Main.Msg("FAH Cfg: Error loading Team #: " & ex.Message.ToString)
            End Try

            'Try loading the Email Address, if it exists already
            If Me.txtEmail.Text.Length = 0 Then
                Try
                    If DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_Email) IsNot Nothing Then
                        Me.txtEmail.Text = DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_Email).GetValue()
                    End If
                Catch ex As Exception
                    g_Main.Msg("FAH Cfg: Error loading Email Address: " & ex.Message.ToString)
                End Try
            End If

            'Try loading the Passkey, if it exists already
            If Me.txtPasskey.Text.Length = 0 Then
                Try
                    If DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_FAH_Passkey) IsNot Nothing Then
                        Me.txtPasskey.Text = DAT.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(DAT_FAH_Passkey).GetValue()
                    End If
                Catch ex As Exception
                    g_Main.Msg("FAH Cfg: Error loading Passkey: " & ex.Message.ToString)
                End Try
            End If
            DAT = Nothing
        End If

        'Load the XML from the file
        If m_strFAHCfgPath.Length > 0 Then
            Try
                Me.txtCfgPath.Text = m_strFAHCfgPath
                Me.txtXmlBefore.Text = System.IO.File.ReadAllText(m_strFAHCfgPath)

            Catch ex As Exception
                Dim strMsg As String = "Could not read the FAH Config file: " & vbNewLine & m_strFAHCfgPath & vbNewLine & vbNewLine & ex.ToString
                g_Main.Msg(strMsg)
                MessageBox.Show(strMsg)
            End Try

            'If no BTC address, try getting the info from the Config.XML FAH settings file
            If Me.txtBitcoinAddress.Text.Length = 0 Then
                'Read existing Username, Team #, and Passkey from XML config file
                Try
                    m_xmlCfg.LoadXml(Me.txtXmlBefore.Text)
                    Dim xmlnlNodes As Xml.XmlNodeList = Nothing

                    'Get existing 'passkey' info
                    xmlnlNodes = m_xmlCfg.GetElementsByTagName("passkey")
                    If xmlnlNodes.Count > 0 Then
                        Me.txtPasskey.Text = xmlnlNodes.Item(0).Attributes("v").Value
                    End If

                    'Get existing 'team' info
                    xmlnlNodes = m_xmlCfg.GetElementsByTagName("team")
                    If xmlnlNodes.Count > 0 Then
                        strTeam = xmlnlNodes.Item(0).Attributes("v").Value
                        If strTeam = "224497" Then
                            Me.rbnCureCoin.Checked = True
                        ElseIf strTeam = "226728" Then
                            Me.rbnFoldingCoin.Checked = True
                        Else
                            Me.txtOtherTeam.Text = strTeam
                        End If
                    End If

                    'Get existing 'user' info
                    xmlnlNodes = m_xmlCfg.GetElementsByTagName("user")
                    If xmlnlNodes.Count > 0 Then
                        Me.txtUsername.Text = xmlnlNodes.Item(0).Attributes("v").Value
                    End If

                Catch ex As Exception
                    Dim strMsg As String = "Error parsing existing XML settings: " & ex.Message.ToString
                    g_Main.Msg(strMsg)
                    MessageBox.Show(strMsg)
                End Try
            End If
        Else
            Me.txtXmlBefore.Text = "No Config.xml"
            Me.txtCfgPath.Text = ""
        End If

        'Turn on auto-updating the settings, now that any existing info was loaded
        m_bSkipUpdating = False
        CreateFAHUserName()

        'Disable the OK button until settings are saved. NOTE: Pausing FAH with Telnet is not Awaited above, and was undoing this on an initial install
        Me.btnOK.Enabled = False

        'Set for initial state
        Me.SplitContainer2.SplitterWidth = 2
        Me.SplitContainer1.SplitterWidth = 2

        'Make the main form visible
        Me.WindowState = FormWindowState.Normal

        'Update some window positions
        Me.chkShowFAHCfg.Checked = False
    End Sub
#End Region

#Region "Username Auto-Update"
    Private Sub cbxUsernameEarnSelect_TextChanged(sender As Object, e As EventArgs) Handles cbxUsernameEarnSelect.TextChanged
        Select Case Me.cbxUsernameEarnSelect.Text
            Case c_EarnTypeBoth, c_EarnTypeFLDC
                Me.txtBitcoinAddress.Visible = True
                Me.cbxSeparator.Visible = True
                Me.lblSeparator.Visible = True
                Me.lblBitcoinAddress.Visible = True
            Case c_EarnTypeCURE
                Me.txtBitcoinAddress.Visible = False
                Me.cbxSeparator.Visible = False
                Me.lblSeparator.Visible = False
                Me.lblBitcoinAddress.Visible = False
            Case Else
                'Fix bad entry
                Me.cbxUsernameEarnSelect.Text = c_EarnTypeBoth
        End Select
        CreateFAHUserName()
    End Sub

    'Preview Username
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        CreateFAHUserName()
    End Sub
    Private Sub cbxSeparator_TextChanged(sender As Object, e As EventArgs) Handles cbxSeparator.TextChanged
        CreateFAHUserName()
    End Sub
    Private Sub txtBitcoinAddress_TextChanged(sender As Object, e As EventArgs) Handles txtBitcoinAddress.TextChanged
        CreateFAHUserName()
    End Sub

    Private Sub CreateFAHUserName()
        If m_bSkipUpdating = False Then
            'Reset errors, and colors to be good
            Me.rbnFoldingCoin.BackColor = Color.FromKnownColor(KnownColor.Window)
            Me.rbnCureCoin.BackColor = Color.FromKnownColor(KnownColor.Window)
            Me.lblErrorNote.BackColor = Color.Tomato
            Me.lblErrorNote.Visible = False
            Me.lblUsernamePreview.BackColor = Color.FromKnownColor(KnownColor.Window)
            Me.txtUsername.BackColor = Color.FromKnownColor(KnownColor.Window)
            Me.cbxSeparator.BackColor = Color.FromKnownColor(KnownColor.Window)
            Me.txtBitcoinAddress.BackColor = Color.FromKnownColor(KnownColor.Window)
            Me.txtTelnetFAHCfg.BackColor = Color.FromKnownColor(KnownColor.Window)

            'Allow existing Username entry in first dialog. Then parse it out in to the other fields. Look for 1 or 2 underscores
            If Me.txtUsername.Text.Contains("_") = True Then
                'Split the entered text at the underscores '_'
                Dim strDim As String() = Me.txtUsername.Text.Split("_"c)
                If strDim(1).Contains("ALL") = True OrElse strDim(1).Contains("FLDC") = True Then
                    'With merged folding tag
                    Me.cbxSeparator.Text = "_" & strDim(1) & "_"
                    Me.txtBitcoinAddress.Text = strDim(2)
                    Me.txtUsername.Text = strDim(0)
                    Exit Sub

                ElseIf (strDim(1).Length >= 26 AndAlso strDim(1).Length <= 35 AndAlso (strDim(1).StartsWith("1") = True OrElse strDim(1).StartsWith("3") = True)) OrElse (strDim(1).StartsWith("bc1") = True AndAlso strDim(1).Length <= 90) Then
                    'New format. Only process if the second part is a Bitcoin address
                    Me.cbxSeparator.Text = "_"
                    Me.txtBitcoinAddress.Text = strDim(1)
                    Me.txtUsername.Text = strDim(0)
                    Exit Sub
                End If
            End If

            'Try to clear out any spaces someone might type
            If Me.txtUsername.Text.Contains(" ") = True Then
                Me.txtUsername.Text = Me.txtUsername.Text.Trim()
                Me.txtUsername.ScrollToCaret()
                Me.txtUsername.Refresh()
            End If
            If Me.cbxSeparator.Text.Contains(" ") = True Then
                Me.cbxSeparator.Text = Me.cbxSeparator.Text.Trim()
            End If
            If Me.txtBitcoinAddress.Text.Contains(" ") = True Then
                Me.txtBitcoinAddress.Text = Me.txtBitcoinAddress.Text.Trim()
                Me.txtBitcoinAddress.ScrollToCaret()
                Me.txtBitcoinAddress.Refresh()
            End If

            'Create the Username preview text
            Me.lblUsernamePreview.Text = Me.txtUsername.Text & If(Me.txtBitcoinAddress.Visible = False AndAlso Me.cbxSeparator.Visible = False, "", Me.cbxSeparator.Text & Me.txtBitcoinAddress.Text)

            'Bitcoin address info 'bc1' Segwit bech32 format: https://github.com/bitcoin/bips/blob/master/bip-0173.mediawiki
            If Me.txtBitcoinAddress.Text.StartsWith("bc1") = True AndAlso Me.txtBitcoinAddress.Text.Length <= 90 Then
                'Segwit bech32 'bc1' addresses are: Not currently supported by stats parser (or distributor?)
                Me.txtBitcoinAddress.BackColor = Color.Tomato
                Me.lblErrorNote.Text = "Counterparty Bitcoin Address: Must start with '1', not Segwit 'bc1'"
                Me.lblErrorNote.Visible = True
            Else
                'Bitcoin address info, see: https://en.bitcoin.it/wiki/Address
                'CounterParty Bitcoin Address: Must be 26-35 characters (typically 34 characters) in Base58 encoding (excludes: 0, O, I, l characters that look similar)
                If Me.txtBitcoinAddress.Text.Length >= 26 AndAlso Me.txtBitcoinAddress.Text.Length <= 35 Then
                    'CounterParty Bitcoin Address: Must start with: '1' (typical). Not currently supported by stats parser: '3' (Multisig)
                    If Me.txtBitcoinAddress.Text.StartsWith("1") = True OrElse Me.txtBitcoinAddress.Text.StartsWith("3") = True Then
                        'CounterParty Bitcoin Address: Check for invalid characters
                        If m_regexBTC.IsMatch(Me.txtBitcoinAddress.Text) = True Then
                            'CounterParty Bitcoin Address: Not all uppercase (very unlikely. Set as warning for now)
                            If Me.txtBitcoinAddress.Text = Me.txtBitcoinAddress.Text.ToUpper Then
                                Me.txtBitcoinAddress.BackColor = Color.Yellow
                                Me.lblErrorNote.Text = "Counterparty Bitcoin Address: Typically not all uppercase"
                                Me.lblErrorNote.Visible = True
                            End If
                        Else
                            Me.txtBitcoinAddress.BackColor = Color.Tomato
                            Me.lblErrorNote.Text = "Counterparty Bitcoin Address: Contains invalid characters"
                            Me.lblErrorNote.Visible = True
                        End If
                    Else
                        Me.txtBitcoinAddress.BackColor = Color.Tomato
                        Me.lblErrorNote.Text = "Counterparty Bitcoin Address: Must start with '1'"
                        Me.lblErrorNote.Visible = True
                    End If
                Else
                    Me.txtBitcoinAddress.BackColor = Color.Tomato
                    Me.lblErrorNote.Text = "Counterparty Bitcoin Address: Typically 34 characters (26-35)"
                    Me.lblErrorNote.Visible = True
                End If
            End If

            'Check for characters not allowed in a FAH Username. See: https://foldingathome.org/support/faq/stats-teams-usernames/#are-there-any-characters-i-should-avoid-in-a-username  NOTE: Should only be letters, numbers, and underscore. Cannot be: # ^ ~ |  Also, Email addresses are truncated / not handled well, so block '@'. See: https://foldingathome.org/support/faq/stats-teams-usernames/#how-do-i-choose-a-username
            Select Case True
                Case Me.txtUsername.Text.Length = 0
                    'Allow old Bitcoin address only format
                    If Me.cbxSeparator.Text.Length > 0 Then
                        Me.txtUsername.BackColor = Color.Tomato
                        Me.lblErrorNote.Text = "Please enter a Username"
                        Me.lblErrorNote.Visible = True
                    End If

                Case m_regexFAH_Forbidden.IsMatch(Me.lblUsernamePreview.Text) = True
                    Me.txtUsername.BackColor = Color.Tomato
                    Me.lblErrorNote.Text = "Cannot contain: <space> # ^ ~ | @"
                    Me.lblErrorNote.Visible = True

                Case m_regexFAH_Warning.IsMatch(Me.lblUsernamePreview.Text) = True
                    'This could be a warning, but it's safer to constrain the user names to safe values, especially so the username might work in web link URLs, searches, databases, etc
                    Me.txtUsername.BackColor = Color.Tomato
                    Me.lblErrorNote.Text = "Avoid special characters that may not work"
                    Me.lblErrorNote.Visible = True
            End Select

            'Check the text entered to ensure it's valid, highlight red otherwise
            If Me.cbxSeparator.Text <> "_ALL_" AndAlso Me.cbxSeparator.Text <> "_FLDC_" AndAlso Me.cbxSeparator.Text <> "_" AndAlso (Me.cbxSeparator.Text.Length > 0 OrElse Me.txtUsername.Text.Length > 0) Then
                Me.cbxSeparator.BackColor = Color.Tomato
                Me.lblErrorNote.Text = "Use: _ALL_, or _FLDC_, or <underscore>"
                Me.lblErrorNote.Visible = True
            End If

            'Check for number of underscores: 0 = Old format, and must be on the FoldingCoin team. 1 = New format, not ready yet. 3+ = Makes a username not work with the current parsing engine (may be able to remove this in the future)
            Select Case Me.lblUsernamePreview.Text.Count(Function(c) c = "_"c)
                Case 0
                    If (Me.txtBitcoinAddress.Text.Length = 0 AndAlso Me.cbxSeparator.Text.Length = 0) OrElse (Me.txtBitcoinAddress.Visible = False AndAlso Me.cbxSeparator.Visible = False) Then
                        '0 underscores = Old format: Allow CureCoin only (no FLDC) username with: no separator, and no Bitcoin address. Must be on the CureCoin team
                        If Me.rbnCureCoin.Checked = True Then
                            Me.lblUsernamePreview.BackColor = Color.Yellow
                            'Reset these error messages to allow this case, for CureCoin setup only
                            Me.cbxSeparator.BackColor = Color.FromKnownColor(KnownColor.Window)
                            Me.txtBitcoinAddress.BackColor = Color.FromKnownColor(KnownColor.Window)
                            Me.lblErrorNote.BackColor = Color.Orange
                            Me.lblErrorNote.Text = "NOTE: For earning CURE only. This username format can't earn FLDC"
                            Me.lblErrorNote.Visible = True
                        Else
                            Me.rbnCureCoin.BackColor = Color.Tomato
                            Me.lblErrorNote.Text = "Need CureCoin Team for CureCoin only username. Can't earn FLDC"
                            Me.lblErrorNote.Visible = True
                        End If

                    Else
                        '0 underscores = Old format, and must be on the FoldingCoin team. Warn about not being able to earn CURE with this format
                        If Me.txtUsername.Text.Length > 0 Then
                            Me.txtUsername.BackColor = Color.Tomato
                            Me.lblErrorNote.Text = "No username for Bitcoin Address only username. Can't earn CURE"
                            Me.lblErrorNote.Visible = True

                        ElseIf Me.rbnFoldingCoin.Checked = False Then
                            Me.rbnFoldingCoin.BackColor = Color.Tomato
                            Me.lblErrorNote.Text = "Need FoldingCoin Team for Bitcoin only username. Can't earn CURE"
                            Me.lblErrorNote.Visible = True

                        ElseIf Me.txtUsername.Text.Length = 0 Then
                            Me.lblUsernamePreview.BackColor = Color.Yellow
                            Me.lblErrorNote.Text = "NOTE: This username format can't earn CURE"
                            Me.lblErrorNote.Visible = True
                        End If
                    End If

                Case 1
                    '1 underscore = New format (User_Address) = good
                    If Me.txtUsername.Text.Length = 0 Then
                        Me.txtUsername.BackColor = Color.Tomato
                        Me.lblErrorNote.Text = "Please select a username"
                        Me.lblErrorNote.Visible = True
                    End If

                Case 2
                    'Typical for _ALL_ or _FLDC_ = good
                    If Me.cbxSeparator.Text <> "_ALL_" AndAlso Me.cbxSeparator.Text <> "_FLDC_" Then
                        Me.cbxSeparator.BackColor = Color.Tomato
                        Me.txtUsername.BackColor = Color.Tomato
                        Me.lblErrorNote.Text = "Avoid additional underscores"
                        Me.lblErrorNote.Visible = True
                    End If

                Case Else
                    '3+ underscores = Makes a username not work with the current parsing engine (may be able to remove this in the future)
                    Me.txtUsername.BackColor = Color.Tomato
                    Me.lblErrorNote.Text = "Cannot contain: additional underscores"
                    Me.lblErrorNote.Visible = True
            End Select

            'If team CureCoin, then make sure the Username is 50 characters or less
            If Me.rbnCureCoin.Checked = True Then
                If Me.lblUsernamePreview.Text.Length > 50 AndAlso Me.txtUsername.BackColor <> Color.Tomato Then
                    Select Case Me.cbxUsernameEarnSelect.Text
                        Case c_EarnTypeBoth, c_EarnTypeCURE
                            Me.txtUsername.BackColor = Color.Tomato
                            Me.lblUsernamePreview.BackColor = Color.Tomato
                        Case c_EarnTypeFLDC
                            Me.txtUsername.BackColor = Color.Yellow
                            Me.lblUsernamePreview.BackColor = Color.Yellow
                    End Select
                    Me.lblErrorNote.Text = "NOTE: Over 50 character Username limit to earn CURE"
                    Me.lblErrorNote.Visible = True
                End If
            End If

            'Passkey check: Must be 32 hexadecimal characters
            If Me.txtPasskey.Text.Length = 32 OrElse Me.txtPasskey.Text.Length = 0 Then
                Me.txtPasskey.BackColor = Color.FromKnownColor(KnownColor.Window)
                Me.lblPasskeyError.Visible = False
            Else
                Me.txtPasskey.BackColor = Color.Tomato
                Me.lblErrorNote.Text = "Passkey check: Must be 32 hexadecimal characters"
                Me.lblErrorNote.Visible = True
                Me.lblPasskeyError.Visible = True
            End If

            'Update the Telnet settings preview
            Me.txtTelnetFAHCfg.Text = "options" & If(Me.txtPasskey.Text.Length = 0, "", " passkey=" & Me.txtPasskey.Text) & " team=" & Me.lblTeamNumber.Text & " user=" & Me.lblUsernamePreview.Text

            'Check for a good text length
            If Me.txtTelnetFAHCfg.Text.Length <= 10 Then
                Me.txtTelnetFAHCfg.BackColor = Color.Tomato
            End If

            If Me.txtUsername.BackColor = Color.Tomato OrElse Me.cbxSeparator.BackColor = Color.Tomato OrElse Me.txtBitcoinAddress.BackColor = Color.Tomato OrElse Me.lblTeamNumber.BackColor = Color.Tomato OrElse Me.rbnFoldingCoin.BackColor = Color.Tomato OrElse Me.rbnCureCoin.BackColor = Color.Tomato OrElse Me.txtTelnetFAHCfg.Text.Length < 10 Then
                'Errors: User needs to fix the entered info, so disable the Save button
                Me.btnTelnetSave.Enabled = False
            Else
                'Good
                Me.btnTelnetSave.Enabled = True
            End If
        End If
    End Sub
#End Region

#Region "Team # Auto-Update"
    Private Sub rbnCureCoin_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCureCoin.CheckedChanged
        SelectTeam()
    End Sub
    Private Sub rbnFoldingCoin_CheckedChanged(sender As Object, e As EventArgs) Handles rbnFoldingCoin.CheckedChanged
        SelectTeam()
    End Sub
    Private Sub rbnOtherTeam_CheckedChanged(sender As Object, e As EventArgs) Handles rbnOtherTeam.CheckedChanged
        'Don't update here. It happens in the text changed event
    End Sub
    Private Sub txtOtherTeam_TextChanged(sender As Object, e As EventArgs) Handles txtOtherTeam.TextChanged
        Me.rbnOtherTeam.Checked = True
        SelectTeam()
    End Sub

    Private Sub SelectTeam()
        If m_bSkipUpdating = False Then
            Select Case True
                Case Me.rbnCureCoin.Checked
                    Me.lblTeamNumber.Text = "224497"
                    Me.lblTeamNumber.BackColor = Color.FromKnownColor(KnownColor.Window)

                Case Me.rbnFoldingCoin.Checked
                    Me.lblTeamNumber.Text = "226728"
                    Me.lblTeamNumber.BackColor = Color.FromKnownColor(KnownColor.Window)

                Case (Me.rbnOtherTeam.Checked = True AndAlso Me.txtOtherTeam.Text.Length > 0 AndAlso IsNumeric(Me.txtOtherTeam.Text) = True)
                    Me.lblTeamNumber.Text = Me.txtOtherTeam.Text.Trim
                    Me.lblTeamNumber.BackColor = Color.FromKnownColor(KnownColor.Window)

                Case Else
                    Me.lblTeamNumber.BackColor = Color.Tomato
            End Select
            'Verify the other info
            CreateFAHUserName()
        End If
    End Sub

    'Web link for the Team Number list
    Private Sub lllTeamNumbersLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lllTeamNumbersLink.LinkClicked
        'Set web link visited
        Me.lllTeamNumbersLink.LinkVisited = True

        'Open the web page in the user's default browser
        System.Diagnostics.Process.Start(Me.lllTeamNumbersLink.Text)
    End Sub
#End Region

#Region "Passkey Auto-Update"
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        'Reset the background color
        Me.txtEmail.BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub

    'Run the web page to send the Passkey
    Private Async Sub btnGetPasskey_Click(sender As Object, e As EventArgs) Handles btnGetPasskey.Click
        'Check to see if email looks valid, and indicate if it isn't
        If Me.txtEmail.Text.Length > 5 AndAlso Me.txtEmail.Text.Contains("@") AndAlso Me.txtEmail.Text.Contains(".") Then
            'Temporarily disable the get passkey button
            Me.btnGetPasskey.Enabled = False
            'Reset the background color
            Me.txtEmail.BackColor = Color.FromKnownColor(KnownColor.Window)

            'Remove any white space at the beginning or end of the email address
            Me.txtEmail.Text = Me.txtEmail.Text.Trim
            'Run the web page to send the Passkey
            If Await g_Main.GetFAHpasskey(URL_FAH_Passkey & Me.lblUsernamePreview.Text & "&email=" & Me.txtEmail.Text) = True Then
                Await Wait(200)
                'Click Get Passkey button (only button on the page)
                Await g_Main.ClickByTag("button", 0, False)

                'Good - Check your email
                Dim OkMsg As New MsgBoxDialog
                OkMsg.Text = "Check your email"
                OkMsg.MsgText.Text = "Please check your email for the passkey." & vbNewLine & "It may take a few minutes"
                OkMsg.Width = (OkMsg.MsgText.Left * 2) + OkMsg.MsgText.Width + 10
                OkMsg.ShowDialog(Me)
                OkMsg.Dispose()
            End If
            Await Wait(500)
            Me.btnGetPasskey.Enabled = True
        Else
            'Indicate invalid email address
            Me.txtEmail.BackColor = Color.Tomato
            Me.btnGetPasskey.Enabled = True
        End If
    End Sub

    Private Sub txtPasskey_TextChanged(sender As Object, e As EventArgs) Handles txtPasskey.TextChanged
        'Verify the other info
        CreateFAHUserName()
    End Sub
#End Region

#Region "Save FAH settings - Send by Telnet"
    'Telnet
    Private client As System.Net.Sockets.TcpClient
    Private stream As System.Net.Sockets.NetworkStream
    Private sbData As New System.Text.StringBuilder

    Private Async Sub btnTelnetSave_Click(sender As Object, e As EventArgs) Handles btnTelnetSave.Click
        'You should only be able to press the 'Save' button when the data looks Good. Use Telnet to set the FAH settings to the FAH client
        Try
            'Start Telnet session
            If My.Computer.Network.IsAvailable = True Then
                'Ensure IP address is available
                If My.Computer.Network.Ping(Me.txtAddress.Text, 1500) = True Then
                    'Retry loop
                    For i As Integer = 0 To 9
                        'Setup for Telnet
                        client = New System.Net.Sockets.TcpClient(Me.txtAddress.Text, CInt(Me.txtPort.Text))
                        stream = client.GetStream()
                        g_Main.Msg("Telnet started on " & Me.txtAddress.Text & ":" & Me.txtPort.Text & ".")

                        'Check for new data: Get the connected message from FAH
                        If Await NewData() = False Then
                            If MessageBox.Show("No data received. If FAH was just started, it may take a minute. Retry?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = MsgBoxResult.Ok Then
                                'Close Telnet session
                                If client.Connected = True Then
                                    stream.Close()
                                    client.Close()
                                    g_Main.Msg("Telnet stopped on " & Me.txtAddress.Text & ":" & Me.txtPort.Text)
                                    Await Wait(200)
                                End If

                                'Verify FAH is running. If not, then start it
                                Try
                                    Dim bRunning As Boolean = False
                                    Dim p As Process
                                    For Each p In Process.GetProcessesByName(FAH_Client)
                                        g_Main.Msg("FAH is running at id: " & p.Id.ToString() & " - " & p.ProcessName)
                                        bRunning = True
                                        Exit For
                                    Next

                                    If bRunning = False Then
                                        'Still not running...  Ask the user to start FAH
                                        MessageBox.Show("Please Start the Folding@Home software, then press 'OK'.")
                                        Await Wait(1000)
                                    End If

                                Catch ex As Exception
                                    g_Main.Msg("Error for finding if FAH is running: " & ex.ToString)
                                End Try
                            Else
                                Exit Sub
                            End If
                        Else
                            'Connected - Good
                            Exit For
                        End If
                        Await Wait(50)
                    Next

                    If client.Connected = True Then
                        'Disable the Save button while the process is running
                        Me.btnTelnetSave.Enabled = False

                        If Me.txtPwd.Text.Length > 0 Then
                            'Send Telnet data. Add a Chr(10) for a linefeed at the end
                            Dim byteAuth As Byte() = System.Text.Encoding.ASCII.GetBytes("auth " & Me.txtPwd.Text & Chr(10))
                            stream.Write(byteAuth, 0, byteAuth.Length)
                            g_Main.Msg("Telnet Send: auth ********")
                            'Get the response from FAH
                            Await NewData()
                            Await Wait(50)
                        End If

                        'Send Telnet data. Add a Chr(10) for a linefeed at the end
                        Dim byteCfg As Byte() = System.Text.Encoding.ASCII.GetBytes(Me.txtTelnetFAHCfg.Text & Chr(10))
                        stream.Write(byteCfg, 0, byteCfg.Length)
                        g_Main.Msg("Telnet Send: " & Me.txtTelnetFAHCfg.Text)
                        'Get the response from FAH
                        Await NewData()
                        Await Wait(50)

                        'Send Telnet data. Add a Chr(10) for a linefeed at the end
                        Dim byteSave As Byte() = System.Text.Encoding.ASCII.GetBytes("save" & Chr(10))
                        stream.Write(byteSave, 0, byteSave.Length)
                        g_Main.Msg("Telnet Send: save")
                        'Get the response from FAH
                        Await NewData()
                        Await Wait(50)

                        'Send Telnet data. Add a Chr(10) for a linefeed at the end
                        Dim byteExit As Byte() = System.Text.Encoding.ASCII.GetBytes("exit" & Chr(10))
                        stream.Write(byteExit, 0, byteExit.Length)
                        g_Main.Msg("Telnet Send: exit")
                        'There is no response for this command from FAH
                        Await Wait(50)

                        'Close Telnet session
                        If client.Connected = True Then
                            stream.Close()
                            client.Close()
                            g_Main.Msg("Telnet stopped on " & Me.txtAddress.Text & ":" & Me.txtPort.Text)
                        End If
                    Else
                        Dim strMsg As String = "Telnet Error: Client didn't connect. Check your connection settings for Folding@Home." & vbNewLine & "Please verify the Folding@Home software is running, and try again."
                        g_Main.Msg(strMsg)
                        MessageBox.Show(strMsg)
                    End If
                Else
                    Dim strMsg As String = "Error pinging: " & Me.txtAddress.Text
                    g_Main.Msg(strMsg)
                    MessageBox.Show(strMsg)
                End If
            Else
                Dim strMsg As String = "Error: No network connection"
                g_Main.Msg(strMsg)
                MessageBox.Show(strMsg)
            End If

        Catch ex As Exception
            Dim strMsg As String = "Telnet error while connecting to the Folding@Home software:" & vbNewLine & ex.Message.ToString & vbNewLine & vbNewLine & "-Please verify the Folding@Home software is running, and then try again."
            g_Main.Msg(strMsg)
            MessageBox.Show(strMsg)
        End Try

        'Set the OK button state
        If m_bInitialInstall = True Then
            'Disable the OK button initially for pausing FAH with Telnet (initial install only, when the form is opened)
            Me.btnOK.Enabled = False
            'Reset this flag, so the normal Telnet process can happen later, which enables the OK button
            m_bInitialInstall = False
        Else
            'Enable the OK button once the Save button has been pressed (Saving the FAH configuration settings to FAH at the end of the process)
            Me.btnOK.Enabled = True

            Try
                'Save and encrypt: Email, Passkey, FAH Username & Team info
                Dim DAT As New IniFile
                If System.IO.File.Exists(DatFilePath) = True Then
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        g_Main.Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If
                End If

                'Write out data to INI info
                If Me.lblUsernamePreview.Text.Length > 0 Then DAT.AddSection(Id & g_Main.cbxToolsWalletId.Text).AddKey(DAT_FAH_Username).Value = Me.lblUsernamePreview.Text
                If Me.lblTeamNumber.Text.Length > 0 Then DAT.AddSection(Id & g_Main.cbxToolsWalletId.Text).AddKey(DAT_FAH_Team).Value = Me.lblTeamNumber.Text
                If Me.txtEmail.Text.Length > 0 Then DAT.AddSection(Id & g_Main.cbxToolsWalletId.Text).AddKey(DAT_Email).Value = Me.txtEmail.Text
                If Me.txtPasskey.Text.Length > 0 Then DAT.AddSection(Id & g_Main.cbxToolsWalletId.Text).AddKey(DAT_FAH_Passkey).Value = Me.txtPasskey.Text

                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(DAT.SaveToString))
                Await Wait(100)
                DAT = Nothing

                'Make sure the INI key/value exists
                If INI.GetSection(Id & g_Main.cbxToolsWalletId.Text) Is Nothing OrElse INI.GetSection(Id & g_Main.cbxToolsWalletId.Text).GetKey(INI_WalletName) Is Nothing Then
                    'Save a wallet name, if there is none
                    INI.AddSection(Id & g_Main.cbxToolsWalletId.Text)
                    INI.AddSection(Id & g_Main.cbxToolsWalletId.Text).AddKey(INI_WalletName).Value = DefaultWalletName & g_Main.cbxToolsWalletId.Text
                End If

                INI.Save(IniFilePath)
                Await Wait(100)
                'Refresh the Wallet Names
                g_Main.cbxToolsWalletId_SelectedIndexChanged(Nothing, Nothing)

            Catch ex As Exception
                Dim strMsg As String = "Error saving FAH settings to DAT file: " & ex.ToString
                g_Main.Msg(strMsg)
                MessageBox.Show(strMsg)
            End Try
        End If

        'Reload the new Config file to show changes
        Await Wait(500)
        btnReload_Click(Nothing, Nothing)

        'Reset the save button
        Me.btnTelnetSave.Enabled = True
    End Sub

    'Process new Telnet data
    Private byteBuf() As Byte = New Byte(255) {}
    Private Async Function NewData() As Threading.Tasks.Task(Of Boolean)
        Try
            If client.Connected = True Then
                sbData.Length = 0
                For j As Integer = 0 To 39
                    If stream.DataAvailable = True Then
                        stream.Read(byteBuf, 0, 255)

                        For i As Integer = 0 To byteBuf.Length - 1
                            'Exit when there is no data left to process
                            If byteBuf(i) = 0 Then
                                Exit For
                            Else
                                sbData.Append(Chr(byteBuf(i)))
                            End If
                            'Reset buffer
                            byteBuf(i) = 0
                        Next
                    Else
                        If sbData.Length > 0 Then Exit For
                        Await Wait(50)
                    End If
                Next

                'Return True, that data was received
                If sbData.Length > 0 Then Return True

                'Display the text
                g_Main.Msg(sbData.ToString)
                sbData.Length = 0
            End If

        Catch ex As Exception
            g_Main.Msg("Telnet receive error: " & ex.Message.ToString)
        End Try
        Return False
    End Function

    Private Sub chkShowFAHCfg_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowFAHCfg.CheckedChanged
        If Me.chkShowFAHCfg.Checked = True Then
            'Try using the main window width as a guide for how wide to make this window when showing the before / after settings text
            Me.Width = g_Main.Width
            'Show full window
            Me.SplitContainer2.Panel2Collapsed = False
        Else
            'Small
            Me.SplitContainer2.Panel2Collapsed = True
            'Try to make it the same spacing on the right side using another control's spacing (when scaled)
            Me.Width = Me.btnCancel.Left + Me.btnCancel.Width + (Me.Width - Me.ClientSize.Width) + (Me.txtTelnetFAHCfg.Left * 2)
            Me.SplitContainer2.SplitterDistance = Me.Width
        End If

        'Try to move the form to be parent centered
        Me.Top = g_Main.Top + (g_Main.Height \ 2) - (Me.Height \ 2)
        Me.Left = g_Main.Left + (g_Main.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        If m_strFAHCfgPath.Length = 0 Then
            Try
                'Find the Config file location
                If System.IO.File.Exists(PATH_FAH_ALL_USER_CFG) = True Then
                    'First try: C:\ProgramData\FAHClient
                    m_strFAHCfgPath = PATH_FAH_ALL_USER_CFG

                ElseIf System.IO.File.Exists(Path_FAH_CurrentUserCfg) = True Then
                    'Then try: <user account>\FAHClient
                    m_strFAHCfgPath = Path_FAH_CurrentUserCfg

                Else
                    'Ask for file location. Use a File Open Dialog to select the Config file
                    Using OpenDlg As New System.Windows.Forms.OpenFileDialog
                        OpenDlg.Title = "Select FAH Config File"
                        OpenDlg.DefaultExt = "xml"
                        OpenDlg.Filter = "Config File (*.xml)|*.xml"
                        OpenDlg.FileName = System.IO.Path.GetFileName(PATH_FAH_ALL_USER_CFG)
                        OpenDlg.InitialDirectory = System.IO.Path.GetDirectoryName(PATH_FAH_ALL_USER_CFG)
                        OpenDlg.CheckPathExists = True
                        OpenDlg.CheckFileExists = True
                        OpenDlg.RestoreDirectory = False
                        OpenDlg.Multiselect = False
                        OpenDlg.FilterIndex = 0
                        If OpenDlg.ShowDialog(Me) = DialogResult.OK Then
                            m_strFAHCfgPath = OpenDlg.FileName
                        End If
                    End Using
                End If

                If m_strFAHCfgPath.Length > 0 Then
                    Me.txtXmlBefore.Text = System.IO.File.ReadAllText(m_strFAHCfgPath)
                Else
                    Me.txtXmlBefore.Text = "Could not find the FAH Config.xml"
                    Me.txtCfgPath.Text = ""
                End If

            Catch ex As Exception
                Dim strMsg As String = "Could not find the FAH Config file: " & vbNewLine & m_strFAHCfgPath & vbNewLine & vbNewLine & ex.ToString
                g_Main.Msg(strMsg)
                MessageBox.Show(strMsg)
            End Try
        End If

        'Load the XML from the file
        If m_strFAHCfgPath.Length > 0 Then
            Try
                Me.txtCfgPath.Text = m_strFAHCfgPath
                Me.txtXmlAfter.Text = System.IO.File.ReadAllText(m_strFAHCfgPath)

            Catch ex As Exception
                Dim strMsg As String = "Could not read the FAH Config file: " & vbNewLine & m_strFAHCfgPath & vbNewLine & vbNewLine & ex.ToString
                g_Main.Msg(strMsg)
                MessageBox.Show(strMsg)
            End Try
        Else
            Me.txtXmlAfter.Text = "Could not find the FAH Config.xml"
        End If
    End Sub
#End Region
End Class