Public Class TextEntryDialog
    Private Sub TextEntryDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.L_cysteine_16_24_32_48_256

        'Set the new font scalar to resize the form (For display scaling percentages other than 100% / 96 DPI)
        If g_sScaleFactor <> DefaultFontScalar Then
            'Scale font. This will force the child controls to resize and scale fonts (as long as they are the default font)
            Me.Font = New Font(Me.Font.FontFamily, Me.Font.Size * g_sScaleFactor, Me.Font.Style)
        End If
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