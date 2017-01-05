Public Class DisplayTextDialog
    Public Sub New()
        Try
            InitializeComponent()

            Me.Icon = My.Resources.FoldingCoin_16_32_48
            If System.IO.File.Exists(DatFilePath) = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))

                'Show data
                Me.txtDisplayText.Text = DAT.SaveToString
                Me.txtDisplayText.Select(Me.txtDisplayText.Text.Length, 0)
                'Reset the Save button to be disabled until some changes to the text are made
                Me.btnSaveChanges.Enabled = False
                Me.BtnOK.Focus()
                Me.Show()

                DAT = Nothing
            Else
                g_Main.Msg("No DAT file yet")
                MessageBox.Show("No DAT file yet")
            End If

        Catch ex As Exception
            g_Main.Msg(ex.ToString)
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DisplayTextDialog_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        'Clear out the displayed text
        Me.txtDisplayText.Text = String.Empty
    End Sub

    Private Sub txtDisplayText_TextChanged(sender As Object, e As EventArgs) Handles txtDisplayText.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        'Show modal dialog box
        If Me.txtDisplayText.Text.Length > 10 Then
            'Create text from the INI, Encrypt, and Write/flush DAT text to file
            SaveDat(Encrypt(Me.txtDisplayText.Text))

            'Disable the save button again
            Me.btnSaveChanges.Enabled = False
            Me.BtnOK.Focus()
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
                Dim Path_FAH_CurrentUserCfg As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FAHClient", "config.xml")

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
                    Prog_Name & " v" & My.Application.Info.Version.Major.ToString & " Settings Files:" & vbNewLine &
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

            Me.BtnOK.Focus()

        Catch ex As Exception
            MessageBox.Show("Error creating backup: " & ex.ToString)
        End Try
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        'The Closing event clears out the displayed text
        Me.Close()
    End Sub

    Private Sub DisplayTextDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            'The Closing event clears out the displayed text
            Me.Close()
        End If
    End Sub
End Class