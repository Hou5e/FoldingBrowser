<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStopNav = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.btnGetWallet = New System.Windows.Forms.Button()
        Me.btnMyWallet = New System.Windows.Forms.Button()
        Me.btnGetFAH = New System.Windows.Forms.Button()
        Me.btnFAHControl = New System.Windows.Forms.Button()
        Me.btnBrowserTools = New System.Windows.Forms.Button()
        Me.btnFoldingCoinWebsite = New System.Windows.Forms.Button()
        Me.btnCureCoin = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.gbxTools = New System.Windows.Forms.GroupBox()
        Me.btnCureCoinSetup = New System.Windows.Forms.Button()
        Me.btnSavedData = New System.Windows.Forms.Button()
        Me.txtWalletName = New System.Windows.Forms.TextBox()
        Me.cbxWalletId = New System.Windows.Forms.ComboBox()
        Me.btnFAHConfig = New System.Windows.Forms.Button()
        Me.lblWalletNum = New System.Windows.Forms.Label()
        Me.btnCurePool = New System.Windows.Forms.Button()
        Me.chkShowTools = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFoldingCoinTwitter = New System.Windows.Forms.Button()
        Me.btnCureCoinTwitter = New System.Windows.Forms.Button()
        Me.btnFoldingCoinBlockchain = New System.Windows.Forms.Button()
        Me.btnEOC = New System.Windows.Forms.Button()
        Me.btnCureCoinBlockchain = New System.Windows.Forms.Button()
        Me.btnFoldingCoinSlack = New System.Windows.Forms.Button()
        Me.btnBTCBlockchain = New System.Windows.Forms.Button()
        Me.btnCureCoinSlack = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.gbxCheckboxForTools = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.gbxDownload = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnFLDC_Distribution = New System.Windows.Forms.Button()
        Me.ToolStripContainer1.SuspendLayout()
        Me.gbxTools.SuspendLayout()
        Me.gbxCheckboxForTools.SuspendLayout()
        Me.gbxDownload.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStopNav
        '
        Me.btnStopNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopNav.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopNav.FlatAppearance.BorderSize = 0
        Me.btnStopNav.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnStopNav.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnStopNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopNav.Location = New System.Drawing.Point(1098, 49)
        Me.btnStopNav.Name = "btnStopNav"
        Me.btnStopNav.Size = New System.Drawing.Size(17, 17)
        Me.btnStopNav.TabIndex = 2
        Me.btnStopNav.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnStopNav, "Cancel navigation / download, or press <Esc>")
        Me.btnStopNav.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(138, 48)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(982, 20)
        Me.txtURL.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.BackColor = System.Drawing.SystemColors.Window
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(1075, 49)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(17, 17)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.btnGo, "Go to URL")
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(81, 52)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 7
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1214, 634)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1214, 634)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'btnGetWallet
        '
        Me.btnGetWallet.Location = New System.Drawing.Point(77, -1)
        Me.btnGetWallet.Name = "btnGetWallet"
        Me.btnGetWallet.Size = New System.Drawing.Size(78, 20)
        Me.btnGetWallet.TabIndex = 1
        Me.btnGetWallet.Text = "2. Get Wallet"
        Me.btnGetWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGetWallet, "One Time Only! Get a CounterWallet")
        Me.btnGetWallet.UseVisualStyleBackColor = True
        '
        'btnMyWallet
        '
        Me.btnMyWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMyWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyWallet.Location = New System.Drawing.Point(0, 0)
        Me.btnMyWallet.Name = "btnMyWallet"
        Me.btnMyWallet.Size = New System.Drawing.Size(72, 41)
        Me.btnMyWallet.TabIndex = 8
        Me.btnMyWallet.Text = "My Wallet"
        Me.btnMyWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnMyWallet, "View wallet at CounterWallet")
        Me.btnMyWallet.UseVisualStyleBackColor = True
        '
        'btnGetFAH
        '
        Me.btnGetFAH.Location = New System.Drawing.Point(5, -1)
        Me.btnGetFAH.Name = "btnGetFAH"
        Me.btnGetFAH.Size = New System.Drawing.Size(73, 20)
        Me.btnGetFAH.TabIndex = 0
        Me.btnGetFAH.Text = "1. Get F@H"
        Me.btnGetFAH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGetFAH, "One Time Only! Install and setup Folding@Home")
        Me.btnGetFAH.UseVisualStyleBackColor = True
        '
        'btnFAHControl
        '
        Me.btnFAHControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFAHControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAHControl.Location = New System.Drawing.Point(71, 0)
        Me.btnFAHControl.Name = "btnFAHControl"
        Me.btnFAHControl.Size = New System.Drawing.Size(88, 41)
        Me.btnFAHControl.TabIndex = 9
        Me.btnFAHControl.Text = "F@H Control"
        Me.btnFAHControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHControl, "Folding@Home Web Control to View App Status")
        Me.btnFAHControl.UseVisualStyleBackColor = True
        '
        'btnBrowserTools
        '
        Me.btnBrowserTools.Location = New System.Drawing.Point(601, 40)
        Me.btnBrowserTools.Name = "btnBrowserTools"
        Me.btnBrowserTools.Size = New System.Drawing.Size(69, 20)
        Me.btnBrowserTools.TabIndex = 23
        Me.btnBrowserTools.Text = "Web Tools"
        Me.btnBrowserTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBrowserTools, "Web Browser Debug Tools")
        Me.btnBrowserTools.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinWebsite
        '
        Me.btnFoldingCoinWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinWebsite.Location = New System.Drawing.Point(165, 0)
        Me.btnFoldingCoinWebsite.Name = "btnFoldingCoinWebsite"
        Me.btnFoldingCoinWebsite.Size = New System.Drawing.Size(82, 41)
        Me.btnFoldingCoinWebsite.TabIndex = 10
        Me.btnFoldingCoinWebsite.Text = "FoldingCoin"
        Me.btnFoldingCoinWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinWebsite, "FoldingCoin Website")
        Me.btnFoldingCoinWebsite.UseVisualStyleBackColor = True
        '
        'btnCureCoin
        '
        Me.btnCureCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoin.Location = New System.Drawing.Point(401, 0)
        Me.btnCureCoin.Name = "btnCureCoin"
        Me.btnCureCoin.Size = New System.Drawing.Size(66, 41)
        Me.btnCureCoin.TabIndex = 16
        Me.btnCureCoin.Text = "CureCoin"
        Me.btnCureCoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.btnReload.Location = New System.Drawing.Point(1119, 49)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(17, 17)
        Me.btnReload.TabIndex = 3
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
        Me.btnBack.Location = New System.Drawing.Point(28, 45)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 5
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
        Me.btnFwd.Location = New System.Drawing.Point(54, 45)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(25, 25)
        Me.btnFwd.TabIndex = 6
        Me.btnFwd.Text = "F"
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Go forward one page")
        Me.btnFwd.UseVisualStyleBackColor = False
        '
        'gbxTools
        '
        Me.gbxTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxTools.Controls.Add(Me.btnCureCoinSetup)
        Me.gbxTools.Controls.Add(Me.btnSavedData)
        Me.gbxTools.Controls.Add(Me.txtWalletName)
        Me.gbxTools.Controls.Add(Me.cbxWalletId)
        Me.gbxTools.Controls.Add(Me.btnFAHConfig)
        Me.gbxTools.Controls.Add(Me.btnGetFAH)
        Me.gbxTools.Controls.Add(Me.btnGetWallet)
        Me.gbxTools.Controls.Add(Me.lblWalletNum)
        Me.gbxTools.Location = New System.Drawing.Point(865, 1)
        Me.gbxTools.Name = "gbxTools"
        Me.gbxTools.Size = New System.Drawing.Size(347, 46)
        Me.gbxTools.TabIndex = 26
        Me.gbxTools.TabStop = False
        '
        'btnCureCoinSetup
        '
        Me.btnCureCoinSetup.Location = New System.Drawing.Point(238, -1)
        Me.btnCureCoinSetup.Name = "btnCureCoinSetup"
        Me.btnCureCoinSetup.Size = New System.Drawing.Size(89, 20)
        Me.btnCureCoinSetup.TabIndex = 3
        Me.btnCureCoinSetup.Text = "4. CURE Setup"
        Me.btnCureCoinSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinSetup, "(One-Time only) Setup CureCoin Folding Pool info")
        Me.btnCureCoinSetup.UseVisualStyleBackColor = True
        '
        'btnSavedData
        '
        Me.btnSavedData.Location = New System.Drawing.Point(24, 22)
        Me.btnSavedData.Name = "btnSavedData"
        Me.btnSavedData.Size = New System.Drawing.Size(72, 20)
        Me.btnSavedData.TabIndex = 4
        Me.btnSavedData.Text = "Saved Data"
        Me.btnSavedData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSavedData, "Show Saved Settings from .Dat File")
        Me.btnSavedData.UseVisualStyleBackColor = True
        '
        'txtWalletName
        '
        Me.txtWalletName.Location = New System.Drawing.Point(215, 22)
        Me.txtWalletName.Name = "txtWalletName"
        Me.txtWalletName.Size = New System.Drawing.Size(128, 20)
        Me.txtWalletName.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxWalletId
        '
        Me.cbxWalletId.FormattingEnabled = True
        Me.cbxWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxWalletId.Location = New System.Drawing.Point(184, 22)
        Me.cbxWalletId.Name = "cbxWalletId"
        Me.cbxWalletId.Size = New System.Drawing.Size(30, 21)
        Me.cbxWalletId.TabIndex = 6
        Me.cbxWalletId.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cbxWalletId, "Wallet Id (0-9) to use. Default: 0.")
        '
        'btnFAHConfig
        '
        Me.btnFAHConfig.Location = New System.Drawing.Point(154, -1)
        Me.btnFAHConfig.Name = "btnFAHConfig"
        Me.btnFAHConfig.Size = New System.Drawing.Size(85, 20)
        Me.btnFAHConfig.TabIndex = 2
        Me.btnFAHConfig.Text = "3. F@H Config"
        Me.btnFAHConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHConfig, "Setup Folding@Home: Username, Team, Passkey Config")
        Me.btnFAHConfig.UseVisualStyleBackColor = True
        '
        'lblWalletNum
        '
        Me.lblWalletNum.AutoSize = True
        Me.lblWalletNum.Location = New System.Drawing.Point(115, 25)
        Me.lblWalletNum.Name = "lblWalletNum"
        Me.lblWalletNum.Size = New System.Drawing.Size(72, 13)
        Me.lblWalletNum.TabIndex = 5
        Me.lblWalletNum.Text = "Use Wallet #:"
        '
        'btnCurePool
        '
        Me.btnCurePool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCurePool.Location = New System.Drawing.Point(516, 20)
        Me.btnCurePool.Name = "btnCurePool"
        Me.btnCurePool.Size = New System.Drawing.Size(75, 21)
        Me.btnCurePool.TabIndex = 18
        Me.btnCurePool.Text = "Pool Login"
        Me.btnCurePool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCurePool, "Login to the CureCoin Folding Pool")
        Me.btnCurePool.UseVisualStyleBackColor = True
        '
        'chkShowTools
        '
        Me.chkShowTools.AutoSize = True
        Me.chkShowTools.Checked = True
        Me.chkShowTools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowTools.Location = New System.Drawing.Point(7, 9)
        Me.chkShowTools.Name = "chkShowTools"
        Me.chkShowTools.Size = New System.Drawing.Size(52, 17)
        Me.chkShowTools.TabIndex = 0
        Me.chkShowTools.Text = "Tools"
        Me.chkShowTools.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinTwitter
        '
        Me.btnFoldingCoinTwitter.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnFoldingCoinTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinTwitter.Location = New System.Drawing.Point(241, 20)
        Me.btnFoldingCoinTwitter.Name = "btnFoldingCoinTwitter"
        Me.btnFoldingCoinTwitter.Size = New System.Drawing.Size(60, 21)
        Me.btnFoldingCoinTwitter.TabIndex = 13
        Me.btnFoldingCoinTwitter.Text = "Twitter"
        Me.btnFoldingCoinTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinTwitter, "FoldingCoin Twitter")
        Me.btnFoldingCoinTwitter.UseVisualStyleBackColor = False
        '
        'btnCureCoinTwitter
        '
        Me.btnCureCoinTwitter.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCureCoinTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinTwitter.Location = New System.Drawing.Point(461, 20)
        Me.btnCureCoinTwitter.Name = "btnCureCoinTwitter"
        Me.btnCureCoinTwitter.Size = New System.Drawing.Size(60, 21)
        Me.btnCureCoinTwitter.TabIndex = 19
        Me.btnCureCoinTwitter.Text = "Twitter"
        Me.btnCureCoinTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinTwitter, "CureCoin Twitter")
        Me.btnCureCoinTwitter.UseVisualStyleBackColor = False
        '
        'btnFoldingCoinBlockchain
        '
        Me.btnFoldingCoinBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinBlockchain.Location = New System.Drawing.Point(242, 0)
        Me.btnFoldingCoinBlockchain.Name = "btnFoldingCoinBlockchain"
        Me.btnFoldingCoinBlockchain.Size = New System.Drawing.Size(78, 21)
        Me.btnFoldingCoinBlockchain.TabIndex = 11
        Me.btnFoldingCoinBlockchain.Text = "Blockchain"
        Me.btnFoldingCoinBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinBlockchain, "FoldingCoin & CounterParty Tokens Blockchain Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doesn't show BTC transact" &
        "ions)")
        Me.btnFoldingCoinBlockchain.UseVisualStyleBackColor = True
        '
        'btnEOC
        '
        Me.btnEOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEOC.Location = New System.Drawing.Point(597, 0)
        Me.btnEOC.Name = "btnEOC"
        Me.btnEOC.Size = New System.Drawing.Size(77, 41)
        Me.btnEOC.TabIndex = 22
        Me.btnEOC.Text = "F@H Stats"
        Me.btnEOC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEOC, "Extreme Overclocking Folding Stats")
        Me.btnEOC.UseVisualStyleBackColor = True
        '
        'btnCureCoinBlockchain
        '
        Me.btnCureCoinBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinBlockchain.Location = New System.Drawing.Point(462, 0)
        Me.btnCureCoinBlockchain.Name = "btnCureCoinBlockchain"
        Me.btnCureCoinBlockchain.Size = New System.Drawing.Size(78, 21)
        Me.btnCureCoinBlockchain.TabIndex = 17
        Me.btnCureCoinBlockchain.Text = "Blockchain"
        Me.btnCureCoinBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinBlockchain, "CureCoin Blockchain Explorer")
        Me.btnCureCoinBlockchain.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinSlack
        '
        Me.btnFoldingCoinSlack.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFoldingCoinSlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinSlack.ForeColor = System.Drawing.Color.White
        Me.btnFoldingCoinSlack.Location = New System.Drawing.Point(348, 0)
        Me.btnFoldingCoinSlack.Name = "btnFoldingCoinSlack"
        Me.btnFoldingCoinSlack.Size = New System.Drawing.Size(47, 21)
        Me.btnFoldingCoinSlack.TabIndex = 14
        Me.btnFoldingCoinSlack.Text = "Slack"
        Me.btnFoldingCoinSlack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinSlack, "Contact us on the FoldingCoin Slack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Questions and Comments")
        Me.btnFoldingCoinSlack.UseVisualStyleBackColor = False
        '
        'btnBTCBlockchain
        '
        Me.btnBTCBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBTCBlockchain.Location = New System.Drawing.Point(314, 0)
        Me.btnBTCBlockchain.Name = "btnBTCBlockchain"
        Me.btnBTCBlockchain.Size = New System.Drawing.Size(41, 21)
        Me.btnBTCBlockchain.TabIndex = 12
        Me.btnBTCBlockchain.Text = "BTC"
        Me.btnBTCBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBTCBlockchain, "BTC Only Blockchain Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doesn't show Counterparty Tokens)")
        Me.btnBTCBlockchain.UseVisualStyleBackColor = True
        '
        'btnCureCoinSlack
        '
        Me.btnCureCoinSlack.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCureCoinSlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinSlack.ForeColor = System.Drawing.Color.White
        Me.btnCureCoinSlack.Location = New System.Drawing.Point(535, 0)
        Me.btnCureCoinSlack.Name = "btnCureCoinSlack"
        Me.btnCureCoinSlack.Size = New System.Drawing.Size(47, 21)
        Me.btnCureCoinSlack.TabIndex = 20
        Me.btnCureCoinSlack.Text = "Slack"
        Me.btnCureCoinSlack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinSlack, "Contact us on the CureCoin Slack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Questions and Comments")
        Me.btnCureCoinSlack.UseVisualStyleBackColor = False
        '
        'txtMsg
        '
        Me.txtMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.Location = New System.Drawing.Point(787, 0)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(77, 73)
        Me.txtMsg.TabIndex = 25
        '
        'gbxCheckboxForTools
        '
        Me.gbxCheckboxForTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCheckboxForTools.Controls.Add(Me.chkShowTools)
        Me.gbxCheckboxForTools.Location = New System.Drawing.Point(1149, 42)
        Me.gbxCheckboxForTools.Name = "gbxCheckboxForTools"
        Me.gbxCheckboxForTools.Size = New System.Drawing.Size(63, 28)
        Me.gbxCheckboxForTools.TabIndex = 27
        Me.gbxCheckboxForTools.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 21)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblPercent
        '
        Me.lblPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.SystemColors.Window
        Me.lblPercent.Location = New System.Drawing.Point(43, 18)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(23, 13)
        Me.lblPercent.TabIndex = 1
        Me.lblPercent.Text = "0%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDownload
        '
        Me.gbxDownload.BackColor = System.Drawing.SystemColors.Info
        Me.gbxDownload.Controls.Add(Me.lblPercent)
        Me.gbxDownload.Controls.Add(Me.ProgressBar1)
        Me.gbxDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDownload.Location = New System.Drawing.Point(676, 4)
        Me.gbxDownload.Name = "gbxDownload"
        Me.gbxDownload.Size = New System.Drawing.Size(108, 42)
        Me.gbxDownload.TabIndex = 24
        Me.gbxDownload.TabStop = False
        Me.gbxDownload.Text = "Download:"
        Me.gbxDownload.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(1154, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 140
        Me.PictureBox2.TabStop = False
        '
        'btnFLDC_Distribution
        '
        Me.btnFLDC_Distribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFLDC_Distribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFLDC_Distribution.Location = New System.Drawing.Point(298, 20)
        Me.btnFLDC_Distribution.Name = "btnFLDC_Distribution"
        Me.btnFLDC_Distribution.Size = New System.Drawing.Size(80, 21)
        Me.btnFLDC_Distribution.TabIndex = 15
        Me.btnFLDC_Distribution.Text = "Distribution"
        Me.btnFLDC_Distribution.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFLDC_Distribution.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 708)
        Me.Controls.Add(Me.gbxDownload)
        Me.Controls.Add(Me.btnBrowserTools)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.gbxTools)
        Me.Controls.Add(Me.btnFwd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnEOC)
        Me.Controls.Add(Me.btnCureCoin)
        Me.Controls.Add(Me.btnFoldingCoinWebsite)
        Me.Controls.Add(Me.btnFAHControl)
        Me.Controls.Add(Me.btnMyWallet)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.btnStopNav)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnFoldingCoinTwitter)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.gbxCheckboxForTools)
        Me.Controls.Add(Me.btnCureCoinBlockchain)
        Me.Controls.Add(Me.btnFoldingCoinBlockchain)
        Me.Controls.Add(Me.btnBTCBlockchain)
        Me.Controls.Add(Me.btnFoldingCoinSlack)
        Me.Controls.Add(Me.btnCureCoinSlack)
        Me.Controls.Add(Me.btnFLDC_Distribution)
        Me.Controls.Add(Me.btnCureCoinTwitter)
        Me.Controls.Add(Me.btnCurePool)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(16, 38)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.gbxTools.ResumeLayout(False)
        Me.gbxTools.PerformLayout()
        Me.gbxCheckboxForTools.ResumeLayout(False)
        Me.gbxCheckboxForTools.PerformLayout()
        Me.gbxDownload.ResumeLayout(False)
        Me.gbxDownload.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStopNav As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnGetWallet As System.Windows.Forms.Button
    Friend WithEvents btnMyWallet As System.Windows.Forms.Button
    Friend WithEvents btnGetFAH As System.Windows.Forms.Button
    Friend WithEvents btnFAHControl As System.Windows.Forms.Button
    Friend WithEvents btnBrowserTools As System.Windows.Forms.Button
    Friend WithEvents btnFoldingCoinWebsite As System.Windows.Forms.Button
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
    Friend WithEvents btnFoldingCoinTwitter As Button
    Friend WithEvents btnCureCoinTwitter As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnFAHConfig As Button
    Friend WithEvents btnEOC As Button
    Friend WithEvents cbxWalletId As ComboBox
    Friend WithEvents lblWalletNum As Label
    Friend WithEvents txtWalletName As TextBox
    Friend WithEvents btnSavedData As Button
    Friend WithEvents btnFoldingCoinBlockchain As Button
    Friend WithEvents btnCureCoinBlockchain As Button
    Friend WithEvents btnCureCoinSetup As Button
    Friend WithEvents btnCurePool As Button
    Friend WithEvents btnFoldingCoinSlack As Button
    Friend WithEvents btnBTCBlockchain As Button
    Friend WithEvents btnCureCoinSlack As Button
    Friend WithEvents btnFLDC_Distribution As Button
End Class
