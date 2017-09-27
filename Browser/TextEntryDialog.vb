Public Class TextEntryDialog
    Private Sub TextEntryDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.L_cysteine_16_24_32_48_256
    End Sub

    Private Sub TextEnteredUpper_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEnteredUpper.KeyPress
        'If the user hits <Enter> at the end of typing, then press OK
        If e.KeyChar = Chr(13) Then
            If Me.TextEnteredLower.Visible = True Then
                'Move to the next text entry line
                Me.TextEnteredLower.Select(Me.TextEnteredLower.Text.Length, 0)
            Else
                '2nd text entry line is hidden, so just press the OK button
                Me.btnOK.PerformClick()
            End If
        End If

    End Sub

    Private Sub TextEnteredLower_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEnteredLower.KeyPress
        'If the user hits <Enter> at the end of typing, then press OK
        If e.KeyChar = Chr(13) Then
            Me.btnOK.PerformClick()
        End If
    End Sub
End Class