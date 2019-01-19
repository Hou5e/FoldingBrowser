Public Class MsgBoxDialog
    Private Sub MsgBoxDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.L_cysteine_16_24_32_48_256

        'Set the new font scalar to resize the form (For display scaling percentages other than 100% / 96 DPI)
        If g_sScaleFactor <> DefaultFontScalar Then
            'Scale font. This will force the child controls to resize and scale fonts (as long as they are the default font)
            Me.Font = New Font(Me.Font.FontFamily, Me.Font.Size * g_sScaleFactor, Me.Font.Style)
        End If

        Me.btnOK.Select()
    End Sub
End Class