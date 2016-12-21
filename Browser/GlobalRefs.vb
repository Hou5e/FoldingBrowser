Public Module GlobalRefs
    Public g_Main As Main

    'Don't change this:
    Public Const Prog_Name As String = "FoldingBrowser"

    'Common URLs
    Public Const URL_BLANK As String = "about:blank"
    Public Const URL_Counterwallet As String = "https://wallet.counterwallet.io/"
    Public Const URL_FoldingCoin As String = "http://foldingcoin.net/"
    Public Const URL_Twitter_FoldingCoin As String = "https://twitter.com/FoldingCoin"
    Public Const URL_BlockchainFLDC As String = "http://blockscan.com/assetInfo/FLDC"
    Public Const URL_FLDC_Distro As String = "http://foldingcoin.xyz/?token=FLDC&total=500000&start=2016-10-25&end=2016-10-26"
    Public Const URL_CureCoin As String = "https://www.curecoin.net/"
    Public Const URL_Twitter_CureCoin As String = "https://twitter.com/CureCoin_Team"
    Public Const URL_BlockchainCURE As String = "https://chainz.cryptoid.info/cure/"
    Public Const URL_EOC As String = "http://folding.extremeoverclocking.com/user_summary.php?s=&u="
    Public Const URL_CureCoin_EOC As String = "http://folding.extremeoverclocking.com/team_summary.php?s=&t=224497"
    Public Const URL_FAH As String = "http://folding.stanford.edu/"
    Public Const URL_FAH_Client As String = "http://folding.stanford.edu/client/"
    Public Const URL_CureCoinFoldingPoolPage As String = "https://www.cryptobullionpools.com/"

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
    Public Const DAT_CureCoin_Wallet_Version As String = "CureCoinWalletVersion"
    Public Const DAT_CureCoin_Addr As String = "CureCoinAddress"

    Public INI As New IniFile
    Public Const INI_Settings As String = "Settings"
    Public Const INI_PW As String = "DatFilePassword"
    Public Const INI_Size As String = "Size"
    Public Const INI_WindowState As String = "WindowState"
    Public Const INI_LastWalletId As String = "LastWalletId"
    Public Const INI_LastBrowserVersion As String = "LastBrowserVersion"
    Public Const INI_HideSavedDataButton As String = "HideSavedDataButton"

    'Wallet Id specific
    Public Const INI_FAH_Username As String = "FAHUsername"
    Public Const INI_EOC_ID As String = "ExtremeOverclockingUserId"
    Public Const INI_WalletName As String = "WalletName"

    'Website title to search for
    Public Const NameCryptoBullions As String = "CryptoBullions"

    Public UserProfileDir As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Prog_Name)
    Public IniFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".ini")
    Public DatFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".dat")
    Public LogFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".txt")

    'Cancel navigation / downloads indicator
    Public g_bCancelNav As Boolean = False
    Public g_bAskDownloadLocation As Boolean = True
    'Holds on to the last downloaded file path, when the download completes
    Public g_strDownloadedFilePath As String = ""

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
    Private iWaits As Integer = 0
    Public Sub Wait(iMilSec As Integer)
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

    Public Async Function Wait2(iMilSec As Integer) As Threading.Tasks.Task
        Await Threading.Tasks.Task.Delay(iMilSec)
    End Function
#End Region
End Module


'File download, see: https://github.com/cefsharp/CefSharp/blob/master/CefSharp.Example/DownloadHandler.cs
Public Class DownloadHandler
    Implements CefSharp.IDownloadHandler
    Public Sub OnBeforeDownload(browser As CefSharp.IBrowser, downloadItem As CefSharp.DownloadItem, callback As CefSharp.IBeforeDownloadCallback) Implements CefSharp.IDownloadHandler.OnBeforeDownload
        'Reset the downloaded file path at the start of downloading the file
        g_strDownloadedFilePath = ""
        g_bCancelNav = False

        If callback.IsDisposed = False Then
            'For g_bAskDownloadLocation = true, then show the download location dialog, otherwise don't
            callback.Continue(System.IO.Path.Combine(UserProfileDir, "Cache", downloadItem.SuggestedFileName), g_bAskDownloadLocation)
        End If
    End Sub

    Public Sub OnDownloadUpdated(browser As CefSharp.IBrowser, downloadItem As CefSharp.DownloadItem, callback As CefSharp.IDownloadItemCallback) Implements CefSharp.IDownloadHandler.OnDownloadUpdated
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