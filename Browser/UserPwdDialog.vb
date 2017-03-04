Public Class UserPwdDialog
    Public bSetupForFoldingCoin As Boolean = True
    Public bGetSlackPressed As Boolean = False

    Private Sub UserPwdDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.FoldingCoin_16_32_48

        Me.btnGetAccount.Text = "Get " & If(bSetupForFoldingCoin = True, "FoldingCoin", "CureCoin") & " Slack Account"
        Me.lblMsgText.Text = "Please Enter Your Existing " & If(bSetupForFoldingCoin = True, "FoldingCoin", "CureCoin") & " Slack Info:"
    End Sub

    Private Sub btnGetAccount_Click(sender As Object, e As EventArgs) Handles btnGetAccount.Click
        bGetSlackPressed = True
    End Sub
End Class