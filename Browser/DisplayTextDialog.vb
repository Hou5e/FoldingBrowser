Public Class DisplayTextDialog
    Private m_bRawDataSaved As Boolean = False

    Public Sub New()
        Try
            InitializeComponent()

            Me.Icon = My.Resources.L_cysteine_16_24_32_48_256
            Me.SplitContainer1.SplitterWidth = 2
            Me.SplitContainer1.Panel1Collapsed = True

            'Set the new font scalar to resize the form (For display scaling percentages other than 100% / 96 DPI)
            If g_sScaleFactor <> DefaultFontScalar Then
                'Scale font. This will force the child controls to resize and scale fonts (as long as they are the default font)
                Me.Font = New Font(Me.Font.FontFamily, Me.Font.Size * g_sScaleFactor, Me.Font.Style)
            End If

            'Update the displayed data
            If Me.cbxWalletId.Text = g_Main.cbxToolsWalletId.Text Then
                'Update the displayed data
                cbxWalletId_SelectedIndexChanged(Nothing, Nothing)
            Else
                'Change to the same wallet as the main interface
                Me.cbxWalletId.Text = g_Main.cbxToolsWalletId.Text
            End If

            'Start with the textboxes instead of the raw data that is hard to look at
            chkShowRawData_CheckedChanged(Nothing, Nothing)
            chkShowPW_CheckedChanged(Nothing, Nothing)

            'Reset the Save button to be disabled until some changes to the text are made
            Me.btnSaveChanges.Enabled = False
            Me.btnOK.Focus()
            'Don't put Me.Show() here because it will be shown as a dialog box.

        Catch ex As Exception
            g_Main.Msg(ex.ToString)
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DisplayTextDialog_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        'Clear out the displayed text
        Me.txtDisplayText.Text = String.Empty
    End Sub

    Private Sub chkShowRawData_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowRawData.CheckedChanged
        If Me.chkShowRawData.Checked = False Then
            'Use the individual textboxes
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = True
            Me.chkShowPW.Visible = True
        Else
            'Use the large single textbox with the Raw INI data
            Me.SplitContainer1.Panel2Collapsed = False
            Me.SplitContainer1.Panel1Collapsed = True
            Me.chkShowPW.Visible = False
        End If

        'Update the displayed data, if changes were saved during raw data viewing
        If m_bRawDataSaved = True Then
            cbxWalletId_SelectedIndexChanged(Nothing, Nothing)
            m_bRawDataSaved = False
        End If

        'Disable the save button again
        Me.btnSaveChanges.Enabled = False
    End Sub

    Private Sub chkShowPW_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPW.CheckedChanged
        If Me.chkShowPW.Checked = True Then
            Me.txtFAHPasskey.PasswordChar = ControlChars.NullChar
            Me.txtCounterParty12WordPassphrase.PasswordChar = ControlChars.NullChar
            Me.txtCureCoinPoolPassword.PasswordChar = ControlChars.NullChar
            Me.txtCureCoinPoolPin.PasswordChar = ControlChars.NullChar
            Me.txtDiscordPassword.PasswordChar = ControlChars.NullChar
        Else
            Me.txtFAHPasskey.PasswordChar = "*"c
            Me.txtCounterParty12WordPassphrase.PasswordChar = "*"c
            Me.txtCureCoinPoolPassword.PasswordChar = "*"c
            Me.txtCureCoinPoolPin.PasswordChar = "*"c
            Me.txtDiscordPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If Me.chkShowRawData.Checked = False Then
            'Use the individual textboxes
            Dim DAT As New IniFile
            'Build the new DAT file
            If System.IO.File.Exists(DatFilePath) = True Then
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    g_Main.Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If
            End If

            Me.txtFAHUsername.Text = Me.txtFAHUsername.Text.Trim
            Me.txtFAHTeam.Text = Me.txtFAHTeam.Text.Trim
            Me.txtFAHPasskey.Text = Me.txtFAHPasskey.Text.Trim
            Me.txtEmail.Text = Me.txtEmail.Text.Trim

            Me.txtBTCAddress.Text = Me.txtBTCAddress.Text.Trim
            Me.txtCounterParty12WordPassphrase.Text = Me.txtCounterParty12WordPassphrase.Text.Trim

            Me.txtCureCoinAddress.Text = Me.txtCureCoinAddress.Text.Trim
            Me.txtCureCoinPoolPassword.Text = Me.txtCureCoinPoolPassword.Text.Trim
            Me.txtCureCoinPoolPin.Text = Me.txtCureCoinPoolPin.Text.Trim

            Me.txtDiscordEmail.Text = Me.txtDiscordEmail.Text.Trim
            Me.txtDiscordPassword.Text = Me.txtDiscordPassword.Text.Trim

            Me.txtExtremeOverclockingId.Text = Me.txtExtremeOverclockingId.Text.Trim


            'Save textboxes with DAT data for the Wallet Id...
            DAT.AddSection(Id & Me.cbxWalletId.Text)
            If Me.txtFAHUsername.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_FAH_Username).Value = Me.txtFAHUsername.Text
            End If
            If Me.txtFAHTeam.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_FAH_Team).Value = Me.txtFAHTeam.Text
            End If
            If Me.txtFAHPasskey.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_FAH_Passkey).Value = Me.txtFAHPasskey.Text
            End If
            If Me.txtEmail.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_Email).Value = Me.txtEmail.Text
            End If


            If Me.txtBTCAddress.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_BTC_Addr).Value = Me.txtBTCAddress.Text
            End If
            If Me.txtCounterParty12WordPassphrase.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = Me.txtCounterParty12WordPassphrase.Text
            End If


            If Me.txtCureCoinAddress.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CureCoin_Addr).Value = Me.txtCureCoinAddress.Text
            End If
            If Me.txtCureCoinPoolPassword.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CureCoin_Pwd).Value = Me.txtCureCoinPoolPassword.Text
            End If
            If Me.txtCureCoinPoolPin.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CureCoin_Pin).Value = Me.txtCureCoinPoolPin.Text
            End If


            If Me.txtDiscordEmail.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_DiscordEmail).Value = Me.txtDiscordEmail.Text
            End If
            If Me.txtDiscordPassword.Text.Length <> 0 Then
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_DiscordPassword).Value = Me.txtDiscordPassword.Text
            End If


            INI.AddSection(Id & Me.cbxWalletId.Text)
            'If saving settings to a new wallet slot, give it a name, so you can access it
            If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName) Is Nothing Then
                'Save a wallet name
                INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = DefaultWalletName & Me.cbxWalletId.Text
            End If

            If Me.txtExtremeOverclockingId.Text.Length <> 0 Then
                INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_EOC_ID).Value = Me.txtExtremeOverclockingId.Text
            End If
            INI.Save(IniFilePath)

            'Display the DAT data in the main raw data textbox
            Me.txtDisplayText.Text = DAT.SaveToString
            Me.txtDisplayText.Select(Me.txtDisplayText.Text.Length, 0)

            DAT = Nothing
        Else
            'Large single textbox with the Raw INI data: Set a flag to reload the textboxes so they don't get out of sync
            m_bRawDataSaved = True
        End If

        'Use the large single textbox with the raw INI data
        If Me.txtDisplayText.Text.Length > 10 Then
            'Create text from the INI, Encrypt, and Write/flush DAT text to file
            SaveDat(Encrypt(Me.txtDisplayText.Text))

            'Disable the save button again
            Me.btnSaveChanges.Enabled = False
            Me.btnOK.Focus()
        Else
            g_Main.Msg("No displayed text to save.")
            MessageBox.Show("No displayed text to save.")
        End If
    End Sub

    Private Async Sub btnMakeBackup_Click(sender As Object, e As EventArgs) Handles btnMakeBackup.Click
        Try
            'Ask for backup folder location, a new folder will be made there for the files
            Dim SaveDlg As New System.Windows.Forms.FolderBrowserDialog
            SaveDlg.ShowNewFolderButton = False
            SaveDlg.Description = "Select a backup location:"
            If SaveDlg.ShowDialog(Me) = DialogResult.OK Then
                Dim strBackupPath As String = System.IO.Path.Combine(SaveDlg.SelectedPath, "FoldingBrowserBackup-" & Now.ToString("yyyy-MM-dd_HH_mm_ss"))
                Dim strRestoreInfo As String = ""

                Dim bCureCoinInstalled As Boolean = False
                Dim strCureCoinWalletPath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "curecoin", "wallet.dat")

                Dim bFAH_Installed As Boolean = False
                Dim strFAHConfigPath As String = ""
                Const PATH_FAH_ALL_USER_CFG As String = "C:\ProgramData\FAHClient\config.xml"
                Dim Path_FAH_CurrentUserCfg As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FAH_Client, "config.xml")

                If System.IO.Directory.Exists(strBackupPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(strBackupPath)
                    Await Wait(100)
                End If

                'FoldingBrowser settings files:
                If System.IO.File.Exists(DatFilePath) = True Then
                    System.IO.File.Copy(DatFilePath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(DatFilePath)))
                End If
                If System.IO.File.Exists(IniFilePath) = True Then
                    System.IO.File.Copy(IniFilePath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(IniFilePath)))
                End If

                'CureCoin wallet file:
                If System.IO.File.Exists(strCureCoinWalletPath) = True Then
                    System.IO.File.Copy(strCureCoinWalletPath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(strCureCoinWalletPath)))
                    bCureCoinInstalled = True
                End If

                'Find the FAH Config file location and copy it to the backup location:
                If System.IO.File.Exists(PATH_FAH_ALL_USER_CFG) = True Then
                    'First try: C:\ProgramData\FAHClient
                    strFAHConfigPath = PATH_FAH_ALL_USER_CFG
                    System.IO.File.Copy(strFAHConfigPath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(strFAHConfigPath)))
                    bFAH_Installed = True

                ElseIf System.IO.File.Exists(Path_FAH_CurrentUserCfg) = True Then
                    'Then try: <user account>\FAHClient
                    strFAHConfigPath = Path_FAH_CurrentUserCfg
                    System.IO.File.Copy(strFAHConfigPath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(strFAHConfigPath)))
                    bFAH_Installed = True
                End If

                'ReadMe.txt: Write out a text file that says what to do to restore the files
                strRestoreInfo = "Restore settings from the backup on " & Now.ToString("yyyy-MM-dd") & ":" & vbNewLine &
                    "================================================" & vbNewLine & vbNewLine &
                    g_strTitleEnd & " Settings Files:" & vbNewLine &
                    "-------------------------------------------------------------------------" & vbNewLine &
                    System.IO.Path.GetFileName(DatFilePath) & "  Copy to:  " & DatFilePath & vbNewLine &
                    System.IO.Path.GetFileName(IniFilePath) & "  Copy to:  " & IniFilePath &
                    If(bCureCoinInstalled = True, vbNewLine & vbNewLine & vbNewLine & "CureCoin Wallet Settings File:" & vbNewLine &
                    "-------------------------------------------------------------------------" & vbNewLine &
                    System.IO.Path.GetFileName(strCureCoinWalletPath) & "  Copy to:  " & strCureCoinWalletPath, "") &
                    If(bFAH_Installed = True, vbNewLine & vbNewLine & vbNewLine & "Folding@Home Settings File:" & vbNewLine &
                    "-------------------------------------------------------------------------" & vbNewLine &
                    System.IO.Path.GetFileName(strFAHConfigPath) & "  Copy to:  " & strFAHConfigPath, "")

                'Create and save the ReadMe text to the file
                Dim ReadmeFilePath As String = System.IO.Path.Combine(UserProfileDir, "ReadMe.txt")
                Dim twLog As System.IO.TextWriter = Nothing
                Try
                    'Create the directory, if needed
                    If System.IO.Directory.Exists(UserProfileDir) = False Then
                        System.IO.Directory.CreateDirectory(UserProfileDir)
                    End If

                    'Create a new text file
                    twLog = System.IO.File.CreateText(ReadmeFilePath)

                    'Add data
                    twLog.Write(strRestoreInfo)

                    'Flush the text to the file 
                    twLog.Flush()
                    Await Wait(100)

                Catch ex As Exception
                    MsgBox("Saving restore info file Error: " & ex.ToString, MsgBoxStyle.Exclamation)
                Finally
                    'Close the File 
                    If twLog IsNot Nothing Then
                        twLog.Close()
                    End If
                End Try

                'Copy the ReadMe text file to backup location
                System.IO.File.Copy(ReadmeFilePath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(ReadmeFilePath)))
            End If
            SaveDlg.Dispose()

            Me.btnOK.Focus()

        Catch ex As Exception
            MessageBox.Show("Error creating backup: " & ex.ToString)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'The Closing event clears out the displayed text
        Me.Close()
    End Sub

    Public Sub cbxWalletId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWalletId.SelectedIndexChanged
        Me.txtFAHUsername.Text = ""
        Me.txtFAHTeam.Text = ""
        Me.txtFAHPasskey.Text = ""
        Me.txtEmail.Text = ""

        Me.txtBTCAddress.Text = ""
        Me.txtCounterParty12WordPassphrase.Text = ""

        Me.txtCureCoinAddress.Text = ""
        Me.txtCureCoinPoolPassword.Text = ""
        Me.txtCureCoinPoolPin.Text = ""

        Me.txtDiscordEmail.Text = ""
        Me.txtDiscordPassword.Text = ""

        Me.txtExtremeOverclockingId.Text = ""

        'Make sure the INI key/value exists
        If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
            'Load the Wallet name from the INI file based on the Wallet Id#
            Me.txtWalletName.Text = INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName).GetValue()

            If System.IO.File.Exists(DatFilePath) = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    g_Main.Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If

                'Show all data (Main textbox)
                Me.txtDisplayText.Text = DAT.SaveToString
                Me.txtDisplayText.Select(Me.txtDisplayText.Text.Length, 0)


                'Load textboxes with DAT data for the Wallet Id...
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                    Me.txtFAHUsername.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_FAH_Team) IsNot Nothing Then
                    Me.txtFAHTeam.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_FAH_Team).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_FAH_Passkey) IsNot Nothing Then
                    Me.txtFAHPasskey.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_FAH_Passkey).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_Email) IsNot Nothing Then
                    Me.txtEmail.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_Email).GetValue()
                End If


                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_BTC_Addr) IsNot Nothing Then
                    Me.txtBTCAddress.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_BTC_Addr).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CP12Words) IsNot Nothing Then
                    Me.txtCounterParty12WordPassphrase.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CP12Words).GetValue()
                End If


                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CureCoin_Addr) IsNot Nothing Then
                    Me.txtCureCoinAddress.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CureCoin_Addr).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CureCoin_Pwd) IsNot Nothing Then
                    Me.txtCureCoinPoolPassword.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CureCoin_Pwd).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CureCoin_Pin) IsNot Nothing Then
                    Me.txtCureCoinPoolPin.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CureCoin_Pin).GetValue()
                End If


                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_DiscordEmail) IsNot Nothing Then
                    Me.txtDiscordEmail.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_DiscordEmail).GetValue()
                End If
                If DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_DiscordPassword) IsNot Nothing Then
                    Me.txtDiscordPassword.Text = DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_DiscordPassword).GetValue()
                End If


                If INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_EOC_ID) IsNot Nothing Then
                    Me.txtExtremeOverclockingId.Text = INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_EOC_ID).GetValue()
                End If

                DAT = Nothing
                Me.btnSaveChanges.Enabled = False
            Else
                g_Main.Msg("No DAT file yet")
                MessageBox.Show("No DAT file yet")
            End If
        Else
            Me.txtWalletName.Text = NotUsed
        End If
    End Sub

    Private Sub txtDisplayText_TextChanged(sender As Object, e As EventArgs) Handles txtDisplayText.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub txtFAHUsername_TextChanged(sender As Object, e As EventArgs) Handles txtFAHUsername.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtFAHTeam_TextChanged(sender As Object, e As EventArgs) Handles txtFAHTeam.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtFAHPasskey_TextChanged(sender As Object, e As EventArgs) Handles txtFAHPasskey.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub txtBTCAddress_TextChanged(sender As Object, e As EventArgs) Handles txtBTCAddress.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtCounterParty12WordPassphrase_TextChanged(sender As Object, e As EventArgs) Handles txtCounterParty12WordPassphrase.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub txtCureCoinAddress_TextChanged(sender As Object, e As EventArgs) Handles txtCureCoinAddress.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtCureCoinPoolPassword_TextChanged(sender As Object, e As EventArgs) Handles txtCureCoinPoolPassword.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtCureCoinPoolPin_TextChanged(sender As Object, e As EventArgs) Handles txtCureCoinPoolPin.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub txtDiscordEmail_TextChanged(sender As Object, e As EventArgs) Handles txtDiscordEmail.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
    Private Sub txtDiscordPassword_TextChanged(sender As Object, e As EventArgs) Handles txtDiscordPassword.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub txtExtremeOverclockingId_TextChanged(sender As Object, e As EventArgs) Handles txtExtremeOverclockingId.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub txtWalletName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWalletName.KeyDown
        'Change wallet name when text is changed and <enter> is pressed
        If e.KeyCode = Keys.Enter Then
            If Me.txtWalletName.Text.Length > 0 Then
                'Save a wallet name
                INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = Me.txtWalletName.Text
                INI.Save(IniFilePath)
            End If
        End If
    End Sub

    Private Sub DisplayTextDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            'The Closing event clears out the displayed text
            Me.Close()
        End If
    End Sub
End Class