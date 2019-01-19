Public Class UserPwdDialog
    Private Sub UserPwdDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.L_cysteine_16_24_32_48_256

        'Set the new font scalar to resize the form (For display scaling percentages other than 100% / 96 DPI)
        If g_sScaleFactor <> DefaultFontScalar Then
            'Scale font. This will force the child controls to resize and scale fonts (as long as they are the default font)
            Me.Font = New Font(Me.Font.FontFamily, Me.Font.Size * g_sScaleFactor, Me.Font.Style)
        End If

        'Change the checkbox state to update the form state
        Me.chkNewUser.Checked = True
    End Sub

    Private Sub chkNewUser_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewUser.CheckedChanged
        If Me.chkNewUser.Checked = True Then
            Me.chkNewUser.Text = "New User"
            Me.lblMsgText.Text = "Please Enter Your Discord Registration Info:"
        Else
            Me.chkNewUser.Text = "Existing User"
            Me.lblMsgText.Text = "Please Enter Your Existing Discord Info:"
        End If

        'Hide the username entry if the user is an existing user, otherwise show it for a new user
        Me.lblUsername.Visible = Me.chkNewUser.Checked
        Me.txtUsername.Visible = Me.chkNewUser.Checked
        Me.lblNote.Visible = Me.chkNewUser.Checked
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If Me.txtPassword.Text.Length > 5 Then
            'Password must be >= 6 characters, up to 128 chars
            Me.btnOK.Enabled = True
        Else
            Me.btnOK.Enabled = False
        End If
    End Sub
End Class