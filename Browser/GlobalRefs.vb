Public Module GlobalRefs
    Public g_Main As Main

    'Don't change this:
    Public Const Prog_Name As String = "FoldingBrowser"
    Public g_strTitleEnd As String = Prog_Name & " v" & My.Application.Info.Version.Major.ToString

    'Common URLs
    Public Const URL_BLANK As String = "about:blank"
    Public Const URL_Homepage_TopAndBottom As String = "data:home"
    Public Const URL_Homepage_SideBySide As String = "data:local"
    Public Const URL_Counterwallet As String = "https://wallet.counterwallet.io/"
    Public Const URL_Alt1Counterwallet As String = "https://eds.counterwallet.io/"
    Public Const CounterwalletAPI As String = "_api/"

    Public Const URL_FoldingCoin As String = "http://foldingcoin.net/"
    Public Const URL_FoldingCoinTwitter As String = "https://twitter.com/FoldingCoin/"
    Public Const URL_FLDC_DefaultBlockchain As String = "https://xchain.io/asset/FLDC"
    Public Const URL_FLDC_AddressBlockchain As String = "https://xchain.io/address/"
    Public Const URL_BTC_Blockchain As String = "https://www.blockchain.com/"
    Public Const URL_FLDC_Distro As String = "https://mergedfolding.net/distributions"
    Public Const URL_FoldingCoinDiscordInvite As String = "https://discord.gg/CvZ7gAs"
    Public Const URL_FoldingCoinDiscordRegister As String = "https://discordapp.com/register?redirect_to=%2Finvite%2FCvZ7gAs"
    Public Const URL_FoldingCoinDiscord As String = "https://discordapp.com/channels/379168590626029568/379168590626029571"
    Public Const URL_FoldingCoinStats As String = "https://stats.mergedfolding.net/"
    Public Const URL_FoldingCoinStatsUser As String = "member/"

    Public Const URL_CureCoin As String = "https://curecoin.net/"
    Public Const URL_CureCoinTwitter As String = "https://twitter.com/CureCoin_Team/"
    Public Const URL_CureCoinBlockchain As String = "https://chainz.cryptoid.info/cure/"
    Public Const URL_CureCoinFoldingPoolPage As String = "https://www.cryptobullionpools.com/"
    Public Const URL_CureCoinDiscordInvite As String = "https://discord.gg/jtztkFZ"
    Public Const URL_CureCoinDiscordRegister As String = "https://discordapp.com/register?redirect_to=%2Finvite%2FjtztkFZ"
    Public Const URL_CureCoinDiscord As String = "https://discordapp.com/channels/376037868826525707/376037869728563201"
    Public Const URL_CureCoin_EOC As String = "http://folding.extremeoverclocking.com/team_summary.php?s=&t=224497"

    Public Const URL_EOC As String = "http://folding.extremeoverclocking.com/user_summary.php?s=&u="

    Public Const URL_FAH As String = "https://foldingathome.org/"
    Public Const URL_FAH_DL As String = "start-folding/"
    Public Const URL_FAH_News As String = "news/"
    Public Const URL_FAHTwitter As String = "https://twitter.com/foldingathome/"
    Public Const URL_FAH_Passkey As String = "https://apps.foldingathome.org/getpasskey?name="
    Public Const URL_FAH_WebClient_URL As String = "http://client.foldingathome.org/"
    Public Const URL_FAH_WebClient_IPAddr As String = "http://127.0.0.1:7396/?nocache="
    Public Const URL_FAH_WebClient_ErrorAddr As String = "http://127.0.0.1:7396/js/main.js"

    'HTML from source code file: FoldingBrowser-SideBySide.html
    Public Const HTML_Homepage_SideBySide As String =
    "<html><head><title>FoldingBrowser - Earn Digital Assets with FoldingCoin and CureCoin</title></head>
    <body style='background-color:#000000;'>
        <a href='https://foldingcoin.net/' style='float:left;width:49%;height:98%;border-style:solid;border-width:1px;border-color:white;z-index:1;'>
            <span><object type='text/html' data='https://foldingcoin.net/' style='width:100%;height:100%;z-index:-1;pointer-events:none;'>FoldingCoin Homepage</object></span>
        </a>
        <a href='https://curecoin.net/' style='float:right;width:49%;height:98%;border-style:solid;border-width:1px;border-color:white;z-index:1;'>
            <span><object type='text/html' data='https://curecoin.net/' style='width:100%;height:100%;z-index:-1;pointer-events:none;'>CureCoin Homepage</object></span>
        </a>
    </body></html>"

    'HTML from source code file: FoldingBrowser-TopAndBottom.html
    Public Const HTML_Homepage_TopAndBottom As String =
    "<html><head><title>FoldingBrowser - Earn Digital Assets with FoldingCoin and CureCoin</title></head>
    <body style='background-color:#000000;'>
        <div style='float:left;width:100%;height:1%;z-index:1'></div>
        <a href='https://foldingcoin.net/' style='float:left;width:100%;height:48%;border-style:solid;border-width:1px;border-color:white;z-index:1;'>
            <span><object type='text/html' data='https://foldingcoin.net/' style='width:100%;height:100%;z-index:-1;pointer-events:none;'>FoldingCoin Homepage</object></span>
        </a>
        <div style='float:left;width:100%;height:2%;z-index:1'></div>
        <a href='https://curecoin.net/' style='float:left;width:100%;height:48%;border-style:solid;border-width:1px;border-color:white;z-index:1;'>
            <span><object type='text/html' data='https://curecoin.net/' style='width:100%;height:100%;z-index:-1;pointer-events:none;'>CureCoin Homepage</object></span>
        </a>
    </body></html>"

    'Encrypted DAT file password
    Public Const Default_DAT_PW As String = "(Default Password) If you change this line, remember to make backups. I can't restore it for you."

    Public Const Id As String = "Id"
    'Wallet Id specific
    Public Const DAT_BTC_Addr As String = "BTCAddress"
    Public Const DAT_CP12Words As String = "CounterParty12WordPassphrase"

    Public Const DAT_FAH_Username As String = "FAHUsername"
    Public Const DAT_FAH_Team As String = "FAHTeam"
    Public Const DAT_FAH_Passkey As String = "FAHPasskey"
    Public Const DAT_Email As String = "Email"

    Public Const DAT_CureCoin_Pwd As String = "CureCoinPoolPassword"
    Public Const DAT_CureCoin_Pin As String = "CureCoinPoolPin"
    Public Const DAT_CureCoin_Addr As String = "CureCoinAddress"

    Public Const DAT_DiscordEmail As String = "DiscordEmail"
    Public Const DAT_DiscordPassword As String = "DiscordPassword"

    Public Const DividerLine As String = "=============="
    Public Const SkipSavingDataFlag As String = "<Skip>"
    Public Const NotUsed As String = "<Not Used>"
    Public Const DefaultWalletName As String = "My Wallet #"

    Public INI As New IniFile
    Public Const INI_Settings As String = "Settings"
    Public Const INI_PW As String = "DatFilePassword"
    Public Const INI_Size As String = "Size"
    Public Const INI_WindowState As String = "WindowState"
    Public Const INI_LastWalletId As String = "LastWalletId"
    Public Const INI_LastBrowserVersion As String = "LastBrowserVersion"
    Public Const INI_HideSavedDataButton As String = "HideSavedDataButton"
    Public Const INI_Homepage As String = "Homepage"
    Public Const INI_ShowPanelOnMouseEnter As String = "ShowPanelOnMouseEnter"
    Public Const INI_DarkThemeUI As String = "DarkThemeUI"
    Public Const INI_RevCWServers As String = "RevCWServers"

    'Wallet Id specific
    Public Const INI_EOC_ID As String = "ExtremeOverclockingUserId"
    Public Const INI_WalletName As String = "WalletName"
    Public Const INI_DiscordInvites As String = "DiscordInvites"

    'Homepage Options List
    Public Const HpgDefault As String = "Default"
    Public Const HpgSideBySide As String = "Side-By-Side: FoldingCoin and CureCoin"
    Public Const HpgTopBottom As String = "Top-Bottom: FoldingCoin and CureCoin"
    Public Const HpgFoldingCoin As String = "FoldingCoin"
    Public Const HpgFoldingCoinTeamStats As String = "FoldingCoin: Team Stats"
    Public Const HpgFoldingCoinMyStats As String = "FoldingCoin: My Stats"
    Public Const HpgCureCoin As String = "CureCoin"
    Public Const HpgCureCoinTeamStatsEOC As String = "CureCoin: Team Stats from EOC"
    Public Const HpgMyStatsEOC As String = "My Stats from EOC"
    Public Const HpgEOC As String = "EOC"  'This is depreciated in v18(don't show in pull-down list). Use 'My Stats from EOC' instead
    Public Const HpgFAH As String = "Folding@Home Web Control"
    Public Const HpgBlank As String = "Blank"

    'Website title to search for
    Public Const NameCryptoBullions As String = "CryptoBullions"
    Public Const NameCounterwallet As String = "Counterwallet"
    'Search strings
    Public Const FAH_Version As String = "Version"
    Public Const FAH_Client As String = "FAHClient"
    Public Const FAH_Core As String = "fahcore_"

    Public UserProfileDir As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Prog_Name)
    Public IniFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".ini")
    Public DatFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".dat")
    Public LogFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".txt")

    'Font scalar for resizing the entire for for different scaling percentages
    Public Const DefaultFontScalar As Single = 1.0!
    Public g_sScaleFactor As Single = 1.0!
    'Cancel navigation / downloads indicator
    Public g_bCancelNav As Boolean = False
    Public g_bAskDownloadLocation As Boolean = True
    'Holds on to the last downloaded file path, when the download completes
    Public g_strDownloadedFilePath As String = ""
    'CounterWallet
    Public g_bRevCWServers As Boolean = True

    'Option to Show the Web Link Panel On MouseEnter Event
    Public g_bShowWebLinkPanelOnMouseEnterEvent As Boolean = True

    'Event logging date-time stamp format string
    Public Const LogDateTimeFormat As String = "yyyy-MM-dd HH:mm:ss.f"

    Public Function SaveLogFile(ByRef strMsg As String) As Boolean
        SaveLogFile = False
        Dim twLog As System.IO.TextWriter = Nothing
        Try
            'Create a Log File Directory, if needed
            If System.IO.Directory.Exists(UserProfileDir) = False Then
                System.IO.Directory.CreateDirectory(UserProfileDir)
            End If

            'Create a new text file
            twLog = System.IO.File.CreateText(LogFilePath)

            'Add data
            twLog.Write(strMsg)

            'Flush the text to the file 
            twLog.Flush()

            SaveLogFile = True

        Catch ex As Exception
            MessageBox.Show("Saving Log File Error: " & ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Close the File 
            If twLog IsNot Nothing Then
                twLog.Close()
            End If
        End Try
    End Function

#Region "Wait (Milliseconds)"
    Public Async Function Wait(iMilSec As Integer) As Threading.Tasks.Task
        Await Threading.Tasks.Task.Delay(iMilSec)
    End Function

    'Simple delay using DoEvents
    Public Sub Delay(iMilSec As Integer)
        Dim time As Date = Now.AddMilliseconds(iMilSec)
        Do While time > Now
            Application.DoEvents()
        Loop
    End Sub
#End Region
End Module


'Authentication / Login Credentials, See: https://github.com/cefsharp/CefSharp/blob/master/CefSharp.Example/RequestEventHandler/RequestEventHandler.cs
<CLSCompliant(False)> Public Class MyRequestHandler
    Inherits CefSharp.Handler.RequestHandler

    Public m_strUser As String = String.Empty
    Public m_strPwd As String = String.Empty
    Public m_bPropmtForCredentials As Boolean = True

    'Login Credentials needed from the user. Return true to continue the request, get credentials if needed, then call callback.Continue(Username, Password). Return false to cancel the request.
    Protected Overrides Function GetAuthCredentials(chromiumWebBrowser As CefSharp.IWebBrowser, browser As CefSharp.IBrowser, originUrl As String, isProxy As Boolean, host As String, port As Integer, realm As String, scheme As String, callback As CefSharp.IAuthCallback) As Boolean
        Dim bReturn As Boolean = False

        'Manual browsing (not automated). Preload the message box defaults with the username and password before calling this
        If m_bPropmtForCredentials = True Then
            'Message box prompt to get credentials
            Dim TxtEntry As New TextEntryDialog
            TxtEntry.Text = "Enter User/PW"
            TxtEntry.MsgTextUpper.Text = "Enter Username (Top text box):"
            TxtEntry.MsgTextLower.Text = "And Password (Bottom text box):"

            TxtEntry.TextEnteredUpper.TextAlign = HorizontalAlignment.Center
            TxtEntry.TextEnteredLower.TextAlign = HorizontalAlignment.Center
            'Setup password text box
            TxtEntry.TextEnteredLower.Visible = True
            TxtEntry.TextEnteredLower.PasswordChar = "*"c
            'Set default values
            TxtEntry.TextEnteredUpper.Text = m_strUser
            TxtEntry.TextEnteredLower.Text = m_strPwd
            'Adjust the width of the dialog box
            TxtEntry.Width = (TxtEntry.MsgTextLower.Left * 2) + TxtEntry.MsgTextLower.Width + 50
            TxtEntry.TextEnteredLower.Visible = True
            TxtEntry.MsgTextExtraBottomNote.Visible = False
            TxtEntry.ActiveControl = TxtEntry.TextEnteredUpper
            TxtEntry.StartPosition = FormStartPosition.CenterScreen

            'Show modal dialog box
            If TxtEntry.ShowDialog() = DialogResult.OK Then
                m_strUser = TxtEntry.TextEnteredUpper.Text
                m_strPwd = TxtEntry.TextEnteredLower.Text

                'Send credentials to load the web page
                callback.Continue(m_strUser, m_strPwd)
                'Reset value
                m_strPwd = String.Empty
                'Good
                bReturn = True
            Else
                'Invalid credentials
                g_Main.Msg("Error: Invalid credentials: Dialog canceled")
                bReturn = False
            End If
            TxtEntry.Dispose()

        Else
            'Automated: Set m_bPropmtForCredentials = false, and the username and password before loading the URL
            If m_strUser.Length > 0 AndAlso m_strPwd.Length > 0 Then
                callback.Continue(m_strUser, m_strPwd)
                'Good
                bReturn = True
            Else
                'Invalid credentials
                g_Main.Msg("Error:Invalid credentials: Username or password were blank")
                bReturn = False
            End If
        End If

        Return bReturn
    End Function

    'Not used. Instead using the browser initialization: settings.CefCommandLineArgs.Add("ignore-certificate-errors")
    ''Handles requests for URLs with an invalid SSL certificate.  Return true and call CefSharp.IRequestCallback.Continue(System.Boolean) either in this method or at a later time to continue or cancel the request. If "ignore-certificate-errors" is used, then all invalid certificates will be accepted without calling this.
    'Protected Overrides Function OnCertificateError(ByVal browserControl As CefSharp.IWebBrowser, ByVal browser As CefSharp.IBrowser, ByVal errorCode As CefSharp.CefErrorCode, ByVal requestUrl As String, ByVal sslInfo As CefSharp.ISslInfo, ByVal callback As CefSharp.IRequestCallback) As Boolean
    '    Return True
    'End Function
End Class


'File download, see: https://github.com/cefsharp/CefSharp/blob/master/CefSharp.Example/DownloadHandler.cs
Public Class DownloadHandler
    Implements CefSharp.IDownloadHandler
    <CLSCompliant(False)> Public Sub OnBeforeDownload(webBrowser As CefSharp.IWebBrowser, browser As CefSharp.IBrowser, downloadItem As CefSharp.DownloadItem, callback As CefSharp.IBeforeDownloadCallback) Implements CefSharp.IDownloadHandler.OnBeforeDownload
        'Reset the downloaded file path at the start of downloading the file
        g_strDownloadedFilePath = ""
        g_bCancelNav = False

        If callback.IsDisposed = False Then
            'For g_bAskDownloadLocation = true, then show the download location dialog, otherwise don't
            callback.Continue(System.IO.Path.Combine(UserProfileDir, "Cache", downloadItem.SuggestedFileName), g_bAskDownloadLocation)
        End If
    End Sub

    <CLSCompliant(False)> Public Sub OnDownloadUpdated(webBrowser As CefSharp.IWebBrowser, browser As CefSharp.IBrowser, downloadItem As CefSharp.DownloadItem, callback As CefSharp.IDownloadItemCallback) Implements CefSharp.IDownloadHandler.OnDownloadUpdated
        If callback.IsDisposed = False Then
            'Stop the download if Navigation canceled or <Esc> was pressed
            If g_bCancelNav = True Then
                callback.Cancel()
            End If
        End If

        'Update the download progress bar in the UI
        g_Main.updateDownload(downloadItem.PercentComplete, downloadItem.IsComplete, downloadItem.IsCancelled)

        If downloadItem.IsComplete = True Then
            'Set the downloaded file path 
            g_strDownloadedFilePath = downloadItem.FullPath
        End If
    End Sub
End Class


'Keypress example, see: https://github.com/cefsharp/CefSharp/blob/master/CefSharp.WinForms.Example/Handlers/KeyboardHandler.cs
Public Class KeyboardHandler
    Implements CefSharp.IKeyboardHandler
    <CLSCompliant(False)> Public Function OnPreKeyEvent(browserControl As CefSharp.IWebBrowser, browser As CefSharp.IBrowser, type As CefSharp.KeyType, windowsKeyCode As Integer, nativeKeyCode As Integer, modifiers As CefSharp.CefEventFlags, isSystemKey As Boolean, ByRef isKeyboardShortcut As Boolean) As Boolean Implements CefSharp.IKeyboardHandler.OnPreKeyEvent
        If type = CefSharp.KeyType.RawKeyDown Then
            Select Case windowsKeyCode
                'Browser active control event: Press ESC to cancel Navigation, F5 to Refresh, CTRL+F5 to Clear Cache, ALT+Left for Navigate Back, ALT+Right for Navigate Forward, F12 for Web Tools
                Case Keys.Right, Keys.Left
                    If modifiers = CefSharp.CefEventFlags.AltDown Then
                        g_Main.updateKeyPress(windowsKeyCode, modifiers)
                        Return True
                    End If
                Case Keys.F
                    If modifiers = CefSharp.CefEventFlags.ControlDown Then
                        g_Main.updateKeyPress(windowsKeyCode, modifiers)
                        Return True
                    End If
                Case Keys.Escape, Keys.F5, Keys.F12
                    g_Main.updateKeyPress(windowsKeyCode, modifiers)
                    Return True
                Case Keys.Prior, Keys.Next
                    'Mouse Forward and Back "keystroke" shortcut buttons: Differentiate between PageDown and Next, or PageUp and Prior keystrokes
                    If nativeKeyCode = 16777217 Then
                        g_Main.updateKeyPress(windowsKeyCode, modifiers)
                        Return True
                    End If
            End Select
        End If

        Return False
    End Function

    <CLSCompliant(False)> Public Function OnKeyEvent(browserControl As CefSharp.IWebBrowser, browser As CefSharp.IBrowser, type As CefSharp.KeyType, windowsKeyCode As Integer, nativeKeyCode As Integer, modifiers As CefSharp.CefEventFlags, isSystemKey As Boolean) As Boolean Implements CefSharp.IKeyboardHandler.OnKeyEvent
        Return False
    End Function
End Class