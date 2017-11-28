Public Class UserPwdDialog
    Private Sub UserPwdDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.L_cysteine_16_24_32_48_256

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