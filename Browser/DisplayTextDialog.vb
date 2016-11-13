Public Class DisplayTextDialog
    Private Sub DisplayTextDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.FoldingCoin_16_32_48
    End Sub

    Private Sub txtDisplayText_TextChanged(sender As Object, e As EventArgs) Handles txtDisplayText.TextChanged
        Me.btnSave.Enabled = True
    End Sub
End Class