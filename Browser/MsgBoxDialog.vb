Public Class MsgBoxDialog
    Private Sub MsgBoxDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.FoldingCoin_16_32_48
        Me.BtnOK.Select()
    End Sub
End Class