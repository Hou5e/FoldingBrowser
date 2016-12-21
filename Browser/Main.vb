Public Class Main
    Private WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser

    'Page loaded indicator
    Private m_bPageLoaded As Boolean = False
    'URL to help determine the page loaded indicator
    Private m_strPageURL As String = ""

    'Timer for resetting after errors
    Private m_timerErr As New System.Timers.Timer

#Region "Form and Browser Events - Initialization, Exiting"
    Public Sub New()
        Try
            InitializeComponent()

            Me.Icon = My.Resources.FoldingCoin_16_32_48
            Me.Text = Prog_Name & " v" & My.Application.Info.Version.Major.ToString

            'Global reference to this form
            g_Main = Me

            'Setup Browser buttons
            Me.btnGo.Text = ""
            Me.btnGo.Image = My.Resources.Go_16.ToBitmap
            Me.btnStopNav.Text = ""
            Me.btnStopNav.Image = My.Resources.Stop_16.ToBitmap
            Me.btnBack.Text = ""
            Me.btnBack.Image = My.Resources.Back_24.ToBitmap
            Me.btnFwd.Text = ""
            Me.btnFwd.Image = My.Resources.Fwd_24.ToBitmap
            Me.btnReload.Text = ""
            Me.btnReload.Image = My.Resources.Reload_16.ToBitmap

            'Button Images
            Me.btnMyWallet.BackgroundImage = My.Resources.Coins_4_top_24.ToBitmap
            Me.btnFAHControl.BackgroundImage = My.Resources.L_methionine_B_top_32.ToBitmap
            Me.btnFoldingCoinWebsite.BackgroundImage = My.Resources.FoldingCoin_top_32.ToBitmap
            Me.btnFLDC_DailyDistro.BackgroundImage = My.Resources.FLDC_48.ToBitmap
            Me.btnCureCoin.BackgroundImage = My.Resources.CureCoinLogo_top_32.ToBitmap
            Me.btnEOC.BackgroundImage = My.Resources.EOC_48.ToBitmap

            'Protein image on the right side of the browser
            Me.PictureBox2.Image = My.Resources.L_cysteine_3D_vdW2_32.ToBitmap

#If DEBUG Then
            'Debug: show Dev Tools
            Me.chkShowTools.Checked = True
            chkShowTools_CheckedChanged(Nothing, Nothing)
#Else
            'Release: hide Dev Tools by default
            Me.chkShowTools.Checked = False
#End If

            Dim settings As New CefSharp.CefSettings()
            settings.LogSeverity = CefSharp.LogSeverity.Verbose
            'Set the Cache path to the user's appdata roaming folder
            settings.CachePath = System.IO.Path.Combine(UserProfileDir, "Cache")
            settings.UserDataPath = settings.CachePath
            settings.LogFile = System.IO.Path.Combine(settings.CachePath, "debug.log")
            If CefSharp.Cef.Initialize(settings) = True Then
                Me.browser = New CefSharp.WinForms.ChromiumWebBrowser(URL_BLANK)
                'Add browser event handlers to pass events back to the main UI
                AddHandler Me.browser.FrameLoadEnd, AddressOf onBrowserFrameLoadEnd
                AddHandler Me.browser.ConsoleMessage, AddressOf onBrowserConsoleMessage
                AddHandler Me.browser.StatusMessage, AddressOf OnBrowserStatusMessage
                AddHandler Me.browser.LoadingStateChanged, AddressOf OnBrowserLoadingStateChanged
                AddHandler Me.browser.TitleChanged, AddressOf OnBrowserTitleChanged
                AddHandler Me.browser.AddressChanged, AddressOf OnBrowserAddressChanged
                'Add download handler
                Me.browser.DownloadHandler = New DownloadHandler()
                'Add to a UI container
                Me.ToolStripContainer1.ContentPanel.Controls.Add(browser)

                'Default homepage / portal set to the FoldingCoin webpage
                OpenURL(URL_FoldingCoin, False)
                'OpenURL("http://folding.stanford.edu/nacl/", False)
            End If

            'Hide the form while it's being adjusted
            Me.WindowState = FormWindowState.Minimized
            'Create the main form (needs to come before the window size restore)
            Me.Show()


            'Look to see if there is an INI file first
            If System.IO.File.Exists(IniFilePath) = True Then
                INI.Load(IniFilePath)
                'Make sure the INI key/value exists
                If INI.GetSection(INI_Settings).GetKey(INI_Size) IsNot Nothing Then
                    'Restore dimensions from string: {Left};{Top};{Width};{Height}
                    Dim strDim As String() = INI.GetSection(INI_Settings).GetKey(INI_Size).GetValue().Split(";"c)
                    Me.Left = CInt(strDim(0))
                    Me.Top = CInt(strDim(1))
                    Me.Width = CInt(strDim(2))
                    Me.Height = CInt(strDim(3))
                End If

                'Make sure the INI key/value exists
                If INI.GetSection(INI_Settings).GetKey(INI_LastWalletId) IsNot Nothing Then
                    'Restore last Wallet Id used
                    Me.cbxWalletId.Text = INI.GetSection(INI_Settings).GetKey(INI_LastWalletId).GetValue()
                End If

                'Make sure the INI key/value exists
                If INI.GetSection(INI_Settings).GetKey(INI_WindowState) IsNot Nothing Then
                    'Restore last window state: Normal or Maximized
                    If INI.GetSection(INI_Settings).GetKey(INI_WindowState).GetValue() = "Maximized" Then
                        Me.WindowState = FormWindowState.Maximized
                    Else
                        Me.WindowState = FormWindowState.Normal
                    End If
                Else
                    Me.WindowState = FormWindowState.Normal
                End If

                'Make sure the INI key/value exists
                If INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton) IsNot Nothing Then
                    'Show/hide the 'Show Dat' file button
                    If INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton).GetValue() = "False" Then
                        Me.btnSavedData.Visible = True
                    Else
                        Me.btnSavedData.Visible = False
                    End If
                End If

            Else
                'NOTE: closing the program will create most all of the other missing INI file settings

                'Create folder for user info, if it doesn't exist
                If System.IO.Directory.Exists(UserProfileDir) = False Then
                    My.Computer.FileSystem.CreateDirectory(UserProfileDir)
                End If
                'Create the 10 wallet slot sections
                Dim i As Integer = 0
                For i = 0 To 9
                    INI.AddSection(Id & i.ToString)
                Next
                INI.AddSection(INI_Settings)
                'Last FoldingBrowser version. Used for updating old settings, if needed, for upgrading versions
                INI.AddSection(INI_Settings).AddKey(INI_LastBrowserVersion).Value = My.Application.Info.Version.Major.ToString
                'Create a new INI for first time use. Set the default encryption PW
                INI.AddSection(INI_Settings).AddKey(INI_PW).Value = Default_DAT_PW
                'Store window size: {Left};{Top};{Width};{Height}. This will get updated when the program exits normally.
                INI.AddSection(INI_Settings).AddKey(INI_Size).Value = "5;5;955;805"
                'Show/hide the 'Show Dat' file button
                INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton).Value = "False"
                INI.Save(IniFilePath)

                'Save and encrypt the 12 word Passphrase and the Bitcoin address
                Dim DAT As New IniFile
                If System.IO.File.Exists(DatFilePath) = True Then
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If
                End If

                'Create the initial 10 wallet slot sections in the DAT file
                For i = 0 To 9
                    DAT.AddSection(Id & i.ToString)
                Next

                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(DAT.SaveToString))
                DAT = Nothing
                'Allow time for the file to be written out
                Wait(100)

                'Make the main form visible
                Me.WindowState = FormWindowState.Normal
            End If

            'Fix old settings, if needed, for upgrading versions
            If System.IO.File.Exists(DatFilePath) = True Then
                'Make sure the INI key/value exists
                If INI.GetSection(INI_Settings).GetKey(INI_LastBrowserVersion) Is Nothing Then
                    'Folding Browser v4 or older upgrade (no stored version number for v4 or older): 12-word PW needing to go to a new location
                    Dim DAT As New IniFile
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If

                    Const OldSection As String = "FLDC"
                    Const Old012W As String = "012W"

                    'Make sure the INI key/value exists
                    If DAT.GetSection(OldSection) IsNot Nothing AndAlso DAT.GetSection(OldSection).GetKey(Old012W) IsNot Nothing Then
                        'Save the old info to the new location and delete old info
                        DAT.AddSection(Id & Me.cbxWalletId.Text)
                        DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = DAT.GetSection(OldSection).GetKey(Old012W).GetValue
                        DAT.GetSection(OldSection).RemoveAllKeys()
                        DAT.RemoveSection(OldSection)
                        'Create text from the INI, Encrypt, and Write/flush DAT text to file
                        SaveDat(Encrypt(DAT.SaveToString))

                        'Save a wallet name
                        INI.AddSection(Id & Me.cbxWalletId.Text)
                        INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = "My Wallet"
                        'Last FoldingBrowser version, now upgraded to v5
                        INI.AddSection(INI_Settings).AddKey(INI_LastBrowserVersion).Value = "5"
                        INI.Save(IniFilePath)
                        Wait(100)
                    End If

                    DAT = Nothing
                End If

                Dim strBrowserVersion As String = INI.GetSection(INI_Settings).GetKey(INI_LastBrowserVersion).Value
                If strBrowserVersion <> My.Application.Info.Version.Major.ToString Then
                    'Fix old settings, if needed, for upgrading versions for v5 or higher:
                    If strBrowserVersion = "5" Then
                        'Folding Browser v5 upgrade: 12-word PW needing to go to a better key name
                        Dim DAT As New IniFile
                        'Load DAT file, decrypt it
                        DAT.LoadText(Decrypt(LoadDat))
                        If DAT.ToString.Length = 0 Then
                            'Decryption failed
                            Msg(DAT_ErrorMsg)
                            MessageBox.Show(DAT_ErrorMsg)
                        End If

                        Const OldCP12Words As String = "CP12Words"
                        Const OldPasskey As String = "Passkey"
                        'Fix the 10 wallet slot sections
                        Dim i As Integer = 0
                        For i = 0 To 9
                            'Make sure the INI key/value exists
                            If DAT.GetSection(Id & i.ToString) IsNot Nothing AndAlso DAT.GetSection(Id & i.ToString).GetKey(OldCP12Words) IsNot Nothing Then
                                'Save the old info to the new location and delete old info
                                DAT.AddSection(Id & i.ToString).AddKey(DAT_CP12Words).Value = DAT.GetSection(Id & i.ToString).GetKey(OldCP12Words).GetValue
                                DAT.GetSection(Id & i.ToString).RemoveKey(OldCP12Words)
                            End If

                            If DAT.GetSection(Id & i.ToString) IsNot Nothing AndAlso DAT.GetSection(Id & i.ToString).GetKey(OldPasskey) IsNot Nothing Then
                                'Save the old info to the new location and delete old info
                                DAT.AddSection(Id & i.ToString).AddKey(DAT_FAH_Passkey).Value = DAT.GetSection(Id & i.ToString).GetKey(OldPasskey).GetValue
                                DAT.GetSection(Id & i.ToString).RemoveKey(OldPasskey)
                            End If
                        Next

                        'Ensure the initial 10 wallet slot sections are in the DAT file
                        For i = 0 To 9
                            DAT.AddSection(Id & i.ToString)
                        Next

                        'Create text from the INI, Encrypt, and Write/flush DAT text to file
                        SaveDat(Encrypt(DAT.SaveToString))
                        Wait(100)
                        DAT = Nothing

                        Const OldShowTheShowDatButton As String = "ShowTheShowDatButton"
                        'Renamed the 'Show Dat' file button to 'Saved Data'
                        INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton).Value = "False"
                        INI.GetSection(INI_Settings).RemoveKey(OldShowTheShowDatButton)
                        'Last FoldingBrowser version, now upgraded to v6
                        INI.AddSection(INI_Settings).AddKey(INI_LastBrowserVersion).Value = "6"
                        INI.Save(IniFilePath)
                        Wait(100)
                    End If

                    'Next DAT format version upgrade would go here
                End If
            End If

            'Refresh the Wallet Names
            cbxWalletId_SelectedIndexChanged(Nothing, Nothing)

            'Process command line values. Only for initial installations
            If Environment.CommandLine.Length > 0 Then
                RunSetup()
            End If

        Catch ex As Exception
            Msg("Error: initialization failed: " & ex.ToString)
            MessageBox.Show("Error: initialization failed: " & ex.ToString)
        End Try
    End Sub

    'This was done because the New() constructor can't be run as Async. So, this was moved out to here
    Private Async Sub RunSetup()
        'MessageBox.Show(Environment.CommandLine.ToString)
        Dim args As String() = Environment.GetCommandLineArgs()
        If args.Length > 1 Then
            Select Case args(1)
                        'This command line option represents the FoldingBrowser was just installed
                Case "-Instl", "-InstWithCure"
                    'Create a dialog that sets the default selections based on stored wallet and F@H info
                    Dim Setup As New SetupDialog
                    'Try to set the check boxes based on the available info

                    'Look for FAH username for FAH installation to un-check the dialog for existing users
                    If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_FAH_Username) IsNot Nothing Then
                        'Has FAH setup already
                        Setup.chkGetFAHSoftware.Checked = False
                    Else
                        'Needs FAH

                        'TODO: Additionally look for FAH installation on PC?

                        Setup.chkGetFAHSoftware.Checked = True
                    End If

                    Dim DAT As New IniFile
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If

                    'Look for 12-word Passphrase (or BTC address?) to un-check the dialog for existing users
                    If DAT.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CP12Words) IsNot Nothing Then
                        'Wallet info exists
                        Setup.chkGetWalletForFLDC.Checked = False
                    Else
                        'No saved Wallet info
                        Setup.chkGetWalletForFLDC.Checked = True

                        'TODO: Ask for existing wallet info? (probably too confusing / too many options)
                    End If

                    'Done with the DAT file
                    DAT = Nothing


                    'If installing the CureCoin wallet, set this check box to setup the CureCoin pool info
                    If args(1) = "-InstWithCure" Then
                        Setup.chkSetupCURE.Checked = True
                    Else
                        Setup.chkSetupCURE.Checked = False
                    End If

                    'Show modal dialog box
                    If Setup.ShowDialog() = DialogResult.OK Then
                        'Run the tasks the operator selected

                        'FAH adavanced client installation
                        If Setup.chkGetFAHSoftware.Checked = True Then
                            g_bAskDownloadLocation = False
                            If GetFAH() = False Then MessageBox.Show("Task 'Get Folding@Home App' did not complete.")
                        End If

                        'Get Wallet
                        If Setup.chkGetWalletForFLDC.Checked = True Then
                            If Await GetWallet() = False Then MessageBox.Show("Task 'Get Wallet' did not complete.")
                        End If

                        'FAH Username / Teamname settings setup
                        If Setup.chkGetFAHSoftware.Checked = True OrElse Setup.chkGetWalletForFLDC.Checked = True Then
                            btnFAHConfig_Click(Nothing, Nothing)
                        End If

                        'TODO: Only do this step for a CureCoin wallet installation (and/or a CureCoin folding team selection?)
                        If Setup.chkSetupCURE.Checked = True Then
                            Await SetupCureCoin()

                            'Logout of the CureCoin folding pool (CryptoBullionPools) website
                            OpenURL(URL_CureCoinFoldingPoolPage & "logout", False)
                            'Wait for the page to load
                            PageLoadWait()
                            PageTitleWait(NameCryptoBullions)
                            Await Wait2(200)
                        End If

                        'Show DAT file saved info. Ask to make backups / store data in a safe place
                        If Setup.chkGetFAHSoftware.Checked = True OrElse Setup.chkGetWalletForFLDC.Checked = True OrElse Setup.chkSetupCURE.Checked = True Then
                            'Load the FAH Web Client in the background.
                            'TODO: Remove: This is slow and doesn't always work without a Refresh, which new users aren't going to want to deal with.
                            'OpenURL(URL_FAH_Client, False)
                            'LoginToCounterwallet()

                            'Setup a timer to finish the process to avoid the backup Dat file window from freezing
                            m_timerErr.Interval = 1000
                            AddHandler m_timerErr.Elapsed, AddressOf OnErrEvent
                            'Finish the last part about asking to make a backup from the timer event, to avoid the make a backup window freezing (multithreading issue?).
                            m_timerErr.Start()
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Delegate Sub OnErrorEvent(sender As Object, e As EventArgs)
    Private Sub OnErrEvent(sender As Object, e As EventArgs)
        Me.Invoke(New OnErrorEvent(AddressOf FixErrEvent), {sender, e})
    End Sub
    Private Sub FixErrEvent(sender As Object, e As EventArgs)
        m_timerErr.Stop()

        'Show the Saved Data dialog
        Dim DlgDisplaySavedData As New DisplayTextDialog
        DlgDisplaySavedData.Show()

        'TODO: this part would freeze as the last part of the automated install for v6 / CefSharp v49. It was moved to the timer to try and avoid the unknown problem.

        'Process completed - Make a backup reminder
        Dim MsgBx As New MsgBoxDialog
        MsgBx.Text = "Setup Complete"
        MsgBx.MsgText.Text = "Setup is complete." & vbNewLine & vbNewLine & "Please use the 'Make Backup' button to save your settings in a safe place"
        MsgBx.Width = (MsgBx.MsgText.Left * 2) + MsgBx.MsgText.Width + 10
        MsgBx.ShowDialog()
    End Sub

    Private Sub onBrowserFrameLoadEnd(sender As Object, e As CefSharp.FrameLoadEndEventArgs)
        'Set a flag to indicate the web page has finished loading. This event is fired for each frame that loads, so compare URLs before setting the flag as loaded (NOTE: Me.browser.IsLoading = True, doesn't work)
        If e.Url.Contains(m_strPageURL) Then
            m_bPageLoaded = True
        End If
    End Sub

    Private Sub onBrowserConsoleMessage(sender As Object, e As CefSharp.ConsoleMessageEventArgs)
        If e.Line > 0 Then
            addActivity(e.Message & " (" & e.Source & ", ln " & e.Line.ToString & " )")
        Else
            addActivity(e.Message)
        End If
    End Sub
    Private Sub OnBrowserStatusMessage(sender As Object, args As CefSharp.StatusMessageEventArgs)
        addActivity(args.Value)
    End Sub

    Private Sub OnBrowserLoadingStateChanged(sender As Object, args As CefSharp.LoadingStateChangedEventArgs)
        enableButtons(args.CanGoForward, args.CanGoBack, Not args.CanReload)
    End Sub
    Private Sub enableButtons(bForward As Boolean, bBack As Boolean, bLoading As Boolean)
        Me.Invoke(Sub()
                      Me.btnBack.Enabled = bBack
                      Me.btnFwd.Enabled = bForward
                      Me.btnStopNav.Enabled = bLoading
                      Me.btnGo.Enabled = Not bLoading
                  End Sub)
    End Sub

    Private Sub OnBrowserTitleChanged(sender As Object, args As CefSharp.TitleChangedEventArgs)
        updateTitle(args.Title)
    End Sub
    Private Sub updateTitle(strTitle As String)
        Me.Invoke(Sub()
                      Me.Text = If(strTitle.Length = 0, "", strTitle & " - ") & Prog_Name & " v" & My.Application.Info.Version.Major.ToString
                  End Sub)
    End Sub

    Private Sub OnBrowserAddressChanged(sender As Object, args As CefSharp.AddressChangedEventArgs)
        updateURL(args.Address)
    End Sub
    Private Sub updateURL(strURL As String)
        Me.Invoke(Sub()
                      Me.txtURL.Text = strURL
                      m_strPageURL = strURL
                  End Sub)
    End Sub

    Public Delegate Sub updateDL(iPercent As Integer, bComplete As Boolean, bCancelled As Boolean)
    Public Sub updateDownload(iPercent As Integer, bComplete As Boolean, bCancelled As Boolean)
        Me.Invoke(New updateDL(AddressOf upDL), {iPercent, bComplete, bCancelled})
    End Sub

    Public Sub upDL(iPercent As Integer, bComplete As Boolean, bCancelled As Boolean)
        'Show when download starts
        If Me.gbxDownload.Visible = False Then
            Me.gbxDownload.Visible = True
        End If

        'Update status
        Me.ProgressBar1.Value = iPercent
        Me.lblPercent.Text = iPercent.ToString & "%"
        Me.btnStopNav.Enabled = True

        'When complete, reset the status bar
        If bComplete = True OrElse bCancelled = True Then
            Me.gbxDownload.Visible = False
            Me.ProgressBar1.Value = 0
            Me.lblPercent.Text = ""
            Me.btnStopNav.Enabled = False
            g_bCancelNav = False
            g_bAskDownloadLocation = True
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Last Wallet Id used
        INI.AddSection(INI_Settings).AddKey(INI_LastWalletId).Value = Me.cbxWalletId.Text
        'Last Window State
        INI.AddSection(INI_Settings).AddKey(INI_WindowState).Value = Me.WindowState.ToString
        'Skip saving the window position, if closed while being minimized or full screen
        If Me.WindowState = FormWindowState.Normal Then
            'Store window size: {Left};{Top};{Width};{Height}
            INI.AddSection(INI_Settings).AddKey(INI_Size).Value = IIf(Me.Left < 0, "0", Me.Left).ToString() & ";" & IIf(Me.Top < 0, "0", Me.Top).ToString() & ";" & IIf(Me.Width < 700, "700", Me.Width).ToString() & ";" & IIf(Me.Height < 500, "500", Me.Height).ToString()
        End If
        'Last FoldingBrowser version. Used for updating old settings, if needed, for upgrading versions
        INI.AddSection(INI_Settings).AddKey(INI_LastBrowserVersion).Value = My.Application.Info.Version.Major.ToString
        INI.Save(IniFilePath)

        Try
            If g_strDownloadedFilePath.Length > 0 Then
                'Try to delete the temp FAH installation file on exiting
                If g_strDownloadedFilePath.Contains("fah") = True AndAlso System.IO.File.Exists(g_strDownloadedFilePath) = True Then
                    System.IO.File.Delete(g_strDownloadedFilePath)
                End If
            End If
        Catch ex As Exception
            Msg("Error: Deleting temp FAH install file: " & ex.ToString)
        End Try

        If Me.browser IsNot Nothing Then
            RemoveHandler Me.browser.FrameLoadEnd, AddressOf onBrowserFrameLoadEnd
            RemoveHandler Me.browser.ConsoleMessage, AddressOf onBrowserConsoleMessage
            RemoveHandler Me.browser.StatusMessage, AddressOf OnBrowserStatusMessage
            RemoveHandler Me.browser.LoadingStateChanged, AddressOf OnBrowserLoadingStateChanged
            RemoveHandler Me.browser.TitleChanged, AddressOf OnBrowserTitleChanged
            RemoveHandler Me.browser.AddressChanged, AddressOf OnBrowserAddressChanged

            'Shutdown the web browser control
            CefSharp.Cef.Shutdown()

            'Save any log messages from the screen to a text file. This may make it easier for users to report issues
            If Me.txtMsg.Text.Length > 0 Then
                SaveLogFile(Me.txtMsg.Text)
            End If

            'For CefSharp.Cef.Shutdown(): This 100ms delay seems to help prevent the messed up state for older (and current) CefSharp versions, where the cache needs to be deleted for the FAH Control web page (at least with CEF1, v25)
            Wait(100)
            g_bCancelNav = True
        End If
    End Sub
#End Region

#Region "Button, Checkbox, Combobox - Form Control Events"
    Private Sub btnMyWallet_Click(sender As System.Object, e As System.EventArgs) Handles btnMyWallet.Click
        If LoginToCounterwallet() = False Then MessageBox.Show("Task 'Log Into Wallet' did not complete. Please try again.")
    End Sub

    Private Sub btnFAHControl_Click(sender As System.Object, e As System.EventArgs) Handles btnFAHControl.Click
        OpenURL(URL_FAH_Client, False)
    End Sub

    Private Sub btnFoldingCoinWebsite_Click(sender As System.Object, e As System.EventArgs) Handles btnFoldingCoinWebsite.Click
        OpenURL(URL_FoldingCoin, False)
    End Sub
    Private Sub btnTwitterFoldingCoin_Click(sender As System.Object, e As System.EventArgs) Handles btnTwitterFoldingCoin.Click
        OpenURL(URL_Twitter_FoldingCoin, False)
    End Sub
    Private Sub btnBlockchainFLDC_Click(sender As Object, e As EventArgs) Handles btnBlockchainFLDC.Click
        OpenURL(URL_BlockchainFLDC, False)
    End Sub

    Private Sub btnFLDC_DailyDistro_Click(sender As System.Object, e As System.EventArgs) Handles btnFLDC_DailyDistro.Click
        OpenURL(URL_FLDC_Distro, False)
    End Sub

    Private Sub btnCureCoin_Click(sender As System.Object, e As System.EventArgs) Handles btnCureCoin.Click
        OpenURL(URL_CureCoin, False)
    End Sub
    Private Sub btnTwitterCureCoin_Click(sender As System.Object, e As System.EventArgs) Handles btnTwitterCureCoin.Click
        OpenURL(URL_Twitter_CureCoin, False)
    End Sub
    Private Sub btnBlockchainCURE_Click(sender As Object, e As EventArgs) Handles btnBlockchainCURE.Click
        OpenURL(URL_BlockchainCURE, False)
    End Sub


    'Extreme Overclocking's User Stats page: Needs to know user ID # ...  Once known, store the info in the INI file
    Private Sub btnEOC_Click(sender As System.Object, e As System.EventArgs) Handles btnEOC.Click
        Dim strUserId As String = "0"
        Dim strUsername As String = ""

        Try
            'Get EOC Username ID from INI
            If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_EOC_ID) IsNot Nothing Then
                strUserId = INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_EOC_ID).Value
            Else
                'Fix missing value. Add temp ExtremeOverclocking.com Username Id
                INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_EOC_ID).Value = "0"
                INI.Save(IniFilePath)
            End If

            'Get FAH Username from INI
            If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_FAH_Username) IsNot Nothing Then
                strUsername = INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_FAH_Username).GetValue()
            Else
                'Fix missing value. Ask for FAH Username
                Dim Prompt As New TextEntryDialog
                Prompt.Text = "Save Folding@Home Username"
                Prompt.MsgTextUpper.Text = "Folding@Home Username not found."
                Prompt.MsgTextLower.Text = "Please enter your Folding@Home Username:"
                Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
                Prompt.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Prompt.ShowDialog() = DialogResult.OK Then
                    'Store FAH Username
                    INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_FAH_Username).Value = Prompt.TextEnteredUpper.Text
                    INI.Save(IniFilePath)
                    strUsername = Prompt.TextEnteredUpper.Text
                Else
                    OpenURL(URL_CureCoin_EOC, False)
                    PageTitleWait("Curecoin")
                    Wait(100)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Msg("Error: Loading Extreme Overclocking settings: " & ex.ToString)
        End Try

        Try
            'No UserId, but if you have the FAH Username stored, then go look up the Id on EOC
            If strUserId = "0" Then
                OpenURL(URL_CureCoin_EOC, False)
                PageTitleWait("Curecoin")
                Wait(100)

                'Enter FAH Username in the Search TextBox
                EnterTextByName("searchbox", strUsername)
                Wait(100)

                'Click the search button. Submit the form data since there are no real Ids, Names, or Tags for this button element, just use the 1st item in the array of forms
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.forms[0].submit();")
                PageTitleWait("Search")
                Wait(100)

                'Get link, and parse Id. The line with the Username has the EOC User ID number
                If FindTextInDoc("/user_summary.php?s=&amp;u=*"">" & strUsername & "</a></td>", strUserId, "") = True AndAlso strUserId.Length > 1 AndAlso IsNumeric(strUserId) Then
                    'Save the ExtremeOverclocking.com Username Id
                    INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_EOC_ID).Value = strUserId
                    INI.Save(IniFilePath)

                    'Open the user's EOC stats page
                    OpenURL(URL_EOC & strUserId, False)
                Else
                    'Fix missing value. Ask for EOC User ID
                    Dim Prompt As New TextEntryDialog
                    Prompt.Text = "Save ExtremeOverclocking.com Username Id"
                    Prompt.MsgTextUpper.Text = "ExtremeOverclocking.com Username Id not found."
                    Prompt.MsgTextLower.Text = "Please enter your ExtremeOverclocking.com Username Id number:"
                    Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
                    Prompt.TextEnteredLower.Visible = False
                    'Show modal dialog box
                    If Prompt.ShowDialog() = DialogResult.OK AndAlso IsNumeric(Prompt.TextEnteredUpper.Text) Then
                        'Store ExtremeOverclocking.com Username Id
                        INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_EOC_ID).Value = Prompt.TextEnteredUpper.Text
                        INI.Save(IniFilePath)
                        strUsername = Prompt.TextEnteredUpper.Text
                        'Open the user's EOC stats page
                        OpenURL(URL_EOC & strUserId, False)
                    End If
                End If
            Else
                'Open the user's EOC stats page
                OpenURL(URL_EOC & strUserId, False)
            End If

        Catch ex As Exception
            OpenURL(URL_CureCoin_EOC, False)
            Msg("Error: Extreme Overclocking Username ID lookup failed: " & ex.ToString & vbNewLine & vbNewLine & "Please fix value in user's INI file:" & vbNewLine & IniFilePath)
        End Try
    End Sub

    Private Sub chkShowTools_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkShowTools.CheckedChanged
        If Me.chkShowTools.Checked = True Then
            Me.gbxTools.Visible = True
            Me.txtMsg.Visible = True
            Me.btnBrowserTools.Visible = True
        Else
            Me.gbxTools.Visible = False
            Me.txtMsg.Visible = False
            Me.btnBrowserTools.Visible = False
        End If
    End Sub

    Private Sub btnGetFAH_Click(sender As System.Object, e As System.EventArgs) Handles btnGetFAH.Click
        'TODO: only ask if FAH is not installed?


        If MessageBox.Show("Get Folding@Home Software: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            g_bAskDownloadLocation = True
            GetFAH()
            'If GetFAH() = False Then MessageBox.Show("Task 'Get Folding@Home App' did not complete.")
        End If
    End Sub

    Private Async Sub btnGetWallet_Click(sender As System.Object, e As System.EventArgs) Handles btnGetWallet.Click
        'TODO: only ask if no wallet info exists for this Wallet Id slot?


        If MessageBox.Show("Get Wallet: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            If Await GetWallet() = False Then MessageBox.Show("Task 'Get Wallet' did not complete.")
        End If
    End Sub

    Private Sub btnFAHConfig_Click(sender As System.Object, e As System.EventArgs) Handles btnFAHConfig.Click
        SetupFAHUserTeamAndCfg()
    End Sub

    Private Async Sub btnCureCoinSetup_Click(sender As Object, e As EventArgs) Handles btnCureCoinSetup.Click
        If MessageBox.Show("Setup CureCoin Folding Pool: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            If Await SetupCureCoin() = False Then
                MessageBox.Show("Task 'Setup CureCoin Folding Pool' did not complete.")
            Else
                'Good
                Dim MsgBx As New MsgBoxDialog
                MsgBx.Text = "CureCoin Folding Pool Setup Complete"
                MsgBx.MsgText.Text = "CureCoin Folding Pool Setup Complete" & vbNewLine & "Please review settings, but they should be OK"
                MsgBx.Width = (MsgBx.MsgText.Left * 2) + MsgBx.MsgText.Width + 10
                MsgBx.ShowDialog()
            End If
        End If
    End Sub

    Public Sub cbxWalletId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWalletId.SelectedIndexChanged
        'Make sure the INI key/value exists
        If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
            'Load the Wallet name from the INI file based on the Wallet Id#
            Me.txtWalletName.Text = INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName).GetValue()
        Else
            Me.txtWalletName.Text = "<Not Used>"
        End If
    End Sub

    Private Sub btnBrowserTools_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowserTools.Click
        Me.browser.GetBrowser.GetHost.ShowDevTools()
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

    Private Sub btnSavedData_Click(sender As Object, e As EventArgs) Handles btnSavedData.Click
        Dim DlgDisplaySavedData As New DisplayTextDialog
        DlgDisplaySavedData.Show()
    End Sub
#End Region

#Region "Auto-Wallet Login"
    Private Function LoginToCounterwallet() As Boolean
        LoginToCounterwallet = False
        Dim DAT As New IniFile
        Dim bSaved12W As Boolean = False
        Try
            'CounterWallet web page 
            OpenURL(URL_Counterwallet, False)
            PageTitleWait("Counterwallet")
            Wait(700)

            'Make sure DAT file exists
            If System.IO.File.Exists(DatFilePath) = True Then
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If
            End If

            'If there is no DAT file, then prompt to make one. If no saved data, then ask for the 12-word Passphrase
            If DAT.GetSection(Id & Me.cbxWalletId.Text) Is Nothing OrElse DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CP12Words) Is Nothing Then
                'Prompt for PW, and save it
                Dim Prompt As New TextEntryDialog
                Prompt.Text = "Save Wallet Password"
                Prompt.MsgTextUpper.Text = "No saved wallet info yet."
                Prompt.MsgTextLower.Text = "Please enter your 12-word Passphrase:"
                Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
                Prompt.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Prompt.ShowDialog() = DialogResult.OK Then
                    'Save and encrypt 12-word Passphrase
                    If Prompt.TextEnteredUpper.Text.Length > 24 Then
                        DAT.AddSection(Id & Me.cbxWalletId.Text)
                        DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = Prompt.TextEnteredUpper.Text
                    End If

                    'Create text from the INI, Encrypt, and Write/Flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))

                    'Save a wallet name
                    INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = "My Wallet"
                    INI.Save(IniFilePath)

                    'Allow time for the file to be written out
                    Wait(100)

                    'Refresh the Wallet Names
                    cbxWalletId_SelectedIndexChanged(Nothing, Nothing)
                    bSaved12W = True
                End If
            Else
                bSaved12W = True
            End If

            If bSaved12W = True Then
                'Enter 12-word Passphrase to login
                EnterTextById("password", DAT.GetSection(Id & Me.cbxWalletId.Text).GetKey(DAT_CP12Words).GetValue())
                Wait(50)
                DAT = Nothing

                'Trigger event to enable the Login button, since there was no keystroke event to enable the button
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("ko.utils.triggerEvent(document.getElementById('password'), 'input');")

                'Click Login button
                ClickById("walletLoginButton", True)

                LoginToCounterwallet = True
            End If

        Catch ex As Exception
            Msg("Auto-Wallet Login error:" & ex.ToString)
            If DAT IsNot Nothing Then DAT = Nothing
        End Try
    End Function
#End Region

#Region "Automated Processes - Mostly for the 'one time only' setups"
    Private Async Function GetWallet() As Threading.Tasks.Task(Of Boolean)
        Try
            'Look to see if the wallet INI key/value exists, and warn user to change wallet info slots, or the info will be overwritten
            If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
                'Load the Wallet name from the INI file based on the Wallet Id#
                If MessageBox.Show("WARNING: Wallet Id #" & Me.cbxWalletId.Text & " info already exists!  Overwrite?" & vbNewLine & "(A different Wallet Id can be set in the 'Tools' section)", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) <> MsgBoxResult.Ok Then
                    Return True
                End If
            End If

            'CounterWallet web page 
            OpenURL(URL_Counterwallet, False)
            PageTitleWait("Counterwallet")
            Await Wait2(700)

            'Click Create New CounterWallet
            ClickById("newWalletButton", False)

            'Save 12-word Passphrase and BTC address
            Dim str12W As String = ""
            Dim strBTCAddr As String = ""

            For i As Integer = 0 To 20
                If FindTextInDoc("generatedPassphrase"">*</span>", str12W, "") = True AndAlso str12W.Length > 24 Then
                    Exit For
                End If
                Await Wait2(200)
            Next

            If str12W.Length > 24 Then
                'Click the "I've written it down" check box
                ClickByName("passphraseSaved", False)
                'Click Continue button
                ClickById("continueWalletCreation", False)
                Await Wait2(100)

                'There are 3 buttons with this ID: finishWalletCreation. Use the class to get the ('btn btn-primary') 4th instance for the Create Wallet button:
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('btn btn-primary')[3].click();")
                Await Wait2(100)

                'Click the 'X' close button.  Not working: click OK, the ('btn btn-primary') 9th instance for the OK button.
                Dim FileURL As String = ""
                ClickByClass("bootbox-close-button close", False, FileURL)

                'Enter 12-word Passphrase to login
                EnterTextById("password", str12W)
                'Trigger event to enable the Login button, since there was no keystroke event to enable the button
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("ko.utils.triggerEvent(document.getElementById('password'), 'input');")

                'Click Login button
                ClickById("walletLoginButton", True)
                Await Wait2(1000)

                'First login, accept terms. ('btn btn-success') 2nd instance for the Accept button:
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('btn btn-success')[1].click();")

                'The logged into wallet web page has no title, but the previous page had a title
                PageNoTitleWait()

                For i As Integer = 1 To 40
                    If FindTextInDoc("selectAddressText, text: dispAddress"">*</span>", strBTCAddr, "") = True Then
                        If strBTCAddr.Length >= 26 AndAlso strBTCAddr.Length <= 35 AndAlso (strBTCAddr.StartsWith("1") = True OrElse strBTCAddr.StartsWith("3") = True) Then
                            Exit For
                        End If
                    End If
                    Await Wait2(200)
                Next

                'Save and encrypt the 12 word Passphrase and the Bitcoin address
                Dim DAT As New IniFile
                If System.IO.File.Exists(DatFilePath) = True Then
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If
                End If

                'Write out data to INI info
                DAT.AddSection(Id & Me.cbxWalletId.Text)
                DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = str12W

                If strBTCAddr.Length > 25 Then
                    'Store Bitcoin address in both INI and DAT files
                    DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_BTC_Addr).Value = strBTCAddr
                    'Set a wallet name
                    INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = strBTCAddr.Substring(0, 8) & "..."
                    INI.Save(IniFilePath)
                End If
                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(DAT.SaveToString))
                DAT = Nothing

                'Allow time for the file to be written out
                Await Wait2(100)

                'Refresh the Wallet Names
                cbxWalletId_SelectedIndexChanged(Nothing, Nothing)

                'Exit / Return true
                Return True

            Else
                str12W = "Error: 12 Word password not found while getting Wallet. Please try again."
                Msg(str12W)
                MessageBox.Show(str12W)
            End If

        Catch ex As Exception
            Msg("Get Wallet error:" & ex.ToString)
        End Try
        Return False
    End Function

    Private Function GetFAH() As Boolean
        GetFAH = False
        Try
            'Get Folding@Home App
            OpenURL(URL_FAH, False)
            PageTitleWait("Folding@home")
            Wait(100)

            'Get EXE file name to execute
            Dim FileURL As String = ""

            'Click the link for Windows download (This initial step appears to be needed? even though the link is in the HTML)
            ClickByClass("download-btn", False, FileURL)
            Wait(200)

            'Make the download progress visible
            Me.gbxDownload.Visible = True
            'Start the download: Click the link for Windows download
            ClickByClass("fah-platform-downloads", False, FileURL)
            Wait(200)

            'Close the download pop-up window
            ClickByClass("modalCloseImg simplemodal-close", False, FileURL)

            'Close any running instances of FAH
            Dim p As Process
            Try
                For Each p In Process.GetProcessesByName("FAHClient")
                    Msg("Asking to close FAH process: " & p.Id.ToString() & " - " & p.ProcessName)
                    MessageBox.Show("Please close the Folding@Home software before proceeding.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Wait(1000)
                    Exit For
                Next

            Catch ex As Exception
                Msg("Error asking for FAH to be closed: " & ex.ToString)
            End Try

            'If still open, then close it
            Try
                For Each p In Process.GetProcessesByName("FAHClient")
                    Msg("Closing process: " & p.Id.ToString() & " - " & p.ProcessName)
                    p.CloseMainWindow()
                    p.WaitForExit(3000)

                    'Check for the process being closed
                    If p.HasExited = False Then
                        Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                        p.Kill()
                        System.Threading.Thread.Sleep(400)
                    End If
                Next

                'Try closing any FAH Core processes still active
                For Each p In Process.GetProcesses
                    If p.ProcessName.ToLower.StartsWith("fahcore_") = True Then
                        Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                        p.Kill()
                    End If
                Next
            Catch ex As Exception
                Msg("Couldn't kill FAH: " & ex.ToString)
            End Try

            '2nd try to close any running instances of FAH
            Try
                For Each p In Process.GetProcessesByName("FAHClient")
                    'Wait for FAH to exit before trying again
                    System.Threading.Thread.Sleep(5000)
                    Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                    p.Kill()
                    System.Threading.Thread.Sleep(3000)
                Next

                'Try closing any FAH Core processes still active
                For Each p In Process.GetProcesses
                    If p.ProcessName.ToLower.StartsWith("fahcore_") = True Then
                        Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                        p.Kill()
                    End If
                Next
            Catch ex As Exception
                Msg("Couldn't kill FAH: " & ex.ToString)
            End Try

            'Is the download done?
            Dim i As Integer = 0
            'Wait for the web page, or 2 hours
            Do Until Me.gbxDownload.Visible = False OrElse g_bCancelNav = True OrElse i > 2400
                i += 1
                Wait(500)
            Loop
            'Download didn't finish or was canceled. Don't reset: g_bCancelNav = False, here because it messes up canceling the download
            If i >= 2400 Then Exit Try
            'Let the screen refresh
            Wait(50)

            'Run FAH installer (stops any running instances and un-installs previous version) and wait for it to finish
            If g_strDownloadedFilePath.Length > 0 Then
                Dim process1 As System.Diagnostics.Process = New System.Diagnostics.Process()
                process1.StartInfo.FileName = g_strDownloadedFilePath
                'Allow prompt for elevation
                process1.StartInfo.Verb = "runas"
                process1.StartInfo.UseShellExecute = True
                process1.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                'Run the installer
                process1.Start()
                'Wait for installer to exit
                process1.WaitForExit()
                'Free resources from the process
                process1.Close()

                'Return true, if the FAH config setup completes
                GetFAH = True
            End If

        Catch ex As Exception
            Msg("Get FAH error:" & ex.ToString)
        End Try

        'Reset flag
        g_bAskDownloadLocation = True
        Me.gbxDownload.Visible = False
    End Function

    Public Function SetupFAHUserTeamAndCfg() As Boolean
        SetupFAHUserTeamAndCfg = False
        Try
            'Prompt for FAH info: Ask for: (existing) Username, Merged Folding Coin Selection, FAH Team #. Show Username as typing and check it for errors. (Optional) Get Passkey by email. Show before and after of the FAH Config file changes 
            Dim DialogFAH As New FAHSetupDialog
            'Show modal dialog box
            If DialogFAH.ShowDialog() = DialogResult.OK Then
                'Return true, if you get here
                SetupFAHUserTeamAndCfg = True
            End If

        Catch ex As Exception
            Msg("Setup FAH User, Team, and Config error:" & ex.ToString)
        End Try
    End Function

    'This is called by the 'FAHSetupDialog' window to get the Passkey email from Stanford
    Public Function GetFAHpasskey(URL As String) As Boolean
        GetFAHpasskey = False
        Try
            'Get Folding@Home App
            OpenURL(URL, False)
            PageTitleWait("Folding@home")
            Wait(100)

            'Return true, if you get here
            GetFAHpasskey = True

        Catch ex As Exception
            Msg("Get FAH passkey error:" & ex.ToString)
        End Try
    End Function

    Public Async Function SetupCureCoin() As Threading.Tasks.Task(Of Boolean)
        Dim strWalletVersion As String = ""
        Dim strWalletName As String = ""
        Dim strWalletAddress As String = ""
        Dim strPoolPW As String = ""
        Dim strPoolPin As String = ""
        Dim strFAHUser As String = ""
        Dim strEmail As String = ""
        Dim strPasskey As String = ""

        Dim randNum As New Random()
        Dim DAT As New IniFile

        Try
            'Go to the CureCoin folding pool (CryptoBullionPools) website
            OpenURL(URL_CureCoinFoldingPoolPage & "register", False)

            If System.IO.File.Exists(DatFilePath) = True Then
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If
            End If

            'Try to get the CureCoin Address from saved info first
            If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Addr) IsNot Nothing Then
                strWalletAddress = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Addr).GetValue()
            End If

            'See if the CureCoin Address was found, if not then try to get it
            If strWalletAddress.Length < 24 Then
                'Setup retries
                For j As Integer = 0 To 1
                    'Test if the CureCoin wallet process is running. If not then prompt to start it up
                    Dim p As Process
                    Dim bRunning As Boolean = False
                    Try
                        For Each p In Process.GetProcessesByName("curecoin-qt")
                            Msg("CureCoin Wallet is running (good). Process: " & p.Id.ToString() & " - " & p.ProcessName)
                            bRunning = True
                            Exit For
                        Next

                    Catch ex As Exception
                        Msg("Error finding if CureCoin Wallet is running: " & ex.ToString)
                    End Try

                    If bRunning = False Then
                        Msg("CureCoin Wallet not running")
                        'Make sure the config file ('curecoin.conf.example') is availible
                        Dim strCureCoinConfigPath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "curecoin", "curecoin.conf.example")
                        Dim strCureCoinEXEPath As String = ""
                        If Environment.Is64BitOperatingSystem = True Then
                            '64-bit OS, x86 folder
                            strCureCoinEXEPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "CureCoin", "curecoin-qt.exe")
                        Else
                            '32-bit
                            strCureCoinEXEPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "CureCoin", "curecoin-qt.exe")
                        End If

                        'Run the CureCoin Qt Wallet with command line options
                        If System.IO.File.Exists(strCureCoinEXEPath) = True Then
                            'Start EXE with the command line options to load 'curecoin.conf.example' settings for the RPC login and port instead (config file installed with installer)
                            Dim process1 As System.Diagnostics.Process = New System.Diagnostics.Process()
                            process1.StartInfo.FileName = strCureCoinEXEPath
                            process1.StartInfo.Arguments = "-conf=" & strCureCoinConfigPath
                            'process1.StartInfo.UseShellExecute = True
                            process1.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                            process1.Start()
                            'Free resources from the process
                            process1.Close()

                            Msg("CureCoin Wallet started")
                            Await Wait2(2000)

                            'Test if the CureCoin wallet process is running
                            bRunning = False
                            Try
                                For Each p In Process.GetProcessesByName("curecoin-qt")
                                    Msg("CureCoin Wallet is running (good). Process: " & p.Id.ToString() & " - " & p.ProcessName)
                                    bRunning = True
                                    Exit For
                                Next

                            Catch ex As Exception
                                Msg("Error finding if CureCoin Wallet is running: " & ex.ToString)
                            End Try
                        End If
                    End If


                    'Get CureCoin address from the wallet using HTTP JSON-RPC
                    If My.Computer.Network.IsAvailable = True Then
                        'Ensure IP address is available
                        If My.Computer.Network.Ping("localhost", 1500) = True Then

                            Msg("HTTP JSON-RPC on http://username:password@localhost:18512.")

                            'Get the wallet version, mostly for debugging issues later
                            strWalletVersion = SendHTTP_JSON_RPC("{""jsonrpc"": ""1.0"", ""id"":""GetVers"", ""method"": ""getinfo"", ""params"": [] }")
                            If strWalletVersion.Contains("GetVers") AndAlso FindTextInDoc(""":""*"",""", strWalletVersion, strWalletVersion) = True AndAlso strWalletVersion.Length > 5 Then
                                'Setup a loop for a few retries
                                For i As Integer = 0 To 2
                                    Await Wait2(700)
                                    'Get the wallet name to get the wallet address
                                    strWalletName = SendHTTP_JSON_RPC("{""jsonrpc"": ""1.0"", ""id"":""GetMyWalletName"", ""method"": ""listaccounts""}")

                                    If strWalletName.Contains("GetMyWalletName") AndAlso FindTextInDoc(":{""*"":", strWalletName, strWalletName) = True Then
                                        Await Wait2(700)
                                        'Get the Wallet Address using the wallet name from the first request
                                        strWalletAddress = SendHTTP_JSON_RPC("{""jsonrpc"": ""1.0"", ""id"":""GetMyCureCoinAddress"", ""method"": ""getaddressesbyaccount"", ""params"":[""" & strWalletName & """]}")

                                        If strWalletAddress.Contains("GetMyCureCoinAddress") AndAlso FindTextInDoc("{""result"":[""*""],", strWalletAddress, strWalletAddress) = True AndAlso strWalletAddress.Length > 24 Then
                                            Exit For
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    End If

                    If strWalletAddress.Length > 24 Then
                        Exit For
                    End If
                    Await Wait2(3000)
                Next
            End If

        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try

        Try
            'If the wallet address is still not found, then pop-up a message saying to fill in the address
            If strWalletAddress.Length < 24 Then
                'Prompt for PW, and save it
                Dim Prompt As New TextEntryDialog
                Prompt.Text = "Save CureCoin Wallet Address"
                Prompt.MsgTextUpper.Text = "From the 'Receive coins' address tab in the CureCoin Wallet Software,"
                Prompt.MsgTextLower.Text = "Please enter your CureCoin Wallet Address (right-click, Copy Address):"
                Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
                Prompt.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Prompt.ShowDialog() = DialogResult.OK Then
                    'Get the Wallet Address
                    If Prompt.TextEnteredUpper.Text.Length > 24 Then
                        strWalletAddress = Prompt.TextEnteredUpper.Text
                    End If
                End If
            End If

            'Exit / Return false, if there is no CureCoin wallet address
            If strWalletAddress.Length < 24 Then Return False

            'Save the DAT info
            If DAT.GetSection(Id & g_Main.cbxWalletId.Text) Is Nothing Then DAT.AddSection(Id & g_Main.cbxWalletId.Text)
            If strWalletVersion.Length > 5 Then DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_CureCoin_Wallet_Version).Value = strWalletVersion
            If strWalletAddress.Length > 24 Then DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_CureCoin_Addr).Value = strWalletAddress

            'Try to get the FAH Username from saved info first
            If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                strFAHUser = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
            End If
            If strFAHUser.Length < 2 Then
                'Prompt for FAH username (and all the other info?). Can be short for a CureCoin only username...
                Dim Pmt As New TextEntryDialog
                Pmt.Text = "Save Folding Username / CureCoin Pool Login"
                Pmt.MsgTextUpper.Text = "Please enter your Folding Username."
                Pmt.MsgTextLower.Text = "This is used as the CureCoin Pool Login:"
                Pmt.Width = (Pmt.MsgTextLower.Left * 2) + Pmt.MsgTextLower.Width + 10
                Pmt.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Pmt.ShowDialog() = DialogResult.OK Then
                    'Get the Wallet Address
                    If Pmt.TextEnteredUpper.Text.Length > 1 Then
                        strFAHUser = Pmt.TextEnteredUpper.Text
                        DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_FAH_Username).Value = strFAHUser
                    End If
                End If
            End If

            'Try to get the Email from saved info first
            If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_Email) IsNot Nothing Then
                strEmail = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_Email).GetValue()
            End If
            If strEmail.Length < 4 Then
                'Prompt for FAH username (and all the other info?). Can be short for a CureCoin only username...
                Dim Prmt As New TextEntryDialog
                Prmt.Text = "Save Email Address"
                Prmt.MsgTextUpper.Text = "Please enter your Email Address."
                Prmt.MsgTextLower.Text = "This is used for the CureCoin Pool sign up:"
                Prmt.Width = (Prmt.MsgTextLower.Left * 2) + Prmt.MsgTextLower.Width + 10
                Prmt.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Prmt.ShowDialog() = DialogResult.OK Then
                    'Get the Wallet Address
                    If Prmt.TextEnteredUpper.Text.Length > 3 Then
                        strEmail = Prmt.TextEnteredUpper.Text
                        DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_Email).Value = strEmail
                    End If
                End If
            End If

            'Try to get the CureCoin pool password from saved info first
            If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Pwd) IsNot Nothing Then
                strPoolPW = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Pwd).GetValue()
            End If
            If strPoolPW.Length < 5 Then
                'Makeup a new 50 char Password
                If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_FAH_Passkey) IsNot Nothing Then
                    'The passkey is 32 digits. Only use the first 30 digits
                    strPasskey = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_FAH_Passkey).GetValue().Substring(0, 30).Trim
                End If
                'Create the unique 50 char Password
                strPoolPW = (System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Hex(randNum.Next()) & Now.ToLongDateString & Now.ToLongTimeString & Hex(randNum.Next()) & strPasskey)) & System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Hex(randNum.Next()) & Now.ToString & Hex(randNum.Next())))).Substring(0, 50)

                'Save the new Password
                If strPoolPW.Length > 24 Then DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_CureCoin_Pwd).Value = strPoolPW
            End If

            'Try to get the CureCoin pool pin from saved info first
            If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Pin) IsNot Nothing Then
                strPoolPin = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Pin).GetValue()
            End If
            If strPoolPin.Length < 6 Then
                'Makeup a new Pin (6-20 char)
                Do Until strPoolPin.Length > 9 OrElse g_bCancelNav = True
                    strPoolPin &= randNum.Next().ToString
                Loop

                If strPoolPin.Length > 20 Then
                    strPoolPin = strPoolPin.Substring(0, 20)
                End If
                'Save the new Pin
                If strPoolPin.Length >= 6 Then DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_CureCoin_Pin).Value = strPoolPin
            End If

            'Create text from the INI, Encrypt, and Write/flush DAT text to file
            SaveDat(Encrypt(DAT.SaveToString))
            DAT = Nothing

            Await Wait2(1000)
            PageLoadWait()
            PageTitleWait(NameCryptoBullions)
            System.Windows.Forms.Application.DoEvents()

            'Setup retries if the captcha fails / CloudFlare takes too long (~5s)
            For m As Integer = 0 To 2
                'Wait for the registration page to load, if not already (needs to wait for CloudFlare to reload the page)
                Await Wait2(1000)
                PageLoadWait()
                PageTitleWait(NameCryptoBullions)
                System.Windows.Forms.Application.DoEvents()

                For i = 0 To 20
                    If Me.Text.Contains("Just") = False Then Exit For
                    Await Wait2(300)
                Next

                For i = 0 To 20
                    If Me.Text.Contains(NameCryptoBullions) = True Then Exit For
                    Await Wait2(300)
                Next

                PageLoadWait()
                PageTitleWait(NameCryptoBullions)
                Await Wait2(1000)
                System.Windows.Forms.Application.DoEvents()

                For i = 0 To 20
                    Await Wait2(200)
                    If Me.Text.Contains(NameCryptoBullions) = True Then Exit For
                Next

                PageLoadWait()
                PageTitleWait(NameCryptoBullions)
                Await Wait2(1000)
                System.Windows.Forms.Application.DoEvents()
                'TODO: ensure the Pool page loaded before proceeding (and it's not still loading CloudFlare...)


                'Fill in form info from the data
                'Enter FAH Username
                EnterTextByName("user", strFAHUser)
                'Password
                EnterTextByName("pass", strPoolPW)
                EnterTextByName("pass2", strPoolPW)
                'Email
                EnterTextByName("email", strEmail)
                EnterTextByName("email2", strEmail)
                'Pin
                EnterTextByName("authPin", strPoolPin)
                Await Wait2(50)


                'Login: Enter FAH Username
                EnterTextByName("username", strFAHUser)
                'Password
                EnterTextByName("password", strPoolPW)
                Await Wait2(50)

                'Ask for the Captcha in a modal dialog, to enter in the form (to keep the user from mofifying the passwords)
                Dim Dlg As New TextEntryDialog
                Dlg.Text = "Enter Captcha Text"
                Dlg.MsgTextUpper.Text = "From the bottom of the registration page,"
                Dlg.MsgTextLower.Text = "Please enter the captcha text:"
                Dlg.Width = (Dlg.MsgTextUpper.Left * 2) + Dlg.MsgTextUpper.Width + 10
                Dlg.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Dlg.ShowDialog() = DialogResult.OK Then
                    EnterTextByName("captcha_code", Dlg.TextEnteredUpper.Text)

                    'Click "Register" (There are 2 buttons with this class. Click the 2nd button [1])
                    Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('submit small')[1].click();")
                    Await Wait2(1000)

                    'Wait for the page to load
                    PageLoadWait()
                    PageTitleWait(NameCryptoBullions)

                    'TODO: Set an INI file flag that the account was created? (This can be undesirable if you want to redo a failed first attempt?)
                    'TODO: Find account created text? or Error account already created, to show the correct dialog box below


                    'Fill in form info from the data again, so the user can try again if the captcha fails here...
                    'Enter FAH Username
                    EnterTextByName("user", strFAHUser)
                    'Password
                    EnterTextByName("pass", strPoolPW)
                    EnterTextByName("pass2", strPoolPW)
                    'Email
                    EnterTextByName("email", strEmail)
                    EnterTextByName("email2", strEmail)
                    'Pin
                    EnterTextByName("authPin", strPoolPin)
                    Await Wait2(50)


                    'Login: Enter FAH Username
                    EnterTextByName("username", strFAHUser)
                    'Password
                    EnterTextByName("password", strPoolPW)
                    Await Wait2(50)

                    'Ask user to solve the captcha
                    Dim MsgBx As New MsgBoxDialog
                    MsgBx.Text = "Please Login"
                    MsgBx.MsgText.Text = "If your account was created:" & vbNewLine & "<-- Please click 'I'm not a robot', solve the captcha, and 'Login'" & vbNewLine & "Otherwise, try the account creation captcha again"
                    MsgBx.Width = (MsgBx.MsgText.Left * 2) + MsgBx.MsgText.Width + 10
                    MsgBx.ShowDialog()

                    'Wait to be logged into the 'My Account' page: look for text on that page to know when logged in...
                    Dim strTemp As String = ""
                    For k As Integer = 1 To 120
                        If g_bCancelNav = True Then Exit Try

                        If FindTextInDoc("<h1>News*>", strTemp, "") = True Then
                            If strTemp.Length > 0 Then
                                Exit For
                            End If
                        End If
                        Await Wait2(2000)
                    Next

                    'Go to the CureCoin folding pool (CryptoBullionPools) website, and go to the 'My Account' settings page
                    OpenURL(URL_CureCoinFoldingPoolPage & "accountdetails", False)
                    'Wait for the page to load
                    PageLoadWait()
                    PageTitleWait(NameCryptoBullions)
                    Await Wait2(200)
                    'Wait to be logged into the 'My Account' page: look for text on that page to know when logged in...
                    strTemp = ""
                    For l As Integer = 1 To 60
                        If g_bCancelNav = True Then Exit Try

                        If FindTextInDoc("<h2>Account De*ils", strTemp, "") = True Then
                            If strTemp.Length > 0 Then
                                Exit For
                            End If
                        End If
                        Await Wait2(2000)
                    Next

                    'Fill in CureCoin address
                    EnterTextByName("paymentAddress", strWalletAddress)
                    'Fill-in payout threshold
                    EnterTextByName("payoutThreshold", "1")
                    'Pin
                    EnterTextByName("authPin", strPoolPin)
                    Await Wait2(50)

                    'Click "Update Settings"
                    Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('submit long')[0].click();")
                    Await Wait2(700)

                    'Return true, if you get here
                    Return True
                End If
            Next

        Catch ex As Exception
            Msg("Setup CureCoin Folding Pool info error:" & ex.ToString)
        End Try

        Return False
    End Function

    Private Function SendHTTP_JSON_RPC(strJSON_Cmd As String) As String
        SendHTTP_JSON_RPC = ""
        Try
            'Start Telnet session
            If My.Computer.Network.IsAvailable = True Then
                'Ensure IP address is available
                If My.Computer.Network.Ping("localhost", 1500) = True Then
                    Dim byteArray As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(strJSON_Cmd)
                    Dim webRequest As Net.HttpWebRequest = CType(Net.WebRequest.Create("http://localhost.:18512"), Net.HttpWebRequest)
                    webRequest.Credentials = New Net.NetworkCredential("username", "password")
                    webRequest.ContentType = "application/json-rpc"
                    webRequest.Method = "POST"
                    webRequest.ContentLength = byteArray.Length
                    Dim dataStream As IO.Stream = webRequest.GetRequestStream()
                    dataStream.Write(byteArray, 0, byteArray.Length)
                    Wait(200)

                    'Get response
                    Dim response As Net.WebResponse = webRequest.GetResponse()
                    Msg(CType(response, Net.HttpWebResponse).StatusDescription)
                    dataStream = response.GetResponseStream()
                    Dim reader As New IO.StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Msg(responseFromServer)
                    SendHTTP_JSON_RPC = responseFromServer

                    'Close objects
                    reader.Close()
                    response.Close()
                    dataStream.Close()
                End If
            End If
        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Function

    Private Async Sub btnCurePool_Click(sender As Object, e As EventArgs) Handles btnCurePool.Click
        Dim strFAHUser As String = ""
        Dim strPoolPW As String = ""
        Dim bSaveDat As Boolean = False
        Dim DAT As New IniFile

        Try
            'Setup retries if the captcha fails / CloudFlare takes too long (~5s)
            For m As Integer = 0 To 2
                'Go to the CureCoin folding pool (CryptoBullionPools) website
                OpenURL(URL_CureCoinFoldingPoolPage, False)

                'Wait for the registration page to load, if not already (needs to wait for CloudFlare to reload the page)
                Await Wait2(2000)
                PageLoadWait()
                PageTitleWait(NameCryptoBullions)
                System.Windows.Forms.Application.DoEvents()

                For i = 0 To 20
                    If Me.Text.Contains("Just") = False Then Exit For
                    Await Wait2(200)
                Next

                For i = 0 To 20
                    If Me.Text.Contains(NameCryptoBullions) = True Then Exit For
                    Await Wait2(200)
                Next

                PageLoadWait()
                PageTitleWait(NameCryptoBullions)
                Await Wait2(1000)
                System.Windows.Forms.Application.DoEvents()
                For i = 0 To 20
                    Await Wait2(200)
                    If Me.Text.Contains(NameCryptoBullions) = True Then Exit For
                Next
                'TODO: ensure the Pool page loaded before proceeding (and it's not still loading CloudFlare...)

                If System.IO.File.Exists(DatFilePath) = True Then
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If
                End If
                'Try to get the FAH Username from saved info first
                If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                    strFAHUser = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
                End If
                If strFAHUser.Length < 2 Then
                    'Prompt for FAH username (and all the other info?). Can be short for a CureCoin only username...
                    Dim Pmt As New TextEntryDialog
                    Pmt.Text = "Save Folding Username / CureCoin Pool Login"
                    Pmt.MsgTextUpper.Text = "Please enter your Folding Username."
                    Pmt.MsgTextLower.Text = "This is used as the CureCoin Pool Login:"
                    Pmt.Width = (Pmt.MsgTextLower.Left * 2) + Pmt.MsgTextLower.Width + 10
                    Pmt.TextEnteredLower.Visible = False
                    'Show modal dialog box
                    If Pmt.ShowDialog() = DialogResult.OK Then
                        'Get the Wallet Address
                        If Pmt.TextEnteredUpper.Text.Length > 1 Then
                            strFAHUser = Pmt.TextEnteredUpper.Text
                            DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_FAH_Username).Value = strFAHUser
                            bSaveDat = True
                        End If
                    End If
                End If

                'Try to get the CureCoin pool password from saved info first
                If DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Pwd) IsNot Nothing Then
                    strPoolPW = DAT.GetSection(Id & g_Main.cbxWalletId.Text).GetKey(DAT_CureCoin_Pwd).GetValue()
                End If
                If strPoolPW.Length < 5 Then
                    'Ask for existing password
                    Dim Prmt As New TextEntryDialog
                    Prmt.Text = "Save Folding Username / CureCoin Pool Login"
                    Prmt.MsgTextUpper.Text = "Please enter your Folding Username."
                    Prmt.MsgTextLower.Text = "This is used as the CureCoin Pool Login:"
                    Prmt.Width = (Prmt.MsgTextLower.Left * 2) + Prmt.MsgTextLower.Width + 10
                    Prmt.TextEnteredLower.Visible = False
                    'Show modal dialog box
                    If Prmt.ShowDialog() = DialogResult.OK Then
                        'Get the Wallet Address
                        If Prmt.TextEnteredUpper.Text.Length > 1 Then
                            strPoolPW = Prmt.TextEnteredUpper.Text
                            DAT.AddSection(Id & g_Main.cbxWalletId.Text).AddKey(DAT_CureCoin_Pwd).Value = strPoolPW
                            bSaveDat = True
                        End If
                    End If
                End If

                If bSaveDat = True Then
                    'Create text from the INI, Encrypt, and Write/flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))
                End If
                DAT = Nothing

                'Login: Enter FAH Username
                EnterTextByName("username", strFAHUser)
                'Password
                EnterTextByName("password", strPoolPW)

                'Ask user to solve the captcha
                Dim MsgBx As New MsgBoxDialog
                MsgBx.Text = "Please Login"
                MsgBx.MsgText.Text = "<-- Please solve the 'I'm not a robot' captcha, and Login"
                MsgBx.Width = (MsgBx.MsgText.Left * 2) + MsgBx.MsgText.Width + 10
                'Show modal dialog box
                If MsgBx.ShowDialog() = DialogResult.OK Then Exit For
            Next

        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Sub
#End Region

#Region "Browser Commands"
    'Specify text box {Object Id}, and text to enter in to the text box
    Private Function EnterTextById(ObjectId As String, sText As String) As Boolean
        EnterTextById = False

        Try
            If ObjectId.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('" & ObjectId & "').value = '" & sText & "';")
                EnterTextById = True
            End If
        Catch ex As Exception
            Msg("Enter Text By Id error: " & Err.Description)
        End Try
    End Function

    'Specify text box {Object Name}, and text to enter in to the text box
    Private Function EnterTextByName(Name As String, sText As String) As Boolean
        EnterTextByName = False

        Try
            If Name.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByName('" & Name & "')[0].value = '" & sText & "';")
                EnterTextByName = True
            End If
        Catch ex As Exception
            Msg("Enter Text By Name error: " & Err.Description)
        End Try
    End Function

    'Specify object {Object Id} to click, and if you wait for the page to load or not
    Private Function ClickById(ObjectId As String, bWait As Boolean) As Boolean
        ClickById = False
        Try
            If ObjectId.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('" & ObjectId & "').click();")
                ClickById = True
                'Wait for the page, if specified
                If bWait = True Then
                    If PageLoadWait() = True Then ClickById = True Else ClickById = False
                End If
            End If
        Catch ex As Exception
            Msg("Click By Id error: " & Err.Description)
        End Try
    End Function

    'Specify object {Object Class} to click, and if you wait for the page to load or not
    Private Function ClickByClass(ObjectClass As String, bWait As Boolean, ByRef href As String) As Boolean
        ClickByClass = False
        Try
            If ObjectClass.Length > 0 Then
                'Get the href URL to pass back
                href = Me.browser.GetBrowser.MainFrame.EvaluateScriptAsync("document.getElementsByClassName('" & ObjectClass & "')[0].attributes.getNamedItem('href').value;").ToString
                'Click it
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('" & ObjectClass & "')[0].click();")
                ClickByClass = True
                'Wait for the page, if specified
                If bWait = True Then
                    If PageLoadWait() = True Then ClickByClass = True Else ClickByClass = False
                End If
            End If

        Catch ex As Exception
            Msg("Click By Class error: " & Err.Description)
        End Try
    End Function

    'Specify object {Object Name} to click, and if you wait for the page to load or not
    Private Function ClickByName(Name As String, bWait As Boolean) As Boolean
        ClickByName = False
        Try
            If Name.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByName('" & Name & "')[0].click();")
                ClickByName = True
                'Wait for the page, if specified
                If bWait = True Then
                    If PageLoadWait() = True Then ClickByName = True Else ClickByName = False
                End If
            End If
        Catch ex As Exception
            Msg("Click By Name error: " & Err.Description)
        End Try
    End Function

    'Specify text to find in HTML document, or supplied text
    Private m_bRunningFind As Boolean = False
    Private Function FindTextInDoc(strFind As String, ByRef strReturnText As String, strSearchThisTextInstead As String) As Boolean
        FindTextInDoc = False
        Dim sText As String() = Nothing
        Dim sMask As String() = Nothing

        Try
            If strFind.Length > 0 Then
                If strSearchThisTextInstead = "" Then
                    If m_bRunningFind = True Then Exit Try
                    m_bRunningFind = True
                    'Try to avoid running this multiple times at once. CefSharp v49 hangs when that happens. Probably from the Wait using: Threading.Thread.Sleep
                    Dim sTempStr As String = browser.GetBrowser.MainFrame.GetSourceAsync.Result
                    m_bRunningFind = False
                    sText = sTempStr.Split(vbNewLine.ToCharArray)
                Else
                    sText = strSearchThisTextInstead.Split(vbNewLine.ToCharArray)
                End If

                If sText IsNot Nothing Then
                    'Search for wild-card (*) data or not
                    If strFind.Contains("*") = False Then
                        'No wild-card, just return the line of text that contains the search text
                        For Each sLineOfText As String In sText
                            If sLineOfText.Contains(strFind) = True Then
                                'Return the line of text that contains the search text
                                strReturnText = Trim(sLineOfText)
                                sText = Nothing
                                Return True
                            End If
                        Next
                    Else
                        'Create the mask to find the wild-card (*) data
                        sMask = strFind.Split("*".ToCharArray, 2)
                        For Each sLineOfText As String In sText
                            'Search through the HTML to find the first part
                            If sLineOfText.Contains(sMask(0)) = True Then
                                'Find the second part in the same line
                                If sLineOfText.Contains(sMask(1)) = True Then
                                    Dim iPos1 As Integer = sMask(0).Length + sLineOfText.IndexOf(sMask(0))
                                    Dim iPos2 As Integer = sLineOfText.IndexOf(sMask(1), iPos1)
                                    If iPos1 <= iPos2 Then
                                        strReturnText = Trim(sLineOfText.Substring(iPos1, iPos2 - iPos1))
                                        sText = Nothing
                                        Return True
                                    End If
                                End If
                            End If
                        Next
                    End If
                End If
            End If

        Catch ex As Exception
            Msg("Find Text In HTML error: " & Err.Description)
            'Reset flag for an error
            m_bRunningFind = False
        End Try
    End Function
#End Region

#Region "Browser Controls"
    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        Me.browser.GetBrowser.Reload(True)
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.browser.GetBrowser.GoBack()
    End Sub

    Private Sub btnFwd_Click(sender As System.Object, e As System.EventArgs) Handles btnFwd.Click
        Me.browser.GetBrowser.GoForward()
    End Sub

    'After entering the URL: Open the URL if 'Enter' is pressed, or Cancel navigation if ESC is pressed.
    Private Sub txtURL_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtURL.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            OpenURL(Me.txtURL.Text, True)

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            StopNavigaion()
        End If
    End Sub

    Private Sub btnStopNavigation_Click(sender As System.Object, e As System.EventArgs) Handles btnStopNav.Click
        StopNavigaion()
    End Sub

    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        OpenURL(Me.txtURL.Text, True)
    End Sub

    'Open URL with the specified settings
    Public Function OpenURL(ByRef sURL As String, Optional bShowErrorDialogBoxes As Boolean = False) As Boolean
        OpenURL = False
        Try
            'Load the web page
            If sURL.Length > 0 And Uri.IsWellFormedUriString(sURL, UriKind.RelativeOrAbsolute) = True Then
                Me.txtURL.Text = sURL

                'Accept Certs to avoid annoying prompts
                System.Net.ServicePointManager.ServerCertificateValidationCallback = New Net.Security.RemoteCertificateValidationCallback(AddressOf ValidateCertificate)

                'Focus the URL text box so the KeyPress events work for Enter / ESC.
                Me.txtURL.BackColor = Color.White
                Me.txtURL.Focus()
                Me.txtURL.Select(Me.txtURL.Text.Length, 0)
                'Reset flag
                m_bPageLoaded = False
                m_strPageURL = Me.txtURL.Text
                Me.browser.Load(Me.txtURL.Text)
                'Wait for the web page or 1 minute
                PageLoadWait()

                OpenURL = True

            Else
                'Error
                Me.txtURL.BackColor = Color.Red
            End If

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Opening URL error: " & Err.Description
            Msg(sRtnErrMsg)

            If bShowErrorDialogBoxes = True Then 'Report errors 
                MessageBox.Show(sRtnErrMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Function

    'Wait for the page to load. Requires the AddHandler to be done before the page loading event, and then call this function.
    Public Function PageLoadWait() As Boolean
        PageLoadWait = False
        Try
            Dim i As Integer = 0
            'Wait for the web page, or 1 minute
            Do Until m_bPageLoaded = True OrElse g_bCancelNav = True OrElse i > 600
                i += 1
                Wait(100)
            Loop
            g_bCancelNav = False

            If i < 600 Then PageLoadWait = True

        Catch ex As Exception
            Msg("Page Loading Wait error: " & Err.Description)
        End Try
    End Function

    'Wait for the page title to load
    Public Function PageTitleWait(ByRef sPageTitle As String) As Boolean
        PageTitleWait = False
        Try
            Dim i As Integer = 0
            'Wait for the webpage title, or 3 seconds
            For i = 0 To 30
                If Me.Text.Contains(sPageTitle) = True OrElse g_bCancelNav = True Then Exit For
                Wait(100)
            Next
            g_bCancelNav = False
            If i < 30 Then PageTitleWait = True

        Catch ex As Exception
            Msg("Page Title Wait error: " & Err.Description)
        End Try
    End Function

    'Wait for No page title for page loading
    Public Function PageNoTitleWait() As Boolean
        PageNoTitleWait = False
        Try
            Dim i As Integer = 0
            'Wait for the web page title, or 3 seconds
            For i = 0 To 30
                If Me.Text.StartsWith(Prog_Name) = True OrElse g_bCancelNav = True Then Exit For
                Wait(100)
            Next
            g_bCancelNav = False
            If i < 30 Then PageNoTitleWait = True

        Catch ex As Exception
            Msg("Page No Title Wait error: " & Err.Description)
        End Try
    End Function

    Private Sub StopNavigaion()
        If Me.browser IsNot Nothing Then
            g_bCancelNav = True
            Me.browser.GetBrowser.StopLoad()
        End If
    End Sub

    Public Function ValidateCertificate(sender As Object, certificate As Security.Cryptography.X509Certificates.X509Certificate, chain As Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean
        'Return True to force the certificate to be accepted.
        Return True
    End Function

    'Clear Web page
    Public Function ClearWebpage() As Boolean
        ClearWebpage = False
        Try
            OpenURL(URL_BLANK, True)
            ClearWebpage = True

        Catch ex As Exception
            Msg("Opening URL error: " & Err.Description)
        End Try
    End Function
#End Region

#Region "Messages / Errors"
    Private Sub addActivity(sMsg As String)
        Me.Invoke(Sub()
                      Me.txtMsg.AppendText("[" & Now.ToString("yyyy-MM-dd HH:mm:ss.f") & "] " & sMsg & vbNewLine)
                  End Sub)
    End Sub

    Public Sub Msg(sMsg As String)
        Try
            Me.txtMsg.AppendText("[" & Now.ToString("yyyy-MM-dd HH:mm:ss.f") & "] " & sMsg & vbNewLine)
            If Me.txtMsg.Visible = True Then
                Me.txtMsg.ScrollToCaret()
            End If

        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Sub
#End Region
End Class
