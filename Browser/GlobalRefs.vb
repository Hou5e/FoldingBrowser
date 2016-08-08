Public Module GlobalRefs
    Public g_Main As Main

    'Don't change this:
    Public Const Prog_Name As String = "FoldingBrowser"

    Public Const DAT_FLDC As String = "FLDC"
    Public Const DAT_12W As String = "12W"
    Public Const DAT_URL As String = "URL"
    Public Const DAT_PW As String = "PW"

    Public INI As New IniFile
    Public Const INI_Settings As String = "Settings"
    Public Const INI_PW As String = "DatFilePassword"
    Public Const INI_Size As String = "Size"

    Public UserProfileDir As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Prog_Name)
    Public IniFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".ini")
    Public DatFilePath As String = System.IO.Path.Combine(UserProfileDir, Prog_Name & ".dat")

    'Cancel navigaion / downloads indicator
    Public g_bCancelNav As Boolean = False
    Public g_bAskDownloadLocation As Boolean = True
    'Holds on to the last download path, when the download completes
    Public g_strDownloadPath As String = ""
End Module

'File download, see: https://github.com/cefsharp/CefSharp/blob/master/CefSharp.Example/DownloadHandler.cs
Public Class DownloadHandler
    Implements CefSharp.IDownloadHandler
    Public Sub OnBeforeDownload(browser As CefSharp.IBrowser, downloadItem As CefSharp.DownloadItem, callback As CefSharp.IBeforeDownloadCallback) Implements CefSharp.IDownloadHandler.OnBeforeDownload
        If callback.IsDisposed = False Then
            'For g_bAskDownloadLocation = true, then show the download location dialog, otherwise don't
            callback.Continue(System.IO.Path.Combine(UserProfileDir, downloadItem.SuggestedFileName), g_bAskDownloadLocation)
        End If
        'Reset the download path at the start of downloading the file
        g_strDownloadPath = ""
    End Sub

    Public Sub OnDownloadUpdated(browser As CefSharp.IBrowser, downloadItem As CefSharp.DownloadItem, callback As CefSharp.IDownloadItemCallback) Implements CefSharp.IDownloadHandler.OnDownloadUpdated
        g_Main.updateDownload(downloadItem.PercentComplete, downloadItem.IsComplete, downloadItem.IsCancelled)
        If downloadItem.IsComplete = True Then
            g_strDownloadPath = downloadItem.FullPath
        End If
    End Sub
End Class