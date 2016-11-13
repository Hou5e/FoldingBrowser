Public Class Main
    Private WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser

    'Page loaded indicator
    Private m_bPageLoaded As Boolean = False
    'URL to help determine the page loaded indicator
    Private m_strPageURL As String = ""

#Region "Form and Browser Events - Initialization, Exiting"
    Public Sub New()
        InitializeComponent()

        Try
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
                If INI.AddSection(INI_Settings).AddKey(INI_ShowTheShowDatButton) IsNot Nothing Then
                    'Show/hide the 'Show Dat' file button
                    If INI.AddSection(INI_Settings).AddKey(INI_ShowTheShowDatButton).GetValue() = "True" Then
                        Me.btnShowDat.Visible = True
                    Else
                        Me.btnShowDat.Visible = False
                    End If
                End If

            Else
                'NOTE: closing the program will create most all of the other missing INI file settings

                'Create folder for user info, if it doesn't exist
                If System.IO.Directory.Exists(UserProfileDir) = False Then
                    My.Computer.FileSystem.CreateDirectory(UserProfileDir)
                End If
                INI.AddSection(Id & "0")
                INI.AddSection(Id & "1")
                INI.AddSection(Id & "2")
                INI.AddSection(Id & "3")
                INI.AddSection(Id & "4")
                INI.AddSection(Id & "5")
                INI.AddSection(Id & "6")
                INI.AddSection(Id & "7")
                INI.AddSection(Id & "8")
                INI.AddSection(Id & "9")
                INI.AddSection(INI_Settings)
                'Create a new INI for first time use. Set the default encryption PW
                INI.AddSection(INI_Settings).AddKey(INI_PW).Value = "(Default Password) If you change this line, remember to make backups. I can't restore it for you."
                'Store window size: {Left};{Top};{Width};{Height}
                INI.AddSection(INI_Settings).AddKey(INI_Size).Value = Me.Left.ToString() & ";" & Me.Top.ToString() & ";" & Me.Width.ToString() & ";" & Me.Height.ToString()
                'Show/hide the 'Show Dat' file button
                INI.AddSection(INI_Settings).AddKey(INI_ShowTheShowDatButton).Value = "True"
                INI.Save(IniFilePath)

                'Make the main form visible
                Me.WindowState = FormWindowState.Normal
            End If

            'Fix old settings, if needed, for upgrading versions
            If System.IO.File.Exists(DatFilePath) = True Then
                'Make sure the INI key/value exists
                If INI.GetSection(INI_Settings).GetKey(INI_LastBrowserVersion) IsNot Nothing Then

                    'If INI.GetSection(INI_Settings).GetKey(INI_LastBrowserVersion).Value <> My.Application.Info.Version.Major.ToString Then
                    '    'Fix old settings, if needed, for upgrading versions for v5 or higher: (none yet)
                    'End If

                Else
                    'Folding Browser v4 or older upgrade: 12-word PW needing to go to a new location
                    Dim DAT As New IniFile
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        g_Main.Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If

                    'Make sure the INI key/value exists
                    If DAT.GetSection("FLDC") IsNot Nothing AndAlso DAT.GetSection("FLDC").GetKey("012W") IsNot Nothing Then
                        'Save the old info to the new location and delete old info
                        DAT.AddSection(Id & Me.cbxWalletId.Text)
                        DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = DAT.GetSection("FLDC").GetKey("012W").GetValue
                        DAT.GetSection("FLDC").RemoveAllKeys()
                        DAT.RemoveSection("FLDC")
                        'Create text from the INI, Encrypt, and Write/flush DAT text to file
                        SaveDat(Encrypt(DAT.SaveToString))

                        'Show/hide the 'Show Dat' file button
                        INI.AddSection(INI_Settings).AddKey(INI_ShowTheShowDatButton).Value = "True"
                        'Save a wallet name
                        INI.AddSection(Id & Me.cbxWalletId.Text)
                        INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = "My Wallet"
                        INI.Save(IniFilePath)
                        Wait(100)
                    End If

                    DAT = Nothing
                End If
            End If

            'Refresh the Wallet Names
            cbxWalletId_SelectedIndexChanged(Nothing, Nothing)

            'Process command line values
            If Environment.CommandLine.Length > 0 Then
                'MessageBox.Show(Environment.CommandLine.ToString)
                Dim args As String() = Environment.GetCommandLineArgs()
                If args.Length > 1 Then
                    Select Case args(1)
                        'This command line option represents the FoldingBrowser was just installed
                        Case "-Instl"
                            'Create a dialog that sets the default selections based on stored wallet and F@H info
                            Dim Setup As New SetupDialog
                            'Show modal dialog box
                            If Setup.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                'Run the tasks the operator selected
                                If Setup.chkGetFAHSoftware.Checked = True Then
                                    'FAH Installation and Setup
                                    g_bAskDownloadLocation = False
                                    If GetFAH() = False Then MessageBox.Show("Task 'Get Folding@Home App' did not complete.")
                                End If

                                If Setup.chkGetWallet.Checked = True Then
                                    'Get Wallet
                                    If GetWallet() = False Then MessageBox.Show("Task 'Get Wallet' did not complete.")

                                    'TODO: Needs better ending condition (stored Wallet info, and got to Wallet page) before going on to the next step
                                End If

                                If Setup.chkGetFAHSoftware.Checked = True OrElse Setup.chkGetWallet.Checked = True Then
                                    btnFAHConfig_Click(Nothing, Nothing)
                                End If
                            End If
                    End Select
                End If
            End If

        Catch ex As Exception
            Msg("Error: initialization failed: " & ex.ToString)
        End Try
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
                If Prompt.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'Store FAH Username
                    INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_FAH_Username).Value = Prompt.TextEnteredUpper.Text
                    INI.Save(IniFilePath)
                    strUsername = Prompt.TextEnteredUpper.Text
                Else
                    OpenURL(URL_CURECOIN_EOC, False)
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
                OpenURL(URL_CURECOIN_EOC, False)
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
                If FindTextInHTML("/user_summary.php?s=&amp;u=*"">" & strUsername & "</a></td>", strUserId) = True AndAlso strUserId.Length > 1 AndAlso IsNumeric(strUserId) Then
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
                    Prompt.MsgTextLower.Text = "Please enter your ExtremeOverclocking.com Username Id:"
                    Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
                    Prompt.TextEnteredLower.Visible = False
                    'Show modal dialog box
                    If Prompt.ShowDialog() = Windows.Forms.DialogResult.OK AndAlso IsNumeric(Prompt.TextEnteredUpper.Text) Then
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
            OpenURL(URL_CURECOIN_EOC, False)
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

    Private Sub btnGetWallet_Click(sender As System.Object, e As System.EventArgs) Handles btnGetWallet.Click
        'TODO: only ask if no wallet info exists for this Wallet Id slot?


        If MessageBox.Show("Get Wallet: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            If GetWallet() = False Then MessageBox.Show("Task 'Get Wallet' did not complete.")
        End If
    End Sub

    Private Sub btnFAHConfig_Click(sender As System.Object, e As System.EventArgs) Handles btnFAHConfig.Click
        SetupFAHUserTeamAndCfg()
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
        'Change wallet name when text is changed and <enter> is presed
        If e.KeyCode = Keys.Enter Then
            If Me.txtWalletName.Text.Length > 0 Then
                'Save a wallet name
                INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = Me.txtWalletName.Text
                INI.Save(IniFilePath)
            End If
        End If
    End Sub

    Private Sub btnShowDat_Click(sender As Object, e As EventArgs) Handles btnShowDat.Click
        If System.IO.File.Exists(DatFilePath) = True Then
            Dim DAT As New IniFile
            'Load DAT file, decrypt it
            DAT.LoadText(Decrypt(LoadDat))
            If DAT.ToString.Length = 0 Then
                'Decryption failed
                g_Main.Msg(DAT_ErrorMsg)
                MessageBox.Show(DAT_ErrorMsg)
            End If

            'Show text
            Dim Dlg As New DisplayTextDialog
            Dlg.Text = "Saved Information"
            Dlg.MsgTextTop.Text = "Encrypted Dat File Contents:"
            Dlg.txtDisplayText.Text = DAT.SaveToString
            Dlg.txtDisplayText.Select(Dlg.txtDisplayText.Text.Length, 0)
            Dlg.btnSave.Enabled = False
            'Show modal dialog box
            If Dlg.ShowDialog() = Windows.Forms.DialogResult.Yes AndAlso Dlg.txtDisplayText.Text.Length > 10 Then
                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(Dlg.txtDisplayText.Text))
            End If
            DAT = Nothing
        End If
    End Sub
#End Region

#Region "Auto-Wallet Login"
    Private Function LoginToCounterwallet() As Boolean
        LoginToCounterwallet = False
        Try
            'CounterWallet web page 
            OpenURL(URL_Counterwallet, False)
            PageTitleWait("Counterwallet")
            Wait(700)

            'Make sure DAT file exists
            Dim bDatFile As Boolean = System.IO.File.Exists(DatFilePath)
            'If there is no DAT file, then prompt to make one
            If bDatFile = False Then
                'Prompt for PW, and save it
                Dim Prompt As New TextEntryDialog
                Prompt.Text = "Save Wallet Password"
                Prompt.MsgTextUpper.Text = "No saved wallet info yet."
                Prompt.MsgTextLower.Text = "Please enter your 12-word Passphrase:"
                Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
                Prompt.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Prompt.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'Save and encrypt 12-word Passphrase
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
                    If Prompt.TextEnteredUpper.Text.Length > 24 Then
                        DAT.AddSection(Id & Me.cbxWalletId.Text)
                        DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = Prompt.TextEnteredUpper.Text
                    End If

                    'Create text from the INI, Encrypt, and Write/flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))
                    DAT = Nothing

                    'Save a wallet name
                    INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = "My Wallet"
                    INI.Save(IniFilePath)

                    'Allow time for the file to be written out
                    Wait(100)
                End If
            End If

            'Login using the info from the Dat file
            If bDatFile = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    g_Main.Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If
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
            Msg("Auto Wallet error:" & ex.ToString)

            'User info decryption failed, most likely. Prompt for new info
            Dim Prompt As New TextEntryDialog
            Prompt.Text = "Save Wallet Password"
            Prompt.MsgTextUpper.Text = "Wallet info could not be decrypted."
            Prompt.MsgTextLower.Text = "Please enter your 12-word Passphrase:"
            Prompt.Width = (Prompt.MsgTextLower.Left * 2) + Prompt.MsgTextLower.Width + 10
            Prompt.TextEnteredLower.Visible = False
            'Show modal dialog box
            If Prompt.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Save and encrypt 12-word Passphrase
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
                If Prompt.TextEnteredUpper.Text.Length > 24 Then
                    DAT.AddSection(Id & Me.cbxWalletId.Text)
                    DAT.AddSection(Id & Me.cbxWalletId.Text).AddKey(DAT_CP12Words).Value = Prompt.TextEnteredUpper.Text
                End If

                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(DAT.SaveToString))
                DAT = Nothing

                'Save a wallet name
                INI.AddSection(Id & Me.cbxWalletId.Text).AddKey(INI_WalletName).Value = "My Wallet"
                INI.Save(IniFilePath)
            End If
        End Try
    End Function
#End Region

#Region "Automated Processes - One time only for setup"
    Private Function GetWallet() As Boolean
        GetWallet = False
        Try
            'Look to see if the wallet INI key/value exists, and warn user to change wallet info slots, or the info will be overwritten
            If INI.GetSection(Id & Me.cbxWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
                'Load the Wallet name from the INI file based on the Wallet Id#
                If MessageBox.Show("WARNING: Wallet Id #" & Me.cbxWalletId.Text & " info already exists!  Overwrite?" & vbNewLine & "(A different Wallet Id can be set in the 'Tools' section)", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) <> MsgBoxResult.Ok Then
                    Exit Function
                End If
            End If

            'CounterWallet web page 
            OpenURL(URL_Counterwallet, False)
            PageTitleWait("Counterwallet")
            Wait(700)

            'Click Create New CounterWallet
            ClickById("newWalletButton", False)

            'Save 12-word Passphrase and BTC address
            Dim str12W As String = ""
            Dim strBTCAddr As String = ""

            For i As Integer = 0 To 20
                If FindTextInHTML("generatedPassphrase"">*</span>", str12W) = True AndAlso str12W.Length > 24 Then
                    Exit For
                End If
                Wait(200)
            Next

            If str12W.Length > 24 Then
                'Click the "I've written it down" checkbox
                ClickByName("passphraseSaved", False)
                'Click Continue button
                ClickById("continueWalletCreation", False)
                Wait(100)

                'There are 3 buttons with this ID: finishWalletCreation. Use the class to get the ('btn btn-primary') 4th instance for the Create Wallet button:
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('btn btn-primary')[3].click();")
                Wait(100)

                'Click the 'X' close button.  Not working: click OK, the ('btn btn-primary') 9th instance for the OK button.
                Dim FileURL As String = ""
                ClickByClass("bootbox-close-button close", False, FileURL)

                'Reload the CounterWallet web page?
                'OpenURL(URL_Counterwallet, False)
                'PageTitleWait("Counterwallet")
                'Wait(700)

                'Enter 12-word Passphrase to login
                EnterTextById("password", str12W)
                'Trigger event to enable the Login button, since there was no keystroke event to enable the button
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("ko.utils.triggerEvent(document.getElementById('password'), 'input');")

                'Click Login button
                ClickById("walletLoginButton", True)
                Wait(1000)

                'First login, accept terms. ('btn btn-success') 2nd instance for the Accept button:
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('btn btn-success')[1].click();")

                'The logged into wallet web page has no title, but the previous page had a title
                PageNoTitleWait()

                For i As Integer = 1 To 40
                    If FindTextInHTML("selectAddressText, text: dispAddress"">*</span>", strBTCAddr) = True Then
                        If strBTCAddr.Length >= 26 AndAlso strBTCAddr.Length <= 35 AndAlso (strBTCAddr.StartsWith("1") = True OrElse strBTCAddr.StartsWith("3") = True) Then
                            Exit For
                        End If
                    End If
                    Wait(200)
                Next

                'Save and encrypt the 12 word Passphrase and the Bitcoin address
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
                Wait(100)

                'Refresh the Wallet Names
                cbxWalletId_SelectedIndexChanged(Nothing, Nothing)

                'Return true
                GetWallet = True

            Else
                str12W = "Error: 12 Word password not found while getting Wallet. Please try again."
                Msg(str12W)
                MessageBox.Show(str12W)
            End If

        Catch ex As Exception
            Msg("Get Wallet error:" & ex.ToString)
        End Try
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

            'Run FAH installer (stops any running instances and uninstalls previous version) and wait for it to finish
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
            If DialogFAH.ShowDialog() = Windows.Forms.DialogResult.OK Then
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
#End Region

#Region "Browser Commands"
    'Specify text box {Object Id}, and text to enter in to the textbox
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

    'Specify text box {Object Name}, and text to enter in to the textbox
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

    'Specify text to find in HTML
    Private Function FindTextInHTML(strFind As String, ByRef strReturnText As String) As Boolean
        FindTextInHTML = False
        Dim sHTML As String() = Nothing
        Dim sMask As String() = Nothing

        Try
            If strFind.Length > 0 Then
                sHTML = browser.GetBrowser.MainFrame.GetSourceAsync().Result.Split(vbNewLine.ToCharArray)
                If sHTML IsNot Nothing Then
                    'Search for wildcard (*) data or not
                    If strFind.Contains("*") = False Then
                        'No wildcard, just return the line of text that contains the search text
                        For Each sLineHTML As String In sHTML
                            If sLineHTML.Contains(strFind) = True Then
                                'Return the line of text that contains the search text
                                strReturnText = Trim(sLineHTML)
                                sHTML = Nothing
                                Return True
                            End If
                        Next
                    Else
                        'Create the mask to find the wildcard (*) data
                        sMask = strFind.Split("*".ToCharArray, 2)
                        For Each sLineHTML As String In sHTML
                            'Search through the HTML to find the first part
                            If sLineHTML.Contains(sMask(0)) = True Then
                                'Find the second part in the same line
                                If sLineHTML.Contains(sMask(1)) = True Then
                                    Dim iPos1 As Integer = sMask(0).Length + sLineHTML.IndexOf(sMask(0))
                                    Dim iPos2 As Integer = sLineHTML.IndexOf(sMask(1))
                                    If iPos1 < iPos2 Then
                                        strReturnText = Trim(sLineHTML.Substring(iPos1, iPos2 - iPos1))
                                        sHTML = Nothing
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
