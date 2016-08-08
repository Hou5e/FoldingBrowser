Public Class Main
    Private Const URL_BLANK As String = "about:blank"
    Private Const URL_Counterwallet As String = "https://wallet.counterwallet.io/"
    Private Const URL_FoldingCoin As String = "http://foldingcoin.net/"
    Private Const URL_FLDC_Distro As String = "http://joelooney.org/fldc/?token=FLDC&total=500000&start=2016-08-05&end=2016-08-06"
    Private Const URL_CureCoin As String = "https://www.curecoin.net/"
    Private Const URL_FAH As String = "http://folding.stanford.edu/"
    Private Const URL_FAH_Client As String = "http://folding.stanford.edu/client/"

    Private WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser

    'Page loaded indicator
    Private m_bPageLoaded As Boolean = False
    'URL to help determine the page loaded indicator
    Private m_strPageURL As String = ""

    Public Sub New()
        InitializeComponent()

        Try
            Me.Icon = My.Resources.IconFLDC
            Me.Text = Prog_Name & " v" & My.Application.Info.Version.Major

            'Global reference to this form
            g_Main = Me

            'Look to see if there is an INI file first
            If System.IO.File.Exists(IniFilePath) = True Then
                INI.Load(IniFilePath)
                'Restore dimensions from string: {Left};{Top};{Width};{Height}
                Dim strDim As String() = INI.GetSection(INI_Settings).GetKey(INI_Size).GetValue().Split(";"c)
                Me.Left = CInt(strDim(0))
                Me.Top = CInt(strDim(1))
                Me.Width = CInt(strDim(2))
                Me.Height = CInt(strDim(3))
            Else
                'Create folder for user info, if it doesn't exist
                If System.IO.Directory.Exists(UserProfileDir) = False Then
                    My.Computer.FileSystem.CreateDirectory(UserProfileDir)
                End If
                'Create a new INI for first time use. Set the default encryption PW
                INI.AddSection(INI_Settings).AddKey(INI_PW).Value = "(Default Password) If you change this line, remember to make backups. I can't restore it for you."
                'Store window size: {Left};{Top};{Width};{Height}
                INI.AddSection(INI_Settings).AddKey(INI_Size).Value = Me.Left.ToString() & ";" & Me.Top.ToString() & ";" & Me.Width.ToString() & ";" & Me.Height.ToString()
                INI.Save(IniFilePath)
            End If

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
            'FLDC Image
            Me.PictureBox1.Image = My.Resources.IconFLDC.ToBitmap

            'TODO: not used yet. Process command line values
            If Environment.CommandLine.Length > 0 Then
                'MessageBox.Show(Environment.CommandLine.ToString)
                Dim args As String() = Environment.GetCommandLineArgs()
                If args.Length > 1 Then
                    Select Case args(1)
                        Case "-InstFAH-Only"
                            'TODO: FAH Installation

                        Case "-GetFLDCWallet"
                            'TODO: Get Wallet
                    End Select
                End If
            End If

#If DEBUG Then
            'Debug: show Dev Tools
            Me.chkShowTools.Checked = True
            chkShowTools_CheckedChanged(Nothing, Nothing)
#Else
            'Release: hide Dev Tools by default
            Me.chkShowTools.Checked = False
#End If

        Catch ex As Exception
            Me.txtMsg.Text = "Error: Webpage initization failed"
        End Try
    End Sub

    Private Sub onBrowserFrameLoadEnd(ByVal sender As Object, ByVal e As CefSharp.FrameLoadEndEventArgs)
        'Set a flag to indicate the webpage has finished loading. This event is fired for each frame that loads, so compare URLs before setting the flag as loaded (NOTE: Me.browser.IsLoading = True, doesn't work)
        If e.Url.Contains(m_strPageURL) Then
            m_bPageLoaded = True
        End If
    End Sub

    Private Sub onBrowserConsoleMessage(ByVal sender As Object, ByVal e As CefSharp.ConsoleMessageEventArgs)
        If e.Line > 0 Then
            addActivity(e.Message & " (" & e.Source & ", ln " & e.Line.ToString & " )")
        Else
            addActivity(e.Message)
        End If
    End Sub
    Private Sub OnBrowserStatusMessage(sender As Object, args As CefSharp.StatusMessageEventArgs)
        addActivity(args.Value)
    End Sub
    Private Sub addActivity(ByVal Message As String)
        Me.Invoke(Sub()
                      Me.txtMsg.AppendText(Message & vbCrLf)
                  End Sub)
    End Sub

    Private Sub OnBrowserLoadingStateChanged(sender As Object, args As CefSharp.LoadingStateChangedEventArgs)
        enableButtons(args.CanGoForward, args.CanGoBack, Not args.CanReload)
    End Sub
    Private Sub enableButtons(ByVal bForward As Boolean, ByVal bBack As Boolean, ByVal bLoading As Boolean)
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
    Private Sub updateTitle(ByVal strTitle As String)
        Me.Invoke(Sub()
                      Me.Text = If(strTitle.Length = 0, "", strTitle & " - ") & Prog_Name & " v" & My.Application.Info.Version.Major
                  End Sub)
    End Sub

    Private Sub OnBrowserAddressChanged(sender As Object, args As CefSharp.AddressChangedEventArgs)
        updateURL(args.Address)
    End Sub
    Private Sub updateURL(ByVal strURL As String)
        Me.Invoke(Sub()
                      Me.txtURL.Text = strURL
                      m_strPageURL = strURL
                  End Sub)
    End Sub

    Public Sub updateDownload(ByVal iPercent As Integer, ByVal bComplete As Boolean, ByVal bCancelled As Boolean)
        Me.Invoke(Sub()
                      'Show when download starts
                      If Me.gbxDownload.Visible = False Then
                          Me.gbxDownload.Visible = True
                          Me.btnStopNav.Enabled = True
                      End If

                      'Update status
                      Me.ProgressBar1.Value = iPercent
                      Me.lblPercent.Text = iPercent.ToString & "%"

                      'When complete, reset the statusbar
                      If bComplete = True OrElse bCancelled = True Then
                          Me.gbxDownload.Visible = False
                          Me.ProgressBar1.Value = 0
                          Me.lblPercent.Text = ""
                          Me.btnStopNav.Enabled = False
                          g_bCancelNav = False
                          g_bAskDownloadLocation = True
                      End If
                  End Sub)
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Skip saving the window position, if closed while being minimized or full screen
        If Me.WindowState = FormWindowState.Normal Then
            'Store window size: {Left};{Top};{Width};{Height}
            INI.AddSection(INI_Settings).AddKey(INI_Size).Value = IIf(Me.Left < 0, "0", Me.Left).ToString() & ";" & IIf(Me.Top < 0, "0", Me.Top).ToString() & ";" & IIf(Me.Width < 700, "700", Me.Width).ToString() & ";" & IIf(Me.Height < 500, "500", Me.Height).ToString()
            INI.Save(IniFilePath)
        End If

        If Me.browser IsNot Nothing Then
            RemoveHandler Me.browser.FrameLoadEnd, AddressOf onBrowserFrameLoadEnd
            RemoveHandler Me.browser.ConsoleMessage, AddressOf onBrowserConsoleMessage
            RemoveHandler Me.browser.StatusMessage, AddressOf OnBrowserStatusMessage
            RemoveHandler Me.browser.LoadingStateChanged, AddressOf OnBrowserLoadingStateChanged
            RemoveHandler Me.browser.TitleChanged, AddressOf OnBrowserTitleChanged
            RemoveHandler Me.browser.AddressChanged, AddressOf OnBrowserAddressChanged

            'Shutdown the web browser control
            CefSharp.Cef.Shutdown()

            'This 100ms delay seems to help prevent the messed up state where the cache needs to be deleted for the FAH Control webpage (atleast with CEF1)
            Wait(100)
        End If
    End Sub

#Region "Checkbox Events"
    Private Sub chkShowTools_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowTools.CheckedChanged
        If Me.chkShowTools.Checked = True Then
            Me.gbxTools.Visible = True
            Me.txtMsg.Visible = True
        Else
            Me.gbxTools.Visible = False
            Me.txtMsg.Visible = False
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btnLogIntoWallet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIntoWallet.Click
        If LoginToCounterwallet() = False Then MsgBox("Task 'Log Into Wallet' did not complete. Please try again.")
    End Sub

    Private Sub btnFAHControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFAHControl.Click
        OpenURL(URL_FAH_Client, False)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        OpenURL(URL_FoldingCoin, False)
    End Sub

    Private Sub btnFoldingCoinWebsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoldingCoinWebsite.Click
        OpenURL(URL_FoldingCoin, False)
    End Sub

    Private Sub btnFLDC_DailyDistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFLDC_DailyDistro.Click
        OpenURL(URL_FLDC_Distro, False)
    End Sub

    Private Sub btnCureCoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCureCoin.Click
        OpenURL(URL_CureCoin, False)
    End Sub

    'TODO: add button to Extreme Overclocking's User Stats page. Would need to know user ID #...

    Private Sub btnGetWallet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetWallet.Click
        If GetWallet() = False Then MsgBox("Task 'Get Wallet' did not complete.")
    End Sub

    Private Sub btnGetFAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetFAH.Click
        If GetFAH() = False Then MsgBox("Task 'Get Folding@Home App' did not complete.")
    End Sub

    Private Sub btnBrowserTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowserTools.Click
        Me.browser.GetBrowser.GetHost.ShowDevTools()
    End Sub
#End Region

#Region "Automated Processes"
    Private Function LoginToCounterwallet() As Boolean
        LoginToCounterwallet = False

        Try
            'Counterwallet webpage 
            OpenURL(URL_Counterwallet, False)
            PageTitleWait("Counterwallet")
            Wait(700)

            'Make sure Dat file exists
            Dim bDatFile As Boolean = System.IO.File.Exists(DatFilePath)
            'If there is no Dat file, then prompt to make one
            If bDatFile = False Then
                'Prompt for PW, and save it
                Dim Msg As New TextEntryDialog
                Msg.Text = "Save Wallet Password"
                Msg.MsgTextUpper.Text = "No saved wallet info yet."
                Msg.MsgTextLower.Text = "Please enter your 12 word passphrase:"
                Msg.Width = (Msg.MsgTextLower.Left * 2) + Msg.MsgTextLower.Width + 10
                Msg.TextEnteredLower.Visible = False
                'Show modal dialog box
                If Msg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'Save and encrypt 12 word passphase (or use username & PW?)
                    Dim bPWSaved As Boolean = SaveWalletPW(0, Msg.TextEnteredUpper.Text, "", "")
                    'Allow time for the file to be written out
                    Wait(100)
                    If bPWSaved = True AndAlso System.IO.File.Exists(DatFilePath) = True Then bDatFile = True
                End If
            End If

            'Login using the info from the Dat file
            If bDatFile = True Then
                Dim DAT As New IniFile
                'Load DAT file, decrypt it, load INI info
                DAT.LoadText(Decrypt(LoadDat))
                If DAT.ToString.Length = 0 Then
                    'Decryption failed

                End If
                'Enter 12 Word Passphrase to login
                EnterTextById("password", DAT.GetSection(DAT_FLDC).GetKey("0" & DAT_12W).GetValue())
                Wait(50)
                DAT = Nothing

                'Trigger event to enable the Login button, since there was no keystroke event to enable the button
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("ko.utils.triggerEvent(document.getElementById('password'), 'input');")

                'Click Login button
                ClickById("walletLoginButton", True)

                LoginToCounterwallet = True
            End If

        Catch ex As Exception
            Me.txtMsg.Text = "Auto Wallet error:" & ex.ToString

            'User info decryption failed, most likely. Prompt for new info
            Dim Msg As New TextEntryDialog
            Msg.Text = "Save Wallet Password"
            Msg.MsgTextUpper.Text = "Wallet info could not be decrypted."
            Msg.MsgTextLower.Text = "Please enter your 12 word passphrase:"
            Msg.Width = (Msg.MsgTextLower.Left * 2) + Msg.MsgTextLower.Width + 10
            Msg.TextEnteredLower.Visible = False
            'Show modal dialog box
            If Msg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Save and encrypt 12 word passphase (or use username & PW?)
                Dim bPWSaved As Boolean = SaveWalletPW(0, Msg.TextEnteredUpper.Text, "", "")
                'Allow time for the file to be written out
                Wait(100)
            End If
        End Try
    End Function
#End Region

#Region "Automated Processes - One time only for setup"
    Private Function GetWallet() As Boolean
        GetWallet = False

        Try
            'Counterwallet webpage 
            OpenURL(URL_Counterwallet, False)
            PageTitleWait("Counterwallet")
            Wait(700)

            'Click Create New Counterwallet
            ClickById("newWalletButton", False)


            'TODO: Is PW OK before proceeding


            'TODO: Allow for muliple PW, for multiple accounts (Don't overwrite? or Ask first...)


            'TODO: Look to see if there is an INI file first


            'Save and encrypt 12 word passphase (or use username & PW?) to Dat file
            'SaveWalletPW(0, "Set 12 Word PW Here", "", "")

            GetWallet = True

        Catch ex As Exception
            Me.txtMsg.Text = "Get Wallet error:" & ex.ToString
        End Try
    End Function

    Private Function SaveWalletPW(ByRef index As Integer, ByRef PW12words As String, ByRef URL As String, ByRef URL_PW As String) As Boolean
        SaveWalletPW = False

        Try
            'Save and encrypt 12 word passphase (or use username & PW?) to Dat file
            Dim DAT As New IniFile
            DAT.AddSection(DAT_FLDC).AddKey(index.ToString & DAT_12W).Value = PW12words
            DAT.AddSection(DAT_FLDC).AddKey(index.ToString & DAT_URL).Value = URL
            DAT.AddSection(DAT_FLDC).AddKey(index.ToString & DAT_PW).Value = URL_PW

            'Create text from the INI, Encrypt, and Write/flush DAT text to file
            SaveDat(Encrypt(DAT.SaveToString))
            DAT = Nothing

            SaveWalletPW = True

        Catch ex As Exception
            Me.txtMsg.Text = "Error creating Dat file:" & ex.ToString
        End Try
    End Function

    Private Function GetFAH() As Boolean
        GetFAH = False

        Try
            'Detect FAH installed already, and give the option to skip over re-downloading and running the installer


            'Get Folding@Home App
            OpenURL(URL_FAH, False)
            PageTitleWait("Folding@home")
            Wait(100)

            'Get EXE file name to execute
            Dim FileURL As String = ""

            'Click the link for Windows download (This initial step appears to be needed? even though the link is in the HTML)
            ClickByClass("download-btn", False, FileURL)
            Wait(200)

            'Start the download: Click the link for Windows download
            g_bAskDownloadLocation = False
            ClickByClass("fah-platform-downloads", False, FileURL)
            Wait(200)

            'Close the download popup window
            ClickByClass("modalCloseImg simplemodal-close", False, FileURL)

            'Is the download done?
            Dim i As Integer = 0
            'Wait for the webpage, or 2 hours
            Do Until Me.gbxDownload.Visible = False OrElse g_bCancelNav = True OrElse i > 2400
                i += 1
                Wait(500)
            Loop
            g_bCancelNav = False
            'Download didn't finish or was cancelled
            If i >= 2400 Then Exit Try

            'Run FAH installer
            ' = g_strDownloadPath


            'Kill any running instances of FAH.


            'Prompt for FAH info: Email, to get Passcode. Ask for: (existing) username, Merged Folding Coin Selection, team #, passcode, and how many CPU / GPU.


            'Find the location of the FAH Config file, save a backup copy, and re-write a new cfg file.


            'Launch FAH (restart should not be required)


            GetFAH = True

        Catch ex As Exception
            Me.txtMsg.Text = "Get FAH error:" & ex.ToString
        End Try

        'Reset flag
        g_bAskDownloadLocation = True
    End Function
#End Region

#Region "Browser Commands"
    'Specify text box {Object Id}, and text to enter in to the textbox
    Private Function EnterTextById(ByVal ObjectId As String, ByVal sText As String) As Boolean
        EnterTextById = False

        If ObjectId.Length > 0 Then
            Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('" & ObjectId & "').value = '" & sText & "';")
            EnterTextById = True
        End If
    End Function

    'Specify object {Object Id} to click, and if you wait for the page to load or not
    Private Function ClickById(ByVal ObjectId As String, ByVal bWait As Boolean) As Boolean
        ClickById = False

        If ObjectId.Length > 0 Then
            Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('" & ObjectId & "').click();")
            ClickById = True
            'Wait for the page, if specified
            If bWait = True Then
                If PageLoadWait() = True Then ClickById = True Else ClickById = False
            End If
        End If
    End Function

    'Specify object {Class} to click, and if you wait for the page to load or not
    Private Function ClickByClass(ByVal ClassName As String, ByVal bWait As Boolean, ByRef href As String) As Boolean
        ClickByClass = False
        Try
            If ClassName.Length > 0 Then
                'Get the href URL
                href = Me.browser.GetBrowser.MainFrame.EvaluateScriptAsync("document.getElementsByClassName('" & ClassName & "')[0].attributes.getNamedItem('href').value;").ToString
                'Click it
                Me.browser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("document.getElementsByClassName('" & ClassName & "')[0].click();")
                ClickByClass = True
                'Wait for the page, if specified
                If bWait = True Then
                    If PageLoadWait() = True Then ClickByClass = True Else ClickByClass = False
                End If
            End If

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Browser Controls"
    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        Me.browser.GetBrowser.Reload(True)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.browser.GetBrowser.GoBack()
    End Sub

    Private Sub btnFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFwd.Click
        Me.browser.GetBrowser.GoForward()
    End Sub

    'After entering the URL: Open the URL if 'Enter' is pressed, or Cancel navigation if ESC is pressed.
    Private Sub txtURL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtURL.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            OpenURL(Me.txtURL.Text, True)

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            StopNavigaion()
        End If
    End Sub

    Private Sub btnStopNavigation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopNav.Click
        StopNavigaion()
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        OpenURL(Me.txtURL.Text, True)
    End Sub

    'Open URL with the specified settings
    Public Function OpenURL(ByRef sURL As String, Optional ByVal bShowErrorDialogBoxes As Boolean = False) As Boolean
        OpenURL = False
        Try
            'Load the webpage
            If sURL.Length > 0 And Uri.IsWellFormedUriString(sURL, UriKind.RelativeOrAbsolute) = True Then
                Me.txtURL.Text = sURL

                'Accept Certs to avoid annoying prompts
                System.Net.ServicePointManager.ServerCertificateValidationCallback = New Net.Security.RemoteCertificateValidationCallback(AddressOf ValidateCertificate)

                'Focus the URL textbox so the KeyPress events work for Enter / ESC.
                Me.txtURL.BackColor = Color.White
                Me.txtURL.Focus()
                Me.txtURL.Select(Me.txtURL.Text.Length, 0)
                'Reset flag
                m_bPageLoaded = False
                m_strPageURL = Me.txtURL.Text
                Me.browser.Load(Me.txtURL.Text)
                'Wait for the webpage or 1 minute
                PageLoadWait()

                OpenURL = True

            Else
                'Error
                Me.txtURL.BackColor = Color.Red
            End If

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Opening URL error: " & Err.Description
            Console.WriteLine(sRtnErrMsg)

            If bShowErrorDialogBoxes = True Then 'Report errors 
                MsgBox(sRtnErrMsg, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Function

    'Wait for the page to load. Requires the AddHandler to be done before the page loading event, and then call this function.
    Public Function PageLoadWait() As Boolean
        PageLoadWait = False
        Try
            Dim i As Integer = 0
            'Wait for the webpage, or 1 minute
            Do Until m_bPageLoaded = True OrElse g_bCancelNav = True OrElse i > 600
                i += 1
                Wait(100)
            Loop
            g_bCancelNav = False

            If i < 600 Then PageLoadWait = True

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Page Loading Wait error: " & Err.Description
            Console.WriteLine(sRtnErrMsg)
        End Try
    End Function

    'Wait for the page title to load
    Public Function PageTitleWait(ByRef sPageTitle As String) As Boolean
        PageTitleWait = False
        Try
            Dim i As Integer = 0
            'Wait for the webpage title, or 3 seconds
            For i = 0 To 30
                'If Me.browser.GetBrowser.Title.Contains(sPageTitle) = True OrElse g_bCancelNav = True Then Exit For
                Wait(100)
            Next
            g_bCancelNav = False
            If i < 30 Then PageTitleWait = True

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Page Title Wait error: " & Err.Description
            Console.WriteLine(sRtnErrMsg)
        End Try
    End Function

    Private Sub StopNavigaion()
        If Me.browser IsNot Nothing Then
            g_bCancelNav = True
            Me.browser.GetBrowser.StopLoad()
        End If
    End Sub

    Public Function ValidateCertificate(ByVal sender As Object, ByVal certificate As Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean
        'Return True to force the certificate to be accepted.
        Return True
    End Function

    'Clear Webpage
    Public Function ClearWebpage() As Boolean
        ClearWebpage = False
        Try
            OpenURL(URL_BLANK, True)
            ClearWebpage = True

        Catch ex As Exception
            Dim sRtnErrMsg As String = "Opening URL error: " & Err.Description
            Console.WriteLine(sRtnErrMsg)
        End Try
    End Function
#End Region

#Region "Wait (Milliseconds)"
    Dim iWaits As Integer = 0
    Private Sub Wait(ByVal iMilSec As Integer)
        If iMilSec > 0 Then
            'Split the time interval up into 50ms intervals to allow the program to update for DoEvents
            iWaits = iMilSec \ 50

            For i As Integer = 1 To iWaits
                System.Windows.Forms.Application.DoEvents()
                'Test for closing app
                If System.Windows.Forms.Application.OpenForms.Count = 0 Then Exit For
                'Test for Stop button being pressed
                If g_bCancelNav = True Then Exit For
                'Sleep to free up system resources
                Threading.Thread.Sleep(50)
            Next
        End If
    End Sub
#End Region
End Class
