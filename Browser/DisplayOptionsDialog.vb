Public Class DisplayOptionsDialog
    Public Sub New()
        Try
            InitializeComponent()

            Me.Icon = My.Resources.L_cysteine_16_24_32_48_256
            Me.SplitContainer1.SplitterWidth = 2
            Me.SplitContainer1.Panel1Collapsed = True

            'Load the pull-down menu from the constants
            Me.cbxHomepage.Items.AddRange({HpgDefault, HpgSideBySide, HpgFoldingCoin, HpgFoldingCoinTeamStats, HpgFoldingCoinMyStats, HpgCureCoin, HpgCureCoinTeamStatsEOC, HpgMyStatsEOC, HpgFAH, HpgBlank})

            'Start with the textboxes instead of the raw data that is hard to look at
            chkShowRawData_CheckedChanged(Nothing, Nothing)

            'Make sure the INI key/value exists
            If INI.GetSection(INI_Settings).GetKey(INI_Homepage) IsNot Nothing Then
                'Load option
                Me.cbxHomepage.Text = INI.GetSection(INI_Settings).GetKey(INI_Homepage).GetValue()
            Else
                'Add, if it doesn't exist
                INI.AddSection(INI_Settings).AddKey(INI_Homepage).Value = HpgDefault
            End If

            If INI.GetSection(INI_Settings).GetKey(INI_ShowPanelOnMouseEnter) IsNot Nothing Then
                'Load option
                Me.chkShowPanelOnMouseEnterEvent.Checked = CBool(INI.GetSection(INI_Settings).GetKey(INI_ShowPanelOnMouseEnter).GetValue())
            Else
                'Add, if it doesn't exist
                INI.AddSection(INI_Settings).AddKey(INI_ShowPanelOnMouseEnter).Value = g_bShowWebLinkPanelOnMouseEnterEvent.ToString
            End If

            'Display the INI data in the main raw data textbox
            Me.txtDisplayText.Text = INI.SaveToString
            Me.txtDisplayText.Select(Me.txtDisplayText.Text.Length, 0)

            'Reset the Save button to be disabled until some changes to the text are made
            Me.btnSaveChanges.Enabled = False
            Me.btnOK.Focus()
            'Don't put Me.Show() here because it will be shown as a dialog box.

        Catch ex As Exception
            g_Main.Msg(ex.ToString)
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DisplayOptionsDialog_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        'Clear out the displayed text
        Me.txtDisplayText.Text = String.Empty
    End Sub

    Private Sub chkShowRawData_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowRawData.CheckedChanged
        If Me.chkShowRawData.Checked = False Then
            'Use the individual textboxes
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = True
            Me.btnSaveChanges.Visible = True
        Else
            'Use the large single textbox with the Raw INI data
            Me.SplitContainer1.Panel2Collapsed = False
            Me.SplitContainer1.Panel1Collapsed = True
            Me.btnSaveChanges.Visible = False
        End If

        'Disable the save button again
        Me.btnSaveChanges.Enabled = False
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If Me.chkShowRawData.Checked = False Then
            'Save options
            If Me.cbxHomepage.Text.Length > 0 Then
                INI.AddSection(INI_Settings).AddKey(INI_Homepage).Value = Me.cbxHomepage.Text
            End If

            g_bShowWebLinkPanelOnMouseEnterEvent = Me.chkShowPanelOnMouseEnterEvent.Checked
            INI.AddSection(INI_Settings).AddKey(INI_ShowPanelOnMouseEnter).Value = g_bShowWebLinkPanelOnMouseEnterEvent.ToString
            INI.Save(IniFilePath)

            'Display the INI data in the main raw data textbox
            Me.txtDisplayText.Text = INI.SaveToString
            Me.txtDisplayText.Select(Me.txtDisplayText.Text.Length, 0)

            'Disable the save button again
            Me.btnSaveChanges.Enabled = False
            Me.btnOK.Focus()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'The Closing event clears out the displayed text
        Me.Close()
    End Sub

    Private Sub DisplayOptionsDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            'The Closing event clears out the displayed text
            Me.Close()
        End If
    End Sub

    'If any of the options are changed, then enable the Save Changes button
    Private Sub cbxHomepage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxHomepage.SelectedIndexChanged
        Me.btnSaveChanges.Enabled = True
    End Sub

    'If any of the options are changed, then enable the Save Changes button
    Private Sub chkShowPanelOnMouseEnterEvent_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPanelOnMouseEnterEvent.CheckedChanged
        Me.btnSaveChanges.Enabled = True
    End Sub
End Class