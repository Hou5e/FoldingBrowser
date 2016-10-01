<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStopNav = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.btnGetWallet = New System.Windows.Forms.Button()
        Me.btnLogIntoWallet = New System.Windows.Forms.Button()
        Me.btnGetFAH = New System.Windows.Forms.Button()
        Me.btnFAHControl = New System.Windows.Forms.Button()
        Me.btnBrowserTools = New System.Windows.Forms.Button()
        Me.btnFoldingCoinWebsite = New System.Windows.Forms.Button()
        Me.btnFLDC_DailyDistro = New System.Windows.Forms.Button()
        Me.btnCureCoin = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.gbxTools = New System.Windows.Forms.GroupBox()
        Me.chkShowTools = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTwitterFoldingCoin = New System.Windows.Forms.Button()
        Me.btnTwitterCureCoin = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.gbxCheckboxForTools = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.gbxDownload = New System.Windows.Forms.GroupBox()
        Me.lblDownloadText = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.SuspendLayout()
        Me.gbxTools.SuspendLayout()
        Me.gbxCheckboxForTools.SuspendLayout()
        Me.gbxDownload.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(927, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnStopNav
        '
        Me.btnStopNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopNav.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopNav.FlatAppearance.BorderSize = 0
        Me.btnStopNav.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnStopNav.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnStopNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopNav.Location = New System.Drawing.Point(859, 47)
        Me.btnStopNav.Name = "btnStopNav"
        Me.btnStopNav.Size = New System.Drawing.Size(17, 17)
        Me.btnStopNav.TabIndex = 124
        Me.btnStopNav.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnStopNav, "Cancel navigation")
        Me.btnStopNav.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(116, 46)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(738, 20)
        Me.txtURL.TabIndex = 123
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.BackColor = System.Drawing.SystemColors.Window
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(836, 47)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(17, 17)
        Me.btnGo.TabIndex = 121
        Me.btnGo.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.btnGo, "Go to URL")
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(83, 49)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 122
        Me.lblURL.Text = "URL:"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(984, 634)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(984, 634)
        Me.ToolStripContainer1.TabIndex = 125
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'btnGetWallet
        '
        Me.btnGetWallet.Location = New System.Drawing.Point(85, 6)
        Me.btnGetWallet.Name = "btnGetWallet"
        Me.btnGetWallet.Size = New System.Drawing.Size(68, 23)
        Me.btnGetWallet.TabIndex = 121
        Me.btnGetWallet.Text = "Get Wallet"
        Me.ToolTip1.SetToolTip(Me.btnGetWallet, "One Time Only! Setup a CounterWallet")
        Me.btnGetWallet.UseVisualStyleBackColor = True
        '
        'btnLogIntoWallet
        '
        Me.btnLogIntoWallet.Location = New System.Drawing.Point(0, -3)
        Me.btnLogIntoWallet.Name = "btnLogIntoWallet"
        Me.btnLogIntoWallet.Size = New System.Drawing.Size(68, 23)
        Me.btnLogIntoWallet.TabIndex = 127
        Me.btnLogIntoWallet.Text = "My Wallet"
        Me.ToolTip1.SetToolTip(Me.btnLogIntoWallet, "Veiw wallet at CounterWallet")
        Me.btnLogIntoWallet.UseVisualStyleBackColor = True
        '
        'btnGetFAH
        '
        Me.btnGetFAH.Location = New System.Drawing.Point(152, 6)
        Me.btnGetFAH.Name = "btnGetFAH"
        Me.btnGetFAH.Size = New System.Drawing.Size(61, 23)
        Me.btnGetFAH.TabIndex = 128
        Me.btnGetFAH.Text = "Get F@H"
        Me.ToolTip1.SetToolTip(Me.btnGetFAH, "One Time Only! Install and setup Folding at Home")
        Me.btnGetFAH.UseVisualStyleBackColor = True
        '
        'btnFAHControl
        '
        Me.btnFAHControl.Location = New System.Drawing.Point(67, -3)
        Me.btnFAHControl.Name = "btnFAHControl"
        Me.btnFAHControl.Size = New System.Drawing.Size(82, 23)
        Me.btnFAHControl.TabIndex = 127
        Me.btnFAHControl.Text = "F@H Control"
        Me.ToolTip1.SetToolTip(Me.btnFAHControl, "View Folding at Home App Status")
        Me.btnFAHControl.UseVisualStyleBackColor = True
        '
        'btnBrowserTools
        '
        Me.btnBrowserTools.Location = New System.Drawing.Point(3, 6)
        Me.btnBrowserTools.Name = "btnBrowserTools"
        Me.btnBrowserTools.Size = New System.Drawing.Size(83, 23)
        Me.btnBrowserTools.TabIndex = 128
        Me.btnBrowserTools.Text = "Browser Tools"
        Me.ToolTip1.SetToolTip(Me.btnBrowserTools, "Web Browser Debug Tools")
        Me.btnBrowserTools.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinWebsite
        '
        Me.btnFoldingCoinWebsite.Location = New System.Drawing.Point(148, -3)
        Me.btnFoldingCoinWebsite.Name = "btnFoldingCoinWebsite"
        Me.btnFoldingCoinWebsite.Size = New System.Drawing.Size(71, 23)
        Me.btnFoldingCoinWebsite.TabIndex = 129
        Me.btnFoldingCoinWebsite.Text = "FoldingCoin"
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinWebsite, "FoldingCoin Website")
        Me.btnFoldingCoinWebsite.UseVisualStyleBackColor = True
        '
        'btnFLDC_DailyDistro
        '
        Me.btnFLDC_DailyDistro.Location = New System.Drawing.Point(218, -3)
        Me.btnFLDC_DailyDistro.Name = "btnFLDC_DailyDistro"
        Me.btnFLDC_DailyDistro.Size = New System.Drawing.Size(75, 23)
        Me.btnFLDC_DailyDistro.TabIndex = 129
        Me.btnFLDC_DailyDistro.Text = "Daily FLDC"
        Me.ToolTip1.SetToolTip(Me.btnFLDC_DailyDistro, "FoldingCoin Daily Distributions")
        Me.btnFLDC_DailyDistro.UseVisualStyleBackColor = True
        '
        'btnCureCoin
        '
        Me.btnCureCoin.Location = New System.Drawing.Point(292, -3)
        Me.btnCureCoin.Name = "btnCureCoin"
        Me.btnCureCoin.Size = New System.Drawing.Size(78, 23)
        Me.btnCureCoin.TabIndex = 129
        Me.btnCureCoin.Text = "CureCoin"
        Me.ToolTip1.SetToolTip(Me.btnCureCoin, "CureCoin Website")
        Me.btnCureCoin.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReload.BackColor = System.Drawing.SystemColors.Control
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(880, 47)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(17, 17)
        Me.btnReload.TabIndex = 130
        Me.btnReload.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnReload, "Reload page")
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(30, 42)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 131
        Me.btnBack.Text = "B"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Go back one page")
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFwd
        '
        Me.btnFwd.BackColor = System.Drawing.SystemColors.Control
        Me.btnFwd.FlatAppearance.BorderSize = 0
        Me.btnFwd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFwd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFwd.Location = New System.Drawing.Point(56, 42)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(25, 25)
        Me.btnFwd.TabIndex = 132
        Me.btnFwd.Text = "F"
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Go forward one page")
        Me.btnFwd.UseVisualStyleBackColor = False
        '
        'gbxTools
        '
        Me.gbxTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxTools.Controls.Add(Me.btnGetFAH)
        Me.gbxTools.Controls.Add(Me.btnGetWallet)
        Me.gbxTools.Controls.Add(Me.btnBrowserTools)
        Me.gbxTools.Location = New System.Drawing.Point(669, -9)
        Me.gbxTools.Name = "gbxTools"
        Me.gbxTools.Size = New System.Drawing.Size(215, 32)
        Me.gbxTools.TabIndex = 133
        Me.gbxTools.TabStop = False
        '
        'chkShowTools
        '
        Me.chkShowTools.AutoSize = True
        Me.chkShowTools.Checked = True
        Me.chkShowTools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowTools.Location = New System.Drawing.Point(7, 9)
        Me.chkShowTools.Name = "chkShowTools"
        Me.chkShowTools.Size = New System.Drawing.Size(52, 17)
        Me.chkShowTools.TabIndex = 134
        Me.chkShowTools.Text = "Tools"
        Me.chkShowTools.UseVisualStyleBackColor = True
        '
        'btnTwitterFoldingCoin
        '
        Me.btnTwitterFoldingCoin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTwitterFoldingCoin.Location = New System.Drawing.Point(148, 14)
        Me.btnTwitterFoldingCoin.Name = "btnTwitterFoldingCoin"
        Me.btnTwitterFoldingCoin.Size = New System.Drawing.Size(71, 19)
        Me.btnTwitterFoldingCoin.TabIndex = 129
        Me.btnTwitterFoldingCoin.Text = "Twitter"
        Me.btnTwitterFoldingCoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnTwitterFoldingCoin, "FoldingCoin Twitter")
        Me.btnTwitterFoldingCoin.UseVisualStyleBackColor = False
        '
        'btnTwitterCureCoin
        '
        Me.btnTwitterCureCoin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTwitterCureCoin.Location = New System.Drawing.Point(292, 14)
        Me.btnTwitterCureCoin.Name = "btnTwitterCureCoin"
        Me.btnTwitterCureCoin.Size = New System.Drawing.Size(78, 19)
        Me.btnTwitterCureCoin.TabIndex = 129
        Me.btnTwitterCureCoin.Text = "Twitter"
        Me.btnTwitterCureCoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnTwitterCureCoin, "CureCoin Twitter")
        Me.btnTwitterCureCoin.UseVisualStyleBackColor = False
        '
        'txtMsg
        '
        Me.txtMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.Location = New System.Drawing.Point(373, -1)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(293, 75)
        Me.txtMsg.TabIndex = 135
        '
        'gbxCheckboxForTools
        '
        Me.gbxCheckboxForTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCheckboxForTools.Controls.Add(Me.chkShowTools)
        Me.gbxCheckboxForTools.Location = New System.Drawing.Point(918, -8)
        Me.gbxCheckboxForTools.Name = "gbxCheckboxForTools"
        Me.gbxCheckboxForTools.Size = New System.Drawing.Size(63, 28)
        Me.gbxCheckboxForTools.TabIndex = 136
        Me.gbxCheckboxForTools.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(64, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(179, 15)
        Me.ProgressBar1.TabIndex = 137
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.SystemColors.Window
        Me.lblPercent.Location = New System.Drawing.Point(144, 10)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(21, 13)
        Me.lblPercent.TabIndex = 138
        Me.lblPercent.Text = "0%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDownload
        '
        Me.gbxDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDownload.Controls.Add(Me.lblDownloadText)
        Me.gbxDownload.Controls.Add(Me.lblPercent)
        Me.gbxDownload.Controls.Add(Me.ProgressBar1)
        Me.gbxDownload.Location = New System.Drawing.Point(669, 17)
        Me.gbxDownload.Name = "gbxDownload"
        Me.gbxDownload.Size = New System.Drawing.Size(249, 27)
        Me.gbxDownload.TabIndex = 139
        Me.gbxDownload.TabStop = False
        Me.gbxDownload.Visible = False
        '
        'lblDownloadText
        '
        Me.lblDownloadText.AutoSize = True
        Me.lblDownloadText.BackColor = System.Drawing.SystemColors.Control
        Me.lblDownloadText.Location = New System.Drawing.Point(6, 10)
        Me.lblDownloadText.Name = "lblDownloadText"
        Me.lblDownloadText.Size = New System.Drawing.Size(58, 13)
        Me.lblDownloadText.TabIndex = 139
        Me.lblDownloadText.Text = "Download:"
        Me.lblDownloadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(877, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 140
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 708)
        Me.Controls.Add(Me.gbxCheckboxForTools)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.gbxTools)
        Me.Controls.Add(Me.btnFwd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnCureCoin)
        Me.Controls.Add(Me.btnFLDC_DailyDistro)
        Me.Controls.Add(Me.btnFoldingCoinWebsite)
        Me.Controls.Add(Me.btnFAHControl)
        Me.Controls.Add(Me.btnLogIntoWallet)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.btnStopNav)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.btnTwitterFoldingCoin)
        Me.Controls.Add(Me.btnTwitterCureCoin)
        Me.Controls.Add(Me.gbxDownload)
        Me.Controls.Add(Me.PictureBox2)
        Me.MinimumSize = New System.Drawing.Size(16, 670)
        Me.Name = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.gbxTools.ResumeLayout(False)
        Me.gbxCheckboxForTools.ResumeLayout(False)
        Me.gbxCheckboxForTools.PerformLayout()
        Me.gbxDownload.ResumeLayout(False)
        Me.gbxDownload.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStopNav As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnGetWallet As System.Windows.Forms.Button
    Friend WithEvents btnLogIntoWallet As System.Windows.Forms.Button
    Friend WithEvents btnGetFAH As System.Windows.Forms.Button
    Friend WithEvents btnFAHControl As System.Windows.Forms.Button
    Friend WithEvents btnBrowserTools As System.Windows.Forms.Button
    Friend WithEvents btnFoldingCoinWebsite As System.Windows.Forms.Button
    Friend WithEvents btnFLDC_DailyDistro As System.Windows.Forms.Button
    Friend WithEvents btnCureCoin As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnFwd As System.Windows.Forms.Button
    Friend WithEvents gbxTools As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowTools As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents gbxCheckboxForTools As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents gbxDownload As System.Windows.Forms.GroupBox
    Friend WithEvents lblDownloadText As System.Windows.Forms.Label
    Friend WithEvents btnTwitterFoldingCoin As Button
    Friend WithEvents btnTwitterCureCoin As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
