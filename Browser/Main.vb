Public Class Main
    Private WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser

    'Page loaded indicator
    Private m_bPageLoaded As Boolean = False
    Private m_bHomepage_TopAnBottomLoaded As Boolean = False
    Private m_bHomepage_SideBySideLoaded As Boolean = False
    'URL to help determine the page loaded indicator
    Private m_strPageURL As String = ""
    'Web Link Button Panel
    Private m_iMinPanelHeight As Integer = 8
    Private m_iNormPanelHeight As Integer = 260
    Private m_iMaxPanelHeight As Integer = 360
    Private m_iTempHeight As Integer = 20
    Private m_iTargetExpandedPanelHeight As Integer = 8
    'DPI for Scaling
    Private g_iOldDPI As Integer = 0
    Private g_iCurrentDPI As Integer = 0
    Private g_dScaleDPI As Double = 1.0
    Private Const i16 As Integer = 16
    Private Const i24 As Integer = 24
    Private Const i48 As Integer = 48

#Region "Form and Browser Events - Initialization, Exiting"
    Public Sub New()
        Try
            InitializeComponent()

            Dim settings As New CefSharp.WinForms.CefSettings()
            'Set the Cache path to the user's appdata roaming folder
            settings.CachePath = System.IO.Path.Combine(UserProfileDir, "Cache")
            settings.UserDataPath = settings.CachePath
            settings.LogFile = System.IO.Path.Combine(settings.CachePath, "debug.log")
            settings.LocalesDirPath = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "locales")
            settings.Locale = "en-US"
            settings.AcceptLanguageList = settings.Locale & "," & settings.Locale.Substring(0, 2)

            'For Debugging, to log everything, use: Verbose. Can cause Cef.Shutdown() to hang.
            'settings.LogSeverity = CefSharp.LogSeverity.Verbose
            settings.LogSeverity = CefSharp.LogSeverity.Info

            Try
                'The log file gets appended to each time, so delete it (or else it can get large over time)
                If System.IO.File.Exists(settings.LogFile) = True Then
                    System.IO.File.Delete(settings.LogFile)
                    Threading.Thread.Sleep(50)
                End If
            Catch ex As Exception
                Msg("Error: deleting temp file " & settings.LogFile & ": " & ex.ToString)
            End Try

            'Load the INI data before loading the Homepage (which is based on the user's options in the INI file). Fix the INI file, if needed
            LoadINISettings()

            CefSharp.Cef.EnableHighDPISupport()
            If CefSharp.Cef.Initialize(settings) = True Then
                Me.browser = New CefSharp.WinForms.ChromiumWebBrowser(URL_BLANK)
                'Add browser event handlers to pass events back to the main UI
                AddHandler Me.browser.FrameLoadEnd, AddressOf OnBrowserFrameLoadEnd
                AddHandler Me.browser.ConsoleMessage, AddressOf OnBrowserConsoleMessage
                AddHandler Me.browser.StatusMessage, AddressOf OnBrowserStatusMessage
                AddHandler Me.browser.LoadingStateChanged, AddressOf OnBrowserLoadingStateChanged
                AddHandler Me.browser.TitleChanged, AddressOf OnBrowserTitleChanged
                AddHandler Me.browser.AddressChanged, AddressOf OnBrowserAddressChanged
                'Add keypress handler: ESC to cancel Navigation, F5 to Refresh, CTRL+F for Find, ...
                Me.browser.KeyboardHandler = New KeyboardHandler()
                'Add download handler
                Me.browser.DownloadHandler = New DownloadHandler()
                'Add to a UI container
                Me.ToolStripContainer1.ContentPanel.Controls.Add(browser)

                'Default homepage / portal set to the FoldingCoin webpage
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
                'Load the Homepage based on the user's options in the INI file (call after loading the INI settings)
                LoadHomepage()
#Enable Warning BC42358
            End If

            'Global reference to this form
            g_Main = Me

            'Setup the rest of the window
            Me.Icon = My.Resources.L_cysteine_16_24_32_48_256
            Me.Text = Prog_Name & " v" & My.Application.Info.Version.Major.ToString

            Dim g As Graphics = Me.CreateGraphics()
            Try
                g_iCurrentDPI = CInt(g.DpiX)
                g_iOldDPI = g_iCurrentDPI
                g_dScaleDPI = g_iCurrentDPI / 96
            Finally
                g.Dispose()
            End Try

            'Setup Browser buttons
            Me.btnBack.Text = ""
            Me.btnBack.Image = GetResizedImage(My.Resources.TB_Back_96, CInt(i24 * g_dScaleDPI))
            Me.btnFwd.Text = ""
            Me.btnFwd.Image = GetResizedImage(My.Resources.TB_Fwd_96, CInt(i24 * g_dScaleDPI))
            Me.btnGo.Text = ""
            Me.btnGo.Image = GetResizedImage(My.Resources.TB_Go_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnStopNav.Text = ""
            Me.btnStopNav.Image = GetResizedImage(My.Resources.TB_Stop_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnReload.Text = ""
            Me.btnReload.Image = GetResizedImage(My.Resources.TB_Reload_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnHome.Text = ""
            Me.btnHome.Image = GetResizedImage(My.Resources.TB_Home_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.chkToolsShow.Text = ""
            Me.chkToolsShow.Image = GetResizedImage(My.Resources.TB_ToolsSettingsGearNoBG_96, CInt(i24 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)

            'Find/Search buttons
            Me.btnFindPrevious.Text = ""
            Me.btnFindPrevious.Image = GetResizedImage(My.Resources.TB_FindUp_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnFindNext.Text = ""
            Me.btnFindNext.Image = GetResizedImage(My.Resources.TB_FindDown_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnFindClose.Text = ""
            Me.btnFindClose.Image = GetResizedImage(My.Resources.TB_Stop_64, CInt(i16 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)

            'Web Link Button Images. Folding@Home Related:
            Me.btnFAHWebControl.BackgroundImage = GetResizedImage(My.Resources.L_methionine_B_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnFAHTwitter.BackgroundImage = GetResizedImage(My.Resources.Twitter_192, CInt(i48 * g_dScaleDPI))
            Me.btnFAHNews.BackgroundImage = GetResizedImage(My.Resources.News_192, CInt(i48 * g_dScaleDPI))
            Me.btnEOC_UserStats.BackgroundImage = GetResizedImage(My.Resources.EOC_192, CInt(i48 * g_dScaleDPI))
            Me.btnFoldingCoinUserStats.BackgroundImage = GetResizedImage(My.Resources.FLDC_192, CInt(i48 * g_dScaleDPI))
            'FoldingCoin Related:
            Me.btnFoldingCoinWebsite.BackgroundImage = GetResizedImage(My.Resources.FoldingCoin_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnMyWallet.BackgroundImage = GetResizedImage(My.Resources.Coins_192, CInt(i48 * g_dScaleDPI))
            Me.btnFoldingCoinTwitter.BackgroundImage = GetResizedImage(My.Resources.Twitter_192, CInt(i48 * g_dScaleDPI))
            Me.btnFoldingCoinDiscord.BackgroundImage = GetResizedImage(My.Resources.Discord_192, CInt(i48 * g_dScaleDPI))
            Me.btnFoldingCoinBlockchain.BackgroundImage = GetResizedImage(My.Resources.BlockchainFLDC_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnBTCBlockchain.BackgroundImage = GetResizedImage(My.Resources.BlockchainBTC_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnFoldingCoinDistribution.BackgroundImage = GetResizedImage(My.Resources.DistributionFLDC_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnFoldingCoinShop.BackgroundImage = GetResizedImage(My.Resources.FLDC_Shop_Mug_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnFoldingCoinTeamStats.BackgroundImage = GetResizedImage(My.Resources.FLDC_192, CInt(i48 * g_dScaleDPI))
            'CureCoin Related:
            Me.btnCureCoinWebsite.BackgroundImage = GetResizedImage(My.Resources.CureCoin_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnCureCoinTwitter.BackgroundImage = GetResizedImage(My.Resources.Twitter_192, CInt(i48 * g_dScaleDPI))
            Me.btnCureCoinDiscord.BackgroundImage = GetResizedImage(My.Resources.Discord_192, CInt(i48 * g_dScaleDPI))
            Me.btnCureCoinBlockchain.BackgroundImage = GetResizedImage(My.Resources.BlockchainCURE_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnCurePool.BackgroundImage = GetResizedImage(My.Resources.DistributionCURE_192, CInt(i48 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Me.btnCureCoinTeamStats.BackgroundImage = GetResizedImage(My.Resources.EOC_192, CInt(i48 * g_dScaleDPI))

            'Protein image for decoration / branding in the browser
            Me.pbProgIcon.Width = CInt(i48 * g_dScaleDPI) + 2
            Me.pbProgIcon.Height = Me.pbProgIcon.Width
            Me.pbProgIcon.Left = Me.pnlBtnLinksDividerTop.Width - Me.pbProgIcon.Width
            Me.pbProgIcon.Image = GetResizedImage(New Icon(My.Resources.L_cysteine_16_24_32_48_256, 256, 256).ToBitmap, (Me.pbProgIcon.Width - 2), Drawing2D.InterpolationMode.HighQualityBicubic)

            'Calculate the web link button panel heights (shown vs minimized)
            m_iNormPanelHeight = Me.pnlBtnLinksDividerBottom.Top - 3  '260px @ 96dpi
            m_iTargetExpandedPanelHeight = m_iNormPanelHeight  'Initially set the expanded target size to the normal height (not showing 'Tools' at the bottom of it)
            m_iMaxPanelHeight = Me.txtMsg.Top + Me.txtMsg.Height + 5  '360px @ 96dpi
            m_iMinPanelHeight = (SystemInformation.BorderSize.Height * 2) + (Me.pnlBtnLinksDividerTop.Top * 2) + Me.pnlBtnLinksDividerTop.Height  '8px @ 96dpi
            'Button Link Panel: Initially show minimized
            Me.pnlBtnLinks.Height = m_iMinPanelHeight

            'Resize the toolbar and browser window. On Win10 at 175%, the right anchors weren't resizing to the window size
            Me.pnlURL.Width = Me.ClientSize.Width
            Me.ToolStripContainer1.Width = Me.ClientSize.Width + (SystemInformation.BorderSize.Width * 2)
            'Set other important positions that Windows might not adjust correctly
            Me.pnlBtnLinks.Left = Me.txtURL.Left
            Me.pnlBtnLinks.Width = Me.txtURL.Width
            Me.gbxDownload.Left = Me.btnGo.Left - Me.gbxDownload.Width - 2
            Me.pnlFind.Left = Me.chkToolsShow.Left - Me.pnlFind.Width - 2
            'Resize the single-line textbox, otherwise the hight doesn't grow correctly, like on Win10 at 175%.
            Me.txtURL.AutoSize = False
            Me.txtURL.Height = Me.pnlBtnLinks.Top - Me.pnlURL.Top - Me.txtURL.Top - (SystemInformation.BorderSize.Width * 2)

            'Hide the form while it's being adjusted
            Me.WindowState = FormWindowState.Minimized
            'Create the main form (Needs to come before restoring the window size and window state)
            Me.Show()

            'Restore window size
            If INI.GetSection(INI_Settings).GetKey(INI_Size) IsNot Nothing Then
                'Restore dimensions from string: {Left};{Top};{Width};{Height}
                Dim strDim As String() = INI.GetSection(INI_Settings).GetKey(INI_Size).GetValue().Split(";"c)
                Me.Left = CInt(strDim(0))
                Me.Top = CInt(strDim(1))
                Me.Width = CInt(strDim(2))
                Me.Height = CInt(strDim(3))
            End If

            'Restore window state
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

            'Restore Option for the Panel MouseEnter event
            If INI.GetSection(INI_Settings).GetKey(INI_ShowPanelOnMouseEnter) IsNot Nothing Then
                g_bShowWebLinkPanelOnMouseEnterEvent = CBool(INI.GetSection(INI_Settings).GetKey(INI_ShowPanelOnMouseEnter).GetValue())
            End If

            'Force the URL text to scroll all the way to the left
            Me.txtURL.Select(0, 0)

            'Process command line values (Only for initial installations). Log browser debug info. NOTE: Async and can't be awaited here.
            RunSetup()

        Catch ex As Exception
            Msg("Error: initialization failed: " & ex.ToString)
            MessageBox.Show("Error: initialization failed: " & ex.ToString)
        End Try
    End Sub

    Private Function GetResizedImage(imgInput As Image, ByRef iOutputDim As Integer, ByRef Optional enImgResizeMode As Drawing2D.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor) As Image
        Dim imgResized As Image = New Bitmap(iOutputDim, iOutputDim)
        Dim g As Graphics = Graphics.FromImage(imgResized)
        g.InterpolationMode = enImgResizeMode
        g.DrawImage(imgInput, New Rectangle(0, 0, iOutputDim, iOutputDim))
        imgInput.Dispose()
        GetResizedImage = imgResized
    End Function

    Private Async Sub LoadINISettings()
        'Load, fix, or update the INI and DAT files for the stored settings. Look to see if there is an INI file first
        If System.IO.File.Exists(IniFilePath) = True Then
            INI.Load(IniFilePath)

            'Make sure the INI key/value exists
            If INI.GetSection(INI_Settings).GetKey(INI_LastWalletId) IsNot Nothing Then
                'Restore last Wallet Id used
                Me.cbxToolsWalletId.Text = INI.GetSection(INI_Settings).GetKey(INI_LastWalletId).GetValue()
            End If

            'Make sure the INI key/value exists
            If INI.GetSection(INI_Settings).GetKey(INI_HideSavedDataButton) IsNot Nothing Then
                'Show/hide the 'Show Dat' file button
                If INI.GetSection(INI_Settings).GetKey(INI_HideSavedDataButton).GetValue() = "False" Then
                    Me.btnToolsSavedData.Visible = True
                ElseIf INI.GetSection(INI_Settings).GetKey(INI_HideSavedDataButton).GetValue() = "True" Then
                    Me.btnToolsSavedData.Visible = False
                Else
                    'Restore value, if missing
                    INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton).Value = "False"
                    Me.btnToolsSavedData.Visible = True
                End If
            Else
                'Restore value, if missing
                INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton).Value = "False"
                Me.btnToolsSavedData.Visible = True
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
            'Allow time for the file to be written out
            Await Wait(100)
            DAT = Nothing

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
                    DAT.AddSection(Id & Me.cbxToolsWalletId.Text)
                    DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CP12Words).Value = DAT.GetSection(OldSection).GetKey(Old012W).GetValue
                    DAT.GetSection(OldSection).RemoveAllKeys()
                    DAT.RemoveSection(OldSection)
                    'Create text from the INI, Encrypt, and Write/flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))
                    'Allow time for the file to be written out
                    Await Wait(100)

                    'Save a wallet name
                    INI.AddSection(Id & Me.cbxToolsWalletId.Text)
                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_WalletName).Value = DefaultWalletName & Me.cbxToolsWalletId.Text
                    'Last FoldingBrowser version, now upgraded to v5
                    INI.AddSection(INI_Settings).AddKey(INI_LastBrowserVersion).Value = "5"
                    INI.Save(IniFilePath)
                    'Allow time for the file to be written out
                    Await Wait(100)
                End If

                DAT = Nothing
            End If

            Dim iBrowserVersion As Integer = CInt(INI.GetSection(INI_Settings).GetKey(INI_LastBrowserVersion).Value)
            If iBrowserVersion <> My.Application.Info.Version.Major Then
                'Fix old settings, if needed, for upgrading versions for v5 or higher:
                If iBrowserVersion = 5 Then
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
                    'Allow time for the file to be written out
                    Await Wait(100)
                    DAT = Nothing

                    Const OldShowTheShowDatButton As String = "ShowTheShowDatButton"
                    'Renamed the 'Show Dat' file button to 'Saved Data'
                    INI.AddSection(INI_Settings).AddKey(INI_HideSavedDataButton).Value = "False"
                    INI.GetSection(INI_Settings).RemoveKey(OldShowTheShowDatButton)
                    'Last FoldingBrowser version, now upgraded to v6
                    INI.AddSection(INI_Settings).AddKey(INI_LastBrowserVersion).Value = "6"
                    INI.Save(IniFilePath)
                    'Allow time for the file to be written out
                    Await Wait(100)
                End If

                If iBrowserVersion <= 19 Then
                    'FoldingBrowser v19 or older: Upgrade / remove unused informational CureCoin wallet version used during the sign-up process to avoid any confusion after upgrading wallet versions
                    Dim DAT As New IniFile
                    'Load DAT file, decrypt it
                    DAT.LoadText(Decrypt(LoadDat))
                    If DAT.ToString.Length = 0 Then
                        'Decryption failed
                        Msg(DAT_ErrorMsg)
                        MessageBox.Show(DAT_ErrorMsg)
                    End If

                    Const Old_CureCoin_Wallet_Version As String = "CureCoinWalletVersion"
                    'Fix the 10 wallet slot sections
                    Dim i As Integer = 0
                    For i = 0 To 9
                        'Make sure the INI key/value exists
                        If DAT.GetSection(Id & i.ToString) IsNot Nothing AndAlso DAT.GetSection(Id & i.ToString).GetKey(Old_CureCoin_Wallet_Version) IsNot Nothing Then
                            'Delete old info
                            DAT.GetSection(Id & i.ToString).RemoveKey(Old_CureCoin_Wallet_Version)
                        End If
                    Next

                    'Create text from the INI, Encrypt, and Write/flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))
                    'Allow time for the file to be written out
                    Await Wait(100)
                    DAT = Nothing
                End If

                'Next DAT format version upgrade would go here
            End If
        Else
            'No Dat file, then start a new one
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
            'Allow time for the file to be written out
            Await Wait(100)
            DAT = Nothing
        End If
        'Refresh the Wallet Names
        cbxToolsWalletId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    'This was done because the New() constructor can't be run as Async. So, this was moved out to here
    Private Async Sub RunSetup()
        'For debugging issues: Log version info
        Dim sbMsg As New System.Text.StringBuilder
        sbMsg.Append(vbNewLine & DividerLine & vbNewLine & "Chromium Version: " & CefSharp.Cef.ChromiumVersion.ToString & vbNewLine &
            "Cef Version: " & CefSharp.Cef.CefVersion.ToString & vbNewLine &
            "CefSharp Version: " & CefSharp.Cef.CefSharpVersion.ToString)
        Dim plugins As List(Of CefSharp.WebPluginInfo) = Await CefSharp.Cef.GetPlugins
        For Each plugin As CefSharp.WebPluginInfo In plugins
            sbMsg.Append(vbNewLine & DividerLine & vbNewLine &
                "Plugin: " & plugin.Name & If(plugin.Version.Length > 0, " v" & plugin.Version, "") &
                If(plugin.Description.Length > 0, vbNewLine & "Plugin Description: " & plugin.Description, "") &
                If(plugin.Path.Length > 0, vbNewLine & "Plugin Path: " & plugin.Path, ""))
        Next
        Msg(sbMsg.ToString & vbNewLine & DividerLine)

        '''''''''''''''''''''
        'Process command line values (Only for initial installations).
        If Environment.CommandLine.Length > 0 Then
            'MessageBox.Show(Environment.CommandLine.ToString)
            Dim args As String() = Environment.GetCommandLineArgs()
            If args.Length > 1 Then
                Select Case args(1)
                        'This command line option represents the FoldingBrowser was just installed
                    Case "-Instl", "-InstWithCure"
                        'Create a dialog that sets the default checkbox selections based on stored wallet and F@H info.
                        Dim Setup As New SetupDialog

                        Dim DAT As New IniFile
                        'Load DAT file, decrypt it
                        DAT.LoadText(Decrypt(LoadDat))
                        If DAT.ToString.Length = 0 Then
                            'Decryption failed
                            Msg(DAT_ErrorMsg)
                            MessageBox.Show(DAT_ErrorMsg)
                        End If

                        'Look for FAH username for FAH installation to un-check the dialog for existing users
                        Try
                            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                                'Has FAH setup already
                                Setup.chkGetFAHSoftware.Checked = False
                            Else

                                'Additionally look for FAH installation on PC
                                If System.IO.File.Exists("C:\Program Files (x86)\FAHClient\FAHClient.exe") = True OrElse System.IO.File.Exists("C:\Program Files\FAHClient\FAHClient.exe") = True Then
                                    'Has FAH setup already
                                    Setup.chkGetFAHSoftware.Checked = False
                                Else
                                    'Needs FAH
                                    Setup.chkGetFAHSoftware.Checked = True
                                End If
                            End If
                        Catch
                            Setup.chkGetFAHSoftware.Checked = True
                        End Try

                        'Look for 12-word Passphrase (or BTC address?) to un-check the dialog for existing users
                        Try
                            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CP12Words) IsNot Nothing Then
                                'Wallet info exists
                                Setup.chkGetWalletForFLDC.Checked = False
                            Else
                                'No saved Wallet info
                                Setup.chkGetWalletForFLDC.Checked = True

                                'TODO: Ask for existing 12-word PW CounterParty wallet info? (probably too confusing / too many options)
                            End If
                        Catch
                            Setup.chkGetWalletForFLDC.Checked = True
                        End Try

                        'Done with the DAT file
                        DAT = Nothing

                        'If installing the CureCoin wallet, set this check box to setup the CureCoin pool info
                        If args(1) = "-InstWithCure" Then
                            Setup.chkSetupCURE.Checked = True
                        Else
                            Setup.chkSetupCURE.Checked = False
                        End If

                        'Show modal dialog box
                        If Setup.ShowDialog(Me) = DialogResult.OK Then
                            'Run the tasks the operator selected

                            'FAH adavanced client installation
                            If Setup.chkGetFAHSoftware.Checked = True Then
                                g_bAskDownloadLocation = False
                                If Await GetFAH() = False Then
                                    MessageBox.Show("Task 'Get Folding@Home App' did not complete." & vbNewLine & "Please use the buttons in the 'Tools' checkbox")
                                    Exit Sub
                                End If
                            End If

                            'Get Wallet
                            If Setup.chkGetWalletForFLDC.Checked = True Then
                                If Await GetWallet() = False Then
                                    MessageBox.Show("Task 'Get Wallet' did not complete." & vbNewLine & "Please use the buttons in the 'Tools' checkbox")
                                    Exit Sub
                                End If
                            End If

                            'FAH Username / Teamname settings setup
                            If Setup.chkGetFAHSoftware.Checked = True OrElse Setup.chkGetWalletForFLDC.Checked = True Then
                                Dim DialogFAH As New FAHSetupDialog
                                Try
                                    'Prompt for FAH info: Ask for: (existing) Username, Merged Folding Coin Selection, FAH Team #. Show Username as typing and check it for errors. (Optional) Get Passkey by email. Show before and after of the FAH Config file changes 
                                    DialogFAH.m_bInitialInstall = True
                                    'Show modal dialog box
                                    DialogFAH.ShowDialog(Me)

                                Catch ex As Exception
                                    Msg("Setup FAH User, Team, and Config error:" & ex.ToString)
                                End Try
                                DialogFAH.Dispose()
                            End If

                            'Only do this step if the CureCoin wallet.dat file wasn't found on the PC during the initial installation, or if the user chooses this option
                            If Setup.chkSetupCURE.Checked = True Then
                                Await SetupCureCoin()
                            End If

                            'Show DAT file saved info. Ask to make backups / store data in a safe place
                            If Setup.chkGetFAHSoftware.Checked = True OrElse Setup.chkGetWalletForFLDC.Checked = True OrElse Setup.chkSetupCURE.Checked = True Then
                                Dim DlgDisplaySavedData As New DisplayTextDialog
                                DlgDisplaySavedData.StartPosition = FormStartPosition.CenterScreen
                                'Show the Saved Data dialog
                                DlgDisplaySavedData.Show(Me)
                                Delay(100)
                            End If
                        End If

                        'Automated process finished - Make a backup reminder, other informational messages
                        Dim FinMsg As New MsgBoxDialog
                        FinMsg.Text = "Setup Finished"
                        FinMsg.MsgText.Text = "Setup Finished:" & vbNewLine &
                            DividerLine & vbNewLine & vbNewLine &
                            "-Please use: Tools | Saved Data | 'Make Backup' button to backup your settings" & vbNewLine & vbNewLine &
                            "-Note Distribution Intervals: " & vbNewLine &
                            "     FoldingCoin: On the 1st Saturday of each month" & vbNewLine &
                            "         CureCoin: Daily.     Also, Proof of Stake (POS) when coins are" & vbNewLine &
                            "            over 4 days old, with wallet unlocked and left running." & vbNewLine & vbNewLine &
                            "-Please contact us on Discord for questions (Use FoldingBrowser Discord buttons)"
                        FinMsg.Width = (FinMsg.MsgText.Left * 2) + FinMsg.MsgText.Width + 10
                        FinMsg.Height = (FinMsg.MsgText.Top * 2) + FinMsg.MsgText.Height + FinMsg.btnOK.Height + System.Windows.Forms.SystemInformation.CaptionHeight + System.Windows.Forms.SystemInformation.BorderSize.Height + 30
                        FinMsg.StartPosition = FormStartPosition.CenterScreen
                        FinMsg.ShowDialog(Me)
                        FinMsg.Dispose()

                        'Cleanup
                        Setup.Dispose()
                End Select
            End If
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        g_bCancelNav = True
        Try
            'Last Wallet Id used
            INI.AddSection(INI_Settings).AddKey(INI_LastWalletId).Value = Me.cbxToolsWalletId.Text
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
        Catch ex As Exception
            Msg("Error: Saving INI file settings on exiting: " & ex.ToString)
        End Try

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

        Try
            'Save any log messages from the screen to a text file. This may make it easier for users to report issues
            If Me.txtMsg.Text.Length > 0 Then
                SaveLogFile(Me.txtMsg.Text)
            End If
        Catch ex As Exception
            Msg("Error: Saving log file: " & ex.ToString)
        End Try

        Try
            'Keep this before CefSharp.Cef.Shutdown() to avoid the browser hanging (CefSharp v53.0.1): when exiting the wallet & click yes, then close the Browser (like the javascript running causes the hang)
            'StopNavigaion()  'In v55, this appears to cause: Exception thrown: 'System.Exception' in CefSharp.dll
            g_bCancelNav = True
            ClearWebpage()
            'Added in v63.0.3. Exiting the FAH Web control was hanging the Cef.Shutdown(). On shutdown, the FAH Web control error was happening, and reloading w/o cache when closing. 'Verbose' debug logging was getting cutoff too, and changing logging to 'info' helped fix it
            g_bCancelNav = True
            Delay(150)

            If Me.browser IsNot Nothing Then
                RemoveHandler Me.browser.FrameLoadEnd, AddressOf OnBrowserFrameLoadEnd
                RemoveHandler Me.browser.ConsoleMessage, AddressOf OnBrowserConsoleMessage
                RemoveHandler Me.browser.StatusMessage, AddressOf OnBrowserStatusMessage
                RemoveHandler Me.browser.LoadingStateChanged, AddressOf OnBrowserLoadingStateChanged
                RemoveHandler Me.browser.TitleChanged, AddressOf OnBrowserTitleChanged
                RemoveHandler Me.browser.AddressChanged, AddressOf OnBrowserAddressChanged
                Me.browser.KeyboardHandler = Nothing
                Me.browser.DownloadHandler = Nothing

                'Shutdown the web browser control
                If Me.browser.IsDisposed = False Then
                    'This is prone to hanging the app when exiting:
                    CefSharp.Cef.Shutdown()
                    'Wait for CefSharp.Cef.Shutdown(): This 100ms delay seems to help prevent the messed up state for older (and current) CefSharp versions. Otherwise, the cache needs to be deleted for the FAH Control web page to work (at least with CEF1, v25)
                    Delay(100)
                End If
            End If

        Catch ex As Exception
            Msg("Error: Exiting: " & ex.ToString)
        End Try

        g_bCancelNav = True
    End Sub
#End Region

#Region "Button, Checkbox, Combobox - Form Control Events"
    Private Async Sub btnFAHWebControl_Click(sender As System.Object, e As System.EventArgs) Handles btnFAHWebControl.Click
        'Check to see if FAH is running, and if not then pop-up a message to indicate that
        Dim bFAHRunning As Boolean = False
        Dim bFAH_PageLoaded As Boolean = False
        Dim proc As Process
        Try
            For Each proc In Process.GetProcessesByName(FAH_Client)
                bFAHRunning = True
                'If you get here, exit searching through the processes
                Exit For
            Next

            If bFAHRunning = False Then
                'Indicate FAH is not running
                MessageBox.Show("Folding@Home is not running." & vbNewLine & "Please start the Folding@Home software, and try again.", "Folding@Home is not running", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            Msg("Error checking if FAH is running: " & ex.ToString)
        End Try

        'WORKAROUND: The FAH Web Control doesn't always load during the 30 second count down. So, try bypassing it for now. The URL to load without cache doesn't avoiding the other CORS infinite loop error (Refresh without cache still needed)
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        Dim r As Random = New Random
        OpenURL(URL_FAH_WebClient_IPAddr & r.NextDouble.ToString(), False)
#Enable Warning BC42358

        'This waits 3 seconds each time, to see if it's going to load quickly. Wait up to 15 seconds total for the page to load
        Dim i As Integer = 0
        Do Until bFAH_PageLoaded = True OrElse g_bCancelNav = True OrElse i >= 4
            i += 1
            If Await PageTitleWait(FAH_Version) = True Then bFAH_PageLoaded = True
        Loop

        'If the user presses a different button to go to a different web page, then don't load the default FAH Web Control URL (can happen easily over the 15 second period, if FAH isn't running)
        If bFAH_PageLoaded = False AndAlso (Me.txtURL.Text.StartsWith(URL_FAH_WebClient_IPAddr) = True OrElse Me.txtURL.Text = URL_FAH_WebClient_URL) Then
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            'If the IP Address version of the page doesn't load, go back to the main URL that has the annoyingly slow 30 countdown page before loading the FAH Web Control
            OpenURL(URL_FAH_WebClient_URL, False)
#Enable Warning BC42358

            If bFAHRunning = True Then
                'If FAH is running, then give it a chance for the page to load
                i = 0
                Do Until bFAH_PageLoaded = True OrElse g_bCancelNav = True OrElse i >= 4
                    i += 1
                    If Await PageTitleWait(FAH_Version) = True Then bFAH_PageLoaded = True
                Loop

                'If the user presses a different button to go to a different web page, then don't reload the default FAH Web Control URL (can happen easily over the 15 second period, if FAH isn't running)
                If bFAH_PageLoaded = False AndAlso (Me.txtURL.Text.StartsWith(URL_FAH_WebClient_IPAddr) = True OrElse Me.txtURL.Text = URL_FAH_WebClient_URL) Then
                    'If still not loaded, try a Refresh ignoring browser cache
                    Me.browser.GetBrowser.Reload(True)
                End If
            End If
        End If
    End Sub

    Private Sub btnFAHTwitter_Click(sender As System.Object, e As System.EventArgs) Handles btnFAHTwitter.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FAHTwitter, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnFAHNews_Click(sender As Object, e As EventArgs) Handles btnFAHNews.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FAH & URL_FAH_News, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnFoldingCoinUserStats_Click(sender As Object, e As EventArgs) Handles btnFoldingCoinUserStats.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        Dim strUsername As String = ""
        Dim DAT As New IniFile
        'Load DAT file, decrypt it
        DAT.LoadText(Decrypt(LoadDat))
        If DAT.ToString.Length = 0 Then
            'Decryption failed
            Msg(DAT_ErrorMsg)
            MessageBox.Show(DAT_ErrorMsg)
        End If

        'Look for FAH username for FAH installation to un-check the dialog for existing users
        If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
            strUsername = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
        End If
        'Done with the DAT file
        DAT = Nothing

        'Make sure the Username is FoldingCoin compatible, otherwise just display the main Stats page
        If strUsername.Length > 0 AndAlso strUsername.Contains("_") = True Then
            'Normal: Load User's Stats
            OpenURL(URL_FoldingCoinStats & URL_FoldingCoinStatsUser & strUsername, False)
        Else
            'Not a vailid FLDC username. Just go to the main FLDC Stats page
            OpenURL(URL_FoldingCoinStats, False)
        End If
#Enable Warning BC42358
    End Sub

    'Extreme Overclocking's User Stats page: Needs to know user ID # ...  Once known, store the info in the INI file
    Private Async Sub btnEOC_UserStats_Click(sender As System.Object, e As System.EventArgs) Handles btnEOC_UserStats.Click
        Dim strUserId As String = "0"
        Dim iUserId As Integer = 0
        Dim strUsername As String = ""

        Try
            'Get EOC Username ID from INI
            If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_EOC_ID) IsNot Nothing Then
                strUserId = INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_EOC_ID).Value
            Else
                'Fix missing value. Add temp ExtremeOverclocking.com Username Id
                INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_EOC_ID).Value = "0"
                INI.Save(IniFilePath)
            End If

            If strUserId.Length >= 1 AndAlso IsNumeric(strUserId) = True Then
                iUserId = CInt(strUserId)
            Else
                'Fix bad values
                INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_EOC_ID).Value = "0"
                INI.Save(IniFilePath)
            End If

        Catch ex As Exception
            Msg("Error: Loading Extreme Overclocking settings: " & ex.ToString)
        End Try

        Try
            'No UserId, but if you have the FAH Username stored, then go look up the Id on EOC (the 3 attempts is for new users who's username won't be searchable for the first ~24 hours: Hopefully this will let them retry some other day)
            If iUserId < 4 Then
                'Just load the CureCoin stats for something to look at
                Await OpenURL(URL_CureCoin_EOC, False)
                Await PageTitleWait("Curecoin")
                Await Wait(100)

                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If

                'Look for FAH username for FAH installation to un-check the dialog for existing users
                If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                    strUsername = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
                Else
                    'Fix missing value. Ask for FAH Username
                    Dim TxtEntry As New TextEntryDialog
                    TxtEntry.Text = "Save Folding@Home Username"
                    TxtEntry.MsgTextUpper.Text = "Folding@Home Username not found."
                    TxtEntry.MsgTextLower.Text = "Please enter your Folding@Home Username:"
                    TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                    TxtEntry.TextEnteredLower.Visible = False
                    TxtEntry.MsgTextExtraBottomNote.Visible = False
                    'Show modal dialog box
                    If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                        'Store FAH Username
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_FAH_Username).Value = TxtEntry.TextEnteredUpper.Text
                        'Create text from the INI, Encrypt, and Write/Flush DAT text to file
                        SaveDat(Encrypt(DAT.SaveToString))
                        'Allow time for the file to be written out
                        Await Wait(100)
                        strUsername = TxtEntry.TextEnteredUpper.Text
                    End If
                    TxtEntry.Dispose()
                End If

                'Done with the DAT file
                DAT = Nothing

                'Skip the address lookup after 3 attempts. The user will have to save the info in the saved settings to fix it.
                If iUserId < 3 AndAlso strUsername.Length > 0 Then
                    'Enter FAH Username in the Search TextBox
                    EnterTextByName("searchbox", 0, strUsername)
                    Await Wait(100)

                    'Click the search button. Submit the form data since there are no real Ids, Names, or Tags for this button element, just use the 1st item in the array of forms
                    Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.forms[0].submit();")
                    Await PageTitleWait("Search")
                    Await Wait(100)

                    'Get link, and parse Id. The line with the Username has the EOC User ID number
                    If FindTextInDoc("/user_summary.php?s=&amp;u=*"">" & strUsername & "</a></td>", "", strUserId, "", False, "") = True AndAlso strUserId.Length > 1 AndAlso IsNumeric(strUserId) AndAlso CInt(strUserId) > 3 Then
                        'Save the ExtremeOverclocking.com Username Id
                        INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_EOC_ID).Value = strUserId
                        INI.Save(IniFilePath)

                        'Open the user's EOC stats page
                        Await OpenURL(URL_EOC & strUserId, False)
                    Else
                        'Fix missing value. Ask for EOC User ID
                        Dim TxtEntry As New TextEntryDialog
                        TxtEntry.Text = "Save ExtremeOverclocking.com Username Id"
                        TxtEntry.MsgTextUpper.Text = "ExtremeOverclocking.com Username Id not found."
                        TxtEntry.MsgTextLower.Text = "Please enter your ExtremeOverclocking.com Username Id number:"
                        TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                        TxtEntry.TextEnteredLower.Visible = False
                        'Show: Attempt 1 of 3
                        TxtEntry.MsgTextExtraBottomNote.Visible = True
                        TxtEntry.MsgTextExtraBottomNote.Text = "(Attempt: " & (iUserId + 1).ToString & " of 3)"
                        'Show modal dialog box
                        If TxtEntry.ShowDialog(Me) = DialogResult.OK AndAlso IsNumeric(TxtEntry.TextEnteredUpper.Text) Then
                            'Store ExtremeOverclocking.com Username Id
                            INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_EOC_ID).Value = TxtEntry.TextEnteredUpper.Text
                            INI.Save(IniFilePath)
                            strUsername = TxtEntry.TextEnteredUpper.Text
                            'Open the user's EOC stats page
                            Await OpenURL(URL_EOC & strUserId, False)
                        Else
                            'Update the INI status for number of attempts (New users usually take a day to show up)
                            INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_EOC_ID).Value = CStr(iUserId + 1)
                            INI.Save(IniFilePath)
                        End If
                        TxtEntry.Dispose()
                    End If
                End If

            Else
                'Open the user's EOC stats page
                Await OpenURL(URL_EOC & strUserId, False)
            End If

        Catch ex As Exception
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            OpenURL(URL_CureCoin_EOC, False)
#Enable Warning BC42358
            Msg("Error: Extreme Overclocking Username ID lookup failed: " & ex.ToString & vbNewLine & vbNewLine & "Please fix value in INI file:" & vbNewLine & IniFilePath)
        End Try
    End Sub

    Private Sub btnFoldingCoinWebsite_Click(sender As System.Object, e As System.EventArgs) Handles btnFoldingCoinWebsite.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FoldingCoin, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnFoldingCoinTwitter_Click(sender As System.Object, e As System.EventArgs) Handles btnFoldingCoinTwitter.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FoldingCoinTwitter, False)
#Enable Warning BC42358
    End Sub

    Private Async Sub btnMyWallet_Click(sender As System.Object, e As System.EventArgs) Handles btnMyWallet.Click
        If Await LoginToCounterwallet() = False Then MessageBox.Show("Task 'Log Into Wallet' did not complete. Please try again.")
    End Sub

    Private Sub btnFoldingCoinBlockchain_Click(sender As Object, e As EventArgs) Handles btnFoldingCoinBlockchain.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        'Make sure the INI key/value exists
        If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
            'Load the Wallet name from the INI file based on the Wallet Id#
            Me.txtToolsWalletName.Text = INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName).GetValue()

            If System.IO.File.Exists(DatFilePath) = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If

                If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_BTC_Addr) IsNot Nothing Then
                    'If the address is available, then open that URL for the users wallet
                    OpenURL(URL_FLDC_AddressBlockchain & DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_BTC_Addr).GetValue(), False)
                Else
                    'Just open the main URL instead
                    OpenURL(URL_FLDC_DefaultBlockchain, False)
                End If
                DAT = Nothing

            Else
                'Just open the main URL instead
                OpenURL(URL_FLDC_DefaultBlockchain, False)
            End If

        Else
            'Just open the main URL instead
            OpenURL(URL_FLDC_DefaultBlockchain, False)
        End If
#Enable Warning BC42358
    End Sub

    Private Sub btnBTCBlockchain_Click(sender As Object, e As EventArgs) Handles btnBTCBlockchain.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        'Make sure the INI key/value exists
        If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
            'Load the Wallet name from the INI file based on the Wallet Id#
            Me.txtToolsWalletName.Text = INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName).GetValue()

            If System.IO.File.Exists(DatFilePath) = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If

                If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_BTC_Addr) IsNot Nothing Then
                    'If the address is available, then open that URL for the users wallet
                    OpenURL(URL_BTC_Blockchain & "address/" & DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_BTC_Addr).GetValue(), False)
                Else
                    'Just open the main URL instead
                    OpenURL(URL_BTC_Blockchain, False)
                End If
                DAT = Nothing

            Else
                'Just open the main URL instead
                OpenURL(URL_BTC_Blockchain, False)
            End If

        Else
            'Just open the main URL instead
            OpenURL(URL_BTC_Blockchain, False)
        End If
#Enable Warning BC42358
    End Sub

    Private Sub btnFoldingCoinDiscord_Click(sender As Object, e As EventArgs) Handles btnFoldingCoinDiscord.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        LoginToDiscord(True)
#Enable Warning BC42358
    End Sub

    Private Sub btnFoldingCoinDistribution_Click(sender As System.Object, e As System.EventArgs) Handles btnFoldingCoinDistribution.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FLDC_Distro, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnFoldingCoinShop_Click(sender As Object, e As EventArgs) Handles btnFoldingCoinShop.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FoldingCoinShop, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnFoldingCoinTeamStats_Click(sender As Object, e As EventArgs) Handles btnFoldingCoinTeamStats.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_FoldingCoinStats, False)
#Enable Warning BC42358
    End Sub


    Private Sub btnCureCoinWebsite_Click(sender As System.Object, e As System.EventArgs) Handles btnCureCoinWebsite.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_CureCoin, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnCureCoinTwitter_Click(sender As System.Object, e As System.EventArgs) Handles btnCureCoinTwitter.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_CureCoinTwitter, False)
#Enable Warning BC42358
    End Sub

    Private Sub btnCureCoinBlockchain_Click(sender As Object, e As EventArgs) Handles btnCureCoinBlockchain.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        'Make sure the INI key/value exists
        If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
            'Load the Wallet name from the INI file based on the Wallet Id#
            Me.txtToolsWalletName.Text = INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName).GetValue()

            If System.IO.File.Exists(DatFilePath) = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If

                If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Addr) IsNot Nothing Then
                    'If the address is available, then open that URL for the users wallet
                    OpenURL(URL_CureCoinBlockchain & "address.dws?" & DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Addr).GetValue() & ".htm", False)
                Else
                    'Just open the main URL instead
                    OpenURL(URL_CureCoinBlockchain, False)
                End If
                DAT = Nothing

            Else
                'Just open the main URL instead
                OpenURL(URL_CureCoinBlockchain, False)
            End If

        Else
            'Just open the main URL instead
            OpenURL(URL_CureCoinBlockchain, False)
        End If
#Enable Warning BC42358
    End Sub

    Private Sub btnCureCoinDiscord_Click(sender As Object, e As EventArgs) Handles btnCureCoinDiscord.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        LoginToDiscord(False)
#Enable Warning BC42358
    End Sub

    Private Sub btnCureCoinTeamStats_Click(sender As Object, e As EventArgs) Handles btnCureCoinTeamStats.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(URL_CureCoin_EOC, False)
#Enable Warning BC42358
    End Sub

    Private Sub chkToolsShow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkToolsShow.CheckedChanged
        If Me.pnlBtnLinks.Height <= m_iMinPanelHeight Then
            'Panel minimized: Show Tools Panel
            m_iTargetExpandedPanelHeight = m_iMaxPanelHeight
            Me.chkToolsShow.Image = GetResizedImage(My.Resources.TB_ToolsSettingsGearEnabled_96, CInt(i24 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
        Else
            'Panel shown already: Toggle the Tools section
            If Me.pnlBtnLinks.Height = m_iMaxPanelHeight Then
                'Hide Tools Panel
                m_iTargetExpandedPanelHeight = m_iNormPanelHeight
                Me.chkToolsShow.Image = GetResizedImage(My.Resources.TB_ToolsSettingsGearNoBG_96, CInt(i24 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            Else
                'Show Tools Panel
                m_iTargetExpandedPanelHeight = m_iMaxPanelHeight
                Me.chkToolsShow.Image = GetResizedImage(My.Resources.TB_ToolsSettingsGearEnabled_96, CInt(i24 * g_dScaleDPI), Drawing2D.InterpolationMode.HighQualityBicubic)
            End If
        End If

        If Me.pnlBtnLinks.Height <= m_iMinPanelHeight Then
            'Panel minimized: Show the panel when you click the show Tools button
            pnlBtnLinks_Click(Nothing, Nothing)
        Else
            'Panel shown already: Increase / decrease the height of the shown panel
            Me.pnlBtnLinks.Height = m_iTargetExpandedPanelHeight
        End If
    End Sub

    Private Sub btnToolsGetFAH_Click(sender As System.Object, e As System.EventArgs) Handles btnToolsGetFAH.Click
        If MessageBox.Show("Get Folding@Home Software: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            'Minimize the Tools panel
            Main_MouseUp(Nothing, Nothing)

            g_bAskDownloadLocation = True
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            GetFAH()
#Enable Warning BC42358
        End If
    End Sub

    Private Async Sub btnToolsGetWallet_Click(sender As System.Object, e As System.EventArgs) Handles btnToolsGetWallet.Click
        If MessageBox.Show("Get Wallet: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            'Minimize the Tools panel
            Main_MouseUp(Nothing, Nothing)

            If Await GetWallet() = False Then
                MessageBox.Show("Task 'Get Wallet' did not complete.")
            Else
                'Good
                Dim OkMsg As New MsgBoxDialog
                OkMsg.Text = "Wallet Setup Complete"
                OkMsg.MsgText.Text = "Wallet Setup Complete"
                OkMsg.Width = (OkMsg.MsgText.Left * 2) + OkMsg.MsgText.Width + 10
                OkMsg.ShowDialog(Me)
                OkMsg.Dispose()
            End If
        End If
    End Sub

    Private Sub btnToolsFAHConfig_Click(sender As System.Object, e As System.EventArgs) Handles btnToolsFAHConfig.Click
        'Minimize the Tools panel
        Main_MouseUp(Nothing, Nothing)

        Dim DialogFAH As New FAHSetupDialog
        Try
            'Prompt for FAH info: Ask for: (existing) Username, Merged Folding Coin Selection, FAH Team #. Show Username as typing and check it for errors. (Optional) Get Passkey by email. Show before and after of the FAH Config file changes 
            DialogFAH.m_bInitialInstall = False
            'Show modal dialog box
            DialogFAH.ShowDialog(Me)

        Catch ex As Exception
            Msg("Setup FAH User, Team, and Config error:" & ex.ToString)
        End Try
        DialogFAH.Dispose()
    End Sub

    Private Async Sub btnToolsCureCoinSetup_Click(sender As Object, e As EventArgs) Handles btnToolsCureCoinSetup.Click
        If MessageBox.Show("Setup CureCoin Folding Pool: Are you sure?", "", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            'Minimize the Tools panel
            Main_MouseUp(Nothing, Nothing)

            If Await SetupCureCoin() = False Then
                MessageBox.Show("Task 'Setup CureCoin Folding Pool' did not complete.")
            Else
                'Good
                Dim OkMsg As New MsgBoxDialog
                OkMsg.Text = "CureCoin Folding Pool Setup Complete"
                OkMsg.MsgText.Text = "CureCoin Folding Pool Setup Complete" & vbNewLine & "Please review settings in the 'Saved Data' button," & vbNewLine & "       but they should be OK"
                OkMsg.Width = (OkMsg.MsgText.Left * 2) + OkMsg.MsgText.Width + 10
                OkMsg.Height = (OkMsg.MsgText.Top * 2) + OkMsg.MsgText.Height + OkMsg.btnOK.Height + System.Windows.Forms.SystemInformation.CaptionHeight + System.Windows.Forms.SystemInformation.BorderSize.Height + 30
                OkMsg.ShowDialog(Me)
                OkMsg.Dispose()
            End If
        End If
    End Sub

    Public Sub cbxToolsWalletId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxToolsWalletId.SelectedIndexChanged
        'Make sure the INI key/value exists
        If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
            'Load the Wallet name from the INI file based on the Wallet Id#
            Me.txtToolsWalletName.Text = INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName).GetValue()
        Else
            Me.txtToolsWalletName.Text = NotUsed
        End If
    End Sub

    Private Sub btnToolsBrowserTools_Click(sender As System.Object, e As System.EventArgs) Handles btnToolsBrowserTools.Click
        Me.browser.GetBrowser.GetHost.ShowDevTools()
    End Sub

    Private Sub txtToolsWalletName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtToolsWalletName.KeyDown
        'Change wallet name when text is changed and <enter> is pressed
        If e.KeyCode = Keys.Enter Then
            If Me.txtToolsWalletName.Text.Length > 0 Then
                'Save a wallet name
                INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_WalletName).Value = Me.txtToolsWalletName.Text
                INI.Save(IniFilePath)
            End If
        End If
    End Sub

    Private Sub btnToolsOptions_Click(sender As Object, e As EventArgs) Handles btnToolsOptions.Click
        Dim DlgDisplayOptions As New DisplayOptionsDialog
        DlgDisplayOptions.StartPosition = FormStartPosition.CenterScreen
        DlgDisplayOptions.Show(Me)
    End Sub

    Private Sub btnToolsSavedData_Click(sender As Object, e As EventArgs) Handles btnToolsSavedData.Click
        Dim DlgDisplaySavedData As New DisplayTextDialog
        DlgDisplaySavedData.StartPosition = FormStartPosition.CenterScreen
        DlgDisplaySavedData.Show(Me)
    End Sub
#End Region

#Region "Auto-Wallet Login"
    'Main CounterWallet server is up: m_iCounterWalletServerUp = 1. If set to 2, then use the secondary server.
    Private m_iCounterWalletServerUp As Integer = 0
    Private Async Function IsCounterwalletUp() As Threading.Tasks.Task
        Try
            'Get CounterWallet server status to make sure it is up
            Dim strResponse1 As String = ""
            Dim strResponse2 As String = ""
            Msg("Getting CounterWallet server status from: " & URL_Counterwallet & CounterwalletAPI)
            'Display status
            Dim OkMsg As New MsgBoxDialog
            OkMsg.Text = "Checking CounterWallet Server Status"
            OkMsg.MsgText.Text = OkMsg.Text & vbNewLine & vbNewLine & "1. " & URL_Counterwallet & CounterwalletAPI & vbNewLine & "(Can take 40 seconds)"
            OkMsg.MsgText.Left = 70
            OkMsg.MsgText.Top = 70
            OkMsg.Width = (OkMsg.MsgText.Left * 2) + OkMsg.MsgText.Width + 20
            OkMsg.Height = (OkMsg.MsgText.Top * 2) + OkMsg.MsgText.Height + System.Windows.Forms.SystemInformation.CaptionHeight + System.Windows.Forms.SystemInformation.BorderSize.Height + 20
            OkMsg.StartPosition = FormStartPosition.CenterScreen
            OkMsg.btnOK.Visible = False
            OkMsg.BackColor = Color.Gold
            OkMsg.Show(Me)

            'Get CounterWallet status from server
            Await OpenURL(URL_Counterwallet & CounterwalletAPI, False)
            Await PageTitleWait("counterwallet")
            Await Wait(50)

            'Find status data in web page
            For i As Integer = 0 To 1
                'Example text: ...3927775, "counterparty-server": "OK", "counterblock_last_message_index": 757169, "counterblock": "NOT OK", "cou...
                If FindTextInDoc("""counterparty-server"": ""*K""", """counterblock"": ""*K""", strResponse1, strResponse2, True, "") = True AndAlso strResponse1.Length > 0 AndAlso strResponse2.Length > 0 Then
                    'Search for: "O"K, or "NOT O"K. If OK, then set the flag for OK.
                    If strResponse1 = "O" AndAlso strResponse2 = "O" Then m_iCounterWalletServerUp = 1
                    Exit For
                End If
                Await Wait(700)
            Next

            If m_iCounterWalletServerUp <> 1 Then
                Msg("Getting CounterWallet server status from: " & URL_CoinDaddyCounterwallet & CounterwalletAPI)
                'Display status
                OkMsg.BackColor = Color.Orange
                OkMsg.MsgText.Text = OkMsg.Text & vbNewLine & vbNewLine & "2. " & URL_CoinDaddyCounterwallet & CounterwalletAPI & vbNewLine & "(Can take 40 seconds)"

                'Get CounterWallet status from server
                Await OpenURL(URL_CoinDaddyCounterwallet & CounterwalletAPI, False)
                Await PageTitleWait("counterwallet")
                Await Wait(50)

                'Find status data in web page
                For i As Integer = 0 To 1
                    If FindTextInDoc("""counterparty-server"": ""*K""", """counterblock"": ""*K""", strResponse1, strResponse2, True, "") = True AndAlso strResponse1.Length > 0 AndAlso strResponse2.Length > 0 Then
                        'Search for: "O"K, or "NOT O"K. If OK, then set the flag for OK
                        If strResponse1 = "O" AndAlso strResponse2 = "O" Then m_iCounterWalletServerUp = 2
                        Exit For
                    End If
                    Await Wait(700)
                Next
            End If

            'Close the informational message
            OkMsg.Close()
            OkMsg.Dispose()
            Msg("Using CounterWallet server: #" & m_iCounterWalletServerUp)

        Catch ex As Exception
            Msg("CounterWallet Status error:" & ex.ToString)
        End Try
    End Function

    Private Async Function LoginToCounterwallet() As Threading.Tasks.Task(Of Boolean)
        Dim DAT As New IniFile
        Dim bSaved12W As Boolean = False
        Try
            'Check server status
            Await IsCounterwalletUp()
            If m_iCounterWalletServerUp < 1 Then
                If MessageBox.Show("CounterWallet Server appears to be down. Continue?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) <> MsgBoxResult.Ok Then
                    Return True
                End If
            End If

            'CounterWallet web page 
            Await OpenURL(If(m_iCounterWalletServerUp = 2, URL_CoinDaddyCounterwallet, URL_Counterwallet), False)
            Await PageTitleWait("Counterwallet")
            Await Wait(700)

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
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) Is Nothing OrElse DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CP12Words) Is Nothing Then
                'Prompt for PW, and save it
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Save Wallet Password"
                TxtEntry.MsgTextUpper.Text = "No saved wallet info yet."
                TxtEntry.MsgTextLower.Text = "Please enter your 12-word Passphrase:"
                TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                TxtEntry.TextEnteredLower.Visible = False
                TxtEntry.MsgTextExtraBottomNote.Visible = False
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    'Save and encrypt 12-word Passphrase
                    If TxtEntry.TextEnteredUpper.Text.Length > 24 Then
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text)
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CP12Words).Value = TxtEntry.TextEnteredUpper.Text
                    End If

                    'Create text from the INI, Encrypt, and Write/Flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))
                    'Allow time for the file to be written out
                    Await Wait(100)

                    'Save a wallet name
                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_WalletName).Value = DefaultWalletName & Me.cbxToolsWalletId.Text
                    INI.Save(IniFilePath)
                    'Allow time for the file to be written out
                    Await Wait(100)

                    'Refresh the Wallet Names
                    cbxToolsWalletId_SelectedIndexChanged(Nothing, Nothing)
                    bSaved12W = True
                End If
                TxtEntry.Dispose()
            Else
                bSaved12W = True
            End If

            If bSaved12W = True Then
                'Enter 12-word Passphrase to login
                EnterTextById("password", DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CP12Words).GetValue())
                Await Wait(50)
                DAT = Nothing

                'Trigger event to enable the Login button, since there was no keystroke event to enable the button
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("ko.utils.triggerEvent(document.getElementById('password'), 'input');")

                'Click Login button
                Await ClickById("walletLoginButton", True)

                'Return true, if you get here
                Return True
            End If

        Catch ex As Exception
            Msg("Auto-Wallet Login error:" & ex.ToString)
            If DAT IsNot Nothing Then DAT = Nothing
        End Try

        Return False
    End Function
#End Region

#Region "Auto-Discord Login"
    Private Async Function LoginToDiscord(bForFoldingCoin As Boolean) As Threading.Tasks.Task(Of Boolean)
        Dim DAT As New IniFile
        Dim bNewUser As Boolean = True
        Dim iDiscordInvite As Integer = 0

        Try
            'Make sure the INI key/value exists
            If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_DiscordInvites) IsNot Nothing Then
                iDiscordInvite = CInt(INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_DiscordInvites).Value)
            Else
                'Fix missing value. Add temp Discord invite status
                INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "0"
                INI.Save(IniFilePath)
            End If

            'Make sure DAT file exists
            If System.IO.File.Exists(DatFilePath) = True Then
                'Load DAT file, decrypt it
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed
                    Msg(DAT_ErrorMsg)
                    MessageBox.Show(DAT_ErrorMsg)
                End If

                'Determine if this is a first-time setup or not: Look for the Discord Login Email in the saved settings
                If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) Is Nothing OrElse DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_DiscordEmail) Is Nothing Then
                    'Fix missing values. Ask for email and passowrd to sign in
                    Dim DiscordDlg As New UserPwdDialog
                    'Suggest the Email from the saved settings, if available
                    If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_Email) IsNot Nothing Then
                        DiscordDlg.txtEmail.Text = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_Email).GetValue()
                    End If

                    'Suggest a strong Password (Skip characters that conflict with the INI format: =;#[]\)
                    Dim s As String = "*$-?_&!/abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                    Dim randNum As New Random()
                    Dim iPwLen As Integer = randNum.Next(25, 50)
                    Dim chrPW() As Char = New Char(iPwLen - 1) {}
                    For i As Integer = 0 To iPwLen - 1
                        chrPW(i) = s(randNum.Next(s.Length))
                    Next
                    DiscordDlg.txtPassword.Text = chrPW   'Don't use .ToString here

                    'Suggest the Username from the saved settings, if available
                    If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                        DiscordDlg.txtUsername.Text = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username).GetValue()

                        'Remove the: _ALL_<BTC> from the FAH username
                        If DiscordDlg.txtUsername.Text.Contains("_") = True Then
                            'Split the entered text at the underscores '_'
                            Dim strDim As String() = DiscordDlg.txtUsername.Text.Split("_"c)
                            If strDim(0).Length > 0 Then
                                DiscordDlg.txtUsername.Text = strDim(0)
                            End If
                        End If
                    End If

                    'Discord Registration link for FoldingCoin / CureCoin
                    If bForFoldingCoin = True Then
                        Await OpenURL(URL_FoldingCoinDiscordRegister, False)
                    Else
                        Await OpenURL(URL_CureCoinDiscordRegister, False)
                    End If
                    System.Windows.Forms.Application.DoEvents()
                    Await Wait(700)

                    'Show modal dialog box, then save email and password, if entered
                    If DiscordDlg.ShowDialog(Me) = DialogResult.OK Then
                        'Store Discord Email
                        If DiscordDlg.txtEmail.Text.Length > 0 Then
                            DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_DiscordEmail).Value = DiscordDlg.txtEmail.Text
                        Else
                            'Don't save info, if user doesn't enter it, or cancels
                            DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_DiscordEmail).Value = SkipSavingDataFlag
                        End If

                        'Store Discord Password
                        If DiscordDlg.txtPassword.Text.Length > 0 Then
                            DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_DiscordPassword).Value = DiscordDlg.txtPassword.Text
                        Else
                            'Don't save info, if user doesn't enter it, or cancels
                            DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_DiscordPassword).Value = SkipSavingDataFlag
                        End If

                        'Allow the sign-up process to run instead of signing-in
                        bNewUser = DiscordDlg.chkNewUser.Checked
                        If bNewUser = True Then
                            'If available, then fill-in the Email, Password, and Username
                            EnterTextById("register-email", DiscordDlg.txtEmail.Text)
                            EnterTextById("register-username", DiscordDlg.txtUsername.Text)
                            EnterTextById("register-password", DiscordDlg.txtPassword.Text)
                            Await Wait(100)

                            'If the Email and Password were entered
                            If DiscordDlg.txtEmail.Text.Length > 0 AndAlso DiscordDlg.txtPassword.Text.Length > 0 Then
                                'Click Registration Continue button
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
                                ClickByClass("btn btn-primary", 0, True)
#Enable Warning BC42358
                                'Save status flag for which Discord server you've been invited to: 0 = None, 1 = FoldingCoin, 2 = CureCoin, 3 = Both invites have been completed
                                If bForFoldingCoin = True Then
                                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "1"
                                    iDiscordInvite = 1
                                Else
                                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "2"
                                    iDiscordInvite = 2
                                End If
                                INI.Save(IniFilePath)
                            End If
                        End If
                    Else
                        'Don't save info, if user doesn't enter it, or cancels
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_DiscordEmail).Value = SkipSavingDataFlag
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_DiscordPassword).Value = SkipSavingDataFlag

                        'Suggest the Email from the saved settings, if available
                        If DiscordDlg.txtEmail.Text.Length > 0 Then
                            EnterTextById("register-email", DiscordDlg.txtEmail.Text)
                        End If
                    End If

                    'Create text from the INI, Encrypt, and Write/Flush DAT text to file
                    SaveDat(Encrypt(DAT.SaveToString))
                    'Allow time for the file to be written out
                    Await Wait(100)
                    DiscordDlg.Dispose()

                    'Return true, if you get here for new user registrations. There is a captcha after this anyway
                    If bNewUser = True Then
                        If DAT IsNot Nothing Then DAT = Nothing
                        Return True
                    End If
                End If

                'Normal Discord login: Load Email and Password for the login web page
                If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_DiscordEmail) IsNot Nothing Then
                    'Open the Discord Sign-in page for the FoldingCoin / CureCoin button pressed
                    If bForFoldingCoin = True Then
                        Await OpenURL(URL_FoldingCoinDiscord, False)
                    Else
                        Await OpenURL(URL_CureCoinDiscord, False)
                    End If
                    'Let the page load. The title isn't always 'Discord', sometimes it's the channel name
                    System.Windows.Forms.Application.DoEvents()
                    Await Wait(2000)

                    'Skip asking for this in the future, if originally cancelled - Don't store info
                    Dim strEmail As String = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_DiscordEmail).GetValue()
                    If strEmail <> SkipSavingDataFlag Then
                        'Don't try to login again if you're already logged in (pressing the button again or switching between FoldingCoin and CureCoin)
                        Dim strReturn As String = ""
                        If FindTextInDoc("Login", "", strReturn, "", False, "") = True Then
                            'Discord is making it difficult to Auto-Login. Using SendKeys instead of entering text into the document and pressing the enter button
                            SendKeys.Send(strEmail)
                            Await Wait(300)

                            'Move to the next textbox
                            SendKeys.Send("{TAB}")
                            'Enter the PW
                            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_DiscordPassword) IsNot Nothing Then
                                Dim strPw As String = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_DiscordPassword).GetValue()
                                If strPw <> SkipSavingDataFlag Then
                                    'With curly braces, escape any SendKeys special characters: {, }, +, ^, %, ~, (, ), [, ]
                                    strPw = strPw.Replace("{", "{{}").Replace("}", "{}}").Replace("+", "{+}").Replace("^", "{^}").Replace("%", "{%}").Replace("~", "{~}").Replace("(", "{(}").Replace(")", "{)}").Replace("[", "{[}").Replace("]", "{]}")
                                    SendKeys.Send(strPw)
                                    strPw = Nothing
                                    Await Wait(200)
                                    System.Windows.Forms.Application.DoEvents()

                                    'Hit Enter to login
                                    SendKeys.Send("{ENTER}")
                                End If
                            End If
                        End If

                        'Go to Discord Invite pages, if needed. Use status flag for which Discord server you've been invited to: 0 = None, 1 = FoldingCoin, 2 = CureCoin, 3 = Both invites have been completed
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
                        Select Case iDiscordInvite
                            Case 0
                                'Existing User. First time use. Setup to invite to first Discord server of the two
                                If bForFoldingCoin = True Then
                                    Await Wait(2000)
                                    OpenURL(URL_FoldingCoinDiscordInvite, False)
                                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "1"
                                    INI.Save(IniFilePath)
                                Else
                                    Await Wait(2000)
                                    OpenURL(URL_CureCoinDiscordInvite, False)
                                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "2"
                                    INI.Save(IniFilePath)
                                End If

                            Case 1
                                'Has been invited to FoldingCoin already. Only invite to CureCoin Discord server
                                If bForFoldingCoin = False Then
                                    Await Wait(2000)
                                    OpenURL(URL_CureCoinDiscordInvite, False)
                                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "3"
                                    INI.Save(IniFilePath)
                                End If

                            Case 2
                                'Has been invited to CureCoin already. Only invite to FoldingCoin Discord server
                                If bForFoldingCoin = True Then
                                    Await Wait(2000)
                                    OpenURL(URL_FoldingCoinDiscordInvite, False)
                                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_DiscordInvites).Value = "3"
                                    INI.Save(IniFilePath)
                                End If

                            Case 3
                                'Do nothing here. User has been invited to both FoldingCoin and CureCoin Discord invites
                        End Select
#Enable Warning BC42358
                    End If
                Else
                    'Just open the main URL instead
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
                    If bForFoldingCoin = True Then
                        OpenURL(URL_FoldingCoinDiscord, False)
                    Else
                        OpenURL(URL_CureCoinDiscord, False)
                    End If
#Enable Warning BC42358
                End If
            Else
                'Just open the main URL instead
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
                If bForFoldingCoin = True Then
                    OpenURL(URL_FoldingCoinDiscord, False)
                Else
                    OpenURL(URL_CureCoinDiscord, False)
                End If
#Enable Warning BC42358
            End If

            If DAT IsNot Nothing Then DAT = Nothing
            'Return true, if you get here
            Return True

        Catch ex As Exception
            Msg("Auto-Discord Login error:" & ex.ToString)
            If DAT IsNot Nothing Then DAT = Nothing
        End Try

        Return False
    End Function
#End Region

#Region "Automated Processes - Mostly for the 'one time only' setups"
    Private Async Function GetWallet() As Threading.Tasks.Task(Of Boolean)
        Try
            'Look to see if the wallet INI key/value exists, and warn user to change wallet info slots, or the info will be overwritten
            If INI.GetSection(Id & Me.cbxToolsWalletId.Text) IsNot Nothing AndAlso INI.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(INI_WalletName) IsNot Nothing Then
                'Load the Wallet name from the INI file based on the Wallet Id#
                If MessageBox.Show("WARNING: Wallet Id #" & Me.cbxToolsWalletId.Text & " info already exists!  Overwrite?" & vbNewLine & "(A different Wallet Id can be set in the 'Tools' section)", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) <> MsgBoxResult.Ok Then
                    Return True
                End If
            End If

            'Check server status
            Await IsCounterwalletUp()
            If m_iCounterWalletServerUp < 1 Then
                If MessageBox.Show("CounterWallet Server appears to be down. Continue?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) <> MsgBoxResult.Ok Then
                    Return False
                End If
            End If

            'CounterWallet web page 
            Await OpenURL(If(m_iCounterWalletServerUp = 2, URL_CoinDaddyCounterwallet, URL_Counterwallet), False)
            Await PageTitleWait("Counterwallet")
            Await Wait(700)

            'Click Create New CounterWallet
            Await ClickById("newWalletButton", False)
            Await Wait(300)

            'Save 12-word Passphrase and BTC address
            Dim str12W As String = ""
            Dim strBTCAddr As String = ""

            For i As Integer = 0 To 10
                If FindTextInDoc("generatedPassphrase"">*</span>", "", str12W, "", False, "") = True AndAlso str12W.Length > 24 Then
                    Exit For
                End If
                Await Wait(400)
            Next

            If str12W.Length > 24 Then
                'Click the "I've written it down" check box
                Await ClickByName("passphraseSaved", 0, False)
                'Click Continue button
                Await ClickById("continueWalletCreation", False)
                Await Wait(100)

                'There are 3 buttons with this ID: finishWalletCreation. Use the class to get the ('btn btn-primary') 4th instance for the Create Wallet button:
                Await ClickByClass("btn btn-primary", 3, False)
                Await Wait(100)

                'Click the 'X' close button.  Not working: click OK, the ('btn btn-primary') 9th instance for the OK button.
                Await ClickByClass("bootbox-close-button close", 0, False)

                'Enter 12-word Passphrase to login
                EnterTextById("password", str12W)
                'Trigger event to enable the Login button, since there was no keystroke event to enable the button
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("ko.utils.triggerEvent(document.getElementById('password'), 'input');")

                'Click Login button
                Await ClickById("walletLoginButton", True)
                Await Wait(1000)

                'First login, accept terms. ('btn btn-success') 2nd instance for the Accept button:
                Await ClickByClass("btn btn-success", 1, False)

                'The logged into wallet web page has no title, but the previous page had a title
                Await PageNoTitleWait()

                For i As Integer = 1 To 40
                    If FindTextInDoc("selectAddressText, text: dispAddress"">*</span>", "", strBTCAddr, "", False, "") = True Then
                        If strBTCAddr.Length >= 26 AndAlso strBTCAddr.Length <= 35 AndAlso (strBTCAddr.StartsWith("1") = True OrElse strBTCAddr.StartsWith("3") = True) Then
                            Exit For
                        End If
                    End If
                    Await Wait(200)
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
                DAT.AddSection(Id & Me.cbxToolsWalletId.Text)
                DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CP12Words).Value = str12W

                If strBTCAddr.Length > 25 Then
                    'Store Bitcoin address in both INI and DAT files
                    DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_BTC_Addr).Value = strBTCAddr
                    'Set a wallet name
                    INI.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(INI_WalletName).Value = strBTCAddr.Substring(0, 8) & "..."
                    INI.Save(IniFilePath)
                End If
                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(DAT.SaveToString))
                'Allow time for the file to be written out
                Await Wait(100)
                DAT = Nothing

                'Refresh the Wallet Names
                cbxToolsWalletId_SelectedIndexChanged(Nothing, Nothing)

                'Return true, if you get here
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

    Private Async Function GetFAH() As Threading.Tasks.Task(Of Boolean)
        Try
            'Get Folding@Home App
            Await OpenURL(URL_FAH & URL_FAH_DL, False)
            Await PageTitleWait("Start folding")
            Await Wait(500)

            'Make the download progress visible
            Me.gbxDownload.Visible = True

            'Start the download: Click the link for Windows download
            Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('fah-file')[0].getElementsByTagName('a')[0].click();")

            'Close any running instances of FAH
            Try
                Dim proc As Process
                For Each proc In Process.GetProcessesByName(FAH_Client)
                    Msg("Asking user to close FAH process: " & proc.Id.ToString() & " - " & proc.ProcessName)
                    MessageBox.Show("Please close the Folding@Home software before proceeding.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Await Wait(1000)

                    'If still open, then close it
                    Dim p As Process
                    Try
                        For Each p In Process.GetProcessesByName(FAH_Client)
                            Msg("Closing process: " & p.Id.ToString() & " - " & p.ProcessName)
                            p.CloseMainWindow()
                            p.WaitForExit(3000)

                            'Check for the process being closed
                            If p.HasExited = False Then
                                Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                                p.Kill()
                                Await Wait(400)
                            End If
                        Next

                        'Try closing any FAH Core processes still active
                        For Each p In Process.GetProcesses
                            If p.ProcessName.ToLower.StartsWith(FAH_Core) = True Then
                                Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                                p.Kill()
                            End If
                        Next
                    Catch ex As Exception
                        Msg("Couldn't kill FAH: " & ex.ToString)
                    End Try

                    '2nd try to close any running instances of FAH
                    Try
                        For Each p In Process.GetProcessesByName(FAH_Client)
                            'Wait for FAH to exit before trying again
                            Await Wait(5000)
                            Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                            p.Kill()
                            Await Wait(3000)
                        Next

                        'Try closing any FAH Core processes still active
                        For Each p In Process.GetProcesses
                            If p.ProcessName.ToLower.StartsWith(FAH_Core) = True Then
                                Msg("Killing process: " & p.Id.ToString() & " - " & p.ProcessName)
                                p.Kill()
                            End If
                        Next
                    Catch ex As Exception
                        Msg("Couldn't kill FAH: " & ex.ToString)
                    End Try

                    'If you get here, exit searching through the processes
                    Exit For
                Next

            Catch ex As Exception
                Msg("Error asking for FAH to be closed: " & ex.ToString)
            End Try

            'Is the download done?
            Dim i As Integer = 0
            'Wait for the web page, or 2 hours
            Do Until Me.gbxDownload.Visible = False OrElse g_bCancelNav = True OrElse i > 2400
                i += 1
                Await Wait(500)
            Loop
            'Download didn't finish or was canceled. Don't reset: g_bCancelNav = False, here because it messes up canceling the download
            If i >= 2400 Then Exit Try
            'Let the screen refresh
            Await Wait(50)

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
                Return True
            End If

        Catch ex As Exception
            Msg("Get FAH error:" & ex.ToString)
        End Try

        'Reset flag
        g_bAskDownloadLocation = True
        Me.gbxDownload.Visible = False
        Return False
    End Function

    'This is called by the 'FAHSetupDialog' window to get the Passkey email from Stanford
    Public Async Function GetFAHpasskey(URL As String) As Threading.Tasks.Task(Of Boolean)
        Try
            'Get Folding@Home App
            Await OpenURL(URL, False)
            Await PageTitleWait("Folding@home")
            Await Wait(100)

            'Return true, if you get here
            Return True

        Catch ex As Exception
            Msg("Get FAH passkey error:" & ex.ToString)
        End Try

        Return False
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

        Dim i As Integer = 0
        Dim randNum As New Random()
        Dim DAT As New IniFile

        Try
            'Try to make the window tall enough to see the captcha at the botttom of the screen
            If Me.Height < 975 Then Me.Height = 975

            'Go to the CureCoin folding pool (CryptoBullionPools) website
            Await OpenURL(URL_CureCoinFoldingPoolPage, False)

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
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Addr) IsNot Nothing Then
                strWalletAddress = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Addr).GetValue()
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
                            Await Wait(2000)

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
                            strWalletVersion = Await SendHTTP_JSON_RPC("{""jsonrpc"": ""1.0"", ""id"":""GetVers"", ""method"": ""getinfo"", ""params"": [] }")
                            If strWalletVersion.Contains("GetVers") AndAlso FindTextInDoc(""":""*"",""", "", strWalletVersion, "", False, strWalletVersion) = True AndAlso strWalletVersion.Length > 5 Then
                                'Setup a loop for a few retries
                                For i = 0 To 2
                                    Await Wait(700)
                                    'Get the wallet name to get the wallet address
                                    strWalletName = Await SendHTTP_JSON_RPC("{""jsonrpc"": ""1.0"", ""id"":""GetMyWalletName"", ""method"": ""listaccounts""}")

                                    If strWalletName.Contains("GetMyWalletName") AndAlso FindTextInDoc(":{""*"":", "", strWalletName, "", False, strWalletName) = True Then
                                        Await Wait(700)
                                        'Get the Wallet Address using the wallet name from the first request
                                        strWalletAddress = Await SendHTTP_JSON_RPC("{""jsonrpc"": ""1.0"", ""id"":""GetMyCureCoinAddress"", ""method"": ""getaddressesbyaccount"", ""params"":[""" & strWalletName & """]}")

                                        If strWalletAddress.Contains("GetMyCureCoinAddress") AndAlso FindTextInDoc("{""result"":[""*""],", "", strWalletAddress, "", False, strWalletAddress) = True AndAlso strWalletAddress.Length > 24 Then
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
                    Await Wait(3000)
                Next
            End If

        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try

        Try
            'If the wallet address is still not found, then pop-up a message saying to fill in the address
            If strWalletAddress.Length < 24 Then
                'Prompt for PW, and save it
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Save CureCoin Wallet Address"
                TxtEntry.MsgTextUpper.Text = "From the 'Receive coins' address tab in the CureCoin Wallet Software,"
                TxtEntry.MsgTextLower.Text = "Please enter your CureCoin Wallet Address (right-click, Copy Address):"
                TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                TxtEntry.TextEnteredLower.Visible = False
                TxtEntry.MsgTextExtraBottomNote.Visible = False
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    'Get the Wallet Address
                    If TxtEntry.TextEnteredUpper.Text.Length > 24 Then
                        strWalletAddress = TxtEntry.TextEnteredUpper.Text
                    End If
                End If
                TxtEntry.Dispose()
            End If

            'Exit / Return false, if there is no CureCoin wallet address
            If strWalletAddress.Length < 24 Then Return False

            'Save the DAT info
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text) Is Nothing Then DAT.AddSection(Id & Me.cbxToolsWalletId.Text)
            If strWalletAddress.Length >= 24 Then DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CureCoin_Addr).Value = strWalletAddress

            'Try to get the FAH Username from saved info first
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                strFAHUser = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
            End If
            If strFAHUser.Length < 2 Then
                'Prompt for FAH username. Can be short for a CureCoin only username...
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Save Folding Username / CureCoin Pool Login"
                TxtEntry.MsgTextUpper.Text = "Please enter your Folding Username."
                TxtEntry.MsgTextLower.Text = "This is used as the CureCoin Pool Login:"
                TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                TxtEntry.TextEnteredLower.Visible = False
                TxtEntry.MsgTextExtraBottomNote.Visible = False
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    'Get the Folding Username / CureCoin Pool Login
                    If TxtEntry.TextEnteredUpper.Text.Length > 1 Then
                        strFAHUser = TxtEntry.TextEnteredUpper.Text
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_FAH_Username).Value = strFAHUser
                    End If
                End If
                TxtEntry.Dispose()
            End If

            'Try to get the Email from saved info first
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_Email) IsNot Nothing Then
                strEmail = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_Email).GetValue()
            End If
            If strEmail.Length < 4 Then
                'Prompt for Email Address
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Save Email Address"
                TxtEntry.MsgTextUpper.Text = "Please enter your Email Address."
                TxtEntry.MsgTextLower.Text = "This is used for the CureCoin Pool sign up:"
                TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                TxtEntry.TextEnteredLower.Visible = False
                TxtEntry.MsgTextExtraBottomNote.Visible = False
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    'Get the Email Address
                    If TxtEntry.TextEnteredUpper.Text.Length > 3 Then
                        strEmail = TxtEntry.TextEnteredUpper.Text
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_Email).Value = strEmail
                    End If
                End If
                TxtEntry.Dispose()
            End If

            'Try to get the CureCoin pool password from saved info first
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Pwd) IsNot Nothing Then
                strPoolPW = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Pwd).GetValue()
            End If
            If strPoolPW.Length < 5 Then
                'Makeup a new 35-50 char Password (Skip characters that conflict with the INI format: =;#[]\)
                Dim s As String = "*$-+?_&!%{}/abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                Dim iPwLen As Integer = randNum.Next(35, 50)
                Dim chrPW() As Char = New Char(iPwLen - 1) {}
                For i = 0 To iPwLen - 1
                    chrPW(i) = s(randNum.Next(s.Length))
                Next
                strPoolPW = chrPW   'Don't use .ToString here

                'Save the new Password
                If strPoolPW.Length > 24 Then DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CureCoin_Pwd).Value = strPoolPW
            End If

            'Try to get the CureCoin pool pin from saved info first
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Pin) IsNot Nothing Then
                strPoolPin = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Pin).GetValue()
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
                If strPoolPin.Length >= 6 Then DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CureCoin_Pin).Value = strPoolPin
            End If

            'Create text from the INI, Encrypt, and Write/flush DAT text to file
            SaveDat(Encrypt(DAT.SaveToString))
            'Allow time for the file to be written out
            Await Wait(100)
            DAT = Nothing

            Await PageTitleWait(NameCryptoBullions)
            System.Windows.Forms.Application.DoEvents()
            'Wait for the registration page to load, if not already (needs to wait for CloudFlare to reload the page)
            For i = 0 To 40
                If Me.Text.Contains("Just") = False Then Exit For
                Await Wait(300)
            Next

            'Setup retries if the captcha fails / CloudFlare takes too long (~5s)
            For m As Integer = 0 To 2
                'Go to the CureCoin folding pool (CryptoBullionPools) website
                Await OpenURL(URL_CureCoinFoldingPoolPage & "register", False)
                Await PageTitleWait(NameCryptoBullions)
                System.Windows.Forms.Application.DoEvents()
                Await Wait(100)

                'Ensure the Pool page loaded before proceeding (and it's not still loading CloudFlare...)
                Dim jsResp As CefSharp.JavascriptResponse
                For i = 0 To 20
                    'There should be a count of 2 of these elements on the registration page
                    jsResp = Await Me.browser.GetBrowser.MainFrame.EvaluateScriptAsync("document.getElementsByClassName('submit small').length;")
                    If jsResp.Success = True AndAlso IsNumeric(jsResp.Result) = True AndAlso CInt(jsResp.Result) > 0 Then Exit For
                    Await Wait(500)
                Next

                'Fill in form info from the data
                'Enter FAH Username
                EnterTextByName("user", 0, strFAHUser)
                'Fill in CureCoin address
                EnterTextByName("cure", 0, strWalletAddress)
                'Password
                EnterTextByName("pass", 0, strPoolPW)
                EnterTextByName("pass2", 0, strPoolPW)
                'Email
                EnterTextByName("email", 0, strEmail)
                EnterTextByName("email2", 0, strEmail)
                'Pin
                EnterTextByName("authPin", 0, strPoolPin)
                Await Wait(100)

                'Scroll to the bottom of the page, so you can see the captcha when the modal dialog is in the way
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("window.scrollTo(0,document.body.scrollHeight);")

                'Login: Enter FAH Username
                EnterTextByName("username", 0, strFAHUser)
                'Password
                EnterTextByName("password", 0, strPoolPW)
                Await Wait(100)

                'Ask for the Captcha in a modal dialog, to enter in the form (to keep the user from mofifying the passwords)
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Enter Captcha Text"
                TxtEntry.MsgTextUpper.Text = "From the bottom of the registration page,"
                TxtEntry.MsgTextLower.Text = "Please enter the captcha text:"
                TxtEntry.Width = (TxtEntry.MsgTextUpper.Left * 2) + TxtEntry.MsgTextUpper.Width + 10
                TxtEntry.TextEnteredLower.Visible = False
                'Show: Attempt 1 of 3
                TxtEntry.MsgTextExtraBottomNote.Visible = True
                'Hide the Cancel button in favor of showing: Attempt 1 of 3
                TxtEntry.btnCancel.Visible = False
                'Move the OK button in the place of the hidden Cancel button
                TxtEntry.btnOK.Left = TxtEntry.btnCancel.Left
                TxtEntry.MsgTextExtraBottomNote.Text = "(Attempt: " & (m + 1).ToString & " of 3)"
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    EnterTextByName("captcha_code", 0, TxtEntry.TextEnteredUpper.Text)
                    TxtEntry.Dispose()

                    'Click "Register" (There are 2 buttons with this class. Click the 2nd button [1])
                    Await ClickByClass("submit small", 1, False)
                    Await Wait(1000)

                    'Wait for the page to load
                    Await PageTitleWait(NameCryptoBullions)
                    Await Wait(300)
                    'Find: account created text, or Errors for: account exists already, or Wrong Captcha text
                    Dim strTemp As String = ""
                    For l As Integer = 1 To 5
                        If g_bCancelNav = True Then Exit Try

                        If FindTextInDoc("ccount *. Please", "Wrong Captcha", strTemp, "", False, "") = True Then
                            If strTemp.Length > 0 Then
                                Exit For
                            End If
                        End If
                        Await Wait(3000)
                    Next

                    Msg("CryptoBullions Registration response: '" & strTemp & "'.")
                    'Look for a 'successfully created' or 'exists' message
                    If strTemp.Contains("successfully created") Then
                        'Return true, if you get here
                        Return True

                    ElseIf strTemp.Contains("exists") Then
                        'Indicate account exists already
                        MessageBox.Show("Account exists. Please try to login instead of creating a new account." & vbNewLine & vbNewLine & "If you don't have the password or pin to this account," & vbNewLine & "then you will probably need to change your username.")

                        'Return true, if you get here
                        Return True
                    End If
                Else
                    'Canceled dialog
                    TxtEntry.Dispose()
                    Return False
                End If
            Next

        Catch ex As Exception
            Msg("Setup CureCoin Folding Pool info error:" & ex.ToString)
        End Try

        Return False
    End Function

    Private Async Function SendHTTP_JSON_RPC(strJSON_Cmd As String) As Threading.Tasks.Task(Of String)
        Try
            'Get HTTP JSON_RPC data from server
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
                    Await Wait(200)

                    'Get response
                    Dim response As Net.WebResponse = webRequest.GetResponse()
                    Msg(CType(response, Net.HttpWebResponse).StatusDescription)
                    dataStream = response.GetResponseStream()
                    Dim reader As New IO.StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Msg(responseFromServer)

                    'Close objects
                    reader.Close()
                    response.Close()
                    dataStream.Close()

                    Return responseFromServer
                End If
            End If
        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try

        Return ""
    End Function

    Private Async Sub btnCurePool_Click(sender As Object, e As EventArgs) Handles btnCurePool.Click
        Dim strFAHUser As String = ""
        Dim strPoolPW As String = ""
        Dim bSaveDat As Boolean = False
        Dim DAT As New IniFile

        Try
            'Go to the CureCoin folding pool (CryptoBullionPools) website
            Await OpenURL(URL_CureCoinFoldingPoolPage, False)

            'Wait for the registration page to load, if not already (needs to wait for CloudFlare to reload the page)
            Await PageTitleWait(NameCryptoBullions)
            System.Windows.Forms.Application.DoEvents()

            For i As Integer = 0 To 40
                If Me.Text.Contains("Just") = False Then Exit For
                Await Wait(300)
            Next
            Await PageTitleWait(NameCryptoBullions)
            System.Windows.Forms.Application.DoEvents()

            'Ensure the Pool page loaded before proceeding (and it's not still loading CloudFlare...)
            Dim jsResp As CefSharp.JavascriptResponse
            For i = 0 To 20
                'There should be a count of 1 of these elements on the main page
                jsResp = Await Me.browser.GetBrowser.MainFrame.EvaluateScriptAsync("document.getElementsByClassName('submit small').length;")
                If jsResp.Success = True AndAlso IsNumeric(jsResp.Result) = True AndAlso CInt(jsResp.Result) > 0 Then Exit For
                Await Wait(300)
            Next

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
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username) IsNot Nothing Then
                strFAHUser = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_FAH_Username).GetValue()
            End If
            If strFAHUser.Length < 2 Then
                'Prompt for FAH username (and all the other info?). Can be short for a CureCoin only username...
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Save Folding Username / CureCoin Pool Login"
                TxtEntry.MsgTextUpper.Text = "Please enter your Folding Username."
                TxtEntry.MsgTextLower.Text = "This is used as the CureCoin Pool Login:"
                TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                TxtEntry.TextEnteredLower.Visible = False
                TxtEntry.MsgTextExtraBottomNote.Visible = False
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    'Get the Folding Username / CureCoin Pool Login
                    If TxtEntry.TextEnteredUpper.Text.Length > 1 Then
                        strFAHUser = TxtEntry.TextEnteredUpper.Text
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_FAH_Username).Value = strFAHUser
                        bSaveDat = True
                    End If
                End If
                TxtEntry.Dispose()
            End If

            'Try to get the CureCoin pool password from saved info first
            If DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Pwd) IsNot Nothing Then
                strPoolPW = DAT.GetSection(Id & Me.cbxToolsWalletId.Text).GetKey(DAT_CureCoin_Pwd).GetValue()
            End If
            If strPoolPW.Length < 5 Then
                'Ask for existing password
                Dim TxtEntry As New TextEntryDialog
                TxtEntry.Text = "Save CureCoin Pool Passwords"
                TxtEntry.MsgTextUpper.Text = "Please enter your CureCoin Pool Password (Top text box):"
                TxtEntry.MsgTextLower.Text = "(Optional) Enter your CureCoin Pool Pin (Bottom text box):"
                TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 10
                TxtEntry.TextEnteredLower.Visible = True
                TxtEntry.MsgTextExtraBottomNote.Visible = False
                'Show modal dialog box
                If TxtEntry.ShowDialog(Me) = DialogResult.OK Then
                    'Get the CureCoin Pool Password (Top text box)
                    If TxtEntry.TextEnteredUpper.Text.Length > 1 Then
                        strPoolPW = TxtEntry.TextEnteredUpper.Text
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CureCoin_Pwd).Value = strPoolPW
                        bSaveDat = True
                    End If

                    'Get the CureCoin Pool Pin (Bottom text box)
                    If TxtEntry.TextEnteredLower.Text.Length > 1 Then
                        DAT.AddSection(Id & Me.cbxToolsWalletId.Text).AddKey(DAT_CureCoin_Pin).Value = TxtEntry.TextEnteredLower.Text
                        bSaveDat = True
                    End If
                End If
                TxtEntry.Dispose()
            End If

            If bSaveDat = True Then
                'Create text from the INI, Encrypt, and Write/flush DAT text to file
                SaveDat(Encrypt(DAT.SaveToString))
                'Allow time for the file to be written out
                Await Wait(100)
            End If
            DAT = Nothing

            'Login: Enter FAH Username
            EnterTextByName("username", 0, strFAHUser)
            'Password
            EnterTextByName("password", 0, strPoolPW)

            'Ask user to solve the captcha
            Dim OkMsg As New MsgBoxDialog
            OkMsg.Text = "Please Login"
            OkMsg.MsgText.Text = "<-- Please solve the 'I'm not a robot' captcha, and Login"
            OkMsg.Width = (OkMsg.MsgText.Left * 2) + OkMsg.MsgText.Width + 10
            'Show modal dialog box
            OkMsg.ShowDialog(Me)
            OkMsg.Dispose()

        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Sub
#End Region

#Region "Browser Commands"
    'Specify text box {Object Id}, and text to enter in to the text box
    Private Function EnterTextById(sId As String, sText As String) As Boolean
        EnterTextById = False

        Try
            If sId.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('" & sId & "').value = '" & sText & "';")
                EnterTextById = True
            End If
        Catch ex As Exception
            Msg("Enter Text by Id error: " & Err.Description)
        End Try
    End Function

    'Specify text box {Object Name} and array index (0-based), and text to enter in to the text box
    Private Function EnterTextByName(sName As String, iIndex As Integer, sText As String) As Boolean
        EnterTextByName = False

        Try
            If sName.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByName('" & sName & "')[" & iIndex.ToString & "].value = '" & sText & "';")
                EnterTextByName = True
            End If
        Catch ex As Exception
            Msg("Enter Text by Name error: " & Err.Description)
        End Try
    End Function

    'Specify text box {Class Name} and array index (0-based), and text to enter in to the text box
    Private Function EnterTextByClass(sName As String, iIndex As Integer, sText As String) As Boolean
        EnterTextByClass = False

        Try
            If sName.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('" & sName & "')[" & iIndex.ToString & "].value = '" & sText & "';")
                EnterTextByClass = True
            End If
        Catch ex As Exception
            Msg("Enter Text by Class error: " & Err.Description)
        End Try
    End Function

    'Specify text box {Tag Name} and array index (0-based), and text to enter in to the text box
    Private Function EnterTextByTag(sName As String, iIndex As Integer, sText As String) As Boolean
        EnterTextByTag = False

        Try
            If sName.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByTagName('" & sName & "')[" & iIndex.ToString & "].value = '" & sText & "';")
                EnterTextByTag = True
            End If
        Catch ex As Exception
            Msg("Enter Text by Tag error: " & Err.Description)
        End Try
    End Function

    'Specify object {Object Id} to click, and if you wait for the page to load or not
    Private Async Function ClickById(sId As String, bWait As Boolean) As Threading.Tasks.Task(Of Boolean)
        Try
            If sId.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('" & sId & "').click();")

                'Wait for the page, if specified
                If bWait = True Then
                    If Await PageLoadWait() = True Then Return True Else Return False
                Else
                    Return True
                End If
            End If

        Catch ex As Exception
            Msg("Click by Id error: " & Err.Description)
        End Try

        Return False
    End Function

    'Specify object {Class Name} to click, and if you wait for the page to load or not
    Private Async Function ClickByClass(sName As String, iIndex As Integer, bWait As Boolean) As Threading.Tasks.Task(Of Boolean)
        Try
            If sName.Length > 0 Then
                'Click it
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('" & sName & "')[" & iIndex.ToString & "].click();")
                'Wait for the page, if specified
                If bWait = True Then
                    If Await PageLoadWait() = True Then Return True Else Return False
                Else
                    Return True
                End If
            End If

        Catch ex As Exception
            Msg("Click by Class error: " & Err.Description)
        End Try

        Return False
    End Function

    'Specify object {Object Name} to click, and if you wait for the page to load or not
    Private Async Function ClickByName(sName As String, iIndex As Integer, bWait As Boolean) As Threading.Tasks.Task(Of Boolean)
        Try
            If sName.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByName('" & sName & "')[" & iIndex.ToString & "].click();")
                'Wait for the page, if specified
                If bWait = True Then
                    If Await PageLoadWait() = True Then Return True Else Return False
                Else
                    Return True
                End If
            End If

        Catch ex As Exception
            Msg("Click by Name error: " & Err.Description)
        End Try

        Return False
    End Function

    'Specify object {Tag Name} to click, and if you wait for the page to load or not
    Public Async Function ClickByTag(sName As String, iIndex As Integer, bWait As Boolean) As Threading.Tasks.Task(Of Boolean)
        Try
            If sName.Length > 0 Then
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByTagName('" & sName & "')[" & iIndex.ToString & "].click();")
                'Wait for the page, if specified
                If bWait = True Then
                    If Await PageLoadWait() = True Then Return True Else Return False
                Else
                    Return True
                End If
            End If

        Catch ex As Exception
            Msg("Click by Tag error: " & Err.Description)
        End Try

        Return False
    End Function

    'Specify text to find in HTML document, or supplied text
    Private m_bRunningFind As Boolean = False
    Private Function FindTextInDoc(strFind As String, str2ndFind As String, ByRef strReturnText1 As String, ByRef strReturnText2 As String, bFindBoth As Boolean, strSearchThisSuppliedTextInstead As String) As Boolean
        FindTextInDoc = False
        Dim sText As String() = Nothing
        Dim sMask As String() = Nothing

        Try
            If strFind.Length > 0 Then
                If strSearchThisSuppliedTextInstead.Length = 0 Then
                    If m_bRunningFind = True Then Exit Try
                    m_bRunningFind = True
                    'Try to avoid running this multiple times at once. CefSharp v49 hangs when that happens. Probably from the Wait using: Threading.Thread.Sleep
                    Dim sTempStr As String = browser.GetBrowser.MainFrame.GetSourceAsync.Result
                    m_bRunningFind = False
                    sText = sTempStr.Split(vbNewLine.ToCharArray)
                Else
                    sText = strSearchThisSuppliedTextInstead.Split(vbNewLine.ToCharArray)
                End If

                If sText IsNot Nothing Then
                    For l As Integer = 1 To 2
                        'Search for wild-card (*) data or not
                        If strFind.Contains("*") = False Then
                            'No wild-card, just return the line of text that contains the search text
                            For Each sLineOfText As String In sText
                                If sLineOfText.Contains(strFind) = True Then
                                    'Return the line of text that contains the search text
                                    If bFindBoth = True Then
                                        If l = 1 Then
                                            strReturnText1 = Trim(sLineOfText)
                                            'Update the return value
                                            FindTextInDoc = True
                                            Exit For
                                        Else
                                            strReturnText2 = Trim(sLineOfText)
                                            sText = Nothing
                                            Return True
                                        End If
                                    Else
                                        strReturnText1 = Trim(sLineOfText)
                                        sText = Nothing
                                        Return True
                                    End If
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
                                            If bFindBoth = True Then
                                                If l = 1 Then
                                                    strReturnText1 = Trim(sLineOfText.Substring(iPos1, iPos2 - iPos1))
                                                    'Update the return value
                                                    FindTextInDoc = True
                                                    Exit For
                                                Else
                                                    strReturnText2 = Trim(sLineOfText.Substring(iPos1, iPos2 - iPos1))
                                                    sText = Nothing
                                                    Return True
                                                End If
                                            Else
                                                strReturnText1 = Trim(sLineOfText.Substring(iPos1, iPos2 - iPos1))
                                                sText = Nothing
                                                Return True
                                            End If
                                        End If
                                    End If
                                End If
                            Next
                        End If

                        If str2ndFind.Length = 0 Then
                            Exit For
                        Else
                            'Update the text to search for with the Alternate 2nd text to find, and repeat the process once more (done to minimize reloading the web page to search for multiple texts)
                            strFind = str2ndFind
                            str2ndFind = ""
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            Msg("Find Text In HTML error: " & Err.Description)
            'Reset flag for an error
            m_bRunningFind = False
        End Try
    End Function
#End Region

#Region "Browser Control Event Handlers"
    Private Sub OnBrowserFrameLoadEnd(sender As Object, e As CefSharp.FrameLoadEndEventArgs)
        'Set a flag to indicate the web page has finished loading. This event is fired for each frame that loads, so compare URLs before setting the flag as loaded (NOTE: Me.browser.IsLoading = True, doesn't work)
        If e.Url IsNot Nothing AndAlso e.Url.Contains(m_strPageURL) Then
            m_bPageLoaded = True
        End If
    End Sub

    Private Sub OnBrowserConsoleMessage(sender As Object, e As CefSharp.ConsoleMessageEventArgs)
        Me.Invoke(Sub()
                      Me.txtMsg.AppendText("[" & Now.ToString(LogDateTimeFormat) & "] " & e.Message & If(e.Line > 0, " (" & e.Source & ", ln " & e.Line.ToString & " )", "") & vbNewLine)
                  End Sub)

        'WORKAROUND: FAH Web Control, where it gets stuck in an infinite refresh loop in Chrome v59+, and needs a refresh without cache to fix that condition.
        'NOTE: This error also occurs almost every time you leave the FAH web control page, so avoid reloading when clicking other web link buttons or exiting. It also happens when you stay on the page for a long time, and the FAH stats update.
        If (Me.txtURL.Text.StartsWith(URL_FAH_WebClient_IPAddr) = True OrElse Me.txtURL.Text = URL_FAH_WebClient_URL) AndAlso g_bCancelNav = False AndAlso e.Message = "DEBUG: error: " AndAlso e.Source = URL_FAH_WebClient_ErrorAddr Then
            'Refresh ignoring browser cache
            Me.browser.GetBrowser.Reload(True)
        End If
    End Sub

    Private Sub OnBrowserStatusMessage(sender As Object, args As CefSharp.StatusMessageEventArgs)
        Me.Invoke(Sub()
                      Me.txtMsg.AppendText("[" & Now.ToString(LogDateTimeFormat) & "] " & args.Value & vbNewLine)
                  End Sub)
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
                      'Set focus back to the browser control window instead of the buttons
                      Me.browser.Select()
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
                      Me.txtURL.Focus()
                      Me.txtURL.Select(Me.txtURL.Text.Length, 0)
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

    'NOTE: These control keypress events should match the equivalent events for the form events below (so they happen for whichever is active)
    Public Delegate Sub updateKP(iKeyCode As Integer, efModifiers As CefSharp.CefEventFlags)
    Public Sub updateKeyPress(iKeyCode As Integer, efModifiers As CefSharp.CefEventFlags)
        Me.Invoke(New updateKP(AddressOf upKeyPress), {iKeyCode, efModifiers})
    End Sub

    Public Sub upKeyPress(iKeyCode As Integer, efModifiers As CefSharp.CefEventFlags)
        Select Case iKeyCode
            Case Keys.Escape
                If Me.pnlFind.Visible = True Then
                    'ESC: Close find panel
                    btnFindClose_Click(Nothing, Nothing)
                Else
                    StopNavigaion()
                End If

            Case Keys.F5
                If efModifiers = CefSharp.CefEventFlags.ControlDown Then
                    'Refresh ignoring browser cache
                    Me.browser.GetBrowser.Reload(True)
                Else
                    'Refresh
                    Me.browser.GetBrowser.Reload(False)
                End If

            Case Keys.F
                If efModifiers = CefSharp.CefEventFlags.ControlDown Then
                    'Show the Find window
                    Me.pnlFind.Visible = True
                    FindTextInWebPage(True)
                    Me.txtFind.SelectAll()
                End If

            Case Keys.Left
                If efModifiers = CefSharp.CefEventFlags.AltDown Then
                    'Back
                    Me.browser.GetBrowser.GoBack()
                    Me.browser.Select()
                End If

            Case Keys.Right
                If efModifiers = CefSharp.CefEventFlags.AltDown Then
                    'Forward
                    Me.browser.GetBrowser.GoForward()
                    Me.browser.Select()
                End If

            Case Keys.Prior
                'Back
                Me.browser.GetBrowser.GoBack()
                'This probably doesn't do much. The buttons for Forward and Back are async set later that take focus back to the main form. This is probably best at this point, then the form's mouse events work for the 4th and 5th button's Forward and Back
                Me.browser.Select()

            Case Keys.Next
                'Forward
                Me.browser.GetBrowser.GoForward()
                Me.browser.Select()

            Case Keys.F12
                'Web Tools
                Me.browser.GetBrowser.GetHost.ShowDevTools()
        End Select
    End Sub
#End Region

#Region "Browser Window Controls"
    'Form focused keystroke events: Press ESC to cancel Navigation, F5 to Refresh, CTRL+F5 Refresh ignoring cache, CTRL+F for Find, ALT+Left for Navigate Back, ALT+Right for Navigate Forward, F12 for Web Tools
    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        FormKeyDownEvents(e)
    End Sub

    'NOTE: These form keypress events should match the equivalent events for the browser control events above (so they happen for whichever is active)
    Private Sub FormKeyDownEvents(ByRef e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                If Me.pnlFind.Visible = True Then
                    'ESC: Close find panel
                    btnFindClose_Click(Nothing, Nothing)
                    e.SuppressKeyPress = True
                Else
                    StopNavigaion()
                    e.SuppressKeyPress = True
                End If

            Case Keys.F5
                If e.Modifiers = Keys.Control Then
                    'Refresh ignoring browser cache
                    Me.browser.GetBrowser.Reload(True)
                    e.SuppressKeyPress = True
                Else
                    'Refresh
                    Me.browser.GetBrowser.Reload(False)
                    e.SuppressKeyPress = True
                End If

            Case Keys.F
                If e.Modifiers = Keys.Control Then
                    'Show the Find window
                    Me.pnlFind.Visible = True
                    FindTextInWebPage(True)
                    Me.txtFind.SelectAll()
                    e.SuppressKeyPress = True
                End If

            Case Keys.Left
                If e.Modifiers = Keys.Alt Then
                    'Back
                    Me.browser.GetBrowser.GoBack()
                    Me.browser.Select()
                    e.SuppressKeyPress = True
                End If

            Case Keys.Right
                If e.Modifiers = Keys.Alt Then
                    'Forward
                    Me.browser.GetBrowser.GoForward()
                    Me.browser.Select()
                    e.SuppressKeyPress = True
                End If

            Case Keys.Prior
                'Back. Can't differentiate between PageDown and Next, or PageUp and Prior keystrokes. Just focus the browser for a user retry
                Me.browser.Select()
                'Me.browser.GetBrowser.GoBack()
                'e.SuppressKeyPress = True

            Case Keys.Next
                'Forward. Can't differentiate between PageDown and Next, or PageUp and Prior keystrokes. Just focus the browser for a user retry
                Me.browser.Select()
                'Me.browser.GetBrowser.GoForward()
                'e.SuppressKeyPress = True

            Case Keys.F12
                'Web Tools
                Me.browser.GetBrowser.GetHost.ShowDevTools()
                e.SuppressKeyPress = True
        End Select
    End Sub

    'Mouse Forward and Back: Works where mouse location is. Works for the main form window (but not over the browser control area) when using the extra mouse programmable 4th and 5th buttons on the mouse
    Private Sub Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown,
            pnlURL.MouseDown, lblURL.MouseDown, txtURL.MouseDown, btnBack.MouseDown, btnFwd.MouseDown, btnGo.MouseDown, btnHome.MouseDown, btnReload.MouseDown, btnStopNav.MouseDown,
            pnlFind.MouseDown, txtFind.MouseDown, btnFindPrevious.MouseDown, btnFindNext.MouseDown, btnFindClose.MouseDown, pnlFindDivider.MouseDown, pnlBtnLinks.MouseDown, pnlBtnLinksDividerTop.MouseDown,
            btnFAHWebControl.MouseDown, btnFAHTwitter.MouseDown, btnFAHNews.MouseDown, btnFoldingCoinUserStats.MouseDown, btnEOC_UserStats.MouseDown, pbProgIcon.MouseDown,
            btnFoldingCoinWebsite.MouseDown, btnFoldingCoinTwitter.MouseDown, btnFoldingCoinDiscord.MouseDown, btnMyWallet.MouseDown, btnFoldingCoinBlockchain.MouseDown, btnBTCBlockchain.MouseDown, btnFoldingCoinDistribution.MouseDown, btnFoldingCoinShop.MouseDown, btnFoldingCoinTeamStats.MouseDown,
            btnCureCoinWebsite.MouseDown, btnCureCoinBlockchain.MouseDown, btnCureCoinDiscord.MouseDown, btnCureCoinTwitter.MouseDown, btnCurePool.MouseDown, btnCureCoinTeamStats.MouseDown,
            pnlBtnLinksDividerBottom.MouseDown, chkToolsShow.MouseDown, txtMsg.MouseDown, btnToolsBrowserTools.MouseDown, btnToolsGetFAH.MouseDown, btnToolsGetWallet.MouseDown, btnToolsFAHConfig.MouseDown, btnToolsCureCoinSetup.MouseDown,
            btnToolsOptions.MouseDown, btnToolsSavedData.MouseDown, lblToolsWalletNum.MouseDown, cbxToolsWalletId.MouseDown, txtToolsWalletName.MouseDown

        Select Case e.Button
            Case MouseButtons.XButton1
                'Back
                Me.browser.Select()
                Me.browser.GetBrowser.GoBack()
            Case MouseButtons.XButton2
                'Forward
                Me.browser.Select()
                Me.browser.GetBrowser.GoForward()
        End Select
    End Sub
    'Additionally for GroupBoxes (they seem like they are handled slightly differently, since the event name doesn't select the same in VS)
    Private Sub gbx_MouseDown(sender As Object, e As MouseEventArgs) Handles gbxFAHRelated.MouseDown, gbxFoldingCoinRelated.MouseDown, gbxCureCoinRelated.MouseDown, gbxTools.MouseDown
        Main_MouseDown(Nothing, e)
    End Sub

    Private Sub Main_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp,
            pnlURL.MouseUp, lblURL.MouseUp, txtURL.MouseUp, btnBack.MouseUp, btnFwd.MouseUp, btnGo.MouseUp, btnHome.MouseUp, btnReload.MouseUp, btnStopNav.MouseUp,
            pnlFind.MouseUp, txtFind.MouseUp, btnFindPrevious.MouseUp, btnFindNext.MouseUp, btnFindClose.MouseUp, pnlFindDivider.MouseUp,
            btnFAHWebControl.MouseUp, btnFAHTwitter.MouseUp, btnFAHNews.MouseUp, btnFoldingCoinUserStats.MouseUp, btnEOC_UserStats.MouseUp, pbProgIcon.MouseUp,
            btnFoldingCoinWebsite.MouseUp, btnFoldingCoinTwitter.MouseUp, btnFoldingCoinDiscord.MouseUp, btnMyWallet.MouseUp, btnFoldingCoinBlockchain.MouseUp, btnBTCBlockchain.MouseUp, btnFoldingCoinDistribution.MouseUp, btnFoldingCoinShop.MouseUp, btnFoldingCoinTeamStats.MouseUp,
            btnCureCoinWebsite.MouseUp, btnCureCoinBlockchain.MouseUp, btnCureCoinDiscord.MouseUp, btnCureCoinTwitter.MouseUp, btnCurePool.MouseUp, btnCureCoinTeamStats.MouseUp,
            pnlBtnLinksDividerBottom.MouseUp,
            lblToolsWalletNum.MouseUp
        'NOTE: Don't add the Tools buttons or controls to this event. If needed, those are handled in their button click events

        'Button Link Panel: Reset panel back to minimized
        Me.pnlBtnLinks.Height = m_iMinPanelHeight
    End Sub
    'Additionally for GroupBoxes (they seem like they are handled slightly differently, since the event name doesn't select the same in VS)
    Private Sub gbx_MouseUp(sender As Object, e As MouseEventArgs) Handles gbxFAHRelated.MouseUp, gbxFoldingCoinRelated.MouseUp, gbxCureCoinRelated.MouseUp, gbxTools.MouseUp
        Main_MouseUp(Nothing, Nothing)
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.browser.GetBrowser.GoBack()
    End Sub

    Private Sub btnFwd_Click(sender As System.Object, e As System.EventArgs) Handles btnFwd.Click
        Me.browser.GetBrowser.GoForward()
    End Sub

    'URL bar only: Open the URL if 'Enter' is pressed
    Private Sub txtURL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtURL.KeyDown
        If e.KeyCode = Keys.Enter Then
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            OpenURL(Me.txtURL.Text, True)
#Enable Warning BC42358
            e.SuppressKeyPress = True
        Else
            'See if there are other keystroke events that need to be handled
            FormKeyDownEvents(e)
        End If
    End Sub

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        OpenURL(Me.txtURL.Text, True)
#Enable Warning BC42358
    End Sub

    Private Sub btnStopNavigation_Click(sender As System.Object, e As System.EventArgs) Handles btnStopNav.Click
        StopNavigaion()
    End Sub

    Private Sub StopNavigaion()
        g_bCancelNav = True
        If Me.browser IsNot Nothing Then
            Me.browser.GetBrowser.StopLoad()
        End If
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        Me.browser.GetBrowser.Reload(True)
    End Sub

    Private Sub btnHome_Click(sender As System.Object, e As System.EventArgs) Handles btnHome.Click
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        LoadHomepage()
#Enable Warning BC42358
    End Sub

    Private Async Function LoadHomepage() As Threading.Tasks.Task(Of Boolean)
        Try
            'Make sure the INI key/value exists
            If INI.GetSection(INI_Settings).GetKey(INI_Homepage) Is Nothing Then
                'Add if it doesn't exist
                INI.AddSection(INI_Settings).AddKey(INI_Homepage).Value = HpgDefault
            End If

            'Load homepage / portal based on the user's options
            Select Case INI.GetSection(INI_Settings).GetKey(INI_Homepage).GetValue()
                Case HpgDefault
                    If m_bHomepage_TopAnBottomLoaded = False Then
                        CefSharp.WebBrowserExtensions.LoadHtml(Me.browser, HTML_Homepage_TopAndBottom, URL_Homepage_TopAndBottom)
                        m_bHomepage_TopAnBottomLoaded = True
                    Else
                        Await OpenURL(URL_Homepage_TopAndBottom, False)
                    End If

                Case HpgSideBySide
                    If m_bHomepage_SideBySideLoaded = False Then
                        CefSharp.WebBrowserExtensions.LoadHtml(Me.browser, HTML_Homepage_SideBySide, URL_Homepage_SideBySide)
                        m_bHomepage_SideBySideLoaded = True
                    Else
                        Await OpenURL(URL_Homepage_SideBySide, False)
                    End If

                Case HpgFoldingCoin
                    btnFoldingCoinWebsite_Click(Nothing, Nothing)

                Case HpgFoldingCoinMyStats
                    btnFoldingCoinUserStats_Click(Nothing, Nothing)

                Case HpgFoldingCoinTeamStats
                    btnFoldingCoinTeamStats_Click(Nothing, Nothing)

                Case HpgCureCoin
                    btnCureCoinWebsite_Click(Nothing, Nothing)

                Case HpgCureCoinTeamStatsEOC
                    btnCureCoinTeamStats_Click(Nothing, Nothing)

                Case HpgMyStatsEOC, HpgEOC
                    btnEOC_UserStats_Click(Nothing, Nothing)

                Case HpgFAH
                    btnFAHWebControl_Click(Nothing, Nothing)

                Case HpgNaClFAH
                    'TODO: Running the FAH NaCl plugin doesn't work yet
                    Await OpenURL(URL_NaCl_FAH, False)

                Case HpgBlank
                    Await OpenURL(URL_BLANK, False)

                Case Else
                    'Add if it doesn't exist
                    INI.AddSection(INI_Settings).AddKey(INI_Homepage).Value = HpgDefault
            End Select
            Return True

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Opening URL error: " & Err.Description
            Msg(sRtnErrMsg)
        End Try

        Return False
    End Function

    Private Async Sub pnlBtnLinks_MouseEnter(sender As Object, e As EventArgs) Handles pnlBtnLinks.MouseEnter
        'Skip, if already expanded
        If Me.pnlBtnLinks.Height <= m_iMinPanelHeight Then
            'Skip, if set in the options
            If g_bShowWebLinkPanelOnMouseEnterEvent = True Then
                'Button Link list: Mouse-over effect to expand area
                For m_iTempHeight = 20 To m_iTargetExpandedPanelHeight Step 20
                    Me.pnlBtnLinks.Height = m_iTempHeight
                    Await Wait(5)
                Next
                'Set to desired size, if it's not a multiple of 20
                Me.pnlBtnLinks.Height = m_iTargetExpandedPanelHeight
            End If
        End If
    End Sub

    Private Async Sub pnlBtnLinks_Click(sender As Object, e As EventArgs) Handles pnlBtnLinks.Click, pnlBtnLinksDividerTop.Click
        If Me.pnlBtnLinks.Height <= m_iMinPanelHeight Then
            'Button Link list: Mouse-over effect to expand area
            For m_iTempHeight = 20 To m_iTargetExpandedPanelHeight Step 20
                Me.pnlBtnLinks.Height = m_iTempHeight
                Await Wait(5)
            Next
            'Set to desired size, if it's not a multiple of 20
            Me.pnlBtnLinks.Height = m_iTargetExpandedPanelHeight
        Else
            'Minimize, if already expanded
            Me.pnlBtnLinks.Height = m_iMinPanelHeight
        End If
    End Sub

    Private Sub btnFindPrevious_Click(sender As Object, e As EventArgs) Handles btnFindPrevious.Click
        FindTextInWebPage(False)
    End Sub

    Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
        FindTextInWebPage(True)
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        FindTextInWebPage(True)
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If e.Shift = True Then
                    'Previous
                    FindTextInWebPage(False)
                Else
                    'Next
                    FindTextInWebPage(True)
                End If

            Case Keys.F3
                If e.Shift = True Then
                    'Previous
                    FindTextInWebPage(False)
                Else
                    'Next
                    FindTextInWebPage(True)
                End If

            Case Keys.Escape
                'ESC: Close find panel
                btnFindClose_Click(Nothing, Nothing)
        End Select
    End Sub

    Private m_bFirstFind As Boolean = True
    Private m_strFindText As String = ""
    Private Sub FindTextInWebPage(bNext As Boolean)
        If Me.txtFind.Text.Length > 0 Then
            'Has the find string changed?
            If m_strFindText = Me.txtFind.Text Then
                m_bFirstFind = False
            Else
                m_strFindText = Me.txtFind.Text
                m_bFirstFind = True
            End If
            'Find
            CefSharp.WebBrowserExtensions.Find(Me.browser, 0, m_strFindText, bNext, False, Not m_bFirstFind)

        Else
            CefSharp.WebBrowserExtensions.StopFinding(Me.browser, True)
            m_strFindText = ""
        End If
        Me.txtFind.Focus()
    End Sub

    Private Sub btnFindClose_Click(sender As Object, e As EventArgs) Handles btnFindClose.Click
        CefSharp.WebBrowserExtensions.StopFinding(Me.browser, True)
        m_strFindText = ""
        Me.pnlFind.Visible = False
    End Sub

    'Open URL with the specified settings
    Public Async Function OpenURL(sURL As String, Optional bShowErrorDialogBoxes As Boolean = False) As Threading.Tasks.Task(Of Boolean)
        Try
            'Load the web page
            If sURL.Length > 0 And Uri.IsWellFormedUriString(sURL, UriKind.RelativeOrAbsolute) = True Then
                'Blank out the page title, to allow it to be updated when the page loads for using PageTitleWait()
                Me.Text = ""
                'Update to the displayed text to the new URL
                Me.txtURL.Text = sURL

                'Accept Certs to avoid annoying prompts
                System.Net.ServicePointManager.ServerCertificateValidationCallback = New Net.Security.RemoteCertificateValidationCallback(AddressOf ValidateCertificate)

                'Focus the URL text box so the KeyPress events work for Enter / ESC.
                Me.txtURL.BackColor = Color.FromKnownColor(KnownColor.Window)
                Me.txtURL.Focus()
                Me.txtURL.Select(Me.txtURL.Text.Length, 0)
                'Reset flag
                m_bPageLoaded = False
                m_strPageURL = Me.txtURL.Text
                Me.browser.Load(Me.txtURL.Text)
                'Wait for the web page or 30 seconds
                Await PageLoadWait()

                Return True

            Else
                'Error
                Me.txtURL.BackColor = Color.Tomato
            End If

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Opening URL error: " & Err.Description
            Msg(sRtnErrMsg)

            If bShowErrorDialogBoxes = True Then 'Report errors 
                MessageBox.Show(sRtnErrMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

        Return False
    End Function

    'Wait for the page to load. Requires the AddHandler to be done before the page loading event, and then call this function.
    Public Async Function PageLoadWait() As Threading.Tasks.Task(Of Boolean)
        Try
            Dim i As Integer = 0
            'Wait for the web page, or 30 seconds
            Do Until m_bPageLoaded = True OrElse g_bCancelNav = True OrElse i > 300
                i += 1
                Await Wait(100)
            Loop
            g_bCancelNav = False

            If i < 300 Then Return True

        Catch ex As Exception
            Msg("Page Loading Wait error: " & Err.Description)
        End Try

        Return False
    End Function

    'Wait for the page title to load
    Public Async Function PageTitleWait(sPageTitle As String) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim i As Integer = 0
            'Wait for the webpage title, or 3 seconds
            For i = 0 To 30
                If Me.Text.Contains(sPageTitle) = True OrElse g_bCancelNav = True Then Exit For
                Await Wait(100)
            Next
            g_bCancelNav = False
            If i < 30 Then Return True

        Catch ex As Exception
            Msg("Page Title Wait error: " & Err.Description)
        End Try

        Return False
    End Function

    'Wait for No page title for page loading
    Public Async Function PageNoTitleWait() As Threading.Tasks.Task(Of Boolean)
        Try
            Dim i As Integer = 0
            'Wait for the web page title, or 3 seconds
            For i = 0 To 30
                If Me.Text.StartsWith(Prog_Name) = True OrElse g_bCancelNav = True Then Exit For
                Await Wait(100)
            Next
            g_bCancelNav = False
            If i < 30 Then Return True

        Catch ex As Exception
            Msg("Page No Title Wait error: " & Err.Description)
        End Try

        Return False
    End Function

    Public Function ValidateCertificate(sender As Object, certificate As Security.Cryptography.X509Certificates.X509Certificate, chain As Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean
        'Return True to force the certificate to be accepted.
        Return True
    End Function

    'Clear Web page
    Public Function ClearWebpage() As Boolean
        ClearWebpage = False
        Try
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            OpenURL(URL_BLANK, True)
#Enable Warning BC42358
            ClearWebpage = True

        Catch ex As Exception
            Msg("Opening URL error: " & Err.Description)
        End Try
    End Function
#End Region

#Region "Messages / Errors"
    Public Sub Msg(sMsg As String)
        Try
            Me.txtMsg.AppendText("[" & Now.ToString(LogDateTimeFormat) & "] " & sMsg & vbNewLine)
            If Me.txtMsg.Visible = True Then
                Me.txtMsg.ScrollToCaret()
            End If

        Catch ex As Exception
            Msg("Error: " & ex.Message & "." & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Sub
#End Region
End Class
