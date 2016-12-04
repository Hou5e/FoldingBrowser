Public Class DisplayTextDialog
    Private Sub DisplayTextDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.FoldingCoin_16_32_48
    End Sub

    Private Sub txtDisplayText_TextChanged(sender As Object, e As EventArgs) Handles txtDisplayText.TextChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    Private Sub btnMakeBackup_Click(sender As Object, e As EventArgs) Handles btnMakeBackup.Click
        Try
            'Ask for backup folder location, a new folder will be made there for the files
            Dim SaveDlg As New System.Windows.Forms.FolderBrowserDialog
            SaveDlg.ShowNewFolderButton = False

            If SaveDlg.ShowDialog() = DialogResult.OK Then
                Dim strBackupPath As String = System.IO.Path.Combine(SaveDlg.SelectedPath, "FoldingBrowserBackup-" & Now.ToString("yyyy-MM-dd_HH_mm_ss"))
                Dim strCureCoinWalletPath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "curecoin", "wallet.dat")

                If System.IO.Directory.Exists(strBackupPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(strBackupPath)
                End If
                System.IO.File.Copy(DatFilePath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(DatFilePath)))
                System.IO.File.Copy(IniFilePath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(IniFilePath)))

                If System.IO.File.Exists(strCureCoinWalletPath) = True Then
                    System.IO.File.Copy(strCureCoinWalletPath, System.IO.Path.Combine(strBackupPath, System.IO.Path.GetFileName(strCureCoinWalletPath)))
                End If

                'TODO: Write out a text file that says what to do to restore the files?

            End If

        Catch ex As Exception
            MessageBox.Show("Error creating backup: " & ex.ToString)
        End Try
    End Sub
End Class